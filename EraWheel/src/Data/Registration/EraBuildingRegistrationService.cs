using EraWheel.Assets;
using EraWheel.Core.Constants;
using EraWheel.Core.Logging;
using EraWheel.Data.Definitions;
using UnityEngine;

namespace EraWheel.Data.Registration;

public sealed class EraBuildingRegistrationReport
{
    public int RegisteredCount { get; }
    public int SkippedCount { get; }

    public EraBuildingRegistrationReport(int registeredCount, int skippedCount)
    {
        RegisteredCount = registeredCount;
        SkippedCount = skippedCount;
    }

    public string CreateStatusReport()
    {
        return $"据点模板注册={RegisteredCount}；跳过={SkippedCount}。";
    }
}

public static class EraBuildingRegistrationService
{
    public static EraBuildingRegistrationReport Register(EraContentCatalog contentCatalog, EraSpriteCatalog spriteCatalog, bool reloadMode = false)
    {
        int registered = 0;
        int skipped = 0;

        foreach (EraStrongholdManifest stronghold in contentCatalog.Strongholds)
        {
            if (RegisterStronghold(stronghold, contentCatalog, spriteCatalog, reloadMode))
            {
                registered++;
            }
            else
            {
                skipped++;
            }
        }

        return new EraBuildingRegistrationReport(registered, skipped);
    }

    private static bool RegisterStronghold(
        EraStrongholdManifest manifest,
        EraContentCatalog contentCatalog,
        EraSpriteCatalog spriteCatalog,
        bool reloadMode
    )
    {
        if (!reloadMode && AssetManager.buildings.has(manifest.BuildingId))
        {
            EraLog.Warning(EraLogCategory.Data, $"据点模板已存在，跳过重复注册：{manifest.BuildingId}");
            return false;
        }

        string spritePath = ResolveStrongholdSpritePath(manifest, contentCatalog, spriteCatalog);
        BuildingAsset asset = new BuildingAsset();
        ConfigureStronghold(asset, manifest, spritePath);
        BuildingAsset registered = AssetManager.buildings.add(asset);
        registered.loadBuildingSprites();
        return true;
    }

    private static void ConfigureStronghold(BuildingAsset asset, EraStrongholdManifest manifest, string spritePath)
    {
        asset.id = manifest.BuildingId;
        asset.group = "ew_strongholds";
        asset.type = "ew_stronghold";
        asset.material = "stone";
        asset.kingdom = EraDemonFactionIds.GetKingdomId(manifest.DemonInternalId);
        asset.building_type = BuildingType.Building_Mob;
        asset.fundament = new BuildingFundament(
            manifest.Placement.FundamentLeft,
            manifest.Placement.FundamentRight,
            manifest.Placement.FundamentTop,
            manifest.Placement.FundamentBottom
        );
        asset.base_stats = new BaseStats();
        asset.only_build_tiles = manifest.Placement.RequireWalkableLand;
        asset.can_be_placed_on_liquid = !manifest.Placement.AvoidDeepWater;
        asset.can_be_placed_on_blocks = false;
        asset.city_building = false;
        asset.ignored_by_cities = true;
        asset.can_be_demolished = true;
        asset.can_be_upgraded = false;
        asset.can_units_live_here = false;
        asset.check_for_close_building = false;
        asset.build_place_single = true;
        asset.build_place_center = true;
        asset.build_place_batch = false;
        asset.build_place_borders = false;
        asset.main_path = spritePath;
        asset.sprite_path = spritePath;
        asset.scale_base = Vector3.one;
        asset.shadow = false;
        asset.random_flip = false;
    }

    private static string ResolveStrongholdSpritePath(
        EraStrongholdManifest manifest,
        EraContentCatalog contentCatalog,
        EraSpriteCatalog spriteCatalog
    )
    {
        if (contentCatalog.DemonsById.TryGetValue(manifest.DemonInternalId, out EraDemonManifest? demon) &&
            spriteCatalog.DemonsById.TryGetValue(demon.InternalId, out EraDemonSpriteSet? set) &&
            set.StrongholdIcon != null &&
            !string.IsNullOrWhiteSpace(set.StrongholdIcon.RuntimePathId))
        {
            return set.StrongholdIcon.RuntimePathId;
        }

        return manifest.IconSourcePath;
    }
}
