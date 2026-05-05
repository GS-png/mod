using HarmonyLib;

namespace EraWheel.Combat.Statuses;

[HarmonyPatch(typeof(Actor), "getHit")]
public static class EraStatusShieldHook
{
    [HarmonyPrefix]
    private static bool BeforeGetHit(Actor __instance, ref float pDamage)
    {
        EraStatusRuntimeService? statuses = EraCombatRuntimeBridge.Current?.Statuses;
        if (statuses == null)
        {
            return true;
        }

        bool fullyBlocked = statuses.TryConsumeShield(__instance, ref pDamage);
        return !fullyBlocked;
    }
}

[HarmonyPatch(typeof(BaseSimObject), "updateStats")]
public static class EraStatusModifierHook
{
    [HarmonyPostfix]
    private static void AfterUpdateStats(BaseSimObject __instance)
    {
        if (__instance is Actor)
        {
            return;
        }

        EraCombatRuntimeBridge.Current?.Statuses.ApplyActiveModifiers(__instance);
    }
}
