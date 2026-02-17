using System.Collections.Generic;
using LayoutGroupExt;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class FlexibleOneRowGrid : MonoBehaviour, ILayoutController
{
	public bool debug;

	public int bonus_spacing_x;

	private RectTransform _grid_rect;

	private GridLayoutGroup _grid;

	private GridLayoutGroupExtended _grid_extended;

	private bool _is_extended;

	private bool _initialized;

	private void Awake()
	{
		init();
	}

	private void init()
	{
		if (!_initialized)
		{
			_initialized = true;
			if (this.HasComponent<GridLayoutGroup>())
			{
				_grid = GetComponent<GridLayoutGroup>();
				_grid_rect = _grid.GetComponent<RectTransform>();
			}
			else
			{
				_grid_extended = GetComponent<GridLayoutGroupExtended>();
				_grid_rect = _grid_extended.GetComponent<RectTransform>();
				_is_extended = true;
			}
		}
	}

	public void SetLayoutHorizontal()
	{
		if (debug || Application.isPlaying)
		{
			init();
			float num = (_is_extended ? _grid_extended.cellSize.x : _grid.cellSize.x);
			float width = _grid_rect.rect.width;
			float num2 = calculateChildren();
			float num3 = 0f;
			float num4 = num * num2 + (float)bonus_spacing_x * (num2 - 1f);
			if (num4 < width)
			{
				num3 = bonus_spacing_x;
			}
			else
			{
				num4 = num * num2;
				num3 = (width - num4) / (num2 - 1f);
			}
			if (_is_extended)
			{
				_grid_extended.spacing = new Vector2(num3, 0f);
			}
			else
			{
				_grid.spacing = new Vector2(num3, 0f);
			}
		}
	}

	public float calculateChildren()
	{
		List<Component> list = CollectionPool<List<Component>, Component>.Get();
		int num = 0;
		int i = 0;
		for (int childCount = _grid_rect.childCount; i < childCount; i++)
		{
			RectTransform rectTransform = _grid_rect.GetChild(i) as RectTransform;
			if (rectTransform == null || !rectTransform.gameObject.activeInHierarchy)
			{
				continue;
			}
			if (!rectTransform.HasComponent<ILayoutIgnorer>())
			{
				num++;
				continue;
			}
			rectTransform.GetComponents(typeof(ILayoutIgnorer), list);
			for (int j = 0; j < list.Count; j++)
			{
				if (!((ILayoutIgnorer)list[j]).ignoreLayout)
				{
					num++;
					break;
				}
			}
			list.Clear();
		}
		CollectionPool<List<Component>, Component>.Release(list);
		return num;
	}

	public void SetLayoutVertical()
	{
	}
}
