using System;
using System.Collections.Generic;
using System.Reflection;
using EraWheel.Combat.Statuses;
using EraWheel.Core;
using EraWheel.Core.Logging;
using EraWheel.Data.Definitions;
using EraWheel.Data.Registration;
using EraWheel.Save.Models;
using HarmonyLib;
using UnityEngine.UI;

namespace EraWheel.UI;

public static class EraHeritageTooltipPatches
{
    private static readonly object EquipmentDisplayContextLock = new();
    private static readonly Stack<HeritageEquipmentDisplayContext> EquipmentDisplayContextStack = new();
    private static readonly Type[] TooltipBaseStatsSignature =
    {
        typeof(Text),
        typeof(Text),
        typeof(BaseStats),
        typeof(bool),
    };
    private static readonly Type[] WindowBaseStatsSignature =
    {
        typeof(BaseStatsHelper.KeyValueFieldGetter),
        typeof(BaseStats),
        typeof(bool),
    };

    private static bool _patched;

    private sealed class HeritageEquipmentDisplayContext
    {
        public long ItemId { get; }
        public IReadOnlyList<EraAttributeModifierEntry> Attributes { get; }

        public HeritageEquipmentDisplayContext(long itemId, IReadOnlyList<EraAttributeModifierEntry> attributes)
        {
            ItemId = itemId;
            Attributes = attributes ?? Array.Empty<EraAttributeModifierEntry>();
        }
    }

    public static void Install()
    {
        if (_patched)
        {
            return;
        }

        Harmony harmony = new("EraWheel.HeritageTooltips");
        PatchPostfix(harmony, typeof(TooltipLibrary), "showTrait", nameof(AfterShowTrait));
        PatchScopedDisplay(harmony, typeof(TooltipLibrary), "showEquipment", nameof(BeforeShowEquipment));
        PatchPostfix(harmony, typeof(TooltipLibrary), "showEquipmentInEditor", nameof(AfterShowEquipmentInEditor));
        PatchScopedDisplay(harmony, typeof(ItemWindow), "showStatsRows", nameof(BeforeItemWindowStatsRows));
        PatchPrefix(harmony, typeof(BaseStatsHelper), "showBaseStats", TooltipBaseStatsSignature, nameof(BeforeShowBaseStats));
        PatchPrefix(harmony, typeof(BaseStatsHelper), "showBaseStatsRows", WindowBaseStatsSignature, nameof(BeforeShowBaseStatsRows));
        _patched = true;
        EraLog.Info(EraLogCategory.Debug, "轮回特质/装备展示补丁已安装。");
    }

    private static void PatchPostfix(Harmony harmony, Type targetType, string targetName, string postfixName)
    {
        MethodInfo? target = AccessTools.Method(targetType, targetName);
        MethodInfo? postfix = AccessTools.Method(typeof(EraHeritageTooltipPatches), postfixName);
        if (target == null || postfix == null)
        {
            EraLog.Warning(EraLogCategory.Debug, $"轮回展示补丁跳过：{targetType.Name}.{targetName}。");
            return;
        }

        harmony.Patch(target, postfix: new HarmonyMethod(postfix));
    }

    private static void PatchPrefix(
        Harmony harmony,
        Type targetType,
        string targetName,
        Type[] targetSignature,
        string prefixName)
    {
        MethodInfo? target = AccessTools.Method(targetType, targetName, targetSignature);
        MethodInfo? prefix = AccessTools.Method(typeof(EraHeritageTooltipPatches), prefixName);
        if (target == null || prefix == null)
        {
            EraLog.Warning(EraLogCategory.Debug, $"轮回展示补丁跳过：{targetType.Name}.{targetName}。");
            return;
        }

        harmony.Patch(target, prefix: new HarmonyMethod(prefix));
    }

    private static void PatchScopedDisplay(Harmony harmony, Type targetType, string targetName, string prefixName)
    {
        MethodInfo? target = AccessTools.Method(targetType, targetName);
        MethodInfo? prefix = AccessTools.Method(typeof(EraHeritageTooltipPatches), prefixName);
        MethodInfo? finalizer = AccessTools.Method(typeof(EraHeritageTooltipPatches), nameof(FinallyDisplayScope));
        if (target == null || prefix == null || finalizer == null)
        {
            EraLog.Warning(EraLogCategory.Debug, $"轮回展示补丁跳过：{targetType.Name}.{targetName}。");
            return;
        }

        harmony.Patch(
            target,
            prefix: new HarmonyMethod(prefix),
            finalizer: new HarmonyMethod(finalizer)
        );
    }

    private static void AfterShowTrait(Tooltip pTooltip, string pType, TooltipData pData)
    {
        ActorTrait? trait = pData?.trait;
        if (trait == null)
        {
            return;
        }

        if (!EraRuntimeBootstrap.ContentCatalog.HeritageTraitsById.TryGetValue(trait.id, out EraHeritageTraitManifest manifest))
        {
            return;
        }

        SetDescription(pTooltip, EraHeritagePresentation.BuildStaticPrimaryText(manifest));
        if (!pData.is_editor_augmentation_button &&
            SelectedUnit.unit != null &&
            SelectedUnit.unit.hasTrait(trait.id) &&
            EraRuntimeBootstrap.ProgressionRuntime?.GetTraitInstanceState(SelectedUnit.unit, trait.id) is { } state)
        {
            SetBottomDescription(pTooltip, string.Empty);
            ShowInstanceStatsBlock(pTooltip, state.Attributes);
            return;
        }

        SetBottomDescription(pTooltip, EraHeritagePresentation.BuildStaticSecondaryText(manifest));
        HideOriginalStatsBlock(pTooltip);
    }

    private static void BeforeShowEquipment(Tooltip pTooltip, string pType, TooltipData pData, out bool __state)
    {
        __state = TryPushEquipmentDisplayContext(pData?.item);
    }

    private static void AfterShowEquipmentInEditor(Tooltip pTooltip, string pType, TooltipData pData)
    {
        EquipmentAsset? asset = pData?.item_asset;
        if (asset == null ||
            !asset.isAvailable() ||
            !TryGetHeritageEquipmentManifest(asset, out EraHeritageEquipmentManifest manifest))
        {
            return;
        }

        SetBottomDescription(pTooltip, EraHeritagePresentation.BuildStaticSecondaryText(manifest));
        HideOriginalStatsBlock(pTooltip);
    }

    private static void BeforeItemWindowStatsRows(ItemWindow __instance, out bool __state)
    {
        __state = TryPushEquipmentDisplayContext(SelectedMetas.selected_item);
    }

    private static Exception? FinallyDisplayScope(bool __state, Exception? __exception)
    {
        PopEquipmentDisplayContext(__state);
        return __exception;
    }

    private static void BeforeShowBaseStats(ref BaseStats pBaseStats)
    {
        pBaseStats = BuildMergedDisplayBaseStats(pBaseStats);
    }

    private static void BeforeShowBaseStatsRows(ref BaseStats pBaseStats)
    {
        pBaseStats = BuildMergedDisplayBaseStats(pBaseStats);
    }

    private static void HideOriginalStatsBlock(Tooltip tooltip)
    {
        if (tooltip.stats_description != null)
        {
            tooltip.stats_description.text = string.Empty;
        }

        if (tooltip.stats_values != null)
        {
            tooltip.stats_values.text = string.Empty;
        }

        tooltip.stats_container?.SetActive(false);
    }

    private static void ShowInstanceStatsBlock(Tooltip tooltip, IEnumerable<EraAttributeModifierEntry>? attributes)
    {
        if (tooltip.stats_description == null || tooltip.stats_values == null || tooltip.stats_container == null)
        {
            return;
        }

        if (!EraHeritagePresentation.TryBuildInstanceStatsBlock(attributes, out string statsDescription, out string statsValues))
        {
            HideOriginalStatsBlock(tooltip);
            return;
        }

        tooltip.stats_description.text = statsDescription;
        tooltip.stats_values.text = WrapPositiveStatsWithGreen(statsValues);
        tooltip.stats_container.SetActive(true);
    }

    private static bool TryPushEquipmentDisplayContext(Item? item)
    {
        if (!TryGetHeritageEquipmentManifest(item?.asset, out _))
        {
            return false;
        }

        EraEquipmentInstanceAttributeState? state = item != null
            ? EraRuntimeBootstrap.ProgressionRuntime?.GetEquipmentInstanceState(item)
            : null;
        HeritageEquipmentDisplayContext context = new(
            item?.getID() ?? 0L,
            CloneAttributes(state?.Attributes)
        );
        lock (EquipmentDisplayContextLock)
        {
            EquipmentDisplayContextStack.Push(context);
        }

        return true;
    }

    private static void PopEquipmentDisplayContext(bool pushed)
    {
        if (!pushed)
        {
            return;
        }

        lock (EquipmentDisplayContextLock)
        {
            if (EquipmentDisplayContextStack.Count > 0)
            {
                EquipmentDisplayContextStack.Pop();
            }
        }
    }

    private static HeritageEquipmentDisplayContext? PeekEquipmentDisplayContext()
    {
        lock (EquipmentDisplayContextLock)
        {
            return EquipmentDisplayContextStack.Count > 0
                ? EquipmentDisplayContextStack.Peek()
                : null;
        }
    }

    private static BaseStats? BuildMergedDisplayBaseStats(BaseStats? baseStats)
    {
        HeritageEquipmentDisplayContext? context = PeekEquipmentDisplayContext();
        if (baseStats == null || context == null || context.Attributes.Count == 0)
        {
            return baseStats;
        }

        BaseStats merged = CloneBaseStats(baseStats);
        bool changed = false;
        foreach (EraAttributeModifierEntry entry in context.Attributes)
        {
            if (entry == null ||
                string.IsNullOrWhiteSpace(entry.AttributeId) ||
                Math.Abs(entry.Value) <= 0.0001f ||
                AssetManager.base_stats_library == null ||
                !AssetManager.base_stats_library.has(entry.AttributeId))
            {
                continue;
            }

            merged[entry.AttributeId] = merged.get(entry.AttributeId) + entry.Value;
            changed = true;
        }

        return changed ? merged : baseStats;
    }

    private static BaseStats CloneBaseStats(BaseStats source)
    {
        if (source.Clone() is BaseStats clone)
        {
            return clone;
        }

        BaseStats fallback = new BaseStats();
        foreach (BaseStatsContainer? container in source.getList())
        {
            if (container == null || string.IsNullOrWhiteSpace(container.id))
            {
                continue;
            }

            fallback[container.id] = source.get(container.id);
        }

        return fallback;
    }

    private static IReadOnlyList<EraAttributeModifierEntry> CloneAttributes(IEnumerable<EraAttributeModifierEntry>? attributes)
    {
        List<EraAttributeModifierEntry> result = new();
        if (attributes == null)
        {
            return result;
        }

        foreach (EraAttributeModifierEntry entry in attributes)
        {
            if (entry == null || string.IsNullOrWhiteSpace(entry.AttributeId))
            {
                continue;
            }

            result.Add(
                new EraAttributeModifierEntry
                {
                    AttributeId = entry.AttributeId,
                    Value = entry.Value,
                }
            );
        }

        return result;
    }

    private static bool TryGetHeritageEquipmentManifest(EquipmentAsset? asset, out EraHeritageEquipmentManifest manifest)
    {
        manifest = null!;
        return asset != null &&
               EraRuntimeBootstrap.ContentCatalog.HeritageEquipmentById.TryGetValue(asset.id, out manifest);
    }

    private static string WrapPositiveStatsWithGreen(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return string.Empty;
        }

        string[] lines = value.Split('\n');
        for (int index = 0; index < lines.Length; index++)
        {
            string line = lines[index];
            if (!string.IsNullOrWhiteSpace(line) && !line.StartsWith("<color=", StringComparison.Ordinal))
            {
                lines[index] = $"<color=#43FF43>{line}</color>";
            }
        }

        return string.Join("\n", lines);
    }

    private static void SetDescription(Tooltip tooltip, string text)
    {
        if (tooltip.description == null)
        {
            return;
        }

        tooltip.description.text = text ?? string.Empty;
        tooltip.description.transform.parent?.gameObject.SetActive(!string.IsNullOrEmpty(tooltip.description.text));
    }

    private static void SetBottomDescription(Tooltip tooltip, string text)
    {
        if (tooltip.description_2 == null)
        {
            return;
        }

        tooltip.description_2.text = text ?? string.Empty;
        tooltip.description_2.transform.parent?.gameObject.SetActive(!string.IsNullOrEmpty(tooltip.description_2.text));
    }
}
