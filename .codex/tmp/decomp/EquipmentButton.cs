using System;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentButton : AugmentationButton<EquipmentAsset>, IBanner, IBaseMono, IRefreshElement
{
	[SerializeField]
	private Image _favorited_icon;

	private Item _item;

	private bool _object_button;

	public MetaCustomizationAsset meta_asset => AssetManager.meta_customization_library.getAsset(MetaType.Item);

	public MetaTypeAsset meta_type_asset => AssetManager.meta_type_library.getAsset(MetaType.Item);

	protected override string tooltip_type => "equipment";

	protected override void Update()
	{
		if (!is_editor_button)
		{
			if (augmentation_asset.unlocked_with_achievement)
			{
				locked_bg.gameObject.SetActive(value: false);
				return;
			}
			bool active = !augmentation_asset.isAvailable() && _object_button;
			locked_bg.gameObject.SetActive(active);
		}
	}

	protected override void onStartDrag(DraggableLayoutElement pOriginalElement)
	{
		EquipmentEditorButton component = pOriginalElement.GetComponent<EquipmentEditorButton>();
		if (component != null)
		{
			load(component.augmentation_button.augmentation_asset);
			is_editor_button = component.augmentation_button.is_editor_button;
			return;
		}
		EquipmentButton component2 = pOriginalElement.GetComponent<EquipmentButton>();
		if (component2._object_button)
		{
			load(component2._item);
			is_editor_button = component2.is_editor_button;
		}
		else
		{
			load(component2.augmentation_asset);
			is_editor_button = component2.is_editor_button;
		}
	}

	public void load(NanoObject pObject)
	{
		load((Item)pObject);
	}

	internal void load(Item pItem)
	{
		_object_button = true;
		create();
		_item = pItem;
		augmentation_asset = _item.getAsset();
		if (augmentation_asset != null)
		{
			image.sprite = _item.getSprite();
			loadLegendaryOutline();
			base.gameObject.name = getElementType() + "_" + _item.data.asset_id;
			bool active = _item.isFavorite();
			_favorited_icon.gameObject.SetActive(active);
		}
	}

	public override void load(EquipmentAsset pItem)
	{
		_object_button = false;
		create();
		augmentation_asset = pItem;
		if (augmentation_asset != null)
		{
			image.sprite = augmentation_asset.getSprite();
			base.gameObject.name = getElementType() + "_" + augmentation_asset.id;
			_favorited_icon.gameObject.SetActive(value: false);
		}
	}

	protected override void initTooltip()
	{
		base.initTooltip();
		if (!TryGetComponent<TipButton>(out var component))
		{
			return;
		}
		TipButton tipButton = component;
		tipButton.clickAction = (TooltipAction)Delegate.Combine(tipButton.clickAction, (TooltipAction)delegate
		{
			if (InputHelpers.mouseSupported)
			{
				openItemWindow();
			}
			else if (Tooltip.isShowingFor(this) && !is_editor_button)
			{
				openItemWindow();
			}
			else
			{
				showTooltip();
			}
		});
	}

	private void openItemWindow()
	{
		SelectedMetas.selected_item = _item;
		if (SelectedMetas.selected_item != null)
		{
			ScrollWindow.showWindow("item");
		}
	}

	protected override void fillTooltipData(EquipmentAsset pElement)
	{
		string pType = ((is_editor_button || !_object_button) ? "equipment_in_editor" : "equipment");
		Tooltip.show(this, pType, tooltipDataBuilder());
	}

	protected override bool unlockElement()
	{
		return augmentation_asset.unlock();
	}

	protected override TooltipData tooltipDataBuilder()
	{
		if (!is_editor_button && _object_button)
		{
			return new TooltipData
			{
				item = _item
			};
		}
		return new TooltipData
		{
			item_asset = augmentation_asset
		};
	}

	protected override string getElementType()
	{
		return "equip";
	}

	protected override void startSignal()
	{
		AchievementLibrary.equipment_explorer.checkBySignal();
	}

	public override string getElementId()
	{
		return getElementAsset().id;
	}

	private bool hasDivineRune()
	{
		if (_item == null)
		{
			return false;
		}
		if (!_item.isAlive())
		{
			return false;
		}
		return _item.hasMod("divine_rune");
	}

	protected override Rarity getRarity()
	{
		return _item.getQuality();
	}

	public string getName()
	{
		return _item.getName();
	}

	public NanoObject GetNanoObject()
	{
		return _item;
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
