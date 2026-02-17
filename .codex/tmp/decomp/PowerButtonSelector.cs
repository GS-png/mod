using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class PowerButtonSelector : MonoBehaviour
{
	private const float TOOLBAR_TEMP_SHOW_DURATION = 1f;

	private const float TOOLBAR_TEMP_SHOW_ALPHA = 0.5f;

	public GameObject buttonSelectionSprite;

	public GameObject buttonUnlocked;

	public GameObject buttonUnlockedFlash;

	public GameObject buttonUnlockedFlashNew;

	[SerializeField]
	private CanvasGroup _toolbar_canvas_group;

	public UiMover cancelUnitSelectedMover;

	public UiMover cancelButtMover;

	public UiMover sizeButtMover;

	public UiMover clockButtMover;

	public UiMover bottomElementsMover;

	public UiMover spectateUnitMover;

	public UiMover pauseButtonMover;

	public UiMover unhideButtonMover;

	public PowerButton clockButton;

	public PowerButton sizeButton;

	public CancelButton cancelButton;

	public PowerButton pauseButton;

	public PowerButton pauseButton2;

	public PowerButton cityInfo;

	public PowerButton cityZones;

	public PowerButton boatMarks;

	public PowerButton kingsAndLeaders;

	public PowerButton historyLog;

	public PowerButton followUnit;

	public GameObject joy_control_cancel_button;

	[SerializeField]
	private Image _joy_control_cancel_button_icon;

	private Coroutine _toolbar_hide_routine;

	private bool _is_toolbar_temp_showed;

	internal PowerButton selectedButton;

	public GameObject buttons;

	internal static PowerButtonSelector instance;

	private void Awake()
	{
		instance = this;
	}

	private void Start()
	{
		clockButtMover.setVisible(pVisible: false, pNow: true);
		sizeButtMover.setVisible(pVisible: false, pNow: true);
		cancelButtMover.setVisible(pVisible: false, pNow: true);
		cancelUnitSelectedMover.setVisible(pVisible: false, pNow: true);
		toggleBottomElements(pState: false, pNow: true);
		spectateUnitMover.setVisible(pVisible: false, pNow: true);
		resetToolbarTempShow();
	}

	internal void checkToggleIcons()
	{
		Color color = new Color(0.7f, 0.7f, 0.7f, 1f);
		foreach (PowerButton toggle_button in PowerButton.toggle_buttons)
		{
			toggle_button.checkToggleIcon();
			if (toggle_button.godPower.option_asset.isActive())
			{
				toggle_button.icon.color = Color.white;
			}
			else
			{
				toggle_button.icon.color = color;
			}
		}
	}

	public virtual void setSelectedPower(PowerButton pButton, GodPower pPower, bool pAnim = false)
	{
		if (!(selectedButton == null))
		{
			_ = selectedButton.godPower;
			selectedButton.setSelectedPower(pButton);
			selectedButton.newClickAnimation();
		}
	}

	public void setPower(PowerButton pButton)
	{
		selectedButton = pButton;
		if (selectedButton != null && selectedButton.godPower != null)
		{
			Config.debug_last_selected_power_button = selectedButton.godPower.id;
			if (selectedButton.godPower.type == PowerActionType.PowerSpawnActor)
			{
				ActorAsset actorAsset = selectedButton.godPower.getActorAsset();
				if (actorAsset.has_sound_spawn)
				{
					MusicBox.playSoundUI(actorAsset.sound_spawn);
				}
			}
		}
		if (selectedButton != null)
		{
			cancelButton.setIconFrom(selectedButton);
			LogText.log("Power Selected", pButton.godPower.id);
		}
		if (pButton == null)
		{
			PowerTracker.setPower(null);
		}
		else
		{
			PowerTracker.setPower(pButton.godPower);
		}
	}

	public void unselectTabs()
	{
		if (PowersTab.isTabSelected())
		{
			SelectedObjects.unselectNanoObject();
			PowersTab.unselect();
			SelectedTabsHistory.clear();
		}
	}

	public void unselectAll()
	{
		if (selectedButton != null)
		{
			selectedButton.unselectActivePower();
			setPower(null);
			clearHighlightedButton();
			WorldTip.instance.startHide();
		}
		if (ControllableUnit.isControllingUnit())
		{
			ControllableUnit.clear();
		}
		if (MoveCamera.hasFocusUnit())
		{
			MoveCamera.clearFocusUnitOnly();
		}
	}

	public bool isPowerSelected()
	{
		return selectedButton != null;
	}

	public bool isPowerSelected(PowerButton pButton)
	{
		return selectedButton == pButton;
	}

	public void clickPowerButton(PowerButton pButton)
	{
		if (!pButton.canSelect())
		{
			if (!InputHelpers.mouseSupported)
			{
				showToolbarText(pButton);
			}
			return;
		}
		if (selectedButton == pButton)
		{
			unselectAll();
			return;
		}
		if (selectedButton != null)
		{
			selectedButton.unselectActivePower();
		}
		if (pButton.godPower.select_button_action != null && pButton.godPower.select_button_action(pButton.godPower.id))
		{
			return;
		}
		setPower(pButton);
		if (selectedButton != null)
		{
			highlightButton(selectedButton);
			if (selectedButton.godPower != null)
			{
				Config.logSelectedPower(selectedButton.godPower);
			}
		}
		if (InputHelpers.mouseSupported)
		{
			showToolbarText(pButton);
		}
		Analytics.LogEvent("select_power", "powerID", pButton.godPower.id);
	}

	public void showToolbarText(PowerButton pButton)
	{
		WorldTip.instance.showToolbarText(pButton.godPower);
	}

	internal void highlightButton(PowerButton pButton)
	{
		if (!(pButton == null))
		{
			buttonSelectionSprite.SetActive(value: true);
			RectTransform obj = (RectTransform)buttonSelectionSprite.transform;
			obj.position = pButton.transform.position;
			obj.SetParent(pButton.transform.parent);
			obj.localScale = Vector3.one;
			obj.sizeDelta = pButton.rect_transform.sizeDelta;
		}
	}

	internal void clearHighlightedButton()
	{
		buttonSelectionSprite.SetActive(value: false);
	}

	private void Update()
	{
		updateSelectedPowerButtons();
		updateHideUiButton();
		updateSelectedUnitCancelButton();
	}

	private bool isSpecialTabActive()
	{
		if (SelectedUnit.isSet())
		{
			return true;
		}
		if (SelectedObjects.isNanoObjectSet())
		{
			return true;
		}
		return false;
	}

	private void updateSelectedUnitCancelButton()
	{
		if (!World.world.isAnyPowerSelected() && isSpecialTabActive() && !ScrollWindow.isWindowActive())
		{
			cancelUnitSelectedMover.setVisible(pVisible: true);
		}
		else
		{
			cancelUnitSelectedMover.setVisible(pVisible: false);
		}
	}

	private void updateHideUiButton()
	{
		if (Config.ui_main_hidden)
		{
			unhideButtonMover.setVisible(pVisible: true);
		}
		else
		{
			unhideButtonMover.setVisible(pVisible: false);
		}
	}

	private void updateSelectedPowerButtons()
	{
		PowerButton powerButton = selectedButton;
		GodPower godPower = ((powerButton != null) ? powerButton.godPower : null);
		if (powerButton == null)
		{
			cancelButtMover.setVisible(pVisible: false);
		}
		else if (ScrollWindow.isWindowActive())
		{
			cancelButtMover.setVisible(pVisible: false);
		}
		else
		{
			cancelButtMover.setVisible(pVisible: true);
		}
		bool flag = MoveCamera.inSpectatorMode();
		if (powerButton == null || ScrollWindow.isWindowActive() || flag)
		{
			sizeButtMover.setVisible(pVisible: false);
			sizeButton.hideSizes();
			if (flag)
			{
				clockButtMover.setVisible(pVisible: true);
			}
			else
			{
				clockButtMover.setVisible(pVisible: false);
				clockButton.hideSizes();
			}
		}
		else
		{
			powerButton.animate(Time.deltaTime);
			if (godPower.show_tool_sizes)
			{
				sizeButtMover.setVisible(pVisible: true);
			}
			else
			{
				sizeButtMover.setVisible(pVisible: false);
				sizeButton.hideSizes();
			}
			if (selectedButton.godPower.id == "clock")
			{
				clockButtMover.setVisible(pVisible: true);
			}
			else
			{
				clockButtMover.setVisible(pVisible: false);
				clockButton.hideSizes();
			}
		}
		if (CanvasMain.isBottomBarShowing())
		{
			toggleBottomElements(pState: true);
			if (_is_toolbar_temp_showed)
			{
				resetToolbarTempShow();
			}
		}
		else if (!_is_toolbar_temp_showed)
		{
			toggleBottomElements(pState: false);
		}
		pauseButtonMover.setVisible(flag);
		spectateUnitMover.setVisible(flag);
		updateTopButtons();
	}

	private void updateTopButtons()
	{
		if (bottomElementsMover.visible)
		{
			cancelButton.goDown = false;
			cancelButton.goUp = false;
			cancelButton.gameObject.SetActive(value: true);
			PremiumElementsChecker.checkElements();
			bool active = DebugConfig.isOn(DebugOption.DebugButton);
			DebugConfig.instance.debugButton.SetActive(active);
			clockButton.GetComponent<CancelButton>().goDown = false;
			joy_control_cancel_button.SetActive(value: false);
			return;
		}
		if (ControllableUnit.isControllingUnit())
		{
			cancelButton.gameObject.SetActive(value: false);
			PremiumElementsChecker.toggleActive(pState: false);
			DebugConfig.instance.debugButton.SetActive(value: false);
			joy_control_cancel_button.SetActive(value: true);
			Sprite spriteIcon = ControllableUnit.getControllableUnit().getActorAsset().getSpriteIcon();
			_joy_control_cancel_button_icon.sprite = spriteIcon;
		}
		bool flag = MoveCamera.inSpectatorMode();
		cancelButton.goDown = flag || (ControllableUnit.isControllingUnit() && !Config.joyControls);
		clockButton.GetComponent<CancelButton>().goDown = flag;
	}

	private void toggleBottomElements(bool pState, bool pNow = false)
	{
		TweenCallback pCompleteCallback = null;
		if (!pState)
		{
			pCompleteCallback = delegate
			{
				buttons.SetActive(value: false);
				resetToolbarCanvasGroup();
			};
		}
		else
		{
			buttons.SetActive(value: true);
		}
		bottomElementsMover.setVisible(pState, pNow, pCompleteCallback);
	}

	public void showBarTemporary()
	{
		if (Config.game_loaded)
		{
			if (_toolbar_hide_routine != null)
			{
				StopCoroutine(_toolbar_hide_routine);
			}
			_is_toolbar_temp_showed = true;
			_toolbar_canvas_group.blocksRaycasts = false;
			_toolbar_canvas_group.alpha = 0.5f;
			toggleBottomElements(pState: true);
			_toolbar_hide_routine = StartCoroutine(toolbarHideRoutine());
		}
	}

	private IEnumerator toolbarHideRoutine()
	{
		yield return new WaitForSeconds(1f);
		toggleBottomElements(pState: false);
		_is_toolbar_temp_showed = false;
	}

	private void resetToolbarCanvasGroup()
	{
		_toolbar_canvas_group.blocksRaycasts = true;
		_toolbar_canvas_group.alpha = 1f;
	}

	private void resetToolbarTempShow()
	{
		resetToolbarCanvasGroup();
		_is_toolbar_temp_showed = false;
		if (_toolbar_hide_routine != null)
		{
			StopCoroutine(_toolbar_hide_routine);
		}
	}
}
