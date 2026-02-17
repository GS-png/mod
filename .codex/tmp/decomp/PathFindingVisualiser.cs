using System.Collections.Generic;
using EpPathFinding.cs;
using UnityEngine;

public class PathFindingVisualiser : MapLayer
{
	public Color default_color;

	private List<WorldTile> tiles = new List<WorldTile>();

	internal override void create()
	{
		colorValues = new Color(1f, 0.46f, 0.19f, 1f);
		colorValues = default_color;
		base.create();
	}

	protected override void UpdateDirty(float pElapsed)
	{
		if (DebugConfig.isOn(DebugOption.LastPath))
		{
			if (!base.gameObject.activeSelf)
			{
				base.gameObject.SetActive(value: true);
			}
		}
		else if (base.gameObject.activeSelf)
		{
			base.gameObject.SetActive(value: false);
		}
	}

	internal override void clear()
	{
		if (tiles.Count != 0)
		{
			tiles.Clear();
			for (int i = 0; i < pixels.Length; i++)
			{
				pixels[i] = Color.clear;
			}
			createTextureNew();
		}
	}

	internal void showPath(StaticGrid pGrid, List<WorldTile> pTilePath)
	{
		if (!DebugConfig.isOn(DebugOption.LastPath))
		{
			return;
		}
		clear();
		if (pGrid != null)
		{
			WorldTile[] tiles_list = World.world.tiles_list;
			foreach (WorldTile worldTile in tiles_list)
			{
				tiles.Add(worldTile);
				Node nodeAt = pGrid.GetNodeAt(worldTile.pos.x, worldTile.pos.y);
				if (nodeAt.isClosed)
				{
					pixels[worldTile.data.tile_id] = Color.red;
				}
				else if (nodeAt.isOpened)
				{
					pixels[worldTile.data.tile_id] = Color.green;
				}
				else
				{
					pixels[worldTile.data.tile_id] = Color.clear;
				}
			}
		}
		foreach (WorldTile item in pTilePath)
		{
			pixels[item.data.tile_id] = Color.blue;
			tiles.Add(item);
		}
		updatePixels();
	}
}
