using HarmonyLib;

namespace EraWheel.Systems.Levels;

[HarmonyPatch(typeof(Actor), "addExperience")]
public static class EraWorldboxLevelPatch
{
    [HarmonyPrefix]
    private static void BeforeAddExperience(Actor __instance, out int __state)
    {
        __state = __instance?.level ?? 0;
    }

    [HarmonyPostfix]
    private static void AfterAddExperience(Actor __instance, int __state)
    {
        if (__instance != null)
        {
            EraLevelRuntimeBridge.Current?.OnActorExperienceChanged(__instance, __state, __instance.level);
        }
    }
}
