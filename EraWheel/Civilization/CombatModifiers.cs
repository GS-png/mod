using EraWheel.Config;
#if !ERAWHEEL_SELFTEST
using System;
using System.Collections.Generic;
using EraWheel.DemonLord;
#endif

namespace EraWheel.Civilization
{
    public static class CombatModifiers
    {
        public static float ApplyDamageDealt(ModConfig cfg, int antiDemonLevel, float baseDamage)
        {
            var mult = AntiDemonLevel.GetDamageDealtMultiplier(cfg, antiDemonLevel);
            if (baseDamage < 0f) baseDamage = 0f;
            return baseDamage * mult;
        }

        public static float ApplyDamageTaken(ModConfig cfg, int antiDemonLevel, float baseDamage)
        {
            var mult = AntiDemonLevel.GetDamageTakenMultiplier(cfg, antiDemonLevel);
            if (baseDamage < 0f) baseDamage = 0f;
            return baseDamage * mult;
        }

#if !ERAWHEEL_SELFTEST
        private struct DemonAssetStats
        {
            public bool HasDamage;
            public bool HasHealth;
            public bool HasArmor;
            public float Damage;
            public float Health;
            public float Armor;
        }

        private static readonly Dictionary<string, DemonAssetStats> DemonBaseStats =
            new Dictionary<string, DemonAssetStats>(StringComparer.Ordinal);

        private static HashSet<string> _demonAssetIds;

        public static void ResetDemonBaseStats()
        {
            DemonBaseStats.Clear();
        }

        public static bool ApplyToDemonAssets(ModConfig cfg, int antiDemonLevel)
        {
            if (!ActorAssetRegistry.EnsureRegistered()) return false;

            var library = AssetManager.actor_library;
            if (library == null || library.list == null) return false;

            EnsureDemonAssetIds();

            var damageDealtMultiplier = AntiDemonLevel.GetDamageDealtMultiplier(cfg, antiDemonLevel);
            var damageTakenMultiplier = AntiDemonLevel.GetDamageTakenMultiplier(cfg, antiDemonLevel);

            if (damageDealtMultiplier <= 0f) damageDealtMultiplier = 1f;
            if (damageTakenMultiplier <= 0f) damageTakenMultiplier = 1f;

            var healthMultiplier = 1f / damageDealtMultiplier;
            if (healthMultiplier < 0.1f) healthMultiplier = 0.1f;

            for (var i = 0; i < library.list.Count; i++)
            {
                var asset = library.list[i];
                if (asset == null || string.IsNullOrEmpty(asset.id)) continue;
                if (!_demonAssetIds.Contains(asset.id)) continue;

                var snapshot = GetOrCacheBaseStats(asset);
                var stats = asset.base_stats;
                if (stats == null) continue;

                if (snapshot.HasDamage)
                {
                    stats["damage"] = snapshot.Damage * damageTakenMultiplier;
                }

                if (snapshot.HasHealth)
                {
                    stats["health"] = snapshot.Health * healthMultiplier;
                }

                if (snapshot.HasArmor)
                {
                    stats["armor"] = snapshot.Armor * healthMultiplier;
                }
            }

            DemonActorRegistry.MarkAllStatsDirty();
            return true;
        }

        private static void EnsureDemonAssetIds()
        {
            if (_demonAssetIds != null) return;

            _demonAssetIds = new HashSet<string>(StringComparer.Ordinal);
            var lords = DemonLordFactory.CreateAll();
            for (var i = 0; i < lords.Length; i++)
            {
                var lord = lords[i];
                if (lord == null || string.IsNullOrEmpty(lord.Id)) continue;
                _demonAssetIds.Add(lord.Id);

                var templates = GeneralFactory.CreateTemplates(lord.Id);
                for (var t = 0; t < templates.Length; t++)
                {
                    var template = templates[t];
                    if (template == null || string.IsNullOrEmpty(template.Id)) continue;
                    _demonAssetIds.Add(template.Id);
                }
            }

            var legionIds = LegionUnitFactory.GetAllUnitIds();
            for (var i = 0; i < legionIds.Length; i++)
            {
                var id = legionIds[i];
                if (!string.IsNullOrEmpty(id))
                {
                    _demonAssetIds.Add(id);
                }
            }
        }

        private static DemonAssetStats GetOrCacheBaseStats(ActorAsset asset)
        {
            if (asset == null || string.IsNullOrEmpty(asset.id))
            {
                return new DemonAssetStats();
            }

            if (DemonBaseStats.TryGetValue(asset.id, out var cached))
            {
                return cached;
            }

            var stats = asset.base_stats;
            var snapshot = new DemonAssetStats();
            if (stats != null)
            {
                snapshot.HasDamage = stats.hasStat("damage");
                snapshot.HasHealth = stats.hasStat("health");
                snapshot.HasArmor = stats.hasStat("armor");

                if (snapshot.HasDamage) snapshot.Damage = stats.get("damage");
                if (snapshot.HasHealth) snapshot.Health = stats.get("health");
                if (snapshot.HasArmor) snapshot.Armor = stats.get("armor");
            }

            DemonBaseStats[asset.id] = snapshot;
            return snapshot;
        }
#endif
    }
}
