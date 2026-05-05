using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EraWheel.Core.Time;
using EraWheel.Save.Models;
using EraWheel.Save.Services;
using UnityEngine;

namespace EraWheel.Systems.Story;

public sealed class EraStoryChapter
{
    public int Year { get; set; }
    public List<EraStoryEntry> Entries { get; set; } = new List<EraStoryEntry>();
}

public sealed class EraStoryEntry
{
    public string Title { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string SourceLabel { get; set; } = string.Empty;
    public float WorldTime { get; set; }
}

public sealed class EraStoryRuntimeService
{
    private EraRuntimeSaveService _runtimeSave;
    private readonly EraStoryRewriteService _rewriteService;
    private List<EraStoryChapter> _cachedChapters = new();
    private long _cachedEventSequence = -1;
    private int _cachedCycleCount = -1;
    private float _cachedObservedWorldTime = -1f;

    public string ExportDirectory { get; }
    public string RewriteDirectory { get; }
    public string LastExportPath { get; private set; } = string.Empty;
    public string LastRewriteRequestPath { get; private set; } = string.Empty;
    public string LastRewritePromptPath { get; private set; } = string.Empty;
    public string LastRewriteOutputPath { get; private set; } = string.Empty;
    public string LastOperationMessage { get; private set; } = "尚未生成故事导出。";

    public EraStoryRuntimeService(EraRuntimeSaveService runtimeSave)
    {
        _runtimeSave = runtimeSave;
        _rewriteService = EraStoryRewriteService.CreateFromEnvironment();
        ExportDirectory = Path.Combine(Application.persistentDataPath, "EraWheel", "StoryExports");
        RewriteDirectory = Path.Combine(ExportDirectory, "Rewrite");
    }

    public void Rebind(EraRuntimeSaveService runtimeSave)
    {
        _runtimeSave = runtimeSave;
        InvalidateCache();
    }

    public IReadOnlyList<EraStoryChapter> GetChapters()
    {
        EraWorldRuntimeState state = _runtimeSave.CurrentState;
        if (_cachedEventSequence == state.EventSequence &&
            _cachedCycleCount == state.CycleHistory.Count &&
            NearlyEqual(_cachedObservedWorldTime, state.LastObservedWorldTime))
        {
            return _cachedChapters;
        }

        _cachedChapters = BuildChapters(state);
        _cachedEventSequence = state.EventSequence;
        _cachedCycleCount = state.CycleHistory.Count;
        _cachedObservedWorldTime = state.LastObservedWorldTime;
        return _cachedChapters;
    }

    public void ClearCache()
    {
        InvalidateCache();
        LastOperationMessage = "故事缓存已清空，下次打开会按当前真实事件重新整理。";
    }

    public bool ExportLatestSnapshot(out string path)
    {
        path = string.Empty;

        try
        {
            Directory.CreateDirectory(ExportDirectory);
            string fileName = $"erawheel_story_{DateTime.UtcNow:yyyyMMdd_HHmmss}.md";
            path = Path.Combine(ExportDirectory, fileName);
            File.WriteAllText(path, BuildExportMarkdown(GetChapters()), Encoding.UTF8);
            LastExportPath = path;
            LastOperationMessage = $"已导出故事素材：{Path.GetFileName(path)}";
            return true;
        }
        catch (Exception exception)
        {
            LastOperationMessage = $"故事导出失败：{exception.Message}";
            return false;
        }
    }

    public bool ExportRewriteRequest(out string path)
    {
        path = string.Empty;

        try
        {
            EraStoryRewriteRequest request = _rewriteService.BuildRequest(GetChapters());
            WriteRewriteBundle(request, out string requestPath, out string promptPath);
            path = requestPath;
            LastOperationMessage = $"已导出 LLM 改写请求：{Path.GetFileName(requestPath)} / {Path.GetFileName(promptPath)}";
            return true;
        }
        catch (Exception exception)
        {
            LastOperationMessage = $"导出 LLM 改写请求失败：{exception.Message}";
            return false;
        }
    }

    public bool TryRewriteLatestSnapshot(out string path)
    {
        path = string.Empty;

        try
        {
            EraStoryRewriteRequest request = _rewriteService.BuildRequest(GetChapters());
            WriteRewriteBundle(request, out _, out _);

            if (!_rewriteService.TryRewrite(request, out EraStoryRewriteResult result))
            {
                LastOperationMessage = string.IsNullOrWhiteSpace(result.Message)
                    ? "当前没有生成改写结果。"
                    : result.Message;
                return false;
            }

            Directory.CreateDirectory(RewriteDirectory);
            string fileName = $"erawheel_story_rewrite_{DateTime.UtcNow:yyyyMMdd_HHmmss_fff}.md";
            path = Path.Combine(RewriteDirectory, fileName);
            File.WriteAllText(path, result.Markdown, Encoding.UTF8);
            LastRewriteOutputPath = path;
            LastOperationMessage = string.IsNullOrWhiteSpace(result.Message)
                ? $"已写出故事改写结果：{Path.GetFileName(path)}"
                : result.Message;
            return true;
        }
        catch (Exception exception)
        {
            LastOperationMessage = $"故事改写失败：{exception.Message}";
            return false;
        }
    }

    public string CreateStatusReport()
    {
        IReadOnlyList<EraStoryChapter> chapters = GetChapters();
        int entryCount = chapters.Sum(item => item.Entries.Count);
        int cycleSummaryCount = chapters
            .Sum(chapter => chapter.Entries.Count(entry => entry.SourceLabel.StartsWith("轮回历史", StringComparison.Ordinal)));
        int eventCount = entryCount - cycleSummaryCount;
        string yearRange = chapters.Count == 0
            ? "当前还没有年份章节"
            : $"年份范围 {chapters[0].Year}-{chapters[^1].Year}";
        return $"年份章节 {chapters.Count} 个；真实素材 {entryCount} 条（轮回总结 {cycleSummaryCount} / 事件流水 {eventCount}）；{yearRange}；导出目录 StoryExports。";
    }

    public string CreateRewriteStatusReport()
    {
        string requestFile = string.IsNullOrWhiteSpace(LastRewriteRequestPath)
            ? "尚未导出"
            : Path.GetFileName(LastRewriteRequestPath);
        string promptFile = string.IsNullOrWhiteSpace(LastRewritePromptPath)
            ? "尚未导出"
            : Path.GetFileName(LastRewritePromptPath);
        string outputFile = string.IsNullOrWhiteSpace(LastRewriteOutputPath)
            ? "尚未生成"
            : Path.GetFileName(LastRewriteOutputPath);
        return $"{_rewriteService.CreateStatusReport()}；请求 JSON={requestFile}；提示词 Markdown={promptFile}；改写输出={outputFile}";
    }

    private void InvalidateCache()
    {
        _cachedChapters = new List<EraStoryChapter>();
        _cachedEventSequence = -1;
        _cachedCycleCount = -1;
        _cachedObservedWorldTime = -1f;
    }

    private static List<EraStoryChapter> BuildChapters(EraWorldRuntimeState state)
    {
        List<EraStoryEntry> entries = new();

        foreach (EraCycleHistoryRecord record in state.CycleHistory)
        {
            entries.Add(CreateCycleHistoryEntry(record));
        }

        foreach (EraRuntimeEventRecord record in state.EventLog)
        {
            if (!ShouldIncludeEventRecord(record))
            {
                continue;
            }

            entries.Add(CreateEventEntry(record));
        }

        CollectWorldMetaEntries(entries);

        return entries
            .Select(NormalizeEntry)
            .Where(entry => !string.IsNullOrWhiteSpace(entry.Summary))
            .GroupBy(BuildDeduplicationKey, StringComparer.Ordinal)
            .Select(group => group
                .OrderBy(item => item.WorldTime)
                .ThenBy(item => item.SourceLabel, StringComparer.Ordinal)
                .First())
            .OrderBy(item => item.WorldTime)
            .ThenBy(item => item.SourceLabel, StringComparer.Ordinal)
            .GroupBy(item => EraWorldTime.GetYear(item.WorldTime))
            .OrderBy(group => group.Key)
            .Select(group => new EraStoryChapter
            {
                Year = group.Key,
                Entries = group.ToList(),
            })
            .ToList();
    }

    private static bool NearlyEqual(float left, float right)
    {
        return Math.Abs(left - right) < 0.01f;
    }

    private static EraStoryEntry CreateCycleHistoryEntry(EraCycleHistoryRecord record)
    {
        return new EraStoryEntry
        {
            Title = $"第 {record.CycleNumber} 轮轮回总结",
            Summary = string.IsNullOrWhiteSpace(record.Summary) ? "本轮没有留下额外摘要。" : record.Summary,
            SourceLabel = "轮回历史 / reconstruction_history",
            WorldTime = record.RecordedWorldTime,
        };
    }

    private static EraStoryEntry CreateEventEntry(EraRuntimeEventRecord record)
    {
        return new EraStoryEntry
        {
            Title = BuildEventTitle(record),
            Summary = record.Message,
            SourceLabel = $"{record.Channel}/{record.EventId}#{record.Sequence}",
            WorldTime = record.WorldTime,
        };
    }

    private static bool ShouldIncludeEventRecord(EraRuntimeEventRecord record)
    {
        if (string.IsNullOrWhiteSpace(record.Message))
        {
            return false;
        }

        if (string.Equals(record.Channel, "bootstrap", StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }

        // 轮回历史已经单独从 CycleHistory 提取，不再把同一条总结技术事件重复写进故事列表。
        if (string.Equals(record.EventId, "reconstruction_history", StringComparison.Ordinal))
        {
            return false;
        }

        return true;
    }

    private static void CollectWorldMetaEntries(List<EraStoryEntry> entries)
    {
        if (World.world == null)
        {
            return;
        }

        CollectWarEntries(entries);
        CollectAllianceEntries(entries);
        CollectPlotEntries(entries);
    }

    private static void CollectWarEntries(List<EraStoryEntry> entries)
    {
        if (World.world.wars == null)
        {
            return;
        }

        foreach (War war in World.world.wars)
        {
            if (war == null)
            {
                continue;
            }

            float startedWorldTime = ToWorldTime(war.data.created_time);
            if (startedWorldTime > 0f)
            {
                entries.Add(
                    new EraStoryEntry
                    {
                        Title = $"战争爆发：{BuildWarHeadline(war)}",
                        Summary = $"战争类型={BuildWarTypeLabel(war)}；发起者={BuildWarStarterLabel(war)}；攻方={BuildKingdomList(war.getAttackers())}；守方={BuildKingdomList(war.getDefenders())}。",
                        SourceLabel = $"worldbox/war/{war.getID()}/started",
                        WorldTime = startedWorldTime,
                    });
            }

            float endedWorldTime = ToWorldTime(war.data.died_time);
            if (endedWorldTime <= 0f || !war.hasEnded())
            {
                continue;
            }

            entries.Add(
                new EraStoryEntry
                {
                    Title = $"战争结束：{BuildWarHeadline(war)}",
                    Summary = $"结果={BuildWarWinnerLabel(war.data.winner)}；持续={Math.Max(0, war.getDuration())} 年；完整参战方={BuildKingdomList(war.getAllAttackers())} vs {BuildKingdomList(war.getAllDefenders())}。",
                    SourceLabel = $"worldbox/war/{war.getID()}/ended",
                    WorldTime = endedWorldTime,
                });
        }
    }

    private static void CollectAllianceEntries(List<EraStoryEntry> entries)
    {
        if (World.world.alliances == null)
        {
            return;
        }

        foreach (Alliance alliance in World.world.alliances)
        {
            if (alliance == null)
            {
                continue;
            }

            float startedWorldTime = ToWorldTime(alliance.data.created_time);
            if (startedWorldTime > 0f)
            {
                entries.Add(
                    new EraStoryEntry
                    {
                        Title = $"联盟成立：{NormalizeSingleLine(alliance.data.name, "未命名联盟")}",
                        Summary = $"创始王国={NormalizeSingleLine(alliance.data.founder_kingdom_name, "未知王国")}；创始者={NormalizeSingleLine(alliance.data.founder_actor_name, "未知人物")}；成员={BuildKingdomList(alliance.kingdoms_list)}；类型={BuildAllianceTypeLabel(alliance.data.alliance_type)}。",
                        SourceLabel = $"worldbox/alliance/{alliance.getID()}/started",
                        WorldTime = startedWorldTime,
                    });
            }

            float endedWorldTime = ToWorldTime(alliance.data.died_time);
            if (endedWorldTime <= 0f)
            {
                continue;
            }

            entries.Add(
                new EraStoryEntry
                {
                    Title = $"联盟解散：{NormalizeSingleLine(alliance.data.name, "未命名联盟")}",
                    Summary = $"最后记录成员={BuildKingdomList(alliance.kingdoms_list)}；最近成员变动时间={FormatOptionalYearDate(alliance.data.timestamp_member_joined)}。",
                    SourceLabel = $"worldbox/alliance/{alliance.getID()}/ended",
                    WorldTime = endedWorldTime,
                });
        }
    }

    private static void CollectPlotEntries(List<EraStoryEntry> entries)
    {
        if (World.world.plots == null)
        {
            return;
        }

        foreach (Plot plot in World.world.plots)
        {
            if (plot == null)
            {
                continue;
            }

            float startedWorldTime = ToWorldTime(plot.data.created_time);
            if (startedWorldTime <= 0f)
            {
                continue;
            }

            entries.Add(
                new EraStoryEntry
                {
                    Title = $"计划与阴谋启动：{NormalizeSingleLine(plot.data.name, plot.data.plot_type_id)}",
                    Summary = $"发起者={NormalizeSingleLine(plot.data.founder_name, "未知人物")}；目标={BuildPlotTargetLabel(plot)}；当前状态={BuildPlotStateLabel(plot)}；当前进度={plot.getProgressPercentage()}%。",
                    SourceLabel = $"worldbox/plot/{plot.getID()}/started",
                    WorldTime = startedWorldTime,
                });
        }
    }

    private static EraStoryEntry NormalizeEntry(EraStoryEntry entry)
    {
        return new EraStoryEntry
        {
            Title = NormalizeSingleLine(entry.Title, "未命名事件"),
            Summary = NormalizeMultiline(entry.Summary),
            SourceLabel = NormalizeSingleLine(entry.SourceLabel, "未知来源"),
            WorldTime = entry.WorldTime,
        };
    }

    private static string BuildDeduplicationKey(EraStoryEntry entry)
    {
        return $"{entry.WorldTime:F3}|{entry.Title}|{entry.Summary}|{entry.SourceLabel}";
    }

    private static string NormalizeSingleLine(string value, string fallback)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return fallback;
        }

        string normalized = value.Trim()
            .Replace("\r", " ")
            .Replace("\n", " ");
        while (normalized.Contains("  ", StringComparison.Ordinal))
        {
            normalized = normalized.Replace("  ", " ");
        }

        return string.IsNullOrWhiteSpace(normalized) ? fallback : normalized;
    }

    private static string NormalizeMultiline(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return string.Empty;
        }

        string normalized = value.Replace("\r\n", "\n").Replace('\r', '\n');
        string[] lines = normalized
            .Split('\n')
            .Select(line => line.Trim())
            .Where(line => line.Length > 0)
            .ToArray();
        return string.Join(" ", lines);
    }

    private static float ToWorldTime(double value)
    {
        return value > 0d ? (float)value : 0f;
    }

    private static string BuildWarHeadline(War war)
    {
        string attackers = NormalizeSingleLine(war.main_attacker?.name, BuildKingdomList(war.getAttackers()));
        string defenders = NormalizeSingleLine(war.main_defender?.name, BuildKingdomList(war.getDefenders()));
        return $"{attackers} vs {defenders}";
    }

    private static string BuildWarStarterLabel(War war)
    {
        string starterActor = NormalizeSingleLine(war.data.started_by_actor_name, string.Empty);
        string starterKingdom = NormalizeSingleLine(war.data.started_by_kingdom_name, string.Empty);
        if (!string.IsNullOrWhiteSpace(starterActor) && !string.IsNullOrWhiteSpace(starterKingdom))
        {
            return $"{starterActor} / {starterKingdom}";
        }

        if (!string.IsNullOrWhiteSpace(starterActor))
        {
            return starterActor;
        }

        return NormalizeSingleLine(starterKingdom, "未知发起者");
    }

    private static string BuildWarTypeLabel(War war)
    {
        return NormalizeSingleLine(war.getAsset()?.id, NormalizeSingleLine(war.data.war_type, "normal"));
    }

    private static string BuildWarWinnerLabel(WarWinner winner)
    {
        return winner switch
        {
            WarWinner.Attackers => "攻方胜利",
            WarWinner.Defenders => "守方胜利",
            WarWinner.Peace => "议和收场",
            WarWinner.Merged => "因阵营合并而结束",
            _ => "未记录胜者",
        };
    }

    private static string BuildAllianceTypeLabel(AllianceType allianceType)
    {
        return allianceType == AllianceType.Forced ? "强制联盟" : "普通联盟";
    }

    private static string BuildPlotStateLabel(Plot plot)
    {
        PlotState state = plot.getState();
        return state switch
        {
            PlotState.Active => "进行中",
            PlotState.Finished => "已完成",
            PlotState.Cancelled => "已取消",
            _ => state.ToString(),
        };
    }

    private static string BuildPlotTargetLabel(Plot plot)
    {
        if (plot.target_actor != null)
        {
            return NormalizeSingleLine(plot.target_actor.getName(), "未知目标角色");
        }

        if (plot.target_city != null)
        {
            return NormalizeSingleLine(plot.target_city.data.name, "未知目标城市");
        }

        if (plot.target_kingdom != null)
        {
            return NormalizeSingleLine(plot.target_kingdom.name, "未知目标王国");
        }

        if (plot.target_alliance != null)
        {
            return NormalizeSingleLine(plot.target_alliance.data.name, "未知目标联盟");
        }

        if (plot.target_war != null)
        {
            return $"战争 {BuildWarHeadline(plot.target_war)}";
        }

        return "未公开目标";
    }

    private static string BuildKingdomList(IEnumerable<Kingdom> kingdoms, int maxNames = 4)
    {
        if (kingdoms == null)
        {
            return "无记录";
        }

        List<string> names = kingdoms
            .Where(kingdom => kingdom != null)
            .Select(kingdom => NormalizeSingleLine(kingdom.name, "未知王国"))
            .Where(name => !string.IsNullOrWhiteSpace(name))
            .Distinct(StringComparer.Ordinal)
            .ToList();
        if (names.Count == 0)
        {
            return "无记录";
        }

        if (names.Count <= maxNames)
        {
            return string.Join("、", names);
        }

        return $"{string.Join("、", names.Take(maxNames))} 等 {names.Count} 方";
    }

    private static string FormatOptionalYearDate(double worldTime)
    {
        float normalized = ToWorldTime(worldTime);
        return normalized <= 0f ? "未记录" : EraWorldTime.GetYearDate(normalized);
    }

    private static string BuildEventTitle(EraRuntimeEventRecord record)
    {
        if (!string.IsNullOrWhiteSpace(record.Message))
        {
            int separator = record.Message.IndexOf('：');
            if (separator > 0)
            {
                return record.Message.Substring(0, separator);
            }

            separator = record.Message.IndexOf(':');
            if (separator > 0)
            {
                return record.Message.Substring(0, separator);
            }
        }

        return string.IsNullOrWhiteSpace(record.EventId)
            ? $"阶段事件 #{record.Sequence}"
            : record.EventId.Replace('_', ' ');
    }

    private static string BuildExportMarkdown(IReadOnlyList<EraStoryChapter> chapters)
    {
        StringBuilder builder = new();
        builder.AppendLine("# EraWheel 故事素材导出");
        builder.AppendLine();
        builder.AppendLine("> 这份导出只包含真实事件素材，不包含凭空改写内容。");
        builder.AppendLine();

        if (chapters.Count == 0)
        {
            builder.AppendLine("当前没有可导出的故事素材。");
            return builder.ToString();
        }

        foreach (EraStoryChapter chapter in chapters)
        {
            builder.AppendLine($"## 年份 {chapter.Year}");
            builder.AppendLine();
            foreach (EraStoryEntry entry in chapter.Entries.OrderBy(item => item.WorldTime))
            {
                builder.AppendLine($"### {entry.Title}");
                builder.AppendLine($"- 时间：{EraWorldTime.GetYearDate(entry.WorldTime)}");
                builder.AppendLine($"- 来源：{entry.SourceLabel}");
                builder.AppendLine($"- 内容：{entry.Summary}");
                builder.AppendLine();
            }
        }

        return builder.ToString();
    }

    private void WriteRewriteBundle(EraStoryRewriteRequest request, out string requestPath, out string promptPath)
    {
        Directory.CreateDirectory(RewriteDirectory);
        string timestamp = DateTime.UtcNow.ToString("yyyyMMdd_HHmmss_fff");
        requestPath = Path.Combine(RewriteDirectory, $"erawheel_story_rewrite_request_{timestamp}.json");
        promptPath = Path.Combine(RewriteDirectory, $"erawheel_story_rewrite_prompt_{timestamp}.md");
        File.WriteAllText(requestPath, _rewriteService.SerializeRequest(request), Encoding.UTF8);
        File.WriteAllText(promptPath, _rewriteService.BuildPromptMarkdown(request), Encoding.UTF8);
        LastRewriteRequestPath = requestPath;
        LastRewritePromptPath = promptPath;
    }
}
