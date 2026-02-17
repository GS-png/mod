using UnityEngine;

public class BuildingMapIcon
{
	private BuildingColorPixel[][] _tex;

	private BuildingColorPixel _clear_color_pixel = new BuildingColorPixel(Toolbox.clear, Toolbox.clear, Toolbox.clear);

	private int _width;

	private int _height;

	public BuildingMapIcon(Sprite sprite)
	{
		_width = sprite.texture.width;
		_height = sprite.texture.height;
		_tex = new BuildingColorPixel[_height][];
		for (int i = 0; i < _height; i++)
		{
			BuildingColorPixel[] array = new BuildingColorPixel[_width];
			for (int j = 0; j < _width; j++)
			{
				Color32 color = sprite.texture.GetPixel(j, i);
				if (color.a == 0)
				{
					array[j] = _clear_color_pixel;
					continue;
				}
				Color color2 = Toolbox.makeDarkerColor(color, 0.9f);
				Color color3 = Toolbox.makeDarkerColor(color, 0.6f);
				array[j] = new BuildingColorPixel(color, color2, color3);
			}
			_tex[i] = array;
		}
	}

	internal Color32 getColor(int pX, int pY, Building pBuilding)
	{
		if (pX >= _width || pY >= _height)
		{
			return Toolbox.clear;
		}
		BuildingColorPixel buildingColorPixel = _tex[pY][pX];
		Color32 color = buildingColorPixel.color;
		bool flag = false;
		ColorAsset color2 = pBuilding.kingdom.getColor();
		if (color2 != null)
		{
			if (Toolbox.areColorsEqual(color, Toolbox.color_magenta_0))
			{
				color = color2.k_color_0;
				flag = true;
			}
			else if (Toolbox.areColorsEqual(color, Toolbox.color_magenta_1))
			{
				color = color2.k_color_1;
				flag = true;
			}
			else if (Toolbox.areColorsEqual(color, Toolbox.color_magenta_2))
			{
				color = color2.k_color_2;
				flag = true;
			}
			else if (Toolbox.areColorsEqual(color, Toolbox.color_magenta_3))
			{
				color = color2.k_color_3;
				flag = true;
			}
			else if (Toolbox.areColorsEqual(color, Toolbox.color_magenta_4))
			{
				color = color2.k_color_4;
				flag = true;
			}
		}
		if (pBuilding.asset.has_get_map_icon_color && Toolbox.areColorsEqual(color, Toolbox.color_map_icon_green))
		{
			color = pBuilding.asset.get_map_icon_color(pBuilding);
			flag = true;
		}
		if (!flag)
		{
			if (pBuilding.isAbandoned())
			{
				color = buildingColorPixel.color_abandoned;
			}
			else if (pBuilding.isRuin())
			{
				color = buildingColorPixel.color_ruin;
			}
		}
		return color;
	}
}
