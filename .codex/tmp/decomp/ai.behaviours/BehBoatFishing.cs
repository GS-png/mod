using UnityEngine;

namespace ai.behaviours;

public class BehBoatFishing : BehaviourActionActor
{
	public override BehResult execute(Actor pActor)
	{
		spawnFishnet(pActor);
		return BehResult.Continue;
	}

	public void spawnFishnet(Actor pActor)
	{
		if (MapBox.isRenderGameplay())
		{
			Vector2 vector = Randy.randomPointOnCircle(3f, 4f);
			WorldTile worldTile = null;
			worldTile = BehaviourActionBase<Actor>.world.GetTile(pActor.current_tile.pos.x + (int)vector.x, pActor.current_tile.pos.y + (int)vector.y);
			if (worldTile != null && worldTile.Type.ocean)
			{
				EffectsLibrary.spawnAtTile("fx_fishnet", worldTile, pActor.asset.base_stats["scale"]);
			}
		}
	}
}
