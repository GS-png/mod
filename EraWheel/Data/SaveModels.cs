using System;
using System.Collections.Generic;
using EraWheel.Core;
using EraWheel.Civilization;
using EraWheel.DemonLord;
using EraWheel.Narrative;
using EraWheel.Narrative.AI;
using HeroSaveData = EraWheel.Civilization.HeroSaveData;

namespace EraWheel.Data
{
    [Serializable]
    public class ModSaveData
    {
        public string ModVersion = "1.0.0";
        public CycleData CycleData = new CycleData();
        public DemonLordSaveData[] DemonLordData = new DemonLordSaveData[0];
        public GeneralSaveData[] GeneralData = new GeneralSaveData[0];
        public CivilizationSaveData Civilization = new CivilizationSaveData();
        public AllianceSaveData Alliance = new AllianceSaveData();
        public HeroSaveData Hero = new HeroSaveData();
        public CycleSummary[] CycleHistory = new CycleSummary[0];
        public LegacyData Legacy = new LegacyData();
        public EventPoolSaveData EventPool;
        public AIOperationLogSaveData AIOperationLog;
    }

    [Serializable]
    public class CycleData
    {
        public int CycleCount;
        public EraPhase CurrentPhase = EraPhase.Sealed;
        public float SealStrength = 100f;

        public long PhaseStartWorldAge;

        public int OmenTargetYears = 30;
        public int AwakeningTargetYears = 20;

        public float DemonHealthPercent = 100f;
    }

    [Serializable]
    public class DemonLordSaveData
    {
        public string Id;
        public bool Enabled;
        public DemonLordState State = DemonLordState.Sealed;
        public float CurrentHealth;
        public int KillCount;
        public string[] ActiveGenerals = new string[0];
    }

    [Serializable]
    public class GeneralSaveData
    {
        public string DemonLordId;
        public string Id;
        public GeneralRole Role;
        public GeneralState State;
        public int DefeatCount;
        public long NextRespawnWorldAge;
    }

    [Serializable]
    public class CivilizationSaveData
    {
        public int DemonKillCount;
        public int AntiDemonLevel;
        public float CSI;
    }

    [Serializable]
    public class LegacyData
    {
        public string[] Keys = new string[0];
        public int[] Values = new int[0];

        public void Set(string key, int value)
        {
            if (string.IsNullOrEmpty(key)) return;
            var dict = ToDictionary();
            dict[key] = value;
            FromDictionary(dict);
        }

        public int Get(string key, int defaultValue = 0)
        {
            if (string.IsNullOrEmpty(key)) return defaultValue;
            var dict = ToDictionary();
            return dict.TryGetValue(key, out var v) ? v : defaultValue;
        }

        private Dictionary<string, int> ToDictionary()
        {
            var d = new Dictionary<string, int>();
            if (Keys == null || Values == null) return d;
            var n = Math.Min(Keys.Length, Values.Length);
            for (var i = 0; i < n; i++)
            {
                var k = Keys[i];
                if (string.IsNullOrEmpty(k)) continue;
                d[k] = Values[i];
            }

            return d;
        }

        private void FromDictionary(Dictionary<string, int> d)
        {
            if (d == null)
            {
                Keys = new string[0];
                Values = new int[0];
                return;
            }

            Keys = new string[d.Count];
            Values = new int[d.Count];
            var i = 0;
            foreach (var kv in d)
            {
                Keys[i] = kv.Key;
                Values[i] = kv.Value;
                i++;
            }
        }
    }
}
