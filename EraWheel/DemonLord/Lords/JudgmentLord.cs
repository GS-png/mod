using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.DemonLord.Lords
{
    public class JudgmentLord : DemonLordBase
    {
        private readonly SpawnSystem _spawn = new SpawnSystem();
        private readonly StrongholdSystem _stronghold = new StrongholdSystem();

        private float _judgmentProgress;
        private int _judgedSouls;
        private bool _finalJudgmentActive;

        public float JudgmentProgress => _judgmentProgress;
        public int JudgedSouls => _judgedSouls;
        public bool FinalJudgmentActive => _finalJudgmentActive;

        public JudgmentLord() : base(new DemonLordDefinition
        {
            Id = "judgment_lord",
            Type = DemonLordType.Judgment,
            NameKey = "demon.judgment_lord.name",
            DangerLevel = 5,
            BaseHealth = 150f
        })
        {
        }

        protected override void OnUpdate(ModConfig cfg, EraPhase eraPhase)
        {
            if (eraPhase == EraPhase.Invasion || eraPhase == EraPhase.Peak)
            {
                UpdateJudgmentProgress(cfg);
            }

            _finalJudgmentActive = _judgmentProgress >= 100f && eraPhase == EraPhase.Peak;

            if (_finalJudgmentActive)
            {
                var maxJudgedPercent = 50f;
                var totalPopulation = WorldCompat.GetTotalPopulation();
                if (totalPopulation > 0)
                {
                    var judgedPercent = (_judgedSouls * 100f) / totalPopulation;
                    if (judgedPercent >= maxJudgedPercent)
                    {
                        _finalJudgmentActive = false;
                    }
                }
            }
        }

        private void UpdateJudgmentProgress(ModConfig cfg)
        {
            if (_judgmentProgress < 100f)
            {
                _judgmentProgress += 0.08f;
                if (_judgmentProgress > 100f)
                    _judgmentProgress = 100f;
            }
        }

        public override void OnSelectedForAwakening(int cycleCount)
        {
            SpawnWithStronghold(_spawn, _stronghold);

            _judgmentProgress = 0f;
            _judgedSouls = 0;
            _finalJudgmentActive = false;

            Log.Info($"[JudgmentLord] 审判天使苏醒，审判机制启动");
        }

        public override void OnPhaseChanged(EraPhase prev, EraPhase next)
        {
            if (next == EraPhase.Peak && _judgmentProgress >= 100f)
            {
                _finalJudgmentActive = true;
                Log.Info("[JudgmentLord] 最终审判启动");
            }
        }

        public void JudgeSoul()
        {
            _judgedSouls++;
            _judgmentProgress += 0.5f;
            Log.Info($"[JudgmentLord] 审判灵魂，当前数量: {_judgedSouls}");
        }
    }
}
