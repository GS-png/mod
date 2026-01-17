using System;

namespace EraOfWheel.DemonLords
{
    [Serializable]
    public class DemonLordStats
    {
        public float BaseHealth { get; set; } = 100000f;
        public float BaseDamage { get; set; } = 1000f;
        public float BaseDefense { get; set; } = 500f;
        public float BaseSpeed { get; set; } = 10f;
        
        public float HealthGrowthPerCycle { get; set; } = 0.5f;
        public float DamageGrowthPerCycle { get; set; } = 0.33f;
        public float DefenseGrowthPerCycle { get; set; } = 0.25f;

        public float CurrentHealth { get; set; }
        public float MaxHealth { get; private set; }
        
        public float HealthPercent => MaxHealth > 0 ? CurrentHealth / MaxHealth * 100f : 0f;

        public void CalculateForCycle(int cycleCount, float powerMultiplier)
        {
            float cycleMultiplier = 1f + (cycleCount - 1) * HealthGrowthPerCycle;
            MaxHealth = BaseHealth * cycleMultiplier * powerMultiplier;
            CurrentHealth = MaxHealth;
        }

        public float GetDamage(int cycleCount, float powerMultiplier)
        {
            float cycleMultiplier = 1f + (cycleCount - 1) * DamageGrowthPerCycle;
            return BaseDamage * cycleMultiplier * powerMultiplier;
        }

        public float GetDefense(int cycleCount, float powerMultiplier)
        {
            float cycleMultiplier = 1f + (cycleCount - 1) * DefenseGrowthPerCycle;
            return BaseDefense * cycleMultiplier * powerMultiplier;
        }

        public void TakeDamage(float damage)
        {
            CurrentHealth = Math.Max(0, CurrentHealth - damage);
        }

        public void Heal(float amount)
        {
            CurrentHealth = Math.Min(MaxHealth, CurrentHealth + amount);
        }

        public bool IsDead => CurrentHealth <= 0;
    }
}
