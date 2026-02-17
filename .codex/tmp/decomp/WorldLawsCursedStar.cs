using UnityEngine;
using UnityEngine.UI;

public class WorldLawsCursedStar : MonoBehaviour
{
	[SerializeField]
	private Image _empty_star;

	[SerializeField]
	private Image _filled_star;

	[SerializeField]
	private Sprite _filled_star_sprite;

	[SerializeField]
	private Sprite _egg_sprite;

	private bool _filled;

	public void setStarsTransparency(float pValue)
	{
		float a = 1f - pValue;
		Color color = _empty_star.color;
		color.a = a;
		_empty_star.color = color;
		color.a = pValue;
		_filled_star.color = color;
	}

	public void setColorMultiplyAlphaBoth(Color pColor, float pValue)
	{
		if (pValue < 0f)
		{
			pValue = 0f;
		}
		pColor.a = _empty_star.color.a * pValue;
		_empty_star.color = pColor;
		pColor.a = _filled_star.color.a * pValue;
		_filled_star.color = pColor;
	}

	public void toggleEgg(bool pState)
	{
		if (pState)
		{
			_filled_star.sprite = _egg_sprite;
		}
		else
		{
			_filled_star.sprite = _filled_star_sprite;
		}
	}

	public void toggleFilled(bool pState)
	{
		_filled = pState;
	}

	public bool isFilled()
	{
		return _filled;
	}
}
