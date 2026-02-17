using UnityEngine;

public class FireLayer : MapLayer
{
	internal override void create()
	{
		base.create();
	}

	public void setTileDirty(WorldTile pTile)
	{
		if (!pixels_to_update.Contains(pTile))
		{
			pixels_to_update.Add(pTile);
		}
	}

	protected override void checkAutoDisable()
	{
		bool flag = WorldBehaviourActionFire.hasFires();
		if (!MapBox.isRenderMiniMap())
		{
			flag = false;
		}
		if (flag)
		{
			if (!sprRnd.enabled)
			{
				sprRnd.enabled = true;
			}
		}
		else if (sprRnd.enabled)
		{
			sprRnd.enabled = false;
		}
	}

	protected override void UpdateDirty(float pElapsed)
	{
		if (pixels_to_update.Count <= 0)
		{
			return;
		}
		Color color = Toolbox.color_fire;
		foreach (WorldTile item in pixels_to_update)
		{
			if (item.isOnFire())
			{
				float worldTimeElapsedSince = World.world.getWorldTimeElapsedSince(item.data.fire_timestamp);
				color.a = 0.5f + (1f - worldTimeElapsedSince / SimGlobals.m.fire_stop_time);
				pixels[item.data.tile_id] = color;
			}
			else
			{
				pixels[item.data.tile_id] = Toolbox.clear;
			}
		}
		pixels_to_update.Clear();
		updatePixels();
	}
}
