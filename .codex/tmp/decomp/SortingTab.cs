using System.Collections.Generic;
using UnityEngine;

public class SortingTab : MonoBehaviour
{
	public bool scrollable;

	private readonly List<SortButtonContainer> _buttons = new List<SortButtonContainer>();

	private SortButton _current_sort_button;

	public SortButton getCurrentButton()
	{
		return _current_sort_button;
	}

	public void clearButtons()
	{
		foreach (SortButtonContainer button in _buttons)
		{
			button.gameObject.SetActive(value: false);
		}
	}

	public SortButton tryAddButton(string pIcon, string pTooltip, SortButtonAction pShowAction, SortButtonAction pAction)
	{
		if (switchButton(pTooltip, pEnabled: true))
		{
			return null;
		}
		return addButton(pIcon, pTooltip, pShowAction, pAction);
	}

	public bool switchButton(string pTooltip, bool pEnabled)
	{
		foreach (SortButtonContainer button in _buttons)
		{
			if (button.gameObject.name == pTooltip)
			{
				button.gameObject.SetActive(pEnabled);
				return true;
			}
		}
		return false;
	}

	public SortButton addButton(string pIcon, string pTooltip, SortButtonAction pShowAction, SortButtonAction pAction)
	{
		SortButtonContainer sortButtonContainer = Object.Instantiate(Resources.Load<SortButtonContainer>("ui/SortButtonGeneric"), base.transform);
		SortButton componentInChildren = sortButtonContainer.GetComponentInChildren<SortButton>();
		PowerButton component = componentInChildren.GetComponent<PowerButton>();
		component.icon.sprite = SpriteTextureLoader.getSprite(pIcon);
		component.GetComponent<TipButton>().textOnClick = pTooltip;
		componentInChildren.icon = component.icon;
		componentInChildren.select_action = selectAction;
		componentInChildren.action = pAction;
		componentInChildren.post_action = pShowAction;
		componentInChildren.gameObject.name = pTooltip;
		sortButtonContainer.gameObject.name = pTooltip;
		_buttons.Add(sortButtonContainer);
		if (scrollable)
		{
			componentInChildren.gameObject.AddComponent<ScrollableButton>();
		}
		return componentInChildren;
	}

	private void selectAction(SortButton pButton)
	{
		foreach (SortButtonContainer button in _buttons)
		{
			if (!(button.sort_button == pButton))
			{
				button.sort_button.turnOff();
			}
		}
		_current_sort_button = pButton;
	}

	internal void enableFirstIfNone()
	{
		if (_buttons.Count == 0)
		{
			return;
		}
		foreach (SortButtonContainer button in _buttons)
		{
			if (button.gameObject.activeSelf && button.sort_button == _current_sort_button)
			{
				return;
			}
		}
		selectAction(null);
		foreach (SortButtonContainer button2 in _buttons)
		{
			if (button2.gameObject.activeSelf)
			{
				button2.sort_button.click();
				break;
			}
		}
	}
}
