using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class OnomasticsTab : OnomasticsNameGenerator
{
	private const int MAX_CARDS = 30;

	private const float BUTTON_SCALE = 1f;

	private const float WORD_SCALE = 1f;

	private const float EFFECT_SCALE = 0.8f;

	private const float WORD_BOX_SIZE_X = 2f;

	private const float WORD_BOX_SIZE_Y = 2f;

	private const float EFFECT_BOX_SIZE_X = 10f;

	private const float EFFECT_BOX_SIZE_Y = 3f;

	public Transform parent_name_variation_1;

	public DragOrderContainer name_variation_1_drag_container;

	public Transform parent_asset_groups;

	public Transform parent_asset_specials;

	public Transform parent_asset_editor_group;

	public Image icon_last_selected_group;

	public Text text_counter;

	public OnomasticsAssetButton prefab_button;

	public OnomasticsAssetButton prefab_button_template;

	private ObjectPoolGenericMono<OnomasticsAssetButton> _pool_buttons;

	protected NameInput _editor_input;

	private bool _created;

	private OnomasticsData _onomastics_data;

	private MetaType _name_set_type = MetaType.Unit;

	private OnomasticsAsset _selected_editor_group;

	private OnomasticsAssetButton _selected_editor_group_button;

	public Image selected_icon_effect;

	public Image selected_icon_effect_2;

	private ObjectPoolGenericMono<Image> _pool_boxed_effects;

	public Image boxed_effect_prefab;

	public Transform boxed_effects_transform;

	private ObjectPoolGenericMono<Image> _pool_word_effects;

	public Image word_effect_prefab;

	public Transform word_effects_transform;

	[SerializeField]
	private TabTogglesGroup _tab_groups;

	private static readonly string[] consonant_combinations = new string[30]
	{
		"b", "c", "d", "f", "g", "h", "j", "k", "l", "m",
		"n", "p", "q", "r", "s", "t", "v", "w", "x", "y",
		"z", "st", "bl", "tr", "pr", "cl", "kr", "fr", "gr", "pl"
	};

	private static readonly string[] vowel_combinations = new string[30]
	{
		"a", "e", "i", "o", "u", "ai", "ei", "oi", "au", "ou",
		"ie", "ee", "oa", "ea", "io", "ia", "ui", "ue", "oo", "ae",
		"ya", "yo", "ye", "wa", "we", "wi", "wo", "ua", "eu", "iu"
	};

	private void OnEnable()
	{
		create();
		showCategoryGroups();
	}

	private void showCategoryGroups()
	{
		_tab_groups.gameObject.SetActive(value: true);
		_tab_groups.clearButtons();
		_tab_groups.tryAddButton("ui/Icons/actor_traits/iconAttractive", "tab_onomastics_unit", loadNameSet, delegate
		{
			_name_set_type = MetaType.Unit;
		});
		_tab_groups.tryAddButton("ui/Icons/iconFamilyList", "tab_onomastics_family", loadNameSet, delegate
		{
			_name_set_type = MetaType.Family;
		});
		_tab_groups.tryAddButton("ui/Icons/iconClanList", "tab_onomastics_clan", loadNameSet, delegate
		{
			_name_set_type = MetaType.Clan;
		});
		_tab_groups.tryAddButton("ui/Icons/iconCityList", "tab_onomastics_city", loadNameSet, delegate
		{
			_name_set_type = MetaType.City;
		});
		_tab_groups.tryAddButton("ui/Icons/iconKingdomList", "tab_onomastics_kingdom", loadNameSet, delegate
		{
			_name_set_type = MetaType.Kingdom;
		});
		_tab_groups.enableFirst();
	}

	private void openFirstGroup()
	{
		using ListPool<OnomasticsAssetButton> listPool = getActiveButtons(parent_asset_groups);
		for (int i = 0; i < listPool.Count; i++)
		{
			OnomasticsAssetButton onomasticsAssetButton = listPool[i];
			if (onomasticsAssetButton.onomastics_asset.id == "group_1")
			{
				openGroup(onomasticsAssetButton);
				break;
			}
		}
	}

	private void Update()
	{
		if (_selected_editor_group != null)
		{
			selected_icon_effect.transform.position = _selected_editor_group_button.transform.position;
			Vector3 position = _selected_editor_group_button.transform.position;
			position.y += 30f;
			selected_icon_effect_2.transform.position = position;
		}
		updateNameGeneration(_onomastics_data);
		text_counter.text = $"{_pool_buttons.countActive().ToString()}/{30}";
	}

	private void LateUpdate()
	{
		checkButtonsAndEffects();
	}

	private void checkButtonsAndEffects()
	{
		_pool_boxed_effects.clear();
		_pool_word_effects.clear();
		OnomasticsAssetButton onomasticsAssetButton = null;
		using ListPool<OnomasticsAssetButton> listPool = getActiveButtons(parent_name_variation_1);
		for (int i = 0; i < listPool.Count; i++)
		{
			OnomasticsAssetButton onomasticsAssetButton2 = listPool[i];
			OnomasticsAssetButton onomasticsAssetButton3 = null;
			if (onomasticsAssetButton2.onomastics_asset.is_word_divider)
			{
				onomasticsAssetButton = null;
			}
			else if (onomasticsAssetButton == null)
			{
				onomasticsAssetButton = onomasticsAssetButton2;
			}
			if (i + 1 < listPool.Count)
			{
				onomasticsAssetButton3 = listPool[i + 1];
			}
			if (onomasticsAssetButton2.onomastics_asset.affects_left_word)
			{
				showWordBox(onomasticsAssetButton, onomasticsAssetButton2);
			}
			if (!onomasticsAssetButton2.onomastics_asset.is_immune && onomasticsAssetButton3 != null && onomasticsAssetButton3.onomastics_asset.affects_left && (!onomasticsAssetButton3.onomastics_asset.affects_left_group_only || onomasticsAssetButton2.onomastics_asset.isGroupType()))
			{
				showEffectBox(onomasticsAssetButton2, onomasticsAssetButton3);
			}
		}
	}

	private ListPool<OnomasticsAssetButton> getActiveButtons(Transform pTransform)
	{
		ListPool<OnomasticsAssetButton> listPool = new ListPool<OnomasticsAssetButton>(pTransform.childCount);
		for (int i = 0; i < pTransform.childCount; i++)
		{
			OnomasticsAssetButton component = pTransform.GetChild(i).GetComponent<OnomasticsAssetButton>();
			if (!(component == null) && component.gameObject.activeSelf)
			{
				listPool.Add(component);
			}
		}
		return listPool;
	}

	private void showEffectBox(OnomasticsAssetButton pButton1, OnomasticsAssetButton pButton2)
	{
		Image next = _pool_boxed_effects.getNext();
		RectTransform component = next.GetComponent<RectTransform>();
		Vector3[] array = new Vector3[4];
		Vector3[] array2 = new Vector3[4];
		pButton1.getRect().GetWorldCorners(array);
		pButton2.getRect().GetWorldCorners(array2);
		float x = Mathf.Min(array[0].x, array2[0].x);
		float x2 = Mathf.Max(array[2].x, array2[2].x);
		float y = Mathf.Min(array[0].y, array2[0].y);
		float y2 = Mathf.Max(array[2].y, array2[2].y);
		Vector3 vector = next.transform.parent.InverseTransformPoint(new Vector3(x, y, 0f));
		Vector3 vector2 = next.transform.parent.InverseTransformPoint(new Vector3(x2, y2, 0f));
		float num = 10f;
		float num2 = 3f;
		component.anchoredPosition = new Vector2((vector.x + vector2.x) / 2f, (vector.y + vector2.y) / 2f);
		component.sizeDelta = new Vector2(vector2.x - vector.x + num, vector2.y - vector.y + num2);
		component.localScale = new Vector3(0.8f, 0.8f, 0.8f);
	}

	private void showWordBox(OnomasticsAssetButton pButton1, OnomasticsAssetButton pButton2)
	{
		Image next = _pool_word_effects.getNext();
		RectTransform component = next.GetComponent<RectTransform>();
		Vector3[] array = new Vector3[4];
		Vector3[] array2 = new Vector3[4];
		pButton1.getRect().GetWorldCorners(array);
		pButton2.getRect().GetWorldCorners(array2);
		float x = Mathf.Min(array[0].x, array2[0].x);
		float x2 = Mathf.Max(array[2].x, array2[2].x);
		float y = Mathf.Min(array[0].y, array2[0].y);
		float y2 = Mathf.Max(array[2].y, array2[2].y);
		Vector3 vector = next.transform.parent.InverseTransformPoint(new Vector3(x, y, 0f));
		Vector3 vector2 = next.transform.parent.InverseTransformPoint(new Vector3(x2, y2, 0f));
		float num = 2f;
		float num2 = 2f;
		component.anchoredPosition = new Vector2((vector.x + vector2.x) / 2f, (vector.y + vector2.y) / 2f);
		component.sizeDelta = new Vector2(vector2.x - vector.x + num, vector2.y - vector.y + num2);
		component.localScale = new Vector3(1f, 1f, 1f);
	}

	private void loadOnomasicsData()
	{
		_onomastics_data = SelectedMetas.selected_culture.getOnomasticData(_name_set_type);
		loadInitialButtons();
	}

	private void loadInitialButtons()
	{
		_pool_buttons.clear();
		List<string> fullTemplateData = _onomastics_data.getFullTemplateData();
		for (int i = 0; i < fullTemplateData.Count; i++)
		{
			string pID = fullTemplateData[i];
			loadTemplateButton(pID);
		}
	}

	public OnomasticsData getOnomasticsData()
	{
		return _onomastics_data;
	}

	protected void OnDisable()
	{
		if (!(_editor_input == null))
		{
			_editor_input.inputField.DeactivateInputField();
		}
	}

	protected virtual void initNameInput()
	{
		if (!(_editor_input == null))
		{
			_editor_input.addListener(applyInputName);
		}
	}

	private void applyInputName(string pString)
	{
		pString = pString.Replace("\n", " ");
		pString = pString.Replace("\r", " ");
		while (pString.Contains("  "))
		{
			pString = pString.Replace("  ", " ");
		}
		pString = pString.Trim();
		if (_onomastics_data.setGroup(_selected_editor_group.id, pString))
		{
			resetNameGenerationTextBox();
		}
	}

	private void resetNameGenerationTextBox()
	{
		clickRegenerate();
		using ListPool<OnomasticsAssetButton> listPool = getActiveButtons(parent_name_variation_1);
		using ListPool<string> listPool2 = new ListPool<string>(listPool.Count);
		for (int i = 0; i < listPool.Count; i++)
		{
			OnomasticsAssetButton onomasticsAssetButton = listPool[i];
			listPool2.Add(onomasticsAssetButton.onomastics_asset.id);
		}
		_onomastics_data.setTemplateData(listPool2);
		if (name_variation_1_drag_container.rect_transform != null)
		{
			LayoutRebuilder.ForceRebuildLayoutImmediate(name_variation_1_drag_container.rect_transform);
		}
	}

	private void create()
	{
		if (_created)
		{
			return;
		}
		DragOrderContainer dragOrderContainer = name_variation_1_drag_container;
		dragOrderContainer.on_order_changed = (Action)Delegate.Combine(dragOrderContainer.on_order_changed, new Action(resetNameGenerationTextBox));
		_pool_boxed_effects = new ObjectPoolGenericMono<Image>(boxed_effect_prefab, boxed_effects_transform);
		_pool_word_effects = new ObjectPoolGenericMono<Image>(word_effect_prefab, word_effects_transform);
		_editor_input = base.transform.FindRecursive("Group Editor Element")?.GetComponent<NameInput>();
		initNameInput();
		_created = true;
		_pool_buttons = new ObjectPoolGenericMono<OnomasticsAssetButton>(prefab_button_template, parent_name_variation_1);
		foreach (OnomasticsAsset item in AssetManager.onomastics_library.list)
		{
			OnomasticsAssetButton tB = UnityEngine.Object.Instantiate(parent: (!item.isGroupType()) ? parent_asset_specials : parent_asset_groups, original: prefab_button);
			setupButton(tB, item);
			if (item.isGroupType())
			{
				tB.GetComponent<TipButton>().showOnClick = false;
				tB.GetComponent<DraggableLayoutElement>().enabled = false;
			}
			tB.button.onClick.AddListener(delegate
			{
				clickAssetButton(tB);
			});
		}
	}

	private void clickAssetButton(OnomasticsAssetButton pButton)
	{
		if (!InputHelpers.mouseSupported)
		{
			if (!Tooltip.isShowingFor(pButton))
			{
				pButton.showTooltip();
				return;
			}
			Tooltip.hideTooltip();
		}
		if (_selected_editor_group != pButton.onomastics_asset && pButton.isGroupType())
		{
			openGroup(pButton);
			return;
		}
		if (pButton.isGroupType() && _onomastics_data.isGroupEmpty(pButton.onomastics_asset.id))
		{
			punch(parent_asset_editor_group.transform);
			return;
		}
		if (_pool_buttons.countActive() >= 30)
		{
			punch(parent_name_variation_1.parent);
			return;
		}
		punch(pButton.transform);
		loadTemplateButton(pButton.onomastics_asset.id, pPunch: true);
		resetNameGenerationTextBox();
	}

	private void punch(Transform pTransformTarget, float pDefaultScale = 1f, float pPower = 0.1f, float pDuration = 0.3f)
	{
		pTransformTarget.DOKill(complete: true);
		pTransformTarget.localScale = new Vector3(pDefaultScale, pDefaultScale, pDefaultScale);
		pTransformTarget.DOPunchScale(new Vector3(pPower, pPower, pPower), pDuration);
	}

	private void setupButton(OnomasticsAssetButton pButton, OnomasticsAsset pAsset)
	{
		pButton.setupButton(pAsset, getOnomasticsData);
	}

	private void setupButton(OnomasticsAssetButton pButton, string pAssetID)
	{
		OnomasticsAsset pAsset = AssetManager.onomastics_library.get(pAssetID);
		setupButton(pButton, pAsset);
	}

	private void loadTemplateButton(string pID, bool pPunch = false)
	{
		OnomasticsAssetButton tNewButton = _pool_buttons.getNext();
		setupButton(tNewButton, pID);
		tNewButton.transform.SetAsLastSibling();
		tNewButton.button.onClick.AddListener(delegate
		{
			clickToRemoveButton(tNewButton);
		});
		punch(tNewButton.transform);
	}

	private void clickToRemoveButton(OnomasticsAssetButton pButton)
	{
		_pool_buttons.release(pButton);
		resetNameGenerationTextBox();
		Tooltip.blockTooltips(0.01f);
	}

	public void openGroup(OnomasticsAssetButton pButton)
	{
		_selected_editor_group = pButton.onomastics_asset;
		_selected_editor_group_button = pButton;
		parent_asset_editor_group.gameObject.SetActive(value: true);
		_editor_input.setText(_onomastics_data.getGroupString(_selected_editor_group.id));
		icon_last_selected_group.sprite = pButton.onomastics_asset.getSprite();
	}

	public void loadFromTemplate(bool pReset = false)
	{
		_onomastics_data = SelectedMetas.selected_culture.getOnomasticData(_name_set_type, pReset);
		loadInitialButtons();
		openFirstGroup();
		resetNameGenerationTextBox();
	}

	public void loadNameSet()
	{
		loadFromTemplate();
	}

	public void resetTemplate()
	{
		loadFromTemplate(pReset: true);
	}

	public void clickRegenerateNames()
	{
		resetNameGenerationTextBox();
	}

	public void randomEverything()
	{
		_onomastics_data.clearTemplateData();
		int num = Randy.randomInt(3, 5);
		bool flag = Randy.randomBool();
		for (int i = 1; i <= num; i++)
		{
			string pString = ((!flag) ? getRandomConsonants() : getRandomVowels());
			flag = !flag;
			_onomastics_data.setGroup("group_" + i, pString);
		}
		fillRandomCards();
		loadInitialButtons();
		openFirstGroup();
		resetNameGenerationTextBox();
	}

	public void randomCards()
	{
		fillRandomCards();
		loadInitialButtons();
		openFirstGroup();
		resetNameGenerationTextBox();
	}

	public void fillRandomCards()
	{
		_onomastics_data.clearTemplateData();
		using ListPool<string> listPool = new ListPool<string>();
		using (new ListPool<string>())
		{
			foreach (KeyValuePair<string, OnomasticsDataGroup> group in _onomastics_data.groups)
			{
				if (!group.Value.isEmpty())
				{
					listPool.Add(group.Key);
				}
			}
			int num = Randy.randomInt(2, 6);
			for (int i = 0; i < num; i++)
			{
				string random = listPool.GetRandom();
				_onomastics_data.addToTemplateData(random);
			}
			for (int j = 0; j < num / 2; j++)
			{
				OnomasticsAsset random2 = AssetManager.onomastics_library.list_special.GetRandom();
				_onomastics_data.addToTemplateData(random2.id);
			}
			_onomastics_data.shuffleAllCards();
		}
	}

	private string getRandomVowels()
	{
		string text = string.Empty;
		int num = Randy.randomInt(2, 4);
		for (int i = 0; i < num; i++)
		{
			text = text + vowel_combinations[Randy.randomInt(0, vowel_combinations.Length)] + " ";
		}
		return text;
	}

	private string getRandomConsonants()
	{
		string text = string.Empty;
		int num = Randy.randomInt(2, 4);
		for (int i = 0; i < num; i++)
		{
			text = text + consonant_combinations[Randy.randomInt(0, consonant_combinations.Length)] + " ";
		}
		return text;
	}

	public void saveToLibrary()
	{
		string current_template = OnomasticsDropdown.current_template;
		int current_template_index = OnomasticsDropdown.current_template_index;
		Debug.Log("Saving to library: " + current_template + " " + current_template_index);
		string shortTemplate = _onomastics_data.getShortTemplate();
		NameGeneratorAsset nameGeneratorAsset = AssetManager.name_generator.get(current_template);
		if (current_template_index >= nameGeneratorAsset.onomastics_templates.Count)
		{
			nameGeneratorAsset.onomastics_templates.Add(shortTemplate);
		}
		else
		{
			nameGeneratorAsset.onomastics_templates[current_template_index] = shortTemplate;
		}
		AssetManager.name_generator.exportAssets();
	}

	public void saveToClipboard()
	{
		string shortTemplate = _onomastics_data.getShortTemplate();
		GUIUtility.systemCopyBuffer = "`" + shortTemplate + "`";
		WorldTip.showNow("onomastics_exported", pTranslate: true, "top");
	}

	public void saveNamesToClipboard()
	{
		string text = "";
		text += "## Template: \n\n";
		text += _onomastics_data.getShortTemplate();
		text += "\n\n";
		if (_onomastics_data.isGendered())
		{
			string text2 = "";
			string text3 = "";
			for (int i = 0; i < 25; i++)
			{
				string text4 = _onomastics_data.generateName(ActorSex.Male);
				text2 = text2 + "- " + text4 + "\n";
				text4 = _onomastics_data.generateName(ActorSex.Female);
				text3 = text3 + "- " + text4 + "\n";
			}
			text = text + "## Male names: \n\n" + text2;
			text += "\n";
			text = text + "## Female names: \n\n" + text3;
		}
		else
		{
			text += "## Generated names: \n\n";
			for (int j = 0; j < 50; j++)
			{
				string text5 = _onomastics_data.generateName();
				text = text + "- " + text5 + "\n";
			}
		}
		GUIUtility.systemCopyBuffer = text;
	}

	public void loadFromClipboard()
	{
		string systemCopyBuffer = GUIUtility.systemCopyBuffer;
		loadTemplate(systemCopyBuffer);
	}

	public void loadTemplate(string pTemplate = null)
	{
		string shortTemplate = _onomastics_data.getShortTemplate();
		pTemplate = pTemplate?.Trim('\n', '\r', ' ', '"', '`') ?? "";
		try
		{
			if (!_onomastics_data.templateIsValid(pTemplate))
			{
				throw new ArgumentException("Invalid template format: (OT) " + pTemplate);
			}
			_onomastics_data.loadFromShortTemplate(pTemplate);
		}
		catch (ArgumentException ex)
		{
			WorldTip.showNow("onomastics_import_error_invalid", pTranslate: true, "top", 3f, "#FF637D");
			Debug.LogWarning(ex.Message);
			return;
		}
		catch (Exception ex2)
		{
			WorldTip.showNow("onomastics_import_error_logs", pTranslate: true, "top", 3f, "#FF637D");
			Debug.LogWarning(ex2.Message);
			return;
		}
		Debug.Log("old: " + shortTemplate.Trim('\n', '\r', ' ', '"', '`'));
		Debug.Log("new: " + pTemplate);
		WorldTip.showNow(pTemplate, pTranslate: false, "top");
		loadInitialButtons();
		openFirstGroup();
		resetNameGenerationTextBox();
	}

	public static string debugTemplateReport(string pTemplateName)
	{
		OnomasticsData originalData = OnomasticsCache.getOriginalData(AssetManager.name_generator.get(pTemplateName).onomastics_templates.GetRandom());
		string text = "";
		text += "## Template: \n\n";
		text += originalData.getShortTemplate();
		text += "\n\n";
		if (originalData.isGendered())
		{
			string text2 = "";
			string text3 = "";
			for (int i = 0; i < 25; i++)
			{
				string text4 = originalData.generateName(ActorSex.Male);
				if (i > 0)
				{
					text2 += ", ";
				}
				text2 += text4;
				text4 = originalData.generateName(ActorSex.Female);
				if (i > 0)
				{
					text3 += ", ";
				}
				text3 += text4;
			}
			text = text + "## Male names: \n\n" + text2;
			text += "\n";
			text = text + "## Female names: \n\n" + text3;
		}
		else
		{
			text += "## Generated names: \n\n";
			for (int j = 0; j < 50; j++)
			{
				string text5 = originalData.generateName();
				if (j > 0)
				{
					text += ", ";
				}
				text += text5;
			}
		}
		return text + "\n\n";
	}
}
