namespace EraOfWheel.DemonLords
{
    public enum DemonState
    {
        Sealed,
        Omen,
        Awakening,
        Invasion,
        Peak,
        Weakening,
        Resealed
    }

    public static class DemonStateExtensions
    {
        public static string ToDisplayName(this DemonState state)
        {
            switch (state)
            {
                case DemonState.Sealed: return "封印中";
                case DemonState.Omen: return "预兆显现";
                case DemonState.Awakening: return "苏醒准备";
                case DemonState.Invasion: return "正式降临";
                case DemonState.Peak: return "全盛期";
                case DemonState.Weakening: return "衰弱期";
                case DemonState.Resealed: return "已封印";
                default: return state.ToString();
            }
        }

        public static bool IsActive(this DemonState state)
        {
            return state == DemonState.Awakening ||
                   state == DemonState.Invasion ||
                   state == DemonState.Peak ||
                   state == DemonState.Weakening;
        }

        public static bool CanTransitionTo(this DemonState current, DemonState target)
        {
            switch (current)
            {
                case DemonState.Sealed:
                    return target == DemonState.Omen;
                case DemonState.Omen:
                    return target == DemonState.Awakening;
                case DemonState.Awakening:
                    return target == DemonState.Invasion;
                case DemonState.Invasion:
                    return target == DemonState.Peak || target == DemonState.Weakening;
                case DemonState.Peak:
                    return target == DemonState.Weakening;
                case DemonState.Weakening:
                    return target == DemonState.Resealed;
                case DemonState.Resealed:
                    return target == DemonState.Sealed;
                default:
                    return false;
            }
        }
    }
}
