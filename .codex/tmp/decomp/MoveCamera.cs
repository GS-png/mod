using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MoveCamera : BaseMapObject
{
	private Vector3 _origin;

	private bool _is_zooming;

	internal const float ORTHOGRAPHIC_SIZE_MIN = 10f;

	internal float orthographic_size_max = 130f;

	private float _target_zoom;

	private Vector3 _first_touch;

	internal Camera main_camera;

	internal static MoveCamera instance;

	private WhooshState _whoosh_state;

	private Action _focus_reached_callback;

	private Action _focus_cancel_callback;

	private float _focus_zoom = -1000000f;

	private float _focus_timer;

	private static Actor _focus_unit;

	private static bool _spectator_mode;

	private static float _touch_dist;

	public static bool camera_drag_activated;

	public static int camera_drag_activated_frame;

	public static bool camera_drag_run;

	private float _last_width;

	private float _last_height;

	private bool _first_touch_on_ui;

	internal float camera_zoom_speed = 5f;

	internal float camera_move_speed = 0.01f;

	internal float camera_move_max = 0.06f;

	private Vector2 _move_velocity;

	private readonly Vector2?[] _old_touch_positions = new Vector2?[2];

	private Vector2 _old_touch_vector;

	private float _old_touch_distance;

	private Rect _visible_bounds;

	private Rect _visible_bounds_without_power_bar;

	public float power_bar_position_y;

	private bool _skip_reset_zoom;

	private bool _mouse_controls_used_last;

	private void Awake()
	{
		instance = this;
		main_camera = Camera.main;
	}

	internal override void create()
	{
		base.create();
		resetZoom();
		_target_zoom = main_camera.orthographicSize;
	}

	public static Actor getFocusUnit()
	{
		return _focus_unit;
	}

	public static void setFocusUnit(Actor pActor)
	{
		_focus_unit = pActor;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool hasFocusUnit()
	{
		return _focus_unit != null;
	}

	public static bool isCameraFollowingUnit(Actor pActor)
	{
		return _focus_unit == pActor;
	}

	internal void focusOn(Vector3 pPos)
	{
		clearFocusUnitAndUnselect();
		_target_zoom = 15f;
		_focus_zoom = _target_zoom;
		pPos.z = base.transform.position.z;
		base.transform.position = pPos;
	}

	internal void focusOn(Vector3 pPos, Action pFocusReachedCallback, Action pFocusCancelCallback)
	{
		clearFocusUnitAndUnselect();
		_target_zoom = 15f;
		_focus_zoom = _target_zoom;
		_focus_reached_callback = pFocusReachedCallback;
		_focus_cancel_callback = pFocusCancelCallback;
		pPos.z = base.transform.position.z;
		base.transform.position = pPos;
	}

	internal void focusOnAndFollow(Actor pActor, Action pFocusReachedCallback, Action pFocusCancelCallback)
	{
		clearFocusUnitAndUnselect();
		Config.ui_main_hidden = false;
		_target_zoom = 15f;
		_focus_zoom = _target_zoom;
		_focus_reached_callback = pFocusReachedCallback;
		_focus_cancel_callback = pFocusCancelCallback;
		_focus_unit = pActor;
		_focus_timer = 0f;
		WorldTip.addWordReplacement("$name$", _focus_unit.coloredName);
		WorldTip.showNowTop("tip_following_unit");
		PowerTracker.spectatingUnit(_focus_unit.getName());
		PowerButtonSelector.instance.setPower(PowerButtonSelector.instance.followUnit);
	}

	internal void resetZoom()
	{
		int num = ((Screen.width >= Screen.height) ? (Screen.height / 4) : (Screen.width / 4));
		if (MapBox.width > MapBox.height)
		{
			orthographic_size_max = (int)((float)MapBox.width * 1.1f);
		}
		else
		{
			orthographic_size_max = (int)((float)MapBox.height * 1.1f);
		}
		if ((float)num > orthographic_size_max)
		{
			num = (int)orthographic_size_max;
		}
		_target_zoom = num;
		main_camera.orthographicSize = Mathf.Clamp(_target_zoom, 10f, orthographic_size_max);
		World.world.setZoomOrthographic(main_camera.orthographicSize);
		_mouse_controls_used_last = false;
		main_camera.farClipPlane = (float)MapBox.height * 1.1f;
	}

	public void forceZoom(float pZoom)
	{
		_target_zoom = pZoom;
		zoomToBounds(pForce: true);
	}

	public void setTargetZoom(float pValue)
	{
		_target_zoom = pValue;
	}

	public float getTargetZoom()
	{
		return _target_zoom;
	}

	private void updateZoomControls()
	{
		if (InputHelpers.touchSupported)
		{
			bool flag = false;
			if (UltimateJoystick.getJoyCount() == 2)
			{
				flag = UltimateJoystick.GetJoystickState("JoyRight") || UltimateJoystick.GetJoystickState("JoyLeft");
			}
			if (flag)
			{
				return;
			}
			bool flag2 = !World.world.player_control.already_used_power || ControllableUnit.isControllingUnit();
			if (InputHelpers.touchCount == 2 && flag2)
			{
				World.world.player_control.already_used_zoom = true;
				Touch touch = Input.GetTouch(0);
				Touch touch2 = Input.GetTouch(1);
				Vector2 vector = touch.position - touch.deltaPosition;
				Vector2 vector2 = touch2.position - touch2.deltaPosition;
				float magnitude = (vector - vector2).magnitude;
				float magnitude2 = (touch.position - touch2.position).magnitude;
				float num = magnitude - magnitude2;
				_target_zoom += num * 0.2f * (main_camera.orthographicSize * 0.015f);
			}
		}
		if (inSpectatorMode())
		{
			followFocusUnit();
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool inSpectatorMode()
	{
		if (_spectator_mode && !hasFocusUnit())
		{
			instance.clearFocusUnitAndUnselect();
		}
		_spectator_mode = hasFocusUnit();
		return _spectator_mode;
	}

	private void checkFocusReached()
	{
		if (main_camera.orthographicSize == _focus_zoom)
		{
			if (_focus_reached_callback != null)
			{
				_focus_reached_callback();
			}
			clearFocus();
		}
		if (_target_zoom != _focus_zoom)
		{
			if (_focus_cancel_callback != null)
			{
				_focus_cancel_callback();
			}
			clearFocus();
		}
	}

	private void followFocusUnit()
	{
		if (!hasFocusUnit())
		{
			return;
		}
		Actor focus_unit = _focus_unit;
		if (!focus_unit.isAlive())
		{
			Actor actor = focus_unit.attackedBy?.a;
			if (actor != null && actor.isAlive())
			{
				WorldTip.addWordReplacement("$name$", focus_unit.coloredName);
				WorldTip.addWordReplacement("$killer$", actor.coloredName);
				WorldTip.showNowTop("tip_followed_unit_killed");
				Actor a = actor.a;
				focus_unit.attackedBy = null;
				setFocusUnit(a);
				_focus_timer = 0f;
			}
			else
			{
				WorldTip.addWordReplacement("$name$", focus_unit.coloredName);
				WorldTip.showNowTop("tip_followed_unit_died");
				clearFocusUnitAndUnselect();
			}
		}
		else if (camera_drag_run || InputHelpers.touchCount > 0)
		{
			_focus_timer = 0f;
		}
		else
		{
			Vector3 position = focus_unit.current_position;
			position.z = base.transform.position.z;
			if (_focus_timer <= 1f)
			{
				_focus_timer += Time.deltaTime;
				_focus_timer = Mathf.Clamp(_focus_timer, 0f, 1f);
				position.x = iTween.easeOutCubic(base.transform.position.x, position.x, _focus_timer);
				position.y = iTween.easeOutCubic(base.transform.position.y, position.y, _focus_timer);
			}
			base.transform.position = position;
		}
	}

	private void clearFocus()
	{
		_focus_reached_callback = null;
		_focus_cancel_callback = null;
		_focus_zoom = -1000000f;
	}

	public static void clearFocusUnitOnly()
	{
		_focus_unit = null;
	}

	internal void clearFocusUnitAndUnselect()
	{
		clearFocusUnitOnly();
		_focus_timer = 0f;
		if (World.world.isSelectedPower("follow_unit"))
		{
			PowerButtonSelector.instance.unselectAll();
		}
	}

	private void zoomToBounds(bool pForce = false)
	{
		float max = (World.world.player_control.isSelectionHappens() ? World.world.quality_changer.getZoomRateBoundLow() : orthographic_size_max);
		_target_zoom = Mathf.Clamp(_target_zoom, 10f, max);
		if (main_camera.orthographicSize == _target_zoom)
		{
			return;
		}
		if (_target_zoom > main_camera.orthographicSize)
		{
			main_camera.orthographicSize += Time.deltaTime * camera_zoom_speed * (Mathf.Abs(main_camera.orthographicSize - _target_zoom) + 5f);
			if (main_camera.orthographicSize > _target_zoom)
			{
				main_camera.orthographicSize = Mathf.Clamp(_target_zoom, 10f, orthographic_size_max);
			}
		}
		else if (_target_zoom < main_camera.orthographicSize)
		{
			main_camera.orthographicSize -= Time.deltaTime * camera_zoom_speed * (Mathf.Abs(main_camera.orthographicSize - _target_zoom) + 5f);
			if (main_camera.orthographicSize < _target_zoom)
			{
				main_camera.orthographicSize = Mathf.Clamp(_target_zoom, 10f, orthographic_size_max);
			}
		}
		if (pForce)
		{
			main_camera.orthographicSize = _target_zoom;
		}
		World.world.setZoomOrthographic(main_camera.orthographicSize);
	}

	private void updateMouseCameraDrag()
	{
		if (ControllableUnit.isControllingUnit())
		{
			return;
		}
		camera_drag_run = false;
		bool flag = false;
		bool flag2 = false;
		if (InputHelpers.mouseSupported)
		{
			flag = checkMouseInputDown();
			flag2 = checkMouseInput();
		}
		if (!flag2)
		{
			clearTouches();
			return;
		}
		if (flag && World.world.isOverUI())
		{
			clearTouches();
			return;
		}
		if (flag && _origin.x == -1f && _origin.z == -1f)
		{
			_origin = getMousePos();
		}
		if ((_origin.x == -1f && _origin.y == -1f && _origin.z == -1f) || !flag2)
		{
			return;
		}
		camera_drag_run = true;
		Vector3 position = base.transform.position;
		position.z = 0f;
		Vector3 vector = getMousePos() - position;
		if (Toolbox.DistVec3(_origin, getMousePos()) > 0.1f)
		{
			camera_drag_activated = true;
			camera_drag_activated_frame = Time.frameCount;
		}
		Vector3 vector2 = _origin - vector;
		vector2.z = 0f;
		if (InputHelpers.touchSupported)
		{
			_touch_dist = Toolbox.DistVec3(_first_touch, getTouchPos(pScreenCoords: true));
			if (World.world.player_control.touch_ticks_skip > 5)
			{
				if (_touch_dist >= 20f || (float)World.world.player_control.touch_ticks_skip > 0.3f)
				{
					World.world.player_control.already_used_zoom = true;
					World.world.player_control.already_used_power = false;
				}
			}
			else if (InputHelpers.touchCount == 1)
			{
				return;
			}
		}
		if (InputHelpers.mouseSupported)
		{
			Vector3 vector3 = position;
			base.transform.position = vector2;
			Vector2 vector4 = vector2 - vector3;
			if (vector4.magnitude > 0.01f)
			{
				Vector2 vector5 = vector4 * 0.2f;
				addVelocity(vector5.x, vector5.y);
				_mouse_controls_used_last = true;
			}
			else
			{
				_move_velocity = Vector2.zero;
			}
			checkDistanceMoved(vector3);
			cameraToBounds();
		}
	}

	private void updateVelocity()
	{
		Vector2 move_velocity = _move_velocity;
		if (move_velocity.x != 0f || move_velocity.y != 0f)
		{
			float decayFactor = getDecayFactor();
			_move_velocity *= decayFactor;
			if (Mathf.Abs(_move_velocity.x) < 0.01f)
			{
				_move_velocity.x = 0f;
			}
			if (Mathf.Abs(_move_velocity.y) < 0.01f)
			{
				_move_velocity.y = 0f;
			}
			if (!InputHelpers.mouseSupported || !InputHelpers.GetMouseButton(1))
			{
				Vector3 vector = _move_velocity;
				base.transform.position += vector;
				setWhooshState(WhooshState.NeedWhoosh);
				cameraToBounds();
			}
		}
	}

	private float getDecayFactor()
	{
		if (_mouse_controls_used_last)
		{
			return Mathf.Pow(0.8f, Time.deltaTime / (1f / 60f));
		}
		return 0.8f;
	}

	private void checkDistanceMoved(Vector3 pOldPosition)
	{
		float num = Toolbox.DistVec3(base.transform.position, pOldPosition);
		Vector3 vector = main_camera.ScreenToWorldPoint(new Vector3(0f, 0f, main_camera.nearClipPlane));
		float num2 = (main_camera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, main_camera.nearClipPlane)) - vector).magnitude * 0.007f;
		if (num > num2)
		{
			GodPower selected_power = World.world.selected_power;
			if (selected_power != null && selected_power.set_used_camera_drag_on_long_move)
			{
				World.world.player_control.already_used_camera_drag = true;
			}
		}
		if (num > num2 * 1.2f)
		{
			setWhooshState(WhooshState.NeedWhoosh);
		}
	}

	private bool checkMouseInputDown()
	{
		if (InputHelpers.GetMouseButtonDown(1))
		{
			return true;
		}
		if (InputHelpers.GetMouseButtonDown(2))
		{
			return true;
		}
		if (InputHelpers.GetMouseButtonDown(0))
		{
			if (!Input.mousePresent)
			{
				return true;
			}
			if (MapBox.isRenderMiniMap())
			{
				return true;
			}
			return false;
		}
		return false;
	}

	private bool checkMouseInput()
	{
		if (InputHelpers.GetMouseButton(1))
		{
			return true;
		}
		if (InputHelpers.GetMouseButton(2))
		{
			return true;
		}
		if (InputHelpers.GetMouseButton(0))
		{
			if (!Input.mousePresent)
			{
				return true;
			}
			return false;
		}
		return false;
	}

	private void clearTouches()
	{
		_first_touch.Set(-1f, -1f, -1f);
		_origin.Set(-1f, -1f, -1f);
		if (camera_drag_activated && Time.frameCount > camera_drag_activated_frame + 2)
		{
			camera_drag_activated = false;
		}
	}

	private void cameraToBounds()
	{
		Vector3 position = new Vector3
		{
			x = Mathf.Clamp(base.transform.position.x, 0f, MapBox.width),
			y = Mathf.Clamp(base.transform.position.y, 0f, MapBox.height),
			z = -0.5f
		};
		base.transform.position = position;
		World.world.nameplate_manager.update();
	}

	private Vector3 getTouchPos(bool pScreenCoords = false)
	{
		Vector2 vector = default(Vector2);
		int num = 0;
		int touchCount = InputHelpers.touchCount;
		for (int i = 0; i < touchCount; i++)
		{
			Touch touch = Input.GetTouch(i);
			if (touch.phase != TouchPhase.Canceled && touch.phase != TouchPhase.Ended)
			{
				vector += touch.position;
				num++;
			}
		}
		Vector3 vector2 = vector / num;
		if (pScreenCoords)
		{
			return vector2;
		}
		return main_camera.ScreenToWorldPoint(vector2);
	}

	private Vector3 getMousePos()
	{
		if (InputHelpers.mouseSupported)
		{
			return World.world.getMousePos();
		}
		return Vector3.one;
	}

	private void setWhooshState(WhooshState pState)
	{
		if (pState != WhooshState.NeedWhoosh || _whoosh_state != WhooshState.WhooshPlayed)
		{
			_whoosh_state = pState;
		}
	}

	private bool isNoInputDetected()
	{
		if (_move_velocity.x == 0f && _move_velocity.y == 0f && InputHelpers.touchCount == 0)
		{
			if (!InputHelpers.GetMouseButton(0) && !InputHelpers.GetMouseButton(1))
			{
				return !InputHelpers.GetMouseButton(2);
			}
			return false;
		}
		return false;
	}

	private void LateUpdate()
	{
		updateVisibleBounds();
		if (!World.world.tutorial.isActive())
		{
			if (_whoosh_state == WhooshState.NeedWhoosh)
			{
				setWhooshState(WhooshState.WhooshPlayed);
			}
			if (isNoInputDetected())
			{
				setWhooshState(WhooshState.Idle);
			}
		}
	}

	private void updateVisibleBounds()
	{
		Vector3 powerBarLeftCornerViewportPos = ToolbarButtons.instance.getPowerBarLeftCornerViewportPos();
		power_bar_position_y = ((Vector2)World.world.camera.ScreenToWorldPoint(powerBarLeftCornerViewportPos)).y;
		if (power_bar_position_y < 0f)
		{
			power_bar_position_y = 0f;
		}
		Camera camera = main_camera;
		float nearClipPlane = camera.nearClipPlane;
		Vector3 vector = camera.ViewportToWorldPoint(new Vector3(0f, 0f, nearClipPlane));
		Vector3 vector2 = camera.ViewportToWorldPoint(new Vector3(1f, 1f, nearClipPlane));
		_visible_bounds.x = vector.x;
		_visible_bounds.y = vector.y;
		_visible_bounds.width = vector2.x - _visible_bounds.x;
		_visible_bounds.height = vector2.y - _visible_bounds.y;
		_visible_bounds_without_power_bar.x = vector.x;
		_visible_bounds_without_power_bar.y = power_bar_position_y;
		_visible_bounds_without_power_bar.width = vector2.x - _visible_bounds_without_power_bar.x;
		_visible_bounds_without_power_bar.height = vector2.y - _visible_bounds_without_power_bar.y;
	}

	public bool isWithinCameraView(Vector2 pPos)
	{
		Rect visible_bounds = _visible_bounds;
		return checkBounds(pPos, visible_bounds);
	}

	public bool isWithinCameraViewNotPowerBar(Vector2 pPos)
	{
		Rect visible_bounds_without_power_bar = _visible_bounds_without_power_bar;
		return checkBounds(pPos, visible_bounds_without_power_bar);
	}

	private bool checkBounds(Vector2 pPos, Rect pBounds)
	{
		return pBounds.Contains(pPos);
	}

	public void update()
	{
		if (World.world.tutorial.isActive())
		{
			return;
		}
		int pixelWidth = main_camera.pixelWidth;
		int pixelHeight = main_camera.pixelHeight;
		if (_last_width != (float)pixelWidth || _last_height != (float)pixelHeight)
		{
			_last_width = pixelWidth;
			_last_height = pixelHeight;
			if (_skip_reset_zoom)
			{
				_skip_reset_zoom = false;
			}
			else
			{
				resetZoom();
			}
			return;
		}
		if (Globals.TRAILER_MODE)
		{
			updateTrailerMode();
		}
		if (InputHelpers.touchCount > 0)
		{
			if (Input.GetTouch(0).phase == TouchPhase.Began && World.world.isOverUI())
			{
				_first_touch_on_ui = true;
			}
		}
		else
		{
			_first_touch_on_ui = false;
		}
		if (!ScrollWindow.isWindowActive() && (!World.world.isOverUI() || inSpectatorMode()))
		{
			updateZoomControls();
		}
		if (_target_zoom != main_camera.orthographicSize)
		{
			zoomToBounds();
		}
		if (_focus_zoom > -1000000f)
		{
			checkFocusReached();
		}
		if (World.world.isGameplayControlsLocked() || ScrollWindow.isAnimationActive() || _first_touch_on_ui)
		{
			clearTouches();
			_old_touch_positions[0] = null;
			_old_touch_positions[1] = null;
			return;
		}
		if (InputHelpers.touchSupported)
		{
			updateMobileCamera();
		}
		if (InputHelpers.mouseSupported && (!InputHelpers.touchSupported || InputHelpers.touchCount <= 0))
		{
			updateMouseCameraDrag();
			if (!ScrollWindow.isWindowActive() && !ControllableUnit.isControllingUnit())
			{
				updateVelocity();
			}
		}
	}

	public Vector2 getVelocity()
	{
		return _move_velocity;
	}

	private bool ignoreTouchControls()
	{
		if (!World.world.isOverUI() && !ScrollWindow.isWindowActive())
		{
			return ScrollWindow.isAnimationActive();
		}
		return true;
	}

	private void updateMobileCamera()
	{
		if (InputHelpers.touchCount == 0)
		{
			_old_touch_positions[0] = null;
			_old_touch_positions[1] = null;
		}
		else
		{
			if ((World.world.isAnyPowerSelected() && World.world.selected_power.hold_action && InputHelpers.touchCount == 1) || World.world.player_control.already_used_power || ControllableUnit.isControllingUnit())
			{
				return;
			}
			Vector3 position = base.transform.position;
			if (InputHelpers.touchCount == 1)
			{
				if (!_old_touch_positions[0].HasValue || _old_touch_positions[1].HasValue)
				{
					_old_touch_positions[0] = Input.GetTouch(0).position;
					_old_touch_positions[1] = null;
				}
				else
				{
					Vector2 position2 = Input.GetTouch(0).position;
					Vector3 position3 = base.transform.position;
					Vector3 vector = base.transform.TransformDirection(((_old_touch_positions[0] - position2) * main_camera.orthographicSize / main_camera.pixelHeight * 2f).Value);
					Vector3 position4 = position3 + vector;
					base.transform.position = position4;
					_old_touch_positions[0] = position2;
					cameraToBounds();
				}
			}
			else if (!_old_touch_positions[1].HasValue)
			{
				_old_touch_positions[0] = Input.GetTouch(0).position;
				_old_touch_positions[1] = Input.GetTouch(1).position;
				_old_touch_vector = (_old_touch_positions[0] - _old_touch_positions[1]).Value;
				_old_touch_distance = _old_touch_vector.magnitude;
			}
			else
			{
				Vector2 vector2 = new Vector2(main_camera.pixelWidth, main_camera.pixelHeight);
				Vector2[] array = new Vector2[2]
				{
					Input.GetTouch(0).position,
					Input.GetTouch(1).position
				};
				Vector2 old_touch_vector = array[0] - array[1];
				float magnitude = old_touch_vector.magnitude;
				base.transform.position += base.transform.TransformDirection(((_old_touch_positions[0] + _old_touch_positions[1] - vector2) * main_camera.orthographicSize / vector2.y).Value);
				if (magnitude != 0f && _old_touch_distance != magnitude)
				{
					main_camera.orthographicSize = Mathf.Clamp(main_camera.orthographicSize * (_old_touch_distance / magnitude), 10f, orthographic_size_max);
				}
				World.world.setZoomOrthographic(main_camera.orthographicSize);
				base.transform.position -= base.transform.TransformDirection((array[0] + array[1] - vector2) * main_camera.orthographicSize / vector2.y);
				cameraToBounds();
				_old_touch_positions[0] = array[0];
				_old_touch_positions[1] = array[1];
				_old_touch_vector = old_touch_vector;
				_old_touch_distance = magnitude;
				World.world.player_control.already_used_zoom = true;
			}
			checkDistanceMoved(position);
		}
	}

	private static float getMoveDistance(bool pFast = false)
	{
		float num = Time.deltaTime * 55f;
		if (pFast)
		{
			num *= 2.5f;
		}
		return num * instance._target_zoom * instance.camera_move_speed;
	}

	public static void move(HotkeyAsset pAsset)
	{
		float moveDistance = getMoveDistance(pAsset.id.StartsWith("fast_"));
		switch (pAsset.id)
		{
		case "up":
		case "fast_up":
			instance.addVelocity(0f, moveDistance);
			break;
		case "down":
		case "fast_down":
			instance.addVelocity(0f, 0f - moveDistance);
			break;
		case "right":
		case "fast_right":
			instance.addVelocity(moveDistance, 0f);
			break;
		case "left":
		case "fast_left":
			instance.addVelocity(0f - moveDistance, 0f);
			break;
		}
		instance.clampVelocity();
		instance._mouse_controls_used_last = false;
	}

	private void addVelocity(float pX, float pY)
	{
		_move_velocity.x += pX;
		_move_velocity.y += pY;
	}

	private void clampVelocity()
	{
		float min = (0f - _target_zoom) * camera_move_max;
		float max = _target_zoom * camera_move_max;
		_move_velocity.y = Mathf.Clamp(_move_velocity.y, min, max);
		_move_velocity.x = Mathf.Clamp(_move_velocity.x, min, max);
	}

	public static void zoomIn(HotkeyAsset pAsset)
	{
		instance._target_zoom -= instance.main_camera.orthographicSize * 0.05f;
	}

	public static void zoomOut(HotkeyAsset pAsset)
	{
		instance._target_zoom += instance.main_camera.orthographicSize * 0.05f;
	}

	public static void zoomInWheel(HotkeyAsset pAsset)
	{
		instance._target_zoom -= instance.main_camera.orthographicSize * 0.2f;
	}

	public static void zoomOutWheel(HotkeyAsset pAsset)
	{
		instance._target_zoom += instance.main_camera.orthographicSize * 0.2f;
	}

	private void updateTrailerMode()
	{
		if (Input.GetKeyUp(KeyCode.F10))
		{
			camera_zoom_speed -= 0.2f;
			if (camera_zoom_speed < 0f)
			{
				camera_zoom_speed = 0.2f;
			}
		}
		if (Input.GetKeyUp(KeyCode.F11))
		{
			camera_zoom_speed += 0.2f;
		}
		if (Input.GetKeyUp(KeyCode.O))
		{
			camera_move_max -= 0.1f;
			if (camera_move_max < 0.01f)
			{
				camera_move_max = 0.01f;
			}
		}
		if (Input.GetKeyUp(KeyCode.P))
		{
			camera_move_max += 0.1f;
		}
		if (Input.GetKeyUp(KeyCode.K))
		{
			camera_move_speed -= 0.01f;
			if (camera_move_speed < 0.01f)
			{
				camera_move_speed = 0.01f;
			}
		}
		if (Input.GetKeyUp(KeyCode.L))
		{
			camera_move_speed += 0.01f;
		}
		if (Input.GetKeyDown(KeyCode.R) && _target_zoom != main_camera.orthographicSize)
		{
			if (_target_zoom > main_camera.orthographicSize)
			{
				_target_zoom = main_camera.orthographicSize + _target_zoom * 0.1f;
			}
			else
			{
				_target_zoom = main_camera.orthographicSize - _target_zoom * 0.1f;
			}
		}
	}

	public void debug(DebugTool pTool)
	{
		pTool.setText("bounds_normal:", _visible_bounds, 0f, pShowBar: false, 0L);
		pTool.setText("bounds_wth_power_bar:", _visible_bounds_without_power_bar, 0f, pShowBar: false, 0L);
		pTool.setText("is_no_input_detected:", isNoInputDetected(), 0f, pShowBar: false, 0L);
		pTool.setText("_whooshState:", _whoosh_state, 0f, pShowBar: false, 0L);
		pTool.setText("InputHelpers.touchCount:", InputHelpers.touchCount, 0f, pShowBar: false, 0L);
		pTool.setText("world.isGameplayControlsLocked():", World.world.isGameplayControlsLocked(), 0f, pShowBar: false, 0L);
		pTool.setText("ScrollWindow.animationActive:", ScrollWindow.isAnimationActive(), 0f, pShowBar: false, 0L);
		pTool.setText("firstTouchOnUI", _first_touch_on_ui, 0f, pShowBar: false, 0L);
		pTool.setText("world.alreadyUsedZoom", World.world.player_control.already_used_zoom, 0f, pShowBar: false, 0L);
		pTool.setText("world.alreadyUsedPower", World.world.player_control.already_used_power, 0f, pShowBar: false, 0L);
		pTool.setText("world.already_used_camera_drag", World.world.player_control.already_used_camera_drag, 0f, pShowBar: false, 0L);
		pTool.setText("_touch_dist", _touch_dist, 0f, pShowBar: false, 0L);
		pTool.setText("cameraDragRun", camera_drag_run, 0f, pShowBar: false, 0L);
		pTool.setText("camera_drag_activated", camera_drag_activated, 0f, pShowBar: false, 0L);
		if (UltimateJoystick.getJoyCount() == 2)
		{
			pTool.setText("JoyRight", UltimateJoystick.GetJoystickState("JoyRight"), 0f, pShowBar: false, 0L);
			pTool.setText("JoyLeft", UltimateJoystick.GetJoystickState("JoyLeft"), 0f, pShowBar: false, 0L);
		}
	}

	public void skipResetZoom()
	{
		_skip_reset_zoom = true;
	}
}
