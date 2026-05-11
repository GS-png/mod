using System;
using System.Collections.Generic;
using System.Linq;
using EraWheel.Core.Constants;
using EraWheel.Core.Logging;
using EraWheel.Reflection;
using NeoModLoader.General;

namespace EraWheel.Combat.Statuses;

public sealed class EraStatusRuntimeService
{
    private const int VisibleStatusFailureThreshold = 2;
    private readonly object _statusesLock = new();
    private readonly Dictionary<long, Dictionary<string, EraActiveStatus>> _statusesByTarget = new();
    private readonly HashSet<string> _invalidVisibleStatusLogged = new(StringComparer.Ordinal);
    private readonly Dictionary<string, int> _visibleStatusFailureCounts = new(StringComparer.Ordinal);
    private readonly HashSet<string> _visibleStatusCircuitsOpen = new(StringComparer.Ordinal);

    public EraActiveStatus Apply(BaseSimObject target, EraStatusApplication application, float currentWorldTime)
    {
        application = NormalizeApplication(application);
        EraStatusDefinition definition = EraCombatStatusCatalog.Get(application.Kind);
        if (target == null)
        {
            return CreateNew(0L, application, definition, currentWorldTime);
        }

        long targetId = target.getID();
        if (!IsValidTargetId(targetId))
        {
            return CreateNew(targetId, application, definition, currentWorldTime);
        }

        string runtimeKey = string.IsNullOrWhiteSpace(application.RuntimeKey)
            ? definition.StatusId
            : application.RuntimeKey;
        EraActiveStatus active;
        lock (_statusesLock)
        {
            Dictionary<string, EraActiveStatus> bucket = GetOrCreateBucketLocked(targetId);
            active = bucket.TryGetValue(runtimeKey, out EraActiveStatus? existing)
                ? UpdateExisting(existing, application, definition, currentWorldTime)
                : CreateNew(targetId, application, definition, currentWorldTime);
            bucket[runtimeKey] = active;
        }

        EnsureVisibleStatus(target, active, application.ColorEffect);
        return active;
    }

    public bool Remove(BaseSimObject target, string runtimeKey)
    {
        if (target == null || string.IsNullOrWhiteSpace(runtimeKey))
        {
            return false;
        }

        long targetId = target.getID();
        if (!IsValidTargetId(targetId))
        {
            return false;
        }

        string? removedStatusId = null;
        lock (_statusesLock)
        {
            if (!_statusesByTarget.TryGetValue(targetId, out Dictionary<string, EraActiveStatus>? bucket) ||
                !bucket.Remove(runtimeKey, out EraActiveStatus? removed))
            {
                return false;
            }

            removedStatusId = removed.StatusId;
            string failureKey = BuildVisibleStatusFailureKey(targetId, runtimeKey, removed.StatusId);
            ClearVisibleStatusFailureLocked(failureKey, preserveCircuit: _visibleStatusCircuitsOpen.Contains(failureKey));
            if (bucket.Count == 0)
            {
                _statusesByTarget.Remove(targetId);
            }
        }

        if (!string.IsNullOrWhiteSpace(removedStatusId))
        {
            FinishVisibleStatusIfUnused(target, targetId, removedStatusId);
        }

        return true;
    }

    public bool HasStatus(BaseSimObject target, EraStatusKind kind)
    {
        if (target == null)
        {
            return false;
        }

        long targetId = target.getID();
        if (!IsValidTargetId(targetId))
        {
            return false;
        }

        lock (_statusesLock)
        {
            return _statusesByTarget.TryGetValue(targetId, out Dictionary<string, EraActiveStatus>? bucket)
                   && bucket.Values.Any(item => item.Kind == kind);
        }
    }

    public bool TryGetStatus(BaseSimObject target, string runtimeKey, out EraActiveStatus? active)
    {
        active = null;
        if (target == null || string.IsNullOrWhiteSpace(runtimeKey))
        {
            return false;
        }

        long targetId = target.getID();
        if (!IsValidTargetId(targetId))
        {
            return false;
        }

        lock (_statusesLock)
        {
            return _statusesByTarget.TryGetValue(targetId, out Dictionary<string, EraActiveStatus>? bucket)
                   && bucket.TryGetValue(runtimeKey, out active);
        }
    }

    public int GetStacks(BaseSimObject target, string runtimeKey)
    {
        if (target == null || string.IsNullOrWhiteSpace(runtimeKey))
        {
            return 0;
        }

        long targetId = target.getID();
        if (!IsValidTargetId(targetId))
        {
            return 0;
        }

        lock (_statusesLock)
        {
            return _statusesByTarget.TryGetValue(targetId, out Dictionary<string, EraActiveStatus>? bucket) &&
                   bucket.TryGetValue(runtimeKey, out EraActiveStatus? active)
                ? active.Stacks
                : 0;
        }
    }

    public int SetStacks(BaseSimObject target, string runtimeKey, int stacks)
    {
        if (target == null || string.IsNullOrWhiteSpace(runtimeKey))
        {
            return 0;
        }

        long targetId = target.getID();
        if (!IsValidTargetId(targetId))
        {
            return 0;
        }

        string? removedStatusId = null;
        int result;
        lock (_statusesLock)
        {
            if (!_statusesByTarget.TryGetValue(targetId, out Dictionary<string, EraActiveStatus>? bucket) ||
                !bucket.TryGetValue(runtimeKey, out EraActiveStatus? active))
            {
                return 0;
            }

            if (stacks <= 0)
            {
                if (bucket.Remove(runtimeKey, out EraActiveStatus? removed))
                {
                    removedStatusId = removed.StatusId;
                    if (bucket.Count == 0)
                    {
                        _statusesByTarget.Remove(targetId);
                    }
                }

                result = 0;
            }
            else
            {
                active.Stacks = stacks;
                result = active.Stacks;
            }
        }

        if (!string.IsNullOrWhiteSpace(removedStatusId))
        {
            FinishVisibleStatusIfUnused(target, targetId, removedStatusId);
        }

        return result;
    }

    public int ChangeStacks(BaseSimObject target, string runtimeKey, int delta)
    {
        int current = GetStacks(target, runtimeKey);
        if (current <= 0)
        {
            return 0;
        }

        return SetStacks(target, runtimeKey, current + delta);
    }

    public IReadOnlyDictionary<string, float> GetAggregatedStatModifiers(BaseSimObject target)
    {
        Dictionary<string, float> aggregated = new Dictionary<string, float>();
        if (target == null)
        {
            return aggregated;
        }

        long targetId = target.getID();
        if (!IsValidTargetId(targetId))
        {
            return aggregated;
        }

        foreach (EraActiveStatus active in GetStatusesSnapshot(targetId))
        {
            if (active.StatModifiers.Count == 0)
            {
                continue;
            }

            int stackMultiplier = Math.Max(1, active.Stacks);
            foreach (KeyValuePair<string, float> modifier in active.StatModifiers)
            {
                aggregated.TryGetValue(modifier.Key, out float current);
                aggregated[modifier.Key] = current + (modifier.Value * stackMultiplier);
            }
        }

        return aggregated;
    }

    public void AppendActorModifiers(Actor actor, IDictionary<string, float> bucket)
    {
        if (actor == null || bucket == null || actor.isRekt())
        {
            return;
        }

        IReadOnlyDictionary<string, float> modifiers = GetAggregatedStatModifiers(actor);
        foreach ((string attributeId, float value) in modifiers)
        {
            if (Math.Abs(value) <= 0.0001f)
            {
                continue;
            }

            bucket.TryGetValue(attributeId, out float current);
            bucket[attributeId] = current + value;
        }
    }

    public EraActiveStatus ApplyNow(BaseSimObject target, EraStatusApplication application)
    {
        return Apply(target, application.Clone(), ReadWorldTime());
    }

    public IReadOnlyList<EraActiveStatus> ApplyToTargets(
        IEnumerable<BaseSimObject> targets,
        EraStatusApplication application,
        float? currentWorldTime = null,
        Func<BaseSimObject, EraStatusApplication, EraStatusApplication>? customize = null
    )
    {
        float worldTime = currentWorldTime ?? ReadWorldTime();
        List<EraActiveStatus> applied = new List<EraActiveStatus>();
        foreach (BaseSimObject? target in targets)
        {
            if (target == null)
            {
                continue;
            }

            EraStatusApplication applicationCopy = application.Clone();
            if (customize != null)
            {
                applicationCopy = customize(target, applicationCopy);
            }

            applied.Add(Apply(target, applicationCopy, worldTime));
        }

        return applied;
    }

    public EraActiveStatus ApplyShield(
        BaseSimObject target,
        float shieldAmount,
        float durationWorldTime,
        string runtimeKey = "",
        bool colorEffect = true
    )
    {
        return ApplySimpleStatus(
            target,
            EraStatusKind.Shield,
            durationWorldTime,
            runtimeKey,
            colorEffect,
            shieldAmount: shieldAmount
        );
    }

    public EraActiveStatus ApplySilence(
        BaseSimObject target,
        float durationWorldTime,
        string runtimeKey = "",
        bool colorEffect = true
    )
    {
        return ApplySimpleStatus(
            target,
            EraStatusKind.Silence,
            durationWorldTime,
            runtimeKey,
            colorEffect
        );
    }

    public EraActiveStatus ApplySlow(
        BaseSimObject target,
        float durationWorldTime,
        float speedModifier = 0f,
        string runtimeKey = "",
        bool colorEffect = true
    )
    {
        Dictionary<string, float> statModifiers = new Dictionary<string, float>();
        if (Math.Abs(speedModifier) > 0.0001f)
        {
            statModifiers[EraAttributeIds.MultiplierSpeed] = speedModifier;
        }

        return ApplySimpleStatus(
            target,
            EraStatusKind.Slow,
            durationWorldTime,
            runtimeKey,
            colorEffect,
            statModifiers: statModifiers
        );
    }

    public EraActiveStatus ApplyStun(
        BaseSimObject target,
        float durationWorldTime,
        string runtimeKey = "",
        bool colorEffect = true
    )
    {
        return ApplySimpleStatus(
            target,
            EraStatusKind.Stun,
            durationWorldTime,
            runtimeKey,
            colorEffect
        );
    }

    public EraActiveStatus ApplyMark(
        BaseSimObject target,
        float durationWorldTime,
        int stackDelta = 1,
        int maxStacks = 3,
        string runtimeKey = "",
        bool colorEffect = true
    )
    {
        return ApplySimpleStatus(
            target,
            EraStatusKind.Mark,
            durationWorldTime,
            runtimeKey,
            colorEffect,
            EraStatusStackMode.AddStacks,
            stackDelta,
            maxStacks
        );
    }

    public EraActiveStatus ApplyStack(
        BaseSimObject target,
        float durationWorldTime,
        int stackDelta = 1,
        int maxStacks = 5,
        string runtimeKey = "",
        bool colorEffect = true
    )
    {
        return ApplySimpleStatus(
            target,
            EraStatusKind.Stack,
            durationWorldTime,
            runtimeKey,
            colorEffect,
            EraStatusStackMode.AddStacks,
            stackDelta,
            maxStacks
        );
    }

    public EraActiveStatus ApplyTimedBuff(
        BaseSimObject target,
        float durationWorldTime,
        IReadOnlyDictionary<string, float>? statModifiers,
        string runtimeKey = "",
        bool colorEffect = true,
        int maxStacks = 1
    )
    {
        return ApplySimpleStatus(
            target,
            EraStatusKind.TimedBuff,
            durationWorldTime,
            runtimeKey,
            colorEffect,
            EraStatusStackMode.RefreshDurationAndStacks,
            stackDelta: 1,
            maxStacks: maxStacks,
            statModifiers: statModifiers
        );
    }

    public EraActiveStatus ApplyTimedDebuff(
        BaseSimObject target,
        float durationWorldTime,
        IReadOnlyDictionary<string, float>? statModifiers,
        string runtimeKey = "",
        bool colorEffect = true,
        int maxStacks = 1
    )
    {
        return ApplySimpleStatus(
            target,
            EraStatusKind.TimedDebuff,
            durationWorldTime,
            runtimeKey,
            colorEffect,
            EraStatusStackMode.RefreshDurationAndStacks,
            stackDelta: 1,
            maxStacks: maxStacks,
            statModifiers: statModifiers
        );
    }

    public bool TryConsumeShield(BaseSimObject target, ref float damage)
    {
        if (target == null)
        {
            return false;
        }

        if (damage <= 0f)
        {
            return true;
        }

        long targetId = target.getID();
        if (!IsValidTargetId(targetId))
        {
            return false;
        }

        List<string> depletedRuntimeKeys = new List<string>();
        float remainingDamage;
        lock (_statusesLock)
        {
            if (!_statusesByTarget.TryGetValue(targetId, out Dictionary<string, EraActiveStatus>? bucket))
            {
                return false;
            }

            List<EraActiveStatus> shields = bucket.Values
                .Where(item => item.Kind == EraStatusKind.Shield && item.ShieldAmount > 0f)
                .OrderBy(item => item.ExpiresAtWorldTime)
                .ToList();
            if (shields.Count == 0)
            {
                return false;
            }

            remainingDamage = damage;
            foreach (EraActiveStatus shield in shields)
            {
                if (remainingDamage <= 0f)
                {
                    break;
                }

                float absorbed = Math.Min(shield.ShieldAmount, remainingDamage);
                shield.ShieldAmount -= absorbed;
                remainingDamage -= absorbed;
                if (shield.ShieldAmount <= 0.01f)
                {
                    depletedRuntimeKeys.Add(shield.RuntimeKey);
                }
            }
        }

        damage = remainingDamage;
        foreach (string runtimeKey in depletedRuntimeKeys)
        {
            Remove(target, runtimeKey);
        }

        return remainingDamage <= 0f;
    }

    public void ApplyActiveModifiers(BaseSimObject target)
    {
        if (target == null || target is Actor)
        {
            return;
        }

        IReadOnlyDictionary<string, float> modifiers = GetAggregatedStatModifiers(target);
        if (modifiers.Count == 0)
        {
            return;
        }

        EraWorldboxStatsAccessor.ApplyAdditiveModifiers(target, modifiers);
    }

    public void Update(float currentWorldTime)
    {
        List<(long TargetId, List<string> ExpiredRuntimeKeys)> expiredByTarget;
        lock (_statusesLock)
        {
            expiredByTarget = _statusesByTarget
                .Select(entry => (
                    TargetId: entry.Key,
                    ExpiredRuntimeKeys: entry.Value
                        .Where(item => item.Value.ExpiresAtWorldTime <= currentWorldTime)
                        .Select(item => item.Key)
                        .ToList()
                ))
                .Where(entry => entry.ExpiredRuntimeKeys.Count > 0)
                .ToList();
        }

        foreach ((long targetId, List<string> expiredRuntimeKeys) in expiredByTarget)
        {
            BaseSimObject? target = FindTarget(targetId);
            foreach (string runtimeKey in expiredRuntimeKeys)
            {
                if (target == null)
                {
                    RemoveByTargetId(targetId, runtimeKey);
                    continue;
                }

                Remove(target, runtimeKey);
            }
        }
    }

    public string CreateStatusReport()
    {
        int targetCount;
        int statusCount;
        int circuitCount;
        lock (_statusesLock)
        {
            targetCount = _statusesByTarget.Count;
            statusCount = _statusesByTarget.Values.Sum(item => item.Count);
            circuitCount = _visibleStatusCircuitsOpen.Count;
        }

        return $"目标={targetCount}；运行时状态={statusCount}；可见状态熔断={circuitCount}";
    }

    private List<EraActiveStatus> GetStatusesSnapshot(long targetId)
    {
        lock (_statusesLock)
        {
            return _statusesByTarget.TryGetValue(targetId, out Dictionary<string, EraActiveStatus>? bucket)
                ? bucket.Values.ToList()
                : new List<EraActiveStatus>();
        }
    }

    private static EraActiveStatus CreateNew(
        long targetId,
        EraStatusApplication application,
        EraStatusDefinition definition,
        float currentWorldTime
    )
    {
        return new EraActiveStatus
        {
            TargetId = targetId,
            Kind = application.Kind,
            RuntimeKey = string.IsNullOrWhiteSpace(application.RuntimeKey) ? definition.StatusId : application.RuntimeKey,
            StatusId = definition.StatusId,
            ExpiresAtWorldTime = currentWorldTime + Math.Max(0f, application.DurationWorldTime),
            Stacks = Math.Clamp(application.StackDelta, 1, Math.Max(1, application.MaxStacks)),
            ShieldAmount = Math.Max(0f, application.ShieldAmount),
            StatModifiers = new Dictionary<string, float>(application.StatModifiers),
        };
    }

    private static EraActiveStatus UpdateExisting(
        EraActiveStatus existing,
        EraStatusApplication application,
        EraStatusDefinition definition,
        float currentWorldTime
    )
    {
        existing.Kind = application.Kind;
        existing.StatusId = definition.StatusId;
        existing.ExpiresAtWorldTime = application.StackMode is EraStatusStackMode.RefreshDuration or EraStatusStackMode.RefreshDurationAndStacks
            ? currentWorldTime + Math.Max(0f, application.DurationWorldTime)
            : Math.Max(existing.ExpiresAtWorldTime, currentWorldTime + Math.Max(0f, application.DurationWorldTime));

        if (application.StackMode is EraStatusStackMode.Replace)
        {
            existing.Stacks = Math.Clamp(application.StackDelta, 1, Math.Max(1, application.MaxStacks));
            existing.ShieldAmount = Math.Max(0f, application.ShieldAmount);
            existing.StatModifiers = new Dictionary<string, float>(application.StatModifiers);
            return existing;
        }

        if (application.StackMode is EraStatusStackMode.AddStacks or EraStatusStackMode.RefreshDurationAndStacks)
        {
            existing.Stacks = Math.Clamp(existing.Stacks + application.StackDelta, 1, Math.Max(1, application.MaxStacks));
            existing.ShieldAmount += Math.Max(0f, application.ShieldAmount);
            if (application.StatModifiers.Count > 0)
            {
                existing.StatModifiers = new Dictionary<string, float>(application.StatModifiers);
            }

            return existing;
        }

        existing.ShieldAmount = Math.Max(existing.ShieldAmount, application.ShieldAmount);
        if (application.StatModifiers.Count > 0)
        {
            existing.StatModifiers = new Dictionary<string, float>(application.StatModifiers);
        }

        return existing;
    }

    private void EnsureVisibleStatus(BaseSimObject target, EraActiveStatus active, bool colorEffect)
    {
        string failureKey = BuildVisibleStatusFailureKey(active.TargetId, active.RuntimeKey, active.StatusId);
        if (!CanUseVisibleStatus(active.StatusId))
        {
            ClearVisibleStatusFailure(failureKey);
            LogInvalidVisibleStatusOnce(
                active.StatusId,
                active.RuntimeKey,
                active.TargetId,
                "附加可见状态"
            );
            return;
        }

        if (IsVisibleStatusCircuitOpen(failureKey))
        {
            return;
        }

        bool applied = WorldboxReflectionAdapter.TryAddStatusEffect(
            target,
            active.StatusId,
            Math.Max(0f, active.ExpiresAtWorldTime - ReadWorldTime()),
            colorEffect
        );
        if (applied)
        {
            ClearVisibleStatusFailure(failureKey);
            return;
        }

        int failureCount = RecordVisibleStatusFailure(failureKey);
        EraLog.Warning(
            EraLogCategory.Combat,
            $"可见状态附加失败，已启动保护计数：statusId={active.StatusId}；runtimeKey={active.RuntimeKey}；targetId={active.TargetId}；连续失败={failureCount}/{VisibleStatusFailureThreshold}"
        );
        TryFinishVisibleStatusSafely(target, active.StatusId, active.TargetId, active.RuntimeKey, "附加失败后清理");

        if (failureCount < VisibleStatusFailureThreshold)
        {
            return;
        }

        EraLog.Warning(
            EraLogCategory.Combat,
            $"可见状态已触发机械熔断，后续将停止注入并移除运行时条目：statusId={active.StatusId}；runtimeKey={active.RuntimeKey}；targetId={active.TargetId}"
        );
        Remove(target, active.RuntimeKey);
    }

    private void FinishVisibleStatusIfUnused(BaseSimObject target, long targetId, string statusId)
    {
        bool stillInUse;
        lock (_statusesLock)
        {
            stillInUse = _statusesByTarget.TryGetValue(targetId, out Dictionary<string, EraActiveStatus>? bucket) &&
                         bucket.Values.Any(item => item.StatusId == statusId);
        }

        if (stillInUse)
        {
            return;
        }

        if (!CanUseVisibleStatus(statusId))
        {
            LogInvalidVisibleStatusOnce(statusId, string.Empty, targetId, "结束可见状态");
            return;
        }

        TryFinishVisibleStatusSafely(target, statusId, targetId, string.Empty, "结束可见状态");
    }

    private void RemoveByTargetId(long targetId, string runtimeKey)
    {
        lock (_statusesLock)
        {
            if (!_statusesByTarget.TryGetValue(targetId, out Dictionary<string, EraActiveStatus>? bucket))
            {
                return;
            }

            if (bucket.Remove(runtimeKey, out EraActiveStatus? removed))
            {
                string failureKey = BuildVisibleStatusFailureKey(targetId, runtimeKey, removed.StatusId);
                ClearVisibleStatusFailureLocked(failureKey, preserveCircuit: _visibleStatusCircuitsOpen.Contains(failureKey));
            }

            if (bucket.Count == 0)
            {
                _statusesByTarget.Remove(targetId);
            }
        }
    }

    private Dictionary<string, EraActiveStatus> GetOrCreateBucketLocked(long targetId)
    {
        if (_statusesByTarget.TryGetValue(targetId, out Dictionary<string, EraActiveStatus>? bucket))
        {
            return bucket;
        }

        bucket = new Dictionary<string, EraActiveStatus>();
        _statusesByTarget[targetId] = bucket;
        return bucket;
    }

    private static bool IsValidTargetId(long targetId)
    {
        return targetId > 0L;
    }

    private bool CanUseVisibleStatus(string statusId)
    {
        return !string.IsNullOrWhiteSpace(statusId) && AssetManager.status.has(statusId);
    }

    private static string BuildVisibleStatusFailureKey(long _, string runtimeKey, string statusId)
    {
        string safeRuntimeKey = string.IsNullOrWhiteSpace(runtimeKey) ? "<empty>" : runtimeKey;
        string safeStatusId = string.IsNullOrWhiteSpace(statusId) ? "<empty>" : statusId;
        return $"{safeRuntimeKey}|{safeStatusId}";
    }

    private bool IsVisibleStatusCircuitOpen(string failureKey)
    {
        lock (_statusesLock)
        {
            return _visibleStatusCircuitsOpen.Contains(failureKey);
        }
    }

    private int RecordVisibleStatusFailure(string failureKey)
    {
        lock (_statusesLock)
        {
            _visibleStatusFailureCounts.TryGetValue(failureKey, out int current);
            int next = current + 1;
            _visibleStatusFailureCounts[failureKey] = next;
            if (next >= VisibleStatusFailureThreshold)
            {
                _visibleStatusCircuitsOpen.Add(failureKey);
            }

            return next;
        }
    }

    private void ClearVisibleStatusFailure(string failureKey)
    {
        lock (_statusesLock)
        {
            ClearVisibleStatusFailureLocked(failureKey, preserveCircuit: false);
        }
    }

    private void ClearVisibleStatusFailureLocked(string failureKey, bool preserveCircuit)
    {
        _visibleStatusFailureCounts.Remove(failureKey);
        if (!preserveCircuit)
        {
            _visibleStatusCircuitsOpen.Remove(failureKey);
        }
    }

    private void LogInvalidVisibleStatusOnce(string statusId, string runtimeKey, long targetId, string action)
    {
        string safeStatusId = string.IsNullOrWhiteSpace(statusId) ? "<empty>" : statusId;
        string dedupeKey = $"{action}|{safeStatusId}";
        lock (_statusesLock)
        {
            if (!_invalidVisibleStatusLogged.Add(dedupeKey))
            {
                return;
            }
        }

        string runtimeKeyPart = string.IsNullOrWhiteSpace(runtimeKey) ? "<empty>" : runtimeKey;
        EraLog.Warning(
            EraLogCategory.Combat,
            $"检测到无效可见状态，已降级跳过：action={action}；statusId={safeStatusId}；runtimeKey={runtimeKeyPart}；targetId={targetId}"
        );
    }

    private void TryFinishVisibleStatusSafely(
        BaseSimObject target,
        string statusId,
        long targetId,
        string runtimeKey,
        string action
    )
    {
        if (target == null || !CanUseVisibleStatus(statusId))
        {
            return;
        }

        try
        {
            target.finishStatusEffect(statusId);
        }
        catch (Exception exception)
        {
            string runtimeKeyPart = string.IsNullOrWhiteSpace(runtimeKey) ? "<empty>" : runtimeKey;
            EraLog.Exception(
                EraLogCategory.Combat,
                $"清理可见状态失败：action={action}；statusId={statusId}；runtimeKey={runtimeKeyPart}；targetId={targetId}",
                exception
            );
        }
    }

    private static float ReadWorldTime()
    {
        return WorldboxReflectionAdapter.TryReadMapStats(out MapStats? mapStats) && mapStats != null
            ? (float)mapStats.world_time
            : 0f;
    }

    private static EraStatusApplication NormalizeApplication(EraStatusApplication application)
    {
        application.StatModifiers = NormalizeStatModifiers(application.StatModifiers);
        return application;
    }

    private static IReadOnlyDictionary<string, float> NormalizeStatModifiers(IReadOnlyDictionary<string, float> modifiers)
    {
        if (modifiers == null || modifiers.Count == 0)
        {
            return new Dictionary<string, float>();
        }

        Dictionary<string, float> normalized = new Dictionary<string, float>(modifiers.Count, StringComparer.Ordinal);
        foreach ((string attributeId, float value) in modifiers)
        {
            normalized[attributeId] = EraPercentAttributeRules.ToRawEngineValue(attributeId, value);
        }

        return normalized;
    }

    private static BaseSimObject? FindTarget(long targetId)
    {
        if (World.world?.units == null)
        {
            return null;
        }

        foreach (Actor actor in World.world.units)
        {
            if (actor != null && actor.getID() == targetId)
            {
                return actor;
            }
        }

        return null;
    }

    private EraActiveStatus ApplySimpleStatus(
        BaseSimObject target,
        EraStatusKind kind,
        float durationWorldTime,
        string runtimeKey,
        bool colorEffect,
        EraStatusStackMode stackMode = EraStatusStackMode.RefreshDuration,
        int stackDelta = 1,
        int maxStacks = 1,
        float shieldAmount = 0f,
        IReadOnlyDictionary<string, float>? statModifiers = null
    )
    {
        return Apply(
            target,
            new EraStatusApplication(kind, durationWorldTime, stackMode, stackDelta, maxStacks, shieldAmount, colorEffect, runtimeKey, statModifiers ?? new Dictionary<string, float>()),
            ReadWorldTime()
        );
    }
}
