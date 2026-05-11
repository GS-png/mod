using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EraWheel.Combat.Statuses;
using EraWheel.Core.Constants;
using EraWheel.Data.Definitions;

namespace EraWheel.HotReload;

public static class EraAssetReconciliationService
{
    private static readonly BindingFlags AnyInstance = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

    public static HashSet<string> CaptureEraStatusIdsFromLibrary()
    {
        return CaptureLibraryIds(
            AssetManager.status,
            id => id.StartsWith("ew_status_", StringComparison.Ordinal)
        );
    }

    public static int RemoveStaleStatuses(HashSet<string> previousEraStatusIds)
    {
        if (previousEraStatusIds.Count == 0)
        {
            return 0;
        }

        HashSet<string> currentEraStatusIds = BuildCurrentEraStatusIds();
        int removed = 0;
        foreach (string statusId in previousEraStatusIds)
        {
            if (currentEraStatusIds.Contains(statusId))
            {
                continue;
            }

            if (TryRemoveFromLibrary(AssetManager.status, statusId))
            {
                removed++;
            }
        }

        return removed;
    }

    public static int RemoveStaleAssets(EraContentCatalog previousCatalog, EraContentCatalog currentCatalog)
    {
        int removed = 0;
        removed += RemoveStale(
            AssetManager.kingdoms,
            previousCatalog.Demons.Select(item => EraDemonFactionIds.GetKingdomId(item.InternalId)),
            currentCatalog.Demons.Select(item => EraDemonFactionIds.GetKingdomId(item.InternalId))
        );
        removed += RemoveStale(
            AssetManager.actor_library,
            previousCatalog.Demons.Select(item => item.InternalId)
                .Concat(previousCatalog.Generals.Select(item => item.InternalId))
                .Concat(previousCatalog.Legions.Select(item => item.InternalId)),
            currentCatalog.Demons.Select(item => item.InternalId)
                .Concat(currentCatalog.Generals.Select(item => item.InternalId))
                .Concat(currentCatalog.Legions.Select(item => item.InternalId))
        );
        removed += RemoveStale(
            AssetManager.buildings,
            previousCatalog.Strongholds.Select(item => item.BuildingId),
            currentCatalog.Strongholds.Select(item => item.BuildingId)
        );
        removed += RemoveStale(
            AssetManager.traits,
            previousCatalog.PublicTraits.Select(item => item.TraitId)
                .Concat(previousCatalog.HeritageTraits.Select(item => item.TraitId)),
            currentCatalog.PublicTraits.Select(item => item.TraitId)
                .Concat(currentCatalog.HeritageTraits.Select(item => item.TraitId))
        );
        removed += RemoveStaleEquipmentAssets(
            previousCatalog.HeritageEquipment.Select(item => item.EquipmentId),
            currentCatalog.HeritageEquipment.Select(item => item.EquipmentId)
        );
        return removed;
    }

    public static int RemoveEquipmentFromPools(IEnumerable<string> equipmentIds)
    {
        HashSet<string> ids = new HashSet<string>(equipmentIds, StringComparer.Ordinal);
        if (ids.Count == 0)
        {
            return 0;
        }

        int removed = 0;
        foreach (List<EquipmentAsset> pool in AssetManager.items.equipment_by_subtypes.Values)
        {
            removed += RemoveEquipmentFromPool(pool, ids);
        }

        foreach (List<EquipmentAsset> pool in AssetManager.items.pot_equipment_by_groups_all.Values)
        {
            removed += RemoveEquipmentFromPool(pool, ids);
        }

        foreach (List<EquipmentAsset> pool in AssetManager.items.pot_equipment_by_groups_unlocked.Values)
        {
            removed += RemoveEquipmentFromPool(pool, ids);
        }

        removed += RemoveEquipmentFromPool(AssetManager.items.pot_weapon_assets_all, ids);
        removed += RemoveEquipmentFromPool(AssetManager.items.pot_weapon_assets_unlocked, ids);
        return removed;
    }

    private static HashSet<string> BuildCurrentEraStatusIds()
    {
        HashSet<string> ids = new HashSet<string>(StringComparer.Ordinal)
        {
            EraStatusIds.CivilWarWinner,
        };

        foreach (EraStatusDefinition definition in EraCombatStatusCatalog.Definitions)
        {
            if (!definition.NativeStatus)
            {
                ids.Add(definition.StatusId);
            }
        }

        return ids;
    }

    private static HashSet<string> CaptureLibraryIds(object library, Func<string, bool> include)
    {
        HashSet<string> ids = new HashSet<string>(StringComparer.Ordinal);
        FieldInfo? dictField = library.GetType().GetField("dict", AnyInstance);
        if (dictField?.GetValue(library) is IDictionary dict)
        {
            foreach (object? key in dict.Keys)
            {
                if (key is string id && include(id))
                {
                    ids.Add(id);
                }
            }
        }

        FieldInfo? listField = library.GetType().GetField("list", AnyInstance);
        if (listField?.GetValue(library) is IList list)
        {
            for (int index = 0; index < list.Count; index++)
            {
                object? item = list[index];
                if (item == null)
                {
                    continue;
                }

                FieldInfo? idField = item.GetType().GetField("id", AnyInstance);
                if (idField?.GetValue(item) is string id && include(id))
                {
                    ids.Add(id);
                }
            }
        }

        return ids;
    }

    private static int RemoveStale(object library, IEnumerable<string> previousIds, IEnumerable<string> currentIds)
    {
        HashSet<string> current = new HashSet<string>(currentIds, StringComparer.Ordinal);
        int removed = 0;
        foreach (string id in previousIds.Distinct(StringComparer.Ordinal))
        {
            if (current.Contains(id))
            {
                continue;
            }

            if (TryRemoveFromLibrary(library, id))
            {
                removed++;
            }
        }

        return removed;
    }

    private static int RemoveStaleEquipmentAssets(IEnumerable<string> previousIds, IEnumerable<string> currentIds)
    {
        HashSet<string> current = new HashSet<string>(currentIds, StringComparer.Ordinal);
        List<string> staleIds = previousIds
            .Where(id => !current.Contains(id))
            .Distinct(StringComparer.Ordinal)
            .ToList();
        int removed = 0;
        foreach (string id in staleIds)
        {
            if (TryRemoveFromLibrary(AssetManager.items, id))
            {
                removed++;
            }
        }

        RemoveEquipmentFromPools(staleIds);
        return removed;
    }

    private static int RemoveEquipmentFromPool(List<EquipmentAsset> pool, HashSet<string> ids)
    {
        int removed = 0;
        for (int index = pool.Count - 1; index >= 0; index--)
        {
            EquipmentAsset? asset = pool[index];
            if (asset == null || !ids.Contains(asset.id))
            {
                continue;
            }

            pool.RemoveAt(index);
            removed++;
        }

        return removed;
    }

    private static bool TryRemoveFromLibrary(object library, string id)
    {
        bool removed = false;
        FieldInfo? dictField = library.GetType().GetField("dict", AnyInstance);
        if (dictField?.GetValue(library) is IDictionary dict && dict.Contains(id))
        {
            dict.Remove(id);
            removed = true;
        }

        FieldInfo? listField = library.GetType().GetField("list", AnyInstance);
        if (listField?.GetValue(library) is IList list)
        {
            for (int index = list.Count - 1; index >= 0; index--)
            {
                object? item = list[index];
                if (item == null)
                {
                    continue;
                }

                FieldInfo? idField = item.GetType().GetField("id", AnyInstance);
                string? itemId = idField?.GetValue(item) as string;
                if (!string.Equals(itemId, id, StringComparison.Ordinal))
                {
                    continue;
                }

                list.RemoveAt(index);
                removed = true;
            }
        }

        return removed;
    }
}
