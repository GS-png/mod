using System;
using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.DemonLord
{
    public abstract class DemonLordBase
    {
        private bool _stateForced;
#if !ERAWHEEL_SELFTEST
        private long _boundActorId = -1;
#endif

        public string Id => Definition != null ? Definition.Id : "";
        public string NameKey => Definition != null ? Definition.NameKey : Id;
        public DemonLordDefinition Definition { get; }

        public bool Enabled { get; set; } = true;
        public DemonLordState State { get; private set; } = DemonLordState.Sealed;
        public bool IsStateForced => _stateForced;

        public object Actor { get; private set; }
        public bool HasActor => Actor != null;

        private float _maxHealth;
        public float CurrentHealthPercent { get; private set; } = 100f;
        public float CurrentHealth => CurrentHealthPercent * MaxHealth / 100f;
        public float MaxHealth => _maxHealth > 0f ? _maxHealth : GetBaseHealth();
        public int TotalKills { get; set; }

        public StrongholdData Stronghold { get; private set; }

        protected DemonLordBase(DemonLordDefinition def)
        {
            Definition = def;
            _maxHealth = GetBaseHealth();
        }

        public void SetEnabled(bool enabled)
        {
            if (Enabled == enabled)
            {
                if (!Enabled && State != DemonLordState.Disabled)
                {
                    SetState(DemonLordState.Disabled);
                }
                return;
            }

            Enabled = enabled;
            ClearForcedState();
            if (!Enabled)
            {
                ClearActor();
                SetState(DemonLordState.Disabled);
            }
            else if (State == DemonLordState.Disabled)
            {
                SetState(DemonLordState.Sealed);
            }
        }

        public void ResetForNewCycle()
        {
            CurrentHealthPercent = 100f;
            ApplyGrowth(1f);
            ClearForcedState();
            ClearActor();
            Stronghold = null;
            if (Enabled)
            {
                SetState(DemonLordState.Sealed);
            }
            else
            {
                SetState(DemonLordState.Disabled);
            }
        }

        public void SetHealthPercent(float hp)
        {
            if (hp < 0f) hp = 0f;
            if (hp > 100f) hp = 100f;
            CurrentHealthPercent = hp;
        }

        public void ApplyGrowth(float multiplier)
        {
            if (multiplier <= 0f) multiplier = 1f;
            _maxHealth = GetBaseHealth() * multiplier;
            if (_maxHealth < 1f) _maxHealth = 1f;
        }

        public void OverrideBaseHealth(float baseHealth)
        {
            if (baseHealth <= 0f) return;
            if (Definition == null) return;
            Definition.BaseHealth = baseHealth;
            _maxHealth = baseHealth;
        }

        public void BindActor(object actor)
        {
            if (actor == null) return;
            if (ReferenceEquals(Actor, actor)) return;
            if (Actor != null) ClearActor();

            Actor = actor;
#if !ERAWHEEL_SELFTEST
            var typed = actor as Actor;
            if (typed == null) return;

            var id = typed.getID();
            if (id <= 0 || id == _boundActorId) return;

            _boundActorId = id;
            DemonActorRegistry.Register(typed);
            typed.callbacks_on_death += OnDemonActorDeath;
#endif
        }

        public void ClearActor()
        {
#if !ERAWHEEL_SELFTEST
            var typed = Actor as Actor;
            if (typed != null)
            {
                typed.callbacks_on_death -= OnDemonActorDeath;
                DemonActorRegistry.Unregister(typed);
            }
            _boundActorId = -1;
#endif
            Actor = null;
        }

        public bool TryGetActorHealthPercent(out float percent)
        {
            percent = 0f;
            return Actor != null && WorldCompat.TryGetActorHealthPercent(Actor, out percent);
        }

        public void Update(ModConfig cfg, EraPhase eraPhase)
        {
            if (!Enabled)
            {
                if (State != DemonLordState.Disabled) SetState(DemonLordState.Disabled);
                return;
            }

            OnUpdate(cfg, eraPhase);
            UpdateUniqueMechanic(cfg, eraPhase);
        }

        protected abstract void OnUpdate(ModConfig cfg, EraPhase eraPhase);

        protected void SetState(DemonLordState s)
        {
            if (s == State) return;
            var prev = State;
            State = s;

            try
            {
                EventBus.Publish(new DemonLordStateChangedEvent
                {
                    DemonLordId = Id,
                    PreviousState = prev,
                    NewState = s,
                    WorldTime = WorldCompat.GetWorldAge()
                });
            }
            catch
            {
            }
        }

        public virtual void OnSelectedForAwakening(int cycleCount)
        {
        }

        public virtual void OnAwaken(int cycleCount)
        {
            OnSelectedForAwakening(cycleCount);
        }

        public virtual void OnKill(object victim)
        {
        }

        public virtual void OnDamageDealt(object target, float damage)
        {
        }

        public virtual void OnDamageTaken(object attacker, float damage)
        {
        }

        public virtual void UpdateUniqueMechanic(ModConfig cfg, EraPhase eraPhase)
        {
        }

        public virtual void OnPhaseChanged(EraPhase prev, EraPhase next)
        {
        }

        protected void SpawnWithStronghold(SpawnSystem spawnSystem, StrongholdSystem strongholdSystem)
        {
            if (spawnSystem == null || strongholdSystem == null) return;

            spawnSystem.LogSpawnAttempt(Id);
            var actor = spawnSystem.TrySpawnDemon(Id);
            if (actor == null)
            {
                Log.Warning("[EraWheel] Demon spawn failed: " + Id);
                return;
            }

            BindActor(actor);

            if (spawnSystem.TryGetActorTileCoords(actor, out var x, out var y))
            {
                SetStronghold(strongholdSystem.CreateStronghold(Id, x, y));
            }
            else
            {
                SetStronghold(strongholdSystem.CreateStronghold(Id));
            }
        }

        public void SetStronghold(StrongholdData stronghold)
        {
            Stronghold = stronghold;
        }

        public virtual void ForceState(DemonLordState state)
        {
            _stateForced = true;
            SetState(state);
        }

        public void ClearForcedState()
        {
            _stateForced = false;
        }

        internal void UpdateStateFromSystem(DemonLordState state)
        {
            if (_stateForced) return;
            SetState(state);
        }

        private float GetBaseHealth()
        {
            var baseHealth = Definition != null ? Definition.BaseHealth : 0f;
            if (baseHealth <= 0f) baseHealth = 10000f;
            return baseHealth;
        }

#if !ERAWHEEL_SELFTEST
        private void OnDemonActorDeath(Actor deadActor)
        {
            if (deadActor == null) return;
            DemonActorRegistry.Unregister(deadActor);
            SetHealthPercent(0f);

            try
            {
                var cycle = global::EraWheel.Main.Instance?.CycleManager;
                if (cycle != null)
                {
                    cycle.SetExternalDemonHealthPercent(0f);
                }
            }
            catch
            {
            }

            try
            {
                EventBus.Publish(new DemonKillEvent
                {
                    Count = 1,
                    WorldTime = WorldCompat.GetWorldAge()
                });
            }
            catch
            {
            }
        }
#endif
    }
}
