using System;
using System.Collections;
using System.Text;
using EraOfWheel.Core;
using EraOfWheel.Core.Config;
using UnityEngine;
using UnityEngine.Networking;

namespace EraOfWheel.LLM
{
    /// <summary>
    /// LLM API客户端
    /// </summary>
    public class LLMClient : IModSystem
    {
        public static LLMClient Instance { get; private set; }
        
        public string SystemName => "LLMClient";
        public bool IsInitialized { get; private set; }

        private LLMConfig _config;

        public void Initialize()
        {
            if (IsInitialized) return;

            Instance = this;
            _config = ConfigManager.Instance?.LLM ?? new LLMConfig();
            
            IsInitialized = true;
            Logger.Info(SystemName, $"LLM客户端初始化 - Model: {_config.model}");
        }

        /// <summary>
        /// 发送请求到LLM API
        /// </summary>
        public IEnumerator SendRequest(LLMRequest request, Action<LLMResponse> callback)
        {
            if (string.IsNullOrEmpty(_config.api_key))
            {
                Logger.Warn(SystemName, "API密钥未配置，使用后备事件池");
                callback?.Invoke(new LLMResponse { Success = false, Error = "API key not configured" });
                yield break;
            }

            var jsonBody = BuildRequestBody(request);
            var url = $"{_config.api_base_url}/chat/completions";

            using (var webRequest = new UnityWebRequest(url, "POST"))
            {
                byte[] bodyRaw = Encoding.UTF8.GetBytes(jsonBody);
                webRequest.uploadHandler = new UploadHandlerRaw(bodyRaw);
                webRequest.downloadHandler = new DownloadHandlerBuffer();
                webRequest.SetRequestHeader("Content-Type", "application/json");
                webRequest.SetRequestHeader("Authorization", $"Bearer {_config.api_key}");
                webRequest.timeout = _config.timeout_seconds;

                Logger.Debug(SystemName, $"发送LLM请求: {request.Prompt.Substring(0, Math.Min(50, request.Prompt.Length))}...");

                yield return webRequest.SendWebRequest();

                if (webRequest.result == UnityWebRequest.Result.Success)
                {
                    var response = ParseResponse(webRequest.downloadHandler.text);
                    response.Success = true;
                    callback?.Invoke(response);
                }
                else
                {
                    Logger.Error(SystemName, $"LLM请求失败: {webRequest.error}");
                    callback?.Invoke(new LLMResponse 
                    { 
                        Success = false, 
                        Error = webRequest.error 
                    });
                }
            }
        }

        private string BuildRequestBody(LLMRequest request)
        {
            return $@"{{
                ""model"": ""{_config.model}"",
                ""messages"": [
                    {{""role"": ""system"", ""content"": ""{EscapeJson(request.SystemPrompt)}""}},
                    {{""role"": ""user"", ""content"": ""{EscapeJson(request.Prompt)}""}}
                ],
                ""temperature"": {request.Temperature},
                ""max_tokens"": {request.MaxTokens}
            }}";
        }

        private LLMResponse ParseResponse(string json)
        {
            try
            {
                // 简化解析，实际项目应使用JSON库
                var contentStart = json.IndexOf("\"content\":\"") + 11;
                var contentEnd = json.IndexOf("\"", contentStart);
                var content = json.Substring(contentStart, contentEnd - contentStart);
                
                return new LLMResponse
                {
                    Content = content.Replace("\\n", "\n").Replace("\\\"", "\""),
                    Success = true
                };
            }
            catch (Exception ex)
            {
                return new LLMResponse { Success = false, Error = ex.Message };
            }
        }

        private string EscapeJson(string text)
        {
            return text?.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n") ?? "";
        }

        public void Dispose()
        {
            Instance = null;
            IsInitialized = false;
        }
    }

    public class LLMRequest
    {
        public string SystemPrompt { get; set; } = "You are a game master for a fantasy world simulation.";
        public string Prompt { get; set; }
        public float Temperature { get; set; } = 0.7f;
        public int MaxTokens { get; set; } = 500;
    }

    public class LLMResponse
    {
        public bool Success { get; set; }
        public string Content { get; set; }
        public string Error { get; set; }
    }
}
