using System;
using EraWheel.Civilization;
using EraWheel.Core;

namespace EraWheel.Data
{
    public static class MigrationManager
    {
        public static ModSaveData Migrate(ModSaveData data, string targetVersion)
        {
            if (data == null) return null;
            if (string.IsNullOrEmpty(targetVersion)) return data;

            if (data.CycleData == null) data.CycleData = new CycleData();
            if (data.DemonLordData == null) data.DemonLordData = new DemonLordSaveData[0];
            if (data.GeneralData == null) data.GeneralData = new GeneralSaveData[0];
            if (data.Civilization == null) data.Civilization = new CivilizationSaveData();
            if (data.Alliance == null) data.Alliance = new AllianceSaveData();
            if (data.Hero == null) data.Hero = new HeroSaveData();
            if (data.CycleHistory == null) data.CycleHistory = new CycleSummary[0];
            if (data.Legacy == null) data.Legacy = new LegacyData();

            data.ModVersion = targetVersion;
            return data;
        }

        public static bool NeedsMigration(ModSaveData data, string targetVersion)
        {
            if (data == null) return false;
            if (string.IsNullOrEmpty(targetVersion)) return false;
            if (string.IsNullOrEmpty(data.ModVersion)) return true;

            try
            {
                var from = new Version(data.ModVersion);
                var to = new Version(targetVersion);
                return from != to;
            }
            catch
            {
                return true;
            }
        }
    }
}
