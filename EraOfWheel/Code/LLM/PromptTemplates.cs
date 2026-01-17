using System.Collections.Generic;
using System.Text.RegularExpressions;
using EraOfWheel.Core;

namespace EraOfWheel.LLM
{
    /// <summary>
    /// Prompt模板系统
    /// </summary>
    public class PromptTemplates : IModSystem
    {
        public static PromptTemplates Instance { get; private set; }
        
        public string SystemName => "PromptTemplates";
        public bool IsInitialized { get; private set; }

        private Dictionary<string, PromptTemplate> _templates = new Dictionary<string, PromptTemplate>();

        public void Initialize()
        {
            if (IsInitialized) return;

            Instance = this;
            LoadDefaultTemplates();
            
            IsInitialized = true;
            Logger.Info(SystemName, $"Prompt模板系统初始化 - {_templates.Count}个模板");
        }

        private void LoadDefaultTemplates()
        {
            // 系统提示
            Register("system_narrator", new PromptTemplate
            {
                Id = "system_narrator",
                Name = "叙事者系统提示",
                Content = @"你是一个奇幻世界的叙事者，为《纪元之轮》游戏生成富有戏剧性的事件。

当前纪元：{{cycle_phase}}
当前轮回：第{{cycle_number}}轮
活跃魔王：{{demon_lord_name}}

规则：
1. 保持简短（不超过100字）
2. 使用史诗般的语言
3. 与轮回和魔王主题相关"
            });

            // 事件生成
            Register("event_generation", new PromptTemplate
            {
                Id = "event_generation",
                Name = "事件生成",
                Content = @"根据以下情境生成一个游戏事件：

情境：{{context}}
纪元阶段：{{cycle_phase}}
文明状态：{{civilization_status}}

请用中文回复，格式：
标题：[事件标题]
描述：[事件描述]
影响：[对游戏的影响]"
            });

            // 魔王对话
            Register("demon_lord_dialog", new PromptTemplate
            {
                Id = "demon_lord_dialog",
                Name = "魔王对话",
                Content = @"你现在扮演{{demon_lord_name}}，{{demon_lord_title}}。

魔王描述：{{demon_lord_description}}
当前苏醒度：{{awakening_level}}%
玩家行动：{{player_action}}

以魔王的口吻回应玩家，保持威胁感和神秘感。回复不超过50字。"
            });

            // 神谕对话
            Register("oracle_dialog", new PromptTemplate
            {
                Id = "oracle_dialog",
                Name = "神谕对话",
                Content = @"你是远古的神谕，守望着无尽的轮回。

玩家问题：{{player_question}}
当前轮回信息：第{{cycle_number}}轮，{{cycle_phase}}阶段
遗产点：{{legacy_points}}

以神秘而智慧的口吻回答，可以给出隐晦的提示但不能直接透露答案。"
            });

            // 轮回总结
            Register("cycle_summary", new PromptTemplate
            {
                Id = "cycle_summary",
                Name = "轮回总结",
                Content = @"总结本轮回的历程：

轮回编号：{{cycle_number}}
持续时间：{{cycle_duration}}
最高阶段：{{max_phase}}
魔王：{{demon_lord_name}}
结局：{{ending_type}}

生成一段史诗般的总结，100字以内。"
            });
        }

        public void Register(string id, PromptTemplate template)
        {
            _templates[id] = template;
        }

        public PromptTemplate Get(string id)
        {
            return _templates.TryGetValue(id, out var template) ? template : null;
        }

        /// <summary>
        /// 渲染模板，替换变量
        /// </summary>
        public string Render(string templateId, Dictionary<string, string> variables)
        {
            var template = Get(templateId);
            if (template == null)
            {
                Logger.Warn(SystemName, $"模板不存在: {templateId}");
                return null;
            }

            var result = template.Content;
            
            foreach (var kvp in variables)
            {
                result = result.Replace("{{" + kvp.Key + "}}", kvp.Value);
            }

            // 清理未替换的变量
            result = Regex.Replace(result, @"\{\{[^}]+\}\}", "[未知]");

            return result;
        }

        public void Dispose()
        {
            _templates.Clear();
            Instance = null;
            IsInitialized = false;
        }
    }

    public class PromptTemplate
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Language { get; set; } = "zh-CN";
    }
}
