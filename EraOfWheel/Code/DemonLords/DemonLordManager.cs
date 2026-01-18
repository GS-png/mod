using System;
using System.Collections.Generic;
using EraOfWheel.Core;
using EraOfWheel.Core.Config;
using EraOfWheel.Core.Events;
using EraOfWheel.Cycle;
using EraOfWheel.Core.Data;
using ModSaveManager = EraOfWheel.Core.Data.SaveManager;

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
            LoadFromSave();
            SubscribeToEvents();
            
            IsInitialized = true;
            Logger.Info(SystemName, $"DemonLordManager initialized with {_demonLords.Count} demon lords");
        }

        private void LoadFromSave()
        {
            var save = ModSaveManager.Instance?.Data;
            if (save == null) return;

            int cycleCount = CycleManager.Instance?.State?.CycleCount ?? save.current_cycle;
            if (cycleCount <= 0) cycleCount = 1;

            if (save.demon_lords != null)
            {
                foreach (var dl in save.demon_lords)
                {
                    if (dl == null || string.IsNullOrEmpty(dl.id)) continue;
                    if (_demonLords.TryGetValue(dl.id, out var demon))
                    {
                        demon.LoadFromSaveData(dl, cycleCount);
                    }
                }
            }

            var preferredId = CycleManager.Instance?.State?.ActiveDemonLordId;
            if (string.IsNullOrEmpty(preferredId))
            {
                preferredId = save.active_demon_lord_id;
                if (CycleManager.Instance?.State != null)
                {
                    CycleManager.Instance.State.ActiveDemonLordId = preferredId ?? "";
                }
            }

            if (!string.IsNullOrEmpty(preferredId) && _demonLords.TryGetValue(preferredId, out var active))
            {
                _activeDemonLord = active;

                if (CycleManager.Instance?.State != null)
                {
                    CycleManager.Instance.State.SealStrength = active.SealStrength;
                }

                _activeDemonLord.EnsureActorSpawned();
            }
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
                    if (_activeDemonLord != null)
                    {
                        float seal = CycleManager.Instance?.State?.SealStrength ?? _activeDemonLord.SealStrength;
                        _activeDemonLord.SyncSealStrength(seal);
                    }
                    _activeDemonLord?.TransitionState(DemonState.Omen);
                    break;
                case CyclePhase.Awakening:
                    _activeDemonLord?.TransitionState(DemonState.Awakening);
                    break;
                case CyclePhase.Invasion:
                    _activeDemonLord?.TransitionState(DemonState.Invasion);
                    break;
                case CyclePhase.Peak:
                    _activeDemonLord?.TransitionState(DemonState.Peak);
                    break;
                case CyclePhase.Weakening:
                    _activeDemonLord?.TransitionState(DemonState.Weakening);
                    break;
                case CyclePhase.Resealed:
                    if (_activeDemonLord != null && _activeDemonLord.State != DemonState.Resealed)
                    {
                        _activeDemonLord.TransitionState(DemonState.Resealed);
                    }
                    break;
                case CyclePhase.Sealed:
                    foreach (var demon in _demonLords.Values)
                    {
                        if (demon != null && demon.State == DemonState.Resealed)
                        {
                            demon.TransitionState(DemonState.Sealed);
                        }
                    }
                    _activeDemonLord = null;
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

            var preferredId = CycleManager.Instance?.State?.ActiveDemonLordId;
            if (!string.IsNullOrEmpty(preferredId) && _demonLords.TryGetValue(preferredId, out var preferred))
            {
                for (int i = 0; i < eligible.Count; i++)
                {
                    if (eligible[i].Id == preferred.Id)
                    {
                        _activeDemonLord = preferred;
                        Logger.Info(SystemName, $"Selected demon lord (preferred) for cycle {cycleCount}: {_activeDemonLord.Name}");
                        return;
                    }
                }
            }

            int index = UnityEngine.Random.Range(0, eligible.Count);
            _activeDemonLord = eligible[index];
            if (CycleManager.Instance?.State != null)
            {
                CycleManager.Instance.State.ActiveDemonLordId = _activeDemonLord.Id;
            }

            ModSaveManager.Instance?.UpdateCycleData(
                CycleManager.Instance?.State?.CycleCount ?? cycleCount,
                CycleManager.Instance?.State?.CurrentPhase.ToString() ?? CyclePhase.Sealed.ToString(),
                CycleManager.Instance?.State?.PhaseStartYear ?? 0,
                CycleManager.Instance?.State?.InvasionStartYear ?? -1,
                CycleManager.Instance?.State?.ActiveDemonLordId ?? _activeDemonLord.Id,
                CycleManager.Instance?.State?.SealStrength ?? _activeDemonLord.SealStrength
            );
            Logger.Info(SystemName, $"Selected demon lord for cycle {cycleCount}: {_activeDemonLord.Name}");
        }

        public bool SetActiveDemonLord(string demonId)
        {
            if (string.IsNullOrEmpty(demonId)) return false;
            if (!_demonLords.TryGetValue(demonId, out var demon)) return false;
            if (!demon.IsEnabled) return false;

            int currentCycle = CycleManager.Instance?.State?.CycleCount ?? 1;
            if (!demon.IsUnlocked(currentCycle)) return false;

            _activeDemonLord = demon;
            if (CycleManager.Instance?.State != null)
            {
                CycleManager.Instance.State.ActiveDemonLordId = demonId;
            }

            ModSaveManager.Instance?.UpdateCycleData(
                CycleManager.Instance?.State?.CycleCount ?? currentCycle,
                CycleManager.Instance?.State?.CurrentPhase.ToString() ?? CyclePhase.Sealed.ToString(),
                CycleManager.Instance?.State?.PhaseStartYear ?? 0,
                CycleManager.Instance?.State?.InvasionStartYear ?? -1,
                CycleManager.Instance?.State?.ActiveDemonLordId ?? demonId,
                CycleManager.Instance?.State?.SealStrength ?? demon.SealStrength
            );

            Logger.Info(SystemName, $"Active demon lord set manually: {demon.Name}");
            return true;
        }

        private void OnCycleCompleted(CycleCompletedEvent e)
        {
            if (_activeDemonLord != null)
            {
                if (_activeDemonLord.State != DemonState.Resealed)
                {
                    _activeDemonLord.TransitionState(DemonState.Resealed);
                }
                int nextCycle = CycleManager.Instance?.State?.CycleCount ?? (e.CycleCount + 1);
                _activeDemonLord.OnCycleEvolution(nextCycle);
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

            _activeDemonLord.ApplyDamage(damage);

            if (!_activeDemonLord.Stats.IsDead &&
                _activeDemonLord.Stats.HealthPercent < 30f &&
                _activeDemonLord.State != DemonState.Weakening)
            {
                _activeDemonLord.TransitionState(DemonState.Weakening);
            }
        }

        public void SealActiveDemonLord(string sealMethod = null)
        {
            if (_activeDemonLord == null) return;

            if (!string.IsNullOrEmpty(sealMethod))
            {
                _activeDemonLord.SetPendingSealMethod(sealMethod);
            }

            _activeDemonLord.TransitionState(DemonState.Resealed);
            
            CycleManager.Instance?.TransitionToPhase(CyclePhase.Resealed);
        }

        public void ForceResetAllDemonsToSealed()
        {
            int cycleCount = CycleManager.Instance?.State?.CycleCount ?? 1;
            foreach (var demon in _demonLords.Values)
            {
                demon?.ForceResetToSealed(cycleCount);
            }
            _activeDemonLord = null;
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
