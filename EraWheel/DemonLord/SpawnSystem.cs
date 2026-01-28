using System;
using EraWheel.Core;

namespace EraWheel.DemonLord
{
    public class SpawnSystem
    {
#if ERAWHEEL_SELFTEST
        public object TrySpawnDemon(string demonId)
        {
            return null;
        }

        public object TrySpawnUnit(string unitId, object tile)
        {
            return null;
        }

        public object TryPickSpawnTile(object anchorActor, int radius)
        {
            return null;
        }

        public bool TryGetActorTileCoords(object actor, out int x, out int y)
        {
            x = 0;
            y = 0;
            return false;
        }

        public bool TryGetActorId(object actor, out long id)
        {
            id = 0;
            return false;
        }

        public bool TrySpawnPlaceholder(string demonId)
        {
            return false;
        }

        public object TryFindActorByAssetId(string assetId)
        {
            return null;
        }

        public void LogSpawnAttempt(string demonId)
        {
            try
            {
                Log.Info("[EraWheel] Spawn placeholder demon: " + demonId);
            }
            catch
            {
            }
        }
#else
        public object TrySpawnDemon(string demonId)
        {
            return TrySpawnUnit(demonId, null);
        }

        public object TrySpawnUnit(string unitId, object tile)
        {
            if (string.IsNullOrEmpty(unitId)) return null;

            if (!ActorAssetRegistry.EnsureRegistered()) return null;

            var mapBox = MapBox.instance;
            if (mapBox == null || mapBox.units == null) return null;

            var spawnTile = tile as WorldTile ?? GetCenterTile(mapBox);
            if (spawnTile == null) return null;

            var actor = TrySpawnAt(mapBox, unitId, spawnTile);
            if (actor != null) return actor;

            actor = TrySpawnAround(mapBox, unitId, spawnTile, 12, 80);
            return actor;
        }

        public object TryPickSpawnTile(object anchorActor, int radius)
        {
            var mapBox = MapBox.instance;
            if (mapBox == null) return null;

            var anchor = TryGetActorTile(anchorActor) ?? GetCenterTile(mapBox);
            if (anchor == null) return null;

            if (radius <= 0) return anchor;

            WorldTile picked = anchor;
            var count = 0;
            foreach (var tile in anchor.getTilesAround(radius))
            {
                if (tile == null) continue;
                count++;
                if (UnityEngine.Random.Range(0, count) == 0)
                {
                    picked = tile;
                }
            }

            return picked;
        }

        public bool TryGetActorTileCoords(object actor, out int x, out int y)
        {
            x = 0;
            y = 0;
            var tile = TryGetActorTile(actor);
            if (tile == null) return false;
            x = tile.x;
            y = tile.y;
            return true;
        }

        public bool TryGetActorId(object actor, out long id)
        {
            id = 0;
            var a = actor as Actor;
            if (a == null) return false;
            id = a.getID();
            return id > 0;
        }

        public bool TrySpawnPlaceholder(string demonId)
        {
            return TrySpawnDemon(demonId) != null;
        }

        public object TryFindActorByAssetId(string assetId)
        {
            if (string.IsNullOrEmpty(assetId)) return null;

            var mapBox = MapBox.instance;
            if (mapBox == null || mapBox.units == null) return null;

            foreach (var actor in mapBox.units)
            {
                if (actor == null) continue;
                var asset = actor.asset;
                if (asset == null || string.IsNullOrEmpty(asset.id)) continue;

                if (string.Equals(asset.id, assetId, StringComparison.Ordinal))
                {
                    return actor;
                }
            }

            return null;
        }

        public void LogSpawnAttempt(string demonId)
        {
            try
            {
                Log.Info("[EraWheel] Spawn placeholder demon: " + demonId);
            }
            catch
            {
            }
        }

        private static WorldTile TryGetActorTile(object actor)
        {
            var a = actor as Actor;
            if (a == null) return null;
            return a.current_tile;
        }

        private static WorldTile GetCenterTile(MapBox mapBox)
        {
            if (mapBox == null) return null;

            if (MapBox.width <= 0 || MapBox.height <= 0) return null;

            var x = Math.Max(0, Math.Min(MapBox.width - 1, MapBox.width / 2));
            var y = Math.Max(0, Math.Min(MapBox.height - 1, MapBox.height / 2));

            return mapBox.GetTile(x, y);
        }

        private static object TrySpawnAt(MapBox mapBox, string unitId, WorldTile spawnTile)
        {
            if (mapBox == null || mapBox.units == null || spawnTile == null) return null;

            try
            {
                return mapBox.units.spawnNewUnit(unitId, spawnTile, false, false, 6f, null, false, false);
            }
            catch
            {
                return null;
            }
        }

        private static object TrySpawnAround(MapBox mapBox, string unitId, WorldTile anchor, int radius, int maxTries)
        {
            if (mapBox == null || mapBox.units == null || anchor == null) return null;
            if (radius <= 0 || maxTries <= 0) return null;

            var tries = 0;
            foreach (var tile in anchor.getTilesAround(radius))
            {
                if (tile == null) continue;
                var actor = TrySpawnAt(mapBox, unitId, tile);
                if (actor != null) return actor;
                tries++;
                if (tries >= maxTries) break;
            }

            return null;
        }
#endif
    }
}
