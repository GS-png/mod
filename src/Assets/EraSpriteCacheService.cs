using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using EraWheel.Core.Logging;
using UnityEngine;

namespace EraWheel.Assets;

public static class EraSpriteCacheService
{
    private const long MaxSingleSpriteBytes = 8L * 1024L * 1024L;
    private static readonly BindingFlags AnyStatic = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
    private static readonly FieldInfo? CachedSpritesField = typeof(SpriteTextureLoader).GetField("_cached_sprites", AnyStatic);
    private static readonly FieldInfo? CachedSpriteListField = typeof(SpriteTextureLoader).GetField("_cached_sprite_list", AnyStatic);
    private static readonly Regex TrailingFrameNumberRegex = new Regex(@"_(\d+)$", RegexOptions.Compiled);

    public static bool UpsertSprite(string runtimePathId, byte[] bytes)
    {
        if (string.IsNullOrWhiteSpace(runtimePathId) || bytes == null)
        {
            return false;
        }

        if (!ValidateSpriteBytes(bytes, runtimePathId))
        {
            return false;
        }

        Dictionary<string, Sprite>? cache = CachedSpritesField?.GetValue(null) as Dictionary<string, Sprite>;
        if (cache == null)
        {
            try
            {
                SpriteTextureLoader.addSprite(runtimePathId, bytes);
                return true;
            }
            catch (Exception exception)
            {
                EraLog.Exception(EraLogCategory.Data, $"写入 Sprite 缓存失败：{runtimePathId}", exception);
                return false;
            }
        }

        Sprite? newSprite = CreateSprite(bytes, runtimePathId, runtimePathId);
        if (newSprite == null)
        {
            return false;
        }

        try
        {
            cache.TryGetValue(runtimePathId, out Sprite? oldSprite);
            cache[runtimePathId] = newSprite;
            if (!ReferenceEquals(oldSprite, newSprite))
            {
                SafeDestroySprite(oldSprite);
            }

            return true;
        }
        catch (Exception exception)
        {
            SafeDestroySprite(newSprite);
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
                Sprite? sprite = CreateSprite(
                    frames[index].Bytes,
                    $"walk_{frames[index].Order}",
                    $"{runtimePathId}#{frames[index].Order}"
                );
                if (sprite == null)
                {
                    DestroySprites(sprites);
                    return false;
                }

                sprites.Add(sprite);
            }

            if (sprites.Count == 0)
            {
                return false;
            }

            Sprite[] newSprites = sprites.ToArray();
            cache.TryGetValue(runtimePathId, out Sprite[]? oldSprites);
            cache[runtimePathId] = newSprites;
            if (!ReferenceEquals(oldSprites, newSprites) && oldSprites != null)
            {
                DestroySprites(oldSprites);
            }

            return true;
        }
        catch (Exception exception)
        {
            DestroySprites(sprites);
            EraLog.Exception(EraLogCategory.Data, $"写入 Sprite 列表缓存失败：{runtimePathId}", exception);
            return false;
        }
    }

    public static void ClearSpriteListCache(string runtimePathId)
    {
        Dictionary<string, Sprite[]>? cache = CachedSpriteListField?.GetValue(null) as Dictionary<string, Sprite[]>;
        if (cache == null || string.IsNullOrWhiteSpace(runtimePathId))
        {
            return;
        }

        if (cache.TryGetValue(runtimePathId, out Sprite[]? oldSprites))
        {
            cache.Remove(runtimePathId);
            DestroySprites(oldSprites);
        }
    }

    public static int? TryParseFrameOrder(string fileNameWithoutExtension)
    {
        if (string.IsNullOrWhiteSpace(fileNameWithoutExtension))
        {
            return null;
        }

        Match match = TrailingFrameNumberRegex.Match(fileNameWithoutExtension);
        if (!match.Success || !int.TryParse(match.Groups[1].Value, out int value))
        {
            return null;
        }

        return value;
    }

    private static bool ValidateSpriteBytes(byte[] bytes, string label)
    {
        if (bytes.Length == 0)
        {
            EraLog.Warning(EraLogCategory.Data, $"Sprite 数据为空，已跳过：{label}");
            return false;
        }

        if (bytes.Length > MaxSingleSpriteBytes)
        {
            EraLog.Warning(
                EraLogCategory.Data,
                $"Sprite 数据超过单图预算，已跳过：{label} size={bytes.Length} limit={MaxSingleSpriteBytes}"
            );
            return false;
        }

        return true;
    }

    private static Sprite? CreateSprite(byte[] bytes, string spriteName, string label)
    {
        if (!ValidateSpriteBytes(bytes, label))
        {
            return null;
        }

        Texture2D texture = new Texture2D(2, 2, TextureFormat.RGBA32, mipChain: false);
        try
        {
            if (!ImageConversion.LoadImage(texture, bytes, markNonReadable: false))
            {
                UnityEngine.Object.Destroy(texture);
                EraLog.Warning(EraLogCategory.Data, $"Sprite 图片解码失败，已跳过：{label}");
                return null;
            }

            texture.name = spriteName;
            Sprite sprite = Sprite.Create(
                texture,
                new Rect(0, 0, texture.width, texture.height),
                new Vector2(0.5f, 0.5f),
                1f
            );
            sprite.name = spriteName;
            return sprite;
        }
        catch (Exception exception)
        {
            UnityEngine.Object.Destroy(texture);
            EraLog.Exception(EraLogCategory.Data, $"创建 Sprite 失败：{label}", exception);
            return null;
        }
    }

    private static void DestroySprites(IEnumerable<Sprite?> sprites)
    {
        foreach (Sprite? sprite in sprites)
        {
            SafeDestroySprite(sprite);
        }
    }

    private static void SafeDestroySprite(Sprite? sprite)
    {
        if (sprite == null)
        {
            return;
        }

        Texture2D? texture = sprite.texture;
        UnityEngine.Object.Destroy(sprite);
        if (texture != null)
        {
            UnityEngine.Object.Destroy(texture);
        }
    }
}
