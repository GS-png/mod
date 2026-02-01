using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace UnityEngine
{
    public static class JsonUtility
    {
        private static readonly JsonSerializerOptions Options = new JsonSerializerOptions
        {
            IncludeFields = true,
            PropertyNameCaseInsensitive = true,
            Converters = { new JsonStringEnumConverter() }
        };

        public static T FromJson<T>(string json)
        {
            if (string.IsNullOrEmpty(json)) return default;

            try
            {
                return JsonSerializer.Deserialize<T>(json, Options);
            }
            catch
            {
                return default;
            }
        }

        public static object FromJson(string json, Type type)
        {
            if (string.IsNullOrEmpty(json) || type == null) return null;

            try
            {
                return JsonSerializer.Deserialize(json, type, Options);
            }
            catch
            {
                return null;
            }
        }

        public static string ToJson(object obj, bool prettyPrint = false)
        {
            if (obj == null) return "{}";

            try
            {
                var options = new JsonSerializerOptions
                {
                    IncludeFields = true,
                    PropertyNameCaseInsensitive = true,
                    WriteIndented = prettyPrint,
                    Converters = { new JsonStringEnumConverter() }
                };
                return JsonSerializer.Serialize(obj, options);
            }
            catch
            {
                return "{}";
            }
        }
    }
}
