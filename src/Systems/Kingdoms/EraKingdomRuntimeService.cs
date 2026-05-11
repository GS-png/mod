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
using EraWheel.Save.Models;
using EraWheel.Save.Services;

namespace EraWheel.Systems.Kingdoms;

public sealed class EraKingdomRuntimeService
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
    private readonly EraRuntimeSaveService _runtimeSave;
    private IReadOnlyDictionary<long, EraKingdomRenownSnapshot> _publishedSnapshots =
        new Dictionary<long, EraKingdomRenownSnapshot>();

    public EraKingdomRuntimeService(
        EraParameterRegistry parameterRegistry,
        EraStableRandomService stableRandom,
        EraEventLogService eventLog,
        EraRuntimeSaveService runtimeSave)
    {
        _parameterRegistry = parameterRegistry;
        _stableRandom = stableRandom;
        _eventLog = eventLog;
        _runtimeSave = runtimeSave;
        EraKingdomPatchInstaller.EnsurePatched();
    }

    public void Bind()
    {
        PublishSnapshotCache();
        EraKingdomRuntimeBridge.Bind(this);
        EraLog.Info(EraLogCategory.Events, $"王国声望运行时已初始化：{CreateStatusReport()}");
    }

    public void Rebind()
    {
        PublishSnapshotCache();
    }

    public void Update()
    {
        if (World.world == null)
        {
            return;
        }

        float currentWorldTime = ReadWorldTime();
        HashSet<long> activeIds = new();
        foreach (Kingdom kingdom in World.world.kingdoms)
        {
            if (kingdom == null || kingdom.isRekt() || IsDemonFactionKingdom(kingdom))
            {
                continue;
            }

            activeIds.Add(kingdom.id);
            SyncKingdomRenown(kingdom, currentWorldTime);
        }

        _runtimeSave.CurrentState.KingdomRenownLedgers.RemoveAll(item => !activeIds.Contains(item.KingdomId));
        PublishSnapshotCache();
    }

    public string CreateStatusReport()
    {
        EraLevelRandomProfile profile = _parameterRegistry.Current.Kingdoms.RandomAttributes;
        return $"王国声望账本={_runtimeSave.CurrentState.KingdomRenownLedgers.Count}；声望随机属性候选={profile.CandidateAttributeIds.Count}；每级随机属性数={profile.AttributesPerLevel}。";
    }

    public void AppendPersistentModifiers(Actor actor, IDictionary<string, float> bucket)
    {
        if (actor == null ||
            bucket == null ||
            actor.isRekt() ||
            !actor.hasKingdom() ||
            actor.kingdom == null ||
            IsDemonFactionKingdom(actor.kingdom))
        {
            return;
        }

        EraKingdomRenownSnapshot? snapshot = GetKingdomRenownSnapshot(actor.kingdom);
        if (snapshot == null || snapshot.TotalModifiers.Count == 0)
        {
            return;
        }

        MergeModifiers(bucket, snapshot.TotalModifiers);
    }

    public void OnKingdomRenownChanged(Kingdom kingdom, int previousRenown, int currentRenown)
    {
        if (kingdom == null || kingdom.isRekt() || IsDemonFactionKingdom(kingdom))
        {
            return;
        }

        EraKingdomRenownLedgerState? ledger = SyncKingdomRenown(
            kingdom,
            ReadWorldTime(),
            currentRenown,
            useInitialObservedRenown: previousRenown);
        if (ledger != null)
        {
            PublishSnapshotCache();
            MarkKingdomUnitsStatsDirty(kingdom);
        }
    }

    public EraKingdomRenownSnapshot? GetKingdomRenownSnapshot(Kingdom? kingdom)
    {
        if (kingdom == null || kingdom.isRekt() || IsDemonFactionKingdom(kingdom))
        {
            return null;
        }

        return _publishedSnapshots.TryGetValue(kingdom.id, out EraKingdomRenownSnapshot? snapshot)
            ? snapshot
            : null;
    }

    private EraKingdomRenownLedgerState? SyncKingdomRenown(
        Kingdom? kingdom,
        float currentWorldTime,
        int? currentRenownOverride = null,
        int? useInitialObservedRenown = null)
    {
        if (kingdom == null || kingdom.isRekt() || IsDemonFactionKingdom(kingdom))
        {
            return null;
        }

        EraKingdomRenownLedgerState ledger = GetOrCreateKingdomRenownLedger(kingdom);

        ledger.KingdomName = kingdom.name ?? ledger.KingdomName;
        int observedRenown = Math.Max(0, currentRenownOverride ?? kingdom.getRenown());
        if (ledger.LastObservedRenown <= 0 && ledger.TotalAccumulatedRenown <= 0)
        {
            int initialRenown = Math.Max(0, useInitialObservedRenown ?? observedRenown);
            ledger.LastObservedRenown = initialRenown;
            ledger.TotalAccumulatedRenown = initialRenown;
        }

        if (observedRenown > ledger.LastObservedRenown)
        {
            ledger.TotalAccumulatedRenown += observedRenown - ledger.LastObservedRenown;
        }

        ledger.LastObservedRenown = observedRenown;

        bool grantedAny = false;
        int targetLevel = ResolveKingdomRenownLevel(ledger.TotalAccumulatedRenown);
        for (int level = Math.Max(1, ledger.LastAppliedLevel + 1); level <= targetLevel; level++)
        {
            List<EraAttributeModifierEntry> modifiers = RollKingdomAttributes(kingdom, level);
            ledger.Entries.Add(
                new EraKingdomLevelLedgerEntry
                {
                    Level = level,
                    TotalRenown = ledger.TotalAccumulatedRenown,
                    GrantedWorldTime = currentWorldTime,
                    Attributes = modifiers,
                }
            );
            ledger.LastAppliedLevel = level;
            MergeModifiers(ledger.TotalModifiers, modifiers);
            grantedAny = true;
            _eventLog.Append(
                "kingdoms",
                "kingdom_renown_level_granted",
                $"EW-096 王国声望升级：{GetKingdomLabel(kingdom)} 达到 Lv{level}，累计总声望 {ledger.TotalAccumulatedRenown}，获得 {FormatAttributeSummary(modifiers)}。"
            );
        }

        if (grantedAny)
        {
            MarkKingdomUnitsStatsDirty(kingdom);
        }

        return ledger;
    }

    private void PublishSnapshotCache()
    {
        Dictionary<long, EraKingdomRenownSnapshot> snapshots = new Dictionary<long, EraKingdomRenownSnapshot>();
        foreach (EraKingdomRenownLedgerState? state in _runtimeSave.CurrentState.KingdomRenownLedgers)
        {
            EraKingdomRenownLedgerState? ledger = NormalizeKingdomRenownLedger(state);
            if (ledger == null)
            {
                continue;
            }

            snapshots[ledger.KingdomId] = CreateSnapshot(ledger);
        }

        _publishedSnapshots = snapshots;
    }

    private EraKingdomRenownSnapshot CreateSnapshot(EraKingdomRenownLedgerState ledger)
    {
        return new EraKingdomRenownSnapshot
        {
            CurrentLevel = ResolveKingdomRenownLevel(ledger.TotalAccumulatedRenown),
            TotalAccumulatedRenown = ledger.TotalAccumulatedRenown,
            TotalModifiers = new Dictionary<string, float>(ledger.TotalModifiers, StringComparer.Ordinal),
        };
    }

    private EraKingdomRenownLedgerState GetOrCreateKingdomRenownLedger(Kingdom kingdom)
    {
        return FindKingdomRenownLedger(kingdom.id) ?? CreateKingdomRenownLedger(kingdom);
    }

    private EraKingdomRenownLedgerState? FindKingdomRenownLedger(long kingdomId)
    {
        List<EraKingdomRenownLedgerState> ledgers = _runtimeSave.CurrentState.KingdomRenownLedgers;
        for (int index = 0; index < ledgers.Count; index++)
        {
            EraKingdomRenownLedgerState? ledger = NormalizeKingdomRenownLedger(ledgers[index]);
            if (ledger != null && ledger.KingdomId == kingdomId)
            {
                return ledger;
            }
        }

        return null;
    }

    private EraKingdomRenownLedgerState CreateKingdomRenownLedger(Kingdom kingdom)
    {
        EraKingdomRenownLedgerState ledger = new EraKingdomRenownLedgerState
        {
            KingdomId = kingdom.id,
            KingdomName = !string.IsNullOrWhiteSpace(kingdom.name) ? kingdom.name : $"#{kingdom.id}",
        };
        _runtimeSave.CurrentState.KingdomRenownLedgers.Add(ledger);
        return ledger;
    }

    private List<EraAttributeModifierEntry> RollKingdomAttributes(Kingdom kingdom, int level)
    {
        EraLevelRandomProfile profile = _parameterRegistry.Current.Kingdoms.RandomAttributes;
        List<string> available = profile.CandidateAttributeIds
            .Where(attributeId => profile.AttributeValues.ContainsKey(attributeId))
            .Distinct(StringComparer.Ordinal)
            .ToList();
        List<EraAttributeModifierEntry> result = new List<EraAttributeModifierEntry>();
        string scope = $"kingdom:{kingdom.id}:{level}";

        for (int index = 0; index < profile.AttributesPerLevel && available.Count > 0; index++)
        {
            int pickIndex = _stableRandom.NextInt("kingdoms:attr_pick", $"{scope}:pick:{index}", 0, available.Count);
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

    private int ResolveKingdomRenownLevel(int totalRenown)
    {
        int maxLevel = Math.Max(1, _parameterRegistry.Current.Kingdoms.MaxLevel);
        int level = 0;
        foreach (EraKingdomRenownBand band in _parameterRegistry.Current.Kingdoms.RenownBands.OrderBy(item => item.StartLevel))
        {
            if (band.EndLevel < band.StartLevel || band.RenownPerLevel <= 0)
            {
                continue;
            }

            int bandLevelCount = band.EndLevel - band.StartLevel + 1;
            int requiredRenown = bandLevelCount * band.RenownPerLevel;
            if (totalRenown >= requiredRenown)
            {
                level = band.EndLevel;
                totalRenown -= requiredRenown;
                continue;
            }

            level = Math.Max(level, band.StartLevel - 1 + totalRenown / band.RenownPerLevel);
            break;
        }

        return Math.Min(maxLevel, Math.Max(0, level));
    }

    private static EraKingdomRenownLedgerState? NormalizeKingdomRenownLedger(EraKingdomRenownLedgerState? state)
    {
        if (state == null)
        {
            return null;
        }

        state.TotalModifiers ??= new Dictionary<string, float>(StringComparer.Ordinal);
        state.Entries ??= new List<EraKingdomLevelLedgerEntry>();
        foreach (EraKingdomLevelLedgerEntry entry in state.Entries)
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

    private static void MarkKingdomUnitsStatsDirty(Kingdom kingdom)
    {
        foreach (Actor actor in kingdom.getUnits())
        {
            if (actor != null && !actor.isRekt())
            {
                actor.setStatsDirty();
            }
        }
    }

    private static float ReadWorldTime()
    {
        return WorldboxReflectionAdapter.TryReadMapStats(out MapStats? mapStats) && mapStats != null
            ? (float)mapStats.world_time
            : 0f;
    }

    private static bool IsDemonFactionKingdom(Kingdom kingdom)
    {
        return kingdom != null &&
               !string.IsNullOrWhiteSpace(kingdom.asset?.id) &&
               kingdom.asset.id.StartsWith("ew_demon_kingdom_", StringComparison.OrdinalIgnoreCase);
    }

    private static string GetKingdomLabel(Kingdom kingdom)
    {
        string name = kingdom.name;
        return string.IsNullOrWhiteSpace(name) ? $"#{kingdom.id}" : $"{name}(#{kingdom.id})";
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
