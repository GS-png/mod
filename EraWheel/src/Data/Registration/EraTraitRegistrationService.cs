using System;
using System.Collections.Generic;
using EraWheel.Assets;
using EraWheel.Core.Constants;
using EraWheel.Core.Logging;
using EraWheel.Data.Definitions;
using NeoModLoader.utils.Builders;

namespace EraWheel.Data.Registration;

public sealed class EraTraitRegistrationReport
{
    public int PublicRegisteredCount { get; }
    public int PublicSkippedCount { get; }
    public int HeritageRegisteredCount { get; }
    public int HeritageSkippedCount { get; }

    public EraTraitRegistrationReport(
        int publicRegisteredCount,
        int publicSkippedCount,
        int heritageRegisteredCount,
        int heritageSkippedCount
    )
    {
        PublicRegisteredCount = publicRegisteredCount;
        PublicSkippedCount = publicSkippedCount;
        HeritageRegisteredCount = heritageRegisteredCount;
        HeritageSkippedCount = heritageSkippedCount;
    }

    public string CreateStatusReport()
    {
        return $"公共特质注册={PublicRegisteredCount}，跳过={PublicSkippedCount}；轮回特质注册={HeritageRegisteredCount}，跳过={HeritageSkippedCount}。";
    }
}

public static class EraTraitRegistrationService
{
    public static EraTraitRegistrationReport Register(EraContentCatalog contentCatalog, EraSpriteCatalog spriteCatalog, bool reloadMode = false)
    {
        int publicRegisteredCount = 0;
        int publicSkippedCount = 0;
        int heritageRegisteredCount = 0;
        int heritageSkippedCount = 0;

        foreach (EraPublicTraitManifest trait in contentCatalog.PublicTraits)
        {
            if (RegisterPublicTrait(trait, spriteCatalog, reloadMode))
            {
                publicRegisteredCount++;
            }
            else
            {
                publicSkippedCount++;
            }
        }

        foreach (EraHeritageTraitManifest trait in contentCatalog.HeritageTraits)
        {
            if (RegisterHeritageTrait(trait, spriteCatalog, reloadMode))
            {
                heritageRegisteredCount++;
            }
            else
            {
                heritageSkippedCount++;
            }
        }

        return new EraTraitRegistrationReport(
            publicRegisteredCount,
            publicSkippedCount,
            heritageRegisteredCount,
            heritageSkippedCount
        );
    }

    private static bool RegisterPublicTrait(EraPublicTraitManifest trait, EraSpriteCatalog spriteCatalog, bool reloadMode)
    {
        if (!reloadMode && AssetManager.traits.has(trait.TraitId))
        {
            EraLog.Warning(EraLogCategory.Data, $"公共特质已存在，跳过重复注册：{trait.TraitId}");
            return false;
        }

        EraTraitGrantConfig grantConfig = EraTraitRegistrationMetadata.ParseGrantConfig(trait.GrantConfig);
        ActorTraitBuilder builder = new ActorTraitBuilder(trait.TraitId);
        ConfigureCommonFields(
            builder,
            trait.TraitId,
            ResolvePublicTraitIconPath(trait, spriteCatalog),
            EraTraitRegistrationMetadata.GetPublicTraitRarity(trait.TraitId),
            ResolvePublicTraitGroupId(trait)
        );
        builder.Description2ID = null;
        builder.ShowInMetaEditor = grantConfig.AllowsManualGrant;
        builder.CanBeGiven = grantConfig.AllowsManualGrant;
        builder.UsedInMutationBox = grantConfig.AllowsMutationBox;
        builder.IsCombatSkill = grantConfig.AllowsTraining;
        builder.RateBirth = grantConfig.BirthWeight;
        builder.RateInherit = grantConfig.InheritWeight;
        builder.RateAcquireWhenGrownUp = grantConfig.GrowthWeight;
        builder.Type = TraitType.Positive;
        builder.Stats = new Dictionary<string, float>(EraTraitRegistrationMetadata.GetPublicTraitBaseStats(trait.TraitId));
        builder.Build(SetRarityAutomatically: false, AutoLocalize: false, LinkWithOtherAssets: false);
        builder.Localize(
            trait.DisplayName,
            EraTraitRegistrationMetadata.BuildPublicTraitDescriptionText(trait),
            null
        );
        return true;
    }

    private static bool RegisterHeritageTrait(EraHeritageTraitManifest trait, EraSpriteCatalog spriteCatalog, bool reloadMode)
    {
        if (!reloadMode && AssetManager.traits.has(trait.TraitId))
        {
            EraLog.Warning(EraLogCategory.Data, $"轮回特质已存在，跳过重复注册：{trait.TraitId}");
            return false;
        }

        ActorTraitBuilder builder = new ActorTraitBuilder(trait.TraitId);
        ConfigureCommonFields(
            builder,
            trait.TraitId,
            ResolveHeritageTraitIconPath(trait, spriteCatalog),
            EraTraitRegistrationMetadata.GetHeritageTraitRarity(trait.TraitId),
            ResolveHeritageTraitGroupId(trait)
        );
        builder.ShowInMetaEditor = trait.Granting.AllowsManualGrant;
        builder.CanBeGiven = trait.Granting.AllowsManualGrant;
        builder.UsedInMutationBox = trait.Granting.AllowsMutationBox;
        builder.IsCombatSkill = trait.Granting.AllowsTraining;
        builder.RateBirth = trait.Granting.BirthWeight;
        builder.RateInherit = trait.Granting.InheritWeight;
        builder.RateAcquireWhenGrownUp = trait.Granting.GrowthWeight;
        builder.Type = TraitType.Positive;
        builder.Build(SetRarityAutomatically: false, AutoLocalize: false, LinkWithOtherAssets: false);
        builder.Localize(
            trait.DisplayName,
            EraTraitRegistrationMetadata.BuildHeritageTraitDescriptionText(trait),
            EraTraitRegistrationMetadata.BuildHeritageTraitDetailText(trait)
        );
        return true;
    }

    private static void ConfigureCommonFields(
        ActorTraitBuilder builder,
        string traitId,
        string iconPath,
        Rarity rarity,
        string groupId
    )
    {
        builder.NameID = $"{traitId}_name";
        builder.Description1ID = $"{traitId}_description";
        builder.Description2ID = $"{traitId}_details";
        builder.PathIcon = iconPath;
        builder.Group = groupId;
        builder.Rarity = rarity;
        builder.ShowInKnowledgeWindow = true;
        builder.CanBeRemoved = true;
    }

    private static string ResolvePublicTraitGroupId(EraPublicTraitManifest _)
    {
        return EraTraitGroupIds.PublicTraits;
    }

    private static string ResolveHeritageTraitGroupId(EraHeritageTraitManifest trait)
    {
        int tier = trait.UnlockTier;
        if (tier < EraTraitGroupIds.MinHeritageTier || tier > EraTraitGroupIds.MaxHeritageTier)
        {
            EraLog.Warning(
                EraLogCategory.Data,
                $"轮回特质档位超出预期，分组将按最近合法档位处理：{trait.TraitId} -> unlock_tier={tier}"
            );
            tier = Math.Clamp(tier, EraTraitGroupIds.MinHeritageTier, EraTraitGroupIds.MaxHeritageTier);
        }

        return EraTraitGroupIds.HeritageTier(tier);
    }

    private static string ResolvePublicTraitIconPath(EraPublicTraitManifest trait, EraSpriteCatalog spriteCatalog)
    {
        if (spriteCatalog.PublicTraitsById.TryGetValue(trait.TraitId, out EraIndexedSpriteSet? set) &&
            set.Icon != null &&
            !string.IsNullOrWhiteSpace(set.Icon.RuntimePathId))
        {
            return set.Icon.RuntimePathId;
        }

        return trait.IconSourcePath;
    }

    private static string ResolveHeritageTraitIconPath(EraHeritageTraitManifest trait, EraSpriteCatalog spriteCatalog)
    {
        if (spriteCatalog.HeritageTraitsById.TryGetValue(trait.TraitId, out EraIndexedSpriteSet? set) &&
            set.Icon != null &&
            !string.IsNullOrWhiteSpace(set.Icon.RuntimePathId))
        {
            return set.Icon.RuntimePathId;
        }

        return trait.IconSourcePath;
    }
}
