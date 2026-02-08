using System;
using EraWheel.Config;

namespace EraWheel.Civilization
{
    public static class AntiDemonLevel
    {
        public static int ComputeLevel(ModConfig cfg, int killCount)
        {
            if (killCount < 0) killCount = 0;

            var thresholds = cfg != null && cfg.civilization != null && cfg.civilization.anti_demon != null
                ? cfg.civilization.anti_demon.kill_thresholds
                : null;

            if (thresholds == null || thresholds.Length == 0)
            {
                return 0;
            }

            var level = 0;
            for (var i = 0; i < thresholds.Length; i++)
            {
                var t = thresholds[i];
                if (t <= 0) continue;
                if (killCount >= t) level = i + 1;
            }

            if (level < 0) level = 0;
            if (level > 10) level = 10;
            return level;
        }

        public static float GetDamageDealtMultiplier(ModConfig cfg, int antiDemonLevel)
        {
            var bonus = cfg != null && cfg.civilization != null && cfg.civilization.anti_demon != null
                ? cfg.civilization.anti_demon.damage_bonus_per_level
                : 0.1f;

            if (bonus < 0f) bonus = 0f;
            if (antiDemonLevel < 0) antiDemonLevel = 0;

            return 1f + antiDemonLevel * bonus;
        }

        public static float GetDamageTakenMultiplier(ModConfig cfg, int antiDemonLevel)
        {
            var reduction = cfg != null && cfg.civilization != null && cfg.civilization.anti_demon != null
                ? cfg.civilization.anti_demon.damage_reduction_per_level
                : 0.05f;

            if (reduction < 0f) reduction = 0f;
            if (antiDemonLevel < 0) antiDemonLevel = 0;

            var mult = 1f - antiDemonLevel * reduction;
            if (mult < 0.1f) mult = 0.1f;
            if (mult > 1f) mult = 1f;
            return mult;
        }
    }
}
