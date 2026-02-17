using System;
using UnityEngine;

namespace ai.behaviours;

public class BehDragonFindRandomTile : BehaviourActionActor
{
	public override BehResult execute(Actor pActor)
	{
		if (pActor.beh_tile_target != null)
		{
			return BehResult.Continue;
		}
		WorldTile worldTile = Toolbox.getRandomTileWithinDistance(pActor.current_tile, 100);
		if (!BehaviourActionBase<Actor>.world.islands_calculator.hasGround())
		{
			pActor.beh_tile_target = worldTile;
			return BehResult.Continue;
		}
		int num = 5;
		while (!worldTile.Type.ground && !worldTile.Type.lava && num > 0)
		{
			worldTile = Toolbox.getRandomTileWithinDistance(pActor.current_tile, 100);
			num--;
		}
		if (!worldTile.Type.ground && !worldTile.Type.lava && BehaviourActionBase<Actor>.world.islands_calculator.getRandomIslandGround() != null)
		{
			Span<Vector2Int> pArray = stackalloc Vector2Int[8];
			for (int i = 0; i < 8; i++)
			{
				pArray[i] = BehaviourActionBase<Actor>.world.islands_calculator.tryGetRandomGround().pos;
			}
			Vector2Int closestTile = Toolbox.getClosestTile(pArray, pActor.current_tile);
			worldTile = BehaviourActionBase<Actor>.world.GetTileSimple(closestTile.x, closestTile.y);
		}
		pActor.beh_tile_target = worldTile;
		return BehResult.Continue;
	}
}
