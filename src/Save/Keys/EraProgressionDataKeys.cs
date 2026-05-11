namespace EraWheel.Save.Keys;

public static class EraProgressionDataKeys
{
    public const string ActorHeroState = "ew_actor_hero_state";
    public const string TraitInstancePrefix = "ew_actor_trait_instance_";
    public const string EquipmentInstance = "ew_item_heritage_instance";
    public const string EquipmentPendingSource = "ew_item_heritage_pending_source";

    public static string BuildTraitInstanceKey(string traitId)
    {
        return $"{TraitInstancePrefix}{traitId}";
    }
}
