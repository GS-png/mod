using System;
using System.Collections.Generic;
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
            Logger.Debug(SystemName, $"Spawning {count} demon units for wave {wave.WaveNumber}");
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
