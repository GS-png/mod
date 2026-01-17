using EraOfWheel.Core;
using EraOfWheel.Core.Events;

namespace EraOfWheel.DemonLords
{
    /// <summary>
    /// 熵噬者 - 时间腐蚀者
    /// </summary>
    public class EntropyDevourer : BaseDemonLord
    {
        public override string Id => "entropy_devourer";
        public override string Name => "熵噬者";
        public override string Title => "时间腐蚀者";
        public override string Description => "以时间本身为食的存在，其触及之处时间加速衰老，一切终将归于虚无。";
        public override DemonLordType Type => DemonLordType.Entropy;

        private float _timeDistortion = 1.0f;

        protected override void InitializeStats()
        {
            Stats["time_acceleration"] = 1.5f;
            Stats["decay_rate"] = 0.3f;
            Stats["entropy_radius"] = 20f;
        }

        protected override void InitializeAbilities()
        {
            UnlockedAbilities.Add("time_warp");
        }

        public override void ExecuteInvasion()
        {
            if (!IsAwakened) return;

            var threatLevel = GetThreatLevel();
            
            if (threatLevel >= 4)
            {
                ExecuteTemporalCollapse();
            }
            else if (threatLevel >= 2)
            {
                ExecuteTimeAcceleration();
            }
            else
            {
                ExecuteDecay();
            }
        }

        private void ExecuteDecay()
        {
            Logger.Info("EntropyDevourer", "熵噬者发动【衰变】");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "decay"));
        }

        private void ExecuteTimeAcceleration()
        {
            _timeDistortion *= Stats["time_acceleration"];
            Logger.Info("EntropyDevourer", $"熵噬者发动【时间加速】倍率: {_timeDistortion:F1}x");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "time_acceleration"));
        }

        private void ExecuteTemporalCollapse()
        {
            Logger.Info("EntropyDevourer", "⚠️ 熵噬者发动【时间崩塌】！");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "temporal_collapse"));
        }

        public override void Evolve(PlayerActionData actions)
        {
            if (actions.ActionCounts.TryGetValue("build", out int buildCount))
            {
                if (buildCount > 5)
                {
                    Stats["decay_rate"] += 0.1f;
                    Logger.Debug("EntropyDevourer", "熵噬者进化: 增强衰变速度");
                }
            }
        }
    }
}
