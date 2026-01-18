using System;
using System.Collections.Generic;
using UnityEngine;
using EraOfWheel.Core;
using EraOfWheel.Core.Config;
using EraOfWheel.Cycle;
using EraOfWheel.UI;
using Logger = EraOfWheel.Core.Logger;

namespace EraOfWheel.DemonLords
{
    public class Omega : BaseDemonLord
    {
        public override string Id => "omega";
        public override string Name => "机械暴君·欧米茄";
        public override string Title => "齿轮与铁律";
        public override string Description => "以机械秩序重塑世界的暴君，擅长用‘强化’与‘失控’改造生灵";
        public override int UnlockCycle => 3;

        private OmegaConfig _config;
        private float _overclockRadius = 160f;
        private int _overclockMaxTargets = 50;
        private int _overclockIntervalYears = 18;
        private int _lastOverclockYear = int.MinValue;

        public Omega()
        {
            Stats.BaseHealth = 110000f;
            Stats.BaseDamage = 650f;
            Stats.BaseDefense = 650f;
            Stats.BaseSpeed = 7f;
            Stats.HealthGrowthPerCycle = 0.5f;
            Stats.DamageGrowthPerCycle = 0.25f;
        }

        public override void Initialize(int cycleCount)
        {
            base.Initialize(cycleCount);

            _config = ConfigManager.Instance?.Config?.demon_lords?.omega;
            if (_config != null)
            {
                ApplyConfigOverrides(_config.enabled, _config.unlock_cycle);
                _overclockRadius = Math.Max(10f, _config.overclock_radius);
                _overclockMaxTargets = Math.Max(1, _config.overclock_max_targets);
                _overclockIntervalYears = Math.Max(1, _config.overclock_interval_years);
            }
        }

        protected override void UpdateInvasion(int currentYear)
        {
            base.UpdateInvasion(currentYear);

            if (_overclockIntervalYears <= 0) return;
            if (currentYear - _lastOverclockYear < _overclockIntervalYears) return;

            Overclock(currentYear);
        }

        public override void ApplyUniqueAbility()
        {
            int year = CycleManager.Instance?.State?.WorldAgeYears ?? 0;
            Overclock(year);
        }

        private void Overclock(int currentYear)
        {
            try
            {
                EnsureActorSpawned();
                if (DemonActor == null) return;

                if (!TryGetActorPosition2D(DemonActor, out var center)) return;

                var units = World.world?.units;
                if (units == null) return;

                var candidates = new List<Actor>(Math.Min(512, _overclockMaxTargets * 4));
                foreach (var u in units)
                {
                    if (u == null) continue;
                    if (ReferenceEquals(u, DemonActor)) continue;

                    try
                    {
                        if (u.hasTrait("dlm_demon_faction")) continue;
                    }
                    catch
                    {
                    }

                    if (!TryGetActorPosition2D(u, out var pos)) continue;
                    if (Vector2.Distance(pos, center) > _overclockRadius) continue;

                    candidates.Add(u);
                }

                if (candidates.Count == 0) return;

                int max = Math.Min(_overclockMaxTargets, candidates.Count);
                int affected = 0;

                for (int i = 0; i < max; i++)
                {
                    int idx = UnityEngine.Random.Range(i, candidates.Count);
                    (candidates[i], candidates[idx]) = (candidates[idx], candidates[i]);

                    var target = candidates[i];
                    if (target == null) continue;

                    TryAddTrait(target, "strong");
                    TryAddTrait(target, "fast");
                    TryAddTrait(target, "madness");
                    affected++;
                }

                _lastOverclockYear = currentYear;

                if (affected > 0)
                {
                    Logger.Info($"DemonLord.{Id}", $"Overclock affected {affected} units (radius={_overclockRadius:0}, year={currentYear})");
                    NotificationSystem.Instance?.Show("超载改造", $"{Name}发动超载改造，影响了{affected}个单位！", NotificationType.Warning);
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"DemonLord.{Id}", "Error performing overclock", ex);
            }
        }

        public override void OnCycleEvolution(int newCycleCount)
        {
            _lastOverclockYear = int.MinValue;
        }
    }
}
