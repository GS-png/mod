using System.Collections.Generic;
using UnityEngine;

public static class SpriteTextureLoader
{
	private static readonly Dictionary<string, Sprite> _cached_sprites = new Dictionary<string, Sprite>();

	private static readonly Dictionary<string, Sprite[]> _cached_sprite_list = new Dictionary<string, Sprite[]>();

	private static int _total_sprite_list_single_sprites = 0;

	public static int total_sprites => _cached_sprites.Count;

	public static int total_sprites_list => _cached_sprite_list.Count;

	public static int total_sprites_list_single_sprites => _total_sprite_list_single_sprites;

	public static Sprite getSprite(string pPath)
	{
		if (!_cached_sprites.TryGetValue(pPath, out var value))
		{
			value = (Sprite)Resources.Load(pPath, typeof(Sprite));
			_cached_sprites[pPath] = value;
		}
		return value;
	}

	public static Sprite[] getSpriteList(string pPath, bool pSkipIfEmpty = false)
	{
		if (!_cached_sprite_list.TryGetValue(pPath, out var value))
		{
			value = Resources.LoadAll<Sprite>(pPath);
			if (pSkipIfEmpty && value.Length == 0)
			{
				return null;
			}
			_cached_sprite_list.Add(pPath, value);
			_total_sprite_list_single_sprites += value.Length;
		}
		return value;
	}

	public static void addSprite(string pPathID, byte[] pBytes)
	{
		Texture2D texture2D = new Texture2D(1, 1);
		texture2D.filterMode = FilterMode.Point;
		if (texture2D.LoadImage(pBytes))
		{
			Rect rect = new Rect(0f, 0f, texture2D.width, texture2D.height);
			Vector2 pivot = new Vector2(0.5f, 0.5f);
			Sprite value = Sprite.Create(texture2D, rect, pivot, 1f);
			_cached_sprites.Add(pPathID, value);
		}
	}
}
