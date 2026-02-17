using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class BrushData : Asset, ILocalizedAsset
{
	[DefaultValue(1)]
	public int size = 1;

	[DefaultValue(1)]
	public int drops = 1;

	public BrushGroup group;

	public bool show_in_brush_window;

	public int width;

	public int height;

	public int sqr_size;

	public bool auto_size;

	public bool continuous;

	public bool fast_spawn;

	public string localized_key;

	public BrushPixelData[] pos;

	public BrushGenerateAction generate_action;

	public Vector2 ui_scale = new Vector2(1f, 1f);

	public Vector2 ui_size = new Vector2(28f, 28f);

	[NonSerialized]
	private Sprite _sprite;

	public void setupImage(Image pSprite)
	{
		pSprite.sprite = getSprite();
		Vector2 vector = ui_scale;
		Vector2 vector2 = ui_size;
		if (height < 28)
		{
			vector2 = new Vector2(width, height);
		}
		pSprite.rectTransform.sizeDelta = new Vector2(vector2.x, vector2.y);
		pSprite.transform.localScale = new Vector3(vector.x, vector.y, 1f);
	}

	public Sprite getSprite()
	{
		if (_sprite != null)
		{
			return _sprite;
		}
		Texture2D texture2D = new Texture2D(width, height, TextureFormat.RGBA32, mipChain: false)
		{
			filterMode = FilterMode.Point,
			wrapMode = TextureWrapMode.Clamp
		};
		Color[] array = new Color[width * height];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = Color.clear;
		}
		texture2D.SetPixels(array);
		Color white = Color.white;
		int num = 0;
		int num2 = 0;
		BrushPixelData[] array2 = pos;
		for (int j = 0; j < array2.Length; j++)
		{
			BrushPixelData brushPixelData = array2[j];
			if (brushPixelData.x < num)
			{
				num = brushPixelData.x;
			}
			if (brushPixelData.y < num2)
			{
				num2 = brushPixelData.y;
			}
		}
		array2 = pos;
		for (int j = 0; j < array2.Length; j++)
		{
			BrushPixelData brushPixelData2 = array2[j];
			texture2D.SetPixel(brushPixelData2.x - num, brushPixelData2.y - num2, white);
		}
		texture2D.Apply(updateMipmaps: false, makeNoLongerReadable: true);
		Rect rect = new Rect(0f, 0f, texture2D.width, texture2D.height);
		Vector2 pivot = new Vector2(0f, 0f);
		_sprite = Sprite.Create(texture2D, rect, pivot, 1f);
		_sprite.name = id;
		return _sprite;
	}

	public string getLocaleID()
	{
		return localized_key;
	}
}
