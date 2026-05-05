using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using EraWheel.Assets;
using EraWheel.Core.Logging;
using UnityEngine;

namespace EraWheel.HotReload;

public static class EraSpriteHotReloadService
{
    private static readonly BindingFlags AnyStatic = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
    private static readonly FieldInfo? CachedSpritesField = typeof(SpriteTextureLoader).GetField("_cached_sprites", AnyStatic);
    private static readonly FieldInfo? CachedSpriteListField = typeof(SpriteTextureLoader).GetField("_cached_sprite_list", AnyStatic);
    private static readonly Regex TrailingFrameNumberRegex = new Regex(@"_(\d+)$", RegexOptions.Compiled);
    private static readonly HashSet<string> LastCatalogPathIds = new HashSet<string>(StringComparer.Ordinal);

    private static int _updatedInSession;
    private static int _removedInSession;

    public static bool UpsertSprite(string runtimePathId, byte[] bytes)
    {
        Dictionary<string, Sprite>? cache = CachedSpritesField?.GetValue(null) as Dictionary<string, Sprite>;
        if (cache == null)
        {
            try
            {
                SpriteTextureLoader.addSprite(runtimePathId, bytes);
                _updatedInSession++;
                return true;
            }
            catch (Exception exception)
            {
                EraLog.Exception(EraLogCategory.Data, $"写入 Sprite 缓存失败：{runtimePathId}", exception);
                return false;
            }
        }

        if (cache.TryGetValue(runtimePathId, out Sprite? oldSprite))
        {
            cache.Remove(runtimePathId);
            SafeDestroySprite(oldSprite);
        }

        try
        {
            SpriteTextureLoader.addSprite(runtimePathId, bytes);
            _updatedInSession++;
            return true;
        }
        catch (Exception exception)
        {
            EraLog.Exception(EraLogCategory.Data, $"写入 Sprite 缓存失败：{runtimePathId}", exception);
            return false;
        }
    }

    public static bool UpsertSpriteList(string runtimePathId, IReadOnlyList<(int Order, byte[] Bytes)> frames)
    {
        if (string.IsNullOrWhiteSpace(runtimePathId) || frames == null || frames.Count == 0)
        {
            return false;
        }

        Dictionary<string, Sprite[]>? cache = CachedSpriteListField?.GetValue(null) as Dictionary<string, Sprite[]>;
        if (cache == null)
        {
            return false;
        }

        List<Sprite> sprites = new List<Sprite>(frames.Count);
        try
        {
            for (int index = 0; index < frames.Count; index++)
            {
                Sprite? sprite = CreateSprite(frames[index].Bytes, frames[index].Order);
                if (sprite == null)
                {
                    continue;
                }

                sprites.Add(sprite);
            }

            if (sprites.Count == 0)
            {
                return false;
            }

            if (cache != null && cache.TryGetValue(runtimePathId, out Sprite[]? oldSprites))
            {
                cache.Remove(runtimePathId);
                foreach (Sprite? oldSprite in oldSprites)
                {
                    SafeDestroySprite(oldSprite);
                }
            }

            cache[runtimePathId] = sprites.ToArray();
            _updatedInSession++;
            return true;
        }
        catch (Exception exception)
        {
            foreach (Sprite sprite in sprites)
            {
                SafeDestroySprite(sprite);
            }

            EraLog.Exception(EraLogCategory.Data, $"写入 Sprite 列表缓存失败：{runtimePathId}", exception);
            return false;
        }
    }

    public static void ReconcileCatalog(EraSpriteCatalog catalog)
    {
        Dictionary<string, Sprite>? cache = CachedSpritesField?.GetValue(null) as Dictionary<string, Sprite>;
        if (cache == null)
        {
            return;
        }

        HashSet<string> nextPathIds = CollectRuntimePathIds(catalog);
        List<string> stale = new List<string>();
        foreach (string pathId in LastCatalogPathIds)
        {
            if (!nextPathIds.Contains(pathId))
            {
                stale.Add(pathId);
            }
        }

        foreach (string stalePath in stale)
        {
            if (cache.TryGetValue(stalePath, out Sprite? oldSprite))
            {
                cache.Remove(stalePath);
                SafeDestroySprite(oldSprite);
                _removedInSession++;
            }
        }

        LastCatalogPathIds.Clear();
        foreach (string pathId in nextPathIds)
        {
            LastCatalogPathIds.Add(pathId);
        }
    }

    public static void DrainSessionStats(out int updated, out int removed)
    {
        updated = _updatedInSession;
        removed = _removedInSession;
        _updatedInSession = 0;
        _removedInSession = 0;
    }

    private static void SafeDestroySprite(Sprite? sprite)
    {
        if (sprite == null)
        {
            return;
        }

        try
        {
            Texture? texture = sprite.texture;
            if (texture != null)
            {
                UnityEngine.Object.Destroy(texture);
            }

            UnityEngine.Object.Destroy(sprite);
        }
        catch
        {
        }
    }

    public static void ClearSpriteListCache(string runtimePathId)
    {
        if (string.IsNullOrWhiteSpace(runtimePathId))
        {
            return;
        }

        Dictionary<string, Sprite[]>? cache = CachedSpriteListField?.GetValue(null) as Dictionary<string, Sprite[]>;
        if (cache == null || !cache.TryGetValue(runtimePathId, out Sprite[]? sprites))
        {
            return;
        }

        cache.Remove(runtimePathId);
        foreach (Sprite? sprite in sprites)
        {
            SafeDestroySprite(sprite);
        }
    }

    private static Sprite? CreateSprite(byte[] bytes, int index)
    {
        Texture2D texture = new Texture2D(1, 1);
        texture.filterMode = FilterMode.Point;
        if (!texture.LoadImage(bytes))
        {
            UnityEngine.Object.Destroy(texture);
            return null;
        }

        Sprite sprite = Sprite.Create(
            texture,
            new Rect(0f, 0f, texture.width, texture.height),
            new Vector2(0.5f, 0.5f),
            1f
        );
        sprite.name = $"walk_{index}";
        return sprite;
    }

    public static int? TryParseFrameOrder(string spriteName)
    {
        if (string.IsNullOrWhiteSpace(spriteName))
        {
            return null;
        }

        Match match = TrailingFrameNumberRegex.Match(spriteName);
        return match.Success && int.TryParse(match.Groups[1].Value, out int order) ? order : null;
    }

    private static HashSet<string> CollectRuntimePathIds(EraSpriteCatalog catalog)
    {
        HashSet<string> ids = new HashSet<string>(StringComparer.Ordinal);

        TryAdd(catalog.ModIcon);
        TryAdd(catalog.TopTabIcon);
        TryAdd(catalog.HudBranch9Crest);
        foreach (EraSpriteResource resource in catalog.EntryButtonsByModuleId.Values)
        {
            TryAdd(resource);
        }

        foreach (EraIndexedSpriteSet set in catalog.PublicTraitsById.Values)
        {
            TryAdd(set.Icon);
            TryAddRange(set.DetailSprites);
        }

        foreach (EraIndexedSpriteSet set in catalog.HeritageTraitsById.Values)
        {
            TryAdd(set.Icon);
            TryAddRange(set.DetailSprites);
        }

        foreach (EraIndexedSpriteSet set in catalog.HeritageEquipmentById.Values)
        {
            TryAdd(set.Icon);
            TryAddRange(set.DetailSprites);
        }

        foreach (EraDemonSpriteSet demonSet in catalog.DemonsById.Values)
        {
            TryAdd(demonSet.UnitIcon);
            TryAdd(demonSet.StrongholdIcon);
            foreach (IReadOnlyList<EraSpriteResource> group in demonSet.SkillSpritesByGroup.Values)
            {
                TryAddRange(group);
            }
        }

        foreach (EraUnitSpriteSet unitSet in catalog.UnitGroupsByKey.Values)
        {
            TryAdd(unitSet.Icon);
            TryAddRange(unitSet.WalkFrames);
            TryAddRange(unitSet.ExtraFrames);
        }

        return ids;

        void TryAdd(EraSpriteResource? resource)
        {
            if (resource == null || string.IsNullOrWhiteSpace(resource.RuntimePathId))
            {
                return;
            }

            ids.Add(resource.RuntimePathId);
        }

        void TryAddRange(IEnumerable<EraSpriteResource> resources)
        {
            foreach (EraSpriteResource resource in resources)
            {
                TryAdd(resource);
            }
        }
    }
}
