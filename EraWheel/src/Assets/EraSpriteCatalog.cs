using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EraWheel.Core.Constants;
using UnityEngine;

namespace EraWheel.Assets;

public sealed class EraSpriteResource
{
    public string RuntimePathId { get; }
    public string SourcePath { get; }
    public Sprite? Sprite { get; }

    public bool IsLoaded => Sprite != null;

    public EraSpriteResource(string runtimePathId, string sourcePath, Sprite? sprite)
    {
        RuntimePathId = runtimePathId;
        SourcePath = sourcePath;
        Sprite = sprite;
    }
}

public sealed class EraIndexedSpriteSet
{
    public string EntryId { get; }
    public string DisplayName { get; }
    public EraSpriteResource? Icon { get; }
    public IReadOnlyList<EraSpriteResource> DetailSprites { get; }

    public EraIndexedSpriteSet(
        string entryId,
        string displayName,
        EraSpriteResource? icon,
        IReadOnlyList<EraSpriteResource> detailSprites
    )
    {
        EntryId = entryId;
        DisplayName = displayName;
        Icon = icon;
        DetailSprites = detailSprites;
    }
}

public sealed class EraDemonSpriteSet
{
    public string DemonId { get; }
    public string DisplayName { get; }
    public EraSpriteResource? UnitIcon { get; }
    public IReadOnlyList<EraSpriteResource> UnitWalkFrames { get; }
    public EraSpriteResource? StrongholdIcon { get; }
    public IReadOnlyDictionary<string, IReadOnlyList<EraSpriteResource>> SkillSpritesByGroup { get; }

    public EraDemonSpriteSet(
        string demonId,
        string displayName,
        EraSpriteResource? unitIcon,
        IReadOnlyList<EraSpriteResource> unitWalkFrames,
        EraSpriteResource? strongholdIcon,
        IReadOnlyDictionary<string, IReadOnlyList<EraSpriteResource>> skillSpritesByGroup
    )
    {
        DemonId = demonId;
        DisplayName = displayName;
        UnitIcon = unitIcon;
        UnitWalkFrames = unitWalkFrames;
        StrongholdIcon = strongholdIcon;
        SkillSpritesByGroup = skillSpritesByGroup;
    }
}

public sealed class EraUnitSpriteSet
{
    public string GroupKey { get; }
    public string DisplayName { get; }
    public EraSpriteResource? Icon { get; }
    public IReadOnlyList<EraSpriteResource> WalkFrames { get; }
    public IReadOnlyList<EraSpriteResource> ExtraFrames { get; }

    public EraUnitSpriteSet(
        string groupKey,
        string displayName,
        EraSpriteResource? icon,
        IReadOnlyList<EraSpriteResource> walkFrames,
        IReadOnlyList<EraSpriteResource> extraFrames
    )
    {
        GroupKey = groupKey;
        DisplayName = displayName;
        Icon = icon;
        WalkFrames = walkFrames;
        ExtraFrames = extraFrames;
    }
}

public sealed class EraSpriteCatalog
{
    public static EraSpriteCatalog Empty { get; } = new(
        null,
        null,
        null,
        new Dictionary<EraModuleId, EraSpriteResource>(),
        new Dictionary<string, EraIndexedSpriteSet>(),
        new Dictionary<string, EraIndexedSpriteSet>(),
        new Dictionary<string, EraIndexedSpriteSet>(),
        new Dictionary<string, EraDemonSpriteSet>(),
        new Dictionary<string, EraUnitSpriteSet>(),
        new Dictionary<string, string>(),
        new Dictionary<string, string>(),
        new Dictionary<string, string>()
    );

    public EraSpriteResource? ModIcon { get; }
    public EraSpriteResource? TopTabIcon { get; }
    public EraSpriteResource? HudBranch9Crest { get; }

    public IReadOnlyDictionary<EraModuleId, EraSpriteResource> EntryButtonsByModuleId { get; }
    public IReadOnlyDictionary<string, EraIndexedSpriteSet> PublicTraitsById { get; }
    public IReadOnlyDictionary<string, EraIndexedSpriteSet> HeritageTraitsById { get; }
    public IReadOnlyDictionary<string, EraIndexedSpriteSet> HeritageEquipmentById { get; }
    public IReadOnlyDictionary<string, EraDemonSpriteSet> DemonsById { get; }
    public IReadOnlyDictionary<string, EraUnitSpriteSet> UnitGroupsByKey { get; }
    public IReadOnlyDictionary<string, string> DemonUnitGroupKeysById { get; }
    public IReadOnlyDictionary<string, string> GeneralUnitGroupKeysById { get; }
    public IReadOnlyDictionary<string, string> LegionUnitGroupKeysById { get; }

    public EraSpriteCatalog(
        EraSpriteResource? modIcon,
        EraSpriteResource? topTabIcon,
        EraSpriteResource? hudBranch9Crest,
        IReadOnlyDictionary<EraModuleId, EraSpriteResource> entryButtonsByModuleId,
        IReadOnlyDictionary<string, EraIndexedSpriteSet> publicTraitsById,
        IReadOnlyDictionary<string, EraIndexedSpriteSet> heritageTraitsById,
        IReadOnlyDictionary<string, EraIndexedSpriteSet> heritageEquipmentById,
        IReadOnlyDictionary<string, EraDemonSpriteSet> demonsById,
        IReadOnlyDictionary<string, EraUnitSpriteSet> unitGroupsByKey,
        IReadOnlyDictionary<string, string> demonUnitGroupKeysById,
        IReadOnlyDictionary<string, string> generalUnitGroupKeysById,
        IReadOnlyDictionary<string, string> legionUnitGroupKeysById
    )
    {
        ModIcon = modIcon;
        TopTabIcon = topTabIcon;
        HudBranch9Crest = hudBranch9Crest;
        EntryButtonsByModuleId = new ReadOnlyDictionary<EraModuleId, EraSpriteResource>(
            new Dictionary<EraModuleId, EraSpriteResource>(entryButtonsByModuleId)
        );
        PublicTraitsById = new ReadOnlyDictionary<string, EraIndexedSpriteSet>(new Dictionary<string, EraIndexedSpriteSet>(publicTraitsById));
        HeritageTraitsById = new ReadOnlyDictionary<string, EraIndexedSpriteSet>(new Dictionary<string, EraIndexedSpriteSet>(heritageTraitsById));
        HeritageEquipmentById = new ReadOnlyDictionary<string, EraIndexedSpriteSet>(new Dictionary<string, EraIndexedSpriteSet>(heritageEquipmentById));
        DemonsById = new ReadOnlyDictionary<string, EraDemonSpriteSet>(new Dictionary<string, EraDemonSpriteSet>(demonsById));
        UnitGroupsByKey = new ReadOnlyDictionary<string, EraUnitSpriteSet>(new Dictionary<string, EraUnitSpriteSet>(unitGroupsByKey));
        DemonUnitGroupKeysById = new ReadOnlyDictionary<string, string>(new Dictionary<string, string>(demonUnitGroupKeysById));
        GeneralUnitGroupKeysById = new ReadOnlyDictionary<string, string>(new Dictionary<string, string>(generalUnitGroupKeysById));
        LegionUnitGroupKeysById = new ReadOnlyDictionary<string, string>(new Dictionary<string, string>(legionUnitGroupKeysById));
    }

    public string CreateStatusReport()
    {
        int entryButtonIcons = EntryButtonsByModuleId.Values.Count(item => item.IsLoaded);
        int publicTraitIcons = CountLoadedIcons(PublicTraitsById.Values);
        int publicTraitDetails = CountDetailSprites(PublicTraitsById.Values);
        int heritageTraitIcons = CountLoadedIcons(HeritageTraitsById.Values);
        int heritageTraitDetails = CountDetailSprites(HeritageTraitsById.Values);
        int heritageEquipmentIcons = CountLoadedIcons(HeritageEquipmentById.Values);
        int heritageEquipmentDetails = CountDetailSprites(HeritageEquipmentById.Values);
        int demonUnitIcons = DemonsById.Values.Count(item => item.UnitIcon?.IsLoaded == true);
        int demonStrongholds = DemonsById.Values.Count(item => item.StrongholdIcon?.IsLoaded == true);
        int demonSkillGroups = DemonsById.Values.Sum(item => item.SkillSpritesByGroup.Count);
        int demonSkillSprites = DemonsById.Values.Sum(item => item.SkillSpritesByGroup.Values.Sum(group => group.Count));
        int unitIcons = UnitGroupsByKey.Values.Count(item => item.Icon?.IsLoaded == true);
        int legionIcons = LegionUnitGroupKeysById.Values.Count(
            key => UnitGroupsByKey.TryGetValue(key, out EraUnitSpriteSet? set) && set.Icon?.IsLoaded == true
        );
        int unitWalkFrames = UnitGroupsByKey.Values.Sum(item => item.WalkFrames.Count);
        return $"MOD图标={(ModIcon?.IsLoaded == true ? 1 : 0)}；页签图标={(TopTabIcon?.IsLoaded == true ? 1 : 0)}；HUD徽记={(HudBranch9Crest?.IsLoaded == true ? 1 : 0)}；入口按钮图标={entryButtonIcons}/{EntryButtonsByModuleId.Count}；公共特质图标={publicTraitIcons}/{PublicTraitsById.Count}；公共特质技能图={publicTraitDetails}；轮回特质图标={heritageTraitIcons}/{HeritageTraitsById.Count}；轮回特质技能图={heritageTraitDetails}；轮回装备图标={heritageEquipmentIcons}/{HeritageEquipmentById.Count}；轮回装备技能图={heritageEquipmentDetails}；魔王头像={demonUnitIcons}/{DemonsById.Count}；据点图={demonStrongholds}/{DemonsById.Count}；魔王技能组={demonSkillGroups}；魔王技能图={demonSkillSprites}；单位组={UnitGroupsByKey.Count}；单位头像={unitIcons}；军团头像={legionIcons}/{LegionUnitGroupKeysById.Count}；行走帧={unitWalkFrames}。";
    }

    private static int CountLoadedIcons(IEnumerable<EraIndexedSpriteSet> entries)
    {
        return entries.Count(item => item.Icon?.IsLoaded == true);
    }

    private static int CountDetailSprites(IEnumerable<EraIndexedSpriteSet> entries)
    {
        return entries.Sum(item => item.DetailSprites.Count);
    }
}
