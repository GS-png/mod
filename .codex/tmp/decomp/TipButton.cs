using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class TipButton : MonoBehaviour
{
	private Vector3 _default_scale;

	private float _default_click_scale_increase = 1.1f;

	public const float SCALE_DURATION = 0.1f;

	public string textOnClick;

	public string textOnClickDescription;

	public string text_description_2;

	public string text_override_non_steam = string.Empty;

	public string description_override_non_steam = string.Empty;

	public TooltipAction hoverAction;

	public TooltipAction clickAction;

	public bool return_if_same_object;

	public string type = "tip";

	public bool showOnClick = true;

	public bool override_click_scale_animation;

	public float overridden_click_scale_animation = 1f;

	private Tweener _scale_anim;

	private void Awake()
	{
		if (hoverAction == null)
		{
			setHoverAction(showTooltipDefault);
		}
		_default_scale = base.gameObject.transform.localScale;
	}

	private void Start()
	{
		if (TryGetComponent<Button>(out var component))
		{
			if (showOnClick)
			{
				component.onClick.AddListener(showTooltipOnClick);
			}
			component.OnHover(showHoverTooltip);
			component.OnHoverOut(Tooltip.hideTooltip);
		}
		else
		{
			Slider component2 = GetComponent<Slider>();
			if (component2 != null)
			{
				component2.OnHover(showHoverTooltip);
				component2.OnHoverOut(Tooltip.hideTooltip);
			}
		}
	}

	public void setDefaultScale(Vector3 pScale)
	{
		_default_scale = pScale;
	}

	public void setHoverAction(TooltipAction pAction, bool pAddAnimation = true)
	{
		hoverAction = pAction;
		if (pAddAnimation)
		{
			hoverAction = (TooltipAction)Delegate.Combine(hoverAction, new TooltipAction(clickAnimation));
		}
	}

	private void showTooltipOnClick()
	{
		if (clickAction != null)
		{
			clickAction();
		}
		else
		{
			hoverAction?.Invoke();
		}
	}

	private void showHoverTooltip()
	{
		if (Config.tooltips_active)
		{
			hoverAction?.Invoke();
		}
	}

	public void showTooltipDefault()
	{
		if (Config.isMobile)
		{
			if (!string.IsNullOrEmpty(text_override_non_steam))
			{
				textOnClick = text_override_non_steam;
			}
			if (!string.IsNullOrEmpty(description_override_non_steam))
			{
				textOnClickDescription = description_override_non_steam;
			}
		}
		if (!(textOnClick == "") || !(textOnClickDescription == ""))
		{
			TooltipData pData = new TooltipData
			{
				tip_name = textOnClick,
				tip_description = textOnClickDescription,
				tip_description_2 = text_description_2
			};
			Tooltip.show(base.gameObject, type, pData);
		}
	}

	public void clickAnimation()
	{
		float default_click_scale_increase = _default_click_scale_increase;
		if (override_click_scale_animation)
		{
			default_click_scale_increase = overridden_click_scale_animation;
		}
		float num = _default_scale.x * default_click_scale_increase;
		base.transform.localScale = new Vector3(num, num, num);
		_scale_anim.Kill();
		_scale_anim = base.transform.DOScale(_default_scale, 0.1f).SetEase(Ease.InBack);
	}

	private void OnEnable()
	{
		resetAnimation();
	}

	private void resetAnimation()
	{
		_scale_anim?.Kill();
		base.transform.localScale = _default_scale;
	}

	private void OnDestroy()
	{
		_scale_anim.Kill();
	}
}
