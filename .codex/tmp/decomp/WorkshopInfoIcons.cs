using UnityEngine;
using UnityEngine.UI;

public class WorkshopInfoIcons : MonoBehaviour
{
	public Text favorites;

	public Text upvotes;

	public Text comments;

	public Text subscription;

	private void OnEnable()
	{
		if (Config.game_loaded)
		{
			WorkshopMapData currentWorkshopMapData = SaveManager.currentWorkshopMapData;
			if (currentWorkshopMapData != null)
			{
				favorites.text = currentWorkshopMapData.workshop_item.NumFavorites.ToString();
				upvotes.text = currentWorkshopMapData.workshop_item.VotesUp.ToString();
				comments.text = currentWorkshopMapData.workshop_item.NumComments.ToString();
				subscription.text = currentWorkshopMapData.workshop_item.NumSubscriptions.ToString();
			}
		}
	}
}
