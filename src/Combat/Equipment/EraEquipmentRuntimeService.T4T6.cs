using System;
using System.Collections.Generic;
using System.Linq;
using EraWheel.Combat;
using EraWheel.Combat.Effects;
using EraWheel.Combat.Statuses;
using EraWheel.Combat.Triggers;
using EraWheel.Core.Constants;
using EraWheel.Core.Logging;
using EraWheel.Core.Time;

namespace EraWheel.Combat.Equipment;

public sealed partial class EraEquipmentRuntimeService
{
    private const string PrismBowId = "eq_herit_t4_prism_bow";
    private const string FrostOathHelmId = "eq_herit_t4_frost_oath_helm";
    private const string SilenceSealAmuletId = "eq_herit_t4_silence_seal_amulet";
    private const string MeteorHammerId = "eq_herit_t5_meteor_hammer";
    private const string GrovePlateId = "eq_herit_t5_grove_plate";
    private const string HuntGreavesId = "eq_herit_t5_hunt_greaves";
    private const string StarcoreStaffId = "eq_herit_t6_starcore_staff";
    private const string BoneCrownId = "eq_herit_t6_bone_crown";
    private const string RefluxRingId = "eq_herit_t6_reflux_ring";
    private const string SkeletonAssetId = "skeleton";

    private static readonly AttackAction MeteorHammerNativeOnHitAction = TriggerMeteorHammerNativeOnHit;

    partial void BindTier4To6NativeEquipmentActions()
    {
        if (BindNativeAttackAction(MeteorHammerId, MeteorHammerNativeOnHitAction))
        {
            MarkActorsWithEquipmentStatsDirty(MeteorHammerId);
        }
    }

    partial void RegisterTier4To6EquipmentTriggers()
    {
        RegisterActiveEquipmentSkill(
            PrismBowId,
            (context, actor) =>
            {
                Actor? primary = ResolveEnemyTarget(actor, 20f);
                if (primary?.current_tile == null)
                {
                    return;
                }

                float bonus = ConsumeNextActiveSkillBonus(actor);
                float multiplier = RollBetween(actor, primary, "prism_bow_damage", 0.45f, 0.65f) * bonus;
                List<Actor> extraTargets = _effects.FindActors(primary.current_tile, 8f, actor, EraEffectTargetRule.Foes)
                    .Where(candidate => candidate.getID() != primary.getID())
                    .Take(3)
                    .ToList();

                foreach (Actor victim in extraTargets)
                {
                    _effects.ApplyDamage(context, victim, damageMultiplier: multiplier);
                }
            },
            cooldownWorldTime: DefaultActiveCooldown,
            targetSearchRadius: 20f
        );

        RegisterOnGetHitEquipmentSkill(
            FrostOathHelmId,
            (context, actor) =>
            {
                Actor? attacker = context.SourceActor;
                if (attacker == null)
                {
                    return;
                }

                float debuff = RollBetween(actor, attacker, "frost_oath_debuff", 45f, 65f);
                ApplyTimedDebuff(
                    attacker,
                    $"ew_equip_frost_oath:{attacker.getID()}",
                    EraWorldTime.YearsToWorldTime(2f),
                    new Dictionary<string, float>
                    {
                        [EraAttributeIds.MultiplierSpeed] = -debuff,
                        [EraAttributeIds.MultiplierAttackSpeed] = -debuff,
                    }
                );
            }
        );

        RegisterActiveEquipmentSkill(
            SilenceSealAmuletId,
            (context, actor) =>
            {
                Actor? target = ResolveEnemyTarget(actor, 18f);
                if (target?.current_tile == null)
                {
                    return;
                }

                float accuracyPenalty = RollBetween(actor, target, "silence_seal_accuracy", 15f, 35f);
                _statuses.ApplySilence(
                    target,
                    EraWorldTime.YearsToWorldTime(1f),
                    runtimeKey: $"ew_equip_silence_target:{target.getID()}"
                );

                foreach (Actor victim in _effects.FindActors(target.current_tile, 4f, actor, EraEffectTargetRule.Foes))
                {
                    ApplyTimedDebuff(
                        victim,
                        $"{SilenceSealAccuracyKeyPrefix}{victim.getID()}",
                        EraWorldTime.YearsToWorldTime(1f),
                        new Dictionary<string, float>
                        {
                            [EraAttributeIds.Accuracy] = -accuracyPenalty,
                        }
                    );
                }
            },
            cooldownWorldTime: DefaultActiveCooldown,
            targetSearchRadius: 18f
        );

        RegisterOnGetHitEquipmentSkill(
            GrovePlateId,
            (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                float armorBonus = RollBetween(actor, context.SourceActor, "grove_plate_armor", 60f, 80f);
                foreach (Actor ally in _effects.FindActors(actor.current_tile, 6f, actor, EraEffectTargetRule.Friends))
                {
                    ApplyTimedBuff(
                        ally,
                        $"ew_equip_grove_plate:{ally.getID()}",
                        EraWorldTime.YearsToWorldTime(3f),
                        new Dictionary<string, float>
                        {
                            [EraAttributeIds.Armor] = armorBonus,
                        }
                    );
                }
            }
        );

        RegisterOnHitEquipmentSkill(
            HuntGreavesId,
            (context, actor) =>
            {
                Actor? target = context.TargetActor;
                if (target == null || !IsLowHealth(target, 0.5f))
                {
                    return;
                }

                float bonusRatio = RollBetween(actor, target, "hunt_greaves_execute", 0.60f, 0.80f);
                int extraDamage = Math.Max(1, (int)MathF.Round(Math.Max(0f, context.Damage) * bonusRatio));
                _effects.ApplyDamage(context.ToEffectContext(), target, flatDamage: extraDamage);
            }
        );

        RegisterOnHitEquipmentSkill(
            StarcoreStaffId,
            (context, actor) =>
            {
                Actor? target = context.TargetActor;
                if (target?.current_tile == null)
                {
                    return;
                }

                float damageMultiplier = RollBetween(actor, target, "starcore_staff_damage", 0.75f, 0.95f);
                _effects.ApplyAreaDamage(
                    context.ToEffectContext(),
                    target.current_tile,
                    6f,
                    damageMultiplier: damageMultiplier,
                    targetRule: EraEffectTargetRule.Foes
                );

                foreach (Actor victim in _effects.FindActors(target.current_tile, 6f, actor, EraEffectTargetRule.Foes))
                {
                    _statuses.ApplyStun(
                        victim,
                        2f,
                        runtimeKey: $"ew_equip_starcore_stun:{victim.getID()}"
                    );
                }
            }
        );

        RegisterActiveEquipmentSkill(
            BoneCrownId,
            (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                _effects.SummonUnits(context, SkeletonAssetId, actor.current_tile, count: 10, joinSourceKingdom: true);
            },
            cooldownWorldTime: DefaultActiveCooldown
        );

        RegisterActiveEquipmentSkill(
            RefluxRingId,
            (context, actor) =>
            {
                float manaPercent = RollBetween(actor, actor, "reflux_ring_mana", 0.25f, 0.50f);
                float damageBonusPercent = RollBetween(actor, actor, "reflux_ring_bonus", 75f, 95f);
                RestoreManaPercent(actor, manaPercent);
                _statuses.ApplyNow(
                    actor,
                    new EraStatusApplication(
                        EraStatusKind.TimedBuff,
                        EraWorldTime.YearsToWorldTime(5f),
                        EraStatusStackMode.Replace,
                        runtimeKey: $"{RefluxChargeKey}:{actor.getID()}",
                        statModifiers: new Dictionary<string, float>
                        {
                            [EraAttributeIds.MultiplierDamage] = damageBonusPercent,
                        }
                    )
                );
            },
            cooldownWorldTime: DefaultActiveCooldown
        );
    }

    private static bool TriggerMeteorHammerNativeOnHit(BaseSimObject self, BaseSimObject target, WorldTile tile)
    {
        try
        {
            EraCombatRuntimeBridge.Current?.Equipment?.ApplyMeteorHammerNativeOnHit(self, target);
        }
        catch (Exception exception)
        {
            EraLog.Exception(
                EraLogCategory.Combat,
                $"陨星锤原版命中回调执行失败：{MeteorHammerId}。",
                exception
            );
        }

        return false;
    }

    private void ApplyMeteorHammerNativeOnHit(BaseSimObject self, BaseSimObject target)
    {
        if (self is not Actor actor)
        {
            return;
        }

        float worldTime = ReadWorldTime();
        string triggerId = $"{MeteorHammerId}#on_hit";
        if (!TryBeginNativeOnHitEquipmentProc(actor, target, MeteorHammerId, triggerId, worldTime))
        {
            return;
        }

        if (target is not Actor targetActor || targetActor.current_tile == null)
        {
            return;
        }

        WorldTile center = targetActor.current_tile;
        float damageMultiplier = RollBetween(actor, targetActor, "meteor_hammer_damage", 0.60f, 0.80f);
        EraEffectContext context = new EraEffectContext(
            actor,
            targetActor,
            worldTime,
            "MapBox.applyAttack",
            EraTriggerType.OnHit
        );

        ActionLibrary.unluckyMeteorite(actor, center);
        _effects.ApplyAreaDamage(
            context,
            center,
            6f,
            damageMultiplier: damageMultiplier,
            targetRule: EraEffectTargetRule.Foes
        );
        _effects.ApplyAreaKnockback(context, center, 6f, forceMultiplier: 2f);
    }
}
