using UnityEngine;
using UnityEngine.UI;

public class FaveWorldButton : MonoBehaviour
{
	public Image icon;

	private void Start()
	{
		if (TryGetComponent<Button>(out var component))
		{
			component.onClick.AddListener(faveWorld);
		}
	}

	private void OnEnable()
	{
		updateFavoriteIconFor(SaveManager.currentSlot);
	}

	private void faveWorld()
	{
		int currentSlot = SaveManager.currentSlot;
		if (PlayerConfig.instance.data.favorite_world == currentSlot)
		{
			PlayerConfig.instance.data.favorite_world = -1;
		}
		else
		{
			PlayerConfig.instance.data.favorite_world = currentSlot;
		}
		PlayerConfig.saveData();
		updateFavoriteIconFor(currentSlot);
	}

	private void updateFavoriteIconFor(int pId)
	{
		if (PlayerConfig.instance.data.favorite_world == pId)
		{
			icon.color = ColorStyleLibrary.m.favorite_selected;
		}
		else
		{
			icon.color = ColorStyleLibrary.m.favorite_not_selected;
		}
	}
}
