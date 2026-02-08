using System;
using System.Globalization;
using System.Text;

namespace EraWheel.Narrative.AI.Providers
{
    public class OpenAIProvider : HttpProviderBase
    {
        public override string ProviderId => "openai";
        public override LLMProviderType ProviderType => LLMProviderType.OpenAI;
        public override bool IsAvailable => !string.IsNullOrEmpty(ApiKey) && !string.IsNullOrEmpty(ApiUrl);

        protected override string DefaultApiUrl => "https://api.openai.com/v1/chat/completions";
        protected override string DefaultModel => "gpt-4";

        protected override void AddRequestHeaders(System.Collections.Generic.Dictionary<string, string> headers)
        {
            if (!string.IsNullOrEmpty(ApiKey))
            {
                headers["Authorization"] = "Bearer " + ApiKey;
            }
        }

        protected override string BuildRequestJson(LLMRequest request)
        {
            var sb = new StringBuilder(512);
            sb.Append('{');
            sb.Append("\"model\":\"").Append(JsonText.Escape(Model)).Append('"');
            sb.Append(",\"messages\":[");

            var hasSystem = !string.IsNullOrEmpty(request.SystemPrompt);
            if (hasSystem)
            {
                sb.Append("{\"role\":\"system\",\"content\":\"")
                    .Append(JsonText.Escape(request.SystemPrompt))
                    .Append("\"},");
            }

            sb.Append("{\"role\":\"user\",\"content\":\"")
                .Append(JsonText.Escape(request.Prompt))
                .Append("\"}]");

            sb.Append(",\"max_tokens\":").Append(Math.Max(1, request.MaxTokens));
            sb.Append(",\"temperature\":").Append(request.Temperature.ToString(CultureInfo.InvariantCulture));

            if (request.StopSequences != null && request.StopSequences.Length > 0)
            {
                sb.Append(",\"stop\":[");
                for (var i = 0; i < request.StopSequences.Length; i++)
                {
                    if (i > 0) sb.Append(',');
                    sb.Append('"').Append(JsonText.Escape(request.StopSequences[i])).Append('"');
                }
                sb.Append(']');
            }

            sb.Append('}');
            return sb.ToString();
        }

        protected override bool TryParseResponse(string json, out string content, out int tokensUsed, out string errorMessage)
        {
            content = null;
            tokensUsed = 0;
            errorMessage = null;

            if (string.IsNullOrEmpty(json))
            {
                errorMessage = "Empty response";
                return false;
            }

            if (!JsonText.TryExtractString(json, "content", out content))
            {
                JsonText.TryExtractString(json, "text", out content);
            }

            if (JsonText.TryExtractInt(json, "total_tokens", out var totalTokens))
            {
                tokensUsed = totalTokens;
            }

            if (string.IsNullOrEmpty(content))
            {
                errorMessage = ExtractErrorMessage(json);
                return false;
            }

            return true;
        }
    }
}
