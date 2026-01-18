using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using EraOfWheel.Core;
using EraOfWheel.Core.Events;
using EraOfWheel.Cycle;

namespace EraOfWheel.DemonLords.Legion
{
    public class LegionManager : IModSystem
    {
        public static LegionManager Instance { get; private set; }
        
        public string SystemName => "LegionManager";
        public bool IsInitialized { get; private set; }
        
        private List<LegionWave> _waves = new List<LegionWave>();
        private int _currentWaveNumber = 0;
        private int _lastSpawnYear = 0;
        private int _spawnIntervalYears = 5;

        public int CurrentWaveNumber => _currentWaveNumber;
        public IReadOnlyList<LegionWave> Waves => _waves;

        public void Initialize()
        {
            if (IsInitialized) return;
            
            Instance = this;
            LegionActorRegistry.EnsureRegistered();
            SubscribeToEvents();
            
            IsInitialized = true;
            Logger.Info(SystemName, "LegionManager initialized");
        }

        private void SubscribeToEvents()
        {
            EventBus.Instance?.Subscribe<DemonStateChangedEvent>(OnDemonStateChanged);
            EventBus.Instance?.Subscribe<CycleCompletedEvent>(OnCycleCompleted);
        }

        private void OnDemonStateChanged(DemonStateChangedEvent e)
        {
            if (e.CurrentState == DemonState.Invasion.ToString())
            {
                StartInvasion();
            }
        }

        private void OnCycleCompleted(CycleCompletedEvent e)
        {
            Reset();
        }

        private void StartInvasion()
        {
            _currentWaveNumber = 0;
            _lastSpawnYear = CycleManager.Instance?.State?.WorldAgeYears ?? 0;
            _waves.Clear();
            
            Logger.Info(SystemName, "Legion invasion started");
        }

        public void Update(int currentYear)
        {
            if (!IsInitialized) return;
            
            var cyclePhase = CycleManager.Instance?.State?.CurrentPhase;
            if (cyclePhase != CyclePhase.Invasion && cyclePhase != CyclePhase.Peak)
            {
                return;
            }
            
            if (currentYear - _lastSpawnYear >= _spawnIntervalYears)
            {
                SpawnNextWave(currentYear);
                _lastSpawnYear = currentYear;
            }
        }

        private void SpawnNextWave(int currentYear)
        {
            _currentWaveNumber++;
            
            int cycleCount = CycleManager.Instance?.State?.CycleCount ?? 1;
            float powerMultiplier = CycleManager.Instance?.CalculateDemonPowerMultiplier() ?? 1f;
            
            var wave = LegionWave.Create(_currentWaveNumber, cycleCount, powerMultiplier);
            wave.SpawnYear = currentYear;
            _waves.Add(wave);
            
            int unitCount = wave.GetActualUnitCount();
            
            SpawnUnits(wave, unitCount);
            
            EventBus.Instance?.Publish(new LegionWaveSpawnedEvent
            {
                DemonLordId = DemonLordManager.Instance?.ActiveDemonLord?.Id ?? "",
                WaveNumber = _currentWaveNumber,
                UnitCount = unitCount
            });
            
            Logger.Info(SystemName, $"Wave {_currentWaveNumber} spawned: {unitCount} {wave.Type} units (Lv.{wave.UnitLevel})");
        }

        private void SpawnUnits(LegionWave wave, int count)
        {
            // Note: Full implementation would create WorldBox actors
            // For MVP, we log the spawn
            var activeDemon = DemonLordManager.Instance?.ActiveDemonLord;
            if (activeDemon == null)
            {
                Logger.Warn(SystemName, "Cannot spawn legion units: no active demon lord");
                return;
            }

            var units = World.world?.units;
            if (units == null)
            {
                Logger.Warn(SystemName, "Cannot spawn legion units: World units not available");
                return;
            }

            activeDemon.EnsureActorSpawned();

            Actor demonActor;
            if (!TryGetDemonActor(activeDemon, out demonActor) || demonActor == null)
            {
                demonActor = null;
            }

            Vector2 center = default(Vector2);
            bool hasCenter = demonActor != null && TryGetActorPosition2D(demonActor, out center);

            const int maxConvertPerWave = 200;
            int targetCount = Math.Max(0, Math.Min(count, maxConvertPerWave));
            if (targetCount == 0)
            {
                return;
            }

            int spawned = TrySpawnNewLegionUnits(wave, targetCount, demonActor);
            int remainingToConvert = Math.Max(0, targetCount - spawned);
            if (remainingToConvert <= 0)
            {
                return;
            }

            var candidates = new List<Actor>(Math.Min(512, targetCount * 4));
            foreach (var u in units)
            {
                if (u == null) continue;
                if (demonActor != null && ReferenceEquals(u, demonActor)) continue;

                try
                {
                    if (u.hasTrait("dlm_demon_faction")) continue;
                }
                catch
                {
                }

                if (IsHeroUnit(u)) continue;
                candidates.Add(u);
            }

            if (candidates.Count == 0)
            {
                Logger.Warn(SystemName, "Cannot spawn legion units: no eligible units to convert");
                return;
            }

            if (hasCenter)
            {
                candidates.Sort((a, b) =>
                {
                    float da = GetDistance2DOrMax(a, center);
                    float db = GetDistance2DOrMax(b, center);
                    return da.CompareTo(db);
                });
            }
            else
            {
                ShuffleInPlace(candidates);
            }

            int converted = 0;
            int toConvert = Math.Min(remainingToConvert, candidates.Count);
            for (int i = 0; i < toConvert; i++)
            {
                var u = candidates[i];
                if (u == null) continue;

                ConvertToLegionUnit(u, wave);
                converted++;
            }

            int total = spawned + converted;
            if (total < count)
            {
                Logger.Warn(SystemName, $"Wave {wave.WaveNumber} requested {count} units, spawned {spawned}, converted {converted} (cap {maxConvertPerWave})");
            }
        }

        private static bool _spawnApiSearched;
        private static MethodInfo _spawnApiMethod;
        private static object _spawnApiTarget;

        private static int TrySpawnNewLegionUnits(LegionWave wave, int count, Actor demonActor)
        {
            if (wave == null) return 0;
            if (count <= 0) return 0;

            LegionActorRegistry.EnsureRegistered();

            try
            {
                if (!_spawnApiSearched)
                {
                    _spawnApiSearched = true;
                    ResolveSpawnApi();
                }

                if (_spawnApiMethod == null || _spawnApiTarget == null) return 0;

                object tile = null;
                if (demonActor != null)
                {
                    tile = GetMemberValue(demonActor, "currentTile")
                           ?? GetMemberValue(demonActor, "tile")
                           ?? GetMemberValue(demonActor, "current_tile");
                }

                int spawned = 0;
                for (int i = 0; i < count; i++)
                {
                    if (!TryInvokeSpawn(_spawnApiTarget, _spawnApiMethod, LegionActorRegistry.LegionActorId, tile, out var actor) || actor == null)
                    {
                        break;
                    }

                    ConvertToLegionUnit(actor, wave);
                    spawned++;
                }

                return spawned;
            }
            catch
            {
                return 0;
            }
        }

        private static void ResolveSpawnApi()
        {
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
                    if (ps.Length == 2) score += 1;

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

        private static bool TryInvokeSpawn(object target, MethodInfo method, string actorId, object tile, out Actor actor)
        {
            actor = null;
            if (target == null || method == null) return false;

            try
            {
                var ps = method.GetParameters();
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

                var result = method.Invoke(target, args);
                actor = result as Actor;
                return actor != null;
            }
            catch
            {
                actor = null;
                return false;
            }
        }

        private static void ConvertToLegionUnit(Actor unit, LegionWave wave)
        {
            if (unit == null || wave == null) return;

            try
            {
                LegionActorRegistry.TryApplyLegionActorAsset(unit);
            }
            catch
            {
            }

            try
            {
                unit.addTrait("dlm_demon_faction");
            }
            catch
            {
            }

            try
            {
                unit.addTrait("madness");
            }
            catch
            {
            }

            try
            {
                unit.addTrait("evil");
            }
            catch
            {
            }

            TrySetUnitLevel(unit, wave.UnitLevel);
            TryBoostHealth(unit, wave);
        }

        private static void TrySetUnitLevel(Actor unit, int level)
        {
            if (unit == null) return;
            if (level <= 0) return;

            try
            {
                var data = GetMemberValue(unit, "data");
                if (data == null) return;

                var t = data.GetType();
                const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

                var field = t.GetField("level", flags);
                if (field != null && field.FieldType == typeof(int))
                {
                    int current = (int)field.GetValue(data);
                    if (level > current) field.SetValue(data, level);
                    return;
                }

                var prop = t.GetProperty("level", flags);
                if (prop != null && prop.PropertyType == typeof(int) && prop.CanWrite)
                {
                    int current = (int)prop.GetValue(data, null);
                    if (level > current) prop.SetValue(data, level, null);
                }
            }
            catch
            {
            }
        }

        private static void TryBoostHealth(Actor unit, LegionWave wave)
        {
            if (unit == null || wave == null) return;

            try
            {
                var data = GetMemberValue(unit, "data");
                if (data == null) return;

                var healthObj = GetMemberValue(data, "health");
                if (healthObj == null) return;

                float health;
                try
                {
                    health = Convert.ToSingle(healthObj);
                }
                catch
                {
                    return;
                }

                float multiplier = 1f;
                if (wave.Type == LegionType.Main) multiplier = 1.15f;
                if (wave.Type == LegionType.Siege) multiplier = 1.25f;
                if (wave.Type == LegionType.Ultimate) multiplier = 1.45f;

                float newHealth = health * multiplier;
                if (newHealth <= health) return;

                var t = data.GetType();
                const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;
                var field = t.GetField("health", flags);
                if (field != null)
                {
                    if (field.FieldType == typeof(float))
                    {
                        field.SetValue(data, newHealth);
                        return;
                    }
                    if (field.FieldType == typeof(int))
                    {
                        field.SetValue(data, (int)newHealth);
                        return;
                    }
                }

                var prop = t.GetProperty("health", flags);
                if (prop != null && prop.CanWrite)
                {
                    if (prop.PropertyType == typeof(float))
                    {
                        prop.SetValue(data, newHealth, null);
                        return;
                    }
                    if (prop.PropertyType == typeof(int))
                    {
                        prop.SetValue(data, (int)newHealth, null);
                    }
                }
            }
            catch
            {
            }
        }

        private static float GetDistance2DOrMax(Actor actor, Vector2 center)
        {
            if (actor == null) return float.MaxValue;

            try
            {
                Vector2 pos;
                if (!TryGetActorPosition2D(actor, out pos)) return float.MaxValue;
                return Vector2.Distance(pos, center);
            }
            catch
            {
                return float.MaxValue;
            }
        }

        private static bool TryGetDemonActor(BaseDemonLord demon, out Actor actor)
        {
            actor = null;
            if (demon == null) return false;

            try
            {
                var t = demon.GetType();
                const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

                var prop = t.GetProperty("DemonActor", flags);
                if (prop != null)
                {
                    actor = prop.GetValue(demon, null) as Actor;
                    if (actor != null) return true;
                }

                var field = t.GetField("DemonActor", flags);
                if (field != null)
                {
                    actor = field.GetValue(demon) as Actor;
                    if (actor != null) return true;
                }

                field = t.GetField("<DemonActor>k__BackingField", flags);
                if (field != null)
                {
                    actor = field.GetValue(demon) as Actor;
                    if (actor != null) return true;
                }
            }
            catch
            {
            }

            return actor != null;
        }

        private static bool TryGetActorPosition2D(Actor actor, out Vector2 pos)
        {
            pos = default(Vector2);
            if (actor == null) return false;

            object posObj = GetMemberValue(actor, "currentPosition")
                           ?? GetMemberValue(actor, "position")
                           ?? GetMemberValue(actor, "pos");
            if (TryConvertToVector2(posObj, out pos)) return true;

            object tileObj = GetMemberValue(actor, "currentTile")
                            ?? GetMemberValue(actor, "tile")
                            ?? GetMemberValue(actor, "current_tile");

            if (tileObj != null)
            {
                var xObj = GetMemberValue(tileObj, "x");
                var yObj = GetMemberValue(tileObj, "y");
                if (xObj != null && yObj != null)
                {
                    try
                    {
                        pos = new Vector2(Convert.ToSingle(xObj), Convert.ToSingle(yObj));
                        return true;
                    }
                    catch
                    {
                    }
                }
            }

            return false;
        }

        private static bool TryConvertToVector2(object value, out Vector2 pos)
        {
            pos = default(Vector2);
            if (value == null) return false;

            try
            {
                if (value is Vector2 v2)
                {
                    pos = v2;
                    return true;
                }

                if (value is Vector3 v3)
                {
                    pos = new Vector2(v3.x, v3.y);
                    return true;
                }

                if (value is Vector2Int v2i)
                {
                    pos = new Vector2(v2i.x, v2i.y);
                    return true;
                }

                if (value is Vector3Int v3i)
                {
                    pos = new Vector2(v3i.x, v3i.y);
                    return true;
                }
            }
            catch
            {
            }

            return false;
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

        private static bool IsHeroUnit(Actor actor)
        {
            if (actor == null) return false;

            try
            {
                if (TryReadBool(actor, "isHero", out var isHero) && isHero) return true;

                var dataObj = GetMemberValue(actor, "data");
                if (TryReadBool(dataObj, "isHero", out isHero) && isHero) return true;

                if (TryInvokeHasTrait(actor, "hero")) return true;
                if (TryInvokeHasTrait(actor, "legendary")) return true;
                if (TryInvokeHasTrait(actor, "legend")) return true;

                return false;
            }
            catch
            {
                return false;
            }
        }

        private static bool TryReadBool(object obj, string name, out bool value)
        {
            value = false;
            if (obj == null) return false;

            var v = GetMemberValue(obj, name);
            if (v == null) return false;

            try
            {
                if (v is bool b)
                {
                    value = b;
                    return true;
                }

                value = Convert.ToBoolean(v);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static bool TryInvokeHasTrait(Actor actor, string traitId)
        {
            try
            {
                if (actor == null || string.IsNullOrEmpty(traitId)) return false;

                var m = actor.GetType().GetMethod("hasTrait") ?? actor.GetType().GetMethod("has_trait");
                if (m == null) return false;

                var result = m.Invoke(actor, new object[] { traitId });
                return result is bool b && b;
            }
            catch
            {
                return false;
            }
        }

        private static void ShuffleInPlace<T>(List<T> list)
        {
            if (list == null) return;

            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = UnityEngine.Random.Range(0, i + 1);
                (list[i], list[j]) = (list[j], list[i]);
            }
        }

        public void Reset()
        {
            _waves.Clear();
            _currentWaveNumber = 0;
            _lastSpawnYear = 0;
            Logger.Info(SystemName, "Legion manager reset");
        }

        public void Dispose()
        {
            EventBus.Instance?.Unsubscribe<DemonStateChangedEvent>(OnDemonStateChanged);
            EventBus.Instance?.Unsubscribe<CycleCompletedEvent>(OnCycleCompleted);
            
            Reset();
            IsInitialized = false;
            Instance = null;
            Logger.Info(SystemName, "LegionManager disposed");
        }
    }
}
