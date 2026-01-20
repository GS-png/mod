using System;
using System.Collections.Generic;

namespace EraWheel.DemonLord
{
    public enum LegionTier
    {
        Vanguard,
        Main,
        Elite,
        Ultimate
    }

    [Serializable]
    public class LegionWaveState
    {
        public int CurrentWave;
        public long LastWaveWorldAge;
        public int TotalUnitsSpawned;
        public int AliveUnits;
        public bool EverSpawnedUltimate;
        public List<string> ActiveUnitIds = new List<string>();

        public void Reset()
        {
            CurrentWave = 0;
            LastWaveWorldAge = -1;
            TotalUnitsSpawned = 0;
            AliveUnits = 0;
            EverSpawnedUltimate = false;
            if (ActiveUnitIds != null) ActiveUnitIds.Clear();
        }
    }

    [Serializable]
    public class LegionConfig
    {
        public int WaveIntervalYears = 10;
        public int BaseUnitsPerWave = 30;
        public float WaveGrowthRate = 0.15f;
        public int MaxUnitsPerWave = 100;
        public int MaxAliveUnits = 200;
        public float EliteRate = 0.1f;
    }
}
