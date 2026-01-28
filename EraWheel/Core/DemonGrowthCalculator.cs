using EraWheel.Config;

namespace EraWheel.Core
{
    public static class DemonGrowthCalculator
    {
        public static float ComputeStrengthMultiplier(ModConfig cfg, int cycleCount)
        {
            var cycleMultiplier = 0.25f;
            var min = 0.6f;
            var max = 3.0f;

            if (cfg != null && cfg.demon_lord != null && cfg.demon_lord.growth != null)
            {
                cycleMultiplier = cfg.demon_lord.growth.cycle_multiplier;
                min = cfg.demon_lord.growth.strength_min;
                max = cfg.demon_lord.growth.strength_max;
            }

            if (min <= 0f) min = 0.6f;
            if (max < min) max = min;
            if (cycleCount < 0) cycleCount = 0;

            var multiplier = 1f + cycleCount * cycleMultiplier;
            if (multiplier < min) multiplier = min;
            if (multiplier > max) multiplier = max;
            return multiplier;
        }
    }
}
