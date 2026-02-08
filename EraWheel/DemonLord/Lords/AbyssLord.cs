using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.DemonLord.Lords
{
    public class AbyssLord : DemonLordBase
    {
        private readonly SpawnSystem _spawn = new SpawnSystem();
        private readonly StrongholdSystem _stronghold = new StrongholdSystem();

        private float _madnessLevel;
        private int _corruptedMinds;
        private bool _gazeActive;

        public float MadnessLevel => _madnessLevel;
        public int CorruptedMinds => _corruptedMinds;
        public bool GazeActive => _gazeActive;

        public AbyssLord() : base(new DemonLordDefinition
        {
            Id = "abyss_lord",
            Type = DemonLordType.Abyss,
            NameKey = "demon.abyss_lord.name",
            DangerLevel = 5,
            BaseHealth = 90f
        })
        {
        }

        protected override void OnUpdate(ModConfig cfg, EraPhase eraPhase)
        {
            if (eraPhase == EraPhase.Invasion || eraPhase == EraPhase.Peak)
            {
                UpdateMadness(cfg);
            }

            _gazeActive = eraPhase == EraPhase.Peak && _madnessLevel > 50f;
        }

        private void UpdateMadness(ModConfig cfg)
        {
            var maxMadness = 100f;
            var madnessPerSecond = 0.1f;

            if (_madnessLevel < maxMadness)
            {
                _madnessLevel += madnessPerSecond;
                if (_madnessLevel > maxMadness)
                    _madnessLevel = maxMadness;
            }
        }

        public override void OnSelectedForAwakening(int cycleCount)
        {
            SpawnWithStronghold(_spawn, _stronghold);

            _madnessLevel = 0f;
            _corruptedMinds = 0;
            _gazeActive = false;

            Log.Info($"[AbyssLord] 深渊之眼苏醒，疯狂机制启动");
        }

        public override void OnPhaseChanged(EraPhase prev, EraPhase next)
        {
            if (next == EraPhase.Peak)
            {
                Log.Info("[AbyssLord] 深渊凝视启动");
            }
        }

        public void CorruptMind()
        {
            _corruptedMinds++;
            _madnessLevel += 2f;
            Log.Info($"[AbyssLord] 腐化心智，当前腐化数: {_corruptedMinds}");
        }
    }
}
