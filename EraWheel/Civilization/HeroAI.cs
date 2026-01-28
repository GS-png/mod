using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.Civilization
{
    public static class HeroAI
    {
        public enum Priority
        {
            SelfPreserve,
            ChallengeDemonLord,
            HuntGenerals,
            Train
        }

        public static Priority GetCurrentPriority(HeroData hero, CycleManager cycle, ModConfig cfg, float? healthRatio = null)
        {
            if (hero == null || cycle == null) return Priority.SelfPreserve;

            var hp = healthRatio ?? 1f;
            if (hp < 0.3f)
            {
                return Priority.SelfPreserve;
            }

            var phase = cycle.CurrentPhase;

            var demonActive = phase == EraPhase.Invasion || phase == EraPhase.Peak || phase == EraPhase.Weakening;
            if (demonActive)
            {
                var heroStrength = GetHeroStrengthScore(hero, hp);
                var demonStrength = cycle.DemonHealthPercent / 100f;
                if (demonStrength < 0f) demonStrength = 0f;
                if (demonStrength > 1f) demonStrength = 1f;

                if (heroStrength >= demonStrength * 0.5f)
                {
                    return Priority.ChallengeDemonLord;
                }
            }

            if (demonActive && hero.GeneralsDefeated < 3)
            {
                return Priority.HuntGenerals;
            }

            return Priority.Train;
        }

        public static void ExecutePriority(HeroData hero, Priority priority, CycleManager cycle)
        {
            if (hero == null || hero.State != HeroState.Alive) return;

            switch (priority)
            {
                case Priority.ChallengeDemonLord:
                    hero.DemonLordDamageDealt += 50;
                    Log.Info("[EraWheel] Hero " + hero.Id + " attacking demon lord");
                    break;

                case Priority.HuntGenerals:
                    Log.Info("[EraWheel] Hero " + hero.Id + " hunting generals");
                    break;

                case Priority.Train:
                    Log.Info("[EraWheel] Hero " + hero.Id + " training");
                    break;

                case Priority.SelfPreserve:
                default:
                    break;
            }
        }

        public static float GetDemonLordDamageMultiplier(HeroData hero)
        {
            if (hero == null) return 1f;

            var multiplier = 1f;

            if (hero.IsDestined) multiplier += 0.5f;

            if (hero.InheritedTraits != null)
            {
                for (var i = 0; i < hero.InheritedTraits.Length; i++)
                {
                    if (hero.InheritedTraits[i] == HeroConstants.BloodlineTraitId)
                    {
                        multiplier += 0.2f;
                    }
                }
            }

            return multiplier;
        }

        private static float GetHeroStrengthScore(HeroData hero, float healthRatio)
        {
            if (hero == null) return healthRatio;

            var score = healthRatio;

            if (hero.IsDestined)
            {
                score += 0.2f;
            }

            if (hero.InheritedTraits != null)
            {
                var extra = 0f;
                for (var i = 0; i < hero.InheritedTraits.Length; i++)
                {
                    if (!string.IsNullOrEmpty(hero.InheritedTraits[i]))
                    {
                        extra += 0.05f;
                    }
                }
                score += extra;
            }

            if (score < 0f) score = 0f;
            if (score > 1f) score = 1f;
            return score;
        }
    }
}
