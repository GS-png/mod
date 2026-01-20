using System;
using System.Collections;
using System.Reflection;

namespace EraWheel.Core
{
    public static class WorldCompat
    {
        public static bool MockEnabled;
        public static long MockWorldAge;
        public static int MockPopulation = -1;
        public static int MockCities = -1;
        public static int MockHeroes = -1;
        public static int MockTechLevel = -1;

        public static long GetWorldAge()
        {
            if (MockEnabled) return MockWorldAge;

            try
            {
                var worldType = CompatReflection.FindTypeByName("World");
                if (worldType == null) return 0;

                var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
                var worldField = worldType.GetField("world", flags);
                var worldObj = worldField != null ? worldField.GetValue(null) : null;
                if (worldObj == null) return 0;

                return ReadLongMember(worldObj, "worldAge", "age", "world_age");
            }
            catch
            {
                return 0;
            }
        }

        public static int TryGetTotalPopulation()
        {
            if (MockEnabled) return MockPopulation;

            try
            {
                var worldType = CompatReflection.FindTypeByName("World");
                if (worldType == null) return -1;

                var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
                var worldField = worldType.GetField("world", flags);
                var worldObj = worldField != null ? worldField.GetValue(null) : null;
                if (worldObj == null) return -1;

                var v = ReadIntMember(worldObj, "population", "totalPopulation", "total_population");
                if (v >= 0) return v;

                var m = worldObj.GetType().GetMethod("getPopulation", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (m != null)
                {
                    var o = m.Invoke(worldObj, null);
                    return Convert.ToInt32(o);
                }

                return -1;
            }
            catch
            {
                return -1;
            }
        }

        public static int TryGetCityCount()
        {
            if (MockEnabled) return MockCities;

            try
            {
                var worldType = CompatReflection.FindTypeByName("World");
                if (worldType == null) return -1;

                var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
                var worldField = worldType.GetField("world", flags);
                var worldObj = worldField != null ? worldField.GetValue(null) : null;
                if (worldObj == null) return -1;

                var v = ReadIntMember(worldObj, "citiesCount", "cityCount", "cities_count");
                if (v >= 0) return v;

                var citiesObj = ReadObjectMember(worldObj, "cities", "list_cities");
                if (citiesObj is ICollection col) return col.Count;
                if (citiesObj is IEnumerable en)
                {
                    var c = 0;
                    var it = en.GetEnumerator();
                    while (it.MoveNext()) c++;
                    return c;
                }

                return -1;
            }
            catch
            {
                return -1;
            }
        }

        public static int TryGetHeroCount()
        {
            if (MockEnabled) return MockHeroes;

            try
            {
                var worldType = CompatReflection.FindTypeByName("World");
                if (worldType == null) return -1;

                var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
                var worldField = worldType.GetField("world", flags);
                var worldObj = worldField != null ? worldField.GetValue(null) : null;
                if (worldObj == null) return -1;

                var v = ReadIntMember(worldObj, "heroesCount", "heroCount", "heroes_count");
                if (v >= 0) return v;

                return -1;
            }
            catch
            {
                return -1;
            }
        }

        public static int TryGetTechLevel()
        {
            if (MockEnabled) return MockTechLevel;

            try
            {
                var worldType = CompatReflection.FindTypeByName("World");
                if (worldType == null) return -1;

                var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
                var worldField = worldType.GetField("world", flags);
                var worldObj = worldField != null ? worldField.GetValue(null) : null;
                if (worldObj == null) return -1;

                var v = ReadIntMember(worldObj, "techLevel", "tech_level", "tech");
                if (v >= 0) return v;

                return -1;
            }
            catch
            {
                return -1;
            }
        }

        private static object ReadObjectMember(object obj, params string[] names)
        {
            if (obj == null || names == null) return null;

            var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;
            for (var i = 0; i < names.Length; i++)
            {
                var n = names[i];
                if (string.IsNullOrEmpty(n)) continue;

                var f = obj.GetType().GetField(n, flags);
                if (f != null) return f.GetValue(obj);

                var p = obj.GetType().GetProperty(n, flags);
                if (p != null && p.CanRead) return p.GetValue(obj, null);
            }

            return null;
        }

        private static int ReadIntMember(object obj, params string[] names)
        {
            try
            {
                var o = ReadObjectMember(obj, names);
                if (o == null) return -1;
                return Convert.ToInt32(o);
            }
            catch
            {
                return -1;
            }
        }

        private static long ReadLongMember(object obj, params string[] names)
        {
            try
            {
                var o = ReadObjectMember(obj, names);
                if (o == null) return 0;
                return Convert.ToInt64(o);
            }
            catch
            {
                return 0;
            }
        }
    }
}
