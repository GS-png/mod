using System.Collections.Generic;
using UnityEngine;

public static class ActorAnimationLoader
{
	public static readonly Dictionary<Sprite, int> int_ids_heads = new Dictionary<Sprite, int>();

	private static readonly Dictionary<string, AnimationContainerUnit> _dict_units = new Dictionary<string, AnimationContainerUnit>();

	private static readonly Dictionary<string, AnimationDataBoat> _dict_boats = new Dictionary<string, AnimationDataBoat>();

	private static readonly Dictionary<string, Sprite> _dict_civ_heads = new Dictionary<string, Sprite>();

	public static int count_units => _dict_units.Count;

	public static int count_boats => _dict_boats.Count;

	public static int count_heads => _dict_civ_heads.Count;

	public static Sprite getHeadSpecial(string pPath)
	{
		if (!_dict_civ_heads.TryGetValue(pPath, out var value))
		{
			Sprite[] spriteList = SpriteTextureLoader.getSpriteList(pPath);
			foreach (Sprite value2 in spriteList)
			{
				_dict_civ_heads.TryAdd(pPath, value2);
			}
			return _dict_civ_heads[pPath];
		}
		return value;
	}

	public static Sprite getHead(string pPath, int pHeadIndex)
	{
		string key = $"{pPath}_head_{pHeadIndex}";
		if (!_dict_civ_heads.TryGetValue(key, out var value))
		{
			Sprite[] spriteList = SpriteTextureLoader.getSpriteList(pPath);
			foreach (Sprite sprite in spriteList)
			{
				string key2 = pPath + "_" + sprite.name;
				_dict_civ_heads.TryAdd(key2, sprite);
			}
			return _dict_civ_heads[key];
		}
		return value;
	}

	public static AnimationDataBoat loadAnimationBoat(string pTexturePath)
	{
		if (!_dict_boats.TryGetValue(pTexturePath, out var value))
		{
			Dictionary<string, Sprite> dictionary = new Dictionary<string, Sprite>();
			Sprite[] spriteList = SpriteTextureLoader.getSpriteList("actors/boats/" + pTexturePath);
			Sprite[] array = spriteList;
			foreach (Sprite sprite in array)
			{
				dictionary.Add(sprite.name, sprite);
			}
			value = new AnimationDataBoat();
			value.broken = new ActorAnimation();
			value.broken.frames = new Sprite[1] { dictionary["broken"] };
			value.normal = new ActorAnimation();
			value.normal.frames = new Sprite[1] { dictionary["normal"] };
			array = spriteList;
			foreach (Sprite sprite2 in array)
			{
				if (!sprite2.name.Contains("@1") && sprite2.name.Contains("@"))
				{
					createBoatAnimationArray(value, dictionary, sprite2.name);
				}
			}
			_dict_boats[pTexturePath] = value;
		}
		return value;
	}

	private static void createBoatAnimationArray(AnimationDataBoat pAnimationData, Dictionary<string, Sprite> pDict, string pID, float pTimeBetween = 0.2f)
	{
		int key = int.Parse(pID.Split('@')[0]);
		ActorAnimation actorAnimation = new ActorAnimation();
		actorAnimation.frames = new Sprite[2];
		actorAnimation.frames[0] = pDict[key + "@" + 0];
		actorAnimation.frames[1] = pDict[key + "@" + 1];
		pAnimationData.dict.Add(key, actorAnimation);
	}

	public static AnimationContainerUnit getAnimationContainer(string pTexturePath, ActorAsset pAsset, SubspeciesTrait pEggAsset = null, SubspeciesTrait pMutationSkinAsset = null)
	{
		if (!_dict_units.TryGetValue(pTexturePath, out var value))
		{
			return createAnimationContainer(pTexturePath, pAsset, pEggAsset, pMutationSkinAsset);
		}
		return value;
	}

	private static AnimationContainerUnit createAnimationContainer(string pTexturePath, ActorAsset pAsset, SubspeciesTrait pEggAsset, SubspeciesTrait pMutationSkinAsset = null)
	{
		AnimationContainerUnit animationContainerUnit = new AnimationContainerUnit(pTexturePath);
		_dict_units.Add(pTexturePath, animationContainerUnit);
		string[] animation_walk;
		string[] animation_swim;
		string[] animation_idle;
		if (pTexturePath.Contains("eggs/"))
		{
			animation_walk = pEggAsset.animation_walk;
			animation_swim = pEggAsset.animation_swim;
			animation_idle = pEggAsset.animation_idle;
		}
		else if (pTexturePath.Contains("species/mutations"))
		{
			animation_walk = pMutationSkinAsset.animation_walk;
			animation_swim = pMutationSkinAsset.animation_swim;
			animation_idle = pMutationSkinAsset.animation_idle;
		}
		else
		{
			animation_walk = pAsset.animation_walk;
			animation_swim = pAsset.animation_swim;
			animation_idle = pAsset.animation_idle;
		}
		generateFrameData(pTexturePath, animationContainerUnit, animationContainerUnit.sprites, animation_swim);
		generateFrameData(pTexturePath, animationContainerUnit, animationContainerUnit.sprites, animation_walk);
		generateFrameData(pTexturePath, animationContainerUnit, animationContainerUnit.sprites, animation_idle);
		if (animation_swim != null && animation_swim.Length != 0)
		{
			animationContainerUnit.swimming = createAnim(0, animationContainerUnit.sprites, animation_swim);
			if (animationContainerUnit.swimming != null)
			{
				animationContainerUnit.has_swimming = true;
			}
		}
		if (animation_walk != null && animation_walk.Length != 0)
		{
			animationContainerUnit.walking = createAnim(1, animationContainerUnit.sprites, animation_walk);
			if (animationContainerUnit.walking != null)
			{
				animationContainerUnit.has_walking = true;
			}
		}
		if (animation_idle != null && animation_idle.Length != 0)
		{
			animationContainerUnit.idle = createAnim(2, animationContainerUnit.sprites, animation_idle);
			if (animationContainerUnit.idle != null)
			{
				animationContainerUnit.has_idle = true;
			}
		}
		if (pTexturePath.Contains("/child"))
		{
			animationContainerUnit.child = true;
		}
		ActorTextureSubAsset actorTextureSubAsset = ((pMutationSkinAsset == null || !pMutationSkinAsset.is_mutation_skin) ? pAsset.texture_asset : pMutationSkinAsset.texture_asset);
		if (actorTextureSubAsset.texture_heads != string.Empty)
		{
			animationContainerUnit.heads = SpriteTextureLoader.getSpriteList(actorTextureSubAsset.texture_heads);
		}
		if (actorTextureSubAsset.texture_heads_male != string.Empty)
		{
			animationContainerUnit.heads_male = SpriteTextureLoader.getSpriteList(actorTextureSubAsset.texture_heads_male);
		}
		if (actorTextureSubAsset.texture_heads_female != string.Empty)
		{
			animationContainerUnit.heads_female = SpriteTextureLoader.getSpriteList(actorTextureSubAsset.texture_heads_female);
		}
		if (animationContainerUnit.heads == null || animationContainerUnit.heads.Length == 0)
		{
			animationContainerUnit.heads = animationContainerUnit.heads_male;
		}
		if (actorTextureSubAsset.render_heads_for_children)
		{
			animationContainerUnit.render_heads_for_children = true;
		}
		return animationContainerUnit;
	}

	private static void generateFrameData(string pFrameString, AnimationContainerUnit pAnimContainer, Dictionary<string, Sprite> pFrames, string[] pStringIDs)
	{
		if (string.IsNullOrEmpty(pFrameString) || pStringIDs == null)
		{
			return;
		}
		foreach (string text in pStringIDs)
		{
			if (!pAnimContainer.dict_frame_data.ContainsKey(text) && pFrames.ContainsKey(text))
			{
				AnimationFrameData animationFrameData = new AnimationFrameData();
				animationFrameData.id = text;
				animationFrameData.sheet_path = pFrameString;
				Sprite sprite = pFrames[text];
				animationFrameData.size_unit = sprite.rect.size;
				string key = text + "_head";
				if (pFrames.TryGetValue(key, out var value))
				{
					float num = value.rect.x - sprite.rect.x;
					num = num - sprite.pivot.x + value.pivot.x;
					float num2 = value.rect.y - sprite.rect.y;
					num2 = num2 - sprite.pivot.y + value.pivot.y;
					animationFrameData.pos_head = new Vector2(num, num2);
					float x = value.rect.x - sprite.rect.x;
					float y = value.rect.y - sprite.rect.y;
					animationFrameData.pos_head_new = new Vector2(x, y);
					animationFrameData.show_head = true;
				}
				string key2 = text + "_item";
				if (pFrames.TryGetValue(key2, out var value2))
				{
					float num3 = value2.rect.x - sprite.rect.x;
					num3 = num3 - sprite.pivot.x + value2.pivot.x;
					float num4 = value2.rect.y - sprite.rect.y;
					num4 = num4 - sprite.pivot.y + value2.pivot.y;
					animationFrameData.pos_item = new Vector2(num3, num4);
					animationFrameData.show_item = true;
				}
				pAnimContainer.dict_frame_data.Add(text, animationFrameData);
			}
		}
	}

	private static ActorAnimation createAnim(int pID, Dictionary<string, Sprite> pDict, string[] pStringIDs)
	{
		Sprite[] array = createArray(pDict, pStringIDs);
		if (array.Length == 0)
		{
			return null;
		}
		return new ActorAnimation
		{
			id = pID,
			frames = array
		};
	}

	private static Sprite[] createArray(Dictionary<string, Sprite> pDict, string[] pStringIDs)
	{
		using ListPool<Sprite> listPool = new ListPool<Sprite>(pStringIDs.Length);
		foreach (string key in pStringIDs)
		{
			if (!pDict.TryGetValue(key, out var value))
			{
				break;
			}
			listPool.Add(value);
		}
		return listPool.ToArray();
	}
}
