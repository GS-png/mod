namespace EraOfWheel.Core.Events
{
    /// <summary>
    /// MOD初始化完成事件
    /// </summary>
    public class ModInitializedEvent : GameEvent
    {
        public string ModVersion { get; }

        public ModInitializedEvent(string version)
        {
            ModVersion = version;
        }
    }

    /// <summary>
    /// MOD卸载事件
    /// </summary>
    public class ModUnloadingEvent : GameEvent
    {
    }

    /// <summary>
    /// 配置变更事件
    /// </summary>
    public class ConfigChangedEvent : GameEvent
    {
        public string ConfigKey { get; }
        public object OldValue { get; }
        public object NewValue { get; }

        public ConfigChangedEvent(string key, object oldValue, object newValue)
        {
            ConfigKey = key;
            OldValue = oldValue;
            NewValue = newValue;
        }
    }

    /// <summary>
    /// 系统错误事件
    /// </summary>
    public class SystemErrorEvent : GameEvent
    {
        public string SystemName { get; }
        public string ErrorMessage { get; }
        public System.Exception Exception { get; }

        public SystemErrorEvent(string systemName, string message, System.Exception ex = null)
        {
            SystemName = systemName;
            ErrorMessage = message;
            Exception = ex;
        }
    }
}
