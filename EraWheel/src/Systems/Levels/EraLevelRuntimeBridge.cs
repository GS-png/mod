using EraWheel.Core.Logging;

namespace EraWheel.Systems.Levels;

public static class EraLevelRuntimeBridge
{
    public static EraLevelRuntimeService? Current { get; private set; }

    public static void Bind(EraLevelRuntimeService? runtime)
    {
        Current = runtime;
        EraLog.Info(
            EraLogCategory.Events,
            runtime == null
                ? "等级运行时桥接已解绑。"
                : "等级运行时桥接已绑定。"
        );
    }
}
