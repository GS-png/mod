using System;
#if !ERAWHEEL_SELFTEST
using System.Collections.Generic;
#endif

namespace EraWheel.Core
{
    public static class LegacyTraitFactory
    {
        private static bool _registered;

#if !ERAWHEEL_SELFTEST
        internal struct LegacyTraitSpec
        {
            public string Id;
            public TraitType Type;
            public string GroupId;
            public string StatId;
            public float BaseValue;
        }

        internal static readonly LegacyTraitSpec[] LegacyTraitSpecs =
        {
            new LegacyTraitSpec
            {
                Id = "legacy_warrior",
                Type = TraitType.Positive,
                GroupId = "special",
                StatId = "multiplier_damage",
                BaseValue = 0.10f
            },
            new LegacyTraitSpec
            {
                Id = "legacy_armor",
                Type = TraitType.Positive,
                GroupId = "special",
                StatId = "armor",
                BaseValue = 15f
            },
            new LegacyTraitSpec
            {
                Id = "legacy_harvest",
                Type = TraitType.Positive,
                GroupId = "special",
                StatId = "stewardship",
                BaseValue = 2f
            },
            new LegacyTraitSpec
            {
                Id = "legacy_scholar",
                Type = TraitType.Positive,
                GroupId = "special",
                StatId = "intelligence",
                BaseValue = 2f
            },
            new LegacyTraitSpec
            {
                Id = "legacy_hero",
                Type = TraitType.Positive,
                GroupId = "special",
                StatId = "birth_rate",
                BaseValue = 1f
            },
            new LegacyTraitSpec
            {
                Id = "legacy_curse",
                Type = TraitType.Negative,
                GroupId = "special",
                StatId = "multiplier_health",
                BaseValue = -0.10f
            }
        };

        private static readonly Dictionary<string, LegacyTraitSpec> SpecsById =
            new Dictionary<string, LegacyTraitSpec>(StringComparer.Ordinal);

        static LegacyTraitFactory()
        {
            for (var i = 0; i < LegacyTraitSpecs.Length; i++)
            {
                var spec = LegacyTraitSpecs[i];
                if (!string.IsNullOrEmpty(spec.Id))
                {
                    SpecsById[spec.Id] = spec;
                }
            }
        }

        internal static bool TryGetSpec(string id, out LegacyTraitSpec spec)
        {
            return SpecsById.TryGetValue(id, out spec);
        }
#endif

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
                Log.Warning("[EraWheel] ActorTrait library not ready, skip legacy registration.");
                return;
            }

            for (var i = 0; i < LegacyTraitSpecs.Length; i++)
            {
                RegisterLegacyTrait(LegacyTraitSpecs[i]);
            }

            _registered = true;
#endif
        }

#if !ERAWHEEL_SELFTEST
        private static void RegisterLegacyTrait(LegacyTraitSpec spec)
        {
            if (string.IsNullOrEmpty(spec.Id)) return;
            if (AssetManager.traits.has(spec.Id)) return;

            var trait = new ActorTrait
            {
                id = spec.Id,
                group_id = spec.GroupId,
                type = spec.Type,
                rate_birth = 0,
                rate_inherit = 0,
                rate_acquire_grow_up = 0,
                spawn_random_trait_allowed = false,
                needs_to_be_explored = false,
                has_description_2 = false,
                base_stats = new BaseStats()
            };

            if (!string.IsNullOrEmpty(spec.StatId))
            {
                trait.base_stats[spec.StatId] = spec.BaseValue;
            }

            AssetManager.traits.add(trait);
        }
#endif
    }
}
