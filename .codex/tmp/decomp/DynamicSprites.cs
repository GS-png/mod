using UnityEngine;

public static class DynamicSprites
{
	public const int NO_COLOR_ID = -900000;

	public static Sprite getIconWithColors(Sprite pSprite, PhenotypeAsset pPhenotype, ColorAsset pKingdomColor)
	{
		DynamicSpritesAsset icons = DynamicSpritesLibrary.icons;
		long num = pSprite.GetHashCode() * 10000 + (pPhenotype?.GetHashCode() ?? 0) * 100 + (pKingdomColor?.GetHashCode() ?? 0);
		Sprite sprite = icons.getSprite(num);
		if ((object)sprite == null)
		{
			sprite = DynamicSpriteCreator.createNewIcon(icons, pSprite, pKingdomColor, pPhenotype);
			icons.addSprite(num, sprite);
		}
		return sprite;
	}

	public static Sprite getRecoloredBuilding(Sprite pBuildingSprite, ColorAsset pColor, DynamicSpritesAsset pAtlasAsset)
	{
		long buildingSpriteID = getBuildingSpriteID(pBuildingSprite.GetHashCode(), pColor);
		Sprite sprite = pAtlasAsset.getSprite(buildingSpriteID);
		if ((object)sprite == null)
		{
			sprite = DynamicSpriteCreator.createNewSpriteBuilding(pAtlasAsset, buildingSpriteID, pBuildingSprite, pColor);
			pAtlasAsset.addSprite(buildingSpriteID, sprite);
		}
		return sprite;
	}

	private static long getBuildingSpriteID(int pBaseSpriteID, ColorAsset pColor)
	{
		long num = ((pColor != null) ? (pColor.index_id + 1) : (-1000000));
		return (num + 1) * 10000000 + pBaseSpriteID;
	}

	public static Sprite getBuildingLight(Building pBuilding)
	{
		DynamicSpritesAsset building_lights = DynamicSpritesLibrary.building_lights;
		int hashCode = pBuilding.last_main_sprite.GetHashCode();
		return building_lights.getSprite(hashCode);
	}

	public static Sprite getIcon(Sprite pSprite, ColorAsset pColorAsset)
	{
		DynamicSpritesAsset icons = DynamicSpritesLibrary.icons;
		long num = pSprite.GetHashCode() * 10000 + pColorAsset.GetHashCode();
		Sprite sprite = icons.getSprite(num);
		if ((object)sprite == null)
		{
			sprite = DynamicSpriteCreator.createNewIcon(icons, pSprite, pColorAsset);
			icons.addSprite(num, sprite);
		}
		return sprite;
	}

	public static Sprite getShadowBuilding(BuildingAsset pAsset, Sprite pSprite)
	{
		if (!pAsset.shadow)
		{
			return null;
		}
		int hashCode = pSprite.GetHashCode();
		return DynamicSpritesLibrary.building_shadows.getSprite(hashCode);
	}

	public static Sprite getShadowUnit(Sprite pSprite, int pHashCode)
	{
		DynamicSpritesAsset units_shadows = DynamicSpritesLibrary.units_shadows;
		Sprite sprite = units_shadows.getSprite(pHashCode);
		if ((object)sprite == null)
		{
			sprite = DynamicSpriteCreator.createNewUnitShadow(units_shadows, pSprite);
			units_shadows.addSprite(pHashCode, sprite);
		}
		return sprite;
	}

	public static void preloadItemSprite(Sprite pSprite, ColorAsset pColorAsset = null)
	{
		long itemSpriteID = getItemSpriteID(pSprite, pColorAsset);
		DynamicSpritesAsset items = DynamicSpritesLibrary.items;
		Sprite pSprite2 = DynamicSpriteCreator.createNewItemSprite(items, pSprite, pColorAsset);
		items.addSprite(itemSpriteID, pSprite2);
	}

	public static long getItemSpriteID(Sprite pSprite, ColorAsset pColor)
	{
		int pColorID = pColor?.GetHashCode() ?? (-900000);
		return getItemSpriteID(pSprite, pColorID);
	}

	public static long getItemSpriteID(Sprite pSprite, int pColorID = -900000)
	{
		return pSprite.GetHashCode() * 10000 + pColorID;
	}

	public static Sprite getCachedAtlasItemSprite(long pID, Sprite pSpriteSource)
	{
		Sprite sprite = DynamicSpritesLibrary.items.getSprite(pID);
		if ((object)sprite == null)
		{
			Debug.LogError("[getCachedAtlasItemSprite]Dynamic sprite not found: " + pID + " " + pSpriteSource);
			return pSpriteSource;
		}
		return sprite;
	}

	public static Sprite getCachedAtlasItemSprite(long pID, Sprite pSpriteSource, ColorAsset pColorAsset)
	{
		Sprite sprite = DynamicSpritesLibrary.items.getSprite(pID);
		if ((object)sprite == null)
		{
			Debug.LogError("[getCachedAtlasItemSprite]Dynamic sprite not found: " + pID + " " + pSpriteSource?.ToString() + " " + ((pColorAsset != null) ? (pColorAsset.index_id + " " + pColorAsset.color_main) : "null"));
			return pSpriteSource;
		}
		return sprite;
	}
}
