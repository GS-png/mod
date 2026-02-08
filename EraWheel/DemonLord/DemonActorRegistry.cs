#if !ERAWHEEL_SELFTEST
using System.Collections.Generic;

namespace EraWheel.DemonLord
{
    public static class DemonActorRegistry
    {
        private static readonly Dictionary<long, Actor> Actors = new Dictionary<long, Actor>();

        public static void Register(Actor actor)
        {
            if (actor == null) return;
            var id = actor.getID();
            if (id <= 0) return;
            Actors[id] = actor;
        }

        public static void Unregister(Actor actor)
        {
            if (actor == null) return;
            var id = actor.getID();
            if (id <= 0) return;
            Actors.Remove(id);
        }

        public static void MarkAllStatsDirty()
        {
            foreach (var actor in Actors.Values)
            {
                if (actor == null) continue;
                actor.setStatsDirty();
            }
        }
    }
}
#endif
