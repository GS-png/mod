using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using EraWheel.Core.Constants;

namespace EraWheel.Data.Definitions;

public sealed class EraDemonManifest
{
    public string InternalId { get; }
    public EraDemonKind Kind { get; }
    public string DisplayName { get; }
    public string CoreMechanic { get; }
    public string CombatKeywords { get; }
    public string UnitIconSourcePath { get; }
    public string StrongholdIconSourcePath { get; }

    public EraDemonManifest(
        string internalId,
        EraDemonKind kind,
        string displayName,
        string coreMechanic,
        string combatKeywords,
        string unitIconSourcePath,
        string strongholdIconSourcePath
    )
    {
        InternalId = internalId;
        Kind = kind;
        DisplayName = displayName;
        CoreMechanic = coreMechanic;
        CombatKeywords = combatKeywords;
        UnitIconSourcePath = unitIconSourcePath;
        StrongholdIconSourcePath = strongholdIconSourcePath;
    }
}

public sealed class EraGeneralManifest
{
    public string InternalId { get; }
    public string DisplayName { get; }
    public string DemonInternalId { get; }
    public string IconSourcePath { get; }

    public EraGeneralManifest(string internalId, string displayName, string demonInternalId, string iconSourcePath)
    {
        InternalId = internalId;
        DisplayName = displayName;
        DemonInternalId = demonInternalId;
        IconSourcePath = iconSourcePath;
    }
}

public sealed class EraLegionManifest
{
    public string InternalId { get; }
    public string DisplayName { get; }
    public string DemonInternalId { get; }
    public string UnitGroupKey { get; }
    public string IconSourcePath { get; }
    public string BaseTemplateId { get; }

    public EraLegionManifest(
        string internalId,
        string displayName,
        string demonInternalId,
        string unitGroupKey,
        string iconSourcePath,
        string baseTemplateId
    )
    {
        InternalId = internalId;
        DisplayName = displayName;
        DemonInternalId = demonInternalId;
        UnitGroupKey = unitGroupKey;
        IconSourcePath = iconSourcePath;
        BaseTemplateId = baseTemplateId;
    }
}

public sealed class EraStrongholdPlacementMetadata
{
    public int ArtFootprintWidth { get; }
    public int ArtFootprintHeight { get; }
    public int FundamentLeft { get; }
    public int FundamentRight { get; }
    public int FundamentTop { get; }
    public int FundamentBottom { get; }
    public bool RequireWalkableLand { get; }
    public bool AvoidDeepWater { get; }
    public bool RetryNearbyWalkableTile { get; }

    public EraStrongholdPlacementMetadata(
        int artFootprintWidth,
        int artFootprintHeight,
        int fundamentLeft,
        int fundamentRight,
        int fundamentTop,
        int fundamentBottom,
        bool requireWalkableLand,
        bool avoidDeepWater,
        bool retryNearbyWalkableTile
    )
    {
        ArtFootprintWidth = artFootprintWidth;
        ArtFootprintHeight = artFootprintHeight;
        FundamentLeft = fundamentLeft;
        FundamentRight = fundamentRight;
        FundamentTop = fundamentTop;
        FundamentBottom = fundamentBottom;
        RequireWalkableLand = requireWalkableLand;
        AvoidDeepWater = avoidDeepWater;
        RetryNearbyWalkableTile = retryNearbyWalkableTile;
    }
}

public sealed class EraStrongholdManifest
{
    public string BuildingId { get; }
    public string DisplayName { get; }
    public string DemonInternalId { get; }
    public string IconSourcePath { get; }
    public EraStrongholdPlacementMetadata Placement { get; }

    public EraStrongholdManifest(
        string buildingId,
        string displayName,
        string demonInternalId,
        string iconSourcePath,
        EraStrongholdPlacementMetadata placement
    )
    {
        BuildingId = buildingId;
        DisplayName = displayName;
        DemonInternalId = demonInternalId;
        IconSourcePath = iconSourcePath;
        Placement = placement;
    }
}

public sealed class EraPublicTraitManifest
{
    public string TraitId { get; }
    public string DisplayName { get; }
    public string TraitType { get; }
    public string Summary { get; }
    public string GrantConfig { get; }
    public string IconSourcePath { get; }

    public EraPublicTraitManifest(
        string traitId,
        string displayName,
        string traitType,
        string summary,
        string grantConfig,
        string iconSourcePath
    )
    {
        TraitId = traitId;
        DisplayName = displayName;
        TraitType = traitType;
        Summary = summary;
        GrantConfig = grantConfig;
        IconSourcePath = iconSourcePath;
    }
}

public enum EraHeritageTriggerKind
{
    Active,
    OnHit,
    OnGetHit,
}

public enum EraHeritageEquipmentSlotKind
{
    Sword,
    Axe,
    Spear,
    Bow,
    Hammer,
    Staff,
    Firearm,
    Helmet,
    Armor,
    Boots,
    Ring,
    Amulet,
}

public enum EraHeritageTargetKind
{
    Self,
    TargetEnemy,
    TargetPointEnemies,
    RadiusEnemies,
    RadiusFriends,
    SelfAndRadiusEnemies,
    SelfAndRadiusFriends,
    SelfAndAttacker,
    SelfAndPathEnemies,
    LineEnemies,
    SummonedAllies,
    Terrain,
    AllCreatures,
    TargetEnemyAndNearbyEnemies,
    TargetEnemyAndAttacker,
    PathEnemies,
}

public enum EraHeritageImplementationKind
{
    ReuseAndAdjust,
    Composite,
    Custom,
}

public enum EraHeritageParameterUnit
{
    Percent,
    Multiplier,
    Seconds,
    Years,
    Tiles,
    Count,
    HitPoints,
}

public sealed class EraHeritageTriggerProfile
{
    public IReadOnlyList<EraHeritageTriggerKind> Kinds { get; }
    public float ChancePercent { get; }
    public string SkillLabel { get; }
    public string DisplayText { get; }

    public EraHeritageTriggerProfile(
        IReadOnlyList<EraHeritageTriggerKind> kinds,
        float chancePercent,
        string skillLabel = ""
    )
    {
        Kinds = kinds ?? Array.Empty<EraHeritageTriggerKind>();
        ChancePercent = chancePercent;
        SkillLabel = skillLabel ?? string.Empty;
        DisplayText = BuildDisplayText(Kinds, chancePercent, SkillLabel);
    }

    private static string BuildDisplayText(
        IReadOnlyList<EraHeritageTriggerKind> kinds,
        float chancePercent,
        string skillLabel
    )
    {
        string triggerText = string.Join("或", kinds.Select(GetTriggerKindDisplayName));
        if (string.IsNullOrWhiteSpace(skillLabel))
        {
            return $"{triggerText} {FormatNumber(chancePercent)}%";
        }

        return $"{triggerText} {FormatNumber(chancePercent)}% 触发“{skillLabel}”";
    }

    private static string GetTriggerKindDisplayName(EraHeritageTriggerKind kind)
    {
        return kind switch
        {
            EraHeritageTriggerKind.Active => "主动时",
            EraHeritageTriggerKind.OnHit => "命中时",
            EraHeritageTriggerKind.OnGetHit => "受击时",
            _ => kind.ToString(),
        };
    }

    private static string FormatNumber(float value)
    {
        return Math.Abs(value - MathF.Round(value)) < 0.001f
            ? MathF.Round(value).ToString(CultureInfo.InvariantCulture)
            : value.ToString("0.##", CultureInfo.InvariantCulture);
    }
}

public sealed class EraHeritageTargetingProfile
{
    public EraHeritageTargetKind Kind { get; }
    public string DisplayText { get; }
    public float SearchRadius { get; }
    public float PrimaryRadius { get; }
    public float SecondaryRadius { get; }
    public float PathLength { get; }
    public int MaxTargets { get; }
    public bool IncludesSelf { get; }

    public EraHeritageTargetingProfile(
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
        Kind = kind;
        DisplayText = displayText;
        SearchRadius = searchRadius;
        PrimaryRadius = primaryRadius;
        SecondaryRadius = secondaryRadius;
        PathLength = pathLength;
        MaxTargets = maxTargets;
        IncludesSelf = includesSelf;
    }
}

public sealed class EraHeritageImplementationProfile
{
    public EraHeritageImplementationKind Kind { get; }
    public string Summary { get; }
    public string ReuseAssetId { get; }

    public EraHeritageImplementationProfile(
        EraHeritageImplementationKind kind,
        string summary,
        string reuseAssetId = ""
    )
    {
        Kind = kind;
        Summary = summary;
        ReuseAssetId = reuseAssetId;
    }
}

public sealed class EraHeritageEffectParameter
{
    public string Key { get; }
    public string DisplayName { get; }
    public float MinValue { get; }
    public float MaxValue { get; }
    public EraHeritageParameterUnit Unit { get; }

    public bool IsRange => Math.Abs(MaxValue - MinValue) > 0.001f;

    public EraHeritageEffectParameter(
        string key,
        string displayName,
        float minValue,
        float maxValue,
        EraHeritageParameterUnit unit
    )
    {
        Key = key;
        DisplayName = displayName;
        MinValue = minValue;
        MaxValue = maxValue;
        Unit = unit;
    }
}

public sealed class EraHeritageRandomAttributeProfile
{
    public string CandidatePoolId { get; }
    public int DrawCount { get; }
    public bool NoDuplicates { get; }
    public string DisplayText { get; }

    public EraHeritageRandomAttributeProfile(
        string candidatePoolId,
        int drawCount,
        bool noDuplicates,
        string displayText
    )
    {
        CandidatePoolId = candidatePoolId;
        DrawCount = drawCount;
        NoDuplicates = noDuplicates;
        DisplayText = displayText;
    }
}

public sealed class EraHeritageRestriction
{
    public string RestrictionId { get; }
    public string Description { get; }

    public EraHeritageRestriction(string restrictionId, string description)
    {
        RestrictionId = restrictionId;
        Description = description;
    }
}

public sealed class EraHeritageCraftingProfile
{
    public EraHeritageEquipmentSlotKind SlotKind { get; }
    public string PrimaryResourceId { get; }
    public int PrimaryResourceCost { get; }
    public string SecondaryResourceId { get; }
    public int SecondaryResourceCost { get; }
    public int GoldCost { get; }
    public int MinimumCityStorageResource1 { get; }
    public int EquipmentValue { get; }
    public string SlotDisplayName { get; }

    public EraHeritageCraftingProfile(
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
        SlotKind = slotKind;
        PrimaryResourceId = primaryResourceId;
        PrimaryResourceCost = primaryResourceCost;
        SecondaryResourceId = secondaryResourceId;
        SecondaryResourceCost = secondaryResourceCost;
        GoldCost = goldCost;
        MinimumCityStorageResource1 = minimumCityStorageResource1;
        EquipmentValue = equipmentValue;
        SlotDisplayName = GetSlotDisplayName(slotKind);
    }

    private static string GetSlotDisplayName(EraHeritageEquipmentSlotKind slotKind)
    {
        return slotKind switch
        {
            EraHeritageEquipmentSlotKind.Sword => "刀剑",
            EraHeritageEquipmentSlotKind.Axe => "斧头",
            EraHeritageEquipmentSlotKind.Spear => "长矛",
            EraHeritageEquipmentSlotKind.Bow => "弓箭",
            EraHeritageEquipmentSlotKind.Hammer => "锤子",
            EraHeritageEquipmentSlotKind.Staff => "法杖",
            EraHeritageEquipmentSlotKind.Firearm => "枪械",
            EraHeritageEquipmentSlotKind.Helmet => "头盔",
            EraHeritageEquipmentSlotKind.Armor => "盔甲",
            EraHeritageEquipmentSlotKind.Boots => "靴子",
            EraHeritageEquipmentSlotKind.Ring => "戒指",
            EraHeritageEquipmentSlotKind.Amulet => "护符",
            _ => slotKind.ToString(),
        };
    }
}

public sealed class EraTraitGrantProfile
{
    public int BirthWeight { get; }
    public int InheritWeight { get; }
    public int GrowthWeight { get; }
    public bool AllowsMutationBox { get; }
    public bool AllowsManualGrant { get; }
    public bool AllowsTraining { get; }
    public string DisplayText { get; }

    public EraTraitGrantProfile(
        int birthWeight,
        int inheritWeight,
        int growthWeight,
        bool allowsMutationBox,
        bool allowsManualGrant,
        bool allowsTraining = false
    )
    {
        BirthWeight = birthWeight;
        InheritWeight = inheritWeight;
        GrowthWeight = growthWeight;
        AllowsMutationBox = allowsMutationBox;
        AllowsManualGrant = allowsManualGrant;
        AllowsTraining = allowsTraining;
        DisplayText = BuildDisplayText();
    }

    private string BuildDisplayText()
    {
        List<string> parts = new List<string>
        {
            $"出生={BirthWeight}",
            $"遗传={InheritWeight}",
            $"成长={GrowthWeight}",
        };
        if (AllowsMutationBox)
        {
            parts.Add("突变箱");
        }

        if (AllowsManualGrant)
        {
            parts.Add("手动");
        }

        if (AllowsTraining)
        {
            parts.Add("训练");
        }

        return string.Join("；", parts);
    }
}

public interface IEraHeritageDefinition
{
    string DefinitionId { get; }
    string DisplayName { get; }
    int UnlockTier { get; }
    EraHeritageTriggerProfile Trigger { get; }
    EraHeritageTargetingProfile Targeting { get; }
    string Summary { get; }
    EraHeritageImplementationProfile Implementation { get; }
    IReadOnlyList<EraHeritageEffectParameter> EffectParameters { get; }
    EraHeritageRandomAttributeProfile RandomAttributes { get; }
    IReadOnlyList<EraHeritageRestriction> Restrictions { get; }
}

public sealed class EraHeritageEquipmentManifest : IEraHeritageDefinition
{
    public string EquipmentId { get; }
    public string DefinitionId => EquipmentId;
    public string DisplayName { get; }
    public int UnlockTier { get; }
    public EraHeritageCraftingProfile Crafting { get; }
    public EraHeritageTriggerProfile Trigger { get; }
    public EraHeritageTargetingProfile Targeting { get; }
    public string Summary { get; }
    public EraHeritageImplementationProfile Implementation { get; }
    public IReadOnlyList<EraHeritageEffectParameter> EffectParameters { get; }
    public EraHeritageRandomAttributeProfile RandomAttributes { get; }
    public IReadOnlyList<EraHeritageRestriction> Restrictions { get; }
    public string IconSourcePath { get; }
    public string Slot => Crafting.SlotDisplayName;
    public string TriggerText => Trigger.DisplayText;
    public EraHeritageEquipmentSlotKind SlotKind => Crafting.SlotKind;
    public string BaseTemplateId => EraHeritageEquipmentSlotSpecs.Get(Crafting.SlotKind)?.BaseTemplateId ?? string.Empty;
    public string PrimaryResourceId => Crafting.PrimaryResourceId;
    public int PrimaryResourceCost => Crafting.PrimaryResourceCost;
    public string SecondaryResourceId => Crafting.SecondaryResourceId;
    public int SecondaryResourceCost => Crafting.SecondaryResourceCost;
    public int GoldCost => Crafting.GoldCost;
    public int MinimumCityStorageResource1 => Crafting.MinimumCityStorageResource1;
    public int EquipmentValue => Crafting.EquipmentValue;

    public EraHeritageEquipmentManifest(
        string equipmentId,
        string displayName,
        int unlockTier,
        EraHeritageCraftingProfile crafting,
        EraHeritageTriggerProfile trigger,
        EraHeritageTargetingProfile targeting,
        string summary,
        EraHeritageImplementationProfile implementation,
        IReadOnlyList<EraHeritageEffectParameter> effectParameters,
        EraHeritageRandomAttributeProfile randomAttributes,
        IReadOnlyList<EraHeritageRestriction> restrictions,
        string iconSourcePath,
        string? _legacySlot = null,
        string? _legacyTriggerText = null
    )
    {
        EquipmentId = equipmentId;
        DisplayName = displayName;
        UnlockTier = unlockTier;
        Crafting = crafting;
        Trigger = trigger;
        Targeting = targeting;
        Summary = summary;
        Implementation = implementation;
        EffectParameters = effectParameters ?? Array.Empty<EraHeritageEffectParameter>();
        RandomAttributes = randomAttributes;
        Restrictions = restrictions ?? Array.Empty<EraHeritageRestriction>();
        IconSourcePath = iconSourcePath;
    }
}

public sealed class EraHeritageTraitManifest : IEraHeritageDefinition
{
    public string TraitId { get; }
    public string DefinitionId => TraitId;
    public string DisplayName { get; }
    public int UnlockTier { get; }
    public EraHeritageTriggerProfile Trigger { get; }
    public EraHeritageTargetingProfile Targeting { get; }
    public string Summary { get; }
    public EraHeritageImplementationProfile Implementation { get; }
    public EraTraitGrantProfile Granting { get; }
    public IReadOnlyList<EraHeritageEffectParameter> EffectParameters { get; }
    public EraHeritageRandomAttributeProfile RandomAttributes { get; }
    public IReadOnlyList<EraHeritageRestriction> Restrictions { get; }
    public string IconSourcePath { get; }
    public string TriggerText => Trigger.DisplayText;
    public string GrantConfig => Granting.DisplayText;

    public EraHeritageTraitManifest(
        string traitId,
        string displayName,
        int unlockTier,
        EraHeritageTriggerProfile trigger,
        EraHeritageTargetingProfile targeting,
        string summary,
        EraHeritageImplementationProfile implementation,
        EraTraitGrantProfile granting,
        IReadOnlyList<EraHeritageEffectParameter> effectParameters,
        EraHeritageRandomAttributeProfile randomAttributes,
        IReadOnlyList<EraHeritageRestriction> restrictions,
        string iconSourcePath
    )
    {
        TraitId = traitId;
        DisplayName = displayName;
        UnlockTier = unlockTier;
        Trigger = trigger;
        Targeting = targeting;
        Summary = summary;
        Implementation = implementation;
        Granting = granting;
        EffectParameters = effectParameters ?? Array.Empty<EraHeritageEffectParameter>();
        RandomAttributes = randomAttributes;
        Restrictions = restrictions ?? Array.Empty<EraHeritageRestriction>();
        IconSourcePath = iconSourcePath;
    }
}

public sealed class EraContentCatalog
{
    public static EraContentCatalog Empty { get; } = new(
        new List<EraDemonManifest>(),
        new List<EraGeneralManifest>(),
        new List<EraLegionManifest>(),
        new List<EraStrongholdManifest>(),
        new List<EraPublicTraitManifest>(),
        new List<EraHeritageEquipmentManifest>(),
        new List<EraHeritageTraitManifest>()
    );

    public IReadOnlyList<EraDemonManifest> Demons { get; }
    public IReadOnlyList<EraGeneralManifest> Generals { get; }
    public IReadOnlyList<EraLegionManifest> Legions { get; }
    public IReadOnlyList<EraStrongholdManifest> Strongholds { get; }
    public IReadOnlyList<EraPublicTraitManifest> PublicTraits { get; }
    public IReadOnlyList<EraHeritageEquipmentManifest> HeritageEquipment { get; }
    public IReadOnlyList<EraHeritageTraitManifest> HeritageTraits { get; }

    public IReadOnlyDictionary<string, EraDemonManifest> DemonsById { get; }
    public IReadOnlyDictionary<string, EraGeneralManifest> GeneralsById { get; }
    public IReadOnlyDictionary<string, EraLegionManifest> LegionsById { get; }
    public IReadOnlyDictionary<string, EraStrongholdManifest> StrongholdsById { get; }
    public IReadOnlyDictionary<string, EraPublicTraitManifest> PublicTraitsById { get; }
    public IReadOnlyDictionary<string, EraHeritageEquipmentManifest> HeritageEquipmentById { get; }
    public IReadOnlyDictionary<string, EraHeritageTraitManifest> HeritageTraitsById { get; }

    public EraContentCatalog(
        IReadOnlyList<EraDemonManifest> demons,
        IReadOnlyList<EraGeneralManifest> generals,
        IReadOnlyList<EraLegionManifest> legions,
        IReadOnlyList<EraStrongholdManifest> strongholds,
        IReadOnlyList<EraPublicTraitManifest> publicTraits,
        IReadOnlyList<EraHeritageEquipmentManifest> heritageEquipment,
        IReadOnlyList<EraHeritageTraitManifest> heritageTraits
    )
    {
        Demons = demons;
        Generals = generals;
        Legions = legions;
        Strongholds = strongholds;
        PublicTraits = publicTraits;
        HeritageEquipment = heritageEquipment;
        HeritageTraits = heritageTraits;
        DemonsById = new ReadOnlyDictionary<string, EraDemonManifest>(ToDictionary(demons, item => item.InternalId));
        GeneralsById = new ReadOnlyDictionary<string, EraGeneralManifest>(ToDictionary(generals, item => item.InternalId));
        LegionsById = new ReadOnlyDictionary<string, EraLegionManifest>(ToDictionary(legions, item => item.InternalId));
        StrongholdsById = new ReadOnlyDictionary<string, EraStrongholdManifest>(ToDictionary(strongholds, item => item.BuildingId));
        PublicTraitsById = new ReadOnlyDictionary<string, EraPublicTraitManifest>(ToDictionary(publicTraits, item => item.TraitId));
        HeritageEquipmentById = new ReadOnlyDictionary<string, EraHeritageEquipmentManifest>(ToDictionary(heritageEquipment, item => item.EquipmentId));
        HeritageTraitsById = new ReadOnlyDictionary<string, EraHeritageTraitManifest>(ToDictionary(heritageTraits, item => item.TraitId));
    }

    public string CreateStatusReport()
    {
        return $"魔王={Demons.Count}；将领={Generals.Count}；军团={Legions.Count}；据点={Strongholds.Count}；公共特质={PublicTraits.Count}；轮回装备={HeritageEquipment.Count}；轮回特质={HeritageTraits.Count}。";
    }

    private static Dictionary<string, TValue> ToDictionary<TValue>(
        IReadOnlyList<TValue> items,
        System.Func<TValue, string> keySelector
    )
    {
        Dictionary<string, TValue> dictionary = new Dictionary<string, TValue>();
        foreach (TValue item in items)
        {
            dictionary[keySelector(item)] = item;
        }

        return dictionary;
    }
}
