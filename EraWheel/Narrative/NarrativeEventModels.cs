using System;

namespace EraWheel.Narrative
{
    public enum NarrativeEventCategory
    {
        Omen,
        Hero,
        Battle,
        System,
        Demon,
        Alliance,
        Legacy,
        General
    }

    public enum NarrativeEventPriority
    {
        Low = 1,
        Normal = 5,
        High = 10,
        Critical = 20
    }

    [Serializable]
    public class NarrativeEvent
    {
        public string Id;
        public NarrativeEventCategory Category;
        public NarrativeEventPriority Priority = NarrativeEventPriority.Normal;
        public int Weight = 100;

        public string TitleKey;
        public string DescriptionKey;

        public NarrativeCondition[] Conditions;
        public NarrativeEffect[] Effects;
        public NarrativeChoice[] Choices;

        public int CooldownYears = 20;
        public bool Unique = false;

        public string[] Tags;
    }

    [Serializable]
    public class NarrativeCondition
    {
        public string Type;
        public string Operator;
        public string Value;

        public static class Types
        {
            public const string Phase = "phase";
            public const string CycleCount = "cycle_count";
            public const string SealStrength = "seal_strength";
            public const string DemonHealth = "demon_health";
            public const string Population = "population";
            public const string CityCount = "city_count";
            public const string HeroCount = "hero_count";
            public const string AntiDemonLevel = "anti_demon_level";
            public const string AllianceFormed = "alliance_formed";
            public const string Random = "random";
        }

        public static class Operators
        {
            public new const string Equals = "eq";
            public const string NotEquals = "ne";
            public const string GreaterThan = "gt";
            public const string LessThan = "lt";
            public const string GreaterOrEqual = "ge";
            public const string LessOrEqual = "le";
            public const string Contains = "contains";
            public const string In = "in";
        }
    }

    [Serializable]
    public class NarrativeEffect
    {
        public string Type;
        public string Target;
        public string Value;

        public static class Types
        {
            public const string AddTrait = "add_trait";
            public const string ModifyStat = "modify_stat";
            public const string SpawnUnit = "spawn_unit";
            public const string TriggerEvent = "trigger_event";
            public const string Notification = "notification";
            public const string Log = "log";
        }
    }

    [Serializable]
    public class NarrativeChoice
    {
        public string Id;
        public string TextKey;
        public NarrativeCondition[] Conditions;
        public NarrativeEffect[] Effects;
        public int Weight = 100;
    }

    [Serializable]
    public class NarrativeEventPoolData
    {
        public string Version = "1.0.0";
        public NarrativeEvent[] Events;
    }

    [Serializable]
    public class WorldContext
    {
        public Core.EraPhase CurrentPhase;
        public int CycleCount;
        public float SealStrength;
        public float DemonHealthPercent;

        public int Population;
        public int CityCount;
        public int HeroCount;
        public int AntiDemonLevel;
        public bool AllianceFormed;

        public long WorldAge;
        public string ActiveDemonLordId;

        public static WorldContext Capture()
        {
            var ctx = new WorldContext();

            try
            {
                ctx.WorldAge = Core.WorldCompat.GetWorldAge();
                ctx.Population = Core.WorldCompat.GetTotalPopulation();
                ctx.CityCount = Core.WorldCompat.GetTotalCities();
                ctx.HeroCount = Core.WorldCompat.GetHeroCount();
            }
            catch
            {
            }

            return ctx;
        }
    }

    [Serializable]
    public class TriggeredEventRecord
    {
        public string EventId;
        public long TriggeredAtWorldAge;
        public int TriggeredAtCycle;
    }
}
