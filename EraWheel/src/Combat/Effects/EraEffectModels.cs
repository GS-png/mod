using EraWheel.Combat.Triggers;

namespace EraWheel.Combat.Effects;

public enum EraEffectTargetRule
{
    All = 0,
    Foes = 1,
    Friends = 2,
    SelfOnly = 3,
    Others = 4,
}

public readonly struct EraEffectContext
{
    public BaseSimObject? Source { get; }
    public BaseSimObject? PrimaryTarget { get; }
    public Actor? SourceActor { get; }
    public Actor? PrimaryTargetActor { get; }
    public float WorldTime { get; }
    public string SourceId { get; }
    public EraTriggerType TriggerType { get; }

    public EraEffectContext(
        BaseSimObject? source,
        BaseSimObject? primaryTarget,
        float worldTime,
        string sourceId,
        EraTriggerType triggerType = EraTriggerType.Active
    )
    {
        Source = source;
        PrimaryTarget = primaryTarget;
        SourceActor = source as Actor;
        PrimaryTargetActor = primaryTarget as Actor;
        WorldTime = worldTime;
        SourceId = sourceId;
        TriggerType = triggerType;
    }

    public static EraEffectContext FromTrigger(EraTriggerContext context)
    {
        return new EraEffectContext(
            context.Source,
            context.Target,
            context.WorldTime,
            context.SourceId,
            context.TriggerType
        );
    }
}
