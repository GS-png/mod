using System;
using System.Collections.Generic;
using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.DemonLord
{
    public enum MultiLordMode
    {
        Independent,
        Alliance,
        CivilWar,
        AutoJudge
    }

    public class MultiLordSystem
    {
        private readonly List<DemonLordBase> _activeLords = new List<DemonLordBase>();
        private readonly Random _rng = new Random();
        private int _lastCycle = -1;
        private MultiLordMode _mode = MultiLordMode.Independent;

        public MultiLordMode Mode => _mode;
        public IReadOnlyList<DemonLordBase> ActiveLords => _activeLords;

        public void Initialize(ModConfig cfg)
        {
            _activeLords.Clear();
            _lastCycle = -1;
            _mode = ResolveMode(cfg);
        }

        public void Update(ModConfig cfg, CycleManager cycle, DemonLordRegistry registry)
        {
            if (cfg == null || cycle == null || registry == null)
            {
                return;
            }

            if (cfg.expansion?.multi_lord?.enabled != true)
            {
                if (_activeLords.Count > 0)
                {
                    _activeLords.Clear();
                }

                _mode = MultiLordMode.Independent;
                return;
            }

            var mode = ResolveMode(cfg);
            if (mode != _mode)
            {
                _mode = mode;
                Log.Info("[MultiLordSystem] 模式切换为: " + _mode);
            }

            if (cycle.CurrentPhase == EraPhase.Awakening && _lastCycle != cycle.CycleCount)
            {
                SelectActiveLords(cfg, registry);
                _lastCycle = cycle.CycleCount;
            }

            if (cycle.CurrentPhase == EraPhase.Sealed && _activeLords.Count > 0)
            {
                _activeLords.Clear();
            }
        }

        private void SelectActiveLords(ModConfig cfg, DemonLordRegistry registry)
        {
            _activeLords.Clear();

            var candidates = new List<DemonLordBase>();
            var all = registry.GetAllLords();
            for (var i = 0; i < all.Count; i++)
            {
                var lord = all[i];
                if (lord == null || !lord.Enabled) continue;
                candidates.Add(lord);
            }

            if (candidates.Count == 0)
            {
                Log.Info("[MultiLordSystem] 没有可用的魔王");
                return;
            }

            var min = cfg.expansion?.multi_lord?.min_awaken_count ?? 2;
            var max = cfg.expansion?.multi_lord?.max_awaken_count ?? 5;
            var desired = cfg.demon_lord != null ? cfg.demon_lord.random_count : min;

            if (desired < min) desired = min;
            if (desired > max) desired = max;
            if (desired > candidates.Count) desired = candidates.Count;

            for (var i = 0; i < desired; i++)
            {
                var index = _rng.Next(0, candidates.Count);
                var picked = candidates[index];
                candidates.RemoveAt(index);
                _activeLords.Add(picked);
            }

            if (_activeLords.Count > 0)
            {
                var ids = new string[_activeLords.Count];
                for (var i = 0; i < _activeLords.Count; i++)
                {
                    ids[i] = _activeLords[i].Id;
                }

                Log.Info("[MultiLordSystem] 本轮多魔王选择: " + string.Join(",", ids));
            }
        }

        private MultiLordMode ResolveMode(ModConfig cfg)
        {
            var mode = cfg?.demon_lord?.multi_lord_mode;
            if (string.IsNullOrEmpty(mode)) return MultiLordMode.Independent;

            switch (mode)
            {
                case "alliance":
                    return MultiLordMode.Alliance;
                case "civil_war":
                    return MultiLordMode.CivilWar;
                case "auto_judge":
                    return MultiLordMode.AutoJudge;
                default:
                    return MultiLordMode.Independent;
            }
        }
    }
}
