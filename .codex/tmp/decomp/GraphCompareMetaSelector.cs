using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(ScrollableButton))]
public class GraphCompareMetaSelector : MonoBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IDragHandler, IBeginDragHandler, IEndDragHandler, IDraggable
{
	[SerializeField]
	private bool _spawn_particles_on_drag = true;

	private Vector3 _start_local_position;

	private Transform _start_parent;

	private ScrollableButton _scrollable_button;

	private readonly List<Graphic> _raycastables = new List<Graphic>();

	private Vector2 _first_position = Vector2.zero;

	private bool _dragging;

	private readonly List<RectTransform> _dropzones = new List<RectTransform>();

	private GraphCompareWindow _window;

	public bool spawn_particles_on_drag => _spawn_particles_on_drag;

	private Transform _attach_parent => World.world.drag_parent;

	private void Awake()
	{
		_scrollable_button = GetComponent<ScrollableButton>();
		_start_parent = base.transform.parent;
		GetComponent<Button>().onClick.AddListener(showTooltip);
	}

	private void showTooltip()
	{
		IBanner component = GetComponent<IBanner>();
		if (!InputHelpers.mouseSupported && !Tooltip.isShowingFor(component))
		{
			component.showTooltip();
		}
	}

	public void addWindow(GraphCompareWindow pWindow)
	{
		_window = pWindow;
	}

	public void addDropzones(params RectTransform[] pDropzones)
	{
		_dropzones.Clear();
		_dropzones.AddRange(pDropzones);
	}

	public bool isBeingDragged()
	{
		return _dragging;
	}

	public void OnInitializePotentialDrag(PointerEventData pEventData)
	{
		_dragging = false;
		_first_position = pEventData.position;
		_start_parent = base.transform.parent;
		_start_local_position = base.transform.localPosition;
	}

	public bool checkIfDragging(PointerEventData pEventData)
	{
		if (_window.countNoosItems() < 5)
		{
			return true;
		}
		Vector2 p = new Vector2(float.MaxValue, 0f);
		Vector2 p2 = new Vector2(float.MinValue, 0f);
		foreach (RectTransform dropzone in _dropzones)
		{
			Vector2 vector = dropzone.position;
			vector.x -= dropzone.rect.width * dropzone.lossyScale.x / 2f;
			vector.y -= dropzone.rect.height * dropzone.lossyScale.y / 2f;
			Vector2 vector2 = dropzone.position;
			vector2.x += dropzone.rect.width * dropzone.lossyScale.x / 2f;
			vector2.y -= dropzone.rect.height * dropzone.lossyScale.y / 2f;
			if (vector.x < p.x)
			{
				p = vector;
			}
			if (vector2.x > p2.x)
			{
				p2 = vector2;
			}
		}
		if (!Toolbox.isInTriangle(pEventData.position, _first_position, p, p2))
		{
			Vector2 vector3 = pEventData.position - _first_position;
			if (Mathf.Abs(vector3.x) > Mathf.Abs(vector3.y))
			{
				return false;
			}
		}
		return true;
	}

	public void OnBeginDrag(PointerEventData pEventData)
	{
		if (!Config.isDraggingItem() && !_dragging)
		{
			_dragging = checkIfDragging(pEventData);
			if (_dragging)
			{
				Config.setDraggingObject(this);
				pEventData.Use();
				_scrollable_button.enabled = false;
				GraphCompareMetaObject.disable_raycasts = true;
				base.transform.SetParent(_attach_parent);
				base.transform.position = pEventData.position;
				disableRaycast();
			}
		}
	}

	public void OnDrag(PointerEventData pEventData)
	{
		if (_dragging && Config.isDraggingObject(this))
		{
			pEventData.Use();
			base.transform.position = pEventData.position;
		}
	}

	public void OnEndDrag(PointerEventData pEventData)
	{
		_scrollable_button.OnEndDrag(pEventData);
		if (_dragging && Config.isDraggingObject(this))
		{
			pEventData.Use();
			base.transform.SetParent(_start_parent);
			base.transform.localPosition = _start_local_position;
			resetDrag();
		}
	}

	public void resetDrag()
	{
		if (!_dragging)
		{
			return;
		}
		Config.clearDraggingObject();
		_dragging = false;
		_scrollable_button.enabled = true;
		GraphCompareMetaObject.disable_raycasts = false;
		foreach (Graphic raycastable in _raycastables)
		{
			raycastable.raycastTarget = true;
		}
	}

	private void disableRaycast()
	{
		_raycastables.Clear();
		Graphic[] componentsInChildren = GetComponentsInChildren<Graphic>();
		foreach (Graphic graphic in componentsInChildren)
		{
			if (graphic.raycastTarget)
			{
				_raycastables.Add(graphic);
			}
		}
		foreach (Graphic raycastable in _raycastables)
		{
			raycastable.raycastTarget = false;
		}
	}

	private void OnDisable()
	{
		resetDrag();
	}

	public void KillDrag()
	{
		OnDisable();
	}

	Transform IDraggable.get_transform()
	{
		return base.transform;
	}
}
