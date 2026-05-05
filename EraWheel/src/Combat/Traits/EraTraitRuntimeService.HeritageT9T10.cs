using System;
using System.Collections.Generic;
using System.Linq;
using EraWheel.Combat.Effects;
using EraWheel.Combat.Statuses;
using EraWheel.Combat.Terrain;
using EraWheel.Core.Constants;
using EraWheel.Core.Time;

namespace EraWheel.Combat.Traits;

public sealed partial class EraTraitRuntimeService
{
    private const string HolyJudgementTraitId = "trait_herit_t9_holy_judgement";
    private const string StormEyeTraitId = "trait_herit_t9_eye_of_storm";
    private const string FrostfireNovaTraitId = "trait_herit_t9_frostfire_nova";
    private const string MeteorBarrageTraitId = "trait_herit_t10_meteor_barrage";
    private const string VoidTideTraitId = "trait_herit_t10_void_tide";
    private const string DoomPrismTraitId = "trait_herit_t10_doom_prism";

    private const string HolyJudgementAreaKeyPrefix = "ew_trait_holy_judgement:";
    private const string StormEyeAreaKeyPrefix = "ew_trait_storm_eye:";
    private const string VoidTideForceKeyPrefix = "ew_trait_void_tide_force:";
    private const string DoomPrismAreaKeyPrefix = "ew_trait_doom_prism:";

    private static readonly float HolyJudgementDuration = 10f;
    private static readonly float FrostfireNovaDuration = 15f;
    private static readonly float StormEyeDuration = EraWorldTime.YearsToWorldTime(10f);
    private static readonly float StormEyeSpeedDebuffDuration = 6f;
    private static readonly float VoidTideForceDuration = 1f;
    private static readonly float DoomPrismDuration = 15f;
    private const float StormEyeTickInterval = 5f;
    private const float DoomPrismTickInterval = 5f;

    private readonly Dictionary<string, float> _doomPrismExpiry = new();

    partial void RegisterHeritageTier9To10Triggers()
    {
        RegisterActiveTraitSkill(
            HolyJudgementTraitId,
            chancePercent: 15f,
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

                WorldTile center = target.current_tile;
                string areaKey = HolyJudgementAreaKeyPrefix + actor.getID();
                _terrain.UpsertPeriodicArea(
                    areaKey,
                    actor,
                    anchorActor: null,
                    centerTile: center,
                    radius: 7f,
                    durationWorldTime: HolyJudgementDuration,
                    tickIntervalWorldTime: 2f,
                    targetRule: EraEffectTargetRule.Foes,
                    onActorTick: (tickContext, victim) =>
                    {
                        float multiplier = IsDemonFactionUnit(victim) ? 3f : 1.2f;
                        _effects.ApplyDamage(tickContext, victim, damageMultiplier: multiplier);
                    }
                );
            }
        );

        RegisterActiveTraitSkill(
            StormEyeTraitId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 20f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 22f);
                if (target?.current_tile == null)
                {
                    return;
                }

                WorldTile center = target.current_tile;
                string areaKey = StormEyeAreaKeyPrefix + actor.getID();
                _terrain.UpsertPeriodicArea(
                    areaKey,
                    actor,
                    anchorActor: null,
                    centerTile: center,
                    radius: 15f,
                    durationWorldTime: StormEyeDuration,
                    tickIntervalWorldTime: StormEyeTickInterval,
                    targetRule: EraEffectTargetRule.Foes,
                    onPulse: (_, pulseCenter) =>
                    {
                        List<Actor> foes = _effects.FindActors(pulseCenter, 15f, actor, EraEffectTargetRule.Foes).ToList();
                        Actor? victim = PickRandomBeamTarget(foes, actor, "storm_eye");
                        if (victim?.current_tile == null)
                        {
                            return;
                        }

                        ActionLibrary.castTornado(actor, victim, victim.current_tile);
                        ActionLibrary.castLightning(actor, victim, victim.current_tile);
                    },
                    onActorTick: (tickContext, victim) =>
                    {
                        ApplyTimedDebuff(
                            victim,
                            $"ew_trait_storm_eye_slow:{victim.getID()}",
                            StormEyeSpeedDebuffDuration,
                            new Dictionary<string, float>
                            {
                                [EraAttributeIds.MultiplierSpeed] = -35f,
                            }
                        );
                    }
                );
            }
        );

        RegisterActiveTraitSkill(
            FrostfireNovaTraitId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 20f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 20f);
                WorldTile? center = target?.current_tile ?? actor.current_tile;
                if (center == null)
                {
                    return;
                }

                float innerRadius = 6f;
                float outerRadius = 12f;
                foreach (Actor victim in _effects.FindActors(center, outerRadius, actor, EraEffectTargetRule.Foes))
                {
                    if (victim.current_tile == null)
                    {
                        continue;
                    }

                    float distance = MathF.Sqrt(DistanceSquared(center, victim.current_tile));
                    if (distance <= innerRadius)
                    {
                        ApplyTimedDebuff(
                            victim,
                            $"ew_trait_frostfire_nova_inner:{victim.getID()}",
                            FrostfireNovaDuration,
                            new Dictionary<string, float>
                            {
                                [EraAttributeIds.MultiplierSpeed] = -50f,
                                [EraAttributeIds.MultiplierAttackSpeed] = -50f,
                            }
                        );
                    }
                    else if (distance <= outerRadius)
                    {
                        ActionLibrary.castFire(actor, victim, victim.current_tile);
                    }
                }
            }
        );

        RegisterActiveTraitSkill(
            MeteorBarrageTraitId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 20f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 22f);
                if (target?.current_tile == null)
                {
                    return;
                }

                WorldTile center = target.current_tile;
                for (int i = 0; i < 3; i++)
                {
                    WorldTile impactTile = i == 0
                        ? center
                        : Toolbox.getRandomTileWithinDistance(center, 12) ?? center;
                    global::Meteorite.spawnMeteoriteDisaster(impactTile, actor);
                }
            }
        );

        RegisterActiveTraitSkill(
            VoidTideTraitId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 20f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 22f);
                WorldTile? center = target?.current_tile ?? actor.current_tile;
                if (center == null)
                {
                    return;
                }

                string forceKey = VoidTideForceKeyPrefix + actor.getID();
                _terrain.CreateBarrierArea(
                    forceKey,
                    actor,
                    anchorActor: null,
                    centerTile: center,
                    radius: 15f,
                    durationWorldTime: VoidTideForceDuration,
                    tickIntervalWorldTime: 1f,
                    forceAmount: 6f
                );

                _effects.ApplyAreaCurrentHealthDamage(
                    context,
                    center,
                    15f,
                    percent: 0.1f,
                    targetRule: EraEffectTargetRule.Foes,
                    attackType: AttackType.Other
                );
            }
        );

        RegisterActiveTraitSkill(
            DoomPrismTraitId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 22f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 24f);
                WorldTile? center = target?.current_tile ?? actor.current_tile;
                if (center == null)
                {
                    return;
                }

                string areaKey = DoomPrismAreaKeyPrefix + actor.getID();
                _doomPrismExpiry[areaKey] = context.WorldTime + DoomPrismDuration;
                _terrain.UpsertPeriodicArea(
                    areaKey,
                    actor,
                    anchorActor: null,
                    centerTile: center,
                    radius: 15f,
                    durationWorldTime: DoomPrismDuration,
                    tickIntervalWorldTime: DoomPrismTickInterval,
                    targetRule: EraEffectTargetRule.All,
                    onPulse: (tickContext, _) =>
                    {
                        bool shouldFinalBurst = _doomPrismExpiry.TryGetValue(areaKey, out float expiresAt)
                            && tickContext.WorldTime >= expiresAt - DoomPrismTickInterval;

                        if (shouldFinalBurst && _doomPrismExpiry.Remove(areaKey))
                        {
                            _effects.ApplyAreaDamage(
                                tickContext,
                                center,
                                15f,
                                damageMultiplier: 1f,
                                targetRule: EraEffectTargetRule.Foes
                            );
                            return;
                        }

                        EmitCrystalBeams(actor, tickContext, center);
                    }
                );
            }
        );
    }

    private void EmitCrystalBeams(Actor caster, EraEffectContext context, WorldTile center)
    {
        List<Actor> foes = _effects.FindActors(center, 15f, caster, EraEffectTargetRule.Foes).ToList();
        if (foes.Count == 0)
        {
            return;
        }

        for (int i = 0; i < 6; i++)
        {
            Actor? victim = PickRandomBeamTarget(foes, caster, $"doom_prism_beam:{i}");
            if (victim == null || victim.current_tile == null)
            {
                continue;
            }

            ActionLibrary.castLightning(caster, victim, victim.current_tile);
            _effects.ApplyDamage(context, victim, damageMultiplier: 2f, attackType: AttackType.Other);
        }
    }

    private Actor? PickRandomBeamTarget(IReadOnlyList<Actor> candidates, Actor caster, string scopeSuffix)
    {
        if (candidates.Count == 0)
        {
            return null;
        }

        int index = _stableRandom.NextInt(
            "trait_runtime_beam",
            $"{scopeSuffix}:{caster.getID()}:{(int)ReadWorldTime()}",
            0,
            candidates.Count
        );
        index = Math.Clamp(index, 0, candidates.Count - 1);
        return candidates[index];
    }

    private static bool IsDemonFactionUnit(Actor actor)
    {
        if (actor.asset != null && actor.asset.id.StartsWith("demon_", StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }

        string? kingdomId = actor.kingdom?.asset?.id;
        return !string.IsNullOrWhiteSpace(kingdomId)
               && kingdomId.StartsWith("ew_demon_kingdom_", StringComparison.OrdinalIgnoreCase);
    }
}
