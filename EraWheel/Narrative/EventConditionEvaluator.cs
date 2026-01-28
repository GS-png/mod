using System;
using System.Globalization;

namespace EraWheel.Narrative
{
    public static class EventConditionEvaluator
    {
        private static readonly Random Rng = new Random();

        public static bool Evaluate(NarrativeCondition condition, WorldContext ctx)
        {
            if (condition == null || ctx == null)
                return true;

            try
            {
                if (string.Equals(condition.Type, NarrativeCondition.Types.RandomChance, StringComparison.OrdinalIgnoreCase))
                {
                    return EvaluateRandom(condition.Operator, condition.Value);
                }

                var val = GetContextValue(condition.Type, condition.Target, condition.Value, ctx);
                return Compare(val, condition.Operator, condition.Value);
            }
            catch
            {
                return false;
            }
        }

        public static bool EvaluateAll(NarrativeCondition[] conditions, WorldContext ctx, string conditionMode)
        {
            if (conditions == null || conditions.Length == 0)
                return true;

            var useOr = string.Equals(conditionMode, "OR", StringComparison.OrdinalIgnoreCase);
            if (useOr)
            {
                for (var i = 0; i < conditions.Length; i++)
                {
                    if (Evaluate(conditions[i], ctx))
                    {
                        return true;
                    }
                }
                return false;
            }

            for (var i = 0; i < conditions.Length; i++)
            {
                if (!Evaluate(conditions[i], ctx))
                {
                    return false;
                }
            }

            return true;
        }

        private static object GetContextValue(string type, string target, string value, WorldContext ctx)
        {
            var normalizedType = type != null ? type.ToLowerInvariant() : "";
            switch (normalizedType)
            {
                case NarrativeCondition.Types.EraPhase:
                    return ctx.CurrentPhase.ToString();

                case NarrativeCondition.Types.CycleCount:
                    return ctx.CycleCount;

                case NarrativeCondition.Types.SealStrength:
                    return ctx.SealStrength;

                case NarrativeCondition.Types.PhaseDuration:
                    return ctx.PhaseDuration;

                case NarrativeCondition.Types.DemonLordActive:
                    return ctx.DemonLordActive;

                case NarrativeCondition.Types.DemonLordType:
                    return ctx.ActiveDemonLordType;

                case NarrativeCondition.Types.DemonHealthPercent:
                    return ctx.DemonHealthPercent;

                case NarrativeCondition.Types.DemonKillCount:
                    return ctx.DemonKillCount;

                case NarrativeCondition.Types.GeneralsActive:
                    return ctx.GeneralsActive;

                case NarrativeCondition.Types.TotalPopulation:
                    return ctx.Population;

                case NarrativeCondition.Types.CityCount:
                    return ctx.CityCount;

                case NarrativeCondition.Types.CivCount:
                    return ctx.CivCount;

                case NarrativeCondition.Types.HeroCount:
                    return ctx.HeroCount;

                case NarrativeCondition.Types.AntiDemonLevel:
                    return ctx.AntiDemonLevel;

                case NarrativeCondition.Types.Csi:
                    return ctx.Csi;

                case NarrativeCondition.Types.AllianceFormed:
                    return ctx.AllianceFormed;

                case NarrativeCondition.Types.DestinedHeroExists:
                    return ctx.DestinedHeroExists;

                case NarrativeCondition.Types.HeroLevel:
                    return ctx.HeroLevel;

                case NarrativeCondition.Types.WorldAge:
                    return ctx.WorldAge;

                case NarrativeCondition.Types.EventTriggered:
                    return IsEventTriggered(target, value, ctx);

                case NarrativeCondition.Types.NpcExists:
                    return CheckNpcExists(target, value);

                case NarrativeCondition.Types.BuildingExists:
                    return CheckBuildingExists(target, value);

                default:
                    return null;
            }
        }

        private static bool Compare(object leftValue, string op, string rightStr)
        {
            if (leftValue == null)
                return false;

            op = op != null ? op.ToLowerInvariant() : "";

            if (leftValue is bool boolVal)
            {
                var rightBool = ParseBool(rightStr);
                switch (op)
                {
                    case NarrativeCondition.Operators.Equals:
                        return boolVal == rightBool;
                    case NarrativeCondition.Operators.NotEquals:
                        return boolVal != rightBool;
                    default:
                        return false;
                }
            }

            if (leftValue is string strVal)
            {
                switch (op)
                {
                    case NarrativeCondition.Operators.Equals:
                        return string.Equals(strVal, rightStr, StringComparison.OrdinalIgnoreCase);
                    case NarrativeCondition.Operators.NotEquals:
                        return !string.Equals(strVal, rightStr, StringComparison.OrdinalIgnoreCase);
                    case NarrativeCondition.Operators.In:
                        var parts = rightStr.Split(',');
                        foreach (var p in parts)
                        {
                            if (string.Equals(strVal, p.Trim(), StringComparison.OrdinalIgnoreCase))
                                return true;
                        }
                        return false;
                    case NarrativeCondition.Operators.NotIn:
                        var items = rightStr.Split(',');
                        foreach (var p in items)
                        {
                            if (string.Equals(strVal, p.Trim(), StringComparison.OrdinalIgnoreCase))
                                return false;
                        }
                        return true;
                    default:
                        return false;
                }
            }

            var leftNum = ToDouble(leftValue);
            var rightNum = ParseDouble(rightStr);

            switch (op)
            {
                case NarrativeCondition.Operators.Equals:
                    return Math.Abs(leftNum - rightNum) < 0.001;
                case NarrativeCondition.Operators.NotEquals:
                    return Math.Abs(leftNum - rightNum) >= 0.001;
                case NarrativeCondition.Operators.GreaterThan:
                    return leftNum > rightNum;
                case NarrativeCondition.Operators.LessThan:
                    return leftNum < rightNum;
                case NarrativeCondition.Operators.GreaterOrEqual:
                    return leftNum >= rightNum;
                case NarrativeCondition.Operators.LessOrEqual:
                    return leftNum <= rightNum;
                default:
                    return false;
            }
        }

        private static bool EvaluateRandom(string op, string value)
        {
            if (!string.Equals(op, NarrativeCondition.Operators.Success, StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            var chance = ParseDouble(value);
            if (chance <= 1.0)
            {
                return Rng.NextDouble() <= chance;
            }

            return Rng.NextDouble() * 100.0 <= chance;
        }

        private static bool IsEventTriggered(string target, string value, WorldContext ctx)
        {
            if (ctx == null || ctx.TriggeredEvents == null)
            {
                return false;
            }

            var id = !string.IsNullOrEmpty(target) ? target : value;
            if (string.IsNullOrEmpty(id))
            {
                return false;
            }

            return ctx.TriggeredEvents.Contains(id);
        }

#if !ERAWHEEL_SELFTEST
        private static bool CheckNpcExists(string target, string value)
        {
            var id = !string.IsNullOrEmpty(target) ? target : value;
            if (string.IsNullOrEmpty(id)) return false;

            var mapBox = MapBox.instance;
            if (mapBox == null || mapBox.units == null) return false;

            var list = mapBox.units.units_only_alive;
            if (list == null) return false;

            for (var i = 0; i < list.Count; i++)
            {
                var actor = list[i];
                if (actor == null) continue;
                var asset = actor.asset;
                if (asset == null || string.IsNullOrEmpty(asset.id)) continue;
                if (string.Equals(asset.id, id, StringComparison.OrdinalIgnoreCase)) return true;
            }

            return false;
        }

        private static bool CheckBuildingExists(string target, string value)
        {
            var id = !string.IsNullOrEmpty(target) ? target : value;
            if (string.IsNullOrEmpty(id)) return false;

            var mapBox = MapBox.instance;
            if (mapBox == null || mapBox.buildings == null) return false;

            foreach (var building in mapBox.buildings)
            {
                if (building == null) continue;
                var data = building.getData() as BuildingData;
                if (data == null || string.IsNullOrEmpty(data.asset_id)) continue;
                if (string.Equals(data.asset_id, id, StringComparison.OrdinalIgnoreCase)) return true;
            }

            return false;
        }
#else
        private static bool CheckNpcExists(string target, string value)
        {
            return false;
        }

        private static bool CheckBuildingExists(string target, string value)
        {
            return false;
        }
#endif

        private static double ToDouble(object val)
        {
            if (val is int i) return i;
            if (val is float f) return f;
            if (val is double d) return d;
            if (val is long l) return l;
            return 0.0;
        }

        private static double ParseDouble(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0.0;
            double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var result);
            return result;
        }

        private static bool ParseBool(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            return s.Equals("true", StringComparison.OrdinalIgnoreCase) ||
                   s.Equals("1", StringComparison.OrdinalIgnoreCase) ||
                   s.Equals("yes", StringComparison.OrdinalIgnoreCase);
        }
    }
}
