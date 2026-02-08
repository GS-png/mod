using System;
using System.Reflection;

namespace EraWheel.Core
{
    public static class UnityCompat
    {
        public static float GetScreenWidth()
        {
            try
            {
                var screenType = typeof(UnityEngine.Screen);
                var prop = screenType.GetProperty("width", BindingFlags.Public | BindingFlags.Static);
                if (prop != null)
                {
                    return (float)(int)prop.GetValue(null);
                }
            }
            catch { }
            return 1920f;
        }

        public static float GetScreenHeight()
        {
            try
            {
                var screenType = typeof(UnityEngine.Screen);
                var prop = screenType.GetProperty("height", BindingFlags.Public | BindingFlags.Static);
                if (prop != null)
                {
                    return (float)(int)prop.GetValue(null);
                }
            }
            catch { }
            return 1080f;
        }
    }
}
