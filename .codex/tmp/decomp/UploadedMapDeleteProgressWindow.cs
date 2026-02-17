using UnityEngine;

public class UploadedMapDeleteProgressWindow : MonoBehaviour
{
	public GameObject deletingOverlay;

	private void OnEnable()
	{
		deletingOverlay.SetActive(value: false);
	}

	public void confirmDeletion()
	{
		deletingOverlay.SetActive(value: true);
	}
}
