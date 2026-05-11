using EraWheel.Config.Registry;
using EraWheel.Config.Schema;
using EraWheel.Core.Constants;
using EraWheel.Core.Time;
using EraWheel.Reflection;
using EraWheel.Save.Keys;
using EraWheel.Save.Migration;
using EraWheel.Save.Models;
using NeoModLoader.General.Game.extensions;
using Newtonsoft.Json;

namespace EraWheel.Save.Services;

public sealed class EraRuntimeSaveService
{
    private readonly EraParameterRegistry _parameterRegistry;

    public EraWorldRuntimeState CurrentState { get; private set; }
    public bool IsBoundToWorld { get; private set; }
    public bool LoadedFromSave { get; private set; }

    private EraRuntimeSaveService(EraParameterRegistry parameterRegistry, EraWorldRuntimeState state)
    {
        _parameterRegistry = parameterRegistry;
        CurrentState = state;
    }

    public static EraRuntimeSaveService Create(EraParameterRegistry parameterRegistry)
    {
        return new EraRuntimeSaveService(parameterRegistry, CreateDefaultState(parameterRegistry));
    }

    public bool TryAttachCurrentWorld()
    {
        if (!WorldboxReflectionAdapter.TryReadMapStats(out MapStats? mapStats) || mapStats == null)
        {
            IsBoundToWorld = false;
            LoadedFromSave = false;
            return false;
        }

        mapStats.custom_data ??= new SaveCustomData();
        CurrentState.LastObservedWorldTime = (float)mapStats.world_time;
        IsBoundToWorld = true;

        if (mapStats.custom_data.TryGet(EraSaveKeys.RuntimeEnvelope, out EraRuntimeSaveEnvelope envelope))
        {
            CurrentState = NormalizeState(envelope.Data, (float)mapStats.world_time);
            PopulateWorldFingerprint(CurrentState, mapStats);
            LoadedFromSave = true;
            return true;
        }

        CurrentState = CreateDefaultState(_parameterRegistry);
        CurrentState.LastObservedWorldTime = (float)mapStats.world_time;
        PopulateWorldFingerprint(CurrentState, mapStats);
        LoadedFromSave = false;
        return false;
    }

    public bool PersistIfPossible()
    {
        if (!WorldboxReflectionAdapter.TryReadMapStats(out MapStats? mapStats) || mapStats == null)
        {
            IsBoundToWorld = false;
            return false;
        }

        mapStats.custom_data ??= new SaveCustomData();
        CurrentState.LastObservedWorldTime = (float)mapStats.world_time;
        mapStats.custom_data.Set(EraSaveKeys.RuntimeEnvelope, new EraRuntimeSaveEnvelope(CurrentState));
        IsBoundToWorld = true;
        return true;
    }

    public void RestoreState(EraWorldRuntimeState state, bool loadedFromSave)
    {
        CurrentState = NormalizeState(state, CurrentState.LastObservedWorldTime);
        LoadedFromSave = loadedFromSave;
    }

    public EraWorldRuntimeState CloneCurrentState()
    {
        string json = JsonConvert.SerializeObject(CurrentState);
        return JsonConvert.DeserializeObject<EraWorldRuntimeState>(json) ?? CreateDefaultState(_parameterRegistry);
    }

    public string CreateStatusReport()
    {
        return $"世界绑定={(IsBoundToWorld ? "已连接" : "未连接")}；来源={(LoadedFromSave ? "读档恢复" : "内存默认态")}；阶段={CurrentState.Stage}；当前轮完成数={CurrentState.CompletedCycles}；本轮魔王={CurrentState.CurrentDemonIds.Count} 名。";
    }

    private static EraWorldRuntimeState CreateDefaultState(EraParameterRegistry parameterRegistry)
    {
        EraReincarnationParameters parameters = parameterRegistry.Current.Reincarnation;
        return new EraWorldRuntimeState
        {
            Stage = EraStage.PreDevelopment,
            CompletedCycles = 0,
            WorldTier = 1,
            WorldSeedId = 0,
            WorldLifeDna = 0L,
            GeneralSealPercent = parameters.GeneralSealInitialPercent,
            DemonSealPercent = parameters.DemonSealInitialPercent,
            LastObservedWorldTime = 0f,
            LastSealTickWorldTime = 0f,
            NextPreDevelopmentCheckWorldTime = parameters.PreDevelopmentCheckInterval.WorldTime,
            NextKingdomControlRefreshWorldTime = 0f,
            NextDemonEquipmentRefreshWorldTime = parameterRegistry.Current.Advancement.DemonEquipmentRefreshInterval.WorldTime,
            NextLegionWaveWorldTime = parameterRegistry.Current.Legions.SpawnInterval.WorldTime,
            NextRelationshipCheckWorldTime = parameterRegistry.Current.Demons.RelationshipCheckInterval.WorldTime,
            NextProgressionCheckWorldTime = EraWorldTime.GetMonthWorldTime(),
            NextRuntimePersistWorldTime = EraWorldTime.GetMonthWorldTime(),
            CycleSeed = 0,
            LegionWaveIndex = 0,
            SpawnedLegions = new System.Collections.Generic.List<EraLegionSpawnState>(),
            DemonInteraction = new EraDemonInteractionState(),
            ReconstructionStartedWorldTime = 0f,
            LastVictoryWorldTime = 0f,
            BattleResultRecorded = false,
            AdvancementApplied = false,
            ReconstructionResetCompleted = false,
            HistoryRecorded = false,
            LastCycleSummary = string.Empty,
            CycleHistory = new System.Collections.Generic.List<EraCycleHistoryRecord>(),
        };
    }

    private static EraWorldRuntimeState NormalizeState(EraWorldRuntimeState? state, float worldTime)
    {
        EraWorldRuntimeState normalized = state ?? new EraWorldRuntimeState();
        normalized.CurrentDemonIds ??= new System.Collections.Generic.List<string>();
        normalized.FortressBindings ??= new System.Collections.Generic.List<EraFortressBindingState>();
        normalized.SpawnedGenerals ??= new System.Collections.Generic.List<EraGeneralSpawnState>();
        normalized.SpawnedDemons ??= new System.Collections.Generic.List<EraDemonSpawnState>();
        normalized.SpawnedLegions ??= new System.Collections.Generic.List<EraLegionSpawnState>();
        normalized.DemonInteraction ??= new EraDemonInteractionState();
        normalized.DemonInteraction.CivilWarWinner ??= new EraCivilWarWinnerState();
        normalized.RandomStreams ??= new System.Collections.Generic.List<EraRandomStreamState>();
        normalized.GrowthTracks ??= new System.Collections.Generic.List<EraGrowthTrackState>();
        normalized.EventLog ??= new System.Collections.Generic.List<EraRuntimeEventRecord>();
        normalized.KingdomTiers ??= new System.Collections.Generic.List<EraKingdomTierState>();
        normalized.UnlockedHeritageEquipment ??= new System.Collections.Generic.List<EraHeritageUnlockLedgerEntry>();
        normalized.UnlockedHeritageTraits ??= new System.Collections.Generic.List<EraHeritageUnlockLedgerEntry>();
        normalized.HeritageInstanceAudit ??= new System.Collections.Generic.List<EraHeritageInstanceAuditEntry>();
        normalized.KingdomRenownLedgers ??= new System.Collections.Generic.List<EraKingdomRenownLedgerState>();
        normalized.KingdomHeroTrackers ??= new System.Collections.Generic.List<EraKingdomHeroTrackerState>();
        normalized.HeroArchives ??= new System.Collections.Generic.List<EraHeroArchiveState>();
        normalized.SurvivorKingdomIds ??= new System.Collections.Generic.List<long>();
        normalized.CycleHistory ??= new System.Collections.Generic.List<EraCycleHistoryRecord>();
        normalized.LastObservedWorldTime = worldTime;
        if (normalized.LastSealTickWorldTime <= 0f)
        {
            normalized.LastSealTickWorldTime = worldTime;
        }
        if (normalized.NextKingdomControlRefreshWorldTime <= 0f)
        {
            normalized.NextKingdomControlRefreshWorldTime = worldTime;
        }
        if (normalized.NextDemonEquipmentRefreshWorldTime <= 0f)
        {
            normalized.NextDemonEquipmentRefreshWorldTime = worldTime;
        }
        if (normalized.NextRuntimePersistWorldTime <= 0f)
        {
            normalized.NextRuntimePersistWorldTime = worldTime + EraWorldTime.GetMonthWorldTime();
        }
        if (normalized.NextProgressionCheckWorldTime <= 0f)
        {
            normalized.NextProgressionCheckWorldTime = worldTime;
        }
        return normalized;
    }

    private static void PopulateWorldFingerprint(EraWorldRuntimeState state, MapStats mapStats)
    {
        if (state == null || mapStats == null)
        {
            return;
        }

        if (state.WorldSeedId == 0)
        {
            state.WorldSeedId = MapBox.current_world_seed_id;
        }

        if (state.WorldLifeDna == 0L)
        {
            state.WorldLifeDna = mapStats.life_dna;
        }
    }
}
