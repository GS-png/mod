using System.Collections.Generic;
using HarmonyLib;

namespace EraWheel.Systems.Advancement;

[HarmonyPatch(typeof(ItemCrafting), nameof(ItemCrafting.getItemAssetToCraft))]
public static class EraWorldboxAdvancementCraftCandidatePatch
{
    [HarmonyPostfix]
    public static void Postfix(
        Actor pActor,
        List<EquipmentAsset> pItemList,
        City pCity,
        int pCurrentItemValue,
        bool pShuffle,
        ref EquipmentAsset? __result
    )
    {
        EraAdvancementRuntimeService? runtime = EraAdvancementRuntimeBridge.Current;
        if (runtime == null)
        {
            return;
        }

        __result = runtime.ResolveCraftCandidate(
            pActor,
            pItemList,
            pCity,
            pCurrentItemValue,
            pShuffle,
            __result
        );
    }
}

[HarmonyPatch(typeof(BaseUnlockableAsset), nameof(BaseUnlockableAsset.isAvailable))]
public static class EraWorldboxHeritageAvailabilityPatch
{
    [HarmonyPostfix]
    public static void Postfix(BaseUnlockableAsset __instance, ref bool __result)
    {
        if (__result)
        {
            return;
        }

        EraAdvancementRuntimeService? runtime = EraAdvancementRuntimeBridge.Current;
        if (runtime == null || __instance == null || string.IsNullOrWhiteSpace(__instance.id))
        {
            return;
        }

        if (runtime.TryGetEditorManualAvailability(__instance.id, out bool available))
        {
            __result = available;
        }
    }
}
