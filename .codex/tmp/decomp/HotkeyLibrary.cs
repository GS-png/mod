using System;
using System.Collections.Generic;
using System.Globalization;
using Beebyte.Obfuscator;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Serializable]
[ObfuscateLiterals]
public class HotkeyLibrary : AssetLibrary<HotkeyAsset>
{
	public static HotkeyAsset cancel;

	public static HotkeyAsset console;

	public static HotkeyAsset remove;

	public static HotkeyAsset pause;

	public static HotkeyAsset hide_ui;

	public static HotkeyAsset action_jump;

	public static HotkeyAsset action_dash;

	public static HotkeyAsset action_backstep;

	public static HotkeyAsset action_talk;

	public static HotkeyAsset action_steal;

	public static HotkeyAsset action_swear;

	public static HotkeyAsset left;

	public static HotkeyAsset right;

	public static HotkeyAsset up;

	public static HotkeyAsset down;

	public static HotkeyAsset next_unit_in_multi_selection;

	public static HotkeyAsset next_tab;

	public static HotkeyAsset prev_tab;

	public static HotkeyAsset zoom_in;

	public static HotkeyAsset zoom_out;

	public static HotkeyAsset zoom;

	public static HotkeyAsset world_speed;

	public static HotkeyAsset brush;

	public static HotkeyAsset follow_unit;

	public static HotkeyAsset control_unit;

	public static HotkeyAsset fullscreen_switch;

	public static HotkeyAsset many_mod;

	public static HotkeyAsset fast_civ_mod;

	public static KeyCode[] mod_keys = new KeyCode[0];

	private HotkeyAsset[] action_hotkeys = new HotkeyAsset[0];

	private Dictionary<string, float> holding_times = new Dictionary<string, float>();

	private bool holdingAnyModKey;

	private bool runModKeyCheck = true;

	private bool _last_input_active;

	private MetaType[] _meta_zones = new MetaType[10]
	{
		MetaType.Army,
		MetaType.Alliance,
		MetaType.Kingdom,
		MetaType.City,
		MetaType.Clan,
		MetaType.Religion,
		MetaType.Culture,
		MetaType.Language,
		MetaType.Family,
		MetaType.Subspecies
	};

	public override void init()
	{
		base.init();
		addHotkeysForUnitControlLayer();
		fullscreen_switch = add(new HotkeyAsset
		{
			id = "fullscreen_switch",
			default_key_1 = KeyCode.Return,
			default_key_mod_1 = KeyCode.LeftAlt,
			just_pressed_action = delegate
			{
				PlayerConfig.toggleFullScreen();
			}
		});
		console = add(new HotkeyAsset
		{
			id = "console",
			default_key_1 = KeyCode.Tilde,
			default_key_2 = KeyCode.BackQuote,
			check_controls_locked = true,
			just_pressed_action = delegate
			{
				if (EventSystem.current.currentSelectedGameObject == null)
				{
					World.world.console.Toggle();
				}
			}
		});
		cancel = add(new HotkeyAsset
		{
			id = "cancel",
			default_key_1 = KeyCode.Escape,
			just_pressed_action = escapeAction
		});
		add(new HotkeyAsset
		{
			id = "back",
			default_key_1 = KeyCode.Mouse3,
			just_pressed_action = backAction
		});
		pause = add(new HotkeyAsset
		{
			id = "pause",
			default_key_1 = KeyCode.Space,
			check_window_not_active = true,
			check_controls_locked = true,
			just_pressed_action = delegate
			{
				Config.paused = !Config.paused;
			}
		});
		hide_ui = add(new HotkeyAsset
		{
			id = "hide_ui",
			default_key_1 = KeyCode.H,
			check_window_not_active = true,
			check_controls_locked = true,
			just_pressed_action = delegate
			{
				Config.ui_main_hidden = !Config.ui_main_hidden;
			}
		});
		remove = add(new HotkeyAsset
		{
			id = "remove",
			default_key_1 = KeyCode.Delete,
			default_key_2 = KeyCode.Backspace,
			check_window_not_active = true,
			check_controls_locked = true,
			just_pressed_action = delegate
			{
				if (SelectedUnit.isSet())
				{
					SelectedUnit.killSelected();
				}
				else
				{
					string pID = "life_eraser";
					if (World.world.isSelectedPower("life_eraser"))
					{
						pID = "demolish";
					}
					World.world.selected_buttons.clickPowerButton(PowerButton.get(pID));
				}
			}
		});
		zoom = add(new HotkeyAsset
		{
			id = "zoom",
			use_mouse_wheel = true,
			holding_cooldown = 0f,
			check_window_not_active = true,
			check_controls_locked = true,
			allow_unit_control = true,
			holding_action = delegate(HotkeyAsset pAsset)
			{
				if (World.world.isPointerInGame() && (!World.world.isOverUI() || MoveCamera.inSpectatorMode()))
				{
					float y = Input.mouseScrollDelta.y;
					if (y < 0f)
					{
						MoveCamera.zoomOutWheel(pAsset);
					}
					else if (y > 0f)
					{
						MoveCamera.zoomInWheel(pAsset);
					}
				}
			}
		});
		world_speed = add(new HotkeyAsset
		{
			id = "world_speed",
			default_key_mod_1 = KeyCode.LeftControl,
			default_key_mod_2 = KeyCode.RightControl,
			default_key_mod_3 = KeyCode.LeftMeta,
			check_window_not_active = true,
			check_controls_locked = true,
			use_mouse_wheel = true,
			holding_cooldown = 0f,
			holding_action = delegate
			{
				float y = Input.mouseScrollDelta.y;
				WorldTimeScaleAsset time_scale_asset = Config.time_scale_asset;
				if (y < 0f)
				{
					Config.prevWorldSpeed();
				}
				else if (y > 0f)
				{
					Config.nextWorldSpeed();
				}
				if (time_scale_asset != Config.time_scale_asset)
				{
					string text = LocalizedTextManager.getText("changed_worldspeed");
					string text2 = null;
					text2 = ((Config.time_scale_asset.getLocaleID() == null) ? Toolbox.coloredText(Config.time_scale_asset.id, "#95DD5D") : Toolbox.coloredText(Config.time_scale_asset.getLocaleID(), "#95DD5D", pLocalize: true));
					text = text.Replace("$speed$", text2);
					WorldTip.instance.showToolbarText(text);
				}
			}
		});
		brush = add(new HotkeyAsset
		{
			id = "brush",
			default_key_mod_1 = KeyCode.LeftAlt,
			default_key_mod_2 = KeyCode.RightAlt,
			check_window_not_active = true,
			check_controls_locked = true,
			use_mouse_wheel = true,
			holding_cooldown = 0f,
			holding_action = delegate
			{
				float y = Input.mouseScrollDelta.y;
				string current_brush = Config.current_brush;
				if (y < 0f)
				{
					BrushLibrary.nextBrush();
				}
				else if (y > 0f)
				{
					BrushLibrary.previousBrush();
				}
				if (current_brush != Config.current_brush)
				{
					BrushData brushData = Brush.get(Config.current_brush);
					string localeID = brushData.getLocaleID();
					string text = LocalizedTextManager.getText("changed_brush");
					string text2 = Toolbox.coloredText(localeID, "#95DD5D", pLocalize: true);
					text2 = text2 + " (" + Toolbox.coloredText(brushData.size.ToString(), "#95DD5D") + ")";
					text = text.Replace("$brush$", text2);
					WorldTip.instance.showToolbarText(text);
				}
			}
		});
		many_mod = add(new HotkeyAsset
		{
			id = "many_mod",
			default_key_mod_1 = KeyCode.RightShift,
			default_key_mod_2 = KeyCode.LeftShift,
			disable_for_controlled_unit = true,
			check_only_not_controllable_unit = true
		});
		fast_civ_mod = add(new HotkeyAsset
		{
			id = "fast_civ_mod",
			default_key_mod_1 = KeyCode.RightControl,
			default_key_mod_2 = KeyCode.LeftControl
		});
		left = add(new HotkeyAsset
		{
			id = "left",
			default_key_1 = KeyCode.A,
			default_key_2 = KeyCode.LeftArrow,
			holding_action = MoveCamera.move,
			holding_cooldown = 0f,
			check_window_not_active = true,
			check_controls_locked = true,
			allow_unit_control = true
		});
		right = clone("right", "left");
		t.default_key_1 = KeyCode.D;
		t.default_key_2 = KeyCode.RightArrow;
		up = clone("up", "left");
		t.default_key_1 = KeyCode.W;
		t.default_key_2 = KeyCode.UpArrow;
		down = clone("down", "left");
		t.default_key_1 = KeyCode.S;
		t.default_key_2 = KeyCode.DownArrow;
		clone("fast_left", "left");
		t.default_key_mod_1 = KeyCode.RightShift;
		t.default_key_mod_2 = KeyCode.LeftShift;
		clone("fast_right", "right");
		t.default_key_mod_1 = KeyCode.RightShift;
		t.default_key_mod_2 = KeyCode.LeftShift;
		clone("fast_up", "up");
		t.default_key_mod_1 = KeyCode.RightShift;
		t.default_key_mod_2 = KeyCode.LeftShift;
		clone("fast_down", "down");
		t.default_key_mod_1 = KeyCode.RightShift;
		t.default_key_mod_2 = KeyCode.LeftShift;
		zoom_in = add(new HotkeyAsset
		{
			id = "zoom_in",
			default_key_1 = KeyCode.Q,
			default_key_2 = KeyCode.Plus,
			default_key_3 = KeyCode.KeypadPlus,
			check_window_not_active = true,
			check_controls_locked = true,
			holding_action = MoveCamera.zoomIn,
			holding_cooldown = 0f
		});
		zoom_out = add(new HotkeyAsset
		{
			id = "zoom_out",
			default_key_1 = KeyCode.E,
			default_key_2 = KeyCode.Minus,
			default_key_3 = KeyCode.KeypadMinus,
			check_window_not_active = true,
			check_controls_locked = true,
			holding_action = MoveCamera.zoomOut,
			holding_cooldown = 0f
		});
		add(new HotkeyAsset
		{
			id = "power_left",
			default_key_1 = KeyCode.LeftArrow,
			default_key_2 = KeyCode.A,
			default_key_mod_1 = KeyCode.LeftControl,
			default_key_mod_2 = KeyCode.LeftMeta,
			default_key_mod_3 = KeyCode.RightControl,
			check_window_not_active = true,
			check_controls_locked = true,
			just_pressed_action = powerMove,
			holding_action = powerMove
		});
		clone("power_right", "power_left");
		t.default_key_1 = KeyCode.RightArrow;
		t.default_key_2 = KeyCode.D;
		clone("power_up", "power_left");
		t.default_key_1 = KeyCode.UpArrow;
		t.default_key_2 = KeyCode.W;
		clone("power_down", "power_left");
		t.default_key_1 = KeyCode.DownArrow;
		t.default_key_2 = KeyCode.S;
		add(new HotkeyAsset
		{
			id = "toggle_power",
			default_key_1 = KeyCode.Return,
			default_key_2 = KeyCode.KeypadEnter,
			check_controls_locked = true,
			just_pressed_action = delegate
			{
				PowerButton activeButton = PowersTab.getActiveTab().getActiveButton();
				if (!(activeButton == null))
				{
					if (activeButton.godPower != null)
					{
						string text = activeButton.godPower.id;
						if (!(text == "clock"))
						{
							if (text == "pause")
							{
								activeButton.clickSpecial();
							}
							else
							{
								activeButton.godPower.select_button_action?.Invoke(activeButton.godPower.id);
								if (activeButton.godPower.toggle_action != null)
								{
									activeButton.godPower.toggle_action?.Invoke(activeButton.godPower.id);
									PowerButtonSelector.instance.checkToggleIcons();
								}
							}
						}
						else
						{
							Config.nextWorldSpeed(pCycle: true);
						}
					}
					else if (activeButton.type == PowerButtonType.Options)
					{
						activeButton.gameObject.GetComponent<Button>().onClick.Invoke();
					}
					else
					{
						activeButton.clickButton();
					}
				}
			}
		});
		clone("toggle_power2", "toggle_power");
		t.default_key_mod_1 = KeyCode.LeftControl;
		t.default_key_mod_2 = KeyCode.LeftMeta;
		next_tab = add(new HotkeyAsset
		{
			id = "next_tab",
			default_key_1 = KeyCode.Tab,
			check_window_not_active = true,
			check_controls_locked = true,
			check_no_multi_unit_selection = true,
			just_pressed_action = delegate
			{
				Button next = PowerTabController.instance.getNext(PowersTab.getActiveTab().name);
				PowersTab.showTabFromButton(next);
				TipButton component = next.gameObject.GetComponent<TipButton>();
				string pText = LocalizedTextManager.getText(component.textOnClick) + "\n" + LocalizedTextManager.getText(component.textOnClickDescription);
				WorldTip.instance.showToolbarText(pText);
			}
		});
		prev_tab = add(new HotkeyAsset
		{
			id = "prev_tab",
			default_key_1 = KeyCode.Tab,
			default_key_mod_1 = KeyCode.LeftShift,
			default_key_mod_2 = KeyCode.RightShift,
			check_window_not_active = true,
			check_controls_locked = true,
			check_no_multi_unit_selection = true,
			just_pressed_action = delegate
			{
				PowersTab.showTabFromButton(PowerTabController.instance.getPrev(PowersTab.getActiveTab().name));
			}
		});
		add(new HotkeyAsset
		{
			id = "hotkey_1",
			default_key_1 = KeyCode.Alpha1,
			default_key_2 = KeyCode.Keypad1,
			check_window_not_active = true,
			check_controls_locked = true,
			just_pressed_action = delegate(HotkeyAsset pAsset)
			{
				string text = pAsset.id;
				string hotkeyFromData = getHotkeyFromData(text);
				if (!string.IsNullOrEmpty(hotkeyFromData))
				{
					hotkeySelectNano(pAsset, hotkeyFromData);
				}
				else
				{
					string stringVal = PlayerConfig.dict[text].stringVal;
					hotkeySelectPower(pAsset, stringVal);
				}
			}
		});
		clone("hotkey_2", "hotkey_1");
		t.default_key_1 = KeyCode.Alpha2;
		t.default_key_2 = KeyCode.Keypad2;
		clone("hotkey_3", "hotkey_1");
		t.default_key_1 = KeyCode.Alpha3;
		t.default_key_2 = KeyCode.Keypad3;
		clone("hotkey_4", "hotkey_1");
		t.default_key_1 = KeyCode.Alpha4;
		t.default_key_2 = KeyCode.Keypad4;
		clone("hotkey_5", "hotkey_1");
		t.default_key_1 = KeyCode.Alpha5;
		t.default_key_2 = KeyCode.Keypad5;
		clone("hotkey_6", "hotkey_1");
		t.default_key_1 = KeyCode.Alpha6;
		t.default_key_2 = KeyCode.Keypad6;
		clone("hotkey_7", "hotkey_1");
		t.default_key_1 = KeyCode.Alpha7;
		t.default_key_2 = KeyCode.Keypad7;
		clone("hotkey_8", "hotkey_1");
		t.default_key_1 = KeyCode.Alpha8;
		t.default_key_2 = KeyCode.Keypad8;
		clone("hotkey_9", "hotkey_1");
		t.default_key_1 = KeyCode.Alpha9;
		t.default_key_2 = KeyCode.Keypad9;
		clone("hotkey_0", "hotkey_1");
		t.default_key_1 = KeyCode.Alpha0;
		t.default_key_2 = KeyCode.Keypad0;
		add(new HotkeyAsset
		{
			id = "save_hotkey_1",
			default_key_1 = KeyCode.Alpha1,
			default_key_2 = KeyCode.Keypad1,
			default_key_mod_1 = KeyCode.LeftControl,
			default_key_mod_2 = KeyCode.LeftMeta,
			check_window_not_active = true,
			check_controls_locked = true,
			just_pressed_action = delegate(HotkeyAsset pAsset)
			{
				if (SelectedObjects.isNanoObjectSet())
				{
					hotkeySaveTab(pAsset);
				}
				else
				{
					hotkeySavePower(pAsset);
				}
			}
		});
		clone("save_hotkey_2", "save_hotkey_1");
		t.default_key_1 = KeyCode.Alpha2;
		t.default_key_2 = KeyCode.Keypad2;
		clone("save_hotkey_3", "save_hotkey_1");
		t.default_key_1 = KeyCode.Alpha3;
		t.default_key_2 = KeyCode.Keypad3;
		clone("save_hotkey_4", "save_hotkey_1");
		t.default_key_1 = KeyCode.Alpha4;
		t.default_key_2 = KeyCode.Keypad4;
		clone("save_hotkey_5", "save_hotkey_1");
		t.default_key_1 = KeyCode.Alpha5;
		t.default_key_2 = KeyCode.Keypad5;
		clone("save_hotkey_6", "save_hotkey_1");
		t.default_key_1 = KeyCode.Alpha6;
		t.default_key_2 = KeyCode.Keypad6;
		clone("save_hotkey_7", "save_hotkey_1");
		t.default_key_1 = KeyCode.Alpha7;
		t.default_key_2 = KeyCode.Keypad7;
		clone("save_hotkey_8", "save_hotkey_1");
		t.default_key_1 = KeyCode.Alpha8;
		t.default_key_2 = KeyCode.Keypad8;
		clone("save_hotkey_9", "save_hotkey_1");
		t.default_key_1 = KeyCode.Alpha9;
		t.default_key_2 = KeyCode.Keypad9;
		clone("save_hotkey_0", "save_hotkey_1");
		t.default_key_1 = KeyCode.Alpha0;
		t.default_key_2 = KeyCode.Keypad0;
		add(new HotkeyAsset
		{
			id = "zone_type_previous",
			default_key_1 = KeyCode.Z,
			check_window_not_active = true,
			check_controls_locked = true,
			just_pressed_action = delegate
			{
				switchZones(-1);
			}
		});
		clone("zone_type_next", "zone_type_previous");
		t.just_pressed_action = delegate
		{
			switchZones(1);
		};
		t.default_key_1 = KeyCode.X;
		add(new HotkeyAsset
		{
			id = "zone_type_state_next",
			default_key_1 = KeyCode.C,
			check_window_not_active = true,
			check_controls_locked = true,
			just_pressed_action = delegate
			{
				toggleZones(1);
			}
		});
		clone("zone_type_state_previous", "zone_type_state_next");
		t.just_pressed_action = delegate
		{
			toggleZones(-1);
		};
		t.default_key_mod_1 = KeyCode.LeftControl;
		t.default_key_mod_2 = KeyCode.LeftMeta;
		follow_unit = add(new HotkeyAsset
		{
			id = "follow_unit",
			default_key_1 = KeyCode.F,
			check_window_not_active = false,
			check_controls_locked = true,
			just_pressed_action = delegate
			{
				Actor unit = SelectedUnit.unit;
				if (ScrollWindow.isWindowActive())
				{
					ScrollWindow currentWindow = ScrollWindow.getCurrentWindow();
					if (!(currentWindow.screen_id != "unit") && !currentWindow.GetComponent<UnitWindow>().name_input.inputField.isFocused && SelectedUnit.isSet())
					{
						World.world.followUnit(unit);
						ScrollWindow.hideAllEvent();
					}
				}
				else if (MapBox.isRenderGameplay())
				{
					Actor actorNearCursor = World.world.getActorNearCursor();
					if (actorNearCursor == null)
					{
						if (MoveCamera.hasFocusUnit())
						{
							MoveCamera.clearFocusUnitOnly();
						}
						else if (SelectedUnit.isSet())
						{
							World.world.followUnit(unit);
						}
					}
					else if (actorNearCursor.isCameraFollowingUnit())
					{
						MoveCamera.clearFocusUnitOnly();
					}
					else
					{
						World.world.followUnit(actorNearCursor);
					}
				}
			}
		});
		control_unit = add(new HotkeyAsset
		{
			id = "control_unit",
			default_key_1 = KeyCode.G,
			check_window_not_active = false,
			just_pressed_action = delegate
			{
				if (MoveCamera.hasFocusUnit())
				{
					World.world.move_camera.clearFocusUnitAndUnselect();
				}
				Actor unit = SelectedUnit.unit;
				if (ScrollWindow.isWindowActive())
				{
					ScrollWindow currentWindow = ScrollWindow.getCurrentWindow();
					if (!(currentWindow.screen_id != "unit") && !currentWindow.GetComponent<UnitWindow>().name_input.inputField.isFocused && SelectedUnit.isSet())
					{
						ControllableUnit.setControllableCreature(unit);
						ScrollWindow.hideAllEvent();
					}
				}
				else if (MapBox.isRenderGameplay())
				{
					Actor actorNearCursor = World.world.getActorNearCursor();
					if (ControllableUnit.isControllingUnit())
					{
						if (ControllableUnit.isControllingUnit(actorNearCursor))
						{
							ControllableUnit.clear();
							return;
						}
						if (actorNearCursor != null)
						{
							ControllableUnit.clear();
							ControllableUnit.setControllableCreature(actorNearCursor);
							return;
						}
						if (actorNearCursor == null)
						{
							ControllableUnit.clear();
							return;
						}
					}
					if (actorNearCursor == null)
					{
						if (SelectedUnit.isSet())
						{
							ControllableUnit.setControllableCreatureAndSelected(unit);
						}
					}
					else
					{
						ControllableUnit.setControllableCreatureAndSelected(actorNearCursor);
					}
				}
			}
		});
		add(new HotkeyAsset
		{
			id = "meta_window_previous",
			default_key_1 = KeyCode.LeftArrow,
			default_key_2 = KeyCode.Q,
			default_key_3 = KeyCode.A,
			just_pressed_action = delegate
			{
				MetaSwitchManager.switchWindows(MetaSwitchManager.Direction.Left);
			},
			check_controls_locked = true,
			check_window_active = true
		});
		clone("meta_window_next", "meta_window_previous");
		t.default_key_1 = KeyCode.RightArrow;
		t.default_key_2 = KeyCode.E;
		t.default_key_3 = KeyCode.D;
		t.just_pressed_action = delegate
		{
			MetaSwitchManager.switchWindows(MetaSwitchManager.Direction.Right);
		};
		add(new HotkeyAsset
		{
			id = "window_tab_next",
			default_key_1 = KeyCode.Tab,
			default_key_2 = KeyCode.S,
			default_key_3 = KeyCode.DownArrow,
			just_pressed_action = windowTabsSwitch,
			check_controls_locked = true,
			check_window_active = true
		});
		clone("window_tab_previous", "window_tab_next");
		t.default_key_mod_1 = KeyCode.LeftShift;
		t.default_key_mod_2 = KeyCode.RightShift;
		clone("window_tab_previous_2", "window_tab_next");
		t.default_key_1 = KeyCode.W;
		t.default_key_2 = KeyCode.UpArrow;
		t.default_key_3 = KeyCode.None;
	}

	private void addHotkeysForUnitControlLayer()
	{
		next_unit_in_multi_selection = add(new HotkeyAsset
		{
			id = "next_unit_in_multi_selection",
			default_key_1 = KeyCode.Tab,
			check_window_not_active = true,
			check_controls_locked = true,
			check_multi_unit_selection = true,
			ignore_same_key_diagnostic = true,
			just_pressed_action = delegate
			{
				SelectedUnit.nextMainUnit();
			}
		});
		action_jump = add(new HotkeyAsset
		{
			id = "action_jump",
			default_key_1 = KeyCode.Space,
			ignore_same_key_diagnostic = true,
			check_window_not_active = true,
			check_controls_locked = true,
			check_only_controllable_unit = true
		});
		action_dash = add(new HotkeyAsset
		{
			id = "action_dash",
			default_key_1 = KeyCode.LeftShift,
			default_key_2 = KeyCode.RightShift,
			ignore_same_key_diagnostic = true,
			check_window_not_active = true,
			check_controls_locked = true,
			ignore_mod_keys = true,
			check_only_controllable_unit = true
		});
		action_backstep = add(new HotkeyAsset
		{
			id = "action_backstep",
			default_key_1 = KeyCode.LeftControl,
			default_key_2 = KeyCode.RightControl,
			ignore_same_key_diagnostic = true,
			check_window_not_active = true,
			check_controls_locked = true,
			ignore_mod_keys = true,
			check_only_controllable_unit = true
		});
		action_swear = add(new HotkeyAsset
		{
			id = "action_swear",
			default_key_1 = KeyCode.F,
			ignore_same_key_diagnostic = true,
			check_window_not_active = true,
			check_controls_locked = true,
			check_only_controllable_unit = true
		});
		action_steal = add(new HotkeyAsset
		{
			id = "action_steal",
			default_key_1 = KeyCode.Q,
			ignore_same_key_diagnostic = true,
			check_window_not_active = true,
			check_controls_locked = true,
			check_only_controllable_unit = true
		});
		action_talk = add(new HotkeyAsset
		{
			id = "action_talk",
			default_key_1 = KeyCode.T,
			ignore_same_key_diagnostic = true,
			check_window_not_active = true,
			check_controls_locked = true,
			check_only_controllable_unit = true
		});
	}

	private void switchZones(int pIndexChange)
	{
		MetaType currentMapBorderMode = Zones.getCurrentMapBorderMode(pCheckOnlyOption: true);
		int num = Array.IndexOf(_meta_zones, currentMapBorderMode);
		num += pIndexChange;
		num = Toolbox.loopIndex(num, _meta_zones.Length);
		currentMapBorderMode = _meta_zones[num];
		MetaTypeAsset asset = AssetManager.meta_type_library.getAsset(currentMapBorderMode);
		AssetManager.powers.get(asset.power_option_zone_id).toggle_action(asset.power_option_zone_id);
		PowerButtonSelector.instance.checkToggleIcons();
		GodPower pPower = AssetManager.powers.get(asset.power_option_zone_id);
		WorldTip.instance.showToolbarText(pPower);
	}

	private void toggleZones(int pIndexChange)
	{
		MetaType currentMapBorderMode = Zones.getCurrentMapBorderMode(pCheckOnlyOption: true);
		if (currentMapBorderMode != MetaType.None)
		{
			MetaTypeAsset asset = AssetManager.meta_type_library.getAsset(currentMapBorderMode);
			GodPower godPower = AssetManager.powers.get(asset.power_option_zone_id);
			if (godPower.multi_toggle)
			{
				asset.toggleOptionZone(godPower, pIndexChange, pDisable: false);
				PowerButtonSelector.instance.checkToggleIcons();
			}
		}
	}

	private void windowTabsSwitch(HotkeyAsset pAsset)
	{
		ScrollWindow currentWindow = ScrollWindow.getCurrentWindow();
		List<WindowMetaTab> contentTabs = currentWindow.tabs.getContentTabs();
		if (contentTabs.Count >= 2)
		{
			WindowMetaTab activeTab = currentWindow.tabs.getActiveTab();
			int num = contentTabs.IndexOf(activeTab);
			switch (pAsset.id)
			{
			case "window_tab_next":
				num++;
				break;
			case "window_tab_previous":
			case "window_tab_previous_2":
				num--;
				break;
			}
			num = Toolbox.loopIndex(num, contentTabs.Count);
			WindowMetaTab windowMetaTab = contentTabs[num];
			windowMetaTab.doAction();
			WorldTip.showNowTop(windowMetaTab.getWorldTipText(), pTranslate: false);
		}
	}

	private bool navigateWindowBack(HotkeyAsset pAsset)
	{
		if (!ScrollWindow.isWindowActive())
		{
			return false;
		}
		if (ScrollWindow.isAnimationActive())
		{
			ScrollWindow.finishAnimations();
		}
		WindowHistory.clickBack();
		return true;
	}

	private bool navigateTabBack(HotkeyAsset pAsset)
	{
		if (ScrollWindow.isWindowActive())
		{
			return false;
		}
		if (!SelectedTabsHistory.showPreviousTab())
		{
			return false;
		}
		return true;
	}

	private void backAction(HotkeyAsset pAsset)
	{
		if (!navigateWindowBack(pAsset) && !navigateTabBack(pAsset) && !PowersTab.getActiveTab().getAsset().tab_type_main)
		{
			PowerTabController.showMainTab();
		}
	}

	private void escapeAction(HotkeyAsset pAsset)
	{
		if (World.world.console.isActive())
		{
			World.world.console.Hide();
		}
		else if (ControllableUnit.isControllingUnit())
		{
			ControllableUnit.clear();
		}
		else if (World.world.tutorial.isActive())
		{
			World.world.tutorial.endTutorial();
		}
		else
		{
			if (MapBox.controlsLocked() || MapBox.isControllingUnit())
			{
				return;
			}
			if (MoveCamera.hasFocusUnit())
			{
				MoveCamera.clearFocusUnitOnly();
			}
			else
			{
				if (navigateWindowBack(pAsset))
				{
					return;
				}
				if (Config.ui_main_hidden)
				{
					Config.ui_main_hidden = false;
				}
				else if (!navigateTabBack(pAsset))
				{
					if (World.world.selected_buttons.selectedButton != null)
					{
						World.world.selected_buttons.unselectAll();
					}
					else if (SelectedUnit.isSet())
					{
						SelectedUnit.clear();
					}
					else if (PowersTab.isTabSelected())
					{
						World.world.selected_buttons.unselectTabs();
						SelectedObjects.unselectNanoObject();
					}
					else
					{
						ScrollWindow.showWindow("quit_game");
					}
				}
			}
		}
	}

	private void powerMove(HotkeyAsset pAsset)
	{
		PowersTab activeTab = PowersTab.getActiveTab();
		switch (pAsset.id)
		{
		case "power_left":
			activeTab.leftButton();
			break;
		case "power_right":
			activeTab.rightButton();
			break;
		case "power_up":
			activeTab.upButton();
			break;
		case "power_down":
			activeTab.downButton();
			break;
		}
	}

	public override void linkAssets()
	{
		base.linkAssets();
		HashSet<KeyCode> hashSet = new HashSet<KeyCode>();
		HashSet<HotkeyAsset> hashSet2 = new HashSet<HotkeyAsset>();
		foreach (HotkeyAsset item in list)
		{
			item.overridden_key_1 = item.default_key_1;
			item.overridden_key_2 = item.default_key_2;
			item.overridden_key_3 = item.default_key_3;
			item.overridden_key_mod_1 = item.default_key_mod_1;
			item.overridden_key_mod_2 = item.default_key_mod_2;
			item.overridden_key_mod_3 = item.default_key_mod_3;
			if (item.default_key_mod_1 != KeyCode.None)
			{
				hashSet.Add(item.default_key_mod_1);
			}
			if (item.default_key_mod_2 != KeyCode.None)
			{
				hashSet.Add(item.default_key_mod_2);
			}
			if (item.default_key_mod_3 != KeyCode.None)
			{
				hashSet.Add(item.default_key_mod_3);
			}
			if (item.just_pressed_action != null)
			{
				hashSet2.Add(item);
			}
			else if (item.holding_action != null)
			{
				hashSet2.Add(item);
			}
		}
		mod_keys = hashSet.ToArray();
		action_hotkeys = hashSet2.ToArray();
	}

	public override void editorDiagnostic()
	{
		base.editorDiagnostic();
		Dictionary<string, HotkeyAsset> dictionary = new Dictionary<string, HotkeyAsset>();
		foreach (HotkeyAsset item in list)
		{
			if (item.ignore_same_key_diagnostic)
			{
				continue;
			}
			string text = "";
			if (item.check_window_active)
			{
				text += "ui+";
			}
			using ListPool<string> listPool = new ListPool<string>();
			bool flag = item.default_key_mod_1 != KeyCode.None;
			if (item.default_key_1 != KeyCode.None)
			{
				if (flag)
				{
					if (item.default_key_mod_1 != KeyCode.None)
					{
						listPool.Add(text + item.default_key_1.ToString() + "+" + item.default_key_mod_1);
					}
					if (item.default_key_mod_2 != KeyCode.None)
					{
						listPool.Add(text + item.default_key_1.ToString() + "+" + item.default_key_mod_2);
					}
					if (item.default_key_mod_3 != KeyCode.None)
					{
						listPool.Add(text + item.default_key_1.ToString() + "+" + item.default_key_mod_3);
					}
				}
				else
				{
					listPool.Add(text + item.default_key_1);
				}
			}
			if (item.default_key_2 != KeyCode.None)
			{
				if (flag)
				{
					if (item.default_key_mod_1 != KeyCode.None)
					{
						listPool.Add(text + item.default_key_2.ToString() + "+" + item.default_key_mod_1);
					}
					if (item.default_key_mod_2 != KeyCode.None)
					{
						listPool.Add(text + item.default_key_2.ToString() + "+" + item.default_key_mod_2);
					}
					if (item.default_key_mod_3 != KeyCode.None)
					{
						listPool.Add(text + item.default_key_2.ToString() + "+" + item.default_key_mod_3);
					}
				}
				else
				{
					listPool.Add(text + item.default_key_2);
				}
			}
			if (item.default_key_3 != KeyCode.None)
			{
				if (flag)
				{
					if (item.default_key_mod_1 != KeyCode.None)
					{
						listPool.Add(text + item.default_key_3.ToString() + "+" + item.default_key_mod_1);
					}
					if (item.default_key_mod_2 != KeyCode.None)
					{
						listPool.Add(text + item.default_key_3.ToString() + "+" + item.default_key_mod_2);
					}
					if (item.default_key_mod_3 != KeyCode.None)
					{
						listPool.Add(text + item.default_key_3.ToString() + "+" + item.default_key_mod_3);
					}
				}
				else
				{
					listPool.Add(text + item.default_key_3);
				}
			}
			foreach (ref string item2 in listPool)
			{
				string current2 = item2;
				if (dictionary.ContainsKey(current2))
				{
					BaseAssetLibrary.logAssetError("<e>" + item.id + "</e> has the same key as asset: <e>" + dictionary[current2].id + "</e>", current2);
				}
				else
				{
					dictionary.Add(current2, item);
				}
			}
		}
	}

	public static bool isHoldingControlForSelection()
	{
		if (!Input.GetKey(KeyCode.LeftControl))
		{
			return Input.GetKey(KeyCode.RightControl);
		}
		return true;
	}

	public static bool isHoldingAlt()
	{
		if (!Input.GetKey(KeyCode.LeftAlt))
		{
			return Input.GetKey(KeyCode.RightAlt);
		}
		return true;
	}

	public static bool isHoldingAnyMod()
	{
		if (AssetManager.hotkey_library == null)
		{
			return false;
		}
		return AssetManager.hotkey_library.isHoldingAnyModKey();
	}

	public void reset()
	{
		foreach (HotkeyAsset item in list)
		{
			item.overridden_key_1 = item.default_key_1;
			item.overridden_key_2 = item.default_key_2;
			item.overridden_key_3 = item.default_key_3;
			item.overridden_key_mod_1 = item.default_key_mod_1;
			item.overridden_key_mod_2 = item.default_key_mod_2;
			item.overridden_key_mod_3 = item.default_key_mod_3;
		}
	}

	public string replaceSpecialTextKeys(string pText)
	{
		if (!pText.Contains("$"))
		{
			return pText;
		}
		foreach (HotkeyAsset item in list)
		{
			if (pText.Contains(item.id))
			{
				string oldValue = "$" + item.id + "$";
				string localizedKeys = item.getLocalizedKeys();
				pText = pText.Replace(oldValue, localizedKeys);
				if (pText.Contains("$mouse_wheel$"))
				{
					string newValue = Toolbox.coloredText("mouse_wheel", "#95DD5D", pLocalize: true);
					pText = pText.Replace("$mouse_wheel$", newValue);
				}
				if (!pText.Contains("$"))
				{
					return pText;
				}
			}
		}
		return pText;
	}

	public bool isHoldingAnyModKey()
	{
		if (!Input.anyKey)
		{
			return false;
		}
		if (runModKeyCheck)
		{
			runModKeyCheck = false;
			holdingAnyModKey = false;
			KeyCode[] array = mod_keys;
			for (int i = 0; i < array.Length; i++)
			{
				if (Input.GetKey(array[i]))
				{
					holdingAnyModKey = true;
					break;
				}
			}
		}
		return holdingAnyModKey;
	}

	public void checkHotKeyActions()
	{
		runModKeyCheck = true;
		bool flag = Input.mouseScrollDelta.y != 0f;
		if (!World.world.has_focus || (!Input.anyKey && !flag))
		{
			return;
		}
		bool flag2 = isInputActive();
		bool flag3 = _last_input_active && !flag2;
		_last_input_active = flag2;
		if (flag2 || flag3)
		{
			return;
		}
		bool flag4 = MapBox.controlsLocked();
		bool flag5 = MapBox.isControllingUnit();
		HotkeyAsset[] array = action_hotkeys;
		foreach (HotkeyAsset hotkeyAsset in array)
		{
			if ((hotkeyAsset.use_mouse_wheel && !flag) || (hotkeyAsset.check_controls_locked && (flag4 || (flag5 && !hotkeyAsset.allow_unit_control))) || !hotkeyAsset.checkIsPossible())
			{
				continue;
			}
			if (hotkeyAsset.just_pressed_action != null && hotkeyAsset.isJustPressed())
			{
				hotkeyAsset.just_pressed_action(hotkeyAsset);
				if (hotkeyAsset.holding_action != null)
				{
					holding_times[hotkeyAsset.id] = hotkeyAsset.holding_cooldown_first_action;
				}
			}
			else if (hotkeyAsset.holding_action != null && hotkeyAsset.isHolding())
			{
				holding_times.TryGetValue(hotkeyAsset.id, out var value);
				value -= Time.deltaTime;
				if (value > 0f)
				{
					holding_times[hotkeyAsset.id] = value;
					continue;
				}
				hotkeyAsset.holding_action(hotkeyAsset);
				holding_times[hotkeyAsset.id] = hotkeyAsset.holding_cooldown;
			}
		}
	}

	private bool isInputActive()
	{
		if (!EventSystem.current.isFocused)
		{
			return false;
		}
		GameObject currentSelectedGameObject = EventSystem.current.currentSelectedGameObject;
		if (currentSelectedGameObject == null)
		{
			return false;
		}
		InputField component = currentSelectedGameObject.GetComponent<InputField>();
		if (component == null)
		{
			return false;
		}
		return component.isFocused;
	}

	public static bool allowedToUsePowers()
	{
		if (ScrollWindow.isWindowActive())
		{
			return false;
		}
		return true;
	}

	public void changeKey(HotkeyAsset pAsset, KeyCode pCode)
	{
	}

	public void load()
	{
	}

	public void hotkeySelectPower(HotkeyAsset pAsset, string pSelectPower)
	{
		if (!string.IsNullOrEmpty(pSelectPower) && AssetManager.powers.get(pSelectPower) == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(pSelectPower))
		{
			showTipNothing(pAsset);
			return;
		}
		PowerButton tPowerButton = PowerButton.get(pSelectPower);
		if (tPowerButton == null)
		{
			return;
		}
		if (tPowerButton.isSelected())
		{
			tPowerButton.cancelSelection();
			return;
		}
		tPowerButton.selectPowerTab(delegate
		{
			World.world.selected_buttons.clickPowerButton(tPowerButton);
			if (tPowerButton.isSelected())
			{
				WorldTip.instance.showToolbarText(tPowerButton.godPower);
			}
		});
	}

	public void hotkeySelectNano(HotkeyAsset pAsset, string pSelectNano)
	{
		if (string.IsNullOrEmpty(pSelectNano))
		{
			showTipNothing(pAsset);
			return;
		}
		string[] array = pSelectNano.Split("|");
		string text = array[0];
		long pId = long.Parse(array[1]);
		MetaTypeAsset metaTypeAsset = AssetManager.meta_type_library.get(text);
		NanoObject nanoObject = metaTypeAsset.get(pId);
		if (nanoObject.isRekt() && array.Length < 3)
		{
			showTipNothing(pAsset);
			return;
		}
		NanoObject selectedNanoObject = SelectedObjects.getSelectedNanoObject();
		if (SelectedObjects.isNanoObjectSet() && SelectedObjects.getSelectedNanoObject() == nanoObject)
		{
			if (selectedNanoObject == SelectedUnit.unit)
			{
				World.world.locatePosition(SelectedUnit.unit.current_position);
			}
			else if (nanoObject is IMetaObject)
			{
				Actor randomUnit = (nanoObject as IMetaObject).getRandomUnit();
				if (randomUnit != null)
				{
					World.world.locatePosition(randomUnit.current_position);
				}
			}
			return;
		}
		if (World.world.isAnyPowerSelected())
		{
			PowerButtonSelector.instance.unselectAll();
		}
		SelectedObjects.unselectNanoObject();
		SelectedUnit.clear();
		if (text == "unit")
		{
			if (array.Length >= 3)
			{
				using (ListPool<Actor> listPool = new ListPool<Actor>(array.Length))
				{
					for (int i = 1; i < array.Length; i++)
					{
						long pID = long.Parse(array[i]);
						Actor actor = World.world.units.get(pID);
						if (!actor.isRekt())
						{
							listPool.Add(actor);
						}
					}
					if (listPool.Count > 0)
					{
						SelectedUnit.selectMultiple(listPool);
						SelectedObjects.setNanoObject(SelectedUnit.unit);
						if (selectedNanoObject == SelectedUnit.unit)
						{
							World.world.locatePosition(SelectedUnit.unit.current_position);
						}
					}
					if (listPool.Count == 0)
					{
						showTipNothing(pAsset);
					}
					else if (listPool.Count == 1)
					{
						PowerTabController.showTabSelectedUnit();
					}
					else
					{
						PowerTabController.showTabMultipleUnits();
					}
					return;
				}
			}
			SelectedUnit.select(nanoObject as Actor);
			SelectedObjects.setNanoObject(SelectedUnit.unit);
			PowerTabController.showTabSelectedUnit();
		}
		else
		{
			metaTypeAsset.selectAndInspect(nanoObject, pFromNameplate: false, pCheckNameplate: false);
		}
	}

	public void showTipNothing(HotkeyAsset pAsset)
	{
		string text = LocalizedTextManager.getText("hotkey_tip_empty_tip");
		text = text.Replace("$save_hotkey$", "$save_" + pAsset.id + "$");
		text = AssetManager.hotkey_library.replaceSpecialTextKeys(text);
		WorldTip.instance.showToolbarText(text);
	}

	public void hotkeySavePower(HotkeyAsset pAsset)
	{
		string text = World.world.getSelectedPowerID();
		string text2 = pAsset.id.Replace("save_", "");
		string text3 = "";
		if (string.IsNullOrEmpty(text))
		{
			text = string.Empty;
			text3 = LocalizedTextManager.getText("hotkey_tip_cleared");
		}
		else
		{
			text3 = LocalizedTextManager.getText("hotkey_tip_saved_power");
		}
		text3 = text3.Replace("$save_hotkey$", "$" + text2 + "$");
		text3 = AssetManager.hotkey_library.replaceSpecialTextKeys(text3);
		WorldTip.instance.showToolbarText(text3);
		PlayerConfig.dict[text2].stringVal = text;
		PlayerConfig.saveData();
		getHotkeyFromData(text2) = string.Empty;
	}

	public void hotkeySaveTab(HotkeyAsset pAsset)
	{
		string text = pAsset.id.Replace("save_", "");
		string text2 = "";
		string text3;
		if (!SelectedObjects.isNanoObjectSet())
		{
			text2 = LocalizedTextManager.getText("hotkey_tip_cleared");
			text3 = string.Empty;
		}
		else
		{
			text2 = LocalizedTextManager.getText("hotkey_tip_saved_nano");
			NanoObject selectedNanoObject = SelectedObjects.getSelectedNanoObject();
			text3 = selectedNanoObject.getMetaTypeAsset().id ?? "";
			if (SelectedUnit.isSet())
			{
				foreach (Actor allSelected in SelectedUnit.getAllSelectedList())
				{
					text3 += $"|{allSelected.id}";
				}
			}
			else
			{
				text3 += $"|{selectedNanoObject.id}";
			}
		}
		text2 = text2.Replace("$save_hotkey$", "$" + text + "$");
		text2 = AssetManager.hotkey_library.replaceSpecialTextKeys(text2);
		getHotkeyFromData(text) = text3;
		WorldTip.instance.showToolbarText(text2);
	}

	public ref string getHotkeyFromData(string pHotkeyId)
	{
		return pHotkeyId switch
		{
			"hotkey_1" => ref World.world.hotkey_tabs_data.hotkey_data_1, 
			"hotkey_2" => ref World.world.hotkey_tabs_data.hotkey_data_2, 
			"hotkey_3" => ref World.world.hotkey_tabs_data.hotkey_data_3, 
			"hotkey_4" => ref World.world.hotkey_tabs_data.hotkey_data_4, 
			"hotkey_5" => ref World.world.hotkey_tabs_data.hotkey_data_5, 
			"hotkey_6" => ref World.world.hotkey_tabs_data.hotkey_data_6, 
			"hotkey_7" => ref World.world.hotkey_tabs_data.hotkey_data_7, 
			"hotkey_8" => ref World.world.hotkey_tabs_data.hotkey_data_8, 
			"hotkey_9" => ref World.world.hotkey_tabs_data.hotkey_data_9, 
			"hotkey_0" => ref World.world.hotkey_tabs_data.hotkey_data_0, 
			_ => ref World.world.hotkey_tabs_data.hotkey_data_1, 
		};
	}

	public void initDebugHotkeys()
	{
		initDebugHotkeysBase();
		initUnitDebugHotkeys();
		initDebugWindowHotkeys();
		add(new HotkeyAsset
		{
			id = "debug_autosave",
			default_key_1 = KeyCode.S,
			default_key_mod_1 = KeyCode.LeftAlt,
			just_pressed_action = debugAutosave
		});
		add(new HotkeyAsset
		{
			id = "debug_next_test_map",
			default_key_1 = KeyCode.PageUp,
			just_pressed_action = delegate
			{
				if (!SmoothLoader.isLoading())
				{
					World.world.transition_screen.startTransition(TestMaps.loadNextMap);
				}
			}
		});
		add(new HotkeyAsset
		{
			id = "debug_prev_test_map",
			default_key_1 = KeyCode.PageDown,
			just_pressed_action = delegate
			{
				if (!SmoothLoader.isLoading())
				{
					World.world.transition_screen.startTransition(TestMaps.loadPrevMap);
				}
			}
		});
	}

	private void initDebugHotkeysBase()
	{
		add(new HotkeyAsset
		{
			id = "export_unit_sprites",
			default_key_1 = KeyCode.Y,
			check_window_not_active = true,
			check_controls_locked = true,
			just_pressed_action = delegate
			{
				WorldTip.instance.showToolbarText("Exporting unit sprites");
				AssetManager.dynamic_sprites_library.export();
			}
		});
		add(new HotkeyAsset
		{
			id = "autotester",
			default_key_1 = KeyCode.U,
			check_window_not_active = true,
			check_controls_locked = true,
			just_pressed_action = delegate
			{
				World.world.auto_tester.toggleAutoTester();
			}
		});
		add(new HotkeyAsset
		{
			id = "test_zones_border_growth",
			default_key_1 = KeyCode.O,
			check_window_not_active = true,
			check_controls_locked = true,
			just_pressed_action = delegate
			{
				DebugZonesTool.actionGrowBorder();
			}
		});
		add(new HotkeyAsset
		{
			id = "test_zones_abandon_zones",
			default_key_1 = KeyCode.P,
			check_window_not_active = true,
			check_controls_locked = true,
			just_pressed_action = delegate
			{
				WorldTile[] tiles_list = World.world.tiles_list;
				foreach (WorldTile pTile in tiles_list)
				{
					World.world.buildings.addBuilding("poop", pTile);
				}
			}
		});
		add(new HotkeyAsset
		{
			id = "test_colors",
			default_key_1 = KeyCode.R,
			check_window_not_active = true,
			check_controls_locked = true,
			just_pressed_action = delegate
			{
				foreach (Kingdom kingdom in World.world.kingdoms)
				{
					kingdom.generateBanner();
					ColorAsset random = AssetManager.kingdom_colors_library.list.GetRandom();
					kingdom.data.setColorID(AssetManager.kingdom_colors_library.list.IndexOf(random));
					if (kingdom.updateColor(random))
					{
						World.world.zone_calculator.dirtyAndClear();
					}
				}
			}
		});
	}

	private void initDebugWindowHotkeys()
	{
		add(new HotkeyAsset
		{
			id = "debug_building_shadow_x_increase",
			default_key_1 = KeyCode.X,
			default_key_mod_1 = KeyCode.LeftControl,
			just_pressed_action = debugShadow,
			check_controls_locked = true,
			check_window_active = true,
			check_debug_active = true
		});
		clone("debug_building_shadow_x_reduce", "debug_building_shadow_x_increase");
		t.default_key_mod_1 = KeyCode.LeftShift;
		clone("debug_building_shadow_y_increase", "debug_building_shadow_x_increase");
		t.default_key_1 = KeyCode.Y;
		clone("debug_building_shadow_y_reduce", "debug_building_shadow_y_increase");
		t.default_key_mod_1 = KeyCode.LeftShift;
		clone("debug_building_shadow_distortion_increase", "debug_building_shadow_x_increase");
		t.default_key_1 = KeyCode.D;
		clone("debug_building_shadow_distortion_reduce", "debug_building_shadow_distortion_increase");
		t.default_key_mod_1 = KeyCode.LeftShift;
	}

	private void initUnitDebugHotkeys()
	{
		add(new HotkeyAsset
		{
			id = "debug_unit_set_task",
			default_key_1 = KeyCode.V,
			default_key_mod_1 = KeyCode.LeftControl,
			check_window_not_active = true,
			check_controls_locked = true,
			check_render_gameplay = true,
			check_debug_active = true,
			just_pressed_action = delegate
			{
				if (DebugConfig.isOn(DebugOption.DebugUnitHotkeys))
				{
					World.world.getActorNearCursor()?.addStatusEffect("budding");
				}
			}
		});
		add(new HotkeyAsset
		{
			id = "debug_general_key",
			default_key_1 = KeyCode.N,
			check_debug_active = true,
			just_pressed_action = delegate
			{
				if (!DebugConfig.isOn(DebugOption.DebugUnitHotkeys) || !SelectedUnit.isSet())
				{
					return;
				}
				using ListPool<Actor> listPool = new ListPool<Actor>(SelectedUnit.getAllSelected());
				foreach (ref Actor item in listPool)
				{
					item.getHitFullHealth(AttackType.Divine);
				}
			}
		});
		add(new HotkeyAsset
		{
			id = "debug_monolith",
			default_key_1 = KeyCode.M,
			default_key_mod_1 = KeyCode.LeftControl,
			check_window_not_active = true,
			check_controls_locked = true,
			check_render_gameplay = true,
			check_debug_active = true,
			just_pressed_action = delegate
			{
				if (!DebugConfig.isOn(DebugOption.DebugMonolith))
				{
					return;
				}
				foreach (Building building in World.world.buildings)
				{
					if (building.asset.id == "monolith")
					{
						BuildingMonolith component_monolith = building.component_monolith;
						component_monolith.doMonolithAction(component_monolith.building.current_tile, pForce: true);
					}
				}
			}
		});
	}

	private void debugAutosave(HotkeyAsset pAsset)
	{
		if (Config.isEditor)
		{
			AutoSaveManager.autoSave(pSkipDelete: true, pForce: true);
		}
	}

	private void debugShadow(HotkeyAsset pAsset)
	{
		if (!DebugConfig.isOn(DebugOption.DebugWindowHotkeys) || ScrollWindow.getCurrentWindow().name != "building_asset")
		{
			return;
		}
		BuildingAsset asset = BaseDebugAssetWindow<BuildingAsset, BuildingDebugAssetElement>.current_element.asset;
		if (asset.shadow)
		{
			switch (pAsset.id)
			{
			case "debug_building_shadow_x_increase":
				asset.shadow_bound.x += 0.05f;
				break;
			case "debug_building_shadow_x_reduce":
				asset.shadow_bound.x -= 0.05f;
				break;
			case "debug_building_shadow_y_increase":
				asset.shadow_bound.y += 0.05f;
				break;
			case "debug_building_shadow_y_reduce":
				asset.shadow_bound.y -= 0.05f;
				break;
			case "debug_building_shadow_distortion_increase":
				asset.shadow_distortion += 0.05f;
				break;
			case "debug_building_shadow_distortion_reduce":
				asset.shadow_distortion -= 0.05f;
				break;
			}
			Debug.Log("t.setShadow(" + asset.shadow_bound.x.ToString(CultureInfo.InvariantCulture) + "f, " + asset.shadow_bound.y.ToString(CultureInfo.InvariantCulture) + "f, " + asset.shadow_distortion.ToString(CultureInfo.InvariantCulture) + "f);");
			BuildingAssetWindow.reloadSprites();
		}
	}

	public void debug(DebugTool pTool)
	{
		foreach (HotkeyAsset item in list)
		{
			if (item.just_pressed_action == null && item.holding_action == null)
			{
				if (item.isJustPressed())
				{
					pTool.setText(item.id, "just_pressed", 0f, pShowBar: false, 0L);
				}
				if (item.isHolding())
				{
					pTool.setText(item.id, "holding", 0f, pShowBar: false, 0L);
				}
			}
		}
	}
}
