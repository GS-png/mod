using UnityEngine;

public struct Pixel
{
	public readonly int x;

	public readonly int y;

	public readonly Color32 color;

	public Pixel(int pX, int pY, Color32 pColor)
	{
		x = pX;
		y = pY;
		color = pColor;
	}
}
