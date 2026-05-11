using HarmonyLib;
using EraWheel.Core.Logging;
using EraWheel.Systems.Stats;

namespace EraWheel.Systems.Kingdoms;

public static class EraKingdomPatchInstaller
{
    private static bool _patched;

    public static void EnsurePatched()
    {
        if (_patched)
        {
            return;
        }

        EraActorModifierInjectionPatchInstaller.EnsurePatched();
        Harmony harmony = new Harmony("EraWheel.KingdomRuntime");
        harmony.CreateClassProcessor(typeof(EraWorldboxKingdomRenownPatch)).Patch();
        harmony.CreateClassProcessor(typeof(EraWorldboxKingdomRenownPercentPatch)).Patch();
        _patched = true;
        EraLog.Info(EraLogCategory.Events, "王国声望 Harmony 补丁已安装。");
    }
}
