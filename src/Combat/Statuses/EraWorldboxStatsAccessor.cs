using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;

namespace EraWheel.Combat.Statuses;

public static class EraWorldboxStatsAccessor
{
    private static readonly FieldInfo? StatsField = AccessTools.Field(typeof(BaseSimObject), "stats");

    public static float GetStat(BaseSimObject target, string statId)
    {
        BaseStats? stats = GetStats(target);
        return stats?.get(statId) ?? 0f;
    }

    public static void ApplyAdditiveModifiers(BaseSimObject target, IReadOnlyDictionary<string, float> modifiers)
    {
        BaseStats? stats = GetStats(target);
        if (stats == null)
        {
            return;
        }

        foreach (KeyValuePair<string, float> modifier in modifiers)
        {
            stats[modifier.Key] = stats.get(modifier.Key) + modifier.Value;
        }
    }

    public static void SetStat(BaseSimObject target, string statId, float value)
    {
        BaseStats? stats = GetStats(target);
        if (stats == null)
        {
            return;
        }

        stats[statId] = value;
    }

    private static BaseStats? GetStats(BaseSimObject target)
    {
        return StatsField?.GetValue(target) as BaseStats;
    }
}
