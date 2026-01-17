using System;
using System.Collections.Generic;
using EraOfWheel.Core;
using EraOfWheel.Core.Events;

namespace EraOfWheel.DemonLords
{
    /// <summary>
    /// 魔王基类 - 所有魔王必须继承此类
    /// </summary>
    public abstract class BaseDemonLord : IDisposable
    {
        public abstract string Id { get; }
        public abstract string Name { get; }
        public abstract string Title { get; }
        public abstract string Description { get; }
        public abstract DemonLordType Type { get; }

        public float AwakeningLevel { get; protected set; } = 0f;
        public float AwakeningThreshold { get; protected set; } = 100f;
        public bool IsAwakened => AwakeningLevel >= AwakeningThreshold;
        public bool IsSealed { get; protected set; } = false;
        
        public List<string> UnlockedAbilities { get; } = new List<string>();
        public Dictionary<string, float> Stats { get; } = new Dictionary<string, float>();

        protected BaseDemonLord()
        {
            InitializeStats();
            InitializeAbilities();
        }

        protected abstract void InitializeStats();
        protected abstract void InitializeAbilities();

        /// <summary>
        /// 增加苏醒度
        /// </summary>
        public virtual void AddAwakening(float amount)
        {
            if (IsSealed) return;
            
            var oldLevel = AwakeningLevel;
            AwakeningLevel = Math.Min(AwakeningLevel + amount, AwakeningThreshold);
            
            if (!IsAwakened && AwakeningLevel >= AwakeningThreshold)
            {
                OnAwakened();
            }
            
            Logger.Debug("DemonLord", $"{Name} 苏醒度: {oldLevel:F1} → {AwakeningLevel:F1}");
        }

        /// <summary>
        /// 魔王苏醒时触发
        /// </summary>
        protected virtual void OnAwakened()
        {
            Logger.Info("DemonLord", $"⚠️ {Name} 已苏醒！");
            EventBus.Instance?.Publish(new DemonLordAwakenedEvent(this));
        }

        /// <summary>
        /// 执行入侵行动
        /// </summary>
        public abstract void ExecuteInvasion();

        /// <summary>
        /// 封印魔王
        /// </summary>
        public virtual void Seal()
        {
            IsSealed = true;
            AwakeningLevel = 0f;
            Logger.Info("DemonLord", $"✨ {Name} 已被封印");
            EventBus.Instance?.Publish(new DemonLordSealedEvent(this));
        }

        /// <summary>
        /// 根据玩家行为进化
        /// </summary>
        public abstract void Evolve(PlayerActionData actions);

        /// <summary>
        /// 获取当前威胁等级
        /// </summary>
        public virtual int GetThreatLevel()
        {
            return (int)(AwakeningLevel / 20f) + 1;
        }

        public virtual void Dispose()
        {
            UnlockedAbilities.Clear();
            Stats.Clear();
        }
    }

    public enum DemonLordType
    {
        Void,       // 虚无之主
        Plague,     // 瘟疫母神
        Entropy,    // 熵噬者
        Abyss,      // 深渊之眼
        War,        // 战争之父
        Famine,     // 饥荒王
        Chaos,      // 狂乱女王
        Silence,    // 寂灭大帝
        Heresy,     // 亵渎者
        End         // 终焉之主
    }

    public class PlayerActionData
    {
        public int TotalActions { get; set; }
        public Dictionary<string, int> ActionCounts { get; } = new Dictionary<string, int>();
    }

    // 魔王事件
    public class DemonLordAwakenedEvent : GameEvent
    {
        public BaseDemonLord DemonLord { get; }
        public DemonLordAwakenedEvent(BaseDemonLord lord) => DemonLord = lord;
    }

    public class DemonLordSealedEvent : GameEvent
    {
        public BaseDemonLord DemonLord { get; }
        public DemonLordSealedEvent(BaseDemonLord lord) => DemonLord = lord;
    }

    public class DemonLordInvasionEvent : GameEvent
    {
        public BaseDemonLord DemonLord { get; }
        public string InvasionType { get; }
        public DemonLordInvasionEvent(BaseDemonLord lord, string type)
        {
            DemonLord = lord;
            InvasionType = type;
        }
    }
}
