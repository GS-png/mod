using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EraWheel.Core.Constants;
using EraWheel.Save.Models;

namespace EraWheel.UI;

internal static class EraDetailUiFormatter
{
    private static readonly IReadOnlyDictionary<string, string> AttributeDisplayNames = new Dictionary<string, string>(StringComparer.Ordinal)
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

    public static string FormatAttributeSummary(
        IEnumerable<EraAttributeModifierEntry>? entries,
        IEnumerable<string>? includeAttributeIds = null)
    {
        List<string> parts = new();
        foreach (KeyValuePair<string, float> pair in CollectOrderedAttributeValues(entries, includeAttributeIds))
        {
            parts.Add($"{GetAttributeLabel(pair.Key)} {FormatAttributeValue(pair.Key, pair.Value)}");
        }

        return parts.Count == 0 ? "无" : string.Join("，", parts);
    }

    public static IReadOnlyList<string> BuildAttributeDetailLines(
        IEnumerable<EraAttributeModifierEntry>? entries,
        IEnumerable<string>? includeAttributeIds = null)
    {
        List<string> lines = new();
        foreach (KeyValuePair<string, float> pair in CollectOrderedAttributeValues(entries, includeAttributeIds))
        {
            lines.Add($"{GetAttributeLabel(pair.Key)}：{FormatAttributeValue(pair.Key, pair.Value)}");
        }

        if (lines.Count == 0)
        {
            lines.Add("无");
        }

        return lines;
    }

    public static string GetAttributeLabel(string attributeId)
    {
        return AttributeDisplayNames.TryGetValue(attributeId, out string? label) ? label : attributeId;
    }

    public static string FormatAttributeValue(string attributeId, float value)
    {
        float displayValue = EraPercentAttributeRules.ToDisplayPercent(attributeId, value);
        return EraPercentAttributeRules.IsPercentAttribute(attributeId)
            ? $"{displayValue:+0.##;-0.##;0}%"
            : $"{displayValue:+0.##;-0.##;0}";
    }

    public static string FormatActorReference(long actorId)
    {
        if (actorId <= 0)
        {
            return "未知";
        }

        Actor? match = World.world?.units?.FirstOrDefault(unit => unit.getID() == actorId);
        if (match == null)
        {
            return $"#{actorId}";
        }

        string name = match.getName();
        return string.IsNullOrWhiteSpace(name) ? $"#{actorId}" : $"{name}(#{actorId})";
    }

    private static List<KeyValuePair<string, float>> CollectOrderedAttributeValues(
        IEnumerable<EraAttributeModifierEntry>? entries,
        IEnumerable<string>? includeAttributeIds)
    {
        Dictionary<string, float> values = new(StringComparer.Ordinal);
        if (entries != null)
        {
            foreach (EraAttributeModifierEntry entry in entries)
            {
                if (entry == null || string.IsNullOrWhiteSpace(entry.AttributeId))
                {
                    continue;
                }

                values[entry.AttributeId] = entry.Value;
            }
        }

        IEnumerable<string> orderedIds = includeAttributeIds?.Distinct(StringComparer.Ordinal)
            ?? values.Keys.OrderBy(item => item, StringComparer.Ordinal);
        List<KeyValuePair<string, float>> result = new();
        foreach (string attributeId in orderedIds)
        {
            if (string.IsNullOrWhiteSpace(attributeId))
            {
                continue;
            }

            float value = values.TryGetValue(attributeId, out float currentValue) ? currentValue : 0f;
            if (includeAttributeIds == null && Math.Abs(value) < 0.0001f)
            {
                continue;
            }

            result.Add(new KeyValuePair<string, float>(attributeId, value));
        }

        return result;
    }
}
