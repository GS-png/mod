using System;
using System.Collections.Generic;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;

namespace LayoutGroupExt;

[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public abstract class LayoutGroupExtended : LayoutGroup
{
	[SerializeField]
	public float moveDuration = 0.15f;

	[Tooltip("Will position the n items immediately, animating the next ones.")]
	[SerializeField]
	public int delayItems = 1;

	private Dictionary<RectTransform, TweenerCore<Vector2, Vector2, VectorOptions>> RectPositionXTweens = new Dictionary<RectTransform, TweenerCore<Vector2, Vector2, VectorOptions>>();

	private Dictionary<RectTransform, TweenerCore<Vector2, Vector2, VectorOptions>> RectPositionYTweens = new Dictionary<RectTransform, TweenerCore<Vector2, Vector2, VectorOptions>>();

	private static List<RectTransform> _to_remove = new List<RectTransform>();

	internal List<RectTransform> m_Children = new List<RectTransform>();

	internal Dictionary<int, List<RectTransform>> m_Axis = new Dictionary<int, List<RectTransform>>
	{
		{
			0,
			new List<RectTransform>()
		},
		{
			1,
			new List<RectTransform>()
		}
	};

	internal Vector2[] m_Positions = new Vector2[0];

	internal RectTransform[] m_Sort = new RectTransform[0];

	internal Dictionary<RectTransform, Vector2> m_Grid_Positions = new Dictionary<RectTransform, Vector2>();

	internal Dictionary<RectTransform, Vector2> m_Grid_Anchors = new Dictionary<RectTransform, Vector2>();

	private int _skip_frame = -1;

	private static RectTransform _highlighter_prefab;

	private ObjectPoolGenericMono<RectTransform> _pool_highlighter;

	protected new void SetChildAlongAxis(RectTransform rect, int axis, float pos)
	{
		if (!(rect == null))
		{
			SetChildAlongAxisWithScale(rect, axis, pos, 1f);
		}
	}

	public override void CalculateLayoutInputHorizontal()
	{
		if (_skip_frame == Time.frameCount)
		{
			SetDirty();
			return;
		}
		bool flag = base.rectChildren.Count == 0;
		base.rectChildren.Clear();
		List<Component> list = CollectionPool<List<Component>, Component>.Get();
		for (int i = 0; i < base.rectTransform.childCount; i++)
		{
			if (Application.isPlaying && flag && base.rectChildren.Count == delayItems)
			{
				_skip_frame = Time.frameCount;
				SetDirty();
				break;
			}
			RectTransform rectTransform = base.rectTransform.GetChild(i) as RectTransform;
			if (rectTransform == null || !rectTransform.gameObject.activeInHierarchy)
			{
				continue;
			}
			rectTransform.GetComponents(typeof(ILayoutIgnorer), list);
			if (list.Count == 0)
			{
				base.rectChildren.Add(rectTransform);
				continue;
			}
			foreach (ILayoutIgnorer item in list)
			{
				if (!item.ignoreLayout && ((MonoBehaviour)item).enabled)
				{
					base.rectChildren.Add(rectTransform);
					break;
				}
			}
		}
		CollectionPool<List<Component>, Component>.Release(list);
		m_Tracker.Clear();
	}

	protected new void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor)
	{
		if (!(rect == null))
		{
			m_Tracker.Add(this, rect, (DrivenTransformProperties)(0xF00 | ((axis == 0) ? 2 : 4)));
			rect.anchorMin = Vector2.up;
			rect.anchorMax = Vector2.up;
			if (!m_Grid_Anchors.TryGetValue(rect, out var value) || !Application.isPlaying)
			{
				value = rect.anchoredPosition;
				m_Grid_Anchors[rect] = value;
			}
			value[axis] = ((axis == 0) ? (pos + rect.sizeDelta[axis] * rect.pivot[axis] * scaleFactor) : (0f - pos - rect.sizeDelta[axis] * (1f - rect.pivot[axis]) * scaleFactor));
			SetPosition(rect, value, axis);
		}
	}

	protected new void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size)
	{
		if (!(rect == null))
		{
			SetChildAlongAxisWithScale(rect, axis, pos, size, 1f);
		}
	}

	protected new void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor)
	{
		if (!(rect == null))
		{
			m_Tracker.Add(this, rect, (DrivenTransformProperties)(0xF00 | ((axis == 0) ? 4098 : 8196)));
			rect.anchorMin = Vector2.up;
			rect.anchorMax = Vector2.up;
			Vector2 sizeDelta = rect.sizeDelta;
			sizeDelta[axis] = size;
			rect.sizeDelta = sizeDelta;
			if (!m_Grid_Anchors.TryGetValue(rect, out var value) || !Application.isPlaying)
			{
				value = rect.anchoredPosition;
				m_Grid_Anchors[rect] = value;
			}
			value[axis] = ((axis == 0) ? (pos + size * rect.pivot[axis] * scaleFactor) : (0f - pos - size * (1f - rect.pivot[axis]) * scaleFactor));
			SetPosition(rect, value, axis);
		}
	}

	public void SetPosition(RectTransform rect, Vector2 pos, int axis)
	{
		if (!Application.isPlaying)
		{
			rect.anchoredPosition = pos;
			return;
		}
		if (!m_Axis[axis].Contains(rect))
		{
			if (m_Axis[axis].Count >= delayItems)
			{
				Vector2 vector = Vector2.zero;
				float num = float.MaxValue;
				for (int num2 = m_Axis[axis].Count - 1; num2 >= 0; num2--)
				{
					Vector2 vector2 = m_Axis[axis][num2].anchoredPosition;
					if (vector2 == Vector2.zero)
					{
						vector2 = m_Grid_Anchors[m_Axis[axis][num2]];
					}
					float num3 = Vector2.Distance(vector2, pos);
					if (num3 < num)
					{
						num = num3;
						vector = vector2;
					}
				}
				Vector2 vector3 = vector - pos;
				if (Mathf.Abs(vector3.y) > Mathf.Abs(vector3.x))
				{
					rect.anchoredPosition = vector + new Vector2(0f, 1f);
				}
				else
				{
					rect.anchoredPosition = vector - new Vector2(1f, 0f);
				}
			}
			else
			{
				rect.anchoredPosition = pos;
			}
			m_Axis[axis].Add(rect);
			if (!m_Children.Contains(rect))
			{
				m_Children.Add(rect);
			}
		}
		m_Grid_Anchors[rect] = pos;
		Vector2 anchoredPosition = rect.anchoredPosition;
		rect.anchoredPosition = pos;
		m_Grid_Positions[rect] = rect.position;
		rect.anchoredPosition = anchoredPosition;
		if (m_Children.Count != m_Positions.Length)
		{
			m_Positions = new Vector2[m_Children.Count];
			m_Sort = new RectTransform[m_Children.Count];
		}
		m_Children.Sort((RectTransform a, RectTransform b) => a.GetSiblingIndex().CompareTo(b.GetSiblingIndex()));
		for (int num4 = 0; num4 < m_Children.Count; num4++)
		{
			Vector2 vector4 = m_Grid_Positions[m_Children[num4]];
			m_Positions[num4] = vector4;
			m_Sort[num4] = m_Children[num4];
		}
		Dictionary<RectTransform, TweenerCore<Vector2, Vector2, VectorOptions>> dict;
		TweenerCore<Vector2, Vector2, VectorOptions> tween;
		switch (axis)
		{
		default:
			return;
		case 0:
		{
			dict = RectPositionXTweens;
			if (dict.TryGetValue(rect, out var value2) && value2.IsActive())
			{
				if (Mathf.Approximately(value2.endValue.x, pos.x))
				{
					return;
				}
				value2.Kill();
			}
			if (Mathf.Approximately(rect.anchoredPosition.x, pos.x))
			{
				return;
			}
			tween = rect.DOAnchorPosX(pos.x, moveDuration);
			break;
		}
		case 1:
		{
			dict = RectPositionYTweens;
			if (dict.TryGetValue(rect, out var value) && value.IsActive())
			{
				if (Mathf.Approximately(value.endValue.y, pos.y))
				{
					return;
				}
				value.Kill();
			}
			if (Mathf.Approximately(rect.anchoredPosition.y, pos.y))
			{
				return;
			}
			tween = rect.DOAnchorPosY(pos.y, moveDuration);
			break;
		}
		}
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = tween;
		tweenerCore.onKill = (TweenCallback)Delegate.Combine(tweenerCore.onKill, (TweenCallback)delegate
		{
			if (dict.ContainsKey(rect) && dict[rect] == tween)
			{
				dict.Remove(rect);
			}
		});
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = tween;
		tweenerCore2.onComplete = (TweenCallback)Delegate.Combine(tweenerCore2.onComplete, (TweenCallback)delegate
		{
			LayoutRebuilder.MarkLayoutForRebuild(base.rectTransform);
			dict.Remove(rect);
		});
		dict[rect] = tween;
	}

	protected override void OnEnable()
	{
		base.OnEnable();
		ScrollWindow.addCallbackShow(setDirty);
		ScrollWindow.addCallbackShowFinished(setDirty);
	}

	protected override void OnDisable()
	{
		base.OnDisable();
		ScrollWindow.removeCallbackShow(setDirty);
		ScrollWindow.removeCallbackShowFinished(setDirty);
		_skip_frame = -1;
		m_Axis[0].Clear();
		m_Axis[1].Clear();
		m_Children.Clear();
		m_Grid_Positions.Clear();
		m_Grid_Anchors.Clear();
		base.rectChildren.Clear();
		using ListPool<TweenerCore<Vector2, Vector2, VectorOptions>> listPool = new ListPool<TweenerCore<Vector2, Vector2, VectorOptions>>(RectPositionXTweens.Count + RectPositionYTweens.Count);
		listPool.AddRange(RectPositionXTweens.Values);
		listPool.AddRange(RectPositionYTweens.Values);
		RectPositionXTweens.Clear();
		RectPositionYTweens.Clear();
		foreach (ref TweenerCore<Vector2, Vector2, VectorOptions> item in listPool)
		{
			item.Kill();
		}
	}

	private void LateUpdate()
	{
		foreach (RectTransform child in m_Children)
		{
			if (!base.rectChildren.Contains(child) || !child.gameObject.activeInHierarchy)
			{
				_to_remove.Add(child);
			}
		}
		foreach (RectTransform item in _to_remove)
		{
			m_Children.Remove(item);
			m_Axis[0].Remove(item);
			m_Axis[1].Remove(item);
			m_Grid_Positions.Remove(item);
			m_Grid_Anchors.Remove(item);
		}
		_to_remove.Clear();
	}

	private void setDirty(string pWindowName)
	{
		SetDirty();
	}

	private void DebugInit()
	{
		if (_highlighter_prefab == null)
		{
			_highlighter_prefab = UnityEngine.Object.Instantiate(Resources.Load<RectTransform>("ui/selector"));
		}
		if (_pool_highlighter == null)
		{
			_pool_highlighter = new ObjectPoolGenericMono<RectTransform>(_highlighter_prefab, base.transform);
		}
		_pool_highlighter.clear();
	}

	protected virtual void Update()
	{
		if (!Application.isPlaying)
		{
			return;
		}
		if (!DebugConfig.isOn(DebugOption.ShowLayoutGroupGrid))
		{
			_pool_highlighter?.clear();
			return;
		}
		DebugInit();
		for (int i = 0; i < m_Positions.Length; i++)
		{
			Vector2 vector = m_Positions[i];
			RectTransform next = _pool_highlighter.getNext();
			next.localScale = m_Children[0].localScale;
			next.GetChild(0).GetComponent<Image>().color = new Color(1f, 0f, 0f, 0.25f);
			GameObject obj = next.gameObject;
			string text = i.ToString();
			Vector2 vector2 = vector;
			obj.name = "m_positions " + text + " " + vector2.ToString();
			next.position = vector;
		}
		for (int j = 0; j < m_Sort.Length; j++)
		{
			RectTransform key = m_Sort[j];
			Vector2 vector3 = m_Grid_Anchors[key];
			RectTransform next2 = _pool_highlighter.getNext();
			next2.localScale = m_Children[0].localScale;
			next2.GetChild(0).GetComponent<Image>().color = new Color(0f, 1f, 0f, 0.25f);
			GameObject obj2 = next2.gameObject;
			string text2 = j.ToString();
			Vector2 vector2 = vector3;
			obj2.name = "m_Grid_Anchors " + text2 + " " + vector2.ToString();
			next2.anchoredPosition = vector3;
		}
		for (int k = 0; k < m_Sort.Length; k++)
		{
			RectTransform key2 = m_Sort[k];
			Vector2 vector4 = m_Grid_Positions[key2];
			RectTransform next3 = _pool_highlighter.getNext();
			next3.localScale = m_Children[0].localScale;
			next3.GetChild(0).GetComponent<Image>().color = new Color(0f, 0f, 1f, 0.25f);
			GameObject obj3 = next3.gameObject;
			string text3 = k.ToString();
			Vector2 vector2 = vector4;
			obj3.name = "m_Grid_Positions " + text3 + " " + vector2.ToString();
			next3.position = vector4;
		}
	}
}
