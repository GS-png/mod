using System;
using System.IO;
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
        private static FieldInfo _mapStatsField;
        private static object _currentMapStats;
        private static long _lastAutoSaveWorldAge = -1;
        private static Type _mapBoxType;
        private static FieldInfo _mapBoxInstanceField;
        private static Type _saveCustomDataType;
        private static FieldInfo _customDataField;
        private static MethodInfo _checkStringMethod;
        private static MethodInfo _setStringMethod;
        private static MethodInfo _getStringMethod;

        public static void Initialize(string modRootPath)
        {
            if (_initialized) return;
            _initialized = true;

            _modRoot = string.IsNullOrEmpty(modRootPath) ? Directory.GetCurrentDirectory() : modRootPath;
        }

        public static void SaveModData<T>(string key, T data)
        {
            if (TrySaveToWorld(key, data))
            {
                return;
            }

            TrySaveToFile(key, data);
        }

        public static T LoadModData<T>(string key) where T : class
        {
            var fromWorld = TryLoadFromWorld<T>(key);
            if (fromWorld != null) return fromWorld;

            return TryLoadFromFile<T>(key);
        }

        public static void Update()
        {
            if (!_initialized) return;

            var mapStats = TryGetMapStats();
            if (mapStats == null) return;

            if (!ReferenceEquals(mapStats, _currentMapStats))
            {
                _currentMapStats = mapStats;
                _lastAutoSaveWorldAge = WorldCompat.GetWorldAge();
                RaiseOnLoad();
                return;
            }

            var worldAge = WorldCompat.GetWorldAge();
            if (worldAge <= 0) return;

            if (_lastAutoSaveWorldAge < 0 || worldAge > _lastAutoSaveWorldAge)
            {
                _lastAutoSaveWorldAge = worldAge;
                RaiseOnSave();
            }
        }

        internal static void RaiseOnSave()
        {
            OnSave?.Invoke();
        }

        internal static void RaiseOnLoad()
        {
            OnLoad?.Invoke();
        }

        private static bool TrySaveToWorld<T>(string key, T data)
        {
            if (string.IsNullOrEmpty(key) || data == null) return false;

            try
            {
                var customData = TryGetCustomData();
                if (customData == null) return false;
                if (!EnsureStringAccessors(customData)) return false;

                var json = JsonCompat.ToJson(data, false);
                _setStringMethod.Invoke(customData, new object[] { key, json });
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static T TryLoadFromWorld<T>(string key) where T : class
        {
            if (string.IsNullOrEmpty(key)) return null;

            try
            {
                var customData = TryGetCustomData();
                if (customData == null) return null;
                if (!EnsureStringAccessors(customData)) return null;

                var args = new object[] { key, null, null };
                _getStringMethod.Invoke(customData, args);
                var json = args[1] as string;
                if (string.IsNullOrEmpty(json)) return null;
                return JsonCompat.FromJson<T>(json);
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

        private static object TryGetCustomData()
        {
            try
            {
                var mapStats = TryGetMapStats();
                if (mapStats == null) return null;

                if (_customDataField == null || _customDataField.DeclaringType != mapStats.GetType())
                {
                    _customDataField = mapStats.GetType().GetField("custom_data", BindingFlags.Public | BindingFlags.Instance);
                }

                if (_customDataField == null) return null;

                var customData = _customDataField.GetValue(mapStats);
                if (customData == null)
                {
                    if (_saveCustomDataType == null)
                    {
                        _saveCustomDataType = CompatReflection.FindTypeByName("SaveCustomData");
                    }

                    if (_saveCustomDataType == null) return null;

                    customData = Activator.CreateInstance(_saveCustomDataType);
                    _customDataField.SetValue(mapStats, customData);
                }

                return customData;
            }
            catch
            {
            }

            return null;
        }

        private static object TryGetMapStats()
        {
            try
            {
                var mapBox = GetMapBox();
                if (mapBox == null) return null;

                if (_mapStatsField == null || _mapStatsField.DeclaringType != mapBox.GetType())
                {
                    _mapStatsField = mapBox.GetType().GetField("map_stats", BindingFlags.NonPublic | BindingFlags.Instance);
                }

                return _mapStatsField != null ? _mapStatsField.GetValue(mapBox) : null;
            }
            catch
            {
                return null;
            }
        }

        private static object GetMapBox()
        {
            try
            {
                if (_mapBoxType == null)
                {
                    _mapBoxType = CompatReflection.FindTypeByName("MapBox");
                }

                if (_mapBoxType == null) return null;

                if (_mapBoxInstanceField == null || _mapBoxInstanceField.DeclaringType != _mapBoxType)
                {
                    _mapBoxInstanceField = _mapBoxType.GetField("instance", BindingFlags.Public | BindingFlags.Static);
                }

                return _mapBoxInstanceField != null ? _mapBoxInstanceField.GetValue(null) : null;
            }
            catch
            {
                return null;
            }
        }

        private static bool EnsureStringAccessors(object customData)
        {
            if (customData == null) return false;

            try
            {
                var dataType = customData.GetType();

                if (_checkStringMethod == null || _checkStringMethod.DeclaringType != dataType)
                {
                    _checkStringMethod = dataType.GetMethod("checkString", BindingFlags.Public | BindingFlags.Instance);
                }

                if (_setStringMethod == null || _setStringMethod.DeclaringType != dataType)
                {
                    _setStringMethod = dataType.GetMethod("set", BindingFlags.Public | BindingFlags.Instance, null, new[] { typeof(string), typeof(string) }, null);
                }

                if (_getStringMethod == null || _getStringMethod.DeclaringType != dataType)
                {
                    _getStringMethod = dataType.GetMethod(
                        "get",
                        BindingFlags.Public | BindingFlags.Instance,
                        null,
                        new[] { typeof(string), typeof(string).MakeByRefType(), typeof(string) },
                        null);
                }

                if (_checkStringMethod == null || _setStringMethod == null || _getStringMethod == null)
                {
                    return false;
                }

                _checkStringMethod.Invoke(customData, null);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
