using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class AugmentationsEditor<TAugmentation, TAugmentationButton, TAugmentationEditorButton, TAugmentationGroupAsset, TAugmentationGroup, TAugmentationWindow, TEditorInterface> : BaseAugmentationsEditor where TAugmentation : BaseAugmentationAsset where TAugmentationButton : AugmentationButton<TAugmentation> where TAugmentationEditorButton : AugmentationEditorButton<TAugmentationButton, TAugmentation> where TAugmentationGroupAsset : BaseCategoryAsset where TAugmentationGroup : AugmentationCategory<TAugmentation, TAugmentationButton, TAugmentationEditorButton> where TAugmentationWindow : IAugmentationsWindow<TEditorInterface> where TEditorInterface : IAugmentationsEditor
{
	private const float FOCUS_SCROLL_OFFSET_TOP = -5f;

	private const float FOCUS_SCROLL_OFFSET_BOTTOM = 1f;

	public const float FOCUS_SCROLL_DURATION = 0.3f;

	[SerializeField]
	protected Image art;

	public TAugmentationButton prefab_augmentation;

	public TAugmentationEditorButton prefab_editor_augmentation;

	public TAugmentationGroup prefab_augmentation_group;

	protected readonly Dictionary<string, TAugmentationGroup> dict_groups = new Dictionary<string, TAugmentationGroup>();

	protected readonly List<TAugmentationEditorButton> all_augmentation_buttons = new List<TAugmentationEditorButton>();

	protected TAugmentationWindow augmentation_window;

	protected ObjectPoolGenericMono<TAugmentationButton> selected_editor_buttons;

	[SerializeField]
	private WindowMetaTab _editor_tab;

	protected virtual List<TAugmentationGroupAsset> augmentation_groups_list
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	protected virtual List<TAugmentation> all_augmentations_list
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	protected virtual TAugmentation edited_marker_augmentation => null;

	protected override void create()
	{
		base.create();
		augmentation_window = GetComponentInParent<TAugmentationWindow>();
		if (rain_editor)
		{
			selected_editor_buttons = new ObjectPoolGenericMono<TAugmentationButton>(prefab_augmentation, selected_editor_augmentations_grid.transform);
		}
	}

	protected override void OnEnable()
	{
		if (rain_editor)
		{
			onEnableRain();
		}
		base.OnEnable();
	}

	protected virtual ListPool<TAugmentation> getOrderedAugmentationsList()
	{
		ListPool<TAugmentation> listPool = new ListPool<TAugmentation>(all_augmentations_list);
		listPool.Sort(delegate(TAugmentation pT1, TAugmentation pT2)
		{
			int num = pT2.priority.CompareTo(pT1.priority);
			if (num == 0)
			{
				num = StringComparer.Ordinal.Compare(pT1.id, pT2.id);
			}
			return num;
		});
		return listPool;
	}

	public override void reloadButtons()
	{
		base.reloadButtons();
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		foreach (TAugmentationEditorButton all_augmentation_button in all_augmentation_buttons)
		{
			bool num4 = isAugmentationAvailable(all_augmentation_button.augmentation_button);
			TAugmentation elementAsset = all_augmentation_button.augmentation_button.getElementAsset();
			num3++;
			if (num4)
			{
				num2++;
			}
			all_augmentation_button.selected_icon.gameObject.SetActive(value: false);
			if (num4)
			{
				all_augmentation_button.augmentation_button.image.color = Toolbox.color_augmentation_unselected;
			}
			bool can_be_given = elementAsset.can_be_given;
			bool pSelected = false;
			if (!can_be_given)
			{
				bool flag = !rain_editor && hasAugmentation(all_augmentation_button.augmentation_button);
				all_augmentation_button.selected_icon.gameObject.SetActive(flag);
				all_augmentation_button.selected_icon.color = Toolbox.color_log_warning;
				if (flag)
				{
					num++;
					pSelected = true;
				}
			}
			else if (rain_editor && augmentations_hashset.Contains(all_augmentation_button.augmentation_button.getElementId()))
			{
				Color color = ((rain_editor_state != RainState.Add) ? ColorStyleLibrary.m.getSelectorRemoveColor() : ColorStyleLibrary.m.getSelectorColor());
				all_augmentation_button.selected_icon.gameObject.SetActive(value: true);
				all_augmentation_button.selected_icon.color = color;
				pSelected = true;
			}
			else if (!rain_editor && hasAugmentation(all_augmentation_button.augmentation_button))
			{
				all_augmentation_button.selected_icon.gameObject.SetActive(value: true);
				all_augmentation_button.selected_icon.color = ColorStyleLibrary.m.getSelectorColor();
				pSelected = true;
				num++;
			}
			all_augmentation_button.augmentation_button.updateIconColor(pSelected);
		}
		foreach (TAugmentationGroup value in dict_groups.Values)
		{
			if (value.asset.show_counter)
			{
				value.updateCounter();
			}
			else
			{
				value.hideCounter();
			}
		}
		if (rain_editor)
		{
			text_counter_augmentations.text = num2 + "/" + num3;
		}
		else
		{
			text_counter_augmentations.text = num + "/" + num3;
		}
		startSignal();
	}

	protected override void groupsBuilder()
	{
		using ListPool<TAugmentation> listPool = getOrderedAugmentationsList();
		foreach (TAugmentationGroupAsset item in augmentation_groups_list)
		{
			TAugmentationGroup val = UnityEngine.Object.Instantiate(prefab_augmentation_group, augmentation_groups_parent);
			val.asset = item;
			val.clearDebug();
			dict_groups.Add(item.id, val);
			val.title.GetComponent<LocalizedText>().setKeyAndUpdate(item.getLocaleID());
			val.title.color = item.getColor();
		}
		foreach (ref TAugmentation item2 in listPool)
		{
			TAugmentation current2 = item2;
			TAugmentationGroup pGroup = dict_groups[current2.group_id];
			createButton(current2, pGroup);
		}
	}

	protected override void checkEnabledGroups()
	{
		foreach (TAugmentationGroup value in dict_groups.Values)
		{
			bool active = value.countActiveButtons() > 0;
			value.gameObject.SetActive(active);
		}
	}

	protected void editorButtonClick(TAugmentationEditorButton pButton)
	{
		if (!InputHelpers.mouseSupported && !Tooltip.isShowingFor(pButton.augmentation_button))
		{
			return;
		}
		if (!Config.hasPremium)
		{
			ScrollWindow.showWindow("premium_menu");
		}
		else if (pButton.augmentation_button.getElementAsset().can_be_given)
		{
			if (rain_editor)
			{
				rainAugmentationClick(pButton);
			}
			else
			{
				metaAugmentationClick(pButton);
			}
			reloadButtons();
		}
	}

	protected virtual void metaAugmentationClick(TAugmentationEditorButton pButton)
	{
		showActiveButtons();
		refreshAugmentationWindow();
	}

	protected virtual void rainAugmentationClick(TAugmentationEditorButton pButton)
	{
		saveRainValues();
		loadEditorSelectedAugmentations();
	}

	protected virtual void validateRainData()
	{
		augmentations_list_link.RemoveAll(delegate(string tId)
		{
			TAugmentation val = all_augmentations_list.Find((TAugmentation tAugmentation) => tAugmentation.id == tId);
			if (val == null)
			{
				return true;
			}
			return !val.isAvailable();
		});
	}

	protected virtual void refreshAugmentationWindow()
	{
		augmentation_window.updateStats();
		augmentation_window.reloadBanner();
	}

	protected void saveRainValues()
	{
		augmentations_list_link.Clear();
		foreach (string item in augmentations_hashset)
		{
			augmentations_list_link.Add(item);
		}
		PlayerConfig.saveData();
	}

	protected virtual void loadEditorSelectedAugmentations()
	{
		selected_editor_buttons.clear();
		foreach (string item in augmentations_hashset)
		{
			if (isAugmentationExists(item))
			{
				TAugmentationButton next = selected_editor_buttons.getNext();
				loadEditorSelectedButton(next, item);
			}
		}
	}

	public void scrollToGroupStarter(GameObject pButton)
	{
		scrollToGroupStarter(pButton, pIgnoreTooltipCheck: false);
	}

	public virtual void scrollToGroupStarter(GameObject pButton, bool pIgnoreTooltipCheck)
	{
		if (!pIgnoreTooltipCheck && !InputHelpers.mouseSupported && !Tooltip.isShowingFor(pButton.GetComponent<TAugmentationButton>()))
		{
			return;
		}
		bool pWithDelay = false;
		if (!base.gameObject.activeInHierarchy)
		{
			if (!(_editor_tab != null))
			{
				return;
			}
			_editor_tab.container.showTab(_editor_tab);
			pWithDelay = true;
		}
		StartCoroutine(scrollToGroupStarterRoutine(pButton, pWithDelay));
	}

	private IEnumerator scrollToGroupStarterRoutine(GameObject pButton, bool pWithDelay)
	{
		if (pWithDelay)
		{
			yield return new WaitForSeconds(Config.getScrollToGroupDelay());
		}
		scrollToGroup(pButton);
	}

	private void scrollToGroup(GameObject pButton, float pDuration = 0.3f)
	{
		TAugmentationGroup val = null;
		foreach (TAugmentationGroup value in dict_groups.Values)
		{
			TAugmentationButton component = pButton.GetComponent<TAugmentationButton>();
			if (value.hasAugmentation(component.getElementAsset()))
			{
				val = value;
				break;
			}
		}
		if (val == null)
		{
			return;
		}
		RectTransform obj = pButton.GetComponentInParent<HeaderContainer>().transform as RectTransform;
		RectTransform component2 = base.transform.parent.GetComponent<RectTransform>();
		RectTransform component3 = component2.parent.GetComponent<RectTransform>();
		RectTransform rectTransform = base.transform as RectTransform;
		RectTransform component4 = val.GetComponent<RectTransform>();
		float height = component3.rect.height;
		float height2 = obj.rect.height;
		float height3 = component2.rect.height;
		float height4 = rectTransform.rect.height;
		float height5 = component4.rect.height;
		float num = Mathf.Abs(rectTransform.anchoredPosition.y) - height4 * (1f - rectTransform.pivot.y) - height2;
		float num2 = Mathf.Abs(component4.anchoredPosition.y) - height5 * (1f - component4.pivot.y) + num;
		float num3 = num2 + height5;
		bool flag = num2 < component2.localPosition.y;
		bool flag2 = num3 > component2.localPosition.y + height - height2;
		if (flag || flag2)
		{
			float num4;
			if (flag)
			{
				num4 = num2;
				num4 -= -5f;
			}
			else
			{
				num4 = num3 - height + height2;
				num4 += 1f;
			}
			num4 = Mathf.Clamp(num4, 0f, height3 - height);
			component2.DOLocalMoveY(num4, pDuration);
		}
	}

	protected virtual bool isAugmentationExists(string pId)
	{
		throw new NotImplementedException();
	}

	protected virtual void loadEditorSelectedButton(TAugmentationButton pButton, string pAugmentationId)
	{
		pButton.removeClickAction(scrollToGroupStarter);
		pButton.addClickAction(scrollToGroupStarter);
	}

	protected virtual void createButton(TAugmentation pElement, TAugmentationGroup pGroup)
	{
		throw new NotImplementedException();
	}

	protected virtual bool hasAugmentation(TAugmentationButton pButton)
	{
		throw new NotImplementedException();
	}

	protected virtual bool addAugmentation(TAugmentationButton pButton)
	{
		throw new NotImplementedException();
	}

	protected virtual bool removeAugmentation(TAugmentationButton pButton)
	{
		throw new NotImplementedException();
	}

	public WindowMetaTab getEditorTab()
	{
		return _editor_tab;
	}

	protected bool isAugmentationAvailable(TAugmentationButton pButton)
	{
		return pButton.getElementAsset().isAvailable();
	}
}
