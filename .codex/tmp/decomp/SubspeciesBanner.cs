using UnityEngine;
using UnityEngine.UI;

public class SubspeciesBanner : BannerGeneric<Subspecies, SubspeciesData>
{
	private Image _part_bookmark_1;

	private Image _part_bookmark_2;

	public Image unit_sprite;

	protected override MetaType meta_type => MetaType.Subspecies;

	protected override string tooltip_id => "subspecies";

	protected override TooltipData getTooltipData()
	{
		TooltipData tooltipData = base.getTooltipData();
		tooltipData.subspecies = meta_object;
		return tooltipData;
	}

	protected override void setupParts()
	{
		base.setupParts();
		_part_bookmark_1 = base.transform.FindRecursive("Bookmark 1")?.GetComponent<Image>();
		_part_bookmark_2 = base.transform.FindRecursive("Bookmark 2")?.GetComponent<Image>();
	}

	protected override void setupBanner()
	{
		base.setupBanner();
		part_background.sprite = meta_object.getSpriteBackground();
		part_icon.sprite = meta_object.getSpriteIcon();
		ColorAsset colorAsset = meta_object.getColor();
		_part_bookmark_1.color = colorAsset.getColorMainSecond();
		_part_bookmark_2.color = colorAsset.getColorMain();
		Sprite unitSpriteForBanner = meta_object.getUnitSpriteForBanner();
		unit_sprite.sprite = unitSpriteForBanner;
	}
}
