using UnityEngine;
using UnityEngine.UI;

public class ArmyBanner : BannerGeneric<Army, ArmyData>
{
	[SerializeField]
	private Image _species_icon;

	protected override MetaType meta_type => MetaType.Army;

	protected override string tooltip_id => "army";

	protected override void setupBanner()
	{
		base.setupBanner();
		Kingdom kingdom = meta_object.getKingdom();
		part_background.sprite = kingdom.getElementBackground();
		part_icon.sprite = kingdom.getElementIcon();
		ColorAsset colorAsset = kingdom.getColor();
		Color colorMainSecond = colorAsset.getColorMainSecond();
		Color colorBanner = colorAsset.getColorBanner();
		colorMainSecond = Color.Lerp(colorMainSecond, Color.black, 0.05f);
		colorBanner = Color.Lerp(colorBanner, Color.black, 0.05f);
		part_background.color = colorMainSecond;
		part_icon.color = colorBanner;
		_species_icon.gameObject.SetActive(value: false);
	}

	protected override TooltipData getTooltipData()
	{
		TooltipData tooltipData = base.getTooltipData();
		tooltipData.army = meta_object;
		return tooltipData;
	}
}
