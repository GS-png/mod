using System;
using System.Collections.Generic;
using EraOfWheel.Core;
using EraOfWheel.Core.Data;
using EraOfWheel.Core.Events;

namespace EraOfWheel.Cycle
{
    /// <summary>
    /// 遗产系统 - 管理跨轮回的永久进度
    /// </summary>
    public class LegacySystem : IModSystem
    {
        public static LegacySystem Instance { get; private set; }
        
        public string SystemName => "LegacySystem";
        public bool IsInitialized { get; private set; }

        private LegacyData _data;
        private IDisposable _cycleEndSubscription;

        public int TotalPoints => _data?.permanentLegacyPoints ?? 0;
        public int TotalCycles => _data?.totalCyclesCompleted ?? 0;

        public void Initialize()
        {
            if (IsInitialized) return;

            Instance = this;
            _data = SaveManager.Instance?.Legacy ?? new LegacyData();
            
            // 订阅轮回结束事件
            _cycleEndSubscription = EventBus.Instance?.Subscribe<CycleEndedEvent>(OnCycleEnded);
            
            IsInitialized = true;
            Logger.Info(SystemName, $"遗产系统初始化 - 累计轮回: {TotalCycles}, 遗产点: {TotalPoints}");
        }

        private void OnCycleEnded(CycleEndedEvent evt)
        {
            var points = CalculateLegacyPoints();
            AddLegacyPoints(points);
            _data.totalCyclesCompleted++;
            
            Save();
            
            Logger.Info(SystemName, $"轮回结束 - 获得遗产点: {points}");
            EventBus.Instance?.Publish(new LegacyEarnedEvent(points, TotalPoints));
        }

        /// <summary>
        /// 计算本轮回获得的遗产点
        /// </summary>
        public int CalculateLegacyPoints()
        {
            var state = CycleManager.Instance?.State;
            if (state == null) return 0;

            int basePoints = 10;
            int phaseBonus = (int)state.currentPhase * 5;
            int cycleBonus = state.cycleNumber * 2;

            return basePoints + phaseBonus + cycleBonus;
        }

        /// <summary>
        /// 添加遗产点
        /// </summary>
        public void AddLegacyPoints(int points)
        {
            if (points <= 0) return;
            _data.permanentLegacyPoints += points;
        }

        /// <summary>
        /// 消费遗产点购买强化
        /// </summary>
        public bool SpendPoints(int cost, string enhancementId)
        {
            if (_data.permanentLegacyPoints < cost) return false;
            if (_data.unlockedEnhancements.Contains(enhancementId)) return false;

            _data.permanentLegacyPoints -= cost;
            _data.unlockedEnhancements.Add(enhancementId);
            Save();

            Logger.Info(SystemName, $"解锁强化: {enhancementId}, 花费: {cost}");
            return true;
        }

        /// <summary>
        /// 检查强化是否已解锁
        /// </summary>
        public bool HasEnhancement(string enhancementId)
        {
            return _data.unlockedEnhancements.Contains(enhancementId);
        }

        /// <summary>
        /// 记录魔王击败
        /// </summary>
        public void RecordDemonLordDefeat(string demonLordId)
        {
            if (!_data.demonLordDefeats.ContainsKey(demonLordId))
            {
                _data.demonLordDefeats[demonLordId] = 0;
            }
            _data.demonLordDefeats[demonLordId]++;
            Save();
        }

        private void Save()
        {
            if (SaveManager.Instance != null)
            {
                SaveManager.Instance.Legacy = _data;
                SaveManager.Instance.SaveLegacy();
            }
        }

        public void Dispose()
        {
            _cycleEndSubscription?.Dispose();
            Instance = null;
            IsInitialized = false;
        }
    }

    public class LegacyEarnedEvent : GameEvent
    {
        public int PointsEarned { get; }
        public int TotalPoints { get; }
        public LegacyEarnedEvent(int earned, int total)
        {
            PointsEarned = earned;
            TotalPoints = total;
        }
    }
}
