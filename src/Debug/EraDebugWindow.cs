using System.Text;
using EraWheel.Config;
using EraWheel.Core;
using EraWheel.Core.Logging;
using EraWheel.Localization;
using EraWheel.Reflection;
using NeoModLoader.General;
using NeoModLoader.General.UI.Prefabs;
using NeoModLoader.api;
using NeoModLoader.api.attributes;
using NeoModLoader.ui;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace EraWheel.Debug;

public sealed class EraDebugWindow : AbstractWindow<EraDebugWindow>
{
    private Text? _summaryTitle;
    private Text? _summaryBody;
    private Text? _actionsTitle;
    private Text? _hintText;

    public static EraDebugWindow Ensure()
    {
        return Instance ?? CreateAndInit("ew_debug_window");
    }

    protected override void Init()
    {
        VerticalLayoutGroup layout = ContentTransform.gameObject.AddComponent<VerticalLayoutGroup>();
        ContentSizeFitter fitter = ContentTransform.gameObject.AddComponent<ContentSizeFitter>();
        OT.InitializeNoActionVerticalLayoutGroup(layout);
        layout.spacing = 8f;
        layout.padding = new RectOffset(8, 8, 8, 8);
        fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
        fitter.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;

        _summaryTitle = CreateLabel("SummaryTitle", 14, FontStyle.Bold);
        _summaryBody = CreateLabel("SummaryBody", 12, FontStyle.Normal);
        _actionsTitle = CreateLabel("ActionsTitle", 14, FontStyle.Bold);

        CreateActionButton(
            "OpenConfigButton",
            EraLocaleKeys.DebugButtonOpenConfig,
            "ui/icons/iconOptions",
            OpenConfigWindow
        );
        CreateActionButton(
            "RefreshButton",
            EraLocaleKeys.DebugButtonRefresh,
            "ui/icons/iconOn",
            RefreshAndLogState
        );
        CreateActionButton(
            "ReflectionButton",
            EraLocaleKeys.DebugButtonLogReflection,
            "ui/icons/iconSaveCloud",
            LogReflectionState
        );
        CreateActionButton(
            "JumpOmenButton",
            EraLocaleKeys.DebugButtonJumpToOmen,
            "ui/icons/iconOn",
            JumpToOmen
        );
        CreateActionButton(
            "JumpAwakeningButton",
            EraLocaleKeys.DebugButtonJumpToAwakening,
            "ui/icons/iconOn",
            JumpToAwakening
        );
        CreateActionButton(
            "JumpAdventButton",
            EraLocaleKeys.DebugButtonJumpToAdvent,
            "ui/icons/iconOn",
            JumpToAdvent
        );
        CreateActionButton(
            "ResetSealsButton",
            EraLocaleKeys.DebugButtonResetSeals,
            "ui/icons/iconOptions",
            ResetSeals
        );
        CreateActionButton(
            "ForceReconstructionButton",
            EraLocaleKeys.DebugButtonForceReconstruction,
            "ui/icons/iconSaveCloud",
            ForceReconstruction
        );
        CreateActionButton(
            "FocusButton",
            EraLocaleKeys.DebugButtonFocusWorldCenter,
            "ui/icons/iconCustomWorld",
            FocusWorldCenter
        );

        _hintText = CreateLabel("HintText", 11, FontStyle.Italic);
        RefreshView();
    }

    [Hotfixable]
    public void RefreshView()
    {
        if (_summaryTitle == null || _summaryBody == null || _actionsTitle == null || _hintText == null)
        {
            return;
        }

        _summaryTitle.text = LM.Get(EraLocaleKeys.DebugSummaryTitle);
        _summaryBody.text = BuildSummaryText();
        _actionsTitle.text = LM.Get(EraLocaleKeys.DebugActionsTitle);
        _hintText.text = LM.Get(EraLocaleKeys.DebugRuntimeHint);
    }

    [Hotfixable]
    private string BuildSummaryText()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine(
            $"{LM.Get(EraLocaleKeys.DebugStatusDevelopmentMode)}: {LM.Get(EraConfig.DevelopmentMode ? EraLocaleKeys.DebugStatusOn : EraLocaleKeys.DebugStatusOff)}"
        );
        builder.AppendLine(
            $"{LM.Get(EraLocaleKeys.DebugStatusWorldLoaded)}: {LM.Get(World.world != null ? EraLocaleKeys.DebugStatusReady : EraLocaleKeys.DebugStatusMissing)}"
        );
        builder.AppendLine(
            $"{LM.Get(EraLocaleKeys.DebugStatusBuildingApi)}: {LM.Get(WorldboxReflectionAdapter.CanAddBuilding ? EraLocaleKeys.DebugStatusReady : EraLocaleKeys.DebugStatusMissing)}"
        );
        builder.AppendLine(
            $"{LM.Get(EraLocaleKeys.DebugStatusMapStatsApi)}: {LM.Get(WorldboxReflectionAdapter.CanReadMapStats ? EraLocaleKeys.DebugStatusReady : EraLocaleKeys.DebugStatusMissing)}"
        );
        builder.AppendLine(
            $"{LM.Get(EraLocaleKeys.DebugStatusCameraApi)}: {LM.Get(WorldboxReflectionAdapter.CanFocusCamera ? EraLocaleKeys.DebugStatusReady : EraLocaleKeys.DebugStatusMissing)}"
        );

        if (WorldboxReflectionAdapter.TryReadMapStats(out MapStats? mapStats) && mapStats != null)
        {
            builder.AppendLine($"{LM.Get(EraLocaleKeys.DebugStatusPopulation)}: {mapStats.population}");
            builder.AppendLine($"{LM.Get(EraLocaleKeys.DebugStatusHousesBuilt)}: {mapStats.housesBuilt}");
            builder.AppendLine($"{LM.Get(EraLocaleKeys.DebugStatusHousesDestroyed)}: {mapStats.housesDestroyed}");
            builder.AppendLine($"{LM.Get(EraLocaleKeys.DebugStatusWorldTime)}: {mapStats.world_time:F2}");
        }

        return builder.ToString().TrimEnd();
    }

    private void OpenConfigWindow()
    {
        ModConfig? config = EraWheelMod.I.GetConfig();
        if (config == null)
        {
            EraLog.Warning(EraLogCategory.Debug, "当前没有可打开的 ModConfig。");
            return;
        }

        ModConfigureWindow.ShowWindow(config);
    }

    private void RefreshAndLogState()
    {
        EraRuntimeBootstrap.RefreshWorldBinding();
        RefreshView();
        EraLog.Info(EraLogCategory.Debug, $"调试面板状态已刷新。{EraRuntimeBootstrap.CreateStatusReport()}");
    }

    private void LogReflectionState()
    {
        WorldboxReflectionAdapter.LogReport();
        RefreshView();
    }

    private void FocusWorldCenter()
    {
        if (WorldboxReflectionAdapter.TryFocusWorldCenter())
        {
            EraLog.Info(EraLogCategory.Debug, "已调用镜头聚焦到世界中心。");
        }
        else
        {
            EraLog.Warning(EraLogCategory.Debug, "镜头聚焦失败，当前可能还没有可用世界。");
        }

        RefreshView();
    }

    private void JumpToOmen()
    {
        if (EraRuntimeBootstrap.ReincarnationRuntime?.DebugJumpToOmen() != true)
        {
            EraLog.Warning(EraLogCategory.Debug, "强制跳到预兆失败，当前可能还没有可用世界。");
        }

        RefreshView();
    }

    private void JumpToAwakening()
    {
        if (EraRuntimeBootstrap.ReincarnationRuntime?.DebugJumpToAwakening() != true)
        {
            EraLog.Warning(EraLogCategory.Debug, "强制跳到苏醒失败，请先确认据点初始化是否成功。");
        }

        RefreshView();
    }

    private void JumpToAdvent()
    {
        if (EraRuntimeBootstrap.ReincarnationRuntime?.DebugJumpToAdvent() != true)
        {
            EraLog.Warning(EraLogCategory.Debug, "强制跳到降临失败，请先确认据点初始化是否成功。");
        }

        RefreshView();
    }

    private void ResetSeals()
    {
        if (EraRuntimeBootstrap.ReincarnationRuntime?.DebugResetSeals() != true)
        {
            EraLog.Warning(EraLogCategory.Debug, "重置双封印失败，当前可能还没有可用世界。");
        }

        RefreshView();
    }

    private void ForceReconstruction()
    {
        if (EraRuntimeBootstrap.ReincarnationRuntime?.DebugForceReconstruction() != true)
        {
            EraLog.Warning(EraLogCategory.Debug, "强制进入战后重建失败，当前可能还没有可用世界。");
        }

        RefreshView();
    }

    private Text CreateLabel(string name, int fontSize, FontStyle fontStyle)
    {
        GameObject labelObject = new GameObject(name, typeof(Text));
        labelObject.transform.SetParent(ContentTransform, worldPositionStays: false);

        Text label = labelObject.GetComponent<Text>();
        OT.InitializeCommonText(label);
        label.fontSize = fontSize;
        label.fontStyle = fontStyle;
        label.color = Color.white;
        label.alignment = TextAnchor.UpperLeft;
        label.horizontalOverflow = HorizontalWrapMode.Wrap;
        label.verticalOverflow = VerticalWrapMode.Overflow;
        label.resizeTextForBestFit = false;
        label.GetComponent<RectTransform>().sizeDelta = new Vector2(210f, 0f);
        return label;
    }

    private void CreateActionButton(string name, string labelKey, string iconPath, UnityAction action)
    {
        SimpleButton button = Object.Instantiate(APrefab<SimpleButton>.Prefab, ContentTransform);
        button.name = name;
        button.transform.localScale = Vector3.one;
        button.Setup(
            action,
            SpriteTextureLoader.getSprite(iconPath),
            LM.Get(labelKey),
            new Vector2(210f, 34f)
        );
        button.Text.resizeTextForBestFit = true;
        button.Text.resizeTextMinSize = 8;
        button.Text.resizeTextMaxSize = 14;
        button.Text.color = Color.white;
    }
}
