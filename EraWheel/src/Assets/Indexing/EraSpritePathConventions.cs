namespace EraWheel.Assets.Indexing;

public static class EraSpritePathConventions
{
    public const string PublicTraitSkillRoot = "Assets/Art/公共特质技能图片";
    public const string HeritageTraitSkillRoot = "Assets/Art/轮回阶位特质技能图片";
    public const string HeritageEquipmentSkillRoot = "Assets/Art/轮回阶位装备技能图片";
    public const string DemonSkillRoot = "Assets/Art/魔王技能图片";
    public const string UnitImageRoot = "Assets/Art/注册生物单位图片";

    public static string BuildPublicTraitIconKey(string traitId) => $"public_trait:{traitId}:icon";
    public static string BuildPublicTraitSkillKey(string traitId, int index) => $"public_trait:{traitId}:skill:{index}";
    public static string BuildHeritageTraitIconKey(string traitId) => $"heritage_trait:{traitId}:icon";
    public static string BuildHeritageTraitSkillKey(string traitId, int index) => $"heritage_trait:{traitId}:skill:{index}";
    public static string BuildHeritageEquipmentIconKey(string equipmentId) => $"heritage_equipment:{equipmentId}:icon";
    public static string BuildHeritageEquipmentSkillKey(string equipmentId, int index) => $"heritage_equipment:{equipmentId}:skill:{index}";
    public static string BuildDemonUnitIconKey(string demonId) => $"demon:{demonId}:unit_icon";
    public static string BuildDemonStrongholdKey(string demonId) => $"demon:{demonId}:stronghold";
    public static string BuildDemonSkillKey(string demonId, int index) => $"demon:{demonId}:skill:{index}";
    public static string BuildUnitIconKey(string unitKey) => $"unit:{unitKey}:icon";
    public static string BuildUnitWalkFrameKey(string unitKey, int index) => $"unit:{unitKey}:walk:{index}";
}
