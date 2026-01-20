using EraWheel.Config;
using EraWheel.Core;
using EraWheel.Civilization;
using EraWheel.Data;
using EraWheel.DemonLord;
using EraWheel.Narrative;
using EraWheel.Narrative.AI;
using EraWheel.UI;
using NeoModLoader.api;
using System;

namespace EraWheel
{
    public class Main : BasicMod<Main>
    {
        public new static Main Instance { get; private set; }

        public ConfigManager ConfigManager { get; private set; }

        public CycleManager CycleManager { get; private set; }
        public DemonLordRegistry DemonLordRegistry { get; private set; }

        public LegacySystem LegacySystem { get; private set; }
        public LegionWaveSystem LegionWaveSystem { get; private set; }

        public GeneralSystem GeneralSystem { get; private set; }
        public CivilizationTracker CivilizationTracker { get; private set; }
        public AllianceSystem AllianceSystem { get; private set; }
        public HeroSystem HeroSystem { get; private set; }

        protected override void OnModLoad()
        {
            Instance = this;

            ConfigManager = new ConfigManager();
            ConfigManager.Load();

            CycleManager = new CycleManager();
            CycleManager.Initialize(ConfigManager.Config);

            DemonLordRegistry = new DemonLordRegistry();
            DemonLordRegistry.Initialize(ConfigManager.Config);

            LegacySystem = new LegacySystem();
            LegacySystem.Initialize(ConfigManager.Config);

            LegionWaveSystem = new LegionWaveSystem();

            GeneralSystem = new GeneralSystem();

            CivilizationTracker = new CivilizationTracker();
            CivilizationTracker.Initialize(ConfigManager.Config);

            AllianceSystem = new AllianceSystem();
            AllianceSystem.Initialize(ConfigManager.Config);

            HeroSystem = new HeroSystem();
            HeroSystem.Initialize(ConfigManager.Config);

            var eventsPath = System.IO.Path.Combine(ConfigManager.ModRootPath, "Resources", "events");
            NarrativeDispatcher.Instance.Initialize(ConfigManager.Config, eventsPath);
            AIStoryEngine.Instance.Initialize(ConfigManager.Config);

            CycleManager.OnPhaseChanged += (prev, next) =>
            {
                try
                {
                    DemonLordRegistry.OnPhaseChanged(prev, next, CycleManager != null ? CycleManager.CycleCount : 0);
                }
                catch
                {
                }
            };

            UpdateScheduler.OnDemonLord = () =>
            {
                try
                {
                    DemonLordRegistry?.Update(ConfigManager != null ? ConfigManager.Config : null, CycleManager);
                    GeneralSystem?.Update(ConfigManager != null ? ConfigManager.Config : null, CycleManager, DemonLordRegistry);
                }
                catch
                {
                }
            };

            UpdateScheduler.OnLegion = () =>
            {
                try
                {
                    LegionWaveSystem?.Update(ConfigManager != null ? ConfigManager.Config : null, CycleManager);
                }
                catch
                {
                }
            };

            UpdateScheduler.OnCivilization = () =>
            {
                try
                {
                    CivilizationTracker?.Update(ConfigManager != null ? ConfigManager.Config : null);
                    AllianceSystem?.Update(ConfigManager != null ? ConfigManager.Config : null, CycleManager);
                }
                catch
                {
                }
            };

            UpdateScheduler.OnHero = () =>
            {
                try
                {
                    HeroSystem?.Update(ConfigManager != null ? ConfigManager.Config : null, CycleManager);
                }
                catch
                {
                }
            };

            UpdateScheduler.OnNarrative = () =>
            {
                try
                {
                    var ctx = WorldContext.Capture();
                    ctx.CurrentPhase = CycleManager?.CurrentPhase ?? EraPhase.Sealed;
                    ctx.CycleCount = CycleManager?.CycleCount ?? 0;
                    ctx.SealStrength = CycleManager?.SealStrength ?? 100f;
                    ctx.DemonHealthPercent = CycleManager?.DemonHealthPercent ?? 100f;
                    ctx.AntiDemonLevel = CivilizationTracker?.AntiDemonLevel ?? 0;
                    ctx.AllianceFormed = AllianceSystem?.State?.Formed ?? false;
                    ctx.ActiveDemonLordId = DemonLordRegistry?.ActiveDemonLord?.Id;

                    NarrativeDispatcher.Instance.Update(ConfigManager?.Config, ctx);
                }
                catch
                {
                }
            };

            EraWheel.Data.SaveManager.Initialize(ConfigManager.ModRootPath);
            EraWheel.Data.SaveManager.OnSave += OnGameSave;
            EraWheel.Data.SaveManager.OnLoad += OnGameLoad;

            TrySubscribeUpdateCallback();

            try
            {
                TryRegisterUIButton();
            }
            catch
            {
            }
        }

        private void OnUpdate()
        {
            UpdateScheduler.Update(ConfigManager != null ? ConfigManager.Config : null);
        }

        private void OnGameSave()
        {
            var saveData = new ModSaveData
            {
                ModVersion = GetModVersion(),
                CycleData = CycleManager != null ? CycleManager.GetSaveData() : new CycleData(),
                DemonLordData = DemonLordRegistry != null ? DemonLordRegistry.GetSaveData() : new DemonLordSaveData[0],
                GeneralData = GeneralSystem != null ? GeneralSystem.ExportToSave() : new GeneralSaveData[0],
                Civilization = CivilizationTracker != null ? CivilizationTracker.ExportToSave() : new CivilizationSaveData(),
                Alliance = AllianceSystem != null ? AllianceSystem.ExportToSave() : new AllianceSaveData(),
                Hero = HeroSystem != null ? HeroSystem.ExportToSave() : new HeroSaveData(),
                CycleHistory = CycleManager != null ? CycleManager.ExportHistory() : new CycleSummary[0],
                Legacy = LegacySystem != null ? LegacySystem.ExportToSave() : new LegacyData(),
                EventPool = NarrativeDispatcher.Instance.GetSaveData(),
                AIOperationLog = AIStoryEngine.Instance.OperationLog.GetSaveData()
            };
            EraWheel.Data.SaveManager.SaveModData("era_wheel", saveData);
        }

        private void OnGameLoad()
        {
            var saveData = EraWheel.Data.SaveManager.LoadModData<ModSaveData>("era_wheel");
            if (saveData == null) return;

            var v = GetModVersion();
            if (MigrationManager.NeedsMigration(saveData, v))
            {
                saveData = MigrationManager.Migrate(saveData, v);
            }

            try
            {
                CycleManager?.LoadSaveData(saveData.CycleData, ConfigManager != null ? ConfigManager.Config : null);
                CycleManager?.LoadHistory(saveData.CycleHistory);
                DemonLordRegistry?.LoadSaveData(saveData.DemonLordData, ConfigManager != null ? ConfigManager.Config : null);
                GeneralSystem?.LoadFromSave(saveData.GeneralData);

                if (CivilizationTracker != null)
                {
                    CivilizationTracker.LoadFromSave(saveData.Civilization);
                }

                if (AllianceSystem != null)
                {
                    AllianceSystem.LoadFromSave(saveData.Alliance);
                }

                if (HeroSystem != null)
                {
                    HeroSystem.LoadFromSave(saveData.Hero);
                }

                if (LegacySystem != null)
                {
                    LegacySystem.UpdateConfig(ConfigManager != null ? ConfigManager.Config : null);
                    LegacySystem.LoadFromSave(saveData.Legacy);
                }

                if (saveData.EventPool != null)
                {
                    NarrativeDispatcher.Instance.LoadSaveData(saveData.EventPool);
                }

                if (saveData.AIOperationLog != null)
                {
                    AIStoryEngine.Instance.OperationLog.LoadSaveData(saveData.AIOperationLog);
                }
            }
            catch
            {
            }
        }

        private static string GetModVersion()
        {
            try
            {
                var v = typeof(Main).Assembly.GetName().Version;
                if (v != null) return v.ToString();
            }
            catch
            {
            }

            return "1.0.0";
        }

        private void TrySubscribeUpdateCallback()
        {
            try
            {
                var t = CompatReflection.FindTypeByName("WorldBehaviourUpdateManager");
                if (t == null) return;

                CompatReflection.InvokeStatic(t, "addUpdateCallback", new object[] { (Action)OnUpdate });
            }
            catch
            {
            }
        }

        private void TryRegisterUIButton()
        {
            try
            {
                var powerButtons = CompatReflection.FindTypeByName("PowerButtons");
                var toolBox = CompatReflection.FindTypeByName("ToolBox");
                if (powerButtons == null || toolBox == null) return;

                var sprite = CompatReflection.InvokeStatic(toolBox, "LoadSprite", new object[] { "mods/EraWheel/icon.png" });
                CompatReflection.InvokeStatic(powerButtons, "CreateButton", new object[]
                {
                    "era_wheel_panel",
                    sprite,
                    "打开纪元之轮控制面板",
                    (Action)(() => ControlPanel.Instance.Toggle())
                });
            }
            catch
            {
            }
        }
    }
}
