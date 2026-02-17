using System;
using UnityEngine;
using UnityEngine.UI;

public class WorldTemplateButton : MonoBehaviour
{
	public Image icon;

	public Text counter;

	public Text text;

	public PowerButton button_left;

	public PowerButton button_right;

	public PowerButton button_switch;

	public Action eventLeft;

	public Action eventRight;

	public Color color_enabled;

	public Color color_disabled;

	private MapGenTemplate _template => AssetManager.map_gen_templates.get(Config.current_map_template);

	private MapGenSettingsAsset settings_asset => AssetManager.map_gen_settings.get(base.transform.name);

	private void OnEnable()
	{
		updateCounter();
	}

	public void clickSwitch()
	{
		if (settings_asset == null)
		{
			Debug.LogError("Forgot to setup gen button - " + base.transform.name);
			return;
		}
		settings_asset.action_switch(settings_asset);
		updateCounter();
	}

	public void clickLeft()
	{
		if (settings_asset == null)
		{
			Debug.LogError("Forgot to setup gen button - " + base.transform.name);
			return;
		}
		if (settings_asset.decrease == null)
		{
			Debug.LogError("Forgot to setup gen button DECREASE - " + base.transform.name);
			return;
		}
		settings_asset.decrease(settings_asset);
		updateCounter();
	}

	public void clickRight()
	{
		if (settings_asset == null)
		{
			Debug.LogError("Forgot to setup gen button - " + base.transform.name);
			return;
		}
		if (settings_asset.increase == null)
		{
			Debug.LogError("Forgot to setup gen button INCREASE - " + base.transform.name);
			return;
		}
		settings_asset.increase(settings_asset);
		updateCounter();
	}

	public void updateCounter()
	{
		int num = settings_asset.action_get();
		text.GetComponent<LocalizedText>().setKeyAndUpdate(settings_asset.getLocaleID());
		if (!settings_asset.is_switch)
		{
			counter.text = num.ToString();
		}
		if (num == 0)
		{
			text.color = color_disabled;
			counter.color = color_disabled;
			icon.color = color_disabled;
		}
		else
		{
			text.color = color_enabled;
			counter.color = color_enabled;
			icon.color = color_enabled;
		}
		if (settings_asset.is_switch)
		{
			if (num == 1)
			{
				button_switch.GetComponent<CanvasGroup>().alpha = 1f;
				button_switch.transform.Find("Text").GetComponent<LocalizedText>().setKeyAndUpdate("short_on");
				button_switch.icon.sprite = SpriteTextureLoader.getSprite("ui/icons/IconOn");
			}
			else
			{
				button_switch.GetComponent<CanvasGroup>().alpha = 0.8f;
				button_switch.transform.Find("Text").GetComponent<LocalizedText>().setKeyAndUpdate("short_off");
				button_switch.icon.sprite = SpriteTextureLoader.getSprite("ui/icons/IconOff");
			}
		}
	}
}
