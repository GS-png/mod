using System;
using EraWheel.Config.Schema;
using Newtonsoft.Json;

namespace EraWheel.Config.Migration;

public static class EraConfigVersioning
{
    public const int CurrentVersion = 1;
}

public sealed class EraConfigDocument
{
    [JsonProperty("config_version")]
    public int ConfigVersion { get; set; } = EraConfigVersioning.CurrentVersion;

    [JsonProperty("exported_at_utc")]
    public string ExportedAtUtc { get; set; } = string.Empty;

    [JsonProperty("parameters")]
    public EraRuntimeParameters Parameters { get; set; } = new EraRuntimeParameters();
}

public sealed class EraConfigMigrationResult
{
    public EraConfigDocument Document { get; }
    public bool MigrationApplied { get; }
    public string Summary { get; }

    public EraConfigMigrationResult(EraConfigDocument document, bool migrationApplied, string summary)
    {
        Document = document;
        MigrationApplied = migrationApplied;
        Summary = summary;
    }
}

public sealed class EraConfigBackupRecord
{
    public string BackupId { get; set; } = string.Empty;
    public string Reason { get; set; } = string.Empty;
    public string CreatedAtUtc { get; set; } = string.Empty;
    public EraConfigDocument Document { get; set; } = new EraConfigDocument();
}

public sealed class EraConfigBackupPolicy
{
    public bool BackupBeforeImport { get; }
    public int MaxBackupCount { get; }

    public EraConfigBackupPolicy(bool backupBeforeImport, int maxBackupCount)
    {
        BackupBeforeImport = backupBeforeImport;
        MaxBackupCount = maxBackupCount;
    }

    public static EraConfigBackupPolicy CreateDefault()
    {
        return new EraConfigBackupPolicy(backupBeforeImport: true, maxBackupCount: 5);
    }

    public EraConfigBackupRecord CreateBackup(string reason, EraRuntimeParameters parameters)
    {
        return new EraConfigBackupRecord
        {
            BackupId = $"ew_cfg_backup_{DateTime.UtcNow:yyyyMMddHHmmss}",
            Reason = reason,
            CreatedAtUtc = DateTime.UtcNow.ToString("O"),
            Document = new EraConfigMigrator().Snapshot(parameters).Document,
        };
    }

    public string CreateStatusReport()
    {
        return $"导入前备份={(BackupBeforeImport ? "开启" : "关闭")}；最多保留 {MaxBackupCount} 份。";
    }
}

public sealed class EraConfigMigrator
{
    public EraConfigMigrationResult Snapshot(EraRuntimeParameters parameters)
    {
        EraConfigDocument document = CreateDocument(parameters, EraConfigVersioning.CurrentVersion);
        return new EraConfigMigrationResult(document, migrationApplied: false, "当前配置已处于最新版本。");
    }

    public EraConfigMigrationResult Migrate(EraConfigDocument? document)
    {
        if (document == null)
        {
            throw new InvalidOperationException("配置文档为空，无法迁移。");
        }

        EraConfigDocument normalized = CloneDocument(document);
        if (normalized.ConfigVersion == EraConfigVersioning.CurrentVersion)
        {
            return new EraConfigMigrationResult(normalized, migrationApplied: false, "当前配置已处于最新版本。");
        }

        if (normalized.ConfigVersion <= 0)
        {
            normalized.ConfigVersion = EraConfigVersioning.CurrentVersion;
            if (string.IsNullOrWhiteSpace(normalized.ExportedAtUtc))
            {
                normalized.ExportedAtUtc = DateTime.UtcNow.ToString("O");
            }

            return new EraConfigMigrationResult(normalized, migrationApplied: true, "已将旧版配置文档补齐到当前 config_version。");
        }

        throw new InvalidOperationException(
            $"暂不支持将 config_version={normalized.ConfigVersion} 迁移到 {EraConfigVersioning.CurrentVersion}。"
        );
    }

    private static EraConfigDocument CreateDocument(EraRuntimeParameters parameters, int configVersion)
    {
        string now = DateTime.UtcNow.ToString("O");
        return CloneDocument(
            new EraConfigDocument
            {
                ConfigVersion = configVersion,
                ExportedAtUtc = now,
                Parameters = parameters ?? new EraRuntimeParameters(),
            }
        );
    }

    private static EraConfigDocument CloneDocument(EraConfigDocument document)
    {
        string json = JsonConvert.SerializeObject(document);
        return JsonConvert.DeserializeObject<EraConfigDocument>(json) ?? new EraConfigDocument();
    }
}
