using UnityEngine;
using UnityEngine.UI;

public class TabToggle : MonoBehaviour
{
	public Image icon;

	public Image background;

	private TabToggleState _state;

	public TabToggleAction action;

	public TabToggleAction post_action;

	public TabToggleClearAction select_action;

	protected static Sprite _tab_toggle_on;

	protected static Sprite _tab_toggle_off;

	private void Awake()
	{
		if (_tab_toggle_on == null)
		{
			_tab_toggle_on = SpriteTextureLoader.getSprite("ui/tab_button_sort_selected");
			_tab_toggle_off = SpriteTextureLoader.getSprite("ui/tab_button_sort");
		}
		unselect();
	}

	private void Start()
	{
		GetComponent<Button>().onClick.AddListener(click);
	}

	public TabToggleState getState()
	{
		return _state;
	}

	private void setState(TabToggleState pState)
	{
		_state = pState;
	}

	public void click()
	{
		if (_state != TabToggleState.Selected)
		{
			select_action?.Invoke(this);
			select();
			action?.Invoke();
			post_action?.Invoke();
		}
	}

	public void select()
	{
		setState(TabToggleState.Selected);
		background.sprite = _tab_toggle_on;
		icon.color = Color.white;
	}

	public void unselect()
	{
		setState(TabToggleState.None);
		background.sprite = _tab_toggle_off;
		Color white = Color.white;
		white.a = 0.5f;
		icon.color = white;
	}
}
