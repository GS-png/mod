using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using EraWheel.Core;

namespace EraWheel.Narrative
{
    public class EventPool
    {
        private struct Candidate
        {
            public NarrativeEvent Event;
            public int Weight;
        }

        private readonly List<NarrativeEvent> _events = new List<NarrativeEvent>();
        private readonly Dictionary<string, NarrativeEvent> _eventById = new Dictionary<string, NarrativeEvent>();
        private readonly Dictionary<string, long> _cooldowns = new Dictionary<string, long>();
        private readonly Dictionary<string, int> _triggerCounts = new Dictionary<string, int>(StringComparer.Ordinal);
        private readonly HashSet<string> _triggeredEvents = new HashSet<string>(StringComparer.Ordinal);
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
            json = NormalizeJson(json);
            var data = DeserializePoolData(json);

            if (data?.Events == null)
            {
                Log.Warning($"[EventPool] 事件文件解析失败: {filePath}");
                return;
            }

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

            ctx.TriggeredEvents = _triggeredEvents;

            var candidates = new List<Candidate>();
            var totalWeight = 0;
            var topPriority = int.MinValue;

            foreach (var evt in _events)
            {
                if (!CanTrigger(evt, ctx))
                    continue;

                if (!EventConditionEvaluator.EvaluateAll(evt.Conditions, ctx, evt.ConditionMode))
                    continue;

                var priority = evt.Priority;
                if (priority > topPriority)
                {
                    topPriority = priority;
                    candidates.Clear();
                    totalWeight = 0;
                }

                if (priority < topPriority)
                    continue;

                var w = Math.Max(1, evt.Priority);
                candidates.Add(new Candidate
                {
                    Event = evt,
                    Weight = w
                });
                totalWeight += w;
            }

            if (candidates.Count == 0)
                return null;

            if (totalWeight <= 0)
                return candidates[0].Event;

            var roll = _rng.Next(0, totalWeight);
            var cumulative = 0;
            for (var i = 0; i < candidates.Count; i++)
            {
                cumulative += candidates[i].Weight;
                if (roll < cumulative)
                    return candidates[i].Event;
            }

            return candidates[candidates.Count - 1].Event;
        }

        public bool CanTrigger(NarrativeEvent evt, WorldContext ctx)
        {
            if (evt == null || ctx == null)
                return false;

            if (!evt.Repeatable && _triggeredEvents.Contains(evt.Id))
                return false;

            if (evt.MaxTriggers > 0 && _triggerCounts.TryGetValue(evt.Id, out var count) && count >= evt.MaxTriggers)
                return false;

            if (_cooldowns.TryGetValue(evt.Id, out var cooldownEnd))
            {
                if (ctx.WorldAge < cooldownEnd)
                    return false;
            }

            if (IsInRecentHistory(evt.Id))
                return false;

            return true;
        }

        private bool IsInRecentHistory(string eventId)
        {
            var remaining = _duplicatePreventionWindow;
            for (var i = _recentHistory.Count - 1; i >= 0 && remaining > 0; i--, remaining--)
            {
                var rec = _recentHistory[i];
                if (rec.EventId == eventId)
                    return true;
            }

            return false;
        }

        public void MarkTriggered(NarrativeEvent evt, WorldContext ctx)
        {
            if (evt == null || ctx == null) return;

            _triggeredEvents.Add(evt.Id);
            if (_triggerCounts.TryGetValue(evt.Id, out var count))
            {
                _triggerCounts[evt.Id] = count + 1;
            }
            else
            {
                _triggerCounts[evt.Id] = 1;
            }

            if (evt.Cooldown > 0)
            {
                _cooldowns[evt.Id] = ctx.WorldAge + evt.Cooldown;
            }

            _recentHistory.Add(new TriggeredEventRecord
            {
                EventId = evt.Id,
                TriggeredAtWorldAge = ctx.WorldAge,
                TriggeredAtCycle = ctx.CycleCount
            });

            var maxHistory = Math.Max(100, _duplicatePreventionWindow * 2);
            while (_recentHistory.Count > maxHistory)
            {
                _recentHistory.RemoveAt(0);
            }
        }

        public void Clear()
        {
            _events.Clear();
            _eventById.Clear();
            _cooldowns.Clear();
            _triggerCounts.Clear();
            _triggeredEvents.Clear();
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

            var countList = new List<TriggerCountEntry>();
            foreach (var kvp in _triggerCounts)
            {
                countList.Add(new TriggerCountEntry
                {
                    EventId = kvp.Key,
                    Count = kvp.Value
                });
            }
            data.TriggerCounts = countList.ToArray();

            data.RecentHistory = _recentHistory.ToArray();

            return data;
        }

        public void LoadSaveData(EventPoolSaveData data)
        {
            _cooldowns.Clear();
            _triggerCounts.Clear();
            _triggeredEvents.Clear();
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

            if (data.TriggerCounts != null)
            {
                foreach (var entry in data.TriggerCounts)
                {
                    if (entry == null || string.IsNullOrEmpty(entry.EventId))
                    {
                        continue;
                    }

                    _triggerCounts[entry.EventId] = entry.Count;
                    if (entry.Count > 0)
                    {
                        _triggeredEvents.Add(entry.EventId);
                    }
                }
            }

            if (data.RecentHistory != null)
            {
                _recentHistory.AddRange(data.RecentHistory);
            }
        }

        private static string NormalizeJson(string json)
        {
            if (string.IsNullOrEmpty(json))
            {
                return json;
            }

            var map = new Dictionary<string, string>(StringComparer.Ordinal)
            {
                { "version", "Version" },
                { "events", "Events" },
                { "id", "Id" },
                { "name_key", "NameKey" },
                { "title_key", "TitleKey" },
                { "category", "Category" },
                { "priority", "Priority" },
                { "conditions", "Conditions" },
                { "condition_mode", "ConditionMode" },
                { "description_key", "DescriptionKey" },
                { "image_key", "ImageKey" },
                { "choices", "Choices" },
                { "effects", "Effects" },
                { "cooldown", "Cooldown" },
                { "cooldown_years", "Cooldown" },
                { "repeatable", "Repeatable" },
                { "max_triggers", "MaxTriggers" },
                { "type", "Type" },
                { "operator", "Operator" },
                { "value", "Value" },
                { "target", "Target" },
                { "text_key", "TextKey" },
                { "duration", "Duration" }
            };

            foreach (var kvp in map)
            {
                json = Regex.Replace(json, $"\\\"{kvp.Key}\\\"\\s*:", $"\"{kvp.Value}\":");
            }

            return json;
        }

        private static NarrativeEventPoolData DeserializePoolData(string json)
        {
#if ERAWHEEL_SELFTEST
            try
            {
                var options = new System.Text.Json.JsonSerializerOptions
                {
                    IncludeFields = true,
                    PropertyNameCaseInsensitive = true
                };
                return System.Text.Json.JsonSerializer.Deserialize<NarrativeEventPoolData>(json, options);
            }
            catch (Exception ex)
            {
                Log.Warning("[EventPool] 自检解析异常: " + ex.Message);
            }
#endif

            return JsonCompat.FromJson<NarrativeEventPoolData>(json);
        }
    }

    [Serializable]
    public class EventPoolSaveData
    {
        public CooldownEntry[] Cooldowns;
        public TriggerCountEntry[] TriggerCounts;
        public TriggeredEventRecord[] RecentHistory;
    }

    [Serializable]
    public class CooldownEntry
    {
        public string EventId;
        public long CooldownEnd;
    }

    [Serializable]
    public class TriggerCountEntry
    {
        public string EventId;
        public int Count;
    }
}
