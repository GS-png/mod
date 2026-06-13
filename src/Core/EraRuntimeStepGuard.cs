using System;
using System.Collections.Generic;
using EraWheel.Core.Logging;

namespace EraWheel.Core;

internal static class EraRuntimeStepGuard
{
    private const int FailurePauseThreshold = 5;
    private static readonly TimeSpan LogInterval = TimeSpan.FromSeconds(10);
    private static readonly TimeSpan CooldownDuration = TimeSpan.FromSeconds(10);

    private static readonly object StatesLock = new();
    private static readonly Dictionary<string, RuntimeStepState> StatesByKey = new();

    internal static void RunRuntimeStep(
        EraLogCategory category,
        string eventId,
        string stage,
        long cycle,
        float worldTime,
        Action action
    )
    {
        if (action == null)
        {
            throw new ArgumentNullException(nameof(action));
        }

        string key = $"{eventId}:{stage}";
        DateTime now = DateTime.UtcNow;
        bool resumingFromCooldown = false;

        lock (StatesLock)
        {
            RuntimeStepState state = GetOrCreateStateLocked(key);
            if (state.CooldownUntilUtc.HasValue)
            {
                if (state.CooldownUntilUtc.Value > now)
                {
                    LogSkippedIfDueLocked(category, eventId, stage, cycle, worldTime, state, now);
                    return;
                }

                state.CooldownUntilUtc = null;
                resumingFromCooldown = true;
            }
        }

        try
        {
            action();
            RecordSuccess(category, eventId, stage, cycle, worldTime, key, resumingFromCooldown);
        }
        catch (OutOfMemoryException)
        {
            throw;
        }
        catch (Exception exception)
        {
            RecordFailure(category, eventId, stage, cycle, worldTime, key, exception);
        }
    }

    private static void RecordSuccess(
        EraLogCategory category,
        string eventId,
        string stage,
        long cycle,
        float worldTime,
        string key,
        bool resumingFromCooldown
    )
    {
        lock (StatesLock)
        {
            RuntimeStepState state = GetOrCreateStateLocked(key);
            int previousFailures = state.ConsecutiveFailures;
            bool shouldLogRecovery = previousFailures > 0 || resumingFromCooldown;
            state.ConsecutiveFailures = 0;
            state.CooldownUntilUtc = null;
            state.LastCooldownSkipLogUtc = DateTime.MinValue;

            if (!shouldLogRecovery)
            {
                return;
            }

            state.LastLogUtc = DateTime.UtcNow;
            EraLog.Event(
                category,
                eventId,
                stage,
                cycle,
                worldTime,
                "recovered",
                ("previousFailures", previousFailures)
            );
        }
    }

    private static void RecordFailure(
        EraLogCategory category,
        string eventId,
        string stage,
        long cycle,
        float worldTime,
        string key,
        Exception exception
    )
    {
        lock (StatesLock)
        {
            RuntimeStepState state = GetOrCreateStateLocked(key);
            DateTime now = DateTime.UtcNow;
            state.ConsecutiveFailures++;
            bool enteredCooldown = false;
            if (state.ConsecutiveFailures >= FailurePauseThreshold)
            {
                state.CooldownUntilUtc = now + CooldownDuration;
                state.LastCooldownSkipLogUtc = DateTime.MinValue;
                enteredCooldown = true;
            }

            if (!enteredCooldown && now - state.LastLogUtc < LogInterval)
            {
                return;
            }

            state.LastLogUtc = now;
            EraLog.EventWarning(
                category,
                eventId,
                stage,
                cycle,
                worldTime,
                enteredCooldown ? "cooldown" : "failed",
                ("failureCount", state.ConsecutiveFailures),
                ("exceptionType", exception.GetType().Name),
                ("message", exception.Message),
                ("cooldownSeconds", enteredCooldown ? (int)CooldownDuration.TotalSeconds : 0)
            );
        }
    }

    private static void LogSkippedIfDueLocked(
        EraLogCategory category,
        string eventId,
        string stage,
        long cycle,
        float worldTime,
        RuntimeStepState state,
        DateTime now
    )
    {
        if (now - state.LastCooldownSkipLogUtc < LogInterval)
        {
            return;
        }

        state.LastCooldownSkipLogUtc = now;
        int remainingSeconds = state.CooldownUntilUtc.HasValue
            ? Math.Max(0, (int)Math.Ceiling((state.CooldownUntilUtc.Value - now).TotalSeconds))
            : 0;
        EraLog.Event(
            category,
            eventId,
            stage,
            cycle,
            worldTime,
            "skipped_cooldown",
            ("failureCount", state.ConsecutiveFailures),
            ("cooldownRemainingSeconds", remainingSeconds)
        );
    }

    private static RuntimeStepState GetOrCreateStateLocked(string key)
    {
        if (StatesByKey.TryGetValue(key, out RuntimeStepState state))
        {
            return state;
        }

        state = new RuntimeStepState();
        StatesByKey[key] = state;
        return state;
    }

    private sealed class RuntimeStepState
    {
        public int ConsecutiveFailures { get; set; }
        public DateTime LastLogUtc { get; set; } = DateTime.MinValue;
        public DateTime LastCooldownSkipLogUtc { get; set; } = DateTime.MinValue;
        public DateTime? CooldownUntilUtc { get; set; }
    }
}
