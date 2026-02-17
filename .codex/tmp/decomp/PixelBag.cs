using UnityEngine;

public class PixelBag
{
	public readonly int texture_rect_width;

	public readonly int texture_rect_height;

	public readonly Pixel[] arr_pixels_normal;

	public readonly Pixel[] arr_pixels_light;

	public readonly Pixel[] arr_pixels_k1_0;

	public readonly Pixel[] arr_pixels_k1_1;

	public readonly Pixel[] arr_pixels_k1_2;

	public readonly Pixel[] arr_pixels_k1_3;

	public readonly Pixel[] arr_pixels_k1_4;

	public readonly Pixel[] arr_pixels_k2_0;

	public readonly Pixel[] arr_pixels_k2_1;

	public readonly Pixel[] arr_pixels_k2_2;

	public readonly Pixel[] arr_pixels_k2_3;

	public readonly Pixel[] arr_pixels_k2_4;

	public readonly Pixel[] arr_pixels_phenotype_shade_0;

	public readonly Pixel[] arr_pixels_phenotype_shade_1;

	public readonly Pixel[] arr_pixels_phenotype_shade_2;

	public readonly Pixel[] arr_pixels_phenotype_shade_3;

	private ListPool<Pixel> _pixels_normal;

	private ListPool<Pixel> _pixels_light;

	private ListPool<Pixel> _pixels_k1_0;

	private ListPool<Pixel> _pixels_k1_1;

	private ListPool<Pixel> _pixels_k1_2;

	private ListPool<Pixel> _pixels_k1_3;

	private ListPool<Pixel> _pixels_k1_4;

	private ListPool<Pixel> _pixels_k2_0;

	private ListPool<Pixel> _pixels_k2_1;

	private ListPool<Pixel> _pixels_k2_2;

	private ListPool<Pixel> _pixels_k2_3;

	private ListPool<Pixel> _pixels_k2_4;

	private ListPool<Pixel> _pixels_phenotype_shade_0;

	private ListPool<Pixel> _pixels_phenotype_shade_1;

	private ListPool<Pixel> _pixels_phenotype_shade_2;

	private ListPool<Pixel> _pixels_phenotype_shade_3;

	public PixelBag(Sprite pSpriteSource, bool pCheckPhenotypes, bool pCheckLights)
	{
		Texture2D texture = pSpriteSource.texture;
		Rect rect = pSpriteSource.rect;
		int width = texture.width;
		texture_rect_width = (int)rect.width;
		texture_rect_height = (int)rect.height;
		int num = (int)rect.x;
		int num2 = (int)rect.y;
		Color32[] pixels = texture.GetPixels32();
		for (int i = 0; i < texture_rect_width; i++)
		{
			for (int j = 0; j < texture_rect_height; j++)
			{
				int num3 = i + num;
				int num4 = j + num2;
				int num5 = num3 + num4 * width;
				Color32 pColor = pixels[num5];
				if (pColor.a != 0)
				{
					checkAndSavePixel(pColor, i, j, pCheckPhenotypes, pCheckLights);
				}
			}
		}
		arr_pixels_normal = _pixels_normal?.ToArray();
		arr_pixels_light = _pixels_light?.ToArray();
		arr_pixels_k1_0 = _pixels_k1_0?.ToArray();
		arr_pixels_k1_1 = _pixels_k1_1?.ToArray();
		arr_pixels_k1_2 = _pixels_k1_2?.ToArray();
		arr_pixels_k1_3 = _pixels_k1_3?.ToArray();
		arr_pixels_k1_4 = _pixels_k1_4?.ToArray();
		arr_pixels_k2_0 = _pixels_k2_0?.ToArray();
		arr_pixels_k2_1 = _pixels_k2_1?.ToArray();
		arr_pixels_k2_2 = _pixels_k2_2?.ToArray();
		arr_pixels_k2_3 = _pixels_k2_3?.ToArray();
		arr_pixels_k2_4 = _pixels_k2_4?.ToArray();
		arr_pixels_phenotype_shade_0 = _pixels_phenotype_shade_0?.ToArray();
		arr_pixels_phenotype_shade_1 = _pixels_phenotype_shade_1?.ToArray();
		arr_pixels_phenotype_shade_2 = _pixels_phenotype_shade_2?.ToArray();
		arr_pixels_phenotype_shade_3 = _pixels_phenotype_shade_3?.ToArray();
		clearLists();
	}

	private void clearLists()
	{
		_pixels_normal?.Dispose();
		_pixels_light?.Dispose();
		_pixels_k1_0?.Dispose();
		_pixels_k1_1?.Dispose();
		_pixels_k1_2?.Dispose();
		_pixels_k1_3?.Dispose();
		_pixels_k1_4?.Dispose();
		_pixels_k2_0?.Dispose();
		_pixels_k2_1?.Dispose();
		_pixels_k2_2?.Dispose();
		_pixels_k2_3?.Dispose();
		_pixels_k2_4?.Dispose();
		_pixels_phenotype_shade_0?.Dispose();
		_pixels_phenotype_shade_1?.Dispose();
		_pixels_phenotype_shade_2?.Dispose();
		_pixels_phenotype_shade_3?.Dispose();
		_pixels_normal = null;
		_pixels_light = null;
		_pixels_k1_0 = null;
		_pixels_k1_1 = null;
		_pixels_k1_2 = null;
		_pixels_k1_3 = null;
		_pixels_k1_4 = null;
		_pixels_k2_0 = null;
		_pixels_k2_1 = null;
		_pixels_k2_2 = null;
		_pixels_k2_3 = null;
		_pixels_k2_4 = null;
		_pixels_phenotype_shade_0 = null;
		_pixels_phenotype_shade_1 = null;
		_pixels_phenotype_shade_2 = null;
		_pixels_phenotype_shade_3 = null;
	}

	private void checkAndSavePixel(Color32 pColor, int pX, int pY, bool pCheckPhenotypes, bool pCheckLights)
	{
		Pixel item = new Pixel(pX, pY, pColor);
		if (Toolbox.areColorsEqual(pColor, Toolbox.color_magenta_0))
		{
			if (_pixels_k1_0 == null)
			{
				_pixels_k1_0 = new ListPool<Pixel>();
			}
			_pixels_k1_0.Add(item);
			return;
		}
		if (Toolbox.areColorsEqual(pColor, Toolbox.color_magenta_1))
		{
			if (_pixels_k1_1 == null)
			{
				_pixels_k1_1 = new ListPool<Pixel>();
			}
			_pixels_k1_1.Add(item);
			return;
		}
		if (Toolbox.areColorsEqual(pColor, Toolbox.color_magenta_2))
		{
			if (_pixels_k1_2 == null)
			{
				_pixels_k1_2 = new ListPool<Pixel>();
			}
			_pixels_k1_2.Add(item);
			return;
		}
		if (Toolbox.areColorsEqual(pColor, Toolbox.color_magenta_3))
		{
			if (_pixels_k1_3 == null)
			{
				_pixels_k1_3 = new ListPool<Pixel>();
			}
			_pixels_k1_3.Add(item);
			return;
		}
		if (Toolbox.areColorsEqual(pColor, Toolbox.color_magenta_4))
		{
			if (_pixels_k1_4 == null)
			{
				_pixels_k1_4 = new ListPool<Pixel>();
			}
			_pixels_k1_4.Add(item);
			return;
		}
		if (Toolbox.areColorsEqual(pColor, Toolbox.color_teal_0))
		{
			if (_pixels_k2_0 == null)
			{
				_pixels_k2_0 = new ListPool<Pixel>();
			}
			_pixels_k2_0.Add(item);
			return;
		}
		if (Toolbox.areColorsEqual(pColor, Toolbox.color_teal_1))
		{
			if (_pixels_k2_1 == null)
			{
				_pixels_k2_1 = new ListPool<Pixel>();
			}
			_pixels_k2_1.Add(item);
			return;
		}
		if (Toolbox.areColorsEqual(pColor, Toolbox.color_teal_2))
		{
			if (_pixels_k2_2 == null)
			{
				_pixels_k2_2 = new ListPool<Pixel>();
			}
			_pixels_k2_2.Add(item);
			return;
		}
		if (Toolbox.areColorsEqual(pColor, Toolbox.color_teal_3))
		{
			if (_pixels_k2_3 == null)
			{
				_pixels_k2_3 = new ListPool<Pixel>();
			}
			_pixels_k2_3.Add(item);
			return;
		}
		if (Toolbox.areColorsEqual(pColor, Toolbox.color_teal_4))
		{
			if (_pixels_k2_4 == null)
			{
				_pixels_k2_4 = new ListPool<Pixel>();
			}
			_pixels_k2_4.Add(item);
			return;
		}
		if (pCheckPhenotypes)
		{
			if (Toolbox.areColorsEqual(pColor, Toolbox.color_phenotype_green_0))
			{
				if (_pixels_phenotype_shade_0 == null)
				{
					_pixels_phenotype_shade_0 = new ListPool<Pixel>();
				}
				_pixels_phenotype_shade_0.Add(item);
				return;
			}
			if (Toolbox.areColorsEqual(pColor, Toolbox.color_phenotype_green_1))
			{
				if (_pixels_phenotype_shade_1 == null)
				{
					_pixels_phenotype_shade_1 = new ListPool<Pixel>();
				}
				_pixels_phenotype_shade_1.Add(item);
				return;
			}
			if (Toolbox.areColorsEqual(pColor, Toolbox.color_phenotype_green_2))
			{
				if (_pixels_phenotype_shade_2 == null)
				{
					_pixels_phenotype_shade_2 = new ListPool<Pixel>();
				}
				_pixels_phenotype_shade_2.Add(item);
				return;
			}
			if (Toolbox.areColorsEqual(pColor, Toolbox.color_phenotype_green_3))
			{
				if (_pixels_phenotype_shade_3 == null)
				{
					_pixels_phenotype_shade_3 = new ListPool<Pixel>();
				}
				_pixels_phenotype_shade_3.Add(item);
				return;
			}
		}
		if (pCheckLights && Toolbox.areColorsEqual(pColor, Toolbox.color_light))
		{
			if (_pixels_light == null)
			{
				_pixels_light = new ListPool<Pixel>();
			}
			_pixels_light.Add(item);
		}
		else
		{
			if (_pixels_normal == null)
			{
				_pixels_normal = new ListPool<Pixel>();
			}
			_pixels_normal.Add(item);
		}
	}
}
