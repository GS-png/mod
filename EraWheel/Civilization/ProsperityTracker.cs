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
            var ok = true;

            if (LastPopulation >= 0)
            {
                anyKnown = true;
                ok &= LastPopulation >= t.population;
            }

            if (LastCities >= 0)
            {
                anyKnown = true;
                ok &= LastCities >= t.cities;
            }

            if (LastHeroes >= 0)
            {
                anyKnown = true;
                ok &= LastHeroes >= t.heroes;
            }

            if (LastTechLevel >= 0)
            {
                anyKnown = true;
                ok &= LastTechLevel >= t.tech_level;
            }

            if (anyKnown && ok)
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
