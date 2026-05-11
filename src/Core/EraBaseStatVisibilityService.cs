using System;
using System.Collections.Generic;
using System.Linq;
using EraWheel.Core.Constants;

namespace EraWheel.Core;

internal static class EraBaseStatVisibilityService
{
    private static readonly IReadOnlyDictionary<string, string?> VisibilityRules =
        new Dictionary<string, string?>(StringComparer.Ordinal)
        {
            [EraAttributeIds.AreaOfEffect] = null,
            [EraAttributeIds.MultiplierMass] = EraAttributeIds.Mass2,
        };

    internal static IReadOnlyCollection<string> RequiredVisibleStatIds => VisibilityRules.Keys.ToArray();

    internal static bool TryGetExpectedTranslationKey(string statId, out string translationKey)
    {
        translationKey = string.Empty;
        if (!VisibilityRules.TryGetValue(statId, out string? configured) ||
            string.IsNullOrWhiteSpace(configured))
        {
            return false;
        }

        translationKey = configured;
        return true;
    }

    internal static string ApplyOverrides()
    {
        if (AssetManager.base_stats_library == null)
        {
            return "原版 base_stats_library 尚未就绪，当前跳过轮回随机属性可视化修正。";
        }

        List<string> unhidden = new();
        List<string> relabeled = new();
        List<string> missing = new();

        foreach (KeyValuePair<string, string?> rule in VisibilityRules)
        {
            BaseStatAsset? asset = AssetManager.base_stats_library.get(rule.Key);
            if (asset == null)
            {
                missing.Add(rule.Key);
                continue;
            }

            if (asset.hidden)
            {
                asset.hidden = false;
                unhidden.Add(rule.Key);
            }

            if (!string.IsNullOrWhiteSpace(rule.Value) &&
                !string.Equals(asset.translation_key, rule.Value, StringComparison.Ordinal))
            {
                asset.translation_key = rule.Value;
                relabeled.Add($"{rule.Key}->{rule.Value}");
            }
        }

        List<string> parts = new();
        if (unhidden.Count > 0)
        {
            parts.Add($"已解隐藏：{string.Join(", ", unhidden)}");
        }

        if (relabeled.Count > 0)
        {
            parts.Add($"已收口显示名：{string.Join(", ", relabeled)}");
        }

        if (missing.Count > 0)
        {
            parts.Add($"未找到 stat：{string.Join(", ", missing)}");
        }

        return parts.Count > 0
            ? string.Join("；", parts)
            : "目标 stat 已经处于可见状态，本次没有额外变更。";
    }
}
