using EraOfWheel.Core;
using EraOfWheel.Core.Events;

namespace EraOfWheel.DemonLords
{
    /// <summary>
    /// 战争之父 - 永恒战火
    /// </summary>
    public class WarFather : BaseDemonLord
    {
        public override string Id => "war_father";
        public override string Name => "战争之父";
        public override string Title => "永恒战火";
        public override string Description => "战争与毁灭的化身，其存在本身就是冲突。他的低语激起无尽的仇恨与战意。";
        public override DemonLordType Type => DemonLordType.War;

        private int _warCount = 0;

        protected override void InitializeStats()
        {
            Stats["aggression_boost"] = 2.0f;
            Stats["conflict_radius"] = 50f;
            Stats["arms_race_speed"] = 1.5f;
        }

        protected override void InitializeAbilities()
        {
            UnlockedAbilities.Add("war_cry");
        }

        public override void ExecuteInvasion()
        {
            if (!IsAwakened) return;

            var threatLevel = GetThreatLevel();
            
            if (threatLevel >= 4)
            {
                ExecuteWorldWar();
            }
            else if (threatLevel >= 2)
            {
                ExecuteArmsRace();
            }
            else
            {
                InciteConflict();
            }
        }

        private void InciteConflict()
        {
            _warCount++;
            Logger.Info("WarFather", "战争之父发动【煽动冲突】");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "incite_conflict"));
        }

        private void ExecuteArmsRace()
        {
            Logger.Info("WarFather", "战争之父发动【军备竞赛】");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "arms_race"));
        }

        private void ExecuteWorldWar()
        {
            Logger.Info("WarFather", "⚠️ 战争之父发动【世界大战】！");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "world_war"));
        }

        public override void Evolve(PlayerActionData actions)
        {
            if (actions.ActionCounts.TryGetValue("peace", out int peaceCount))
            {
                if (peaceCount > 3)
                {
                    Stats["aggression_boost"] += 0.5f;
                    Logger.Debug("WarFather", "战争之父进化: 增强攻击性");
                }
            }
        }

        public override int GetThreatLevel()
        {
            return base.GetThreatLevel() + (_warCount / 3);
        }
    }
}
