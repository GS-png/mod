using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitAvatarLoader : MonoBehaviour
{
	private const float DEFAULT_ANIMATION_SPEED = 8f;

	private const float ANIMATION_SPEED_ITEM = 5f;

	private const float FLOATING_UNITS_ANCHOR = 0.25f;

	private const float DEFAULT_AVATAR_SCALE = 2.5f;

	private const float DIED_AVATAR_SCALE = 1f;

	private static int _syntetic_index;

	public float avatarSize = 1f;

	[SerializeField]
	private Transform _frame;

	[SerializeField]
	private RectTransform _actor_and_item_container;

	[SerializeField]
	private Image _actor_image;

	[SerializeField]
	private Image _item_image;

	[SerializeField]
	private Sprite _died_sprite;

	private Actor _actor;

	private ActorAvatarData _data;

	private AnimationContainerUnit _animation_container;

	private readonly List<Sprite> _unit_sprites = new List<Sprite>();

	private readonly List<Sprite> _item_sprites = new List<Sprite>();

	private readonly List<Vector3> _item_positions = new List<Vector3>();

	private readonly List<bool> _item_show_frames = new List<bool>();

	private readonly List<AvatarEffect> _effects = new List<AvatarEffect>();

	[SerializeField]
	private AvatarEffect _effect_prefab;

	[SerializeField]
	private Transform _effects_parent_attached_below;

	[SerializeField]
	private Transform _effects_parent_attached_above;

	[SerializeField]
	private Transform _effects_parent_below;

	[SerializeField]
	private Transform _effects_parent_above;

	private ObjectPoolGenericMono<AvatarEffect> _effects_pool_attached_below;

	private ObjectPoolGenericMono<AvatarEffect> _effects_pool_attached_above;

	private ObjectPoolGenericMono<AvatarEffect> _effects_pool_below;

	private ObjectPoolGenericMono<AvatarEffect> _effects_pool_above;

	private bool _show_item;

	private bool _animated;

	private float _animation_speed = 8f;

	private int _last_frame_index;

	private int _last_frame_index_item;

	private bool _same_actor_reloaded;

	private bool _same_skin_mutation_reloaded;

	private bool _is_swimming;

	private bool _died;

	public void load(Actor pActor)
	{
		_actor = pActor;
		_same_actor_reloaded = _actor == pActor;
		if (_data == null)
		{
			_data = new ActorAvatarData();
		}
		if (!pActor.isAlive())
		{
			load(pDied: true);
			return;
		}
		_same_skin_mutation_reloaded = _data?.mutation_skin_asset == pActor.subspecies?.mutation_skin_asset;
		_data.setData(pActor);
		if (!_data.asset.has_override_sprite)
		{
			_animation_container = DynamicActorSpriteCreatorUI.getContainerForUI(_data.asset, _data.is_adult, _data.getTextureAsset(), _data.mutation_skin_asset, _data.is_egg, _data.egg_asset, _actor.getUnitTexturePath());
		}
		load();
	}

	public void load(ActorAvatarData pData, bool pSameActor = false)
	{
		_died = false;
		_same_actor_reloaded = pSameActor;
		_same_skin_mutation_reloaded = _data?.mutation_skin_asset == pData.mutation_skin_asset;
		_data = pData;
		if (!_data.asset.has_override_sprite)
		{
			_animation_container = DynamicActorSpriteCreatorUI.getContainerForUI(_data.asset, _data.is_adult, _data.getTextureAsset(), _data.mutation_skin_asset, _data.is_egg, _data.egg_asset);
		}
		load();
	}

	private void load(bool pDied = false)
	{
		if (_effects_pool_attached_below == null)
		{
			_effects_pool_attached_below = new ObjectPoolGenericMono<AvatarEffect>(_effect_prefab, _effects_parent_attached_below);
		}
		if (_effects_pool_attached_above == null)
		{
			_effects_pool_attached_above = new ObjectPoolGenericMono<AvatarEffect>(_effect_prefab, _effects_parent_attached_above);
		}
		if (_effects_pool_below == null)
		{
			_effects_pool_below = new ObjectPoolGenericMono<AvatarEffect>(_effect_prefab, _effects_parent_below);
		}
		if (_effects_pool_above == null)
		{
			_effects_pool_above = new ObjectPoolGenericMono<AvatarEffect>(_effect_prefab, _effects_parent_above);
		}
		clear();
		_died = pDied;
		if (_died)
		{
			base.transform.localScale = new Vector3(1f * avatarSize, 1f * avatarSize, 0f);
			showDied();
			return;
		}
		base.transform.localScale = new Vector3(_data.asset.inspect_avatar_scale * avatarSize, _data.asset.inspect_avatar_scale * avatarSize, 0f);
		if (_frame != null)
		{
			_frame.localScale = new Vector3(2.5f / (_data.asset.inspect_avatar_scale * avatarSize), 2.5f / (_data.asset.inspect_avatar_scale * avatarSize), 0f);
		}
		loadItemSprites();
		bool flag = _animation_container?.has_walking ?? false;
		if (_data.asset.has_override_sprite && !_data.asset.has_override_avatar_frames && !_data.asset.is_boat)
		{
			_animated = false;
		}
		else
		{
			_animated = (flag || _data.asset.is_boat || _data.asset.has_override_avatar_frames) && !_data.is_egg && !_data.is_lying && !_data.is_stop_idle_animation;
		}
		if (!_animated)
		{
			showStatic();
		}
		else
		{
			showAnimation();
		}
		checkRotationAndPivot();
		showStatusEffects();
	}

	private void loadItemSprites()
	{
		IHandRenderer item_renderer = _data.item_renderer;
		_show_item = _data.asset.use_items && item_renderer != null;
		if (!_show_item)
		{
			return;
		}
		if (!item_renderer.is_animated)
		{
			Sprite itemMainSpriteFrame = ItemRendering.getItemMainSpriteFrame(item_renderer);
			if ((object)itemMainSpriteFrame != null)
			{
				_item_image.sprite = getColoredItemSprite(itemMainSpriteFrame, item_renderer);
			}
			return;
		}
		Sprite[] sprites = item_renderer.getSprites();
		foreach (Sprite pSprite in sprites)
		{
			Sprite coloredItemSprite = getColoredItemSprite(pSprite, item_renderer);
			_item_sprites.Add(coloredItemSprite);
		}
		int actualSpriteIndexItem = getActualSpriteIndexItem();
		_item_image.sprite = _item_sprites[actualSpriteIndexItem];
	}

	private void clear()
	{
		_died = false;
		_unit_sprites.Clear();
		_item_sprites.Clear();
		_item_positions.Clear();
		_item_show_frames.Clear();
		_effects.Clear();
		_effects_pool_above.clear();
		_effects_pool_below.clear();
		_effects_pool_attached_above.clear();
		_effects_pool_attached_below.clear();
	}

	private void Update()
	{
		if (_died)
		{
			return;
		}
		updateEffects();
		updateItem();
		if (_animated)
		{
			int actualSpriteIndex = getActualSpriteIndex();
			if (_last_frame_index != actualSpriteIndex)
			{
				_last_frame_index = actualSpriteIndex;
				_actor_image.sprite = _unit_sprites[_last_frame_index];
				syncItemWithUnit();
			}
		}
	}

	private void updateEffects()
	{
		foreach (AvatarEffect effect in _effects)
		{
			effect.update(Time.deltaTime);
		}
	}

	private void updateItem()
	{
		if (_show_item && _data.item_renderer.is_animated)
		{
			int actualSpriteIndexItem = getActualSpriteIndexItem();
			if (_last_frame_index_item != actualSpriteIndexItem)
			{
				_last_frame_index_item = actualSpriteIndexItem;
				_item_image.sprite = _item_sprites[_last_frame_index_item];
			}
		}
	}

	private void checkRotationAndPivot()
	{
		checkRotation();
		checkPivot();
	}

	private float getRotation()
	{
		if (_data.is_lying && (!_data.is_touching_liquid || !_data.is_unconscious))
		{
			return 90f;
		}
		return 0f;
	}

	private void checkRotation()
	{
		Quaternion rotation = Quaternion.Euler(0f, 0f, getRotation());
		_actor_and_item_container.rotation = rotation;
	}

	private void checkPivot()
	{
		Vector2 pivot = ((!_data.is_lying || (_data.is_touching_liquid && _data.is_unconscious)) ? new Vector2(0.5f, 0.5f) : new Vector2(0.75f, 0.25f));
		_actor_and_item_container.pivot = pivot;
	}

	private void syncItemWithUnit()
	{
		if (_show_item)
		{
			bool flag = _item_show_frames[_last_frame_index];
			_item_image.enabled = flag;
			if (flag)
			{
				Vector3 pPosition = _item_positions[_last_frame_index];
				setImageParams(_item_image, pPosition);
			}
		}
	}

	private void showDied()
	{
		_show_item = false;
		_animated = false;
		_is_swimming = false;
		_actor_image.sprite = _died_sprite;
		setImageParams(_actor_image, Vector2.zero);
		_item_image.enabled = false;
	}

	private void showStatic()
	{
		Vector3 avatarPosition = getAvatarPosition();
		Sprite sprite;
		Sprite sprite2;
		if (_data.asset.has_override_sprite)
		{
			sprite = null;
			sprite2 = _data.asset.get_override_sprite(_actor);
		}
		else
		{
			if (_data.is_touching_liquid && _animation_container.has_swimming && !_data.is_inside_boat)
			{
				_is_swimming = true;
				sprite = _animation_container.swimming.frames[0];
			}
			else
			{
				_is_swimming = false;
				sprite = _animation_container.walking.frames[0];
			}
			sprite2 = _data.getColoredSprite(sprite, _animation_container);
		}
		_actor_image.sprite = sprite2;
		setImageParams(_actor_image, avatarPosition);
		if (_show_item)
		{
			AnimationFrameData animationFrameData = _animation_container.dict_frame_data[sprite.name];
			if (!animationFrameData.show_item)
			{
				_item_image.enabled = false;
				return;
			}
			_item_image.enabled = true;
			avatarPosition = getAvatarPosition();
			avatarPosition.x += animationFrameData.pos_item.x;
			avatarPosition.y += animationFrameData.pos_item.y;
			setImageParams(_item_image, avatarPosition);
		}
		else
		{
			_item_image.enabled = false;
		}
		string text = ((_actor != null) ? _actor.data.id.ToString() : $"syntetic_{_data.asset.id}_{++_syntetic_index}");
		base.gameObject.name = "UnitAvatar_" + text;
	}

	private void showAnimation()
	{
		_item_image.enabled = _show_item;
		ActorAsset asset = _data.asset;
		Vector2 vector = new Vector2(0.5f, 0f);
		if (_data.is_hovering && !_data.is_lying && !_data.is_immovable)
		{
			vector.y = 0.25f;
		}
		_actor_image.rectTransform.anchorMax = vector;
		_actor_image.rectTransform.anchorMin = vector;
		_item_image.rectTransform.anchorMax = vector;
		_item_image.rectTransform.anchorMin = vector;
		Vector2 vector2;
		if (asset.has_override_avatar_frames)
		{
			vector2 = getAvatarPosition();
			Sprite[] collection = asset.get_override_avatar_frames(_actor);
			_unit_sprites.AddRange(collection);
			_animation_speed = 8f;
		}
		else
		{
			vector2 = Vector2.zero;
			ActorAnimation actorAnimation;
			if (asset.is_boat)
			{
				actorAnimation = DynamicActorSpriteCreatorUI.getBoatAnimation(ActorAnimationLoader.loadAnimationBoat(asset.id));
				_animation_speed = 8f;
			}
			else if (_data.is_touching_liquid && _animation_container.has_swimming && !_data.is_inside_boat)
			{
				_is_swimming = true;
				actorAnimation = _animation_container.swimming;
				_animation_speed = asset.animation_swim_speed;
			}
			else
			{
				_is_swimming = false;
				actorAnimation = _animation_container.walking;
				_animation_speed = asset.animation_walk_speed;
			}
			Sprite[] frames = actorAnimation.frames;
			foreach (Sprite sprite in frames)
			{
				Sprite coloredSprite = _data.getColoredSprite(sprite, _animation_container);
				_unit_sprites.Add(coloredSprite);
				if (!_show_item)
				{
					continue;
				}
				AnimationFrameData animationFrameData = _animation_container.dict_frame_data[sprite.name];
				float num = 0f;
				float num2 = 0f;
				if (animationFrameData != null)
				{
					if (!animationFrameData.show_item)
					{
						_item_show_frames.Add(item: false);
						_item_positions.Add(Vector3.zero);
						continue;
					}
					num = animationFrameData.pos_item.x;
					num2 = animationFrameData.pos_item.y;
				}
				float x = asset.inspect_avatar_offset_x + num;
				float y = asset.inspect_avatar_offset_y + num2;
				Vector3 item = new Vector3(x, y, -0.01f);
				_item_positions.Add(item);
				_item_show_frames.Add(item: true);
			}
		}
		if (!_same_actor_reloaded || !_same_skin_mutation_reloaded || _last_frame_index >= _unit_sprites.Count)
		{
			_last_frame_index = 0;
		}
		_actor_image.sprite = _unit_sprites[_last_frame_index];
		setImageParams(_actor_image, vector2);
		if (_show_item)
		{
			setImageParams(_item_image, _item_positions[_last_frame_index]);
		}
	}

	private void showStatusEffects()
	{
		if (_data.statuses == null)
		{
			return;
		}
		foreach (string status in _data.statuses)
		{
			if (_data.statuses_gameplay != null && _data.statuses_gameplay[status].is_finished)
			{
				continue;
			}
			StatusAsset statusAsset = AssetManager.status.get(status);
			if (statusAsset.need_visual_render && statusAsset.render_check(_data.asset) && (statusAsset.has_override_sprite || statusAsset.texture != null))
			{
				AvatarEffect next = getEffectsPool(statusAsset).getNext();
				_effects.Add(next);
				Image image = next.image;
				RectTransform rectTransform = image.rectTransform;
				Vector2 vector = new Vector2(0.5f, 0f);
				if (_data.is_hovering && !_data.is_lying && !_data.is_immovable)
				{
					vector.y = 0.25f;
				}
				rectTransform.anchorMax = vector;
				rectTransform.anchorMin = vector;
				next.load(statusAsset, _actor, this);
				Rect rect = image.sprite.rect;
				setImageParams(image, new Vector3
				{
					x = statusAsset.offset_x_ui * (rect.width * statusAsset.scale),
					y = statusAsset.offset_y_ui * (rect.height * statusAsset.scale)
				}, statusAsset.scale);
				next.setInitialPosition(image.transform.localPosition);
			}
		}
	}

	private void setImageParams(Image pImage, Vector3 pPosition, float pScale = 1f)
	{
		pImage.rectTransform.sizeDelta = new Vector2(pImage.sprite.rect.width * pScale, pImage.sprite.rect.height * pScale);
		float x = pImage.sprite.pivot.x / pImage.sprite.rect.width;
		float y = pImage.sprite.pivot.y / pImage.sprite.rect.height;
		pImage.rectTransform.pivot = new Vector2(x, y);
		pImage.rectTransform.anchoredPosition = pPosition;
	}

	private Sprite getColoredItemSprite(Sprite pSprite, IHandRenderer pIHandRenderer)
	{
		ColorAsset colorAsset = _data.kingdom_color;
		if (!pIHandRenderer.is_colored)
		{
			colorAsset = null;
		}
		if (pIHandRenderer.is_colored && colorAsset == null)
		{
			throw new InvalidOperationException("ItemRenderer is colored but no color asset found");
		}
		return DynamicSprites.getCachedAtlasItemSprite(DynamicSprites.getItemSpriteID(pSprite, colorAsset), pSprite, colorAsset);
	}

	public int getActualSpriteIndex()
	{
		int result = 0;
		if (_animated)
		{
			result = AnimationHelper.getSpriteIndex((Time.time + (float)getAnimationHashCode()) * _animation_speed, 0, _unit_sprites.Count);
		}
		return result;
	}

	private int getActualSpriteIndexItem()
	{
		return AnimationHelper.getSpriteIndex((Time.time + (float)getAnimationHashCode()) * 5f, 0, _item_sprites.Count);
	}

	private int getAnimationHashCode()
	{
		return _data.actor_hash;
	}

	private Vector3 getAvatarPosition()
	{
		return new Vector3(_data.asset.inspect_avatar_offset_x, _data.asset.inspect_avatar_offset_y);
	}

	private ObjectPoolGenericMono<AvatarEffect> getEffectsPool(StatusAsset pAsset)
	{
		if (pAsset.use_parent_rotation)
		{
			if (pAsset.position_z >= 0f)
			{
				return _effects_pool_attached_above;
			}
			return _effects_pool_attached_below;
		}
		if (pAsset.position_z >= 0f)
		{
			return _effects_pool_above;
		}
		return _effects_pool_below;
	}

	public bool actorStateChanged()
	{
		if (_died)
		{
			return false;
		}
		bool num = (!_is_swimming && _actor.isTouchingLiquid()) || (_is_swimming && !_actor.isTouchingLiquid());
		bool flag = _data.item_renderer != _actor.getHandRendererAsset();
		return num || flag;
	}

	public ActorAvatarData getData()
	{
		return _data;
	}

	public AnimationContainerUnit getAnimationContainer()
	{
		return _animation_container;
	}
}
