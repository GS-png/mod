using System;
using System.Collections.Generic;
using System.Linq;
using EraWheel.Combat.Effects;
using EraWheel.Combat.Statuses;
using EraWheel.Combat.Terrain;
using EraWheel.Combat.Triggers;
using EraWheel.Core;
using EraWheel.Core.Constants;
using EraWheel.Core.Time;
using EraWheel.Reflection;
using NeoModLoader.General;

namespace EraWheel.Combat.Demons;

public sealed partial class EraDemonSkillRuntimeService
{
    private const string TimeDistorterId = "demon_time_distorter";
    private const string ChaosFlameId = "demon_chaos_flame";
    private const string TimeDistorterS2VulnerabilityKey = "ew_time_distorter_s2_vulnerability";
    private const string TimeDistorterShadowStatsKey = "ew_time_distorter_shadow_stats";
    private const string ChaosFlameMinionBuffKey = "ew_chaos_flame_minion_stats";
    private const string FireElementalAssetId = "fire_elemental";
    private const string FireSkullAssetId = "skeleton";

    private static readonly float[] TimeDistorterThresholdPercents = { 80f, 60f, 40f, 20f };
    private static readonly Random RandomGen = new();

    private readonly Dictionary<long, HashSet<float>> _timeDistorterTriggeredThresholds = new();
    private readonly Dictionary<long, List<TimeDistorterDamageEntry>> _timeDistorterDamageHistory = new();
    private readonly Dictionary<long, float> _timeDistorterShadowExpiry = new();
    private readonly Dictionary<long, (int X, int Y)> _chaosFlameLastTiles = new();
    private readonly HashSet<long> _chaosFlameMinionIds = new();

    private sealed class TimeDistorterDamageEntry
    {
        public TimeDistorterDamageEntry(float timestamp, float damage)
        {
            Timestamp = timestamp;
            Damage = damage;
        }

        public float Timestamp { get; }
        public float Damage { get; }
    }

    private void RegisterTimeDistorter()
    {
        _triggers.Register(
            new EraTriggerDefinition(
                "demon_time_distorter#p0_tracking",
                TimeDistorterId,
                EraTriggerType.OnGetHit,
                context =>
                {
                    Actor? actor = context.TargetActor;
                    if (actor == null || actor.asset?.id != TimeDistorterId || !actor.isAlive())
                    {
                        return;
                    }

                    RecordTimeDistorterDamage(actor, Math.Max(0f, context.Damage), context.WorldTime);
                    HandleTimeDistorterHealthThreshold(actor);
                }
            )
        );

        _triggers.Register(
            new EraTriggerDefinition(
                "demon_time_distorter#s2_vulnerability",
                TimeDistorterId,
                EraTriggerType.OnGetHit,
                context =>
                {
                    Actor? victim = context.TargetActor;
                    if (victim == null || victim.asset?.id != TimeDistorterId)
                    {
                        return;
                    }

                    if (!_statuses.TryGetStatus(victim, TimeDistorterS2VulnerabilityKey, out EraActiveStatus? active) ||
                        active == null)
                    {
                        return;
                    }

                    int extraDamage = Math.Max(1, (int)MathF.Round(context.Damage * 0.2f));
                    _effects.ApplyDamage(context.ToEffectContext(), victim, flatDamage: extraDamage);
                }
            )
        );

        _triggers.Register(
            new EraTriggerDefinition(
                "demon_time_distorter#shadow_lifecycle",
                TimeDistorterId,
                EraTriggerType.OnTick,
                context =>
                {
                    Actor? shadow = context.SourceActor;
                    if (shadow == null || !_timeDistorterShadowExpiry.TryGetValue(shadow.getID(), out float expires))
                    {
                        return;
                    }

                    if (context.WorldTime < expires)
                    {
                        return;
                    }

                    shadow.changeHealth(-shadow.getHealth());
                    _timeDistorterShadowExpiry.Remove(shadow.getID());
                },
                condition: context => context.SourceActor != null &&
                    _timeDistorterShadowExpiry.ContainsKey(context.SourceActor.getID())
            )
        );

        _triggers.Register(
            new EraTriggerDefinition(
                "demon_time_distorter#shadow_cleanup",
                TimeDistorterId,
                EraTriggerType.OnDeath,
                context =>
                {
                    if (context.TargetActor != null)
                    {
                        _timeDistorterShadowExpiry.Remove(context.TargetActor.getID());
                    }
                }
            )
        );

        RegisterTickSkill(
            "demon_time_distorter#s1",
            TimeDistorterId,
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

                _effects.ApplyDamage(context, target, damageMultiplier: 0.8f);
                _effects.ApplyAreaStatus(
                    context,
                    target.current_tile,
                    radius: 3f,
                    application: new EraStatusApplication(
                        EraStatusKind.TimedDebuff,
                        EraWorldTime.YearsToWorldTime(2f),
                        runtimeKey: "ew_time_distorter_s1_slow",
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
            "demon_time_distorter#s2",
            TimeDistorterId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                string runtimeKey = $"demon_time_distorter#s2_area:{actor.getID()}";
                _terrain.UpsertPeriodicArea(
                    runtimeKey,
                    actor,
                    actor,
                    actor.current_tile,
                    radius: 5f,
                    durationWorldTime: 4f,
                    tickIntervalWorldTime: 2f,
                    targetRule: EraEffectTargetRule.Foes,
                    onActorTick: (areaContext, target) =>
                    {
                        _effects.ApplyCurrentHealthDamage(areaContext, target, percent: 0.02f);
                    }
                );

                _statuses.ApplyTimedDebuff(
                    actor,
                    4f,
                    statModifiers: new Dictionary<string, float>(),
                    runtimeKey: TimeDistorterS2VulnerabilityKey
                );
            }
        );

        RegisterTickSkill(
            "demon_time_distorter#s3",
            TimeDistorterId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                float recentDamage = GetTimeDistorterDamageSince(actor, context.WorldTime, 3f);
                if (recentDamage <= 0f)
                {
                    return;
                }

                int healAmount = Math.Max(1, (int)MathF.Round(recentDamage * 0.5f));
                _effects.ApplyHealing(context, actor, flatAmount: healAmount);
            }
        );

        RegisterTickSkill(
            "demon_time_distorter#s4",
            TimeDistorterId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 10f,
            handler: (context, actor) =>
            {
                Actor? target = FindFarthestEnemy(actor, 10f);
                if (target?.current_tile == null || actor.current_tile == null)
                {
                    return;
                }

                WorldTile sourceTile = actor.current_tile;
                WorldTile targetTile = target.current_tile;
                WorldboxReflectionAdapter.TryTeleportActor(target, sourceTile);
                WorldboxReflectionAdapter.TryTeleportActor(actor, targetTile);
            }
        );

        RegisterTickSkill(
            "demon_time_distorter#s5",
            TimeDistorterId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                IReadOnlyList<Actor> shadow = _effects.SummonUnits(
                    context,
                    ZombieAssetId,
                    actor.current_tile,
                    count: 1,
                    joinSourceKingdom: true
                );

                foreach (Actor clone in shadow)
                {
                    _timeDistorterShadowExpiry[clone.getID()] = context.WorldTime + 5f;
                    _statuses.ApplyTimedBuff(
                        clone,
                        durationWorldTime: 5f,
                        statModifiers: new Dictionary<string, float>
                        {
                            [EraAttributeIds.Health] = 5000f,
                            [EraAttributeIds.MultiplierDamage] = 100f,
                            [EraAttributeIds.Damage] = 20f,
                        },
                        runtimeKey: TimeDistorterShadowStatsKey
                    );
                    _statuses.ApplySilence(clone, 5f, runtimeKey: "ew_time_distorter_shadow_silence");
                    clone.changeHealth(5000);
                }
            }
        );

        RegisterTickSkill(
            "demon_time_distorter#s6",
            TimeDistorterId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(10f),
            manaCost: 15,
            requiresAdvent: true,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                _effects.ApplyAreaDamage(context, actor.current_tile, radius: 20f, damageMultiplier: 0.5f);

                List<Actor> foes = _effects.FindActors(actor.current_tile, 20f, actor, EraEffectTargetRule.Foes).ToList();
                foreach (Actor foe in foes)
                {
                    TeleportActorToRandomNearby(foe, 15f);
                }
            }
        );
    }

    private void RegisterChaosFlame()
    {
        _triggers.RegisterActorAssetTrigger(
            "demon_chaos_flame#p0_lava",
            ChaosFlameId,
            EraTriggerType.OnTick,
            EraTriggerSubject.Source,
            ChaosFlameId,
            (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                (int x, int y) currentTile = (actor.current_tile.x, actor.current_tile.y);
                if (!_chaosFlameLastTiles.TryGetValue(actor.getID(), out (int x, int y) previousTile))
                {
                    _chaosFlameLastTiles[actor.getID()] = currentTile;
                    return;
                }

                if (previousTile == currentTile)
                {
                    return;
                }

                _chaosFlameLastTiles[actor.getID()] = currentTile;

                if (RandomGen.NextDouble() > 0.1)
                {
                    return;
                }

                string runtimeKey = $"{ChaosFlameId}#p0_lava:{actor.current_tile.x}:{actor.current_tile.y}";
                _terrain.ApplyLavaTerrain(
                    actor.current_tile,
                    radius: 1f,
                    durationWorldTime: EraWorldTime.MonthToWorldTime(1f),
                    runtimeKey: runtimeKey
                );
            }
        );

        RegisterTickSkill(
            "demon_chaos_flame#s1",
            ChaosFlameId,
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

                _effects.ApplyDamage(context, target, damageMultiplier: 1.8f);
                _effects.ApplyKnockback(context, target, forceMultiplier: 5f);
                _terrain.ApplyFireTiles(
                    target.current_tile,
                    radius: 3f,
                    durationWorldTime: EraWorldTime.MonthToWorldTime(1f),
                    runtimeKey: $"demon_chaos_flame#s1_fire:{target.current_tile.x}:{target.current_tile.y}"
                );
            }
        );

        RegisterTickSkill(
            "demon_chaos_flame#s2",
            ChaosFlameId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                for (int index = 0; index < 2; index++)
                {
                    WorldTile? impact = ResolveRandomWalkableTile(actor.current_tile, 15f);
                    if (impact == null)
                    {
                        continue;
                    }

                    _effects.ApplyAreaDamage(context, impact, radius: 8f, damageMultiplier: 0.7f);
                    _terrain.ApplyFireTiles(
                        impact,
                        radius: 4f,
                        durationWorldTime: EraWorldTime.MonthToWorldTime(2f),
                        runtimeKey: $"demon_chaos_flame#s2_meteor:{impact.x}:{impact.y}:{index}"
                    );
                }
            }
        );

        RegisterTickSkill(
            "demon_chaos_flame#s3",
            ChaosFlameId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                _effects.ApplyAreaDamage(context, actor.current_tile, radius: 6f, damageMultiplier: 1.8f);
            }
        );

        RegisterTickSkill(
            "demon_chaos_flame#s4",
            ChaosFlameId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                HashSet<long> visited = new();
                Actor? current = ResolveEnemyTarget(actor, 20f);
                float damageMultiplier = 1f;

                while (current != null && visited.Count < 4)
                {
                    if (current.current_tile != null)
                    {
                        _effects.ApplyDamage(context, current, damageMultiplier: damageMultiplier);
                        _statuses.ApplyTimedDebuff(
                            current,
                            3f,
                            new Dictionary<string, float>
                            {
                                [EraAttributeIds.MultiplierSpeed] = -50f,
                            },
                            runtimeKey: "ew_chaos_flame_s4_slow"
                        );
                    }

                    visited.Add(current.getID());
                    damageMultiplier = Math.Max(0.2f, damageMultiplier - 0.2f);
                    current = ResolveLeadingEnemy(current, 3f, visited);
                }
            }
        );

        RegisterTickSkill(
            "demon_chaos_flame#s5",
            ChaosFlameId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                SummonChaosFlameMinions(context, actor, FireElementalAssetId, 5);
                SummonChaosFlameMinions(context, actor, FireSkullAssetId, 5);
            }
        );

        RegisterTickSkill(
            "demon_chaos_flame#s6",
            ChaosFlameId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(10f),
            manaCost: 15,
            requiresAdvent: true,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                _effects.ApplyAreaDamage(context, actor.current_tile, radius: 20f, damageMultiplier: 1f);

                ConvertPartialTilesToLava(actor.current_tile, 20f, 0.3f, EraWorldTime.MonthToWorldTime(3f));
                _effects.ApplyHealing(context, actor, percentOfMaxHealth: 0.1f);
            }
        );

        _triggers.Register(
            new EraTriggerDefinition(
                "demon_chaos_flame#s5_minion_explosion",
                ChaosFlameId,
                EraTriggerType.OnDeath,
                context =>
                {
                    Actor? minion = context.TargetActor;
                    if (minion == null || !_chaosFlameMinionIds.Remove(minion.getID()))
                    {
                        return;
                    }

                    if (minion.current_tile == null)
                    {
                        return;
                    }

                    EraEffectContext explosionContext = new(
                        minion,
                        minion,
                        context.WorldTime,
                        "demon_chaos_flame#s5_minion_explosion",
                        EraTriggerType.OnDeath
                    );
                    _effects.ApplyAreaDamage(explosionContext, minion.current_tile, radius: 3f, damageMultiplier: 0.5f);
                }
            )
        );
    }

    private void RecordTimeDistorterDamage(Actor actor, float damage, float worldTime)
    {
        if (damage <= 0f)
        {
            return;
        }

        if (!_timeDistorterDamageHistory.TryGetValue(actor.getID(), out List<TimeDistorterDamageEntry>? history))
        {
            history = new List<TimeDistorterDamageEntry>();
            _timeDistorterDamageHistory[actor.getID()] = history;
        }

        history.Add(new TimeDistorterDamageEntry(worldTime, damage));
    }

    private float GetTimeDistorterDamageSince(Actor actor, float worldTime, float window)
    {
        if (!_timeDistorterDamageHistory.TryGetValue(actor.getID(), out List<TimeDistorterDamageEntry>? history))
        {
            return 0f;
        }

        float cutoff = worldTime - window;
        float total = 0f;
        for (int index = history.Count - 1; index >= 0; index--)
        {
            TimeDistorterDamageEntry entry = history[index];
            if (entry.Timestamp < cutoff)
            {
                history.RemoveAt(index);
                continue;
            }

            total += entry.Damage;
        }

        if (history.Count == 0)
        {
            _timeDistorterDamageHistory.Remove(actor.getID());
        }

        return total;
    }

    private void HandleTimeDistorterHealthThreshold(Actor actor)
    {
        if (actor.current_tile == null || actor.getMaxHealth() <= 0)
        {
            return;
        }

        float percent = actor.getHealth() / (float)actor.getMaxHealth() * 100f;
        HashSet<float> triggered = _timeDistorterTriggeredThresholds.TryGetValue(actor.getID(), out HashSet<float>? bucket)
            ? bucket
            : (_timeDistorterTriggeredThresholds[actor.getID()] = new HashSet<float>());

        foreach (float threshold in TimeDistorterThresholdPercents)
        {
            if (percent > threshold || !triggered.Add(threshold))
            {
                continue;
            }

            TriggerTimeDistorterThreshold(actor);
            break;
        }
    }

    private void TriggerTimeDistorterThreshold(Actor actor)
    {
        if (actor.current_tile == null)
        {
            return;
        }

        WorldTile destination = ResolveNearbyTile(actor.current_tile, 6f) ?? actor.current_tile;
        WorldboxReflectionAdapter.TryTeleportActor(actor, destination);
        ActionLibrary.castCure(actor, actor, actor.current_tile);
    }

    private static Actor? ResolveLeadingEnemy(Actor? actor, float maxDistance, HashSet<long> visited)
    {
        if (actor == null || actor.current_tile == null || World.world?.units == null)
        {
            return null;
        }

        float maxDistanceSquared = maxDistance * maxDistance;
        Actor? best = null;
        float bestDistance = float.MaxValue;
        foreach (Actor candidate in World.world.units)
        {
            if (candidate == null || !candidate.isAlive() || candidate.current_tile == null || !actor.areFoes(candidate))
            {
                continue;
            }

            long id = candidate.getID();
            if (visited.Contains(id))
            {
                continue;
            }

            float dx = candidate.current_tile.x - actor.current_tile.x;
            float dy = candidate.current_tile.y - actor.current_tile.y;
            float distanceSquared = dx * dx + dy * dy;
            if (distanceSquared > maxDistanceSquared || distanceSquared >= bestDistance)
            {
                continue;
            }

            bestDistance = distanceSquared;
            best = candidate;
        }

        return best;
    }

    private static Actor? FindFarthestEnemy(Actor actor, float maxDistance)
    {
        if (actor.current_tile == null || World.world?.units == null)
        {
            return null;
        }

        float maxDistanceSquared = maxDistance * maxDistance;
        Actor? best = null;
        float bestDistanceSquared = -1f;
        foreach (Actor candidate in World.world.units)
        {
            if (candidate == null || !candidate.isAlive() || candidate.current_tile == null || !actor.areFoes(candidate))
            {
                continue;
            }

            float dx = candidate.current_tile.x - actor.current_tile.x;
            float dy = candidate.current_tile.y - actor.current_tile.y;
            float distanceSquared = dx * dx + dy * dy;
            if (distanceSquared > maxDistanceSquared || distanceSquared <= bestDistanceSquared)
            {
                continue;
            }

            bestDistanceSquared = distanceSquared;
            best = candidate;
        }

        return best;
    }

    private static WorldTile? ResolveRandomWalkableTile(WorldTile center, float radius)
    {
        if (center == null)
        {
            return null;
        }

        List<WorldTile> candidates = new() { center };
        int searchRadius = Math.Max(1, (int)MathF.Ceiling(radius));
        foreach (WorldTile tile in center.getTilesAround(searchRadius))
        {
            if (tile == null || tile.is_liquid || tile.hasBuilding())
            {
                continue;
            }

            candidates.Add(tile);
        }

        if (candidates.Count == 0)
        {
            return center;
        }

        return candidates[RandomGen.Next(candidates.Count)];
    }

    private void TeleportActorToRandomNearby(Actor actor, float radius)
    {
        if (actor.current_tile == null)
        {
            return;
        }

        WorldTile? destination = ResolveRandomWalkableTile(actor.current_tile, radius);
        if (destination == null)
        {
            return;
        }

        WorldboxReflectionAdapter.TryTeleportActor(actor, destination);
    }

    private void SummonChaosFlameMinions(EraEffectContext context, Actor actor, string assetId, int count)
    {
        if (actor.current_tile == null || count <= 0)
        {
            return;
        }

        IReadOnlyList<Actor> minions = _effects.SummonUnits(
            context,
            assetId,
            actor.current_tile,
            count,
            joinSourceKingdom: true
        );

        foreach (Actor minion in minions)
        {
            _chaosFlameMinionIds.Add(minion.getID());
            _statuses.ApplyTimedBuff(
                minion,
                EraWorldTime.YearsToWorldTime(1000f),
                new Dictionary<string, float>
                {
                    [EraAttributeIds.Health] = 300f,
                    [EraAttributeIds.Damage] = 20f,
                },
                runtimeKey: ChaosFlameMinionBuffKey
            );
            minion.changeHealth(300);
        }
    }

    private void ConvertPartialTilesToLava(WorldTile center, float radius, float percent, float durationWorldTime)
    {
        List<WorldTile> tiles = CollectTilesInRadius(center, radius);
        if (tiles.Count == 0)
        {
            return;
        }

        int toConvert = Math.Max(1, (int)MathF.Round(tiles.Count * percent));
        for (int index = 0; index < toConvert && tiles.Count > 0; index++)
        {
            int tileIndex = RandomGen.Next(tiles.Count);
            WorldTile tile = tiles[tileIndex];
            tiles.RemoveAt(tileIndex);
            _terrain.ApplyLavaTerrain(
                tile,
                radius: 0.75f,
                durationWorldTime,
                runtimeKey: $"demon_chaos_flame#s6_lava:{tile.x}:{tile.y}:{index}"
            );
        }
    }

    private static List<WorldTile> CollectTilesInRadius(WorldTile center, float radius)
    {
        List<WorldTile> result = new() { center };
        int searchRadius = Math.Max(1, (int)MathF.Ceiling(radius));
        foreach (WorldTile tile in center.getTilesAround(searchRadius))
        {
            if (tile == null)
            {
                continue;
            }

            float dx = tile.x - center.x;
            float dy = tile.y - center.y;
            if ((dx * dx) + (dy * dy) <= radius * radius)
            {
                result.Add(tile);
            }
        }

        return result;
    }
}
