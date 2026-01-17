using System;

namespace EraOfWheel.Cycle
{
    [Serializable]
    public class CycleState
    {
        public int CycleCount { get; set; } = 1;
        public CyclePhase CurrentPhase { get; set; } = CyclePhase.Sealed;
        public int WorldAgeYears { get; set; } = 0;
        public int PhaseStartYear { get; set; } = 0;
        public int InvasionStartYear { get; set; } = 0;
        public string ActiveDemonLordId { get; set; } = "";
        
        public int YearsInCurrentPhase => WorldAgeYears - PhaseStartYear;
        public int YearsInInvasion => InvasionStartYear > 0 ? WorldAgeYears - InvasionStartYear : 0;

        public void TransitionTo(CyclePhase newPhase)
        {
            PhaseStartYear = WorldAgeYears;
            CurrentPhase = newPhase;

            if (newPhase == CyclePhase.Invasion)
            {
                InvasionStartYear = WorldAgeYears;
            }
            else if (newPhase == CyclePhase.Resealed)
            {
                InvasionStartYear = 0;
            }
        }

        public void IncrementCycle()
        {
            CycleCount++;
        }

        public void Reset(float legacyKeepRatio)
        {
            CurrentPhase = CyclePhase.Sealed;
            PhaseStartYear = WorldAgeYears;
            InvasionStartYear = 0;
            ActiveDemonLordId = "";
        }
    }
}
