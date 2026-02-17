using UnityEngine;

public class ViewRainfall : MapLayer
{
	internal override void create()
	{
		colorValues = new Color(0f, 0f, 1f);
		colors_amount = 10;
		base.create();
		sprRnd.color = new Color(1f, 1f, 1f, 0.6f);
	}

	public void setTileDirty(WorldTile pTile)
	{
	}

	protected override void UpdateDirty(float pElapsed)
	{
	}
}
