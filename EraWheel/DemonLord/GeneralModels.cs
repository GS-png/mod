using System;
using EraWheel.Core;

namespace EraWheel.DemonLord
{
    public enum GeneralRole
    {
        Vanguard,
        Tank,
        DPS,
        Support,
        Elite
    }

    [Serializable]
    public class GeneralTemplate
    {
        public string DemonLordId;
        public string Id;
        public GeneralRole Role = GeneralRole.Elite;
        public int MinCycle;
    }

    [Serializable]
    public class GeneralRuntime
    {
        public string DemonLordId;
        public string Id;
        public GeneralRole Role = GeneralRole.Elite;

        public GeneralState State = GeneralState.Inactive;
        public int DefeatCount;
        public long NextRespawnWorldAge = -1;

        public bool IsActive
        {
            get
            {
                return State == GeneralState.Active || State == GeneralState.Retreating;
            }
        }
    }
}
