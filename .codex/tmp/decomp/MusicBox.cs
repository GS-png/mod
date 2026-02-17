using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AOT;
using FMOD;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;

public class MusicBox : MonoBehaviour
{
	private const int MUSIC_ZONES_SIZE = 3;

	private const int IDLE_SOUND_TIMER_MIN = 5;

	private const int IDLE_SOUND_TIMER_MAX = 12;

	public static MusicBox inst;

	private readonly HashSet<string> _flags_to_enable = new HashSet<string>();

	private EventInstance _music_event;

	internal MusicBoxDebug debug_box;

	private float _timer;

	private const float INTERVAL_UPDATE = 1f;

	public static bool music_on = true;

	public static bool sounds_on = true;

	public static bool debug_sounds = true;

	private VCA _vca_sound_effects;

	private VCA _vca_music;

	private VCA _vca_ui;

	private Bus _bus_master;

	private Bus _bus_idle;

	private float _volume_idle = 1f;

	private EVENT_CALLBACK _music_callback;

	private TimelineInfo _timeline_info;

	private GCHandle _timeline_handle;

	public static bool new_world_on_start_played = false;

	private readonly Dictionary<string, EventInstance> _environment_sounds = new Dictionary<string, EventInstance>();

	private readonly Dictionary<string, EventInstance> _drawing_sounds = new Dictionary<string, EventInstance>();

	private static readonly Dictionary<string, bool> _events_cache = new Dictionary<string, bool>();

	private static readonly Dictionary<string, GUID> _events_guids = new Dictionary<string, GUID>();

	private static GameObject _sound_object;

	private int _tiles_sand;

	private int _tiles_shallow_water;

	public MusicState music_state;

	private MusicBoxLibrary _lib;

	public MusicBoxIdle idle;

	private GameObject _camera_listener;

	private bool _created;

	private static FMOD.Studio.System _studio_system => RuntimeManager.StudioSystem;

	private static bool fmod_disabled
	{
		get
		{
			if (!music_on)
			{
				return !sounds_on;
			}
			return false;
		}
	}

	private void Awake()
	{
		create();
	}

	internal void create()
	{
		if (_created)
		{
			return;
		}
		_created = true;
		inst = this;
		debug_box = new MusicBoxDebug();
		_lib = AssetManager.music_box;
		idle = new MusicBoxIdle();
		ScrollWindow.addCallbackHide(hideWindowCallback);
		if (!fmod_disabled)
		{
			try
			{
				_bus_master = RuntimeManager.GetBus("bus:/");
				if (_bus_master.isValid())
				{
					_bus_master.setVolume(0f);
				}
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.LogError("MusicBox failed to init: " + ex);
				music_on = false;
				sounds_on = false;
				return;
			}
			Platform platform = Settings.Instance.FindCurrentPlatform();
			if (debug_sounds)
			{
				Platform.PropertyAccessors.LiveUpdate.Set(platform, TriStateBool.Enabled);
				Platform.PropertyAccessors.Overlay.Set(platform, TriStateBool.Development);
			}
			else
			{
				Platform.PropertyAccessors.LiveUpdate.Set(platform, TriStateBool.Disabled);
				Platform.PropertyAccessors.Overlay.Set(platform, TriStateBool.Disabled);
			}
			createMusicEvent();
			assignCallback();
			startMusic();
		}
		reserveFlag(MusicBoxLibrary.Neutral_001.id);
		clearParams();
		_sound_object = new GameObject("musicbox_pan");
		_camera_listener = new GameObject("fmod_listener");
		_camera_listener.transform.parent = Camera.main.transform;
		_camera_listener.AddComponent<StudioListener>();
	}

	private void setMusicState(MusicState pState)
	{
		music_state = pState;
		if (pState == MusicState.Menu)
		{
			reserveFlag("Menu");
		}
	}

	private void checkDrawingSounds()
	{
		if (!sounds_on)
		{
			return;
		}
		bool flag = false;
		if (InputHelpers.mouseSupported)
		{
			if (!Input.GetMouseButton(0))
			{
				flag = true;
			}
			else if (!ControllableUnit.isControllingUnit() && World.world.isOverUI())
			{
				flag = true;
			}
		}
		else if (Input.touchCount == 0)
		{
			flag = true;
		}
		if (flag)
		{
			inst.stopDrawingSounds();
		}
	}

	private void checkIdleVolume()
	{
		if (World.world.isPaused())
		{
			_volume_idle -= Time.deltaTime;
			if (_volume_idle < 0f)
			{
				_volume_idle = 0f;
			}
		}
		else
		{
			_volume_idle += Time.deltaTime;
			if (_volume_idle > 1f)
			{
				_volume_idle = 1f;
			}
		}
		if (!_bus_idle.isValid())
		{
			_bus_idle = RuntimeManager.GetBus("bus:/Idle");
		}
		checkBusVolume(_volume_idle, _bus_idle);
	}

	private void checkVolumes()
	{
		bool flag = _vca_sound_effects.isValid();
		if (!flag)
		{
			_vca_sound_effects = RuntimeManager.GetVCA("vca:/Sound Effects");
			_vca_music = RuntimeManager.GetVCA("vca:/Music");
			_vca_ui = RuntimeManager.GetVCA("vca:/UI");
			_bus_master = RuntimeManager.GetBus("bus:/");
			if (!flag)
			{
				return;
			}
		}
		checkBusVolume("volume_master_sound", _bus_master);
		checkVcaVolume("volume_sound_effects", _vca_sound_effects);
		checkVcaVolume("volume_music", _vca_music);
		checkVcaVolume("volume_ui", _vca_ui);
	}

	private void checkBusVolume(float pVolume, Bus pBus)
	{
		pBus.getVolume(out var volume);
		if (volume != pVolume)
		{
			pBus.setVolume(pVolume);
		}
	}

	private void checkBusVolume(string pOptionParam, Bus pBus)
	{
		float num = (float)PlayerConfig.getIntValue(pOptionParam) / 100f;
		pBus.getVolume(out var volume);
		if (volume != num)
		{
			pBus.setVolume(num);
		}
	}

	private void checkVcaVolume(string pOptionParam, VCA pVCA)
	{
		float num = (float)PlayerConfig.getIntValue(pOptionParam) / 100f;
		pVCA.getVolume(out var volume);
		if (volume != num)
		{
			pVCA.setVolume(num);
		}
	}

	public void update(float pElapsed)
	{
		if (fmod_disabled)
		{
			return;
		}
		Bench.bench("music_box", "music_box_total");
		Bench.bench("check_volume", "music_box");
		checkVolumes();
		checkIdleVolume();
		Bench.benchEnd("check_volume", "music_box", pSaveCounter: false, 0L);
		Bench.bench("update_idle", "music_box");
		idle.update(pElapsed);
		Bench.benchEnd("update_idle", "music_box", pSaveCounter: false, 0L);
		Bench.bench("update_debug", "music_box");
		debug_box.update();
		Bench.benchEnd("update_debug", "music_box", pSaveCounter: false, 0L);
		Bench.bench("update_drawing", "music_box");
		checkDrawingSounds();
		Bench.benchEnd("update_drawing", "music_box", pSaveCounter: false, 0L);
		Bench.bench("update_fmod_params", "music_box");
		Vector3 localPosition = new Vector3(0f, 0f, World.world.camera.orthographicSize * 1.5f);
		_camera_listener.transform.localPosition = localPosition;
		updateMainFmodParams();
		Bench.benchEnd("update_fmod_params", "music_box", pSaveCounter: false, 0L);
		if (_timer > 0f)
		{
			_timer -= pElapsed;
			return;
		}
		_timer = 1f;
		Bench.bench("clearParams", "music_box");
		clearParams();
		Bench.benchEnd("clearParams", "music_box", pSaveCounter: false, 0L);
		Bench.bench("drawFmodDebugZones", "music_box");
		drawFmodDebugZones();
		Bench.benchEnd("drawFmodDebugZones", "music_box", pSaveCounter: false, 0L);
		Bench.bench("countZonesUnits", "music_box");
		countUnitsInZones();
		Bench.benchEnd("countZonesUnits", "music_box", pSaveCounter: false, 0L);
		Bench.bench("countSpecialTiles", "music_box");
		countSpecialTilesInChunks();
		Bench.benchEnd("countSpecialTiles", "music_box", pSaveCounter: false, 0L);
		Bench.bench("checkUnitsParams", "music_box");
		checkUnitsParams();
		Bench.benchEnd("checkUnitsParams", "music_box", pSaveCounter: false, 0L);
		Bench.bench("checkCamera", "music_box");
		checkCamera();
		Bench.benchEnd("checkCamera", "music_box", pSaveCounter: false, 0L);
		Bench.bench("music_params_1", "music_box");
		foreach (MusicBoxContainerTiles c_list_param in _lib.c_list_params)
		{
			if (c_list_param.enabled)
			{
				enableMusicParameter(c_list_param.asset.id);
			}
			else
			{
				disableMusicParameter(c_list_param.asset.id);
			}
		}
		Bench.benchEnd("music_params_1", "music_box", pSaveCounter: false, 0L);
		Bench.bench("music_params_2", "music_box");
		foreach (MusicBoxContainerUnits value in _lib.c_dict_units.Values)
		{
			if (value.enabled)
			{
				enableMusicParameter(value.asset.id);
			}
			else
			{
				disableMusicParameter(value.asset.id);
			}
		}
		Bench.benchEnd("music_params_2", "music_box", pSaveCounter: false, 0L);
		Bench.bench("flags", "music_box");
		if (_flags_to_enable.Any())
		{
			foreach (string item in _flags_to_enable)
			{
				enableMusicParameter(item);
			}
			_flags_to_enable.Clear();
		}
		Bench.benchEnd("flags", "music_box", pSaveCounter: false, 0L);
		Bench.bench("check_environment", "music_box");
		foreach (MusicBoxContainerTiles c_list_environment in _lib.c_list_environments)
		{
			checkEnvironmentSound(c_list_environment);
		}
		Bench.benchEnd("check_environment", "music_box", pSaveCounter: false, 0L);
		Bench.benchEnd("music_box", "music_box_total", pSaveCounter: false, 0L);
	}

	private void updateMainFmodParams()
	{
		if (World.world.quality_changer.isLowRes())
		{
			_studio_system.setParameterByName("MiniMap", 1f);
		}
		else
		{
			_studio_system.setParameterByName("MiniMap", 0f);
		}
		float zoomRatioLow = World.world.quality_changer.getZoomRatioLow();
		float zoomRatioHigh = World.world.quality_changer.getZoomRatioHigh();
		float zoomRatioFull = World.world.quality_changer.getZoomRatioFull();
		_studio_system.setParameterByName("Zoom_Low", zoomRatioLow);
		_studio_system.setParameterByName("Zoom_High", zoomRatioHigh);
		_studio_system.setParameterByName("Zoom_Full", zoomRatioFull);
	}

	public static void clearAllSounds()
	{
		if (!fmod_disabled)
		{
			inst.idle.clearAllSounds();
			inst.debug_box.clear();
		}
	}

	public void clearParams()
	{
		foreach (Kingdom kingdom in World.world.kingdoms)
		{
			if (_lib.c_dict_civs.TryGetValue(kingdom.getSpecies(), out var value))
			{
				value.kingdom_exists = true;
			}
		}
		_tiles_sand = 0;
		_tiles_shallow_water = 0;
		foreach (MusicBoxContainerCivs value2 in _lib.c_dict_civs.Values)
		{
			value2.clear();
		}
		foreach (MusicAsset item in _lib.list)
		{
			item.container_tiles?.clear();
		}
		foreach (MusicBoxContainerUnits value3 in _lib.c_dict_units.Values)
		{
			value3.clear();
		}
		DebugLayer.fmod_zones_to_draw.Clear();
	}

	private void hideWindowCallback(string pWindowID)
	{
	}

	private void assignCallback()
	{
		_music_callback = beatEventCallback;
		_timeline_info = new TimelineInfo();
		_timeline_handle = GCHandle.Alloc(_timeline_info, GCHandleType.Pinned);
		_music_event.setUserData(GCHandle.ToIntPtr(_timeline_handle));
		_music_event.setCallback(_music_callback, EVENT_CALLBACK_TYPE.TIMELINE_MARKER | EVENT_CALLBACK_TYPE.TIMELINE_BEAT);
	}

	public static EventInstance getNewInstance(string pID)
	{
		return RuntimeManager.CreateInstance(pID);
	}

	public static EventInstance attachToObject(string pID, GameObject pObject, bool pPlay = true)
	{
		if (!sounds_on)
		{
			return default(EventInstance);
		}
		EventInstance newInstance = getNewInstance(pID);
		RuntimeManager.AttachInstanceToGameObject(newInstance, pObject.transform);
		if (pPlay)
		{
			newInstance.start();
		}
		return newInstance;
	}

	private void createMusicEvent()
	{
		_music_event = getNewInstance("event:/MUSIC/ConsolidatedMusicEvent");
	}

	private void startMusic()
	{
		if (music_on)
		{
			_music_event.start();
		}
	}

	[MonoPInvokeCallback(typeof(EVENT_CALLBACK))]
	private static RESULT beatEventCallback(EVENT_CALLBACK_TYPE pType, IntPtr pInstancePtr, IntPtr pParameterPtr)
	{
		IntPtr userdata;
		RESULT userData = inst._music_event.getUserData(out userdata);
		if (userData != RESULT.OK)
		{
			UnityEngine.Debug.LogError("Timeline Callback error: " + userData);
		}
		else if (userdata != IntPtr.Zero)
		{
			TimelineInfo timelineInfo = (TimelineInfo)GCHandle.FromIntPtr(userdata).Target;
			if (pType == EVENT_CALLBACK_TYPE.TIMELINE_MARKER)
			{
				timelineInfo.lastMarker = ((TIMELINE_MARKER_PROPERTIES)Marshal.PtrToStructure(pParameterPtr, typeof(TIMELINE_MARKER_PROPERTIES))).name;
				inst.markerReached(timelineInfo.lastMarker);
			}
		}
		return RESULT.OK;
	}

	private void loadBanks()
	{
	}

	private void checkEnvironmentSound(MusicBoxContainerTiles pContainer)
	{
		MusicAsset asset = pContainer.asset;
		bool flag = true;
		if (asset.mini_map_only)
		{
			if (!World.world.quality_changer.isLowRes())
			{
				flag = false;
			}
		}
		else if (World.world.quality_changer.isLowRes())
		{
			flag = false;
		}
		else if (asset.min_zoom <= World.world.camera.orthographicSize)
		{
			flag = false;
		}
		if (flag && asset.min_tiles_to_play != 0 && pContainer.amount < asset.min_tiles_to_play)
		{
			flag = false;
		}
		pContainer.enabled = flag;
		if (flag)
		{
			playEnvironmentSound(pContainer);
		}
		else
		{
			stopEnvironmentSound(pContainer);
		}
	}

	public static void playIdleSoundVisibleOnly(string pSoundPath, WorldTile pTile)
	{
		if (sounds_on)
		{
			playSoundVisibleOnly(pSoundPath, pTile);
		}
	}

	public static void playSoundVisibleOnly(string pSoundPath, WorldTile pTile)
	{
		if (sounds_on)
		{
			playSound(pSoundPath, pTile, pGameViewOnly: true, pVisibleOnly: true);
		}
	}

	public static void playSound(string pSoundPath, WorldTile pTile, bool pGameViewOnly = false, bool pVisibleOnly = false)
	{
		if (!string.IsNullOrEmpty(pSoundPath) && (!pVisibleOnly || pTile.zone.visible))
		{
			playSound(pSoundPath, pTile.pos.x, pTile.pos.y, pGameViewOnly);
		}
	}

	public static void playSoundWorld(string pSoundPath)
	{
	}

	public static void playSoundUI(string pSoundPath)
	{
		playSound(pSoundPath);
	}

	public static EventInstance PlayOneShot(GUID pGuid, Vector3 pPosition, bool pSet3D = true)
	{
		EventInstance result = RuntimeManager.CreateInstance(pGuid);
		if (pSet3D)
		{
			result.set3DAttributes(pPosition.To3DAttributes());
		}
		else
		{
			Vector3 position = World.world.move_camera.transform.position;
			float orthographicSize = World.world.move_camera.main_camera.orthographicSize;
			Vector3 pos = new Vector3(position.x, position.y, orthographicSize);
			result.set3DAttributes(pos.To3DAttributes());
		}
		result.start();
		result.release();
		return result;
	}

	private static bool isEventExists(string pEventPath)
	{
		if (!_events_cache.TryGetValue(pEventPath, out var value))
		{
			value = RuntimeManager.StudioSystem.getEvent(pEventPath, out var _) == RESULT.OK;
			_events_cache.Add(pEventPath, value);
			if (!value)
			{
				UnityEngine.Debug.LogWarning("[FMOD] Missing event : " + pEventPath);
			}
			else
			{
				_events_guids[pEventPath] = RuntimeManager.PathToGUID(pEventPath);
			}
		}
		return value;
	}

	public static void playSound(string pSoundPath, float pX = -1f, float pY = -1f, bool pGameViewOnly = false, bool pVisibleOnly = false)
	{
		if (sounds_on && (!pGameViewOnly || !World.world.quality_changer.isLowRes()) && isEventExists(pSoundPath))
		{
			GUID pGuid = _events_guids[pSoundPath];
			EventInstance? eventInstance = null;
			try
			{
				eventInstance = ((pX == -1f || pY == -1f) ? new EventInstance?(PlayOneShot(pGuid, Vector3.zero, pSet3D: false)) : new EventInstance?(PlayOneShot(pGuid, new Vector3(pX, pY, 0f))));
			}
			catch (EventNotFoundException)
			{
			}
			if (DebugConfig.isOn(DebugOption.OverlaySounds) || DebugConfig.isOn(DebugOption.OverlaySoundsActive))
			{
				inst.debug_box.add(pSoundPath.Split('/').Last(), pX, pY, eventInstance.Value);
			}
		}
	}

	public void playEnvironmentSound(MusicBoxContainerTiles pContainer)
	{
		if (sounds_on)
		{
			MusicAsset asset = pContainer.asset;
			EventInstance eventInstance;
			if (_environment_sounds.ContainsKey(asset.fmod_path))
			{
				eventInstance = _environment_sounds[asset.fmod_path];
			}
			else
			{
				eventInstance = getNewInstance(asset.fmod_path);
				_environment_sounds.Add(asset.fmod_path, eventInstance);
			}
			setPan(eventInstance, pContainer.cur_pan.x, pContainer.cur_pan.y);
			if (!isPlaying(eventInstance))
			{
				eventInstance.start();
			}
		}
	}

	public void stopEnvironmentSound(MusicBoxContainerTiles pContainer)
	{
		MusicAsset asset = pContainer.asset;
		if (_environment_sounds.ContainsKey(asset.fmod_path))
		{
			EventInstance pInstance = _environment_sounds[asset.fmod_path];
			if (isPlaying(pInstance))
			{
				pInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
			}
		}
	}

	public void playDrawingSound(string pSoundPath, float pX = -1f, float pY = -1f)
	{
		if (sounds_on)
		{
			EventInstance eventInstance;
			if (_drawing_sounds.ContainsKey(pSoundPath))
			{
				eventInstance = _drawing_sounds[pSoundPath];
			}
			else
			{
				eventInstance = getNewInstance(pSoundPath);
				_drawing_sounds.Add(pSoundPath, eventInstance);
			}
			setPan(eventInstance, pX, pY);
			eventInstance.setParameterByName("cursor_speed", MapBox.cursor_speed.fmod_speed);
			if (!isPlaying(eventInstance))
			{
				eventInstance.start();
			}
		}
	}

	public static void setPan(EventInstance pInstance, float pX, float pY)
	{
		if (pX != -1f || pY != -1f)
		{
			float z = 0f;
			_sound_object.transform.position = new Vector3(pX, pY, z);
			ATTRIBUTES_3D attributes = _sound_object.To3DAttributes();
			pInstance.set3DAttributes(attributes);
		}
	}

	public void stopDrawingSound(string pID)
	{
		if (_drawing_sounds.ContainsKey(pID))
		{
			EventInstance pInstance = _drawing_sounds[pID];
			if (isPlaying(pInstance))
			{
				pInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
			}
		}
	}

	public void stopDrawingSounds()
	{
		foreach (EventInstance value in _drawing_sounds.Values)
		{
			if (isPlaying(value))
			{
				value.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
			}
		}
	}

	public static bool isPlaying(EventInstance pInstance)
	{
		pInstance.getPlaybackState(out var state);
		return state != PLAYBACK_STATE.STOPPED;
	}

	private void drawFmodDebugZones()
	{
	}

	private void countUnitsInZones()
	{
		foreach (MapChunk visibleChunk in World.world.zone_camera.getVisibleChunks())
		{
			if (!visibleChunk.objects.isEmpty())
			{
				countUnits(visibleChunk);
			}
		}
	}

	private void checkCamera()
	{
		if ((_tiles_sand < 50 || _tiles_shallow_water < 50) && _tiles_sand >= 100 && _tiles_shallow_water < 20)
		{
			MusicBoxLibrary.Locations_Desert.container_tiles.amount = _tiles_sand + _tiles_shallow_water;
		}
		_lib.c_list_params.Sort(sorter);
		float num = 0f;
		for (int i = 0; i < _lib.c_list_params.Count; i++)
		{
			MusicBoxContainerTiles musicBoxContainerTiles = _lib.c_list_params[i];
			musicBoxContainerTiles.enabled = false;
			num += (float)musicBoxContainerTiles.amount;
		}
		float num2 = 0f;
		int num3 = 0;
		for (int j = 0; j < _lib.c_list_params.Count; j++)
		{
			MusicBoxContainerTiles musicBoxContainerTiles2 = _lib.c_list_params[j];
			musicBoxContainerTiles2.calculatePan();
			musicBoxContainerTiles2.percent = (float)musicBoxContainerTiles2.amount / num;
			num2 += musicBoxContainerTiles2.percent;
			if (musicBoxContainerTiles2.amount > 50)
			{
				if (num3 >= 2)
				{
					break;
				}
				musicBoxContainerTiles2.enabled = true;
				num3++;
			}
		}
	}

	private void checkUnitsParams()
	{
		MusicBoxContainerUnits musicBoxContainerUnits = null;
		MusicBoxContainerUnits musicBoxContainerUnits2 = null;
		foreach (MusicBoxContainerUnits value in _lib.c_dict_units.Values)
		{
			value.asset.special_delegate_units?.Invoke(value);
			if (value.units > 0)
			{
				if (value.asset.priority == MusicLayerPriority.High)
				{
					musicBoxContainerUnits2 = value;
				}
				else if (value.asset.priority == MusicLayerPriority.Medium)
				{
					musicBoxContainerUnits = value;
				}
			}
		}
		if (musicBoxContainerUnits2 != null)
		{
			musicBoxContainerUnits = null;
		}
		if (musicBoxContainerUnits2 != null || musicBoxContainerUnits != null)
		{
			foreach (MusicBoxContainerUnits value2 in _lib.c_dict_units.Values)
			{
				if ((musicBoxContainerUnits2 == null || value2 != musicBoxContainerUnits2) && (musicBoxContainerUnits == null || value2 != musicBoxContainerUnits))
				{
					value2.units = 0;
				}
			}
		}
		foreach (MusicBoxContainerUnits value3 in _lib.c_dict_units.Values)
		{
			if (value3.units > 0)
			{
				value3.enabled = true;
			}
		}
	}

	public static int sorter(MusicBoxContainerTiles pV1, MusicBoxContainerTiles pV2)
	{
		return pV2.amount.CompareTo(pV1.amount);
	}

	private void countSpecialTilesInChunks()
	{
		List<MapChunk> visibleChunks = World.world.zone_camera.getVisibleChunks();
		int i = 0;
		for (int count = visibleChunks.Count; i < count; i++)
		{
			MapChunk pChunk = visibleChunks[i];
			countSpecialTilesForZone(pChunk);
		}
	}

	private void countSpecialTilesForZone(MapChunk pChunk)
	{
		List<MusicBoxTileData> simpleData = pChunk.getSimpleData();
		TileTypeBase[] array_tiles = TileLibrary.array_tiles;
		int i = 0;
		for (int count = simpleData.Count; i < count; i++)
		{
			MusicBoxTileData musicBoxTileData = simpleData[i];
			TileTypeBase tileTypeBase = array_tiles[musicBoxTileData.tile_type_id];
			int amount = musicBoxTileData.amount;
			if (amount == 0)
			{
				continue;
			}
			List<MusicAsset> music_assets = tileTypeBase.music_assets;
			if (music_assets != null)
			{
				int j = 0;
				for (int count2 = music_assets.Count; j < count2; j++)
				{
					music_assets[j].container_tiles.count(amount, pChunk.world_center_x, pChunk.world_center_y);
				}
			}
		}
	}

	private void countUnits(MapChunk pChunk)
	{
		foreach (long kingdom2 in pChunk.objects.kingdoms)
		{
			Kingdom kingdom = World.world.kingdoms.get(kingdom2);
			if (kingdom != null)
			{
				ActorAsset actorAsset = kingdom.getActorAsset();
				if (actorAsset != null && actorAsset.has_music_theme)
				{
					_lib.c_dict_units[actorAsset.music_theme].units++;
				}
			}
		}
	}

	private void enableMusicParameter(string pID)
	{
		setMusicParameter(pID, 1f);
	}

	private void disableMusicParameter(string pID)
	{
		setMusicParameter(pID, 0f);
	}

	private void setMusicParameter(string pID, float pValue)
	{
		_music_event.setParameterByName(pID, pValue);
	}

	private void markerReached(string pMarker)
	{
		if (pMarker == "Intro")
		{
			return;
		}
		MusicAsset musicAsset = _lib.get(pMarker);
		if (musicAsset != null)
		{
			if (musicAsset.disable_param_after_start)
			{
				disableMusicParameter(pMarker);
			}
			if (musicAsset.action != null)
			{
				musicAsset.action();
			}
		}
	}

	public static void reserveFlag(string pID, bool pValue = true)
	{
		if (music_on)
		{
			inst._timer = -1f;
			inst._flags_to_enable.Add(pID);
		}
	}

	public static void debug_fmod(DebugTool pTool)
	{
		if (!fmod_disabled)
		{
			_studio_system.getBankList(out var array);
			EventDescription _event;
			RESULT rESULT = _studio_system.getEvent("event:/MUSIC/ConsolidatedMusicEvent", out _event);
			int position = -1;
			float value = -1f;
			PLAYBACK_STATE state = PLAYBACK_STATE.STARTING;
			inst._music_event.getParameterByName("new_world", out value);
			inst._music_event.getTimelinePosition(out position);
			inst._music_event.getPlaybackState(out state);
			pTool.setText("Zoom_Low:", World.world.quality_changer.getZoomRatioLow(), 0f, pShowBar: false, 0L);
			pTool.setText("Zoom_High:", World.world.quality_changer.getZoomRatioHigh(), 0f, pShowBar: false, 0L);
			pTool.setText("Zoom_Full:", World.world.quality_changer.getZoomRatioFull(), 0f, pShowBar: false, 0L);
			pTool.setSeparator();
			pTool.setText("idle_sim_objects:", inst.idle.CountCurrentSounds(), 0f, pShowBar: false, 0L);
			pTool.setText("music state:", inst.music_state, 0f, pShowBar: false, 0L);
			pTool.setText("IsInitialized:", RuntimeManager.IsInitialized, 0f, pShowBar: false, 0L);
			pTool.setText("Banks count:", array.Length, 0f, pShowBar: false, 0L);
			pTool.setText("AnySampleDataLoading:", RuntimeManager.AnySampleDataLoading(), 0f, pShowBar: false, 0L);
			pTool.setText("Bank Master:", RuntimeManager.HasBankLoaded("Master"), 0f, pShowBar: false, 0L);
			pTool.setText("Bank Master.strings:", RuntimeManager.HasBankLoaded("Master.strings"), 0f, pShowBar: false, 0L);
			pTool.setText("MUSIC_EVENT by name:", rESULT.ToString(), 0f, pShowBar: false, 0L);
			pTool.setText("tParam_new_world:", value, 0f, pShowBar: false, 0L);
			pTool.setText("tTimelinePos:", position, 0f, pShowBar: false, 0L);
			pTool.setText("getPlaybackState:", state.ToString(), 0f, pShowBar: false, 0L);
		}
	}

	public void debug_params(DebugTool pTool)
	{
		if (fmod_disabled)
		{
			return;
		}
		float value = 0f;
		for (int i = 0; i < _lib.list.Count; i++)
		{
			string id = _lib.list[i].id;
			inst._music_event.getParameterByName(id, out value);
			if (value == 1f)
			{
				pTool.setText(id + ":", value, 0f, pShowBar: false, 0L);
			}
		}
	}

	public void debug_world_params(DebugTool pTool)
	{
		if (fmod_disabled)
		{
			return;
		}
		foreach (MusicBoxContainerCivs value in _lib.c_dict_civs.Values)
		{
			if (value.active)
			{
				pTool.setText(value.asset.id, value.buildings + " " + value.kingdom_exists + " " + value.active, 0f, pShowBar: false, 0L);
			}
		}
		foreach (MusicAsset item in _lib.list)
		{
			MusicBoxContainerTiles container_tiles = item.container_tiles;
			if (container_tiles != null && container_tiles.enabled)
			{
				pTool.setText(container_tiles.asset.id, container_tiles.amount + " " + container_tiles.enabled + " " + container_tiles.percent.ToText() + "%", 0f, pShowBar: false, 0L);
			}
		}
		pTool.setText("", "", 0f, pShowBar: false, 0L);
	}

	public void debug_unit_params(DebugTool pTool)
	{
		if (fmod_disabled || _lib.c_dict_units.Count == 0)
		{
			return;
		}
		foreach (MusicBoxContainerUnits value in _lib.c_dict_units.Values)
		{
			if (value.units != 0)
			{
				pTool.setText(value.asset.id, value.units + " " + value.enabled, 0f, pShowBar: false, 0L);
			}
		}
		pTool.setText("", "", 0f, pShowBar: false, 0L);
	}
}
