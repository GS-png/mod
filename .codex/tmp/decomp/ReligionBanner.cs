public class ReligionBanner : BannerGeneric<Religion, ReligionData>
{
	protected override MetaType meta_type => MetaType.Religion;

	protected override string tooltip_id => "religion";

	protected override TooltipData getTooltipData()
	{
		TooltipData tooltipData = base.getTooltipData();
		tooltipData.religion = meta_object;
		return tooltipData;
	}

	protected override void setupBanner()
	{
		base.setupBanner();
		part_background.sprite = meta_object.getBackgroundSprite();
		part_icon.sprite = meta_object.getIconSprite();
		ColorAsset colorAsset = meta_object.getColor();
		part_background.color = colorAsset.getColorMainSecond();
		part_icon.color = colorAsset.getColorBanner();
	}
}
