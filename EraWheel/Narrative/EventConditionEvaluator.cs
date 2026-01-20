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
                var val = GetContextValue(condition.Type, ctx);
                return Compare(val, condition.Operator, condition.Value);
            }
            catch
            {
                return false;
            }
        }

        public static bool EvaluateAll(NarrativeCondition[] conditions, WorldContext ctx)
        {
            if (conditions == null || conditions.Length == 0)
                return true;

            foreach (var c in conditions)
            {
                if (!Evaluate(c, ctx))
                    return false;
            }

            return true;
        }

        private static object GetContextValue(string type, WorldContext ctx)
        {
            switch (type)
            {
                case NarrativeCondition.Types.Phase:
                    return ctx.CurrentPhase.ToString();

                case NarrativeCondition.Types.CycleCount:
                    return ctx.CycleCount;

                case NarrativeCondition.Types.SealStrength:
                    return ctx.SealStrength;

                case NarrativeCondition.Types.DemonHealth:
                    return ctx.DemonHealthPercent;

                case NarrativeCondition.Types.Population:
                    return ctx.Population;

                case NarrativeCondition.Types.CityCount:
                    return ctx.CityCount;

                case NarrativeCondition.Types.HeroCount:
                    return ctx.HeroCount;

                case NarrativeCondition.Types.AntiDemonLevel:
                    return ctx.AntiDemonLevel;

                case NarrativeCondition.Types.AllianceFormed:
                    return ctx.AllianceFormed;

                case NarrativeCondition.Types.Random:
                    return Rng.NextDouble() * 100.0;

                default:
                    return null;
            }
        }

        private static bool Compare(object leftValue, string op, string rightStr)
        {
            if (leftValue == null)
                return false;

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
                    case NarrativeCondition.Operators.Contains:
                        return strVal.IndexOf(rightStr, StringComparison.OrdinalIgnoreCase) >= 0;
                    case NarrativeCondition.Operators.In:
                        var parts = rightStr.Split(',');
                        foreach (var p in parts)
                        {
                            if (string.Equals(strVal, p.Trim(), StringComparison.OrdinalIgnoreCase))
                                return true;
                        }
                        return false;
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
