using System.Collections.Generic;

namespace EraWheel.Combat.Statuses;

public enum EraStatusKind
{
    Shield = 0,
    Silence = 1,
    Slow = 2,
    Stun = 3,
    Mark = 4,
    Stack = 5,
    TimedBuff = 6,
    TimedDebuff = 7,
}

public enum EraStatusStackMode
{
    Replace = 0,
    RefreshDuration = 1,
    AddStacks = 2,
    RefreshDurationAndStacks = 3,
}

public sealed class EraStatusDefinition
{
    public EraStatusKind Kind { get; }
    public string StatusId { get; }
    public string DisplayName { get; }
    public string Description { get; }
    public bool NativeStatus { get; }
    public bool BlocksSpellCast { get; }
    public bool SupportsDynamicModifiers { get; }
    public bool SupportsShield { get; }

    public EraStatusDefinition(
        EraStatusKind kind,
        string statusId,
        string displayName,
        string description,
        bool nativeStatus = false,
        bool blocksSpellCast = false,
        bool supportsDynamicModifiers = false,
        bool supportsShield = false
    )
    {
        Kind = kind;
        StatusId = statusId;
        DisplayName = displayName;
        Description = description;
        NativeStatus = nativeStatus;
        BlocksSpellCast = blocksSpellCast;
        SupportsDynamicModifiers = supportsDynamicModifiers;
        SupportsShield = supportsShield;
    }
}

public sealed class EraStatusApplication
{
    public EraStatusKind Kind { get; set; }
    public string RuntimeKey { get; set; } = string.Empty;
    public float DurationWorldTime { get; set; }
    public EraStatusStackMode StackMode { get; set; } = EraStatusStackMode.RefreshDuration;
    public int StackDelta { get; set; } = 1;
    public int MaxStacks { get; set; } = 1;
    public float ShieldAmount { get; set; }
    public bool ColorEffect { get; set; } = true;
    public IReadOnlyDictionary<string, float> StatModifiers { get; set; } = new Dictionary<string, float>();

    public EraStatusApplication()
    {
    }

    public EraStatusApplication(
        EraStatusKind kind,
        float durationWorldTime,
        EraStatusStackMode stackMode = EraStatusStackMode.RefreshDuration,
        int stackDelta = 1,
        int maxStacks = 1,
        float shieldAmount = 0f,
        bool colorEffect = true,
        string runtimeKey = "",
        IReadOnlyDictionary<string, float>? statModifiers = null
    )
    {
        Kind = kind;
        DurationWorldTime = durationWorldTime;
        StackMode = stackMode;
        StackDelta = stackDelta;
        MaxStacks = maxStacks;
        ShieldAmount = shieldAmount;
        ColorEffect = colorEffect;
        RuntimeKey = runtimeKey;
        StatModifiers = statModifiers ?? new Dictionary<string, float>();
    }

    public EraStatusApplication Clone()
    {
        return new EraStatusApplication(
            Kind,
            DurationWorldTime,
            StackMode,
            StackDelta,
            MaxStacks,
            ShieldAmount,
            ColorEffect,
            RuntimeKey,
            new Dictionary<string, float>(StatModifiers)
        );
    }
}

public sealed class EraActiveStatus
{
    public long TargetId { get; set; }
    public EraStatusKind Kind { get; set; }
    public string RuntimeKey { get; set; } = string.Empty;
    public string StatusId { get; set; } = string.Empty;
    public float ExpiresAtWorldTime { get; set; }
    public int Stacks { get; set; }
    public float ShieldAmount { get; set; }
    public Dictionary<string, float> StatModifiers { get; set; } = new Dictionary<string, float>();
}
