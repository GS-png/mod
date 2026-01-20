using System;
using System.Collections.Generic;
using EraWheel.Config;
using EraWheel.Data;

namespace EraWheel.Core
{
    public class LegacySystem
    {
        private readonly Dictionary<string, int> _stacks = new Dictionary<string, int>(StringComparer.Ordinal);
        private readonly Random _rng = new Random();

        private bool _bound;
        private ModConfig _lastConfig;

        private int _cycleStartCities = -1;
        private int _cycleStartHeroes = -1;

        public void Initialize(ModConfig cfg)
        {
            _lastConfig = cfg;
            LegacyTraitFactory.EnsureRegistered();
            BindEvents();
        }

        public void UpdateConfig(ModConfig cfg)
        {
            if (cfg != null) _lastConfig = cfg;
        }

        private void BindEvents()
        {
            if (_bound) return;
            _bound = true;

            EventBus.Subscribe<PhaseChangedEvent>(OnPhaseChanged);
            EventBus.Subscribe<CycleCompletedEvent>(OnCycleCompleted);
        }

        private void OnPhaseChanged(PhaseChangedEvent evt)
        {
            if (evt.NewPhase == EraPhase.Sealed)
            {
                _cycleStartCities = WorldCompat.TryGetCityCount();
                _cycleStartHeroes = WorldCompat.TryGetHeroCount();
            }
        }

        private void OnCycleCompleted(CycleCompletedEvent evt)
        {
            try
            {
                GrantLegacies(evt.CycleNumber);
            }
            catch
            {
            }
        }

        private void GrantLegacies(int cycleNumber)
        {
            var cfg = _lastConfig;

            var maxStacks = 5;
            if (cfg != null && cfg.legacy != null)
            {
                maxStacks = cfg.legacy.max_stacks;
            }
            if (maxStacks < 1) maxStacks = 1;

            var positive = new[] { "legacy_warrior", "legacy_armor", "legacy_scholar", "legacy_hero" };
            var picked = positive[_rng.Next(0, positive.Length)];

            AddStack(picked, 1, maxStacks);

            if (ShouldGrantCurse(cfg))
            {
                AddStack("legacy_curse", 1, maxStacks);
            }

            Log.Info("[EraWheel] Legacy granted at cycle=" + cycleNumber + ", totalKeys=" + _stacks.Count);
        }

        private bool ShouldGrantCurse(ModConfig cfg)
        {
            var endCities = WorldCompat.TryGetCityCount();
            var endHeroes = WorldCompat.TryGetHeroCount();

            var startCities = _cycleStartCities;
            var startHeroes = _cycleStartHeroes;

            if (startCities < 0) startCities = endCities;
            if (startHeroes < 0) startHeroes = endHeroes;

            var lostCities = 0;
            if (startCities > 0 && endCities >= 0)
            {
                lostCities = startCities - endCities;
                if (lostCities < 0) lostCities = 0;
            }

            var lostHeroes = 0;
            if (startHeroes >= 0 && endHeroes >= 0)
            {
                lostHeroes = startHeroes - endHeroes;
                if (lostHeroes < 0) lostHeroes = 0;
            }

            var cityLossPercent = startCities > 0 ? (float)lostCities / startCities : 0f;

            var cityLossThreshold = 0.5f;
            var heroDeathsThreshold = 3;

            if (cfg != null && cfg.legacy != null && cfg.legacy.curse_threshold != null)
            {
                cityLossThreshold = cfg.legacy.curse_threshold.city_loss_percent;
                heroDeathsThreshold = cfg.legacy.curse_threshold.hero_deaths;
            }

            if (heroDeathsThreshold < 0) heroDeathsThreshold = 0;

            return cityLossPercent >= cityLossThreshold || lostHeroes >= heroDeathsThreshold;
        }

        private void AddStack(string key, int delta, int maxStacks)
        {
            if (string.IsNullOrEmpty(key)) return;
            if (delta == 0) return;

            if (!_stacks.TryGetValue(key, out var v)) v = 0;
            v += delta;
            if (v < 0) v = 0;
            if (v > maxStacks) v = maxStacks;
            _stacks[key] = v;
        }

        public int GetStack(string key)
        {
            if (string.IsNullOrEmpty(key)) return 0;
            return _stacks.TryGetValue(key, out var v) ? v : 0;
        }

        public void LoadFromSave(LegacyData data)
        {
            _stacks.Clear();
            if (data == null || data.Keys == null || data.Values == null) return;

            var n = Math.Min(data.Keys.Length, data.Values.Length);
            for (var i = 0; i < n; i++)
            {
                var k = data.Keys[i];
                if (string.IsNullOrEmpty(k)) continue;
                _stacks[k] = data.Values[i];
            }
        }

        public LegacyData ExportToSave()
        {
            var d = new LegacyData();
            foreach (var kv in _stacks)
            {
                d.Set(kv.Key, kv.Value);
            }
            return d;
        }
    }
}
