using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.DemonLord.Lords
{
    public class SoulLord : DemonLordBase
    {
        private readonly SpawnSystem _spawn = new SpawnSystem();
        private readonly StrongholdSystem _stronghold = new StrongholdSystem();

        private int _soulsBound;
        private float _puppeteerPower;
        private bool _massControlActive;

        public int SoulsBound => _soulsBound;
        public float PuppeteerPower => _puppeteerPower;
        public bool MassControlActive => _massControlActive;

        public SoulLord() : base(new DemonLordDefinition
        {
            Id = "soul_lord",
            Type = DemonLordType.Soul,
            NameKey = "demon.soul_lord.name",
            DangerLevel = 5,
            BaseHealth = 85f
        })
        {
        }

        protected override void OnUpdate(ModConfig cfg, EraPhase eraPhase)
        {
            if (eraPhase == EraPhase.Invasion || eraPhase == EraPhase.Peak)
            {
                UpdatePuppeteerPower(cfg);
            }

            var maxBoundPercent = 30f;
            var totalPopulation = WorldCompat.GetTotalPopulation();
            if (totalPopulation > 0)
            {
                var boundPercent = (_soulsBound * 100f) / totalPopulation;
                _massControlActive = boundPercent < maxBoundPercent;
            }
        }

        private void UpdatePuppeteerPower(ModConfig cfg)
        {
            var maxPower = 100f;
            if (_puppeteerPower < maxPower)
            {
                _puppeteerPower += 0.15f;
                if (_puppeteerPower > maxPower)
                    _puppeteerPower = maxPower;
            }
        }

        public override void OnSelectedForAwakening(int cycleCount)
        {
            _spawn.LogSpawnAttempt(Id);
            _spawn.TrySpawnPlaceholder(Id);
            _stronghold.CreateStronghold(Id);

            _soulsBound = 0;
            _puppeteerPower = 0f;
            _massControlActive = false;

            Log.Info($"[SoulLord] 灵魂编织者苏醒，傀儡机制启动");
        }

        public override void OnPhaseChanged(EraPhase prev, EraPhase next)
        {
            if (next == EraPhase.Invasion)
            {
                _massControlActive = true;
                Log.Info("[SoulLord] 开始绑定灵魂");
            }
        }

        public void BindSoul()
        {
            _soulsBound++;
            _puppeteerPower += 1f;
            Log.Info($"[SoulLord] 绑定灵魂，当前数量: {_soulsBound}");
        }
    }
}
