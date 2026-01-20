using System;
using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.Civilization
{
    public class AllianceSystem
    {
        private bool _bound;
        private ModConfig _lastConfig;

        private long _lastWorldAge = -1;

        public AntiDemonAllianceState State { get; } = new AntiDemonAllianceState();

        public void Initialize(ModConfig cfg)
        {
            _lastConfig = cfg;
            BindEvents();

            if (State.CycleStartCities < 0)
            {
                State.CycleStartCities = WorldCompat.TryGetCityCount();
            }

            if (_lastWorldAge < 0)
            {
                _lastWorldAge = WorldCompat.GetWorldAge();
            }
        }

        private void BindEvents()
        {
            if (_bound) return;
            _bound = true;

            EventBus.Subscribe<PhaseChangedEvent>(OnPhaseChanged);
        }

        private void OnPhaseChanged(PhaseChangedEvent evt)
        {
            if (evt.NewPhase == EraPhase.Sealed)
            {
                State.Formed = false;
                State.FormWorldAge = 0;
                State.CouncilCount = 0;
                State.LastCouncilWorldAge = -1;
                State.SealProgress = 0f;

                State.CycleStartCities = WorldCompat.TryGetCityCount();
                _lastWorldAge = evt.WorldTime;
            }
        }

        public void Update(ModConfig cfg, CycleManager cycle)
        {
            if (cycle == null) return;
            if (cfg != null) _lastConfig = cfg;

            var worldAge = cycle.WorldAge;
            if (_lastWorldAge < 0) _lastWorldAge = worldAge;

            var deltaYears = worldAge - _lastWorldAge;
            if (deltaYears < 0) deltaYears = 0;
            _lastWorldAge = worldAge;

            if (!State.Formed)
            {
                TryAutoForm(cfg, cycle);
            }

            if (State.Formed)
            {
                TryCouncil(cfg, cycle);
                UpdateSealProgress(cfg, cycle, (int)deltaYears);
            }
        }

        private void TryAutoForm(ModConfig cfg, CycleManager cycle)
        {
            var phase = cycle.CurrentPhase;
            if (phase != EraPhase.Invasion && phase != EraPhase.Peak && phase != EraPhase.Weakening) return;

            var threshold = 0.2f;
            if (cfg != null && cfg.civilization != null && cfg.civilization.alliance != null)
            {
                threshold = cfg.civilization.alliance.auto_form_threshold;
            }

            if (threshold < 0f) threshold = 0f;
            if (threshold > 1f) threshold = 1f;

            var startCities = State.CycleStartCities;
            if (startCities <= 0) return;

            var currentCities = WorldCompat.TryGetCityCount();
            if (currentCities < 0) return;

            var destroyed = startCities - currentCities;
            if (destroyed < 0) destroyed = 0;

            var destroyedPercent = (float)destroyed / startCities;
            if (destroyedPercent < threshold) return;

            State.Formed = true;
            State.FormWorldAge = cycle.WorldAge;
            State.LastCouncilWorldAge = cycle.WorldAge;

            try
            {
                EventBus.Publish(new AllianceFormedEvent
                {
                    WorldTime = cycle.WorldAge,
                    DestroyedCityPercent = destroyedPercent
                });
            }
            catch
            {
            }

            Log.Info("[EraWheel] Alliance formed: destroyedCityPercent=" + destroyedPercent.ToString("0.00"));
        }

        private void TryCouncil(ModConfig cfg, CycleManager cycle)
        {
            var interval = 20;
            if (cfg != null && cfg.civilization != null && cfg.civilization.alliance != null)
            {
                interval = cfg.civilization.alliance.council_interval_years;
            }

            if (interval < 1) interval = 1;
            if (State.LastCouncilWorldAge < 0) State.LastCouncilWorldAge = cycle.WorldAge;

            var since = cycle.WorldAge - State.LastCouncilWorldAge;
            if (since < interval) return;

            State.LastCouncilWorldAge = cycle.WorldAge;
            State.CouncilCount++;

            try
            {
                EventBus.Publish(new AllianceCouncilEvent
                {
                    WorldTime = cycle.WorldAge,
                    CouncilIndex = State.CouncilCount
                });
            }
            catch
            {
            }

            Log.Info("[EraWheel] Alliance council held: #" + State.CouncilCount);
        }

        private void UpdateSealProgress(ModConfig cfg, CycleManager cycle, int deltaYears)
        {
            if (deltaYears <= 0) return;

            if (cycle.CurrentPhase != EraPhase.Weakening) return;

            var enabled = cfg != null && cfg.cycle != null && cfg.cycle.seal != null && cfg.cycle.seal.victory_conditions != null &&
                          cfg.cycle.seal.victory_conditions.alliance;
            if (!enabled) return;

            var before = State.SealProgress;
            State.SealProgress += 10f * deltaYears;
            if (State.SealProgress > 100f) State.SealProgress = 100f;

            if (Math.Abs(State.SealProgress - before) > 0.001f)
            {
                try
                {
                    EventBus.Publish(new AllianceSealProgressEvent
                    {
                        WorldTime = cycle.WorldAge,
                        Progress = State.SealProgress
                    });
                }
                catch
                {
                }
            }
        }

        public AllianceSaveData ExportToSave()
        {
            return new AllianceSaveData
            {
                Formed = State.Formed,
                FormWorldAge = State.FormWorldAge,
                CycleStartCities = State.CycleStartCities,
                CouncilCount = State.CouncilCount,
                LastCouncilWorldAge = State.LastCouncilWorldAge,
                SealProgress = State.SealProgress
            };
        }

        public void LoadFromSave(AllianceSaveData data)
        {
            if (data == null) return;

            State.Formed = data.Formed;
            State.FormWorldAge = data.FormWorldAge;
            State.CycleStartCities = data.CycleStartCities;
            State.CouncilCount = data.CouncilCount;
            State.LastCouncilWorldAge = data.LastCouncilWorldAge;
            State.SealProgress = data.SealProgress;
        }
    }
}
