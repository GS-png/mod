using System;
using EraWheel.Config;

namespace EraWheel.Core
{
    public static class UpdateScheduler
    {
        private static int FrameCount;

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
        }

        public static void Update(ModConfig cfg)
        {
            FrameCount++;
            OnCycle?.Invoke();
            OnEveryFrame?.Invoke();

            var demonInterval = 1;
            var legionInterval = 5;
            var heroInterval = 10;
            var civInterval = 30;
            var aiInterval = 300;

            if (cfg != null && cfg.performance != null && cfg.performance.update_intervals != null)
            {
                demonInterval = Math.Max(1, cfg.performance.update_intervals.demon_lord);
                legionInterval = Math.Max(1, cfg.performance.update_intervals.legion);
                heroInterval = Math.Max(1, cfg.performance.update_intervals.hero);
                civInterval = Math.Max(1, cfg.performance.update_intervals.civilization);
                aiInterval = Math.Max(1, cfg.performance.update_intervals.ai_story);
            }

            if (FrameCount % demonInterval == 0) OnDemonLord?.Invoke();
            if (FrameCount % legionInterval == 0) OnLegion?.Invoke();
            if (FrameCount % heroInterval == 0) OnHero?.Invoke();
            if (FrameCount % civInterval == 0) OnCivilization?.Invoke();
            if (FrameCount % aiInterval == 0) OnAiStory?.Invoke();
            if (FrameCount % aiInterval == 0) OnNarrative?.Invoke();
        }
    }
}
