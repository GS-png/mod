using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public class NullableLongListJsonConverter : JsonConverter
{
	public override bool CanWrite => false;

	public override bool CanRead => true;

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		if (reader.TokenType == JsonToken.Null)
		{
			return null;
		}
		if (reader.TokenType == JsonToken.StartArray)
		{
			using ListPool<long?> listPool = new ListPool<long?>();
			while (reader.Read())
			{
				switch (reader.TokenType)
				{
				case JsonToken.Integer:
					listPool.Add(Convert.ToInt64(reader.Value));
					break;
				case JsonToken.Null:
					listPool.Add(null);
					break;
				case JsonToken.String:
				{
					string pString = (string)reader.Value;
					listPool.Add(NullableLongJsonConverter.getLong(pString, reader));
					break;
				}
				case JsonToken.EndArray:
					return new List<long?>(listPool);
				}
			}
		}
		Debug.LogWarning("Unhandled type " + reader.Path + " " + reader.Value?.ToString() + " " + reader.TokenType.ToString() + " -> null");
		return null;
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		writer.WriteValue(value);
	}

	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(List<long?>);
	}
}
