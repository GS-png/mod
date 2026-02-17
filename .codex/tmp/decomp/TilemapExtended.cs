using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapExtended : MonoBehaviour
{
	public int z;

	private Tilemap _tilemap;

	private readonly List<Vector3Int> _vec = new List<Vector3Int>();

	private readonly ListPool<TileBase> _tiles = new ListPool<TileBase>();

	public void create(TileTypeBase pTileBase)
	{
		z = pTileBase.render_z;
		base.gameObject.name = pTileBase.draw_layer_name;
		TilemapRenderer component = GetComponent<TilemapRenderer>();
		component.sortingOrder = pTileBase.render_z;
		component.sharedMaterial = LibraryMaterials.instance.dict[pTileBase.material];
		if (pTileBase.id == "deep_ocean")
		{
			base.gameObject.SetActive(value: false);
		}
		_tilemap = GetComponent<Tilemap>();
	}

	internal void prepareDraw()
	{
		_vec.Clear();
		_tiles.Clear();
	}

	internal void addToQueueToRedraw(WorldTile pWorldTile, Vector3Int pPosition, TileBase pTileGraphics, bool pSkipCheck = false)
	{
		pPosition.z = 0;
		if (!pSkipCheck)
		{
			if (pWorldTile.current_rendered_tile_graphics == pTileGraphics && (object)pTileGraphics != null)
			{
				return;
			}
			pWorldTile.current_rendered_tile_graphics = pTileGraphics;
		}
		_vec.Add(pPosition);
		_tiles.Add(pTileGraphics);
	}

	internal void clear()
	{
		_tilemap.ClearAllTiles();
	}

	internal void redraw()
	{
		if (_vec.Count != 0)
		{
			_tilemap.SetTiles(_vec.ToArray(), _tiles.GetRawBuffer());
		}
	}
}
