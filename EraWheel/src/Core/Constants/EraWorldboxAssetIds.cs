namespace EraWheel.Core.Constants;

public static class EraWorldboxAssetIds
{
    public const string MobNoGenesTemplate = "$mob_no_genes$";
    public const string MobKingdomTemplate = "$TEMPLATE_MOB$";
    public const string WildKingdomNeutral = "neutral";
}

public static class EraDemonFactionIds
{
    public const string SharedTag = "ew_demon_faction";

    public static string GetKingdomId(string demonId)
    {
        return $"ew_demon_kingdom_{demonId}";
    }
}

public static class EraStatusIds
{
    public const string CivilWarWinner = "ew_status_civil_war_winner";
}
