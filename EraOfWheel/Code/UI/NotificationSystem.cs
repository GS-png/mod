using System;
using System.Collections.Generic;
using EraOfWheel.Core;
using EraOfWheel.Core.Config;
using EraOfWheel.Core.Events;

namespace EraOfWheel.UI
{
    public class Notification
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public float Duration { get; set; }
        public float TimeRemaining { get; set; }
        public NotificationType Type { get; set; }
    }

    public enum NotificationType
    {
        Info,
        Warning,
        Critical,
        Success
    }

    public class NotificationSystem : IModSystem
    {
        public static NotificationSystem Instance { get; private set; }
        
        public string SystemName => "NotificationSystem";
        public bool IsInitialized { get; private set; }
        
        private Queue<Notification> _queue = new Queue<Notification>();
        private List<Notification> _activeNotifications = new List<Notification>();
        private int _maxActive = 3;
        private float _defaultDuration;

        public IReadOnlyList<Notification> ActiveNotifications => _activeNotifications;

        public void Initialize()
        {
            if (IsInitialized) return;
            
            Instance = this;
            _defaultDuration = ConfigManager.Instance?.Config?.ui?.notification_duration_seconds ?? 5f;
            
            SubscribeToEvents();
            
            IsInitialized = true;
            Logger.Info(SystemName, "NotificationSystem initialized");
        }

        private void SubscribeToEvents()
        {
            EventBus.Instance?.Subscribe<PhaseChangedEvent>(OnPhaseChanged);
            EventBus.Instance?.Subscribe<DemonAwakeningEvent>(OnDemonAwakening);
            EventBus.Instance?.Subscribe<DemonSealedEvent>(OnDemonSealed);
            EventBus.Instance?.Subscribe<LegionWaveSpawnedEvent>(OnLegionWave);
        }

        private void OnPhaseChanged(PhaseChangedEvent e)
        {
            Show("阶段转换", $"进入{e.CurrentPhase}阶段", NotificationType.Info);
        }

        private void OnDemonAwakening(DemonAwakeningEvent e)
        {
            Show("魔王苏醒", $"{e.DemonName}已苏醒！", NotificationType.Critical);
        }

        private void OnDemonSealed(DemonSealedEvent e)
        {
            Show("魔王封印", $"魔王已被封印！(方式: {e.SealMethod})", NotificationType.Success);
        }

        private void OnLegionWave(LegionWaveSpawnedEvent e)
        {
            Show("军团来袭", $"第{e.WaveNumber}波军团已生成 ({e.UnitCount}单位)", NotificationType.Warning);
        }

        public void Show(string title, string message, NotificationType type = NotificationType.Info)
        {
            var notification = new Notification
            {
                Id = Guid.NewGuid().ToString(),
                Title = title,
                Message = message,
                Type = type,
                Duration = _defaultDuration,
                TimeRemaining = _defaultDuration
            };
            
            _queue.Enqueue(notification);
            Logger.Debug(SystemName, $"Notification queued: {title}");
        }

        public void Update(float deltaTime)
        {
            if (!IsInitialized) return;
            
            // Process queue
            while (_queue.Count > 0 && _activeNotifications.Count < _maxActive)
            {
                var notification = _queue.Dequeue();
                _activeNotifications.Add(notification);
                OnNotificationShow(notification);
            }
            
            // Update active notifications
            for (int i = _activeNotifications.Count - 1; i >= 0; i--)
            {
                var notification = _activeNotifications[i];
                notification.TimeRemaining -= deltaTime;
                
                if (notification.TimeRemaining <= 0)
                {
                    _activeNotifications.RemoveAt(i);
                    OnNotificationHide(notification);
                }
            }
        }

        private void OnNotificationShow(Notification notification)
        {
            // Note: Full implementation would show visual notification
            Logger.Info(SystemName, $"[{notification.Type}] {notification.Title}: {notification.Message}");
        }

        private void OnNotificationHide(Notification notification)
        {
            Logger.Debug(SystemName, $"Notification dismissed: {notification.Title}");
        }

        public void DismissAll()
        {
            _activeNotifications.Clear();
            _queue.Clear();
        }

        public void Dispose()
        {
            EventBus.Instance?.Unsubscribe<PhaseChangedEvent>(OnPhaseChanged);
            EventBus.Instance?.Unsubscribe<DemonAwakeningEvent>(OnDemonAwakening);
            EventBus.Instance?.Unsubscribe<DemonSealedEvent>(OnDemonSealed);
            EventBus.Instance?.Unsubscribe<LegionWaveSpawnedEvent>(OnLegionWave);
            
            DismissAll();
            IsInitialized = false;
            Instance = null;
            Logger.Info(SystemName, "NotificationSystem disposed");
        }
    }
}
