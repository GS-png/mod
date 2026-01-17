using System;
using EraOfWheel.Core;
using EraOfWheel.Core.Config;
using EraOfWheel.Core.Events;
using EraOfWheel.Core.Data;

namespace EraOfWheel.Cycle
{
    public class CycleManager : IModSystem
    {
        public static CycleManager Instance { get; private set; }
        
        public string SystemName => "CycleManager";
        public bool IsInitialized { get; private set; }
        
        public CycleState State { get; private set; }
        
        private int _lastUpdateYear = -1;
        private CycleConfig _config;

        public void Initialize()
        {
            if (IsInitialized) return;
            
            Instance = this;
            State = new CycleState();
            _config = ConfigManager.Instance?.Config?.cycle ?? new CycleConfig();
            
            LoadState();
            
            IsInitialized = true;
            Logger.Info(SystemName, $"CycleManager initialized - Cycle {State.CycleCount}, Phase {State.CurrentPhase}");
        }

        private void LoadState()
        {
            var saveData = SaveManager.Instance?.Data;
            if (saveData != null)
            {
                State.CycleCount = saveData.current_cycle;
                State.WorldAgeYears = saveData.world_age_years;
                
                if (Enum.TryParse<CyclePhase>(saveData.current_phase, out var phase))
                {
                    State.CurrentPhase = phase;
                }
            }
        }

        public void Update(int currentWorldYear)
        {
            if (!IsInitialized) return;
            if (currentWorldYear <= _lastUpdateYear) return;
            
            State.WorldAgeYears = currentWorldYear;
            _lastUpdateYear = currentWorldYear;
            
            ProcessPhaseLogic();
        }

        private void ProcessPhaseLogic()
        {
            switch (State.CurrentPhase)
            {
                case CyclePhase.Sealed:
                    CheckCycleTrigger();
                    break;
                case CyclePhase.Omen:
                    CheckOmenToAwakening();
                    break;
                case CyclePhase.Invasion:
                case CyclePhase.Peak:
                    CheckInvasionTimeout();
                    break;
            }
        }

        private void CheckCycleTrigger()
        {
            if (!ShouldTriggerCycle()) return;
            
            TransitionToPhase(CyclePhase.Omen);
            Logger.Info(SystemName, "Cycle triggered - entering Omen phase");
        }

        private bool ShouldTriggerCycle()
        {
            var conditions = _config.trigger_conditions;
            if (conditions.conditions == null || conditions.conditions.Count == 0)
            {
                return State.WorldAgeYears >= 600;
            }
            
            bool isOrMode = conditions.method.ToUpper() == "OR";
            bool anyMet = false;
            bool allMet = true;
            
            foreach (var condition in conditions.conditions)
            {
                bool met = EvaluateCondition(condition);
                if (met) anyMet = true;
                if (!met) allMet = false;
            }
            
            return isOrMode ? anyMet : allMet;
        }

        private bool EvaluateCondition(TriggerCondition condition)
        {
            switch (condition.type)
            {
                case "world_age_years":
                    return State.WorldAgeYears >= condition.threshold;
                case "total_population":
                    return GetWorldPopulation() >= condition.threshold;
                case "total_cities":
                    return GetWorldCityCount() >= condition.threshold;
                case "legendary_heroes":
                    return GetLegendaryHeroCount() >= condition.threshold;
                default:
                    Logger.Warn(SystemName, $"Unknown trigger condition type: {condition.type}");
                    return false;
            }
        }

        private int GetWorldPopulation()
        {
            try
            {
                return World.world?.units?.Count ?? 0;
            }
            catch
            {
                return 0;
            }
        }

        private int GetWorldCityCount()
        {
            try
            {
                return World.world?.cities?.Count ?? 0;
            }
            catch
            {
                return 0;
            }
        }

        private int GetLegendaryHeroCount()
        {
            return 0;
        }

        private void CheckOmenToAwakening()
        {
            if (State.YearsInCurrentPhase >= 50)
            {
                TransitionToPhase(CyclePhase.Awakening);
            }
        }

        private void CheckInvasionTimeout()
        {
            var maxYears = ConfigManager.Instance?.Config?.seal?.invasion_window_years?.max ?? 200;
            
            if (State.YearsInInvasion >= maxYears)
            {
                Logger.Warn(SystemName, "Invasion timeout reached - forcing seal war window");
                TransitionToPhase(CyclePhase.Weakening);
            }
        }

        public void TransitionToPhase(CyclePhase newPhase)
        {
            if (!State.CurrentPhase.CanTransitionTo(newPhase))
            {
                Logger.Warn(SystemName, $"Invalid phase transition: {State.CurrentPhase} -> {newPhase}");
                return;
            }
            
            var previousPhase = State.CurrentPhase;
            State.TransitionTo(newPhase);
            
            EventBus.Instance?.Publish(new PhaseChangedEvent
            {
                PreviousPhase = previousPhase.ToString(),
                CurrentPhase = newPhase.ToString(),
                CycleCount = State.CycleCount
            });
            
            Logger.Info(SystemName, $"Phase transition: {previousPhase} -> {newPhase}");
            
            if (newPhase == CyclePhase.Resealed)
            {
                CompleteCycle();
            }
        }

        private void CompleteCycle()
        {
            State.IncrementCycle();
            
            EventBus.Instance?.Publish(new CycleCompletedEvent
            {
                CycleCount = State.CycleCount,
                SealMethod = "execution"
            });
            
            Logger.Info(SystemName, $"Cycle {State.CycleCount - 1} completed, entering Cycle {State.CycleCount}");
            
            State.TransitionTo(CyclePhase.Sealed);
            
            SaveManager.Instance?.UpdateCycleData(State.CycleCount, State.CurrentPhase.ToString());
            SaveManager.Instance?.SaveToWorld();
        }

        public void ForceRestartCycle()
        {
            var keepRatio = ConfigManager.Instance?.Config?.seal?.restart_cycle?.legacy_keep_ratio ?? 0.5f;
            
            State.Reset(keepRatio);
            
            Logger.Info(SystemName, $"Cycle restarted with {keepRatio * 100}% legacy retention");
            
            SaveManager.Instance?.UpdateCycleData(State.CycleCount, State.CurrentPhase.ToString());
        }

        public float CalculateDemonPowerMultiplier()
        {
            var diffConfig = ConfigManager.Instance?.Config?.difficulty;
            if (diffConfig == null || !diffConfig.enabled)
            {
                return 1f;
            }
            
            float cycleMultiplier = 1f + (State.CycleCount * diffConfig.cycle_growth);
            
            float adaptiveMultiplier = 1f;
            if (diffConfig.adaptive.enabled)
            {
                float csi = CalculateCSI();
                adaptiveMultiplier = Lerp(diffConfig.adaptive.min, diffConfig.adaptive.max, csi / 100f);
            }
            
            float finalMultiplier = cycleMultiplier * adaptiveMultiplier;
            return ErrorHandler.Clamp(finalMultiplier, diffConfig.caps.min_power, diffConfig.caps.max_power);
        }

        private float CalculateCSI()
        {
            float popScore = Math.Min(20f, GetWorldPopulation() / 500f);
            float cityScore = Math.Min(15f, GetWorldCityCount() / 3.33f);
            float heroScore = Math.Min(20f, GetLegendaryHeroCount() * 4f);
            
            return popScore + cityScore + heroScore;
        }

        private float Lerp(float a, float b, float t)
        {
            t = ErrorHandler.Clamp(t, 0f, 1f);
            return a + (b - a) * t;
        }

        public void Dispose()
        {
            SaveManager.Instance?.UpdateCycleData(State.CycleCount, State.CurrentPhase.ToString());
            
            IsInitialized = false;
            Instance = null;
            Logger.Info(SystemName, "CycleManager disposed");
        }
    }
}
