using System;
using System.Collections.Generic;
using System.Linq;
using EraWheel.Config.Registry;
using EraWheel.Config.Schema;
using EraWheel.Combat.Statuses;
using EraWheel.Core.Constants;
using EraWheel.Core.Events;
using EraWheel.Core.Logging;
using EraWheel.Core.Random;
using EraWheel.Core.Time;
using EraWheel.Data.Definitions;
using EraWheel.Reflection;
using EraWheel.Save.Keys;
using EraWheel.Save.Models;
using EraWheel.Save.Services;
using EraWheel.Systems.Advancement;
using EraWheel.Systems.Reincarnation;
using Newtonsoft.Json;

namespace EraWheel.Systems.Progression;

public sealed class EraProgressionRuntimeService
{
    private sealed class EraTraitGrantAuditState
    {
        public string Source { get; set; } = string.Empty;
        public Actor? Parent1 { get; set; }
        public Actor? Parent2 { get; set; }
        public bool IsRerolling { get; set; }
    }

    private static readonly EquipmentType[] EquipmentSlots =
    {
        EquipmentType.Weapon,
        EquipmentType.Helmet,
        EquipmentType.Armor,
        EquipmentType.Boots,
        EquipmentType.Amulet,
        EquipmentType.Ring,
    };

    private static readonly IReadOnlyDictionary<string, string> AttributeDisplayNames =
        new Dictionary<string, string>(StringComparer.Ordinal)
        {
            [EraAttributeIds.Damage] = "伤害",
            [EraAttributeIds.MultiplierDamage] = "伤害倍率",
            [EraAttributeIds.AttackSpeed] = "攻速",
            [EraAttributeIds.MultiplierAttackSpeed] = "攻速倍率",
            [EraAttributeIds.CriticalChance] = "暴击率",
            [EraAttributeIds.CriticalDamageMultiplier] = "暴击伤害倍率",
            [EraAttributeIds.ThrowingRange] = "投掷",
            [EraAttributeIds.Range] = "范围",
            [EraAttributeIds.AreaOfEffect] = "效果范围",
            [EraAttributeIds.Knockback] = "击退",
            [EraAttributeIds.Health] = "生命值",
            [EraAttributeIds.MultiplierHealth] = "生命值倍率",
            [EraAttributeIds.Armor] = "防御",
            [EraAttributeIds.Stamina] = "耐力",
            [EraAttributeIds.MultiplierStamina] = "耐力倍率",
            [EraAttributeIds.Mana] = "法力",
            [EraAttributeIds.MultiplierMana] = "法力倍率",
            [EraAttributeIds.MaxNutrition] = "最大营养",
            [EraAttributeIds.Happiness] = "幸福度",
            [EraAttributeIds.Lifespan] = "寿命",
            [EraAttributeIds.MultiplierLifespan] = "寿命倍率",
            [EraAttributeIds.Speed] = "移速",
            [EraAttributeIds.MultiplierSpeed] = "移速倍率",
            [EraAttributeIds.Mass] = "受力质量",
            [EraAttributeIds.MultiplierMass] = "体重倍率",
            [EraAttributeIds.SkillCombat] = "战斗技能",
            [EraAttributeIds.SkillSpell] = "施法",
            [EraAttributeIds.Diplomacy] = "外交",
            [EraAttributeIds.MultiplierDiplomacy] = "外交倍率",
            [EraAttributeIds.Warfare] = "指挥",
            [EraAttributeIds.Stewardship] = "组织",
            [EraAttributeIds.Intelligence] = "智力",
        };

    private static readonly IReadOnlyList<string> HeroTitleSuffixPool = new[]
    {
        "曜锋",
        "星卫",
        "岚刃",
        "霜誓",
        "赤焰",
        "雷铸",
        "狮心",
        "龙痕",
        "影歌",
        "月冠",
        "晨辉",
        "暮炬",
        "青岚",
        "磐壁",
        "霆枪",
        "霜翼",
        "炎矛",
        "潮魂",
        "森誓",
        "砂王",
        "曙刃",
        "夜烬",
        "银旗",
        "苍穹",
        "玄铠",
        "远征",
        "天穹",
        "断浪",
        "炽轮",
        "辉纹",
    };

    private readonly EraParameterRegistry _parameterRegistry;
    private readonly EraStableRandomService _stableRandom;
    private readonly EraEventLogService _eventLog;
    private readonly EraAdvancementRuntimeService _advancementRuntime;
    private readonly EraRuntimeSaveService _runtimeSave;
    private readonly EraGrowthRangeManager _growthRanges;
    private readonly EraAutoFavoriteService _autoFavorites;
    private readonly Dictionary<string, EraHeritageTraitManifest> _heritageTraitsById;
    private readonly Dictionary<string, EraHeritageEquipmentManifest> _heritageEquipmentById;
    private readonly Dictionary<long, EraTraitGrantAuditState> _traitGrantAuditByActorId = new();

    public EraProgressionRuntimeService(
        EraParameterRegistry parameterRegistry,
        EraStableRandomService stableRandom,
        EraEventLogService eventLog,
        EraAdvancementRuntimeService advancementRuntime,
        EraRuntimeSaveService runtimeSave,
        EraGrowthRangeManager growthRanges,
        EraContentCatalog contentCatalog
    )
    {
        _parameterRegistry = parameterRegistry;
        _stableRandom = stableRandom;
        _eventLog = eventLog;
        _advancementRuntime = advancementRuntime;
        _runtimeSave = runtimeSave;
        _growthRanges = growthRanges;
        _autoFavorites = new EraAutoFavoriteService();
        _heritageTraitsById = new Dictionary<string, EraHeritageTraitManifest>(
            contentCatalog.HeritageTraitsById,
            StringComparer.Ordinal
        );
        _heritageEquipmentById = new Dictionary<string, EraHeritageEquipmentManifest>(
            contentCatalog.HeritageEquipmentById,
            StringComparer.Ordinal
        );
        EraProgressionPatchInstaller.EnsurePatched();
    }

    public void Bind()
    {
        EraProgressionRuntimeBridge.Bind(this);
        EraLog.Info(EraLogCategory.Events, $"成长运行时已初始化：{CreateStatusReport()}");
    }

    public void Rebind()
    {
    }

    public void Update()
    {
        if (World.world == null)
        {
            return;
        }

        float currentWorldTime = ReadWorldTime();
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        if (currentWorldTime < state.NextProgressionCheckWorldTime)
        {
            return;
        }

        RefreshHeroPromotions(currentWorldTime);
        state.NextProgressionCheckWorldTime = currentWorldTime + EraWorldTime.GetMonthWorldTime();
    }

    public string CreateStatusReport()
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        return
            $"轮回特质定义={_heritageTraitsById.Count}；轮回装备定义={_heritageEquipmentById.Count}；" +
            $"实例审计={state.HeritageInstanceAudit.Count}；已解锁特质={state.UnlockedHeritageTraits.Count}；已解锁装备={state.UnlockedHeritageEquipment.Count}；" +
            $"轮回随机属性候选={_parameterRegistry.Current.Advancement.RandomAttributes.CandidateAttributeIds.Count}；" +
            $"英雄档案={state.HeroArchives.Count}；王国英雄追踪器={state.KingdomHeroTrackers.Count}。";
    }

    public string ApplyCycleSurvivorBonuses(float currentWorldTime)
    {
        EraHeroParameters parameters = _parameterRegistry.Current.Heroes;
        if (!parameters.SurvivorBonusEnabled)
        {
            return "EW-100 幸存强化已关闭。";
        }

        if (World.world == null)
        {
            return "EW-100 幸存强化跳过：当前世界未加载。";
        }

        int eligibleHeroes = 0;
        int grantedHeroes = 0;
        int cappedHeroes = 0;
        int newlyCappedHeroes = 0;

        foreach (Actor actor in World.world.units)
        {
            if (actor == null || actor.isRekt() || !actor.isAlive())
            {
                continue;
            }

            EraHeroProgressionState? heroState = GetHeroProgressionState(actor);
            if (!(heroState?.IsHero ?? false))
            {
                continue;
            }

            eligibleHeroes++;
            float currentPercent = Math.Max(0f, GetCustomFloat(actor, EraEntityCustomDataKeys.HeroSurvivorBonusPercent));
            float capPercent = Math.Max(0f, parameters.SurvivorBonusCapPercent);
            if (currentPercent >= capPercent - 0.0001f)
            {
                cappedHeroes++;
                if (currentPercent > capPercent + 0.0001f)
                {
                    SetCustomFloat(actor, EraEntityCustomDataKeys.HeroSurvivorBonusPercent, capPercent);
                    actor.setStatsDirty();
                }

                continue;
            }

            float nextPercent = Math.Min(capPercent, currentPercent + parameters.SurvivorBonusPercentPerCycle);
            float deltaPercent = Math.Max(0f, nextPercent - currentPercent);
            if (deltaPercent <= 0.0001f)
            {
                cappedHeroes++;
                continue;
            }

            SetCustomFloat(actor, EraEntityCustomDataKeys.HeroSurvivorBonusPercent, nextPercent);
            actor.setStatsDirty();
            grantedHeroes++;
            if (nextPercent >= capPercent - 0.0001f)
            {
                newlyCappedHeroes++;
            }

            List<EraAttributeModifierEntry> deltaModifiers = BuildScaledModifierEntries(
                heroState.Promotion.Attributes,
                deltaPercent / 100f
            );
            _eventLog.Append(
                "progression",
                "hero_survivor_bonus_granted",
                $"EW-100 幸存强化已发放：{GetActorLabel(actor)} 本轮新增 {deltaPercent:0.##}% ，当前累计 {nextPercent:0.##}% ，折算属性 {FormatAttributeSummary(deltaModifiers)}。"
            );
        }

        return $"EW-100 幸存强化结算：存活命定英雄={eligibleHeroes}；本轮发放={grantedHeroes}；已达上限={cappedHeroes}；本轮新达上限={newlyCappedHeroes}。";
    }

    public void AppendPersistentModifiers(Actor actor, IDictionary<string, float> bucket)
    {
        if (actor == null || bucket == null || actor.isRekt())
        {
            return;
        }

        EraHeroProgressionState? heroState = GetHeroProgressionState(actor);
        if (heroState != null)
        {
            MergeModifiers(bucket, heroState.Promotion.Attributes);
            MergeModifiers(bucket, heroState.Inheritance.Attributes);

            float survivorBonusPercent = Math.Max(0f, GetCustomFloat(actor, EraEntityCustomDataKeys.HeroSurvivorBonusPercent));
            if (survivorBonusPercent > 0.0001f && heroState.Promotion.Attributes.Count > 0)
            {
                MergeModifiers(bucket, BuildScaledModifierEntries(heroState.Promotion.Attributes, survivorBonusPercent / 100f));
            }
        }

        PruneMissingTraitStates(actor);
        foreach (ActorTrait trait in actor.getTraits())
        {
            if (trait == null || string.IsNullOrWhiteSpace(trait.id))
            {
                continue;
            }

            EraTraitInstanceAttributeState? state = EnsureHeritageTraitInstance(actor, trait, "trait_runtime", silent: true);
            if (state == null)
            {
                continue;
            }

            MergeModifiers(bucket, state.Attributes);
        }

        if (actor.equipment != null)
        {
            foreach (EquipmentType slotType in EquipmentSlots)
            {
                Item? item = actor.equipment.getSlot(slotType)?.getItem();
                if (item == null)
                {
                    continue;
                }

                EraEquipmentInstanceAttributeState? state = EnsureHeritageEquipmentInstance(item, actor, "equipment_runtime", silent: true);
                if (state == null)
                {
                    continue;
                }

                MergeModifiers(bucket, state.Attributes);
            }
        }
    }

    public void OnActorBorn(Actor actor)
    {
        if (actor == null || actor.isRekt() || !actor.hasKingdom() || actor.kingdom == null || IsDemonFactionKingdom(actor.kingdom))
        {
            return;
        }

        TryApplyBloodlineInheritance(actor);
    }

    public void BeginRandomTraitGrant(Actor actor, string source, Actor? parent1 = null, Actor? parent2 = null)
    {
        if (actor == null || actor.isRekt() || string.IsNullOrWhiteSpace(source))
        {
            return;
        }

        _traitGrantAuditByActorId[actor.getID()] = new EraTraitGrantAuditState
        {
            Source = source,
            Parent1 = parent1,
            Parent2 = parent2,
        };
    }

    public void EndRandomTraitGrant(Actor actor, string source)
    {
        if (actor == null)
        {
            return;
        }

        _traitGrantAuditByActorId.Remove(actor.getID());
    }

    public void OnTraitAdded(Actor actor, ActorTrait trait)
    {
        if (actor == null || trait == null || actor.isRekt())
        {
            return;
        }

        if (TryReplaceLockedRandomTrait(actor, trait))
        {
            return;
        }

        if (ShouldRejectTraitGrant(actor, trait))
        {
            actor.removeTrait(trait);
            return;
        }

        EnsureHeritageTraitInstance(actor, trait, ResolveTraitGrantSource(actor), silent: false);
    }

    public void OnTraitRemoved(Actor actor, ActorTrait trait)
    {
        if (actor == null || trait == null || string.IsNullOrWhiteSpace(trait.id))
        {
            return;
        }

        RemoveString(actor.getData(), EraProgressionDataKeys.BuildTraitInstanceKey(trait.id));
    }

    public void MarkEquipmentPendingGrant(Item item, string source)
    {
        if (item == null || item.asset == null || !_heritageEquipmentById.ContainsKey(item.asset.id) || item.data == null)
        {
            return;
        }

        item.data.set(EraProgressionDataKeys.EquipmentPendingSource, source ?? string.Empty);
    }

    public void EnsureEquipmentStored(Item item, Actor? actor, string source)
    {
        EnsureHeritageEquipmentInstance(item, actor, source, silent: false);
    }

    public void NormalizeMutationBoxBirthTraits(SubspeciesActorBirthTraits container)
    {
        if (container == null || !WorldLawLibrary.world_law_mutant_box.isEnabled())
        {
            return;
        }

        List<ActorTrait> current = container.getTraits().ToList();
        int replacements = 0;
        foreach (ActorTrait trait in current)
        {
            if (trait == null || CanReceiveRandomHeritageTrait(trait, null))
            {
                continue;
            }

            if (container.removeTrait(trait))
            {
                replacements++;
            }
        }

        if (replacements <= 0)
        {
            return;
        }

        List<ActorTrait> pool = FilterUnlockedTraits(AssetManager.traits.pot_traits_mutation_box, null);
        for (int index = 0; index < replacements; index++)
        {
            ActorTrait? random = PickRandomTrait(pool);
            if (random == null)
            {
                break;
            }

            if (CanAddMutationBoxReplacementTrait(random))
            {
                container.addTrait(random, pRemoveOpposites: true);
            }
        }
    }

    private bool CanAddMutationBoxReplacementTrait(ActorTrait? trait)
    {
        if (trait == null)
        {
            return false;
        }

        if (!string.IsNullOrWhiteSpace(trait.id) && _heritageTraitsById.ContainsKey(trait.id))
        {
            return CanReceiveRandomHeritageTrait(trait, null);
        }

        return trait.isAvailable();
    }

    public EraTraitInstanceAttributeState? GetTraitInstanceState(Actor actor, string traitId)
    {
        return NormalizeTraitState(ReadState<EraTraitInstanceAttributeState>(actor.getData(), EraProgressionDataKeys.BuildTraitInstanceKey(traitId)));
    }

    public EraEquipmentInstanceAttributeState? GetEquipmentInstanceState(Item item)
    {
        return NormalizeEquipmentState(ReadState<EraEquipmentInstanceAttributeState>(item.data, EraProgressionDataKeys.EquipmentInstance));
    }

    public EraHeroProgressionState? GetHeroProgressionStateSnapshot(Actor actor)
    {
        return GetHeroProgressionState(actor);
    }

    private void RefreshHeroPromotions(float currentWorldTime)
    {
        if (World.world == null)
        {
            return;
        }

        HashSet<long> activeIds = new();
        foreach (Kingdom kingdom in World.world.kingdoms)
        {
            if (kingdom == null || kingdom.isRekt() || IsDemonFactionKingdom(kingdom))
            {
                continue;
            }

            activeIds.Add(kingdom.id);
            EraKingdomHeroTrackerState tracker = EnsureHeroTracker(kingdom, currentWorldTime);
            int pendingPromotions = RefreshPendingHeroPromotions(kingdom, tracker, currentWorldTime);
            for (int index = 0; index < pendingPromotions; index++)
            {
                if (!TryPromoteHero(kingdom, tracker, currentWorldTime))
                {
                    break;
                }

                tracker.PendingPromotionCharges = Math.Max(0, tracker.PendingPromotionCharges - 1);
            }
        }

        _runtimeSave.CurrentState.KingdomHeroTrackers.RemoveAll(item => !activeIds.Contains(item.KingdomId));
    }

    private EraKingdomHeroTrackerState EnsureHeroTracker(Kingdom kingdom, float currentWorldTime)
    {
        EraKingdomHeroTrackerState tracker = _runtimeSave.CurrentState.KingdomHeroTrackers
            .FirstOrDefault(item => item.KingdomId == kingdom.id)
            ?? CreateHeroTracker(kingdom, currentWorldTime);

        tracker.KingdomName = kingdom.name ?? tracker.KingdomName;
        if (tracker.CrisisWindowStartedWorldTime <= 0f)
        {
            tracker.CrisisWindowStartedWorldTime = currentWorldTime;
        }

        if (tracker.CrisisWindowStartPopulation <= 0)
        {
            tracker.CrisisWindowStartPopulation = Math.Max(0, kingdom.getPopulationTotal());
        }

        return tracker;
    }

    private EraKingdomHeroTrackerState CreateHeroTracker(Kingdom kingdom, float currentWorldTime)
    {
        int population = Math.Max(0, kingdom.getPopulationTotal());
        EraKingdomHeroTrackerState tracker = new EraKingdomHeroTrackerState
        {
            KingdomId = kingdom.id,
            KingdomName = !string.IsNullOrWhiteSpace(kingdom.name) ? kingdom.name : $"#{kingdom.id}",
            LastObservedPopulation = population,
            CrisisWindowStartPopulation = population,
            CrisisWindowStartedWorldTime = currentWorldTime,
        };
        _runtimeSave.CurrentState.KingdomHeroTrackers.Add(tracker);
        return tracker;
    }

    private int RefreshPendingHeroPromotions(Kingdom kingdom, EraKingdomHeroTrackerState tracker, float currentWorldTime)
    {
        EraHeroParameters parameters = _parameterRegistry.Current.Heroes;
        int currentPopulation = Math.Max(0, kingdom.getPopulationTotal());
        if (currentPopulation > tracker.LastObservedPopulation)
        {
            tracker.AccumulatedPopulationGrowth += currentPopulation - tracker.LastObservedPopulation;
        }

        int prosperityAvailable = parameters.ProsperityPopulationGrowthThreshold <= 0
            ? 0
            : tracker.AccumulatedPopulationGrowth / parameters.ProsperityPopulationGrowthThreshold - tracker.ConsumedProsperityPromotions;
        if (prosperityAvailable > 0)
        {
            tracker.PendingPromotionCharges += prosperityAvailable;
            tracker.ConsumedProsperityPromotions += prosperityAvailable;
        }

        if (currentWorldTime - tracker.CrisisWindowStartedWorldTime > parameters.CrisisWindow.WorldTime)
        {
            tracker.CrisisWindowStartedWorldTime = currentWorldTime;
            tracker.CrisisWindowStartPopulation = currentPopulation;
        }
        else if (tracker.CrisisWindowStartPopulation > 0)
        {
            float thresholdPopulation = tracker.CrisisWindowStartPopulation * (1f - parameters.CrisisPopulationLossPercent / 100f);
            if (currentPopulation <= thresholdPopulation)
            {
                tracker.PendingPromotionCharges++;
                tracker.CrisisWindowStartedWorldTime = currentWorldTime;
                tracker.CrisisWindowStartPopulation = currentPopulation;
                _eventLog.Append(
                    "progression",
                    "hero_crisis_triggered",
                    $"EW-097 危机晋升触发：{GetKingdomLabel(kingdom)} 在 {parameters.CrisisWindow.Years:0.#} 年窗口内人口跌到 {currentPopulation}。"
                );
            }
        }

        tracker.LastObservedPopulation = currentPopulation;
        return tracker.PendingPromotionCharges;
    }

    private bool TryPromoteHero(Kingdom kingdom, EraKingdomHeroTrackerState tracker, float currentWorldTime)
    {
        int worldHeroCount = CountLivingHeroes();
        int kingdomHeroCount = CountLivingHeroes(kingdom);
        if (worldHeroCount >= _parameterRegistry.Current.Heroes.HeroesWorldLimit ||
            kingdomHeroCount >= _parameterRegistry.Current.Heroes.HeroesPerKingdomLimit)
        {
            _eventLog.Append(
                "progression",
                "hero_promotion_skipped_by_limit",
                $"EW-097 英雄晋升被上限拦截：{GetKingdomLabel(kingdom)} 当前英雄 {kingdomHeroCount}/{_parameterRegistry.Current.Heroes.HeroesPerKingdomLimit}，世界英雄 {worldHeroCount}/{_parameterRegistry.Current.Heroes.HeroesWorldLimit}。"
            );
            return false;
        }

        List<Actor> candidates = BuildHeroCandidates(kingdom);
        if (candidates.Count == 0)
        {
            _eventLog.Append("progression", "hero_promotion_no_candidate", $"EW-098 英雄候选为空：{GetKingdomLabel(kingdom)} 当前没有可晋升对象。");
            return false;
        }

        EraHeroParameters parameters = _parameterRegistry.Current.Heroes;
        List<(Actor Actor, float Score)> scored = candidates
            .Select(actor => (Actor: actor, Score: CalculateHeroScore(actor)))
            .OrderByDescending(item => item.Score)
            .ThenBy(item => item.Actor.getID())
            .ToList();
        int topCount = Math.Max(1, Math.Min(parameters.RandomTopCandidateCount, scored.Count));
        List<(Actor Actor, float Score)> top = scored.Take(topCount).ToList();
        int pickIndex = _stableRandom.NextInt(
            "progression:hero_pick",
            $"{kingdom.id}:{tracker.ConsumedProsperityPromotions}:{CountLivingHeroes()}:{(int)currentWorldTime}",
            0,
            top.Count
        );

        return ApplyHeroPromotion(kingdom, top[pickIndex].Actor, top[pickIndex].Score, currentWorldTime);
    }

    private bool ApplyHeroPromotion(Kingdom kingdom, Actor actor, float score, float currentWorldTime)
    {
        if (actor == null || actor.isRekt())
        {
            return false;
        }

        EraHeroProgressionState state = GetHeroProgressionState(actor) ?? new EraHeroProgressionState();
        if (state.IsHero)
        {
            return false;
        }

        List<EraAttributeModifierEntry> promotionAttributes = RollHeroPromotionAttributes(actor);
        string suffix = ResolveHeroTitleSuffix(actor);
        bool wasAwakened = GetCustomBool(actor, EraEntityCustomDataKeys.HeroAwakened);

        state.IsHero = true;
        state.PromotionReason = "promotion";
        state.PromotedWorldTime = currentWorldTime;
        state.TitleSuffix = suffix;
        state.Promotion = new EraHeroPromotionAttributeState
        {
            GrantedWorldTime = currentWorldTime,
            Attributes = promotionAttributes,
        };
        state.Inheritance ??= new EraHeroPromotionAttributeState();
        WriteHeroProgressionState(actor, state);

        SetCustomLong(actor, EraEntityCustomDataKeys.HeroBloodlineRootId, actor.getID());
        SetCustomInt(actor, EraEntityCustomDataKeys.HeroBloodlineGeneration, 0);
        SetCustomBool(actor, EraEntityCustomDataKeys.HeroAwakened, wasAwakened);
        UpsertHeroArchive(actor, currentWorldTime, promotionAttributes);
        ApplyHeroDisplayName(actor, suffix);

        EraAutoFavoriteResult favoriteResult = _autoFavorites.TryFavorite(actor);
        if (favoriteResult.IsFailure && !favoriteResult.AlreadyFavorite)
        {
            EraLog.Warning(EraLogCategory.Data, $"EW-057 命定英雄自动收藏失败：{GetActorLabel(actor)} -> {favoriteResult.Reason}");
        }

        _eventLog.Append(
            "progression",
            "hero_promoted",
            $"EW-098 命定英雄已晋升：{GetActorLabel(actor)} 属于 {GetKingdomLabel(kingdom)}，评分 {score:0.###}，称号「{suffix}」，获得 {FormatAttributeSummary(promotionAttributes)}。"
        );
        return true;
    }

    private void TryApplyBloodlineInheritance(Actor actor)
    {
        if (GetCustomLong(actor, EraEntityCustomDataKeys.HeroBloodlineRootId) > 0L ||
            (GetHeroProgressionState(actor)?.Inheritance.Attributes.Count ?? 0) > 0)
        {
            return;
        }

        if (actor.getData() is not ActorData actorData)
        {
            return;
        }

        EraHeroLineageCandidate? parent1 = ResolveLineageCandidate(actorData.parent_id_1);
        EraHeroLineageCandidate? parent2 = ResolveLineageCandidate(actorData.parent_id_2);
        EraHeroLineageCandidate? chosen = ChooseLineageCandidate(parent1, parent2);
        if (chosen == null)
        {
            return;
        }

        SetCustomLong(actor, EraEntityCustomDataKeys.HeroBloodlineRootId, chosen.RootHeroId);
        SetCustomInt(actor, EraEntityCustomDataKeys.HeroBloodlineGeneration, chosen.Generation);
        SetCustomBool(actor, EraEntityCustomDataKeys.HeroAwakened, false);

        float roll = _stableRandom.NextFloat(
            "progression:hero_bloodline_chance",
            $"bloodline:{actor.getID()}:{chosen.RootHeroId}:{chosen.Generation}",
            0f,
            100f
        );
        if (roll > _parameterRegistry.Current.Heroes.BloodlineInheritanceChancePercent)
        {
            _eventLog.Append(
                "progression",
                "hero_bloodline_linked",
                $"EW-099 血脉已记录但未觉醒：{GetActorLabel(actor)} 追溯到英雄祖先 #{chosen.RootHeroId}，代数 {chosen.Generation}。"
            );
            return;
        }

        EraHeroArchiveState? archive = _runtimeSave.CurrentState.HeroArchives
            .FirstOrDefault(item => item.HeroActorId == chosen.RootHeroId);
        if (archive == null || archive.PromotionAttributes.Count == 0)
        {
            return;
        }

        float ratio = _parameterRegistry.Current.Heroes.BloodlineInheritanceValuePercent / 100f;
        List<EraAttributeModifierEntry> inherited = archive.PromotionAttributes
            .Select(entry => new EraAttributeModifierEntry
            {
                AttributeId = entry.AttributeId,
                Value = entry.Value * ratio,
            })
            .Where(entry => Math.Abs(entry.Value) > 0.0001f)
            .ToList();
        if (inherited.Count == 0)
        {
            return;
        }

        EraHeroProgressionState state = GetHeroProgressionState(actor) ?? new EraHeroProgressionState();
        state.Inheritance = new EraHeroPromotionAttributeState
        {
            GrantedWorldTime = ReadWorldTime(),
            Attributes = inherited,
        };
        WriteHeroProgressionState(actor, state);
        SetCustomBool(actor, EraEntityCustomDataKeys.HeroAwakened, true);
        _eventLog.Append(
            "progression",
            "hero_bloodline_awakened",
            $"EW-099 血脉觉醒成功：{GetActorLabel(actor)} 继承英雄祖先 #{chosen.RootHeroId} 的 {FormatAttributeSummary(inherited)}。"
        );
    }

    private EraHeroLineageCandidate? ResolveLineageCandidate(long actorId)
    {
        if (World.world == null || actorId <= 0L)
        {
            return null;
        }

        Actor? actor = World.world.units.get(actorId);
        if (actor == null)
        {
            return null;
        }

        EraHeroProgressionState? state = GetHeroProgressionState(actor);
        if (state?.IsHero == true)
        {
            return new EraHeroLineageCandidate(actor.getID(), 1);
        }

        long rootHeroId = GetCustomLong(actor, EraEntityCustomDataKeys.HeroBloodlineRootId);
        int generation = GetCustomInt(actor, EraEntityCustomDataKeys.HeroBloodlineGeneration);
        if (rootHeroId <= 0L || generation < 0)
        {
            return null;
        }

        int inheritedGeneration = generation + 1;
        return inheritedGeneration > _parameterRegistry.Current.Heroes.BloodlineGenerationLimit
            ? null
            : new EraHeroLineageCandidate(rootHeroId, inheritedGeneration);
    }

    private static EraHeroLineageCandidate? ChooseLineageCandidate(EraHeroLineageCandidate? left, EraHeroLineageCandidate? right)
    {
        if (left == null)
        {
            return right;
        }

        if (right == null)
        {
            return left;
        }

        return left.Generation <= right.Generation ? left : right;
    }

    private List<Actor> BuildHeroCandidates(Kingdom kingdom)
    {
        if (World.world == null)
        {
            return new List<Actor>();
        }

        return World.world.units
            .Where(actor => actor != null &&
                            !actor.isRekt() &&
                            actor.isAlive() &&
                            actor.hasKingdom() &&
                            actor.kingdom == kingdom &&
                            actor.isSapient() &&
                            !IsDemonFactionKingdom(actor.kingdom) &&
                            !(GetHeroProgressionState(actor)?.IsHero ?? false))
            .ToList();
    }

    private float CalculateHeroScore(Actor actor)
    {
        EraHeroScoreProfile profile = _parameterRegistry.Current.Heroes.ScoreProfile;
        float score = 0f;
        score += BuildNormalizedMetric(actor.level, profile.LevelThreshold, profile.LevelWeight);
        score += BuildNormalizedMetric(GetActorKills(actor), profile.KillThreshold, profile.KillWeight);
        score += BuildNormalizedMetric(EraWorldboxStatsAccessor.GetStat(actor, EraAttributeIds.Health), profile.HealthThreshold, profile.HealthWeight);
        score += BuildNormalizedMetric(EraWorldboxStatsAccessor.GetStat(actor, EraAttributeIds.Damage), profile.DamageThreshold, profile.DamageWeight);
        score += BuildNormalizedMetric(actor.warfare, profile.WarfareThreshold, profile.WarfareWeight);

        if (GetCustomBool(actor, EraEntityCustomDataKeys.HeroAwakened) &&
            GetHeroProgressionState(actor)?.Inheritance.Attributes.Count > 0)
        {
            score *= 1f + _parameterRegistry.Current.Heroes.AwakenedScoreBonusPercent / 100f;
        }

        return score;
    }

    private static float BuildNormalizedMetric(float value, float threshold, float weight)
    {
        if (threshold <= 0f || weight <= 0f)
        {
            return 0f;
        }

        return Math.Min(value / threshold, 1f) * weight;
    }

    private int CountLivingHeroes(Kingdom? kingdom = null)
    {
        if (World.world == null)
        {
            return 0;
        }

        return World.world.units.Count(actor => actor != null &&
                                               !actor.isRekt() &&
                                               actor.isAlive() &&
                                               (kingdom == null || actor.kingdom == kingdom) &&
                                               (GetHeroProgressionState(actor)?.IsHero ?? false));
    }

    private List<EraAttributeModifierEntry> RollHeroPromotionAttributes(Actor actor)
    {
        IReadOnlyDictionary<string, EraFloatRange> ranges = _parameterRegistry.Current.Growth.HeroPromotionRanges;
        List<EraAttributeModifierEntry> result = new List<EraAttributeModifierEntry>(ranges.Count);
        foreach (KeyValuePair<string, EraFloatRange> pair in ranges)
        {
            string attributeId = pair.Key;
            EraFloatRange configuredRange = pair.Value;
            if (!_growthRanges.TryGetFrozenRange(EraGrowthTrackIds.Hero, attributeId, out EraFloatRange range))
            {
                range = configuredRange;
            }

            float value = _stableRandom.NextFloat(
                "progression:hero_attr_roll",
                $"hero:{actor.getID()}:{attributeId}:{_runtimeSave.CurrentState.CompletedCycles}",
                range.Min,
                range.Max
            );
            if (Math.Abs(value) <= 0.0001f)
            {
                continue;
            }

            _growthRanges.RecordSample(EraGrowthTrackIds.Hero, attributeId, value);
            result.Add(
                new EraAttributeModifierEntry
                {
                    AttributeId = attributeId,
                    Value = EraPercentAttributeRules.ToRawEngineValue(attributeId, value),
                }
            );
        }

        return result;
    }

    private EraHeroProgressionState? GetHeroProgressionState(Actor actor)
    {
        return NormalizeHeroProgressionState(ReadState<EraHeroProgressionState>(actor.getData(), EraProgressionDataKeys.ActorHeroState));
    }

    private void WriteHeroProgressionState(Actor actor, EraHeroProgressionState state)
    {
        WriteState(actor.getData(), EraProgressionDataKeys.ActorHeroState, NormalizeHeroProgressionState(state)!);
    }

    private void UpsertHeroArchive(Actor actor, float currentWorldTime, List<EraAttributeModifierEntry> promotionAttributes)
    {
        EraHeroArchiveState? existing = _runtimeSave.CurrentState.HeroArchives
            .FirstOrDefault(item => item.HeroActorId == actor.getID());
        EraHeroArchiveState archive = existing ?? new EraHeroArchiveState
        {
            HeroActorId = actor.getID(),
        };

        archive.HeroName = actor.getName();
        archive.PromotedWorldTime = currentWorldTime;
        archive.PromotionAttributes = promotionAttributes.Select(
            entry => new EraAttributeModifierEntry
            {
                AttributeId = entry.AttributeId,
                Value = entry.Value,
            }
        ).ToList();

        if (existing == null)
        {
            _runtimeSave.CurrentState.HeroArchives.Add(archive);
        }
    }

    private string ResolveHeroTitleSuffix(Actor actor)
    {
        int index = _stableRandom.NextInt(
            "progression:hero_title",
            $"hero_title:{actor.getID()}:{_runtimeSave.CurrentState.CompletedCycles}",
            0,
            HeroTitleSuffixPool.Count
        );
        return HeroTitleSuffixPool[index];
    }

    private static void ApplyHeroDisplayName(Actor actor, string suffix)
    {
        if (string.IsNullOrWhiteSpace(suffix))
        {
            return;
        }

        string currentName = actor.getName();
        if (!string.IsNullOrWhiteSpace(currentName) && currentName.IndexOf($"·{suffix}", StringComparison.Ordinal) >= 0)
        {
            return;
        }

        string baseName = string.IsNullOrWhiteSpace(currentName) ? $"Actor#{actor.getID()}" : currentName.Trim();
        actor.setName($"{baseName}·{suffix}", pTrack: true);
    }

    private EraTraitInstanceAttributeState? EnsureHeritageTraitInstance(Actor actor, ActorTrait trait, string source, bool silent)
    {
        if (actor == null ||
            trait == null ||
            !_heritageTraitsById.TryGetValue(trait.id, out EraHeritageTraitManifest? manifest))
        {
            return null;
        }

        string key = EraProgressionDataKeys.BuildTraitInstanceKey(trait.id);
        EraTraitInstanceAttributeState? existing = NormalizeTraitState(ReadState<EraTraitInstanceAttributeState>(actor.getData(), key));
        if (existing != null)
        {
            return existing;
        }

        float worldTime = ReadWorldTime();
        int grantedTier = _advancementRuntime.GetEffectiveActorTier(actor);
        int worldTier = _advancementRuntime.GetCurrentWorldTier();
        long kingdomId = actor.hasKingdom() ? actor.kingdom.id : 0L;
        EraTraitInstanceAttributeState state = new EraTraitInstanceAttributeState
        {
            TraitId = trait.id,
            GrantedWorldTime = worldTime,
            GrantedCycle = _runtimeSave.CurrentState.CompletedCycles,
            UnlockTier = manifest.UnlockTier,
            GrantedTier = grantedTier,
            SourceWorldTier = worldTier,
            SourceKingdomId = kingdomId,
            SourceKingdomTier = kingdomId > 0L ? grantedTier : 0,
            GrantedActorId = actor.getID(),
            GrantedActorName = actor.getName(),
            Source = source,
            Attributes = RollAdvancementAttributes(
                manifest.RandomAttributes.DrawCount,
                $"trait:{actor.getID()}:{trait.id}:{source}:{worldTime:F2}"
            ),
        };

        WriteState(actor.getData(), key, state);
        AppendHeritageInstanceAudit(
            new EraHeritageInstanceAuditEntry
            {
                Kind = "trait",
                DefinitionId = trait.id,
                GrantedWorldTime = state.GrantedWorldTime,
                GrantedCycle = state.GrantedCycle,
                UnlockTier = state.UnlockTier,
                GrantedTier = state.GrantedTier,
                SourceWorldTier = state.SourceWorldTier,
                SourceKingdomId = state.SourceKingdomId,
                SourceKingdomTier = state.SourceKingdomTier,
                GrantedActorId = state.GrantedActorId,
                GrantedActorName = state.GrantedActorName,
                Source = state.Source,
                Attributes = state.Attributes.Select(CloneModifier).ToList(),
            }
        );
        if (!silent)
        {
            _eventLog.Append(
                "progression",
                "heritage_trait_instance_assigned",
                $"EW-093 轮回特质实例已写入：{GetActorLabel(actor)} 获得 {manifest.DisplayName}，来源={source}，生效档位=T{grantedTier}，实例属性={FormatAttributeSummary(state.Attributes)}。"
            );
        }

        return state;
    }

    private EraEquipmentInstanceAttributeState? EnsureHeritageEquipmentInstance(Item item, Actor? actor, string source, bool silent)
    {
        if (item == null ||
            item.asset == null ||
            !_heritageEquipmentById.TryGetValue(item.asset.id, out EraHeritageEquipmentManifest? manifest))
        {
            return null;
        }

        string resolvedSource = ResolveEquipmentGrantSource(item, source);
        EraEquipmentInstanceAttributeState? existing = NormalizeEquipmentState(
            ReadState<EraEquipmentInstanceAttributeState>(item.data, EraProgressionDataKeys.EquipmentInstance)
        );
        if (existing != null)
        {
            ClearEquipmentPendingGrant(item);
            return existing;
        }

        float worldTime = ReadWorldTime();
        int worldTier = _advancementRuntime.GetCurrentWorldTier();
        int grantedTier = actor != null ? _advancementRuntime.GetEffectiveActorTier(actor) : worldTier;
        long kingdomId = actor != null && actor.hasKingdom() ? actor.kingdom.id : 0L;
        EraEquipmentInstanceAttributeState state = new EraEquipmentInstanceAttributeState
        {
            EquipmentId = item.asset.id,
            GrantedWorldTime = worldTime,
            GrantedCycle = _runtimeSave.CurrentState.CompletedCycles,
            UnlockTier = manifest.UnlockTier,
            GrantedTier = grantedTier,
            SourceWorldTier = worldTier,
            SourceKingdomId = kingdomId,
            SourceKingdomTier = kingdomId > 0L ? grantedTier : 0,
            GrantedActorId = actor?.getID() ?? 0L,
            GrantedActorName = actor?.getName() ?? string.Empty,
            GrantedItemId = item.getID(),
            Source = resolvedSource,
            Attributes = RollAdvancementAttributes(
                manifest.RandomAttributes.DrawCount,
                $"equipment:{item.getID()}:{item.asset.id}:{resolvedSource}:{grantedTier}:{worldTime:F2}"
            ),
        };

        WriteState(item.data, EraProgressionDataKeys.EquipmentInstance, state);
        ClearEquipmentPendingGrant(item);
        AppendHeritageInstanceAudit(
            new EraHeritageInstanceAuditEntry
            {
                Kind = "equipment",
                DefinitionId = item.asset.id,
                GrantedWorldTime = state.GrantedWorldTime,
                GrantedCycle = state.GrantedCycle,
                UnlockTier = state.UnlockTier,
                GrantedTier = state.GrantedTier,
                SourceWorldTier = state.SourceWorldTier,
                SourceKingdomId = state.SourceKingdomId,
                SourceKingdomTier = state.SourceKingdomTier,
                GrantedActorId = state.GrantedActorId,
                GrantedActorName = state.GrantedActorName,
                GrantedItemId = state.GrantedItemId,
                Source = state.Source,
                Attributes = state.Attributes.Select(CloneModifier).ToList(),
            }
        );
        if (!silent)
        {
            _eventLog.Append(
                "progression",
                "heritage_equipment_instance_assigned",
                $"EW-094 轮回装备实例已写入：{manifest.DisplayName}（Item#{item.getID()}），来源={resolvedSource}，对象={state.GrantedActorName}，生效档位=T{grantedTier}，实例属性={FormatAttributeSummary(state.Attributes)}。"
            );
        }

        return state;
    }

    private int AddInheritedTraits(Actor parent, Actor child, ICollection<ActorTrait> target)
    {
        int inheritedKinds = 0;
        foreach (ActorTrait trait in parent.getTraits())
        {
            if (trait == null || (trait.rate_inherit == 0 && trait.rate_birth == 0))
            {
                continue;
            }

            if (!CanReceiveRandomHeritageTrait(trait, child))
            {
                continue;
            }

            inheritedKinds++;
            AddTraitCopies(target, trait, trait.rate_birth);
            AddTraitCopies(target, trait, trait.rate_inherit);
        }

        return inheritedKinds;
    }

    private static void AddTraitCopies(ICollection<ActorTrait> target, ActorTrait trait, int amount)
    {
        for (int index = 0; index < amount; index++)
        {
            target.Add(trait);
        }
    }

    private List<ActorTrait> FilterUnlockedTraits(
        IEnumerable<ActorTrait> source,
        Actor? actor,
        Func<ActorTrait, bool>? extraFilter = null
    )
    {
        List<ActorTrait> result = new List<ActorTrait>();
        foreach (ActorTrait trait in source)
        {
            if (trait == null || !CanReceiveRandomHeritageTrait(trait, actor))
            {
                continue;
            }

            if (extraFilter != null && !extraFilter(trait))
            {
                continue;
            }

            result.Add(trait);
        }

        return result;
    }

    private bool CanReceiveRandomHeritageTrait(ActorTrait trait, Actor? actor)
    {
        if (trait == null || !_heritageTraitsById.TryGetValue(trait.id, out EraHeritageTraitManifest? manifest))
        {
            return true;
        }

        if (!_advancementRuntime.IsWorldHeritageTraitUnlocked(trait.id))
        {
            return false;
        }

        if (actor != null && ShouldRejectTraitGrant(actor, trait))
        {
            return false;
        }

        int effectiveTier = actor == null
            ? _advancementRuntime.GetCurrentWorldTier()
            : _advancementRuntime.GetEffectiveActorTier(actor);
        return effectiveTier >= manifest.UnlockTier;
    }

    private bool ShouldRejectTraitGrant(Actor actor, ActorTrait trait)
    {
        return string.Equals(trait.id, "trait_herit_t9_holy_judgement", StringComparison.Ordinal) &&
               actor.hasKingdom() &&
               actor.kingdom != null &&
               IsDemonFactionKingdom(actor.kingdom);
    }

    private bool TryReplaceLockedRandomTrait(Actor actor, ActorTrait trait)
    {
        if (!_traitGrantAuditByActorId.TryGetValue(actor.getID(), out EraTraitGrantAuditState? audit) ||
            audit.IsRerolling ||
            CanReceiveRandomHeritageTrait(trait, actor))
        {
            return false;
        }

        audit.IsRerolling = true;
        actor.removeTrait(trait);
        ActorTrait? replacement = TryPickReplacementTrait(actor, audit);
        if (replacement != null)
        {
            actor.addTrait(replacement.id);
        }

        audit.IsRerolling = false;
        if (replacement == null)
        {
            _eventLog.Append(
                "progression",
                "heritage_trait_reroll_exhausted",
                $"EW-093 轮回特质重抽失败：{GetActorLabel(actor)} 在来源 {audit.Source} 中跳过了 {trait.id}，因为当前没有可用解锁条目。"
            );
        }

        return true;
    }

    private ActorTrait? TryPickReplacementTrait(Actor actor, EraTraitGrantAuditState audit)
    {
        IReadOnlyList<ActorTrait> pool = audit.Source switch
        {
            "birth" => FilterUnlockedTraits(
                AssetManager.traits.pot_traits_birth,
                actor,
                candidate => actor.asset.traits_ignore == null || !actor.asset.traits_ignore.Contains(candidate.id)
            ),
            "grow_up" => FilterUnlockedTraits(
                AssetManager.traits.pot_traits_growup,
                actor,
                candidate => (actor.asset.traits_ignore == null || !actor.asset.traits_ignore.Contains(candidate.id)) &&
                             (!candidate.acquire_grow_up_sapient_only || actor.isSapient())
            ),
            "inheritance" => BuildInheritanceReplacementPool(actor, audit.Parent1, audit.Parent2),
            _ => Array.Empty<ActorTrait>(),
        };

        if (pool.Count == 0)
        {
            return null;
        }

        int attempts = Math.Max(pool.Count, 12);
        for (int index = 0; index < attempts; index++)
        {
            ActorTrait? candidate = PickRandomTrait(pool);
            if (candidate == null ||
                actor.hasTrait(candidate) ||
                (actor.asset.traits_ignore != null && actor.asset.traits_ignore.Contains(candidate.id)) ||
                !CanReceiveRandomHeritageTrait(candidate, actor))
            {
                continue;
            }

            return candidate;
        }

        return null;
    }

    private IReadOnlyList<ActorTrait> BuildInheritanceReplacementPool(Actor child, Actor? parent1, Actor? parent2)
    {
        List<ActorTrait> weightedPool = new List<ActorTrait>(128);
        if (parent1 != null)
        {
            AddInheritedTraits(parent1, child, weightedPool);
        }

        if (parent2 != null)
        {
            AddInheritedTraits(parent2, child, weightedPool);
        }

        return weightedPool;
    }

    private string ResolveTraitGrantSource(Actor actor)
    {
        return _traitGrantAuditByActorId.TryGetValue(actor.getID(), out EraTraitGrantAuditState? audit)
            ? audit.Source
            : "manual_grant";
    }

    private string ResolveEquipmentGrantSource(Item item, string fallbackSource)
    {
        if (item?.data == null)
        {
            return fallbackSource;
        }

        item.data.get(EraProgressionDataKeys.EquipmentPendingSource, out string pending, string.Empty);
        return string.IsNullOrWhiteSpace(pending) ? fallbackSource : pending;
    }

    private void ClearEquipmentPendingGrant(Item item)
    {
        RemoveString(item?.data, EraProgressionDataKeys.EquipmentPendingSource);
    }

    private void AppendHeritageInstanceAudit(EraHeritageInstanceAuditEntry entry)
    {
        if (entry == null || string.IsNullOrWhiteSpace(entry.DefinitionId))
        {
            return;
        }

        _runtimeSave.CurrentState.HeritageInstanceAudit.Add(entry);
    }

    private void PruneMissingTraitStates(Actor actor)
    {
        foreach (string traitId in _heritageTraitsById.Keys)
        {
            if (actor.hasTrait(traitId))
            {
                continue;
            }

            RemoveString(actor.getData(), EraProgressionDataKeys.BuildTraitInstanceKey(traitId));
        }
    }

    private List<EraAttributeModifierEntry> RollAdvancementAttributes(int count, string scope)
    {
        EraRandomAttributeProfile profile = _parameterRegistry.Current.Advancement.RandomAttributes;
        List<string> available = profile.CandidateAttributeIds
            .Where(attributeId => profile.AttributeRanges.ContainsKey(attributeId))
            .Distinct(StringComparer.Ordinal)
            .ToList();
        List<EraAttributeModifierEntry> result = new List<EraAttributeModifierEntry>();

        for (int index = 0; index < count && available.Count > 0; index++)
        {
            int pickIndex = _stableRandom.NextInt("progression:advancement_attr_pick", $"{scope}:pick:{index}", 0, available.Count);
            string attributeId = available[pickIndex];
            available.RemoveAt(pickIndex);
            EraFloatRange range = profile.AttributeRanges[attributeId];
            float value = _stableRandom.NextFloat(
                "progression:advancement_attr_roll",
                $"{scope}:{attributeId}:{index}",
                range.Min,
                range.Max
            );
            result.Add(
                new EraAttributeModifierEntry
                {
                    AttributeId = attributeId,
                    Value = EraPercentAttributeRules.ToRawEngineValue(attributeId, value),
                }
            );
        }

        return result;
    }

    private static List<EraAttributeModifierEntry> BuildScaledModifierEntries(
        IEnumerable<EraAttributeModifierEntry> source,
        float scale
    )
    {
        if (Math.Abs(scale) <= 0.0001f)
        {
            return new List<EraAttributeModifierEntry>();
        }

        return source
            .Where(entry => entry != null && !string.IsNullOrWhiteSpace(entry.AttributeId))
            .Select(entry => new EraAttributeModifierEntry
            {
                AttributeId = entry.AttributeId,
                Value = entry.Value * scale,
            })
            .Where(entry => Math.Abs(entry.Value) > 0.0001f)
            .ToList();
    }

    private static EraAttributeModifierEntry CloneModifier(EraAttributeModifierEntry entry)
    {
        return new EraAttributeModifierEntry
        {
            AttributeId = entry.AttributeId,
            Value = entry.Value,
        };
    }

    private static ActorTrait? PickRandomTrait(IReadOnlyList<ActorTrait> pool)
    {
        if (pool.Count == 0)
        {
            return null;
        }

        return pool[Randy.randomInt(0, pool.Count)];
    }

    private static void MergeModifiers(IDictionary<string, float> target, IReadOnlyDictionary<string, float> source)
    {
        foreach ((string attributeId, float value) in source)
        {
            if (Math.Abs(value) <= 0.0001f)
            {
                continue;
            }

            target.TryGetValue(attributeId, out float current);
            target[attributeId] = current + value;
        }
    }

    private static void MergeModifiers(IDictionary<string, float> target, IEnumerable<EraAttributeModifierEntry> source)
    {
        foreach (EraAttributeModifierEntry entry in source)
        {
            if (entry == null || string.IsNullOrWhiteSpace(entry.AttributeId) || Math.Abs(entry.Value) <= 0.0001f)
            {
                continue;
            }

            target.TryGetValue(entry.AttributeId, out float current);
            target[entry.AttributeId] = current + entry.Value;
        }
    }

    private static EraTraitInstanceAttributeState? NormalizeTraitState(EraTraitInstanceAttributeState? state)
    {
        if (state == null)
        {
            return null;
        }

        state.GrantedActorName ??= string.Empty;
        state.Source ??= string.Empty;
        state.Attributes ??= new List<EraAttributeModifierEntry>();
        return state;
    }

    private static EraHeroProgressionState? NormalizeHeroProgressionState(EraHeroProgressionState? state)
    {
        if (state == null)
        {
            return null;
        }

        state.Promotion ??= new EraHeroPromotionAttributeState();
        state.Promotion.Attributes ??= new List<EraAttributeModifierEntry>();
        state.Inheritance ??= new EraHeroPromotionAttributeState();
        state.Inheritance.Attributes ??= new List<EraAttributeModifierEntry>();
        return state;
    }

    private static EraEquipmentInstanceAttributeState? NormalizeEquipmentState(EraEquipmentInstanceAttributeState? state)
    {
        if (state == null)
        {
            return null;
        }

        state.GrantedActorName ??= string.Empty;
        state.Source ??= string.Empty;
        state.Attributes ??= new List<EraAttributeModifierEntry>();
        return state;
    }

    private static bool GetCustomBool(Actor actor, EraEntityCustomDataKey key)
    {
        if (actor.getData() is not BaseObjectData data)
        {
            return false;
        }

        data.get(key.Key, out bool value, false);
        return value;
    }

    private static void SetCustomBool(Actor actor, EraEntityCustomDataKey key, bool value)
    {
        if (actor.getData() is BaseObjectData data)
        {
            data.set(key.Key, value);
        }
    }

    private static int GetCustomInt(Actor actor, EraEntityCustomDataKey key)
    {
        if (actor.getData() is not BaseObjectData data)
        {
            return 0;
        }

        data.get(key.Key, out int value, 0);
        return value;
    }

    private static void SetCustomInt(Actor actor, EraEntityCustomDataKey key, int value)
    {
        if (actor.getData() is BaseObjectData data)
        {
            data.set(key.Key, value);
        }
    }

    private static float GetCustomFloat(Actor actor, EraEntityCustomDataKey key)
    {
        if (actor.getData() is not BaseObjectData data)
        {
            return 0f;
        }

        data.get(key.Key, out float value, 0f);
        return value;
    }

    private static void SetCustomFloat(Actor actor, EraEntityCustomDataKey key, float value)
    {
        if (actor.getData() is BaseObjectData data)
        {
            data.set(key.Key, value);
        }
    }

    private static int GetActorKills(Actor actor)
    {
        return actor.getData() is ActorData data ? data.kills : 0;
    }

    private static long GetCustomLong(Actor actor, EraEntityCustomDataKey key)
    {
        if (actor.getData() is not BaseObjectData data)
        {
            return 0L;
        }

        data.get(key.Key, out long value, 0L);
        return value;
    }

    private static void SetCustomLong(Actor actor, EraEntityCustomDataKey key, long value)
    {
        if (actor.getData() is BaseObjectData data)
        {
            data.set(key.Key, value);
        }
    }

    private static string GetActorLabel(Actor actor)
    {
        string name = actor.getName();
        return string.IsNullOrWhiteSpace(name) ? $"Actor#{actor.getID()}" : $"{name}(#{actor.getID()})";
    }

    private static string GetKingdomLabel(Kingdom kingdom)
    {
        string name = kingdom.name;
        return string.IsNullOrWhiteSpace(name) ? $"#{kingdom.id}" : $"{name}(#{kingdom.id})";
    }

    private static string FormatAttributeSummary(IEnumerable<EraAttributeModifierEntry> entries)
    {
        List<string> parts = entries
            .Where(entry => entry != null && !string.IsNullOrWhiteSpace(entry.AttributeId))
            .Select(entry => $"{GetAttributeLabel(entry.AttributeId)} {FormatAttributeValue(entry.AttributeId, entry.Value)}")
            .ToList();
        return parts.Count == 0 ? "无" : string.Join("，", parts);
    }

    private static string GetAttributeLabel(string attributeId)
    {
        return AttributeDisplayNames.TryGetValue(attributeId, out string? label) ? label : attributeId;
    }

    private static string FormatAttributeValue(string attributeId, float value)
    {
        float displayValue = EraPercentAttributeRules.ToDisplayPercent(attributeId, value);
        return EraPercentAttributeRules.IsPercentAttribute(attributeId)
            ? $"{displayValue:+0.##;-0.##;0}%"
            : $"{displayValue:+0.##;-0.##;0}";
    }

    private static float ReadWorldTime()
    {
        return WorldboxReflectionAdapter.TryReadMapStats(out MapStats? mapStats) && mapStats != null
            ? (float)mapStats.world_time
            : 0f;
    }

    private static TState? ReadState<TState>(BaseSystemData? data, string key)
        where TState : class
    {
        if (data == null || string.IsNullOrWhiteSpace(key))
        {
            return null;
        }

        data.get(key, out string json, string.Empty);
        if (string.IsNullOrWhiteSpace(json))
        {
            return null;
        }

        try
        {
            return JsonConvert.DeserializeObject<TState>(json);
        }
        catch
        {
            return null;
        }
    }

    private static void WriteState<TState>(BaseSystemData? data, string key, TState state)
        where TState : class
    {
        if (data == null || string.IsNullOrWhiteSpace(key) || state == null)
        {
            return;
        }

        data.set(key, JsonConvert.SerializeObject(state));
    }

    private static void RemoveString(BaseSystemData? data, string key)
    {
        if (data == null || string.IsNullOrWhiteSpace(key))
        {
            return;
        }

        data.removeString(key);
    }

    private static bool IsDemonFactionKingdom(Kingdom kingdom)
    {
        return kingdom != null &&
               !string.IsNullOrWhiteSpace(kingdom.asset?.id) &&
               kingdom.asset.id.StartsWith("ew_demon_kingdom_", StringComparison.OrdinalIgnoreCase);
    }

    private sealed class EraHeroLineageCandidate
    {
        public EraHeroLineageCandidate(long rootHeroId, int generation)
        {
            RootHeroId = rootHeroId;
            Generation = generation;
        }

        public long RootHeroId { get; }
        public int Generation { get; }
    }
}
