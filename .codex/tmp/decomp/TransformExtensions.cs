using System;
using UnityEngine;

public static class TransformExtensions
{
	public static Transform FindRecursive(this Transform pTransform, string pName)
	{
		return pTransform.FindRecursive((Transform tChild) => tChild.name == pName);
	}

	public static Transform FindRecursive(this Transform pTransform, Func<Transform, bool> pSelector)
	{
		foreach (Transform item in pTransform)
		{
			if (pSelector(item))
			{
				return item;
			}
			Transform transform2 = item.FindRecursive(pSelector);
			if (transform2 != null)
			{
				return transform2;
			}
		}
		return null;
	}

	public static T[] FindAllRecursive<T>(this Transform pTransform)
	{
		return pTransform.FindAllRecursive<T>((Transform p) => p.HasComponent<T>());
	}

	public static T[] FindAllRecursive<T>(this Transform pTransform, Func<Transform, bool> pSelector)
	{
		using ListPool<T> listPool = new ListPool<T>();
		foreach (Transform item in pTransform)
		{
			if (pSelector(item) && item.HasComponent<T>())
			{
				listPool.Add(item.GetComponent<T>());
			}
			T[] array = item.FindAllRecursive<T>(pSelector);
			if (array != null)
			{
				listPool.AddRange(array);
			}
		}
		return listPool.ToArray();
	}

	public static Transform FindParentWithName(this Transform pChildObject, params string[] pNames)
	{
		Transform transform = null;
		foreach (string pName in pNames)
		{
			transform = pChildObject.FindParentWithName(pName);
			if (transform != null)
			{
				break;
			}
		}
		return transform;
	}

	public static Transform FindParentWithName(this Transform pChildObject, string pName)
	{
		Transform transform = pChildObject;
		while (transform.parent != null)
		{
			if (transform.parent.gameObject.name == pName)
			{
				return transform.parent;
			}
			transform = transform.parent.transform;
		}
		return null;
	}

	public static int GetActiveSiblingIndex(this Transform pTransform)
	{
		int num = 0;
		Transform parent = pTransform.parent;
		int i = 0;
		for (int childCount = parent.childCount; i < childCount; i++)
		{
			Transform child = parent.GetChild(i);
			if (child.gameObject.activeSelf)
			{
				if (child == pTransform)
				{
					return num;
				}
				num++;
			}
		}
		return -1;
	}

	public static int CountActiveChildren(this Transform pTransform)
	{
		int num = 0;
		int i = 0;
		for (int childCount = pTransform.childCount; i < childCount; i++)
		{
			if (pTransform.GetChild(i).gameObject.activeSelf)
			{
				num++;
			}
		}
		return num;
	}

	public static int CountChildren(this Transform pTransform, Func<Transform, bool> pSelector)
	{
		int num = 0;
		int i = 0;
		for (int childCount = pTransform.childCount; i < childCount; i++)
		{
			if (pSelector(pTransform.GetChild(i)))
			{
				num++;
			}
		}
		return num;
	}
}
