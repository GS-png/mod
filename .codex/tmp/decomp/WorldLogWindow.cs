using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using db;

public class WorldLogWindow : MonoBehaviour
{
	private const int PADDING_ELEMENTS = 3;

	[SerializeField]
	private WorldLogElement _element_prefab_log;

	[SerializeField]
	private EmptyLogElement _element_prefab_empty;

	[SerializeField]
	private Transform _transform_content;

	[SerializeField]
	private GameObject _no_items;

	[SerializeField]
	private GridLayoutGroup _grid;

	[SerializeField]
	private ScrollRect _scroll_rect;

	[SerializeField]
	private ToggleButton _prefab;

	private ObjectPoolGenericMono<WorldLogElement> _pool;

	private ObjectPoolGenericMono<EmptyLogElement> _pool_empty;

	private HashSet<string> _selected_groups = new HashSet<string>();

	private ListPool<WorldLogMessage> _messages;

	private bool _autolayout_done;

	private void Awake()
	{
		_pool = new ObjectPoolGenericMono<WorldLogElement>(_element_prefab_log, _transform_content);
		_pool_empty = new ObjectPoolGenericMono<EmptyLogElement>(_element_prefab_empty, _transform_content);
		foreach (HistoryGroupAsset tAsset in AssetManager.history_groups.list)
		{
			UnityEngine.Object.Instantiate(_prefab, _grid.transform).init(tAsset.icon_path, tAsset.getLocaleID(), delegate(ToggleButton pButton)
			{
				if (pButton.is_on)
				{
					_selected_groups.Add(tAsset.id);
				}
				else
				{
					_selected_groups.Remove(tAsset.id);
				}
			}, showSorted);
		}
		int num = 198 / AssetManager.history_groups.list.Count;
		_grid.cellSize = new Vector2(num, _grid.cellSize.y);
	}

	private void OnEnable()
	{
		clear();
		_messages = DBGetter.getWorldLogMessages();
		bool flag = _messages.Any();
		_no_items.SetActive(!flag);
		_grid.gameObject.SetActive(flag);
		if (flag)
		{
			showSorted();
		}
	}

	private void OnRenderObject()
	{
		_autolayout_done = true;
	}

	private void LateUpdate()
	{
		if (!_autolayout_done)
		{
			return;
		}
		IReadOnlyList<EmptyLogElement> listTotal = _pool_empty.getListTotal();
		int num = int.MaxValue;
		int num2 = int.MinValue;
		float y = _scroll_rect.content.localPosition.y;
		float pScrollRectTop = y + _scroll_rect.viewport.rect.height;
		for (int i = 0; i < listTotal.Count; i++)
		{
			EmptyLogElement emptyLogElement = listTotal[i];
			if (!emptyLogElement.gameObject.activeSelf)
			{
				continue;
			}
			if (IsVisibleInScrollRect(emptyLogElement.rect_transform, _scroll_rect, pScrollRectTop, y))
			{
				if (num == int.MaxValue)
				{
					num = i;
				}
				num2 = i;
			}
			else if (num2 > int.MinValue)
			{
				break;
			}
		}
		if (num2 == int.MaxValue || num == int.MinValue)
		{
			return;
		}
		int num3 = Math.Max(0, num - 3);
		int num4 = Math.Min(listTotal.Count - 1, num2 + 3);
		for (int j = 0; j < listTotal.Count; j++)
		{
			if (j < num3 || j > num4)
			{
				EmptyLogElement emptyLogElement2 = listTotal[j];
				WorldLogElement element = emptyLogElement2.getElement();
				if (!(element == null))
				{
					_pool.release(element);
					emptyLogElement2.setElement(null);
				}
			}
		}
		for (int k = num3; k <= num4; k++)
		{
			EmptyLogElement emptyLogElement3 = listTotal[k];
			if (emptyLogElement3.gameObject.activeSelf)
			{
				WorldLogElement element2 = emptyLogElement3.getElement();
				if (!(element2 != null))
				{
					element2 = _pool.getNext();
					emptyLogElement3.setElement(element2);
				}
			}
		}
	}

	private bool IsVisibleInScrollRect(RectTransform pRectTransform, ScrollRect pScrollRect, float pScrollRectTop, float pScrollRectBottom)
	{
		Vector2 vector = pRectTransform.localPosition;
		vector *= -1f;
		float num = pRectTransform.sizeDelta.y * 0.6f;
		if (vector.y <= pScrollRectTop + num + base.transform.localPosition.y)
		{
			return vector.y >= pScrollRectBottom - num + base.transform.localPosition.y;
		}
		return false;
	}

	private void showSorted()
	{
		StartCoroutine(showSortedRoutine());
	}

	private IEnumerator showSortedRoutine()
	{
		clear();
		using ListPool<WorldLogMessage> tSorted = new ListPool<WorldLogMessage>();
		if (_selected_groups.Count == 0)
		{
			tSorted.AddRange(_messages);
		}
		else
		{
			foreach (ref WorldLogMessage message in _messages)
			{
				WorldLogMessage current = message;
				WorldLogAsset asset = current.getAsset();
				if (!string.IsNullOrEmpty(asset.group) && _selected_groups.Contains(asset.group))
				{
					tSorted.Add(current);
				}
			}
		}
		tSorted.Sort(sortByTime);
		for (int i = 0; i < tSorted.Count; i++)
		{
			WorldLogMessage pMessage = tSorted[i];
			EmptyLogElement next = _pool_empty.getNext();
			next.load(pMessage);
			next.setElement(null);
			if (i % 20 == 0)
			{
				yield return null;
			}
		}
	}

	private int sortByTime(WorldLogMessage p1, WorldLogMessage p2)
	{
		return p2.timestamp.CompareTo(p1.timestamp);
	}

	private void OnDisable()
	{
		_messages?.Dispose();
		_messages = null;
	}

	private void clear()
	{
		_pool.clear();
		_pool_empty.clear();
	}
}
