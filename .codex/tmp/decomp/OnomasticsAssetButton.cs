using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class OnomasticsAssetButton : MonoBehaviour
{
	private bool _created;

	internal Image image;

	internal bool tooltip_enabled = true;

	internal Button button;

	public OnomasticsAsset onomastics_asset;

	public OnomasticsActionUpdate onomastics_action_update;

	private GetCurrentOnomasticsData _get_current_onomastics_data;

	private void Awake()
	{
		create();
		if (TryGetComponent<DraggableLayoutElement>(out var component))
		{
			DraggableLayoutElement draggableLayoutElement = component;
			draggableLayoutElement.start_being_dragged = (Action<DraggableLayoutElement>)Delegate.Combine(draggableLayoutElement.start_being_dragged, new Action<DraggableLayoutElement>(onStartDrag));
		}
	}

	protected virtual void onStartDrag(DraggableLayoutElement pOriginalElement)
	{
		OnomasticsAssetButton component = pOriginalElement.GetComponent<OnomasticsAssetButton>();
		setupButton(component.onomastics_asset, component._get_current_onomastics_data);
	}

	public void setupButton(OnomasticsAsset pAsset, GetCurrentOnomasticsData pDelegate)
	{
		loadAsset(pAsset);
		setOnomasticsGetter(pDelegate);
		checkSpriteButtonColor();
	}

	public RectTransform getRect()
	{
		return GetComponent<RectTransform>();
	}

	private void Update()
	{
		checkSpriteButtonColor();
	}

	public bool isGroupType()
	{
		return onomastics_asset.isGroupType();
	}

	private bool doesGroupHaveContent()
	{
		if (_get_current_onomastics_data == null)
		{
			return true;
		}
		OnomasticsData onomasticsData = _get_current_onomastics_data();
		if (onomasticsData == null || onomastics_asset == null)
		{
			return false;
		}
		if (!isGroupType())
		{
			return true;
		}
		return !onomasticsData.isGroupEmpty(onomastics_asset.id);
	}

	public void checkSpriteButtonColor()
	{
		if (doesGroupHaveContent())
		{
			image.color = Color.white;
		}
		else
		{
			image.color = Color.gray;
		}
	}

	public void setOnomasticsGetter(GetCurrentOnomasticsData pDelegate)
	{
		_get_current_onomastics_data = pDelegate;
	}

	private void Start()
	{
		if (!TryGetComponent<TipButton>(out var component))
		{
			return;
		}
		component.setHoverAction(delegate
		{
			if (InputHelpers.mouseSupported)
			{
				showTooltip();
			}
		});
	}

	public void loadAsset(OnomasticsAsset pAsset)
	{
		onomastics_asset = pAsset;
		image.sprite = onomastics_asset.getSprite();
	}

	public void showTooltip()
	{
		if (tooltip_enabled)
		{
			tooltipBuilder();
			base.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
			base.transform.DOKill();
			base.transform.DOScale(1f, 0.1f).SetEase(Ease.InBack);
		}
	}

	private void tooltipBuilder()
	{
		Tooltip.show(this, "onomastics_asset", new TooltipData
		{
			onomastics_asset = onomastics_asset,
			onomastics_data = _get_current_onomastics_data()
		});
	}

	private void create()
	{
		if (!_created)
		{
			_created = true;
			button = GetComponent<Button>();
			image = base.transform.Find("TiltEffect/icon").GetComponent<Image>();
		}
	}

	private void OnDestroy()
	{
		base.transform.DOKill();
	}
}
