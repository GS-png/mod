using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EraWheel.Assets.Indexing;

public enum EraSpriteAssetGroup
{
    PublicTrait,
    HeritageTrait,
    HeritageEquipment,
    Demon,
    Unit,
}

public sealed class EraTraitSpriteIndexItem
{
    public string TraitId { get; }
    public string DisplayName { get; }
    public string IconSpriteKey { get; }
    public string IconRelativePath { get; }
    public IReadOnlyList<string> SkillSpriteKeys { get; }
    public IReadOnlyList<string> SkillRelativePaths { get; }

    public EraTraitSpriteIndexItem(
        string traitId,
        string displayName,
        string iconSpriteKey,
        string iconRelativePath,
        IReadOnlyList<string> skillSpriteKeys,
        IReadOnlyList<string> skillRelativePaths
    )
    {
        TraitId = traitId;
        DisplayName = displayName;
        IconSpriteKey = iconSpriteKey;
        IconRelativePath = iconRelativePath;
        SkillSpriteKeys = skillSpriteKeys;
        SkillRelativePaths = skillRelativePaths;
    }
}

public sealed class EraEquipmentSpriteIndexItem
{
    public string EquipmentId { get; }
    public string DisplayName { get; }
    public string IconSpriteKey { get; }
    public string IconRelativePath { get; }
    public IReadOnlyList<string> SkillSpriteKeys { get; }
    public IReadOnlyList<string> SkillRelativePaths { get; }

    public EraEquipmentSpriteIndexItem(
        string equipmentId,
        string displayName,
        string iconSpriteKey,
        string iconRelativePath,
        IReadOnlyList<string> skillSpriteKeys,
        IReadOnlyList<string> skillRelativePaths
    )
    {
        EquipmentId = equipmentId;
        DisplayName = displayName;
        IconSpriteKey = iconSpriteKey;
        IconRelativePath = iconRelativePath;
        SkillSpriteKeys = skillSpriteKeys;
        SkillRelativePaths = skillRelativePaths;
    }
}

public sealed class EraDemonSpriteIndexItem
{
    public string DemonId { get; }
    public string DisplayName { get; }
    public string UnitIconSpriteKey { get; }
    public string UnitIconRelativePath { get; }
    public string StrongholdSpriteKey { get; }
    public string StrongholdRelativePath { get; }
    public IReadOnlyList<string> SkillSpriteKeys { get; }
    public IReadOnlyList<string> SkillRelativePaths { get; }

    public EraDemonSpriteIndexItem(
        string demonId,
        string displayName,
        string unitIconSpriteKey,
        string unitIconRelativePath,
        string strongholdSpriteKey,
        string strongholdRelativePath,
        IReadOnlyList<string> skillSpriteKeys,
        IReadOnlyList<string> skillRelativePaths
    )
    {
        DemonId = demonId;
        DisplayName = displayName;
        UnitIconSpriteKey = unitIconSpriteKey;
        UnitIconRelativePath = unitIconRelativePath;
        StrongholdSpriteKey = strongholdSpriteKey;
        StrongholdRelativePath = strongholdRelativePath;
        SkillSpriteKeys = skillSpriteKeys;
        SkillRelativePaths = skillRelativePaths;
    }
}

public sealed class EraUnitSpriteIndexItem
{
    public string UnitKey { get; }
    public string DisplayName { get; }
    public string RelativeDirectoryPath { get; }
    public string IconSpriteKey { get; }
    public string IconRelativePath { get; }
    public IReadOnlyList<string> WalkFrameSpriteKeys { get; }
    public IReadOnlyList<string> WalkFrameRelativePaths { get; }

    public EraUnitSpriteIndexItem(
        string unitKey,
        string displayName,
        string relativeDirectoryPath,
        string iconSpriteKey,
        string iconRelativePath,
        IReadOnlyList<string> walkFrameSpriteKeys,
        IReadOnlyList<string> walkFrameRelativePaths
    )
    {
        UnitKey = unitKey;
        DisplayName = displayName;
        RelativeDirectoryPath = relativeDirectoryPath;
        IconSpriteKey = iconSpriteKey;
        IconRelativePath = iconRelativePath;
        WalkFrameSpriteKeys = walkFrameSpriteKeys;
        WalkFrameRelativePaths = walkFrameRelativePaths;
    }
}

public sealed class EraSpriteSourceEntry
{
    public EraSpriteAssetGroup Group { get; }
    public string OwnerId { get; }
    public string Usage { get; }
    public string SpriteKey { get; }
    public string RelativePath { get; }

    public EraSpriteSourceEntry(EraSpriteAssetGroup group, string ownerId, string usage, string spriteKey, string relativePath)
    {
        Group = group;
        OwnerId = ownerId;
        Usage = usage;
        SpriteKey = spriteKey;
        RelativePath = relativePath;
    }
}

public sealed class EraSpriteIndex
{
    public static EraSpriteIndex Empty { get; } = new EraSpriteIndex(
        new List<EraTraitSpriteIndexItem>(),
        new List<EraTraitSpriteIndexItem>(),
        new List<EraEquipmentSpriteIndexItem>(),
        new List<EraDemonSpriteIndexItem>(),
        new List<EraUnitSpriteIndexItem>()
    );

    public IReadOnlyList<EraTraitSpriteIndexItem> PublicTraits { get; }
    public IReadOnlyList<EraTraitSpriteIndexItem> HeritageTraits { get; }
    public IReadOnlyList<EraEquipmentSpriteIndexItem> HeritageEquipment { get; }
    public IReadOnlyList<EraDemonSpriteIndexItem> Demons { get; }
    public IReadOnlyList<EraUnitSpriteIndexItem> Units { get; }

    public IReadOnlyDictionary<string, string> SpritePathByKey { get; }
    public int DuplicateKeyCount { get; }
    public int EmptyPathCount { get; }

    public EraSpriteIndex(
        IReadOnlyList<EraTraitSpriteIndexItem> publicTraits,
        IReadOnlyList<EraTraitSpriteIndexItem> heritageTraits,
        IReadOnlyList<EraEquipmentSpriteIndexItem> heritageEquipment,
        IReadOnlyList<EraDemonSpriteIndexItem> demons,
        IReadOnlyList<EraUnitSpriteIndexItem> units
    )
    {
        PublicTraits = publicTraits;
        HeritageTraits = heritageTraits;
        HeritageEquipment = heritageEquipment;
        Demons = demons;
        Units = units;

        Dictionary<string, string> pathByKey = new Dictionary<string, string>();
        int duplicateKeyCount = 0;
        int emptyPathCount = 0;
        foreach (EraSpriteSourceEntry source in EnumerateAllSources())
        {
            if (string.IsNullOrWhiteSpace(source.RelativePath))
            {
                emptyPathCount++;
                continue;
            }

            if (pathByKey.TryGetValue(source.SpriteKey, out string? existingPath))
            {
                if (!string.Equals(existingPath, source.RelativePath))
                {
                    duplicateKeyCount++;
                }
            }

            pathByKey[source.SpriteKey] = source.RelativePath;
        }

        SpritePathByKey = new ReadOnlyDictionary<string, string>(pathByKey);
        DuplicateKeyCount = duplicateKeyCount;
        EmptyPathCount = emptyPathCount;
    }

    public IEnumerable<EraSpriteSourceEntry> EnumerateAllSources()
    {
        foreach (EraTraitSpriteIndexItem trait in PublicTraits)
        {
            yield return new EraSpriteSourceEntry(
                EraSpriteAssetGroup.PublicTrait,
                trait.TraitId,
                "icon",
                trait.IconSpriteKey,
                trait.IconRelativePath
            );
            foreach (KeyValuePair<string, string> pair in ZipSpriteSources(trait.SkillSpriteKeys, trait.SkillRelativePaths))
            {
                yield return new EraSpriteSourceEntry(EraSpriteAssetGroup.PublicTrait, trait.TraitId, "skill", pair.Key, pair.Value);
            }
        }

        foreach (EraTraitSpriteIndexItem trait in HeritageTraits)
        {
            yield return new EraSpriteSourceEntry(
                EraSpriteAssetGroup.HeritageTrait,
                trait.TraitId,
                "icon",
                trait.IconSpriteKey,
                trait.IconRelativePath
            );
            foreach (KeyValuePair<string, string> pair in ZipSpriteSources(trait.SkillSpriteKeys, trait.SkillRelativePaths))
            {
                yield return new EraSpriteSourceEntry(EraSpriteAssetGroup.HeritageTrait, trait.TraitId, "skill", pair.Key, pair.Value);
            }
        }

        foreach (EraEquipmentSpriteIndexItem equipment in HeritageEquipment)
        {
            yield return new EraSpriteSourceEntry(
                EraSpriteAssetGroup.HeritageEquipment,
                equipment.EquipmentId,
                "icon",
                equipment.IconSpriteKey,
                equipment.IconRelativePath
            );
            foreach (KeyValuePair<string, string> pair in ZipSpriteSources(equipment.SkillSpriteKeys, equipment.SkillRelativePaths))
            {
                yield return new EraSpriteSourceEntry(EraSpriteAssetGroup.HeritageEquipment, equipment.EquipmentId, "skill", pair.Key, pair.Value);
            }
        }

        foreach (EraDemonSpriteIndexItem demon in Demons)
        {
            yield return new EraSpriteSourceEntry(
                EraSpriteAssetGroup.Demon,
                demon.DemonId,
                "unit_icon",
                demon.UnitIconSpriteKey,
                demon.UnitIconRelativePath
            );
            yield return new EraSpriteSourceEntry(
                EraSpriteAssetGroup.Demon,
                demon.DemonId,
                "stronghold",
                demon.StrongholdSpriteKey,
                demon.StrongholdRelativePath
            );
            foreach (KeyValuePair<string, string> pair in ZipSpriteSources(demon.SkillSpriteKeys, demon.SkillRelativePaths))
            {
                yield return new EraSpriteSourceEntry(EraSpriteAssetGroup.Demon, demon.DemonId, "skill", pair.Key, pair.Value);
            }
        }

        foreach (EraUnitSpriteIndexItem unit in Units)
        {
            if (!string.IsNullOrWhiteSpace(unit.IconSpriteKey))
            {
                yield return new EraSpriteSourceEntry(
                    EraSpriteAssetGroup.Unit,
                    unit.UnitKey,
                    "icon",
                    unit.IconSpriteKey,
                    unit.IconRelativePath
                );
            }

            foreach (KeyValuePair<string, string> pair in ZipSpriteSources(unit.WalkFrameSpriteKeys, unit.WalkFrameRelativePaths))
            {
                yield return new EraSpriteSourceEntry(EraSpriteAssetGroup.Unit, unit.UnitKey, "walk", pair.Key, pair.Value);
            }
        }
    }

    private static IEnumerable<KeyValuePair<string, string>> ZipSpriteSources(
        IReadOnlyList<string> keys,
        IReadOnlyList<string> paths
    )
    {
        int count = Math.Min(keys.Count, paths.Count);
        for (int index = 0; index < count; index++)
        {
            yield return new KeyValuePair<string, string>(keys[index], paths[index]);
        }
    }

    public string CreateStatusReport()
    {
        int publicTraitSkills = PublicTraits.Sum(item => item.SkillRelativePaths.Count);
        int heritageTraitSkills = HeritageTraits.Sum(item => item.SkillRelativePaths.Count);
        int equipmentSkills = HeritageEquipment.Sum(item => item.SkillRelativePaths.Count);
        int demonSkills = Demons.Sum(item => item.SkillRelativePaths.Count);
        int unitWalkFrames = Units.Sum(item => item.WalkFrameRelativePaths.Count);
        return
            $"公共特质={PublicTraits.Count}(技能图={publicTraitSkills})；轮回特质={HeritageTraits.Count}(技能图={heritageTraitSkills})；轮回装备={HeritageEquipment.Count}(技能图={equipmentSkills})；魔王={Demons.Count}(技能图={demonSkills})；单位目录={Units.Count}(行走帧={unitWalkFrames})；注册键={SpritePathByKey.Count}；重复键冲突={DuplicateKeyCount}；空路径={EmptyPathCount}。";
    }
}
