using System;
using System.Collections.Generic;
using System.IO;
using EraWheel.Core;
using EraWheel.Core.Logging;
using EraWheel.HotReload;
using UnityEngine;

namespace EraWheel.Assets;

public sealed class EraSpriteLoader
{
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

        try
        {
            byte[] bytes = File.ReadAllBytes(absolutePath);
            TryAddOrReuseSprite(runtimePathId, bytes, sourcePath);
            Sprite? sprite = SpriteTextureLoader.getSprite(runtimePathId);
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

    private static void TryAddOrReuseSprite(string runtimePathId, byte[] bytes, string sourcePath)
    {
        if (EraSpriteHotReloadService.UpsertSprite(runtimePathId, bytes))
        {
            return;
        }

        if (DuplicateSpriteWarnings.Add(runtimePathId))
        {
            EraLog.Warning(
                EraLogCategory.Data,
                $"检测到重复 Sprite 键，资源替换失败后已保留旧缓存：{runtimePathId} <- {sourcePath}"
            );
        }
    }
}
