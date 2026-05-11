using System;
using System.Collections.Generic;
using EraWheel.Data.Definitions;

namespace EraWheel.Data.Manifests;

public static class EraHeritageEquipmentManifestData
{
    private static readonly EraHeritageRandomAttributeProfile SharedRandomAttributes = new(
        "advancement.shared_default",
        6,
        true,
        "共享候选池；随机 6 条；单次不重复。"
    );

    public static IReadOnlyList<EraHeritageEquipmentManifest> All { get; } = new[]
    {
        Equipment(
            "eq_herit_t1_stormwire_blade",
            "风暴引线短剑",
            1,
            Craft(EraHeritageEquipmentSlotKind.Sword, "silver", 1, "stone", 1, 3, 0, 90),
            Trigger(EraHeritageTriggerKind.OnHit, 15f, "雷电引线"),
            Target(EraHeritageTargetKind.TargetEnemy, "目标敌军"),
            "降下一道雷击；目标附加 1 年易伤（受伤 +10%~20%）。",
            Impl(EraHeritageImplementationKind.ReuseAndAdjust, "复用 summon_lightning，再给目标追加易伤状态。", "summon_lightning"),
            "Assets/Art/轮回阶位装备图标/风暴引线短剑.png",
            Fixed("vulnerability_duration_years", "易伤持续时间", 1f, EraHeritageParameterUnit.Years),
            Range("damage_taken_bonus_percent", "受伤提升", 10f, 20f, EraHeritageParameterUnit.Percent)
        ),
        Equipment(
            "eq_herit_t1_mirror_shell_helm",
            "镜壳头盔",
            1,
            Craft(EraHeritageEquipmentSlotKind.Helmet, "leather", 1, "silver", 1, 0, 0, 80),
            Trigger(EraHeritageTriggerKind.OnGetHit, 15f, "镜返"),
            Target(EraHeritageTargetKind.SelfAndAttacker, "自身 + 攻击者（敌军）", includesSelf: true),
            "回填本次伤害 10%~20%，并给攻击者 1 年减速（移速 -10%~20%）。",
            Impl(EraHeritageImplementationKind.Composite, "先按本次受击值回填生命，再给攻击者附加减速效果。"),
            "Assets/Art/轮回阶位装备图标/镜壳头盔.png",
            Range("heal_from_damage_percent", "受击回填比例", 10f, 20f, EraHeritageParameterUnit.Percent),
            Fixed("slow_duration_years", "减速持续时间", 1f, EraHeritageParameterUnit.Years),
            Range("slow_percent", "移速降低", 10f, 20f, EraHeritageParameterUnit.Percent)
        ),
        Equipment(
            "eq_herit_t1_seedflare_ring",
            "芽火戒",
            1,
            Craft(EraHeritageEquipmentSlotKind.Ring, "wood", 1, "gems", 1, 3, 0, 85),
            Trigger(EraHeritageTriggerKind.OnHit, 15f, "芽火燃烧"),
            Target(EraHeritageTargetKind.TargetEnemy, "目标敌军"),
            "对目标附加火焰效果；命中的目标附加 1 年燃芽（移速 -10%~20%）。",
            Impl(EraHeritageImplementationKind.ReuseAndAdjust, "复用 cast_fire，再给命中目标追加减速状态。", "cast_fire"),
            "Assets/Art/轮回阶位装备图标/芽火戒.png",
            Fixed("slow_duration_years", "燃芽持续时间", 1f, EraHeritageParameterUnit.Years),
            Range("slow_percent", "移速降低", 10f, 20f, EraHeritageParameterUnit.Percent)
        ),
        Equipment(
            "eq_herit_t2_quake_axe",
            "裂岩震斧",
            2,
            Craft(EraHeritageEquipmentSlotKind.Axe, "stone", 1, "common_metals", 1, 8, 0, 110),
            Trigger(EraHeritageTriggerKind.OnHit, 15f, "断层震波"),
            Target(EraHeritageTargetKind.TargetPointEnemies, "目标点半径敌军", primaryRadius: 4f),
            "以目标为中心打出地裂，半径 4 内敌军受到 damage×15%~25% 并短眩晕。",
            Impl(EraHeritageImplementationKind.ReuseAndAdjust, "复用 summon_earthquake，把范围和伤害改成技能描述，并追加短眩晕。", "summon_earthquake"),
            "Assets/Art/轮回阶位装备图标/裂岩震斧.png",
            Fixed("radius", "地裂半径", 4f, EraHeritageParameterUnit.Tiles),
            Range("damage_multiplier", "伤害倍率", 0.15f, 0.25f, EraHeritageParameterUnit.Multiplier),
            Fixed("stun_seconds", "眩晕时间", 2f, EraHeritageParameterUnit.Seconds)
        ),
        Equipment(
            "eq_herit_t2_shadowstep_boots",
            "影步战靴",
            2,
            Craft(EraHeritageEquipmentSlotKind.Boots, "leather", 1, "silver", 1, 7, 0, 100),
            Trigger(EraHeritageTriggerKind.OnGetHit, 15f, "残影疾行"),
            Target(EraHeritageTargetKind.Self, "自身", includesSelf: true),
            "自身获得 1 年移速 +15%~55%，并给下一次命中附加必暴标记。",
            Impl(EraHeritageImplementationKind.Custom, "新增受击后自我加速状态，并记录下一次命中的必暴标记。"),
            "Assets/Art/轮回阶位装备图标/影步战靴.png",
            Fixed("buff_duration_years", "加速持续时间", 1f, EraHeritageParameterUnit.Years),
            Range("speed_bonus_percent", "移速提升", 15f, 55f, EraHeritageParameterUnit.Percent),
            Fixed("next_hit_crit", "下一次命中必暴", 1f, EraHeritageParameterUnit.Count)
        ),
        Equipment(
            "eq_herit_t2_voidwell_amulet",
            "虚井护符",
            2,
            Craft(EraHeritageEquipmentSlotKind.Amulet, "common_metals", 1, "silver", 1, 7, 0, 105),
            Trigger(EraHeritageTriggerKind.OnGetHit, 15f, "虚井回响"),
            Target(EraHeritageTargetKind.Self, "自身", includesSelf: true),
            "获得护盾；护盾持续期间法力回复 +15%~25%。",
            Impl(EraHeritageImplementationKind.ReuseAndAdjust, "复用 cast_shield，再在护盾持续期间追加法力回复加成。", "cast_shield"),
            "Assets/Art/轮回阶位装备图标/虚井护符.png",
            Fixed("shield_enabled", "护盾", 1f, EraHeritageParameterUnit.Count),
            Range("mana_regen_bonus_percent", "法力回复提升", 15f, 25f, EraHeritageParameterUnit.Percent)
        ),
        Equipment(
            "eq_herit_t3_tide_spear",
            "潮汐折浪矛",
            3,
            Craft(EraHeritageEquipmentSlotKind.Spear, "silver", 1, "wood", 1, 15, 0, 135),
            Trigger(EraHeritageTriggerKind.Active, 15f, "潮刃回旋"),
            Target(EraHeritageTargetKind.TargetPointEnemies, "目标点半径敌军", primaryRadius: 5f),
            "释放水刃环特效，半径 5 内敌军被牵引并损失当前生命 2%（最低保留 1HP）。",
            Impl(EraHeritageImplementationKind.Custom, "新增目标点范围水刃环，统一结算牵引和当前生命百分比伤害。"),
            "Assets/Art/轮回阶位装备图标/潮汐折浪矛.png",
            Fixed("radius", "水刃环半径", 5f, EraHeritageParameterUnit.Tiles),
            Fixed("current_health_damage_percent", "当前生命伤害", 2f, EraHeritageParameterUnit.Percent),
            Fixed("minimum_remaining_health", "最低保留生命", 1f, EraHeritageParameterUnit.HitPoints)
        ),
        Equipment(
            "eq_herit_t3_iron_tide_armor",
            "铁潮重甲",
            3,
            Craft(EraHeritageEquipmentSlotKind.Armor, "common_metals", 1, "leather", 1, 14, 0, 130),
            Trigger(EraHeritageTriggerKind.OnGetHit, 15f, "重潮回震"),
            Target(EraHeritageTargetKind.SelfAndAttacker, "自身 + 攻击者（敌军）", includesSelf: true),
            "反弹本次伤害 15%~25%，并给自身 2 年减伤 15%~25%。",
            Impl(EraHeritageImplementationKind.Composite, "先按本次受击值反弹部分伤害，再给自身附加短时减伤状态。"),
            "Assets/Art/轮回阶位装备图标/铁潮重甲.png",
            Range("reflect_percent", "反弹比例", 15f, 25f, EraHeritageParameterUnit.Percent),
            Fixed("mitigation_duration_years", "减伤持续时间", 2f, EraHeritageParameterUnit.Years),
            Range("mitigation_percent", "减伤比例", 15f, 25f, EraHeritageParameterUnit.Percent)
        ),
        Equipment(
            "eq_herit_t3_plague_rain_ring",
            "瘟雨戒",
            3,
            Craft(EraHeritageEquipmentSlotKind.Ring, "bones", 1, "gems", 1, 11, 0, 125),
            Trigger(EraHeritageTriggerKind.Active, 15f, "瘟雨"),
            Target(EraHeritageTargetKind.RadiusEnemies, "雨区敌军"),
            "生成血雨区域；雨区内命中的目标附加 2 年衰弱（伤害 -30%~50%）。",
            Impl(EraHeritageImplementationKind.ReuseAndAdjust, "复用 cast_blood_rain，再给雨区命中目标追加衰弱状态。", "cast_blood_rain"),
            "Assets/Art/轮回阶位装备图标/瘟雨戒.png",
            Fixed("weaken_duration_years", "衰弱持续时间", 2f, EraHeritageParameterUnit.Years),
            Range("damage_penalty_percent", "伤害降低", 30f, 50f, EraHeritageParameterUnit.Percent)
        ),
        Equipment(
            "eq_herit_t4_prism_bow",
            "折光棱弓",
            4,
            Craft(EraHeritageEquipmentSlotKind.Bow, "mythril", 2, "common_metals", 1, 24, 0, 160),
            Trigger(EraHeritageTriggerKind.Active, 15f, "棱镜齐射"),
            Target(EraHeritageTargetKind.RadiusEnemies, "额外 3 名敌军", maxTargets: 3),
            "发射三束光矢特效，额外命中 3 个目标，各造成 damage×45%~65%。",
            Impl(EraHeritageImplementationKind.Custom, "新增多目标光矢逻辑，对额外目标分别结算伤害。"),
            "Assets/Art/轮回阶位装备图标/折光棱弓.png",
            Fixed("extra_target_count", "额外目标数", 3f, EraHeritageParameterUnit.Count),
            Range("damage_multiplier", "额外光矢伤害倍率", 0.45f, 0.65f, EraHeritageParameterUnit.Multiplier)
        ),
        Equipment(
            "eq_herit_t4_frost_oath_helm",
            "霜誓战盔",
            4,
            Craft(EraHeritageEquipmentSlotKind.Helmet, "mythril", 1, "stone", 1, 20, 0, 155),
            Trigger(EraHeritageTriggerKind.OnGetHit, 15f, "霜锚"),
            Target(EraHeritageTargetKind.TargetEnemy, "目标敌军"),
            "目标获得 2 年移速 -45%~65%，并获得 2 年攻速 -45%~65%。",
            Impl(EraHeritageImplementationKind.Custom, "新增受击反制效果，对敌方目标同时施加移速和攻速削弱。"),
            "Assets/Art/轮回阶位装备图标/霜誓战盔.png",
            Fixed("duration_years", "削弱持续时间", 2f, EraHeritageParameterUnit.Years),
            Range("speed_penalty_percent", "移速降低", 45f, 65f, EraHeritageParameterUnit.Percent),
            Range("attack_speed_penalty_percent", "攻速降低", 45f, 65f, EraHeritageParameterUnit.Percent)
        ),
        Equipment(
            "eq_herit_t4_silence_seal_amulet",
            "沉默圣印",
            4,
            Craft(EraHeritageEquipmentSlotKind.Amulet, "mythril", 1, "bones", 1, 18, 0, 150),
            Trigger(EraHeritageTriggerKind.Active, 15f, "沉默封印"),
            Target(EraHeritageTargetKind.TargetEnemyAndNearbyEnemies, "主目标 + 目标周围敌军", primaryRadius: 4f),
            "使目标沉默，并给目标周围半径 4 内的敌军附加 1 年失衡（精准 -15%~35%）。",
            Impl(EraHeritageImplementationKind.Composite, "先复用 cast_silence 作用于主目标，再给周围敌军追加精准削弱。", "cast_silence"),
            "Assets/Art/轮回阶位装备图标/沉默圣印.png",
            Fixed("aura_radius", "周围半径", 4f, EraHeritageParameterUnit.Tiles),
            Fixed("imbalance_duration_years", "失衡持续时间", 1f, EraHeritageParameterUnit.Years),
            Range("accuracy_penalty_percent", "精准降低", 15f, 35f, EraHeritageParameterUnit.Percent)
        ),
        Equipment(
            "eq_herit_t5_meteor_hammer",
            "陨核战锤",
            5,
            Craft(EraHeritageEquipmentSlotKind.Hammer, "mythril", 2, "stone", 1, 40, 0, 210),
            Trigger(EraHeritageTriggerKind.OnHit, 15f, "陨火坠地"),
            Target(EraHeritageTargetKind.TargetPointEnemies, "目标点半径敌军", primaryRadius: 6f),
            "在目标处召唤一颗陨石，半径 6 内敌军承受 damage×60%~80% 并被击退。",
            Impl(EraHeritageImplementationKind.ReuseAndAdjust, "复用 summon_meteor_rain，把陨石数量和范围改成单颗陨落，并追加击退。", "summon_meteor_rain"),
            "Assets/Art/轮回阶位装备图标/陨核战锤.png",
            Fixed("meteor_count", "陨石数量", 1f, EraHeritageParameterUnit.Count),
            Fixed("radius", "陨石半径", 6f, EraHeritageParameterUnit.Tiles),
            Range("damage_multiplier", "伤害倍率", 0.60f, 0.80f, EraHeritageParameterUnit.Multiplier)
        ),
        Equipment(
            "eq_herit_t5_grove_plate",
            "林歌披甲",
            5,
            Craft(EraHeritageEquipmentSlotKind.Armor, "wood", 1, "mythril", 1, 36, 0, 200),
            Trigger(EraHeritageTriggerKind.OnGetHit, 15f, "藤生护场"),
            Target(EraHeritageTargetKind.SelfAndRadiusFriends, "半径友军（含自身）", primaryRadius: 6f, includesSelf: true),
            "给半径 6 内友军增加 3 年防御 +60%~80%。",
            Impl(EraHeritageImplementationKind.Custom, "新增范围友军增益技能，统一给周围友军附加防御加成。"),
            "Assets/Art/轮回阶位装备图标/林歌披甲.png",
            Fixed("radius", "护场半径", 6f, EraHeritageParameterUnit.Tiles),
            Fixed("buff_duration_years", "增益持续时间", 3f, EraHeritageParameterUnit.Years),
            Range("armor_bonus_percent", "防御提升", 60f, 80f, EraHeritageParameterUnit.Percent)
        ),
        Equipment(
            "eq_herit_t5_hunt_greaves",
            "追猎胫甲",
            5,
            Craft(EraHeritageEquipmentSlotKind.Boots, "leather", 1, "gems", 1, 31, 0, 190),
            Trigger(EraHeritageTriggerKind.OnHit, 15f, "追猎处决"),
            Target(EraHeritageTargetKind.TargetEnemy, "目标敌军"),
            "若目标生命低于 50%，追加当前伤害 60%~80% 伤害。",
            Impl(EraHeritageImplementationKind.Custom, "新增斩杀判定，按目标当前生命阈值追加伤害。"),
            "Assets/Art/轮回阶位装备图标/追猎胫甲.png",
            Fixed("health_threshold_percent", "处决阈值", 50f, EraHeritageParameterUnit.Percent),
            Range("bonus_damage_percent", "追加伤害比例", 60f, 80f, EraHeritageParameterUnit.Percent)
        ),
        Equipment(
            "eq_herit_t6_starcore_staff",
            "星核法杖",
            6,
            Craft(EraHeritageEquipmentSlotKind.Staff, "mythril", 2, "gems", 1, 58, 0, 260),
            Trigger(EraHeritageTriggerKind.OnHit, 15f, "星核坠击"),
            Target(EraHeritageTargetKind.TargetPointEnemies, "目标点半径敌军", primaryRadius: 6f),
            "在目标区生成蓝红色彗核特效，半径 6 内敌军承受 damage×75%~95% 并短眩晕。",
            Impl(EraHeritageImplementationKind.Custom, "新增目标点彗核坠击效果，对范围敌军结算伤害和短眩晕。"),
            "Assets/Art/轮回阶位装备图标/星核法杖.png",
            Fixed("radius", "坠击半径", 6f, EraHeritageParameterUnit.Tiles),
            Range("damage_multiplier", "伤害倍率", 0.75f, 0.95f, EraHeritageParameterUnit.Multiplier),
            Fixed("stun_seconds", "眩晕时间", 2f, EraHeritageParameterUnit.Seconds)
        ),
        Equipment(
            "eq_herit_t6_bone_crown",
            "白骨王冠",
            6,
            Craft(EraHeritageEquipmentSlotKind.Helmet, "bones", 1, "adamantine", 1, 51, 0, 250),
            Trigger(EraHeritageTriggerKind.Active, 15f, "白骨召唤"),
            Target(EraHeritageTargetKind.SummonedAllies, "召唤单位（友军）", maxTargets: 10),
            "召唤 10 个骷髅协助作战。",
            Impl(EraHeritageImplementationKind.ReuseAndAdjust, "复用 spawn_skeleton，把召唤规模改成 10 个并指定归属。", "spawn_skeleton"),
            "Assets/Art/轮回阶位装备图标/白骨王冠.png",
            Fixed("summon_count", "召唤数量", 10f, EraHeritageParameterUnit.Count)
        ),
        Equipment(
            "eq_herit_t6_reflux_ring",
            "逆流戒",
            6,
            Craft(EraHeritageEquipmentSlotKind.Ring, "silver", 1, "gems", 1, 47, 0, 240),
            Trigger(EraHeritageTriggerKind.Active, 15f, "逆流充能"),
            Target(EraHeritageTargetKind.Self, "自身", includesSelf: true),
            "立刻回蓝 25%~50%，并让下次主动技能伤害 +75%~95%。",
            Impl(EraHeritageImplementationKind.Custom, "新增即时回蓝效果，并记录下一次主动技能的伤害加成。"),
            "Assets/Art/轮回阶位装备图标/逆流戒.png",
            Range("restore_mana_percent", "回蓝比例", 25f, 50f, EraHeritageParameterUnit.Percent),
            Range("next_active_bonus_percent", "下次主动伤害提升", 75f, 95f, EraHeritageParameterUnit.Percent)
        ),
        Equipment(
            "eq_herit_t7_thunder_prison_gun",
            "雷狱枪",
            7,
            Craft(EraHeritageEquipmentSlotKind.Firearm, "common_metals", 1, "adamantine", 2, 78, 0, 350),
            Trigger(EraHeritageTriggerKind.OnHit, 15f, "电磁囚网"),
            Target(EraHeritageTargetKind.TargetPointEnemies, "命中点半径敌军", primaryRadius: 5f),
            "在命中点生成半径 5 的电网特效，持续 3 秒，范围内敌军被困在里面不能出来。",
            Impl(EraHeritageImplementationKind.Custom, "新增目标点电网区域，持续限制范围敌军离开。"),
            "Assets/Art/轮回阶位装备图标/雷狱枪.png",
            Fixed("radius", "电网半径", 5f, EraHeritageParameterUnit.Tiles),
            Fixed("duration_seconds", "电网持续时间", 3f, EraHeritageParameterUnit.Seconds)
        ),
        Equipment(
            "eq_herit_t7_wall_armor",
            "界墙胸铠",
            7,
            Craft(EraHeritageEquipmentSlotKind.Armor, "silver", 1, "adamantine", 1, 70, 0, 335),
            Trigger(EraHeritageTriggerKind.OnGetHit, 15f, "界墙"),
            Target(EraHeritageTargetKind.SelfAndAttacker, "自身 + 攻击者（敌军）", includesSelf: true),
            "获得护盾，护盾值=最大生命×20%~40%，并反弹本次伤害 30%~50%。",
            Impl(EraHeritageImplementationKind.ReuseAndAdjust, "复用 cast_shield，把护盾值改成最大生命百分比，再追加反伤。", "cast_shield"),
            "Assets/Art/轮回阶位装备图标/界墙胸铠.png",
            Range("shield_max_health_percent", "护盾值", 20f, 40f, EraHeritageParameterUnit.Percent),
            Range("reflect_percent", "反弹比例", 30f, 50f, EraHeritageParameterUnit.Percent)
        ),
        Equipment(
            "eq_herit_t7_blink_sigil",
            "瞬界符",
            7,
            Craft(EraHeritageEquipmentSlotKind.Amulet, "mythril", 1, "leather", 1, 65, 0, 320),
            Trigger(EraHeritageTriggerKind.Active, 15f, "瞬界"),
            Target(EraHeritageTargetKind.SelfAndRadiusEnemies, "自身 + 落点半径敌军", primaryRadius: 8f, includesSelf: true),
            "瞬移到目标位置；落点范围为半径 8，范围内敌军附加 3 年减速 40%。",
            Impl(EraHeritageImplementationKind.Composite, "先复用 teleport 位移到落点，再给落点周围敌军附加减速。", "teleport"),
            "Assets/Art/轮回阶位装备图标/瞬界符.png",
            Fixed("landing_radius", "落点半径", 8f, EraHeritageParameterUnit.Tiles),
            Fixed("slow_duration_years", "减速持续时间", 3f, EraHeritageParameterUnit.Years),
            Fixed("slow_percent", "移速降低", 40f, EraHeritageParameterUnit.Percent)
        ),
        Equipment(
            "eq_herit_t8_abyss_tornado_blade",
            "深渊龙卷刃",
            8,
            Craft(EraHeritageEquipmentSlotKind.Sword, "dragon_scales", 2, "bones", 1, 98, 0, 440),
            Trigger(EraHeritageTriggerKind.OnHit, 15f, "龙卷裂甲"),
            Target(EraHeritageTargetKind.RadiusEnemies, "龙卷命中敌军", primaryRadius: 5f),
            "生成龙卷风；被龙卷命中目标附加 3 年裂甲（受到的伤害 +30%~60%）。",
            Impl(EraHeritageImplementationKind.ReuseAndAdjust, "复用 summon_tornado，再给命中目标追加裂甲状态。", "summon_tornado"),
            "Assets/Art/轮回阶位装备图标/深渊龙卷刃.png",
            Fixed("crack_duration_years", "裂甲持续时间", 3f, EraHeritageParameterUnit.Years),
            Range("damage_taken_bonus_percent", "受伤提升", 30f, 60f, EraHeritageParameterUnit.Percent)
        ),
        Equipment(
            "eq_herit_t8_solar_flare_boots",
            "日珥战靴",
            8,
            Craft(EraHeritageEquipmentSlotKind.Boots, "dragon_scales", 1, "leather", 1, 79, 0, 400),
            Trigger(EraHeritageTriggerKind.Active, 15f, "日珥拖尾"),
            Target(EraHeritageTargetKind.SelfAndPathEnemies, "自身 + 拖尾范围敌军", pathLength: 10f, includesSelf: true),
            "自身向前冲刺 10 格，并在拖尾路径留下火焰效果；碰到火焰的敌军造成 damage×50%~70%。",
            Impl(EraHeritageImplementationKind.Composite, "先新增前冲位移，再复用 cast_fire 在路径上生成持续火焰。", "cast_fire"),
            "Assets/Art/轮回阶位装备图标/日珥战靴.png",
            Fixed("dash_length", "冲刺长度", 10f, EraHeritageParameterUnit.Tiles),
            Range("fire_damage_multiplier", "拖尾火焰伤害倍率", 0.50f, 0.70f, EraHeritageParameterUnit.Multiplier)
        ),
        Equipment(
            "eq_herit_t8_verdict_circuit_ring",
            "审判回路戒",
            8,
            Craft(EraHeritageEquipmentSlotKind.Ring, "mythril", 1, "gems", 1, 94, 0, 420),
            Trigger(EraHeritageTriggerKind.OnHit, 15f, "审判计数"),
            Target(EraHeritageTargetKind.TargetEnemy, "目标敌军"),
            "目标叠 1 层印记；达到 3 层时立刻损失当前生命 5%（最低保留 1HP）。",
            Impl(EraHeritageImplementationKind.Custom, "新增印记叠层系统，达到阈值后结算当前生命百分比伤害。"),
            "Assets/Art/轮回阶位装备图标/审判回路戒.png",
            Fixed("stack_per_hit", "单次叠层", 1f, EraHeritageParameterUnit.Count),
            Fixed("trigger_stacks", "触发层数", 3f, EraHeritageParameterUnit.Count),
            Fixed("current_health_damage_percent", "当前生命伤害", 5f, EraHeritageParameterUnit.Percent),
            Fixed("minimum_remaining_health", "最低保留生命", 1f, EraHeritageParameterUnit.HitPoints)
        ),
        Equipment(
            "eq_herit_t9_heaven_arc_bow",
            "天罚弧弓",
            9,
            Craft(EraHeritageEquipmentSlotKind.Bow, "adamantine", 3, "mythril", 2, 112, 0, 580),
            Trigger(EraHeritageTriggerKind.OnHit, 15f, "三段圣雷"),
            Target(EraHeritageTargetKind.TargetEnemy, "目标敌军"),
            "连续降下 3 次雷击，第 2/3 段各造成首段 50%~80% 伤害。",
            Impl(EraHeritageImplementationKind.ReuseAndAdjust, "连续复用 summon_lightning，按段数衰减后续伤害。", "summon_lightning"),
            "Assets/Art/轮回阶位装备图标/天罚弧弓.png",
            Fixed("lightning_count", "雷击次数", 3f, EraHeritageParameterUnit.Count),
            Range("follow_up_damage_percent", "后续段伤害比例", 50f, 80f, EraHeritageParameterUnit.Percent)
        ),
        Equipment(
            "eq_herit_t9_crown_of_cities",
            "王城冠冕",
            9,
            Craft(EraHeritageEquipmentSlotKind.Helmet, "adamantine", 2, "silver", 2, 112, 0, 550),
            Trigger(new[] { EraHeritageTriggerKind.Active, EraHeritageTriggerKind.OnGetHit }, 15f, "王城动员"),
            Target(EraHeritageTargetKind.SelfAndRadiusFriends, "半径友军（含自身）", primaryRadius: 8f, includesSelf: true),
            "半径 8 内友军获得 5 年升级经验获取 +120%~140%，并获得战斗技能 +120%~140%。",
            Impl(EraHeritageImplementationKind.Custom, "新增范围友军增益效果，统一提高经验获取与战斗技能。"),
            "Assets/Art/轮回阶位装备图标/王城冠冕.png",
            Fixed("radius", "动员半径", 8f, EraHeritageParameterUnit.Tiles),
            Fixed("buff_duration_years", "增益持续时间", 5f, EraHeritageParameterUnit.Years),
            Range("experience_gain_percent", "经验获取提升", 120f, 140f, EraHeritageParameterUnit.Percent),
            Range("skill_combat_bonus_percent", "战斗技能提升", 120f, 140f, EraHeritageParameterUnit.Percent)
        ),
        Equipment(
            "eq_herit_t9_black_sun_amulet",
            "无光圣匣",
            9,
            Craft(EraHeritageEquipmentSlotKind.Amulet, "bones", 2, "gems", 2, 112, 0, 520),
            Trigger(EraHeritageTriggerKind.Active, 15f, "暗日封界"),
            Target(EraHeritageTargetKind.TargetPointEnemies, "目标点半径敌军", primaryRadius: 8f),
            "目标点半径 8 内敌军先被拉拢，再获得 5 年移速 -40%。",
            Impl(EraHeritageImplementationKind.Custom, "新增目标点范围牵引效果，再给范围敌军附加减速状态。"),
            "Assets/Art/轮回阶位装备图标/无光圣匣.png",
            Fixed("radius", "封界半径", 8f, EraHeritageParameterUnit.Tiles),
            Fixed("slow_duration_years", "减速持续时间", 5f, EraHeritageParameterUnit.Years),
            Fixed("slow_percent", "移速降低", 40f, EraHeritageParameterUnit.Percent)
        ),
        Equipment(
            "eq_herit_t10_final_lance",
            "终局圣枪",
            10,
            Craft(EraHeritageEquipmentSlotKind.Spear, "adamantine", 3, "mythril", 2, 130, 0, 760),
            Trigger(EraHeritageTriggerKind.OnHit, 15f, "终局落星"),
            Target(EraHeritageTargetKind.TargetEnemyAndNearbyEnemies, "主目标 + 半径敌军", primaryRadius: 10f),
            "对主目标及其周围半径 10 内的敌军造成 damage×135%~155%。",
            Impl(EraHeritageImplementationKind.Custom, "新增主目标加范围溅射伤害的结算逻辑。"),
            "Assets/Art/轮回阶位装备图标/终局圣枪.png",
            Fixed("splash_radius", "溅射半径", 10f, EraHeritageParameterUnit.Tiles),
            Range("damage_multiplier", "伤害倍率", 1.35f, 1.55f, EraHeritageParameterUnit.Multiplier)
        ),
        Equipment(
            "eq_herit_t10_omni_king_armor",
            "万象王铠",
            10,
            Craft(EraHeritageEquipmentSlotKind.Armor, "adamantine", 3, "dragon_scales", 2, 126, 0, 720),
            Trigger(EraHeritageTriggerKind.OnGetHit, 15f, "万象反域"),
            Target(EraHeritageTargetKind.SelfAndRadiusEnemies, "自身 + 半径敌军", primaryRadius: 10f, includesSelf: true),
            "立即获得 +100000 护盾，并击退半径 10 内敌军。",
            Impl(EraHeritageImplementationKind.ReuseAndAdjust, "复用 cast_shield 作为护盾入口，把护盾值改成固定值，再追加范围击退。", "cast_shield"),
            "Assets/Art/轮回阶位装备图标/万象王铠.png",
            Fixed("shield_value", "固定护盾值", 100000f, EraHeritageParameterUnit.HitPoints),
            Fixed("knockback_radius", "击退半径", 10f, EraHeritageParameterUnit.Tiles)
        ),
        Equipment(
            "eq_herit_t10_cycle_singularity_ring",
            "轮回奇点戒",
            10,
            Craft(EraHeritageEquipmentSlotKind.Ring, "mythril", 2, "gems", 2, 136, 0, 680),
            Trigger(EraHeritageTriggerKind.Active, 15f, "奇点爆缩"),
            Target(EraHeritageTargetKind.RadiusEnemies, "半径敌军", primaryRadius: 10f),
            "拉拢半径 10 内敌军，随后触发爆缩，目标损失当前生命 15%（最低保留 1HP）。",
            Impl(EraHeritageImplementationKind.Custom, "新增范围牵引与爆缩结算逻辑，对敌军追加当前生命百分比伤害。"),
            "Assets/Art/轮回阶位装备图标/轮回奇点戒.png",
            Fixed("radius", "奇点半径", 10f, EraHeritageParameterUnit.Tiles),
            Fixed("current_health_damage_percent", "当前生命伤害", 15f, EraHeritageParameterUnit.Percent),
            Fixed("minimum_remaining_health", "最低保留生命", 1f, EraHeritageParameterUnit.HitPoints)
        ),
    };

    private static EraHeritageEquipmentManifest Equipment(
        string equipmentId,
        string displayName,
        int unlockTier,
        EraHeritageCraftingProfile crafting,
        EraHeritageTriggerProfile trigger,
        EraHeritageTargetingProfile targeting,
        string summary,
        EraHeritageImplementationProfile implementation,
        string iconSourcePath,
        params EraHeritageEffectParameter[] effectParameters
    )
    {
        return new EraHeritageEquipmentManifest(
            equipmentId,
            displayName,
            unlockTier,
            crafting,
            trigger,
            targeting,
            summary,
            implementation,
            effectParameters,
            SharedRandomAttributes,
            Array.Empty<EraHeritageRestriction>(),
            iconSourcePath
        );
    }

    private static EraHeritageCraftingProfile Craft(
        EraHeritageEquipmentSlotKind slotKind,
        string primaryResourceId,
        int primaryResourceCost,
        string secondaryResourceId,
        int secondaryResourceCost,
        int goldCost,
        int minimumCityStorageResource1,
        int equipmentValue
    )
    {
        return new EraHeritageCraftingProfile(
            slotKind,
            primaryResourceId,
            primaryResourceCost,
            secondaryResourceId,
            secondaryResourceCost,
            goldCost,
            minimumCityStorageResource1,
            equipmentValue
        );
    }

    private static EraHeritageTriggerProfile Trigger(
        EraHeritageTriggerKind kind,
        float chancePercent,
        string skillLabel
    )
    {
        return new EraHeritageTriggerProfile(new[] { kind }, chancePercent, skillLabel);
    }

    private static EraHeritageTriggerProfile Trigger(
        IReadOnlyList<EraHeritageTriggerKind> kinds,
        float chancePercent,
        string skillLabel
    )
    {
        return new EraHeritageTriggerProfile(kinds, chancePercent, skillLabel);
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
}
