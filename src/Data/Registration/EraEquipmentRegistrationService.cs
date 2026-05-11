using System;
using System.Collections.Generic;
using System.Linq;
using EraWheel.Assets;
using EraWheel.Core.Logging;
using EraWheel.Data.Definitions;
using EraWheel.HotReload;
using EraWheel.Localization;
using NeoModLoader.General;

namespace EraWheel.Data.Registration;

public sealed class EraEquipmentRegistrationReport
{
    public int RegisteredCount { get; }
    public int SkippedCount { get; }

    public EraEquipmentRegistrationReport(int registeredCount, int skippedCount)
    {
        RegisteredCount = registeredCount;
        SkippedCount = skippedCount;
    }

    public string CreateStatusReport()
    {
        return $"轮回装备注册={RegisteredCount}，跳过={SkippedCount}。";
    }
}

public static class EraEquipmentRegistrationService
{
    public static EraEquipmentRegistrationReport Register(EraContentCatalog contentCatalog, EraSpriteCatalog spriteCatalog, bool reloadMode = false)
    {
        int registeredCount = 0;
        int skippedCount = 0;

        if (reloadMode)
        {
            EraAssetReconciliationService.RemoveEquipmentFromPools(
                contentCatalog.HeritageEquipment.Select(item => item.EquipmentId)
            );
        }

        foreach (EraHeritageEquipmentManifest equipment in contentCatalog.HeritageEquipment)
        {
            if (RegisterEquipment(equipment, spriteCatalog, reloadMode))
            {
                registeredCount++;
            }
            else
            {
                skippedCount++;
            }
        }

        SortPoolsByEquipmentValue();
        if (LocalizedTextManager.instance != null)
        {
            LM.ApplyLocale(false);
        }

        return new EraEquipmentRegistrationReport(registeredCount, skippedCount);
    }

    private static bool RegisterEquipment(EraHeritageEquipmentManifest equipment, EraSpriteCatalog spriteCatalog, bool reloadMode)
    {
        if (!reloadMode && AssetManager.items.has(equipment.EquipmentId))
        {
            EraLog.Warning(EraLogCategory.Data, $"轮回装备已存在，跳过重复注册：{equipment.EquipmentId}");
            return false;
        }

        if (!EraHeritageEquipmentSlotSpecs.TryGet(equipment.SlotKind, out EraHeritageEquipmentSlotSpec slotSpec))
        {
            EraLog.Error(EraLogCategory.Data, $"轮回装备缺少槽位规格，已跳过：{equipment.EquipmentId} -> {equipment.SlotKind}");
            return false;
        }

        EquipmentAsset? baseTemplate = AssetManager.items.get(slotSpec.BaseTemplateId);
        if (baseTemplate == null)
        {
            EraLog.Error(EraLogCategory.Data, $"轮回装备缺少可用母版，已跳过：{equipment.EquipmentId} -> {slotSpec.BaseTemplateId}");
            return false;
        }

        EquipmentAsset? visualReference = AssetManager.items.get(slotSpec.VisualReferenceAssetId);
        if (visualReference == null)
        {
            EraLog.Error(
                EraLogCategory.Data,
                $"轮回装备缺少可用外观引用，已跳过：{equipment.EquipmentId} -> {slotSpec.VisualReferenceAssetId}"
            );
            return false;
        }

        AssetManager.items.clone(out EquipmentAsset cloned, baseTemplate);
        cloned.id = equipment.EquipmentId;
        ConfigureEquipment(cloned, slotSpec, visualReference, equipment, spriteCatalog);
        EquipmentAsset registered = AssetManager.items.add(cloned);
        RegisterPools(registered);
        RegisterLocale(registered, equipment);
        return true;
    }

    private static void ConfigureEquipment(
        EquipmentAsset asset,
        EraHeritageEquipmentSlotSpec slotSpec,
        EquipmentAsset visualReference,
        EraHeritageEquipmentManifest manifest,
        EraSpriteCatalog spriteCatalog
    )
    {
        ClearInheritedAugmentationData(asset);
        asset.translation_key = BuildNameLocaleKey(manifest);
        asset.has_locales = true;
        asset.show_in_meta_editor = true;
        asset.show_in_knowledge_window = true;
        asset.can_be_given = true;
        asset.can_be_removed = true;
        asset.mod_can_be_given = true;
        asset.material = "basic";
        asset.equipment_type = slotSpec.EquipmentType;
        asset.equipment_subtype = slotSpec.EquipmentSubtype;
        asset.group_id = slotSpec.GroupId;
        asset.is_pool_weapon = slotSpec.IsPoolWeapon;
        if (slotSpec.AttackType.HasValue)
        {
            asset.attack_type = slotSpec.AttackType.Value;
        }

        asset.path_slash_animation = slotSpec.PathSlashAnimation;
        asset.projectile = slotSpec.Projectile;
        if (slotSpec.RigidityRating.HasValue)
        {
            asset.rigidity_rating = slotSpec.RigidityRating.Value;
        }

        asset.minimum_city_storage_resource_1 = manifest.MinimumCityStorageResource1;
        asset.equipment_value = manifest.EquipmentValue;
        asset.setCost(
            manifest.GoldCost,
            manifest.PrimaryResourceId,
            manifest.PrimaryResourceCost,
            manifest.SecondaryResourceId,
            manifest.SecondaryResourceCost
        );
        asset.cost_coins_resources = CalculateResourceCoinCost(manifest);
        asset.path_icon = ResolveIconPath(manifest, spriteCatalog);
        asset.gameplay_sprites = visualReference.gameplay_sprites;
        asset.path_gameplay_sprite = visualReference.path_gameplay_sprite;
        asset.name_templates = asset.name_templates != null ? new List<string>(asset.name_templates) : new List<string>();
        ApplyBaseStatOverrides(asset, slotSpec);
    }

    private static void ClearInheritedAugmentationData(EquipmentAsset asset)
    {
        asset.achievement_id = null;
        asset.unlocked_with_achievement = false;
        asset.item_modifier_ids = Array.Empty<string>();
        asset.item_modifiers = Array.Empty<ItemModAsset>();
        asset.spells_ids = new List<string>();
        asset.spells = new List<SpellAsset>();
    }

    private static void ApplyBaseStatOverrides(EquipmentAsset asset, EraHeritageEquipmentSlotSpec slotSpec)
    {
        if (slotSpec.BaseStatOverrides.Count == 0)
        {
            return;
        }

        asset.base_stats ??= new BaseStats();
        foreach (KeyValuePair<string, float> entry in slotSpec.BaseStatOverrides)
        {
            asset.base_stats[entry.Key] = entry.Value;
        }
    }

    private static int CalculateResourceCoinCost(EraHeritageEquipmentManifest manifest)
    {
        int total = 0;
        total += GetResourceMoneyCost(manifest.PrimaryResourceId) * manifest.PrimaryResourceCost;
        total += GetResourceMoneyCost(manifest.SecondaryResourceId) * manifest.SecondaryResourceCost;
        return total;
    }

    private static int GetResourceMoneyCost(string resourceId)
    {
        if (string.IsNullOrWhiteSpace(resourceId))
        {
            return 0;
        }

        ResourceAsset? resource = AssetManager.resources.get(resourceId);
        return resource?.money_cost ?? 0;
    }

    private static void RegisterPools(EquipmentAsset asset)
    {
        if (!AssetManager.items.equipment_by_subtypes.TryGetValue(asset.equipment_subtype, out List<EquipmentAsset>? subtypePool))
        {
            subtypePool = new List<EquipmentAsset>();
            AssetManager.items.equipment_by_subtypes[asset.equipment_subtype] = subtypePool;
        }

        if (!subtypePool.Contains(asset))
        {
            subtypePool.Add(asset);
        }

        if (asset.is_pool_weapon)
        {
            if (!AssetManager.items.pot_weapon_assets_all.Contains(asset))
            {
                AssetManager.items.pot_weapon_assets_all.Add(asset);
            }

            return;
        }

        if (!AssetManager.items.pot_equipment_by_groups_all.TryGetValue(asset.group_id, out List<EquipmentAsset>? groupPool))
        {
            groupPool = new List<EquipmentAsset>();
            AssetManager.items.pot_equipment_by_groups_all[asset.group_id] = groupPool;
        }

        if (!groupPool.Contains(asset))
        {
            groupPool.Add(asset);
        }
    }

    private static void SortPoolsByEquipmentValue()
    {
        foreach (List<EquipmentAsset> subtypePool in AssetManager.items.equipment_by_subtypes.Values)
        {
            SortPool(subtypePool);
        }

        foreach (List<EquipmentAsset> groupPool in AssetManager.items.pot_equipment_by_groups_all.Values)
        {
            SortPool(groupPool);
        }

        foreach (List<EquipmentAsset> groupPool in AssetManager.items.pot_equipment_by_groups_unlocked.Values)
        {
            SortPool(groupPool);
        }

        SortPool(AssetManager.items.pot_weapon_assets_all);
        SortPool(AssetManager.items.pot_weapon_assets_unlocked);
    }

    private static void SortPool(List<EquipmentAsset> pool)
    {
        pool.Sort(
            (left, right) =>
            {
                int byValue = left.equipment_value.CompareTo(right.equipment_value);
                if (byValue != 0)
                {
                    return byValue;
                }

                return string.Compare(left.id, right.id, StringComparison.Ordinal);
            }
        );
    }

    private static void RegisterLocale(EquipmentAsset asset, EraHeritageEquipmentManifest manifest)
    {
        string nameKey = BuildNameLocaleKey(manifest);
        string descriptionKey = asset.getDescriptionID();
        string descriptionText = BuildDescriptionText(manifest);

        EraLocaleRegistrar.AddZhEn(nameKey, manifest.DisplayName, manifest.DisplayName);
        if (!string.IsNullOrWhiteSpace(descriptionKey))
        {
            EraLocaleRegistrar.AddZhEn(descriptionKey, descriptionText, descriptionText);
        }
    }

    private static string BuildNameLocaleKey(EraHeritageEquipmentManifest manifest)
    {
        return $"{manifest.EquipmentId}_name";
    }

    private static string BuildDescriptionText(EraHeritageEquipmentManifest manifest)
    {
        return EraHeritagePresentation.BuildStaticPrimaryText(manifest);
    }

    private static string FormatParameterValue(EraHeritageEffectParameter parameter)
    {
        string valueText = Math.Abs(parameter.MaxValue - parameter.MinValue) > 0.001f
            ? $"{parameter.MinValue:0.##}~{parameter.MaxValue:0.##}"
            : $"{parameter.MinValue:0.##}";

        string suffix = parameter.Unit switch
        {
            EraHeritageParameterUnit.Percent => "%",
            EraHeritageParameterUnit.Multiplier => "x",
            EraHeritageParameterUnit.Seconds => "秒",
            EraHeritageParameterUnit.Years => "年",
            EraHeritageParameterUnit.Tiles => "格",
            EraHeritageParameterUnit.Count => "个",
            EraHeritageParameterUnit.HitPoints => "HP",
            _ => string.Empty,
        };
        return valueText + suffix;
    }

    private static string ResolveIconPath(EraHeritageEquipmentManifest manifest, EraSpriteCatalog spriteCatalog)
    {
        if (spriteCatalog.HeritageEquipmentById.TryGetValue(manifest.EquipmentId, out EraIndexedSpriteSet? set) &&
            set.Icon != null &&
            !string.IsNullOrWhiteSpace(set.Icon.RuntimePathId))
        {
            return set.Icon.RuntimePathId;
        }

        return manifest.IconSourcePath;
    }
}
