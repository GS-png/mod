using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.Core.ExtensionModules
{
    public class RagnarokModule
    {
        private bool _active;
        private long _endWorldAge;
        private int _lastCycle = -1;

        public bool Active => _active;

        public void Initialize(ModConfig cfg)
        {
            _active = false;
            _endWorldAge = 0;
            _lastCycle = -1;
        }

        public void Update(ModConfig cfg, CycleManager cycle)
        {
            if (cfg?.expansion?.ragnarok?.enabled != true || cycle == null)
            {
                if (_active)
                {
                    _active = false;
                }
                return;
            }

            var worldAge = cycle.WorldAge;
            if (_active)
            {
                if (worldAge >= _endWorldAge || cycle.CurrentPhase == EraPhase.Sealed)
                {
                    _active = false;
                    Log.Info("[Ragnarok] 诸神黄昏结束");
                }

                return;
            }

            if (_lastCycle == cycle.CycleCount)
            {
                return;
            }

            var required = cfg.expansion.ragnarok.required_civilizations;
            var duration = cfg.expansion.ragnarok.duration_years;
            var civCount = WorldCompat.GetTotalCivilizations();

            if (civCount >= required && cycle.CurrentPhase >= EraPhase.Peak)
            {
                _active = true;
                _endWorldAge = worldAge + duration;
                _lastCycle = cycle.CycleCount;
                Log.Info("[Ragnarok] 诸神黄昏启动，持续 " + duration + " 年");
            }
        }
    }
}
