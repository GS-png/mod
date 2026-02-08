using System;
using EraWheel.Civilization;
using EraWheel.Core;
using EraWheel.Narrative;
using EraWheel.Narrative.AI;

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
            if (data.EventPool == null) data.EventPool = CreateEmptyEventPool();
            if (data.AIOperationLog == null) data.AIOperationLog = CreateEmptyAIOperationLog();

            EnsureCycleDefaults(data.CycleData);
            EnsureDemonDefaults(data.DemonLordData);
            EnsureLegacyDefaults(data.Legacy);

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

        private static void EnsureCycleDefaults(CycleData data)
        {
            if (data == null) return;

            if (data.SealStrength < 0f) data.SealStrength = 0f;
            if (data.SealStrength > 100f) data.SealStrength = 100f;
            if (data.OmenTargetYears <= 0) data.OmenTargetYears = 30;
            if (data.AwakeningTargetYears <= 0) data.AwakeningTargetYears = 20;
            if (data.DemonHealthPercent < 0f) data.DemonHealthPercent = 0f;
            if (data.DemonHealthPercent > 100f) data.DemonHealthPercent = 100f;
        }

        private static void EnsureDemonDefaults(DemonLordSaveData[] data)
        {
            if (data == null) return;

            for (var i = 0; i < data.Length; i++)
            {
                var entry = data[i];
                if (entry == null) continue;
                if (entry.ActiveGenerals == null) entry.ActiveGenerals = new string[0];
            }
        }

        private static void EnsureLegacyDefaults(LegacyData data)
        {
            if (data == null) return;
            if (data.Keys == null) data.Keys = new string[0];
            if (data.Values == null) data.Values = new int[0];
        }

        private static EventPoolSaveData CreateEmptyEventPool()
        {
            return new EventPoolSaveData
            {
                Cooldowns = new CooldownEntry[0],
                TriggerCounts = new TriggerCountEntry[0],
                RecentHistory = new TriggeredEventRecord[0]
            };
        }

        private static AIOperationLogSaveData CreateEmptyAIOperationLog()
        {
            return new AIOperationLogSaveData
            {
                Operations = new AIOperation[0]
            };
        }
    }
}
