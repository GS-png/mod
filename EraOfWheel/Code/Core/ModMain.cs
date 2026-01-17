using System;
using System.Collections.Generic;
using System.IO;
using NeoModLoader.api;
using UnityEngine;

namespace EraOfWheel.Core
{
    public class ModMain : MonoBehaviour, IMod
    {
        public static ModMain Instance { get; private set; }

        private static string _bootstrapLogPath;
        
        private ModDeclare _declare;
        private GameObject _gameObject;
        
        private readonly List<IDisposable> _disposables = new List<IDisposable>();
        private bool _isInitialized = false;

        public ModDeclare GetDeclaration() => _declare;

        public GameObject GetGameObject() => _gameObject;

        public string GetUrl() => string.Empty;

        public void OnLoad(ModDeclare pModDecl, GameObject pGameObject)
        {
            _declare = pModDecl;
            _gameObject = pGameObject;
            OnModLoad();
        }

        public void OnUnload()
        {
            OnModUnload();
        }

        public void OnModLoad()
        {
            if (_isInitialized)
            {
                Log("MOD already initialized, skipping...", LogLevel.Warning);
                return;
            }

            Instance = this;
            
            Log("=== 纪元之轮：魔王轮回 ===");
            Log("MOD版本: 0.1.0");
            Log("作者: 吴旭");
            Log("正在初始化...");

            try
            {
                InitializeSystems();
                _isInitialized = true;
                Log("MOD初始化完成！");
            }
            catch (Exception ex)
            {
                Log($"MOD初始化失败: {ex}", LogLevel.Error);
                _isInitialized = false;
            }
        }

        public void OnModUnload()
        {
            Log("正在卸载MOD...");

            try
            {
                CleanupResources();
                _isInitialized = false;
                Instance = null;
                Log("MOD卸载完成");
            }
            catch (Exception ex)
            {
                Log($"MOD卸载时发生错误: {ex.Message}", LogLevel.Error);
            }
        }

        private void InitializeSystems()
        {
            // Story 1.2: EventBus
            var eventBus = new EventBus();
            eventBus.Initialize();
            RegisterDisposable(eventBus);
            
            // Story 1.3: ConfigManager
            var configManager = new Config.ConfigManager();
            configManager.Initialize();
            RegisterDisposable(configManager);
            
            // 发布初始化完成事件
            EventBus.Instance.Publish(new Events.ModInitializedEvent("0.1.0"));
            
            // Story 1.4: SaveManager
            var saveManager = new Data.SaveManager();
            saveManager.Initialize();
            RegisterDisposable(saveManager);
            
            // Story 1.5: Logger
            var logger = new Logger();
            logger.Initialize();
            RegisterDisposable(logger);
            
            // Story 1.6: ErrorHandler
            var errorHandler = new ErrorHandler();
            errorHandler.Initialize();
            RegisterDisposable(errorHandler);
        }

        private void CleanupResources()
        {
            foreach (var disposable in _disposables)
            {
                try
                {
                    disposable?.Dispose();
                }
                catch (Exception ex)
                {
                    Log($"资源清理失败: {ex.Message}", LogLevel.Warning);
                }
            }
            _disposables.Clear();
        }

        public void RegisterDisposable(IDisposable disposable)
        {
            if (disposable != null)
            {
                _disposables.Add(disposable);
            }
        }

        public static void Log(string message, LogLevel level = LogLevel.Info)
        {
            string prefix = level switch
            {
                LogLevel.Error => "[ERROR]",
                LogLevel.Warning => "[WARN]",
                LogLevel.Debug => "[DEBUG]",
                _ => "[INFO]"
            };

            var formatted = $"{prefix} [EraOfWheel] {message}";
            TryWriteBootstrapLog(formatted);

            switch (level)
            {
                case LogLevel.Error:
                    Debug.LogError(formatted);
                    break;
                case LogLevel.Warning:
                    Debug.LogWarning(formatted);
                    break;
                default:
                    Debug.Log(formatted);
                    break;
            }
        }

        private static void TryWriteBootstrapLog(string line)
        {
            try
            {
                if (string.IsNullOrEmpty(_bootstrapLogPath))
                {
                    var modPath = Path.GetDirectoryName(typeof(ModMain).Assembly.Location);
                    _bootstrapLogPath = Path.Combine(modPath ?? string.Empty, "logs", "bootstrap.log");
                }

                var dir = Path.GetDirectoryName(_bootstrapLogPath);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                File.AppendAllText(_bootstrapLogPath, $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {line}\n");
            }
            catch
            {
            }
        }

        public enum LogLevel
        {
            Debug,
            Info,
            Warning,
            Error
        }
    }
}
