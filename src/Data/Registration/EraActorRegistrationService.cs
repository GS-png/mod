using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EraWheel.Assets;
using EraWheel.Core;
using EraWheel.Core.Constants;
using EraWheel.Core.Logging;
using EraWheel.Data.Definitions;
using EraWheel.HotReload;
using EraWheel.Localization;
using EraWheel.Reflection;
using NeoModLoader.General;
using UnityEngine;

namespace EraWheel.Data.Registration;

public sealed class EraActorRegistrationReport
{
    public int DemonRegisteredCount { get; }
    public int GeneralRegisteredCount { get; }
    public int LegionRegisteredCount { get; }
    public int SkippedCount { get; }

    public EraActorRegistrationReport(
        int demonRegisteredCount,
        int generalRegisteredCount,
        int legionRegisteredCount,
        int skippedCount
    )
    {
        DemonRegisteredCount = demonRegisteredCount;
        GeneralRegisteredCount = generalRegisteredCount;
        LegionRegisteredCount = legionRegisteredCount;
        SkippedCount = skippedCount;
    }

    public string CreateStatusReport()
    {
        return $"魔王模板注册={DemonRegisteredCount}；将领模板注册={GeneralRegisteredCount}；军团模板注册={LegionRegisteredCount}；跳过={SkippedCount}。";
    }
}

public static class EraActorRegistrationService
{
    private const string ActorTextureRoot = "actors/species/other";
    private static string _modRootPath = string.Empty;

    public static EraActorRegistrationReport Register(EraContentCatalog contentCatalog, EraSpriteCatalog spriteCatalog, bool reloadMode = false)
    {
        _modRootPath = EraWheelMod.I.GetDeclaration().FolderPath;
        int demons = 0;
        int generals = 0;
        int legions = 0;
        int skipped = 0;

        foreach (EraDemonManifest demon in contentCatalog.Demons)
        {
            if (RegisterDemon(demon, spriteCatalog, reloadMode))
            {
                demons++;
            }
            else
            {
                skipped++;
            }
        }

        foreach (EraGeneralManifest general in contentCatalog.Generals)
        {
            if (RegisterGeneral(general, contentCatalog, spriteCatalog, reloadMode))
            {
                generals++;
            }
            else
            {
                skipped++;
            }
        }

        foreach (EraLegionManifest legion in contentCatalog.Legions)
        {
            if (RegisterLegion(legion, contentCatalog, spriteCatalog, reloadMode))
            {
                legions++;
            }
            else
            {
                skipped++;
            }
        }

        if (LocalizedTextManager.instance != null)
        {
            LM.ApplyLocale(false);
        }

        return new EraActorRegistrationReport(demons, generals, legions, skipped);
    }

    private static bool RegisterDemon(EraDemonManifest manifest, EraSpriteCatalog spriteCatalog, bool reloadMode)
    {
        return RegisterActor(
            manifest.InternalId,
            manifest.DisplayName,
            BuildDemonDescription(manifest),
            ResolveDemonIconPath(manifest, spriteCatalog),
            ResolveDemonWalkFrames(manifest, spriteCatalog),
            "魔王",
            EraDemonFactionIds.GetKingdomId(manifest.InternalId),
            canBeFavorited: true,
            reloadMode
        );
    }

    private static bool RegisterGeneral(
        EraGeneralManifest manifest,
        EraContentCatalog contentCatalog,
        EraSpriteCatalog spriteCatalog,
        bool reloadMode
    )
    {
        string demonName = contentCatalog.DemonsById.TryGetValue(manifest.DemonInternalId, out EraDemonManifest? demon)
            ? demon.DisplayName
            : manifest.DemonInternalId;
        return RegisterActor(
            manifest.InternalId,
            manifest.DisplayName,
            $"归属魔王：{demonName}\n基础母版：{EraWorldboxAssetIds.MobNoGenesTemplate}",
            ResolveGeneralIconPath(manifest, spriteCatalog),
            ResolveGeneralWalkFrames(manifest, spriteCatalog),
            "将领",
            EraDemonFactionIds.GetKingdomId(manifest.DemonInternalId),
            canBeFavorited: true,
            reloadMode
        );
    }

    private static bool RegisterLegion(
        EraLegionManifest manifest,
        EraContentCatalog contentCatalog,
        EraSpriteCatalog spriteCatalog,
        bool reloadMode
    )
    {
        string demonName = contentCatalog.DemonsById.TryGetValue(manifest.DemonInternalId, out EraDemonManifest? demon)
            ? demon.DisplayName
            : manifest.DemonInternalId;
        return RegisterActor(
            manifest.InternalId,
            manifest.DisplayName,
            $"归属魔王：{demonName}\n类型：军团基础模板\n基础母版：{manifest.BaseTemplateId}",
            ResolveLegionIconPath(manifest, spriteCatalog),
            ResolveLegionWalkFrames(manifest, spriteCatalog),
            "军团",
            EraDemonFactionIds.GetKingdomId(manifest.DemonInternalId),
            canBeFavorited: false,
            reloadMode
        );
    }

    private static bool RegisterActor(
        string actorId,
        string displayName,
        string description,
        string iconPath,
        IReadOnlyList<EraSpriteResource> walkFrames,
        string actorKindLabel,
        string wildKingdomId,
        bool canBeFavorited,
        bool reloadMode
    )
    {
        if (!reloadMode && AssetManager.actor_library.has(actorId))
        {
            EraLog.Warning(EraLogCategory.Data, $"单位模板已存在，跳过重复注册：{actorId}");
            return false;
        }

        ActorAsset? template = AssetManager.actor_library.get(EraWorldboxAssetIds.MobNoGenesTemplate);
        if (template == null)
        {
            EraLog.Error(EraLogCategory.Data, $"缺少单位母版，无法注册：{actorId} -> {EraWorldboxAssetIds.MobNoGenesTemplate}");
            return false;
        }

        AssetManager.actor_library.clone(out ActorAsset cloned, template);
        if (!TryPrepareActorSprites(actorId, actorKindLabel, walkFrames, out string mainTexturePath, out string failureReason))
        {
            EraLog.Error(EraLogCategory.Data, $"单位模板注册已降级：{actorKindLabel} {actorId} 资源未准备完成，原因：{failureReason}");
            return false;
        }

        ConfigureActor(cloned, actorId, iconPath, mainTexturePath, wildKingdomId, canBeFavorited);
        if (!WorldboxReflectionAdapter.TryPrepareActorTextures(cloned) || cloned.texture_asset == null)
        {
            EraLog.Error(
                EraLogCategory.Data,
                $"单位模板注册已降级：{actorKindLabel} {actorId} 贴图资源未准备完成，已跳过注册以避免原版预加载阶段空引用。"
            );
            return false;
        }

        if (!HasUsableMainTexture(cloned))
        {
            EraLog.Error(
                EraLogCategory.Data,
                $"单位模板注册已降级：{actorKindLabel} {actorId} 主贴图列表为空，路径={cloned.texture_asset?.texture_path_main ?? "<empty>"}。"
            );
            return false;
        }

        ActorAsset registered = AssetManager.actor_library.add(cloned);
        RegisterLocale(registered, displayName, description);
        return true;
    }

    private static void ConfigureActor(
        ActorAsset asset,
        string actorId,
        string iconPath,
        string mainTexturePath,
        string wildKingdomId,
        bool canBeFavorited
    )
    {
        asset.id = actorId;
        asset.name_locale = actorId;
        asset.civ = false;
        asset.auto_civ = false;
        asset.kingdom_id_civilization = string.Empty;
        asset.architecture_id = string.Empty;
        asset.build_order_template_id = string.Empty;
        asset.kingdom_id_wild = wildKingdomId;
        asset.icon = iconPath;
        asset.texture_id = actorId;
        asset.animation_walk = ActorAnimationSequences.walk_0_3;
        asset.animation_swim = null;
        asset.has_baby_form = false;
        asset.has_advanced_textures = false;
        asset.shadow = false;
        asset.show_on_meta_layer = true;
        asset.can_be_inspected = true;
        asset.inspect_stats = true;
        asset.inspect_show_species = true;
        asset.can_edit_equipment = true;
        asset.can_edit_traits = true;
        asset.use_items = true;
        asset.can_receive_traits = true;
        asset.can_be_favorited = canBeFavorited;
        asset.hide_favorite_icon = !canBeFavorited;
        asset.allowed_status_tiers = StatusTier.Advanced;
        asset.status_tiers = StatusTier.Advanced;
        asset.special = true;
        asset.unit_other = true;
        asset.visible_on_minimap = true;

        ActorTextureSubAsset textureAsset = new ActorTextureSubAsset($"{ActorTextureRoot}/{actorId}/", pHasAdvancedTextures: false)
        {
            texture_path_main = mainTexturePath,
            texture_heads = string.Empty,
            texture_path_baby = string.Empty,
            shadow = false,
        };
        asset.texture_asset = textureAsset;
    }

    private static void RegisterLocale(ActorAsset asset, string displayName, string description)
    {
        EraLocaleRegistrar.AddZhEn(asset.getLocaleID(), displayName, displayName);

        string descriptionId = asset.getDescriptionID();
        if (!string.IsNullOrWhiteSpace(descriptionId))
        {
            EraLocaleRegistrar.AddZhEn(descriptionId, description, description);
        }
    }

    private static string ResolveDemonIconPath(EraDemonManifest manifest, EraSpriteCatalog spriteCatalog)
    {
        if (spriteCatalog.DemonsById.TryGetValue(manifest.InternalId, out EraDemonSpriteSet? set) &&
            set.UnitIcon != null &&
            !string.IsNullOrWhiteSpace(set.UnitIcon.RuntimePathId))
        {
            return set.UnitIcon.RuntimePathId;
        }

        return manifest.UnitIconSourcePath;
    }

    private static IReadOnlyList<EraSpriteResource> ResolveDemonWalkFrames(EraDemonManifest manifest, EraSpriteCatalog spriteCatalog)
    {
        if (spriteCatalog.DemonsById.TryGetValue(manifest.InternalId, out EraDemonSpriteSet? set))
        {
            return set.UnitWalkFrames;
        }

        return Array.Empty<EraSpriteResource>();
    }

    private static string ResolveGeneralIconPath(EraGeneralManifest manifest, EraSpriteCatalog spriteCatalog)
    {
        if (spriteCatalog.GeneralUnitGroupKeysById.TryGetValue(manifest.InternalId, out string? groupKey) &&
            spriteCatalog.UnitGroupsByKey.TryGetValue(groupKey, out EraUnitSpriteSet? set) &&
            set.Icon != null &&
            !string.IsNullOrWhiteSpace(set.Icon.RuntimePathId))
        {
            return set.Icon.RuntimePathId;
        }

        return manifest.IconSourcePath;
    }

    private static IReadOnlyList<EraSpriteResource> ResolveGeneralWalkFrames(EraGeneralManifest manifest, EraSpriteCatalog spriteCatalog)
    {
        if (spriteCatalog.GeneralUnitGroupKeysById.TryGetValue(manifest.InternalId, out string? groupKey) &&
            spriteCatalog.UnitGroupsByKey.TryGetValue(groupKey, out EraUnitSpriteSet? set))
        {
            return set.WalkFrames;
        }

        return Array.Empty<EraSpriteResource>();
    }

    private static string ResolveLegionIconPath(EraLegionManifest manifest, EraSpriteCatalog spriteCatalog)
    {
        if (spriteCatalog.LegionUnitGroupKeysById.TryGetValue(manifest.InternalId, out string? groupKey) &&
            spriteCatalog.UnitGroupsByKey.TryGetValue(groupKey, out EraUnitSpriteSet? set) &&
            set.Icon != null &&
            !string.IsNullOrWhiteSpace(set.Icon.RuntimePathId))
        {
            return set.Icon.RuntimePathId;
        }

        return manifest.IconSourcePath;
    }

    private static IReadOnlyList<EraSpriteResource> ResolveLegionWalkFrames(EraLegionManifest manifest, EraSpriteCatalog spriteCatalog)
    {
        if (spriteCatalog.LegionUnitGroupKeysById.TryGetValue(manifest.InternalId, out string? groupKey) &&
            spriteCatalog.UnitGroupsByKey.TryGetValue(groupKey, out EraUnitSpriteSet? set))
        {
            return set.WalkFrames;
        }

        return Array.Empty<EraSpriteResource>();
    }

    private static bool TryPrepareActorSprites(
        string actorId,
        string actorKindLabel,
        IReadOnlyList<EraSpriteResource> walkFrames,
        out string mainTexturePath,
        out string failureReason
    )
    {
        mainTexturePath = BuildMainTexturePath(actorId);
        failureReason = string.Empty;

        if (walkFrames == null || walkFrames.Count == 0)
        {
            failureReason = "缺少 walk_* 主贴图。";
            return false;
        }

        List<(int Order, byte[] Bytes)> frameBytes = new List<(int Order, byte[] Bytes)>();
        foreach (EraSpriteResource frame in walkFrames)
        {
            if (frame == null || string.IsNullOrWhiteSpace(frame.SourcePath))
            {
                continue;
            }

            int? order = EraSpriteHotReloadService.TryParseFrameOrder(Path.GetFileNameWithoutExtension(frame.SourcePath));
            if (!order.HasValue)
            {
                continue;
            }

            string absolutePath = EraPathResolver.ResolveModPath(_modRootPath, frame.SourcePath);
            if (!File.Exists(absolutePath))
            {
                continue;
            }

            try
            {
                frameBytes.Add((order.Value, File.ReadAllBytes(absolutePath)));
            }
            catch (Exception exception)
            {
                EraLog.Exception(EraLogCategory.Data, $"读取单位主贴图失败：{actorKindLabel} {actorId} -> {frame.SourcePath}", exception);
            }
        }

        if (frameBytes.Count == 0)
        {
            failureReason = "主贴图文件存在索引，但无法读取任何 walk_* 图片。";
            return false;
        }

        if (!frameBytes.Any(item => item.Order == 0))
        {
            failureReason = "缺少 walk_0 主贴图，原版动画预加载无法确认起始行走帧。";
            return false;
        }

        List<(int Order, byte[] Bytes)> orderedFrames = frameBytes
            .OrderBy(item => item.Order)
            .ToList();

        if (!EraSpriteHotReloadService.UpsertSpriteList(mainTexturePath, orderedFrames))
        {
            failureReason = $"无法桥接原版主贴图列表缓存：{mainTexturePath}";
            return false;
        }

        Sprite[]? spriteList = SpriteTextureLoader.getSpriteList(mainTexturePath, pSkipIfEmpty: true);
        if (spriteList == null || spriteList.Length == 0)
        {
            EraSpriteHotReloadService.ClearSpriteListCache(mainTexturePath);
            failureReason = $"桥接后主贴图列表仍为空：{mainTexturePath}";
            return false;
        }

        return true;
    }

    private static bool HasUsableMainTexture(ActorAsset asset)
    {
        if (asset?.texture_asset == null || string.IsNullOrWhiteSpace(asset.texture_asset.texture_path_main))
        {
            return false;
        }

        Sprite[]? sprites = SpriteTextureLoader.getSpriteList(asset.texture_asset.texture_path_main, pSkipIfEmpty: true);
        return sprites != null && sprites.Length > 0;
    }

    private static string BuildMainTexturePath(string actorId)
    {
        return $"{ActorTextureRoot}/{actorId}/main";
    }

    private static string BuildDemonDescription(EraDemonManifest manifest)
    {
        return $"核心机制：{manifest.CoreMechanic}\n主要打法：{manifest.CombatKeywords}\n基础母版：{EraWorldboxAssetIds.MobNoGenesTemplate}";
    }
}
