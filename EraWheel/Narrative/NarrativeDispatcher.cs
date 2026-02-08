using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using EraWheel.Config;
using EraWheel.Core;

namespace EraWheel.Narrative
{
    public class NarrativeDispatcher
    {
        private static NarrativeDispatcher _instance;
        public static NarrativeDispatcher Instance => _instance ?? (_instance = new NarrativeDispatcher());

        private readonly EventPool _eventPool = new EventPool();
        private long _lastCheckWorldAge;
        private int _frameCounter;
        private bool _initialized;

        public EventPool EventPool => _eventPool;
        public bool AIEnabled { get; set; }

        public void Initialize(ModConfig cfg, string eventsPath)
        {
            if (_initialized) return;

            try
            {
                var window = 10;
                if (cfg?.narrative?.event_pool != null)
                {
                    window = cfg.narrative.event_pool.duplicate_prevention_window;
                }
                _eventPool.SetDuplicatePreventionWindow(window);
                _eventPool.LoadFromDirectory(eventsPath);
                _initialized = true;
                Log.Info($"[NarrativeDispatcher] 初始化完成，加载了 {_eventPool.EventCount} 个事件");
            }
            catch (Exception ex)
            {
                Log.Warning($"[NarrativeDispatcher] 初始化失败: {ex.Message}");
            }
        }

        public void Update(ModConfig cfg, WorldContext ctx)
        {
            if (!_initialized || cfg == null || ctx == null) return;

            _frameCounter++;
            var interval = 300;
            if (cfg.narrative?.event_pool != null)
            {
                interval = Math.Max(60, cfg.narrative.event_pool.trigger_interval_frames);
            }

            if (_frameCounter < interval) return;
            _frameCounter = 0;

            if (_lastCheckWorldAge == ctx.WorldAge) return;
            _lastCheckWorldAge = ctx.WorldAge;

            TryTriggerEvent(cfg, ctx);
        }

        public void TryTriggerEvent(ModConfig cfg, WorldContext ctx)
        {
            if (cfg?.narrative?.ai_engine?.enabled == true && AIEnabled)
            {
                return;
            }

            var evt = _eventPool.SelectEvent(ctx);
            if (evt == null) return;

            DispatchEvent(evt, ctx);
            _eventPool.MarkTriggered(evt, ctx);
        }

        public void DispatchEvent(NarrativeEvent evt, WorldContext ctx)
        {
            if (evt == null) return;

            var titleKey = !string.IsNullOrEmpty(evt.NameKey) ? evt.NameKey : evt.TitleKey;
            var title = Localization.Get(titleKey, titleKey);
            var desc = Localization.Get(evt.DescriptionKey, evt.DescriptionKey);

            Log.Info($"[NarrativeDispatcher] 触发事件: {evt.Id} - {title}");

            try
            {
                ShowNotification(title, desc, ParseCategory(evt.Category));
            }
            catch (Exception ex)
            {
                Log.Warning($"[NarrativeDispatcher] 显示通知失败: {ex.Message}");
            }

            if (evt.Effects != null)
            {
                foreach (var effect in evt.Effects)
                {
                    ApplyEffect(effect, ctx);
                }
            }

            EventBus.Publish(new NarrativeEventTriggeredEvent
            {
                EventId = evt.Id,
                Category = ParseCategory(evt.Category),
                WorldAge = ctx.WorldAge
            });
        }

        private void ApplyEffect(NarrativeEffect effect, WorldContext ctx)
        {
            if (effect == null) return;

            try
            {
                switch (effect.Type)
                {
                    case NarrativeEffect.Types.ShowNotification:
                        var msg = Localization.Get(effect.Value, effect.Value);
                        ShowNotification("系统", msg, NarrativeEventCategory.System);
                        break;

                    case NarrativeEffect.Types.AddChronicle:
                        Log.Info($"[NarrativeEffect] {effect.Value}");
                        break;
                }
            }
            catch
            {
            }
        }

        private void ShowNotification(string title, string content, NarrativeEventCategory category)
        {
            try
            {
                WorldCompat.ShowNotification($"【{title}】{content}");
            }
            catch
            {
                Log.Info($"[Notification] {title}: {content}");
            }
        }

        public static void NotifyOmenEntered()
        {
            try
            {
                Log.Info("[EraWheel] 预兆阶段开始");

                var ctx = WorldContext.Capture();
                ctx.CurrentPhase = EraPhase.Omen;

                var evt = Instance._eventPool.GetById("omen_started");
                if (evt != null)
                {
                    Instance.DispatchEvent(evt, ctx);
                    Instance._eventPool.MarkTriggered(evt, ctx);
                }
            }
            catch
            {
            }
        }

        public static void NotifyPhaseChanged(EraPhase prev, EraPhase next)
        {
            try
            {
                Log.Info($"[EraWheel] 阶段变化: {prev} -> {next}");
            }
            catch
            {
            }
        }

        public static void NotifyDemonAwakened(string demonId)
        {
            try
            {
                Log.Info($"[EraWheel] 魔王苏醒: {demonId}");
            }
            catch
            {
            }
        }

        public static void NotifyHeroBorn(string heroName)
        {
            try
            {
                Log.Info($"[EraWheel] 命定英雄诞生: {heroName}");
            }
            catch
            {
            }
        }

        public static void NotifyAllianceFormed()
        {
            try
            {
                Log.Info("[EraWheel] 反魔联盟成立");
            }
            catch
            {
            }
        }

        public static void NotifyCycleCompleted(int cycleNumber)
        {
            try
            {
                Log.Info($"[EraWheel] 轮回完成: 第 {cycleNumber} 轮");
            }
            catch
            {
            }
        }

        public EventPoolSaveData GetSaveData()
        {
            return _eventPool.GetSaveData();
        }

        public void LoadSaveData(EventPoolSaveData data)
        {
            _eventPool.LoadSaveData(data);
        }

        public void Reset()
        {
            _eventPool.ResetCooldowns();
            _frameCounter = 0;
            _lastCheckWorldAge = 0;
        }

        private static NarrativeEventCategory ParseCategory(string category)
        {
            if (string.IsNullOrEmpty(category))
            {
                return NarrativeEventCategory.Unknown;
            }

            if (Enum.TryParse(category, true, out NarrativeEventCategory parsed))
            {
                return parsed;
            }

            return NarrativeEventCategory.Unknown;
        }
    }

    [Serializable]
    public struct NarrativeEventTriggeredEvent
    {
        public string EventId;
        public NarrativeEventCategory Category;
        public long WorldAge;
    }

    public static class Localization
    {
        private static readonly Dictionary<string, string> Entries = new Dictionary<string, string>(StringComparer.Ordinal);
        private static string _basePath;
        private static string _localeId = "zh_CN";
        private static bool _loaded;

        public static void Initialize(string basePath, string localeId = null)
        {
            if (!string.IsNullOrEmpty(basePath))
            {
                _basePath = basePath;
            }

            if (!string.IsNullOrEmpty(localeId))
            {
                _localeId = localeId;
            }

            LoadLocale();
        }

        public static string Get(string key, string fallback = null)
        {
            if (string.IsNullOrEmpty(key))
                return fallback ?? "";

            if (!_loaded)
            {
                LoadLocale();
            }

            if (Entries.TryGetValue(key, out var value))
            {
                return value;
            }

            return fallback ?? key;
        }

        private static void LoadLocale()
        {
            if (string.IsNullOrEmpty(_basePath))
            {
                return;
            }

            var path = Path.Combine(_basePath, _localeId + ".json");
            if (!File.Exists(path))
            {
                path = Path.Combine(_basePath, "en.json");
                if (!File.Exists(path))
                {
                    return;
                }
            }

            try
            {
                var json = File.ReadAllText(path);
                ParseFlatJson(json, Entries);
                _loaded = true;
            }
            catch
            {
            }
        }

        private static void ParseFlatJson(string json, Dictionary<string, string> dest)
        {
            dest.Clear();
            if (string.IsNullOrEmpty(json)) return;

            var index = 0;
            SkipWhitespace(json, ref index);
            if (index >= json.Length || json[index] != '{') return;
            index++;

            while (index < json.Length)
            {
                SkipWhitespace(json, ref index);
                if (index >= json.Length) break;
                if (json[index] == '}') break;

                if (!TryReadString(json, ref index, out var key)) break;
                SkipWhitespace(json, ref index);
                if (index >= json.Length || json[index] != ':') break;
                index++;
                SkipWhitespace(json, ref index);
                if (!TryReadString(json, ref index, out var value)) break;

                dest[key] = value;

                SkipWhitespace(json, ref index);
                if (index < json.Length && json[index] == ',')
                {
                    index++;
                }
            }
        }

        private static void SkipWhitespace(string json, ref int index)
        {
            while (index < json.Length && char.IsWhiteSpace(json[index]))
            {
                index++;
            }
        }

        private static bool TryReadString(string json, ref int index, out string value)
        {
            value = "";
            if (index >= json.Length || json[index] != '\"') return false;

            index++;
            var sb = new StringBuilder();
            while (index < json.Length)
            {
                var ch = json[index++];
                if (ch == '\"')
                {
                    value = sb.ToString();
                    return true;
                }

                if (ch == '\\' && index < json.Length)
                {
                    var esc = json[index++];
                    switch (esc)
                    {
                        case '\"': sb.Append('\"'); break;
                        case '\\': sb.Append('\\'); break;
                        case '/': sb.Append('/'); break;
                        case 'b': sb.Append('\b'); break;
                        case 'f': sb.Append('\f'); break;
                        case 'n': sb.Append('\n'); break;
                        case 'r': sb.Append('\r'); break;
                        case 't': sb.Append('\t'); break;
                        case 'u':
                            if (index + 4 <= json.Length)
                            {
                                var hex = json.Substring(index, 4);
                                if (int.TryParse(hex, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var code))
                                {
                                    sb.Append((char)code);
                                }
                                index += 4;
                            }
                            break;
                        default:
                            sb.Append(esc);
                            break;
                    }
                }
                else
                {
                    sb.Append(ch);
                }
            }

            value = sb.ToString();
            return false;
        }
    }
}
