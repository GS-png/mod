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
            ProtectCivilization
        }

        public static Priority GetCurrentPriority(HeroData hero, CycleManager cycle, ModConfig cfg)
        {
            if (hero == null || cycle == null) return Priority.SelfPreserve;

            var phase = cycle.CurrentPhase;

            if (phase == EraPhase.Weakening)
            {
                return Priority.ChallengeDemonLord;
            }

            if (phase == EraPhase.Peak)
            {
                if (hero.GeneralsDefeated < 3)
                {
                    return Priority.HuntGenerals;
                }
                return Priority.SelfPreserve;
            }

            if (phase == EraPhase.Invasion)
            {
                return Priority.ProtectCivilization;
            }

            return Priority.SelfPreserve;
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

                case Priority.ProtectCivilization:
                    Log.Info("[EraWheel] Hero " + hero.Id + " protecting civilization");
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
                    if (hero.InheritedTraits[i] == "legacy_hero_blood")
                    {
                        multiplier += 0.2f;
                    }
                }
            }

            return multiplier;
        }
    }
}
