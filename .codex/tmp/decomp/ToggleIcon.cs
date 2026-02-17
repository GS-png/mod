using UnityEngine;
using UnityEngine.UI;

public class ToggleIcon : MonoBehaviour
{
	public Sprite spriteON;

	public Sprite spriteOFF;

	private Image image;

	private void Awake()
	{
		image = GetComponent<Image>();
	}

	internal void updateIcon(bool pEnabled)
	{
		if (image == null)
		{
			image = GetComponent<Image>();
		}
		if (pEnabled)
		{
			image.sprite = spriteON;
		}
		else
		{
			image.sprite = spriteOFF;
		}
	}

	internal void updateIconMultiToggle(bool pActive, bool pEnabled)
	{
		if (image == null)
		{
			image = GetComponent<Image>();
		}
		if (pActive)
		{
			image.gameObject.SetActive(value: true);
		}
		else
		{
			image.gameObject.SetActive(value: false);
		}
		if (pActive)
		{
			image.color = Color.white;
		}
		else if (pEnabled)
		{
			image.color = Toolbox.color_grey;
		}
		else
		{
			image.color = Color.white;
		}
		if (pEnabled)
		{
			image.sprite = spriteON;
		}
		else
		{
			image.sprite = spriteOFF;
		}
	}
}
