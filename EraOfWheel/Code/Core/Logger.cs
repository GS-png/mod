using System;
using System.IO;
using System.Text;
using UnityEngine;

namespace EraOfWheel.Core
{
    /// <summary>
    /// 统一日志系统
    /// </summary>
    public class Logger : IModSystem
    {
        public static Logger Instance { get; private set; }
        
        public string SystemName => "Logger";
        public bool IsInitialized { get; private set; }

        private string _logPath;
        private StringBuilder _buffer = new StringBuilder();
        private bool _fileLoggingEnabled = false;

        public void Initialize()
        {
            if (IsInitialized) return;

            Instance = this;
            
            var modPath = Path.GetDirectoryName(typeof(Logger).Assembly.Location);
            _logPath = Path.Combine(modPath, "logs", $"mod_{DateTime.Now:yyyyMMdd}.log");

            var logDir = Path.GetDirectoryName(_logPath);
            if (!Directory.Exists(logDir))
            {
                Directory.CreateDirectory(logDir);
            }

            _fileLoggingEnabled = Config.ConfigManager.Instance?.DebugMode ?? false;
            IsInitialized = true;
            
            Info("Logger", "日志系统初始化完成");
        }

        public static void Debug(string system, string message)
        {
            Instance?.Log(LogLevel.Debug, system, message);
        }

        public static void Info(string system, string message)
        {
            Instance?.Log(LogLevel.Info, system, message);
        }

        public static void Warn(string system, string message)
        {
            Instance?.Log(LogLevel.Warning, system, message);
        }

        public static void Error(string system, string message, Exception ex = null)
        {
            var fullMessage = ex != null ? $"{message}: {ex.Message}" : message;
            Instance?.Log(LogLevel.Error, system, fullMessage);
        }

        private void Log(LogLevel level, string system, string message)
        {
            var timestamp = DateTime.Now.ToString("HH:mm:ss");
            var levelStr = level switch
            {
                LogLevel.Debug => "DEBUG",
                LogLevel.Warning => "WARN",
                LogLevel.Error => "ERROR",
                _ => "INFO"
            };

            var formattedMessage = $"[{timestamp}] [{levelStr}] [{system}] {message}";

            // Unity Console
            switch (level)
            {
                case LogLevel.Error:
                    UnityEngine.Debug.LogError(formattedMessage);
                    break;
                case LogLevel.Warning:
                    UnityEngine.Debug.LogWarning(formattedMessage);
                    break;
                default:
                    UnityEngine.Debug.Log(formattedMessage);
                    break;
            }

            // File logging
            if (_fileLoggingEnabled)
            {
                _buffer.AppendLine(formattedMessage);
                if (_buffer.Length > 4096)
                {
                    Flush();
                }
            }
        }

        public void Flush()
        {
            if (_buffer.Length > 0)
            {
                try
                {
                    File.AppendAllText(_logPath, _buffer.ToString());
                    _buffer.Clear();
                }
                catch { }
            }
        }

        public void Dispose()
        {
            Flush();
            Instance = null;
            IsInitialized = false;
        }

        public enum LogLevel { Debug, Info, Warning, Error }
    }
}
