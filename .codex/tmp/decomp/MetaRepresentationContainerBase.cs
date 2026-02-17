using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityPools;

public class MetaRepresentationContainerBase : StatsRowsContainer
{
	[SerializeField]
	protected MetaType _meta_type;

	[SerializeField]
	private LocalizedText _title;

	[SerializeField]
	private Image _background;

	[SerializeField]
	private Image _prefab_bar;

	[SerializeField]
	private LayoutElement _layout_element;

	protected MetaRepresentationAsset asset;

	protected override void init()
	{
		base.init();
		asset = AssetManager.meta_representation_library.getAsset(_meta_type);
		_prefab_bar.gameObject.SetActive(value: false);
		_title.setKeyAndUpdate(asset.getLocaleID());
	}

	protected override void showStats()
	{
		int pTotal = 0;
		bool pAny = false;
		Dictionary<IMetaObject, int> dictionary = UnsafeCollectionPool<Dictionary<IMetaObject, int>, KeyValuePair<IMetaObject, int>>.Get();
		fillDict(ref pTotal, ref pAny, dictionary);
		int num = pTotal;
		foreach (KeyValuePair<IMetaObject, int> item in dictionary.OrderByDescending((KeyValuePair<IMetaObject, int> p) => p.Value))
		{
			IMetaObject key = item.Key;
			int value = item.Value;
			num -= value;
			string pValue = amountWithPercent(value, pTotal);
			string pIconPath = asset.icon_getter(key);
			string pIconSecondaryPath = (asset.show_species_icon ? key.getActorAsset().icon : null);
			string text = key.name;
			text += Toolbox.coloredGreyPart(value, key.getColor().color_text);
			KeyValueField pField = showStatRowTwoIcons(text, pValue, key.getColor().color_text, asset.meta_type, key.getID(), pColorText: true, pIconPath, pIconSecondaryPath, null, null, pLocalize: false);
			showBar(pField, value, pTotal, key.getColor().color_text);
		}
		checkShowNone(pAny, num, pTotal);
		UnsafeCollectionPool<Dictionary<IMetaObject, int>, KeyValuePair<IMetaObject, int>>.Release(dictionary);
		_layout_element.ignoreLayout = !pAny;
		_background.enabled = pAny;
		_title.gameObject.SetActive(pAny);
	}

	protected virtual void fillDict(ref int pTotal, ref bool pAny, Dictionary<IMetaObject, int> pDict)
	{
		throw new NotImplementedException();
	}

	protected virtual void checkShowNone(bool pAny, int pNone, int pTotal)
	{
		throw new NotImplementedException();
	}

	protected void showBar(KeyValueField pField, int pAmount, int pTotal, string pColorHex)
	{
		float num = ((pTotal > 0) ? ((float)pAmount / (float)pTotal) : 0f);
		Image image = pField.transform.Find("gen_percent_bar")?.GetComponent<Image>();
		if (image == null)
		{
			image = UnityEngine.Object.Instantiate(_prefab_bar.gameObject, pField.transform).GetComponent<Image>();
			image.gameObject.SetActive(value: true);
			image.name = "gen_percent_bar";
		}
		float x = 100f * num * 0.5f;
		Vector2 sizeDelta = new Vector2(x, 8.5f);
		image.GetComponent<RectTransform>().sizeDelta = sizeDelta;
		image.GetComponent<RectTransform>().anchoredPosition = new Vector2(-2f, 0f);
		image.transform.SetAsFirstSibling();
		Color color = Toolbox.makeColor(pColorHex);
		color.a = 0.4f;
		image.color = color;
	}

	protected string amountWithPercent(int pAmount, int pTotal)
	{
		float pFloat = ((pTotal > 0) ? ((float)pAmount / (float)pTotal * 100f) : 0f);
		if (pTotal == pAmount)
		{
			pFloat = 100f;
		}
		return pFloat.ToText() + "%";
	}

	internal KeyValueField showStatRowTwoIcons(string pId, object pValue, string pColor, MetaType pMetaType = MetaType.None, long pMetaId = -1L, bool pColorText = false, string pIconPath = null, string pIconSecondaryPath = null, string pTooltipId = null, TooltipDataGetter pTooltipData = null, bool pLocalize = true)
	{
		KeyValueField keyValueField = showStatRow(pId, pValue, pColor, pMetaType, pMetaId, pColorText, pIconPath, pTooltipId, pTooltipData, pLocalize);
		bool flag = !string.IsNullOrEmpty(pIconSecondaryPath);
		if (flag)
		{
			Sprite sprite = SpriteTextureLoader.getSprite("ui/Icons/" + pIconSecondaryPath);
			keyValueField.icon_secondary.sprite = sprite;
		}
		keyValueField.icon_secondary.gameObject.SetActive(flag);
		return keyValueField;
	}

	public void setMetaType(MetaType pType)
	{
		_meta_type = pType;
	}
}
