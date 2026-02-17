using System.Collections.Generic;
using UnityEngine;

public class MagnetThrow
{
	private Vector2 _mouse_velocity = Vector2.zero;

	private Vector2 _last_mouse_position;

	private readonly List<Vector2> _velocity_samples = new List<Vector2>();

	private const int MAX_VELOCITY_SAMPLES = 5;

	private const float THROW_FORCE_MULTIPLIER = 5f;

	public const float MIN_THROW_FORCE = 0.1f;

	private const float MAX_THROW_FORCE = 10f;

	private Vector2 _throw_momentum = Vector2.zero;

	private const float MOMENTUM_DECAY = 0.85f;

	private const float MOMENTUM_BUILD_RATE = 0.7f;

	public void initializeMouseTracking()
	{
		_last_mouse_position = World.world.getMousePos();
		_velocity_samples.Clear();
		_throw_momentum = Vector2.zero;
	}

	public void trackMouseMovement(int pMagnetState)
	{
		if (pMagnetState == 1)
		{
			Vector2 mousePos = World.world.getMousePos();
			Vector2 vector = mousePos - _last_mouse_position;
			_mouse_velocity = vector * 60f;
			_velocity_samples.Add(_mouse_velocity);
			if (_velocity_samples.Count > 5)
			{
				_velocity_samples.RemoveAt(0);
			}
			Vector2 b = vector * 0.7f;
			_throw_momentum = Vector2.Lerp(_throw_momentum, b, Time.deltaTime * 10f);
			_last_mouse_position = mousePos;
		}
	}

	public Vector2 calculateThrowForce()
	{
		Vector2 zero = Vector2.zero;
		if (_velocity_samples.Count > 0)
		{
			foreach (Vector2 velocity_sample in _velocity_samples)
			{
				zero += velocity_sample;
			}
			zero /= (float)_velocity_samples.Count;
		}
		Vector2 result = zero * 5f * Time.deltaTime;
		float magnitude = result.magnitude;
		if (magnitude > 10f)
		{
			result = result.normalized * 10f;
		}
		else if (magnitude < 0.1f && magnitude > 0.1f)
		{
			result = result.normalized * 0.1f;
		}
		return result;
	}

	public void clear()
	{
		_velocity_samples.Clear();
		_throw_momentum = Vector2.zero;
	}
}
