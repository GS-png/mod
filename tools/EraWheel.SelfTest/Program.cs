using System;
using System.Collections.Generic;
using EraWheel.Config;
using EraWheel.Civilization;
using EraWheel.Core;
using EraWheel.Core.ExtensionModules;
using EraWheel.Data;
using EraWheel.DemonLord;
using EraWheel.Narrative;
using System.IO;

internal static class Program
{
    private static void Main()
    {
        WorldCompat.MockEnabled = true;
        WorldCompat.MockCivilizations = 1;

        EventBus.ClearAll();

        var cfg = new ModConfig();

        cfg.cycle.trigger.first_cycle_mode = "prosperity";
        cfg.cycle.trigger.prosperity_thresholds.population = 1;
        cfg.cycle.trigger.prosperity_thresholds.cities = 1;
        cfg.cycle.trigger.prosperity_thresholds.heroes = 0;
        cfg.cycle.trigger.prosperity_thresholds.tech_level = 0;

        cfg.cycle.seal.initial_strength = 35f;
        cfg.cycle.seal.decay_rate_per_year = 2f;

        cfg.cycle.seal.victory_conditions.execution = false;
        cfg.cycle.seal.victory_conditions.ritual = false;
        cfg.cycle.seal.victory_conditions.time_window = false;
        cfg.cycle.seal.victory_conditions.alliance = true;

        cfg.cycle.phases.omen_duration.min = 1;
        cfg.cycle.phases.omen_duration.max = 1;
        cfg.cycle.phases.awakening_duration.min = 1;
        cfg.cycle.phases.awakening_duration.max = 1;
        cfg.cycle.phases.invasion_timeout = 200;

        cfg.demon_lord.legion.wave_interval_years = 1;
        cfg.demon_lord.legion.base_units_per_wave = 10;
        cfg.demon_lord.legion.wave_growth_rate = 0.0f;
        cfg.demon_lord.legion.max_units_per_wave = 20;
        cfg.demon_lord.legion.max_alive_units = 25;
        cfg.demon_lord.legion.elite_rate = 0.0f;

        cfg.demon_lord.generals.betrayal_defeat_threshold = 3;
        cfg.demon_lord.generals.betrayal_base_chance = 1.0f;

        cfg.civilization.anti_demon.kill_thresholds = new[] { 5, 10, 20, 30, 40, 50, 60, 70, 80, 90 };
        cfg.civilization.anti_demon.damage_bonus_per_level = 0.1f;
        cfg.civilization.anti_demon.damage_reduction_per_level = 0.05f;

        cfg.civilization.alliance.auto_form_threshold = 0.2f;
        cfg.civilization.alliance.council_interval_years = 5;

        cfg.debug.enabled = true;

        ConfigSchema.ValidateAndClamp(cfg);

        var fallbackCfg = new ModConfig();
        fallbackCfg.cycle.seal.victory_conditions.execution = false;
        fallbackCfg.cycle.seal.victory_conditions.ritual = false;
        fallbackCfg.cycle.seal.victory_conditions.time_window = false;
        fallbackCfg.cycle.seal.victory_conditions.alliance = false;
        ConfigSchema.ValidateAndClamp(fallbackCfg);

        if (!fallbackCfg.cycle.seal.victory_conditions.execution ||
            fallbackCfg.cycle.seal.fallback_condition != "execution")
        {
            throw new Exception("SelfTest failed: fallback victory condition should re-enable execution.");
        }

        var nullSectionCfg = new ModConfig();
        nullSectionCfg.civilization = null;
        nullSectionCfg.legacy = null;
        nullSectionCfg.adaptive_difficulty = null;
        nullSectionCfg.ui = null;
        nullSectionCfg.debug = null;
        nullSectionCfg.narrative = null;
        nullSectionCfg.demon_lord = null;
        nullSectionCfg.cycle = null;
        ConfigSchema.ValidateAndClamp(nullSectionCfg);
        if (nullSectionCfg.civilization == null ||
            nullSectionCfg.civilization.anti_demon == null ||
            nullSectionCfg.legacy == null ||
            nullSectionCfg.adaptive_difficulty == null ||
            nullSectionCfg.ui == null ||
            nullSectionCfg.debug == null ||
            nullSectionCfg.narrative == null ||
            nullSectionCfg.demon_lord == null ||
            nullSectionCfg.demon_lord.stats == null ||
            nullSectionCfg.demon_lord.stats.lords == null ||
            nullSectionCfg.demon_lord.stats.general_roles == null ||
            nullSectionCfg.demon_lord.stats.legion_units == null ||
            nullSectionCfg.cycle == null)
        {
            throw new Exception("SelfTest failed: ConfigSchema should fill missing config sections.");
        }

        var normalizeEnumsCfg = new ModConfig();
        normalizeEnumsCfg.demon_lord.awakening_mode = "SPECIFIED";
        normalizeEnumsCfg.narrative.ai_engine.provider = "CUSTOM";
        normalizeEnumsCfg.narrative.ai_engine.confirmation_mode = "AUTO";
        normalizeEnumsCfg.ui.theme = "DARK";
        normalizeEnumsCfg.debug.log_level = "WARNING";
        ConfigSchema.ValidateAndClamp(normalizeEnumsCfg);
        if (normalizeEnumsCfg.demon_lord.awakening_mode != "specified" ||
            normalizeEnumsCfg.narrative.ai_engine.provider != "custom" ||
            normalizeEnumsCfg.narrative.ai_engine.confirmation_mode != "auto" ||
            normalizeEnumsCfg.ui.theme != "dark" ||
            normalizeEnumsCfg.debug.log_level != "warning")
        {
            throw new Exception("SelfTest failed: enum normalization did not apply expected defaults.");
        }

        var heroClampCfg = new ModConfig();
        heroClampCfg.civilization.hero.destined_chance = 5f;
        heroClampCfg.civilization.hero.inheritance_chance = -1f;
        ConfigSchema.ValidateAndClamp(heroClampCfg);
        if (heroClampCfg.civilization.hero.destined_chance > 0.2f ||
            heroClampCfg.civilization.hero.inheritance_chance < 0f)
        {
            throw new Exception("SelfTest failed: hero config clamping did not apply bounds.");
        }

        var statClampCfg = new ModConfig();
        statClampCfg.demon_lord.stats.legion_units.legion_vanguard.health = 0f;
        statClampCfg.demon_lord.stats.legion_units.legion_vanguard.damage = 50f;
        ConfigSchema.ValidateAndClamp(statClampCfg);
        if (statClampCfg.demon_lord.stats.legion_units.legion_vanguard.health < 0.1f ||
            statClampCfg.demon_lord.stats.legion_units.legion_vanguard.damage > 20f)
        {
            throw new Exception("SelfTest failed: unit stat multipliers were not clamped.");
        }

        var orCfg = new ModConfig();
        orCfg.cycle.trigger.prosperity_thresholds.population = 100;
        orCfg.cycle.trigger.prosperity_thresholds.cities = 100;
        orCfg.cycle.trigger.prosperity_thresholds.heroes = 5;
        orCfg.cycle.trigger.prosperity_thresholds.tech_level = 5;
        ConfigSchema.ValidateAndClamp(orCfg);

        var orTracker = new ProsperityTracker();
        orTracker.Enable();
        WorldCompat.MockPopulation = 100;
        WorldCompat.MockCities = 0;
        WorldCompat.MockHeroes = 0;
        WorldCompat.MockTechLevel = 0;
        orTracker.Update(orCfg);
        if (!orTracker.ProsperityReached)
        {
            throw new Exception("SelfTest failed: prosperity should trigger when any threshold is met.");
        }

        var andCfg = new ModConfig();
        andCfg.cycle.trigger.prosperity_mode = "all";
        andCfg.cycle.trigger.prosperity_thresholds.population = 10;
        andCfg.cycle.trigger.prosperity_thresholds.cities = 10;
        andCfg.cycle.trigger.prosperity_thresholds.heroes = 1;
        andCfg.cycle.trigger.prosperity_thresholds.tech_level = 1;
        ConfigSchema.ValidateAndClamp(andCfg);

        var andTracker = new ProsperityTracker();
        andTracker.Enable();
        WorldCompat.MockPopulation = 10;
        WorldCompat.MockCities = 0;
        WorldCompat.MockHeroes = 1;
        WorldCompat.MockTechLevel = 1;
        andTracker.Update(andCfg);
        if (andTracker.ProsperityReached)
        {
            throw new Exception("SelfTest failed: prosperity(all) should wait for all known thresholds.");
        }

        WorldCompat.MockCities = 10;
        andTracker.Update(andCfg);
        if (!andTracker.ProsperityReached)
        {
            throw new Exception("SelfTest failed: prosperity(all) should trigger once all known thresholds are met.");
        }

        var ritualCfg = new ModConfig();
        ritualCfg.cycle.seal.victory_conditions.execution = false;
        ritualCfg.cycle.seal.victory_conditions.ritual = true;
        ritualCfg.cycle.seal.victory_conditions.time_window = false;
        ritualCfg.cycle.seal.victory_conditions.alliance = false;
        ConfigSchema.ValidateAndClamp(ritualCfg);

        var ritualSeal = new SealSystem();
        ritualSeal.Reset(ritualCfg, 0);
        EventBus.Publish(new SealRitualCompletedEvent { WorldTime = 0 });
        if (!ritualSeal.CheckSealSuccess(ritualCfg, 0, 50f))
        {
            throw new Exception("SelfTest failed: ritual seal condition did not trigger.");
        }

        var executionCfg = new ModConfig();
        executionCfg.cycle.seal.victory_conditions.execution = true;
        executionCfg.cycle.seal.victory_conditions.ritual = false;
        executionCfg.cycle.seal.victory_conditions.time_window = false;
        executionCfg.cycle.seal.victory_conditions.alliance = false;
        ConfigSchema.ValidateAndClamp(executionCfg);

        var executionSeal = new SealSystem();
        executionSeal.Reset(executionCfg, 0);
        if (!executionSeal.CheckSealSuccess(executionCfg, 0, 0f))
        {
            throw new Exception("SelfTest failed: execution seal condition did not trigger.");
        }

        var timeCfg = new ModConfig();
        timeCfg.cycle.seal.victory_conditions.execution = false;
        timeCfg.cycle.seal.victory_conditions.ritual = false;
        timeCfg.cycle.seal.victory_conditions.time_window = true;
        timeCfg.cycle.seal.victory_conditions.alliance = false;
        ConfigSchema.ValidateAndClamp(timeCfg);

        var timeSeal = new SealSystem();
        timeSeal.Reset(timeCfg, 0);
        if (timeSeal.CheckSealSuccess(timeCfg, 100, 50f))
        {
            throw new Exception("SelfTest failed: time_window should require Weakening start.");
        }
        timeSeal.MarkWeakeningStart(0);
        if (timeSeal.CheckSealSuccess(timeCfg, 49, 50f))
        {
            throw new Exception("SelfTest failed: time_window should not trigger before 50 years.");
        }
        if (!timeSeal.CheckSealSuccess(timeCfg, 50, 50f))
        {
            throw new Exception("SelfTest failed: time_window did not trigger after 50 years.");
        }

        WorldCompat.MockWorldAge = 0;
        var loadWeakeningCycle = new CycleManager();
        loadWeakeningCycle.LoadSaveData(new CycleData
        {
            CycleCount = 1,
            CurrentPhase = EraPhase.Weakening,
            SealStrength = 50f,
            PhaseStartWorldAge = 0,
            OmenTargetYears = 1,
            AwakeningTargetYears = 1,
            DemonHealthPercent = 100f
        }, timeCfg);
        WorldCompat.MockWorldAge = 49;
        loadWeakeningCycle.Update(timeCfg);
        if (loadWeakeningCycle.CurrentPhase != EraPhase.Weakening)
        {
            throw new Exception("SelfTest failed: loaded Weakening should stay until time_window is met.");
        }
        WorldCompat.MockWorldAge = 50;
        loadWeakeningCycle.Update(timeCfg);
        if (loadWeakeningCycle.CurrentPhase != EraPhase.Resealed)
        {
            throw new Exception("SelfTest failed: loaded Weakening should reseal after time_window.");
        }

        var allianceCfg = new ModConfig();
        allianceCfg.cycle.seal.victory_conditions.execution = false;
        allianceCfg.cycle.seal.victory_conditions.ritual = false;
        allianceCfg.cycle.seal.victory_conditions.time_window = false;
        allianceCfg.cycle.seal.victory_conditions.alliance = true;
        ConfigSchema.ValidateAndClamp(allianceCfg);

        var allianceSeal = new SealSystem();
        allianceSeal.Reset(allianceCfg, 0);
        if (allianceSeal.CheckSealSuccess(allianceCfg, 0, 50f))
        {
            throw new Exception("SelfTest failed: alliance seal should not trigger without progress.");
        }
        EventBus.Publish(new AllianceSealProgressEvent { WorldTime = 0, Progress = 100f });
        if (!allianceSeal.CheckSealSuccess(allianceCfg, 0, 50f))
        {
            throw new Exception("SelfTest failed: alliance seal did not trigger at 100%.");
        }

        var allianceBaselineCfg = new ModConfig();
        allianceBaselineCfg.civilization.alliance.auto_form_threshold = 0.5f;
        ConfigSchema.ValidateAndClamp(allianceBaselineCfg);

        var baselineCycle = new CycleManager();
        baselineCycle.Initialize(allianceBaselineCfg);
        baselineCycle.ForcePhase(EraPhase.Invasion);

        var baselineAlliance = new AllianceSystem();
        baselineAlliance.Initialize(allianceBaselineCfg);

        WorldCompat.MockWorldAge = 0;
        WorldCompat.MockCities = -1;
        baselineCycle.Update(allianceBaselineCfg);
        baselineAlliance.Update(allianceBaselineCfg, baselineCycle);

        WorldCompat.MockWorldAge = 1;
        WorldCompat.MockCities = 10;
        baselineCycle.Update(allianceBaselineCfg);
        baselineAlliance.Update(allianceBaselineCfg, baselineCycle);

        WorldCompat.MockWorldAge = 2;
        WorldCompat.MockCities = 4;
        baselineCycle.Update(allianceBaselineCfg);
        baselineAlliance.Update(allianceBaselineCfg, baselineCycle);

        if (!baselineAlliance.State.Formed)
        {
            throw new Exception("SelfTest failed: alliance baseline should form after data becomes available.");
        }

        var sealCfg = new ModConfig();
        sealCfg.cycle.seal.initial_strength = 25f;
        sealCfg.cycle.trigger.first_cycle_mode = "manual";
        ConfigSchema.ValidateAndClamp(sealCfg);
        WorldCompat.MockWorldAge = 0;

        var sealCycle = new CycleManager();
        sealCycle.Initialize(sealCfg);
        sealCycle.Update(sealCfg);
        if (sealCycle.CurrentPhase != EraPhase.Sealed)
        {
            throw new Exception("SelfTest failed: first_cycle_mode=manual should not auto trigger Omen.");
        }

        sealCycle.ForceCycleCount(1);
        sealCycle.Update(sealCfg);
        if (sealCycle.CurrentPhase != EraPhase.Omen)
        {
            throw new Exception("SelfTest failed: seal strength < 30 should enter Omen after first cycle.");
        }

        var prosperityCfg = new ModConfig();
        prosperityCfg.cycle.seal.initial_strength = 25f;
        prosperityCfg.cycle.trigger.first_cycle_mode = "prosperity";
        prosperityCfg.cycle.trigger.prosperity_thresholds.population = 9999;
        prosperityCfg.cycle.trigger.prosperity_thresholds.cities = 9999;
        prosperityCfg.cycle.trigger.prosperity_thresholds.heroes = 9999;
        prosperityCfg.cycle.trigger.prosperity_thresholds.tech_level = 9999;
        ConfigSchema.ValidateAndClamp(prosperityCfg);
        WorldCompat.MockWorldAge = 0;
        WorldCompat.MockPopulation = 0;
        WorldCompat.MockCities = 0;
        WorldCompat.MockHeroes = 0;
        WorldCompat.MockTechLevel = 0;

        var prosperityCycle = new CycleManager();
        prosperityCycle.Initialize(prosperityCfg);
        prosperityCycle.Update(prosperityCfg);
        if (prosperityCycle.CurrentPhase != EraPhase.Sealed)
        {
            throw new Exception("SelfTest failed: first_cycle_mode=prosperity should ignore seal strength.");
        }

        var missingDataCfg = new ModConfig();
        missingDataCfg.cycle.trigger.first_cycle_mode = "prosperity";
        missingDataCfg.cycle.trigger.fixed_age_years = 100;
        missingDataCfg.cycle.seal.initial_strength = 100f;
        ConfigSchema.ValidateAndClamp(missingDataCfg);

        WorldCompat.MockPopulation = -1;
        WorldCompat.MockCities = -1;
        WorldCompat.MockHeroes = -1;
        WorldCompat.MockTechLevel = -1;

        var missingDataCycle = new CycleManager();
        missingDataCycle.Initialize(missingDataCfg);

        for (var year = 0; year <= 100; year++)
        {
            WorldCompat.MockWorldAge = year;
            missingDataCycle.Update(missingDataCfg);
        }

        if (missingDataCycle.CurrentPhase != EraPhase.Omen)
        {
            throw new Exception("SelfTest failed: prosperity data missing should fallback to fixed age trigger.");
        }

        var normalizeCfg = new ModConfig();
        normalizeCfg.cycle.trigger.first_cycle_mode = "MANUAL";
        ConfigSchema.ValidateAndClamp(normalizeCfg);
        if (normalizeCfg.cycle.trigger.first_cycle_mode != "manual")
        {
            throw new Exception("SelfTest failed: first_cycle_mode should normalize to manual.");
        }

        var normalizeFallbackCfg = new ModConfig();
        normalizeFallbackCfg.cycle.trigger.first_cycle_mode = "unknown_mode";
        ConfigSchema.ValidateAndClamp(normalizeFallbackCfg);
        if (normalizeFallbackCfg.cycle.trigger.first_cycle_mode != "prosperity")
        {
            throw new Exception("SelfTest failed: first_cycle_mode should fallback to prosperity.");
        }

        var fixedAgeCfg = new ModConfig();
        fixedAgeCfg.cycle.trigger.first_cycle_mode = "fixed_age";
        fixedAgeCfg.cycle.trigger.fixed_age_years = 100;
        fixedAgeCfg.cycle.seal.initial_strength = 100f;
        ConfigSchema.ValidateAndClamp(fixedAgeCfg);

        var fixedAgeCycle = new CycleManager();
        fixedAgeCycle.Initialize(fixedAgeCfg);

        for (var year = 0; year <= 100; year++)
        {
            WorldCompat.MockWorldAge = year;
            fixedAgeCycle.Update(fixedAgeCfg);
        }

        if (fixedAgeCycle.CurrentPhase != EraPhase.Omen)
        {
            throw new Exception("SelfTest failed: fixed_age trigger did not enter Omen.");
        }

        var fixedModeCfg = new ModConfig();
        fixedModeCfg.cycle.trigger.first_cycle_mode = "fixed_age";
        fixedModeCfg.cycle.trigger.fixed_age_years = 1000;
        fixedModeCfg.cycle.seal.initial_strength = 100f;
        ConfigSchema.ValidateAndClamp(fixedModeCfg);

        WorldCompat.MockWorldAge = 0;
        WorldCompat.MockPopulation = 99999;
        WorldCompat.MockCities = 999;
        WorldCompat.MockHeroes = 9;
        WorldCompat.MockTechLevel = 99;

        var fixedModeCycle = new CycleManager();
        fixedModeCycle.Initialize(fixedModeCfg);
        fixedModeCycle.Update(fixedModeCfg);

        if (fixedModeCycle.CurrentPhase != EraPhase.Sealed)
        {
            throw new Exception("SelfTest failed: first_cycle_mode=fixed_age should ignore prosperity.");
        }

        var lowHpCfg = new ModConfig();
        lowHpCfg.cycle.trigger.first_cycle_mode = "manual";
        ConfigSchema.ValidateAndClamp(lowHpCfg);

        var lowHpCycle = new CycleManager();
        lowHpCycle.Initialize(lowHpCfg);
        lowHpCycle.LoadSaveData(new CycleData
        {
            CycleCount = 1,
            CurrentPhase = EraPhase.Invasion,
            SealStrength = 100f,
            PhaseStartWorldAge = 0,
            OmenTargetYears = 1,
            AwakeningTargetYears = 1,
            DemonHealthPercent = 20f
        }, lowHpCfg);
        WorldCompat.MockWorldAge = 1;
        lowHpCycle.Update(lowHpCfg);
        if (lowHpCycle.CurrentPhase != EraPhase.Weakening)
        {
            throw new Exception("SelfTest failed: low HP during invasion should enter Weakening.");
        }

        var forceCycleCfg = new ModConfig();
        forceCycleCfg.cycle.seal.initial_strength = 80f;
        ConfigSchema.ValidateAndClamp(forceCycleCfg);

        WorldCompat.MockWorldAge = 0;
        var forceCycle = new CycleManager();
        forceCycle.Initialize(forceCycleCfg);
        forceCycle.ForceSealStrength(10f);
        forceCycle.ForceCompleteCycle();
        if (forceCycle.CurrentPhase != EraPhase.Sealed)
        {
            throw new Exception("SelfTest failed: ForceCompleteCycle should end at Sealed.");
        }

        if (Math.Abs(forceCycle.SealStrength - forceCycleCfg.cycle.seal.initial_strength) > 0.01f)
        {
            throw new Exception("SelfTest failed: ForceCompleteCycle should reset seal strength.");
        }
        if (forceCycle.ExportHistory().Length != 1 || forceCycle.CycleCount != 1)
        {
            throw new Exception("SelfTest failed: cycle history not recorded on ForceCompleteCycle.");
        }

        var forcedStateCfg = new ModConfig();
        ConfigSchema.ValidateAndClamp(forcedStateCfg);

        WorldCompat.MockWorldAge = 0;
        var forcedCycle = new CycleManager();
        forcedCycle.Initialize(forcedStateCfg);
        forcedCycle.ForcePhase(EraPhase.Invasion);
        forcedCycle.ForceDemonHealthPercent(50f);

        var forcedRegistry = new DemonLordRegistry();
        forcedRegistry.Initialize(forcedStateCfg);
        forcedRegistry.ForceSetActive("void_lord");
        forcedRegistry.ForceState(DemonLordState.Peak);
        forcedRegistry.Update(forcedStateCfg, forcedCycle);

        if (forcedRegistry.Active == null || forcedRegistry.Active.State != DemonLordState.Peak)
        {
            throw new Exception("SelfTest failed: forced demon state should persist across updates.");
        }

        var actorCfg = new ModConfig();
        ConfigSchema.ValidateAndClamp(actorCfg);

        WorldCompat.MockWorldAge = 1;
        var actorCycle = new CycleManager();
        actorCycle.Initialize(actorCfg);
        actorCycle.ForcePhase(EraPhase.Invasion);

        var actorRegistry = new DemonLordRegistry();
        actorRegistry.Initialize(actorCfg);
        actorRegistry.ForceSetActive("void_lord");
        actorRegistry.Active.BindActor(new MockActor { health = 50f, maxHealth = 200f });
        actorRegistry.Update(actorCfg, actorCycle);

        if (Math.Abs(actorCycle.DemonHealthPercent - 25f) > 0.1f)
        {
            throw new Exception("SelfTest failed: actor health percent sync did not apply.");
        }

        var eventsPath = Path.Combine(Directory.GetCurrentDirectory(), "EraWheel", "Resources", "events");
        var pool = new EventPool();
        pool.LoadFromDirectory(eventsPath);
        if (pool.EventCount <= 0 || pool.GetById("omen_started") == null)
        {
            throw new Exception("SelfTest failed: event pool did not load expected events.");
        }

        var eventCtx = new WorldContext
        {
            CurrentPhase = EraPhase.Omen,
            CycleCount = 0,
            SealStrength = 20f,
            DemonHealthPercent = 100f,
            Population = 1000,
            CityCount = 10,
            HeroCount = 1,
            AntiDemonLevel = 0,
            AllianceFormed = false,
            WorldAge = 10
        };
        if (pool.SelectEvent(eventCtx) == null)
        {
            throw new Exception("SelfTest failed: event selection returned null for valid context.");
        }

        var evalCtx = new WorldContext
        {
            CurrentPhase = EraPhase.Omen,
            CycleCount = 2,
            SealStrength = 25f,
            DemonHealthPercent = 80f,
            ActiveDemonLordType = "Void",
            AllianceFormed = true,
            WorldAge = 100,
            TriggeredEvents = new HashSet<string> { "evt_1" }
        };

        var evalTrue = new NarrativeCondition
        {
            Type = NarrativeCondition.Types.EraPhase,
            Operator = NarrativeCondition.Operators.Equals,
            Value = "Omen"
        };

        var evalFalse = new NarrativeCondition
        {
            Type = NarrativeCondition.Types.CycleCount,
            Operator = NarrativeCondition.Operators.GreaterThan,
            Value = "5"
        };

        if (!EventConditionEvaluator.EvaluateAll(new[] { evalTrue, evalFalse }, evalCtx, "OR"))
        {
            throw new Exception("SelfTest failed: condition OR should pass when any condition is true.");
        }
        if (EventConditionEvaluator.EvaluateAll(new[] { evalTrue, evalFalse }, evalCtx, "AND"))
        {
            throw new Exception("SelfTest failed: condition AND should fail when any condition is false.");
        }

        var inCond = new NarrativeCondition
        {
            Type = NarrativeCondition.Types.DemonLordType,
            Operator = NarrativeCondition.Operators.In,
            Value = "void,plague"
        };
        if (!EventConditionEvaluator.Evaluate(inCond, evalCtx))
        {
            throw new Exception("SelfTest failed: in-operator did not match expected demon type.");
        }

        var notInCond = new NarrativeCondition
        {
            Type = NarrativeCondition.Types.DemonLordType,
            Operator = NarrativeCondition.Operators.NotIn,
            Value = "void,plague"
        };
        if (EventConditionEvaluator.Evaluate(notInCond, evalCtx))
        {
            throw new Exception("SelfTest failed: not_in operator should not match expected demon type.");
        }

        var triggeredCond = new NarrativeCondition
        {
            Type = NarrativeCondition.Types.EventTriggered,
            Operator = NarrativeCondition.Operators.Equals,
            Target = "evt_1",
            Value = "true"
        };
        if (!EventConditionEvaluator.Evaluate(triggeredCond, evalCtx))
        {
            throw new Exception("SelfTest failed: event_triggered condition did not resolve.");
        }

        void RunSelectionCheck(string expectedDemonId)
        {
            WorldCompat.MockWorldAge = 0;
            WorldCompat.MockPopulation = 99999;
            WorldCompat.MockCities = 999;
            WorldCompat.MockHeroes = 9;
            WorldCompat.MockTechLevel = 99;

            var localCycle = new CycleManager();
            localCycle.Initialize(cfg);

            var localDemons = new DemonLordRegistry();
            localDemons.Initialize(cfg);

            localCycle.OnPhaseChanged += (prev, next) =>
            {
                localDemons.OnPhaseChanged(prev, next, localCycle.CycleCount);
            };

            for (var year = 0; year < 500; year++)
            {
                WorldCompat.MockWorldAge = year;
                localCycle.Update(cfg);
                localDemons.Update(cfg, localCycle);

                if (localCycle.CurrentPhase == EraPhase.Awakening && localDemons.Active != null)
                {
                    break;
                }
            }

            if (localDemons.Active == null)
            {
                throw new Exception("SelfTest failed: demon was not selected on Awakening.");
            }

            if (!string.Equals(localDemons.Active.Id, expectedDemonId, StringComparison.Ordinal))
            {
                throw new Exception("SelfTest failed: enabled_lords was not respected. expected=" + expectedDemonId + " actual=" + localDemons.Active.Id);
            }
        }

        void RunForceAwakenCheck(string demonId)
        {
            var forceCfg = new ModConfig();
            forceCfg.demon_lord.enabled_lords.void_lord = false;
            forceCfg.demon_lord.enabled_lords.plague_lord = false;
            forceCfg.demon_lord.enabled_lords.machine_lord = false;
            forceCfg.demon_lord.enabled_lords.time_lord = false;
            forceCfg.demon_lord.enabled_lords.flame_lord = false;
            forceCfg.demon_lord.enabled_lords.abyss_lord = false;
            forceCfg.demon_lord.enabled_lords.death_lord = false;
            forceCfg.demon_lord.enabled_lords.soul_lord = false;
            forceCfg.demon_lord.enabled_lords.nature_lord = false;
            forceCfg.demon_lord.enabled_lords.judgment_lord = false;

            if (demonId == "void_lord") forceCfg.demon_lord.enabled_lords.void_lord = true;
            if (demonId == "plague_lord") forceCfg.demon_lord.enabled_lords.plague_lord = true;
            if (demonId == "machine_lord") forceCfg.demon_lord.enabled_lords.machine_lord = true;
            if (demonId == "time_lord") forceCfg.demon_lord.enabled_lords.time_lord = true;
            if (demonId == "flame_lord") forceCfg.demon_lord.enabled_lords.flame_lord = true;
            if (demonId == "abyss_lord") forceCfg.demon_lord.enabled_lords.abyss_lord = true;
            if (demonId == "death_lord") forceCfg.demon_lord.enabled_lords.death_lord = true;
            if (demonId == "soul_lord") forceCfg.demon_lord.enabled_lords.soul_lord = true;
            if (demonId == "nature_lord") forceCfg.demon_lord.enabled_lords.nature_lord = true;
            if (demonId == "judgment_lord") forceCfg.demon_lord.enabled_lords.judgment_lord = true;

            ConfigSchema.ValidateAndClamp(forceCfg);

            WorldCompat.MockWorldAge = 123;
            var forceCycle = new CycleManager();
            forceCycle.Initialize(forceCfg);

            var forceRegistry = new DemonLordRegistry();
            forceRegistry.Initialize(forceCfg);

            var target = forceRegistry.GetLord(demonId);
            if (target == null)
            {
                throw new Exception("SelfTest failed: demon not found for force awaken: " + demonId);
            }

            if (!target.Enabled)
            {
                throw new Exception("SelfTest failed: demon should be enabled for force awaken: " + demonId);
            }

            var cycleCount = forceCycle.CycleCount;
            forceRegistry.ForceSetActive(demonId);
            target.ClearForcedState();
            target.UpdateStateFromSystem(DemonLordState.Awakening);
            forceCycle.ForcePhase(EraPhase.Awakening);
            forceCycle.ForceDemonHealthPercent(30f);
            target.OnAwaken(cycleCount);

            if (forceRegistry.Active == null || forceRegistry.Active.Id != demonId)
            {
                throw new Exception("SelfTest failed: force awaken did not set active demon: " + demonId);
            }

            if (forceCycle.CurrentPhase != EraPhase.Awakening)
            {
                throw new Exception("SelfTest failed: force awaken did not enter awakening phase.");
            }

            if (target.State != DemonLordState.Awakening)
            {
                throw new Exception("SelfTest failed: force awaken did not set demon state to awakening.");
            }

            if (target.HasActor)
            {
                if (target.Stronghold == null || target.Stronghold.CreatedAtWorldAge != WorldCompat.MockWorldAge)
                {
                    throw new Exception("SelfTest failed: force awaken did not create stronghold.");
                }
            }
        }

        void AssertDemonState(bool enabled, EraPhase phase, float hp, DemonLordState expected)
        {
            var actual = DemonLordStateMachine.ComputeState(enabled, phase, hp);
            if (actual != expected)
            {
                throw new Exception("SelfTest failed: demon state mismatch. expected=" + expected + " actual=" + actual);
            }
        }

        cfg.demon_lord.enabled_lords.void_lord = true;
        cfg.demon_lord.enabled_lords.plague_lord = false;
        cfg.demon_lord.enabled_lords.machine_lord = false;
        cfg.demon_lord.enabled_lords.time_lord = false;
        cfg.demon_lord.enabled_lords.flame_lord = false;
        cfg.demon_lord.enabled_lords.abyss_lord = false;
        cfg.demon_lord.enabled_lords.death_lord = false;
        cfg.demon_lord.enabled_lords.soul_lord = false;
        cfg.demon_lord.enabled_lords.nature_lord = false;
        cfg.demon_lord.enabled_lords.judgment_lord = false;
        RunSelectionCheck("void_lord");

        cfg.demon_lord.enabled_lords.void_lord = false;
        cfg.demon_lord.enabled_lords.plague_lord = true;
        RunSelectionCheck("plague_lord");

        RunForceAwakenCheck("void_lord");

        AssertDemonState(false, EraPhase.Invasion, 100f, DemonLordState.Disabled);
        AssertDemonState(true, EraPhase.Sealed, 100f, DemonLordState.Sealed);
        AssertDemonState(true, EraPhase.Omen, 100f, DemonLordState.Sealed);
        AssertDemonState(true, EraPhase.Awakening, 100f, DemonLordState.Awakening);
        AssertDemonState(true, EraPhase.Weakening, 10f, DemonLordState.Weakened);
        AssertDemonState(true, EraPhase.Weakening, 0f, DemonLordState.Defeated);
        AssertDemonState(true, EraPhase.Resealed, 50f, DemonLordState.Defeated);
        AssertDemonState(true, EraPhase.Invasion, 80f, DemonLordState.Peak);
        AssertDemonState(true, EraPhase.Invasion, 50f, DemonLordState.Active);
        AssertDemonState(true, EraPhase.Invasion, 10f, DemonLordState.Weakened);
        AssertDemonState(true, EraPhase.Invasion, 0f, DemonLordState.Defeated);

        var clampCfg = new ModConfig();
        clampCfg.cycle.phases.omen_duration.min = -5;
        clampCfg.cycle.phases.omen_duration.max = -1;
        clampCfg.cycle.phases.awakening_duration.min = 50;
        clampCfg.cycle.phases.awakening_duration.max = 10;
        clampCfg.cycle.phases.invasion_timeout = 5;
        clampCfg.demon_lord.random_count = 0;
        clampCfg.demon_lord.growth.strength_min = 5f;
        clampCfg.demon_lord.growth.strength_max = 1f;
        clampCfg.demon_lord.legion.max_alive_units = 10;
        clampCfg.demon_lord.generals.betrayal_base_chance = 1.0f;
        clampCfg.performance.update_intervals.ai_story = 0;
        clampCfg.expansion.ragnarok.required_civilizations = 0;
        clampCfg.expansion.ragnarok.duration_years = 0;
        clampCfg.civilization.alliance.auto_form_threshold = 2f;
        clampCfg.adaptive_difficulty.smoothing_factor = 2f;
        clampCfg.adaptive_difficulty.multiplier_min = 2f;
        clampCfg.adaptive_difficulty.multiplier_max = 1f;
        clampCfg.ui.scale = 0.1f;
        clampCfg.narrative.event_pool.trigger_interval_frames = 0;
        clampCfg.narrative.ai_engine.permission_level = 0;
        ConfigSchema.ValidateAndClamp(clampCfg);

        if (clampCfg.cycle.phases.omen_duration.min != 0 || clampCfg.cycle.phases.omen_duration.max != 0)
        {
            throw new Exception("SelfTest failed: omen duration clamp not applied.");
        }
        if (clampCfg.cycle.phases.awakening_duration.min != 50 || clampCfg.cycle.phases.awakening_duration.max != 50)
        {
            throw new Exception("SelfTest failed: awakening duration clamp not applied.");
        }
        if (clampCfg.cycle.phases.invasion_timeout != 50)
        {
            throw new Exception("SelfTest failed: invasion timeout clamp not applied.");
        }
        if (clampCfg.demon_lord.random_count != 1)
        {
            throw new Exception("SelfTest failed: random_count clamp not applied.");
        }
        if (Math.Abs(clampCfg.demon_lord.growth.strength_min - 1f) > 0.001f || Math.Abs(clampCfg.demon_lord.growth.strength_max - 1f) > 0.001f)
        {
            throw new Exception("SelfTest failed: growth strength clamp not applied.");
        }
        if (clampCfg.demon_lord.legion.max_alive_units != 50)
        {
            throw new Exception("SelfTest failed: legion max_alive_units clamp not applied.");
        }
        if (Math.Abs(clampCfg.demon_lord.generals.betrayal_base_chance - 0.2f) > 0.001f)
        {
            throw new Exception("SelfTest failed: betrayal_base_chance clamp not applied.");
        }
        if (clampCfg.performance.update_intervals.ai_story != 1)
        {
            throw new Exception("SelfTest failed: ai_story interval clamp not applied.");
        }
        if (clampCfg.expansion.ragnarok.required_civilizations != 1 || clampCfg.expansion.ragnarok.duration_years != 1)
        {
            throw new Exception("SelfTest failed: ragnarok clamp not applied.");
        }
        if (Math.Abs(clampCfg.ui.scale - 0.5f) > 0.001f)
        {
            throw new Exception("SelfTest failed: ui scale clamp not applied.");
        }
        if (clampCfg.narrative.event_pool.trigger_interval_frames != 1 || clampCfg.narrative.ai_engine.permission_level != 1)
        {
            throw new Exception("SelfTest failed: narrative clamp not applied.");
        }
        if (Math.Abs(clampCfg.civilization.alliance.auto_form_threshold - 1f) > 0.001f)
        {
            throw new Exception("SelfTest failed: alliance auto_form_threshold clamp not applied.");
        }
        if (Math.Abs(clampCfg.adaptive_difficulty.smoothing_factor - 1f) > 0.001f)
        {
            throw new Exception("SelfTest failed: smoothing_factor clamp not applied.");
        }
        if (Math.Abs(clampCfg.adaptive_difficulty.multiplier_min - clampCfg.adaptive_difficulty.multiplier_max) > 0.001f)
        {
            throw new Exception("SelfTest failed: adaptive_difficulty min/max clamp not applied.");
        }

        var phaseCfg = new ModConfig();
        ConfigSchema.ValidateAndClamp(phaseCfg);
        var phaseCycle = new CycleManager();
        phaseCycle.Initialize(phaseCfg);
        phaseCycle.ForcePhase(EraPhase.Awakening);
        if (phaseCycle.CurrentPhase != EraPhase.Awakening || Math.Abs(phaseCycle.DemonHealthPercent - 30f) > 0.001f)
        {
            throw new Exception("SelfTest failed: ForcePhase(Awakening) did not set health to 30.");
        }
        phaseCycle.ForcePhase(EraPhase.Invasion);
        if (phaseCycle.CurrentPhase != EraPhase.Invasion || Math.Abs(phaseCycle.DemonHealthPercent - 100f) > 0.001f)
        {
            throw new Exception("SelfTest failed: ForcePhase(Invasion) did not set health to 100.");
        }
        phaseCycle.ForcePhase(EraPhase.Sealed);
        if (phaseCycle.CurrentPhase != EraPhase.Sealed || Math.Abs(phaseCycle.DemonHealthPercent - 100f) > 0.001f)
        {
            throw new Exception("SelfTest failed: ForcePhase(Sealed) did not reset health.");
        }
        phaseCycle.ForceNextPhase();
        if (phaseCycle.CurrentPhase != EraPhase.Omen)
        {
            throw new Exception("SelfTest failed: ForceNextPhase did not enter Omen.");
        }

        var externalCfg = new ModConfig();
        externalCfg.cycle.trigger.first_cycle_mode = "manual";
        ConfigSchema.ValidateAndClamp(externalCfg);

        WorldCompat.MockWorldAge = 0;
        var externalCycle = new CycleManager();
        externalCycle.Initialize(externalCfg);
        externalCycle.ForcePhase(EraPhase.Invasion);
        externalCycle.SetExternalDemonHealthPercent(80f);

        WorldCompat.MockWorldAge = 5;
        externalCycle.Update(externalCfg);
        if (Math.Abs(externalCycle.DemonHealthPercent - 80f) > 0.01f)
        {
            throw new Exception("SelfTest failed: external demon health should remain fixed.");
        }

        externalCycle.ClearExternalDemonHealth();
        WorldCompat.MockWorldAge = 6;
        externalCycle.Update(externalCfg);
        if (externalCycle.DemonHealthPercent >= 80f)
        {
            throw new Exception("SelfTest failed: demon health should decay after clearing external override.");
        }

        var disabledActiveCfg = new ModConfig();
        disabledActiveCfg.demon_lord.enabled_lords.void_lord = false;
        disabledActiveCfg.demon_lord.enabled_lords.plague_lord = false;
        disabledActiveCfg.demon_lord.enabled_lords.machine_lord = false;
        disabledActiveCfg.demon_lord.enabled_lords.time_lord = false;
        disabledActiveCfg.demon_lord.enabled_lords.flame_lord = false;
        disabledActiveCfg.demon_lord.enabled_lords.abyss_lord = false;
        disabledActiveCfg.demon_lord.enabled_lords.death_lord = false;
        disabledActiveCfg.demon_lord.enabled_lords.soul_lord = false;
        disabledActiveCfg.demon_lord.enabled_lords.nature_lord = false;
        disabledActiveCfg.demon_lord.enabled_lords.judgment_lord = false;
        ConfigSchema.ValidateAndClamp(disabledActiveCfg);

        var disabledActiveRegistry = new DemonLordRegistry();
        disabledActiveRegistry.Initialize(disabledActiveCfg);
        disabledActiveRegistry.ForceSetActive("void_lord");
        if (disabledActiveRegistry.Active != null)
        {
            throw new Exception("SelfTest failed: ForceSetActive should ignore disabled lord.");
        }

        var resetCfg = new ModConfig();
        resetCfg.demon_lord.enabled_lords.plague_lord = false;
        resetCfg.demon_lord.enabled_lords.machine_lord = false;
        resetCfg.demon_lord.enabled_lords.time_lord = false;
        resetCfg.demon_lord.enabled_lords.flame_lord = false;
        resetCfg.demon_lord.enabled_lords.abyss_lord = false;
        resetCfg.demon_lord.enabled_lords.death_lord = false;
        resetCfg.demon_lord.enabled_lords.soul_lord = false;
        resetCfg.demon_lord.enabled_lords.nature_lord = false;
        resetCfg.demon_lord.enabled_lords.judgment_lord = false;
        ConfigSchema.ValidateAndClamp(resetCfg);

        var resetCycle = new CycleManager();
        resetCycle.Initialize(resetCfg);
        resetCycle.ForcePhase(EraPhase.Awakening);

        var resetRegistry = new DemonLordRegistry();
        resetRegistry.Initialize(resetCfg);
        resetRegistry.Update(resetCfg, resetCycle);
        if (resetRegistry.Active == null)
        {
            throw new Exception("SelfTest failed: active demon not selected before seal.");
        }
        resetCycle.ForcePhase(EraPhase.Sealed);
        resetRegistry.Update(resetCfg, resetCycle);
        if (resetRegistry.Active != null)
        {
            throw new Exception("SelfTest failed: active demon not cleared on seal.");
        }

        var saveLoadCfg = new ModConfig();
        ConfigSchema.ValidateAndClamp(saveLoadCfg);

        var saveCycle = new CycleManager();
        saveCycle.Initialize(saveLoadCfg);
        saveCycle.ForceCycleCount(3);
        saveCycle.ForcePhase(EraPhase.Invasion);
        saveCycle.ForceDemonHealthPercent(55f);
        saveCycle.ForceSealStrength(12f);
        var savedCycleData = saveCycle.GetSaveData();

        var loadCycle = new CycleManager();
        loadCycle.LoadSaveData(savedCycleData, saveLoadCfg);
        if (loadCycle.CycleCount != 3 || loadCycle.CurrentPhase != EraPhase.Invasion || Math.Abs(loadCycle.DemonHealthPercent - 55f) > 0.001f)
        {
            throw new Exception("SelfTest failed: cycle save/load mismatch.");
        }
        if (Math.Abs(loadCycle.SealStrength - 12f) > 0.001f)
        {
            throw new Exception("SelfTest failed: cycle seal strength not restored.");
        }

        var saveRegistry = new DemonLordRegistry();
        saveRegistry.Initialize(saveLoadCfg);
        saveRegistry.ForceSetActive("void_lord");
        var saveActive = saveRegistry.Active;
        if (saveActive == null)
        {
            throw new Exception("SelfTest failed: registry active missing before save.");
        }
        saveActive.SetHealthPercent(42f);
        saveActive.UpdateStateFromSystem(DemonLordState.Peak);
        var savedDemons = saveRegistry.GetSaveData();

        var loadRegistry = new DemonLordRegistry();
        loadRegistry.LoadSaveData(savedDemons, saveLoadCfg);
        if (loadRegistry.Active == null || loadRegistry.Active.Id != "void_lord")
        {
            throw new Exception("SelfTest failed: registry save/load active mismatch.");
        }
        if (Math.Abs(loadRegistry.Active.CurrentHealthPercent - 42f) > 0.001f || loadRegistry.Active.State != DemonLordState.Peak)
        {
            throw new Exception("SelfTest failed: registry save/load data mismatch.");
        }

        var migrateData = new ModSaveData
        {
            ModVersion = "0.0.1",
            CycleData = new CycleData
            {
                SealStrength = -5f,
                OmenTargetYears = 0,
                AwakeningTargetYears = 0,
                DemonHealthPercent = 200f
            },
            DemonLordData = null,
            GeneralData = null,
            Civilization = null,
            Alliance = null,
            Hero = null,
            CycleHistory = null,
            Legacy = null,
            EventPool = null,
            AIOperationLog = null
        };

        var migratedData = MigrationManager.Migrate(migrateData, "1.0.9");
        if (migratedData == null || migratedData.DemonLordData == null || migratedData.GeneralData == null ||
            migratedData.Civilization == null || migratedData.Alliance == null || migratedData.Hero == null ||
            migratedData.CycleHistory == null || migratedData.Legacy == null || migratedData.EventPool == null ||
            migratedData.AIOperationLog == null)
        {
            throw new Exception("SelfTest failed: migration did not initialize defaults.");
        }
        if (Math.Abs(migratedData.CycleData.SealStrength) > 0.001f ||
            migratedData.CycleData.OmenTargetYears != 30 ||
            migratedData.CycleData.AwakeningTargetYears != 20 ||
            Math.Abs(migratedData.CycleData.DemonHealthPercent - 100f) > 0.001f)
        {
            throw new Exception("SelfTest failed: migration did not clamp cycle defaults.");
        }

        var civCfg2 = new ModConfig();
        civCfg2.civilization.anti_demon.kill_thresholds = new[] { 1, 2, 3 };
        ConfigSchema.ValidateAndClamp(civCfg2);
        var civTracker2 = new CivilizationTracker();
        civTracker2.Initialize(civCfg2);
        EventBus.Publish(new DemonKillEvent { Count = 1, WorldTime = 0 });
        if (civTracker2.DemonKillCount != 1 || civTracker2.AntiDemonLevel < 1)
        {
            throw new Exception("SelfTest failed: DemonKillEvent did not update AntiDemonLevel.");
        }
        EventBus.Publish(new CycleCompletedEvent
        {
            CycleNumber = 2,
            Summary = new CycleSummary { CycleNumber = 2, EndPhase = EraPhase.Resealed, WorldTime = 0, KeyEvents = new string[0] }
        });
        if (civTracker2.SealCount != 2)
        {
            throw new Exception("SelfTest failed: CycleCompletedEvent did not update SealCount.");
        }

        if (!DemonLordConfigHelper.IsEnabled(new EnabledLordsConfig { void_lord = false }, "unknown_lord"))
        {
            throw new Exception("SelfTest failed: unknown demon id should default to enabled.");
        }

        cfg.demon_lord.enabled_lords.void_lord = true;
        cfg.demon_lord.enabled_lords.plague_lord = true;

        WorldCompat.MockPopulation = 99999;
        WorldCompat.MockCities = 999;
        WorldCompat.MockHeroes = 9;
        WorldCompat.MockTechLevel = 99;

        var cycle = new CycleManager();
        cycle.Initialize(cfg);

        var demons = new DemonLordRegistry();
        demons.Initialize(cfg);

        var legacy = new LegacySystem();
        legacy.Initialize(cfg);

        var legion = new LegionWaveSystem();

        var generalSystem = new GeneralSystem();

        var civ = new CivilizationTracker();
        civ.Initialize(cfg);

        var alliance = new AllianceSystem();
        alliance.Initialize(cfg);

        var sawBetrayal = false;
        var sawAllianceFormed = false;
        var allianceFormedEver = false;
        var sawAntiDemonLevelUp = false;
        var sawAllianceSealProgress = false;

        EventBus.Subscribe<GeneralBetrayedEvent>(_ => { sawBetrayal = true; });
        EventBus.Subscribe<AllianceFormedEvent>(_ => { sawAllianceFormed = true; allianceFormedEver = true; });
        EventBus.Subscribe<AntiDemonLevelChangedEvent>(_ => { sawAntiDemonLevelUp = true; });
        EventBus.Subscribe<AllianceSealProgressEvent>(_ => { sawAllianceSealProgress = true; });

        cycle.OnPhaseChanged += (prev, next) =>
        {
            demons.OnPhaseChanged(prev, next, cycle.CycleCount);
        };

        string firstDemonId = null;
        var lastPhase = cycle.CurrentPhase;
        var defeatReports = 0;

        for (var year = 0; year < 2000; year++)
        {
            WorldCompat.MockWorldAge = year;

            if (cycle.CurrentPhase == EraPhase.Sealed || cycle.CurrentPhase == EraPhase.Resealed)
            {
                WorldCompat.MockCities = 100;
            }
            else
            {
                WorldCompat.MockCities = 50;
            }

            cycle.Update(cfg);
            demons.Update(cfg, cycle);
            legion.Update(cfg, cycle);
            generalSystem.Update(cfg, cycle, demons);
            alliance.Update(cfg, cycle);
            civ.Update(cfg);

            if (alliance.State.Formed)
            {
                allianceFormedEver = true;
            }

            if (defeatReports < 3)
            {
                var gens = generalSystem.Generals;
                if (gens != null && gens.Length > 0 && !string.IsNullOrEmpty(gens[0].Id))
                {
                    generalSystem.ReportGeneralDefeated(gens[0].Id, year);
                    defeatReports++;
                }
            }

            if (demons.Active != null && firstDemonId == null)
            {
                firstDemonId = demons.Active.Id;
            }

            if (cycle.CurrentPhase != lastPhase)
            {
                Log.Info($"[SelfTest] Phase: {lastPhase} -> {cycle.CurrentPhase} @ age={year} cycleCount={cycle.CycleCount} demonHP={cycle.DemonHealthPercent:0.0}%");
                lastPhase = cycle.CurrentPhase;
            }

            if (cycle.CycleCount >= 2 && cycle.CurrentPhase == EraPhase.Sealed)
            {
                break;
            }
        }

        if (cycle.CycleCount < 2)
        {
            throw new Exception("SelfTest failed: did not reach 2 cycles.");
        }

        if (civ.SealCount < cycle.CycleCount)
        {
            throw new Exception("SelfTest failed: seal count did not track cycle completions.");
        }

        if (civ.AntiDemonLevel < Math.Min(10, civ.SealCount))
        {
            throw new Exception("SelfTest failed: AntiDemonLevel did not include seal progress.");
        }

        if (string.IsNullOrEmpty(firstDemonId))
        {
            throw new Exception("SelfTest failed: demon lord was never selected.");
        }

        var originalCycleCount = cycle.CycleCount;
        cycle.ForceCycleCount(0);
        var m0 = cycle.GetDemonStrengthMultiplier(cfg);
        cycle.ForceCycleCount(2);
        var m2 = cycle.GetDemonStrengthMultiplier(cfg);
        cycle.ForceCycleCount(originalCycleCount);

        if (m2 <= m0)
        {
            throw new Exception("SelfTest failed: demon strength multiplier did not increase across cycles.");
        }

        if (legacy.GetStack("legacy_warrior") + legacy.GetStack("legacy_armor") + legacy.GetStack("legacy_scholar") + legacy.GetStack("legacy_hero") + legacy.GetStack("legacy_curse") <= 0)
        {
            throw new Exception("SelfTest failed: no legacy stacks granted.");
        }

        if (legion.State.AliveUnits > cfg.demon_lord.legion.max_alive_units)
        {
            throw new Exception("SelfTest failed: legion alive cap exceeded.");
        }

        if (legion.State.CurrentWave < 10 || !legion.State.EverSpawnedUltimate)
        {
            throw new Exception("SelfTest failed: did not observe ultimate unit at wave 10+.");
        }

        var peakCfg = new ModConfig();
        peakCfg.demon_lord.legion.wave_interval_years = 4;
        peakCfg.demon_lord.legion.base_units_per_wave = 1;
        peakCfg.demon_lord.legion.wave_growth_rate = 0f;
        peakCfg.demon_lord.legion.max_units_per_wave = 10;
        peakCfg.demon_lord.legion.max_alive_units = 100;
        ConfigSchema.ValidateAndClamp(peakCfg);

        var peakCycle = new CycleManager();
        peakCycle.Initialize(peakCfg);

        var peakLegion = new LegionWaveSystem();
        peakLegion.Reset();

        for (var year = 0; year <= 5; year++)
        {
            WorldCompat.MockWorldAge = year;
            peakCycle.ForcePhase(EraPhase.Peak);
            peakLegion.Update(peakCfg, peakCycle);
        }

        if (peakLegion.State.CurrentWave < 2)
        {
            throw new Exception("SelfTest failed: Peak phase should speed up legion wave interval.");
        }

        if (!sawAntiDemonLevelUp || civ.AntiDemonLevel <= 0)
        {
            throw new Exception("SelfTest failed: AntiDemonLevel did not increase.");
        }

        if (!sawAllianceFormed && !allianceFormedEver)
        {
            throw new Exception("SelfTest failed: Alliance was not formed.");
        }

        if (!sawAllianceSealProgress)
        {
            throw new Exception("SelfTest failed: did not observe alliance seal progress events.");
        }

        if (!sawBetrayal)
        {
            throw new Exception("SelfTest failed: did not observe GeneralBetrayedEvent.");
        }

        var generalsAfter = generalSystem.Generals;
        if (generalsAfter != null && generalsAfter.Length > 0 && generalsAfter[0].LastSpawnAttemptWorldAge < 0)
        {
            throw new Exception("SelfTest failed: general spawn attempts were not tracked.");
        }

        UpdateScheduler.Reset();
        var narrativeCalls = 0;
        UpdateScheduler.OnNarrative = () => { narrativeCalls++; };
        var schedulerCfg = new ModConfig();
        schedulerCfg.performance.update_intervals.ai_story = 100;
        ConfigSchema.ValidateAndClamp(schedulerCfg);

        for (var i = 0; i < 10; i++)
        {
            UpdateScheduler.Update(schedulerCfg);
        }

        if (narrativeCalls != 10)
        {
            throw new Exception("SelfTest failed: OnNarrative should run every update tick.");
        }

        var heroCfg = new ModConfig();
        ConfigSchema.ValidateAndClamp(heroCfg);
        var heroSystem = new HeroSystem();
        heroSystem.Initialize(heroCfg);

        var hero = heroSystem.ForceSpawnDestinedHero(0);
        if (hero == null || heroSystem.Heroes.Count != 1)
        {
            throw new Exception("SelfTest failed: ForceSpawnDestinedHero did not add hero.");
        }

        var inheritBefore = heroSystem.TotalInheritances;
        var okInherit = heroSystem.ForceHeroDeathWithInheritance(hero.Id, 10, "selftest");
        if (!okInherit || heroSystem.TotalInheritances <= inheritBefore)
        {
            throw new Exception("SelfTest failed: ForceHeroDeathWithInheritance did not add inheritance.");
        }

        var saveRoot = Path.Combine(Path.GetTempPath(), "EraWheelSelfTest");
        Directory.CreateDirectory(saveRoot);
        SaveManager.Initialize(saveRoot);

        var sampleSave = new ModSaveData
        {
            ModVersion = "selftest"
        };
        SaveManager.SaveModData("era_wheel_selftest", sampleSave);
        var savePath = Path.Combine(saveRoot, "Data", "Saves", "era_wheel_selftest.json");
        if (!File.Exists(savePath))
        {
            throw new Exception("SelfTest failed: SaveManager file fallback did not persist data.");
        }
        var saveText = File.ReadAllText(savePath);
        if (string.IsNullOrEmpty(saveText) || !saveText.Contains("\"ModVersion\": \"selftest\""))
        {
            throw new Exception("SelfTest failed: SaveManager file payload missing expected content.");
        }

        var migrationCfg = new ModConfig();
        migrationCfg.cycle.trigger.first_cycle_mode = "manual";
        ConfigSchema.ValidateAndClamp(migrationCfg);

        var legacySave = new ModSaveData
        {
            ModVersion = "1.0.0",
            CycleData = new CycleData
            {
                CycleCount = 1,
                CurrentPhase = EraPhase.Omen,
                SealStrength = -5f,
                PhaseStartWorldAge = 1,
                OmenTargetYears = 1,
                AwakeningTargetYears = 1,
                DemonHealthPercent = 150f
            },
            DemonLordData = null,
            GeneralData = null,
            Civilization = null,
            Alliance = null,
            Hero = null,
            CycleHistory = null,
            Legacy = null,
            EventPool = null,
            AIOperationLog = null
        };

        SaveManager.SaveModData("era_wheel_selftest_migrate", legacySave);
        var loadedLegacy = SaveManager.LoadModData<ModSaveData>("era_wheel_selftest_migrate");
        if (loadedLegacy == null)
        {
            throw new Exception("SelfTest failed: migration save/load returned null.");
        }

        if (!MigrationManager.NeedsMigration(loadedLegacy, "1.0.4"))
        {
            throw new Exception("SelfTest failed: migration should be required for legacy version.");
        }

        var migrated = MigrationManager.Migrate(loadedLegacy, "1.0.4");
        if (migrated == null || migrated.ModVersion != "1.0.4")
        {
            throw new Exception("SelfTest failed: migration did not update version.");
        }

        if (Math.Abs(migrated.CycleData.SealStrength - 0f) > 0.001f)
        {
            throw new Exception("SelfTest failed: migration did not clamp seal strength.");
        }

        if (Math.Abs(migrated.CycleData.DemonHealthPercent - 100f) > 0.001f)
        {
            throw new Exception("SelfTest failed: migration did not clamp demon health.");
        }

        WorldCompat.MockWorldAge = 0;
        var migratedCycle = new CycleManager();
        migratedCycle.LoadSaveData(migrated.CycleData, migrationCfg);

        WorldCompat.MockWorldAge = 2;
        migratedCycle.Update(migrationCfg);
        if (migratedCycle.CurrentPhase != EraPhase.Awakening)
        {
            throw new Exception("SelfTest failed: migrated cycle did not advance to Awakening.");
        }

        WorldCompat.MockWorldAge = 3;
        migratedCycle.Update(migrationCfg);
        if (migratedCycle.CurrentPhase != EraPhase.Invasion)
        {
            throw new Exception("SelfTest failed: migrated cycle did not advance to Invasion.");
        }

        WorldCompat.MockWorldAge = 4;
        migratedCycle.Update(migrationCfg);
        if (migratedCycle.CurrentPhase != EraPhase.Peak)
        {
            throw new Exception("SelfTest failed: migrated cycle did not advance to Peak.");
        }

        var eventPool = new EventPool();
        var eventJson = @"{
  ""version"": ""1.0.0"",
  ""events"": [
    {
      ""id"": ""test_primary"",
      ""name_key"": ""event.test.primary.name"",
      ""category"": ""System"",
      ""priority"": 100,
      ""conditions"": [
        { ""type"": ""era_phase"", ""operator"": ""eq"", ""value"": ""Omen"" }
      ],
      ""description_key"": ""event.test.primary.desc"",
      ""cooldown"": 0,
      ""repeatable"": false,
      ""max_triggers"": 1
    },
    {
      ""id"": ""test_fallback"",
      ""name_key"": ""event.test.fallback.name"",
      ""category"": ""System"",
      ""priority"": 10,
      ""conditions"": [
        { ""type"": ""era_phase"", ""operator"": ""eq"", ""value"": ""Omen"" }
      ],
      ""description_key"": ""event.test.fallback.desc"",
      ""cooldown"": 0,
      ""repeatable"": true
    }
  ]
}";
        var eventPath = Path.Combine(saveRoot, "event_pool_selftest.json");
        File.WriteAllText(eventPath, eventJson);
        eventPool.LoadFromFile(eventPath);

        var eventCtx2 = new WorldContext
        {
            CurrentPhase = EraPhase.Omen,
            CycleCount = 0,
            WorldAge = 1
        };

        var firstEvent = eventPool.SelectEvent(eventCtx2);
        if (firstEvent == null || firstEvent.Id != "test_primary")
        {
            throw new Exception("SelfTest failed: EventPool did not select primary event.");
        }
        eventPool.MarkTriggered(firstEvent, eventCtx2);
        var secondEvent = eventPool.SelectEvent(eventCtx2);
        if (secondEvent == null || secondEvent.Id != "test_fallback")
        {
            throw new Exception("SelfTest failed: EventPool repeatable filter failed.");
        }

        var repeatPool = new EventPool();
        var repeatEventJson = @"{
  ""version"": ""1.0.0"",
  ""events"": [
    {
      ""id"": ""repeat_only"",
      ""name_key"": ""event.test.repeat.name"",
      ""category"": ""System"",
      ""priority"": 10,
      ""conditions"": [
        { ""type"": ""era_phase"", ""operator"": ""eq"", ""value"": ""Omen"" }
      ],
      ""description_key"": ""event.test.repeat.desc"",
      ""cooldown"": 0,
      ""repeatable"": true
    }
  ]
}";
        var repeatPath = Path.Combine(saveRoot, "event_pool_repeat.json");
        File.WriteAllText(repeatPath, repeatEventJson);
        repeatPool.LoadFromFile(repeatPath);
        repeatPool.SetDuplicatePreventionWindow(1);

        var repeatCtx = new WorldContext
        {
            CurrentPhase = EraPhase.Omen,
            CycleCount = 0,
            WorldAge = 1
        };
        var repeatPick = repeatPool.SelectEvent(repeatCtx);
        if (repeatPick == null || repeatPick.Id != "repeat_only")
        {
            throw new Exception("SelfTest failed: repeat event not selected.");
        }
        repeatPool.MarkTriggered(repeatPick, repeatCtx);
        var repeatBlocked = repeatPool.SelectEvent(repeatCtx);
        if (repeatBlocked != null)
        {
            throw new Exception("SelfTest failed: duplicate prevention did not block repeat event.");
        }

        void AssertMultiLordMode(string mode, MultiLordMode expected)
        {
            var mcfg = new ModConfig();
            mcfg.expansion.multi_lord.enabled = true;
            mcfg.demon_lord.multi_lord_mode = mode;
            ConfigSchema.ValidateAndClamp(mcfg);

            var ms = new MultiLordSystem();
            ms.Initialize(mcfg);
            if (ms.Mode != expected)
            {
                throw new Exception("SelfTest failed: MultiLordMode mismatch for " + mode);
            }
        }

        AssertMultiLordMode("independent", MultiLordMode.Independent);
        AssertMultiLordMode("alliance", MultiLordMode.Alliance);
        AssertMultiLordMode("civil_war", MultiLordMode.CivilWar);
        AssertMultiLordMode("auto_judge", MultiLordMode.AutoJudge);
        AssertMultiLordMode("unknown", MultiLordMode.Independent);

        var multiCfg = new ModConfig();
        multiCfg.expansion.multi_lord.enabled = true;
        multiCfg.expansion.multi_lord.min_awaken_count = 2;
        multiCfg.expansion.multi_lord.max_awaken_count = 3;
        multiCfg.demon_lord.random_count = 3;
        multiCfg.demon_lord.enabled_lords = new EnabledLordsConfig
        {
            void_lord = true,
            plague_lord = true,
            machine_lord = false,
            time_lord = false,
            flame_lord = false,
            abyss_lord = false,
            death_lord = false,
            soul_lord = false,
            nature_lord = false,
            judgment_lord = false
        };
        ConfigSchema.ValidateAndClamp(multiCfg);

        var multiCycle = new CycleManager();
        multiCycle.Initialize(multiCfg);
        multiCycle.ForcePhase(EraPhase.Awakening);

        var multiRegistry = new DemonLordRegistry();
        multiRegistry.Initialize(multiCfg);

        var multiSystem = new MultiLordSystem();
        multiSystem.Initialize(multiCfg);
        multiSystem.Update(multiCfg, multiCycle, multiRegistry);

        if (multiSystem.ActiveLords.Count != 2)
        {
            throw new Exception("SelfTest failed: multi-lord selection did not respect enabled count.");
        }

        multiCycle.ForcePhase(EraPhase.Sealed);
        multiSystem.Update(multiCfg, multiCycle, multiRegistry);
        if (multiSystem.ActiveLords.Count != 0)
        {
            throw new Exception("SelfTest failed: multi-lord selection did not clear on seal.");
        }

        var disabledCfg = new ModConfig();
        disabledCfg.expansion.multi_lord.enabled = false;
        disabledCfg.demon_lord.multi_lord_mode = "alliance";
        ConfigSchema.ValidateAndClamp(disabledCfg);

        var disabledCycle = new CycleManager();
        disabledCycle.Initialize(disabledCfg);
        disabledCycle.ForcePhase(EraPhase.Awakening);

        var disabledRegistry = new DemonLordRegistry();
        disabledRegistry.Initialize(disabledCfg);

        var disabledSystem = new MultiLordSystem();
        disabledSystem.Initialize(disabledCfg);
        disabledSystem.Update(disabledCfg, disabledCycle, disabledRegistry);
        if (disabledSystem.ActiveLords.Count != 0 || disabledSystem.Mode != MultiLordMode.Independent)
        {
            throw new Exception("SelfTest failed: multi-lord disabled state not respected.");
        }

        var ragnarokCfg = new ModConfig();
        ragnarokCfg.expansion.ragnarok.enabled = true;
        ragnarokCfg.expansion.ragnarok.required_civilizations = 1;
        ragnarokCfg.expansion.ragnarok.duration_years = 5;
        ConfigSchema.ValidateAndClamp(ragnarokCfg);

        WorldCompat.MockCivilizations = 1;
        WorldCompat.MockWorldAge = 10;

        var ragnarokCycle = new CycleManager();
        ragnarokCycle.Initialize(ragnarokCfg);
        ragnarokCycle.ForcePhase(EraPhase.Peak);

        var ragnarok = new RagnarokModule();
        ragnarok.Initialize(ragnarokCfg);
        ragnarok.Update(ragnarokCfg, ragnarokCycle);

        if (!ragnarok.Active)
        {
            throw new Exception("SelfTest failed: Ragnarok did not activate.");
        }

        WorldCompat.MockWorldAge = 20;
        ragnarokCycle.Update(ragnarokCfg);
        ragnarok.Update(ragnarokCfg, ragnarokCycle);
        if (ragnarok.Active)
        {
            throw new Exception("SelfTest failed: Ragnarok did not stop after duration.");
        }

        var noRagnarokCfg = new ModConfig();
        noRagnarokCfg.expansion.ragnarok.enabled = false;
        ConfigSchema.ValidateAndClamp(noRagnarokCfg);

        var noRagnarokCycle = new CycleManager();
        noRagnarokCycle.Initialize(noRagnarokCfg);
        noRagnarokCycle.ForcePhase(EraPhase.Peak);

        var noRagnarok = new RagnarokModule();
        noRagnarok.Initialize(noRagnarokCfg);
        noRagnarok.Update(noRagnarokCfg, noRagnarokCycle);
        if (noRagnarok.Active)
        {
            throw new Exception("SelfTest failed: Ragnarok should remain inactive when disabled.");
        }

        EventBus.ClearAll();
        var curseCfg = new ModConfig();
        curseCfg.legacy.curse_threshold.city_loss_percent = 0.5f;
        curseCfg.legacy.curse_threshold.hero_deaths = 2;
        ConfigSchema.ValidateAndClamp(curseCfg);

        var curseLegacy = new LegacySystem();
        curseLegacy.Initialize(curseCfg);

        WorldCompat.MockCities = 10;
        WorldCompat.MockHeroes = 5;
        EventBus.Publish(new PhaseChangedEvent
        {
            PreviousPhase = EraPhase.Resealed,
            NewPhase = EraPhase.Sealed,
            WorldTime = 0,
            TriggerReason = "selftest"
        });

        WorldCompat.MockCities = 4;
        WorldCompat.MockHeroes = 5;
        EventBus.Publish(new CycleCompletedEvent
        {
            CycleNumber = 1,
            Summary = new CycleSummary
            {
                CycleNumber = 1,
                EndPhase = EraPhase.Resealed,
                WorldTime = 10,
                KeyEvents = new string[0]
            }
        });

        if (curseLegacy.GetStack("legacy_curse") <= 0)
        {
            throw new Exception("SelfTest failed: legacy curse should grant on heavy losses.");
        }

        EventBus.ClearAll();
        var safeLegacy = new LegacySystem();
        safeLegacy.Initialize(curseCfg);

        WorldCompat.MockCities = 10;
        WorldCompat.MockHeroes = 5;
        EventBus.Publish(new PhaseChangedEvent
        {
            PreviousPhase = EraPhase.Resealed,
            NewPhase = EraPhase.Sealed,
            WorldTime = 0,
            TriggerReason = "selftest"
        });

        WorldCompat.MockCities = 9;
        WorldCompat.MockHeroes = 4;
        EventBus.Publish(new CycleCompletedEvent
        {
            CycleNumber = 2,
            Summary = new CycleSummary
            {
                CycleNumber = 2,
                EndPhase = EraPhase.Resealed,
                WorldTime = 20,
                KeyEvents = new string[0]
            }
        });

        if (safeLegacy.GetStack("legacy_curse") > 0)
        {
            throw new Exception("SelfTest failed: legacy curse should not grant when thresholds are unmet.");
        }

        Log.Info($"[SelfTest] PASS: cycles={cycle.CycleCount}, firstDemon={firstDemonId}");
    }

    private class MockActor
    {
        public float health;
        public float maxHealth;
    }
}
