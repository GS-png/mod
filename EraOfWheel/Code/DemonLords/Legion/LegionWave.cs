using System;

namespace EraOfWheel.DemonLords.Legion
{
    public enum LegionType
    {
        Vanguard,
        Main,
        Siege,
        Ultimate
    }

    [Serializable]
    public class LegionWave
    {
        public int WaveNumber { get; set; }
        public LegionType Type { get; set; }
        public int BaseUnitCount { get; set; }
        public int UnitLevel { get; set; }
        public float EliteChance { get; set; }
        public int SpawnYear { get; set; }

        public static LegionWave Create(int waveNumber, int cycleCount, float powerMultiplier)
        {
            var wave = new LegionWave
            {
                WaveNumber = waveNumber,
                Type = DetermineLegionType(waveNumber),
                UnitLevel = 1 + (cycleCount - 1) + (waveNumber / 3),
                SpawnYear = 0
            };

            wave.BaseUnitCount = CalculateUnitCount(wave.Type, waveNumber, powerMultiplier);
            wave.EliteChance = waveNumber >= 7 ? 0.2f : 0.05f;

            return wave;
        }

        private static LegionType DetermineLegionType(int waveNumber)
        {
            if (waveNumber <= 2) return LegionType.Vanguard;
            if (waveNumber <= 5) return LegionType.Main;
            if (waveNumber <= 8) return LegionType.Siege;
            return LegionType.Ultimate;
        }

        private static int CalculateUnitCount(LegionType type, int waveNumber, float powerMultiplier)
        {
            int baseCount = type switch
            {
                LegionType.Vanguard => 20,
                LegionType.Main => 40,
                LegionType.Siege => 30,
                LegionType.Ultimate => 50,
                _ => 20
            };

            float waveMultiplier = 1f + (waveNumber * 0.1f);
            return (int)(baseCount * waveMultiplier * powerMultiplier);
        }

        public int GetActualUnitCount()
        {
            int eliteBonus = UnityEngine.Random.value < EliteChance ? (int)(BaseUnitCount * 0.2f) : 0;
            return BaseUnitCount + eliteBonus;
        }
    }
}
