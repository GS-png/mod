using System;

namespace EraWheel.Civilization
{
    [Serializable]
    public class AntiDemonAllianceState
    {
        public bool Formed;
        public long FormWorldAge;

        public int CycleStartCities = -1;

        public int CouncilCount;
        public long LastCouncilWorldAge = -1;

        public float SealProgress;
    }

    [Serializable]
    public class AllianceSaveData
    {
        public bool Formed;
        public long FormWorldAge;
        public int CycleStartCities;
        public int CouncilCount;
        public long LastCouncilWorldAge;
        public float SealProgress;
    }
}
