using System;
using EraWheel.Config;
using EraWheel.Core;
using EraWheel.Data;

namespace EraWheel.Civilization
{
    public class CivilizationTracker
    {
        private bool _bound;
        private ModConfig _lastConfig;

        public int DemonKillCount { get; private set; }
        public int AntiDemonLevel { get; private set; }
        public float CSI { get; private set; }

        public void Initialize(ModConfig cfg)
        {
            _lastConfig = cfg;
            BindEvents();
            RecomputeAll(cfg);
        }

        public void Update(ModConfig cfg)
        {
            if (cfg != null) _lastConfig = cfg;
            RecomputeCSI(_lastConfig);
        }

        private void BindEvents()
        {
            if (_bound) return;
            _bound = true;

            EventBus.Subscribe<DemonKillEvent>(OnDemonKill);
        }

        private void OnDemonKill(DemonKillEvent evt)
        {
            if (evt.Count <= 0) return;

            DemonKillCount += evt.Count;
            if (DemonKillCount < 0) DemonKillCount = int.MaxValue;

            var prev = AntiDemonLevel;
            AntiDemonLevel = global::EraWheel.Civilization.AntiDemonLevel.ComputeLevel(_lastConfig, DemonKillCount);

            if (AntiDemonLevel > prev)
            {
                try
                {
                    EventBus.Publish(new AntiDemonLevelChangedEvent
                    {
                        PreviousLevel = prev,
                        NewLevel = AntiDemonLevel,
                        DemonKillCount = DemonKillCount,
                        WorldTime = evt.WorldTime
                    });
                }
                catch
                {
                }

                Log.Info("[EraWheel] AntiDemonLevel increased: " + prev + " -> " + AntiDemonLevel + " kills=" + DemonKillCount);
            }

            RecomputeCSI(_lastConfig);
        }

        private void RecomputeAll(ModConfig cfg)
        {
            if (cfg != null) _lastConfig = cfg;
            AntiDemonLevel = global::EraWheel.Civilization.AntiDemonLevel.ComputeLevel(_lastConfig, DemonKillCount);
            RecomputeCSI(_lastConfig);
        }

        private void RecomputeCSI(ModConfig cfg)
        {
            var pop = WorldCompat.TryGetTotalPopulation();
            var cities = WorldCompat.TryGetCityCount();
            var heroes = WorldCompat.TryGetHeroCount();
            var tech = WorldCompat.TryGetTechLevel();

            var wPop = 0.25f;
            var wCities = 0.2f;
            var wTech = 0.2f;
            var wAnti = 0.2f;
            var wHeroes = 0.15f;

            if (cfg != null && cfg.civilization != null && cfg.civilization.csi != null)
            {
                wPop = cfg.civilization.csi.population_weight;
                wCities = cfg.civilization.csi.cities_weight;
                wTech = cfg.civilization.csi.tech_weight;
                wAnti = cfg.civilization.csi.anti_demon_weight;
                wHeroes = cfg.civilization.csi.heroes_weight;
            }

            var sumW = 0f;
            var sum = 0f;

            if (pop >= 0)
            {
                sumW += wPop;
                sum += wPop * Score(pop, 10000);
            }

            if (cities >= 0)
            {
                sumW += wCities;
                sum += wCities * Score(cities, 50);
            }

            if (tech >= 0)
            {
                sumW += wTech;
                sum += wTech * Score(tech, 20);
            }

            sumW += wAnti;
            sum += wAnti * Score(AntiDemonLevel, 10);

            if (heroes >= 0)
            {
                sumW += wHeroes;
                sum += wHeroes * Score(heroes, 20);
            }

            if (sumW <= 0f)
            {
                CSI = 0f;
                return;
            }

            CSI = sum / sumW;
            if (CSI < 0f) CSI = 0f;
            if (CSI > 100f) CSI = 100f;
        }

        private static float Score(int value, int max)
        {
            if (max <= 0) return 0f;
            if (value < 0) value = 0;
            if (value > max) value = max;
            return (float)value / max * 100f;
        }

        public CivilizationSaveData ExportToSave()
        {
            return new CivilizationSaveData
            {
                DemonKillCount = DemonKillCount,
                AntiDemonLevel = AntiDemonLevel,
                CSI = CSI
            };
        }

        public void LoadFromSave(CivilizationSaveData data)
        {
            if (data == null) return;
            DemonKillCount = Math.Max(0, data.DemonKillCount);
            AntiDemonLevel = Math.Max(0, data.AntiDemonLevel);
            CSI = data.CSI;
        }
    }
}
