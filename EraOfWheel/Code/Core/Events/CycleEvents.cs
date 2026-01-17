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
}
