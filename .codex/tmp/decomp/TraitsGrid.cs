using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class TraitsGrid : MonoBehaviour, ILayoutController
{
	public OnChange on_change;

	private RectTransform _rect;

	private List<RectTransform> _rect_children = new List<RectTransform>();

	private void Awake()
	{
		_rect = GetComponent<RectTransform>();
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
			on_change?.Invoke();
		}
	}

	public void SetLayoutHorizontal()
	{
	}
}
