using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using EraWheel.Config;
using EraWheel.Core;
using EraWheel.Core.Logging;
using EraWheel.Localization;
using EraWheel.Save.Models;
using EraWheel.Systems.Advancement;
using EraWheel.Systems.Kingdoms;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;

namespace EraWheel.UI;

public static class EraKingdomDetailUi
{
    private const string RenownTabId = "ew_kingdom_renown_bonus";
    private const string RenownTabLabelKey = EraLocaleKeys.UiKingdomDetailTabRenown;
    private const string RenownTabDescriptionKey = EraLocaleKeys.UiKingdomDetailTabRenownDescription;
    private const string TierSummaryRowKey = EraLocaleKeys.UiKingdomDetailRowTierSummary;
    // Observed: 原版 WindowFavorites.setupSortingTabs() 直接使用 ui/Icons/iconRenown 作为声望排序按钮图标。
    private const string RenownTabIconPath = "ui/Icons/iconRenown";
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
    private static readonly MethodInfo? GetEditorTabMethod = typeof(ITraitsEditor<KingdomTrait>).GetMethod("getEditorTab", AnyInstance);

    private static bool _patched;
    private static readonly Dictionary<int, RenownTabViewState> RenownTabStates = new();
    private static readonly HashSet<string> LoggedDiagnostics = new(StringComparer.Ordinal);

    public static void Install()
    {
        if (_patched)
        {
            return;
        }

        MethodInfo? target = typeof(KingdomWindow).GetMethod(
            "showStatsRows",
            BindingFlags.Instance | BindingFlags.NonPublic
        );
        MethodInfo? postfix = typeof(EraKingdomDetailUi).GetMethod(
            nameof(OnShowStatsRows),
            BindingFlags.Static | BindingFlags.NonPublic
        );
        if (target != null && postfix != null)
        {
            Harmony harmony = new("EraWheel.KingdomDetails");
            harmony.Patch(target, postfix: new HarmonyMethod(postfix));
        }

        _patched = true;
    }

    private static void OnShowStatsRows(KingdomWindow __instance)
    {
        if (!EraConfig.EnableKingdomDetailPatch || __instance == null)
        {
            return;
        }

        Kingdom? kingdom = SelectedMetas.selected_kingdom;
        if (kingdom == null)
        {
            return;
        }

        string lastSuccessfulStep = "selected_kingdom_ready";
        try
        {
            InjectDetailRows(__instance, kingdom, ref lastSuccessfulStep);
            LogDetailDiagnosisOnce(__instance, kingdom, lastSuccessfulStep, null);
        }
        catch (Exception exception)
        {
            LogDetailDiagnosisOnce(__instance, kingdom, lastSuccessfulStep, exception);
            throw;
        }
    }

    private static void InjectDetailRows(KingdomWindow window, Kingdom kingdom, ref string lastSuccessfulStep)
    {
        if (window == null || ShowStatRowMethod == null)
        {
            return;
        }

        if (EnsureRenownTab(window, kingdom))
        {
            lastSuccessfulStep = "renown_tab_ready";
        }

        EraAdvancementRuntimeService? advancement = EraRuntimeBootstrap.AdvancementRuntime;
        if (advancement == null)
        {
            if (ShowStatRow(window, TierSummaryRowKey, "轮回进阶尚未初始化"))
            {
                lastSuccessfulStep = "tier_summary_fallback_ready";
            }

            return;
        }

        lastSuccessfulStep = "advancement_runtime_ready";
        EraKingdomTierState? tierState = advancement.GetKingdomTierState(kingdom);
        if (ShowStatRow(window, TierSummaryRowKey, BuildTierSummary(advancement, tierState)))
        {
            lastSuccessfulStep = "stat_rows_injected";
        }
    }

    private static bool EnsureRenownTab(KingdomWindow window, Kingdom kingdom)
    {
        PruneDestroyedTabStates();
        int windowId = window.GetInstanceID();
        if (!RenownTabStates.TryGetValue(windowId, out RenownTabViewState? state) || !state.IsAlive)
        {
            state = CreateRenownTabViewState(window);
            if (state == null)
            {
                return false;
            }

            RenownTabStates[windowId] = state;
        }

        RefreshRenownTab(state, kingdom);
        return true;
    }

    private static RenownTabViewState? CreateRenownTabViewState(KingdomWindow window)
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
        WindowMetaTab? kingdomEditorTab = GetKingdomEditorTab(window);
        if (kingdomEditorTab == null)
        {
            return null;
        }

        WindowMetaTab? tabButton = CloneOriginalTabButton(tabBar, kingdomEditorTab);
        if (tabButton == null)
        {
            return null;
        }

        Transform panel = EraUiBuilder.CreateVerticalPanel(
            panelHost,
            "EraKingdomRenownTabPanel",
            new Vector2(bodyWidth, 0f),
            3f,
            new RectOffset(0, 0, 0, 0)
        );
        panel.gameObject.SetActive(false);

        Text levelLabel = EraUiBuilder.CreateLabel(panel, "RenownLevelLabel", 11, FontStyle.Bold, string.Empty, textWidth);
        Text renownLabel = EraUiBuilder.CreateLabel(panel, "TotalRenownLabel", 10, FontStyle.Normal, string.Empty, textWidth);
        Text summaryTitleLabel = EraUiBuilder.CreateLabel(panel, "RenownBonusSummaryTitleLabel", 10, FontStyle.Bold, "累计加成", textWidth);
        Transform detailsContainer = EraUiBuilder.CreateVerticalPanel(
            panel,
            "RenownBonusDetailsContainer",
            new Vector2(bodyWidth, 0f),
            1f,
            new RectOffset(0, 0, 0, 0)
        );

        if (!RegisterTab(tabs, tabButton, panel, kingdomEditorTab))
        {
            UnityEngine.Object.Destroy(panel.gameObject);
            UnityEngine.Object.Destroy(tabButton.gameObject);
            return null;
        }

        return new RenownTabViewState(window, tabButton, panel, levelLabel, renownLabel, summaryTitleLabel, detailsContainer, textWidth);
    }

    private static void RefreshRenownTab(RenownTabViewState state, Kingdom kingdom)
    {
        EraKingdomRuntimeService? kingdomRuntime = EraRuntimeBootstrap.KingdomRuntime;
        if (kingdomRuntime == null)
        {
            state.LevelLabel.text = "当前声望等级：未知";
            state.RenownLabel.text = "累计总声望：未知";
            UpdateDetailLines(state, new[] { "王国声望运行时尚未初始化。" });
            return;
        }

        EraKingdomRenownSnapshot? snapshot = kingdomRuntime.GetKingdomRenownSnapshot(kingdom);
        if (snapshot == null)
        {
            state.LevelLabel.text = "当前声望等级：Lv0";
            state.RenownLabel.text = "累计总声望：0";
            UpdateDetailLines(
                state,
                EraDetailUiFormatter.BuildAttributeDetailLines(
                    Array.Empty<EraAttributeModifierEntry>(),
                    EraConfig.Parameters.Kingdoms.RandomAttributes.CandidateAttributeIds
                )
            );
            return;
        }

        state.LevelLabel.text = $"当前声望等级：Lv{snapshot.CurrentLevel.ToString(CultureInfo.InvariantCulture)}";
        state.RenownLabel.text = $"累计总声望：{snapshot.TotalAccumulatedRenown.ToString(CultureInfo.InvariantCulture)}";
        UpdateDetailLines(
            state,
            EraDetailUiFormatter.BuildAttributeDetailLines(
                ToModifierEntries(snapshot.TotalModifiers),
                EraConfig.Parameters.Kingdoms.RandomAttributes.CandidateAttributeIds
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
            EraLog.Warning(EraLogCategory.Reflection, "王国详情声望页签创建失败：未找到原版 tab 列表字段。");
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
            EraLog.Warning(EraLogCategory.Validation, "王国详情声望页签创建失败：无法把内容面板挂到新页签。");
            return false;
        }

        tabButton.tab_action.AddListener(_ => tabs.showTab(tabButton));
        RefillTabsWithContentMethod?.Invoke(tabs, null);
        return true;
    }

    private static WindowMetaTab? CloneOriginalTabButton(Transform tabBar, WindowMetaTab anchorTab)
    {
        Sprite? iconSprite = SpriteTextureLoader.getSprite(RenownTabIconPath);
        if (iconSprite == null)
        {
            EraLog.Warning(EraLogCategory.Validation, $"王国详情声望页签创建失败：未找到原版声望图标 {RenownTabIconPath}。");
            return null;
        }

        GameObject buttonObject = UnityEngine.Object.Instantiate(anchorTab.gameObject, tabBar, false);
        buttonObject.name = "EraKingdomRenownTabButton";
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
            EraLog.Warning(EraLogCategory.Validation, "王国详情声望页签创建失败：克隆出来的原版按钮骨架缺少 WindowMetaTab 或 Button 组件。");
            UnityEngine.Object.Destroy(buttonObject);
            return null;
        }

        tabButton.name = RenownTabId;
        tabButton.tab_action = new WindowMetaTabEvent();
        tabButton.tab_elements = new List<Transform>();

        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(tabButton.doAction);

        ConfigureTabTip(tabButton, RenownTabLabelKey, RenownTabDescriptionKey);
        if (!TryAssignTabIcon(tabButton.transform, iconSprite))
        {
            EraLog.Warning(EraLogCategory.Validation, "王国详情声望页签创建失败：原版按钮骨架里没有可用的图标槽。");
            UnityEngine.Object.Destroy(buttonObject);
            return null;
        }

        HideTabTexts(tabButton.transform);
        return tabButton;
    }

    private static WindowMetaTab? GetKingdomEditorTab(KingdomWindow window)
    {
        IAugmentationsWindow<ITraitsEditor<KingdomTrait>>? traitsWindow = window as IAugmentationsWindow<ITraitsEditor<KingdomTrait>>;
        ITraitsEditor<KingdomTrait>? editor = traitsWindow?.getEditor();
        if (editor == null)
        {
            EraLog.Warning(EraLogCategory.Reflection, "王国详情声望页签创建失败：未找到王国原版 Traits editor 实例。");
            return null;
        }

        if (GetEditorTabMethod == null)
        {
            EraLog.Warning(EraLogCategory.Reflection, "王国详情声望页签创建失败：未找到原版 getEditorTab 入口。");
            return null;
        }

        WindowMetaTab? tab = GetEditorTabMethod.Invoke(editor, null) as WindowMetaTab;
        if (tab == null)
        {
            EraLog.Warning(EraLogCategory.Reflection, "王国详情声望页签创建失败：运行时未返回王国编辑器页签实例。");
        }

        return tab;
    }

    private static bool TryPlaceTabButtonAfterAnchor(Transform tabTransform, WindowMetaTab anchorTab)
    {
        Transform? anchorTransform = anchorTab?.transform;
        if (anchorTransform == null)
        {
            EraLog.Warning(EraLogCategory.Validation, "王国详情声望页签创建失败：王国编辑器按钮实例已失效。");
            return false;
        }

        if (tabTransform.parent != anchorTransform.parent)
        {
            EraLog.Warning(EraLogCategory.Validation, "王国详情声望页签创建失败：王国编辑器按钮不在当前 tab 容器中。");
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
            EraLog.Warning(EraLogCategory.Validation, "王国详情声望页签创建失败：原版 tab 列表里没有王国编辑器按钮。");
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
        Image? iconImage = Array.Find(
            images,
            image => image != null
                && image.transform != tabTransform
                && image.gameObject.name.Contains("icon", StringComparison.OrdinalIgnoreCase)
        );
        iconImage ??= Array.Find(
            images,
            image => image != null
                && image.transform != tabTransform
                && image.type != Image.Type.Sliced
                && image.sprite != null
                && image.sprite != rootImage?.sprite
        );
        iconImage ??= Array.Find(images, image => image != null && image.transform != tabTransform);
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

    private static void UpdateDetailLines(RenownTabViewState state, IReadOnlyList<string> lines)
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

    private static Text EnsureDetailLabel(RenownTabViewState state, int index)
    {
        while (state.DetailLabels.Count <= index)
        {
            Text label = EraUiBuilder.CreateLabel(
                state.DetailsContainer,
                $"RenownBonusDetailLabel_{state.DetailLabels.Count}",
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
        foreach ((int key, RenownTabViewState state) in RenownTabStates)
        {
            if (!state.IsAlive)
            {
                staleKeys.Add(key);
            }
        }

        foreach (int key in staleKeys)
        {
            RenownTabStates.Remove(key);
        }
    }

    private static string BuildTierSummary(EraAdvancementRuntimeService advancement, EraKingdomTierState? state)
    {
        if (state == null)
        {
            return $"世界档位 T{advancement.GetCurrentWorldTier()}；王国档位缓存尚未建立。";
        }

        string survivorText = state.IsSurvivorKingdom ? "幸存王国" : "新王国 / 普通王国";
        return $"世界档位 T{advancement.GetCurrentWorldTier()}；王国生效档位 T{state.EffectiveTier}；基础档位 T{state.BaseTier}；掌控度 {state.ControlScore:P0}；{survivorText}";
    }

    private static bool ShowStatRow(KingdomWindow window, string label, string value)
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

    private static void LogDetailDiagnosisOnce(KingdomWindow window, Kingdom kingdom, string lastSuccessfulStep, Exception? exception)
    {
        long kingdomId = kingdom.id;
        string activeTab = ResolveActiveTab(window);
        string status = exception == null ? "ok" : $"error:{exception.GetType().Name}";
        string signature = $"kingdom|{kingdomId}|{window.GetInstanceID()}|{activeTab}|{lastSuccessfulStep}|{status}";
        if (!LoggedDiagnostics.Add(signature))
        {
            return;
        }

        string message =
            $"详情诊断 kingdom=#{kingdomId}；window={window.GetInstanceID()}；activeTab={activeTab}；lastStep={lastSuccessfulStep}。";
        if (exception == null)
        {
            EraLog.Info(EraLogCategory.Debug, message);
            return;
        }

        EraLog.Exception(EraLogCategory.Debug, message, exception);
    }

    private static string ResolveActiveTab(KingdomWindow window)
    {
        ScrollWindow? scrollWindow = window.GetComponentInParent<ScrollWindow>();
        WindowMetaTab? activeTab = scrollWindow?.tabs?.getActiveTab();
        if (activeTab != null && !string.IsNullOrWhiteSpace(activeTab.name))
        {
            return activeTab.name;
        }

        return "unknown";
    }

    private sealed class RenownTabViewState
    {
        public KingdomWindow Window { get; }
        public WindowMetaTab TabButton { get; }
        public Transform Panel { get; }
        public Text LevelLabel { get; }
        public Text RenownLabel { get; }
        public Text SummaryTitleLabel { get; }
        public Transform DetailsContainer { get; }
        public float TextWidth { get; }
        public List<Text> DetailLabels { get; } = new();

        public bool IsAlive =>
            Window != null
            && TabButton != null
            && Panel != null
            && LevelLabel != null
            && RenownLabel != null
            && SummaryTitleLabel != null
            && DetailsContainer != null;

        public RenownTabViewState(
            KingdomWindow window,
            WindowMetaTab tabButton,
            Transform panel,
            Text levelLabel,
            Text renownLabel,
            Text summaryTitleLabel,
            Transform detailsContainer,
            float textWidth)
        {
            Window = window;
            TabButton = tabButton;
            Panel = panel;
            LevelLabel = levelLabel;
            RenownLabel = renownLabel;
            SummaryTitleLabel = summaryTitleLabel;
            DetailsContainer = detailsContainer;
            TextWidth = textWidth;
        }
    }
}
