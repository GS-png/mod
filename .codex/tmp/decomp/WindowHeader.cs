using UnityEngine;

public class WindowHeader : MonoBehaviour
{
	public void Awake()
	{
		GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 3f);
	}
}
