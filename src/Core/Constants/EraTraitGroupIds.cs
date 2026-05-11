namespace EraWheel.Core.Constants;

public static class EraTraitGroupIds
{
    public const int MinHeritageTier = 1;
    public const int MaxHeritageTier = 10;
    public const string GroupColor = "#D8D8D8";

    public const string PublicTraits = "ew_public_traits";

    public static string HeritageTier(int tier)
    {
        return $"ew_herit_t{tier}";
    }

    public static string LocaleKey(string groupId)
    {
        return $"trait_group_{groupId}";
    }

    public static string PublicTraitsLocaleKey => LocaleKey(PublicTraits);

    public static string HeritageTierLocaleKey(int tier)
    {
        return LocaleKey(HeritageTier(tier));
    }
}
