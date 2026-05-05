using System;
using System.Collections.Generic;
using System.Linq;
using EraWheel.Config;
using EraWheel.Config.Schema;
using EraWheel.Core.Constants;

namespace EraWheel.UI;

public enum EraParameterControlKind
{
    Toggle = 0,
    Number = 1,
    Range = 2,
    Enum = 3,
    MultiSelect = 4,
}

public sealed class EraParameterGroupBinding
{
    public string Title { get; }
    public string Description { get; }
    public IReadOnlyList<EraParameterBindingBase> Bindings { get; }

    public EraParameterGroupBinding(string title, string description, IReadOnlyList<EraParameterBindingBase> bindings)
    {
        Title = title;
        Description = description;
        Bindings = bindings;
    }
}

public abstract class EraParameterBindingBase
{
    public string Label { get; }
    public string Description { get; }
    public EraParameterControlKind ControlKind { get; }

    protected EraParameterBindingBase(string label, string description, EraParameterControlKind controlKind)
    {
        Label = label;
        Description = description;
        ControlKind = controlKind;
    }
}

public sealed class EraToggleBinding : EraParameterBindingBase
{
    public Func<bool> Getter { get; }
    public Action<bool> Setter { get; }

    public EraToggleBinding(string label, string description, Func<bool> getter, Action<bool> setter)
        : base(label, description, EraParameterControlKind.Toggle)
    {
        Getter = getter;
        Setter = setter;
    }
}

public sealed class EraNumberBinding : EraParameterBindingBase
{
    public Func<float> Getter { get; }
    public Action<float> Setter { get; }
    public bool WholeNumbers { get; }
    public string Suffix { get; }

    public EraNumberBinding(
        string label,
        string description,
        Func<float> getter,
        Action<float> setter,
        bool wholeNumbers = false,
        string suffix = ""
    )
        : base(label, description, EraParameterControlKind.Number)
    {
        Getter = getter;
        Setter = setter;
        WholeNumbers = wholeNumbers;
        Suffix = suffix;
    }
}

public sealed class EraRangeBinding : EraParameterBindingBase
{
    public Func<EraFloatRange> Getter { get; }
    public Action<float, float> Setter { get; }
    public bool WholeNumbers { get; }
    public string Suffix { get; }

    public EraRangeBinding(
        string label,
        string description,
        Func<EraFloatRange> getter,
        Action<float, float> setter,
        bool wholeNumbers = false,
        string suffix = ""
    )
        : base(label, description, EraParameterControlKind.Range)
    {
        Getter = getter;
        Setter = setter;
        WholeNumbers = wholeNumbers;
        Suffix = suffix;
    }
}

public sealed class EraEnumOptionBinding
{
    public string Label { get; }
    public int Value { get; }

    public EraEnumOptionBinding(string label, int value)
    {
        Label = label;
        Value = value;
    }
}

public sealed class EraEnumBinding : EraParameterBindingBase
{
    public Func<int> Getter { get; }
    public Action<int> Setter { get; }
    public IReadOnlyList<EraEnumOptionBinding> Options { get; }

    public EraEnumBinding(
        string label,
        string description,
        Func<int> getter,
        Action<int> setter,
        IReadOnlyList<EraEnumOptionBinding> options
    )
        : base(label, description, EraParameterControlKind.Enum)
    {
        Getter = getter;
        Setter = setter;
        Options = options;
    }
}

public sealed class EraMultiSelectOptionBinding
{
    public string Label { get; }
    public string Description { get; }
    public Func<bool> Getter { get; }
    public Action<bool> Setter { get; }

    public EraMultiSelectOptionBinding(string label, string description, Func<bool> getter, Action<bool> setter)
    {
        Label = label;
        Description = description;
        Getter = getter;
        Setter = setter;
    }
}

public sealed class EraMultiSelectBinding : EraParameterBindingBase
{
    public IReadOnlyList<EraMultiSelectOptionBinding> Options { get; }

    public EraMultiSelectBinding(string label, string description, IReadOnlyList<EraMultiSelectOptionBinding> options)
        : base(label, description, EraParameterControlKind.MultiSelect)
    {
        Options = options;
    }
}

public static class EraParameterUiBindings
{
    private static readonly IReadOnlyList<EraEnumOptionBinding> DemonAwakeningModes = new[]
    {
        new EraEnumOptionBinding("指定", (int)EraDemonAwakeningMode.Specified),
        new EraEnumOptionBinding("随机", (int)EraDemonAwakeningMode.Random),
    };

    private static readonly IReadOnlyList<EraEnumOptionBinding> DemonInteractionModes = new[]
    {
        new EraEnumOptionBinding("联盟", (int)EraDemonInteractionMode.Alliance),
        new EraEnumOptionBinding("内战", (int)EraDemonInteractionMode.CivilWar),
        new EraEnumOptionBinding("随机", (int)EraDemonInteractionMode.Random),
    };

    private static readonly IReadOnlyList<EraEnumOptionBinding> WorldTierModes = new[]
    {
        new EraEnumOptionBinding("自动推进", (int)EraWorldTierProgressionMode.AutoAdvance),
        new EraEnumOptionBinding("手动控制", (int)EraWorldTierProgressionMode.ManualControl),
    };

    private static readonly IReadOnlyList<EraEnumOptionBinding> KingdomTierModes = new[]
    {
        new EraEnumOptionBinding("全部世界档位", (int)EraKingdomTierMode.AllUseWorldTier),
        new EraEnumOptionBinding("全部王国档位", (int)EraKingdomTierMode.AllUseKingdomTier),
        new EraEnumOptionBinding("幸存王国世界档位 + 新王国王国档位", (int)EraKingdomTierMode.SurvivorsUseWorldTierAndNewcomersUseKingdomTier),
    };

    private static readonly IReadOnlyDictionary<string, string> AttributeLabels = new Dictionary<string, string>
    {
        [EraAttributeIds.Health] = "生命值",
        [EraAttributeIds.Damage] = "伤害",
        [EraAttributeIds.AttackSpeed] = "攻速",
        [EraAttributeIds.CriticalChance] = "暴击率",
        [EraAttributeIds.CriticalDamageMultiplier] = "暴击伤害倍率",
        [EraAttributeIds.ThrowingRange] = "投掷",
        [EraAttributeIds.Range] = "范围",
        [EraAttributeIds.AreaOfEffect] = "效果范围",
        [EraAttributeIds.Knockback] = "击退",
        [EraAttributeIds.Armor] = "防御",
        [EraAttributeIds.Stamina] = "耐力",
        [EraAttributeIds.Mana] = "法力",
        [EraAttributeIds.Lifespan] = "寿命",
        [EraAttributeIds.Speed] = "移速",
        [EraAttributeIds.Scale] = "体形",
        [EraAttributeIds.Mass] = "受力质量",
        [EraAttributeIds.Mass2] = "体重",
        [EraAttributeIds.MaxNutrition] = "最大营养",
        [EraAttributeIds.Happiness] = "幸福度",
        [EraAttributeIds.SkillCombat] = "战斗技能",
        [EraAttributeIds.SkillSpell] = "施法",
        [EraAttributeIds.Diplomacy] = "外交",
        [EraAttributeIds.Warfare] = "指挥",
        [EraAttributeIds.Stewardship] = "组织",
        [EraAttributeIds.Intelligence] = "智力",
        [EraAttributeIds.MultiplierDamage] = "伤害倍率",
        [EraAttributeIds.MultiplierAttackSpeed] = "攻速倍率",
        [EraAttributeIds.MultiplierHealth] = "生命值倍率",
        [EraAttributeIds.MultiplierStamina] = "耐力倍率",
        [EraAttributeIds.MultiplierMana] = "法力倍率",
        [EraAttributeIds.MultiplierLifespan] = "寿命倍率",
        [EraAttributeIds.MultiplierSpeed] = "移速倍率",
        [EraAttributeIds.MultiplierMass] = "体重倍率",
        [EraAttributeIds.MultiplierDiplomacy] = "外交倍率",
    };

    public static IReadOnlyList<EraParameterGroupBinding> CreateForModule(EraModuleId moduleId)
    {
        return moduleId switch
        {
            EraModuleId.Reincarnation => BuildReincarnationBindings(),
            EraModuleId.Demons => BuildDemonBindings(),
            EraModuleId.Legions => BuildLegionBindings(),
            EraModuleId.Advancement => BuildAdvancementBindings(),
            EraModuleId.Levels => BuildLevelBindings(),
            EraModuleId.Kingdoms => BuildKingdomBindings(),
            EraModuleId.Heroes => BuildHeroBindings(),
            _ => Array.Empty<EraParameterGroupBinding>(),
        };
    }

    private static IReadOnlyList<EraParameterGroupBinding> BuildReincarnationBindings()
    {
        EraReincarnationParameters parameters = EraConfig.Parameters.Reincarnation;
        return new[]
        {
            Group(
                "预兆触发",
                "控制世界什么时候从平稳发展切到战前预兆。",
                Number("世界现存人口阈值", "预发展阶段检查人口时读取。", () => parameters.OmenPopulationThreshold, value => parameters.OmenPopulationThreshold = ToInt(value), wholeNumbers: true),
                Number("预发展检查间隔", "只影响多久检查一次，不改阈值本身。", () => parameters.PreDevelopmentCheckInterval.Years, value => parameters.PreDevelopmentCheckInterval.Years = value, suffix: "年")
            ),
            Group(
                "将领封印",
                "将领封印归零后进入苏醒阶段。",
                Number("将领封印初始强度", "进入预兆时写入。", () => parameters.GeneralSealInitialPercent, value => parameters.GeneralSealInitialPercent = value, suffix: "%"),
                Number("将领封印衰减速率", "预兆阶段持续衰减。", () => parameters.GeneralSealDecayPercentPerYear, value => parameters.GeneralSealDecayPercentPerYear = value, suffix: "%/年")
            ),
            Group(
                "魔王封印",
                "魔王封印归零后进入降临阶段。",
                Number("魔王封印初始强度", "进入苏醒时写入。", () => parameters.DemonSealInitialPercent, value => parameters.DemonSealInitialPercent = value, suffix: "%"),
                Number("魔王封印衰减速率", "苏醒阶段持续衰减。", () => parameters.DemonSealDecayPercentPerYear, value => parameters.DemonSealDecayPercentPerYear = value, suffix: "%/年")
            ),
        };
    }

    private static IReadOnlyList<EraParameterGroupBinding> BuildDemonBindings()
    {
        EraDemonParameters parameters = EraConfig.Parameters.Demons;
        IReadOnlyList<EraDemonKind> allDemons = System.Enum.GetValues(typeof(EraDemonKind)).Cast<EraDemonKind>().ToArray();
        return new[]
        {
            Group(
                "魔王池与苏醒",
                "决定这一轮有哪些魔王有资格进入候选池。",
                Multi(
                    "魔王启用默认",
                    "只控制候选池，不直接指定谁一定出场。",
                    allDemons.Select(kind => new EraMultiSelectOptionBinding(
                        GetDemonLabel(kind),
                        "预兆阶段确定本轮名单时读取。",
                        () => parameters.EnabledDemons.Contains(kind),
                        enabled => parameters.EnabledDemons = ToggleEnumValue(parameters.EnabledDemons, kind, enabled)
                    )).ToArray()
                ),
                Enum(
                    "魔王苏醒模式",
                    "可选 指定 / 随机。",
                    () => (int)parameters.AwakeningMode,
                    value => parameters.AwakeningMode = (EraDemonAwakeningMode)value,
                    DemonAwakeningModes
                ),
                Number("苏醒数量", "同轮同时苏醒的魔王数量。", () => parameters.AwakeningCount, value => parameters.AwakeningCount = Math.Max(1, ToInt(value)), wholeNumbers: true)
            ),
            Group(
                "多魔王模式",
                "同轮存在至少两名魔王时，这一组参数才真正参与计算。",
                Enum("互动模式", "可选 联盟 / 内战 / 随机。", () => (int)parameters.InteractionMode, value => parameters.InteractionMode = (EraDemonInteractionMode)value, DemonInteractionModes),
                Number("关系校验间隔", "只在随机模式下真正使用。", () => parameters.RelationshipCheckInterval.Years, value => parameters.RelationshipCheckInterval.Years = value, suffix: "年"),
                Number("联盟强度系数", "控制联盟模式下的整体压制力。", () => parameters.AllianceStrengthPercent, value => parameters.AllianceStrengthPercent = value, suffix: "%"),
                Number("内战强度系数", "控制内战模式下的整体强度修正。", () => parameters.CivilWarStrengthPercent, value => parameters.CivilWarStrengthPercent = value, suffix: "%")
            ),
            Group(
                "内战主导权",
                "只影响内战胜者那一套奖励。",
                Number("内战最大魔王数", "限制一轮里可参与主导权结算的魔王数量。", () => parameters.CivilWarMaxDemons, value => parameters.CivilWarMaxDemons = Math.Max(1, ToInt(value)), wholeNumbers: true),
                Number("加成时长", "内战胜者限时加成持续时间。", () => parameters.CivilWarWinnerBonusDuration.Years, value => parameters.CivilWarWinnerBonusDuration.Years = value, suffix: "年"),
                Number("加成属性比例", "只影响内战胜者。", () => parameters.CivilWarWinnerBonusPercent, value => parameters.CivilWarWinnerBonusPercent = value, suffix: "%")
            ),
        };
    }

    private static IReadOnlyList<EraParameterGroupBinding> BuildLegionBindings()
    {
        EraLegionParameters parameters = EraConfig.Parameters.Legions;
        return new[]
        {
            Group(
                "波次节奏",
                "控制预兆和降临阶段的持续出波。",
                Number("军团生成间隔", "预发展和战后重建不读取这项。", () => parameters.SpawnInterval.Years, value => parameters.SpawnInterval.Years = value, suffix: "年"),
                Number("军团初始数量", "第一波压力。", () => parameters.InitialCount, value => parameters.InitialCount = Math.Max(1, ToInt(value)), wholeNumbers: true),
                Number("军团同时上限", "每次准备出波时按上限裁剪。", () => parameters.ConcurrentLimit, value => parameters.ConcurrentLimit = Math.Max(1, ToInt(value)), wholeNumbers: true)
            ),
            Group(
                "波次数量",
                "只影响相对上一波的增长比例。",
                Number("波次数量递增", "后续波次增长速度。", () => parameters.GrowthPercentPerWave, value => parameters.GrowthPercentPerWave = value, suffix: "%/波")
            ),
        };
    }

    private static IReadOnlyList<EraParameterGroupBinding> BuildAdvancementBindings()
    {
        EraAdvancementParameters parameters = EraConfig.Parameters.Advancement;
        List<EraParameterGroupBinding> groups = new List<EraParameterGroupBinding>
        {
            Group(
                "档位推进",
                "这组参数决定世界档位怎么跨轮变化。",
                Number("轮回阶位上限", "世界档位最终会被截断到这个上限。", () => parameters.MaxTier, value => parameters.MaxTier = Math.Max(1, ToInt(value)), wholeNumbers: true),
                Number("每轮回档位提升", "只在自动推进模式下生效。", () => parameters.TierIncreasePerCycle, value => parameters.TierIncreasePerCycle = Math.Max(0, ToInt(value)), wholeNumbers: true),
                Enum("档位推进模式", "可选 自动推进 / 手动控制。", () => (int)parameters.ProgressionMode, value => parameters.ProgressionMode = (EraWorldTierProgressionMode)value, WorldTierModes),
                Number("手动世界档位", "推进模式为手动控制时直接读取。", () => parameters.ManualWorldTier, value => parameters.ManualWorldTier = Math.Max(1, ToInt(value)), wholeNumbers: true),
                Enum("王国档位模式", "决定王国侧装备和特质的档位读取方式。", () => (int)parameters.KingdomTierMode, value => parameters.KingdomTierMode = (EraKingdomTierMode)value, KingdomTierModes)
            ),
            Group(
                "新王国起步",
                "用于计算王国档位基值。",
                Number("新王国档位下限", "新王国起始强度。", () => parameters.Control.NewKingdomFloorTier, value => parameters.Control.NewKingdomFloorTier = Math.Max(1, ToInt(value)), wholeNumbers: true),
                Number("掌控度刷新间隔", "运行中重算掌控度时读取。", () => parameters.Control.RefreshInterval.Years, value => parameters.Control.RefreshInterval.Years = value, suffix: "年"),
                Number("掌控度基础分", "王国档位基线。", () => parameters.Control.BaseScore, value => parameters.Control.BaseScore = value)
            ),
            Group(
                "掌控度规模类",
                "城市、人口、军力和书籍共同组成王国掌控度。",
                Number("城市阈值", "达到后城市项按满额算。", () => parameters.Control.Cities.Threshold, value => parameters.Control.Cities.Threshold = Math.Max(1, ToInt(value)), wholeNumbers: true),
                Number("人口阈值", "达到后人口项按满额算。", () => parameters.Control.Population.Threshold, value => parameters.Control.Population.Threshold = Math.Max(1, ToInt(value)), wholeNumbers: true),
                Number("军力阈值", "达到后军力项按满额算。", () => parameters.Control.Military.Threshold, value => parameters.Control.Military.Threshold = Math.Max(1, ToInt(value)), wholeNumbers: true),
                Number("书籍阈值", "达到后书籍项按满额算。", () => parameters.Control.Books.Threshold, value => parameters.Control.Books.Threshold = Math.Max(1, ToInt(value)), wholeNumbers: true),
                Number("城市权重", "城市项贡献比例。", () => parameters.Control.Cities.Weight, value => parameters.Control.Cities.Weight = value),
                Number("人口权重", "人口项贡献比例。", () => parameters.Control.Population.Weight, value => parameters.Control.Population.Weight = value),
                Number("军力权重", "军力项贡献比例。", () => parameters.Control.Military.Weight, value => parameters.Control.Military.Weight = value),
                Number("书籍权重", "书籍项贡献比例。", () => parameters.Control.Books.Weight, value => parameters.Control.Books.Weight = value)
            ),
            Group(
                "魔王装备发放",
                "空槽位继续补发，有更高值装备就替换。",
                Number("刷新间隔", "魔王与将领换装频率。", () => parameters.DemonEquipmentRefreshInterval.Years, value => parameters.DemonEquipmentRefreshInterval.Years = value, suffix: "年")
            ),
            Group(
                "随机候选池",
                "同时影响轮回装备实例和轮回特质实例。",
                Multi(
                    "随机属性候选",
                    "发放轮回装备 / 特质实例时可抽中的属性集合。",
                    BuildAttributeOptions(
                        parameters.RandomAttributes.CandidateAttributeIds,
                        attributeId => parameters.RandomAttributes.CandidateAttributeIds.Contains(attributeId),
                        (attributeId, enabled) => parameters.RandomAttributes.CandidateAttributeIds = ToggleStringValue(parameters.RandomAttributes.CandidateAttributeIds, attributeId, enabled)
                    )
                ),
                Number("每件装备随机属性数", "单件装备能抽到多少条随机属性。", () => parameters.RandomAttributes.EquipmentAttributesPerItem, value => parameters.RandomAttributes.EquipmentAttributesPerItem = Math.Max(0, ToInt(value)), wholeNumbers: true),
                Number("每条特质随机属性数", "单条特质能抽到多少条随机属性。", () => parameters.RandomAttributes.TraitAttributesPerItem, value => parameters.RandomAttributes.TraitAttributesPerItem = Math.Max(0, ToInt(value)), wholeNumbers: true)
            ),
        };

        groups.Add(
            Group(
                "属性独立区间",
                "每个属性都在自己的区间里结算，不会共用一个总随机池。",
                BuildRangeBindings(parameters.RandomAttributes.AttributeRanges, suffix: string.Empty).ToArray()
            )
        );

        groups.AddRange(BuildGrowthBindings());
        return groups;
    }

    private static IReadOnlyList<EraParameterGroupBinding> BuildLevelBindings()
    {
        EraLevelParameters parameters = EraConfig.Parameters.Levels;
        return new[]
        {
            Group(
                "升级随机规则",
                "所有 Actor 生物单位共用这套候选池。",
                Multi(
                    "随机属性候选",
                    "单位升级结算时可抽中的属性集合。",
                    BuildAttributeOptions(
                        parameters.RandomAttributes.CandidateAttributeIds,
                        attributeId => parameters.RandomAttributes.CandidateAttributeIds.Contains(attributeId),
                        (attributeId, enabled) => parameters.RandomAttributes.CandidateAttributeIds = ToggleStringValue(parameters.RandomAttributes.CandidateAttributeIds, attributeId, enabled)
                    )
                ),
                Number("每级随机属性数", "单次升级能抽到多少项属性。", () => parameters.RandomAttributes.AttributesPerLevel, value => parameters.RandomAttributes.AttributesPerLevel = Math.Max(0, ToInt(value)), wholeNumbers: true)
            ),
            Group(
                "升级属性独立加成",
                "每次命中就直接叠加这个固定值。",
                BuildNumberBindings(parameters.RandomAttributes.AttributeValues).ToArray()
            ),
        };
    }

    private static IReadOnlyList<EraParameterGroupBinding> BuildKingdomBindings()
    {
        EraKingdomParameters parameters = EraConfig.Parameters.Kingdoms;
        List<EraParameterGroupBinding> groups = new List<EraParameterGroupBinding>
        {
            Group(
                "声望等级成长",
                "声望达到累计门槛后立即升级，不消耗、不清零。",
                Number("等级上限", "达到后总声望继续累计，但不再升。", () => parameters.MaxLevel, value => parameters.MaxLevel = Math.Max(1, ToInt(value)), wholeNumbers: true)
            ),
        };

        for (int i = 0; i < parameters.RenownBands.Count; i++)
        {
            EraKingdomRenownBand band = parameters.RenownBands[i];
            int bandIndex = i + 1;
            groups.Add(
                Group(
                    $"声望阈值分段（第 {bandIndex} 段）",
                    "三段必须连续覆盖整个等级区间。",
                    Number("起始等级", "读取该段配置时使用。", () => band.StartLevel, value => band.StartLevel = Math.Max(1, ToInt(value)), wholeNumbers: true),
                    Number("结束等级", "读取该段配置时使用。", () => band.EndLevel, value => band.EndLevel = Math.Max(band.StartLevel, ToInt(value)), wholeNumbers: true),
                    Number("每级所需声望", "用累计总声望判定。", () => band.RenownPerLevel, value => band.RenownPerLevel = Math.Max(1, ToInt(value)), wholeNumbers: true)
                )
            );
        }

        groups.Add(
            Group(
                "声望随机规则",
                "所属王国的 Actor 单位都会受益。",
                Multi(
                    "随机属性候选",
                    "王国每次声望升级时可抽中的属性集合。",
                    BuildAttributeOptions(
                        parameters.RandomAttributes.CandidateAttributeIds,
                        attributeId => parameters.RandomAttributes.CandidateAttributeIds.Contains(attributeId),
                        (attributeId, enabled) => parameters.RandomAttributes.CandidateAttributeIds = ToggleStringValue(parameters.RandomAttributes.CandidateAttributeIds, attributeId, enabled)
                    )
                ),
                Number("每级随机属性数", "单次升级能抽到多少项属性。", () => parameters.RandomAttributes.AttributesPerLevel, value => parameters.RandomAttributes.AttributesPerLevel = Math.Max(0, ToInt(value)), wholeNumbers: true)
            )
        );

        groups.Add(
            Group(
                "声望属性加成",
                "每次命中就直接叠加固定值。",
                BuildNumberBindings(parameters.RandomAttributes.AttributeValues).ToArray()
            )
        );

        return groups;
    }

    private static IReadOnlyList<EraParameterGroupBinding> BuildHeroBindings()
    {
        EraHeroParameters parameters = EraConfig.Parameters.Heroes;
        return new[]
        {
            Group(
                "英雄上限与晋升条件",
                "先检查上限，再检查繁荣或危机触发。",
                Number("每王国英雄上限", "达到后该王国不再新增命定英雄。", () => parameters.HeroesPerKingdomLimit, value => parameters.HeroesPerKingdomLimit = Math.Max(0, ToInt(value)), wholeNumbers: true),
                Number("世界总英雄上限", "达到后全世界都不再新增命定英雄。", () => parameters.HeroesWorldLimit, value => parameters.HeroesWorldLimit = Math.Max(0, ToInt(value)), wholeNumbers: true),
                Number("王国每次人口增长阈值", "每累计增长到整数倍就触发一次。", () => parameters.ProsperityPopulationGrowthThreshold, value => parameters.ProsperityPopulationGrowthThreshold = Math.Max(1, ToInt(value)), wholeNumbers: true),
                Number("统计窗口", "危机链路观察范围。", () => parameters.CrisisWindow.Years, value => parameters.CrisisWindow.Years = value, suffix: "年"),
                Number("王国人口跌幅", "达到这个跌幅后触发一次晋升。", () => parameters.CrisisPopulationLossPercent, value => parameters.CrisisPopulationLossPercent = value, suffix: "%")
            ),
            Group(
                "候选与评分",
                "综合分 = Σ(min(指标/阈值,1) × 权重)。",
                Number("等级权重", "与其它权重共同组成总分。", () => parameters.ScoreProfile.LevelWeight, value => parameters.ScoreProfile.LevelWeight = value),
                Number("击杀权重", "与其它权重共同组成总分。", () => parameters.ScoreProfile.KillWeight, value => parameters.ScoreProfile.KillWeight = value),
                Number("生命权重", "与其它权重共同组成总分。", () => parameters.ScoreProfile.HealthWeight, value => parameters.ScoreProfile.HealthWeight = value),
                Number("攻击权重", "与其它权重共同组成总分。", () => parameters.ScoreProfile.DamageWeight, value => parameters.ScoreProfile.DamageWeight = value),
                Number("指挥权重", "与其它权重共同组成总分。", () => parameters.ScoreProfile.WarfareWeight, value => parameters.ScoreProfile.WarfareWeight = value),
                Number("等级阈值", "等级项折算上限。", () => parameters.ScoreProfile.LevelThreshold, value => parameters.ScoreProfile.LevelThreshold = Math.Max(1, ToInt(value)), wholeNumbers: true),
                Number("击杀阈值", "击杀项折算上限。", () => parameters.ScoreProfile.KillThreshold, value => parameters.ScoreProfile.KillThreshold = Math.Max(1, ToInt(value)), wholeNumbers: true),
                Number("生命阈值", "生命项折算上限。", () => parameters.ScoreProfile.HealthThreshold, value => parameters.ScoreProfile.HealthThreshold = Math.Max(1, ToInt(value)), wholeNumbers: true),
                Number("攻击阈值", "攻击项折算上限。", () => parameters.ScoreProfile.DamageThreshold, value => parameters.ScoreProfile.DamageThreshold = Math.Max(1, ToInt(value)), wholeNumbers: true),
                Number("指挥阈值", "指挥项折算上限。", () => parameters.ScoreProfile.WarfareThreshold, value => parameters.ScoreProfile.WarfareThreshold = Math.Max(1, ToInt(value)), wholeNumbers: true),
                Number("从评分前 N 名随机", "N 越大，随机性越强。", () => parameters.RandomTopCandidateCount, value => parameters.RandomTopCandidateCount = Math.Max(1, ToInt(value)), wholeNumbers: true)
            ),
            Group(
                "幸存强化与家族继承",
                "跨轮幸存强化和血脉觉醒都在这里调。",
                Toggle("幸存强化开关", "只对命定英雄生效。", () => parameters.SurvivorBonusEnabled, value => parameters.SurvivorBonusEnabled = value),
                Number("每轮强化比例", "每轮最多发一次。", () => parameters.SurvivorBonusPercentPerCycle, value => parameters.SurvivorBonusPercentPerCycle = value, suffix: "%"),
                Number("强化上限", "达到上限后不再继续叠加。", () => parameters.SurvivorBonusCapPercent, value => parameters.SurvivorBonusCapPercent = value, suffix: "%"),
                Number("触发概率", "新生儿追溯到英雄祖先后判定。", () => parameters.BloodlineInheritanceChancePercent, value => parameters.BloodlineInheritanceChancePercent = value, suffix: "%"),
                Number("继承属性比例", "只对成功觉醒者生效。", () => parameters.BloodlineInheritanceValuePercent, value => parameters.BloodlineInheritanceValuePercent = value, suffix: "%"),
                Number("可继承代数", "向上追溯深度。", () => parameters.BloodlineGenerationLimit, value => parameters.BloodlineGenerationLimit = Math.Max(1, ToInt(value)), wholeNumbers: true),
                Number("觉醒评分加成", "不直接增加继承属性值。", () => parameters.AwakenedScoreBonusPercent, value => parameters.AwakenedScoreBonusPercent = value, suffix: "%")
            ),
        };
    }

    private static IReadOnlyList<EraParameterGroupBinding> BuildGrowthBindings()
    {
        EraGrowthParameters parameters = EraConfig.Parameters.Growth;
        return new[]
        {
            Group("数值成长：魔王生成基础范围", "同一轮回固定。", BuildRangeBindings(parameters.DemonBaseRanges).ToArray()),
            Group("数值成长：将领生成基础范围", "同一轮回固定。", BuildRangeBindings(parameters.GeneralBaseRanges).ToArray()),
            Group("数值成长：英雄晋升基础范围", "这是在原单位基础上叠加。", BuildRangeBindings(parameters.HeroPromotionRanges).ToArray()),
            Group("数值成长：军团出波基础范围", "同一波共享该波结果。", BuildRangeBindings(parameters.LegionBaseRanges).ToArray()),
        };
    }

    private static IEnumerable<EraParameterBindingBase> BuildRangeBindings(IReadOnlyDictionary<string, EraFloatRange> ranges, string suffix = "")
    {
        foreach (KeyValuePair<string, EraFloatRange> entry in ranges.OrderBy(item => item.Key, StringComparer.Ordinal))
        {
            string attributeId = entry.Key;
            EraFloatRange range = entry.Value;
            yield return Range(
                $"{GetAttributeLabel(attributeId)}（`{attributeId}`）",
                "修改后会直接影响这一类随机范围。",
                () => range,
                (min, max) =>
                {
                    range.Min = min;
                    range.Max = max;
                },
                suffix: suffix
            );
        }
    }

    private static IEnumerable<EraParameterBindingBase> BuildNumberBindings(IReadOnlyDictionary<string, float> values)
    {
        foreach (string attributeId in values.Keys.OrderBy(item => item, StringComparer.Ordinal))
        {
            yield return Number(
                $"{GetAttributeLabel(attributeId)}（`{attributeId}`）",
                "每次命中该属性时就直接叠加这个固定值。",
                () => values[attributeId],
                value => SetDictionaryValue(values, attributeId, value)
            );
        }
    }

    private static IReadOnlyList<EraMultiSelectOptionBinding> BuildAttributeOptions(
        IReadOnlyList<string> selectedValues,
        Func<string, bool> getter,
        Action<string, bool> setter
    )
    {
        List<string> allValues = selectedValues
            .Concat(AttributeLabels.Keys)
            .Distinct(StringComparer.Ordinal)
            .OrderBy(GetAttributeLabel, StringComparer.Ordinal)
            .ToList();

        return allValues
            .Select(attributeId => new EraMultiSelectOptionBinding(
                $"{GetAttributeLabel(attributeId)}（`{attributeId}`）",
                "勾上后，这个属性才会进入候选池。",
                () => getter(attributeId),
                enabled => setter(attributeId, enabled)
            ))
            .ToArray();
    }

    private static EraParameterGroupBinding Group(string title, string description, params EraParameterBindingBase[] bindings)
    {
        return new EraParameterGroupBinding(title, description, bindings);
    }

    private static EraToggleBinding Toggle(string label, string description, Func<bool> getter, Action<bool> setter)
    {
        return new EraToggleBinding(label, description, getter, setter);
    }

    private static EraNumberBinding Number(
        string label,
        string description,
        Func<float> getter,
        Action<float> setter,
        bool wholeNumbers = false,
        string suffix = ""
    )
    {
        return new EraNumberBinding(label, description, getter, setter, wholeNumbers, suffix);
    }

    private static EraRangeBinding Range(
        string label,
        string description,
        Func<EraFloatRange> getter,
        Action<float, float> setter,
        bool wholeNumbers = false,
        string suffix = ""
    )
    {
        return new EraRangeBinding(label, description, getter, setter, wholeNumbers, suffix);
    }

    private static EraEnumBinding Enum(
        string label,
        string description,
        Func<int> getter,
        Action<int> setter,
        IReadOnlyList<EraEnumOptionBinding> options
    )
    {
        return new EraEnumBinding(label, description, getter, setter, options);
    }

    private static EraMultiSelectBinding Multi(string label, string description, IReadOnlyList<EraMultiSelectOptionBinding> options)
    {
        return new EraMultiSelectBinding(label, description, options);
    }

    private static string GetDemonLabel(EraDemonKind kind)
    {
        return kind switch
        {
            EraDemonKind.VoidLord => "虚无之主",
            EraDemonKind.PlagueMother => "瘟疫母神",
            EraDemonKind.MechTyrant => "机械暴君",
            EraDemonKind.TimeDistorter => "时空扭曲者",
            EraDemonKind.ChaosFlame => "混沌炎魔",
            EraDemonKind.AbyssGod => "深渊邪神",
            EraDemonKind.DeathKing => "死亡君王",
            EraDemonKind.SoulWeaver => "灵魂编织者",
            EraDemonKind.NatureWrath => "自然之怒",
            EraDemonKind.FinalJudge => "终焉审判者",
            _ => kind.ToString(),
        };
    }

    private static string GetAttributeLabel(string attributeId)
    {
        return AttributeLabels.TryGetValue(attributeId, out string? label)
            ? label
            : attributeId.Replace('_', ' ');
    }

    private static int ToInt(float value)
    {
        return (int)Math.Round(value, MidpointRounding.AwayFromZero);
    }

    private static IReadOnlyList<TEnum> ToggleEnumValue<TEnum>(IReadOnlyList<TEnum> source, TEnum value, bool enabled)
        where TEnum : struct
    {
        List<TEnum> items = source.Distinct().ToList();
        if (enabled)
        {
            if (!items.Contains(value))
            {
                items.Add(value);
            }
        }
        else
        {
            items.RemoveAll(item => EqualityComparer<TEnum>.Default.Equals(item, value));
        }

        return items;
    }

    private static IReadOnlyList<string> ToggleStringValue(IReadOnlyList<string> source, string value, bool enabled)
    {
        List<string> items = source.Distinct(StringComparer.Ordinal).ToList();
        if (enabled)
        {
            if (!items.Any(item => string.Equals(item, value, StringComparison.Ordinal)))
            {
                items.Add(value);
            }
        }
        else
        {
            items.RemoveAll(item => string.Equals(item, value, StringComparison.Ordinal));
        }

        return items;
    }

    private static void SetDictionaryValue(IReadOnlyDictionary<string, float> values, string key, float value)
    {
        if (values is Dictionary<string, float> mutable)
        {
            mutable[key] = value;
        }
    }
}
