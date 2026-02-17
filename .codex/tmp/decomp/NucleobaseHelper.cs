using UnityEngine;

public static class NucleobaseHelper
{
	private const char SHORT_ADENINE = 'A';

	private const char SHORT_CYTOSINE = 'C';

	private const char SHORT_GUANINE = 'G';

	private const char SHORT_THYMINE = 'T';

	private const string NOT_CONNECTED_TRANSPARENCY = "88";

	private const string COLOR_HEX_ADENINE = "#70FF70";

	private const string COLOR_HEX_CYTOSINE = "#3A8FFF";

	private const string COLOR_HEX_GUANINE = "#FFDF42";

	private const string COLOR_HEX_THYMINE = "#FF3A3A";

	private const string COLOR_HEX_ADENINE_DARK = "#70FF7088";

	private const string COLOR_HEX_CYTOSINE_DARK = "#3A8FFF88";

	private const string COLOR_HEX_GUANINE_DARK = "#FFDF4288";

	private const string COLOR_HEX_THYMINE_DARK = "#FF3A3A88";

	private static readonly Color color_adenine = Toolbox.makeColor("#70FF70");

	private static readonly Color color_cytosine = Toolbox.makeColor("#3A8FFF");

	private static readonly Color color_guanine = Toolbox.makeColor("#FFDF42");

	private static readonly Color color_thymine = Toolbox.makeColor("#FF3A3A");

	private static readonly Color color_adenine_dark = Toolbox.makeColor("#70FF7088");

	private static readonly Color color_cytosine_dark = Toolbox.makeColor("#3A8FFF88");

	private static readonly Color color_guanine_dark = Toolbox.makeColor("#FFDF4288");

	private static readonly Color color_thymine_dark = Toolbox.makeColor("#FF3A3A88");

	public static readonly Color color_bad = Color.black;

	public const string COLOR_HEX_BAD = "#B159FF";

	public static Color getColor(char pChar, bool pDark = false)
	{
		if (pDark)
		{
			return pChar switch
			{
				'A' => color_adenine_dark, 
				'C' => color_cytosine_dark, 
				'G' => color_guanine_dark, 
				'T' => color_thymine_dark, 
				_ => Color.black, 
			};
		}
		return pChar switch
		{
			'A' => color_adenine, 
			'C' => color_cytosine, 
			'G' => color_guanine, 
			'T' => color_thymine, 
			_ => Color.black, 
		};
	}

	public static string getColorHex(char pChar, bool pDark = false)
	{
		string result = string.Empty;
		if (pDark)
		{
			switch (pChar)
			{
			case 'A':
				result = "#70FF7088";
				break;
			case 'C':
				result = "#3A8FFF88";
				break;
			case 'G':
				result = "#FFDF4288";
				break;
			case 'T':
				result = "#FF3A3A88";
				break;
			}
		}
		else
		{
			switch (pChar)
			{
			case 'A':
				result = "#70FF70";
				break;
			case 'C':
				result = "#3A8FFF";
				break;
			case 'G':
				result = "#FFDF42";
				break;
			case 'T':
				result = "#FF3A3A";
				break;
			}
		}
		return result;
	}

	private static string getNucleobaseFullID(char pChar)
	{
		string result = string.Empty;
		switch (pChar)
		{
		case 'A':
			result = "nucleo_adenine";
			break;
		case 'C':
			result = "nucleo_cytosine";
			break;
		case 'G':
			result = "nucleo_guanine";
			break;
		case 'T':
			result = "nucleo_thymine";
			break;
		}
		return result;
	}

	public static string getColoredNucleobaseFull(char pChar)
	{
		string colorHex = getColorHex(pChar);
		string fullNucleobaseName = getFullNucleobaseName(pChar);
		return "<color=" + colorHex + ">" + fullNucleobaseName + "</color>";
	}

	public static string getFullNucleobaseName(char pChar)
	{
		return LocalizedTextManager.getText(getNucleobaseFullID(pChar));
	}

	public static string getColoredSequence(string pGeneticCode)
	{
		string text = string.Empty;
		foreach (char c in pGeneticCode)
		{
			string colorHex = getColorHex(c);
			text += $"<color={colorHex}>{c}</color>";
		}
		return text;
	}
}
