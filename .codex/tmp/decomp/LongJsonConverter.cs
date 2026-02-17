using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public class LongJsonConverter : JsonConverter
{
	internal static long next_long = 100000000L;

	internal static Dictionary<string, long> longs = new Dictionary<string, long>();

	public override bool CanWrite => false;

	public override bool CanRead => true;

	public static void reset()
	{
		next_long = 100000000L;
		longs.Clear();
	}

	public static long getLong(string pString, JsonReader pReader)
	{
		if (string.IsNullOrEmpty(pString))
		{
			return -1L;
		}
		string s = pString;
		if (pString.IndexOf('_') > 0)
		{
			string[] array = pString.Split('_');
			if (array.Length == 2)
			{
				string pValue = array[0] + "_";
				if (MapStats.possible_formats.IndexOf(pValue) > -1)
				{
					s = array[1];
				}
			}
		}
		if (long.TryParse(s, out var result))
		{
			return result;
		}
		bool flag = pString.Length == 8 || (pString.Length == 36 && pString[8] == '-' && pString[13] == '-' && pString[18] == '-' && pString[23] == '-');
		if (!longs.TryGetValue(pString, out var value))
		{
			value = next_long++;
			longs[pString] = value;
			if (!flag)
			{
				Debug.LogWarning(pReader.Path + " Failed to parse long <b>" + pString + "</b> " + pString.Length + " -> " + value);
			}
		}
		else if (!flag)
		{
			Debug.LogWarning(pReader.Path + " Failed to parse long <b>" + pString + "</b> " + pString.Length + " -> " + value + " already had it");
		}
		return value;
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		switch (reader.TokenType)
		{
		case JsonToken.Null:
			return -1L;
		case JsonToken.Integer:
			return Convert.ToInt64(reader.Value);
		case JsonToken.String:
			return getLong((string)reader.Value, reader);
		default:
			Debug.LogWarning("Unhandled type " + reader.Path + " " + reader.Value?.ToString() + " " + reader.TokenType.ToString() + " -> " + -1L);
			return -1L;
		}
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		writer.WriteValue(value);
	}

	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(long);
	}
}
