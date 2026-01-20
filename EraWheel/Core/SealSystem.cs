using EraWheel.Config;

namespace EraWheel.Core
{
    public class SealSystem
    {
        public float SealStrength { get; private set; }

        private long _lastWorldAge;
        private long _weakeningStartWorldAge;
        private float _allianceSealProgress;

        public void Reset(ModConfig cfg, long worldAge)
        {
            try
            {
                EventBus.Subscribe<AllianceSealProgressEvent>(OnAllianceSealProgress);
            }
            catch
            {
            }

            SealStrength = cfg != null && cfg.cycle != null && cfg.cycle.seal != null ? cfg.cycle.seal.initial_strength : 100f;
            _lastWorldAge = worldAge;
            _weakeningStartWorldAge = -1;
            _allianceSealProgress = 0f;
        }

        private void OnAllianceSealProgress(AllianceSealProgressEvent evt)
        {
            var p = evt.Progress;
            if (p < 0f) p = 0f;
            if (p > 100f) p = 100f;
            _allianceSealProgress = p;
        }

        public void SetSealStrength(float strength)
        {
            SealStrength = Clamp(strength, 0f, 100f);
        }

        public void MarkWeakeningStart(long worldAge)
        {
            if (_weakeningStartWorldAge < 0)
            {
                _weakeningStartWorldAge = worldAge;
            }
        }

        public void ClearWeakeningStart()
        {
            _weakeningStartWorldAge = -1;
        }

        public void Update(ModConfig cfg, long worldAge, EraPhase phase)
        {
            if (phase != EraPhase.Sealed)
            {
                _lastWorldAge = worldAge;
                return;
            }

            var decayRate = cfg != null && cfg.cycle != null && cfg.cycle.seal != null ? cfg.cycle.seal.decay_rate_per_year : 0.5f;

            var deltaYears = worldAge - _lastWorldAge;
            if (deltaYears <= 0)
            {
                return;
            }

            _lastWorldAge = worldAge;
            var newStrength = SealStrength - (float)deltaYears * decayRate;
            SealStrength = Clamp(newStrength, 0f, 100f);
        }

        public bool IsSealWeakened()
        {
            return SealStrength < 30f;
        }

        public bool CheckSealSuccess(ModConfig cfg, long worldAge, float demonHealthPercent)
        {
            if (cfg == null || cfg.cycle == null || cfg.cycle.seal == null || cfg.cycle.seal.victory_conditions == null)
            {
                return false;
            }

            var vc = cfg.cycle.seal.victory_conditions;

            if (vc.execution)
            {
                if (demonHealthPercent <= 0f) return true;
            }

            if (vc.time_window)
            {
                if (_weakeningStartWorldAge >= 0)
                {
                    var duration = worldAge - _weakeningStartWorldAge;
                    if (duration >= 50) return true;
                }
            }

            if (vc.alliance)
            {
                if (_allianceSealProgress >= 100f) return true;
            }

            return false;
        }

        private static float Clamp(float v, float min, float max)
        {
            if (v < min) return min;
            if (v > max) return max;
            return v;
        }
    }
}
