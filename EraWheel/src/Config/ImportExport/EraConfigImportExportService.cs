using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using EraWheel.Config.Migration;
using EraWheel.Config.Schema;
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

    private EraConfigImportExportService(EraConfigMigrator migrator, EraConfigBackupPolicy backupPolicy)
    {
        _migrator = migrator;
        _backupPolicy = backupPolicy;
        BaseDirectory = Path.Combine(Application.persistentDataPath, "EraWheel", "Config");
        ExportDirectory = Path.Combine(BaseDirectory, "Exports");
        BackupDirectory = Path.Combine(BaseDirectory, "Backups");
        ActiveConfigPath = Path.Combine(BaseDirectory, "active_parameters.json");
    }

    public static EraConfigImportExportService Create(
        EraConfigMigrator migrator,
        EraConfigBackupPolicy backupPolicy,
        EraRuntimeParameters currentParameters)
    {
        EraConfigImportExportService service = new(migrator, backupPolicy);
        service.Initialize(currentParameters);
        return service;
    }

    public bool ExportCurrentParameters(EraRuntimeParameters currentParameters, out string path)
    {
        path = string.Empty;

        try
        {
            EnsureDirectories();
            path = Path.Combine(ExportDirectory, $"erawheel_parameters_{DateTime.UtcNow:yyyyMMdd_HHmmss}.json");
            EraConfigDocument document = _migrator.Snapshot(currentParameters).Document;
            WriteDocument(path, document);
            LastExportPath = path;
            if (string.IsNullOrWhiteSpace(DraftImportPath))
            {
                DraftImportPath = path;
            }

            LastStatusMessage = $"已导出当前玩法参数：{DescribePath(path)}";
            return true;
        }
        catch (Exception exception)
        {
            LastStatusMessage = $"导出失败：{exception.Message}";
            return false;
        }
    }

    public bool TryPreviewImport(EraRuntimeParameters currentParameters, out EraConfigImportPreview? preview)
    {
        preview = null;

        try
        {
            string path = NormalizePath(DraftImportPath);
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
                Differences = BuildDifferences(currentParameters, migration.Document.Parameters),
            };
            PendingPreview = preview;
            DraftImportPath = path;
            LastStatusMessage = $"已生成导入预览：{preview.Differences.Count} 处差异。";
            return true;
        }
        catch (Exception exception)
        {
            LastStatusMessage = $"预览失败：{exception.Message}";
            PendingPreview = null;
            return false;
        }
    }

    public bool ApplyPendingImport(EraRuntimeParameters currentParameters)
    {
        if (PendingPreview == null)
        {
            LastStatusMessage = "还没有可应用的导入预览。";
            return false;
        }

        EraRuntimeParameters snapshotBeforeApply = CloneParameters(currentParameters);

        try
        {
            EnsureDirectories();
            if (_backupPolicy.BackupBeforeImport)
            {
                LastBackupPath = WriteBackup("apply_import", currentParameters);
                PruneBackups();
            }

            ApplyParameters(currentParameters, PendingPreview.Migration.Document.Parameters);
            WriteDocument(ActiveConfigPath, PendingPreview.Migration.Document);
            LoadedActiveDocument = true;
            LastStatusMessage = $"导入应用成功：{DescribePath(PendingPreview.SourcePath)}";
            PendingPreview = null;
            return true;
        }
        catch (Exception exception)
        {
            ApplyParameters(currentParameters, snapshotBeforeApply);
            LastStatusMessage = $"导入应用失败，已回滚内存参数：{exception.Message}";
            return false;
        }
    }

    public bool RollbackLastImport(EraRuntimeParameters currentParameters)
    {
        try
        {
            string? path = !string.IsNullOrWhiteSpace(LastBackupPath) && File.Exists(LastBackupPath)
                ? LastBackupPath
                : FindLatestBackupPath();
            if (string.IsNullOrWhiteSpace(path))
            {
                LastStatusMessage = "当前没有可回滚的导入备份。";
                return false;
            }

            EraConfigBackupRecord backup = ReadBackup(path);
            ApplyParameters(currentParameters, backup.Document.Parameters);
            WriteDocument(ActiveConfigPath, backup.Document);
            LastBackupPath = path;
            LoadedActiveDocument = true;
            PendingPreview = null;
            LastStatusMessage = $"已回滚到备份：{backup.BackupId}";
            return true;
        }
        catch (Exception exception)
        {
            LastStatusMessage = $"回滚失败：{exception.Message}";
            return false;
        }
    }

    public bool SaveCurrentAsActive(EraRuntimeParameters currentParameters, string reason)
    {
        try
        {
            EnsureDirectories();
            WriteDocument(ActiveConfigPath, _migrator.Snapshot(currentParameters).Document);
            LoadedActiveDocument = true;
            LastStatusMessage = $"已保存当前玩法参数：{reason}";
            return true;
        }
        catch (Exception exception)
        {
            LastStatusMessage = $"保存当前玩法参数失败：{exception.Message}";
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

    private void Initialize(EraRuntimeParameters currentParameters)
    {
        try
        {
            EnsureDirectories();
            if (!File.Exists(ActiveConfigPath))
            {
                LoadedActiveDocument = false;
                LastStatusMessage = "当前没有激活参数文档，启动时继续使用内置默认值。";
                return;
            }

            EraConfigDocument document = ReadDocument(ActiveConfigPath);
            EraConfigMigrationResult migration = _migrator.Migrate(document);
            ApplyParameters(currentParameters, migration.Document.Parameters);
            LoadedActiveDocument = true;
            LastStatusMessage = "启动时已读取激活参数文档。";
            if (migration.MigrationApplied)
            {
                WriteDocument(ActiveConfigPath, migration.Document);
            }
        }
        catch (Exception exception)
        {
            LoadedActiveDocument = false;
            LastStatusMessage = $"读取激活参数文档失败，已退回默认参数：{exception.Message}";
        }
    }

    private void EnsureDirectories()
    {
        Directory.CreateDirectory(BaseDirectory);
        Directory.CreateDirectory(ExportDirectory);
        Directory.CreateDirectory(BackupDirectory);
    }

    private string WriteBackup(string reason, EraRuntimeParameters currentParameters)
    {
        EraConfigBackupRecord record = _backupPolicy.CreateBackup(reason, currentParameters);
        string path = Path.Combine(BackupDirectory, $"{record.BackupId}.json");
        string json = JsonConvert.SerializeObject(record, Formatting.Indented);
        File.WriteAllText(path, json);
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
            throw new InvalidOperationException($"无法解析配置文档：{path}");
        }

        return document;
    }

    private static EraConfigBackupRecord ReadBackup(string path)
    {
        string json = File.ReadAllText(path);
        EraConfigBackupRecord? record = JsonConvert.DeserializeObject<EraConfigBackupRecord>(json);
        if (record == null)
        {
            throw new InvalidOperationException($"无法解析配置备份：{path}");
        }

        return record;
    }

    private static void WriteDocument(string path, EraConfigDocument document)
    {
        string json = JsonConvert.SerializeObject(document, Formatting.Indented);
        File.WriteAllText(path, json);
    }

    private static string NormalizePath(string? rawPath)
    {
        if (string.IsNullOrWhiteSpace(rawPath))
        {
            return string.Empty;
        }

        return Path.GetFullPath(rawPath.Trim());
    }

    private static EraRuntimeParameters CloneParameters(EraRuntimeParameters parameters)
    {
        string json = JsonConvert.SerializeObject(parameters ?? new EraRuntimeParameters());
        return JsonConvert.DeserializeObject<EraRuntimeParameters>(json) ?? new EraRuntimeParameters();
    }

    private static void ApplyParameters(EraRuntimeParameters target, EraRuntimeParameters source)
    {
        EraRuntimeParameters clone = CloneParameters(source);
        target.Reincarnation = clone.Reincarnation;
        target.Demons = clone.Demons;
        target.Legions = clone.Legions;
        target.Advancement = clone.Advancement;
        target.Levels = clone.Levels;
        target.Kingdoms = clone.Kingdoms;
        target.Heroes = clone.Heroes;
        target.Growth = clone.Growth;
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

    private string DescribePath(string path)
    {
        if (string.IsNullOrWhiteSpace(path))
        {
            return "未生成";
        }

        string fullPath = Path.GetFullPath(path);
        string fullBase = Path.GetFullPath(BaseDirectory);
        if (fullPath.StartsWith(fullBase, StringComparison.OrdinalIgnoreCase))
        {
            return fullPath.Substring(fullBase.Length).TrimStart(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
        }

        return Path.GetFileName(fullPath);
    }
}
