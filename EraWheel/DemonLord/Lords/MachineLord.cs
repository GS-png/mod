using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.DemonLord.Lords
{
    public class MachineLord : DemonLordBase
    {
        private readonly SpawnSystem _spawn = new SpawnSystem();
        private readonly StrongholdSystem _stronghold = new StrongholdSystem();

        private float _techAbsorption;
        private int _corruptedCities;

        public float TechAbsorption => _techAbsorption;
        public int CorruptedCities => _corruptedCities;

        public MachineLord() : base(new DemonLordDefinition
        {
            Id = "machine_lord",
            Type = DemonLordType.Machine,
            NameKey = "demon.machine_lord.name",
            DangerLevel = 4,
            BaseHealth = 120f
        })
        {
        }

        protected override void OnUpdate(ModConfig cfg, EraPhase eraPhase)
        {
            if (eraPhase == EraPhase.Invasion || eraPhase == EraPhase.Peak)
            {
                UpdateTechAbsorption(cfg);
            }
        }

        private void UpdateTechAbsorption(ModConfig cfg)
        {
            var maxAbsorption = 50f;
            if (_techAbsorption < maxAbsorption)
            {
                _techAbsorption += 0.1f;
                if (_techAbsorption > maxAbsorption)
                    _techAbsorption = maxAbsorption;
            }
        }

        public override void OnSelectedForAwakening(int cycleCount)
        {
            SpawnWithStronghold(_spawn, _stronghold);

            _techAbsorption = 0f;
            _corruptedCities = 0;

            Log.Info($"[MachineLord] 机械暴君苏醒，科技吸收机制启动");
        }

        public override void OnPhaseChanged(EraPhase prev, EraPhase next)
        {
            if (next == EraPhase.Invasion)
            {
                Log.Info("[MachineLord] 开始腐化文明科技");
            }
        }

        public void CorruptCity()
        {
            _corruptedCities++;
            _techAbsorption += 5f;
            Log.Info($"[MachineLord] 腐化城市，当前腐化数: {_corruptedCities}");
        }
    }
}
