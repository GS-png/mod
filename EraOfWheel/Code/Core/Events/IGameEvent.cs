using System;

namespace EraOfWheel.Core.Events
{
    /// <summary>
    /// 游戏事件接口，所有事件必须实现此接口
    /// </summary>
    public interface IGameEvent
    {
        /// <summary>
        /// 事件唯一标识符
        /// </summary>
        string EventId { get; }
        
        /// <summary>
        /// 事件触发时间戳
        /// </summary>
        DateTime Timestamp { get; }
    }
}
