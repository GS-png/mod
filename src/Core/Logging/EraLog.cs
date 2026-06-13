using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace EraWheel.Core.Logging;

public static class EraLog
{
    private static readonly Regex WindowsAbsolutePathRegex = new(@"[A-Za-z]:\\[^\s=;|<>""']+", RegexOptions.Compiled);
    private static readonly Regex UnixAbsolutePathRegex = new(@"(?<![\w:])/(?!/)[^\s=;|<>""']+(?:/[^\s=;|<>""']*)*", RegexOptions.Compiled);

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
            EraWheelMod.LogError(SanitizeLogText(exception.StackTrace));
        }
    }

    public static void Event(
        EraLogCategory category,
        string eventId,
        string stage,
        long cycle,
        float worldTime,
        string result,
        params (string Key, object Value)[] fields
    )
    {
        WriteEvent(category, eventId, stage, cycle, worldTime, result, false, fields);
    }

    public static void EventWarning(
        EraLogCategory category,
        string eventId,
        string stage,
        long cycle,
        float worldTime,
        string result,
        params (string Key, object Value)[] fields
    )
    {
        WriteEvent(category, eventId, stage, cycle, worldTime, result, true, fields);
    }

    private static void WriteEvent(
        EraLogCategory category,
        string eventId,
        string stage,
        long cycle,
        float worldTime,
        string result,
        bool warning,
        params (string Key, object Value)[] fields
    )
    {
        StringBuilder builder = new StringBuilder("event");
        AppendField(builder, "category", category.ToString());
        AppendField(builder, "eventId", eventId);
        AppendField(builder, "stage", stage);
        AppendField(builder, "cycle", cycle);
        AppendField(builder, "worldTime", worldTime.ToString("F3", CultureInfo.InvariantCulture));
        AppendField(builder, "result", result);

        foreach ((string key, object value) in fields)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                continue;
            }

            AppendField(builder, key, value);
        }

        string formatted = Format(category, builder.ToString(), sanitizeMessage: false);
        if (warning)
        {
            EraWheelMod.LogWarning(formatted);
            return;
        }

        EraWheelMod.LogInfo(formatted);
    }

    private static string Format(EraLogCategory category, string message, bool sanitizeMessage = true)
    {
        return $"[{GetLabel(category)}] {(sanitizeMessage ? SanitizeLogText(message) : message)}";
    }

    private static void AppendField(StringBuilder builder, string key, object value)
    {
        builder.Append(' ');
        builder.Append(CleanValue(key));
        builder.Append('=');
        builder.Append(CleanValue(value?.ToString() ?? string.Empty));
    }

    private static string CleanValue(string value)
    {
        return SanitizeLogText(value);
    }

    private static string SanitizeLogText(string value)
    {
        string sanitized = WindowsAbsolutePathRegex.Replace(value, "<path>");
        sanitized = UnixAbsolutePathRegex.Replace(sanitized, "<path>");
        return sanitized
            .Replace('\r', ' ')
            .Replace('\n', ' ')
            .Replace('=', ':');
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
