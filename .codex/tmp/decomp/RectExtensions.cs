using UnityEngine;

public static class RectExtensions
{
	public static Rect Resize(this Rect pRect, float pMultiplier)
	{
		float num = pRect.width * pMultiplier;
		float num2 = pRect.height * pMultiplier;
		float num3 = (pRect.width - num) / 2f;
		float num4 = (pRect.height - num2) / 2f;
		pRect.width = num;
		pRect.height = num2;
		pRect.x += num3;
		pRect.y += num4;
		return pRect;
	}
}
