using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UnitHouseElement : UnitElement
{
	[SerializeField]
	private GameObject _title;

	[SerializeField]
	private GameObject _house_container;

	[SerializeField]
	private Image _house_image;

	protected override IEnumerator showContent()
	{
		if (actor.hasHomeBuilding())
		{
			Building homeBuilding = actor.getHomeBuilding();
			track_objects.Add(homeBuilding);
			_title.SetActive(value: true);
			_house_container.gameObject.SetActive(value: true);
			showSprite(actor.kingdom, _house_image, homeBuilding);
			setIconValue("i_house_health", homeBuilding.getHealth(), homeBuilding.getMaxHealth());
			setIconValue("i_house_people", homeBuilding.countResidents(), homeBuilding.asset.housing_slots);
		}
		yield break;
	}

	private void setIconValue(string pName, float pMainVal, float? pMax = null, string pColor = "", bool pFloat = false, string pEnding = "", char pSeparator = '/')
	{
		Transform transform = base.transform.FindRecursive(pName);
		if (!(transform == null))
		{
			StatsIcon component = transform.GetComponent<StatsIcon>();
			component.gameObject.SetActive(value: true);
			component.setValue(pMainVal, pMax, pColor, pFloat, pEnding, pSeparator);
		}
	}

	private void showSprite(Kingdom pKingdom, Image pImage, Building pBuilding)
	{
		BuildingAsset asset = pBuilding.asset;
		Sprite recoloredBuilding = DynamicSprites.getRecoloredBuilding(asset.building_sprites.animation_data[pBuilding.animData_index].main.GetRandom(), pKingdom.getColor(), asset.atlas_asset);
		pImage.sprite = recoloredBuilding;
		pImage.SetNativeSize();
		float a = 28f / pImage.rectTransform.sizeDelta.x;
		float b = 28f / pImage.rectTransform.sizeDelta.y;
		float num = Mathf.Min(a, b);
		pImage.rectTransform.sizeDelta = new Vector2(pImage.rectTransform.sizeDelta.x * num, pImage.rectTransform.sizeDelta.y * num);
	}

	protected override void clear()
	{
		_title.SetActive(value: false);
		_house_container.SetActive(value: false);
		base.clear();
	}

	public override bool checkRefreshWindow()
	{
		if (_house_container.activeSelf && !actor.hasHomeBuilding())
		{
			return true;
		}
		return base.checkRefreshWindow();
	}
}
