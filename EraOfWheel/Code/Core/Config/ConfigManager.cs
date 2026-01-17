using System;
using System.IO;
using UnityEngine;

namespace EraOfWheel.Core.Config
{
    public class ConfigManager : IModSystem
    {
        public static ConfigManager Instance { get; private set; }
        
        public string SystemName => "ConfigManager";
        public bool IsInitialized { get; private set; }
        
        public ModConfig Config { get; private set; }
        
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
                    return null;
                }
                
                var json = File.ReadAllText(path);
                return JsonUtility.FromJson<ModConfig>(json);
            }
            catch (Exception ex)
            {
                Logger.Error(SystemName, $"Error loading config from {path}", ex);
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
            
            Config.llm.permission_level = ErrorHandler.Clamp(Config.llm.permission_level, 1, 5);
            
            if (Config.cycle.trigger_conditions.conditions == null || Config.cycle.trigger_conditions.conditions.Count == 0)
            {
                Logger.Warn(SystemName, "No trigger conditions configured, adding default");
                Config.cycle.trigger_conditions.conditions.Add(new TriggerCondition { type = "world_age_years", threshold = 600 });
            }
            
            if (!Config.seal.victory_conditions.execution && !Config.seal.victory_conditions.ritual)
            {
                Logger.Warn(SystemName, "No victory conditions enabled, enabling execution as fallback");
                Config.seal.victory_conditions.execution = true;
            }
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
