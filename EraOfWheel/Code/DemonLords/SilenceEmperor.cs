using EraOfWheel.Core;
using EraOfWheel.Core.Events;

namespace EraOfWheel.DemonLords
{
    /// <summary>
    /// 寂灭大帝 - 遗忘之主
    /// </summary>
    public class SilenceEmperor : BaseDemonLord
    {
        public override string Id => "silence_emperor";
        public override string Name => "寂灭大帝";
        public override string Title => "遗忘之主";
        public override string Description => "寂静与遗忘的化身，其力量抹除一切存在的痕迹。在他的领域中，连记忆都将消散。";
        public override DemonLordType Type => DemonLordType.Silence;

        private int _erasedCount = 0;

        protected override void InitializeStats()
        {
            Stats["erasure_power"] = 1.0f;
            Stats["silence_radius"] = 25f;
            Stats["memory_decay"] = 0.1f;
        }

        protected override void InitializeAbilities()
        {
            UnlockedAbilities.Add("whisper_of_void");
        }

        public override void ExecuteInvasion()
        {
            if (!IsAwakened) return;

            var threatLevel = GetThreatLevel();
            
            if (threatLevel >= 4)
                ExecuteTotalErasure();
            else if (threatLevel >= 2)
                ExecuteCulturalDecay();
            else
                ExecuteSilence();
        }

        private void ExecuteSilence()
        {
            Logger.Info("SilenceEmperor", "寂灭大帝发动【沉默】");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "silence"));
        }

        private void ExecuteCulturalDecay()
        {
            _erasedCount++;
            Logger.Info("SilenceEmperor", "寂灭大帝发动【文化衰退】");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "cultural_decay"));
        }

        private void ExecuteTotalErasure()
        {
            Logger.Info("SilenceEmperor", "⚠️ 寂灭大帝发动【完全抹除】！");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "total_erasure"));
        }

        public override void Evolve(PlayerActionData actions)
        {
            if (actions.ActionCounts.TryGetValue("culture", out int cultureCount))
            {
                if (cultureCount > 4)
                {
                    Stats["memory_decay"] += 0.05f;
                    Logger.Debug("SilenceEmperor", "寂灭大帝进化: 增强遗忘能力");
                }
            }
        }
    }
}
