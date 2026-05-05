using System.Collections.Generic;

namespace EraWheel.Save.Models;

public sealed class EraKingdomLevelLedgerEntry
{
    public int Level { get; set; }
    public int TotalRenown { get; set; }
    public float GrantedWorldTime { get; set; }
    public List<EraAttributeModifierEntry> Attributes { get; set; } = new List<EraAttributeModifierEntry>();
}

public sealed class EraKingdomRenownLedgerState
{
    public long KingdomId { get; set; }
    public string KingdomName { get; set; } = string.Empty;
    public int LastObservedRenown { get; set; }
    public int TotalAccumulatedRenown { get; set; }
    public int LastAppliedLevel { get; set; }
    public Dictionary<string, float> TotalModifiers { get; set; } = new Dictionary<string, float>();
    public List<EraKingdomLevelLedgerEntry> Entries { get; set; } = new List<EraKingdomLevelLedgerEntry>();
}

public sealed class EraKingdomRenownSnapshot
{
    public int CurrentLevel { get; set; }
    public int TotalAccumulatedRenown { get; set; }
    public IReadOnlyDictionary<string, float> TotalModifiers { get; set; } = new Dictionary<string, float>();
}
