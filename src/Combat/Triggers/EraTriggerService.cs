using System;
using System.Collections.Generic;
using System.Linq;
using EraWheel.Combat.Effects;
using EraWheel.Combat.Statuses;
using EraWheel.Core;
using EraWheel.Core.Logging;
using EraWheel.Core.Random;

namespace EraWheel.Combat.Triggers;

public sealed class EraTriggerService
{
    private const int TriggerFailureFuseThreshold = 5;
    private const int MaxQueuedTickContexts = 4096;
    private const int MaxTickContextsPerDrain = 512;
    private static readonly TimeSpan QueueGovernanceLogInterval = TimeSpan.FromSeconds(10);

    private readonly object _definitionsLock = new();
    private readonly object _queuedContextsLock = new();
    private readonly EraStableRandomService _stableRandom;
    private readonly Dictionary<EraTriggerType, List<EraTriggerDefinition>> _definitions = new();
    private readonly Dictionary<string, int> _consecutiveFailuresByDefinitionId = new();
    private readonly Dictionary<string, string> _lastFailureSummaryByDefinitionId = new();
    private readonly HashSet<string> _fusedDefinitionIds = new();
    private readonly Queue<string> _queuedTickKeys = new();
    private readonly Dictionary<string, EraTriggerContext> _queuedTickContextsByKey = new();
    private long _queuedTickDropped;
    private long _queuedTickMerged;
    private long _queuedTickSkippedDead;
    private DateTime _lastQueueGovernanceLogUtc = DateTime.MinValue;

    public EraEffectService Effects { get; }
    public EraStatusRuntimeService Statuses { get; }

    public EraTriggerService(
        EraStableRandomService stableRandom,
        EraEffectService effects,
        EraStatusRuntimeService statuses
    )
    {
        _stableRandom = stableRandom;
        Effects = effects;
        Statuses = statuses;
    }

    public bool Register(EraTriggerDefinition definition)
    {
        lock (_definitionsLock)
        {
            List<EraTriggerDefinition> bucket = GetOrCreateBucketLocked(definition.TriggerType);
            if (bucket.Any(item => item.Id == definition.Id))
            {
                return false;
            }

            bucket.Add(definition);
            _consecutiveFailuresByDefinitionId.Remove(definition.Id);
            _lastFailureSummaryByDefinitionId.Remove(definition.Id);
            _fusedDefinitionIds.Remove(definition.Id);
            return true;
        }
    }

    public bool RegisterActorTrigger(
        string id,
        string ownerId,
        EraTriggerType triggerType,
        EraTriggerSubject subject,
        Func<Actor, bool> actorMatcher,
        Action<EraTriggerContext, Actor> handler,
        float chancePercent = 100f,
        Func<EraTriggerContext, bool>? condition = null
    )
    {
        if (actorMatcher == null)
        {
            throw new ArgumentNullException(nameof(actorMatcher));
        }

        if (handler == null)
        {
            throw new ArgumentNullException(nameof(handler));
        }

        return Register(
            new EraTriggerDefinition(
                id,
                ownerId,
                triggerType,
                context =>
                {
                    foreach (Actor actor in ResolveActors(context, subject).Where(actorMatcher))
                    {
                        handler(context, actor);
                    }
                },
                chancePercent,
                context =>
                {
                    if (condition != null && !condition(context))
                    {
                        return false;
                    }

                    return ResolveActors(context, subject).Any(actorMatcher);
                }
            )
        );
    }

    public bool RegisterTraitTrigger(
        string id,
        string ownerId,
        EraTriggerType triggerType,
        EraTriggerSubject subject,
        string traitId,
        Action<EraTriggerContext, Actor> handler,
        float chancePercent = 100f,
        Func<EraTriggerContext, bool>? condition = null
    )
    {
        if (string.IsNullOrWhiteSpace(traitId))
        {
            throw new ArgumentException("特质 ID 不能为空。", nameof(traitId));
        }

        return RegisterActorTrigger(
            id,
            ownerId,
            triggerType,
            subject,
            actor => actor.hasTrait(traitId),
            handler,
            chancePercent,
            condition
        );
    }

    public bool RegisterEquipmentTrigger(
        string id,
        string ownerId,
        EraTriggerType triggerType,
        EraTriggerSubject subject,
        string equipmentId,
        Action<EraTriggerContext, Actor> handler,
        float chancePercent = 100f,
        Func<EraTriggerContext, bool>? condition = null
    )
    {
        if (string.IsNullOrWhiteSpace(equipmentId))
        {
            throw new ArgumentException("装备 ID 不能为空。", nameof(equipmentId));
        }

        return RegisterActorTrigger(
            id,
            ownerId,
            triggerType,
            subject,
            actor => HasEquipment(actor, equipmentId),
            handler,
            chancePercent,
            condition
        );
    }

    public bool RegisterActorAssetTrigger(
        string id,
        string ownerId,
        EraTriggerType triggerType,
        EraTriggerSubject subject,
        string actorAssetId,
        Action<EraTriggerContext, Actor> handler,
        float chancePercent = 100f,
        Func<EraTriggerContext, bool>? condition = null
    )
    {
        if (string.IsNullOrWhiteSpace(actorAssetId))
        {
            throw new ArgumentException("单位模板 ID 不能为空。", nameof(actorAssetId));
        }

        return RegisterActorTrigger(
            id,
            ownerId,
            triggerType,
            subject,
            actor => actor.asset != null && actor.asset.id == actorAssetId,
            handler,
            chancePercent,
            condition
        );
    }

    public int UnregisterOwner(string ownerId)
    {
        lock (_definitionsLock)
        {
            int removed = 0;
            List<string> removedDefinitionIds = new List<string>();
            foreach (List<EraTriggerDefinition> bucket in _definitions.Values)
            {
                for (int index = bucket.Count - 1; index >= 0; index--)
                {
                    EraTriggerDefinition definition = bucket[index];
                    if (definition.OwnerId != ownerId)
                    {
                        continue;
                    }

                    removedDefinitionIds.Add(definition.Id);
                    bucket.RemoveAt(index);
                    removed++;
                }
            }

            foreach (string definitionId in removedDefinitionIds)
            {
                _consecutiveFailuresByDefinitionId.Remove(definitionId);
                _lastFailureSummaryByDefinitionId.Remove(definitionId);
                _fusedDefinitionIds.Remove(definitionId);
            }

            return removed;
        }
    }

    public void Dispatch(EraTriggerContext context)
    {
        if (context.TriggerType == EraTriggerType.OnTick)
        {
            string key = BuildQueuedTickKey(context);
            long dropped = 0;
            long merged = 0;
            int backlog;
            lock (_queuedContextsLock)
            {
                if (_queuedTickContextsByKey.ContainsKey(key))
                {
                    _queuedTickContextsByKey[key] = context;
                    _queuedTickMerged++;
                    merged = 1;
                    backlog = _queuedTickContextsByKey.Count;
                }
                else
                {
                    while (_queuedTickContextsByKey.Count >= MaxQueuedTickContexts && _queuedTickKeys.Count > 0)
                    {
                        string oldestKey = _queuedTickKeys.Dequeue();
                        if (_queuedTickContextsByKey.Remove(oldestKey))
                        {
                            _queuedTickDropped++;
                            dropped++;
                            break;
                        }
                    }

                    _queuedTickKeys.Enqueue(key);
                    _queuedTickContextsByKey[key] = context;
                    backlog = _queuedTickContextsByKey.Count;
                }
            }

            LogQueueGovernanceIfNeeded("enqueue", context.WorldTime, dropped, merged, 0, backlog);
            return;
        }

        DispatchNow(context);
    }

    public void DrainQueued()
    {
        List<EraTriggerContext> batch = new List<EraTriggerContext>(MaxTickContextsPerDrain);
        int backlog;
        lock (_queuedContextsLock)
        {
            while (batch.Count < MaxTickContextsPerDrain && _queuedTickKeys.Count > 0)
            {
                string key = _queuedTickKeys.Dequeue();
                if (!_queuedTickContextsByKey.TryGetValue(key, out EraTriggerContext context))
                {
                    continue;
                }

                _queuedTickContextsByKey.Remove(key);
                batch.Add(context);
            }

            backlog = _queuedTickContextsByKey.Count;
        }

        if (batch.Count == 0)
        {
            return;
        }

        int skippedDead = 0;
        float worldTime = 0f;
        foreach (EraTriggerContext context in batch)
        {
            worldTime = context.WorldTime;
            if ((context.SourceActor != null && !context.SourceActor.isAlive()) ||
                (context.TargetActor != null && !context.TargetActor.isAlive()))
            {
                skippedDead++;
                continue;
            }

            DispatchNow(context);
        }

        if (skippedDead > 0)
        {
            lock (_queuedContextsLock)
            {
                _queuedTickSkippedDead += skippedDead;
            }
        }

        LogQueueGovernanceIfNeeded("drain", worldTime, 0, 0, skippedDead, backlog);
    }

    private void DispatchNow(EraTriggerContext context)
    {
        List<EraTriggerDefinition> snapshot;
        lock (_definitionsLock)
        {
            if (!_definitions.TryGetValue(context.TriggerType, out List<EraTriggerDefinition>? definitions) ||
                definitions.Count == 0)
            {
                return;
            }

            snapshot = new List<EraTriggerDefinition>(definitions);
        }

        foreach (EraTriggerDefinition definition in snapshot)
        {
            if (IsDefinitionFused(definition.Id))
            {
                continue;
            }

            try
            {
                if (definition.Condition != null && !definition.Condition(context))
                {
                    continue;
                }

                if (!PassChance(definition, context))
                {
                    continue;
                }

                definition.Handler(context);
                ResetFailureIfHealthy(definition.Id);
            }
            catch (Exception exception)
            {
                (int failureCount, bool fusedNow) = RecordDefinitionFailure(definition.Id, exception);
                EraLog.Exception(
                    EraLogCategory.Combat,
                    $"触发定义执行失败：{definition.Id} -> {definition.TriggerType}",
                    exception
                );
                if (fusedNow)
                {
                    string summary = $"{exception.GetType().Name}: {exception.Message}";
                    EraLog.Error(
                        EraLogCategory.Combat,
                        $"触发定义已熔断：{definition.Id} -> {definition.TriggerType}；连续失败={failureCount}；最近异常={summary}"
                    );
                }
            }
        }
    }

    public string CreateStatusReport()
    {
        int total;
        int fused;
        int queued;
        long dropped;
        long merged;
        long skippedDead;
        lock (_definitionsLock)
        {
            total = _definitions.Values.Sum(item => item.Count);
            fused = _fusedDefinitionIds.Count;
        }

        lock (_queuedContextsLock)
        {
            queued = _queuedTickContextsByKey.Count;
            dropped = _queuedTickDropped;
            merged = _queuedTickMerged;
            skippedDead = _queuedTickSkippedDead;
        }

        return $"定义={total}；主动={Count(EraTriggerType.Active)}；命中={Count(EraTriggerType.OnHit)}；受击={Count(EraTriggerType.OnGetHit)}；死亡={Count(EraTriggerType.OnDeath)}；轮询={Count(EraTriggerType.OnTick)}；轮询排队={queued}；轮询丢弃={dropped}；轮询合并={merged}；轮询跳过死亡={skippedDead}；熔断={fused}";
    }

    private bool PassChance(EraTriggerDefinition definition, EraTriggerContext context)
    {
        if (definition.ChancePercent >= 100f)
        {
            return true;
        }

        if (definition.ChancePercent <= 0f)
        {
            return false;
        }

        long sourceId = context.Source?.getID() ?? 0L;
        long targetId = context.Target?.getID() ?? 0L;
        string scope = $"{definition.Id}:{sourceId}:{targetId}:{(int)context.WorldTime}:{context.TriggerType}";
        return _stableRandom.NextFloat("combat_trigger", scope, 0f, 100f) <= definition.ChancePercent;
    }

    private int Count(EraTriggerType type)
    {
        lock (_definitionsLock)
        {
            return _definitions.TryGetValue(type, out List<EraTriggerDefinition>? bucket) ? bucket.Count : 0;
        }
    }

    private static IEnumerable<Actor> ResolveActors(EraTriggerContext context, EraTriggerSubject subject)
    {
        return subject switch
        {
            EraTriggerSubject.Source => YieldActor(context.SourceActor),
            EraTriggerSubject.Target => YieldActor(context.TargetActor),
            EraTriggerSubject.Any => YieldDistinctActors(context.SourceActor, context.TargetActor),
            EraTriggerSubject.Both => context.SourceActor != null && context.TargetActor != null
                ? YieldDistinctActors(context.SourceActor, context.TargetActor)
                : Enumerable.Empty<Actor>(),
            _ => Enumerable.Empty<Actor>(),
        };
    }

    private static IEnumerable<Actor> YieldActor(Actor? actor)
    {
        if (actor != null)
        {
            yield return actor;
        }
    }

    private static IEnumerable<Actor> YieldDistinctActors(Actor? first, Actor? second)
    {
        if (first != null)
        {
            yield return first;
        }

        if (second != null && (first == null || first.getID() != second.getID()))
        {
            yield return second;
        }
    }

    private static bool HasEquipment(Actor actor, string equipmentId)
    {
        if (actor.equipment == null)
        {
            return false;
        }

        foreach (ActorEquipmentSlot slot in actor.equipment)
        {
            if (slot == null || slot.isEmpty())
            {
                continue;
            }

            Item? item = slot.getItem();
            if (item?.getAsset()?.id == equipmentId)
            {
                return true;
            }
        }

        return false;
    }

    private void LogQueueGovernanceIfNeeded(
        string stage,
        float worldTime,
        long dropped,
        long merged,
        int skippedDead,
        int backlog
    )
    {
        if (dropped <= 0 && merged <= 0 && skippedDead <= 0 && backlog <= MaxTickContextsPerDrain)
        {
            return;
        }

        DateTime now = DateTime.UtcNow;
        lock (_queuedContextsLock)
        {
            if (now - _lastQueueGovernanceLogUtc < QueueGovernanceLogInterval)
            {
                return;
            }

            _lastQueueGovernanceLogUtc = now;
        }

        EraLog.Event(
            EraLogCategory.Combat,
            "on_tick_queue",
            stage,
            EraRuntimeBootstrap.RuntimeSave?.CurrentState.CompletedCycles ?? 0,
            worldTime,
            "governed",
            ("dropped", dropped),
            ("merged", merged),
            ("backlog", backlog),
            ("skippedDead", skippedDead)
        );
    }

    private static string BuildQueuedTickKey(EraTriggerContext context)
    {
        string sourceScopeId = NormalizeQueuedTickSourceId(context.SourceId);
        long sourceObjectId = context.Source?.getID() ?? 0L;
        long targetObjectId = context.Target?.getID() ?? 0L;
        long sourceActorId = context.SourceActor?.getID() ?? 0L;
        long targetActorId = context.TargetActor?.getID() ?? 0L;
        long worldTick = (long)Math.Floor(context.WorldTime * 1000.0);
        return $"{sourceScopeId}:{sourceObjectId}:{targetObjectId}:{sourceActorId}:{targetActorId}:{worldTick}";
    }

    private static string NormalizeQueuedTickSourceId(string sourceId)
    {
        if (string.IsNullOrWhiteSpace(sourceId))
        {
            return "runtime";
        }

        return sourceId
            .Replace(':', '_')
            .Replace('|', '_')
            .Replace('\r', '_')
            .Replace('\n', '_');
    }

    private List<EraTriggerDefinition> GetOrCreateBucketLocked(EraTriggerType type)
    {
        if (_definitions.TryGetValue(type, out List<EraTriggerDefinition>? bucket))
        {
            return bucket;
        }

        bucket = new List<EraTriggerDefinition>();
        _definitions[type] = bucket;
        return bucket;
    }

    private bool IsDefinitionFused(string definitionId)
    {
        lock (_definitionsLock)
        {
            return _fusedDefinitionIds.Contains(definitionId);
        }
    }

    private void ResetFailureIfHealthy(string definitionId)
    {
        lock (_definitionsLock)
        {
            _consecutiveFailuresByDefinitionId.Remove(definitionId);
            _lastFailureSummaryByDefinitionId.Remove(definitionId);
        }
    }

    private (int FailureCount, bool FusedNow) RecordDefinitionFailure(string definitionId, Exception exception)
    {
        lock (_definitionsLock)
        {
            int failureCount = _consecutiveFailuresByDefinitionId.TryGetValue(definitionId, out int existing)
                ? existing + 1
                : 1;
            _consecutiveFailuresByDefinitionId[definitionId] = failureCount;
            _lastFailureSummaryByDefinitionId[definitionId] = $"{exception.GetType().Name}: {exception.Message}";

            bool fusedNow = false;
            if (failureCount >= TriggerFailureFuseThreshold && !_fusedDefinitionIds.Contains(definitionId))
            {
                _fusedDefinitionIds.Add(definitionId);
                fusedNow = true;
            }

            return (failureCount, fusedNow);
        }
    }
}
