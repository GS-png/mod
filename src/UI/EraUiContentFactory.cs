using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EraWheel.Config;
using EraWheel.Core;
using EraWheel.Core.Constants;
using EraWheel.Core.Time;
using EraWheel.Data.Bestiary;
using EraWheel.Data.Definitions;
using EraWheel.Localization;
using EraWheel.Save.Models;
using EraWheel.Systems.Story;
using NeoModLoader.api.attributes;

namespace EraWheel.UI;

public sealed class EraUiModuleDefinition
{
    public EraModuleId ModuleId { get; }
    public string NameKey { get; }
    public string DescriptionKey { get; }

    public EraUiModuleDefinition(EraModuleId moduleId, string nameKey, string descriptionKey)
    {
        ModuleId = moduleId;
        NameKey = nameKey;
        DescriptionKey = descriptionKey;
    }
}

public static class EraUiContentFactory
{
    private static readonly IReadOnlyList<EraUiModuleDefinition> Modules = new[]
    {
        new EraUiModuleDefinition(EraModuleId.Guide, EraLocaleKeys.UiModuleGuide, EraLocaleKeys.UiModuleGuideDescription),
        new EraUiModuleDefinition(EraModuleId.Reincarnation, EraLocaleKeys.UiModuleReincarnation, EraLocaleKeys.UiModuleReincarnationDescription),
        new EraUiModuleDefinition(EraModuleId.Demons, EraLocaleKeys.UiModuleDemons, EraLocaleKeys.UiModuleDemonsDescription),
        new EraUiModuleDefinition(EraModuleId.Generals, EraLocaleKeys.UiModuleGenerals, EraLocaleKeys.UiModuleGeneralsDescription),
        new EraUiModuleDefinition(EraModuleId.Legions, EraLocaleKeys.UiModuleLegions, EraLocaleKeys.UiModuleLegionsDescription),
        new EraUiModuleDefinition(EraModuleId.Advancement, EraLocaleKeys.UiModuleAdvancement, EraLocaleKeys.UiModuleAdvancementDescription),
        new EraUiModuleDefinition(EraModuleId.Levels, EraLocaleKeys.UiModuleLevels, EraLocaleKeys.UiModuleLevelsDescription),
        new EraUiModuleDefinition(EraModuleId.Kingdoms, EraLocaleKeys.UiModuleKingdoms, EraLocaleKeys.UiModuleKingdomsDescription),
        new EraUiModuleDefinition(EraModuleId.Heroes, EraLocaleKeys.UiModuleHeroes, EraLocaleKeys.UiModuleHeroesDescription),
        new EraUiModuleDefinition(EraModuleId.StoryGenerator, EraLocaleKeys.UiModuleStoryGenerator, EraLocaleKeys.UiModuleStoryGeneratorDescription),
    };

    public static IReadOnlyList<EraUiModuleDefinition> GetModulesInOrder()
    {
        return Modules;
    }

    public static EraUiModuleDefinition GetModule(EraModuleId moduleId)
    {
        return Modules.First(item => item.ModuleId == moduleId);
    }

    [Hotfixable]
    public static string BuildGuideOverviewText()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine("这块在 MOD 里负责什么：");
        builder.AppendLine("EraWheel 把“魔王来袭 -> 世界应战 -> 战后成长 -> 下一轮再战”串成一条长期循环。");
        builder.AppendLine("你不是只看一场 Boss 战，而是在看整个世界怎样一次次扛住危机、留下积累、再面对更强敌人。");
        builder.AppendLine();
        builder.AppendLine("第一次看建议先盯 3 件事：");
        builder.AppendLine("1. 当前轮回跑到哪个阶段了。");
        builder.AppendLine("2. 本轮会来哪些魔王、将领和军团。");
        builder.AppendLine("3. 打赢以后世界留下了哪些长期成长。");
        builder.AppendLine();
        builder.AppendLine("当前共享底座状态：");
        builder.AppendLine(EraRuntimeBootstrap.CreateStatusReport());
        return builder.ToString().TrimEnd();
    }

    [Hotfixable]
    public static string BuildGuideSettingsText()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine("这页负责什么：");
        builder.AppendLine("这里集中放导览层能直接操作的共用设置、参数导入导出和版本信息。");
        builder.AppendLine("你可以把它理解成玩法参数的总控前台。");
        builder.AppendLine();
        builder.AppendLine("当前配置状态：");
        builder.AppendLine($"- 开发模式：{(EraConfig.DevelopmentMode ? "开启" : "关闭")}");
        builder.AppendLine($"- config_version 快照：{EraConfig.VersioningSnapshot.Document.ConfigVersion}");
        builder.AppendLine($"- 配置迁移器：{EraConfig.VersioningSnapshot.Summary}");
        builder.AppendLine($"- 备份策略：{EraConfig.BackupPolicy.CreateStatusReport()}");
        builder.AppendLine($"- HUD 显示：{(EraHudOverlay.IsVisible ? "开启" : "关闭")}");
        builder.AppendLine($"- HUD 位置记忆：({EraHudOverlay.CachedPosition.x:0.#}, {EraHudOverlay.CachedPosition.y:0.#})");
        if (EraConfig.ImportExport != null)
        {
            builder.AppendLine($"- 导入导出状态：{EraConfig.ImportExport.CreateStatusReport()}");
            builder.AppendLine($"- 最近结果：{EraConfig.ImportExport.LastStatusMessage}");
            builder.AppendLine($"- 待导入文件：{(string.IsNullOrWhiteSpace(EraConfig.ImportExport.DraftImportPath) ? "尚未填写" : Path.GetFileName(EraConfig.ImportExport.DraftImportPath))}");
            builder.AppendLine(EraConfig.ImportExport.CreatePreviewReport());
        }
        builder.AppendLine();
        builder.AppendLine("导出对象只包含玩法参数，不会把运行态存档一起带出去。");
        builder.AppendLine("导入时会先迁移和做差异预览，确认后才真正应用。");
        return builder.ToString().TrimEnd();
    }

    [Hotfixable]
    public static string BuildModuleIntroText(EraModuleId moduleId)
    {
        return moduleId switch
        {
            EraModuleId.Reincarnation => "这块在 MOD 里像总进度条。它统一驱动阶段推进、双封印管理、胜利结算和下一轮重置，让所有系统都围着同一条主线运转。",
            EraModuleId.Demons => "这块负责魔王本体、多魔王关系和魔王技能。可以把它理解成整轮战役的核心敌方压力源，真正的 Boss 气氛从这里出来。",
            EraModuleId.Generals => "将领是魔王阵营的精英前锋。它们比魔王先上场，像是在决战前先把前线撑起来的一批主力干部。",
            EraModuleId.Legions => "军团负责持续出波，让魔王阵营不是只靠几个 Boss 撑场，而是一直有兵线压力。它更像战场上的浪潮，而不是单个大招。",
            EraModuleId.Advancement => "轮回进阶负责把“这一轮打赢了什么”转成“下一轮世界能拿到什么”。它是整个 MOD 的长期成长主轴。",
            EraModuleId.Levels => "等级系统复用原版升级，但会在升级时额外发放随机属性加成。通俗说，它是在原版练级上再加一层成长味道。",
            EraModuleId.Kingdoms => "王国系统让王国不只靠人口和军队成长，还会积累长期声望。它更像是在给文明一条跨大战持续变强的线。",
            EraModuleId.Heroes => "英雄系统负责命定英雄、家族继承和幸存强化。它让“哪些人活下来、哪些血脉传下去”变成长期故事的一部分。",
            EraModuleId.StoryGenerator => "故事生成器不凭空编历史，只把真实发生的事件整理成更像小说的叙事。它负责把这套 MOD 讲出来，而不是替战斗做判断。",
            _ => "导览页已经单独拆开，这里不会再重复讲导览内容。",
        };
    }

    [Hotfixable]
    public static string BuildModuleBestiaryText(EraModuleId moduleId)
    {
        IReadOnlyList<EraBestiaryEntry> entries = GetBestiaryEntriesForModule(moduleId);
        if (entries.Count > 0)
        {
            return BuildBestiaryEntryText(moduleId, 0);
        }

        return BuildModuleBestiaryFallbackText(moduleId);
    }

    public static IReadOnlyList<EraBestiaryEntry> GetBestiaryEntriesForModule(EraModuleId moduleId)
    {
        EraBestiaryCatalog bestiary = EraRuntimeBootstrap.BestiaryCatalog;
        return moduleId switch
        {
            EraModuleId.Demons => bestiary.Entries
                .Where(item => item.Kind == EraBestiaryEntryKind.Demon || item.Kind == EraBestiaryEntryKind.Stronghold)
                .OrderBy(item => item.Kind)
                .ThenBy(item => item.DisplayName)
                .ToArray(),
            EraModuleId.Generals => bestiary.Entries
                .Where(item => item.Kind == EraBestiaryEntryKind.General)
                .OrderBy(item => item.RelatedDemonId)
                .ThenBy(item => item.DisplayName)
                .ToArray(),
            EraModuleId.Legions => bestiary.Entries
                .Where(item => item.Kind == EraBestiaryEntryKind.Legion)
                .OrderBy(item => item.RelatedDemonId)
                .ThenBy(item => item.DisplayName)
                .ToArray(),
            EraModuleId.Advancement => bestiary.Entries
                .Where(item => item.Kind == EraBestiaryEntryKind.HeritageEquipment ||
                               item.Kind == EraBestiaryEntryKind.HeritageTrait ||
                               item.Kind == EraBestiaryEntryKind.PublicTrait)
                .OrderBy(item => item.Kind)
                .ThenBy(item => item.UnlockTier)
                .ThenBy(item => item.DisplayName)
                .ToArray(),
            _ => Array.Empty<EraBestiaryEntry>(),
        };
    }

    [Hotfixable]
    public static string BuildBestiaryEntryText(EraModuleId moduleId, int entryIndex)
    {
        IReadOnlyList<EraBestiaryEntry> entries = GetBestiaryEntriesForModule(moduleId);
        if (entries.Count == 0)
        {
            return BuildModuleBestiaryFallbackText(moduleId);
        }

        int safeIndex = Math.Max(0, Math.Min(entryIndex, entries.Count - 1));
        EraBestiaryEntry entry = entries[safeIndex];
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"{GetBestiaryKindLabel(entry.Kind)}：{entry.DisplayName}");
        builder.AppendLine($"第 {safeIndex + 1}/{entries.Count} 条，ID：{entry.EntryId}");
        builder.AppendLine();
        if (!string.IsNullOrWhiteSpace(entry.Summary))
        {
            builder.AppendLine($"摘要：{entry.Summary}");
        }

        if (entry.UnlockTier > 0)
        {
            builder.AppendLine($"解锁档位：T{entry.UnlockTier}");
        }

        if (!string.IsNullOrWhiteSpace(entry.RelatedDemonId))
        {
            builder.AppendLine($"关联魔王：{entry.RelatedDemonId}");
        }

        if (!string.IsNullOrWhiteSpace(entry.BaseTemplateId))
        {
            builder.AppendLine($"基础模板：{entry.BaseTemplateId}");
        }

        if (!string.IsNullOrWhiteSpace(entry.IconRuntimePath))
        {
            builder.AppendLine($"运行时图标：{entry.IconRuntimePath}");
        }

        builder.AppendLine();
        builder.AppendLine("详情：");
        builder.AppendLine(string.IsNullOrWhiteSpace(entry.DetailText) ? "暂无详情文本。" : entry.DetailText);
        if (entry.DetailSpriteRuntimePaths.Count > 0)
        {
            builder.AppendLine();
            builder.AppendLine($"关联技能图：{string.Join("、", entry.DetailSpriteRuntimePaths.Take(5))}");
            if (entry.DetailSpriteRuntimePaths.Count > 5)
            {
                builder.AppendLine($"还有 {entry.DetailSpriteRuntimePaths.Count - 5} 张图可供后续图文页使用。");
            }
        }

        return builder.ToString().TrimEnd();
    }

    [Hotfixable]
    public static string BuildModuleRuntimeText(EraModuleId moduleId)
    {
        return moduleId switch
        {
            EraModuleId.Reincarnation => BuildRuntimeOverviewText(),
            EraModuleId.Demons => string.Join(
                Environment.NewLine,
                BuildRuntimeOverviewText(),
                EraRuntimeBootstrap.CombatRuntime?.DemonSkills.CreateStatusReport() ?? "魔王技能运行时还没有初始化。"
            ),
            EraModuleId.Generals => BuildGeneralRuntimeText(),
            EraModuleId.Legions => BuildLegionRuntimeText(),
            EraModuleId.Advancement => EraRuntimeBootstrap.AdvancementRuntime?.CreateStatusReport() ?? "轮回进阶运行时还没有初始化。",
            EraModuleId.Levels => EraRuntimeBootstrap.LevelRuntime?.CreateStatusReport() ?? "等级运行时还没有初始化。",
            EraModuleId.Kingdoms => BuildKingdomRuntimeText(),
            EraModuleId.Heroes => BuildHeroRuntimeText(),
            EraModuleId.StoryGenerator => BuildStoryListText(),
            _ => EraRuntimeBootstrap.CreateStatusReport(),
        };
    }

    [Hotfixable]
    public static string BuildRuntimeOverviewText()
    {
        if (EraRuntimeBootstrap.RuntimeSave == null)
        {
            return "运行态存档还没有初始化。";
        }

        EraWorldRuntimeState state = EraRuntimeBootstrap.RuntimeSave.CurrentState;
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"轮回数：第 {state.CompletedCycles + 1} 轮（已完成 {state.CompletedCycles} 轮）");
        builder.AppendLine($"当前阶段：{GetStageLabel(state.Stage)}");
        builder.AppendLine($"世界档位：T{state.WorldTier}");
        builder.AppendLine($"将领封印：{state.GeneralSealPercent:0.#}%");
        builder.AppendLine($"魔王封印：{state.DemonSealPercent:0.#}%");
        builder.AppendLine();
        builder.AppendLine($"魔王态势：{BuildDemonSituationText(state)}");
        builder.AppendLine($"将领态势：{BuildGeneralSituationText(state)}");
        builder.AppendLine($"军团态势：{BuildLegionSituationText(state)}");
        builder.AppendLine($"王国英雄：{BuildHeroSituationText(state)}");
        builder.AppendLine($"快捷定位：{EraRuntimeFocusService.CreateStatusReport()}");
        if (state.DemonInteraction.Active && !string.IsNullOrWhiteSpace(state.DemonInteraction.Description))
        {
            builder.AppendLine();
            builder.AppendLine($"多魔王关系：{state.DemonInteraction.Description}");
        }

        return builder.ToString().TrimEnd();
    }

    private static string BuildModuleBestiaryFallbackText(EraModuleId moduleId)
    {
        EraContentCatalog content = EraRuntimeBootstrap.ContentCatalog;
        EraBestiaryCatalog bestiary = EraRuntimeBootstrap.BestiaryCatalog;
        return moduleId switch
        {
            EraModuleId.Reincarnation => string.Join(
                Environment.NewLine,
                "轮回系统直接相关的图鉴不是生物名册，而是阶段和运行口径：",
                "- 阶段：预发展、预兆、苏醒、降临、战后重建。",
                "- 双封印：将领封印先走，魔王封印后走。",
                "- 胜利条件：最后一名存活魔王死亡。",
                string.Empty,
                $"当前静态图鉴总览：{bestiary.CreateStatusReport()}"
            ),
            EraModuleId.Levels => string.Join(
                Environment.NewLine,
                "等级系统没有独立生物图鉴，真正要看的其实是“升级时能抽哪些属性”。",
                $"当前等级随机属性候选：{string.Join("、", EraConfig.Parameters.Levels.RandomAttributes.CandidateAttributeIds)}"
            ),
            EraModuleId.Kingdoms => string.Join(
                Environment.NewLine,
                "王国系统的图鉴重心不是单位，而是声望阈值分段和属性账本。",
                $"当前声望阈值段数：{EraConfig.Parameters.Kingdoms.RenownBands.Count} 段。"
            ),
            EraModuleId.Heroes => string.Join(
                Environment.NewLine,
                "英雄系统更像人物成长规则集，而不是固定名册。",
                "这里重点看的是晋升评分、血脉继承和幸存强化口径。"
            ),
            EraModuleId.StoryGenerator => $"故事素材目录当前来自真实事件流水，静态图鉴总览：{bestiary.CreateStatusReport()}",
            _ => content.CreateStatusReport(),
        };
    }

    private static string GetBestiaryKindLabel(EraBestiaryEntryKind kind)
    {
        return kind switch
        {
            EraBestiaryEntryKind.Demon => "魔王",
            EraBestiaryEntryKind.General => "将领",
            EraBestiaryEntryKind.Legion => "军团",
            EraBestiaryEntryKind.Stronghold => "据点",
            EraBestiaryEntryKind.HeritageEquipment => "轮回装备",
            EraBestiaryEntryKind.HeritageTrait => "轮回特质",
            EraBestiaryEntryKind.PublicTrait => "公共特质",
            _ => kind.ToString(),
        };
    }

    private static string GetStageLabel(EraStage stage)
    {
        return stage switch
        {
            EraStage.PreDevelopment => "预发展",
            EraStage.Omen => "预兆",
            EraStage.Awakening => "苏醒",
            EraStage.Advent => "降临",
            EraStage.Reconstruction => "战后重建",
            _ => stage.ToString(),
        };
    }

    private static string BuildDemonSituationText(EraWorldRuntimeState state)
    {
        int planned = state.CurrentDemonIds.Count;
        int spawned = state.SpawnedDemons.Count;
        if (planned == 0)
        {
            return "本轮魔王名单还没有锁定。";
        }

        string names = string.Join("、", state.CurrentDemonIds.Take(4));
        string tail = planned > 4 ? $" 等 {planned} 名" : string.Empty;
        return spawned > 0
            ? $"已降临 {spawned}/{planned} 名：{names}{tail}。"
            : $"已锁定 {planned} 名，还未降临：{names}{tail}。";
    }

    private static string BuildGeneralSituationText(EraWorldRuntimeState state)
    {
        if (!state.OmenInitialized)
        {
            return "预兆尚未初始化，将领还未准备。";
        }

        return state.GeneralsSpawned
            ? $"已生成 {state.SpawnedGenerals.Count} 名将领。"
            : $"封印推进中，将领尚未上场；据点绑定 {state.FortressBindings.Count} 处。";
    }

    private static string BuildLegionSituationText(EraWorldRuntimeState state)
    {
        if (state.Stage == EraStage.PreDevelopment || state.Stage == EraStage.Reconstruction)
        {
            return "当前阶段不出波。";
        }

        return $"第 {state.LegionWaveIndex} 波；运行态记录 {state.SpawnedLegions.Count} 个军团单位。";
    }

    private static string BuildHeroSituationText(EraWorldRuntimeState state)
    {
        int livingArchives = state.HeroArchives.Count;
        int trackers = state.KingdomHeroTrackers.Count;
        int pending = state.KingdomHeroTrackers.Sum(item => item.PendingPromotionCharges);
        return pending > 0
            ? $"英雄档案 {livingArchives} 条；{trackers} 个王国追踪中；待晋升次数 {pending}。"
            : $"英雄档案 {livingArchives} 条；{trackers} 个王国追踪中。";
    }

    [Hotfixable]
    public static string BuildStoryListText()
    {
        if (EraRuntimeBootstrap.StoryRuntime == null)
        {
            return "故事素材服务还没有初始化。";
        }

        StringBuilder builder = new StringBuilder();
        IReadOnlyList<EraStoryChapter> chapters = EraRuntimeBootstrap.StoryRuntime.GetChapters();
        if (chapters.Count == 0)
        {
            builder.AppendLine("当前还没有采集到可展示的故事素材。");
            builder.AppendLine("等世界真正跑起来，事件流水、战争、联盟和阴谋素材开始积累，这里就会更像一本编年史。");
            return builder.ToString().TrimEnd();
        }

        builder.AppendLine($"故事素材总览：{EraRuntimeBootstrap.StoryRuntime.CreateStatusReport()}");
        builder.AppendLine("当前会同时整理：MOD 事件流水、轮回历史，以及 WorldBox 里的战争 / 联盟 / 阴谋真实关系。");
        builder.AppendLine();
        foreach (EraStoryChapter chapter in chapters)
        {
            builder.AppendLine($"年份 {chapter.Year}");
            foreach (EraStoryEntry entry in chapter.Entries.OrderBy(item => item.WorldTime))
            {
                builder.AppendLine($"- [{EraWorldTime.GetYearDate(entry.WorldTime)}] {entry.Title}");
                builder.AppendLine($"  来源：{entry.SourceLabel}");
                builder.AppendLine($"  内容：{entry.Summary}");
            }
            builder.AppendLine();
        }

        return builder.ToString().TrimEnd();
    }

    [Hotfixable]
    public static string BuildStoryConfigText()
    {
        return string.Join(
            Environment.NewLine,
            "故事生成器的当前规则：",
            "1. 只吃真实发生过的事件素材。",
            "2. 不能凭空新造人物、地点、时间和因果。",
            "3. LLM 只负责把素材改写得更像故事，不负责造史料。",
            "4. 当前阶段会按年份整理 MOD 事件流水、轮回历史，以及战争 / 联盟 / 阴谋这些原版真实关系。",
            "5. 在线改写统一走适配层；没配置适配器时，离线素材和导出照常可用。",
            string.Empty,
            $"当前事件流水状态：{EraRuntimeBootstrap.EventLog?.CreateStatusReport() ?? "事件流水服务未初始化。"}",
            $"当前故事素材状态：{EraRuntimeBootstrap.StoryRuntime?.CreateStatusReport() ?? "故事素材服务未初始化。"}",
            $"当前改写适配状态：{EraRuntimeBootstrap.StoryRuntime?.CreateRewriteStatusReport() ?? "故事改写服务未初始化。"}"
        );
    }

    [Hotfixable]
    public static string BuildStoryExportText()
    {
        return string.Join(
            Environment.NewLine,
            "导出 / 清理页当前可以做两件事：",
            "- 导出当前结构化故事素材，按年份分章写成 Markdown。",
            "- 导出 LLM 改写请求包，里面会同时放 JSON 素材和 Markdown 提示词。",
            "- 如果未来接上故事改写适配器，这里会额外生成改写结果文件；没接适配器时只会提示，不会挡住基础功能。",
            "- 清空故事缓存，下次再按当前真实事件重新整理。",
            "- 清理动作只碰故事缓存，不会误伤运行态存档。",
            string.Empty,
            $"当前故事状态：{EraRuntimeBootstrap.StoryRuntime?.CreateStatusReport() ?? "故事素材服务未初始化。"}",
            $"最近故事导出：{(string.IsNullOrWhiteSpace(EraRuntimeBootstrap.StoryRuntime?.LastExportPath) ? "尚未导出。" : Path.GetFileName(EraRuntimeBootstrap.StoryRuntime!.LastExportPath))}",
            $"最近改写请求：{(string.IsNullOrWhiteSpace(EraRuntimeBootstrap.StoryRuntime?.LastRewriteRequestPath) ? "尚未导出。" : Path.GetFileName(EraRuntimeBootstrap.StoryRuntime!.LastRewriteRequestPath))}",
            $"最近改写提示词：{(string.IsNullOrWhiteSpace(EraRuntimeBootstrap.StoryRuntime?.LastRewritePromptPath) ? "尚未导出。" : Path.GetFileName(EraRuntimeBootstrap.StoryRuntime!.LastRewritePromptPath))}",
            $"最近改写输出：{(string.IsNullOrWhiteSpace(EraRuntimeBootstrap.StoryRuntime?.LastRewriteOutputPath) ? "尚未生成。" : Path.GetFileName(EraRuntimeBootstrap.StoryRuntime!.LastRewriteOutputPath))}",
            $"最近操作结果：{EraRuntimeBootstrap.StoryRuntime?.LastOperationMessage ?? "尚未执行。"}"
        );
    }

    private static string BuildDemonBestiaryText(IReadOnlyList<EraDemonManifest> demons)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"当前魔王名册：{demons.Count} 名。");
        foreach (EraDemonManifest demon in demons)
        {
            builder.AppendLine($"- {demon.DisplayName}：核心机制 {demon.CoreMechanic}；战斗关键词 {demon.CombatKeywords}");
        }

        return builder.ToString().TrimEnd();
    }

    private static string BuildGeneralBestiaryText(
        IReadOnlyList<EraGeneralManifest> generals,
        IReadOnlyDictionary<string, EraDemonManifest> demonsById
    )
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"当前将领名册：{generals.Count} 名。");
        foreach (IGrouping<string, EraGeneralManifest> group in generals.GroupBy(item => item.DemonInternalId))
        {
            string demonName = demonsById.TryGetValue(group.Key, out EraDemonManifest? demon)
                ? demon.DisplayName
                : group.Key;
            builder.AppendLine($"{demonName}：{string.Join("、", group.Select(item => item.DisplayName))}");
        }

        return builder.ToString().TrimEnd();
    }

    private static string BuildLegionBestiaryText(
        IReadOnlyList<EraLegionManifest> legions,
        IReadOnlyDictionary<string, EraDemonManifest> demonsById
    )
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"当前军团模板：{legions.Count} 组。");
        foreach (EraLegionManifest legion in legions)
        {
            string demonName = demonsById.TryGetValue(legion.DemonInternalId, out EraDemonManifest? demon)
                ? demon.DisplayName
                : legion.DemonInternalId;
            builder.AppendLine($"- {legion.DisplayName}：归属 {demonName}，基础模板 {legion.BaseTemplateId}");
        }

        return builder.ToString().TrimEnd();
    }

    private static string BuildGeneralRuntimeText()
    {
        if (EraRuntimeBootstrap.RuntimeSave == null)
        {
            return "运行态存档还没有初始化。";
        }

        int generalCount = EraRuntimeBootstrap.RuntimeSave.CurrentState.SpawnedGenerals.Count;
        int fortressCount = EraRuntimeBootstrap.RuntimeSave.CurrentState.FortressBindings.Count;
        return string.Join(
            Environment.NewLine,
            EraRuntimeBootstrap.ReincarnationRuntime?.CreateStatusReport() ?? "轮回运行时还没有初始化。",
            $"当前已记录将领生成：{generalCount} 名。",
            $"当前据点绑定记录：{fortressCount} 条。"
        );
    }

    private static string BuildLegionRuntimeText()
    {
        if (EraRuntimeBootstrap.RuntimeSave == null)
        {
            return "运行态存档还没有初始化。";
        }

        int legionCount = EraRuntimeBootstrap.RuntimeSave.CurrentState.SpawnedLegions.Count;
        int waveIndex = EraRuntimeBootstrap.RuntimeSave.CurrentState.LegionWaveIndex;
        return string.Join(
            Environment.NewLine,
            EraRuntimeBootstrap.ReincarnationRuntime?.CreateStatusReport() ?? "轮回运行时还没有初始化。",
            $"当前军团记录数：{legionCount}。",
            $"当前波次序号：{waveIndex}。"
        );
    }

    private static string BuildKingdomRuntimeText()
    {
        if (EraRuntimeBootstrap.RuntimeSave == null)
        {
            return "运行态存档还没有初始化。";
        }

        int kingdomTierCount = EraRuntimeBootstrap.RuntimeSave.CurrentState.KingdomTiers.Count;
        int renownLedgerCount = EraRuntimeBootstrap.RuntimeSave.CurrentState.KingdomRenownLedgers.Count;
        return string.Join(
            Environment.NewLine,
            EraRuntimeBootstrap.AdvancementRuntime?.CreateStatusReport() ?? "轮回进阶运行时还没有初始化。",
            EraRuntimeBootstrap.KingdomRuntime?.CreateStatusReport() ?? "王国声望运行时还没有初始化。",
            $"王国档位缓存：{kingdomTierCount} 条。",
            $"王国声望账本：{renownLedgerCount} 条。"
        );
    }

    private static string BuildHeroRuntimeText()
    {
        if (EraRuntimeBootstrap.RuntimeSave == null)
        {
            return "运行态存档还没有初始化。";
        }

        int archiveCount = EraRuntimeBootstrap.RuntimeSave.CurrentState.HeroArchives.Count;
        int trackerCount = EraRuntimeBootstrap.RuntimeSave.CurrentState.KingdomHeroTrackers.Count;
        return string.Join(
            Environment.NewLine,
            EraRuntimeBootstrap.ProgressionRuntime?.CreateStatusReport() ?? "成长实例与英雄运行时还没有初始化。",
            $"英雄档案：{archiveCount} 条。",
            $"王国英雄追踪器：{trackerCount} 条。"
        );
    }
}
