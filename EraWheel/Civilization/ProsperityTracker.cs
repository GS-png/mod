using System;
using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.Civilization
{
    public class ProsperityTracker
    {
        public bool Enabled { get; private set; }
        public bool ProsperityReached { get; private set; }

        public int LastPopulation { get; private set; }
        public int LastCities { get; private set; }
        public int LastHeroes { get; private set; }
        public int LastTechLevel { get; private set; }

        public bool HasUsableSnapshot
        {
            get
            {
                return LastPopulation >= 0 || LastCities >= 0 || LastHeroes >= 0 || LastTechLevel >= 0;
            }
        }

        public ProsperityTracker()
        {
            ResetSnapshot();
        }

        public void Enable()
        {
            Enabled = true;
            ProsperityReached = false;
            ResetSnapshot();
        }

        public void Disable()
        {
            Enabled = false;
        }

        public void ForceReached()
        {
            ProsperityReached = true;
        }

        public void Update(ModConfig cfg)
        {
            if (!Enabled) return;
            if (cfg == null || cfg.cycle == null || cfg.cycle.trigger == null) return;

            LastPopulation = WorldCompat.TryGetTotalPopulation();
            LastCities = WorldCompat.TryGetCityCount();
            LastHeroes = WorldCompat.TryGetHeroCount();
            LastTechLevel = WorldCompat.TryGetTechLevel();

            if (ProsperityReached) return;

            var t = cfg.cycle.trigger.prosperity_thresholds;
            if (t == null) return;

            var anyKnown = false;
            var anyMet = false;
            var allMet = true;
            var requireAll = string.Equals(cfg.cycle.trigger.prosperity_mode, "all", StringComparison.OrdinalIgnoreCase) ||
                             string.Equals(cfg.cycle.trigger.prosperity_mode, "and", StringComparison.OrdinalIgnoreCase);

            if (LastPopulation >= 0)
            {
                anyKnown = true;
                var met = LastPopulation >= t.population;
                anyMet |= met;
                allMet &= met;
            }

            if (LastCities >= 0)
            {
                anyKnown = true;
                var met = LastCities >= t.cities;
                anyMet |= met;
                allMet &= met;
            }

            if (LastHeroes >= 0)
            {
                anyKnown = true;
                var met = LastHeroes >= t.heroes;
                anyMet |= met;
                allMet &= met;
            }

            if (LastTechLevel >= 0)
            {
                anyKnown = true;
                var met = LastTechLevel >= t.tech_level;
                anyMet |= met;
                allMet &= met;
            }

            if (anyKnown && (requireAll ? allMet : anyMet))
            {
                ProsperityReached = true;
            }
        }

        private void ResetSnapshot()
        {
            LastPopulation = -1;
            LastCities = -1;
            LastHeroes = -1;
            LastTechLevel = -1;
        }
    }
}
