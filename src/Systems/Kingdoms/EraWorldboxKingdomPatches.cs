using HarmonyLib;

namespace EraWheel.Systems.Kingdoms;

[HarmonyPatch(typeof(MetaObject<KingdomData>), nameof(MetaObject<KingdomData>.addRenown), new[] { typeof(int) })]
public static class EraWorldboxKingdomRenownPatch
{
    [HarmonyPrefix]
    private static void BeforeAddRenown(MetaObject<KingdomData> __instance, out int __state)
    {
        __state = __instance is Kingdom kingdom ? kingdom.getRenown() : 0;
    }

    [HarmonyPostfix]
    private static void AfterAddRenown(MetaObject<KingdomData> __instance, int __state)
    {
        if (__instance is Kingdom kingdom)
        {
            EraKingdomRuntimeBridge.Current?.OnKingdomRenownChanged(kingdom, __state, kingdom.getRenown());
        }
    }
}

[HarmonyPatch(typeof(MetaObject<KingdomData>), nameof(MetaObject<KingdomData>.addRenown), new[] { typeof(int), typeof(float) })]
public static class EraWorldboxKingdomRenownPercentPatch
{
    [HarmonyPrefix]
    private static void BeforeAddRenown(MetaObject<KingdomData> __instance, out int __state)
    {
        __state = __instance is Kingdom kingdom ? kingdom.getRenown() : 0;
    }

    [HarmonyPostfix]
    private static void AfterAddRenown(MetaObject<KingdomData> __instance, int __state)
    {
        if (__instance is Kingdom kingdom)
        {
            EraKingdomRuntimeBridge.Current?.OnKingdomRenownChanged(kingdom, __state, kingdom.getRenown());
        }
    }
}
