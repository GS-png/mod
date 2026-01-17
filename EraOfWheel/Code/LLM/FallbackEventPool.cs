using System;
using System.Collections.Generic;
using EraOfWheel.Core;

namespace EraOfWheel.LLM
{
    /// <summary>
    /// 后备事件池 - 当LLM不可用时使用预定义事件
    /// </summary>
    public class FallbackEventPool : IModSystem
    {
        public static FallbackEventPool Instance { get; private set; }
        
        public string SystemName => "FallbackEventPool";
        public bool IsInitialized { get; private set; }

        private Dictionary<string, List<FallbackEvent>> _eventsByCategory = new Dictionary<string, List<FallbackEvent>>();
        private System.Random _random = new System.Random();

        public void Initialize()
        {
            if (IsInitialized) return;

            Instance = this;
            LoadDefaultEvents();
            
            IsInitialized = true;
            Logger.Info(SystemName, $"后备事件池初始化 - 共 {GetTotalEventCount()} 个事件");
        }

        private void LoadDefaultEvents()
        {
            // 轮回事件
            AddEvent("cycle", new FallbackEvent
            {
                Id = "new_era_dawn",
                Title = "新纪元曙光",
                Description = "一个新的时代即将开始，世界充满了无限可能。",
                Category = "cycle"
            });
            AddEvent("cycle", new FallbackEvent
            {
                Id = "civilization_rise",
                Title = "文明崛起",
                Description = "一个新的文明从废墟中崛起，带来希望的曙光。",
                Category = "cycle"
            });

            // 魔王事件
            AddEvent("demon", new FallbackEvent
            {
                Id = "dark_whisper",
                Title = "黑暗低语",
                Description = "远古的邪恶在低语，魔王的意志正在苏醒。",
                Category = "demon"
            });
            AddEvent("demon", new FallbackEvent
            {
                Id = "corruption_spreads",
                Title = "腐蚀蔓延",
                Description = "黑暗的力量正在侵蚀这片土地。",
                Category = "demon"
            });
            AddEvent("demon", new FallbackEvent
            {
                Id = "void_tear",
                Title = "虚空裂隙",
                Description = "空间出现裂隙，虚无的力量涌入世界。",
                Category = "demon"
            });

            // 叙事事件
            AddEvent("narrative", new FallbackEvent
            {
                Id = "hero_rises",
                Title = "英雄崛起",
                Description = "一位英雄从平凡中崛起，誓言对抗黑暗。",
                Category = "narrative"
            });
            AddEvent("narrative", new FallbackEvent
            {
                Id = "ancient_prophecy",
                Title = "远古预言",
                Description = "古老的预言揭示了即将到来的命运。",
                Category = "narrative"
            });
            AddEvent("narrative", new FallbackEvent
            {
                Id = "alliance_formed",
                Title = "同盟结成",
                Description = "各个种族放下成见，组成抵抗黑暗的联盟。",
                Category = "narrative"
            });
        }

        /// <summary>
        /// 添加后备事件
        /// </summary>
        public void AddEvent(string category, FallbackEvent evt)
        {
            if (!_eventsByCategory.ContainsKey(category))
            {
                _eventsByCategory[category] = new List<FallbackEvent>();
            }
            _eventsByCategory[category].Add(evt);
        }

        /// <summary>
        /// 获取随机事件
        /// </summary>
        public FallbackEvent GetRandomEvent(string category = null)
        {
            List<FallbackEvent> pool;
            
            if (string.IsNullOrEmpty(category))
            {
                pool = new List<FallbackEvent>();
                foreach (var list in _eventsByCategory.Values)
                {
                    pool.AddRange(list);
                }
            }
            else if (!_eventsByCategory.TryGetValue(category, out pool) || pool.Count == 0)
            {
                return null;
            }

            if (pool.Count == 0) return null;
            return pool[_random.Next(pool.Count)];
        }

        private int GetTotalEventCount()
        {
            int count = 0;
            foreach (var list in _eventsByCategory.Values)
            {
                count += list.Count;
            }
            return count;
        }

        public void Dispose()
        {
            _eventsByCategory.Clear();
            Instance = null;
            IsInitialized = false;
        }
    }

    public class FallbackEvent
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Weight { get; set; } = 1;
    }
}
