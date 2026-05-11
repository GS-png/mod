using System;
using System.Collections.Generic;

namespace EraWheel.Data.Definitions;

public sealed class EraHeritageEquipmentSlotSpec
{
    public EraHeritageEquipmentSlotKind SlotKind { get; }
    public string BaseTemplateId { get; }
    public string VisualReferenceAssetId { get; }
    public EquipmentType EquipmentType { get; }
    public string EquipmentSubtype { get; }
    public string GroupId { get; }
    public bool IsPoolWeapon { get; }
    public WeaponType? AttackType { get; }
    public string PathSlashAnimation { get; }
    public string Projectile { get; }
    public int? RigidityRating { get; }
    public IReadOnlyDictionary<string, float> BaseStatOverrides { get; }

    public EraHeritageEquipmentSlotSpec(
        EraHeritageEquipmentSlotKind slotKind,
        string baseTemplateId,
        string visualReferenceAssetId,
        EquipmentType equipmentType,
        string equipmentSubtype,
        string groupId,
        bool isPoolWeapon,
        WeaponType? attackType = null,
        string pathSlashAnimation = "",
        string projectile = "",
        int? rigidityRating = null,
        IReadOnlyDictionary<string, float>? baseStatOverrides = null
    )
    {
        SlotKind = slotKind;
        BaseTemplateId = baseTemplateId ?? string.Empty;
        VisualReferenceAssetId = visualReferenceAssetId ?? string.Empty;
        EquipmentType = equipmentType;
        EquipmentSubtype = equipmentSubtype ?? string.Empty;
        GroupId = groupId ?? string.Empty;
        IsPoolWeapon = isPoolWeapon;
        AttackType = attackType;
        PathSlashAnimation = pathSlashAnimation ?? string.Empty;
        Projectile = projectile ?? string.Empty;
        RigidityRating = rigidityRating;
        BaseStatOverrides = baseStatOverrides ??
                            new Dictionary<string, float>(StringComparer.Ordinal);
    }
}

public static class EraHeritageEquipmentSlotSpecs
{
    private static readonly IReadOnlyDictionary<EraHeritageEquipmentSlotKind, EraHeritageEquipmentSlotSpec> Specs =
        new Dictionary<EraHeritageEquipmentSlotKind, EraHeritageEquipmentSlotSpec>
        {
            [EraHeritageEquipmentSlotKind.Sword] = new(
                EraHeritageEquipmentSlotKind.Sword,
                "$sword",
                "sword_adamantine",
                EquipmentType.Weapon,
                "sword",
                "sword",
                isPoolWeapon: true,
                attackType: WeaponType.Melee,
                pathSlashAnimation: "effects/slashes/slash_sword"
            ),
            [EraHeritageEquipmentSlotKind.Axe] = new(
                EraHeritageEquipmentSlotKind.Axe,
                "$axe",
                "axe_adamantine",
                EquipmentType.Weapon,
                "axe",
                "axe",
                isPoolWeapon: true,
                attackType: WeaponType.Melee,
                pathSlashAnimation: "effects/slashes/slash_axe"
            ),
            [EraHeritageEquipmentSlotKind.Spear] = new(
                EraHeritageEquipmentSlotKind.Spear,
                "$spear",
                "spear_adamantine",
                EquipmentType.Weapon,
                "spear",
                "spear",
                isPoolWeapon: true,
                attackType: WeaponType.Melee,
                pathSlashAnimation: "effects/slashes/slash_spear"
            ),
            [EraHeritageEquipmentSlotKind.Bow] = new(
                EraHeritageEquipmentSlotKind.Bow,
                "$bow",
                "bow_adamantine",
                EquipmentType.Weapon,
                "bow",
                "bow",
                isPoolWeapon: true,
                attackType: WeaponType.Range,
                pathSlashAnimation: "effects/slashes/slash_bow",
                projectile: "arrow"
            ),
            [EraHeritageEquipmentSlotKind.Hammer] = new(
                EraHeritageEquipmentSlotKind.Hammer,
                "$hammer",
                "hammer_adamantine",
                EquipmentType.Weapon,
                "hammer",
                "hammer",
                isPoolWeapon: true,
                attackType: WeaponType.Melee,
                pathSlashAnimation: "effects/slashes/slash_hammer"
            ),
            [EraHeritageEquipmentSlotKind.Staff] = new(
                EraHeritageEquipmentSlotKind.Staff,
                "$range",
                "druid_staff",
                EquipmentType.Weapon,
                "staff",
                "staff",
                isPoolWeapon: true,
                attackType: WeaponType.Range,
                pathSlashAnimation: "effects/slashes/slash_punch",
                projectile: "green_orb",
                rigidityRating: 5,
                baseStatOverrides: new Dictionary<string, float>(StringComparer.Ordinal)
                {
                    ["range"] = 20f,
                    ["critical_chance"] = 0.1f,
                    ["targets"] = 1f,
                    ["critical_damage_multiplier"] = 0.3f,
                    ["damage"] = 12f,
                    ["mana"] = 40f,
                    ["projectiles"] = 2f,
                }
            ),
            [EraHeritageEquipmentSlotKind.Firearm] = new(
                EraHeritageEquipmentSlotKind.Firearm,
                "$range",
                "shotgun",
                EquipmentType.Weapon,
                "firearm",
                "firearm",
                isPoolWeapon: true,
                attackType: WeaponType.Range,
                pathSlashAnimation: "effects/slashes/slash_punch",
                projectile: "shotgun_bullet",
                rigidityRating: 6,
                baseStatOverrides: new Dictionary<string, float>(StringComparer.Ordinal)
                {
                    ["projectiles"] = 12f,
                    ["range"] = 10f,
                    ["targets"] = 1f,
                    ["damage"] = 10f,
                    ["damage_range"] = 0.9f,
                    ["mana"] = 5f,
                    ["stamina"] = 10f,
                }
            ),
            [EraHeritageEquipmentSlotKind.Helmet] = new(
                EraHeritageEquipmentSlotKind.Helmet,
                "$helmet",
                "helmet_adamantine",
                EquipmentType.Helmet,
                "helmet",
                "helmet",
                isPoolWeapon: false
            ),
            [EraHeritageEquipmentSlotKind.Armor] = new(
                EraHeritageEquipmentSlotKind.Armor,
                "$armor",
                "armor_adamantine",
                EquipmentType.Armor,
                "armor",
                "armor",
                isPoolWeapon: false
            ),
            [EraHeritageEquipmentSlotKind.Boots] = new(
                EraHeritageEquipmentSlotKind.Boots,
                "$boots",
                "boots_adamantine",
                EquipmentType.Boots,
                "boots",
                "boots",
                isPoolWeapon: false
            ),
            [EraHeritageEquipmentSlotKind.Ring] = new(
                EraHeritageEquipmentSlotKind.Ring,
                "$ring",
                "ring_adamantine",
                EquipmentType.Ring,
                "ring",
                "ring",
                isPoolWeapon: false
            ),
            [EraHeritageEquipmentSlotKind.Amulet] = new(
                EraHeritageEquipmentSlotKind.Amulet,
                "$amulet",
                "amulet_adamantine",
                EquipmentType.Amulet,
                "amulet",
                "amulet",
                isPoolWeapon: false
            ),
        };

    public static bool TryGet(EraHeritageEquipmentSlotKind slotKind, out EraHeritageEquipmentSlotSpec spec)
    {
        if (Specs.TryGetValue(slotKind, out EraHeritageEquipmentSlotSpec? existing) && existing != null)
        {
            spec = existing;
            return true;
        }

        spec = null!;
        return false;
    }

    public static EraHeritageEquipmentSlotSpec? Get(EraHeritageEquipmentSlotKind slotKind)
    {
        return TryGet(slotKind, out EraHeritageEquipmentSlotSpec spec) ? spec : null;
    }
}
