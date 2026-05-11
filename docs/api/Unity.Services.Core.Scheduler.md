# Assembly: Unity.Services.Core.Scheduler
- Path: tools/WorldBox.Managed/Unity.Services.Core.Scheduler.dll
- Types: 13

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=431 A5576FB9D076419784B42BFF3E1C0A685D57D84A095A5B4C0B44D7F9FB44B95A
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=624 CA035ABD3CA616B75FD4C6693C5B51FFC7D1B085170845A5B0A178535F975842

### private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData

#### Fields
- public byte[] FilePathsData
- public bool IsEditorOnly
- public int TotalFiles
- public int TotalTypes
- public byte[] TypesData

### internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1

#### Constructors
- public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()

#### Methods
- private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=431

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=624

## Namespace: Unity.Services.Core.Scheduler.Internal

### private struct Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap<T>.<>c__DisplayClass21_0<T>

#### Fields
- public Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap<T> <>4__this
- public int currentIndex
- public int smallest

### internal class Unity.Services.Core.Scheduler.Internal.ActionScheduler
- Interfaces: Unity.Services.Core.Scheduler.Internal.IActionScheduler, Unity.Services.Core.Internal.IServiceComponent

#### Fields
- private static const long k_MinimumIdValue
- private readonly System.Collections.Generic.List<Unity.Services.Core.Scheduler.Internal.ScheduledInvocation> m_ExpiredActions
- private readonly System.Collections.Generic.Dictionary<long, Unity.Services.Core.Scheduler.Internal.ScheduledInvocation> m_IdScheduledInvocationMap
- private readonly object m_Lock
- private long m_NextId
- private readonly Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap<Unity.Services.Core.Scheduler.Internal.ScheduledInvocation> m_ScheduledActions
- private readonly Unity.Services.Core.Scheduler.Internal.ITimeProvider m_TimeProvider
- internal readonly UnityEngine.LowLevel.PlayerLoopSystem SchedulerLoopSystem

#### Properties
- public int ScheduledActionsCount { get; }

#### Constructors
- public ActionScheduler()
- public ActionScheduler(Unity.Services.Core.Scheduler.Internal.ITimeProvider timeProvider)

#### Methods
- public void CancelAction(long actionId)
- internal void ExecuteExpiredActions()
- public void JoinPlayerLoopSystem()
- public void QuitPlayerLoopSystem()
- public long ScheduleAction(System.Action action, double delaySeconds = 0)
- internal static void UpdateCurrentPlayerLoopWith(System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem> subSystemList, UnityEngine.LowLevel.PlayerLoopSystem currentPlayerLoop)

### internal interface Unity.Services.Core.Scheduler.Internal.ITimeProvider

#### Properties
- public System.DateTime Now { get; }

### internal class Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap

#### Fields
- internal static const float DecreaseFactor
- internal static const float IncreaseFactor

#### Constructors
- protected MinimumBinaryHeap()

### internal class Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap<T>
- Base: Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap

#### Fields
- private int <Count>k__BackingField
- private readonly System.Collections.Generic.IComparer<T> m_Comparer
- private T[] m_HeapArray
- private readonly object m_Lock
- private readonly int m_MinimumCapacity

#### Properties
- public int Count { get; private set; }
- internal System.Collections.Generic.IReadOnlyList<T> HeapArray { get; }
- public T Min { get; }

#### Constructors
- public MinimumBinaryHeap<T>(int minimumCapacity = 10)
- public MinimumBinaryHeap<T>(System.Collections.Generic.IComparer<T> comparer, int minimumCapacity = 10)
- internal MinimumBinaryHeap<T>(System.Collections.Generic.ICollection<T> collection, System.Collections.Generic.IComparer<T> comparer, int minimumCapacity = 10)

#### Methods
- private void <MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1(int candidate, ref Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap<T>.<>c__DisplayClass21_0<T> )
- private void <MinHeapify>g__UpdateSmallestIndex|21_0(ref Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap<T>.<>c__DisplayClass21_0<T> )
- private void DecreaseHeapCapacityWhenSpare()
- public T ExtractMin()
- private static int GetLeftChildIndex(int index)
- private static int GetParentIndex(int index)
- private static int GetRightChildIndex(int index)
- private void IncreaseHeapCapacityWhenFull()
- private int IndexOf(T item)
- public void Insert(T item)
- private void MinHeapify()
- public void Remove(T item)
- private static void Swap(ref T lhs, ref T rhs)

### internal class Unity.Services.Core.Scheduler.Internal.ScheduledInvocation

#### Fields
- public System.Action Action
- public long ActionId
- public System.DateTime InvocationTime

#### Constructors
- public ScheduledInvocation()

### internal class Unity.Services.Core.Scheduler.Internal.ScheduledInvocationComparer
- Interfaces: System.Collections.Generic.IComparer<Unity.Services.Core.Scheduler.Internal.ScheduledInvocation>

#### Constructors
- public ScheduledInvocationComparer()

#### Methods
- public int Compare(Unity.Services.Core.Scheduler.Internal.ScheduledInvocation x, Unity.Services.Core.Scheduler.Internal.ScheduledInvocation y)

### internal class Unity.Services.Core.Scheduler.Internal.UtcTimeProvider
- Interfaces: Unity.Services.Core.Scheduler.Internal.ITimeProvider

#### Properties
- public System.DateTime Now { get; }

#### Constructors
- public UtcTimeProvider()

