using UnityEngine;
using UnityEngine.UI;

public class CityBanner : BannerGeneric<City, CityData>
{
	[SerializeField]
	private Sprite _city_sprite;

	[SerializeField]
	private Sprite _capital_sprite;

	private Image _part_city_icon;

	protected override MetaType meta_type => MetaType.City;

	protected override string tooltip_id => "city";

	protected override void setupBanner()
	{
		base.setupBanner();
		ColorAsset colorAsset = meta_object.kingdom.getColor();
		part_background.sprite = meta_object.kingdom.getElementBackground();
		part_icon.sprite = meta_object.kingdom.getElementIcon();
		Sprite pSprite = (meta_object.isCapitalCity() ? _capital_sprite : _city_sprite);
		_part_city_icon.sprite = DynamicSprites.getIconWithColors(pSprite, null, colorAsset);
		Color colorMainSecond = colorAsset.getColorMainSecond();
		Color colorBanner = colorAsset.getColorBanner();
		colorMainSecond = Color.Lerp(colorMainSecond, Color.black, 0.05f);
		colorBanner = Color.Lerp(colorBanner, Color.black, 0.05f);
		part_background.color = colorMainSecond;
		part_icon.color = colorBanner;
	}

	protected override void setupParts()
	{
		base.setupParts();
		_part_city_icon = base.transform.FindRecursive("Foundation").GetComponent<Image>();
	}

	protected override TooltipData getTooltipData()
	{
		TooltipData tooltipData = base.getTooltipData();
		tooltipData.city = meta_object;
		return tooltipData;
	}
}
