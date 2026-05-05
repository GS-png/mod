using System;

namespace EraWheel.Combat.Triggers;

public enum EraTriggerType
{
    Active = 0,
    OnHit = 1,
    OnGetHit = 2,
    OnDeath = 3,
    OnTick = 4,
}

public enum EraTriggerSubject
{
    Source = 0,
    Target = 1,
    Any = 2,
    Both = 3,
}

public readonly struct EraTriggerContext
{
    public EraTriggerType TriggerType { get; }
    public BaseSimObject? Source { get; }
    public BaseSimObject? Target { get; }
    public Actor? SourceActor { get; }
    public Actor? TargetActor { get; }
    public AttackData? AttackData { get; }
    public float Damage { get; }
    public AttackType AttackType { get; }
    public float WorldTime { get; }
    public string SourceId { get; }

    public EraTriggerContext(
        EraTriggerType triggerType,
        BaseSimObject? source,
        BaseSimObject? target,
        AttackData? attackData,
        float damage,
        AttackType attackType,
        float worldTime,
        string sourceId = "runtime"
    )
    {
        TriggerType = triggerType;
        Source = source;
        Target = target;
        SourceActor = source as Actor;
        TargetActor = target as Actor;
        AttackData = attackData;
        Damage = damage;
        AttackType = attackType;
        WorldTime = worldTime;
        SourceId = sourceId;
    }
}

public sealed class EraTriggerDefinition
{
    public string Id { get; }
    public string OwnerId { get; }
    public EraTriggerType TriggerType { get; }
    public float ChancePercent { get; }
    public Func<EraTriggerContext, bool>? Condition { get; }
    public Action<EraTriggerContext> Handler { get; }

    public EraTriggerDefinition(
        string id,
        string ownerId,
        EraTriggerType triggerType,
        Action<EraTriggerContext> handler,
        float chancePercent = 100f,
        Func<EraTriggerContext, bool>? condition = null
    )
    {
        Id = id;
        OwnerId = ownerId;
        TriggerType = triggerType;
        Handler = handler;
        ChancePercent = chancePercent;
        Condition = condition;
    }
}
