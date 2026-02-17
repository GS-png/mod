using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OnomasticsDropdown : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[SerializeField]
	private OnomasticsTab _onomastics_tab;

	private Button _button;

	private Dropdown _dropdown;

	private List<string> _options;

	internal static string current_template;

	internal static int current_template_index;

	private void Start()
	{
		_dropdown = GetComponent<Dropdown>();
		createDropdownOptions();
		_dropdown.onValueChanged.AddListener(dropdownValueChanged);
	}

	private void createDropdownOptions()
	{
		_dropdown.ClearOptions();
		_options = new List<string>();
		_options.Add("");
		foreach (NameGeneratorAsset item in AssetManager.name_generator.list)
		{
			if (item.onomastics_templates.Count < 1)
			{
				_options.Add("<color=red>" + item.id + "</color>");
				continue;
			}
			if (item.onomastics_templates.Count < 2)
			{
				_options.Add(item.id);
				continue;
			}
			for (int i = 0; i < item.onomastics_templates.Count; i++)
			{
				_options.Add(item.id + "#" + i);
			}
		}
		_options.Sort((string a, string b) => Toolbox.removeRichTextTags(a).CompareTo(Toolbox.removeRichTextTags(b)));
		_dropdown.AddOptions(_options);
	}

	private void dropdownValueChanged(int pOption)
	{
		if (pOption < 0 || pOption >= _dropdown.options.Count)
		{
			return;
		}
		string text = _dropdown.options[pOption].text;
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		text = Toolbox.removeRichTextTags(text);
		int result = 0;
		if (text.Contains('#'))
		{
			string[] array = text.Split('#');
			text = array[0];
			if (!int.TryParse(array[1], out result))
			{
				return;
			}
		}
		NameGeneratorAsset nameGeneratorAsset = AssetManager.name_generator.get(text);
		if (nameGeneratorAsset != null)
		{
			current_template = text;
			current_template_index = result;
			string pTemplate = null;
			if (result >= 0 && result < nameGeneratorAsset.onomastics_templates.Count)
			{
				pTemplate = nameGeneratorAsset.onomastics_templates[result];
			}
			_onomastics_tab.loadTemplate(pTemplate);
		}
	}

	public void OnPointerClick(PointerEventData pEventData)
	{
		if (pEventData.selectedObject == null || pEventData.selectedObject.GetComponentInChildren<Scrollbar>() != null || !_dropdown.IsActive() || !_dropdown.IsInteractable())
		{
			return;
		}
		Scrollbar scrollbar = base.gameObject.GetComponentInChildren<ScrollRect>()?.verticalScrollbar;
		if (_options.Count > 1 && scrollbar != null)
		{
			if (scrollbar.direction == Scrollbar.Direction.TopToBottom)
			{
				scrollbar.value = Mathf.Max(0.001f, (float)_dropdown.value / (float)(_options.Count - 1));
			}
			else
			{
				scrollbar.value = Mathf.Max(0.001f, 1f - (float)_dropdown.value / (float)(_options.Count - 1));
			}
		}
	}
}
