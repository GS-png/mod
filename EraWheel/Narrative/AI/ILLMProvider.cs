using System;

namespace EraWheel.Narrative.AI
{
    public enum LLMProviderType
    {
        OpenAI,
        Claude,
        Ollama,
        Custom
    }

    public interface ILLMProvider
    {
        string ProviderId { get; }
        LLMProviderType ProviderType { get; }
        bool IsAvailable { get; }

        void Configure(string apiUrl, string model, string apiKey);

        void GenerateAsync(LLMRequest request, Action<LLMResponse> callback);

        void TestConnection(Action<bool, string> callback);

        void Cancel();
    }

    [Serializable]
    public class LLMRequest
    {
        public string Prompt;
        public string SystemPrompt;
        public int MaxTokens = 500;
        public float Temperature = 0.7f;
        public string[] StopSequences;

        public WorldContext Context;
        public string RequestType;
    }

    [Serializable]
    public class LLMResponse
    {
        public bool Success;
        public string Content;
        public string ErrorMessage;
        public int TokensUsed;
        public float ResponseTimeMs;

        public static LLMResponse Error(string message)
        {
            return new LLMResponse
            {
                Success = false,
                ErrorMessage = message
            };
        }

        public static LLMResponse Ok(string content, int tokens = 0, float timeMs = 0)
        {
            return new LLMResponse
            {
                Success = true,
                Content = content,
                TokensUsed = tokens,
                ResponseTimeMs = timeMs
            };
        }
    }
}
