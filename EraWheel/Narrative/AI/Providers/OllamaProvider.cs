using System;
using System.Globalization;
using System.Text;

namespace EraWheel.Narrative.AI.Providers
{
    public class OllamaProvider : HttpProviderBase
    {
        public override string ProviderId => "ollama";
        public override LLMProviderType ProviderType => LLMProviderType.Ollama;
        public override bool IsAvailable => !string.IsNullOrEmpty(ApiUrl);

        protected override string DefaultApiUrl => "http://localhost:11434/api/generate";
        protected override string DefaultModel => "llama2";

        protected override string BuildRequestJson(LLMRequest request)
        {
            var sb = new StringBuilder(512);
            sb.Append('{');
            sb.Append("\"model\":\"").Append(JsonText.Escape(Model)).Append('"');
            sb.Append(",\"prompt\":\"").Append(JsonText.Escape(request.Prompt)).Append('"');
            sb.Append(",\"stream\":false");

            if (!string.IsNullOrEmpty(request.SystemPrompt))
            {
                sb.Append(",\"system\":\"").Append(JsonText.Escape(request.SystemPrompt)).Append('"');
            }

            sb.Append(",\"options\":{");
            sb.Append("\"temperature\":").Append(request.Temperature.ToString(CultureInfo.InvariantCulture));
            sb.Append(",\"num_predict\":").Append(Math.Max(1, request.MaxTokens));

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

            sb.Append("}}");
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

            JsonText.TryExtractString(json, "response", out content);
            JsonText.TryExtractInt(json, "eval_count", out tokensUsed);

            if (string.IsNullOrEmpty(content))
            {
                errorMessage = ExtractErrorMessage(json);
                return false;
            }

            return true;
        }
    }
}
