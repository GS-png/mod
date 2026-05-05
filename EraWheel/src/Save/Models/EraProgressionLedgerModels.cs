using System.Collections.Generic;

namespace EraWheel.Save.Models;

public interface IEraHeritageInstanceRoll
{
    float GrantedWorldTime { get; set; }
    int GrantedCycle { get; set; }
    int UnlockTier { get; set; }
    int GrantedTier { get; set; }
    int SourceWorldTier { get; set; }
    long SourceKingdomId { get; set; }
    int SourceKingdomTier { get; set; }
    long GrantedActorId { get; set; }
    string GrantedActorName { get; set; }
    string Source { get; set; }
    List<EraAttributeModifierEntry> Attributes { get; set; }
}

public sealed class EraTraitInstanceAttributeState : IEraHeritageInstanceRoll
{
    public string TraitId { get; set; } = string.Empty;
    public float GrantedWorldTime { get; set; }
    public int GrantedCycle { get; set; }
    public int UnlockTier { get; set; }
    public int GrantedTier { get; set; }
    public int SourceWorldTier { get; set; }
    public long SourceKingdomId { get; set; }
    public int SourceKingdomTier { get; set; }
    public long GrantedActorId { get; set; }
    public string GrantedActorName { get; set; } = string.Empty;
    public string Source { get; set; } = string.Empty;
    public List<EraAttributeModifierEntry> Attributes { get; set; } = new List<EraAttributeModifierEntry>();
}

public sealed class EraEquipmentInstanceAttributeState : IEraHeritageInstanceRoll
{
    public string EquipmentId { get; set; } = string.Empty;
    public float GrantedWorldTime { get; set; }
    public int GrantedCycle { get; set; }
    public int UnlockTier { get; set; }
    public int GrantedTier { get; set; }
    public int SourceWorldTier { get; set; }
    public long SourceKingdomId { get; set; }
    public int SourceKingdomTier { get; set; }
    public long GrantedActorId { get; set; }
    public string GrantedActorName { get; set; } = string.Empty;
    public long GrantedItemId { get; set; }
    public string Source { get; set; } = string.Empty;
    public List<EraAttributeModifierEntry> Attributes { get; set; } = new List<EraAttributeModifierEntry>();
}

public sealed class EraHeritageUnlockLedgerEntry
{
    public string Kind { get; set; } = string.Empty;
    public string DefinitionId { get; set; } = string.Empty;
    public int UnlockTier { get; set; }
    public int GrantedCycle { get; set; }
    public float GrantedWorldTime { get; set; }
    public int SourceWorldTier { get; set; }
    public string Source { get; set; } = string.Empty;
}

public sealed class EraHeritageInstanceAuditEntry : IEraHeritageInstanceRoll
{
    public string Kind { get; set; } = string.Empty;
    public string DefinitionId { get; set; } = string.Empty;
    public float GrantedWorldTime { get; set; }
    public int GrantedCycle { get; set; }
    public int UnlockTier { get; set; }
    public int GrantedTier { get; set; }
    public int SourceWorldTier { get; set; }
    public long SourceKingdomId { get; set; }
    public int SourceKingdomTier { get; set; }
    public long GrantedActorId { get; set; }
    public string GrantedActorName { get; set; } = string.Empty;
    public long GrantedItemId { get; set; }
    public string Source { get; set; } = string.Empty;
    public List<EraAttributeModifierEntry> Attributes { get; set; } = new List<EraAttributeModifierEntry>();
}

public sealed class EraHeroPromotionAttributeState
{
    public float GrantedWorldTime { get; set; }
    public List<EraAttributeModifierEntry> Attributes { get; set; } = new List<EraAttributeModifierEntry>();
}

public sealed class EraHeroProgressionState
{
    public bool IsHero { get; set; }
    public string PromotionReason { get; set; } = string.Empty;
    public string TitleSuffix { get; set; } = string.Empty;
    public float PromotedWorldTime { get; set; }
    public EraHeroPromotionAttributeState Promotion { get; set; } = new EraHeroPromotionAttributeState();
    public EraHeroPromotionAttributeState Inheritance { get; set; } = new EraHeroPromotionAttributeState();
}

public sealed class EraHeroArchiveState
{
    public long HeroActorId { get; set; }
    public string HeroName { get; set; } = string.Empty;
    public float PromotedWorldTime { get; set; }
    public List<EraAttributeModifierEntry> PromotionAttributes { get; set; } = new List<EraAttributeModifierEntry>();
}

public sealed class EraKingdomHeroTrackerState
{
    public long KingdomId { get; set; }
    public string KingdomName { get; set; } = string.Empty;
    public int LastObservedPopulation { get; set; }
    public int AccumulatedPopulationGrowth { get; set; }
    public int ConsumedProsperityPromotions { get; set; }
    public int PendingPromotionCharges { get; set; }
    public float CrisisWindowStartedWorldTime { get; set; }
    public int CrisisWindowStartPopulation { get; set; }
}
