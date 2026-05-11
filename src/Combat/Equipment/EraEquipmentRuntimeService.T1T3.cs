using System;
using System.Collections.Generic;
using System.Linq;
using EraWheel.Combat.Effects;
using EraWheel.Combat.Statuses;
using EraWheel.Core.Constants;
using EraWheel.Core.Time;

namespace EraWheel.Combat.Equipment;

public sealed partial class EraEquipmentRuntimeService
{
    private const string StormwireBladeId = "eq_herit_t1_stormwire_blade";
    private const string MirrorShellHelmId = "eq_herit_t1_mirror_shell_helm";
    private const string SeedflareRingId = "eq_herit_t1_seedflare_ring";
    private const string QuakeAxeId = "eq_herit_t2_quake_axe";
    private const string ShadowstepBootsId = "eq_herit_t2_shadowstep_boots";
    private const string VoidwellAmuletId = "eq_herit_t2_voidwell_amulet";
    private const string TideSpearId = "eq_herit_t3_tide_spear";
    private const string IronTideArmorId = "eq_herit_t3_iron_tide_armor";
    private const string PlagueRainRingId = "eq_herit_t3_plague_rain_ring";

    partial void RegisterTier1To3EquipmentTriggers()
    {
        RegisterOnHitEquipmentSkill(
            StormwireBladeId,
            (context, actor) =>
            {
                Actor? target = context.TargetActor;
                if (target?.current_tile == null)
                {
                    return;
                }

                ActionLibrary.castLightning(actor, target, target.current_tile);
                float vulnerabilityPercent = RollBetween(actor, target, "stormwire_vulnerability", 10f, 20f);
                ApplyIncomingDamageAmp(
                    target,
                    vulnerabilityPercent,
                    context.WorldTime + EraWorldTime.YearsToWorldTime(1f)
                );
            }
        );

        RegisterOnGetHitEquipmentSkill(
            MirrorShellHelmId,
            (context, actor) =>
            {
                Actor? attacker = context.SourceActor;
                if (attacker == null)
                {
                    return;
                }

                float healingPercent = RollBetween(actor, attacker, "mirror_shell_heal", 0.10f, 0.20f);
                int healing = Math.Max(1, (int)MathF.Round(Math.Max(0f, context.Damage) * healingPercent));
                actor.restoreHealth(healing);

                float slowPercent = RollBetween(actor, attacker, "mirror_shell_slow", 10f, 20f);
                ApplyTimedDebuff(
                    attacker,
                    $"ew_equip_mirror_shell_slow:{attacker.getID()}",
                    EraWorldTime.YearsToWorldTime(1f),
                    new Dictionary<string, float>
                    {
                        [EraAttributeIds.MultiplierSpeed] = -slowPercent,
                    }
                );
            }
        );

        RegisterOnHitEquipmentSkill(
            SeedflareRingId,
            (context, actor) =>
            {
                Actor? target = context.TargetActor;
                if (target?.current_tile == null)
                {
                    return;
                }

                ActionLibrary.castFire(actor, target, target.current_tile);
                float slowPercent = RollBetween(actor, target, "seedflare_slow", 10f, 20f);
                ApplyTimedDebuff(
                    target,
                    $"ew_equip_seedflare_slow:{target.getID()}",
                    EraWorldTime.YearsToWorldTime(1f),
                    new Dictionary<string, float>
                    {
                        [EraAttributeIds.MultiplierSpeed] = -slowPercent,
                    }
                );
            }
        );

        RegisterOnHitEquipmentSkill(
            QuakeAxeId,
            (context, actor) =>
            {
                Actor? target = context.TargetActor;
                if (target?.current_tile == null)
                {
                    return;
                }

                float damageMultiplier = RollBetween(actor, target, "quake_axe_damage", 0.15f, 0.25f);
                _effects.ApplyAreaDamage(
                    context.ToEffectContext(),
                    target.current_tile,
                    4f,
                    damageMultiplier: damageMultiplier,
                    targetRule: EraEffectTargetRule.Foes
                );

                foreach (Actor victim in _effects.FindActors(target.current_tile, 4f, actor, EraEffectTargetRule.Foes))
                {
                    _statuses.ApplyStun(
                        victim,
                        2f,
                        runtimeKey: $"{QuakeAxeStunKeyPrefix}{victim.getID()}"
                    );
                }
            }
        );

        RegisterOnGetHitEquipmentSkill(
            ShadowstepBootsId,
            (context, actor) =>
            {
                float speedBonus = RollBetween(actor, context.SourceActor, "shadowstep_speed", 15f, 55f);
                ApplyTimedBuff(
                    actor,
                    $"ew_equip_shadowstep_speed:{actor.getID()}",
                    EraWorldTime.YearsToWorldTime(1f),
                    new Dictionary<string, float>
                    {
                        [EraAttributeIds.MultiplierSpeed] = speedBonus,
                    }
                );

                _statuses.ApplyNow(
                    actor,
                    new EraStatusApplication(
                        EraStatusKind.TimedBuff,
                        EraWorldTime.YearsToWorldTime(1f),
                        EraStatusStackMode.Replace,
                        runtimeKey: $"{ShadowstepChargeKey}:{actor.getID()}",
                        statModifiers: new Dictionary<string, float>
                        {
                            [EraAttributeIds.MultiplierCrit] = 100f,
                        }
                    )
                );
            }
        );

        RegisterOnHitEquipmentSkill(
            ShadowstepBootsId,
            (context, actor) =>
            {
                Actor? target = context.TargetActor;
                if (target == null || !TryConsumeShadowstepCharge(actor, out float extraDamageMultiplier))
                {
                    return;
                }

                int extraDamage = Math.Max(1, (int)MathF.Round(Math.Max(0f, context.Damage) * extraDamageMultiplier));
                _effects.ApplyDamage(context.ToEffectContext(), target, flatDamage: extraDamage);
            },
            chancePercent: 100f,
            manaCost: 0,
            condition: (_, actor) => _statuses.TryGetStatus(actor, $"{ShadowstepChargeKey}:{actor.getID()}", out EraActiveStatus? _)
        );

        RegisterOnGetHitEquipmentSkill(
            VoidwellAmuletId,
            (context, actor) =>
            {
                float shieldAmount = Math.Max(50f, actor.getMaxHealth() * 0.2f);
                float manaPercent = RollBetween(actor, context.SourceActor, "voidwell_mana_restore", 0.15f, 0.25f);
                _statuses.ApplyShield(
                    actor,
                    shieldAmount,
                    EraWorldTime.YearsToWorldTime(1f),
                    runtimeKey: $"ew_equip_voidwell_shield:{actor.getID()}"
                );
                ApplyTimedBuff(
                    actor,
                    $"ew_equip_voidwell_mana:{actor.getID()}",
                    EraWorldTime.YearsToWorldTime(1f),
                    new Dictionary<string, float>
                    {
                        [EraAttributeIds.MultiplierMana] = manaPercent * 100f,
                    }
                );
            }
        );

        RegisterActiveEquipmentSkill(
            TideSpearId,
            (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 18f);
                WorldTile? center = target?.current_tile ?? actor.current_tile;
                if (center == null)
                {
                    return;
                }

                _effects.ApplyAreaPull(context, center, 5f, forceAmount: 3f);
                _effects.ApplyAreaCurrentHealthDamage(
                    context,
                    center,
                    5f,
                    percent: 0.02f,
                    targetRule: EraEffectTargetRule.Foes
                );
            },
            cooldownWorldTime: DefaultActiveCooldown,
            targetSearchRadius: 18f
        );

        RegisterOnGetHitEquipmentSkill(
            IronTideArmorId,
            (context, actor) =>
            {
                Actor? attacker = context.SourceActor;
                float ratio = RollBetween(actor, attacker, "iron_tide_reflect", 0.15f, 0.25f);
                if (attacker != null)
                {
                    int reflectedDamage = Math.Max(1, (int)MathF.Round(Math.Max(0f, context.Damage) * ratio));
                    _effects.ApplyDamage(context.ToEffectContext(), attacker, flatDamage: reflectedDamage);
                }

                ApplyTimedBuff(
                    actor,
                    $"ew_equip_iron_tide_armor:{actor.getID()}",
                    EraWorldTime.YearsToWorldTime(2f),
                    new Dictionary<string, float>
                    {
                        [EraAttributeIds.Armor] = ratio * 100f,
                    }
                );
            }
        );

        RegisterActiveEquipmentSkill(
            PlagueRainRingId,
            (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 18f);
                WorldTile? center = target?.current_tile ?? actor.current_tile;
                if (center == null)
                {
                    return;
                }

                float damagePenalty = RollBetween(actor, target, "plague_rain_damage_down", 30f, 50f);
                string areaKey = $"ew_equip_plague_rain:{actor.getID()}";
                _terrain.UpsertPeriodicArea(
                    areaKey,
                    actor,
                    anchorActor: null,
                    centerTile: center,
                    radius: 6f,
                    durationWorldTime: 10f,
                    tickIntervalWorldTime: 2f,
                    targetRule: EraEffectTargetRule.Foes,
                    onActorTick: (_, victim) =>
                    {
                        ApplyTimedDebuff(
                            victim,
                            $"ew_equip_plague_rain_weak:{victim.getID()}",
                            EraWorldTime.YearsToWorldTime(2f),
                            new Dictionary<string, float>
                            {
                                [EraAttributeIds.MultiplierDamage] = -damagePenalty,
                            }
                        );
                    }
                );
            },
            cooldownWorldTime: DefaultActiveCooldown,
            targetSearchRadius: 18f
        );
    }
}
