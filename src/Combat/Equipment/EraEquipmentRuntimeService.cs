using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HarmonyLib;
using EraWheel.Combat.Effects;
using EraWheel.Combat.Statuses;
using EraWheel.Combat.Terrain;
using EraWheel.Combat.Triggers;
using EraWheel.Core.Constants;
using EraWheel.Core.Random;
using EraWheel.Core.Time;
using EraWheel.Reflection;

namespace EraWheel.Combat.Equipment;

public sealed partial class EraEquipmentRuntimeService
{
    private const float DefaultProcChance = 15f;
    private const int DefaultManaCost = 10;
    private static readonly float DefaultActiveCooldown = EraWorldTime.YearsToWorldTime(1f);

    private const string ShadowstepChargeKey = "ew_equip_shadowstep_charge";
    private const string RefluxChargeKey = "ew_equip_reflux_charge";
    private const string StormwireVulnerabilityKeyPrefix = "ew_equip_stormwire_vulnerable:";
    private const string AbyssCrackKeyPrefix = "ew_equip_abyss_crack:";
    private const string BlackSunSlowKeyPrefix = "ew_equip_black_sun_slow:";
    private const string VerdictMarkKeyPrefix = "ew_equip_verdict_mark:";
    private const string QuakeAxeStunKeyPrefix = "ew_equip_quake_axe_stun:";
    private const string SilenceSealAccuracyKeyPrefix = "ew_equip_silence_accuracy:";
    private const string CrownMobilizationKeyPrefix = "ew_equip_crown_mobilization:";

    private static readonly MethodInfo? AddExperienceMethod = AccessTools.Method(
        typeof(Actor),
        "addExperience",
        new[] { typeof(int) }
    );

    private readonly EraStableRandomService _stableRandom;
    private readonly EraTriggerService _triggers;
    private readonly EraEffectService _effects;
    private readonly EraStatusRuntimeService _statuses;
    private readonly EraTerrainAreaService _terrain;
    private readonly Dictionary<string, float> _cooldowns = new();
    private readonly Dictionary<long, float> _incomingDamageAmpPercent = new();
    private readonly Dictionary<long, float> _incomingDamageAmpExpiresAt = new();
    private readonly HashSet<long> _incomingDamageAmpBypass = new();

    public EraEquipmentRuntimeService(
        EraStableRandomService stableRandom,
        EraTriggerService triggers,
        EraEffectService effects,
        EraStatusRuntimeService statuses,
        EraTerrainAreaService terrain
    )
    {
        _stableRandom = stableRandom;
        _triggers = triggers;
        _effects = effects;
        _statuses = statuses;
        _terrain = terrain;

        RegisterTier1To3EquipmentTriggers();
        RegisterTier4To6EquipmentTriggers();
        RegisterTier7To8EquipmentTriggers();
        RegisterTier9To10EquipmentTriggers();
        RegisterIncomingDamageAmpRuntime();
    }

    public void Update(float currentWorldTime)
    {
        CleanupExpiredCooldowns(currentWorldTime);
        CleanupExpiredIncomingDamageAmp(currentWorldTime);
    }

    public string CreateStatusReport()
    {
        return $"装备技能冷却={_cooldowns.Count}";
    }

    partial void RegisterTier1To3EquipmentTriggers();

    partial void RegisterTier4To6EquipmentTriggers();

    partial void RegisterTier7To8EquipmentTriggers();

    partial void RegisterTier9To10EquipmentTriggers();

    private void RegisterOnHitEquipmentSkill(
        string equipmentId,
        Action<EraTriggerContext, Actor> handler,
        float chancePercent = DefaultProcChance,
        float cooldownWorldTime = 0f,
        int manaCost = DefaultManaCost,
        Func<EraTriggerContext, Actor, bool>? condition = null
    )
    {
        RegisterEquipmentTriggerInternal(
            equipmentId,
            $"{equipmentId}#on_hit",
            EraTriggerType.OnHit,
            EraTriggerSubject.Source,
            handler,
            chancePercent,
            cooldownWorldTime,
            manaCost,
            condition
        );
    }

    private void RegisterOnGetHitEquipmentSkill(
        string equipmentId,
        Action<EraTriggerContext, Actor> handler,
        float chancePercent = DefaultProcChance,
        float cooldownWorldTime = 0f,
        int manaCost = DefaultManaCost,
        Func<EraTriggerContext, Actor, bool>? condition = null
    )
    {
        RegisterEquipmentTriggerInternal(
            equipmentId,
            $"{equipmentId}#on_get_hit",
            EraTriggerType.OnGetHit,
            EraTriggerSubject.Target,
            handler,
            chancePercent,
            cooldownWorldTime,
            manaCost,
            condition
        );
    }

    private void RegisterActiveEquipmentSkill(
        string equipmentId,
        Action<EraEffectContext, Actor> handler,
        float chancePercent = DefaultProcChance,
        float cooldownWorldTime = 0f,
        int manaCost = DefaultManaCost,
        float targetSearchRadius = 0f,
        Func<EraTriggerContext, Actor, bool>? condition = null
    )
    {
        _triggers.RegisterEquipmentTrigger(
            $"{equipmentId}#active",
            equipmentId,
            EraTriggerType.Active,
            EraTriggerSubject.Source,
            equipmentId,
            (context, actor) =>
            {
                if (!CanTriggerProc(actor, equipmentId, context.WorldTime, cooldownWorldTime, manaCost, targetSearchRadius))
                {
                    return;
                }

                if (manaCost > 0)
                {
                    WorldboxReflectionAdapter.TryConsumeActorMana(actor, manaCost);
                }

                handler(context.ToEffectContext(), actor);
                SetCooldown(actor, equipmentId, context.WorldTime, cooldownWorldTime);
            },
            chancePercent,
            context =>
            {
                Actor? actor = context.SourceActor;
                return actor != null
                       && CanTriggerProc(actor, equipmentId, context.WorldTime, cooldownWorldTime, manaCost, targetSearchRadius)
                       && (condition == null || condition(context, actor));
            }
        );
    }

    private void RegisterEquipmentTriggerInternal(
        string equipmentId,
        string triggerId,
        EraTriggerType triggerType,
        EraTriggerSubject subject,
        Action<EraTriggerContext, Actor> handler,
        float chancePercent,
        float cooldownWorldTime,
        int manaCost,
        Func<EraTriggerContext, Actor, bool>? condition
    )
    {
        _triggers.RegisterEquipmentTrigger(
            triggerId,
            equipmentId,
            triggerType,
            subject,
            equipmentId,
            (context, actor) =>
            {
                if (!CanTriggerProc(actor, equipmentId, context.WorldTime, cooldownWorldTime, manaCost))
                {
                    return;
                }

                if (manaCost > 0)
                {
                    WorldboxReflectionAdapter.TryConsumeActorMana(actor, manaCost);
                }

                handler(context, actor);
                SetCooldown(actor, equipmentId, context.WorldTime, cooldownWorldTime);
            },
            chancePercent,
            context =>
            {
                Actor? actor = subject == EraTriggerSubject.Target ? context.TargetActor : context.SourceActor;
                return actor != null
                       && CanTriggerProc(actor, equipmentId, context.WorldTime, cooldownWorldTime, manaCost)
                       && (condition == null || condition(context, actor));
            }
        );
    }

    private bool CanTriggerProc(
        Actor actor,
        string equipmentId,
        float worldTime,
        float cooldownWorldTime,
        int manaCost,
        float targetSearchRadius = 0f
    )
    {
        if (actor.current_tile == null || !actor.isAlive())
        {
            return false;
        }

        if (cooldownWorldTime > 0f &&
            _cooldowns.TryGetValue(BuildCooldownKey(actor, equipmentId), out float nextAllowedWorldTime) &&
            nextAllowedWorldTime > worldTime)
        {
            return false;
        }

        if (targetSearchRadius > 0f && ResolveEnemyTarget(actor, targetSearchRadius) == null)
        {
            return false;
        }

        return manaCost <= 0
               || !WorldboxReflectionAdapter.CanAccessActorMana
               || (WorldboxReflectionAdapter.TryGetActorMana(actor, out int mana) && mana >= manaCost);
    }

    private void SetCooldown(Actor actor, string equipmentId, float worldTime, float cooldownWorldTime)
    {
        if (cooldownWorldTime <= 0f)
        {
            return;
        }

        _cooldowns[BuildCooldownKey(actor, equipmentId)] = worldTime + cooldownWorldTime;
    }

    private static string BuildCooldownKey(Actor actor, string equipmentId)
    {
        return $"{actor.getID()}:{equipmentId}";
    }

    private void CleanupExpiredCooldowns(float currentWorldTime)
    {
        if (_cooldowns.Count == 0)
        {
            return;
        }

        List<string> expired = new List<string>();
        foreach ((string key, float expiresAt) in _cooldowns)
        {
            if (expiresAt <= currentWorldTime)
            {
                expired.Add(key);
            }
        }

        foreach (string key in expired)
        {
            _cooldowns.Remove(key);
        }
    }

    private void CleanupExpiredIncomingDamageAmp(float currentWorldTime)
    {
        if (_incomingDamageAmpExpiresAt.Count == 0)
        {
            return;
        }

        List<long> expired = new List<long>();
        foreach ((long actorId, float expiresAt) in _incomingDamageAmpExpiresAt)
        {
            if (expiresAt <= currentWorldTime)
            {
                expired.Add(actorId);
            }
        }

        foreach (long actorId in expired)
        {
            _incomingDamageAmpExpiresAt.Remove(actorId);
            _incomingDamageAmpPercent.Remove(actorId);
        }
    }

    private Actor? ResolveEnemyTarget(Actor actor, float maxDistance)
    {
        if (WorldboxReflectionAdapter.TryGetAttackTarget(actor, out BaseSimObject? target) &&
            target is Actor targetActor &&
            targetActor.isAlive() &&
            targetActor.current_tile != null &&
            actor.areFoes(targetActor))
        {
            return targetActor;
        }

        if (actor.current_tile == null)
        {
            return null;
        }

        float maxDistanceSquared = maxDistance * maxDistance;
        Actor? best = null;
        float bestDistance = float.MaxValue;
        foreach (Actor other in EnumerateActors())
        {
            if (other == null || !other.isAlive() || other.current_tile == null || !actor.areFoes(other))
            {
                continue;
            }

            float distanceSquared = DistanceSquared(actor.current_tile, other.current_tile);
            if (distanceSquared > maxDistanceSquared || distanceSquared >= bestDistance)
            {
                continue;
            }

            bestDistance = distanceSquared;
            best = other;
        }

        return best;
    }

    private static IEnumerable<Actor> EnumerateActors()
    {
        if (World.world?.units == null)
        {
            return Array.Empty<Actor>();
        }

        List<Actor> result = new List<Actor>();
        foreach (Actor actor in World.world.units)
        {
            if (actor != null)
            {
                result.Add(actor);
            }
        }

        return result;
    }

    private float RollBetween(BaseSimObject source, BaseSimObject? target, string scopeSuffix, float min, float max)
    {
        long sourceId = source.getID();
        long targetId = target?.getID() ?? 0L;
        string scope = $"{scopeSuffix}:{sourceId}:{targetId}:{(int)ReadWorldTime()}";
        return _stableRandom.NextFloat("equipment_runtime_roll", scope, min, max);
    }

    private int RollInt(BaseSimObject source, BaseSimObject? target, string scopeSuffix, int minInclusive, int maxExclusive)
    {
        long sourceId = source.getID();
        long targetId = target?.getID() ?? 0L;
        string scope = $"{scopeSuffix}:{sourceId}:{targetId}:{(int)ReadWorldTime()}";
        return _stableRandom.NextInt("equipment_runtime_int", scope, minInclusive, maxExclusive);
    }

    private static float DistanceSquared(WorldTile? left, WorldTile? right)
    {
        if (left == null || right == null)
        {
            return float.MaxValue;
        }

        float dx = left.x - right.x;
        float dy = left.y - right.y;
        return (dx * dx) + (dy * dy);
    }

    private static float ReadWorldTime()
    {
        return WorldboxReflectionAdapter.TryReadMapStats(out MapStats? mapStats) && mapStats != null
            ? (float)mapStats.world_time
            : 0f;
    }

    private static void AddExperience(Actor actor, int amount)
    {
        if (amount <= 0 || AddExperienceMethod == null)
        {
            return;
        }

        AddExperienceMethod.Invoke(actor, new object[] { amount });
    }

    private static void RestoreManaPercent(Actor actor, float percent)
    {
        if (percent <= 0f || !WorldboxReflectionAdapter.TryGetActorMana(actor, out int mana))
        {
            return;
        }

        int maxMana = Math.Max(0, actor.getMaxMana());
        int amount = Math.Max(1, (int)MathF.Round(maxMana * percent));
        WorldboxReflectionAdapter.TrySetActorMana(actor, Math.Min(maxMana, mana + amount));
    }

    private void ApplyTimedBuff(
        BaseSimObject target,
        string runtimeKey,
        float durationWorldTime,
        IReadOnlyDictionary<string, float> modifiers
    )
    {
        _statuses.ApplyNow(
            target,
            new EraStatusApplication(
                EraStatusKind.TimedBuff,
                durationWorldTime,
                EraStatusStackMode.Replace,
                runtimeKey: runtimeKey,
                statModifiers: modifiers
            )
        );
    }

    private void ApplyTimedDebuff(
        BaseSimObject target,
        string runtimeKey,
        float durationWorldTime,
        IReadOnlyDictionary<string, float> modifiers
    )
    {
        _statuses.ApplyNow(
            target,
            new EraStatusApplication(
                EraStatusKind.TimedDebuff,
                durationWorldTime,
                EraStatusStackMode.Replace,
                runtimeKey: runtimeKey,
                statModifiers: modifiers
            )
        );
    }

    private static WorldTile? FindClosestTileTowards(WorldTile origin, WorldTile destination, int maxSteps)
    {
        if (origin == null || destination == null)
        {
            return null;
        }

        float dx = destination.x - origin.x;
        float dy = destination.y - origin.y;
        float length = MathF.Sqrt((dx * dx) + (dy * dy));
        if (length <= 0.001f)
        {
            return origin;
        }

        float normalizedX = dx / length;
        float normalizedY = dy / length;
        int steps = Math.Max(1, maxSteps);
        int targetX = origin.x + (int)MathF.Round(normalizedX * steps);
        int targetY = origin.y + (int)MathF.Round(normalizedY * steps);
        return World.world?.GetTile(targetX, targetY);
    }

    private static List<WorldTile> BuildLineTiles(WorldTile start, WorldTile end, int segments)
    {
        List<WorldTile> result = new List<WorldTile>();
        if (World.world == null || start == null || end == null)
        {
            return result;
        }

        int steps = Math.Max(1, segments);
        for (int index = 0; index <= steps; index++)
        {
            float t = index / (float)steps;
            int tileX = (int)MathF.Round(start.x + ((end.x - start.x) * t));
            int tileY = (int)MathF.Round(start.y + ((end.y - start.y) * t));
            WorldTile? tile = World.world.GetTile(tileX, tileY);
            if (tile != null && !result.Contains(tile))
            {
                result.Add(tile);
            }
        }

        return result;
    }

    private static void StartFireOnTiles(IEnumerable<WorldTile> tiles)
    {
        foreach (WorldTile tile in tiles)
        {
            WorldboxReflectionAdapter.TryStartTileFire(tile, true);
        }
    }

    private float ConsumeNextActiveSkillBonus(Actor actor)
    {
        string runtimeKey = $"{RefluxChargeKey}:{actor.getID()}";
        if (!_statuses.TryGetStatus(actor, runtimeKey, out EraActiveStatus? active) || active == null)
        {
            return 1f;
        }

        _statuses.Remove(actor, runtimeKey);
        if (!active.StatModifiers.TryGetValue(EraAttributeIds.MultiplierDamage, out float bonusPercent))
        {
            return 1f;
        }

        return 1f + Math.Max(0f, bonusPercent / 100f);
    }

    private bool TryConsumeShadowstepCharge(Actor actor, out float extraDamageMultiplier)
    {
        extraDamageMultiplier = 0f;
        string runtimeKey = $"{ShadowstepChargeKey}:{actor.getID()}";
        if (!_statuses.TryGetStatus(actor, runtimeKey, out EraActiveStatus? active) || active == null)
        {
            return false;
        }

        _statuses.Remove(actor, runtimeKey);
        extraDamageMultiplier = active.StatModifiers.TryGetValue(EraAttributeIds.MultiplierCrit, out float critMultiplier)
            ? Math.Max(1f, critMultiplier / 100f)
            : 1f;
        return true;
    }

    private void RegisterIncomingDamageAmpRuntime()
    {
        _triggers.Register(
            new EraTriggerDefinition(
                "heritage_equipment#incoming_damage_amp",
                "heritage_equipment_runtime",
                EraTriggerType.OnGetHit,
                context =>
                {
                    Actor? victim = context.TargetActor;
                    if (victim == null || context.Damage <= 0f || _incomingDamageAmpBypass.Contains(victim.getID()))
                    {
                        return;
                    }

                    if (!TryGetIncomingDamageAmp(victim, context.WorldTime, out float bonusPercent))
                    {
                        return;
                    }

                    int extraDamage = Math.Max(1, (int)MathF.Round(context.Damage * (bonusPercent / 100f)));
                    if (extraDamage <= 0)
                    {
                        return;
                    }

                    long actorId = victim.getID();
                    _incomingDamageAmpBypass.Add(actorId);
                    try
                    {
                        _effects.ApplyDamage(context.ToEffectContext(), victim, flatDamage: extraDamage);
                    }
                    finally
                    {
                        _incomingDamageAmpBypass.Remove(actorId);
                    }
                }
            )
        );
    }

    private void ApplyIncomingDamageAmp(Actor actor, float bonusPercent, float expiresAt)
    {
        long actorId = actor.getID();
        if (_incomingDamageAmpPercent.TryGetValue(actorId, out float currentBonus))
        {
            _incomingDamageAmpPercent[actorId] = Math.Max(currentBonus, bonusPercent);
            _incomingDamageAmpExpiresAt[actorId] = Math.Max(_incomingDamageAmpExpiresAt[actorId], expiresAt);
            return;
        }

        _incomingDamageAmpPercent[actorId] = bonusPercent;
        _incomingDamageAmpExpiresAt[actorId] = expiresAt;
    }

    private bool TryGetIncomingDamageAmp(Actor actor, float worldTime, out float bonusPercent)
    {
        bonusPercent = 0f;
        long actorId = actor.getID();
        if (!_incomingDamageAmpExpiresAt.TryGetValue(actorId, out float expiresAt) || expiresAt <= worldTime)
        {
            _incomingDamageAmpExpiresAt.Remove(actorId);
            _incomingDamageAmpPercent.Remove(actorId);
            return false;
        }

        return _incomingDamageAmpPercent.TryGetValue(actorId, out bonusPercent) && bonusPercent > 0f;
    }

    private static bool IsLowHealth(Actor actor, float thresholdPercent)
    {
        if (actor == null || actor.getMaxHealth() <= 0)
        {
            return false;
        }

        return actor.getHealth() <= actor.getMaxHealthPercent(thresholdPercent);
    }
}

internal static class EraEquipmentTriggerContextExtensions
{
    public static EraEffectContext ToEffectContext(this EraTriggerContext context)
    {
        return EraEffectContext.FromTrigger(context);
    }
}
