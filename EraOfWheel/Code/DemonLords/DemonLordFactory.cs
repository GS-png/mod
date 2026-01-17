using System;
using System.Collections.Generic;
using EraOfWheel.Core;

namespace EraOfWheel.DemonLords
{
    /// <summary>
    /// 魔王工厂 - 负责创建和管理魔王实例
    /// </summary>
    public class DemonLordFactory : IModSystem
    {
        public static DemonLordFactory Instance { get; private set; }
        
        public string SystemName => "DemonLordFactory";
        public bool IsInitialized { get; private set; }

        private Dictionary<string, Func<BaseDemonLord>> _creators = new Dictionary<string, Func<BaseDemonLord>>();
        private BaseDemonLord _activeDemonLord;

        public BaseDemonLord ActiveDemonLord => _activeDemonLord;

        public void Initialize()
        {
            if (IsInitialized) return;

            Instance = this;
            RegisterDemonLords();
            
            IsInitialized = true;
            Logger.Info(SystemName, $"魔王工厂初始化完成 - 已注册 {_creators.Count} 个魔王");
        }

        private void RegisterDemonLords()
        {
            // MVP魔王 (Epic 3)
            Register("void_lord", () => new VoidLord());
            Register("plague_mother", () => new PlagueMother());
            
            // 扩展魔王 (Epic 6)
            Register("entropy_devourer", () => new EntropyDevourer());
            Register("abyss_eye", () => new AbyssEye());
            Register("war_father", () => new WarFather());
            Register("famine_king", () => new FamineKing());
            Register("chaos_queen", () => new ChaosQueen());
            Register("silence_emperor", () => new SilenceEmperor());
            Register("desecrator", () => new Desecrator());
            Register("end_lord", () => new EndLord());
        }

        /// <summary>
        /// 注册魔王创建器
        /// </summary>
        public void Register(string id, Func<BaseDemonLord> creator)
        {
            _creators[id] = creator;
        }

        /// <summary>
        /// 创建魔王实例
        /// </summary>
        public BaseDemonLord Create(string id)
        {
            if (!_creators.TryGetValue(id, out var creator))
            {
                Logger.Error(SystemName, $"未知的魔王ID: {id}");
                return null;
            }

            var demonLord = creator();
            Logger.Info(SystemName, $"创建魔王: {demonLord.Name}");
            return demonLord;
        }

        /// <summary>
        /// 设置当前活跃魔王
        /// </summary>
        public void SetActive(string id)
        {
            _activeDemonLord?.Dispose();
            _activeDemonLord = Create(id);
        }

        /// <summary>
        /// 获取所有可用魔王ID
        /// </summary>
        public IEnumerable<string> GetAvailableIds()
        {
            return _creators.Keys;
        }

        /// <summary>
        /// 随机选择一个魔王
        /// </summary>
        public BaseDemonLord CreateRandom()
        {
            var ids = new List<string>(_creators.Keys);
            if (ids.Count == 0) return null;
            
            var randomIndex = UnityEngine.Random.Range(0, ids.Count);
            return Create(ids[randomIndex]);
        }

        public void Dispose()
        {
            _activeDemonLord?.Dispose();
            _activeDemonLord = null;
            _creators.Clear();
            Instance = null;
            IsInitialized = false;
        }
    }
}
