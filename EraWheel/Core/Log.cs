using System;
using System.Reflection;

namespace EraWheel.Core
{
    public static class Log
    {
        public static void Info(string message)
        {
            if (string.IsNullOrEmpty(message)) return;

            try
            {
                var t = Type.GetType("EraWheel.Main, EraWheel", false);
                if (t != null)
                {
                    var m = t.GetMethod("LogInfo", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
                    if (m != null)
                    {
                        m.Invoke(null, new object[] { message });
                        return;
                    }
                }
            }
            catch
            {
            }

            try
            {
                Console.WriteLine(message);
            }
            catch
            {
            }
        }

        public static void Warning(string message)
        {
            if (string.IsNullOrEmpty(message)) return;

            try
            {
                var t = Type.GetType("EraWheel.Main, EraWheel", false);
                if (t != null)
                {
                    var m = t.GetMethod("LogWarning", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
                    if (m != null)
                    {
                        m.Invoke(null, new object[] { message });
                        return;
                    }
                }
            }
            catch
            {
            }

            try
            {
                Console.WriteLine("[WARN] " + message);
            }
            catch
            {
            }
        }

        public static void Error(string message)
        {
            if (string.IsNullOrEmpty(message)) return;

            try
            {
                var t = Type.GetType("EraWheel.Main, EraWheel", false);
                if (t != null)
                {
                    var m = t.GetMethod("LogError", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
                    if (m != null)
                    {
                        m.Invoke(null, new object[] { message });
                        return;
                    }
                }
            }
            catch
            {
            }

            try
            {
                Console.WriteLine("[ERROR] " + message);
            }
            catch
            {
            }
        }
    }
}
