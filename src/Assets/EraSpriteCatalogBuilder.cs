using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using EraWheel.Core;
using EraWheel.Core.Constants;
using EraWheel.Data.Definitions;

namespace EraWheel.Assets;

public static class EraSpriteCatalogBuilder
{
    private const string DesignResourceRoot = "Assets/Art";
    private const string PublicTraitSkillRoot = "Assets/Art/公共特质技能图片";
    private const string HeritageTraitSkillRoot = "Assets/Art/轮回阶位特质技能图片";
    private const string HeritageEquipmentSkillRoot = "Assets/Art/轮回阶位装备技能图片";
    private const string DemonSkillRoot = "Assets/Art/魔王技能图片";
    private const string UnitSpriteRoot = "Assets/Art/注册生物单位图片";
    private const string EntryButtonRoot = "Assets/Art/入口页按钮图标";
    private const string HudUiRoot = "Assets/Art/UI/HUD";

    private static readonly Regex WalkFrameRegex = new Regex(@"^walk_(\d+)$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

    public static EraSpriteCatalog Build(string modRootPath, EraContentCatalog contentCatalog)
    {
        EraSpriteLoader loader = new EraSpriteLoader(modRootPath);
        Dictionary<EraModuleId, EraSpriteResource> entryButtons = BuildEntryButtonIndex(loader);
        Dictionary<string, EraIndexedSpriteSet> publicTraits = BuildPublicTraitIndex(modRootPath, contentCatalog, loader);
        Dictionary<string, EraIndexedSpriteSet> heritageTraits = BuildHeritageTraitIndex(modRootPath, contentCatalog, loader);
        Dictionary<string, EraIndexedSpriteSet> heritageEquipment = BuildHeritageEquipmentIndex(modRootPath, contentCatalog, loader);
        Dictionary<string, EraDemonSpriteSet> demons = BuildDemonIndex(modRootPath, contentCatalog, loader);
        Dictionary<string, EraUnitSpriteSet> unitGroups = BuildUnitGroupIndex(modRootPath, loader);

        return new EraSpriteCatalog(
            loader.TryLoad(CreateRuntimePathId("mod/icon", "icon.png"), "icon.png"),
            loader.TryLoad(CreateRuntimePathId("tab/icon", $"{DesignResourceRoot}/mod图标/世纪轮回.png"), $"{DesignResourceRoot}/mod图标/世纪轮回.png"),
            loader.TryLoad(CreateRuntimePathId("hud/branch9_crest", $"{HudUiRoot}/ew_hud_branch9_crest.png"), $"{HudUiRoot}/ew_hud_branch9_crest.png"),
            entryButtons,
            publicTraits,
            heritageTraits,
            heritageEquipment,
            demons,
            unitGroups,
            BuildDemonUnitGroupKeys(contentCatalog),
            BuildGeneralUnitGroupKeys(contentCatalog),
            BuildLegionUnitGroupKeys(contentCatalog)
        );
    }

    private static Dictionary<EraModuleId, EraSpriteResource> BuildEntryButtonIndex(EraSpriteLoader loader)
    {
        Dictionary<EraModuleId, EraSpriteResource> result = new Dictionary<EraModuleId, EraSpriteResource>();
        foreach ((EraModuleId moduleId, string fileName) in new[]
                 {
                     (EraModuleId.Guide, "guide"),
                     (EraModuleId.Reincarnation, "reincarnation"),
                     (EraModuleId.Demons, "demons"),
                     (EraModuleId.Generals, "generals"),
                     (EraModuleId.Legions, "legions"),
                     (EraModuleId.Advancement, "advancement"),
                     (EraModuleId.Levels, "levels"),
                     (EraModuleId.Kingdoms, "kingdoms"),
                     (EraModuleId.Heroes, "heroes"),
                     (EraModuleId.StoryGenerator, "story_generator")
                 })
        {
            string sourcePath = $"{EntryButtonRoot}/{fileName}.png";
            string runtimePathId = CreateRuntimePathId($"entry_buttons/{fileName}", sourcePath);
            EraSpriteResource resource = loader.TryLoad(runtimePathId, sourcePath)
                                       ?? new EraSpriteResource(runtimePathId, sourcePath, null);
            result[moduleId] = resource;
        }

        return result;
    }

    private static Dictionary<string, EraIndexedSpriteSet> BuildPublicTraitIndex(
        string modRootPath,
        EraContentCatalog contentCatalog,
        EraSpriteLoader loader
    )
    {
        Dictionary<string, EraIndexedSpriteSet> result = new Dictionary<string, EraIndexedSpriteSet>();
        foreach (EraPublicTraitManifest trait in contentCatalog.PublicTraits)
        {
            EraSpriteResource? icon = loader.TryLoad(CreateRuntimePathId($"public_traits/{trait.TraitId}/icon", trait.IconSourcePath), trait.IconSourcePath);
            IReadOnlyList<EraSpriteResource> details = LoadDetailSprites(
                modRootPath,
                loader,
                $"public_traits/{trait.TraitId}/details",
                PublicTraitSkillRoot,
                trait.DisplayName
            );
            result[trait.TraitId] = new EraIndexedSpriteSet(trait.TraitId, trait.DisplayName, icon, details);
        }

        return result;
    }

    private static Dictionary<string, EraIndexedSpriteSet> BuildHeritageTraitIndex(
        string modRootPath,
        EraContentCatalog contentCatalog,
        EraSpriteLoader loader
    )
    {
        Dictionary<string, EraIndexedSpriteSet> result = new Dictionary<string, EraIndexedSpriteSet>();
        foreach (EraHeritageTraitManifest trait in contentCatalog.HeritageTraits)
        {
            EraSpriteResource? icon = loader.TryLoad(CreateRuntimePathId($"heritage_traits/{trait.TraitId}/icon", trait.IconSourcePath), trait.IconSourcePath);
            IReadOnlyList<EraSpriteResource> details = LoadDetailSprites(
                modRootPath,
                loader,
                $"heritage_traits/{trait.TraitId}/details",
                HeritageTraitSkillRoot,
                trait.DisplayName
            );
            result[trait.TraitId] = new EraIndexedSpriteSet(trait.TraitId, trait.DisplayName, icon, details);
        }

        return result;
    }

    private static Dictionary<string, EraIndexedSpriteSet> BuildHeritageEquipmentIndex(
        string modRootPath,
        EraContentCatalog contentCatalog,
        EraSpriteLoader loader
    )
    {
        Dictionary<string, EraIndexedSpriteSet> result = new Dictionary<string, EraIndexedSpriteSet>();
        foreach (EraHeritageEquipmentManifest equipment in contentCatalog.HeritageEquipment)
        {
            EraSpriteResource? icon = loader.TryLoad(CreateRuntimePathId($"heritage_equipment/{equipment.EquipmentId}/icon", equipment.IconSourcePath), equipment.IconSourcePath);
            IReadOnlyList<EraSpriteResource> details = LoadDetailSprites(
                modRootPath,
                loader,
                $"heritage_equipment/{equipment.EquipmentId}/details",
                HeritageEquipmentSkillRoot,
                equipment.DisplayName
            );
            result[equipment.EquipmentId] = new EraIndexedSpriteSet(equipment.EquipmentId, equipment.DisplayName, icon, details);
        }

        return result;
    }

    private static Dictionary<string, EraDemonSpriteSet> BuildDemonIndex(
        string modRootPath,
        EraContentCatalog contentCatalog,
        EraSpriteLoader loader
    )
    {
        Dictionary<string, EraDemonSpriteSet> result = new Dictionary<string, EraDemonSpriteSet>();
        foreach (EraDemonManifest demon in contentCatalog.Demons)
        {
            EraSpriteResource? unitIcon = loader.TryLoad(CreateRuntimePathId($"demons/{demon.InternalId}/icon", demon.UnitIconSourcePath), demon.UnitIconSourcePath);
            IReadOnlyList<EraSpriteResource> unitWalkFrames = LoadDemonUnitWalkFrames(modRootPath, loader, demon);
            EraSpriteResource? stronghold = loader.TryLoad(CreateRuntimePathId($"demons/{demon.InternalId}/stronghold", demon.StrongholdIconSourcePath), demon.StrongholdIconSourcePath);
            IReadOnlyDictionary<string, IReadOnlyList<EraSpriteResource>> skillGroups = BuildDemonSkillGroups(
                modRootPath,
                loader,
                demon.InternalId,
                demon.DisplayName
            );
            result[demon.InternalId] = new EraDemonSpriteSet(
                demon.InternalId,
                demon.DisplayName,
                unitIcon,
                unitWalkFrames,
                stronghold,
                skillGroups
            );
        }

        return result;
    }

    private static IReadOnlyDictionary<string, IReadOnlyList<EraSpriteResource>> BuildDemonSkillGroups(
        string modRootPath,
        EraSpriteLoader loader,
        string demonId,
        string demonDisplayName
    )
    {
        string baseDirectory = GetAbsolutePath(modRootPath, $"{DemonSkillRoot}/{demonDisplayName}");
        if (!Directory.Exists(baseDirectory))
        {
            return new ReadOnlyDictionary<string, IReadOnlyList<EraSpriteResource>>(new Dictionary<string, IReadOnlyList<EraSpriteResource>>());
        }

        Dictionary<string, IReadOnlyList<EraSpriteResource>> groups = new Dictionary<string, IReadOnlyList<EraSpriteResource>>();
        foreach (string directory in Directory.EnumerateDirectories(baseDirectory).OrderBy(path => path, StringComparer.OrdinalIgnoreCase))
        {
            string groupName = Path.GetFileName(directory);
            List<EraSpriteResource> sprites = Directory
                .EnumerateFiles(directory)
                .OrderBy(path => path, StringComparer.OrdinalIgnoreCase)
                .Select((path, index) => loader.TryLoad(
                    CreateRuntimePathId($"demons/{demonId}/skills/{groupName}/{index}", ToModRelativePath(modRootPath, path)),
                    ToModRelativePath(modRootPath, path)
                ))
                .Where(resource => resource != null)
                .Cast<EraSpriteResource>()
                .ToList();

            groups[groupName] = sprites;
        }

        return new ReadOnlyDictionary<string, IReadOnlyList<EraSpriteResource>>(groups);
    }

    private static IReadOnlyList<EraSpriteResource> LoadDemonUnitWalkFrames(
        string modRootPath,
        EraSpriteLoader loader,
        EraDemonManifest demon
    )
    {
        string groupKey = NormalizePath($"魔王与将领图片/{demon.DisplayName}");
        string absoluteDirectory = GetAbsolutePath(modRootPath, $"{UnitSpriteRoot}/{groupKey}");
        if (!Directory.Exists(absoluteDirectory))
        {
            return Array.Empty<EraSpriteResource>();
        }

        List<(int Order, EraSpriteResource Resource)> walkFrames = new List<(int Order, EraSpriteResource Resource)>();
        foreach (string file in Directory.EnumerateFiles(absoluteDirectory).OrderBy(path => path, StringComparer.OrdinalIgnoreCase))
        {
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
            Match match = WalkFrameRegex.Match(fileNameWithoutExtension);
            if (!match.Success || !int.TryParse(match.Groups[1].Value, out int order))
            {
                continue;
            }

            string relativePath = ToModRelativePath(modRootPath, file);
            EraSpriteResource? resource = loader.TryLoad(
                CreateRuntimePathId($"demons/{demon.InternalId}/unit_walk/{fileNameWithoutExtension}", relativePath),
                relativePath
            );
            if (resource == null)
            {
                continue;
            }

            walkFrames.Add((order, resource));
        }

        return walkFrames.OrderBy(item => item.Order).Select(item => item.Resource).ToList();
    }

    private static Dictionary<string, EraUnitSpriteSet> BuildUnitGroupIndex(string modRootPath, EraSpriteLoader loader)
    {
        string unitRoot = GetAbsolutePath(modRootPath, UnitSpriteRoot);
        Dictionary<string, EraUnitSpriteSet> result = new Dictionary<string, EraUnitSpriteSet>();
        if (!Directory.Exists(unitRoot))
        {
            return result;
        }

        foreach (IGrouping<string, string> group in Directory
                     .EnumerateFiles(unitRoot, "*", SearchOption.AllDirectories)
                     .GroupBy(path => NormalizePath(Path.GetRelativePath(unitRoot, Path.GetDirectoryName(path) ?? unitRoot))))
        {
            string groupKey = group.Key;
            List<string> files = group.OrderBy(path => path, StringComparer.OrdinalIgnoreCase).ToList();
            EraSpriteResource? icon = null;
            List<(int Order, EraSpriteResource Resource)> walkFrames = new List<(int Order, EraSpriteResource Resource)>();
            List<EraSpriteResource> extras = new List<EraSpriteResource>();

            foreach (string file in files)
            {
                string relativePath = ToModRelativePath(modRootPath, file);
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
                EraSpriteResource? resource = loader.TryLoad(
                    CreateRuntimePathId($"units/{groupKey}/{fileNameWithoutExtension}", relativePath),
                    relativePath
                );
                if (resource == null)
                {
                    continue;
                }

                if (fileNameWithoutExtension.Equals("icon", StringComparison.OrdinalIgnoreCase))
                {
                    icon = resource;
                    continue;
                }

                Match match = WalkFrameRegex.Match(fileNameWithoutExtension);
                if (match.Success && int.TryParse(match.Groups[1].Value, out int order))
                {
                    walkFrames.Add((order, resource));
                    continue;
                }

                extras.Add(resource);
            }

            result[groupKey] = new EraUnitSpriteSet(
                groupKey,
                Path.GetFileName(groupKey),
                icon,
                walkFrames.OrderBy(item => item.Order).Select(item => item.Resource).ToList(),
                extras
            );
        }

        return result;
    }

    private static Dictionary<string, string> BuildDemonUnitGroupKeys(EraContentCatalog contentCatalog)
    {
        Dictionary<string, string> result = new Dictionary<string, string>();
        foreach (EraDemonManifest demon in contentCatalog.Demons)
        {
            result[demon.InternalId] = NormalizePath($"魔王与将领图片/{demon.DisplayName}");
        }

        return result;
    }

    private static Dictionary<string, string> BuildGeneralUnitGroupKeys(EraContentCatalog contentCatalog)
    {
        Dictionary<string, string> result = new Dictionary<string, string>();
        foreach (EraGeneralManifest general in contentCatalog.Generals)
        {
            if (!contentCatalog.DemonsById.TryGetValue(general.DemonInternalId, out EraDemonManifest? demon))
            {
                continue;
            }

            result[general.InternalId] = NormalizePath($"魔王与将领图片/{demon.DisplayName}/将领/{general.DisplayName}");
        }

        return result;
    }

    private static Dictionary<string, string> BuildLegionUnitGroupKeys(EraContentCatalog contentCatalog)
    {
        Dictionary<string, string> result = new Dictionary<string, string>();
        foreach (EraLegionManifest legion in contentCatalog.Legions)
        {
            result[legion.InternalId] = NormalizePath(legion.UnitGroupKey);
        }

        return result;
    }

    private static IReadOnlyList<EraSpriteResource> LoadDetailSprites(
        string modRootPath,
        EraSpriteLoader loader,
        string scope,
        string baseFolderRelativePath,
        string displayName
    )
    {
        List<EraSpriteResource> result = new List<EraSpriteResource>();
        foreach (string path in FindDetailSpritePaths(modRootPath, baseFolderRelativePath, displayName))
        {
            EraSpriteResource? resource = loader.TryLoad(CreateRuntimePathId(scope, path), path);
            if (resource != null)
            {
                result.Add(resource);
            }
        }

        return result;
    }

    private static IEnumerable<string> FindDetailSpritePaths(
        string modRootPath,
        string baseFolderRelativePath,
        string displayName
    )
    {
        string baseDirectory = GetAbsolutePath(modRootPath, baseFolderRelativePath);
        if (!Directory.Exists(baseDirectory))
        {
            return Array.Empty<string>();
        }

        List<string> result = new List<string>();
        string displayDirectory = Path.Combine(baseDirectory, displayName);
        if (Directory.Exists(displayDirectory))
        {
            result.AddRange(Directory.EnumerateFiles(displayDirectory, "*", SearchOption.AllDirectories));
        }
        else
        {
            foreach (string file in Directory.EnumerateFiles(baseDirectory))
            {
                if (Path.GetFileNameWithoutExtension(file).Equals(displayName, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(file);
                }
            }
        }

        return result
            .OrderBy(path => path, StringComparer.OrdinalIgnoreCase)
            .Select(path => ToModRelativePath(modRootPath, path))
            .ToList();
    }

    private static string CreateRuntimePathId(string scope, string sourcePath)
    {
        string normalizedSourcePath = NormalizePath(sourcePath);
        using MD5 md5 = MD5.Create();
        byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(normalizedSourcePath));
        StringBuilder builder = new StringBuilder(hash.Length * 2);
        foreach (byte value in hash)
        {
            builder.Append(value.ToString("x2"));
        }

        return $"ew/{NormalizePath(scope).Trim('/')}/{builder}";
    }

    private static string GetAbsolutePath(string modRootPath, string relativePath)
    {
        return EraPathResolver.ResolveModPath(modRootPath, relativePath);
    }

    private static string ToModRelativePath(string modRootPath, string absolutePath)
    {
        return EraPathResolver.ToModRelativePath(modRootPath, absolutePath);
    }

    private static string NormalizePath(string path)
    {
        return path.Replace('\\', '/');
    }
}
