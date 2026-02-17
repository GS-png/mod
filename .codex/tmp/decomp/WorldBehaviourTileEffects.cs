using System.Collections.Generic;

public class WorldBehaviourTileEffects
{
	public static void tryToStartTileEffects()
	{
		for (int i = 0; i < 5; i++)
		{
			spawnEffect();
		}
	}

	public static void spawnEffect()
	{
		if (TrailerMonolith.enable_trailer_stuff || !World.world.zone_camera.hasVisibleZones() || World.world.stack_effects.controller_tile_effects.isLimitReached())
		{
			return;
		}
		WorldTile randomTile = World.world.zone_camera.getVisibleZones().GetRandom().getRandomTile();
		TileEffectAsset randomEffect = TileEffectsLibrary.getRandomEffect(randomTile);
		if (randomEffect == null || !Randy.randomChance(randomEffect.chance))
		{
			return;
		}
		WorldTile[] neighboursAll = randomTile.neighboursAll;
		foreach (WorldTile worldTile in neighboursAll)
		{
			if (!randomEffect.tile_types.Contains(worldTile.Type.id))
			{
				return;
			}
		}
		TileEffect tileEffect = EffectsLibrary.spawn("fx_tile_effect", randomTile) as TileEffect;
		if (!(tileEffect == null))
		{
			tileEffect.load(randomEffect);
		}
	}

	public static void checkTileForEffectKill(WorldTile pTile, int pRadius)
	{
		BaseEffectController controller_tile_effects = World.world.stack_effects.controller_tile_effects;
		List<BaseEffect> list = controller_tile_effects.getList();
		for (int i = 0; i < list.Count; i++)
		{
			BaseEffect baseEffect = list[i];
			if (baseEffect.active && !(Toolbox.Dist(baseEffect.transform.position.x, baseEffect.transform.position.y, pTile.pos.x, pTile.pos.y) > (float)pRadius))
			{
				controller_tile_effects.killObject(baseEffect);
				break;
			}
		}
	}
}
