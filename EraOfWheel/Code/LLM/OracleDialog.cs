using System;
using System.Collections;
using System.Collections.Generic;
using EraOfWheel.Core;
using EraOfWheel.Core.Events;
using EraOfWheel.Cycle;

namespace EraOfWheel.LLM
{
    /// <summary>
    /// 神谕对话系统 - 玩家与AI的直接交互
    /// </summary>
    public class OracleDialog : IModSystem
    {
        public static OracleDialog Instance { get; private set; }
        
        public string SystemName => "OracleDialog";
        public bool IsInitialized { get; private set; }

        private List<DialogEntry> _dialogHistory = new List<DialogEntry>();
        private bool _isWaitingResponse = false;

        public bool IsWaiting => _isWaitingResponse;
        public IReadOnlyList<DialogEntry> History => _dialogHistory;

        public void Initialize()
        {
            if (IsInitialized) return;

            Instance = this;
            
            IsInitialized = true;
            Logger.Info(SystemName, "神谕对话系统初始化完成");
        }

        /// <summary>
        /// 发送消息给神谕
        /// </summary>
        public void SendMessage(string message, Action<string> callback)
        {
            if (_isWaitingResponse)
            {
                Logger.Warn(SystemName, "正在等待神谕回应...");
                return;
            }

            // 记录玩家消息
            _dialogHistory.Add(new DialogEntry
            {
                Role = "player",
                Content = message,
                Timestamp = DateTime.UtcNow
            });

            ContextManager.Instance?.AddUserMessage(message);

            _isWaitingResponse = true;
            
            // 构建prompt
            var variables = new Dictionary<string, string>
            {
                {"player_question", message},
                {"cycle_number", CycleManager.Instance?.State?.cycleNumber.ToString() ?? "1"},
                {"cycle_phase", CycleManager.Instance?.State?.currentPhase.ToString() ?? "未知"},
                {"legacy_points", LegacySystem.Instance?.TotalPoints.ToString() ?? "0"}
            };

            var prompt = PromptTemplates.Instance?.Render("oracle_dialog", variables) ?? message;

            var request = new LLMRequest
            {
                SystemPrompt = "你是远古的神谕，守望着无尽的轮回。用神秘而智慧的口吻回答。",
                Prompt = prompt,
                Temperature = 0.8f,
                MaxTokens = 150
            };

            RequestQueue.Instance?.Enqueue(request, response =>
            {
                _isWaitingResponse = false;
                
                string reply;
                if (response.Success)
                {
                    reply = response.Content;
                }
                else
                {
                    reply = GetFallbackResponse();
                }

                _dialogHistory.Add(new DialogEntry
                {
                    Role = "oracle",
                    Content = reply,
                    Timestamp = DateTime.UtcNow
                });

                ContextManager.Instance?.AddAssistantMessage(reply);
                
                callback?.Invoke(reply);
                EventBus.Instance?.Publish(new OracleResponseEvent(reply));
            }, RequestPriority.High);
        }

        /// <summary>
        /// 快捷指令
        /// </summary>
        public void ExecuteCommand(string command)
        {
            switch (command.ToLower())
            {
                case "/status":
                    SendMessage("告诉我当前轮回的状态", null);
                    break;
                case "/demon":
                    SendMessage("告诉我关于当前魔王的信息", null);
                    break;
                case "/help":
                    ShowHelp();
                    break;
                case "/clear":
                    ClearHistory();
                    break;
                default:
                    Logger.Warn(SystemName, $"未知指令: {command}");
                    break;
            }
        }

        private string GetFallbackResponse()
        {
            var responses = new[]
            {
                "轮回的奥秘...难以言说...",
                "命运的织线纠缠，真相隐于其中...",
                "远古的智慧低语着答案，但你需自己领悟...",
                "时间之河流淌，一切终将显现..."
            };
            return responses[UnityEngine.Random.Range(0, responses.Length)];
        }

        private void ShowHelp()
        {
            var help = @"可用指令：
/status - 查看轮回状态
/demon - 查看魔王信息
/help - 显示帮助
/clear - 清空对话历史";
            
            _dialogHistory.Add(new DialogEntry
            {
                Role = "system",
                Content = help,
                Timestamp = DateTime.UtcNow
            });
        }

        public void ClearHistory()
        {
            _dialogHistory.Clear();
            ContextManager.Instance?.Clear();
            Logger.Info(SystemName, "对话历史已清空");
        }

        public void Dispose()
        {
            ClearHistory();
            Instance = null;
            IsInitialized = false;
        }
    }

    public class DialogEntry
    {
        public string Role { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
    }

    public class OracleResponseEvent : GameEvent
    {
        public string Response { get; }
        public OracleResponseEvent(string response) => Response = response;
    }
}
