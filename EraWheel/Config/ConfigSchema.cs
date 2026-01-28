using System;

namespace EraWheel.Config
{
    public static class ConfigSchema
    {
        public static void ValidateAndClamp(ModConfig cfg)
        {
            if (cfg == null) return;

            cfg.config_version = string.IsNullOrEmpty(cfg.config_version) ? "1.0.5" : cfg.config_version;

            if (cfg.cycle == null) cfg.cycle = new CycleConfig();
            if (cfg.cycle.trigger == null) cfg.cycle.trigger = new CycleTriggerConfig();
            if (cfg.cycle.trigger.prosperity_thresholds == null) cfg.cycle.trigger.prosperity_thresholds = new ProsperityThresholdsConfig();
            if (cfg.cycle.seal == null) cfg.cycle.seal = new CycleSealConfig();
            if (cfg.cycle.seal.victory_conditions == null) cfg.cycle.seal.victory_conditions = new VictoryConditionsConfig();
            if (cfg.cycle.phases == null) cfg.cycle.phases = new CyclePhasesConfig();
            if (cfg.cycle.phases.omen_duration == null) cfg.cycle.phases.omen_duration = new MinMaxIntConfig();
            if (cfg.cycle.phases.awakening_duration == null) cfg.cycle.phases.awakening_duration = new MinMaxIntConfig();

            cfg.cycle.trigger.first_cycle_mode = NormalizeFirstCycleMode(cfg.cycle.trigger.first_cycle_mode);
            cfg.cycle.trigger.prosperity_mode = NormalizeProsperityMode(cfg.cycle.trigger.prosperity_mode);
            cfg.cycle.trigger.fixed_age_years = ClampInt(cfg.cycle.trigger.fixed_age_years, 100, 10000);
            cfg.cycle.trigger.prosperity_thresholds.population = Math.Max(0, cfg.cycle.trigger.prosperity_thresholds.population);
            cfg.cycle.trigger.prosperity_thresholds.cities = Math.Max(0, cfg.cycle.trigger.prosperity_thresholds.cities);
            cfg.cycle.trigger.prosperity_thresholds.heroes = Math.Max(0, cfg.cycle.trigger.prosperity_thresholds.heroes);
            cfg.cycle.trigger.prosperity_thresholds.tech_level = Math.Max(0, cfg.cycle.trigger.prosperity_thresholds.tech_level);

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
            if (cfg.demon_lord.stats == null) cfg.demon_lord.stats = new DemonUnitStatsConfig();
            if (cfg.demon_lord.stats.lords == null) cfg.demon_lord.stats.lords = new DemonLordStatsConfig();
            if (cfg.demon_lord.stats.general_roles == null) cfg.demon_lord.stats.general_roles = new GeneralRoleStatsConfig();
            if (cfg.demon_lord.stats.legion_units == null) cfg.demon_lord.stats.legion_units = new LegionUnitStatsConfig();
            if (cfg.demon_lord.enabled_lords == null) cfg.demon_lord.enabled_lords = new EnabledLordsConfig();

            cfg.demon_lord.awakening_mode = NormalizeAwakeningMode(cfg.demon_lord.awakening_mode);
            cfg.demon_lord.multi_lord_mode = NormalizeMultiLordMode(cfg.demon_lord.multi_lord_mode);
            cfg.demon_lord.random_count = ClampInt(cfg.demon_lord.random_count, 1, 10);

            cfg.demon_lord.growth.cycle_multiplier = ClampFloat(cfg.demon_lord.growth.cycle_multiplier, 0f, 1f);
            cfg.demon_lord.growth.strength_min = ClampFloat(cfg.demon_lord.growth.strength_min, 0.1f, 5f);
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

            ClampUnitStats(cfg.demon_lord.stats.lords.void_lord);
            ClampUnitStats(cfg.demon_lord.stats.lords.plague_lord);
            ClampUnitStats(cfg.demon_lord.stats.lords.machine_lord);
            ClampUnitStats(cfg.demon_lord.stats.lords.time_lord);
            ClampUnitStats(cfg.demon_lord.stats.lords.flame_lord);
            ClampUnitStats(cfg.demon_lord.stats.lords.abyss_lord);
            ClampUnitStats(cfg.demon_lord.stats.lords.death_lord);
            ClampUnitStats(cfg.demon_lord.stats.lords.soul_lord);
            ClampUnitStats(cfg.demon_lord.stats.lords.nature_lord);
            ClampUnitStats(cfg.demon_lord.stats.lords.judgment_lord);

            ClampUnitStats(cfg.demon_lord.stats.general_roles.vanguard);
            ClampUnitStats(cfg.demon_lord.stats.general_roles.tank);
            ClampUnitStats(cfg.demon_lord.stats.general_roles.dps);
            ClampUnitStats(cfg.demon_lord.stats.general_roles.support);
            ClampUnitStats(cfg.demon_lord.stats.general_roles.elite);

            ClampUnitStats(cfg.demon_lord.stats.legion_units.legion_vanguard);
            ClampUnitStats(cfg.demon_lord.stats.legion_units.legion_main);
            ClampUnitStats(cfg.demon_lord.stats.legion_units.legion_elite);
            ClampUnitStats(cfg.demon_lord.stats.legion_units.legion_ultimate);

            if (!cfg.cycle.seal.victory_conditions.execution && !cfg.cycle.seal.victory_conditions.ritual &&
                !cfg.cycle.seal.victory_conditions.time_window && !cfg.cycle.seal.victory_conditions.alliance)
            {
                cfg.cycle.seal.victory_conditions.execution = true;
                cfg.cycle.seal.fallback_condition = "execution";
            }

            if (cfg.civilization == null) cfg.civilization = new CivilizationRootConfig();
            if (cfg.civilization.anti_demon == null) cfg.civilization.anti_demon = new AntiDemonConfig();
            if (cfg.civilization.anti_demon.kill_thresholds == null || cfg.civilization.anti_demon.kill_thresholds.Length == 0)
            {
                cfg.civilization.anti_demon.kill_thresholds = new AntiDemonConfig().kill_thresholds;
            }
            else
            {
                for (var i = 0; i < cfg.civilization.anti_demon.kill_thresholds.Length; i++)
                {
                    if (cfg.civilization.anti_demon.kill_thresholds[i] < 0)
                    {
                        cfg.civilization.anti_demon.kill_thresholds[i] = 0;
                    }
                }
            }

            if (cfg.civilization.csi == null) cfg.civilization.csi = new CsiConfig();

            if (cfg.civilization.alliance == null) cfg.civilization.alliance = new AllianceConfig();
            cfg.civilization.alliance.auto_form_threshold = ClampFloat(cfg.civilization.alliance.auto_form_threshold, 0f, 1f);

            if (cfg.civilization.hero == null) cfg.civilization.hero = new HeroConfig();
            cfg.civilization.hero.destined_chance = ClampFloat(cfg.civilization.hero.destined_chance, 0f, 0.2f);
            cfg.civilization.hero.inheritance_chance = ClampFloat(cfg.civilization.hero.inheritance_chance, 0f, 1f);

            if (cfg.legacy == null) cfg.legacy = new LegacyRootConfig();
            if (cfg.legacy.curse_threshold == null) cfg.legacy.curse_threshold = new LegacyCurseThresholdConfig();
            cfg.legacy.max_stacks = ClampInt(cfg.legacy.max_stacks, 1, 10);
            if (cfg.legacy.stack_diminish == null || cfg.legacy.stack_diminish.Length == 0)
            {
                cfg.legacy.stack_diminish = new LegacyRootConfig().stack_diminish;
            }

            if (cfg.adaptive_difficulty == null) cfg.adaptive_difficulty = new AdaptiveDifficultyRootConfig();
            if (cfg.adaptive_difficulty.emergency_threshold == null) cfg.adaptive_difficulty.emergency_threshold = new EmergencyThresholdConfig();
            cfg.adaptive_difficulty.smoothing_factor = ClampFloat(cfg.adaptive_difficulty.smoothing_factor, 0f, 1f);
            if (cfg.adaptive_difficulty.multiplier_min > cfg.adaptive_difficulty.multiplier_max)
            {
                cfg.adaptive_difficulty.multiplier_min = cfg.adaptive_difficulty.multiplier_max;
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

            cfg.narrative.ai_engine.provider = NormalizeAiProvider(cfg.narrative.ai_engine.provider);
            cfg.narrative.ai_engine.confirmation_mode = NormalizeConfirmationMode(cfg.narrative.ai_engine.confirmation_mode);
            cfg.narrative.ai_engine.permission_level = ClampInt(cfg.narrative.ai_engine.permission_level, 1, 5);
            cfg.narrative.ai_engine.timeout_seconds = Math.Max(1, cfg.narrative.ai_engine.timeout_seconds);
            cfg.narrative.ai_engine.retry_count = ClampInt(cfg.narrative.ai_engine.retry_count, 0, 10);
            cfg.narrative.ai_engine.max_tokens_per_call = Math.Max(1, cfg.narrative.ai_engine.max_tokens_per_call);
            cfg.narrative.ai_engine.operation_cooldown_minutes = Math.Max(0, cfg.narrative.ai_engine.operation_cooldown_minutes);

            if (cfg.expansion == null) cfg.expansion = new ExpansionRootConfig();
            if (cfg.expansion.ragnarok == null) cfg.expansion.ragnarok = new RagnarokExpansionConfig();
            if (cfg.expansion.multi_lord == null) cfg.expansion.multi_lord = new MultiLordExpansionConfig();

            cfg.expansion.ragnarok.required_civilizations = ClampInt(cfg.expansion.ragnarok.required_civilizations, 1, 50);
            cfg.expansion.ragnarok.duration_years = ClampInt(cfg.expansion.ragnarok.duration_years, 1, 500);

            cfg.expansion.multi_lord.min_awaken_count = ClampInt(cfg.expansion.multi_lord.min_awaken_count, 2, 10);
            cfg.expansion.multi_lord.max_awaken_count = ClampInt(cfg.expansion.multi_lord.max_awaken_count, cfg.expansion.multi_lord.min_awaken_count, 10);

            if (cfg.ui == null) cfg.ui = new UiRootConfig();
            cfg.ui.scale = ClampFloat(cfg.ui.scale, 0.5f, 2f);
            cfg.ui.notification_duration_seconds = Math.Max(0, cfg.ui.notification_duration_seconds);
            cfg.ui.theme = NormalizeTheme(cfg.ui.theme);

            if (cfg.debug == null) cfg.debug = new DebugRootConfig();
            cfg.debug.log_level = NormalizeLogLevel(cfg.debug.log_level);
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

        private static void ClampUnitStats(UnitStatMultiplierConfig cfg)
        {
            if (cfg == null) return;
            cfg.health = ClampFloat(cfg.health, 0.1f, 20f);
            cfg.damage = ClampFloat(cfg.damage, 0.1f, 20f);
            cfg.armor = ClampFloat(cfg.armor, 0.1f, 20f);
            cfg.speed = ClampFloat(cfg.speed, 0.1f, 20f);
        }

        private static string NormalizeProsperityMode(string value)
        {
            if (string.IsNullOrEmpty(value)) return "any";

            if (string.Equals(value, "all", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(value, "and", StringComparison.OrdinalIgnoreCase))
            {
                return "all";
            }

            if (string.Equals(value, "any", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(value, "or", StringComparison.OrdinalIgnoreCase))
            {
                return "any";
            }

            return "any";
        }

        private static string NormalizeMultiLordMode(string value)
        {
            if (string.IsNullOrEmpty(value)) return "independent";

            if (string.Equals(value, "independent", StringComparison.OrdinalIgnoreCase)) return "independent";
            if (string.Equals(value, "alliance", StringComparison.OrdinalIgnoreCase)) return "alliance";
            if (string.Equals(value, "civil_war", StringComparison.OrdinalIgnoreCase)) return "civil_war";
            if (string.Equals(value, "auto_judge", StringComparison.OrdinalIgnoreCase)) return "auto_judge";

            return "independent";
        }

        private static string NormalizeAwakeningMode(string value)
        {
            if (string.IsNullOrEmpty(value)) return "random";

            if (string.Equals(value, "specified", StringComparison.OrdinalIgnoreCase)) return "specified";
            if (string.Equals(value, "random", StringComparison.OrdinalIgnoreCase)) return "random";

            return "random";
        }

        private static string NormalizeFirstCycleMode(string value)
        {
            if (string.IsNullOrEmpty(value)) return "prosperity";

            if (string.Equals(value, "prosperity", StringComparison.OrdinalIgnoreCase)) return "prosperity";
            if (string.Equals(value, "fixed_age", StringComparison.OrdinalIgnoreCase)) return "fixed_age";
            if (string.Equals(value, "manual", StringComparison.OrdinalIgnoreCase)) return "manual";

            return "prosperity";
        }

        private static string NormalizeAiProvider(string value)
        {
            if (string.IsNullOrEmpty(value)) return "openai";

            if (string.Equals(value, "openai", StringComparison.OrdinalIgnoreCase)) return "openai";
            if (string.Equals(value, "claude", StringComparison.OrdinalIgnoreCase)) return "claude";
            if (string.Equals(value, "ollama", StringComparison.OrdinalIgnoreCase)) return "ollama";
            if (string.Equals(value, "custom", StringComparison.OrdinalIgnoreCase)) return "custom";

            return "openai";
        }

        private static string NormalizeConfirmationMode(string value)
        {
            if (string.IsNullOrEmpty(value)) return "manual";

            if (string.Equals(value, "auto", StringComparison.OrdinalIgnoreCase)) return "auto";
            if (string.Equals(value, "manual", StringComparison.OrdinalIgnoreCase)) return "manual";
            if (string.Equals(value, "suggest_only", StringComparison.OrdinalIgnoreCase)) return "suggest_only";

            return "manual";
        }

        private static string NormalizeTheme(string value)
        {
            if (string.IsNullOrEmpty(value)) return "default";

            if (string.Equals(value, "default", StringComparison.OrdinalIgnoreCase)) return "default";
            if (string.Equals(value, "dark", StringComparison.OrdinalIgnoreCase)) return "dark";
            if (string.Equals(value, "light", StringComparison.OrdinalIgnoreCase)) return "light";

            return "default";
        }

        private static string NormalizeLogLevel(string value)
        {
            if (string.IsNullOrEmpty(value)) return "info";

            if (string.Equals(value, "debug", StringComparison.OrdinalIgnoreCase)) return "debug";
            if (string.Equals(value, "info", StringComparison.OrdinalIgnoreCase)) return "info";
            if (string.Equals(value, "warning", StringComparison.OrdinalIgnoreCase)) return "warning";
            if (string.Equals(value, "error", StringComparison.OrdinalIgnoreCase)) return "error";

            return "info";
        }
    }
}
