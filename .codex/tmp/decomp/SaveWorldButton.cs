using UnityEngine;
using UnityEngine.UI;

public class SaveWorldButton : MonoBehaviour
{
	private void Start()
	{
		if (TryGetComponent<Button>(out var component))
		{
			component.onClick.AddListener(saveWorld);
		}
	}

	private void saveWorld()
	{
		ScrollWindow.showWindow("save_world_confirm");
	}
}
