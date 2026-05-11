using HarmonyLib;
using EraWheel.Reflection;

namespace EraWheel.Combat.Triggers;

[HarmonyPatch(typeof(CombatActionLibrary), nameof(CombatActionLibrary.tryToCastSpell))]
public static class EraTriggerActivePatch
{
    [HarmonyPostfix]
    private static void AfterTryToCastSpell(AttackData pData, bool __result)
    {
        if (!__result)
        {
            return;
        }

        float worldTime = EraTriggerPatchShared.ReadWorldTime();
        EraCombatRuntimeBridge.Current?.Triggers.Dispatch(
            new EraTriggerContext(
                EraTriggerType.Active,
                pData.initiator,
                pData.target,
                pData,
                pData.damage,
                pData.attack_type,
                worldTime,
                nameof(CombatActionLibrary.tryToCastSpell)
            )
        );
    }
}

[HarmonyPatch(typeof(MapBox), "applyAttack")]
public static class EraTriggerHitPatch
{
    [HarmonyPostfix]
    private static void AfterApplyAttack(AttackData pData, BaseSimObject pTargetToCheck, AttackDataResult __result)
    {
        if (__result.state != ApplyAttackState.Hit)
        {
            return;
        }

        float worldTime = EraTriggerPatchShared.ReadWorldTime();
        EraCombatRuntimeBridge.Current?.Triggers.Dispatch(
            new EraTriggerContext(
                EraTriggerType.OnHit,
                pData.initiator,
                pTargetToCheck,
                pData,
                pData.damage,
                pData.attack_type,
                worldTime,
                "MapBox.applyAttack"
            )
        );
    }
}

[HarmonyPatch(typeof(Actor), "getHit")]
public static class EraTriggerGetHitPatch
{
    [HarmonyPostfix]
    private static void AfterGetHit(Actor __instance, float pDamage, AttackType pAttackType, BaseSimObject pAttacker)
    {
        float worldTime = EraTriggerPatchShared.ReadWorldTime();
        EraCombatRuntimeBridge.Current?.Triggers.Dispatch(
            new EraTriggerContext(
                EraTriggerType.OnGetHit,
                pAttacker,
                __instance,
                attackData: null,
                damage: pDamage,
                attackType: pAttackType,
                worldTime: worldTime,
                sourceId: "Actor.getHit"
            )
        );
    }
}

[HarmonyPatch(typeof(Actor), "checkCallbacksOnDeath")]
public static class EraTriggerDeathPatch
{
    [HarmonyPostfix]
    private static void AfterCheckCallbacksOnDeath(Actor __instance)
    {
        if (__instance.isAlive())
        {
            return;
        }

        float worldTime = EraTriggerPatchShared.ReadWorldTime();
        EraCombatRuntimeBridge.Current?.Triggers.Dispatch(
            new EraTriggerContext(
                EraTriggerType.OnDeath,
                source: null,
                __instance,
                attackData: null,
                damage: 0f,
                attackType: AttackType.Other,
                worldTime: worldTime,
                sourceId: "Actor.checkCallbacksOnDeath"
            )
        );
    }
}

[HarmonyPatch(typeof(Actor), "checkActionsFromAllMetas")]
public static class EraTriggerTickPatch
{
    [HarmonyPostfix]
    private static void AfterCheckActionsFromAllMetas(Actor __instance)
    {
        if (!__instance.isAlive())
        {
            return;
        }

        float worldTime = EraTriggerPatchShared.ReadWorldTime();
        EraCombatRuntimeBridge.Current?.Triggers.Dispatch(
            new EraTriggerContext(
                EraTriggerType.OnTick,
                __instance,
                __instance,
                attackData: null,
                damage: 0f,
                attackType: AttackType.Other,
                worldTime: worldTime,
                sourceId: "Actor.checkActionsFromAllMetas"
            )
        );
    }
}

internal static class EraTriggerPatchShared
{
    public static float ReadWorldTime()
    {
        return WorldboxReflectionAdapter.TryReadMapStats(out MapStats? mapStats) && mapStats != null
            ? (float)mapStats.world_time
            : 0f;
    }
}
