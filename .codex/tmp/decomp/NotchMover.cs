using UnityEngine;

public class NotchMover : MonoBehaviour
{
	private float originalTopPosition;

	private RectTransform rectTransform;

	private Canvas _canvas;

	private void Start()
	{
		rectTransform = GetComponent<RectTransform>();
		originalTopPosition = rectTransform.anchoredPosition.y;
		_canvas = base.gameObject.transform.GetComponentInParent<Canvas>();
	}

	private void Update()
	{
		if ((float)Screen.height != Screen.safeArea.height && !(_canvas == null))
		{
			float num = ((float)Screen.height - Screen.safeArea.height) / _canvas.scaleFactor;
			rectTransform.anchoredPosition = new Vector3(rectTransform.anchoredPosition.x, originalTopPosition - num);
		}
	}
}
