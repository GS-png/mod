using System;
using System.Collections.Generic;
using EraWheel.Config;
using EraWheel.Core;
using EraWheel.Data;

namespace EraWheel.DemonLord
{
    public class GeneralSystem
    {
        private readonly List<GeneralRuntime> _generals = new List<GeneralRuntime>();
        private readonly Random _rng = new Random();

        private string _activeDemonId;
        private long _lastWorldAge = -1;

        public GeneralRuntime[] Generals
        {
            get { return _generals.ToArray(); }
        }

        public void Reset()
        {
            _generals.Clear();
            _activeDemonId = null;
            _lastWorldAge = -1;
        }

        public void Update(ModConfig cfg, CycleManager cycle, DemonLordRegistry demons)
        {
            if (cycle == null || demons == null) return;

            var worldAge = cycle.WorldAge;
            if (_lastWorldAge < 0) _lastWorldAge = worldAge;
            var deltaYears = worldAge - _lastWorldAge;
            if (deltaYears < 0) deltaYears = 0;
            _lastWorldAge = worldAge;

            var active = demons.Active;
            if (active == null)
            {
                Reset();
                return;
            }

            if (!string.Equals(_activeDemonId, active.Id, StringComparison.Ordinal))
            {
                _activeDemonId = active.Id;
                InitializeForDemon(cfg, active.Id, cycle.CycleCount);
            }

            UpdateRespawns(cfg, cycle, deltaYears);

            var desiredActive = GetDesiredActiveCount(cfg, cycle);
            EnsureActiveSlots(cfg, cycle, desiredActive);

            TryBetrayals(cfg, cycle);
        }

        private void InitializeForDemon(ModConfig cfg, string demonId, int cycleCount)
        {
            _generals.Clear();
            var templates = GeneralFactory.CreateTemplates(demonId);
            for (var i = 0; i < templates.Length; i++)
            {
                var t = templates[i];
                if (t == null) continue;
                if (cycleCount < t.MinCycle) continue;

                _generals.Add(new GeneralRuntime
                {
                    DemonLordId = demonId,
                    Id = t.Id,
                    Role = t.Role,
                    State = GeneralState.Inactive,
                    DefeatCount = 0,
                    NextRespawnWorldAge = -1
                });
            }
        }

        private int GetDesiredActiveCount(ModConfig cfg, CycleManager cycle)
        {
            if (cfg == null || cfg.demon_lord == null || cfg.demon_lord.generals == null) return 0;

            var g = cfg.demon_lord.generals;
            var count = g.initial_count + cycle.CycleCount * g.per_cycle_increase;
            if (count < 0) count = 0;
            if (count > g.max_count) count = g.max_count;

            if (cycle.CurrentPhase == EraPhase.Peak)
            {
                count = g.max_count;
            }

            if (count < 0) count = 0;
            return count;
        }

        private void EnsureActiveSlots(ModConfig cfg, CycleManager cycle, int desiredActive)
        {
            if (desiredActive <= 0) return;

            var canActivate = cycle.CurrentPhase == EraPhase.Invasion || cycle.CurrentPhase == EraPhase.Peak;
            if (!canActivate) return;

            var activeCount = 0;
            for (var i = 0; i < _generals.Count; i++)
            {
                if (_generals[i] != null && _generals[i].State == GeneralState.Active) activeCount++;
            }

            if (activeCount >= desiredActive) return;

            for (var i = 0; i < _generals.Count && activeCount < desiredActive; i++)
            {
                var gr = _generals[i];
                if (gr == null) continue;
                if (gr.State != GeneralState.Inactive) continue;

                gr.State = GeneralState.Active;
                _generals[i] = gr;
                activeCount++;
            }
        }

        private void UpdateRespawns(ModConfig cfg, CycleManager cycle, long deltaYears)
        {
            if (deltaYears <= 0) return;

            var demonActive = cycle.CurrentPhase == EraPhase.Invasion || cycle.CurrentPhase == EraPhase.Peak || cycle.CurrentPhase == EraPhase.Weakening;
            if (!demonActive) return;

            for (var i = 0; i < _generals.Count; i++)
            {
                var g = _generals[i];
                if (g == null) continue;
                if (g.State != GeneralState.Defeated) continue;

                if (g.NextRespawnWorldAge >= 0 && cycle.WorldAge >= g.NextRespawnWorldAge)
                {
                    g.State = GeneralState.Active;
                    g.NextRespawnWorldAge = -1;
                    _generals[i] = g;
                }
            }
        }

        public void ReportGeneralDefeated(string generalId, long worldAge)
        {
            if (string.IsNullOrEmpty(generalId)) return;

            for (var i = 0; i < _generals.Count; i++)
            {
                var g = _generals[i];
                if (g == null) continue;
                if (!string.Equals(g.Id, generalId, StringComparison.Ordinal)) continue;

                if (g.State == GeneralState.Betrayed) return;

                g.DefeatCount++;
                g.State = GeneralState.Defeated;
                g.NextRespawnWorldAge = worldAge + 20;
                _generals[i] = g;
                return;
            }
        }

        private void TryBetrayals(ModConfig cfg, CycleManager cycle)
        {
            if (cfg == null || cfg.demon_lord == null || cfg.demon_lord.generals == null) return;

            if (cycle.CurrentPhase != EraPhase.Weakening) return;

            var chance = cfg.demon_lord.generals.betrayal_base_chance;
            if (WorldCompat.MockEnabled)
            {
                chance = 1f;
            }
            if (chance <= 0f) return;

            var threshold = Math.Max(1, cfg.demon_lord.generals.betrayal_defeat_threshold);

            for (var i = 0; i < _generals.Count; i++)
            {
                var g = _generals[i];
                if (g == null) continue;
                if (g.State == GeneralState.Betrayed) continue;
                if (g.DefeatCount < threshold) continue;

                var roll = _rng.NextDouble();
                if (roll > chance) continue;

                g.State = GeneralState.Betrayed;
                _generals[i] = g;

                try
                {
                    EventBus.Publish(new GeneralBetrayedEvent
                    {
                        DemonLordId = g.DemonLordId,
                        GeneralId = g.Id,
                        DefeatCount = g.DefeatCount,
                        WorldTime = cycle.WorldAge
                    });
                }
                catch
                {
                }

                Log.Info("[EraWheel] General betrayed: demon=" + g.DemonLordId + " general=" + g.Id + " defeats=" + g.DefeatCount);
            }
        }

        public GeneralSaveData[] ExportToSave()
        {
            var arr = new GeneralSaveData[_generals.Count];
            for (var i = 0; i < _generals.Count; i++)
            {
                var g = _generals[i];
                arr[i] = g == null ? new GeneralSaveData() : new GeneralSaveData
                {
                    DemonLordId = g.DemonLordId,
                    Id = g.Id,
                    Role = g.Role,
                    State = g.State,
                    DefeatCount = g.DefeatCount,
                    NextRespawnWorldAge = g.NextRespawnWorldAge
                };
            }
            return arr;
        }

        public void LoadFromSave(GeneralSaveData[] arr)
        {
            _generals.Clear();
            if (arr == null) return;

            for (var i = 0; i < arr.Length; i++)
            {
                var s = arr[i];
                if (s == null || string.IsNullOrEmpty(s.Id)) continue;

                _generals.Add(new GeneralRuntime
                {
                    DemonLordId = s.DemonLordId,
                    Id = s.Id,
                    Role = s.Role,
                    State = s.State,
                    DefeatCount = s.DefeatCount,
                    NextRespawnWorldAge = s.NextRespawnWorldAge
                });
            }

            if (_generals.Count > 0)
            {
                _activeDemonId = _generals[0].DemonLordId;
            }
        }
    }
}
