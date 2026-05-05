using HarmonyLib;

namespace EraWheel.Systems.Progression;

[HarmonyPatch(typeof(Actor), "addTrait", new[] { typeof(ActorTrait), typeof(bool) })]
public static class EraProgressionTraitAddPatch
{
    [HarmonyPostfix]
    private static void AfterAddTrait(Actor __instance, ActorTrait pTrait, bool __result)
    {
        if (__result)
        {
            EraProgressionRuntimeBridge.Current?.OnTraitAdded(__instance, pTrait);
        }
    }
}

[HarmonyPatch(typeof(Actor), "removeTrait", new[] { typeof(ActorTrait) })]
public static class EraProgressionTraitRemovePatch
{
    [HarmonyPostfix]
    private static void AfterRemoveTrait(Actor __instance, ActorTrait pTrait, bool __result)
    {
        if (__result)
        {
            EraProgressionRuntimeBridge.Current?.OnTraitRemoved(__instance, pTrait);
        }
    }
}

[HarmonyPatch(typeof(Actor), nameof(Actor.birthEvent))]
public static class EraProgressionBirthEventPatch
{
    [HarmonyPostfix]
    private static void AfterBirthEvent(Actor __instance)
    {
        if (__instance != null)
        {
            EraProgressionRuntimeBridge.Current?.OnActorBorn(__instance);
        }
    }
}

[HarmonyPatch(typeof(Actor), nameof(Actor.checkTraitMutationOnBirth))]
public static class EraProgressionBirthTraitPatch
{
    [HarmonyPrefix]
    private static void Before(Actor __instance)
    {
        EraProgressionRuntimeBridge.Current?.BeginRandomTraitGrant(__instance, "birth");
    }

    [HarmonyPostfix]
    private static void After(Actor __instance)
    {
        EraProgressionRuntimeBridge.Current?.EndRandomTraitGrant(__instance, "birth");
    }
}

[HarmonyPatch(typeof(Actor), nameof(Actor.checkTraitMutationGrowUp))]
public static class EraProgressionGrowUpTraitPatch
{
    [HarmonyPrefix]
    private static void Before(Actor __instance)
    {
        EraProgressionRuntimeBridge.Current?.BeginRandomTraitGrant(__instance, "grow_up");
    }

    [HarmonyPostfix]
    private static void After(Actor __instance)
    {
        EraProgressionRuntimeBridge.Current?.EndRandomTraitGrant(__instance, "grow_up");
    }
}

[HarmonyPatch(typeof(BabyHelper), nameof(BabyHelper.traitsInherit))]
public static class EraProgressionInheritanceTraitPatch
{
    [HarmonyPrefix]
    private static void Before(Actor pActorTarget, Actor pParent1, Actor pParent2)
    {
        EraProgressionRuntimeBridge.Current?.BeginRandomTraitGrant(pActorTarget, "inheritance", pParent1, pParent2);
    }

    [HarmonyPostfix]
    private static void After(Actor pActorTarget)
    {
        EraProgressionRuntimeBridge.Current?.EndRandomTraitGrant(pActorTarget, "inheritance");
    }
}

[HarmonyPatch(typeof(SubspeciesActorBirthTraits), nameof(SubspeciesActorBirthTraits.init))]
public static class EraProgressionMutationBoxTraitPatch
{
    [HarmonyPostfix]
    private static void AfterInit(SubspeciesActorBirthTraits __instance)
    {
        EraProgressionRuntimeBridge.Current?.NormalizeMutationBoxBirthTraits(__instance);
    }
}

[HarmonyPatch(typeof(ActorEquipmentSlot), "setItem")]
public static class EraProgressionEquipmentSlotPatch
{
    [HarmonyPostfix]
    private static void AfterSetItem(ActorEquipmentSlot __instance, Item pItem, Actor pActor)
    {
        if (pItem != null)
        {
            EraProgressionRuntimeBridge.Current?.EnsureEquipmentStored(pItem, pActor, "direct_equip_on_spawn_or_refresh");
        }
    }
}

[HarmonyPatch(typeof(City), nameof(City.tryToPutItem))]
public static class EraProgressionCityStoragePatch
{
    [HarmonyPostfix]
    private static void AfterTryToPutItem(Item pItem)
    {
        if (pItem != null)
        {
            EraProgressionRuntimeBridge.Current?.MarkEquipmentPendingGrant(pItem, "city_storage_then_pickup");
        }
    }
}
