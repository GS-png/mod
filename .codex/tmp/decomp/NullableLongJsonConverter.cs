using System;
using Newtonsoft.Json;
using UnityEngine;

public class NullableLongJsonConverter : JsonConverter
{
	public override bool CanWrite => false;

	public override bool CanRead => true;

	public static long? getLong(string pString, JsonReader pReader)
	{
		if (string.IsNullOrEmpty(pString))
		{
			return null;
		}
		return LongJsonConverter.getLong(pString, pReader);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		switch (reader.TokenType)
		{
		case JsonToken.Null:
			return null;
		case JsonToken.Integer:
			return Convert.ToInt64(reader.Value);
		case JsonToken.String:
			return getLong((string)reader.Value, reader);
		default:
			Debug.LogWarning("Unhandled type " + reader.Path + " " + reader.Value?.ToString() + " " + reader.TokenType.ToString() + " -> null");
			return null;
		}
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		writer.WriteValue(value);
	}

	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(long?);
	}
}
