using System;
using System.IO;
using System.Linq;
using System.Reflection;
using EraWheel.Core;

namespace EraWheel.Data
{
    public static class SaveManager
    {
        public static event Action OnSave;
        public static event Action OnLoad;

        private static bool _initialized;
        private static string _modRoot;

        public static void Initialize(string modRootPath)
        {
            if (_initialized) return;
            _initialized = true;

            _modRoot = string.IsNullOrEmpty(modRootPath) ? Directory.GetCurrentDirectory() : modRootPath;

            TryHookNeoModLoaderSaveEvents();
        }

        public static void SaveModData<T>(string key, T data)
        {
            if (TryInvokeNeoSave(key, data))
            {
                return;
            }

            TrySaveToFile(key, data);
        }

        public static T LoadModData<T>(string key) where T : class
        {
            var fromNml = TryInvokeNeoLoad<T>(key);
            if (fromNml != null) return fromNml;

            return TryLoadFromFile<T>(key);
        }

        internal static void RaiseOnSave()
        {
            OnSave?.Invoke();
        }

        internal static void RaiseOnLoad()
        {
            OnLoad?.Invoke();
        }

        private static void TryHookNeoModLoaderSaveEvents()
        {
            try
            {
                var t = GetNeoSaveManagerType();
                if (t == null) return;

                CompatReflection.TryAddStaticEventHandler(t, "OnSave", (Action)RaiseOnSave);
                CompatReflection.TryAddStaticEventHandler(t, "OnLoad", (Action)RaiseOnLoad);
            }
            catch
            {
            }
        }

        private static bool TryInvokeNeoSave<T>(string key, T data)
        {
            try
            {
                var t = GetNeoSaveManagerType();
                if (t == null) return false;

                var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
                var m = t.GetMethods(flags)
                    .FirstOrDefault(mi => mi.Name == "SaveModData" && mi.GetParameters().Length == 2);
                if (m == null) return false;

                m.Invoke(null, new object[] { key, data });
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static T TryInvokeNeoLoad<T>(string key) where T : class
        {
            try
            {
                var t = GetNeoSaveManagerType();
                if (t == null) return null;

                var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
                var m = t.GetMethods(flags)
                    .FirstOrDefault(mi => mi.Name == "LoadModData" && mi.GetParameters().Length == 1);
                if (m == null) return null;

                if (m.IsGenericMethodDefinition)
                {
                    var gm = m.MakeGenericMethod(typeof(T));
                    return gm.Invoke(null, new object[] { key }) as T;
                }

                return m.Invoke(null, new object[] { key }) as T;
            }
            catch
            {
                return null;
            }
        }

        private static void TrySaveToFile<T>(string key, T data)
        {
            try
            {
                var dir = GetSaveDir();
                Directory.CreateDirectory(dir);

                var path = Path.Combine(dir, key + ".json");
                var json = JsonCompat.ToJson(data, true);
                File.WriteAllText(path, json);
            }
            catch
            {
            }
        }

        private static T TryLoadFromFile<T>(string key) where T : class
        {
            try
            {
                var dir = GetSaveDir();
                var path = Path.Combine(dir, key + ".json");
                if (!File.Exists(path)) return null;

                var json = File.ReadAllText(path);
                if (string.IsNullOrEmpty(json)) return null;

                return JsonCompat.FromJson<T>(json);
            }
            catch
            {
                return null;
            }
        }

        private static string GetSaveDir()
        {
            return Path.Combine(_modRoot ?? Directory.GetCurrentDirectory(), "Data", "Saves");
        }

        private static Type GetNeoSaveManagerType()
        {
            try
            {
                var neoAsm = AppDomain.CurrentDomain.GetAssemblies()
                    .FirstOrDefault(a => string.Equals(a.GetName().Name, "NeoModLoader", StringComparison.Ordinal));
                if (neoAsm == null) return null;

                var t = neoAsm.GetType("NeoModLoader.General.SaveManager", false);
                if (t != null) return t;

                var types = neoAsm.GetTypes();
                for (var i = 0; i < types.Length; i++)
                {
                    var tt = types[i];
                    if (tt == null) continue;
                    if (!string.Equals(tt.Name, "SaveManager", StringComparison.Ordinal)) continue;
                    if (string.IsNullOrEmpty(tt.Namespace)) continue;
                    if (!tt.Namespace.StartsWith("NeoModLoader", StringComparison.Ordinal)) continue;
                    return tt;
                }
            }
            catch
            {
            }

            return null;
        }
    }
}
