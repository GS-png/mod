using EraWheel.Assets;
using EraWheel.Core.Constants;
using EraWheel.Core.Logging;
using EraWheel.Data.Definitions;
using EraWheel.Reflection;

namespace EraWheel.Data.Registration;

public sealed class EraKingdomRegistrationReport
{
    public int RegisteredCount { get; }
    public int SkippedCount { get; }
    public int RuntimeCreatedCount { get; }

    public EraKingdomRegistrationReport(int registeredCount, int skippedCount, int runtimeCreatedCount)
    {
        RegisteredCount = registeredCount;
        SkippedCount = skippedCount;
        RuntimeCreatedCount = runtimeCreatedCount;
    }

    public string CreateStatusReport()
    {
        return $"魔王阵营王国注册={RegisteredCount}；跳过={SkippedCount}；当前世界补建={RuntimeCreatedCount}。";
    }
}

public static class EraKingdomRegistrationService
{
    public static EraKingdomRegistrationReport Register(EraContentCatalog contentCatalog, EraSpriteCatalog spriteCatalog, bool reloadMode = false)
    {
        int registered = 0;
        int skipped = 0;
        int runtimeCreated = 0;

        foreach (EraDemonManifest demon in contentCatalog.Demons)
        {
            if (RegisterKingdomAsset(demon, spriteCatalog, reloadMode))
            {
                registered++;
            }
            else
            {
                skipped++;
            }

            if (WorldboxReflectionAdapter.TryEnsureWildKingdom(EraDemonFactionIds.GetKingdomId(demon.InternalId)))
            {
                runtimeCreated++;
            }
        }

        return new EraKingdomRegistrationReport(registered, skipped, runtimeCreated);
    }

    private static bool RegisterKingdomAsset(EraDemonManifest manifest, EraSpriteCatalog spriteCatalog, bool reloadMode)
    {
        string kingdomId = EraDemonFactionIds.GetKingdomId(manifest.InternalId);
        if (!reloadMode && AssetManager.kingdoms.has(kingdomId))
        {
            return false;
        }

        KingdomAsset? template = AssetManager.kingdoms.get(EraWorldboxAssetIds.MobKingdomTemplate);
        if (template == null)
        {
            EraLog.Error(EraLogCategory.Data, $"缺少野怪王国模板，无法注册魔王阵营：{kingdomId}");
            return false;
        }

        AssetManager.kingdoms.clone(out KingdomAsset cloned, template);
        Configure(cloned, manifest, ResolveIconPath(manifest, spriteCatalog));
        AssetManager.kingdoms.add(cloned);
        return true;
    }

    private static void Configure(KingdomAsset asset, EraDemonManifest manifest, string iconPath)
    {
        string kingdomId = EraDemonFactionIds.GetKingdomId(manifest.InternalId);
        asset.id = kingdomId;
        asset.civ = false;
        asset.nomads = false;
        asset.mobs = true;
        asset.neutral = false;
        asset.nature = false;
        asset.brain = false;
        asset.count_as_danger = true;
        asset.always_attack_each_other = false;
        asset.force_look_all_chunks = true;
        asset.default_kingdom_color = CreateColor(manifest.Kind, kingdomId);
        asset.setIcon(iconPath);
        asset.list_tags.Clear();
        asset.friendly_tags.Clear();
        asset.enemy_tags.Clear();
        asset.addTag(kingdomId);
        asset.addTag(EraDemonFactionIds.SharedTag);
    }

    private static ColorAsset CreateColor(EraDemonKind kind, string kingdomId)
    {
        string hex = kind switch
        {
            EraDemonKind.VoidLord => "#6B5DFF",
            EraDemonKind.PlagueMother => "#7C9C3A",
            EraDemonKind.MechTyrant => "#8AA3B6",
            EraDemonKind.TimeDistorter => "#4CC7D9",
            EraDemonKind.ChaosFlame => "#FF7A3D",
            EraDemonKind.AbyssGod => "#7B3B9C",
            EraDemonKind.DeathKing => "#CFCFCF",
            EraDemonKind.SoulWeaver => "#E86FB7",
            EraDemonKind.NatureWrath => "#4FAE5A",
            EraDemonKind.FinalJudge => "#F0D66A",
            _ => "#888888",
        };

        ColorAsset color = ColorAsset.tryMakeNewColorAsset(hex);
        color.id = $"{kingdomId}_color";
        color.initColor();
        return color;
    }

    private static string ResolveIconPath(EraDemonManifest manifest, EraSpriteCatalog spriteCatalog)
    {
        if (spriteCatalog.DemonsById.TryGetValue(manifest.InternalId, out EraDemonSpriteSet? set) &&
            set.UnitIcon != null &&
            !string.IsNullOrWhiteSpace(set.UnitIcon.RuntimePathId))
        {
            return set.UnitIcon.RuntimePathId;
        }

        return manifest.UnitIconSourcePath;
    }
}
