using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace EraWheel.Narrative.AI.Providers
{
    public abstract class HttpProviderBase : ILLMProvider
    {
        private static readonly HttpClient Client;

        private CancellationTokenSource _cts;
        private string _apiUrl;
        private string _model;
        private string _apiKey;

        static HttpProviderBase()
        {
            try
            {
                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
            }
            catch
            {
            }

            Client = new HttpClient
            {
                Timeout = Timeout.InfiniteTimeSpan
            };
        }

        public abstract string ProviderId { get; }
        public abstract LLMProviderType ProviderType { get; }
        public abstract bool IsAvailable { get; }

        protected string ApiUrl => _apiUrl;
        protected string Model => _model;
        protected string ApiKey => _apiKey;

        protected virtual string DefaultApiUrl => "";
        protected virtual string DefaultModel => "";

        public void Configure(string apiUrl, string model, string apiKey)
        {
            _apiUrl = !string.IsNullOrEmpty(apiUrl) ? apiUrl : DefaultApiUrl;
            _model = !string.IsNullOrEmpty(model) ? model : DefaultModel;
            _apiKey = apiKey ?? "";
        }

        public void GenerateAsync(LLMRequest request, Action<LLMResponse> callback)
        {
            if (request == null)
            {
                callback?.Invoke(LLMResponse.Error("Empty request"));
                return;
            }

            if (!IsAvailable)
            {
                callback?.Invoke(LLMResponse.Error("Provider not configured"));
                return;
            }

            Cancel();

            var timeoutSeconds = request.TimeoutSeconds > 0 ? request.TimeoutSeconds : 30;
            _cts = new CancellationTokenSource(TimeSpan.FromSeconds(timeoutSeconds));
            var token = _cts.Token;

            var payload = BuildRequestJson(request);
            var headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            AddRequestHeaders(headers);

            var watch = Stopwatch.StartNew();
            Task.Run(async () =>
            {
                try
                {
                    using (var message = new HttpRequestMessage(HttpMethod.Post, ApiUrl))
                    {
                        message.Content = new StringContent(payload ?? "{}", Encoding.UTF8, "application/json");
                        foreach (var kv in headers)
                        {
                            message.Headers.TryAddWithoutValidation(kv.Key, kv.Value);
                        }

                        var response = await Client.SendAsync(message, token).ConfigureAwait(false);
                        var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        watch.Stop();

                        if (!response.IsSuccessStatusCode)
                        {
                            var error = ExtractErrorMessage(body);
                            callback?.Invoke(LLMResponse.Error($"HTTP {(int)response.StatusCode} {response.StatusCode}: {error}"));
                            return;
                        }

                        if (TryParseResponse(body, out var content, out var tokens, out var errorMessage))
                        {
                            callback?.Invoke(LLMResponse.Ok(content ?? "", tokens, (float)watch.Elapsed.TotalMilliseconds));
                            return;
                        }

                        callback?.Invoke(LLMResponse.Error(string.IsNullOrEmpty(errorMessage) ? "Response parse failed" : errorMessage));
                    }
                }
                catch (TaskCanceledException ex)
                {
                    var msg = ex.InnerException is TimeoutException ? "Request timed out" : "Request canceled";
                    callback?.Invoke(LLMResponse.Error(msg));
                }
                catch (Exception ex)
                {
                    callback?.Invoke(LLMResponse.Error(ex.Message));
                }
            });
        }

        public void TestConnection(Action<bool, string> callback)
        {
            var request = new LLMRequest
            {
                Prompt = BuildTestPrompt(),
                SystemPrompt = "",
                MaxTokens = 4,
                TimeoutSeconds = 10,
                Temperature = 0.2f
            };

            GenerateAsync(request, response =>
            {
                if (response.Success)
                {
                    callback?.Invoke(true, "OK");
                }
                else
                {
                    callback?.Invoke(false, response.ErrorMessage ?? "Failed");
                }
            });
        }

        public void Cancel()
        {
            if (_cts == null) return;

            try
            {
                _cts.Cancel();
            }
            catch
            {
            }
            finally
            {
                _cts.Dispose();
                _cts = null;
            }
        }

        protected virtual string BuildTestPrompt()
        {
            return "ping";
        }

        protected abstract string BuildRequestJson(LLMRequest request);

        protected abstract bool TryParseResponse(string json, out string content, out int tokensUsed, out string errorMessage);

        protected virtual void AddRequestHeaders(Dictionary<string, string> headers)
        {
        }

        protected virtual string ExtractErrorMessage(string json)
        {
            if (!string.IsNullOrEmpty(json) && JsonText.TryExtractString(json, "message", out var msg))
            {
                return msg;
            }

            return string.IsNullOrEmpty(json) ? "Unknown error" : json;
        }
    }
}
