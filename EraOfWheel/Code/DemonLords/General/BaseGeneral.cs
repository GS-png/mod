using System;
using System.Reflection;
using UnityEngine;
using EraOfWheel.Core;
using EraOfWheel.Core.Data;
using Logger = EraOfWheel.Core.Logger;

namespace EraOfWheel.DemonLords.General
{
    public abstract class BaseGeneral
    {
        public abstract string Id { get; }
        public abstract string Name { get; }

        public string DemonLordId { get; private set; } = "";
        public bool Betrayed { get; private set; } = false;
        public int DefeatCount { get; private set; } = 0;
        public int LastSeenYear { get; private set; } = -1;

        public Actor Actor => _generalActor;
        public bool HasHadActor => _hasHadActor;

        private Actor _generalActor;
        private bool _hasHadActor = false;

        private static bool _spawnApiSearched;
        private static MethodInfo _spawnApiMethod;
        private static object _spawnApiTarget;

        public virtual void Initialize(string demonLordId)
        {
            DemonLordId = demonLordId ?? "";
            LoadFromSave();
        }

        public virtual void Update(int currentYear)
        {
            EnsureActorBoundFromWorld();
            if (currentYear != LastSeenYear)
            {
                LastSeenYear = currentYear;
                PersistToSave();
            }
        }

        private void EnsureActorBoundFromWorld()
        {
            if (_generalActor != null) return;

            try
            {
                if (TryFindExistingGeneralActor(out var found) && found != null)
                {
                    _generalActor = found;
                    _hasHadActor = true;
                }
            }
            catch
            {
            }
        }

        private bool TryFindExistingGeneralActor(out Actor actor)
        {
            actor = null;

            try
            {
                var units = World.world?.units;
                if (units == null) return false;

                string marker = GetGeneralMarker();
                foreach (var u in units)
                {
                    if (u == null) continue;

                    var n1 = TryGetStringMember(u, "name");
                    if (!string.IsNullOrEmpty(n1) && n1 == marker)
                    {
                        actor = u;
                        return true;
                    }

                    var data = GetMemberValue(u, "data");
                    var n2 = TryGetStringMember(data, "name");
                    if (!string.IsNullOrEmpty(n2) && n2 == marker)
                    {
                        actor = u;
                        return true;
                    }
                }
            }
            catch
            {
            }

            return false;
        }

        public void BindActor(Actor actor)
        {
            _generalActor = actor;
            if (_generalActor != null) _hasHadActor = true;
            PersistToSave();
        }

        public void ClearActor()
        {
            _generalActor = null;
        }

        public void RecordDefeat()
        {
            DefeatCount = Math.Max(0, DefeatCount + 1);
            PersistToSave();
        }

        public void SetBetrayed(bool betrayed)
        {
            Betrayed = betrayed;
            PersistToSave();
        }

        public void EnsureActorSpawned(string fallbackActorId, object tile)
        {
            EnsureActorBoundFromWorld();
            if (_generalActor != null) return;
            if (string.IsNullOrEmpty(fallbackActorId)) return;

            try
            {
                EnsureSpawnApiResolved();
                if (_spawnApiMethod == null || _spawnApiTarget == null) return;

                if (!TrySpawnActor(fallbackActorId, tile, out var actor) || actor == null) return;
                _generalActor = actor;
                _hasHadActor = true;
                MarkAsGeneral(actor);
                PersistToSave();
            }
            catch (Exception ex)
            {
                Logger.Error($"General.{Id}", "Failed to spawn general actor", ex);
            }
        }

        public bool TryGetHealthPercent(out float hp)
        {
            hp = 100f;
            if (_generalActor == null) return false;

            try
            {
                var data = GetMemberValue(_generalActor, "data");
                if (data == null) return false;

                if (!TryGetFloatMember(data, "health", out var h)) return false;

                float mh;
                if (TryGetFloatMember(data, "maxHealth", out mh) || TryGetFloatMember(data, "max_health", out mh))
                {
                    if (mh > 0.0001f)
                    {
                        hp = Mathf.Clamp((h / mh) * 100f, 0f, 100f);
                        return true;
                    }
                }

                hp = Mathf.Clamp(h, 0f, 100f);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool TryHealToPercent(float targetHealthPercent)
        {
            if (_generalActor == null) return false;
            targetHealthPercent = Mathf.Clamp(targetHealthPercent, 1f, 100f);

            try
            {
                var data = GetMemberValue(_generalActor, "data");
                if (data == null) return false;

                float mh;
                if (!TryGetFloatMember(data, "maxHealth", out mh) && !TryGetFloatMember(data, "max_health", out mh))
                {
                    return false;
                }

                float desired = mh * (targetHealthPercent / 100f);
                return TrySetFloatMember(data, "health", desired);
             }
             catch
             {
                 return false;
             }
         }

        public void TryAddTrait(string traitId)
        {
            if (_generalActor == null) return;
            if (string.IsNullOrEmpty(traitId)) return;

            try
            {
                var method = _generalActor.GetType().GetMethod("addTrait");
                method?.Invoke(_generalActor, new object[] { traitId });
            }
            catch
            {
            }
        }

        public void TryRemoveTrait(string traitId)
        {
            if (_generalActor == null) return;
            if (string.IsNullOrEmpty(traitId)) return;

            try
            {
                var method = _generalActor.GetType().GetMethod("removeTrait") ?? _generalActor.GetType().GetMethod("remove_trait");
                method?.Invoke(_generalActor, new object[] { traitId });
            }
            catch
            {
            }
        }

        protected virtual void LoadFromSave()
        {
            var save = SaveManager.Instance?.Data;
            if (save?.generals == null) return;

            try
            {
                for (int i = 0; i < save.generals.Length; i++)
                {
                    var g = save.generals[i];
                    if (g == null) continue;
                    if (g.id != Id) continue;

                    DemonLordId = g.demon_lord_id ?? "";
                    DefeatCount = Math.Max(0, g.defeat_count);
                    Betrayed = g.betrayed;
                    LastSeenYear = g.last_seen_year;
                    return;
                }
            }
            catch
            {
            }
        }

        protected void PersistToSave()
        {
            try
            {
                SaveManager.Instance?.UpdateGeneralData(
                    Id,
                    DemonLordId,
                    DefeatCount,
                    Betrayed,
                    LastSeenYear
                );
            }
            catch (Exception ex)
            {
                Logger.Error($"General.{Id}", "Failed to persist general data", ex);
            }
        }

        private void MarkAsGeneral(Actor actor)
        {
            if (actor == null) return;

            try
            {
                actor.addTrait("dlm_demon_faction");
            }
            catch
            {
            }

            string marker = GetGeneralMarker();
            TrySetStringMember(actor, "name", marker);

            var data = GetMemberValue(actor, "data");
            if (data != null)
            {
                TrySetStringMember(data, "name", marker);
            }
        }

        private string GetGeneralMarker()
        {
            return $"eow_general_{Id}";
        }

        private static string TryGetStringMember(object obj, string memberName)
        {
            if (obj == null || string.IsNullOrEmpty(memberName)) return null;

            try
            {
                var t = obj.GetType();
                const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

                var field = t.GetField(memberName, flags);
                if (field != null && field.FieldType == typeof(string)) return (string)field.GetValue(obj);

                var prop = t.GetProperty(memberName, flags);
                if (prop != null && prop.PropertyType == typeof(string)) return (string)prop.GetValue(obj, null);
            }
            catch
            {
            }

            return null;
        }

        private static void EnsureSpawnApiResolved()
        {
            if (_spawnApiSearched) return;
            _spawnApiSearched = true;

            try
            {
                var world = World.world;
                if (world == null) return;

                var unitManager = world.units;
                if (unitManager != null && TryFindSpawnMethod(unitManager, out var m))
                {
                    _spawnApiTarget = unitManager;
                    _spawnApiMethod = m;
                    return;
                }

                if (TryFindSpawnMethod(world, out m))
                {
                    _spawnApiTarget = world;
                    _spawnApiMethod = m;
                }
            }
            catch
            {
            }
        }

        private static bool TryFindSpawnMethod(object target, out MethodInfo method)
        {
            method = null;
            if (target == null) return false;

            try
            {
                var methods = target.GetType().GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                MethodInfo best = null;
                int bestScore = int.MinValue;
                foreach (var m in methods)
                {
                    if (m == null) continue;
                    var name = m.Name;
                    if (string.IsNullOrEmpty(name)) continue;

                    if (name.IndexOf("spawn", StringComparison.OrdinalIgnoreCase) < 0 &&
                        name.IndexOf("create", StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        continue;
                    }

                    var ps = m.GetParameters();
                    if (ps.Length < 1 || ps.Length > 6) continue;
                    if (ps[0].ParameterType != typeof(string)) continue;

                    if (m.ReturnType == null) continue;
                    if (!typeof(Actor).IsAssignableFrom(m.ReturnType)) continue;

                    int score = 0;
                    if (name.IndexOf("spawn", StringComparison.OrdinalIgnoreCase) >= 0) score += 3;
                    if (name.IndexOf("create", StringComparison.OrdinalIgnoreCase) >= 0) score += 1;

                    bool hasTile = false;
                    for (int i = 0; i < ps.Length; i++)
                    {
                        var ptName = ps[i].ParameterType?.Name ?? "";
                        if (ptName.IndexOf("WorldTile", StringComparison.OrdinalIgnoreCase) >= 0 ||
                            ptName.IndexOf("Tile", StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            hasTile = true;
                            break;
                        }
                    }
                    if (hasTile) score += 4;

                    if (score > bestScore)
                    {
                        bestScore = score;
                        best = m;
                    }
                }

                if (best != null)
                {
                    method = best;
                    return true;
                }
            }
            catch
            {
                method = null;
                return false;
            }

            return false;
        }

        private static bool TrySpawnActor(string actorId, object tile, out Actor actor)
        {
            actor = null;
            if (string.IsNullOrEmpty(actorId)) return false;
            if (_spawnApiMethod == null || _spawnApiTarget == null) return false;

            try
            {
                var ps = _spawnApiMethod.GetParameters();
                var args = new object[ps.Length];

                for (int i = 0; i < ps.Length; i++)
                {
                    var pt = ps[i].ParameterType;
                    if (pt == typeof(string))
                    {
                        args[i] = actorId;
                        continue;
                    }

                    if (tile != null && pt.IsInstanceOfType(tile))
                    {
                        args[i] = tile;
                        continue;
                    }

                    if (pt == typeof(int))
                    {
                        args[i] = 0;
                        continue;
                    }

                    if (pt == typeof(float))
                    {
                        args[i] = 0f;
                        continue;
                    }

                    args[i] = null;
                }

                var result = _spawnApiMethod.Invoke(_spawnApiTarget, args);
                actor = result as Actor;
                return actor != null;
            }
            catch
            {
                actor = null;
                return false;
            }
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

        private static bool TryGetFloatMember(object obj, string memberName, out float value)
        {
            value = 0f;
            if (obj == null || string.IsNullOrEmpty(memberName)) return false;

            try
            {
                var v = GetMemberValue(obj, memberName);
                if (v == null) return false;

                value = Convert.ToSingle(v);
                return true;
            }
            catch
            {
                value = 0f;
                return false;
            }
        }

        private static bool TrySetFloatMember(object obj, string memberName, float value)
        {
            if (obj == null || string.IsNullOrEmpty(memberName)) return false;

            try
            {
                var t = obj.GetType();
                const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

                var field = t.GetField(memberName, flags);
                if (field != null && (field.FieldType == typeof(float) || field.FieldType == typeof(int)))
                {
                    field.SetValue(obj, field.FieldType == typeof(int) ? (object)(int)value : value);
                    return true;
                }

                var prop = t.GetProperty(memberName, flags);
                if (prop != null && prop.CanWrite && (prop.PropertyType == typeof(float) || prop.PropertyType == typeof(int)))
                {
                    prop.SetValue(obj, prop.PropertyType == typeof(int) ? (object)(int)value : value, null);
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        private static void TrySetStringMember(object obj, string memberName, string value)
        {
            if (obj == null || string.IsNullOrEmpty(memberName)) return;

            try
            {
                var t = obj.GetType();
                const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

                var field = t.GetField(memberName, flags);
                if (field != null && field.FieldType == typeof(string))
                {
                    field.SetValue(obj, value);
                    return;
                }

                var prop = t.GetProperty(memberName, flags);
                if (prop != null && prop.PropertyType == typeof(string) && prop.CanWrite)
                {
                    prop.SetValue(obj, value, null);
                }
            }
            catch
            {
            }
        }
    }
}
