using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PowerButton : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IInitializePotentialDragHandler, IScrollHandler
{
	public bool drag_power_bar;

	public string open_window_id = string.Empty;

	public bool block_same_window;

	public Image icon;

	private Image _image;

	private Button _button;

	public PowerButtonType type;

	public GameObject sizeButtons;

	public PowerButton mainSizeButton;

	internal GodPower godPower;

	private Image _icon_lock;

	public GameObject buttonUnlocked;

	public GameObject buttonUnlockedFlash;

	public static List<PowerButton> power_buttons = new List<PowerButton>();

	public static List<PowerButton> toggle_buttons = new List<PowerButton>();

	public static Dictionary<ActorAsset, PowerButton> actor_spawn_buttons = new Dictionary<ActorAsset, PowerButton>();

	internal RectTransform rect_transform;

	internal PowerButton left;

	internal PowerButton right;

	internal PowerButton down;

	internal PowerButton up;

	private Vector3 _default_scale;

	private Vector3 _clicked_scale;

	[HideInInspector]
	public bool is_selectable = true;

	private bool _initialized;

	private PowerButtonSelector _selected_buttons => PowerButtonSelector.instance;

	public static PowerButton get(string pID)
	{
		for (int i = 0; i < power_buttons.Count; i++)
		{
			PowerButton powerButton = power_buttons[i];
			if (powerButton.gameObject.name == pID)
			{
				return powerButton;
			}
		}
		return null;
	}

	private void init()
	{
		rect_transform = GetComponent<RectTransform>();
		_image = GetComponent<Image>();
		_button = GetComponent<Button>();
		if (type == PowerButtonType.Special || type == PowerButtonType.Active)
		{
			power_buttons.Add(this);
			godPower = AssetManager.powers.get(base.gameObject.name);
		}
		else if (type == PowerButtonType.Shop)
		{
			godPower = AssetManager.powers.get(base.gameObject.name);
		}
		if (godPower == null)
		{
			return;
		}
		if (godPower.disabled_on_mobile && Config.isMobile)
		{
			base.gameObject.SetActive(value: false);
			return;
		}
		if (type == PowerButtonType.Active)
		{
			GodPower.addPower(godPower, this);
		}
		if (godPower.toggle_action != null)
		{
			toggle_buttons.Add(this);
		}
		if (isActorSpawn())
		{
			ActorAsset actorAsset = godPower.getActorAsset();
			if (!actorAsset.isAvailable())
			{
				icon.color = Toolbox.color_black;
			}
			actor_spawn_buttons.TryAdd(actorAsset, this);
		}
	}

	private void OnEnable()
	{
		if (_initialized)
		{
			return;
		}
		_initialized = true;
		init();
		_default_scale = base.transform.localScale;
		_clicked_scale = _default_scale * 0.9f;
		if (type == PowerButtonType.Active && godPower != null)
		{
			if (base.gameObject.name.Contains("Button"))
			{
				Color color = new Color(0.5f, 0.5f, 0.5f, 1f);
				_image.color = color;
				icon.color = color;
			}
			else
			{
				godPower.id = base.gameObject.transform.name;
			}
		}
		if (!this.HasComponent<TipButton>())
		{
			_button.OnHover(showTooltip);
			_button.OnHoverOut(Tooltip.hideTooltip);
		}
	}

	public void OnPointerClick(PointerEventData pEventData)
	{
		if (!draggingBarEnabled() || !ScrollRectExtended.isAnyDragged())
		{
			if (!InputHelpers.mouseSupported && !Tooltip.isShowingFor(this) && (type == PowerButtonType.Active || type == PowerButtonType.Special) && PowerButtonSelector.instance.selectedButton != this)
			{
				showTooltip();
			}
			clickButton();
		}
	}

	internal void clickButton()
	{
		newClickAnimation();
		playSound();
		if ((type == PowerButtonType.Active || type == PowerButtonType.Library || type == PowerButtonType.Special) && (godPower == null || godPower.track_activity))
		{
			PowerTracker.trackPower(getText());
		}
		if (type == PowerButtonType.Active)
		{
			clickActivePower();
		}
		if (type == PowerButtonType.BrushSizeMain)
		{
			clickSizeMainTool();
		}
		if (type == PowerButtonType.TimeScale)
		{
			clickTimeScaleTool();
		}
		if (type == PowerButtonType.Shop)
		{
			clickShop();
		}
		if (type == PowerButtonType.Special)
		{
			clickSpecial();
		}
		if (type == PowerButtonType.Window)
		{
			clickOpenWindow();
		}
	}

	private void showTooltip()
	{
		if (InputHelpers.mouseSupported && !Config.tooltips_active)
		{
			return;
		}
		if (godPower != null)
		{
			TooltipData tooltipData = new TooltipData();
			if ((Config.isComputer || Config.isEditor) && godPower.multiple_spawn_tip && type != PowerButtonType.Shop)
			{
				tooltipData.tip_description_2 = "hotkey_many_mod";
			}
			tooltipData.tip_name = godPower.getLocaleID();
			tooltipData.tip_description = godPower.getDescriptionID();
			switch (godPower.type)
			{
			case PowerActionType.PowerSpawnActor:
				tooltipData.power = godPower;
				Tooltip.show(this, "unit_spawn", tooltipData);
				break;
			case PowerActionType.PowerSpawnSeeds:
				tooltipData.power = godPower;
				Tooltip.show(this, "biome_seed", tooltipData);
				break;
			default:
				Tooltip.show(this, "normal", tooltipData);
				break;
			}
		}
		else
		{
			string text = getText();
			string description = getDescription();
			if (text == "")
			{
				return;
			}
			if (description != "")
			{
				Tooltip.show(this, "normal", new TooltipData
				{
					tip_name = text,
					tip_description = description
				});
			}
			else
			{
				Tooltip.show(this, "tip", new TooltipData
				{
					tip_name = text
				});
			}
		}
		base.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
		base.transform.DOKill();
		base.transform.DOScale(1f, 0.1f).SetEase(Ease.InBack);
	}

	private string getText()
	{
		if (godPower != null)
		{
			return godPower.getLocaleID();
		}
		string text = _button.name.Underscore();
		if (LocalizedTextManager.stringExists("button_" + text))
		{
			return "button_" + text;
		}
		if (LocalizedTextManager.stringExists(text))
		{
			return text;
		}
		return "";
	}

	private string getDescription()
	{
		if (godPower != null)
		{
			return godPower.getDescriptionID();
		}
		string text = _button.name.Underscore();
		if (LocalizedTextManager.stringExists("button_" + text + "_description"))
		{
			return "button_" + text + "_description";
		}
		if (LocalizedTextManager.stringExists(text + "_description"))
		{
			return text + "_description";
		}
		return "";
	}

	private void clickOpenWindow()
	{
		if (open_window_id == "steam" && (Config.isComputer || Config.isEditor))
		{
			open_window_id = "steam_workshop_main";
		}
		if (ScrollWindow.isAnimationActive() && !ScrollWindow.isCurrentWindow(open_window_id))
		{
			ScrollWindow.finishAnimations();
		}
		PowerButtonSelector.instance.clearHighlightedButton();
		showWindow(open_window_id, block_same_window);
	}

	internal void clickSpecial()
	{
		Analytics.LogEvent("select_power", "powerID", godPower.id);
		if (godPower.id == "pause")
		{
			GetComponent<PauseButton>().press();
		}
		if (godPower.toggle_action != null)
		{
			godPower.toggle_action(godPower.id);
			PowerButtonSelector.instance.unselectAll();
			PowerButtonSelector.instance.checkToggleIcons();
		}
	}

	public void checkToggleIcon()
	{
		GodPower godPower = this.godPower;
		if (godPower == null || string.IsNullOrEmpty(godPower.toggle_name))
		{
			return;
		}
		OptionAsset option_asset = this.godPower.option_asset;
		bool flag = option_asset.isActive();
		int num = 0;
		bool pEnabled = flag;
		bool pEnabled2 = flag;
		bool pEnabled3 = flag;
		ToggleIcon toggleIcon = null;
		ToggleIcon toggleIcon2 = null;
		ToggleIcon toggleIcon3 = null;
		ToggleIcon toggleIcon4 = null;
		toggleIcon = base.transform.Find("ToggleIcon")?.GetComponent<ToggleIcon>();
		if (godPower.multi_toggle)
		{
			num = option_asset.current_int_value;
			toggleIcon2 = base.transform.Find("toggle_0")?.GetComponent<ToggleIcon>();
			toggleIcon3 = base.transform.Find("toggle_1")?.GetComponent<ToggleIcon>();
			toggleIcon4 = base.transform.Find("toggle_2")?.GetComponent<ToggleIcon>();
			switch (option_asset.max_value)
			{
			case 2:
				pEnabled = num == 0;
				pEnabled2 = num == 1;
				pEnabled3 = num == 2;
				break;
			case 1:
				pEnabled = num == 0;
				pEnabled3 = num == 1;
				break;
			default:
				pEnabled = flag;
				pEnabled2 = flag;
				pEnabled3 = flag;
				break;
			}
		}
		toggleIcon?.updateIcon(flag);
		if (godPower.multi_toggle)
		{
			toggleIcon2?.updateIconMultiToggle(flag, pEnabled3);
			toggleIcon3?.updateIconMultiToggle(flag, pEnabled);
			toggleIcon4?.updateIconMultiToggle(flag, pEnabled2);
		}
	}

	private void playSound()
	{
		SoundBox.click();
	}

	public void checkLockIcon()
	{
		if (type == PowerButtonType.Shop)
		{
			return;
		}
		if (godPower != null && godPower.requires_premium)
		{
			if (_icon_lock == null)
			{
				_icon_lock = Object.Instantiate(PrefabLibrary.instance.iconLock, base.transform);
				_icon_lock.enabled = true;
			}
			if (buttonUnlocked == null)
			{
				buttonUnlocked = Object.Instantiate(PowerButtonSelector.instance.buttonUnlockedFlashNew, base.transform);
				buttonUnlocked.transform.position = base.transform.position;
				buttonUnlocked.SetActive(value: false);
				buttonUnlocked.transform.SetSiblingIndex(0);
				buttonUnlocked.GetComponent<RectTransform>().pivot = GetComponent<RectTransform>().pivot;
			}
			if (buttonUnlockedFlash == null)
			{
				buttonUnlockedFlash = Object.Instantiate(PowerButtonSelector.instance.buttonUnlockedFlash, base.transform);
				buttonUnlockedFlash.transform.position = base.transform.position;
				buttonUnlockedFlash.SetActive(value: false);
				buttonUnlockedFlash.transform.SetSiblingIndex(0);
				buttonUnlockedFlash.GetComponent<RectTransform>().pivot = GetComponent<RectTransform>().pivot;
			}
		}
		if (!(_icon_lock == null))
		{
			if (godPower == null)
			{
				_icon_lock.enabled = false;
			}
			else if (Config.hasPremium)
			{
				_icon_lock.enabled = false;
			}
			else
			{
				_icon_lock.enabled = true;
			}
		}
	}

	public void showOthers()
	{
		Debug.Log("other");
	}

	public bool isSelected()
	{
		return _selected_buttons.isPowerSelected(this);
	}

	public void cancelSelection()
	{
		_selected_buttons.unselectAll();
	}

	public void unselectActivePower()
	{
		if (base.gameObject.activeInHierarchy)
		{
			StartCoroutine(angleToZero());
		}
		else
		{
			icon.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
		}
	}

	public void hideSizes()
	{
		sizeButtons.SetActive(value: false);
	}

	private void clickSizeMainTool()
	{
		sizeButtons.SetActive(!sizeButtons.activeSelf);
	}

	public void clickTimeScaleTool()
	{
		sizeButtons.SetActive(value: false);
		Config.setWorldSpeed(base.transform.name);
		mainSizeButton.newClickAnimation();
		World.world.player_control.inspect_timer_click = 1f;
	}

	private void clickActivePower()
	{
		_selected_buttons.clickPowerButton(this);
	}

	public bool canSelect()
	{
		if (!is_selectable)
		{
			return false;
		}
		if (!isActorSpawn())
		{
			return true;
		}
		if (godPower.getActorAsset().isAvailable())
		{
			return true;
		}
		return false;
	}

	private void clickShop()
	{
		WorldTip.showNow(LocalizedTextManager.getText(godPower.getLocaleID()) + "\n" + LocalizedTextManager.getText(godPower.getDescriptionID()), pTranslate: false, "top");
	}

	public void setSelectedPower(PowerButton pLibraryButton, bool pAnim = false)
	{
		godPower = pLibraryButton.godPower;
	}

	public void newClickAnimation()
	{
		base.gameObject.transform.localScale = _clicked_scale;
		base.gameObject.transform.DOScale(_default_scale, 0.1f).SetEase(Ease.InOutBack);
	}

	protected IEnumerator angleToZero()
	{
		while (icon.transform.localEulerAngles.z != 0f)
		{
			Vector3 localEulerAngles = icon.transform.localEulerAngles;
			localEulerAngles.z -= 100f * Time.deltaTime;
			if (localEulerAngles.z < 0f)
			{
				localEulerAngles.z = 0f;
			}
			icon.transform.localEulerAngles = localEulerAngles;
			yield return null;
		}
	}

	public void animate(float pElapsed)
	{
		if (icon.transform.localEulerAngles.z < 20f)
		{
			Vector3 localEulerAngles = icon.transform.localEulerAngles;
			localEulerAngles.z += 100f * pElapsed;
			if (localEulerAngles.z > 20f)
			{
				localEulerAngles.z = 20f;
			}
			icon.transform.localEulerAngles = localEulerAngles;
		}
	}

	public void destroyLockIcon()
	{
		if (buttonUnlocked != null)
		{
			Object.Destroy(buttonUnlocked);
		}
		if (buttonUnlockedFlash != null)
		{
			Object.Destroy(buttonUnlockedFlash);
		}
		if (_icon_lock != null)
		{
			Object.Destroy(_icon_lock.gameObject);
			return;
		}
		Transform transform = base.transform.Find("IconLock");
		if (transform != null)
		{
			Object.Destroy(transform.gameObject);
			transform = null;
			return;
		}
		transform = base.transform.Find("IconLock(Clone)");
		if (transform != null)
		{
			Object.Destroy(transform.gameObject);
		}
	}

	public void showWindow(string pID, bool pBlockSame)
	{
		if (!ScrollWindow.isAnimationActive())
		{
			ScrollWindow.showWindow(pID, pSkipAnimation: false, pBlockSame);
		}
	}

	public void showWindow(string pID)
	{
		ScrollWindow.showWindow(pID, pSkipAnimation: false, pBlockSame: false);
	}

	public void selectPowerTab(TweenCallback pOnComplete = null)
	{
		if (!base.transform.parent.gameObject.activeInHierarchy)
		{
			Button tabForTabGroup = PowerTabController.instance.getTabForTabGroup(base.transform.parent.name);
			if (tabForTabGroup != null)
			{
				PowersTab.showTabFromButton(tabForTabGroup);
			}
		}
		RectTransform rectTransform = base.transform.parent.parent.parent as RectTransform;
		float width = rectTransform.rect.width;
		float num = (float)Screen.width / CanvasMain.instance.canvas_ui.scaleFactor;
		float value = 0f - base.transform.localPosition.x + 32f + num / 2f;
		float min = 0f;
		if (width > num)
		{
			min = -1f * (width - num);
		}
		value = Mathf.Clamp(value, min, 0f);
		ScrollRectExtended tScrollRect = rectTransform.GetComponentInParent<ScrollRectExtended>();
		tScrollRect.movementType = ScrollRectExtended.MovementType.Clamped;
		if (pOnComplete == null)
		{
			rectTransform.DOLocalMoveX(value, 1.5f).SetEase(Ease.OutBack).SetDelay(0.3f)
				.OnComplete(delegate
				{
					tScrollRect.StopMovement();
					tScrollRect.movementType = ScrollRectExtended.MovementType.Elastic;
				});
			return;
		}
		rectTransform.DOLocalMoveX(value, 0.125f).SetEase(Ease.OutBack).OnComplete(delegate
		{
			tScrollRect.StopMovement();
			tScrollRect.movementType = ScrollRectExtended.MovementType.Elastic;
			pOnComplete();
		});
	}

	internal void findNeighbours(List<PowerButton> pButtons, bool pCheckForActive = false)
	{
		Vector2 anchoredPosition = rect_transform.anchoredPosition;
		if (anchoredPosition.y == -2f)
		{
			anchoredPosition.y = 16f;
		}
		foreach (PowerButton pButton in pButtons)
		{
			if (pButton == this || (pCheckForActive && !pButton.gameObject.activeSelf))
			{
				continue;
			}
			Vector2 anchoredPosition2 = pButton.rect_transform.anchoredPosition;
			if (anchoredPosition2.y == -2f)
			{
				anchoredPosition2.y = 16f;
			}
			if (anchoredPosition2.y == anchoredPosition.y)
			{
				if (anchoredPosition2.x < anchoredPosition.x)
				{
					if (left == null)
					{
						left = pButton;
					}
					else if (left.rect_transform.anchoredPosition.x < anchoredPosition2.x)
					{
						left = pButton;
					}
				}
				if (anchoredPosition2.x > anchoredPosition.x)
				{
					if (right == null)
					{
						right = pButton;
					}
					else if (right.rect_transform.anchoredPosition.x > anchoredPosition2.x)
					{
						right = pButton;
					}
				}
			}
			if (anchoredPosition2.x != anchoredPosition.x)
			{
				continue;
			}
			if (anchoredPosition2.y < anchoredPosition.y)
			{
				if (down == null)
				{
					down = pButton;
				}
				else if (down.rect_transform.anchoredPosition.y < anchoredPosition2.y)
				{
					down = pButton;
				}
			}
			if (anchoredPosition2.y > anchoredPosition.y)
			{
				if (up == null)
				{
					up = pButton;
				}
				else if (up.rect_transform.anchoredPosition.y > anchoredPosition2.y)
				{
					up = pButton;
				}
			}
		}
		if (left == null)
		{
			foreach (PowerButton pButton2 in pButtons)
			{
				if (pButton2 == this || (pCheckForActive && !pButton2.gameObject.activeSelf))
				{
					continue;
				}
				Vector2 anchoredPosition3 = pButton2.rect_transform.anchoredPosition;
				if (anchoredPosition3.y == -2f)
				{
					anchoredPosition3.y = 16f;
				}
				if (anchoredPosition3.y == anchoredPosition.y)
				{
					if (left == null)
					{
						left = pButton2;
					}
					else if (left.rect_transform.anchoredPosition.x < anchoredPosition3.x)
					{
						left = pButton2;
					}
				}
			}
		}
		if (!(right == null))
		{
			return;
		}
		foreach (PowerButton pButton3 in pButtons)
		{
			if (pButton3 == this || (pCheckForActive && !pButton3.gameObject.activeSelf))
			{
				continue;
			}
			Vector2 anchoredPosition4 = pButton3.rect_transform.anchoredPosition;
			if (anchoredPosition4.y == -2f)
			{
				anchoredPosition4.y = 16f;
			}
			if (anchoredPosition4.y == anchoredPosition.y)
			{
				if (right == null)
				{
					right = pButton3;
				}
				else if (right.rect_transform.anchoredPosition.x > anchoredPosition4.x)
				{
					right = pButton3;
				}
			}
		}
	}

	private bool isActorSpawn()
	{
		if (godPower != null)
		{
			return godPower.type == PowerActionType.PowerSpawnActor;
		}
		return false;
	}

	public static void checkActorSpawnButtons()
	{
		Color color = new Color(0.75f, 0.75f, 0.75f, 0.9f);
		foreach (KeyValuePair<ActorAsset, PowerButton> actor_spawn_button in actor_spawn_buttons)
		{
			ActorAsset key = actor_spawn_button.Key;
			PowerButton value = actor_spawn_button.Value;
			if (key.isAvailable())
			{
				if (key.countPopulation() > 0)
				{
					value._image.sprite = ToolbarButtons.getSpriteButtonUnitExists();
					value.icon.color = Toolbox.color_white;
				}
				else
				{
					value._image.sprite = ToolbarButtons.getSpriteButtonNormal();
					value.icon.color = color;
				}
			}
			else
			{
				value.icon.color = Toolbox.color_black;
			}
		}
	}

	private bool draggingBarEnabled()
	{
		if (drag_power_bar)
		{
			return InputHelpers.mouseSupported;
		}
		return false;
	}

	public void OnBeginDrag(PointerEventData pEventData)
	{
		if (draggingBarEnabled())
		{
			ScrollRectExtended.SendMessageToAll("OnBeginDrag", pEventData);
		}
	}

	public void OnDrag(PointerEventData pEventData)
	{
		if (draggingBarEnabled())
		{
			ScrollRectExtended.SendMessageToAll("OnDrag", pEventData);
		}
	}

	public void OnEndDrag(PointerEventData pEventData)
	{
		if (draggingBarEnabled())
		{
			ScrollRectExtended.SendMessageToAll("OnEndDrag", pEventData);
		}
	}

	public void OnInitializePotentialDrag(PointerEventData pEventData)
	{
		if (draggingBarEnabled())
		{
			ScrollRectExtended.SendMessageToAll("OnInitializePotentialDrag", pEventData);
		}
	}

	public void OnScroll(PointerEventData pEventData)
	{
		if (draggingBarEnabled())
		{
			ScrollRectExtended.SendMessageToAll("OnScroll", pEventData);
		}
	}

	public void OnDestroy()
	{
		base.transform.DOKill();
		power_buttons.Remove(this);
		toggle_buttons.Remove(this);
		if (actor_spawn_buttons.ContainsValue(this))
		{
			ActorAsset key = actor_spawn_buttons.FirstOrDefault((KeyValuePair<ActorAsset, PowerButton> x) => x.Value == this).Key;
			actor_spawn_buttons.Remove(key);
		}
	}
}
