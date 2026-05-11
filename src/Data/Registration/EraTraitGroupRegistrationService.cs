using System.Collections.Generic;
using EraWheel.Core.Constants;
using EraWheel.Localization;
using NeoModLoader.General;

namespace EraWheel.Data.Registration;

public sealed class EraTraitGroupRegistrationReport
{
    public int AddedCount { get; }
    public int UpdatedCount { get; }

    public EraTraitGroupRegistrationReport(int addedCount, int updatedCount)
    {
        AddedCount = addedCount;
        UpdatedCount = updatedCount;
    }

    public string CreateStatusReport()
    {
        return $"新增={AddedCount}，更新={UpdatedCount}。";
    }
}

public static class EraTraitGroupRegistrationService
{
    public static EraTraitGroupRegistrationReport Register()
    {
        int added = 0;
        int updated = 0;

        foreach (EraTraitGroupDefinition definition in BuildDefinitions())
        {
            EraLocaleRegistrar.AddZhEn(definition.LocaleKey, definition.ZhName, definition.EnName);
            if (UpsertGroup(definition))
            {
                added++;
            }
            else
            {
                updated++;
            }
        }

        if (LocalizedTextManager.instance != null)
        {
            LM.ApplyLocale(false);
        }

        return new EraTraitGroupRegistrationReport(added, updated);
    }

    private static bool UpsertGroup(EraTraitGroupDefinition definition)
    {
        ActorTraitGroupAsset? existing = AssetManager.trait_groups.get(definition.GroupId);
        if (existing != null)
        {
            existing.name = definition.LocaleKey;
            existing.color = EraTraitGroupIds.GroupColor;
            return false;
        }

        AssetManager.trait_groups.add(new ActorTraitGroupAsset
        {
            id = definition.GroupId,
            name = definition.LocaleKey,
            color = EraTraitGroupIds.GroupColor,
        });
        return true;
    }

    private static IReadOnlyList<EraTraitGroupDefinition> BuildDefinitions()
    {
        List<EraTraitGroupDefinition> definitions = new()
        {
            new EraTraitGroupDefinition(
                EraTraitGroupIds.PublicTraits,
                EraTraitGroupIds.PublicTraitsLocaleKey,
                "公共特质",
                "Public Traits"
            ),
        };

        for (int tier = EraTraitGroupIds.MinHeritageTier; tier <= EraTraitGroupIds.MaxHeritageTier; tier++)
        {
            definitions.Add(
                new EraTraitGroupDefinition(
                    EraTraitGroupIds.HeritageTier(tier),
                    EraTraitGroupIds.HeritageTierLocaleKey(tier),
                    $"轮回 T{tier}",
                    $"Reincarnation T{tier}"
                )
            );
        }

        return definitions;
    }

    private readonly struct EraTraitGroupDefinition
    {
        public string GroupId { get; }
        public string LocaleKey { get; }
        public string ZhName { get; }
        public string EnName { get; }

        public EraTraitGroupDefinition(string groupId, string localeKey, string zhName, string enName)
        {
            GroupId = groupId;
            LocaleKey = localeKey;
            ZhName = zhName;
            EnName = enName;
        }
    }
}
