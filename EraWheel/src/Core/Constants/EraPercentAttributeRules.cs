using System;

namespace EraWheel.Core.Constants;

public static class EraPercentAttributeRules
{
    private const float PercentScale = 100f;

    public static bool IsPercentAttribute(string attributeId)
    {
        if (string.IsNullOrWhiteSpace(attributeId))
        {
            return false;
        }

        return attributeId.StartsWith("multiplier_", StringComparison.Ordinal) ||
               string.Equals(attributeId, EraAttributeIds.CriticalChance, StringComparison.Ordinal) ||
               string.Equals(attributeId, EraAttributeIds.CriticalDamageMultiplier, StringComparison.Ordinal) ||
               string.Equals(attributeId, EraAttributeIds.SkillCombat, StringComparison.Ordinal) ||
               string.Equals(attributeId, EraAttributeIds.SkillSpell, StringComparison.Ordinal);
    }

    public static float ToRawEngineValue(string attributeId, float designValue)
    {
        return IsPercentAttribute(attributeId)
            ? designValue / PercentScale
            : designValue;
    }

    public static float ToDisplayPercent(string attributeId, float rawValue)
    {
        return IsPercentAttribute(attributeId)
            ? rawValue * PercentScale
            : rawValue;
    }
}
