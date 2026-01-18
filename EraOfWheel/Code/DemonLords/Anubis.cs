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
    public class Anubis : BaseDemonLord
    {
        public override string Id => "anubis";
        public override string Name => "死亡君王·阿努比斯";
        public override string Title => "冥府的裁决者";
        public override string Description => "掌控死亡与灵魂的魔王，他的出现会让世界逐渐陷入腐朽与诅咒";
        public override int UnlockCycle => 2;

        private AnubisConfig _config;
        private float _curseRadius = 140f;
        private int _curseMaxTargets = 40;
        private int _soulHarvestIntervalYears = 15;
        private int _lastSoulHarvestYear = int.MinValue;

        public Anubis()
        {
            Stats.BaseHealth = 95000f;
            Stats.BaseDamage = 700f;
            Stats.BaseDefense = 550f;
            Stats.BaseSpeed = 8f;
            Stats.HealthGrowthPerCycle = 0.45f;
            Stats.DamageGrowthPerCycle = 0.28f;
        }

        public override void Initialize(int cycleCount)
        {
            base.Initialize(cycleCount);

            _config = ConfigManager.Instance?.Config?.demon_lords?.anubis;
            if (_config != null)
            {
                ApplyConfigOverrides(_config.enabled, _config.unlock_cycle);
                _curseRadius = Math.Max(10f, _config.curse_radius);
                _curseMaxTargets = Math.Max(1, _config.curse_max_targets);
                _soulHarvestIntervalYears = Math.Max(1, _config.soul_harvest_interval_years);
            }
        }

        protected override void UpdateInvasion(int currentYear)
        {
            base.UpdateInvasion(currentYear);

            if (_soulHarvestIntervalYears <= 0) return;
            if (currentYear - _lastSoulHarvestYear < _soulHarvestIntervalYears) return;

            SoulHarvest(currentYear);
        }

        public override void ApplyUniqueAbility()
        {
            int year = CycleManager.Instance?.State?.WorldAgeYears ?? 0;
            SoulHarvest(year);
        }

        private void SoulHarvest(int currentYear)
        {
            try
            {
                EnsureActorSpawned();
                if (DemonActor == null) return;

                if (!TryGetActorPosition2D(DemonActor, out var center)) return;

                var units = World.world?.units;
                if (units == null) return;

                var candidates = new List<Actor>(Math.Min(512, _curseMaxTargets * 4));
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
                    if (Vector2.Distance(pos, center) > _curseRadius) continue;

                    candidates.Add(u);
                }

                if (candidates.Count == 0) return;

                int max = Math.Min(_curseMaxTargets, candidates.Count);
                int affected = 0;

                for (int i = 0; i < max; i++)
                {
                    int idx = UnityEngine.Random.Range(i, candidates.Count);
                    (candidates[i], candidates[idx]) = (candidates[idx], candidates[i]);

                    var target = candidates[i];
                    if (target == null) continue;

                    TryAddTrait(target, "cursed");
                    TryAddTrait(target, "madness");
                    affected++;
                }

                _lastSoulHarvestYear = currentYear;

                if (affected > 0)
                {
                    Logger.Info($"DemonLord.{Id}", $"Soul harvest affected {affected} units (radius={_curseRadius:0}, year={currentYear})");
                    NotificationSystem.Instance?.Show("灵魂收割", $"{Name}降下冥府诅咒，影响了{affected}个单位！", NotificationType.Critical);
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"DemonLord.{Id}", "Error performing soul harvest", ex);
            }
        }

        public override void OnCycleEvolution(int newCycleCount)
        {
            _lastSoulHarvestYear = int.MinValue;
        }
    }
}
