using System;
using System.Collections.Generic;
using EraOfWheel.Core;
using EraOfWheel.Core.Config;
using EraOfWheel.Core.Events;
using EraOfWheel.Cycle;

namespace EraOfWheel.DemonLords
{
    public class DemonLordManager : IModSystem
    {
        public static DemonLordManager Instance { get; private set; }
        
        public string SystemName => "DemonLordManager";
        public bool IsInitialized { get; private set; }
        
        private Dictionary<string, BaseDemonLord> _demonLords = new Dictionary<string, BaseDemonLord>();
        private BaseDemonLord _activeDemonLord;

        public IEnumerable<BaseDemonLord> AllDemonLords => _demonLords.Values;
        public BaseDemonLord ActiveDemonLord => _activeDemonLord;

        public void Initialize()
        {
            if (IsInitialized) return;
            
            Instance = this;
            
            RegisterDemonLords();
            SubscribeToEvents();
            
            IsInitialized = true;
            Logger.Info(SystemName, $"DemonLordManager initialized with {_demonLords.Count} demon lords");
        }

        private void RegisterDemonLords()
        {
            RegisterDemonLord(new VoidLord());
            RegisterDemonLord(new PlagueMother());
        }

        private void RegisterDemonLord(BaseDemonLord demonLord)
        {
            _demonLords[demonLord.Id] = demonLord;
            Logger.Debug(SystemName, $"Registered demon lord: {demonLord.Name}");
        }

        private void SubscribeToEvents()
        {
            EventBus.Instance?.Subscribe<PhaseChangedEvent>(OnPhaseChanged);
            EventBus.Instance?.Subscribe<CycleCompletedEvent>(OnCycleCompleted);
        }

        private void OnPhaseChanged(PhaseChangedEvent e)
        {
            if (!Enum.TryParse<CyclePhase>(e.CurrentPhase, out var phase)) return;
            
            switch (phase)
            {
                case CyclePhase.Omen:
                    SelectActiveDemonLord(e.CycleCount);
                    _activeDemonLord?.TransitionState(DemonState.Omen);
                    break;
                case CyclePhase.Awakening:
                    _activeDemonLord?.TransitionState(DemonState.Awakening);
                    break;
            }
        }

        private void SelectActiveDemonLord(int cycleCount)
        {
            var eligible = new List<BaseDemonLord>();
            
            foreach (var demon in _demonLords.Values)
            {
                if (demon.IsEnabled && demon.IsUnlocked(cycleCount))
                {
                    eligible.Add(demon);
                }
            }
            
            if (eligible.Count == 0)
            {
                Logger.Warn(SystemName, "No eligible demon lords for this cycle!");
                return;
            }
            
            int index = UnityEngine.Random.Range(0, eligible.Count);
            _activeDemonLord = eligible[index];
            
            Logger.Info(SystemName, $"Selected demon lord for cycle {cycleCount}: {_activeDemonLord.Name}");
        }

        private void OnCycleCompleted(CycleCompletedEvent e)
        {
            if (_activeDemonLord != null)
            {
                _activeDemonLord.TransitionState(DemonState.Resealed);
                _activeDemonLord.OnCycleEvolution(e.CycleCount + 1);
            }
            
            _activeDemonLord = null;
        }

        public void Update(int currentYear)
        {
            if (!IsInitialized) return;
            
            _activeDemonLord?.Update(currentYear);
        }

        public BaseDemonLord GetDemonLord(string id)
        {
            return _demonLords.TryGetValue(id, out var demon) ? demon : null;
        }

        public void DamageDemonLord(float damage)
        {
            if (_activeDemonLord == null) return;
            
            _activeDemonLord.Stats.TakeDamage(damage);
            
            if (_activeDemonLord.Stats.IsDead)
            {
                Logger.Info(SystemName, $"{_activeDemonLord.Name} has been defeated!");
                _activeDemonLord.TransitionState(DemonState.Weakening);
            }
            else if (_activeDemonLord.Stats.HealthPercent < 30f && _activeDemonLord.State != DemonState.Weakening)
            {
                _activeDemonLord.TransitionState(DemonState.Weakening);
            }
        }

        public void SealActiveDemonLord()
        {
            if (_activeDemonLord == null) return;
            
            _activeDemonLord.TransitionState(DemonState.Resealed);
            
            CycleManager.Instance?.TransitionToPhase(CyclePhase.Resealed);
        }

        public void Dispose()
        {
            EventBus.Instance?.Unsubscribe<PhaseChangedEvent>(OnPhaseChanged);
            EventBus.Instance?.Unsubscribe<CycleCompletedEvent>(OnCycleCompleted);
            
            _demonLords.Clear();
            _activeDemonLord = null;
            
            IsInitialized = false;
            Instance = null;
            Logger.Info(SystemName, "DemonLordManager disposed");
        }
    }
}
