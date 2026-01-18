using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace EraOfWheel.DemonLords.Legion
{
    internal static class LegionActorRegistry
    {
        internal const string LegionActorId = "eow_legion_grunt";
        internal const string SpriteFolder = "actors/races/era_wheel_legion/unit_legion";

        private static bool _initialized;

        internal static void EnsureRegistered()
        {
            if (_initialized) return;

            try
            {
                TryRegisterActorAsset();
                TryRegisterSpriteOverride();
            }
            catch
            {
            }

            _initialized = true;
        }

        internal static bool TryApplyLegionActorAsset(Actor actor)
        {
            if (actor == null) return false;

            try
            {
                if (!TryGetActorAsset(LegionActorId, out var assetObj) || assetObj == null) return false;

                if (TrySetActorAssetOnActor(actor, assetObj))
                {
                    TryInvokeActorMethod(actor, "setStatsDirty");
                    TryInvokeActorMethod(actor, "set_stats_dirty");
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        private static void TryRegisterActorAsset()
        {
            if (TryGetActorAsset(LegionActorId, out _)) return;

            if (!TryGetActorLibrary(out var actorLibrary) || actorLibrary == null) return;

            var baseCandidates = new[] { "unit_human", "unit_orc", "t_sheep" };
            object cloned = null;
            foreach (var baseId in baseCandidates)
            {
                if (TryCloneActorAsset(actorLibrary, LegionActorId, baseId, out cloned) && cloned != null)
                {
                    break;
                }
            }

            if (cloned == null)
            {
                if (TryPickAnyActorId(actorLibrary, out var anyId) && TryCloneActorAsset(actorLibrary, LegionActorId, anyId, out cloned))
                {
                }
            }

            if (cloned == null) return;

            TrySetStringField(cloned, "id", LegionActorId);

            TryInvokeMethod(actorLibrary, "add", cloned);
            TryInvokeMethod(actorLibrary, "Add", cloned);
        }

        private static bool TryPickAnyActorId(object actorLibrary, out string id)
        {
            id = null;
            if (actorLibrary == null) return false;

            try
            {
                var dictField = actorLibrary.GetType().GetField("dict", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (dictField != null)
                {
                    var dictObj = dictField.GetValue(actorLibrary);
                    if (dictObj is System.Collections.IDictionary dict && dict.Count > 0)
                    {
                        foreach (var k in dict.Keys)
                        {
                            id = k as string;
                            if (!string.IsNullOrEmpty(id)) return true;
                        }
                    }
                }

                var listField = actorLibrary.GetType().GetField("list", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (listField != null)
                {
                    var listObj = listField.GetValue(actorLibrary);
                    if (listObj is System.Collections.IEnumerable enumerable)
                    {
                        foreach (var a in enumerable)
                        {
                            var aid = GetStringMember(a, "id");
                            if (!string.IsNullOrEmpty(aid))
                            {
                                id = aid;
                                return true;
                            }
                        }
                    }
                }
            }
            catch
            {
            }

            return false;
        }

        private static void TryRegisterSpriteOverride()
        {
            if (!TryGetActorAsset(LegionActorId, out var asset) || asset == null) return;

            TrySetBoolField(asset, "has_override_sprite", true);
            TrySetBoolField(asset, "hasOverrideSprite", true);

            var method = typeof(LegionActorRegistry).GetMethod(nameof(GetOverrideSprite), BindingFlags.Static | BindingFlags.NonPublic);
            if (method == null) return;

            var field = asset.GetType().GetField("get_override_sprite", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            if (field != null)
            {
                try
                {
                    var d = Delegate.CreateDelegate(field.FieldType, method);
                    field.SetValue(asset, d);
                }
                catch
                {
                }
                return;
            }

            var prop = asset.GetType().GetProperty("get_override_sprite", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            if (prop != null && prop.CanWrite)
            {
                try
                {
                    var d = Delegate.CreateDelegate(prop.PropertyType, method);
                    prop.SetValue(asset, d, null);
                }
                catch
                {
                }
            }
        }

        private static Sprite GetOverrideSprite(Actor actor)
        {
            try
            {
                if (actor == null) return null;

                var walkSprites = new[]
                {
                    $"{SpriteFolder}/walk_0",
                    $"{SpriteFolder}/walk_1",
                    $"{SpriteFolder}/walk_2",
                    $"{SpriteFolder}/walk_3"
                };

                var idleSprite = $"{SpriteFolder}/walk_3";

                string path = idleSprite;
                if (TryReadBool(actor, "is_moving", out var moving) && moving)
                {
                    int idx = Mathf.Abs(actor.GetHashCode()) % walkSprites.Length;
                    path = walkSprites[idx];
                }

                return TryGetSingleSprite(path);
            }
            catch
            {
                return null;
            }
        }

        private static bool TrySetActorAssetOnActor(Actor actor, object actorAsset)
        {
            if (actor == null || actorAsset == null) return false;

            try
            {
                var field = actor.GetType().GetField("asset", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (field != null && field.FieldType.IsInstanceOfType(actorAsset))
                {
                    field.SetValue(actor, actorAsset);
                    return true;
                }

                var prop = actor.GetType().GetProperty("asset", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (prop != null && prop.CanWrite && prop.PropertyType.IsInstanceOfType(actorAsset))
                {
                    prop.SetValue(actor, actorAsset, null);
                    return true;
                }

                var data = GetMemberValue(actor, "data");
                if (data != null)
                {
                    field = data.GetType().GetField("asset", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                    if (field != null && field.FieldType.IsInstanceOfType(actorAsset))
                    {
                        field.SetValue(data, actorAsset);
                        return true;
                    }

                    prop = data.GetType().GetProperty("asset", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                    if (prop != null && prop.CanWrite && prop.PropertyType.IsInstanceOfType(actorAsset))
                    {
                        prop.SetValue(data, actorAsset, null);
                        return true;
                    }
                }
            }
            catch
            {
            }

            return false;
        }

        private static void TryInvokeActorMethod(Actor actor, string methodName)
        {
            if (actor == null || string.IsNullOrEmpty(methodName)) return;

            try
            {
                var m = actor.GetType().GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                m?.Invoke(actor, null);
            }
            catch
            {
            }
        }

        private static string GetStringMember(object obj, string name)
        {
            if (obj == null || string.IsNullOrEmpty(name)) return null;

            try
            {
                var field = obj.GetType().GetField(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (field != null && field.FieldType == typeof(string)) return (string)field.GetValue(obj);

                var prop = obj.GetType().GetProperty(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (prop != null && prop.PropertyType == typeof(string)) return (string)prop.GetValue(obj, null);
            }
            catch
            {
            }

            return null;
        }

        private static object GetMemberValue(object obj, string name)
        {
            if (obj == null || string.IsNullOrEmpty(name)) return null;

            try
            {
                var t = obj.GetType();
                const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

                var field = t.GetField(name, flags);
                if (field != null) return field.GetValue(obj);

                var prop = t.GetProperty(name, flags);
                if (prop != null) return prop.GetValue(obj, null);

                var method = t.GetMethod(name, flags, null, Type.EmptyTypes, null);
                if (method != null) return method.Invoke(obj, null);

                return null;
            }
            catch
            {
                return null;
            }
        }

        private static Sprite TryGetSingleSprite(string path)
        {
            if (string.IsNullOrEmpty(path)) return null;

            try
            {
                var spriteTextureLoaderType = FindTypeByName("SpriteTextureLoader");
                if (spriteTextureLoaderType == null) return null;

                var getSprite = spriteTextureLoaderType.GetMethod("getSprite", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
                if (getSprite == null) return null;

                var result = getSprite.Invoke(null, new object[] { path });
                return result as Sprite;
            }
            catch
            {
                return null;
            }
        }

        private static bool TryGetActorLibrary(out object actorLibrary)
        {
            actorLibrary = null;

            try
            {
                var assetManagerType = FindTypeByName("AssetManager");
                if (assetManagerType == null) return false;

                var field = assetManagerType.GetField("actor_library", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
                if (field != null)
                {
                    actorLibrary = field.GetValue(null);
                    return actorLibrary != null;
                }

                var prop = assetManagerType.GetProperty("actor_library", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
                if (prop != null)
                {
                    actorLibrary = prop.GetValue(null, null);
                    return actorLibrary != null;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        internal static bool TryGetActorAsset(string id, out object asset)
        {
            asset = null;
            if (string.IsNullOrEmpty(id)) return false;

            try
            {
                if (!TryGetActorLibrary(out var actorLibrary) || actorLibrary == null) return false;

                var getMethod = actorLibrary.GetType().GetMethod("get", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (getMethod == null) return false;

                asset = getMethod.Invoke(actorLibrary, new object[] { id });
                return asset != null;
            }
            catch
            {
                asset = null;
                return false;
            }
        }

        private static bool TryCloneActorAsset(object actorLibrary, string newId, string baseId, out object cloned)
        {
            cloned = null;
            if (actorLibrary == null) return false;
            if (string.IsNullOrEmpty(newId) || string.IsNullOrEmpty(baseId)) return false;

            try
            {
                var cloneMethod = actorLibrary.GetType().GetMethod("clone", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (cloneMethod == null) return false;

                cloned = cloneMethod.Invoke(actorLibrary, new object[] { newId, baseId });
                return cloned != null;
            }
            catch
            {
                cloned = null;
                return false;
            }
        }

        private static Type FindTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName)) return null;

            try
            {
                foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
                {
                    Type[] types;
                    try
                    {
                        types = asm.GetTypes();
                    }
                    catch
                    {
                        continue;
                    }

                    foreach (var t in types)
                    {
                        if (t == null) continue;
                        if (t.Name == typeName) return t;
                    }
                }

                return null;
            }
            catch
            {
                return null;
            }
        }

        private static void TryInvokeMethod(object obj, string methodName, params object[] args)
        {
            if (obj == null || string.IsNullOrEmpty(methodName)) return;

            try
            {
                var methods = obj.GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                foreach (var m in methods)
                {
                    if (!string.Equals(m.Name, methodName, StringComparison.Ordinal)) continue;

                    var ps = m.GetParameters();
                    if (ps.Length != (args?.Length ?? 0)) continue;

                    m.Invoke(obj, args);
                    return;
                }
            }
            catch
            {
            }
        }

        private static void TrySetBoolField(object obj, string fieldName, bool value)
        {
            if (obj == null || string.IsNullOrEmpty(fieldName)) return;

            try
            {
                var field = obj.GetType().GetField(fieldName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (field != null && field.FieldType == typeof(bool))
                {
                    field.SetValue(obj, value);
                }
            }
            catch
            {
            }
        }

        private static void TrySetStringField(object obj, string fieldName, string value)
        {
            if (obj == null || string.IsNullOrEmpty(fieldName)) return;

            try
            {
                var field = obj.GetType().GetField(fieldName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (field != null && field.FieldType == typeof(string))
                {
                    field.SetValue(obj, value);
                }
            }
            catch
            {
            }
        }

        private static bool TryReadBool(object obj, string memberName, out bool value)
        {
            value = false;
            if (obj == null || string.IsNullOrEmpty(memberName)) return false;

            try
            {
                var field = obj.GetType().GetField(memberName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (field != null && field.FieldType == typeof(bool))
                {
                    value = (bool)field.GetValue(obj);
                    return true;
                }

                var prop = obj.GetType().GetProperty(memberName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (prop != null && prop.PropertyType == typeof(bool))
                {
                    value = (bool)prop.GetValue(obj, null);
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
