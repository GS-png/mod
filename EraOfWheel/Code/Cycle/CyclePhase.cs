namespace EraOfWheel.Cycle
{
    public enum CyclePhase
    {
        Sealed,
        Omen,
        Awakening,
        Invasion,
        Peak,
        Weakening,
        Resealed
    }

    public static class CyclePhaseExtensions
    {
        public static string ToDisplayName(this CyclePhase phase)
        {
            switch (phase)
            {
                case CyclePhase.Sealed: return "封印状态";
                case CyclePhase.Omen: return "预兆阶段";
                case CyclePhase.Awakening: return "苏醒准备";
                case CyclePhase.Invasion: return "正式降临";
                case CyclePhase.Peak: return "全盛期";
                case CyclePhase.Weakening: return "衰弱期";
                case CyclePhase.Resealed: return "被封印";
                default: return phase.ToString();
            }
        }

        public static bool IsCombatPhase(this CyclePhase phase)
        {
            return phase == CyclePhase.Awakening ||
                   phase == CyclePhase.Invasion ||
                   phase == CyclePhase.Peak ||
                   phase == CyclePhase.Weakening;
        }

        public static bool CanTransitionTo(this CyclePhase current, CyclePhase target)
        {
            switch (current)
            {
                case CyclePhase.Sealed:
                    return target == CyclePhase.Omen;
                case CyclePhase.Omen:
                    return target == CyclePhase.Awakening || target == CyclePhase.Sealed;
                case CyclePhase.Awakening:
                    return target == CyclePhase.Invasion || target == CyclePhase.Sealed;
                case CyclePhase.Invasion:
                    return target == CyclePhase.Peak || target == CyclePhase.Weakening;
                case CyclePhase.Peak:
                    return target == CyclePhase.Weakening;
                case CyclePhase.Weakening:
                    return target == CyclePhase.Resealed;
                case CyclePhase.Resealed:
                    return target == CyclePhase.Sealed;
                default:
                    return false;
            }
        }
    }
}
