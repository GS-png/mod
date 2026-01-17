using System;
using System.Collections.Generic;
using EraOfWheel.Core;
using EraOfWheel.Core.Config;
using EraOfWheel.Core.Data;

namespace EraOfWheel.UI
{
    /// <summary>
    /// 教程提示系统
    /// </summary>
    public class TutorialSystem : IModSystem
    {
        public static TutorialSystem Instance { get; private set; }
        
        public string SystemName => "TutorialSystem";
        public bool IsInitialized { get; private set; }

        private Dictionary<string, TutorialStep> _steps = new Dictionary<string, TutorialStep>();
        private HashSet<string> _completedSteps = new HashSet<string>();
        private bool _tutorialEnabled = true;

        public void Initialize()
        {
            if (IsInitialized) return;

            Instance = this;
            LoadTutorialSteps();
            LoadProgress();
            
            _tutorialEnabled = ConfigManager.Instance?.UI?.show_tutorial ?? true;
            
            IsInitialized = true;
            Logger.Info(SystemName, "教程系统初始化完成");
        }

        private void LoadTutorialSteps()
        {
            // 首次使用教程
            Register(new TutorialStep
            {
                Id = "welcome",
                Title = "欢迎来到纪元之轮",
                Content = "在这里，你将见证文明的兴衰轮回，对抗来自深渊的魔王。\n\n点击左上角的控制面板开始你的旅程。",
                TriggerCondition = "first_launch",
                Priority = 1
            });

            Register(new TutorialStep
            {
                Id = "cycle_intro",
                Title = "轮回系统",
                Content = "每个纪元都会经历五个阶段：\n萌芽 → 成长 → 鼎盛 → 衰落 → 灭绝\n\n轮回结束后，你将获得遗产点用于永久强化。",
                TriggerCondition = "cycle_started",
                Priority = 2
            });

            Register(new TutorialStep
            {
                Id = "demon_lord_intro",
                Title = "魔王威胁",
                Content = "魔王潜伏在封印之中，随着时间推移逐渐苏醒。\n\n注意观察苏醒度指示器，当魔王完全苏醒时将带来毁灭。",
                TriggerCondition = "awakening_started",
                Priority = 3
            });

            Register(new TutorialStep
            {
                Id = "oracle_intro",
                Title = "神谕系统",
                Content = "你可以向远古神谕寻求指引。\n\n点击神谕图标开始对话，获取关于轮回和魔王的神秘提示。",
                TriggerCondition = "oracle_unlocked",
                Priority = 4
            });

            Register(new TutorialStep
            {
                Id = "legacy_intro",
                Title = "遗产强化",
                Content = "遗产点可以兑换永久强化，这些强化将在所有轮回中生效。\n\n明智地选择你的强化路线！",
                TriggerCondition = "first_legacy",
                Priority = 5
            });
        }

        public void Register(TutorialStep step)
        {
            _steps[step.Id] = step;
        }

        /// <summary>
        /// 触发教程检查
        /// </summary>
        public void CheckTrigger(string condition)
        {
            if (!_tutorialEnabled) return;

            foreach (var step in _steps.Values)
            {
                if (step.TriggerCondition == condition && !_completedSteps.Contains(step.Id))
                {
                    ShowTutorial(step);
                    break;
                }
            }
        }

        /// <summary>
        /// 显示教程
        /// </summary>
        public void ShowTutorial(TutorialStep step)
        {
            Logger.Info(SystemName, $"显示教程: {step.Title}");
            
            NotificationSystem.Instance?.Show($"💡 {step.Title}", NotificationPriority.High);
            
            // TODO: 显示完整教程UI
        }

        /// <summary>
        /// 标记教程完成
        /// </summary>
        public void Complete(string stepId)
        {
            _completedSteps.Add(stepId);
            SaveProgress();
            Logger.Debug(SystemName, $"教程完成: {stepId}");
        }

        /// <summary>
        /// 跳过所有教程
        /// </summary>
        public void SkipAll()
        {
            foreach (var step in _steps.Keys)
            {
                _completedSteps.Add(step);
            }
            SaveProgress();
        }

        /// <summary>
        /// 重置教程进度
        /// </summary>
        public void Reset()
        {
            _completedSteps.Clear();
            SaveProgress();
        }

        /// <summary>
        /// 设置教程开关
        /// </summary>
        public void SetEnabled(bool enabled)
        {
            _tutorialEnabled = enabled;
        }

        private void LoadProgress()
        {
            // TODO: 从存档加载已完成的教程
        }

        private void SaveProgress()
        {
            // TODO: 保存教程进度
        }

        public void Dispose()
        {
            _steps.Clear();
            _completedSteps.Clear();
            Instance = null;
            IsInitialized = false;
        }
    }

    public class TutorialStep
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string TriggerCondition { get; set; }
        public int Priority { get; set; }
        public string HighlightElement { get; set; }
    }
}
