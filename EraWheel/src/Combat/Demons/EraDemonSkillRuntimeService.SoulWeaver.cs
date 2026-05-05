using System;
using System.Collections.Generic;
using System.Linq;
using EraWheel.Combat.Effects;
using EraWheel.Combat.Statuses;
using EraWheel.Combat.Triggers;
using EraWheel.Core.Constants;
using EraWheel.Core.Time;
using EraWheel.Reflection;

namespace EraWheel.Combat.Demons;

public sealed partial class EraDemonSkillRuntimeService
{
    private const string SoulWeaverId = "demon_soul_weaver";
    private const string SoulGhostAssetId = "ghost";
    private const string SoulMarkRuntimeKey = "ew_soul_weaver_mark";
    private const string SoulGhostRuntimeKey = "ew_soul_weaver_ghost";
    private const string SoulS4DebuffKey = "ew_soul_weaver_s4_tear";
    private const string SoulS5ShieldKey = "ew_soul_weaver_s5_shield";
    private const string SoulS6BuffKey = "ew_soul_weaver_s6_storm";
    private static readonly Random SoulChainRandom = new();

    private readonly Dictionary<long, SoulChainEntry> _soulChainEntries = new();
    private readonly Dictionary<long, SoulKillRecord> _soulGhostKillRecords = new();

    private sealed class SoulChainEntry
    {
        public SoulChainEntry(List<long> targetIds, float expiresAt)
        {
            TargetIds = targetIds;
            ExpiresAt = expiresAt;
        }

        public List<long> TargetIds { get; }
        public float ExpiresAt { get; set; }
    }

    private sealed class SoulKillRecord
    {
        public long KillerId { get; set; }
        public float Timestamp { get; set; }
    }

    private void RegisterSoulWeaver()
    {
        RegisterSoulWeaverTriggers();
        RegisterSoulWeaverSkills();
    }

    private void RegisterSoulWeaverTriggers()
    {
        _triggers.RegisterActorAssetTrigger(
            "demon_soul_weaver#p0_mark",
            SoulWeaverId,
            EraTriggerType.OnHit,
            EraTriggerSubject.Source,
            SoulWeaverId,
            (context, actor) =>
            {
                Actor? target = context.TargetActor;
                if (target == null || target.asset?.id == SoulWeaverId || IsSoulGhost(target))
                {
                    return;
                }

                _statuses.ApplyMark(target, 15f, stackDelta: 1, maxStacks: 1, runtimeKey: SoulMarkRuntimeKey);
            }
        );

        _triggers.Register(
            new EraTriggerDefinition(
                "demon_soul_weaver#p0_ghost_last_hit",
                SoulWeaverId,
                EraTriggerType.OnHit,
                context =>
                {
                    Actor? attacker = context.SourceActor;
                    Actor? target = context.TargetActor;
                    if (attacker == null || target == null || !IsSoulGhost(target))
                    {
                        return;
                    }

                    _soulGhostKillRecords[target.getID()] = new SoulKillRecord
                    {
                        KillerId = attacker.getID(),
                        Timestamp = context.WorldTime,
                    };
                }
            )
        );

        _triggers.Register(
            new EraTriggerDefinition(
                "demon_soul_weaver#p0_spawn_ghost",
                SoulWeaverId,
                EraTriggerType.OnDeath,
                context =>
                {
                    Actor? victim = context.TargetActor;
                    if (victim == null || victim.asset?.id == SoulWeaverId || IsSoulGhost(victim))
                    {
                        return;
                    }

                    if (!_statuses.TryGetStatus(victim, SoulMarkRuntimeKey, out _))
                    {
                        return;
                    }

                    _statuses.Remove(victim, SoulMarkRuntimeKey);
                    if (victim.current_tile == null)
                    {
                        return;
                    }

                    _effects.SummonUnits(
                        context.ToEffectContext(),
                        SoulGhostAssetId,
                        victim.current_tile,
                        count: 1,
                        joinSourceKingdom: false
                    );
                }
            )
        );

        _triggers.Register(
            new EraTriggerDefinition(
                "demon_soul_weaver#p0_restore",
                SoulWeaverId,
                EraTriggerType.OnDeath,
                context =>
                {
                    Actor? ghost = context.TargetActor;
                    if (ghost == null || !IsSoulGhost(ghost))
                    {
                        return;
                    }

                    if (!_soulGhostKillRecords.TryGetValue(ghost.getID(), out SoulKillRecord? record))
                    {
                        return;
                    }

                    _soulGhostKillRecords.Remove(ghost.getID());
                    if (context.WorldTime - record.Timestamp > 2f)
                    {
                        return;
                    }

                    Actor? killer = ResolveActor(record.KillerId);
                    if (killer?.asset?.id != SoulWeaverId)
                    {
                        return;
                    }

                    RestoreSoulResources(killer);
                }
            )
        );

        _triggers.RegisterActorAssetTrigger(
            "demon_soul_weaver#s3_share",
            SoulWeaverId,
            EraTriggerType.OnGetHit,
            EraTriggerSubject.Target,
            SoulWeaverId,
            (context, actor) =>
            {
                if (!TryGetActiveSoulChain(actor, context.WorldTime, out SoulChainEntry? entry) || entry == null)
                {
                    return;
                }

                if (entry.TargetIds.Count == 0)
                {
                    _soulChainEntries.Remove(actor.getID());
                    return;
                }

                EraEffectContext effectContext = new(
                    actor,
                    actor,
                    context.WorldTime,
                    "demon_soul_weaver#s3_split",
                    EraTriggerType.OnGetHit
                );

                int remainingDamage = Math.Max(1, (int)MathF.Round(context.Damage));
                int totalDistributed = 0;
                for (int index = entry.TargetIds.Count - 1; index >= 0 && remainingDamage > 0; index--)
                {
                    Actor? linked = ResolveActor(entry.TargetIds[index]);
                    if (linked == null || !linked.isAlive() || linked.current_tile == null)
                    {
                        entry.TargetIds.RemoveAt(index);
                        continue;
                    }

                    int targetsLeft = index + 1;
                    int sharedDamage = Math.Max(1, (int)MathF.Ceiling(remainingDamage / (float)targetsLeft));
                    int applied = _effects.ApplyDamage(
                        effectContext,
                        linked,
                        flatDamage: Math.Min(sharedDamage, remainingDamage),
                        preserveOneHitPoint: true
                    );
                    remainingDamage = Math.Max(0, remainingDamage - applied);
                    totalDistributed += applied;
                }

                if (entry.TargetIds.Count == 0 || context.WorldTime >= entry.ExpiresAt)
                {
                    _soulChainEntries.Remove(actor.getID());
                }

                if (totalDistributed > 0)
                {
                    _effects.ApplyHealing(effectContext, actor, flatAmount: totalDistributed);
                }
            }
        );
    }

    private void RegisterSoulWeaverSkills()
    {
        RegisterTickSkill(
            "demon_soul_weaver#s1",
            SoulWeaverId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 15f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 15f);
                if (target == null)
                {
                    return;
                }

                _statuses.ApplySilence(target, 5f, runtimeKey: "ew_soul_weaver_s1_silence");
                _statuses.ApplyTimedDebuff(
                    target,
                    5f,
                    new Dictionary<string, float>
                    {
                        [EraAttributeIds.MultiplierSpeed] = -99f,
                    },
                    runtimeKey: "ew_soul_weaver_s1_slow"
                );
            }
        );

        RegisterTickSkill(
            "demon_soul_weaver#s2",
            SoulWeaverId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 10f,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                Actor? enemy = ResolveEnemyTarget(actor, 10f);
                Actor? ally = _effects.FindActors(actor.current_tile, 10f, actor, EraEffectTargetRule.Friends)
                    .FirstOrDefault(candidate => candidate.getID() != actor.getID());
                if (enemy == null || ally == null)
                {
                    return;
                }

                EraEffectContext effectContext = new(
                    actor,
                    actor,
                    context.WorldTime,
                    "demon_soul_weaver#s2_swallow",
                    EraTriggerType.Active
                );

                int allyLoss = _effects.ApplyDamage(effectContext, ally, damageMultiplier: 1f, preserveOneHitPoint: true);
                int enemyLoss = _effects.ApplyDamage(effectContext, enemy, damageMultiplier: 1f);
                int healAmount = Math.Max(1, (int)MathF.Round((allyLoss + enemyLoss) * 0.5f));
                _effects.ApplyHealing(effectContext, actor, flatAmount: healAmount);
            }
        );

        RegisterTickSkill(
            "demon_soul_weaver#s3",
            SoulWeaverId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                List<Actor> candidates = _effects.FindActors(actor.current_tile, 10f, actor, EraEffectTargetRule.All)
                    .Where(candidate => candidate.getID() != actor.getID())
                    .ToList();
                if (candidates.Count == 0)
                {
                    return;
                }

                ShuffleSoulTargets(candidates);
                _soulChainEntries[actor.getID()] = new SoulChainEntry(
                    candidates.Take(4).Select(candidate => candidate.getID()).ToList(),
                    context.WorldTime + 12f
                );
            }
        );

        RegisterTickSkill(
            "demon_soul_weaver#s4",
            SoulWeaverId,
            chancePercent: 10f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            targetSearchRadius: 20f,
            handler: (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 20f);
                if (target == null)
                {
                    return;
                }

                _effects.ApplyCurrentHealthDamage(context, target, percent: 0.1f);
                _statuses.ApplyTimedDebuff(
                    target,
                    EraWorldTime.YearsToWorldTime(1000f),
                    new Dictionary<string, float>
                    {
                        [EraAttributeIds.MultiplierDamage] = -5f,
                        [EraAttributeIds.MultiplierAttackSpeed] = -5f,
                        [EraAttributeIds.MultiplierSpeed] = -5f,
                        [EraAttributeIds.Armor] = -5f,
                    },
                    runtimeKey: SoulS4DebuffKey,
                    maxStacks: 3
                );
            }
        );

        RegisterTickSkill(
            "demon_soul_weaver#s5",
            SoulWeaverId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                _effects.ApplyAreaStatus(
                    context,
                    actor.current_tile,
                    radius: 10f,
                    application: new EraStatusApplication(
                        EraStatusKind.Shield,
                        15f,
                        runtimeKey: SoulS5ShieldKey,
                        shieldAmount: 0f
                    ),
                    targetRule: EraEffectTargetRule.Friends,
                    customize: (target, application) =>
                    {
                        application.ShieldAmount = target.getMaxHealth() * 0.5f;
                        return application;
                    }
                );
            }
        );

        RegisterTickSkill(
            "demon_soul_weaver#s6",
            SoulWeaverId,
            chancePercent: 15f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(10f),
            manaCost: 15,
            requiresAdvent: true,
            handler: (context, actor) =>
            {
                _effects.ApplyHealing(context, actor, percentOfMaxHealth: 0.2f);
                _statuses.ApplyTimedBuff(
                    actor,
                    20f,
                    new Dictionary<string, float>
                    {
                        [EraAttributeIds.MultiplierDamage] = 30f,
                    },
                    runtimeKey: SoulS6BuffKey
                );
            }
        );
    }

    private bool TryGetActiveSoulChain(Actor actor, float worldTime, out SoulChainEntry? entry)
    {
        if (_soulChainEntries.TryGetValue(actor.getID(), out entry) && entry != null && worldTime < entry.ExpiresAt)
        {
            return true;
        }

        _soulChainEntries.Remove(actor.getID());
        entry = null;
        return false;
    }

    private static bool IsSoulGhost(Actor actor)
    {
        return actor.asset?.id == SoulGhostAssetId;
    }

    private static void ShuffleSoulTargets<T>(List<T> list)
    {
        for (int index = list.Count - 1; index > 0; index--)
        {
            int swapIndex = SoulChainRandom.Next(0, index + 1);
            (list[index], list[swapIndex]) = (list[swapIndex], list[index]);
        }
    }

    private void RestoreSoulResources(Actor caster)
    {
        int healAmount = Math.Max(1, (int)MathF.Round(caster.getHealth() * 0.05f));
        EraEffectContext effectContext = new(
            caster,
            caster,
            WorldboxReflectionAdapter.TryReadMapStats(out MapStats? mapStats) && mapStats != null ? (float)mapStats.world_time : 0f,
            "demon_soul_weaver#p0_restore",
            EraTriggerType.OnDeath
        );
        _effects.ApplyHealing(effectContext, caster, flatAmount: healAmount);

        if (!WorldboxReflectionAdapter.TryGetActorMana(caster, out int currentMana))
        {
            return;
        }

        int manaGain = Math.Max(1, (int)MathF.Round(caster.getMaxMana() * 0.05f));
        int nextMana = Math.Min(caster.getMaxMana(), currentMana + manaGain);
        WorldboxReflectionAdapter.TrySetActorMana(caster, nextMana);
    }
}
