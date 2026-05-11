using System.Collections.Generic;
using EraWheel.Data.Definitions;

namespace EraWheel.Data.Manifests;

public static class EraPublicTraitManifestData
{
    public static IReadOnlyList<EraPublicTraitManifest> All { get; } = new[]
    {
        new EraPublicTraitManifest("trait_common_lifesteal", "吸血", "命中触发", "攻击命中后按本次造成伤害的 10% 回血。", "出生=2；遗传=13；成长=1；突变箱；手动", "Assets/Art/公共特质图标/吸血.png"),
        new EraPublicTraitManifest("trait_common_onhit_exp_10", "战斗悟性", "命中触发", "普通攻击命中目标时，攻击者固定获得 +10 经验。", "出生=1；遗传=5；成长=1；突变箱；手动；训练", "Assets/Art/公共特质图标/战斗悟性.png"),
        new EraPublicTraitManifest("trait_common_fireborn", "火之子", "地形适应", "站在岩浆或火地块时免疫火焰伤害，并每 10 秒回复 1% 当前生命和法力。", "出生=3；遗传=15；成长=1；突变箱；手动", "Assets/Art/公共特质图标/火之子.png"),
        new EraPublicTraitManifest("trait_common_revival", "复活吧", "死亡触发", "单位死亡时立即复活，并回复到 30% 生命值。", "出生=2；遗传=9；成长=1；突变箱；手动", "Assets/Art/公共特质图标/复活吧.png"),
        new EraPublicTraitManifest("trait_common_golden_touch", "黄金之触", "击杀触发", "击杀目标后尸体随机变成石头、银、精金、矿石、秘银、黄金。", "出生=1；遗传=6；成长=1；突变箱；手动", "Assets/Art/公共特质图标/黄金之触.png"),
        new EraPublicTraitManifest("trait_common_waterborn", "水之子", "地形适应", "站在水或深海地块时移速 +50%，并每 10 秒回复 1% 当前生命和法力。", "出生=2；遗传=15；成长=1；突变箱；手动", "Assets/Art/公共特质图标/水之子.png"),
        new EraPublicTraitManifest("trait_common_lightning_body", "雷电法体", "受击触发", "被雷击时不受伤，改为回复 50% 当前生命，并获得 10 秒移速提升 100%。", "出生=2；遗传=13；成长=1；突变箱；手动", "Assets/Art/公共特质图标/雷电法体.png"),
        new EraPublicTraitManifest("trait_common_forestborn", "森林之子", "地形适应", "站在森林地块时移速 +50%，并每 10 秒回复 1% 当前生命和法力。", "出生=3；遗传=15；成长=1；突变箱；手动", "Assets/Art/公共特质图标/森林之子.png"),
        new EraPublicTraitManifest("trait_common_berserker", "狂战士", "低血被动", "每当生命值下降 1%，伤害提升 2%，提升的伤害根据生命值动态加载。", "出生=2；遗传=9；成长=1；突变箱；手动", "Assets/Art/公共特质图标/狂战士.png"),
        new EraPublicTraitManifest("trait_common_death_curse", "死亡诅咒", "死亡触发", "单位死亡后让击杀者减少 30% 当前剩余寿命。", "出生=2；遗传=13；成长=1；突变箱；手动", "Assets/Art/公共特质图标/死亡诅咒.png"),
        new EraPublicTraitManifest("trait_common_soul_reaper", "灵魂收割者", "击杀成长", "每击杀 1 个敌人，永久提升 1% 最大生命值。", "出生=1；遗传=5；成长=1；突变箱；手动", "Assets/Art/公共特质图标/灵魂收割者.png"),
        new EraPublicTraitManifest("trait_common_fast_leveling", "快速升级", "成长被动", "每年额外获得 10 点经验。", "出生=1；遗传=6；成长=1；突变箱；手动", "Assets/Art/公共特质图标/快速升级.png"),
        new EraPublicTraitManifest("trait_common_flight", "飞翔", "常驻移动", "单位获得飞行能力，拥有飞行姿态，无视所有地形阻挡。", "出生=2；遗传=11；成长=1；突变箱；手动", "Assets/Art/公共特质图标/飞翔.png"),
        new EraPublicTraitManifest("trait_common_martyr", "殉道者", "死亡触发", "死亡时给半径 6 友军回复 10% 最大生命并套气泡盾。", "出生=1；遗传=6；成长=1；突变箱；手动", "Assets/Art/公共特质图标/殉道者.png"),
        new EraPublicTraitManifest("trait_common_leadership", "领袖气质", "光环被动", "半径 6 内每有 1 名友军时自身防御提升 1%。", "出生=1；遗传=9；成长=1；突变箱；手动", "Assets/Art/公共特质图标/领袖气质.png"),
        new EraPublicTraitManifest("trait_common_unbroken_will", "不屈意志", "濒死触发", "生命值第一次低于 20% 时立即回复 50% 当前生命。", "出生=1；遗传=9；成长=1；突变箱；手动", "Assets/Art/公共特质图标/不屈意志.png"),
        new EraPublicTraitManifest("trait_common_cute", "甚至有点可爱", "索敌干扰", "敌方单位索敌时有 50% 概率跳过该目标。", "出生=2；遗传=11；成长=1；突变箱；手动", "Assets/Art/公共特质图标/甚至有点可爱.png"),
        new EraPublicTraitManifest("trait_common_giant_slayer", "巨人杀手", "条件增伤", "对体型比自己大的敌人造成双倍伤害。", "出生=1；遗传=6；成长=1；突变箱；手动；训练", "Assets/Art/公共特质图标/巨人杀手.png"),
        new EraPublicTraitManifest("trait_common_lucky", "幸运儿", "受击触发", "受到伤害时有 10% 概率完全免疫本次伤害。", "出生=1；遗传=9；成长=1；突变箱；手动", "Assets/Art/公共特质图标/幸运儿.png"),
        new EraPublicTraitManifest("trait_common_coward", "胆小鬼", "低血触发", "生命值低于 50% 时移速额外提升 200%。", "出生=2；遗传=11；成长=1；突变箱；手动", "Assets/Art/公共特质图标/胆小鬼.png"),
        new EraPublicTraitManifest("trait_common_gambler", "赌徒", "命中触发", "每次攻击伤害在 1%-500% 区间内随机波动。", "出生=1；遗传=6；成长=1；突变箱；手动", "Assets/Art/公共特质图标/赌徒.png"),
        new EraPublicTraitManifest("trait_common_shared_fate", "命运共同体", "群体联动", "同特质单位共享视野，且任意成员被攻击时全体会锁定攻击者。", "出生=2；遗传=9；成长=1；突变箱；手动", "Assets/Art/公共特质图标/命运共同体.png"),
        new EraPublicTraitManifest("trait_common_bloodline", "血脉", "后代继承", "当拥有该特质的生物诞生后代时，后代会获得其除血脉外当前拥有的其它全部特质。", "出生=2；遗传=19；成长=1；手动", "Assets/Art/公共特质图标/血脉.png"),
        new EraPublicTraitManifest("trait_common_lightning_blessing", "闪电的祝福", "常驻增益", "常驻提升移速和攻速各 100%。", "出生=1；遗传=6；成长=1；突变箱；手动", "Assets/Art/公共特质图标/闪电的祝福.png"),
        new EraPublicTraitManifest("trait_common_master", "大师", "常驻增益", "常驻提升战斗、施法与文明属性，作为综合型高阶特质。", "出生=1；遗传=6；成长=1；突变箱；手动；训练", "Assets/Art/公共特质图标/大师.png"),
    };
}
