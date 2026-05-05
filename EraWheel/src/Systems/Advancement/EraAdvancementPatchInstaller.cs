using HarmonyLib;
using EraWheel.Core.Logging;

namespace EraWheel.Systems.Advancement;

public static class EraAdvancementPatchInstaller
{
    private static bool _patched;

    public static void EnsurePatched()
    {
        if (_patched)
        {
            return;
        }

        Harmony harmony = new Harmony("EraWheel.AdvancementRuntime");
        harmony.CreateClassProcessor(typeof(EraWorldboxAdvancementCraftCandidatePatch)).Patch();
        harmony.CreateClassProcessor(typeof(EraWorldboxHeritageAvailabilityPatch)).Patch();
        _patched = true;
        EraLog.Info(EraLogCategory.Events, "轮回进阶 Harmony 补丁已安装。");
    }
}
