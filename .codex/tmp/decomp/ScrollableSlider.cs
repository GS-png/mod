using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[DisallowMultipleComponent]
[RequireComponent(typeof(Slider))]
[RequireComponent(typeof(SliderExtended))]
public class ScrollableSlider : MonoBehaviour, IScrollHandler, IEventSystemHandler
{
	private ScrollRect _scroll_rect;

	private ScrollRectExtended _scroll_rect_extended;

	protected void Start()
	{
		_scroll_rect_extended = base.gameObject.GetComponentInParent<ScrollRectExtended>();
		if (_scroll_rect_extended == null)
		{
			_scroll_rect = base.gameObject.GetComponentInParent<ScrollRect>();
		}
		if (_scroll_rect == null && _scroll_rect_extended == null)
		{
			base.enabled = false;
		}
	}

	public void OnScroll(PointerEventData pEventData)
	{
		_scroll_rect?.SendMessage("OnScroll", pEventData);
		_scroll_rect_extended?.SendMessage("OnScroll", pEventData);
	}
}
