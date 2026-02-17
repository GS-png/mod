using UnityEngine;
using UnityEngine.UI;

public class SwitchButton : MonoBehaviour
{
	public Color color_on = Color.white;

	public Color color_off = Color.gray;

	public Text text;

	public Image icon;

	public void setEnabled(bool pValue)
	{
		if (pValue)
		{
			GetComponent<CanvasGroup>().alpha = 1f;
		}
		else
		{
			GetComponent<CanvasGroup>().alpha = 0.5f;
		}
	}
}
