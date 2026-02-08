using System;

namespace EraWheel.Narrative
{
    public enum NarrativeEventCategory
    {
        Unknown,
        Omen,
        Hero,
        Civilization,
        Mystery,
        Battle,
        System
    }

    [Serializable]
    public class NarrativeEvent
    {
        public string Id;
        public string NameKey;
        public string DescriptionKey;
        public string TitleKey;
        public string ImageKey;

        public string Category;
        public int Priority = 50;

        public NarrativeCondition[] Conditions;
        public string ConditionMode = "AND";
        public NarrativeEffect[] Effects;
        public NarrativeChoice[] Choices;

        public int Cooldown;
        public bool Repeatable = true;
        public int MaxTriggers;
    }

    [Serializable]
    public class NarrativeCondition
    {
        public string Type;
        public string Operator;
        public string Value;
        public string Target;

        public static class Types
        {
            public const string EraPhase = "era_phase";
            public const string CycleCount = "cycle_count";
            public const string SealStrength = "seal_strength";
            public const string PhaseDuration = "phase_duration";
            public const string DemonLordActive = "demon_lord_active";
            public const string DemonLordType = "demon_lord_type";
            public const string DemonHealthPercent = "demon_health_percent";
            public const string DemonKillCount = "demon_kill_count";
            public const string GeneralsActive = "generals_active";
            public const string TotalPopulation = "total_population";
            public const string CityCount = "city_count";
            public const string CivCount = "civ_count";
            public const string AntiDemonLevel = "anti_demon_level";
            public const string Csi = "csi";
            public const string AllianceFormed = "alliance_formed";
            public const string HeroCount = "hero_count";
            public const string DestinedHeroExists = "destined_hero_exists";
            public const string HeroLevel = "hero_level";
            public const string WorldAge = "world_age";
            public const string RandomChance = "random_chance";
            public const string EventTriggered = "event_triggered";
            public const string NpcExists = "npc_exists";
            public const string BuildingExists = "building_exists";
        }

        public static class Operators
        {
            public new const string Equals = "eq";
            public const string NotEquals = "ne";
            public const string GreaterThan = "gt";
            public const string LessThan = "lt";
            public const string GreaterOrEqual = "gte";
            public const string LessOrEqual = "lte";
            public const string In = "in";
            public const string NotIn = "not_in";
            public const string Success = "success";
        }
    }

    [Serializable]
    public class NarrativeEffect
    {
        public string Type;
        public string Target;
        public string Value;
        public int Duration;

        public static class Types
        {
            public const string SpawnUnit = "spawn_unit";
            public const string BuffUnit = "buff_unit";
            public const string DamageUnit = "damage_unit";
            public const string HealUnit = "heal_unit";
            public const string ModifyPopulation = "modify_population";
            public const string ModifyResources = "modify_resources";
            public const string ModifyAntiDemon = "modify_anti_demon";
            public const string FormAlliance = "form_alliance";
            public const string ModifyDemonHealth = "modify_demon_health";
            public const string ModifySealStrength = "modify_seal_strength";
            public const string SpawnGeneral = "spawn_general";
            public const string SpawnLegion = "spawn_legion";
            public const string TriggerEvent = "trigger_event";
            public const string ShowNotification = "show_notification";
            public const string AddChronicle = "add_chronicle";
            public const string GrantLegacy = "grant_legacy";
            public const string SetFlag = "set_flag";
            public const string ClearFlag = "clear_flag";
            public const string StartQuest = "start_quest";
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
        public int PhaseDuration;

        public bool DemonLordActive;
        public string ActiveDemonLordId;
        public string ActiveDemonLordType;
        public float DemonHealthPercent;
        public int DemonKillCount;
        public int GeneralsActive;

        public int Population;
        public int CityCount;
        public int CivCount;
        public float Csi;
        public int HeroCount;
        public int AntiDemonLevel;
        public bool AllianceFormed;
        public bool DestinedHeroExists;
        public int HeroLevel;

        public long WorldAge;

        public System.Collections.Generic.ICollection<string> TriggeredEvents;

        public static WorldContext Capture()
        {
            var ctx = new WorldContext();

            try
            {
                ctx.WorldAge = Core.WorldCompat.GetWorldAge();
                ctx.Population = Core.WorldCompat.GetTotalPopulation();
                ctx.CityCount = Core.WorldCompat.GetTotalCities();
                ctx.CivCount = Core.WorldCompat.GetTotalCivilizations();
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
