using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EraWheel.Core.Time;
using Newtonsoft.Json;

namespace EraWheel.Systems.Story;

public sealed class EraStoryRewriteRequest
{
    public string AdapterId { get; set; } = string.Empty;
    public DateTime GeneratedUtc { get; set; }
    public string ConstraintSummary { get; set; } = string.Empty;
    public string SystemInstruction { get; set; } = string.Empty;
    public string UserGoal { get; set; } = string.Empty;
    public List<EraStoryRewriteChapter> Chapters { get; set; } = new List<EraStoryRewriteChapter>();
}

public sealed class EraStoryRewriteChapter
{
    public int Year { get; set; }
    public List<EraStoryRewriteEntry> Entries { get; set; } = new List<EraStoryRewriteEntry>();
}

public sealed class EraStoryRewriteEntry
{
    public string WorldDate { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string SourceLabel { get; set; } = string.Empty;
}

public sealed class EraStoryRewriteResult
{
    public string OutputTitle { get; set; } = string.Empty;
    public string Markdown { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
}

public interface IEraStoryRewriteAdapter
{
    string AdapterId { get; }
    string DisplayName { get; }
    bool IsConfigured { get; }
    string CreateStatusReport();
    bool TryRewrite(EraStoryRewriteRequest request, out EraStoryRewriteResult result);
}

public sealed class EraDisabledStoryRewriteAdapter : IEraStoryRewriteAdapter
{
    private readonly string _message;

    public string AdapterId { get; }
    public string DisplayName => "离线素材模式";
    public bool IsConfigured => false;

    public EraDisabledStoryRewriteAdapter(string adapterId, string message)
    {
        AdapterId = string.IsNullOrWhiteSpace(adapterId) ? "disabled" : adapterId;
        _message = string.IsNullOrWhiteSpace(message)
            ? "当前没有配置外部故事改写服务。"
            : message;
    }

    public string CreateStatusReport()
    {
        return $"{DisplayName}；适配器={AdapterId}；{_message}";
    }

    public bool TryRewrite(EraStoryRewriteRequest request, out EraStoryRewriteResult result)
    {
        result = new EraStoryRewriteResult
        {
            OutputTitle = "未生成改写结果",
            Markdown = string.Empty,
            Message = _message,
        };
        return false;
    }
}

public sealed class EraStoryRewriteService
{
    public const string AdapterEnvVar = "ERAWHEEL_STORY_REWRITE_ADAPTER";

    private readonly IEraStoryRewriteAdapter _adapter;

    private EraStoryRewriteService(IEraStoryRewriteAdapter adapter)
    {
        _adapter = adapter;
    }

    public string AdapterId => _adapter.AdapterId;
    public string DisplayName => _adapter.DisplayName;
    public bool IsConfigured => _adapter.IsConfigured;

    public static EraStoryRewriteService CreateFromEnvironment()
    {
        string configuredAdapter = (Environment.GetEnvironmentVariable(AdapterEnvVar) ?? string.Empty).Trim();
        if (string.IsNullOrWhiteSpace(configuredAdapter) ||
            configuredAdapter.Equals("disabled", StringComparison.OrdinalIgnoreCase))
        {
            return new EraStoryRewriteService(
                new EraDisabledStoryRewriteAdapter(
                    "disabled",
                    "未配置在线故事改写适配器，基础故事列表和导出仍可正常使用。"
                )
            );
        }

        return new EraStoryRewriteService(
            new EraDisabledStoryRewriteAdapter(
                configuredAdapter,
                $"环境变量 {AdapterEnvVar}={configuredAdapter}，但当前构建还没有接入对应桥接器。"
            )
        );
    }

    public string CreateStatusReport()
    {
        return _adapter.CreateStatusReport();
    }

    public EraStoryRewriteRequest BuildRequest(IReadOnlyList<EraStoryChapter> chapters)
    {
        return new EraStoryRewriteRequest
        {
            AdapterId = AdapterId,
            GeneratedUtc = DateTime.UtcNow,
            ConstraintSummary = "只能改写真实素材，不新增人物、地点、时间和因果。",
            SystemInstruction = "你是 EraWheel 的故事改写器。你只能引用输入里的结构化事件，把它们整理成更易读的故事草稿。任何无法从素材直接追溯的句子都必须删除。",
            UserGoal = "按年份组织素材，输出适合给玩家阅读的 Markdown 草稿，同时保留来源可追溯性。",
            Chapters = chapters
                .Select(
                    chapter => new EraStoryRewriteChapter
                    {
                        Year = chapter.Year,
                        Entries = chapter.Entries
                            .OrderBy(item => item.WorldTime)
                            .Select(
                                entry => new EraStoryRewriteEntry
                                {
                                    WorldDate = EraWorldTime.GetYearDate(entry.WorldTime),
                                    Title = entry.Title,
                                    Summary = entry.Summary,
                                    SourceLabel = entry.SourceLabel,
                                })
                            .ToList(),
                    })
                .ToList(),
        };
    }

    public string SerializeRequest(EraStoryRewriteRequest request)
    {
        return JsonConvert.SerializeObject(request, Formatting.Indented);
    }

    public string BuildPromptMarkdown(EraStoryRewriteRequest request)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine("# EraWheel LLM 改写请求");
        builder.AppendLine();
        builder.AppendLine("## 硬约束");
        builder.AppendLine($"- {request.ConstraintSummary}");
        builder.AppendLine("- 不能补人物设定、地名、战果或隐藏因果。");
        builder.AppendLine("- 如果素材不足，就保持克制，不要把猜测写成事实。");
        builder.AppendLine();
        builder.AppendLine("## 系统指令");
        builder.AppendLine(request.SystemInstruction);
        builder.AppendLine();
        builder.AppendLine("## 用户目标");
        builder.AppendLine(request.UserGoal);
        builder.AppendLine();
        builder.AppendLine($"- 生成时间：{request.GeneratedUtc:yyyy-MM-dd HH:mm:ss} UTC");
        builder.AppendLine($"- 适配器：{request.AdapterId}");
        builder.AppendLine();

        if (request.Chapters.Count == 0)
        {
            builder.AppendLine("## 结构化素材");
            builder.AppendLine("当前没有可供改写的真实素材。");
            return builder.ToString();
        }

        builder.AppendLine("## 结构化素材");
        builder.AppendLine();
        foreach (EraStoryRewriteChapter chapter in request.Chapters)
        {
            builder.AppendLine($"### 年份 {chapter.Year}");
            foreach (EraStoryRewriteEntry entry in chapter.Entries)
            {
                builder.AppendLine($"- 时间：{entry.WorldDate}");
                builder.AppendLine($"- 标题：{entry.Title}");
                builder.AppendLine($"- 来源：{entry.SourceLabel}");
                builder.AppendLine($"- 摘要：{entry.Summary}");
                builder.AppendLine();
            }
        }

        return builder.ToString().TrimEnd();
    }

    public bool TryRewrite(EraStoryRewriteRequest request, out EraStoryRewriteResult result)
    {
        return _adapter.TryRewrite(request, out result);
    }
}
