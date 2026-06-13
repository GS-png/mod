using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EraWheel.Config.Migration;
using EraWheel.Config.Registry;
using EraWheel.Core.Constants;
using EraWheel.Data.Definitions;
using EraWheel.Data.Registration;
using EraWheel.Save.Keys;
using EraWheel.Save.Models;

namespace EraWheel.Core.Validation;

public static class EraStartupValidator
{
    private const string ExpectedHeritageRandomPoolId = "advancement.shared_default";

    private static readonly HashSet<string> AllowedEquipmentSlots = new HashSet<string>
    {
        "刀剑",
        "斧头",
        "长矛",
        "弓箭",
        "锤子",
        "法杖",
        "枪械",
        "头盔",
        "盔甲",
        "靴子",
        "戒指",
        "护符",
    };

    public static EraValidationReport Validate(
        string modRootPath,
        EraParameterRegistry registry,
        EraContentCatalog catalog,
        EraConfigMigrator configMigrator,
        EraConfigBackupPolicy backupPolicy
    )
    {
        List<EraValidationIssue> issues = new List<EraValidationIssue>();
        ValidateConfigRegistry(registry, issues);
        ValidateConfigVersioning(configMigrator, backupPolicy, issues);
        ValidateEntityCustomDataKeys(issues);
        ValidateCatalogCounts(catalog, issues);
        ValidateCatalog(catalog, modRootPath, registry.Current.Advancement.MaxTier, issues);
        return new EraValidationReport(issues);
    }

    public static EraValidationReport ValidateRuntimeState(EraContentCatalog catalog)
    {
        List<EraValidationIssue> issues = new List<EraValidationIssue>();
        ValidateRegisteredHeritageEquipmentAssets(catalog.HeritageEquipment, issues);
        ValidateAdvancementDisplayableBaseStats(issues);
        return new EraValidationReport(issues);
    }

    private static void ValidateConfigRegistry(EraParameterRegistry registry, List<EraValidationIssue> issues)
    {
        if (registry.Current.Advancement.MaxTier < 1)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "轮回阶位上限必须 >= 1。"));
        }

        if (registry.Current.Demons.AwakeningCount < 1)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "苏醒数量必须 >= 1。"));
        }

        if (registry.Current.Legions.ConcurrentLimit < registry.Current.Legions.InitialCount)
        {
            issues.Add(
                new EraValidationIssue(
                    EraValidationSeverity.Warning,
                    "Config",
                    "军团同时上限小于初始数量，首波会被直接裁剪。"
                )
            );
        }

        if (registry.Current.Heroes.HeroesPerKingdomLimit < 0 || registry.Current.Heroes.HeroesWorldLimit < 0)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "英雄上限不能为负数。"));
        }

        if (registry.Current.Kingdoms.RenownBands.Count != 3)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Warning, "Config", "当前王国声望分段数量不是设计文档里的 3 段。"));
        }

        HashSet<EraDemonKind> enabledDemons = new HashSet<EraDemonKind>(registry.Current.Demons.EnabledDemons);
        if (enabledDemons.Count == 0)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "启用魔王池不能为空，否则预兆阶段无法确定本轮魔王名单。"));
        }

        if (enabledDemons.Count != registry.Current.Demons.EnabledDemons.Count)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "启用魔王池里出现了重复条目。"));
        }

        ValidateReincarnationParameters(registry, issues);
        ValidateDemonParameters(registry, issues);
        ValidateLegionParameters(registry, issues);
        ValidateAdvancementParameters(registry, issues);
        ValidateKingdomParameters(registry, issues);
        ValidateHeroParameters(registry, issues);
        ValidateGrowthRanges(registry, issues);
    }

    private static void ValidateConfigVersioning(
        EraConfigMigrator configMigrator,
        EraConfigBackupPolicy backupPolicy,
        List<EraValidationIssue> issues
    )
    {
        if (backupPolicy.MaxBackupCount < 1)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "ConfigVersion", "备份保留数量必须 >= 1。"));
        }

        try
        {
            configMigrator.Migrate(
                new EraConfigDocument
                {
                    ConfigVersion = 0,
                }
            );
        }
        catch (System.Exception exception)
        {
            issues.Add(
                new EraValidationIssue(
                    EraValidationSeverity.Error,
                    "ConfigVersion",
                    $"配置迁移器无法处理旧版 config_version：{exception.Message}"
                )
            );
        }
    }

    private static void ValidateEntityCustomDataKeys(List<EraValidationIssue> issues)
    {
        HashSet<string> keys = new HashSet<string>();
        foreach (EraEntityCustomDataKey key in EraEntityCustomDataKeys.All)
        {
            if (!keys.Add(key.Key))
            {
                issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "CustomData", $"发现重复实体自定义键：{key.Key}。"));
            }
        }
    }

    private static void ValidateReincarnationParameters(EraParameterRegistry registry, List<EraValidationIssue> issues)
    {
        if (registry.Current.Reincarnation.PreDevelopmentCheckInterval.Years <= 0f)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "预发展检查间隔必须 > 0 年。"));
        }

        if (registry.Current.Reincarnation.GeneralSealDecayPercentPerYear < 0f)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "将领封印衰减速率不能为负数。"));
        }

        if (registry.Current.Reincarnation.DemonSealDecayPercentPerYear < 0f)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "魔王封印衰减速率不能为负数。"));
        }

        if (registry.Current.Reincarnation.GeneralSealDecayPercentPerYear == 0f)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Warning, "Config", "将领封印衰减速率为 0，将领先置阶段不会自然推进。"));
        }

        if (registry.Current.Reincarnation.DemonSealDecayPercentPerYear == 0f)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Warning, "Config", "魔王封印衰减速率为 0，降临阶段不会自然到来。"));
        }
    }

    private static void ValidateDemonParameters(EraParameterRegistry registry, List<EraValidationIssue> issues)
    {
        if (registry.Current.Demons.CivilWarMaxDemons < 1)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "内战最大魔王数必须 >= 1。"));
        }

        if (registry.Current.Demons.CivilWarWinnerBonusDuration.Years < 0f)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "内战胜者加成时长不能为负数。"));
        }

        if (registry.Current.Demons.CivilWarWinnerBonusPercent < 0f)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "内战胜者加成比例不能为负数。"));
        }

        if (registry.Current.Demons.InteractionMode == EraDemonInteractionMode.Random &&
            registry.Current.Demons.RelationshipCheckInterval.Years <= 0f)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "随机互动模式下，关系校验间隔必须 > 0 年。"));
        }
    }

    private static void ValidateLegionParameters(EraParameterRegistry registry, List<EraValidationIssue> issues)
    {
        if (registry.Current.Legions.SpawnInterval.Years <= 0f)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "军团生成间隔必须 > 0 年。"));
        }

        if (registry.Current.Legions.InitialCount < 1)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "军团初始数量必须 >= 1。"));
        }

        if (registry.Current.Legions.ConcurrentLimit < 1)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "军团同时上限必须 >= 1。"));
        }

        if (registry.Current.Legions.GrowthPercentPerWave < 0f)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "波次数量递增不能为负数。"));
        }
    }

    private static void ValidateAdvancementParameters(EraParameterRegistry registry, List<EraValidationIssue> issues)
    {
        if (registry.Current.Advancement.TierIncreasePerCycle < 0)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "每轮回档位提升不能为负数。"));
        }

        if (registry.Current.Advancement.ManualWorldTier < 1 ||
            registry.Current.Advancement.ManualWorldTier > registry.Current.Advancement.MaxTier)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "手动世界档位必须落在 1~轮回阶位上限。"));
        }

        if (registry.Current.Advancement.DemonEquipmentRefreshInterval.Years <= 0f)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "魔王装备刷新间隔必须 > 0 年。"));
        }

        if (registry.Current.Advancement.Control.NewKingdomFloorTier < 1 ||
            registry.Current.Advancement.Control.NewKingdomFloorTier > registry.Current.Advancement.MaxTier)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "新王国档位下限必须落在 1~轮回阶位上限。"));
        }

        if (registry.Current.Advancement.KingdomTierMode != EraKingdomTierMode.AllUseWorldTier &&
            registry.Current.Advancement.Control.RefreshInterval.Years <= 0f)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "使用王国档位模式时，掌控度刷新间隔必须 > 0 年。"));
        }

        if (registry.Current.Advancement.Control.BaseScore < 0f)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "掌控度基础分不能为负数。"));
        }

        ValidateControlMetric("城市", registry.Current.Advancement.Control.Cities, issues);
        ValidateControlMetric("人口", registry.Current.Advancement.Control.Population, issues);
        ValidateControlMetric("军力", registry.Current.Advancement.Control.Military, issues);
        ValidateControlMetric("书籍", registry.Current.Advancement.Control.Books, issues);

        ValidateAttributeRangeProfile("轮回装备/特质随机区间", registry.Current.Advancement.RandomAttributes.AttributeRanges, issues);
        ValidateCandidatePool(
            "轮回装备/特质随机属性候选",
            registry.Current.Advancement.RandomAttributes.CandidateAttributeIds,
            registry.Current.Advancement.RandomAttributes.EquipmentAttributesPerItem > 0 ||
            registry.Current.Advancement.RandomAttributes.TraitAttributesPerItem > 0,
            issues);
        if (registry.Current.Advancement.RandomAttributes.EquipmentAttributesPerItem < 0)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "每件装备随机属性数不能为负数。"));
        }

        if (registry.Current.Advancement.RandomAttributes.TraitAttributesPerItem < 0)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "每条特质随机属性数不能为负数。"));
        }
    }

    private static void ValidateKingdomParameters(EraParameterRegistry registry, List<EraValidationIssue> issues)
    {
        if (registry.Current.Kingdoms.MaxLevel < 1)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "王国声望等级上限必须 >= 1。"));
        }

        ValidateRenownBands(registry, issues);
        ValidateCandidatePool(
            "王国声望随机属性候选",
            registry.Current.Kingdoms.RandomAttributes.CandidateAttributeIds,
            registry.Current.Kingdoms.RandomAttributes.AttributesPerLevel > 0,
            issues);
        if (registry.Current.Kingdoms.RandomAttributes.AttributesPerLevel < 0)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "王国每级随机属性数不能为负数。"));
        }
    }

    private static void ValidateHeroParameters(EraParameterRegistry registry, List<EraValidationIssue> issues)
    {
        if (registry.Current.Heroes.HeroesPerKingdomLimit > registry.Current.Heroes.HeroesWorldLimit &&
            registry.Current.Heroes.HeroesWorldLimit >= 0)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Warning, "Config", "每王国英雄上限大于世界总英雄上限，单王国永远无法吃满。"));
        }

        if (registry.Current.Heroes.ProsperityPopulationGrowthThreshold < 1)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "王国每次人口增长阈值必须 >= 1。"));
        }

        if (registry.Current.Heroes.CrisisWindow.Years <= 0f)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "危机统计窗口必须 > 0 年。"));
        }

        if (registry.Current.Heroes.CrisisPopulationLossPercent <= 0f ||
            registry.Current.Heroes.CrisisPopulationLossPercent > 100f)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "王国人口跌幅必须落在 0%~100% 之间，且不能为 0。"));
        }

        if (registry.Current.Heroes.RandomTopCandidateCount < 1)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "从评分前 N 名随机时，N 必须 >= 1。"));
        }

        if (registry.Current.Heroes.SurvivorBonusPercentPerCycle < 0f)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "每轮幸存强化比例不能为负数。"));
        }

        if (registry.Current.Heroes.SurvivorBonusCapPercent < 0f)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "幸存强化上限不能为负数。"));
        }

        if (registry.Current.Heroes.SurvivorBonusCapPercent < registry.Current.Heroes.SurvivorBonusPercentPerCycle)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Warning, "Config", "幸存强化上限小于单轮强化比例，第一次结算后就会直接封顶。"));
        }

        ValidatePercent("家族继承触发概率", registry.Current.Heroes.BloodlineInheritanceChancePercent, issues);
        ValidatePercent("继承属性比例", registry.Current.Heroes.BloodlineInheritanceValuePercent, issues);

        if (registry.Current.Heroes.BloodlineGenerationLimit < 0)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "可继承代数不能为负数。"));
        }

        if (registry.Current.Heroes.AwakenedScoreBonusPercent < 0f)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "觉醒评分加成不能为负数。"));
        }

        ValidateCandidatePool(
            "等级随机属性候选",
            registry.Current.Levels.RandomAttributes.CandidateAttributeIds,
            registry.Current.Levels.RandomAttributes.AttributesPerLevel > 0,
            issues);
        if (registry.Current.Levels.RandomAttributes.AttributesPerLevel < 0)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "每级随机属性数不能为负数。"));
        }
    }

    private static void ValidateGrowthRanges(EraParameterRegistry registry, List<EraValidationIssue> issues)
    {
        ValidateAttributeRangeProfile("魔王生成基础范围", registry.Current.Growth.DemonBaseRanges, issues);
        ValidateAttributeRangeProfile("将领生成基础范围", registry.Current.Growth.GeneralBaseRanges, issues);
        ValidateAttributeRangeProfile("英雄晋升基础范围", registry.Current.Growth.HeroPromotionRanges, issues);
        ValidateAttributeRangeProfile("军团出波基础范围", registry.Current.Growth.LegionBaseRanges, issues);
    }

    private static void ValidateCatalog(
        EraContentCatalog catalog,
        string modRootPath,
        int maxTier,
        List<EraValidationIssue> issues
    )
    {
        ValidateUniqueIds(catalog.Demons.Select(item => item.InternalId), "Demon", issues);
        ValidateUniqueIds(catalog.Generals.Select(item => item.InternalId), "General", issues);
        ValidateUniqueIds(catalog.Legions.Select(item => item.InternalId), "Legion", issues);
        ValidateUniqueIds(catalog.Strongholds.Select(item => item.BuildingId), "Stronghold", issues);
        ValidateUniqueIds(catalog.PublicTraits.Select(item => item.TraitId), "PublicTrait", issues);
        ValidateUniqueIds(catalog.HeritageEquipment.Select(item => item.EquipmentId), "HeritageEquipment", issues);
        ValidateUniqueIds(catalog.HeritageTraits.Select(item => item.TraitId), "HeritageTrait", issues);

        foreach (EraDemonManifest demon in catalog.Demons)
        {
            ValidateRequiredText("Demon", demon.InternalId, demon.DisplayName, issues);
            ValidateRequiredText("Demon", demon.InternalId, demon.CoreMechanic, issues);
            ValidateRequiredText("Demon", demon.InternalId, demon.CombatKeywords, issues);
            ValidateIconPath("Demon", demon.InternalId, modRootPath, demon.UnitIconSourcePath, issues);
            ValidateIconPath("Demon", demon.InternalId, modRootPath, demon.StrongholdIconSourcePath, issues);
        }

        if (!AssetManager.actor_library.has(EraWorldboxAssetIds.MobNoGenesTemplate))
        {
            issues.Add(
                new EraValidationIssue(
                    EraValidationSeverity.Error,
                    "ActorTemplate",
                    $"缺少单位母版：{EraWorldboxAssetIds.MobNoGenesTemplate}。"
                )
            );
        }

        foreach (EraGeneralManifest general in catalog.Generals)
        {
            ValidateRequiredText("General", general.InternalId, general.DisplayName, issues);
            ValidateIconPath("General", general.InternalId, modRootPath, general.IconSourcePath, issues);
            if (!catalog.DemonsById.ContainsKey(general.DemonInternalId))
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "General",
                        $"将领 {general.InternalId} 绑定了未知魔王 ID：{general.DemonInternalId}。"
                    )
                );
            }
        }

        foreach (EraDemonManifest demon in catalog.Demons)
        {
            int generalCount = catalog.Generals.Count(item => item.DemonInternalId == demon.InternalId);
            if (generalCount != 5)
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "General",
                        $"魔王 {demon.InternalId} 当前绑定将领数量为 {generalCount}，不等于设计要求的 5 名。"
                    )
                );
            }
        }

        foreach (EraLegionManifest legion in catalog.Legions)
        {
            ValidateRequiredText("Legion", legion.InternalId, legion.DisplayName, issues);
            ValidateRequiredText("Legion", legion.InternalId, legion.UnitGroupKey, issues);
            ValidateRequiredText("Legion", legion.InternalId, legion.BaseTemplateId, issues);
            ValidateIconPath("Legion", legion.InternalId, modRootPath, legion.IconSourcePath, issues);
            if (!catalog.DemonsById.ContainsKey(legion.DemonInternalId))
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "Legion",
                        $"军团 {legion.InternalId} 绑定了未知魔王 ID：{legion.DemonInternalId}。"
                    )
                );
            }
        }

        foreach (EraStrongholdManifest stronghold in catalog.Strongholds)
        {
            ValidateRequiredText("Stronghold", stronghold.BuildingId, stronghold.DisplayName, issues);
            ValidateIconPath("Stronghold", stronghold.BuildingId, modRootPath, stronghold.IconSourcePath, issues);
            if (!catalog.DemonsById.ContainsKey(stronghold.DemonInternalId))
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "Stronghold",
                        $"据点 {stronghold.BuildingId} 绑定了未知魔王 ID：{stronghold.DemonInternalId}。"
                    )
                );
            }

            if (stronghold.Placement.ArtFootprintWidth != 7 || stronghold.Placement.ArtFootprintHeight != 3)
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "Stronghold",
                        $"据点 {stronghold.BuildingId} 的美术底座不是设计要求的 7x3。"
                    )
                );
            }

            if (stronghold.Placement.FundamentLeft != 3 ||
                stronghold.Placement.FundamentRight != 3 ||
                stronghold.Placement.FundamentTop != 2 ||
                stronghold.Placement.FundamentBottom != 0)
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "Stronghold",
                        $"据点 {stronghold.BuildingId} 的 BuildingFundament 不是设计要求的 (3,3,2,0)。"
                    )
                );
            }
        }

        foreach (EraPublicTraitManifest trait in catalog.PublicTraits)
        {
            ValidateRequiredText("PublicTrait", trait.TraitId, trait.DisplayName, issues);
            ValidateRequiredText("PublicTrait", trait.TraitId, trait.Summary, issues);
            ValidateRequiredText("PublicTrait", trait.TraitId, trait.GrantConfig, issues);
            ValidateIconPath("PublicTrait", trait.TraitId, modRootPath, trait.IconSourcePath, issues);
        }

        ValidateHeritageEquipmentSlotSpecs(issues);
        foreach (EraHeritageEquipmentManifest equipment in catalog.HeritageEquipment)
        {
            ValidateRequiredText("HeritageEquipment", equipment.EquipmentId, equipment.DisplayName, issues);
            ValidateRequiredText("HeritageEquipment", equipment.EquipmentId, equipment.Slot, issues);
            ValidateRequiredText("HeritageEquipment", equipment.EquipmentId, equipment.TriggerText, issues);
            ValidateRequiredText("HeritageEquipment", equipment.EquipmentId, equipment.Summary, issues);
            ValidateHeritageTrigger("HeritageEquipment", equipment.EquipmentId, equipment.Trigger, issues);
            ValidateHeritageRandomAttributes("HeritageEquipment", equipment.EquipmentId, equipment.RandomAttributes, issues);
            ValidateHeritageEffectParameters("HeritageEquipment", equipment.EquipmentId, equipment.EffectParameters, issues);
            ValidateHeritagePresentation("HeritageEquipment", equipment.EquipmentId, equipment, issues);
            if (equipment.UnlockTier < 1 || equipment.UnlockTier > maxTier)
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipment",
                        $"装备 {equipment.EquipmentId} 的 unlock_tier={equipment.UnlockTier} 超出 1-{maxTier}。"
                    )
                );
            }

            if (!AllowedEquipmentSlots.Contains(equipment.Slot))
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipment",
                        $"装备 {equipment.EquipmentId} 使用了未登记槽位：{equipment.Slot}。"
                    )
                );
            }

            if (!EraHeritageEquipmentSlotSpecs.TryGet(equipment.SlotKind, out EraHeritageEquipmentSlotSpec slotSpec))
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipment",
                        $"装备 {equipment.EquipmentId} 缺少槽位规格：{equipment.SlotKind}。"
                    )
                );
            }

            ValidateRequiredText("HeritageEquipment", equipment.EquipmentId, equipment.BaseTemplateId, issues);
            if (!string.IsNullOrWhiteSpace(equipment.BaseTemplateId) && !AssetManager.items.has(equipment.BaseTemplateId))
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipment",
                        $"装备 {equipment.EquipmentId} 绑定了未知母版：{equipment.BaseTemplateId}。"
                    )
                );
            }

            if (EraHeritageEquipmentSlotSpecs.TryGet(equipment.SlotKind, out slotSpec))
            {
                ValidateRequiredText("HeritageEquipment", equipment.EquipmentId, slotSpec.VisualReferenceAssetId, issues);
                if (!string.IsNullOrWhiteSpace(slotSpec.VisualReferenceAssetId) &&
                    !AssetManager.items.has(slotSpec.VisualReferenceAssetId))
                {
                    issues.Add(
                        new EraValidationIssue(
                            EraValidationSeverity.Error,
                            "HeritageEquipment",
                            $"装备 {equipment.EquipmentId} 绑定了未知外观引用：{slotSpec.VisualReferenceAssetId}。"
                        )
                    );
                }
            }

            ValidateRequiredText("HeritageEquipment", equipment.EquipmentId, equipment.PrimaryResourceId, issues);
            ValidateResource("HeritageEquipment", equipment.EquipmentId, equipment.PrimaryResourceId, issues);
            ValidateResource("HeritageEquipment", equipment.EquipmentId, equipment.SecondaryResourceId, issues);
            if (equipment.PrimaryResourceCost < 1)
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipment",
                        $"装备 {equipment.EquipmentId} 的主材数量必须 >= 1。"
                    )
                );
            }

            if (equipment.SecondaryResourceCost < 1)
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipment",
                        $"装备 {equipment.EquipmentId} 的副材数量必须 >= 1。"
                    )
                );
            }

            if (equipment.PrimaryResourceId == equipment.SecondaryResourceId)
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipment",
                        $"装备 {equipment.EquipmentId} 的主材和副材不能相同。"
                    )
                );
            }

            if (equipment.GoldCost < 0)
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipment",
                        $"装备 {equipment.EquipmentId} 的金币成本不能为负数。"
                    )
                );
            }

            if (equipment.MinimumCityStorageResource1 < 0)
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipment",
                        $"装备 {equipment.EquipmentId} 的城市库存门槛不能为负数。"
                    )
                );
            }

            if (equipment.EquipmentValue < 1)
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipment",
                        $"装备 {equipment.EquipmentId} 的 equipment_value 必须 >= 1。"
                    )
                );
            }

            ValidateIconPath("HeritageEquipment", equipment.EquipmentId, modRootPath, equipment.IconSourcePath, issues);
        }

        foreach (EraHeritageTraitManifest trait in catalog.HeritageTraits)
        {
            ValidateRequiredText("HeritageTrait", trait.TraitId, trait.DisplayName, issues);
            ValidateRequiredText("HeritageTrait", trait.TraitId, trait.Summary, issues);
            if (trait.Granting == null)
            {
                issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "HeritageTrait", $"{trait.TraitId} 缺少授予配置。"));
            }
            else
            {
                if (trait.Granting.BirthWeight < 0 || trait.Granting.InheritWeight < 0 || trait.Granting.GrowthWeight < 0)
                {
                    issues.Add(
                        new EraValidationIssue(
                            EraValidationSeverity.Error,
                            "HeritageTrait",
                            $"{trait.TraitId} 的出生/遗传/成长签数不能为负数。"
                        )
                    );
                }

                if (!trait.Granting.AllowsMutationBox || !trait.Granting.AllowsManualGrant || trait.Granting.AllowsTraining)
                {
                    issues.Add(
                        new EraValidationIssue(
                            EraValidationSeverity.Error,
                            "HeritageTrait",
                            $"{trait.TraitId} 的默认授予开关必须为：突变箱=开、手动=开、训练=关。"
                        )
                    );
                }
            }
            ValidateHeritageTrigger("HeritageTrait", trait.TraitId, trait.Trigger, issues);
            ValidateHeritageRandomAttributes("HeritageTrait", trait.TraitId, trait.RandomAttributes, issues);
            ValidateHeritageEffectParameters("HeritageTrait", trait.TraitId, trait.EffectParameters, issues);
            ValidateHeritagePresentation("HeritageTrait", trait.TraitId, trait, issues);
            if (trait.UnlockTier < 1 || trait.UnlockTier > maxTier)
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageTrait",
                        $"轮回特质 {trait.TraitId} 的 unlock_tier={trait.UnlockTier} 超出 1-{maxTier}。"
                    )
                );
            }
            ValidateIconPath("HeritageTrait", trait.TraitId, modRootPath, trait.IconSourcePath, issues);
        }
    }

    private static void ValidateCatalogCounts(EraContentCatalog catalog, List<EraValidationIssue> issues)
    {
        ValidateExpectedCount("Demon", catalog.Demons.Count, 10, issues);
        ValidateExpectedCount("General", catalog.Generals.Count, 50, issues);
        ValidateExpectedCount("Legion", catalog.Legions.Count, 10, issues);
        ValidateExpectedCount("Stronghold", catalog.Strongholds.Count, 10, issues);
        ValidateExpectedCount("PublicTrait", catalog.PublicTraits.Count, 25, issues);
        ValidateExpectedCount("HeritageEquipment", catalog.HeritageEquipment.Count, 30, issues);
        ValidateExpectedCount("HeritageTrait", catalog.HeritageTraits.Count, 30, issues);
    }

    private static void ValidateHeritageEquipmentSlotSpecs(List<EraValidationIssue> issues)
    {
        foreach (EraHeritageEquipmentSlotKind slotKind in Enum.GetValues(typeof(EraHeritageEquipmentSlotKind)))
        {
            if (!EraHeritageEquipmentSlotSpecs.TryGet(slotKind, out EraHeritageEquipmentSlotSpec spec))
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipmentSpec",
                        $"槽位 {slotKind} 缺少轮回装备规格。"
                    )
                );
                continue;
            }

            if (string.IsNullOrWhiteSpace(spec.BaseTemplateId) || !AssetManager.items.has(spec.BaseTemplateId))
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipmentSpec",
                        $"槽位 {slotKind} 绑定的装备母版无效：{spec.BaseTemplateId}。"
                    )
                );
            }

            if (string.IsNullOrWhiteSpace(spec.VisualReferenceAssetId) || !AssetManager.items.has(spec.VisualReferenceAssetId))
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipmentSpec",
                        $"槽位 {slotKind} 绑定的外观引用无效：{spec.VisualReferenceAssetId}。"
                    )
                );
            }
        }
    }

    private static void ValidateUniqueIds(IEnumerable<string> ids, string scope, List<EraValidationIssue> issues)
    {
        HashSet<string> seen = new HashSet<string>();
        foreach (string id in ids)
        {
            if (!seen.Add(id))
            {
                issues.Add(new EraValidationIssue(EraValidationSeverity.Error, scope, $"发现重复 ID：{id}。"));
            }
        }
    }

    private static void ValidateExpectedCount(string scope, int actual, int expected, List<EraValidationIssue> issues)
    {
        if (actual != expected)
        {
            issues.Add(
                new EraValidationIssue(
                    EraValidationSeverity.Error,
                    scope,
                    $"当前条目数量为 {actual}，与设计要求的 {expected} 不一致。"
                )
            );
        }
    }

    private static void ValidateHeritageTrigger(
        string scope,
        string entryId,
        EraHeritageTriggerProfile trigger,
        List<EraValidationIssue> issues
    )
    {
        if (trigger == null || trigger.Kinds.Count == 0)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, scope, $"{entryId} 缺少触发类型。"));
            return;
        }

        if (trigger.ChancePercent <= 0f || trigger.ChancePercent > 100f)
        {
            issues.Add(
                new EraValidationIssue(
                    EraValidationSeverity.Error,
                    scope,
                    $"{entryId} 的触发率 {trigger.ChancePercent} 超出 0~100。"
                )
            );
        }
    }

    private static void ValidateHeritageRandomAttributes(
        string scope,
        string entryId,
        EraHeritageRandomAttributeProfile randomAttributes,
        List<EraValidationIssue> issues
    )
    {
        if (randomAttributes == null)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, scope, $"{entryId} 缺少随机属性规则。"));
            return;
        }

        if (!string.Equals(randomAttributes.CandidatePoolId, ExpectedHeritageRandomPoolId, StringComparison.Ordinal))
        {
            issues.Add(
                new EraValidationIssue(
                    EraValidationSeverity.Error,
                    scope,
                    $"{entryId} 的随机属性池 {randomAttributes.CandidatePoolId} 不符合共享候选池口径。"
                )
            );
        }

        if (randomAttributes.DrawCount != 6)
        {
            issues.Add(
                new EraValidationIssue(
                    EraValidationSeverity.Error,
                    scope,
                    $"{entryId} 的随机属性抽取数量={randomAttributes.DrawCount}，设计要求为 6。"
                )
            );
        }

        if (!randomAttributes.NoDuplicates)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, scope, $"{entryId} 的随机属性必须单次不重复。"));
        }
    }

    private static void ValidateHeritageEffectParameters(
        string scope,
        string entryId,
        IReadOnlyList<EraHeritageEffectParameter> effectParameters,
        List<EraValidationIssue> issues
    )
    {
        if (effectParameters == null || effectParameters.Count == 0)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, scope, $"{entryId} 缺少核心效果参数。"));
            return;
        }

        HashSet<string> keys = new HashSet<string>();
        foreach (EraHeritageEffectParameter parameter in effectParameters)
        {
            if (string.IsNullOrWhiteSpace(parameter.Key) || string.IsNullOrWhiteSpace(parameter.DisplayName))
            {
                issues.Add(new EraValidationIssue(EraValidationSeverity.Error, scope, $"{entryId} 存在空的效果参数定义。"));
                continue;
            }

            if (!keys.Add(parameter.Key))
            {
                issues.Add(new EraValidationIssue(EraValidationSeverity.Error, scope, $"{entryId} 出现重复效果参数：{parameter.Key}。"));
            }

            if (parameter.MaxValue < parameter.MinValue)
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        scope,
                        $"{entryId} 的效果参数 {parameter.Key} 上限小于下限。"
                    )
                );
            }
        }
    }

    private static void ValidateHeritagePresentation(
        string scope,
        string entryId,
        IEraHeritageDefinition definition,
        List<EraValidationIssue> issues
    )
    {
        string primaryText = EraHeritagePresentation.BuildStaticPrimaryText(definition);
        string secondaryText = EraHeritagePresentation.BuildStaticSecondaryText(definition);
        if (!EraHeritagePresentation.IsPlayerFacingTextClean(primaryText))
        {
            issues.Add(
                new EraValidationIssue(
                    EraValidationSeverity.Error,
                    scope,
                    $"{entryId} 的主说明不符合玩家展示口径，不能为空，也不能包含内部实现字段。"
                )
            );
        }

        if (!EraHeritagePresentation.IsPlayerFacingTextClean(secondaryText))
        {
            issues.Add(
                new EraValidationIssue(
                    EraValidationSeverity.Error,
                    scope,
                    $"{entryId} 的随机范围说明不符合玩家展示口径，不能为空，也不能包含内部实现字段。"
                )
            );
        }

        if (!EraHeritagePresentation.HasExpandedRandomRangeText(secondaryText))
        {
            issues.Add(
                new EraValidationIssue(
                    EraValidationSeverity.Error,
                    scope,
                    $"{entryId} 的随机范围说明没有展开当前候选属性和对应区间。"
                )
            );
        }

        if (!EraHeritagePresentation.UsesPreferredRandomRangeText(secondaryText))
        {
            issues.Add(
                new EraValidationIssue(
                    EraValidationSeverity.Error,
                    scope,
                    $"{entryId} 的随机范围说明仍在使用旧样式，必须改成“属性名：+50%~200%”这一类玩家可读格式。"
                )
            );
        }

        if (secondaryText.Contains("当前实例属性加成", StringComparison.Ordinal))
        {
            issues.Add(
                new EraValidationIssue(
                    EraValidationSeverity.Error,
                    scope,
                    $"{entryId} 的静态随机范围说明混入了实例属性摘要，静态展示只能保留效果说明和随机范围说明。"
                )
            );
        }

        string instanceSummary = EraHeritagePresentation.BuildCurrentInstanceAttributeSummary(
            new[]
            {
                new EraAttributeModifierEntry
                {
                    AttributeId = EraAttributeIds.MultiplierDamage,
                    Value = 0.5f,
                },
            }
        );
        if (instanceSummary.Contains("随机规则：", StringComparison.Ordinal) ||
            instanceSummary.Contains("候选属性：", StringComparison.Ordinal))
        {
            issues.Add(
                new EraValidationIssue(
                    EraValidationSeverity.Error,
                    scope,
                    $"{entryId} 的实例属性摘要生成器混入了静态随机范围说明；这个摘要只应该输出实例属性摘要，不应该混入静态说明。"
                )
            );
        }

        if (instanceSummary.Contains("效果：", StringComparison.Ordinal) ||
            instanceSummary.Contains("作用对象：", StringComparison.Ordinal))
        {
            issues.Add(
                new EraValidationIssue(
                    EraValidationSeverity.Error,
                    scope,
                    $"{entryId} 的实例属性摘要生成器混入了静态主说明；这个摘要只应该输出实例属性摘要，不应该混入静态说明。"
                )
            );
        }
    }

    private static void ValidateRequiredText(string scope, string id, string value, List<EraValidationIssue> issues)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, scope, $"{id} 缺少文本字段。"));
        }
    }

    private static void ValidateResource(string scope, string id, string resourceId, List<EraValidationIssue> issues)
    {
        if (string.IsNullOrWhiteSpace(resourceId))
        {
            return;
        }

        if (!AssetManager.resources.has(resourceId))
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, scope, $"{id} 绑定了未知资源：{resourceId}。"));
        }
    }

    private static void ValidateIconPath(
        string scope,
        string id,
        string modRootPath,
        string relativePath,
        List<EraValidationIssue> issues
    )
    {
        if (string.IsNullOrWhiteSpace(relativePath))
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, scope, $"{id} 缺少图标路径。"));
            return;
        }

        string absolutePath = EraPathResolver.ResolveModPath(modRootPath, relativePath);
        if (!File.Exists(absolutePath))
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, scope, $"{id} 的图标源文件不存在：{relativePath}。"));
        }
    }

    private static void ValidateControlMetric(string name, Config.Schema.EraControlMetric metric, List<EraValidationIssue> issues)
    {
        if (metric.Threshold < 1)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", $"{name}掌控度阈值必须 >= 1。"));
        }

        if (metric.Weight < 0f)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", $"{name}掌控度权重不能为负数。"));
        }
    }

    private static void ValidateAttributeRangeProfile(
        string label,
        IReadOnlyDictionary<string, Config.Schema.EraFloatRange> ranges,
        List<EraValidationIssue> issues)
    {
        foreach ((string attributeId, Config.Schema.EraFloatRange range) in ranges)
        {
            if (range.Min > range.Max)
            {
                issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", $"{label}里 {attributeId} 的最小值大于最大值。"));
            }
        }
    }

    private static void ValidateCandidatePool(
        string label,
        IReadOnlyList<string> candidateIds,
        bool required,
        List<EraValidationIssue> issues)
    {
        if (!required)
        {
            return;
        }

        if (candidateIds.Count == 0)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", $"{label}不能为空。"));
            return;
        }

        if (candidateIds.Distinct().Count() != candidateIds.Count)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", $"{label}里出现了重复属性。"));
        }
    }

    private static void ValidateRegisteredHeritageEquipmentAssets(
        IEnumerable<EraHeritageEquipmentManifest> equipmentList,
        List<EraValidationIssue> issues
    )
    {
        foreach (EraHeritageEquipmentManifest equipment in equipmentList)
        {
            if (!EraHeritageEquipmentSlotSpecs.TryGet(equipment.SlotKind, out EraHeritageEquipmentSlotSpec spec))
            {
                continue;
            }

            EquipmentAsset? asset = AssetManager.items.get(equipment.EquipmentId);
            if (asset == null)
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipmentRegistration",
                        $"轮回装备未完成注册：{equipment.EquipmentId}。"
                    )
                );
                continue;
            }

            if (asset.equipment_type != spec.EquipmentType)
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipmentRegistration",
                        $"轮回装备 {equipment.EquipmentId} 的 equipment_type={asset.equipment_type}，预期={spec.EquipmentType}。"
                    )
                );
            }

            if (!string.Equals(asset.equipment_subtype, spec.EquipmentSubtype, StringComparison.Ordinal))
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipmentRegistration",
                        $"轮回装备 {equipment.EquipmentId} 的 equipment_subtype={asset.equipment_subtype}，预期={spec.EquipmentSubtype}。"
                    )
                );
            }

            if (!string.Equals(asset.group_id, spec.GroupId, StringComparison.Ordinal))
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipmentRegistration",
                        $"轮回装备 {equipment.EquipmentId} 的 group_id={asset.group_id}，预期={spec.GroupId}。"
                    )
                );
            }

            if (asset.is_pool_weapon != spec.IsPoolWeapon)
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipmentRegistration",
                        $"轮回装备 {equipment.EquipmentId} 的 is_pool_weapon={asset.is_pool_weapon}，预期={spec.IsPoolWeapon}。"
                    )
                );
            }

            if (spec.AttackType.HasValue && asset.attack_type != spec.AttackType.Value)
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipmentRegistration",
                        $"轮回装备 {equipment.EquipmentId} 的 attack_type={asset.attack_type}，预期={spec.AttackType.Value}。"
                    )
                );
            }

            if (!string.Equals(asset.path_slash_animation, spec.PathSlashAnimation, StringComparison.Ordinal))
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipmentRegistration",
                        $"轮回装备 {equipment.EquipmentId} 的 path_slash_animation={asset.path_slash_animation}，预期={spec.PathSlashAnimation}。"
                    )
                );
            }

            if (!string.Equals(asset.projectile ?? string.Empty, spec.Projectile ?? string.Empty, StringComparison.Ordinal))
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipmentRegistration",
                        $"轮回装备 {equipment.EquipmentId} 的 projectile={asset.projectile}，预期={spec.Projectile}。"
                    )
                );
            }

            if (spec.RigidityRating.HasValue && asset.rigidity_rating != spec.RigidityRating.Value)
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipmentRegistration",
                        $"轮回装备 {equipment.EquipmentId} 的 rigidity_rating={asset.rigidity_rating}，预期={spec.RigidityRating.Value}。"
                    )
                );
            }

            foreach (KeyValuePair<string, float> entry in spec.BaseStatOverrides)
            {
                float actualValue = asset.base_stats?[entry.Key] ?? 0f;
                if (Math.Abs(actualValue - entry.Value) > 0.0001f)
                {
                    issues.Add(
                        new EraValidationIssue(
                            EraValidationSeverity.Error,
                            "HeritageEquipmentRegistration",
                            $"轮回装备 {equipment.EquipmentId} 的 base_stats[{entry.Key}]={actualValue:0.###}，预期={entry.Value:0.###}。"
                        )
                    );
                }
            }

            if (asset.item_modifier_ids != null && asset.item_modifier_ids.Length > 0)
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipmentRegistration",
                        $"轮回装备 {equipment.EquipmentId} 残留了继承词条：{string.Join(",", asset.item_modifier_ids)}。"
                    )
                );
            }

            if (asset.item_modifiers != null && asset.item_modifiers.Length > 0)
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipmentRegistration",
                        $"轮回装备 {equipment.EquipmentId} 残留了已链接词条实例。"
                    )
                );
            }

            if (asset.spells_ids != null && asset.spells_ids.Count > 0)
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipmentRegistration",
                        $"轮回装备 {equipment.EquipmentId} 残留了继承法术：{string.Join(",", asset.spells_ids)}。"
                    )
                );
            }

            if (asset.spells != null && asset.spells.Count > 0)
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "HeritageEquipmentRegistration",
                        $"轮回装备 {equipment.EquipmentId} 残留了已链接法术实例。"
                    )
                );
            }
        }
    }

    private static void ValidateAdvancementDisplayableBaseStats(List<EraValidationIssue> issues)
    {
        if (AssetManager.base_stats_library == null)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "AdvancementDisplay", "原版 base_stats_library 未初始化，无法校验轮回随机属性展示口径。"));
            return;
        }

        foreach (string statId in EraBaseStatVisibilityService.RequiredVisibleStatIds)
        {
            BaseStatAsset? asset = AssetManager.base_stats_library.get(statId);
            if (asset == null)
            {
                issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "AdvancementDisplay", $"轮回随机属性展示依赖的原版 stat 不存在：{statId}。"));
                continue;
            }

            if (asset.hidden)
            {
                issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "AdvancementDisplay", $"轮回随机属性展示依赖的原版 stat 仍然是 hidden=true：{statId}。"));
            }

            if (EraBaseStatVisibilityService.TryGetExpectedTranslationKey(statId, out string translationKey) &&
                !string.Equals(asset.translation_key, translationKey, StringComparison.Ordinal))
            {
                issues.Add(
                    new EraValidationIssue(
                        EraValidationSeverity.Error,
                        "AdvancementDisplay",
                        $"{statId} 的 translation_key={asset.translation_key ?? "<null>"}，预期={translationKey}，否则玩家界面可能直接露出原始 key。"
                    )
                );
            }
        }
    }

    private static void ValidateRenownBands(EraParameterRegistry registry, List<EraValidationIssue> issues)
    {
        IReadOnlyList<Config.Schema.EraKingdomRenownBand> bands = registry.Current.Kingdoms.RenownBands
            .OrderBy(band => band.StartLevel)
            .ToArray();
        if (bands.Count == 0)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "王国声望分段不能为空。"));
            return;
        }

        int expectedStart = 1;
        for (int index = 0; index < bands.Count; index++)
        {
            Config.Schema.EraKingdomRenownBand band = bands[index];
            if (band.StartLevel != expectedStart)
            {
                issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "王国声望分段必须从 1 级开始且连续覆盖，不能重叠或留空。"));
                break;
            }

            if (band.EndLevel < band.StartLevel)
            {
                issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", $"王国声望分段 #{index + 1} 的结束等级不能小于起始等级。"));
            }

            if (band.RenownPerLevel < 1)
            {
                issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", $"王国声望分段 #{index + 1} 的每级所需声望必须 >= 1。"));
            }

            expectedStart = band.EndLevel + 1;
        }

        if (bands[^1].EndLevel != registry.Current.Kingdoms.MaxLevel)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", "王国声望分段的最终结束等级必须等于王国等级上限。"));
        }
    }

    private static void ValidatePercent(string label, float value, List<EraValidationIssue> issues)
    {
        if (value < 0f || value > 100f)
        {
            issues.Add(new EraValidationIssue(EraValidationSeverity.Error, "Config", $"{label}必须落在 0%~100% 之间。"));
        }
    }
}
