using UnityEngine;
using UnityEngine.UI;

public class WorkshopMapElement : MonoBehaviour
{
	private WorkshopMapData data;

	public Image image;

	public Text textName;

	public Text textKingdoms;

	public Text textCities;

	public Text textPopulation;

	public Text textMobs;

	public Text textUpvotes;

	public Text textComments;

	public Image mainBackground;

	public Image ayeIcon;

	public void load(WorkshopMapData pData)
	{
		data = pData;
		textName.text = data.meta_data_map.mapStats.name;
		textKingdoms.text = data.meta_data_map.kingdoms.ToString();
		textCities.text = data.meta_data_map.cities.ToString();
		textPopulation.text = data.meta_data_map.population.ToString();
		textMobs.text = data.meta_data_map.mobs.ToString();
		textUpvotes.text = data.workshop_item.VotesUp.ToString();
		textComments.text = data.workshop_item.NumComments.ToString();
		image.sprite = data.sprite_small_preview;
		if (data.workshop_item.Owner.Id.ToString() == Config.steam_id)
		{
			textName.color = Toolbox.makeColor("#3DDEFF");
			ayeIcon.gameObject.SetActive(value: true);
		}
		else
		{
			textName.color = Toolbox.makeColor("#FF9B1C");
			ayeIcon.gameObject.SetActive(value: false);
		}
		base.gameObject.name = "WorkshopMapElement " + data.meta_data_map.mapStats.name;
	}

	public void clickWorkshopMap()
	{
		SaveManager.currentWorkshopMapData = data;
		ScrollWindow.showWindow("steam_workshop_play_world");
	}
}
