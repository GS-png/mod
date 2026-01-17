using EraOfWheel.Core;
using EraOfWheel.Core.Events;

namespace EraOfWheel.DemonLords
{
    /// <summary>
    /// 终焉之主 - 万物终结
    /// </summary>
    public class EndLord : BaseDemonLord
    {
        public override string Id => "end_lord";
        public override string Name => "终焉之主";
        public override string Title => "万物终结";
        public override string Description => "所有魔王之上的存在，代表着一切的终结。当它完全苏醒时，便是这个世界的末日。";
        public override DemonLordType Type => DemonLordType.End;

        protected override void InitializeStats()
        {
            Stats["extinction_power"] = 5.0f;
            Stats["final_countdown"] = 100f;
            Stats["apocalypse_radius"] = 999f;
        }

        protected override void InitializeAbilities()
        {
            UnlockedAbilities.Add("doom_herald");
            AwakeningThreshold = 200f; // 终焉之主需要更高的苏醒度
        }

        public override void ExecuteInvasion()
        {
            if (!IsAwakened) return;

            var threatLevel = GetThreatLevel();
            
            if (threatLevel >= 5)
            {
                ExecuteApocalypse();
            }
            else if (threatLevel >= 3)
            {
                ExecuteDoomCountdown();
            }
            else
            {
                HeraldEnd();
            }
        }

        private void HeraldEnd()
        {
            Logger.Info("EndLord", "终焉之主发动【末日预兆】");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "doom_herald"));
        }

        private void ExecuteDoomCountdown()
        {
            Stats["final_countdown"] -= 10f;
            Logger.Info("EndLord", $"终焉之主发动【末日倒计时】剩余: {Stats["final_countdown"]:F0}");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "doom_countdown"));
        }

        private void ExecuteApocalypse()
        {
            Logger.Info("EndLord", "💀 终焉之主发动【天启】！世界末日降临！");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "apocalypse"));
        }

        public override void Evolve(PlayerActionData actions)
        {
            // 终焉之主吸收所有行动的力量
            Stats["extinction_power"] += actions.TotalActions * 0.01f;
        }

        public override int GetThreatLevel()
        {
            return base.GetThreatLevel() + 2; // 终焉之主基础威胁更高
        }
    }
}
