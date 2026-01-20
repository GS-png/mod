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

            return "{}";
        }

        public static T FromJson<T>(string json) where T : class
        {
            var o = FromJson(json, typeof(T));
            return o as T;
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

            return null;
        }

        public static void WriteAllText(string path, object obj, bool pretty = true)
        {
            var json = ToJson(obj, pretty);
            File.WriteAllText(path, json);
        }
    }
}
