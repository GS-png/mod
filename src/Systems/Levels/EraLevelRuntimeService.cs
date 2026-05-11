using System;
using System.Collections.Generic;
using System.Linq;
using EraWheel.Combat.Statuses;
using EraWheel.Config.Registry;
using EraWheel.Config.Schema;
using EraWheel.Core.Constants;
using EraWheel.Core.Events;
using EraWheel.Core.Logging;
using EraWheel.Core.Random;
using EraWheel.Reflection;
using EraWheel.Save.Keys;
using EraWheel.Save.Models;
using Newtonsoft.Json;

namespace EraWheel.Systems.Levels;

public sealed class EraLevelRuntimeService
{
    private static readonly IReadOnlyDictionary<string, string> AttributeDisplayNames =
        new Dictionary<string, string>(StringComparer.Ordinal)
        {
            [EraAttributeIds.Damage] = "伤害",
            [EraAttributeIds.MultiplierDamage] = "伤害倍率",
            [EraAttributeIds.AttackSpeed] = "攻速",
            [EraAttributeIds.MultiplierAttackSpeed] = "攻速倍率",
            [EraAttributeIds.CriticalChance] = "暴击率",
            [EraAttributeIds.CriticalDamageMultiplier] = "暴击伤害倍率",
            [EraAttributeIds.ThrowingRange] = "投掷",
            [EraAttributeIds.Range] = "范围",
            [EraAttributeIds.AreaOfEffect] = "效果范围",
            [EraAttributeIds.Knockback] = "击退",
            [EraAttributeIds.Health] = "生命值",
            [EraAttributeIds.MultiplierHealth] = "生命值倍率",
            [EraAttributeIds.Armor] = "防御",
            [EraAttributeIds.Stamina] = "耐力",
            [EraAttributeIds.MultiplierStamina] = "耐力倍率",
            [EraAttributeIds.Mana] = "法力",
            [EraAttributeIds.MultiplierMana] = "法力倍率",
            [EraAttributeIds.MaxNutrition] = "最大营养",
            [EraAttributeIds.Happiness] = "幸福度",
            [EraAttributeIds.Lifespan] = "寿命",
            [EraAttributeIds.MultiplierLifespan] = "寿命倍率",
            [EraAttributeIds.Speed] = "移速",
            [EraAttributeIds.MultiplierSpeed] = "移速倍率",
            [EraAttributeIds.Mass] = "受力质量",
            [EraAttributeIds.MultiplierMass] = "体重倍率",
            [EraAttributeIds.SkillCombat] = "战斗技能",
            [EraAttributeIds.SkillSpell] = "施法",
            [EraAttributeIds.Diplomacy] = "外交",
            [EraAttributeIds.MultiplierDiplomacy] = "外交倍率",
            [EraAttributeIds.Warfare] = "指挥",
            [EraAttributeIds.Stewardship] = "组织",
            [EraAttributeIds.Intelligence] = "智力",
        };

    private readonly EraParameterRegistry _parameterRegistry;
    private readonly EraStableRandomService _stableRandom;
    private readonly EraEventLogService _eventLog;

    public EraLevelRuntimeService(
        EraParameterRegistry parameterRegistry,
        EraStableRandomService stableRandom,
        EraEventLogService eventLog)
    {
        _parameterRegistry = parameterRegistry;
        _stableRandom = stableRandom;
        _eventLog = eventLog;
        EraLevelPatchInstaller.EnsurePatched();
    }

    public void Bind()
    {
        EraLevelRuntimeBridge.Bind(this);
        EraLog.Info(EraLogCategory.Events, $"等级运行时已初始化：{CreateStatusReport()}");
    }

    public void Rebind()
    {
    }

    public void Update()
    {
    }

    public string CreateStatusReport()
    {
        EraLevelRandomProfile profile = _parameterRegistry.Current.Levels.RandomAttributes;
        return $"等级随机属性候选={profile.CandidateAttributeIds.Count}；每级随机属性数={profile.AttributesPerLevel}。";
    }

    public void AppendPersistentModifiers(Actor actor, IDictionary<string, float> bucket)
    {
        if (actor == null || bucket == null || actor.isRekt())
        {
            return;
        }

        EraActorLevelLedgerState ledger = EnsureLevelLedger(actor, Math.Max(1, actor.level), silent: true);
        if (ledger.TotalModifiers.Count > 0)
        {
            MergeModifiers(bucket, ledger.TotalModifiers);
        }
    }

    public void OnActorExperienceChanged(Actor actor, int previousLevel, int currentLevel)
    {
        if (actor == null || actor.isRekt() || currentLevel <= previousLevel)
        {
            return;
        }

        EnsureLevelLedger(actor, Math.Max(1, previousLevel), silent: true);
        EnsureLevelLedger(actor, currentLevel, silent: false);
        actor.setStatsDirty();
    }

    public EraActorLevelLedgerState GetActorLevelLedgerSnapshot(Actor actor)
    {
        return EnsureLevelLedger(actor, Math.Max(1, actor.level), silent: true);
    }

    private EraActorLevelLedgerState EnsureLevelLedger(Actor actor, int targetLevel, bool silent)
    {
        EraActorLevelLedgerState ledger = NormalizeLevelLedger(
            ReadState<EraActorLevelLedgerState>(actor.getData(), EraLevelDataKeys.ActorLevelLedger)
        ) ?? new EraActorLevelLedgerState();

        if (targetLevel <= ledger.LastAppliedLevel)
        {
            return ledger;
        }

        float worldTime = ReadWorldTime();
        for (int level = Math.Max(1, ledger.LastAppliedLevel + 1); level <= targetLevel; level++)
        {
            List<EraAttributeModifierEntry> modifiers = RollLevelAttributes(actor, level);
            ledger.Entries.Add(
                new EraLevelLedgerEntry
                {
                    Level = level,
                    GrantedWorldTime = worldTime,
                    Attributes = modifiers,
                }
            );
            ledger.LastAppliedLevel = level;
            MergeModifiers(ledger.TotalModifiers, modifiers);

            if (!silent)
            {
                _eventLog.Append(
                    "levels",
                    "actor_level_bonus_granted",
                    $"EW-095 等级加成已结算：{GetActorLabel(actor)} 达到 Lv{level}，获得 {FormatAttributeSummary(modifiers)}。"
                );
            }
        }

        WriteState(actor.getData(), EraLevelDataKeys.ActorLevelLedger, ledger);
        return ledger;
    }

    private List<EraAttributeModifierEntry> RollLevelAttributes(Actor actor, int level)
    {
        EraLevelRandomProfile profile = _parameterRegistry.Current.Levels.RandomAttributes;
        List<string> available = profile.CandidateAttributeIds
            .Where(attributeId => profile.AttributeValues.ContainsKey(attributeId))
            .Distinct(StringComparer.Ordinal)
            .ToList();
        List<EraAttributeModifierEntry> result = new List<EraAttributeModifierEntry>();
        string scope = $"level:{actor.getID()}:{level}";

        for (int index = 0; index < profile.AttributesPerLevel && available.Count > 0; index++)
        {
            int pickIndex = _stableRandom.NextInt("levels:attr_pick", $"{scope}:pick:{index}", 0, available.Count);
            string attributeId = available[pickIndex];
            available.RemoveAt(pickIndex);
            result.Add(
                new EraAttributeModifierEntry
                {
                    AttributeId = attributeId,
                    Value = EraPercentAttributeRules.ToRawEngineValue(attributeId, profile.AttributeValues[attributeId]),
                }
            );
        }

        return result;
    }

    private static EraActorLevelLedgerState? NormalizeLevelLedger(EraActorLevelLedgerState? state)
    {
        if (state == null)
        {
            return null;
        }

        state.TotalModifiers ??= new Dictionary<string, float>(StringComparer.Ordinal);
        state.Entries ??= new List<EraLevelLedgerEntry>();
        foreach (EraLevelLedgerEntry entry in state.Entries)
        {
            entry.Attributes ??= new List<EraAttributeModifierEntry>();
        }

        return state;
    }

    private static void MergeModifiers(IDictionary<string, float> target, IEnumerable<EraAttributeModifierEntry> source)
    {
        foreach (EraAttributeModifierEntry entry in source)
        {
            if (entry == null || string.IsNullOrWhiteSpace(entry.AttributeId) || Math.Abs(entry.Value) <= 0.0001f)
            {
                continue;
            }

            target.TryGetValue(entry.AttributeId, out float current);
            target[entry.AttributeId] = current + entry.Value;
        }
    }

    private static void MergeModifiers(IDictionary<string, float> target, IReadOnlyDictionary<string, float> source)
    {
        foreach ((string attributeId, float value) in source)
        {
            if (Math.Abs(value) <= 0.0001f)
            {
                continue;
            }

            target.TryGetValue(attributeId, out float current);
            target[attributeId] = current + value;
        }
    }

    private static TState? ReadState<TState>(BaseSystemData? data, string key)
        where TState : class
    {
        if (data == null || string.IsNullOrWhiteSpace(key))
        {
            return null;
        }

        data.get(key, out string json, string.Empty);
        if (string.IsNullOrWhiteSpace(json))
        {
            return null;
        }

        try
        {
            return JsonConvert.DeserializeObject<TState>(json);
        }
        catch
        {
            return null;
        }
    }

    private static void WriteState<TState>(BaseSystemData? data, string key, TState state)
        where TState : class
    {
        if (data == null || string.IsNullOrWhiteSpace(key) || state == null)
        {
            return;
        }

        data.set(key, JsonConvert.SerializeObject(state));
    }

    private static float ReadWorldTime()
    {
        return WorldboxReflectionAdapter.TryReadMapStats(out MapStats? mapStats) && mapStats != null
            ? (float)mapStats.world_time
            : 0f;
    }

    private static string GetActorLabel(Actor actor)
    {
        string name = actor.getName();
        return string.IsNullOrWhiteSpace(name) ? $"Actor#{actor.getID()}" : $"{name}(#{actor.getID()})";
    }

    private static string FormatAttributeSummary(IEnumerable<EraAttributeModifierEntry> entries)
    {
        List<string> parts = entries
            .Where(entry => entry != null && !string.IsNullOrWhiteSpace(entry.AttributeId))
            .Select(entry => $"{GetAttributeLabel(entry.AttributeId)} {FormatAttributeValue(entry.AttributeId, entry.Value)}")
            .ToList();
        return parts.Count == 0 ? "无" : string.Join("，", parts);
    }

    private static string GetAttributeLabel(string attributeId)
    {
        return AttributeDisplayNames.TryGetValue(attributeId, out string? label) ? label : attributeId;
    }

    private static string FormatAttributeValue(string attributeId, float value)
    {
        float displayValue = EraPercentAttributeRules.ToDisplayPercent(attributeId, value);
        return EraPercentAttributeRules.IsPercentAttribute(attributeId)
            ? $"{displayValue:+0.##;-0.##;0}%"
            : $"{displayValue:+0.##;-0.##;0}";
    }
}
