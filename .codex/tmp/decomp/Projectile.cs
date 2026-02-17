using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Projectile : CoreSystemObject<ProjectileData>
{
	internal readonly BaseStats stats = new BaseStats();

	private BaseSimObject by_who;

	private BaseSimObject _main_target;

	private long _main_target_id;

	internal Kingdom kingdom;

	private Action _kill_action;

	public ProjectileAsset asset;

	private Vector2 _vector_start;

	private Vector2 _vector_target;

	private float _current_scale;

	private float _target_scale;

	private bool _is_target_reached;

	private Vector3 _current_position_3d;

	private float _angle_horizontal;

	private float _angle_vertical;

	private float _timer_smoke;

	private float _dead_alpha;

	private ProjectileState _state;

	private float _collision_timeout;

	private Vector3 _velocity;

	public Quaternion rotation;

	private float _speed;

	public override BaseSystemManager manager => World.world.projectiles;

	protected sealed override void setDefaultValues()
	{
		base.setDefaultValues();
		_current_scale = 0f;
		_target_scale = 0f;
		_is_target_reached = false;
		_angle_horizontal = 0f;
		_angle_vertical = 0f;
		_timer_smoke = 0f;
		_dead_alpha = 1f;
		_state = ProjectileState.Active;
		_collision_timeout = 0f;
		_speed = 0f;
	}

	public Vector2 getStartVector()
	{
		return _vector_start;
	}

	public Vector2 getTargetVector()
	{
		return _vector_target;
	}

	public void start(BaseSimObject pInitiator, BaseSimObject pTargetObject, Vector3 pLaunchPosition, Vector3 pTargetPosition, string pAssetID, float pTargetPosZ = 0f, float pStartZ = 0.25f, float pForce = 0f, Action pKillAction = null, Kingdom pForcedKingdom = null)
	{
		_kill_action = pKillAction;
		by_who = pInitiator;
		_main_target = pTargetObject;
		if (_main_target != null)
		{
			_main_target_id = _main_target.id;
		}
		if (by_who != null)
		{
			setStats(pInitiator.stats);
			kingdom = by_who.kingdom;
		}
		if (pForcedKingdom != null)
		{
			kingdom = pForcedKingdom;
		}
		asset = AssetManager.projectiles.get(pAssetID);
		_speed = asset.speed + Randy.randomFloat(0f, asset.speed_random);
		if (pForce != 0f)
		{
			_speed = pForce;
		}
		Vector3 current_position_3d = new Vector3(pLaunchPosition.x, pLaunchPosition.y, 0f);
		current_position_3d.z = pStartZ;
		_current_position_3d = current_position_3d;
		calculateAngles(pLaunchPosition, pTargetPosition, current_position_3d.z, pTargetPosZ);
		calculateVelocities();
		if (asset.frames == null || asset.frames.Length == 0)
		{
			asset.frames = SpriteTextureLoader.getSpriteList("effects/projectiles/" + asset.texture);
		}
		if (asset.sound_launch != string.Empty)
		{
			MusicBox.playSound(asset.sound_launch, pLaunchPosition.x, pLaunchPosition.y, pGameViewOnly: true);
		}
		_current_scale = asset.scale_start;
		_target_scale = asset.scale_target;
		_is_target_reached = false;
		_dead_alpha = 1f;
		setState(ProjectileState.Active);
	}

	private void calculateAngles(Vector3 pStart, Vector3 pTarget, float pStartZ, float pTargetZ)
	{
		_vector_start = pStart;
		_vector_target = pTarget;
		_angle_horizontal = getHorizontalLaunchAngle(pStart, pTarget);
		_angle_vertical = getVerticalLaunchAngle(pStart, pTarget, _speed, pStartZ, pTargetZ);
	}

	private void calculateVelocities()
	{
		float num = _speed / asset.mass;
		_velocity.x = num * Mathf.Cos(_angle_vertical) * Mathf.Cos(_angle_horizontal);
		_velocity.y = num * Mathf.Cos(_angle_vertical) * Mathf.Sin(_angle_horizontal);
		_velocity.z = num * Mathf.Sin(_angle_vertical);
	}

	private float getVerticalLaunchAngle(Vector3 pStart, Vector3 pTarget, float pForce, float pStartHeight, float pTargetHeight)
	{
		float gravity = SimGlobals.m.gravity;
		float num = Toolbox.DistVec3(pStart, pTarget);
		float num2 = pTargetHeight - pStartHeight;
		float num3 = pForce / asset.mass;
		float num4 = num3 * num3;
		float num5 = Mathf.Pow(num3, 4f);
		float num6 = gravity * (gravity * num * num + 2f * num2 * num4);
		if (num6 > num5)
		{
			return MathF.PI / 4f;
		}
		float num7 = Mathf.Sqrt(num5 - num6);
		float num8 = Mathf.Atan((num4 + num7) / (SimGlobals.m.gravity * num));
		float num9 = Mathf.Atan((num4 - num7) / (SimGlobals.m.gravity * num));
		float num10 = 2f * num3 * Mathf.Sin(num8) / gravity;
		float num11 = 2f * num3 * Mathf.Sin(num9) / gravity;
		if (asset.use_min_angle_height)
		{
			return (num10 < num11) ? num8 : num9;
		}
		if (num8 > num9)
		{
			return num8;
		}
		return num9;
	}

	private float getHorizontalLaunchAngle(Vector3 pStart, Vector3 pTarget)
	{
		return Mathf.Atan2(pTarget.y - pStart.y, pTarget.x - pStart.x);
	}

	private void updateVelocity(float pElapsed)
	{
		_velocity.z -= SimGlobals.m.gravity * pElapsed;
		Vector3 current_position_3d = _current_position_3d + _velocity * pElapsed;
		_current_position_3d = current_position_3d;
		float angle = Mathf.Atan2(_velocity.y + _velocity.z, _velocity.x) * 57.29578f;
		rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		if (_current_position_3d.z <= 0f)
		{
			_velocity.Set(0f, 0f, 0f);
			_current_position_3d.z = 0f;
		}
		if (_collision_timeout != 0f && _current_position_3d.z != 0f)
		{
			return;
		}
		AttackDataResult pDataResult = checkHitOnNearbyUnits();
		switch (pDataResult.state)
		{
		case ApplyAttackState.Deflect:
			getDeflected(_vector_start, pDataResult);
			return;
		case ApplyAttackState.Block:
			getCollided(_vector_target);
			return;
		case ApplyAttackState.Hit:
			setState(ProjectileState.ToRemove);
			_kill_action?.Invoke();
			targetReached();
			return;
		case ApplyAttackState.Continue:
			return;
		}
		EffectsLibrary.spawnAt("fx_miss", _current_position_3d, 0.1f);
		if (asset.can_be_left_on_ground)
		{
			setState(ProjectileState.AlphaAnimation);
		}
		else
		{
			setState(ProjectileState.ToRemove);
		}
		targetReached();
	}

	private bool isOnGround()
	{
		return _current_position_3d.z <= 0f;
	}

	private AttackDataResult checkHitOnNearbyUnits()
	{
		if (_is_target_reached)
		{
			return AttackDataResult.Continue;
		}
		WorldTile tile = World.world.GetTile((int)_current_position_3d.x, (int)_current_position_3d.y);
		if (tile == null)
		{
			if (isOnGround())
			{
				return AttackDataResult.Miss;
			}
			return AttackDataResult.Continue;
		}
		if (by_who.isRekt())
		{
			return AttackDataResult.Miss;
		}
		EnemyFinderData enemyFinderData = EnemiesFinder.findEnemiesFrom(tile, kingdom);
		bool num = isMainTargetStillValid();
		if (!num)
		{
			_main_target = null;
			_main_target_id = -1L;
		}
		if (num && !enemyFinderData.list.Contains(_main_target))
		{
			enemyFinderData.list.Add(_main_target);
		}
		if (enemyFinderData.isEmpty())
		{
			if (isOnGround())
			{
				return AttackDataResult.Miss;
			}
			return AttackDataResult.Continue;
		}
		Vector3 vector = by_who.current_position;
		BaseSimObject pInitiator = by_who;
		Kingdom pKingdom = kingdom;
		Vector3 pInitiatorPosition = vector;
		AttackData pData = new AttackData(pInitiator, tile, _current_position_3d, pInitiatorPosition, null, pKingdom, AttackType.Weapon, pMetallicWeapon: false, pSkipShake: false, pProjectile: true, asset.id);
		if (isOnGround())
		{
			AttackDataResult result = MapBox.newAttack(pData);
			if (result.state == ApplyAttackState.Continue)
			{
				result.state = ApplyAttackState.Miss;
			}
			return result;
		}
		foreach (BaseSimObject item in enemyFinderData.list.LoopRandom())
		{
			AttackDataResult result2 = checkHitForUnit(item, pData);
			ApplyAttackState state = result2.state;
			if (state == ApplyAttackState.Hit || (uint)(state - 2) <= 1u)
			{
				return result2;
			}
		}
		return AttackDataResult.Continue;
	}

	private bool isMainTargetStillValid()
	{
		if (_main_target.isRekt())
		{
			return false;
		}
		if (_main_target.id != _main_target_id)
		{
			return false;
		}
		return true;
	}

	private AttackDataResult checkHitForUnit(BaseSimObject pObject, AttackData pData)
	{
		if (pObject == null)
		{
			return AttackDataResult.Continue;
		}
		if (!pObject.isAlive())
		{
			return AttackDataResult.Continue;
		}
		float z = _current_position_3d.z;
		float height = pObject.getHeight();
		if (Mathf.Abs(z - height) > 3f)
		{
			return AttackDataResult.Continue;
		}
		Vector3 vector = pObject.current_position;
		Vector3 current_position_3d = _current_position_3d;
		float num = Toolbox.Dist(current_position_3d.x, current_position_3d.y + current_position_3d.z, vector.x, vector.y + pObject.getHeight());
		float num2 = asset.size + pObject.stats["size"];
		if (num > num2)
		{
			return AttackDataResult.Continue;
		}
		return MapBox.checkAttackFor(pData, pObject);
	}

	public void setStats(BaseStats pStats)
	{
		stats.clear();
		stats.mergeStats(pStats);
	}

	public float getLaunchAngle()
	{
		return Mathf.Atan2(_velocity.y + _velocity.z, _velocity.x) * 57.29578f;
	}

	private void updateScaleEffect(float pElapsed)
	{
		if (_current_scale < _target_scale)
		{
			_current_scale += pElapsed * 0.2f;
			if (_current_scale > _target_scale)
			{
				_current_scale = _target_scale;
			}
		}
	}

	private void updateTrailEffect(float pElapsed)
	{
		if (!asset.trail_effect_enabled)
		{
			return;
		}
		if (_timer_smoke > 0f)
		{
			_timer_smoke -= pElapsed;
			return;
		}
		BaseEffect baseEffect = EffectsLibrary.spawnAt(pPos: new Vector3(_current_position_3d.x, _current_position_3d.y + _current_position_3d.z, 0f), pID: asset.trail_effect_id, pScale: asset.trail_effect_scale);
		if (asset.look_at_target && baseEffect != null)
		{
			baseEffect.transform.rotation = rotation;
		}
		_timer_smoke = asset.trail_effect_timer;
	}

	public void update(float pElapsed)
	{
		if (_collision_timeout > 0f)
		{
			_collision_timeout -= pElapsed;
			if (_collision_timeout < 0f)
			{
				_collision_timeout = 0f;
			}
		}
		switch (_state)
		{
		case ProjectileState.Active:
			updateVelocity(pElapsed);
			break;
		case ProjectileState.AlphaAnimation:
			updateDeadAnimation(pElapsed);
			break;
		}
		updateScaleEffect(pElapsed);
		updateTrailEffect(pElapsed);
		updateLightEffect(pElapsed);
	}

	private void updateLightEffect(float pElapsed)
	{
		if (asset.draw_light_area)
		{
			Vector2 position = new Vector2(_current_position_3d.x, _current_position_3d.y + _current_position_3d.z);
			position.x += asset.draw_light_area_offset_x;
			position.y += asset.draw_light_area_offset_y;
			World.world.stack_effects.light_blobs.Add(new LightBlobData
			{
				position = position,
				radius = asset.draw_light_size
			});
		}
	}

	private void updateDeadAnimation(float pElapsed)
	{
		_dead_alpha -= pElapsed * 0.5f;
		if (_dead_alpha < 0f)
		{
			setState(ProjectileState.ToRemove);
		}
	}

	private void targetReached()
	{
		_is_target_reached = true;
		WorldTile worldTile = getCurrentTilePosition();
		if (worldTile == null)
		{
			worldTile = World.world.GetTile((int)_vector_target.x, (int)_vector_target.y);
		}
		if (asset.impact_actions != null && worldTile != null && !asset.impact_actions(by_who, null, worldTile))
		{
			reset();
			return;
		}
		Vector2 transformedPositionWithHeight = getTransformedPositionWithHeight();
		if (!string.IsNullOrEmpty(asset.end_effect))
		{
			EffectsLibrary.spawnAt(asset.end_effect, transformedPositionWithHeight, asset.end_effect_scale);
		}
		if (asset.sound_impact != string.Empty)
		{
			MusicBox.playSound(asset.sound_impact, transformedPositionWithHeight.x, transformedPositionWithHeight.y, pGameViewOnly: true);
		}
		if (worldTile != null)
		{
			if (asset.world_actions != null)
			{
				asset.world_actions(by_who, null, worldTile);
			}
			if (asset.hit_freeze)
			{
				worldTile.freeze();
				for (int i = 0; i < worldTile.neighbours.Length; i++)
				{
					WorldTile worldTile2 = worldTile.neighbours[i];
					if (Randy.randomBool())
					{
						worldTile2.freeze();
					}
				}
			}
			if (asset.hit_shake && worldTile.zone.visible && MapBox.isRenderGameplay())
			{
				World.world.startShake(asset.shake_duration, asset.shake_interval, asset.shake_intensity, asset.shake_x, asset.shake_y);
			}
			if (asset.terraform_option != string.Empty)
			{
				MapAction.damageWorld(worldTile, asset.terraform_range, AssetManager.terraform.get(asset.terraform_option), by_who);
			}
		}
		reset();
	}

	public void getDeflected(Vector3 pPos, AttackDataResult pDataResult)
	{
		BaseSimObject pInitiator = World.world.units.get(pDataResult.deflected_by_who_id);
		Vector3 pLaunchPosition = getCurrentPosition();
		Vector3 pTargetPosition = _vector_start;
		start(pInitiator, null, pLaunchPosition, pTargetPosition, asset.id, getCurrentHeight(), getCurrentHeight(), _speed);
	}

	public void getCollided(Vector3 pPos)
	{
		if (asset.trigger_on_collision)
		{
			targetReached();
			setState(ProjectileState.ToRemove);
			return;
		}
		_collision_timeout = 1f;
		Vector3 pLaunchPosition = getCurrentPosition();
		Vector3 newPoint = Toolbox.getNewPoint(pLaunchPosition.x, pLaunchPosition.y, pPos.x, pPos.y, 6f);
		start(by_who, null, pLaunchPosition, newPoint, asset.id, getCurrentHeight() + 5f, getCurrentHeight(), _speed * 0.2f);
	}

	private void setState(ProjectileState pState)
	{
		_state = pState;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool isTargetReached()
	{
		return _is_target_reached;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float getCurrentHeight()
	{
		return _current_position_3d.z;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Vector2 getCurrentPosition()
	{
		return _current_position_3d;
	}

	private WorldTile getCurrentTilePosition()
	{
		return World.world.GetTile((int)_current_position_3d.x, (int)_current_position_3d.y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Vector2 getTransformedPositionWithHeight()
	{
		Vector2 result = _current_position_3d;
		result.y += getCurrentHeight();
		return result;
	}

	public float getCurrentScale()
	{
		return _current_scale;
	}

	public float getAngleForShadow()
	{
		return Toolbox.getAngleDegrees(_current_position_3d.x, _current_position_3d.y, _vector_target.x, _vector_target.y);
	}

	public override void setAlive(bool pValue)
	{
		_alive = pValue;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool isFinished()
	{
		return _state == ProjectileState.ToRemove;
	}

	public bool isDeadAnimation()
	{
		return _state == ProjectileState.AlphaAnimation;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool canBeCollided()
	{
		if (!asset.can_be_collided)
		{
			return false;
		}
		if (isFinished())
		{
			return false;
		}
		if (isTargetReached())
		{
			return false;
		}
		if (_collision_timeout > 0f)
		{
			return false;
		}
		return true;
	}

	public float getAlpha()
	{
		return _dead_alpha;
	}

	private void reset()
	{
		_kill_action = null;
		_collision_timeout = 0f;
		by_who = null;
		_main_target = null;
		_main_target_id = -1L;
		kingdom = null;
		stats.clear();
	}

	public override void Dispose()
	{
		reset();
		asset = null;
		stats.reset();
		base.Dispose();
	}
}
