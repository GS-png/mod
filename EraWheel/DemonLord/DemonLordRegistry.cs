using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using EraWheel.Config;
using EraWheel.Core;
using EraWheel.Data;

namespace EraWheel.DemonLord
{
    public class DemonLordRegistry
    {
        private readonly Dictionary<string, DemonLordBase> _lords = new Dictionary<string, DemonLordBase>(StringComparer.Ordinal);
        private readonly Random _rng = new Random();
        private readonly SpawnSystem _spawn = new SpawnSystem();
        private long _lastRebindWorldAge = -1;

        private ModConfig _lastConfig;

        public DemonLordBase Active { get; private set; }

        public DemonLordBase ActiveDemonLord => Active;

        public IReadOnlyList<DemonLordBase> GetAllLords()
        {
            var list = new List<DemonLordBase>(_lords.Count);
            foreach (var kv in _lords)
            {
                if (kv.Value != null) list.Add(kv.Value);
            }
            return list;
        }

        public DemonLordBase GetLord(string id)
        {
            if (string.IsNullOrEmpty(id)) return null;
            return _lords.TryGetValue(id, out var l) ? l : null;
        }

        public void Initialize(ModConfig cfg)
        {
            _lastConfig = cfg;
            _lords.Clear();
            var all = DemonLordFactory.CreateAll();
            for (var i = 0; i < all.Length; i++)
            {
                var l = all[i];
                if (l == null) continue;
                _lords[l.Id] = l;
            }

            ApplyEnabledFlags(cfg);
            ApplyStatOverrides(cfg);
        }

        public void ApplyEnabledFlags(ModConfig cfg)
        {
            if (cfg != null) _lastConfig = cfg;
            if (cfg == null || cfg.demon_lord == null || cfg.demon_lord.enabled_lords == null)
            {
                return;
            }

            foreach (var kv in _lords)
            {
                var id = kv.Key;
                var enabled = DemonLordConfigHelper.IsEnabled(cfg.demon_lord.enabled_lords, id);
                kv.Value.SetEnabled(enabled);
            }
        }

        public void ApplyStatOverrides(ModConfig cfg)
        {
            if (cfg != null) _lastConfig = cfg;

#if !ERAWHEEL_SELFTEST
            var library = AssetManager.actor_library;
            if (library == null) return;

            foreach (var kv in _lords)
            {
                var lord = kv.Value;
                if (lord == null || string.IsNullOrEmpty(lord.Id)) continue;
                if (!library.has(lord.Id)) continue;

                var asset = library.get(lord.Id);
                var stats = asset != null ? asset.base_stats : null;
                if (stats == null || !stats.hasStat("health")) continue;

                var baseHealth = stats.get("health");
                lord.OverrideBaseHealth(baseHealth);
            }
#endif
        }

        public void Update(ModConfig cfg, CycleManager cycle)
        {
            if (cfg != null) _lastConfig = cfg;
            ApplyEnabledFlags(cfg);

            if (Active != null && !Active.Enabled)
            {
                Active.ClearActor();
                Active = null;
                _lastRebindWorldAge = -1;

                if (cycle != null)
                {
                    cycle.ClearExternalDemonHealth();
                    cycle.SetDemonSpawned(false);
                }
            }

            if (cycle == null) return;

            if (Active != null)
            {
                TryRebindActiveActor(cycle);

                cycle.SetDemonSpawned(Active.HasActor);

                if (Active.TryGetActorHealthPercent(out var actorPercent))
                {
                    cycle.SetExternalDemonHealthPercent(actorPercent);
                }
                else
                {
                    cycle.ClearExternalDemonHealth();
                }

                Active.SetHealthPercent(cycle.DemonHealthPercent);
                Active.ApplyGrowth(DemonGrowthCalculator.ComputeStrengthMultiplier(cfg, cycle.CycleCount));
                var s = DemonLordStateMachine.ComputeState(Active.Enabled, cycle.CurrentPhase, Active.CurrentHealthPercent);
                Active.UpdateStateFromSystem(s);
                Active.Update(cfg, cycle.CurrentPhase);
            }
            else
            {
                cycle.ClearExternalDemonHealth();
                cycle.SetDemonSpawned(false);
            }

            if (cycle.CurrentPhase == EraPhase.Awakening && Active == null)
            {
                SelectActive(cfg, cycle.CycleCount);
            }

            if (cycle.CurrentPhase == EraPhase.Sealed && Active != null)
            {
                Active.ResetForNewCycle();
                Active = null;
                _lastRebindWorldAge = -1;
            }
        }

        public void OnPhaseChanged(EraPhase prev, EraPhase next, int cycleCount)
        {
            if (Active != null)
            {
                Active.OnPhaseChanged(prev, next);
            }

            if (next == EraPhase.Awakening && Active == null)
            {
                SelectActive(_lastConfig, cycleCount);
            }
        }

        public void ForceSetActive(string id)
        {
            if (string.IsNullOrEmpty(id)) return;
            if (_lords.TryGetValue(id, out var l) && l != null && l.Enabled)
            {
                Active = l;
            }
        }

        public void ForceState(DemonLordState state)
        {
            if (Active != null)
            {
                Active.ForceState(state);
            }
        }

        private void SelectActive(ModConfig cfg, int cycleCount)
        {
            var candidates = new List<DemonLordBase>();
            foreach (var kv in _lords)
            {
                var l = kv.Value;
                if (l == null) continue;

                if (cfg != null)
                {
                    l.SetEnabled(DemonLordConfigHelper.IsEnabled(cfg.demon_lord?.enabled_lords, l.Id));
                }

                if (!l.Enabled) continue;
                candidates.Add(l);
            }

            if (candidates.Count == 0)
            {
                Log.Info("[EraWheel] No demon lord is enabled. Please check config demon_lord.enabled_lords.");
                Active = null;
                return;
            }

            var picked = candidates[_rng.Next(0, candidates.Count)];
            Active = picked;
            Active.ClearForcedState();
            Active.UpdateStateFromSystem(DemonLordState.Awakening);
            Active.ApplyGrowth(DemonGrowthCalculator.ComputeStrengthMultiplier(cfg, cycleCount));
            Active.OnAwaken(cycleCount);
        }

        private void TryRebindActiveActor(CycleManager cycle)
        {
            if (Active == null || Active.HasActor || cycle == null) return;

            var phase = cycle.CurrentPhase;
            if (phase == EraPhase.Sealed || phase == EraPhase.Omen) return;

            var worldAge = cycle.WorldAge;
            if (_lastRebindWorldAge == worldAge) return;
            _lastRebindWorldAge = worldAge;

            var actor = _spawn.TryFindActorByAssetId(Active.Id);
            if (actor != null)
            {
                Active.BindActor(actor);
            }
        }

        public DemonLordSaveData[] GetSaveData()
        {
            var arr = new DemonLordSaveData[_lords.Count];
            var i = 0;
            foreach (var kv in _lords)
            {
                var l = kv.Value;
                arr[i] = new DemonLordSaveData
                {
                    Id = kv.Key,
                    Enabled = l != null && l.Enabled,
                    State = l != null ? l.State : DemonLordState.Sealed,
                    CurrentHealth = l != null ? l.CurrentHealthPercent : 0f,
                    KillCount = 0,
                    ActiveGenerals = new string[0]
                };
                i++;
            }
            return arr;
        }

        public void LoadSaveData(DemonLordSaveData[] data, ModConfig cfg)
        {
            Initialize(cfg);

            if (data == null) return;

            DemonLordBase activeCandidate = null;
            for (var i = 0; i < data.Length; i++)
            {
                var d = data[i];
                if (d == null || string.IsNullOrEmpty(d.Id)) continue;
                if (!_lords.TryGetValue(d.Id, out var l) || l == null) continue;

                l.SetEnabled(d.Enabled);
                l.SetHealthPercent(d.CurrentHealth);
                l.ClearForcedState();
                l.UpdateStateFromSystem(d.State);

                if (activeCandidate == null && d.State != DemonLordState.Sealed && d.State != DemonLordState.Disabled)
                {
                    activeCandidate = l;
                }
            }

            Active = activeCandidate;
        }
    }
}
