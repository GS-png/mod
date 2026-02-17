using UnityEngine;
using UnityEngine.UI;

public class SortButton : MonoBehaviour
{
	public Image arrow_sprite;

	public Image icon;

	public Image background;

	private SortButtonState _state;

	public SortButtonAction action;

	public SortButtonAction post_action;

	public SortButtonClearAction select_action;

	protected static Sprite _tab_button_on;

	protected static Sprite _tab_button_off;

	private void Awake()
	{
		if (_tab_button_on == null)
		{
			_tab_button_on = SpriteTextureLoader.getSprite("ui/tab_button_sort_selected");
			_tab_button_off = SpriteTextureLoader.getSprite("ui/tab_button_sort");
		}
		arrow_sprite.gameObject.SetActive(value: false);
		setState(SortButtonState.None);
		background.sprite = _tab_button_off;
	}

	private void Start()
	{
		GetComponent<Button>().onClick.AddListener(click);
	}

	public SortButtonState getState()
	{
		return _state;
	}

	private void setState(SortButtonState pState)
	{
		_state = pState;
	}

	internal void turnOff()
	{
		setState(SortButtonState.None);
		arrow_sprite.gameObject.SetActive(value: false);
		background.sprite = _tab_button_off;
		Color white = Color.white;
		white.a = 0.5f;
		icon.color = white;
		base.transform.parent.GetComponent<RectTransform>().sizeDelta = new Vector2(27f, 37f);
	}

	public void click()
	{
		select_action?.Invoke(this);
		switch (_state)
		{
		case SortButtonState.None:
			setSortUP();
			break;
		case SortButtonState.Up:
			setSortDOWN();
			break;
		case SortButtonState.Down:
			setSortUP();
			break;
		}
		action?.Invoke();
		post_action?.Invoke();
	}

	public void callAction()
	{
	}

	public void setSortUP()
	{
		setState(SortButtonState.Up);
		arrow_sprite.gameObject.SetActive(value: true);
		arrow_sprite.sprite = SpriteTextureLoader.getSprite("ui/Icons/iconArrowUP");
		background.sprite = _tab_button_on;
		icon.color = Color.white;
		base.transform.parent.GetComponent<RectTransform>().sizeDelta = new Vector2(33f, 37f);
	}

	public void setSortDOWN()
	{
		setState(SortButtonState.Down);
		arrow_sprite.gameObject.SetActive(value: true);
		arrow_sprite.sprite = SpriteTextureLoader.getSprite("ui/Icons/iconArrowDOWN");
		background.sprite = _tab_button_on;
		icon.color = Color.white;
		base.transform.parent.GetComponent<RectTransform>().sizeDelta = new Vector2(33f, 37f);
	}
}
