using System;
using EraOfWheel.Core;
using EraOfWheel.Core.Config;
using EraOfWheel.Core.Events;
using EraOfWheel.Core.Data;
using ModSaveManager = EraOfWheel.Core.Data.SaveManager;
using EraOfWheel.DemonLords;
using System.Reflection;

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
        private int _lastSealDecayYear = -1;
        private string _pendingSealMethod = "execution";

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
            var saveData = ModSaveManager.Instance?.Data;
            if (saveData != null)
            {
                State.CycleCount = saveData.current_cycle;
                State.WorldAgeYears = saveData.world_age_years;
                State.PhaseStartYear = saveData.phase_start_year;
                State.InvasionStartYear = saveData.invasion_start_year;
                State.ActiveDemonLordId = saveData.active_demon_lord_id ?? "";
                State.SealStrength = ErrorHandler.Clamp(saveData.current_seal_strength, 0f, 100f);
                State.SealDecayStarted = saveData.seal_decay_started;
                _lastSealDecayYear = saveData.last_seal_decay_year;
                
                if (Enum.TryParse<CyclePhase>(saveData.current_phase, out var phase))
                {
                    State.CurrentPhase = phase;
                }

                if (State.SealStrength <= 0.0001f && (saveData.current_seal_strength <= 0.0001f))
                {
                    if (saveData.demon_lords == null || saveData.demon_lords.Length == 0)
                    {
                        State.SealStrength = 100f;
                    }
                }

                if (State.InvasionStartYear == 0 && State.CurrentPhase != CyclePhase.Invasion)
                {
                    State.InvasionStartYear = -1;
                }

                if (State.CurrentPhase == CyclePhase.Invasion && State.InvasionStartYear <= 0)
                {
                    State.InvasionStartYear = State.WorldAgeYears;
                }
            }
        }

        public void SetPendingSealMethod(string method)
        {
            if (string.IsNullOrEmpty(method)) return;
            _pendingSealMethod = method;
        }

        public void Update(int currentWorldYear)
        {
            if (!IsInitialized) return;
            if (currentWorldYear <= _lastUpdateYear) return;
            
            State.WorldAgeYears = currentWorldYear;
            _lastUpdateYear = currentWorldYear;

            ModSaveManager.Instance?.UpdateWorldAgeYears(currentWorldYear);
            
            ProcessPhaseLogic();
        }

        private void ProcessPhaseLogic()
        {
            switch (State.CurrentPhase)
            {
                case CyclePhase.Sealed:
                    ProcessSealDecay();
                    CheckCycleTrigger();
                    break;
                case CyclePhase.Omen:
                    ProcessSealDecay();
                    CheckOmenToAwakening();
                    break;
                case CyclePhase.Awakening:
                    SyncPhaseWithDemonState();
                    break;
                case CyclePhase.Invasion:
                case CyclePhase.Peak:
                    SyncPhaseWithDemonState();
                    CheckInvasionTimeout();
                    break;
                case CyclePhase.Weakening:
                    SyncPhaseWithDemonState();
                    break;
            }
        }

        private void SyncPhaseWithDemonState()
        {
            var active = DemonLordManager.Instance?.ActiveDemonLord;
            if (active == null) return;

            var demonState = active.State;

            if (demonState == DemonState.Invasion && State.CurrentPhase != CyclePhase.Invasion)
            {
                TransitionToPhase(CyclePhase.Invasion);
                return;
            }
            if (demonState == DemonState.Peak && State.CurrentPhase != CyclePhase.Peak)
            {
                TransitionToPhase(CyclePhase.Peak);
                return;
            }
            if (demonState == DemonState.Weakening && State.CurrentPhase != CyclePhase.Weakening)
            {
                TransitionToPhase(CyclePhase.Weakening);
                return;
            }
            if (demonState == DemonState.Resealed && State.CurrentPhase != CyclePhase.Resealed)
            {
                TransitionToPhase(CyclePhase.Resealed);
            }
        }

        private void CheckCycleTrigger()
        {
            if (!ShouldTriggerCycle()) return;

            if (State.SealStrength > 50f)
            {
                State.SealStrength = 49f;
                DemonLordManager.Instance?.ActiveDemonLord?.SyncSealStrength(State.SealStrength);
            }

            TransitionToPhase(CyclePhase.Omen);
            Logger.Info(SystemName, "Cycle triggered - forcing seal strength below 50% and entering Omen phase");
        }

        private bool ShouldTriggerCycle()
        {
            if (State.CycleCount == 1 && State.WorldAgeYears < 100)
            {
                return false;
            }

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
                var units = World.world?.units;
                if (units == null) return 0;

                int count = 0;
                foreach (var u in units) count++;
                return count;
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
                var cities = World.world?.cities;
                if (cities == null) return 0;

                int count = 0;
                foreach (var c in cities) count++;
                return count;
            }
            catch
            {
                return 0;
            }
        }

        private int GetLegendaryHeroCount()
        {
            try
            {
                var units = World.world?.units;
                if (units == null) return 0;

                int count = 0;
                foreach (var u in units)
                {
                    if (u == null) continue;

                    if (IsLegendaryHero(u))
                    {
                        count++;
                    }
                }
                return count;
            }
            catch
            {
                return 0;
            }
        }

        private bool IsLegendaryHero(Actor actor)
        {
            try
            {
                if (actor == null) return false;

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
                if (result is bool b) return b;
                return false;
            }
            catch
            {
                return false;
            }
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

        private void CheckOmenToAwakening()
        {
            if (State.SealStrength <= 0f)
            {
                TransitionToPhase(CyclePhase.Awakening);
                return;
            }

            if (State.SealStrength <= 20f)
            {
                TransitionToPhase(CyclePhase.Awakening);
            }
        }

        private void ProcessSealDecay()
        {
            if (State.CurrentPhase != CyclePhase.Sealed && State.CurrentPhase != CyclePhase.Omen) return;

            if (State.CycleCount == 1 && State.WorldAgeYears < 100)
            {
                State.SealStrength = 100f;
                State.SealDecayStarted = false;
                _lastSealDecayYear = -1;
                return;
            }

            if (!State.SealDecayStarted)
            {
                State.SealDecayStarted = true;
                if (_lastSealDecayYear < 0)
                {
                    _lastSealDecayYear = State.WorldAgeYears;
                }
            }

            int interval = Math.Max(1, _config.seal_decay_interval_years);
            if (_lastSealDecayYear < 0) _lastSealDecayYear = State.WorldAgeYears;

            if (State.WorldAgeYears - _lastSealDecayYear >= interval)
            {
                float amount = Math.Max(0f, _config.seal_decay_amount);

                float previous = State.SealStrength;

                var active = DemonLordManager.Instance?.ActiveDemonLord;
                if (active != null)
                {
                    active.DecreaseSealStrength(amount);
                    State.SealStrength = active.SealStrength;
                }
                else
                {
                    State.SealStrength = ErrorHandler.Clamp(State.SealStrength - amount, 0f, 100f);
                }

                _lastSealDecayYear = State.WorldAgeYears;

                if (State.CurrentPhase == CyclePhase.Sealed && State.SealStrength <= 50f)
                {
                    TransitionToPhase(CyclePhase.Omen);
                }

                if (Math.Abs(previous - State.SealStrength) > 0.0001f)
                {
                    ModSaveManager.Instance?.UpdateCycleData(
                        State.CycleCount,
                        State.CurrentPhase.ToString(),
                        State.PhaseStartYear,
                        State.InvasionStartYear,
                        State.ActiveDemonLordId,
                        State.SealStrength,
                        State.SealDecayStarted,
                        _lastSealDecayYear
                    );
                }
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

            ModSaveManager.Instance?.UpdateCycleData(
                State.CycleCount,
                State.CurrentPhase.ToString(),
                State.PhaseStartYear,
                State.InvasionStartYear,
                State.ActiveDemonLordId,
                State.SealStrength,
                State.SealDecayStarted,
                _lastSealDecayYear
            );
        }

        private void CompleteCycle()
        {
            int completedCycle = State.CycleCount;
            State.IncrementCycle();
            State.SealStrength = 100f;
            State.SealDecayStarted = false;
            _lastSealDecayYear = -1;
            
            EventBus.Instance?.Publish(new CycleCompletedEvent
            {
                CycleCount = completedCycle,
                SealMethod = _pendingSealMethod
            });
            
            Logger.Info(SystemName, $"Cycle {completedCycle} completed, entering Cycle {State.CycleCount}");

            _pendingSealMethod = "execution";

            TransitionToPhase(CyclePhase.Sealed);
            ModSaveManager.Instance?.SaveToWorld();
        }

        public void ForceRestartCycle()
        {
            var keepRatio = ConfigManager.Instance?.Config?.seal?.restart_cycle?.legacy_keep_ratio ?? 0.5f;
            
            State.Reset(keepRatio);

            State.SealStrength = 100f;
            State.SealDecayStarted = false;
            _lastSealDecayYear = -1;

            LegacySystem.Instance?.ApplyRestartPenalty(keepRatio);

            _pendingSealMethod = "execution";
            
            Logger.Info(SystemName, $"Cycle restarted with {keepRatio * 100}% legacy retention");

            ModSaveManager.Instance?.UpdateCycleData(
                State.CycleCount,
                State.CurrentPhase.ToString(),
                State.PhaseStartYear,
                State.InvasionStartYear,
                State.ActiveDemonLordId,
                State.SealStrength,
                State.SealDecayStarted,
                _lastSealDecayYear
            );
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
            ModSaveManager.Instance?.UpdateCycleData(
                State.CycleCount,
                State.CurrentPhase.ToString(),
                State.PhaseStartYear,
                State.InvasionStartYear,
                State.ActiveDemonLordId,
                State.SealStrength,
                State.SealDecayStarted,
                _lastSealDecayYear
            );
            
            IsInitialized = false;
            Instance = null;
            Logger.Info(SystemName, "CycleManager disposed");
        }
    }
}
