using UnityEngine;
using UnityEngine.UI;

public class UiUnitAvatarElement : MonoBehaviour, IBanner, IBaseMono, IRefreshElement
{
	public Image unit_type_bg;

	[SerializeField]
	private Sprite _type_king;

	[SerializeField]
	private Sprite _type_leader;

	[SerializeField]
	private Sprite _type_captain;

	public UnitAvatarLoader avatarLoader;

	public KingdomBanner kingdomBanner;

	public ClanBanner clanBanner;

	public bool show_banner_kingdom = true;

	public bool show_banner_clan = true;

	[SerializeField]
	private Image _tile_graphics_1;

	[SerializeField]
	private Image _tile_graphics_2;

	[SerializeField]
	private Sprite _tile_inside_boat;

	private Actor _actor;

	public MetaCustomizationAsset meta_asset => AssetManager.meta_customization_library.getAsset(MetaType.Unit);

	public MetaTypeAsset meta_type_asset => AssetManager.meta_type_library.getAsset(MetaType.Unit);

	private void Start()
	{
		setupTooltip();
	}

	public void setupTooltip()
	{
		if (!TryGetComponent<TipButton>(out var component))
		{
			return;
		}
		component.hoverAction = delegate
		{
			if (InputHelpers.mouseSupported)
			{
				tooltipActionActor();
			}
		};
	}

	public void showTooltip()
	{
		tooltipActionActor();
	}

	public void tooltipActionActor()
	{
		if (!_actor.isRekt())
		{
			_actor.showTooltip(this);
		}
	}

	public void load(NanoObject pActor)
	{
		show((Actor)pActor);
	}

	public void show(Actor pActor)
	{
		if (pActor == null)
		{
			base.gameObject.SetActive(value: false);
			return;
		}
		base.gameObject.SetActive(value: true);
		_actor = pActor;
		checkSpecialBg(pActor);
		avatarLoader.load(pActor);
		if (show_banner_kingdom)
		{
			if (pActor.isAlive() && pActor.isKingdomCiv())
			{
				kingdomBanner.gameObject.SetActive(value: true);
				kingdomBanner.load(pActor.kingdom);
			}
			else
			{
				kingdomBanner.gameObject.SetActive(value: false);
			}
		}
		if (show_banner_clan)
		{
			if (pActor.isAlive() && pActor.hasClan())
			{
				clanBanner.gameObject.SetActive(value: true);
				clanBanner.load(pActor.clan);
			}
			else
			{
				clanBanner.gameObject.SetActive(value: false);
			}
		}
		updateTileSprite();
		base.gameObject.name = "UnitAvatar_" + pActor.data.id;
	}

	public void updateTileSprite()
	{
		if (_actor.isRekt() || _actor.current_tile == null)
		{
			_tile_graphics_1.gameObject.SetActive(value: false);
			_tile_graphics_2.gameObject.SetActive(value: false);
			return;
		}
		_tile_graphics_1.gameObject.SetActive(value: true);
		_tile_graphics_2.gameObject.SetActive(value: true);
		if (_actor.is_inside_boat)
		{
			_tile_graphics_1.sprite = _tile_inside_boat;
			_tile_graphics_2.sprite = _tile_inside_boat;
		}
		else
		{
			_tile_graphics_1.sprite = _actor.current_tile.Type.sprites.main.sprite;
			_tile_graphics_2.sprite = _actor.current_tile.Type.sprites.main.sprite;
		}
	}

	private void checkSpecialBg(Actor pActor)
	{
		unit_type_bg.gameObject.SetActive(value: false);
		if (pActor.isAlive())
		{
			if (pActor.hasKingdom() && pActor.isKing())
			{
				unit_type_bg.sprite = _type_king;
				unit_type_bg.gameObject.SetActive(value: true);
			}
			else if (pActor.hasCity() && pActor.isCityLeader())
			{
				unit_type_bg.sprite = _type_leader;
				unit_type_bg.gameObject.SetActive(value: true);
			}
			else if (pActor.is_army_captain)
			{
				unit_type_bg.sprite = _type_captain;
				unit_type_bg.gameObject.SetActive(value: true);
			}
		}
	}

	public void showThisActor()
	{
		if (!_actor.isRekt())
		{
			if (!InputHelpers.mouseSupported && !Tooltip.isShowingFor(this))
			{
				tooltipActionActor();
			}
			else
			{
				ActionLibrary.openUnitWindow(_actor);
			}
		}
	}

	public Actor getActor()
	{
		return _actor;
	}

	private void OnDisable()
	{
		_actor = null;
	}

	public bool isSameActor(Actor pActor)
	{
		return _actor == pActor;
	}

	public MetaCustomizationAsset GetMetaAsset()
	{
		return AssetManager.meta_customization_library.get("unit");
	}

	public string getName()
	{
		return _actor.getName();
	}

	public NanoObject GetNanoObject()
	{
		return _actor;
	}

	Transform IBaseMono.get_transform()
	{
		return base.transform;
	}

	GameObject IBaseMono.get_gameObject()
	{
		return base.gameObject;
	}

	T IBaseMono.GetComponent<T>()
	{
		return GetComponent<T>();
	}
}
