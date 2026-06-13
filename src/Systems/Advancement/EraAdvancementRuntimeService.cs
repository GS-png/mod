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
using EraWheel.Save.Models;
using EraWheel.Save.Services;
using EraWheel.Systems.Progression;

namespace EraWheel.Systems.Advancement;

public enum EraAdvancementLoadoutRole
{
    Demon = 0,
    General = 1,
    Legion = 2,
}

public sealed class EraWorldTierAdvanceResult
{
    public int PreviousTier { get; }
    public int CurrentTier { get; }
    public int SurvivorKingdoms { get; }
    public int RefreshedKingdoms { get; }
    public int NewlyUnlockedEquipment { get; }
    public int NewlyUnlockedTraits { get; }

    public EraWorldTierAdvanceResult(
        int previousTier,
        int currentTier,
        int survivorKingdoms,
        int refreshedKingdoms,
        int newlyUnlockedEquipment,
        int newlyUnlockedTraits
    )
    {
        PreviousTier = previousTier;
        CurrentTier = currentTier;
        SurvivorKingdoms = survivorKingdoms;
        RefreshedKingdoms = refreshedKingdoms;
        NewlyUnlockedEquipment = newlyUnlockedEquipment;
        NewlyUnlockedTraits = newlyUnlockedTraits;
    }

    public string CreateSummary()
    {
        return
            $"世界档位 {PreviousTier} -> {CurrentTier}；幸存王国={SurvivorKingdoms}；" +
            $"已刷新王国档位={RefreshedKingdoms}；新增装备解锁={NewlyUnlockedEquipment}；新增特质解锁={NewlyUnlockedTraits}。";
    }
}

public sealed class EraAdvancementRuntimeService
{
    private static readonly EquipmentType[] EquipmentSlots =
    {
        EquipmentType.Weapon,
        EquipmentType.Helmet,
        EquipmentType.Armor,
        EquipmentType.Boots,
        EquipmentType.Amulet,
        EquipmentType.Ring,
    };

    private readonly EraParameterRegistry _parameterRegistry;
    private readonly EraRuntimeSaveService _runtimeSave;
    private readonly EraStableRandomService _stableRandom;
    private readonly EraEventLogService _eventLog;
    private readonly HashSet<string> _publicTraitIds;
    private readonly Dictionary<string, EraHeritageEquipmentManifest> _heritageById;
    private readonly Dictionary<string, EraHeritageTraitManifest> _heritageTraitsById;
    private readonly Dictionary<EquipmentType, List<EquipmentAsset>> _heritageAssetsBySlot = new();

    public EraAdvancementRuntimeService(
        EraParameterRegistry parameterRegistry,
        EraRuntimeSaveService runtimeSave,
        EraStableRandomService stableRandom,
        EraEventLogService eventLog,
        EraContentCatalog contentCatalog
    )
    {
        _parameterRegistry = parameterRegistry;
        _runtimeSave = runtimeSave;
        _stableRandom = stableRandom;
        _eventLog = eventLog;
        _publicTraitIds = contentCatalog.PublicTraitsById.Keys.ToHashSet(StringComparer.Ordinal);
        _heritageById = contentCatalog.HeritageEquipmentById.ToDictionary(item => item.Key, item => item.Value);
        _heritageTraitsById = contentCatalog.HeritageTraitsById.ToDictionary(item => item.Key, item => item.Value);
        EraAdvancementPatchInstaller.EnsurePatched();
        BuildEquipmentIndex();
    }

    public void Bind()
    {
        EraAdvancementRuntimeBridge.Bind(this);
        EraLog.Info(EraLogCategory.Events, $"轮回进阶运行时已初始化：{CreateStatusReport()}");
    }

    public void Rebind()
    {
        BuildEquipmentIndex();
    }

    public void Update(float currentWorldTime)
    {
        RefreshKingdomControl(currentWorldTime, force: false);
        RefreshDemonEquipmentIfDue(currentWorldTime);
    }

    public string CreateStatusReport()
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        EraAdvancementParameters parameters = _parameterRegistry.Current.Advancement;
        return
            $"世界档位={state.WorldTier}；推进模式={parameters.ProgressionMode}；手动档位={parameters.ManualWorldTier}；" +
            $"王国档位模式={parameters.KingdomTierMode}；缓存王国={state.KingdomTiers.Count}；幸存王国={state.SurvivorKingdomIds.Count}；" +
            $"已解锁装备={state.UnlockedHeritageEquipment.Count}；已解锁特质={state.UnlockedHeritageTraits.Count}；" +
            $"{CreateAvailabilityStatusReport()}；" +
            $"下次掌控刷新={state.NextKingdomControlRefreshWorldTime:F1}；下次魔王换装={state.NextDemonEquipmentRefreshWorldTime:F1}。";
    }

    public EraWorldTierAdvanceResult ApplyCycleAdvancement(float currentWorldTime)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        int previousTier = state.WorldTier;
        state.WorldTier = ResolveNextWorldTier(previousTier);
        CaptureSurvivingKingdoms();
        int refreshedKingdoms = RefreshKingdomControl(currentWorldTime, force: true);
        (int unlockedEquipment, int unlockedTraits) = RecordCycleUnlocks(currentWorldTime);
        state.NextDemonEquipmentRefreshWorldTime = currentWorldTime + _parameterRegistry.Current.Advancement.DemonEquipmentRefreshInterval.WorldTime;
        return new EraWorldTierAdvanceResult(
            previousTier,
            state.WorldTier,
            state.SurvivorKingdomIds.Count,
            refreshedKingdoms,
            unlockedEquipment,
            unlockedTraits
        );
    }

    public bool TryEquipSpawnLoadout(Actor actor, EraAdvancementLoadoutRole role)
    {
        if (actor == null || actor.isRekt())
        {
            return false;
        }

        float currentWorldTime = World.world != null
            ? (float)World.world.getCurWorldTime()
            : _runtimeSave.CurrentState.LastObservedWorldTime;
        return RefreshActorLoadout(actor, role, currentWorldTime, "spawn");
    }

    public bool IsHeritageEquipment(EquipmentAsset? asset)
    {
        return asset != null && _heritageById.ContainsKey(asset.id);
    }

    public bool CanKingdomCraftEquipment(Kingdom? kingdom, EquipmentAsset? asset)
    {
        if (asset == null || !IsHeritageEquipment(asset))
        {
            return true;
        }

        if (!IsWorldHeritageEquipmentUnlocked(asset.id))
        {
            return false;
        }

        if (kingdom == null)
        {
            return true;
        }

        int effectiveTier = IsDemonFactionKingdom(kingdom)
            ? _runtimeSave.CurrentState.WorldTier
            : GetEffectiveKingdomTier(kingdom);
        return effectiveTier >= _heritageById[asset.id].UnlockTier;
    }

    public int GetEffectiveKingdomTier(Kingdom? kingdom)
    {
        EraKingdomTierState? state = GetKingdomTierState(kingdom);
        return state == null ? _runtimeSave.CurrentState.WorldTier : ClampTier(state.EffectiveTier);
    }

    public EraKingdomTierState? GetKingdomTierState(Kingdom? kingdom)
    {
        if (kingdom == null)
        {
            return null;
        }

        EraKingdomTierState? cached = _runtimeSave.CurrentState.KingdomTiers
            .FirstOrDefault(item => item.KingdomId == kingdom.id);
        return cached ?? BuildKingdomTierState(kingdom, _runtimeSave.CurrentState.LastObservedWorldTime);
    }

    public int GetCurrentWorldTier()
    {
        return ClampTier(_runtimeSave.CurrentState.WorldTier);
    }

    public bool IsWorldHeritageEquipmentUnlocked(string equipmentId)
    {
        return _runtimeSave.CurrentState.UnlockedHeritageEquipment.Any(item => item.DefinitionId == equipmentId);
    }

    public bool IsWorldHeritageTraitUnlocked(string traitId)
    {
        return _runtimeSave.CurrentState.UnlockedHeritageTraits.Any(item => item.DefinitionId == traitId);
    }

    public string CreateAvailabilityStatusReport()
    {
        int unlockedHeritageTraits = _runtimeSave.CurrentState.UnlockedHeritageTraits.Count;
        int unlockedHeritageEquipment = _runtimeSave.CurrentState.UnlockedHeritageEquipment.Count;
        return
            $"原版可用性不改写；已登记内容：公共特质={_publicTraitIds.Count}，" +
            $"轮回特质={_heritageTraitsById.Count}，轮回装备={_heritageById.Count}；" +
            $"玩法已解锁：轮回特质={unlockedHeritageTraits}/{_heritageTraitsById.Count}，" +
            $"轮回装备={unlockedHeritageEquipment}/{_heritageById.Count}";
    }

    public bool TryGetHeritageAvailability(string assetId, out bool available)
    {
        if (_heritageById.ContainsKey(assetId))
        {
            available = IsWorldHeritageEquipmentUnlocked(assetId);
            return true;
        }

        if (_heritageTraitsById.ContainsKey(assetId))
        {
            available = IsWorldHeritageTraitUnlocked(assetId);
            return true;
        }

        available = false;
        return false;
    }

    public int GetEffectiveActorTier(Actor? actor)
    {
        if (actor == null || actor.kingdom == null)
        {
            return GetCurrentWorldTier();
        }

        return IsDemonFactionKingdom(actor.kingdom)
            ? GetCurrentWorldTier()
            : GetEffectiveKingdomTier(actor.kingdom);
    }

    public EquipmentAsset? ResolveCraftCandidate(
        Actor actor,
        List<EquipmentAsset>? source,
        City city,
        int currentValue,
        bool shuffle,
        EquipmentAsset? original
    )
    {
        if (actor == null || city == null)
        {
            return original;
        }

        if (original != null && !ShouldSkipCraftAsset(actor, original))
        {
            return original;
        }

        if (source == null || source.Count == 0)
        {
            return null;
        }

        for (int index = source.Count - 1; index >= 0; index--)
        {
            EquipmentAsset? asset = source[index];
            if (asset == null ||
                asset.equipment_value <= currentValue ||
                !HasEnoughResourcesToCraft(actor, asset, city) ||
                ShouldSkipCraftAsset(actor, asset))
            {
                continue;
            }

            return asset;
        }

        return null;
    }

    private int RefreshKingdomControl(float currentWorldTime, bool force)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        EraControlProfile control = _parameterRegistry.Current.Advancement.Control;
        if (World.world == null || (!force && currentWorldTime < state.NextKingdomControlRefreshWorldTime))
        {
            return state.KingdomTiers.Count;
        }

        List<EraKingdomTierState> refreshed = new();
        foreach (Kingdom kingdom in World.world.kingdoms)
        {
            if (kingdom == null || kingdom.isRekt() || IsDemonFactionKingdom(kingdom))
            {
                continue;
            }

            refreshed.Add(BuildKingdomTierState(kingdom, currentWorldTime));
        }

        state.KingdomTiers = refreshed;
        state.NextKingdomControlRefreshWorldTime = currentWorldTime + control.RefreshInterval.WorldTime;

        _eventLog.Append(
            "advancement",
            "kingdom_control_refresh",
            $"EW-089 王国掌控度已刷新：王国={refreshed.Count}；世界档位={state.WorldTier}；模式={_parameterRegistry.Current.Advancement.KingdomTierMode}。"
        );
        return refreshed.Count;
    }

    private bool RefreshDemonEquipmentIfDue(float currentWorldTime)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        if (World.world == null || currentWorldTime < state.NextDemonEquipmentRefreshWorldTime)
        {
            return false;
        }

        int changedActors = 0;
        foreach (EraDemonSpawnState spawn in state.SpawnedDemons)
        {
            if (ResolveTrackedActor(spawn.ActorId, spawn.DemonId) is { } actor &&
                RefreshActorLoadout(actor, EraAdvancementLoadoutRole.Demon, currentWorldTime, "refresh"))
            {
                changedActors++;
            }
        }

        foreach (EraGeneralSpawnState spawn in state.SpawnedGenerals)
        {
            if (ResolveTrackedActor(spawn.ActorId, spawn.GeneralId) is { } actor &&
                RefreshActorLoadout(actor, EraAdvancementLoadoutRole.General, currentWorldTime, "refresh"))
            {
                changedActors++;
            }
        }

        foreach (EraLegionSpawnState spawn in state.SpawnedLegions)
        {
            if (ResolveTrackedActor(spawn.ActorId, spawn.LegionId) is { } actor &&
                RefreshActorLoadout(actor, EraAdvancementLoadoutRole.Legion, currentWorldTime, "refresh"))
            {
                changedActors++;
            }
        }

        state.NextDemonEquipmentRefreshWorldTime = currentWorldTime + _parameterRegistry.Current.Advancement.DemonEquipmentRefreshInterval.WorldTime;
        _eventLog.Append(
            "advancement",
            "demon_equipment_refresh",
            $"EW-092 魔王装备刷新完成：变更单位={changedActors}；下次刷新时间={EraWorldTime.GetYearDate(state.NextDemonEquipmentRefreshWorldTime)}。"
        );
        return changedActors > 0;
    }

    private bool RefreshActorLoadout(Actor actor, EraAdvancementLoadoutRole role, float currentWorldTime, string scope)
    {
        if (actor.equipment == null)
        {
            return false;
        }

        bool changed = false;
        foreach (EquipmentType slotType in EquipmentSlots)
        {
            if (role == EraAdvancementLoadoutRole.Legion &&
                !ShouldLegionAttemptSlot(actor, slotType, currentWorldTime, scope))
            {
                continue;
            }

            changed |= TryEquipBestHeritageItem(actor, slotType, role, scope);
        }

        return changed;
    }

    private bool TryEquipBestHeritageItem(Actor actor, EquipmentType slotType, EraAdvancementLoadoutRole role, string scope)
    {
        if (!_heritageAssetsBySlot.TryGetValue(slotType, out List<EquipmentAsset>? candidates) || candidates.Count == 0)
        {
            return false;
        }

        ActorEquipmentSlot slot = actor.equipment.getSlot(slotType);
        if (!slot.canChangeSlot())
        {
            return false;
        }

        int worldTier = ClampTier(_runtimeSave.CurrentState.WorldTier);
        EquipmentAsset? candidate = candidates
            .FirstOrDefault(item => _heritageById.TryGetValue(item.id, out EraHeritageEquipmentManifest? manifest) &&
                                    IsWorldHeritageEquipmentUnlocked(item.id) &&
                                    manifest.UnlockTier <= worldTier);
        if (candidate == null)
        {
            return false;
        }

        Item generated = World.world.items.generateItem(candidate, actor.kingdom, actor.getName(), 1, actor);
        EraProgressionRuntimeBridge.Current?.MarkEquipmentPendingGrant(generated, BuildLoadoutGrantSource(role, scope));
        Item? current = slot.getItem();
        if (current == null || generated.getValue() > current.getValue())
        {
            actor.equipment.setItem(generated, actor);
            return true;
        }

        generated.setShouldBeRemoved();
        return false;
    }

    private bool ShouldLegionAttemptSlot(Actor actor, EquipmentType slotType, float currentWorldTime, string scope)
    {
        float roll = _stableRandom.NextFloat(
            "advancement:legion_loadout",
            $"{scope}:{_runtimeSave.CurrentState.CompletedCycles}:{actor.getID()}:{(int)slotType}:{(int)currentWorldTime}",
            0f,
            1f
        );
        return roll <= 0.20f;
    }

    private EraKingdomTierState BuildKingdomTierState(Kingdom kingdom, float currentWorldTime)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        EraControlProfile control = _parameterRegistry.Current.Advancement.Control;

        int books = CountKingdomBooks(kingdom);
        int cities = kingdom.countCities();
        int population = kingdom.getPopulationTotal();
        int military = kingdom.countTotalWarriors();

        float controlScore = control.BaseScore;
        controlScore += BuildMetricScore(cities, control.Cities);
        controlScore += BuildMetricScore(population, control.Population);
        controlScore += BuildMetricScore(military, control.Military);
        controlScore += BuildMetricScore(books, control.Books);
        controlScore = Math.Clamp(controlScore, 0f, 1f);

        int baseTier = Math.Max(control.NewKingdomFloorTier, (int)Math.Floor(state.WorldTier * controlScore));
        bool isSurvivor = state.SurvivorKingdomIds.Contains(kingdom.id);
        int effectiveTier = _parameterRegistry.Current.Advancement.KingdomTierMode switch
        {
            EraKingdomTierMode.AllUseWorldTier => state.WorldTier,
            EraKingdomTierMode.AllUseKingdomTier => baseTier,
            EraKingdomTierMode.SurvivorsUseWorldTierAndNewcomersUseKingdomTier => isSurvivor ? state.WorldTier : baseTier,
            _ => baseTier,
        };

        return new EraKingdomTierState
        {
            KingdomId = kingdom.id,
            KingdomName = string.IsNullOrWhiteSpace(kingdom.name) ? $"#{kingdom.id}" : kingdom.name,
            ControlScore = controlScore,
            Cities = cities,
            Population = population,
            Military = military,
            Books = books,
            BaseTier = ClampTier(baseTier),
            EffectiveTier = ClampTier(effectiveTier),
            IsSurvivorKingdom = isSurvivor,
            LastRefreshWorldTime = currentWorldTime,
        };
    }

    private void CaptureSurvivingKingdoms()
    {
        if (World.world == null)
        {
            _runtimeSave.CurrentState.SurvivorKingdomIds.Clear();
            return;
        }

        _runtimeSave.CurrentState.SurvivorKingdomIds = World.world.kingdoms
            .Where(kingdom => kingdom != null &&
                              !kingdom.isRekt() &&
                              !IsDemonFactionKingdom(kingdom) &&
                              (kingdom.countCities() > 0 || kingdom.getPopulationTotal() > 0))
            .Select(kingdom => kingdom.id)
            .Distinct()
            .ToList();
    }

    private static float BuildMetricScore(int value, EraControlMetric metric)
    {
        if (metric.Threshold <= 0 || metric.Weight <= 0f)
        {
            return 0f;
        }

        float normalized = Math.Min((float)value / metric.Threshold, 1f);
        return normalized * metric.Weight;
    }

    private (int UnlockedEquipment, int UnlockedTraits) RecordCycleUnlocks(float currentWorldTime)
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        int unlockedEquipment = AppendUnlocks(
            state.UnlockedHeritageEquipment,
            _heritageById.Values.Select(
                manifest => new EraHeritageUnlockLedgerEntry
                {
                    Kind = "equipment",
                    DefinitionId = manifest.EquipmentId,
                    UnlockTier = manifest.UnlockTier,
                    GrantedCycle = state.CompletedCycles,
                    GrantedWorldTime = currentWorldTime,
                    SourceWorldTier = state.WorldTier,
                    Source = "cycle_advancement",
                }
            ),
            state.WorldTier
        );
        int unlockedTraits = AppendUnlocks(
            state.UnlockedHeritageTraits,
            _heritageTraitsById.Values.Select(
                manifest => new EraHeritageUnlockLedgerEntry
                {
                    Kind = "trait",
                    DefinitionId = manifest.TraitId,
                    UnlockTier = manifest.UnlockTier,
                    GrantedCycle = state.CompletedCycles,
                    GrantedWorldTime = currentWorldTime,
                    SourceWorldTier = state.WorldTier,
                    Source = "cycle_advancement",
                }
            ),
            state.WorldTier
        );

        if (unlockedEquipment > 0 || unlockedTraits > 0)
        {
            _eventLog.Append(
                "advancement",
                "heritage_unlocks_recorded",
                $"EW-090 轮回解锁账本已更新：装备新增={unlockedEquipment}；特质新增={unlockedTraits}；世界档位=T{state.WorldTier}。"
            );
        }

        return (unlockedEquipment, unlockedTraits);
    }

    private void BuildEquipmentIndex()
    {
        _heritageAssetsBySlot.Clear();
        foreach (EraHeritageEquipmentManifest manifest in _heritageById.Values)
        {
            EquipmentAsset? asset = AssetManager.items.get(manifest.EquipmentId);
            if (asset == null)
            {
                continue;
            }

            if (!_heritageAssetsBySlot.TryGetValue(asset.equipment_type, out List<EquipmentAsset>? list))
            {
                list = new List<EquipmentAsset>();
                _heritageAssetsBySlot[asset.equipment_type] = list;
            }

            if (!list.Contains(asset))
            {
                list.Add(asset);
            }
        }

        foreach (List<EquipmentAsset> list in _heritageAssetsBySlot.Values)
        {
            list.Sort(
                (left, right) =>
                {
                    int byValue = right.equipment_value.CompareTo(left.equipment_value);
                    if (byValue != 0)
                    {
                        return byValue;
                    }

                    return string.Compare(left.id, right.id, StringComparison.Ordinal);
                }
            );
        }
    }

    private static int AppendUnlocks(
        ICollection<EraHeritageUnlockLedgerEntry> target,
        IEnumerable<EraHeritageUnlockLedgerEntry> source,
        int currentTier
    )
    {
        int added = 0;
        foreach (EraHeritageUnlockLedgerEntry entry in source)
        {
            if (entry.UnlockTier > currentTier ||
                target.Any(item => item.Kind == entry.Kind && item.DefinitionId == entry.DefinitionId))
            {
                continue;
            }

            target.Add(entry);
            added++;
        }

        return added;
    }

    private bool ShouldSkipCraftAsset(Actor actor, EquipmentAsset asset)
    {
        return IsHeritageEquipment(asset) && !CanKingdomCraftEquipment(actor.kingdom, asset);
    }

    private static Actor? ResolveTrackedActor(long actorId, string actorAssetId)
    {
        if (World.world == null || actorId <= 0L)
        {
            return null;
        }

        Actor? actor = World.world.units.get(actorId);
        if (actor == null || actor.isRekt() || actor.asset == null)
        {
            return null;
        }

        return string.Equals(actor.asset.id, actorAssetId, StringComparison.Ordinal) ? actor : null;
    }

    private static int CountKingdomBooks(Kingdom kingdom)
    {
        int total = 0;
        foreach (City city in kingdom.getCities())
        {
            if (city == null || city.isRekt())
            {
                continue;
            }

            total += city.countBooks();
        }

        return total;
    }

    private int ResolveNextWorldTier(int previousTier)
    {
        EraAdvancementParameters advancement = _parameterRegistry.Current.Advancement;
        int nextTier = advancement.ProgressionMode == EraWorldTierProgressionMode.ManualControl
            ? advancement.ManualWorldTier
            : previousTier + advancement.TierIncreasePerCycle;
        return ClampTier(nextTier);
    }

    private int ClampTier(int tier)
    {
        return Math.Max(1, Math.Min(_parameterRegistry.Current.Advancement.MaxTier, tier));
    }

    private static bool HasEnoughResourcesToCraft(Actor actor, EquipmentAsset asset, City city)
    {
        if (!actor.hasEnoughMoney(asset.get_total_cost))
        {
            return false;
        }

        if (asset.cost_resource_id_1 != "none" && asset.cost_resource_1 > city.getResourcesAmount(asset.cost_resource_id_1))
        {
            return false;
        }

        if (asset.cost_resource_id_2 != "none" && asset.cost_resource_2 > city.getResourcesAmount(asset.cost_resource_id_2))
        {
            return false;
        }

        return true;
    }

    private static string BuildLoadoutGrantSource(EraAdvancementLoadoutRole role, string scope)
    {
        return role switch
        {
            EraAdvancementLoadoutRole.Demon => scope == "refresh" ? "demon_refresh" : "demon_spawn",
            EraAdvancementLoadoutRole.General => scope == "refresh" ? "general_refresh" : "general_spawn",
            EraAdvancementLoadoutRole.Legion => scope == "refresh" ? "legion_refresh" : "legion_spawn",
            _ => "direct_equip_on_spawn_or_refresh",
        };
    }

    private static bool IsDemonFactionKingdom(Kingdom kingdom)
    {
        return !string.IsNullOrWhiteSpace(kingdom?.asset?.id) &&
               kingdom.asset.id.StartsWith("ew_demon_kingdom_", StringComparison.OrdinalIgnoreCase);
    }

}
