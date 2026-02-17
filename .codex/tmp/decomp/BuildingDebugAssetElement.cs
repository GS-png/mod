using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingDebugAssetElement : BaseDebugAssetElement<BuildingAsset>
{
	public BuildingDebugAnimationElement spawn;

	public BuildingDebugAnimationElement main;

	public BuildingDebugAnimationElement disabled;

	public BuildingDebugAnimationElement ruin;

	public BuildingDebugAnimationElement special;

	public Image construction;

	public Image mini;

	public override void setData(BuildingAsset pAsset)
	{
		asset = pAsset;
		title.text = asset.id;
		initAnimations();
		initStats();
	}

	protected override void initAnimations()
	{
		BuildingSprites building_sprites = asset.building_sprites;
		spawn.setData(asset);
		main.setData(asset);
		disabled.setData(asset);
		ruin.setData(asset);
		special.setData(asset);
		List<DebugAnimatedVariation> list = new List<DebugAnimatedVariation>();
		List<DebugAnimatedVariation> list2 = new List<DebugAnimatedVariation>();
		List<DebugAnimatedVariation> list3 = new List<DebugAnimatedVariation>();
		List<DebugAnimatedVariation> list4 = new List<DebugAnimatedVariation>();
		List<DebugAnimatedVariation> list5 = new List<DebugAnimatedVariation>();
		foreach (BuildingAnimationData animation_datum in asset.building_sprites.animation_data)
		{
			list.Add(new DebugAnimatedVariation(getBuildingColoredSprites(animation_datum.spawn), animation_datum.animated));
			list2.Add(new DebugAnimatedVariation(getBuildingColoredSprites(animation_datum.main), animation_datum.animated));
			list3.Add(new DebugAnimatedVariation(getBuildingColoredSprites(animation_datum.main_disabled), animation_datum.animated));
			list4.Add(new DebugAnimatedVariation(getBuildingColoredSprites(animation_datum.ruins), animation_datum.animated));
			list5.Add(new DebugAnimatedVariation(getBuildingColoredSprites(animation_datum.special), animation_datum.animated));
		}
		spawn.setFrames(list, asset.has_sprites_spawn);
		main.setFrames(list2, asset.has_sprites_main);
		disabled.setFrames(list3, asset.has_sprites_main_disabled);
		ruin.setFrames(list4, asset.has_sprites_ruin);
		special.setFrames(list5, asset.has_sprites_special);
		if (building_sprites.construction != null)
		{
			construction.sprite = building_sprites.construction;
		}
		else if (asset.has_sprite_construction)
		{
			construction.sprite = no_animation;
		}
		else
		{
			construction.color = Color.clear;
		}
		mini.sprite = loadMini();
	}

	private Sprite loadMini()
	{
		string text = asset.sprite_path;
		if (string.IsNullOrEmpty(text))
		{
			text = asset.main_path + asset.id;
		}
		text += "/mini_0";
		Sprite sprite = SpriteTextureLoader.getSprite(text);
		if (sprite == null)
		{
			Debug.LogError("Not found mini sprite for building: " + asset.id);
			return sprite;
		}
		KingdomAsset kingdomAsset = AssetManager.kingdoms.get("mad");
		if (!asset.has_kingdom_color)
		{
			return sprite;
		}
		ColorAsset debug_color_asset = kingdomAsset.debug_color_asset;
		Texture2D texture2D = new Texture2D(sprite.texture.width, sprite.texture.height);
		texture2D.filterMode = sprite.texture.filterMode;
		for (int i = 0; i < texture2D.width; i++)
		{
			for (int j = 0; j < texture2D.height; j++)
			{
				Color pixel = sprite.texture.GetPixel(i, j);
				Color color = getColor(pixel, debug_color_asset);
				texture2D.SetPixel(i, j, color);
			}
		}
		texture2D.Apply();
		return Sprite.Create(texture2D, new Rect(Vector2.zero, new Vector2(texture2D.width, texture2D.height)), new Vector2(0.5f, 0.5f), 1f);
	}

	private Color32 getColor(Color pOrigColor, ColorAsset pKingdomColor)
	{
		if (Toolbox.areColorsEqual(pOrigColor, Toolbox.color_magenta_0))
		{
			pOrigColor = pKingdomColor.k_color_0;
		}
		else if (Toolbox.areColorsEqual(pOrigColor, Toolbox.color_magenta_1))
		{
			pOrigColor = pKingdomColor.k_color_1;
		}
		else if (Toolbox.areColorsEqual(pOrigColor, Toolbox.color_magenta_2))
		{
			pOrigColor = pKingdomColor.k_color_2;
		}
		else if (Toolbox.areColorsEqual(pOrigColor, Toolbox.color_magenta_3))
		{
			pOrigColor = pKingdomColor.k_color_3;
		}
		else if (Toolbox.areColorsEqual(pOrigColor, Toolbox.color_magenta_4))
		{
			pOrigColor = pKingdomColor.k_color_4;
		}
		return pOrigColor;
	}

	public override void update()
	{
		if (base.gameObject.activeSelf)
		{
			spawn.update();
			main.update();
			disabled.update();
			ruin.update();
			special.update();
		}
	}

	public override void stopAnimations()
	{
		spawn.stopAnimations();
		main.stopAnimations();
		disabled.stopAnimations();
		ruin.stopAnimations();
		special.stopAnimations();
	}

	public override void startAnimations()
	{
		spawn.startAnimations();
		main.startAnimations();
		disabled.startAnimations();
		ruin.startAnimations();
		special.startAnimations();
	}

	private Sprite[] getBuildingColoredSprites(Sprite[] pSprites)
	{
		if (pSprites == null)
		{
			return new Sprite[0];
		}
		Sprite[] array = new Sprite[pSprites.Length];
		for (int i = 0; i < pSprites.Length; i++)
		{
			array[i] = getBuildingColoredSprite(pSprites[i]);
		}
		return array;
	}

	private Sprite getBuildingColoredSprite(Sprite pMainSprite)
	{
		ColorAsset pColor = null;
		if (asset.has_kingdom_color)
		{
			pColor = AssetManager.kingdoms.get("mad").debug_color_asset;
		}
		return DynamicSprites.getRecoloredBuilding(pMainSprite, pColor, asset.atlas_asset);
	}

	protected override void initStats()
	{
		base.initStats();
		showStat("health", asset.base_stats["health"]);
		showStat("damage", asset.base_stats["damage"]);
		showStat("targets", asset.base_stats["targets"]);
		showStat("area_of_effect", asset.base_stats["area_of_effect"]);
	}

	protected override void showAssetWindow()
	{
		base.showAssetWindow();
		ScrollWindow.showWindow("building_asset");
	}
}
