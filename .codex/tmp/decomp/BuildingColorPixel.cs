using UnityEngine;

public readonly struct BuildingColorPixel
{
	public readonly Color32 color;

	public readonly Color32 color_abandoned;

	public readonly Color32 color_ruin;

	public BuildingColorPixel(Color32 pColor, Color32 pColorAbandoned, Color32 pColorRuin)
	{
		color = pColor;
		color_abandoned = pColorAbandoned;
		color_ruin = pColorRuin;
	}
}
