using System;
using EraOfWheel.Core;
using EraOfWheel.Core.Events;

namespace EraOfWheel.Cycle
{
    /// <summary>
    /// 轮回管理器 - 控制纪元阶段和轮回循环
    /// </summary>
    public class CycleManager : IModSystem
    {
        public static CycleManager Instance { get; private set; }
        
        public string SystemName => "CycleManager";
        public bool IsInitialized { get; private set; }

        public CycleState State { get; private set; }

        public void Initialize()
        {
            if (IsInitialized) return;

            Instance = this;
            State = new CycleState();
            
            IsInitialized = true;
            Logger.Info(SystemName, "轮回系统初始化完成");
        }

        /// <summary>
        /// 开始新轮回
        /// </summary>
        public void StartCycle()
        {
            State.StartNewCycle();
            Logger.Info(SystemName, $"轮回 #{State.cycleNumber} 开始");
            
            EventBus.Instance?.Publish(new CycleStartedEvent(State.cycleNumber));
        }

        /// <summary>
        /// 更新轮回进度
        /// </summary>
        public void Update(float deltaTime)
        {
            if (!State.isActive) return;

            State.phaseProgress += deltaTime;

            if (State.IsPhaseComplete)
            {
                AdvancePhase();
            }
        }

        /// <summary>
        /// 推进到下一阶段
        /// </summary>
        private void AdvancePhase()
        {
            var oldPhase = State.currentPhase;
            var nextPhase = State.NextPhase;

            if (nextPhase == null)
            {
                EndCycle();
                return;
            }

            State.currentPhase = nextPhase.Value;
            State.phaseProgress = 0f;
            State.phaseTarget = CyclePhaseConfig.GetPhaseDuration(State.currentPhase);

            Logger.Info(SystemName, $"阶段转换: {CyclePhaseConfig.GetPhaseName(oldPhase)} → {CyclePhaseConfig.GetPhaseName(State.currentPhase)}");
            
            EventBus.Instance?.Publish(new PhaseChangedEvent(oldPhase, State.currentPhase));
        }

        /// <summary>
        /// 结束当前轮回
        /// </summary>
        public void EndCycle()
        {
            State.isActive = false;
            Logger.Info(SystemName, $"轮回 #{State.cycleNumber} 结束");
            
            EventBus.Instance?.Publish(new CycleEndedEvent(State.cycleNumber));
        }

        /// <summary>
        /// 强制设置阶段（调试用）
        /// </summary>
        public void SetPhase(CyclePhase phase)
        {
            var oldPhase = State.currentPhase;
            State.currentPhase = phase;
            State.phaseProgress = 0f;
            State.phaseTarget = CyclePhaseConfig.GetPhaseDuration(phase);
            
            EventBus.Instance?.Publish(new PhaseChangedEvent(oldPhase, phase));
        }

        public void Dispose()
        {
            Instance = null;
            IsInitialized = false;
        }
    }

    // 轮回相关事件
    public class CycleStartedEvent : GameEvent
    {
        public int CycleNumber { get; }
        public CycleStartedEvent(int number) => CycleNumber = number;
    }

    public class CycleEndedEvent : GameEvent
    {
        public int CycleNumber { get; }
        public CycleEndedEvent(int number) => CycleNumber = number;
    }

    public class PhaseChangedEvent : GameEvent
    {
        public CyclePhase OldPhase { get; }
        public CyclePhase NewPhase { get; }
        public PhaseChangedEvent(CyclePhase old, CyclePhase @new)
        {
            OldPhase = old;
            NewPhase = @new;
        }
    }
}
