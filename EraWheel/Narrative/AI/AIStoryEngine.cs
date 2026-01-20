using System;
using System.Collections.Generic;
using EraWheel.Config;
using EraWheel.Core;
using EraWheel.Narrative.AI.Providers;

namespace EraWheel.Narrative.AI
{
    public class AIStoryEngine
    {
        private static AIStoryEngine _instance;
        public static AIStoryEngine Instance => _instance ?? (_instance = new AIStoryEngine());

        private readonly Dictionary<string, ILLMProvider> _providers = new Dictionary<string, ILLMProvider>();
        private ILLMProvider _activeProvider;
        private AIPermissionManager _permissionManager;
        private AIOperationLog _operationLog;

        private bool _initialized;
        private bool _requestInProgress;
        private int _retryCount;
        private int _maxRetries = 3;
        private int _timeoutSeconds = 30;

        public bool Enabled { get; set; }
        public bool IsAvailable => _activeProvider?.IsAvailable == true;
        public bool RequestInProgress => _requestInProgress;
        public AIPermissionManager PermissionManager => _permissionManager;
        public AIOperationLog OperationLog => _operationLog;

        public AIStoryEngine()
        {
            _permissionManager = new AIPermissionManager();
            _operationLog = new AIOperationLog();
        }

        public void Initialize(ModConfig cfg)
        {
            if (_initialized) return;

            RegisterProviders();

            if (cfg?.narrative?.ai_engine != null)
            {
                var aiCfg = cfg.narrative.ai_engine;
                Enabled = aiCfg.enabled;
                _maxRetries = aiCfg.retry_count;
                _timeoutSeconds = aiCfg.timeout_seconds;
                _permissionManager.SetLevel(aiCfg.permission_level);

                SetProvider(aiCfg.provider, aiCfg.api_url, aiCfg.model, "");
            }

            _initialized = true;
            Log.Info("[AIStoryEngine] 初始化完成");
        }

        private void RegisterProviders()
        {
            _providers["openai"] = new OpenAIProvider();
            _providers["claude"] = new ClaudeProvider();
            _providers["ollama"] = new OllamaProvider();
        }

        public void SetProvider(string providerId, string apiUrl, string model, string apiKey)
        {
            if (string.IsNullOrEmpty(providerId))
                providerId = "openai";

            if (_providers.TryGetValue(providerId.ToLower(), out var provider))
            {
                provider.Configure(apiUrl, model, apiKey);
                _activeProvider = provider;
                Log.Info($"[AIStoryEngine] 切换到提供者: {providerId}");
            }
            else
            {
                Log.Warning($"[AIStoryEngine] 未知提供者: {providerId}");
            }
        }

        public void GenerateNarrative(WorldContext ctx, string requestType, Action<string> onComplete)
        {
            if (!Enabled || !IsAvailable)
            {
                FallbackToEventPool(ctx, requestType, onComplete);
                return;
            }

            if (_requestInProgress)
            {
                Log.Warning("[AIStoryEngine] 请求进行中，跳过");
                return;
            }

            var prompt = BuildPrompt(ctx, requestType);
            var request = new LLMRequest
            {
                Prompt = prompt,
                SystemPrompt = GetSystemPrompt(),
                MaxTokens = 500,
                Temperature = 0.7f,
                Context = ctx,
                RequestType = requestType
            };

            _requestInProgress = true;
            _retryCount = 0;

            SendRequest(request, onComplete);
        }

        private void SendRequest(LLMRequest request, Action<string> onComplete)
        {
            _activeProvider.GenerateAsync(request, response =>
            {
                if (response.Success)
                {
                    _requestInProgress = false;
                    _operationLog.LogOperation(new AIOperation
                    {
                        RequestType = request.RequestType,
                        Content = response.Content,
                        TokensUsed = response.TokensUsed,
                        Success = true,
                        WorldAge = request.Context?.WorldAge ?? 0
                    });
                    onComplete?.Invoke(response.Content);
                }
                else
                {
                    _retryCount++;
                    if (_retryCount < _maxRetries)
                    {
                        Log.Warning($"[AIStoryEngine] 请求失败，重试 {_retryCount}/{_maxRetries}: {response.ErrorMessage}");
                        SendRequest(request, onComplete);
                    }
                    else
                    {
                        _requestInProgress = false;
                        _operationLog.LogOperation(new AIOperation
                        {
                            RequestType = request.RequestType,
                            Content = "",
                            ErrorMessage = response.ErrorMessage,
                            Success = false,
                            WorldAge = request.Context?.WorldAge ?? 0
                        });
                        Log.Warning($"[AIStoryEngine] 请求失败，回退到事件池: {response.ErrorMessage}");
                        FallbackToEventPool(request.Context, request.RequestType, onComplete);
                    }
                }
            });
        }

        private void FallbackToEventPool(WorldContext ctx, string requestType, Action<string> onComplete)
        {
            try
            {
                var evt = NarrativeDispatcher.Instance.EventPool.SelectEvent(ctx);
                if (evt != null)
                {
                    var title = Localization.Get(evt.TitleKey, evt.TitleKey);
                    var desc = Localization.Get(evt.DescriptionKey, evt.DescriptionKey);
                    onComplete?.Invoke($"{title}: {desc}");
                    NarrativeDispatcher.Instance.EventPool.MarkTriggered(evt, ctx);
                }
                else
                {
                    onComplete?.Invoke("");
                }
            }
            catch (Exception ex)
            {
                Log.Warning($"[AIStoryEngine] 回退失败: {ex.Message}");
                onComplete?.Invoke("");
            }
        }

        private string BuildPrompt(WorldContext ctx, string requestType)
        {
            var phase = ctx.CurrentPhase.ToString();
            var cycle = ctx.CycleCount;

            return $@"当前世界状态：
- 阶段：{phase}
- 轮回次数：{cycle}
- 封印强度：{ctx.SealStrength:F1}%
- 魔王血量：{ctx.DemonHealthPercent:F1}%
- 人口：{ctx.Population}
- 城市数：{ctx.CityCount}
- 英雄数：{ctx.HeroCount}

请根据当前状态生成一段简短的叙事描述（不超过100字），类型：{requestType}";
        }

        private string GetSystemPrompt()
        {
            return @"你是一个魔幻史诗叙事生成器。你的任务是根据游戏世界的当前状态，生成简短、富有戏剧性的叙事描述。
保持描述简洁有力，不超过100字。使用中文。保持史诗感和戏剧性。";
        }

        public void TestConnection(Action<bool, string> callback)
        {
            if (!IsAvailable)
            {
                callback?.Invoke(false, "未配置AI提供者");
                return;
            }

            _activeProvider.TestConnection(callback);
        }

        public void Cancel()
        {
            if (_requestInProgress && _activeProvider != null)
            {
                _activeProvider.Cancel();
                _requestInProgress = false;
            }
        }

        public void Reset()
        {
            Cancel();
            _retryCount = 0;
        }
    }
}
