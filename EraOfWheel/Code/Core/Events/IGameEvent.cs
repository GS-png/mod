namespace EraOfWheel.Core.Events
{
    public interface IGameEvent
    {
        string EventName { get; }
    }

    public abstract class GameEvent : IGameEvent
    {
        public abstract string EventName { get; }
    }
}
