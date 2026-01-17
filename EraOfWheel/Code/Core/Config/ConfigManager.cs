using System;
using System.IO;
using EraOfWheel.Core.Events;
using UnityEngine;

namespace EraOfWheel.Core.Config
{
    /// <summary>
    /// 配置管理器 - 负责加载、保存和管理MOD配置
    /// </summary>
    public class ConfigManager : IModSystem
    {
        public static ConfigManager Instance { get; private set; }
        
        public string SystemName => "ConfigManager";
        public bool IsInitialized { get; private set; }

        private ModConfig _config;
        private string _configPath;
        private DateTime _lastModified;

        public ModConfig Config => _config;

        public void Initialize()
        {
            if (IsInitialized) return;

            Instance = this;
            
            // 设置配置文件路径
            var modPath = Path.GetDirectoryName(typeof(ConfigManager).Assembly.Location);
            _configPath = Path.Combine(modPath, "Resources", "Config", "config.json");

            Load();
            IsInitialized = true;
            ModMain.Log($"[{SystemName}] 初始化完成");
        }

        /// <summary>
        /// 加载配置文件
        /// </summary>
        public void Load()
        {
            try
            {
                if (File.Exists(_configPath))
                {
                    var json = File.ReadAllText(_configPath);
                    _config = JsonUtility.FromJson<ModConfig>(json);
                    _lastModified = File.GetLastWriteTime(_configPath);
                    ModMain.Log($"[{SystemName}] 配置已加载: {_configPath}");
                }
                else
                {
                    ModMain.Log($"[{SystemName}] 配置文件不存在，使用默认值", ModMain.LogLevel.Warning);
                    _config = new ModConfig();
                    Save(); // 创建默认配置文件
                }
            }
            catch (Exception ex)
            {
                ModMain.Log($"[{SystemName}] 加载配置失败: {ex.Message}", ModMain.LogLevel.Error);
                _config = new ModConfig();
            }
        }

        /// <summary>
        /// 保存配置到文件
        /// </summary>
        public void Save()
        {
            try
            {
                var directory = Path.GetDirectoryName(_configPath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                var json = JsonUtility.ToJson(_config, true);
                File.WriteAllText(_configPath, json);
                _lastModified = File.GetLastWriteTime(_configPath);
                ModMain.Log($"[{SystemName}] 配置已保存");
            }
            catch (Exception ex)
            {
                ModMain.Log($"[{SystemName}] 保存配置失败: {ex.Message}", ModMain.LogLevel.Error);
            }
        }

        /// <summary>
        /// 重新加载配置（热重载）
        /// </summary>
        public void Reload()
        {
            var oldConfig = _config;
            Load();
            
            // 发布配置变更事件
            EventBus.Instance?.Publish(new ConfigChangedEvent("*", oldConfig, _config));
            ModMain.Log($"[{SystemName}] 配置已重新加载");
        }

        /// <summary>
        /// 检查配置文件是否已修改
        /// </summary>
        public bool HasFileChanged()
        {
            if (!File.Exists(_configPath)) return false;
            return File.GetLastWriteTime(_configPath) > _lastModified;
        }

        /// <summary>
        /// 获取配置值（泛型）
        /// </summary>
        public T Get<T>(Func<ModConfig, T> selector)
        {
            return selector(_config);
        }

        /// <summary>
        /// 设置配置值并触发事件
        /// </summary>
        public void Set<T>(Action<ModConfig> setter, string key, T oldValue, T newValue)
        {
            setter(_config);
            EventBus.Instance?.Publish(new ConfigChangedEvent(key, oldValue, newValue));
        }

        // 便捷访问属性
        public bool DebugMode => _config.debug_mode;
        public LLMConfig LLM => _config.llm;
        public GameplayConfig Gameplay => _config.gameplay;
        public UIConfig UI => _config.ui;

        public void Dispose()
        {
            Save();
            Instance = null;
            IsInitialized = false;
        }
    }
}
