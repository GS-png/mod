using HarmonyLib;
using EraWheel.Core.Logging;
using EraWheel.Systems.Stats;

namespace EraWheel.Systems.Progression;

public static class EraProgressionPatchInstaller
{
    private static bool _patched;

    public static void EnsurePatched()
    {
        if (_patched)
        {
            return;
        }

        EraActorModifierInjectionPatchInstaller.EnsurePatched();
        Harmony harmony = new Harmony("EraWheel.ProgressionRuntime");
        harmony.CreateClassProcessor(typeof(EraProgressionTraitAddPatch)).Patch();
        harmony.CreateClassProcessor(typeof(EraProgressionTraitRemovePatch)).Patch();
        harmony.CreateClassProcessor(typeof(EraProgressionBirthEventPatch)).Patch();
        harmony.CreateClassProcessor(typeof(EraProgressionBirthTraitPatch)).Patch();
        harmony.CreateClassProcessor(typeof(EraProgressionGrowUpTraitPatch)).Patch();
        harmony.CreateClassProcessor(typeof(EraProgressionInheritanceTraitPatch)).Patch();
        harmony.CreateClassProcessor(typeof(EraProgressionMutationBoxTraitPatch)).Patch();
        harmony.CreateClassProcessor(typeof(EraProgressionEquipmentSlotPatch)).Patch();
        harmony.CreateClassProcessor(typeof(EraProgressionCityStoragePatch)).Patch();
        _patched = true;
        EraLog.Info(EraLogCategory.Events, "成长实例 Harmony 补丁已安装。");
    }
}
