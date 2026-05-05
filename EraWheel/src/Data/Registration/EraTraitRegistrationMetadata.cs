using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using EraWheel.Core.Constants;
using EraWheel.Data.Definitions;

namespace EraWheel.Data.Registration;

public sealed class EraTraitGrantConfig
{
    public static EraTraitGrantConfig Empty { get; } = new EraTraitGrantConfig(0, 0, 0, false, false, false, string.Empty);

    public int BirthWeight { get; }
    public int InheritWeight { get; }
    public int GrowthWeight { get; }
    public bool AllowsMutationBox { get; }
    public bool AllowsManualGrant { get; }
    public bool AllowsTraining { get; }
    public string RawText { get; }

    public EraTraitGrantConfig(
        int birthWeight,
        int inheritWeight,
        int growthWeight,
        bool allowsMutationBox,
        bool allowsManualGrant,
        bool allowsTraining,
        string rawText
    )
    {
        BirthWeight = birthWeight;
        InheritWeight = inheritWeight;
        GrowthWeight = growthWeight;
        AllowsMutationBox = allowsMutationBox;
        AllowsManualGrant = allowsManualGrant;
        AllowsTraining = allowsTraining;
        RawText = rawText;
    }
}

public static class EraTraitRegistrationMetadata
{
    private static readonly HashSet<string> PublicTraitEpicIds = new HashSet<string>(StringComparer.Ordinal)
    {
        "trait_common_golden_touch",
        "trait_common_lightning_body",
        "trait_common_soul_reaper",
        "trait_common_martyr",
        "trait_common_leadership",
        "trait_common_unbroken_will",
        "trait_common_cute",
        "trait_common_lucky",
        "trait_common_lightning_blessing",
        "trait_common_master",
    };

    private static readonly HashSet<string> PublicTraitLegendaryIds = new HashSet<string>(StringComparer.Ordinal)
    {
        "trait_common_revival",
        "trait_common_flight",
        "trait_common_shared_fate",
        "trait_common_bloodline",
    };

    private static readonly HashSet<string> HeritageTraitRareIds = new HashSet<string>(StringComparer.Ordinal)
    {
        "trait_herit_t1_frost_impact",
        "trait_herit_t1_sacred_heal",
        "trait_herit_t1_wind_blade",
        "trait_herit_t2_sword_array",
        "trait_herit_t2_rock_armor",
        "trait_herit_t3_sky_thunder",
    };

    private static readonly HashSet<string> HeritageTraitLegendaryIds = new HashSet<string>(StringComparer.Ordinal)
    {
        "trait_herit_t4_twin_gate",
        "trait_herit_t7_phoenix_strike",
        "trait_herit_t8_gravity_well",
        "trait_herit_t8_absolute_zero",
        "trait_herit_t9_holy_judgement",
        "trait_herit_t9_eye_of_storm",
        "trait_herit_t9_frostfire_nova",
        "trait_herit_t10_meteor_barrage",
        "trait_herit_t10_void_tide",
        "trait_herit_t10_doom_prism",
    };

    private static readonly IReadOnlyDictionary<string, IReadOnlyDictionary<string, float>> PublicTraitBaseStats =
        new ReadOnlyDictionary<string, IReadOnlyDictionary<string, float>>(
            new Dictionary<string, IReadOnlyDictionary<string, float>>(StringComparer.Ordinal)
            {
                ["trait_common_lifesteal"] = CreateStatMap(("damage", 200f), ("health", 50000f)),
                ["trait_common_onhit_exp_10"] = CreateStatMap(("health", 70000f), ("attack_speed", 3f), ("mana", 300f), ("damage", 100f)),
                ["trait_common_fireborn"] = CreateStatMap(("armor", 8f), ("health", 65000f), ("mana", 500f), ("damage", 200f), ("lifespan", 500f)),
                ["trait_common_revival"] = CreateStatMap(("health", 100000f), ("lifespan", 500f), ("speed", 30f)),
                ["trait_common_golden_touch"] = CreateStatMap(("health", 75000f), ("armor", 5f), ("stamina", 500f), ("mass", 2f)),
                ["trait_common_waterborn"] = CreateStatMap(("armor", 8f), ("health", 65000f), ("speed", 50f), ("mana", 500f), ("damage", 150f), ("lifespan", 800f)),
                ["trait_common_lightning_body"] = CreateStatMap(("health", 80000f), ("attack_speed", 2f), ("speed", 70f), ("mana", 500f), ("damage", 180f), ("lifespan", 800f)),
                ["trait_common_forestborn"] = CreateStatMap(("lifespan", 600f), ("health", 80000f), ("stamina", 300f), ("mana", 500f), ("damage", 150f)),
                ["trait_common_berserker"] = CreateStatMap(("damage", 500f), ("health", 50000f), ("skill_combat", 10f)),
                ["trait_common_death_curse"] = CreateStatMap(("lifespan", 500f), ("armor", 8f), ("intelligence", 5f)),
                ["trait_common_soul_reaper"] = CreateStatMap(("health", 100000f), ("stamina", 100f), ("attack_speed", 3f), ("damage", 130f), ("lifespan", 800f)),
                ["trait_common_fast_leveling"] = CreateStatMap(("lifespan", 500f), ("speed", 50f), ("health", 100000f)),
                ["trait_common_flight"] = CreateStatMap(("speed", 100f), ("stamina", 500f), ("mana", 500f), ("attack_speed", 3f), ("lifespan", 500f)),
                ["trait_common_martyr"] = CreateStatMap(("health", 70000f), ("armor", 10f)),
                ["trait_common_leadership"] = CreateStatMap(("health", 75000f), ("armor", 10f), ("damage", 100f), ("warfare", 5f), ("stewardship", 5f)),
                ["trait_common_unbroken_will"] = CreateStatMap(("health", 85000f), ("stamina", 500f), ("intelligence", 5f), ("diplomacy", 5f)),
                ["trait_common_cute"] = CreateStatMap(),
                ["trait_common_giant_slayer"] = CreateStatMap(("damage", 400f), ("attack_speed", 3f), ("speed", 100f)),
                ["trait_common_lucky"] = CreateStatMap(("health", 90000f), ("armor", 8f), ("stamina", 500f), ("intelligence", 5f), ("diplomacy", 5f)),
                ["trait_common_coward"] = CreateStatMap(("health", 700000f), ("speed", 60f), ("stamina", 500f), ("damage", 300f)),
                ["trait_common_gambler"] = CreateStatMap(("health", 70000f), ("damage", 200f), ("attack_speed", 3f), ("speed", 100f)),
                ["trait_common_shared_fate"] = CreateStatMap(("health", 95000f), ("damage", 250f), ("lifespan", 500f), ("intelligence", 5f)),
                ["trait_common_bloodline"] = CreateStatMap(("health", 150000f), ("damage", 300f), ("lifespan", 100f)),
                ["trait_common_lightning_blessing"] = CreateStatMap(("health", 80000f), ("speed", 100f), ("attack_speed", 5f), ("damage", 200f), ("lifespan", 500f), ("mana", 500f)),
                ["trait_common_master"] = CreateStatMap(("health", 100000f), ("speed", 80f), ("attack_speed", 2f), ("damage", 350f), ("lifespan", 500f), ("mana", 500f), ("stamina", 500f), ("skill_combat", 15f), ("skill_spell", 15f), ("intelligence", 5f), ("warfare", 5f), ("stewardship", 5f)),
            }
        );

    public static EraTraitGrantConfig ParseGrantConfig(string? rawText)
    {
        if (string.IsNullOrWhiteSpace(rawText))
        {
            return EraTraitGrantConfig.Empty;
        }

        int birthWeight = 0;
        int inheritWeight = 0;
        int growthWeight = 0;
        bool allowsMutationBox = false;
        bool allowsManualGrant = false;
        bool allowsTraining = false;

        foreach (string rawToken in rawText.Split(new[] { ';', '；' }, StringSplitOptions.RemoveEmptyEntries))
        {
            string token = rawToken.Trim();
            if (token.StartsWith("出生=", StringComparison.Ordinal))
            {
                birthWeight = ParseIntSuffix(token, "出生=");
                continue;
            }

            if (token.StartsWith("遗传=", StringComparison.Ordinal))
            {
                inheritWeight = ParseIntSuffix(token, "遗传=");
                continue;
            }

            if (token.StartsWith("成长=", StringComparison.Ordinal))
            {
                growthWeight = ParseIntSuffix(token, "成长=");
                continue;
            }

            if (string.Equals(token, "突变箱", StringComparison.Ordinal))
            {
                allowsMutationBox = true;
                continue;
            }

            if (string.Equals(token, "手动", StringComparison.Ordinal))
            {
                allowsManualGrant = true;
                continue;
            }

            if (string.Equals(token, "训练", StringComparison.Ordinal))
            {
                allowsTraining = true;
            }
        }

        return new EraTraitGrantConfig(
            birthWeight,
            inheritWeight,
            growthWeight,
            allowsMutationBox,
            allowsManualGrant,
            allowsTraining,
            rawText
        );
    }

    public static Rarity GetPublicTraitRarity(string traitId)
    {
        if (PublicTraitLegendaryIds.Contains(traitId))
        {
            return Rarity.R3_Legendary;
        }

        if (PublicTraitEpicIds.Contains(traitId))
        {
            return Rarity.R2_Epic;
        }

        return Rarity.R1_Rare;
    }

    public static Rarity GetHeritageTraitRarity(string traitId)
    {
        if (HeritageTraitLegendaryIds.Contains(traitId))
        {
            return Rarity.R3_Legendary;
        }

        if (HeritageTraitRareIds.Contains(traitId))
        {
            return Rarity.R1_Rare;
        }

        return Rarity.R2_Epic;
    }

    public static IReadOnlyDictionary<string, float> GetPublicTraitBaseStats(string traitId)
    {
        if (PublicTraitBaseStats.TryGetValue(traitId, out IReadOnlyDictionary<string, float>? stats))
        {
            return stats;
        }

        return CreateStatMap();
    }

    public static string BuildPublicTraitDescriptionText(EraPublicTraitManifest trait)
    {
        return trait.Summary;
    }

    public static string BuildHeritageTraitDescriptionText(EraHeritageTraitManifest trait)
    {
        return EraHeritagePresentation.BuildStaticPrimaryText(trait);
    }

    public static string BuildHeritageTraitDetailText(EraHeritageTraitManifest trait)
    {
        return EraHeritagePresentation.BuildStaticSecondaryText(trait);
    }

    private static string FormatImplementationKind(EraHeritageImplementationKind kind)
    {
        return kind switch
        {
            EraHeritageImplementationKind.ReuseAndAdjust => "复用+微调",
            EraHeritageImplementationKind.Composite => "组合实现",
            EraHeritageImplementationKind.Custom => "完全自定义",
            _ => kind.ToString(),
        };
    }

    private static string FormatEffectParameters(IEnumerable<EraHeritageEffectParameter> parameters)
    {
        return string.Join("、", parameters.Select(FormatEffectParameter).Where(item => !string.IsNullOrWhiteSpace(item)));
    }

    private static string FormatEffectParameter(EraHeritageEffectParameter parameter)
    {
        string suffix = parameter.Unit switch
        {
            EraHeritageParameterUnit.Percent => "%",
            EraHeritageParameterUnit.Multiplier => "x",
            EraHeritageParameterUnit.Seconds => "秒",
            EraHeritageParameterUnit.Years => "年",
            EraHeritageParameterUnit.Tiles => "格",
            EraHeritageParameterUnit.Count => "个",
            EraHeritageParameterUnit.HitPoints => "HP",
            _ => string.Empty,
        };

        string valueText = parameter.IsRange
            ? $"{FormatNumber(parameter.MinValue)}~{FormatNumber(parameter.MaxValue)}"
            : FormatNumber(parameter.MinValue);

        if (parameter.Unit == EraHeritageParameterUnit.Multiplier)
        {
            valueText = $"{valueText}{suffix}";
        }
        else
        {
            valueText = $"{valueText}{suffix}";
        }

        return $"{parameter.DisplayName}={valueText}";
    }

    private static string FormatRestrictions(IEnumerable<EraHeritageRestriction> restrictions)
    {
        return string.Join("；", restrictions.Select(item => item.Description).Where(item => !string.IsNullOrWhiteSpace(item)));
    }

    private static string FormatNumber(float value)
    {
        return Math.Abs(value - MathF.Round(value)) < 0.001f
            ? MathF.Round(value).ToString(CultureInfo.InvariantCulture)
            : value.ToString("0.##", CultureInfo.InvariantCulture);
    }

    private static IReadOnlyDictionary<string, float> CreateStatMap(params (string StatId, float Value)[] values)
    {
        Dictionary<string, float> result = new Dictionary<string, float>(StringComparer.Ordinal);
        foreach ((string statId, float value) in values)
        {
            result[statId] = EraPercentAttributeRules.ToRawEngineValue(statId, value);
        }

        return new ReadOnlyDictionary<string, float>(result);
    }

    private static int ParseIntSuffix(string token, string prefix)
    {
        string rawNumber = token[prefix.Length..].Trim();
        return int.TryParse(rawNumber, NumberStyles.Integer, CultureInfo.InvariantCulture, out int value)
            ? value
            : 0;
    }
}
