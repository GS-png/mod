using System;
using System.Collections;
using EraOfWheel.Core;
using EraOfWheel.Core.Events;
using UnityEngine;

namespace EraOfWheel.LLM
{
    /// <summary>
    /// AI叙事引擎 - 将LLM响应转化为游戏叙事
    /// </summary>
    public class NarrativeEngine : IModSystem
    {
        public static NarrativeEngine Instance { get; private set; }
        
        public string SystemName => "NarrativeEngine";
        public bool IsInitialized { get; private set; }

        private MonoBehaviour _coroutineRunner;

        public void Initialize()
        {
            if (IsInitialized) return;

            Instance = this;
            _coroutineRunner = ModMain.Instance;
            
            IsInitialized = true;
            Logger.Info(SystemName, "AI叙事引擎初始化完成");
        }

        /// <summary>
        /// 生成叙事事件
        /// </summary>
        public void GenerateNarrativeEvent(string context, Action<NarrativeEvent> callback)
        {
            var request = new LLMRequest
            {
                SystemPrompt = GetSystemPrompt(),
                Prompt = $"根据以下情境生成一个简短的游戏事件：\n{context}\n\n请用中文回复，格式：\n标题：[事件标题]\n描述：[事件描述]",
                Temperature = 0.8f,
                MaxTokens = 200
            };

            _coroutineRunner?.StartCoroutine(RequestNarrative(request, callback));
        }

        private IEnumerator RequestNarrative(LLMRequest request, Action<NarrativeEvent> callback)
        {
            NarrativeEvent result = null;
            
            yield return LLMClient.Instance?.SendRequest(request, response =>
            {
                if (response.Success)
                {
                    result = ParseNarrativeEvent(response.Content);
                }
                else
                {
                    // 使用后备事件
                    var fallback = FallbackEventPool.Instance?.GetRandomEvent("narrative");
                    if (fallback != null)
                    {
                        result = new NarrativeEvent
                        {
                            Title = fallback.Title,
                            Description = fallback.Description,
                            IsAIGenerated = false
                        };
                    }
                }
            });

            callback?.Invoke(result);
        }

        private NarrativeEvent ParseNarrativeEvent(string content)
        {
            var evt = new NarrativeEvent { IsAIGenerated = true };
            
            var lines = content.Split('\n');
            foreach (var line in lines)
            {
                if (line.StartsWith("标题："))
                    evt.Title = line.Substring(3).Trim();
                else if (line.StartsWith("描述："))
                    evt.Description = line.Substring(3).Trim();
            }

            if (string.IsNullOrEmpty(evt.Title))
                evt.Title = "神秘事件";
            if (string.IsNullOrEmpty(evt.Description))
                evt.Description = content;

            return evt;
        }

        private string GetSystemPrompt()
        {
            return @"你是一个奇幻世界的叙事者。你的任务是为游戏生成富有戏剧性的事件描述。
规则：
1. 保持简短精炼（不超过50字）
2. 使用史诗般的语言风格
3. 与轮回和魔王主题相关
4. 避免重复之前的事件";
        }

        public void Dispose()
        {
            Instance = null;
            IsInitialized = false;
        }
    }

    public class NarrativeEvent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsAIGenerated { get; set; }
    }
}
