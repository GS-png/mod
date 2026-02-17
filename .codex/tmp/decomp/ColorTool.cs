using System.IO;
using UnityEngine;

public class ColorTool : MonoBehaviour
{
	public string colorString;

	public GameObject prefabKingdom;

	public GameObject prefabClan;

	public GameObject prefabCulture;

	public GameObject prefabAlliance;

	public Transform container;

	public string last_editor = "";

	private void resetCoords()
	{
	}

	public void InitKingdoms()
	{
		cleanup();
		last_editor = "kingdoms";
		KingdomColorsLibrary kingdomColorsLibrary = new KingdomColorsLibrary();
		kingdomColorsLibrary.init();
		kingdomColorsLibrary.post_init();
		foreach (ColorAsset item in kingdomColorsLibrary.list)
		{
			createColorToolElement(item, prefabKingdom, last_editor);
		}
	}

	public void InitCultures()
	{
		cleanup();
		last_editor = "cultures";
		CultureColorsLibrary cultureColorsLibrary = new CultureColorsLibrary();
		cultureColorsLibrary.init();
		cultureColorsLibrary.post_init();
		foreach (ColorAsset item in cultureColorsLibrary.list)
		{
			createColorToolElement(item, prefabCulture, last_editor);
		}
	}

	public void InitClans()
	{
		cleanup();
		last_editor = "clans";
		ClanColorsLibrary clanColorsLibrary = new ClanColorsLibrary();
		clanColorsLibrary.init();
		clanColorsLibrary.post_init();
		foreach (ColorAsset item in clanColorsLibrary.list)
		{
			createColorToolElement(item, prefabClan, last_editor);
		}
	}

	public void cleanup()
	{
		resetCoords();
		while (container.childCount > 0)
		{
			Object.DestroyImmediate(container.GetChild(0).gameObject);
		}
	}

	private void createColorToolElement(ColorAsset pColor, GameObject pPrefab, string pWhat)
	{
		ColorToolElement component = Object.Instantiate(pPrefab, container).GetComponent<ColorToolElement>();
		if (last_editor == "kingdoms")
		{
			component.createKingdom(pColor);
		}
		else if (last_editor == "clans")
		{
			component.createClans(pColor);
		}
		else if (last_editor == "cultures")
		{
			component.createCulture(pColor);
		}
		component.transform.name = pColor.index_id + "-" + pColor.id;
		component.transform.SetSiblingIndex(pColor.index_id);
	}

	public void saveEditor()
	{
		if (last_editor == "kingdoms")
		{
			saveKingdoms();
		}
		else if (last_editor == "clans")
		{
			saveClans();
		}
		else if (last_editor == "cultures")
		{
			saveCultures();
		}
	}

	private void convertToolIntoAsset(ColorToolElement pTool, ColorAsset pAsset)
	{
		pAsset.color_main = Toolbox.colorToHex(pTool.colorMain, pAlpha: false);
		pAsset.color_main_2 = Toolbox.colorToHex(pTool.colorMain2, pAlpha: false);
		pAsset.color_banner = Toolbox.colorToHex(pTool.colorBanner, pAlpha: false);
		pAsset.color_text = Toolbox.colorToHex(pTool.colorText, pAlpha: false);
		pAsset.id = pTool.id;
		pAsset.favorite = pTool.favorite;
	}

	private void saveKingdoms()
	{
		KingdomColorsLibrary pLibrary = new KingdomColorsLibrary();
		saveLib(pLibrary);
	}

	private void saveCultures()
	{
		CultureColorsLibrary pLibrary = new CultureColorsLibrary();
		saveLib(pLibrary);
	}

	private void saveClans()
	{
		ClanColorsLibrary pLibrary = new ClanColorsLibrary();
		saveLib(pLibrary);
	}

	private void saveLib(ColorLibrary pLibrary)
	{
		for (int i = 0; i < container.childCount; i++)
		{
			ColorToolElement component = container.GetChild(i).GetComponent<ColorToolElement>();
			ColorAsset colorAsset = new ColorAsset();
			convertToolIntoAsset(component, colorAsset);
			colorAsset.index_id = i;
			pLibrary.list.Add(colorAsset);
		}
		string contents = JsonUtility.ToJson(pLibrary, prettyPrint: true);
		File.WriteAllText(pLibrary.getEditorPathForSave(), contents);
	}
}
