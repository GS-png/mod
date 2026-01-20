using System;

namespace EraWheel.Core
{
    public enum EraPhase
    {
        Sealed,
        Omen,
        Awakening,
        Invasion,
        Peak,
        Weakening,
        Resealed
    }

    public enum DemonLordState
    {
        Disabled,
        Sealed,
        Awakening,
        Active,
        Peak,
        Weakened,
        Defeated
    }

    public enum GeneralState
    {
        Inactive,
        Active,
        Retreating,
        Defeated,
        Betrayed
    }

    [Serializable]
    public struct PhaseChangedEvent
    {
        public EraPhase PreviousPhase;
        public EraPhase NewPhase;
        public long WorldTime;
        public string TriggerReason;
    }

    [Serializable]
    public struct DemonLordStateChangedEvent
    {
        public string DemonLordId;
        public DemonLordState PreviousState;
        public DemonLordState NewState;
        public long WorldTime;
    }

    [Serializable]
    public struct GeneralBetrayedEvent
    {
        public string DemonLordId;
        public string GeneralId;
        public int DefeatCount;
        public long WorldTime;
    }

    [Serializable]
    public struct DemonKillEvent
    {
        public int Count;
        public long WorldTime;
    }

    [Serializable]
    public struct AntiDemonLevelChangedEvent
    {
        public int PreviousLevel;
        public int NewLevel;
        public int DemonKillCount;
        public long WorldTime;
    }

    [Serializable]
    public struct AllianceFormedEvent
    {
        public long WorldTime;
        public float DestroyedCityPercent;
    }

    [Serializable]
    public struct AllianceCouncilEvent
    {
        public long WorldTime;
        public int CouncilIndex;
    }

    [Serializable]
    public struct AllianceSealProgressEvent
    {
        public long WorldTime;
        public float Progress;
    }

    [Serializable]
    public struct CycleSummary
    {
        public int CycleNumber;
        public EraPhase EndPhase;
        public long WorldTime;
        public string[] KeyEvents;
    }

    [Serializable]
    public struct CycleCompletedEvent
    {
        public int CycleNumber;
        public CycleSummary Summary;
    }
}
