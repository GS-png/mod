namespace EraOfWheel.Core.Events
{
    public class DemonStateChangedEvent : GameEvent
    {
        public override string EventName => "DemonStateChanged";
        public string DemonLordId { get; set; }
        public string PreviousState { get; set; }
        public string CurrentState { get; set; }
    }

    public class DemonAwakeningEvent : GameEvent
    {
        public override string EventName => "DemonAwakening";
        public string DemonLordId { get; set; }
        public string DemonName { get; set; }
        public float PowerLevel { get; set; }
    }

    public class DemonSealedEvent : GameEvent
    {
        public override string EventName => "DemonSealed";
        public string DemonLordId { get; set; }
        public string SealMethod { get; set; }
        public int CycleCount { get; set; }
    }

    public class LegionWaveSpawnedEvent : GameEvent
    {
        public override string EventName => "LegionWaveSpawned";
        public string DemonLordId { get; set; }
        public int WaveNumber { get; set; }
        public int UnitCount { get; set; }
    }
}
