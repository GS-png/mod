using System;

namespace EraOfWheel.Core.Events
{
    /// <summary>
    /// 游戏事件基类
    /// </summary>
    public abstract class GameEvent : IGameEvent
    {
        public string EventId { get; }
        public DateTime Timestamp { get; }

        protected GameEvent()
        {
            EventId = Guid.NewGuid().ToString("N").Substring(0, 8);
            Timestamp = DateTime.UtcNow;
        }

        public override string ToString()
        {
            return $"[{GetType().Name}] Id={EventId} Time={Timestamp:HH:mm:ss}";
        }
    }
}
