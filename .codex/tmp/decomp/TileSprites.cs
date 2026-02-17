using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileSprites
{
	private List<Tile> _tiles = new List<Tile>();

	public Tile main => _tiles[0];

	public void addVariation(Sprite pSprite, string pID)
	{
		Tile tile = ScriptableObject.CreateInstance<Tile>();
		tile.name = pID;
		tile.sprite = pSprite;
		_tiles.Add(tile);
	}

	public Tile getRandom()
	{
		return _tiles.GetRandom();
	}

	public Tile getVariation(int pID)
	{
		return _tiles[pID];
	}
}
