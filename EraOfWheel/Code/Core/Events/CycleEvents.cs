namespace EraOfWheel.Core.Events
{
    public class PhaseChangedEvent : GameEvent
    {
        public override string EventName => "PhaseChanged";
        public string PreviousPhase { get; set; }
        public string CurrentPhase { get; set; }
        public int CycleCount { get; set; }
    }

    public class CycleCompletedEvent : GameEvent
    {
        public override string EventName => "CycleCompleted";
        public int CycleCount { get; set; }
        public string SealMethod { get; set; }
    }

    public class SealStrengthChangedEvent : GameEvent
    {
        public override string EventName => "SealStrengthChanged";
        public string DemonLordId { get; set; }
        public float PreviousStrength { get; set; }
        public float CurrentStrength { get; set; }
    }

    public class CycleFailureDecisionRequestedEvent : GameEvent
    {
        public override string EventName => "CycleFailureDecisionRequested";
        public string Reason { get; set; }
        public int CycleCount { get; set; }
        public bool CanRestartCycle { get; set; }
    }

    public class CycleFailureResolvedEvent : GameEvent
    {
        public override string EventName => "CycleFailureResolved";
        public string Reason { get; set; }
        public int CycleCount { get; set; }
        public string Choice { get; set; }
    }

    public class TerminalAftermathEnteredEvent : GameEvent
    {
        public override string EventName => "TerminalAftermathEntered";
        public string Reason { get; set; }
        public int CycleCount { get; set; }
    }

    public class TerminalAftermathTickEvent : GameEvent
    {
        public override string EventName => "TerminalAftermathTick";
        public int CycleCount { get; set; }
        public int WorldYear { get; set; }
    }
}
