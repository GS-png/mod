using EraWheel.Core.Constants;
using EraWheel.Combat.Statuses;
using EraWheel.Localization;

namespace EraWheel.Data.Registration;

public sealed class EraStatusRegistrationReport
{
    public int RegisteredCount { get; }
    public int SkippedCount { get; }

    public EraStatusRegistrationReport(int registeredCount, int skippedCount)
    {
        RegisteredCount = registeredCount;
        SkippedCount = skippedCount;
    }

    public string CreateStatusReport()
    {
        return $"运行时状态注册={RegisteredCount}；跳过={SkippedCount}。";
    }
}

public static class EraStatusRegistrationService
{
    public static EraStatusRegistrationReport Register(bool reloadMode = false)
    {
        int registered = 0;
        int skipped = 0;

        if (RegisterCivilWarWinnerStatus(reloadMode))
        {
            registered++;
        }
        else
        {
            skipped++;
        }

        int combatRegistered = EraCombatStatusCatalog.RegisterCustomStatuses(reloadMode);
        registered += combatRegistered;

        return new EraStatusRegistrationReport(registered, skipped);
    }

    private static bool RegisterCivilWarWinnerStatus(bool reloadMode)
    {
        if (!reloadMode && AssetManager.status.has(EraStatusIds.CivilWarWinner))
        {
            return false;
        }

        StatusAsset asset = new StatusAsset
        {
            id = EraStatusIds.CivilWarWinner,
            locale_id = $"{EraStatusIds.CivilWarWinner}_name",
            locale_description = $"{EraStatusIds.CivilWarWinner}_description",
            path_icon = "ui/Icons/iconWarning",
            can_be_cured = false,
            allow_timer_reset = true,
            duration = 0f,
            tier = StatusTier.Advanced,
            base_stats = BuildWinnerStats(),
        };

        AssetManager.status.add(asset);
        EraLocaleRegistrar.AddZhEn(asset.getLocaleID(), "内战胜者", "Civil War Victor");
        EraLocaleRegistrar.AddZhEn(
            asset.getDescriptionID(),
            "内战中活到最后的魔王。临时获得核心战斗属性提升。",
            "The last surviving demon in civil war. Temporarily gains core combat bonuses."
        );
        return true;
    }

    private static BaseStats BuildWinnerStats()
    {
        BaseStats stats = new BaseStats();
        stats[EraAttributeIds.MultiplierDamage] = EraPercentAttributeRules.ToRawEngineValue(EraAttributeIds.MultiplierDamage, 10f);
        stats[EraAttributeIds.MultiplierHealth] = EraPercentAttributeRules.ToRawEngineValue(EraAttributeIds.MultiplierHealth, 10f);
        stats[EraAttributeIds.MultiplierAttackSpeed] = EraPercentAttributeRules.ToRawEngineValue(EraAttributeIds.MultiplierAttackSpeed, 10f);
        stats[EraAttributeIds.MultiplierSpeed] = EraPercentAttributeRules.ToRawEngineValue(EraAttributeIds.MultiplierSpeed, 10f);
        return stats;
    }
}
