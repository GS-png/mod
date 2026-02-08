using System;
using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.DemonLord.Lords
{
    public class PlagueLord : DemonLordBase
    {
        private readonly SpawnSystem _spawn = new SpawnSystem();
        private readonly StrongholdSystem _stronghold = new StrongholdSystem();

        private float _plagueIntensity;
        private int _outbreakCount;
        private bool _contagionActive;

        public float PlagueIntensity => _plagueIntensity;
        public int OutbreakCount => _outbreakCount;
        public bool ContagionActive => _contagionActive;

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
            if (eraPhase == EraPhase.Invasion || eraPhase == EraPhase.Peak)
            {
                var population = WorldCompat.GetTotalPopulation();
                var growth = 0.2f;
                if (population > 0)
                {
                    growth += Math.Min(2f, population / 5000f);
                }

                _plagueIntensity = Math.Min(100f, _plagueIntensity + growth);
                _contagionActive = _plagueIntensity >= 50f;

                if (_plagueIntensity >= 100f)
                {
                    TriggerOutbreak();
                    _plagueIntensity = 0f;
                }
            }
            else
            {
                _contagionActive = false;
                _plagueIntensity = Math.Max(0f, _plagueIntensity - 0.4f);
            }
        }

        public override void OnSelectedForAwakening(int cycleCount)
        {
            SpawnWithStronghold(_spawn, _stronghold);
            _plagueIntensity = 0f;
            _outbreakCount = 0;
            _contagionActive = false;
            Log.Info("[PlagueLord] 瘟疫蔓延机制启动");
        }

        private void TriggerOutbreak()
        {
            _outbreakCount++;
            try
            {
                EventBus.Publish(new DemonLordMechanicEvent
                {
                    DemonLordId = Id,
                    MechanicId = "plague_outbreak",
                    Value = _outbreakCount,
                    WorldTime = WorldCompat.GetWorldAge()
                });
            }
            catch
            {
            }

            Log.Info($"[PlagueLord] 爆发瘟疫，累计次数: {_outbreakCount}");
        }
    }
}
