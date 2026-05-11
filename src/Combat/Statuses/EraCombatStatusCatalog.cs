using System.Collections.Generic;
using EraWheel.Core.Logging;
using EraWheel.Localization;

namespace EraWheel.Combat.Statuses;

public static class EraCombatStatusCatalog
{
    public const string MarkStatusId = "ew_status_runtime_mark";
    public const string StackStatusId = "ew_status_runtime_stack";
    public const string BuffStatusId = "ew_status_runtime_buff";
    public const string DebuffStatusId = "ew_status_runtime_debuff";

    public static IReadOnlyList<EraStatusDefinition> Definitions { get; } = new[]
    {
        new EraStatusDefinition(EraStatusKind.Shield, "shield", "护盾", "吸收即将到来的伤害。", nativeStatus: true, supportsShield: true),
        new EraStatusDefinition(EraStatusKind.Silence, "spell_silence", "沉默", "无法释放主动技能。", nativeStatus: true, blocksSpellCast: true),
        new EraStatusDefinition(EraStatusKind.Slow, "slowness", "减速", "移动速度下降。", nativeStatus: true, supportsDynamicModifiers: true),
        new EraStatusDefinition(EraStatusKind.Stun, "stunned", "眩晕", "暂时失去行动能力。", nativeStatus: true),
        new EraStatusDefinition(EraStatusKind.Mark, MarkStatusId, "标记", "被特殊效果点名。", supportsDynamicModifiers: false),
        new EraStatusDefinition(EraStatusKind.Stack, StackStatusId, "叠层", "身上存在可累积层数。", supportsDynamicModifiers: false),
        new EraStatusDefinition(EraStatusKind.TimedBuff, BuffStatusId, "增益", "临时属性提升。", supportsDynamicModifiers: true),
        new EraStatusDefinition(EraStatusKind.TimedDebuff, DebuffStatusId, "减益", "临时属性降低。", supportsDynamicModifiers: true),
    };

    public static int RegisterCustomStatuses(bool reloadMode = false)
    {
        int registered = 0;
        foreach (EraStatusDefinition definition in Definitions)
        {
            if (definition.NativeStatus)
            {
                continue;
            }

            if (!reloadMode && AssetManager.status.has(definition.StatusId))
            {
                continue;
            }

            StatusAsset asset = new StatusAsset
            {
                id = definition.StatusId,
                locale_id = $"{definition.StatusId}_name",
                locale_description = $"{definition.StatusId}_description",
                path_icon = "ui/Icons/iconWarning",
                can_be_cured = false,
                allow_timer_reset = true,
                duration = 0f,
                tier = StatusTier.Advanced,
                base_stats = new BaseStats(),
            };

            AssetManager.status.add(asset);
            EraLocaleRegistrar.AddZhEn(asset.getLocaleID(), definition.DisplayName, definition.DisplayName);
            EraLocaleRegistrar.AddZhEn(asset.getDescriptionID(), definition.Description, definition.Description);
            registered++;
        }

        if (registered > 0)
        {
            EraLog.Info(EraLogCategory.Combat, $"战斗状态目录已注册自定义状态 {registered} 个。");
        }

        return registered;
    }

    public static EraStatusDefinition Get(EraStatusKind kind)
    {
        foreach (EraStatusDefinition definition in Definitions)
        {
            if (definition.Kind == kind)
            {
                return definition;
            }
        }

        throw new KeyNotFoundException($"未定义状态类型：{kind}");
    }
}
