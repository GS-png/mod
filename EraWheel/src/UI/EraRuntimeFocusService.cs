using System;
using System.Collections.Generic;
using System.Linq;
using EraWheel.Core;
using EraWheel.Core.Logging;
using EraWheel.Reflection;
using EraWheel.Save.Models;
using UnityEngine;

namespace EraWheel.UI;

public static class EraRuntimeFocusService
{
    private sealed class EraFocusCandidate
    {
        public string Label { get; set; } = string.Empty;
        public Vector3 Position { get; set; }
    }

    private static int _demonCursor;
    private static int _fortressCursor;
    private static int _heroCursor;
    private static int _battlefieldCursor;

    public static string LastStatusMessage { get; private set; } = "还没有执行过镜头聚焦。";

    public static string CreateStatusReport()
    {
        return WorldboxReflectionAdapter.CanFocusCamera
            ? $"镜头聚焦接口可用；最近结果：{LastStatusMessage}"
            : "镜头聚焦接口当前不可用。";
    }

    public static void FocusNextDemon()
    {
        FocusCandidates(CollectDemonCandidates(), ref _demonCursor, "魔王");
    }

    public static void FocusNextFortress()
    {
        FocusCandidates(CollectFortressCandidates(), ref _fortressCursor, "据点");
    }

    public static void FocusNextHero()
    {
        FocusCandidates(CollectHeroCandidates(), ref _heroCursor, "英雄");
    }

    public static void FocusNextBattlefield()
    {
        FocusCandidates(CollectBattlefieldCandidates(), ref _battlefieldCursor, "关键战场");
    }

    private static void FocusCandidates(IReadOnlyList<EraFocusCandidate> candidates, ref int cursor, string targetKind)
    {
        if (!WorldboxReflectionAdapter.CanFocusCamera)
        {
            LastStatusMessage = $"镜头聚焦失败：{targetKind} 定位接口不可用。";
            EraLog.Warning(EraLogCategory.Reflection, LastStatusMessage);
            return;
        }

        if (candidates.Count == 0)
        {
            LastStatusMessage = $"镜头聚焦失败：当前没有可定位的{targetKind}。";
            EraLog.Warning(EraLogCategory.Debug, LastStatusMessage);
            return;
        }

        if (cursor < 0 || cursor >= candidates.Count)
        {
            cursor = 0;
        }

        EraFocusCandidate candidate = candidates[cursor];
        cursor = (cursor + 1) % candidates.Count;
        if (WorldboxReflectionAdapter.TryFocusOn(candidate.Position))
        {
            LastStatusMessage = $"已聚焦到{targetKind}：{candidate.Label}。";
            EraLog.Info(EraLogCategory.Debug, LastStatusMessage);
            return;
        }

        LastStatusMessage = $"镜头聚焦失败：{targetKind} {candidate.Label}。";
        EraLog.Warning(EraLogCategory.Reflection, LastStatusMessage);
    }

    private static IReadOnlyList<EraFocusCandidate> CollectDemonCandidates()
    {
        if (EraRuntimeBootstrap.RuntimeSave == null)
        {
            return Array.Empty<EraFocusCandidate>();
        }

        List<EraFocusCandidate> candidates = new();
        foreach (EraDemonSpawnState spawn in EraRuntimeBootstrap.RuntimeSave.CurrentState.SpawnedDemons
                     .OrderBy(item => item.DemonId, StringComparer.Ordinal))
        {
            Actor? actor = ResolveActor(spawn.ActorId);
            if (actor?.current_tile == null || !actor.isAlive())
            {
                continue;
            }

            candidates.Add(
                new EraFocusCandidate
                {
                    Label = BuildActorLabel(actor, spawn.DemonId),
                    Position = actor.current_tile.posV3,
                });
        }

        return candidates;
    }

    private static IReadOnlyList<EraFocusCandidate> CollectFortressCandidates()
    {
        if (EraRuntimeBootstrap.RuntimeSave == null)
        {
            return Array.Empty<EraFocusCandidate>();
        }

        List<EraFocusCandidate> candidates = new();
        foreach (EraFortressBindingState fortress in EraRuntimeBootstrap.RuntimeSave.CurrentState.FortressBindings
                     .OrderBy(item => item.DemonId, StringComparer.Ordinal))
        {
            if (WorldboxReflectionAdapter.TryGetBuilding(fortress.BuildingId, out Building? building) &&
                building?.current_tile != null)
            {
                candidates.Add(
                    new EraFocusCandidate
                    {
                        Label = $"{fortress.DemonId} 据点",
                        Position = building.current_tile.posV3,
                    });
                continue;
            }

            WorldTile? tile = World.world?.GetTile(fortress.TileX, fortress.TileY);
            if (tile == null)
            {
                continue;
            }

            candidates.Add(
                new EraFocusCandidate
                {
                    Label = $"{fortress.DemonId} 据点",
                    Position = tile.posV3,
                });
        }

        return candidates;
    }

    private static IReadOnlyList<EraFocusCandidate> CollectHeroCandidates()
    {
        if (EraRuntimeBootstrap.RuntimeSave == null)
        {
            return Array.Empty<EraFocusCandidate>();
        }

        List<EraFocusCandidate> candidates = new();
        foreach (EraHeroArchiveState archive in EraRuntimeBootstrap.RuntimeSave.CurrentState.HeroArchives
                     .OrderBy(item => item.HeroName, StringComparer.Ordinal))
        {
            Actor? actor = ResolveActor(archive.HeroActorId);
            if (actor?.current_tile == null || !actor.isAlive())
            {
                continue;
            }

            candidates.Add(
                new EraFocusCandidate
                {
                    Label = BuildActorLabel(actor, archive.HeroName),
                    Position = actor.current_tile.posV3,
                });
        }

        return candidates;
    }

    private static IReadOnlyList<EraFocusCandidate> CollectBattlefieldCandidates()
    {
        if (World.world?.wars == null)
        {
            return Array.Empty<EraFocusCandidate>();
        }

        List<EraFocusCandidate> candidates = new();
        foreach (War war in World.world.wars.getActiveWars())
        {
            if (war == null)
            {
                continue;
            }

            Actor? attacker = war.main_attacker?.king;
            Actor? defender = war.main_defender?.king;
            if (attacker?.current_tile != null && defender?.current_tile != null)
            {
                Vector3 midpoint = (attacker.current_tile.posV3 + defender.current_tile.posV3) * 0.5f;
                candidates.Add(
                    new EraFocusCandidate
                    {
                        Label = $"{war.main_attacker?.name ?? "未知王国"} vs {war.main_defender?.name ?? "未知王国"}",
                        Position = midpoint,
                    });
                continue;
            }

            if (attacker?.current_tile != null)
            {
                candidates.Add(
                    new EraFocusCandidate
                    {
                        Label = $"{war.main_attacker?.name ?? "未知王国"} 战线",
                        Position = attacker.current_tile.posV3,
                    });
                continue;
            }

            if (defender?.current_tile != null)
            {
                candidates.Add(
                    new EraFocusCandidate
                    {
                        Label = $"{war.main_defender?.name ?? "未知王国"} 战线",
                        Position = defender.current_tile.posV3,
                    });
            }
        }

        if (candidates.Count == 0)
        {
            return CollectDemonCandidates();
        }

        return candidates;
    }

    private static Actor? ResolveActor(long actorId)
    {
        if (actorId <= 0 || World.world?.units == null)
        {
            return null;
        }

        return World.world.units.getSimpleList().FirstOrDefault(actor => actor != null && actor.getID() == actorId);
    }

    private static string BuildActorLabel(Actor actor, string fallback)
    {
        string name = actor.getName();
        if (!string.IsNullOrWhiteSpace(name))
        {
            return $"{name}(#{actor.getID()})";
        }

        return string.IsNullOrWhiteSpace(fallback) ? $"Actor#{actor.getID()}" : fallback;
    }
}
