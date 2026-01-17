using System;

namespace EraOfWheel.Core
{
    public static class ErrorHandler
    {
        public static void HandleException(string system, string context, Exception ex)
        {
            Logger.Error(system, $"Exception in {context}", ex);
        }

        public static T SafeExecute<T>(string system, string context, Func<T> action, T defaultValue)
        {
            try
            {
                return action();
            }
            catch (Exception ex)
            {
                HandleException(system, context, ex);
                return defaultValue;
            }
        }

        public static void SafeExecute(string system, string context, Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                HandleException(system, context, ex);
            }
        }

        public static T ParseWithDefault<T>(string value, T defaultValue, Func<string, T> parser)
        {
            if (string.IsNullOrEmpty(value)) return defaultValue;
            
            try
            {
                return parser(value);
            }
            catch
            {
                return defaultValue;
            }
        }

        public static float Clamp(float value, float min, float max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        public static int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
    }
}
