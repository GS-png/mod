using System;
using UnityEngine;

public static class PixelDetector
{
	public static bool GetSpritePixelColorUnderMousePointer(MonoBehaviour mono, out Vector2Int pVector)
	{
		pVector = new Vector2Int(-1, -1);
		Vector2 vector = Input.mousePosition;
		Vector2 vector2 = Camera.main.ScreenToViewportPoint(vector);
		if (vector2.x <= 0f || vector2.x >= 1f || vector2.y <= 0f || vector2.y >= 1f)
		{
			return false;
		}
		Ray ray;
		try
		{
			ray = Camera.main.ViewportPointToRay(vector2);
		}
		catch (Exception)
		{
			return false;
		}
		return IntersectsSprite(mono, ray, out pVector);
	}

	private static bool IntersectsSprite(MonoBehaviour mono, Ray ray, out Vector2Int pVector)
	{
		SpriteRenderer component = mono.GetComponent<SpriteRenderer>();
		pVector = new Vector2Int(-1, -1);
		if (component == null)
		{
			return false;
		}
		Sprite sprite = component.sprite;
		if (sprite == null)
		{
			return false;
		}
		Texture2D texture = sprite.texture;
		if (texture == null)
		{
			return false;
		}
		if (sprite.packed && sprite.packingMode == SpritePackingMode.Tight)
		{
			Debug.LogError("SpritePackingMode.Tight atlas packing is not supported!");
			return false;
		}
		if (!new Plane(mono.transform.forward, mono.transform.position).Raycast(ray, out var enter))
		{
			return false;
		}
		Vector3 vector = component.worldToLocalMatrix.MultiplyPoint3x4(ray.origin + ray.direction * enter);
		Rect textureRect = sprite.textureRect;
		float pixelsPerUnit = sprite.pixelsPerUnit;
		float num = (float)texture.width * 0f;
		float num2 = (float)texture.height * 0f;
		int num3 = (int)(vector.x * pixelsPerUnit + num);
		int num4 = (int)(vector.y * pixelsPerUnit + num2);
		if (num3 < 0 || (float)num3 < textureRect.x || num3 >= Mathf.FloorToInt(textureRect.xMax))
		{
			return false;
		}
		if (num4 < 0 || (float)num4 < textureRect.y || num4 >= Mathf.FloorToInt(textureRect.yMax))
		{
			return false;
		}
		pVector = new Vector2Int(num3, num4);
		return true;
	}
}
