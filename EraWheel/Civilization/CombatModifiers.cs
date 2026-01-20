using EraWheel.Config;

namespace EraWheel.Civilization
{
    public static class CombatModifiers
    {
        public static float ApplyDamageDealt(ModConfig cfg, int antiDemonLevel, float baseDamage)
        {
            var mult = AntiDemonLevel.GetDamageDealtMultiplier(cfg, antiDemonLevel);
            if (baseDamage < 0f) baseDamage = 0f;
            return baseDamage * mult;
        }

        public static float ApplyDamageTaken(ModConfig cfg, int antiDemonLevel, float baseDamage)
        {
            var mult = AntiDemonLevel.GetDamageTakenMultiplier(cfg, antiDemonLevel);
            if (baseDamage < 0f) baseDamage = 0f;
            return baseDamage * mult;
        }
    }
}
