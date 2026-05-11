using System.Collections.Generic;
using EraWheel.Core.Constants;
using EraWheel.Data.Definitions;

namespace EraWheel.Data.Manifests;

public static class EraDemonManifestData
{
    public static IReadOnlyList<EraDemonManifest> All { get; } = new[]
    {
        new EraDemonManifest(
            "demon_void_lord",
            EraDemonKind.VoidLord,
            "虚无之主",
            "位移、牵引、沉默",
            "机动压制",
            "Assets/Art/注册生物单位图片/魔王与将领图片/虚无之主/icon.png",
            "Assets/Art/魔王据点图片/虚无之主据点.png"
        ),
        new EraDemonManifest(
            "demon_plague_mother",
            EraDemonKind.PlagueMother,
            "瘟疫母神",
            "感染叠层、死亡扩散",
            "持续消耗",
            "Assets/Art/注册生物单位图片/魔王与将领图片/瘟疫母神/icon.png",
            "Assets/Art/魔王据点图片/瘟疫母神据点.png"
        ),
        new EraDemonManifest(
            "demon_mech_tyrant",
            EraDemonKind.MechTyrant,
            "机械暴君",
            "电荷资源、群体增益",
            "节奏爆发",
            "Assets/Art/注册生物单位图片/魔王与将领图片/机械暴君/icon.png",
            "Assets/Art/魔王据点图片/机械暴君据点.png"
        ),
        new EraDemonManifest(
            "demon_time_distorter",
            EraDemonKind.TimeDistorter,
            "时空扭曲者",
            "传送、换位、回溯",
            "干扰反打",
            "Assets/Art/注册生物单位图片/魔王与将领图片/时空扭曲者/icon.png",
            "Assets/Art/魔王据点图片/时空扭曲者据点.png"
        ),
        new EraDemonManifest(
            "demon_chaos_flame",
            EraDemonKind.ChaosFlame,
            "混沌炎魔",
            "火焰地形、冲击爆发",
            "近战压场",
            "Assets/Art/注册生物单位图片/魔王与将领图片/混沌炎魔/icon.png",
            "Assets/Art/魔王据点图片/混沌炎魔据点.png"
        ),
        new EraDemonManifest(
            "demon_abyss_god",
            EraDemonKind.AbyssGod,
            "深渊邪神",
            "恐惧、腐化池、召唤",
            "控场耗血",
            "Assets/Art/注册生物单位图片/魔王与将领图片/深渊邪神/icon.png",
            "Assets/Art/魔王据点图片/深渊邪神据点.png"
        ),
        new EraDemonManifest(
            "demon_death_king",
            EraDemonKind.DeathKing,
            "死亡君王",
            "复生亡灵、永夜压制",
            "兵海推进",
            "Assets/Art/注册生物单位图片/魔王与将领图片/死亡君王/icon.png",
            "Assets/Art/魔王据点图片/死亡君王据点.png"
        ),
        new EraDemonManifest(
            "demon_soul_weaver",
            EraDemonKind.SoulWeaver,
            "灵魂编织者",
            "控制、交换、分伤",
            "夺控战场",
            "Assets/Art/注册生物单位图片/魔王与将领图片/灵魂编织者/icon.png",
            "Assets/Art/魔王据点图片/灵魂编织者据点.png"
        ),
        new EraDemonManifest(
            "demon_nature_wrath",
            EraDemonKind.NatureWrath,
            "自然之怒",
            "地形改造、群体增益",
            "召唤续航",
            "Assets/Art/注册生物单位图片/魔王与将领图片/自然之怒/icon.png",
            "Assets/Art/魔王据点图片/自然之怒据点.png"
        ),
        new EraDemonManifest(
            "demon_final_judge",
            EraDemonKind.FinalJudge,
            "终焉审判者",
            "罪孽判定、分层制裁",
            "定点处决",
            "Assets/Art/注册生物单位图片/魔王与将领图片/终焉审判者/icon.png",
            "Assets/Art/魔王据点图片/终焉审判者据点.png"
        ),
    };
}
