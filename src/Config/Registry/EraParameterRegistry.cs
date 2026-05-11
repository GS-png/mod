using System;
using System.Collections.Generic;
using EraWheel.Config.Schema;
using EraWheel.Core.Constants;
using NeoModLoader.api;

namespace EraWheel.Config.Registry;

public sealed class EraParameterRegistry
{
    private readonly Dictionary<Type, object> _sections = new Dictionary<Type, object>();

    public EraRuntimeParameters Current { get; }

    private EraParameterRegistry(EraRuntimeParameters current)
    {
        Current = current;
        Register(current.Reincarnation);
        Register(current.Demons);
        Register(current.Legions);
        Register(current.Advancement);
        Register(current.Levels);
        Register(current.Kingdoms);
        Register(current.Heroes);
        Register(current.Growth);
    }

    public static EraParameterRegistry Create(ModConfig? config)
    {
        return new EraParameterRegistry(CreateDefaultParameters());
    }

    public TSection GetSection<TSection>()
        where TSection : class
    {
        if (_sections.TryGetValue(typeof(TSection), out object? section))
        {
            return (TSection)section;
        }

        throw new InvalidOperationException($"未注册参数分区：{typeof(TSection).Name}");
    }

    public string CreateStatusReport()
    {
        return $"已装载 {_sections.Count} 个参数分区；启用魔王 {Current.Demons.EnabledDemons.Count} 个；轮回进阶随机属性 {Current.Advancement.RandomAttributes.CandidateAttributeIds.Count} 项；等级随机属性 {Current.Levels.RandomAttributes.CandidateAttributeIds.Count} 项。";
    }

    private void Register<TSection>(TSection section)
        where TSection : class
    {
        _sections[typeof(TSection)] = section;
    }

    private static EraRuntimeParameters CreateDefaultParameters()
    {
        return new EraRuntimeParameters
        {
            Reincarnation = new EraReincarnationParameters
            {
                OmenPopulationThreshold = 7000,
                PreDevelopmentCheckInterval = EraDuration.FromYears(10f),
                GeneralSealInitialPercent = 100f,
                GeneralSealDecayPercentPerYear = 1f,
                DemonSealInitialPercent = 100f,
                DemonSealDecayPercentPerYear = 1f,
            },
            Demons = new EraDemonParameters
            {
                EnabledDemons = new[]
                {
                    EraDemonKind.VoidLord,
                    EraDemonKind.PlagueMother,
                    EraDemonKind.MechTyrant,
                    EraDemonKind.TimeDistorter,
                    EraDemonKind.ChaosFlame,
                    EraDemonKind.AbyssGod,
                    EraDemonKind.DeathKing,
                    EraDemonKind.SoulWeaver,
                    EraDemonKind.NatureWrath,
                    EraDemonKind.FinalJudge,
                },
                AwakeningCount = 1,
                InteractionMode = EraDemonInteractionMode.Random,
                RelationshipCheckInterval = EraDuration.FromYears(3f),
                AllianceStrengthPercent = 85f,
                CivilWarStrengthPercent = 100f,
                CivilWarMaxDemons = 5,
                CivilWarWinnerBonusDuration = EraDuration.FromYears(10f),
                CivilWarWinnerBonusPercent = 10f,
            },
            Legions = new EraLegionParameters
            {
                SpawnInterval = EraDuration.FromYears(10f),
                InitialCount = 40,
                ConcurrentLimit = 300,
                GrowthPercentPerWave = 15f,
            },
            Advancement = new EraAdvancementParameters
            {
                MaxTier = 10,
                TierIncreasePerCycle = 1,
                ProgressionMode = EraWorldTierProgressionMode.AutoAdvance,
                ManualWorldTier = 1,
                KingdomTierMode = EraKingdomTierMode.AllUseKingdomTier,
                Control = new EraControlProfile
                {
                    NewKingdomFloorTier = 1,
                    RefreshInterval = EraDuration.FromYears(10f),
                    BaseScore = 0.20f,
                    Cities = new EraControlMetric
                    {
                        Threshold = 5,
                        Weight = 0.20f,
                    },
                    Population = new EraControlMetric
                    {
                        Threshold = 688,
                        Weight = 0.20f,
                    },
                    Military = new EraControlMetric
                    {
                        Threshold = 200,
                        Weight = 0.20f,
                    },
                    Books = new EraControlMetric
                    {
                        Threshold = 6,
                        Weight = 0.20f,
                    },
                },
                DemonEquipmentRefreshInterval = EraDuration.FromYears(7f),
                RandomAttributes = new EraRandomAttributeProfile
                {
                    CandidateAttributeIds = new[]
                    {
                        EraAttributeIds.MultiplierDamage,
                        EraAttributeIds.MultiplierAttackSpeed,
                        EraAttributeIds.CriticalChance,
                        EraAttributeIds.CriticalDamageMultiplier,
                        EraAttributeIds.ThrowingRange,
                        EraAttributeIds.Range,
                        EraAttributeIds.AreaOfEffect,
                        EraAttributeIds.Knockback,
                        EraAttributeIds.MultiplierHealth,
                        EraAttributeIds.Armor,
                        EraAttributeIds.MultiplierStamina,
                        EraAttributeIds.MultiplierMana,
                        EraAttributeIds.MaxNutrition,
                        EraAttributeIds.Happiness,
                        EraAttributeIds.MultiplierLifespan,
                        EraAttributeIds.MultiplierSpeed,
                        EraAttributeIds.Mass,
                        EraAttributeIds.MultiplierMass,
                        EraAttributeIds.SkillCombat,
                        EraAttributeIds.SkillSpell,
                        EraAttributeIds.MultiplierDiplomacy,
                        EraAttributeIds.Warfare,
                        EraAttributeIds.Stewardship,
                        EraAttributeIds.Intelligence,
                    },
                    EquipmentAttributesPerItem = 6,
                    TraitAttributesPerItem = 6,
                    AttributeRanges = CreateRangeMap(
                        (EraAttributeIds.MultiplierDamage, 50f, 200f),
                        (EraAttributeIds.MultiplierAttackSpeed, 50f, 150f),
                        (EraAttributeIds.CriticalChance, 5f, 15f),
                        (EraAttributeIds.CriticalDamageMultiplier, 10f, 100f),
                        (EraAttributeIds.ThrowingRange, 1f, 5f),
                        (EraAttributeIds.Range, 1f, 5f),
                        (EraAttributeIds.AreaOfEffect, 1f, 5f),
                        (EraAttributeIds.Knockback, 1f, 5f),
                        (EraAttributeIds.MultiplierHealth, 50f, 150f),
                        (EraAttributeIds.Armor, 2f, 8f),
                        (EraAttributeIds.MultiplierStamina, 50f, 200f),
                        (EraAttributeIds.MultiplierMana, 50f, 200f),
                        (EraAttributeIds.MaxNutrition, 1f, 200f),
                        (EraAttributeIds.Happiness, 1f, 200f),
                        (EraAttributeIds.MultiplierLifespan, 100f, 200f),
                        (EraAttributeIds.MultiplierSpeed, 30f, 200f),
                        (EraAttributeIds.Mass, 0.3f, 1f),
                        (EraAttributeIds.MultiplierMass, 10f, 100f),
                        (EraAttributeIds.SkillCombat, 1f, 15f),
                        (EraAttributeIds.SkillSpell, 1f, 15f),
                        (EraAttributeIds.MultiplierDiplomacy, 10f, 200f),
                        (EraAttributeIds.Warfare, 2f, 10f),
                        (EraAttributeIds.Stewardship, 2f, 10f),
                        (EraAttributeIds.Intelligence, 2f, 10f)
                    ),
                },
            },
            Levels = new EraLevelParameters
            {
                RandomAttributes = new EraLevelRandomProfile
                {
                    CandidateAttributeIds = new[]
                    {
                        EraAttributeIds.Damage,
                        EraAttributeIds.AttackSpeed,
                        EraAttributeIds.CriticalChance,
                        EraAttributeIds.ThrowingRange,
                        EraAttributeIds.Knockback,
                        EraAttributeIds.Health,
                        EraAttributeIds.Armor,
                        EraAttributeIds.Stamina,
                        EraAttributeIds.Mana,
                        EraAttributeIds.Lifespan,
                        EraAttributeIds.Speed,
                        EraAttributeIds.Mass,
                        EraAttributeIds.SkillCombat,
                        EraAttributeIds.SkillSpell,
                        EraAttributeIds.Diplomacy,
                        EraAttributeIds.Warfare,
                        EraAttributeIds.Stewardship,
                        EraAttributeIds.Intelligence,
                    },
                    AttributesPerLevel = 2,
                    AttributeValues = CreateValueMap(
                        (EraAttributeIds.Damage, 50f),
                        (EraAttributeIds.AttackSpeed, 1f),
                        (EraAttributeIds.CriticalChance, 3f),
                        (EraAttributeIds.ThrowingRange, 1f),
                        (EraAttributeIds.Knockback, 1f),
                        (EraAttributeIds.Health, 2000f),
                        (EraAttributeIds.Armor, 2f),
                        (EraAttributeIds.Stamina, 100f),
                        (EraAttributeIds.Mana, 100f),
                        (EraAttributeIds.Lifespan, 100f),
                        (EraAttributeIds.Speed, 50f),
                        (EraAttributeIds.Mass, 0.2f),
                        (EraAttributeIds.SkillCombat, 5f),
                        (EraAttributeIds.SkillSpell, 5f),
                        (EraAttributeIds.Diplomacy, 3f),
                        (EraAttributeIds.Warfare, 3f),
                        (EraAttributeIds.Stewardship, 3f),
                        (EraAttributeIds.Intelligence, 3f)
                    ),
                },
            },
            Kingdoms = new EraKingdomParameters
            {
                MaxLevel = 99,
                RenownBands = new[]
                {
                    new EraKingdomRenownBand
                    {
                        StartLevel = 1,
                        EndLevel = 5,
                        RenownPerLevel = 300,
                    },
                    new EraKingdomRenownBand
                    {
                        StartLevel = 6,
                        EndLevel = 15,
                        RenownPerLevel = 500,
                    },
                    new EraKingdomRenownBand
                    {
                        StartLevel = 16,
                        EndLevel = 99,
                        RenownPerLevel = 800,
                    },
                },
                RandomAttributes = new EraLevelRandomProfile
                {
                    CandidateAttributeIds = new[]
                    {
                        EraAttributeIds.MultiplierDamage,
                        EraAttributeIds.MultiplierAttackSpeed,
                        EraAttributeIds.CriticalChance,
                        EraAttributeIds.CriticalDamageMultiplier,
                        EraAttributeIds.ThrowingRange,
                        EraAttributeIds.Knockback,
                        EraAttributeIds.MultiplierHealth,
                        EraAttributeIds.Armor,
                        EraAttributeIds.MultiplierStamina,
                        EraAttributeIds.MultiplierMana,
                        EraAttributeIds.MaxNutrition,
                        EraAttributeIds.Happiness,
                        EraAttributeIds.MultiplierLifespan,
                        EraAttributeIds.MultiplierSpeed,
                        EraAttributeIds.Mass,
                        EraAttributeIds.MultiplierMass,
                        EraAttributeIds.SkillCombat,
                        EraAttributeIds.SkillSpell,
                        EraAttributeIds.MultiplierDiplomacy,
                        EraAttributeIds.Warfare,
                        EraAttributeIds.Stewardship,
                        EraAttributeIds.Intelligence,
                    },
                    AttributesPerLevel = 2,
                    AttributeValues = CreateValueMap(
                        (EraAttributeIds.MultiplierDamage, 50f),
                        (EraAttributeIds.MultiplierAttackSpeed, 50f),
                        (EraAttributeIds.CriticalChance, 5f),
                        (EraAttributeIds.CriticalDamageMultiplier, 20f),
                        (EraAttributeIds.ThrowingRange, 1f),
                        (EraAttributeIds.Knockback, 1f),
                        (EraAttributeIds.MultiplierHealth, 50f),
                        (EraAttributeIds.Armor, 2f),
                        (EraAttributeIds.MultiplierStamina, 50f),
                        (EraAttributeIds.MultiplierMana, 50f),
                        (EraAttributeIds.MaxNutrition, 3f),
                        (EraAttributeIds.Happiness, 10f),
                        (EraAttributeIds.MultiplierLifespan, 50f),
                        (EraAttributeIds.MultiplierSpeed, 30f),
                        (EraAttributeIds.Mass, 1f),
                        (EraAttributeIds.MultiplierMass, 20f),
                        (EraAttributeIds.SkillCombat, 3f),
                        (EraAttributeIds.SkillSpell, 3f),
                        (EraAttributeIds.MultiplierDiplomacy, 30f),
                        (EraAttributeIds.Warfare, 2f),
                        (EraAttributeIds.Stewardship, 2f),
                        (EraAttributeIds.Intelligence, 2f)
                    ),
                },
            },
            Heroes = new EraHeroParameters
            {
                HeroesPerKingdomLimit = 3,
                HeroesWorldLimit = 50,
                ProsperityPopulationGrowthThreshold = 200,
                CrisisWindow = EraDuration.FromYears(10f),
                CrisisPopulationLossPercent = 50f,
                ScoreProfile = new EraHeroScoreProfile
                {
                    LevelWeight = 0.25f,
                    KillWeight = 0.10f,
                    HealthWeight = 0.25f,
                    DamageWeight = 0.25f,
                    WarfareWeight = 0.15f,
                    LevelThreshold = 10,
                    KillThreshold = 50,
                    HealthThreshold = 1000,
                    DamageThreshold = 100,
                    WarfareThreshold = 100,
                },
                RandomTopCandidateCount = 3,
                SurvivorBonusEnabled = true,
                SurvivorBonusPercentPerCycle = 10f,
                SurvivorBonusCapPercent = 200f,
                BloodlineInheritanceChancePercent = 30f,
                BloodlineInheritanceValuePercent = 30f,
                BloodlineGenerationLimit = 10,
                AwakenedScoreBonusPercent = 5f,
            },
            Growth = new EraGrowthParameters
            {
                DemonBaseRanges = CreateRangeMap(
                    (EraAttributeIds.Health, 4000000f, 5000000f),
                    (EraAttributeIds.Lifespan, 99999f, 99999f),
                    (EraAttributeIds.Armor, 15f, 30f),
                    (EraAttributeIds.Damage, 4000f, 5000f),
                    (EraAttributeIds.Mana, 1000f, 2000f),
                    (EraAttributeIds.Stamina, 3000f, 5000f),
                    (EraAttributeIds.CriticalChance, 10f, 20f),
                    (EraAttributeIds.Speed, 200f, 300f),
                    (EraAttributeIds.AttackSpeed, 3.5f, 7f),
                    (EraAttributeIds.Knockback, 3f, 4.5f),
                    (EraAttributeIds.Scale, 0.006f, 0.006f),
                    (EraAttributeIds.Mass, 1f, 3f),
                    (EraAttributeIds.Mass2, 3333f, 6667f)
                ),
                GeneralBaseRanges = CreateRangeMap(
                    (EraAttributeIds.Health, 1800000f, 2800000f),
                    (EraAttributeIds.Lifespan, 99999f, 99999f),
                    (EraAttributeIds.Armor, 10f, 20f),
                    (EraAttributeIds.Damage, 1800f, 2800f),
                    (EraAttributeIds.Mana, 800f, 1200f),
                    (EraAttributeIds.Stamina, 1000f, 3000f),
                    (EraAttributeIds.CriticalChance, 10f, 20f),
                    (EraAttributeIds.Speed, 100f, 200f),
                    (EraAttributeIds.AttackSpeed, 2f, 5f),
                    (EraAttributeIds.Knockback, 2.6f, 3.5f),
                    (EraAttributeIds.Scale, 0.005f, 0.005f),
                    (EraAttributeIds.Mass, 1f, 3f),
                    (EraAttributeIds.Mass2, 1000f, 3000f)
                ),
                HeroPromotionRanges = CreateRangeMap(
                    (EraAttributeIds.Health, 360000f, 500000f),
                    (EraAttributeIds.Lifespan, 300f, 500f),
                    (EraAttributeIds.Armor, 10f, 20f),
                    (EraAttributeIds.Damage, 500f, 1000f),
                    (EraAttributeIds.Mana, 700f, 1300f),
                    (EraAttributeIds.Stamina, 1000f, 3000f),
                    (EraAttributeIds.CriticalChance, 10f, 20f),
                    (EraAttributeIds.Speed, 100f, 220f),
                    (EraAttributeIds.AttackSpeed, 2f, 5f),
                    (EraAttributeIds.Knockback, 2.6f, 3.5f),
                    (EraAttributeIds.Scale, 0.1f, 0.1f),
                    (EraAttributeIds.Mass, 1f, 3f),
                    (EraAttributeIds.Mass2, 0f, 0f)
                ),
                LegionBaseRanges = CreateRangeMap(
                    (EraAttributeIds.Health, 5000f, 10000f),
                    (EraAttributeIds.Lifespan, 99999f, 99999f),
                    (EraAttributeIds.Armor, 1f, 10f),
                    (EraAttributeIds.Damage, 20f, 100f),
                    (EraAttributeIds.Mana, 50f, 200f),
                    (EraAttributeIds.Stamina, 100f, 500f),
                    (EraAttributeIds.CriticalChance, 2f, 7f),
                    (EraAttributeIds.Speed, 15f, 30f),
                    (EraAttributeIds.AttackSpeed, 0.7f, 1.5f),
                    (EraAttributeIds.Knockback, 1f, 2f),
                    (EraAttributeIds.Scale, 0.004f, 0.004f),
                    (EraAttributeIds.Mass, 1f, 1.6f),
                    (EraAttributeIds.Mass2, 833f, 2500f)
                ),
            },
        };
    }

    private static Dictionary<string, EraFloatRange> CreateRangeMap(params (string Key, float Min, float Max)[] items)
    {
        Dictionary<string, EraFloatRange> map = new Dictionary<string, EraFloatRange>(StringComparer.Ordinal);
        foreach ((string key, float min, float max) in items)
        {
            map[key] = new EraFloatRange
            {
                Min = min,
                Max = max,
            };
        }

        return map;
    }

    private static Dictionary<string, float> CreateValueMap(params (string Key, float Value)[] items)
    {
        Dictionary<string, float> map = new Dictionary<string, float>(StringComparer.Ordinal);
        foreach ((string key, float value) in items)
        {
            map[key] = value;
        }

        return map;
    }
}
