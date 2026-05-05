using System.Collections.Generic;
using EraWheel.Core.Constants;
using EraWheel.Core.Time;

namespace EraWheel.Config.Schema;

public sealed class EraDuration
{
    public float Years { get; set; }

    public float WorldTime => EraWorldTime.YearsToWorldTime(Years);

    public static EraDuration FromYears(float years)
    {
        return new EraDuration
        {
            Years = years,
        };
    }
}

public sealed class EraFloatRange
{
    public float Min { get; set; }
    public float Max { get; set; }
}

public sealed class EraKingdomRenownBand
{
    public int StartLevel { get; set; }
    public int EndLevel { get; set; }
    public int RenownPerLevel { get; set; }
}

public sealed class EraHeroScoreProfile
{
    public float LevelWeight { get; set; }
    public float KillWeight { get; set; }
    public float HealthWeight { get; set; }
    public float DamageWeight { get; set; }
    public float WarfareWeight { get; set; }
    public int LevelThreshold { get; set; }
    public int KillThreshold { get; set; }
    public int HealthThreshold { get; set; }
    public int DamageThreshold { get; set; }
    public int WarfareThreshold { get; set; }
}

public sealed class EraControlMetric
{
    public int Threshold { get; set; }
    public float Weight { get; set; }
}

public sealed class EraControlProfile
{
    public int NewKingdomFloorTier { get; set; }
    public EraDuration RefreshInterval { get; set; } = EraDuration.FromYears(0f);
    public float BaseScore { get; set; }
    public EraControlMetric Cities { get; set; } = new EraControlMetric();
    public EraControlMetric Population { get; set; } = new EraControlMetric();
    public EraControlMetric Military { get; set; } = new EraControlMetric();
    public EraControlMetric Books { get; set; } = new EraControlMetric();
}

public sealed class EraRandomAttributeProfile
{
    public IReadOnlyList<string> CandidateAttributeIds { get; set; } = new string[0];
    public int EquipmentAttributesPerItem { get; set; }
    public int TraitAttributesPerItem { get; set; }
    public IReadOnlyDictionary<string, EraFloatRange> AttributeRanges { get; set; }
        = new Dictionary<string, EraFloatRange>();
}

public sealed class EraLevelRandomProfile
{
    public IReadOnlyList<string> CandidateAttributeIds { get; set; } = new string[0];
    public int AttributesPerLevel { get; set; }
    public IReadOnlyDictionary<string, float> AttributeValues { get; set; }
        = new Dictionary<string, float>();
}

public sealed class EraRuntimeParameters
{
    public EraReincarnationParameters Reincarnation { get; set; } = new EraReincarnationParameters();
    public EraDemonParameters Demons { get; set; } = new EraDemonParameters();
    public EraLegionParameters Legions { get; set; } = new EraLegionParameters();
    public EraAdvancementParameters Advancement { get; set; } = new EraAdvancementParameters();
    public EraLevelParameters Levels { get; set; } = new EraLevelParameters();
    public EraKingdomParameters Kingdoms { get; set; } = new EraKingdomParameters();
    public EraHeroParameters Heroes { get; set; } = new EraHeroParameters();
    public EraGrowthParameters Growth { get; set; } = new EraGrowthParameters();
}

public sealed class EraReincarnationParameters
{
    public int OmenPopulationThreshold { get; set; }
    public EraDuration PreDevelopmentCheckInterval { get; set; } = EraDuration.FromYears(0f);
    public float GeneralSealInitialPercent { get; set; }
    public float GeneralSealDecayPercentPerYear { get; set; }
    public float DemonSealInitialPercent { get; set; }
    public float DemonSealDecayPercentPerYear { get; set; }
}

public sealed class EraDemonParameters
{
    public IReadOnlyList<EraDemonKind> EnabledDemons { get; set; } = new EraDemonKind[0];
    public EraDemonAwakeningMode AwakeningMode { get; set; }
    public int AwakeningCount { get; set; }
    public EraDemonInteractionMode InteractionMode { get; set; }
    public EraDuration RelationshipCheckInterval { get; set; } = EraDuration.FromYears(0f);
    public float AllianceStrengthPercent { get; set; }
    public float CivilWarStrengthPercent { get; set; }
    public int CivilWarMaxDemons { get; set; }
    public EraDuration CivilWarWinnerBonusDuration { get; set; } = EraDuration.FromYears(0f);
    public float CivilWarWinnerBonusPercent { get; set; }
}

public sealed class EraLegionParameters
{
    public EraDuration SpawnInterval { get; set; } = EraDuration.FromYears(0f);
    public int InitialCount { get; set; }
    public int ConcurrentLimit { get; set; }
    public float GrowthPercentPerWave { get; set; }
}

public sealed class EraAdvancementParameters
{
    public int MaxTier { get; set; }
    public int TierIncreasePerCycle { get; set; }
    public EraWorldTierProgressionMode ProgressionMode { get; set; }
    public int ManualWorldTier { get; set; }
    public EraKingdomTierMode KingdomTierMode { get; set; }
    public EraControlProfile Control { get; set; } = new EraControlProfile();
    public EraDuration DemonEquipmentRefreshInterval { get; set; } = EraDuration.FromYears(0f);
    public EraRandomAttributeProfile RandomAttributes { get; set; } = new EraRandomAttributeProfile();
}

public sealed class EraLevelParameters
{
    public EraLevelRandomProfile RandomAttributes { get; set; } = new EraLevelRandomProfile();
}

public sealed class EraKingdomParameters
{
    public int MaxLevel { get; set; }
    public IReadOnlyList<EraKingdomRenownBand> RenownBands { get; set; } = new EraKingdomRenownBand[0];
    public EraLevelRandomProfile RandomAttributes { get; set; } = new EraLevelRandomProfile();
}

public sealed class EraHeroParameters
{
    public int HeroesPerKingdomLimit { get; set; }
    public int HeroesWorldLimit { get; set; }
    public int ProsperityPopulationGrowthThreshold { get; set; }
    public EraDuration CrisisWindow { get; set; } = EraDuration.FromYears(0f);
    public float CrisisPopulationLossPercent { get; set; }
    public EraHeroScoreProfile ScoreProfile { get; set; } = new EraHeroScoreProfile();
    public int RandomTopCandidateCount { get; set; }
    public bool SurvivorBonusEnabled { get; set; }
    public float SurvivorBonusPercentPerCycle { get; set; }
    public float SurvivorBonusCapPercent { get; set; }
    public float BloodlineInheritanceChancePercent { get; set; }
    public float BloodlineInheritanceValuePercent { get; set; }
    public int BloodlineGenerationLimit { get; set; }
    public float AwakenedScoreBonusPercent { get; set; }
}

public sealed class EraGrowthParameters
{
    public IReadOnlyDictionary<string, EraFloatRange> DemonBaseRanges { get; set; }
        = new Dictionary<string, EraFloatRange>();
    public IReadOnlyDictionary<string, EraFloatRange> GeneralBaseRanges { get; set; }
        = new Dictionary<string, EraFloatRange>();
    public IReadOnlyDictionary<string, EraFloatRange> HeroPromotionRanges { get; set; }
        = new Dictionary<string, EraFloatRange>();
    public IReadOnlyDictionary<string, EraFloatRange> LegionBaseRanges { get; set; }
        = new Dictionary<string, EraFloatRange>();
}
