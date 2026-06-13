using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EraWheel.Core.Logging;
using UnityEngine;

namespace EraWheel.Reflection;

public static class WorldboxReflectionAdapter
{
    private const BindingFlags AnyInstance = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

    private static bool _initialized;
    private static MethodInfo? _addBuildingMethod;
    private static FieldInfo? _mapStatsField;
    private static PropertyInfo? _moveCameraProperty;
    private static MethodInfo? _focusOnMethod;
    private static MethodInfo? _startDestroyBuildingMethod;
    private static MethodInfo? _newWildKingdomMethod;
    private static MethodInfo? _loadActorTexturesMethod;
    private static MethodInfo? _loadActorShadowMethod;
    private static MethodInfo? _addStatusEffectMethod;
    private static MethodInfo? _setCurrentTileMethod;
    private static MethodInfo? _setCurrentTilePositionMethod;
    private static MethodInfo? _startFireMethod;
    private static FieldInfo? _kingdomAssetEnemyCacheField;
    private static FieldInfo? _actorAggressionTargetsField;
    private static FieldInfo? _actorAttackTargetField;
    private static FieldInfo? _actorDataField;
    private static PropertyInfo? _actorDataManaProperty;

    private static string _addBuildingSignature = "未确认";
    private static string _mapStatsSignature = "未确认";
    private static string _focusOnSignature = "未确认";
    private static string _startDestroyBuildingSignature = "未确认";
    private static string _newWildKingdomSignature = "未确认";
    private static string _loadActorTexturesSignature = "未确认";
    private static string _loadActorShadowSignature = "未确认";
    private static string _addStatusEffectSignature = "未确认";
    private static string _teleportSignature = "未确认";
    private static string _startFireSignature = "未确认";
    private static string _actorManaSignature = "未确认";

    public static bool CanAddBuilding => _addBuildingMethod != null;
    public static bool CanReadMapStats => _mapStatsField != null;
    public static bool CanFocusCamera => _moveCameraProperty != null && _focusOnMethod != null;
    public static bool CanStartDestroyBuildings => _startDestroyBuildingMethod != null;
    public static bool CanCreateWildKingdoms => _newWildKingdomMethod != null;
    public static bool CanPrepareActorTextures => _loadActorTexturesMethod != null;
    public static bool CanAddStatusEffects => _addStatusEffectMethod != null;
    public static bool CanTeleportActors => _setCurrentTileMethod != null;
    public static bool CanStartTileFire => _startFireMethod != null;
    public static bool CanAccessActorMana => _actorDataField != null && _actorDataManaProperty != null;

    public static void Initialize()
    {
        if (_initialized)
        {
            return;
        }

        _initialized = true;

        _addBuildingMethod = typeof(BuildingManager)
            .GetMethods(AnyInstance)
            .FirstOrDefault(
                method =>
                {
                    ParameterInfo[] parameters = method.GetParameters();
                    return method.Name == "addBuilding"
                        && parameters.Length == 5
                        && parameters[0].ParameterType == typeof(string)
                        && parameters[1].ParameterType == typeof(WorldTile);
                }
            );

        _mapStatsField = typeof(MapBox).GetField("map_stats", AnyInstance);
        _moveCameraProperty = typeof(MapBox).GetProperty("move_camera", AnyInstance);
        _focusOnMethod = typeof(MoveCamera)
            .GetMethods(AnyInstance)
            .FirstOrDefault(
                method =>
                {
                    ParameterInfo[] parameters = method.GetParameters();
                    return method.Name == "focusOn"
                        && parameters.Length == 1
                        && parameters[0].ParameterType == typeof(Vector3);
                }
            );
        _startDestroyBuildingMethod = typeof(Building)
            .GetMethods(AnyInstance)
            .FirstOrDefault(
                method => method.Name == "startDestroyBuilding" && method.GetParameters().Length == 0
            );
        _newWildKingdomMethod = typeof(WildKingdomsManager)
            .GetMethods(AnyInstance)
            .FirstOrDefault(
                method =>
                {
                    ParameterInfo[] parameters = method.GetParameters();
                    return method.Name == "newWildKingdom"
                        && parameters.Length == 1
                        && parameters[0].ParameterType == typeof(KingdomAsset);
                }
            );
        _loadActorTexturesMethod = typeof(ActorAssetLibrary)
            .GetMethods(AnyInstance)
            .FirstOrDefault(
                method =>
                {
                    ParameterInfo[] parameters = method.GetParameters();
                    return method.Name == "loadTexturesAndSprites"
                        && parameters.Length == 1
                        && parameters[0].ParameterType == typeof(ActorAsset);
                }
            );
        _loadActorShadowMethod = typeof(ActorTextureSubAsset)
            .GetMethods(AnyInstance)
            .FirstOrDefault(method => method.Name == "loadShadow" && method.GetParameters().Length == 0);
        _addStatusEffectMethod = typeof(BaseSimObject)
            .GetMethods(AnyInstance)
            .FirstOrDefault(
                method =>
                {
                    ParameterInfo[] parameters = method.GetParameters();
                    return method.Name == "addStatusEffect"
                        && parameters.Length == 3
                        && parameters[0].ParameterType == typeof(string);
                }
            );
        _setCurrentTileMethod = typeof(Actor).GetMethod("setCurrentTile", AnyInstance);
        _setCurrentTilePositionMethod = typeof(Actor).GetMethod("setCurrentTilePosition", AnyInstance);
        _startFireMethod = typeof(WorldTile).GetMethod("startFire", AnyInstance);
        _kingdomAssetEnemyCacheField = typeof(KingdomAsset).GetField("_cached_enemies", AnyInstance);
        _actorAggressionTargetsField = typeof(Actor).GetField("_aggression_targets", AnyInstance);
        _actorAttackTargetField = typeof(Actor).GetField("attack_target", AnyInstance);
        _actorDataField = typeof(Actor).GetField("data", AnyInstance);
        _actorDataManaProperty = typeof(ActorData).GetProperty("mana", AnyInstance);

        _addBuildingSignature = _addBuildingMethod?.ToString() ?? "未找到";
        _mapStatsSignature = _mapStatsField?.ToString() ?? "未找到";
        _focusOnSignature = _focusOnMethod?.ToString() ?? "未找到";
        _startDestroyBuildingSignature = _startDestroyBuildingMethod?.ToString() ?? "未找到";
        _newWildKingdomSignature = _newWildKingdomMethod?.ToString() ?? "未找到";
        _loadActorTexturesSignature = _loadActorTexturesMethod?.ToString() ?? "未找到";
        _loadActorShadowSignature = _loadActorShadowMethod?.ToString() ?? "未找到";
        _addStatusEffectSignature = _addStatusEffectMethod?.ToString() ?? "未找到";
        _teleportSignature = _setCurrentTileMethod?.ToString() ?? "未找到";
        _startFireSignature = _startFireMethod?.ToString() ?? "未找到";
        _actorManaSignature = _actorDataManaProperty?.ToString() ?? "未找到";
    }

    public static string CreateStatusReport()
    {
        Initialize();
        return string.Join(
            " | ",
            $"据点放置={(CanAddBuilding ? "已确认" : "缺失")}<{_addBuildingSignature}>",
            $"世界统计={(CanReadMapStats ? "已确认" : "缺失")}<{_mapStatsSignature}>",
            $"镜头聚焦={(CanFocusCamera ? "已确认" : "缺失")}<{_focusOnSignature}>",
            $"建筑销毁={(CanStartDestroyBuildings ? "已确认" : "缺失")}<{_startDestroyBuildingSignature}>",
            $"野怪王国补建={(CanCreateWildKingdoms ? "已确认" : "缺失")}<{_newWildKingdomSignature}>",
            $"单位贴图补建={(CanPrepareActorTextures ? "已确认" : "缺失")}<{_loadActorTexturesSignature}>",
            $"单位阴影补建={(_loadActorShadowMethod != null ? "已确认" : "缺失")}<{_loadActorShadowSignature}>",
            $"状态附加={(CanAddStatusEffects ? "已确认" : "缺失")}<{_addStatusEffectSignature}>",
            $"单位瞬移={(CanTeleportActors ? "已确认" : "缺失")}<{_teleportSignature}>",
            $"地块点火={(CanStartTileFire ? "已确认" : "缺失")}<{_startFireSignature}>",
            $"法力读写={(CanAccessActorMana ? "已确认" : "缺失")}<{_actorManaSignature}>"
        );
    }

    public static void LogReport()
    {
        EraLog.Info(EraLogCategory.Reflection, CreateStatusReport());
    }

    public static bool TryReadMapStats(out MapStats? mapStats)
    {
        Initialize();
        mapStats = null;

        MapBox? world = World.world;
        if (world == null || _mapStatsField == null)
        {
            return false;
        }

        mapStats = _mapStatsField.GetValue(world) as MapStats;
        return mapStats != null;
    }

    public static bool TryFocusWorldCenter()
    {
        MapBox? world = World.world;
        if (world == null)
        {
            return false;
        }

        WorldTile? centerTile = world.GetTile(MapBox.width / 2, MapBox.height / 2);
        return centerTile != null && TryFocusOn(centerTile.posV3);
    }

    public static bool TryFocusOn(Vector3 position)
    {
        Initialize();

        try
        {
            MoveCamera? moveCamera = GetMoveCamera();
            if (moveCamera == null || _focusOnMethod == null)
            {
                return false;
            }

            _focusOnMethod.Invoke(moveCamera, new object[] { position });
            return true;
        }
        catch (Exception exception)
        {
            EraLog.Exception(EraLogCategory.Reflection, "调用 MoveCamera.focusOn 失败。", exception);
            return false;
        }
    }

    public static bool TryAddBuilding(string buildingId, WorldTile tile, out Building? building, bool checkForBuild = false, bool sfx = false)
    {
        Initialize();
        building = null;

        MapBox? world = World.world;
        if (world == null || _addBuildingMethod == null)
        {
            return false;
        }

        try
        {
            object buildPlacingType = ResolveBuildPlacingType(_addBuildingMethod);
            building = _addBuildingMethod.Invoke(
                world.buildings,
                new object?[] { buildingId, tile, checkForBuild, sfx, buildPlacingType }
            ) as Building;
            return building != null;
        }
        catch (Exception exception)
        {
            EraLog.Exception(EraLogCategory.Reflection, $"调用 BuildingManager.addBuilding 失败，buildingId={buildingId}。", exception);
            return false;
        }
    }

    public static bool TryGetBuilding(long id, out Building? building)
    {
        building = null;

        MapBox? world = World.world;
        if (world == null)
        {
            return false;
        }

        BuildingManager? manager = world.buildings;
        if (manager == null || manager.occupied_buildings == null)
        {
            return false;
        }

        foreach (Building candidate in manager.occupied_buildings)
        {
            if (candidate == null)
            {
                continue;
            }

            long candidateId = candidate.getID();
            if (candidateId == id)
            {
                building = candidate;
                return true;
            }
        }

        return false;
    }

    public static bool TryStartDestroyBuilding(long id)
    {
        return TryGetBuilding(id, out Building? building) && TryStartDestroyBuilding(building);
    }

    public static bool TryStartDestroyBuilding(Building? building)
    {
        Initialize();

        if (building == null || _startDestroyBuildingMethod == null)
        {
            return false;
        }

        try
        {
            _startDestroyBuildingMethod.Invoke(building, Array.Empty<object>());
            return true;
        }
        catch (Exception exception)
        {
            long buildingId;
            try
            {
                buildingId = building.getID();
            }
            catch
            {
                buildingId = -1;
            }

            EraLog.Exception(EraLogCategory.Reflection, $"调用 Building.startDestroyBuilding 失败，buildingId={buildingId}。", exception);
            return false;
        }
    }

    public static bool TryEnsureWildKingdom(string kingdomId)
    {
        Initialize();
        if (string.IsNullOrWhiteSpace(kingdomId) || World.world?.kingdoms_wild == null)
        {
            return false;
        }

        if (World.world.kingdoms_wild.get(kingdomId) != null)
        {
            return false;
        }

        if (_newWildKingdomMethod == null)
        {
            return false;
        }

        KingdomAsset? asset = AssetManager.kingdoms.get(kingdomId);
        if (asset == null)
        {
            return false;
        }

        try
        {
            Kingdom? kingdom = _newWildKingdomMethod.Invoke(World.world.kingdoms_wild, new object[] { asset }) as Kingdom;
            return kingdom != null;
        }
        catch (Exception exception)
        {
            EraLog.Exception(EraLogCategory.Reflection, $"补建野怪王国失败，kingdomId={kingdomId}。", exception);
            return false;
        }
    }

    public static bool TryPrepareActorTextures(ActorAsset asset)
    {
        Initialize();
        if (asset == null || AssetManager.actor_library == null || _loadActorTexturesMethod == null)
        {
            return false;
        }

        try
        {
            _loadActorTexturesMethod.Invoke(AssetManager.actor_library, new object[] { asset });
            if (asset.texture_asset == null)
            {
                EraLog.Error(
                    EraLogCategory.Reflection,
                    $"单位贴图补建失败：loadTexturesAndSprites 已调用，但 texture_asset 仍为空，actorId={asset.id ?? "<empty>"}。"
                );
                return false;
            }

            if (asset.shadow && _loadActorShadowMethod != null)
            {
                _loadActorShadowMethod.Invoke(asset.texture_asset, Array.Empty<object>());
            }

            return true;
        }
        catch (Exception exception)
        {
            EraLog.Exception(
                EraLogCategory.Reflection,
                $"单位贴图补建失败，actorId={asset.id ?? "<empty>"}。",
                exception
            );
            return false;
        }
    }

    public static bool TryAddStatusEffect(BaseSimObject simObject, string statusId, float overrideTimer, bool colorEffect = false)
    {
        Initialize();
        if (simObject == null || string.IsNullOrWhiteSpace(statusId) || _addStatusEffectMethod == null)
        {
            return false;
        }

        try
        {
            return _addStatusEffectMethod.Invoke(simObject, new object[] { statusId, overrideTimer, colorEffect }) is bool result && result;
        }
        catch (Exception exception)
        {
            EraLog.Exception(EraLogCategory.Reflection, $"附加状态失败，statusId={statusId}。", exception);
            return false;
        }
    }

    public static bool TryTeleportActor(Actor actor, WorldTile tile)
    {
        Initialize();
        if (actor == null || tile == null || _setCurrentTileMethod == null || !IsValidTeleportDestination(tile))
        {
            return false;
        }

        try
        {
            ActionLibrary.teleportEffect(actor, tile);
            actor.cancelAllBeh();
            _setCurrentTileMethod.Invoke(actor, new object[] { tile });
            _setCurrentTilePositionMethod?.Invoke(actor, new object[] { tile });
            actor.current_path?.Clear();
            actor.next_step_position = tile.pos;
            actor.current_position = tile.pos;
            return true;
        }
        catch (Exception exception)
        {
            EraLog.Exception(EraLogCategory.Reflection, $"单位瞬移失败，actor={actor.asset?.id ?? actor.getID().ToString()}。", exception);
            return false;
        }
    }

    public static bool IsValidTeleportDestination(WorldTile tile)
    {
        return tile?.Type != null && tile.Type.ground && !tile.Type.block;
    }

    public static bool TryStartTileFire(WorldTile tile, bool force = true)
    {
        Initialize();
        if (tile == null || _startFireMethod == null)
        {
            return false;
        }

        try
        {
            return _startFireMethod.Invoke(tile, new object[] { force }) is bool started && started;
        }
        catch (Exception exception)
        {
            EraLog.Exception(EraLogCategory.Reflection, $"地块点火失败，tile=({tile.x},{tile.y})。", exception);
            return false;
        }
    }

    public static bool TryGetActorMana(Actor actor, out int mana)
    {
        Initialize();
        mana = 0;
        if (actor == null || _actorDataField == null || _actorDataManaProperty == null)
        {
            return false;
        }

        if (_actorDataField.GetValue(actor) is not ActorData data)
        {
            return false;
        }

        mana = (int)(_actorDataManaProperty.GetValue(data) ?? 0);
        return true;
    }

    public static bool TrySetActorMana(Actor actor, int mana)
    {
        Initialize();
        if (actor == null || _actorDataField == null || _actorDataManaProperty == null)
        {
            return false;
        }

        if (_actorDataField.GetValue(actor) is not ActorData data)
        {
            return false;
        }

        _actorDataManaProperty.SetValue(data, Math.Max(0, mana));
        return true;
    }

    public static bool TryConsumeActorMana(Actor actor, int cost)
    {
        if (cost <= 0)
        {
            return true;
        }

        if (!TryGetActorMana(actor, out int mana) || mana < cost)
        {
            return false;
        }

        return TrySetActorMana(actor, mana - cost);
    }

    public static bool TryGetAttackTarget(Actor actor, out BaseSimObject? target)
    {
        Initialize();
        target = null;
        if (_actorAttackTargetField == null)
        {
            return false;
        }

        target = _actorAttackTargetField.GetValue(actor) as BaseSimObject;
        return target != null;
    }

    public static void ClearKingdomEnemyCaches(IEnumerable<KingdomAsset?> assets)
    {
        Initialize();
        Kingdom.cache_enemy_check.clear();
        if (_kingdomAssetEnemyCacheField == null)
        {
            return;
        }

        foreach (KingdomAsset? asset in assets)
        {
            if (asset == null)
            {
                continue;
            }

            if (_kingdomAssetEnemyCacheField.GetValue(asset) is Dictionary<int, int> cache)
            {
                cache.Clear();
            }
        }
    }

    public static bool TryClearActorAggro(Actor actor, IEnumerable<long> targetActorIds)
    {
        Initialize();
        if (_actorAggressionTargetsField == null)
        {
            return false;
        }

        if (_actorAggressionTargetsField.GetValue(actor) is not HashSet<long> aggroTargets)
        {
            return false;
        }

        bool changed = false;
        foreach (long actorId in targetActorIds)
        {
            changed |= aggroTargets.Remove(actorId);
        }

        return changed;
    }

    private static MoveCamera? GetMoveCamera()
    {
        MapBox? world = World.world;
        if (world == null || _moveCameraProperty == null)
        {
            return null;
        }

        return _moveCameraProperty.GetValue(world) as MoveCamera;
    }

    private static object ResolveBuildPlacingType(MethodInfo method)
    {
        ParameterInfo parameter = method.GetParameters().Last();
        if (parameter.DefaultValue != null && parameter.DefaultValue != DBNull.Value && parameter.DefaultValue != Type.Missing)
        {
            return parameter.DefaultValue;
        }

        if (parameter.ParameterType.IsEnum)
        {
            Array values = Enum.GetValues(parameter.ParameterType);
            if (values.Length > 0)
            {
                return values.GetValue(0)!;
            }
        }

        return Activator.CreateInstance(parameter.ParameterType)
            ?? throw new InvalidOperationException($"无法为参数 {parameter.Name} 创建默认值。");
    }
}
