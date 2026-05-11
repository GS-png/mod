using System;
using System.Collections.Generic;
using EraWheel.Combat.Effects;
using EraWheel.Combat.Statuses;
using EraWheel.Combat.Terrain;
using EraWheel.Combat.Triggers;
using EraWheel.Core;
using EraWheel.Core.Constants;
using EraWheel.Core.Random;
using EraWheel.Core.Time;
using EraWheel.Reflection;
using NeoModLoader.General;

namespace EraWheel.Combat.Demons;

public sealed partial class EraDemonSkillRuntimeService
{
    private const string AbyssGodId = "demon_abyss_god";
    private const string AbyssAuraRuntimeKey = "ew_abyss_p0_aura";
    private const string AbyssMadnessRuntimeKey = "ew_abyss_p0_madness";
    private const string AbyssCorruptionPoolKeyPrefix = "ew_abyss_s2_pool:";
    private const string AbyssSiphonKeyPrefix = "ew_abyss_s3:";
    private const string AbyssRiftVortexPrefix = "ew_abyss_s4_vortex:";
    private const string AbyssDeepMarkKey = "ew_abyss_s6_mark";
    private static readonly string[] AbyssAberrationCandidates =
    {
        "tumor",
        "biomass",
        "super_pumpkin",
    };

    private readonly Dictionary<long, AbyssAuraEntry> _abyssAuraEntries = new();
    private readonly HashSet<long> _abyssMadTargets = new();

    private sealed class AbyssAuraEntry
    {
        public float EnteredAt { get; set; }
        public float LastSeen { get; set; }
    }

    private const string DeathKingId = "demon_death_king";
    private const string DeathMarkRuntimeKey = "ew_death_mark";
    private const string DeathNightBuffKey = "ew_death_s6_buff";
    private const string DeathNightAreaKey = "ew_death_s6_area";
    private const string DeathNightDebuffKey = "ew_death_s6_debuff";
    private const string DeathCurseKey = "ew_death_s4_wither";
    private const string SkeletonAssetId = "skeleton";

    private readonly Dictionary<long, DeathKingKillRecord> _deathKingKillRecords = new();
    private readonly Dictionary<long, float> _deathNightExpiresAtByActor = new();

    private sealed class DeathKingKillRecord
    {
        public long KillerId { get; set; }
        public float Timestamp { get; set; }
    }

    private void RegisterAbyssGod()
    {
        RegisterTickSkill(
            "demon_abyss_god#p0",
            AbyssGodId,
            chancePercent: 100f,
            cooldownWorldTime: EraWorldTime.MonthToWorldTime(1f),
            manaCost: 0,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                float now = context.WorldTime;
                PruneAbyssAuraEntries(now);
                _terrain.UpsertPeriodicArea(
                    AbyssAuraRuntimeKey,
                    actor,
                    actor,
                    actor.current_tile,
                    radius: 8f,
                    durationWorldTime: EraWorldTime.MonthToWorldTime(2f),
                    tickIntervalWorldTime: EraWorldTime.MonthToWorldTime(1f),
                    targetRule: EraEffectTargetRule.Foes,
                    onActorTick: (tickContext, target) => ApplyAbyssAuraTick(tickContext, target)
                );
            }
        );

        RegisterTickSkill(
            "demon_abyss_god#s1",
            AbyssGodId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 20f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 20f);
                if (target?.current_tile == null)
                {
                    return;
                }

                WorldTile landing = ResolveNearbyTile(actor.current_tile!, 2f) ?? actor.current_tile!;
                WorldboxReflectionAdapter.TryTeleportActor(target, landing);
            }
        );

        RegisterTickSkill(
            "demon_abyss_god#s2",
            AbyssGodId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                CreateCorruptionPool(context, actor);
            }
        );

        RegisterTickSkill(
            "demon_abyss_god#s3",
            AbyssGodId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 10f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 10f);
                if (target?.current_tile == null)
                {
                    return;
                }

                StartSoulSiphon(context, actor, target);
            }
        );

        RegisterTickSkill(
            "demon_abyss_god#s4",
            AbyssGodId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                WorldTile? destination = ResolveRiftDestination(actor.current_tile!, context.WorldTime);
                if (destination == null || destination == actor.current_tile)
                {
                    return;
                }

                CreateRiftVortex(context, actor, actor.current_tile!, "start");
                CreateRiftVortex(context, actor, destination, "end");
                WorldboxReflectionAdapter.TryTeleportActor(actor, destination);
            }
        );

        RegisterTickSkill(
            "demon_abyss_god#s5",
            AbyssGodId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                string summonId = PickAberrationAsset(actor.getID());
                _effects.SummonUnits(
                    context,
                    summonId,
                    actor.current_tile,
                    count: 1,
                    joinSourceKingdom: true
                );
            }
        );

        RegisterTickSkill(
            "demon_abyss_god#s6",
            AbyssGodId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(10f),
            manaCost: 15,
            requiresAdvent: true,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                string fieldKey = $"{AbyssDeepMarkKey}:{actor.getID()}";
                _terrain.UpsertPeriodicArea(
                    fieldKey,
                    actor,
                    actor,
                    actor.current_tile,
                    radius: 20f,
                    durationWorldTime: 10f,
                    tickIntervalWorldTime: 1f,
                    targetRule: EraEffectTargetRule.Foes,
                    onPulse: (effectContext, center) =>
                    {
                        _effects.ApplyAreaCurrentHealthDamage(
                            effectContext,
                            center,
                            radius: 20f,
                            percent: 0.01f,
                            preserveOneHitPoint: true
                        );
                    },
                    onActorTick: (effectContext, target) =>
                    {
                        _statuses.ApplyMark(target, durationWorldTime: 10f, runtimeKey: AbyssDeepMarkKey);
                    }
                );
            }
        );
    }

    private void RegisterDeathKing()
    {
        RegisterDeathKingHitTracker();
        RegisterDeathKingResurrection();

        RegisterTickSkill(
            "demon_death_king#s1",
            DeathKingId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 12f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 12f);
                if (target?.current_tile == null)
                {
                    return;
                }

                WorldTile landing = ResolveNearbyTile(actor.current_tile!, 1f) ?? actor.current_tile!;
                WorldboxReflectionAdapter.TryTeleportActor(target, landing);
                _statuses.ApplyMark(target, 10f, runtimeKey: DeathMarkRuntimeKey);
            }
        );

        RegisterTickSkill(
            "demon_death_king#s2",
            DeathKingId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                EraStatusApplication bonus = new(
                    EraStatusKind.TimedBuff,
                    durationWorldTime: 15f,
                    statModifiers: new Dictionary<string, float>
                    {
                        [EraAttributeIds.Armor] = 15f,
                        [EraAttributeIds.MultiplierDamage] = 15f,
                        [EraAttributeIds.MultiplierAttackSpeed] = 15f,
                    },
                    runtimeKey: "ew_death_s2_bless"
                );

                _effects.ApplyAreaStatus(
                    context,
                    actor.current_tile,
                    radius: 10f,
                    application: bonus,
                    targetRule: EraEffectTargetRule.Friends
                );
            }
        );

        RegisterTickSkill(
            "demon_death_king#s3",
            DeathKingId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                _effects.SummonUnits(
                    context,
                    SkeletonAssetId,
                    actor.current_tile,
                    count: 20,
                    joinSourceKingdom: true
                );
            }
        );

        RegisterTickSkill(
            "demon_death_king#s4",
            DeathKingId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                EraStatusApplication curse = new(
                    EraStatusKind.TimedDebuff,
                    durationWorldTime: 12f,
                    statModifiers: new Dictionary<string, float>
                    {
                        [EraAttributeIds.MultiplierDamage] = -10f,
                        [EraAttributeIds.Armor] = -10f,
                    },
                    runtimeKey: DeathCurseKey
                );

                _effects.ApplyAreaStatus(
                    context,
                    actor.current_tile,
                    radius: 10f,
                    application: curse,
                    targetRule: EraEffectTargetRule.Foes
                );
            }
        );

        RegisterTickSkill(
            "demon_death_king#s5",
            DeathKingId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 12f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 12f);
                if (target == null)
                {
                    return;
                }

                _effects.ApplyDamage(context, target, damageMultiplier: 1f);
                if (target.current_tile != null)
                {
                    _effects.ApplyAreaDamage(
                        context,
                        target.current_tile,
                        radius: 6f,
                        damageMultiplier: 0.9f,
                        targetRule: EraEffectTargetRule.Foes
                    );
                }
            }
        );

        RegisterTickSkill(
            "demon_death_king#s6",
            DeathKingId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(10f),
            manaCost: 15,
            requiresAdvent: true,
            handler: (context, actor) =>
            {
                float now = context.WorldTime;
                if (_deathNightExpiresAtByActor.TryGetValue(actor.getID(), out float expiresAt) && now <= expiresAt)
                {
                    return;
                }

                _deathNightExpiresAtByActor[actor.getID()] = now + 30f;

                _statuses.ApplyTimedBuff(
                    actor,
                    durationWorldTime: 30f,
                    new Dictionary<string, float>
                    {
                        [EraAttributeIds.MultiplierSpeed] = 40f,
                        [EraAttributeIds.MultiplierDamage] = 20f,
                        [EraAttributeIds.Armor] = 20f,
                    },
                    runtimeKey: DeathNightBuffKey
                );

                if (actor.current_tile == null)
                {
                    return;
                }

                _terrain.UpsertPeriodicArea(
                    DeathNightAreaKey,
                    actor,
                    actor,
                    actor.current_tile,
                    radius: 20f,
                    durationWorldTime: 30f,
                    tickIntervalWorldTime: 1f,
                    targetRule: EraEffectTargetRule.Foes,
                    onActorTick: (effectContext, target) =>
                    {
                        _statuses.ApplyTimedDebuff(
                            target,
                            durationWorldTime: 1f,
                            new Dictionary<string, float>
                            {
                                [EraAttributeIds.MultiplierDamage] = -20f,
                                [EraAttributeIds.MultiplierSpeed] = -20f,
                                [EraAttributeIds.Armor] = -20f,
                            },
                            runtimeKey: DeathNightDebuffKey
                        );
                    }
                );
            }
        );
    }

    private void RegisterDeathKingHitTracker()
    {
        _triggers.Register(
            new EraTriggerDefinition(
                "demon_death_king#p0_on_hit",
                DeathKingId,
                EraTriggerType.OnGetHit,
                context =>
                {
                    Actor? actor = context.SourceActor;
                    Actor? target = context.TargetActor;
                    if (actor?.asset?.id != DeathKingId || target == null)
                    {
                        return;
                    }

                    _deathKingKillRecords[target.getID()] = new DeathKingKillRecord
                    {
                        KillerId = actor.getID(),
                        Timestamp = context.WorldTime,
                    };

                    if (!_statuses.TryGetStatus(target, DeathMarkRuntimeKey, out _))
                    {
                        return;
                    }

                    EraEffectContext effectContext = new(
                        actor,
                        target,
                        context.WorldTime,
                        "demon_death_king#s1_mark",
                        EraTriggerType.OnGetHit
                    );

                    _effects.ApplyDamage(effectContext, target, damageMultiplier: 0.1f);
                }
            )
        );
    }

    private void RegisterDeathKingResurrection()
    {
        _triggers.Register(
            new EraTriggerDefinition(
                "demon_death_king#p0_revive",
                DeathKingId,
                EraTriggerType.OnDeath,
                context =>
                {
                    Actor? fallen = context.TargetActor;
                    if (fallen == null || fallen.current_tile == null)
                    {
                        return;
                    }

                    if (!_deathKingKillRecords.TryGetValue(fallen.getID(), out DeathKingKillRecord? record))
                    {
                        return;
                    }

                    if (context.WorldTime - record.Timestamp > 2f)
                    {
                        _deathKingKillRecords.Remove(fallen.getID());
                        return;
                    }

                    Actor? killer = ResolveActor(record.KillerId);
                    EraEffectContext effectContext = new(
                        killer ?? fallen,
                        fallen,
                        context.WorldTime,
                        "demon_death_king#p0_resurrect",
                        EraTriggerType.OnDeath
                    );

                    _effects.SummonUnits(effectContext, SkeletonAssetId, fallen.current_tile, count: 1, joinSourceKingdom: true);
                    _deathKingKillRecords.Remove(fallen.getID());
                }
            )
        );
    }

    private void ApplyAbyssAuraTick(EraEffectContext context, Actor target)
    {
        float now = context.WorldTime;
        long targetId = target.getID();
        _abyssAuraEntries.TryGetValue(targetId, out AbyssAuraEntry? entry);
        if (entry == null)
        {
            entry = new AbyssAuraEntry { EnteredAt = now, LastSeen = now };
            _abyssAuraEntries[targetId] = entry;
        }
        else
        {
            entry.LastSeen = now;
        }

        _statuses.ApplyTimedDebuff(
            target,
            durationWorldTime: EraWorldTime.MonthToWorldTime(1f),
            new Dictionary<string, float> { [EraAttributeIds.Accuracy] = -30f },
            runtimeKey: "ew_abyss_p0_accuracy"
        );

        if (_abyssMadTargets.Contains(targetId))
        {
            return;
        }

        if (now - entry.EnteredAt < EraWorldTime.YearsToWorldTime(1f))
        {
            return;
        }

        _abyssMadTargets.Add(targetId);
        _statuses.ApplyTimedDebuff(
            target,
            durationWorldTime: EraWorldTime.YearsToWorldTime(3f),
            new Dictionary<string, float>
            {
                [EraAttributeIds.MultiplierDamage] = 20f,
                [EraAttributeIds.Accuracy] = -40f,
                [EraAttributeIds.MultiplierSpeed] = -10f,
            },
            runtimeKey: AbyssMadnessRuntimeKey
        );
        WorldboxReflectionAdapter.TryAddStatusEffect(target, "madness", EraWorldTime.YearsToWorldTime(3f), true);

        EraEffectContext madnessContext = new(
            target,
            target,
            context.WorldTime,
            "demon_abyss_god#p0_madness",
            EraTriggerType.OnTick
        );
        _effects.ApplyAreaDamage(
            madnessContext,
            target.current_tile!,
            radius: 4f,
            flatDamage: 3,
            targetRule: EraEffectTargetRule.Friends
        );
    }

    private void PruneAbyssAuraEntries(float worldTime)
    {
        List<long> stale = new();
        foreach ((long id, AbyssAuraEntry entry) in _abyssAuraEntries)
        {
            if (worldTime - entry.LastSeen > EraWorldTime.MonthToWorldTime(3f))
            {
                stale.Add(id);
            }
        }

        foreach (long id in stale)
        {
            _abyssAuraEntries.Remove(id);
            _abyssMadTargets.Remove(id);
        }
    }

    private void CreateCorruptionPool(EraEffectContext context, Actor actor)
    {
        string poolKey = $"{AbyssCorruptionPoolKeyPrefix}{actor.getID()}";
        _terrain.UpsertPeriodicArea(
            poolKey,
            actor,
            actor,
            actor.current_tile!,
            radius: 6f,
            durationWorldTime: 10f,
            tickIntervalWorldTime: 1f,
            targetRule: EraEffectTargetRule.Foes,
            onPulse: (effectContext, center) =>
            {
                _effects.ApplyAreaCurrentHealthDamage(
                    effectContext,
                    center,
                    radius: 6f,
                    percent: 0.01f
                );
                int healAmount = Math.Max(1, (int)MathF.Round(actor.getHealth() * 0.02f));
                _effects.ApplyHealing(effectContext, actor, flatAmount: healAmount);
            },
            onActorTick: (effectContext, target) =>
            {
                _statuses.ApplyTimedDebuff(
                    target,
                    durationWorldTime: 1f,
                    new Dictionary<string, float> { [EraAttributeIds.MultiplierSpeed] = -40f },
                    runtimeKey: "ew_abyss_s2_slow"
                );
            }
        );
    }

    private void StartSoulSiphon(EraEffectContext context, Actor actor, Actor target)
    {
        string siphonKey = $"{AbyssSiphonKeyPrefix}{target.getID()}";
        _terrain.UpsertPeriodicArea(
            siphonKey,
            actor,
            target,
            target.current_tile!,
            radius: 1f,
            durationWorldTime: 3f,
            tickIntervalWorldTime: 1f,
            targetRule: EraEffectTargetRule.Foes,
            onActorTick: (effectContext, victim) =>
            {
                if (victim.getID() != target.getID())
                {
                    return;
                }

                if (actor.current_tile == null || victim.current_tile == null)
                {
                    return;
                }

                float dx = actor.current_tile.x - victim.current_tile.x;
                float dy = actor.current_tile.y - victim.current_tile.y;
                if ((dx * dx) + (dy * dy) > 100f)
                {
                    return;
                }

                int damage = _effects.ApplyDamage(effectContext, victim, damageMultiplier: 0.3f, preserveOneHitPoint: false);
                if (damage > 0)
                {
                    _effects.ApplyHealing(effectContext, actor, flatAmount: damage);
                }
            }
        );
    }

    private void CreateRiftVortex(EraEffectContext context, Actor actor, WorldTile center, string suffix)
    {
        string vortexKey = $"{AbyssRiftVortexPrefix}{actor.getID()}:{suffix}";
        _terrain.UpsertPeriodicArea(
            vortexKey,
            actor,
            actor,
            center,
            radius: 5f,
            durationWorldTime: 3f,
            tickIntervalWorldTime: 1f,
            targetRule: EraEffectTargetRule.Foes,
            onActorTick: (effectContext, target) =>
            {
                _statuses.ApplyTimedDebuff(
                    target,
                    durationWorldTime: 1f,
                    new Dictionary<string, float> { [EraAttributeIds.MultiplierSpeed] = -50f },
                    runtimeKey: $"{vortexKey}:slow"
                );
            }
        );
    }

    private WorldTile? ResolveRiftDestination(WorldTile origin, float worldTime)
    {
        if (World.world == null)
        {
            return null;
        }

        int radius = 10;
        List<WorldTile> candidates = new();
        WorldTile? best = null;
        foreach (WorldTile tile in origin.getTilesAround(radius))
        {
            if (tile == null || tile == origin || tile.is_liquid || tile.hasBuilding())
            {
                continue;
            }

            float dx = tile.x - origin.x;
            float dy = tile.y - origin.y;
            float distance = MathF.Sqrt((dx * dx) + (dy * dy));
            if (distance >= 9f && distance <= 11f)
            {
                candidates.Add(tile);
            }
        }

        if (candidates.Count == 0)
        {
            return origin;
        }

        EraStableRandomService? random = EraRuntimeBootstrap.StableRandom;
        int index = random != null
            ? random.NextInt("abyss:rift", $"{origin.x}:{origin.y}", 0, candidates.Count)
            : 0;
        best = candidates[index % candidates.Count];
        return best;
    }

    private string PickAberrationAsset(long actorId)
    {
        EraStableRandomService? random = EraRuntimeBootstrap.StableRandom;
        int start = 0;
        if (random != null)
        {
            start = random.NextInt("abyss:s5", actorId.ToString(), 0, AbyssAberrationCandidates.Length);
        }

        for (int i = 0; i < AbyssAberrationCandidates.Length; i++)
        {
            string candidate = AbyssAberrationCandidates[(start + i) % AbyssAberrationCandidates.Length];
            if (AssetManager.actor_library.has(candidate))
            {
                return candidate;
            }
        }

        return ZombieAssetId;
    }
}
