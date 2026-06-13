using System.Collections.Generic;

namespace EraWheel.Save.Keys;

public enum EraCustomDataValueKind
{
    Bool,
    Int,
    Float,
    Long,
    String,
}

public sealed class EraEntityCustomDataKey
{
    public string Key { get; }
    public EraCustomDataValueKind ValueKind { get; }
    public string Purpose { get; }

    public EraEntityCustomDataKey(string key, EraCustomDataValueKind valueKind, string purpose)
    {
        Key = key;
        ValueKind = valueKind;
        Purpose = purpose;
    }
}

public static class EraEntityCustomDataKeys
{
    public static readonly EraEntityCustomDataKey HeroBloodlineRootId = new(
        "ew_actor_hero_bloodline_root_id",
        EraCustomDataValueKind.Long,
        "记录最近命中的命定英雄祖先 ID。"
    );

    public static readonly EraEntityCustomDataKey HeroBloodlineGeneration = new(
        "ew_actor_hero_bloodline_generation",
        EraCustomDataValueKind.Int,
        "记录当前单位距离英雄祖先的代数。"
    );

    public static readonly EraEntityCustomDataKey HeroAwakened = new(
        "ew_actor_hero_awakened",
        EraCustomDataValueKind.Bool,
        "记录当前单位是否已觉醒。"
    );

    public static readonly EraEntityCustomDataKey HeroSurvivorBonusPercent = new(
        "ew_actor_hero_survivor_bonus_percent",
        EraCustomDataValueKind.Float,
        "记录命定英雄跨轮幸存强化累计比例。"
    );

    public static readonly EraEntityCustomDataKey GeneralBoundDemonId = new(
        "ew_actor_general_bound_demon_id",
        EraCustomDataValueKind.String,
        "记录将领归属的魔王 ID。"
    );

    public static readonly EraEntityCustomDataKey GeneralBoundFortressId = new(
        "ew_actor_general_bound_fortress_id",
        EraCustomDataValueKind.Long,
        "记录将领绑定的据点建筑 ID。"
    );

    public static readonly EraEntityCustomDataKey DemonBoundFortressId = new(
        "ew_actor_demon_bound_fortress_id",
        EraCustomDataValueKind.Long,
        "记录魔王绑定的据点建筑 ID。"
    );

    public static readonly EraEntityCustomDataKey DemonCycleMarker = new(
        "ew_actor_demon_cycle_marker",
        EraCustomDataValueKind.Int,
        "记录魔王属于哪一轮运行态。"
    );

    public static readonly EraEntityCustomDataKey TraitRevivalUsed = new(
        "ew_actor_trait_revival_used",
        EraCustomDataValueKind.Bool,
        "记录“复活吧”是否已经在当前单位身上触发过。"
    );

    public static readonly EraEntityCustomDataKey TraitUnbrokenWillUsed = new(
        "ew_actor_trait_unbroken_will_used",
        EraCustomDataValueKind.Bool,
        "记录“不屈意志”是否已经在当前单位身上触发过。"
    );

    public static readonly EraEntityCustomDataKey TraitSoulReaperStacks = new(
        "ew_actor_trait_soul_reaper_stacks",
        EraCustomDataValueKind.Int,
        "记录“灵魂收割者”累计获得了多少层永久生命成长。"
    );

    public static readonly EraEntityCustomDataKey TraitFastLevelingNextGrantWorldTime = new(
        "ew_actor_trait_fast_leveling_next_grant_world_time",
        EraCustomDataValueKind.Float,
        "历史兼容字段；旧版本记录“快速升级”下一次发放经验时间，当前原版 special_effect_interval 不再读取。"
    );

    public static readonly IReadOnlyList<EraEntityCustomDataKey> All = new[]
    {
        HeroBloodlineRootId,
        HeroBloodlineGeneration,
        HeroAwakened,
        HeroSurvivorBonusPercent,
        GeneralBoundDemonId,
        GeneralBoundFortressId,
        DemonBoundFortressId,
        DemonCycleMarker,
        TraitRevivalUsed,
        TraitUnbrokenWillUsed,
        TraitSoulReaperStacks,
        TraitFastLevelingNextGrantWorldTime,
    };
}
