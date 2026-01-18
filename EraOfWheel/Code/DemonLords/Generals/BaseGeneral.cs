using System;
using System.Reflection;
using UnityEngine;
using EraOfWheel.Core;
using EraOfWheel.Core.Data;
using EraOfWheel.Cycle;
using Logger = EraOfWheel.Core.Logger;

namespace EraOfWheel.DemonLords.Generals
{
    public abstract class LegacyBaseGeneral
    {
        public abstract string Id { get; }
        public abstract string Name { get; }

        public string DemonLordId { get; private set; } = "";
        public bool Betrayed { get; private set; } = false;
        public int DefeatCount { get; private set; } = 0;
        public int LastSeenYear { get; private set; } = -1;

        protected Actor GeneralActor { get; private set; }

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
            if (currentYear != LastSeenYear)
            {
                LastSeenYear = currentYear;
                PersistToSave();
            }
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

        public void BindActor(Actor actor)
        {
            GeneralActor = actor;
            PersistToSave();
        }

        public void EnsureActorSpawned(string fallbackActorId, object tile)
        {
            if (GeneralActor != null) return;
            if (string.IsNullOrEmpty(fallbackActorId)) return;

            try
            {
                EnsureSpawnApiResolved();
                if (_spawnApiMethod == null || _spawnApiTarget == null) return;

                if (!TrySpawnActor(fallbackActorId, tile, out var actor) || actor == null) return;
                GeneralActor = actor;
                TryMarkAsGeneral(actor);
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
            if (GeneralActor == null) return false;

            try
            {
                var data = GetMemberValue(GeneralActor, "data");
                if (data == null) return false;

                if (!TryGetFloatMember(data, "health", out var h)) return false;
                if (TryGetFloatMember(data, "maxHealth", out var mh) || TryGetFloatMember(data, "max_health", out mh))
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

        private void EnsureSpawnApiResolved()
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

        private bool TrySpawnActor(string actorId, object tile, out Actor actor)
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

        private void TryMarkAsGeneral(Actor actor)
        {
            if (actor == null) return;

            try
            {
                actor.addTrait("dlm_demon_faction");
            }
            catch
            {
            }

            TrySetStringMember(actor, "name", $"eow_general_{Id}");
            var data = GetMemberValue(actor, "data");
            if (data != null)
            {
                TrySetStringMember(data, "name", $"eow_general_{Id}");
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
