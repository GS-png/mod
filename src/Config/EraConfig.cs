using System.Collections.Generic;
using EraWheel.Config.ImportExport;
using EraWheel.Config.Migration;
using EraWheel.Config.Registry;
using EraWheel.Config.Schema;
using EraWheel.Core.Constants;
using NeoModLoader.api;
using NeoModLoader.api.attributes;

namespace EraWheel.Config;

public static class EraConfig
{
    private static ModConfig? _config;

    public static EraParameterRegistry ParameterRegistry { get; private set; } = EraParameterRegistry.Create(null);
    public static EraConfigMigrator ConfigMigrator { get; private set; } = new EraConfigMigrator();
    public static EraConfigBackupPolicy BackupPolicy { get; private set; } = EraConfigBackupPolicy.CreateDefault();
    public static EraConfigImportExportService? ImportExport { get; private set; }
    public static EraConfigMigrationResult VersioningSnapshot { get; private set; }
        = new EraConfigMigrator().Snapshot(new EraRuntimeParameters());

    public static bool DevelopmentMode { get; private set; }
    public static bool EnableActorDetailPatch { get; private set; } = true;
    public static bool EnableKingdomDetailPatch { get; private set; } = true;
    public static bool EnableTopTabRetryVerboseLog { get; private set; } = true;

    public static ModConfig? RawConfig => _config;
    public static EraRuntimeParameters Parameters => ParameterRegistry.Current;

    internal static EraConfigSnapshot CaptureSnapshot()
    {
        return new EraConfigSnapshot(
            _config,
            ParameterRegistry,
            ConfigMigrator,
            BackupPolicy,
            ImportExport,
            VersioningSnapshot,
            DevelopmentMode,
            EnableActorDetailPatch,
            EnableKingdomDetailPatch,
            EnableTopTabRetryVerboseLog
        );
    }

    internal static void RestoreSnapshot(EraConfigSnapshot snapshot)
    {
        _config = snapshot.Config;
        ParameterRegistry = snapshot.ParameterRegistry;
        ConfigMigrator = snapshot.ConfigMigrator;
        BackupPolicy = snapshot.BackupPolicy;
        ImportExport = snapshot.ImportExport;
        VersioningSnapshot = snapshot.VersioningSnapshot;
        DevelopmentMode = snapshot.DevelopmentMode;
        EnableActorDetailPatch = snapshot.EnableActorDetailPatch;
        EnableKingdomDetailPatch = snapshot.EnableKingdomDetailPatch;
        EnableTopTabRetryVerboseLog = snapshot.EnableTopTabRetryVerboseLog;
    }

    [Hotfixable]
    public static void Initialize(ModDeclare declaration, ModConfig? config)
    {
        _config = config;
        DevelopmentMode = ReadSwitch(
            config,
            EraModConfigIds.DebugGroup,
            EraModConfigIds.DevelopmentMode,
            defaultValue: false
        );
        EnableActorDetailPatch = ReadSwitch(
            config,
            EraModConfigIds.DebugGroup,
            EraModConfigIds.EnableActorDetailPatch,
            defaultValue: true
        );
        EnableKingdomDetailPatch = ReadSwitch(
            config,
            EraModConfigIds.DebugGroup,
            EraModConfigIds.EnableKingdomDetailPatch,
            defaultValue: true
        );
        EnableTopTabRetryVerboseLog = ReadSwitch(
            config,
            EraModConfigIds.DebugGroup,
            EraModConfigIds.EnableTopTabRetryVerboseLog,
            defaultValue: true
        );
        ParameterRegistry = EraParameterRegistry.Create(config);
        ConfigMigrator = new EraConfigMigrator();
        BackupPolicy = EraConfigBackupPolicy.CreateDefault();
        ImportExport = EraConfigImportExportService.Create(
            ConfigMigrator,
            BackupPolicy,
            ParameterRegistry);
        VersioningSnapshot = ConfigMigrator.Snapshot(ParameterRegistry.Current);
    }

    private static bool ReadSwitch(ModConfig? config, string groupId, string itemId, bool defaultValue)
    {
        if (config == null)
        {
            return defaultValue;
        }

        try
        {
            if (config[groupId].TryGetValue(itemId, out ModConfigItem? item))
            {
                return item.BoolVal;
            }
        }
        catch (KeyNotFoundException)
        {
        }

        return defaultValue;
    }
}

internal sealed class EraConfigSnapshot
{
    public ModConfig? Config { get; }
    public EraParameterRegistry ParameterRegistry { get; }
    public EraConfigMigrator ConfigMigrator { get; }
    public EraConfigBackupPolicy BackupPolicy { get; }
    public EraConfigImportExportService? ImportExport { get; }
    public EraConfigMigrationResult VersioningSnapshot { get; }
    public bool DevelopmentMode { get; }
    public bool EnableActorDetailPatch { get; }
    public bool EnableKingdomDetailPatch { get; }
    public bool EnableTopTabRetryVerboseLog { get; }

    public EraConfigSnapshot(
        ModConfig? config,
        EraParameterRegistry parameterRegistry,
        EraConfigMigrator configMigrator,
        EraConfigBackupPolicy backupPolicy,
        EraConfigImportExportService? importExport,
        EraConfigMigrationResult versioningSnapshot,
        bool developmentMode,
        bool enableActorDetailPatch,
        bool enableKingdomDetailPatch,
        bool enableTopTabRetryVerboseLog
    )
    {
        Config = config;
        ParameterRegistry = parameterRegistry;
        ConfigMigrator = configMigrator;
        BackupPolicy = backupPolicy;
        ImportExport = importExport;
        VersioningSnapshot = versioningSnapshot;
        DevelopmentMode = developmentMode;
        EnableActorDetailPatch = enableActorDetailPatch;
        EnableKingdomDetailPatch = enableKingdomDetailPatch;
        EnableTopTabRetryVerboseLog = enableTopTabRetryVerboseLog;
    }
}
