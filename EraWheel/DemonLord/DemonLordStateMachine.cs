using EraWheel.Core;

namespace EraWheel.DemonLord
{
    public static class DemonLordStateMachine
    {
        public static DemonLordState ComputeState(bool enabled, EraPhase eraPhase, float healthPercent)
        {
            if (!enabled) return DemonLordState.Disabled;

            if (eraPhase == EraPhase.Sealed || eraPhase == EraPhase.Omen)
            {
                return DemonLordState.Sealed;
            }

            if (eraPhase == EraPhase.Awakening)
            {
                return DemonLordState.Awakening;
            }

            if (eraPhase == EraPhase.Resealed)
            {
                return DemonLordState.Defeated;
            }

            if (healthPercent <= 0f) return DemonLordState.Defeated;
            if (healthPercent < 30f) return DemonLordState.Weakened;
            if (healthPercent > 70f) return DemonLordState.Peak;
            return DemonLordState.Active;
        }
    }
}
