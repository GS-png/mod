using System;
using System.Reflection;
using UnityEngine;

namespace EraOfWheel.DemonLords.General
{
    public static class ActorUtils
    {
        public static bool TryGetActorPosition2D(Actor actor, out Vector2 pos)
        {
            pos = default(Vector2);
            if (actor == null) return false;

            object posObj = GetMemberValue(actor, "currentPosition")
                           ?? GetMemberValue(actor, "position")
                           ?? GetMemberValue(actor, "pos");
            if (TryConvertToVector2(posObj, out pos)) return true;

            object tileObj = GetMemberValue(actor, "currentTile")
                            ?? GetMemberValue(actor, "tile")
                            ?? GetMemberValue(actor, "current_tile");

            if (tileObj != null)
            {
                var xObj = GetMemberValue(tileObj, "x");
                var yObj = GetMemberValue(tileObj, "y");
                if (xObj != null && yObj != null)
                {
                    try
                    {
                        pos = new Vector2(Convert.ToSingle(xObj), Convert.ToSingle(yObj));
                        return true;
                    }
                    catch
                    {
                    }
                }
            }

            return false;
        }

        public static bool TryHasTrait(Actor actor, string traitId)
        {
            if (actor == null || string.IsNullOrEmpty(traitId)) return false;
            try
            {
                return actor.hasTrait(traitId);
            }
            catch
            {
                return false;
            }
        }

        public static object GetMemberValue(object obj, string name)
        {
            if (obj == null || string.IsNullOrEmpty(name)) return null;

            try
            {
                var t = obj.GetType();
                const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

                var field = t.GetField(name, flags);
                if (field != null) return field.GetValue(obj);

                var prop = t.GetProperty(name, flags);
                if (prop != null) return prop.GetValue(obj, null);

                var method = t.GetMethod(name, flags, null, Type.EmptyTypes, null);
                if (method != null) return method.Invoke(obj, null);

                return null;
            }
            catch
            {
                return null;
            }
        }

        private static bool TryConvertToVector2(object value, out Vector2 pos)
        {
            pos = default(Vector2);
            if (value == null) return false;

            try
            {
                if (value is Vector2 v2)
                {
                    pos = v2;
                    return true;
                }

                if (value is Vector3 v3)
                {
                    pos = new Vector2(v3.x, v3.y);
                    return true;
                }

                if (value is Vector2Int v2i)
                {
                    pos = new Vector2(v2i.x, v2i.y);
                    return true;
                }

                if (value is Vector3Int v3i)
                {
                    pos = new Vector2(v3i.x, v3i.y);
                    return true;
                }
            }
            catch
            {
            }

            return false;
        }
    }
}
