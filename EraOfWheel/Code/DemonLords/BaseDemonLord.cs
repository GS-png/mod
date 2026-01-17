using System;
using System.Reflection;
using UnityEngine;
using EraOfWheel.Core;
using Logger = EraOfWheel.Core.Logger;
using EraOfWheel.Core.Events;
using EraOfWheel.Cycle;

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
            
            EventBus.Instance?.Publish(new DemonSealedEvent
            {
                DemonLordId = Id,
                SealMethod = Stats.IsDead ? "execution" : "ritual",
                CycleCount = cycleCount
            });
            
            RemoveDemonActor();
            ResetForNextCycle();
            
            Logger.Info($"DemonLord.{Id}", $"{Name} has been sealed!");
        }

        protected virtual void SpawnDemonActor()
        {
            Logger.Info($"DemonLord.{Id}", $"Spawning demon actor (placeholder)");
        }

        protected virtual void RemoveDemonActor()
        {
            DemonActor = null;
        }

        protected virtual void ResetForNextCycle()
        {
            SealStrength = 100f;
            TotalKills = 0;
            CitiesDestroyed = 0;
            HeroesKilled = 0;
        }

        public void DecreaseSealStrength(float amount)
        {
            SealStrength = Math.Max(0f, SealStrength - amount);
            
            EventBus.Instance?.Publish(new SealStrengthChangedEvent
            {
                DemonLordId = Id,
                PreviousStrength = SealStrength + amount,
                CurrentStrength = SealStrength
            });
        }

        public void RecordKill(bool isHero = false, bool isCity = false)
        {
            TotalKills++;
            if (isHero) HeroesKilled++;
            if (isCity) CitiesDestroyed++;
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
