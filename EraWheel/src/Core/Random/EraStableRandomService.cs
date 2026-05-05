using System;
using System.Collections.Generic;
using System.Linq;
using EraWheel.Core.Logging;
using EraWheel.Save.Models;

namespace EraWheel.Core.Random;

public sealed class EraStableRandomService
{
    private readonly object _randomStreamsLock = new();
    private EraWorldRuntimeState _state;
    private bool _worldFingerprintFallbackLogged;

    public EraStableRandomService(EraWorldRuntimeState state)
    {
        _state = state;
    }

    public void Rebind(EraWorldRuntimeState state)
    {
        lock (_randomStreamsLock)
        {
            _state = state;
            if (HasWorldFingerprintLocked())
            {
                _worldFingerprintFallbackLogged = false;
            }
        }
    }

    public void ResetForNewCycle(int? cycleSeed = null)
    {
        lock (_randomStreamsLock)
        {
            _state.RandomStreams.Clear();
            _state.CycleSeed = cycleSeed.GetValueOrDefault();
        }
    }

    public int NextInt(string streamId, string scopeId, int minInclusive, int maxExclusive)
    {
        if (maxExclusive <= minInclusive)
        {
            throw new ArgumentOutOfRangeException(nameof(maxExclusive), "随机上界必须大于下界。");
        }

        uint hash = NextHash(streamId, scopeId);
        return minInclusive + (int)(hash % (uint)(maxExclusive - minInclusive));
    }

    public float NextFloat(string streamId, string scopeId, float minInclusive, float maxInclusive)
    {
        if (maxInclusive < minInclusive)
        {
            throw new ArgumentOutOfRangeException(nameof(maxInclusive), "随机上界不能小于下界。");
        }

        uint hash = NextHash(streamId, scopeId);
        float normalized = hash / (float)uint.MaxValue;
        return minInclusive + ((maxInclusive - minInclusive) * normalized);
    }

    public string CreateStatusReport()
    {
        int streamCount;
        int cycleSeed;
        string fingerprint;
        lock (_randomStreamsLock)
        {
            streamCount = _state.RandomStreams.Count;
            cycleSeed = EnsureCycleSeedLocked();
            fingerprint = FormatWorldFingerprintLocked();
        }

        return $"本轮种子={cycleSeed}；世界指纹={fingerprint}；随机流={streamCount} 条。";
    }

    private uint NextHash(string streamId, string scopeId)
    {
        string key = $"{streamId}:{scopeId}";
        int cursor;
        lock (_randomStreamsLock)
        {
            EraRandomStreamState stream = GetOrCreateStreamLocked(key);
            cursor = stream.Cursor++;
            uint seed = unchecked((uint)EnsureCycleSeedLocked());
            seed = Mix(seed, key);
            seed = Mix(seed, cursor.ToString());
            return seed;
        }
    }

    private EraRandomStreamState GetOrCreateStreamLocked(string key)
    {
        for (int index = 0; index < _state.RandomStreams.Count; index++)
        {
            EraRandomStreamState stream = _state.RandomStreams[index];
            if (stream.StreamKey == key)
            {
                return stream;
            }
        }

        EraRandomStreamState created = new EraRandomStreamState
        {
            StreamKey = key,
            Cursor = 0,
        };
        _state.RandomStreams.Add(created);
        return created;
    }

    private int EnsureCycleSeedLocked()
    {
        if (_state.CycleSeed != 0)
        {
            return _state.CycleSeed;
        }

        List<string> values;
        if (HasWorldFingerprintLocked())
        {
            values = new List<string>(_state.CurrentDemonIds.Count + 4)
            {
                $"cycle:{_state.CompletedCycles}",
                $"tier:{_state.WorldTier}",
                $"world_seed:{_state.WorldSeedId}",
                $"world_life:{_state.WorldLifeDna}",
            };
            values.AddRange(_state.CurrentDemonIds.Select(item => $"demon:{item}"));
            _worldFingerprintFallbackLogged = false;
        }
        else
        {
            values = new List<string>(_state.CurrentDemonIds)
            {
                _state.CompletedCycles.ToString(),
                _state.WorldTier.ToString(),
            };

            if (!_worldFingerprintFallbackLogged)
            {
                EraLog.Warning(
                    EraLogCategory.Events,
                    "稳定随机缺少世界指纹：MapBox.current_world_seed_id 和 MapStats.life_dna 都是 0，将回退到旧随机口径。"
                );
                _worldFingerprintFallbackLogged = true;
            }
        }

        _state.CycleSeed = unchecked((int)Mix(2166136261, string.Join("|", values.OrderBy(item => item))));
        if (_state.CycleSeed == 0)
        {
            _state.CycleSeed = 1;
        }

        return _state.CycleSeed;
    }

    private bool HasWorldFingerprintLocked()
    {
        return _state.WorldSeedId != 0 || _state.WorldLifeDna != 0L;
    }

    private string FormatWorldFingerprintLocked()
    {
        return HasWorldFingerprintLocked()
            ? $"seed={_state.WorldSeedId},life={_state.WorldLifeDna}"
            : "缺失";
    }

    private static uint Mix(uint seed, string value)
    {
        uint current = seed;
        foreach (char character in value)
        {
            current ^= character;
            current *= 16777619;
        }

        return current;
    }
}
