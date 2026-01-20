using System;
using EraWheel.Config;
using EraWheel.Civilization;
using EraWheel.Data;
using EraWheel.Narrative;

namespace EraWheel.Core
{
    public class CycleManager
    {
        public int CycleCount { get; private set; }
        public EraPhase CurrentPhase { get; private set; } = EraPhase.Sealed;

        public long WorldAge { get; private set; }
        public long PhaseStartWorldAge { get; private set; }

        public int OmenTargetYears { get; private set; } = 30;
        public int AwakeningTargetYears { get; private set; } = 20;

        public float DemonHealthPercent { get; private set; } = 100f;
        private long _lastDemonHealthWorldAge;

        public SealSystem SealSystem { get; } = new SealSystem();
        public ProsperityTracker ProsperityTracker { get; } = new ProsperityTracker();
        public CycleHistory History { get; } = new CycleHistory();

        private readonly EraStateMachine _stateMachine = new EraStateMachine();
        private readonly Random _rng = new Random();

        private ModConfig _lastConfig;

        public event Action<EraPhase, EraPhase> OnPhaseChanged;
        public event Action<int> OnCycleCompleted;

        public CycleManager()
        {
            PhaseStartWorldAge = 0;
        }

        public void Initialize(ModConfig cfg)
        {
            _lastConfig = cfg;
            WorldAge = WorldCompat.GetWorldAge();
            SealSystem.Reset(cfg, WorldAge);
            ProsperityTracker.Enable();
            PhaseStartWorldAge = WorldAge;
            PickPhaseDurations(cfg);

            DemonHealthPercent = 100f;
            _lastDemonHealthWorldAge = WorldAge;
        }

        public void Update(ModConfig cfg)
        {
            _lastConfig = cfg;
            WorldAge = WorldCompat.GetWorldAge();

            if (PhaseStartWorldAge == 0)
            {
                PhaseStartWorldAge = WorldAge;
            }

            SealSystem.Update(cfg, WorldAge, CurrentPhase);

            UpdateSimulatedDemonHealth();

            if (CurrentPhase == EraPhase.Sealed)
            {
                ProsperityTracker.Update(cfg);
            }

            var prosperityReached = ProsperityTracker.ProsperityReached;
            if (CurrentPhase == EraPhase.Sealed && !ProsperityTracker.HasUsableSnapshot)
            {
                prosperityReached = false;
            }

            if (_stateMachine.TryTransition(this, cfg, prosperityReached, DemonHealthPercent))
            {
                if (CurrentPhase == EraPhase.Resealed)
                {
                    HandleResealed();
                }
            }
        }

        internal bool TransitionTo(EraPhase newPhase, string reason)
        {
            if (newPhase == CurrentPhase) return false;

            var prev = CurrentPhase;
            CurrentPhase = newPhase;
            PhaseStartWorldAge = WorldAge;

            if (newPhase == EraPhase.Awakening)
            {
                DemonHealthPercent = 30f;
            }

            if (newPhase == EraPhase.Invasion)
            {
                DemonHealthPercent = 100f;
            }

            if (newPhase == EraPhase.Sealed)
            {
                SealSystem.Reset(_lastConfig, WorldAge);
                ProsperityTracker.Enable();
                SealSystem.ClearWeakeningStart();
                PickPhaseDurations(_lastConfig);

                DemonHealthPercent = 100f;
                _lastDemonHealthWorldAge = WorldAge;
            }
            else
            {
                ProsperityTracker.Disable();
            }

            if (newPhase == EraPhase.Weakening)
            {
                SealSystem.MarkWeakeningStart(WorldAge);
            }

            if (newPhase != EraPhase.Weakening)
            {
                SealSystem.ClearWeakeningStart();
            }

            PublishPhaseChanged(prev, newPhase, reason);

            return true;
        }

        private void UpdateSimulatedDemonHealth()
        {
            var deltaYears = WorldAge - _lastDemonHealthWorldAge;
            if (deltaYears <= 0) return;

            _lastDemonHealthWorldAge = WorldAge;

            var decayPerYear = 0f;
            switch (CurrentPhase)
            {
                case EraPhase.Awakening:
                    if (DemonHealthPercent > 30f) DemonHealthPercent = 30f;
                    return;

                case EraPhase.Invasion:
                    decayPerYear = 0.6f;
                    break;

                case EraPhase.Peak:
                    decayPerYear = 1.2f;
                    break;

                case EraPhase.Weakening:
                    decayPerYear = 2.0f;
                    break;

                default:
                    return;
            }

            DemonHealthPercent -= (float)deltaYears * decayPerYear;
            if (DemonHealthPercent < 0f) DemonHealthPercent = 0f;
            if (DemonHealthPercent > 100f) DemonHealthPercent = 100f;
        }

        private void PublishPhaseChanged(EraPhase prev, EraPhase next, string reason)
        {
            try
            {
                EventBus.Publish(new PhaseChangedEvent
                {
                    PreviousPhase = prev,
                    NewPhase = next,
                    WorldTime = WorldAge,
                    TriggerReason = reason
                });
            }
            catch
            {
            }

            try
            {
                OnPhaseChanged?.Invoke(prev, next);
            }
            catch
            {
            }

            if (next == EraPhase.Omen)
            {
                try
                {
                    NarrativeDispatcher.NotifyOmenEntered();
                }
                catch
                {
                }
            }
        }

        private void HandleResealed()
        {
            var summary = new CycleSummary
            {
                CycleNumber = CycleCount + 1,
                EndPhase = EraPhase.Resealed,
                WorldTime = WorldAge,
                KeyEvents = new string[0]
            };

            History.Add(summary);
            CycleCount++;

            try
            {
                EventBus.Publish(new CycleCompletedEvent
                {
                    CycleNumber = CycleCount,
                    Summary = summary
                });
            }
            catch
            {
            }

            try
            {
                OnCycleCompleted?.Invoke(CycleCount);
            }
            catch
            {
            }
        }

        private void PickPhaseDurations(ModConfig cfg)
        {
            var omenMin = 20;
            var omenMax = 50;
            var awakeMin = 10;
            var awakeMax = 30;

            if (cfg != null && cfg.cycle != null && cfg.cycle.phases != null)
            {
                if (cfg.cycle.phases.omen_duration != null)
                {
                    omenMin = cfg.cycle.phases.omen_duration.min;
                    omenMax = cfg.cycle.phases.omen_duration.max;
                }

                if (cfg.cycle.phases.awakening_duration != null)
                {
                    awakeMin = cfg.cycle.phases.awakening_duration.min;
                    awakeMax = cfg.cycle.phases.awakening_duration.max;
                }
            }

            OmenTargetYears = NextRange(omenMin, omenMax);
            AwakeningTargetYears = NextRange(awakeMin, awakeMax);
        }

        private int NextRange(int min, int max)
        {
            if (max < min) max = min;
            if (max == min) return min;
            return _rng.Next(min, max + 1);
        }

        public CycleData GetSaveData()
        {
            return new CycleData
            {
                CycleCount = CycleCount,
                CurrentPhase = CurrentPhase,
                SealStrength = SealSystem.SealStrength,
                PhaseStartWorldAge = PhaseStartWorldAge,
                OmenTargetYears = OmenTargetYears,
                AwakeningTargetYears = AwakeningTargetYears,
                DemonHealthPercent = DemonHealthPercent
            };
        }

        public void LoadSaveData(CycleData data, ModConfig cfg)
        {
            if (data == null)
            {
                Initialize(cfg);
                return;
            }

            CycleCount = data.CycleCount;
            CurrentPhase = data.CurrentPhase;
            PhaseStartWorldAge = data.PhaseStartWorldAge;
            OmenTargetYears = data.OmenTargetYears;
            AwakeningTargetYears = data.AwakeningTargetYears;
            DemonHealthPercent = data.DemonHealthPercent;

            WorldAge = WorldCompat.GetWorldAge();
            SealSystem.Reset(cfg, WorldAge);
            SealSystem.SetSealStrength(data.SealStrength);

            _lastDemonHealthWorldAge = WorldAge;

            if (CurrentPhase == EraPhase.Sealed)
            {
                ProsperityTracker.Enable();
            }
            else
            {
                ProsperityTracker.Disable();
            }
        }

        public void LoadHistory(CycleSummary[] arr)
        {
            History.LoadFromArray(arr);
        }

        public CycleSummary[] ExportHistory()
        {
            return History.ToArray();
        }

        public float GetDemonStrengthMultiplier(ModConfig cfg)
        {
            var cycleMultiplier = 0.25f;
            var min = 0.6f;
            var max = 3.0f;

            if (cfg != null && cfg.demon_lord != null && cfg.demon_lord.growth != null)
            {
                cycleMultiplier = cfg.demon_lord.growth.cycle_multiplier;
                min = cfg.demon_lord.growth.strength_min;
                max = cfg.demon_lord.growth.strength_max;
            }

            if (min <= 0f) min = 0.6f;
            if (max < min) max = min;

            var multiplier = 1f + CycleCount * cycleMultiplier;
            if (multiplier < min) multiplier = min;
            if (multiplier > max) multiplier = max;
            return multiplier;
        }

        public void ForcePhase(EraPhase phase)
        {
            var prev = CurrentPhase;
            CurrentPhase = phase;
            PhaseStartWorldAge = WorldAge;
            PublishPhaseChanged(prev, CurrentPhase, "调试强制切换阶段");
        }

        public void ForceCycleCount(int count)
        {
            if (count < 0) count = 0;
            if (count > 999) count = 999;
            CycleCount = count;
        }

        public void ForceSealStrength(float strength)
        {
            SealSystem.SetSealStrength(strength);
        }

        public float SealStrength => SealSystem.SealStrength;

        public void ForceNextPhase()
        {
            var next = GetNextPhase(CurrentPhase);
            ForcePhase(next);
        }

        public void ForceCompleteCycle()
        {
            ForcePhase(EraPhase.Resealed);
            HandleResealed();
            ForcePhase(EraPhase.Sealed);
        }

        public void ResetSealStrength()
        {
            SealSystem.Reset(_lastConfig, WorldAge);
        }

        private static EraPhase GetNextPhase(EraPhase current)
        {
            switch (current)
            {
                case EraPhase.Sealed: return EraPhase.Omen;
                case EraPhase.Omen: return EraPhase.Awakening;
                case EraPhase.Awakening: return EraPhase.Invasion;
                case EraPhase.Invasion: return EraPhase.Peak;
                case EraPhase.Peak: return EraPhase.Weakening;
                case EraPhase.Weakening: return EraPhase.Resealed;
                case EraPhase.Resealed: return EraPhase.Sealed;
                default: return EraPhase.Sealed;
            }
        }
    }
}
