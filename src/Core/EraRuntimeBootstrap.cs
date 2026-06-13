using System;
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

        Rebuild(declaration, parameterRegistry, persistAfterRebuild: true);
        _initialized = true;
    }

    private static void Rebuild(
        ModDeclare declaration,
        EraParameterRegistry parameterRegistry,
        bool persistAfterRebuild
    )
    {
        EraAssetRegistrySnapshot assetRegistrySnapshot = EraAssetRegistryRollbackService.CaptureRuntimeRegistry();
        EraRuntimeDraft draft;
        try
        {
            draft = BuildRuntimeDraft(declaration, parameterRegistry);
        }
        catch
        {
            RestoreAssetRegistrySnapshot(assetRegistrySnapshot);
            throw;
        }

        CommitRuntimeDraft(draft, persistAfterRebuild);
    }

    private static EraRuntimeDraft BuildRuntimeDraft(
        ModDeclare declaration,
        EraParameterRegistry parameterRegistry
    )
    {
        EraRuntimeDraft draft = new EraRuntimeDraft
        {
            ModRootPath = declaration.FolderPath,
        };

        draft.ContentCatalog = EraContentManifestLoader.Load();
        draft.ValidationReport = EraStartupValidator.Validate(
            declaration.FolderPath,
            parameterRegistry,
            draft.ContentCatalog,
            EraConfig.ConfigMigrator,
            EraConfig.BackupPolicy
        );
        LogValidationIssues(draft.ValidationReport);
        LogValidationChecklist(draft.ValidationReport);
        draft.ValidationReport.ThrowIfBlocking();

        draft.SpriteCatalog = EraSpriteCatalogBuilder.Build(draft.ModRootPath, draft.ContentCatalog);
        draft.RuntimeSave = EraRuntimeSaveService.Create(parameterRegistry);
        draft.RuntimeSave.TryAttachCurrentWorld();
        draft.StableRandom = new EraStableRandomService(draft.RuntimeSave.CurrentState);
        draft.EventLog = new EraEventLogService(draft.RuntimeSave.CurrentState);
        draft.GrowthRanges = new EraGrowthRangeManager(parameterRegistry, draft.RuntimeSave.CurrentState);
        draft.EventLog.Append("bootstrap", "foundation_initialized", "EW-012~018 共享底座已初始化。");
        draft.EventLog.Append("bootstrap", "sprite_catalog_ready", $"EW-019~024 资源索引已初始化：{draft.SpriteCatalog.CreateStatusReport()}");
        draft.EventLog.Append("bootstrap", "growth_ranges_ready", $"EW-050 数值范围管理器已初始化：{draft.GrowthRanges.CreateStatusReport()}");

        EraKingdomRegistrationReport kingdomRegistrationReport = EraKingdomRegistrationService.Register(draft.ContentCatalog, draft.SpriteCatalog);
        string kingdomReport = $"EW-056/058 魔王阵营王国已初始化：{kingdomRegistrationReport.CreateStatusReport()}";
        draft.EventLog.Append("bootstrap", "demon_kingdom_registry_ready", kingdomReport);
        EraLog.Info(EraLogCategory.Data, kingdomReport);
        EraTraitGroupRegistrationReport traitGroupRegistrationReport = EraTraitGroupRegistrationService.Register();
        string traitGroupReport = $"EW-025 特质分组已初始化：{traitGroupRegistrationReport.CreateStatusReport()}";
        draft.EventLog.Append("bootstrap", "trait_group_registry_ready", traitGroupReport);
        EraLog.Info(EraLogCategory.Data, traitGroupReport);
        EraTraitRegistrationReport traitRegistrationReport = EraTraitRegistrationService.Register(draft.ContentCatalog, draft.SpriteCatalog);
        string traitReport = $"EW-025~029 特质静态注册已初始化：{traitRegistrationReport.CreateStatusReport()}";
        draft.EventLog.Append("bootstrap", "trait_registry_ready", traitReport);
        EraLog.Info(EraLogCategory.Data, traitReport);
        EraStatusRegistrationReport statusRegistrationReport = EraStatusRegistrationService.Register();
        string statusReport = $"EW-060 运行时状态已初始化：{statusRegistrationReport.CreateStatusReport()}";
        draft.EventLog.Append("bootstrap", "runtime_status_registry_ready", statusReport);
        EraLog.Info(EraLogCategory.Data, statusReport);
        draft.CombatRuntime = new EraCombatRuntimeService(draft.StableRandom);
        string combatReport = $"EW-062~072 战斗原语与首批魔王技能已初始化：{draft.CombatRuntime.CreateStatusReport()}";
        draft.EventLog.Append("bootstrap", "combat_runtime_ready", combatReport);
        EraLog.Info(EraLogCategory.Combat, combatReport);
        EraEquipmentRegistrationReport equipmentRegistrationReport = EraEquipmentRegistrationService.Register(draft.ContentCatalog, draft.SpriteCatalog);
        draft.CombatRuntime.Equipment.BindNativeEquipmentActions();
        string equipmentReport = $"EW-030~033 装备静态注册已初始化：{equipmentRegistrationReport.CreateStatusReport()}";
        draft.EventLog.Append("bootstrap", "equipment_registry_ready", equipmentReport);
        EraLog.Info(EraLogCategory.Data, equipmentReport);
        string baseStatVisibilityReport = EraBaseStatVisibilityService.ApplyOverrides();
        string baseStatVisibilityMessage = $"原版 base stat 可视化修正已初始化：{baseStatVisibilityReport}";
        draft.EventLog.Append("bootstrap", "base_stat_visibility_ready", baseStatVisibilityMessage);
        EraLog.Info(EraLogCategory.Data, baseStatVisibilityMessage);
        EraValidationReport runtimeValidationReport = EraStartupValidator.ValidateRuntimeState(draft.ContentCatalog);
        LogValidationIssues(runtimeValidationReport);
        draft.ValidationReport = draft.ValidationReport.Merge(runtimeValidationReport);
        draft.ValidationReport.ThrowIfBlocking();
        draft.AdvancementRuntime = new EraAdvancementRuntimeService(
            parameterRegistry,
            draft.RuntimeSave,
            draft.StableRandom,
            draft.EventLog,
            draft.ContentCatalog
        );
        string advancementReport = $"EW-088~092 轮回进阶运行时已初始化：{draft.AdvancementRuntime.CreateStatusReport()}";
        draft.EventLog.Append("bootstrap", "advancement_runtime_ready", advancementReport);
        EraLog.Info(EraLogCategory.Events, advancementReport);
        draft.LevelRuntime = new EraLevelRuntimeService(
            parameterRegistry,
            draft.StableRandom,
            draft.EventLog
        );
        string levelReport = $"EW-095 等级账本运行时已初始化：{draft.LevelRuntime.CreateStatusReport()}";
        draft.EventLog.Append("bootstrap", "level_runtime_ready", levelReport);
        EraLog.Info(EraLogCategory.Events, levelReport);
        draft.KingdomRuntime = new EraKingdomRuntimeService(
            parameterRegistry,
            draft.StableRandom,
            draft.EventLog,
            draft.RuntimeSave
        );
        string kingdomRuntimeReport = $"EW-096 王国声望运行时已初始化：{draft.KingdomRuntime.CreateStatusReport()}";
        draft.EventLog.Append("bootstrap", "kingdom_runtime_ready", kingdomRuntimeReport);
        EraLog.Info(EraLogCategory.Events, kingdomRuntimeReport);
        draft.ProgressionRuntime = new EraProgressionRuntimeService(
            parameterRegistry,
            draft.StableRandom,
            draft.EventLog,
            draft.AdvancementRuntime,
            draft.RuntimeSave,
            draft.GrowthRanges,
            draft.ContentCatalog
        );
        string progressionReport = $"EW-093/097~100 成长实例与英雄运行时已初始化：{draft.ProgressionRuntime.CreateStatusReport()}";
        draft.EventLog.Append("bootstrap", "progression_runtime_ready", progressionReport);
        EraLog.Info(EraLogCategory.Events, progressionReport);
        EraActorRegistrationReport actorRegistrationReport = EraActorRegistrationService.Register(draft.ContentCatalog, draft.SpriteCatalog);
        string actorReport = $"EW-034~036 单位模板注册已初始化：{actorRegistrationReport.CreateStatusReport()}";
        draft.EventLog.Append("bootstrap", "actor_registry_ready", actorReport);
        EraLog.Info(EraLogCategory.Data, actorReport);
        EraBuildingRegistrationReport buildingRegistrationReport = EraBuildingRegistrationService.Register(draft.ContentCatalog, draft.SpriteCatalog);
        string buildingReport = $"EW-037 据点模板注册已初始化：{buildingRegistrationReport.CreateStatusReport()}";
        draft.EventLog.Append("bootstrap", "stronghold_registry_ready", buildingReport);
        EraLog.Info(EraLogCategory.Data, buildingReport);
        draft.ReincarnationRuntime = new EraReincarnationRuntimeService(
            parameterRegistry,
            draft.RuntimeSave,
            draft.StableRandom,
            draft.EventLog,
            draft.ContentCatalog,
            draft.GrowthRanges,
            draft.AdvancementRuntime
        );
        draft.StoryRuntime = new EraStoryRuntimeService(draft.RuntimeSave);
        draft.BestiaryCatalog = EraBestiaryCatalogBuilder.Build(draft.ContentCatalog, draft.SpriteCatalog);
        string bestiaryReport = $"EW-038 静态图鉴目录已初始化：{draft.BestiaryCatalog.CreateStatusReport()}";
        draft.EventLog.Append("bootstrap", "bestiary_catalog_ready", bestiaryReport);
        EraLog.Info(EraLogCategory.Data, bestiaryReport);
        return draft;
    }

    private static void RestoreAssetRegistrySnapshot(EraAssetRegistrySnapshot snapshot)
    {
        try
        {
            if (EraAssetRegistryRollbackService.TryRestoreRuntimeRegistry(snapshot, out string message))
            {
                EraLog.Info(EraLogCategory.Data, $"运行态重建失败，已恢复 AssetManager 注册表：{message}");
                return;
            }

            EraLog.Warning(EraLogCategory.Data, $"运行态重建失败，AssetManager 注册表恢复不完整：{message}");
        }
        catch (Exception exception)
        {
            EraLog.Exception(EraLogCategory.Data, "运行态重建失败后恢复 AssetManager 注册表时再次失败。", exception);
        }
    }

    private static void CommitRuntimeDraft(EraRuntimeDraft draft, bool persistAfterRebuild)
    {
        _modRootPath = draft.ModRootPath;
        ContentCatalog = draft.ContentCatalog;
        SpriteCatalog = draft.SpriteCatalog;
        BestiaryCatalog = draft.BestiaryCatalog;
        RuntimeSave = draft.RuntimeSave;
        StableRandom = draft.StableRandom;
        EventLog = draft.EventLog;
        GrowthRanges = draft.GrowthRanges;
        AdvancementRuntime = draft.AdvancementRuntime;
        LevelRuntime = draft.LevelRuntime;
        KingdomRuntime = draft.KingdomRuntime;
        ProgressionRuntime = draft.ProgressionRuntime;
        ReincarnationRuntime = draft.ReincarnationRuntime;
        StoryRuntime = draft.StoryRuntime;
        ValidationReport = draft.ValidationReport;
        CombatRuntime = draft.CombatRuntime;
        BindRuntimeBridges();

        if (persistAfterRebuild)
        {
            RuntimeSave.PersistIfPossible();
        }
    }

    private static void BindRuntimeBridges()
    {
        CombatRuntime?.Bind();
        if (CombatRuntime == null)
        {
            EraCombatRuntimeBridge.Bind(null);
        }

        AdvancementRuntime?.Bind();
        if (AdvancementRuntime == null)
        {
            EraAdvancementRuntimeBridge.Bind(null);
        }

        LevelRuntime?.Bind();
        if (LevelRuntime == null)
        {
            EraLevelRuntimeBridge.Bind(null);
        }

        KingdomRuntime?.Bind();
        if (KingdomRuntime == null)
        {
            EraKingdomRuntimeBridge.Bind(null);
        }

        ProgressionRuntime?.Bind();
        if (ProgressionRuntime == null)
        {
            EraProgressionRuntimeBridge.Bind(null);
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

        RunRuntimeUpdateStep(EraLogCategory.Events, "reincarnation", () => ReincarnationRuntime?.Update());
        RunRuntimeUpdateStep(
            EraLogCategory.Events,
            "advancement",
            () => AdvancementRuntime?.Update(RuntimeSave?.CurrentState.LastObservedWorldTime ?? 0f)
        );
        RunRuntimeUpdateStep(EraLogCategory.Events, "level", () => LevelRuntime?.Update());
        RunRuntimeUpdateStep(EraLogCategory.Events, "kingdom", () => KingdomRuntime?.Update());
        RunRuntimeUpdateStep(EraLogCategory.Events, "progression", () => ProgressionRuntime?.Update());
        RunRuntimeUpdateStep(EraLogCategory.Combat, "combat", () => CombatRuntime?.Update());
    }

    private static void RunRuntimeUpdateStep(EraLogCategory category, string stage, Action action)
    {
        EraRuntimeStepGuard.RunRuntimeStep(
            category,
            "runtime_update_step",
            stage,
            RuntimeSave?.CurrentState.CompletedCycles ?? 0,
            RuntimeSave?.CurrentState.LastObservedWorldTime ?? 0f,
            action
        );
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

    private static void LogValidationIssues(EraValidationReport report)
    {
        if (report.Issues.Count == 0)
        {
            EraLog.Info(EraLogCategory.Validation, "启动校验通过，没有发现 EW-017 阻塞项。");
            return;
        }

        foreach (EraValidationIssue issue in report.Issues)
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

    private static void LogValidationChecklist(EraValidationReport report)
    {
        EraLog.Info(EraLogCategory.Validation, "EW-114 启动自检清单：");
        foreach (string line in report.CreateChecklistLines())
        {
            EraLog.Info(EraLogCategory.Validation, line);
        }
    }

    private sealed class EraRuntimeDraft
    {
        public string ModRootPath { get; set; } = string.Empty;
        public EraContentCatalog ContentCatalog { get; set; } = EraContentCatalog.Empty;
        public EraSpriteCatalog SpriteCatalog { get; set; } = EraSpriteCatalog.Empty;
        public EraBestiaryCatalog BestiaryCatalog { get; set; } = EraBestiaryCatalog.Empty;
        public EraRuntimeSaveService RuntimeSave { get; set; } = null!;
        public EraStableRandomService StableRandom { get; set; } = null!;
        public EraEventLogService EventLog { get; set; } = null!;
        public EraGrowthRangeManager GrowthRanges { get; set; } = null!;
        public EraAdvancementRuntimeService AdvancementRuntime { get; set; } = null!;
        public EraLevelRuntimeService LevelRuntime { get; set; } = null!;
        public EraKingdomRuntimeService KingdomRuntime { get; set; } = null!;
        public EraProgressionRuntimeService ProgressionRuntime { get; set; } = null!;
        public EraReincarnationRuntimeService ReincarnationRuntime { get; set; } = null!;
        public EraStoryRuntimeService StoryRuntime { get; set; } = null!;
        public EraValidationReport ValidationReport { get; set; } = EraValidationReport.Empty;
        public EraCombatRuntimeService CombatRuntime { get; set; } = null!;
    }
}
