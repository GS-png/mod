using UnityEngine;
using UnityEngine.UI;

public class ToggleButton : MonoBehaviour
{
	[SerializeField]
	private Image _background;

	private ToggleButtonSelectAction _action;

	private ToggleButtonAction _post_action;

	private static Sprite _sprite_on;

	private static Sprite _sprite_off;

	public bool is_on;

	private void Awake()
	{
		if (_sprite_on == null)
		{
			_sprite_on = SpriteTextureLoader.getSprite("ui/tab_button_sort_selected");
			_sprite_off = SpriteTextureLoader.getSprite("ui/tab_button_sort");
		}
		_background.sprite = _sprite_off;
		GetComponent<Button>().onClick.AddListener(click);
	}

	public void init(string pIcon, string pTooltip, ToggleButtonSelectAction pAction, ToggleButtonAction pShowAction)
	{
		PowerButton component = GetComponent<PowerButton>();
		component.icon.sprite = SpriteTextureLoader.getSprite(pIcon);
		component.GetComponent<TipButton>().textOnClick = pTooltip;
		_action = pAction;
		_post_action = pShowAction;
		base.gameObject.name = pTooltip;
	}

	public void click()
	{
		is_on = !is_on;
		checkSprite();
		_action?.Invoke(this);
		_post_action?.Invoke();
	}

	private void checkSprite()
	{
		_background.sprite = (is_on ? _sprite_on : _sprite_off);
	}
}
