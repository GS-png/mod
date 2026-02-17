using UnityEngine;

public class RateUsChecker : MonoBehaviour
{
	public GameObject rateUs;

	public GameObject updateAvailable;

	private void OnEnable()
	{
		if (Config.game_loaded && rateUs != null && rateUs.gameObject != null)
		{
			rateUs.gameObject.SetActive(value: false);
		}
	}

	private void Update()
	{
		if (VersionCheck.isOutdated())
		{
			if (rateUs != null && rateUs.gameObject != null)
			{
				rateUs.gameObject.SetActive(value: false);
			}
			if (updateAvailable != null && updateAvailable.gameObject != null)
			{
				updateAvailable.gameObject.SetActive(value: true);
			}
		}
		else if (updateAvailable != null && updateAvailable.gameObject != null)
		{
			updateAvailable.gameObject.SetActive(value: false);
		}
	}
}
