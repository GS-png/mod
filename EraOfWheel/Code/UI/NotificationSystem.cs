using System;
using System.Collections.Generic;
using EraOfWheel.Core;
using EraOfWheel.Core.Events;
using UnityEngine;
using UnityEngine.UI;

namespace EraOfWheel.UI
{
    /// <summary>
    /// 通知系统 - 游戏内消息提示
    /// </summary>
    public class NotificationSystem : IModSystem
    {
        public static NotificationSystem Instance { get; private set; }
        
        public string SystemName => "NotificationSystem";
        public bool IsInitialized { get; private set; }

        private Queue<Notification> _pendingNotifications = new Queue<Notification>();
        private List<Notification> _history = new List<Notification>();
        private Notification _currentNotification;
        private float _displayTime = 0f;
        private int _maxHistory = 50;

        public IReadOnlyList<Notification> History => _history;

        public void Initialize()
        {
            if (IsInitialized) return;

            Instance = this;
            SubscribeEvents();
            
            IsInitialized = true;
            Logger.Info(SystemName, "通知系统初始化完成");
        }

        private void SubscribeEvents()
        {
            EventBus.Instance?.Subscribe<PhaseChangedEvent>(e => 
                Show($"纪元阶段变化: {e.NewPhase}", NotificationPriority.High));
            
            EventBus.Instance?.Subscribe<DemonLords.DemonLordAwakenedEvent>(e => 
                Show($"⚠️ {e.DemonLord.Name}已苏醒！", NotificationPriority.Critical));
            
            EventBus.Instance?.Subscribe<LegacyEarnedEvent>(e => 
                Show($"获得遗产点: +{e.PointsEarned}", NotificationPriority.Normal));
        }

        /// <summary>
        /// 显示通知
        /// </summary>
        public void Show(string message, NotificationPriority priority = NotificationPriority.Normal)
        {
            var notification = new Notification
            {
                Id = Guid.NewGuid().ToString("N").Substring(0, 8),
                Message = message,
                Priority = priority,
                Timestamp = DateTime.UtcNow,
                Duration = GetDuration(priority)
            };

            if (priority == NotificationPriority.Critical)
            {
                // 关键通知立即显示
                DisplayNotification(notification);
            }
            else
            {
                _pendingNotifications.Enqueue(notification);
            }

            AddToHistory(notification);
            Logger.Debug(SystemName, $"通知: [{priority}] {message}");
        }

        /// <summary>
        /// 每帧更新
        /// </summary>
        public void Update(float deltaTime)
        {
            if (_currentNotification != null)
            {
                _displayTime += deltaTime;
                if (_displayTime >= _currentNotification.Duration)
                {
                    HideCurrentNotification();
                }
            }
            else if (_pendingNotifications.Count > 0)
            {
                DisplayNotification(_pendingNotifications.Dequeue());
            }
        }

        private void DisplayNotification(Notification notification)
        {
            _currentNotification = notification;
            _displayTime = 0f;
            
            // TODO: 更新UI显示
            EventBus.Instance?.Publish(new NotificationDisplayedEvent(notification));
        }

        private void HideCurrentNotification()
        {
            _currentNotification = null;
            _displayTime = 0f;
        }

        private float GetDuration(NotificationPriority priority)
        {
            var baseDuration = Core.Config.ConfigManager.Instance?.UI?.notification_duration ?? 5;
            
            return priority switch
            {
                NotificationPriority.Critical => baseDuration * 2f,
                NotificationPriority.High => baseDuration * 1.5f,
                NotificationPriority.Low => baseDuration * 0.5f,
                _ => baseDuration
            };
        }

        private void AddToHistory(Notification notification)
        {
            _history.Add(notification);
            if (_history.Count > _maxHistory)
            {
                _history.RemoveAt(0);
            }
        }

        public void ClearHistory()
        {
            _history.Clear();
        }

        public void Dispose()
        {
            _pendingNotifications.Clear();
            _history.Clear();
            Instance = null;
            IsInitialized = false;
        }
    }

    public enum NotificationPriority
    {
        Low,
        Normal,
        High,
        Critical
    }

    public class Notification
    {
        public string Id { get; set; }
        public string Message { get; set; }
        public NotificationPriority Priority { get; set; }
        public DateTime Timestamp { get; set; }
        public float Duration { get; set; }
    }

    public class NotificationDisplayedEvent : GameEvent
    {
        public Notification Notification { get; }
        public NotificationDisplayedEvent(Notification n) => Notification = n;
    }
}
