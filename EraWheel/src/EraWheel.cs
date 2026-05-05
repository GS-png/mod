using EraWheel.Config;
using EraWheel.Core;
using EraWheel.Core.Logging;
using EraWheel.Debug;
using EraWheel.HotReload;
using EraWheel.Localization;
using EraWheel.Reflection;
using EraWheel.UI;
using NeoModLoader.api;
using NeoModLoader.api.attributes;
using NeoModLoader.General;

namespace EraWheel;

public sealed class EraWheelMod : BasicMod<EraWheelMod>, IReloadable
{
    private static bool _reloading;

    public static string LastReloadStatus { get; private set; } = "尚未执行热加载。";
    public static EraReloadResult? LastReloadResult { get; private set; }

    protected override void OnModLoad()
    {
        ModDeclare declaration = GetDeclaration();
        EraConfig.Initialize(declaration, GetConfig());
        WorldboxReflectionAdapter.Initialize();
        EraRuntimeBootstrap.Initialize(declaration, EraConfig.ParameterRegistry);

        EraLog.Info(EraLogCategory.Startup, $"模组入口已加载，当前版本：{declaration.Version}");
        EraLog.Info(EraLogCategory.Config, $"开发模式：{(EraConfig.DevelopmentMode ? "开启" : "关闭")}。");
        EraLog.Info(EraLogCategory.Config, $"系统参数注册表：{EraConfig.ParameterRegistry.CreateStatusReport()}");
        EraLog.Info(EraLogCategory.Config, $"参数导入导出：{EraConfig.ImportExport?.CreateStatusReport() ?? "未初始化。"}");
        EraLog.Info(EraLogCategory.Config, $"参数导入导出最近结果：{EraConfig.ImportExport?.LastStatusMessage ?? "无"}");
        EraLog.Info(EraLogCategory.Reflection, $"待反射 API 探测结果：{WorldboxReflectionAdapter.CreateStatusReport()}");
        EraLog.Info(EraLogCategory.Localization, "本地化目录已切换到 Locales/，EW-007 文本键骨架已接入。");
        EraLog.Info(EraLogCategory.Startup, $"共享底座状态：{EraRuntimeBootstrap.CreateStatusReport()}");
        EraLog.Info(EraLogCategory.Startup, EraUiBootstrap.CreateEntryButtonIconModeReport());
    }

    public override void Init()
    {
        base.Init();

        EraRuntimeBootstrap.RefreshWorldBinding();
        EraUiBootstrap.Initialize();
        EraDebugPanelService.Initialize();
        EraLog.Info(
            EraLogCategory.Debug,
            EraConfig.DevelopmentMode
                ? "开发模式按钮已尝试挂载到 main 页签。"
                : "开发模式未开启，调试按钮保持隐藏。"
        );
        EraLog.Info(EraLogCategory.Startup, $"初始化后共享底座状态：{EraRuntimeBootstrap.CreateStatusReport()}");
        EraLog.Info(EraLogCategory.Startup, EraUiBootstrap.CreateEntryButtonIconModeReport());
        EraLog.Info(EraLogCategory.Startup, EraUiBootstrap.CreateTopTabStatusReport());
    }

    private void Update()
    {
        EraRuntimeBootstrap.UpdateRuntime();
        EraUiBootstrap.PumpTopTabRegistration();
        EraHudOverlay.Update();
    }

    [Hotfixable]
    public void Reload()
    {
        if (_reloading)
        {
            EraLog.Warning(EraLogCategory.Debug, "整模组热加载已在执行中，本次请求已忽略。");
            return;
        }

        _reloading = true;
        try
        {
            ModDeclare declaration = GetDeclaration();
            EraLog.Info(EraLogCategory.Startup, $"开始执行 EraWheel 整模组热加载：{declaration.Version}");
            LastReloadResult = EraHotReloadCoordinator.Execute(this);
            LastReloadStatus = LastReloadResult.RestartRequired
                ? LM.Get(EraLocaleKeys.DebugReloadHintRestartRequired)
                : LastReloadResult.Success
                    ? LM.Get(EraLocaleKeys.DebugReloadHintSuccess)
                    : LM.Get(EraLocaleKeys.DebugReloadHintFailed);
            EraLog.Info(EraLogCategory.Startup, $"热加载摘要：{LastReloadResult.Summary}");
            EraLog.Info(EraLogCategory.Startup, EraUiBootstrap.CreateEntryButtonIconModeReport());
            EraLog.Info(EraLogCategory.Startup, EraUiBootstrap.CreateTopTabStatusReport());
        }
        finally
        {
            _reloading = false;
        }
    }
}
