using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using EraWheel.Assets;
using EraWheel.Config;
using EraWheel.Config.Schema;
using EraWheel.Core;
using EraWheel.Core.Constants;
using EraWheel.Core.Logging;
using EraWheel.Localization;
using NeoModLoader.General;
using NeoModLoader.General.UI.Prefabs;
using NeoModLoader.General.UI.Tab;
using NeoModLoader.api;
using NeoModLoader.api.attributes;
using NeoModLoader.ui;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Object = UnityEngine.Object;
using PrefabSwitchButton = NeoModLoader.General.UI.Prefabs.SwitchButton;

namespace EraWheel.UI;

public static class EraUiBootstrap
{
    private const string TopTabId = "erawheel";
    private const int TopTabVerboseLogThrottleFrames = 300;
    private static readonly BindingFlags AnyStatic = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
    private static readonly BindingFlags AnyInstance = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
    private static readonly FieldInfo? AllWindowsField = typeof(ScrollWindow).GetField("_all_windows", AnyStatic);
    private static readonly FieldInfo? PowersTabParentObjField = typeof(PowersTab).GetField("parentObj", AnyInstance);
    private static readonly int TopTabRetryIntervalFrames = 15;

    private static bool _initialized;
    private static PowersTab? _topTab;
    private static EraTopTabRegistrationState _topTabState = EraTopTabRegistrationState.NotStarted;
    private static int _topTabAttemptCount;
    private static int _topTabNextRetryFrame;
    private static string _topTabLastStatusDetail = "尚未开始注册。";
    private static string _topTabLastLoggedReport = string.Empty;
    private static EraTopTabRegistrationState _topTabLastLoggedState = EraTopTabRegistrationState.NotStarted;
    private static int _topTabNextVerboseLogFrame;
    private static readonly Dictionary<EraModuleId, PowerButton> ModuleButtons = new();
    private static readonly Dictionary<EraModuleId, EraUiWindowSpec> SpecsByModule = new();
    private static readonly Dictionary<EraModuleId, EraModuleWindowView> WindowsByModule = new();

    [Hotfixable]
    public static void Initialize()
    {
        if (_initialized)
        {
            RefreshOpenWindows();
            PumpTopTabRegistration();
            return;
        }

        BuildWindowSpecs();
        EnsureModuleWindows();
        if (EraConfig.EnableActorDetailPatch)
        {
            EraActorDetailUi.Install();
        }
        else
        {
            EraLog.Info(EraLogCategory.Debug, "角色详情补丁已按调试配置关闭，当前会跳过 actor detail 注入。");
        }

        if (EraConfig.EnableKingdomDetailPatch)
        {
            EraKingdomDetailUi.Install();
        }
        else
        {
            EraLog.Info(EraLogCategory.Debug, "王国详情补丁已按调试配置关闭，当前会跳过 kingdom detail 注入。");
        }

        EraHeritageTooltipPatches.Install();
        EraHudOverlay.Initialize();
        _initialized = true;
        EnsureTopTabRegistration("初始化阶段");
    }

    [Hotfixable]
    public static void ShowModule(EraModuleId moduleId)
    {
        if (!SpecsByModule.TryGetValue(moduleId, out EraUiWindowSpec? spec))
        {
            return;
        }

        ScrollWindow.showWindow(spec.WindowId);
        if (WindowsByModule.TryGetValue(moduleId, out EraModuleWindowView? view))
        {
            view.RefreshAll();
        }
    }

    [Hotfixable]
    public static void RefreshOpenWindows()
    {
        foreach (EraModuleWindowView view in WindowsByModule.Values)
        {
            view.RefreshAll();
        }
    }

    [Hotfixable]
    public static void PumpTopTabRegistration()
    {
        if (!_initialized || _topTabState == EraTopTabRegistrationState.Ready)
        {
            return;
        }

        if (Time.frameCount < _topTabNextRetryFrame)
        {
            return;
        }

        EnsureTopTabRegistration("每帧补挂");
    }

    [Hotfixable]
    public static string CreateTopTabStatusReport()
    {
        return $"顶层页签状态={GetTopTabStateLabel(_topTabState)}；尝试次数={_topTabAttemptCount}；下次重试帧={_topTabNextRetryFrame}；详情={_topTabLastStatusDetail}";
    }

    [Hotfixable]
    internal static Sprite ResolveEntryButtonIcon(EraModuleId moduleId)
    {
        EraSpriteResource? resource = ResolveUnifiedEntryButtonIconResource();
        if (resource?.Sprite != null)
        {
            return resource.Sprite;
        }

        return ResolveFallbackSprite();
    }

    [Hotfixable]
    internal static string CreateEntryButtonIconModeReport()
    {
        EraSpriteCatalog catalog = EraRuntimeBootstrap.SpriteCatalog;
        EraSpriteResource? resource = ResolveUnifiedEntryButtonIconResource();
        string source;
        string runtimePath;
        if (resource?.Sprite != null)
        {
            if (ReferenceEquals(resource, catalog.TopTabIcon))
            {
                source = "TopTabIcon(世纪轮回)";
            }
            else if (ReferenceEquals(resource, catalog.ModIcon))
            {
                source = "ModIcon";
            }
            else
            {
                source = "Custom";
            }

            runtimePath = resource.RuntimePathId;
        }
        else
        {
            source = "Fallback(iconOptions)";
            runtimePath = "ui/icons/iconOptions";
        }

        return $"入口图标模式=统一世纪轮回；来源={source}；运行时路径={runtimePath}";
    }

    private static EraSpriteResource? ResolveUnifiedEntryButtonIconResource()
    {
        EraSpriteCatalog catalog = EraRuntimeBootstrap.SpriteCatalog;
        if (catalog.TopTabIcon?.Sprite != null)
        {
            return catalog.TopTabIcon;
        }

        if (catalog.ModIcon?.Sprite != null)
        {
            return catalog.ModIcon;
        }

        return null;
    }

    private static void BuildWindowSpecs()
    {
        SpecsByModule.Clear();
        foreach (EraUiModuleDefinition module in EraUiContentFactory.GetModulesInOrder())
        {
            SpecsByModule[module.ModuleId] = new EraUiWindowSpec(
                module,
                GetWindowId(module.ModuleId),
                ResolveModuleIconResource(module.ModuleId)
            );
        }
    }

    private static void EnsureModuleWindows()
    {
        foreach (EraUiWindowSpec spec in SpecsByModule.Values)
        {
            if (WindowsByModule.ContainsKey(spec.Module.ModuleId))
            {
                continue;
            }

            WindowsByModule[spec.Module.ModuleId] = EraModuleWindowView.Create(spec);
        }
    }

    [Hotfixable]
    private static void EnsureTopTabRegistration(string reason)
    {
        _topTabAttemptCount++;
        try
        {
            RegisterTopTabCore();
            _topTabState = EraTopTabRegistrationState.Ready;
            _topTabNextRetryFrame = 0;
            _topTabLastStatusDetail = $"入口按钮={ModuleButtons.Count}个；触发原因={reason}。";
            LogTopTabStatusIfChanged();
        }
        catch (Exception ex)
        {
            _topTabState = _topTab == null
                ? EraTopTabRegistrationState.WaitingForTabObject
                : EraTopTabRegistrationState.WaitingForUnityLayout;
            _topTabNextRetryFrame = Time.frameCount + TopTabRetryIntervalFrames;
            _topTabLastStatusDetail = $"{reason}失败：{ex.GetType().Name}: {ex.Message}";
            LogTopTabStatusIfChanged(EraConfig.EnableTopTabRetryVerboseLog);
        }
    }

    private static void RegisterTopTabCore()
    {
        _topTab = PowerButtonCreator.GetTab(TopTabId);
        if (_topTab == null)
        {
            _topTab = TabManager.CreateTab(
                TopTabId,
                EraLocaleKeys.UiTopTabTitle,
                EraLocaleKeys.UiTopTabDescription,
                SpecsByModule[EraModuleId.Guide].IconSprite
            );
        }

        EnsureTopTabLayoutReady(_topTab);

        Transform topTabTransform = _topTab.transform;
        List<Transform> staleSeparators = new List<Transform>();
        for (int childIndex = 0; childIndex < topTabTransform.childCount; childIndex++)
        {
            Transform child = topTabTransform.GetChild(childIndex);
            if (IsEraManagedSpacer(child))
            {
                staleSeparators.Add(child);
            }
        }

        foreach (Transform separator in staleSeparators)
        {
            Object.Destroy(separator.gameObject);
        }

        IReadOnlyList<EraUiModuleDefinition> modules = EraUiContentFactory.GetModulesInOrder();
        IReadOnlyList<EraUiModuleDefinition> displayOrder = GetEntryModulesInDisplayOrder(modules);

        HashSet<string> validButtonNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        for (int index = 0; index < displayOrder.Count; index++)
        {
            validButtonNames.Add(GetModuleButtonName(displayOrder[index].ModuleId));
        }

        Dictionary<string, PowerButton> existingButtonsByName = new(StringComparer.OrdinalIgnoreCase);
        List<Transform> staleModuleButtons = new();
        List<PowerButton> duplicateModuleButtons = new();
        for (int childIndex = 0; childIndex < topTabTransform.childCount; childIndex++)
        {
            Transform child = topTabTransform.GetChild(childIndex);
            if (!child.name.StartsWith("ew_module_", StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            if (!validButtonNames.Contains(child.name))
            {
                staleModuleButtons.Add(child);
                continue;
            }

            if (!child.TryGetComponent(out PowerButton childButton) || childButton == null)
            {
                staleModuleButtons.Add(child);
                continue;
            }

            if (!existingButtonsByName.TryAdd(child.name, childButton))
            {
                duplicateModuleButtons.Add(childButton);
            }
        }

        foreach (Transform staleButton in staleModuleButtons)
        {
            Object.Destroy(staleButton.gameObject);
        }
        foreach (PowerButton duplicateButton in duplicateModuleButtons)
        {
            Object.Destroy(duplicateButton.gameObject);
        }

        int firstModuleSiblingIndex = CountOriginalTopTabChildren(topTabTransform);
        for (int displayIndex = 0; displayIndex < displayOrder.Count; displayIndex++)
        {
            EraUiModuleDefinition module = displayOrder[displayIndex];
            string buttonName = GetModuleButtonName(module.ModuleId);
            PowerButton? button = null;
            if (ModuleButtons.TryGetValue(module.ModuleId, out PowerButton? existingButton) && existingButton != null)
            {
                button = existingButton;
            }
            else if (existingButtonsByName.TryGetValue(buttonName, out PowerButton? existingByName))
            {
                button = existingByName;
            }
            else
            {
                button = PowerButtonCreator.CreateWindowButton(
                    buttonName,
                    GetWindowId(module.ModuleId),
                    ResolveEntryButtonIcon(module.ModuleId)
                );
                PowerButtonCreator.AddButtonToTab(button, _topTab, siblingIndex: firstModuleSiblingIndex + displayIndex);
            }

            button.name = buttonName;
            button.transform.SetParent(topTabTransform, false);
            button.transform.SetSiblingIndex(firstModuleSiblingIndex + displayIndex);
            button.block_same_window = false;
            ModuleButtons[module.ModuleId] = button;
        }

        _topTab.sortButtons();
        _topTab.recalc();

        StringBuilder layoutOrderBuilder = new StringBuilder();
        for (int index = 0; index < displayOrder.Count; index++)
        {
            if (index > 0)
            {
                layoutOrderBuilder.Append(", ");
            }

            EraUiModuleDefinition module = displayOrder[index];
            PowerButton button = ModuleButtons[module.ModuleId];
            int siblingIndex = button.transform.GetSiblingIndex();
            layoutOrderBuilder.Append(index + 1)
                .Append(':')
                .Append(module.ModuleId)
                .Append("=>#")
                .Append(siblingIndex);
        }

        EraLog.Info(
            EraLogCategory.Debug,
            $"顶部入口布局已刷新：原版前置子物体数={firstModuleSiblingIndex}；显示顺序={layoutOrderBuilder}；残留清理=旧按钮{staleModuleButtons.Count}个/重复按钮{duplicateModuleButtons.Count}个。"
        );
    }

    private static void EnsureTopTabLayoutReady(PowersTab topTab)
    {
        if (PowersTabParentObjField?.GetValue(topTab) is not GameObject parentObj || parentObj == null)
        {
            throw new InvalidOperationException(
                $"PowersTab.parentObj 尚未就绪；frame={Time.frameCount}；tab子物体数={topTab.transform.childCount}"
            );
        }

        if (parentObj.GetComponent<RectTransform>() == null)
        {
            throw new InvalidOperationException(
                $"PowersTab.parentObj 缺少 RectTransform；对象={parentObj.name}"
            );
        }
    }

    private static void LogTopTabStatusIfChanged(bool allowVerboseFailure = false)
    {
        string report = CreateTopTabStatusReport();
        if (_topTabState == EraTopTabRegistrationState.Ready)
        {
            if (_topTabState == _topTabLastLoggedState &&
                string.Equals(report, _topTabLastLoggedReport, StringComparison.Ordinal))
            {
                return;
            }

            EraLog.Info(EraLogCategory.Startup, report);
            _topTabLastLoggedState = _topTabState;
            _topTabLastLoggedReport = report;
            _topTabNextVerboseLogFrame = 0;
            return;
        }

        bool stateChanged = _topTabState != _topTabLastLoggedState;
        bool throttleWindowOpen = Time.frameCount >= _topTabNextVerboseLogFrame;
        if (!stateChanged && (!allowVerboseFailure || !throttleWindowOpen))
        {
            return;
        }

        EraLog.Warning(
            EraLogCategory.Startup,
            $"顶层页签挂载未完成，已改为延迟重试，不影响核心 UI。{report}"
        );
        _topTabLastLoggedState = _topTabState;
        _topTabLastLoggedReport = report;
        _topTabNextVerboseLogFrame = Time.frameCount + TopTabVerboseLogThrottleFrames;
    }

    private static string GetTopTabStateLabel(EraTopTabRegistrationState state)
    {
        return state switch
        {
            EraTopTabRegistrationState.NotStarted => "未开始",
            EraTopTabRegistrationState.WaitingForTabObject => "等待页签对象",
            EraTopTabRegistrationState.WaitingForUnityLayout => "等待原版布局就绪",
            EraTopTabRegistrationState.Ready => "已就绪",
            _ => "未知"
        };
    }

    private static bool IsEraManagedTopTabChild(Transform child)
    {
        return IsEraModuleButton(child) || IsEraManagedSpacer(child);
    }

    private static bool IsEraModuleButton(Transform child)
    {
        return child.name.StartsWith("ew_module_", StringComparison.OrdinalIgnoreCase);
    }

    private static bool IsEraManagedSpacer(Transform child)
    {
        return child.name.StartsWith("_space_half_ew_group_", StringComparison.OrdinalIgnoreCase) ||
               child.name.StartsWith("_space_ew_group_", StringComparison.OrdinalIgnoreCase);
    }

    private static int CountOriginalTopTabChildren(Transform topTabTransform)
    {
        int count = 0;
        for (int childIndex = 0; childIndex < topTabTransform.childCount; childIndex++)
        {
            if (!IsEraManagedTopTabChild(topTabTransform.GetChild(childIndex)))
            {
                count++;
            }
        }

        return count;
    }

    private static string GetModuleButtonName(EraModuleId moduleId)
    {
        return $"ew_module_{moduleId.ToString().ToLowerInvariant()}";
    }

    private static IReadOnlyList<EraUiModuleDefinition> GetEntryModulesInDisplayOrder(
        IReadOnlyList<EraUiModuleDefinition> modules
    )
    {
        return modules;
    }

    private static EraSpriteResource? ResolveModuleIconResource(EraModuleId moduleId)
    {
        EraSpriteCatalog catalog = EraRuntimeBootstrap.SpriteCatalog;
        return moduleId switch
        {
            EraModuleId.Guide => catalog.TopTabIcon ?? catalog.ModIcon,
            EraModuleId.Reincarnation => ResolveIndexedIcon(catalog.HeritageEquipmentById, "eq_herit_t10_cycle_singularity_ring"),
            EraModuleId.Demons => ResolveDemonIcon(catalog, "demon_void_lord"),
            EraModuleId.Generals => ResolveUnitGroupIcon(catalog, catalog.GeneralUnitGroupKeysById, "general_void_lord_01"),
            EraModuleId.Legions => ResolveUnitGroupIcon(catalog, "魔王与将领图片/虚无之主/虚无之主军团"),
            EraModuleId.Advancement => ResolveIndexedIcon(catalog.HeritageTraitsById, "trait_herit_t9_eye_of_storm"),
            EraModuleId.Levels => ResolveIndexedIcon(catalog.PublicTraitsById, "trait_common_fast_leveling"),
            EraModuleId.Kingdoms => ResolveIndexedIcon(catalog.HeritageEquipmentById, "eq_herit_t9_crown_of_cities"),
            EraModuleId.Heroes => ResolveIndexedIcon(catalog.PublicTraitsById, "trait_common_bloodline"),
            EraModuleId.StoryGenerator => catalog.TopTabIcon ?? catalog.ModIcon,
            _ => catalog.TopTabIcon ?? catalog.ModIcon
        };
    }

    private static EraSpriteResource? ResolveIndexedIcon(
        IReadOnlyDictionary<string, EraIndexedSpriteSet> entries,
        string entryId)
    {
        return entries.TryGetValue(entryId, out EraIndexedSpriteSet? set) ? set.Icon : null;
    }

    private static EraSpriteResource? ResolveDemonIcon(EraSpriteCatalog catalog, string demonId)
    {
        return catalog.DemonsById.TryGetValue(demonId, out EraDemonSpriteSet? set) ? set.UnitIcon : null;
    }

    private static EraSpriteResource? ResolveUnitGroupIcon(
        EraSpriteCatalog catalog,
        IReadOnlyDictionary<string, string> unitGroupKeys,
        string entryId)
    {
        return unitGroupKeys.TryGetValue(entryId, out string? groupKey)
               && catalog.UnitGroupsByKey.TryGetValue(groupKey, out EraUnitSpriteSet? set)
            ? set.Icon
            : null;
    }

    private static EraSpriteResource? ResolveUnitGroupIcon(EraSpriteCatalog catalog, string groupKey)
    {
        return catalog.UnitGroupsByKey.TryGetValue(groupKey, out EraUnitSpriteSet? set) ? set.Icon : null;
    }

    private static Sprite ResolveFallbackSprite()
    {
        return SpriteTextureLoader.getSprite("ui/icons/iconOptions");
    }

    private static string GetWindowId(EraModuleId moduleId)
    {
        return moduleId switch
        {
            EraModuleId.Guide => EraWindowIds.Guide,
            EraModuleId.Reincarnation => EraWindowIds.Reincarnation,
            EraModuleId.Demons => EraWindowIds.Demons,
            EraModuleId.Generals => EraWindowIds.Generals,
            EraModuleId.Legions => EraWindowIds.Legions,
            EraModuleId.Advancement => EraWindowIds.Advancement,
            EraModuleId.Levels => EraWindowIds.Levels,
            EraModuleId.Kingdoms => EraWindowIds.Kingdoms,
            EraModuleId.Heroes => EraWindowIds.Heroes,
            EraModuleId.StoryGenerator => EraWindowIds.StoryGenerator,
            _ => EraWindowIds.Guide
        };
    }
}

internal enum EraTopTabRegistrationState
{
    NotStarted = 0,
    WaitingForTabObject = 1,
    WaitingForUnityLayout = 2,
    Ready = 3
}

internal sealed class EraUiWindowSpec
{
    public EraUiModuleDefinition Module { get; }
    public string WindowId { get; }
    public string IconRuntimePath { get; }
    public Sprite IconSprite { get; }

    public EraUiWindowSpec(EraUiModuleDefinition module, string windowId, EraSpriteResource? resource)
    {
        Module = module;
        WindowId = windowId;
        IconRuntimePath = resource?.RuntimePathId ?? "ui/icons/iconOptions";
        IconSprite = resource?.Sprite ?? SpriteTextureLoader.getSprite("ui/icons/iconOptions");
    }
}

internal sealed class EraModuleWindowView : MonoBehaviour
{
    private const float RootHorizontalPadding = 4f;
    private const float ActionButtonHeight = 28f;
    private const float ActionInputHeight = 28f;
    private const float TabHeight = 28f;
    private const float TabSpacing = 4f;
    private const float MinimumTabWidth = 48f;
    private const float SectionSpacing = 10f;
    private const float FixedTabInset = 6f;

    private readonly Dictionary<string, Action> _tabRefreshers = new();
    private readonly List<Action> _globalRefreshers = new();
    private readonly List<EraMetaTabEntry> _tabEntries = new();

    private bool _initialized;
    private EraUiWindowSpec? _spec;
    private ScrollWindow? _scrollWindow;
    private WindowMetaTabButtonsContainer? _tabsContainer;
    private RectTransform? _contentRootRect;
    private RectTransform? _scrollViewRect;
    private Transform? _tabBarTransform;
    private Transform? _panelHostTransform;
    private string? _activeTabId;
    private int _bestiaryIndex;
    private float _bodyWidth = 220f;

    public static EraModuleWindowView Create(EraUiWindowSpec spec)
    {
        ScrollWindow scrollWindow = WindowCreator.CreateEmptyWindow(spec.WindowId, spec.Module.NameKey, spec.IconRuntimePath);
        EraModuleWindowView view = scrollWindow.gameObject.GetComponent<EraModuleWindowView>();
        if (view == null)
        {
            view = scrollWindow.gameObject.AddComponent<EraModuleWindowView>();
        }

        view.Initialize(spec, scrollWindow);
        return view;
    }

    public void RefreshAll()
    {
        foreach (Action refresher in _globalRefreshers)
        {
            refresher();
        }

        if (_activeTabId != null && _tabRefreshers.TryGetValue(_activeTabId, out Action? activeRefresher))
        {
            activeRefresher();
        }
    }

    private void Initialize(EraUiWindowSpec spec, ScrollWindow scrollWindow)
    {
        if (_initialized)
        {
            return;
        }

        _initialized = true;
        _spec = spec;
        _scrollWindow = scrollWindow;

        ConfigureWindowAsset(scrollWindow, spec);
        ConfigureWindowChrome(scrollWindow);
        BuildWindowContent(scrollWindow.transform.Find("Background/Scroll View/Viewport/Content"));
    }

    private void OnEnable()
    {
        if (!_initialized || _spec == null)
        {
            return;
        }

        RecalculateResponsiveLayout();
        RefreshAll();
    }

    private void ConfigureWindowAsset(ScrollWindow scrollWindow, EraUiWindowSpec spec)
    {
        scrollWindow.force_gradient = false;
        scrollWindow.titleText.text = LM.Get(spec.Module.NameKey);
        scrollWindow.titleText.fontSize = EraUiLayoutPrimitives.WindowTitleFontSize;
        scrollWindow.titleText.fontStyle = FontStyle.Bold;
        scrollWindow.titleText.lineSpacing = 1f;
        scrollWindow.titleText.color = EraUiLayoutPrimitives.TitleColor;

        WindowAsset asset = AssetManager.window_library.get(spec.WindowId);
        asset.icon_path = spec.IconRuntimePath;
        asset.related_parent_window = spec.WindowId;
        asset.window_toolbar_enabled = false;
    }

    private void ConfigureWindowChrome(ScrollWindow scrollWindow)
    {
        // 保持原版空窗口骨架，不再注入固定宽度。
    }

    private void BuildWindowContent(Transform? contentTransform)
    {
        if (contentTransform == null || _spec == null || _scrollWindow == null)
        {
            return;
        }

        Transform? scrollViewTransform = _scrollWindow.transform.Find("Background/Scroll View");
        if (scrollViewTransform == null)
        {
            return;
        }

        _scrollViewRect = scrollViewTransform as RectTransform;
        _contentRootRect = contentTransform as RectTransform;
        _bodyWidth = EraUiLayoutPrimitives.ResolveBodyWidth(_scrollWindow, RootHorizontalPadding * 2f);

        VerticalLayoutGroup rootLayout = contentTransform.gameObject.AddComponent<VerticalLayoutGroup>();
        rootLayout.childAlignment = TextAnchor.UpperLeft;
        rootLayout.childControlHeight = true;
        rootLayout.childControlWidth = true;
        rootLayout.childForceExpandHeight = false;
        rootLayout.childForceExpandWidth = false;
        rootLayout.spacing = SectionSpacing;
        rootLayout.padding = new RectOffset((int)RootHorizontalPadding, (int)RootHorizontalPadding, (int)(TabHeight + FixedTabInset + 2f), 6);

        ContentSizeFitter fitter = contentTransform.gameObject.AddComponent<ContentSizeFitter>();
        fitter.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
        fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;

        Transform tabBar = EraUiBuilder.CreateHorizontalPanel(
            scrollViewTransform,
            "MetaTabs",
            new Vector2(_bodyWidth, 0f),
            TabSpacing,
            new RectOffset(0, 0, 0, 0)
        );
        if (tabBar.TryGetComponent(out RectTransform tabBarRect))
        {
            tabBarRect.anchorMin = new Vector2(0f, 1f);
            tabBarRect.anchorMax = new Vector2(1f, 1f);
            tabBarRect.pivot = new Vector2(0.5f, 1f);
            tabBarRect.anchoredPosition = new Vector2(0f, -FixedTabInset);
            tabBarRect.sizeDelta = new Vector2(-FixedTabInset * 2f, TabHeight);
        }
        tabBar.SetAsLastSibling();
        _tabBarTransform = tabBar;

        Transform panelHost = EraUiBuilder.CreateVerticalPanel(
            contentTransform,
            "PanelHost",
            new Vector2(_bodyWidth, 0f),
            SectionSpacing,
            new RectOffset(0, 0, 0, 0)
        );
        LayoutElement panelHostLayout = panelHost.gameObject.AddComponent<LayoutElement>();
        panelHostLayout.preferredWidth = _bodyWidth;
        panelHostLayout.minWidth = Mathf.Max(120f, _bodyWidth);
        _panelHostTransform = panelHost;

        if (_spec.Module.ModuleId == EraModuleId.Guide)
        {
            BuildGuideTabs(tabBar, panelHost);
        }
        else if (_spec.Module.ModuleId == EraModuleId.StoryGenerator)
        {
            BuildStoryTabs(tabBar, panelHost);
        }
        else
        {
            BuildStandardTabs(tabBar, panelHost);
        }

        _tabsContainer = tabBar.gameObject.AddComponent<WindowMetaTabButtonsContainer>();
        _scrollWindow.tabs = _tabsContainer;
        FinalizeTabs();
        RecalculateResponsiveLayout();
        RebuildWindowLayout();
    }

    private float GetBodyWidth()
    {
        if (_scrollWindow != null)
        {
            _bodyWidth = EraUiLayoutPrimitives.ResolveBodyWidth(_scrollWindow, RootHorizontalPadding * 2f);
        }

        return Mathf.Max(156f, _bodyWidth);
    }

    private float GetTextWidth()
    {
        return Mathf.Max(116f, GetBodyWidth() - 4f);
    }

    private float GetFullButtonWidth()
    {
        return Mathf.Max(112f, GetBodyWidth() - 6f);
    }

    private float GetHalfButtonWidth()
    {
        return Mathf.Max(54f, (GetFullButtonWidth() - 4f) * 0.5f);
    }

    private void RecalculateResponsiveLayout()
    {
        float width = GetBodyWidth();
        if (_tabBarTransform != null && _tabBarTransform.TryGetComponent(out RectTransform tabRect))
        {
            _tabBarTransform.SetAsLastSibling();
            tabRect.sizeDelta = new Vector2(-FixedTabInset * 2f, TabHeight);
            tabRect.anchoredPosition = new Vector2(0f, -FixedTabInset);
        }

        if (_panelHostTransform != null && _panelHostTransform.TryGetComponent(out RectTransform panelRect))
        {
            panelRect.sizeDelta = new Vector2(width, panelRect.sizeDelta.y);
            if (_panelHostTransform.TryGetComponent(out LayoutElement panelLayout))
            {
                panelLayout.preferredWidth = width;
            }
        }

        if (_tabEntries.Count == 0)
        {
            return;
        }

        IReadOnlyList<float> tabWidths = ResolveTabWidths(width);
        for (int index = 0; index < _tabEntries.Count; index++)
        {
            EraMetaTabEntry entry = _tabEntries[index];
            float tabWidth = tabWidths[index];
            RectTransform entryRect = entry.Button.GetComponent<RectTransform>();
            entryRect.sizeDelta = new Vector2(tabWidth, TabHeight);
            if (entry.Button.TryGetComponent(out LayoutElement layout))
            {
                layout.preferredWidth = tabWidth;
                layout.minWidth = MinimumTabWidth;
                layout.preferredHeight = TabHeight;
            }
        }
    }

    private IReadOnlyList<float> ResolveTabWidths(float availableWidth)
    {
        if (_tabEntries.Count == 0)
        {
            return Array.Empty<float>();
        }

        float totalSpacing = TabSpacing * Mathf.Max(0, _tabEntries.Count - 1);
        float buttonBudget = Mathf.Max(MinimumTabWidth * _tabEntries.Count, availableWidth - totalSpacing);
        List<float> preferredWidths = new(_tabEntries.Count);

        foreach (EraMetaTabEntry entry in _tabEntries)
        {
            Text? label = entry.Button.GetComponentInChildren<Text>();
            float textWidth = label != null ? Mathf.Ceil(label.preferredWidth) : 32f;
            preferredWidths.Add(Mathf.Clamp(textWidth + 18f, MinimumTabWidth, 84f));
        }

        float preferredSum = preferredWidths.Sum();
        if (preferredSum <= buttonBudget)
        {
            return preferredWidths;
        }

        float fallbackWidth = Mathf.Max(MinimumTabWidth, buttonBudget / _tabEntries.Count);
        return Enumerable.Repeat(fallbackWidth, _tabEntries.Count).ToArray();
    }

    private void RebuildWindowLayout()
    {
        if (_panelHostTransform is RectTransform panelHostRect)
        {
            LayoutRebuilder.ForceRebuildLayoutImmediate(panelHostRect);
        }

        if (_tabBarTransform is RectTransform tabBarRect)
        {
            LayoutRebuilder.ForceRebuildLayoutImmediate(tabBarRect);
        }

        if (_contentRootRect != null)
        {
            LayoutRebuilder.ForceRebuildLayoutImmediate(_contentRootRect);
        }
    }

    private void BuildGuideTabs(Transform tabBar, Transform panelHost)
    {
        Text overview = CreateTextTab(tabBar, panelHost, "overview", EraLocaleKeys.UiGuidePageOverview);
        RegisterTabRefresher("overview", () => overview.text = EraUiContentFactory.BuildGuideOverviewText());

        GameObject settingsPanel = CreateTabPanel(tabBar, panelHost, "settings", EraLocaleKeys.UiGuidePageSettings);
        Text settingsText = EraUiBuilder.CreateBodyLabel(settingsPanel.transform, "SettingsText", string.Empty, GetTextWidth());
        EraUiBuilder.CreateSimpleButton(
            settingsPanel.transform,
            "OpenConfigWindow",
            LM.Get(EraLocaleKeys.UiActionOpenConfig),
            SpriteTextureLoader.getSprite("ui/icons/iconOptions"),
            new Vector2(GetFullButtonWidth(), ActionButtonHeight),
            OpenConfigWindow
        );
        EraUiBuilder.CreateSimpleButton(
            settingsPanel.transform,
            "RefreshSettings",
            LM.Get(EraLocaleKeys.UiActionRefresh),
            SpriteTextureLoader.getSprite("ui/icons/iconOn"),
            new Vector2(GetFullButtonWidth(), ActionButtonHeight),
            () =>
            {
                EraRuntimeBootstrap.RefreshWorldBinding();
                EraUiBootstrap.RefreshOpenWindows();
            }
        );
        EraUiBuilder.CreateSimpleButton(
            settingsPanel.transform,
            "ToggleHud",
            "显示 / 隐藏 HUD",
            SpriteTextureLoader.getSprite("ui/icons/iconOn"),
            new Vector2(GetFullButtonWidth(), ActionButtonHeight),
            EraHudOverlay.ToggleVisibility
        );
        EraUiBuilder.CreateParameterLabel(
            settingsPanel.transform,
            "ImportPathLabel",
            "导入文件路径",
            GetTextWidth()
        );

        TextInput importPathInput = Object.Instantiate(APrefab<TextInput>.Prefab, settingsPanel.transform);
        importPathInput.transform.localScale = Vector3.one;
        importPathInput.SetSize(new Vector2(GetFullButtonWidth(), ActionInputHeight));
        EraUiLayoutPrimitives.ApplyTextInputValueStyle(importPathInput);

        void RefreshImportPath()
        {
            importPathInput.Setup(EraConfig.ImportExport?.DraftImportPath ?? string.Empty, value =>
            {
                if (EraConfig.ImportExport != null)
                {
                    EraConfig.ImportExport.DraftImportPath = value;
                }
            });
        }

        RefreshImportPath();
        _globalRefreshers.Add(RefreshImportPath);

        EraUiBuilder.CreateSimpleButton(
            settingsPanel.transform,
            "UseLastExportPath",
            "使用最近导出路径",
            SpriteTextureLoader.getSprite("ui/icons/iconSaveCloud"),
            new Vector2(GetFullButtonWidth(), ActionButtonHeight),
            () =>
            {
                if (EraConfig.ImportExport == null)
                {
                    return;
                }

                EraConfig.ImportExport.DraftImportPath = EraConfig.ImportExport.LastExportPath;
                EraUiBootstrap.RefreshOpenWindows();
            }
        );
        EraUiBuilder.CreateSimpleButton(
            settingsPanel.transform,
            "ExportGameplayParameters",
            "导出当前玩法参数",
            SpriteTextureLoader.getSprite("ui/icons/iconSaveCloud"),
            new Vector2(GetFullButtonWidth(), ActionButtonHeight),
            () =>
            {
                EraConfig.ImportExport?.ExportCurrentParameters(out _);
                EraUiBootstrap.RefreshOpenWindows();
            }
        );
        EraUiBuilder.CreateSimpleButton(
            settingsPanel.transform,
            "PreviewGameplayImport",
            "预览导入差异",
            SpriteTextureLoader.getSprite("ui/icons/iconOn"),
            new Vector2(GetFullButtonWidth(), ActionButtonHeight),
            () =>
            {
                EraConfig.ImportExport?.TryPreviewImport(out _);
                EraUiBootstrap.RefreshOpenWindows();
            }
        );
        EraUiBuilder.CreateSimpleButton(
            settingsPanel.transform,
            "ApplyGameplayImport",
            "应用导入预览",
            SpriteTextureLoader.getSprite("ui/icons/iconOn"),
            new Vector2(GetFullButtonWidth(), ActionButtonHeight),
            () =>
            {
                if (EraConfig.ImportExport?.ApplyPendingImport() == true)
                {
                    EraRuntimeBootstrap.RefreshWorldBinding();
                }

                EraUiBootstrap.RefreshOpenWindows();
            }
        );
        EraUiBuilder.CreateSimpleButton(
            settingsPanel.transform,
            "RollbackGameplayImport",
            "回滚上次导入",
            SpriteTextureLoader.getSprite("ui/icons/iconOptions"),
            new Vector2(GetFullButtonWidth(), ActionButtonHeight),
            () =>
            {
                if (EraConfig.ImportExport?.RollbackLastImport() == true)
                {
                    EraRuntimeBootstrap.RefreshWorldBinding();
                }

                EraUiBootstrap.RefreshOpenWindows();
            }
        );
        RegisterTabRefresher("settings", () => settingsText.text = EraUiContentFactory.BuildGuideSettingsText());
    }

    private void BuildStoryTabs(Transform tabBar, Transform panelHost)
    {
        Text storyList = CreateTextTab(tabBar, panelHost, "story_list", EraLocaleKeys.UiStoryPageList);
        RegisterTabRefresher("story_list", () => storyList.text = EraUiContentFactory.BuildStoryListText());

        Text storyConfig = CreateTextTab(tabBar, panelHost, "story_config", EraLocaleKeys.UiStoryPageConfig);
        RegisterTabRefresher("story_config", () => storyConfig.text = EraUiContentFactory.BuildStoryConfigText());

        GameObject exportPanel = CreateTabPanel(tabBar, panelHost, "story_export", EraLocaleKeys.UiStoryPageExport);
        Text storyExport = EraUiBuilder.CreateBodyLabel(exportPanel.transform, "StoryExportText", string.Empty, GetTextWidth());
        EraUiBuilder.CreateSimpleButton(
            exportPanel.transform,
            "ExportStorySnapshot",
            "导出当前故事素材",
            SpriteTextureLoader.getSprite("ui/icons/iconSaveCloud"),
            new Vector2(GetFullButtonWidth(), ActionButtonHeight),
            () =>
            {
                EraRuntimeBootstrap.StoryRuntime?.ExportLatestSnapshot(out _);
                EraUiBootstrap.RefreshOpenWindows();
            }
        );
        EraUiBuilder.CreateSimpleButton(
            exportPanel.transform,
            "ExportStoryRewriteRequest",
            "导出 LLM 改写请求",
            SpriteTextureLoader.getSprite("ui/icons/iconSaveCloud"),
            new Vector2(GetFullButtonWidth(), ActionButtonHeight),
            () =>
            {
                EraRuntimeBootstrap.StoryRuntime?.ExportRewriteRequest(out _);
                EraUiBootstrap.RefreshOpenWindows();
            }
        );
        EraUiBuilder.CreateSimpleButton(
            exportPanel.transform,
            "TryStoryRewrite",
            "尝试在线改写",
            SpriteTextureLoader.getSprite("ui/icons/iconOn"),
            new Vector2(GetFullButtonWidth(), ActionButtonHeight),
            () =>
            {
                EraRuntimeBootstrap.StoryRuntime?.TryRewriteLatestSnapshot(out _);
                EraUiBootstrap.RefreshOpenWindows();
            }
        );
        EraUiBuilder.CreateSimpleButton(
            exportPanel.transform,
            "ClearStoryCache",
            "清空故事缓存",
            SpriteTextureLoader.getSprite("ui/icons/iconOptions"),
            new Vector2(GetFullButtonWidth(), ActionButtonHeight),
            () =>
            {
                EraRuntimeBootstrap.StoryRuntime?.ClearCache();
                EraUiBootstrap.RefreshOpenWindows();
            },
            style: EraUiButtonStyle.Danger
        );
        RegisterTabRefresher("story_export", () => storyExport.text = EraUiContentFactory.BuildStoryExportText());
    }

    private void BuildStandardTabs(Transform tabBar, Transform panelHost)
    {
        GameObject introPanel = CreateTabPanel(tabBar, panelHost, "intro", EraLocaleKeys.UiPageIntro);
        EraUiBuilder.CreateSectionTitle(
            introPanel.transform,
            "IntroSectionTitle",
            $"{LM.Get(_spec!.Module.NameKey)}是什么",
            GetTextWidth()
        );
        Text intro = EraUiBuilder.CreateBodyLabel(introPanel.transform, "intro_Text", string.Empty, GetTextWidth());
        RegisterTabRefresher("intro", () => intro.text = EraUiContentFactory.BuildModuleIntroText(_spec!.Module.ModuleId));

        GameObject parameterPanel = CreateTabPanel(tabBar, panelHost, "parameters", EraLocaleKeys.UiPageParameters);
        BuildParameterPanel(parameterPanel.transform);

        GameObject bestiaryPanel = CreateTabPanel(tabBar, panelHost, "bestiary", EraLocaleKeys.UiPageBestiary);
        BuildBestiaryPanel(bestiaryPanel.transform);

        GameObject runtimePanel = CreateTabPanel(tabBar, panelHost, "runtime", EraLocaleKeys.UiPageRuntime);
        EraUiBuilder.CreateSectionTitle(runtimePanel.transform, "RuntimeSectionTitle", "运行态摘要", GetTextWidth());
        Text runtimeText = EraUiBuilder.CreateBodyLabel(runtimePanel.transform, "RuntimeText", string.Empty, GetTextWidth());
        EraUiBuilder.CreateSeparatorBlock(runtimePanel.transform, "RuntimeActionSep", GetTextWidth());
        EraUiBuilder.CreateSectionTitle(runtimePanel.transform, "RuntimeActionTitle", "操作", GetTextWidth());
        EraUiBuilder.CreateSimpleButton(
            runtimePanel.transform,
            "RefreshRuntime",
            LM.Get(EraLocaleKeys.UiActionRefresh),
            SpriteTextureLoader.getSprite("ui/icons/iconOn"),
            new Vector2(GetFullButtonWidth(), ActionButtonHeight),
            () =>
            {
                EraRuntimeBootstrap.RefreshWorldBinding();
                EraUiBootstrap.RefreshOpenWindows();
            }
        );
        if (_spec!.Module.ModuleId == EraModuleId.Reincarnation)
        {
            EraUiBuilder.CreateSimpleButton(
                runtimePanel.transform,
                "FocusNextDemon",
                "聚焦下一名魔王",
                SpriteTextureLoader.getSprite("ui/icons/iconOn"),
                new Vector2(GetFullButtonWidth(), ActionButtonHeight),
                EraRuntimeFocusService.FocusNextDemon
            );
            EraUiBuilder.CreateSimpleButton(
                runtimePanel.transform,
                "FocusNextFortress",
                "聚焦下一处据点",
                SpriteTextureLoader.getSprite("ui/icons/iconOn"),
                new Vector2(GetFullButtonWidth(), ActionButtonHeight),
                EraRuntimeFocusService.FocusNextFortress
            );
            EraUiBuilder.CreateSimpleButton(
                runtimePanel.transform,
                "FocusNextHero",
                "聚焦下一名英雄",
                SpriteTextureLoader.getSprite("ui/icons/iconOn"),
                new Vector2(GetFullButtonWidth(), ActionButtonHeight),
                EraRuntimeFocusService.FocusNextHero
            );
            EraUiBuilder.CreateSimpleButton(
                runtimePanel.transform,
                "FocusNextBattlefield",
                "聚焦关键战场",
                SpriteTextureLoader.getSprite("ui/icons/iconOn"),
                new Vector2(GetFullButtonWidth(), ActionButtonHeight),
                EraRuntimeFocusService.FocusNextBattlefield
            );
        }
        RegisterTabRefresher("runtime", () => runtimeText.text = EraUiContentFactory.BuildModuleRuntimeText(_spec.Module.ModuleId));
    }

    private void BuildBestiaryPanel(Transform parent)
    {
        EraUiBuilder.CreateSectionTitle(parent, "BestiarySectionTitle", "图鉴资料", GetTextWidth());
        Text bestiaryText = EraUiBuilder.CreateBodyLabel(parent, "BestiaryText", string.Empty, GetTextWidth());
        EraUiBuilder.CreateSeparatorBlock(parent, "BestiaryActionSep", GetTextWidth());
        EraUiBuilder.CreateSectionTitle(parent, "BestiaryActionTitle", "浏览", GetTextWidth());
        Transform actions = EraUiBuilder.CreateHorizontalPanel(
            parent,
            "BestiaryActions",
            new Vector2(GetBodyWidth(), 0f),
            6f,
            new RectOffset(0, 0, 0, 0)
        );

        EraUiBuilder.CreateSimpleButton(
            actions,
            "BestiaryPrev",
            "上一条",
            SpriteTextureLoader.getSprite("ui/icons/iconOn"),
            new Vector2(GetHalfButtonWidth(), ActionButtonHeight),
            () =>
            {
                int count = EraUiContentFactory.GetBestiaryEntriesForModule(_spec!.Module.ModuleId).Count;
                _bestiaryIndex = count <= 0 ? 0 : (_bestiaryIndex - 1 + count) % count;
                bestiaryText.text = EraUiContentFactory.BuildBestiaryEntryText(_spec.Module.ModuleId, _bestiaryIndex);
            }
        );
        EraUiBuilder.CreateSimpleButton(
            actions,
            "BestiaryNext",
            "下一条",
            SpriteTextureLoader.getSprite("ui/icons/iconOn"),
            new Vector2(GetHalfButtonWidth(), ActionButtonHeight),
            () =>
            {
                int count = EraUiContentFactory.GetBestiaryEntriesForModule(_spec!.Module.ModuleId).Count;
                _bestiaryIndex = count <= 0 ? 0 : (_bestiaryIndex + 1) % count;
                bestiaryText.text = EraUiContentFactory.BuildBestiaryEntryText(_spec.Module.ModuleId, _bestiaryIndex);
            }
        );
        RegisterTabRefresher(
            "bestiary",
            () =>
            {
                int count = EraUiContentFactory.GetBestiaryEntriesForModule(_spec!.Module.ModuleId).Count;
                if (count <= 0)
                {
                    _bestiaryIndex = 0;
                }
                else if (_bestiaryIndex >= count)
                {
                    _bestiaryIndex = count - 1;
                }

                bestiaryText.text = EraUiContentFactory.BuildBestiaryEntryText(_spec.Module.ModuleId, _bestiaryIndex);
            }
        );
    }

    private void BuildParameterPanel(Transform parent)
    {
        IReadOnlyList<EraParameterGroupBinding> groups = EraParameterUiBindings.CreateForModule(_spec!.Module.ModuleId);
        if (groups.Count == 0)
        {
            EraUiBuilder.CreateDescriptionLabel(
                parent,
                "NoPublicParameters",
                LM.Get(EraLocaleKeys.UiNoPublicParameters),
                GetTextWidth()
            );
            return;
        }

        for (int groupIndex = 0; groupIndex < groups.Count; groupIndex++)
        {
            EraParameterGroupBinding group = groups[groupIndex];
            Transform groupPanel = EraUiBuilder.CreateVerticalPanel(
                parent,
                $"Group_{group.Title}",
                new Vector2(GetBodyWidth(), 0f),
                3f,
                new RectOffset(0, 0, 0, 4)
            );

            float groupTextWidth = GetTextWidth();
            EraUiBuilder.CreateSectionTitle(groupPanel, "GroupTitle", group.Title, groupTextWidth);
            EraUiBuilder.CreateDescriptionLabel(groupPanel, "GroupDescription", group.Description, groupTextWidth);

            foreach (EraParameterBindingBase binding in group.Bindings)
            {
                RenderBinding(groupPanel, binding);
            }

            if (groupIndex < groups.Count - 1)
            {
                EraUiBuilder.CreateSeparatorBlock(parent, $"Settings Sep {groupIndex + 1}", GetTextWidth());
            }
        }
    }

    private void RenderBinding(Transform parent, EraParameterBindingBase binding)
    {
        Transform row = EraUiBuilder.CreateVerticalPanel(
            parent,
            $"Binding_{binding.Label}",
            new Vector2(GetBodyWidth(), 0f),
            2f,
            new RectOffset(0, 0, 0, 0)
        );
        float bindingTextWidth = GetTextWidth();
        EraUiBuilder.CreateParameterLabel(row, "BindingLabel", binding.Label, bindingTextWidth);
        if (!string.IsNullOrWhiteSpace(binding.Description))
        {
            EraUiBuilder.CreateDescriptionLabel(row, "BindingDescription", binding.Description, bindingTextWidth);
        }

        switch (binding)
        {
            case EraToggleBinding toggleBinding:
                RenderToggleBinding(row, toggleBinding);
                break;
            case EraNumberBinding numberBinding:
                RenderNumberBinding(row, numberBinding);
                break;
            case EraRangeBinding rangeBinding:
                RenderRangeBinding(row, rangeBinding);
                break;
            case EraEnumBinding enumBinding:
                RenderEnumBinding(row, enumBinding);
                break;
            case EraMultiSelectBinding multiBinding:
                RenderMultiSelectBinding(row, multiBinding);
                break;
        }
    }

    private void RenderToggleBinding(Transform parent, EraToggleBinding binding)
    {
        Transform row = EraUiBuilder.CreateHorizontalPanel(
            parent,
            "ToggleRow",
            new Vector2(GetBodyWidth(), 0f),
            4f,
            new RectOffset(0, 0, 0, 0)
        );
        PrefabSwitchButton button = Object.Instantiate(APrefab<PrefabSwitchButton>.Prefab, row);
        button.transform.localScale = Vector3.one;
        EraUiLayoutPrimitives.ApplySwitchTextStyle(button);

        void ApplyAndRefresh()
        {
            binding.Setter(!binding.Getter());
            PersistGameplayParameters(binding.Label);
        }

        void Refresh() => button.Setup(binding.Getter(), ApplyAndRefresh);

        Refresh();
        _globalRefreshers.Add(Refresh);
    }

    private void RenderNumberBinding(Transform parent, EraNumberBinding binding)
    {
        TextInput input = Object.Instantiate(APrefab<TextInput>.Prefab, parent);
        input.transform.localScale = Vector3.one;
        input.SetSize(new Vector2(GetFullButtonWidth(), ActionInputHeight));
        EraUiLayoutPrimitives.ApplyTextInputValueStyle(input);

        void Refresh()
        {
            input.Setup(FormatNumber(binding.Getter, binding.WholeNumbers), value =>
            {
                if (!TryParseNumber(value, binding.WholeNumbers, out float parsed))
                {
                    input.input.text = FormatNumber(binding.Getter, binding.WholeNumbers);
                    return;
                }

                binding.Setter(parsed);
                PersistGameplayParameters(binding.Label);
                input.input.text = FormatNumber(binding.Getter, binding.WholeNumbers);
            });
        }

        Refresh();
        _globalRefreshers.Add(Refresh);
    }

    private void RenderRangeBinding(Transform parent, EraRangeBinding binding)
    {
        float rowWidth = GetFullButtonWidth();
        const float labelWidth = 28f;
        const float spacing = 4f;
        float inputWidth = Mathf.Max(72f, rowWidth - labelWidth - spacing);

        Transform minRow = EraUiBuilder.CreateHorizontalPanel(
            parent,
            "RangeMinRow",
            new Vector2(rowWidth, 0f),
            spacing,
            new RectOffset(0, 0, 0, 0)
        );
        EraUiBuilder.CreateDescriptionLabel(minRow, "MinLabel", "最小", labelWidth, TextAnchor.MiddleLeft);
        TextInput minInput = Object.Instantiate(APrefab<TextInput>.Prefab, minRow);
        minInput.transform.localScale = Vector3.one;
        minInput.SetSize(new Vector2(inputWidth, ActionInputHeight));
        EraUiLayoutPrimitives.ApplyTextInputValueStyle(minInput);

        Transform maxRow = EraUiBuilder.CreateHorizontalPanel(
            parent,
            "RangeMaxRow",
            new Vector2(rowWidth, 0f),
            spacing,
            new RectOffset(0, 0, 0, 0)
        );
        EraUiBuilder.CreateDescriptionLabel(maxRow, "MaxLabel", "最大", labelWidth, TextAnchor.MiddleLeft);
        TextInput maxInput = Object.Instantiate(APrefab<TextInput>.Prefab, maxRow);
        maxInput.transform.localScale = Vector3.one;
        maxInput.SetSize(new Vector2(inputWidth, ActionInputHeight));
        EraUiLayoutPrimitives.ApplyTextInputValueStyle(maxInput);

        void Refresh()
        {
            minInput.Setup(FormatNumber(() => binding.Getter().Min, binding.WholeNumbers), value =>
            {
                if (!TryParseNumber(value, binding.WholeNumbers, out float minValue))
                {
                    minInput.input.text = FormatNumber(() => binding.Getter().Min, binding.WholeNumbers);
                    return;
                }

                binding.Setter(minValue, binding.Getter().Max);
                PersistGameplayParameters(binding.Label);
                minInput.input.text = FormatNumber(() => binding.Getter().Min, binding.WholeNumbers);
                maxInput.input.text = FormatNumber(() => binding.Getter().Max, binding.WholeNumbers);
            });
            maxInput.Setup(FormatNumber(() => binding.Getter().Max, binding.WholeNumbers), value =>
            {
                if (!TryParseNumber(value, binding.WholeNumbers, out float maxValue))
                {
                    maxInput.input.text = FormatNumber(() => binding.Getter().Max, binding.WholeNumbers);
                    return;
                }

                binding.Setter(binding.Getter().Min, maxValue);
                PersistGameplayParameters(binding.Label);
                minInput.input.text = FormatNumber(() => binding.Getter().Min, binding.WholeNumbers);
                maxInput.input.text = FormatNumber(() => binding.Getter().Max, binding.WholeNumbers);
            });
        }

        Refresh();
        _globalRefreshers.Add(Refresh);
    }

    private void RenderEnumBinding(Transform parent, EraEnumBinding binding)
    {
        SimpleButton? button = null;
        button = EraUiBuilder.CreateSimpleButton(
            parent,
            "EnumButton",
            string.Empty,
            SpriteTextureLoader.getSprite("ui/icons/iconOptions"),
            new Vector2(GetFullButtonWidth(), ActionButtonHeight),
            () =>
            {
                if (binding.Options.Count == 0)
                {
                    return;
                }

                int currentValue = binding.Getter();
                int currentIndex = binding.Options.ToList().FindIndex(item => item.Value == currentValue);
                if (currentIndex < 0)
                {
                    currentIndex = 0;
                }

                int nextIndex = (currentIndex + 1) % binding.Options.Count;
                binding.Setter(binding.Options[nextIndex].Value);
                PersistGameplayParameters(binding.Label);
                if (button != null)
                {
                    button.Text.text = binding.Options[nextIndex].Label;
                }
            }
        );

        void Refresh()
        {
            int currentValue = binding.Getter();
            EraEnumOptionBinding option = binding.Options.FirstOrDefault(item => item.Value == currentValue)
                                          ?? binding.Options.FirstOrDefault()
                                          ?? new EraEnumOptionBinding("未配置", 0);
            button.Text.text = option.Label;
        }

        Refresh();
        _globalRefreshers.Add(Refresh);
    }

    private void RenderMultiSelectBinding(Transform parent, EraMultiSelectBinding binding)
    {
        float rowWidth = GetFullButtonWidth();
        const float switchWidth = 50f;
        const float spacing = 4f;
        float labelWidth = Mathf.Max(48f, rowWidth - switchWidth - spacing);

        foreach (EraMultiSelectOptionBinding option in binding.Options)
        {
            Transform optionPanel = EraUiBuilder.CreateVerticalPanel(
                parent,
                $"MultiOption_{option.Label}",
                new Vector2(rowWidth, 0f),
                1f,
                new RectOffset(0, 0, 0, 0)
            );
            Transform row = EraUiBuilder.CreateHorizontalPanel(
                optionPanel,
                $"MultiRow_{option.Label}",
                new Vector2(rowWidth, 0f),
                spacing,
                new RectOffset(0, 0, 0, 0)
            );
            PrefabSwitchButton switchButton = Object.Instantiate(APrefab<PrefabSwitchButton>.Prefab, row);
            switchButton.transform.localScale = Vector3.one;
            EraUiLayoutPrimitives.ApplySwitchTextStyle(switchButton);
            if (switchButton.TryGetComponent(out LayoutElement switchLayout))
            {
                switchLayout.preferredWidth = switchWidth;
                switchLayout.minWidth = switchWidth;
            }
            else
            {
                LayoutElement layout = switchButton.gameObject.AddComponent<LayoutElement>();
                layout.preferredWidth = switchWidth;
                layout.minWidth = switchWidth;
            }

            Text label = EraUiBuilder.CreateDescriptionLabel(row, "OptionLabel", option.Label, labelWidth, TextAnchor.MiddleLeft);
            label.alignment = TextAnchor.MiddleLeft;

            void Refresh() => switchButton.Setup(option.Getter(), () =>
            {
                option.Setter(!option.Getter());
                PersistGameplayParameters(binding.Label);
            });

            Refresh();
            _globalRefreshers.Add(Refresh);
        }
    }

    private Text CreateTextTab(Transform tabBar, Transform panelHost, string tabId, string labelKey)
    {
        GameObject panel = CreateTabPanel(tabBar, panelHost, tabId, labelKey);
        return EraUiBuilder.CreateBodyLabel(panel.transform, $"{tabId}_Text", string.Empty, GetTextWidth());
    }

    private GameObject CreateTabPanel(Transform tabBar, Transform panelHost, string tabId, string labelKey)
    {
        WindowMetaTab tab = EraUiBuilder.CreateMetaTabButton(tabBar, $"TabButton_{tabId}", tabId, labelKey, MinimumTabWidth);
        Transform panel = EraUiBuilder.CreateVerticalPanel(
            panelHost,
            $"TabPanel_{tabId}",
            new Vector2(GetBodyWidth(), 0f),
            3f,
            new RectOffset(0, 0, 0, 0)
        );
        panel.gameObject.SetActive(false);
        _tabEntries.Add(new EraMetaTabEntry(tabId, tab, panel));
        return panel.gameObject;
    }

    private void FinalizeTabs()
    {
        if (_tabsContainer == null || _tabEntries.Count == 0)
        {
            return;
        }

        _tabsContainer.tab_default = _tabEntries[0].Button;
        _tabsContainer.init();
        foreach (EraMetaTabEntry entry in _tabEntries)
        {
            _tabsContainer.addTabContent(entry.Button, entry.Panel);
            entry.Button.tab_action.AddListener(_ => _tabsContainer.showTab(entry.Button));
            entry.Button.tab_action.AddListener(_ =>
            {
                _activeTabId = entry.TabId;
                if (_tabRefreshers.TryGetValue(entry.TabId, out Action? refresher))
                {
                    refresher();
                }

                RebuildWindowLayout();
            });
        }

        _tabsContainer.initialTabAction();
        RebuildWindowLayout();
    }

    private void RegisterTabRefresher(string tabId, Action refresher)
    {
        _tabRefreshers[tabId] = refresher;
        _globalRefreshers.Add(refresher);
    }

    private static string FormatNumber(Func<float> getter, bool wholeNumbers)
    {
        float value = getter();
        return wholeNumbers
            ? value.ToString("0", CultureInfo.InvariantCulture)
            : value.ToString("0.##", CultureInfo.InvariantCulture);
    }

    private static bool TryParseNumber(string raw, bool wholeNumbers, out float value)
    {
        if (!float.TryParse(raw, NumberStyles.Float, CultureInfo.InvariantCulture, out value)
            && !float.TryParse(raw, NumberStyles.Float, CultureInfo.CurrentCulture, out value))
        {
            value = 0f;
            return false;
        }

        if (wholeNumbers)
        {
            value = Mathf.Round(value);
        }

        return true;
    }

    private static void OpenConfigWindow()
    {
        ModConfig? config = EraWheelMod.I.GetConfig();
        if (config == null)
        {
            EraLog.Warning(EraLogCategory.Config, "当前没有可打开的 ModConfig。");
            return;
        }

        ModConfigureWindow.ShowWindow(config);
    }

    private static void PersistGameplayParameters(string reason)
    {
        EraConfig.ImportExport?.SaveCurrentAsActive(reason);
    }
}

internal readonly struct EraMetaTabEntry
{
    public string TabId { get; }
    public WindowMetaTab Button { get; }
    public Transform Panel { get; }

    public EraMetaTabEntry(string tabId, WindowMetaTab button, Transform panel)
    {
        TabId = tabId;
        Button = button;
        Panel = panel;
    }
}

internal static class EraUiBuilder
{
    private static readonly BindingFlags AnyInstance = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
    private static readonly FieldInfo? TabCanvasGroupField = typeof(WindowMetaTab).GetField("_canvas_group", AnyInstance);

    public static Transform CreateVerticalPanel(
        Transform parent,
        string name,
        Vector2 size,
        float spacing,
        RectOffset padding)
    {
        GameObject panel = new(name, typeof(RectTransform), typeof(VerticalLayoutGroup), typeof(ContentSizeFitter));
        panel.transform.SetParent(parent, false);
        RectTransform rect = panel.GetComponent<RectTransform>();
        rect.sizeDelta = size;

        VerticalLayoutGroup layout = panel.GetComponent<VerticalLayoutGroup>();
        OT.InitializeNoActionVerticalLayoutGroup(layout);
        layout.childAlignment = TextAnchor.UpperLeft;
        layout.childControlHeight = true;
        layout.childControlWidth = false;
        layout.childForceExpandHeight = false;
        layout.childForceExpandWidth = false;
        layout.childScaleHeight = false;
        layout.childScaleWidth = false;
        layout.spacing = spacing;
        layout.padding = padding;

        ContentSizeFitter fitter = panel.GetComponent<ContentSizeFitter>();
        fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
        fitter.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
        return panel.transform;
    }

    public static Transform CreateHorizontalPanel(
        Transform parent,
        string name,
        Vector2 size,
        float spacing,
        RectOffset padding)
    {
        GameObject panel = new(name, typeof(RectTransform), typeof(HorizontalLayoutGroup), typeof(ContentSizeFitter));
        panel.transform.SetParent(parent, false);
        RectTransform rect = panel.GetComponent<RectTransform>();
        rect.sizeDelta = size;

        HorizontalLayoutGroup layout = panel.GetComponent<HorizontalLayoutGroup>();
        layout.childAlignment = TextAnchor.MiddleLeft;
        layout.childControlHeight = true;
        layout.childControlWidth = false;
        layout.childForceExpandHeight = false;
        layout.childForceExpandWidth = false;
        layout.childScaleHeight = false;
        layout.childScaleWidth = false;
        layout.spacing = spacing;
        layout.padding = padding;

        ContentSizeFitter fitter = panel.GetComponent<ContentSizeFitter>();
        fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
        fitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
        return panel.transform;
    }

    public static Text CreateLabel(
        Transform parent,
        string name,
        int fontSize,
        FontStyle fontStyle,
        string text,
        float width,
        float lineSpacing = 1f,
        TextAnchor alignment = TextAnchor.UpperLeft,
        Color? color = null)
    {
        return EraUiLayoutPrimitives.CreateAutoHeightLabel(
            parent,
            name,
            fontSize,
            fontStyle,
            text,
            width,
            lineSpacing,
            alignment,
            color
        );
    }

    public static Text CreateSectionTitle(Transform parent, string name, string text, float width)
    {
        return CreateLabel(
            parent,
            name,
            EraUiLayoutPrimitives.SectionTitleFontSize,
            FontStyle.Bold,
            text,
            width,
            color: EraUiLayoutPrimitives.SectionTitleColor
        );
    }

    public static Text CreateBodyLabel(Transform parent, string name, string text, float width)
    {
        return CreateLabel(
            parent,
            name,
            EraUiLayoutPrimitives.BodyFontSize,
            FontStyle.Normal,
            text,
            width,
            EraUiLayoutPrimitives.BodyLineSpacing,
            color: EraUiLayoutPrimitives.BodyColor
        );
    }

    public static Text CreateParameterLabel(Transform parent, string name, string text, float width)
    {
        return CreateLabel(
            parent,
            name,
            EraUiLayoutPrimitives.ParameterLabelFontSize,
            FontStyle.Bold,
            text,
            width,
            color: EraUiLayoutPrimitives.BodyColor
        );
    }

    public static Text CreateDescriptionLabel(
        Transform parent,
        string name,
        string text,
        float width,
        TextAnchor alignment = TextAnchor.UpperLeft)
    {
        return CreateLabel(
            parent,
            name,
            EraUiLayoutPrimitives.DescriptionFontSize,
            FontStyle.Normal,
            text,
            width,
            EraUiLayoutPrimitives.DescriptionLineSpacing,
            alignment,
            EraUiLayoutPrimitives.DescriptionColor
        );
    }

    public static Transform CreateSeparatorBlock(Transform parent, string name, float width)
    {
        GameObject block = new(name, typeof(RectTransform), typeof(VerticalLayoutGroup), typeof(ContentSizeFitter));
        block.transform.SetParent(parent, false);

        RectTransform blockRect = block.GetComponent<RectTransform>();
        blockRect.sizeDelta = new Vector2(width, 0f);

        VerticalLayoutGroup layout = block.GetComponent<VerticalLayoutGroup>();
        OT.InitializeNoActionVerticalLayoutGroup(layout);
        layout.childAlignment = TextAnchor.UpperLeft;
        layout.childControlHeight = false;
        layout.childControlWidth = false;
        layout.childForceExpandHeight = false;
        layout.childForceExpandWidth = false;
        layout.padding = new RectOffset(0, 0, 24, 30);

        ContentSizeFitter fitter = block.GetComponent<ContentSizeFitter>();
        fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
        fitter.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;

        float separatorWidth = Mathf.Min(EraUiLayoutPrimitives.SeparatorWidth, width);
        GameObject separator = new("Line", typeof(RectTransform), typeof(Image), typeof(LayoutElement));
        separator.transform.SetParent(block.transform, false);
        RectTransform separatorRect = separator.GetComponent<RectTransform>();
        separatorRect.sizeDelta = new Vector2(separatorWidth, EraUiLayoutPrimitives.SeparatorHeight);

        Image image = separator.GetComponent<Image>();
        image.color = EraUiLayoutPrimitives.SeparatorColor;
        image.raycastTarget = false;

        LayoutElement element = separator.GetComponent<LayoutElement>();
        element.preferredWidth = separatorWidth;
        element.preferredHeight = EraUiLayoutPrimitives.SeparatorHeight;
        element.minHeight = EraUiLayoutPrimitives.SeparatorHeight;
        element.flexibleHeight = 0f;

        return block.transform;
    }

    public static SimpleButton CreateSimpleButton(
        Transform parent,
        string name,
        string text,
        Sprite icon,
        Vector2 size,
        Action click,
        EraUiButtonStyle style = EraUiButtonStyle.Neutral)
    {
        return EraUiLayoutPrimitives.CreateStyledActionButton(parent, name, text, icon, size, style, click);
    }

    public static WindowMetaTab CreateMetaTabButton(
        Transform parent,
        string name,
        string tabId,
        string labelKey,
        float width)
    {
        return EraUiLayoutPrimitives.CreateResponsiveTabButton(
            parent,
            name,
            tabId,
            labelKey,
            width,
            TabCanvasGroupField
        );
    }
}
