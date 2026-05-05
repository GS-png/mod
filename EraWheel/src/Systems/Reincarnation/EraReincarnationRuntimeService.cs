using System;
using System.Collections.Generic;
using System.Linq;
using EraWheel.Config.Registry;
using EraWheel.Config.Schema;
using EraWheel.Core.Constants;
using EraWheel.Core.Events;
using EraWheel.Core.Logging;
using EraWheel.Core.Random;
using EraWheel.Core.Time;
using EraWheel.Data.Definitions;
using EraWheel.Reflection;
using EraWheel.Save.Models;
using EraWheel.Save.Services;
using EraWheel.Systems.Advancement;
using EraWheel.Systems.Progression;

namespace EraWheel.Systems.Reincarnation;

public sealed class EraReincarnationRuntimeService
{
    private const int StrongholdPlacementAttempts = 96;
    private const int NearbyFallbackRadius = 12;

    private readonly EraParameterRegistry _parameterRegistry;
    private readonly EraRuntimeSaveService _runtimeSave;
    private readonly EraStableRandomService _stableRandom;
    private readonly EraEventLogService _eventLog;
    private readonly EraContentCatalog _contentCatalog;
    private readonly EraGrowthRangeManager _growthRanges;
    private readonly EraAdvancementRuntimeService _advancementRuntime;
    private readonly EraSpawnAnchorService _spawnAnchors;
    private readonly EraLegionWaveService _legionWaves;
    private readonly EraAutoFavoriteService _autoFavorites;
    private readonly EraDemonInteractionService _demonInteractions;

    public EraReincarnationRuntimeService(
        EraParameterRegistry parameterRegistry,
        EraRuntimeSaveService runtimeSave,
        EraStableRandomService stableRandom,
        EraEventLogService eventLog,
        EraContentCatalog contentCatalog,
        EraGrowthRangeManager growthRanges,
        EraAdvancementRuntimeService advancementRuntime
    )
    {
        _parameterRegistry = parameterRegistry;
        _runtimeSave = runtimeSave;
        _stableRandom = stableRandom;
        _eventLog = eventLog;
        _contentCatalog = contentCatalog;
        _growthRanges = growthRanges;
        _advancementRuntime = advancementRuntime;
        _spawnAnchors = new EraSpawnAnchorService(runtimeSave, contentCatalog);
        _legionWaves = new EraLegionWaveService(parameterRegistry.Current.Legions);
        _autoFavorites = new EraAutoFavoriteService();
        _demonInteractions = new EraDemonInteractionService(parameterRegistry, stableRandom);
    }

    public void Update()
    {
        if (!WorldboxReflectionAdapter.TryReadMapStats(out MapStats? mapStats) || mapStats == null)
        {
            return;
        }

        float currentWorldTime = (float)mapStats.world_time;
        if (!_runtimeSave.IsBoundToWorld || currentWorldTime + 0.01f < _runtimeSave.CurrentState.LastObservedWorldTime)
        {
            _runtimeSave.TryAttachCurrentWorld();
            RebindRuntimeStateDependencies();
            currentWorldTime = _runtimeSave.CurrentState.LastObservedWorldTime;
        }

        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        float elapsedWorldTime = Math.Max(0f, currentWorldTime - state.LastObservedWorldTime);
        state.LastObservedWorldTime = currentWorldTime;

        bool stateChanged = false;
        switch (state.Stage)
        {
            case EraStage.PreDevelopment:
                stateChanged = UpdatePreDevelopment(mapStats, currentWorldTime);
                break;
            case EraStage.Omen:
                stateChanged = UpdateOmen(currentWorldTime);
                break;
            case EraStage.Awakening:
                stateChanged = UpdateAwakening(currentWorldTime, elapsedWorldTime);
                break;
            case EraStage.Advent:
                stateChanged = UpdateAdvent(currentWorldTime);
                break;
            case EraStage.Reconstruction:
                stateChanged = UpdateReconstruction(currentWorldTime);
                break;
        }

        if (currentWorldTime >= state.NextRuntimePersistWorldTime || stateChanged)
        {
            state.NextRuntimePersistWorldTime = currentWorldTime + EraWorldTime.GetMonthWorldTime();
            _runtimeSave.PersistIfPossible();
        }
    }

    public bool DebugJumpToOmen()
    {
        if (!TryGetCurrentWorldTime(out float currentWorldTime))
        {
            return false;
        }

        ResetTrackedSpawnState();
        BeginOmen(currentWorldTime);
        EnsureOmenInitialized(currentWorldTime);
        _runtimeSave.PersistIfPossible();
        EraLog.Info(EraLogCategory.Debug, "EW-051 调试动作：已强制跳到预兆。");
        return true;
    }

    public bool DebugJumpToAwakening()
    {
        if (!EnsureDebugOmenReady(out float currentWorldTime))
        {
            return false;
        }

        ResetTrackedSpawnState();
        EnterAwakening(currentWorldTime);
        _runtimeSave.PersistIfPossible();
        EraLog.Info(EraLogCategory.Debug, "EW-051 调试动作：已强制跳到苏醒。");
        return true;
    }

    public bool DebugJumpToAdvent()
    {
        if (!EnsureDebugOmenReady(out float currentWorldTime))
        {
            return false;
        }

        ResetTrackedSpawnState();
        EnterAwakening(currentWorldTime);
        EnterAdvent(currentWorldTime);
        _runtimeSave.PersistIfPossible();
        EraLog.Info(EraLogCategory.Debug, "EW-051 调试动作：已强制跳到降临。");
        return true;
    }

    public bool DebugResetSeals()
    {
        if (!EnsureDebugOmenReady(out float currentWorldTime))
        {
            return false;
        }

        ResetTrackedSpawnState();
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        EraReincarnationParameters parameters = _parameterRegistry.Current.Reincarnation;
        state.Stage = EraStage.Omen;
        state.GeneralSealPercent = parameters.GeneralSealInitialPercent;
        state.DemonSealPercent = parameters.DemonSealInitialPercent;
        state.LastSealTickWorldTime = currentWorldTime;
        _runtimeSave.PersistIfPossible();
        EraLog.Info(EraLogCategory.Debug, "EW-051 调试动作：已重置双封印并回到预兆。");
        return true;
    }

    public bool DebugForceReconstruction()
    {
        if (!TryGetCurrentWorldTime(out float currentWorldTime))
        {
            return false;
        }

        EnterReconstruction(currentWorldTime);
        _runtimeSave.PersistIfPossible();
        EraLog.Info(EraLogCategory.Debug, "EW-051 调试动作：已强制进入战后重建。");
        return true;
    }

    public string CreateStatusReport()
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        return
            $"阶段驱动=已初始化；阶段={state.Stage}；将领封印={state.GeneralSealPercent:F1}%；魔王封印={state.DemonSealPercent:F1}%；" +
            $"预兆初始化={(state.OmenInitialized ? "已完成" : "未完成")}；将领生成={(state.GeneralsSpawned ? "已完成" : "未完成")}；" +
            $"魔王生成={(state.DemonsSpawned ? "已完成" : "未完成")}；军团波次={state.LegionWaveIndex}；当前军团={state.SpawnedLegions.Count}；" +
            $"多魔王模式={GetInteractionStatusLabel(state)}；本轮魔王={state.CurrentDemonIds.Count}；据点绑定={state.FortressBindings.Count}；" +
            $"结算步骤={GetReconstructionProgressLabel(state)}。";
    }

    private bool UpdatePreDevelopment(MapStats mapStats, float currentWorldTime)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        EraReincarnationParameters parameters = _parameterRegistry.Current.Reincarnation;
        if (currentWorldTime < state.NextPreDevelopmentCheckWorldTime)
        {
            return false;
        }

        state.NextPreDevelopmentCheckWorldTime = currentWorldTime + parameters.PreDevelopmentCheckInterval.WorldTime;
        if (mapStats.population < parameters.OmenPopulationThreshold)
        {
            return true;
        }

        BeginOmen(currentWorldTime);
        return true;
    }

    private bool UpdateOmen(float currentWorldTime)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        bool stateChanged = EnsureOmenInitialized(currentWorldTime);
        if (!state.OmenInitialized)
        {
            return stateChanged;
        }

        stateChanged |= RefreshDemonInteractionState(currentWorldTime);
        stateChanged |= UpdateLegionWaves(currentWorldTime);

        float generalSealBefore = state.GeneralSealPercent;
        state.GeneralSealPercent = DecaySeal(
            state.GeneralSealPercent,
            _parameterRegistry.Current.Reincarnation.GeneralSealDecayPercentPerYear,
            currentWorldTime - state.LastSealTickWorldTime
        );
        state.LastSealTickWorldTime = currentWorldTime;
        stateChanged |= !NearlyEqual(generalSealBefore, state.GeneralSealPercent);

        if (state.GeneralSealPercent <= 0f)
        {
            EnterAwakening(currentWorldTime);
            stateChanged = true;
        }

        return stateChanged;
    }

    private bool EnsureOmenInitialized(float currentWorldTime)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        bool stateChanged = false;

        if (state.CurrentDemonIds.Count == 0)
        {
            List<EraDemonManifest> selectedDemons = SelectCurrentCycleDemons();
            state.CurrentDemonIds.Clear();
            state.FortressBindings.Clear();
            foreach (EraDemonManifest demon in selectedDemons)
            {
                state.CurrentDemonIds.Add(demon.InternalId);
            }

            stateChanged = selectedDemons.Count > 0;
        }

        foreach (string demonId in state.CurrentDemonIds)
        {
            if (state.FortressBindings.Any(item => item.DemonId == demonId))
            {
                continue;
            }

            EraStrongholdManifest? stronghold = _contentCatalog.Strongholds
                .FirstOrDefault(item => item.DemonInternalId == demonId);
            if (stronghold == null)
            {
                EraLog.Warning(EraLogCategory.Data, $"未找到对应据点模板，已跳过：{demonId}");
                continue;
            }

            EraFortressBindingState? binding = TryCreateStrongholdBinding(stronghold);
            if (binding != null)
            {
                state.FortressBindings.Add(binding);
                stateChanged = true;
            }
        }

        bool initializationComplete = state.CurrentDemonIds.Count > 0
            && state.CurrentDemonIds.All(demonId => state.FortressBindings.Any(item => item.DemonId == demonId));
        if (!initializationComplete)
        {
            return stateChanged;
        }

        if (!state.OmenInitialized)
        {
            state.OmenInitialized = true;
            string demonNames = string.Join(
                "、",
                state.CurrentDemonIds
                    .Select(id => _contentCatalog.DemonsById.TryGetValue(id, out EraDemonManifest? demon) ? demon.DisplayName : id)
            );
            _eventLog.Append(
                "reincarnation",
                "omen_initialized",
                $"EW-042 预兆初始化完成：本轮魔王={demonNames}；据点={state.FortressBindings.Count} 座；时间={EraWorldTime.GetYearDate(currentWorldTime)}。"
            );
            EraLog.Info(EraLogCategory.Events, $"EW-042 预兆初始化完成：{demonNames}。");
            stateChanged = true;
        }

        return stateChanged;
    }

    private bool UpdateAwakening(float currentWorldTime, float elapsedWorldTime)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        bool stateChanged = false;

        if (!state.GeneralsSpawned)
        {
            stateChanged |= TrySpawnMissingGenerals();
        }

        stateChanged |= RefreshDemonInteractionState(currentWorldTime);
        stateChanged |= UpdateLegionWaves(currentWorldTime);

        float demonSealBefore = state.DemonSealPercent;
        state.DemonSealPercent = DecaySeal(
            state.DemonSealPercent,
            _parameterRegistry.Current.Reincarnation.DemonSealDecayPercentPerYear,
            elapsedWorldTime
        );
        stateChanged |= !NearlyEqual(demonSealBefore, state.DemonSealPercent);

        if (state.DemonSealPercent <= 0f && state.Stage != EraStage.Advent)
        {
            EnterAdvent(currentWorldTime);
            stateChanged = true;
        }

        return stateChanged;
    }

    private bool UpdateAdvent(float currentWorldTime)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        bool stateChanged = false;

        if (!state.DemonsSpawned)
        {
            stateChanged |= TrySpawnMissingDemons();
        }

        stateChanged |= RefreshDemonInteractionState(currentWorldTime);
        stateChanged |= UpdateLegionWaves(currentWorldTime);

        (int aliveDemons, bool actorStateUpdated) = CountAliveDemons();
        stateChanged |= actorStateUpdated;
        stateChanged |= MaintainCivilWarWinnerBonus(currentWorldTime);
        if (state.DemonsSpawned && state.SpawnedDemons.Count > 0 && aliveDemons <= 0)
        {
            EnterReconstruction(currentWorldTime);
            return true;
        }

        return stateChanged;
    }

    private bool UpdateReconstruction(float currentWorldTime)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        if (!state.BattleResultRecorded)
        {
            RecordBattleResult(currentWorldTime);
            return true;
        }

        if (!state.AdvancementApplied)
        {
            ApplyCycleAdvancement(currentWorldTime);
            return true;
        }

        if (!state.ReconstructionResetCompleted)
        {
            ResetCurrentCycleEntities(currentWorldTime);
            return true;
        }

        if (!state.HistoryRecorded)
        {
            RecordCycleHistory(currentWorldTime);
            return true;
        }

        CompleteReconstruction(currentWorldTime);
        return true;
    }

    private void BeginOmen(float currentWorldTime)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        EraReincarnationParameters reincarnation = _parameterRegistry.Current.Reincarnation;
        EraLegionParameters legions = _parameterRegistry.Current.Legions;
        EraDemonParameters demons = _parameterRegistry.Current.Demons;

        state.Stage = EraStage.Omen;
        state.OmenInitialized = false;
        state.GeneralsSpawned = false;
        state.DemonsSpawned = false;
        state.LegionWaveIndex = 0;
        state.GeneralSealPercent = reincarnation.GeneralSealInitialPercent;
        state.DemonSealPercent = reincarnation.DemonSealInitialPercent;
        state.LastSealTickWorldTime = currentWorldTime;
        state.NextLegionWaveWorldTime = currentWorldTime;
        state.NextRelationshipCheckWorldTime = currentWorldTime + demons.RelationshipCheckInterval.WorldTime;
        ResetAllDemonKingdomRelations();
        state.CurrentDemonIds.Clear();
        state.FortressBindings.Clear();
        state.SpawnedGenerals.Clear();
        state.SpawnedDemons.Clear();
        state.SpawnedLegions.Clear();
        ResetDemonInteractionState(state);
        state.ReconstructionStartedWorldTime = 0f;
        state.LastVictoryWorldTime = 0f;
        state.BattleResultRecorded = false;
        state.AdvancementApplied = false;
        state.ReconstructionResetCompleted = false;
        state.HistoryRecorded = false;
        state.LastCycleSummary = string.Empty;
        _stableRandom.ResetForNewCycle();
        _eventLog.Append(
            "reincarnation",
            "stage_omen",
            $"人口达到 { _parameterRegistry.Current.Reincarnation.OmenPopulationThreshold }，已进入预兆。时间={EraWorldTime.GetYearDate(currentWorldTime)}。"
        );
        EraLog.Info(EraLogCategory.Events, "EW-040~041 已进入预兆阶段。");
    }

    private void EnterAwakening(float currentWorldTime)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        if (state.Stage == EraStage.Awakening)
        {
            return;
        }

        state.Stage = EraStage.Awakening;
        state.GeneralSealPercent = 0f;
        state.DemonSealPercent = _parameterRegistry.Current.Reincarnation.DemonSealInitialPercent;
        _eventLog.Append(
            "reincarnation",
            "stage_awakening",
            $"将领封印归零，已进入苏醒。时间={EraWorldTime.GetYearDate(currentWorldTime)}。"
        );
        EraLog.Info(EraLogCategory.Events, "EW-040~043 已进入苏醒阶段。");
        TrySpawnMissingGenerals();
    }

    private void EnterAdvent(float currentWorldTime)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        if (state.Stage == EraStage.Advent)
        {
            return;
        }

        state.Stage = EraStage.Advent;
        state.DemonSealPercent = 0f;
        state.DemonsSpawned = false;
        _eventLog.Append(
            "reincarnation",
            "stage_advent",
            $"魔王封印归零，已进入降临。时间={EraWorldTime.GetYearDate(currentWorldTime)}。"
        );
        EraLog.Info(EraLogCategory.Events, "EW-040~044 已进入降临阶段。");
        TrySpawnMissingDemons();
    }

    private bool TrySpawnMissingGenerals()
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        if (World.world == null)
        {
            return false;
        }

        bool stateChanged = false;
        foreach (string demonId in state.CurrentDemonIds)
        {
            foreach (EraGeneralManifest general in _contentCatalog.Generals.Where(item => item.DemonInternalId == demonId))
            {
                if (state.SpawnedGenerals.Any(item => item.GeneralId == general.InternalId))
                {
                    continue;
                }

                if (!_spawnAnchors.TrySpawnActorAtBoundFortress(
                        general.InternalId,
                        demonId,
                        6f,
                        out Actor? actor,
                        out EraFortressBindingState? fortress,
                        out WorldTile? spawnTile
                    ) || actor == null || spawnTile == null)
                {
                    EraLog.Warning(EraLogCategory.Save, $"将领未能从对应据点出生，已跳过：{general.InternalId}");
                    continue;
                }

                WorldTile actorTile = actor.current_tile ?? spawnTile;
                state.SpawnedGenerals.Add(
                    new EraGeneralSpawnState
                    {
                        GeneralId = general.InternalId,
                        DemonId = demonId,
                        ActorId = actor.getID(),
                        FortressBuildingId = fortress?.BuildingId ?? 0L,
                        TileX = actorTile.x,
                        TileY = actorTile.y,
                    }
                );
                stateChanged = true;
                _eventLog.Append(
                    "reincarnation",
                    "general_spawned",
                    $"EW-043 将领已苏醒：{general.DisplayName} -> {demonId}。"
                );
                TryAutoFavoriteActor(actor, $"将领 {general.DisplayName}");
                _advancementRuntime.TryEquipSpawnLoadout(actor, EraAdvancementLoadoutRole.General);
            }
        }

        int expectedGeneralCount = _contentCatalog.Generals
            .Count(item => state.CurrentDemonIds.Contains(item.DemonInternalId));
        if (expectedGeneralCount > 0 && state.SpawnedGenerals.Count >= expectedGeneralCount)
        {
            stateChanged |= !state.GeneralsSpawned;
            state.GeneralsSpawned = true;
        }

        return stateChanged;
    }

    private bool TrySpawnMissingDemons()
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        if (World.world == null)
        {
            return false;
        }

        bool stateChanged = false;
        foreach (string demonId in state.CurrentDemonIds)
        {
            if (state.SpawnedDemons.Any(item => item.DemonId == demonId))
            {
                continue;
            }

            if (!_spawnAnchors.TrySpawnActorAtBoundFortress(
                    demonId,
                    demonId,
                    8f,
                    out Actor? actor,
                    out EraFortressBindingState? fortress,
                    out WorldTile? spawnTile
                ) || actor == null || spawnTile == null)
            {
                EraLog.Warning(EraLogCategory.Save, $"魔王未能从对应据点出生，已跳过：{demonId}");
                continue;
            }

            WorldTile actorTile = actor.current_tile ?? spawnTile;
            state.SpawnedDemons.Add(
                new EraDemonSpawnState
                {
                    DemonId = demonId,
                    ActorId = actor.getID(),
                    FortressBuildingId = fortress?.BuildingId ?? 0L,
                    TileX = actorTile.x,
                    TileY = actorTile.y,
                }
            );

            string demonName = GetDemonDisplayName(demonId);
            _eventLog.Append(
                "reincarnation",
                "demon_spawned",
                $"EW-046 魔王已降临：{demonName}。"
            );
            EraLog.Info(EraLogCategory.Events, $"EW-046 魔王已降临：{demonName}。");
            TryAutoFavoriteActor(actor, $"魔王 {demonName}");
            _advancementRuntime.TryEquipSpawnLoadout(actor, EraAdvancementLoadoutRole.Demon);
            stateChanged = true;
        }

        if (state.CurrentDemonIds.Count > 0 && state.SpawnedDemons.Count >= state.CurrentDemonIds.Count)
        {
            stateChanged |= !state.DemonsSpawned;
            state.DemonsSpawned = true;
        }

        return stateChanged;
    }

    private bool UpdateLegionWaves(float currentWorldTime)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        if (World.world == null ||
            !state.OmenInitialized ||
            state.Stage == EraStage.PreDevelopment ||
            state.Stage == EraStage.Reconstruction ||
            state.CurrentDemonIds.Count == 0)
        {
            return false;
        }

        bool stateChanged = PruneTrackedLegions();
        int processedWaves = 0;
        while ((state.LegionWaveIndex <= 0 || currentWorldTime >= state.NextLegionWaveWorldTime) && processedWaves < 8)
        {
            state.LegionWaveIndex++;
            float referenceWorldTime = state.LegionWaveIndex == 1
                ? currentWorldTime
                : state.NextLegionWaveWorldTime;
            state.NextLegionWaveWorldTime = referenceWorldTime + _parameterRegistry.Current.Legions.SpawnInterval.WorldTime;
            stateChanged = true;
            stateChanged |= ExecuteLegionWave(currentWorldTime, state.LegionWaveIndex);
            processedWaves++;
        }

        return stateChanged;
    }

    private bool ExecuteLegionWave(float currentWorldTime, int waveIndex)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        var demonIds = state.CurrentDemonIds
            .Where(HasLegionManifestForDemon)
            .ToList();
        if (demonIds.Count == 0)
        {
            string warning = $"EW-054/055 第{waveIndex}波跳过：当前没有可用的军团模板。";
            _eventLog.Append("reincarnation", "legion_wave_missing_manifest", $"{warning} 时间={EraWorldTime.GetYearDate(currentWorldTime)}。");
            EraLog.Warning(EraLogCategory.Data, warning);
            return false;
        }

        EraLegionWavePlan wavePlan = _legionWaves.CalculateWave(waveIndex, state.SpawnedLegions.Count, demonIds);

        if (wavePlan.IsSkipped)
        {
            _eventLog.Append(
                "reincarnation",
                "legion_wave_skipped",
                $"{wavePlan.Description} 时间={EraWorldTime.GetYearDate(currentWorldTime)}。"
            );
            EraLog.Info(EraLogCategory.Events, wavePlan.Description);
            return false;
        }

        int spawnedCount = 0;
        foreach ((string demonId, int requestedCount) in wavePlan.Allocation)
        {
            EraLegionManifest? legion = GetLegionManifestByDemonId(demonId);
            if (legion == null)
            {
                EraLog.Warning(EraLogCategory.Data, $"未找到对应军团模板，已跳过本波分配：{demonId}");
                continue;
            }

            for (int index = 0; index < requestedCount; index++)
            {
                if (!_spawnAnchors.TrySpawnActorAtBoundFortress(
                        legion.InternalId,
                        demonId,
                        4f,
                        out Actor? actor,
                        out EraFortressBindingState? fortress,
                        out WorldTile? spawnTile
                    ) || actor == null || spawnTile == null)
                {
                    EraLog.Warning(EraLogCategory.Save, $"军团未能从对应据点出生，已跳过：{legion.InternalId}");
                    continue;
                }

                WorldTile actorTile = actor.current_tile ?? spawnTile;
                state.SpawnedLegions.Add(
                    new EraLegionSpawnState
                    {
                        LegionId = legion.InternalId,
                        DemonId = demonId,
                        WaveIndex = waveIndex,
                        ActorId = actor.getID(),
                        FortressBuildingId = fortress?.BuildingId ?? 0L,
                        TileX = actorTile.x,
                        TileY = actorTile.y,
                    }
                );
                _advancementRuntime.TryEquipSpawnLoadout(actor, EraAdvancementLoadoutRole.Legion);
                spawnedCount++;
            }
        }

        string message = spawnedCount >= wavePlan.ActualCount
            ? wavePlan.Description
            : $"{wavePlan.Description} 实际成功生成 {spawnedCount}/{wavePlan.ActualCount}。";
        _eventLog.Append(
            "reincarnation",
            "legion_wave_spawned",
            $"{message} 时间={EraWorldTime.GetYearDate(currentWorldTime)}。"
        );
        EraLog.Info(EraLogCategory.Events, message);
        return spawnedCount > 0;
    }

    private bool PruneTrackedLegions()
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        bool stateChanged = false;

        for (int index = state.SpawnedLegions.Count - 1; index >= 0; index--)
        {
            EraLegionSpawnState spawnState = state.SpawnedLegions[index];
            Actor? actor = ResolveActorByState(spawnState.LegionId, spawnState.ActorId, spawnState.TileX, spawnState.TileY);
            if (actor == null || !actor.isAlive())
            {
                state.SpawnedLegions.RemoveAt(index);
                stateChanged = true;
                continue;
            }

            long resolvedActorId = actor.getID();
            if (spawnState.ActorId != resolvedActorId)
            {
                spawnState.ActorId = resolvedActorId;
                WorldTile? actorTile = actor.current_tile;
                if (actorTile != null)
                {
                    spawnState.TileX = actorTile.x;
                    spawnState.TileY = actorTile.y;
                }

                stateChanged = true;
            }
        }

        return stateChanged;
    }

    private bool RefreshDemonInteractionState(float currentWorldTime)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        EraDemonInteractionSnapshot snapshot = _demonInteractions.ResolveState(
            state.CurrentDemonIds,
            state.Stage,
            currentWorldTime,
            state.DemonInteraction,
            state.NextRelationshipCheckWorldTime
        );
        bool changed = state.DemonInteraction.Active != snapshot.IsActive ||
                       state.DemonInteraction.Mode != snapshot.Mode ||
                       !string.Equals(state.DemonInteraction.Description, snapshot.Description, StringComparison.Ordinal) ||
                       !NearlyEqual(state.NextRelationshipCheckWorldTime, snapshot.NextCheckWorldTime) ||
                       state.DemonInteraction.UsesRandomRoll != snapshot.UsesRandomRoll;
        bool relationApplied = false;
        if (changed || state.DemonInteraction.LastResolvedWorldTime <= 0f)
        {
            relationApplied = ApplyDemonInteractionSnapshot(snapshot);
        }

        if (!changed)
        {
            return relationApplied;
        }

        state.DemonInteraction.Active = snapshot.IsActive;
        state.DemonInteraction.Mode = snapshot.Mode;
        state.DemonInteraction.Description = snapshot.Description;
        state.DemonInteraction.UsesRandomRoll = snapshot.UsesRandomRoll;
        if (snapshot.Rerolled)
        {
            state.DemonInteraction.LastRandomRollWorldTime = currentWorldTime;
        }
        state.DemonInteraction.LastResolvedWorldTime = currentWorldTime;
        state.NextRelationshipCheckWorldTime = snapshot.NextCheckWorldTime;

        string message = snapshot.Rerolled
            ? $"EW-061 随机关系已重掷：{snapshot.Label}。{snapshot.Description}"
            : snapshot.IsActive
            ? $"EW-058 多魔王模式已更新：{snapshot.Label}。{snapshot.Description}"
            : $"EW-058 多魔王模式未激活：{snapshot.Description}";
        _eventLog.Append("reincarnation", "demon_interaction_state", message);
        EraLog.Info(EraLogCategory.Events, message);
        return true;
    }

    private void TryAutoFavoriteActor(Actor actor, string label)
    {
        EraAutoFavoriteResult favoriteResult = _autoFavorites.TryFavorite(actor);
        if (!favoriteResult.IsFailure || favoriteResult.AlreadyFavorite)
        {
            return;
        }

        EraLog.Warning(EraLogCategory.Data, $"EW-057 自动收藏失败：{label} -> {favoriteResult.Reason}");
    }

    private bool HasLegionManifestForDemon(string demonId)
    {
        return GetLegionManifestByDemonId(demonId) != null;
    }

    private EraLegionManifest? GetLegionManifestByDemonId(string demonId)
    {
        return _contentCatalog.Legions.FirstOrDefault(item => string.Equals(item.DemonInternalId, demonId, StringComparison.Ordinal));
    }

    private List<EraDemonManifest> SelectCurrentCycleDemons()
    {
        IReadOnlyList<EraDemonKind> enabledKinds = _parameterRegistry.Current.Demons.EnabledDemons;
        List<EraDemonManifest> candidates = _contentCatalog.Demons
            .Where(item => enabledKinds.Contains(item.Kind))
            .ToList();
        if (candidates.Count == 0)
        {
            return new List<EraDemonManifest>();
        }

        int targetCount = Math.Max(1, Math.Min(_parameterRegistry.Current.Demons.AwakeningCount, candidates.Count));
        if (_parameterRegistry.Current.Demons.AwakeningMode == EraDemonAwakeningMode.Specified)
        {
            return candidates.Take(targetCount).ToList();
        }

        List<EraDemonManifest> selected = new List<EraDemonManifest>(targetCount);
        List<EraDemonManifest> remaining = new List<EraDemonManifest>(candidates);
        for (int index = 0; index < targetCount; index++)
        {
            int pickedIndex = _stableRandom.NextInt("omen:demon_pool", $"pick:{index}", 0, remaining.Count);
            selected.Add(remaining[pickedIndex]);
            remaining.RemoveAt(pickedIndex);
        }

        return selected;
    }

    private EraFortressBindingState? TryCreateStrongholdBinding(EraStrongholdManifest stronghold)
    {
        for (int attempt = 0; attempt < StrongholdPlacementAttempts; attempt++)
        {
            WorldTile? tile = FindRandomStrongholdTile(stronghold.DemonInternalId, attempt);
            if (tile == null)
            {
                continue;
            }

            if (WorldboxReflectionAdapter.TryAddBuilding(stronghold.BuildingId, tile, out Building? building, checkForBuild: true))
            {
                return CreateFortressBinding(stronghold.DemonInternalId, building);
            }

            if (!stronghold.Placement.RetryNearbyWalkableTile)
            {
                continue;
            }

            WorldTile? fallbackTile = FindNearbyBuildableTile(tile, NearbyFallbackRadius);
            if (fallbackTile != null &&
                WorldboxReflectionAdapter.TryAddBuilding(stronghold.BuildingId, fallbackTile, out building, checkForBuild: true))
            {
                return CreateFortressBinding(stronghold.DemonInternalId, building);
            }
        }

        EraLog.Warning(EraLogCategory.Data, $"据点放置失败，已跳过：{stronghold.BuildingId}");
        return null;
    }

    private static EraFortressBindingState CreateFortressBinding(string demonId, Building? building)
    {
        WorldTile? tile = building?.current_tile;
        return new EraFortressBindingState
        {
            DemonId = demonId,
            BuildingId = building?.getID() ?? 0L,
            TileX = tile?.x ?? 0,
            TileY = tile?.y ?? 0,
        };
    }

    private WorldTile? FindRandomStrongholdTile(string demonId, int attempt)
    {
        if (World.world == null)
        {
            return null;
        }

        int x = _stableRandom.NextInt("omen:stronghold_x", $"{demonId}:{attempt}", 0, MapBox.width);
        int y = _stableRandom.NextInt("omen:stronghold_y", $"{demonId}:{attempt}", 0, MapBox.height);
        WorldTile? tile = World.world.GetTile(x, y);
        return IsCandidateGroundTile(tile) ? tile : null;
    }

    private static WorldTile? FindNearbyBuildableTile(WorldTile origin, int radius)
    {
        if (World.world == null)
        {
            return null;
        }

        for (int currentRadius = 1; currentRadius <= radius; currentRadius++)
        {
            for (int offsetX = -currentRadius; offsetX <= currentRadius; offsetX++)
            {
                for (int offsetY = -currentRadius; offsetY <= currentRadius; offsetY++)
                {
                    WorldTile? tile = World.world.GetTile(origin.x + offsetX, origin.y + offsetY);
                    if (IsCandidateGroundTile(tile))
                    {
                        return tile;
                    }
                }
            }
        }

        return null;
    }

    private static bool IsCandidateGroundTile(WorldTile? tile)
    {
        return tile != null &&
               tile.Type != null &&
               tile.Type.ground &&
               tile.Type.can_build_on &&
               !tile.Type.ocean;
    }

    private static float DecaySeal(float currentValue, float decayPercentPerYear, float elapsedWorldTime)
    {
        if (currentValue <= 0f || elapsedWorldTime <= 0f)
        {
            return Math.Max(0f, currentValue);
        }

        float delta = EraWorldTime.GetDeltaByPercentPerYear(decayPercentPerYear, elapsedWorldTime);
        return Math.Max(0f, currentValue - delta);
    }

    private static bool NearlyEqual(float left, float right)
    {
        return Math.Abs(left - right) <= 0.001f;
    }

    private void EnterReconstruction(float currentWorldTime)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        if (state.Stage == EraStage.Reconstruction)
        {
            return;
        }

        state.Stage = EraStage.Reconstruction;
        state.LastVictoryWorldTime = currentWorldTime;
        state.ReconstructionStartedWorldTime = currentWorldTime;
        state.BattleResultRecorded = false;
        state.AdvancementApplied = false;
        state.ReconstructionResetCompleted = false;
        state.HistoryRecorded = false;

        string demonNames = string.Join("、", state.CurrentDemonIds.Select(GetDemonDisplayName));
        _eventLog.Append(
            "reincarnation",
            "stage_reconstruction",
            $"EW-047 最后一名存活魔王已死亡，进入战后重建：{demonNames}。时间={EraWorldTime.GetYearDate(currentWorldTime)}。"
        );
        EraLog.Info(EraLogCategory.Events, "EW-047 已进入战后重建阶段。");
    }

    private void RecordBattleResult(float currentWorldTime)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        string demonNames = string.Join("、", state.CurrentDemonIds.Select(GetDemonDisplayName));
        state.LastCycleSummary = $"第 {state.CompletedCycles + 1} 轮击败魔王：{demonNames}";
        state.BattleResultRecorded = true;
        _eventLog.Append(
            "reincarnation",
            "reconstruction_battle_result",
            $"EW-048 战果结算完成：本轮击败魔王={demonNames}；胜利时间={EraWorldTime.GetYearDate(currentWorldTime)}。"
        );
        EraLog.Info(EraLogCategory.Events, $"EW-048 战果结算完成：{demonNames}。");
    }

    private void ApplyCycleAdvancement(float currentWorldTime)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        EraWorldTierAdvanceResult advancementResult = _advancementRuntime.ApplyCycleAdvancement(currentWorldTime);
        string survivorBonusReport = EraProgressionRuntimeBridge.Current?.ApplyCycleSurvivorBonuses(currentWorldTime)
            ?? "EW-100 幸存强化跳过：成长运行时未绑定。";
        state.AdvancementApplied = true;
        state.LastCycleSummary = $"{state.LastCycleSummary}；{advancementResult.CreateSummary()}；{survivorBonusReport}";
        string growthReport = _growthRanges.PrepareNextCycleRanges();

        _eventLog.Append(
            "reincarnation",
            "reconstruction_advancement",
            $"EW-048/EW-088~092/EW-100 轮回进阶完成：{advancementResult.CreateSummary()} {survivorBonusReport} {growthReport}"
        );
        EraLog.Info(EraLogCategory.Events, $"EW-048/EW-088~092/EW-100 轮回进阶完成：{advancementResult.CreateSummary()} {survivorBonusReport}");
        EraLog.Info(EraLogCategory.Events, growthReport);
    }

    private void ResetCurrentCycleEntities(float currentWorldTime)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        DestroyTrackedCycleActors();

        foreach (EraFortressBindingState fortress in state.FortressBindings)
        {
            _spawnAnchors.TryDestroyBoundFortress(fortress);
        }

        _eventLog.Append(
            "reincarnation",
            "reconstruction_reset",
            "EW-048 运行态重置完成：已清理当轮魔王、将领、军团与据点。"
        );
        EraLog.Info(EraLogCategory.Events, "EW-048 运行态重置完成。");
        state.ReconstructionResetCompleted = true;
    }

    private void RecordCycleHistory(float currentWorldTime)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        state.CycleHistory.Add(
            new EraCycleHistoryRecord
            {
                CycleNumber = state.CompletedCycles + 1,
                Summary = state.LastCycleSummary,
                RecordedWorldTime = currentWorldTime,
            }
        );
        state.HistoryRecorded = true;

        _eventLog.Append(
            "reincarnation",
            "reconstruction_history",
            $"EW-048 历史写入完成：{state.LastCycleSummary}。"
        );
        EraLog.Info(EraLogCategory.Events, $"EW-048 历史写入完成：{state.LastCycleSummary}。");
    }

    private void CompleteReconstruction(float currentWorldTime)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        EraReincarnationParameters reincarnation = _parameterRegistry.Current.Reincarnation;
        EraLegionParameters legions = _parameterRegistry.Current.Legions;
        EraDemonParameters demons = _parameterRegistry.Current.Demons;

        state.CompletedCycles++;
        state.Stage = EraStage.PreDevelopment;
        state.OmenInitialized = false;
        state.GeneralsSpawned = false;
        state.DemonsSpawned = false;
        state.LegionWaveIndex = 0;
        state.GeneralSealPercent = reincarnation.GeneralSealInitialPercent;
        state.DemonSealPercent = reincarnation.DemonSealInitialPercent;
        state.LastSealTickWorldTime = currentWorldTime;
        state.NextPreDevelopmentCheckWorldTime = currentWorldTime + reincarnation.PreDevelopmentCheckInterval.WorldTime;
        state.NextLegionWaveWorldTime = currentWorldTime + legions.SpawnInterval.WorldTime;
        state.NextRelationshipCheckWorldTime = currentWorldTime + demons.RelationshipCheckInterval.WorldTime;
        state.CurrentDemonIds.Clear();
        state.FortressBindings.Clear();
        state.SpawnedGenerals.Clear();
        state.SpawnedDemons.Clear();
        state.SpawnedLegions.Clear();
        ResetDemonInteractionState(state);
        state.ReconstructionStartedWorldTime = 0f;
        state.BattleResultRecorded = false;
        state.AdvancementApplied = false;
        state.ReconstructionResetCompleted = false;
        state.HistoryRecorded = false;
        state.LastCycleSummary = string.Empty;
        _growthRanges.EnsureCycleFrozen();

        _eventLog.Append(
            "reincarnation",
            "reconstruction_complete",
            $"EW-048 战后重建完成，已开启下一轮预发展。当前轮回数={state.CompletedCycles}。"
        );
        EraLog.Info(EraLogCategory.Events, $"EW-048 战后重建完成，当前轮回数={state.CompletedCycles}。");
    }

    private (int aliveCount, bool stateChanged) CountAliveDemons()
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        int aliveCount = 0;
        bool stateChanged = false;

        foreach (EraDemonSpawnState spawnState in state.SpawnedDemons)
        {
            Actor? actor = ResolveActorByState(spawnState.DemonId, spawnState.ActorId, spawnState.TileX, spawnState.TileY);
            if (actor == null || !actor.isAlive())
            {
                continue;
            }

            long resolvedActorId = actor.getID();
            if (spawnState.ActorId != resolvedActorId)
            {
                spawnState.ActorId = resolvedActorId;
                WorldTile? actorTile = actor.current_tile;
                if (actorTile != null)
                {
                    spawnState.TileX = actorTile.x;
                    spawnState.TileY = actorTile.y;
                }

                stateChanged = true;
            }

            aliveCount++;
        }

        return (aliveCount, stateChanged);
    }

    private static Actor? ResolveActorByState(string assetId, long actorId, int tileX, int tileY)
    {
        if (World.world == null)
        {
            return null;
        }

        Actor? closest = null;
        int bestDistance = int.MaxValue;
        foreach (Actor candidate in World.world.units.getSimpleList())
        {
            if (!IsMatchingActor(candidate, assetId) || candidate.current_tile == null)
            {
                continue;
            }

            if (actorId > 0L && candidate.getID() == actorId)
            {
                return candidate;
            }

            int distance = GetDistanceSquared(candidate.current_tile.x, candidate.current_tile.y, tileX, tileY);
            if (distance >= bestDistance)
            {
                continue;
            }

            bestDistance = distance;
            closest = candidate;
        }

        return closest;
    }

    private static bool IsMatchingActor(Actor? actor, string assetId)
    {
        return actor != null &&
               actor.asset != null &&
               actor.asset.id == assetId;
    }

    private static int GetDistanceSquared(int leftX, int leftY, int rightX, int rightY)
    {
        int deltaX = leftX - rightX;
        int deltaY = leftY - rightY;
        return deltaX * deltaX + deltaY * deltaY;
    }

    private string GetDemonDisplayName(string demonId)
    {
        return _contentCatalog.DemonsById.TryGetValue(demonId, out EraDemonManifest? demon)
            ? demon.DisplayName
            : demonId;
    }

    private bool EnsureDebugOmenReady(out float currentWorldTime)
    {
        currentWorldTime = 0f;
        if (!TryGetCurrentWorldTime(out currentWorldTime))
        {
            return false;
        }

        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        if (state.Stage == EraStage.PreDevelopment)
        {
            BeginOmen(currentWorldTime);
        }

        EnsureOmenInitialized(currentWorldTime);
        if (!state.OmenInitialized)
        {
            EraLog.Warning(EraLogCategory.Debug, "调试跳阶段失败：当前还没有完成据点初始化。");
            return false;
        }

        return true;
    }

    private bool TryGetCurrentWorldTime(out float currentWorldTime)
    {
        currentWorldTime = 0f;
        if (!WorldboxReflectionAdapter.TryReadMapStats(out MapStats? mapStats) || mapStats == null)
        {
            _runtimeSave.TryAttachCurrentWorld();
            RebindRuntimeStateDependencies();
            currentWorldTime = _runtimeSave.CurrentState.LastObservedWorldTime;
            return World.world != null;
        }

        currentWorldTime = (float)mapStats.world_time;
        _runtimeSave.CurrentState.LastObservedWorldTime = currentWorldTime;
        return true;
    }

    private void DestroyTrackedCycleActors()
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;

        foreach (EraGeneralSpawnState spawnState in state.SpawnedGenerals)
        {
            Actor? actor = ResolveActorByState(spawnState.GeneralId, spawnState.ActorId, spawnState.TileX, spawnState.TileY);
            if (actor != null && actor.isAlive())
            {
                actor.dieSimpleNone();
            }
        }

        foreach (EraDemonSpawnState spawnState in state.SpawnedDemons)
        {
            Actor? actor = ResolveActorByState(spawnState.DemonId, spawnState.ActorId, spawnState.TileX, spawnState.TileY);
            if (actor != null && actor.isAlive())
            {
                actor.dieSimpleNone();
            }
        }

        foreach (EraLegionSpawnState spawnState in state.SpawnedLegions)
        {
            Actor? actor = ResolveActorByState(spawnState.LegionId, spawnState.ActorId, spawnState.TileX, spawnState.TileY);
            if (actor != null && actor.isAlive())
            {
                actor.dieSimpleNone();
            }
        }
    }

    private void ResetTrackedSpawnState()
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        DestroyTrackedCycleActors();
        state.GeneralsSpawned = false;
        state.DemonsSpawned = false;
        state.LegionWaveIndex = 0;
        state.SpawnedGenerals.Clear();
        state.SpawnedDemons.Clear();
        state.SpawnedLegions.Clear();
        ResetDemonInteractionState(state);
    }

    private void RebindRuntimeStateDependencies()
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        _stableRandom.Rebind(state);
        _eventLog.Rebind(state);
        _growthRanges.Rebind(state);
    }

    private bool ApplyDemonInteractionSnapshot(EraDemonInteractionSnapshot snapshot)
    {
        ResetAllDemonKingdomRelations();
        if (!snapshot.IsActive)
        {
            return false;
        }

        IReadOnlyList<string> demonIds = _runtimeSave.CurrentState.CurrentDemonIds;
        if (snapshot.Mode == EraDemonInteractionMode.Alliance)
        {
            ApplyAllianceRelations(demonIds);
            return ClearFriendlyFireBetweenDemonFactions(demonIds);
        }

        return false;
    }

    private void ResetAllDemonKingdomRelations()
    {
        List<KingdomAsset?> assets = new List<KingdomAsset?>(_contentCatalog.Demons.Count);
        foreach (EraDemonManifest demon in _contentCatalog.Demons)
        {
            KingdomAsset? asset = AssetManager.kingdoms.get(EraDemonFactionIds.GetKingdomId(demon.InternalId));
            if (asset == null)
            {
                continue;
            }

            asset.list_tags.Clear();
            asset.friendly_tags.Clear();
            asset.enemy_tags.Clear();
            asset.addTag(asset.id);
            asset.addTag(EraDemonFactionIds.SharedTag);
            assets.Add(asset);
        }

        WorldboxReflectionAdapter.ClearKingdomEnemyCaches(assets);
    }

    private static void ApplyAllianceRelations(IReadOnlyList<string> demonIds)
    {
        List<KingdomAsset?> assets = new List<KingdomAsset?>(demonIds.Count);
        foreach (string demonId in demonIds)
        {
            KingdomAsset? asset = AssetManager.kingdoms.get(EraDemonFactionIds.GetKingdomId(demonId));
            if (asset != null)
            {
                assets.Add(asset);
            }
        }

        foreach (KingdomAsset? source in assets)
        {
            if (source == null)
            {
                continue;
            }

            foreach (KingdomAsset? target in assets)
            {
                if (target == null || ReferenceEquals(source, target))
                {
                    continue;
                }

                source.addFriendlyTag(target.id);
            }
        }

        WorldboxReflectionAdapter.ClearKingdomEnemyCaches(assets);
    }

    private static bool ClearFriendlyFireBetweenDemonFactions(IReadOnlyList<string> demonIds)
    {
        if (World.world == null)
        {
            return false;
        }

        HashSet<Kingdom> kingdoms = new HashSet<Kingdom>();
        foreach (string demonId in demonIds)
        {
            Kingdom? kingdom = World.world.kingdoms_wild?.get(EraDemonFactionIds.GetKingdomId(demonId));
            if (kingdom != null)
            {
                kingdoms.Add(kingdom);
            }
        }

        if (kingdoms.Count < 2)
        {
            return false;
        }

        HashSet<long> alliedActorIds = new HashSet<long>();
        foreach (Actor actor in World.world.units.getSimpleList())
        {
            if (actor.kingdom != null && kingdoms.Contains(actor.kingdom))
            {
                alliedActorIds.Add(actor.getID());
            }
        }

        bool changed = false;
        foreach (Actor actor in World.world.units.getSimpleList())
        {
            if (actor.kingdom == null || !kingdoms.Contains(actor.kingdom))
            {
                continue;
            }

            if (WorldboxReflectionAdapter.TryGetAttackTarget(actor, out BaseSimObject? attackTarget) &&
                attackTarget != null &&
                attackTarget.kingdom != null &&
                kingdoms.Contains(attackTarget.kingdom))
            {
                actor.clearAttackTarget();
                actor.cancelAllBeh();
                changed = true;
            }

            if (WorldboxReflectionAdapter.TryClearActorAggro(actor, alliedActorIds))
            {
                changed = true;
            }
        }

        return changed;
    }

    private bool MaintainCivilWarWinnerBonus(float currentWorldTime)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        bool stateChanged = MaintainExistingCivilWarWinnerBonus(currentWorldTime);
        if (!state.DemonInteraction.Active || state.DemonInteraction.Mode != EraDemonInteractionMode.CivilWar)
        {
            return stateChanged;
        }

        HashSet<string> eligibleDemons = state.CurrentDemonIds
            .Take(Math.Max(1, _parameterRegistry.Current.Demons.CivilWarMaxDemons))
            .ToHashSet(StringComparer.Ordinal);
        List<(EraDemonSpawnState SpawnState, Actor Actor)> aliveEligibleDemons = new List<(EraDemonSpawnState SpawnState, Actor Actor)>();
        foreach (EraDemonSpawnState spawnState in state.SpawnedDemons)
        {
            if (!eligibleDemons.Contains(spawnState.DemonId))
            {
                continue;
            }

            Actor? actor = ResolveActorByState(spawnState.DemonId, spawnState.ActorId, spawnState.TileX, spawnState.TileY);
            if (actor != null && actor.isAlive())
            {
                aliveEligibleDemons.Add((spawnState, actor));
            }
        }

        if (aliveEligibleDemons.Count != 1)
        {
            return stateChanged;
        }

        EraCivilWarWinnerState winnerState = state.DemonInteraction.CivilWarWinner;
        (EraDemonSpawnState SpawnState, Actor Actor) winner = aliveEligibleDemons[0];
        if (string.Equals(winnerState.DemonId, winner.SpawnState.DemonId, StringComparison.Ordinal) &&
            winnerState.BonusEndWorldTime > currentWorldTime)
        {
            return stateChanged;
        }

        float bonusDuration = _parameterRegistry.Current.Demons.CivilWarWinnerBonusDuration.WorldTime;
        WorldboxReflectionAdapter.TryAddStatusEffect(winner.Actor, EraStatusIds.CivilWarWinner, bonusDuration);
        state.DemonInteraction.CivilWarWinner = new EraCivilWarWinnerState
        {
            DemonId = winner.SpawnState.DemonId,
            ActorId = winner.Actor.getID(),
            Title = "内战胜者",
            BonusPercent = _parameterRegistry.Current.Demons.CivilWarWinnerBonusPercent,
            BonusEndWorldTime = currentWorldTime + bonusDuration,
        };

        string demonName = GetDemonDisplayName(winner.SpawnState.DemonId);
        string message = $"EW-060 内战胜者已确定：{demonName} 获得称号“内战胜者”，加成持续到 {EraWorldTime.GetYearDate(currentWorldTime + bonusDuration)}。";
        _eventLog.Append("reincarnation", "civil_war_winner", message);
        EraLog.Info(EraLogCategory.Events, message);
        return true;
    }

    private bool MaintainExistingCivilWarWinnerBonus(float currentWorldTime)
    {
        EraCivilWarWinnerState winnerState = _runtimeSave.CurrentState.DemonInteraction.CivilWarWinner;
        if (string.IsNullOrWhiteSpace(winnerState.DemonId))
        {
            return false;
        }

        EraDemonSpawnState? spawnState = _runtimeSave.CurrentState.SpawnedDemons
            .FirstOrDefault(item => string.Equals(item.DemonId, winnerState.DemonId, StringComparison.Ordinal));
        Actor? actor = spawnState == null
            ? null
            : ResolveActorByState(winnerState.DemonId, winnerState.ActorId, spawnState.TileX, spawnState.TileY);
        if (currentWorldTime >= winnerState.BonusEndWorldTime || actor == null || !actor.isAlive())
        {
            if (actor != null && actor.isAlive())
            {
                actor.finishStatusEffect(EraStatusIds.CivilWarWinner);
            }

            _runtimeSave.CurrentState.DemonInteraction.CivilWarWinner = new EraCivilWarWinnerState();
            return true;
        }

        bool changed = false;
        if (winnerState.ActorId != actor.getID())
        {
            winnerState.ActorId = actor.getID();
            changed = true;
        }

        if (!actor.getStatusesDict().ContainsKey(EraStatusIds.CivilWarWinner))
        {
            WorldboxReflectionAdapter.TryAddStatusEffect(
                actor,
                EraStatusIds.CivilWarWinner,
                winnerState.BonusEndWorldTime - currentWorldTime
            );
            changed = true;
        }

        _runtimeSave.CurrentState.DemonInteraction.CivilWarWinner = winnerState;
        return changed;
    }

    private static string GetReconstructionProgressLabel(EraWorldRuntimeState state)
    {
        if (state.Stage != EraStage.Reconstruction)
        {
            return "未开始";
        }

        if (!state.BattleResultRecorded)
        {
            return "战果";
        }

        if (!state.AdvancementApplied)
        {
            return "进阶";
        }

        if (!state.ReconstructionResetCompleted)
        {
            return "重置";
        }

        if (!state.HistoryRecorded)
        {
            return "历史";
        }

        return "下一轮";
    }

    private static string GetInteractionStatusLabel(EraWorldRuntimeState state)
    {
        if (!state.DemonInteraction.Active)
        {
            return "未激活";
        }

        return state.DemonInteraction.Mode switch
        {
            EraDemonInteractionMode.Alliance => "联盟",
            EraDemonInteractionMode.CivilWar => "内战",
            _ => "随机",
        };
    }

    private static void ResetDemonInteractionState(EraWorldRuntimeState state)
    {
        state.DemonInteraction.Active = false;
        state.DemonInteraction.Mode = EraDemonInteractionMode.Alliance;
        state.DemonInteraction.Description = string.Empty;
        state.DemonInteraction.LastResolvedWorldTime = 0f;
        state.DemonInteraction.UsesRandomRoll = false;
        state.DemonInteraction.LastRandomRollWorldTime = 0f;
        state.DemonInteraction.CivilWarWinner = new EraCivilWarWinnerState();
    }
}
