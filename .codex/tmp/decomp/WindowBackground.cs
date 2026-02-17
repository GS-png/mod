using UnityEngine;

public class WindowBackground : MonoBehaviour
{
	private CanvasGroup group;

	private void Start()
	{
		group = GetComponent<CanvasGroup>();
	}

	private void Update()
	{
		if (ScrollWindow.isWindowActive() && group.alpha < 1f)
		{
			group.alpha += Time.deltaTime * 5f;
		}
		else if (!ScrollWindow.isWindowActive() && group.alpha > 0f)
		{
			group.alpha -= Time.deltaTime * 5f;
		}
	}
}
