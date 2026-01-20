using System;
using System.Collections.Generic;

namespace EraWheel.Core
{
    public static class EventBus
    {
        private static readonly Dictionary<Type, List<Delegate>> Handlers = new Dictionary<Type, List<Delegate>>();

        public static void Subscribe<T>(Action<T> handler)
        {
            if (handler == null) return;
            var t = typeof(T);
            if (!Handlers.TryGetValue(t, out var list))
            {
                list = new List<Delegate>();
                Handlers[t] = list;
            }

            if (!list.Contains(handler))
            {
                list.Add(handler);
            }
        }

        public static void Unsubscribe<T>(Action<T> handler)
        {
            if (handler == null) return;
            var t = typeof(T);
            if (Handlers.TryGetValue(t, out var list))
            {
                list.Remove(handler);
            }
        }

        public static void Publish<T>(T evt)
        {
            var t = typeof(T);
            if (!Handlers.TryGetValue(t, out var list)) return;

            var snapshot = list.ToArray();
            for (var i = 0; i < snapshot.Length; i++)
            {
                if (snapshot[i] is Action<T> a)
                {
                    try
                    {
                        a(evt);
                    }
                    catch
                    {
                    }
                }
            }
        }

        public static void ClearAll()
        {
            Handlers.Clear();
        }
    }
}
