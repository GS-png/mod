using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using EraWheel.Config.Schema;

namespace EraWheel.Systems.Reincarnation;

public sealed class EraLegionWaveService
{
    private readonly EraLegionParameters _parameters;

    public EraLegionWaveService(EraLegionParameters parameters)
    {
        _parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));
    }

    public EraLegionWavePlan CalculateWave(int waveIndex, int activeLegionCount, IReadOnlyList<string>? demonIds)
    {
        int normalizedWaveIndex = Math.Max(1, waveIndex);
        int plannedCount = CalculatePlannedCount(normalizedWaveIndex);
        int availableSlots = Math.Max(0, _parameters.ConcurrentLimit - activeLegionCount);
        int actualCount = Math.Max(0, Math.Min(plannedCount, availableSlots));

        IReadOnlyDictionary<string, int> allocation = AllocateRoundRobin(demonIds, actualCount);
        string description = BuildDescription(normalizedWaveIndex, plannedCount, actualCount, availableSlots, allocation);

        return new EraLegionWavePlan(
            normalizedWaveIndex,
            plannedCount,
            actualCount,
            allocation,
            description
        );
    }

    private int CalculatePlannedCount(int waveIndex)
    {
        if (waveIndex <= 1 || _parameters.GrowthPercentPerWave <= 0f)
        {
            return _parameters.InitialCount;
        }

        double growthFactor = 1.0 + _parameters.GrowthPercentPerWave / 100.0;
        double multiplier = Math.Pow(growthFactor, waveIndex - 1);
        return (int)Math.Ceiling(_parameters.InitialCount * multiplier);
    }

    private static IReadOnlyDictionary<string, int> AllocateRoundRobin(IReadOnlyList<string>? demonIds, int totalLegions)
    {
        if (totalLegions <= 0 || demonIds == null || demonIds.Count == 0)
        {
            return new ReadOnlyDictionary<string, int>(new Dictionary<string, int>());
        }

        var allocation = new Dictionary<string, int>(demonIds.Count);
        int index = 0;
        for (int i = 0; i < totalLegions; i++)
        {
            string demonId = demonIds[index];
            allocation[demonId] = allocation.TryGetValue(demonId, out int existing) ? existing + 1 : 1;
            index = (index + 1) % demonIds.Count;
        }

        return new ReadOnlyDictionary<string, int>(allocation);
    }

    private string BuildDescription(
        int waveIndex,
        int plannedCount,
        int actualCount,
        int availableSlots,
        IReadOnlyDictionary<string, int> allocation
    )
    {
        var builder = new StringBuilder();
        builder.Append($"EW-054/055 第{waveIndex}波：计划{plannedCount}，上限{_parameters.ConcurrentLimit}，当前可用名额{availableSlots}。 ");

        if (actualCount <= 0)
        {
            if (availableSlots <= 0)
            {
                builder.Append("并发上限已满，跳过此波。");
            }
            else
            {
                builder.Append("计划数量为0或已达上限，未生成军团。");
            }
        }
        else
        {
            builder.Append($"实际投放{actualCount}个军团。");
            if (allocation.Count > 0)
            {
                builder.Append("分配：");
                builder.Append(string.Join(", ", allocation.Select(kv => $"{kv.Key}×{kv.Value}")));
                builder.Append("。 ");
            }
        }

        return builder.ToString().Trim();
    }
}

public sealed class EraLegionWavePlan
{
    public EraLegionWavePlan(
        int waveIndex,
        int plannedCount,
        int actualCount,
        IReadOnlyDictionary<string, int> allocation,
        string description
    )
    {
        WaveIndex = waveIndex;
        PlannedCount = plannedCount;
        ActualCount = actualCount;
        Allocation = allocation;
        Description = description;
    }

    public int WaveIndex { get; }
    public int PlannedCount { get; }
    public int ActualCount { get; }
    public IReadOnlyDictionary<string, int> Allocation { get; }
    public string Description { get; }
    public bool IsSkipped => ActualCount <= 0;
}
