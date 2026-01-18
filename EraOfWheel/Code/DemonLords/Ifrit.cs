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
    public class Ifrit : BaseDemonLord
    {
        public override string Id => "ifrit";
        public override string Name => "混沌炎魔·伊弗利特";
        public override string Title => "焚世的狂焰";
        public override string Description => "来自混沌烈焰的魔王，擅长以火焰扭曲文明的秩序";
        public override int UnlockCycle => 2;

        private IfritConfig _config;
        private float _igniteRadius = 120f;
        private int _igniteMaxTargets = 60;
        private int _firestormIntervalYears = 12;
        private int _lastFirestormYear = int.MinValue;

        public Ifrit()
        {
            Stats.BaseHealth = 90000f;
            Stats.BaseDamage = 800f;
            Stats.BaseDefense = 450f;
            Stats.BaseSpeed = 10f;
            Stats.HealthGrowthPerCycle = 0.45f;
            Stats.DamageGrowthPerCycle = 0.3f;
        }

        public override void Initialize(int cycleCount)
        {
            base.Initialize(cycleCount);

            _config = ConfigManager.Instance?.Config?.demon_lords?.ifrit;
            if (_config != null)
            {
                ApplyConfigOverrides(_config.enabled, _config.unlock_cycle);
                _igniteRadius = Math.Max(10f, _config.ignite_radius);
                _igniteMaxTargets = Math.Max(1, _config.ignite_max_targets);
                _firestormIntervalYears = Math.Max(1, _config.firestorm_interval_years);
            }
        }

        protected override void UpdateInvasion(int currentYear)
        {
            base.UpdateInvasion(currentYear);

            if (_firestormIntervalYears <= 0) return;
            if (currentYear - _lastFirestormYear < _firestormIntervalYears) return;

            TriggerFirestorm(currentYear);
        }

        public override void ApplyUniqueAbility()
        {
            int year = CycleManager.Instance?.State?.WorldAgeYears ?? 0;
            TriggerFirestorm(year);
        }

        private void TriggerFirestorm(int currentYear)
        {
            try
            {
                EnsureActorSpawned();
                if (DemonActor == null) return;

                if (!TryGetActorPosition2D(DemonActor, out var center)) return;

                var units = World.world?.units;
                if (units == null) return;

                var candidates = new List<Actor>(Math.Min(512, _igniteMaxTargets * 4));
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
                    if (Vector2.Distance(pos, center) > _igniteRadius) continue;

                    candidates.Add(u);
                }

                if (candidates.Count == 0) return;

                int max = Math.Min(_igniteMaxTargets, candidates.Count);
                int affected = 0;
                for (int i = 0; i < max; i++)
                {
                    int idx = UnityEngine.Random.Range(i, candidates.Count);
                    (candidates[i], candidates[idx]) = (candidates[idx], candidates[i]);
                    var target = candidates[i];
                    if (target == null) continue;

                    TryAddTrait(target, "burning");
                    TryAddTrait(target, "madness");
                    affected++;
                }

                _lastFirestormYear = currentYear;

                if (affected > 0)
                {
                    Logger.Info($"DemonLord.{Id}", $"Firestorm affected {affected} units (radius={_igniteRadius:0}, year={currentYear})");
                    NotificationSystem.Instance?.Show("火焰风暴", $"{Name}释放火焰风暴，点燃了{affected}个单位！", NotificationType.Critical);
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"DemonLord.{Id}", "Error triggering firestorm", ex);
            }
        }

        public override void OnCycleEvolution(int newCycleCount)
        {
            _lastFirestormYear = int.MinValue;
        }
    }
}
