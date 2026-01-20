using System;
using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.DemonLord
{
    public abstract class DemonLordBase
    {
        public string Id => Definition != null ? Definition.Id : "";
        public string NameKey => Definition != null ? Definition.NameKey : Id;
        public DemonLordDefinition Definition { get; }

        public bool Enabled { get; set; } = true;
        public DemonLordState State { get; private set; } = DemonLordState.Sealed;

        public float CurrentHealthPercent { get; private set; } = 100f;
        public float CurrentHealth => CurrentHealthPercent * MaxHealth / 100f;
        public float MaxHealth => Definition?.BaseHealth ?? 10000f;
        public int TotalKills { get; set; }

        protected DemonLordBase(DemonLordDefinition def)
        {
            Definition = def;
        }

        public void SetEnabled(bool enabled)
        {
            Enabled = enabled;
            if (!Enabled)
            {
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

        public void Update(ModConfig cfg, EraPhase eraPhase)
        {
            if (!Enabled)
            {
                if (State != DemonLordState.Disabled) SetState(DemonLordState.Disabled);
                return;
            }

            OnUpdate(cfg, eraPhase);
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

        public virtual void OnPhaseChanged(EraPhase prev, EraPhase next)
        {
        }

        public virtual void ForceState(DemonLordState state)
        {
            SetState(state);
        }
    }
}
