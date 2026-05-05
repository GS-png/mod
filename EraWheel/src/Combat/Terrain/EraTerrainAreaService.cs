using System;
using System.Collections.Generic;
using System.Linq;
using EraWheel.Combat.Effects;
using EraWheel.Core.Constants;
using EraWheel.Reflection;

namespace EraWheel.Combat.Terrain;

public sealed class EraTerrainAreaService
{
    private sealed class EraTileSnapshot
    {
        public WorldTile Tile { get; set; } = null!;
        public TileType? MainType { get; set; }
        public TopTileType? TopType { get; set; }
        public bool HadFire { get; set; }
    }

    private sealed class EraTimedTerrainPatch
    {
        public string RuntimeKey { get; set; } = string.Empty;
        public float ExpiresAtWorldTime { get; set; }
        public List<EraTileSnapshot> Tiles { get; set; } = new();
    }

    private sealed class EraPeriodicArea
    {
        public string RuntimeKey { get; set; } = string.Empty;
        public long? SourceId { get; set; }
        public long? AnchorActorId { get; set; }
        public int CenterTileX { get; set; }
        public int CenterTileY { get; set; }
        public float Radius { get; set; }
        public float TickIntervalWorldTime { get; set; }
        public float NextTickWorldTime { get; set; }
        public float ExpiresAtWorldTime { get; set; }
        public EraEffectTargetRule TargetRule { get; set; }
        public Action<EraEffectContext, WorldTile>? OnPulse { get; set; }
        public Action<EraEffectContext, Actor>? OnActorTick { get; set; }
    }

    private readonly Dictionary<string, EraTimedTerrainPatch> _terrainPatches = new();
    private readonly Dictionary<string, EraPeriodicArea> _areas = new();

    public void Update(float currentWorldTime)
    {
        UpdateTerrainPatches(currentWorldTime);
        UpdateAreas(currentWorldTime);
    }

    public void UpsertPeriodicArea(
        string runtimeKey,
        BaseSimObject? source,
        Actor? anchorActor,
        WorldTile centerTile,
        float radius,
        float durationWorldTime,
        float tickIntervalWorldTime,
        EraEffectTargetRule targetRule,
        Action<EraEffectContext, Actor>? onActorTick = null,
        Action<EraEffectContext, WorldTile>? onPulse = null
    )
    {
        if (string.IsNullOrWhiteSpace(runtimeKey) || centerTile == null || durationWorldTime <= 0f)
        {
            return;
        }

        if (_areas.TryGetValue(runtimeKey, out EraPeriodicArea? existing))
        {
            existing.SourceId = source?.getID();
            existing.AnchorActorId = anchorActor?.getID();
            existing.CenterTileX = centerTile.x;
            existing.CenterTileY = centerTile.y;
            existing.Radius = radius;
            existing.TickIntervalWorldTime = Math.Max(1f, tickIntervalWorldTime);
            existing.ExpiresAtWorldTime = ReadWorldTime() + durationWorldTime;
            existing.TargetRule = targetRule;
            existing.OnActorTick = onActorTick;
            existing.OnPulse = onPulse;
            return;
        }

        float now = ReadWorldTime();
        _areas[runtimeKey] = new EraPeriodicArea
        {
            RuntimeKey = runtimeKey,
            SourceId = source?.getID(),
            AnchorActorId = anchorActor?.getID(),
            CenterTileX = centerTile.x,
            CenterTileY = centerTile.y,
            Radius = radius,
            TickIntervalWorldTime = Math.Max(1f, tickIntervalWorldTime),
            NextTickWorldTime = now,
            ExpiresAtWorldTime = now + durationWorldTime,
            TargetRule = targetRule,
            OnActorTick = onActorTick,
            OnPulse = onPulse,
        };
    }

    public void CreateBarrierArea(
        string runtimeKey,
        BaseSimObject? source,
        Actor? anchorActor,
        WorldTile centerTile,
        float radius,
        float durationWorldTime,
        float tickIntervalWorldTime,
        float forceAmount
    )
    {
        UpsertPeriodicArea(
            runtimeKey,
            source,
            anchorActor,
            centerTile,
            radius,
            durationWorldTime,
            tickIntervalWorldTime,
            EraEffectTargetRule.All,
            onPulse: (context, resolvedCenter) =>
            {
                if (World.world == null)
                {
                    return;
                }

                World.world.applyForceOnTile(
                    resolvedCenter,
                    pRad: Math.Max(1, (int)MathF.Ceiling(radius)),
                    pForceAmount: Math.Max(0.1f, forceAmount),
                    pForceOut: true,
                    pDamage: 0,
                    pIgnoreKingdoms: null,
                    pByWho: context.Source
                );
            }
        );
    }

    public int ApplyFireTiles(WorldTile centerTile, float radius, float durationWorldTime, string runtimeKey)
    {
        return ApplyTimedTerrain(
            centerTile,
            radius,
            durationWorldTime,
            runtimeKey,
            tile => WorldboxReflectionAdapter.TryStartTileFire(tile, true)
        );
    }

    public int ApplyLavaTerrain(WorldTile centerTile, float radius, float durationWorldTime, string runtimeKey)
    {
        return ApplyTimedTerrain(
            centerTile,
            radius,
            durationWorldTime,
            runtimeKey,
            tile => LavaHelper.addLava(tile, "lava3")
        );
    }

    public int ApplyIceTerrain(WorldTile centerTile, float radius, float durationWorldTime, string runtimeKey)
    {
        return ApplyTimedTerrain(
            centerTile,
            radius,
            durationWorldTime,
            runtimeKey,
            tile => tile.setTopTileType(TopTileLibrary.ice)
        );
    }

    public int ApplyForestTerrain(WorldTile centerTile, float radius, float durationWorldTime, string runtimeKey)
    {
        return ApplyTimedTerrain(
            centerTile,
            radius,
            durationWorldTime,
            runtimeKey,
            tile => tile.setTopTileType(TopTileLibrary.birch_high)
        );
    }

    public int ApplyCorruptionTerrain(WorldTile centerTile, float radius, float durationWorldTime, string runtimeKey)
    {
        return ApplyTimedTerrain(
            centerTile,
            radius,
            durationWorldTime,
            runtimeKey,
            tile => tile.setTopTileType(TopTileLibrary.corruption_high)
        );
    }

    public string CreateStatusReport()
    {
        return $"持续区域={_areas.Count}；临时地形补丁={_terrainPatches.Count}";
    }

    private int ApplyTimedTerrain(
        WorldTile centerTile,
        float radius,
        float durationWorldTime,
        string runtimeKey,
        Action<WorldTile> apply
    )
    {
        if (centerTile == null || durationWorldTime <= 0f || string.IsNullOrWhiteSpace(runtimeKey))
        {
            return 0;
        }

        List<EraTileSnapshot> snapshots = GetTilesInRadius(centerTile, radius)
            .Select(
                tile => new EraTileSnapshot
                {
                    Tile = tile,
                    MainType = tile.main_type,
                    TopType = tile.top_type,
                    HadFire = tile.burned_stages > 0,
                }
            )
            .ToList();

        foreach (EraTileSnapshot snapshot in snapshots)
        {
            apply(snapshot.Tile);
        }

        _terrainPatches[runtimeKey] = new EraTimedTerrainPatch
        {
            RuntimeKey = runtimeKey,
            ExpiresAtWorldTime = ReadWorldTime() + durationWorldTime,
            Tiles = snapshots,
        };

        return snapshots.Count;
    }

    private void UpdateTerrainPatches(float currentWorldTime)
    {
        List<string> expired = new List<string>();
        foreach ((string runtimeKey, EraTimedTerrainPatch patch) in _terrainPatches)
        {
            if (patch.ExpiresAtWorldTime > currentWorldTime)
            {
                continue;
            }

            foreach (EraTileSnapshot snapshot in patch.Tiles)
            {
                if (snapshot.Tile == null)
                {
                    continue;
                }

                snapshot.Tile.setTileTypes(snapshot.MainType ?? snapshot.Tile.main_type, snapshot.TopType ?? snapshot.Tile.top_type);
                if (!snapshot.HadFire)
                {
                    snapshot.Tile.removeBurn();
                    snapshot.Tile.setFireData(false);
                }
            }

            expired.Add(runtimeKey);
        }

        foreach (string runtimeKey in expired)
        {
            _terrainPatches.Remove(runtimeKey);
        }
    }

    private void UpdateAreas(float currentWorldTime)
    {
        List<string> expired = new List<string>();
        foreach ((string runtimeKey, EraPeriodicArea area) in _areas)
        {
            if (area.ExpiresAtWorldTime <= currentWorldTime)
            {
                expired.Add(runtimeKey);
                continue;
            }

            if (area.NextTickWorldTime > currentWorldTime)
            {
                continue;
            }

            WorldTile? centerTile = ResolveCenterTile(area);
            if (centerTile == null)
            {
                area.NextTickWorldTime = currentWorldTime + area.TickIntervalWorldTime;
                continue;
            }

            BaseSimObject? source = ResolveSource(area.SourceId);
            EraEffectContext context = new EraEffectContext(
                source,
                primaryTarget: null,
                currentWorldTime,
                area.RuntimeKey,
                Combat.Triggers.EraTriggerType.OnTick
            );

            area.OnPulse?.Invoke(context, centerTile);

            if (area.OnActorTick != null)
            {
                foreach (Actor actor in FindActors(centerTile, area.Radius, source, area.TargetRule))
                {
                    area.OnActorTick(context, actor);
                }
            }

            area.NextTickWorldTime = currentWorldTime + area.TickIntervalWorldTime;
        }

        foreach (string runtimeKey in expired)
        {
            _areas.Remove(runtimeKey);
        }
    }

    private static IEnumerable<Actor> FindActors(
        WorldTile centerTile,
        float radius,
        BaseSimObject? source,
        EraEffectTargetRule targetRule
    )
    {
        if (World.world?.units == null || centerTile == null)
        {
            return Array.Empty<Actor>();
        }

        float radiusSquared = radius * radius;
        List<Actor> result = new List<Actor>();
        foreach (Actor actor in World.world.units)
        {
            if (actor == null || !actor.isAlive() || actor.current_tile == null)
            {
                continue;
            }

            float dx = actor.current_tile.x - centerTile.x;
            float dy = actor.current_tile.y - centerTile.y;
            if ((dx * dx) + (dy * dy) > radiusSquared)
            {
                continue;
            }

            if (!MatchesRule(source, actor, targetRule))
            {
                continue;
            }

            result.Add(actor);
        }

        return result;
    }

    private static bool MatchesRule(BaseSimObject? source, Actor target, EraEffectTargetRule rule)
    {
        Actor? sourceActor = source as Actor;
        return rule switch
        {
            EraEffectTargetRule.All => true,
            EraEffectTargetRule.SelfOnly => source != null && target.getID() == source.getID(),
            EraEffectTargetRule.Others => source == null || target.getID() != source.getID(),
            EraEffectTargetRule.Friends => sourceActor != null && sourceActor.hasKingdom() && sourceActor.isSameKingdom(target),
            EraEffectTargetRule.Foes => source == null || source.areFoes(target),
            _ => true,
        };
    }

    private static BaseSimObject? ResolveSource(long? sourceId)
    {
        if (sourceId == null || World.world?.units == null)
        {
            return null;
        }

        foreach (Actor actor in World.world.units)
        {
            if (actor != null && actor.getID() == sourceId.Value)
            {
                return actor;
            }
        }

        return null;
    }

    private static WorldTile? ResolveCenterTile(EraPeriodicArea area)
    {
        if (area.AnchorActorId != null && World.world?.units != null)
        {
            foreach (Actor actor in World.world.units)
            {
                if (actor != null && actor.getID() == area.AnchorActorId.Value && actor.current_tile != null)
                {
                    return actor.current_tile;
                }
            }
        }

        return World.world?.GetTile(area.CenterTileX, area.CenterTileY);
    }

    private static float ReadWorldTime()
    {
        return WorldboxReflectionAdapter.TryReadMapStats(out MapStats? mapStats) && mapStats != null
            ? (float)mapStats.world_time
            : 0f;
    }

    private static List<WorldTile> GetTilesInRadius(WorldTile centerTile, float radius)
    {
        HashSet<WorldTile> tiles = new HashSet<WorldTile>();
        tiles.Add(centerTile);

        int searchRadius = Math.Max(1, (int)MathF.Ceiling(radius));
        foreach (WorldTile tile in centerTile.getTilesAround(searchRadius))
        {
            if (tile == null)
            {
                continue;
            }

            float dx = tile.x - centerTile.x;
            float dy = tile.y - centerTile.y;
            if ((dx * dx) + (dy * dy) <= radius * radius)
            {
                tiles.Add(tile);
            }
        }

        return tiles.ToList();
    }
}
