using UnityEngine;
using UnityEngine.UI;

public class RainSwitcherButton : MonoBehaviour
{
	[SerializeField]
	private Image _icon;

	[SerializeField]
	private Image _background;

	[SerializeField]
	private Button _button;

	[SerializeField]
	private Sprite _enabled;

	[SerializeField]
	private Sprite _disabled;

	public void toggleState(bool pState)
	{
		if (pState)
		{
			_background.sprite = _enabled;
			_icon.color = ColorStyleLibrary.m.favorite_selected;
		}
		else
		{
			_background.sprite = _disabled;
			_icon.color = ColorStyleLibrary.m.favorite_not_selected;
		}
	}

	public Button getButton()
	{
		return _button;
	}
}
