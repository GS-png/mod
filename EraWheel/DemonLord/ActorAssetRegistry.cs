using System;
using System.Collections.Generic;
using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.DemonLord
{
    public static class ActorAssetRegistry
    {
        private static bool _registered;
        private static bool _warnedUnavailable;
        private static ModConfig _lastConfig;
        private static readonly Dictionary<string, UnitStatSnapshot> UnitStatSnapshots =
            new Dictionary<string, UnitStatSnapshot>(StringComparer.Ordinal);

        public static bool EnsureRegistered(ModConfig cfg = null)
        {
            if (cfg != null) _lastConfig = cfg;

            if (_registered) return true;

            var library = AssetManager.actor_library;
            if (library == null || library.list == null || library.list.Count == 0)
            {
                if (!_warnedUnavailable)
                {
                    _warnedUnavailable = true;
                    Log.Warning("[EraWheel] Actor asset library not ready, registration deferred.");
                }
                return false;
            }

            var baseAsset = PickBaseAsset(library);
            if (baseAsset == null)
            {
                Log.Warning("[EraWheel] No base ActorAsset found for registration.");
                return false;
            }

            RegisterDemonAssets(library, baseAsset);
            RegisterGeneralAssets(library, baseAsset);
            RegisterLegionAssets(library, baseAsset);

            _registered = true;
            ApplyConfigStats(cfg);
            Log.Info("[EraWheel] Actor assets registered.");
            return true;
        }

        private static ActorAsset PickBaseAsset(ActorAssetLibrary library)
        {
            if (library == null || library.list == null) return null;

            ActorAsset fallback = null;
            for (var i = 0; i < library.list.Count; i++)
            {
                var asset = library.list[i];
                if (asset == null) continue;
                if (fallback == null) fallback = asset;

                if (asset.count_as_unit && !asset.isTemplateAsset())
                {
                    return asset;
                }
            }

            return fallback;
        }

        private static void RegisterDemonAssets(ActorAssetLibrary library, ActorAsset baseAsset)
        {
            var lords = DemonLordFactory.CreateAll();
            for (var i = 0; i < lords.Length; i++)
            {
                var lord = lords[i];
                if (lord == null) continue;
                EnsureActorAsset(library, baseAsset, lord.Id, lord.NameKey);
            }
        }

        private static void RegisterGeneralAssets(ActorAssetLibrary library, ActorAsset baseAsset)
        {
            var lords = DemonLordFactory.CreateAll();
            var seen = new HashSet<string>(StringComparer.Ordinal);

            for (var i = 0; i < lords.Length; i++)
            {
                var lord = lords[i];
                if (lord == null) continue;

                var templates = GeneralFactory.CreateTemplates(lord.Id);
                for (var t = 0; t < templates.Length; t++)
                {
                    var template = templates[t];
                    if (template == null || string.IsNullOrEmpty(template.Id)) continue;
                    if (!seen.Add(template.Id)) continue;

                    EnsureActorAsset(library, baseAsset, template.Id, template.Id);
                }
            }
        }

        private static void RegisterLegionAssets(ActorAssetLibrary library, ActorAsset baseAsset)
        {
            var ids = LegionUnitFactory.GetAllUnitIds();
            for (var i = 0; i < ids.Length; i++)
            {
                var id = ids[i];
                if (string.IsNullOrEmpty(id)) continue;
                EnsureActorAsset(library, baseAsset, id, id);
            }
        }

        private static ActorAsset EnsureActorAsset(ActorAssetLibrary library, ActorAsset baseAsset, string id, string nameLocale)
        {
            if (library == null || baseAsset == null || string.IsNullOrEmpty(id)) return null;
            if (library.has(id)) return library.get(id);

            ActorAsset cloned;
            library.clone(out cloned, baseAsset);
            if (cloned == null) return null;

            cloned.id = id;
            cloned.base_asset_id = baseAsset.id;
            if (!string.IsNullOrEmpty(nameLocale))
            {
                cloned.name_locale = nameLocale;
            }

            cloned.civ = false;
            cloned.auto_civ = false;

            library.add(cloned);
            return cloned;
        }

        public static bool ApplyConfigStats(ModConfig cfg)
        {
            if (cfg != null) _lastConfig = cfg;
            cfg = cfg ?? _lastConfig;
            if (cfg == null) return false;

            if (!_registered)
            {
                return EnsureRegistered(cfg);
            }

            var library = AssetManager.actor_library;
            if (library == null || library.list == null || library.list.Count == 0)
            {
                return false;
            }

            ApplyDemonLordStats(cfg, library);
            ApplyGeneralStats(cfg, library);
            ApplyLegionStats(cfg, library);

            DemonActorRegistry.MarkAllStatsDirty();
            return true;
        }

        private static void ApplyDemonLordStats(ModConfig cfg, ActorAssetLibrary library)
        {
            if (cfg == null || cfg.demon_lord == null || cfg.demon_lord.stats == null || cfg.demon_lord.stats.lords == null)
            {
                return;
            }

            var lords = DemonLordFactory.CreateAll();
            for (var i = 0; i < lords.Length; i++)
            {
                var lord = lords[i];
                if (lord == null || string.IsNullOrEmpty(lord.Id)) continue;
                if (!library.has(lord.Id)) continue;

                var asset = library.get(lord.Id);
                var mult = GetLordMultiplier(cfg.demon_lord.stats.lords, lord.Id);
                ApplyStatMultipliers(asset, mult);
            }
        }

        private static void ApplyGeneralStats(ModConfig cfg, ActorAssetLibrary library)
        {
            if (cfg == null || cfg.demon_lord == null || cfg.demon_lord.stats == null || cfg.demon_lord.stats.general_roles == null)
            {
                return;
            }

            var lords = DemonLordFactory.CreateAll();
            var seen = new HashSet<string>(StringComparer.Ordinal);

            for (var i = 0; i < lords.Length; i++)
            {
                var lord = lords[i];
                if (lord == null) continue;

                var templates = GeneralFactory.CreateTemplates(lord.Id);
                for (var t = 0; t < templates.Length; t++)
                {
                    var template = templates[t];
                    if (template == null || string.IsNullOrEmpty(template.Id)) continue;
                    if (!seen.Add(template.Id)) continue;
                    if (!library.has(template.Id)) continue;

                    var asset = library.get(template.Id);
                    var mult = GetGeneralRoleMultiplier(cfg.demon_lord.stats.general_roles, template.Role);
                    ApplyStatMultipliers(asset, mult);
                }
            }
        }

        private static void ApplyLegionStats(ModConfig cfg, ActorAssetLibrary library)
        {
            if (cfg == null || cfg.demon_lord == null || cfg.demon_lord.stats == null || cfg.demon_lord.stats.legion_units == null)
            {
                return;
            }

            var ids = LegionUnitFactory.GetAllUnitIds();
            for (var i = 0; i < ids.Length; i++)
            {
                var id = ids[i];
                if (string.IsNullOrEmpty(id)) continue;
                if (!library.has(id)) continue;

                var asset = library.get(id);
                var mult = GetLegionMultiplier(cfg.demon_lord.stats.legion_units, id);
                ApplyStatMultipliers(asset, mult);
            }
        }

        private static UnitStatMultiplierConfig GetLordMultiplier(DemonLordStatsConfig cfg, string id)
        {
            if (cfg == null || string.IsNullOrEmpty(id)) return new UnitStatMultiplierConfig();

            switch (id)
            {
                case "void_lord": return cfg.void_lord;
                case "plague_lord": return cfg.plague_lord;
                case "machine_lord": return cfg.machine_lord;
                case "time_lord": return cfg.time_lord;
                case "flame_lord": return cfg.flame_lord;
                case "abyss_lord": return cfg.abyss_lord;
                case "death_lord": return cfg.death_lord;
                case "soul_lord": return cfg.soul_lord;
                case "nature_lord": return cfg.nature_lord;
                case "judgment_lord": return cfg.judgment_lord;
                default: return new UnitStatMultiplierConfig();
            }
        }

        private static UnitStatMultiplierConfig GetGeneralRoleMultiplier(GeneralRoleStatsConfig cfg, GeneralRole role)
        {
            if (cfg == null) return new UnitStatMultiplierConfig();

            switch (role)
            {
                case GeneralRole.Vanguard: return cfg.vanguard;
                case GeneralRole.Tank: return cfg.tank;
                case GeneralRole.DPS: return cfg.dps;
                case GeneralRole.Support: return cfg.support;
                case GeneralRole.Elite: return cfg.elite;
                default: return new UnitStatMultiplierConfig();
            }
        }

        private static UnitStatMultiplierConfig GetLegionMultiplier(LegionUnitStatsConfig cfg, string id)
        {
            if (cfg == null || string.IsNullOrEmpty(id)) return new UnitStatMultiplierConfig();

            switch (id)
            {
                case "legion_vanguard": return cfg.legion_vanguard;
                case "legion_main": return cfg.legion_main;
                case "legion_elite": return cfg.legion_elite;
                case "legion_ultimate": return cfg.legion_ultimate;
                default: return new UnitStatMultiplierConfig();
            }
        }

        private static void ApplyStatMultipliers(ActorAsset asset, UnitStatMultiplierConfig mult)
        {
            if (asset == null) return;
            if (mult == null) mult = new UnitStatMultiplierConfig();

            var snapshot = GetOrCacheSnapshot(asset);
            var stats = asset.base_stats ?? new BaseStats();
            asset.base_stats = stats;

            ApplyMultiplier(stats, "health", snapshot.HasHealth, snapshot.Health, mult.health);
            ApplyMultiplier(stats, "damage", snapshot.HasDamage, snapshot.Damage, mult.damage);
            ApplyMultiplier(stats, "armor", snapshot.HasArmor, snapshot.Armor, mult.armor);
            ApplyMultiplier(stats, "speed", snapshot.HasSpeed, snapshot.Speed, mult.speed);
        }

        private static void ApplyMultiplier(BaseStats stats, string statId, bool hasBase, float baseValue, float multiplier)
        {
            if (stats == null || !hasBase) return;
            if (multiplier <= 0f) return;
            stats[statId] = baseValue * multiplier;
        }

        private static UnitStatSnapshot GetOrCacheSnapshot(ActorAsset asset)
        {
            if (asset == null || string.IsNullOrEmpty(asset.id))
            {
                return new UnitStatSnapshot();
            }

            if (UnitStatSnapshots.TryGetValue(asset.id, out var snapshot))
            {
                return snapshot;
            }

            snapshot = CaptureSnapshot(asset.base_stats);
            UnitStatSnapshots[asset.id] = snapshot;

            if (asset.base_stats != null)
            {
                var cloned = asset.base_stats.Clone() as BaseStats;
                if (cloned != null)
                {
                    asset.base_stats = cloned;
                }
            }
            else
            {
                asset.base_stats = new BaseStats();
            }

            return snapshot;
        }

        private static UnitStatSnapshot CaptureSnapshot(BaseStats stats)
        {
            var snapshot = new UnitStatSnapshot();
            if (stats == null) return snapshot;

            snapshot.HasHealth = stats.hasStat("health");
            snapshot.HasDamage = stats.hasStat("damage");
            snapshot.HasArmor = stats.hasStat("armor");
            snapshot.HasSpeed = stats.hasStat("speed");

            if (snapshot.HasHealth) snapshot.Health = stats.get("health");
            if (snapshot.HasDamage) snapshot.Damage = stats.get("damage");
            if (snapshot.HasArmor) snapshot.Armor = stats.get("armor");
            if (snapshot.HasSpeed) snapshot.Speed = stats.get("speed");

            return snapshot;
        }

        private struct UnitStatSnapshot
        {
            public bool HasHealth;
            public bool HasDamage;
            public bool HasArmor;
            public bool HasSpeed;
            public float Health;
            public float Damage;
            public float Armor;
            public float Speed;
        }
    }
}
