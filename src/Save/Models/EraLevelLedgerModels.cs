using System.Collections.Generic;

namespace EraWheel.Save.Models;

public sealed class EraLevelLedgerEntry
{
    public int Level { get; set; }
    public float GrantedWorldTime { get; set; }
    public List<EraAttributeModifierEntry> Attributes { get; set; } = new List<EraAttributeModifierEntry>();
}

public sealed class EraActorLevelLedgerState
{
    public int LastAppliedLevel { get; set; }
    public Dictionary<string, float> TotalModifiers { get; set; } = new Dictionary<string, float>();
    public List<EraLevelLedgerEntry> Entries { get; set; } = new List<EraLevelLedgerEntry>();
}
