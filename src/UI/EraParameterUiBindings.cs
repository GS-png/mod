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
    private static EraRuntimeParameters Current => EraConfig.ParameterRegistry.Current;
    private static EraReincarnationParameters Reincarnation => Current.Reincarnation;
    private static EraDemonParameters Demons => Current.Demons;
    private static EraLegionParameters Legions => Current.Legions;
    private static EraAdvancementParameters Advancement => Current.Advancement;
    private static EraLevelParameters Levels => Current.Levels;
    private static EraKingdomParameters Kingdoms => Current.Kingdoms;
    private static EraHeroParameters Heroes => Current.Heroes;

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
        return new[]
        {
            Group(
                "预兆触发",
                "控制世界什么时候从平稳发展切到战前预兆。",
                Number("世界现存人口阈值", "预发展阶段检查人口时读取。", () => Reincarnation.OmenPopulationThreshold, value => UpdateCurrent(parameters => parameters.Reincarnation.OmenPopulationThreshold = ToInt(value)), wholeNumbers: true),
                Number("预发展检查间隔", "只影响多久检查一次，不改阈值本身。", () => Reincarnation.PreDevelopmentCheckInterval.Years, value => UpdateCurrent(parameters => parameters.Reincarnation.PreDevelopmentCheckInterval.Years = value), suffix: "年")
            ),
            Group(
                "将领封印",
                "将领封印归零后进入苏醒阶段。",
                Number("将领封印初始强度", "进入预兆时写入。", () => Reincarnation.GeneralSealInitialPercent, value => UpdateCurrent(parameters => parameters.Reincarnation.GeneralSealInitialPercent = value), suffix: "%"),
                Number("将领封印衰减速率", "预兆阶段持续衰减。", () => Reincarnation.GeneralSealDecayPercentPerYear, value => UpdateCurrent(parameters => parameters.Reincarnation.GeneralSealDecayPercentPerYear = value), suffix: "%/年")
            ),
            Group(
                "魔王封印",
                "魔王封印归零后进入降临阶段。",
                Number("魔王封印初始强度", "进入苏醒时写入。", () => Reincarnation.DemonSealInitialPercent, value => UpdateCurrent(parameters => parameters.Reincarnation.DemonSealInitialPercent = value), suffix: "%"),
                Number("魔王封印衰减速率", "苏醒阶段持续衰减。", () => Reincarnation.DemonSealDecayPercentPerYear, value => UpdateCurrent(parameters => parameters.Reincarnation.DemonSealDecayPercentPerYear = value), suffix: "%/年")
            ),
        };
    }

    private static IReadOnlyList<EraParameterGroupBinding> BuildDemonBindings()
    {
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
                        () => Demons.EnabledDemons.Contains(kind),
                        enabled => UpdateCurrent(parameters => parameters.Demons.EnabledDemons = ToggleEnumValue(parameters.Demons.EnabledDemons, kind, enabled))
                    )).ToArray()
                ),
                Number("苏醒数量", "候选池多于该数量时，会从启用魔王池里稳定随机抽取。", () => Demons.AwakeningCount, value => UpdateCurrent(parameters => parameters.Demons.AwakeningCount = Math.Max(1, ToInt(value))), wholeNumbers: true)
            ),
            Group(
                "多魔王模式",
                "同轮存在至少两名魔王时，这一组参数才真正参与计算。",
                Enum("互动模式", "可选 联盟 / 内战 / 随机。", () => (int)Demons.InteractionMode, value => UpdateCurrent(parameters => parameters.Demons.InteractionMode = (EraDemonInteractionMode)value), DemonInteractionModes),
                Number("关系校验间隔", "只在随机模式下真正使用。", () => Demons.RelationshipCheckInterval.Years, value => UpdateCurrent(parameters => parameters.Demons.RelationshipCheckInterval.Years = value), suffix: "年"),
                Number("联盟强度系数", "控制联盟模式下的整体压制力。", () => Demons.AllianceStrengthPercent, value => UpdateCurrent(parameters => parameters.Demons.AllianceStrengthPercent = value), suffix: "%"),
                Number("内战强度系数", "控制内战模式下的整体强度修正。", () => Demons.CivilWarStrengthPercent, value => UpdateCurrent(parameters => parameters.Demons.CivilWarStrengthPercent = value), suffix: "%")
            ),
            Group(
                "内战主导权",
                "只影响内战胜者那一套奖励。",
                Number("内战最大魔王数", "限制一轮里可参与主导权结算的魔王数量。", () => Demons.CivilWarMaxDemons, value => UpdateCurrent(parameters => parameters.Demons.CivilWarMaxDemons = Math.Max(1, ToInt(value))), wholeNumbers: true),
                Number("加成时长", "内战胜者限时加成持续时间。", () => Demons.CivilWarWinnerBonusDuration.Years, value => UpdateCurrent(parameters => parameters.Demons.CivilWarWinnerBonusDuration.Years = value), suffix: "年"),
                Number("加成属性比例", "只影响内战胜者。", () => Demons.CivilWarWinnerBonusPercent, value => UpdateCurrent(parameters => parameters.Demons.CivilWarWinnerBonusPercent = value), suffix: "%")
            ),
        };
    }

    private static IReadOnlyList<EraParameterGroupBinding> BuildLegionBindings()
    {
        return new[]
        {
            Group(
                "波次节奏",
                "控制预兆和降临阶段的持续出波。",
                Number("军团生成间隔", "预发展和战后重建不读取这项。", () => Legions.SpawnInterval.Years, value => UpdateCurrent(parameters => parameters.Legions.SpawnInterval.Years = value), suffix: "年"),
                Number("军团初始数量", "第一波压力。", () => Legions.InitialCount, value => UpdateCurrent(parameters => parameters.Legions.InitialCount = Math.Max(1, ToInt(value))), wholeNumbers: true),
                Number("军团同时上限", "每次准备出波时按上限裁剪。", () => Legions.ConcurrentLimit, value => UpdateCurrent(parameters => parameters.Legions.ConcurrentLimit = Math.Max(1, ToInt(value))), wholeNumbers: true)
            ),
            Group(
                "波次数量",
                "只影响相对上一波的增长比例。",
                Number("波次数量递增", "后续波次增长速度。", () => Legions.GrowthPercentPerWave, value => UpdateCurrent(parameters => parameters.Legions.GrowthPercentPerWave = value), suffix: "%/波")
            ),
        };
    }

    private static IReadOnlyList<EraParameterGroupBinding> BuildAdvancementBindings()
    {
        List<EraParameterGroupBinding> groups = new List<EraParameterGroupBinding>
        {
            Group(
                "档位推进",
                "这组参数决定世界档位怎么跨轮变化。",
                Number("轮回阶位上限", "世界档位最终会被截断到这个上限。", () => Advancement.MaxTier, value => UpdateCurrent(parameters => parameters.Advancement.MaxTier = Math.Max(1, ToInt(value))), wholeNumbers: true),
                Number("每轮回档位提升", "只在自动推进模式下生效。", () => Advancement.TierIncreasePerCycle, value => UpdateCurrent(parameters => parameters.Advancement.TierIncreasePerCycle = Math.Max(0, ToInt(value))), wholeNumbers: true),
                Enum("档位推进模式", "可选 自动推进 / 手动控制。", () => (int)Advancement.ProgressionMode, value => UpdateCurrent(parameters => parameters.Advancement.ProgressionMode = (EraWorldTierProgressionMode)value), WorldTierModes),
                Number("手动世界档位", "推进模式为手动控制时直接读取。", () => Advancement.ManualWorldTier, value => UpdateCurrent(parameters => parameters.Advancement.ManualWorldTier = Math.Max(1, ToInt(value))), wholeNumbers: true),
                Enum("王国档位模式", "决定王国侧装备和特质的档位读取方式。", () => (int)Advancement.KingdomTierMode, value => UpdateCurrent(parameters => parameters.Advancement.KingdomTierMode = (EraKingdomTierMode)value), KingdomTierModes)
            ),
            Group(
                "新王国起步",
                "用于计算王国档位基值。",
                Number("新王国档位下限", "新王国起始强度。", () => Advancement.Control.NewKingdomFloorTier, value => UpdateCurrent(parameters => parameters.Advancement.Control.NewKingdomFloorTier = Math.Max(1, ToInt(value))), wholeNumbers: true),
                Number("掌控度刷新间隔", "运行中重算掌控度时读取。", () => Advancement.Control.RefreshInterval.Years, value => UpdateCurrent(parameters => parameters.Advancement.Control.RefreshInterval.Years = value), suffix: "年"),
                Number("掌控度基础分", "王国档位基线。", () => Advancement.Control.BaseScore, value => UpdateCurrent(parameters => parameters.Advancement.Control.BaseScore = value))
            ),
            Group(
                "掌控度规模类",
                "城市、人口、军力和书籍共同组成王国掌控度。",
                Number("城市阈值", "达到后城市项按满额算。", () => Advancement.Control.Cities.Threshold, value => UpdateCurrent(parameters => parameters.Advancement.Control.Cities.Threshold = Math.Max(1, ToInt(value))), wholeNumbers: true),
                Number("人口阈值", "达到后人口项按满额算。", () => Advancement.Control.Population.Threshold, value => UpdateCurrent(parameters => parameters.Advancement.Control.Population.Threshold = Math.Max(1, ToInt(value))), wholeNumbers: true),
                Number("军力阈值", "达到后军力项按满额算。", () => Advancement.Control.Military.Threshold, value => UpdateCurrent(parameters => parameters.Advancement.Control.Military.Threshold = Math.Max(1, ToInt(value))), wholeNumbers: true),
                Number("书籍阈值", "达到后书籍项按满额算。", () => Advancement.Control.Books.Threshold, value => UpdateCurrent(parameters => parameters.Advancement.Control.Books.Threshold = Math.Max(1, ToInt(value))), wholeNumbers: true),
                Number("城市权重", "城市项贡献比例。", () => Advancement.Control.Cities.Weight, value => UpdateCurrent(parameters => parameters.Advancement.Control.Cities.Weight = value)),
                Number("人口权重", "人口项贡献比例。", () => Advancement.Control.Population.Weight, value => UpdateCurrent(parameters => parameters.Advancement.Control.Population.Weight = value)),
                Number("军力权重", "军力项贡献比例。", () => Advancement.Control.Military.Weight, value => UpdateCurrent(parameters => parameters.Advancement.Control.Military.Weight = value)),
                Number("书籍权重", "书籍项贡献比例。", () => Advancement.Control.Books.Weight, value => UpdateCurrent(parameters => parameters.Advancement.Control.Books.Weight = value))
            ),
            Group(
                "魔王装备发放",
                "空槽位继续补发，有更高值装备就替换。",
                Number("刷新间隔", "魔王与将领换装频率。", () => Advancement.DemonEquipmentRefreshInterval.Years, value => UpdateCurrent(parameters => parameters.Advancement.DemonEquipmentRefreshInterval.Years = value), suffix: "年")
            ),
            Group(
                "随机候选池",
                "同时影响轮回装备实例和轮回特质实例。",
                Multi(
                    "随机属性候选",
                    "发放轮回装备 / 特质实例时可抽中的属性集合。",
                    BuildAttributeOptions(
                        () => Advancement.RandomAttributes.CandidateAttributeIds,
                        attributeId => Advancement.RandomAttributes.CandidateAttributeIds.Contains(attributeId),
                        (attributeId, enabled) => UpdateCurrent(parameters => parameters.Advancement.RandomAttributes.CandidateAttributeIds = ToggleStringValue(parameters.Advancement.RandomAttributes.CandidateAttributeIds, attributeId, enabled))
                    )
                ),
                Number("每件装备随机属性数", "单件装备能抽到多少条随机属性。", () => Advancement.RandomAttributes.EquipmentAttributesPerItem, value => UpdateCurrent(parameters => parameters.Advancement.RandomAttributes.EquipmentAttributesPerItem = Math.Max(0, ToInt(value))), wholeNumbers: true),
                Number("每条特质随机属性数", "单条特质能抽到多少条随机属性。", () => Advancement.RandomAttributes.TraitAttributesPerItem, value => UpdateCurrent(parameters => parameters.Advancement.RandomAttributes.TraitAttributesPerItem = Math.Max(0, ToInt(value))), wholeNumbers: true)
            ),
        };

        groups.Add(
            Group(
                "属性独立区间",
                "每个属性都在自己的区间里结算，不会共用一个总随机池。",
                BuildRangeBindings(parameters => parameters.Advancement.RandomAttributes.AttributeRanges, suffix: string.Empty).ToArray()
            )
        );

        groups.AddRange(BuildGrowthBindings());
        return groups;
    }

    private static IReadOnlyList<EraParameterGroupBinding> BuildLevelBindings()
    {
        return new[]
        {
            Group(
                "升级随机规则",
                "所有 Actor 生物单位共用这套候选池。",
                Multi(
                    "随机属性候选",
                    "单位升级结算时可抽中的属性集合。",
                    BuildAttributeOptions(
                        () => Levels.RandomAttributes.CandidateAttributeIds,
                        attributeId => Levels.RandomAttributes.CandidateAttributeIds.Contains(attributeId),
                        (attributeId, enabled) => UpdateCurrent(parameters => parameters.Levels.RandomAttributes.CandidateAttributeIds = ToggleStringValue(parameters.Levels.RandomAttributes.CandidateAttributeIds, attributeId, enabled))
                    )
                ),
                Number("每级随机属性数", "单次升级能抽到多少项属性。", () => Levels.RandomAttributes.AttributesPerLevel, value => UpdateCurrent(parameters => parameters.Levels.RandomAttributes.AttributesPerLevel = Math.Max(0, ToInt(value))), wholeNumbers: true)
            ),
            Group(
                "升级属性独立加成",
                "每次命中就直接叠加这个固定值。",
                BuildNumberBindings(parameters => parameters.Levels.RandomAttributes.AttributeValues).ToArray()
            ),
        };
    }

    private static IReadOnlyList<EraParameterGroupBinding> BuildKingdomBindings()
    {
        List<EraParameterGroupBinding> groups = new List<EraParameterGroupBinding>
        {
            Group(
                "声望等级成长",
                "声望达到累计门槛后立即升级，不消耗、不清零。",
                Number("等级上限", "达到后总声望继续累计，但不再升。", () => Kingdoms.MaxLevel, value => UpdateCurrent(parameters => parameters.Kingdoms.MaxLevel = Math.Max(1, ToInt(value))), wholeNumbers: true)
            ),
        };

        for (int i = 0; i < Kingdoms.RenownBands.Count; i++)
        {
            int bandIndex = i + 1;
            int bandOffset = i;
            groups.Add(
                Group(
                    $"声望阈值分段（第 {bandIndex} 段）",
                    "三段必须连续覆盖整个等级区间。",
                    Number("起始等级", "读取该段配置时使用。", () => GetRenownBand(bandOffset).StartLevel, value => UpdateRenownBand(bandOffset, band => band.StartLevel = Math.Max(1, ToInt(value))), wholeNumbers: true),
                    Number("结束等级", "读取该段配置时使用。", () => GetRenownBand(bandOffset).EndLevel, value => UpdateRenownBand(bandOffset, band => band.EndLevel = Math.Max(band.StartLevel, ToInt(value))), wholeNumbers: true),
                    Number("每级所需声望", "用累计总声望判定。", () => GetRenownBand(bandOffset).RenownPerLevel, value => UpdateRenownBand(bandOffset, band => band.RenownPerLevel = Math.Max(1, ToInt(value))), wholeNumbers: true)
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
                        () => Kingdoms.RandomAttributes.CandidateAttributeIds,
                        attributeId => Kingdoms.RandomAttributes.CandidateAttributeIds.Contains(attributeId),
                        (attributeId, enabled) => UpdateCurrent(parameters => parameters.Kingdoms.RandomAttributes.CandidateAttributeIds = ToggleStringValue(parameters.Kingdoms.RandomAttributes.CandidateAttributeIds, attributeId, enabled))
                    )
                ),
                Number("每级随机属性数", "单次升级能抽到多少项属性。", () => Kingdoms.RandomAttributes.AttributesPerLevel, value => UpdateCurrent(parameters => parameters.Kingdoms.RandomAttributes.AttributesPerLevel = Math.Max(0, ToInt(value))), wholeNumbers: true)
            )
        );

        groups.Add(
            Group(
                "声望属性加成",
                "每次命中就直接叠加固定值。",
                BuildNumberBindings(parameters => parameters.Kingdoms.RandomAttributes.AttributeValues).ToArray()
            )
        );

        return groups;
    }

    private static IReadOnlyList<EraParameterGroupBinding> BuildHeroBindings()
    {
        return new[]
        {
            Group(
                "英雄上限与晋升条件",
                "先检查上限，再检查繁荣或危机触发。",
                Number("每王国英雄上限", "达到后该王国不再新增命定英雄。", () => Heroes.HeroesPerKingdomLimit, value => UpdateCurrent(parameters => parameters.Heroes.HeroesPerKingdomLimit = Math.Max(0, ToInt(value))), wholeNumbers: true),
                Number("世界总英雄上限", "达到后全世界都不再新增命定英雄。", () => Heroes.HeroesWorldLimit, value => UpdateCurrent(parameters => parameters.Heroes.HeroesWorldLimit = Math.Max(0, ToInt(value))), wholeNumbers: true),
                Number("王国每次人口增长阈值", "每累计增长到整数倍就触发一次。", () => Heroes.ProsperityPopulationGrowthThreshold, value => UpdateCurrent(parameters => parameters.Heroes.ProsperityPopulationGrowthThreshold = Math.Max(1, ToInt(value))), wholeNumbers: true),
                Number("统计窗口", "危机链路观察范围。", () => Heroes.CrisisWindow.Years, value => UpdateCurrent(parameters => parameters.Heroes.CrisisWindow.Years = value), suffix: "年"),
                Number("王国人口跌幅", "达到这个跌幅后触发一次晋升。", () => Heroes.CrisisPopulationLossPercent, value => UpdateCurrent(parameters => parameters.Heroes.CrisisPopulationLossPercent = value), suffix: "%")
            ),
            Group(
                "候选与评分",
                "综合分 = Σ(min(指标/阈值,1) × 权重)。",
                Number("等级权重", "与其它权重共同组成总分。", () => Heroes.ScoreProfile.LevelWeight, value => UpdateCurrent(parameters => parameters.Heroes.ScoreProfile.LevelWeight = value)),
                Number("击杀权重", "与其它权重共同组成总分。", () => Heroes.ScoreProfile.KillWeight, value => UpdateCurrent(parameters => parameters.Heroes.ScoreProfile.KillWeight = value)),
                Number("生命权重", "与其它权重共同组成总分。", () => Heroes.ScoreProfile.HealthWeight, value => UpdateCurrent(parameters => parameters.Heroes.ScoreProfile.HealthWeight = value)),
                Number("攻击权重", "与其它权重共同组成总分。", () => Heroes.ScoreProfile.DamageWeight, value => UpdateCurrent(parameters => parameters.Heroes.ScoreProfile.DamageWeight = value)),
                Number("指挥权重", "与其它权重共同组成总分。", () => Heroes.ScoreProfile.WarfareWeight, value => UpdateCurrent(parameters => parameters.Heroes.ScoreProfile.WarfareWeight = value)),
                Number("等级阈值", "等级项折算上限。", () => Heroes.ScoreProfile.LevelThreshold, value => UpdateCurrent(parameters => parameters.Heroes.ScoreProfile.LevelThreshold = Math.Max(1, ToInt(value))), wholeNumbers: true),
                Number("击杀阈值", "击杀项折算上限。", () => Heroes.ScoreProfile.KillThreshold, value => UpdateCurrent(parameters => parameters.Heroes.ScoreProfile.KillThreshold = Math.Max(1, ToInt(value))), wholeNumbers: true),
                Number("生命阈值", "生命项折算上限。", () => Heroes.ScoreProfile.HealthThreshold, value => UpdateCurrent(parameters => parameters.Heroes.ScoreProfile.HealthThreshold = Math.Max(1, ToInt(value))), wholeNumbers: true),
                Number("攻击阈值", "攻击项折算上限。", () => Heroes.ScoreProfile.DamageThreshold, value => UpdateCurrent(parameters => parameters.Heroes.ScoreProfile.DamageThreshold = Math.Max(1, ToInt(value))), wholeNumbers: true),
                Number("指挥阈值", "指挥项折算上限。", () => Heroes.ScoreProfile.WarfareThreshold, value => UpdateCurrent(parameters => parameters.Heroes.ScoreProfile.WarfareThreshold = Math.Max(1, ToInt(value))), wholeNumbers: true),
                Number("从评分前 N 名随机", "N 越大，随机性越强。", () => Heroes.RandomTopCandidateCount, value => UpdateCurrent(parameters => parameters.Heroes.RandomTopCandidateCount = Math.Max(1, ToInt(value))), wholeNumbers: true)
            ),
            Group(
                "幸存强化与家族继承",
                "跨轮幸存强化和血脉觉醒都在这里调。",
                Toggle("幸存强化开关", "只对命定英雄生效。", () => Heroes.SurvivorBonusEnabled, value => UpdateCurrent(parameters => parameters.Heroes.SurvivorBonusEnabled = value)),
                Number("每轮强化比例", "每轮最多发一次。", () => Heroes.SurvivorBonusPercentPerCycle, value => UpdateCurrent(parameters => parameters.Heroes.SurvivorBonusPercentPerCycle = value), suffix: "%"),
                Number("强化上限", "达到上限后不再继续叠加。", () => Heroes.SurvivorBonusCapPercent, value => UpdateCurrent(parameters => parameters.Heroes.SurvivorBonusCapPercent = value), suffix: "%"),
                Number("触发概率", "新生儿追溯到英雄祖先后判定。", () => Heroes.BloodlineInheritanceChancePercent, value => UpdateCurrent(parameters => parameters.Heroes.BloodlineInheritanceChancePercent = value), suffix: "%"),
                Number("继承属性比例", "只对成功觉醒者生效。", () => Heroes.BloodlineInheritanceValuePercent, value => UpdateCurrent(parameters => parameters.Heroes.BloodlineInheritanceValuePercent = value), suffix: "%"),
                Number("可继承代数", "向上追溯深度。", () => Heroes.BloodlineGenerationLimit, value => UpdateCurrent(parameters => parameters.Heroes.BloodlineGenerationLimit = Math.Max(1, ToInt(value))), wholeNumbers: true),
                Number("觉醒评分加成", "不直接增加继承属性值。", () => Heroes.AwakenedScoreBonusPercent, value => UpdateCurrent(parameters => parameters.Heroes.AwakenedScoreBonusPercent = value), suffix: "%")
            ),
        };
    }

    private static IReadOnlyList<EraParameterGroupBinding> BuildGrowthBindings()
    {
        return new[]
        {
            Group("数值成长：魔王生成基础范围", "同一轮回固定。", BuildRangeBindings(parameters => parameters.Growth.DemonBaseRanges).ToArray()),
            Group("数值成长：将领生成基础范围", "同一轮回固定。", BuildRangeBindings(parameters => parameters.Growth.GeneralBaseRanges).ToArray()),
            Group("数值成长：英雄晋升基础范围", "这是在原单位基础上叠加。", BuildRangeBindings(parameters => parameters.Growth.HeroPromotionRanges).ToArray()),
            Group("数值成长：军团出波基础范围", "同一波共享该波结果。", BuildRangeBindings(parameters => parameters.Growth.LegionBaseRanges).ToArray()),
        };
    }

    private static IEnumerable<EraParameterBindingBase> BuildRangeBindings(
        Func<EraRuntimeParameters, IReadOnlyDictionary<string, EraFloatRange>> rangesSelector,
        string suffix = "")
    {
        foreach (string attributeId in rangesSelector(Current).Keys.OrderBy(item => item, StringComparer.Ordinal))
        {
            yield return Range(
                $"{GetAttributeLabel(attributeId)}（`{attributeId}`）",
                "修改后会直接影响这一类随机范围。",
                () => GetRangeValue(rangesSelector(Current), attributeId),
                (min, max) =>
                {
                    UpdateCurrent(parameters => SetRangeValue(rangesSelector(parameters), attributeId, min, max));
                },
                suffix: suffix
            );
        }
    }

    private static IEnumerable<EraParameterBindingBase> BuildNumberBindings(
        Func<EraRuntimeParameters, IReadOnlyDictionary<string, float>> valuesSelector)
    {
        foreach (string attributeId in valuesSelector(Current).Keys.OrderBy(item => item, StringComparer.Ordinal))
        {
            yield return Number(
                $"{GetAttributeLabel(attributeId)}（`{attributeId}`）",
                "每次命中该属性时就直接叠加这个固定值。",
                () => GetDictionaryValue(valuesSelector(Current), attributeId),
                value => UpdateCurrent(parameters => SetDictionaryValue(valuesSelector(parameters), attributeId, value))
            );
        }
    }

    private static IReadOnlyList<EraMultiSelectOptionBinding> BuildAttributeOptions(
        Func<IReadOnlyList<string>> selectedValues,
        Func<string, bool> getter,
        Action<string, bool> setter
    )
    {
        List<string> allValues = selectedValues()
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

    private static void UpdateCurrent(Action<EraRuntimeParameters> mutation)
    {
        EraConfig.ParameterRegistry.UpdateCurrent(mutation);
    }

    private static EraKingdomRenownBand GetRenownBand(int index)
    {
        return index >= 0 && index < Kingdoms.RenownBands.Count
            ? Kingdoms.RenownBands[index]
            : new EraKingdomRenownBand();
    }

    private static void UpdateRenownBand(int index, Action<EraKingdomRenownBand> mutation)
    {
        UpdateCurrent(parameters =>
        {
            if (index >= 0 && index < parameters.Kingdoms.RenownBands.Count)
            {
                mutation(parameters.Kingdoms.RenownBands[index]);
            }
        });
    }

    private static EraFloatRange GetRangeValue(IReadOnlyDictionary<string, EraFloatRange> ranges, string key)
    {
        return ranges.TryGetValue(key, out EraFloatRange? range)
            ? range
            : new EraFloatRange();
    }

    private static void SetRangeValue(IReadOnlyDictionary<string, EraFloatRange> ranges, string key, float min, float max)
    {
        if (ranges is Dictionary<string, EraFloatRange> mutable)
        {
            if (!mutable.TryGetValue(key, out EraFloatRange? range))
            {
                range = new EraFloatRange();
                mutable[key] = range;
            }

            range.Min = min;
            range.Max = max;
        }
    }

    private static float GetDictionaryValue(IReadOnlyDictionary<string, float> values, string key)
    {
        return values.TryGetValue(key, out float value) ? value : 0f;
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
