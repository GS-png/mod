using System.Collections.Generic;
using EraWheel.Core.Constants;

namespace EraWheel.Save.Models;

public sealed class EraFortressBindingState
{
    public string DemonId { get; set; } = string.Empty;
    public long BuildingId { get; set; }
    public int TileX { get; set; }
    public int TileY { get; set; }
}

public sealed class EraGeneralSpawnState
{
    public string GeneralId { get; set; } = string.Empty;
    public string DemonId { get; set; } = string.Empty;
    public long ActorId { get; set; }
    public long FortressBuildingId { get; set; }
    public int TileX { get; set; }
    public int TileY { get; set; }
}

public sealed class EraDemonSpawnState
{
    public string DemonId { get; set; } = string.Empty;
    public long ActorId { get; set; }
    public long FortressBuildingId { get; set; }
    public int TileX { get; set; }
    public int TileY { get; set; }
}

public sealed class EraLegionSpawnState
{
    public string LegionId { get; set; } = string.Empty;
    public string DemonId { get; set; } = string.Empty;
    public int WaveIndex { get; set; }
    public long ActorId { get; set; }
    public long FortressBuildingId { get; set; }
    public int TileX { get; set; }
    public int TileY { get; set; }
}

public sealed class EraDemonInteractionState
{
    public bool Active { get; set; }
    public EraDemonInteractionMode Mode { get; set; } = EraDemonInteractionMode.Alliance;
    public string Description { get; set; } = string.Empty;
    public float LastResolvedWorldTime { get; set; }
    public bool UsesRandomRoll { get; set; }
    public float LastRandomRollWorldTime { get; set; }
    public EraCivilWarWinnerState CivilWarWinner { get; set; } = new EraCivilWarWinnerState();
}

public sealed class EraCivilWarWinnerState
{
    public string DemonId { get; set; } = string.Empty;
    public long ActorId { get; set; }
    public string Title { get; set; } = string.Empty;
    public float BonusPercent { get; set; }
    public float BonusEndWorldTime { get; set; }
}

public sealed class EraCycleHistoryRecord
{
    public int CycleNumber { get; set; }
    public string Summary { get; set; } = string.Empty;
    public float RecordedWorldTime { get; set; }
}

public sealed class EraRandomStreamState
{
    public string StreamKey { get; set; } = string.Empty;
    public int Cursor { get; set; }
}

public sealed class EraGrowthAttributeRangeState
{
    public string AttributeId { get; set; } = string.Empty;
    public float InitialMin { get; set; }
    public float InitialWidth { get; set; }
    public float ActiveMin { get; set; }
    public float ActiveMax { get; set; }
    public float FrozenMin { get; set; }
    public float FrozenMax { get; set; }
    public float SampleTotal { get; set; }
    public int SampleCount { get; set; }
}

public sealed class EraGrowthTrackState
{
    public string TrackId { get; set; } = string.Empty;
    public int FrozenCycleNumber { get; set; } = -1;
    public List<EraGrowthAttributeRangeState> Attributes { get; set; } = new List<EraGrowthAttributeRangeState>();
}

public sealed class EraRuntimeEventRecord
{
    public long Sequence { get; set; }
    public string Channel { get; set; } = string.Empty;
    public string EventId { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public float WorldTime { get; set; }
    public int CompletedCycles { get; set; }
    public EraStage Stage { get; set; }
}

public sealed class EraKingdomTierState
{
    public long KingdomId { get; set; }
    public string KingdomName { get; set; } = string.Empty;
    public float ControlScore { get; set; }
    public int Cities { get; set; }
    public int Population { get; set; }
    public int Military { get; set; }
    public int Books { get; set; }
    public int BaseTier { get; set; } = 1;
    public int EffectiveTier { get; set; } = 1;
    public bool IsSurvivorKingdom { get; set; }
    public float LastRefreshWorldTime { get; set; }
}

public sealed class EraWorldRuntimeState
{
    public EraStage Stage { get; set; } = EraStage.PreDevelopment;
    public int CompletedCycles { get; set; }
    public int WorldTier { get; set; } = 1;
    public int WorldSeedId { get; set; }
    public long WorldLifeDna { get; set; }
    public float GeneralSealPercent { get; set; }
    public float DemonSealPercent { get; set; }
    public float LastObservedWorldTime { get; set; }
    public float LastSealTickWorldTime { get; set; }
    public float NextPreDevelopmentCheckWorldTime { get; set; }
    public float NextKingdomControlRefreshWorldTime { get; set; }
    public float NextDemonEquipmentRefreshWorldTime { get; set; }
    public float NextLegionWaveWorldTime { get; set; }
    public float NextRelationshipCheckWorldTime { get; set; }
    public float NextProgressionCheckWorldTime { get; set; }
    public float NextRuntimePersistWorldTime { get; set; }
    public int CycleSeed { get; set; }
    public bool OmenInitialized { get; set; }
    public bool GeneralsSpawned { get; set; }
    public bool DemonsSpawned { get; set; }
    public int LegionWaveIndex { get; set; }
    public List<string> CurrentDemonIds { get; set; } = new List<string>();
    public List<EraFortressBindingState> FortressBindings { get; set; } = new List<EraFortressBindingState>();
    public List<EraGeneralSpawnState> SpawnedGenerals { get; set; } = new List<EraGeneralSpawnState>();
    public List<EraDemonSpawnState> SpawnedDemons { get; set; } = new List<EraDemonSpawnState>();
    public List<EraLegionSpawnState> SpawnedLegions { get; set; } = new List<EraLegionSpawnState>();
    public EraDemonInteractionState DemonInteraction { get; set; } = new EraDemonInteractionState();
    public List<EraRandomStreamState> RandomStreams { get; set; } = new List<EraRandomStreamState>();
    public List<EraGrowthTrackState> GrowthTracks { get; set; } = new List<EraGrowthTrackState>();
    public List<EraRuntimeEventRecord> EventLog { get; set; } = new List<EraRuntimeEventRecord>();
    public List<EraKingdomTierState> KingdomTiers { get; set; } = new List<EraKingdomTierState>();
    public List<EraHeritageUnlockLedgerEntry> UnlockedHeritageEquipment { get; set; } = new List<EraHeritageUnlockLedgerEntry>();
    public List<EraHeritageUnlockLedgerEntry> UnlockedHeritageTraits { get; set; } = new List<EraHeritageUnlockLedgerEntry>();
    public List<EraHeritageInstanceAuditEntry> HeritageInstanceAudit { get; set; } = new List<EraHeritageInstanceAuditEntry>();
    public List<EraKingdomRenownLedgerState> KingdomRenownLedgers { get; set; } = new List<EraKingdomRenownLedgerState>();
    public List<EraKingdomHeroTrackerState> KingdomHeroTrackers { get; set; } = new List<EraKingdomHeroTrackerState>();
    public List<EraHeroArchiveState> HeroArchives { get; set; } = new List<EraHeroArchiveState>();
    public List<long> SurvivorKingdomIds { get; set; } = new List<long>();
    public long EventSequence { get; set; }
    public float ReconstructionStartedWorldTime { get; set; }
    public float LastVictoryWorldTime { get; set; }
    public bool BattleResultRecorded { get; set; }
    public bool AdvancementApplied { get; set; }
    public bool ReconstructionResetCompleted { get; set; }
    public bool HistoryRecorded { get; set; }
    public string LastCycleSummary { get; set; } = string.Empty;
    public List<EraCycleHistoryRecord> CycleHistory { get; set; } = new List<EraCycleHistoryRecord>();
}
