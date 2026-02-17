namespace ai.behaviours;

public class BehCityActorRemoveFire : BehCityActor
{
	protected override void setupErrorChecks()
	{
		base.setupErrorChecks();
		null_check_tile_target = true;
	}

	public override BehResult execute(Actor pActor)
	{
		foreach (WorldTile item in pActor.current_tile.getTilesAround(3))
		{
			if (item != null)
			{
				putOutFireForTile(item);
			}
		}
		return BehResult.Continue;
	}

	private void putOutFireForTile(WorldTile pTile, bool pForceEffect = false)
	{
		bool flag = false;
		if (pTile.isOnFire())
		{
			pTile.stopFire();
			flag = true;
		}
		if (flag || pForceEffect)
		{
			EffectsLibrary.spawnAt("fx_water_splash", pTile.pos, 0.1f);
		}
		if (pTile.hasBuilding())
		{
			pTile.building.stopFire();
		}
	}
}
