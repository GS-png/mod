using System.Collections.Generic;
using System.Linq;
using EraWheel.Assets;
using EraWheel.Core.Constants;
using EraWheel.Data.Definitions;

namespace EraWheel.Data.Bestiary;

public static class EraBestiaryCatalogBuilder
{
    public static EraBestiaryCatalog Build(EraContentCatalog contentCatalog, EraSpriteCatalog spriteCatalog)
    {
        List<EraBestiaryEntry> entries = new List<EraBestiaryEntry>();

        foreach (EraDemonManifest demon in contentCatalog.Demons)
        {
            entries.Add(BuildDemonEntry(demon, spriteCatalog));
        }

        foreach (EraGeneralManifest general in contentCatalog.Generals)
        {
            string demonName = contentCatalog.DemonsById.TryGetValue(general.DemonInternalId, out EraDemonManifest? demon)
                ? demon.DisplayName
                : general.DemonInternalId;
            entries.Add(BuildGeneralEntry(general, demonName, spriteCatalog));
        }

        foreach (EraLegionManifest legion in contentCatalog.Legions)
        {
            string demonName = contentCatalog.DemonsById.TryGetValue(legion.DemonInternalId, out EraDemonManifest? demon)
                ? demon.DisplayName
                : legion.DemonInternalId;
            entries.Add(BuildLegionEntry(legion, demonName, spriteCatalog));
        }

        foreach (EraStrongholdManifest stronghold in contentCatalog.Strongholds)
        {
            entries.Add(BuildStrongholdEntry(stronghold, contentCatalog, spriteCatalog));
        }

        foreach (EraHeritageEquipmentManifest equipment in contentCatalog.HeritageEquipment)
        {
            entries.Add(BuildHeritageEquipmentEntry(equipment, spriteCatalog));
        }

        foreach (EraHeritageTraitManifest trait in contentCatalog.HeritageTraits)
        {
            entries.Add(BuildHeritageTraitEntry(trait, spriteCatalog));
        }

        foreach (EraPublicTraitManifest trait in contentCatalog.PublicTraits)
        {
            entries.Add(BuildPublicTraitEntry(trait, spriteCatalog));
        }

        return new EraBestiaryCatalog(entries);
    }

    private static EraBestiaryEntry BuildDemonEntry(EraDemonManifest demon, EraSpriteCatalog spriteCatalog)
    {
        string iconRuntimePath = demon.UnitIconSourcePath;
        List<string> detailSprites = new List<string>();
        if (spriteCatalog.DemonsById.TryGetValue(demon.InternalId, out EraDemonSpriteSet? set))
        {
            if (set.UnitIcon != null && !string.IsNullOrWhiteSpace(set.UnitIcon.RuntimePathId))
            {
                iconRuntimePath = set.UnitIcon.RuntimePathId;
            }

            detailSprites.AddRange(
                set.SkillSpritesByGroup.Values
                    .SelectMany(group => group)
                    .Select(sprite => sprite.RuntimePathId)
                    .Where(path => !string.IsNullOrWhiteSpace(path))
            );
        }

        return new EraBestiaryEntry(
            demon.InternalId,
            EraBestiaryEntryKind.Demon,
            demon.DisplayName,
            demon.CoreMechanic,
            $"主要打法：{demon.CombatKeywords}\n基础母版：{EraWorldboxAssetIds.MobNoGenesTemplate}",
            iconRuntimePath,
            demon.UnitIconSourcePath,
            string.Empty,
            0,
            EraWorldboxAssetIds.MobNoGenesTemplate,
            detailSprites
        );
    }

    private static EraBestiaryEntry BuildGeneralEntry(EraGeneralManifest general, string demonName, EraSpriteCatalog spriteCatalog)
    {
        string iconRuntimePath = general.IconSourcePath;
        if (spriteCatalog.GeneralUnitGroupKeysById.TryGetValue(general.InternalId, out string? groupKey) &&
            spriteCatalog.UnitGroupsByKey.TryGetValue(groupKey, out EraUnitSpriteSet? set) &&
            set.Icon != null &&
            !string.IsNullOrWhiteSpace(set.Icon.RuntimePathId))
        {
            iconRuntimePath = set.Icon.RuntimePathId;
        }

        return new EraBestiaryEntry(
            general.InternalId,
            EraBestiaryEntryKind.General,
            general.DisplayName,
            $"所属魔王：{demonName}",
            $"归属 ID：{general.DemonInternalId}\n基础母版：{EraWorldboxAssetIds.MobNoGenesTemplate}",
            iconRuntimePath,
            general.IconSourcePath,
            general.DemonInternalId,
            0,
            EraWorldboxAssetIds.MobNoGenesTemplate,
            new List<string>()
        );
    }

    private static EraBestiaryEntry BuildLegionEntry(EraLegionManifest legion, string demonName, EraSpriteCatalog spriteCatalog)
    {
        string iconRuntimePath = legion.IconSourcePath;
        if (spriteCatalog.LegionUnitGroupKeysById.TryGetValue(legion.InternalId, out string? groupKey) &&
            spriteCatalog.UnitGroupsByKey.TryGetValue(groupKey, out EraUnitSpriteSet? set) &&
            set.Icon != null &&
            !string.IsNullOrWhiteSpace(set.Icon.RuntimePathId))
        {
            iconRuntimePath = set.Icon.RuntimePathId;
        }

        return new EraBestiaryEntry(
            legion.InternalId,
            EraBestiaryEntryKind.Legion,
            legion.DisplayName,
            $"所属魔王：{demonName}",
            $"单位组：{legion.UnitGroupKey}\n基础母版：{legion.BaseTemplateId}",
            iconRuntimePath,
            legion.IconSourcePath,
            legion.DemonInternalId,
            0,
            legion.BaseTemplateId,
            new List<string>()
        );
    }

    private static EraBestiaryEntry BuildStrongholdEntry(
        EraStrongholdManifest stronghold,
        EraContentCatalog contentCatalog,
        EraSpriteCatalog spriteCatalog
    )
    {
        string iconRuntimePath = stronghold.IconSourcePath;
        if (contentCatalog.DemonsById.TryGetValue(stronghold.DemonInternalId, out EraDemonManifest? demon) &&
            spriteCatalog.DemonsById.TryGetValue(demon.InternalId, out EraDemonSpriteSet? set) &&
            set.StrongholdIcon != null &&
            !string.IsNullOrWhiteSpace(set.StrongholdIcon.RuntimePathId))
        {
            iconRuntimePath = set.StrongholdIcon.RuntimePathId;
        }

        return new EraBestiaryEntry(
            stronghold.BuildingId,
            EraBestiaryEntryKind.Stronghold,
            stronghold.DisplayName,
            $"所属魔王：{stronghold.DemonInternalId}",
            $"美术底座：{stronghold.Placement.ArtFootprintWidth}x{stronghold.Placement.ArtFootprintHeight}\n代码口径：BuildingFundament({stronghold.Placement.FundamentLeft},{stronghold.Placement.FundamentRight},{stronghold.Placement.FundamentTop},{stronghold.Placement.FundamentBottom})",
            iconRuntimePath,
            stronghold.IconSourcePath,
            stronghold.DemonInternalId,
            0,
            string.Empty,
            new List<string>()
        );
    }

    private static EraBestiaryEntry BuildHeritageEquipmentEntry(EraHeritageEquipmentManifest equipment, EraSpriteCatalog spriteCatalog)
    {
        string iconRuntimePath = equipment.IconSourcePath;
        List<string> detailSprites = new List<string>();
        if (spriteCatalog.HeritageEquipmentById.TryGetValue(equipment.EquipmentId, out EraIndexedSpriteSet? set))
        {
            if (set.Icon != null && !string.IsNullOrWhiteSpace(set.Icon.RuntimePathId))
            {
                iconRuntimePath = set.Icon.RuntimePathId;
            }

            detailSprites.AddRange(
                set.DetailSprites.Select(sprite => sprite.RuntimePathId).Where(path => !string.IsNullOrWhiteSpace(path))
            );
        }

        return new EraBestiaryEntry(
            equipment.EquipmentId,
            EraBestiaryEntryKind.HeritageEquipment,
            equipment.DisplayName,
            equipment.TriggerText,
            $"效果：{equipment.Summary}\n作用对象：{equipment.Targeting.DisplayText}\n轮回阶位：T{equipment.UnlockTier}",
            iconRuntimePath,
            equipment.IconSourcePath,
            string.Empty,
            equipment.UnlockTier,
            equipment.BaseTemplateId,
            detailSprites
        );
    }

    private static EraBestiaryEntry BuildHeritageTraitEntry(EraHeritageTraitManifest trait, EraSpriteCatalog spriteCatalog)
    {
        string iconRuntimePath = trait.IconSourcePath;
        List<string> detailSprites = new List<string>();
        if (spriteCatalog.HeritageTraitsById.TryGetValue(trait.TraitId, out EraIndexedSpriteSet? set))
        {
            if (set.Icon != null && !string.IsNullOrWhiteSpace(set.Icon.RuntimePathId))
            {
                iconRuntimePath = set.Icon.RuntimePathId;
            }

            detailSprites.AddRange(
                set.DetailSprites.Select(sprite => sprite.RuntimePathId).Where(path => !string.IsNullOrWhiteSpace(path))
            );
        }

        return new EraBestiaryEntry(
            trait.TraitId,
            EraBestiaryEntryKind.HeritageTrait,
            trait.DisplayName,
            trait.TriggerText,
            $"效果：{trait.Summary}\n作用对象：{trait.Targeting.DisplayText}\n轮回阶位：T{trait.UnlockTier}",
            iconRuntimePath,
            trait.IconSourcePath,
            string.Empty,
            trait.UnlockTier,
            string.Empty,
            detailSprites
        );
    }

    private static EraBestiaryEntry BuildPublicTraitEntry(EraPublicTraitManifest trait, EraSpriteCatalog spriteCatalog)
    {
        string iconRuntimePath = trait.IconSourcePath;
        List<string> detailSprites = new List<string>();
        if (spriteCatalog.PublicTraitsById.TryGetValue(trait.TraitId, out EraIndexedSpriteSet? set))
        {
            if (set.Icon != null && !string.IsNullOrWhiteSpace(set.Icon.RuntimePathId))
            {
                iconRuntimePath = set.Icon.RuntimePathId;
            }

            detailSprites.AddRange(
                set.DetailSprites.Select(sprite => sprite.RuntimePathId).Where(path => !string.IsNullOrWhiteSpace(path))
            );
        }

        return new EraBestiaryEntry(
            trait.TraitId,
            EraBestiaryEntryKind.PublicTrait,
            trait.DisplayName,
            trait.TraitType,
            $"效果：{trait.Summary}\n授予配置：{trait.GrantConfig}",
            iconRuntimePath,
            trait.IconSourcePath,
            string.Empty,
            0,
            string.Empty,
            detailSprites
        );
    }
}
