using EraWheel.Config;
using EraWheel.Core;
using EraWheel.Core.Logging;
using EraWheel.Debug;
using EraWheel.Reflection;
using EraWheel.UI;
using NeoModLoader.api;
using NeoModLoader.General;

namespace EraWheel;

public sealed class EraWheelMod : BasicMod<EraWheelMod>
{
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
        EraRuntimeStepGuard.RunRuntimeStep(
            EraLogCategory.Startup,
            "main_loop_step",
            "runtime.update",
            CurrentCycle(),
            CurrentWorldTime(),
            EraRuntimeBootstrap.UpdateRuntime
        );
        EraRuntimeStepGuard.RunRuntimeStep(
            EraLogCategory.Debug,
            "main_loop_step",
            "ui.top_tab_registration",
            CurrentCycle(),
            CurrentWorldTime(),
            EraUiBootstrap.PumpTopTabRegistration
        );
        EraRuntimeStepGuard.RunRuntimeStep(
            EraLogCategory.Debug,
            "main_loop_step",
            "ui.hud_overlay",
            CurrentCycle(),
            CurrentWorldTime(),
            EraHudOverlay.Update
        );
    }

    private static int CurrentCycle()
    {
        return EraRuntimeBootstrap.RuntimeSave?.CurrentState.CompletedCycles ?? 0;
    }

    private static float CurrentWorldTime()
    {
        return EraRuntimeBootstrap.RuntimeSave?.CurrentState.LastObservedWorldTime ?? 0f;
    }
}
