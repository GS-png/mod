# Assembly: System.ServiceModel.Internals
- Path: tools/WorldBox.Managed/System.ServiceModel.Internals.dll
- Types: 184

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 1812FFD58290AC7DDA7A88832F32082655D69F735E8B764AD679F9A0D19AE462
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 62E6F13B53D67FDD780E20D89A6E8EE503B197AC16AC3F1D2571C147FDD324C9
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 69B4F5E3CE230ECC9509A555D4DF97EFDCA206A15ACCD048A0729C8315C8E38E

### internal static class AssemblyRef

#### Fields
- public static const string EcmaPublicKey
- public static const string FrameworkPublicKeyFull
- public static const string FrameworkPublicKeyFull2
- public static const string MicrosoftJScript
- public static const string MicrosoftPublicKey
- public static const string MicrosoftVSDesigner
- internal static const string System
- internal static const string SystemConfiguration
- public static const string SystemData
- public static const string SystemDesign
- public static const string SystemDrawing
- public static const string SystemWeb
- public static const string SystemWebExtensions
- public static const string SystemWindowsForms

### internal static class Consts

#### Fields
- public static const string AssemblyCorlib
- public static const string AssemblyI18N
- public static const string AssemblyMicrosoft_JScript
- public static const string AssemblyMicrosoft_VisualStudio
- public static const string AssemblyMicrosoft_VisualStudio_Web
- public static const string AssemblyMicrosoft_VSDesigner
- public static const string AssemblyMono_Http
- public static const string AssemblyMono_Messaging_RabbitMQ
- public static const string AssemblyMono_Posix
- public static const string AssemblyMono_Security
- public static const string AssemblyPresentationCore_3_5
- public static const string AssemblyPresentationCore_4_0
- public static const string AssemblyPresentationFramework_3_5
- public static const string AssemblySystem
- public static const string AssemblySystemCore_3_5
- public static const string AssemblySystemServiceModel_3_0
- public static const string AssemblySystem_2_0
- public static const string AssemblySystem_Core
- public static const string AssemblySystem_Data
- public static const string AssemblySystem_Design
- public static const string AssemblySystem_DirectoryServices
- public static const string AssemblySystem_Drawing
- public static const string AssemblySystem_Drawing_Design
- public static const string AssemblySystem_Messaging
- public static const string AssemblySystem_Security
- public static const string AssemblySystem_ServiceProcess
- public static const string AssemblySystem_Web
- public static const string AssemblySystem_Windows_Forms
- public static const string AssemblyWindowsBase
- public static const string EnvironmentVersion
- public static const string FxFileVersion
- public static const string FxVersion
- public static const string MonoCompany
- public static const string MonoCopyright
- public static const string MonoCorlibVersion
- public static const string MonoProduct
- public static const string MonoVersion
- private static const string PublicKeyToken
- public static const string VsFileVersion
- public static const string VsVersion
- public static const string WindowsBase_3_0

### internal static class SR

#### Methods
- internal static string Format(string resourceFormat, params object[] args)
- internal static string Format(string resourceFormat, object p1)
- internal static string Format(string resourceFormat, object p1, object p2)
- internal static string Format(System.Globalization.CultureInfo ci, string resourceFormat, object p1, object p2)
- internal static string Format(string resourceFormat, object p1, object p2, object p3)
- internal static string GetResourceString(string str)
- internal static string GetString(string name, params object[] args)
- internal static string GetString(System.Globalization.CultureInfo culture, string name, params object[] args)
- internal static string GetString(string name)
- internal static string GetString(System.Globalization.CultureInfo culture, string name)

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64

## Namespace: System.Runtime

### private class System.Runtime.Fx.<>c

#### Fields
- public static readonly System.Runtime.Fx.<>c <>9
- public static System.Action <>9__8_0

#### Constructors
- private static Fx.<>c()
- public Fx.<>c()

#### Methods
- internal void <InitializeTracing>b__8_0()

### private class System.Runtime.TaskExtensions.<>c__DisplayClass0_0<T>

#### Fields
- public System.AsyncCallback callback
- public System.Threading.Tasks.TaskCompletionSource<T> tcs

#### Constructors
- public TaskExtensions.<>c__DisplayClass0_0<T>()

#### Methods
- internal void <AsAsyncResult>b__0(System.Threading.Tasks.Task<T> t)

### private class System.Runtime.TaskExtensions.<>c__DisplayClass1_0

#### Fields
- public System.AsyncCallback callback
- public System.Threading.Tasks.TaskCompletionSource<object> tcs

#### Constructors
- public TaskExtensions.<>c__DisplayClass1_0()

#### Methods
- internal void <AsAsyncResult>b__0(System.Threading.Tasks.Task t)

### private class System.Runtime.TypeHelper.<GetCompatibleTypes>d__24
- Interfaces: System.Collections.Generic.IEnumerable<System.Type>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Type>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private System.Type <>2__current
- public System.Collections.Generic.IEnumerable<System.Type> <>3__enumerable
- public System.Type <>3__targetType
- private System.Collections.Generic.IEnumerator<System.Type> <>7__wrap1
- private int <>l__initialThreadId
- private System.Collections.Generic.IEnumerable<System.Type> enumerable
- private System.Type targetType

#### Properties
- private System.Type System.Collections.Generic.IEnumerator<System.Type>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public TypeHelper.<GetCompatibleTypes>d__24(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<System.Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private struct System.Runtime.TaskExtensions.<UpcastPrivate>d__11<TDerived, TBase>
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TBase> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter<TDerived> <>u__1
- public System.Threading.Tasks.Task<TDerived> task

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### internal class System.Runtime.ActionItem

#### Fields
- private bool isScheduled
- private bool lowPriority

#### Properties
- public bool LowPriority { get; protected set; }

#### Constructors
- protected ActionItem()

#### Methods
- protected abstract void Invoke()
- public static void Schedule(System.Action<object> callback, object state)
- public static void Schedule(System.Action<object> callback, object state, bool lowPriority)
- protected void Schedule()
- private static void ScheduleCallback(System.Action<object> callback, object state, bool lowPriority)
- private void ScheduleCallback(System.Action<object> callback)
- protected void ScheduleWithoutContext()

### private class System.Runtime.Fx.ActionThunk<T1>
- Base: System.Runtime.Fx.Thunk<System.Action<T1>>

#### Properties
- public System.Action<T1> ThunkFrame { get; }

#### Constructors
- public Fx.ActionThunk<T1>(System.Action<T1> callback)

#### Methods
- private void UnhandledExceptionFrame(T1 result)

### internal static class System.Runtime.AssertHelper

#### Methods
- internal static void FireAssert(string message)

### protected delegate System.Runtime.AsyncResult.AsyncCompletion
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public AsyncResult.AsyncCompletion(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IAsyncResult result, System.AsyncCallback callback, object object)
- public virtual bool EndInvoke(System.IAsyncResult result)
- public virtual bool Invoke(System.IAsyncResult result)

### internal enum System.Runtime.AsyncCompletionResult
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Completed = 1
- Queued = 0

### internal class System.Runtime.AsyncEventArgs
- Interfaces: System.Runtime.IAsyncEventArgs

#### Fields
- private object asyncState
- private System.Runtime.AsyncEventArgsCallback callback
- private System.Exception exception
- private System.Runtime.AsyncEventArgs.OperationState state

#### Properties
- public object AsyncState { get; }
- public System.Exception Exception { get; }
- private System.Runtime.AsyncEventArgs.OperationState State { set; }

#### Constructors
- protected AsyncEventArgs()

#### Methods
- public void Complete(bool completedSynchronously)
- public virtual void Complete(bool completedSynchronously, System.Exception exception)
- protected void SetAsyncState(System.Runtime.AsyncEventArgsCallback callback, object state)

### internal delegate System.Runtime.AsyncEventArgsCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public AsyncEventArgsCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.Runtime.IAsyncEventArgs eventArgs, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.Runtime.IAsyncEventArgs eventArgs)

### internal class System.Runtime.AsyncEventArgs<TArgument>
- Base: System.Runtime.AsyncEventArgs
- Interfaces: System.Runtime.IAsyncEventArgs

#### Fields
- private TArgument <Arguments>k__BackingField

#### Properties
- public TArgument Arguments { get; private set; }

#### Constructors
- public AsyncEventArgs<TArgument>()

#### Methods
- public virtual void Set(System.Runtime.AsyncEventArgsCallback callback, TArgument arguments, object state)

### internal class System.Runtime.AsyncEventArgs<TArgument, TResult>
- Base: System.Runtime.AsyncEventArgs<TArgument>
- Interfaces: System.Runtime.IAsyncEventArgs

#### Fields
- private TResult <Result>k__BackingField

#### Properties
- public TResult Result { get; set; }

#### Constructors
- public AsyncEventArgs<TArgument, TResult>()

### private class System.Runtime.InputQueue<T>.AsyncQueueReader<T>
- Base: System.Runtime.AsyncResult
- Interfaces: System.IAsyncResult, System.Runtime.InputQueue<T>.IQueueReader<T>

#### Fields
- private bool expired
- private System.Runtime.InputQueue<T> inputQueue
- private T item
- private System.Runtime.IOThreadTimer timer
- private static System.Action<object> timerCallback

#### Constructors
- private static InputQueue<T>.AsyncQueueReader<T>()
- public InputQueue<T>.AsyncQueueReader<T>(System.Runtime.InputQueue<T> inputQueue, System.TimeSpan timeout, System.AsyncCallback callback, object state)

#### Methods
- public static bool End(System.IAsyncResult result, out T value)
- public void Set(System.Runtime.InputQueue<T>.Item<T> item)
- private static void TimerCallback(object state)

### private class System.Runtime.InputQueue<T>.AsyncQueueWaiter<T>
- Base: System.Runtime.AsyncResult
- Interfaces: System.IAsyncResult, System.Runtime.InputQueue<T>.IQueueWaiter<T>

#### Fields
- private bool itemAvailable
- private object thisLock
- private System.Runtime.IOThreadTimer timer
- private static System.Action<object> timerCallback

#### Properties
- private object ThisLock { get; }

#### Constructors
- private static InputQueue<T>.AsyncQueueWaiter<T>()
- public InputQueue<T>.AsyncQueueWaiter<T>(System.TimeSpan timeout, System.AsyncCallback callback, object state)

#### Methods
- public static bool End(System.IAsyncResult result)
- public void Set(bool itemAvailable)
- private static void TimerCallback(object state)

### internal class System.Runtime.AsyncResult
- Interfaces: System.IAsyncResult

#### Fields
- private System.Action<System.Runtime.AsyncResult, System.Exception> <OnCompleting>k__BackingField
- private System.Action<System.AsyncCallback, System.IAsyncResult> <VirtualCallback>k__BackingField
- private static System.AsyncCallback asyncCompletionWrapperCallback
- private System.Action beforePrepareAsyncCompletionAction
- private System.AsyncCallback callback
- private System.Func<System.IAsyncResult, bool> checkSyncValidationFunc
- private bool completedSynchronously
- private bool endCalled
- private System.Exception exception
- private bool isCompleted
- private System.Threading.ManualResetEvent manualResetEvent
- private System.Runtime.AsyncResult.AsyncCompletion nextAsyncCompletion
- private object state
- private object thisLock

#### Properties
- public object AsyncState { get; }
- public System.Threading.WaitHandle AsyncWaitHandle { get; }
- public bool CompletedSynchronously { get; }
- public bool HasCallback { get; }
- public bool IsCompleted { get; }
- protected System.Action<System.Runtime.AsyncResult, System.Exception> OnCompleting { get; set; }
- private object ThisLock { get; }
- protected System.Action<System.AsyncCallback, System.IAsyncResult> VirtualCallback { get; set; }

#### Constructors
- protected AsyncResult(System.AsyncCallback callback, object state)

#### Methods
- private static void AsyncCompletionWrapperCallback(System.IAsyncResult result)
- protected bool CheckSyncContinue(System.IAsyncResult result)
- protected void Complete(bool completedSynchronously)
- protected void Complete(bool completedSynchronously, System.Exception exception)
- protected static TAsyncResult End<TAsyncResult>(System.IAsyncResult result)
- private System.Runtime.AsyncResult.AsyncCompletion GetNextCompletion()
- protected virtual bool OnContinueAsyncCompletion(System.IAsyncResult result)
- protected System.AsyncCallback PrepareAsyncCompletion(System.Runtime.AsyncResult.AsyncCompletion callback)
- protected void SetBeforePrepareAsyncCompletionAction(System.Action beforePrepareAsyncCompletionAction)
- protected void SetCheckSyncValidationFunc(System.Func<System.IAsyncResult, bool> checkSyncValidationFunc)
- protected bool SyncContinue(System.IAsyncResult result)
- protected static void ThrowInvalidAsyncResult(System.IAsyncResult result)
- protected static void ThrowInvalidAsyncResult(string debugText)
- private bool TryContinueHelper(System.IAsyncResult result, out System.Runtime.AsyncResult.AsyncCompletion callback)

### private class System.Runtime.Fx.AsyncThunk
- Base: System.Runtime.Fx.Thunk<System.AsyncCallback>

#### Properties
- public System.AsyncCallback ThunkFrame { get; }

#### Constructors
- public Fx.AsyncThunk(System.AsyncCallback callback)

#### Methods
- private void UnhandledExceptionFrame(System.IAsyncResult result)

### private class System.Runtime.AsyncWaitHandle.AsyncWaiter
- Base: System.Runtime.ActionItem

#### Fields
- private System.Runtime.AsyncWaitHandle <Parent>k__BackingField
- private bool <TimedOut>k__BackingField
- private System.Action<object, System.TimeoutException> callback
- private System.TimeSpan originalTimeout
- private object state
- private System.Runtime.IOThreadTimer timer

#### Properties
- public System.Runtime.AsyncWaitHandle Parent { get; private set; }
- public bool TimedOut { get; set; }

#### Constructors
- public AsyncWaitHandle.AsyncWaiter(System.Runtime.AsyncWaitHandle parent, System.Action<object, System.TimeoutException> callback, object state)

#### Methods
- public void Call()
- public void CancelTimer()
- protected override void Invoke()
- public void SetTimer(System.Action<object> callback, object state, System.TimeSpan timeout)

### internal class System.Runtime.AsyncWaitHandle

#### Fields
- private System.Collections.Generic.List<System.Runtime.AsyncWaitHandle.AsyncWaiter> asyncWaiters
- private bool isSignaled
- private System.Threading.EventResetMode resetMode
- private object syncObject
- private int syncWaiterCount
- private static System.Action<object> timerCompleteCallback

#### Constructors
- public AsyncWaitHandle()
- public AsyncWaitHandle(System.Threading.EventResetMode resetMode)

#### Methods
- private static void OnTimerComplete(object state)
- public void Reset()
- public void Set()
- public bool Wait(System.TimeSpan timeout)
- public bool WaitAsync(System.Action<object, System.TimeoutException> callback, object state, System.TimeSpan timeout)

### internal class System.Runtime.BackoffTimeoutHelper

#### Fields
- private System.Action<object> backoffCallback
- private object backoffState
- private System.Runtime.IOThreadTimer backoffTimer
- private System.DateTime deadline
- private static readonly System.TimeSpan defaultInitialWaitTime
- private static readonly System.TimeSpan defaultMaxWaitTime
- private static readonly long maxDriftTicks
- private static readonly int maxSkewMilliseconds
- private System.TimeSpan maxWaitTime
- private System.TimeSpan originalTimeout
- private System.Random random
- private System.TimeSpan waitTime

#### Properties
- public System.TimeSpan OriginalTimeout { get; }

#### Constructors
- private static BackoffTimeoutHelper()
- internal BackoffTimeoutHelper(System.TimeSpan timeout)
- internal BackoffTimeoutHelper(System.TimeSpan timeout, System.TimeSpan maxWaitTime)
- internal BackoffTimeoutHelper(System.TimeSpan timeout, System.TimeSpan maxWaitTime, System.TimeSpan initialWaitTime)

#### Methods
- private void Backoff()
- public bool IsExpired()
- private void Reset(System.TimeSpan timeout, System.TimeSpan initialWaitTime)
- public void WaitAndBackoff(System.Action<object> callback, object state)
- public void WaitAndBackoff()
- private System.TimeSpan WaitTimeWithDrift()

### private static class System.Runtime.IOThreadScheduler.Bits

#### Fields
- public static const int HiBits
- public static const int HiCountMask
- public static const int HiHiBit
- public static const int HiMask
- public static const int HiOne
- public static const int HiShift
- public static const int LoCountMask
- public static const int LoHiBit
- public static const int LoMask

#### Methods
- public static int Count(int slot)
- public static int CountNoIdle(int slot)
- public static int IncrementLo(int slot)
- public static bool IsComplete(int gate)

### public class System.Runtime.Fx.Tag.BlockingAttribute
- Base: System.Attribute

#### Fields
- private System.Type <CancelDeclaringType>k__BackingField
- private string <CancelMethod>k__BackingField
- private string <Conditional>k__BackingField

#### Properties
- public System.Type CancelDeclaringType { get; set; }
- public string CancelMethod { get; set; }
- public string Conditional { get; set; }

#### Constructors
- public Fx.Tag.BlockingAttribute()

### public enum System.Runtime.Fx.Tag.BlocksUsing
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AsyncResult = 4
- AutoResetEvent = 3
- IAsyncResult = 5
- InputQueue = 7
- ManualResetEvent = 2
- MonitorEnter = 0
- MonitorWait = 1
- NonBlocking = 14
- Other = 13
- OtherFrameworkPrimitive = 11
- OtherInternalPrimitive = 10
- OtherInterop = 12
- PInvoke = 6
- PrivatePrimitive = 9
- ThreadNeutralSemaphore = 8

### internal class System.Runtime.BufferedOutputStream
- Base: System.IO.Stream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private System.Runtime.InternalBufferManager bufferManager
- private bool bufferReturned
- private bool callerReturnsBuffer
- private int chunkCount
- private byte[][] chunks
- private byte[] currentChunk
- private int currentChunkSize
- private bool initialized
- private int maxSize
- private int maxSizeQuota
- private int totalSize

#### Properties
- public bool CanRead { get; }
- public bool CanSeek { get; }
- public bool CanWrite { get; }
- public long Length { get; }
- public long Position { get; set; }

#### Constructors
- public BufferedOutputStream()
- public BufferedOutputStream(int maxSize)
- public BufferedOutputStream(int initialSize, int maxSize, System.Runtime.InternalBufferManager bufferManager)

#### Methods
- private void AllocNextChunk(int minimumChunkSize)
- public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state)
- public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state)
- public void Clear()
- public override void Close()
- protected virtual System.Exception CreateQuotaExceededException(int maxSizeQuota)
- public override int EndRead(System.IAsyncResult result)
- public override void EndWrite(System.IAsyncResult result)
- public override void Flush()
- public override int Read(byte[] buffer, int offset, int size)
- public override int ReadByte()
- public void Reinitialize(int initialSize, int maxSizeQuota, System.Runtime.InternalBufferManager bufferManager)
- public void Reinitialize(int initialSize, int maxSizeQuota, int effectiveMaxSize, System.Runtime.InternalBufferManager bufferManager)
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- public override void SetLength(long value)
- public void Skip(int size)
- public byte[] ToArray(out int bufferSize)
- public System.IO.MemoryStream ToMemoryStream()
- public override void Write(byte[] buffer, int offset, int size)
- public override void WriteByte(byte value)
- private void WriteCore(byte[] buffer, int offset, int size)

### private class System.Runtime.InternalBufferManager.PooledBufferManager.BufferPool

#### Fields
- private int bufferSize
- private int count
- private int limit
- private int misses
- private int peak

#### Properties
- public int BufferSize { get; }
- public int Limit { get; }
- public int Misses { get; set; }
- public int Peak { get; }

#### Constructors
- public InternalBufferManager.PooledBufferManager.BufferPool(int bufferSize, int limit)

#### Methods
- public void Clear()
- internal static System.Runtime.InternalBufferManager.PooledBufferManager.BufferPool CreatePool(int bufferSize, int limit)
- public void DecrementCount()
- public void IncrementCount()
- internal abstract void OnClear()
- internal abstract bool Return(byte[] buffer)
- internal abstract byte[] Take()

### public class System.Runtime.Fx.Tag.CacheAttribute
- Base: System.Attribute

#### Fields
- private string <Scope>k__BackingField
- private string <SizeLimit>k__BackingField
- private string <Timeout>k__BackingField
- private readonly System.Runtime.Fx.Tag.CacheAttrition cacheAttrition
- private readonly System.Type elementType

#### Properties
- public System.Runtime.Fx.Tag.CacheAttrition CacheAttrition { get; }
- public System.Type ElementType { get; }
- public string Scope { get; set; }
- public string SizeLimit { get; set; }
- public string Timeout { get; set; }

#### Constructors
- public Fx.Tag.CacheAttribute(System.Type elementType, System.Runtime.Fx.Tag.CacheAttrition cacheAttrition)

### public enum System.Runtime.Fx.Tag.CacheAttrition
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ElementOnCallback = 3
- ElementOnGC = 2
- ElementOnTimer = 1
- FullPurgeOnEachAccess = 5
- FullPurgeOnTimer = 4
- None = 0
- PartialPurgeOnEachAccess = 7
- PartialPurgeOnTimer = 6

### private struct System.Runtime.MruCache<TKey, TValue>.CacheEntry<TKey, TValue>

#### Fields
- internal System.Collections.Generic.LinkedListNode<TKey> node
- internal TValue value

### internal class System.Runtime.CallbackException
- Base: System.Runtime.FatalException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public CallbackException()
- public CallbackException(string message, System.Exception innerException)
- protected CallbackException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)

### private static class System.Runtime.ActionItem.CallbackHelper

#### Fields
- private static System.Action<object> invokeWithoutContextCallback
- private static System.Threading.ContextCallback onContextAppliedCallback

#### Properties
- public static System.Action<object> InvokeWithoutContextCallback { get; }
- public static System.Threading.ContextCallback OnContextAppliedCallback { get; }

#### Methods
- private static void InvokeWithoutContext(object state)
- private static void OnContextApplied(object o)

### public static class System.Runtime.FxCop.Category

#### Fields
- public static const string Configuration
- public static const string Design
- public static const string Globalization
- public static const string Maintainability
- public static const string MSInternal
- public static const string Naming
- public static const string Performance
- public static const string Reliability
- public static const string ReliabilityBasic
- public static const string Security
- public static const string Usage
- public static const string Xaml

### internal class System.Runtime.CompletedAsyncResult
- Base: System.Runtime.AsyncResult
- Interfaces: System.IAsyncResult

#### Constructors
- public CompletedAsyncResult(System.AsyncCallback callback, object state)

#### Methods
- public static void End(System.IAsyncResult result)

### internal class System.Runtime.CompletedAsyncResult<T>
- Base: System.Runtime.AsyncResult
- Interfaces: System.IAsyncResult

#### Fields
- private T data

#### Constructors
- public CompletedAsyncResult<T>(T data, System.AsyncCallback callback, object state)

#### Methods
- public static T End(System.IAsyncResult result)

### internal class System.Runtime.CompletedAsyncResult<TResult, TParameter>
- Base: System.Runtime.AsyncResult
- Interfaces: System.IAsyncResult

#### Fields
- private TParameter parameter
- private TResult resultData

#### Constructors
- public CompletedAsyncResult<TResult, TParameter>(TResult resultData, TParameter parameter, System.AsyncCallback callback, object state)

#### Methods
- public static TResult End(System.IAsyncResult result, out TParameter parameter)

### internal enum System.Runtime.ComputerNameFormat
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Dns = 2
- DnsFullyQualified = 3
- DnsHostName = 1
- NetBIOS = 0
- PhysicalDnsDomain = 6
- PhysicalDnsFullyQualified = 7
- PhysicalDnsHostName = 5
- PhysicalNetBIOS = 4

### private class System.Runtime.ActionItem.DefaultActionItem
- Base: System.Runtime.ActionItem

#### Fields
- private System.Guid activityId
- private System.Action<object> callback
- private System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity
- private bool flowLegacyActivityId
- private object state

#### Constructors
- public ActionItem.DefaultActionItem(System.Action<object> callback, object state, bool isLowPriority)

#### Methods
- protected override void Invoke()
- private void TraceAndInvoke()

### internal static class System.Runtime.DiagnosticStrings

#### Fields
- internal static const string AppDomain
- internal static const string ChannelTag
- internal static const string DataItemsTag
- internal static const string DataTag
- internal static const string Description
- internal static const string DescriptionTag
- internal static const string ExceptionStringTag
- internal static const string ExceptionTag
- internal static const string ExceptionTypeTag
- internal static const string ExtendedDataTag
- internal static const string InnerExceptionTag
- internal static const string KeyTag
- internal static const string MessageTag
- internal static const string NamespaceTag
- internal static const string NativeErrorCodeTag
- internal static const string Separator
- internal static const string SeverityTag
- internal static const string SourceTag
- internal static const string StackTraceTag
- internal static const string Task
- internal static const string TraceCodeTag
- internal static const string TraceRecordTag
- internal static const string ValueTag

### internal class System.Runtime.DuplicateDetector<T>

#### Fields
- private int capacity
- private System.Collections.Generic.LinkedList<T> fifoList
- private System.Collections.Generic.Dictionary<T, System.Collections.Generic.LinkedListNode<T>> items
- private object thisLock

#### Constructors
- public DuplicateDetector<T>(int capacity)

#### Methods
- private void Add(T value)
- public bool AddIfNotDuplicate(T value)
- public void Clear()
- public bool Remove(T value)

### private class System.Runtime.ThreadNeutralSemaphore.EnterAsyncData

#### Fields
- private System.Runtime.FastAsyncCallback <Callback>k__BackingField
- private System.Runtime.ThreadNeutralSemaphore <Semaphore>k__BackingField
- private object <State>k__BackingField
- private System.Runtime.AsyncWaitHandle <Waiter>k__BackingField

#### Properties
- public System.Runtime.FastAsyncCallback Callback { get; set; }
- public System.Runtime.ThreadNeutralSemaphore Semaphore { get; set; }
- public object State { get; set; }
- public System.Runtime.AsyncWaitHandle Waiter { get; set; }

#### Constructors
- public ThreadNeutralSemaphore.EnterAsyncData(System.Runtime.ThreadNeutralSemaphore semaphore, System.Runtime.AsyncWaitHandle waiter, System.Runtime.FastAsyncCallback callback, object state)

### private struct System.Runtime.SynchronizedPool<T>.Entry<T>

#### Fields
- public int threadID
- public T value

### public class System.Runtime.Fx.ExceptionHandler

#### Constructors
- protected Fx.ExceptionHandler()

#### Methods
- public abstract bool HandleException(System.Exception exception)

### internal class System.Runtime.ExceptionTrace

#### Fields
- private readonly System.Runtime.Diagnostics.EtwDiagnosticTrace diagnosticTrace
- private string eventSourceName
- private static const ushort FailFastEventLogCategory

#### Constructors
- public ExceptionTrace(string eventSourceName, System.Runtime.Diagnostics.EtwDiagnosticTrace diagnosticTrace)

#### Methods
- public System.ArgumentException Argument(string paramName, string message)
- public System.ArgumentNullException ArgumentNull(string paramName)
- public System.ArgumentNullException ArgumentNull(string paramName, string message)
- public System.ArgumentException ArgumentNullOrEmpty(string paramName)
- public System.ArgumentOutOfRangeException ArgumentOutOfRange(string paramName, object actualValue, string message)
- public System.Exception AsError(System.Exception exception)
- public System.Exception AsError(System.Exception exception, string eventSource)
- public System.Exception AsError(System.Reflection.TargetInvocationException targetInvocationException, string eventSource)
- public System.Exception AsError<TPreferredException>(System.AggregateException aggregateException)
- public System.Exception AsError<TPreferredException>(System.AggregateException aggregateException, string eventSource)
- public void AsInformation(System.Exception exception)
- public void AsWarning(System.Exception exception)
- private void BreakOnException(System.Exception exception)
- public System.ObjectDisposedException ObjectDisposed(string message)
- public void TraceEtwException(System.Exception exception, System.Diagnostics.TraceEventType eventType)
- private TException TraceException<TException>(TException exception)
- private TException TraceException<TException>(TException exception, string eventSource)
- internal void TraceFailFast(string message)
- internal void TraceFailFast(string message, System.Runtime.Diagnostics.EventLogger logger)
- public void TraceHandledException(System.Exception exception, System.Diagnostics.TraceEventType traceEventType)
- public void TraceUnhandledException(System.Exception exception)

### public class System.Runtime.Fx.Tag.ExternalResourceAttribute
- Base: System.Attribute

#### Fields
- private readonly string description
- private readonly System.Runtime.Fx.Tag.Location location

#### Properties
- public string Description { get; }
- public System.Runtime.Fx.Tag.Location Location { get; }

#### Constructors
- public Fx.Tag.ExternalResourceAttribute(System.Runtime.Fx.Tag.Location location, string description)

### internal delegate System.Runtime.FastAsyncCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public FastAsyncCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(object state, System.Exception asyncException, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(object state, System.Exception asyncException)

### internal class System.Runtime.FatalException
- Base: System.SystemException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public FatalException()
- public FatalException(string message)
- public FatalException(string message, System.Exception innerException)
- protected FatalException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)

### private class System.Runtime.Fx.FatalInternalException
- Base: System.Runtime.Fx.InternalException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public Fx.FatalInternalException(string description)
- protected Fx.FatalInternalException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)

### public class System.Runtime.Fx.Tag.FriendAccessAllowedAttribute
- Base: System.Attribute

#### Fields
- private string <AssemblyName>k__BackingField

#### Properties
- public string AssemblyName { get; set; }

#### Constructors
- public Fx.Tag.FriendAccessAllowedAttribute(string assemblyName)

### internal static class System.Runtime.Fx

#### Fields
- private static System.Runtime.Fx.ExceptionHandler asynchronousThreadExceptionHandler
- private static const string defaultEventSource
- private static System.Runtime.Diagnostics.EtwDiagnosticTrace diagnosticTrace
- private static System.Runtime.ExceptionTrace exceptionTrace

#### Properties
- internal static bool AssertsFailFast { get; }
- public static System.Runtime.Fx.ExceptionHandler AsynchronousThreadExceptionHandler { get; set; }
- internal static System.Type[] BreakOnExceptionTypes { get; }
- public static System.Runtime.ExceptionTrace Exception { get; }
- internal static bool FastDebug { get; }
- internal static bool StealthDebugger { get; }
- public static System.Runtime.Diagnostics.EtwDiagnosticTrace Trace { get; }

#### Methods
- public static byte[] AllocateByteArray(int size)
- public static char[] AllocateCharArray(int size)
- public static void Assert(bool condition, string description)
- public static void Assert(string description)
- public static void AssertAndFailFast(bool condition, string description)
- public static System.Exception AssertAndFailFast(string description)
- public static void AssertAndThrow(bool condition, string description)
- public static System.Exception AssertAndThrow(string description)
- public static void AssertAndThrowFatal(bool condition, string description)
- public static System.Exception AssertAndThrowFatal(string description)
- public static System.Guid CreateGuid(string guidString)
- private static bool HandleAtThreadBase(System.Exception exception)
- private static System.Runtime.Diagnostics.EtwDiagnosticTrace InitializeTracing()
- public static bool IsFatal(System.Exception exception)
- public static System.Action<T1> ThunkCallback<T1>(System.Action<T1> callback)
- public static System.AsyncCallback ThunkCallback(System.AsyncCallback callback)
- public static System.Threading.WaitCallback ThunkCallback(System.Threading.WaitCallback callback)
- public static System.Threading.TimerCallback ThunkCallback(System.Threading.TimerCallback callback)
- public static System.Threading.WaitOrTimerCallback ThunkCallback(System.Threading.WaitOrTimerCallback callback)
- public static System.Threading.SendOrPostCallback ThunkCallback(System.Threading.SendOrPostCallback callback)
- public static System.Threading.IOCompletionCallback ThunkCallback(System.Threading.IOCompletionCallback callback)
- private static void TraceExceptionNoThrow(System.Exception exception)
- public static bool TryCreateGuid(string guidString, out System.Guid result)
- private static void UpdateLevel(System.Runtime.Diagnostics.EtwDiagnosticTrace trace)
- private static void UpdateLevel()

### internal static class System.Runtime.FxCop

### private static class System.Runtime.SignalGate.GateState

#### Fields
- public static const int Locked
- public static const int Signalled
- public static const int SignalPending
- public static const int Unlocked

### private class System.Runtime.InternalBufferManager.GCBufferManager
- Base: System.Runtime.InternalBufferManager

#### Fields
- private static System.Runtime.InternalBufferManager.GCBufferManager value

#### Properties
- public static System.Runtime.InternalBufferManager.GCBufferManager Value { get; }

#### Constructors
- private InternalBufferManager.GCBufferManager()
- private static InternalBufferManager.GCBufferManager()

#### Methods
- public override void Clear()
- public override void ReturnBuffer(byte[] buffer)
- public override byte[] TakeBuffer(int bufferSize)

### private class System.Runtime.SynchronizedPool<T>.GlobalPool<T>

#### Fields
- private System.Collections.Generic.Stack<T> items
- private int maxCount

#### Properties
- public int MaxCount { get; set; }
- private object ThisLock { get; }

#### Constructors
- public SynchronizedPool<T>.GlobalPool<T>(int maxCount)

#### Methods
- public void Clear()
- public void DecrementMaxCount()
- public bool Return(T value)
- public T Take()

### public class System.Runtime.Fx.Tag.GuaranteeNonBlockingAttribute
- Base: System.Attribute

#### Constructors
- public Fx.Tag.GuaranteeNonBlockingAttribute()

### internal static class System.Runtime.HashHelper

#### Methods
- public static byte[] ComputeHash(byte[] buffer)

### private class System.Runtime.UrlUtility.HttpValueCollection
- Base: System.Collections.Specialized.NameValueCollection
- Interfaces: System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback

#### Constructors
- internal UrlUtility.HttpValueCollection(string str, System.Text.Encoding encoding)
- protected UrlUtility.HttpValueCollection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)

#### Methods
- internal void FillFromString(string s, bool urlencoded, System.Text.Encoding encoding)
- public override string ToString()
- private string ToString(bool urlencoded, System.Collections.IDictionary excludeKeys)

### internal interface System.Runtime.IAsyncEventArgs

#### Properties
- public object AsyncState { get; }
- public System.Exception Exception { get; }

### public class System.Runtime.Fx.Tag.InheritThrowsAttribute
- Base: System.Attribute

#### Fields
- private string <From>k__BackingField
- private System.Type <FromDeclaringType>k__BackingField

#### Properties
- public string From { get; set; }
- public System.Type FromDeclaringType { get; set; }

#### Constructors
- public Fx.Tag.InheritThrowsAttribute()

### internal class System.Runtime.InputQueue<T>
- Interfaces: System.IDisposable

#### Fields
- private System.Func<System.Action<System.AsyncCallback, System.IAsyncResult>> <AsyncCallbackGenerator>k__BackingField
- private System.Action<T> <DisposeItemCallback>k__BackingField
- private static System.Action<object> completeOutstandingReadersCallback
- private static System.Action<object> completeWaitersFalseCallback
- private static System.Action<object> completeWaitersTrueCallback
- private System.Runtime.InputQueue<T>.ItemQueue<T> itemQueue
- private static System.Action<object> onDispatchCallback
- private static System.Action<object> onInvokeDequeuedCallback
- private System.Runtime.InputQueue<T>.QueueState<T> queueState
- private System.Collections.Generic.Queue<System.Runtime.InputQueue<T>.IQueueReader<T>> readerQueue
- private System.Collections.Generic.List<System.Runtime.InputQueue<T>.IQueueWaiter<T>> waiterList

#### Properties
- private System.Func<System.Action<System.AsyncCallback, System.IAsyncResult>> AsyncCallbackGenerator { get; set; }
- public System.Action<T> DisposeItemCallback { get; set; }
- public int PendingCount { get; }
- private object ThisLock { get; }

#### Constructors
- public InputQueue<T>()
- public InputQueue<T>(System.Func<System.Action<System.AsyncCallback, System.IAsyncResult>> asyncCallbackGenerator)

#### Methods
- public System.IAsyncResult BeginDequeue(System.TimeSpan timeout, System.AsyncCallback callback, object state)
- public System.IAsyncResult BeginWaitForItem(System.TimeSpan timeout, System.AsyncCallback callback, object state)
- public void Close()
- private static void CompleteOutstandingReadersCallback(object state)
- private static void CompleteWaiters(bool itemAvailable, System.Runtime.InputQueue<T>.IQueueWaiter<T>[] waiters)
- private static void CompleteWaitersFalseCallback(object state)
- private static void CompleteWaitersLater(bool itemAvailable, System.Runtime.InputQueue<T>.IQueueWaiter<T>[] waiters)
- private static void CompleteWaitersTrueCallback(object state)
- public T Dequeue(System.TimeSpan timeout)
- public bool Dequeue(System.TimeSpan timeout, out T value)
- public void Dispatch()
- public void Dispose()
- private void DisposeItem(System.Runtime.InputQueue<T>.Item<T> item)
- public bool EndDequeue(System.IAsyncResult result, out T value)
- public T EndDequeue(System.IAsyncResult result)
- public bool EndWaitForItem(System.IAsyncResult result)
- public void EnqueueAndDispatch(T item)
- public void EnqueueAndDispatch(T item, System.Action dequeuedCallback)
- public void EnqueueAndDispatch(System.Exception exception, System.Action dequeuedCallback, bool canDispatchOnThisThread)
- public void EnqueueAndDispatch(T item, System.Action dequeuedCallback, bool canDispatchOnThisThread)
- private void EnqueueAndDispatch(System.Runtime.InputQueue<T>.Item<T> item, bool canDispatchOnThisThread)
- public bool EnqueueWithoutDispatch(T item, System.Action dequeuedCallback)
- public bool EnqueueWithoutDispatch(System.Exception exception, System.Action dequeuedCallback)
- private bool EnqueueWithoutDispatch(System.Runtime.InputQueue<T>.Item<T> item)
- private void GetWaiters(out System.Runtime.InputQueue<T>.IQueueWaiter<T>[] waiters)
- private static void InvokeDequeuedCallback(System.Action dequeuedCallback)
- private static void InvokeDequeuedCallbackLater(System.Action dequeuedCallback)
- private static void OnDispatchCallback(object state)
- private static void OnInvokeDequeuedCallback(object state)
- private bool RemoveReader(System.Runtime.InputQueue<T>.IQueueReader<T> reader)
- public void Shutdown()
- public void Shutdown(System.Func<System.Exception> pendingExceptionGenerator)
- public bool WaitForItem(System.TimeSpan timeout)

### internal class System.Runtime.InternalBufferManager

#### Constructors
- protected InternalBufferManager()

#### Methods
- public abstract void Clear()
- public static System.Runtime.InternalBufferManager Create(long maxBufferPoolSize, int maxBufferSize)
- public abstract void ReturnBuffer(byte[] buffer)
- public abstract byte[] TakeBuffer(int bufferSize)

### private class System.Runtime.Fx.InternalException
- Base: System.SystemException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public Fx.InternalException(string description)
- protected Fx.InternalException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)

### internal static class System.Runtime.InternalSR

#### Fields
- public static const string ActionItemIsAlreadyScheduled
- public static const string AsyncCallbackThrewException
- public static const string AsyncResultAlreadyEnded
- public static const string BadCopyToArray
- public static const string BufferIsNotRightSizeForBufferManager
- public static const string DictionaryIsReadOnly
- public static const string InvalidAsyncResult
- public static const string InvalidAsyncResultImplementationGeneric
- public static const string InvalidNullAsyncResult
- public static const string InvalidSemaphoreExit
- public static const string KeyCollectionUpdatesNotAllowed
- public static const string KeyNotFoundInDictionary
- public static const string MustCancelOldTimer
- public static const string NullKeyAlreadyPresent
- public static const string ReadNotSupported
- public static const string SeekNotSupported
- public static const string SFxTaskNotStarted
- public static const string ThreadNeutralSemaphoreAborted
- public static const string ValueCollectionUpdatesNotAllowed
- public static const string ValueMustBeNonNegative

#### Methods
- public static string ArgumentNullOrEmpty(string paramName)
- public static string AsyncEventArgsCompletedTwice(System.Type t)
- public static string AsyncEventArgsCompletionPending(System.Type t)
- public static string AsyncResultCompletedTwice(System.Type t)
- public static string BufferAllocationFailed(int size)
- public static string BufferedOutputStreamQuotaExceeded(int maxSizeQuota)
- public static string CannotConvertObject(object source, System.Type t)
- public static string EtwAPIMaxStringCountExceeded(object max)
- public static string EtwMaxNumberArgumentsExceeded(object max)
- public static string EtwRegistrationFailed(object arg)
- public static string FailFastMessage(string description)
- public static string InvalidAsyncResultImplementation(System.Type t)
- public static string LockTimeoutExceptionMessage(object timeout)
- public static string ShipAssertExceptionMessage(object description)
- public static string TaskTimedOutError(object timeout)
- public static string TimeoutInputQueueDequeue(object timeout)
- public static string TimeoutMustBeNonNegative(object argumentName, object timeout)
- public static string TimeoutMustBePositive(string argumentName, object timeout)
- public static string TimeoutOnOperation(object timeout)

### private class System.Runtime.Fx.IOCompletionThunk

#### Fields
- private System.Threading.IOCompletionCallback callback

#### Properties
- public System.Threading.IOCompletionCallback ThunkFrame { get; }

#### Constructors
- public Fx.IOCompletionThunk(System.Threading.IOCompletionCallback callback)

#### Methods
- private void UnhandledExceptionFrame(uint error, uint bytesRead, System.Threading.NativeOverlapped* nativeOverlapped)

### internal class System.Runtime.IOThreadCancellationTokenSource
- Interfaces: System.IDisposable

#### Fields
- private static readonly System.Action<object> onCancel
- private System.Threading.CancellationTokenSource source
- private readonly System.TimeSpan timeout
- private System.Runtime.IOThreadTimer timer
- private System.Nullable<System.Threading.CancellationToken> token

#### Properties
- public System.Threading.CancellationToken Token { get; }

#### Constructors
- private static IOThreadCancellationTokenSource()
- public IOThreadCancellationTokenSource(System.TimeSpan timeout)
- public IOThreadCancellationTokenSource(int timeout)

#### Methods
- private void Cancel()
- public void Dispose()
- private static void OnCancel(object obj)

### internal class System.Runtime.IOThreadScheduler

#### Fields
- private static System.Runtime.IOThreadScheduler current
- private int headTail
- private int headTailLowPri
- private static const int MaximumCapacity
- private readonly System.Runtime.IOThreadScheduler.ScheduledOverlapped overlapped
- private readonly System.Runtime.IOThreadScheduler.Slot[] slots
- private readonly System.Runtime.IOThreadScheduler.Slot[] slotsLowPri

#### Properties
- private int SlotMask { get; }
- private int SlotMaskLowPri { get; }

#### Constructors
- private static IOThreadScheduler()
- private IOThreadScheduler(int capacity, int capacityLowPri)

#### Methods
- private void Cleanup()
- private void CompletionCallback(out System.Action<object> callback, out object state)
- protected override void Finalize()
- private bool ScheduleCallbackHelper(System.Action<object> callback, object state)
- private bool ScheduleCallbackLowPriHelper(System.Action<object> callback, object state)
- public static void ScheduleCallbackLowPriNoFlow(System.Action<object> callback, object state)
- public static void ScheduleCallbackNoFlow(System.Action<object> callback, object state)
- private bool TryCoalesce(out System.Action<object> callback, out object state)

### internal class System.Runtime.IOThreadTimer

#### Fields
- private System.Action<object> callback
- private object callbackState
- private long dueTime
- private int index
- private long maxSkew
- private static const int maxSkewInMillisecondsDefault
- private static long systemTimeResolutionTicks
- private System.Runtime.IOThreadTimer.TimerGroup timerGroup

#### Properties
- public static long SystemTimeResolutionTicks { get; }

#### Constructors
- private static IOThreadTimer()
- public IOThreadTimer(System.Action<object> callback, object callbackState, bool isTypicallyCanceledShortlyAfterBeingSet)
- public IOThreadTimer(System.Action<object> callback, object callbackState, bool isTypicallyCanceledShortlyAfterBeingSet, int maxSkewInMilliseconds)

#### Methods
- public bool Cancel()
- private static long GetSystemTimeResolution()
- public void Set(System.TimeSpan timeFromNow)
- public void Set(int millisecondsFromNow)
- public void SetAt(long dueTime)

### private interface System.Runtime.InputQueue<T>.IQueueReader<T>

#### Methods
- public void Set(System.Runtime.InputQueue<T>.Item<T> item)

### private interface System.Runtime.InputQueue<T>.IQueueWaiter<T>

#### Methods
- public void Set(bool itemAvailable)

### private struct System.Runtime.InputQueue<T>.Item<T>

#### Fields
- private System.Action dequeuedCallback
- private System.Exception exception
- private T value

#### Properties
- public System.Action DequeuedCallback { get; }
- public System.Exception Exception { get; }
- public T Value { get; }

#### Constructors
- public InputQueue<T>.Item<T>(T value, System.Action dequeuedCallback)
- public InputQueue<T>.Item<T>(System.Exception exception, System.Action dequeuedCallback)
- private InputQueue<T>.Item<T>(T value, System.Exception exception, System.Action dequeuedCallback)

#### Methods
- public T GetValue()

### private class System.Runtime.InputQueue<T>.ItemQueue<T>

#### Fields
- private int head
- private System.Runtime.InputQueue<T>.Item<T>[] items
- private int pendingCount
- private int totalCount

#### Properties
- public bool HasAnyItem { get; }
- public bool HasAvailableItem { get; }
- public int ItemCount { get; }

#### Constructors
- public InputQueue<T>.ItemQueue<T>()

#### Methods
- public System.Runtime.InputQueue<T>.Item<T> DequeueAnyItem()
- public System.Runtime.InputQueue<T>.Item<T> DequeueAvailableItem()
- private System.Runtime.InputQueue<T>.Item<T> DequeueItemCore()
- public void EnqueueAvailableItem(System.Runtime.InputQueue<T>.Item<T> item)
- private void EnqueueItemCore(System.Runtime.InputQueue<T>.Item<T> item)
- public void EnqueuePendingItem(System.Runtime.InputQueue<T>.Item<T> item)
- public void MakePendingItemAvailable()

### public class System.Runtime.Fx.Tag.KnownXamlExternalAttribute
- Base: System.Attribute

#### Constructors
- public Fx.Tag.KnownXamlExternalAttribute()

### private class System.Runtime.InternalBufferManager.PooledBufferManager.BufferPool.LargeBufferPool
- Base: System.Runtime.InternalBufferManager.PooledBufferManager.BufferPool

#### Fields
- private System.Collections.Generic.Stack<byte[]> items

#### Properties
- private object ThisLock { get; }

#### Constructors
- internal InternalBufferManager.PooledBufferManager.BufferPool.LargeBufferPool(int bufferSize, int limit)

#### Methods
- internal override void OnClear()
- internal override bool Return(byte[] buffer)
- internal override byte[] Take()

### public enum System.Runtime.Fx.Tag.Location
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- InProcess = 0
- LocalOrRemoteSystem = 3
- LocalSystem = 2
- OutOfProcess = 1
- RemoteSystem = 4

### internal class System.Runtime.MruCache<TKey, TValue>

#### Fields
- private int highWatermark
- private System.Collections.Generic.Dictionary<TKey, System.Runtime.MruCache<TKey, TValue>.CacheEntry<TKey, TValue>> items
- private int lowWatermark
- private System.Runtime.MruCache<TKey, TValue>.CacheEntry<TKey, TValue> mruEntry
- private System.Collections.Generic.LinkedList<TKey> mruList

#### Properties
- public int Count { get; }

#### Constructors
- public MruCache<TKey, TValue>(int watermark)
- public MruCache<TKey, TValue>(int lowWatermark, int highWatermark)
- public MruCache<TKey, TValue>(int lowWatermark, int highWatermark, System.Collections.Generic.IEqualityComparer<TKey> comparer)

#### Methods
- public void Add(TKey key, TValue value)
- public void Clear()
- protected virtual void OnItemAgedOutOfCache(TValue item)
- protected virtual void OnSingleItemRemoved(TValue item)
- public bool Remove(TKey key)
- public bool TryGetValue(TKey key, out TValue value)

### internal class System.Runtime.NameGenerator

#### Fields
- private long id
- private static System.Runtime.NameGenerator nameGenerator
- private string prefix

#### Constructors
- private NameGenerator()
- private static NameGenerator()

#### Methods
- public static string Next()

### public class System.Runtime.Fx.Tag.NonThrowingAttribute
- Base: System.Attribute

#### Constructors
- public Fx.Tag.NonThrowingAttribute()

### private enum System.Runtime.AsyncEventArgs.OperationState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CompletedAsynchronously = 3
- CompletedSynchronously = 2
- Created = 0
- PendingCompletion = 1

### internal static class System.Runtime.PartialTrustHelpers

#### Fields
- private static System.Type aptca
- private static bool checkedForFullTrust
- private static bool inFullTrust

#### Properties
- internal static bool AppDomainFullyTrusted { get; }
- internal static bool ShouldFlowSecurityContext { get; }

#### Methods
- internal static bool CheckAppDomainPermissions(System.Security.PermissionSet permissions)
- internal static void DemandForFullTrust()
- internal static bool HasEtwPermissions()
- private static bool IsAssemblyAptca(System.Reflection.Assembly assembly)
- private static bool IsAssemblySigned(System.Reflection.Assembly assembly)
- internal static bool IsInFullTrust()
- internal static bool IsTypeAptca(System.Type type)

### private struct System.Runtime.SynchronizedPool<T>.PendingEntry<T>

#### Fields
- public int returnCount
- public int threadID

### private class System.Runtime.InternalBufferManager.PooledBufferManager
- Base: System.Runtime.InternalBufferManager

#### Fields
- private bool areQuotasBeingTuned
- private System.Runtime.InternalBufferManager.PooledBufferManager.BufferPool[] bufferPools
- private int[] bufferSizes
- private static const int initialBufferCount
- private static const int maxMissesBeforeTuning
- private long memoryLimit
- private static const int minBufferSize
- private long remainingMemory
- private int totalMisses
- private readonly object tuningLock

#### Constructors
- public InternalBufferManager.PooledBufferManager(long maxMemoryToPool, int maxBufferSize)

#### Methods
- private void ChangeQuota(ref System.Runtime.InternalBufferManager.PooledBufferManager.BufferPool bufferPool, int delta)
- public override void Clear()
- private void DecreaseQuota(ref System.Runtime.InternalBufferManager.PooledBufferManager.BufferPool bufferPool)
- private int FindMostExcessivePool()
- private int FindMostStarvedPool()
- private System.Runtime.InternalBufferManager.PooledBufferManager.BufferPool FindPool(int desiredBufferSize)
- private void IncreaseQuota(ref System.Runtime.InternalBufferManager.PooledBufferManager.BufferPool bufferPool)
- public override void ReturnBuffer(byte[] buffer)
- public override byte[] TakeBuffer(int bufferSize)
- private void TuneQuotas()

### public class System.Runtime.Fx.Tag.QueueAttribute
- Base: System.Attribute

#### Fields
- private bool <EnqueueThrowsIfFull>k__BackingField
- private string <Scope>k__BackingField
- private string <SizeLimit>k__BackingField
- private bool <StaleElementsRemovedImmediately>k__BackingField
- private readonly System.Type elementType

#### Properties
- public System.Type ElementType { get; }
- public bool EnqueueThrowsIfFull { get; set; }
- public string Scope { get; set; }
- public string SizeLimit { get; set; }
- public bool StaleElementsRemovedImmediately { get; set; }

#### Constructors
- public Fx.Tag.QueueAttribute(System.Type elementType)

### private enum System.Runtime.InputQueue<T>.QueueState<T>
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Closed = 2
- Open = 0
- Shutdown = 1

### internal class System.Runtime.ReadOnlyDictionaryInternal<TKey, TValue>
- Interfaces: System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable

#### Fields
- private System.Collections.Generic.IDictionary<TKey, TValue> dictionary

#### Properties
- public int Count { get; }
- public bool IsReadOnly { get; }
- public TValue Item { get; set; }
- public System.Collections.Generic.ICollection<TKey> Keys { get; }
- public System.Collections.Generic.ICollection<TValue> Values { get; }

#### Constructors
- public ReadOnlyDictionaryInternal<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> dictionary)

#### Methods
- public void Add(TKey key, TValue value)
- public void Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item)
- public void Clear()
- public bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item)
- public bool ContainsKey(TKey key)
- public void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int arrayIndex)
- public static System.Collections.Generic.IDictionary<TKey, TValue> Create(System.Collections.Generic.IDictionary<TKey, TValue> dictionary)
- private System.Exception CreateReadOnlyException()
- public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator()
- public bool Remove(TKey key)
- public bool Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item)
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- public bool TryGetValue(TKey key, out TValue value)

### internal class System.Runtime.ReadOnlyKeyedCollection<TKey, TValue>
- Base: System.Collections.ObjectModel.ReadOnlyCollection<TValue>
- Interfaces: System.Collections.Generic.IList<TValue>, System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList<TValue>, System.Collections.Generic.IReadOnlyCollection<TValue>

#### Fields
- private System.Collections.ObjectModel.KeyedCollection<TKey, TValue> innerCollection

#### Properties
- public TValue Item { get; }

#### Constructors
- public ReadOnlyKeyedCollection<TKey, TValue>(System.Collections.ObjectModel.KeyedCollection<TKey, TValue> innerCollection)

### public static class System.Runtime.FxCop.Rule

#### Fields
- public static const string AptcaMethodsShouldOnlyCallAptcaMethods
- public static const string AssembliesShouldHaveValidStrongNames
- public static const string AvoidCallingProblematicMethods
- public static const string AvoidExcessiveComplexity
- public static const string AvoidNamespacesWithFewTypes
- public static const string AvoidOutParameters
- public static const string AvoidUncalledPrivateCode
- public static const string AvoidUninstantiatedInternalClasses
- public static const string AvoidUnsealedAttributes
- public static const string CollectionPropertiesShouldBeReadOnly
- public static const string CollectionsShouldImplementGenericInterface
- public static const string CommunicationObjectThrowIf
- public static const string ConfigurationPropertyAttributeRule
- public static const string ConfigurationPropertyNameRule
- public static const string ConfigurationValidatorAttributeRule
- public static const string ConsiderPassingBaseTypesAsParameters
- public static const string DefaultParametersShouldNotBeUsed
- public static const string DefineAccessorsForAttributeArguments
- public static const string DiagnosticsUtilityIsFatal
- public static const string DisposableFieldsShouldBeDisposed
- public static const string DoNotCallOverridableMethodsInConstructors
- public static const string DoNotCatchGeneralExceptionTypes
- public static const string DoNotDeclareReadOnlyMutableReferenceTypes
- public static const string DoNotDeclareVisibleInstanceFields
- public static const string DoNotIgnoreMethodResults
- public static const string DoNotIndirectlyExposeMethodsWithLinkDemands
- public static const string DoNotLockOnObjectsWithWeakIdentity
- public static const string DoNotPassLiteralsAsLocalizedParameters
- public static const string DoNotRaiseReservedExceptionTypes
- public static const string EnumsShouldHaveZeroValue
- public static const string FlagsEnumsShouldHavePluralNames
- public static const string GenericMethodsShouldProvideTypeParameter
- public static const string IdentifiersShouldBeSpelledCorrectly
- public static const string IdentifiersShouldHaveCorrectSuffix
- public static const string IdentifiersShouldNotContainTypeNames
- public static const string IdentifiersShouldNotHaveIncorrectSuffix
- public static const string IdentifiersShouldNotMatchKeywords
- public static const string ImplementStandardExceptionConstructors
- public static const string InitializeReferenceTypeStaticFieldsInline
- public static const string InstantiateArgumentExceptionsCorrectly
- public static const string InterfaceMethodsShouldBeCallableByChildTypes
- public static const string InvariantAssertRule
- public static const string IsFatalRule
- public static const string MarkISerializableTypesWithSerializable
- public static const string MarkMembersAsStatic
- public static const string NestedTypesShouldNotBeVisible
- public static const string NormalizeStringsToUppercase
- public static const string OperatorOverloadsHaveNamedAlternates
- public static const string PropertyExternalTypesMustBeKnown
- public static const string PropertyNamesShouldNotMatchGetMethods
- public static const string PropertyTypesMustBeXamlVisible
- public static const string ReplaceRepetitiveArgumentsWithParamsArray
- public static const string ResourceStringsShouldBeSpelledCorrectly
- public static const string ReviewSuppressUnmanagedCodeSecurityUsage
- public static const string ReviewUnusedParameters
- public static const string SecureAsserts
- public static const string SecureGetObjectDataOverrides
- public static const string ShortAcronymsShouldBeUppercase
- public static const string SpecifyIFormatProvider
- public static const string SpecifyMarshalingForPInvokeStringArguments
- public static const string StaticHolderTypesShouldNotHaveConstructors
- public static const string SystemAndMicrosoftNamespacesRequireApproval
- public static const string ThunkCallbackRule
- public static const string TransparentMethodsMustNotReferenceCriticalCode
- public static const string TypeConvertersMustBePublic
- public static const string TypeNamesShouldNotMatchNamespaces
- public static const string TypesMustHaveXamlCallableConstructors
- public static const string TypesShouldHavePublicParameterlessConstructors
- public static const string UriPropertiesShouldNotBeStrings
- public static const string UseEventsWhereAppropriate
- public static const string UseNewGuidHelperRule
- public static const string UsePropertiesWhereAppropriate
- public static const string VariableNamesShouldNotMatchFieldNames
- public static const string WrapExceptionsRule

### internal class System.Runtime.ScheduleActionItemAsyncResult
- Base: System.Runtime.AsyncResult
- Interfaces: System.IAsyncResult

#### Fields
- private static System.Action<object> doWork

#### Constructors
- private static ScheduleActionItemAsyncResult()
- protected ScheduleActionItemAsyncResult(System.AsyncCallback callback, object state)

#### Methods
- private static void DoWork(object state)
- public static void End(System.IAsyncResult result)
- protected abstract void OnDoWork()
- protected void Schedule()

### private class System.Runtime.IOThreadScheduler.ScheduledOverlapped

#### Fields
- private readonly System.Threading.NativeOverlapped* nativeOverlapped
- private System.Runtime.IOThreadScheduler scheduler

#### Constructors
- public IOThreadScheduler.ScheduledOverlapped()

#### Methods
- public void Cleanup()
- private void IOCallback(uint errorCode, uint numBytes, System.Threading.NativeOverlapped* nativeOverlapped)
- public void Post(System.Runtime.IOThreadScheduler iots)

### public class System.Runtime.Fx.Tag.SecurityNoteAttribute
- Base: System.Attribute

#### Fields
- private string <Critical>k__BackingField
- private string <Miscellaneous>k__BackingField
- private string <Safe>k__BackingField

#### Properties
- public string Critical { get; set; }
- public string Miscellaneous { get; set; }
- public string Safe { get; set; }

#### Constructors
- public Fx.Tag.SecurityNoteAttribute()

### private class System.Runtime.Fx.SendOrPostThunk
- Base: System.Runtime.Fx.Thunk<System.Threading.SendOrPostCallback>

#### Properties
- public System.Threading.SendOrPostCallback ThunkFrame { get; }

#### Constructors
- public Fx.SendOrPostThunk(System.Threading.SendOrPostCallback callback)

#### Methods
- private void UnhandledExceptionFrame(object state)

### internal class System.Runtime.SignalGate

#### Fields
- private int state

#### Properties
- internal bool IsLocked { get; }
- internal bool IsSignalled { get; }

#### Constructors
- public SignalGate()

#### Methods
- public bool Signal()
- private void ThrowInvalidSignalGateState()
- public bool Unlock()

### internal class System.Runtime.SignalGate<T>
- Base: System.Runtime.SignalGate

#### Fields
- private T result

#### Constructors
- public SignalGate<T>()

#### Methods
- public bool Signal(T result)
- public bool Unlock(out T result)

### private struct System.Runtime.IOThreadScheduler.Slot

#### Fields
- private System.Action<object> callback
- private int gate
- private object state

#### Methods
- public void DequeueWorkItem(out System.Action<object> callback, out object state)
- public bool TryEnqueueWorkItem(System.Action<object> callback, object state, out bool wrapped)

### public static class System.Runtime.Fx.Tag.Strings

#### Fields
- internal static const string AppDomain
- internal static const string DeclaringInstance
- internal static const string ExternallyManaged
- internal static const string Infinite
- internal static const string Unbounded

### public enum System.Runtime.Fx.Tag.SynchronizationKind
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FromFieldType = 5
- InterlockedNoSpin = 3
- InterlockedWithSpin = 4
- LockStatement = 0
- MonitorExplicit = 2
- MonitorWait = 1

### public class System.Runtime.Fx.Tag.SynchronizationObjectAttribute
- Base: System.Attribute

#### Fields
- private bool <Blocking>k__BackingField
- private System.Runtime.Fx.Tag.SynchronizationKind <Kind>k__BackingField
- private string <Scope>k__BackingField

#### Properties
- public bool Blocking { get; set; }
- public System.Runtime.Fx.Tag.SynchronizationKind Kind { get; set; }
- public string Scope { get; set; }

#### Constructors
- public Fx.Tag.SynchronizationObjectAttribute()

### public class System.Runtime.Fx.Tag.SynchronizationPrimitiveAttribute
- Base: System.Attribute

#### Fields
- private string <ReleaseMethod>k__BackingField
- private bool <Spins>k__BackingField
- private bool <SupportsAsync>k__BackingField
- private readonly System.Runtime.Fx.Tag.BlocksUsing blocksUsing

#### Properties
- public System.Runtime.Fx.Tag.BlocksUsing BlocksUsing { get; }
- public string ReleaseMethod { get; set; }
- public bool Spins { get; set; }
- public bool SupportsAsync { get; set; }

#### Constructors
- public Fx.Tag.SynchronizationPrimitiveAttribute(System.Runtime.Fx.Tag.BlocksUsing blocksUsing)

### private class System.Runtime.InternalBufferManager.PooledBufferManager.BufferPool.SynchronizedBufferPool
- Base: System.Runtime.InternalBufferManager.PooledBufferManager.BufferPool

#### Fields
- private System.Runtime.SynchronizedPool<byte[]> innerPool

#### Constructors
- internal InternalBufferManager.PooledBufferManager.BufferPool.SynchronizedBufferPool(int bufferSize, int limit)

#### Methods
- internal override void OnClear()
- internal override bool Return(byte[] buffer)
- internal override byte[] Take()

### private static class System.Runtime.SynchronizedPool<T>.SynchronizedPoolHelper<T>

#### Fields
- public static readonly int ProcessorCount

#### Constructors
- private static SynchronizedPool<T>.SynchronizedPoolHelper<T>()

#### Methods
- private static int GetProcessorCount()

### internal class System.Runtime.SynchronizedPool<T>

#### Fields
- private System.Runtime.SynchronizedPool<T>.Entry<T>[] entries
- private System.Runtime.SynchronizedPool<T>.GlobalPool<T> globalPool
- private int maxCount
- private static const int maxPendingEntries
- private static const int maxPromotionFailures
- private static const int maxReturnsBeforePromotion
- private static const int maxThreadItemsPerProcessor
- private System.Runtime.SynchronizedPool<T>.PendingEntry<T>[] pending
- private int promotionFailures

#### Properties
- private object ThisLock { get; }

#### Constructors
- public SynchronizedPool<T>(int maxCount)

#### Methods
- public void Clear()
- private void HandlePromotionFailure(int thisThreadID)
- private bool PromoteThread(int thisThreadID)
- private void RecordReturnToGlobalPool(int thisThreadID)
- private void RecordTakeFromGlobalPool(int thisThreadID)
- public bool Return(T value)
- private bool ReturnToGlobalPool(int thisThreadID, T value)
- private bool ReturnToPerThreadPool(int thisThreadID, T value)
- public T Take()
- private T TakeFromGlobalPool(int thisThreadID)
- private T TakeFromPerThreadPool(int thisThreadID)

### public static class System.Runtime.Fx.Tag

### internal static class System.Runtime.TaskExtensions

#### Methods
- public static System.IAsyncResult AsAsyncResult<T>(System.Threading.Tasks.Task<T> task, System.AsyncCallback callback, object state)
- public static System.IAsyncResult AsAsyncResult(System.Threading.Tasks.Task task, System.AsyncCallback callback, object state)
- public static System.Runtime.CompilerServices.ConfiguredTaskAwaitable ContinueOnCapturedContextFlow(System.Threading.Tasks.Task task)
- public static System.Runtime.CompilerServices.ConfiguredTaskAwaitable<T> ContinueOnCapturedContextFlow<T>(System.Threading.Tasks.Task<T> task)
- public static System.Runtime.CompilerServices.ConfiguredTaskAwaitable SuppressContextFlow(System.Threading.Tasks.Task task)
- public static System.Runtime.CompilerServices.ConfiguredTaskAwaitable<T> SuppressContextFlow<T>(System.Threading.Tasks.Task<T> task)
- public static System.Threading.Tasks.Task<TBase> Upcast<TDerived, TBase>(System.Threading.Tasks.Task<TDerived> task)
- private static System.Threading.Tasks.Task<TBase> UpcastPrivate<TDerived, TBase>(System.Threading.Tasks.Task<TDerived> task)
- public static void Wait<TException>(System.Threading.Tasks.Task task)
- public static bool Wait<TException>(System.Threading.Tasks.Task task, int millisecondsTimeout)
- public static bool Wait<TException>(System.Threading.Tasks.Task task, System.TimeSpan timeout)
- public static void Wait(System.Threading.Tasks.Task task, System.TimeSpan timeout, System.Action<System.Exception, System.TimeSpan, string> exceptionConverter, string operationType)

### internal class System.Runtime.ThreadNeutralSemaphore

#### Fields
- private bool aborted
- private System.Func<System.Exception> abortedExceptionGenerator
- private int count
- private static System.Action<object, System.TimeoutException> enteredAsyncCallback
- private int maxCount
- private object ThisLock
- private System.Collections.Generic.Queue<System.Runtime.AsyncWaitHandle> waiters

#### Properties
- private static System.Action<object, System.TimeoutException> EnteredAsyncCallback { get; }
- private System.Collections.Generic.Queue<System.Runtime.AsyncWaitHandle> Waiters { get; }

#### Constructors
- public ThreadNeutralSemaphore(int maxCount)
- public ThreadNeutralSemaphore(int maxCount, System.Func<System.Exception> abortedExceptionGenerator)

#### Methods
- public void Abort()
- internal static System.TimeoutException CreateEnterTimedOutException(System.TimeSpan timeout)
- private System.Exception CreateObjectAbortedException()
- public void Enter(System.TimeSpan timeout)
- public bool EnterAsync(System.TimeSpan timeout, System.Runtime.FastAsyncCallback callback, object state)
- private System.Runtime.AsyncWaitHandle EnterCore()
- public int Exit()
- private static void OnEnteredAsync(object state, System.TimeoutException exception)
- private bool RemoveWaiter(System.Runtime.AsyncWaitHandle waiter)
- public bool TryEnter()
- public bool TryEnter(System.TimeSpan timeout)

### public enum System.Runtime.Fx.Tag.ThrottleAction
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Pause = 1
- Reject = 0

### public class System.Runtime.Fx.Tag.ThrottleAttribute
- Base: System.Attribute

#### Fields
- private string <Scope>k__BackingField
- private readonly string limit
- private readonly System.Runtime.Fx.Tag.ThrottleAction throttleAction
- private readonly System.Runtime.Fx.Tag.ThrottleMetric throttleMetric

#### Properties
- public string Limit { get; }
- public string Scope { get; set; }
- public System.Runtime.Fx.Tag.ThrottleAction ThrottleAction { get; }
- public System.Runtime.Fx.Tag.ThrottleMetric ThrottleMetric { get; }

#### Constructors
- public Fx.Tag.ThrottleAttribute(System.Runtime.Fx.Tag.ThrottleAction throttleAction, System.Runtime.Fx.Tag.ThrottleMetric throttleMetric, string limit)

### public enum System.Runtime.Fx.Tag.ThrottleMetric
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Count = 0
- Other = 2
- Rate = 1

### public static class System.Runtime.Fx.Tag.Throws

### public class System.Runtime.Fx.Tag.ThrowsAttribute
- Base: System.Attribute

#### Fields
- private readonly string diagnosis
- private readonly System.Type exceptionType

#### Properties
- public string Diagnosis { get; }
- public System.Type ExceptionType { get; }

#### Constructors
- public Fx.Tag.ThrowsAttribute(System.Type exceptionType, string diagnosis)

### private class System.Runtime.Fx.Thunk<T>

#### Fields
- private T callback

#### Properties
- internal T Callback { get; }

#### Constructors
- protected Fx.Thunk<T>(T callback)

### internal static class System.Runtime.Ticks

#### Properties
- public static long Now { get; }

#### Methods
- public static long Add(long firstTicks, long secondTicks)
- public static long FromMilliseconds(int milliseconds)
- public static long FromTimeSpan(System.TimeSpan duration)
- public static int ToMilliseconds(long ticks)
- public static System.TimeSpan ToTimeSpan(long ticks)

### public class System.Runtime.Fx.Tag.Throws.TimeoutAttribute
- Base: System.Runtime.Fx.Tag.ThrowsAttribute

#### Constructors
- public Fx.Tag.Throws.TimeoutAttribute()
- public Fx.Tag.Throws.TimeoutAttribute(string diagnosis)

### internal struct System.Runtime.TimeoutHelper

#### Fields
- private System.DateTime deadline
- private bool deadlineSet
- public static readonly System.TimeSpan MaxWait
- private System.TimeSpan originalTimeout

#### Properties
- public System.TimeSpan OriginalTimeout { get; }

#### Constructors
- private static TimeoutHelper()
- public TimeoutHelper(System.TimeSpan timeout)

#### Methods
- public static System.TimeSpan Add(System.TimeSpan timeout1, System.TimeSpan timeout2)
- public static System.DateTime Add(System.DateTime time, System.TimeSpan timeout)
- public static System.TimeSpan Divide(System.TimeSpan timeout, int factor)
- public System.TimeSpan ElapsedTime()
- public static System.TimeSpan FromMilliseconds(int milliseconds)
- public static bool IsTooLarge(System.TimeSpan timeout)
- public static System.TimeSpan Min(System.TimeSpan val1, System.TimeSpan val2)
- public System.TimeSpan RemainingTime()
- private void SetDeadline()
- public static System.DateTime Subtract(System.DateTime time, System.TimeSpan timeout)
- public static void ThrowIfNegativeArgument(System.TimeSpan timeout)
- public static void ThrowIfNegativeArgument(System.TimeSpan timeout, string argumentName)
- public static void ThrowIfNonPositiveArgument(System.TimeSpan timeout)
- public static void ThrowIfNonPositiveArgument(System.TimeSpan timeout, string argumentName)
- public static int ToMilliseconds(System.TimeSpan timeout)
- public static bool WaitOne(System.Threading.WaitHandle waitHandle, System.TimeSpan timeout)

### private class System.Runtime.IOThreadTimer.TimerGroup

#### Fields
- private System.Runtime.IOThreadTimer.TimerQueue timerQueue
- private System.Runtime.IOThreadTimer.WaitableTimer waitableTimer

#### Properties
- public System.Runtime.IOThreadTimer.TimerQueue TimerQueue { get; }
- public System.Runtime.IOThreadTimer.WaitableTimer WaitableTimer { get; }

#### Constructors
- public IOThreadTimer.TimerGroup()

### private static class System.Runtime.IOThreadTimer.WaitableTimer.TimerHelper

#### Methods
- public static Microsoft.Win32.SafeHandles.SafeWaitHandle CreateWaitableTimer()
- public static long Set(Microsoft.Win32.SafeHandles.SafeWaitHandle timer, long dueTime)

### private class System.Runtime.IOThreadTimer.TimerManager

#### Fields
- private static const long maxTimeToWaitForMoreTimers
- private System.Action<object> onWaitCallback
- private System.Runtime.IOThreadTimer.TimerGroup stableTimerGroup
- private static System.Runtime.IOThreadTimer.TimerManager value
- private System.Runtime.IOThreadTimer.TimerGroup volatileTimerGroup
- private System.Runtime.IOThreadTimer.WaitableTimer[] waitableTimers
- private bool waitScheduled

#### Properties
- public System.Runtime.IOThreadTimer.TimerGroup StableTimerGroup { get; }
- private object ThisLock { get; }
- public static System.Runtime.IOThreadTimer.TimerManager Value { get; }
- public System.Runtime.IOThreadTimer.TimerGroup VolatileTimerGroup { get; }

#### Constructors
- public IOThreadTimer.TimerManager()
- private static IOThreadTimer.TimerManager()

#### Methods
- public bool Cancel(System.Runtime.IOThreadTimer timer)
- private void EnsureWaitScheduled()
- private System.Runtime.IOThreadTimer.TimerGroup GetOtherTimerGroup(System.Runtime.IOThreadTimer.TimerGroup timerGroup)
- private void OnWaitCallback(object state)
- private void ReactivateWaitableTimer(System.Runtime.IOThreadTimer.TimerGroup timerGroup)
- private void ReactivateWaitableTimers()
- private void ScheduleElapsedTimers(long now)
- private void ScheduleElapsedTimers(System.Runtime.IOThreadTimer.TimerGroup timerGroup, long now)
- private void ScheduleWait()
- private void ScheduleWaitIfAnyTimersLeft()
- public void Set(System.Runtime.IOThreadTimer timer, long dueTime)
- private void UpdateWaitableTimer(System.Runtime.IOThreadTimer.TimerGroup timerGroup)

### private class System.Runtime.IOThreadTimer.TimerQueue

#### Fields
- private int count
- private System.Runtime.IOThreadTimer[] timers

#### Properties
- public int Count { get; }
- public System.Runtime.IOThreadTimer MinTimer { get; }

#### Constructors
- public IOThreadTimer.TimerQueue()

#### Methods
- public void DeleteMinTimer()
- private void DeleteMinTimerCore()
- public void DeleteTimer(System.Runtime.IOThreadTimer timer)
- public bool InsertTimer(System.Runtime.IOThreadTimer timer, long dueTime)
- public bool UpdateTimer(System.Runtime.IOThreadTimer timer, long dueTime)

### private class System.Runtime.Fx.TimerThunk
- Base: System.Runtime.Fx.Thunk<System.Threading.TimerCallback>

#### Properties
- public System.Threading.TimerCallback ThunkFrame { get; }

#### Constructors
- public Fx.TimerThunk(System.Threading.TimerCallback callback)

#### Methods
- private void UnhandledExceptionFrame(object state)

### internal enum System.Runtime.TraceChannel
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Admin = 16
- Analytic = 18
- Application = 9
- Debug = 19
- Operational = 17
- Perf = 20

### internal class System.Runtime.TraceCore

#### Fields
- private static System.Runtime.Diagnostics.EventDescriptor[] eventDescriptors
- private static bool eventDescriptorsCreated
- private static System.Globalization.CultureInfo resourceCulture
- private static System.Resources.ResourceManager resourceManager
- private static object syncLock

#### Properties
- internal static System.Globalization.CultureInfo Culture { get; set; }
- private static System.Resources.ResourceManager ResourceManager { get; }

#### Constructors
- private TraceCore()
- private static TraceCore()

#### Methods
- internal static void ActionItemCallbackInvoked(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity)
- internal static bool ActionItemCallbackInvokedIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace)
- internal static void ActionItemScheduled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity)
- internal static bool ActionItemScheduledIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace)
- internal static void AppDomainUnload(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string appdomainName, string processName, string processId)
- internal static bool AppDomainUnloadIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace)
- internal static void BufferPoolAllocation(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, int Size)
- internal static bool BufferPoolAllocationIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace)
- internal static void BufferPoolChangeQuota(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, int PoolSize, int Delta)
- internal static bool BufferPoolChangeQuotaIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace)
- private static void CreateEventDescriptors()
- private static void EnsureEventDescriptors()
- internal static void EtwUnhandledException(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0, System.Exception exception)
- internal static bool EtwUnhandledExceptionIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace)
- internal static void HandledException(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0, System.Exception exception)
- internal static void HandledExceptionError(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0, System.Exception exception)
- internal static bool HandledExceptionErrorIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace)
- internal static bool HandledExceptionIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace)
- internal static void HandledExceptionVerbose(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0, System.Exception exception)
- internal static bool HandledExceptionVerboseIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace)
- internal static void HandledExceptionWarning(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0, System.Exception exception)
- internal static bool HandledExceptionWarningIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace)
- private static bool IsEtwEventEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, int eventIndex)
- internal static void ShipAssertExceptionMessage(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0)
- internal static bool ShipAssertExceptionMessageIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace)
- internal static void ThrowingEtwException(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0, string param1, System.Exception exception)
- internal static bool ThrowingEtwExceptionIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace)
- internal static void ThrowingEtwExceptionVerbose(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0, string param1, System.Exception exception)
- internal static bool ThrowingEtwExceptionVerboseIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace)
- internal static void ThrowingException(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0, string param1, System.Exception exception)
- internal static bool ThrowingExceptionIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace)
- internal static void ThrowingExceptionVerbose(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0, string param1, System.Exception exception)
- internal static bool ThrowingExceptionVerboseIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace)
- internal static void TraceCodeEventLogCritical(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, System.Runtime.Diagnostics.TraceRecord traceRecord)
- internal static bool TraceCodeEventLogCriticalIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace)
- internal static void TraceCodeEventLogError(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, System.Runtime.Diagnostics.TraceRecord traceRecord)
- internal static bool TraceCodeEventLogErrorIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace)
- internal static void TraceCodeEventLogInfo(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, System.Runtime.Diagnostics.TraceRecord traceRecord)
- internal static bool TraceCodeEventLogInfoIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace)
- internal static void TraceCodeEventLogVerbose(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, System.Runtime.Diagnostics.TraceRecord traceRecord)
- internal static bool TraceCodeEventLogVerboseIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace)
- internal static void TraceCodeEventLogWarning(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, System.Runtime.Diagnostics.TraceRecord traceRecord)
- internal static bool TraceCodeEventLogWarningIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace)
- internal static void UnhandledException(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0, System.Exception exception)
- internal static bool UnhandledExceptionIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace)
- private static bool WriteEtwEvent(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, string eventParam1, string eventParam2, string eventParam3, string eventParam4)
- private static bool WriteEtwEvent(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, string eventParam1, string eventParam2, string eventParam3)
- private static bool WriteEtwEvent(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, string eventParam1, string eventParam2)
- private static bool WriteEtwEvent(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, int eventParam1, string eventParam2)
- private static bool WriteEtwEvent(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, int eventParam1, int eventParam2, string eventParam3)
- private static bool WriteEtwEvent(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, string eventParam1)
- private static void WriteTraceSource(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, int eventIndex, string description, System.Runtime.TracePayload payload)

### internal enum System.Runtime.TraceEventLevel
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Critical = 1
- Error = 2
- Informational = 4
- LogAlways = 0
- Verbose = 5
- Warning = 3

### internal enum System.Runtime.TraceEventOpcode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Info = 0
- Receive = 240
- Reply = 6
- Resume = 7
- Send = 9
- Start = 1
- Stop = 2
- Suspend = 8

### internal class System.Runtime.TraceLevelHelper

#### Fields
- private static System.Diagnostics.TraceEventType[] EtwLevelToTraceEventType

#### Constructors
- public TraceLevelHelper()
- private static TraceLevelHelper()

#### Methods
- internal static System.Diagnostics.TraceEventType GetTraceEventType(byte level, byte opcode)
- internal static System.Diagnostics.TraceEventType GetTraceEventType(System.Runtime.TraceEventLevel level)
- internal static System.Diagnostics.TraceEventType GetTraceEventType(byte level)
- internal static string LookupSeverity(System.Runtime.TraceEventLevel level, System.Runtime.TraceEventOpcode opcode)

### internal struct System.Runtime.TracePayload

#### Fields
- private string appDomainFriendlyName
- private string eventSource
- private string extendedData
- private string hostReference
- private string serializedException

#### Properties
- public string AppDomainFriendlyName { get; }
- public string EventSource { get; }
- public string ExtendedData { get; }
- public string HostReference { get; }
- public string SerializedException { get; }

#### Constructors
- public TracePayload(string serializedException, string eventSource, string appDomainFriendlyName, string extendedData, string hostReference)

### internal class System.Runtime.TypedAsyncResult<T>
- Base: System.Runtime.AsyncResult
- Interfaces: System.IAsyncResult

#### Fields
- private T data

#### Properties
- public T Data { get; }

#### Constructors
- public TypedAsyncResult<T>(System.AsyncCallback callback, object state)

#### Methods
- protected void Complete(T data, bool completedSynchronously)
- public static T End(System.IAsyncResult result)

### internal static class System.Runtime.TypeHelper

#### Fields
- public static readonly System.Type ArrayType
- public static readonly System.Type BoolType
- public static readonly System.Type ByteType
- public static readonly System.Type CharType
- public static readonly System.Type DecimalType
- public static readonly System.Type DoubleType
- public static readonly System.Type ExceptionType
- public static readonly System.Type FloatType
- public static readonly System.Type GenericCollectionType
- public static readonly System.Type IntType
- public static readonly System.Type LongType
- public static readonly System.Type NullableType
- public static readonly System.Type ObjectType
- public static readonly System.Type SByteType
- public static readonly System.Type ShortType
- public static readonly System.Type StringType
- public static readonly System.Type TypeType
- public static readonly System.Type UIntType
- public static readonly System.Type ULongType
- public static readonly System.Type UShortType
- public static readonly System.Type VoidType

#### Constructors
- private static TypeHelper()

#### Methods
- public static bool AreReferenceTypesCompatible(System.Type sourceType, System.Type destinationType)
- public static bool AreTypesCompatible(object source, System.Type destinationType)
- public static bool AreTypesCompatible(System.Type sourceType, System.Type destinationType)
- public static bool ContainsCompatibleType(System.Collections.Generic.IEnumerable<System.Type> enumerable, System.Type targetType)
- public static T Convert<T>(object source)
- public static System.Collections.Generic.IEnumerable<System.Type> GetCompatibleTypes(System.Collections.Generic.IEnumerable<System.Type> enumerable, System.Type targetType)
- public static object GetDefaultValueForType(System.Type type)
- public static System.Collections.Generic.IEnumerable<System.Type> GetImplementedTypes(System.Type type)
- private static void GetImplementedTypesHelper(System.Type type, System.Collections.Generic.Dictionary<System.Type, object> typesEncountered)
- private static bool IsImplicitBoxingConversion(System.Type sourceType, System.Type destinationType)
- private static bool IsImplicitNullableConversion(System.Type sourceType, System.Type destinationType)
- private static bool IsImplicitNumericConversion(System.Type source, System.Type destination)
- private static bool IsImplicitReferenceConversion(System.Type sourceType, System.Type destinationType)
- public static bool IsNonNullableValueType(System.Type type)
- private static bool IsNullableType(System.Type type)
- public static bool IsNullableValueType(System.Type type)
- public static bool ShouldFilterProperty(System.ComponentModel.PropertyDescriptor property, System.Attribute[] attributes)
- private static bool TryNumericConversion<T>(object source, out T result)

### private class System.Runtime.UrlUtility.UrlDecoder

#### Fields
- private int _bufferSize
- private byte[] _byteBuffer
- private char[] _charBuffer
- private System.Text.Encoding _encoding
- private int _numBytes
- private int _numChars

#### Constructors
- internal UrlUtility.UrlDecoder(int bufferSize, System.Text.Encoding encoding)

#### Methods
- internal void AddByte(byte b)
- internal void AddChar(char ch)
- private void FlushBytes()
- internal string GetString()

### internal static class System.Runtime.UrlUtility

#### Methods
- private static int HexToInt(char h)
- private static char IntToHex(int n)
- private static bool IsNonAsciiByte(byte b)
- internal static bool IsSafe(char ch)
- public static System.Collections.Specialized.NameValueCollection ParseQueryString(string query)
- public static System.Collections.Specialized.NameValueCollection ParseQueryString(string query, System.Text.Encoding encoding)
- public static string UrlDecode(string str, System.Text.Encoding e)
- private static string UrlDecodeStringFromStringInternal(string s, System.Text.Encoding e)
- public static string UrlEncode(string str)
- public static string UrlEncode(string str, System.Text.Encoding encoding)
- private static byte[] UrlEncodeBytesToBytesInternal(byte[] bytes, int offset, int count, bool alwaysCreateReturnValue)
- private static byte[] UrlEncodeBytesToBytesInternalNonAscii(byte[] bytes, int offset, int count, bool alwaysCreateReturnValue)
- private static string UrlEncodeNonAscii(string str, System.Text.Encoding e)
- private static string UrlEncodeSpaces(string str)
- public static byte[] UrlEncodeToBytes(string str, System.Text.Encoding e)
- public static string UrlEncodeUnicode(string str)
- private static string UrlEncodeUnicodeStringToStringInternal(string s, bool ignoreAscii)
- public static string UrlPathEncode(string str)

### private class System.Runtime.IOThreadTimer.WaitableTimer
- Base: System.Threading.WaitHandle
- Interfaces: System.IDisposable

#### Fields
- private long dueTime

#### Properties
- public long DueTime { get; }

#### Constructors
- public IOThreadTimer.WaitableTimer()

#### Methods
- public void Set(long dueTime)

### internal static class System.Runtime.WaitCallbackActionItem

#### Fields
- private static bool <ShouldUseActivity>k__BackingField

#### Properties
- internal static bool ShouldUseActivity { get; set; }

### private class System.Runtime.Fx.WaitOrTimerThunk
- Base: System.Runtime.Fx.Thunk<System.Threading.WaitOrTimerCallback>

#### Properties
- public System.Threading.WaitOrTimerCallback ThunkFrame { get; }

#### Constructors
- public Fx.WaitOrTimerThunk(System.Threading.WaitOrTimerCallback callback)

#### Methods
- private void UnhandledExceptionFrame(object state, bool timedOut)

### private class System.Runtime.InputQueue<T>.WaitQueueReader<T>
- Interfaces: System.Runtime.InputQueue<T>.IQueueReader<T>

#### Fields
- private System.Exception exception
- private System.Runtime.InputQueue<T> inputQueue
- private T item
- private System.Threading.ManualResetEvent waitEvent

#### Constructors
- public InputQueue<T>.WaitQueueReader<T>(System.Runtime.InputQueue<T> inputQueue)

#### Methods
- public void Set(System.Runtime.InputQueue<T>.Item<T> item)
- public bool Wait(System.TimeSpan timeout, out T value)

### private class System.Runtime.InputQueue<T>.WaitQueueWaiter<T>
- Interfaces: System.Runtime.InputQueue<T>.IQueueWaiter<T>

#### Fields
- private bool itemAvailable
- private System.Threading.ManualResetEvent waitEvent

#### Constructors
- public InputQueue<T>.WaitQueueWaiter<T>()

#### Methods
- public void Set(bool itemAvailable)
- public bool Wait(System.TimeSpan timeout)

### private class System.Runtime.Fx.WaitThunk
- Base: System.Runtime.Fx.Thunk<System.Threading.WaitCallback>

#### Properties
- public System.Threading.WaitCallback ThunkFrame { get; }

#### Constructors
- public Fx.WaitThunk(System.Threading.WaitCallback callback)

#### Methods
- private void UnhandledExceptionFrame(object state)

### public class System.Runtime.Fx.Tag.XamlVisibleAttribute
- Base: System.Attribute

#### Fields
- private bool <Visible>k__BackingField

#### Properties
- public bool Visible { get; private set; }

#### Constructors
- public Fx.Tag.XamlVisibleAttribute()
- public Fx.Tag.XamlVisibleAttribute(bool visible)

## Namespace: System.Runtime.Collections

### private class System.Runtime.Collections.NullableKeyDictionary<TKey, TValue>.NullKeyDictionaryKeyCollection<TKey, TValue, TypeKey, TypeValue>.<GetEnumerator>d__11<TKey, TValue, TypeKey, TypeValue>
- Interfaces: System.Collections.Generic.IEnumerator<TypeKey>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private TypeKey <>2__current
- public System.Runtime.Collections.NullableKeyDictionary<TKey, TValue>.NullKeyDictionaryKeyCollection<TKey, TValue, TypeKey, TypeValue> <>4__this
- private System.Collections.Generic.IEnumerator<TypeKey> <>7__wrap1

#### Properties
- private TypeKey System.Collections.Generic.IEnumerator<TypeKey>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public NullableKeyDictionary<TKey, TValue>.NullKeyDictionaryKeyCollection<TKey, TValue, TypeKey, TypeValue>.<GetEnumerator>d__11<TKey, TValue, TypeKey, TypeValue>(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class System.Runtime.Collections.NullableKeyDictionary<TKey, TValue>.NullKeyDictionaryValueCollection<TKey, TValue, TypeKey, TypeValue>.<GetEnumerator>d__11<TKey, TValue, TypeKey, TypeValue>
- Interfaces: System.Collections.Generic.IEnumerator<TypeValue>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private TypeValue <>2__current
- public System.Runtime.Collections.NullableKeyDictionary<TKey, TValue>.NullKeyDictionaryValueCollection<TKey, TValue, TypeKey, TypeValue> <>4__this
- private System.Collections.Generic.IEnumerator<TypeValue> <>7__wrap1

#### Properties
- private TypeValue System.Collections.Generic.IEnumerator<TypeValue>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public NullableKeyDictionary<TKey, TValue>.NullKeyDictionaryValueCollection<TKey, TValue, TypeKey, TypeValue>.<GetEnumerator>d__11<TKey, TValue, TypeKey, TypeValue>(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class System.Runtime.Collections.OrderedDictionary<TKey, TValue>.<GetEnumerator>d__20<TKey, TValue>
- Interfaces: System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private System.Collections.Generic.KeyValuePair<TKey, TValue> <>2__current
- public System.Runtime.Collections.OrderedDictionary<TKey, TValue> <>4__this
- private System.Collections.IDictionaryEnumerator <>7__wrap1

#### Properties
- private System.Collections.Generic.KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public OrderedDictionary<TKey, TValue>.<GetEnumerator>d__20<TKey, TValue>(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class System.Runtime.Collections.NullableKeyDictionary<TKey, TValue>.<GetEnumerator>d__24<TKey, TValue>
- Interfaces: System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private System.Collections.Generic.KeyValuePair<TKey, TValue> <>2__current
- public System.Runtime.Collections.NullableKeyDictionary<TKey, TValue> <>4__this
- private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> <innerEnumerator>5__2

#### Properties
- private System.Collections.Generic.KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public NullableKeyDictionary<TKey, TValue>.<GetEnumerator>d__24<TKey, TValue>(int <>1__state)

#### Methods
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### internal class System.Runtime.Collections.HopperCache

#### Fields
- private readonly int hopperSize
- private System.Collections.Hashtable limitedHopper
- private System.Runtime.Collections.HopperCache.LastHolder mruEntry
- private System.Collections.Hashtable outstandingHopper
- private int promoting
- private System.Collections.Hashtable strongHopper
- private readonly bool weak

#### Constructors
- public HopperCache(int hopperSize, bool weak)

#### Methods
- public void Add(object key, object value)
- public object GetValue(object syncObject, object key)

### private class System.Runtime.Collections.ObjectCache<TKey, TValue>.Item<TKey, TValue>
- Base: System.Runtime.Collections.ObjectCacheItem<TValue>

#### Fields
- private System.DateTime <CreationTime>k__BackingField
- private System.DateTime <LastUsage>k__BackingField
- private readonly System.Action<TValue> disposeItemCallback
- private readonly TKey key
- private readonly System.Runtime.Collections.ObjectCache<TKey, TValue> parent
- private int referenceCount
- private TValue value

#### Properties
- public System.DateTime CreationTime { get; set; }
- public System.DateTime LastUsage { get; set; }
- public int ReferenceCount { get; }
- public TValue Value { get; }

#### Constructors
- private ObjectCache<TKey, TValue>.Item<TKey, TValue>(TKey key, TValue value)
- public ObjectCache<TKey, TValue>.Item<TKey, TValue>(TKey key, TValue value, System.Action<TValue> disposeItemCallback)
- public ObjectCache<TKey, TValue>.Item<TKey, TValue>(TKey key, TValue value, System.Runtime.Collections.ObjectCache<TKey, TValue> parent)

#### Methods
- public void Dispose()
- internal void InternalAddReference()
- internal void InternalReleaseReference()
- public void LocalDispose()
- public void LockedDispose()
- public override void ReleaseReference()
- public override bool TryAddReference()

### private class System.Runtime.Collections.HopperCache.LastHolder

#### Fields
- private readonly object key
- private readonly object value

#### Properties
- internal object Key { get; }
- internal object Value { get; }

#### Constructors
- internal HopperCache.LastHolder(object key, object value)

### internal class System.Runtime.Collections.NullableKeyDictionary<TKey, TValue>
- Interfaces: System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable

#### Fields
- private System.Collections.Generic.IDictionary<TKey, TValue> innerDictionary
- private bool isNullKeyPresent
- private TValue nullKeyValue

#### Properties
- public int Count { get; }
- public bool IsReadOnly { get; }
- public TValue Item { get; set; }
- public System.Collections.Generic.ICollection<TKey> Keys { get; }
- public System.Collections.Generic.ICollection<TValue> Values { get; }

#### Constructors
- public NullableKeyDictionary<TKey, TValue>()

#### Methods
- public void Add(TKey key, TValue value)
- public void Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item)
- public void Clear()
- public bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item)
- public bool ContainsKey(TKey key)
- public void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int arrayIndex)
- public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator()
- public bool Remove(TKey key)
- public bool Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item)
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- public bool TryGetValue(TKey key, out TValue value)

### private class System.Runtime.Collections.NullableKeyDictionary<TKey, TValue>.NullKeyDictionaryKeyCollection<TKey, TValue, TypeKey, TypeValue>
- Interfaces: System.Collections.Generic.ICollection<TypeKey>, System.Collections.Generic.IEnumerable<TypeKey>, System.Collections.IEnumerable

#### Fields
- private System.Runtime.Collections.NullableKeyDictionary<TypeKey, TypeValue> nullKeyDictionary

#### Properties
- public int Count { get; }
- public bool IsReadOnly { get; }

#### Constructors
- public NullableKeyDictionary<TKey, TValue>.NullKeyDictionaryKeyCollection<TKey, TValue, TypeKey, TypeValue>(System.Runtime.Collections.NullableKeyDictionary<TypeKey, TypeValue> nullKeyDictionary)

#### Methods
- public void Add(TypeKey item)
- public void Clear()
- public bool Contains(TypeKey item)
- public void CopyTo(TypeKey[] array, int arrayIndex)
- public System.Collections.Generic.IEnumerator<TypeKey> GetEnumerator()
- public bool Remove(TypeKey item)
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()

### private class System.Runtime.Collections.NullableKeyDictionary<TKey, TValue>.NullKeyDictionaryValueCollection<TKey, TValue, TypeKey, TypeValue>
- Interfaces: System.Collections.Generic.ICollection<TypeValue>, System.Collections.Generic.IEnumerable<TypeValue>, System.Collections.IEnumerable

#### Fields
- private System.Runtime.Collections.NullableKeyDictionary<TypeKey, TypeValue> nullKeyDictionary

#### Properties
- public int Count { get; }
- public bool IsReadOnly { get; }

#### Constructors
- public NullableKeyDictionary<TKey, TValue>.NullKeyDictionaryValueCollection<TKey, TValue, TypeKey, TypeValue>(System.Runtime.Collections.NullableKeyDictionary<TypeKey, TypeValue> nullKeyDictionary)

#### Methods
- public void Add(TypeValue item)
- public void Clear()
- public bool Contains(TypeValue item)
- public void CopyTo(TypeValue[] array, int arrayIndex)
- public System.Collections.Generic.IEnumerator<TypeValue> GetEnumerator()
- public bool Remove(TypeValue item)
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()

### internal class System.Runtime.Collections.ObjectCacheItem<T>

#### Properties
- public T Value { get; }

#### Constructors
- protected ObjectCacheItem<T>()

#### Methods
- public abstract void ReleaseReference()
- public abstract bool TryAddReference()

### internal class System.Runtime.Collections.ObjectCacheSettings

#### Fields
- private int cacheLimit
- private static const int DefaultCacheLimit
- private static System.TimeSpan DefaultIdleTimeout
- private static System.TimeSpan DefaultLeaseTimeout
- private static const int DefaultPurgeFrequency
- private System.TimeSpan idleTimeout
- private System.TimeSpan leaseTimeout
- private int purgeFrequency

#### Properties
- public int CacheLimit { get; set; }
- public System.TimeSpan IdleTimeout { get; set; }
- public System.TimeSpan LeaseTimeout { get; set; }
- public int PurgeFrequency { get; set; }

#### Constructors
- public ObjectCacheSettings()
- private static ObjectCacheSettings()
- private ObjectCacheSettings(System.Runtime.Collections.ObjectCacheSettings other)

#### Methods
- internal System.Runtime.Collections.ObjectCacheSettings Clone()

### internal class System.Runtime.Collections.ObjectCache<TKey, TValue>

#### Fields
- private System.Action<TValue> <DisposeItemCallback>k__BackingField
- private System.Collections.Generic.Dictionary<TKey, System.Runtime.Collections.ObjectCache<TKey, TValue>.Item<TKey, TValue>> cacheItems
- private bool disposed
- private bool idleTimeoutEnabled
- private System.Runtime.IOThreadTimer idleTimer
- private bool leaseTimeoutEnabled
- private static System.Action<object> onIdle
- private System.Runtime.Collections.ObjectCacheSettings settings
- private static const int timerThreshold

#### Properties
- public int Count { get; }
- public System.Action<TValue> DisposeItemCallback { get; set; }
- private object ThisLock { get; }

#### Constructors
- public ObjectCache<TKey, TValue>(System.Runtime.Collections.ObjectCacheSettings settings)
- public ObjectCache<TKey, TValue>(System.Runtime.Collections.ObjectCacheSettings settings, System.Collections.Generic.IEqualityComparer<TKey> comparer)

#### Methods
- public System.Runtime.Collections.ObjectCacheItem<TValue> Add(TKey key, TValue value)
- private static void Add<T>(ref System.Collections.Generic.List<T> list, T item)
- public void Dispose()
- private void GatherExpiredItems(ref System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<TKey, System.Runtime.Collections.ObjectCache<TKey, TValue>.Item<TKey, TValue>>> expiredItems, bool calledFromTimer)
- private System.Runtime.Collections.ObjectCache<TKey, TValue>.Item<TKey, TValue> InternalAdd(TKey key, TValue value)
- private static void OnIdle(object state)
- private void PurgeCache(bool calledFromTimer)
- private bool Return(TKey key, System.Runtime.Collections.ObjectCache<TKey, TValue>.Item<TKey, TValue> cacheItem)
- private bool ShouldPurgeItem(System.Runtime.Collections.ObjectCache<TKey, TValue>.Item<TKey, TValue> cacheItem, System.DateTime now)
- private void StartTimerIfNecessary()
- public System.Runtime.Collections.ObjectCacheItem<TValue> Take(TKey key)
- public System.Runtime.Collections.ObjectCacheItem<TValue> Take(TKey key, System.Func<TValue> initializerDelegate)

### internal class System.Runtime.Collections.OrderedDictionary<TKey, TValue>
- Interfaces: System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.Collections.IDictionary, System.Collections.ICollection

#### Fields
- private System.Collections.Specialized.OrderedDictionary privateDictionary

#### Properties
- public int Count { get; }
- public bool IsReadOnly { get; }
- public TValue Item { get; set; }
- public System.Collections.Generic.ICollection<TKey> Keys { get; }
- private int System.Collections.ICollection.Count { get; }
- private bool System.Collections.ICollection.IsSynchronized { get; }
- private object System.Collections.ICollection.SyncRoot { get; }
- private bool System.Collections.IDictionary.IsFixedSize { get; }
- private bool System.Collections.IDictionary.IsReadOnly { get; }
- private object System.Collections.IDictionary.Item { get; set; }
- private System.Collections.ICollection System.Collections.IDictionary.Keys { get; }
- private System.Collections.ICollection System.Collections.IDictionary.Values { get; }
- public System.Collections.Generic.ICollection<TValue> Values { get; }

#### Constructors
- public OrderedDictionary<TKey, TValue>()
- public OrderedDictionary<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> dictionary)

#### Methods
- public void Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item)
- public void Add(TKey key, TValue value)
- public void Clear()
- public bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item)
- public bool ContainsKey(TKey key)
- public void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int arrayIndex)
- public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator()
- public bool Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item)
- public bool Remove(TKey key)
- private void System.Collections.ICollection.CopyTo(System.Array array, int index)
- private void System.Collections.IDictionary.Add(object key, object value)
- private void System.Collections.IDictionary.Clear()
- private bool System.Collections.IDictionary.Contains(object key)
- private System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
- private void System.Collections.IDictionary.Remove(object key)
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- public bool TryGetValue(TKey key, out TValue value)

### internal class System.Runtime.Collections.ValidatingCollection<T>
- Base: System.Collections.ObjectModel.Collection<T>
- Interfaces: System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Generic.IReadOnlyList<T>, System.Collections.Generic.IReadOnlyCollection<T>

#### Fields
- private System.Action<T> <OnAddValidationCallback>k__BackingField
- private System.Action <OnMutateValidationCallback>k__BackingField

#### Properties
- public System.Action<T> OnAddValidationCallback { get; set; }
- public System.Action OnMutateValidationCallback { get; set; }

#### Constructors
- public ValidatingCollection<T>()

#### Methods
- protected override void ClearItems()
- protected override void InsertItem(int index, T item)
- private void OnAdd(T item)
- private void OnMutate()
- protected override void RemoveItem(int index)
- protected override void SetItem(int index, T item)

## Namespace: System.Runtime.CompilerServices

### internal class System.Runtime.CompilerServices.FriendAccessAllowedAttribute
- Base: System.Attribute

#### Constructors
- public FriendAccessAllowedAttribute()

## Namespace: System.Runtime.Diagnostics

### internal enum System.Runtime.Diagnostics.ActivityControl
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- EVENT_ACTIVITY_CTRL_CREATE_ID = 3
- EVENT_ACTIVITY_CTRL_CREATE_SET_ID = 5
- EVENT_ACTIVITY_CTRL_GET_ID = 1
- EVENT_ACTIVITY_CTRL_GET_SET_ID = 4
- EVENT_ACTIVITY_CTRL_SET_ID = 2

### internal class System.Runtime.Diagnostics.DiagnosticsEventProvider
- Interfaces: System.IDisposable

#### Fields
- private long allKeywordMask
- private long anyKeywordMask
- private static const int basicTypeAllocationBufferSize
- private byte currentTraceLevel
- private static System.Runtime.Diagnostics.DiagnosticsEventProvider.WriteEventErrorCode errorCode
- private static const int etwAPIMaxStringCount
- private System.Runtime.Interop.UnsafeNativeMethods.EtwEnableCallback etwCallback
- private static const int etwMaxNumberArguments
- private int isDisposed
- private bool isProviderEnabled
- private static const int maxEventDataDescriptors
- private System.Guid providerId
- private static const int traceEventMaximumSize
- private static const int traceEventMaximumStringSize
- private long traceRegistrationHandle
- private static const int WindowsVistaMajorNumber

#### Constructors
- protected DiagnosticsEventProvider(System.Guid providerGuid)

#### Methods
- public virtual void Close()
- private void Deregister()
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- private static string EncodeObject(ref object data, System.Runtime.Interop.UnsafeNativeMethods.EventData* dataDescriptor, byte* dataBuffer)
- private void EtwEnableCallBack(in System.Guid sourceId, int isEnabled, byte setLevel, long anyKeyword, long allKeyword, void* filterData, void* callbackContext)
- private void EtwRegister()
- protected override void Finalize()
- public static System.Runtime.Diagnostics.DiagnosticsEventProvider.WriteEventErrorCode GetLastWriteEventError()
- public bool IsEnabled()
- public bool IsEnabled(byte level, long keywords)
- public bool IsEventEnabled(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor)
- protected abstract void OnControllerCommand()
- public static void SetActivityId(ref System.Guid id)
- private static void SetLastError(int error)
- public bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, params object[] eventPayload)
- public bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string data)
- protected internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, int dataCount, System.IntPtr data)
- public bool WriteMessageEvent(System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string eventMessage, byte eventLevel, long eventKeywords)
- public bool WriteMessageEvent(System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string eventMessage)
- public bool WriteTransferEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, System.Guid relatedActivityId, params object[] eventPayload)
- protected bool WriteTransferEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, System.Guid relatedActivityId, int dataCount, System.IntPtr data)

### internal class System.Runtime.Diagnostics.DiagnosticTraceBase

#### Fields
- private System.DateTime <LastFailure>k__BackingField
- protected static string AppDomainFriendlyName
- private bool calledShutdown
- protected static const string DefaultTraceListenerName
- private string eventSourceName
- private bool haveListeners
- private System.Diagnostics.SourceLevels level
- private object thisLock
- protected static const string TraceRecordVersion
- private System.Diagnostics.TraceSource traceSource
- protected string TraceSourceName
- private bool tracingEnabled
- private static const ushort TracingEventLogCategory

#### Properties
- public static System.Guid ActivityId { get; set; }
- protected bool CalledShutdown { get; }
- protected string EventSourceName { get; set; }
- public bool HaveListeners { get; }
- protected System.DateTime LastFailure { get; set; }
- public System.Diagnostics.SourceLevels Level { get; set; }
- protected static int ProcessId { get; }
- protected static string ProcessName { get; }
- public System.Diagnostics.TraceSource TraceSource { get; set; }
- public bool TracingEnabled { get; }

#### Constructors
- private static DiagnosticTraceBase()
- public DiagnosticTraceBase(string traceSourceName)

#### Methods
- protected void AddDomainEventHandlersForCleanup()
- protected static void AddExceptionToTraceString(System.Xml.XmlWriter xml, System.Exception exception)
- internal static string CreateDefaultSourceString(object source)
- protected static string CreateSourceString(object source)
- private void ExitOrUnloadEventHandler(object sender, System.EventArgs e)
- private System.Diagnostics.SourceLevels FixLevel(System.Diagnostics.SourceLevels level)
- public abstract bool IsEnabled()
- protected void LogTraceFailure(string traceString, System.Exception exception)
- protected static string LookupSeverity(System.Diagnostics.TraceEventType type)
- protected virtual void OnSetLevel(System.Diagnostics.SourceLevels level)
- protected abstract void OnShutdownTracing()
- protected abstract void OnUnhandledException(System.Exception exception)
- private void SetLevel(System.Diagnostics.SourceLevels level)
- private void SetLevelThreadSafe(System.Diagnostics.SourceLevels level)
- protected void SetTraceSource(System.Diagnostics.TraceSource traceSource)
- public virtual bool ShouldTrace(System.Runtime.TraceEventLevel level)
- public bool ShouldTrace(System.Diagnostics.TraceEventType type)
- public bool ShouldTraceToTraceSource(System.Runtime.TraceEventLevel level)
- private void ShutdownTracing()
- protected static string StackTraceString(System.Exception exception)
- public abstract void TraceEventLogEvent(System.Diagnostics.TraceEventType type, System.Runtime.Diagnostics.TraceRecord traceRecord)
- protected void UnhandledExceptionHandler(object sender, System.UnhandledExceptionEventArgs args)
- private static void UnsafeRemoveDefaultTraceListener(System.Diagnostics.TraceSource traceSource)
- public static string XmlEncode(string text)

### internal class System.Runtime.Diagnostics.DiagnosticTraceSource
- Base: System.Diagnostics.TraceSource

#### Fields
- private static const string PropagateActivityValue

#### Properties
- internal bool PropagateActivity { get; set; }

#### Constructors
- internal DiagnosticTraceSource(string name)

#### Methods
- protected override string[] GetSupportedAttributes()

### internal class System.Runtime.Diagnostics.DictionaryTraceRecord
- Base: System.Runtime.Diagnostics.TraceRecord

#### Fields
- private System.Collections.IDictionary dictionary

#### Properties
- internal string EventId { get; }

#### Constructors
- internal DictionaryTraceRecord(System.Collections.IDictionary dictionary)

#### Methods
- internal override void WriteTo(System.Xml.XmlWriter xml)

### internal class System.Runtime.Diagnostics.EtwDiagnosticTrace
- Base: System.Runtime.Diagnostics.DiagnosticTraceBase

#### Fields
- private static System.Guid defaultEtwProviderId
- private static const string DiagnosticTraceSource
- private System.Runtime.Diagnostics.EtwProvider etwProvider
- private static System.Collections.Hashtable etwProviderCache
- private System.Guid etwProviderId
- private static const string EventSourceVersion
- public static readonly System.Guid ImmutableDefaultEtwProviderId
- private static bool isVistaOrGreater
- private static const int MaxExceptionDepth
- private static const int MaxExceptionStringLength
- private static System.Func<string> traceAnnotation
- private static const ushort TracingEventLogCategory
- private static System.Runtime.Diagnostics.EventDescriptor transferEventDescriptor
- private static const int WindowsVistaMajorNumber
- private static const int XmlBracketsLength
- private static const int XmlBracketsLengthForNullValue

#### Properties
- public static System.Guid DefaultEtwProviderId { get; set; }
- public System.Runtime.Diagnostics.EtwProvider EtwProvider { get; }
- private bool EtwTracingEnabled { get; }
- public bool IsEnd2EndActivityTracingEnabled { get; }
- public bool IsEtwProviderEnabled { get; }
- public System.Action RefreshState { get; set; }

#### Constructors
- private static EtwDiagnosticTrace()
- public EtwDiagnosticTrace(string traceSourceName, System.Guid etwProviderId)

#### Methods
- private static string BuildTrace(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, string description, System.Runtime.TracePayload payload, string msdnTraceCode)
- private void CreateEtwProvider(System.Guid etwProviderId)
- private void CreateTraceSource()
- public void Event(int eventId, System.Runtime.TraceEventLevel traceEventLevel, System.Runtime.TraceChannel channel, string description)
- public void Event(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, string description)
- internal static string ExceptionToTraceString(System.Exception exception, int maxTraceStringLength)
- private static void GenerateLegacyTraceCode(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, out string msdnTraceCode, out int legacyEventId)
- private static string GenerateMsdnTraceCode(string traceSource, string traceCodeString)
- private static System.Runtime.Diagnostics.EventDescriptor GetEventDescriptor(int eventId, System.Runtime.TraceChannel channel, System.Runtime.TraceEventLevel traceEventLevel)
- private static string GetExceptionData(System.Exception exception)
- private static string GetInnerException(System.Exception exception, int remainingLength, int remainingAllowedRecursionDepth)
- public System.Runtime.TracePayload GetSerializedPayload(object source, System.Runtime.Diagnostics.TraceRecord traceRecord, System.Exception exception)
- public System.Runtime.TracePayload GetSerializedPayload(object source, System.Runtime.Diagnostics.TraceRecord traceRecord, System.Exception exception, bool getServiceReference)
- public override bool IsEnabled()
- public bool IsEtwEventEnabled(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor)
- public bool IsEtwEventEnabled(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, bool fullCheck)
- private static string LookupChannel(System.Runtime.TraceChannel traceChannel)
- protected override void OnShutdownTracing()
- protected override void OnUnhandledException(System.Exception exception)
- public void SetAndTraceTransfer(System.Guid newId, bool emitTransfer)
- public void SetAnnotation(System.Func<string> annotation)
- public void SetEnd2EndActivityTracingEnabled(bool isEnd2EndTracingEnabled)
- public override bool ShouldTrace(System.Runtime.TraceEventLevel level)
- public bool ShouldTraceToEtw(System.Runtime.TraceEventLevel level)
- private void ShutdownEtwProvider()
- private void ShutdownTraceSource()
- public override void TraceEventLogEvent(System.Diagnostics.TraceEventType type, System.Runtime.Diagnostics.TraceRecord traceRecord)
- public void TraceTransfer(System.Guid newId)
- private static void WriteExceptionToTraceString(System.Xml.XmlTextWriter xml, System.Exception exception, int remainingLength, int remainingAllowedRecursionDepth)
- private static bool WriteStartElement(System.Xml.XmlTextWriter xml, string localName, ref int remainingLength)
- public void WriteTraceSource(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, string description, System.Runtime.TracePayload payload)
- private static bool WriteXmlElementString(System.Xml.XmlTextWriter xml, string localName, string value, ref int remainingLength)

### internal class System.Runtime.Diagnostics.EtwProvider
- Base: System.Runtime.Diagnostics.DiagnosticsEventProvider
- Interfaces: System.IDisposable

#### Fields
- private bool end2EndActivityTracingEnabled
- private System.Action invokeControllerCallback

#### Properties
- internal System.Action ControllerCallBack { get; set; }
- internal bool IsEnd2EndActivityTracingEnabled { get; }

#### Constructors
- internal EtwProvider(System.Guid id)

#### Methods
- protected override void OnControllerCommand()
- internal void SetEnd2EndActivityTracingEnabled(bool isEnd2EndActivityTracingEnabled)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, System.Guid value1, string value2, string value3)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string value1, string value2)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string value1, string value2, string value3)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string value1, string value2, string value3, string value4)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string value1, string value2, string value3, string value4, string value5)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string value1, string value2, string value3, string value4, string value5, string value6)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string value1, string value2, string value3, string value4, string value5, string value6, string value7)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string value1, string value2, string value3, string value4, string value5, string value6, string value7, string value8)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string value1, string value2, string value3, string value4, string value5, string value6, string value7, string value8, string value9)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string value1, string value2, string value3, string value4, string value5, string value6, string value7, string value8, string value9, string value10)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string value1, string value2, string value3, string value4, string value5, string value6, string value7, string value8, string value9, string value10, string value11)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string value1, string value2, string value3, string value4, string value5, string value6, string value7, string value8, string value9, string value10, string value11, string value12)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string value1, string value2, string value3, string value4, string value5, string value6, string value7, string value8, string value9, string value10, string value11, string value12, string value13)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, int value1)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, int value1, int value2)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, int value1, int value2, int value3)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, long value1)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, long value1, long value2)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, long value1, long value2, long value3)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, System.Guid value1, long value2, long value3, string value4, string value5, string value6, string value7, string value8, string value9, string value10, string value11, string value12, string value13, string value14, string value15)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, System.Guid value1, long value2, long value3, string value4, string value5, string value6, string value7, string value8, string value9, string value10, string value11, string value12, bool value13, string value14, string value15, string value16, string value17)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, System.Guid value1, long value2, long value3, string value4, string value5, string value6, string value7, string value8, string value9)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, System.Guid value1, long value2, long value3, string value4, string value5, string value6, string value7, string value8, string value9, string value10, string value11)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, System.Guid value1, long value2, long value3, string value4, string value5, string value6, string value7, string value8, string value9, string value10, string value11, string value12, string value13)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, System.Guid value1, long value2, long value3, string value4, string value5, string value6, string value7, string value8, string value9, string value10, string value11, string value12, string value13, string value14)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, System.Guid value1, long value2, long value3, string value4, System.Guid value5, string value6, string value7, string value8, string value9, string value10, string value11, string value12, string value13)
- internal bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string value1, long value2, string value3, string value4)
- internal bool WriteTransferEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, System.Guid relatedActivityId, string value1, string value2)

### internal struct System.Runtime.Diagnostics.EventDescriptor

#### Fields
- private byte m_channel
- private ushort m_id
- private long m_keywords
- private byte m_level
- private byte m_opcode
- private ushort m_task
- private byte m_version

#### Properties
- public byte Channel { get; }
- public int EventId { get; }
- public long Keywords { get; }
- public byte Level { get; }
- public byte Opcode { get; }
- public int Task { get; }
- public byte Version { get; }

#### Constructors
- public EventDescriptor(int id, byte version, byte channel, byte level, byte opcode, int task, long keywords)

#### Methods
- public override bool Equals(object obj)
- public bool Equals(System.Runtime.Diagnostics.EventDescriptor other)
- public override int GetHashCode()
- public static bool op_Equality(System.Runtime.Diagnostics.EventDescriptor event1, System.Runtime.Diagnostics.EventDescriptor event2)
- public static bool op_Inequality(System.Runtime.Diagnostics.EventDescriptor event1, System.Runtime.Diagnostics.EventDescriptor event2)

### internal enum System.Runtime.Diagnostics.EventFacility
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- InfoCards = 327680
- SecurityAudit = 393216
- ServiceModel = 131072
- SMSvcHost = 262144
- Tracing = 65536
- TransactionBridge = 196608

### private static class System.Runtime.Diagnostics.EtwDiagnosticTrace.EventIdsWithMsdnTraceCode

#### Fields
- public static const int AppDomainUnload
- public static const int HandledExceptionError
- public static const int HandledExceptionInfo
- public static const int HandledExceptionVerbose
- public static const int HandledExceptionWarning
- public static const int ThrowingExceptionVerbose
- public static const int ThrowingExceptionWarning
- public static const int UnhandledException

### internal enum System.Runtime.Diagnostics.EventLogCategory
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ComPlus = 10
- FailFast = 6
- ListenerAdapter = 14
- MessageAuthentication = 2
- MessageLogging = 7
- ObjectAccess = 3
- PerformanceCounter = 8
- ServiceAuthorization = 1
- SharingService = 13
- StateMachine = 11
- Tracing = 4
- WebHost = 5
- Wmi = 9
- Wsat = 12

### internal enum System.Runtime.Diagnostics.EventLogEventId
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BindingError = 3221487618
- ComPlusDllHostInitializerStartingError = 3221356567
- ComPlusInstanceCreationError = 3221356570
- ComPlusInvokingMethodFailed = 3221356569
- ComPlusInvokingMethodFailedMismatchedTransactions = 3221356571
- ComPlusServiceHostStartingServiceError = 3221356566
- ComPlusTLBImportError = 3221356568
- CoordinatorRecoveryLogEntryCorrupt = 3221422084
- CoordinatorRecoveryLogEntryCreationFailure = 3221422085
- FailedToCreateMessageLoggingTraceSource = 3221356551
- FailedToInitializeTraceSource = 3221291109
- FailedToLoadPerformanceCounter = 3221356554
- FailedToLogMessage = 3221356549
- FailedToRemovePerformanceCounter = 3221356555
- FailedToSetupTracing = 3221291108
- FailedToTraceEvent = 3221291112
- FailedToTraceEventWithException = 3221291113
- FailFast = 3221291110
- FailFastException = 3221291111
- FatalUnexpectedStateMachineEvent = 3221422082
- ImpersonationFailure = 3221618698
- ImpersonationSuccess = 1074135049
- InvariantAssertionFailed = 3221291114
- LAFailedToListenForApp = 3221487619
- MessageAuthenticationFailure = 3221618692
- MessageAuthenticationSuccess = 1074135043
- MessageLoggingOff = 3221356553
- MessageLoggingOn = 3221356552
- MessageQueueDuplicatedPipeLeak = 3221487625
- MessageQueueDuplicatedSocketLeak = 3221487624
- MissingNecessaryEnhancedKeyUsage = 3221422102
- MissingNecessaryKeyUsage = 3221422101
- NonFatalUnexpectedStateMachineEvent = 3221422093
- ParticipantRecoveryLogEntryCorrupt = 3221422083
- ParticipantRecoveryLogEntryCreationFailure = 3221422086
- PerformanceCounterInitializationFailure = 3221422094
- PiiLoggingNotAllowed = 3221291116
- PiiLoggingOn = 3221291115
- ProtocolInitializationFailure = 3221422087
- ProtocolRecoveryBeginningFailure = 3221422089
- ProtocolRecoveryComplete = 3221422095
- ProtocolRecoveryCompleteFailure = 3221422090
- ProtocolStartFailure = 3221422088
- ProtocolStopFailure = 3221422092
- ProtocolStopped = 3221422096
- RemovedBadFilter = 3221356550
- SecurityNegotiationFailure = 3221618694
- SecurityNegotiationSuccess = 1074135045
- ServiceAuthorizationFailure = 3221618690
- ServiceAuthorizationSuccess = 1074135041
- ServiceStartFailed = 3221487623
- SharingUnhandledException = 3221487626
- SslNoAccessiblePrivateKey = 3221422100
- SslNoPrivateKey = 3221422099
- StartErrorPublish = 3221487617
- ThumbPrintNotFound = 3221422097
- ThumbPrintNotValidated = 3221422098
- TransactionBridgeRecoveryFailure = 3221422091
- TransportAuthenticationFailure = 3221618696
- TransportAuthenticationSuccess = 1074135047
- UnhandledStateMachineExceptionRecordDescription = 3221422081
- UnknownListenerAdapterError = 3221487620
- WasConnectionTimedout = 3221487622
- WasDisconnected = 3221487621
- WebHostFailedToListen = 3221356548
- WebHostFailedToProcessRequest = 3221356547
- WebHostHttpError = 3221356546
- WebHostNotLoggingInsufficientMemoryExceptionsOnActivationForNextTimeInterval = 2147614748
- WebHostUnhandledException = 3221356545
- WmiAdminTypeMismatch = 3221356564
- WmiCreateInstanceFailed = 3221356559
- WmiDeleteInstanceFailed = 3221356558
- WmiExecMethodFailed = 3221356561
- WmiExecQueryFailed = 3221356560
- WmiGetObjectFailed = 3221356556
- WmiPropertyMissing = 3221356565
- WmiPutInstanceFailed = 3221356557
- WmiRegistrationFailed = 3221356562
- WmiUnregistrationFailed = 3221356563

### internal class System.Runtime.Diagnostics.EventLogger

#### Fields
- private static bool canLogEvent
- private System.Runtime.Diagnostics.DiagnosticTraceBase diagnosticTrace
- private string eventLogSourceName
- private bool isInPartialTrust
- private static int logCountForPT
- private static const int MaxEventLogsInPT

#### Constructors
- private EventLogger()
- private static EventLogger()
- public EventLogger(string eventLogSourceName, System.Runtime.Diagnostics.DiagnosticTraceBase diagnosticTrace)

### <unavailable>

### internal enum System.Runtime.Diagnostics.EventSeverity
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Error = 3221225472
- Informational = 1073741824
- Success = 0
- Warning = 2147483648

### internal class System.Runtime.Diagnostics.EventTraceActivity

#### Fields
- public System.Guid ActivityId
- private static System.Runtime.Diagnostics.EventTraceActivity empty

#### Properties
- public static System.Runtime.Diagnostics.EventTraceActivity Empty { get; }
- public static string Name { get; }

#### Constructors
- public EventTraceActivity(bool setOnThread = false)
- public EventTraceActivity(System.Guid guid, bool setOnThread = false)

#### Methods
- public static System.Guid GetActivityIdFromThread()
- public static System.Runtime.Diagnostics.EventTraceActivity GetFromThreadOrCreate(bool clearIdOnThread = false)
- public void SetActivityId(System.Guid guid)
- private void SetActivityIdOnThread()

### internal interface System.Runtime.Diagnostics.ITraceSourceStringProvider

#### Methods
- public string GetSourceString()

### private static class System.Runtime.Diagnostics.EtwDiagnosticTrace.LegacyTraceEventIds

#### Fields
- public static const int AppDomainUnload
- public static const int Diagnostics
- public static const int EventLog
- public static const int ThrowingException
- public static const int TraceHandledException
- public static const int UnhandledException

### internal class System.Runtime.Diagnostics.PerformanceCounterNameAttribute
- Base: System.Attribute

#### Fields
- private string <Name>k__BackingField

#### Properties
- public string Name { get; set; }

#### Constructors
- public PerformanceCounterNameAttribute(string name)

### private static class System.Runtime.Diagnostics.EtwDiagnosticTrace.StringBuilderPool

#### Fields
- private static readonly System.Collections.Concurrent.ConcurrentQueue<System.Text.StringBuilder> freeStringBuilders
- private static const int maxPooledStringBuilders

#### Constructors
- private static EtwDiagnosticTrace.StringBuilderPool()

#### Methods
- public static void Return(System.Text.StringBuilder sb)
- public static System.Text.StringBuilder Take()

### internal class System.Runtime.Diagnostics.StringTraceRecord
- Base: System.Runtime.Diagnostics.TraceRecord

#### Fields
- private string content
- private string elementName

#### Properties
- internal string EventId { get; }

#### Constructors
- internal StringTraceRecord(string elementName, string content)

#### Methods
- internal override void WriteTo(System.Xml.XmlWriter writer)

### private static class System.Runtime.Diagnostics.EtwDiagnosticTrace.TraceCodes

#### Fields
- public static const string AppDomainUnload
- public static const string ThrowingException
- public static const string TraceHandledException
- public static const string UnhandledException

### internal class System.Runtime.Diagnostics.TraceRecord

#### Fields
- protected static const string EventIdBase
- protected static const string NamespaceSuffix

#### Properties
- internal string EventId { get; }

#### Constructors
- public TraceRecord()

#### Methods
- protected string BuildEventId(string eventId)
- internal virtual void WriteTo(System.Xml.XmlWriter writer)
- protected string XmlEncode(string text)

### public enum System.Runtime.Diagnostics.DiagnosticsEventProvider.WriteEventErrorCode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- EventTooBig = 2
- NoError = 0
- NoFreeBuffers = 1

## Namespace: System.Runtime.Interop

### internal delegate System.Runtime.Interop.UnsafeNativeMethods.EtwEnableCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public UnsafeNativeMethods.EtwEnableCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(in System.Guid sourceId, int isEnabled, byte level, long matchAnyKeywords, long matchAllKeywords, void* filterData, void* callbackContext, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(in System.Guid sourceId, System.IAsyncResult result)
- public virtual void Invoke(in System.Guid sourceId, int isEnabled, byte level, long matchAnyKeywords, long matchAllKeywords, void* filterData, void* callbackContext)

### public struct System.Runtime.Interop.UnsafeNativeMethods.EventData

#### Fields
- internal ulong DataPointer
- internal int Reserved
- internal uint Size

### internal class System.Runtime.Interop.SafeEventLogWriteHandle
- Base: Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
- Interfaces: System.IDisposable

#### Constructors
- private SafeEventLogWriteHandle()

#### Methods
- private static bool DeregisterEventSource(System.IntPtr hEventLog)
- public static System.Runtime.Interop.SafeEventLogWriteHandle RegisterEventSource(string uncServerName, string sourceName)
- protected override bool ReleaseHandle()

### internal static class System.Runtime.Interop.UnsafeNativeMethods

#### Fields
- public static const string ADVAPI32
- public static const int ERROR_ARITHMETIC_OVERFLOW
- public static const int ERROR_INVALID_HANDLE
- public static const int ERROR_MORE_DATA
- public static const int ERROR_NOT_ENOUGH_MEMORY
- public static const string KERNEL32

#### Methods
- public static Microsoft.Win32.SafeHandles.SafeWaitHandle CreateWaitableTimer(System.IntPtr mustBeZero, bool manualReset, string timerName)
- internal static void DebugBreak()
- internal static uint EventActivityIdControl(int ControlCode, out System.Guid ActivityId)
- internal static bool EventEnabled(long registrationHandle, in System.Runtime.Diagnostics.EventDescriptor eventDescriptor)
- internal static uint EventRegister(in System.Guid providerId, System.Runtime.Interop.UnsafeNativeMethods.EtwEnableCallback enableCallback, void* callbackContext, out long registrationHandle)
- internal static uint EventUnregister(long registrationHandle)
- internal static uint EventWrite(long registrationHandle, in System.Runtime.Diagnostics.EventDescriptor eventDescriptor, uint userDataCount, System.Runtime.Interop.UnsafeNativeMethods.EventData* userData)
- internal static uint EventWriteString(long registrationHandle, byte level, long keywords, char* message)
- internal static uint EventWriteTransfer(long registrationHandle, in System.Runtime.Diagnostics.EventDescriptor eventDescriptor, in System.Guid activityId, in System.Guid relatedActivityId, uint userDataCount, System.Runtime.Interop.UnsafeNativeMethods.EventData* userData)
- internal static string GetComputerName(System.Runtime.ComputerNameFormat nameType)
- private static bool GetComputerNameEx(System.Runtime.ComputerNameFormat nameType, System.Text.StringBuilder lpBuffer, out int size)
- public static uint GetSystemTimeAdjustment(out int adjustment, out uint increment, out uint adjustmentDisabled)
- private static void GetSystemTimeAsFileTime(out System.Runtime.InteropServices.ComTypes.FILETIME time)
- public static void GetSystemTimeAsFileTime(out long time)
- internal static bool IsDebuggerPresent()
- internal static void OutputDebugString(string lpOutputString)
- public static int QueryPerformanceCounter(out long time)
- internal static System.Runtime.Interop.SafeEventLogWriteHandle RegisterEventSource(string uncServerName, string sourceName)
- internal static bool ReportEvent(System.Runtime.InteropServices.SafeHandle hEventLog, ushort type, ushort category, uint eventID, byte[] userSID, ushort numStrings, uint dataLen, System.Runtime.InteropServices.HandleRef strings, byte[] rawData)
- public static bool SetWaitableTimer(Microsoft.Win32.SafeHandles.SafeWaitHandle handle, ref long dueTime, int period, System.IntPtr mustBeZero, System.IntPtr mustBeZeroAlso, bool resume)

## Namespace: System.ServiceModel.Internals

### internal static class System.ServiceModel.Internals.LocalAppContextSwitches

#### Fields
- public static readonly bool IncludeNullExceptionMessageInETWTrace

