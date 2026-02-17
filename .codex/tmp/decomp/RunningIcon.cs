using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RunningIcon : MonoBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IScrollHandler, IPointerClickHandler, IDraggable
{
	[SerializeField]
	private Image _icon;

	private RunningIcons _parent;

	private Vector2 _last_position;

	public bool spawn_particles_on_drag => false;

	public void Awake()
	{
		_parent = GetComponentInParent<RunningIcons>();
	}

	public Image getIconImage()
	{
		return _icon;
	}

	public void setIcon(Sprite pIcon)
	{
		_icon.sprite = pIcon;
	}

	public void setIconColor(Color pColor)
	{
		_icon.color = pColor;
	}

	public void OnBeginDrag(PointerEventData pEventData)
	{
		if (!Config.isDraggingItem())
		{
			Config.setDraggingObject(this);
			_last_position = pEventData.position;
			_parent.toggle(pState: false);
		}
	}

	public void OnDrag(PointerEventData pEventData)
	{
		if (!Config.isDraggingObject(this))
		{
			return;
		}
		_parent.toggle(pState: false);
		Vector2 vector = pEventData.position - _last_position;
		_last_position = pEventData.position;
		if (vector.x != 0f)
		{
			float num = vector.x / CanvasMain.instance.canvas_ui.scaleFactor;
			if (num < 0f)
			{
				_parent.moveBy(Mathf.Abs(num), RunningIcons.Direction.Left);
			}
			else
			{
				_parent.moveBy(Mathf.Abs(num), RunningIcons.Direction.Right);
			}
		}
	}

	public void OnEndDrag(PointerEventData pEventData)
	{
		if (Config.isDraggingItem() && Config.isDraggingObject(this))
		{
			Config.clearDraggingObject();
			_parent.toggle(pState: true);
		}
	}

	public void OnScroll(PointerEventData pEventData)
	{
		if (pEventData.scrollDelta.y < 0f)
		{
			_parent.moveBy(Mathf.Abs(pEventData.scrollDelta.y * 20f), RunningIcons.Direction.Left);
		}
		else
		{
			_parent.moveBy(Mathf.Abs(pEventData.scrollDelta.y * 20f), RunningIcons.Direction.Right);
		}
	}

	public void OnPointerClick(PointerEventData pEventData)
	{
		if (!InputHelpers.mouseSupported)
		{
			GetComponent<Button>().onClick.Invoke();
			if (EventSystem.current.currentSelectedGameObject == _parent.gameObject)
			{
				_parent.toggle(pState: false);
			}
			EventSystem.current.SetSelectedGameObject(_parent.gameObject);
		}
	}

	private void OnDisable()
	{
		KillDrag();
	}

	public void KillDrag()
	{
		OnEndDrag(new PointerEventData(EventSystem.current));
	}

	Transform IDraggable.get_transform()
	{
		return base.transform;
	}
}
