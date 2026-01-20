using System.Collections.Generic;

namespace EraWheel.Core
{
    public class CycleHistory
    {
        private readonly List<CycleSummary> _entries = new List<CycleSummary>();

        public IReadOnlyList<CycleSummary> Entries => _entries;

        public void Clear()
        {
            _entries.Clear();
        }

        public void Add(CycleSummary summary)
        {
            _entries.Add(summary);
        }

        public CycleSummary[] ToArray()
        {
            return _entries.ToArray();
        }

        public void LoadFromArray(CycleSummary[] summaries)
        {
            _entries.Clear();
            if (summaries == null) return;
            _entries.AddRange(summaries);
        }
    }
}
