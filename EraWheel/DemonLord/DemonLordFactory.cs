using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.DemonLord
{
    public static class DemonLordFactory
    {
        public static DemonLordBase[] CreateAll()
        {
            return new DemonLordBase[]
            {
                new Lords.VoidLord(),
                new Lords.PlagueLord(),
                new Lords.MachineLord(),
                new Lords.TimeLord(),
                new Lords.FlameLord(),
                new Lords.AbyssLord(),
                new Lords.DeathLord(),
                new Lords.SoulLord(),
                new Lords.NatureLord(),
                new Lords.JudgmentLord()
            };
        }

        public static DemonLordBase[] CreateEnabled(EnabledLordsConfig cfg)
        {
            var all = CreateAll();
            if (cfg == null) return all;

            var enabled = new System.Collections.Generic.List<DemonLordBase>();

            foreach (var lord in all)
            {
                if (DemonLordConfigHelper.IsEnabled(cfg, lord.Id))
                {
                    enabled.Add(lord);
                }
                else
                {
                    lord.SetEnabled(false);
                }
            }

            Log.Info($"[DemonLordFactory] 启用魔王数: {enabled.Count}/{all.Length}");
            return enabled.ToArray();
        }

        public static DemonLordBase CreateById(string lordId)
        {
            switch (lordId)
            {
                case "void_lord": return new Lords.VoidLord();
                case "plague_lord": return new Lords.PlagueLord();
                case "machine_lord": return new Lords.MachineLord();
                case "time_lord": return new Lords.TimeLord();
                case "flame_lord": return new Lords.FlameLord();
                case "abyss_lord": return new Lords.AbyssLord();
                case "death_lord": return new Lords.DeathLord();
                case "soul_lord": return new Lords.SoulLord();
                case "nature_lord": return new Lords.NatureLord();
                case "judgment_lord": return new Lords.JudgmentLord();
                default:
                    Log.Warning($"[DemonLordFactory] 未知魔王ID: {lordId}");
                    return null;
            }
        }
    }
}
