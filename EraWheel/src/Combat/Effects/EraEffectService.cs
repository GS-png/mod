using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HarmonyLib;
using EraWheel.Combat.Statuses;
using EraWheel.Combat.Summons;
using EraWheel.Core.Constants;

namespace EraWheel.Combat.Effects;

public sealed class EraEffectService
{
    private static readonly MethodInfo? GetHitMethod = AccessTools.Method(
        typeof(BaseSimObject),
        "getHit",
        new[]
        {
            typeof(float),
            typeof(bool),
            typeof(AttackType),
            typeof(BaseSimObject),
            typeof(bool),
            typeof(bool),
            typeof(bool),
        }
    );

    private readonly EraStatusRuntimeService _statuses;
    private readonly EraSummonService _summons = new();

    public EraEffectService(EraStatusRuntimeService statuses)
    {
        _statuses = statuses;
    }

    public int ApplyAreaDamage(
        EraEffectContext context,
        WorldTile centerTile,
        float radius,
        int flatDamage = 0,
        float damageMultiplier = 1f,
        EraEffectTargetRule targetRule = EraEffectTargetRule.Foes,
        AttackType attackType = AttackType.Other,
        bool preserveOneHitPoint = false
    )
    {
        int affected = 0;
        foreach (Actor actor in FindActors(centerTile, radius, context.Source, targetRule))
        {
            if (ApplyDirectDamage(context, actor, flatDamage, damageMultiplier, attackType, preserveOneHitPoint) > 0)
            {
                affected++;
            }
        }

        return affected;
    }

    public int ApplyDamage(
        EraEffectContext context,
        BaseSimObject target,
        int flatDamage = 0,
        float damageMultiplier = 1f,
        AttackType attackType = AttackType.Other,
        bool preserveOneHitPoint = false
    )
    {
        return ApplyDirectDamage(
            context,
            target,
            flatDamage,
            damageMultiplier,
            attackType,
            preserveOneHitPoint
        );
    }

    public int ApplyAreaCurrentHealthDamage(
        EraEffectContext context,
        WorldTile centerTile,
        float radius,
        float percent,
        bool preserveOneHitPoint = true,
        EraEffectTargetRule targetRule = EraEffectTargetRule.Foes,
        AttackType attackType = AttackType.Other
    )
    {
        int affected = 0;
        foreach (Actor actor in FindActors(centerTile, radius, context.Source, targetRule))
        {
            if (ApplyCurrentHealthDamage(context, actor, percent, preserveOneHitPoint, attackType) > 0)
            {
                affected++;
            }
        }

        return affected;
    }

    public int ApplyCurrentHealthDamage(
        EraEffectContext context,
        BaseSimObject target,
        float percent,
        bool preserveOneHitPoint = true,
        AttackType attackType = AttackType.Other
    )
    {
        if (target == null || percent <= 0f || !target.hasHealth())
        {
            return 0;
        }

        int currentHealth = target.getHealth();
        int damage = (int)MathF.Round(currentHealth * percent);
        if (preserveOneHitPoint)
        {
            damage = Math.Min(damage, Math.Max(0, currentHealth - 1));
        }

        return ApplyResolvedDamage(context, target, damage, attackType);
    }

    public int ApplyHealing(
        EraEffectContext context,
        BaseSimObject target,
        int flatAmount = 0,
        float percentOfMaxHealth = 0f
    )
    {
        if (target == null || !target.hasHealth())
        {
            return 0;
        }

        int healing = flatAmount;
        if (percentOfMaxHealth > 0f)
        {
            healing += (int)MathF.Round(target.getMaxHealth() * percentOfMaxHealth);
        }

        if (healing <= 0)
        {
            return 0;
        }

        target.changeHealth(healing);
        return healing;
    }

    public int ApplyAreaHealing(
        EraEffectContext context,
        WorldTile centerTile,
        float radius,
        int flatAmount = 0,
        float percentOfMaxHealth = 0f,
        EraEffectTargetRule targetRule = EraEffectTargetRule.Friends
    )
    {
        int affected = 0;
        foreach (Actor actor in FindActors(centerTile, radius, context.Source, targetRule))
        {
            if (ApplyHealing(context, actor, flatAmount, percentOfMaxHealth) > 0)
            {
                affected++;
            }
        }

        return affected;
    }

    public bool ApplyPull(EraEffectContext context, BaseSimObject target, float forceAmount = 1f)
    {
        return ApplyPullToPoint(
            context,
            target,
            context.Source?.current_tile ?? target?.current_tile,
            forceAmount
        );
    }

    public bool ApplyPullToPoint(
        EraEffectContext context,
        BaseSimObject target,
        WorldTile? centerTile,
        float forceAmount = 1f
    )
    {
        if (World.world == null || target?.current_tile == null)
        {
            return false;
        }

        WorldTile center = centerTile ?? target.current_tile;
        World.world.applyForceOnTile(
            center,
            pRad: 1,
            pForceAmount: Math.Max(0.1f, forceAmount),
            pForceOut: false,
            pDamage: 0,
            pIgnoreKingdoms: null,
            pByWho: context.Source
        );
        return true;
    }

    public int ApplyAreaPull(
        EraEffectContext context,
        WorldTile centerTile,
        float radius,
        float forceAmount = 1f,
        EraEffectTargetRule targetRule = EraEffectTargetRule.Foes
    )
    {
        int affected = 0;
        foreach (Actor actor in FindActors(centerTile, radius, context.Source, targetRule))
        {
            if (ApplyPullToPoint(context, actor, centerTile, forceAmount))
            {
                affected++;
            }
        }

        return affected;
    }

    public bool ApplyKnockback(EraEffectContext context, BaseSimObject target, float forceMultiplier = 1f)
    {
        if (target == null)
        {
            return false;
        }

        AttackData attackData = BuildAttackData(context, target, AttackType.Other);
        ai.ActorTool.applyForceToUnit(attackData, target, Math.Max(0.1f, forceMultiplier));
        return true;
    }

    public int ApplyAreaKnockback(
        EraEffectContext context,
        WorldTile centerTile,
        float radius,
        float forceMultiplier = 1f,
        EraEffectTargetRule targetRule = EraEffectTargetRule.Foes
    )
    {
        int affected = 0;
        foreach (Actor actor in FindActors(centerTile, radius, context.Source, targetRule))
        {
            if (ApplyKnockback(context, actor, forceMultiplier))
            {
                affected++;
            }
        }

        return affected;
    }

    public EraActiveStatus? ApplyStatus(EraEffectContext context, BaseSimObject target, EraStatusApplication application)
    {
        if (target == null)
        {
            return null;
        }

        return _statuses.Apply(target, application.Clone(), context.WorldTime);
    }

    public IReadOnlyList<EraActiveStatus> ApplyAreaStatus(
        EraEffectContext context,
        WorldTile centerTile,
        float radius,
        EraStatusApplication application,
        EraEffectTargetRule targetRule = EraEffectTargetRule.Foes,
        Func<BaseSimObject, EraStatusApplication, EraStatusApplication>? customize = null
    )
    {
        return _statuses.ApplyToTargets(
            FindActors(centerTile, radius, context.Source, targetRule),
            application,
            context.WorldTime,
            customize
        );
    }

    public IReadOnlyList<Actor> SummonUnits(
        EraEffectContext context,
        string actorAssetId,
        WorldTile centerTile,
        int count,
        bool joinSourceKingdom = true
    )
    {
        return _summons.SummonUnits(context, actorAssetId, centerTile, count, joinSourceKingdom);
    }

    public string CreateStatusReport()
    {
        return $"原语=范围伤害/当前生命伤害/治疗/牵引/击退/召唤/状态施加；{_summons.CreateStatusReport()}";
    }

    public IEnumerable<Actor> FindActors(
        WorldTile centerTile,
        float radius,
        BaseSimObject? source,
        EraEffectTargetRule targetRule
    )
    {
        if (World.world?.units == null || centerTile == null)
        {
            return Enumerable.Empty<Actor>();
        }

        float radiusSquared = radius * radius;
        List<Actor> result = new List<Actor>();
        foreach (Actor actor in World.world.units)
        {
            if (actor == null || !actor.isAlive() || actor.current_tile == null)
            {
                continue;
            }

            float dx = actor.current_tile.x - centerTile.x;
            float dy = actor.current_tile.y - centerTile.y;
            if ((dx * dx) + (dy * dy) > radiusSquared)
            {
                continue;
            }

            if (!MatchesRule(source, actor, targetRule))
            {
                continue;
            }

            result.Add(actor);
        }

        return result;
    }

    private int ApplyDirectDamage(
        EraEffectContext context,
        BaseSimObject target,
        int flatDamage,
        float damageMultiplier,
        AttackType attackType,
        bool preserveOneHitPoint
    )
    {
        float baseDamage = context.Source != null
            ? EraWorldboxStatsAccessor.GetStat(context.Source, EraAttributeIds.Damage)
            : 0f;
        int resolved = flatDamage > 0
            ? flatDamage
            : (int)MathF.Round(baseDamage * Math.Max(0f, damageMultiplier));

        if (preserveOneHitPoint && target.hasHealth())
        {
            resolved = Math.Min(resolved, Math.Max(0, target.getHealth() - 1));
        }

        return ApplyResolvedDamage(context, target, resolved, attackType);
    }

    private static int ApplyResolvedDamage(
        EraEffectContext context,
        BaseSimObject target,
        int resolvedDamage,
        AttackType attackType
    )
    {
        if (target == null || resolvedDamage <= 0)
        {
            return 0;
        }

        if (GetHitMethod == null)
        {
            target.changeHealth(-resolvedDamage);
            return resolvedDamage;
        }

        GetHitMethod.Invoke(
            target,
            new object?[]
            {
                (float)resolvedDamage,
                true,
                attackType,
                context.Source,
                true,
                false,
                true,
            }
        );
        return resolvedDamage;
    }

    private static bool MatchesRule(BaseSimObject? source, Actor target, EraEffectTargetRule rule)
    {
        Actor? sourceActor = source as Actor;
        return rule switch
        {
            EraEffectTargetRule.All => true,
            EraEffectTargetRule.SelfOnly => source != null && target.getID() == source.getID(),
            EraEffectTargetRule.Others => source == null || target.getID() != source.getID(),
            EraEffectTargetRule.Friends => sourceActor != null && sourceActor.hasKingdom() && sourceActor.isSameKingdom(target),
            EraEffectTargetRule.Foes => source == null || source.areFoes(target),
            _ => true,
        };
    }

    private static AttackData BuildAttackData(EraEffectContext context, BaseSimObject target, AttackType attackType)
    {
        BaseSimObject initiator = context.Source ?? target;
        WorldTile? hitTile = target.current_tile ?? initiator.current_tile ?? World.world?.GetTile(0, 0);
        if (hitTile == null)
        {
            throw new InvalidOperationException("当前世界缺少可用落点，无法构造 AttackData。");
        }

        return new AttackData(
            initiator,
            hitTile,
            target.current_position,
            initiator.current_position,
            target,
            initiator.kingdom,
            attackType,
            pMetallicWeapon: false,
            pSkipShake: true,
            pProjectile: false,
            pProjectileID: string.Empty,
            pKillAction: null,
            pBonusAreOfEffect: 0f
        );
    }
}
