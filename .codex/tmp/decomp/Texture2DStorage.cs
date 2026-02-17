using System.Collections.Generic;
using UnityEngine;

public static class Texture2DStorage
{
	private static Dictionary<string, SpritePool> pools = new Dictionary<string, SpritePool>();

	private static Dictionary<string, Texture2D> prefabs = new Dictionary<string, Texture2D>();

	internal static Sprite getSprite(int pW, int pH)
	{
		string text = pW + "_" + pH;
		if (pools.ContainsKey(text))
		{
			SpritePool spritePool = pools[text];
			if (spritePool.list.Count > 0)
			{
				Sprite result = spritePool.list[spritePool.list.Count - 1];
				spritePool.list.RemoveAt(spritePool.list.Count - 1);
				return result;
			}
		}
		if (!prefabs.ContainsKey(text))
		{
			Texture2D texture2D = new Texture2D(pW, pH, TextureFormat.RGBA32, mipChain: false)
			{
				filterMode = FilterMode.Point
			};
			texture2D.name = "Texture2DStorage_" + text;
			prefabs.Add(text, texture2D);
		}
		return Sprite.Create(Object.Instantiate(prefabs[text]), new Rect(0f, 0f, pW, pH), new Vector2(0f, 0f), 1f);
	}

	internal static void addToStorage(Sprite pSprite, int pW, int pH)
	{
		string key = pW + "_" + pH;
		SpritePool spritePool;
		if (pools.ContainsKey(key))
		{
			spritePool = pools[key];
		}
		else
		{
			spritePool = new SpritePool();
			pools.Add(key, spritePool);
		}
		spritePool.list.Add(pSprite);
	}
}
