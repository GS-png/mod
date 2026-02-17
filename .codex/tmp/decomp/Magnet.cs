using System;
using System.Collections.Generic;
using UnityEngine;

public class Magnet
{
	private const float ANIMATED_SHRINK_SPEED = 0.3f;

	private const float PICKED_UP_SPEED_MULTIPLIER = 0.1f;

	private int _magnet_state;

	private WorldTile _magnet_last_pos;

	private bool _has_units;

	internal List<Actor> magnet_units = new List<Actor>();

	private HashSet<Actor> _magnet_units = new HashSet<Actor>();

	private float _picked_up_multiplier = 1f;

	private float _angle;

	public float moving_angle;

	private MagnetThrow _magnet_throw = new MagnetThrow();

	private float _target_angle;

	private float _current_angle;

	private float _rotation_velocity;

	internal void magnetAction(bool pFromUpdate, WorldTile pTile = null)
	{
		if (ScrollWindow.isWindowActive())
		{
			dropPickedUnits();
		}
		else
		{
			if (pFromUpdate && _magnet_state != 1 && _magnet_state != 3)
			{
				return;
			}
			if (pTile != null)
			{
				_magnet_last_pos = pTile;
			}
			_magnet_throw.trackMouseMovement(_magnet_state);
			updatePickedUnits();
			if (pTile != null)
			{
				World.world.flash_effects.flashPixel(pTile, 10);
			}
			switch (_magnet_state)
			{
			case 0:
				if (Input.GetMouseButton(0))
				{
					_magnet_state = 1;
					_magnet_throw.initializeMouseTracking();
				}
				break;
			case 1:
				if (!pFromUpdate)
				{
					pickupUnits(pTile);
				}
				if (Input.GetMouseButtonUp(0))
				{
					_magnet_state = 2;
					dropPickedUnits();
				}
				break;
			case 2:
				if (!pFromUpdate && Input.GetMouseButton(0))
				{
					dropPickedUnits();
					_magnet_state = 0;
				}
				break;
			}
		}
	}

	public void dropPickedUnits()
	{
		if (magnet_units.Count == 0)
		{
			return;
		}
		Vector2 vector = _magnet_throw.calculateThrowForce();
		for (int i = 0; i < magnet_units.Count; i++)
		{
			Actor actor = magnet_units[i];
			if (actor != null && actor.isAlive())
			{
				actor.current_position.y -= actor.position_height;
				actor.is_in_magnet = false;
				actor.dirty_current_tile = true;
				actor.findCurrentTile();
				actor.spawnOn(actor.current_tile, actor.getActorAsset().default_height);
				actor.makeStunned(1f);
				actor.addStatusEffect("magnetized");
				actor.target_angle.z = 0f;
				if (vector.magnitude > 0.1f)
				{
					Vector2 vector2 = vector;
					vector2.x += UnityEngine.Random.Range(-0.3f, 0.3f);
					vector2.y += UnityEngine.Random.Range(-0.3f, 0.3f);
					actor.addForce(vector2.x, vector2.y, vector2.magnitude * 0.3f, pCheckLandCancelAllActions: true, pIgnorePosHeight: true);
				}
				else
				{
					actor.addForce(0f, 0f, 0.1f, pCheckLandCancelAllActions: true);
				}
				actor.addActionWaitAfterLand(0.5f);
			}
		}
		magnet_units.Clear();
		_magnet_units.Clear();
		_has_units = false;
		_magnet_throw.clear();
	}

	private void updatePickedUnits()
	{
		if (_magnet_last_pos == null || magnet_units.Count == 0)
		{
			return;
		}
		updateMovingForce();
		if (_picked_up_multiplier > 0.1f)
		{
			_picked_up_multiplier -= World.world.delta_time * 0.3f;
			if (_picked_up_multiplier < 0.1f)
			{
				_picked_up_multiplier = 0.1f;
			}
		}
		float num = magnet_units.Count;
		float num2 = 6f;
		if (num > 100f)
		{
			num2 = 4f;
		}
		else if (num > 50f)
		{
			num2 = 4.5f;
		}
		else if (num > 5f)
		{
			num2 = 5f;
		}
		float num3 = MathF.PI * 2f / num2;
		int num4 = Config.current_brush_data.width + 1;
		float num5 = ((0 == 0) ? ((float)num4 / 2f) : (Mathf.Lerp(0f, num4, _picked_up_multiplier) / 2f));
		float num6 = 1f / num * num5;
		_angle += num3 * Time.deltaTime;
		Vector2 mousePos = World.world.getMousePos();
		for (int i = 0; (float)i < num; i++)
		{
			Actor actor = magnet_units[i];
			if (actor != null && actor.isAlive())
			{
				actor.findCurrentTile();
				Vector3 vector = mousePos;
				vector.x += Mathf.Cos(_angle + (float)i) * (num6 * (float)i);
				vector.y += Mathf.Sin(_angle + (float)i) * (num6 * (float)i);
				actor.current_position = new Vector2(vector.x, vector.y - actor.position_height);
				actor.callbacks_magnet_update?.Invoke(actor);
			}
		}
	}

	private void updateMovingForce()
	{
		Vector2 vector = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")) * 3f;
		if (vector.magnitude > 0.1f)
		{
			_target_angle = Mathf.Atan2(vector.y, vector.x) * 57.29578f;
			_target_angle -= 90f;
		}
		else
		{
			_target_angle = 0f;
		}
		_current_angle = Mathf.SmoothDampAngle(_current_angle, _target_angle, ref _rotation_velocity, 0.2f);
		moving_angle = _current_angle;
	}

	private void pickupUnits(WorldTile pTile)
	{
		BrushPixelData[] pos = Config.current_brush_data.pos;
		for (int i = 0; i < pos.Length; i++)
		{
			WorldTile tile = World.world.GetTile(pos[i].x + pTile.x, pos[i].y + pTile.y);
			if (tile == null || !tile.hasUnits())
			{
				continue;
			}
			tile.doUnits(delegate(Actor tActor)
			{
				if (tActor.asset.can_be_moved_by_powers && !tActor.isInsideSomething() && _magnet_units.Add(tActor))
				{
					tActor.cancelAllBeh();
					magnet_units.Add(tActor);
					tActor.is_in_magnet = true;
					_picked_up_multiplier = 2f;
				}
			});
		}
		_has_units = _magnet_units.Count > 0;
	}

	public int countUnits()
	{
		return _magnet_units.Count;
	}

	public bool hasUnits()
	{
		return _has_units;
	}
}
