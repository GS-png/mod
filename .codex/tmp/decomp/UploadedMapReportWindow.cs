using UnityEngine;

public class UploadedMapReportWindow : MonoBehaviour
{
	public GameObject reportOverlay;

	public GameObject reportButtons;

	public GameObject reportConfirmation;

	private string reportReason = "";

	private void OnEnable()
	{
		reportOverlay.SetActive(value: false);
		reportButtons.SetActive(value: true);
		reportConfirmation.SetActive(value: false);
	}

	public void reportNSFW()
	{
		reportReason = "nsfw";
		confirmReport();
	}

	public void reportCrash()
	{
		reportReason = "crash";
		confirmReport();
	}

	public void reportBroken()
	{
		reportReason = "broken";
		confirmReport();
	}

	public void confirmReport()
	{
		reportButtons.SetActive(value: false);
		reportOverlay.SetActive(value: true);
		_ = reportReason;
	}
}
