using UnityEngine;

public class PremiumElementsChecker : MonoBehaviour
{
	public GameObject premiumButtonCorner;

	public GameObject adsButton;

	private static PremiumElementsChecker instance;

	internal float insterAdTimer = 25f;

	private void Awake()
	{
		instance = this;
	}

	internal static bool goodForInterstitialAd()
	{
		if (DebugConfig.isOn(DebugOption.TestAds))
		{
			return true;
		}
		return false;
	}

	public static void setInterstitialAdTimer(int howLong = 80)
	{
		if (DebugConfig.isOn(DebugOption.TestAds))
		{
			howLong = 15;
		}
		if (howLong > 100)
		{
			howLong = 100;
		}
		instance.insterAdTimer = howLong;
	}

	private void Update()
	{
	}

	public static void checkElements()
	{
		if (Config.hasPremium)
		{
			if (instance.premiumButtonCorner != null)
			{
				instance.premiumButtonCorner.SetActive(value: false);
			}
			if (instance.adsButton != null)
			{
				instance.adsButton.SetActive(value: false);
			}
		}
		else if (instance.premiumButtonCorner != null)
		{
			instance.premiumButtonCorner.SetActive(value: true);
		}
		foreach (PowerButton power_button in PowerButton.power_buttons)
		{
			power_button.checkLockIcon();
		}
	}

	public static void toggleActive(bool pState)
	{
		if (instance.premiumButtonCorner != null)
		{
			instance.premiumButtonCorner.SetActive(pState);
		}
		if (instance.adsButton != null)
		{
			instance.adsButton.SetActive(pState);
		}
	}
}
