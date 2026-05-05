using HarmonyLib;
using EraWheel.Core.Logging;
using EraWheel.Systems.Stats;

namespace EraWheel.Systems.Levels;

public static class EraLevelPatchInstaller
{
    private static bool _patched;

    public static void EnsurePatched()
    {
        if (_patched)
        {
            return;
        }

        EraActorModifierInjectionPatchInstaller.EnsurePatched();
        Harmony harmony = new Harmony("EraWheel.LevelRuntime");
        harmony.CreateClassProcessor(typeof(EraWorldboxLevelPatch)).Patch();
        _patched = true;
        EraLog.Info(EraLogCategory.Events, "等级 Harmony 补丁已安装。");
    }
}
