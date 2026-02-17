using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragOrderContainer : MonoBehaviour
{
	public enum SnapAxis
	{
		Horizontal,
		Vertical,
		No
	}

	internal static float drag_delay = 0.25f;

	public MonoBehaviour scroll_rect;

	public SnapAxis snapping_axis = SnapAxis.No;

	public bool limit_moving;

	public bool delay_before_drag = true;

	public bool debug;

	public Action on_order_changed;

	internal DragOrderElement dragging_element;

	internal bool is_anything_dragging;

	internal RectTransform rect_transform;

	internal LayoutGroup grid_layout;

	internal LayoutElement layout_element;

	private List<DragOrderElement> _elements = new List<DragOrderElement>();

	private Dictionary<int, DragOrderElement> _elements_dict = new Dictionary<int, DragOrderElement>();

	private Dictionary<int, Vector2> _children_positions = new Dictionary<int, Vector2>();

	private Dictionary<int, Rect> _children_rects = new Dictionary<int, Rect>();

	private Transform _to_ignore_in_intersection;

	private int _previous_elements_count;

	private bool _marked_for_update;

	private int _marked_for_update_on_frame;

	private bool _initialized;

	private void Awake()
	{
		if (scroll_rect == null)
		{
			scroll_rect = GetComponentInParent<ScrollRectExtended>();
		}
		if (scroll_rect == null)
		{
			scroll_rect = GetComponentInParent<ScrollRect>();
		}
		rect_transform = GetComponent<RectTransform>();
		grid_layout = GetComponent<LayoutGroup>();
		layout_element = base.gameObject.AddOrGetComponent<LayoutElement>();
		layout_element.enabled = false;
	}

	private void markForUpdate()
	{
		_marked_for_update = true;
		_marked_for_update_on_frame = Time.frameCount;
	}

	private void OnApplicationFocus(bool pHasFocus)
	{
		if (!pHasFocus)
		{
			disable();
		}
	}

	private void OnEnable()
	{
		markForUpdate();
		ScrollWindow.addCallbackShow(onWindowClose);
		ScrollWindow.addCallbackHide(onWindowClose);
	}

	private void OnDisable()
	{
		disable();
		ScrollWindow.removeCallbackShow(onWindowClose);
		ScrollWindow.removeCallbackHide(onWindowClose);
	}

	private void onWindowClose(string pId)
	{
		disable();
	}

	private void disable()
	{
		grid_layout.enabled = true;
		LayoutRebuilder.MarkLayoutForRebuild(rect_transform);
		if (dragging_element != null)
		{
			dragging_element.stopDrag();
		}
		foreach (DragOrderElement element in _elements)
		{
			if (!element.is_target_reached)
			{
				element.is_target_reached = true;
				element.unsetOnTop();
			}
		}
	}

	private void Update()
	{
		if (_marked_for_update && _marked_for_update_on_frame != Time.frameCount)
		{
			_marked_for_update = false;
			updateChildrenData();
		}
		checkIntersections();
		updatePositions();
	}

	private void OnDrawGizmos()
	{
		if (!debug)
		{
			return;
		}
		foreach (Rect value in _children_rects.Values)
		{
			Rect current = value;
			current.min = rect_transform.TransformPoint(current.min);
			current.max = rect_transform.TransformPoint(current.max);
			drawRect(current, Color.green);
		}
	}

	private void checkIntersections()
	{
		if (is_anything_dragging)
		{
			DragOrderElement intersectedWith = getIntersectedWith();
			if (intersectedWith == null)
			{
				_to_ignore_in_intersection = null;
			}
			else if (!(intersectedWith.main_transform == _to_ignore_in_intersection))
			{
				_to_ignore_in_intersection = intersectedWith.main_transform;
				switchElements(dragging_element, intersectedWith);
				on_order_changed?.Invoke();
			}
		}
	}

	private DragOrderElement getIntersectedWith()
	{
		int order_index = dragging_element.order_index;
		Vector2 vector = dragging_element.main_transform.localPosition;
		Debug.DrawLine(rect_transform.TransformPoint(_children_rects[order_index].center), rect_transform.TransformPoint(vector));
		if (snapping_axis != SnapAxis.No)
		{
			int key = 0;
			int key2 = _elements.Count - 1;
			Rect rect = _children_rects[key];
			Rect rect2 = _children_rects[key2];
			if (snapping_axis == SnapAxis.Horizontal)
			{
				if (vector.x <= rect.xMax)
				{
					return _elements_dict[key];
				}
				if (vector.x >= rect2.xMin)
				{
					return _elements_dict[key2];
				}
			}
			if (snapping_axis == SnapAxis.Vertical)
			{
				if (vector.y >= rect.yMax)
				{
					return _elements_dict[key];
				}
				if (vector.y <= rect2.yMin)
				{
					return _elements_dict[key2];
				}
			}
		}
		for (int i = 0; i < _elements.Count; i++)
		{
			if (i != order_index && _children_rects[i].Contains(vector))
			{
				return _elements_dict[i];
			}
		}
		return null;
	}

	private void updatePositions()
	{
		if (grid_layout.enabled)
		{
			return;
		}
		bool flag = false;
		foreach (DragOrderElement element in _elements)
		{
			if (!(element == dragging_element))
			{
				element.updatePosition();
				if (!element.is_target_reached)
				{
					flag = true;
				}
			}
		}
		if (!flag && !is_anything_dragging)
		{
			grid_layout.enabled = true;
		}
	}

	public void updateChildrenData()
	{
		layout_element.minHeight = rect_transform.rect.height;
		layout_element.minWidth = rect_transform.rect.width;
		_elements.Clear();
		_elements_dict.Clear();
		_children_positions.Clear();
		_children_rects.Clear();
		DragOrderElement[] componentsInChildren = rect_transform.GetComponentsInChildren<DragOrderElement>();
		int num = 0;
		DragOrderElement[] array = componentsInChildren;
		foreach (DragOrderElement dragOrderElement in array)
		{
			Vector2 vector = ((!dragOrderElement.is_target_reached && _previous_elements_count == componentsInChildren.Length) ? dragOrderElement.current_destination : ((Vector2)dragOrderElement.main_transform.localPosition));
			dragOrderElement.order_index = num;
			_elements.Add(dragOrderElement);
			_elements_dict.Add(num, dragOrderElement);
			_children_positions.Add(num, vector);
			Rect rect = dragOrderElement.getRect();
			_children_rects.Add(num, rect);
			dragOrderElement.current_destination = vector;
			dragOrderElement.unsetOnTop();
			num++;
		}
		_previous_elements_count = componentsInChildren.Length;
	}

	private void switchElements(DragOrderElement pFirst, DragOrderElement pSecond)
	{
		pFirst.main_transform.SetSiblingIndex(pSecond.main_transform.GetSiblingIndex());
		int order_index = pFirst.order_index;
		int order_index2 = pSecond.order_index;
		bool tIsAscending = order_index > order_index2;
		pFirst.order_index = order_index2;
		_elements.Sort((DragOrderElement e1, DragOrderElement e2) => sort(e1, e2, tIsAscending));
		int order_index3 = pFirst.order_index;
		foreach (DragOrderElement element in _elements)
		{
			if (!(element == pFirst) && (!tIsAscending || element.order_index >= order_index3) && (tIsAscending || element.order_index <= order_index3) && element.order_index == order_index3)
			{
				element.order_index += (tIsAscending ? 1 : (-1));
				order_index3 = element.order_index;
			}
		}
		foreach (DragOrderElement element2 in _elements)
		{
			_elements_dict[element2.order_index] = element2;
		}
	}

	public Vector3 getChildPosition(int pIndex)
	{
		return _children_positions[pIndex];
	}

	private int sort(DragOrderElement pFirst, DragOrderElement pSecond, bool pIsAscending)
	{
		return pFirst.order_index.CompareTo(pSecond.order_index) * (pIsAscending ? 1 : (-1));
	}

	private static void drawRect(Rect pRect, Color pColor)
	{
		Vector3 start = pRect.min;
		Vector3 vector = pRect.max;
		Debug.DrawLine(start, new Vector3(start.x, vector.y), pColor);
		Debug.DrawLine(new Vector3(start.x, vector.y), vector, pColor);
		Debug.DrawLine(vector, new Vector3(vector.x, start.y), pColor);
		Debug.DrawLine(start, new Vector3(vector.x, start.y), pColor);
	}
}
