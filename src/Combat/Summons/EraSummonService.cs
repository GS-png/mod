using System.Collections.Generic;

namespace EraWheel.Combat.Summons;

public sealed class EraSummonService
{
    public IReadOnlyList<Actor> SummonUnits(
        Effects.EraEffectContext context,
        string actorAssetId,
        WorldTile centerTile,
        int count,
        bool joinSourceKingdom = true,
        bool ownerlessItems = false,
        bool adultAge = true
    )
    {
        List<Actor> spawned = new List<Actor>();
        if (World.world?.units == null || centerTile == null || count <= 0)
        {
            return spawned;
        }

        for (int index = 0; index < count; index++)
        {
            WorldTile tile = ResolveSpawnTile(centerTile, index) ?? centerTile;
            Actor? actor = World.world.units.spawnNewUnit(
                actorAssetId,
                tile,
                pSpawnSound: false,
                pMiracleSpawn: false,
                pSpawnHeight: 6f,
                pSubspecies: null,
                pGiveOwnerlessItems: ownerlessItems,
                pAdultAge: adultAge
            );
            if (actor == null)
            {
                continue;
            }

            if (joinSourceKingdom && context.SourceActor?.kingdom != null)
            {
                actor.joinKingdom(context.SourceActor.kingdom);
            }

            spawned.Add(actor);
        }

        return spawned;
    }

    public string CreateStatusReport()
    {
        return "召唤服务=已就绪";
    }

    private static WorldTile? ResolveSpawnTile(WorldTile centerTile, int offset)
    {
        WorldTile? walkable = centerTile.getWalkableTileAround(centerTile);
        if (walkable != null)
        {
            return walkable;
        }

        int radius = 1 + (offset % 3);
        foreach (WorldTile tile in centerTile.getTilesAround(radius))
        {
            if (tile != null && !tile.is_liquid && !tile.hasBuilding())
            {
                return tile;
            }
        }

        return null;
    }
}
