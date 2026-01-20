using System;
using System.Collections.Generic;
using System.IO;
using EraWheel.Core;
using UnityEngine;

namespace EraWheel.Narrative
{
    public class EventPool
    {
        private readonly List<NarrativeEvent> _events = new List<NarrativeEvent>();
        private readonly Dictionary<string, NarrativeEvent> _eventById = new Dictionary<string, NarrativeEvent>();
        private readonly Dictionary<string, long> _cooldowns = new Dictionary<string, long>();
        private readonly HashSet<string> _triggeredUniques = new HashSet<string>();
        private readonly List<TriggeredEventRecord> _recentHistory = new List<TriggeredEventRecord>();

        private readonly System.Random _rng = new System.Random();
        private int _duplicatePreventionWindow = 10;

        public int EventCount => _events.Count;
        public IReadOnlyList<NarrativeEvent> AllEvents => _events;

        public void SetDuplicatePreventionWindow(int window)
        {
            _duplicatePreventionWindow = Math.Max(1, window);
        }

        public void LoadFromDirectory(string path)
        {
            if (string.IsNullOrEmpty(path) || !Directory.Exists(path))
            {
                Log.Warning($"[EventPool] 事件目录不存在: {path}");
                return;
            }

            var files = Directory.GetFiles(path, "*.json", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                try
                {
                    LoadFromFile(file);
                }
                catch (Exception ex)
                {
                    Log.Warning($"[EventPool] 加载事件文件失败 {file}: {ex.Message}");
                }
            }

            Log.Info($"[EventPool] 加载了 {_events.Count} 个事件");
        }

        public void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath)) return;

            var json = File.ReadAllText(filePath);
            var data = JsonUtility.FromJson<NarrativeEventPoolData>(json);

            if (data?.Events == null) return;

            foreach (var evt in data.Events)
            {
                if (string.IsNullOrEmpty(evt.Id)) continue;
                RegisterEvent(evt);
            }
        }

        public void RegisterEvent(NarrativeEvent evt)
        {
            if (evt == null || string.IsNullOrEmpty(evt.Id)) return;

            if (_eventById.ContainsKey(evt.Id))
            {
                Log.Warning($"[EventPool] 事件ID重复，跳过: {evt.Id}");
                return;
            }

            _events.Add(evt);
            _eventById[evt.Id] = evt;
        }

        public NarrativeEvent GetById(string id)
        {
            if (string.IsNullOrEmpty(id)) return null;
            _eventById.TryGetValue(id, out var evt);
            return evt;
        }

        public NarrativeEvent SelectEvent(WorldContext ctx)
        {
            if (_events.Count == 0 || ctx == null)
                return null;

            var candidates = new List<NarrativeEvent>();
            var weights = new List<int>();
            var totalWeight = 0;

            foreach (var evt in _events)
            {
                if (!CanTrigger(evt, ctx))
                    continue;

                if (!EventConditionEvaluator.EvaluateAll(evt.Conditions, ctx))
                    continue;

                candidates.Add(evt);
                var w = evt.Weight * (int)evt.Priority;
                weights.Add(w);
                totalWeight += w;
            }

            if (candidates.Count == 0)
                return null;

            candidates.Sort((a, b) => (int)b.Priority - (int)a.Priority);

            var roll = _rng.Next(0, totalWeight);
            var cumulative = 0;
            for (var i = 0; i < candidates.Count; i++)
            {
                cumulative += weights[i];
                if (roll < cumulative)
                    return candidates[i];
            }

            return candidates[candidates.Count - 1];
        }

        public bool CanTrigger(NarrativeEvent evt, WorldContext ctx)
        {
            if (evt == null || ctx == null)
                return false;

            if (evt.Unique && _triggeredUniques.Contains(evt.Id))
                return false;

            if (_cooldowns.TryGetValue(evt.Id, out var cooldownEnd))
            {
                if (ctx.WorldAge < cooldownEnd)
                    return false;
            }

            if (IsInRecentHistory(evt.Id, ctx.CycleCount))
                return false;

            return true;
        }

        private bool IsInRecentHistory(string eventId, int currentCycle)
        {
            for (var i = _recentHistory.Count - 1; i >= 0; i--)
            {
                var rec = _recentHistory[i];
                if (rec.EventId == eventId)
                {
                    var cycleDiff = currentCycle - rec.TriggeredAtCycle;
                    if (cycleDiff < _duplicatePreventionWindow)
                        return true;
                }
            }

            return false;
        }

        public void MarkTriggered(NarrativeEvent evt, WorldContext ctx)
        {
            if (evt == null || ctx == null) return;

            if (evt.Unique)
            {
                _triggeredUniques.Add(evt.Id);
            }

            if (evt.CooldownYears > 0)
            {
                _cooldowns[evt.Id] = ctx.WorldAge + evt.CooldownYears;
            }

            _recentHistory.Add(new TriggeredEventRecord
            {
                EventId = evt.Id,
                TriggeredAtWorldAge = ctx.WorldAge,
                TriggeredAtCycle = ctx.CycleCount
            });

            while (_recentHistory.Count > 100)
            {
                _recentHistory.RemoveAt(0);
            }
        }

        public void Clear()
        {
            _events.Clear();
            _eventById.Clear();
            _cooldowns.Clear();
            _triggeredUniques.Clear();
            _recentHistory.Clear();
        }

        public void ResetCooldowns()
        {
            _cooldowns.Clear();
        }

        public EventPoolSaveData GetSaveData()
        {
            var data = new EventPoolSaveData();

            var cooldownList = new List<CooldownEntry>();
            foreach (var kvp in _cooldowns)
            {
                cooldownList.Add(new CooldownEntry { EventId = kvp.Key, CooldownEnd = kvp.Value });
            }
            data.Cooldowns = cooldownList.ToArray();

            var uniqueList = new List<string>();
            foreach (var id in _triggeredUniques)
            {
                uniqueList.Add(id);
            }
            data.TriggeredUniques = uniqueList.ToArray();

            data.RecentHistory = _recentHistory.ToArray();

            return data;
        }

        public void LoadSaveData(EventPoolSaveData data)
        {
            _cooldowns.Clear();
            _triggeredUniques.Clear();
            _recentHistory.Clear();

            if (data == null) return;

            if (data.Cooldowns != null)
            {
                foreach (var entry in data.Cooldowns)
                {
                    if (!string.IsNullOrEmpty(entry.EventId))
                    {
                        _cooldowns[entry.EventId] = entry.CooldownEnd;
                    }
                }
            }

            if (data.TriggeredUniques != null)
            {
                foreach (var id in data.TriggeredUniques)
                {
                    if (!string.IsNullOrEmpty(id))
                    {
                        _triggeredUniques.Add(id);
                    }
                }
            }

            if (data.RecentHistory != null)
            {
                _recentHistory.AddRange(data.RecentHistory);
            }
        }
    }

    [Serializable]
    public class EventPoolSaveData
    {
        public CooldownEntry[] Cooldowns;
        public string[] TriggeredUniques;
        public TriggeredEventRecord[] RecentHistory;
    }

    [Serializable]
    public class CooldownEntry
    {
        public string EventId;
        public long CooldownEnd;
    }
}
