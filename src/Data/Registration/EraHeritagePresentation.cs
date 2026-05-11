using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Globalization;
using EraWheel.Config;
using EraWheel.Config.Schema;
using EraWheel.Core.Constants;
using EraWheel.Data.Definitions;
using EraWheel.Save.Models;

namespace EraWheel.Data.Registration;

public static class EraHeritagePresentation
{
    private static readonly Regex PositiveRangeWithDoublePlusPattern = new(
        @"：\+\d+(?:\.\d+)?%?~\+\d+(?:\.\d+)?%?",
        RegexOptions.Compiled
    );

    private static readonly IReadOnlyDictionary<string, string> AttributeDisplayNames =
        new Dictionary<string, string>(StringComparer.Ordinal)
        {
            [EraAttributeIds.Damage] = "伤害",
            [EraAttributeIds.MultiplierDamage] = "伤害倍率",
            [EraAttributeIds.AttackSpeed] = "攻速",
            [EraAttributeIds.MultiplierAttackSpeed] = "攻速倍率",
            [EraAttributeIds.CriticalChance] = "暴击率",
            [EraAttributeIds.CriticalDamageMultiplier] = "暴击伤害倍率",
            [EraAttributeIds.ThrowingRange] = "投掷",
            [EraAttributeIds.Range] = "射程",
            [EraAttributeIds.AreaOfEffect] = "效果范围",
            [EraAttributeIds.Knockback] = "击退",
            [EraAttributeIds.Health] = "生命值",
            [EraAttributeIds.MultiplierHealth] = "生命倍率",
            [EraAttributeIds.Armor] = "防御",
            [EraAttributeIds.Stamina] = "耐力",
            [EraAttributeIds.MultiplierStamina] = "耐力倍率",
            [EraAttributeIds.Mana] = "法力",
            [EraAttributeIds.MultiplierMana] = "法力倍率",
            [EraAttributeIds.MaxNutrition] = "最大营养",
            [EraAttributeIds.Happiness] = "幸福度",
            [EraAttributeIds.Lifespan] = "寿命",
            [EraAttributeIds.MultiplierLifespan] = "寿命倍率",
            [EraAttributeIds.Speed] = "移速",
            [EraAttributeIds.MultiplierSpeed] = "移速倍率",
            [EraAttributeIds.Mass] = "体重",
            [EraAttributeIds.MultiplierMass] = "体重倍率",
            [EraAttributeIds.SkillCombat] = "战斗技能",
            [EraAttributeIds.SkillSpell] = "施法",
            [EraAttributeIds.Diplomacy] = "外交",
            [EraAttributeIds.MultiplierDiplomacy] = "外交倍率",
            [EraAttributeIds.Warfare] = "指挥",
            [EraAttributeIds.Stewardship] = "组织",
            [EraAttributeIds.Intelligence] = "智力",
        };

    public static string BuildStaticPrimaryText(IEraHeritageDefinition definition)
    {
        if (definition == null)
        {
            return string.Empty;
        }

        List<string> lines = new()
        {
            $"效果：{definition.Summary}",
        };
        if (!string.IsNullOrWhiteSpace(definition.Targeting?.DisplayText))
        {
            lines.Add($"作用对象：{definition.Targeting.DisplayText}");
        }

        return string.Join("\n", lines);
    }

    public static string BuildStaticSecondaryText(IEraHeritageDefinition definition)
    {
        if (definition == null)
        {
            return string.Empty;
        }

        EraRandomAttributeProfile profile = EraConfig.Parameters.Advancement.RandomAttributes;
        int drawCount = ResolveDrawCount(definition, profile);
        List<string> lines = new()
        {
            $"随机规则：从当前候选池随机 {drawCount} 条，单次不重复。",
            "候选属性：",
        };
        lines.AddRange(BuildRandomRangeLines(profile));
        string restrictionText = BuildRestrictionText(definition.Restrictions);
        if (!string.IsNullOrWhiteSpace(restrictionText))
        {
            lines.Add($"限制：{restrictionText}");
        }

        return string.Join("\n", lines);
    }

    public static string BuildActorDetailInstanceSummary(
        IEraHeritageDefinition definition,
        IEnumerable<EraAttributeModifierEntry>? attributes)
    {
        return BuildCurrentInstanceAttributeSummary(attributes);
    }

    public static bool TryBuildInstanceStatsBlock(
        IEnumerable<EraAttributeModifierEntry>? attributes,
        out string statsDescription,
        out string statsValues)
    {
        statsDescription = string.Empty;
        statsValues = string.Empty;
        if (attributes == null)
        {
            return false;
        }

        List<string> descriptionLines = new();
        List<string> valueLines = new();
        foreach (EraAttributeModifierEntry entry in attributes)
        {
            if (entry == null || string.IsNullOrWhiteSpace(entry.AttributeId) || Math.Abs(entry.Value) < 0.0001f)
            {
                continue;
            }

            descriptionLines.Add(GetAttributeLabel(entry.AttributeId));
            valueLines.Add(FormatAttributeValue(entry.AttributeId, entry.Value));
        }

        if (descriptionLines.Count == 0)
        {
            return false;
        }

        statsDescription = string.Join("\n", descriptionLines);
        statsValues = string.Join("\n", valueLines);
        return true;
    }

    public static string BuildCurrentInstanceAttributeSummary(IEnumerable<EraAttributeModifierEntry>? attributes)
    {
        string attributeText = FormatAttributeSummary(attributes);
        return string.IsNullOrWhiteSpace(attributeText) || string.Equals(attributeText, "无", StringComparison.Ordinal)
            ? "当前实例属性加成：无"
            : $"当前实例属性加成：{attributeText}";
    }

    public static bool TryBuildEquipmentInstanceStatsBlock(
        IEnumerable<EraAttributeModifierEntry>? attributes,
        out string statsDescription,
        out string statsValues)
    {
        if (TryBuildInstanceStatsBlock(attributes, out statsDescription, out statsValues))
        {
            return true;
        }

        statsDescription = "当前实例属性加成";
        statsValues = "无";
        return false;
    }

    public static string FormatAttributeSummary(IEnumerable<EraAttributeModifierEntry>? entries)
    {
        if (entries == null)
        {
            return "无";
        }

        List<string> parts = new();
        foreach (EraAttributeModifierEntry entry in entries)
        {
            if (entry == null || string.IsNullOrWhiteSpace(entry.AttributeId) || Math.Abs(entry.Value) < 0.0001f)
            {
                continue;
            }

            parts.Add($"{GetAttributeLabel(entry.AttributeId)} {FormatAttributeValue(entry.AttributeId, entry.Value)}");
        }

        return parts.Count == 0 ? "无" : string.Join("，", parts);
    }

    public static bool IsPlayerFacingTextClean(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return false;
        }

        string[] forbidden =
        {
            "实现指引",
            "授予配置",
            "解锁阶位",
            "轮回阶位",
            "核心参数",
            "基础模板",
            "运行时图标",
            "内部ID",
            "ID：",
        };

        return forbidden.All(item => !text.Contains(item, StringComparison.Ordinal));
    }

    public static bool HasExpandedRandomRangeText(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return false;
        }

        EraRandomAttributeProfile profile = EraConfig.Parameters.Advancement.RandomAttributes;
        if (!text.Contains("随机规则：", StringComparison.Ordinal) ||
            !text.Contains("候选属性：", StringComparison.Ordinal))
        {
            return false;
        }

        return BuildRandomRangeLines(profile).Any(line => text.Contains(line, StringComparison.Ordinal));
    }

    public static bool UsesPreferredRandomRangeText(string text)
    {
        if (!HasExpandedRandomRangeText(text))
        {
            return false;
        }

        string[] lines = text.Split('\n');
        if (lines.Any(line => line.StartsWith("- ", StringComparison.Ordinal)))
        {
            return false;
        }

        return !PositiveRangeWithDoublePlusPattern.IsMatch(text);
    }

    private static string BuildRestrictionText(IEnumerable<EraHeritageRestriction>? restrictions)
    {
        if (restrictions == null)
        {
            return string.Empty;
        }

        return string.Join("；", restrictions.Select(item => item.Description).Where(item => !string.IsNullOrWhiteSpace(item)));
    }

    private static IEnumerable<string> BuildRandomRangeLines(EraRandomAttributeProfile profile)
    {
        if (profile?.CandidateAttributeIds == null || profile.AttributeRanges == null)
        {
            yield break;
        }

        foreach (string attributeId in profile.CandidateAttributeIds.Distinct(StringComparer.Ordinal))
        {
            string label = GetAttributeLabel(attributeId);
            if (!profile.AttributeRanges.TryGetValue(attributeId, out EraFloatRange? range) || range == null)
            {
                yield return $"{label}：未配置区间";
                continue;
            }

            yield return $"{label}：{FormatRangeValue(attributeId, range.Min, range.Max)}";
        }
    }

    private static int ResolveDrawCount(IEraHeritageDefinition definition, EraRandomAttributeProfile profile)
    {
        if (definition is EraHeritageEquipmentManifest)
        {
            return Math.Max(0, profile?.EquipmentAttributesPerItem ?? 0);
        }

        if (definition is EraHeritageTraitManifest)
        {
            return Math.Max(0, profile?.TraitAttributesPerItem ?? 0);
        }

        return Math.Max(0, definition?.RandomAttributes?.DrawCount ?? 0);
    }

    private static string GetAttributeLabel(string attributeId)
    {
        return AttributeDisplayNames.TryGetValue(attributeId, out string? label) ? label : attributeId;
    }

    private static string FormatAttributeValue(string attributeId, float value)
    {
        float displayValue = EraPercentAttributeRules.ToDisplayPercent(attributeId, value);
        return EraPercentAttributeRules.IsPercentAttribute(attributeId)
            ? $"{displayValue:+0.##;-0.##;0}%"
            : $"{displayValue:+0.##;-0.##;0}";
    }

    private static string FormatRangeValue(string attributeId, float minValue, float maxValue)
    {
        bool showMinPositiveSign = minValue > 0f;
        bool showMaxPositiveSign = maxValue > 0f && minValue <= 0f;
        string minText = FormatConfiguredRangeNumber(attributeId, minValue, showMinPositiveSign);
        string maxText = FormatConfiguredRangeNumber(attributeId, maxValue, showMaxPositiveSign);
        return Math.Abs(maxValue - minValue) <= 0.0001f ? minText : $"{minText}~{maxText}";
    }

    private static string FormatConfiguredRangeNumber(string attributeId, float value, bool showPositiveSign)
    {
        string format = showPositiveSign ? "+0.##;-0.##;0" : "0.##;-0.##;0";
        return EraPercentAttributeRules.IsPercentAttribute(attributeId)
            ? $"{value.ToString(format, CultureInfo.InvariantCulture)}%"
            : value.ToString(format, CultureInfo.InvariantCulture);
    }
}
