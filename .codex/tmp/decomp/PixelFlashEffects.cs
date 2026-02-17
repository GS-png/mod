using System.Collections.Generic;
using UnityEngine;

public class PixelFlashEffects : MapLayer
{
	private List<WorldTile> toRemove = new List<WorldTile>();

	private ColorArray colorWhite;

	private ColorArray colorPurple;

	private ColorArray colorBlue;

	private float _timer;

	internal override void create()
	{
		colors_amount = 30;
		colorValues = new Color(1f, 1f, 1f);
		colorWhite = new ColorArray(1f, 1f, 1f, 1f, colors_amount, 0.5f);
		colorPurple = new ColorArray(ConwayLife.colorEater, colors_amount);
		colorBlue = new ColorArray(Toolbox.makeColor("#3BCC55"), colors_amount);
		base.create();
		base.enabled = true;
	}

	public void flashPixel(WorldTile pTile, int pVal = -1, ColorType pColorType = ColorType.White)
	{
		if (SmoothLoader.isLoading())
		{
			return;
		}
		if (pVal == -1 || pVal >= colors_amount)
		{
			pVal = colors_amount - 1;
		}
		if (base.enabled)
		{
			switch (pColorType)
			{
			case ColorType.White:
				pTile.color_array = colorWhite;
				break;
			case ColorType.Purple:
				pTile.color_array = colorPurple;
				break;
			case ColorType.Blue:
				pTile.color_array = colorBlue;
				break;
			}
			if (pTile.flash_state <= 0)
			{
				pixels_to_update.Add(pTile);
			}
			if (pTile.flash_state < pVal)
			{
				pTile.flash_state = pVal;
			}
		}
	}

	internal override void clear()
	{
		base.clear();
		pixels_to_update.Clear();
	}

	protected override void UpdateDirty(float pElapsed)
	{
		if (_timer > 0f)
		{
			_timer -= World.world.delta_time;
			return;
		}
		_timer = 0.01f;
		if (pixels_to_update.Count <= 0)
		{
			return;
		}
		toRemove.Clear();
		foreach (WorldTile item2 in pixels_to_update)
		{
			if (item2.flash_state < 0)
			{
				toRemove.Add(item2);
				continue;
			}
			pixels[item2.data.tile_id] = item2.color_array.colors[item2.flash_state];
			item2.flash_state--;
		}
		for (int i = 0; i < toRemove.Count; i++)
		{
			WorldTile item = toRemove[i];
			pixels_to_update.Remove(item);
		}
		updatePixels();
	}
}
