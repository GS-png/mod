using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.DemonLord.Lords
{
    public class FlameLord : DemonLordBase
    {
        private readonly SpawnSystem _spawn = new SpawnSystem();
        private readonly StrongholdSystem _stronghold = new StrongholdSystem();

        private float _infernoIntensity;
        private int _burntTiles;
        private bool _volcanoActive;

        public float InfernoIntensity => _infernoIntensity;
        public int BurntTiles => _burntTiles;
        public bool VolcanoActive => _volcanoActive;

        public FlameLord() : base(new DemonLordDefinition
        {
            Id = "flame_lord",
            Type = DemonLordType.Flame,
            NameKey = "demon.flame_lord.name",
            DangerLevel = 4,
            BaseHealth = 110f
        })
        {
        }

        protected override void OnUpdate(ModConfig cfg, EraPhase eraPhase)
        {
            if (eraPhase == EraPhase.Invasion || eraPhase == EraPhase.Peak)
            {
                UpdateInfernoIntensity(cfg);
            }

            _volcanoActive = eraPhase == EraPhase.Peak;
        }

        private void UpdateInfernoIntensity(ModConfig cfg)
        {
            var maxIntensity = 100f;
            var maxBurntPercent = 40f;

            if (_infernoIntensity < maxIntensity)
            {
                _infernoIntensity += 0.2f;
                if (_infernoIntensity > maxIntensity)
                    _infernoIntensity = maxIntensity;
            }

            var worldTiles = 10000;
            var currentBurntPercent = (_burntTiles * 100f) / worldTiles;
            if (currentBurntPercent >= maxBurntPercent)
            {
                _infernoIntensity *= 0.5f;
            }
        }

        public override void OnSelectedForAwakening(int cycleCount)
        {
            _spawn.LogSpawnAttempt(Id);
            _spawn.TrySpawnPlaceholder(Id);
            _stronghold.CreateStronghold(Id);

            _infernoIntensity = 0f;
            _burntTiles = 0;
            _volcanoActive = false;

            Log.Info($"[FlameLord] 炎狱君王苏醒，烈焰机制启动");
        }

        public override void OnPhaseChanged(EraPhase prev, EraPhase next)
        {
            if (next == EraPhase.Peak)
            {
                _volcanoActive = true;
                Log.Info("[FlameLord] 火山喷发！");
            }
        }

        public void BurnTile()
        {
            _burntTiles++;
            _infernoIntensity += 0.5f;
        }
    }
}
