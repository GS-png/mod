using UnityEngine;
using UnityEngine.EventSystems;

public class UiWindowStretch : EventTrigger
{
	public RectTransform stretchTarget;

	private bool dragging;

	private Transform mainTransform;

	private Transform canvasContainer;

	public Vector3 posClicked;

	public Vector3 newSize;

	public Vector2 originSizeDelta;

	private void Start()
	{
	}

	public void Update()
	{
		if (dragging)
		{
			Vector3 vector = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
			newSize = posClicked - vector;
			stretchTarget.sizeDelta = new Vector2(originSizeDelta.x - newSize.x, originSizeDelta.y + newSize.y);
		}
	}

	public override void OnPointerDown(PointerEventData eventData)
	{
		if (!dragging)
		{
			posClicked = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
			originSizeDelta = stretchTarget.sizeDelta;
		}
		dragging = true;
	}

	public override void OnPointerUp(PointerEventData eventData)
	{
		dragging = false;
	}
}
