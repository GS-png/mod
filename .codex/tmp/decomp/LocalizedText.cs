using System.Collections.Generic;
using System.Text.RegularExpressions;
using UPersian.Utils;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LocalizedText : UIBehaviour
{
	public const string DEFAULT_KEY = "??????";

	protected const char LINE_ENDING = '\n';

	public bool convertToUppercase;

	public bool autoField = true;

	public bool specialTags;

	public string key = "??????";

	private FontStyle? _font_style_before;

	private bool? _shadow_before = false;

	private bool _has_shadow;

	internal Text text;

	private TextAnchor? _text_alignment_before;

	protected override void Awake()
	{
		base.Awake();
		text = GetComponent<Text>();
	}

	protected override void Start()
	{
		base.Start();
		if (autoField)
		{
			LocalizedTextManager.addTextField(this);
			updateText();
		}
	}

	public void setKeyAndUpdate(string pKey)
	{
		key = pKey;
		updateText();
	}

	protected override void OnRectTransformDimensionsChange()
	{
		GameLanguageAsset current_language = LocalizedTextManager.current_language;
		if ((current_language == null || current_language.isRTL()) && !string.IsNullOrEmpty(key) && !(key == "??????") && !(text == null))
		{
			updateText();
			base.OnRectTransformDimensionsChange();
		}
	}

	internal virtual void updateText(bool pCheckText = true)
	{
		if (this.text == null || LocalizedTextManager.instance == null || !LocalizedTextManager.instance.initiated)
		{
			return;
		}
		if (LocalizedTextManager.current_font != null)
		{
			this.text.font = LocalizedTextManager.current_font;
		}
		string text = LocalizedTextManager.getText(key, this.text);
		if (convertToUppercase)
		{
			text = text.ToUpper();
		}
		if (specialTags && text.Contains("$"))
		{
			if (text.Contains("$total_prem_powers$"))
			{
				text = text.Replace("$total_prem_powers$", GodPower.premium_powers.Count.ToString() ?? "");
			}
			if (text.Contains("$minutes$"))
			{
				text = text.Replace("$minutes$", 30.ToString() ?? "");
			}
			if (text.Contains("$minutes_clock$"))
			{
				text = text.Replace("$minutes_clock$", 720.ToString() ?? "");
			}
			if (text.Contains("$hours_clock$"))
			{
				text = text.Replace("$hours_clock$", 12.ToString() ?? "");
			}
			if (text.Contains("$power$") && Config.power_to_unlock != null)
			{
				text = text.Replace("$power$", Config.power_to_unlock.getLocaleID().Localize() ?? "");
			}
			if (text.Contains("$hours$"))
			{
				text = text.Replace("$hours$", 3.ToString() ?? "");
			}
			if (text.Contains("$number$"))
			{
				text = text.Replace("$number$", 3.ToString() ?? "");
			}
			if (text.Contains("$discord_count$"))
			{
				text = text.Replace("$discord_count$", 560000.ToText() ?? "");
			}
			if (text.Contains("$wbcode$"))
			{
				text = text.Replace("$wbcode$", "<color=cyan>WB-5555-1166-5555</color>");
			}
			if (text.Contains("$lifeissimhours$"))
			{
				text = text.Replace("$lifeissimhours$", 24f.ToText());
			}
			if (text.Contains("$current_era_year"))
			{
				text = text.Replace("$current_era_year$", Date.getCurrentYear().ToText());
			}
			if (text.Contains("$era_moons_left"))
			{
				int pInt = World.world.era_manager.calculateMoonsLeft();
				text = text.Replace("$era_moons_left$", pInt.ToText());
			}
		}
		this.text.text = text;
		checkTextFont();
		if (pCheckText)
		{
			checkSpecialLanguages();
		}
	}

	internal void checkTextFont(GameLanguageAsset pLanguage = null)
	{
		if (!(text == null))
		{
			if (pLanguage == null)
			{
				pLanguage = LocalizedTextManager.current_language;
			}
			Font font = pLanguage.font();
			if (!(font == null))
			{
				text.font = font;
			}
		}
	}

	internal void checkSpecialLanguages(GameLanguageAsset pLanguage = null)
	{
		if (text == null)
		{
			return;
		}
		if (pLanguage == null)
		{
			pLanguage = LocalizedTextManager.current_language;
		}
		checkTextFont(pLanguage);
		if (!_text_alignment_before.HasValue)
		{
			_text_alignment_before = text.alignment;
		}
		if (!_font_style_before.HasValue)
		{
			_font_style_before = text.fontStyle;
		}
		if (!_shadow_before.HasValue)
		{
			_shadow_before = (_has_shadow = text.HasComponent<Shadow>());
		}
		if (pLanguage.hasForcedStyle())
		{
			text.fontStyle = pLanguage.force_style.style;
			if (text.fontSize < 9 && pLanguage.force_style.shadow && !_has_shadow)
			{
				text.gameObject.AddComponent<Shadow>().effectColor = new Color(0f, 0f, 0f, 160f);
				_has_shadow = true;
			}
		}
		else
		{
			text.fontStyle = _font_style_before.Value;
			if (_has_shadow && _shadow_before == false)
			{
				if (text.TryGetComponent<Shadow>(out var component))
				{
					Object.Destroy(component);
				}
				_has_shadow = false;
			}
		}
		if (pLanguage.isRTL())
		{
			text.text = getRTLText(text, text.text);
			text.alignment = getRTLAlignment(_text_alignment_before.Value);
		}
		else
		{
			text.alignment = _text_alignment_before.Value;
		}
		if (pLanguage.isHindi() && !Regex.IsMatch(text.text, "[a-zA-Z]"))
		{
			text.SetHindiText(text.text);
		}
	}

	internal static string getRTLText(Text pText, string pString)
	{
		pText.cachedTextGenerator.Populate(pString, pText.GetGenerationSettings(pText.rectTransform.rect.size));
		if (!(pText.cachedTextGenerator.lines is List<UILineInfo> list))
		{
			return null;
		}
		string pStr = "";
		if (list.Count == 0)
		{
			pStr = pString;
		}
		for (int i = 0; i < list.Count; i++)
		{
			if (i < list.Count - 1)
			{
				int startCharIdx = list[i].startCharIdx;
				int length = list[i + 1].startCharIdx - list[i].startCharIdx;
				pStr += pString.Substring(startCharIdx, length);
				if (pStr.Length > 0 && pStr[pStr.Length - 1] != '\n' && pStr[pStr.Length - 1] != '\r')
				{
					pStr += "\n";
				}
			}
			else
			{
				pStr += pString.Substring(list[i].startCharIdx);
			}
		}
		UPersianUtils.RtlFix(ref pStr);
		return pStr;
	}

	internal TextAnchor getRTLAlignment(TextAnchor pTextAlignment)
	{
		return pTextAlignment switch
		{
			TextAnchor.UpperLeft => TextAnchor.UpperRight, 
			TextAnchor.UpperRight => TextAnchor.UpperLeft, 
			TextAnchor.MiddleLeft => TextAnchor.MiddleRight, 
			TextAnchor.MiddleRight => TextAnchor.MiddleLeft, 
			TextAnchor.LowerLeft => TextAnchor.LowerRight, 
			TextAnchor.LowerRight => TextAnchor.LowerLeft, 
			_ => pTextAlignment, 
		};
	}
}
