using System;
using System.Reflection;
using EraWheel.Core;

namespace EraWheel.DemonLord
{
    public class SpawnSystem
    {
        public bool TrySpawnPlaceholder(string demonId)
        {
            try
            {
                var assetManagerType = CompatReflection.FindTypeByName("AssetManager");
                if (assetManagerType == null)
                {
                    return false;
                }

                var unitStatsField = assetManagerType.GetField("unitStats", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
                var unitStatsObj = unitStatsField != null ? unitStatsField.GetValue(null) : null;
                if (unitStatsObj == null) return false;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public void LogSpawnAttempt(string demonId)
        {
            try
            {
                Log.Info("[EraWheel] Spawn placeholder demon: " + demonId);
            }
            catch
            {
            }
        }
    }
}
