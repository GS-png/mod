using System;
using System.Collections.Generic;
using System.Text;
using EraOfWheel.Core;

namespace EraOfWheel.LLM
{
    /// <summary>
    /// 上下文管理器 - 维护对话历史
    /// </summary>
    public class ContextManager : IModSystem
    {
        public static ContextManager Instance { get; private set; }
        
        public string SystemName => "ContextManager";
        public bool IsInitialized { get; private set; }

        private List<ContextMessage> _history = new List<ContextMessage>();
        private int _maxMessages = 10;
        private int _maxTokens = 2000;
        private int _currentTokens = 0;

        public void Initialize()
        {
            if (IsInitialized) return;

            Instance = this;
            
            IsInitialized = true;
            Logger.Info(SystemName, "上下文管理器初始化完成");
        }

        /// <summary>
        /// 添加消息到上下文
        /// </summary>
        public void AddMessage(string role, string content, int importance = 1)
        {
            var msg = new ContextMessage
            {
                Role = role,
                Content = content,
                Timestamp = DateTime.UtcNow,
                Importance = importance,
                TokenCount = EstimateTokens(content)
            };

            _history.Add(msg);
            _currentTokens += msg.TokenCount;

            // 超出限制时压缩
            if (_history.Count > _maxMessages || _currentTokens > _maxTokens)
            {
                Compress();
            }
        }

        /// <summary>
        /// 添加用户消息
        /// </summary>
        public void AddUserMessage(string content)
        {
            AddMessage("user", content, 2);
        }

        /// <summary>
        /// 添加助手消息
        /// </summary>
        public void AddAssistantMessage(string content)
        {
            AddMessage("assistant", content, 1);
        }

        /// <summary>
        /// 获取上下文字符串
        /// </summary>
        public string GetContextString()
        {
            var sb = new StringBuilder();
            
            foreach (var msg in _history)
            {
                sb.AppendLine($"[{msg.Role}]: {msg.Content}");
            }

            return sb.ToString();
        }

        /// <summary>
        /// 获取消息列表
        /// </summary>
        public List<ContextMessage> GetMessages()
        {
            return new List<ContextMessage>(_history);
        }

        /// <summary>
        /// 压缩上下文
        /// </summary>
        private void Compress()
        {
            if (_history.Count <= 2) return;

            // 按重要性排序，保留最重要的消息
            _history.Sort((a, b) => b.Importance.CompareTo(a.Importance));

            // 移除最不重要的消息
            while (_history.Count > _maxMessages / 2 || _currentTokens > _maxTokens * 0.7)
            {
                if (_history.Count <= 2) break;
                
                var removed = _history[_history.Count - 1];
                _currentTokens -= removed.TokenCount;
                _history.RemoveAt(_history.Count - 1);
            }

            // 按时间重新排序
            _history.Sort((a, b) => a.Timestamp.CompareTo(b.Timestamp));

            Logger.Debug(SystemName, $"上下文压缩: 剩余{_history.Count}条消息, {_currentTokens}tokens");
        }

        /// <summary>
        /// 估算token数量
        /// </summary>
        private int EstimateTokens(string text)
        {
            // 简化估算：中文约1.5字符/token
            return (int)(text.Length / 1.5f);
        }

        /// <summary>
        /// 清空上下文
        /// </summary>
        public void Clear()
        {
            _history.Clear();
            _currentTokens = 0;
        }

        public void Dispose()
        {
            Clear();
            Instance = null;
            IsInitialized = false;
        }
    }

    public class ContextMessage
    {
        public string Role { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public int Importance { get; set; }
        public int TokenCount { get; set; }
    }
}
