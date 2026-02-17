using UnityEngine;
using UnityEngine.UI;

public class SwitchStateButton : MonoBehaviour
{
	[SerializeField]
	private Image _icon;

	[SerializeField]
	private Image _background;

	[SerializeField]
	private Button _button;

	[SerializeField]
	private Sprite _sprite_enabled;

	[SerializeField]
	private Sprite _sprite_disabled;

	private bool _state = true;

	private PowerButton _power_button;

	private void Awake()
	{
		_power_button = GetComponent<PowerButton>();
	}

	public void setState(bool pState)
	{
		_state = pState;
		if (_state)
		{
			_background.sprite = _sprite_enabled;
			_icon.color = Color.white;
		}
		else
		{
			_background.sprite = _sprite_disabled;
			_icon.color = Toolbox.color_grey_dark;
		}
		_button.enabled = _state;
		if (_power_button != null)
		{
			_power_button.is_selectable = _state;
		}
	}
}
