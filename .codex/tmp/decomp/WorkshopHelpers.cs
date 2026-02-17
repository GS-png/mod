using UnityEngine;

public class WorkshopHelpers : MonoBehaviour
{
	public const string color_own_map = "#3DDEFF";

	public const string color_other_map = "#FF9B1C";

	public void openCurrentMapInWorkshop()
	{
		Application.OpenURL("steam://url/CommunityFilePage/" + SaveManager.currentWorkshopMapData.workshop_item.Id.ToString());
	}

	public void openUploadWorld()
	{
		SaveManager.clearCurrentSelectedWorld();
		ScrollWindow.showWindow("steam_workshop_upload_world");
	}

	public void openBrowseWorlds()
	{
		SaveManager.clearCurrentSelectedWorld();
		ScrollWindow.showWindow("steam_workshop_browse");
	}
}
