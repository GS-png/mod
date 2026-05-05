using System.Collections.Generic;
using EraWheel.Core.Constants;
using EraWheel.Data.Definitions;
using EraWheel.Data.Manifests;

namespace EraWheel.Data.Loaders;

public static class EraContentManifestLoader
{
    private static readonly EraStrongholdPlacementMetadata DefaultStrongholdPlacement = new(
        artFootprintWidth: 7,
        artFootprintHeight: 3,
        fundamentLeft: 3,
        fundamentRight: 3,
        fundamentTop: 2,
        fundamentBottom: 0,
        requireWalkableLand: true,
        avoidDeepWater: true,
        retryNearbyWalkableTile: true
    );

    public static EraContentCatalog Load()
    {
        IReadOnlyList<EraDemonManifest> demons = EraDemonManifestData.All;
        IReadOnlyList<EraGeneralManifest> generals = EraGeneralManifestData.All;
        IReadOnlyList<EraLegionManifest> legions = BuildLegions(demons);
        IReadOnlyList<EraStrongholdManifest> strongholds = BuildStrongholds(demons);

        return new EraContentCatalog(
            demons,
            generals,
            legions,
            strongholds,
            EraPublicTraitManifestData.All,
            EraHeritageEquipmentManifestData.All,
            EraHeritageTraitManifestData.All
        );
    }

    private static IReadOnlyList<EraLegionManifest> BuildLegions(IReadOnlyList<EraDemonManifest> demons)
    {
        List<EraLegionManifest> legions = new List<EraLegionManifest>(demons.Count);
        foreach (EraDemonManifest demon in demons)
        {
            string suffix = demon.InternalId.StartsWith("demon_")
                ? demon.InternalId.Substring("demon_".Length)
                : demon.InternalId;
            string displayName = $"{demon.DisplayName}军团";
            string unitGroupKey = $"魔王与将领图片/{demon.DisplayName}/{displayName}";
            string iconSourcePath = $"Assets/Art/注册生物单位图片/{unitGroupKey}/icon.png";
            legions.Add(
                new EraLegionManifest(
                    $"legion_{suffix}",
                    displayName,
                    demon.InternalId,
                    unitGroupKey,
                    iconSourcePath,
                    EraWorldboxAssetIds.MobNoGenesTemplate
                )
            );
        }

        return legions;
    }

    private static IReadOnlyList<EraStrongholdManifest> BuildStrongholds(IReadOnlyList<EraDemonManifest> demons)
    {
        List<EraStrongholdManifest> strongholds = new List<EraStrongholdManifest>(demons.Count);
        foreach (EraDemonManifest demon in demons)
        {
            string suffix = demon.InternalId.StartsWith("demon_")
                ? demon.InternalId.Substring("demon_".Length)
                : demon.InternalId;
            strongholds.Add(
                new EraStrongholdManifest(
                    $"stronghold_{suffix}",
                    $"{demon.DisplayName}据点",
                    demon.InternalId,
                    demon.StrongholdIconSourcePath,
                    DefaultStrongholdPlacement
                )
            );
        }

        return strongholds;
    }
}
