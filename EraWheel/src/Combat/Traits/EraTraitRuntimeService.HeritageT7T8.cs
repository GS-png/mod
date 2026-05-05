using System;
using System.Collections.Generic;
using EraWheel.Combat.Effects;
using EraWheel.Combat.Statuses;
using EraWheel.Combat.Terrain;
using EraWheel.Core.Constants;
using EraWheel.Core.Time;
using EraWheel.Reflection;

namespace EraWheel.Combat.Traits;

public sealed partial class EraTraitRuntimeService
{
    private const string FrostTempestTraitId = "trait_herit_t7_frost_tempest";
    private const string PhoenixStrikeTraitId = "trait_herit_t7_phoenix_strike";
    private const string ShadowExecuteTraitId = "trait_herit_t7_shadow_execute";
    private const string GravityWellTraitId = "trait_herit_t8_gravity_well";
    private const string AbsoluteZeroTraitId = "trait_herit_t8_absolute_zero";
    private const string RockGolemTraitId = "trait_herit_t8_rock_golem";
    private const string RockGolemAssetId = "crystal_golem";

    private const string FrostTempestAreaKeyPrefix = "ew_trait_frost_tempest:";
    private const string PhoenixStrikeFireAreaKeyPrefix = "ew_trait_phoenix_fire:";
    private const string GravityWellAreaKeyPrefix = "ew_trait_gravity_well:";
    private const string AbsoluteZeroAreaKeyPrefix = "ew_trait_absolute_zero_field:";
    private const string AbsoluteZeroTerrainKeyPrefix = "ew_trait_absolute_zero_tile:";
    private const string RockGolemStatusKeyPrefix = "ew_trait_rock_golem:";

    private static readonly float FrostTempestDuration = 15f;
    private static readonly float FrostTempestTickInterval = 2f;
    private static readonly float PhoenixFireDuration = 12f;
    private static readonly float GravityWellDuration = 20f;
    private static readonly float GravityWellTickInterval = 4f;
    private static readonly float AbsoluteZeroDuration = 10f;
    private static readonly float AbsoluteZeroTickInterval = 3f;
    private static readonly float RockGolemDuration = 30f;

    partial void RegisterHeritageTier7To8Triggers()
    {
        RegisterActiveTraitSkill(
            FrostTempestTraitId,
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

                ActionLibrary.castTornado(actor, target, target.current_tile);
                CreateFrostTempestArea(context, actor, target.current_tile);
            }
        );

        RegisterActiveTraitSkill(
            PhoenixStrikeTraitId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 20f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 20f);
                WorldTile? landing = target?.current_tile ?? actor.current_tile;
                if (landing == null)
                {
                    return;
                }

                ActionLibrary.castFire(actor, target, landing);
                _effects.ApplyAreaDamage(
                    context,
                    landing,
                    radius: 10f,
                    damageMultiplier: 2.4f,
                    targetRule: EraEffectTargetRule.Foes
                );
                CreatePhoenixFirefield(context, actor, landing);
            }
        );

        RegisterActiveTraitSkill(
            ShadowExecuteTraitId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 5f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 5f);
                if (target?.current_tile == null)
                {
                    return;
                }

                WorldTile? behindTile = FindTileBehindTarget(actor, target);
                if (behindTile == null)
                {
                    return;
                }

                if (!WorldboxReflectionAdapter.TryTeleportActor(actor, behindTile))
                {
                    return;
                }

                _effects.ApplyDamage(context, target, damageMultiplier: 3f);
            }
        );

        RegisterActiveTraitSkill(
            GravityWellTraitId,
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

                CreateGravityWell(context, actor, target.current_tile);
            }
        );

        RegisterActiveTraitSkill(
            AbsoluteZeroTraitId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                WorldTile? center = actor.current_tile;
                if (center == null)
                {
                    return;
                }

                string terrainKey = AbsoluteZeroTerrainKeyPrefix + actor.getID();
                _terrain.ApplyIceTerrain(center, 10f, AbsoluteZeroDuration, terrainKey);
                _effects.ApplyAreaDamage(
                    context,
                    center,
                    radius: 10f,
                    damageMultiplier: 1.6f,
                    targetRule: EraEffectTargetRule.Foes
                );
                CreateAbsoluteZeroField(context, actor, center);
            }
        );

        RegisterActiveTraitSkill(
            RockGolemTraitId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                WorldTile? spawnTile = actor.current_tile;
                if (spawnTile == null || actor.asset == null)
                {
                    return;
                }

                IReadOnlyList<Actor> golems = _effects.SummonUnits(
                    context,
                    RockGolemAssetId,
                    spawnTile,
                    count: 1,
                    joinSourceKingdom: true
                );

                foreach (Actor golem in golems)
                {
                    ApplyTimedBuff(
                        golem,
                        RockGolemStatusKeyPrefix + golem.getID(),
                        RockGolemDuration,
                        new Dictionary<string, float>
                        {
                            [EraAttributeIds.MultiplierHealth] = -50f,
                            [EraAttributeIds.MultiplierDamage] = -50f,
                        }
                    );
                    _mirrorCloneExpiry[golem.getID()] = context.WorldTime + RockGolemDuration;
                }
            }
        );
    }

    private void CreateFrostTempestArea(EraEffectContext context, Actor actor, WorldTile center)
    {
        string runtimeKey = FrostTempestAreaKeyPrefix + actor.getID();
        _terrain.UpsertPeriodicArea(
            runtimeKey,
            actor,
            anchorActor: null,
            centerTile: center,
            radius: 5f,
            durationWorldTime: FrostTempestDuration,
            tickIntervalWorldTime: FrostTempestTickInterval,
            targetRule: EraEffectTargetRule.Foes,
            onActorTick: (tickContext, victim) =>
            {
                _effects.ApplyDamage(tickContext, victim, damageMultiplier: 1.8f);
                ApplyTimedDebuff(
                    victim,
                    runtimeKey + ":slow",
                    FrostTempestTickInterval + 0.5f,
                    new Dictionary<string, float>
                    {
                        [EraAttributeIds.MultiplierSpeed] = -30f,
                    }
                );
            }
        );
    }

    private void CreatePhoenixFirefield(EraEffectContext context, Actor actor, WorldTile center)
    {
        string runtimeKey = PhoenixStrikeFireAreaKeyPrefix + actor.getID();
        _terrain.UpsertPeriodicArea(
            runtimeKey,
            actor,
            anchorActor: null,
            centerTile: center,
            radius: 10f,
            durationWorldTime: PhoenixFireDuration,
            tickIntervalWorldTime: FrostTempestTickInterval,
            targetRule: EraEffectTargetRule.Foes,
            onActorTick: (tickContext, victim) =>
            {
                _effects.ApplyDamage(
                    tickContext,
                    victim,
                    damageMultiplier: 0.6f,
                    attackType: AttackType.Fire
                );
                ApplyTimedDebuff(
                    victim,
                    runtimeKey + ":burn",
                    FrostTempestTickInterval + 0.5f,
                    new Dictionary<string, float>
                    {
                        [EraAttributeIds.MultiplierAttackSpeed] = -20f,
                    }
                );
            }
        );
    }

    private void CreateGravityWell(EraEffectContext context, Actor actor, WorldTile center)
    {
        string runtimeKey = GravityWellAreaKeyPrefix + actor.getID();
        _terrain.UpsertPeriodicArea(
            runtimeKey,
            actor,
            anchorActor: null,
            centerTile: center,
            radius: 5f,
            durationWorldTime: GravityWellDuration,
            tickIntervalWorldTime: GravityWellTickInterval,
            targetRule: EraEffectTargetRule.Foes,
            onActorTick: (tickContext, victim) =>
            {
                _effects.ApplyPull(tickContext, victim, forceAmount: 3f);
                _effects.ApplyDamage(tickContext, victim, damageMultiplier: 0.3f);
                ApplyTimedDebuff(
                    victim,
                    runtimeKey + ":slow",
                    GravityWellTickInterval + 0.5f,
                    new Dictionary<string, float>
                    {
                        [EraAttributeIds.MultiplierSpeed] = -80f,
                    }
                );
            }
        );
    }

    private void CreateAbsoluteZeroField(EraEffectContext context, Actor actor, WorldTile center)
    {
        string runtimeKey = AbsoluteZeroAreaKeyPrefix + actor.getID();
        _terrain.UpsertPeriodicArea(
            runtimeKey,
            actor,
            anchorActor: null,
            centerTile: center,
            radius: 10f,
            durationWorldTime: AbsoluteZeroDuration,
            tickIntervalWorldTime: AbsoluteZeroTickInterval,
            targetRule: EraEffectTargetRule.Foes,
            onActorTick: (tickContext, victim) =>
            {
                _effects.ApplyDamage(tickContext, victim, damageMultiplier: 1.6f);
                ApplyTimedDebuff(
                    victim,
                    runtimeKey + ":freeze",
                    AbsoluteZeroTickInterval + 0.5f,
                    new Dictionary<string, float>
                    {
                        [EraAttributeIds.MultiplierAttackSpeed] = -80f,
                    }
                );
            }
        );
    }

    private static WorldTile? FindTileBehindTarget(Actor actor, Actor target)
    {
        WorldTile? targetTile = target.current_tile;
        WorldTile? actorTile = actor.current_tile;
        if (targetTile == null || actorTile == null)
        {
            return null;
        }

        float directionX = targetTile.x - actorTile.x;
        float directionY = targetTile.y - actorTile.y;
        float bestScore = float.NegativeInfinity;
        WorldTile? bestCandidate = null;

        foreach (WorldTile candidate in targetTile.getTilesAround(2))
        {
            if (candidate == null || candidate == targetTile)
            {
                continue;
            }

            float dot = (candidate.x - targetTile.x) * directionX + (candidate.y - targetTile.y) * directionY;
            float distance = DistanceSquared(candidate, actorTile);
            if (distance <= 0f)
            {
                continue;
            }

            if (dot > bestScore)
            {
                bestScore = dot;
                bestCandidate = candidate;
            }
        }

        return bestCandidate ?? targetTile;
    }
}
