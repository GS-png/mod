using System;

namespace EraWheel.Core.Logging;

public static class EraLog
{
    public static void Info(EraLogCategory category, string message)
    {
        EraWheelMod.LogInfo(Format(category, message));
    }

    public static void Warning(EraLogCategory category, string message)
    {
        EraWheelMod.LogWarning(Format(category, message));
    }

    public static void Error(EraLogCategory category, string message)
    {
        EraWheelMod.LogError(Format(category, message));
    }

    public static void Exception(EraLogCategory category, string message, Exception exception)
    {
        EraWheelMod.LogError(Format(category, $"{message} | {exception.GetType().Name}: {exception.Message}"));
        if (!string.IsNullOrWhiteSpace(exception.StackTrace))
        {
            EraWheelMod.LogError(exception.StackTrace);
        }
    }

    private static string Format(EraLogCategory category, string message)
    {
        return $"[{GetLabel(category)}] {message}";
    }

    private static string GetLabel(EraLogCategory category)
    {
        return category switch
        {
            EraLogCategory.Startup => "启动",
            EraLogCategory.Config => "配置",
            EraLogCategory.Debug => "调试",
            EraLogCategory.Reflection => "反射",
            EraLogCategory.Localization => "文本",
            EraLogCategory.Data => "数据",
            EraLogCategory.Random => "随机",
            EraLogCategory.Events => "事件",
            EraLogCategory.Validation => "校验",
            EraLogCategory.Combat => "战斗",
            EraLogCategory.Save => "存档",
            _ => "通用",
        };
    }
}
