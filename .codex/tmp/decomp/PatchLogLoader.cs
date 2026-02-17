using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Humanizer;
using UnityEngine;
using UnityEngine.UI;

public class PatchLogLoader : MonoBehaviour
{
	private const int FIRST_UNFOLDED_ELEMS_AMOUNT = 5;

	[SerializeField]
	private GameObject _prefab_text;

	[SerializeField]
	private GameObject _prefab_entry_bg;

	[SerializeField]
	private PatchLogElement _prefab_element;

	private readonly List<GameObject> _visual_elements = new List<GameObject>();

	private readonly Dictionary<string, PatchLogEntry> _entries_dict = new Dictionary<string, PatchLogEntry>();

	private readonly List<PatchLogEntry> _entries_list = new List<PatchLogEntry>();

	public void OnEnable()
	{
		loadEntries();
		StartCoroutine(createElements());
	}

	private void loadEntries()
	{
		if (_entries_list.Count > 0)
		{
			return;
		}
		TextAsset[] array = Resources.LoadAll<TextAsset>("texts/patch_notes");
		if (array.Length == 0)
		{
			return;
		}
		TextAsset[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			string[] array3 = array2[i].text.Split(new string[1] { "##########" }, StringSplitOptions.None);
			string[] array4 = array3[0].Split(new string[3] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
			string version = array4[0];
			string text = array4[1];
			string date = array4[2];
			string icon_path = array4[3];
			string text2 = array3[1];
			if (text2.StartsWith("\r\n"))
			{
				text2 = text2.Substring(2);
			}
			else if (text2.StartsWith("\n"))
			{
				text2 = text2.Substring(1);
			}
			PatchLogEntry patchLogEntry = new PatchLogEntry
			{
				version = version,
				name = text,
				date = date,
				icon_path = icon_path,
				text = text2
			};
			_entries_dict[patchLogEntry.version] = patchLogEntry;
			_entries_list.Add(patchLogEntry);
		}
		_entries_list.Sort((PatchLogEntry pA, PatchLogEntry pB) => (Version.TryParse(pA.version, out var result) && Version.TryParse(pB.version, out var result2)) ? result2.CompareTo(result) : string.Compare(pB.version, pA.version, StringComparison.Ordinal));
	}

	private IEnumerator createElements()
	{
		if (_entries_dict.Count == 0)
		{
			yield break;
		}
		for (int i = 0; i < _entries_list.Count; i++)
		{
			PatchLogEntry pEntry = _entries_list[i];
			PatchLogElement patchLogElement = showEntry(pEntry);
			if (!(patchLogElement == null))
			{
				if (i < 5)
				{
					patchLogElement.unfold();
				}
				else
				{
					patchLogElement.fold();
				}
				yield return new WaitForSeconds(0.05f);
			}
		}
	}

	private PatchLogElement showEntry(PatchLogEntry pEntry)
	{
		if (!CursedSacrifice.isAllSacrificesDone() && !WorldLawLibrary.world_law_cursed_world.isEnabled() && pEntry.name == "VoidBox")
		{
			return null;
		}
		using ListPool<string> listPool = new ListPool<string>(10);
		string[] array = pEntry.text.Split(new string[3] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
		string text;
		try
		{
			text = prettyDaysAgo(pEntry.date);
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			throw;
		}
		bool num = isValidDate(pEntry.date);
		string text2 = (num ? pEntry.date : "???");
		string pColorHex = (num ? "#23F3FF" : "#96adb3");
		string pColorHex2 = (num ? "#FFFF51" : "#96adb3");
		string text3 = pEntry.version.ColorHex(pColorHex) + " - " + pEntry.name.ToUpper().ColorHex(pColorHex2);
		PatchLogElement patchLogElement = UnityEngine.Object.Instantiate(_prefab_element, base.gameObject.transform);
		patchLogElement.name = "PatchLog " + pEntry.version;
		_visual_elements.Add(patchLogElement.gameObject);
		PatchLogTitle title = patchLogElement.title;
		title.title.text = text3;
		patchLogElement.date.text = text2;
		patchLogElement.date_ago.text = text;
		Sprite sprite = SpriteTextureLoader.getSprite(pEntry.icon_path);
		if (sprite == null)
		{
			Debug.LogError("Failed to load icon in " + pEntry.version);
		}
		title.icon_left.sprite = sprite;
		title.icon_right.sprite = sprite;
		for (int i = 0; i < array.Length; i += 10)
		{
			listPool.Clear();
			for (int j = i; j < i + 10 && j < array.Length; j++)
			{
				listPool.Add(array[j]);
			}
			string pText = string.Join("\n", listPool);
			pText = colorElements(pText);
			createTextField(pText, patchLogElement.texts.gameObject).color = Toolbox.color_text_default_bright;
		}
		return patchLogElement;
	}

	private string prettyDaysAgo(string pDateString)
	{
		if (!isValidDate(pDateString))
		{
			return pDateString;
		}
		DateTime dateTime = DateTime.ParseExact(pDateString, "yyyy-MM-dd", null);
		int days = (DateTime.UtcNow - dateTime).Days;
		CultureInfo culture = LocalizedTextManager.getCulture();
		CultureInfo culture2 = culture;
		string text = dateTime.Humanize(utcDate: true, null, culture2);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return days + " days ago";
	}

	private bool isValidDate(string pInput)
	{
		DateTime result;
		return DateTime.TryParseExact(pInput, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out result);
	}

	private Text createTextField(string pText, GameObject pEntryBackground)
	{
		Text component = UnityEngine.Object.Instantiate(_prefab_text, pEntryBackground.transform).GetComponent<Text>();
		component.text = pText;
		_visual_elements.Add(component.gameObject);
		return component;
	}

	private string colorElements(string pText)
	{
		pText = pText.Replace("added:", "<color=#4CCFFF>added:</color>");
		pText = pText.Replace("fixed:", "<color=#D95032>fixed:</color>");
		pText = pText.Replace("fixes:", "<color=#D95032>fixed:</color>");
		pText = pText.Replace("fxed:", "<color=#D95032>fixed:</color>");
		pText = pText.Replace("changes:", "<color=#F3961F>changed:</color>");
		pText = pText.Replace("changed:", "<color=#F3961F>changed:</color>");
		pText = pText.Replace("ongoing:", "<color=#4CCFFF>ongoing:</color>");
		pText = pText.Replace("modding:", "<color=#43FF43>modding:</color>");
		pText = pText.Replace("known issues:", "<color=#D95032>known issues:</color>");
		pText = pText.Replace("translations:", "<color=#d6abff>translation:</color>");
		return pText;
	}

	public void OnDisable()
	{
		foreach (GameObject visual_element in _visual_elements)
		{
			UnityEngine.Object.Destroy(visual_element.gameObject);
		}
		_visual_elements.Clear();
	}
}
