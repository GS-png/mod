using EraWheel.Core.Logging;

namespace EraWheel.Systems.Progression;

public static class EraProgressionRuntimeBridge
{
    public static EraProgressionRuntimeService? Current { get; private set; }

    public static void Bind(EraProgressionRuntimeService? runtime)
    {
        Current = runtime;
        EraLog.Info(
            EraLogCategory.Events,
            runtime == null
                ? "成长运行时桥接已解绑。"
                : "成长运行时桥接已绑定。"
        );
    }
}
