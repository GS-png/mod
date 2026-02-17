using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DebugTool : MonoBehaviour
{
	public const int DT_WIDTH = 126;

	public const int DT_HEIGHT = 60;

	protected ObjectPoolGenericMono<DebugToolTextElement> pool_texts;

	public DebugToolTextElement element_prefab;

	internal int textCount;

	public Dropdown dropdown;

	internal bool sort_order_reversed;

	internal bool sort_by_names;

	internal bool sort_by_values = true;

	internal bool show_averages = true;

	internal bool percentage_slowest;

	internal bool hide_zeroes = true;

	internal bool show_counter = true;

	internal bool show_max = true;

	internal DebugToolState state = DebugToolState.FrameBudget;

	public DebugToolType type;

	internal bool paused;

	internal DebugToolAsset asset;

	[HideInInspector]
	public DebugDropdown active_dropdown;

	private double last_update_timestamp;

	private List<DebugIconOptionAction> list_actions = new List<DebugIconOptionAction>();

	private List<Image> list_icons = new List<Image>();

	private Transform transform_texts;

	private Transform benchmark_icons;

	private string _latest_text;

	private void Awake()
	{
		populateOptions();
		benchmark_icons = base.transform.FindRecursive("Benchmark Icons");
		initButtons();
		initElements();
	}

	private void initElements()
	{
		transform_texts = base.transform.FindRecursive("Texts");
		pool_texts = new ObjectPoolGenericMono<DebugToolTextElement>(element_prefab, transform_texts);
		element_prefab.gameObject.SetActive(value: false);
	}

	private float calculateLineHeight(Text pText)
	{
		Vector2 extents = pText.cachedTextGenerator.rectExtents.size * 0.5f;
		return pText.cachedTextGeneratorForLayout.GetPreferredHeight("A", pText.GetGenerationSettings(extents));
	}

	internal void populateOptions()
	{
		dropdown.ClearOptions();
		List<string> list = new List<string>();
		foreach (DebugToolAsset item in AssetManager.debug_tool_library.list)
		{
			if (item.type == type)
			{
				list.Add(item.name);
			}
		}
		dropdown.AddOptions(list);
		dropdown.onValueChanged.RemoveListener(switchTool);
		dropdown.onValueChanged.AddListener(switchTool);
	}

	public void filterOptions(string pInput)
	{
		DebugDropdownOption[] componentsInChildren = active_dropdown.transform.GetComponentsInChildren<DebugDropdownOption>(includeInactive: true);
		foreach (DebugDropdownOption debugDropdownOption in componentsInChildren)
		{
			string text = debugDropdownOption.title.text;
			if (text == "Debug option")
			{
				debugDropdownOption.gameObject.SetActive(value: false);
			}
			else if (!string.IsNullOrEmpty(pInput) && !text.ToLower().Contains(pInput.ToLower()))
			{
				debugDropdownOption.gameObject.SetActive(value: false);
			}
			else
			{
				debugDropdownOption.gameObject.SetActive(value: true);
			}
		}
	}

	private void initButtons()
	{
		newButton("SortByName", clickSortByName, delegate(Image pIcon)
		{
			checkIcon(pIcon, sort_by_names);
		});
		newButton("SortByValues", clickSortByValues, delegate(Image pIcon)
		{
			checkIcon(pIcon, sort_by_values);
		});
		newButton("SortReversed", delegate
		{
			sort_order_reversed = !sort_order_reversed;
		}, delegate(Image pIcon)
		{
			checkIcon(pIcon, sort_order_reversed);
		});
		newButton("ShowAverages", delegate
		{
			show_averages = !show_averages;
		}, delegate(Image pIcon)
		{
			checkIcon(pIcon, isValueAverage());
		});
		newButton("PercentBasedOnSlowest", delegate
		{
			percentage_slowest = !percentage_slowest;
		}, delegate(Image pIcon)
		{
			checkIcon(pIcon, percentage_slowest);
		});
		newButton("HideZeroes", delegate
		{
			hide_zeroes = !hide_zeroes;
		}, delegate(Image pIcon)
		{
			checkIcon(pIcon, hide_zeroes);
		});
		newButton("ShowCounter", delegate
		{
			show_counter = !show_counter;
		}, delegate(Image pIcon)
		{
			checkIcon(pIcon, show_counter);
		});
		newButton("ShowMax", delegate
		{
			show_max = !show_max;
		}, delegate(Image pIcon)
		{
			checkIcon(pIcon, show_max);
		});
		newButton("ShowSeconds", delegate
		{
			state = DebugToolState.Values;
		}, delegate(Image pIcon)
		{
			checkIcon(pIcon, state == DebugToolState.Values);
		});
		newButton("ShowPercentages", delegate
		{
			state = DebugToolState.Percent;
		}, delegate(Image pIcon)
		{
			checkIcon(pIcon, state == DebugToolState.Percent);
		});
		newButton("ShowTimeSpent", delegate
		{
			state = DebugToolState.TimeSpent;
		}, delegate(Image pIcon)
		{
			checkIcon(pIcon, state == DebugToolState.TimeSpent);
		});
		newButton("ShowFrameBudget", delegate
		{
			state = DebugToolState.FrameBudget;
		}, delegate(Image pIcon)
		{
			checkIcon(pIcon, state == DebugToolState.FrameBudget);
		});
		newButton("Paused", delegate
		{
			paused = !paused;
		}, delegate(Image pIcon)
		{
			checkIcon(pIcon, paused);
		});
		newButton("EnableBenchmarks", delegate
		{
			Bench.bench_enabled = !Bench.bench_enabled;
		}, delegate(Image pIcon)
		{
			checkIcon(pIcon, Bench.bench_enabled);
		});
	}

	private void newButton(string pID, UnityAction pAction, DebugIconOptionAction pCheckIcon)
	{
		Transform transform = base.transform.FindRecursive(pID);
		transform.GetComponent<Button>().onClick.AddListener(pAction);
		list_actions.Add(pCheckIcon);
		list_icons.Add(transform.GetComponent<Image>());
	}

	public bool isValueAverage()
	{
		return show_averages;
	}

	public bool isState(DebugToolState pState)
	{
		return state == pState;
	}

	private void updateIcons()
	{
		for (int i = 0; i < list_actions.Count; i++)
		{
			DebugIconOptionAction debugIconOptionAction = list_actions[i];
			Image pButton = list_icons[i];
			debugIconOptionAction(pButton);
		}
	}

	private void checkIcon(Image pImageIcon, bool pValue)
	{
		if (pValue)
		{
			pImageIcon.color = Color.white;
		}
		else
		{
			pImageIcon.color = Toolbox.color_transparent_grey;
		}
	}

	private void switchTool(int pIndex)
	{
		string text = dropdown.options[pIndex].text;
		DebugToolAsset debugToolAsset = AssetManager.debug_tool_library.get(text);
		setAsset(debugToolAsset);
	}

	public void setAsset(DebugToolAsset pAsset)
	{
		asset = pAsset;
		type = asset.type;
		benchmark_icons.gameObject.SetActive(asset.show_benchmark_buttons);
		if (asset.action_start != null)
		{
			asset.action_start(this);
		}
	}

	private void Update()
	{
		if (SmoothLoader.isLoading())
		{
			return;
		}
		updateIcons();
		double curSessionTime = World.world.getCurSessionTime();
		if (!(curSessionTime < last_update_timestamp + (double)asset.update_timeout) && !paused)
		{
			if (asset.action_update != null)
			{
				asset.action_update(this);
			}
			clearTexts();
			_ = dropdown.captionText.text;
			last_update_timestamp = curSessionTime;
			if (asset.action_1 != null)
			{
				asset.action_1(this);
			}
			if (asset.action_2 != null)
			{
				asset.action_2(this);
			}
			updateSize();
			pool_texts.disableInactive();
			StartCoroutine(updateSizeAfterFrame());
		}
	}

	public IEnumerator updateSizeAfterFrame()
	{
		yield return CoroutineHelper.wait_for_end_of_frame;
		updateSize();
	}

	private void updateSize()
	{
		float num = LayoutUtility.GetPreferredWidth(transform_texts.GetComponent<RectTransform>()) * 1.2f;
		float num2 = LayoutUtility.GetPreferredHeight(transform_texts.GetComponent<RectTransform>()) + 40f;
		if (num < 126f)
		{
			num = 126f;
		}
		if (num2 < 60f)
		{
			num2 = 60f;
		}
		GetComponent<RectTransform>().sizeDelta = new Vector2(num, num2);
	}

	public void clickSortByName()
	{
		sort_by_names = !sort_by_names;
		sort_by_values = !sort_by_names;
	}

	public void clickSortByValues()
	{
		sort_by_values = !sort_by_values;
		sort_by_names = !sort_by_values;
	}

	public int kingdomSorter(Kingdom k1, Kingdom k2)
	{
		return k2.units.Count.CompareTo(k1.units.Count);
	}

	public int citySorter(City c1, City c2)
	{
		return c2.getPopulationPeople().CompareTo(c1.getPopulationPeople());
	}

	internal void setText(string pT1, object pT2, float pBarValue = 0f, bool pShowBar = false, long pCounter = 0L, bool pShowCounter = false, bool pShowMax = false, string pMaxValue = "")
	{
		DebugToolTextElement next = pool_texts.getNext();
		string text = ((pT2 == null) ? "-" : pT2.ToString());
		if (pT2 != null)
		{
			if (pShowCounter && show_counter && (asset.split_benchmark || asset.show_last_count))
			{
				text = pCounter + " | " + text;
			}
			if (pShowMax)
			{
				text = pMaxValue + " | " + text;
			}
		}
		next.text_left.text = pT1;
		next.text_right.text = text;
		textCount++;
		if (pShowBar)
		{
			next.text_bar.gameObject.SetActive(value: true);
			if (pBarValue > 100f)
			{
				pBarValue = 101f;
			}
			float x = pBarValue * 0.5f;
			next.text_bar.GetComponent<RectTransform>().sizeDelta = new Vector2(x, 4.2f);
			if (pBarValue > 70f && pBarValue != 100f)
			{
				next.text_bar.color = Toolbox.color_debug_bar_red;
			}
			else
			{
				next.text_bar.color = Toolbox.color_debug_bar_blue;
			}
		}
		else
		{
			next.text_bar.gameObject.SetActive(value: false);
		}
	}

	internal void setSeparator()
	{
		DebugToolTextElement next = pool_texts.getNext();
		next.text_left.text = string.Empty;
		next.text_right.text = string.Empty;
		next.text_bar.gameObject.SetActive(value: false);
	}

	private void clearTexts()
	{
		textCount = 0;
		pool_texts.clear(pDisable: false);
	}

	public void clickClose()
	{
		Object.Destroy(base.gameObject, 0.01f);
	}

	public void clickDuplicate()
	{
		int pX = (int)base.transform.localPosition.x + 126 + 2;
		int pY = (int)base.transform.localPosition.y;
		DebugConfig.createTool(asset.id, pX, pY);
	}
}
