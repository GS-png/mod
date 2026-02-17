using System.Collections.Generic;
using UnityEngine;

public class UnitSpriteConstructorAtlas
{
	public UnitTextureAtlasID id;

	private bool _big_atlas;

	public Texture2D texture;

	public Color32[] pixels;

	public List<Texture2D> textures = new List<Texture2D>();

	public int last_x;

	public int last_y;

	private int _biggest_height;

	public bool dirty;

	public UnitSpriteConstructorAtlas(UnitTextureAtlasID pID, bool pBigAtlas)
	{
		id = pID;
		_big_atlas = pBigAtlas;
	}

	public void setBigAtlas(bool pBigAtlas)
	{
		_big_atlas = pBigAtlas;
	}

	public bool isBigSpriteSheetAtlas()
	{
		return _big_atlas;
	}

	public void newTexture(int pWidth, int pHeight, string tName)
	{
		if (!_big_atlas)
		{
			pWidth += 2;
			pHeight += 10;
		}
		texture = new Texture2D(pWidth, pHeight);
		textures.Add(texture);
		texture.filterMode = FilterMode.Point;
		texture.wrapMode = TextureWrapMode.Clamp;
		texture.name = tName;
		pixels = texture.GetPixels32();
		Color32 color = Color.clear;
		for (int i = 0; i < pixels.Length; i++)
		{
			pixels[i] = color;
		}
		dirty = true;
		last_x = 0;
		last_y = 0;
		_biggest_height = 0;
	}

	public void checkDirty()
	{
		if (dirty)
		{
			dirty = false;
			texture.SetPixels32(pixels);
			texture.Apply();
		}
	}

	public string debug()
	{
		return textures.Count + " | " + last_y;
	}

	public void checkBounds(int pWidth, int pHeight)
	{
		if (!_big_atlas)
		{
			newTexture(pWidth, pHeight, id.ToString() + "_small_atlas");
			last_x = 1;
			last_y = 1;
			return;
		}
		bool flag = false;
		if (textures.Count == 0)
		{
			flag = true;
		}
		if (pHeight > _biggest_height)
		{
			_biggest_height = pHeight;
		}
		int texture_size = DynamicSpritesConfig.texture_size;
		if (last_x + pWidth + 1 > texture_size)
		{
			last_x = 0;
			last_y += _biggest_height + 1;
			if (last_y + _biggest_height >= texture_size || last_y >= texture_size)
			{
				flag = true;
			}
			else
			{
				_biggest_height = pHeight;
			}
		}
		else if (last_y + pHeight >= texture_size)
		{
			flag = true;
		}
		if (flag)
		{
			checkDirty();
			newTexture(texture_size, texture_size, id.ToString() + "_big_atlas");
			_biggest_height = pHeight;
		}
	}

	public void clear()
	{
		foreach (Texture2D texture in textures)
		{
			if (texture != null)
			{
				Object.Destroy(texture);
			}
		}
		textures.Clear();
		_biggest_height = 0;
		last_x = 0;
		last_y = 0;
	}
}
