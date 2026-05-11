using System;
using System.Collections.Generic;
using EraWheel.Data.Definitions;

namespace EraWheel.Data.Manifests;

public static class EraHeritageTraitManifestData
{
    private static readonly EraHeritageRandomAttributeProfile SharedRandomAttributes = new(
        "advancement.shared_default",
        6,
        true,
        "共享候选池；随机 6 条；单次不重复。"
    );

    public static IReadOnlyList<EraHeritageTraitManifest> All { get; } = new[]
    {
        Trait(
            "trait_herit_t1_frost_impact",
            "冰霜天降",
            1,
            Active(15f),
            Target(EraHeritageTargetKind.TargetPointEnemies, "目标点敌军", primaryRadius: 2.5f),
            "在目标点落下冰锥特效，造成 damage×150%。",
            Impl(EraHeritageImplementationKind.Custom, "新增目标点冰锥坠落效果，对命中敌军结算伤害。"),
            Grant(2, 12, 1),
            "Assets/Art/轮回阶位特质图标/冰霜天降.png",
            Fixed("damage_multiplier", "伤害倍率", 1.5f, EraHeritageParameterUnit.Multiplier),
            Fixed("impact_radius", "命中半径", 2.5f, EraHeritageParameterUnit.Tiles)
        ),
        Trait(
            "trait_herit_t1_sacred_heal",
            "神的乐曲",
            1,
            Active(30f),
            Target(EraHeritageTargetKind.RadiusFriends, "半径友军（含自身）", primaryRadius: 6f, includesSelf: true),
            "恢复半径 6 内友军 20% 当前生命。",
            Impl(EraHeritageImplementationKind.Composite, "逐个复用 cast_cure，再按技能描述调整治疗量。", "cast_cure"),
            Grant(2, 12, 1),
            "Assets/Art/轮回阶位特质图标/神的乐曲.png",
            Fixed("radius", "治疗半径", 6f, EraHeritageParameterUnit.Tiles),
            Fixed("heal_current_health_percent", "当前生命治疗比例", 20f, EraHeritageParameterUnit.Percent)
        ),
        Trait(
            "trait_herit_t1_wind_blade",
            "风刃冲击",
            1,
            Active(15f),
            Target(EraHeritageTargetKind.LineEnemies, "直线敌军", pathLength: 6f),
            "发射穿透风刃特效，对直线路径 6 格敌军造成 damage×120%。",
            Impl(EraHeritageImplementationKind.Custom, "新增直线路径穿透风刃，对沿线敌军结算伤害。"),
            Grant(2, 9, 1),
            "Assets/Art/轮回阶位特质图标/风刃冲击.png",
            Fixed("path_length", "穿透长度", 6f, EraHeritageParameterUnit.Tiles),
            Fixed("damage_multiplier", "伤害倍率", 1.2f, EraHeritageParameterUnit.Multiplier)
        ),
        Trait(
            "trait_herit_t2_sword_array",
            "天穹剑阵",
            2,
            Active(15f),
            Target(EraHeritageTargetKind.TargetPointEnemies, "目标点附近敌军", primaryRadius: 4f, maxTargets: 3),
            "在目标周围召唤 3 把飞剑特效，每把造成 damage×80%。",
            Impl(EraHeritageImplementationKind.Custom, "新增目标点飞剑阵效果，对周围敌军分别结算飞剑伤害。"),
            Grant(2, 9, 1),
            "Assets/Art/轮回阶位特质图标/天穹剑阵.png",
            Fixed("projectile_count", "飞剑数量", 3f, EraHeritageParameterUnit.Count),
            Fixed("damage_multiplier", "单把飞剑伤害倍率", 0.8f, EraHeritageParameterUnit.Multiplier)
        ),
        Trait(
            "trait_herit_t2_polymorph_sheep",
            "变羊术",
            2,
            Active(15f),
            Target(EraHeritageTargetKind.TargetEnemy, "目标敌军"),
            "将目标变成羊 5 秒，所有属性不变只改变外观，期间伤害 -20% 且无法释放主动技能。",
            Impl(EraHeritageImplementationKind.Custom, "新增单体变形状态，只改外观并限制伤害与主动技能。"),
            Grant(2, 9, 1),
            "Assets/Art/轮回阶位特质图标/变羊术.png",
            Fixed("duration_seconds", "变羊持续时间", 5f, EraHeritageParameterUnit.Seconds),
            Fixed("damage_penalty_percent", "伤害降低", 20f, EraHeritageParameterUnit.Percent)
        ),
        Trait(
            "trait_herit_t2_rock_armor",
            "岩石护甲",
            2,
            Active(15f),
            Target(EraHeritageTargetKind.SelfAndRadiusEnemies, "自身 + 半径敌军", primaryRadius: 5f, includesSelf: true),
            "获得岩甲护盾，护盾值=最大生命×30%；破碎后对半径 5 内敌军造成 damage×100%。",
            Impl(EraHeritageImplementationKind.ReuseAndAdjust, "复用 cast_shield 生成岩甲护盾，并在破碎时追加范围伤害。", "cast_shield"),
            Grant(2, 9, 1),
            "Assets/Art/轮回阶位特质图标/岩石护甲.png",
            Fixed("shield_max_health_percent", "护盾值", 30f, EraHeritageParameterUnit.Percent),
            Fixed("burst_radius", "破碎半径", 5f, EraHeritageParameterUnit.Tiles),
            Fixed("burst_damage_multiplier", "破碎伤害倍率", 1f, EraHeritageParameterUnit.Multiplier)
        ),
        Trait(
            "trait_herit_t3_mirror_clone",
            "镜像克隆",
            3,
            Active(15f),
            Target(EraHeritageTargetKind.SummonedAllies, "召唤单位（友军）", maxTargets: 1),
            "召唤 1 个镜像分身，继承本体 50% 生命和伤害，只会普攻，20 秒后消失。",
            Impl(EraHeritageImplementationKind.Custom, "以自身为模板复制一个镜像分身，再覆盖生命、伤害、行为和持续时间。"),
            Grant(1, 7, 1),
            "Assets/Art/轮回阶位特质图标/镜像克隆.png",
            Fixed("summon_count", "镜像数量", 1f, EraHeritageParameterUnit.Count),
            Fixed("inherit_health_percent", "生命继承比例", 50f, EraHeritageParameterUnit.Percent),
            Fixed("inherit_damage_percent", "伤害继承比例", 50f, EraHeritageParameterUnit.Percent),
            Fixed("duration_seconds", "持续时间", 20f, EraHeritageParameterUnit.Seconds)
        ),
        Trait(
            "trait_herit_t3_sky_thunder",
            "隆隆天雷",
            3,
            Active(15f),
            Target(EraHeritageTargetKind.TargetEnemy, "目标敌军"),
            "降下一次天雷，造成 damage×200%。",
            Impl(EraHeritageImplementationKind.ReuseAndAdjust, "复用 summon_lightning，把伤害倍率改成技能描述。", "summon_lightning"),
            Grant(2, 10, 1),
            "Assets/Art/轮回阶位特质图标/隆隆天雷.png",
            Fixed("damage_multiplier", "伤害倍率", 2f, EraHeritageParameterUnit.Multiplier)
        ),
        Trait(
            "trait_herit_t3_sandstorm",
            "沙暴王国",
            3,
            Active(15f),
            Target(EraHeritageTargetKind.RadiusEnemies, "沙尘区敌军", primaryRadius: 6f),
            "生成半径 6 沙尘区特效持续 10 秒，范围内敌军精准 -15%~30%，每两秒损失 1% 当前生命。",
            Impl(EraHeritageImplementationKind.Custom, "新增范围沙尘区域，持续削弱精准并按周期结算当前生命伤害。"),
            Grant(2, 7, 1),
            "Assets/Art/轮回阶位特质图标/沙暴王国.png",
            Fixed("radius", "沙尘半径", 6f, EraHeritageParameterUnit.Tiles),
            Fixed("duration_seconds", "持续时间", 10f, EraHeritageParameterUnit.Seconds),
            Range("accuracy_penalty_percent", "精准削弱", 15f, 30f, EraHeritageParameterUnit.Percent),
            Fixed("tick_current_health_percent", "周期当前生命伤害", 1f, EraHeritageParameterUnit.Percent)
        ),
        Trait(
            "trait_herit_t4_chain_lightning",
            "调皮闪电",
            4,
            Active(15f),
            Target(EraHeritageTargetKind.TargetEnemyAndNearbyEnemies, "主目标敌军 + 弹射敌军", primaryRadius: 5f, maxTargets: 4),
            "主目标承受 damage×180%，再向 5 格内最多 3 名敌军弹射，每跳伤害衰减 20%。",
            Impl(EraHeritageImplementationKind.Custom, "新增连锁闪电逻辑，对主目标和弹射目标分别结算递减伤害。"),
            Grant(2, 9, 1),
            "Assets/Art/轮回阶位特质图标/调皮闪电.png",
            Fixed("primary_damage_multiplier", "主目标伤害倍率", 1.8f, EraHeritageParameterUnit.Multiplier),
            Fixed("bounce_radius", "弹射半径", 5f, EraHeritageParameterUnit.Tiles),
            Fixed("max_bounces", "最大弹射数", 3f, EraHeritageParameterUnit.Count),
            Fixed("bounce_decay_percent", "每跳衰减", 20f, EraHeritageParameterUnit.Percent)
        ),
        Trait(
            "trait_herit_t4_twin_gate",
            "传送门",
            4,
            Active(15f),
            Target(EraHeritageTargetKind.AllCreatures, "所有生物", primaryRadius: 20f),
            "在当前位置与半径 20 范围外生成 A、B 白色漩涡特效，打开 A、B 双门持续 1 年，所有生物进入 A、B 门会从 B、A 门出现。",
            Impl(EraHeritageImplementationKind.ReuseAndAdjust, "复用 teleport 作为双门传送入口，再补双向门的持续存在逻辑。", "teleport"),
            Grant(1, 7, 1),
            "Assets/Art/轮回阶位特质图标/传送门.png",
            Fixed("min_gate_distance", "双门最小距离", 20f, EraHeritageParameterUnit.Tiles),
            Fixed("duration_years", "双门持续时间", 1f, EraHeritageParameterUnit.Years)
        ),
        Trait(
            "trait_herit_t4_blood_hook",
            "血肉钩锁",
            4,
            Active(15f),
            Target(EraHeritageTargetKind.TargetEnemy, "目标敌军"),
            "生成红色线条特效钩锁，命中后将目标强拉到面前，造成 damage×160%。",
            Impl(EraHeritageImplementationKind.Composite, "先复用 teleport 把目标拉到施法者面前，再按技能描述结算伤害。", "teleport"),
            Grant(2, 7, 1),
            "Assets/Art/轮回阶位特质图标/血肉钩锁.png",
            Fixed("damage_multiplier", "伤害倍率", 1.6f, EraHeritageParameterUnit.Multiplier)
        ),
        Trait(
            "trait_herit_t5_meteor_fall",
            "陨石天降",
            5,
            Active(15f),
            Target(EraHeritageTargetKind.TargetPointEnemies, "目标点半径敌军", primaryRadius: 8f),
            "在目标处召唤一颗陨石，陨石范围为半径 8，范围内敌军承受 damage×220%。",
            Impl(EraHeritageImplementationKind.ReuseAndAdjust, "复用 summon_meteor_rain，把陨石数量改成单颗并按描述调整范围。", "summon_meteor_rain"),
            Grant(1, 7, 1),
            "Assets/Art/轮回阶位特质图标/陨石天降.png",
            Fixed("meteor_count", "陨石数量", 1f, EraHeritageParameterUnit.Count),
            Fixed("radius", "陨石半径", 8f, EraHeritageParameterUnit.Tiles),
            Fixed("damage_multiplier", "伤害倍率", 2.2f, EraHeritageParameterUnit.Multiplier)
        ),
        Trait(
            "trait_herit_t5_quake_rift",
            "大地的愤怒",
            5,
            Active(15f),
            Target(EraHeritageTargetKind.RadiusEnemies, "半径敌军", primaryRadius: 6f),
            "以目标为中心触发地裂震波，地裂范围为半径 6，范围内敌人损失 6% 当前生命并短眩晕。",
            Impl(EraHeritageImplementationKind.ReuseAndAdjust, "复用 summon_earthquake 作为地裂入口，再补当前生命百分比伤害和短眩晕。", "summon_earthquake"),
            Grant(1, 9, 1),
            "Assets/Art/轮回阶位特质图标/大地的愤怒.png",
            Fixed("radius", "地裂半径", 6f, EraHeritageParameterUnit.Tiles),
            Fixed("current_health_damage_percent", "当前生命伤害", 6f, EraHeritageParameterUnit.Percent),
            Fixed("stun_seconds", "眩晕时间", 1.5f, EraHeritageParameterUnit.Seconds)
        ),
        Trait(
            "trait_herit_t5_thorn_counter",
            "感同身受",
            5,
            Active(15f),
            Target(EraHeritageTargetKind.SelfAndAttacker, "自身 + 攻击者（敌军）", includesSelf: true),
            "获得 10 秒反伤状态，期间把本次直伤的 50% 反弹给攻击者。",
            Impl(EraHeritageImplementationKind.Custom, "新增短时反伤状态，把受到的直伤按比例反弹给攻击者。"),
            Grant(1, 8, 1),
            "Assets/Art/轮回阶位特质图标/感同身受.png",
            Fixed("duration_seconds", "反伤持续时间", 10f, EraHeritageParameterUnit.Seconds),
            Fixed("reflect_percent", "反伤比例", 50f, EraHeritageParameterUnit.Percent)
        ),
        Trait(
            "trait_herit_t6_rage_giant",
            "狂暴巨大",
            6,
            Active(15f),
            Target(EraHeritageTargetKind.Self, "自身", includesSelf: true),
            "进入 15 秒巨大化状态：体型变为 3 倍，伤害 +100%，攻速 -40%，并获得击退抗性。",
            Impl(EraHeritageImplementationKind.Custom, "新增巨大化状态，统一改写体型、质量、伤害、攻速和击退抗性。"),
            Grant(1, 7, 1),
            "Assets/Art/轮回阶位特质图标/狂暴巨大.png",
            Fixed("duration_seconds", "巨大化持续时间", 15f, EraHeritageParameterUnit.Seconds),
            Fixed("scale_multiplier", "体型倍率", 3f, EraHeritageParameterUnit.Multiplier),
            Fixed("damage_bonus_percent", "伤害提升", 100f, EraHeritageParameterUnit.Percent),
            Fixed("attack_speed_penalty_percent", "攻速降低", 40f, EraHeritageParameterUnit.Percent)
        ),
        Trait(
            "trait_herit_t6_dragon_breath",
            "龙息术",
            6,
            Active(15f),
            Target(EraHeritageTargetKind.PathEnemies, "前方扇形敌军 + 地面", primaryRadius: 5f),
            "生成喷火特效，向前方喷出半径 5 的锥形火焰，持续 1 秒；持续命中的敌军承受 damage×90%，地面被点燃。",
            Impl(EraHeritageImplementationKind.Custom, "新增前方扇形喷火区域，持续结算伤害并点燃地面。"),
            Grant(1, 7, 1),
            "Assets/Art/轮回阶位特质图标/龙息术.png",
            Fixed("cone_radius", "喷火半径", 5f, EraHeritageParameterUnit.Tiles),
            Fixed("duration_seconds", "喷火持续时间", 1f, EraHeritageParameterUnit.Seconds),
            Fixed("damage_multiplier", "持续命中伤害倍率", 0.9f, EraHeritageParameterUnit.Multiplier)
        ),
        Trait(
            "trait_herit_t6_lava_river",
            "岩浆裂隙",
            6,
            Active(15f),
            Target(EraHeritageTargetKind.Terrain, "地形"),
            "沿前方撕裂 10 格为熔岩河，持续 15 秒后恢复原本地形。",
            Impl(EraHeritageImplementationKind.ReuseAndAdjust, "复用原版熔岩地块逻辑，把前方路径改成临时熔岩河并到期恢复。"),
            Grant(1, 7, 1),
            "Assets/Art/轮回阶位特质图标/岩浆裂隙.png",
            Fixed("river_length", "裂隙长度", 10f, EraHeritageParameterUnit.Tiles),
            Fixed("duration_seconds", "持续时间", 15f, EraHeritageParameterUnit.Seconds)
        ),
        Trait(
            "trait_herit_t7_frost_tempest",
            "寒冰风暴",
            7,
            Active(15f),
            Target(EraHeritageTargetKind.RadiusEnemies, "龙卷命中敌军", primaryRadius: 5f),
            "召唤蓝白色龙卷持续 15 秒，命中敌军造成 damage×180% 并移速 -30% 1 年。",
            Impl(EraHeritageImplementationKind.ReuseAndAdjust, "复用 summon_tornado 作为入口，再生成自定义寒冰龙卷外观并追加减速。", "summon_tornado"),
            Grant(1, 8, 1),
            "Assets/Art/轮回阶位特质图标/寒冰风暴.png",
            Fixed("duration_seconds", "龙卷持续时间", 15f, EraHeritageParameterUnit.Seconds),
            Fixed("damage_multiplier", "伤害倍率", 1.8f, EraHeritageParameterUnit.Multiplier),
            Fixed("slow_percent", "移速降低", 30f, EraHeritageParameterUnit.Percent),
            Fixed("slow_duration_years", "减速持续时间", 1f, EraHeritageParameterUnit.Years)
        ),
        Trait(
            "trait_herit_t7_phoenix_strike",
            "凤凰冲击",
            7,
            Active(15f),
            Target(EraHeritageTargetKind.TargetPointEnemies, "半径敌军 + 地面", primaryRadius: 10f),
            "生成火凤凰俯冲落地特效，落点范围为半径 10，范围内敌军承受 damage×240%，并留下燃烧区域。",
            Impl(EraHeritageImplementationKind.Composite, "先新增火凤凰俯冲落地效果，再复用 cast_fire 留下燃烧区域。", "cast_fire"),
            Grant(1, 7, 1),
            "Assets/Art/轮回阶位特质图标/凤凰冲击.png",
            Fixed("impact_radius", "落点半径", 10f, EraHeritageParameterUnit.Tiles),
            Fixed("damage_multiplier", "伤害倍率", 2.4f, EraHeritageParameterUnit.Multiplier)
        ),
        Trait(
            "trait_herit_t7_shadow_execute",
            "瞬狱影杀",
            7,
            Active(15f),
            Target(EraHeritageTargetKind.TargetEnemy, "目标敌军"),
            "瞬移到半径 5 内目标背后，触发一次必暴背刺，造成 damage×300%。",
            Impl(EraHeritageImplementationKind.ReuseAndAdjust, "复用 teleport 绕到目标背后，再追加必暴背刺伤害。", "teleport"),
            Grant(1, 7, 1),
            "Assets/Art/轮回阶位特质图标/瞬狱影杀.png",
            Fixed("target_range", "目标搜索半径", 5f, EraHeritageParameterUnit.Tiles),
            Fixed("damage_multiplier", "背刺伤害倍率", 3f, EraHeritageParameterUnit.Multiplier)
        ),
        Trait(
            "trait_herit_t8_gravity_well",
            "引力黑洞",
            8,
            Active(15f),
            Target(EraHeritageTargetKind.RadiusEnemies, "黑洞半径敌军", primaryRadius: 5f),
            "生成持续 20 秒的黑洞特效，黑洞范围为半径 5，范围内敌军移速 -80%，每 4 秒周期范围内造成 damage×30%。",
            Impl(EraHeritageImplementationKind.Custom, "新增黑洞区域效果，持续压低移速并按周期结算范围伤害。"),
            Grant(1, 7, 1),
            "Assets/Art/轮回阶位特质图标/引力黑洞.png",
            Fixed("duration_seconds", "黑洞持续时间", 20f, EraHeritageParameterUnit.Seconds),
            Fixed("radius", "黑洞半径", 5f, EraHeritageParameterUnit.Tiles),
            Fixed("slow_percent", "移速降低", 80f, EraHeritageParameterUnit.Percent),
            Fixed("tick_damage_multiplier", "周期伤害倍率", 0.3f, EraHeritageParameterUnit.Multiplier),
            Fixed("tick_interval_seconds", "伤害周期", 4f, EraHeritageParameterUnit.Seconds)
        ),
        Trait(
            "trait_herit_t8_absolute_zero",
            "绝对零度",
            8,
            Active(15f),
            Target(EraHeritageTargetKind.SelfAndRadiusEnemies, "半径地形 + 冰面上的敌军", primaryRadius: 10f, includesSelf: true),
            "以自身为中心半径 10 的地形改为冰块，持续 10 秒，到期恢复地形；踩在冰面上的敌军攻速 -80%，并承受 damage×160%。",
            Impl(EraHeritageImplementationKind.ReuseAndAdjust, "复用冻土地形逻辑，把范围改成自身周围半径 10，并补到期恢复。"),
            Grant(1, 8, 1),
            "Assets/Art/轮回阶位特质图标/绝对零度.png",
            Fixed("radius", "冻结半径", 10f, EraHeritageParameterUnit.Tiles),
            Fixed("duration_seconds", "冰面持续时间", 10f, EraHeritageParameterUnit.Seconds),
            Fixed("attack_speed_penalty_percent", "攻速降低", 80f, EraHeritageParameterUnit.Percent),
            Fixed("damage_multiplier", "踩冰伤害倍率", 1.6f, EraHeritageParameterUnit.Multiplier)
        ),
        Trait(
            "trait_herit_t8_rock_golem",
            "岩石傀儡",
            8,
            Active(15f),
            Target(EraHeritageTargetKind.SummonedAllies, "召唤单位（友军）", maxTargets: 1),
            "召唤岩石傀儡生物，继承施法者 50% 生命与伤害，持续 30 秒。",
            Impl(EraHeritageImplementationKind.ReuseAndAdjust, "复用 spawn_skeleton 作为召唤入口，再生成自定义岩石傀儡单位。", "spawn_skeleton"),
            Grant(1, 8, 1),
            "Assets/Art/轮回阶位特质图标/岩石傀儡.png",
            Fixed("summon_count", "召唤数量", 1f, EraHeritageParameterUnit.Count),
            Fixed("inherit_health_percent", "生命继承比例", 50f, EraHeritageParameterUnit.Percent),
            Fixed("inherit_damage_percent", "伤害继承比例", 50f, EraHeritageParameterUnit.Percent),
            Fixed("duration_seconds", "持续时间", 30f, EraHeritageParameterUnit.Seconds)
        ),
        Trait(
            "trait_herit_t9_holy_judgement",
            "圣光制裁",
            9,
            Active(15f),
            Target(EraHeritageTargetKind.RadiusEnemies, "光柱区域敌军（魔王势力额外）", primaryRadius: 7f),
            "降下持续 10 秒白色光柱特效，区域内造成 damage×120%；对魔王势力按 300% 暴击伤害结算；魔王势力单位不能获得。",
            Impl(EraHeritageImplementationKind.Custom, "新增持续光柱区域，对范围敌军结算伤害，并对魔王势力单独提高倍率。"),
            Grant(1, 7, 1),
            "Assets/Art/轮回阶位特质图标/圣光制裁.png",
            new[]
            {
                Fixed("duration_seconds", "光柱持续时间", 10f, EraHeritageParameterUnit.Seconds),
                Fixed("radius", "光柱半径", 7f, EraHeritageParameterUnit.Tiles),
                Fixed("default_damage_multiplier", "默认伤害倍率", 1.2f, EraHeritageParameterUnit.Multiplier),
                Fixed("demon_damage_multiplier", "魔王势力伤害倍率", 3f, EraHeritageParameterUnit.Multiplier),
            },
            Restrictions(
                Restrict("blocks_demon_faction_grant", "魔王势力单位不能获得。")
            )
        ),
        Trait(
            "trait_herit_t9_eye_of_storm",
            "风暴天眼",
            9,
            Active(15f),
            Target(EraHeritageTargetKind.RadiusEnemies, "天眼范围敌军", primaryRadius: 15f),
            "生成半径 15 的风暴天眼特效持续 10 年：每 5 秒自动触发龙卷风和闪电，范围敌军移速 -35%。",
            Impl(EraHeritageImplementationKind.Composite, "新增长期风暴区域，定时复用龙卷和落雷效果，并持续削弱范围敌军移速。"),
            Grant(1, 8, 1),
            "Assets/Art/轮回阶位特质图标/风暴天眼.png",
            Fixed("radius", "天眼半径", 15f, EraHeritageParameterUnit.Tiles),
            Fixed("duration_years", "持续时间", 10f, EraHeritageParameterUnit.Years),
            Fixed("pulse_interval_seconds", "脉冲周期", 5f, EraHeritageParameterUnit.Seconds),
            Fixed("slow_percent", "移速降低", 35f, EraHeritageParameterUnit.Percent)
        ),
        Trait(
            "trait_herit_t9_frostfire_nova",
            "冰焰新星",
            9,
            Active(15f),
            Target(EraHeritageTargetKind.RadiusEnemies, "双环范围敌军", primaryRadius: 6f, secondaryRadius: 12f),
            "释放双环新星：半径 6 范围敌军移速 -50%、攻速 -50%，半径 7~12 范围附加火焰效果，持续 15 秒。",
            Impl(EraHeritageImplementationKind.Composite, "先对内环敌军施加移速和攻速削弱，再复用 cast_fire 点燃外环范围。", "cast_fire"),
            Grant(1, 7, 1),
            "Assets/Art/轮回阶位特质图标/冰焰新星.png",
            Fixed("inner_radius", "内环半径", 6f, EraHeritageParameterUnit.Tiles),
            Fixed("outer_radius", "外环半径", 12f, EraHeritageParameterUnit.Tiles),
            Fixed("slow_percent", "移速降低", 50f, EraHeritageParameterUnit.Percent),
            Fixed("attack_speed_penalty_percent", "攻速降低", 50f, EraHeritageParameterUnit.Percent),
            Fixed("duration_seconds", "持续时间", 15f, EraHeritageParameterUnit.Seconds)
        ),
        Trait(
            "trait_herit_t10_meteor_barrage",
            "星陨连爆",
            10,
            Active(20f),
            Target(EraHeritageTargetKind.TargetPointEnemies, "目标区敌军", primaryRadius: 12f),
            "在目标处召唤 3 颗陨石，每颗陨石范围为半径 12。",
            Impl(EraHeritageImplementationKind.ReuseAndAdjust, "复用 summon_meteor_rain，把陨石数量改成 3 颗并按技能描述调整范围。", "summon_meteor_rain"),
            Grant(1, 7, 1),
            "Assets/Art/轮回阶位特质图标/星陨连爆.png",
            Fixed("meteor_count", "陨石数量", 3f, EraHeritageParameterUnit.Count),
            Fixed("radius", "单颗陨石半径", 12f, EraHeritageParameterUnit.Tiles)
        ),
        Trait(
            "trait_herit_t10_void_tide",
            "虚空潮汐",
            10,
            Active(15f),
            Target(EraHeritageTargetKind.RadiusEnemies, "半径敌军", primaryRadius: 15f),
            "使半径 15 内敌军损失 10% 当前生命（最低保留 1HP）并击退。",
            Impl(EraHeritageImplementationKind.Custom, "新增范围冲击效果，对敌军结算当前生命百分比伤害并击退。"),
            Grant(1, 9, 1),
            "Assets/Art/轮回阶位特质图标/虚空潮汐.png",
            Fixed("radius", "冲击半径", 15f, EraHeritageParameterUnit.Tiles),
            Fixed("current_health_damage_percent", "当前生命伤害", 10f, EraHeritageParameterUnit.Percent),
            Fixed("minimum_remaining_health", "最低保留生命", 1f, EraHeritageParameterUnit.HitPoints)
        ),
        Trait(
            "trait_herit_t10_doom_prism",
            "末日水晶",
            10,
            Active(15f),
            Target(EraHeritageTargetKind.RadiusEnemies, "棱镜范围敌军", primaryRadius: 15f),
            "生成旋转水晶特效 15 秒，每 5 秒向半径 15 内敌军随机发射 6 束光线，每束造成 damage×200%；到期时对半径 15 内敌军造成 damage×100%。",
            Impl(EraHeritageImplementationKind.Custom, "新增持续水晶区域，定时随机发射光线，并在结束时结算一次范围爆发伤害。"),
            Grant(1, 7, 1),
            "Assets/Art/轮回阶位特质图标/末日水晶.png",
            Fixed("radius", "棱镜半径", 15f, EraHeritageParameterUnit.Tiles),
            Fixed("duration_seconds", "棱镜持续时间", 15f, EraHeritageParameterUnit.Seconds),
            Fixed("pulse_interval_seconds", "发射周期", 5f, EraHeritageParameterUnit.Seconds),
            Fixed("beam_count", "单轮光线数量", 6f, EraHeritageParameterUnit.Count),
            Fixed("beam_damage_multiplier", "光线伤害倍率", 2f, EraHeritageParameterUnit.Multiplier),
            Fixed("final_burst_damage_multiplier", "终结爆发倍率", 1f, EraHeritageParameterUnit.Multiplier)
        ),
    };

    private static EraHeritageTraitManifest Trait(
        string traitId,
        string displayName,
        int unlockTier,
        EraHeritageTriggerProfile trigger,
        EraHeritageTargetingProfile targeting,
        string summary,
        EraHeritageImplementationProfile implementation,
        EraTraitGrantProfile granting,
        string iconSourcePath,
        params EraHeritageEffectParameter[] effectParameters
    )
    {
        return Trait(
            traitId,
            displayName,
            unlockTier,
            trigger,
            targeting,
            summary,
            implementation,
            granting,
            iconSourcePath,
            effectParameters,
            Array.Empty<EraHeritageRestriction>()
        );
    }

    private static EraHeritageTraitManifest Trait(
        string traitId,
        string displayName,
        int unlockTier,
        EraHeritageTriggerProfile trigger,
        EraHeritageTargetingProfile targeting,
        string summary,
        EraHeritageImplementationProfile implementation,
        EraTraitGrantProfile granting,
        string iconSourcePath,
        IReadOnlyList<EraHeritageEffectParameter> effectParameters,
        IReadOnlyList<EraHeritageRestriction> restrictions
    )
    {
        return new EraHeritageTraitManifest(
            traitId,
            displayName,
            unlockTier,
            trigger,
            targeting,
            summary,
            implementation,
            granting,
            effectParameters,
            SharedRandomAttributes,
            restrictions,
            iconSourcePath
        );
    }

    private static EraHeritageTriggerProfile Active(float chancePercent)
    {
        return new EraHeritageTriggerProfile(new[] { EraHeritageTriggerKind.Active }, chancePercent);
    }

    private static EraHeritageTargetingProfile Target(
        EraHeritageTargetKind kind,
        string displayText,
        float searchRadius = 0f,
        float primaryRadius = 0f,
        float secondaryRadius = 0f,
        float pathLength = 0f,
        int maxTargets = 0,
        bool includesSelf = false
    )
    {
        return new EraHeritageTargetingProfile(
            kind,
            displayText,
            searchRadius,
            primaryRadius,
            secondaryRadius,
            pathLength,
            maxTargets,
            includesSelf
        );
    }

    private static EraHeritageImplementationProfile Impl(
        EraHeritageImplementationKind kind,
        string summary,
        string reuseAssetId = ""
    )
    {
        return new EraHeritageImplementationProfile(kind, summary, reuseAssetId);
    }

    private static EraTraitGrantProfile Grant(int birthWeight, int inheritWeight, int growthWeight)
    {
        return new EraTraitGrantProfile(
            birthWeight,
            inheritWeight,
            growthWeight,
            allowsMutationBox: true,
            allowsManualGrant: true
        );
    }

    private static EraHeritageEffectParameter Fixed(
        string key,
        string displayName,
        float value,
        EraHeritageParameterUnit unit
    )
    {
        return new EraHeritageEffectParameter(key, displayName, value, value, unit);
    }

    private static EraHeritageEffectParameter Range(
        string key,
        string displayName,
        float minValue,
        float maxValue,
        EraHeritageParameterUnit unit
    )
    {
        return new EraHeritageEffectParameter(key, displayName, minValue, maxValue, unit);
    }

    private static IReadOnlyList<EraHeritageRestriction> Restrictions(params EraHeritageRestriction[] restrictions)
    {
        return restrictions;
    }

    private static EraHeritageRestriction Restrict(string restrictionId, string description)
    {
        return new EraHeritageRestriction(restrictionId, description);
    }
}
