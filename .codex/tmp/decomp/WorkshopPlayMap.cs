using UnityEngine;
using UnityEngine.UI;

public class WorkshopPlayMap : MonoBehaviour
{
	private void Start()
	{
		if (TryGetComponent<Button>(out var component))
		{
			component.onClick.AddListener(playWorkShopMap);
		}
	}

	public void playWorkShopMap()
	{
		ScrollWindow.showWindow("save_load_confirm");
	}
}
