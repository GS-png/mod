namespace EraWheel.Core.Constants;

public enum EraStage
{
    PreDevelopment = 0,
    Omen = 1,
    Awakening = 2,
    Advent = 3,
    Reconstruction = 4,
}

public enum EraModuleId
{
    Guide = 0,
    Reincarnation = 1,
    Demons = 2,
    Generals = 3,
    Legions = 4,
    Advancement = 5,
    Levels = 6,
    Kingdoms = 7,
    Heroes = 8,
    StoryGenerator = 9,
}

public enum EraWindowId
{
    Guide = 0,
    Reincarnation = 1,
    Demons = 2,
    Generals = 3,
    Legions = 4,
    Advancement = 5,
    Levels = 6,
    Kingdoms = 7,
    Heroes = 8,
    StoryGenerator = 9,
}

public enum EraTier
{
    Tier1 = 1,
    Tier2 = 2,
    Tier3 = 3,
    Tier4 = 4,
    Tier5 = 5,
    Tier6 = 6,
    Tier7 = 7,
    Tier8 = 8,
    Tier9 = 9,
    Tier10 = 10,
}

public enum EraFactionKind
{
    Neutral = 0,
    Kingdom = 1,
    Demon = 2,
}

public enum EraDemonInteractionMode
{
    Alliance = 0,
    CivilWar = 1,
    Random = 2,
}

public enum EraWorldTierProgressionMode
{
    AutoAdvance = 0,
    ManualControl = 1,
}

public enum EraKingdomTierMode
{
    AllUseWorldTier = 0,
    AllUseKingdomTier = 1,
    SurvivorsUseWorldTierAndNewcomersUseKingdomTier = 2,
}

public enum EraDemonKind
{
    VoidLord = 0,
    PlagueMother = 1,
    MechTyrant = 2,
    TimeDistorter = 3,
    ChaosFlame = 4,
    AbyssGod = 5,
    DeathKing = 6,
    SoulWeaver = 7,
    NatureWrath = 8,
    FinalJudge = 9,
}

public static class EraModConfigIds
{
    public const string DebugGroup = "ew_group_debug";
    public const string DevelopmentMode = "ew_debug_enabled";
    public const string EnableActorDetailPatch = "ew_debug_enable_actor_detail_patch";
    public const string EnableKingdomDetailPatch = "ew_debug_enable_kingdom_detail_patch";
    public const string EnableTopTabRetryVerboseLog = "ew_debug_enable_top_tab_retry_verbose_log";
}

public static class EraWindowIds
{
    public const string Guide = "ew_window_guide";
    public const string Reincarnation = "ew_window_reincarnation";
    public const string Demons = "ew_window_demons";
    public const string Generals = "ew_window_generals";
    public const string Legions = "ew_window_legions";
    public const string Advancement = "ew_window_advancement";
    public const string Levels = "ew_window_levels";
    public const string Kingdoms = "ew_window_kingdoms";
    public const string Heroes = "ew_window_heroes";
    public const string StoryGenerator = "ew_window_story_generator";
}

public static class EraSaveKeyPrefixes
{
    public const string Root = "ew_";
    public const string World = "ew_world_";
    public const string Runtime = "ew_runtime_";
    public const string Demon = "ew_demon_";
    public const string General = "ew_general_";
    public const string Legion = "ew_legion_";
    public const string Hero = "ew_hero_";
    public const string Kingdom = "ew_kingdom_";
    public const string History = "ew_history_";
    public const string Debug = "ew_debug_";
}

public static class EraWorldTimeConstants
{
    public const float WorldTimePerMonth = 5f;
    public const float WorldTimePerYear = 60f;
}
