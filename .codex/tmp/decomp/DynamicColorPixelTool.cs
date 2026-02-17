using System;
using UnityEngine;

public static class DynamicColorPixelTool
{
	private static bool _draw_phenotype;

	private static Color32 _phenotype_color;

	public static Color32 phenotype_shade_0;

	public static Color32 phenotype_shade_1;

	public static Color32 phenotype_shade_2;

	public static Color32 phenotype_shade_3;

	private static readonly Color32 _zombie_blood_color = Toolbox.makeColor("#CE566E");

	public static Color32 checkSpecialColors(Color32 pColor, ColorAsset pKingdomColor, bool pCheckForLightColors = false)
	{
		if (Config.EVERYTHING_MAGIC_COLOR)
		{
			return Toolbox.EVERYTHING_MAGIC_COLOR32;
		}
		if (pCheckForLightColors && Toolbox.areColorsEqual(pColor, Toolbox.color_light))
		{
			pColor = Toolbox.color_light_replace;
			return pColor;
		}
		if (pKingdomColor != null)
		{
			if (Toolbox.areColorsEqual(pColor, Toolbox.color_magenta_0))
			{
				pColor = pKingdomColor.k_color_0;
			}
			else if (Toolbox.areColorsEqual(pColor, Toolbox.color_magenta_1))
			{
				pColor = pKingdomColor.k_color_1;
			}
			else if (Toolbox.areColorsEqual(pColor, Toolbox.color_magenta_2))
			{
				pColor = pKingdomColor.k_color_2;
			}
			else if (Toolbox.areColorsEqual(pColor, Toolbox.color_magenta_3))
			{
				pColor = pKingdomColor.k_color_3;
			}
			else if (Toolbox.areColorsEqual(pColor, Toolbox.color_magenta_4))
			{
				pColor = pKingdomColor.k_color_4;
			}
			else if (Toolbox.areColorsEqual(pColor, Toolbox.color_teal_0))
			{
				pColor = pKingdomColor.k2_color_0;
			}
			else if (Toolbox.areColorsEqual(pColor, Toolbox.color_teal_1))
			{
				pColor = pKingdomColor.k2_color_1;
			}
			else if (Toolbox.areColorsEqual(pColor, Toolbox.color_teal_2))
			{
				pColor = pKingdomColor.k2_color_2;
			}
			else if (Toolbox.areColorsEqual(pColor, Toolbox.color_teal_3))
			{
				pColor = pKingdomColor.k2_color_3;
			}
			else if (Toolbox.areColorsEqual(pColor, Toolbox.color_teal_4))
			{
				pColor = pKingdomColor.k2_color_4;
			}
		}
		if (_draw_phenotype)
		{
			if (Toolbox.areColorsEqual(pColor, Toolbox.color_phenotype_green_0))
			{
				pColor = phenotype_shade_0;
			}
			else if (Toolbox.areColorsEqual(pColor, Toolbox.color_phenotype_green_1))
			{
				pColor = phenotype_shade_1;
			}
			else if (Toolbox.areColorsEqual(pColor, Toolbox.color_phenotype_green_2))
			{
				pColor = phenotype_shade_2;
			}
			else if (Toolbox.areColorsEqual(pColor, Toolbox.color_phenotype_green_3))
			{
				pColor = phenotype_shade_3;
			}
		}
		return pColor;
	}

	public static Color32 checkZombieColors(ActorAsset pAsset, Color32 pColor, int pID, bool pHead = false)
	{
		Color32 pTargetBlendColor = Toolbox.makeColor(pAsset.zombie_color_hex);
		return addNoiseAndBlood(multiplyBlend(pColor, pTargetBlendColor), pID);
	}

	private static Color32 addNoiseAndBlood(Color32 pTargetColor, int pID)
	{
		System.Random random = new System.Random(pID);
		if (random.NextDouble() < 0.5)
		{
			return multiplyBlend(pTargetColor, _zombie_blood_color, 0.2f);
		}
		int num = random.Next(0, 20);
		int num2 = Mathf.Clamp(pTargetColor.r + num, 0, 255);
		int num3 = Mathf.Clamp(pTargetColor.g + num, 0, 255);
		int num4 = Mathf.Clamp(pTargetColor.b + num, 0, 255);
		return new Color32((byte)num2, (byte)num3, (byte)num4, pTargetColor.a);
	}

	private static Color32 multiplyBlend(Color32 pBaseColor, Color32 pTargetBlendColor, float pIntensity = 1f)
	{
		float num = (float)(int)pBaseColor.r / 255f;
		float num2 = (float)(int)pBaseColor.g / 255f;
		float num3 = (float)(int)pBaseColor.b / 255f;
		float num4 = Mathf.Lerp(1f, (float)(int)pTargetBlendColor.r / 255f, pIntensity);
		float num5 = Mathf.Lerp(1f, (float)(int)pTargetBlendColor.g / 255f, pIntensity);
		float num6 = Mathf.Lerp(1f, (float)(int)pTargetBlendColor.b / 255f, pIntensity);
		float num7 = Mathf.Clamp01(num * num4);
		float num8 = Mathf.Clamp01(num2 * num5);
		float num9 = Mathf.Clamp01(num3 * num6);
		return new Color32((byte)(num7 * 255f), (byte)(num8 * 255f), (byte)(num9 * 255f), pBaseColor.a);
	}

	private static Color32 overlayBlend(Color32 pBaseColor, Color32 pTargetBlendColor)
	{
		float num = (float)(int)pBaseColor.r / 255f;
		float num2 = (float)(int)pBaseColor.g / 255f;
		float num3 = (float)(int)pBaseColor.b / 255f;
		float num4 = (float)(int)pTargetBlendColor.r / 255f;
		float num5 = (float)(int)pTargetBlendColor.g / 255f;
		float num6 = (float)(int)pTargetBlendColor.b / 255f;
		float num7 = ((num < 0.5f) ? (2f * num * num4) : (1f - 2f * (1f - num) * (1f - num4)));
		float num8 = ((num2 < 0.5f) ? (2f * num2 * num5) : (1f - 2f * (1f - num2) * (1f - num5)));
		float num9 = ((num3 < 0.5f) ? (2f * num3 * num6) : (1f - 2f * (1f - num3) * (1f - num6)));
		return new Color32((byte)(num7 * 255f), (byte)(num8 * 255f), (byte)(num9 * 255f), pBaseColor.a);
	}

	public static void loadPhenotype(int pPhenotypeIndex, int pPhenotypeShadeIndex)
	{
		loadPhenotype(AssetManager.phenotype_library.getAssetByPhenotypeIndex(pPhenotypeIndex), pPhenotypeShadeIndex);
	}

	public static void loadPhenotype(PhenotypeAsset pPhenotypeAsset, int pPhenotypeShadeIndex)
	{
		_phenotype_color = pPhenotypeAsset.colors[pPhenotypeShadeIndex];
		_draw_phenotype = true;
		phenotype_shade_0 = Toolbox.makeDarkerColor(_phenotype_color, 1f);
		phenotype_shade_1 = Toolbox.makeDarkerColor(_phenotype_color, 0.9f);
		phenotype_shade_2 = Toolbox.makeDarkerColor(_phenotype_color, 0.8f);
		phenotype_shade_3 = Toolbox.makeDarkerColor(_phenotype_color, 0.7f);
	}

	public static void loadSkinColorsPreview(PhenotypeAsset pPhenotype, int pSkinColor)
	{
		_draw_phenotype = true;
		phenotype_shade_0 = pPhenotype.colors[0];
		phenotype_shade_1 = pPhenotype.colors[1];
		phenotype_shade_2 = pPhenotype.colors[2];
		phenotype_shade_3 = pPhenotype.colors[3];
	}

	public static void resetSkinColors()
	{
		_draw_phenotype = false;
	}

	public static void setPlaceholderSkinColor(Color32 pColor)
	{
		_phenotype_color = pColor;
	}
}
