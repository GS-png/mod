using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityPools;

public static class Toolbox
{
	public static readonly ActorDirection[] directions = new ActorDirection[4]
	{
		ActorDirection.Up,
		ActorDirection.Right,
		ActorDirection.Down,
		ActorDirection.Left
	};

	public static readonly ActorDirection[] directions_all = new ActorDirection[8]
	{
		ActorDirection.Up,
		ActorDirection.UpRight,
		ActorDirection.UpLeft,
		ActorDirection.Right,
		ActorDirection.DownRight,
		ActorDirection.DownLeft,
		ActorDirection.Down,
		ActorDirection.Left
	};

	public static readonly Dictionary<ActorDirection, ActorDirection[]> directions_turns = new Dictionary<ActorDirection, ActorDirection[]>
	{
		{
			ActorDirection.Up,
			new ActorDirection[2]
			{
				ActorDirection.Right,
				ActorDirection.Left
			}
		},
		{
			ActorDirection.Right,
			new ActorDirection[2]
			{
				ActorDirection.Down,
				ActorDirection.Up
			}
		},
		{
			ActorDirection.Down,
			new ActorDirection[2]
			{
				ActorDirection.Left,
				ActorDirection.Right
			}
		},
		{
			ActorDirection.Left,
			new ActorDirection[2]
			{
				ActorDirection.Up,
				ActorDirection.Down
			}
		}
	};

	public static readonly Dictionary<ActorDirection, ActorDirection[]> directions_all_turns = new Dictionary<ActorDirection, ActorDirection[]>
	{
		{
			ActorDirection.Up,
			new ActorDirection[4]
			{
				ActorDirection.Right,
				ActorDirection.UpRight,
				ActorDirection.UpLeft,
				ActorDirection.Left
			}
		},
		{
			ActorDirection.UpRight,
			new ActorDirection[4]
			{
				ActorDirection.DownRight,
				ActorDirection.Right,
				ActorDirection.Up,
				ActorDirection.UpLeft
			}
		},
		{
			ActorDirection.Right,
			new ActorDirection[4]
			{
				ActorDirection.Down,
				ActorDirection.DownRight,
				ActorDirection.UpRight,
				ActorDirection.Up
			}
		},
		{
			ActorDirection.DownRight,
			new ActorDirection[4]
			{
				ActorDirection.DownLeft,
				ActorDirection.Down,
				ActorDirection.Right,
				ActorDirection.UpRight
			}
		},
		{
			ActorDirection.Down,
			new ActorDirection[4]
			{
				ActorDirection.Left,
				ActorDirection.DownLeft,
				ActorDirection.DownRight,
				ActorDirection.Right
			}
		},
		{
			ActorDirection.DownLeft,
			new ActorDirection[4]
			{
				ActorDirection.UpLeft,
				ActorDirection.Left,
				ActorDirection.Down,
				ActorDirection.DownRight
			}
		},
		{
			ActorDirection.Left,
			new ActorDirection[4]
			{
				ActorDirection.Up,
				ActorDirection.UpLeft,
				ActorDirection.DownLeft,
				ActorDirection.Down
			}
		},
		{
			ActorDirection.UpLeft,
			new ActorDirection[4]
			{
				ActorDirection.UpRight,
				ActorDirection.Up,
				ActorDirection.Left,
				ActorDirection.DownLeft
			}
		}
	};

	public static readonly Color32 EVERYTHING_MAGIC_COLOR32 = makeColor("#DF7FFF");

	public static readonly Color32 color_grey_dark = makeColor("#5D5D5D");

	public static readonly Color32 color_grey = makeColor("#AAAAAA");

	public static readonly Color32 color_transparent_grey = makeColor("#666666", 0.5f);

	public static readonly Color32 color_debug_bar_blue = makeColor("#0092FF", 0.5f);

	public static readonly Color32 color_debug_bar_red = makeColor("#FF6262", 0.5f);

	public static readonly Color32 color_phenotype_green_0 = makeColor("#B8FF96");

	public static readonly Color32 color_phenotype_green_1 = makeColor("#00FF00");

	public static readonly Color32 color_phenotype_green_2 = makeColor("#00AF00");

	public static readonly Color32 color_phenotype_green_3 = makeColor("#4A831F");

	public static readonly Color32 color_map_icon_green = makeColor("#00FF00");

	public static readonly Color32 color_magenta_0 = makeColor("#FF00FF");

	public static readonly Color32 color_magenta_1 = makeColor("#DE00DE");

	public static readonly Color32 color_magenta_2 = makeColor("#A700A7");

	public static readonly Color32 color_magenta_3 = makeColor("#7F007F");

	public static readonly Color32 color_magenta_4 = makeColor("#580058");

	public static readonly Color32 color_teal_0 = makeColor("#00EFEF");

	public static readonly Color32 color_teal_1 = makeColor("#00DBDB");

	public static readonly Color32 color_teal_2 = makeColor("#00BCBC");

	public static readonly Color32 color_teal_3 = makeColor("#009E9E");

	public static readonly Color32 color_teal_4 = makeColor("#007777");

	public static readonly Color32 color_ocean = makeColor("#3370CC");

	public static readonly Color32 color_night = makeColor("#05003F");

	public static readonly Color32 color_light = makeColor("#FFD800");

	public static readonly Color32 color_light_100 = makeColor("#FFFFFF");

	public static readonly Color32 color_light_10 = makeColor("#FFFFFF", 0.3f);

	public static readonly Color32 color_light_replace = makeColor("#000000");

	public static Color color_augmentation_selected = Color.white;

	public static Color color_augmentation_unselected = new Color(0.7f, 0.7f, 0.7f, 1f);

	public static readonly Color32 color_clear = Color.clear;

	public static Color color_white = Color.white;

	public static Color color_gray = Color.gray;

	public static Color color_black = Color.black;

	public static Color32 color_black_32 = Color.black;

	public static readonly Color32 color_white_32 = Color.white;

	public static Color color_red = Color.red;

	public static Color color_yellow = Color.yellow;

	public static Color color_blue = Color.blue;

	public static Color color_green = Color.green;

	public static Color color_purple = new Color(0.5f, 0f, 0.5f);

	public static Color color_cyan = Color.cyan;

	public static Color color_cursed = new Color(1f, 0f, 71f / 85f);

	public static Color color_abandoned_building = new Color(0.8f, 0.8f, 0.8f);

	public const string color_positive = "#43FF43";

	public const string color_negative = "#FB2C21";

	public const string color_positive_light = "#95DD5D";

	public const string color_negative_light = "#FF8686";

	public static readonly Color color_positive_RGBA = makeColor("#43FF43");

	public static readonly Color color_negative_RGBA = makeColor("#FB2C21");

	public const string color_report_positive = "#ADADAD";

	public const string color_report_negative = "#919191";

	public const string color_hex_white = "#FFFFFF";

	public const string color_hex_black = "#000000";

	public const string color_hex_neutral = "#F3961F";

	public const string color_hex_brighter = "#FFBC66";

	public const string color_tooltip_hotkey = "#95DD5D";

	public static readonly Color32 clear = Color.clear;

	public static readonly Color32 edge_alpha = makeColor("#000000", 0.1f);

	public static readonly Color color_white_transparent = makeColor("#FFFFFF", 0f);

	public static readonly Color color_text_default = makeColor("#FF9B1C");

	public static readonly Color color_text_default_bright = makeColor("#FFBC66");

	public static readonly Color color_log_good = makeColor("#95DD5D");

	public static readonly Color color_log_warning = makeColor("#FF8686");

	public static readonly Color color_log_neutral = makeColor("#F3961F");

	public static readonly Color32 color_fire = makeColor("#FF6930");

	public const string color_hex_ocean = "#3370CC";

	public const string color_hex_blue = "#4CCFFF";

	public const string color_hex_red = "#FF637D";

	public const string color_hex_green = "#43FF43";

	public const string color_hex_purple = "#E060CD";

	public const string color_hex_yellow = "#FFFF51";

	public const string color_hex_heal = "#23F3FF";

	public const string color_hex_plague = "#CE4A9B";

	public const string color_hex_mush_spores = "#8CFF99";

	public const string color_hex_infected = "#35CC6E";

	public const string color_hex_poisoned = "#D85BC5";

	public static Color color_heal = makeColor("#23F3FF");

	public static Color color_plague = makeColor("#CE4A9B");

	public static Color color_mushSpores = makeColor("#8CFF99");

	public static Color color_infected = makeColor("#35CC6E");

	public static Color color_poisoned = makeColor("#D85BC5");

	public static readonly Color[] colors_fire = new Color[10]
	{
		makeColor("#D95032"),
		makeColor("#F27F3D"),
		makeColor("#F2A444"),
		makeColor("#F2C36B"),
		makeColor("#F2CA50"),
		makeColor("#E35632"),
		makeColor("#EEB543"),
		Color.red,
		Color.yellow,
		Color.white
	};

	public static readonly Color[] colors_wheat = new Color[5]
	{
		makeColor("#20B22B"),
		makeColor("#2A8E31"),
		makeColor("#20B22B"),
		makeColor("#74A926"),
		makeColor("#FFEB93")
	};

	internal static readonly List<WorldTile> temp_list_tiles = new List<WorldTile>();

	private static readonly MapChunk[] _temp_array_chunks = new MapChunk[9];

	private static readonly TileZone[] _temp_array_zones = new TileZone[9];

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void fromStringListToHashset(List<string> pList, HashSet<string> pHashset)
	{
		pHashset.UnionWith(pList);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static string coloredText(string pText, string pColor, bool pLocalize = false)
	{
		if (pLocalize)
		{
			pText = LocalizedTextManager.getText(pText);
		}
		return "<color=" + pColor + ">" + pText + "</color>";
	}

	public static string coloredGreyPart(object pPart, string pMainColor, bool pUnit = false)
	{
		string empty = string.Empty;
		if (pUnit)
		{
			empty += coloredString(" (", ColorStyleLibrary.m.color_dead_text);
			empty += coloredString(pPart.ToString(), pMainColor);
			return empty + coloredString(")", ColorStyleLibrary.m.color_dead_text);
		}
		empty += coloredString(" [", ColorStyleLibrary.m.color_dead_text);
		empty += coloredString(pPart.ToString(), pMainColor);
		return empty + coloredString("]", ColorStyleLibrary.m.color_dead_text);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool areColorsEqual(Color32 pC1, Color32 pC2)
	{
		if (pC1.r == pC2.r && pC1.g == pC2.g)
		{
			return pC1.b == pC2.b;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool inBounds(float pVal, float pMin, float pMax)
	{
		if (pVal > pMin)
		{
			return pVal < pMax;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static string firstLetterToUpper(string str)
	{
		if (str == null)
		{
			return null;
		}
		if (str.Length == 0)
		{
			return str;
		}
		if (str.Length > 1)
		{
			Span<char> span = stackalloc char[str.Length];
			span[0] = char.ToUpper(str[0]);
			MemoryExtensions.AsSpan(str, 1).CopyTo(span.Slice(1));
			return new string(span);
		}
		return str.ToUpper();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int loopIndex(int pIndex, int pLength)
	{
		if (pLength < 1)
		{
			return 0;
		}
		return (pIndex % pLength + pLength) % pLength;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 RotatePointAroundPivot(ref Vector3 point, ref Vector3 pivot, ref Vector3 angles)
	{
		return Quaternion.Euler(angles) * (point - pivot) + pivot;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 RotatePointAroundPivot2(ref Vector3 point, ref Vector3 pivot, ref Vector3 angles)
	{
		Vector3 vector = point - pivot;
		vector = Quaternion.Euler(angles) * vector;
		point = vector + pivot;
		return point;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 rotateVector(Vector2 pVector, float degrees)
	{
		float f = degrees * (MathF.PI / 180f);
		float num = Mathf.Sin(f);
		float num2 = Mathf.Cos(f);
		float x = pVector.x;
		float y = pVector.y;
		return new Vector2(num2 * x - num * y, num * x + num2 * y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 cubeBezier3(ref Vector3 p0, ref Vector3 p1, ref Vector3 p2, ref Vector3 p3, float t)
	{
		float num = 1f - t;
		float num2 = num * num * num;
		float num3 = num * num * t * 3f;
		float num4 = num * t * t * 3f;
		float num5 = t * t * t;
		return new Vector3(num2 * p0.x + num3 * p1.x + num4 * p2.x + num5 * p3.x, num2 * p0.y + num3 * p1.y + num4 * p2.y + num5 * p3.y, num2 * p0.z + num3 * p1.z + num4 * p2.z + num5 * p3.z);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 cubeBezier2(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, float t)
	{
		float num = 1f - t;
		float num2 = num * num * num;
		float num3 = num * num * t * 3f;
		float num4 = num * t * t * 3f;
		float num5 = t * t * t;
		return new Vector2(num2 * p0.x + num3 * p1.x + num4 * p2.x + num5 * p3.x, num2 * p0.y + num3 * p1.y + num4 * p2.y + num5 * p3.y);
	}

	public static Vector2 cubeBezierN(float pTick, Span<Vector3> pPoints)
	{
		if (pPoints.Length > 2)
		{
			int num = pPoints.Length - 1;
			Span<Vector3> span = ((num >= 128) ? ((Span<Vector3>)new Vector3[num]) : stackalloc Vector3[num]);
			Span<Vector3> pPoints2 = span;
			for (int i = 0; i < num; i++)
			{
				pPoints2[i] = Vector2.Lerp(pPoints[i], pPoints[i + 1], pTick);
			}
			return cubeBezierN(pTick, pPoints2);
		}
		if (pPoints.Length == 2)
		{
			return Vector2.Lerp(pPoints[0], pPoints[1], pTick);
		}
		return pPoints[0];
	}

	public static string encode(string pString)
	{
		string text = "WorldboxIsAwesome";
		pString = Encryption.EncryptString(pString, text + "555");
		return pString;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float easeInOutQuart(float x)
	{
		if (x < 0.5f)
		{
			return 8f * x * x * x * x;
		}
		return 1f - (float)Math.Pow(-2f * x + 2f, 4.0) / 2f;
	}

	public static string decode(string pString)
	{
		string text = "WorldboxIsAwesome";
		pString = Encryption.DecryptString(pString, text + "555");
		return pString;
	}

	public static string decodeMobile(string pString)
	{
		string deviceUniqueIdentifier = SystemInfo.deviceUniqueIdentifier;
		string text = "WorldboxIsAwesome";
		pString = Encryption.DecryptString(pString, text + "555" + deviceUniqueIdentifier);
		return pString;
	}

	public static string generateID_old()
	{
		return shortGUID(Guid.NewGuid());
	}

	public static string shortGUID(Guid guid)
	{
		return Convert.ToBase64String(guid.ToByteArray()).Replace('+', '-').Replace('/', '_')
			.Substring(0, 8);
	}

	public static Vector3 getNewPoint(float pX1, float pY1, float pX2, float pY2, float pDist, bool pConvertNegative = true)
	{
		Vector3 result = default(Vector3);
		float num = Dist(pX1, pY1, pX2, pY2) - pDist;
		float num2;
		if (num == 0f)
		{
			num2 = 1f;
			result.Set(pX2, pY2, 0f);
			return result;
		}
		num2 = pDist / num;
		if (pConvertNegative && num2 < 0f)
		{
			num2 = 0f - num2;
		}
		float x = (pX1 + num2 * pX2) / (1f + num2);
		float y = (pY1 + num2 * pY2) / (1f + num2);
		result.x = x;
		result.y = y;
		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 getNewPointVec2(Vector2 pVec1, Vector2 pVec2, float pDist, bool pConvertNegative = true)
	{
		return getNewPointVec2(pVec1.x, pVec1.y, pVec2.x, pVec2.y, pDist, pConvertNegative);
	}

	public static Vector2 getNewPointVec2(float pX1, float pY1, float pX2, float pY2, float pDist, bool pConvertNegative = true)
	{
		float num = Dist(pX1, pY1, pX2, pY2) - pDist;
		if (num == 0f)
		{
			return new Vector2(pX2, pY2);
		}
		float num2 = pDist / num;
		if (pConvertNegative && num2 < 0f)
		{
			num2 = 0f - num2;
		}
		float num3 = 1f / (1f + num2);
		float x = (pX1 + num2 * pX2) * num3;
		float y = (pY1 + num2 * pY2) * num3;
		return new Vector2(x, y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float DistVec3(Vector3 pT1, Vector3 pT2)
	{
		return Mathf.Sqrt((pT1.x - pT2.x) * (pT1.x - pT2.x) + (pT1.y - pT2.y) * (pT1.y - pT2.y));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float DistVec2(Vector2Int pT1, Vector2Int pT2)
	{
		return Mathf.Sqrt((pT1.x - pT2.x) * (pT1.x - pT2.x) + (pT1.y - pT2.y) * (pT1.y - pT2.y));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float DistVec2Float(Vector2 pT1, Vector2 pT2)
	{
		return Mathf.Sqrt((pT1.x - pT2.x) * (pT1.x - pT2.x) + (pT1.y - pT2.y) * (pT1.y - pT2.y));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float DistTile(WorldTile pT1, WorldTile pT2)
	{
		return Mathf.Sqrt((pT1.x - pT2.x) * (pT1.x - pT2.x) + (pT1.y - pT2.y) * (pT1.y - pT2.y));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Dist(float x1, float y1, float x2, float y2)
	{
		return Mathf.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Dist(int x1, int y1, int x2, int y2)
	{
		return Mathf.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float SquaredDist(float x1, float y1, float x2, float y2)
	{
		return (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int SquaredDist(int x1, int y1, int x2, int y2)
	{
		return (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int SquaredDistTile(WorldTile pT1, WorldTile pT2)
	{
		return (pT1.x - pT2.x) * (pT1.x - pT2.x) + (pT1.y - pT2.y) * (pT1.y - pT2.y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float SquaredDistVec2Float(Vector2 pT1, Vector2 pT2)
	{
		return (pT1.x - pT2.x) * (pT1.x - pT2.x) + (pT1.y - pT2.y) * (pT1.y - pT2.y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int SquaredDistVec2(Vector2Int pT1, Vector2Int pT2)
	{
		return (pT1.x - pT2.x) * (pT1.x - pT2.x) + (pT1.y - pT2.y) * (pT1.y - pT2.y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float SquaredDistVec3(Vector3 pT1, Vector3 pT2)
	{
		return (pT1.x - pT2.x) * (pT1.x - pT2.x) + (pT1.y - pT2.y) * (pT1.y - pT2.y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Color makeColor(string pHex)
	{
		ColorUtility.TryParseHtmlString(pHex, out var color);
		return color;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Color makeColor(string pHex, float pAlpha)
	{
		ColorUtility.TryParseHtmlString(pHex, out var color);
		color.a = pAlpha;
		return color;
	}

	public static string colorToHex(Color32 pColor, bool pAlpha = true)
	{
		if (pAlpha)
		{
			Span<char> span = stackalloc char[9];
			span[0] = '#';
			MemoryExtensions.AsSpan(ColorUtility.ToHtmlStringRGBA(pColor)).CopyTo(span.Slice(1));
			return new string(span);
		}
		Span<char> span2 = stackalloc char[7];
		span2[0] = '#';
		MemoryExtensions.AsSpan(ColorUtility.ToHtmlStringRGB(pColor)).CopyTo(span2.Slice(1));
		return new string(span2);
	}

	public static string coloredString(string pText, string pColor)
	{
		if (string.IsNullOrEmpty(pColor))
		{
			return pText;
		}
		using StringBuilderPool stringBuilderPool = new StringBuilderPool();
		stringBuilderPool.Append("<color=").Append(pColor).Append(">")
			.Append(pText)
			.Append("</color>");
		return stringBuilderPool.ToString();
	}

	public static string colorBetween(double pValue, double pMin, double pMax, string pMinColor = "#FB2C21", string pMaxColor = "#43FF43")
	{
		float t = 100f;
		if (pMax - pMin != 0.0)
		{
			t = (float)(pValue - pMin) / (float)(pMax - pMin);
		}
		return colorToHex(Color.Lerp(makeColor(pMinColor), makeColor(pMaxColor), t));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float getAngle(float pX1, float pY1, float pX2, float pY2)
	{
		float num = pX2 - pX1;
		return (float)Math.Atan2(pY2 - pY1, num);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Quaternion getEulerAngle(float pX1, float pY1, float pX2, float pY2)
	{
		float angleDegrees = getAngleDegrees(pX1, pY1, pX2, pY2);
		return Quaternion.Euler(new Vector3(0f, 0f, angleDegrees));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Quaternion getEulerAngle(Vector2 pVec1, Vector2 pVec2)
	{
		float angleDegrees = getAngleDegrees(pVec1, pVec2);
		return Quaternion.Euler(new Vector3(0f, 0f, angleDegrees));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float getAngleDegrees(Vector2 pVec1, Vector2 pVec2)
	{
		return getAngle(pVec1.x, pVec1.y, pVec2.x, pVec2.y) * 57.29578f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float getAngleDegrees(float pX1, float pY1, float pX2, float pY2)
	{
		return getAngle(pX1, pY1, pX2, pY2) * 57.29578f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Color makeDarkerColor(Color pColor, float pMod = 0.4f)
	{
		return new Color(pColor.r * pMod, pColor.g * pMod, pColor.b * pMod, pColor.a);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static string makeDarkerColor(string pHexColor, float pMod = 0.4f)
	{
		return colorToHex(makeDarkerColor(makeColor(pHexColor), pMod));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Color blendColor(Color pFrom, Color pTo, float amount)
	{
		float r = pFrom.r * amount + pTo.r * (1f - amount);
		float g = pFrom.g * amount + pTo.g * (1f - amount);
		float b = pFrom.b * amount + pTo.b * (1f - amount);
		return new Color(r, g, b);
	}

	public static Vector2Int getClosestTile(Span<Vector2Int> pArray, WorldTile pTarget)
	{
		Vector2Int result = default(Vector2Int);
		Span<Vector2Int> span = pArray;
		int length = span.Length;
		int num = int.MaxValue;
		for (int i = 0; i < length; i++)
		{
			Vector2Int vector2Int = span[i];
			int num2 = SquaredDist(pTarget.x, pTarget.y, vector2Int.x, vector2Int.y);
			if (num2 < num)
			{
				num = num2;
				result = vector2Int;
			}
		}
		return result;
	}

	public static WorldTile getClosestTile(WorldTile[] pArray, WorldTile pTarget)
	{
		WorldTile result = null;
		int num = pArray.Length;
		int num2 = int.MaxValue;
		for (int i = 0; i < num; i++)
		{
			WorldTile worldTile = pArray[i];
			int num3 = SquaredDist(pTarget.x, pTarget.y, worldTile.x, worldTile.y);
			if (num3 < num2)
			{
				num2 = num3;
				result = worldTile;
			}
		}
		return result;
	}

	public static WorldTile getClosestTile(List<WorldTile> pArray, WorldTile pTarget)
	{
		WorldTile result = null;
		int count = pArray.Count;
		int num = int.MaxValue;
		for (int i = 0; i < count; i++)
		{
			WorldTile worldTile = pArray[i];
			int num2 = SquaredDist(pTarget.x, pTarget.y, worldTile.x, worldTile.y);
			if (num2 < num)
			{
				num = num2;
				result = worldTile;
			}
		}
		return result;
	}

	public static WorldTile getClosestTile(ListPool<WorldTile> pArray, WorldTile pTarget)
	{
		WorldTile result = null;
		int count = pArray.Count;
		int num = int.MaxValue;
		for (int i = 0; i < count; i++)
		{
			WorldTile worldTile = pArray[i];
			int num2 = SquaredDist(pTarget.x, pTarget.y, worldTile.x, worldTile.y);
			if (num2 < num)
			{
				num = num2;
				result = worldTile;
			}
		}
		return result;
	}

	public static void sortRegionsByDistance(WorldTile pTile, List<MapRegion> pRegions)
	{
		pRegions.Sort((MapRegion x, MapRegion y) => SquaredDistTile(pTile, x.tiles[0]).CompareTo(SquaredDistTile(pTile, y.tiles[0])));
	}

	public static void sortTilesByDistance(WorldTile pTile, ListPool<WorldTile> pTiles)
	{
		pTiles.Sort((WorldTile x, WorldTile y) => SquaredDistTile(pTile, x).CompareTo(SquaredDistTile(pTile, y)));
	}

	public static float maxTileDistance(WorldTile pTile, ListPool<WorldTile> pTiles)
	{
		float num = 0f;
		for (int i = 0; i < pTiles.Count; i++)
		{
			WorldTile pT = pTiles[i];
			float num2 = DistTile(pTile, pT);
			if (num2 > num)
			{
				num = num2;
			}
		}
		return num;
	}

	public static MapRegion getClosestRegion(List<MapRegion> pArray, WorldTile pTarget)
	{
		MapRegion result = null;
		int num = int.MaxValue;
		for (int i = 0; i < pArray.Count; i++)
		{
			MapRegion mapRegion = pArray[i];
			int num2 = SquaredDist(pTarget.pos.x, pTarget.pos.y, mapRegion.tiles[0].pos.x, mapRegion.tiles[0].pos.y);
			if (num2 < num)
			{
				num = num2;
				result = mapRegion;
			}
		}
		return result;
	}

	public static Vector2Int getRandomVectorWithinDistance(int pX, int pY, int pRange)
	{
		Vector2 pPos = new Vector2(pX - pRange, pY - pRange);
		Vector2 pPos2 = new Vector2(pX + pRange, pY + pRange);
		clampToMap(ref pPos);
		clampToMap(ref pPos2);
		Vector2 vector = new Vector2
		{
			x = Randy.randomFloat(pPos.x, pPos2.x),
			y = Randy.randomFloat(pPos.y, pPos2.y)
		};
		return new Vector2Int((int)vector.x, (int)vector.y);
	}

	public static WorldTile getRandomTileWithinDistance(WorldTile pWorldTile, int pRange)
	{
		Vector2Int randomVectorWithinDistance = getRandomVectorWithinDistance(pWorldTile.pos.x, pWorldTile.pos.y, pRange);
		return World.world.GetTileSimple(randomVectorWithinDistance.x, randomVectorWithinDistance.y);
	}

	public static WorldTile getRandomTileWithinDistance(WorldTile pWorldTile, int pRange, ListPool<WorldTile> pTiles)
	{
		foreach (WorldTile item in pTiles.LoopRandom())
		{
			if (!(DistTile(pWorldTile, item) > (float)pRange))
			{
				return item;
			}
		}
		return getRandomTileWithinDistance(pWorldTile, pRange);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Actor getClosestActor(HashSet<Actor> pCollection, WorldTile pTile)
	{
		Actor result = null;
		int num = int.MaxValue;
		Vector2Int pos = pTile.pos;
		foreach (Actor item in pCollection)
		{
			if (!item.isRekt())
			{
				Vector2Int pos2 = item.current_tile.pos;
				int num2 = SquaredDist(pos.x, pos.y, pos2.x, pos2.y);
				if (num2 < num)
				{
					num = num2;
					result = item;
				}
			}
		}
		return result;
	}

	public static Actor getClosestActor(List<Actor> pCollection, WorldTile pTile)
	{
		Actor result = null;
		int num = int.MaxValue;
		Vector2Int pos = pTile.pos;
		int count = pCollection.Count;
		for (int i = 0; i < count; i++)
		{
			Actor actor = pCollection[i];
			Vector2Int pos2 = actor.current_tile.pos;
			int num2 = SquaredDist(pos.x, pos.y, pos2.x, pos2.y);
			if (num2 < num)
			{
				num = num2;
				result = actor;
			}
		}
		return result;
	}

	public static Actor getClosestActor(ListPool<Actor> pCollection, WorldTile pTile)
	{
		Actor result = null;
		int num = int.MaxValue;
		Vector2Int pos = pTile.pos;
		int count = pCollection.Count;
		for (int i = 0; i < count; i++)
		{
			Actor actor = pCollection[i];
			Vector2Int pos2 = actor.current_tile.pos;
			int num2 = SquaredDist(pos.x, pos.y, pos2.x, pos2.y);
			if (num2 < num)
			{
				num = num2;
				result = actor;
			}
		}
		return result;
	}

	public static Building getClosestBuilding(List<Building> pCollection, WorldTile pTile)
	{
		Building result = null;
		int num = int.MaxValue;
		Vector2Int pos = pTile.pos;
		int count = pCollection.Count;
		for (int i = 0; i < count; i++)
		{
			Building building = pCollection[i];
			Vector2Int pos2 = building.current_tile.pos;
			int num2 = SquaredDist(pos.x, pos.y, pos2.x, pos2.y);
			if (num2 < num)
			{
				num = num2;
				result = building;
			}
		}
		return result;
	}

	public static async Task<byte[]> ReadAllBytes(string filePath)
	{
		byte[] result;
		using (FileStream stream = File.Open(filePath, FileMode.Open))
		{
			result = new byte[stream.Length];
			await stream.ReadAsync(result, 0, (int)stream.Length);
		}
		return result;
	}

	public static Sprite LoadSprite(string path)
	{
		if (string.IsNullOrEmpty(path))
		{
			return null;
		}
		if (File.Exists(path))
		{
			byte[] data = File.ReadAllBytes(path);
			Texture2D texture2D = new Texture2D(1, 1);
			texture2D.anisoLevel = 0;
			texture2D.LoadImage(data);
			Sprite result = Sprite.Create(texture2D, new Rect(0f, 0f, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));
			data = null;
			return result;
		}
		return null;
	}

	public static Sprite LoadResizedSprite(string path, int width, int height)
	{
		Sprite sprite = LoadSprite(path);
		if (sprite == null)
		{
			return null;
		}
		Sprite result = Sprite.Create(ScaleTexture(sprite.texture, width, height), new Rect(0f, 0f, width, height), new Vector2(0f, 0f));
		UnityEngine.Object.DestroyImmediate(sprite.texture);
		UnityEngine.Object.DestroyImmediate(sprite);
		return result;
	}

	public static Texture2D ScaleTexture(Texture2D source, int targetWidth, int targetHeight)
	{
		Texture2D texture2D = new Texture2D(targetWidth, targetHeight, source.format, mipChain: true);
		Color[] pixels = texture2D.GetPixels(0);
		float num = 1f / (float)source.width * ((float)source.width / (float)targetWidth);
		float num2 = 1f / (float)source.height * ((float)source.height / (float)targetHeight);
		for (int i = 0; i < pixels.Length; i++)
		{
			pixels[i] = source.GetPixelBilinear(num * ((float)i % (float)targetWidth), num2 * Mathf.Floor(i / targetWidth));
		}
		texture2D.SetPixels(pixels, 0);
		texture2D.Apply();
		return texture2D;
	}

	public static string formatTimer(float pTime)
	{
		int num = (int)(pTime / 60f);
		int num2 = (int)(pTime - (float)(num * 60));
		string text = "";
		text = ((num >= 10) ? (num + ":") : ("0" + num + ":"));
		if (num2 < 10)
		{
			return text + "0" + num2;
		}
		return text + num2;
	}

	public static string formatTime(float pTime)
	{
		using StringBuilderPool stringBuilderPool = new StringBuilderPool();
		TimeSpan timeSpan = TimeSpan.FromSeconds(pTime);
		int num = timeSpan.Days / 7;
		int num2 = timeSpan.Days;
		int num3 = (int)timeSpan.TotalHours;
		if (num > 0)
		{
			stringBuilderPool.Append(num).Append("w ");
			num2 -= num * 7;
			num3 -= num * 7 * 24;
		}
		if (num2 > 1)
		{
			stringBuilderPool.Append(num2).Append("d ");
			num3 -= num2 * 24;
		}
		stringBuilderPool.Append(num3);
		if (timeSpan.Minutes < 10)
		{
			stringBuilderPool.Append(":0").Append(timeSpan.Minutes);
		}
		else
		{
			stringBuilderPool.Append(':').Append(timeSpan.Minutes);
		}
		if (timeSpan.Seconds < 10)
		{
			stringBuilderPool.Append(":0").Append(timeSpan.Seconds);
		}
		else
		{
			stringBuilderPool.Append(':').Append(timeSpan.Seconds);
		}
		return stringBuilderPool.ToString();
	}

	public static string formatNumber(long pNumber)
	{
		long num = Math.Abs(pNumber);
		if (num >= 10000000000L)
		{
			return ((double)pNumber / 1000000000.0).ToString("N0") + "b";
		}
		if (num >= 1000000000)
		{
			return ((double)pNumber / 1000000000.0).ToText() + "b";
		}
		if (num >= 10000000)
		{
			return ((double)pNumber / 1000000.0).ToString("N0") + "m";
		}
		if (num >= 1000000)
		{
			return ((double)pNumber / 1000000.0).ToText() + "m";
		}
		if (num >= 10000)
		{
			return ((float)pNumber / 1000f).ToString("N0") + "k";
		}
		if (num >= 1000)
		{
			return ((float)pNumber / 1000f).ToText() + "k";
		}
		return pNumber.ToText();
	}

	public static string formatNumber(long pNumber, int pMaxSize)
	{
		if (pNumber.ToText().Length <= pMaxSize)
		{
			return pNumber.ToText();
		}
		return formatNumber(pNumber);
	}

	internal static void clearAll()
	{
		temp_list_tiles.Clear();
		_temp_array_chunks.Clear();
		_temp_array_zones.Clear();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static MapChunk getRandomChunkFromTile(WorldTile pTile)
	{
		var (pArray, pLength) = getAllChunksFromTile(pTile);
		return pArray.GetRandom(pLength);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static WorldTile getRandomTileAround(WorldTile pTile)
	{
		return getRandomChunkFromTile(pTile).tiles.GetRandom();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static (MapChunk[], int) getAllChunksFromTile(WorldTile pTile)
	{
		return getAllChunksFromChunk(pTile.chunk);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static (MapChunk[], int) getAllChunksFromChunk(MapChunk pChunk)
	{
		MapChunk[] temp_array_chunks = _temp_array_chunks;
		temp_array_chunks[0] = pChunk;
		int num = pChunk.neighbours_all.Length;
		MemoryExtensions.AsSpan(pChunk.neighbours_all).CopyTo(MemoryExtensions.AsSpan(_temp_array_chunks, 1));
		return (temp_array_chunks, num + 1);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static (TileZone[], int) getAllZonesFromTile(WorldTile pTile)
	{
		return getAllZonesFromZone(pTile.zone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static (TileZone[], int) getAllZonesFromZone(TileZone pZone)
	{
		TileZone[] temp_array_zones = _temp_array_zones;
		temp_array_zones[0] = pZone;
		int num = pZone.neighbours_all.Length;
		MemoryExtensions.AsSpan(pZone.neighbours_all).CopyTo(MemoryExtensions.AsSpan(_temp_array_zones, 1));
		return (temp_array_zones, num + 1);
	}

	internal static bool hasDifferentSpeciesInChunkAround(WorldTile pTile, string pSpecies)
	{
		foreach (Actor item in Finder.getUnitsFromChunk(pTile, 1))
		{
			if (!item.a.isSameSpecies(pSpecies))
			{
				return true;
			}
		}
		return false;
	}

	internal static int countUnitsInChunk(WorldTile pTile)
	{
		int num = 0;
		foreach (Actor item in Finder.getUnitsFromChunk(pTile, 0))
		{
			_ = item;
			num++;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static bool inMapBorder(ref Vector2 pPoint)
	{
		if (pPoint.x < (float)MapBox.width && pPoint.y < (float)MapBox.height && pPoint.x >= 0f)
		{
			return pPoint.y >= 0f;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static bool inMapBorder(ref Vector3 pPoint)
	{
		if (pPoint.x < (float)MapBox.width && pPoint.y < (float)MapBox.height && pPoint.x >= 0f)
		{
			return pPoint.y >= 0f;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void clampToMap(ref Vector2 pPos)
	{
		pPos.x = Mathf.Clamp(pPos.x, 0f, MapBox.width - 1);
		pPos.y = Mathf.Clamp(pPos.y, 0f, MapBox.height - 1);
	}

	internal static IEnumerable<Building> getBuildingsTypeFromChunk(MapChunk pChunk, string pType, bool pOnlyNonTargeted, bool pOnlyWithResources)
	{
		foreach (Building item in Finder.getBuildingsFromChunk(pChunk.tiles[0], 0, 0, pRandom: true))
		{
			if ((!pOnlyWithResources || item.hasResourcesToCollect()) && item.isUsable() && (!pOnlyNonTargeted || !item.current_tile.isTargeted()) && item.asset.type == pType)
			{
				yield return item;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Quaternion LookAt2D(Vector2 forward)
	{
		return Quaternion.Euler(0f, 0f, Mathf.Atan2(forward.y, forward.x) * 57.29578f);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static string LowerCaseFirst(string pString)
	{
		if (pString.Length == 0)
		{
			return "";
		}
		return char.ToLower(pString[0]) + ((pString.Length > 1) ? pString.Substring(1) : string.Empty);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T[] resizeArray<T>(T[] pArray, int aPos)
	{
		Array.Resize(ref pArray, aPos);
		return pArray;
	}

	public static string getRoundedTimestamp()
	{
		DateTime utcNow = DateTime.UtcNow;
		new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		string text = ((utcNow.Month < 10) ? ("0" + utcNow.Month) : utcNow.Month.ToString());
		string text2 = ((utcNow.Day < 10) ? ("0" + utcNow.Day) : utcNow.Day.ToString());
		return utcNow.Year + text + text2;
	}

	public static ListPool<string> getDirectories(string pPath)
	{
		ListPool<string> listPool = new ListPool<string>();
		string[] directories = Directory.GetDirectories(pPath);
		foreach (string text in directories)
		{
			if (!text.Contains(".meta"))
			{
				listPool.Add(text);
			}
		}
		return listPool;
	}

	public static ListPool<string> getFiles(string pPath)
	{
		ListPool<string> listPool = new ListPool<string>();
		string[] files = Directory.GetFiles(pPath);
		foreach (string text in files)
		{
			if (!text.Contains(".meta"))
			{
				listPool.Add(text);
			}
		}
		return listPool;
	}

	public static string cacheBuster()
	{
		return DateTime.UtcNow.RoundMinutes().ToFileTime() + "_" + Config.versionCodeText;
	}

	public static DateTime RoundMinutes(this DateTime value)
	{
		return value.RoundMinutes(30);
	}

	public static DateTime RoundMinutes(this DateTime value, int roundMinutes)
	{
		DateTime dateTime = new DateTime(value.Ticks);
		int minute = value.Minute;
		_ = value.Hour;
		int num = minute % roundMinutes;
		if (num <= roundMinutes / 2)
		{
			return dateTime.AddMinutes(-num);
		}
		return dateTime.AddMinutes(roundMinutes - num);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static WorldTile getTileAt(float pX, float pY)
	{
		int pX2 = Mathf.Clamp(Mathf.FloorToInt(pX), 0, MapBox.width - 1);
		int pY2 = Mathf.Clamp(Mathf.FloorToInt(pY), 0, MapBox.height - 1);
		return World.world.GetTileSimple(pX2, pY2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static WorldTile getNearestTileToCursor()
	{
		Vector2 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		return getTileAt(vector.x, vector.y);
	}

	public static bool isBlockAt(float pX, float pY)
	{
		return getTileAt(pX, pY)?.Type.block ?? false;
	}

	public static List<string> splitStringIntoList(params string[] pTypes)
	{
		List<string> list = new List<string>();
		foreach (string text in pTypes)
		{
			if (text.Contains("#"))
			{
				string[] array = text.Split('#');
				string item = array[0];
				if (array.Length > 2)
				{
					Debug.LogError("WRONG FORMAT - splitStringIntoList" + text);
					Debug.LogError("RETURN EMPTY STRING");
					return new List<string>();
				}
				int num = int.Parse(array[1]);
				for (int j = 0; j < num; j++)
				{
					list.Add(item);
				}
			}
			else
			{
				list.Add(text);
			}
		}
		return list;
	}

	public static string[] splitStringIntoArray(params string[] pTypes)
	{
		using ListPool<string> listPool = new ListPool<string>(pTypes.Length * 2);
		foreach (string text in pTypes)
		{
			if (text.Contains('#'))
			{
				string[] array = text.Split('#');
				string item = array[0];
				if (array.Length > 2)
				{
					Debug.LogError("WRONG FORMAT - splitStringIntoList" + text);
					Debug.LogError("RETURN EMPTY STRING");
					return new string[0];
				}
				int num = int.Parse(array[1]);
				for (int j = 0; j < num; j++)
				{
					listPool.Add(item);
				}
			}
			else
			{
				listPool.Add(text);
			}
		}
		return listPool.ToArray();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool isFirstLatin(string pString)
	{
		char c = pString[0];
		if (c >= 'A' && c <= 'Z')
		{
			return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 Parabola(Vector2 pStart, Vector2 pEnd, float pHeight, float pTime)
	{
		pTime = Mathf.Clamp(pTime, 0f, 1f);
		Vector2 vector = Vector2.Lerp(pStart, pEnd, pTime);
		return new Vector2(vector.x, parabolaHelper(pTime, pHeight) + vector.y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 ParabolaDrag(Vector2 pStart, Vector2 pEnd, float pHeight, float pTime)
	{
		pTime = Mathf.Clamp(pTime, 0f, 1f);
		float x = Mathf.Lerp(pStart.x, pEnd.x, iTween.easeOutQuad(0f, 1f, pTime));
		float num = Mathf.Lerp(pStart.y, pEnd.y, iTween.easeInQuad(0f, 1f, pTime));
		return new Vector2(x, parabolaHelper(pTime, pHeight) + num);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static float parabolaHelper(float pTime, float pHeight)
	{
		return -4f * pHeight * pTime * pTime + 4f * pHeight * pTime;
	}

	public static bool WriteSafely(string pWhat, string pDataPath, ref string pStringData)
	{
		return WriteSafely(pWhat, pDataPath, ref pStringData, null);
	}

	public static bool WriteSafely(string pWhat, string pDataPath, byte[] pByteData)
	{
		string pStringData = null;
		return WriteSafely(pWhat, pDataPath, ref pStringData, pByteData);
	}

	private static bool WriteSafely(string pWhat, string pDataPath, ref string pStringData, byte[] pByteData)
	{
		bool flag = false;
		try
		{
			if (!string.IsNullOrEmpty(pStringData))
			{
				File.WriteAllText(pDataPath + ".tmp", pStringData);
			}
			if (pByteData != null)
			{
				File.WriteAllBytes(pDataPath + ".tmp", pByteData);
			}
		}
		catch (IOException ex)
		{
			if (IsDiskFull(ex))
			{
				WorldTip.showNow("Error saving " + pWhat + " : Disk full!", pTranslate: false, "top");
			}
			else
			{
				Debug.Log("Could not save " + pWhat + " due to hard drive / IO Error : ");
				Debug.Log(ex);
				WorldTip.showNow("Error saving " + pWhat + " due to IOError! Check console for details", pTranslate: false, "top");
			}
			flag = true;
		}
		catch (Exception message)
		{
			Debug.Log("Could not save " + pWhat + " due to error : ");
			Debug.Log(message);
			WorldTip.showNow("Error saving " + pWhat + "! Check console for errors", pTranslate: false, "top");
			flag = true;
		}
		if (flag)
		{
			if (File.Exists(pDataPath + ".tmp"))
			{
				File.Delete(pDataPath + ".tmp");
			}
			return false;
		}
		if (File.Exists(pDataPath))
		{
			File.Delete(pDataPath);
		}
		File.Move(pDataPath + ".tmp", pDataPath);
		return true;
	}

	public static bool MoveSafely(string pOldPath, string pNewPath)
	{
		if (string.IsNullOrEmpty(pOldPath))
		{
			return false;
		}
		if (string.IsNullOrEmpty(pNewPath))
		{
			return false;
		}
		if (File.Exists(pNewPath))
		{
			File.Delete(pNewPath);
		}
		File.Move(pOldPath, pNewPath);
		return true;
	}

	public static bool IsDiskFull(IOException ex)
	{
		if ((ex.HResult & 0xFFFF) != 39)
		{
			return (ex.HResult & 0xFFFF) == 112;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static string textureID(string pStringData, string pID)
	{
		return Encryption.EncryptString(pStringData, pID);
	}

	public static int getClosestAngle(int pAngle, AnimationDataBoat pData)
	{
		int num = int.MinValue;
		float num2 = 0f;
		foreach (int key in pData.dict.Keys)
		{
			float num3 = Mathf.Abs(key - pAngle);
			if (num3 < num2 || num == int.MinValue)
			{
				num2 = num3;
				num = key;
			}
		}
		return num;
	}

	public static bool isInTriangle(Vector2 pPoint, Vector2 p0, Vector2 p1, Vector2 p2)
	{
		float num = 0.5f * ((0f - p1.y) * p2.x + p0.y * (0f - p1.x + p2.x) + p0.x * (p1.y - p2.y) + p1.x * p2.y);
		int num2 = ((!(num < 0f)) ? 1 : (-1));
		float num3 = (p0.y * p2.x - p0.x * p2.y + (p2.y - p0.y) * pPoint.x + (p0.x - p2.x) * pPoint.y) * (float)num2;
		float num4 = (p0.x * p1.y - p0.y * p1.x + (p0.y - p1.y) * pPoint.x + (p1.x - p0.x) * pPoint.y) * (float)num2;
		if (num3 > 0f && num4 > 0f)
		{
			return num3 + num4 < 2f * num * (float)num2;
		}
		return false;
	}

	public static List<string> getListForSave<T>(IReadOnlyCollection<T> pList) where T : Asset
	{
		List<string> list = new List<string>(pList.Count);
		foreach (T p in pList)
		{
			list.Add(p.id);
		}
		return list;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T[] checkArraySize<T>(T[] pArray, int pTargetSize)
	{
		if (pArray == null || pTargetSize > pArray.Length)
		{
			pArray = new T[nextPowerOfTwo(pTargetSize)];
		}
		return pArray;
	}

	private static int nextPowerOfTwo(int pN)
	{
		pN--;
		pN |= pN >> 1;
		pN |= pN >> 2;
		pN |= pN >> 4;
		pN |= pN >> 8;
		pN |= pN >> 16;
		pN++;
		return pN;
	}

	public static string fillLeft(string pString, int pSize = 1, char pFill = ' ')
	{
		string text = removeRichTextTags(pString);
		if (pString != text)
		{
			pSize += pString.Length - text.Length;
		}
		if (pString.Length >= pSize)
		{
			return pString;
		}
		Span<char> span = stackalloc char[pSize];
		MemoryExtensions.AsSpan(pString).CopyTo(span.Slice(pSize - pString.Length));
		for (int i = 0; i < pSize - pString.Length; i++)
		{
			span[i] = pFill;
		}
		return new string(span);
	}

	public static void fillRight(ref string pString, int pSize = 1, char pFill = ' ')
	{
		int length = pString.Length;
		if (removeRichTextTags(ref pString))
		{
			pSize += length - pString.Length;
		}
		if (pString.Length < pSize)
		{
			Span<char> span = stackalloc char[pSize];
			MemoryExtensions.AsSpan(pString).CopyTo(span.Slice(0, pString.Length));
			for (int i = pString.Length; i < pSize; i++)
			{
				span[i] = pFill;
			}
			pString = new string(span);
		}
	}

	public static string fillRight(string pString, int pSize = 1, char pFill = ' ')
	{
		string text = removeRichTextTags(pString);
		if (pString != text)
		{
			pSize += pString.Length - text.Length;
		}
		if (pString.Length >= pSize)
		{
			return pString;
		}
		Span<char> span = stackalloc char[pSize];
		MemoryExtensions.AsSpan(pString).CopyTo(span.Slice(0, pString.Length));
		for (int i = pString.Length; i < pSize; i++)
		{
			span[i] = pFill;
		}
		return new string(span);
	}

	public static string printRows(ListPool<string[]> pRows, string pAlign = "right", bool pSkipFormatting = false)
	{
		int num = 0;
		int count = pRows.Count;
		for (int i = 0; i < count; i++)
		{
			string[] array = pRows[i];
			if (array.Length > num)
			{
				num = array.Length;
			}
		}
		int[] array2 = new int[num];
		for (int j = 0; j < count; j++)
		{
			string[] array3 = pRows[j];
			for (int k = 0; k < array3.Length; k++)
			{
				int length = removeRichTextTags(array3[k]).Length;
				if (length > array2[k])
				{
					array2[k] = length;
				}
			}
		}
		using StringBuilderPool stringBuilderPool = new StringBuilderPool();
		for (int l = 0; l <= count; l++)
		{
			if (l == 0 || l == count || pRows[l].Length == 0)
			{
				stringBuilderPool.Append("|");
				for (int m = 0; m < num; m++)
				{
					if (array2[m] != 0)
					{
						stringBuilderPool.Append(fillRight("", array2[m] + 2, '='));
						stringBuilderPool.Append("|");
					}
				}
				stringBuilderPool.Append("\n");
				if (l == count)
				{
					break;
				}
			}
			string[] array4 = pRows[l];
			if (array4.Length == 0)
			{
				continue;
			}
			stringBuilderPool.Append("|");
			for (int n = 0; n < num; n++)
			{
				if (array2[n] == 0)
				{
					continue;
				}
				string pString = "";
				if (n < array4.Length)
				{
					pString = array4[n];
				}
				stringBuilderPool.Append(" ");
				if (n == 0)
				{
					if (!pSkipFormatting)
					{
						stringBuilderPool.Append("<b>");
					}
					stringBuilderPool.Append(fillRight(pString, array2[n]));
					if (!pSkipFormatting)
					{
						stringBuilderPool.Append("</b>");
					}
				}
				else if (pAlign == "right")
				{
					stringBuilderPool.Append(fillLeft(pString, array2[n]));
				}
				else
				{
					stringBuilderPool.Append(fillRight(pString, array2[n]));
				}
				stringBuilderPool.Append(" ");
				stringBuilderPool.Append("|");
			}
			stringBuilderPool.Append("\n");
		}
		return stringBuilderPool.ToString();
	}

	public static string printColumns(params ListPool<string>[] pLists)
	{
		int num = 0;
		int num2 = pLists.Length;
		int[] array = new int[num2];
		for (int i = 0; i < num2; i++)
		{
			ListPool<string> listPool = pLists[i];
			if (listPool.Count > num)
			{
				num = listPool.Count;
			}
			for (int j = 0; j < listPool.Count; j++)
			{
				int length = removeRichTextTags(listPool[j]).Length;
				if (length > array[i])
				{
					array[i] = length;
				}
			}
		}
		using StringBuilderPool stringBuilderPool = new StringBuilderPool();
		for (int k = 0; k < num; k++)
		{
			if (k == 0 || k == 1)
			{
				stringBuilderPool.Append("|");
				for (int l = 0; l < num2; l++)
				{
					if (array[l] != 0)
					{
						stringBuilderPool.Append(fillRight("", array[l] + 2, '='));
						stringBuilderPool.Append("|");
					}
				}
				stringBuilderPool.Append("\n");
			}
			stringBuilderPool.Append("|");
			for (int m = 0; m < num2; m++)
			{
				if (array[m] != 0)
				{
					string pString = "";
					if (k < pLists[m].Count)
					{
						pString = pLists[m][k];
					}
					stringBuilderPool.Append(" ");
					if (k == 0)
					{
						stringBuilderPool.Append("<b>");
					}
					stringBuilderPool.Append(fillRight(pString, array[m] + 1));
					if (k == 0)
					{
						stringBuilderPool.Append("</b>");
					}
					stringBuilderPool.Append("|");
				}
			}
			stringBuilderPool.Append("\n");
			if (k != num - 1)
			{
				continue;
			}
			stringBuilderPool.Append("|");
			for (int n = 0; n < num2; n++)
			{
				if (array[n] != 0)
				{
					stringBuilderPool.Append(fillRight("", array[n] + 2, '='));
					stringBuilderPool.Append("|");
				}
			}
			stringBuilderPool.Append("\n");
		}
		return stringBuilderPool.ToString();
	}

	public static string getRepeatedString(char pChar, int pCount)
	{
		Span<char> span = stackalloc char[pCount];
		span.Fill(pChar);
		return new string(span);
	}

	public static bool removeRichTextTags(ref string pInput)
	{
		bool result = false;
		while (true)
		{
			int num = pInput.IndexOf('<');
			if (num == -1)
			{
				return result;
			}
			int num2 = pInput.IndexOf('>', num);
			if (num2 == -1)
			{
				break;
			}
			pInput = pInput.Remove(num, num2 - num + 1);
			result = true;
		}
		return result;
	}

	public static string removeRichTextTags(string pInput)
	{
		while (true)
		{
			int num = pInput.IndexOf('<');
			if (num == -1)
			{
				return pInput;
			}
			int num2 = pInput.IndexOf('>', num);
			if (num2 == -1)
			{
				break;
			}
			pInput = pInput.Remove(num, num2 - num + 1);
		}
		return pInput;
	}

	public static bool areListsEqual<T>(IList<T> pList1, IList<T> pList2)
	{
		HashSet<T> hashSet = UnsafeCollectionPool<HashSet<T>, T>.Get();
		hashSet.UnionWith(pList1);
		bool result = hashSet.SetEquals(pList2);
		UnsafeCollectionPool<HashSet<T>, T>.Release(hashSet);
		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static TA[] a<TA>(params TA[] pArgs)
	{
		return pArgs;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static List<TL> l<TL>(params TL[] pArgs)
	{
		return List.Of(pArgs);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static HashSet<TH> h<TH>(params TH[] pArgs)
	{
		return new HashSet<TH>(pArgs);
	}
}
