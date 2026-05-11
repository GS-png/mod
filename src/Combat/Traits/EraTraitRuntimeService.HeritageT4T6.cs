using System;
using System.Collections.Generic;
using System.Linq;
using EraWheel.Combat.Effects;
using EraWheel.Combat.Statuses;
using EraWheel.Combat.Terrain;
using EraWheel.Combat.Triggers;
using EraWheel.Core.Constants;
using EraWheel.Core.Time;
using EraWheel.Reflection;

namespace EraWheel.Combat.Traits;

public sealed partial class EraTraitRuntimeService
{
    private const string ChainLightningTraitId = "trait_herit_t4_chain_lightning";
    private const string TwinGateTraitId = "trait_herit_t4_twin_gate";
    private const string BloodHookTraitId = "trait_herit_t4_blood_hook";

    private const string MeteorFallTraitId = "trait_herit_t5_meteor_fall";
    private const string QuakeRiftTraitId = "trait_herit_t5_quake_rift";
    private const string ThornCounterTraitId = "trait_herit_t5_thorn_counter";

    private const string RageGiantTraitId = "trait_herit_t6_rage_giant";
    private const string DragonBreathTraitId = "trait_herit_t6_dragon_breath";
    private const string LavaRiverTraitId = "trait_herit_t6_lava_river";

    private const float ChainLightningRadius = 5f;
    private const int ChainLightningMaxBounces = 3;
    private const float ChainLightningDecay = 0.8f;
    private const float ChainLightningBaseMultiplier = 1.8f;

    private const string TwinGateAreaKeyPrefix = "ew_trait_twin_gate_area";
    private static readonly float TwinGateDuration = EraWorldTime.YearsToWorldTime(1f);
    private const float TwinGateRadius = 3f;
    private const float TwinGateCooldown = 2f;
    private const float TwinGateMinDistance = 20f;
    private readonly Dictionary<long, float> _twinGateTeleportLocks = new();

    private const float BloodHookDamageMultiplier = 1.6f;

    private const float MeteorFallRadius = 8f;
    private const float MeteorFallMultiplier = 2.2f;

    private const float QuakeRiftRadius = 6f;
    private const float QuakeRiftDamagePercent = 0.06f;
    private const float QuakeRiftStunDuration = 1.5f;
    private readonly Dictionary<long, float> _thornCounterExpiry = new();
    private const float ThornCounterDuration = 10f;
    private const float ThornCounterReturnPercent = 0.5f;

    private const string RageGiantBuffKey = "ew_trait_rage_giant";
    private const float RageGiantDuration = 15f;

    private const string DragonBreathAreaKeyPrefix = "ew_trait_dragon_breath";
    private const float DragonBreathRadius = 5f;
    private const float DragonBreathDuration = 1f;
    private const float DragonBreathTickInterval = 0.5f;
    private const float DragonBreathDamageMultiplier = 0.9f;

    private const string LavaRiverRuntimeKeyPrefix = "ew_trait_lava_river";
    private const int LavaRiverLength = 10;
    private const float LavaRiverDuration = 15f;
    private const float LavaRiverDamageMultiplier = 1.2f;
    private const float LavaRiverRadius = 1f;

    partial void RegisterHeritageTier4To6Triggers()
    {
        RegisterActiveTraitSkill(
            ChainLightningTraitId,
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

                HandleChainLightning(context, actor, target);
            }
        );

        RegisterActiveTraitSkill(
            TwinGateTraitId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                WorldTile? sourceTile = actor.current_tile;
                if (sourceTile == null)
                {
                    return;
                }

                WorldTile? exitTile = FindTwinGateExit(sourceTile);
                if (exitTile == null)
                {
                    return;
                }

                CreateTwinGateAreas(actor, sourceTile, exitTile);
            }
        );

        RegisterActiveTraitSkill(
            BloodHookTraitId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 16f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 16f);
                if (target == null || target.current_tile == null || actor.current_tile == null)
                {
                    return;
                }

                ApplyBloodHook(context, actor, target);
            }
        );

        RegisterActiveTraitSkill(
            MeteorFallTraitId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 20f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 20f);
                WorldTile? impactTile = target?.current_tile ?? actor.current_tile;
                if (impactTile == null)
                {
                    return;
                }

                global::Meteorite.spawnMeteoriteDisaster(impactTile, actor);
                _effects.ApplyAreaDamage(
                    context,
                    impactTile,
                    MeteorFallRadius,
                    damageMultiplier: MeteorFallMultiplier
                );
            }
        );

        RegisterActiveTraitSkill(
            QuakeRiftTraitId,
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

                Earthquake.startQuake(target.current_tile, EarthquakeType.SmallDisaster);
                string runtimeKey = $"{QuakeRiftTraitId}:{actor.getID()}:{(int)context.WorldTime}";
                _effects.ApplyAreaCurrentHealthDamage(
                    context,
                    target.current_tile,
                    QuakeRiftRadius,
                    QuakeRiftDamagePercent
                );

                foreach (Actor victim in _effects.FindActors(target.current_tile, QuakeRiftRadius, actor, EraEffectTargetRule.Foes))
                {
                    _statuses.ApplyStun(victim, QuakeRiftStunDuration, runtimeKey: runtimeKey);
                }
            }
        );

        RegisterActiveTraitSkill(
            ThornCounterTraitId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                _thornCounterExpiry[actor.getID()] = context.WorldTime + ThornCounterDuration;
            }
        );

        _triggers.RegisterTraitTrigger(
            $"{ThornCounterTraitId}#on_get_hit",
            ThornCounterTraitId,
            EraTriggerType.OnGetHit,
            EraTriggerSubject.Target,
            ThornCounterTraitId,
            (context, actor) =>
            {
                if (!IsThornCounterActive(actor, context.WorldTime))
                {
                    return;
                }

                Actor? attacker = context.SourceActor;
                if (attacker == null || !attacker.isAlive())
                {
                    return;
                }

                if (context.Damage <= 0f)
                {
                    return;
                }

                int retaliateDamage = Math.Max(1, (int)MathF.Round(context.Damage * ThornCounterReturnPercent));
                _effects.ApplyDamage(
                    context.ToEffectContext(),
                    attacker,
                    flatDamage: retaliateDamage
                );
            },
            condition: context => context.TargetActor != null && IsThornCounterActive(context.TargetActor, context.WorldTime)
        );

        RegisterActiveTraitSkill(
            RageGiantTraitId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                ApplyTimedBuff(
                    actor,
                    RageGiantBuffKey,
                    RageGiantDuration,
                    new Dictionary<string, float>
                    {
                        [EraAttributeIds.Scale] = 3f,
                        [EraAttributeIds.MultiplierDamage] = 100f,
                        [EraAttributeIds.MultiplierAttackSpeed] = -40f,
                        [EraAttributeIds.Knockback] = -50f,
                    }
                );
            }
        );

        RegisterActiveTraitSkill(
            DragonBreathTraitId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 18f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 18f);
                WorldTile? centerTile = target?.current_tile ?? actor.current_tile;
                if (centerTile == null)
                {
                    return;
                }

                string areaKey = $"{DragonBreathAreaKeyPrefix}:{actor.getID()}:{(int)context.WorldTime}";
                _terrain.UpsertPeriodicArea(
                    areaKey,
                    actor,
                    actor,
                    centerTile,
                    DragonBreathRadius,
                    DragonBreathDuration,
                    DragonBreathTickInterval,
                    EraEffectTargetRule.Foes,
                    onActorTick: (areaContext, victim) =>
                    {
                        _effects.ApplyDamage(
                            areaContext,
                            victim,
                            damageMultiplier: DragonBreathDamageMultiplier
                        );
                    }
                );

                _terrain.ApplyFireTiles(centerTile, DragonBreathRadius, DragonBreathDuration, areaKey);
            }
        );

        RegisterActiveTraitSkill(
            LavaRiverTraitId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 18f,
            handler: (context, actor) =>
            {
                WorldTile? startTile = actor.current_tile;
                if (startTile == null)
                {
                    return;
                }

                WorldTile? endTile = ResolveLavaRiverDestination(startTile, ResolveEnemyTarget(actor, 18f));
                if (endTile == null)
                {
                    return;
                }

                List<WorldTile> river = BuildLavaRiverPath(startTile, endTile, LavaRiverLength);
                if (river.Count == 0)
                {
                    return;
                }

                string runtimeKey = $"{LavaRiverRuntimeKeyPrefix}:{actor.getID()}:{(int)context.WorldTime}";
                foreach (WorldTile tile in river)
                {
                    _terrain.ApplyLavaTerrain(tile, LavaRiverRadius, LavaRiverDuration, runtimeKey);
                    _effects.ApplyAreaDamage(
                        context,
                        tile,
                        LavaRiverRadius * 1.5f,
                        damageMultiplier: LavaRiverDamageMultiplier
                    );
                }
            }
        );
    }

    private void HandleChainLightning(EraEffectContext context, Actor actor, Actor primary)
    {
        if (primary.current_tile == null)
        {
            return;
        }

        HashSet<long> hitIds = new() { primary.getID() };
        float currentMultiplier = ChainLightningBaseMultiplier;
        global::ActionLibrary.castLightning(actor, primary, primary.current_tile);
        _effects.ApplyDamage(context, primary, damageMultiplier: currentMultiplier);

        int bounces = 0;
        foreach (Actor candidate in _effects.FindActors(primary.current_tile, ChainLightningRadius, actor, EraEffectTargetRule.Foes)
                     .Where(candidate => candidate.current_tile != null && !hitIds.Contains(candidate.getID()))
                     .OrderBy(candidate => DistanceSquared(candidate.current_tile, primary.current_tile)))
        {
            if (bounces >= ChainLightningMaxBounces)
            {
                break;
            }

            WorldTile? tile = candidate.current_tile;
            if (tile == null)
            {
                continue;
            }

            currentMultiplier *= ChainLightningDecay;
            global::ActionLibrary.castLightning(actor, candidate, tile);
            _effects.ApplyDamage(context, candidate, damageMultiplier: currentMultiplier);
            hitIds.Add(candidate.getID());
            bounces++;
        }
    }

    private WorldTile? FindTwinGateExit(WorldTile startTile)
    {
        if (World.world == null)
        {
            return null;
        }

        float minDistanceSquared = TwinGateMinDistance * TwinGateMinDistance;
        for (int i = 0; i < 6; i++)
        {
            WorldTile candidate = Toolbox.getRandomTileWithinDistance(startTile, 60);
            if (candidate == null || !WorldboxReflectionAdapter.IsValidTeleportDestination(candidate))
            {
                continue;
            }

            if (DistanceSquared(startTile, candidate) >= minDistanceSquared)
            {
                return candidate;
            }
        }

        return null;
    }

    private void CreateTwinGateAreas(Actor actor, WorldTile source, WorldTile exit)
    {
        string areaKeyA = $"{TwinGateAreaKeyPrefix}:{actor.getID()}:A";
        string areaKeyB = $"{TwinGateAreaKeyPrefix}:{actor.getID()}:B";

        _terrain.UpsertPeriodicArea(
            areaKeyA,
            actor,
            anchorActor: null,
            source,
            TwinGateRadius,
            TwinGateDuration,
            1f,
            EraEffectTargetRule.All,
            onActorTick: (context, victim) => TryTeleportThroughGate(context, victim, exit),
            onPulse: (_, gateTile) => SpawnTwinGatePulse(gateTile)
        );

        _terrain.UpsertPeriodicArea(
            areaKeyB,
            actor,
            anchorActor: null,
            exit,
            TwinGateRadius,
            TwinGateDuration,
            1f,
            EraEffectTargetRule.All,
            onActorTick: (context, victim) => TryTeleportThroughGate(context, victim, source),
            onPulse: (_, gateTile) => SpawnTwinGatePulse(gateTile)
        );
    }

    private static void SpawnTwinGatePulse(WorldTile gateTile)
    {
        if (gateTile == null)
        {
            return;
        }

        global::EffectsLibrary.spawnAt("fx_teleport_blue", gateTile.posV3, 1.2f);
    }

    private void TryTeleportThroughGate(EraEffectContext context, Actor victim, WorldTile destination)
    {
        if (victim == null || destination == null || !victim.isAlive())
        {
            return;
        }

        long actorId = victim.getID();
        if (_twinGateTeleportLocks.TryGetValue(actorId, out float nextAllowed) && context.WorldTime < nextAllowed)
        {
            return;
        }

        if (!WorldboxReflectionAdapter.TryTeleportActor(victim, destination))
        {
            return;
        }

        _twinGateTeleportLocks[actorId] = context.WorldTime + TwinGateCooldown;
    }

    private void ApplyBloodHook(EraEffectContext context, Actor actor, Actor target)
    {
        WorldTile? actorTile = actor.current_tile;
        WorldTile? targetTile = target.current_tile;
        if (actorTile == null || targetTile == null)
        {
            return;
        }

        _effects.ApplyPullToPoint(context, target, actorTile, forceAmount: 2f);
        if (!WorldboxReflectionAdapter.TryTeleportActor(target, actorTile))
        {
            // If teleport is not reliable, fallback to a short ranged pull so the effect still feels tight.
        }

        global::ActionLibrary.castLightning(actor, target, targetTile);
        _effects.ApplyDamage(context, target, damageMultiplier: BloodHookDamageMultiplier);
    }

    private bool IsThornCounterActive(Actor actor, float worldTime)
    {
        long actorId = actor.getID();
        if (_thornCounterExpiry.TryGetValue(actorId, out float expiresAt))
        {
            if (worldTime >= expiresAt)
            {
                _thornCounterExpiry.Remove(actorId);
                return false;
            }

            return true;
        }

        return false;
    }

    private WorldTile? ResolveLavaRiverDestination(WorldTile start, Actor? target)
    {
        WorldTile? desired = target?.current_tile;
        if (desired != null)
        {
            return desired;
        }

        if (World.world == null)
        {
            return null;
        }

        for (int i = 0; i < 6; i++)
        {
            WorldTile candidate = Toolbox.getRandomTileWithinDistance(start, 18);
            if (candidate == null)
            {
                continue;
            }

            if (DistanceSquared(start, candidate) > 1f)
            {
                return candidate;
            }
        }

        return start;
    }

    private List<WorldTile> BuildLavaRiverPath(WorldTile start, WorldTile end, int segments)
    {
        List<WorldTile> result = new();
        if (segments <= 0)
        {
            return result;
        }

        float dx = end.x - start.x;
        float dy = end.y - start.y;
        WorldTile? lastTile = null;
        for (int step = 1; step <= segments; step++)
        {
            float t = step / (float)segments;
            WorldTile candidate = Toolbox.getTileAt(start.x + dx * t, start.y + dy * t);
            if (candidate == null)
            {
                continue;
            }

            if (lastTile != null && candidate.x == lastTile.x && candidate.y == lastTile.y)
            {
                continue;
            }

            result.Add(candidate);
            lastTile = candidate;
        }

        return result;
    }
}
