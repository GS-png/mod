using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class PowersTab : MonoBehaviour
{
	private const float END_SPACE = 5f;

	private static PowersTab _current_tab;

	private static Button _current_tab_button;

	private static PowersTab _main_tab;

	private GameObject parentObj;

	public Sprite image_normal;

	public Sprite image_selected;

	public Button powerButton;

	public static float scale_time = 0.2f;

	public static float buttonScaleTime = 0.1f;

	private List<PowerButton> _power_buttons = new List<PowerButton>();

	private PowerButton _last_selected_button;

	private PowerTabAsset _asset;

	private SelectedNanoBase _selected_nano;

	private int _children;

	public const int BACK_BUTTON_Y = -2;

	public const int TOP_BUTTON_Y = 16;

	private const int Y_TOP_ITEM = 32;

	private const int Y_BOTTOM_ITEM = -4;

	private const float Y_LINE_ITEM = 37.2f;

	private const int SIDE_SPACING = 2;

	private const int BUTTON_WIDTH = 32;

	private void Start()
	{
		parentObj = base.transform.parent.parent.gameObject;
		_selected_nano = GetComponent<SelectedNanoBase>();
		if (PowerTabController.instance.tab_main == this)
		{
			setActive();
			_main_tab = PowerTabController.instance.tab_main;
		}
		else
		{
			hideTab();
		}
		PowerButton[] componentsInChildren = GetComponentsInChildren<PowerButton>();
		foreach (PowerButton powerButton in componentsInChildren)
		{
			if (!(powerButton == null) && !(powerButton.rect_transform == null))
			{
				_power_buttons.Add(powerButton);
			}
		}
		findNeighbours();
		_asset = AssetManager.power_tab_library.get(base.gameObject.name);
		if (_asset == null)
		{
			Debug.LogError("No Power_Tab_library found for " + base.gameObject.name);
		}
	}

	public void findNeighbours(bool pCheckForActive = false)
	{
		foreach (PowerButton power_button in _power_buttons)
		{
			power_button.up = null;
			power_button.down = null;
			power_button.left = null;
			power_button.right = null;
		}
		foreach (PowerButton power_button2 in _power_buttons)
		{
			power_button2.findNeighbours(_power_buttons, pCheckForActive);
		}
	}

	public void update()
	{
		if (_selected_nano != null && !ScrollWindow.isWindowActive() && !ScrollWindow.isAnimationActive())
		{
			_selected_nano.update();
		}
		int num = base.transform.CountChildren(delegate(Transform pChild)
		{
			if (!pChild.gameObject.activeSelf)
			{
				return false;
			}
			return !pChild.name.StartsWith("ButtonSelection");
		});
		if (_children != num)
		{
			_children = num;
			sortButtons();
			setNewWidth();
			if (_asset != null)
			{
				_asset.last_scroll_position = 0f;
			}
		}
	}

	public PowerTabAsset getAsset()
	{
		return _asset;
	}

	private void selectButton(PowerButton pButton)
	{
		World.world.selected_buttons.unselectAll();
		if (pButton == null)
		{
			World.world.selected_buttons.clearHighlightedButton();
			return;
		}
		_last_selected_button = pButton;
		if (pButton.godPower != null && pButton.godPower.activate_on_hotkey_select)
		{
			World.world.selected_buttons.clickPowerButton(pButton);
		}
		else
		{
			World.world.selected_buttons.highlightButton(pButton);
		}
		float num = (float)Screen.width / CanvasMain.instance.canvas_ui.scaleFactor;
		if (!(pButton.rect_transform.position.x > 0f) || !(pButton.rect_transform.position.x + 32f < (float)Screen.width))
		{
			float num2 = 0f - pButton.transform.localPosition.x - 96f + num;
			if (num2 > 0f)
			{
				num2 = 0f;
			}
			pButton.transform.parent.parent.parent.transform.DOLocalMoveX(num2, 0.25f);
		}
	}

	internal int currentPowerIndex()
	{
		int num = -1;
		PowerButton selectedButton = World.world.selected_buttons.selectedButton;
		if (selectedButton != null && selectedButton != _last_selected_button)
		{
			if (_last_selected_button == null)
			{
				_last_selected_button = selectedButton;
			}
			else if (_power_buttons.IndexOf(selectedButton) >= 0)
			{
				_last_selected_button = selectedButton;
			}
		}
		num = _power_buttons.IndexOf(_last_selected_button);
		if (num < 0)
		{
			num = 0;
		}
		return num;
	}

	internal PowerButton getActiveButton()
	{
		return _power_buttons[currentPowerIndex()];
	}

	internal void leftButton()
	{
		PowerButton powerButton = getActiveButton();
		while (powerButton.left != null)
		{
			powerButton = powerButton.left;
			if (powerButton.canSelect() && powerButton.isActiveAndEnabled)
			{
				break;
			}
		}
		selectButton(powerButton);
	}

	internal void rightButton()
	{
		PowerButton powerButton = getActiveButton();
		while (powerButton.right != null)
		{
			powerButton = powerButton.right;
			if (powerButton.canSelect() && powerButton.isActiveAndEnabled)
			{
				break;
			}
		}
		selectButton(powerButton);
	}

	internal void upButton()
	{
		PowerButton activeButton = getActiveButton();
		if (activeButton.up != null && activeButton.up.isActiveAndEnabled && activeButton.up.canSelect())
		{
			selectButton(activeButton.up);
		}
		else if (activeButton.down != null && activeButton.down.isActiveAndEnabled && activeButton.down.canSelect())
		{
			selectButton(activeButton.down);
		}
	}

	internal void downButton()
	{
		PowerButton activeButton = getActiveButton();
		if (activeButton.down != null && activeButton.down.isActiveAndEnabled && activeButton.down.canSelect())
		{
			selectButton(activeButton.down);
		}
		else if (activeButton.up != null && activeButton.up.isActiveAndEnabled && activeButton.up.canSelect())
		{
			selectButton(activeButton.up);
		}
	}

	public static void showTabFromButton(Button pButtonTab, bool pHideTooltips = false)
	{
		pButtonTab.onClick.Invoke();
		if (pHideTooltips)
		{
			Tooltip.hideTooltipNow();
		}
	}

	public static PowersTab getActiveTab()
	{
		if (!isTabSelected())
		{
			return _main_tab;
		}
		return _current_tab;
	}

	public static bool isTabSelected()
	{
		return _current_tab != null;
	}

	public static void unselect()
	{
		_current_tab?.hideTab();
		_main_tab.setActive();
		Tooltip.hideTooltip();
	}

	public bool isCurrentPowerTabSelected()
	{
		return _current_tab == this;
	}

	public void tryToShowTab()
	{
		if (!isCurrentPowerTabSelected())
		{
			showTab(null);
		}
	}

	public void showTab(Button pTabButton)
	{
		bool flag = false;
		if (_current_tab != null)
		{
			if (isCurrentPowerTabSelected())
			{
				flag = true;
			}
			_current_tab.hideTab();
			_current_tab = null;
		}
		if (flag)
		{
			_main_tab.setActive();
			return;
		}
		PowerTabController.instance.tab_main.hideTab();
		_current_tab = this;
		_current_tab_button = pTabButton;
		setActive(pTabButton);
		if (pTabButton != null)
		{
			string textOnClick = pTabButton.gameObject.GetComponent<TipButton>().textOnClick;
			WorldTip.instance.showToolbarText(LocalizedTextManager.getText(textOnClick));
		}
		MusicBox.playSoundUI("event:/SFX/UI/ThumbnailsSlide");
	}

	private void setActive(Button pTabButton = null)
	{
		if (pTabButton != null)
		{
			pTabButton.image.sprite = image_selected;
		}
		base.gameObject.SetActive(value: true);
		base.gameObject.transform.localPosition = new Vector3(0f, -16f);
		setNewWidth();
		if (_asset != null)
		{
			PowerTabController.loadScrollPosition(_asset.last_scroll_position);
			if (_asset.tab_type_main)
			{
				SelectedTabsHistory.clear();
			}
		}
		TabCenterer component = GetComponent<TabCenterer>();
		_ = component == null;
		base.gameObject.transform.localScale = new Vector3(0.2f, 0.9f, 0.9f);
		base.gameObject.transform.DOScale(1f, scale_time).SetEase(Ease.OutCubic);
		if (_asset == null || !_asset.tab_type_main)
		{
			return;
		}
		foreach (PowerTabAsset item in AssetManager.power_tab_library.list)
		{
			item.on_main_tab_select?.Invoke(item);
		}
	}

	private bool setNewWidth()
	{
		int childCount = base.transform.childCount;
		RectTransform component = parentObj.GetComponent<RectTransform>();
		float x = component.sizeDelta.x;
		float num = 0f;
		float num2 = 0f;
		for (int i = 0; i < childCount; i++)
		{
			GameObject gameObject = base.transform.GetChild(i).gameObject;
			if (gameObject.activeSelf)
			{
				RectTransform component2 = gameObject.GetComponent<RectTransform>();
				num = component2.localPosition.x + component2.sizeDelta.x + component2.rect.x;
				if (num > num2)
				{
					num2 = num;
				}
			}
		}
		component.sizeDelta = new Vector2(num2 + 5f, component.sizeDelta.y);
		PowerTabController.instance.resetToStartScrollPosition();
		return x != num2;
	}

	public bool recalc()
	{
		return setNewWidth();
	}

	public void hideTab()
	{
		saveScrollPosition();
		completeHide();
		_current_tab = null;
		if (_current_tab_button != null)
		{
			_current_tab_button.image.sprite = image_normal;
			_current_tab_button = null;
		}
	}

	private void saveScrollPosition()
	{
		if (_asset != null)
		{
			_asset.last_scroll_position = PowerTabController.currentScrollPosition();
		}
	}

	private void completeHide()
	{
		base.gameObject.SetActive(value: false);
	}

	private void OnDisable()
	{
		if (Config.isDraggingItem())
		{
			Config.getDraggingObject().KillDrag();
		}
	}

	private void prepareButtonPosition(RectTransform pRect)
	{
		if (!(pRect == null))
		{
			pRect.SetAnchor(AnchorPresets.TopLeft);
			pRect.SetPivot(PivotPresets.TopLeft);
		}
	}

	private void restoreButtonPosition(RectTransform pRect)
	{
		if (!(pRect == null))
		{
			pRect.SetPivot(PivotPresets.MiddleCenter, pKeepPosition: true);
		}
	}

	public void sortButtons()
	{
		Transform transform = base.gameObject.transform;
		float num = 9.6f;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		float num5 = 20f;
		for (int i = 0; i < transform.childCount; i++)
		{
			GameObject gameObject = transform.GetChild(i).gameObject;
			gameObject.transform.DOKill(complete: true);
			if (!gameObject.activeSelf)
			{
				continue;
			}
			gameObject.TryGetComponent<RectTransform>(out var component);
			if (gameObject.name.StartsWith("_space_half"))
			{
				if (num4 > 0)
				{
					num5 += 36f;
					num4 = 0;
				}
				num5 += num;
				continue;
			}
			if (gameObject.name.StartsWith("_line") || gameObject.name.StartsWith("element_"))
			{
				if (num4 > 0)
				{
					num5 += 36f;
					num4 = 0;
				}
				float y = 32f;
				if (gameObject.name.StartsWith("_line"))
				{
					y = 37.2f;
				}
				prepareButtonPosition(component);
				gameObject.transform.localPosition = new Vector3(num5, y, 0f);
				num5 += ((RectTransform)gameObject.transform).rect.width;
				num5 += 4f;
				restoreButtonPosition(component);
				continue;
			}
			gameObject.TryGetComponent<PowerButton>(out var component2);
			if (!gameObject.name.Contains("_space") && (component2 == null || !component2.isActiveAndEnabled))
			{
				continue;
			}
			bool flag = false;
			if (num4 % 2 == 0)
			{
				num2++;
				num3 = 0;
				flag = num4 > 0;
			}
			else
			{
				num3 = 1;
			}
			num4++;
			if (gameObject.name.StartsWith("_space"))
			{
				if (flag)
				{
					num5 += 36f;
				}
				continue;
			}
			if (flag)
			{
				num5 += 36f;
			}
			if (!(component2 == null) && component2.isActiveAndEnabled)
			{
				float num6 = 0f;
				num6 = ((num3 != 0) ? (-4f) : 32f);
				if (gameObject.name.Contains("tab_back_button"))
				{
					num6 = 32f;
				}
				prepareButtonPosition(component);
				component2.transform.localPosition = new Vector3(num5, num6, 0f);
				restoreButtonPosition(component);
			}
		}
	}
}
