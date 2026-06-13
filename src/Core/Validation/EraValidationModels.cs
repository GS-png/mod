using System;
using System.Collections.Generic;
using System.Linq;

namespace EraWheel.Core.Validation;

public enum EraValidationSeverity
{
    Warning,
    Error,
}

public sealed class EraValidationIssue
{
    public EraValidationSeverity Severity { get; }
    public string Scope { get; }
    public string Message { get; }

    public EraValidationIssue(EraValidationSeverity severity, string scope, string message)
    {
        Severity = severity;
        Scope = scope;
        Message = message;
    }
}

public sealed class EraValidationReport
{
    public static EraValidationReport Empty { get; } = new EraValidationReport(new List<EraValidationIssue>());

    public IReadOnlyList<EraValidationIssue> Issues { get; }

    public int ErrorCount => Issues.Count(issue => issue.Severity == EraValidationSeverity.Error);
    public int WarningCount => Issues.Count(issue => issue.Severity == EraValidationSeverity.Warning);
    public bool HasErrors => ErrorCount > 0;
    public bool HasWarnings => WarningCount > 0;

    public EraValidationReport(IReadOnlyList<EraValidationIssue> issues)
    {
        Issues = issues;
    }

    public string CreateStatusReport()
    {
        return $"错误={ErrorCount}；警告={WarningCount}。";
    }

    public EraValidationReport Merge(EraValidationReport other)
    {
        if (other.Issues.Count == 0)
        {
            return this;
        }

        if (Issues.Count == 0)
        {
            return other;
        }

        return new EraValidationReport(Issues.Concat(other.Issues).ToArray());
    }

    public IReadOnlyList<string> CreateChecklistLines()
    {
        return new[]
        {
            BuildChecklistLine("参数与版本", "Config", "ConfigVersion"),
            BuildChecklistLine("实体自定义键", "CustomData"),
            BuildChecklistLine("魔王与将领清单", "Demon", "General"),
            BuildChecklistLine("军团与据点清单", "Legion", "Stronghold", "ActorTemplate"),
            BuildChecklistLine("公共特质清单", "PublicTrait"),
            BuildChecklistLine("轮回装备清单", "HeritageEquipment"),
            BuildChecklistLine("轮回特质清单", "HeritageTrait"),
        };
    }

    public void ThrowIfBlocking()
    {
        if (!HasErrors)
        {
            return;
        }

        IReadOnlyList<EraValidationIssue> errors = Issues
            .Where(issue => issue.Severity == EraValidationSeverity.Error)
            .ToArray();
        string summary = string.Join(
            " | ",
            errors.Take(3).Select(issue => $"[{issue.Scope}] {issue.Message}")
        );
        if (errors.Count > 3)
        {
            summary = $"{summary} | 另有 {errors.Count - 3} 条错误。";
        }

        throw new InvalidOperationException($"EraWheel 启动自检失败：{summary}");
    }

    private string BuildChecklistLine(string title, params string[] scopes)
    {
        IReadOnlyList<EraValidationIssue> matchedIssues = Issues
            .Where(issue => scopes.Contains(issue.Scope))
            .ToArray();
        string statusLabel;
        if (matchedIssues.Any(issue => issue.Severity == EraValidationSeverity.Error))
        {
            statusLabel = "错误";
        }
        else if (matchedIssues.Any())
        {
            statusLabel = "警告";
        }
        else
        {
            statusLabel = "通过";
        }

        if (matchedIssues.Count == 0)
        {
            return $"- [{statusLabel}] {title}：已通过。";
        }

        string detail = string.Join("；", matchedIssues.Take(2).Select(issue => issue.Message));
        if (matchedIssues.Count > 2)
        {
            detail = $"{detail}；另有 {matchedIssues.Count - 2} 条。";
        }

        return $"- [{statusLabel}] {title}：{detail}";
    }
}
