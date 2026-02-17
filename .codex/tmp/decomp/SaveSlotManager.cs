using System.Collections.Generic;
using UnityEngine;

public class SaveSlotManager : MonoBehaviour
{
	public GameObject buttonsContainer;

	private List<LevelPreviewButton> previews = new List<LevelPreviewButton>();

	private List<GameObject> containers = new List<GameObject>();

	public GameObject slotButtonPrefab;

	public RectTransform content;

	private Vector3 originalPos;

	public bool loaded;

	public bool worldNetUpload;

	private void Init()
	{
		SaveManager.clearCurrentSelectedWorld();
		int num = 65;
		int num2 = 65;
		int num3 = 0;
		int num4 = 1;
		int num5 = 10;
		for (int i = 0; i < num5; i++)
		{
			GameObject gameObject = Object.Instantiate(slotButtonPrefab, buttonsContainer.transform);
			gameObject.transform.localPosition = new Vector3(-num, -num3 * num2);
			setID(gameObject, num4++);
			gameObject = Object.Instantiate(slotButtonPrefab, buttonsContainer.transform);
			gameObject.transform.localPosition = new Vector3(0f, -num3 * num2);
			setID(gameObject, num4++);
			gameObject = Object.Instantiate(slotButtonPrefab, buttonsContainer.transform);
			gameObject.transform.localPosition = new Vector3(num, -num3 * num2);
			setID(gameObject, num4++);
			num3++;
		}
		content.sizeDelta = new Vector2(0f, num5 * num2);
	}

	private void OnEnable()
	{
		loaded = false;
		Init();
	}

	private void Update()
	{
		foreach (LevelPreviewButton preview in previews)
		{
			if (!preview.loaded && !preview.loading)
			{
				preview.reloadImage();
				break;
			}
		}
	}

	private void OnDisable()
	{
		for (int i = 0; i < containers.Count; i++)
		{
			previews[i].checkTextureDestroy();
			Object.Destroy(containers[i]);
			containers[i] = null;
		}
		previews.Clear();
		containers.Clear();
	}

	private void setID(GameObject pContainer, int pID)
	{
		Transform transform = pContainer.transform.Find("AnimationContainer/Mask/SizeContainer/Button");
		transform.GetComponent<SlotButtonCallback>().slotID = pID;
		transform.GetComponent<LevelPreviewButton>().loaded = false;
		transform.GetComponent<LevelPreviewButton>().worldNetUpload = worldNetUpload;
		if (pID > 1)
		{
			transform.GetComponent<LevelPreviewButton>().premiumOnly = true;
		}
		previews.Add(transform.GetComponent<LevelPreviewButton>());
		containers.Add(pContainer);
	}
}
