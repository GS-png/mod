using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconOutline : MonoBehaviour
{
	private static Dictionary<string, Sprite> _cached_textures = new Dictionary<string, Sprite>();

	private Image _image;

	public Image parent_image;

	private void Awake()
	{
		checkInit();
	}

	private void checkInit()
	{
		if (!(_image != null))
		{
			_image = GetComponent<Image>();
			base.gameObject.AddComponent<FadeInOutAnimation>();
		}
	}

	public void show(ContainerItemColor pContainer)
	{
		checkInit();
		base.gameObject.SetActive(value: true);
		Color color = pContainer.color;
		color.a = 1f;
		_image.color = color;
		string key = parent_image.sprite.texture.GetHashCode() + "_" + color.GetHashCode();
		Sprite sprite = null;
		if (_cached_textures.ContainsKey(key))
		{
			sprite = _cached_textures[key];
		}
		else
		{
			sprite = generateSprite();
			_cached_textures.Add(key, sprite);
		}
		_image.sprite = sprite;
	}

	private Sprite generateSprite()
	{
		int width = parent_image.sprite.texture.width;
		int height = parent_image.sprite.texture.height;
		Texture2D texture2D = new Texture2D(width, height);
		Color color = new Color(1f, 1f, 1f, 0f);
		for (int i = 0; i < texture2D.width; i++)
		{
			for (int j = 0; j < texture2D.height; j++)
			{
				texture2D.SetPixel(i, j, color);
			}
		}
		makePixels(-1, -1, texture2D);
		makePixels(1, 1, texture2D);
		makePixels(1, -1, texture2D);
		makePixels(-1, 1, texture2D);
		makePixels(1, 0, texture2D);
		makePixels(-1, 0, texture2D);
		makePixels(0, 1, texture2D);
		makePixels(0, -1, texture2D);
		texture2D.Apply();
		texture2D.filterMode = FilterMode.Point;
		texture2D.name = "IconOutline";
		Rect rect = new Rect(0f, 0f, texture2D.width, texture2D.height);
		Vector2 pivot = new Vector2(0.5f, 0.5f);
		return Sprite.Create(texture2D, rect, pivot, 1f);
	}

	private void makePixels(int pOffsetX, int pOffsetY, Texture2D pTexture)
	{
		for (int i = 0; i < pTexture.width; i++)
		{
			for (int j = 0; j < pTexture.height; j++)
			{
				if (parent_image.sprite.texture.GetPixel(i, j).a != 0f)
				{
					int num = i + pOffsetX;
					int num2 = j + pOffsetY;
					if (num >= 0 && num <= pTexture.width && num2 >= 0 && num2 <= pTexture.height)
					{
						Color pixel = pTexture.GetPixel(num, num2);
						pixel.a += 0.3f;
						pTexture.SetPixel(num, num2, pixel);
					}
				}
			}
		}
	}
}
