using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteSwitcher : MonoBehaviour
{
	public Sprite primary_sprite;

	public Sprite secondary_sprite;

	private Image _image;

	private Image _icon;

	private bool? _last_state;

	private static List<SpriteSwitcher> _all_buttons = new List<SpriteSwitcher>();

	private void Awake()
	{
		_image = GetComponent<Image>();
		_icon = base.transform.Find("Icon").GetComponent<Image>();
	}

	private void OnEnable()
	{
		_all_buttons.Add(this);
		checkState();
	}

	private void OnDisable()
	{
		_all_buttons.Remove(this);
	}

	public static void checkAllStates()
	{
		foreach (SpriteSwitcher all_button in _all_buttons)
		{
			all_button.checkState();
		}
	}

	private void checkState()
	{
		if (!Config.game_loaded || !base.gameObject.activeInHierarchy)
		{
			return;
		}
		bool flag = hasAny();
		if (_last_state != flag)
		{
			_last_state = flag;
			if (flag)
			{
				setPrimary();
			}
			else
			{
				setSecondary();
			}
		}
	}

	protected virtual bool hasAny()
	{
		throw new NotImplementedException();
	}

	private void setPrimary()
	{
		_image.sprite = primary_sprite;
		Color color = _icon.color;
		color.a = 1f;
		_icon.color = color;
	}

	private void setSecondary()
	{
		_image.sprite = secondary_sprite;
		Color color = _icon.color;
		color.a = 0.9f;
		_icon.color = color;
	}
}
