using System;
using EraOfWheel.Core;
using EraOfWheel.Core.Events;

namespace EraOfWheel.LLM
{
    /// <summary>
    /// API成本监控器
    /// </summary>
    public class CostMonitor : IModSystem
    {
        public static CostMonitor Instance { get; private set; }
        
        public string SystemName => "CostMonitor";
        public bool IsInitialized { get; private set; }

        private int _totalTokensUsed = 0;
        private int _sessionTokensUsed = 0;
        private int _requestCount = 0;
        private int _tokenLimit = 100000; // 默认限制
        private int _warningThreshold = 80; // 80%时警告
        private DateTime _sessionStart;

        public int TotalTokens => _totalTokensUsed;
        public int SessionTokens => _sessionTokensUsed;
        public int RequestCount => _requestCount;
        public float UsagePercent => _tokenLimit > 0 ? (float)_totalTokensUsed / _tokenLimit * 100f : 0f;

        public void Initialize()
        {
            if (IsInitialized) return;

            Instance = this;
            _sessionStart = DateTime.UtcNow;
            
            // 从配置加载限制
            var config = Core.Config.ConfigManager.Instance?.LLM;
            if (config != null)
            {
                // _tokenLimit = config.token_limit; // 如果配置支持
            }
            
            IsInitialized = true;
            Logger.Info(SystemName, $"API成本监控初始化 - 限制: {_tokenLimit} tokens");
        }

        /// <summary>
        /// 记录token使用
        /// </summary>
        public void RecordUsage(int inputTokens, int outputTokens)
        {
            var total = inputTokens + outputTokens;
            _totalTokensUsed += total;
            _sessionTokensUsed += total;
            _requestCount++;

            Logger.Debug(SystemName, $"Token使用: +{total} (总计: {_totalTokensUsed})");

            // 检查是否接近限制
            CheckLimit();
        }

        /// <summary>
        /// 估算并记录使用量
        /// </summary>
        public void EstimateAndRecord(string prompt, string response)
        {
            int inputTokens = EstimateTokens(prompt);
            int outputTokens = EstimateTokens(response);
            RecordUsage(inputTokens, outputTokens);
        }

        private int EstimateTokens(string text)
        {
            if (string.IsNullOrEmpty(text)) return 0;
            // 粗略估算：中文约1.5字符/token，英文约4字符/token
            return (int)(text.Length / 2f);
        }

        private void CheckLimit()
        {
            var percent = UsagePercent;
            
            if (percent >= 100)
            {
                Logger.Error(SystemName, "⚠️ 已达到token使用上限！");
                EventBus.Instance?.Publish(new TokenLimitReachedEvent(_totalTokensUsed, _tokenLimit));
            }
            else if (percent >= _warningThreshold)
            {
                Logger.Warn(SystemName, $"⚠️ Token使用已达{percent:F1}%");
                EventBus.Instance?.Publish(new TokenWarningEvent(_totalTokensUsed, _tokenLimit));
            }
        }

        /// <summary>
        /// 检查是否可以发送请求
        /// </summary>
        public bool CanSendRequest(int estimatedTokens = 500)
        {
            return (_totalTokensUsed + estimatedTokens) <= _tokenLimit;
        }

        /// <summary>
        /// 设置token限制
        /// </summary>
        public void SetLimit(int limit)
        {
            _tokenLimit = limit;
            Logger.Info(SystemName, $"Token限制设置为: {limit}");
        }

        /// <summary>
        /// 重置会话统计
        /// </summary>
        public void ResetSession()
        {
            _sessionTokensUsed = 0;
            _requestCount = 0;
            _sessionStart = DateTime.UtcNow;
        }

        /// <summary>
        /// 获取使用报告
        /// </summary>
        public CostReport GetReport()
        {
            return new CostReport
            {
                TotalTokens = _totalTokensUsed,
                SessionTokens = _sessionTokensUsed,
                RequestCount = _requestCount,
                TokenLimit = _tokenLimit,
                UsagePercent = UsagePercent,
                SessionDuration = DateTime.UtcNow - _sessionStart
            };
        }

        public void Dispose()
        {
            Instance = null;
            IsInitialized = false;
        }
    }

    public class CostReport
    {
        public int TotalTokens { get; set; }
        public int SessionTokens { get; set; }
        public int RequestCount { get; set; }
        public int TokenLimit { get; set; }
        public float UsagePercent { get; set; }
        public TimeSpan SessionDuration { get; set; }
    }

    public class TokenWarningEvent : GameEvent
    {
        public int CurrentUsage { get; }
        public int Limit { get; }
        public TokenWarningEvent(int usage, int limit) { CurrentUsage = usage; Limit = limit; }
    }

    public class TokenLimitReachedEvent : GameEvent
    {
        public int CurrentUsage { get; }
        public int Limit { get; }
        public TokenLimitReachedEvent(int usage, int limit) { CurrentUsage = usage; Limit = limit; }
    }
}
