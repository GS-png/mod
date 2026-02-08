using System;
using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.DemonLord.Lords
{
    public class VoidLord : DemonLordBase
    {
        private readonly SpawnSystem _spawn = new SpawnSystem();
        private readonly StrongholdSystem _stronghold = new StrongholdSystem();

        private float _voidPressure;
        private int _riftCount;
        private bool _riftActive;

        public float VoidPressure => _voidPressure;
        public int RiftCount => _riftCount;
        public bool RiftActive => _riftActive;

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
            if (eraPhase == EraPhase.Invasion || eraPhase == EraPhase.Peak)
            {
                var growth = 0.25f;
                _voidPressure = Math.Min(100f, _voidPressure + growth);

                if (_voidPressure >= 100f)
                {
                    TriggerVoidRift();
                    _voidPressure = 0f;
                }
            }
            else
            {
                _voidPressure = Math.Max(0f, _voidPressure - 0.5f);
                _riftActive = false;
            }

            if (_riftActive && _voidPressure > 10f)
            {
                _riftActive = false;
            }
        }

        public override void OnSelectedForAwakening(int cycleCount)
        {
            SpawnWithStronghold(_spawn, _stronghold);
            _voidPressure = 0f;
            _riftCount = 0;
            _riftActive = false;
            Log.Info("[VoidLord] 虚空裂隙机制启动");
        }

        private void TriggerVoidRift()
        {
            _riftCount++;
            _riftActive = true;
            try
            {
                EventBus.Publish(new DemonLordMechanicEvent
                {
                    DemonLordId = Id,
                    MechanicId = "void_rift",
                    Value = _riftCount,
                    WorldTime = WorldCompat.GetWorldAge()
                });
            }
            catch
            {
            }

            Log.Info($"[VoidLord] 虚空裂隙开启，累计次数: {_riftCount}");
        }
    }
}
