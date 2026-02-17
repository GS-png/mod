using System.Collections.Generic;
using UnityEngine;

public class TabTogglesGroup : MonoBehaviour
{
	private readonly List<TabToggleContainer> _toggles = new List<TabToggleContainer>();

	private TabToggle _current_toggle;

	public TabToggle getCurrentButton()
	{
		return _current_toggle;
	}

	public void clearButtons()
	{
		foreach (TabToggleContainer toggle in _toggles)
		{
			toggle.gameObject.SetActive(value: false);
		}
	}

	public void tryAddButton(string pIcon, string pTooltip, TabToggleAction pShowAction, TabToggleAction pAction)
	{
		if (!switchButton(pTooltip, pEnabled: true))
		{
			addButton(pIcon, pTooltip, pShowAction, pAction);
		}
	}

	public bool switchButton(string pTooltip, bool pEnabled)
	{
		foreach (TabToggleContainer toggle in _toggles)
		{
			if (toggle.gameObject.name == pTooltip)
			{
				toggle.gameObject.SetActive(pEnabled);
				return true;
			}
		}
		return false;
	}

	public void addButton(string pIcon, string pTooltip, TabToggleAction pShowAction, TabToggleAction pAction)
	{
		TabToggleContainer tabToggleContainer = Object.Instantiate(Resources.Load<TabToggleContainer>("ui/TabToggleGeneric"), base.transform);
		TabToggle componentInChildren = tabToggleContainer.GetComponentInChildren<TabToggle>();
		PowerButton component = componentInChildren.GetComponent<PowerButton>();
		component.icon.sprite = SpriteTextureLoader.getSprite(pIcon);
		component.GetComponent<TipButton>().textOnClick = pTooltip;
		component.GetComponent<TipButton>().textOnClickDescription = pTooltip + "_description";
		componentInChildren.icon = component.icon;
		componentInChildren.select_action = selectAction;
		componentInChildren.action = pAction;
		componentInChildren.post_action = pShowAction;
		componentInChildren.gameObject.name = pTooltip;
		tabToggleContainer.gameObject.name = pTooltip;
		_toggles.Add(tabToggleContainer);
	}

	private void selectAction(TabToggle pToggle)
	{
		foreach (TabToggleContainer toggle in _toggles)
		{
			if (!(toggle.toggle == pToggle))
			{
				toggle.toggle.unselect();
			}
		}
		_current_toggle = pToggle;
	}

	internal void enableFirst()
	{
		if (_toggles.Count == 0)
		{
			return;
		}
		selectAction(null);
		foreach (TabToggleContainer toggle in _toggles)
		{
			if (toggle.gameObject.activeSelf)
			{
				toggle.toggle.click();
				break;
			}
		}
	}
}
