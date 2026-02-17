using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;

public static class RectTransformExtensions
{
	public static ListPool<RectTransform> getLayoutChildren(this RectTransform pRect)
	{
		List<Component> list = CollectionPool<List<Component>, Component>.Get();
		ListPool<RectTransform> listPool = new ListPool<RectTransform>();
		int i = 0;
		for (int childCount = pRect.childCount; i < childCount; i++)
		{
			RectTransform rectTransform = pRect.GetChild(i) as RectTransform;
			if (rectTransform == null || !rectTransform.gameObject.activeInHierarchy)
			{
				continue;
			}
			if (!rectTransform.HasComponent<ILayoutIgnorer>())
			{
				listPool.Add(rectTransform);
				continue;
			}
			rectTransform.GetComponents(typeof(ILayoutIgnorer), list);
			if (list.Count == 0)
			{
				listPool.Add(rectTransform);
				continue;
			}
			for (int j = 0; j < list.Count; j++)
			{
				if (!((ILayoutIgnorer)list[j]).ignoreLayout)
				{
					listPool.Add(rectTransform);
					break;
				}
			}
			list.Clear();
		}
		CollectionPool<List<Component>, Component>.Release(list);
		return listPool;
	}

	public static void SetLeft(this RectTransform pRectTransform, float pLeft)
	{
		pRectTransform.offsetMin = new Vector2(pLeft, pRectTransform.offsetMin.y);
	}

	public static void SetRight(this RectTransform pRectTransform, float pRight)
	{
		pRectTransform.offsetMax = new Vector2(0f - pRight, pRectTransform.offsetMax.y);
	}

	public static void SetTop(this RectTransform pRectTransform, float pTop)
	{
		pRectTransform.offsetMax = new Vector2(pRectTransform.offsetMax.x, 0f - pTop);
	}

	public static void SetBottom(this RectTransform pRectTransform, float pBottom)
	{
		pRectTransform.offsetMin = new Vector2(pRectTransform.offsetMin.x, pBottom);
	}

	public static void SetAnchor(this RectTransform pSource, AnchorPresets pAlign, float pOffsetX = 0f, float pOffsetY = 0f)
	{
		pSource.anchoredPosition = new Vector3(pOffsetX, pOffsetY, 0f);
		switch (pAlign)
		{
		case AnchorPresets.TopLeft:
			pSource.anchorMin = new Vector2(0f, 1f);
			pSource.anchorMax = new Vector2(0f, 1f);
			break;
		case AnchorPresets.TopCenter:
			pSource.anchorMin = new Vector2(0.5f, 1f);
			pSource.anchorMax = new Vector2(0.5f, 1f);
			break;
		case AnchorPresets.TopRight:
			pSource.anchorMin = new Vector2(1f, 1f);
			pSource.anchorMax = new Vector2(1f, 1f);
			break;
		case AnchorPresets.MiddleLeft:
			pSource.anchorMin = new Vector2(0f, 0.5f);
			pSource.anchorMax = new Vector2(0f, 0.5f);
			break;
		case AnchorPresets.MiddleCenter:
			pSource.anchorMin = new Vector2(0.5f, 0.5f);
			pSource.anchorMax = new Vector2(0.5f, 0.5f);
			break;
		case AnchorPresets.MiddleRight:
			pSource.anchorMin = new Vector2(1f, 0.5f);
			pSource.anchorMax = new Vector2(1f, 0.5f);
			break;
		case AnchorPresets.BottomLeft:
			pSource.anchorMin = new Vector2(0f, 0f);
			pSource.anchorMax = new Vector2(0f, 0f);
			break;
		case AnchorPresets.BottonCenter:
			pSource.anchorMin = new Vector2(0.5f, 0f);
			pSource.anchorMax = new Vector2(0.5f, 0f);
			break;
		case AnchorPresets.BottomRight:
			pSource.anchorMin = new Vector2(1f, 0f);
			pSource.anchorMax = new Vector2(1f, 0f);
			break;
		case AnchorPresets.HorStretchTop:
			pSource.anchorMin = new Vector2(0f, 1f);
			pSource.anchorMax = new Vector2(1f, 1f);
			break;
		case AnchorPresets.HorStretchMiddle:
			pSource.anchorMin = new Vector2(0f, 0.5f);
			pSource.anchorMax = new Vector2(1f, 0.5f);
			break;
		case AnchorPresets.HorStretchBottom:
			pSource.anchorMin = new Vector2(0f, 0f);
			pSource.anchorMax = new Vector2(1f, 0f);
			break;
		case AnchorPresets.VertStretchLeft:
			pSource.anchorMin = new Vector2(0f, 0f);
			pSource.anchorMax = new Vector2(0f, 1f);
			break;
		case AnchorPresets.VertStretchCenter:
			pSource.anchorMin = new Vector2(0.5f, 0f);
			pSource.anchorMax = new Vector2(0.5f, 1f);
			break;
		case AnchorPresets.VertStretchRight:
			pSource.anchorMin = new Vector2(1f, 0f);
			pSource.anchorMax = new Vector2(1f, 1f);
			break;
		case AnchorPresets.StretchAll:
			pSource.anchorMin = new Vector2(0f, 0f);
			pSource.anchorMax = new Vector2(1f, 1f);
			break;
		case AnchorPresets.BottomStretch:
			break;
		}
	}

	public static void SetPivot(this RectTransform pSource, PivotPresets pPreset, bool pKeepPosition = false)
	{
		Vector2 vector = Vector2.zero;
		switch (pPreset)
		{
		case PivotPresets.TopLeft:
			vector = new Vector2(0f, 1f);
			break;
		case PivotPresets.TopCenter:
			vector = new Vector2(0.5f, 1f);
			break;
		case PivotPresets.TopRight:
			vector = new Vector2(1f, 1f);
			break;
		case PivotPresets.MiddleLeft:
			vector = new Vector2(0f, 0.5f);
			break;
		case PivotPresets.MiddleCenter:
			vector = new Vector2(0.5f, 0.5f);
			break;
		case PivotPresets.MiddleRight:
			vector = new Vector2(1f, 0.5f);
			break;
		case PivotPresets.BottomLeft:
			vector = new Vector2(0f, 0f);
			break;
		case PivotPresets.BottomCenter:
			vector = new Vector2(0.5f, 0f);
			break;
		case PivotPresets.BottomRight:
			vector = new Vector2(1f, 0f);
			break;
		}
		if (!pKeepPosition)
		{
			pSource.pivot = vector;
			return;
		}
		Vector3 vector2 = pSource.pivot - vector;
		vector2.Scale(pSource.rect.size);
		vector2.Scale(pSource.localScale);
		vector2 = pSource.rotation * vector2;
		pSource.pivot = vector;
		pSource.localPosition -= vector2;
	}

	public static Vector2 GetWorldCenter(this RectTransform pRectTransform)
	{
		return pRectTransform.TransformPoint(pRectTransform.rect.center);
	}

	public static Rect GetWorldRect(this RectTransform pRectTransform)
	{
		Rect rect = pRectTransform.rect;
		return new Rect
		{
			min = pRectTransform.TransformPoint(rect.min),
			max = pRectTransform.TransformPoint(rect.max)
		};
	}

	public static bool Overlaps(this RectTransform a, RectTransform b)
	{
		return a.WorldRect().Overlaps(b.WorldRect());
	}

	public static bool Overlaps(this RectTransform a, RectTransform b, bool allowInverse)
	{
		return a.WorldRect().Overlaps(b.WorldRect(), allowInverse);
	}

	public static Rect WorldRect(this RectTransform rectTransform)
	{
		Vector2 sizeDelta = rectTransform.sizeDelta;
		float num = sizeDelta.x * rectTransform.lossyScale.x;
		float num2 = sizeDelta.y * rectTransform.lossyScale.y;
		Vector3 vector = rectTransform.TransformPoint(rectTransform.rect.center);
		float x = vector.x - num * 0.5f;
		float y = vector.y - num2 * 0.5f;
		return new Rect(x, y, num, num2);
	}
}
