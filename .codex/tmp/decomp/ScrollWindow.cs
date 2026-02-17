using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ScrollWindow : MonoBehaviour, IShakable
{
	public const int WINDOW_POSITION_Y = -6;

	private const float SCROLLBAR_POSITION_SHOW = 0f;

	private const float SCROLLBAR_POSITION_HIDE = -17.2f;

	private const float SCROLLBAR_ANIMATION_DURATION = 0.35f;

	private const float SCROLLBAR_ANIMATION_DURATION_COLOR = 0.35f;

	private const float SCROLLBAR_ANIMATION_DELAY = 0.25f;

	private const float SCROLLBAR_ANIMATION_DELAY_COLOR = 0.125f;

	private const string SCROLLBAR_ACTIVE_COLOR = "#E75340";

	private const string SCROLLBAR_INACTIVE_COLOR = "#545454";

	private static ScrollWindowNameAction _open_callback;

	private static ScrollWindowNameAction _show_started_callback;

	private static ScrollWindowNameAction _show_callback;

	private static ScrollWindowNameAction _show_finished_callback;

	private static ScrollWindowNameAction _hide_callback;

	private static ScrollWindowAction _close_callback;

	private static ScrollWindow _current_window = null;

	private static Dictionary<string, ScrollWindow> _all_windows = new Dictionary<string, ScrollWindow>();

	private static bool _is_window_active = false;

	private static bool _is_any_window_active = false;

	public string screen_id = "screen";

	public bool unselectPower = true;

	private Canvas _canvas;

	private CanvasGroup _canvas_group;

	private RectTransform _bg_rect;

	public Text titleText;

	[SerializeField]
	private GameObject _back_button_container;

	[SerializeField]
	private Button _back_button;

	public Image previous_window_icon;

	private static string _queued_window = "";

	public ScrollRect scrollRect;

	public Image scrollingGradient;

	public RectTransform transform_content;

	public RectTransform transform_viewport;

	public RectTransform transform_scrollRect;

	public GameObject[] destroyOnAwake;

	public bool force_gradient;

	public bool historyActionEnabled = true;

	private static bool _should_clear;

	public List<Sprite> close_sprites;

	public Image close_background;

	private int _current_background_sprite_index;

	[SerializeField]
	private TipButton _close_button_tip;

	public WindowMetaTabButtonsContainer tabs;

	public static bool skip_worldtip_hide;

	private static List<Tweener> _animations_list = new List<Tweener>();

	private Tweener _animation_tween;

	private WindowAsset _asset;

	private bool _scrollbar_cached_state;

	private Tweener _scrollbar_tweener;

	private Tweener _scrollbar_tweener_color;

	private Coroutine _scrollbar_routine;

	private bool _initialized;

	public float shake_duration { get; } = 0.5f;

	public float shake_strength { get; } = 8f;

	public Tweener shake_tween { get; set; }

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool isWindowActive()
	{
		return _is_window_active;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool isAnimationActive()
	{
		return _animations_list.Count > 0;
	}

	private void Awake()
	{
		init();
	}

	public void init()
	{
		if (_initialized)
		{
			return;
		}
		_asset = AssetManager.window_library.get(screen_id);
		_canvas_group = base.gameObject.GetComponent<CanvasGroup>();
		_bg_rect = base.gameObject.transform.GetChild(0).GetComponent<RectTransform>();
		if (destroyOnAwake != null)
		{
			GameObject[] array = destroyOnAwake;
			for (int i = 0; i < array.Length; i++)
			{
				UnityEngine.Object.Destroy(array[i]);
			}
		}
		initComponents();
	}

	private void OnEnable()
	{
		WorldTip.hideNow();
	}

	private void Start()
	{
		if (_canvas == null)
		{
			create(pHide: true);
		}
		toggleScrollbar(pState: false);
	}

	private void Update()
	{
		updateScrollbar();
		updateRightClickBack();
	}

	private void updateRightClickBack()
	{
		if (InputHelpers.GetMouseButtonDown(1) && canGoBackWithRightClick())
		{
			WindowHistory.clickBack();
		}
	}

	private bool canGoBackWithRightClick()
	{
		if (!historyActionEnabled)
		{
			return false;
		}
		if (Config.isDraggingItem())
		{
			return false;
		}
		if (!InputHelpers.mouseSupported)
		{
			return false;
		}
		if (World.world.isOverUiButton())
		{
			return false;
		}
		return true;
	}

	private void updateScrollbar()
	{
		Scrollbar verticalScrollbar = scrollRect.verticalScrollbar;
		bool flag = !Mathf.Approximately(verticalScrollbar.size, 1f);
		if (_scrollbar_cached_state != flag)
		{
			_scrollbar_cached_state = flag;
			toggleScrollbar(pState: true);
			checkGradient();
			_scrollbar_tweener_color.Kill();
			_scrollbar_tweener_color = DOTweenModuleUI.DOColor(endValue: (!_scrollbar_cached_state) ? Toolbox.makeColor("#545454") : Toolbox.makeColor("#E75340"), target: verticalScrollbar.image, duration: 0.35f);
			if (!_scrollbar_cached_state)
			{
				_scrollbar_tweener_color.SetDelay(0.125f);
			}
			if (_scrollbar_routine != null)
			{
				StopCoroutine(_scrollbar_routine);
			}
			_scrollbar_routine = StartCoroutine(toggleScrollbarRoutine());
		}
	}

	private IEnumerator toggleScrollbarRoutine()
	{
		yield return new WaitForSecondsRealtime(0.25f);
		if (!(scrollRect.verticalScrollbar.size < 1f))
		{
			toggleScrollbar(pState: false);
		}
	}

	private void toggleScrollbar(bool pState)
	{
		Scrollbar verticalScrollbar = scrollRect.verticalScrollbar;
		_scrollbar_tweener.Kill();
		float endValue = (pState ? 0f : (-17.2f));
		_scrollbar_tweener = verticalScrollbar.transform.DOLocalMoveX(endValue, 0.35f).SetEase(Ease.InOutCubic);
	}

	public void resetScroll()
	{
		Vector3 localPosition = transform_content.localPosition;
		localPosition.y = 0f;
		transform_content.localPosition = localPosition;
	}

	internal void create(bool pHide = false)
	{
		_canvas = CanvasMain.instance.canvas_windows;
		if (historyActionEnabled)
		{
			_back_button.onClick.AddListener(WindowHistory.clickBack);
		}
		else
		{
			_back_button_container.gameObject.SetActive(value: false);
		}
		if (pHide)
		{
			hide("right", pPlaySound: false);
			finishTween();
		}
		checkGradient();
	}

	private void checkGradient()
	{
		if (force_gradient || _scrollbar_cached_state)
		{
			scrollingGradient.gameObject.SetActive(value: true);
		}
		else
		{
			scrollingGradient.gameObject.SetActive(value: false);
		}
	}

	public void clickBack()
	{
		WindowHistory.clickBack();
	}

	private static void setCurrentWindow(ScrollWindow pWindow)
	{
		if (!(pWindow == null))
		{
			_current_window = pWindow;
			_is_window_active = true;
			if (!_is_any_window_active)
			{
				_open_callback?.Invoke(pWindow.screen_id);
			}
			_is_any_window_active = true;
			_show_callback?.Invoke(pWindow.screen_id);
		}
	}

	private static void clearCurrentWindow(ScrollWindow pWindow)
	{
		if (!(_current_window == null))
		{
			_hide_callback?.Invoke(_current_window.screen_id);
			_current_window = null;
			_is_window_active = false;
			Config.debug_window_stats.setCurrent(null);
		}
	}

	public static void queueWindow(string pWindowID)
	{
		_queued_window = pWindowID;
	}

	public static void clearQueue()
	{
		if (_queued_window != "")
		{
			string queued_window = _queued_window;
			_queued_window = "";
			hideAllEvent(pWithAnimation: false);
			showWindow(queued_window);
		}
	}

	public static void showWindow(string pWindowID)
	{
		showWindow(pWindowID, pSkipAnimation: false, pBlockSame: false);
	}

	public static void showWindow(string pWindowID, bool pSkipAnimation = false, bool pBlockSame = false)
	{
		World.world.selected_buttons.clearHighlightedButton();
		if (!isAnimationActive())
		{
			bool pJustCreated = checkWindowExist(pWindowID);
			ScrollWindow scrollWindow = _all_windows[pWindowID];
			if (pBlockSame && pWindowID == _current_window.screen_id)
			{
				((IShakable)scrollWindow).shake();
				WindowToolbar.shake();
				randomDropHoveringIcon(3, 6);
			}
			else
			{
				scrollWindow.clickShow(pSkipAnimation, pJustCreated);
			}
		}
	}

	public static void randomDropHoveringIcon(int pMin, int pMax)
	{
		int num = Randy.randomInt(pMin, pMax);
		for (int i = 0; i < num; i++)
		{
			HoveringBgIconManager.randomDrop();
		}
	}

	public static string checkWindowID(string pWindowID)
	{
		if (pWindowID.StartsWith("worldnet", StringComparison.Ordinal))
		{
			return "not_found";
		}
		return pWindowID;
	}

	public static bool windowLoaded(string pWindowID)
	{
		string key = checkWindowID(pWindowID);
		return _all_windows.ContainsKey(key);
	}

	public static bool checkWindowExist(string pWindowID)
	{
		string text = checkWindowID(pWindowID);
		bool result = false;
		if (!_all_windows.ContainsKey(pWindowID))
		{
			result = true;
			string path = "windows/" + text;
			if (!WindowPreloader.TryGetPreloadedWindow(pWindowID, out var tScrollWindow))
			{
				ScrollWindow scrollWindow = (ScrollWindow)Resources.Load(path, typeof(ScrollWindow));
				if (scrollWindow == null)
				{
					Debug.LogError("Window with id " + text + " not found!");
					scrollWindow = (ScrollWindow)Resources.Load("windows/not_found", typeof(ScrollWindow));
				}
				ListPool<GameObject> pTabsObjects = disableTabsInPrefab(scrollWindow);
				tScrollWindow = UnityEngine.Object.Instantiate(scrollWindow, CanvasMain.instance.transformWindows);
				enableTabsInPrefab(pTabsObjects);
			}
			if (!_all_windows.ContainsKey(pWindowID))
			{
				_all_windows.Add(pWindowID, tScrollWindow);
			}
			tScrollWindow.screen_id = pWindowID;
			tScrollWindow.name = pWindowID;
			tScrollWindow.create();
		}
		return result;
	}

	public static ListPool<GameObject> disableTabsInPrefab(ScrollWindow pPrefab)
	{
		ListPool<GameObject> listPool = new ListPool<GameObject>();
		if (pPrefab.tabs != null)
		{
			WindowMetaTab[] array = pPrefab.tabs.transform.FindAllRecursive<WindowMetaTab>();
			for (int i = 0; i < array.Length; i++)
			{
				foreach (Transform tab_element in array[i].tab_elements)
				{
					if (!(tab_element == null) && tab_element.gameObject.activeSelf)
					{
						tab_element.gameObject.SetActive(value: false);
						listPool.Add(tab_element.gameObject);
					}
				}
			}
		}
		return listPool;
	}

	public static void enableTabsInPrefab(ListPool<GameObject> pTabsObjects)
	{
		foreach (ref GameObject pTabsObject in pTabsObjects)
		{
			pTabsObject.gameObject.SetActive(value: true);
		}
		pTabsObjects.Dispose();
	}

	public static ScrollWindow get(string pWindowID)
	{
		checkWindowExist(pWindowID);
		return _all_windows[pWindowID];
	}

	public void clickShow(bool pSkipAnimation = false, bool pJustCreated = false)
	{
		if (!isAnimationActive())
		{
			LogText.log("Window Opened", screen_id);
			if (_current_window == this)
			{
				showSameWindow();
				return;
			}
			moveAllToLeftAndRemove();
			show("right", "right", pSkipAnimation, pJustCreated);
		}
	}

	public void clickShowLeft()
	{
		if (!isAnimationActive())
		{
			LogText.log("Window Opened", screen_id);
			if (_current_window == this)
			{
				showSameWindow();
				return;
			}
			moveAllToRightAndRemove();
			show("left", "left");
		}
	}

	public void forceShow()
	{
		show("right", "right", pSkipAnimation: true);
	}

	public void show(string pDistPosition = "right", string pStartPosition = "right", bool pSkipAnimation = false, bool pJustCreated = false)
	{
		setActive(pActive: true, pDistPosition, pStartPosition, pSkipAnimation, pJustCreated);
		CanvasMain.addTooltipShowTimeout(0.01f);
		if (screen_id == "PremiumPurchaseError")
		{
			Analytics.LogEvent("purchase_premium_error");
		}
		Analytics.trackWindow(screen_id);
		historyAction();
		PowerTracker.trackWindow(screen_id, this);
		MusicBox.playSoundUI("event:/SFX/UI/WindowWhoosh");
	}

	private void historyAction()
	{
		if (historyActionEnabled)
		{
			if (WindowHistory.hasHistory())
			{
				_back_button_container.SetActive(value: true);
				Sprite sprite = WindowHistory.list.Last().window._asset.getSprite();
				previous_window_icon.sprite = sprite;
				_close_button_tip.text_description_2 = "";
			}
			else
			{
				_back_button_container.SetActive(value: false);
				_close_button_tip.text_description_2 = "hotkey_cancel";
			}
			WindowHistory.addIntoHistory(this);
		}
	}

	public static void moveAllToLeftAndRemove(bool pWithAnimation = true)
	{
		if (_current_window != null)
		{
			if (pWithAnimation)
			{
				_current_window.moveToLeft(pRemove: true);
			}
			else
			{
				_current_window.activeToFalse();
			}
			_hide_callback?.Invoke(_current_window.screen_id);
			_current_window = null;
		}
		_is_window_active = false;
		Config.debug_window_stats.setCurrent(null);
	}

	public static bool isCurrentWindow(string pWindowID)
	{
		if (_current_window == null)
		{
			return false;
		}
		return _current_window.screen_id == pWindowID;
	}

	public static ScrollWindow getCurrentWindow()
	{
		if (!isWindowActive())
		{
			return null;
		}
		return _current_window;
	}

	public static void setPreviousWindowSprite(Sprite pSprite)
	{
		if (isWindowActive())
		{
			getCurrentWindow().previous_window_icon.sprite = pSprite;
		}
	}

	public static void moveAllToRightAndRemove(bool pWithAnimation = true)
	{
		if (_current_window != null)
		{
			if (pWithAnimation)
			{
				_current_window.moveToRight(pRemove: true);
			}
			else
			{
				_current_window.activeToFalse();
			}
			_hide_callback?.Invoke(_current_window.screen_id);
			_current_window = null;
		}
		_is_window_active = false;
		Config.debug_window_stats.setCurrent(null);
	}

	public void moveToLeft(bool pRemove = false)
	{
		setCanvasGroupEnabled(_canvas_group, pValue: false);
		if (pRemove)
		{
			float pToX = base.transform.localPosition.x + getHidePosLeft();
			moveTween(pToX, activeToFalse);
		}
	}

	public void moveToRight(bool pRemove = false)
	{
		setCanvasGroupEnabled(_canvas_group, pValue: false);
		if (pRemove)
		{
			float pToX = base.transform.localPosition.x - getHidePosLeft();
			moveTween(pToX, activeToFalse);
		}
	}

	public static void setCanvasGroupEnabled(CanvasGroup pGroup, bool pValue)
	{
		pGroup.interactable = pValue;
		pGroup.blocksRaycasts = pValue;
	}

	public void showSameWindow()
	{
		sameWindowTween(0f, finishTween);
		historyAction();
		clearCurrentWindow(this);
		_show_started_callback?.Invoke(screen_id);
		base.gameObject.SetActive(value: false);
		base.gameObject.SetActive(value: true);
		setCurrentWindow(this);
		Tooltip.hideTooltipNow();
		resetScroll();
	}

	public void setActive(bool pActive, string pDistPosition = "right", string pStartPosition = "right", bool pSkipAnimation = false, bool pJustCreated = false)
	{
		if (skip_worldtip_hide)
		{
			skip_worldtip_hide = false;
		}
		else
		{
			WorldTip.hideNow();
		}
		Tooltip.hideTooltipNow();
		if (unselectPower && World.world.selected_buttons.selectedButton != null && World.world.selected_buttons.selectedButton.godPower.unselect_when_window)
		{
			World.world.selected_buttons.unselectAll();
		}
		if (pActive)
		{
			setCanvasGroupEnabled(_canvas_group, pValue: true);
			_show_started_callback?.Invoke(screen_id);
			base.gameObject.SetActive(value: true);
			setCurrentWindow(this);
			resetScroll();
			if (!(pStartPosition == "right"))
			{
				if (pStartPosition == "left")
				{
					base.transform.localPosition = new Vector3(getHidePosLeft(), -6f, base.transform.localPosition.z);
				}
			}
			else
			{
				base.transform.localPosition = new Vector3(getHidePosRight(), -6f, base.transform.localPosition.z);
			}
			if (pSkipAnimation)
			{
				finishTween();
				base.transform.localPosition = new Vector3(0f, 0f, 0f);
			}
			else
			{
				moveTween(0f, finishTween, pJustCreated);
			}
		}
		else
		{
			clearCurrentWindow(this);
			if (pDistPosition == "left")
			{
				float hidePosLeft = getHidePosLeft();
				moveTween(hidePosLeft, activeToFalse, pJustCreated);
			}
			else
			{
				moveTween(getHidePosRight(), activeToFalse, pJustCreated);
			}
		}
	}

	protected void moveTween(float pToX = 0f, TweenCallback pCompleteCallback = null, bool pJustCreated = false)
	{
		float duration = 0.35f;
		Ease ease = Ease.OutBack;
		if (pCompleteCallback == null)
		{
			pCompleteCallback = finishTween;
		}
		if (pCompleteCallback == new TweenCallback(activeToFalse))
		{
			duration = 0.1f;
			ease = Ease.Linear;
		}
		Vector3 endValue = new Vector3(pToX, -6f, base.transform.localPosition.z);
		_animation_tween.Kill(complete: true);
		float delay = 0.02f;
		if (pJustCreated)
		{
			delay = 0.1f;
		}
		_animation_tween = base.transform.DOLocalMove(endValue, duration).SetDelay(delay).SetEase(ease)
			.OnComplete(delegate
			{
				pCompleteCallback();
				_animations_list.Remove(_animation_tween);
			});
		_animations_list.Add(_animation_tween);
	}

	protected void sameWindowTween(float pToX = 0f, TweenCallback pCompleteCallback = null)
	{
		float duration = 0.09f;
		if (pCompleteCallback == null)
		{
			pCompleteCallback = finishTween;
		}
		base.transform.localPosition = new Vector3(0f, -4f, 0f);
		Vector3 endValue = new Vector3(pToX, -6f, base.gameObject.transform.localPosition.z);
		_animation_tween.Kill(complete: true);
		_animation_tween = base.transform.DOLocalMove(endValue, duration).SetEase(Ease.InOutSine).OnComplete(delegate
		{
			pCompleteCallback();
			_animations_list.Remove(_animation_tween);
		});
		_animations_list.Add(_animation_tween);
	}

	public static void hideAllEvent(bool pWithAnimation = true)
	{
		if (isWindowActive())
		{
			_should_clear = true;
			_close_callback?.Invoke();
			moveAllToLeftAndRemove(pWithAnimation);
		}
		Tooltip.hideTooltipNow();
		World.world.player_control.controls_lock_timer = 0.1f;
		PowerTracker.trackWatching();
	}

	public void clickCloseButton(string pDirection = "right")
	{
		clickHide(pDirection);
		_current_background_sprite_index++;
		if (_current_background_sprite_index >= close_sprites.Count)
		{
			_current_background_sprite_index = close_sprites.Count - 1;
		}
		close_background.sprite = close_sprites[_current_background_sprite_index];
	}

	public void clickHide(string pDirection = "right")
	{
		if (canClickHide())
		{
			hide(pDirection);
			World.world.selected_buttons.gameObject.SetActive(value: true);
			_should_clear = true;
			_close_callback?.Invoke();
			World.world.player_control.controls_lock_timer = 0.3f;
			PowerTracker.trackWatching();
		}
	}

	internal static void checkElements()
	{
		if (!isWindowActive())
		{
			return;
		}
		ScrollWindow currentWindow = getCurrentWindow();
		bool flag = currentWindow.shouldClose();
		bool flag2 = false;
		if (!flag)
		{
			flag2 = currentWindow.shouldRefresh();
		}
		if (flag || flag2)
		{
			if (currentWindow.TryGetComponent<TabbedWindow>(out var component))
			{
				component.StopAllCoroutines();
			}
			WindowMetaElementBase[] componentsInChildren = currentWindow.GetComponentsInChildren<WindowMetaElementBase>(includeInactive: false);
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].StopAllCoroutines();
			}
		}
		if (flag)
		{
			hideAllEvent(pWithAnimation: false);
		}
		else if (flag2)
		{
			WindowHistory.popHistory();
			currentWindow.showSameWindow();
		}
	}

	public bool shouldClose()
	{
		if (TryGetComponent<TabbedWindow>(out var component) && component.checkCancelWindow())
		{
			return true;
		}
		return false;
	}

	public bool shouldRefresh()
	{
		IShouldRefreshWindow[] componentsInChildren = GetComponentsInChildren<IShouldRefreshWindow>(includeInactive: false);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			if (componentsInChildren[i].checkRefreshWindow())
			{
				return true;
			}
		}
		return false;
	}

	private void OnDisable()
	{
		if (_should_clear)
		{
			_should_clear = false;
			WindowHistory.clear();
			clear();
			_is_any_window_active = false;
			Config.debug_window_stats.setCurrent(null);
		}
		((IShakable)this).killShakeTween();
	}

	internal static void clear()
	{
		foreach (MetaTypeAsset item in AssetManager.meta_type_library.list)
		{
			item.window_action_clear?.Invoke();
		}
		NanoObject selectedNanoObject = SelectedObjects.getSelectedNanoObject();
		if (!selectedNanoObject.isRekt())
		{
			AssetManager.meta_type_library.getAsset(selectedNanoObject.getMetaType()).selectAndInspect(selectedNanoObject, pFromNameplate: false, pCheckNameplate: true, pClearAction: true);
		}
	}

	public static bool canClickHide()
	{
		if (WorkshopUploadingWorldWindow.uploading)
		{
			return false;
		}
		return true;
	}

	public void hide(string pDirection = "right", bool pPlaySound = true)
	{
		LogText.log("Window Hide", screen_id);
		setActive(pActive: false, pDirection);
		CanvasMain.addTooltipShowTimeout(0.01f);
		setCanvasGroupEnabled(_canvas_group, pValue: false);
		if (pPlaySound)
		{
			MusicBox.playSoundUI("event:/SFX/UI/WindowClose");
		}
		Analytics.hideWindow();
	}

	public static void finishAnimations()
	{
		using ListPool<Tweener> listPool = new ListPool<Tweener>(_animations_list);
		listPool.Sort(delegate(Tweener p1, Tweener p2)
		{
			float num = p1.Duration() * p1.ElapsedPercentage();
			float value = p2.Duration() * p2.ElapsedPercentage();
			return num.CompareTo(value);
		});
		foreach (ref Tweener item in listPool)
		{
			item.Kill(complete: true);
		}
	}

	public void finishTween()
	{
		_show_finished_callback?.Invoke(screen_id);
	}

	public void activeToFalse()
	{
		base.gameObject.SetActive(value: false);
	}

	public float getHidePosRight()
	{
		return _canvas.GetComponent<RectTransform>().sizeDelta.x / 2f + _bg_rect.sizeDelta.x / 2f + _bg_rect.sizeDelta.x * 0.2f;
	}

	public float getHidePosLeft()
	{
		return getHidePosRight() * -1f;
	}

	public float getHidePosLeftHalf()
	{
		float num = (_canvas.GetComponent<RectTransform>().sizeDelta.x - _bg_rect.sizeDelta.x) / 2f;
		return getHidePosLeft() + num / 2f;
	}

	public float getDistBetweenWindows()
	{
		return getHidePosLeftHalf();
	}

	public void openConsole()
	{
		World.world.console.Show();
	}

	public static void addCallbackOpen(ScrollWindowNameAction pAction)
	{
		_open_callback = (ScrollWindowNameAction)Delegate.Combine(_open_callback, pAction);
	}

	public static void removeCallbackOpen(ScrollWindowNameAction pAction)
	{
		_open_callback = (ScrollWindowNameAction)Delegate.Remove(_open_callback, pAction);
	}

	public static void addCallbackShowStarted(ScrollWindowNameAction pAction)
	{
		_show_started_callback = (ScrollWindowNameAction)Delegate.Combine(_show_started_callback, pAction);
	}

	public static void removeCallbackShowStarted(ScrollWindowNameAction pAction)
	{
		_show_started_callback = (ScrollWindowNameAction)Delegate.Remove(_show_started_callback, pAction);
	}

	public static void addCallbackShow(ScrollWindowNameAction pAction)
	{
		_show_callback = (ScrollWindowNameAction)Delegate.Combine(_show_callback, pAction);
	}

	public static void removeCallbackShow(ScrollWindowNameAction pAction)
	{
		_show_callback = (ScrollWindowNameAction)Delegate.Remove(_show_callback, pAction);
	}

	public static void addCallbackShowFinished(ScrollWindowNameAction pAction)
	{
		_show_finished_callback = (ScrollWindowNameAction)Delegate.Combine(_show_finished_callback, pAction);
	}

	public static void removeCallbackShowFinished(ScrollWindowNameAction pAction)
	{
		_show_finished_callback = (ScrollWindowNameAction)Delegate.Remove(_show_finished_callback, pAction);
	}

	public static void addCallbackHide(ScrollWindowNameAction pAction)
	{
		_hide_callback = (ScrollWindowNameAction)Delegate.Combine(_hide_callback, pAction);
	}

	public static void removeCallbackHide(ScrollWindowNameAction pAction)
	{
		_hide_callback = (ScrollWindowNameAction)Delegate.Remove(_hide_callback, pAction);
	}

	public static void addCallbackClose(ScrollWindowAction pAction)
	{
		_close_callback = (ScrollWindowAction)Delegate.Combine(_close_callback, pAction);
	}

	public static void removeCallbackClose(ScrollWindowAction pAction)
	{
		_close_callback = (ScrollWindowAction)Delegate.Remove(_close_callback, pAction);
	}

	private void initComponents()
	{
	}

	public static void debug(DebugTool pTool)
	{
		if (isWindowActive())
		{
			pTool.setText("currentWindow:", getCurrentWindow().screen_id, 0f, pShowBar: false, 0L);
			pTool.setText("historyActionEnabled:", getCurrentWindow().historyActionEnabled, 0f, pShowBar: false, 0L);
		}
		pTool.setText("_is_window_active:", _is_window_active, 0f, pShowBar: false, 0L);
		pTool.setText("_is_any_window_active:", _is_any_window_active, 0f, pShowBar: false, 0L);
		pTool.setText("isAnimationActive:", isAnimationActive(), 0f, pShowBar: false, 0L);
		pTool.setText("queuedWindow:", _queued_window, 0f, pShowBar: false, 0L);
	}

	Transform IShakable.get_transform()
	{
		return base.transform;
	}
}
