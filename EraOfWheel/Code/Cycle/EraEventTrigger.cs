using System;
using System.Collections.Generic;
using EraOfWheel.Core;
using EraOfWheel.Core.Events;

namespace EraOfWheel.Cycle
{
    /// <summary>
    /// 纪元事件触发器 - 基于纪元阶段触发事件
    /// </summary>
    public class EraEventTrigger : IModSystem
    {
        public static EraEventTrigger Instance { get; private set; }
        
        public string SystemName => "EraEventTrigger";
        public bool IsInitialized { get; private set; }

        private Dictionary<CyclePhase, List<EraEvent>> _eventPools = new Dictionary<CyclePhase, List<EraEvent>>();
        private System.Random _random = new System.Random();
        private IDisposable _phaseSubscription;

        public void Initialize()
        {
            if (IsInitialized) return;

            Instance = this;
            LoadEventPools();
            
            _phaseSubscription = EventBus.Instance?.Subscribe<PhaseChangedEvent>(OnPhaseChanged);
            
            IsInitialized = true;
            Logger.Info(SystemName, "纪元事件触发器初始化完成");
        }

        private void LoadEventPools()
        {
            // 萌芽期事件
            _eventPools[CyclePhase.Germination] = new List<EraEvent>
            {
                new EraEvent("first_fire", "初火", "第一缕文明之火在黑暗中燃起", 0.3f),
                new EraEvent("tribe_formed", "部落形成", "散落的人群开始聚集成部落", 0.4f),
                new EraEvent("ancient_discovery", "远古发现", "发现了上一轮回留下的遗迹", 0.2f)
            };

            // 成长期事件
            _eventPools[CyclePhase.Growth] = new List<EraEvent>
            {
                new EraEvent("city_founded", "城市建立", "第一座城市拔地而起", 0.3f),
                new EraEvent("trade_route", "贸易通道", "文明之间建立了贸易通道", 0.3f),
                new EraEvent("dark_whisper", "黑暗低语", "远古的邪恶开始低语", 0.2f)
            };

            // 鼎盛期事件
            _eventPools[CyclePhase.Prosperity] = new List<EraEvent>
            {
                new EraEvent("golden_age", "黄金时代", "文明进入黄金时代", 0.25f),
                new EraEvent("great_wonder", "伟大奇迹", "建造了举世瞩目的奇迹", 0.2f),
                new EraEvent("demon_stir", "魔王躁动", "封印中的魔王开始躁动", 0.3f)
            };

            // 衰落期事件
            _eventPools[CyclePhase.Decline] = new List<EraEvent>
            {
                new EraEvent("civil_war", "内战爆发", "文明陷入内战", 0.4f),
                new EraEvent("plague", "瘟疫蔓延", "致命的瘟疫开始蔓延", 0.3f),
                new EraEvent("demon_awakening", "魔王苏醒", "魔王开始苏醒", 0.4f)
            };

            // 灭绝期事件
            _eventPools[CyclePhase.Extinction] = new List<EraEvent>
            {
                new EraEvent("last_stand", "最后的抵抗", "最后的文明进行殊死抵抗", 0.5f),
                new EraEvent("apocalypse", "天启降临", "末日降临这片土地", 0.4f),
                new EraEvent("legacy_remains", "遗产留存", "文明的遗产在废墟中保存", 0.3f)
            };
        }

        private void OnPhaseChanged(PhaseChangedEvent evt)
        {
            // 阶段变化时触发事件
            TriggerRandomEvent(evt.NewPhase);
        }

        /// <summary>
        /// 触发指定阶段的随机事件
        /// </summary>
        public EraEvent TriggerRandomEvent(CyclePhase phase)
        {
            if (!_eventPools.TryGetValue(phase, out var pool) || pool.Count == 0)
                return null;

            // 根据权重随机选择
            float totalWeight = 0f;
            foreach (var evt in pool) totalWeight += evt.Weight;

            float roll = (float)_random.NextDouble() * totalWeight;
            float current = 0f;

            foreach (var evt in pool)
            {
                current += evt.Weight;
                if (roll <= current)
                {
                    Logger.Info(SystemName, $"触发纪元事件: [{evt.Title}] {evt.Description}");
                    EventBus.Instance?.Publish(new EraEventTriggeredEvent(evt));
                    return evt;
                }
            }

            return null;
        }

        /// <summary>
        /// 添加自定义事件
        /// </summary>
        public void AddEvent(CyclePhase phase, EraEvent evt)
        {
            if (!_eventPools.ContainsKey(phase))
                _eventPools[phase] = new List<EraEvent>();
            _eventPools[phase].Add(evt);
        }

        public void Dispose()
        {
            _phaseSubscription?.Dispose();
            _eventPools.Clear();
            Instance = null;
            IsInitialized = false;
        }
    }

    public class EraEvent
    {
        public string Id { get; }
        public string Title { get; }
        public string Description { get; }
        public float Weight { get; }

        public EraEvent(string id, string title, string desc, float weight = 1f)
        {
            Id = id;
            Title = title;
            Description = desc;
            Weight = weight;
        }
    }

    public class EraEventTriggeredEvent : GameEvent
    {
        public EraEvent Event { get; }
        public EraEventTriggeredEvent(EraEvent evt) => Event = evt;
    }
}
