using UnityEngine;

public class TouchCamera : MonoBehaviour
{
	private Vector2?[] oldTouchPositions = new Vector2?[2];

	private Vector2 oldTouchVector;

	private float oldTouchDistance;

	private Camera _camera;

	private const int orthographicSizeMin = 10;

	internal float orthographicSizeMax = 130f;

	private void Awake()
	{
		_camera = Camera.main;
	}

	private void Update()
	{
		if (Input.touchCount == 0)
		{
			oldTouchPositions[0] = null;
			oldTouchPositions[1] = null;
			return;
		}
		if (Input.touchCount == 1)
		{
			if (!oldTouchPositions[0].HasValue || oldTouchPositions[1].HasValue)
			{
				oldTouchPositions[0] = Input.GetTouch(0).position;
				oldTouchPositions[1] = null;
			}
			else
			{
				Vector2 position = Input.GetTouch(0).position;
				base.transform.position += base.transform.TransformDirection(((oldTouchPositions[0] - position) * _camera.orthographicSize / _camera.pixelHeight * 2f).Value);
				oldTouchPositions[0] = position;
			}
			return;
		}
		if (!oldTouchPositions[1].HasValue)
		{
			oldTouchPositions[0] = Input.GetTouch(0).position;
			oldTouchPositions[1] = Input.GetTouch(1).position;
			oldTouchVector = (oldTouchPositions[0] - oldTouchPositions[1]).Value;
			oldTouchDistance = oldTouchVector.magnitude;
			return;
		}
		Vector2 vector = new Vector2(_camera.pixelWidth, _camera.pixelHeight);
		Vector2[] array = new Vector2[2]
		{
			Input.GetTouch(0).position,
			Input.GetTouch(1).position
		};
		Vector2 vector2 = array[0] - array[1];
		float magnitude = vector2.magnitude;
		base.transform.position += base.transform.TransformDirection(((oldTouchPositions[0] + oldTouchPositions[1] - vector) * _camera.orthographicSize / vector.y).Value);
		_camera.orthographicSize = Mathf.Clamp(_camera.orthographicSize * (oldTouchDistance / magnitude), 10f, orthographicSizeMax);
		base.transform.position -= base.transform.TransformDirection((array[0] + array[1] - vector) * _camera.orthographicSize / vector.y);
		oldTouchPositions[0] = array[0];
		oldTouchPositions[1] = array[1];
		oldTouchVector = vector2;
		oldTouchDistance = magnitude;
	}
}
