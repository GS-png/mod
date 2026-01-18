using System;
using System.Text;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using EraOfWheel.Core;
using EraOfWheel.Core.Config;
using EraOfWheel.Cycle;
using EraOfWheel.DemonLords;
using EraOfWheel.UI;
using Logger = EraOfWheel.Core.Logger;

namespace EraOfWheel.UI.Panels
{
    public class DemonPanel : IModSystem
    {
        public static DemonPanel Instance { get; private set; }
        
        public string SystemName => "DemonPanel";
        public bool IsInitialized { get; private set; }
        
        private GameObject _panelRoot;
        private bool _isVisible = false;
        private string _selectedDemonId = "";

        private List<DemonData> _cachedDemons;
        private float _lastDemonsBuildTime = -999f;
        private const float DemonsCacheSeconds = 0.5f;

        private string _cachedDetailText = "";
        private string _cachedDetailId = "";
        private float _lastDetailBuildTime = -999f;
        private const float DetailCacheSeconds = 0.5f;

        public void Initialize()
        {
            if (IsInitialized) return;
            
            Instance = this;
            CreatePanel();
            
            IsInitialized = true;
            Logger.Info(SystemName, "DemonPanel initialized");
        }

        private void CreatePanel()
        {
            Logger.Debug(SystemName, "Demon panel created (placeholder)");
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

        public void SelectDemon(string demonId)
        {
            _selectedDemonId = demonId;
            Refresh();
        }

        public void Refresh()
        {
            if (!_isVisible) return;

            _lastDemonsBuildTime = -999f;
            _lastDetailBuildTime = -999f;
            
            var demons = GetAllDemonData();
            UpdateDisplay(demons);
        }

        public List<DemonData> GetAllDemonData()
        {
            if (_cachedDemons != null)
            {
                float now = Time.realtimeSinceStartup;
                if (now - _lastDemonsBuildTime < DemonsCacheSeconds)
                {
                    return _cachedDemons;
                }
            }

            var result = new List<DemonData>();
            var demons = DemonLordManager.Instance?.AllDemonLords;
            
            if (demons == null)
            {
                _cachedDemons = result;
                _lastDemonsBuildTime = Time.realtimeSinceStartup;
                return result;
            }
            
            int currentCycle = CycleManager.Instance?.State?.CycleCount ?? 1;
            
            foreach (var demon in demons)
            {
                result.Add(new DemonData
                {
                    Id = demon.Id,
                    Name = demon.Name,
                    Title = demon.Title,
                    Description = demon.Description,
                    
                    IsEnabled = demon.IsEnabled,
                    IsUnlocked = demon.IsUnlocked(currentCycle),
                    UnlockCycle = demon.EffectiveUnlockCycle,
                    
                    State = demon.State.ToDisplayName(),
                    StateRaw = demon.State.ToString(),
                    
                    MaxHealth = demon.Stats?.MaxHealth ?? 0f,
                    CurrentHealth = demon.Stats?.CurrentHealth ?? 0f,
                    HealthPercent = demon.Stats?.HealthPercent ?? 0f,
                    
                    SealStrength = demon.SealStrength,
                    TotalKills = demon.TotalKills,
                    CitiesDestroyed = demon.CitiesDestroyed,
                    HeroesKilled = demon.HeroesKilled,
                    
                    IsActive = DemonLordManager.Instance?.ActiveDemonLord?.Id == demon.Id
                });
            }
            
            _cachedDemons = result;
            _lastDemonsBuildTime = Time.realtimeSinceStartup;
            return _cachedDemons;
        }

        public DemonData GetSelectedDemonData()
        {
            if (string.IsNullOrEmpty(_selectedDemonId))
            {
                var active = DemonLordManager.Instance?.ActiveDemonLord;
                if (active != null)
                {
                    _selectedDemonId = active.Id;
                }
            }
            
            var demons = GetAllDemonData();
            foreach (var demon in demons)
            {
                if (demon.Id == _selectedDemonId)
                {
                    return demon;
                }
            }
            
            return demons.Count > 0 ? demons[0] : null;
        }

        private void UpdateDisplay(List<DemonData> demons)
        {
            if (ConfigManager.Instance?.Config?.core?.debug_mode == true)
            {
                Logger.Debug(SystemName, $"Displaying {demons.Count} demon lords");
            }
        }

        public string GetDemonDetailText(string demonId = null)
        {
            float now = Time.realtimeSinceStartup;
            string cacheKey = demonId ?? "";
            if (!string.IsNullOrEmpty(_cachedDetailText) && _cachedDetailId == cacheKey)
            {
                if (now - _lastDetailBuildTime < DetailCacheSeconds)
                {
                    return _cachedDetailText;
                }
            }

            var demon = string.IsNullOrEmpty(demonId) 
                ? GetSelectedDemonData() 
                : GetDemonDataById(demonId);
            
            if (demon == null)
            {
                return "无魔王数据";
            }
            
            var sb = new StringBuilder();
            
            sb.AppendLine("╔═══════════════════════════════════════╗");
            sb.AppendLine($"║  {demon.Name,-35}║");
            sb.AppendLine($"║  {demon.Title,-35}║");
            sb.AppendLine("╠═══════════════════════════════════════╣");
            sb.AppendLine($"║  状态: {demon.State,-28}║");
            
            if (demon.IsActive)
            {
                sb.AppendLine("║  【当前活跃魔王】                      ║");
            }
            
            sb.AppendLine("╠═══════════════════════════════════════╣");
            sb.AppendLine("║ 基础属性                               ║");
            sb.AppendLine($"║  生命值: {demon.CurrentHealth:N0}/{demon.MaxHealth:N0} ({demon.HealthPercent:F1}%)");
            sb.AppendLine($"║  封印强度: {demon.SealStrength:F1}%");
            sb.AppendLine("║");
            sb.AppendLine("║ 战绩统计                               ║");
            sb.AppendLine($"║  总击杀: {demon.TotalKills}");
            sb.AppendLine($"║  摧毁城市: {demon.CitiesDestroyed}");
            sb.AppendLine($"║  击杀英雄: {demon.HeroesKilled}");
            sb.AppendLine("║");
            sb.AppendLine("╠═══════════════════════════════════════╣");
            sb.AppendLine("║ 解锁状态                               ║");
            
            if (demon.IsUnlocked)
            {
                sb.AppendLine($"║  ✓ 已解锁 (第{demon.UnlockCycle}轮回)");
            }
            else
            {
                sb.AppendLine($"║  ✗ 未解锁 (需要第{demon.UnlockCycle}轮回)");
            }
            
            sb.AppendLine($"║  启用状态: {(demon.IsEnabled ? "已启用" : "已禁用")}");
            sb.AppendLine("║");
            sb.AppendLine("╠═══════════════════════════════════════╣");
            sb.AppendLine("║ 手动操作                               ║");
            sb.AppendLine("║  [立即苏醒] [调整强度] [查看日志]      ║");
            sb.AppendLine("║  [启用/禁用] [重置统计]                ║");
            sb.AppendLine("╚═══════════════════════════════════════╝");
            
            _cachedDetailText = sb.ToString();
            _cachedDetailId = cacheKey;
            _lastDetailBuildTime = now;
            return _cachedDetailText;
        }

        private DemonData GetDemonDataById(string id)
        {
            var demons = GetAllDemonData();
            foreach (var demon in demons)
            {
                if (demon.Id == id)
                {
                    return demon;
                }
            }
            return null;
        }

        public string GetDemonListText()
        {
            var demons = GetAllDemonData();
            var sb = new StringBuilder();
            
            sb.AppendLine("══════════════════════════════════════");
            sb.AppendLine("         魔王管理面板                  ");
            sb.AppendLine("══════════════════════════════════════");
            sb.AppendLine();
            
            foreach (var demon in demons)
            {
                string status = demon.IsActive ? "◆" : (demon.IsEnabled ? "○" : "✗");
                string state = demon.State;
                
                sb.AppendLine($"{status} {demon.Name}");
                sb.AppendLine($"   状态: {state}");
                
                if (demon.IsActive)
                {
                    sb.AppendLine($"   生命: {demon.HealthPercent:F1}%  封印: {demon.SealStrength:F1}%");
                }
                
                if (!demon.IsUnlocked)
                {
                    sb.AppendLine($"   [第{demon.UnlockCycle}轮回解锁]");
                }
                
                sb.AppendLine();
            }
            
            sb.AppendLine("──────────────────────────────────────");
            sb.AppendLine("◆ = 活跃  ○ = 启用  ✗ = 禁用");
            sb.AppendLine("══════════════════════════════════════");
            
            return sb.ToString();
        }

        public void ForceAwaken(string demonId)
        {
            var demon = DemonLordManager.Instance?.GetDemonLord(demonId);
            if (demon == null)
            {
                Logger.Warn(SystemName, $"Demon not found: {demonId}");
                NotificationSystem.Instance?.Show("魔王", "未找到该魔王", NotificationType.Warning);
                return;
            }
            
            if (!demon.IsEnabled)
            {
                Logger.Warn(SystemName, $"Demon is disabled: {demonId}");
                NotificationSystem.Instance?.Show("魔王", "该魔王已被禁用", NotificationType.Warning);
                return;
            }
            
            if (DemonLordManager.Instance == null)
            {
                Logger.Warn(SystemName, "DemonLordManager not ready");
                return;
            }

            if (!DemonLordManager.Instance.SetActiveDemonLord(demonId))
            {
                Logger.Warn(SystemName, $"Failed to set active demon: {demonId}");
                NotificationSystem.Instance?.Show("魔王", "无法将该魔王设为活跃（可能未解锁）", NotificationType.Warning);
                return;
            }

            Logger.Info(SystemName, $"Force awakening demon: {demon.Name}");
            NotificationSystem.Instance?.Show("魔王", $"强制苏醒：{demon.Name}", NotificationType.Info);

            var cycle = CycleManager.Instance;
            if (cycle?.State == null) return;

            if (cycle.State.CurrentPhase == CyclePhase.Sealed)
            {
                cycle.TransitionToPhase(CyclePhase.Omen);
            }
            if (cycle.State.CurrentPhase == CyclePhase.Omen)
            {
                cycle.TransitionToPhase(CyclePhase.Awakening);
            }
            if (cycle.State.CurrentPhase == CyclePhase.Awakening)
            {
                cycle.TransitionToPhase(CyclePhase.Invasion);
            }
        }

        public void ToggleEnabled(string demonId)
        {
            var demon = DemonLordManager.Instance?.GetDemonLord(demonId);
            if (demon == null) return;

            bool newEnabled = !demon.IsEnabled;

            var active = DemonLordManager.Instance?.ActiveDemonLord;
            if (!newEnabled && active != null && active.Id == demonId)
            {
                Logger.Warn(SystemName, $"Cannot disable active demon: {demonId}");
                NotificationSystem.Instance?.Show("魔王", "不能禁用当前活跃魔王（请先封印/结束入侵）", NotificationType.Warning);
                return;
            }
            
            demon.IsEnabled = newEnabled;
            Logger.Info(SystemName, $"Demon {demon.Name} enabled: {demon.IsEnabled}");

            bool persisted = TryPersistDemonEnabledToConfig(demonId, demon.IsEnabled);
            if (persisted)
            {
                NotificationSystem.Instance?.Show("魔王", $"{demon.Name} {(demon.IsEnabled ? "已启用" : "已禁用")}（已保存配置）", NotificationType.Info);
            }
            else
            {
                NotificationSystem.Instance?.Show("魔王", $"{demon.Name} {(demon.IsEnabled ? "已启用" : "已禁用")}（未能保存配置）", NotificationType.Warning);
            }

            _lastDemonsBuildTime = -999f;
            _lastDetailBuildTime = -999f;
            
            Refresh();
        }

        private static bool TryPersistDemonEnabledToConfig(string demonId, bool enabled)
        {
            try
            {
                var cfg = ConfigManager.Instance;
                if (cfg?.Config?.demon_lords == null) return false;

                var demonCfgRoot = cfg.Config.demon_lords;
                var rootType = demonCfgRoot.GetType();
                var field = rootType.GetField(demonId, BindingFlags.Public | BindingFlags.Instance);
                if (field == null) return false;

                var demonCfg = field.GetValue(demonCfgRoot);
                if (demonCfg == null) return false;

                var enabledField = demonCfg.GetType().GetField("enabled", BindingFlags.Public | BindingFlags.Instance);
                if (enabledField == null || enabledField.FieldType != typeof(bool)) return false;

                enabledField.SetValue(demonCfg, enabled);
                cfg.SaveConfig();
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error("DemonPanel", "Failed to persist demon enabled flag", ex);
                return false;
            }
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
            Logger.Info(SystemName, "DemonPanel disposed");
        }
    }

    public class DemonData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        
        public bool IsEnabled { get; set; }
        public bool IsUnlocked { get; set; }
        public int UnlockCycle { get; set; }
        
        public string State { get; set; }
        public string StateRaw { get; set; }
        
        public float MaxHealth { get; set; }
        public float CurrentHealth { get; set; }
        public float HealthPercent { get; set; }
        
        public float SealStrength { get; set; }
        public int TotalKills { get; set; }
        public int CitiesDestroyed { get; set; }
        public int HeroesKilled { get; set; }
        
        public bool IsActive { get; set; }
    }
}
