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
    public class Mephisto : BaseDemonLord
    {
        public override string Id => "mephisto";
        public override string Name => "灵魂编织者·墨菲斯托";
        public override string Title => "契约的低语";
        public override string Description => "以欲望与契约操控人心的魔王，擅长挑起混乱与堕落";
        public override int UnlockCycle => 3;

        private MephistoConfig _config;
        private float _temptationRadius = 180f;
        private int _temptationMaxTargets = 35;
        private int _temptationIntervalYears = 20;
        private int _lastTemptationYear = int.MinValue;

        public Mephisto()
        {
            Stats.BaseHealth = 85000f;
            Stats.BaseDamage = 650f;
            Stats.BaseDefense = 380f;
            Stats.BaseSpeed = 11f;
            Stats.HealthGrowthPerCycle = 0.4f;
            Stats.DamageGrowthPerCycle = 0.3f;
        }

        public override void Initialize(int cycleCount)
        {
            base.Initialize(cycleCount);

            _config = ConfigManager.Instance?.Config?.demon_lords?.mephisto;
            if (_config != null)
            {
                ApplyConfigOverrides(_config.enabled, _config.unlock_cycle);
                _temptationRadius = Math.Max(10f, _config.temptation_radius);
                _temptationMaxTargets = Math.Max(1, _config.temptation_max_targets);
                _temptationIntervalYears = Math.Max(1, _config.temptation_interval_years);
            }
        }

        protected override void UpdateInvasion(int currentYear)
        {
            base.UpdateInvasion(currentYear);

            if (_temptationIntervalYears <= 0) return;
            if (currentYear - _lastTemptationYear < _temptationIntervalYears) return;

            Tempt(currentYear);
        }

        public override void ApplyUniqueAbility()
        {
            int year = CycleManager.Instance?.State?.WorldAgeYears ?? 0;
            Tempt(year);
        }

        private void Tempt(int currentYear)
        {
            try
            {
                EnsureActorSpawned();
                if (DemonActor == null) return;

                if (!TryGetActorPosition2D(DemonActor, out var center)) return;

                var units = World.world?.units;
                if (units == null) return;

                var candidates = new List<Actor>(Math.Min(512, _temptationMaxTargets * 4));
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
                    if (Vector2.Distance(pos, center) > _temptationRadius) continue;

                    candidates.Add(u);
                }

                if (candidates.Count == 0) return;

                int max = Math.Min(_temptationMaxTargets, candidates.Count);
                int affected = 0;

                for (int i = 0; i < max; i++)
                {
                    int idx = UnityEngine.Random.Range(i, candidates.Count);
                    (candidates[i], candidates[idx]) = (candidates[idx], candidates[i]);

                    var target = candidates[i];
                    if (target == null) continue;

                    TryAddTrait(target, "greedy");
                    TryAddTrait(target, "madness");
                    TryAddTrait(target, "evil");
                    affected++;
                }

                _lastTemptationYear = currentYear;

                if (affected > 0)
                {
                    Logger.Info($"DemonLord.{Id}", $"Temptation affected {affected} units (radius={_temptationRadius:0}, year={currentYear})");
                    NotificationSystem.Instance?.Show("契约低语", $"{Name}散播契约低语，诱惑了{affected}个单位！", NotificationType.Warning);
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"DemonLord.{Id}", "Error performing temptation", ex);
            }
        }

        public override void OnCycleEvolution(int newCycleCount)
        {
            _lastTemptationYear = int.MinValue;
        }
    }
}
