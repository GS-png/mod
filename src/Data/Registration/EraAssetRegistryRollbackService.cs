using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EraWheel.Data.Registration;

internal static class EraAssetRegistryRollbackService
{
    private static readonly BindingFlags AnyInstance = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

    internal static EraAssetRegistrySnapshot CaptureRuntimeRegistry()
    {
        return new EraAssetRegistrySnapshot(
            CaptureLibrary(AssetManager.kingdoms, IsEraKingdomId),
            CaptureLibrary(AssetManager.actor_library, IsEraAssetId),
            CaptureLibrary(AssetManager.buildings, IsEraAssetId),
            CaptureLibrary(AssetManager.traits, IsEraAssetId),
            CaptureLibrary(AssetManager.items, IsEraAssetId),
            CaptureLibrary(AssetManager.status, IsEraStatusId),
            CaptureLibrary(AssetManager.trait_groups, IsEraAssetId),
            CaptureEquipmentPools()
        );
    }

    internal static bool TryRestoreRuntimeRegistry(EraAssetRegistrySnapshot snapshot, out string message)
    {
        List<string> failures = new List<string>();
        RestoreLibrary("kingdoms", snapshot.Kingdoms, failures);
        RestoreLibrary("actor_library", snapshot.ActorLibrary, failures);
        RestoreLibrary("buildings", snapshot.Buildings, failures);
        RestoreLibrary("traits", snapshot.Traits, failures);
        RestoreLibrary("items", snapshot.Items, failures);
        RestoreLibrary("status", snapshot.Statuses, failures);
        RestoreLibrary("trait_groups", snapshot.TraitGroups, failures);
        RestoreEquipmentPools(snapshot.EquipmentPools, failures);

        message = failures.Count == 0
            ? "AssetManager 注册表和装备池已恢复。"
            : $"AssetManager 注册表恢复不完整：{string.Join(" | ", failures.Take(6))}";
        return failures.Count == 0;
    }

    private static EraLibrarySnapshot CaptureLibrary(object library, Func<string, bool> include)
    {
        Dictionary<string, EraLibraryAssetSnapshot> items = new Dictionary<string, EraLibraryAssetSnapshot>(StringComparer.Ordinal);
        FieldInfo? dictField = library.GetType().GetField("dict", AnyInstance);
        if (dictField?.GetValue(library) is IDictionary dict)
        {
            foreach (object? key in dict.Keys)
            {
                if (key is not string id || !include(id))
                {
                    continue;
                }

                items[id] = new EraLibraryAssetSnapshot(id, dict[key], true, null);
            }
        }

        FieldInfo? listField = library.GetType().GetField("list", AnyInstance);
        if (listField?.GetValue(library) is IList list)
        {
            for (int index = 0; index < list.Count; index++)
            {
                object? asset = list[index];
                if (!TryGetAssetId(asset, out string id) || !include(id))
                {
                    continue;
                }

                if (items.TryGetValue(id, out EraLibraryAssetSnapshot? existing))
                {
                    existing.Asset ??= asset;
                    existing.ListIndex = index;
                }
                else
                {
                    items[id] = new EraLibraryAssetSnapshot(id, asset, false, index);
                }
            }
        }

        return new EraLibrarySnapshot(library, include, items.Values.ToList());
    }

    private static EraEquipmentPoolSnapshot CaptureEquipmentPools()
    {
        return new EraEquipmentPoolSnapshot(
            CopyPools(AssetManager.items.equipment_by_subtypes),
            CopyPools(AssetManager.items.pot_equipment_by_groups_all),
            CopyPools(AssetManager.items.pot_equipment_by_groups_unlocked),
            new List<EquipmentAsset>(AssetManager.items.pot_weapon_assets_all),
            new List<EquipmentAsset>(AssetManager.items.pot_weapon_assets_unlocked)
        );
    }

    private static Dictionary<string, List<EquipmentAsset>> CopyPools(Dictionary<string, List<EquipmentAsset>> source)
    {
        Dictionary<string, List<EquipmentAsset>> copy = new Dictionary<string, List<EquipmentAsset>>(StringComparer.Ordinal);
        foreach (KeyValuePair<string, List<EquipmentAsset>> entry in source)
        {
            copy[entry.Key] = new List<EquipmentAsset>(entry.Value);
        }

        return copy;
    }

    private static void RestoreLibrary(string label, EraLibrarySnapshot snapshot, List<string> failures)
    {
        try
        {
            FieldInfo? dictField = snapshot.Library.GetType().GetField("dict", AnyInstance);
            FieldInfo? listField = snapshot.Library.GetType().GetField("list", AnyInstance);
            IDictionary? dict = dictField?.GetValue(snapshot.Library) as IDictionary;
            IList? list = listField?.GetValue(snapshot.Library) as IList;

            if (dict != null)
            {
                List<string> removeKeys = new List<string>();
                foreach (object? key in dict.Keys)
                {
                    if (key is string id && snapshot.Include(id))
                    {
                        removeKeys.Add(id);
                    }
                }

                foreach (string id in removeKeys)
                {
                    dict.Remove(id);
                }
            }

            if (list != null)
            {
                for (int index = list.Count - 1; index >= 0; index--)
                {
                    object? asset = list[index];
                    if (TryGetAssetId(asset, out string id) && snapshot.Include(id))
                    {
                        list.RemoveAt(index);
                    }
                }
            }

            foreach (EraLibraryAssetSnapshot item in snapshot.Items)
            {
                item.RestoreFieldValues();
                if (item.InDictionary && dict != null)
                {
                    dict[item.Id] = item.Asset;
                }
            }

            if (list != null)
            {
                foreach (EraLibraryAssetSnapshot item in snapshot.Items
                             .Where(item => item.ListIndex.HasValue)
                             .OrderBy(item => item.ListIndex!.Value))
                {
                    int index = Math.Min(item.ListIndex!.Value, list.Count);
                    list.Insert(index, item.Asset);
                }
            }
        }
        catch (Exception exception)
        {
            failures.Add($"{label}: {exception.Message}");
        }
    }

    private static void RestoreEquipmentPools(EraEquipmentPoolSnapshot snapshot, List<string> failures)
    {
        try
        {
            RestorePools(AssetManager.items.equipment_by_subtypes, snapshot.EquipmentBySubtypes);
            RestorePools(AssetManager.items.pot_equipment_by_groups_all, snapshot.PotEquipmentByGroupsAll);
            RestorePools(AssetManager.items.pot_equipment_by_groups_unlocked, snapshot.PotEquipmentByGroupsUnlocked);
            RestorePool(AssetManager.items.pot_weapon_assets_all, snapshot.PotWeaponAssetsAll);
            RestorePool(AssetManager.items.pot_weapon_assets_unlocked, snapshot.PotWeaponAssetsUnlocked);
        }
        catch (Exception exception)
        {
            failures.Add($"equipment_pools: {exception.Message}");
        }
    }

    private static void RestorePools(
        Dictionary<string, List<EquipmentAsset>> target,
        IReadOnlyDictionary<string, List<EquipmentAsset>> snapshot)
    {
        target.Clear();
        foreach (KeyValuePair<string, List<EquipmentAsset>> entry in snapshot)
        {
            target[entry.Key] = new List<EquipmentAsset>(entry.Value);
        }
    }

    private static void RestorePool(List<EquipmentAsset> target, IReadOnlyList<EquipmentAsset> snapshot)
    {
        target.Clear();
        target.AddRange(snapshot);
    }

    private static bool TryGetAssetId(object? asset, out string id)
    {
        id = string.Empty;
        if (asset == null)
        {
            return false;
        }

        FieldInfo? idField = asset.GetType().GetField("id", AnyInstance);
        if (idField?.GetValue(asset) is not string value || string.IsNullOrWhiteSpace(value))
        {
            return false;
        }

        id = value;
        return true;
    }

    private static bool IsEraAssetId(string id)
    {
        return id.StartsWith("ew_", StringComparison.Ordinal);
    }

    private static bool IsEraKingdomId(string id)
    {
        return id.StartsWith("ew_demon_kingdom_", StringComparison.Ordinal);
    }

    private static bool IsEraStatusId(string id)
    {
        return id.StartsWith("ew_status_", StringComparison.Ordinal);
    }
}

internal sealed class EraAssetRegistrySnapshot
{
    internal EraLibrarySnapshot Kingdoms { get; }
    internal EraLibrarySnapshot ActorLibrary { get; }
    internal EraLibrarySnapshot Buildings { get; }
    internal EraLibrarySnapshot Traits { get; }
    internal EraLibrarySnapshot Items { get; }
    internal EraLibrarySnapshot Statuses { get; }
    internal EraLibrarySnapshot TraitGroups { get; }
    internal EraEquipmentPoolSnapshot EquipmentPools { get; }

    public EraAssetRegistrySnapshot(
        EraLibrarySnapshot kingdoms,
        EraLibrarySnapshot actorLibrary,
        EraLibrarySnapshot buildings,
        EraLibrarySnapshot traits,
        EraLibrarySnapshot items,
        EraLibrarySnapshot statuses,
        EraLibrarySnapshot traitGroups,
        EraEquipmentPoolSnapshot equipmentPools
    )
    {
        Kingdoms = kingdoms;
        ActorLibrary = actorLibrary;
        Buildings = buildings;
        Traits = traits;
        Items = items;
        Statuses = statuses;
        TraitGroups = traitGroups;
        EquipmentPools = equipmentPools;
    }
}

internal sealed class EraLibrarySnapshot
{
    internal object Library { get; }
    internal Func<string, bool> Include { get; }
    internal IReadOnlyList<EraLibraryAssetSnapshot> Items { get; }

    public EraLibrarySnapshot(object library, Func<string, bool> include, IReadOnlyList<EraLibraryAssetSnapshot> items)
    {
        Library = library;
        Include = include;
        Items = items;
    }
}

internal sealed class EraLibraryAssetSnapshot
{
    internal string Id { get; }
    internal object? Asset { get; set; }
    internal bool InDictionary { get; }
    internal int? ListIndex { get; set; }
    private readonly IReadOnlyList<EraFieldValueSnapshot> _fieldValues;

    public EraLibraryAssetSnapshot(string id, object? asset, bool inDictionary, int? listIndex)
    {
        Id = id;
        Asset = asset;
        InDictionary = inDictionary;
        ListIndex = listIndex;
        _fieldValues = CaptureFieldValues(asset);
    }

    public void RestoreFieldValues()
    {
        if (Asset == null)
        {
            return;
        }

        foreach (EraFieldValueSnapshot fieldValue in _fieldValues)
        {
            fieldValue.Restore(Asset);
        }
    }

    private static IReadOnlyList<EraFieldValueSnapshot> CaptureFieldValues(object? asset)
    {
        if (asset == null)
        {
            return Array.Empty<EraFieldValueSnapshot>();
        }

        List<EraFieldValueSnapshot> values = new List<EraFieldValueSnapshot>();
        foreach (FieldInfo field in asset.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
        {
            if (field.IsLiteral)
            {
                continue;
            }

            values.Add(new EraFieldValueSnapshot(field, field.GetValue(asset)));
        }

        return values;
    }
}

internal sealed class EraFieldValueSnapshot
{
    private readonly FieldInfo _field;
    private readonly object? _value;

    public EraFieldValueSnapshot(FieldInfo field, object? value)
    {
        _field = field;
        _value = value;
    }

    public void Restore(object asset)
    {
        if (_field.IsInitOnly || _field.IsLiteral)
        {
            return;
        }

        _field.SetValue(asset, _value);
    }
}

internal sealed class EraEquipmentPoolSnapshot
{
    internal IReadOnlyDictionary<string, List<EquipmentAsset>> EquipmentBySubtypes { get; }
    internal IReadOnlyDictionary<string, List<EquipmentAsset>> PotEquipmentByGroupsAll { get; }
    internal IReadOnlyDictionary<string, List<EquipmentAsset>> PotEquipmentByGroupsUnlocked { get; }
    internal IReadOnlyList<EquipmentAsset> PotWeaponAssetsAll { get; }
    internal IReadOnlyList<EquipmentAsset> PotWeaponAssetsUnlocked { get; }

    public EraEquipmentPoolSnapshot(
        IReadOnlyDictionary<string, List<EquipmentAsset>> equipmentBySubtypes,
        IReadOnlyDictionary<string, List<EquipmentAsset>> potEquipmentByGroupsAll,
        IReadOnlyDictionary<string, List<EquipmentAsset>> potEquipmentByGroupsUnlocked,
        IReadOnlyList<EquipmentAsset> potWeaponAssetsAll,
        IReadOnlyList<EquipmentAsset> potWeaponAssetsUnlocked
    )
    {
        EquipmentBySubtypes = equipmentBySubtypes;
        PotEquipmentByGroupsAll = potEquipmentByGroupsAll;
        PotEquipmentByGroupsUnlocked = potEquipmentByGroupsUnlocked;
        PotWeaponAssetsAll = potWeaponAssetsAll;
        PotWeaponAssetsUnlocked = potWeaponAssetsUnlocked;
    }
}
