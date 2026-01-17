using System;
using System.Collections.Generic;
using EraOfWheel.Core.Events;

namespace EraOfWheel.Core
{
    public class EventBus : IModSystem
    {
        public static EventBus Instance { get; private set; }
        
        public string SystemName => "EventBus";
        public bool IsInitialized { get; private set; }

        private readonly Dictionary<Type, List<Delegate>> _handlers = new Dictionary<Type, List<Delegate>>();
        private readonly Queue<IGameEvent> _asyncQueue = new Queue<IGameEvent>();
        private readonly object _lock = new object();

        public void Initialize()
        {
            if (IsInitialized) return;
            Instance = this;
            IsInitialized = true;
            Logger.Info(SystemName, "EventBus initialized");
        }

        public void Subscribe<T>(Action<T> handler) where T : IGameEvent
        {
            var type = typeof(T);
            lock (_lock)
            {
                if (!_handlers.ContainsKey(type))
                {
                    _handlers[type] = new List<Delegate>();
                }
                _handlers[type].Add(handler);
            }
            Logger.Debug(SystemName, $"Subscribed to {type.Name}");
        }

        public void Unsubscribe<T>(Action<T> handler) where T : IGameEvent
        {
            var type = typeof(T);
            lock (_lock)
            {
                if (_handlers.ContainsKey(type))
                {
                    _handlers[type].Remove(handler);
                }
            }
        }

        public void Publish<T>(T gameEvent) where T : IGameEvent
        {
            var type = typeof(T);
            List<Delegate> handlers;
            
            lock (_lock)
            {
                if (!_handlers.ContainsKey(type)) return;
                handlers = new List<Delegate>(_handlers[type]);
            }

            foreach (var handler in handlers)
            {
                try
                {
                    ((Action<T>)handler)(gameEvent);
                }
                catch (Exception ex)
                {
                    Logger.Error(SystemName, $"Error handling event {gameEvent.EventName}", ex);
                }
            }
        }

        public void PublishAsync<T>(T gameEvent) where T : IGameEvent
        {
            lock (_lock)
            {
                _asyncQueue.Enqueue(gameEvent);
            }
        }

        public void ProcessQueue(int maxEvents = 10)
        {
            var processed = 0;
            while (processed < maxEvents)
            {
                IGameEvent gameEvent;
                lock (_lock)
                {
                    if (_asyncQueue.Count == 0) break;
                    gameEvent = _asyncQueue.Dequeue();
                }
                
                var type = gameEvent.GetType();
                List<Delegate> handlers;
                
                lock (_lock)
                {
                    if (!_handlers.ContainsKey(type)) continue;
                    handlers = new List<Delegate>(_handlers[type]);
                }

                foreach (var handler in handlers)
                {
                    try
                    {
                        handler.DynamicInvoke(gameEvent);
                    }
                    catch (Exception ex)
                    {
                        Logger.Error(SystemName, $"Error handling async event {gameEvent.EventName}", ex);
                    }
                }
                processed++;
            }
        }

        public void Dispose()
        {
            lock (_lock)
            {
                _handlers.Clear();
                _asyncQueue.Clear();
            }
            IsInitialized = false;
            Instance = null;
            Logger.Info(SystemName, "EventBus disposed");
        }
    }
}
