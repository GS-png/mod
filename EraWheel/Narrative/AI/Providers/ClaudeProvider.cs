using System;
using System.Globalization;
using System.Text;

namespace EraWheel.Narrative.AI.Providers
{
    public class ClaudeProvider : HttpProviderBase
    {
        public override string ProviderId => "claude";
        public override LLMProviderType ProviderType => LLMProviderType.Claude;
        public override bool IsAvailable => !string.IsNullOrEmpty(ApiKey) && !string.IsNullOrEmpty(ApiUrl);

        protected override string DefaultApiUrl => "https://api.anthropic.com/v1/messages";
        protected override string DefaultModel => "claude-3-opus-20240229";

        protected override void AddRequestHeaders(System.Collections.Generic.Dictionary<string, string> headers)
        {
            if (!string.IsNullOrEmpty(ApiKey))
            {
                headers["x-api-key"] = ApiKey;
            }
            headers["anthropic-version"] = "2023-06-01";
        }

        protected override string BuildRequestJson(LLMRequest request)
        {
            var sb = new StringBuilder(512);
            sb.Append('{');
            sb.Append("\"model\":\"").Append(JsonText.Escape(Model)).Append('"');
            sb.Append(",\"max_tokens\":").Append(Math.Max(1, request.MaxTokens));
            sb.Append(",\"temperature\":").Append(request.Temperature.ToString(CultureInfo.InvariantCulture));

            if (!string.IsNullOrEmpty(request.SystemPrompt))
            {
                sb.Append(",\"system\":\"").Append(JsonText.Escape(request.SystemPrompt)).Append('"');
            }

            sb.Append(",\"messages\":[{\"role\":\"user\",\"content\":\"")
                .Append(JsonText.Escape(request.Prompt))
                .Append("\"}]");

            if (request.StopSequences != null && request.StopSequences.Length > 0)
            {
                sb.Append(",\"stop_sequences\":[");
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

            JsonText.TryExtractString(json, "text", out content);

            if (JsonText.TryExtractInt(json, "output_tokens", out var outTokens))
            {
                tokensUsed = outTokens;
            }
            else if (JsonText.TryExtractInt(json, "input_tokens", out var inTokens))
            {
                tokensUsed = inTokens;
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
