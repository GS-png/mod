using UnityEngine;
using UnityEngine.UI;

namespace tools.debug;

public class DebugMap
{
	public static void makeDebugMap()
	{
		createDebugButtons();
		WorldTile[] tiles_list = World.world.tiles_list;
		for (int i = 0; i < tiles_list.Length; i++)
		{
			MapAction.terraformTile(tiles_list[i], TileLibrary.soil_low, TopTileLibrary.grass_low, TerraformLibrary.destroy);
		}
		int num = 10;
		int num2 = 10;
		int num3 = 0;
		int count = AssetManager.buildings.list.Count;
		while (num3 < count)
		{
			BuildingAsset buildingAsset = AssetManager.buildings.list[num3];
			if (buildingAsset.id.Contains("!"))
			{
				num3++;
				continue;
			}
			num3++;
			num += 20;
			if (num > 200)
			{
				num = 10;
				num2 += 10;
			}
			Building building = World.world.buildings.addBuilding(buildingAsset, World.world.GetTile(num, num2));
			building.kingdom = World.world.kingdoms_wild.get("nature");
			building.updateBuild(10000);
			if (!building.asset.docks)
			{
				continue;
			}
			foreach (WorldTile tile in building.tiles)
			{
				MapAction.terraformMain(tile, TileLibrary.shallow_waters, TerraformLibrary.flash);
			}
		}
		Config.paused = true;
	}

	private static void debugConstructionZone()
	{
		foreach (Building building in World.world.buildings)
		{
			building.debugConstructions();
		}
	}

	private static void debugNextFrame()
	{
	}

	private static void debugRuins()
	{
	}

	public static void createDebugButtons()
	{
		Button button = makeNewButton("debug_next_frame", "iconBuildings");
		button.onClick.AddListener(debugNextFrame);
		button.GetComponent<RectTransform>().anchoredPosition = new Vector2(50f, -20f);
		Button button2 = makeNewButton("debug_ruins", "iconDemolish");
		button2.onClick.AddListener(debugRuins);
		button2.GetComponent<RectTransform>().anchoredPosition = new Vector2(100f, -20f);
		Button button3 = makeNewButton("debug_construction", "iconBucket");
		button3.onClick.AddListener(debugConstructionZone);
		button3.GetComponent<RectTransform>().anchoredPosition = new Vector2(150f, -20f);
	}

	private static Button makeNewButton(string pName, string pIcon)
	{
		Button button = Object.Instantiate((Button)Resources.Load("ui/PrefabWorldBoxButton", typeof(Button)), World.world.canvas.transform);
		button.transform.name = pName;
		button.transform.parent = World.world.canvas.transform;
		Sprite sprite = (Sprite)Resources.Load("ui/Icons/" + pIcon, typeof(Sprite));
		button.transform.Find("Icon").GetComponent<Image>().sprite = sprite;
		return button;
	}
}
