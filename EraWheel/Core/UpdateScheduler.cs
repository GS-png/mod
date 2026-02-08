using System;
using EraWheel.Config;

namespace EraWheel.Core
{
    public static class UpdateScheduler
    {
        private static int FrameCount;
        private static int _demonInterval = 1;
        private static int _legionInterval = 5;
        private static int _heroInterval = 10;
        private static int _civInterval = 30;
        private static int _aiInterval = 300;

        public static Action OnCycle;
        public static Action OnEveryFrame;
        public static Action OnDemonLord;
        public static Action OnLegion;
        public static Action OnHero;
        public static Action OnCivilization;
        public static Action OnAiStory;
        public static Action OnNarrative;

        public static void Reset()
        {
            FrameCount = 0;
            SetDefaultIntervals();
        }

        public static void Update(ModConfig cfg)
        {
            FrameCount++;
            if (FrameCount == int.MaxValue)
            {
                FrameCount = 0;
            }

            ApplyConfig(cfg);
            OnCycle?.Invoke();
            OnEveryFrame?.Invoke();

            if (FrameCount % _demonInterval == 0) OnDemonLord?.Invoke();
            if (FrameCount % _legionInterval == 0) OnLegion?.Invoke();
            if (FrameCount % _heroInterval == 0) OnHero?.Invoke();
            if (FrameCount % _civInterval == 0) OnCivilization?.Invoke();
            if (FrameCount % _aiInterval == 0) OnAiStory?.Invoke();
            OnNarrative?.Invoke();
        }

        private static void ApplyConfig(ModConfig cfg)
        {
            if (cfg?.performance?.update_intervals == null)
            {
                SetDefaultIntervals();
                return;
            }

            var intervals = cfg.performance.update_intervals;

            var demon = intervals.demon_lord;
            if (demon < 1) demon = 1;
            if (demon != _demonInterval) _demonInterval = demon;

            var legion = intervals.legion;
            if (legion < 1) legion = 1;
            if (legion != _legionInterval) _legionInterval = legion;

            var hero = intervals.hero;
            if (hero < 1) hero = 1;
            if (hero != _heroInterval) _heroInterval = hero;

            var civ = intervals.civilization;
            if (civ < 1) civ = 1;
            if (civ != _civInterval) _civInterval = civ;

            var ai = intervals.ai_story;
            if (ai < 1) ai = 1;
            if (ai != _aiInterval) _aiInterval = ai;
        }

        private static void SetDefaultIntervals()
        {
            _demonInterval = 1;
            _legionInterval = 5;
            _heroInterval = 10;
            _civInterval = 30;
            _aiInterval = 300;
        }
    }
}
