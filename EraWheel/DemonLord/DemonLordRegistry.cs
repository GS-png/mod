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
                var enabled = IsEnabledByConfig(cfg, id);
                kv.Value.SetEnabled(enabled);
            }
        }

        public void Update(ModConfig cfg, CycleManager cycle)
        {
            if (cfg != null) _lastConfig = cfg;
            ApplyEnabledFlags(cfg);

            if (cycle == null) return;

            if (Active != null)
            {
                Active.SetHealthPercent(cycle.DemonHealthPercent);
                var s = DemonLordStateMachine.ComputeState(Active.Enabled, cycle.CurrentPhase, Active.CurrentHealthPercent);
                Active.ForceState(s);
                Active.Update(cfg, cycle.CurrentPhase);
            }

            if (cycle.CurrentPhase == EraPhase.Awakening && Active == null)
            {
                SelectActive(cfg, cycle.CycleCount);
            }

            if (cycle.CurrentPhase == EraPhase.Sealed && Active != null)
            {
                Active.ResetForNewCycle();
                Active = null;
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
                    l.SetEnabled(IsEnabledByConfig(cfg, l.Id));
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
            Active.OnSelectedForAwakening(cycleCount);
        }

        private static bool IsEnabledByConfig(ModConfig cfg, string id)
        {
            if (cfg == null || cfg.demon_lord == null || cfg.demon_lord.enabled_lords == null) return true;

            var e = cfg.demon_lord.enabled_lords;
            switch (id)
            {
                case "void_lord": return e.void_lord;
                case "plague_lord": return e.plague_lord;
                case "machine_lord": return e.machine_lord;
                case "time_lord": return e.time_lord;
                case "flame_lord": return e.flame_lord;
                case "abyss_lord": return e.abyss_lord;
                case "death_lord": return e.death_lord;
                case "soul_lord": return e.soul_lord;
                case "nature_lord": return e.nature_lord;
                case "judgment_lord": return e.judgment_lord;
                default: return true;
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

            for (var i = 0; i < data.Length; i++)
            {
                var d = data[i];
                if (d == null || string.IsNullOrEmpty(d.Id)) continue;
                if (!_lords.TryGetValue(d.Id, out var l) || l == null) continue;

                l.SetEnabled(d.Enabled);
                l.SetHealthPercent(d.CurrentHealth);
                l.ForceState(d.State);
            }
        }
    }
}
