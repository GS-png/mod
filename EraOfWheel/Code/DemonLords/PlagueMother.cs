using System;
using System.Collections.Generic;
using EraOfWheel.Core;
using EraOfWheel.Core.Config;

namespace EraOfWheel.DemonLords
{
    public class PlagueMother : BaseDemonLord
    {
        public override string Id => "plague_mother";
        public override string Name => "瘟疫母神·娜迦蒂";
        public override string Title => "腐烂的爱抚者";
        public override string Description => "掌控疾病与腐朽的魔王，她的爱意表现为致命的瘟疫";
        public override int UnlockCycle => 1;

        private PlagueMother _config;
        private float _infectionSpreadChance;
        private int _incubationYears;
        private int _toxicFogDurationYears;
        private int _plagueLordSummonThreshold;
        
        private HashSet<string> _infectedUnits = new HashSet<string>();
        private int _totalInfected = 0;
        private int _lastPlagueYear = 0;

        public PlagueMother()
        {
            Stats.BaseHealth = 80000f;
            Stats.BaseDamage = 600f;
            Stats.BaseDefense = 400f;
            Stats.BaseSpeed = 8f;
            Stats.HealthGrowthPerCycle = 0.4f;
            Stats.DamageGrowthPerCycle = 0.25f;
        }

        public override void Initialize(int cycleCount)
        {
            base.Initialize(cycleCount);
            
            var config = ConfigManager.Instance?.Config?.demon_lords?.plague_mother;
            if (config != null)
            {
                _infectionSpreadChance = config.infection_spread_chance;
                _incubationYears = config.incubation_years;
                _toxicFogDurationYears = config.toxic_fog_duration_years;
                _plagueLordSummonThreshold = config.plague_lord_summon_threshold;
                IsEnabled = config.enabled;
            }
            else
            {
                _infectionSpreadChance = 0.3f;
                _incubationYears = 5;
                _toxicFogDurationYears = 10;
                _plagueLordSummonThreshold = 100;
            }
        }

        protected override void UpdateInvasion(int currentYear)
        {
            base.UpdateInvasion(currentYear);
            
            SpreadInfection();
            ProcessIncubation(currentYear);
            CheckPlagueLordSummon();
        }

        public override void ApplyUniqueAbility()
        {
            TriggerGlobalPlague();
        }

        private void SpreadInfection()
        {
            try
            {
                var units = World.world?.units;
                if (units == null) return;

                var newInfections = new List<string>();

                foreach (var unit in units)
                {
                    if (unit == null) continue;
                    if (unit.hasTrait("dlm_demon_faction")) continue;
                    if (_infectedUnits.Contains(unit.data.id)) continue;
                    
                    bool nearInfected = IsNearInfectedUnit(unit);
                    if (nearInfected && UnityEngine.Random.value < _infectionSpreadChance)
                    {
                        newInfections.Add(unit.data.id);
                        unit.addTrait("plague_infected");
                    }
                }

                foreach (var id in newInfections)
                {
                    _infectedUnits.Add(id);
                    _totalInfected++;
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"DemonLord.{Id}", "Error spreading infection", ex);
            }
        }

        private bool IsNearInfectedUnit(Actor unit)
        {
            try
            {
                var units = World.world?.units;
                if (units == null) return false;

                foreach (var other in units)
                {
                    if (other == null || other == unit) continue;
                    if (!_infectedUnits.Contains(other.data.id)) continue;
                    
                    float distance = CalculateDistance(unit.currentPosition, other.currentPosition);
                    if (distance <= 50)
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
            
            return false;
        }

        private void ProcessIncubation(int currentYear)
        {
            // Simplified: infected units take damage over time
            try
            {
                var units = World.world?.units;
                if (units == null) return;

                foreach (var unit in units)
                {
                    if (unit == null) continue;
                    if (!_infectedUnits.Contains(unit.data.id)) continue;
                    
                    float damage = unit.data.health * 0.05f;
                    unit.getHit(damage, pType: AttackType.Other);
                    
                    if (unit.data.health <= 0)
                    {
                        RecordKill();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"DemonLord.{Id}", "Error processing incubation", ex);
            }
        }

        private void TriggerGlobalPlague()
        {
            Logger.Info($"DemonLord.{Id}", "Global plague outbreak triggered!");
            
            try
            {
                var cities = World.world?.cities;
                if (cities == null || cities.Count == 0) return;

                int targetIndex = UnityEngine.Random.Range(0, cities.Count);
                var targetCity = cities[targetIndex];
                
                if (targetCity != null)
                {
                    Logger.Info($"DemonLord.{Id}", $"Plague outbreak at {targetCity.data.name}");
                    InfectCity(targetCity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"DemonLord.{Id}", "Error triggering global plague", ex);
            }
        }

        private void InfectCity(City city)
        {
            if (city?.units == null) return;
            
            foreach (var unit in city.units)
            {
                if (unit == null) continue;
                if (UnityEngine.Random.value < 0.5f)
                {
                    _infectedUnits.Add(unit.data.id);
                    unit.addTrait("plague_infected");
                    _totalInfected++;
                }
            }
        }

        private void CheckPlagueLordSummon()
        {
            if (_totalInfected >= _plagueLordSummonThreshold)
            {
                SummonPlagueLord();
                _totalInfected = 0;
            }
        }

        private void SummonPlagueLord()
        {
            Logger.Info($"DemonLord.{Id}", "Plague Lord summoned from the accumulated suffering!");
            // Note: Full implementation would spawn a mini-boss
        }

        private float CalculateDistance(WorldTile a, WorldTile b)
        {
            if (a == null || b == null) return float.MaxValue;
            
            float dx = a.x - b.x;
            float dy = a.y - b.y;
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }

        public override void OnCycleEvolution(int newCycleCount)
        {
            Logger.Info($"DemonLord.{Id}", $"Evolving for cycle {newCycleCount}");
            
            if (newCycleCount >= 2)
            {
                _infectionSpreadChance = Math.Min(0.6f, _infectionSpreadChance * 1.2f);
            }
            
            if (newCycleCount >= 3)
            {
                _incubationYears = Math.Max(2, _incubationYears - 1);
            }
        }

        protected override void ResetForNextCycle()
        {
            base.ResetForNextCycle();
            _infectedUnits.Clear();
            _totalInfected = 0;
            _lastPlagueYear = 0;
        }
    }
}
