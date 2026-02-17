using System.Collections.Generic;
using UnityEngine;

public class ColorArray
{
	public List<Color32> colors;

	public ColorArray(float pR, float pG, float pB, float pA, float pAmount, float pMod = 1f)
	{
		colors = new List<Color32>();
		for (int i = 0; (float)i < pAmount; i++)
		{
			float num = ((i <= 0) ? 0f : (1f / pAmount * (float)i));
			Color color = new Color(pR, pG, pB, num * 1f * pMod);
			colors.Add(color);
		}
	}

	public ColorArray(Color32 pColor, int pAmount)
		: this((int)pColor.r, (int)pColor.g, (int)pColor.b, (int)pColor.a, pAmount)
	{
	}
}
