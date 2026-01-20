using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.DemonLord.Lords
{
    public class DeathLord : DemonLordBase
    {
        private readonly SpawnSystem _spawn = new SpawnSystem();
        private readonly StrongholdSystem _stronghold = new StrongholdSystem();

        private int _soulsHarvested;
        private int _undeadRaised;
        private bool _deathAuraActive;

        public int SoulsHarvested => _soulsHarvested;
        public int UndeadRaised => _undeadRaised;
        public bool DeathAuraActive => _deathAuraActive;

        public DeathLord() : base(new DemonLordDefinition
        {
            Id = "death_lord",
            Type = DemonLordType.Death,
            NameKey = "demon.death_lord.name",
            DangerLevel = 4,
            BaseHealth = 100f
        })
        {
        }

        protected override void OnUpdate(ModConfig cfg, EraPhase eraPhase)
        {
            _deathAuraActive = eraPhase == EraPhase.Invasion || eraPhase == EraPhase.Peak;

            if (_deathAuraActive)
            {
                var maxUndead = 500;
                if (_undeadRaised >= maxUndead)
                {
                    _deathAuraActive = false;
                }
            }
        }

        public override void OnSelectedForAwakening(int cycleCount)
        {
            _spawn.LogSpawnAttempt(Id);
            _spawn.TrySpawnPlaceholder(Id);
            _stronghold.CreateStronghold(Id);

            _soulsHarvested = 0;
            _undeadRaised = 0;
            _deathAuraActive = false;

            Log.Info($"[DeathLord] 死亡收割者苏醒，亡灵机制启动");
        }

        public override void OnPhaseChanged(EraPhase prev, EraPhase next)
        {
            if (next == EraPhase.Invasion)
            {
                _deathAuraActive = true;
                Log.Info("[DeathLord] 死亡光环启动");
            }
        }

        public void HarvestSoul()
        {
            _soulsHarvested++;

            if (_soulsHarvested % 10 == 0)
            {
                RaiseUndead();
            }
        }

        public void RaiseUndead()
        {
            _undeadRaised++;
            Log.Info($"[DeathLord] 召唤亡灵，当前数量: {_undeadRaised}");
        }
    }
}
