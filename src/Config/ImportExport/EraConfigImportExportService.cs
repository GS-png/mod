using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using EraWheel.Config.Migration;
using EraWheel.Config.Registry;
using EraWheel.Config.Schema;
using EraWheel.Core.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace EraWheel.Config.ImportExport;

public sealed class EraConfigDiffEntry
{
    public string Path { get; set; } = string.Empty;
    public string CurrentValue { get; set; } = string.Empty;
    public string IncomingValue { get; set; } = string.Empty;
}

public sealed class EraConfigImportPreview
{
    public string SourcePath { get; set; } = string.Empty;
    public EraConfigMigrationResult Migration { get; set; } = new EraConfigMigrationResult(new EraConfigDocument(), false, "未生成预览。");
    public List<EraConfigDiffEntry> Differences { get; set; } = new List<EraConfigDiffEntry>();
}

public sealed class EraConfigImportExportService
{
    private readonly EraConfigMigrator _migrator;
    private readonly EraConfigBackupPolicy _backupPolicy;
    private readonly EraParameterRegistry _registry;
    private static readonly UTF8Encoding JsonEncoding = new UTF8Encoding(false);

    public string BaseDirectory { get; }
    public string ExportDirectory { get; }
    public string BackupDirectory { get; }
    public string ActiveConfigPath { get; }
    public string DraftImportPath { get; set; } = string.Empty;
    public string LastStatusMessage { get; private set; } = "尚未执行导入导出。";
    public string LastExportPath { get; private set; } = string.Empty;
    public string LastBackupPath { get; private set; } = string.Empty;
    public bool LoadedActiveDocument { get; private set; }
    public EraConfigImportPreview? PendingPreview { get; private set; }

    private EraConfigImportExportService(
        EraConfigMigrator migrator,
        EraConfigBackupPolicy backupPolicy,
        EraParameterRegistry registry)
    {
        _migrator = migrator;
        _backupPolicy = backupPolicy;
        _registry = registry;
        BaseDirectory = Path.Combine(Application.persistentDataPath, "EraWheel", "Config");
        ExportDirectory = Path.Combine(BaseDirectory, "Exports");
        BackupDirectory = Path.Combine(BaseDirectory, "Backups");
        ActiveConfigPath = Path.Combine(BaseDirectory, "active_parameters.json");
    }

    public static EraConfigImportExportService Create(
        EraConfigMigrator migrator,
        EraConfigBackupPolicy backupPolicy,
        EraParameterRegistry registry)
    {
        EraConfigImportExportService service = new(migrator, backupPolicy, registry);
        service.Initialize();
        return service;
    }

    public bool ExportCurrentParameters(out string path)
    {
        path = string.Empty;

        try
        {
            EnsureDirectories();
            path = Path.Combine(ExportDirectory, $"erawheel_parameters_{DateTime.UtcNow:yyyyMMdd_HHmmss}.json");
            EraConfigDocument document = _migrator.Snapshot(_registry.CloneCurrent()).Document;
            WriteDocument(path, document);
            LastExportPath = path;
            if (string.IsNullOrWhiteSpace(DraftImportPath))
            {
                DraftImportPath = path;
            }

            LastStatusMessage = $"已导出当前玩法参数：{DescribePath(path)}";
            LogConfigAction(
                "export_parameters",
                "success",
                document.ConfigVersion,
                migrationApplied: false,
                backupCreated: false,
                rollbackMemory: false,
                path);
            return true;
        }
        catch (Exception exception)
        {
            LastStatusMessage = $"导出失败：{DescribeException(exception)}";
            LogConfigAction(
                "export_parameters",
                "failed",
                EraConfigVersioning.CurrentVersion,
                migrationApplied: false,
                backupCreated: false,
                rollbackMemory: false,
                path);
            return false;
        }
    }

    public bool TryPreviewImport(out EraConfigImportPreview? preview)
    {
        preview = null;
        string path = string.Empty;

        try
        {
            path = NormalizePath(DraftImportPath);
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            {
                LastStatusMessage = "预览失败：导入文件不存在，请先填写有效路径。";
                PendingPreview = null;
                return false;
            }

            EraConfigDocument document = ReadDocument(path);
            EraConfigMigrationResult migration = _migrator.Migrate(document);
            preview = new EraConfigImportPreview
            {
                SourcePath = path,
                Migration = migration,
                Differences = BuildDifferences(_registry.CloneCurrent(), migration.Document.Parameters),
            };
            PendingPreview = preview;
            DraftImportPath = path;
            LastStatusMessage = $"已生成导入预览：{preview.Differences.Count} 处差异。";
            LogConfigAction(
                "preview_import",
                "success",
                migration.Document.ConfigVersion,
                migration.MigrationApplied,
                backupCreated: false,
                rollbackMemory: false,
                path);
            return true;
        }
        catch (Exception exception)
        {
            LastStatusMessage = $"预览失败：{DescribeException(exception, path)}";
            PendingPreview = null;
            LogConfigAction(
                "preview_import",
                "failed",
                EraConfigVersioning.CurrentVersion,
                migrationApplied: false,
                backupCreated: false,
                rollbackMemory: false,
                path);
            return false;
        }
    }

    public bool ApplyPendingImport()
    {
        if (PendingPreview == null)
        {
            LastStatusMessage = "还没有可应用的导入预览。";
            LogConfigAction(
                "apply_import",
                "skipped_no_preview",
                EraConfigVersioning.CurrentVersion,
                migrationApplied: false,
                backupCreated: false,
                rollbackMemory: false,
                string.Empty);
            return false;
        }

        EraConfigImportPreview preview = PendingPreview;
        EraRuntimeParameters baseline = _registry.CloneCurrent();
        bool loadedBeforeApply = LoadedActiveDocument;
        bool backupCreated = false;

        try
        {
            EnsureDirectories();
            if (_backupPolicy.BackupBeforeImport)
            {
                LastBackupPath = WriteBackup("apply_import", baseline);
                backupCreated = true;
                PruneBackups();
            }

            _registry.ReplaceCurrent(preview.Migration.Document.Parameters);
            WriteDocument(ActiveConfigPath, preview.Migration.Document);
            LoadedActiveDocument = true;
            LastStatusMessage = $"导入应用成功：{DescribePath(preview.SourcePath)}";
            PendingPreview = null;
            LogConfigAction(
                "apply_import",
                "success",
                preview.Migration.Document.ConfigVersion,
                preview.Migration.MigrationApplied,
                backupCreated,
                rollbackMemory: false,
                preview.SourcePath);
            return true;
        }
        catch (Exception exception)
        {
            _registry.ReplaceCurrent(baseline);
            LoadedActiveDocument = loadedBeforeApply;
            LastStatusMessage = $"导入应用失败，已回滚内存参数：{DescribeException(exception)}";
            LogConfigAction(
                "apply_import",
                "failed",
                preview.Migration.Document.ConfigVersion,
                preview.Migration.MigrationApplied,
                backupCreated,
                rollbackMemory: true,
                preview.SourcePath);
            return false;
        }
    }

    public bool RollbackLastImport()
    {
        EraRuntimeParameters baseline = _registry.CloneCurrent();
        bool loadedBeforeRollback = LoadedActiveDocument;

        try
        {
            string? path = !string.IsNullOrWhiteSpace(LastBackupPath) && File.Exists(LastBackupPath)
                ? LastBackupPath
                : FindLatestBackupPath();
            if (string.IsNullOrWhiteSpace(path))
            {
                LastStatusMessage = "当前没有可回滚的导入备份。";
                LogConfigAction(
                    "rollback_import",
                    "skipped_no_backup",
                    EraConfigVersioning.CurrentVersion,
                    migrationApplied: false,
                    backupCreated: false,
                    rollbackMemory: false,
                    string.Empty);
                return false;
            }

            EraConfigBackupRecord backup = ReadBackup(path);
            _registry.ReplaceCurrent(backup.Document.Parameters);
            WriteDocument(ActiveConfigPath, backup.Document);
            LastBackupPath = path;
            LoadedActiveDocument = true;
            PendingPreview = null;
            LastStatusMessage = $"已回滚到备份：{backup.BackupId}";
            LogConfigAction(
                "rollback_import",
                "success",
                backup.Document.ConfigVersion,
                migrationApplied: false,
                backupCreated: false,
                rollbackMemory: false,
                path);
            return true;
        }
        catch (Exception exception)
        {
            _registry.ReplaceCurrent(baseline);
            LoadedActiveDocument = loadedBeforeRollback;
            LastStatusMessage = $"回滚失败，已恢复操作前内存参数：{DescribeException(exception)}";
            LogConfigAction(
                "rollback_import",
                "failed",
                EraConfigVersioning.CurrentVersion,
                migrationApplied: false,
                backupCreated: false,
                rollbackMemory: true,
                LastBackupPath);
            return false;
        }
    }

    public bool SaveCurrentAsActive(string reason)
    {
        try
        {
            EnsureDirectories();
            EraConfigDocument document = _migrator.Snapshot(_registry.CloneCurrent()).Document;
            WriteDocument(ActiveConfigPath, document);
            LoadedActiveDocument = true;
            LastStatusMessage = $"已保存当前玩法参数：{reason}";
            LogConfigAction(
                "save_active",
                "success",
                document.ConfigVersion,
                migrationApplied: false,
                backupCreated: false,
                rollbackMemory: false,
                ActiveConfigPath);
            return true;
        }
        catch (Exception exception)
        {
            LastStatusMessage = $"保存当前玩法参数失败：{DescribeException(exception)}";
            LogConfigAction(
                "save_active",
                "failed",
                EraConfigVersioning.CurrentVersion,
                migrationApplied: false,
                backupCreated: false,
                rollbackMemory: false,
                ActiveConfigPath);
            return false;
        }
    }

    public string CreateStatusReport()
    {
        return string.Join(
            " ",
            $"激活参数文档={(LoadedActiveDocument ? "已加载" : "未加载")}",
            "导出目录=Config/Exports",
            "备份目录=Config/Backups",
            string.IsNullOrWhiteSpace(LastExportPath) ? "尚未导出。" : $"最近导出={DescribePath(LastExportPath)}",
            string.IsNullOrWhiteSpace(LastBackupPath) ? "尚无回滚备份。" : $"最近备份={DescribePath(LastBackupPath)}"
        );
    }

    public string CreatePreviewReport()
    {
        if (PendingPreview == null)
        {
            return "当前没有待应用的导入预览。";
        }

        List<string> lines = new()
        {
            $"预览来源：{DescribePath(PendingPreview.SourcePath)}",
            $"迁移结果：{PendingPreview.Migration.Summary}",
            $"差异数量：{PendingPreview.Differences.Count}",
        };
        foreach (EraConfigDiffEntry diff in PendingPreview.Differences.Take(8))
        {
            lines.Add($"- {diff.Path}: {diff.CurrentValue} -> {diff.IncomingValue}");
        }

        if (PendingPreview.Differences.Count > 8)
        {
            lines.Add($"- 还有 {PendingPreview.Differences.Count - 8} 处差异未展开。");
        }

        return string.Join(Environment.NewLine, lines);
    }

    private void Initialize()
    {
        EraRuntimeParameters baseline = _registry.CloneCurrent();
        bool loadedBeforeInitialize = LoadedActiveDocument;

        try
        {
            EnsureDirectories();
            if (!File.Exists(ActiveConfigPath))
            {
                LoadedActiveDocument = false;
                LastStatusMessage = "当前没有激活参数文档，启动时继续使用内置默认值。";
                LogConfigAction(
                    "initialize_active",
                    "seed_defaults",
                    EraConfigVersioning.CurrentVersion,
                    migrationApplied: false,
                    backupCreated: false,
                    rollbackMemory: false,
                    ActiveConfigPath);
                return;
            }

            EraConfigDocument document = ReadDocument(ActiveConfigPath);
            EraConfigMigrationResult migration = _migrator.Migrate(document);
            _registry.ReplaceCurrent(migration.Document.Parameters);
            LoadedActiveDocument = true;
            LastStatusMessage = "启动时已读取激活参数文档。";
            if (migration.MigrationApplied)
            {
                WriteDocument(ActiveConfigPath, migration.Document);
            }
            LogConfigAction(
                "initialize_active",
                "success",
                migration.Document.ConfigVersion,
                migration.MigrationApplied,
                backupCreated: false,
                rollbackMemory: false,
                ActiveConfigPath);
        }
        catch (Exception exception)
        {
            _registry.ReplaceCurrent(baseline);
            LoadedActiveDocument = loadedBeforeInitialize;
            LastStatusMessage = $"读取激活参数文档失败，已保留启动前参数：{DescribeException(exception)}";
            LogConfigAction(
                "initialize_active",
                "failed",
                EraConfigVersioning.CurrentVersion,
                migrationApplied: false,
                backupCreated: false,
                rollbackMemory: true,
                ActiveConfigPath);
        }
    }

    private void EnsureDirectories()
    {
        Directory.CreateDirectory(BaseDirectory);
        Directory.CreateDirectory(ExportDirectory);
        Directory.CreateDirectory(BackupDirectory);
    }

    private string WriteBackup(string reason, EraRuntimeParameters sourceParameters)
    {
        EraConfigBackupRecord record = _backupPolicy.CreateBackup(reason, sourceParameters);
        string path = Path.Combine(BackupDirectory, $"{record.BackupId}.json");
        string json = JsonConvert.SerializeObject(record, Formatting.Indented);
        WriteJsonAtomically(path, json);
        return path;
    }

    private string? FindLatestBackupPath()
    {
        if (!Directory.Exists(BackupDirectory))
        {
            return null;
        }

        return Directory.EnumerateFiles(BackupDirectory, "*.json")
            .OrderByDescending(path => path, StringComparer.Ordinal)
            .FirstOrDefault();
    }

    private void PruneBackups()
    {
        if (_backupPolicy.MaxBackupCount < 1 || !Directory.Exists(BackupDirectory))
        {
            return;
        }

        string[] backups = Directory.EnumerateFiles(BackupDirectory, "*.json")
            .OrderByDescending(path => path, StringComparer.Ordinal)
            .ToArray();
        foreach (string path in backups.Skip(_backupPolicy.MaxBackupCount))
        {
            File.Delete(path);
        }
    }

    private static EraConfigDocument ReadDocument(string path)
    {
        string json = File.ReadAllText(path);
        EraConfigDocument? document = JsonConvert.DeserializeObject<EraConfigDocument>(json);
        if (document == null)
        {
            throw new InvalidOperationException($"无法解析配置文档：{Path.GetFileName(path)}");
        }

        return document;
    }

    private static EraConfigBackupRecord ReadBackup(string path)
    {
        string json = File.ReadAllText(path);
        EraConfigBackupRecord? record = JsonConvert.DeserializeObject<EraConfigBackupRecord>(json);
        if (record == null)
        {
            throw new InvalidOperationException($"无法解析配置备份：{Path.GetFileName(path)}");
        }

        return record;
    }

    private void WriteDocument(string path, EraConfigDocument document)
    {
        string json = JsonConvert.SerializeObject(document, Formatting.Indented);
        WriteJsonAtomically(path, json);
    }

    private static void WriteJsonAtomically(string path, string json)
    {
        string targetPath = Path.GetFullPath(path);
        string? directory = Path.GetDirectoryName(targetPath);
        if (!string.IsNullOrWhiteSpace(directory))
        {
            Directory.CreateDirectory(directory);
        }

        string tempPath = Path.Combine(
            directory ?? string.Empty,
            $".{Path.GetFileName(targetPath)}.{Guid.NewGuid():N}.tmp");

        try
        {
            using (FileStream stream = new FileStream(tempPath, FileMode.CreateNew, FileAccess.Write, FileShare.None))
            using (StreamWriter writer = new StreamWriter(stream, JsonEncoding))
            {
                writer.Write(json);
                writer.Flush();
                stream.Flush(true);
            }

            if (File.Exists(targetPath))
            {
                File.Replace(tempPath, targetPath, null);
            }
            else
            {
                File.Move(tempPath, targetPath);
            }
        }
        catch
        {
            TryDeleteTempFile(tempPath);
            throw;
        }
    }

    private static void TryDeleteTempFile(string path)
    {
        try
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
        catch
        {
        }
    }

    private static string NormalizePath(string? rawPath)
    {
        if (string.IsNullOrWhiteSpace(rawPath))
        {
            return string.Empty;
        }

        return Path.GetFullPath(rawPath.Trim());
    }

    private static List<EraConfigDiffEntry> BuildDifferences(EraRuntimeParameters current, EraRuntimeParameters incoming)
    {
        Dictionary<string, string> currentFlat = Flatten(current);
        Dictionary<string, string> incomingFlat = Flatten(incoming);
        HashSet<string> keys = new(currentFlat.Keys, StringComparer.Ordinal);
        keys.UnionWith(incomingFlat.Keys);

        List<EraConfigDiffEntry> differences = new();
        foreach (string key in keys.OrderBy(item => item, StringComparer.Ordinal))
        {
            currentFlat.TryGetValue(key, out string? currentValue);
            incomingFlat.TryGetValue(key, out string? incomingValue);
            currentValue ??= "<null>";
            incomingValue ??= "<null>";
            if (string.Equals(currentValue, incomingValue, StringComparison.Ordinal))
            {
                continue;
            }

            differences.Add(
                new EraConfigDiffEntry
                {
                    Path = key,
                    CurrentValue = currentValue,
                    IncomingValue = incomingValue,
                });
        }

        return differences;
    }

    private static Dictionary<string, string> Flatten(object value)
    {
        Dictionary<string, string> flattened = new(StringComparer.Ordinal);
        FlattenToken(JToken.FromObject(value), string.Empty, flattened);
        return flattened;
    }

    private static void FlattenToken(JToken token, string path, IDictionary<string, string> target)
    {
        switch (token.Type)
        {
            case JTokenType.Object:
                foreach (JProperty property in token.Children<JProperty>())
                {
                    string nextPath = string.IsNullOrWhiteSpace(path)
                        ? property.Name
                        : $"{path}.{property.Name}";
                    FlattenToken(property.Value, nextPath, target);
                }
                break;
            case JTokenType.Array:
                int index = 0;
                foreach (JToken child in token.Children())
                {
                    FlattenToken(child, $"{path}[{index}]", target);
                    index++;
                }
                if (index == 0)
                {
                    target[path] = "[]";
                }
                break;
            default:
                target[path] = token.Type == JTokenType.Float
                    ? token.Value<float>().ToString("0.###", CultureInfo.InvariantCulture)
                    : token.ToString(Formatting.None);
                break;
        }
    }

    private void LogConfigAction(
        string action,
        string result,
        int configVersion,
        bool migrationApplied,
        bool backupCreated,
        bool rollbackMemory,
        string path)
    {
        string message = string.Join(
            " ",
            $"action={action}",
            $"result={result}",
            $"config_version={configVersion}",
            $"migration_applied={FormatBool(migrationApplied)}",
            $"backup_created={FormatBool(backupCreated)}",
            $"rollback_memory={FormatBool(rollbackMemory)}",
            $"file={DescribePath(path)}");

        if (string.Equals(result, "success", StringComparison.Ordinal)
            || string.Equals(result, "seed_defaults", StringComparison.Ordinal)
            || result.StartsWith("skipped_", StringComparison.Ordinal))
        {
            EraLog.Info(EraLogCategory.Config, message);
            return;
        }

        EraLog.Warning(EraLogCategory.Config, message);
    }

    private string DescribeException(Exception exception, params string[] additionalPaths)
    {
        string message = SanitizePathText(exception.Message, additionalPaths);
        return string.IsNullOrWhiteSpace(message)
            ? exception.GetType().Name
            : $"{exception.GetType().Name}: {message}";
    }

    private string SanitizePathText(string message, params string[] additionalPaths)
    {
        string sanitized = message ?? string.Empty;
        sanitized = ReplaceKnownPath(sanitized, BaseDirectory);
        sanitized = ReplaceKnownPath(sanitized, ExportDirectory);
        sanitized = ReplaceKnownPath(sanitized, BackupDirectory);
        sanitized = ReplaceKnownPath(sanitized, ActiveConfigPath);
        sanitized = ReplaceKnownPath(sanitized, DraftImportPath);
        sanitized = ReplaceKnownPath(sanitized, LastExportPath);
        sanitized = ReplaceKnownPath(sanitized, LastBackupPath);
        foreach (string path in additionalPaths)
        {
            sanitized = ReplaceKnownPath(sanitized, path);
        }

        return string.IsNullOrWhiteSpace(Application.persistentDataPath)
            ? sanitized
            : sanitized.Replace(Application.persistentDataPath, "persistentDataPath");
    }

    private string ReplaceKnownPath(string message, string path)
    {
        if (string.IsNullOrWhiteSpace(path))
        {
            return message;
        }

        return message.Replace(path, DescribePath(path));
    }

    private static string FormatBool(bool value)
    {
        return value ? "true" : "false";
    }

    private string DescribePath(string path)
    {
        if (string.IsNullOrWhiteSpace(path))
        {
            return "未生成";
        }

        try
        {
            string fullPath = Path.GetFullPath(path);
            string fullBase = Path.GetFullPath(BaseDirectory);
            if (fullPath.StartsWith(fullBase, StringComparison.OrdinalIgnoreCase))
            {
                return fullPath.Substring(fullBase.Length).TrimStart(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
            }

            return Path.GetFileName(fullPath);
        }
        catch
        {
            return Path.GetFileName(path);
        }
    }
}
