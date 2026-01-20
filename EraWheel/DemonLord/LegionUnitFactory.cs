using System;

namespace EraWheel.DemonLord
{
    public static class LegionUnitFactory
    {
        public static string PickUnitIdForWave(int wave, float eliteRate, Random rng)
        {
            if (wave < 1) wave = 1;
            if (rng == null) rng = new Random();

            var tier = PickTier(wave, eliteRate, rng);
            switch (tier)
            {
                case LegionTier.Vanguard:
                    return "legion_vanguard";
                case LegionTier.Main:
                    return "legion_main";
                case LegionTier.Elite:
                    return "legion_elite";
                case LegionTier.Ultimate:
                    return "legion_ultimate";
                default:
                    return "legion_main";
            }
        }

        private static LegionTier PickTier(int wave, float eliteRate, Random rng)
        {
            if (wave >= 10) return LegionTier.Ultimate;
            if (wave >= 7) return LegionTier.Elite;
            if (wave >= 4) return LegionTier.Main;

            if (eliteRate > 0f && rng.NextDouble() < eliteRate)
            {
                return LegionTier.Elite;
            }

            return LegionTier.Vanguard;
        }
    }
}
