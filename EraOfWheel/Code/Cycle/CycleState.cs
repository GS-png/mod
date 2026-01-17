using System;

namespace EraOfWheel.Cycle
{
    /// <summary>
    /// 轮回状态
    /// </summary>
    [Serializable]
    public class CycleState
    {
        public int cycleNumber = 1;
        public CyclePhase currentPhase = CyclePhase.Germination;
        public float phaseProgress = 0f;
        public float phaseTarget = 100f;
        public bool isActive = false;
        public DateTime cycleStartTime;

        public float ProgressPercent => phaseTarget > 0 ? phaseProgress / phaseTarget * 100f : 0f;

        public bool IsPhaseComplete => phaseProgress >= phaseTarget;

        public CyclePhase? NextPhase => currentPhase switch
        {
            CyclePhase.Germination => CyclePhase.Growth,
            CyclePhase.Growth => CyclePhase.Prosperity,
            CyclePhase.Prosperity => CyclePhase.Decline,
            CyclePhase.Decline => CyclePhase.Extinction,
            CyclePhase.Extinction => null, // 轮回结束
            _ => null
        };

        public void Reset()
        {
            currentPhase = CyclePhase.Germination;
            phaseProgress = 0f;
            phaseTarget = CyclePhaseConfig.GetPhaseDuration(CyclePhase.Germination);
            isActive = false;
        }

        public void StartNewCycle()
        {
            cycleNumber++;
            Reset();
            isActive = true;
            cycleStartTime = DateTime.UtcNow;
        }
    }
}
