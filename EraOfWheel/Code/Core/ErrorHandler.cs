using System;
using EraOfWheel.Core.Events;

namespace EraOfWheel.Core
{
    /// <summary>
    /// 全局错误处理器
    /// </summary>
    public class ErrorHandler : IModSystem
    {
        public static ErrorHandler Instance { get; private set; }
        
        public string SystemName => "ErrorHandler";
        public bool IsInitialized { get; private set; }

        public void Initialize()
        {
            if (IsInitialized) return;

            Instance = this;
            
            // 注册全局异常处理
            AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
            
            IsInitialized = true;
            Logger.Info(SystemName, "错误处理器初始化完成");
        }

        private void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception;
            HandleCritical("UnhandledException", ex?.Message ?? "Unknown error", ex);
        }

        /// <summary>
        /// 处理关键错误（记录、降级、通知）
        /// </summary>
        public void HandleCritical(string system, string message, Exception ex = null)
        {
            Logger.Error(system, $"[CRITICAL] {message}", ex);
            
            // 发布错误事件
            EventBus.Instance?.Publish(new SystemErrorEvent(system, message, ex));
            
            // 尝试安全降级
            TrySafeDegrade(system);
        }

        /// <summary>
        /// 处理普通错误（记录、尝试恢复）
        /// </summary>
        public void HandleError(string system, string message, Exception ex = null)
        {
            Logger.Error(system, message, ex);
            EventBus.Instance?.Publish(new SystemErrorEvent(system, message, ex));
        }

        /// <summary>
        /// 处理警告（仅记录）
        /// </summary>
        public void HandleWarning(string system, string message)
        {
            Logger.Warn(system, message);
        }

        private void TrySafeDegrade(string system)
        {
            Logger.Warn(SystemName, $"尝试安全降级: {system}");
            // 根据系统类型执行不同的降级策略
        }

        /// <summary>
        /// 安全执行Action，捕获异常
        /// </summary>
        public static bool TryExecute(string system, Action action)
        {
            try
            {
                action();
                return true;
            }
            catch (Exception ex)
            {
                Instance?.HandleError(system, "执行失败", ex);
                return false;
            }
        }

        /// <summary>
        /// 安全执行Func，捕获异常
        /// </summary>
        public static T TryExecute<T>(string system, Func<T> func, T defaultValue = default)
        {
            try
            {
                return func();
            }
            catch (Exception ex)
            {
                Instance?.HandleError(system, "执行失败", ex);
                return defaultValue;
            }
        }

        public void Dispose()
        {
            AppDomain.CurrentDomain.UnhandledException -= OnUnhandledException;
            Instance = null;
            IsInitialized = false;
        }
    }
}
