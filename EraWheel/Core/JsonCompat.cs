using System;
using System.IO;
using System.Reflection;

namespace EraWheel.Core
{
    public static class JsonCompat
    {
        public static string ToJson(object obj, bool pretty = false)
        {
            if (obj == null) return "{}";

            try
            {
                var t = CompatReflection.FindType("UnityEngine.JsonUtility") ?? CompatReflection.FindType("UnityEngine.JsonUtility, UnityEngine");
                if (t != null)
                {
                    var flags = BindingFlags.Public | BindingFlags.Static;
                    var m = t.GetMethod("ToJson", flags, null, new[] { typeof(object), typeof(bool) }, null) ??
                            t.GetMethod("ToJson", flags, null, new[] { typeof(object) }, null);
                    if (m != null)
                    {
                        var args = m.GetParameters().Length == 2 ? new object[] { obj, pretty } : new object[] { obj };
                        return m.Invoke(null, args) as string;
                    }
                }
            }
            catch
            {
            }

            try
            {
                var jsonType = CompatReflection.FindType("System.Text.Json.JsonSerializer") ??
                               CompatReflection.FindType("System.Text.Json.JsonSerializer, System.Text.Json");
                if (jsonType != null)
                {
                    var optionsType = CompatReflection.FindType("System.Text.Json.JsonSerializerOptions") ??
                                      CompatReflection.FindType("System.Text.Json.JsonSerializerOptions, System.Text.Json");
                    object options = null;
                    if (optionsType != null)
                    {
                        options = Activator.CreateInstance(optionsType);
                        var writeIndented = optionsType.GetProperty("WriteIndented");
                        writeIndented?.SetValue(options, pretty, null);
                        var includeFields = optionsType.GetProperty("IncludeFields");
                        includeFields?.SetValue(options, true, null);
                    }

                    MethodInfo method = null;
                    if (optionsType != null)
                    {
                        method = jsonType.GetMethod("Serialize", new[] { typeof(object), typeof(Type), optionsType });
                        if (method != null)
                        {
                            return method.Invoke(null, new object[] { obj, obj.GetType(), options }) as string;
                        }
                    }

                    method = jsonType.GetMethod("Serialize", new[] { typeof(object), typeof(Type) });
                    if (method != null)
                    {
                        return method.Invoke(null, new object[] { obj, obj.GetType() }) as string;
                    }

                    method = jsonType.GetMethod("Serialize", new[] { typeof(object) });
                    if (method != null)
                    {
                        return method.Invoke(null, new object[] { obj }) as string;
                    }
                }
            }
            catch
            {
            }

            return "{}";
        }

        public static T FromJson<T>(string json) where T : class
        {
            var o = FromJson(json, typeof(T));
            return o as T;
        }

        public static bool TryOverwriteJson(string json, object target)
        {
            if (string.IsNullOrEmpty(json) || target == null) return false;

            try
            {
                var t = CompatReflection.FindType("UnityEngine.JsonUtility") ?? CompatReflection.FindType("UnityEngine.JsonUtility, UnityEngine");
                if (t != null)
                {
                    var flags = BindingFlags.Public | BindingFlags.Static;
                    var m = t.GetMethod("FromJsonOverwrite", flags, null, new[] { typeof(string), typeof(object) }, null);
                    if (m != null)
                    {
                        m.Invoke(null, new[] { json, target });
                        return true;
                    }
                }
            }
            catch
            {
            }

            return false;
        }

        public static object FromJson(string json, Type type)
        {
            if (string.IsNullOrEmpty(json) || type == null) return null;

            try
            {
                var t = CompatReflection.FindType("UnityEngine.JsonUtility") ?? CompatReflection.FindType("UnityEngine.JsonUtility, UnityEngine");
                if (t != null)
                {
                    var flags = BindingFlags.Public | BindingFlags.Static;
                    var m = t.GetMethod("FromJson", flags, null, new[] { typeof(string), typeof(Type) }, null);
                    if (m != null)
                    {
                        return m.Invoke(null, new object[] { json, type });
                    }
                }
            }
            catch
            {
            }

            try
            {
                var jsonType = CompatReflection.FindType("System.Text.Json.JsonSerializer") ??
                               CompatReflection.FindType("System.Text.Json.JsonSerializer, System.Text.Json");
                if (jsonType != null)
                {
                    var optionsType = CompatReflection.FindType("System.Text.Json.JsonSerializerOptions") ??
                                      CompatReflection.FindType("System.Text.Json.JsonSerializerOptions, System.Text.Json");
                    object options = null;
                    if (optionsType != null)
                    {
                        options = Activator.CreateInstance(optionsType);
                        var includeFields = optionsType.GetProperty("IncludeFields");
                        includeFields?.SetValue(options, true, null);
                    }

                    MethodInfo method = null;
                    if (optionsType != null)
                    {
                        method = jsonType.GetMethod("Deserialize", new[] { typeof(string), typeof(Type), optionsType });
                        if (method != null)
                        {
                            return method.Invoke(null, new object[] { json, type, options });
                        }
                    }

                    method = jsonType.GetMethod("Deserialize", new[] { typeof(string), typeof(Type) });
                    if (method != null)
                    {
                        return method.Invoke(null, new object[] { json, type });
                    }
                }
            }
            catch
            {
            }

            return null;
        }

        public static void WriteAllText(string path, object obj, bool pretty = true)
        {
            var json = ToJson(obj, pretty);
            File.WriteAllText(path, json);
        }
    }
}
