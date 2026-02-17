using System.Collections.Generic;
using UnityEngine;

public class PremiumWindow : MonoBehaviour
{
	public Transform buttons_transform;

	public void Awake()
	{
		clearButtons();
		addButtons();
	}

	private void addButtons()
	{
		Dictionary<string, PowerButton> dictionary = new Dictionary<string, PowerButton>();
		foreach (PowerButton premium_button in GodPower.premium_buttons)
		{
			dictionary.TryAdd(premium_button.godPower.id, premium_button);
		}
		foreach (PowerButton value in dictionary.Values)
		{
			value.gameObject.SetActive(value: false);
			PowerButton powerButton = Object.Instantiate(value, buttons_transform);
			powerButton.transform.name = value.transform.name;
			powerButton.type = PowerButtonType.Shop;
			powerButton.destroyLockIcon();
			powerButton.GetComponent<RectTransform>().pivot = value.GetComponent<RectTransform>().pivot;
			IconRotationAnimation iconRotationAnimation = powerButton.gameObject.AddComponent<IconRotationAnimation>();
			iconRotationAnimation.delay = Randy.randomFloat(1f, 10f);
			iconRotationAnimation.randomDelay = true;
			value.gameObject.SetActive(value: true);
			powerButton.gameObject.SetActive(value: true);
		}
	}

	private void clearButtons()
	{
		while (buttons_transform.childCount > 0)
		{
			GameObject obj = buttons_transform.GetChild(0).gameObject;
			obj.transform.SetParent(null);
			Object.Destroy(obj);
		}
	}
}
