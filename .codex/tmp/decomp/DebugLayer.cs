using System.Collections.Generic;
using UnityEngine;

public class DebugLayer : MapLayer
{
	internal static List<TileZone> fmod_zones_to_draw = new List<TileZone>();

	private HashSet<WorldTile> _tiles = new HashSet<WorldTile>();

	public Color color1 = Color.gray;

	public Color color2 = Color.white;

	public Color color_red = Color.red;

	public Color color_active_path;

	private bool used;

	private List<MapRegion> _forced_global_path = new List<MapRegion>();

	protected override void UpdateDirty(float pElapsed)
	{
		if (!DebugConfig.instance.debugButton.gameObject.activeSelf)
		{
			clear();
			return;
		}
		color_active_path = new Color(1f, 1f, 1f, 0.5f);
		used = false;
		clear();
		if (_forced_global_path != null && _forced_global_path.Count > 0)
		{
			drawRegionPath(_forced_global_path);
		}
		if (DebugConfig.isOn(DebugOption.CityZones))
		{
			drawZones();
		}
		else if (DebugConfig.isOn(DebugOption.Chunks))
		{
			drawChunks();
		}
		if (DebugConfig.isOn(DebugOption.PathRegions))
		{
			drawPathRegions();
		}
		if (DebugConfig.isOn(DebugOption.ActivePaths))
		{
			drawActivePaths();
		}
		if (DebugConfig.isOn(DebugOption.CityPlaces))
		{
			drawCityPlaces();
		}
		if (DebugConfig.isOn(DebugOption.RenderCityDangerZones))
		{
			drawCityDangerZones();
		}
		if (DebugConfig.isOn(DebugOption.RenderVisibleZones))
		{
			drawVisibleZones();
		}
		if (DebugConfig.isOn(DebugOption.RenderCityCenterZones))
		{
			drawCityCenterZones();
		}
		if (DebugConfig.isOn(DebugOption.RenderCityFarmPlaces))
		{
			drawCityFarmZones();
		}
		if (DebugConfig.isOn(DebugOption.Buildings))
		{
			drawBuildings();
		}
		if (DebugConfig.isOn(DebugOption.FmodZones))
		{
			drawFmodZones();
		}
		if (DebugConfig.isOn(DebugOption.ConstructionTiles))
		{
			drawConstructionTiles();
		}
		if (DebugConfig.isOn(DebugOption.UnitsInside))
		{
			drawUnitsInside();
		}
		if (DebugConfig.isOn(DebugOption.TargetedBy))
		{
			drawTargetedBy();
		}
		if (DebugConfig.isOn(DebugOption.UnitKingdoms))
		{
			drawUnitKingdoms();
		}
		if (DebugConfig.isOn(DebugOption.DisplayUnitTiles))
		{
			drawUnitTiles();
		}
		if (DebugConfig.isOn(DebugOption.ProKing))
		{
			drawProfession(UnitProfession.King);
		}
		if (DebugConfig.isOn(DebugOption.ProLeader))
		{
			drawProfession(UnitProfession.Leader);
		}
		if (DebugConfig.isOn(DebugOption.ProUnit))
		{
			drawProfession(UnitProfession.Unit);
		}
		if (DebugConfig.isOn(DebugOption.ProWarrior))
		{
			drawProfession(UnitProfession.Warrior);
		}
		if (used)
		{
			if (!base.gameObject.activeSelf)
			{
				base.gameObject.SetActive(value: true);
			}
			updatePixels();
		}
		else if (base.gameObject.activeSelf)
		{
			base.gameObject.SetActive(value: false);
		}
	}

	private void drawUnitKingdoms()
	{
		used = true;
		foreach (Actor unit in World.world.units)
		{
			if (unit.kingdom != null && unit.kingdom.getColor() != null)
			{
				Color color = unit.kingdom.getColor().getColorMain32();
				pixels[unit.current_tile.data.tile_id] = color;
				_tiles.Add(unit.current_tile);
			}
		}
	}

	private void drawUnitTiles()
	{
		used = true;
		WorldTile[] tiles_list = World.world.tiles_list;
		foreach (WorldTile worldTile in tiles_list)
		{
			if (worldTile.hasUnits())
			{
				pixels[worldTile.data.tile_id] = Color.blue;
				_tiles.Add(worldTile);
			}
		}
	}

	private void drawTargetedBy()
	{
		used = true;
		WorldTile[] tiles_list = World.world.tiles_list;
		foreach (WorldTile worldTile in tiles_list)
		{
			if (worldTile.isTargeted())
			{
				pixels[worldTile.data.tile_id] = Color.blue;
				_tiles.Add(worldTile);
			}
		}
	}

	private void drawProfession(UnitProfession pPro)
	{
		used = true;
		foreach (Actor unit in World.world.units)
		{
			if (unit.isProfession(pPro))
			{
				Color blue = Color.blue;
				pixels[unit.current_tile.data.tile_id] = blue;
				_tiles.Add(unit.current_tile);
			}
		}
	}

	private void drawCitizenJobs(string pID)
	{
		used = true;
		foreach (Actor unit in World.world.units)
		{
			if (unit.ai.job != null && !(pID != unit.ai.job.id))
			{
				Color red = Color.red;
				pixels[unit.current_tile.data.tile_id] = red;
				_tiles.Add(unit.current_tile);
			}
		}
	}

	private void drawUnitsInside()
	{
		used = true;
		foreach (Actor unit in World.world.units)
		{
			if (unit.is_inside_building)
			{
				pixels[unit.current_tile.data.tile_id] = Color.green;
				_tiles.Add(unit.current_tile);
			}
		}
	}

	private void drawConstructionTiles()
	{
		used = true;
		WorldTile[] tiles_list = World.world.tiles_list;
		foreach (WorldTile worldTile in tiles_list)
		{
			if (!worldTile.hasBuilding() || !worldTile.building.asset.docks)
			{
				continue;
			}
			(TileZone[], int) allZonesFromTile = Toolbox.getAllZonesFromTile(worldTile);
			TileZone[] item = allZonesFromTile.Item1;
			int item2 = allZonesFromTile.Item2;
			for (int j = 0; j < item2; j++)
			{
				TileZone pZone = item[j];
				foreach (WorldTile item3 in worldTile.building.checkZoneForDockConstruction(pZone))
				{
					pixels[item3.data.tile_id] = Color.red;
					_tiles.Add(item3);
				}
			}
		}
	}

	private void drawFmodZones()
	{
		used = true;
		foreach (TileZone item in fmod_zones_to_draw)
		{
			fill(item.tiles, Color.yellow);
		}
	}

	private void drawBuildings()
	{
		used = true;
		WorldTile[] tiles_list = World.world.tiles_list;
		foreach (WorldTile worldTile in tiles_list)
		{
			if (worldTile.hasBuilding())
			{
				if (worldTile.building.kingdom != null && worldTile.building.isKingdomCiv())
				{
					pixels[worldTile.data.tile_id] = worldTile.building.kingdom.getColor().getColorMain32();
				}
				else
				{
					pixels[worldTile.data.tile_id] = Color.red;
				}
				pixels[worldTile.building.current_tile.data.tile_id] = Color.magenta;
				pixels[worldTile.building.door_tile.data.tile_id] = Color.yellow;
				_tiles.Add(worldTile.building.current_tile);
				_tiles.Add(worldTile.building.door_tile);
				_tiles.Add(worldTile);
			}
		}
	}

	private void drawCityCenterZones()
	{
		used = true;
		foreach (City city in World.world.cities)
		{
			WorldTile tile = city.getTile();
			if (tile != null)
			{
				fill(tile.zone.tiles, Color.red);
			}
		}
	}

	private void drawCityFarmZones()
	{
		used = true;
		foreach (City city in World.world.cities)
		{
			fill(city.calculated_place_for_farms.getSimpleList(), Color.blue);
			fill(city.calculated_farm_fields.getSimpleList(), Color.cyan);
			fill(city.calculated_crops.getSimpleList(), Color.green);
			fill(city.calculated_grown_wheat.getSimpleList(), Color.yellow);
		}
	}

	private void drawVisibleZones()
	{
		used = true;
		List<TileZone> visibleZones = World.world.zone_camera.getVisibleZones();
		for (int i = 0; i < visibleZones.Count; i++)
		{
			TileZone tileZone = visibleZones[i];
			if (tileZone.visible_main_centered)
			{
				fill(tileZone.tiles, Color.green);
			}
			else if (tileZone.visible)
			{
				fill(tileZone.tiles, Color.blue);
			}
		}
	}

	private void drawCityDangerZones()
	{
		used = true;
		foreach (City city in World.world.cities)
		{
			foreach (TileZone danger_zone in city.danger_zones)
			{
				fill(danger_zone.tiles, Color.red);
			}
		}
	}

	private void drawCityPlaces()
	{
		used = true;
		foreach (TileZone zone in World.world.zone_calculator.zones)
		{
			if (zone.city != null)
			{
				fill(zone.tiles, Color.yellow);
			}
			else if (zone.isGoodForNewCity())
			{
				fill(zone.tiles, Color.blue);
			}
		}
	}

	private void drawActivePaths()
	{
		used = true;
		foreach (Actor unit in World.world.units)
		{
			if (unit.current_path_global != null)
			{
				drawRegionPath(unit.current_path_global);
				fill(unit.current_path, Color.blue);
			}
		}
	}

	public void drawRegionPath(List<MapRegion> pRegions)
	{
		used = true;
		foreach (MapRegion pRegion in pRegions)
		{
			fill(pRegion.tiles, color_active_path);
		}
	}

	public void forceDrawRegionPath(List<MapRegion> pRegions)
	{
		_forced_global_path.Clear();
		_forced_global_path.AddRange(pRegions);
	}

	private void drawPathRegions()
	{
		used = true;
		MapChunk[] chunks = World.world.map_chunk_manager.chunks;
		for (int i = 0; i < chunks.Length; i++)
		{
			foreach (MapRegion region in chunks[i].regions)
			{
				if (region.path_wave_id != -1)
				{
					fill(region.tiles, new Color(1f, 1f, 0f, 0.9f));
				}
			}
		}
		List<MapRegion> last_globalPath = World.world.region_path_finder.last_globalPath;
		if (last_globalPath == null || last_globalPath.Count <= 0 || World.world.region_path_finder?.tileStart?.region == null || World.world.region_path_finder?.tileTarget?.region == null)
		{
			return;
		}
		foreach (MapRegion item in World.world.region_path_finder.last_globalPath)
		{
			fill(item.tiles, Color.blue);
		}
		fill(World.world.region_path_finder.tileStart.region.tiles, Color.green);
		fill(World.world.region_path_finder.tileTarget.region.tiles, new Color(1f, 0f, 0f, 0.3f));
	}

	private void fill(List<WorldTile> pTiles, Color pColor, bool pEdge = false)
	{
		createTextureNew();
		for (int i = 0; i < pTiles.Count; i++)
		{
			WorldTile worldTile = pTiles[i];
			if (!pEdge || worldTile.region != null)
			{
				_tiles.Add(worldTile);
				pixels[worldTile.data.tile_id] = pColor;
			}
		}
	}

	private void fill(WorldTile[] pTiles, Color pColor, bool pEdge = false)
	{
		createTextureNew();
		foreach (WorldTile worldTile in pTiles)
		{
			if (!pEdge || worldTile.region != null)
			{
				_tiles.Add(worldTile);
				pixels[worldTile.data.tile_id] = pColor;
			}
		}
	}

	private void drawZones()
	{
		used = true;
		foreach (TileZone zone in World.world.zone_calculator.zones)
		{
			if ((zone.x + zone.y) % 2 == 0)
			{
				zone.debug_zone_color = color1;
			}
			else
			{
				zone.debug_zone_color = color2;
			}
			fill(zone.tiles, zone.debug_zone_color);
		}
	}

	private void testCityLayout()
	{
		DebugVariables instance = DebugVariables.instance;
		if ((object)instance != null && !instance.layout_city_test)
		{
			return;
		}
		used = true;
		WorldTile mouseTilePos = World.world.getMouseTilePos();
		if (mouseTilePos == null)
		{
			return;
		}
		TileZone pCursorZone = mouseTilePos?.zone;
		foreach (TileZone zone in World.world.zone_calculator.zones)
		{
			bool flag = true;
			if (!TownPlans.debugVisualizeZone(zone, pCursorZone))
			{
				flag = false;
			}
			if (flag)
			{
				zone.debug_zone_color = color1;
			}
			else
			{
				zone.debug_zone_color = color_red;
			}
			fill(zone.tiles, zone.debug_zone_color);
		}
	}

	private void drawChunks()
	{
		used = true;
		MapChunk[] chunks = World.world.map_chunk_manager.chunks;
		foreach (MapChunk mapChunk in chunks)
		{
			fill(mapChunk.tiles, mapChunk.color);
		}
	}

	internal override void clear()
	{
		HashSet<WorldTile> tiles = _tiles;
		if (tiles.Count == 0)
		{
			return;
		}
		foreach (WorldTile item in tiles)
		{
			if (item.data.tile_id <= pixels.Length - 1)
			{
				pixels[item.data.tile_id] = Color.clear;
			}
		}
		_tiles.Clear();
		createTextureNew();
	}
}
