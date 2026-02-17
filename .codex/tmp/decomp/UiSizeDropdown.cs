using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiSizeDropdown : MonoBehaviour
{
	private Button button;

	private Dropdown dropdown;

	private List<string> options = new List<string>();

	private void Start()
	{
		createDropdownOptions();
		renderDropdownValue(dropdown);
		dropdown.onValueChanged.AddListener(delegate
		{
			DropdownValueChanged(dropdown);
		});
	}

	private void createDropdownOptions()
	{
		dropdown = GetComponent<Dropdown>();
		dropdown.ClearOptions();
		options.Clear();
		dropdown.AddOptions(options);
	}

	private void OnEnable()
	{
		if (Config.game_loaded)
		{
			dropdown = GetComponent<Dropdown>();
			renderDropdownValue(dropdown);
		}
	}

	private void DropdownValueChanged(Dropdown change)
	{
	}

	private void renderDropdownValue(Dropdown dropdown)
	{
		string stringVal = PlayerConfig.dict["ui_size"].stringVal;
		dropdown.value = options.IndexOf(stringVal);
		dropdown.RefreshShownValue();
	}
}
