using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.DemonLord.Lords
{
    public class NatureLord : DemonLordBase
    {
        private readonly SpawnSystem _spawn = new SpawnSystem();
        private readonly StrongholdSystem _stronghold = new StrongholdSystem();

        private float _wildGrowth;
        private int _corruptedForests;
        private bool _beastRageActive;

        public float WildGrowth => _wildGrowth;
        public int CorruptedForests => _corruptedForests;
        public bool BeastRageActive => _beastRageActive;

        public NatureLord() : base(new DemonLordDefinition
        {
            Id = "nature_lord",
            Type = DemonLordType.Nature,
            NameKey = "demon.nature_lord.name",
            DangerLevel = 3,
            BaseHealth = 130f
        })
        {
        }

        protected override void OnUpdate(ModConfig cfg, EraPhase eraPhase)
        {
            if (eraPhase == EraPhase.Invasion || eraPhase == EraPhase.Peak)
            {
                UpdateWildGrowth(cfg);
            }

            var maxForestPercent = 60f;
            var totalForests = 1000;
            var corruptedPercent = (_corruptedForests * 100f) / totalForests;
            _beastRageActive = corruptedPercent < maxForestPercent;
        }

        private void UpdateWildGrowth(ModConfig cfg)
        {
            var maxGrowth = 100f;
            if (_wildGrowth < maxGrowth)
            {
                _wildGrowth += 0.25f;
                if (_wildGrowth > maxGrowth)
                    _wildGrowth = maxGrowth;
            }
        }

        public override void OnSelectedForAwakening(int cycleCount)
        {
            SpawnWithStronghold(_spawn, _stronghold);

            _wildGrowth = 0f;
            _corruptedForests = 0;
            _beastRageActive = false;

            Log.Info($"[NatureLord] 荒野主宰苏醒，自然腐化机制启动");
        }

        public override void OnPhaseChanged(EraPhase prev, EraPhase next)
        {
            if (next == EraPhase.Invasion)
            {
                _beastRageActive = true;
                Log.Info("[NatureLord] 野兽狂暴启动");
            }
        }

        public void CorruptForest()
        {
            _corruptedForests++;
            _wildGrowth += 3f;
            Log.Info($"[NatureLord] 腐化森林，当前数量: {_corruptedForests}");
        }
    }
}
