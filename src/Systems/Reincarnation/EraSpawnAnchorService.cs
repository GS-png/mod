using System;
using System.Linq;
using EraWheel.Data.Definitions;
using EraWheel.Reflection;
using EraWheel.Save.Models;
using EraWheel.Save.Services;

namespace EraWheel.Systems.Reincarnation;

public sealed class EraSpawnAnchorService
{
    private const int NearbyFallbackRadius = 12;

    private readonly EraRuntimeSaveService _runtimeSave;
    private readonly EraContentCatalog _contentCatalog;

    public EraSpawnAnchorService(EraRuntimeSaveService runtimeSave, EraContentCatalog contentCatalog)
    {
        _runtimeSave = runtimeSave;
        _contentCatalog = contentCatalog;
    }

    public bool TryGetBoundFortress(string demonId, out EraFortressBindingState? fortress)
    {
        fortress = _runtimeSave.CurrentState.FortressBindings
            .Find(item => string.Equals(item.DemonId, demonId, StringComparison.Ordinal));
        return fortress != null;
    }

    public bool TryResolveSpawnTile(EraFortressBindingState? fortress, out WorldTile? spawnTile)
    {
        spawnTile = null;
        if (World.world == null || fortress == null)
        {
            return false;
        }

        Building? building = ResolveBuilding(fortress);
        WorldTile? primary = building?.current_tile ?? World.world.GetTile(fortress.TileX, fortress.TileY);
        if (IsCandidateGroundTile(primary))
        {
            spawnTile = primary;
            return true;
        }

        if (primary == null)
        {
            return false;
        }

        spawnTile = FindNearbyBuildableTile(primary, NearbyFallbackRadius);
        return spawnTile != null;
    }

    public bool TrySpawnActorAtBoundFortress(
        string actorAssetId,
        string demonId,
        float spawnRadius,
        out Actor? actor,
        out EraFortressBindingState? fortress,
        out WorldTile? spawnTile
    )
    {
        actor = null;
        fortress = null;
        spawnTile = null;
        if (World.world == null || !TryGetBoundFortress(demonId, out fortress) || fortress == null)
        {
            return false;
        }

        if (!TryResolveSpawnTile(fortress, out spawnTile) || spawnTile == null)
        {
            return false;
        }

        actor = World.world.units.spawnNewUnit(actorAssetId, spawnTile, false, false, spawnRadius, null, false, true);
        return actor != null;
    }

    public bool TryDestroyBoundFortress(EraFortressBindingState fortress)
    {
        Building? building = ResolveBuilding(fortress);
        if (building != null)
        {
            return WorldboxReflectionAdapter.TryStartDestroyBuilding(building);
        }

        if (fortress.BuildingId > 0L)
        {
            return WorldboxReflectionAdapter.TryStartDestroyBuilding(fortress.BuildingId);
        }

        return false;
    }

    private Building? ResolveBuilding(EraFortressBindingState fortress)
    {
        if (World.world == null)
        {
            return null;
        }

        if (fortress.BuildingId > 0L &&
            WorldboxReflectionAdapter.TryGetBuilding(fortress.BuildingId, out Building? buildingById) &&
            buildingById != null &&
            IsMatchingStronghold(buildingById, fortress))
        {
            UpdateBindingFromBuilding(fortress, buildingById);
            return buildingById;
        }

        string? expectedBuildingId = GetExpectedStrongholdBuildingId(fortress.DemonId);
        Building? bestMatch = null;
        int bestDistance = int.MaxValue;

        foreach (Building candidate in World.world.buildings.occupied_buildings)
        {
            if (!IsMatchingStronghold(candidate, fortress, expectedBuildingId) || candidate.current_tile == null)
            {
                continue;
            }

            int distance = GetDistanceSquared(candidate.current_tile.x, candidate.current_tile.y, fortress.TileX, fortress.TileY);
            if (distance >= bestDistance)
            {
                continue;
            }

            bestDistance = distance;
            bestMatch = candidate;
        }

        if (bestMatch != null)
        {
            UpdateBindingFromBuilding(fortress, bestMatch);
        }

        return bestMatch;
    }

    private string? GetExpectedStrongholdBuildingId(string demonId)
    {
        EraStrongholdManifest? stronghold = _contentCatalog.Strongholds
            .FirstOrDefault(item => string.Equals(item.DemonInternalId, demonId, StringComparison.Ordinal));
        return stronghold?.BuildingId;
    }

    private static WorldTile? FindNearbyBuildableTile(WorldTile origin, int radius)
    {
        if (World.world == null)
        {
            return null;
        }

        for (int currentRadius = 1; currentRadius <= radius; currentRadius++)
        {
            for (int offsetX = -currentRadius; offsetX <= currentRadius; offsetX++)
            {
                for (int offsetY = -currentRadius; offsetY <= currentRadius; offsetY++)
                {
                    WorldTile? tile = World.world.GetTile(origin.x + offsetX, origin.y + offsetY);
                    if (IsCandidateGroundTile(tile))
                    {
                        return tile;
                    }
                }
            }
        }

        return null;
    }

    private static bool IsCandidateGroundTile(WorldTile? tile)
    {
        return tile != null &&
               tile.Type != null &&
               tile.Type.ground &&
               tile.Type.can_build_on &&
               !tile.Type.ocean;
    }

    private static bool IsMatchingStronghold(Building? building, EraFortressBindingState fortress, string? expectedBuildingId = null)
    {
        if (building == null || building.current_tile == null)
        {
            return false;
        }

        if (!string.IsNullOrWhiteSpace(expectedBuildingId) && fortress.BuildingId > 0L && building.getID() != fortress.BuildingId)
        {
            return false;
        }

        return GetDistanceSquared(building.current_tile.x, building.current_tile.y, fortress.TileX, fortress.TileY) <= NearbyFallbackRadius * NearbyFallbackRadius;
    }

    private static void UpdateBindingFromBuilding(EraFortressBindingState fortress, Building building)
    {
        WorldTile? tile = building.current_tile;
        if (tile == null)
        {
            return;
        }

        fortress.BuildingId = building.getID();
        fortress.TileX = tile.x;
        fortress.TileY = tile.y;
    }

    private static int GetDistanceSquared(int leftX, int leftY, int rightX, int rightY)
    {
        int deltaX = leftX - rightX;
        int deltaY = leftY - rightY;
        return deltaX * deltaX + deltaY * deltaY;
    }
}
