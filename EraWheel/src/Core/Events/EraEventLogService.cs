using EraWheel.Save.Models;

namespace EraWheel.Core.Events;

public sealed class EraEventLogService
{
    private EraWorldRuntimeState _state;
    private readonly int _maxEntries;

    public EraEventLogService(EraWorldRuntimeState state, int maxEntries = 512)
    {
        _state = state;
        _maxEntries = maxEntries;
    }

    public void Rebind(EraWorldRuntimeState state)
    {
        _state = state;
    }

    public void Append(string channel, string eventId, string message)
    {
        _state.EventSequence++;
        _state.EventLog.Add(
            new EraRuntimeEventRecord
            {
                Sequence = _state.EventSequence,
                Channel = channel,
                EventId = eventId,
                Message = message,
                WorldTime = _state.LastObservedWorldTime,
                CompletedCycles = _state.CompletedCycles,
                Stage = _state.Stage,
            }
        );

        while (_state.EventLog.Count > _maxEntries)
        {
            _state.EventLog.RemoveAt(0);
        }
    }

    public string CreateStatusReport()
    {
        return $"事件数={_state.EventLog.Count}；最新序号={_state.EventSequence}。";
    }
}
