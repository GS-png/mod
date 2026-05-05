using System.Collections.Generic;
using HarmonyLib;
using EraWheel.Core.Logging;
using EraWheel.Reflection;
using UnityEngine;

namespace EraWheel.Combat;

[HarmonyPatch(typeof(ActorAssetLibrary), nameof(ActorAssetLibrary.preloadMainUnitSprites))]
public static class EraActorPreloadDiagnosticsPatch
{
    private static bool _loggedThisSession;

    [HarmonyPrefix]
    private static void BeforePreloadMainUnitSprites(ActorAssetLibrary __instance)
    {
        if (_loggedThisSession || __instance?.list == null)
        {
            return;
        }

        _loggedThisSession = true;
        List<string> suspiciousActors = new List<string>();
        foreach (ActorAsset asset in __instance.list)
        {
            if (asset == null || asset.has_override_sprite || !asset.has_sprite_renderer)
            {
                continue;
            }

            if (asset.texture_asset == null)
            {
                if (!WorldboxReflectionAdapter.TryPrepareActorTextures(asset) || asset.texture_asset == null)
                {
                    suspiciousActors.Add($"{asset.id}:texture_asset=null");
                    continue;
                }
            }

            if (string.IsNullOrWhiteSpace(asset.texture_asset.texture_path_main))
            {
                suspiciousActors.Add($"{asset.id}:main_path=empty");
                continue;
            }

            Sprite[]? sprites = SpriteTextureLoader.getSpriteList(asset.texture_asset.texture_path_main, pSkipIfEmpty: true);
            if (sprites == null || sprites.Length == 0)
            {
                suspiciousActors.Add($"{asset.id}:main_list=empty@{asset.texture_asset.texture_path_main}");
            }
        }

        if (suspiciousActors.Count == 0)
        {
            EraLog.Info(EraLogCategory.Startup, "单位预加载前诊断：未发现 texture_asset 或主贴图列表异常。");
            return;
        }

        EraLog.Warning(
            EraLogCategory.Startup,
            $"单位预加载前诊断：发现 {suspiciousActors.Count} 个可疑模板 -> {string.Join("; ", suspiciousActors)}"
        );
    }
}
