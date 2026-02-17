using System.Collections.Generic;
using UnityEngine;

public class UnitLayer : MapLayer
{
	private List<WorldTile> prevTiles;

	private float interval = 0.1f;

	private Color32 dead = new Color(0f, 0f, 0f, 0.5f);

	private Color32 _color_clear = Color.clear;

	internal override void create()
	{
		dead = Toolbox.makeColor("#393939");
		prevTiles = new List<WorldTile>();
		base.create();
	}

	internal override void clear()
	{
		prevTiles.Clear();
		base.clear();
	}

	protected override void UpdateDirty(float pElapsed)
	{
		if (MapBox.isRenderGameplay())
		{
			timer = 0f;
			return;
		}
		if (timer > 0f)
		{
			timer -= pElapsed;
			return;
		}
		timer = interval;
		for (int i = 0; i < prevTiles.Count; i++)
		{
			WorldTile worldTile = prevTiles[i];
			pixels[worldTile.data.tile_id] = _color_clear;
		}
		prevTiles.Clear();
		bool flag = PlayerConfig.optionBoolEnabled("marks_boats");
		bool flag2 = Zones.showCultureZones();
		if (World.world.isAnyPowerSelected() && !Zones.isPowerForceMapMode())
		{
			flag2 = false;
		}
		bool flag3 = Zones.showClanZones();
		bool flag4 = Zones.showAllianceZones();
		List<Actor> simpleList = World.world.units.getSimpleList();
		for (int j = 0; j < simpleList.Count; j++)
		{
			Actor actor = simpleList[j];
			if (actor.asset.visible_on_minimap || !actor.asset.color.HasValue || actor.is_inside_building)
			{
				continue;
			}
			prevTiles.Add(actor.current_tile);
			if (!actor.isAlive())
			{
				pixels[actor.current_tile.data.tile_id] = dead;
				continue;
			}
			if (flag2)
			{
				if (actor.hasCulture())
				{
					pixels[actor.current_tile.data.tile_id] = actor.culture.getColor().getColorUnit32();
				}
				continue;
			}
			if (flag3)
			{
				if (actor.hasClan())
				{
					pixels[actor.current_tile.data.tile_id] = actor.clan.getColor().getColorUnit32();
				}
				continue;
			}
			if (flag4)
			{
				Alliance alliance = World.world.alliances.get(actor.kingdom.data.allianceID);
				if (alliance != null)
				{
					pixels[actor.current_tile.data.tile_id] = alliance.getColor().getColorUnit32();
					continue;
				}
			}
			if ((actor.asset.is_boat || actor.isSapient()) && actor.hasKingdom() && actor.isKingdomCiv())
			{
				if (!flag || !actor.asset.draw_boat_mark)
				{
					pixels[actor.current_tile.data.tile_id] = actor.kingdom.getColor().getColorUnit32();
				}
			}
			else
			{
				pixels[actor.current_tile.data.tile_id] = actor.asset.color.Value;
			}
		}
		updatePixels();
	}
}
