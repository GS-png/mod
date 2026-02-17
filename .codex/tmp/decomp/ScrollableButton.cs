using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class ScrollableButton : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IInitializePotentialDragHandler, IScrollHandler
{
	private ScrollRect _scroll_rect;

	private ScrollRectExtended _scroll_rect_extended;

	private Button _button;

	private bool _has_button;

	[SerializeField]
	private bool _scroll_wheel_only;

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
		_has_button = base.gameObject.TryGetComponent<Button>(out _button);
	}

	public void OnBeginDrag(PointerEventData pEventData)
	{
		if (!_scroll_wheel_only)
		{
			sendMessage("OnBeginDrag", pEventData);
			if (_has_button)
			{
				_button.interactable = false;
			}
		}
	}

	public void OnDrag(PointerEventData pEventData)
	{
		if (!_scroll_wheel_only)
		{
			sendMessage("OnDrag", pEventData);
		}
	}

	public void OnEndDrag(PointerEventData pEventData)
	{
		if (!_scroll_wheel_only)
		{
			sendMessage("OnEndDrag", pEventData);
			if (_has_button)
			{
				_button.interactable = true;
			}
		}
	}

	public void OnInitializePotentialDrag(PointerEventData pEventData)
	{
		if (!_scroll_wheel_only)
		{
			sendMessage("OnInitializePotentialDrag", pEventData);
		}
	}

	public void OnScroll(PointerEventData pEventData)
	{
		sendMessage("OnScroll", pEventData);
	}

	private void sendMessage(string pMethodName, PointerEventData pEventData)
	{
		_scroll_rect?.SendMessage(pMethodName, pEventData);
		_scroll_rect_extended?.SendMessage(pMethodName, pEventData);
	}
}
