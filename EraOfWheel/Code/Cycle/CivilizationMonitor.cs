using System;
using System.Collections.Generic;
using EraOfWheel.Core;
using EraOfWheel.Core.Events;

namespace EraOfWheel.Cycle
{
    /// <summary>
    /// 文明监控系统 - 监控WorldBox中的文明数据
    /// </summary>
    public class CivilizationMonitor : IModSystem
    {
        public static CivilizationMonitor Instance { get; private set; }
        
        public string SystemName => "CivilizationMonitor";
        public bool IsInitialized { get; private set; }

        private CivilizationData _currentData = new CivilizationData();
        private CivilizationData _previousData = new CivilizationData();
        private float _updateInterval = 1f;
        private float _lastUpdate = 0f;

        public CivilizationData CurrentData => _currentData;

        public void Initialize()
        {
            if (IsInitialized) return;

            Instance = this;
            RefreshData();
            
            IsInitialized = true;
            Logger.Info(SystemName, "文明监控系统初始化完成");
        }

        /// <summary>
        /// 每帧更新
        /// </summary>
        public void Update(float deltaTime)
        {
            _lastUpdate += deltaTime;
            if (_lastUpdate >= _updateInterval)
            {
                _lastUpdate = 0f;
                RefreshData();
            }
        }

        /// <summary>
        /// 刷新文明数据
        /// </summary>
        public void RefreshData()
        {
            _previousData = _currentData.Clone();
            
            // 从WorldBox获取数据
            try
            {
                _currentData.civilizationCount = GetCivilizationCount();
                _currentData.totalPopulation = GetTotalPopulation();
                _currentData.cityCount = GetCityCount();
                _currentData.techLevel = GetAverageTechLevel();
                _currentData.warCount = GetActiveWarCount();
                _currentData.lastUpdate = DateTime.UtcNow;

                CheckForChanges();
            }
            catch (Exception ex)
            {
                Logger.Error(SystemName, "刷新文明数据失败", ex);
            }
        }

        private void CheckForChanges()
        {
            if (_currentData.civilizationCount != _previousData.civilizationCount)
            {
                var delta = _currentData.civilizationCount - _previousData.civilizationCount;
                EventBus.Instance?.Publish(new CivilizationCountChangedEvent(delta, _currentData.civilizationCount));
            }

            if (_currentData.totalPopulation < _previousData.totalPopulation * 0.5f)
            {
                EventBus.Instance?.Publish(new MassExtinctionEvent(_previousData.totalPopulation - _currentData.totalPopulation));
            }
        }

        // WorldBox数据获取方法 (需要根据实际API调整)
        private int GetCivilizationCount()
        {
            // TODO: 调用WorldBox API
            return 0;
        }

        private int GetTotalPopulation()
        {
            // TODO: 调用WorldBox API
            return 0;
        }

        private int GetCityCount()
        {
            // TODO: 调用WorldBox API
            return 0;
        }

        private float GetAverageTechLevel()
        {
            // TODO: 调用WorldBox API
            return 0f;
        }

        private int GetActiveWarCount()
        {
            // TODO: 调用WorldBox API
            return 0;
        }

        public void Dispose()
        {
            Instance = null;
            IsInitialized = false;
        }
    }

    [Serializable]
    public class CivilizationData
    {
        public int civilizationCount;
        public int totalPopulation;
        public int cityCount;
        public float techLevel;
        public int warCount;
        public DateTime lastUpdate;

        public CivilizationData Clone()
        {
            return new CivilizationData
            {
                civilizationCount = civilizationCount,
                totalPopulation = totalPopulation,
                cityCount = cityCount,
                techLevel = techLevel,
                warCount = warCount,
                lastUpdate = lastUpdate
            };
        }
    }

    public class CivilizationCountChangedEvent : GameEvent
    {
        public int Delta { get; }
        public int NewCount { get; }
        public CivilizationCountChangedEvent(int delta, int newCount)
        {
            Delta = delta;
            NewCount = newCount;
        }
    }

    public class MassExtinctionEvent : GameEvent
    {
        public int DeathCount { get; }
        public MassExtinctionEvent(int count) => DeathCount = count;
    }
}
