using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HarmonyLib;
using EraWheel.Combat.Effects;
using EraWheel.Combat.Statuses;
using EraWheel.Combat.Terrain;
using EraWheel.Combat.Triggers;
using EraWheel.Core.Logging;
using EraWheel.Core.Constants;
using EraWheel.Core.Random;
using EraWheel.Core.Time;
using EraWheel.Reflection;
using EraWheel.Save.Keys;

namespace EraWheel.Combat.Traits;

public sealed partial class EraTraitRuntimeService
{
    private const string LifestealTraitId = "trait_common_lifesteal";
    private const string OnHitExpTraitId = "trait_common_onhit_exp_10";
    private const string FirebornTraitId = "trait_common_fireborn";
    private const string RevivalTraitId = "trait_common_revival";
    private const string GoldenTouchTraitId = "trait_common_golden_touch";
    private const string WaterbornTraitId = "trait_common_waterborn";
    private const string LightningBodyTraitId = "trait_common_lightning_body";
    private const string ForestbornTraitId = "trait_common_forestborn";
    private const string BerserkerTraitId = "trait_common_berserker";
    private const string DeathCurseTraitId = "trait_common_death_curse";
    private const string SoulReaperTraitId = "trait_common_soul_reaper";
    private const string FastLevelingTraitId = "trait_common_fast_leveling";
    private const string FlightTraitId = "trait_common_flight";
    private const string MartyrTraitId = "trait_common_martyr";
    private const string LeadershipTraitId = "trait_common_leadership";
    private const string UnbrokenWillTraitId = "trait_common_unbroken_will";
    private const string CuteTraitId = "trait_common_cute";
    private const string GiantSlayerTraitId = "trait_common_giant_slayer";
    private const string LuckyTraitId = "trait_common_lucky";
    private const string CowardTraitId = "trait_common_coward";
    private const string GamblerTraitId = "trait_common_gambler";
    private const string SharedFateTraitId = "trait_common_shared_fate";
    private const string BloodlineTraitId = "trait_common_bloodline";
    private const string LightningBlessingTraitId = "trait_common_lightning_blessing";
    private const string MasterTraitId = "trait_common_master";

    private const string FrostImpactTraitId = "trait_herit_t1_frost_impact";
    private const string SacredHealTraitId = "trait_herit_t1_sacred_heal";
    private const string WindBladeTraitId = "trait_herit_t1_wind_blade";
    private const string SwordArrayTraitId = "trait_herit_t2_sword_array";
    private const string PolymorphSheepTraitId = "trait_herit_t2_polymorph_sheep";
    private const string RockArmorTraitId = "trait_herit_t2_rock_armor";
    private const string MirrorCloneTraitId = "trait_herit_t3_mirror_clone";
    private const string SkyThunderTraitId = "trait_herit_t3_sky_thunder";
    private const string SandstormTraitId = "trait_herit_t3_sandstorm";

    private const string SoulReaperBuffKey = "ew_trait_soul_reaper_growth";
    private const string FirebornRegenTimerKey = "ew_trait_fireborn_regen";
    private const string WaterbornRegenTimerKey = "ew_trait_waterborn_regen";
    private const string ForestbornRegenTimerKey = "ew_trait_forestborn_regen";
    private const string BerserkerBuffKey = "ew_trait_berserker_buff";
    private const string WaterbornBuffKey = "ew_trait_waterborn_speed";
    private const string ForestbornBuffKey = "ew_trait_forestborn_speed";
    private const string LeadershipBuffKey = "ew_trait_leadership_armor";
    private const string CowardBuffKey = "ew_trait_coward_speed";
    private const string LightningBlessingBuffKey = "ew_trait_lightning_blessing";
    private const string MasterBuffKey = "ew_trait_master";
    private const string LightningBodyBuffKey = "ew_trait_lightning_body_speed";
    private const string RockArmorShieldKey = "ew_trait_rock_armor_shield";
    private const string SandstormAreaKeyPrefix = "ew_trait_sandstorm:";

    private static readonly MethodInfo? AddExperienceMethod = AccessTools.Method(
        typeof(Actor),
        "addExperience",
        new[] { typeof(int) }
    );

    private static readonly AttackAction OnHitExperienceAction = GrantOnHitExperience;
    private static readonly WorldAction FastLevelingSpecialEffectAction = GrantFastLevelingExperience;
    private static readonly WorldAction FlightSpecialEffectAction = ApplyFlightSpecialEffect;
    private static readonly WorldActionTrait FlightAddedAction = ApplyFlightTrait;
    private static readonly WorldActionTrait FlightLoadedAction = ApplyFlightTrait;
    private static readonly GetHitAction UnbrokenWillGetHitAction = TriggerUnbrokenWillGetHit;
    private static readonly GetHitAction SharedFateGetHitAction = TriggerSharedFateGetHit;

    private static readonly FieldInfo? AttackedByField = AccessTools.Field(typeof(Actor), "attackedBy");

    private static readonly string[] GoldenTouchDropIds =
    {
        "stone",
        "silver",
        "adamantine",
        "metals",
        "mythril",
        "gold",
    };

    private static readonly HashSet<string> GoldenTouchMissingDropWarnings = new(StringComparer.Ordinal);

    private readonly EraStableRandomService _stableRandom;
    private readonly EraTriggerService _triggers;
    private readonly EraEffectService _effects;
    private readonly EraStatusRuntimeService _statuses;
    private readonly EraTerrainAreaService _terrain;
    private readonly Dictionary<string, float> _cooldowns = new();
    private readonly Dictionary<string, float> _timers = new();
    private readonly Dictionary<long, float> _mirrorCloneExpiry = new();
    private readonly HashSet<long> _rockArmorWatchers = new();

    public EraTraitRuntimeService(
        EraStableRandomService stableRandom,
        EraTriggerService triggers,
        EraEffectService effects,
        EraStatusRuntimeService statuses,
        EraTerrainAreaService terrain
    )
    {
        _stableRandom = stableRandom;
        _triggers = triggers;
        _effects = effects;
        _statuses = statuses;
        _terrain = terrain;

        RegisterPublicTraitTriggers();
        RegisterHeritageTraitTriggers();
    }

    public void Update(float currentWorldTime)
    {
        List<long> expiredClones = new List<long>();
        foreach ((long actorId, float expiresAt) in _mirrorCloneExpiry)
        {
            if (expiresAt > currentWorldTime)
            {
                continue;
            }

            Actor? clone = ResolveActor(actorId);
            if (clone != null && clone.isAlive())
            {
                clone.dieAndDestroy(AttackType.None);
            }

            expiredClones.Add(actorId);
        }

        foreach (long actorId in expiredClones)
        {
            _mirrorCloneExpiry.Remove(actorId);
        }
    }

    public string CreateStatusReport()
    {
        return $"技能冷却={_cooldowns.Count}；周期计时器={_timers.Count}；镜像分身={_mirrorCloneExpiry.Count}；岩甲监听={_rockArmorWatchers.Count}";
    }

    public bool TryPrepareAttack(Actor actor, BaseSimObject? target, out float originalDamage)
    {
        originalDamage = 0f;
        if (actor == null || target == null)
        {
            return false;
        }

        float damageMultiplier = 1f;
        if (actor.hasTrait(GamblerTraitId))
        {
            damageMultiplier *= RollBetween(actor, target, "gambler", 0.01f, 5f);
        }

        if (actor.hasTrait(GiantSlayerTraitId) && target is Actor targetActor && IsLargerThan(targetActor, actor))
        {
            damageMultiplier *= 2f;
        }

        if (damageMultiplier <= 1.0001f)
        {
            return false;
        }

        originalDamage = EraWorldboxStatsAccessor.GetStat(actor, EraAttributeIds.Damage);
        EraWorldboxStatsAccessor.SetStat(actor, EraAttributeIds.Damage, Math.Max(1f, originalDamage * damageMultiplier));
        return true;
    }

    public void RestorePreparedAttack(Actor actor, bool modified, float originalDamage)
    {
        if (!modified || actor == null)
        {
            return;
        }

        EraWorldboxStatsAccessor.SetStat(actor, EraAttributeIds.Damage, originalDamage);
    }

    public bool TryHandleIncomingHit(Actor actor, ref float damage, AttackType attackType, BaseSimObject? attacker)
    {
        if (actor == null || damage <= 0f)
        {
            return false;
        }

        if (actor.hasTrait(LuckyTraitId) && RollChance(actor, attacker, "lucky", 10f))
        {
            if (attacker is Actor attackerActor)
            {
                actor.addAggro(attackerActor);
            }

            damage = 0f;
            return true;
        }

        if (actor.hasTrait(LightningBodyTraitId) && attackType == AttackType.Divine)
        {
            if (attacker is Actor attackerActor)
            {
                actor.addAggro(attackerActor);
            }

            int healing = Math.Max(1, actor.getHealth() / 2);
            actor.restoreHealth(healing);
            ApplyTimedBuff(
                actor,
                LightningBodyBuffKey,
                EraWorldTime.MonthToWorldTime(2f),
                new Dictionary<string, float>
                {
                    [EraAttributeIds.MultiplierSpeed] = 100f,
                }
            );
            damage = 0f;
            return true;
        }

        if (actor.hasTrait(FirebornTraitId) &&
            attackType == AttackType.Fire &&
            actor.current_tile != null &&
            (actor.current_tile.Type.lava || actor.current_tile.isOnFire()))
        {
            damage = 0f;
            return true;
        }

        return false;
    }

    public bool TryHandleDeath(Actor actor)
    {
        if (actor == null || actor.hasHealth() || !actor.isAlive())
        {
            return false;
        }

        if (actor.hasTrait(RevivalTraitId) && !GetCustomBool(actor, EraEntityCustomDataKeys.TraitRevivalUsed))
        {
            SetCustomBool(actor, EraEntityCustomDataKeys.TraitRevivalUsed, true);
            actor.changeHealth(actor.getMaxHealthPercent(0.3f));
            return true;
        }

        Actor? attacker = ResolveLastAttacker(actor);

        if (actor.hasTrait(MartyrTraitId) && actor.current_tile != null)
        {
            foreach (Actor ally in _effects.FindActors(actor.current_tile, 6f, actor, EraEffectTargetRule.Friends))
            {
                ally.restoreHealth(Math.Max(1, ally.getMaxHealthPercent(0.1f)));
                _statuses.ApplyShield(
                    ally,
                    Math.Max(1f, ally.getMaxHealth() * 0.1f),
                    EraWorldTime.YearsToWorldTime(1f),
                    runtimeKey: $"ew_trait_martyr_shield:{ally.getID()}"
                );
            }
        }

        if (actor.hasTrait(DeathCurseTraitId) && attacker != null)
        {
            float lifespan = EraWorldboxStatsAccessor.GetStat(attacker, EraAttributeIds.Lifespan);
            float remaining = Math.Max(0f, lifespan - attacker.getAge());
            if (remaining > 0.01f)
            {
                EraWorldboxStatsAccessor.SetStat(attacker, EraAttributeIds.Lifespan, attacker.getAge() + (remaining * 0.7f));
            }
        }

        if (attacker != null)
        {
            if (attacker.hasTrait(SoulReaperTraitId))
            {
                int nextStacks = GetCustomInt(attacker, EraEntityCustomDataKeys.TraitSoulReaperStacks) + 1;
                SetCustomInt(attacker, EraEntityCustomDataKeys.TraitSoulReaperStacks, nextStacks);
                ApplySoulReaperGrowth(attacker, nextStacks);
            }

            if (attacker.hasTrait(GoldenTouchTraitId) && actor.current_tile != null)
            {
                string resourceId = PickOne(
                    attacker,
                    actor,
                    "golden_touch",
                    GoldenTouchDropIds
                );
                if (!AssetManager.drops.has(resourceId))
                {
                    if (GoldenTouchMissingDropWarnings.Add(resourceId))
                    {
                        EraLog.Warning(
                            EraLogCategory.Combat,
                            $"黄金之触掉落已跳过：未找到掉落 ID={resourceId}。"
                        );
                    }
                }
                else
                {
                    World.world?.drop_manager.spawn(actor.current_tile, resourceId, 15f, -1f, -1L);
                }
            }
        }

        return false;
    }

    public bool ShouldSkipTarget(Actor source, BaseSimObject? target)
    {
        if (source == null || target is not Actor targetActor || !targetActor.hasTrait(CuteTraitId))
        {
            return false;
        }

        if (!source.areFoes(targetActor))
        {
            return false;
        }

        return RollChance(source, targetActor, "cute", 50f);
    }

    public void HandleBabyBorn(Actor baby, Actor parent1, Actor? parent2)
    {
        if (baby == null || parent1 == null)
        {
            return;
        }

        InheritBloodlineTraits(parent1, baby);
        if (parent2 != null)
        {
            InheritBloodlineTraits(parent2, baby);
        }
    }

    private void RegisterPublicTraitTriggers()
    {
        RegisterOnHitExperienceAction();
        RegisterFastLevelingSpecialEffect();
        RegisterFlightActions();
        RegisterGetHitAction(UnbrokenWillTraitId, UnbrokenWillGetHitAction, "不屈意志");
        RegisterGetHitAction(SharedFateTraitId, SharedFateGetHitAction, "命运共同体");

        _triggers.RegisterTraitTrigger(
            "trait_common_lifesteal#on_hit",
            LifestealTraitId,
            EraTriggerType.OnHit,
            EraTriggerSubject.Source,
            LifestealTraitId,
            (context, actor) =>
            {
                int healing = Math.Max(1, (int)MathF.Round(Math.Max(0f, context.Damage) * 0.1f));
                actor.restoreHealth(healing);
            }
        );

        _triggers.Register(
            new EraTriggerDefinition(
                "trait_common_public_tick_runtime",
                "public_trait_tick_runtime",
                EraTriggerType.OnTick,
                context =>
                {
                    Actor? actor = context.SourceActor;
                    if (actor == null || actor.current_tile == null)
                    {
                        return;
                    }

                    RefreshPublicTraitAuras(context, actor);
                    RefreshTerrainAdaptations(context, actor);
                    RefreshPermanentGrowth(context, actor);
                    CheckRockArmorBreak(context, actor);
                },
                chancePercent: 100f
            )
        );
    }

    private static void RegisterOnHitExperienceAction()
    {
        ActorTrait? trait = AssetManager.traits.get(OnHitExpTraitId);
        if (trait == null)
        {
            EraLog.Warning(
                EraLogCategory.Combat,
                $"战斗悟性原版命中回调未注册：未找到特质 ID={OnHitExpTraitId}。"
            );
            return;
        }

        AttackAction? withoutExisting = (AttackAction?)Delegate.Remove(
            trait.action_attack_target,
            OnHitExperienceAction
        );
        trait.action_attack_target = (AttackAction)Delegate.Combine(withoutExisting, OnHitExperienceAction);
        MarkActorsWithTraitStatsDirty(OnHitExpTraitId);
    }

    private static void RegisterFastLevelingSpecialEffect()
    {
        ActorTrait? trait = AssetManager.traits.get(FastLevelingTraitId);
        if (trait == null)
        {
            EraLog.Warning(
                EraLogCategory.Combat,
                $"快速升级原版周期回调未注册：未找到特质 ID={FastLevelingTraitId}。"
            );
            return;
        }

        WorldAction? withoutExisting = (WorldAction?)Delegate.Remove(
            trait.action_special_effect,
            FastLevelingSpecialEffectAction
        );
        trait.action_special_effect = (WorldAction)Delegate.Combine(withoutExisting, FastLevelingSpecialEffectAction);
        trait.special_effect_interval = EraWorldTime.YearsToWorldTime(1f);
        MarkActorsWithTraitStatsDirty(FastLevelingTraitId);
    }

    private static void RegisterFlightActions()
    {
        ActorTrait? trait = AssetManager.traits.get(FlightTraitId);
        if (trait == null)
        {
            EraLog.Warning(
                EraLogCategory.Combat,
                $"飞翔原版飞行回调未注册：未找到特质 ID={FlightTraitId}。"
            );
            return;
        }

        WorldAction? withoutSpecialEffect = (WorldAction?)Delegate.Remove(
            trait.action_special_effect,
            FlightSpecialEffectAction
        );
        WorldActionTrait? withoutAdded = (WorldActionTrait?)Delegate.Remove(
            trait.action_on_augmentation_add,
            FlightAddedAction
        );
        WorldActionTrait? withoutLoaded = (WorldActionTrait?)Delegate.Remove(
            trait.action_on_augmentation_load,
            FlightLoadedAction
        );

        trait.action_special_effect = (WorldAction)Delegate.Combine(withoutSpecialEffect, FlightSpecialEffectAction);
        trait.action_on_augmentation_add = (WorldActionTrait)Delegate.Combine(withoutAdded, FlightAddedAction);
        trait.action_on_augmentation_load = (WorldActionTrait)Delegate.Combine(withoutLoaded, FlightLoadedAction);
        trait.special_effect_interval = 1f;

        MarkActorsWithTraitStatsDirty(FlightTraitId);
        ApplyFlightToExistingActors();
    }

    private static void RegisterGetHitAction(string traitId, GetHitAction action, string displayName)
    {
        ActorTrait? trait = AssetManager.traits.get(traitId);
        if (trait == null)
        {
            EraLog.Warning(
                EraLogCategory.Combat,
                $"{displayName}原版受击回调未注册：未找到特质 ID={traitId}。"
            );
            return;
        }

        GetHitAction? withoutExisting = (GetHitAction?)Delegate.Remove(
            trait.action_get_hit,
            action
        );
        trait.action_get_hit = (GetHitAction)Delegate.Combine(withoutExisting, action);
        MarkActorsWithTraitStatsDirty(traitId);
    }

    private static void MarkActorsWithTraitStatsDirty(string traitId)
    {
        if (World.world?.units == null)
        {
            return;
        }

        foreach (Actor actor in World.world.units)
        {
            if (actor != null && actor.hasTrait(traitId))
            {
                actor.setStatsDirty();
            }
        }
    }

    private void RegisterHeritageTraitTriggers()
    {
        RegisterActiveTraitSkill(
            FrostImpactTraitId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 16f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 16f);
                if (target?.current_tile == null)
                {
                    return;
                }

                _effects.ApplyAreaDamage(context, target.current_tile, 2.5f, damageMultiplier: 1.5f);
            }
        );

        RegisterActiveTraitSkill(
            SacredHealTraitId,
            chancePercent: 30f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                foreach (Actor ally in _effects.FindActors(actor.current_tile!, 6f, actor, EraEffectTargetRule.Friends))
                {
                    if (ally.current_tile != null)
                    {
                        ActionLibrary.castCure(actor, ally, ally.current_tile);
                    }

                    ally.restoreHealth(Math.Max(1, ally.getHealth() / 5));
                }

                if (actor.current_tile != null)
                {
                    ActionLibrary.castCure(actor, actor, actor.current_tile);
                }

                actor.restoreHealth(Math.Max(1, actor.getHealth() / 5));
            }
        );

        RegisterActiveTraitSkill(
            WindBladeTraitId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 16f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 16f);
                if (target?.current_tile == null || actor.current_tile == null)
                {
                    return;
                }

                foreach (Actor foe in FindActorsOnLine(actor, target.current_tile, 6f, 1.2f))
                {
                    _effects.ApplyDamage(context, foe, damageMultiplier: 1.2f);
                }
            }
        );

        RegisterActiveTraitSkill(
            SwordArrayTraitId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 16f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 16f);
                if (target?.current_tile == null)
                {
                    return;
                }

                List<Actor> foes = _effects.FindActors(target.current_tile, 4f, actor, EraEffectTargetRule.Foes)
                    .OrderBy(candidate => DistanceSquared(candidate.current_tile, target.current_tile))
                    .Take(3)
                    .ToList();

                foreach (Actor foe in foes)
                {
                    _effects.ApplyDamage(context, foe, damageMultiplier: 0.8f);
                }
            }
        );

        RegisterActiveTraitSkill(
            PolymorphSheepTraitId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 16f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 16f);
                if (target == null)
                {
                    return;
                }

                _statuses.ApplySilence(target, 5f, runtimeKey: "ew_trait_polymorph_silence");
                ApplyTimedDebuff(
                    target,
                    "ew_trait_polymorph_debuff",
                    5f,
                    new Dictionary<string, float>
                    {
                        [EraAttributeIds.MultiplierDamage] = -20f,
                    }
                );
            }
        );

        RegisterActiveTraitSkill(
            RockArmorTraitId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                ActionLibrary.castShieldOnHimself(actor, actor, actor.current_tile);
                _statuses.ApplyShield(
                    actor,
                    Math.Max(1f, actor.getMaxHealth() * 0.3f),
                    EraWorldTime.YearsToWorldTime(1f),
                    runtimeKey: RockArmorShieldKey
                );
                _rockArmorWatchers.Add(actor.getID());
            }
        );

        RegisterActiveTraitSkill(
            MirrorCloneTraitId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null || actor.asset == null)
                {
                    return;
                }

                IReadOnlyList<Actor> clones = _effects.SummonUnits(
                    context,
                    actor.asset.id,
                    actor.current_tile,
                    count: 1,
                    joinSourceKingdom: true
                );

                foreach (Actor clone in clones)
                {
                    _mirrorCloneExpiry[clone.getID()] = context.WorldTime + 20f;
                    ApplyTimedBuff(
                        clone,
                        $"ew_trait_mirror_clone:{clone.getID()}",
                        20f,
                        new Dictionary<string, float>
                        {
                            [EraAttributeIds.MultiplierHealth] = -50f,
                            [EraAttributeIds.MultiplierDamage] = -50f,
                        }
                    );
                    _statuses.ApplySilence(clone, 20f, runtimeKey: $"ew_trait_mirror_clone_silence:{clone.getID()}");
                }
            }
        );

        RegisterActiveTraitSkill(
            SkyThunderTraitId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 18f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 18f);
                if (target?.current_tile == null)
                {
                    return;
                }

                ActionLibrary.castLightning(actor, target, target.current_tile);
                _effects.ApplyDamage(context, target, damageMultiplier: 2f);
            }
        );

        RegisterActiveTraitSkill(
            SandstormTraitId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 18f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 18f);
                if (target?.current_tile == null)
                {
                    return;
                }

                string areaKey = $"{SandstormAreaKeyPrefix}{actor.getID()}";
                _terrain.UpsertPeriodicArea(
                    areaKey,
                    actor,
                    anchorActor: null,
                    centerTile: target.current_tile,
                    radius: 6f,
                    durationWorldTime: 10f,
                    tickIntervalWorldTime: 2f,
                    targetRule: EraEffectTargetRule.Foes,
                    onActorTick: (tickContext, victim) =>
                    {
                        float accuracyPenalty = RollBetween(actor, victim, "sandstorm_accuracy", 15f, 30f);
                        _effects.ApplyDamage(
                            tickContext,
                            victim,
                            flatDamage: Math.Max(1, (int)MathF.Round(victim.getHealth() * 0.01f))
                        );
                        ApplyTimedDebuff(
                            victim,
                            $"ew_trait_sandstorm_accuracy:{victim.getID()}",
                            2.5f,
                            new Dictionary<string, float>
                            {
                                [EraAttributeIds.Accuracy] = -accuracyPenalty,
                            }
                        );
                    }
                );
            }
        );

        RegisterHeritageTier4To6Triggers();
        RegisterHeritageTier7To8Triggers();
        RegisterHeritageTier9To10Triggers();
    }

    partial void RegisterHeritageTier4To6Triggers();

    partial void RegisterHeritageTier7To8Triggers();

    partial void RegisterHeritageTier9To10Triggers();

    private void RefreshPublicTraitAuras(EraTriggerContext context, Actor actor)
    {
        if (actor.hasTrait(BerserkerTraitId))
        {
            int maxHealth = Math.Max(1, actor.getMaxHealth());
            int missingPercent = Math.Clamp((int)MathF.Round((1f - (actor.getHealth() / (float)maxHealth)) * 100f), 0, 100);
            ApplyTimedBuff(
                actor,
                BerserkerBuffKey,
                2f,
                new Dictionary<string, float>
                {
                    [EraAttributeIds.MultiplierDamage] = missingPercent * 2f,
                }
            );
        }

        if (actor.hasTrait(LeadershipTraitId) && actor.current_tile != null)
        {
            int allyCount = _effects.FindActors(actor.current_tile, 6f, actor, EraEffectTargetRule.Friends)
                .Count(candidate => candidate.getID() != actor.getID());
            ApplyTimedBuff(
                actor,
                LeadershipBuffKey,
                2f,
                new Dictionary<string, float>
                {
                    [EraAttributeIds.Armor] = allyCount,
                }
            );
        }

        if (actor.hasTrait(CowardTraitId) && actor.getHealth() > 0 && actor.getMaxHealth() > 0)
        {
            float speedBonus = actor.getHealth() <= actor.getMaxHealthPercent(0.5f) ? 200f : 0f;
            ApplyTimedBuff(
                actor,
                CowardBuffKey,
                2f,
                new Dictionary<string, float>
                {
                    [EraAttributeIds.MultiplierSpeed] = speedBonus,
                }
            );
        }

        if (actor.hasTrait(LightningBlessingTraitId))
        {
            ApplyTimedBuff(
                actor,
                LightningBlessingBuffKey,
                2f,
                new Dictionary<string, float>
                {
                    [EraAttributeIds.MultiplierSpeed] = 100f,
                    [EraAttributeIds.MultiplierAttackSpeed] = 100f,
                }
            );
        }

        if (actor.hasTrait(MasterTraitId))
        {
            ApplyTimedBuff(
                actor,
                MasterBuffKey,
                2f,
                new Dictionary<string, float>
                {
                    [EraAttributeIds.SkillCombat] = 15f,
                    [EraAttributeIds.SkillSpell] = 15f,
                    [EraAttributeIds.Intelligence] = 5f,
                    [EraAttributeIds.Warfare] = 5f,
                    [EraAttributeIds.Stewardship] = 5f,
                }
            );
        }
    }

    private void RefreshTerrainAdaptations(EraTriggerContext context, Actor actor)
    {
        WorldTile? tile = actor.current_tile;
        if (tile == null)
        {
            return;
        }

        if (actor.hasTrait(FirebornTraitId))
        {
            if ((tile.Type.lava || tile.isOnFire()) && CanRunTimer(BuildActorTimerKey(actor, FirebornRegenTimerKey), context.WorldTime, 10f))
            {
                actor.restoreHealth(Math.Max(1, (int)MathF.Round(actor.getHealth() * 0.01f)));
                RestoreManaPercent(actor, 0.01f);
            }
        }

        if (actor.hasTrait(WaterbornTraitId))
        {
            if (tile.Type.liquid)
            {
                ApplyTimedBuff(
                    actor,
                    WaterbornBuffKey,
                    2f,
                    new Dictionary<string, float>
                    {
                        [EraAttributeIds.MultiplierSpeed] = 50f,
                    }
                );
            }

            if (tile.Type.liquid && CanRunTimer(BuildActorTimerKey(actor, WaterbornRegenTimerKey), context.WorldTime, 10f))
            {
                actor.restoreHealth(Math.Max(1, (int)MathF.Round(actor.getHealth() * 0.01f)));
                RestoreManaPercent(actor, 0.01f);
            }
        }

        if (actor.hasTrait(ForestbornTraitId))
        {
            if (IsForestTile(tile))
            {
                ApplyTimedBuff(
                    actor,
                    ForestbornBuffKey,
                    2f,
                    new Dictionary<string, float>
                    {
                        [EraAttributeIds.MultiplierSpeed] = 50f,
                    }
                );
            }

            if (IsForestTile(tile) && CanRunTimer(BuildActorTimerKey(actor, ForestbornRegenTimerKey), context.WorldTime, 10f))
            {
                actor.restoreHealth(Math.Max(1, (int)MathF.Round(actor.getHealth() * 0.01f)));
                RestoreManaPercent(actor, 0.01f);
            }
        }
    }

    private void RefreshPermanentGrowth(EraTriggerContext _, Actor actor)
    {
        if (!actor.hasTrait(SoulReaperTraitId))
        {
            return;
        }

        int stacks = GetCustomInt(actor, EraEntityCustomDataKeys.TraitSoulReaperStacks);
        if (stacks > 0)
        {
            ApplySoulReaperGrowth(actor, stacks);
        }
    }

    private void CheckRockArmorBreak(EraTriggerContext context, Actor actor)
    {
        if (!_rockArmorWatchers.Contains(actor.getID()))
        {
            return;
        }

        if (_statuses.TryGetStatus(actor, RockArmorShieldKey, out _))
        {
            return;
        }

        _rockArmorWatchers.Remove(actor.getID());
        if (actor.current_tile == null)
        {
            return;
        }

        _effects.ApplyAreaDamage(
            context.ToEffectContext(),
            actor.current_tile,
            radius: 5f,
            damageMultiplier: 1f,
            targetRule: EraEffectTargetRule.Foes
        );
    }

    private void RegisterActiveTraitSkill(
        string traitId,
        float chancePercent,
        float cooldownWorldTime,
        int manaCost,
        Action<EraEffectContext, Actor> handler,
        float targetSearchRadius = 0f
    )
    {
        _triggers.RegisterTraitTrigger(
            $"{traitId}#active_skill",
            traitId,
            EraTriggerType.Active,
            EraTriggerSubject.Source,
            traitId,
            (context, actor) =>
            {
                if (!CanCastTraitSkill(actor, traitId, context.WorldTime, cooldownWorldTime, manaCost, targetSearchRadius))
                {
                    return;
                }

                if (manaCost > 0)
                {
                    WorldboxReflectionAdapter.TryConsumeActorMana(actor, manaCost);
                }

                handler(context.ToEffectContext(), actor);
                _cooldowns[BuildCooldownKey(actor, traitId)] = context.WorldTime + cooldownWorldTime;
            },
            chancePercent: chancePercent,
            condition: context =>
            {
                Actor? actor = context.SourceActor;
                return actor != null && CanCastTraitSkill(actor, traitId, context.WorldTime, cooldownWorldTime, manaCost, targetSearchRadius);
            }
        );
    }

    private bool CanCastTraitSkill(
        Actor actor,
        string traitId,
        float worldTime,
        float cooldownWorldTime,
        int manaCost,
        float targetSearchRadius
    )
    {
        if (actor.current_tile == null || !actor.isAlive())
        {
            return false;
        }

        if (_cooldowns.TryGetValue(BuildCooldownKey(actor, traitId), out float nextAllowedWorldTime) &&
            nextAllowedWorldTime > worldTime)
        {
            return false;
        }

        if (targetSearchRadius > 0f && ResolveEnemyTarget(actor, targetSearchRadius) == null)
        {
            return false;
        }

        return manaCost <= 0
               || !WorldboxReflectionAdapter.CanAccessActorMana
               || (WorldboxReflectionAdapter.TryGetActorMana(actor, out int mana) && mana >= manaCost);
    }

    private void InheritBloodlineTraits(Actor parent, Actor child)
    {
        if (parent == null || child == null || !parent.hasTrait(BloodlineTraitId))
        {
            return;
        }

        foreach (ActorTrait trait in parent.getTraits())
        {
            if (trait == null || string.IsNullOrWhiteSpace(trait.id) || trait.id == BloodlineTraitId)
            {
                continue;
            }

            if (child.hasTrait(trait.id))
            {
                continue;
            }

            child.addTrait(trait.id);
        }
    }

    private void ApplySoulReaperGrowth(Actor actor, int stacks)
    {
        ApplyTimedBuff(
            actor,
            SoulReaperBuffKey,
            EraWorldTime.YearsToWorldTime(1000f),
            new Dictionary<string, float>
            {
                [EraAttributeIds.MultiplierHealth] = stacks,
            }
        );
    }

    private static bool IsForestTile(WorldTile tile)
    {
        string biomeId = tile.getBiome()?.id ?? string.Empty;
        return biomeId is "biome_jungle" or "biome_birch" or "biome_maple";
    }

    private Actor? ResolveEnemyTarget(Actor actor, float maxDistance)
    {
        if (WorldboxReflectionAdapter.TryGetAttackTarget(actor, out BaseSimObject? target) &&
            target is Actor targetActor &&
            targetActor.isAlive() &&
            targetActor.current_tile != null &&
            actor.areFoes(targetActor))
        {
            return targetActor;
        }

        if (actor.current_tile == null)
        {
            return null;
        }

        float maxDistanceSquared = maxDistance * maxDistance;
        Actor? best = null;
        float bestDistance = float.MaxValue;
        foreach (Actor other in EnumerateActors())
        {
            if (other == null || !other.isAlive() || other.current_tile == null || !actor.areFoes(other))
            {
                continue;
            }

            float distanceSquared = DistanceSquared(actor.current_tile, other.current_tile);
            if (distanceSquared > maxDistanceSquared || distanceSquared >= bestDistance)
            {
                continue;
            }

            bestDistance = distanceSquared;
            best = other;
        }

        return best;
    }

    private IEnumerable<Actor> FindActorsOnLine(Actor source, WorldTile targetTile, float length, float thickness)
    {
        if (source.current_tile == null)
        {
            return Array.Empty<Actor>();
        }

        float startX = source.current_tile.x;
        float startY = source.current_tile.y;
        float endX = targetTile.x;
        float endY = targetTile.y;
        float dx = endX - startX;
        float dy = endY - startY;
        float totalLength = MathF.Sqrt((dx * dx) + (dy * dy));
        if (totalLength <= 0.001f)
        {
            return Array.Empty<Actor>();
        }

        float normalizedX = dx / totalLength;
        float normalizedY = dy / totalLength;
        List<Actor> result = new List<Actor>();
        foreach (Actor actor in EnumerateActors())
        {
            if (actor == null || actor.current_tile == null || !actor.isAlive() || !source.areFoes(actor))
            {
                continue;
            }

            float relativeX = actor.current_tile.x - startX;
            float relativeY = actor.current_tile.y - startY;
            float projected = (relativeX * normalizedX) + (relativeY * normalizedY);
            if (projected < 0f || projected > length)
            {
                continue;
            }

            float perpendicular = MathF.Abs((relativeX * normalizedY) - (relativeY * normalizedX));
            if (perpendicular <= thickness)
            {
                result.Add(actor);
            }
        }

        return result;
    }

    private float RollBetween(BaseSimObject source, BaseSimObject? target, string scopeSuffix, float min, float max)
    {
        long sourceId = source.getID();
        long targetId = target?.getID() ?? 0L;
        string scope = $"{scopeSuffix}:{sourceId}:{targetId}:{(int)ReadWorldTime()}";
        return _stableRandom.NextFloat("trait_runtime_roll", scope, min, max);
    }

    private bool RollChance(BaseSimObject source, BaseSimObject? target, string scopeSuffix, float chancePercent)
    {
        if (chancePercent >= 100f)
        {
            return true;
        }

        if (chancePercent <= 0f)
        {
            return false;
        }

        long sourceId = source.getID();
        long targetId = target?.getID() ?? 0L;
        string scope = $"{scopeSuffix}:{sourceId}:{targetId}:{(int)ReadWorldTime()}";
        return _stableRandom.NextFloat("trait_runtime_chance", scope, 0f, 100f) <= chancePercent;
    }

    private string PickOne(BaseSimObject source, BaseSimObject? target, string scopeSuffix, IReadOnlyList<string> values)
    {
        if (values.Count == 0)
        {
            return string.Empty;
        }

        long sourceId = source.getID();
        long targetId = target?.getID() ?? 0L;
        string scope = $"{scopeSuffix}:{sourceId}:{targetId}:{(int)ReadWorldTime()}";
        int index = _stableRandom.NextInt("trait_runtime_pick", scope, 0, values.Count);
        index = Math.Clamp(index, 0, values.Count - 1);
        return values[index];
    }

    private static bool IsLargerThan(Actor left, Actor right)
    {
        float leftSize = EraWorldboxStatsAccessor.GetStat(left, EraAttributeIds.Size);
        float rightSize = EraWorldboxStatsAccessor.GetStat(right, EraAttributeIds.Size);
        if (leftSize > rightSize)
        {
            return true;
        }

        return EraWorldboxStatsAccessor.GetStat(left, EraAttributeIds.Scale)
               > EraWorldboxStatsAccessor.GetStat(right, EraAttributeIds.Scale);
    }

    private static float DistanceSquared(WorldTile? left, WorldTile? right)
    {
        if (left == null || right == null)
        {
            return float.MaxValue;
        }

        float dx = left.x - right.x;
        float dy = left.y - right.y;
        return (dx * dx) + (dy * dy);
    }

    private bool CanRunTimer(string timerKey, float worldTime, float intervalWorldTime)
    {
        if (_timers.TryGetValue(timerKey, out float nextWorldTime) && nextWorldTime > worldTime)
        {
            return false;
        }

        _timers[timerKey] = worldTime + intervalWorldTime;
        return true;
    }

    private static string BuildCooldownKey(Actor actor, string traitId)
    {
        return $"{actor.getID()}:{traitId}";
    }

    private static string BuildActorTimerKey(Actor actor, string timerName)
    {
        return $"{actor.getID()}:{timerName}";
    }

    private void ApplyTimedBuff(
        BaseSimObject target,
        string runtimeKey,
        float durationWorldTime,
        IReadOnlyDictionary<string, float> modifiers
    )
    {
        _statuses.ApplyNow(
            target,
            new EraStatusApplication(
                EraStatusKind.TimedBuff,
                durationWorldTime,
                EraStatusStackMode.Replace,
                runtimeKey: runtimeKey,
                statModifiers: modifiers
            )
        );
    }

    private void ApplyTimedDebuff(
        BaseSimObject target,
        string runtimeKey,
        float durationWorldTime,
        IReadOnlyDictionary<string, float> modifiers
    )
    {
        _statuses.ApplyNow(
            target,
            new EraStatusApplication(
                EraStatusKind.TimedDebuff,
                durationWorldTime,
                EraStatusStackMode.Replace,
                runtimeKey: runtimeKey,
                statModifiers: modifiers
            )
        );
    }

    private static Actor? ResolveActor(long actorId)
    {
        if (actorId <= 0L || World.world?.units == null)
        {
            return null;
        }

        foreach (Actor actor in World.world.units)
        {
            if (actor != null && actor.getID() == actorId)
            {
                return actor;
            }
        }

        return null;
    }

    private static Actor? ResolveLastAttacker(Actor actor)
    {
        BaseSimObject? attackedBy = AttackedByField?.GetValue(actor) as BaseSimObject;
        return attackedBy is Actor attacker && attacker.isAlive() ? attacker : null;
    }

    private static IEnumerable<Actor> EnumerateActors()
    {
        if (World.world?.units == null)
        {
            return Array.Empty<Actor>();
        }

        List<Actor> result = new List<Actor>();
        foreach (Actor actor in World.world.units)
        {
            if (actor != null)
            {
                result.Add(actor);
            }
        }

        return result;
    }

    private static float ReadWorldTime()
    {
        return WorldboxReflectionAdapter.TryReadMapStats(out MapStats? mapStats) && mapStats != null
            ? (float)mapStats.world_time
            : 0f;
    }

    private static void AddExperience(Actor actor, int amount)
    {
        if (amount <= 0 || AddExperienceMethod == null)
        {
            return;
        }

        AddExperienceMethod.Invoke(actor, new object[] { amount });
    }

    private static bool GrantOnHitExperience(BaseSimObject self, BaseSimObject target, WorldTile tile)
    {
        if (self is Actor actor)
        {
            AddExperience(actor, 10);
        }

        return false;
    }

    private static bool GrantFastLevelingExperience(BaseSimObject self, WorldTile tile)
    {
        if (self is Actor actor)
        {
            AddExperience(actor, 10);
        }

        return false;
    }

    private static bool ApplyFlightSpecialEffect(BaseSimObject self, WorldTile tile)
    {
        if (self is Actor actor)
        {
            ApplyFlight(actor);
        }

        return false;
    }

    private static bool ApplyFlightTrait(NanoObject target, BaseAugmentationAsset trait)
    {
        if (target is Actor actor)
        {
            ApplyFlight(actor);
        }

        return false;
    }

    private static void ApplyFlight(Actor actor)
    {
        actor.setFlying(true);
    }

    private static void ApplyFlightToExistingActors()
    {
        if (World.world?.units == null)
        {
            return;
        }

        foreach (Actor actor in World.world.units)
        {
            if (actor != null && actor.hasTrait(FlightTraitId))
            {
                ApplyFlight(actor);
            }
        }
    }

    private static bool TriggerUnbrokenWillGetHit(BaseSimObject self, BaseSimObject attackedBy, WorldTile tile)
    {
        if (self is not Actor actor)
        {
            return false;
        }

        if (GetCustomBool(actor, EraEntityCustomDataKeys.TraitUnbrokenWillUsed))
        {
            return false;
        }

        if (actor.getMaxHealth() <= 0 || actor.getHealth() <= 0)
        {
            return false;
        }

        if (actor.getHealth() > actor.getMaxHealthPercent(0.2f))
        {
            return false;
        }

        SetCustomBool(actor, EraEntityCustomDataKeys.TraitUnbrokenWillUsed, true);
        actor.restoreHealth(Math.Max(1, actor.getHealth() / 2));
        return false;
    }

    private static bool TriggerSharedFateGetHit(BaseSimObject self, BaseSimObject attackedBy, WorldTile tile)
    {
        if (self is not Actor actor)
        {
            return false;
        }

        if (attackedBy is not Actor attacker)
        {
            return false;
        }

        foreach (Actor ally in EnumerateActors())
        {
            if (ally == null || !ally.isAlive() || !ally.hasTrait(SharedFateTraitId))
            {
                continue;
            }

            if (!ally.hasKingdom() || !actor.hasKingdom() || !ally.isSameKingdom(actor))
            {
                continue;
            }

            ally.addAggro(attacker);
            ally.startFightingWith(attacker);
        }

        return false;
    }

    private static void RestoreManaPercent(Actor actor, float percent)
    {
        if (percent <= 0f || !WorldboxReflectionAdapter.TryGetActorMana(actor, out int mana) || mana <= 0)
        {
            return;
        }

        int amount = Math.Max(1, (int)MathF.Round(Math.Max(0, mana) * percent));
        WorldboxReflectionAdapter.TrySetActorMana(actor, mana + amount);
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
}

internal static class EraTraitTriggerContextExtensions
{
    public static EraEffectContext ToEffectContext(this EraTriggerContext context)
    {
        return EraEffectContext.FromTrigger(context);
    }
}
