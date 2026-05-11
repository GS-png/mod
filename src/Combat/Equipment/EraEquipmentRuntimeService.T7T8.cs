using System;
using System.Collections.Generic;
using System.Linq;
using EraWheel.Combat.Effects;
using EraWheel.Combat.Statuses;
using EraWheel.Core.Constants;
using EraWheel.Core.Time;
using EraWheel.Reflection;

namespace EraWheel.Combat.Equipment;

public sealed partial class EraEquipmentRuntimeService
{
    private const string ThunderPrisonGunId = "eq_herit_t7_thunder_prison_gun";
    private const string WallArmorId = "eq_herit_t7_wall_armor";
    private const string BlinkSigilId = "eq_herit_t7_blink_sigil";
    private const string AbyssTornadoBladeId = "eq_herit_t8_abyss_tornado_blade";
    private const string SolarFlareBootsId = "eq_herit_t8_solar_flare_boots";
    private const string VerdictCircuitRingId = "eq_herit_t8_verdict_circuit_ring";

    partial void RegisterTier7To8EquipmentTriggers()
    {
        RegisterOnHitEquipmentSkill(
            ThunderPrisonGunId,
            (context, actor) =>
            {
                Actor? target = context.TargetActor;
                if (target?.current_tile == null)
                {
                    return;
                }

                WorldTile center = target.current_tile;
                string areaKey = $"ew_equip_thunder_prison:{actor.getID()}";
                _terrain.UpsertPeriodicArea(
                    areaKey,
                    actor,
                    anchorActor: null,
                    centerTile: center,
                    radius: 5f,
                    durationWorldTime: 3f,
                    tickIntervalWorldTime: 1f,
                    targetRule: EraEffectTargetRule.Foes,
                    onActorTick: (tickContext, victim) =>
                    {
                        _effects.ApplyPullToPoint(tickContext, victim, center, forceAmount: 3.5f);
                        ApplyTimedDebuff(
                            victim,
                            $"ew_equip_thunder_prison_slow:{victim.getID()}",
                            1.5f,
                            new Dictionary<string, float>
                            {
                                [EraAttributeIds.MultiplierSpeed] = -95f,
                            }
                        );
                    }
                );
            }
        );

        RegisterOnGetHitEquipmentSkill(
            WallArmorId,
            (context, actor) =>
            {
                Actor? attacker = context.SourceActor;
                float shieldPercent = RollBetween(actor, attacker, "wall_armor_shield", 0.20f, 0.40f);
                float reflectRatio = RollBetween(actor, attacker, "wall_armor_reflect", 0.30f, 0.50f);
                _statuses.ApplyShield(
                    actor,
                    Math.Max(1f, actor.getMaxHealth() * shieldPercent),
                    EraWorldTime.YearsToWorldTime(1f),
                    runtimeKey: $"ew_equip_wall_armor:{actor.getID()}"
                );

                if (attacker != null)
                {
                    int reflectedDamage = Math.Max(1, (int)MathF.Round(Math.Max(0f, context.Damage) * reflectRatio));
                    _effects.ApplyDamage(context.ToEffectContext(), attacker, flatDamage: reflectedDamage);
                }
            }
        );

        RegisterActiveEquipmentSkill(
            BlinkSigilId,
            (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 20f);
                if (target?.current_tile == null)
                {
                    return;
                }

                if (!WorldboxReflectionAdapter.TryTeleportActor(actor, target.current_tile))
                {
                    return;
                }

                foreach (Actor victim in _effects.FindActors(target.current_tile, 8f, actor, EraEffectTargetRule.Foes))
                {
                    ApplyTimedDebuff(
                        victim,
                        $"ew_equip_blink_sigil_slow:{victim.getID()}",
                        EraWorldTime.YearsToWorldTime(3f),
                        new Dictionary<string, float>
                        {
                            [EraAttributeIds.MultiplierSpeed] = -40f,
                        }
                    );
                }
            },
            cooldownWorldTime: DefaultActiveCooldown,
            targetSearchRadius: 20f
        );

        RegisterOnHitEquipmentSkill(
            AbyssTornadoBladeId,
            (context, actor) =>
            {
                Actor? target = context.TargetActor;
                if (target?.current_tile == null)
                {
                    return;
                }

                ActionLibrary.castTornado(actor, target, target.current_tile);
                float vulnerabilityPercent = RollBetween(actor, target, "abyss_tornado_crack", 30f, 60f);
                foreach (Actor victim in _effects.FindActors(target.current_tile, 5f, actor, EraEffectTargetRule.Foes))
                {
                    ApplyIncomingDamageAmp(
                        victim,
                        vulnerabilityPercent,
                        context.WorldTime + EraWorldTime.YearsToWorldTime(3f)
                    );
                }
            }
        );

        RegisterActiveEquipmentSkill(
            SolarFlareBootsId,
            (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 20f);
                WorldTile? startTile = actor.current_tile;
                WorldTile? landingTile = startTile != null && target?.current_tile != null
                    ? FindClosestTileTowards(startTile, target.current_tile, 10)
                    : null;
                if (startTile == null || landingTile == null)
                {
                    return;
                }

                List<WorldTile> pathTiles = BuildLineTiles(startTile, landingTile, 10);
                StartFireOnTiles(pathTiles);
                WorldboxReflectionAdapter.TryTeleportActor(actor, landingTile);

                float damageMultiplier = RollBetween(actor, target, "solar_flare_damage", 0.50f, 0.70f);
                HashSet<long> damaged = new HashSet<long>();
                foreach (WorldTile tile in pathTiles)
                {
                    foreach (Actor victim in _effects.FindActors(tile, 1.5f, actor, EraEffectTargetRule.Foes))
                    {
                        if (!damaged.Add(victim.getID()))
                        {
                            continue;
                        }

                        _effects.ApplyDamage(context, victim, damageMultiplier: damageMultiplier, attackType: AttackType.Fire);
                    }
                }
            },
            cooldownWorldTime: DefaultActiveCooldown,
            targetSearchRadius: 20f
        );

        RegisterOnHitEquipmentSkill(
            VerdictCircuitRingId,
            (context, actor) =>
            {
                Actor? target = context.TargetActor;
                if (target == null)
                {
                    return;
                }

                string runtimeKey = $"{VerdictMarkKeyPrefix}{target.getID()}";
                EraActiveStatus active = _statuses.ApplyMark(
                    target,
                    EraWorldTime.YearsToWorldTime(3f),
                    stackDelta: 1,
                    maxStacks: 3,
                    runtimeKey: runtimeKey
                );

                if (active.Stacks < 3)
                {
                    return;
                }

                _statuses.Remove(target, runtimeKey);
                _effects.ApplyCurrentHealthDamage(context.ToEffectContext(), target, percent: 0.05f);
            }
        );
    }
}
