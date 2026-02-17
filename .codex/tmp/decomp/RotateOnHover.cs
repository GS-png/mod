using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateOnHover : MonoBehaviour
{
	private const float TILT_ANGLE = 60f;

	private const float TILT_SPEED = 15f;

	public List<Shadow> shadows;

	private bool _is_hovering;

	private Vector3 _original_rotation;

	private Vector2 _original_pivot;

	private List<Vector2> _original_shadows;

	private RectTransform _rect_transform;

	private void Awake()
	{
		_rect_transform = GetComponent<RectTransform>();
		_original_rotation = _rect_transform.eulerAngles;
		_original_pivot = _rect_transform.pivot;
		_original_shadows = new List<Vector2>();
		foreach (Shadow shadow in shadows)
		{
			_original_shadows.Add(shadow.effectDistance);
		}
	}

	private void Start()
	{
		Button componentInParent = GetComponentInParent<Button>();
		if (!(componentInParent == null))
		{
			componentInParent.OnHover(delegate
			{
				_is_hovering = true;
			});
			componentInParent.OnHoverOut(delegate
			{
				_is_hovering = false;
			});
		}
	}

	private void OnEnable()
	{
		_is_hovering = false;
		_rect_transform.eulerAngles = _original_rotation;
		_rect_transform.pivot = _original_pivot;
		for (int i = 0; i < shadows.Count; i++)
		{
			shadows[i].effectDistance = _original_shadows[i];
		}
	}

	private void OnDisable()
	{
		_is_hovering = false;
		_rect_transform.eulerAngles = Vector3.zero;
	}

	private void Update()
	{
		if (!_is_hovering)
		{
			float t = 15f * Time.deltaTime * 0.5f;
			_rect_transform.pivot = Vector2.Lerp(_rect_transform.pivot, _original_pivot, t);
			for (int i = 0; i < shadows.Count; i++)
			{
				shadows[i].effectDistance = Vector2.Lerp(shadows[i].effectDistance, _original_shadows[i], t);
			}
			_rect_transform.rotation = Quaternion.Lerp(_rect_transform.rotation, Quaternion.Euler(_original_rotation), t);
			return;
		}
		Vector2 vector = _rect_transform.InverseTransformPoint(Input.mousePosition);
		float num = Mathf.Clamp(vector.x / _rect_transform.rect.width, -0.5f, 0.5f);
		float num2 = Mathf.Clamp(vector.y / _rect_transform.rect.height, -0.5f, 0.5f);
		Vector3 euler = new Vector3(_original_rotation.x - num2 * 60f, _original_rotation.y + num * 60f, _original_rotation.z);
		Vector2 effectDistance = new Vector2(num * 4f, num2 * 4f);
		foreach (Shadow shadow in shadows)
		{
			shadow.effectDistance = effectDistance;
		}
		_rect_transform.pivot = new Vector2(_original_pivot.x - num * 0.1f, _original_pivot.y - num2 * 0.1f);
		_rect_transform.rotation = Quaternion.Lerp(_rect_transform.rotation, Quaternion.Euler(euler), 15f * Time.deltaTime);
	}
}
