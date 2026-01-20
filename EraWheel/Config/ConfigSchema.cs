using System;

namespace EraWheel.Config
{
    public static class ConfigSchema
    {
        public static void ValidateAndClamp(ModConfig cfg)
        {
            if (cfg == null) return;

            cfg.config_version = string.IsNullOrEmpty(cfg.config_version) ? "1.0.0" : cfg.config_version;

            if (cfg.cycle == null) cfg.cycle = new CycleConfig();
            if (cfg.cycle.trigger == null) cfg.cycle.trigger = new CycleTriggerConfig();
            if (cfg.cycle.trigger.prosperity_thresholds == null) cfg.cycle.trigger.prosperity_thresholds = new ProsperityThresholdsConfig();
            if (cfg.cycle.seal == null) cfg.cycle.seal = new CycleSealConfig();
            if (cfg.cycle.seal.victory_conditions == null) cfg.cycle.seal.victory_conditions = new VictoryConditionsConfig();
            if (cfg.cycle.phases == null) cfg.cycle.phases = new CyclePhasesConfig();
            if (cfg.cycle.phases.omen_duration == null) cfg.cycle.phases.omen_duration = new MinMaxIntConfig();
            if (cfg.cycle.phases.awakening_duration == null) cfg.cycle.phases.awakening_duration = new MinMaxIntConfig();

            cfg.cycle.trigger.fixed_age_years = ClampInt(cfg.cycle.trigger.fixed_age_years, 100, 10000);

            cfg.cycle.seal.initial_strength = ClampFloat(cfg.cycle.seal.initial_strength, 0f, 100f);
            cfg.cycle.seal.decay_rate_per_year = ClampFloat(cfg.cycle.seal.decay_rate_per_year, 0f, 10f);

            cfg.cycle.phases.omen_duration.min = ClampInt(cfg.cycle.phases.omen_duration.min, 0, 10000);
            cfg.cycle.phases.omen_duration.max = ClampInt(cfg.cycle.phases.omen_duration.max, cfg.cycle.phases.omen_duration.min, 10000);
            cfg.cycle.phases.awakening_duration.min = ClampInt(cfg.cycle.phases.awakening_duration.min, 0, 10000);
            cfg.cycle.phases.awakening_duration.max = ClampInt(cfg.cycle.phases.awakening_duration.max, cfg.cycle.phases.awakening_duration.min, 10000);
            cfg.cycle.phases.invasion_timeout = ClampInt(cfg.cycle.phases.invasion_timeout, 50, 500);

            if (cfg.demon_lord == null) cfg.demon_lord = new DemonLordRootConfig();
            if (cfg.demon_lord.growth == null) cfg.demon_lord.growth = new DemonGrowthConfig();
            if (cfg.demon_lord.generals == null) cfg.demon_lord.generals = new DemonGeneralsConfig();
            if (cfg.demon_lord.legion == null) cfg.demon_lord.legion = new DemonLegionConfig();
            if (cfg.demon_lord.enabled_lords == null) cfg.demon_lord.enabled_lords = new EnabledLordsConfig();

            cfg.demon_lord.random_count = ClampInt(cfg.demon_lord.random_count, 1, 10);

            cfg.demon_lord.growth.cycle_multiplier = ClampFloat(cfg.demon_lord.growth.cycle_multiplier, 0f, 1f);
            cfg.demon_lord.growth.strength_min = ClampFloat(cfg.demon_lord.growth.strength_min, 0.1f, 999f);
            cfg.demon_lord.growth.strength_max = ClampFloat(cfg.demon_lord.growth.strength_max, 0.1f, 5f);
            if (cfg.demon_lord.growth.strength_min > cfg.demon_lord.growth.strength_max)
            {
                cfg.demon_lord.growth.strength_min = cfg.demon_lord.growth.strength_max;
            }

            cfg.demon_lord.generals.initial_count = ClampInt(cfg.demon_lord.generals.initial_count, 0, 6);
            cfg.demon_lord.generals.per_cycle_increase = ClampInt(cfg.demon_lord.generals.per_cycle_increase, 0, 2);
            cfg.demon_lord.generals.max_count = ClampInt(cfg.demon_lord.generals.max_count, 1, 6);
            cfg.demon_lord.generals.betrayal_base_chance = ClampFloat(cfg.demon_lord.generals.betrayal_base_chance, 0f, 0.2f);
            cfg.demon_lord.generals.betrayal_defeat_threshold = Math.Max(1, cfg.demon_lord.generals.betrayal_defeat_threshold);

            cfg.demon_lord.legion.wave_interval_years = ClampInt(cfg.demon_lord.legion.wave_interval_years, 1, 50);
            cfg.demon_lord.legion.base_units_per_wave = ClampInt(cfg.demon_lord.legion.base_units_per_wave, 5, 100);
            cfg.demon_lord.legion.wave_growth_rate = ClampFloat(cfg.demon_lord.legion.wave_growth_rate, 0f, 0.5f);
            cfg.demon_lord.legion.max_units_per_wave = ClampInt(cfg.demon_lord.legion.max_units_per_wave, 10, 200);
            cfg.demon_lord.legion.max_alive_units = ClampInt(cfg.demon_lord.legion.max_alive_units, 50, 500);
            cfg.demon_lord.legion.elite_rate = ClampFloat(cfg.demon_lord.legion.elite_rate, 0f, 0.3f);

            if (!cfg.cycle.seal.victory_conditions.execution && !cfg.cycle.seal.victory_conditions.ritual &&
                !cfg.cycle.seal.victory_conditions.time_window && !cfg.cycle.seal.victory_conditions.alliance)
            {
                cfg.cycle.seal.victory_conditions.execution = true;
                cfg.cycle.seal.fallback_condition = "execution";
            }

            if (cfg.performance == null) cfg.performance = new PerformanceRootConfig();
            if (cfg.performance.update_intervals == null) cfg.performance.update_intervals = new PerformanceUpdateIntervalsConfig();
            if (cfg.performance.warning_thresholds == null) cfg.performance.warning_thresholds = new PerformanceWarningThresholdsConfig();

            cfg.performance.update_intervals.demon_lord = Math.Max(1, cfg.performance.update_intervals.demon_lord);
            cfg.performance.update_intervals.legion = Math.Max(1, cfg.performance.update_intervals.legion);
            cfg.performance.update_intervals.hero = Math.Max(1, cfg.performance.update_intervals.hero);
            cfg.performance.update_intervals.civilization = Math.Max(1, cfg.performance.update_intervals.civilization);
            cfg.performance.update_intervals.ai_story = Math.Max(1, cfg.performance.update_intervals.ai_story);

            cfg.performance.object_pool_size = ClampInt(cfg.performance.object_pool_size, 100, 5000);
            cfg.performance.warning_thresholds.frame_time_ms = Math.Max(0f, cfg.performance.warning_thresholds.frame_time_ms);
            cfg.performance.warning_thresholds.memory_mb = Math.Max(0, cfg.performance.warning_thresholds.memory_mb);

            if (cfg.narrative == null) cfg.narrative = new NarrativeRootConfig();
            if (cfg.narrative.event_pool == null) cfg.narrative.event_pool = new NarrativeEventPoolConfig();
            if (cfg.narrative.ai_engine == null) cfg.narrative.ai_engine = new NarrativeAiEngineConfig();

            cfg.narrative.event_pool.trigger_interval_frames = Math.Max(1, cfg.narrative.event_pool.trigger_interval_frames);
            cfg.narrative.event_pool.duplicate_prevention_window = Math.Max(0, cfg.narrative.event_pool.duplicate_prevention_window);

            cfg.narrative.ai_engine.permission_level = ClampInt(cfg.narrative.ai_engine.permission_level, 1, 5);
            cfg.narrative.ai_engine.timeout_seconds = Math.Max(1, cfg.narrative.ai_engine.timeout_seconds);
            cfg.narrative.ai_engine.retry_count = ClampInt(cfg.narrative.ai_engine.retry_count, 0, 10);
            cfg.narrative.ai_engine.max_tokens_per_call = Math.Max(1, cfg.narrative.ai_engine.max_tokens_per_call);
            cfg.narrative.ai_engine.operation_cooldown_minutes = Math.Max(0, cfg.narrative.ai_engine.operation_cooldown_minutes);

            if (cfg.ui == null) cfg.ui = new UiRootConfig();
            cfg.ui.scale = ClampFloat(cfg.ui.scale, 0.5f, 2f);
            cfg.ui.notification_duration_seconds = Math.Max(0, cfg.ui.notification_duration_seconds);

            if (cfg.debug == null) cfg.debug = new DebugRootConfig();
            cfg.debug.log_level = string.IsNullOrEmpty(cfg.debug.log_level) ? "info" : cfg.debug.log_level;
        }

        private static int ClampInt(int v, int min, int max)
        {
            if (v < min) return min;
            if (v > max) return max;
            return v;
        }

        private static float ClampFloat(float v, float min, float max)
        {
            if (v < min) return min;
            if (v > max) return max;
            return v;
        }
    }
}
