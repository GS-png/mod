using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class WindowToolbar : MonoBehaviour, IShakable
{
	private const int REFERENCE_HEIGHT = 1080;

	private const int HIDE_DISTANCE_MIN = 225;

	private const int HIDE_DISTANCE_MAX = 440;

	private const float FOCUS_SCROLL_TOP_ERROR = 0.5f;

	private const float FOCUS_SCROLL_BOTTOM_ERROR = 0.1f;

	private const float FOCUS_SCROLL_BUTTON_ERROR = 0.5f;

	private const float FOCUS_SCROLL_DURATION = 0.3f;

	private static WindowToolbar _instance;

	private UiMover _ui_mover;

	private Transform _content;

	private RectTransform _parent_rect;

	private CanvasGroup _canvas_group;

	[SerializeField]
	private ScrollRectExtended _scroll_rect;

	[SerializeField]
	private RectTransform _content_rect;

	[SerializeField]
	private RectTransform _windows_parent;

	[SerializeField]
	private Transform _selector_base_parent;

	[SerializeField]
	private Transform _selector;

	private float _ui_size_min;

	private float _ui_size_max;

	private Dictionary<string, Transform> _window_buttons = new Dictionary<string, Transform>();

	public bool _last_state;

	public float shake_duration { get; } = 0.5f;

	public float shake_strength { get; } = 8f;

	public Tweener shake_tween { get; set; }

	private void Awake()
	{
		_instance = this;
		_ui_mover = GetComponent<UiMover>();
		_content = base.transform.FindRecursive("Content");
		_canvas_group = GetComponent<CanvasGroup>();
		_parent_rect = base.transform.parent.GetComponent<RectTransform>();
		ScrollWindow.addCallbackShow(delegate
		{
			toggleShow(pState: true);
		});
		ScrollWindow.addCallbackClose(delegate
		{
			toggleShow(pState: false);
		});
		OptionAsset optionAsset = AssetManager.options_library.get("ui_size_windows");
		_ui_size_min = (float)optionAsset.min_value / 100f;
		_ui_size_max = (float)optionAsset.max_value / 100f;
		_ui_mover.initPos.y = -6f;
		_ui_mover.hidePos.y = -6f;
		Vector3 localPosition = base.transform.localPosition;
		localPosition.y = -6f;
		base.transform.localPosition = localPosition;
		PowerButton[] componentsInChildren = GetComponentsInChildren<PowerButton>();
		foreach (PowerButton powerButton in componentsInChildren)
		{
			if (powerButton.type == PowerButtonType.Window)
			{
				_window_buttons.Add(powerButton.open_window_id, powerButton.transform);
			}
		}
		ScrollWindow.addCallbackShow(checkSelectOnWindowShow);
		ScrollWindow.addCallbackHide(checkDeselectOnWindowHide);
	}

	private void Start()
	{
		CanvasMain.instance.addCallbackResize(onResize);
		CanvasMain.instance.addCallbackResizeUI(checkShow);
	}

	private void OnDisable()
	{
		((IShakable)this).killShakeTween();
	}

	private void onResize(float pWidth, float pHeight)
	{
		float pUISize = (float)PlayerConfig.getOptionInt("ui_size_windows") / 100f;
		checkShow(pUISize);
	}

	private void checkShow(float pUISize)
	{
		if (isHideDistance(pUISize))
		{
			toggleShow(pState: false);
		}
		else if (ScrollWindow.isWindowActive())
		{
			toggleShow(pState: true);
		}
	}

	public static void toggleActive(bool pState)
	{
		_instance.toggleActiveInstance(pState);
	}

	private void toggleActiveInstance(bool pState)
	{
		if (pState)
		{
			base.gameObject.SetActive(value: true);
			if (ScrollWindow.isWindowActive())
			{
				toggleShow(pState: true);
			}
			else
			{
				_ui_mover.setVisible(pVisible: false, pNow: true);
			}
		}
		else
		{
			_ui_mover.setVisible(pVisible: false, pNow: false, delegate
			{
				base.gameObject.SetActive(value: false);
			});
		}
	}

	private void toggleShow(bool pState)
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		if (pState)
		{
			float pUISize = (float)PlayerConfig.getIntValue("ui_size_windows") / 100f;
			if (isHideDistance(pUISize))
			{
				pState = false;
			}
			else if (!AssetManager.window_library.get(ScrollWindow.getCurrentWindow().screen_id).window_toolbar_enabled)
			{
				pState = false;
			}
		}
		_last_state = pState;
		_canvas_group.blocksRaycasts = pState;
		if (pState)
		{
			_content.gameObject.SetActive(value: true);
		}
		TweenCallback pCompleteCallback = null;
		if (!pState)
		{
			pCompleteCallback = delegate
			{
				_content.gameObject.SetActive(_last_state);
			};
		}
		_ui_mover.setVisible(pState, pNow: false, pCompleteCallback);
	}

	public static void shake()
	{
		((IShakable)_instance).shake();
	}

	private bool isPortrait()
	{
		return false;
	}

	private bool isHideDistance(float pUISize)
	{
		if (!ScrollWindow.isWindowActive())
		{
			return true;
		}
		float t = Mathf.InverseLerp(_ui_size_min, _ui_size_max, pUISize);
		float num = (float)Screen.height / 1080f;
		float num2 = Mathf.Lerp(225f, 440f, t) * num;
		float xMin = _windows_parent.WorldRect().xMin;
		float xMin2 = _parent_rect.WorldRect().xMin;
		return xMin - xMin2 < num2;
	}

	private void checkSelectOnWindowShow(string pWindowId)
	{
		if (!_window_buttons.TryGetValue(pWindowId, out var value))
		{
			pWindowId = AssetManager.window_library.get(pWindowId).related_parent_window;
			if (string.IsNullOrEmpty(pWindowId) || !_window_buttons.TryGetValue(pWindowId, out value))
			{
				return;
			}
		}
		_selector.SetParent(value);
		_selector.localPosition = Vector3.zero;
		_selector.localScale = Vector3.one;
		scrollToButton(value);
	}

	private void scrollToButton(Transform pButtonTransform)
	{
		Rect worldRect = _scroll_rect.rectTransform.GetWorldRect();
		float yMax = worldRect.yMax;
		Rect worldRect2 = _content_rect.GetWorldRect();
		float height = worldRect2.height;
		Rect worldRect3 = ((RectTransform)pButtonTransform).GetWorldRect();
		float num = pButtonTransform.position.y - worldRect2.yMax + yMax;
		Vector2 vector = new Vector2(0f, worldRect3.height * 0.5f);
		if (!worldRect.Contains(worldRect3.position - vector) || !worldRect.Contains(worldRect3.max + vector))
		{
			float num2 = (num - worldRect3.height / 0.5f) / height;
			float value = (float)PlayerConfig.getOptionInt("ui_size_windows") / 100f;
			float num3 = 1f - Mathf.InverseLerp(_ui_size_min, _ui_size_max, value);
			if (num2 > 1f - (0.5f - num3))
			{
				num2 = 1f;
			}
			else if (num2 < 0.1f + num3)
			{
				num2 = 0f;
			}
			DOTween.To(() => _scroll_rect.verticalScrollbar.value, delegate(float pValue)
			{
				_scroll_rect.verticalScrollbar.value = pValue;
			}, num2, 0.3f);
		}
	}

	private void checkDeselectOnWindowHide(string pWindowId)
	{
		_selector.SetParent(_selector_base_parent);
	}

	Transform IShakable.get_transform()
	{
		return base.transform;
	}
}
