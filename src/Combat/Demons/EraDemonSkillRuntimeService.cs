using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EraWheel.Assets;
using EraWheel.Combat.Effects;
using EraWheel.Combat.Statuses;
using EraWheel.Combat.Terrain;
using EraWheel.Combat.Triggers;
using EraWheel.Core;
using EraWheel.Core.Constants;
using EraWheel.Core.Logging;
using EraWheel.Core.Time;
using EraWheel.Localization;
using EraWheel.Reflection;
using NeoModLoader.General;
using UnityEngine;

namespace EraWheel.Combat.Demons;

public sealed partial class EraDemonSkillRuntimeService
{
    private const string RuntimeActorTextureRoot = "actors/species/other";
    private const string VoidLordId = "demon_void_lord";
    private const string PlagueMotherId = "demon_plague_mother";
    private const string MechTyrantId = "demon_mech_tyrant";
    private const string ZombieAssetId = "zombie";
    private const string AssimilatorAssetId = "assimilator";
    private const string DroneAssetId = "ew_summon_mech_drone";
    private const string InfectionRuntimeKey = "ew_plague_infection";
    private const string ChargeRuntimeKey = "ew_mech_charge";
    private const string VoidAuraAreaKeyPrefix = "ew_void_aura:";
    private const string DroneGroupKey = "魔王与将领图片/机械暴君/召唤物：无人机";

    private readonly EraTriggerService _triggers;
    private readonly EraEffectService _effects;
    private readonly EraStatusRuntimeService _statuses;
    private readonly EraTerrainAreaService _terrain;
    private readonly Dictionary<string, float> _cooldowns = new();
    private readonly Dictionary<string, float> _timers = new();
    private readonly Dictionary<long, long> _infectionSources = new();

    public EraDemonSkillRuntimeService(
        EraTriggerService triggers,
        EraEffectService effects,
        EraStatusRuntimeService statuses,
        EraTerrainAreaService terrain
    )
    {
        _triggers = triggers;
        _effects = effects;
        _statuses = statuses;
        _terrain = terrain;

        EnsureDroneAssetRegistered();
        RegisterVoidLord();
        RegisterPlagueMother();
        RegisterMechTyrant();
        RegisterTimeDistorter();
        RegisterChaosFlame();
        RegisterAbyssGod();
        RegisterDeathKing();
        RegisterSoulWeaver();
        RegisterNatureWrath();
        RegisterFinalJudge();
    }

    public string CreateStatusReport()
    {
        return $"技能冷却={_cooldowns.Count}；周期计时器={_timers.Count}；感染来源={_infectionSources.Count}";
    }

    private void RegisterVoidLord()
    {
        RegisterTickSkill(
            "demon_void_lord#p0",
            VoidLordId,
            chancePercent: 100f,
            cooldownWorldTime: 0f,
            manaCost: 0,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                string areaKey = $"{VoidAuraAreaKeyPrefix}{actor.getID()}";
                _terrain.UpsertPeriodicArea(
                    areaKey,
                    actor,
                    actor,
                    actor.current_tile,
                    radius: 12f,
                    durationWorldTime: EraWorldTime.YearsToWorldTime(1f),
                    tickIntervalWorldTime: EraWorldTime.MonthToWorldTime(6f),
                    targetRule: EraEffectTargetRule.Foes,
                    onActorTick: (tickContext, target) =>
                    {
                        _statuses.ApplySlow(
                            target,
                            EraWorldTime.YearsToWorldTime(3f),
                            speedModifier: -15f,
                            runtimeKey: "ew_void_lord_p0_slow"
                        );
                    }
                );
            }
        );

        RegisterTickSkill(
            "demon_void_lord#s1",
            VoidLordId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 20f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 20f);
                if (target?.current_tile == null)
                {
                    return;
                }

                WorldTile landingTile = ResolveNearbyTile(target.current_tile, 3f) ?? target.current_tile;
                WorldboxReflectionAdapter.TryTeleportActor(actor, landingTile);
                _effects.ApplyDamage(context, target, damageMultiplier: 2f, preserveOneHitPoint: false);
            }
        );

        RegisterTickSkill(
            "demon_void_lord#s2",
            VoidLordId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 20f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 20f);
                if (target?.current_tile == null)
                {
                    return;
                }

                ActionLibrary.castSpellSilence(actor, target, target.current_tile);
                _statuses.ApplySilence(target, EraWorldTime.YearsToWorldTime(2f), "ew_void_lord_s2_silence");
            }
        );

        RegisterTickSkill(
            "demon_void_lord#s3",
            VoidLordId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 20f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 20f);
                if (target?.current_tile == null)
                {
                    return;
                }

                _effects.ApplyAreaStatus(
                    context,
                    target.current_tile,
                    radius: 8f,
                    application: new EraStatusApplication(
                        EraStatusKind.Slow,
                        EraWorldTime.YearsToWorldTime(2f),
                        runtimeKey: "ew_void_lord_s3_rift_slow",
                        statModifiers: new Dictionary<string, float>
                        {
                            [EraAttributeIds.MultiplierSpeed] = -20f,
                        }
                    ),
                    targetRule: EraEffectTargetRule.Foes
                );
            }
        );

        RegisterTickSkill(
            "demon_void_lord#s4",
            VoidLordId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                float shield = actor.getMaxHealth() * 0.1f;
                _statuses.ApplyShield(
                    actor,
                    shield,
                    EraWorldTime.YearsToWorldTime(2f),
                    runtimeKey: "ew_void_lord_s4_reflect_shield"
                );
            }
        );

        RegisterTickSkill(
            "demon_void_lord#s5",
            VoidLordId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                _effects.ApplyAreaStatus(
                    context,
                    actor.current_tile!,
                    radius: 10f,
                    application: new EraStatusApplication(
                        EraStatusKind.TimedBuff,
                        EraWorldTime.YearsToWorldTime(2f),
                        runtimeKey: "ew_void_lord_s5_domination",
                        statModifiers: new Dictionary<string, float>
                        {
                            [EraAttributeIds.MultiplierDamage] = 20f,
                            [EraAttributeIds.MultiplierSpeed] = 20f,
                        }
                    ),
                    targetRule: EraEffectTargetRule.Friends
                );
                _statuses.ApplyTimedBuff(
                    actor,
                    EraWorldTime.YearsToWorldTime(2f),
                    new Dictionary<string, float>
                    {
                        [EraAttributeIds.MultiplierDamage] = 20f,
                        [EraAttributeIds.MultiplierSpeed] = 20f,
                    },
                    runtimeKey: "ew_void_lord_s5_domination_self"
                );
            }
        );

        RegisterTickSkill(
            "demon_void_lord#s6",
            VoidLordId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(10f),
            manaCost: 15,
            requiresAdvent: true,
            handler: (context, actor) =>
            {
                _effects.ApplyAreaCurrentHealthDamage(
                    context,
                    actor.current_tile!,
                    radius: 20f,
                    percent: 0.08f,
                    preserveOneHitPoint: true,
                    targetRule: EraEffectTargetRule.Foes
                );
            }
        );
    }

    private void RegisterPlagueMother()
    {
        _triggers.RegisterActorAssetTrigger(
            "demon_plague_mother#p0_on_hit",
            PlagueMotherId,
            EraTriggerType.OnHit,
            EraTriggerSubject.Source,
            PlagueMotherId,
            (context, actor) =>
            {
                if (context.TargetActor == null)
                {
                    return;
                }

                ApplyInfection(context.TargetActor, actor);
            },
            chancePercent: 20f
        );

        _triggers.Register(
            new EraTriggerDefinition(
                "demon_plague_mother#p0_infection_burst",
                PlagueMotherId,
                EraTriggerType.OnGetHit,
                context =>
                {
                    if (context.TargetActor == null)
                    {
                        return;
                    }

                    int stacks = _statuses.GetStacks(context.TargetActor, InfectionRuntimeKey);
                    if (stacks <= 0)
                    {
                        return;
                    }

                    _effects.ApplyCurrentHealthDamage(
                        context.ToEffectContext(),
                        context.TargetActor,
                        0.01f * stacks,
                        preserveOneHitPoint: true
                    );
                }
            )
        );

        _triggers.Register(
            new EraTriggerDefinition(
                "demon_plague_mother#s5",
                PlagueMotherId,
                EraTriggerType.OnDeath,
                context =>
                {
                    if (context.TargetActor?.current_tile == null)
                    {
                        return;
                    }

                    if (_statuses.GetStacks(context.TargetActor, InfectionRuntimeKey) <= 0)
                    {
                        return;
                    }

                    Actor? source = ResolveActor(
                        _infectionSources.TryGetValue(context.TargetActor.getID(), out long sourceId) ? sourceId : 0L
                    );
                    EraEffectContext effectContext = new EraEffectContext(
                        source ?? context.TargetActor,
                        context.TargetActor,
                        context.WorldTime,
                        "demon_plague_mother#s5",
                        EraTriggerType.OnDeath
                    );

                    _effects.ApplyAreaCurrentHealthDamage(
                        effectContext,
                        context.TargetActor.current_tile,
                        radius: 5f,
                        percent: 0.01f,
                        preserveOneHitPoint: true,
                        targetRule: source != null ? EraEffectTargetRule.Foes : EraEffectTargetRule.All
                    );
                    _infectionSources.Remove(context.TargetActor.getID());
                }
            )
        );

        RegisterTickSkill(
            "demon_plague_mother#s1",
            PlagueMotherId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                foreach (Actor target in _effects.FindActors(actor.current_tile!, 6f, actor, EraEffectTargetRule.Foes))
                {
                    ApplyInfection(target, actor);
                }
            }
        );

        RegisterTickSkill(
            "demon_plague_mother#s2",
            PlagueMotherId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 20f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 20f);
                if (target?.current_tile == null)
                {
                    return;
                }

                foreach (Actor foe in _effects.FindActors(target.current_tile, 6f, actor, EraEffectTargetRule.Foes))
                {
                    ActionLibrary.castCurses(actor, foe, foe.current_tile);
                    _statuses.ApplyTimedDebuff(
                        foe,
                        EraWorldTime.YearsToWorldTime(2f),
                        new Dictionary<string, float>
                        {
                            [EraAttributeIds.MultiplierDamage] = -10f,
                        },
                        runtimeKey: "ew_plague_s2_curse"
                    );
                }
            }
        );

        RegisterTickSkill(
            "demon_plague_mother#s3",
            PlagueMotherId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 20f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 20f);
                if (target == null)
                {
                    return;
                }

                _statuses.ApplyTimedDebuff(
                    target,
                    EraWorldTime.YearsToWorldTime(2f),
                    new Dictionary<string, float>
                    {
                        [EraAttributeIds.MultiplierDamage] = -20f,
                        [EraAttributeIds.Armor] = -5f,
                    },
                    runtimeKey: "ew_plague_s3_weakness"
                );
            }
        );

        RegisterTickSkill(
            "demon_plague_mother#s4",
            PlagueMotherId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 20f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 20f);
                WorldTile centerTile = target?.current_tile ?? actor.current_tile!;
                _effects.SummonUnits(context, ZombieAssetId, centerTile, count: 10, joinSourceKingdom: true);
            }
        );

        RegisterTickSkill(
            "demon_plague_mother#s6",
            PlagueMotherId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(10f),
            manaCost: 15,
            requiresAdvent: true,
            handler: (context, actor) =>
            {
                foreach (Actor target in _effects.FindActors(actor.current_tile!, 20f, actor, EraEffectTargetRule.Foes))
                {
                    ApplyInfection(target, actor);
                    _statuses.ApplyTimedDebuff(
                        target,
                        EraWorldTime.YearsToWorldTime(5f),
                        new Dictionary<string, float>
                        {
                            [EraAttributeIds.MultiplierDamage] = -20f,
                        },
                        runtimeKey: "ew_plague_s6_black_plague"
                    );
                }
            }
        );
    }

    private void RegisterMechTyrant()
    {
        _triggers.RegisterActorAssetTrigger(
            "demon_mech_tyrant#p0_charge_tick",
            MechTyrantId,
            EraTriggerType.OnTick,
            EraTriggerSubject.Source,
            MechTyrantId,
            (context, actor) =>
            {
                string timerKey = BuildActorTimerKey(actor, "charge_gain");
                if (!CanRunTimer(timerKey, context.WorldTime, 5f))
                {
                    return;
                }

                AddCharges(actor, 1);
            },
            chancePercent: 100f
        );

        _triggers.RegisterActorAssetTrigger(
            "demon_mech_tyrant#p0_charge_hit",
            MechTyrantId,
            EraTriggerType.OnHit,
            EraTriggerSubject.Source,
            MechTyrantId,
            (context, actor) => AddCharges(actor, 1),
            chancePercent: 20f
        );

        _triggers.RegisterActorAssetTrigger(
            "demon_mech_tyrant#drone_pulse",
            DroneAssetId,
            EraTriggerType.OnTick,
            EraTriggerSubject.Source,
            DroneAssetId,
            (context, actor) =>
            {
                string timerKey = BuildActorTimerKey(actor, "drone_pulse");
                if (!CanRunTimer(timerKey, context.WorldTime, EraWorldTime.YearsToWorldTime(3f)))
                {
                    return;
                }

                EraEffectContext pulseContext = new EraEffectContext(
                    actor,
                    actor,
                    context.WorldTime,
                    "demon_mech_tyrant#s3_pulse",
                    EraTriggerType.OnTick
                );

                _effects.ApplyAreaStatus(
                    pulseContext,
                    actor.current_tile!,
                    radius: 8f,
                    application: new EraStatusApplication(
                        EraStatusKind.Shield,
                        EraWorldTime.YearsToWorldTime(3f),
                        runtimeKey: "ew_mech_drone_shield",
                        shieldAmount: 0f
                    ),
                    targetRule: EraEffectTargetRule.Friends,
                    customize: (target, application) =>
                    {
                        application.ShieldAmount = target.getMaxHealth() * 0.1f;
                        application.RuntimeKey = "ew_mech_drone_shield";
                        return application;
                    }
                );

                _statuses.ApplyShield(
                    actor,
                    actor.getMaxHealth() * 0.1f,
                    EraWorldTime.YearsToWorldTime(3f),
                    runtimeKey: "ew_mech_drone_self_shield"
                );
            },
            chancePercent: 100f
        );

        RegisterTickSkill(
            "demon_mech_tyrant#s1",
            MechTyrantId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            requiredCharges: 1,
            targetSearchRadius: 20f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 20f);
                if (target == null)
                {
                    return;
                }

                ConsumeCharges(actor, 1);
                _effects.ApplyDamage(context, target, damageMultiplier: 2f, preserveOneHitPoint: false);
            }
        );

        RegisterTickSkill(
            "demon_mech_tyrant#s2",
            MechTyrantId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            requiredCharges: 2,
            targetSearchRadius: 20f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 20f);
                if (target?.current_tile == null)
                {
                    return;
                }

                ConsumeCharges(actor, 2);
                _effects.ApplyAreaDamage(context, target.current_tile, 8f, damageMultiplier: 0.5f);
                _effects.ApplyAreaStatus(
                    context,
                    target.current_tile,
                    radius: 8f,
                    application: new EraStatusApplication(
                        EraStatusKind.TimedDebuff,
                        EraWorldTime.YearsToWorldTime(2f),
                        runtimeKey: "ew_mech_s2_emp",
                        statModifiers: new Dictionary<string, float>
                        {
                            [EraAttributeIds.MultiplierAttackSpeed] = -20f,
                        }
                    ),
                    targetRule: EraEffectTargetRule.Foes
                );
            }
        );

        RegisterTickSkill(
            "demon_mech_tyrant#s3",
            MechTyrantId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(2f),
            manaCost: 10,
            requiredCharges: 2,
            handler: (context, actor) =>
            {
                ConsumeCharges(actor, 2);
                IReadOnlyList<Actor> drones = _effects.SummonUnits(
                    context,
                    DroneAssetId,
                    actor.current_tile!,
                    count: 3,
                    joinSourceKingdom: true
                );

                foreach (Actor drone in drones)
                {
                    _statuses.ApplyTimedBuff(
                        drone,
                        EraWorldTime.YearsToWorldTime(1000f),
                        new Dictionary<string, float>
                        {
                            [EraAttributeIds.Health] = 100000f,
                        },
                        runtimeKey: "ew_mech_drone_health"
                    );
                    drone.changeHealth(100000);
                    _timers[BuildActorTimerKey(drone, "drone_pulse")] = context.WorldTime;
                }
            }
        );

        RegisterTickSkill(
            "demon_mech_tyrant#s4",
            MechTyrantId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            requiredCharges: 1,
            targetSearchRadius: 24f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 24f);
                if (target?.current_tile == null)
                {
                    return;
                }

                ConsumeCharges(actor, 1);
                WorldTile dashTile = ResolveDashTile(actor.current_tile!, target.current_tile, 12f);
                WorldboxReflectionAdapter.TryTeleportActor(actor, dashTile);
            }
        );

        RegisterTickSkill(
            "demon_mech_tyrant#s5",
            MechTyrantId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            requiredCharges: 2,
            handler: (context, actor) =>
            {
                ConsumeCharges(actor, 2);

                foreach (Actor ally in _effects.FindActors(actor.current_tile!, 10f, actor, EraEffectTargetRule.Friends))
                {
                    ActionLibrary.castCure(actor, ally, ally.current_tile);
                    _statuses.ApplyTimedBuff(
                        ally,
                        EraWorldTime.YearsToWorldTime(2f),
                        new Dictionary<string, float>
                        {
                            [EraAttributeIds.MultiplierAttackSpeed] = 20f,
                            [EraAttributeIds.MultiplierSpeed] = 20f,
                        },
                        runtimeKey: "ew_mech_s5_tactic_buff"
                    );
                }

                _statuses.ApplyTimedBuff(
                    actor,
                    EraWorldTime.YearsToWorldTime(2f),
                    new Dictionary<string, float>
                    {
                        [EraAttributeIds.MultiplierAttackSpeed] = 20f,
                        [EraAttributeIds.MultiplierSpeed] = 20f,
                    },
                    runtimeKey: "ew_mech_s5_tactic_buff_self"
                );

                foreach (Actor foe in _effects.FindActors(actor.current_tile!, 10f, actor, EraEffectTargetRule.Foes))
                {
                    _statuses.ApplyTimedDebuff(
                        foe,
                        EraWorldTime.YearsToWorldTime(2f),
                        new Dictionary<string, float>
                        {
                            [EraAttributeIds.MultiplierDamage] = -20f,
                        },
                        runtimeKey: "ew_mech_s5_tactic_debuff"
                    );
                }
            }
        );

        RegisterTickSkill(
            "demon_mech_tyrant#s6",
            MechTyrantId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(10f),
            manaCost: 15,
            requiredCharges: 4,
            requiresAdvent: true,
            handler: (context, actor) =>
            {
                int charges = GetCharges(actor);
                if (charges <= 0)
                {
                    return;
                }

                ConsumeCharges(actor, charges);

                _effects.ApplyAreaStatus(
                    context,
                    actor.current_tile!,
                    radius: 20f,
                    application: new EraStatusApplication(
                        EraStatusKind.TimedDebuff,
                        EraWorldTime.YearsToWorldTime(5f),
                        runtimeKey: "ew_mech_s6_sky_net",
                        statModifiers: new Dictionary<string, float>
                        {
                            [EraAttributeIds.MultiplierAttackSpeed] = -50f,
                            [EraAttributeIds.MultiplierSpeed] = -50f,
                        }
                    ),
                    targetRule: EraEffectTargetRule.Foes
                );

                _effects.SummonUnits(
                    context,
                    AssimilatorAssetId,
                    actor.current_tile!,
                    count: 20,
                    joinSourceKingdom: true
                );
            }
        );
    }

    private void RegisterTickSkill(
        string skillId,
        string actorAssetId,
        float chancePercent,
        float cooldownWorldTime,
        int manaCost,
        Action<EraEffectContext, Actor> handler,
        int requiredCharges = 0,
        bool requiresAdvent = false,
        float targetSearchRadius = 0f
    )
    {
        _triggers.RegisterActorAssetTrigger(
            skillId,
            actorAssetId,
            EraTriggerType.OnTick,
            EraTriggerSubject.Source,
            actorAssetId,
            (context, actor) =>
            {
                if (!CanCastSkill(
                        actor,
                        skillId,
                        context.WorldTime,
                        cooldownWorldTime,
                        manaCost,
                        requiredCharges,
                        requiresAdvent,
                        targetSearchRadius
                    ))
                {
                    return;
                }

                if (manaCost > 0)
                {
                    WorldboxReflectionAdapter.TryConsumeActorMana(actor, manaCost);
                }

                handler(context.ToEffectContext(), actor);
                _cooldowns[BuildCooldownKey(actor, skillId)] = context.WorldTime + cooldownWorldTime;
            },
            chancePercent: chancePercent,
            condition: context =>
            {
                Actor? actor = context.SourceActor;
                return actor != null && CanCastSkill(
                    actor,
                    skillId,
                    context.WorldTime,
                    cooldownWorldTime,
                    manaCost,
                    requiredCharges,
                    requiresAdvent,
                    targetSearchRadius
                );
            }
        );
    }

    private bool CanCastSkill(
        Actor actor,
        string skillId,
        float worldTime,
        float cooldownWorldTime,
        int manaCost,
        int requiredCharges,
        bool requiresAdvent,
        float targetSearchRadius = 0f
    )
    {
        if (actor.current_tile == null || !actor.isAlive())
        {
            return false;
        }

        if (requiresAdvent && EraRuntimeBootstrap.RuntimeSave?.CurrentState.Stage != EraStage.Advent)
        {
            return false;
        }

        if (cooldownWorldTime > 0f &&
            _cooldowns.TryGetValue(BuildCooldownKey(actor, skillId), out float nextAllowedWorldTime) &&
            nextAllowedWorldTime > worldTime)
        {
            return false;
        }

        if (requiredCharges > 0 && GetCharges(actor) < requiredCharges)
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

    private void ApplyInfection(Actor target, Actor source)
    {
        _statuses.ApplyStack(
            target,
            EraWorldTime.YearsToWorldTime(10f),
            stackDelta: 1,
            maxStacks: 3,
            runtimeKey: InfectionRuntimeKey
        );
        _infectionSources[target.getID()] = source.getID();
    }

    private int GetCharges(Actor actor)
    {
        return _statuses.GetStacks(actor, ChargeRuntimeKey);
    }

    private void AddCharges(Actor actor, int amount)
    {
        if (amount <= 0)
        {
            return;
        }

        if (GetCharges(actor) <= 0)
        {
            _statuses.ApplyStack(
                actor,
                EraWorldTime.YearsToWorldTime(1000f),
                stackDelta: amount,
                maxStacks: 6,
                runtimeKey: ChargeRuntimeKey
            );
            return;
        }

        int updated = Math.Min(6, GetCharges(actor) + amount);
        _statuses.SetStacks(actor, ChargeRuntimeKey, updated);
    }

    private void ConsumeCharges(Actor actor, int amount)
    {
        if (amount <= 0)
        {
            return;
        }

        _statuses.ChangeStacks(actor, ChargeRuntimeKey, -amount);
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

    private static string BuildCooldownKey(Actor actor, string skillId)
    {
        return $"{actor.getID()}:{skillId}";
    }

    private static string BuildActorTimerKey(Actor actor, string timerName)
    {
        return $"{actor.getID()}:{timerName}";
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

    private static Actor? ResolveEnemyTarget(Actor actor, float maxDistance)
    {
        if (WorldboxReflectionAdapter.TryGetAttackTarget(actor, out BaseSimObject? target) &&
            target is Actor targetActor &&
            targetActor.isAlive() &&
            targetActor.current_tile != null &&
            actor.areFoes(targetActor))
        {
            return targetActor;
        }

        if (actor.current_tile == null || World.world?.units == null)
        {
            return null;
        }

        float maxDistanceSquared = maxDistance * maxDistance;
        Actor? best = null;
        float bestDistance = float.MaxValue;
        foreach (Actor other in World.world.units)
        {
            if (other == null || !other.isAlive() || other.current_tile == null || !actor.areFoes(other))
            {
                continue;
            }

            float dx = other.current_tile.x - actor.current_tile.x;
            float dy = other.current_tile.y - actor.current_tile.y;
            float distanceSquared = (dx * dx) + (dy * dy);
            if (distanceSquared > maxDistanceSquared || distanceSquared >= bestDistance)
            {
                continue;
            }

            bestDistance = distanceSquared;
            best = other;
        }

        return best;
    }

    private static WorldTile? ResolveNearbyTile(WorldTile centerTile, float radius)
    {
        int searchRadius = Math.Max(1, (int)MathF.Ceiling(radius));
        foreach (WorldTile tile in centerTile.getTilesAround(searchRadius))
        {
            if (tile != null && !tile.is_liquid && !tile.hasBuilding())
            {
                return tile;
            }
        }

        return centerTile;
    }

    private static WorldTile ResolveDashTile(WorldTile fromTile, WorldTile targetTile, float distance)
    {
        int dx = targetTile.x - fromTile.x;
        int dy = targetTile.y - fromTile.y;
        float length = MathF.Sqrt((dx * dx) + (dy * dy));
        if (length <= 0.001f)
        {
            return targetTile;
        }

        int endX = fromTile.x + (int)MathF.Round((dx / length) * distance);
        int endY = fromTile.y + (int)MathF.Round((dy / length) * distance);
        return World.world?.GetTile(endX, endY) ?? targetTile;
    }

    private static void EnsureDroneAssetRegistered()
    {
        if (AssetManager.actor_library.has(DroneAssetId))
        {
            return;
        }

        ActorAsset? template = AssetManager.actor_library.get(AssimilatorAssetId)
            ?? AssetManager.actor_library.get(EraWorldboxAssetIds.MobNoGenesTemplate);
        if (template == null)
        {
            EraLog.Warning(EraLogCategory.Combat, "无法注册机械无人机：缺少基础模板。");
            return;
        }

        string iconPath = ResolveDroneIconPath();
        if (string.IsNullOrWhiteSpace(iconPath))
        {
            EraLog.Error(EraLogCategory.Combat, "机械无人机注册已降级：图标路径为空，已跳过注册以避免贴图预加载异常。");
            return;
        }

        if (SpriteTextureLoader.getSprite(iconPath) == null)
        {
            EraLog.Error(EraLogCategory.Combat, $"机械无人机注册已降级：图标资源不可用（{iconPath}），已跳过注册以避免贴图预加载异常。");
            return;
        }

        AssetManager.actor_library.clone(out ActorAsset cloned, template);
        cloned.id = DroneAssetId;
        cloned.name_locale = DroneAssetId;
        cloned.icon = iconPath;
        cloned.kingdom_id_wild = string.Empty;
        cloned.can_be_favorited = false;
        cloned.hide_favorite_icon = true;
        cloned.can_edit_equipment = false;
        cloned.can_edit_traits = false;
        cloned.can_receive_traits = false;
        cloned.use_items = false;
        cloned.take_items = false;
        cloned.skip_fight_logic = true;
        cloned.force_hide_mana = true;
        cloned.shadow = false;
        cloned.has_baby_form = false;
        cloned.flying = true;
        cloned.hovering = true;
        cloned.special = true;
        cloned.unit_other = true;
        cloned.skip_save = true;

        IReadOnlyList<EraSpriteResource> walkFrames = ResolveUnitGroupWalkFrames(DroneGroupKey);
        if (!EnsureRuntimeTemplateTextures(cloned, template, DroneAssetId, "机械无人机", walkFrames))
        {
            return;
        }

        ActorAsset asset = AssetManager.actor_library.add(cloned);
        RegisterRuntimeActorLocale(
            asset,
            DroneAssetId,
            "护盾无人机",
            "Shield Drone",
            "机械暴君的护盾支援无人机，只负责脉冲护盾。",
            "A support drone that only emits shield pulses."
        );
        if (LocalizedTextManager.instance != null)
        {
            LM.ApplyLocale(false);
        }
    }

    private static bool EnsureRuntimeTemplateTextures(ActorAsset cloned, ActorAsset template, string actorLabel)
    {
        return EnsureRuntimeTemplateTextures(cloned, template, cloned?.id ?? string.Empty, actorLabel, Array.Empty<EraSpriteResource>());
    }

    private static bool EnsureRuntimeTemplateTextures(
        ActorAsset cloned,
        ActorAsset template,
        string actorId,
        string actorLabel,
        IReadOnlyList<EraSpriteResource> walkFrames,
        string fallbackSingleFrameSourcePath = ""
    )
    {
        if (cloned == null || template == null)
        {
            EraLog.Error(EraLogCategory.Combat, $"{actorLabel}注册已降级：运行时模板为空，无法补建贴图。");
            return false;
        }

        if (string.IsNullOrWhiteSpace(actorId))
        {
            EraLog.Error(EraLogCategory.Combat, $"{actorLabel}注册已降级：actorId 为空，无法桥接主贴图。");
            return false;
        }

        if (!TryPrepareRuntimeActorSprites(actorId, actorLabel, walkFrames, fallbackSingleFrameSourcePath, out string mainTexturePath, out int frameCount, out string failureReason))
        {
            EraLog.Error(
                EraLogCategory.Combat,
                $"{actorLabel}注册已降级：{failureReason}，已跳过注册以避免原版单位预加载继续读取坏模板。"
            );
            return false;
        }

        cloned.texture_id = actorId;
        cloned.animation_walk = frameCount > 1 ? ActorAnimationSequences.walk_0_3 : ActorAnimationSequences.walk_0;
        cloned.animation_idle = ActorAnimationSequences.walk_0;
        cloned.animation_swim = null;
        cloned.has_baby_form = false;
        cloned.has_advanced_textures = false;
        cloned.render_heads_for_babies = false;
        cloned.shadow = false;
        cloned.texture_asset = CreateMinimalRuntimeTextureAsset(actorId, mainTexturePath);

        if (!WorldboxReflectionAdapter.TryPrepareActorTextures(cloned) || cloned.texture_asset == null)
        {
            EraLog.Error(
                EraLogCategory.Combat,
                $"{actorLabel}注册已降级：主贴图桥接后调用原版贴图装配失败，已跳过注册。"
            );
            return false;
        }

        cloned.texture_asset.texture_path_main = mainTexturePath;
        cloned.texture_asset.texture_path_baby = string.Empty;
        cloned.texture_asset.texture_heads = string.Empty;
        cloned.texture_asset.texture_head_king = string.Empty;
        cloned.texture_asset.texture_head_warrior = string.Empty;
        cloned.texture_asset.texture_heads_old_male = string.Empty;
        cloned.texture_asset.texture_heads_old_female = string.Empty;
        cloned.texture_asset.texture_heads_male = string.Empty;
        cloned.texture_asset.texture_heads_female = string.Empty;
        cloned.texture_asset.shadow = false;

        if (!HasUsableMainTexture(cloned))
        {
            EraLog.Error(
                EraLogCategory.Combat,
                $"{actorLabel}注册已降级：主贴图列表为空，路径={mainTexturePath}。"
            );
            return false;
        }

        return true;
    }

    private static ActorTextureSubAsset CreateMinimalRuntimeTextureAsset(string actorId, string mainTexturePath)
    {
        ActorTextureSubAsset textureAsset = new ActorTextureSubAsset($"{RuntimeActorTextureRoot}/{actorId}/", pHasAdvancedTextures: false)
        {
            texture_path_main = mainTexturePath,
            texture_path_baby = string.Empty,
            texture_heads = string.Empty,
            texture_head_king = string.Empty,
            texture_head_warrior = string.Empty,
            texture_heads_old_male = string.Empty,
            texture_heads_old_female = string.Empty,
            texture_heads_male = string.Empty,
            texture_heads_female = string.Empty,
            shadow = false,
        };
        return textureAsset;
    }

    private static bool TryPrepareRuntimeActorSprites(
        string actorId,
        string actorLabel,
        IReadOnlyList<EraSpriteResource> walkFrames,
        string fallbackSingleFrameSourcePath,
        out string mainTexturePath,
        out int frameCount,
        out string failureReason
    )
    {
        mainTexturePath = BuildRuntimeMainTexturePath(actorId);
        frameCount = 0;
        failureReason = string.Empty;

        List<(int Order, byte[] Bytes)> frameBytes = new List<(int Order, byte[] Bytes)>();
        if (walkFrames != null)
        {
            foreach (EraSpriteResource frame in walkFrames)
            {
                if (frame == null || string.IsNullOrWhiteSpace(frame.SourcePath))
                {
                    continue;
                }

                int? order = EraSpriteCacheService.TryParseFrameOrder(Path.GetFileNameWithoutExtension(frame.SourcePath));
                if (!order.HasValue)
                {
                    continue;
                }

                if (!TryReadSpriteBytes(frame.SourcePath, out byte[]? bytes))
                {
                    continue;
                }

                frameBytes.Add((order.Value, bytes));
            }
        }

        if (frameBytes.Count == 0 && !string.IsNullOrWhiteSpace(fallbackSingleFrameSourcePath))
        {
            if (!TryReadSpriteBytes(fallbackSingleFrameSourcePath, out byte[]? bytes))
            {
                failureReason = $"找不到兜底主贴图文件：{fallbackSingleFrameSourcePath}";
                return false;
            }

            frameBytes.Add((0, bytes));
        }

        if (frameBytes.Count == 0)
        {
            failureReason = "缺少可读取的 walk_* 主贴图，也没有可用的单帧兜底图。";
            return false;
        }

        if (!frameBytes.Any(item => item.Order == 0))
        {
            failureReason = "缺少 walk_0 主贴图，原版动画预加载无法确认起始帧。";
            return false;
        }

        List<(int Order, byte[] Bytes)> orderedFrames = frameBytes
            .GroupBy(item => item.Order)
            .Select(group => group.First())
            .OrderBy(item => item.Order)
            .ToList();

        if (!EraSpriteCacheService.UpsertSpriteList(mainTexturePath, orderedFrames))
        {
            failureReason = $"无法写入原版主贴图缓存：{mainTexturePath}";
            return false;
        }

        Sprite[]? sprites = SpriteTextureLoader.getSpriteList(mainTexturePath, pSkipIfEmpty: true);
        if (sprites == null || sprites.Length == 0)
        {
            EraSpriteCacheService.ClearSpriteListCache(mainTexturePath);
            failureReason = $"桥接后主贴图列表仍为空：{mainTexturePath}";
            return false;
        }

        frameCount = sprites.Length;
        return true;
    }

    private static bool TryReadSpriteBytes(string sourcePath, out byte[]? bytes)
    {
        bytes = null;
        if (string.IsNullOrWhiteSpace(sourcePath))
        {
            return false;
        }

        string modRootPath = EraWheelMod.I.GetDeclaration().FolderPath;
        string absolutePath = EraPathResolver.ResolveModPath(modRootPath, sourcePath);
        if (!File.Exists(absolutePath))
        {
            return false;
        }

        try
        {
            bytes = File.ReadAllBytes(absolutePath);
            return bytes.Length > 0;
        }
        catch (Exception exception)
        {
            EraLog.Exception(EraLogCategory.Combat, $"读取运行时单位贴图失败：{sourcePath}", exception);
            return false;
        }
    }

    private static IReadOnlyList<EraSpriteResource> ResolveUnitGroupWalkFrames(string groupKey)
    {
        if (EraRuntimeBootstrap.SpriteCatalog.UnitGroupsByKey.TryGetValue(groupKey, out EraUnitSpriteSet? spriteSet))
        {
            return spriteSet.WalkFrames;
        }

        return Array.Empty<EraSpriteResource>();
    }

    private static bool HasUsableMainTexture(ActorAsset asset)
    {
        if (asset?.texture_asset == null || string.IsNullOrWhiteSpace(asset.texture_asset.texture_path_main))
        {
            return false;
        }

        Sprite[]? sprites = SpriteTextureLoader.getSpriteList(asset.texture_asset.texture_path_main, pSkipIfEmpty: true);
        return sprites != null && sprites.Length > 0;
    }

    private static string BuildRuntimeMainTexturePath(string actorId)
    {
        return $"{RuntimeActorTextureRoot}/{actorId}/main";
    }

    private static void RegisterRuntimeActorLocale(
        ActorAsset asset,
        string localeKeyBase,
        string zhName,
        string enName,
        string zhDescription,
        string enDescription
    )
    {
        string nameKey = string.IsNullOrWhiteSpace(asset?.getLocaleID()) ? localeKeyBase : asset.getLocaleID();
        string descriptionKey = string.IsNullOrWhiteSpace(asset?.getDescriptionID()) ? $"{nameKey}_description" : asset.getDescriptionID();

        if (!string.IsNullOrWhiteSpace(nameKey))
        {
            EraLocaleRegistrar.AddZhEn(nameKey, zhName, enName);
        }

        if (!string.IsNullOrWhiteSpace(descriptionKey))
        {
            EraLocaleRegistrar.AddZhEn(descriptionKey, zhDescription, enDescription);
        }
    }

    private static string ResolveDroneIconPath()
    {
        if (EraRuntimeBootstrap.SpriteCatalog.UnitGroupsByKey.TryGetValue(DroneGroupKey, out var spriteSet) &&
            spriteSet.Icon != null &&
            !string.IsNullOrWhiteSpace(spriteSet.Icon.RuntimePathId))
        {
            return spriteSet.Icon.RuntimePathId;
        }

        return "Assets/Art/注册生物单位图片/魔王与将领图片/机械暴君/召唤物：无人机/icon.png";
    }
}

internal static class EraTriggerContextDemonExtensions
{
    public static EraEffectContext ToEffectContext(this EraTriggerContext context)
    {
        return EraEffectContext.FromTrigger(context);
    }
}
