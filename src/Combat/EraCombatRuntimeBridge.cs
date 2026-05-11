using EraWheel.Core.Logging;

namespace EraWheel.Combat;

public static class EraCombatRuntimeBridge
{
    public static EraCombatRuntimeService? Current { get; private set; }

    public static void Bind(EraCombatRuntimeService? runtime)
    {
        Current = runtime;
        EraLog.Info(
            EraLogCategory.Combat,
            runtime == null
                ? "战斗运行时桥接已解绑。"
                : "战斗运行时桥接已绑定。"
        );
    }
}
