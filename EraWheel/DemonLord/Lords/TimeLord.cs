using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.DemonLord.Lords
{
    public class TimeLord : DemonLordBase
    {
        private readonly SpawnSystem _spawn = new SpawnSystem();
        private readonly StrongholdSystem _stronghold = new StrongholdSystem();

        private float _timeDistortion;
        private int _ageAbsorbed;
        private bool _chronoShieldActive;

        public float TimeDistortion => _timeDistortion;
        public int AgeAbsorbed => _ageAbsorbed;
        public bool ChronoShieldActive => _chronoShieldActive;

        public TimeLord() : base(new DemonLordDefinition
        {
            Id = "time_lord",
            Type = DemonLordType.Time,
            NameKey = "demon.time_lord.name",
            DangerLevel = 5,
            BaseHealth = 80f
        })
        {
        }

        protected override void OnUpdate(ModConfig cfg, EraPhase eraPhase)
        {
            if (eraPhase == EraPhase.Invasion || eraPhase == EraPhase.Peak)
            {
                UpdateTimeDistortion(cfg);
            }

            if (eraPhase == EraPhase.Weakening && CurrentHealthPercent < 30f)
            {
                _chronoShieldActive = true;
            }
            else
            {
                _chronoShieldActive = false;
            }
        }

        private void UpdateTimeDistortion(ModConfig cfg)
        {
            var maxDistortion = 30f;
            if (_timeDistortion < maxDistortion)
            {
                _timeDistortion += 0.05f;
                if (_timeDistortion > maxDistortion)
                    _timeDistortion = maxDistortion;
            }
        }

        public override void OnSelectedForAwakening(int cycleCount)
        {
            _spawn.LogSpawnAttempt(Id);
            _spawn.TrySpawnPlaceholder(Id);
            _stronghold.CreateStronghold(Id);

            _timeDistortion = 0f;
            _ageAbsorbed = 0;
            _chronoShieldActive = false;

            Log.Info($"[TimeLord] 时间吞噬者苏醒，时间扭曲机制启动");
        }

        public override void OnPhaseChanged(EraPhase prev, EraPhase next)
        {
            if (next == EraPhase.Invasion)
            {
                Log.Info("[TimeLord] 开始扭曲时间流速");
            }
        }

        public void AbsorbAge(int years)
        {
            _ageAbsorbed += years;
            _timeDistortion += years * 0.1f;
            Log.Info($"[TimeLord] 吸收时间 {years} 年，总计: {_ageAbsorbed}");
        }
    }
}
