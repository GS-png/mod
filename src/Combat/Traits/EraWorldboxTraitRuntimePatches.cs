using HarmonyLib;

namespace EraWheel.Combat.Traits;

[HarmonyPatch(typeof(Actor), "tryToAttack")]
public static class EraTraitAttackPreparationPatch
{
    private struct AttackPreparationState
    {
        public bool Modified;
        public float OriginalDamage;
    }

    [HarmonyPrefix]
    private static void BeforeTryToAttack(Actor __instance, BaseSimObject pTarget, out AttackPreparationState __state)
    {
        EraTraitRuntimeService? traits = EraCombatRuntimeBridge.Current?.Traits;
        float originalDamage = 0f;
        bool modified = traits != null && traits.TryPrepareAttack(__instance, pTarget, out originalDamage);
        __state = new AttackPreparationState
        {
            Modified = modified,
            OriginalDamage = modified ? originalDamage : 0f,
        };
    }

    [HarmonyPostfix]
    private static void AfterTryToAttack(Actor __instance, AttackPreparationState __state)
    {
        EraCombatRuntimeBridge.Current?.Traits?.RestorePreparedAttack(__instance, __state.Modified, __state.OriginalDamage);
    }
}

[HarmonyPatch(typeof(Actor), "getHit")]
public static class EraTraitIncomingHitPatch
{
    [HarmonyPriority(Priority.First)]
    [HarmonyPrefix]
    private static bool BeforeGetHit(Actor __instance, ref float pDamage, AttackType pAttackType, BaseSimObject pAttacker)
    {
        EraTraitRuntimeService? traits = EraCombatRuntimeBridge.Current?.Traits;
        if (traits == null)
        {
            return true;
        }

        return !traits.TryHandleIncomingHit(__instance, ref pDamage, pAttackType, pAttacker);
    }
}

[HarmonyPatch(typeof(Actor), "setAttackTarget")]
public static class EraTraitTargetSkipPatch
{
    [HarmonyPrefix]
    private static bool BeforeSetAttackTarget(Actor __instance, BaseSimObject pAttackTarget)
    {
        EraTraitRuntimeService? traits = EraCombatRuntimeBridge.Current?.Traits;
        if (traits == null)
        {
            return true;
        }

        return !traits.ShouldSkipTarget(__instance, pAttackTarget);
    }
}

[HarmonyPatch(typeof(BabyMaker), "makeBaby")]
public static class EraTraitBloodlineBirthPatch
{
    [HarmonyPostfix]
    private static void AfterMakeBaby(Actor pParent1, Actor pParent2, ref Actor __result)
    {
        if (__result == null || pParent1 == null)
        {
            return;
        }

        EraCombatRuntimeBridge.Current?.Traits?.HandleBabyBorn(__result, pParent1, pParent2);
    }
}

[HarmonyPatch(typeof(Actor), "checkDeath")]
public static class EraTraitCheckDeathPatch
{
    [HarmonyPrefix]
    private static bool BeforeCheckDeath(Actor __instance)
    {
        EraTraitRuntimeService? traits = EraCombatRuntimeBridge.Current?.Traits;
        if (traits == null)
        {
            return true;
        }

        return !traits.TryHandleDeath(__instance);
    }
}
