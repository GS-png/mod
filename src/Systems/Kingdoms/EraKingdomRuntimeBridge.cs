using EraWheel.Core.Logging;

namespace EraWheel.Systems.Kingdoms;

public static class EraKingdomRuntimeBridge
{
    public static EraKingdomRuntimeService? Current { get; private set; }

    public static void Bind(EraKingdomRuntimeService? runtime)
    {
        Current = runtime;
        EraLog.Info(
            EraLogCategory.Events,
            runtime == null
                ? "王国声望运行时桥接已解绑。"
                : "王国声望运行时桥接已绑定。"
        );
    }
}
