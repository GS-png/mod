using System;
using System.Collections.Generic;
using EraOfWheel.Core.Events;
using UnityEngine;

namespace EraOfWheel.Core
{
    /// <summary>
    /// 事件总线 - 实现解耦的事件发布/订阅机制
    /// </summary>
    public class EventBus : IModSystem
    {
        public static EventBus Instance { get; private set; }
        
        public string SystemName => "EventBus";
        public bool IsInitialized { get; private set; }

        private readonly Dictionary<Type, List<Delegate>> _handlers = new Dictionary<Type, List<Delegate>>();
        private readonly Queue<IGameEvent> _eventQueue = new Queue<IGameEvent>();
        private readonly object _lock = new object();

        public void Initialize()
        {
            if (IsInitialized) return;
            
            Instance = this;
            IsInitialized = true;
            ModMain.Log($"[{SystemName}] 初始化完成");
        }

        /// <summary>
        /// 订阅事件
        /// </summary>
        public IDisposable Subscribe<T>(Action<T> handler) where T : IGameEvent
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            var eventType = typeof(T);
            
            lock (_lock)
            {
                if (!_handlers.ContainsKey(eventType))
                {
                    _handlers[eventType] = new List<Delegate>();
                }
                _handlers[eventType].Add(handler);
            }

            ModMain.Log($"[{SystemName}] 订阅事件: {eventType.Name}", ModMain.LogLevel.Debug);
            
            return new Subscription(() => Unsubscribe(handler));
        }

        /// <summary>
        /// 取消订阅事件
        /// </summary>
        public void Unsubscribe<T>(Action<T> handler) where T : IGameEvent
        {
            if (handler == null) return;

            var eventType = typeof(T);
            
            lock (_lock)
            {
                if (_handlers.TryGetValue(eventType, out var handlers))
                {
                    handlers.Remove(handler);
                    if (handlers.Count == 0)
                    {
                        _handlers.Remove(eventType);
                    }
                }
            }
        }

        /// <summary>
        /// 发布事件（同步）
        /// </summary>
        public void Publish<T>(T gameEvent) where T : IGameEvent
        {
            if (gameEvent == null) throw new ArgumentNullException(nameof(gameEvent));

            var eventType = typeof(T);
            List<Delegate> handlersCopy;

            lock (_lock)
            {
                if (!_handlers.TryGetValue(eventType, out var handlers) || handlers.Count == 0)
                {
                    return;
                }
                handlersCopy = new List<Delegate>(handlers);
            }

            ModMain.Log($"[{SystemName}] 发布事件: {gameEvent}", ModMain.LogLevel.Debug);

            foreach (var handler in handlersCopy)
            {
                try
                {
                    ((Action<T>)handler)?.Invoke(gameEvent);
                }
                catch (Exception ex)
                {
                    ModMain.Log($"[{SystemName}] 事件处理器异常: {ex.Message}", ModMain.LogLevel.Error);
                }
            }
        }

        /// <summary>
        /// 发布事件（异步，加入队列）
        /// </summary>
        public void PublishAsync<T>(T gameEvent) where T : IGameEvent
        {
            if (gameEvent == null) throw new ArgumentNullException(nameof(gameEvent));

            lock (_lock)
            {
                _eventQueue.Enqueue(gameEvent);
            }
        }

        /// <summary>
        /// 处理队列中的事件（每帧调用）
        /// </summary>
        public void ProcessQueue(int maxEvents = 10)
        {
            int processed = 0;
            
            while (processed < maxEvents)
            {
                IGameEvent gameEvent;
                
                lock (_lock)
                {
                    if (_eventQueue.Count == 0) break;
                    gameEvent = _eventQueue.Dequeue();
                }

                var eventType = gameEvent.GetType();
                var method = typeof(EventBus).GetMethod("Publish").MakeGenericMethod(eventType);
                method.Invoke(this, new object[] { gameEvent });
                
                processed++;
            }
        }

        /// <summary>
        /// 清理所有订阅
        /// </summary>
        public void ClearAll()
        {
            lock (_lock)
            {
                _handlers.Clear();
                _eventQueue.Clear();
            }
            ModMain.Log($"[{SystemName}] 已清理所有订阅");
        }

        public void Dispose()
        {
            ClearAll();
            Instance = null;
            IsInitialized = false;
        }

        /// <summary>
        /// 订阅包装器，用于自动取消订阅
        /// </summary>
        private class Subscription : IDisposable
        {
            private Action _unsubscribe;

            public Subscription(Action unsubscribe)
            {
                _unsubscribe = unsubscribe;
            }

            public void Dispose()
            {
                _unsubscribe?.Invoke();
                _unsubscribe = null;
            }
        }
    }
}
