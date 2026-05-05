using EraWheel.Core.Logging;

namespace EraWheel.Systems.Advancement;

public static class EraAdvancementRuntimeBridge
{
    public static EraAdvancementRuntimeService? Current { get; private set; }

    public static void Bind(EraAdvancementRuntimeService? runtime)
    {
        Current = runtime;
        EraLog.Info(
            EraLogCategory.Events,
            runtime == null
                ? "轮回进阶运行时桥接已解绑。"
                : "轮回进阶运行时桥接已绑定。"
        );
    }
}
