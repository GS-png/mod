using EraWheel.Config;
using EraWheel.Core;
using EraWheel.Civilization;
using EraWheel.Data;
using EraWheel.DemonLord;
using EraWheel.Narrative;
using EraWheel.Narrative.AI;
using EraWheel.Core.ExtensionModules;
using EraWheel.UI;
using EraWheel.UI.Components;
using NeoModLoader.api;
using NeoModLoader.General;
using System;

namespace EraWheel
{
    public class Main : BasicMod<Main>
    {
        public new static Main Instance { get; private set; }

        public ConfigManager ConfigManager { get; private set; }

        public CycleManager CycleManager { get; private set; }
        public DemonLordRegistry DemonLordRegistry { get; private set; }
        public MultiLordSystem MultiLordSystem { get; private set; }

        public LegacySystem LegacySystem { get; private set; }
        public LegionWaveSystem LegionWaveSystem { get; private set; }
        public RagnarokModule RagnarokModule { get; private set; }

        public GeneralSystem GeneralSystem { get; private set; }
        public CivilizationTracker CivilizationTracker { get; private set; }
        public AllianceSystem AllianceSystem { get; private set; }
        public HeroSystem HeroSystem { get; private set; }
        private bool _uiRegistered;
        private int _uiRegisterAttempts;
        private bool _assetsRegistered;

        protected override void OnModLoad()
        {
            Instance = this;

            ConfigManager = new ConfigManager();
            ConfigManager.Load();
            Localization.Initialize(System.IO.Path.Combine(ConfigManager.ModRootPath, "Localization"));
            _assetsRegistered = ActorAssetRegistry.EnsureRegistered(ConfigManager.Config);

            CycleManager = new CycleManager();
            CycleManager.Initialize(ConfigManager.Config);

            DemonLordRegistry = new DemonLordRegistry();
            DemonLordRegistry.Initialize(ConfigManager.Config);

            MultiLordSystem = new MultiLordSystem();
            MultiLordSystem.Initialize(ConfigManager.Config);

            LegacySystem = new LegacySystem();
            LegacySystem.Initialize(ConfigManager.Config);

            LegionWaveSystem = new LegionWaveSystem();

            GeneralSystem = new GeneralSystem();

            RagnarokModule = new RagnarokModule();
            RagnarokModule.Initialize(ConfigManager.Config);

            CivilizationTracker = new CivilizationTracker();
            CivilizationTracker.Initialize(ConfigManager.Config);

            AllianceSystem = new AllianceSystem();
            AllianceSystem.Initialize(ConfigManager.Config);

            HeroSystem = new HeroSystem();
            HeroSystem.Initialize(ConfigManager.Config);
            WorldCompat.HeroCountProvider = () => HeroSystem != null ? HeroSystem.AliveHeroCount : 0;

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

            UpdateScheduler.Reset();
            UpdateScheduler.OnCycle = () =>
            {
                try
                {
                    var cfg = GetModConfig();
                    CycleManager?.Update(cfg);
                    RagnarokModule?.Update(cfg, CycleManager);
                }
                catch
                {
                }
            };

            UpdateScheduler.OnDemonLord = () =>
            {
                try
                {
                    var cfg = GetModConfig();
                    DemonLordRegistry?.Update(cfg, CycleManager);
                    GeneralSystem?.Update(cfg, CycleManager, DemonLordRegistry);
                    MultiLordSystem?.Update(cfg, CycleManager, DemonLordRegistry);
                }
                catch
                {
                }
            };

            UpdateScheduler.OnLegion = () =>
            {
                try
                {
                    LegionWaveSystem?.Update(GetModConfig(), CycleManager);
                }
                catch
                {
                }
            };

            UpdateScheduler.OnCivilization = () =>
            {
                try
                {
                    var cfg = GetModConfig();
                    CivilizationTracker?.Update(cfg);
                    AllianceSystem?.Update(cfg, CycleManager);
                }
                catch
                {
                }
            };

            UpdateScheduler.OnHero = () =>
            {
                try
                {
                    HeroSystem?.Update(GetModConfig(), CycleManager);
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
                    var cycle = CycleManager;
                    var activeDemon = DemonLordRegistry?.ActiveDemonLord;

                    ctx.CurrentPhase = cycle?.CurrentPhase ?? EraPhase.Sealed;
                    ctx.CycleCount = cycle?.CycleCount ?? 0;
                    ctx.SealStrength = cycle?.SealStrength ?? 100f;
                    ctx.DemonHealthPercent = cycle?.DemonHealthPercent ?? 100f;
                    ctx.PhaseDuration = cycle != null ? (int)Math.Max(0, cycle.WorldAge - cycle.PhaseStartWorldAge) : 0;

                    ctx.DemonLordActive = activeDemon != null && activeDemon.Enabled;
                    ctx.ActiveDemonLordId = activeDemon?.Id;
                    ctx.ActiveDemonLordType = activeDemon?.Definition?.Type.ToString();

                    ctx.DemonKillCount = CivilizationTracker?.DemonKillCount ?? 0;
                    ctx.GeneralsActive = GeneralSystem != null ? GeneralSystem.ActiveCount : 0;

                    ctx.Csi = CivilizationTracker?.CSI ?? 0f;
                    ctx.AntiDemonLevel = CivilizationTracker?.AntiDemonLevel ?? 0;
                    ctx.AllianceFormed = AllianceSystem?.State?.Formed ?? false;
                    ctx.HeroCount = HeroSystem != null ? HeroSystem.AliveHeroCount : ctx.HeroCount;
                    ctx.DestinedHeroExists = HeroSystem != null && HeroSystem.HasDestinedHero;

                    NarrativeDispatcher.Instance.Update(GetModConfig(), ctx);
                }
                catch
                {
                }
            };

            EraWheel.Data.SaveManager.Initialize(ConfigManager.ModRootPath);
            EraWheel.Data.SaveManager.OnSave += OnGameSave;
            EraWheel.Data.SaveManager.OnLoad += OnGameLoad;

            _uiRegistered = TryRegisterUIButton();
            _uiRegisterAttempts = _uiRegistered ? 0 : 1;
        }

        private void Update()
        {
            var cfg = GetModConfig();
            if (!_assetsRegistered)
            {
                _assetsRegistered = ActorAssetRegistry.EnsureRegistered(GetModConfig());
                if (_assetsRegistered)
                {
                    DemonLordRegistry?.ApplyStatOverrides(GetModConfig());
                }
            }
            UpdateScheduler.Update(cfg);
            EraWheel.Data.SaveManager.Update();

            try
            {
                if (UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.F8))
                {
                    ControlPanel.Instance.Toggle();
                }
            }
            catch
            {
            }

            if (_uiRegistered || _uiRegisterAttempts <= 0) return;

            if (UnityEngine.Time.frameCount % 60 != 0) return;
            if (_uiRegisterAttempts >= 60)
            {
                _uiRegisterAttempts = 0;
                return;
            }

            _uiRegisterAttempts++;
            if (TryRegisterUIButton())
            {
                _uiRegistered = true;
                _uiRegisterAttempts = 0;
            }
        }

        private void OnGUI()
        {
            try
            {
                ControlPanel.Instance.OnGUI();
                ConfirmDialog.Instance.OnGUI();
            }
            catch (Exception ex)
            {
                Log.Error("[EraWheel] Main.OnGUI error: " + ex.Message);
            }
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
                CycleManager?.LoadSaveData(saveData.CycleData, GetModConfig());
                CycleManager?.LoadHistory(saveData.CycleHistory);
                DemonLordRegistry?.LoadSaveData(saveData.DemonLordData, GetModConfig());
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
                    LegacySystem.UpdateConfig(GetModConfig());
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

        private EraWheel.Config.ModConfig GetModConfig()
        {
            return ConfigManager != null ? ConfigManager.Config : null;
        }

        private bool TryRegisterUIButton()
        {
            try
            {
                var tab = PowerButtonCreator.GetTab(PowerTabNames.Other);
                if (tab == null)
                {
                    tab = PowerButtonCreator.GetTab("Tab_" + PowerTabNames.Other);
                }
                if (tab == null) return false;

                var existing = tab.transform.Find("era_wheel_panel");
                if (existing != null) return true;

                var iconPath = System.IO.Path.Combine(ConfigManager.ModRootPath, "icon.png");
                var sprite = Toolbox.LoadSprite(iconPath);
                if (sprite == null)
                {
                    Log.Warning("[EraWheel] Icon not found: " + iconPath);
                }

                var button = PowerButtonCreator.CreateSimpleButton(
                    "era_wheel_panel",
                    () => ControlPanel.Instance.Toggle(),
                    sprite
                );

                PowerButtonCreator.AddButtonToTab(button, tab);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
