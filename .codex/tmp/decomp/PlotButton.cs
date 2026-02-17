public class PlotButton : AugmentationButton<PlotAsset>
{
	protected override string tooltip_type => "plot_in_editor";

	public override void load(PlotAsset pElement)
	{
		create();
		augmentation_asset = pElement;
		image.sprite = augmentation_asset.getSprite();
		base.gameObject.name = getElementType() + "_" + augmentation_asset.id;
		loadLegendaryOutline();
	}

	protected override void Update()
	{
		if (!is_editor_button)
		{
			if (augmentation_asset.unlocked_with_achievement)
			{
				locked_bg.gameObject.SetActive(value: false);
				return;
			}
			bool active = !augmentation_asset.isAvailable();
			locked_bg.gameObject.SetActive(active);
		}
	}

	public override void updateIconColor(bool pSelected)
	{
		if (!is_editor_button)
		{
			return;
		}
		if (!getElementAsset().isAvailable())
		{
			image.color = Toolbox.color_black;
			return;
		}
		if (pSelected)
		{
			image.color = Toolbox.color_augmentation_selected;
			return;
		}
		Actor unit = SelectedUnit.unit;
		if (augmentation_asset.canBeDoneByRole(unit))
		{
			if (augmentation_asset.check_can_be_forced != null && !augmentation_asset.check_can_be_forced(SelectedUnit.unit))
			{
				image.color = Toolbox.color_gray;
			}
			else
			{
				image.color = Toolbox.color_white;
			}
		}
		else
		{
			image.color = Toolbox.color_gray;
		}
	}

	protected override bool unlockElement()
	{
		return augmentation_asset.unlock();
	}

	protected override void startSignal()
	{
		AchievementLibrary.plots_explorer.checkBySignal();
	}

	protected override void fillTooltipData(PlotAsset pElement)
	{
		Tooltip.show(this, tooltip_type, tooltipDataBuilder());
	}

	protected override TooltipData tooltipDataBuilder()
	{
		return new TooltipData
		{
			plot_asset = augmentation_asset
		};
	}

	protected override string getElementType()
	{
		return "plot";
	}

	public override string getElementId()
	{
		return augmentation_asset.id;
	}

	protected override Rarity getRarity()
	{
		return augmentation_asset.rarity;
	}
}
