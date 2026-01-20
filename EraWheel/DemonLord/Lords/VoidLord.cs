using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.DemonLord.Lords
{
    public class VoidLord : DemonLordBase
    {
        private readonly SpawnSystem _spawn = new SpawnSystem();
        private readonly StrongholdSystem _stronghold = new StrongholdSystem();

        public VoidLord() : base(new DemonLordDefinition
        {
            Id = "void_lord",
            Type = DemonLordType.Void,
            NameKey = "demon.void_lord.name",
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
