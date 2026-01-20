using System;
using System.Linq;
using System.Reflection;

namespace EraWheel.Core
{
    internal static class CompatReflection
    {
        public static Type FindType(string fullName)
        {
            if (string.IsNullOrEmpty(fullName)) return null;

            var t = Type.GetType(fullName, false);
            if (t != null) return t;

            var asmNameGuess = fullName.Split(',').Skip(1).FirstOrDefault();
            if (!string.IsNullOrEmpty(asmNameGuess))
            {
                t = Type.GetType(fullName + ", " + asmNameGuess.Trim(), false);
                if (t != null) return t;
            }

            var asms = AppDomain.CurrentDomain.GetAssemblies();
            for (var i = 0; i < asms.Length; i++)
            {
                try
                {
                    t = asms[i].GetType(fullName, false);
                    if (t != null) return t;
                }
                catch
                {
                }
            }

            return null;
        }

        public static Type FindTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName)) return null;

            var asms = AppDomain.CurrentDomain.GetAssemblies();
            for (var i = 0; i < asms.Length; i++)
            {
                Type[] types;
                try
                {
                    types = asms[i].GetTypes();
                }
                catch
                {
                    continue;
                }

                for (var j = 0; j < types.Length; j++)
                {
                    if (types[j] != null && string.Equals(types[j].Name, typeName, StringComparison.Ordinal))
                    {
                        return types[j];
                    }
                }
            }

            return null;
        }

        public static object InvokeStatic(Type type, string methodName, object[] args)
        {
            if (type == null || string.IsNullOrEmpty(methodName)) return null;

            try
            {
                var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
                var m = type.GetMethod(methodName, flags);
                if (m == null) return null;
                return m.Invoke(null, args);
            }
            catch
            {
                return null;
            }
        }

        public static bool TryAddStaticEventHandler(Type type, string eventName, Delegate handler)
        {
            if (type == null || string.IsNullOrEmpty(eventName) || handler == null) return false;

            try
            {
                var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
                var e = type.GetEvent(eventName, flags);
                if (e == null) return false;

                if (e.EventHandlerType == handler.GetType())
                {
                    e.AddEventHandler(null, handler);
                    return true;
                }

                var d = Delegate.CreateDelegate(e.EventHandlerType, handler.Target, handler.Method);
                e.AddEventHandler(null, d);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
