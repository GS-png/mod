using UnityEngine;
using UnityEngine.UI;

public class StatIconDarkToggle : MonoBehaviour
{
	private Color _original_color;

	private Image _background;

	private const int INDEX_MAX = 3;

	private const float SHADE_FACTOR = 0.5f;

	private int _switched_index;

	private void changeColor()
	{
		if (!(_background == null))
		{
			_switched_index++;
			if (_switched_index >= 3)
			{
				_switched_index = 0;
			}
			float num = 1f - (float)_switched_index / 3f * 0.5f;
			Color color = new Color(_original_color.r * num, _original_color.g * num, _original_color.b * num, _original_color.a);
			_background.color = color;
		}
	}

	private void Awake()
	{
		base.gameObject.AddOrGetComponent<Button>().onClick.AddListener(click);
		_background = GetComponent<Image>();
		if (_background != null)
		{
			_original_color = _background.color;
		}
		else
		{
			_original_color = Color.white;
		}
	}

	private void click()
	{
		changeColor();
	}
}
