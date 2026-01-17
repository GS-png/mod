using System;
using EraOfWheel.Core;
using EraOfWheel.Core.Config;

namespace EraOfWheel.DemonLords
{
    public class VoidLord : BaseDemonLord
    {
        public override string Id => "void_lord";
        public override string Name => "虚无之主·伊格尔";
        public override string Title => "存在的终结者";
        public override string Description => "代表虚无概念的原初魔王，能够抹除万物的存在痕迹";
        public override int UnlockCycle => 1;

        private VoidLordConfig _config;
        private int _voidDomainRadius;
        private float _voidDomainDamagePercent;
        private int _worldContractionKillThreshold;
        private float _worldContractionPercent;
        private float _minHabitablePercent;
        
        private int _lastContractionKillCount = 0;

        public VoidLord()
        {
            Stats.BaseHealth = 100000f;
            Stats.BaseDamage = 1000f;
            Stats.BaseDefense = 500f;
            Stats.BaseSpeed = 12f;
            Stats.HealthGrowthPerCycle = 0.5f;
            Stats.DamageGrowthPerCycle = 0.33f;
        }

        public override void Initialize(int cycleCount)
        {
            base.Initialize(cycleCount);
            
            _config = ConfigManager.Instance?.Config?.demon_lords?.void_lord;
            if (_config != null)
            {
                _voidDomainRadius = _config.void_domain_radius;
                _voidDomainDamagePercent = _config.void_domain_damage_percent;
                _worldContractionKillThreshold = _config.world_contraction_kill_threshold;
                _worldContractionPercent = _config.world_contraction_percent;
                _minHabitablePercent = _config.min_habitable_percent;
                IsEnabled = _config.enabled;
            }
            else
            {
                _voidDomainRadius = 1000;
                _voidDomainDamagePercent = 1f;
                _worldContractionKillThreshold = 100;
                _worldContractionPercent = 5f;
                _minHabitablePercent = 40f;
            }
        }

        protected override void UpdateInvasion(int currentYear)
        {
            base.UpdateInvasion(currentYear);
            
            ApplyVoidDomain();
            CheckWorldContraction();
        }

        public override void ApplyUniqueAbility()
        {
            ApplyVoidDomain();
        }

        private void ApplyVoidDomain()
        {
            if (DemonActor == null) return;
            
            try
            {
                var units = World.world?.units;
                if (units == null) return;

                var demonTile = DemonActor?.currentTile;
                if (demonTile == null) return;

                foreach (var unit in units)
                {
                    if (unit == null || unit == DemonActor) continue;
                    if (unit.hasTrait("dlm_demon_faction")) continue;
                    
                    var unitTile = unit?.currentTile;
                    if (unitTile == null) continue;
                    
                    float distance = CalculateDistance(demonTile, unitTile);
                    if (distance <= _voidDomainRadius)
                    {
                        float damage = unit.data.health * (_voidDomainDamagePercent / 100f);
                        unit.getHit(damage);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"DemonLord.{Id}", $"Error applying void domain", ex);
            }
        }

        private void CheckWorldContraction()
        {
            int killsSinceLastContraction = TotalKills - _lastContractionKillCount;
            
            if (killsSinceLastContraction >= _worldContractionKillThreshold)
            {
                TriggerWorldContraction();
                _lastContractionKillCount = TotalKills;
            }
        }

        private void TriggerWorldContraction()
        {
            Logger.Info($"DemonLord.{Id}", $"World Contraction triggered! {_worldContractionPercent}% of world becomes void");
            
            // Note: Full implementation would convert tiles to void terrain
            // For MVP, we log the event
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
                _voidDomainRadius = (int)(_voidDomainRadius * 1.1f);
            }
            
            if (newCycleCount >= 3)
            {
                _voidDomainDamagePercent *= 1.2f;
            }
        }

        protected override void ResetForNextCycle()
        {
            base.ResetForNextCycle();
            _lastContractionKillCount = 0;
        }
    }
}
