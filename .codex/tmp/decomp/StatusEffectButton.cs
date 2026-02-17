using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class StatusEffectButton : MonoBehaviour
{
	private Status _status;

	internal Image image;

	internal bool tooltip_enabled = true;

	internal Button button;

	private bool _updatable_tooltip;

	public Status status => _status;

	private void Awake()
	{
		button = GetComponent<Button>();
		image = base.transform.Find("icon").GetComponent<Image>();
		if (TryGetComponent<DraggableLayoutElement>(out var component))
		{
			DraggableLayoutElement draggableLayoutElement = component;
			draggableLayoutElement.start_being_dragged = (Action<DraggableLayoutElement>)Delegate.Combine(draggableLayoutElement.start_being_dragged, new Action<DraggableLayoutElement>(onStartDrag));
		}
	}

	private void Start()
	{
		button.onClick.AddListener(showTooltip);
		button.OnHover(showHoverTooltip);
		button.OnHoverOut(Tooltip.hideTooltip);
	}

	internal void load(Status pData)
	{
		if (pData != null)
		{
			_status = pData;
			image.sprite = pData.asset.getSprite();
		}
	}

	protected virtual void onStartDrag(DraggableLayoutElement pOriginalElement)
	{
		StatusEffectButton component = pOriginalElement.GetComponent<StatusEffectButton>();
		load(component._status);
	}

	private void OnDisable()
	{
		Tooltip.hideTooltip();
	}

	private void showHoverTooltip()
	{
		if (Config.tooltips_active)
		{
			showTooltip();
		}
	}

	private void showTooltip()
	{
		if (tooltip_enabled)
		{
			string pType = (_updatable_tooltip ? "status_updatable" : "status");
			string localeID = _status.asset.getLocaleID();
			string descriptionID = _status.asset.getDescriptionID();
			Tooltip.show(this, pType, new TooltipData
			{
				tip_name = localeID,
				tip_description = descriptionID,
				status = _status
			});
			base.transform.localScale = new Vector3(1f, 1f, 1f);
			base.transform.DOKill();
			base.transform.DOScale(0.8f, 0.1f).SetEase(Ease.InBack);
		}
	}

	public void setUpdatableTooltip(bool pState)
	{
		_updatable_tooltip = pState;
	}

	private void OnDestroy()
	{
		base.transform.DOKill();
	}
}
