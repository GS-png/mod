using EraOfWheel.Core;
using EraOfWheel.Core.Events;

namespace EraOfWheel.DemonLords
{
    /// <summary>
    /// 虚无之主 - 存在吞噬者
    /// </summary>
    public class VoidLord : BaseDemonLord
    {
        public override string Id => "void_lord";
        public override string Name => "虚无之主";
        public override string Title => "存在吞噬者";
        public override string Description => "来自虚空的古老存在，以吞噬一切存在为食。其力量随着被吞噬的生命而增长。";
        public override DemonLordType Type => DemonLordType.Void;

        private float _corruptionRadius = 10f;
        private int _devourCount = 0;

        protected override void InitializeStats()
        {
            Stats["corruption_power"] = 1.0f;
            Stats["devour_rate"] = 0.5f;
            Stats["void_expansion"] = 0.1f;
        }

        protected override void InitializeAbilities()
        {
            UnlockedAbilities.Add("void_touch");
        }

        public override void ExecuteInvasion()
        {
            if (!IsAwakened) return;

            var threatLevel = GetThreatLevel();
            
            if (threatLevel >= 3)
            {
                ExecuteVoidStorm();
            }
            else if (threatLevel >= 2)
            {
                ExecuteCorruption();
            }
            else
            {
                ExecuteDevour();
            }
        }

        private void ExecuteDevour()
        {
            _devourCount++;
            Stats["corruption_power"] += 0.1f;
            
            Logger.Info("VoidLord", "虚无之主发动【吞噬】");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "devour"));
        }

        private void ExecuteCorruption()
        {
            _corruptionRadius += Stats["void_expansion"] * 5f;
            
            Logger.Info("VoidLord", $"虚无之主发动【虚空腐蚀】范围: {_corruptionRadius:F1}");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "corruption"));
        }

        private void ExecuteVoidStorm()
        {
            Logger.Info("VoidLord", "⚠️ 虚无之主发动【虚空风暴】！");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "void_storm"));
        }

        public override void Evolve(PlayerActionData actions)
        {
            // 学习玩家的防御模式
            if (actions.ActionCounts.TryGetValue("defense", out int defenseCount))
            {
                if (defenseCount > 5)
                {
                    Stats["corruption_power"] += 0.2f;
                    Logger.Debug("VoidLord", "虚无之主进化: 增强腐蚀力量");
                }
            }
            
            // 解锁新能力
            if (_devourCount >= 10 && !UnlockedAbilities.Contains("mass_devour"))
            {
                UnlockedAbilities.Add("mass_devour");
                Logger.Info("VoidLord", "虚无之主解锁新能力: 【群体吞噬】");
            }
        }

        public override int GetThreatLevel()
        {
            var baseThreat = base.GetThreatLevel();
            return baseThreat + (_devourCount / 5);
        }
    }
}
