using System;
using UnityEngine;
using UnityEngine.UI;

public class TooltipDebugHelper
{
	private static GameObject _debug_canvas;

	public static void checkCreate()
	{
		if (DebugConfig.isOn(DebugOption.DebugTooltipUI))
		{
			MapBox.on_world_loaded = (Action)Delegate.Combine(MapBox.on_world_loaded, new Action(loadButtons));
			HotkeyAsset cancel = HotkeyLibrary.cancel;
			cancel.just_pressed_action = (HotkeyAction)Delegate.Combine(cancel.just_pressed_action, new HotkeyAction(killButtons));
		}
	}

	public static void killButtons(HotkeyAsset pAsset)
	{
		UnityEngine.Object.Destroy(_debug_canvas);
		_debug_canvas = null;
	}

	public static void loadButtons()
	{
		_debug_canvas = new GameObject("Canvas Debug", typeof(RectTransform));
		RectTransform component = _debug_canvas.GetComponent<RectTransform>();
		component.SetParent(CanvasMain.instance.canvas_ui.transform, worldPositionStays: true);
		component.anchorMin = new Vector2(0f, 0f);
		component.anchorMax = new Vector2(1f, 1f);
		component.offsetMin = new Vector2(0f, 0f);
		component.offsetMax = new Vector2(0f, 0f);
		component.localScale = new Vector3(1f, 1f, 1f);
		GridLayoutGroup gridLayoutGroup = component.AddComponent<GridLayoutGroup>();
		gridLayoutGroup.cellSize = new Vector2(28f, 28f);
		gridLayoutGroup.spacing = new Vector2(2f, 2f);
		using ListPool<PowerButton> listPool = new ListPool<PowerButton>(PowerButton.power_buttons.Count + PowerButton.toggle_buttons.Count);
		listPool.AddRange(PowerButton.power_buttons);
		listPool.AddRange(PowerButton.toggle_buttons);
		for (int i = 0; i < 9; i++)
		{
			listPool.Shuffle();
			foreach (ref PowerButton item in listPool)
			{
				PowerButton current = item;
				current.gameObject.SetActive(value: false);
				PowerButton powerButton = UnityEngine.Object.Instantiate(current, component);
				powerButton.transform.name = current.transform.name;
				powerButton.destroyLockIcon();
				IconRotationAnimation iconRotationAnimation = powerButton.gameObject.AddComponent<IconRotationAnimation>();
				iconRotationAnimation.delay = Randy.randomFloat(1f, 10f);
				iconRotationAnimation.randomDelay = true;
				current.gameObject.SetActive(value: true);
				powerButton.gameObject.SetActive(value: true);
			}
		}
	}
}
