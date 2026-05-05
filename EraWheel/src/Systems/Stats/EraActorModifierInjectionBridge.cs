using System;
using System.Collections.Generic;
using System.Linq;
using EraWheel.Combat;
using EraWheel.Combat.Statuses;
using EraWheel.Config;
using EraWheel.Core.Logging;
using EraWheel.Systems.Kingdoms;
using EraWheel.Systems.Levels;
using EraWheel.Systems.Progression;

namespace EraWheel.Systems.Stats;

public static class EraActorModifierInjectionBridge
{
    private static readonly Dictionary<long, string> LastLoggedModifiersByActorId = new();

    public static void InjectPersistentModifiers(Actor actor)
    {
        if (actor == null || actor.isRekt())
        {
            return;
        }

        Dictionary<string, float> modifiers = new Dictionary<string, float>(StringComparer.Ordinal);
        EraLevelRuntimeBridge.Current?.AppendPersistentModifiers(actor, modifiers);
        EraKingdomRuntimeBridge.Current?.AppendPersistentModifiers(actor, modifiers);
        EraProgressionRuntimeBridge.Current?.AppendPersistentModifiers(actor, modifiers);
        EraCombatRuntimeBridge.Current?.Statuses.AppendActorModifiers(actor, modifiers);

        if (modifiers.Count == 0)
        {
            if (EraConfig.DevelopmentMode)
            {
                LastLoggedModifiersByActorId.Remove(actor.getID());
            }

            return;
        }

        EraWorldboxStatsAccessor.ApplyAdditiveModifiers(actor, modifiers);
        LogInjectedModifiers(actor, modifiers);
    }

    private static void LogInjectedModifiers(Actor actor, IReadOnlyDictionary<string, float> modifiers)
    {
        if (!EraConfig.DevelopmentMode)
        {
            return;
        }

        string summary = string.Join(
            ", ",
            modifiers
                .OrderBy(entry => entry.Key, StringComparer.Ordinal)
                .Select(entry => $"{entry.Key}={entry.Value:0.###}")
        );

        long actorId = actor.getID();
        if (LastLoggedModifiersByActorId.TryGetValue(actorId, out string existingSummary) &&
            string.Equals(existingSummary, summary, StringComparison.Ordinal))
        {
            return;
        }

        LastLoggedModifiersByActorId[actorId] = summary;
        EraLog.Info(
            EraLogCategory.Debug,
            $"EW-DEBUG Actor.updateStats 已注入持久修正：{actor.getName()}#{actorId} => {summary}"
        );
    }
}
