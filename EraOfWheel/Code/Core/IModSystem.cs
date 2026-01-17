using System;

namespace EraOfWheel.Core
{
    /// <summary>
    /// MOD系统接口，所有子系统必须实现此接口
    /// </summary>
    public interface IModSystem : IDisposable
    {
        /// <summary>
        /// 系统名称，用于日志和调试
        /// </summary>
        string SystemName { get; }
        
        /// <summary>
        /// 初始化系统
        /// </summary>
        void Initialize();
        
        /// <summary>
        /// 系统是否已初始化
        /// </summary>
        bool IsInitialized { get; }
    }
}
