using System;
using Steamworks.Data;
using UnityEngine;
using UnityEngine.UI;

public class WorkshopUploadingWorldWindow : MonoBehaviour
{
	public Button doneButton;

	public UnityEngine.UI.Image loadingImage;

	public UnityEngine.UI.Image doneImage;

	public UnityEngine.UI.Image errorImage;

	public GameObject barParent;

	public Text statusMessage;

	public Text percents;

	public UnityEngine.UI.Image bar;

	public UnityEngine.UI.Image mask;

	public static bool uploading;

	public static bool needsWorkshopAgreement;

	public GameObject workshopAgreementButton;

	private void OnEnable()
	{
		if (!Config.game_loaded)
		{
			return;
		}
		needsWorkshopAgreement = false;
		errorImage.gameObject.SetActive(value: false);
		doneButton.gameObject.SetActive(value: false);
		workshopAgreementButton.gameObject.SetActive(value: false);
		statusMessage.text = LocalizedTextManager.getText("uploading_your_world");
		loadingImage.gameObject.SetActive(value: true);
		doneImage.gameObject.SetActive(value: false);
		bar.gameObject.SetActive(value: true);
		percents.gameObject.SetActive(value: true);
		mask.gameObject.SetActive(value: true);
		barParent.SetActive(value: true);
		bar.transform.localScale = new Vector3(0f, 1f, 1f);
		uploading = true;
		SteamSDK.steamInitialized.Then(() => WorkshopMaps.uploadMap()).Then(delegate
		{
			progressBarUpdate();
			uploading = false;
			doneButton.gameObject.SetActive(value: true);
			statusMessage.text = LocalizedTextManager.getText("world_uploaded");
			loadingImage.gameObject.SetActive(value: false);
			doneImage.gameObject.SetActive(value: true);
			if (needsWorkshopAgreement)
			{
				statusMessage.text = LocalizedTextManager.getText("workshop_agreement");
				workshopAgreementButton.SetActive(value: true);
			}
			else
			{
				PublishedFileId uploaded_file_id = WorkshopMaps.uploaded_file_id;
				Application.OpenURL("steam://url/CommunityFilePage/" + uploaded_file_id.ToString());
			}
			barParent.SetActive(value: false);
			bar.gameObject.SetActive(value: false);
			percents.gameObject.SetActive(value: false);
			mask.gameObject.SetActive(value: false);
		}).Catch(delegate(Exception e)
		{
			statusMessage.text = LocalizedTextManager.getText("upload_error") + "\n( " + e.Message.ToString() + " )";
			uploading = false;
			Debug.LogError(e.Message.ToString());
			doneButton.gameObject.SetActive(value: true);
			doneImage.gameObject.SetActive(value: false);
			loadingImage.gameObject.SetActive(value: false);
			errorImage.gameObject.SetActive(value: true);
		});
	}

	private void Update()
	{
		if (uploading || percents.isActiveAndEnabled)
		{
			progressBarUpdate();
		}
	}

	private void progressBarUpdate()
	{
		float uploadProgress = WorkshopMaps.uploadProgress;
		float x = bar.transform.localScale.x;
		if (bar.transform.localScale.x < uploadProgress)
		{
			x = bar.transform.localScale.x + Time.deltaTime;
			if (x > uploadProgress || uploadProgress > 0.75f)
			{
				x = uploadProgress;
			}
			bar.transform.localScale = new Vector3(x, 1f, 1f);
			percents.text = Mathf.CeilToInt(x * 100f) + " %";
		}
		else
		{
			percents.text = Mathf.CeilToInt(uploadProgress * 100f) + " %";
		}
	}
}
