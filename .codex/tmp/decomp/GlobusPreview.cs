using System.Collections;
using System.IO;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class GlobusPreview : MonoBehaviour
{
	public bool use_current_world_info;

	public Image main_image_1;

	public Image main_image_2;

	public GameObject images_parent;

	public Image clouds;

	public Sprite preview_default;

	private float _tweenSpeed = 18f;

	private float _gap_size = 25f;

	private float _box_size = 100f;

	private void OnEnable()
	{
		if (Config.game_loaded)
		{
			if (use_current_world_info)
			{
				setCurrentWorldSprite();
			}
			else if (SaveManager.currentWorkshopMapData != null)
			{
				setWorkshopSlotSprite();
			}
			else
			{
				startLoadCurrentSaveSlotSprite();
			}
			startTweenGlobus();
		}
	}

	private void startLoadCurrentSaveSlotSprite()
	{
		StartCoroutine(loadSaveSlotImage());
	}

	private void setCurrentWorldSprite()
	{
		Sprite currentWorldPreview = PreviewHelper.getCurrentWorldPreview();
		setSprites(currentWorldPreview);
	}

	private void setWorkshopSlotSprite()
	{
		Sprite sprites = PreviewHelper.loadWorkshopMapPreview();
		setSprites(sprites);
	}

	private void setSprites(Sprite pSprite)
	{
		makeGradient(pSprite);
		main_image_1.sprite = pSprite;
		main_image_2.sprite = pSprite;
	}

	private void showDefaultImage()
	{
		main_image_1.sprite = preview_default;
		main_image_2.sprite = preview_default;
	}

	private IEnumerator loadSaveSlotImage()
	{
		string path = SaveManager.getCurrentPreviewPath();
		if (string.IsNullOrEmpty(path) || !File.Exists(path))
		{
			showDefaultImage();
			yield break;
		}
		using UnityWebRequest webRequest = UnityWebRequestTexture.GetTexture("file://" + path);
		yield return webRequest.SendWebRequest();
		if (webRequest.result == UnityWebRequest.Result.ProtocolError || webRequest.result == UnityWebRequest.Result.ConnectionError)
		{
			showDefaultImage();
			yield break;
		}
		Texture2D content = DownloadHandlerTexture.GetContent(webRequest);
		content.name = "save_slot_preview_" + Path.GetFileNameWithoutExtension(path);
		Sprite sprites = Sprite.Create(content, new Rect(0f, 0f, content.width, content.height), new Vector2(0.5f, 0.5f));
		setSprites(sprites);
	}

	private void makeGradient(Sprite pSprite)
	{
		float num = (float)pSprite.texture.width * 0.1f;
		Texture2D texture = pSprite.texture;
		texture.name = "gradient_" + texture.name;
		for (int i = 0; (float)i < num; i++)
		{
			for (int j = 0; j < texture.height; j++)
			{
				int num2 = i;
				Color pixel = texture.GetPixel(num2, j);
				pixel.a = (float)num2 / num;
				texture.SetPixel(num2, j, pixel);
				num2 = pSprite.texture.width - i;
				pixel = texture.GetPixel(num2, j);
				pixel.a = (float)i / num;
				texture.SetPixel(num2, j, pixel);
			}
		}
		texture.Apply();
	}

	private void startTweenGlobus()
	{
		float num = _box_size + _gap_size;
		float duration = num / _tweenSpeed;
		images_parent.transform.DOKill();
		images_parent.transform.localPosition = new Vector3(_gap_size, 0f, 0f);
		images_parent.transform.DOLocalMove(new Vector3(0f - num, 0f, 0f), duration).SetEase(Ease.Linear).onComplete = tweenLoop;
	}

	private void tweenLoop()
	{
		float num = _box_size + _gap_size;
		float duration = num / _tweenSpeed;
		images_parent.transform.localPosition = new Vector3(0f, 0f, 0f);
		images_parent.transform.DOLocalMove(new Vector3(0f - num, 0f, 0f), duration).SetEase(Ease.Linear).onComplete = tweenLoop;
	}
}
