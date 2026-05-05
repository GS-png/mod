using EraWheel.Core;
using EraWheel.Data.Definitions;

namespace EraWheel.HotReload;

public static class EraWorldEntityRebindService
{
    public static EraWorldRebindReport RebindCurrentWorld(
        EraContentCatalog currentCatalog,
        EraContentCatalog previousCatalog)
    {
        EraWorldRebindReport report = new EraWorldRebindReport();

        if (EraRuntimeBootstrap.RuntimeSave == null)
        {
            report.Skipped++;
            report.Warnings.Add("世界重绑跳过：运行态存档尚未初始化。");
            return report;
        }

        EraRuntimeBootstrap.RefreshWorldBinding();
        if (!EraRuntimeBootstrap.RuntimeSave.IsBoundToWorld)
        {
            report.Skipped++;
            report.Warnings.Add("世界重绑跳过：当前没有可绑定的世界。");
            return report;
        }

        _ = currentCatalog;
        _ = previousCatalog;
        return report;
    }
}
