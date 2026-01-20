using System;
using EraWheel.Core;

namespace EraWheel.Narrative.AI.Providers
{
    public class ClaudeProvider : ILLMProvider
    {
        public string ProviderId => "claude";
        public LLMProviderType ProviderType => LLMProviderType.Claude;
        public bool IsAvailable => !string.IsNullOrEmpty(_apiKey) && !string.IsNullOrEmpty(_apiUrl);

        private string _apiUrl = "https://api.anthropic.com/v1/messages";
        private string _model = "claude-3-opus-20240229";
        private string _apiKey;

        public void Configure(string apiUrl, string model, string apiKey)
        {
            if (!string.IsNullOrEmpty(apiUrl))
                _apiUrl = apiUrl;
            if (!string.IsNullOrEmpty(model))
                _model = model;
            _apiKey = apiKey;
        }

        public void GenerateAsync(LLMRequest request, Action<LLMResponse> callback)
        {
            if (!IsAvailable)
            {
                callback?.Invoke(LLMResponse.Error("Claude provider not configured"));
                return;
            }

            try
            {
                Log.Info($"[ClaudeProvider] 发送请求到 {_apiUrl}, 模型: {_model}");
                callback?.Invoke(LLMResponse.Error("HTTP请求需要Unity协程支持，当前为占位实现"));
            }
            catch (Exception ex)
            {
                callback?.Invoke(LLMResponse.Error($"请求失败: {ex.Message}"));
            }
        }

        public void TestConnection(Action<bool, string> callback)
        {
            if (!IsAvailable)
            {
                callback?.Invoke(false, "API Key未配置");
                return;
            }

            Log.Info("[ClaudeProvider] 测试连接...");
            callback?.Invoke(false, "HTTP请求需要Unity协程支持");
        }

        public void Cancel()
        {
            Log.Info("[ClaudeProvider] 取消请求");
        }
    }
}
