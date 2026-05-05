using HarmonyLib;
using EraWheel.Combat.Statuses;
using EraWheel.Combat.Traits;
using EraWheel.Combat.Triggers;
using EraWheel.Core.Logging;
using EraWheel.Systems.Stats;

namespace EraWheel.Combat;

public static class EraCombatPatchInstaller
{
    private static bool _patched;

    public static void EnsurePatched()
    {
        if (_patched)
        {
            return;
        }

        EraActorModifierInjectionPatchInstaller.EnsurePatched();
        Harmony harmony = new Harmony("EraWheel.CombatRuntime");
        harmony.CreateClassProcessor(typeof(EraTriggerActivePatch)).Patch();
        harmony.CreateClassProcessor(typeof(EraTriggerHitPatch)).Patch();
        harmony.CreateClassProcessor(typeof(EraTriggerGetHitPatch)).Patch();
        harmony.CreateClassProcessor(typeof(EraTriggerDeathPatch)).Patch();
        harmony.CreateClassProcessor(typeof(EraTriggerTickPatch)).Patch();
        harmony.CreateClassProcessor(typeof(EraTraitAttackPreparationPatch)).Patch();
        harmony.CreateClassProcessor(typeof(EraTraitIncomingHitPatch)).Patch();
        harmony.CreateClassProcessor(typeof(EraTraitTargetSkipPatch)).Patch();
        harmony.CreateClassProcessor(typeof(EraTraitBloodlineBirthPatch)).Patch();
        harmony.CreateClassProcessor(typeof(EraTraitCheckDeathPatch)).Patch();
        harmony.CreateClassProcessor(typeof(EraStatusShieldHook)).Patch();
        harmony.CreateClassProcessor(typeof(EraStatusModifierHook)).Patch();
        harmony.CreateClassProcessor(typeof(EraActorPreloadDiagnosticsPatch)).Patch();
        _patched = true;
        EraLog.Info(EraLogCategory.Combat, "战斗运行时 Harmony 补丁已安装。");
    }
}
