using System.Collections.Generic;
using EraWheel.Config.Registry;
using EraWheel.Config.Schema;
using EraWheel.Core.Constants;
using EraWheel.Core.Random;
using EraWheel.Save.Models;

namespace EraWheel.Systems.Reincarnation;

public sealed class EraDemonInteractionService
{
    private readonly EraParameterRegistry _parameterRegistry;
    private readonly EraStableRandomService _stableRandom;

    public EraDemonInteractionService(EraParameterRegistry parameterRegistry, EraStableRandomService stableRandom)
    {
        _parameterRegistry = parameterRegistry;
        _stableRandom = stableRandom;
    }

    public EraDemonInteractionSnapshot ResolveState(
        IReadOnlyCollection<string> activeDemonIds,
        EraStage currentStage,
        float currentWorldTime,
        EraDemonInteractionState currentState,
        float nextRelationshipCheckWorldTime)
    {
        EraDemonParameters parameters = _parameterRegistry.Current.Demons;

        if (activeDemonIds.Count < 2)
        {
            return EraDemonInteractionSnapshot.Disabled(
                parameters.InteractionMode,
                BuildLabel(parameters.InteractionMode),
                currentStage,
                currentWorldTime,
                nextRelationshipCheckWorldTime,
                false,
                false,
                "当前不足两名魔王，多魔王模式未激活。"
            );
        }

        if (currentStage == EraStage.PreDevelopment || currentStage == EraStage.Reconstruction)
        {
            return EraDemonInteractionSnapshot.Disabled(
                parameters.InteractionMode,
                BuildLabel(parameters.InteractionMode),
                currentStage,
                currentWorldTime,
                nextRelationshipCheckWorldTime,
                false,
                false,
                "当前阶段不处理多魔王模式。"
            );
        }

        bool usesRandomRoll = parameters.InteractionMode == EraDemonInteractionMode.Random;
        bool shouldRollRandom = usesRandomRoll &&
                                (!currentState.Active ||
                                 !currentState.UsesRandomRoll ||
                                 currentState.Mode == EraDemonInteractionMode.Random ||
                                 currentWorldTime >= nextRelationshipCheckWorldTime);
        EraDemonInteractionMode effectiveMode = parameters.InteractionMode;
        float resolvedNextCheckWorldTime = nextRelationshipCheckWorldTime;
        if (usesRandomRoll)
        {
            if (shouldRollRandom)
            {
                effectiveMode = _stableRandom.NextInt("demon_interaction", "mode_roll", 0, 2) == 0
                    ? EraDemonInteractionMode.Alliance
                    : EraDemonInteractionMode.CivilWar;
                resolvedNextCheckWorldTime = currentWorldTime + parameters.RelationshipCheckInterval.WorldTime;
            }
            else
            {
                effectiveMode = currentState.Mode is EraDemonInteractionMode.Alliance or EraDemonInteractionMode.CivilWar
                    ? currentState.Mode
                    : EraDemonInteractionMode.Alliance;
            }
        }

        string description = BuildDescription(
            effectiveMode,
            usesRandomRoll,
            shouldRollRandom,
            resolvedNextCheckWorldTime,
            currentWorldTime
        );

        return EraDemonInteractionSnapshot.Active(
            effectiveMode,
            BuildLabel(effectiveMode),
            currentStage,
            currentWorldTime,
            resolvedNextCheckWorldTime,
            usesRandomRoll,
            shouldRollRandom,
            description
        );
    }

    private static string BuildLabel(EraDemonInteractionMode mode)
    {
        return mode switch
        {
            EraDemonInteractionMode.Alliance => "联盟",
            EraDemonInteractionMode.CivilWar => "内战",
            _ => "随机",
        };
    }

    private static string BuildDescription(
        EraDemonInteractionMode effectiveMode,
        bool usesRandomRoll,
        bool rerolled,
        float nextCheckWorldTime,
        float currentWorldTime)
    {
        string modeDescription = effectiveMode switch
        {
            EraDemonInteractionMode.Alliance => "联盟模式已生效：魔王阵营之间停火，并共同压制王国。",
            EraDemonInteractionMode.CivilWar => "内战模式已生效：魔王阵营彼此敌对，同时继续攻击王国。",
            _ => "随机模式等待关系结果。",
        };

        if (!usesRandomRoll)
        {
            return modeDescription;
        }

        string rollText = rerolled
            ? "本次已按随机模式重掷关系。"
            : "当前沿用上一轮随机结果。";
        float remaining = nextCheckWorldTime - currentWorldTime;
        return $"{rollText}{modeDescription} 下次校验剩余 world_time={remaining:F1}。";
    }
}

public readonly struct EraDemonInteractionSnapshot
{
    public EraDemonInteractionSnapshot(
        EraDemonInteractionMode mode,
        string label,
        EraStage stage,
        float worldTime,
        float nextCheckWorldTime,
        bool usesRandomRoll,
        bool rerolled,
        string description,
        bool active)
    {
        Mode = mode;
        Label = label;
        Stage = stage;
        WorldTime = worldTime;
        NextCheckWorldTime = nextCheckWorldTime;
        UsesRandomRoll = usesRandomRoll;
        Rerolled = rerolled;
        Description = description;
        IsActive = active;
    }

    public EraDemonInteractionMode Mode { get; }
    public string Label { get; }
    public EraStage Stage { get; }
    public float WorldTime { get; }
    public float NextCheckWorldTime { get; }
    public bool UsesRandomRoll { get; }
    public bool Rerolled { get; }
    public string Description { get; }
    public bool IsActive { get; }

    public static EraDemonInteractionSnapshot Active(
        EraDemonInteractionMode mode,
        string label,
        EraStage stage,
        float worldTime,
        float nextCheckWorldTime,
        bool usesRandomRoll,
        bool rerolled,
        string description)
        => new(mode, label, stage, worldTime, nextCheckWorldTime, usesRandomRoll, rerolled, description, true);

    public static EraDemonInteractionSnapshot Disabled(
        EraDemonInteractionMode mode,
        string label,
        EraStage stage,
        float worldTime,
        float nextCheckWorldTime,
        bool usesRandomRoll,
        bool rerolled,
        string description)
        => new(mode, label, stage, worldTime, nextCheckWorldTime, usesRandomRoll, rerolled, description, false);
}
