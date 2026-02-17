using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

[Serializable]
public class HotkeyAsset : Asset
{
	public KeyCode default_key_mod_1;

	public KeyCode default_key_mod_2;

	public KeyCode default_key_mod_3;

	public KeyCode default_key_1;

	public KeyCode default_key_2;

	public KeyCode default_key_3;

	public KeyCode overridden_key_1;

	public KeyCode overridden_key_2;

	public KeyCode overridden_key_3;

	public KeyCode overridden_key_mod_1;

	public KeyCode overridden_key_mod_2;

	public KeyCode overridden_key_mod_3;

	public bool use_mouse_wheel;

	public HotkeyAction just_pressed_action;

	public HotkeyAction holding_action;

	[DefaultValue(0.1f)]
	public float holding_cooldown = 0.1f;

	[DefaultValue(0.33f)]
	public float holding_cooldown_first_action = 0.33f;

	public bool ignore_same_key_diagnostic;

	public bool disable_for_controlled_unit;

	public bool ignore_mod_keys;

	public bool check_only_controllable_unit;

	public bool check_only_not_controllable_unit;

	public bool check_controls_locked;

	public bool check_window_active;

	public bool check_window_not_active;

	public bool check_render_gameplay;

	public bool check_render_minimap;

	public bool check_debug_active;

	public bool check_no_multi_unit_selection;

	public bool check_no_selection;

	public bool check_multi_unit_selection;

	public bool allow_unit_control;

	public bool isJustPressed()
	{
		if (!Input.anyKeyDown)
		{
			return false;
		}
		if (disable_for_controlled_unit && ControllableUnit.isControllingUnit())
		{
			return false;
		}
		if (hasModKey())
		{
			if (!isHoldingModKey())
			{
				return false;
			}
			if (!hasKey() && isJustPressedModKey())
			{
				return true;
			}
		}
		else if (!ignore_mod_keys && isHoldingAnyModKey())
		{
			return false;
		}
		if (hasKey() && isJustPressedKey())
		{
			return true;
		}
		return false;
	}

	public bool isHolding()
	{
		if (use_mouse_wheel)
		{
			if (Input.mouseScrollDelta.y == 0f)
			{
				return false;
			}
		}
		else if (!Input.anyKey)
		{
			return false;
		}
		if (disable_for_controlled_unit && ControllableUnit.isControllingUnit())
		{
			return false;
		}
		if (hasModKey())
		{
			if (!isHoldingModKey())
			{
				return false;
			}
			if (!hasKey() && isHoldingModKey())
			{
				return true;
			}
		}
		else if (!ignore_mod_keys && isHoldingAnyModKey())
		{
			return false;
		}
		if (hasKey() && isHoldingKey())
		{
			return true;
		}
		if (use_mouse_wheel)
		{
			return true;
		}
		return false;
	}

	private bool isHoldingModKey()
	{
		if (!Input.anyKey)
		{
			return false;
		}
		if (disable_for_controlled_unit && ControllableUnit.isControllingUnit())
		{
			return false;
		}
		if (default_key_mod_1 != KeyCode.None && Input.GetKey(default_key_mod_1))
		{
			return true;
		}
		if (default_key_mod_2 != KeyCode.None && Input.GetKey(default_key_mod_2))
		{
			return true;
		}
		if (default_key_mod_3 != KeyCode.None && Input.GetKey(default_key_mod_3))
		{
			return true;
		}
		return false;
	}

	public static bool isHoldingAnyModKey()
	{
		return AssetManager.hotkey_library.isHoldingAnyModKey();
	}

	private bool hasKey()
	{
		return default_key_1 != KeyCode.None;
	}

	private bool hasModKey()
	{
		return default_key_mod_1 != KeyCode.None;
	}

	public string getLocalizedKeys()
	{
		string text = "";
		string localizedKey = HotkeysLocalized.getLocalizedKey(default_key_1);
		string localizedKey2 = HotkeysLocalized.getLocalizedKey(default_key_2);
		string localizedKey3 = HotkeysLocalized.getLocalizedKey(default_key_3);
		string localizedKey4 = HotkeysLocalized.getLocalizedKey(default_key_mod_1);
		string localizedKey5 = HotkeysLocalized.getLocalizedKey(default_key_mod_2);
		string localizedKey6 = HotkeysLocalized.getLocalizedKey(default_key_mod_3);
		List<string> list = new List<string>();
		if (!string.IsNullOrEmpty(localizedKey))
		{
			list.Add(localizedKey);
		}
		if (!string.IsNullOrEmpty(localizedKey2))
		{
			list.Add(localizedKey2);
		}
		if (!string.IsNullOrEmpty(localizedKey3))
		{
			list.Add(localizedKey3);
		}
		List<string> list2 = new List<string>();
		if (!string.IsNullOrEmpty(localizedKey4))
		{
			list2.Add(localizedKey4);
		}
		if (!string.IsNullOrEmpty(localizedKey5))
		{
			list2.Add(localizedKey5);
		}
		if (!string.IsNullOrEmpty(localizedKey6))
		{
			list2.Add(localizedKey6);
		}
		list = new List<string>(new HashSet<string>(list));
		list2 = new List<string>(new HashSet<string>(list2));
		if (hasKey() && hasModKey())
		{
			int num = Mathf.Max(list.Count, list2.Count);
			string text2 = "";
			string text3 = "";
			for (int i = 0; i < num; i++)
			{
				if (i > 0)
				{
					text += " / ";
				}
				if (i < list2.Count)
				{
					text2 = list2[i];
				}
				if (i < list.Count)
				{
					text3 = list[i];
				}
				text = text + text2 + " + " + text3;
			}
		}
		else if (hasModKey())
		{
			text += string.Join(", ", list2);
		}
		else if (hasKey())
		{
			text += string.Join(", ", list);
		}
		return text;
	}

	private bool isHoldingKey()
	{
		if (!Input.anyKey)
		{
			return false;
		}
		if (default_key_1 != KeyCode.None && Input.GetKey(default_key_1))
		{
			return true;
		}
		if (default_key_2 != KeyCode.None && Input.GetKey(default_key_2))
		{
			return true;
		}
		if (default_key_3 != KeyCode.None && Input.GetKey(default_key_3))
		{
			return true;
		}
		return false;
	}

	private bool isJustPressedKey()
	{
		if (!Input.anyKeyDown)
		{
			return false;
		}
		if (default_key_1 != KeyCode.None && Input.GetKeyDown(default_key_1))
		{
			return true;
		}
		if (default_key_2 != KeyCode.None && Input.GetKeyDown(default_key_2))
		{
			return true;
		}
		if (default_key_3 != KeyCode.None && Input.GetKeyDown(default_key_3))
		{
			return true;
		}
		return false;
	}

	private bool isJustPressedModKey()
	{
		if (!Input.anyKeyDown)
		{
			return false;
		}
		if (default_key_mod_1 != KeyCode.None && Input.GetKeyDown(default_key_mod_1))
		{
			return true;
		}
		if (default_key_mod_2 != KeyCode.None && Input.GetKeyDown(default_key_mod_2))
		{
			return true;
		}
		if (default_key_mod_3 != KeyCode.None && Input.GetKeyDown(default_key_mod_3))
		{
			return true;
		}
		return false;
	}

	public bool checkIsPossible()
	{
		if (check_render_gameplay && !MapBox.isRenderGameplay())
		{
			return false;
		}
		if (check_render_minimap && !MapBox.isRenderMiniMap())
		{
			return false;
		}
		if (check_window_active)
		{
			if (!ScrollWindow.isWindowActive())
			{
				return false;
			}
			if (ScrollWindow.isAnimationActive())
			{
				return false;
			}
		}
		if (check_window_not_active && ScrollWindow.isWindowActive())
		{
			return false;
		}
		if (check_no_selection && SelectedUnit.isSet())
		{
			return false;
		}
		if (check_no_multi_unit_selection && SelectedUnit.multipleSelected())
		{
			return false;
		}
		if (check_multi_unit_selection && !SelectedUnit.multipleSelected())
		{
			return false;
		}
		if (check_only_not_controllable_unit && ControllableUnit.isControllingUnit())
		{
			return false;
		}
		if (check_only_controllable_unit && !ControllableUnit.isControllingUnit())
		{
			return false;
		}
		return true;
	}
}
