using System;
using EraOfWheel.Core;
using EraOfWheel.Core.Events;

namespace EraOfWheel.DemonLords
{
    /// <summary>
    /// 狂乱女王 - 混沌之源
    /// </summary>
    public class ChaosQueen : BaseDemonLord
    {
        public override string Id => "chaos_queen";
        public override string Name => "狂乱女王";
        public override string Title => "混沌之源";
        public override string Description => "混沌与疯狂的化身，其存在打破一切秩序与规律。在她的领域中，唯一的法则就是没有法则。";
        public override DemonLordType Type => DemonLordType.Chaos;

        private Random _chaos = new Random();

        protected override void InitializeStats()
        {
            Stats["randomness"] = 0.5f;
            Stats["madness_spread"] = 0.2f;
            Stats["reality_distortion"] = 0.1f;
        }

        protected override void InitializeAbilities()
        {
            UnlockedAbilities.Add("random_event");
        }

        public override void ExecuteInvasion()
        {
            if (!IsAwakened) return;

            // 混沌女王的行动是随机的
            var roll = _chaos.NextDouble();
            
            if (roll < 0.2f)
                ExecuteRealityWarp();
            else if (roll < 0.5f)
                SpreadMadness();
            else
                TriggerRandomEvent();
        }

        private void TriggerRandomEvent()
        {
            Logger.Info("ChaosQueen", "狂乱女王发动【随机事件】");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "random_event"));
        }

        private void SpreadMadness()
        {
            Logger.Info("ChaosQueen", "狂乱女王发动【疯狂蔓延】");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "madness"));
        }

        private void ExecuteRealityWarp()
        {
            Logger.Info("ChaosQueen", "⚠️ 狂乱女王发动【现实扭曲】！");
            EventBus.Instance?.Publish(new DemonLordInvasionEvent(this, "reality_warp"));
        }

        public override void Evolve(PlayerActionData actions)
        {
            // 混沌女王的进化也是随机的
            Stats["randomness"] += (float)_chaos.NextDouble() * 0.1f;
        }
    }
}
