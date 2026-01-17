using EraOfWheel.Core;
using EraOfWheel.Cycle;
using EraOfWheel.DemonLords;
using UnityEngine;
using UnityEngine.UI;

namespace EraOfWheel.UI
{
    /// <summary>
    /// 主控制面板
    /// </summary>
    public class MainControlPanel : BasePanel
    {
        public override string PanelId => "main";

        protected override void CreateUI()
        {
            Root = new GameObject("MainControlPanel");
            Root.transform.SetParent(Parent, false);
            
            var rect = Root.AddComponent<RectTransform>();
            rect.anchorMin = new Vector2(0, 1);
            rect.anchorMax = new Vector2(0, 1);
            rect.pivot = new Vector2(0, 1);
            rect.anchoredPosition = new Vector2(10, -10);
            rect.sizeDelta = new Vector2(200, 150);

            var bg = Root.AddComponent<Image>();
            bg.color = new Color(0.1f, 0.1f, 0.1f, 0.8f);

            CreateButton("轮回状态", () => UIManager.Instance?.TogglePanel("cycle"));
            CreateButton("魔王信息", () => UIManager.Instance?.TogglePanel("demon"));
            CreateButton("设置", () => UIManager.Instance?.TogglePanel("settings"));
            
            Hide();
        }

        private void CreateButton(string text, System.Action onClick)
        {
            // 简化的按钮创建
            Logger.Debug("UI", $"创建按钮: {text}");
        }
    }

    /// <summary>
    /// 轮回状态面板
    /// </summary>
    public class CycleStatusPanel : BasePanel
    {
        public override string PanelId => "cycle";
        private Text _phaseText;
        private Text _progressText;
        private Text _cycleText;

        protected override void CreateUI()
        {
            Root = new GameObject("CycleStatusPanel");
            Root.transform.SetParent(Parent, false);
            
            var rect = Root.AddComponent<RectTransform>();
            rect.anchorMin = new Vector2(1, 1);
            rect.anchorMax = new Vector2(1, 1);
            rect.pivot = new Vector2(1, 1);
            rect.anchoredPosition = new Vector2(-10, -10);
            rect.sizeDelta = new Vector2(250, 120);

            var bg = Root.AddComponent<Image>();
            bg.color = new Color(0.15f, 0.1f, 0.2f, 0.9f);
            
            Hide();
        }

        public void UpdateDisplay()
        {
            var state = CycleManager.Instance?.State;
            if (state == null) return;

            var phaseName = CyclePhaseConfig.GetPhaseName(state.currentPhase);
            Logger.Debug("UI", $"更新轮回面板: {phaseName} {state.ProgressPercent:F1}%");
        }
    }

    /// <summary>
    /// 魔王信息面板
    /// </summary>
    public class DemonLordPanel : BasePanel
    {
        public override string PanelId => "demon";

        protected override void CreateUI()
        {
            Root = new GameObject("DemonLordPanel");
            Root.transform.SetParent(Parent, false);
            
            var rect = Root.AddComponent<RectTransform>();
            rect.anchorMin = new Vector2(0.5f, 0.5f);
            rect.anchorMax = new Vector2(0.5f, 0.5f);
            rect.sizeDelta = new Vector2(400, 300);

            var bg = Root.AddComponent<Image>();
            bg.color = new Color(0.2f, 0.1f, 0.15f, 0.95f);
            
            Hide();
        }

        public void UpdateDisplay()
        {
            var demonLord = DemonLordFactory.Instance?.ActiveDemonLord;
            if (demonLord == null) return;

            Logger.Debug("UI", $"更新魔王面板: {demonLord.Name} 苏醒度:{demonLord.AwakeningLevel:F1}");
        }
    }

    /// <summary>
    /// 设置面板
    /// </summary>
    public class SettingsPanel : BasePanel
    {
        public override string PanelId => "settings";

        protected override void CreateUI()
        {
            Root = new GameObject("SettingsPanel");
            Root.transform.SetParent(Parent, false);
            
            var rect = Root.AddComponent<RectTransform>();
            rect.anchorMin = new Vector2(0.5f, 0.5f);
            rect.anchorMax = new Vector2(0.5f, 0.5f);
            rect.sizeDelta = new Vector2(500, 400);

            var bg = Root.AddComponent<Image>();
            bg.color = new Color(0.1f, 0.1f, 0.1f, 0.95f);
            
            Hide();
        }
    }
}
