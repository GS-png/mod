using System;
using System.Collections.Generic;

namespace EraWheel.HotReload;

public enum EraReloadStage
{
    Preflight = 0,
    Compile = 1,
    CompatibilityScan = 2,
    MethodPatch = 3,
    ResourcesAndLocales = 4,
    RuntimeRebuild = 5,
    WorldRebind = 6,
    UiRebind = 7,
    Commit = 8,
}

public enum EraReloadIssueKind
{
    Unknown = 0,
    Compile = 1,
    Patch = 2,
    Resource = 3,
    Locale = 4,
    Runtime = 5,
    UI = 6,
    Rollback = 7,
    Compatibility = 8,
    WorldRebind = 9,
}

public enum EraReloadErrorCode
{
    None = 0,
    PreflightFailed = 1001,
    CompileFailed = 1002,
    CompatibilityRestartRequired = 1003,
    MethodPatchFailed = 1004,
    ResourcesFailed = 1005,
    RuntimeRebuildFailed = 1006,
    WorldRebindFailed = 1007,
    UiRebindFailed = 1008,
    CommitFailed = 1009,
    RestartRequired = 1098,
    RollbackFailed = 1099,
}

public enum EraReloadOutcome
{
    Pending = 0,
    Succeeded = 1,
    Failed = 2,
    RestartRequired = 3,
}

public enum EraCompatibilityIssueKind
{
    AddedType,
    RemovedType,
    AddedField,
    RemovedField,
    ChangedField,
    AddedMethodSignature,
    RemovedMethodSignature,
    ConstructorChanged,
    StaticInitializerChanged,
    RuntimeMethodMissing,
}

public sealed class EraCompatibilityIssue
{
    public EraCompatibilityIssueKind Kind { get; set; }
    public string Member { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;

    public override string ToString()
    {
        return string.IsNullOrWhiteSpace(Member)
            ? $"{Kind}: {Message}"
            : $"{Kind}: {Member} | {Message}";
    }
}

public sealed class EraCompatibilityReport
{
    public List<EraCompatibilityIssue> Issues { get; } = new List<EraCompatibilityIssue>();
    public bool RequiresRestart => Issues.Count > 0;

    public string CreateSummary(int maxItems = 4)
    {
        if (Issues.Count == 0)
        {
            return "兼容扫描通过：只发现可热修补的方法体变化。";
        }

        List<string> previews = new List<string>();
        for (int index = 0; index < Issues.Count && index < maxItems; index++)
        {
            previews.Add(Issues[index].ToString());
        }

        string suffix = Issues.Count > maxItems ? $"；另有 {Issues.Count - maxItems} 项" : string.Empty;
        return $"兼容扫描发现 {Issues.Count} 个需要重启的结构变化：{string.Join("；", previews)}{suffix}";
    }
}

public sealed class EraCompiledReloadAssembly
{
    public string NewAssemblyPath { get; }
    public string OldAssemblyPath { get; }
    public string NewSymbolsPath { get; }
    public string OldSymbolsPath { get; }

    public EraCompiledReloadAssembly(
        string newAssemblyPath,
        string oldAssemblyPath,
        string newSymbolsPath,
        string oldSymbolsPath
    )
    {
        NewAssemblyPath = newAssemblyPath;
        OldAssemblyPath = oldAssemblyPath;
        NewSymbolsPath = newSymbolsPath;
        OldSymbolsPath = oldSymbolsPath;
    }
}

public sealed class EraMethodPatchReport
{
    public int Patched { get; set; }
    public int Skipped { get; set; }
    public int Failed { get; set; }
    public List<string> PatchedMethodKeys { get; } = new List<string>();
    public List<string> FailureMessages { get; } = new List<string>();

    public string CreateSummary()
    {
        return $"方法体补丁完成：patched={Patched} skipped={Skipped} failed={Failed}。";
    }
}

public sealed class EraWorldRebindReport
{
    public int ActorsRebound { get; set; }
    public int BuildingsRebound { get; set; }
    public int ItemsRebound { get; set; }
    public int CustomDataMappingsApplied { get; set; }
    public int Skipped { get; set; }
    public List<string> Warnings { get; } = new List<string>();

    public string CreateSummary()
    {
        return
            $"当前世界重绑完成：actors={ActorsRebound} buildings={BuildingsRebound} items={ItemsRebound} " +
            $"custom_data={CustomDataMappingsApplied} skipped={Skipped} warnings={Warnings.Count}。";
    }
}

public sealed class EraReloadIssue
{
    public EraReloadIssueKind Kind { get; set; } = EraReloadIssueKind.Unknown;
    public EraReloadStage Stage { get; set; } = EraReloadStage.Preflight;
    public string Message { get; set; } = string.Empty;
    public string? Detail { get; set; }

    public override string ToString()
    {
        if (string.IsNullOrWhiteSpace(Detail))
        {
            return $"[{Kind}] {Message}";
        }

        return $"[{Kind}] {Message} | {Detail}";
    }
}

public sealed class EraReloadStats
{
    public int CompatibilityIssues { get; set; }
    public int MethodsPatched { get; set; }
    public int MethodsSkipped { get; set; }
    public int MethodsFailed { get; set; }
    public int ResourcesUpdated { get; set; }
    public int ResourcesRemoved { get; set; }
    public int AssetsRemoved { get; set; }
    public int LocaleFilesReloaded { get; set; }
    public int WorldActorsRebound { get; set; }
    public int WorldBuildingsRebound { get; set; }
    public int WorldItemsRebound { get; set; }
    public int WorldCustomDataMappingsApplied { get; set; }
}

public sealed class EraReloadStageReport
{
    public EraReloadStage Stage { get; set; }
    public bool Success { get; set; }
    public long DurationMs { get; set; }
    public string Message { get; set; } = string.Empty;
}

public sealed class EraReloadResult
{
    public bool Success { get; set; }
    public bool RestartRequired { get; set; }
    public EraReloadOutcome Outcome { get; set; } = EraReloadOutcome.Pending;
    public bool RollbackAttempted { get; set; }
    public bool RollbackSucceeded { get; set; }
    public EraReloadStage LastStage { get; set; } = EraReloadStage.Preflight;
    public EraReloadErrorCode ErrorCode { get; set; } = EraReloadErrorCode.None;
    public string Summary { get; set; } = "尚未执行热加载。";
    public long TotalDurationMs { get; set; }
    public EraReloadStats Stats { get; } = new EraReloadStats();
    public List<EraReloadIssue> Issues { get; } = new List<EraReloadIssue>();
    public List<EraReloadStageReport> StageReports { get; } = new List<EraReloadStageReport>();
    public DateTimeOffset FinishedAt { get; set; } = DateTimeOffset.MinValue;

    public string CreateDebugReport()
    {
        string headline = Outcome switch
        {
            EraReloadOutcome.Succeeded => $"成功，耗时 {TotalDurationMs}ms。",
            EraReloadOutcome.RestartRequired => $"需要重启，停在 {LastStage}，错误码 {(int)ErrorCode}，耗时 {TotalDurationMs}ms。",
            _ => $"失败，停在 {LastStage}，错误码 {(int)ErrorCode}，耗时 {TotalDurationMs}ms。",
        };
        string rollback = RollbackAttempted
            ? (RollbackSucceeded ? "已回滚。" : "回滚失败。")
            : "未触发回滚。";
        string stats =
            $"兼容问题 {Stats.CompatibilityIssues}；" +
            $"方法补丁 {Stats.MethodsPatched}（跳过 {Stats.MethodsSkipped}，失败 {Stats.MethodsFailed}）；" +
            $"资源更新 {Stats.ResourcesUpdated}，资源移除 {Stats.ResourcesRemoved}，资产移除 {Stats.AssetsRemoved}；" +
            $"文本重载 {Stats.LocaleFilesReloaded}；" +
            $"世界重绑 actor/building/item={Stats.WorldActorsRebound}/{Stats.WorldBuildingsRebound}/{Stats.WorldItemsRebound}。";
        return $"{headline} {rollback} {stats}";
    }
}
