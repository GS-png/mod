using EraWheel.Config;

namespace EraWheel.DemonLord
{
    public static class DemonLordConfigHelper
    {
        public static bool IsEnabled(EnabledLordsConfig cfg, string id)
        {
            if (cfg == null || string.IsNullOrEmpty(id)) return true;

            switch (id)
            {
                case "void_lord": return cfg.void_lord;
                case "plague_lord": return cfg.plague_lord;
                case "machine_lord": return cfg.machine_lord;
                case "time_lord": return cfg.time_lord;
                case "flame_lord": return cfg.flame_lord;
                case "abyss_lord": return cfg.abyss_lord;
                case "death_lord": return cfg.death_lord;
                case "soul_lord": return cfg.soul_lord;
                case "nature_lord": return cfg.nature_lord;
                case "judgment_lord": return cfg.judgment_lord;
                default: return true;
            }
        }
    }
}
