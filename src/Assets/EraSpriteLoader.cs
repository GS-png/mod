using System;
using System.Collections.Generic;
using System.IO;
using EraWheel.Core;
using EraWheel.Core.Logging;
using UnityEngine;

namespace EraWheel.Assets;

public sealed class EraSpriteLoader
{
    private const long MaxSingleSpriteBytes = 8L * 1024L * 1024L;
    private readonly string _modRootPath;
    private readonly Dictionary<string, EraSpriteResource> _resourcesByPathId = new Dictionary<string, EraSpriteResource>();
    private static readonly HashSet<string> DuplicateSpriteWarnings = new HashSet<string>(StringComparer.Ordinal);

    public EraSpriteLoader(string modRootPath)
    {
        _modRootPath = modRootPath;
    }

    public EraSpriteResource? TryLoad(string runtimePathId, string sourcePath)
    {
        if (string.IsNullOrWhiteSpace(runtimePathId) || string.IsNullOrWhiteSpace(sourcePath))
        {
            return null;
        }

        if (_resourcesByPathId.TryGetValue(runtimePathId, out EraSpriteResource? cached))
        {
            return cached;
        }

        string absolutePath = EraPathResolver.ResolveModPath(_modRootPath, sourcePath);
        if (!File.Exists(absolutePath))
        {
            EraLog.Warning(EraLogCategory.Data, $"资源文件不存在，已跳过加载：{sourcePath}");
            return null;
        }

        FileInfo fileInfo = new FileInfo(absolutePath);
        if (fileInfo.Length == 0)
        {
            EraLog.Warning(EraLogCategory.Data, $"Sprite 文件为空，已跳过加载：{sourcePath}");
            return null;
        }

        if (fileInfo.Length > MaxSingleSpriteBytes)
        {
            EraLog.Warning(
                EraLogCategory.Data,
                $"Sprite 文件超过单图预算，已跳过加载：{sourcePath} size={fileInfo.Length} limit={MaxSingleSpriteBytes}"
            );
            return null;
        }

        try
        {
            byte[] bytes = File.ReadAllBytes(absolutePath);
            bool cacheUpdated = TryAddOrReuseSprite(runtimePathId, bytes, sourcePath);
            Sprite? sprite = SpriteTextureLoader.getSprite(runtimePathId);
            if (!cacheUpdated && sprite == null)
            {
                return null;
            }

            EraSpriteResource resource = new EraSpriteResource(runtimePathId, NormalizePath(sourcePath), sprite);
            _resourcesByPathId[runtimePathId] = resource;
            return resource;
        }
        catch (Exception exception)
        {
            EraLog.Exception(EraLogCategory.Data, $"加载 Sprite 失败：{sourcePath}", exception);
            return null;
        }
    }

    private static string NormalizePath(string path)
    {
        return path.Replace('\\', '/');
    }

    private static bool TryAddOrReuseSprite(string runtimePathId, byte[] bytes, string sourcePath)
    {
        if (EraSpriteCacheService.UpsertSprite(runtimePathId, bytes))
        {
            return true;
        }

        if (DuplicateSpriteWarnings.Add(runtimePathId))
        {
            EraLog.Warning(
                EraLogCategory.Data,
                $"检测到重复 Sprite 键，资源替换失败后已保留旧缓存：{runtimePathId} <- {sourcePath}"
            );
        }

        return false;
    }
}
