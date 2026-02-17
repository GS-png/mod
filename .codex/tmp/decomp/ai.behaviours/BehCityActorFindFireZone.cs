using UnityEngine;

namespace ai.behaviours;

public class BehCityActorFindFireZone : BehCityActor
{
	public override BehResult execute(Actor pActor)
	{
		if (pActor.hasStatus("burning"))
		{
			return BehResult.Stop;
		}
		TileZone cityZoneNearFire = getCityZoneNearFire(pActor);
		if (cityZoneNearFire == null)
		{
			return BehResult.Stop;
		}
		WorldTile closestTileNotOnFire = getClosestTileNotOnFire(cityZoneNearFire.tiles, pActor.current_tile);
		if (closestTileNotOnFire == null)
		{
			return BehResult.Stop;
		}
		pActor.beh_tile_target = closestTileNotOnFire;
		return BehResult.Continue;
	}

	private static TileZone getCityZoneNearFire(Actor pActor)
	{
		using ListPool<TileZone> listPool = new ListPool<TileZone>(pActor.city.zones);
		int num = int.MaxValue;
		TileZone result = null;
		foreach (TileZone neighbour_zone in pActor.city.neighbour_zones)
		{
			if (!neighbour_zone.hasCity())
			{
				listPool.Add(neighbour_zone);
			}
		}
		Vector2Int pos = pActor.current_tile.pos;
		for (int i = 0; i < listPool.Count; i++)
		{
			TileZone tileZone = listPool[i];
			if (tileZone.isZoneOnFire())
			{
				Vector2Int pos2 = tileZone.centerTile.pos;
				int num2 = Toolbox.SquaredDist(pos.x, pos.y, pos2.x, pos2.y);
				if (num2 < num)
				{
					result = tileZone;
					num = num2;
				}
			}
		}
		listPool.Clear();
		return result;
	}

	public static WorldTile getClosestTileNotOnFire(WorldTile[] pArray, WorldTile pTarget)
	{
		WorldTile result = null;
		int num = pArray.Length;
		int num2 = int.MaxValue;
		for (int i = 0; i < num; i++)
		{
			WorldTile worldTile = pArray[i];
			int num3 = Toolbox.SquaredDist(pTarget.x, pTarget.y, worldTile.x, worldTile.y);
			if (num3 < num2 && !worldTile.hasBuilding() && !worldTile.isOnFire())
			{
				num2 = num3;
				result = worldTile;
			}
		}
		return result;
	}
}
