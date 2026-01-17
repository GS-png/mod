using System.Text;
using UnityEngine;
using EraOfWheel.Core;
using EraOfWheel.Core.Config;
using EraOfWheel.Cycle;
using EraOfWheel.DemonLords;
using Logger = EraOfWheel.Core.Logger;

namespace EraOfWheel.UI.Panels
{
    public class OverviewPanel : IModSystem
    {
        public static OverviewPanel Instance { get; private set; }
        
        public string SystemName => "OverviewPanel";
        public bool IsInitialized { get; private set; }
        
        private GameObject _panelRoot;
        private bool _isVisible = false;

        public void Initialize()
        {
            if (IsInitialized) return;
            
            Instance = this;
            CreatePanel();
            
            IsInitialized = true;
            Logger.Info(SystemName, "OverviewPanel initialized");
        }

        private void CreatePanel()
        {
            // Note: Full implementation would create NeoModLoader UI elements
            // For now, we prepare the data structure
            Logger.Debug(SystemName, "Overview panel created (placeholder)");
        }

        public void Show()
        {
            _isVisible = true;
            if (_panelRoot != null)
            {
                _panelRoot.SetActive(true);
            }
            Refresh();
        }

        public void Hide()
        {
            _isVisible = false;
            if (_panelRoot != null)
            {
                _panelRoot.SetActive(false);
            }
        }

        public void Refresh()
        {
            if (!_isVisible) return;
            
            var data = GetOverviewData();
            UpdateDisplay(data);
        }

        public OverviewData GetOverviewData()
        {
            var cycleState = CycleManager.Instance?.State;
            var activeDemon = DemonLordManager.Instance?.ActiveDemonLord;
            var legacySystem = LegacySystem.Instance;
            
            return new OverviewData
            {
                CurrentCycle = cycleState?.CycleCount ?? 1,
                WorldAge = cycleState?.WorldAgeYears ?? 0,
                CurrentPhase = cycleState?.CurrentPhase.ToDisplayName() ?? "未知",
                PhaseRaw = cycleState?.CurrentPhase.ToString() ?? "Sealed",
                
                ActiveDemonName = activeDemon?.Name ?? "无",
                ActiveDemonState = activeDemon?.State.ToDisplayName() ?? "封印中",
                DemonHealthPercent = activeDemon?.Stats?.HealthPercent ?? 0f,
                SealStrength = activeDemon?.SealStrength ?? 100f,
                
                SealWarActive = SealSystem.Instance?.SealWarWindowActive ?? false,
                RitualProgress = SealSystem.Instance?.RitualProgress ?? 0f,
                
                MilitaryBonus = legacySystem?.TotalMilitaryBonus ?? 0f,
                EconomicBonus = legacySystem?.TotalEconomicBonus ?? 0f,
                TechBonus = legacySystem?.TotalTechBonus ?? 0f,
                
                EnabledDemonCount = CountEnabledDemons(),
                LegionWaveCount = DemonLords.Legion.LegionManager.Instance?.CurrentWaveNumber ?? 0
            };
        }

        private int CountEnabledDemons()
        {
            int count = 0;
            var demons = DemonLordManager.Instance?.AllDemonLords;
            if (demons == null) return 0;
            
            foreach (var demon in demons)
            {
                if (demon.IsEnabled) count++;
            }
            return count;
        }

        private void UpdateDisplay(OverviewData data)
        {
            // Note: Full implementation would update UI elements
            // For now, log the data for debugging
            if (ConfigManager.Instance?.Config?.core?.debug_mode == true)
            {
                Logger.Debug(SystemName, $"Overview: Cycle {data.CurrentCycle}, {data.CurrentPhase}, Demon: {data.ActiveDemonName}");
            }
        }

        public string GetSummaryText()
        {
            var data = GetOverviewData();
            var sb = new StringBuilder();
            
            sb.AppendLine("═══════════════════════════════════");
            sb.AppendLine("   纪元之轮 - 魔王轮回系统 v0.1.0   ");
            sb.AppendLine("═══════════════════════════════════");
            sb.AppendLine();
            sb.AppendLine($"当前纪元: 第{data.CurrentCycle}轮回");
            sb.AppendLine($"世界年龄: {data.WorldAge}年");
            sb.AppendLine($"阶段: {data.CurrentPhase}");
            sb.AppendLine();
            sb.AppendLine("───────────────────────────────────");
            sb.AppendLine("【魔王状态】");
            sb.AppendLine($"  活跃魔王: {data.ActiveDemonName}");
            sb.AppendLine($"  状态: {data.ActiveDemonState}");
            
            if (data.DemonHealthPercent > 0)
            {
                sb.AppendLine($"  生命值: {data.DemonHealthPercent:F1}%");
            }
            
            sb.AppendLine($"  封印强度: {data.SealStrength:F1}%");
            
            if (data.SealWarActive)
            {
                sb.AppendLine();
                sb.AppendLine("【封印战进行中】");
                sb.AppendLine($"  仪式进度: {data.RitualProgress:F1}%");
            }
            
            sb.AppendLine();
            sb.AppendLine("───────────────────────────────────");
            sb.AppendLine("【纪元遗产加成】");
            sb.AppendLine($"  军事: +{data.MilitaryBonus:F1}%");
            sb.AppendLine($"  经济: +{data.EconomicBonus:F1}%");
            sb.AppendLine($"  科技: +{data.TechBonus:F1}%");
            sb.AppendLine();
            sb.AppendLine("───────────────────────────────────");
            sb.AppendLine($"启用魔王数: {data.EnabledDemonCount}");
            sb.AppendLine($"军团波次: {data.LegionWaveCount}");
            sb.AppendLine("═══════════════════════════════════");
            
            return sb.ToString();
        }

        public void Dispose()
        {
            if (_panelRoot != null)
            {
                Object.Destroy(_panelRoot);
                _panelRoot = null;
            }
            
            IsInitialized = false;
            Instance = null;
            Logger.Info(SystemName, "OverviewPanel disposed");
        }
    }

    public class OverviewData
    {
        public int CurrentCycle { get; set; }
        public int WorldAge { get; set; }
        public string CurrentPhase { get; set; }
        public string PhaseRaw { get; set; }
        
        public string ActiveDemonName { get; set; }
        public string ActiveDemonState { get; set; }
        public float DemonHealthPercent { get; set; }
        public float SealStrength { get; set; }
        
        public bool SealWarActive { get; set; }
        public float RitualProgress { get; set; }
        
        public float MilitaryBonus { get; set; }
        public float EconomicBonus { get; set; }
        public float TechBonus { get; set; }
        
        public int EnabledDemonCount { get; set; }
        public int LegionWaveCount { get; set; }
    }
}
