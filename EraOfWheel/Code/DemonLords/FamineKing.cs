using EraOfWheel.Core;
using EraOfWheel.Core.Events;

namespace EraOfWheel.DemonLords
{
    /// <summary>
    /// 饥荒王 - 贪婪的饥饿
    /// </summary>
    public class FamineKing : BaseDemonLord
    {
        public override string Id => "famine_king";
        public override string Name => "饥荒王";
        public override string Title => "贪婪的饥饿";
        public override string Description => "永不满足的饥饿化身，其存在本身就是无尽的消耗。他让土地贫瘠，让河流干涸。";
        public override DemonLordType Type => DemonLordType.Famine;

        private float _resourceDrain = 0f;

        protected override void InitializeStats()
        {
            Stats["consumption_rate"] = 2.0f;
            Stats["blight_spread"] = 0.3f;
            Stats["hoarding_power"] = 1.0f;
        }

        protected override void InitializeAbilities()
        {
            UnlockedAbilities.Add("drain");
        }

        public override void ExecuteInvasion()
        {
            if (!IsAwakened) return;

            var threatLevel = GetThreatLevel();
            
            if (threatLevel >= 4)
                ExecuteGreatFamine();
            else if (threatLevel >= 2)
                ExecuteBlight();
            else
                ExecuteDrain();
        }

        private void ExecuteDrain()
        {
            _resourceDrain += Stats["consumption_rate"];
            Logger.Info("FamineKing", $"饥荒王发动【汲取】累计: {_resourceDrain:F1}");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "drain"));
        }

        private void ExecuteBlight()
        {
            Logger.Info("FamineKing", "饥荒王发动【枯萎】");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "blight"));
        }

        private void ExecuteGreatFamine()
        {
            Logger.Info("FamineKing", "⚠️ 饥荒王发动【大饥荒】！");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "great_famine"));
        }

        public override void Evolve(PlayerActionData actions)
        {
            if (actions.ActionCounts.TryGetValue("trade", out int tradeCount))
            {
                if (tradeCount > 5)
                {
                    Stats["consumption_rate"] += 0.5f;
                    Logger.Debug("FamineKing", "饥荒王进化: 增强消耗速度");
                }
            }
        }
    }
}
