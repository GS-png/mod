using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using EraOfWheel.Core;
using Logger = EraOfWheel.Core.Logger;
using EraOfWheel.Core.Events;
using EraOfWheel.Cycle;
using EraOfWheel.Core.Data;
using ModSaveManager = EraOfWheel.Core.Data.SaveManager;

namespace EraOfWheel.DemonLords
{
    public abstract class BaseDemonLord
    {
        public abstract string Id { get; }
        public abstract string Name { get; }
        public abstract string Title { get; }
        public abstract string Description { get; }
        public abstract int UnlockCycle { get; }
        
        public DemonState State { get; protected set; } = DemonState.Sealed;
        public DemonLordStats Stats { get; protected set; } = new DemonLordStats();
        public float SealStrength { get; protected set; } = 100f;
        
        public int TotalKills { get; protected set; } = 0;
        public int CitiesDestroyed { get; protected set; } = 0;
        public int HeroesKilled { get; protected set; } = 0;
        
        protected Actor DemonActor { get; set; }
        protected bool OwnsDemonActor { get; set; }

        private static bool _spawnApiSearched;
        private static MethodInfo _spawnApiMethod;
        private static object _spawnApiTarget;

        private string _pendingSealMethod;
        private int _lastSpawnAttemptYear = int.MinValue;
        
        public bool IsEnabled { get; set; } = true;
        public bool IsUnlocked(int currentCycle) => currentCycle >= UnlockCycle;

        public virtual void Initialize(int cycleCount)
        {
            float powerMultiplier = CycleManager.Instance?.CalculateDemonPowerMultiplier() ?? 1f;
            Stats.CalculateForCycle(cycleCount, powerMultiplier);
            Logger.Info($"DemonLord.{Id}", $"Initialized for cycle {cycleCount}, power multiplier {powerMultiplier:F2}");
        }

        public virtual void Update(int currentYear)
        {
            if (!IsEnabled) return;

            SyncHealthFromActorIfPossible();

            if (DemonActor == null && (State == DemonState.Invasion || State == DemonState.Peak || State == DemonState.Weakening))
            {
                if (currentYear != _lastSpawnAttemptYear)
                {
                    _lastSpawnAttemptYear = currentYear;
                    SpawnDemonActor();
                }
            }
            
            switch (State)
            {
                case DemonState.Awakening:
                    UpdateAwakening(currentYear);
                    break;
                case DemonState.Invasion:
                case DemonState.Peak:
                    UpdateInvasion(currentYear);
                    break;
                case DemonState.Weakening:
                    UpdateWeakening(currentYear);
                    break;
            }
        }

        protected virtual void UpdateAwakening(int currentYear)
        {
            TransitionState(DemonState.Invasion);
        }

        protected virtual void UpdateInvasion(int currentYear)
        {
            if (Stats.HealthPercent >= 70f && State != DemonState.Peak)
            {
                TransitionState(DemonState.Peak);
            }
            else if (Stats.HealthPercent < 30f)
            {
                TransitionState(DemonState.Weakening);
            }
        }

        protected virtual void UpdateWeakening(int currentYear)
        {
        }

        public virtual void TransitionState(DemonState newState)
        {
            if (!State.CanTransitionTo(newState))
            {
                Logger.Warn($"DemonLord.{Id}", $"Invalid state transition: {State} -> {newState}");
                return;
            }

            var previousState = State;
            State = newState;

            EventBus.Instance?.Publish(new DemonStateChangedEvent
            {
                DemonLordId = Id,
                PreviousState = previousState.ToString(),
                CurrentState = newState.ToString()
            });

            Logger.Info($"DemonLord.{Id}", $"State: {previousState} -> {newState}");

            OnStateChanged(previousState, newState);

            ModSaveManager.Instance?.UpdateDemonLordData(Id, State.ToString(), SealStrength, Stats.HealthPercent, TotalKills);
        }

        protected virtual void OnStateChanged(DemonState previousState, DemonState newState)
        {
            switch (newState)
            {
                case DemonState.Awakening:
                    OnAwaken();
                    break;
                case DemonState.Invasion:
                    OnInvade();
                    break;
                case DemonState.Resealed:
                    OnSeal();
                    break;
            }
        }

        public virtual void OnAwaken()
        {
            int cycleCount = CycleManager.Instance?.State?.CycleCount ?? 1;
            Initialize(cycleCount);
            
            EventBus.Instance?.Publish(new DemonAwakeningEvent
            {
                DemonLordId = Id,
                DemonName = Name,
                PowerLevel = Stats.MaxHealth
            });
            
            Logger.Info($"DemonLord.{Id}", $"{Name} awakens with {Stats.MaxHealth:N0} HP!");
        }

        public virtual void OnInvade()
        {
            SpawnDemonActor();
        }

        public virtual void OnSeal()
        {
            int cycleCount = CycleManager.Instance?.State?.CycleCount ?? 1;

            string method = _pendingSealMethod;
            if (string.IsNullOrEmpty(method))
            {
                method = Stats.IsDead ? "execution" : "ritual";
            }
            _pendingSealMethod = null;
            
            EventBus.Instance?.Publish(new DemonSealedEvent
            {
                DemonLordId = Id,
                SealMethod = method,
                CycleCount = cycleCount
            });
            
            RemoveDemonActor();
            ResetForNextCycle();

            ModSaveManager.Instance?.UpdateDemonLordData(Id, State.ToString(), SealStrength, Stats.HealthPercent, TotalKills);
            
            Logger.Info($"DemonLord.{Id}", $"{Name} has been sealed!");
        }

        public void SetPendingSealMethod(string method)
        {
            if (string.IsNullOrEmpty(method)) return;
            _pendingSealMethod = method;
        }

        public void ForceResetToSealed(int cycleCount)
        {
            try
            {
                RemoveDemonActor();
                ResetForNextCycle();

                State = DemonState.Sealed;
                SealStrength = 100f;

                Initialize(Math.Max(1, cycleCount));
                Stats.CurrentHealth = Stats.MaxHealth;

                ModSaveManager.Instance?.UpdateDemonLordData(Id, State.ToString(), SealStrength, 100f, 0);
            }
            catch
            {
            }
        }

        protected virtual void SpawnDemonActor()
        {
            try
            {
                if (DemonActor != null) return;

                try
                {
                    EraOfWheel.DemonLords.Legion.LegionActorRegistry.EnsureRegistered();
                }
                catch
                {
                }

                if (TryFindExistingDemonActor(out var existing) && existing != null)
                {
                    DemonActor = existing;
                    OwnsDemonActor = true;
                    SyncHealthToActorIfPossible();
                    Logger.Info($"DemonLord.{Id}", $"Re-linked existing demon actor: {Name}");
                    return;
                }

                EnsureSpawnApiResolved();

                object spawnTile = null;
                TryPickSpawnTileFromWorldUnits(out spawnTile);

                var ids = GetSpawnCandidateActorIds();
                if (ids != null)
                {
                    for (int i = 0; i < ids.Length; i++)
                    {
                        var actorId = ids[i];
                        if (string.IsNullOrEmpty(actorId)) continue;

                        if (TrySpawnActor(actorId, spawnTile, out var spawned) && spawned != null)
                        {
                            DemonActor = spawned;
                            OwnsDemonActor = true;
                            MarkAsDemonBoss(DemonActor);
                            SyncHealthToActorIfPossible();
                            Logger.Info($"DemonLord.{Id}", $"Spawned demon actor ({actorId}): {Name}");
                            return;
                        }
                    }
                }

                Logger.Error($"DemonLord.{Id}", "Failed to spawn demon actor. (Strict mode: no fallback binding to existing units)");
            }
            catch (Exception ex)
            {
                Logger.Error($"DemonLord.{Id}", "Error spawning demon actor", ex);
            }
        }

        protected virtual void RemoveDemonActor()
        {
            if (DemonActor != null && OwnsDemonActor)
            {
                TryDespawnActor(DemonActor);
            }

            TryRemoveTrait(DemonActor, "dlm_demon_faction");
            DemonActor = null;
            OwnsDemonActor = false;
            _lastSpawnAttemptYear = int.MinValue;
        }

        protected void TryAddTrait(Actor actor, string traitId)
        {
            if (actor == null || string.IsNullOrEmpty(traitId)) return;
            try
            {
                var method = actor.GetType().GetMethod("addTrait");
                if (method != null)
                {
                    method.Invoke(actor, new object[] { traitId });
                }
            }
            catch
            {
            }
        }

        protected void TryRemoveTrait(Actor actor, string traitId)
        {
            if (actor == null || string.IsNullOrEmpty(traitId)) return;
            try
            {
                var method = actor.GetType().GetMethod("removeTrait") ?? actor.GetType().GetMethod("remove_trait");
                if (method != null)
                {
                    method.Invoke(actor, new object[] { traitId });
                }
            }
            catch
            {
            }
        }

        protected virtual void ResetForNextCycle()
        {
            SealStrength = 100f;
            TotalKills = 0;
            CitiesDestroyed = 0;
            HeroesKilled = 0;
        }

        protected virtual string[] GetSpawnCandidateActorIds()
        {
            return new[]
            {
                EraOfWheel.DemonLords.Legion.LegionActorRegistry.LegionActorId,
                "unit_demon",
                "demon",
                "unit_orc",
                "unit_human",
                "t_sheep"
            };
        }

        private string GetDemonBossMarker()
        {
            return $"eow_demon_boss_{Id}";
        }

        private void MarkAsDemonBoss(Actor actor)
        {
            if (actor == null) return;

            TryAddTrait(actor, "dlm_demon_faction");
            TryAddTrait(actor, "evil");
            TryAddTrait(actor, "madness");

            TrySetStringMember(actor, "name", GetDemonBossMarker());

            var data = GetMemberValue(actor, "data");
            if (data != null)
            {
                TrySetStringMember(data, "name", GetDemonBossMarker());
            }
        }

        private bool TryFindExistingDemonActor(out Actor actor)
        {
            actor = null;

            try
            {
                var units = World.world?.units;
                if (units == null) return false;

                string marker = GetDemonBossMarker();
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

        private void SyncHealthToActorIfPossible()
        {
            if (DemonActor == null) return;
            if (Stats == null) return;

            try
            {
                var data = GetMemberValue(DemonActor, "data");
                if (data == null) return;

                TrySetFloatMember(data, "health", Stats.CurrentHealth);
                TrySetFloatMember(data, "maxHealth", Stats.MaxHealth);
                TrySetFloatMember(data, "health_max", Stats.MaxHealth);
                TrySetFloatMember(data, "max_health", Stats.MaxHealth);
            }
            catch
            {
            }
        }

        private void SyncHealthFromActorIfPossible()
        {
            if (DemonActor == null) return;
            if (Stats == null) return;

            try
            {
                var data = GetMemberValue(DemonActor, "data");
                if (data == null) return;

                if (!TryGetFloatMember(data, "health", out var health)) return;

                if (health < 0f) health = 0f;
                Stats.CurrentHealth = Math.Min(Stats.MaxHealth, health);

                if (Stats.IsDead)
                {
                    if (State == DemonState.Invasion || State == DemonState.Peak)
                    {
                        TransitionState(DemonState.Weakening);
                    }
                }
            }
            catch
            {
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

        private bool TryPickSpawnTileFromWorldUnits(out object tile)
        {
            tile = null;

            try
            {
                var units = World.world?.units;
                if (units == null) return false;

                Actor selected = null;
                int seen = 0;
                foreach (var u in units)
                {
                    if (u == null) continue;
                    seen++;
                    if (UnityEngine.Random.Range(0, seen) == 0)
                    {
                        selected = u;
                    }
                }

                if (selected == null) return false;

                tile = GetMemberValue(selected, "currentTile")
                       ?? GetMemberValue(selected, "tile")
                       ?? GetMemberValue(selected, "current_tile");

                return tile != null;
            }
            catch
            {
                tile = null;
                return false;
            }
        }

        private void TryDespawnActor(Actor actor)
        {
            if (actor == null) return;

            try
            {
                var data = GetMemberValue(actor, "data");
                if (data != null)
                {
                    TrySetFloatMember(data, "health", 0f);
                }
            }
            catch
            {
            }

            TryInvokeMethod(actor, "killHimself");
            TryInvokeMethod(actor, "kill");
            TryInvokeMethod(actor, "die");
            TryInvokeMethod(actor, "Destroy");
        }

        private static void TryInvokeMethod(object obj, string methodName)
        {
            if (obj == null || string.IsNullOrEmpty(methodName)) return;

            try
            {
                var m = obj.GetType().GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                m?.Invoke(obj, null);
            }
            catch
            {
            }
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

        private static void TrySetFloatMember(object obj, string memberName, float value)
        {
            if (obj == null || string.IsNullOrEmpty(memberName)) return;

            try
            {
                var t = obj.GetType();
                const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

                var field = t.GetField(memberName, flags);
                if (field != null && (field.FieldType == typeof(float) || field.FieldType == typeof(int)))
                {
                    field.SetValue(obj, field.FieldType == typeof(int) ? (object)(int)value : value);
                    return;
                }

                var prop = t.GetProperty(memberName, flags);
                if (prop != null && prop.CanWrite && (prop.PropertyType == typeof(float) || prop.PropertyType == typeof(int)))
                {
                    prop.SetValue(obj, prop.PropertyType == typeof(int) ? (object)(int)value : value, null);
                }
            }
            catch
            {
            }
        }

        public virtual void DecreaseSealStrength(float amount)
        {
            SetSealStrength(SealStrength - amount);
        }

        public void SetSealStrength(float strength)
        {
            float previous = SealStrength;
            SealStrength = Math.Max(0f, Math.Min(100f, strength));

            if (Math.Abs(previous - SealStrength) > 0.0001f)
            {
                EventBus.Instance?.Publish(new SealStrengthChangedEvent
                {
                    DemonLordId = Id,
                    PreviousStrength = previous,
                    CurrentStrength = SealStrength
                });
            }

            ModSaveManager.Instance?.UpdateDemonLordData(Id, State.ToString(), SealStrength, Stats.HealthPercent, TotalKills);
        }

        public void SyncSealStrength(float strength)
        {
            SetSealStrength(strength);
        }

        public void LoadFromSaveData(DemonLordSaveData saveData, int cycleCount)
        {
            if (saveData == null) return;

            float powerMultiplier = CycleManager.Instance?.CalculateDemonPowerMultiplier() ?? 1f;
            Stats.CalculateForCycle(cycleCount, powerMultiplier);

            float hp = Math.Max(0f, Math.Min(100f, saveData.health_percent));
            Stats.CurrentHealth = Stats.MaxHealth * (hp / 100f);

            TotalKills = Math.Max(0, saveData.total_kills);
            SetSealStrength(saveData.seal_strength);

            if (Enum.TryParse<DemonState>(saveData.state, out var state))
            {
                State = state;
            }
            else
            {
                State = DemonState.Sealed;
            }
        }

        public void EnsureActorSpawned()
        {
            if (DemonActor != null) return;

            if (State == DemonState.Invasion || State == DemonState.Peak || State == DemonState.Weakening)
            {
                SpawnDemonActor();
            }
        }

        public void RecordKill(bool isHero = false, bool isCity = false)
        {
            TotalKills++;
            if (isHero) HeroesKilled++;
            if (isCity) CitiesDestroyed++;
        }

        public void ApplyDamage(float damage)
        {
            if (damage <= 0f) return;

            Stats.TakeDamage(damage);

            if (State == DemonState.Invasion || State == DemonState.Peak)
            {
                EnsureActorSpawned();
                SyncHealthToActorIfPossible();
            }

            if (Stats.IsDead)
            {
                if (State == DemonState.Invasion || State == DemonState.Peak)
                {
                    TransitionState(DemonState.Weakening);
                }
            }
        }

        protected bool TryGetActorPosition2D(Actor actor, out Vector2 pos)
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

        public virtual void ApplyUniqueAbility()
        {
        }

        public abstract void OnCycleEvolution(int newCycleCount);
    }
}
