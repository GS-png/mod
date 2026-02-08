using System;
using System.Collections.Generic;
using EraWheel.Config;
using EraWheel.Data;

namespace EraWheel.Core
{
    public class LegacySystem
    {
        private static readonly string[] MilitaryLegacies = { "legacy_warrior", "legacy_armor" };
        private static readonly string[] EconomicLegacies = { "legacy_harvest" };
        private static readonly string[] TechLegacies = { "legacy_scholar" };
        private static readonly string[] LegendaryLegacies = { "legacy_hero" };

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
            CaptureCycleStartSnapshot();
        }

        public void UpdateConfig(ModConfig cfg)
        {
            if (cfg != null) _lastConfig = cfg;
            ApplyLegacyEffects(_lastConfig);
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
                CaptureCycleStartSnapshot();
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
            var maxStacks = GetMaxStacks(cfg);

            GrantCategory(MilitaryLegacies, maxStacks);
            GrantCategory(EconomicLegacies, maxStacks);
            GrantCategory(TechLegacies, maxStacks);
            GrantCategory(LegendaryLegacies, maxStacks);

            if (ShouldGrantCurse(cfg))
            {
                AddStack("legacy_curse", 1, maxStacks);
            }

            ApplyLegacyEffects(cfg);

            Log.Info("[EraWheel] Legacy granted at cycle=" + cycleNumber + ", totalKeys=" + _stacks.Count);
        }

        private void GrantCategory(string[] options, int maxStacks)
        {
            if (options == null || options.Length == 0) return;
            var pick = options[_rng.Next(0, options.Length)];
            AddStack(pick, 1, maxStacks);
        }

        private static int GetMaxStacks(ModConfig cfg)
        {
            var maxStacks = 5;
            if (cfg != null && cfg.legacy != null)
            {
                maxStacks = cfg.legacy.max_stacks;
            }

            if (maxStacks < 1) maxStacks = 1;
            return maxStacks;
        }

        private void ApplyLegacyEffects(ModConfig cfg)
        {
#if !ERAWHEEL_SELFTEST
            LegacyTraitFactory.EnsureRegistered();
            if (_stacks.Count == 0) return;

            var traitLibrary = AssetManager.traits;
            var actorLibrary = AssetManager.actor_library;
            if (traitLibrary == null || actorLibrary == null || actorLibrary.list == null) return;

            var activeTraits = new List<string>();
            var diminish = GetDiminish(cfg);

            for (var i = 0; i < LegacyTraitFactory.LegacyTraitSpecs.Length; i++)
            {
                var spec = LegacyTraitFactory.LegacyTraitSpecs[i];
                var stacks = GetStack(spec.Id);
                if (stacks <= 0) continue;

                var trait = traitLibrary.get(spec.Id);
                if (trait == null) continue;

                var factor = SumDiminish(stacks, diminish);
                var value = spec.BaseValue * factor;

                if (trait.base_stats == null)
                {
                    trait.base_stats = new BaseStats();
                }

                if (!string.IsNullOrEmpty(spec.StatId))
                {
                    trait.base_stats[spec.StatId] = value;
                }

                activeTraits.Add(spec.Id);
            }

            if (activeTraits.Count == 0) return;

            ApplyTraitsToAssets(actorLibrary, activeTraits);
            ApplyTraitsToUnits(activeTraits);
#endif
        }

#if !ERAWHEEL_SELFTEST
        private static float[] GetDiminish(ModConfig cfg)
        {
            if (cfg != null && cfg.legacy != null && cfg.legacy.stack_diminish != null && cfg.legacy.stack_diminish.Length > 0)
            {
                return cfg.legacy.stack_diminish;
            }

            return new[] { 1f };
        }

        private static float SumDiminish(int stacks, float[] factors)
        {
            if (stacks <= 0) return 0f;
            if (factors == null || factors.Length == 0) return stacks;

            var sum = 0f;
            var last = factors[factors.Length - 1];

            for (var i = 0; i < stacks; i++)
            {
                sum += i < factors.Length ? factors[i] : last;
            }

            return sum;
        }

        private static void ApplyTraitsToAssets(ActorAssetLibrary actorLibrary, List<string> traitIds)
        {
            for (var i = 0; i < actorLibrary.list.Count; i++)
            {
                var asset = actorLibrary.list[i];
                if (asset == null) continue;
                if (!asset.civ && !asset.auto_civ) continue;

                for (var t = 0; t < traitIds.Count; t++)
                {
                    var traitId = traitIds[t];
                    if (asset.traits == null)
                    {
                        asset.traits = new List<string>();
                    }
                    if (!asset.traits.Contains(traitId))
                    {
                        asset.addTrait(traitId);
                    }
                }
            }
        }

        private static void ApplyTraitsToUnits(List<string> traitIds)
        {
            var mapBox = MapBox.instance;
            if (mapBox == null || mapBox.units == null) return;

            foreach (var actor in mapBox.units)
            {
                if (actor == null) continue;
                if (!actor.hasKingdom()) continue;
                if (!actor.isKingdomCiv()) continue;

                for (var t = 0; t < traitIds.Count; t++)
                {
                    var traitId = traitIds[t];
                    if (!actor.hasTrait(traitId))
                    {
                        actor.addTrait(traitId);
                    }
                }

                actor.setStatsDirty();
            }
        }
#endif

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

        private void CaptureCycleStartSnapshot()
        {
            var cities = WorldCompat.TryGetCityCount();
            var heroes = WorldCompat.TryGetHeroCount();

            _cycleStartCities = cities >= 0 ? cities : _cycleStartCities;
            _cycleStartHeroes = heroes >= 0 ? heroes : _cycleStartHeroes;
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

            ApplyLegacyEffects(_lastConfig);
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
