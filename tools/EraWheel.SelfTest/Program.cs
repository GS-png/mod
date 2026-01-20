using System;
using EraWheel.Config;
using EraWheel.Civilization;
using EraWheel.Core;
using EraWheel.DemonLord;

internal static class Program
{
    private static void Main()
    {
        WorldCompat.MockEnabled = true;

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

        Log.Info($"[SelfTest] PASS: cycles={cycle.CycleCount}, firstDemon={firstDemonId}");
    }
}
