using System.Collections.Generic;
using UnityEngine;

public static class DynamicSpriteCreator
{
	public static Actor debug_actor;

	private static Dictionary<Sprite, int> _int_ids_body = new Dictionary<Sprite, int>();

	private static readonly Color32 _placeholder_color_skin = Toolbox.makeColor("#00FF00");

	private static readonly List<Vector2Int> _light_colors = new List<Vector2Int>();

	public static Sprite createNewItemSprite(DynamicSpritesAsset pAsset, Sprite pSource, ColorAsset pKingdomColor)
	{
		UnitSpriteConstructorAtlas atlas = pAsset.getAtlas();
		Rect rect = pSource.rect;
		int pWidth = (int)rect.width;
		int pHeight = (int)rect.height;
		atlas.checkBounds(pWidth, pHeight);
		int width = atlas.texture.width;
		_ = atlas.texture.height;
		Color32[] pixels = pSource.texture.GetPixels32();
		int width2 = pSource.texture.width;
		for (int i = 0; (float)i < rect.width; i++)
		{
			for (int j = 0; (float)j < rect.height; j++)
			{
				int num = i + (int)rect.x;
				int num2 = j + (int)rect.y;
				int num3 = num + num2 * width2;
				Color32 pColor = pixels[num3];
				if (pColor.a != 0)
				{
					pColor = DynamicColorPixelTool.checkSpecialColors(pColor, pKingdomColor, pCheckForLightColors: true);
					int num4 = i + atlas.last_x;
					int num5 = j + atlas.last_y;
					if (num4 < 0)
					{
						num4 = 0;
					}
					if (num5 < 0)
					{
						num5 = 0;
					}
					num3 = num4 + num5 * width;
					atlas.pixels[num3] = pColor;
				}
			}
		}
		setAtlasDirty(atlas);
		return createFinalSprite(atlas, pSource, pWidth, pHeight);
	}

	private static Sprite createFinalSprite(UnitSpriteConstructorAtlas pAtlasTexture, Sprite pMain, int pWidth, int pHeight, int pResizeX = 0, int pResizeY = 0)
	{
		Sprite obj = Sprite.Create(rect: new Rect(pAtlasTexture.last_x, pAtlasTexture.last_y, pWidth, pHeight), pivot: new Vector2((pMain.pivot.x + (float)pResizeX) / (float)pWidth, pMain.pivot.y / (float)pHeight), texture: pAtlasTexture.texture, pixelsPerUnit: 1f);
		obj.name = "gen_" + pMain.name;
		pAtlasTexture.last_x += pWidth + 1;
		return obj;
	}

	private static Sprite createNewSpriteBuildingShadow(DynamicSpritesAsset pDynamicSpritesAsset, BuildingAsset tAsset, Sprite pSource, bool pIsContructionSprite)
	{
		UnitSpriteConstructorAtlas atlas = pDynamicSpritesAsset.getAtlas();
		Rect rect = pSource.rect;
		int num = 3;
		int num2 = (int)rect.width;
		int num3 = (int)rect.height;
		int num4 = (int)rect.x;
		int num5 = (int)rect.y;
		atlas.checkBounds(num2 + num, num3);
		int width = atlas.texture.width;
		_ = atlas.texture.height;
		Color32[] pixels = pSource.texture.GetPixels32();
		Vector2 vector;
		float num6;
		if (pIsContructionSprite)
		{
			vector = BuildingLibrary.shadow_under_construction_bound;
			num6 = BuildingLibrary.shadow_under_construction_distortion;
		}
		else
		{
			vector = tAsset.shadow_bound;
			num6 = tAsset.shadow_distortion;
		}
		int num7 = (int)(vector.x * (float)num2);
		int num8 = (int)((float)num3 * vector.y);
		List<Vector2Int> list = new List<Vector2Int>();
		Color32 color = Color.black;
		int width2 = pSource.texture.width;
		for (int i = 0; i < num2; i++)
		{
			for (int j = 0; j < num3; j++)
			{
				int num9 = i + num4;
				int num10 = j + num5;
				int num11 = num9 + num10 * width2;
				Color32 color2 = pixels[num11];
				if (color2.a == 0)
				{
					continue;
				}
				color2 = color;
				if (i >= num7)
				{
					int num12 = i + atlas.last_x;
					int num13 = j + atlas.last_y;
					if (j > num8)
					{
						num13 = (int)((float)j * num6) + atlas.last_y;
					}
					if (num12 < 0)
					{
						num12 = 0;
					}
					if (num13 < 0)
					{
						num13 = 0;
					}
					list.Add(new Vector2Int(num12, num13));
					num11 = num12 + num13 * width;
					atlas.pixels[num11] = color2;
				}
			}
		}
		setAtlasDirty(atlas);
		num2 += num;
		foreach (Vector2Int item in list)
		{
			int num14 = item.x + 1;
			int y = item.y;
			int num15 = num14 + y * width;
			atlas.pixels[num15] = color;
			int num16 = item.x + 2;
			y = item.y;
			num15 = num16 + y * width;
			atlas.pixels[num15] = color;
			int num17 = item.x + 1;
			y = item.y + 1;
			num15 = num17 + y * width;
			atlas.pixels[num15] = color;
		}
		return createFinalSprite(atlas, pSource, num2, num3);
	}

	public static Sprite createNewUnitShadow(DynamicSpritesAsset pAsset, Sprite pSource)
	{
		UnitSpriteConstructorAtlas atlas = pAsset.getAtlas();
		Rect rect = pSource.rect;
		int num = 1;
		int num2 = (int)rect.width;
		int num3 = (int)rect.height;
		int num4 = (int)rect.x;
		int num5 = (int)rect.y;
		atlas.checkBounds(num2 + num, num3);
		int width = atlas.texture.width;
		_ = atlas.texture.height;
		Color32[] pixels = pSource.texture.GetPixels32();
		int width2 = pSource.texture.width;
		for (int i = 0; i < num2; i++)
		{
			for (int j = 0; j < num3; j++)
			{
				int num6 = i + num4;
				int num7 = j + num5;
				int num8 = num6 + num7 * width2;
				Color32 color = pixels[num8];
				if (color.a != 0)
				{
					int num9 = i + atlas.last_x;
					int num10 = j + atlas.last_y;
					if (num9 < 0)
					{
						num9 = 0;
					}
					if (num10 < 0)
					{
						num10 = 0;
					}
					num8 = num9 + num10 * width;
					atlas.pixels[num8] = color;
				}
			}
		}
		num2 += num;
		setAtlasDirty(atlas);
		return createFinalSprite(atlas, pSource, num2, num3);
	}

	public static void createBuildingShadow(BuildingAsset pAsset, Sprite pSprite, bool pIsContructionSprite)
	{
		DynamicSpritesAsset building_shadows = DynamicSpritesLibrary.building_shadows;
		int hashCode = pSprite.GetHashCode();
		Sprite pSprite2 = createNewSpriteBuildingShadow(building_shadows, pAsset, pSprite, pIsContructionSprite);
		building_shadows.addSprite(hashCode, pSprite2);
	}

	public static Sprite createNewIcon(DynamicSpritesAsset pAsset, Sprite pSource, ColorAsset pKingdomColor, PhenotypeAsset pPhenotype = null)
	{
		UnitSpriteConstructorAtlas atlas = pAsset.getAtlas();
		if (pPhenotype != null)
		{
			DynamicColorPixelTool.loadSkinColorsPreview(pPhenotype, 0);
		}
		Rect rect = pSource.rect;
		int pWidth = (int)rect.width;
		int pHeight = (int)rect.height;
		atlas.checkBounds(pWidth, pHeight);
		int width = atlas.texture.width;
		_ = atlas.texture.height;
		Color32[] pixels = pSource.texture.GetPixels32();
		int width2 = pSource.texture.width;
		for (int i = 0; (float)i < rect.width; i++)
		{
			for (int j = 0; (float)j < rect.height; j++)
			{
				int num = i + (int)rect.x;
				int num2 = j + (int)rect.y;
				int num3 = num + num2 * width2;
				Color32 pColor = pixels[num3];
				if (pColor.a != 0)
				{
					pColor = DynamicColorPixelTool.checkSpecialColors(pColor, pKingdomColor, pCheckForLightColors: true);
					int num4 = i + atlas.last_x;
					int num5 = j + atlas.last_y;
					if (num4 < 0)
					{
						num4 = 0;
					}
					if (num5 < 0)
					{
						num5 = 0;
					}
					num3 = num4 + num5 * width;
					atlas.pixels[num3] = pColor;
				}
			}
		}
		setAtlasDirty(atlas);
		return createFinalSprite(atlas, pSource, pWidth, pHeight);
	}

	public static Sprite createNewSpriteBuilding(DynamicSpritesAsset pAssetAtlas, long pID, Sprite pSource, ColorAsset pKingdomColor)
	{
		UnitSpriteConstructorAtlas atlas = pAssetAtlas.getAtlas();
		Rect rect = pSource.rect;
		int pWidth = (int)rect.width;
		int pHeight = (int)rect.height;
		atlas.checkBounds(pWidth, pHeight);
		int width = atlas.texture.width;
		_ = atlas.texture.height;
		Color32[] pixels = pSource.texture.GetPixels32();
		_light_colors.Clear();
		int width2 = pSource.texture.width;
		for (int i = 0; (float)i < rect.width; i++)
		{
			for (int j = 0; (float)j < rect.height; j++)
			{
				int num = i + (int)rect.x;
				int num2 = j + (int)rect.y;
				int num3 = num + num2 * width2;
				Color32 color = pixels[num3];
				if (color.a != 0)
				{
					if (Toolbox.areColorsEqual(color, Toolbox.color_light))
					{
						_light_colors.Add(new Vector2Int(i, j));
					}
					color = DynamicColorPixelTool.checkSpecialColors(color, pKingdomColor, pCheckForLightColors: true);
					int num4 = i + atlas.last_x;
					int num5 = j + atlas.last_y;
					if (num4 < 0)
					{
						num4 = 0;
					}
					if (num5 < 0)
					{
						num5 = 0;
					}
					num3 = num4 + num5 * width;
					atlas.pixels[num3] = color;
				}
			}
		}
		setAtlasDirty(atlas);
		Sprite result = createFinalSprite(atlas, pSource, pWidth, pHeight);
		if (_light_colors.Count > 0)
		{
			checkBuildingLightSprite(DynamicSpritesLibrary.building_lights, pSource.GetHashCode(), pSource);
		}
		return result;
	}

	private static void checkBuildingLightSprite(DynamicSpritesAsset pQuantumAsset, long pHashcodeMainSprite, Sprite pSprite)
	{
		Sprite sprite = pQuantumAsset.getSprite(pHashcodeMainSprite);
		if ((object)sprite == null)
		{
			sprite = createNewSpriteBuildingLight(pQuantumAsset, pSprite);
			pQuantumAsset.addSprite(pHashcodeMainSprite, sprite);
		}
	}

	public static Sprite createNewSpriteBuildingLight(DynamicSpritesAsset pAsset, Sprite pSource)
	{
		UnitSpriteConstructorAtlas atlas = pAsset.getAtlas();
		Rect rect = pSource.rect;
		int pWidth = (int)rect.width;
		int pHeight = (int)rect.height;
		atlas.checkBounds(pWidth, pHeight);
		int width = pSource.texture.width;
		for (int i = 0; i < _light_colors.Count; i++)
		{
			Vector2Int vector2Int = _light_colors[i];
			drawLightPixel(atlas, vector2Int.x, vector2Int.y, pWidth, pHeight, width, Toolbox.color_light_100);
			drawLightPixel(atlas, vector2Int.x, vector2Int.y - 1, pWidth, pHeight, width, Toolbox.color_light_10);
			drawLightPixel(atlas, vector2Int.x - 1, vector2Int.y, pWidth, pHeight, width, Toolbox.color_light_10);
			drawLightPixel(atlas, vector2Int.x + 1, vector2Int.y, pWidth, pHeight, width, Toolbox.color_light_10);
			drawLightPixel(atlas, vector2Int.x, vector2Int.y + 1, pWidth, pHeight, width, Toolbox.color_light_10);
		}
		setAtlasDirty(atlas);
		return createFinalSprite(atlas, pSource, pWidth, pHeight);
	}

	private static void drawLightPixel(UnitSpriteConstructorAtlas pAtlas, int pColorCoordsX, int pColorCoordsY, int pWidth, int pHeight, int pBodyTextureWidth, Color32 pColor)
	{
		int num = pColorCoordsX + pAtlas.last_x;
		int num2 = pColorCoordsY + pAtlas.last_y;
		if (num < 0)
		{
			num = 0;
		}
		if (num2 < 0)
		{
			num2 = 0;
		}
		int num3 = num + num2 * pAtlas.texture.width;
		if (pAtlas.pixels[num3].a < pColor.a)
		{
			pAtlas.pixels[num3] = pColor;
		}
	}

	public static Sprite createNewSpriteForDebug(Sprite pSpriteSource, ColorAsset pKingdomColor)
	{
		Rect rect = pSpriteSource.rect;
		int width = (int)rect.width;
		int height = (int)rect.height;
		Color32[] pixels = pSpriteSource.texture.GetPixels32();
		Texture2D texture2D = new Texture2D(width, height);
		texture2D.filterMode = FilterMode.Point;
		texture2D.wrapMode = TextureWrapMode.Clamp;
		Color32[] pixels2 = texture2D.GetPixels32();
		int width2 = pSpriteSource.texture.width;
		for (int i = 0; (float)i < rect.width; i++)
		{
			for (int j = 0; (float)j < rect.height; j++)
			{
				int num = i + (int)rect.x;
				int num2 = j + (int)rect.y;
				int num3 = num + num2 * width2;
				Color32 color = pixels[num3];
				if (color.a == 0)
				{
					pixels2[num3] = color;
					continue;
				}
				color = DynamicColorPixelTool.checkSpecialColors(color, pKingdomColor, pCheckForLightColors: true);
				pixels2[num3] = color;
			}
		}
		texture2D.SetPixels32(pixels2);
		texture2D.Apply();
		Sprite sprite = Sprite.Create(texture2D, rect, pSpriteSource.pivot, 1f);
		sprite.name = "gen_" + pSpriteSource.name;
		return sprite;
	}

	public static Sprite createNewSpriteUnit(AnimationFrameData pFrameData, Sprite pSourceBody, Sprite pSourceHead, ColorAsset pKingdomColor, ActorAsset pAsset, int pPhenotypeIndex, int pPhenotypeShade, UnitTextureAtlasID pAtlasID)
	{
		UnitSpriteConstructorAtlas unitSpriteConstructorAtlas = null;
		switch (pAtlasID)
		{
		case UnitTextureAtlasID.Units:
			unitSpriteConstructorAtlas = DynamicSpritesLibrary.units.getAtlas();
			break;
		case UnitTextureAtlasID.Boats:
			unitSpriteConstructorAtlas = DynamicSpritesLibrary.boats.getAtlas();
			break;
		}
		PixelBag pixelBag = PixelBagManager.getPixelBag(pSourceBody, pCheckPhenotypes: true);
		int texture_rect_width = pixelBag.texture_rect_width;
		int texture_rect_height = pixelBag.texture_rect_height;
		int num = 0;
		int num2 = 0;
		DynamicColorPixelTool.setPlaceholderSkinColor(_placeholder_color_skin);
		DynamicColorPixelTool.resetSkinColors();
		if (pPhenotypeIndex != 0)
		{
			DynamicColorPixelTool.loadPhenotype(pPhenotypeIndex, pPhenotypeShade);
		}
		if ((object)pSourceHead != null && pFrameData != null)
		{
			Rect rect = pSourceHead.rect;
			Vector2 pos_head_new = pFrameData.pos_head_new;
			int num3 = (int)pos_head_new.y + (int)rect.height - texture_rect_height;
			if (num3 > 0)
			{
				num2 = num3;
			}
			int num4 = (int)pos_head_new.x + (int)rect.width - texture_rect_width;
			if (num4 > 0)
			{
				num = num4;
			}
			else if (pos_head_new.x < 0f)
			{
				num = -(int)pos_head_new.x;
			}
		}
		int num5 = num;
		int num6 = num2;
		texture_rect_width += num5;
		texture_rect_height += num6;
		unitSpriteConstructorAtlas.checkBounds(texture_rect_width, texture_rect_height);
		fillDebugColor(texture_rect_width, texture_rect_height, unitSpriteConstructorAtlas);
		bool dynamic_sprite_zombie = pAsset.dynamic_sprite_zombie;
		int num7 = num5 + unitSpriteConstructorAtlas.last_x;
		int last_y = unitSpriteConstructorAtlas.last_y;
		drawPixelsAll(pixelBag, unitSpriteConstructorAtlas, pKingdomColor, num7, last_y, dynamic_sprite_zombie, pAsset);
		if ((object)pSourceHead != null && pFrameData != null)
		{
			PixelBag pixelBag2 = PixelBagManager.getPixelBag(pSourceHead, pCheckPhenotypes: true);
			Vector2 pos_head_new2 = pFrameData.pos_head_new;
			Vector2 pivot = pSourceHead.pivot;
			int num8 = (int)pos_head_new2.x - (int)pivot.x;
			int num9 = (int)pos_head_new2.y - (int)pivot.y;
			num7 += num8;
			last_y += num9;
			drawPixelsAll(pixelBag2, unitSpriteConstructorAtlas, pKingdomColor, num7, last_y, dynamic_sprite_zombie, pAsset, pHead: true);
		}
		setAtlasDirty(unitSpriteConstructorAtlas);
		return createFinalSprite(unitSpriteConstructorAtlas, pSourceBody, texture_rect_width, texture_rect_height, num5);
	}

	private static void fillDebugColor(int pWidth, int pHeight, UnitSpriteConstructorAtlas pAtlas)
	{
	}

	private static void drawPixelsAll(PixelBag pBag, UnitSpriteConstructorAtlas pAtlas, ColorAsset pKingdomColor, int pPartX, int pPartY, bool pDynamicZombie, ActorAsset pActorAsset, bool pHead = false)
	{
		Color32[] pixels = pAtlas.pixels;
		int width = pAtlas.texture.width;
		drawPixels(pixels, width, pBag.arr_pixels_k1_0, pKingdomColor.k_color_0, pPartX, pPartY, pDynamicZombie, pActorAsset, pUseNormal: false, pHead);
		drawPixels(pixels, width, pBag.arr_pixels_k1_1, pKingdomColor.k_color_1, pPartX, pPartY, pDynamicZombie, pActorAsset, pUseNormal: false, pHead);
		drawPixels(pixels, width, pBag.arr_pixels_k1_2, pKingdomColor.k_color_2, pPartX, pPartY, pDynamicZombie, pActorAsset, pUseNormal: false, pHead);
		drawPixels(pixels, width, pBag.arr_pixels_k1_3, pKingdomColor.k_color_3, pPartX, pPartY, pDynamicZombie, pActorAsset, pUseNormal: false, pHead);
		drawPixels(pixels, width, pBag.arr_pixels_k1_4, pKingdomColor.k_color_4, pPartX, pPartY, pDynamicZombie, pActorAsset, pUseNormal: false, pHead);
		drawPixels(pixels, width, pBag.arr_pixels_k2_0, pKingdomColor.k2_color_0, pPartX, pPartY, pDynamicZombie, pActorAsset, pUseNormal: false, pHead);
		drawPixels(pixels, width, pBag.arr_pixels_k2_1, pKingdomColor.k2_color_1, pPartX, pPartY, pDynamicZombie, pActorAsset, pUseNormal: false, pHead);
		drawPixels(pixels, width, pBag.arr_pixels_k2_2, pKingdomColor.k2_color_2, pPartX, pPartY, pDynamicZombie, pActorAsset, pUseNormal: false, pHead);
		drawPixels(pixels, width, pBag.arr_pixels_k2_3, pKingdomColor.k2_color_3, pPartX, pPartY, pDynamicZombie, pActorAsset, pUseNormal: false, pHead);
		drawPixels(pixels, width, pBag.arr_pixels_k2_4, pKingdomColor.k2_color_4, pPartX, pPartY, pDynamicZombie, pActorAsset, pUseNormal: false, pHead);
		drawPixels(pixels, width, pBag.arr_pixels_light, Toolbox.color_light_replace, pPartX, pPartY, pDynamicZombie, pActorAsset, pUseNormal: false, pHead);
		drawPixels(pixels, width, pBag.arr_pixels_normal, Toolbox.color_magenta_1, pPartX, pPartY, pDynamicZombie, pActorAsset, pUseNormal: true, pHead);
		drawPixels(pixels, width, pBag.arr_pixels_phenotype_shade_0, DynamicColorPixelTool.phenotype_shade_0, pPartX, pPartY, pDynamicZombie, pActorAsset, pUseNormal: false, pHead);
		drawPixels(pixels, width, pBag.arr_pixels_phenotype_shade_1, DynamicColorPixelTool.phenotype_shade_1, pPartX, pPartY, pDynamicZombie, pActorAsset, pUseNormal: false, pHead);
		drawPixels(pixels, width, pBag.arr_pixels_phenotype_shade_2, DynamicColorPixelTool.phenotype_shade_2, pPartX, pPartY, pDynamicZombie, pActorAsset, pUseNormal: false, pHead);
		drawPixels(pixels, width, pBag.arr_pixels_phenotype_shade_3, DynamicColorPixelTool.phenotype_shade_3, pPartX, pPartY, pDynamicZombie, pActorAsset, pUseNormal: false, pHead);
	}

	private static void drawPixels(Color32[] pPixels, int pAtlasWidth, Pixel[] pListSourcePixels, Color32 pNewColor, int pPartX, int pPartY, bool pDrawDynamicZombie, ActorAsset pActorAsset, bool pUseNormal = false, bool pHead = false)
	{
		if (pListSourcePixels == null)
		{
			return;
		}
		for (int i = 0; i < pListSourcePixels.Length; i++)
		{
			Pixel pixel = pListSourcePixels[i];
			Color32 color = pNewColor;
			int num = pixel.x + pPartX;
			int num2 = pixel.y + pPartY;
			if (num < 0)
			{
				num = 0;
			}
			if (num2 < 0)
			{
				num2 = 0;
			}
			int num3 = num + num2 * pAtlasWidth;
			if (pUseNormal)
			{
				color = pixel.color;
			}
			if (pDrawDynamicZombie)
			{
				color = DynamicColorPixelTool.checkZombieColors(pActorAsset, color, num3 / 3 + num, pHead);
			}
			pPixels[num3] = color;
		}
	}

	public static Sprite getSpriteUnit(AnimationFrameData pFrameData, Sprite pMainSprite, Actor pActor, ColorAsset pKingdomColor, int pPhenotypeIndex, int pPhenotypeShade, UnitTextureAtlasID pTextureAtlasID)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = pPhenotypeIndex;
		long num4 = 0L;
		long num5 = getBodySpriteSmallID(pMainSprite);
		if (pActor.has_rendered_sprite_head)
		{
			ActorAnimationLoader.int_ids_heads.TryGetValue(pActor.cached_sprite_head, out var value);
			if (value == 0)
			{
				int num6 = ActorAnimationLoader.int_ids_heads.Count + 1;
				ActorAnimationLoader.int_ids_heads.Add(pActor.cached_sprite_head, num6);
				value = num6;
			}
			num4 = value;
		}
		if (num3 != 0L)
		{
			num2 = pPhenotypeShade + 1;
		}
		if (pKingdomColor != null)
		{
			num = pKingdomColor.index_id + 1;
		}
		long num7 = num * 1000000000000L + num4 * 1000000000 + num5 * 1000000 + num3 * 1000 + num2;
		if (debug_actor == pActor)
		{
			AssetManager.dynamic_sprites_library.setDebugActor(num7, num, num4, num5, num3, num2);
		}
		DynamicSpritesAsset units = DynamicSpritesLibrary.units;
		Sprite sprite = units.getSprite(num7);
		if ((object)sprite == null)
		{
			sprite = createNewSpriteUnit(pFrameData, pMainSprite, pActor.cached_sprite_head, pKingdomColor, pActor.asset, pPhenotypeIndex, pPhenotypeShade, pTextureAtlasID);
			units.addSprite(num7, sprite);
		}
		return sprite;
	}

	public static void setAtlasDirty(UnitSpriteConstructorAtlas pAtlas)
	{
		AssetManager.dynamic_sprites_library.setDirty();
		pAtlas.dirty = true;
		if (!pAtlas.isBigSpriteSheetAtlas())
		{
			pAtlas.checkDirty();
		}
	}

	public static int getBodySpriteSmallID(Sprite pSprite)
	{
		if (!_int_ids_body.TryGetValue(pSprite, out var value))
		{
			value = _int_ids_body.Count + 1;
			_int_ids_body.Add(pSprite, value);
		}
		return value;
	}
}
