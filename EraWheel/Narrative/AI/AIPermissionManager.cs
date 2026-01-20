using System;
using EraWheel.Core;

namespace EraWheel.Narrative.AI
{
    public enum AIPermissionLevel
    {
        Observer = 1,
        Recorder = 2,
        Narrator = 3,
        Playwright = 4,
        Creator = 5
    }

    public class AIPermissionManager
    {
        public AIPermissionLevel CurrentLevel { get; private set; } = AIPermissionLevel.Recorder;

        public bool CanRead => CurrentLevel >= AIPermissionLevel.Observer;
        public bool CanLog => CurrentLevel >= AIPermissionLevel.Recorder;
        public bool CanNarrate => CurrentLevel >= AIPermissionLevel.Narrator;
        public bool CanModifyEvents => CurrentLevel >= AIPermissionLevel.Playwright;
        public bool CanModifyWorld => CurrentLevel >= AIPermissionLevel.Creator;

        public event Action<AIPermissionLevel> OnLevelChanged;

        public void SetLevel(int level)
        {
            if (level < 1) level = 1;
            if (level > 5) level = 5;
            SetLevel((AIPermissionLevel)level);
        }

        public void SetLevel(AIPermissionLevel level)
        {
            if (level == CurrentLevel) return;

            var prev = CurrentLevel;
            CurrentLevel = level;

            Log.Info($"[AIPermissionManager] 权限等级变更: {prev} -> {level}");

            try
            {
                OnLevelChanged?.Invoke(level);
            }
            catch
            {
            }
        }

        public bool CheckPermission(AIPermissionLevel required)
        {
            return CurrentLevel >= required;
        }

        public bool RequestPermission(AIPermissionLevel required, string operationDesc)
        {
            if (CurrentLevel >= required)
            {
                Log.Info($"[AIPermissionManager] 权限检查通过: {operationDesc}");
                return true;
            }

            Log.Warning($"[AIPermissionManager] 权限不足: {operationDesc} 需要 {required}，当前 {CurrentLevel}");
            return false;
        }

        public string GetLevelName(AIPermissionLevel level)
        {
            switch (level)
            {
                case AIPermissionLevel.Observer: return "观察者";
                case AIPermissionLevel.Recorder: return "记录者";
                case AIPermissionLevel.Narrator: return "叙事者";
                case AIPermissionLevel.Playwright: return "编剧";
                case AIPermissionLevel.Creator: return "造物主";
                default: return "未知";
            }
        }

        public string GetLevelDescription(AIPermissionLevel level)
        {
            switch (level)
            {
                case AIPermissionLevel.Observer:
                    return "仅可读取世界状态，无法产生任何影响";
                case AIPermissionLevel.Recorder:
                    return "可记录事件日志，增强叙事描述";
                case AIPermissionLevel.Narrator:
                    return "可触发叙事事件，显示通知";
                case AIPermissionLevel.Playwright:
                    return "可创建和修改事件，影响故事走向";
                case AIPermissionLevel.Creator:
                    return "完全控制权，可修改世界状态（需确认）";
                default:
                    return "";
            }
        }
    }
}
