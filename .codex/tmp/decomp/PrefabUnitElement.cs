using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PrefabUnitElement : WindowListElementBaseActor, IPointerMoveHandler, IEventSystemHandler
{
	private Actor _actor;

	public Text unitName;

	public UiUnitAvatarElement avatarElement;

	public StatBar health_bar;

	public CountUpOnClick text_damage;

	public CountUpOnClick text_level;

	public CountUpOnClick text_kills;

	public CountUpOnClick text_age;

	public Image icon_sex;

	[SerializeField]
	private Image _icon_species;

	[SerializeField]
	private GameObject _icon_favorite;

	private void Awake()
	{
		initTooltip();
	}

	internal void show(Actor pActor)
	{
		_actor = pActor;
		unitName.text = pActor.coloredName;
		avatarElement.show(pActor);
		health_bar.setBar(pActor.getHealth(), pActor.getMaxHealth(), "");
		text_level.setValue(pActor.level);
		text_kills.setValue(pActor.data.kills);
		text_age.setValue(pActor.getAge());
		if (pActor.asset.inspect_sex)
		{
			icon_sex.gameObject.SetActive(value: true);
			if (pActor.isSexMale())
			{
				icon_sex.sprite = SpriteTextureLoader.getSprite("ui/icons/IconMale");
			}
			else
			{
				icon_sex.sprite = SpriteTextureLoader.getSprite("ui/icons/IconFemale");
			}
		}
		else
		{
			icon_sex.gameObject.SetActive(value: false);
		}
		_icon_species.sprite = _actor.asset.getSpriteIcon();
		toggleFavorited(_actor.isFavorite());
	}

	public void clickLocate()
	{
		WorldLog.locationFollow(_actor);
	}

	public void clickInspect()
	{
		if (!InputHelpers.mouseSupported && !Tooltip.isShowingFor(this))
		{
			tooltipAction();
		}
		else
		{
			ActionLibrary.openUnitWindow(_actor);
		}
	}

	public Actor getActor()
	{
		return _actor;
	}

	public void toggleFavorited(bool pState)
	{
		_icon_favorite.SetActive(pState);
	}

	private void OnDisable()
	{
		_actor = null;
	}

	public void OnPointerMove(PointerEventData pData)
	{
		if (InputHelpers.mouseSupported && !Tooltip.anyActive())
		{
			tooltipAction();
		}
	}

	private void tooltipAction()
	{
		_actor.showTooltip(this);
	}

	private void initTooltip()
	{
		GetComponent<Button>().OnHoverOut(delegate
		{
			Tooltip.hideTooltip();
		});
	}
}
