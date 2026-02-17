using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Obsolete]
public class ResolutionDropdown : MonoBehaviour
{
	private Button button;

	private Dropdown dropdown;

	public OptionBool fullscreenOption;

	private static List<string> options = new List<string>();

	private void Start()
	{
		dropdown = GetComponent<Dropdown>();
		PopulateDropdown(dropdown);
		dropdown.onValueChanged.AddListener(delegate
		{
			DropdownValueChanged(dropdown);
		});
	}

	private void OnEnable()
	{
		if (Config.game_loaded)
		{
			dropdown = GetComponent<Dropdown>();
			PopulateDropdown(dropdown);
		}
	}

	private void DropdownValueChanged(Dropdown change)
	{
		Resolution[] resolutions = Screen.resolutions;
		if (options[change.value] == LocalizedTextManager.getText("windowed_mode"))
		{
			PlayerConfig.setFullScreen(pFullScreen: false);
		}
		else
		{
			Resolution[] array = resolutions;
			for (int i = 0; i < array.Length; i++)
			{
				Resolution resolution = array[i];
				if (resolution.ToString() == options[change.value])
				{
					if (!Screen.fullScreen)
					{
						PlayerConfig.setFullScreen(pFullScreen: true, pSwitchScreen: false);
					}
					Screen.SetResolution(resolution.width, resolution.height, fullscreen: true, resolution.refreshRate);
					break;
				}
			}
		}
		fullscreenOption.checkGameOption();
	}

	private void PopulateDropdown(Dropdown dropdown)
	{
		options.Clear();
		Resolution[] resolutions = Screen.resolutions;
		for (int i = 0; i < resolutions.Length; i++)
		{
			Resolution resolution = resolutions[i];
			options.Add(resolution.ToString());
		}
		options.Add(LocalizedTextManager.getText("windowed_mode"));
		dropdown.ClearOptions();
		options.Reverse();
		int num = options.IndexOf(Screen.currentResolution.ToString());
		if (!Screen.fullScreen)
		{
			num = options.IndexOf(LocalizedTextManager.getText("windowed_mode"));
		}
		dropdown.AddOptions(options);
		if (num > -1)
		{
			dropdown.value = num;
		}
		else
		{
			options.Insert(0, Screen.currentResolution.ToString());
			dropdown.AddOptions(options);
			dropdown.value = options.IndexOf(Screen.currentResolution.ToString());
		}
		dropdown.RefreshShownValue();
	}
}
