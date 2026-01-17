using System;
using System.Collections.Generic;

namespace EraOfWheel.Core.Config
{
    [Serializable]
    public class ModConfig
    {
        public int config_version = 1;
        public CoreConfig core = new CoreConfig();
        public CycleConfig cycle = new CycleConfig();
        public DifficultyConfig difficulty = new DifficultyConfig();
        public DemonLordsConfig demon_lords = new DemonLordsConfig();
        public SealConfig seal = new SealConfig();
        public LegacyConfig legacy = new LegacyConfig();
        public LLMConfig llm = new LLMConfig();
        public UIConfig ui = new UIConfig();
    }

    [Serializable]
    public class CoreConfig
    {
        public bool enabled = true;
        public bool debug_mode = false;
        public string log_level = "Info";
    }

    [Serializable]
    public class CycleConfig
    {
        public TriggerConditions trigger_conditions = new TriggerConditions();
        public int seal_decay_interval_years = 10;
        public float seal_decay_amount = 5f;
    }

    [Serializable]
    public class TriggerConditions
    {
        public string method = "OR";
        public List<TriggerCondition> conditions = new List<TriggerCondition>();
    }

    [Serializable]
    public class TriggerCondition
    {
        public string type;
        public int threshold;
    }

    [Serializable]
    public class DifficultyConfig
    {
        public bool enabled = true;
        public float cycle_growth = 0.25f;
        public AdaptiveConfig adaptive = new AdaptiveConfig();
        public CapsConfig caps = new CapsConfig();
    }

    [Serializable]
    public class AdaptiveConfig
    {
        public bool enabled = true;
        public float min = 0.85f;
        public float max = 1.25f;
        public float smoothing = 0.3f;
    }

    [Serializable]
    public class CapsConfig
    {
        public float min_power = 0.6f;
        public float max_power = 3.0f;
    }

    [Serializable]
    public class DemonLordsConfig
    {
        public VoidLordConfig void_lord = new VoidLordConfig();
        public PlagueMother plague_mother = new PlagueMother();
    }

    [Serializable]
    public class VoidLordConfig
    {
        public bool enabled = true;
        public int unlock_cycle = 1;
        public int void_domain_radius = 1000;
        public float void_domain_damage_percent = 1f;
        public int world_contraction_kill_threshold = 100;
        public float world_contraction_percent = 5f;
        public float min_habitable_percent = 40f;
    }

    [Serializable]
    public class PlagueMother
    {
        public bool enabled = true;
        public int unlock_cycle = 1;
        public float infection_spread_chance = 0.3f;
        public int incubation_years = 5;
        public int toxic_fog_duration_years = 10;
        public int plague_lord_summon_threshold = 100;
    }

    [Serializable]
    public class SealConfig
    {
        public InvasionWindow invasion_window_years = new InvasionWindow();
        public VictoryConditions victory_conditions = new VictoryConditions();
        public FailureConditions failure_conditions = new FailureConditions();
        public RestartCycleConfig restart_cycle = new RestartCycleConfig();
    }

    [Serializable]
    public class InvasionWindow
    {
        public int min = 100;
        public int max = 200;
    }

    [Serializable]
    public class VictoryConditions
    {
        public string mode = "ANY";
        public bool execution = true;
        public bool ritual = true;
        public int ritual_progress_required = 100;
    }

    [Serializable]
    public class FailureConditions
    {
        public float cities_controlled_ratio = 0.6f;
        public int cities_controlled_duration_years = 20;
        public int min_kingdoms = 1;
    }

    [Serializable]
    public class RestartCycleConfig
    {
        public bool enabled = true;
        public float legacy_keep_ratio = 0.5f;
    }

    [Serializable]
    public class LegacyConfig
    {
        public bool enabled = true;
        public int base_military_count = 1;
        public int base_economic_count = 1;
        public int base_tech_count = 1;
        public float legendary_probability = 0.1f;
        public bool curse_enabled = true;
        public float curse_city_damage_threshold = 0.5f;
        public float stacking_diminish_rate = 0.2f;
        public float max_bonus_percent = 100f;
    }

    [Serializable]
    public class LLMConfig
    {
        public bool enabled = false;
        public string provider = "openai_compatible";
        public string api_key = "";
        public string base_url = "https://api.openai.com/v1";
        public string model = "gpt-3.5-turbo";
        public float temperature = 0.8f;
        public int max_tokens = 2000;
        public int timeout_seconds = 30;
        public int max_retries = 3;
        public int permission_level = 2;
        public string fallback_mode = "event_pool";
    }

    [Serializable]
    public class UIConfig
    {
        public bool enabled = true;
        public string hotkey = "F8";
        public int notification_duration_seconds = 5;
        public bool show_debug_tools = false;
    }
}
