using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EraWheel.Data.Bestiary;

public enum EraBestiaryEntryKind
{
    Demon = 0,
    General = 1,
    Legion = 2,
    Stronghold = 3,
    HeritageEquipment = 4,
    HeritageTrait = 5,
    PublicTrait = 6,
}

public sealed class EraBestiaryEntry
{
    public string EntryId { get; }
    public EraBestiaryEntryKind Kind { get; }
    public string DisplayName { get; }
    public string Summary { get; }
    public string DetailText { get; }
    public string IconRuntimePath { get; }
    public string IconSourcePath { get; }
    public string RelatedDemonId { get; }
    public int UnlockTier { get; }
    public string BaseTemplateId { get; }
    public IReadOnlyList<string> DetailSpriteRuntimePaths { get; }

    public EraBestiaryEntry(
        string entryId,
        EraBestiaryEntryKind kind,
        string displayName,
        string summary,
        string detailText,
        string iconRuntimePath,
        string iconSourcePath,
        string relatedDemonId,
        int unlockTier,
        string baseTemplateId,
        IReadOnlyList<string> detailSpriteRuntimePaths
    )
    {
        EntryId = entryId;
        Kind = kind;
        DisplayName = displayName;
        Summary = summary;
        DetailText = detailText;
        IconRuntimePath = iconRuntimePath;
        IconSourcePath = iconSourcePath;
        RelatedDemonId = relatedDemonId;
        UnlockTier = unlockTier;
        BaseTemplateId = baseTemplateId;
        DetailSpriteRuntimePaths = detailSpriteRuntimePaths;
    }
}

public sealed class EraBestiaryCatalog
{
    public static EraBestiaryCatalog Empty { get; } = new EraBestiaryCatalog(new List<EraBestiaryEntry>());

    public IReadOnlyList<EraBestiaryEntry> Entries { get; }
    public IReadOnlyDictionary<string, EraBestiaryEntry> EntriesById { get; }

    public EraBestiaryCatalog(IReadOnlyList<EraBestiaryEntry> entries)
    {
        Entries = entries;
        EntriesById = new ReadOnlyDictionary<string, EraBestiaryEntry>(
            entries.ToDictionary(item => item.EntryId, item => item)
        );
    }

    public string CreateStatusReport()
    {
        int demons = Entries.Count(item => item.Kind == EraBestiaryEntryKind.Demon);
        int generals = Entries.Count(item => item.Kind == EraBestiaryEntryKind.General);
        int legions = Entries.Count(item => item.Kind == EraBestiaryEntryKind.Legion);
        int strongholds = Entries.Count(item => item.Kind == EraBestiaryEntryKind.Stronghold);
        int equipment = Entries.Count(item => item.Kind == EraBestiaryEntryKind.HeritageEquipment);
        int heritageTraits = Entries.Count(item => item.Kind == EraBestiaryEntryKind.HeritageTrait);
        int publicTraits = Entries.Count(item => item.Kind == EraBestiaryEntryKind.PublicTrait);
        return $"图鉴条目={Entries.Count}；魔王={demons}；将领={generals}；军团={legions}；据点={strongholds}；装备={equipment}；轮回特质={heritageTraits}；公共特质={publicTraits}。";
    }
}
