using EraOfWheel.Core;
using EraOfWheel.Core.Events;

namespace EraOfWheel.DemonLords
{
    /// <summary>
    /// 亵渎者 - 堕落使徒
    /// </summary>
    public class Desecrator : BaseDemonLord
    {
        public override string Id => "desecrator";
        public override string Name => "亵渎者";
        public override string Title => "堕落使徒";
        public override string Description => "信仰腐蚀者，将神圣扭曲为亵渎。他在信徒心中播下怀疑的种子，让虔诚转化为狂热。";
        public override DemonLordType Type => DemonLordType.Heresy;

        private int _corruptedFaith = 0;

        protected override void InitializeStats()
        {
            Stats["corruption_influence"] = 1.5f;
            Stats["heresy_spread"] = 0.3f;
            Stats["cult_power"] = 0f;
        }

        protected override void InitializeAbilities()
        {
            UnlockedAbilities.Add("seed_of_doubt");
        }

        public override void ExecuteInvasion()
        {
            if (!IsAwakened) return;

            var threatLevel = GetThreatLevel();
            
            if (threatLevel >= 4)
                ExecuteDarkReligion();
            else if (threatLevel >= 2)
                ExecuteHeresySpread();
            else
                ExecuteCorruption();
        }

        private void ExecuteCorruption()
        {
            _corruptedFaith++;
            Stats["cult_power"] += 0.1f;
            Logger.Info("Desecrator", "亵渎者发动【信仰腐蚀】");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "faith_corruption"));
        }

        private void ExecuteHeresySpread()
        {
            Logger.Info("Desecrator", "亵渎者发动【异端传播】");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "heresy_spread"));
        }

        private void ExecuteDarkReligion()
        {
            Logger.Info("Desecrator", "⚠️ 亵渎者发动【黑暗崇拜】！");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "dark_religion"));
        }

        public override void Evolve(PlayerActionData actions)
        {
            if (actions.ActionCounts.TryGetValue("religion", out int religionCount))
            {
                if (religionCount > 3)
                {
                    Stats["corruption_influence"] += 0.4f;
                    Logger.Debug("Desecrator", "亵渎者进化: 增强腐蚀影响");
                }
            }
        }

        public override int GetThreatLevel()
        {
            return base.GetThreatLevel() + (int)(Stats["cult_power"]);
        }
    }
}
