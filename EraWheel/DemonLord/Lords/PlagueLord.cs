using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.DemonLord.Lords
{
    public class PlagueLord : DemonLordBase
    {
        private readonly SpawnSystem _spawn = new SpawnSystem();
        private readonly StrongholdSystem _stronghold = new StrongholdSystem();

        public PlagueLord() : base(new DemonLordDefinition
        {
            Id = "plague_lord",
            Type = DemonLordType.Plague,
            NameKey = "demon.plague_lord.name",
            DangerLevel = 3,
            BaseHealth = 100f
        })
        {
        }

        protected override void OnUpdate(ModConfig cfg, EraPhase eraPhase)
        {
        }

        public override void OnSelectedForAwakening(int cycleCount)
        {
            _spawn.LogSpawnAttempt(Id);
            _spawn.TrySpawnPlaceholder(Id);
            _stronghold.CreateStronghold(Id);
        }
    }
}
