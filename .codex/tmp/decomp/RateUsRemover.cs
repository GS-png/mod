using UnityEngine;

public class RateUsRemover : MonoBehaviour
{
	public void clickedRateUs()
	{
		PlayerConfig.instance.data.lastRateID = 12;
		base.gameObject.SetActive(value: false);
		PlayerConfig.saveData();
	}
}
