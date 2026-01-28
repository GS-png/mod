using EraWheel.Core;

namespace EraWheel.Civilization
{
    public static class HeroTraitFactory
    {
        private static bool _registered;

        public static void EnsureRegistered()
        {
#if ERAWHEEL_SELFTEST
            if (_registered) return;
            _registered = true;
            return;
#else
            if (_registered) return;

            if (AssetManager.traits == null)
            {
                Log.Warning("[EraWheel] ActorTrait library not ready, skip hero trait registration.");
                return;
            }

            RegisterTrait(HeroConstants.MightTraitId, TraitType.Positive, "special", "multiplier_damage", 0.25f);
            RegisterTrait(HeroConstants.ResilienceTraitId, TraitType.Positive, "special", "multiplier_health", 0.25f);

            _registered = true;
#endif
        }

#if !ERAWHEEL_SELFTEST
        private static void RegisterTrait(string id, TraitType type, string groupId, string statId, float value)
        {
            if (string.IsNullOrEmpty(id)) return;
            if (AssetManager.traits.has(id)) return;

            var trait = new ActorTrait
            {
                id = id,
                group_id = groupId,
                type = type,
                rate_birth = 0,
                rate_inherit = 0,
                rate_acquire_grow_up = 0,
                spawn_random_trait_allowed = false,
                needs_to_be_explored = false,
                has_description_2 = false,
                base_stats = new BaseStats()
            };

            if (!string.IsNullOrEmpty(statId))
            {
                trait.base_stats[statId] = value;
            }

            AssetManager.traits.add(trait);
        }
#endif
    }
}
