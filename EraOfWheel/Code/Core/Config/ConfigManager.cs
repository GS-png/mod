using System;
using System.IO;
using UnityEngine;
using Logger = EraOfWheel.Core.Logger;

namespace EraOfWheel.Core.Config
{
    public class ConfigManager : IModSystem
    {
        public static ConfigManager Instance { get; private set; }
        
        public string SystemName => "ConfigManager";
        public bool IsInitialized { get; private set; }
        
        public ModConfig Config { get; private set; }

        private readonly System.Collections.Generic.List<string> _startupWarnings = new System.Collections.Generic.List<string>();
        public System.Collections.Generic.IReadOnlyList<string> StartupWarnings => _startupWarnings;
        
        private string _configPath;
        private string _backupPath;

        public void Initialize()
        {
            if (IsInitialized) return;
            
            Instance = this;
            
            var modPath = GetModPath();
            _configPath = Path.Combine(modPath, "Resources", "Config", "config.json");
            _backupPath = Path.Combine(modPath, "Resources", "Config", "config.backup.json");
            
            LoadConfig();
            
            IsInitialized = true;
            Logger.Info(SystemName, $"ConfigManager initialized, config loaded from {_configPath}");
        }

        private string GetModPath()
        {
            var assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            return Path.GetDirectoryName(assemblyPath) ?? Application.dataPath;
        }

        public void LoadConfig()
        {
            Config = LoadFromFile(_configPath);
            if (Config == null)
            {
                Logger.Warn(SystemName, "Failed to load config, using defaults");
                AddStartupWarning("配置文件加载失败，已回退为默认配置");
                Config = CreateDefaultConfig();
                SaveConfig();
            }
            
            ValidateConfig();
            ApplyLogLevel();
        }

        private ModConfig LoadFromFile(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    Logger.Info(SystemName, $"Config file not found at {path}");
                    AddStartupWarning($"未找到配置文件：{path}（将使用默认配置）");
                    return null;
                }
                
                var json = File.ReadAllText(path);
                return JsonUtility.FromJson<ModConfig>(json);
            }
            catch (Exception ex)
            {
                Logger.Error(SystemName, $"Error loading config from {path}", ex);
                AddStartupWarning($"配置读取异常：{ex.Message}（将使用默认配置）");
                return null;
            }
        }

        public void SaveConfig()
        {
            try
            {
                BackupConfig();
                
                var directory = Path.GetDirectoryName(_configPath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                
                var json = JsonUtility.ToJson(Config, true);
                File.WriteAllText(_configPath, json);
                Logger.Info(SystemName, "Config saved");
            }
            catch (Exception ex)
            {
                Logger.Error(SystemName, "Error saving config", ex);
            }
        }

        private void BackupConfig()
        {
            try
            {
                if (File.Exists(_configPath))
                {
                    File.Copy(_configPath, _backupPath, true);
                }
            }
            catch (Exception ex)
            {
                Logger.Warn(SystemName, $"Failed to backup config: {ex.Message}");
            }
        }

        public void RestoreBackup()
        {
            try
            {
                if (File.Exists(_backupPath))
                {
                    File.Copy(_backupPath, _configPath, true);
                    LoadConfig();
                    Logger.Info(SystemName, "Config restored from backup");
                }
            }
            catch (Exception ex)
            {
                Logger.Error(SystemName, "Error restoring backup", ex);
            }
        }

        public void ResetToDefaults()
        {
            Config = CreateDefaultConfig();
            SaveConfig();
            Logger.Info(SystemName, "Config reset to defaults");
        }

        private ModConfig CreateDefaultConfig()
        {
            var config = new ModConfig();
            
            config.cycle.trigger_conditions.conditions.Add(new TriggerCondition { type = "world_age_years", threshold = 600 });
            config.cycle.trigger_conditions.conditions.Add(new TriggerCondition { type = "total_population", threshold = 10000 });
            config.cycle.trigger_conditions.conditions.Add(new TriggerCondition { type = "total_cities", threshold = 50 });
            
            return config;
        }

        private void ValidateConfig()
        {
            Config.difficulty.cycle_growth = ErrorHandler.Clamp(Config.difficulty.cycle_growth, 0f, 2f);
            Config.difficulty.adaptive.min = ErrorHandler.Clamp(Config.difficulty.adaptive.min, 0.1f, 1f);
            Config.difficulty.adaptive.max = ErrorHandler.Clamp(Config.difficulty.adaptive.max, 1f, 3f);
            Config.difficulty.caps.min_power = ErrorHandler.Clamp(Config.difficulty.caps.min_power, 0.1f, 1f);
            Config.difficulty.caps.max_power = ErrorHandler.Clamp(Config.difficulty.caps.max_power, 1f, 10f);
            
            Config.seal.failure_conditions.cities_controlled_ratio = ErrorHandler.Clamp(Config.seal.failure_conditions.cities_controlled_ratio, 0.3f, 0.9f);
            Config.seal.restart_cycle.legacy_keep_ratio = ErrorHandler.Clamp(Config.seal.restart_cycle.legacy_keep_ratio, 0f, 1f);
            
            Config.legacy.legendary_probability = ErrorHandler.Clamp(Config.legacy.legendary_probability, 0f, 1f);
            Config.legacy.stacking_diminish_rate = ErrorHandler.Clamp(Config.legacy.stacking_diminish_rate, 0f, 1f);

            Config.generals.defeat_threshold = ErrorHandler.Clamp(Config.generals.defeat_threshold, 1, 20);
            Config.generals.betray_probability = ErrorHandler.Clamp(Config.generals.betray_probability, 0f, 1f);
            Config.generals.retreat_health_percent = ErrorHandler.Clamp(Config.generals.retreat_health_percent, 1f, 90f);
            Config.generals.skill_check_interval_years = ErrorHandler.Clamp(Config.generals.skill_check_interval_years, 1, 50);
            
            Config.llm.permission_level = ErrorHandler.Clamp(Config.llm.permission_level, 1, 5);
            
            if (Config.cycle.trigger_conditions.conditions == null || Config.cycle.trigger_conditions.conditions.Count == 0)
            {
                Logger.Warn(SystemName, "No trigger conditions configured, adding default");
                AddStartupWarning("轮回触发条件为空，已自动补充默认触发条件（世界年龄>=600）");
                Config.cycle.trigger_conditions.conditions.Add(new TriggerCondition { type = "world_age_years", threshold = 600 });
            }
            else
            {
                bool anyPositive = false;
                foreach (var c in Config.cycle.trigger_conditions.conditions)
                {
                    if (c == null) continue;
                    if (c.threshold > 0)
                    {
                        anyPositive = true;
                        break;
                    }
                }

                if (!anyPositive)
                {
                    Logger.Warn(SystemName, "All trigger condition thresholds are <= 0, using default fallback");
                    AddStartupWarning("轮回触发条件阈值全部为0/负数，已回退默认触发条件（世界年龄>=600）");
                    Config.cycle.trigger_conditions.conditions.Clear();
                    Config.cycle.trigger_conditions.conditions.Add(new TriggerCondition { type = "world_age_years", threshold = 600 });
                }
            }
            
            if (!Config.seal.victory_conditions.execution && !Config.seal.victory_conditions.ritual)
            {
                Logger.Warn(SystemName, "No victory conditions enabled, enabling execution as fallback");
                AddStartupWarning("封印胜利条件配置为空，已自动启用‘击杀封印’作为保底");
                Config.seal.victory_conditions.execution = true;
            }
        }

        private void AddStartupWarning(string message)
        {
            if (string.IsNullOrEmpty(message)) return;
            _startupWarnings.Add(message);
        }

        private void ApplyLogLevel()
        {
            Logger.SetMinLevel(Config.core.log_level);
        }

        public void Dispose()
        {
            IsInitialized = false;
            Instance = null;
            Logger.Info(SystemName, "ConfigManager disposed");
        }
    }
}
