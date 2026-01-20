using System;
using System.Reflection;

namespace EraWheel.Core
{
    public static class LegacyTraitFactory
    {
        private static bool _registered;
        private static object _traitsCollection;

        public static void EnsureRegistered()
        {
            if (_registered) return;

            if (!TryResolveTraitsCollection()) return;

            _registered = true;

            TryRegisterLegacyTrait("legacy_warrior", "战士之魂", "先祖的战斗智慧流淌在血液中", damageMultiplier: 1.10f);
            TryRegisterLegacyTrait("legacy_armor", "铁甲守护", "坚固的意志化作护甲", armorMultiplier: 1.15f);
            TryRegisterLegacyTrait("legacy_scholar", "学者智慧", "知识的火种永不熄灭", null, null, null);
            TryRegisterLegacyTrait("legacy_hero", "英雄血脉", "传奇的血脉代代相传", null, null, null);
            TryRegisterLegacyTrait("legacy_curse", "瘟疫印记", "魔王的诅咒永远不会消散", healthMultiplier: 0.90f, isNegative: true);
        }

        private static bool TryResolveTraitsCollection()
        {
            if (_traitsCollection != null) return true;

            try
            {
                var actorTraitType = CompatReflection.FindTypeByName("ActorTrait");
                if (actorTraitType == null) return false;

                var assetManagerType = CompatReflection.FindTypeByName("AssetManager");
                if (assetManagerType == null) return false;

                var traitsField = assetManagerType.GetField("traits", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
                _traitsCollection = traitsField != null ? traitsField.GetValue(null) : null;
                return _traitsCollection != null;
            }
            catch
            {
                return false;
            }
        }

        private static void TryRegisterLegacyTrait(string id, string name, string desc, float? damageMultiplier = null, float? armorMultiplier = null,
            float? healthMultiplier = null, bool isNegative = false)
        {
            if (string.IsNullOrEmpty(id)) return;

            if (_traitsCollection == null)
            {
                if (!TryResolveTraitsCollection()) return;
            }

            try
            {
                var actorTraitType = CompatReflection.FindTypeByName("ActorTrait");
                if (actorTraitType == null) return;

                var trait = Activator.CreateInstance(actorTraitType);
                if (trait == null) return;

                TrySetMember(trait, "id", id);
                TrySetMember(trait, "nameLocale", name);
                TrySetMember(trait, "descriptionLocale", desc);

                var traitGroupType = CompatReflection.FindTypeByName("TraitGroup");
                if (traitGroupType != null && traitGroupType.IsEnum)
                {
                    var enumName = isNegative ? "Negative" : "Positive";
                    try
                    {
                        var groupValue = Enum.Parse(traitGroupType, enumName);
                        TrySetMember(trait, "group", groupValue);
                    }
                    catch
                    {
                    }
                }

                var baseStatsObj = TryGetMember(trait, "baseStats");
                if (baseStatsObj != null)
                {
                    if (damageMultiplier.HasValue) TrySetMember(baseStatsObj, "damage", damageMultiplier.Value);
                    if (armorMultiplier.HasValue) TrySetMember(baseStatsObj, "armor", armorMultiplier.Value);
                    if (healthMultiplier.HasValue) TrySetMember(baseStatsObj, "health", healthMultiplier.Value);
                }

                var addMethod = _traitsCollection.GetType().GetMethod("add", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (addMethod == null) return;

                addMethod.Invoke(_traitsCollection, new[] { trait });
            }
            catch
            {
            }
        }

        private static void TrySetMember(object obj, string name, object value)
        {
            if (obj == null || string.IsNullOrEmpty(name)) return;

            var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;
            try
            {
                var f = obj.GetType().GetField(name, flags);
                if (f != null)
                {
                    f.SetValue(obj, value);
                    return;
                }

                var p = obj.GetType().GetProperty(name, flags);
                if (p != null && p.CanWrite)
                {
                    p.SetValue(obj, value, null);
                }
            }
            catch
            {
            }
        }

        private static object TryGetMember(object obj, string name)
        {
            if (obj == null || string.IsNullOrEmpty(name)) return null;

            var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;
            try
            {
                var f = obj.GetType().GetField(name, flags);
                if (f != null) return f.GetValue(obj);

                var p = obj.GetType().GetProperty(name, flags);
                if (p != null && p.CanRead) return p.GetValue(obj, null);
            }
            catch
            {
            }

            return null;
        }
    }
}
