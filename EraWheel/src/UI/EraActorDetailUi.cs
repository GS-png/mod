using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using EraWheel.Config;
using EraWheel.Core;
using EraWheel.Core.Logging;
using EraWheel.Localization;
using EraWheel.Save.Keys;
using EraWheel.Save.Models;
using EraWheel.Systems.Levels;
using HarmonyLib;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.UI;

namespace EraWheel.UI;

public static class EraActorDetailUi
{
    private const string LevelTabId = "ew_actor_levels_bonus";
    private const string LevelTabLabelKey = EraLocaleKeys.UiActorDetailTabLevels;
    private const string LevelTabDescriptionKey = EraLocaleKeys.UiActorDetailTabLevelsDescription;
    private const string HeroStatusRowKey = EraLocaleKeys.UiActorDetailRowHeroStatus;
    private const string LineageSummaryRowKey = EraLocaleKeys.UiActorDetailRowLineageSummary;
    // Observed: 原版 WindowFavorites.setupSortingTabs() 直接使用 ui/Icons/iconLevels 作为等级排序按钮图标。
    private const string LevelTabIconPath = "ui/Icons/iconLevels";
    private static readonly BindingFlags AnyInstance = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
    private static readonly MethodInfo? ShowStatRowMethod = typeof(StatsWindow).GetMethod(
        "showStatRow",
        BindingFlags.Instance | BindingFlags.NonPublic,
        null,
        new[]
        {
            typeof(string),
            typeof(object),
            typeof(MetaType),
            typeof(long),
            typeof(string),
            typeof(string),
            typeof(TooltipDataGetter),
        },
        null
    );
    private static readonly FieldInfo? TabsField = typeof(WindowMetaTabButtonsContainer).GetField("_tabs", AnyInstance);
    private static readonly MethodInfo? RefillTabsWithContentMethod = typeof(WindowMetaTabButtonsContainer).GetMethod("refillTabsWithContent", AnyInstance);
    private static readonly FieldInfo? TabContainerField = typeof(WindowMetaTab).GetField("container", AnyInstance);
    private static readonly FieldInfo? WorldTipTextField = typeof(WindowMetaTab).GetField("_worldtip_text", AnyInstance);
    private static readonly MethodInfo? GetWorldTipTextMethod = typeof(WindowMetaTab).GetMethod("getWorldTipText", AnyInstance);
    private static readonly FieldInfo? EquipmentEditorTabField = typeof(UnitWindow).GetField("_button_equipment_editor", AnyInstance);

    private static bool _patched;
    private static readonly Dictionary<int, LevelTabViewState> LevelTabStates = new();
    private static readonly HashSet<string> LoggedDiagnostics = new(StringComparer.Ordinal);

    public static void Install()
    {
        if (_patched)
        {
            return;
        }

        MethodInfo? target = typeof(UnitWindow).GetMethod(
            "showStatsRows",
            BindingFlags.Instance | BindingFlags.NonPublic
        );
        MethodInfo? postfix = typeof(EraActorDetailUi).GetMethod(
            nameof(OnShowStatsRows),
            BindingFlags.Static | BindingFlags.NonPublic
        );

        if (target != null && postfix != null)
        {
            Harmony harmony = new("EraWheel.ActorDetails");
            harmony.Patch(target, postfix: new HarmonyMethod(postfix));
        }

        _patched = true;
    }

    private static void OnShowStatsRows(UnitWindow __instance)
    {
        if (!EraConfig.EnableActorDetailPatch || __instance == null)
        {
            return;
        }

        Actor? actor = SelectedUnit.unit;
        if (actor == null)
        {
            return;
        }

        string lastSuccessfulStep = "selected_actor_ready";
        try
        {
            InjectDetailRows(__instance, actor, ref lastSuccessfulStep);
            LogDetailDiagnosisOnce(__instance, actor, lastSuccessfulStep, null);
        }
        catch (Exception exception)
        {
            LogDetailDiagnosisOnce(__instance, actor, lastSuccessfulStep, exception);
            throw;
        }
    }

    // 这里既要保留原版详情窗口的 tab 生命周期，又要插入新的“等级加成”页签。
    // 做法是沿用原版 WindowMetaTabButtonsContainer，只在运行时补注册新 tab，而不改原版窗口 prefab。
    private static void InjectDetailRows(UnitWindow window, Actor actor, ref string lastSuccessfulStep)
    {
        if (window == null || ShowStatRowMethod == null)
        {
            return;
        }

        if (EnsureLevelTab(window, actor))
        {
            lastSuccessfulStep = "level_tab_ready";
        }

        EraHeroProgressionState? heroState = ReadHeroState(actor);
        lastSuccessfulStep = "hero_state_ready";
        if (ShowStatRow(window, HeroStatusRowKey, BuildHeroStatusText(heroState)))
        {
            lastSuccessfulStep = "hero_status_row_ready";
        }

        if (ShowStatRow(window, LineageSummaryRowKey, BuildLineageText(actor)))
        {
            lastSuccessfulStep = "stat_rows_injected";
        }
    }

    private static bool EnsureLevelTab(UnitWindow window, Actor actor)
    {
        PruneDestroyedTabStates();
        int windowId = window.GetInstanceID();
        if (!LevelTabStates.TryGetValue(windowId, out LevelTabViewState? state) || !state.IsAlive)
        {
            state = CreateLevelTabViewState(window);
            if (state == null)
            {
                return false;
            }

            LevelTabStates[windowId] = state;
        }

        RefreshLevelTab(state, actor);
        return true;
    }

    private static LevelTabViewState? CreateLevelTabViewState(UnitWindow window)
    {
        ScrollWindow? scrollWindow = window.GetComponentInParent<ScrollWindow>();
        WindowMetaTabButtonsContainer? tabs = scrollWindow?.tabs;
        Transform? tabBar = tabs?.tab_default?.transform.parent;
        Transform? panelHost = GetPanelHost(tabs);
        if (scrollWindow == null || tabs == null || tabBar == null || panelHost == null)
        {
            return null;
        }

        float bodyWidth = EraUiLayoutPrimitives.ResolveBodyWidth(scrollWindow, 12f);
        float textWidth = Mathf.Max(116f, bodyWidth - 4f);
        WindowMetaTab? equipmentEditorTab = GetEquipmentEditorTab(window);
        if (equipmentEditorTab == null)
        {
            return null;
        }

        WindowMetaTab? tabButton = CloneOriginalTabButton(tabBar, tabs.tab_default, equipmentEditorTab);
        if (tabButton == null)
        {
            return null;
        }

        Transform panel = EraUiBuilder.CreateVerticalPanel(
            panelHost,
            "EraActorLevelsTabPanel",
            new Vector2(bodyWidth, 0f),
            3f,
            new RectOffset(0, 0, 0, 0)
        );
        panel.gameObject.SetActive(false);

        Text levelLabel = EraUiBuilder.CreateLabel(panel, "CurrentLevelLabel", 11, FontStyle.Bold, string.Empty, textWidth);
        Text summaryTitleLabel = EraUiBuilder.CreateLabel(panel, "LevelBonusSummaryTitleLabel", 10, FontStyle.Bold, "累计加成", textWidth);
        Transform detailsContainer = EraUiBuilder.CreateVerticalPanel(
            panel,
            "LevelBonusDetailsContainer",
            new Vector2(bodyWidth, 0f),
            1f,
            new RectOffset(0, 0, 0, 0)
        );

        if (!RegisterTab(tabs, tabButton, panel, equipmentEditorTab))
        {
            UnityEngine.Object.Destroy(panel.gameObject);
            UnityEngine.Object.Destroy(tabButton.gameObject);
            return null;
        }

        return new LevelTabViewState(window, tabButton, panel, levelLabel, summaryTitleLabel, detailsContainer, textWidth);
    }

    private static void RefreshLevelTab(LevelTabViewState state, Actor actor)
    {
        state.LevelLabel.text = $"当前等级：Lv{Math.Max(1, actor.level).ToString(CultureInfo.InvariantCulture)}";

        EraLevelRuntimeService? levelRuntime = EraRuntimeBootstrap.LevelRuntime;
        if (levelRuntime == null)
        {
            UpdateDetailLines(state, new[] { "等级运行时尚未初始化。" });
            return;
        }

        EraActorLevelLedgerState ledger = levelRuntime.GetActorLevelLedgerSnapshot(actor);
        UpdateDetailLines(
            state,
            EraDetailUiFormatter.BuildAttributeDetailLines(
                ToModifierEntries(ledger.TotalModifiers),
                EraConfig.Parameters.Levels.RandomAttributes.CandidateAttributeIds
            )
        );
    }

    private static IEnumerable<EraAttributeModifierEntry> ToModifierEntries(IReadOnlyDictionary<string, float>? values)
    {
        if (values == null)
        {
            yield break;
        }

        foreach ((string key, float value) in values)
        {
            yield return new EraAttributeModifierEntry
            {
                AttributeId = key,
                Value = value,
            };
        }
    }

    private static Transform? GetPanelHost(WindowMetaTabButtonsContainer? tabs)
    {
        if (tabs == null)
        {
            return null;
        }

        foreach (WindowMetaTab tab in tabs.getContentTabs())
        {
            if (tab?.tab_elements == null || tab.tab_elements.Count == 0 || tab.tab_elements[0] == null)
            {
                continue;
            }

            return tab.tab_elements[0].parent;
        }

        return null;
    }

    private static bool RegisterTab(WindowMetaTabButtonsContainer tabs, WindowMetaTab tabButton, Transform panel, WindowMetaTab anchorTab)
    {
        if (TabsField?.GetValue(tabs) is not List<WindowMetaTab> tabList)
        {
            EraLog.Warning(EraLogCategory.Reflection, "单位详情等级页签创建失败：未找到原版 tab 列表字段。");
            return false;
        }

        if (!InsertTabAfterAnchor(tabList, tabButton, anchorTab))
        {
            return false;
        }

        TabContainerField?.SetValue(tabButton, tabs);
        if (tabs.addTabContent(tabButton, panel) == null)
        {
            tabList.Remove(tabButton);
            EraLog.Warning(EraLogCategory.Validation, "单位详情等级页签创建失败：无法把内容面板挂到新页签。");
            return false;
        }

        tabButton.tab_action.AddListener(_ => tabs.showTab(tabButton));
        RefillTabsWithContentMethod?.Invoke(tabs, null);
        return true;
    }

    private static WindowMetaTab? CloneOriginalTabButton(Transform tabBar, WindowMetaTab template, WindowMetaTab anchorTab)
    {
        Sprite? iconSprite = SpriteTextureLoader.getSprite(LevelTabIconPath);
        if (iconSprite == null)
        {
            EraLog.Warning(EraLogCategory.Validation, $"单位详情等级页签创建失败：未找到原版等级图标 {LevelTabIconPath}。");
            return null;
        }

        GameObject buttonObject = UnityEngine.Object.Instantiate(template.gameObject, tabBar, false);
        buttonObject.name = "EraActorLevelsTabButton";
        buttonObject.SetActive(true);
        if (!TryPlaceTabButtonAfterAnchor(buttonObject.transform, anchorTab))
        {
            UnityEngine.Object.Destroy(buttonObject);
            return null;
        }

        WindowMetaTab? tabButton = buttonObject.GetComponent<WindowMetaTab>();
        Button? button = buttonObject.GetComponent<Button>();
        if (tabButton == null || button == null)
        {
            EraLog.Warning(EraLogCategory.Validation, "单位详情等级页签创建失败：克隆出来的原版按钮骨架缺少 WindowMetaTab 或 Button 组件。");
            UnityEngine.Object.Destroy(buttonObject);
            return null;
        }

        tabButton.name = LevelTabId;
        tabButton.tab_action = new WindowMetaTabEvent();
        tabButton.tab_elements = new List<Transform>();

        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(tabButton.doAction);

        ConfigureTabTip(tabButton, LevelTabLabelKey, LevelTabDescriptionKey);
        if (!TryAssignTabIcon(tabButton.transform, iconSprite))
        {
            EraLog.Warning(EraLogCategory.Validation, "单位详情等级页签创建失败：原版按钮骨架里没有可用的图标槽。");
            UnityEngine.Object.Destroy(buttonObject);
            return null;
        }

        HideTabTexts(tabButton.transform);
        return tabButton;
    }

    private static WindowMetaTab? GetEquipmentEditorTab(UnitWindow window)
    {
        if (EquipmentEditorTabField == null)
        {
            EraLog.Warning(EraLogCategory.Reflection, "单位详情等级页签创建失败：未找到 UnitWindow._button_equipment_editor 字段。");
            return null;
        }

        WindowMetaTab? tab = EquipmentEditorTabField.GetValue(window) as WindowMetaTab;
        if (tab == null)
        {
            EraLog.Warning(EraLogCategory.Reflection, "单位详情等级页签创建失败：运行时未返回装备编辑器按钮实例。");
        }

        return tab;
    }

    private static bool TryPlaceTabButtonAfterAnchor(Transform tabTransform, WindowMetaTab anchorTab)
    {
        Transform? anchorTransform = anchorTab?.transform;
        if (anchorTransform == null)
        {
            EraLog.Warning(EraLogCategory.Validation, "单位详情等级页签创建失败：装备编辑器按钮实例已失效。");
            return false;
        }

        if (tabTransform.parent != anchorTransform.parent)
        {
            EraLog.Warning(EraLogCategory.Validation, "单位详情等级页签创建失败：装备编辑器按钮不在当前 tab 容器中。");
            return false;
        }

        tabTransform.SetSiblingIndex(anchorTransform.GetSiblingIndex() + 1);
        return true;
    }

    private static bool InsertTabAfterAnchor(List<WindowMetaTab> tabList, WindowMetaTab tabButton, WindowMetaTab anchorTab)
    {
        int anchorIndex = tabList.IndexOf(anchorTab);
        if (anchorIndex < 0)
        {
            EraLog.Warning(EraLogCategory.Validation, "单位详情等级页签创建失败：原版 tab 列表里没有装备编辑器按钮。");
            return false;
        }

        int existingIndex = tabList.IndexOf(tabButton);
        if (existingIndex >= 0)
        {
            tabList.RemoveAt(existingIndex);
            if (existingIndex < anchorIndex)
            {
                anchorIndex--;
            }
        }

        int targetIndex = Math.Min(anchorIndex + 1, tabList.Count);
        tabList.Insert(targetIndex, tabButton);
        return true;
    }

    private static bool TryAssignTabIcon(Transform tabTransform, Sprite sprite)
    {
        Image[] images = tabTransform.GetComponentsInChildren<Image>(true);
        Image? rootImage = tabTransform.GetComponent<Image>();
        Image? iconImage = images.FirstOrDefault(
            image => image != null
                && image.transform != tabTransform
                && image.gameObject.name.Contains("icon", StringComparison.OrdinalIgnoreCase)
        );
        iconImage ??= images.FirstOrDefault(
            image => image != null
                && image.transform != tabTransform
                && image.type != Image.Type.Sliced
                && image.sprite != null
                && image.sprite != rootImage?.sprite
        );
        iconImage ??= images.FirstOrDefault(image => image != null && image.transform != tabTransform);
        if (iconImage == null)
        {
            return false;
        }

        iconImage.gameObject.SetActive(true);
        iconImage.sprite = sprite;
        iconImage.overrideSprite = sprite;
        iconImage.type = Image.Type.Simple;
        iconImage.preserveAspect = true;
        iconImage.color = Color.white;
        return true;
    }

    private static void HideTabTexts(Transform tabTransform)
    {
        foreach (Text text in tabTransform.GetComponentsInChildren<Text>(true))
        {
            text.gameObject.SetActive(false);
        }
    }

    private static void ConfigureTabTip(WindowMetaTab tabButton, string labelKey, string descriptionKey)
    {
        TipButton? tip = tabButton.GetComponent<TipButton>();
        if (tip == null)
        {
            return;
        }

        tip.textOnClick = labelKey;
        tip.textOnClickDescription = descriptionKey;
        if (WorldTipTextField != null && GetWorldTipTextMethod != null)
        {
            WorldTipTextField.SetValue(tabButton, GetWorldTipTextMethod.Invoke(tabButton, null));
        }
    }

    private static void UpdateDetailLines(LevelTabViewState state, IReadOnlyList<string> lines)
    {
        for (int index = 0; index < lines.Count; index++)
        {
            Text label = EnsureDetailLabel(state, index);
            label.text = lines[index];
            if (!label.gameObject.activeSelf)
            {
                label.gameObject.SetActive(true);
            }
        }

        for (int index = lines.Count; index < state.DetailLabels.Count; index++)
        {
            state.DetailLabels[index].gameObject.SetActive(false);
        }

        if (state.Panel is RectTransform panelRect)
        {
            LayoutRebuilder.ForceRebuildLayoutImmediate(panelRect);
        }
    }

    private static Text EnsureDetailLabel(LevelTabViewState state, int index)
    {
        while (state.DetailLabels.Count <= index)
        {
            Text label = EraUiBuilder.CreateLabel(
                state.DetailsContainer,
                $"LevelBonusDetailLabel_{state.DetailLabels.Count}",
                10,
                FontStyle.Normal,
                string.Empty,
                state.TextWidth
            );
            state.DetailLabels.Add(label);
        }

        return state.DetailLabels[index];
    }

    private static void PruneDestroyedTabStates()
    {
        List<int> staleKeys = new();
        foreach ((int key, LevelTabViewState state) in LevelTabStates)
        {
            if (!state.IsAlive)
            {
                staleKeys.Add(key);
            }
        }

        foreach (int key in staleKeys)
        {
            LevelTabStates.Remove(key);
        }
    }

    private static string BuildHeroStatusText(EraHeroProgressionState? state)
    {
        if (state == null)
        {
            return "未触及英雄状态";
        }

        StringBuilder builder = new();
        builder.Append(state.IsHero ? "英雄：已晋升" : "英雄：未晋升");

        if (!string.IsNullOrWhiteSpace(state.PromotionReason))
        {
            builder.Append("；").Append(state.PromotionReason);
        }

        if (!string.IsNullOrWhiteSpace(state.TitleSuffix))
        {
            builder.Append("；头衔后缀：").Append(state.TitleSuffix);
        }

        if (state.Promotion?.Attributes.Any() == true)
        {
            builder.Append("；晋升加成：").Append(FormatAttributeSummary(state.Promotion.Attributes));
        }

        if (state.Inheritance?.Attributes.Any() == true)
        {
            builder.Append("；承袭加成：").Append(FormatAttributeSummary(state.Inheritance.Attributes));
        }

        return builder.ToString();
    }

    private static string BuildLineageText(Actor actor)
    {
        long root = GetCustomLong(actor, EraEntityCustomDataKeys.HeroBloodlineRootId);
        int generation = GetCustomInt(actor, EraEntityCustomDataKeys.HeroBloodlineGeneration);
        bool awakened = GetCustomBool(actor, EraEntityCustomDataKeys.HeroAwakened);
        float survivorPercent = GetCustomFloat(actor, EraEntityCustomDataKeys.HeroSurvivorBonusPercent);

        string rootName = root > 0 ? FormatActorReference(root) : "普通血脉";
        string generationText = generation >= 0 ? $"世代 {generation}" : "世代未知";
        string awakenedText = awakened ? "已觉醒" : "未觉醒";
        string survivorText = survivorPercent >= 0 ? survivorPercent.ToString("P0", CultureInfo.InvariantCulture) : "0%";

        return $"{rootName}；{generationText}；{awakenedText}；幸存强化 {survivorText}";
    }

    private static string FormatActorReference(long id)
    {
        return EraDetailUiFormatter.FormatActorReference(id);
    }

    private static string FormatAttributeSummary(IEnumerable<EraAttributeModifierEntry>? entries)
    {
        return EraDetailUiFormatter.FormatAttributeSummary(entries);
    }

    private static EraHeroProgressionState? ReadHeroState(Actor actor)
    {
        if (actor?.getData() is not BaseSystemData data)
        {
            return null;
        }

        data.get(EraProgressionDataKeys.ActorHeroState, out string json, string.Empty);
        if (string.IsNullOrWhiteSpace(json))
        {
            return null;
        }

        try
        {
            return JsonConvert.DeserializeObject<EraHeroProgressionState>(json);
        }
        catch
        {
            return null;
        }
    }

    private static bool ShowStatRow(UnitWindow window, string label, string value)
    {
        if (ShowStatRowMethod == null)
        {
            return false;
        }

        ShowStatRowMethod.Invoke(window, new object?[]
        {
            label,
            value,
            MetaType.None,
            -1L,
            null,
            null,
            null,
        });
        return true;
    }

    private static void LogDetailDiagnosisOnce(UnitWindow window, Actor actor, string lastSuccessfulStep, Exception? exception)
    {
        long actorId = actor.getID();
        string activeTab = ResolveActiveTab(window);
        string status = exception == null ? "ok" : $"error:{exception.GetType().Name}";
        string signature = $"actor|{actorId}|{window.GetInstanceID()}|{activeTab}|{lastSuccessfulStep}|{status}";
        if (!LoggedDiagnostics.Add(signature))
        {
            return;
        }

        string message =
            $"详情诊断 actor=#{actorId}；window={window.GetInstanceID()}；activeTab={activeTab}；lastStep={lastSuccessfulStep}。";
        if (exception == null)
        {
            EraLog.Info(EraLogCategory.Debug, message);
            return;
        }

        EraLog.Exception(EraLogCategory.Debug, message, exception);
    }

    private static string ResolveActiveTab(UnitWindow window)
    {
        ScrollWindow? scrollWindow = window.GetComponentInParent<ScrollWindow>();
        WindowMetaTab? activeTab = scrollWindow?.tabs?.getActiveTab();
        if (activeTab != null && !string.IsNullOrWhiteSpace(activeTab.name))
        {
            return activeTab.name;
        }

        return "unknown";
    }

    private static bool GetCustomBool(Actor actor, EraEntityCustomDataKey key)
    {
        if (actor?.getData() is BaseSystemData data)
        {
            data.get(key.Key, out bool result, false);
            return result;
        }

        return false;
    }

    private static int GetCustomInt(Actor actor, EraEntityCustomDataKey key)
    {
        if (actor?.getData() is BaseSystemData data)
        {
            data.get(key.Key, out int result, -1);
            return result;
        }

        return -1;
    }

    private static long GetCustomLong(Actor actor, EraEntityCustomDataKey key)
    {
        if (actor?.getData() is BaseSystemData data)
        {
            data.get(key.Key, out long result, 0L);
            return result;
        }

        return 0L;
    }

    private static float GetCustomFloat(Actor actor, EraEntityCustomDataKey key)
    {
        if (actor?.getData() is BaseSystemData data)
        {
            data.get(key.Key, out float result, 0f);
            return result;
        }

        return 0f;
    }

    private sealed class LevelTabViewState
    {
        public UnitWindow Window { get; }
        public WindowMetaTab TabButton { get; }
        public Transform Panel { get; }
        public Text LevelLabel { get; }
        public Text SummaryTitleLabel { get; }
        public Transform DetailsContainer { get; }
        public float TextWidth { get; }
        public List<Text> DetailLabels { get; } = new();

        public bool IsAlive =>
            Window != null
            && TabButton != null
            && Panel != null
            && LevelLabel != null
            && SummaryTitleLabel != null
            && DetailsContainer != null;

        public LevelTabViewState(
            UnitWindow window,
            WindowMetaTab tabButton,
            Transform panel,
            Text levelLabel,
            Text summaryTitleLabel,
            Transform detailsContainer,
            float textWidth)
        {
            Window = window;
            TabButton = tabButton;
            Panel = panel;
            LevelLabel = levelLabel;
            SummaryTitleLabel = summaryTitleLabel;
            DetailsContainer = detailsContainer;
            TextWidth = textWidth;
        }
    }
}
