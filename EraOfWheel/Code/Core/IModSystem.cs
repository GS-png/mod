using System;

namespace EraOfWheel.Core
{
    public interface IModSystem : IDisposable
    {
        string SystemName { get; }
        bool IsInitialized { get; }
        void Initialize();
    }
}
