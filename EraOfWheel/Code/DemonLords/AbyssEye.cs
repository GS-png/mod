using System.Collections.Generic;
using EraOfWheel.Core;
using EraOfWheel.Core.Events;

namespace EraOfWheel.DemonLords
{
    /// <summary>
    /// 深渊之眼 - 全知窥视者
    /// </summary>
    public class AbyssEye : BaseDemonLord
    {
        public override string Id => "abyss_eye";
        public override string Name => "深渊之眼";
        public override string Title => "全知窥视者";
        public override string Description => "无所不见的深渊意识，能预知未来并操纵心智。它的凝视带来疯狂，它的低语动摇信念。";
        public override DemonLordType Type => DemonLordType.Abyss;

        private List<string> _knownSecrets = new List<string>();
        private int _psychicInfluence = 0;

        protected override void InitializeStats()
        {
            Stats["prophecy_power"] = 1.5f;
            Stats["mind_control"] = 0.2f;
            Stats["fear_radius"] = 30f;
        }

        protected override void InitializeAbilities()
        {
            UnlockedAbilities.Add("dark_vision");
        }

        public override void ExecuteInvasion()
        {
            if (!IsAwakened) return;

            var threatLevel = GetThreatLevel();
            
            if (threatLevel >= 4)
                ExecuteMassHysteria();
            else if (threatLevel >= 2)
                ExecuteMindWhisper();
            else
                ExecuteProphecy();
        }

        private void ExecuteProphecy()
        {
            Logger.Info("AbyssEye", "深渊之眼发动【黑暗预言】");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "prophecy"));
        }

        private void ExecuteMindWhisper()
        {
            _psychicInfluence++;
            Logger.Info("AbyssEye", "深渊之眼发动【心灵低语】");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "mind_whisper"));
        }

        private void ExecuteMassHysteria()
        {
            Logger.Info("AbyssEye", "⚠️ 深渊之眼发动【群体癔症】！");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "mass_hysteria"));
        }

        public override void Evolve(PlayerActionData actions)
        {
            if (actions.ActionCounts.TryGetValue("spy", out int spyCount))
            {
                if (spyCount > 3)
                {
                    Stats["prophecy_power"] += 0.3f;
                    Logger.Debug("AbyssEye", "深渊之眼进化: 增强预知能力");
                }
            }
        }
    }
}
