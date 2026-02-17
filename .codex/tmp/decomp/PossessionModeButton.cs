using UnityEngine;
using UnityEngine.UI;

public class PossessionModeButton : MonoBehaviour
{
	public PossessionActionMode mode;

	[SerializeField]
	private Image _image_icon;

	[SerializeField]
	private Image _image_background;

	public void updateGraphics(PossessionActionMode pCurrentSelectedMode)
	{
		if (mode == pCurrentSelectedMode)
		{
			_image_icon.color = Color.white;
			_image_background.color = Color.white;
		}
		else
		{
			_image_icon.color = new Color(0.3f, 0.3f, 0.3f, 1f);
			_image_background.color = Color.gray;
		}
	}
}
