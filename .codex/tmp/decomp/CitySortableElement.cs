using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CitySortableElement : CityElement, ILayoutController
{
	private RectTransform _rect;

	private List<RectTransform> _rect_children = new List<RectTransform>();

	protected override void Awake()
	{
		_rect = GetComponent<RectTransform>();
		base.Awake();
	}

	protected virtual void onListChange()
	{
	}

	public void SetLayoutVertical()
	{
		if (_rect == null)
		{
			return;
		}
		using ListPool<RectTransform> listPool = _rect.getLayoutChildren();
		if (!listPool.SequenceEqual(_rect_children))
		{
			_rect_children.Clear();
			_rect_children.AddRange(listPool);
			onListChange();
		}
	}

	public void SetLayoutHorizontal()
	{
	}
}
