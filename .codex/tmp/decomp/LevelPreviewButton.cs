using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LevelPreviewButton : MonoBehaviour
{
	public bool premiumOnly = true;

	public bool worldNetUpload;

	public Image premiumIcon;

	public Image rewardAdIcon;

	public Button button;

	public SlotButtonCallback slotData;

	public Sprite defaultSprite;

	private ButtonAnimation buttonAnimation;

	public bool loaded;

	public bool loading;

	public bool autoload;

	public void click()
	{
		if (ScrollWindow.isAnimationActive())
		{
			return;
		}
		if (buttonAnimation == null)
		{
			buttonAnimation = base.transform.parent.parent.parent.GetComponent<ButtonAnimation>();
		}
		buttonAnimation.clickAnimation();
		SaveManager.setCurrentSlot(slotData.slotID);
		if (worldNetUpload)
		{
			if (SaveManager.currentSlotExists() && SaveManager.currentPreviewExists() && SaveManager.currentMetaExists())
			{
				ScrollWindow.showWindow("worldnet_upload_world_name");
			}
		}
		else if (SaveManager.currentSlotExists())
		{
			ScrollWindow.showWindow("save_slot");
		}
		else
		{
			ScrollWindow.showWindow("save_slot_new");
		}
	}

	public void checkTextureDestroy()
	{
		if (button.image.sprite.texture != defaultSprite.texture)
		{
			Object.Destroy(button.image.sprite.texture);
		}
	}

	private void OnEnable()
	{
		if (autoload)
		{
			reloadImage();
		}
	}

	private void OnDisable()
	{
		if (!(button?.image?.sprite?.texture == defaultSprite.texture))
		{
			Object.Destroy(button?.image?.sprite?.texture);
			Object.Destroy(button?.image?.sprite);
		}
	}

	public void reloadImage()
	{
		if (this == null || !base.isActiveAndEnabled || (loaded && button?.image?.sprite != null) || loading)
		{
			return;
		}
		loading = true;
		if (SaveManager.currentWorkshopMapData != null)
		{
			loadWorkshopMapPreview();
			return;
		}
		bool flag = SaveManager.currentSlotExists();
		if (slotData.slotID == -1 && !flag)
		{
			loadImage(PreviewHelper.getCurrentWorldPreview());
		}
		else
		{
			StartCoroutine(loadSaveSlotImage(slotData.slotID));
		}
	}

	private void loadWorkshopMapPreview()
	{
		loadImage(PreviewHelper.loadWorkshopMapPreview());
	}

	private IEnumerator loadSaveSlotImage(int slotID)
	{
		string path = SaveManager.getPngSlotPath(slotID);
		if (string.IsNullOrEmpty(path) || !File.Exists(path))
		{
			loadImage(null);
			yield break;
		}
		using UnityWebRequest webRequest = UnityWebRequestTexture.GetTexture("file://" + path);
		yield return webRequest.SendWebRequest();
		if (webRequest.result == UnityWebRequest.Result.ProtocolError || webRequest.result == UnityWebRequest.Result.ConnectionError)
		{
			Debug.LogError(base.gameObject.name + " " + webRequest.error + " " + path);
			loadImage(null);
		}
		else
		{
			Texture2D content = DownloadHandlerTexture.GetContent(webRequest);
			Sprite pSource = Sprite.Create(content, new Rect(0f, 0f, content.width, content.height), new Vector2(0.5f, 0.5f));
			loadImage(pSource);
		}
	}

	public void loadImage(Sprite pSource)
	{
		if (this == null || !base.isActiveAndEnabled)
		{
			loaded = false;
			loading = false;
			return;
		}
		if (!premiumOnly || Config.hasPremium)
		{
			premiumIcon.gameObject.SetActive(value: false);
		}
		bool flag = false;
		if (pSource != null)
		{
			flag = true;
			pSource.texture.anisoLevel = 0;
			pSource.texture.filterMode = FilterMode.Point;
		}
		else
		{
			pSource = defaultSprite;
		}
		button.image.sprite = pSource;
		base.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(pSource.rect.width, pSource.rect.height);
		RectTransform component = button.transform.parent.parent.GetComponent<RectTransform>();
		float num = 1f;
		float num2 = 1f;
		num = component.sizeDelta.x / pSource.rect.width;
		num2 = component.sizeDelta.y / pSource.rect.height;
		float num3 = ((num > num2) ? num : num2);
		Transform parent = base.transform.parent;
		if (!flag)
		{
			num3 = 1f;
		}
		parent.localScale = new Vector3(num3, num3, 1f);
		loaded = true;
		loading = false;
	}
}
