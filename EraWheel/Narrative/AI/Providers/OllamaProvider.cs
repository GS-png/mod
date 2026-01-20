using System;
using EraWheel.Core;

namespace EraWheel.Narrative.AI.Providers
{
    public class OllamaProvider : ILLMProvider
    {
        public string ProviderId => "ollama";
        public LLMProviderType ProviderType => LLMProviderType.Ollama;
        public bool IsAvailable => !string.IsNullOrEmpty(_apiUrl);

        private string _apiUrl = "http://localhost:11434/api/generate";
        private string _model = "llama2";
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
                callback?.Invoke(LLMResponse.Error("Ollama provider not configured"));
                return;
            }

            try
            {
                Log.Info($"[OllamaProvider] 发送请求到 {_apiUrl}, 模型: {_model}");
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
                callback?.Invoke(false, "Ollama URL未配置");
                return;
            }

            Log.Info("[OllamaProvider] 测试连接...");
            callback?.Invoke(false, "HTTP请求需要Unity协程支持");
        }

        public void Cancel()
        {
            Log.Info("[OllamaProvider] 取消请求");
        }
    }
}
