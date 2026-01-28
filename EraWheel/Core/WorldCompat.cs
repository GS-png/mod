using System;
using System.Reflection;

namespace EraWheel.Core
{
    public static class WorldCompat
    {
        public static bool MockEnabled { get; set; }
        public static long MockWorldAge { get; set; }
        public static int MockPopulation { get; set; }
        public static int MockCities { get; set; }
        public static int MockCivilizations { get; set; }
        public static int MockHeroes { get; set; }
        public static int MockTechLevel { get; set; }
        public static Func<int> HeroCountProvider { get; set; }

        private static bool _heroUnsupportedLogged;
        private static bool _techUnsupportedLogged;
#if !ERAWHEEL_SELFTEST
        private static bool _worldTipLogged;
#endif

        public static long GetWorldAge()
        {
            if (MockEnabled) return MockWorldAge;

#if !ERAWHEEL_SELFTEST
            var mapBox = MapBox.instance;
            if (mapBox == null) return 0;

            try
            {
                var worldTime = mapBox.getCurWorldTime();
                var year = Date.getYear(worldTime);
                return year > 0 ? year : 0;
            }
            catch
            {
                return 0;
            }
#else
            return 0;
#endif
        }

        public static int TryGetTotalPopulation()
        {
            if (MockEnabled) return MockPopulation;

#if !ERAWHEEL_SELFTEST
            var mapBox = MapBox.instance;
            if (mapBox == null) return -1;

            try
            {
                return mapBox.getCivWorldPopulation();
            }
            catch
            {
                return -1;
            }
#else
            return -1;
#endif
        }

        public static int GetTotalPopulation()
        {
            var value = TryGetTotalPopulation();
            return value >= 0 ? value : 0;
        }

        public static int TryGetCityCount()
        {
            if (MockEnabled) return MockCities;

#if !ERAWHEEL_SELFTEST
            var mapBox = MapBox.instance;
            if (mapBox == null || mapBox.cities == null) return -1;

            try
            {
                return mapBox.cities.Count;
            }
            catch
            {
                return -1;
            }
#else
            return -1;
#endif
        }

        public static int GetTotalCities()
        {
            var value = TryGetCityCount();
            return value >= 0 ? value : 0;
        }

        public static int TryGetCivilizationCount()
        {
            if (MockEnabled) return MockCivilizations;

#if !ERAWHEEL_SELFTEST
            var mapBox = MapBox.instance;
            if (mapBox == null || mapBox.kingdoms == null) return -1;

            try
            {
                return mapBox.kingdoms.Count;
            }
            catch
            {
                return -1;
            }
#else
            return -1;
#endif
        }

        public static int GetTotalCivilizations()
        {
            var value = TryGetCivilizationCount();
            return value >= 0 ? value : 0;
        }

        public static int TryGetHeroCount()
        {
            if (MockEnabled) return MockHeroes;

            if (HeroCountProvider != null)
            {
                try
                {
                    return HeroCountProvider();
                }
                catch
                {
                }
            }

            if (!_heroUnsupportedLogged)
            {
                _heroUnsupportedLogged = true;
                Log.Info("[EraWheel] Hero count is not available in current WorldBox API.");
            }
            return -1;
        }

        public static int GetHeroCount()
        {
            var value = TryGetHeroCount();
            return value >= 0 ? value : 0;
        }

        public static int TryGetTechLevel()
        {
            if (MockEnabled) return MockTechLevel;

            if (!_techUnsupportedLogged)
            {
                _techUnsupportedLogged = true;
                Log.Info("[EraWheel] Tech level is not available in current WorldBox API.");
            }
            return -1;
        }

        public static bool TryGetActorHealthPercent(object actor, out float percent)
        {
            percent = 0f;
            if (actor == null) return false;

            if (MockEnabled && TryGetMockHealthPercent(actor, out percent))
            {
                return true;
            }

#if !ERAWHEEL_SELFTEST
            var typed = actor as Actor;
            if (typed == null) return false;

            try
            {
                var ratio = typed.getHealthRatio();
                percent = ratio * 100f;
                if (percent < 0f) percent = 0f;
                if (percent > 100f) percent = 100f;
                return true;
            }
            catch
            {
                return false;
            }
#else
            return false;
#endif
        }

        public static void ShowNotification(string message)
        {
            if (string.IsNullOrEmpty(message)) return;

            if (MockEnabled)
            {
                Log.Info("[EraWheel] " + message);
                return;
            }

#if !ERAWHEEL_SELFTEST
            try
            {
                WorldTip.showNow(message, false, "center", 3f, "#F3961F");
                return;
            }
            catch
            {
            }

            if (!_worldTipLogged)
            {
                _worldTipLogged = true;
                Log.Info("[EraWheel] WorldTip.showNow failed, falling back to log.");
            }

            Log.Info("[EraWheel] " + message);
#else
            Log.Info("[EraWheel] " + message);
#endif
        }

        private static bool TryGetMockHealthPercent(object actor, out float percent)
        {
            percent = 0f;

            try
            {
                var actorType = actor.GetType();
                var healthField = actorType.GetField("health", BindingFlags.Public | BindingFlags.Instance);
                var maxField = actorType.GetField("maxHealth", BindingFlags.Public | BindingFlags.Instance);
                if (healthField == null || maxField == null) return false;

                var healthObj = healthField.GetValue(actor);
                var maxObj = maxField.GetValue(actor);
                var health = Convert.ToSingle(healthObj);
                var max = Convert.ToSingle(maxObj);
                if (max <= 0f) return false;

                percent = (health / max) * 100f;
                if (percent < 0f) percent = 0f;
                if (percent > 100f) percent = 100f;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
