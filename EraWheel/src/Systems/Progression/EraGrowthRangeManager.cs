using System;
using System.Collections.Generic;
using System.Linq;
using EraWheel.Config.Registry;
using EraWheel.Config.Schema;
using EraWheel.Save.Models;

namespace EraWheel.Systems.Progression;

public static class EraGrowthTrackIds
{
    public const string Demon = "demon";
    public const string General = "general";
    public const string Hero = "hero";
    public const string Legion = "legion";
}

public sealed class EraGrowthRangeManager
{
    private readonly EraParameterRegistry _parameterRegistry;
    private EraWorldRuntimeState _state;

    public EraGrowthRangeManager(EraParameterRegistry parameterRegistry, EraWorldRuntimeState state)
    {
        _parameterRegistry = parameterRegistry;
        _state = state;
        EnsureCycleFrozen();
    }

    public void Rebind(EraWorldRuntimeState state)
    {
        _state = state;
        EnsureCycleFrozen();
    }

    public void EnsureCycleFrozen()
    {
        EnsureTrack(EraGrowthTrackIds.Demon, _parameterRegistry.Current.Growth.DemonBaseRanges);
        EnsureTrack(EraGrowthTrackIds.General, _parameterRegistry.Current.Growth.GeneralBaseRanges);
        EnsureTrack(EraGrowthTrackIds.Hero, _parameterRegistry.Current.Growth.HeroPromotionRanges);
        EnsureTrack(EraGrowthTrackIds.Legion, _parameterRegistry.Current.Growth.LegionBaseRanges);

        foreach (EraGrowthTrackState track in _state.GrowthTracks)
        {
            if (track.FrozenCycleNumber == _state.CompletedCycles)
            {
                continue;
            }

            foreach (EraGrowthAttributeRangeState attribute in track.Attributes)
            {
                attribute.FrozenMin = attribute.ActiveMin;
                attribute.FrozenMax = attribute.ActiveMax;
                attribute.SampleTotal = 0f;
                attribute.SampleCount = 0;
            }

            track.FrozenCycleNumber = _state.CompletedCycles;
        }
    }

    public bool TryGetFrozenRange(string trackId, string attributeId, out EraFloatRange range)
    {
        EnsureCycleFrozen();
        range = new EraFloatRange();

        EraGrowthTrackState? track = _state.GrowthTracks.FirstOrDefault(item => item.TrackId == trackId);
        EraGrowthAttributeRangeState? attribute = track?.Attributes.FirstOrDefault(item => item.AttributeId == attributeId);
        if (attribute == null)
        {
            return false;
        }

        range.Min = attribute.FrozenMin;
        range.Max = attribute.FrozenMax;
        return true;
    }

    public bool RecordSample(string trackId, string attributeId, float value)
    {
        EnsureCycleFrozen();

        EraGrowthTrackState? track = _state.GrowthTracks.FirstOrDefault(item => item.TrackId == trackId);
        EraGrowthAttributeRangeState? attribute = track?.Attributes.FirstOrDefault(item => item.AttributeId == attributeId);
        if (attribute == null)
        {
            return false;
        }

        attribute.SampleTotal += value;
        attribute.SampleCount++;
        return true;
    }

    public string PrepareNextCycleRanges()
    {
        EnsureCycleFrozen();

        List<string> reports = new List<string>(_state.GrowthTracks.Count);
        foreach (EraGrowthTrackState track in _state.GrowthTracks)
        {
            int shifted = 0;
            int kept = 0;
            foreach (EraGrowthAttributeRangeState attribute in track.Attributes)
            {
                if (attribute.SampleCount > 0)
                {
                    float nextMin = attribute.SampleTotal / attribute.SampleCount;
                    attribute.ActiveMin = nextMin;
                    attribute.ActiveMax = nextMin + attribute.InitialWidth;
                    shifted++;
                }
                else
                {
                    kept++;
                }

                attribute.SampleTotal = 0f;
                attribute.SampleCount = 0;
            }

            reports.Add($"{GetTrackDisplayName(track.TrackId)}: 平移 {shifted} 项，保持 {kept} 项");
        }

        return reports.Count == 0 ? "EW-050 没有可管理的数值范围。" : $"EW-050 已准备下一轮数值范围：{string.Join("；", reports)}。";
    }

    public string CreateStatusReport()
    {
        EnsureCycleFrozen();
        if (_state.GrowthTracks.Count == 0)
        {
            return "数值范围未初始化。";
        }

        return string.Join(
            "；",
            _state.GrowthTracks.Select(
                track => $"{GetTrackDisplayName(track.TrackId)}={track.Attributes.Count}项(冻结轮={track.FrozenCycleNumber + 1})"
            )
        );
    }

    private void EnsureTrack(string trackId, IReadOnlyDictionary<string, EraFloatRange> configuredRanges)
    {
        EraGrowthTrackState? track = _state.GrowthTracks.FirstOrDefault(item => item.TrackId == trackId);
        if (track == null)
        {
            track = new EraGrowthTrackState
            {
                TrackId = trackId,
            };
            _state.GrowthTracks.Add(track);
        }

        HashSet<string> configuredIds = new HashSet<string>(configuredRanges.Keys, StringComparer.Ordinal);
        track.Attributes.RemoveAll(item => !configuredIds.Contains(item.AttributeId));

        foreach (KeyValuePair<string, EraFloatRange> pair in configuredRanges)
        {
            string attributeId = pair.Key;
            EraFloatRange configuredRange = pair.Value;
            EraGrowthAttributeRangeState? attribute = track.Attributes
                .FirstOrDefault(item => item.AttributeId == attributeId);
            if (attribute == null)
            {
                attribute = new EraGrowthAttributeRangeState
                {
                    AttributeId = attributeId,
                    ActiveMin = configuredRange.Min,
                    ActiveMax = configuredRange.Max,
                    FrozenMin = configuredRange.Min,
                    FrozenMax = configuredRange.Max,
                };
                track.Attributes.Add(attribute);
            }

            attribute.InitialMin = configuredRange.Min;
            attribute.InitialWidth = configuredRange.Max - configuredRange.Min;
        }
    }

    private static string GetTrackDisplayName(string trackId)
    {
        return trackId switch
        {
            EraGrowthTrackIds.Demon => "魔王",
            EraGrowthTrackIds.General => "将领",
            EraGrowthTrackIds.Hero => "英雄",
            EraGrowthTrackIds.Legion => "军团",
            _ => trackId,
        };
    }
}
