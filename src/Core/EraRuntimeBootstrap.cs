using EraWheel.Assets;
using EraWheel.Combat;
using EraWheel.Config;
using EraWheel.Config.Registry;
using EraWheel.Core.Events;
using EraWheel.Core.Logging;
using EraWheel.Core.Random;
using EraWheel.Core.Validation;
using EraWheel.Data.Bestiary;
using EraWheel.Data.Definitions;
using EraWheel.Data.Loaders;
using EraWheel.Data.Registration;
using EraWheel.Save.Services;
using EraWheel.Systems.Advancement;
using EraWheel.Systems.Kingdoms;
using EraWheel.Systems.Levels;
using EraWheel.Systems.Progression;
using EraWheel.Systems.Reincarnation;
using EraWheel.Systems.Story;
using NeoModLoader.api;
using NeoModLoader.api.attributes;

namespace EraWheel.Core;

public static class EraRuntimeBootstrap
{
    private static bool _initialized;
    private static string _modRootPath = string.Empty;

    public static EraContentCatalog ContentCatalog { get; private set; } = EraContentCatalog.Empty;
    public static EraSpriteCatalog SpriteCatalog { get; private set; } = EraSpriteCatalog.Empty;
    public static EraBestiaryCatalog BestiaryCatalog { get; private set; } = EraBestiaryCatalog.Empty;
    public static EraRuntimeSaveService? RuntimeSave { get; private set; }
    public static EraStableRandomService? StableRandom { get; private set; }
    public static EraEventLogService? EventLog { get; private set; }
    public static EraGrowthRangeManager? GrowthRanges { get; private set; }
    public static EraAdvancementRuntimeService? AdvancementRuntime { get; private set; }
    public static EraLevelRuntimeService? LevelRuntime { get; private set; }
    public static EraKingdomRuntimeService? KingdomRuntime { get; private set; }
    public static EraProgressionRuntimeService? ProgressionRuntime { get; private set; }
    public static EraReincarnationRuntimeService? ReincarnationRuntime { get; private set; }
    public static EraStoryRuntimeService? StoryRuntime { get; private set; }
    public static EraValidationReport ValidationReport { get; private set; } = EraValidationReport.Empty;
    public static EraCombatRuntimeService? CombatRuntime { get; private set; }

    public static void Initialize(ModDeclare declaration, EraParameterRegistry parameterRegistry)
    {
        if (_initialized)
        {
            RefreshWorldBinding();
            return;
        }

        Rebuild(declaration, parameterRegistry, reloadMode: false, persistAfterRebuild: true);
        _initialized = true;
    }

    [Hotfixable]
    public static void Reload(ModDeclare declaration, EraParameterRegistry parameterRegistry)
    {
        Rebuild(declaration, parameterRegistry, reloadMode: true, persistAfterRebuild: false);
        _initialized = true;
    }

    private static void Rebuild(
        ModDeclare declaration,
        EraParameterRegistry parameterRegistry,
        bool reloadMode,
        bool persistAfterRebuild
    )
    {
        _modRootPath = declaration.FolderPath;
        ContentCatalog = EraContentManifestLoader.Load();
        SpriteCatalog = EraSpriteCatalogBuilder.Build(_modRootPath, ContentCatalog);
        RuntimeSave = EraRuntimeSaveService.Create(parameterRegistry);
        RuntimeSave.TryAttachCurrentWorld();
        StableRandom = new EraStableRandomService(RuntimeSave.CurrentState);
        EventLog = new EraEventLogService(RuntimeSave.CurrentState);
        GrowthRanges = new EraGrowthRangeManager(parameterRegistry, RuntimeSave.CurrentState);
        EventLog.Append("bootstrap", reloadMode ? "foundation_reloaded" : "foundation_initialized", reloadMode ? "EW-012~018 共享底座已重载。" : "EW-012~018 共享底座已初始化。");
        EventLog.Append("bootstrap", "sprite_catalog_ready", $"EW-019~024 资源索引已初始化：{SpriteCatalog.CreateStatusReport()}");
        EventLog.Append("bootstrap", "growth_ranges_ready", $"EW-050 数值范围管理器已初始化：{GrowthRanges.CreateStatusReport()}");
        EraKingdomRegistrationReport kingdomRegistrationReport = EraKingdomRegistrationService.Register(ContentCatalog, SpriteCatalog, reloadMode);
        string kingdomReport = $"EW-056/058 魔王阵营王国已初始化：{kingdomRegistrationReport.CreateStatusReport()}";
        EventLog.Append("bootstrap", "demon_kingdom_registry_ready", kingdomReport);
        EraLog.Info(EraLogCategory.Data, kingdomReport);
        EraTraitGroupRegistrationReport traitGroupRegistrationReport = EraTraitGroupRegistrationService.Register();
        string traitGroupReport = $"EW-025 特质分组已初始化：{traitGroupRegistrationReport.CreateStatusReport()}";
        EventLog.Append("bootstrap", "trait_group_registry_ready", traitGroupReport);
        EraLog.Info(EraLogCategory.Data, traitGroupReport);
        EraTraitRegistrationReport traitRegistrationReport = EraTraitRegistrationService.Register(ContentCatalog, SpriteCatalog, reloadMode);
        string traitReport = $"EW-025~029 特质静态注册已初始化：{traitRegistrationReport.CreateStatusReport()}";
        EventLog.Append("bootstrap", "trait_registry_ready", traitReport);
        EraLog.Info(EraLogCategory.Data, traitReport);
        EraStatusRegistrationReport statusRegistrationReport = EraStatusRegistrationService.Register(reloadMode);
        string statusReport = $"EW-060 运行时状态已初始化：{statusRegistrationReport.CreateStatusReport()}";
        EventLog.Append("bootstrap", "runtime_status_registry_ready", statusReport);
        EraLog.Info(EraLogCategory.Data, statusReport);
        CombatRuntime = new EraCombatRuntimeService(StableRandom);
        CombatRuntime.Bind();
        string combatReport = $"EW-062~072 战斗原语与首批魔王技能已初始化：{CombatRuntime.CreateStatusReport()}";
        EventLog.Append("bootstrap", "combat_runtime_ready", combatReport);
        EraLog.Info(EraLogCategory.Combat, combatReport);
        EraEquipmentRegistrationReport equipmentRegistrationReport = EraEquipmentRegistrationService.Register(ContentCatalog, SpriteCatalog, reloadMode);
        string equipmentReport = $"EW-030~033 装备静态注册已初始化：{equipmentRegistrationReport.CreateStatusReport()}";
        EventLog.Append("bootstrap", "equipment_registry_ready", equipmentReport);
        EraLog.Info(EraLogCategory.Data, equipmentReport);
        string baseStatVisibilityReport = EraBaseStatVisibilityService.ApplyOverrides();
        string baseStatVisibilityMessage = $"原版 base stat 可视化修正已初始化：{baseStatVisibilityReport}";
        EventLog.Append("bootstrap", "base_stat_visibility_ready", baseStatVisibilityMessage);
        EraLog.Info(EraLogCategory.Data, baseStatVisibilityMessage);
        AdvancementRuntime = new EraAdvancementRuntimeService(
            parameterRegistry,
            RuntimeSave,
            StableRandom,
            EventLog,
            ContentCatalog
        );
        AdvancementRuntime.Bind();
        string advancementReport = $"EW-088~092 轮回进阶运行时已初始化：{AdvancementRuntime.CreateStatusReport()}";
        EventLog.Append("bootstrap", "advancement_runtime_ready", advancementReport);
        EraLog.Info(EraLogCategory.Events, advancementReport);
        LevelRuntime = new EraLevelRuntimeService(
            parameterRegistry,
            StableRandom,
            EventLog
        );
        LevelRuntime.Bind();
        string levelReport = $"EW-095 等级账本运行时已初始化：{LevelRuntime.CreateStatusReport()}";
        EventLog.Append("bootstrap", "level_runtime_ready", levelReport);
        EraLog.Info(EraLogCategory.Events, levelReport);
        KingdomRuntime = new EraKingdomRuntimeService(
            parameterRegistry,
            StableRandom,
            EventLog,
            RuntimeSave
        );
        KingdomRuntime.Bind();
        string kingdomRuntimeReport = $"EW-096 王国声望运行时已初始化：{KingdomRuntime.CreateStatusReport()}";
        EventLog.Append("bootstrap", "kingdom_runtime_ready", kingdomRuntimeReport);
        EraLog.Info(EraLogCategory.Events, kingdomRuntimeReport);
        ProgressionRuntime = new EraProgressionRuntimeService(
            parameterRegistry,
            StableRandom,
            EventLog,
            AdvancementRuntime,
            RuntimeSave,
            GrowthRanges,
            ContentCatalog
        );
        ProgressionRuntime.Bind();
        string progressionReport = $"EW-093/097~100 成长实例与英雄运行时已初始化：{ProgressionRuntime.CreateStatusReport()}";
        EventLog.Append("bootstrap", "progression_runtime_ready", progressionReport);
        EraLog.Info(EraLogCategory.Events, progressionReport);
        EraActorRegistrationReport actorRegistrationReport = EraActorRegistrationService.Register(ContentCatalog, SpriteCatalog, reloadMode);
        string actorReport = $"EW-034~036 单位模板注册已初始化：{actorRegistrationReport.CreateStatusReport()}";
        EventLog.Append("bootstrap", "actor_registry_ready", actorReport);
        EraLog.Info(EraLogCategory.Data, actorReport);
        EraBuildingRegistrationReport buildingRegistrationReport = EraBuildingRegistrationService.Register(ContentCatalog, SpriteCatalog, reloadMode);
        string buildingReport = $"EW-037 据点模板注册已初始化：{buildingRegistrationReport.CreateStatusReport()}";
        EventLog.Append("bootstrap", "stronghold_registry_ready", buildingReport);
        EraLog.Info(EraLogCategory.Data, buildingReport);
        ReincarnationRuntime = new EraReincarnationRuntimeService(
            parameterRegistry,
            RuntimeSave,
            StableRandom,
            EventLog,
            ContentCatalog,
            GrowthRanges,
            AdvancementRuntime
        );
        StoryRuntime = new EraStoryRuntimeService(RuntimeSave);
        BestiaryCatalog = EraBestiaryCatalogBuilder.Build(ContentCatalog, SpriteCatalog);
        string bestiaryReport = $"EW-038 静态图鉴目录已初始化：{BestiaryCatalog.CreateStatusReport()}";
        EventLog.Append("bootstrap", "bestiary_catalog_ready", bestiaryReport);
        EraLog.Info(EraLogCategory.Data, bestiaryReport);
        ValidationReport = EraStartupValidator.Validate(
            declaration.FolderPath,
            parameterRegistry,
            ContentCatalog,
            EraConfig.ConfigMigrator,
            EraConfig.BackupPolicy
        );
        LogValidationIssues();
        LogValidationChecklist();
        ValidationReport.ThrowIfBlocking();
        if (persistAfterRebuild)
        {
            RuntimeSave.PersistIfPossible();
        }
    }

    [Hotfixable]
    public static void RefreshWorldBinding()
    {
        if (!_initialized || RuntimeSave == null)
        {
            return;
        }

        RuntimeSave.TryAttachCurrentWorld();
        StableRandom?.Rebind(RuntimeSave.CurrentState);
        EventLog?.Rebind(RuntimeSave.CurrentState);
        GrowthRanges?.Rebind(RuntimeSave.CurrentState);
        AdvancementRuntime?.Rebind();
        LevelRuntime?.Rebind();
        KingdomRuntime?.Rebind();
        ProgressionRuntime?.Rebind();
        StoryRuntime?.Rebind(RuntimeSave);
    }

    public static void UpdateRuntime()
    {
        if (!_initialized)
        {
            return;
        }

        ReincarnationRuntime?.Update();
        AdvancementRuntime?.Update(RuntimeSave?.CurrentState.LastObservedWorldTime ?? 0f);
        LevelRuntime?.Update();
        KingdomRuntime?.Update();
        ProgressionRuntime?.Update();
        CombatRuntime?.Update();
    }

    [Hotfixable]
    public static string CreateStatusReport()
    {
        string content = ContentCatalog.CreateStatusReport();
        string sprites = SpriteCatalog.CreateStatusReport();
        string save = RuntimeSave?.CreateStatusReport() ?? "运行态存档未初始化。";
        string random = StableRandom?.CreateStatusReport() ?? "稳定随机未初始化。";
        string events = EventLog?.CreateStatusReport() ?? "事件流水未初始化。";
        string growth = GrowthRanges?.CreateStatusReport() ?? "数值范围未初始化。";
        string advancement = AdvancementRuntime?.CreateStatusReport() ?? "轮回进阶未初始化。";
        string levels = LevelRuntime?.CreateStatusReport() ?? "等级运行时未初始化。";
        string kingdoms = KingdomRuntime?.CreateStatusReport() ?? "王国声望运行时未初始化。";
        string progression = ProgressionRuntime?.CreateStatusReport() ?? "成长实例与英雄运行时未初始化。";
        string reincarnation = ReincarnationRuntime?.CreateStatusReport() ?? "阶段驱动未初始化。";
        string story = StoryRuntime?.CreateStatusReport() ?? "故事素材运行时未初始化。";
        string combat = CombatRuntime?.CreateStatusReport() ?? "战斗原语未初始化。";
        string bestiary = BestiaryCatalog.CreateStatusReport();
        string validation = ValidationReport.CreateStatusReport();
        return $"清单：{content} | 资源：{sprites} | 图鉴：{bestiary} | 存档：{save} | 随机：{random} | 事件：{events} | 数值范围：{growth} | 进阶：{advancement} | 等级：{levels} | 王国：{kingdoms} | 成长：{progression} | 阶段：{reincarnation} | 故事：{story} | 战斗：{combat} | 校验：{validation}";
    }

    private static void LogValidationIssues()
    {
        if (ValidationReport.Issues.Count == 0)
        {
            EraLog.Info(EraLogCategory.Validation, "启动校验通过，没有发现 EW-017 阻塞项。");
            return;
        }

        foreach (EraValidationIssue issue in ValidationReport.Issues)
        {
            string message = $"[{issue.Scope}] {issue.Message}";
            if (issue.Severity == EraValidationSeverity.Error)
            {
                EraLog.Error(EraLogCategory.Validation, message);
            }
            else
            {
                EraLog.Warning(EraLogCategory.Validation, message);
            }
        }
    }

    private static void LogValidationChecklist()
    {
        EraLog.Info(EraLogCategory.Validation, "EW-114 启动自检清单：");
        foreach (string line in ValidationReport.CreateChecklistLines())
        {
            EraLog.Info(EraLogCategory.Validation, line);
        }
    }
}
