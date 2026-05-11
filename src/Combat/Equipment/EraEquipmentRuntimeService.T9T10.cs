using System;
using System.Collections.Generic;
using EraWheel.Combat.Effects;
using EraWheel.Core.Constants;
using EraWheel.Core.Time;

namespace EraWheel.Combat.Equipment;

public sealed partial class EraEquipmentRuntimeService
{
    private const string HeavenArcBowId = "eq_herit_t9_heaven_arc_bow";
    private const string CrownOfCitiesId = "eq_herit_t9_crown_of_cities";
    private const string BlackSunAmuletId = "eq_herit_t9_black_sun_amulet";
    private const string FinalLanceId = "eq_herit_t10_final_lance";
    private const string OmniKingArmorId = "eq_herit_t10_omni_king_armor";
    private const string CycleSingularityRingId = "eq_herit_t10_cycle_singularity_ring";

    partial void RegisterTier9To10EquipmentTriggers()
    {
        RegisterOnHitEquipmentSkill(
            HeavenArcBowId,
            (context, actor) =>
            {
                Actor? target = context.TargetActor;
                if (target?.current_tile == null)
                {
                    return;
                }

                float followUpMultiplier = RollBetween(actor, target, "heaven_arc_follow_up", 0.50f, 0.80f);
                ActionLibrary.castLightning(actor, target, target.current_tile);
                _effects.ApplyDamage(context.ToEffectContext(), target, damageMultiplier: 1f, attackType: AttackType.Divine);
                for (int index = 0; index < 2; index++)
                {
                    ActionLibrary.castLightning(actor, target, target.current_tile);
                    _effects.ApplyDamage(
                        context.ToEffectContext(),
                        target,
                        damageMultiplier: followUpMultiplier,
                        attackType: AttackType.Divine
                    );
                }
            }
        );

        RegisterActiveEquipmentSkill(
            CrownOfCitiesId,
            (context, actor) => ApplyCrownMobilization(context, actor),
            cooldownWorldTime: DefaultActiveCooldown
        );

        RegisterOnGetHitEquipmentSkill(
            CrownOfCitiesId,
            (context, actor) => ApplyCrownMobilization(context.ToEffectContext(), actor),
            cooldownWorldTime: DefaultActiveCooldown
        );

        RegisterActiveEquipmentSkill(
            BlackSunAmuletId,
            (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 20f);
                WorldTile? center = target?.current_tile ?? actor.current_tile;
                if (center == null)
                {
                    return;
                }

                _effects.ApplyAreaPull(context, center, 8f, forceAmount: 4f);
                foreach (Actor victim in _effects.FindActors(center, 8f, actor, EraEffectTargetRule.Foes))
                {
                    ApplyTimedDebuff(
                        victim,
                        $"{BlackSunSlowKeyPrefix}{victim.getID()}",
                        EraWorldTime.YearsToWorldTime(5f),
                        new Dictionary<string, float>
                        {
                            [EraAttributeIds.MultiplierSpeed] = -40f,
                        }
                    );
                }
            },
            cooldownWorldTime: DefaultActiveCooldown,
            targetSearchRadius: 20f
        );

        RegisterOnHitEquipmentSkill(
            FinalLanceId,
            (context, actor) =>
            {
                Actor? target = context.TargetActor;
                if (target?.current_tile == null)
                {
                    return;
                }

                float damageMultiplier = RollBetween(actor, target, "final_lance_damage", 1.35f, 1.55f);
                _effects.ApplyDamage(context.ToEffectContext(), target, damageMultiplier: damageMultiplier);
                _effects.ApplyAreaDamage(
                    context.ToEffectContext(),
                    target.current_tile,
                    10f,
                    damageMultiplier: damageMultiplier,
                    targetRule: EraEffectTargetRule.Foes
                );
            }
        );

        RegisterOnGetHitEquipmentSkill(
            OmniKingArmorId,
            (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                _statuses.ApplyShield(
                    actor,
                    100000f,
                    EraWorldTime.YearsToWorldTime(1f),
                    runtimeKey: $"ew_equip_omni_king_shield:{actor.getID()}"
                );
                _effects.ApplyAreaKnockback(context.ToEffectContext(), actor.current_tile, 10f, forceMultiplier: 4f);
            }
        );

        RegisterActiveEquipmentSkill(
            CycleSingularityRingId,
            (context, actor) =>
            {
                WorldTile? center = actor.current_tile;
                if (center == null)
                {
                    return;
                }

                _effects.ApplyAreaPull(context, center, 10f, forceAmount: 5f);
                _effects.ApplyAreaCurrentHealthDamage(
                    context,
                    center,
                    10f,
                    percent: 0.15f,
                    targetRule: EraEffectTargetRule.Foes
                );
            },
            cooldownWorldTime: DefaultActiveCooldown
        );
    }

    private void ApplyCrownMobilization(EraEffectContext context, Actor actor)
    {
        if (actor.current_tile == null)
        {
            return;
        }

        float expMultiplier = RollBetween(actor, actor, "crown_exp_gain", 2.2f, 2.4f);
        float combatBonus = RollBetween(actor, actor, "crown_skill_combat", 120f, 140f);
        foreach (Actor ally in _effects.FindActors(actor.current_tile, 8f, actor, EraEffectTargetRule.Friends))
        {
            ApplyTimedBuff(
                ally,
                $"{CrownMobilizationKeyPrefix}{ally.getID()}",
                EraWorldTime.YearsToWorldTime(5f),
                new Dictionary<string, float>
                {
                    [EraAttributeIds.FastLearners] = expMultiplier,
                    [EraAttributeIds.SkillCombat] = combatBonus,
                }
            );
            AddExperience(ally, 20);
        }
    }
}
