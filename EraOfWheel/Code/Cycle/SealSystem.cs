using System;
using EraOfWheel.Core;
using EraOfWheel.Core.Config;
using EraOfWheel.Core.Events;
using EraOfWheel.DemonLords;

namespace EraOfWheel.Cycle
{
    public class SealSystem : IModSystem
    {
        public static SealSystem Instance { get; private set; }
        
        public string SystemName => "SealSystem";
        public bool IsInitialized { get; private set; }
        
        public float RitualProgress { get; private set; } = 0f;
        public bool SealWarWindowActive { get; private set; } = false;
        
        private SealConfig _config;
        private int _failureStartYear = -1;

        public void Initialize()
        {
            if (IsInitialized) return;
            
            Instance = this;
            _config = ConfigManager.Instance?.Config?.seal ?? new SealConfig();
            
            SubscribeToEvents();
            
            IsInitialized = true;
            Logger.Info(SystemName, "SealSystem initialized");
        }

        private void SubscribeToEvents()
        {
            EventBus.Instance?.Subscribe<DemonStateChangedEvent>(OnDemonStateChanged);
            EventBus.Instance?.Subscribe<PhaseChangedEvent>(OnPhaseChanged);
        }

        private void OnDemonStateChanged(DemonStateChangedEvent e)
        {
            if (e.CurrentState == DemonState.Weakening.ToString())
            {
                ActivateSealWarWindow();
            }
        }

        private void OnPhaseChanged(PhaseChangedEvent e)
        {
            if (e.CurrentPhase == CyclePhase.Resealed.ToString())
            {
                DeactivateSealWarWindow();
            }
        }

        public void Update(int currentYear)
        {
            if (!IsInitialized) return;
            
            var phase = CycleManager.Instance?.State?.CurrentPhase;
            if (phase == null) return;
            
            if (phase == CyclePhase.Invasion || phase == CyclePhase.Peak)
            {
                CheckFailureConditions(currentYear);
                CheckInvasionTimeout(currentYear);
            }
            
            if (SealWarWindowActive)
            {
                UpdateRitualProgress();
            }
        }

        private void CheckInvasionTimeout(int currentYear)
        {
            var invasionYears = CycleManager.Instance?.State?.YearsInInvasion ?? 0;
            if (invasionYears >= _config.invasion_window_years.max)
            {
                Logger.Warn(SystemName, "Invasion timeout - forcing seal war window");
                ActivateSealWarWindow();
            }
        }

        private void ActivateSealWarWindow()
        {
            if (SealWarWindowActive) return;
            
            SealWarWindowActive = true;
            RitualProgress = 0f;
            
            Logger.Info(SystemName, "Seal War Window activated!");
        }

        private void DeactivateSealWarWindow()
        {
            SealWarWindowActive = false;
            RitualProgress = 0f;
            _failureStartYear = -1;
        }

        private void UpdateRitualProgress()
        {
            if (!_config.victory_conditions.ritual) return;
            
            // Simplified: progress increases over time when seal war is active
            RitualProgress += 1f;
            
            if (RitualProgress >= _config.victory_conditions.ritual_progress_required)
            {
                TriggerRitualSeal();
            }
        }

        private void CheckFailureConditions(int currentYear)
        {
            if (!CanCheckFailure()) return;
            
            float controlledRatio = CalculateDemonControlRatio();
            
            if (controlledRatio >= _config.failure_conditions.cities_controlled_ratio)
            {
                if (_failureStartYear < 0)
                {
                    _failureStartYear = currentYear;
                }
                else if (currentYear - _failureStartYear >= _config.failure_conditions.cities_controlled_duration_years)
                {
                    TriggerFailure("Demon controls too many cities");
                }
            }
            else
            {
                _failureStartYear = -1;
            }
            
            int aliveKingdoms = CountAliveKingdoms();
            if (aliveKingdoms <= _config.failure_conditions.min_kingdoms)
            {
                TriggerFailure("Too few kingdoms remain");
            }
        }

        private bool CanCheckFailure()
        {
            var phase = CycleManager.Instance?.State?.CurrentPhase;
            return phase == CyclePhase.Invasion || phase == CyclePhase.Peak;
        }

        private float CalculateDemonControlRatio()
        {
            try
            {
                var cities = World.world?.cities;
                if (cities == null || cities.Count == 0) return 0f;
                
                int demonCities = 0;
                foreach (var city in cities)
                {
                    if (city?.kingdom?.data?.id?.Contains("demon") == true)
                    {
                        demonCities++;
                    }
                }
                
                return (float)demonCities / cities.Count;
            }
            catch
            {
                return 0f;
            }
        }

        private int CountAliveKingdoms()
        {
            try
            {
                var kingdoms = World.world?.kingdoms;
                if (kingdoms == null) return 0;
                
                int count = 0;
                foreach (var kingdom in kingdoms)
                {
                    if (kingdom?.cities?.Count > 0 && !kingdom.data.id.Contains("demon"))
                    {
                        count++;
                    }
                }
                return count;
            }
            catch
            {
                return 1;
            }
        }

        public void TriggerExecutionSeal()
        {
            if (!_config.victory_conditions.execution)
            {
                Logger.Warn(SystemName, "Execution seal not enabled");
                return;
            }
            
            var demon = DemonLordManager.Instance?.ActiveDemonLord;
            if (demon == null || !demon.Stats.IsDead)
            {
                Logger.Warn(SystemName, "Demon lord not defeated");
                return;
            }
            
            CompleteSeal("execution");
        }

        private void TriggerRitualSeal()
        {
            Logger.Info(SystemName, "Ritual seal completed!");
            CompleteSeal("ritual");
        }

        private void CompleteSeal(string method)
        {
            Logger.Info(SystemName, $"Seal completed via {method}!");
            
            DemonLordManager.Instance?.SealActiveDemonLord();
            
            DeactivateSealWarWindow();
        }

        private void TriggerFailure(string reason)
        {
            Logger.Warn(SystemName, $"Failure condition met: {reason}");
            
            if (_config.restart_cycle.enabled)
            {
                OfferCycleRestart();
            }
            else
            {
                Logger.Error(SystemName, "No recovery option available - Terminal Aftermath");
            }
        }

        private void OfferCycleRestart()
        {
            Logger.Info(SystemName, "Offering cycle restart option");
            // Note: Full implementation would show UI dialog
        }

        public void ForceRestart()
        {
            CycleManager.Instance?.ForceRestartCycle();
            DeactivateSealWarWindow();
        }

        public void AddRitualProgress(float amount)
        {
            if (!SealWarWindowActive) return;
            
            RitualProgress = Math.Min(
                _config.victory_conditions.ritual_progress_required,
                RitualProgress + amount
            );
        }

        public void Dispose()
        {
            EventBus.Instance?.Unsubscribe<DemonStateChangedEvent>(OnDemonStateChanged);
            EventBus.Instance?.Unsubscribe<PhaseChangedEvent>(OnPhaseChanged);
            
            DeactivateSealWarWindow();
            IsInitialized = false;
            Instance = null;
            Logger.Info(SystemName, "SealSystem disposed");
        }
    }
}
