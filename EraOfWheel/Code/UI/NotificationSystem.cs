using System;
using System.Collections.Generic;
using UnityEngine;
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

        private int _lastAftermathNoticeYear = -1;

        private GUIStyle _titleStyle;
        private GUIStyle _messageStyle;
        private GUIStyle _boxStyle;

        public IReadOnlyList<Notification> ActiveNotifications => _activeNotifications;

        public void Initialize()
        {
            if (IsInitialized) return;
            
            Instance = this;
            _defaultDuration = ConfigManager.Instance?.Config?.ui?.notification_duration_seconds ?? 5f;
            _maxActive = Math.Max(1, ConfigManager.Instance?.Config?.ui?.notification_max_active ?? 3);
            
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
            EventBus.Instance?.Subscribe<CycleFailureDecisionRequestedEvent>(OnFailureDecisionRequested);
            EventBus.Instance?.Subscribe<CycleFailureResolvedEvent>(OnFailureResolved);
            EventBus.Instance?.Subscribe<TerminalAftermathEnteredEvent>(OnTerminalAftermathEntered);
            EventBus.Instance?.Subscribe<TerminalAftermathTickEvent>(OnTerminalAftermathTick);
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

        private void OnFailureDecisionRequested(CycleFailureDecisionRequestedEvent e)
        {
            string reason = string.IsNullOrEmpty(e?.Reason) ? "(未知)" : e.Reason;
            Show("轮回失败", $"失败原因：{reason}。请做出选择（重启/终末余波）。", NotificationType.Critical);
        }

        private void OnFailureResolved(CycleFailureResolvedEvent e)
        {
            string choice = string.IsNullOrEmpty(e?.Choice) ? "(未知)" : e.Choice;
            if (choice == "restart")
            {
                float keepRatio = ConfigManager.Instance?.Config?.seal?.restart_cycle?.legacy_keep_ratio ?? 0.5f;
                Show("轮回重启", $"已选择重启轮回。遗产保留：{keepRatio * 100f:0}%（传奇保留，诅咒清除）", NotificationType.Warning);
                return;
            }
            Show("终末余波", "已选择进入终末余波。", NotificationType.Critical);
        }

        private void OnTerminalAftermathEntered(TerminalAftermathEnteredEvent e)
        {
            string reason = string.IsNullOrEmpty(e?.Reason) ? "(未知)" : e.Reason;
            _lastAftermathNoticeYear = -1;
            Show("终末余波", $"世界进入终末余波：{reason}", NotificationType.Critical);
        }

        private void OnTerminalAftermathTick(TerminalAftermathTickEvent e)
        {
            if (e == null) return;

            const int interval = 10;
            if (_lastAftermathNoticeYear >= 0 && e.WorldYear - _lastAftermathNoticeYear < interval) return;
            _lastAftermathNoticeYear = e.WorldYear;

            Show("终末余波", $"世界正在崩坏（年份：{e.WorldYear}），惩罚正在累积...", NotificationType.Critical);
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

        internal void RenderGui()
        {
            if (!IsInitialized) return;
            if (_activeNotifications == null || _activeNotifications.Count == 0) return;

            EnsureGuiStyles();

            int count = Math.Min(_activeNotifications.Count, _maxActive);
            if (count <= 0) return;

            const float width = 360f;
            const float heightPer = 74f;
            const float margin = 12f;
            float height = count * heightPer;

            float x = Screen.width - width - margin;
            float y = margin;

            GUILayout.BeginArea(new Rect(x, y, width, height));

            for (int i = 0; i < count; i++)
            {
                var n = _activeNotifications[i];
                if (n == null) continue;

                Color prevColor = GUI.color;
                GUI.color = GetColorForType(n.Type);

                GUILayout.BeginVertical(_boxStyle);
                GUILayout.Label(n.Title ?? "", _titleStyle);
                GUILayout.Label(n.Message ?? "", _messageStyle);
                GUILayout.EndVertical();

                GUI.color = prevColor;
            }

            GUILayout.EndArea();
        }

        private void EnsureGuiStyles()
        {
            if (_titleStyle == null)
            {
                _titleStyle = new GUIStyle(GUI.skin.label)
                {
                    fontStyle = FontStyle.Bold,
                    wordWrap = true
                };
            }

            if (_messageStyle == null)
            {
                _messageStyle = new GUIStyle(GUI.skin.label)
                {
                    wordWrap = true
                };
            }

            if (_boxStyle == null)
            {
                _boxStyle = new GUIStyle(GUI.skin.box)
                {
                    alignment = TextAnchor.UpperLeft,
                    padding = new RectOffset(10, 10, 8, 8)
                };
            }
        }

        private static Color GetColorForType(NotificationType type)
        {
            return type switch
            {
                NotificationType.Info => new Color(1f, 1f, 1f, 0.92f),
                NotificationType.Warning => new Color(1f, 0.85f, 0.35f, 0.92f),
                NotificationType.Critical => new Color(1f, 0.4f, 0.4f, 0.92f),
                NotificationType.Success => new Color(0.45f, 1f, 0.6f, 0.92f),
                _ => new Color(1f, 1f, 1f, 0.92f)
            };
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
            EventBus.Instance?.Unsubscribe<CycleFailureDecisionRequestedEvent>(OnFailureDecisionRequested);
            EventBus.Instance?.Unsubscribe<CycleFailureResolvedEvent>(OnFailureResolved);
            EventBus.Instance?.Unsubscribe<TerminalAftermathEnteredEvent>(OnTerminalAftermathEntered);
            EventBus.Instance?.Unsubscribe<TerminalAftermathTickEvent>(OnTerminalAftermathTick);
            
            DismissAll();
            _titleStyle = null;
            _messageStyle = null;
            _boxStyle = null;
            IsInitialized = false;
            Instance = null;
            Logger.Info(SystemName, "NotificationSystem disposed");
        }
    }
}
