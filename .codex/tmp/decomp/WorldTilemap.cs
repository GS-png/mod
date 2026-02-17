using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Tilemaps;

public class WorldTilemap : BaseMapObject
{
	private const int EMPTY_Z = -1000;

	public static readonly Vector3Int EMPTY_TILE_POS = new Vector3Int(-1, -1, -1000);

	private Dictionary<int, TilemapExtended> _layers;

	[SerializeField]
	private TilemapExtended _prefab_tilemap_layer;

	[SerializeField]
	private Material _water_rims_material;

	private TileType _asset_border_water_outline;

	private TileType _asset_border_water_runup;

	private TileType _asset_border_pit;

	private TilemapExtended _layer_border_water_runup;

	private TilemapExtended _layer_water_outline;

	private readonly HashSet<TileZone> _dirty_zones = new HashSet<TileZone>();

	private readonly List<TileZone> _clear_list_zones = new List<TileZone>();

	private HashSet<WorldTile>[] _tiles_by_zone;

	private readonly Color _color_border_water_runup_default = Toolbox.makeColor("#DDFCFF", 0.7f);

	private float _color_water_runup_alpha_current = 0.4f;

	private float _color_water_runup_timer;

	private bool _color_water_runup_state_fade_in = true;

	private const float WATER_RUNUP_INTERVAL = 0.01f;

	private const float WATER_RUNUP_SPEED_CHANGE = 0.6f;

	private const float COLOR_WATER_RUNUP_ALPHA_BOUND_MIN = 0.02f;

	private const float COLOR_WATER_RUNUP_ALPHA_BOUND_M = 0.7f;

	internal override void create()
	{
		base.create();
		_layers = new Dictionary<int, TilemapExtended>();
		_asset_border_water_outline = AssetManager.tiles.get("border_water");
		_asset_border_water_runup = AssetManager.tiles.get("border_water_runup");
		_asset_border_pit = AssetManager.tiles.get("border_pit");
		for (int i = 0; i < AssetManager.tiles.list.Count; i++)
		{
			TileTypeBase pTileBase = AssetManager.tiles.list[i];
			createTileMapFor(pTileBase);
		}
		for (int j = 0; j < AssetManager.top_tiles.list.Count; j++)
		{
			TileTypeBase pTileBase2 = AssetManager.top_tiles.list[j];
			createTileMapFor(pTileBase2);
		}
		_layer_border_water_runup = _layers[_asset_border_water_runup.render_z];
		_layer_water_outline = _layers[_asset_border_water_outline.render_z];
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool needsRedraw(WorldTile pTile)
	{
		if (pTile.last_rendered_tile_type == pTile.Type)
		{
			return false;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void addToQueueToRedraw(WorldTile pTile)
	{
		TileZone zone = pTile.zone;
		_dirty_zones.Add(zone);
		_tiles_by_zone[zone.id].Add(pTile);
	}

	private void createTileMapFor(TileTypeBase pTileBase)
	{
		if (!_layers.ContainsKey(pTileBase.render_z))
		{
			TilemapExtended tilemapExtended = Object.Instantiate(_prefab_tilemap_layer, base.transform);
			tilemapExtended.create(pTileBase);
			if (pTileBase.id == "border_water_runup")
			{
				tilemapExtended.GetComponent<TilemapRenderer>().sharedMaterial = _water_rims_material;
			}
			_layers.Add(pTileBase.render_z, tilemapExtended);
		}
	}

	public override void update(float pElapsed)
	{
		base.update(pElapsed);
		if (!World.world.isPaused())
		{
			updateWaterRunup(Time.deltaTime);
		}
	}

	private void updateWaterRunup(float pElapsed)
	{
		if (_color_water_runup_timer > 0f)
		{
			_color_water_runup_timer -= pElapsed;
			return;
		}
		_color_water_runup_timer = 0.01f;
		if (_color_water_runup_state_fade_in)
		{
			_color_water_runup_alpha_current += pElapsed * 0.6f;
			if (_color_water_runup_alpha_current >= 0.7f)
			{
				_color_water_runup_alpha_current = 0.7f;
				_color_water_runup_state_fade_in = false;
			}
		}
		else
		{
			_color_water_runup_alpha_current -= pElapsed * 0.6f;
			if (_color_water_runup_alpha_current <= 0.02f)
			{
				_color_water_runup_alpha_current = 0.02f;
				_color_water_runup_state_fade_in = true;
			}
		}
		float nightMod = World.world.era_manager.getNightMod();
		Color color = Toolbox.blendColor(Toolbox.color_night, _color_border_water_runup_default, nightMod);
		color.a = _color_water_runup_alpha_current;
		_water_rims_material.color = color;
	}

	internal void clear()
	{
		if (_tiles_by_zone != null)
		{
			HashSet<WorldTile>[] tiles_by_zone = _tiles_by_zone;
			for (int i = 0; i < tiles_by_zone.Length; i++)
			{
				tiles_by_zone[i].Clear();
			}
		}
		_dirty_zones.Clear();
		_clear_list_zones.Clear();
		foreach (TilemapExtended value in _layers.Values)
		{
			value.clear();
		}
	}

	internal void generate(int pCount)
	{
		_tiles_by_zone = new HashSet<WorldTile>[pCount];
		for (int i = 0; i < pCount; i++)
		{
			_tiles_by_zone[i] = new HashSet<WorldTile>(64);
		}
	}

	private void prepareToDraw()
	{
		foreach (TilemapExtended value in _layers.Values)
		{
			value.prepareDraw();
		}
	}

	internal void redrawTiles(bool pForceAll = false)
	{
		if (_dirty_zones.Count == 0 || !(MapBox.isRenderGameplay() || pForceAll))
		{
			return;
		}
		prepareToDraw();
		if (pForceAll)
		{
			foreach (TileZone dirty_zone in _dirty_zones)
			{
				checkZoneToRender(dirty_zone);
			}
		}
		else
		{
			List<TileZone> visibleZones = World.world.zone_camera.getVisibleZones();
			for (int i = 0; i < visibleZones.Count; i++)
			{
				TileZone pZone = visibleZones[i];
				checkZoneToRender(pZone);
			}
		}
		if (pForceAll)
		{
			_clear_list_zones.Clear();
			_dirty_zones.Clear();
		}
		redrawAllLayers();
		drawFinish();
	}

	private void drawFinish()
	{
		_dirty_zones.ExceptWith(_clear_list_zones);
		_clear_list_zones.Clear();
	}

	private void redrawAllLayers()
	{
		foreach (TilemapExtended value in _layers.Values)
		{
			value.redraw();
		}
	}

	private void checkZoneToRender(TileZone pZone)
	{
		if (!_dirty_zones.Contains(pZone))
		{
			return;
		}
		HashSet<WorldTile> hashSet = _tiles_by_zone[pZone.id];
		foreach (WorldTile item in hashSet)
		{
			renderTile(item);
		}
		_clear_list_zones.Add(pZone);
		hashSet.Clear();
	}

	private void renderTile(WorldTile pTile)
	{
		TileTypeBase tileTypeBase = pTile.main_type;
		if (pTile.Type != null)
		{
			tileTypeBase = pTile.Type;
		}
		int render_z = tileTypeBase.render_z;
		Vector3Int vector3Int = new Vector3Int(pTile.pos.x, pTile.pos.y, render_z);
		Vector3Int last_rendered_pos_tile = pTile.last_rendered_pos_tile;
		int z = last_rendered_pos_tile.z;
		if (vector3Int.z != z || pTile.last_rendered_tile_type != tileTypeBase)
		{
			if (z != -1000)
			{
				_layers[z].addToQueueToRedraw(pTile, last_rendered_pos_tile, null);
				pTile.last_rendered_pos_tile = EMPTY_TILE_POS;
			}
			pTile.last_rendered_tile_type = tileTypeBase;
			_layers[vector3Int.z].addToQueueToRedraw(pTileGraphics: getVariation(pTile), pWorldTile: pTile, pPosition: vector3Int);
			pTile.last_rendered_pos_tile = vector3Int;
		}
		Vector3Int last_rendered_border_pos_ocean = pTile.last_rendered_border_pos_ocean;
		int z2 = last_rendered_border_pos_ocean.z;
		if (z2 != -1000)
		{
			_layers[z2].addToQueueToRedraw(pTile, last_rendered_border_pos_ocean, null);
			pTile.last_rendered_border_pos_ocean = EMPTY_TILE_POS;
			_layer_border_water_runup.addToQueueToRedraw(pTile, last_rendered_pos_tile, null, pSkipCheck: true);
		}
		if ((!pTile.main_type.ground && !pTile.main_type.block) || pTile.main_type.can_be_filled_with_ocean)
		{
			return;
		}
		TileType tileType = null;
		bool flag = false;
		if (pTile.has_tile_down && pTile.tile_down.main_type.can_be_filled_with_ocean)
		{
			tileType = _asset_border_pit;
			render_z = tileType.render_z;
		}
		else if (pTile.isWaterAround())
		{
			tileType = _asset_border_water_outline;
			render_z = tileType.render_z;
			flag = true;
		}
		if (tileType != null)
		{
			TilemapExtended tilemapExtended = _layers[render_z];
			vector3Int.y = pTile.pos.y;
			vector3Int.z = render_z;
			tilemapExtended.addToQueueToRedraw(pTile, vector3Int, tileType.sprites.main);
			pTile.last_rendered_border_pos_ocean = vector3Int;
			if (flag)
			{
				_layer_border_water_runup.addToQueueToRedraw(pTile, vector3Int, _asset_border_water_runup.sprites.main, pSkipCheck: true);
			}
		}
	}

	internal void enableTiles(bool pValue)
	{
		if (base.gameObject.activeSelf != pValue)
		{
			base.gameObject.SetActive(pValue);
		}
	}

	private Tile getVariation(WorldTile pTile)
	{
		TileSprites sprites = pTile.main_type.sprites;
		if (pTile.Type != null)
		{
			sprites = pTile.Type.sprites;
		}
		if (pTile.Type.force_edge_variation && pTile.has_tile_up && pTile.tile_up.Type != pTile.Type)
		{
			return pTile.Type.sprites.getVariation(pTile.Type.force_edge_variation_frame);
		}
		return sprites.getRandom();
	}

	internal void debug(DebugTool pTool)
	{
		pTool.setText("_dirty_zones", _dirty_zones.Count, 0f, pShowBar: false, 0L);
		pTool.setText("_clear_list_zones", _clear_list_zones.Count, 0f, pShowBar: false, 0L);
	}

	public void checkEnableForWaterRunups(bool pIsLowRes)
	{
		if (pIsLowRes)
		{
			if (_layer_border_water_runup.gameObject.activeSelf)
			{
				_layer_border_water_runup.gameObject.SetActive(value: false);
				_layer_water_outline.gameObject.SetActive(value: false);
			}
		}
		else if (!_layer_border_water_runup.gameObject.activeSelf)
		{
			_layer_border_water_runup.gameObject.SetActive(value: true);
			_layer_water_outline.gameObject.SetActive(value: true);
		}
	}
}
