using UnityEngine;
using UnityEngine.UI;

public class WorkshopUploadWorldButton : MonoBehaviour
{
	public Text title;

	public Text description;

	public GameObject quickError;

	public Text errorMessage;

	private void Start()
	{
		if (TryGetComponent<Button>(out var component))
		{
			component.onClick.AddListener(uploadWorldToWorkshop);
		}
	}

	private void OnEnable()
	{
		quickError.SetActive(value: false);
	}

	private void uploadWorldToWorkshop()
	{
		quickError.SetActive(value: false);
		if (string.IsNullOrWhiteSpace(title.text))
		{
			errorMessage.text = "Give your world a name!";
			quickError.SetActive(value: true);
		}
		else if (string.IsNullOrWhiteSpace(description.text))
		{
			errorMessage.text = "Give your world a description!";
			quickError.SetActive(value: true);
		}
		else
		{
			ScrollWindow.showWindow("steam_workshop_uploading");
		}
	}

	public void closeError()
	{
		quickError.SetActive(value: false);
	}
}
