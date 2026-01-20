using System;

namespace EraWheel.Config
{
    [Serializable]
    public class ModConfig
    {
        public string config_version = "1.0.0";
        public CycleConfig cycle = new CycleConfig();
        public DemonLordRootConfig demon_lord = new DemonLordRootConfig();
        public CivilizationRootConfig civilization = new CivilizationRootConfig();
        public LegacyRootConfig legacy = new LegacyRootConfig();
        public AdaptiveDifficultyRootConfig adaptive_difficulty = new AdaptiveDifficultyRootConfig();
        public NarrativeRootConfig narrative = new NarrativeRootConfig();
        public PerformanceRootConfig performance = new PerformanceRootConfig();
        public UiRootConfig ui = new UiRootConfig();
        public DebugRootConfig debug = new DebugRootConfig();
    }

    [Serializable]
    public class CycleConfig
    {
        public CycleTriggerConfig trigger = new CycleTriggerConfig();
        public CycleSealConfig seal = new CycleSealConfig();
        public CyclePhasesConfig phases = new CyclePhasesConfig();
    }

    [Serializable]
    public class CycleTriggerConfig
    {
        public string first_cycle_mode = "prosperity";
        public ProsperityThresholdsConfig prosperity_thresholds = new ProsperityThresholdsConfig();
        public int fixed_age_years = 600;
    }

    [Serializable]
    public class ProsperityThresholdsConfig
    {
        public int population = 3000;
        public int cities = 15;
        public int heroes = 1;
        public int tech_level = 5;
    }

    [Serializable]
    public class CycleSealConfig
    {
        public float initial_strength = 100f;
        public float decay_rate_per_year = 0.5f;
        public VictoryConditionsConfig victory_conditions = new VictoryConditionsConfig();
        public string fallback_condition = "execution";
    }

    [Serializable]
    public class VictoryConditionsConfig
    {
        public bool execution = true;
        public bool ritual = true;
        public bool time_window = true;
        public bool alliance = false;
    }

    [Serializable]
    public class CyclePhasesConfig
    {
        public MinMaxIntConfig omen_duration = new MinMaxIntConfig { min = 20, max = 50 };
        public MinMaxIntConfig awakening_duration = new MinMaxIntConfig { min = 10, max = 30 };
        public int invasion_timeout = 200;
    }

    [Serializable]
    public class MinMaxIntConfig
    {
        public int min;
        public int max;
    }

    [Serializable]
    public class DemonLordRootConfig
    {
        public string awakening_mode = "random";
        public int random_count = 1;
        public string multi_lord_mode = "independent";
        public DemonGrowthConfig growth = new DemonGrowthConfig();
        public DemonGeneralsConfig generals = new DemonGeneralsConfig();
        public DemonLegionConfig legion = new DemonLegionConfig();
        public EnabledLordsConfig enabled_lords = new EnabledLordsConfig();
    }

    [Serializable]
    public class DemonGrowthConfig
    {
        public float cycle_multiplier = 0.25f;
        public float strength_min = 0.6f;
        public float strength_max = 3.0f;
    }

    [Serializable]
    public class DemonGeneralsConfig
    {
        public int initial_count = 2;
        public int per_cycle_increase = 1;
        public int max_count = 6;
        public float betrayal_base_chance = 0.02f;
        public int betrayal_defeat_threshold = 3;
    }

    [Serializable]
    public class DemonLegionConfig
    {
        public int wave_interval_years = 10;
        public int base_units_per_wave = 30;
        public float wave_growth_rate = 0.15f;
        public int max_units_per_wave = 100;
        public int max_alive_units = 200;
        public float elite_rate = 0.1f;
    }

    [Serializable]
    public class EnabledLordsConfig
    {
        public bool void_lord = true;
        public bool plague_lord = true;
        public bool machine_lord = true;
        public bool time_lord = true;
        public bool flame_lord = true;
        public bool abyss_lord = true;
        public bool death_lord = true;
        public bool soul_lord = true;
        public bool nature_lord = true;
        public bool judgment_lord = true;
    }

    [Serializable]
    public class CivilizationRootConfig
    {
        public AntiDemonConfig anti_demon = new AntiDemonConfig();
        public CsiConfig csi = new CsiConfig();
        public AllianceConfig alliance = new AllianceConfig();
        public HeroConfig hero = new HeroConfig();
    }

    [Serializable]
    public class AntiDemonConfig
    {
        public int[] kill_thresholds = new[] { 100, 300, 600, 1000, 1500, 2000, 3000, 5000, 8000, 10000 };
        public float damage_reduction_per_level = 0.05f;
        public float damage_bonus_per_level = 0.1f;
    }

    [Serializable]
    public class CsiConfig
    {
        public float population_weight = 0.25f;
        public float cities_weight = 0.2f;
        public float tech_weight = 0.2f;
        public float anti_demon_weight = 0.2f;
        public float heroes_weight = 0.15f;
    }

    [Serializable]
    public class AllianceConfig
    {
        public float auto_form_threshold = 0.2f;
        public int council_interval_years = 20;
    }

    [Serializable]
    public class HeroConfig
    {
        public float destined_chance = 0.05f;
        public float inheritance_chance = 0.3f;
    }

    [Serializable]
    public class LegacyRootConfig
    {
        public int max_stacks = 5;
        public float[] stack_diminish = new[] { 1.0f, 0.8f, 0.6f, 0.4f, 0.2f };
        public LegacyCurseThresholdConfig curse_threshold = new LegacyCurseThresholdConfig();
    }

    [Serializable]
    public class LegacyCurseThresholdConfig
    {
        public float city_loss_percent = 0.5f;
        public int hero_deaths = 3;
    }

    [Serializable]
    public class AdaptiveDifficultyRootConfig
    {
        public bool enabled = true;
        public float multiplier_min = 0.85f;
        public float multiplier_max = 1.25f;
        public float smoothing_factor = 0.3f;
        public float max_change_per_update = 0.05f;
        public EmergencyThresholdConfig emergency_threshold = new EmergencyThresholdConfig();
    }

    [Serializable]
    public class EmergencyThresholdConfig
    {
        public int population = 500;
        public int civilizations = 1;
    }

    [Serializable]
    public class NarrativeRootConfig
    {
        public NarrativeEventPoolConfig event_pool = new NarrativeEventPoolConfig();
        public NarrativeAiEngineConfig ai_engine = new NarrativeAiEngineConfig();
    }

    [Serializable]
    public class NarrativeEventPoolConfig
    {
        public int trigger_interval_frames = 300;
        public int duplicate_prevention_window = 10;
    }

    [Serializable]
    public class NarrativeAiEngineConfig
    {
        public bool enabled = false;
        public string provider = "openai";
        public string api_url = "";
        public string model = "gpt-4";
        public int permission_level = 2;
        public int timeout_seconds = 30;
        public int retry_count = 3;
        public int max_tokens_per_call = 500;
        public int operation_cooldown_minutes = 5;
        public string confirmation_mode = "manual";
    }

    [Serializable]
    public class PerformanceRootConfig
    {
        public PerformanceUpdateIntervalsConfig update_intervals = new PerformanceUpdateIntervalsConfig();
        public int object_pool_size = 1000;
        public PerformanceWarningThresholdsConfig warning_thresholds = new PerformanceWarningThresholdsConfig();
    }

    [Serializable]
    public class PerformanceUpdateIntervalsConfig
    {
        public int demon_lord = 1;
        public int legion = 5;
        public int hero = 10;
        public int civilization = 30;
        public int ai_story = 300;
    }

    [Serializable]
    public class PerformanceWarningThresholdsConfig
    {
        public float frame_time_ms = 5f;
        public int memory_mb = 100;
    }

    [Serializable]
    public class UiRootConfig
    {
        public float scale = 1f;
        public bool animation_enabled = true;
        public int notification_duration_seconds = 5;
        public string theme = "default";
    }

    [Serializable]
    public class DebugRootConfig
    {
        public bool enabled = false;
        public bool show_internal_vars = false;
        public bool show_performance = false;
        public string log_level = "info";
    }
}
