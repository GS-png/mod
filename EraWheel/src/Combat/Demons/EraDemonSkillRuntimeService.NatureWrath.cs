using System;
using System.Collections.Generic;
using EraWheel.Assets;
using EraWheel.Combat.Effects;
using EraWheel.Combat.Statuses;
using EraWheel.Combat.Triggers;
using EraWheel.Core.Constants;
using EraWheel.Core.Logging;
using EraWheel.Core.Time;
using EraWheel.Reflection;
using NeoModLoader.General;

namespace EraWheel.Combat.Demons;

public sealed partial class EraDemonSkillRuntimeService
{
    private const string NatureWrathId = "demon_nature_wrath";
    private const string NatureDragonAssetId = "dragon";
    private const string NatureWorldTreeAssetId = "ew_nature_world_tree";
    private const string NatureWorldTreeIconPath = "Assets/Art/魔王技能图片/自然之怒/世界树降临/naturewrath_s6_worldtree_core_entity.png";
    private const string NatureWorldTreeAuraKey = "ew_nature_s6_world_tree_aura";
    private const string NatureWorldTreeCasterBuffKey = "ew_nature_s6_self";

    private readonly Dictionary<long, NatureWorldTreeEntry> _natureWorldTrees = new();

    private sealed class NatureWorldTreeEntry
    {
        public long CasterId { get; set; }
        public string CasterBuffRuntimeKey { get; set; } = string.Empty;
        public float ExpiresAtWorldTime { get; set; }
    }

    private void RegisterNatureWrath()
    {
        EnsureNatureWorldTreeAssetRegistered();
        RegisterNatureWrathTriggers();
        RegisterNatureWrathSkills();
    }

    private void RegisterNatureWrathTriggers()
    {
        _triggers.RegisterActorAssetTrigger(
            "demon_nature_wrath#p0_regen",
            NatureWrathId,
            EraTriggerType.OnTick,
            EraTriggerSubject.Source,
            NatureWrathId,
            (context, actor) =>
            {
                if (actor.current_tile == null ||
                    !IsNatureAlignedTile(actor.current_tile) ||
                    !CanRunTimer(BuildActorTimerKey(actor, "nature_p0"), context.WorldTime, 15f))
                {
                    return;
                }

                EraEffectContext effectContext = context.ToEffectContext();
                int healAmount = Math.Max(1, (int)MathF.Round(actor.getHealth() * 0.01f));
                _effects.ApplyHealing(effectContext, actor, flatAmount: healAmount);

                if (WorldboxReflectionAdapter.TryGetActorMana(actor, out int currentMana))
                {
                    int manaGain = Math.Max(1, (int)MathF.Round(Math.Max(1, currentMana) * 0.01f));
                    int nextMana = Math.Min(actor.getMaxMana(), currentMana + manaGain);
                    WorldboxReflectionAdapter.TrySetActorMana(actor, nextMana);
                }
            }
        );

        _triggers.RegisterActorAssetTrigger(
            "demon_nature_wrath#world_tree_tick",
            NatureWrathId,
            EraTriggerType.OnTick,
            EraTriggerSubject.Source,
            NatureWorldTreeAssetId,
            (context, tree) =>
            {
                if (!_natureWorldTrees.TryGetValue(tree.getID(), out NatureWorldTreeEntry? entry))
                {
                    return;
                }

                if (!tree.isAlive() || tree.current_tile == null)
                {
                    CleanupNatureWorldTree(tree.getID());
                    return;
                }

                if (context.WorldTime >= entry.ExpiresAtWorldTime)
                {
                    CleanupNatureWorldTree(tree.getID());
                    tree.changeHealth(-tree.getHealth());
                    return;
                }

                _terrain.UpsertPeriodicArea(
                    $"{NatureWorldTreeAuraKey}:{tree.getID()}",
                    tree,
                    tree,
                    tree.current_tile,
                    radius: 30f,
                    durationWorldTime: 2f,
                    tickIntervalWorldTime: 1f,
                    targetRule: EraEffectTargetRule.All,
                    onActorTick: (_, target) =>
                    {
                        if (target.getID() == tree.getID())
                        {
                            return;
                        }

                        if (tree.hasKingdom() && tree.isSameKingdom(target))
                        {
                            _statuses.ApplyTimedBuff(
                                target,
                                1.5f,
                                new Dictionary<string, float>
                                {
                                    [EraAttributeIds.MultiplierHealth] = 30f,
                                    [EraAttributeIds.MultiplierDamage] = 30f,
                                    [EraAttributeIds.MultiplierAttackSpeed] = 30f,
                                    [EraAttributeIds.MultiplierSpeed] = 30f,
                                    [EraAttributeIds.Armor] = 30f,
                                },
                                runtimeKey: $"ew_nature_s6_tree_friend:{target.getID()}"
                            );
                        }
                        else if (tree.areFoes(target))
                        {
                            _statuses.ApplyTimedDebuff(
                                target,
                                1.5f,
                                new Dictionary<string, float>
                                {
                                    [EraAttributeIds.MultiplierSpeed] = -50f,
                                    [EraAttributeIds.MultiplierDamage] = -20f,
                                },
                                runtimeKey: $"ew_nature_s6_tree_foe:{target.getID()}"
                            );
                        }
                    }
                );
            }
        );

        _triggers.RegisterActorAssetTrigger(
            "demon_nature_wrath#world_tree_cleanup",
            NatureWrathId,
            EraTriggerType.OnDeath,
            EraTriggerSubject.Target,
            NatureWorldTreeAssetId,
            (_, tree) => CleanupNatureWorldTree(tree.getID())
        );
    }

    private void RegisterNatureWrathSkills()
    {
        RegisterTickSkill(
            "demon_nature_wrath#s1",
            NatureWrathId,
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

                string areaKey = $"ew_nature_s1_root:{target.getID()}";
                _terrain.UpsertPeriodicArea(
                    areaKey,
                    actor,
                    target,
                    target.current_tile,
                    radius: 1f,
                    durationWorldTime: 4f,
                    tickIntervalWorldTime: 1f,
                    targetRule: EraEffectTargetRule.All,
                    onActorTick: (tickContext, victim) =>
                    {
                        if (victim.getID() != target.getID())
                        {
                            return;
                        }

                        _statuses.ApplyTimedDebuff(
                            victim,
                            1.5f,
                            new Dictionary<string, float>
                            {
                                [EraAttributeIds.MultiplierSpeed] = -99f,
                            },
                            runtimeKey: $"ew_nature_s1_root_debuff:{victim.getID()}"
                        );
                        _effects.ApplyCurrentHealthDamage(tickContext, victim, percent: 0.01f);
                    }
                );
            }
        );

        RegisterTickSkill(
            "demon_nature_wrath#s2",
            NatureWrathId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                _terrain.UpsertPeriodicArea(
                    $"ew_nature_s2_tide:{actor.getID()}",
                    actor,
                    actor,
                    actor.current_tile,
                    radius: 10f,
                    durationWorldTime: 5f,
                    tickIntervalWorldTime: 1f,
                    targetRule: EraEffectTargetRule.Foes,
                    onActorTick: (tickContext, target) =>
                    {
                        _statuses.ApplyTimedDebuff(
                            target,
                            1.5f,
                            new Dictionary<string, float>
                            {
                                [EraAttributeIds.MultiplierSpeed] = -50f,
                            },
                            runtimeKey: $"ew_nature_s2_slow:{target.getID()}"
                        );
                        _effects.ApplyKnockback(tickContext, target, forceMultiplier: 3f);
                    }
                );
            }
        );

        RegisterTickSkill(
            "demon_nature_wrath#s3",
            NatureWrathId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                if (actor.current_tile != null)
                {
                    _effects.SummonUnits(context, NatureDragonAssetId, actor.current_tile, count: 10, joinSourceKingdom: true);
                }
            }
        );

        RegisterTickSkill(
            "demon_nature_wrath#s4",
            NatureWrathId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                _effects.ApplyAreaHealing(context, actor.current_tile, radius: 12f, percentOfMaxHealth: 0.3f);
                _effects.ApplyAreaStatus(
                    context,
                    actor.current_tile,
                    radius: 12f,
                    application: new EraStatusApplication(
                        EraStatusKind.TimedBuff,
                        40f,
                        runtimeKey: "ew_nature_s4_bless",
                        statModifiers: new Dictionary<string, float>
                        {
                            [EraAttributeIds.MultiplierAttackSpeed] = 30f,
                            [EraAttributeIds.MultiplierSpeed] = 30f,
                            [EraAttributeIds.MultiplierDamage] = 30f,
                            [EraAttributeIds.Armor] = 30f,
                        }
                    ),
                    targetRule: EraEffectTargetRule.Friends
                );
            }
        );

        RegisterTickSkill(
            "demon_nature_wrath#s5",
            NatureWrathId,
            chancePercent: 20f,
            cooldownWorldTime: EraWorldTime.YearsToWorldTime(1f),
            manaCost: 10,
            handler: (context, actor) =>
            {
                if (actor.current_tile == null)
                {
                    return;
                }

                _terrain.CreateBarrierArea(
                    $"ew_nature_s5_barrier:{actor.getID()}",
                    actor,
                    actor,
                    actor.current_tile,
                    radius: 10f,
                    durationWorldTime: 10f,
                    tickIntervalWorldTime: 1f,
                    forceAmount: 8f
                );
                _terrain.ApplyForestTerrain(
                    actor.current_tile,
                    radius: 10f,
                    durationWorldTime: 10f,
                    runtimeKey: $"ew_nature_s5_forest:{actor.getID()}"
                );
            }
        );

        RegisterTickSkill(
            "demon_nature_wrath#s6",
            NatureWrathId,
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

                _terrain.ApplyForestTerrain(
                    actor.current_tile,
                    radius: 20f,
                    durationWorldTime: 60f,
                    runtimeKey: $"ew_nature_s6_worldtree_forest:{actor.getID()}"
                );

                IReadOnlyList<Actor> trees = _effects.SummonUnits(
                    context,
                    NatureWorldTreeAssetId,
                    actor.current_tile,
                    count: 1,
                    joinSourceKingdom: true
                );
                foreach (Actor tree in trees)
                {
                    _statuses.ApplyTimedBuff(
                        tree,
                        60f,
                        new Dictionary<string, float>
                        {
                            [EraAttributeIds.Health] = 100000f,
                            [EraAttributeIds.Armor] = 200f,
                            [EraAttributeIds.MultiplierSpeed] = -100f,
                        },
                        runtimeKey: $"ew_nature_s6_tree_stats:{tree.getID()}"
                    );
                    tree.changeHealth(100000);
                    _natureWorldTrees[tree.getID()] = new NatureWorldTreeEntry
                    {
                        CasterId = actor.getID(),
                        CasterBuffRuntimeKey = $"{NatureWorldTreeCasterBuffKey}:{actor.getID()}",
                        ExpiresAtWorldTime = context.WorldTime + 60f,
                    };
                }

                _statuses.ApplyTimedBuff(
                    actor,
                    60f,
                    new Dictionary<string, float>
                    {
                        [EraAttributeIds.MultiplierHealth] = 100f,
                        [EraAttributeIds.MultiplierDamage] = 100f,
                        [EraAttributeIds.MultiplierAttackSpeed] = 100f,
                        [EraAttributeIds.MultiplierSpeed] = 100f,
                        [EraAttributeIds.Armor] = 100f,
                    },
                    runtimeKey: $"{NatureWorldTreeCasterBuffKey}:{actor.getID()}"
                );
            }
        );
    }

    private void CleanupNatureWorldTree(long treeId)
    {
        if (!_natureWorldTrees.TryGetValue(treeId, out NatureWorldTreeEntry? entry))
        {
            return;
        }

        _natureWorldTrees.Remove(treeId);
        Actor? caster = ResolveActor(entry.CasterId);
        if (caster != null)
        {
            _statuses.Remove(caster, entry.CasterBuffRuntimeKey);
        }
    }

    private static bool IsNatureAlignedTile(WorldTile tile)
    {
        if (tile == null)
        {
            return false;
        }

        return tile.top_type == TopTileLibrary.grass_high
               || tile.top_type == TopTileLibrary.grass_low
               || tile.top_type == TopTileLibrary.swamp_high
               || tile.top_type == TopTileLibrary.swamp_low
               || tile.top_type == TopTileLibrary.birch_high;
    }

    private void EnsureNatureWorldTreeAssetRegistered()
    {
        if (AssetManager.actor_library.has(NatureWorldTreeAssetId))
        {
            return;
        }

        ActorAsset? template = AssetManager.actor_library.get(EraWorldboxAssetIds.MobNoGenesTemplate);
        if (template == null)
        {
            EraLog.Warning(EraLogCategory.Combat, "无法注册世界树实体：缺少基础模板。");
            return;
        }

        AssetManager.actor_library.clone(out ActorAsset cloned, template);
        cloned.id = NatureWorldTreeAssetId;
        cloned.name_locale = NatureWorldTreeAssetId;
        cloned.icon = NatureWorldTreeIconPath;
        cloned.shadow = false;
        if (cloned.texture_asset != null)
        {
            cloned.texture_asset.shadow = false;
        }
        cloned.kingdom_id_wild = string.Empty;
        cloned.can_be_favorited = false;
        cloned.hide_favorite_icon = true;
        cloned.can_edit_equipment = false;
        cloned.can_edit_traits = false;
        cloned.can_receive_traits = false;
        cloned.use_items = false;
        cloned.take_items = false;
        cloned.force_hide_mana = true;
        cloned.skip_fight_logic = true;
        cloned.special = true;
        cloned.unit_other = true;
        cloned.skip_save = true;

        if (!EnsureRuntimeTemplateTextures(
                cloned,
                template,
                NatureWorldTreeAssetId,
                "自然之怒世界树",
                Array.Empty<EraSpriteResource>(),
                NatureWorldTreeIconPath
            ))
        {
            return;
        }

        ActorAsset asset = AssetManager.actor_library.add(cloned);
        RegisterRuntimeActorLocale(
            asset,
            NatureWorldTreeAssetId,
            "巨型古树",
            "Ancient Tree Core",
            "自然之怒·世界树降临生成的巨型古树核心。",
            "The ancient tree core created by Nature's Wrath: World Tree Descent."
        );
        if (LocalizedTextManager.instance != null)
        {
            LM.ApplyLocale(false);
        }
    }

}
