using System;
using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.Narrative
{
    public class NarrativeDispatcher
    {
        private static NarrativeDispatcher _instance;
        public static NarrativeDispatcher Instance => _instance ?? (_instance = new NarrativeDispatcher());

        private readonly EventPool _eventPool = new EventPool();
        private long _lastCheckWorldAge;
        private int _frameCounter;
        private bool _initialized;

        public EventPool EventPool => _eventPool;
        public bool AIEnabled { get; set; }

        public void Initialize(ModConfig cfg, string eventsPath)
        {
            if (_initialized) return;

            try
            {
                var window = 10;
                if (cfg?.narrative?.event_pool != null)
                {
                    window = cfg.narrative.event_pool.duplicate_prevention_window;
                }
                _eventPool.SetDuplicatePreventionWindow(window);
                _eventPool.LoadFromDirectory(eventsPath);
                _initialized = true;
                Log.Info($"[NarrativeDispatcher] 初始化完成，加载了 {_eventPool.EventCount} 个事件");
            }
            catch (Exception ex)
            {
                Log.Warning($"[NarrativeDispatcher] 初始化失败: {ex.Message}");
            }
        }

        public void Update(ModConfig cfg, WorldContext ctx)
        {
            if (!_initialized || cfg == null || ctx == null) return;

            _frameCounter++;
            var interval = 300;
            if (cfg.narrative?.event_pool != null)
            {
                interval = Math.Max(60, cfg.narrative.event_pool.trigger_interval_frames);
            }

            if (_frameCounter < interval) return;
            _frameCounter = 0;

            if (_lastCheckWorldAge == ctx.WorldAge) return;
            _lastCheckWorldAge = ctx.WorldAge;

            TryTriggerEvent(cfg, ctx);
        }

        public void TryTriggerEvent(ModConfig cfg, WorldContext ctx)
        {
            if (cfg?.narrative?.ai_engine?.enabled == true && AIEnabled)
            {
                return;
            }

            var evt = _eventPool.SelectEvent(ctx);
            if (evt == null) return;

            DispatchEvent(evt, ctx);
            _eventPool.MarkTriggered(evt, ctx);
        }

        public void DispatchEvent(NarrativeEvent evt, WorldContext ctx)
        {
            if (evt == null) return;

            var title = Localization.Get(evt.TitleKey, evt.TitleKey);
            var desc = Localization.Get(evt.DescriptionKey, evt.DescriptionKey);

            Log.Info($"[NarrativeDispatcher] 触发事件: {evt.Id} - {title}");

            try
            {
                ShowNotification(title, desc, evt.Category);
            }
            catch (Exception ex)
            {
                Log.Warning($"[NarrativeDispatcher] 显示通知失败: {ex.Message}");
            }

            if (evt.Effects != null)
            {
                foreach (var effect in evt.Effects)
                {
                    ApplyEffect(effect, ctx);
                }
            }

            EventBus.Publish(new NarrativeEventTriggeredEvent
            {
                EventId = evt.Id,
                Category = evt.Category,
                WorldAge = ctx.WorldAge
            });
        }

        private void ApplyEffect(NarrativeEffect effect, WorldContext ctx)
        {
            if (effect == null) return;

            try
            {
                switch (effect.Type)
                {
                    case NarrativeEffect.Types.Notification:
                        var msg = Localization.Get(effect.Value, effect.Value);
                        ShowNotification("系统", msg, NarrativeEventCategory.System);
                        break;

                    case NarrativeEffect.Types.Log:
                        Log.Info($"[NarrativeEffect] {effect.Value}");
                        break;
                }
            }
            catch
            {
            }
        }

        private void ShowNotification(string title, string content, NarrativeEventCategory category)
        {
            try
            {
                WorldCompat.ShowNotification($"【{title}】{content}");
            }
            catch
            {
                Log.Info($"[Notification] {title}: {content}");
            }
        }

        public static void NotifyOmenEntered()
        {
            try
            {
                Log.Info("[EraWheel] 预兆阶段开始");

                var ctx = WorldContext.Capture();
                ctx.CurrentPhase = EraPhase.Omen;

                var evt = Instance._eventPool.GetById("omen_started");
                if (evt != null)
                {
                    Instance.DispatchEvent(evt, ctx);
                    Instance._eventPool.MarkTriggered(evt, ctx);
                }
            }
            catch
            {
            }
        }

        public static void NotifyPhaseChanged(EraPhase prev, EraPhase next)
        {
            try
            {
                Log.Info($"[EraWheel] 阶段变化: {prev} -> {next}");
            }
            catch
            {
            }
        }

        public static void NotifyDemonAwakened(string demonId)
        {
            try
            {
                Log.Info($"[EraWheel] 魔王苏醒: {demonId}");
            }
            catch
            {
            }
        }

        public static void NotifyHeroBorn(string heroName)
        {
            try
            {
                Log.Info($"[EraWheel] 命定英雄诞生: {heroName}");
            }
            catch
            {
            }
        }

        public static void NotifyAllianceFormed()
        {
            try
            {
                Log.Info("[EraWheel] 反魔联盟成立");
            }
            catch
            {
            }
        }

        public static void NotifyCycleCompleted(int cycleNumber)
        {
            try
            {
                Log.Info($"[EraWheel] 轮回完成: 第 {cycleNumber} 轮");
            }
            catch
            {
            }
        }

        public EventPoolSaveData GetSaveData()
        {
            return _eventPool.GetSaveData();
        }

        public void LoadSaveData(EventPoolSaveData data)
        {
            _eventPool.LoadSaveData(data);
        }

        public void Reset()
        {
            _eventPool.ResetCooldowns();
            _frameCounter = 0;
            _lastCheckWorldAge = 0;
        }
    }

    [Serializable]
    public struct NarrativeEventTriggeredEvent
    {
        public string EventId;
        public NarrativeEventCategory Category;
        public long WorldAge;
    }

    public static class Localization
    {
        public static string Get(string key, string fallback = null)
        {
            if (string.IsNullOrEmpty(key))
                return fallback ?? "";

            return fallback ?? key;
        }
    }
}
