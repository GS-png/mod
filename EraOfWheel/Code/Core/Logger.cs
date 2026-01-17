using System;
using UnityEngine;

namespace EraOfWheel.Core
{
    public enum LogLevel
    {
        Debug = 0,
        Info = 1,
        Warn = 2,
        Error = 3
    }

    public static class Logger
    {
        private const string ModPrefix = "[EraOfWheel]";
        private static LogLevel _minLevel = LogLevel.Info;

        public static void SetMinLevel(LogLevel level)
        {
            _minLevel = level;
        }

        public static void SetMinLevel(string levelName)
        {
            if (Enum.TryParse<LogLevel>(levelName, true, out var level))
            {
                _minLevel = level;
            }
        }

        public static void Debug(string system, string message)
        {
            Log(LogLevel.Debug, system, message);
        }

        public static void Info(string system, string message)
        {
            Log(LogLevel.Info, system, message);
        }

        public static void Warn(string system, string message)
        {
            Log(LogLevel.Warn, system, message);
        }

        public static void Error(string system, string message)
        {
            Log(LogLevel.Error, system, message);
        }

        public static void Error(string system, string message, Exception ex)
        {
            Log(LogLevel.Error, system, $"{message}: {ex.Message}\n{ex.StackTrace}");
        }

        private static void Log(LogLevel level, string system, string message)
        {
            if (level < _minLevel) return;

            var formattedMessage = $"{ModPrefix}[{system}] {message}";

            switch (level)
            {
                case LogLevel.Debug:
                case LogLevel.Info:
                    UnityEngine.Debug.Log(formattedMessage);
                    break;
                case LogLevel.Warn:
                    UnityEngine.Debug.LogWarning(formattedMessage);
                    break;
                case LogLevel.Error:
                    UnityEngine.Debug.LogError(formattedMessage);
                    break;
            }
        }
    }
}
