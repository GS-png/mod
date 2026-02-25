# Assembly: Unity.Services.Core.Internal
- Path: tools/WorldBox.Managed/Unity.Services.Core.Internal.dll
- Types: 116

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9039 0C31BF72A97938576A1816EC362788771220CDD28AE27F3D26BECC23EFF7FC49
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4692 BB519949E26438990A23CC3238AFC6BBD442283B34A8A9738ADC57E2C1D5C6DE

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4692

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9039

## Namespace: Unity.Services.Authentication.Internal

### public interface Unity.Services.Authentication.Internal.IAccessToken
- Interfaces: Unity.Services.Core.Internal.IServiceComponent

#### Properties
- public string AccessToken { get; }

### public interface Unity.Services.Authentication.Internal.IAccessTokenObserver
- Interfaces: Unity.Services.Core.Internal.IServiceComponent

#### Events
- public event System.Action<string> AccessTokenChanged

### public interface Unity.Services.Authentication.Internal.IEnvironmentId
- Interfaces: Unity.Services.Core.Internal.IServiceComponent

#### Properties
- public string EnvironmentId { get; }

### public interface Unity.Services.Authentication.Internal.IPlayerId
- Interfaces: Unity.Services.Core.Internal.IServiceComponent

#### Properties
- public string PlayerId { get; }

#### Events
- public event System.Action<string> PlayerIdChanged

## Namespace: Unity.Services.Authentication.Server.Internal

### public interface Unity.Services.Authentication.Server.Internal.IServerAccessToken
- Interfaces: Unity.Services.Authentication.Internal.IAccessToken, Unity.Services.Core.Internal.IServiceComponent, Unity.Services.Authentication.Internal.IAccessTokenObserver

### public interface Unity.Services.Authentication.Server.Internal.IServerEnvironmentId
- Interfaces: Unity.Services.Authentication.Internal.IEnvironmentId, Unity.Services.Core.Internal.IServiceComponent

## Namespace: Unity.Services.Core.Analytics.Internal

### public interface Unity.Services.Core.Analytics.Internal.IAnalyticsStandardEventComponent
- Interfaces: Unity.Services.Core.Internal.IServiceComponent

#### Methods
- public void Record(string eventName, System.Collections.Generic.IDictionary<string, object> eventParameters, int eventVersion, string packageName)

### public interface Unity.Services.Core.Analytics.Internal.IAnalyticsUserId
- Interfaces: Unity.Services.Core.Internal.IServiceComponent

#### Methods
- public string GetAnalyticsUserId()

## Namespace: Unity.Services.Core.Configuration.Internal

### public interface Unity.Services.Core.Configuration.Internal.ICloudProjectId
- Interfaces: Unity.Services.Core.Internal.IServiceComponent

#### Methods
- public string GetCloudProjectId()

### public interface Unity.Services.Core.Configuration.Internal.IExternalUserId
- Interfaces: Unity.Services.Core.Internal.IServiceComponent

#### Properties
- public string UserId { get; }

#### Events
- public event System.Action<string> UserIdChanged

### public interface Unity.Services.Core.Configuration.Internal.IProjectConfiguration
- Interfaces: Unity.Services.Core.Internal.IServiceComponent

#### Methods
- public bool GetBool(string key, bool defaultValue = false)
- public float GetFloat(string key, float defaultValue = 0)
- public int GetInt(string key, int defaultValue = 0)
- public string GetString(string key, string defaultValue = null)

## Namespace: Unity.Services.Core.Device.Internal

### public interface Unity.Services.Core.Device.Internal.IInstallationId
- Interfaces: Unity.Services.Core.Internal.IServiceComponent

#### Methods
- public string GetOrCreateIdentifier()

## Namespace: Unity.Services.Core.Environments.Internal

### public interface Unity.Services.Core.Environments.Internal.IEnvironments
- Interfaces: Unity.Services.Core.Internal.IServiceComponent

#### Properties
- public string Current { get; }

## Namespace: Unity.Services.Core.Internal

### private struct Unity.Services.Core.Internal.CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__InitializePackageAsync|2>d
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Unity.Services.Core.Internal.CoreRegistryInitializer.<>c__DisplayClass3_0 <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1
- public Unity.Services.Core.Internal.IInitializablePackage package

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Unity.Services.Core.Internal.CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__TryInitializePackageAsync|0>d
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Unity.Services.Core.Internal.CoreRegistryInitializer.<>c__DisplayClass3_0 <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1
- public Unity.Services.Core.Internal.IInitializablePackage package

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Unity.Services.Core.Internal.UnityServicesInternal.<>c__DisplayClass33_0.<<InitializeServicesAsync>g__InitializePackagesAsync|1>d
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Unity.Services.Core.Internal.UnityServicesInternal.<>c__DisplayClass33_0 <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo>> <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Unity.Services.Core.Internal.TaskAsyncOperation.<>c

#### Fields
- public static readonly Unity.Services.Core.Internal.TaskAsyncOperation.<>c <>9
- public static System.Action<System.Threading.Tasks.Task, object> <>9__10_0

#### Constructors
- private static TaskAsyncOperation.<>c()
- public TaskAsyncOperation.<>c()

#### Methods
- internal void <.ctor>b__10_0(System.Threading.Tasks.Task t, object state)

### private class Unity.Services.Core.Internal.TaskAsyncOperation<T>.<>c<T>

#### Fields
- public static readonly Unity.Services.Core.Internal.TaskAsyncOperation<T>.<>c<T> <>9
- public static System.Action<System.Threading.Tasks.Task<T>, object> <>9__11_0

#### Constructors
- private static TaskAsyncOperation<T>.<>c<T>()
- public TaskAsyncOperation<T>.<>c<T>()

#### Methods
- internal void <.ctor>b__11_0(System.Threading.Tasks.Task<T> t, object state)

### private class Unity.Services.Core.Internal.AsyncOperationBase.<>c__DisplayClass17_0

#### Fields
- public System.Action continuation

#### Constructors
- public AsyncOperationBase.<>c__DisplayClass17_0()

#### Methods
- internal void <OnCompleted>b__0(Unity.Services.Core.Internal.IAsyncOperation op)

### private class Unity.Services.Core.Internal.AsyncOperationBase<T>.<>c__DisplayClass19_0<T>

#### Fields
- public System.Action continuation

#### Constructors
- public AsyncOperationBase<T>.<>c__DisplayClass19_0<T>()

#### Methods
- internal void <OnCompleted>b__0(Unity.Services.Core.Internal.IAsyncOperation<T> op)

### private class Unity.Services.Core.Internal.AsyncOperationExtensions.<>c__DisplayClass1_0

#### Fields
- public System.Threading.Tasks.TaskCompletionSource<object> taskCompletionSource

#### Constructors
- public AsyncOperationExtensions.<>c__DisplayClass1_0()

#### Methods
- internal void <AsTask>g__CompleteTask|0(Unity.Services.Core.Internal.IAsyncOperation operation)

### private class Unity.Services.Core.Internal.AsyncOperationAwaiter.<>c__DisplayClass2_0

#### Fields
- public System.Action continuation

#### Constructors
- public AsyncOperationAwaiter.<>c__DisplayClass2_0()

#### Methods
- internal void <OnCompleted>b__0(Unity.Services.Core.Internal.IAsyncOperation operation)

### private class Unity.Services.Core.Internal.AsyncOperationAwaiter<T>.<>c__DisplayClass2_0<T>

#### Fields
- public System.Action continuation

#### Constructors
- public AsyncOperationAwaiter<T>.<>c__DisplayClass2_0<T>()

#### Methods
- internal void <OnCompleted>b__0(Unity.Services.Core.Internal.IAsyncOperation<T> obj)

### private class Unity.Services.Core.Internal.UnityWebRequestUtils.<>c__DisplayClass2_0

#### Fields
- public System.Threading.Tasks.TaskCompletionSource<string> completionSource

#### Constructors
- public UnityWebRequestUtils.<>c__DisplayClass2_0()

#### Methods
- internal void <GetTextAsync>g__CompleteFetchTaskOnRequestCompleted|0(UnityEngine.AsyncOperation rawOperation)

### private class Unity.Services.Core.Internal.UnityServicesInternal.<>c__DisplayClass33_0

#### Fields
- public Unity.Services.Core.Internal.UnityServicesInternal <>4__this
- public Unity.Services.Core.Internal.DependencyTree dependencyTree
- public System.Diagnostics.Stopwatch initStopwatch
- public System.Collections.Generic.List<int> sortedPackageTypeHashes

#### Constructors
- public UnityServicesInternal.<>c__DisplayClass33_0()

#### Methods
- internal void <InitializeServicesAsync>g__FailServicesInitialization|2(System.Exception reason)
- internal System.Threading.Tasks.Task <InitializeServicesAsync>g__InitializePackagesAsync|1()
- internal void <InitializeServicesAsync>g__SortPackages|0()
- internal void <InitializeServicesAsync>g__SucceedServicesInitialization|3()

### private class Unity.Services.Core.Internal.AsyncOperationAwaiter.<>c__DisplayClass3_0

#### Fields
- public System.Action continuation

#### Constructors
- public AsyncOperationAwaiter.<>c__DisplayClass3_0()

#### Methods
- internal void <UnsafeOnCompleted>b__0(Unity.Services.Core.Internal.IAsyncOperation operation)

### private class Unity.Services.Core.Internal.AsyncOperationAwaiter<T>.<>c__DisplayClass3_0<T>

#### Fields
- public System.Action continuation

#### Constructors
- public AsyncOperationAwaiter<T>.<>c__DisplayClass3_0<T>()

#### Methods
- internal void <UnsafeOnCompleted>b__0(Unity.Services.Core.Internal.IAsyncOperation<T> obj)

### private class Unity.Services.Core.Internal.CoreRegistryInitializer.<>c__DisplayClass3_0

#### Fields
- public Unity.Services.Core.Internal.CoreRegistryInitializer <>4__this
- public Unity.Services.Core.Internal.DependencyTree dependencyTree
- public System.Collections.Generic.List<System.Exception> failureReasons
- public System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo> packagesInitInfos
- public System.Diagnostics.Stopwatch stopwatch

#### Constructors
- public CoreRegistryInitializer.<>c__DisplayClass3_0()

#### Methods
- internal void <InitializeRegistryAsync>g__Fail|3()
- internal Unity.Services.Core.Internal.IInitializablePackage <InitializeRegistryAsync>g__GetPackageAt|1(int index)
- internal System.Threading.Tasks.Task <InitializeRegistryAsync>g__InitializePackageAsync|2(Unity.Services.Core.Internal.IInitializablePackage package)
- internal System.Threading.Tasks.Task <InitializeRegistryAsync>g__TryInitializePackageAsync|0(Unity.Services.Core.Internal.IInitializablePackage package)

### private class Unity.Services.Core.Internal.AsyncOperationExtensions.<>c__DisplayClass3_0<T>

#### Fields
- public System.Threading.Tasks.TaskCompletionSource<T> taskCompletionSource

#### Constructors
- public AsyncOperationExtensions.<>c__DisplayClass3_0<T>()

#### Methods
- internal void <AsTask>g__CompleteTask|0(Unity.Services.Core.Internal.IAsyncOperation<T> operation)

### private struct Unity.Services.Core.Internal.UnityServicesInternal.<EnableInitializationAsync>d__36
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Unity.Services.Core.Internal.UnityServicesInternal <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Unity.Services.Core.Internal.UnityServicesInitializer.<EnableServicesInitializationAsync>d__1
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Unity.Services.Core.Internal.CoreDiagnostics.<GetOrCreateDiagnosticsAsync>d__26
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Unity.Services.Core.Internal.CoreDiagnostics <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Telemetry.Internal.IDiagnostics> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory> <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Unity.Services.Core.Internal.UnityServicesInternal.<InitializeAsync>d__27
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Unity.Services.Core.Internal.UnityServicesInternal <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<object> <>u__1
- private System.Runtime.CompilerServices.TaskAwaiter <>u__2
- public Unity.Services.Core.InitializationOptions options

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Unity.Services.Core.Internal.CoreRegistryInitializer.<InitializeRegistryAsync>d__3
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Unity.Services.Core.Internal.CoreRegistryInitializer <>4__this
- private Unity.Services.Core.Internal.CoreRegistryInitializer.<>c__DisplayClass3_0 <>8__1
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1
- private int <i>5__2

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Unity.Services.Core.Internal.UnityServicesInternal.<InitializeServicesAsync>d__33
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Unity.Services.Core.Internal.UnityServicesInternal <>4__this
- private Unity.Services.Core.Internal.UnityServicesInternal.<>c__DisplayClass33_0 <>8__1
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Unity.Services.Core.Internal.CoreDiagnostics.<SendCoreDiagnosticsAsync>d__24
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### internal class Unity.Services.Core.Internal.AsyncOperation
- Interfaces: Unity.Services.Core.Internal.IAsyncOperation, System.Collections.IEnumerator

#### Fields
- private System.Exception <Exception>k__BackingField
- private bool <IsDone>k__BackingField
- private Unity.Services.Core.Internal.AsyncOperationStatus <Status>k__BackingField
- protected System.Action<Unity.Services.Core.Internal.IAsyncOperation> m_CompletedCallback

#### Properties
- public System.Exception Exception { get; protected set; }
- public bool IsDone { get; protected set; }
- public Unity.Services.Core.Internal.AsyncOperationStatus Status { get; protected set; }
- private object System.Collections.IEnumerator.Current { get; }

#### Events
- public event System.Action<Unity.Services.Core.Internal.IAsyncOperation> Completed

#### Constructors
- public AsyncOperation()

#### Methods
- public void Cancel()
- public void Fail(System.Exception reason)
- public void SetInProgress()
- public void Succeed()
- private bool System.Collections.IEnumerator.MoveNext()
- private void System.Collections.IEnumerator.Reset()

### internal struct Unity.Services.Core.Internal.AsyncOperationAwaiter
- Interfaces: Unity.Services.Core.Internal.IAsyncOperationAwaiter, System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion

#### Fields
- private Unity.Services.Core.Internal.IAsyncOperation m_Operation

#### Properties
- public bool IsCompleted { get; }

#### Constructors
- public AsyncOperationAwaiter(Unity.Services.Core.Internal.IAsyncOperation asyncOperation)

#### Methods
- public void GetResult()
- public void OnCompleted(System.Action continuation)
- public void UnsafeOnCompleted(System.Action continuation)

### internal struct Unity.Services.Core.Internal.AsyncOperationAwaiter<T>
- Interfaces: Unity.Services.Core.Internal.IAsyncOperationAwaiter<T>, System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion

#### Fields
- private Unity.Services.Core.Internal.IAsyncOperation<T> m_Operation

#### Properties
- public bool IsCompleted { get; }

#### Constructors
- public AsyncOperationAwaiter<T>(Unity.Services.Core.Internal.IAsyncOperation<T> asyncOperation)

#### Methods
- public T GetResult()
- public void OnCompleted(System.Action continuation)
- public void UnsafeOnCompleted(System.Action continuation)

### internal class Unity.Services.Core.Internal.AsyncOperationBase
- Base: UnityEngine.CustomYieldInstruction
- Interfaces: System.Collections.IEnumerator, Unity.Services.Core.Internal.IAsyncOperation, System.Runtime.CompilerServices.INotifyCompletion

#### Fields
- private System.Action<Unity.Services.Core.Internal.IAsyncOperation> m_CompletedCallback

#### Properties
- public System.Exception Exception { get; }
- public bool IsCompleted { get; }
- public bool IsDone { get; }
- public bool keepWaiting { get; }
- public Unity.Services.Core.Internal.AsyncOperationStatus Status { get; }

#### Events
- public event System.Action<Unity.Services.Core.Internal.IAsyncOperation> Completed

#### Constructors
- protected AsyncOperationBase()

#### Methods
- protected void DidComplete()
- public abstract Unity.Services.Core.Internal.AsyncOperationBase GetAwaiter()
- public abstract void GetResult()
- public virtual void OnCompleted(System.Action continuation)

### internal class Unity.Services.Core.Internal.AsyncOperationBase<T>
- Base: UnityEngine.CustomYieldInstruction
- Interfaces: System.Collections.IEnumerator, Unity.Services.Core.Internal.IAsyncOperation<T>, System.Runtime.CompilerServices.INotifyCompletion

#### Fields
- private System.Action<Unity.Services.Core.Internal.IAsyncOperation<T>> m_CompletedCallback

#### Properties
- public System.Exception Exception { get; }
- public bool IsCompleted { get; }
- public bool IsDone { get; }
- public bool keepWaiting { get; }
- public T Result { get; }
- public Unity.Services.Core.Internal.AsyncOperationStatus Status { get; }

#### Events
- public event System.Action<Unity.Services.Core.Internal.IAsyncOperation<T>> Completed

#### Constructors
- protected AsyncOperationBase<T>()

#### Methods
- protected void DidComplete()
- public abstract Unity.Services.Core.Internal.AsyncOperationBase<T> GetAwaiter()
- public abstract T GetResult()
- public virtual void OnCompleted(System.Action continuation)

### internal static class Unity.Services.Core.Internal.AsyncOperationExtensions

#### Methods
- public static System.Threading.Tasks.Task AsTask(Unity.Services.Core.Internal.IAsyncOperation self)
- public static System.Threading.Tasks.Task<T> AsTask<T>(Unity.Services.Core.Internal.IAsyncOperation<T> self)
- public static Unity.Services.Core.Internal.AsyncOperationAwaiter GetAwaiter(Unity.Services.Core.Internal.IAsyncOperation self)
- public static Unity.Services.Core.Internal.AsyncOperationAwaiter<T> GetAwaiter<T>(Unity.Services.Core.Internal.IAsyncOperation<T> self)

### internal enum Unity.Services.Core.Internal.AsyncOperationStatus
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Cancelled = 4
- Failed = 3
- InProgress = 1
- None = 0
- Succeeded = 2

### internal class Unity.Services.Core.Internal.AsyncOperation<T>
- Interfaces: Unity.Services.Core.Internal.IAsyncOperation<T>, System.Collections.IEnumerator

#### Fields
- private System.Exception <Exception>k__BackingField
- private bool <IsDone>k__BackingField
- private T <Result>k__BackingField
- private Unity.Services.Core.Internal.AsyncOperationStatus <Status>k__BackingField
- protected System.Action<Unity.Services.Core.Internal.IAsyncOperation<T>> m_CompletedCallback

#### Properties
- public System.Exception Exception { get; protected set; }
- public bool IsDone { get; protected set; }
- public T Result { get; protected set; }
- public Unity.Services.Core.Internal.AsyncOperationStatus Status { get; protected set; }
- private object System.Collections.IEnumerator.Current { get; }

#### Events
- public event System.Action<Unity.Services.Core.Internal.IAsyncOperation<T>> Completed

#### Constructors
- public AsyncOperation<T>()

#### Methods
- public void Cancel()
- public void Fail(System.Exception reason)
- public void SetInProgress()
- public void Succeed(T result)
- private bool System.Collections.IEnumerator.MoveNext()
- private void System.Collections.IEnumerator.Reset()

### public class Unity.Services.Core.Internal.CircularDependencyException
- Base: Unity.Services.Core.ServicesInitializationException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public CircularDependencyException()
- public CircularDependencyException(string message)

### internal class Unity.Services.Core.Internal.ComponentRegistry
- Interfaces: Unity.Services.Core.Internal.IComponentRegistry

#### Fields
- private readonly System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IServiceComponent> <ComponentTypeHashToInstance>k__BackingField

#### Properties
- internal System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IServiceComponent> ComponentTypeHashToInstance { get; }

#### Constructors
- public ComponentRegistry()
- public ComponentRegistry(System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance)

#### Methods
- public TComponent GetServiceComponent<TComponent>()
- private bool IsComponentTypeRegistered(int componentTypeHash)
- public void RegisterServiceComponent<TComponent>(TComponent component)
- public void ResetProvidedComponents(System.Collections.Generic.IDictionary<int, Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance)
- public bool TryGetServiceComponent<TComponent>(out TComponent component)

### internal class Unity.Services.Core.Internal.CoreDiagnostics

#### Fields
- private readonly System.Collections.Generic.IDictionary<string, string> <CoreTags>k__BackingField
- private Unity.Services.Core.Telemetry.Internal.IDiagnostics <Diagnostics>k__BackingField
- private Unity.Services.Core.Telemetry.Internal.IDiagnosticsComponentProvider <DiagnosticsComponentProvider>k__BackingField
- private static Unity.Services.Core.Internal.CoreDiagnostics <Instance>k__BackingField
- internal static const string CircularDependencyDiagnosticName
- internal static const string CorePackageInitDiagnosticName
- internal static const string CorePackageName
- internal static const string OperateServicesInitDiagnosticName
- internal static const string ProjectConfigTagName

#### Properties
- public System.Collections.Generic.IDictionary<string, string> CoreTags { get; }
- internal Unity.Services.Core.Telemetry.Internal.IDiagnostics Diagnostics { get; set; }
- internal Unity.Services.Core.Telemetry.Internal.IDiagnosticsComponentProvider DiagnosticsComponentProvider { get; set; }
- public static Unity.Services.Core.Internal.CoreDiagnostics Instance { get; internal set; }

#### Constructors
- public CoreDiagnostics()

#### Methods
- internal System.Threading.Tasks.Task<Unity.Services.Core.Telemetry.Internal.IDiagnostics> GetOrCreateDiagnosticsAsync()
- private static void OnSendFailed(System.Threading.Tasks.Task failedSendTask)
- public void SendCircularDependencyDiagnostics(System.Exception exception)
- internal System.Threading.Tasks.Task SendCoreDiagnosticsAsync(string diagnosticName, System.Exception exception)
- public void SendCorePackageInitDiagnostics(System.Exception exception)
- public void SendOperateServicesInitDiagnostics(System.Exception exception)
- public void SetProjectConfiguration(string serializedProjectConfig)

### internal static class Unity.Services.Core.Internal.CoreLogger

#### Fields
- private static const string k_TelemetryLoggingDefine
- internal static const string Tag
- internal static const string VerboseLoggingDefine

#### Methods
- public static void Log(object message)
- public static void LogAssertion(object message)
- public static void LogError(object message)
- public static void LogException(System.Exception exception)
- public static void LogTelemetry(object message)
- public static void LogVerbose(object message)
- public static void LogWarning(object message)

### internal class Unity.Services.Core.Internal.CoreMetrics

#### Fields
- private readonly System.Collections.Generic.IDictionary<System.Type, Unity.Services.Core.Telemetry.Internal.IMetrics> <AllPackageMetrics>k__BackingField
- private static Unity.Services.Core.Internal.CoreMetrics <Instance>k__BackingField
- private Unity.Services.Core.Telemetry.Internal.IMetrics <Metrics>k__BackingField
- internal static const string AllPackageNamesKey
- internal static const char AllPackageNamesSeparator
- internal static const string AllPackagesInitSuccessMetricName
- internal static const string AllPackagesInitTimeMetricName
- internal static const string PackageInitializerNamesKeyFormat
- internal static const char PackageInitializerNamesSeparator
- internal static const string PackageInitTimeMetricName

#### Properties
- internal System.Collections.Generic.IDictionary<System.Type, Unity.Services.Core.Telemetry.Internal.IMetrics> AllPackageMetrics { get; }
- public static Unity.Services.Core.Internal.CoreMetrics Instance { get; internal set; }
- internal Unity.Services.Core.Telemetry.Internal.IMetrics Metrics { get; set; }

#### Constructors
- public CoreMetrics()

#### Methods
- internal void FindAndCacheAllPackageMetrics(Unity.Services.Core.Configuration.Internal.IProjectConfiguration configuration, Unity.Services.Core.Telemetry.Internal.IMetricsFactory factory)
- public void Initialize(Unity.Services.Core.Configuration.Internal.IProjectConfiguration configuration, Unity.Services.Core.Telemetry.Internal.IMetricsFactory factory, System.Type corePackageType)
- public void SendAllPackagesInitSuccessMetric()
- public void SendAllPackagesInitTimeMetric(double initTimeSeconds)
- public void SendInitTimeMetricForPackage(System.Type packageType, double initTimeSeconds)

### public class Unity.Services.Core.Internal.CorePackageRegistry

#### Fields
- private static Unity.Services.Core.Internal.CorePackageRegistry <Instance>k__BackingField
- private Unity.Services.Core.Internal.IPackageRegistry <Registry>k__BackingField

#### Properties
- public static Unity.Services.Core.Internal.CorePackageRegistry Instance { get; internal set; }
- internal Unity.Services.Core.Internal.IPackageRegistry Registry { get; set; }

#### Constructors
- internal CorePackageRegistry()
- internal CorePackageRegistry(Unity.Services.Core.Internal.IPackageRegistry registry)

#### Methods
- internal void Lock()
- public Unity.Services.Core.Internal.CoreRegistration Register<TPackage>(TPackage package)

### public struct Unity.Services.Core.Internal.CoreRegistration

#### Fields
- private readonly int m_PackageHash
- private readonly Unity.Services.Core.Internal.IPackageRegistry m_Registry

#### Constructors
- internal CoreRegistration(Unity.Services.Core.Internal.IPackageRegistry registry, int packageHash)

#### Methods
- public Unity.Services.Core.Internal.CoreRegistration DependsOn<T>()
- public Unity.Services.Core.Internal.CoreRegistration OptionallyDependsOn<T>()
- public Unity.Services.Core.Internal.CoreRegistration ProvidesComponent<T>()

### public class Unity.Services.Core.Internal.CoreRegistry

#### Fields
- private Unity.Services.Core.Internal.IComponentRegistry <ComponentRegistry>k__BackingField
- private static Unity.Services.Core.Internal.CoreRegistry <Instance>k__BackingField
- private readonly string <InstanceId>k__BackingField
- private Unity.Services.Core.InitializationOptions <Options>k__BackingField
- private Unity.Services.Core.Internal.IPackageRegistry <PackageRegistry>k__BackingField
- private Unity.Services.Core.Internal.IServiceRegistry <ServiceRegistry>k__BackingField
- private Unity.Services.Core.Internal.ServicesType <Type>k__BackingField

#### Properties
- internal Unity.Services.Core.Internal.IComponentRegistry ComponentRegistry { get; private set; }
- public static Unity.Services.Core.Internal.CoreRegistry Instance { get; internal set; }
- public string InstanceId { get; }
- internal Unity.Services.Core.InitializationOptions Options { get; set; }
- internal Unity.Services.Core.Internal.IPackageRegistry PackageRegistry { get; private set; }
- internal Unity.Services.Core.Internal.IServiceRegistry ServiceRegistry { get; private set; }
- internal Unity.Services.Core.Internal.ServicesType Type { get; private set; }

#### Constructors
- internal CoreRegistry()
- internal CoreRegistry(Unity.Services.Core.Internal.IPackageRegistry packageRegistry, Unity.Services.Core.Internal.ServicesType type = Default, string instanceId = null)

#### Methods
- public T GetService<T>()
- public TComponent GetServiceComponent<TComponent>()
- internal void LockComponentRegistration()
- internal void LockServiceRegistration()
- public Unity.Services.Core.Internal.CoreRegistration RegisterPackage<TPackage>(TPackage package)
- public void RegisterService<T>(T service)
- public void RegisterServiceComponent<TComponent>(TComponent component)
- public bool TryGetServiceComponent<TComponent>(out TComponent component)

### internal class Unity.Services.Core.Internal.CoreRegistryInitializer

#### Fields
- private readonly Unity.Services.Core.Internal.CoreRegistry m_Registry
- private readonly System.Collections.Generic.List<int> m_SortedPackageTypeHashes

#### Constructors
- public CoreRegistryInitializer(Unity.Services.Core.Internal.CoreRegistry registry, System.Collections.Generic.List<int> sortedPackageTypeHashes)

#### Methods
- public System.Threading.Tasks.Task<System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo>> InitializeRegistryAsync()

### internal class Unity.Services.Core.Internal.DependencyTree

#### Fields
- public readonly System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IServiceComponent> ComponentTypeHashToInstance
- public readonly System.Collections.Generic.Dictionary<int, int> ComponentTypeHashToPackageTypeHash
- public readonly System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int>> PackageTypeHashToComponentTypeHashDependencies
- public readonly System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IInitializablePackage> PackageTypeHashToInstance

#### Constructors
- internal DependencyTree()
- internal DependencyTree(System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IInitializablePackage> packageToInstance, System.Collections.Generic.Dictionary<int, int> componentToPackage, System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int>> packageToComponentDependencies, System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IServiceComponent> componentToInstance)

### internal class Unity.Services.Core.Internal.DependencyTreeComponentHashException
- Base: Unity.Services.Core.Internal.HashException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public DependencyTreeComponentHashException(int hash)
- public DependencyTreeComponentHashException(int hash, string message)
- public DependencyTreeComponentHashException(int hash, string message, System.Exception inner)

### internal static class Unity.Services.Core.Internal.DependencyTreeExtensions

#### Methods
- private static string GetComponentIdentifier(Unity.Services.Core.Internal.IServiceComponent component)
- private static Newtonsoft.Json.Linq.JObject GetComponentJObject(Unity.Services.Core.Internal.DependencyTree tree, int componentHash)
- private static Newtonsoft.Json.Linq.JObject GetPackageJObject(Unity.Services.Core.Internal.DependencyTree tree, int packageHash)
- internal static bool IsOptional(Unity.Services.Core.Internal.DependencyTree tree, int componentTypeHash)
- internal static bool IsProvided(Unity.Services.Core.Internal.DependencyTree tree, int componentTypeHash)
- internal static string ToJson(Unity.Services.Core.Internal.DependencyTree tree, System.Collections.Generic.ICollection<int> order = null)

### internal struct Unity.Services.Core.Internal.DependencyTreeInitializeOrderSorter

#### Fields
- private System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.DependencyTreeInitializeOrderSorter.ExplorationMark> m_PackageTypeHashExplorationHistory
- public readonly System.Collections.Generic.ICollection<int> Target
- public readonly Unity.Services.Core.Internal.DependencyTree Tree

#### Constructors
- public DependencyTreeInitializeOrderSorter(Unity.Services.Core.Internal.DependencyTree tree, System.Collections.Generic.ICollection<int> target)

#### Methods
- private System.Collections.Generic.IEnumerable<int> GetDependencyTypeHashesFor(int packageTypeHash)
- private System.Collections.Generic.IReadOnlyCollection<int> GetPackageTypeHashes()
- private int GetPackageTypeHashFor(int componentTypeHash)
- private void MarkPackage(int packageTypeHash, Unity.Services.Core.Internal.DependencyTreeInitializeOrderSorter.ExplorationMark mark)
- private void RemoveUnprovidedOptionalDependencies(System.Collections.Generic.IList<int> dependencyTypeHashes)
- private void RemoveUnprovidedOptionalDependenciesFromTree()
- public void SortRegisteredPackagesIntoTarget()
- private void SortTreeThrough(int packageTypeHash)
- private void SortTreeThrough(System.Collections.Generic.IEnumerable<int> dependencyTypeHashes)

### internal class Unity.Services.Core.Internal.DependencyTreePackageHashException
- Base: Unity.Services.Core.Internal.HashException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public DependencyTreePackageHashException(int hash)
- public DependencyTreePackageHashException(int hash, string message)
- public DependencyTreePackageHashException(int hash, string message, System.Exception inner)

### internal class Unity.Services.Core.Internal.DependencyTreeSortFailedException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public DependencyTreeSortFailedException(Unity.Services.Core.Internal.DependencyTree tree, System.Collections.Generic.ICollection<int> target)
- public DependencyTreeSortFailedException(Unity.Services.Core.Internal.DependencyTree tree, System.Collections.Generic.ICollection<int> target, System.Exception inner)

#### Methods
- private static string CreateExceptionMessage(Unity.Services.Core.Internal.DependencyTree tree, System.Collections.Generic.ICollection<int> target, System.Exception inner = null)

### internal static class Unity.Services.Core.Internal.DictionaryExtensions

#### Methods
- public static TDictionary MergeAllowOverride<TDictionary, TKey, TValue>(TDictionary self, System.Collections.Generic.IDictionary<TKey, TValue> dictionary)
- public static TDictionary MergeNoOverride<TDictionary, TKey, TValue>(TDictionary self, System.Collections.Generic.IDictionary<TKey, TValue> dictionary)
- public static bool ValueEquals<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> x, System.Collections.Generic.IDictionary<TKey, TValue> y)
- public static bool ValueEquals<TKey, TValue, TComparer>(System.Collections.Generic.IDictionary<TKey, TValue> x, System.Collections.Generic.IDictionary<TKey, TValue> y, TComparer valueComparer)

### private enum Unity.Services.Core.Internal.DependencyTreeInitializeOrderSorter.ExplorationMark
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- None = 0
- Sorted = 2
- Viewed = 1

### internal class Unity.Services.Core.Internal.HashException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Fields
- private readonly int <Hash>k__BackingField

#### Properties
- public int Hash { get; }

#### Constructors
- public HashException(int hash)
- public HashException(int hash, string message)
- public HashException(int hash, string message, System.Exception inner)

### internal interface Unity.Services.Core.Internal.IAsyncOperation
- Interfaces: System.Collections.IEnumerator

#### Properties
- public System.Exception Exception { get; }
- public bool IsDone { get; }
- public Unity.Services.Core.Internal.AsyncOperationStatus Status { get; }

#### Events
- public event System.Action<Unity.Services.Core.Internal.IAsyncOperation> Completed

### internal interface Unity.Services.Core.Internal.IAsyncOperationAwaiter
- Interfaces: System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion

#### Properties
- public bool IsCompleted { get; }

#### Methods
- public void GetResult()

### internal interface Unity.Services.Core.Internal.IAsyncOperationAwaiter<T>
- Interfaces: System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion

#### Properties
- public bool IsCompleted { get; }

#### Methods
- public T GetResult()

### internal interface Unity.Services.Core.Internal.IAsyncOperation<T>
- Interfaces: System.Collections.IEnumerator

#### Properties
- public System.Exception Exception { get; }
- public bool IsDone { get; }
- public T Result { get; }
- public Unity.Services.Core.Internal.AsyncOperationStatus Status { get; }

#### Events
- public event System.Action<Unity.Services.Core.Internal.IAsyncOperation<T>> Completed

### internal interface Unity.Services.Core.Internal.IComponentRegistry

#### Methods
- public TComponent GetServiceComponent<TComponent>()
- public void RegisterServiceComponent<TComponent>(TComponent component)
- public void ResetProvidedComponents(System.Collections.Generic.IDictionary<int, Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance)
- public bool TryGetServiceComponent<TComponent>(out TComponent component)

### public interface Unity.Services.Core.Internal.IInitializablePackage

#### Methods
- public System.Threading.Tasks.Task Initialize(Unity.Services.Core.Internal.CoreRegistry registry)

### public interface Unity.Services.Core.Internal.IInitializablePackageV2
- Interfaces: Unity.Services.Core.Internal.IInitializablePackage

#### Methods
- public System.Threading.Tasks.Task InitializeInstanceAsync(Unity.Services.Core.Internal.CoreRegistry registry)
- public void Register(Unity.Services.Core.Internal.CorePackageRegistry registry)

### internal interface Unity.Services.Core.Internal.IPackageRegistry

#### Properties
- public Unity.Services.Core.Internal.DependencyTree Tree { get; set; }

#### Methods
- public void RegisterDependency<TComponent>(int packageTypeHash)
- public void RegisterOptionalDependency<TComponent>(int packageTypeHash)
- public Unity.Services.Core.Internal.CoreRegistration RegisterPackage<TPackage>(TPackage package)
- public void RegisterProvision<TComponent>(int packageTypeHash)

### public interface Unity.Services.Core.Internal.IServiceComponent

### internal interface Unity.Services.Core.Internal.IServiceRegistry

#### Methods
- public T GetService<T>()
- public void RegisterService<T>(T service)

### internal class Unity.Services.Core.Internal.LockedComponentRegistry
- Interfaces: Unity.Services.Core.Internal.IComponentRegistry

#### Fields
- private readonly Unity.Services.Core.Internal.IComponentRegistry <Registry>k__BackingField
- private static const string k_ErrorMessage

#### Properties
- internal Unity.Services.Core.Internal.IComponentRegistry Registry { get; }

#### Constructors
- public LockedComponentRegistry(Unity.Services.Core.Internal.IComponentRegistry registryToLock)

#### Methods
- public TComponent GetServiceComponent<TComponent>()
- public void RegisterServiceComponent<TComponent>(TComponent component)
- public void ResetProvidedComponents(System.Collections.Generic.IDictionary<int, Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance)
- public bool TryGetServiceComponent<TComponent>(out TComponent component)

### internal class Unity.Services.Core.Internal.LockedPackageRegistry
- Interfaces: Unity.Services.Core.Internal.IPackageRegistry

#### Fields
- private readonly Unity.Services.Core.Internal.IPackageRegistry <Registry>k__BackingField
- private static const string k_ErrorMessage

#### Properties
- internal Unity.Services.Core.Internal.IPackageRegistry Registry { get; }
- public Unity.Services.Core.Internal.DependencyTree Tree { get; set; }

#### Constructors
- public LockedPackageRegistry(Unity.Services.Core.Internal.IPackageRegistry registryToLock)

#### Methods
- public void RegisterDependency<TComponent>(int packageTypeHash)
- public void RegisterOptionalDependency<TComponent>(int packageTypeHash)
- public Unity.Services.Core.Internal.CoreRegistration RegisterPackage<TPackage>(TPackage package)
- public void RegisterProvision<TComponent>(int packageTypeHash)

### internal class Unity.Services.Core.Internal.LockedServiceRegistry
- Interfaces: Unity.Services.Core.Internal.IServiceRegistry

#### Fields
- private readonly Unity.Services.Core.Internal.IServiceRegistry <Registry>k__BackingField
- private static const string k_ErrorMessage

#### Properties
- internal Unity.Services.Core.Internal.IServiceRegistry Registry { get; }

#### Constructors
- public LockedServiceRegistry(Unity.Services.Core.Internal.IServiceRegistry registryToLock)

#### Methods
- public T GetService<T>()
- public void RegisterService<T>(T service)

### internal class Unity.Services.Core.Internal.MissingComponent
- Interfaces: Unity.Services.Core.Internal.IServiceComponent

#### Fields
- private readonly System.Type <IntendedType>k__BackingField

#### Properties
- public System.Type IntendedType { get; }

#### Constructors
- internal MissingComponent(System.Type intendedType)

### internal class Unity.Services.Core.Internal.PackageInitializationInfo

#### Fields
- public double InitializationTimeInSeconds
- public System.Type PackageType

#### Constructors
- public PackageInitializationInfo()

### internal class Unity.Services.Core.Internal.PackageRegistry
- Interfaces: Unity.Services.Core.Internal.IPackageRegistry

#### Fields
- private Unity.Services.Core.Internal.DependencyTree <Tree>k__BackingField

#### Properties
- public Unity.Services.Core.Internal.DependencyTree Tree { get; set; }

#### Constructors
- public PackageRegistry(Unity.Services.Core.Internal.DependencyTree tree)

#### Methods
- private void AddComponentDependencyToPackage(int componentTypeHash, int packageTypeHash)
- public void RegisterDependency<TComponent>(int packageTypeHash)
- public void RegisterOptionalDependency<TComponent>(int packageTypeHash)
- public Unity.Services.Core.Internal.CoreRegistration RegisterPackage<TPackage>(TPackage package)
- public void RegisterProvision<TComponent>(int packageTypeHash)

### internal class Unity.Services.Core.Internal.ServiceRegistry
- Interfaces: Unity.Services.Core.Internal.IServiceRegistry

#### Fields
- private readonly System.Collections.Generic.Dictionary<int, object> <ServiceTypeHashToInstance>k__BackingField

#### Properties
- internal System.Collections.Generic.Dictionary<int, object> ServiceTypeHashToInstance { get; }

#### Constructors
- public ServiceRegistry()
- public ServiceRegistry(System.Collections.Generic.Dictionary<int, object> serviceTypeHashToInstance)

#### Methods
- public T GetService<T>()
- public void RegisterService<T>(T service)

### internal enum Unity.Services.Core.Internal.ServicesType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Default = 0
- Instance = 1

### internal class Unity.Services.Core.Internal.TaskAsyncOperation
- Base: Unity.Services.Core.Internal.AsyncOperationBase
- Interfaces: System.Collections.IEnumerator, Unity.Services.Core.Internal.IAsyncOperation, System.Runtime.CompilerServices.INotifyCompletion

#### Fields
- private System.Threading.Tasks.Task m_Task
- internal static System.Threading.Tasks.TaskScheduler Scheduler

#### Properties
- public System.Exception Exception { get; }
- public bool IsCompleted { get; }
- public Unity.Services.Core.Internal.AsyncOperationStatus Status { get; }

#### Constructors
- public TaskAsyncOperation(System.Threading.Tasks.Task task)

#### Methods
- public override Unity.Services.Core.Internal.AsyncOperationBase GetAwaiter()
- public override void GetResult()
- public static Unity.Services.Core.Internal.TaskAsyncOperation Run(System.Action action)
- internal static void SetScheduler()

### internal class Unity.Services.Core.Internal.TaskAsyncOperation<T>
- Base: Unity.Services.Core.Internal.AsyncOperationBase<T>
- Interfaces: System.Collections.IEnumerator, Unity.Services.Core.Internal.IAsyncOperation<T>, System.Runtime.CompilerServices.INotifyCompletion

#### Fields
- private System.Threading.Tasks.Task<T> m_Task

#### Properties
- public System.Exception Exception { get; }
- public bool IsCompleted { get; }
- public T Result { get; }
- public Unity.Services.Core.Internal.AsyncOperationStatus Status { get; }

#### Constructors
- public TaskAsyncOperation<T>(System.Threading.Tasks.Task<T> task)

#### Methods
- public override Unity.Services.Core.Internal.AsyncOperationBase<T> GetAwaiter()
- public override T GetResult()
- public static Unity.Services.Core.Internal.TaskAsyncOperation<T> Run(System.Func<T> func)

### internal static class Unity.Services.Core.Internal.UnityServicesInitializer

#### Methods
- internal static Unity.Services.Core.IUnityServices CreateInstance(string servicesId)
- private static void CreateStaticInstance()
- private static void EnableServicesInitializationAsync()

### internal class Unity.Services.Core.Internal.UnityServicesInternal
- Interfaces: Unity.Services.Core.IUnityServices

#### Fields
- private readonly Unity.Services.Core.Internal.CoreDiagnostics <Diagnostics>k__BackingField
- private readonly Unity.Services.Core.Internal.CoreMetrics <Metrics>k__BackingField
- private readonly Unity.Services.Core.Internal.CoreRegistry <Registry>k__BackingField
- private Unity.Services.Core.ServicesInitializationState <State>k__BackingField
- internal bool CanInitialize
- internal static const string InitFailureEventInvocationError
- private System.Action Initialized
- private System.Action<System.Exception> InitializeFailed
- internal static const string InitSuccessEventInvocationError
- private System.Threading.Tasks.TaskCompletionSource<object> m_Initialization

#### Properties
- internal Unity.Services.Core.Internal.CoreDiagnostics Diagnostics { get; }
- internal Unity.Services.Core.Internal.CoreMetrics Metrics { get; }
- public Unity.Services.Core.InitializationOptions Options { get; internal set; }
- internal Unity.Services.Core.Internal.CoreRegistry Registry { get; }
- public Unity.Services.Core.ServicesInitializationState State { get; private set; }

#### Events
- public event System.Action Initialized
- public event System.Action<System.Exception> InitializeFailed

#### Constructors
- public UnityServicesInternal(Unity.Services.Core.Internal.CoreRegistry registry, Unity.Services.Core.Internal.CoreMetrics coreMetrics, Unity.Services.Core.Internal.CoreDiagnostics coreDiagnostics)

#### Methods
- private bool <InitializeAsync>g__HasInitializationFailed|27_0()
- internal void EnableInitialization()
- internal System.Threading.Tasks.Task EnableInitializationAsync()
- public string GetIdentifier()
- public T GetService<T>()
- private bool HasRequestedInitialization()
- public System.Threading.Tasks.Task InitializeAsync(Unity.Services.Core.InitializationOptions options)
- private System.Threading.Tasks.Task InitializeServicesAsync()
- internal void SendInitializationMetrics(System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo> packageInitInfos)
- private void TriggerInitializeFailed(System.Exception initException)
- private void TriggerInitializeSuccess()

### internal static class Unity.Services.Core.Internal.UnityWebRequestUtils

#### Fields
- public static const string JsonContentType

#### Methods
- public static System.Threading.Tasks.Task<string> GetTextAsync(string uri)
- public static bool HasSucceeded(UnityEngine.Networking.UnityWebRequest self)

### public class Unity.Services.Core.Internal.VisibilityAttribute
- Base: UnityEngine.PropertyAttribute

#### Fields
- private string <PropertyName>k__BackingField
- private object <Value>k__BackingField

#### Properties
- public string PropertyName { get; private set; }
- public object Value { get; private set; }

#### Constructors
- public VisibilityAttribute(string propertyName, object value)

## Namespace: Unity.Services.Core.Internal.Serialization

### internal interface Unity.Services.Core.Internal.Serialization.IJsonSerializer

#### Methods
- public T DeserializeObject<T>(string value)
- public string SerializeObject<T>(T value)

### internal class Unity.Services.Core.Internal.Serialization.NewtonsoftSerializer
- Interfaces: Unity.Services.Core.Internal.Serialization.IJsonSerializer

#### Fields
- private readonly Newtonsoft.Json.JsonSerializer m_Serializer

#### Constructors
- public NewtonsoftSerializer(Newtonsoft.Json.JsonSerializerSettings settings = null)
- internal NewtonsoftSerializer(Newtonsoft.Json.JsonSerializer serializer)

#### Methods
- public T DeserializeObject<T>(string value)
- public string SerializeObject<T>(T value)

## Namespace: Unity.Services.Core.Networking.Internal

### internal struct Unity.Services.Core.Networking.Internal.HttpOptions

#### Fields
- public int RedirectLimit
- public int RequestTimeoutInSeconds

### internal class Unity.Services.Core.Networking.Internal.HttpRequest

#### Fields
- public byte[] Body
- public System.Collections.Generic.Dictionary<string, string> Headers
- public string Method
- public Unity.Services.Core.Networking.Internal.HttpOptions Options
- public string Url

#### Constructors
- public HttpRequest()
- public HttpRequest(string method, string url, System.Collections.Generic.Dictionary<string, string> headers, byte[] body)

#### Methods
- public Unity.Services.Core.Networking.Internal.HttpRequest SetBody(byte[] body)
- public Unity.Services.Core.Networking.Internal.HttpRequest SetHeader(string key, string value)
- public Unity.Services.Core.Networking.Internal.HttpRequest SetHeaders(System.Collections.Generic.Dictionary<string, string> headers)
- public Unity.Services.Core.Networking.Internal.HttpRequest SetMethod(string method)
- public Unity.Services.Core.Networking.Internal.HttpRequest SetOptions(Unity.Services.Core.Networking.Internal.HttpOptions options)
- public Unity.Services.Core.Networking.Internal.HttpRequest SetRedirectLimit(int redirectLimit)
- public Unity.Services.Core.Networking.Internal.HttpRequest SetTimeOutInSeconds(int timeout)
- public Unity.Services.Core.Networking.Internal.HttpRequest SetUrl(string url)

### internal static class Unity.Services.Core.Networking.Internal.HttpRequestExtensions

#### Methods
- public static Unity.Services.Core.Networking.Internal.HttpRequest AsConnect(Unity.Services.Core.Networking.Internal.HttpRequest self)
- public static Unity.Services.Core.Networking.Internal.HttpRequest AsDelete(Unity.Services.Core.Networking.Internal.HttpRequest self)
- public static Unity.Services.Core.Networking.Internal.HttpRequest AsGet(Unity.Services.Core.Networking.Internal.HttpRequest self)
- public static Unity.Services.Core.Networking.Internal.HttpRequest AsHead(Unity.Services.Core.Networking.Internal.HttpRequest self)
- public static Unity.Services.Core.Networking.Internal.HttpRequest AsOptions(Unity.Services.Core.Networking.Internal.HttpRequest self)
- public static Unity.Services.Core.Networking.Internal.HttpRequest AsPatch(Unity.Services.Core.Networking.Internal.HttpRequest self)
- public static Unity.Services.Core.Networking.Internal.HttpRequest AsPost(Unity.Services.Core.Networking.Internal.HttpRequest self)
- public static Unity.Services.Core.Networking.Internal.HttpRequest AsPut(Unity.Services.Core.Networking.Internal.HttpRequest self)
- public static Unity.Services.Core.Networking.Internal.HttpRequest AsTrace(Unity.Services.Core.Networking.Internal.HttpRequest self)

### internal class Unity.Services.Core.Networking.Internal.HttpResponse

#### Fields
- public byte[] Data
- public string ErrorMessage
- public System.Collections.Generic.Dictionary<string, string> Headers
- public bool IsHttpError
- public bool IsNetworkError
- public Unity.Services.Core.Networking.Internal.ReadOnlyHttpRequest Request
- public long StatusCode

#### Constructors
- public HttpResponse()

#### Methods
- public Unity.Services.Core.Networking.Internal.HttpResponse SetData(byte[] data)
- public Unity.Services.Core.Networking.Internal.HttpResponse SetErrorMessage(string errorMessage)
- public Unity.Services.Core.Networking.Internal.HttpResponse SetHeader(string key, string value)
- public Unity.Services.Core.Networking.Internal.HttpResponse SetHeaders(System.Collections.Generic.Dictionary<string, string> headers)
- public Unity.Services.Core.Networking.Internal.HttpResponse SetIsHttpError(bool isHttpError)
- public Unity.Services.Core.Networking.Internal.HttpResponse SetIsNetworkError(bool isNetworkError)
- public Unity.Services.Core.Networking.Internal.HttpResponse SetRequest(Unity.Services.Core.Networking.Internal.HttpRequest request)
- public Unity.Services.Core.Networking.Internal.HttpResponse SetRequest(Unity.Services.Core.Networking.Internal.ReadOnlyHttpRequest request)
- public Unity.Services.Core.Networking.Internal.HttpResponse SetStatusCode(long statusCode)

### internal interface Unity.Services.Core.Networking.Internal.IHttpClient
- Interfaces: Unity.Services.Core.Internal.IServiceComponent

#### Methods
- public Unity.Services.Core.Networking.Internal.HttpRequest CreateRequestForService(string serviceId, string resourcePath)
- public string GetBaseUrlFor(string serviceId)
- public Unity.Services.Core.Networking.Internal.HttpOptions GetDefaultOptionsFor(string serviceId)
- public Unity.Services.Core.Internal.IAsyncOperation<Unity.Services.Core.Networking.Internal.ReadOnlyHttpResponse> Send(Unity.Services.Core.Networking.Internal.HttpRequest request)

### internal struct Unity.Services.Core.Networking.Internal.ReadOnlyHttpRequest

#### Fields
- private Unity.Services.Core.Networking.Internal.HttpRequest m_Request

#### Properties
- public byte[] Body { get; }
- public System.Collections.Generic.IReadOnlyDictionary<string, string> Headers { get; }
- public string Method { get; }
- public string Url { get; }

#### Constructors
- public ReadOnlyHttpRequest(Unity.Services.Core.Networking.Internal.HttpRequest request)

### internal struct Unity.Services.Core.Networking.Internal.ReadOnlyHttpResponse

#### Fields
- private Unity.Services.Core.Networking.Internal.HttpResponse m_Response

#### Properties
- public byte[] Data { get; }
- public string ErrorMessage { get; }
- public System.Collections.Generic.IReadOnlyDictionary<string, string> Headers { get; }
- public bool IsHttpError { get; }
- public bool IsNetworkError { get; }
- public Unity.Services.Core.Networking.Internal.ReadOnlyHttpRequest Request { get; }
- public long StatusCode { get; }

#### Constructors
- public ReadOnlyHttpResponse(Unity.Services.Core.Networking.Internal.HttpResponse response)

## Namespace: Unity.Services.Core.Scheduler.Internal

### public interface Unity.Services.Core.Scheduler.Internal.IActionScheduler
- Interfaces: Unity.Services.Core.Internal.IServiceComponent

#### Methods
- public void CancelAction(long actionId)
- public long ScheduleAction(System.Action action, double delaySeconds = 0)

## Namespace: Unity.Services.Core.Telemetry.Internal

### public interface Unity.Services.Core.Telemetry.Internal.IDiagnostics

#### Methods
- public void SendDiagnostic(string name, string message, System.Collections.Generic.IDictionary<string, string> tags = null)

### internal interface Unity.Services.Core.Telemetry.Internal.IDiagnosticsComponentProvider

#### Methods
- public System.Threading.Tasks.Task<Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory> CreateDiagnosticsComponents()
- public System.Threading.Tasks.Task<string> GetSerializedProjectConfigurationAsync()

### public interface Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory
- Interfaces: Unity.Services.Core.Internal.IServiceComponent

#### Properties
- public System.Collections.Generic.IReadOnlyDictionary<string, string> CommonTags { get; }

#### Methods
- public Unity.Services.Core.Telemetry.Internal.IDiagnostics Create(string packageName)

### public interface Unity.Services.Core.Telemetry.Internal.IMetrics

#### Methods
- public void SendGaugeMetric(string name, double value = 0, System.Collections.Generic.IDictionary<string, string> tags = null)
- public void SendHistogramMetric(string name, double time, System.Collections.Generic.IDictionary<string, string> tags = null)
- public void SendSumMetric(string name, double value = 1, System.Collections.Generic.IDictionary<string, string> tags = null)

### public interface Unity.Services.Core.Telemetry.Internal.IMetricsFactory
- Interfaces: Unity.Services.Core.Internal.IServiceComponent

#### Properties
- public System.Collections.Generic.IReadOnlyDictionary<string, string> CommonTags { get; }

#### Methods
- public Unity.Services.Core.Telemetry.Internal.IMetrics Create(string packageName)

## Namespace: Unity.Services.Core.Threading.Internal

### public interface Unity.Services.Core.Threading.Internal.IUnityThreadUtils
- Interfaces: Unity.Services.Core.Internal.IServiceComponent

#### Properties
- public bool IsRunningOnUnityThread { get; }

#### Methods
- public System.Threading.Tasks.Task PostAsync(System.Action action)
- public System.Threading.Tasks.Task PostAsync(System.Action<object> action, object state)
- public System.Threading.Tasks.Task<T> PostAsync<T>(System.Func<T> action)
- public System.Threading.Tasks.Task<T> PostAsync<T>(System.Func<object, T> action, object state)
- public void Send(System.Action action)
- public void Send(System.Action<object> action, object state)
- public T Send<T>(System.Func<T> action)
- public T Send<T>(System.Func<object, T> action, object state)

## Namespace: Unity.Services.Qos.Internal

### public interface Unity.Services.Qos.Internal.IQosResults
- Interfaces: Unity.Services.Core.Internal.IServiceComponent

#### Methods
- public System.Threading.Tasks.Task<System.Collections.Generic.IList<Unity.Services.Qos.Internal.QosResult>> GetSortedQosResultsAsync(string service, System.Collections.Generic.IList<string> regions)

### public struct Unity.Services.Qos.Internal.QosResult

#### Fields
- public int AverageLatencyMs
- public float PacketLossPercent
- public string Region

## Namespace: Unity.Services.Vivox.Internal

### public interface Unity.Services.Vivox.Internal.IVivox
- Interfaces: Unity.Services.Core.Internal.IServiceComponent

#### Methods
- public void RegisterTokenProvider(Unity.Services.Vivox.Internal.IVivoxTokenProviderInternal tokenProvider)

### public interface Unity.Services.Vivox.Internal.IVivoxTokenProviderInternal

#### Methods
- public System.Threading.Tasks.Task<string> GetTokenAsync(string issuer = null, System.Nullable<System.TimeSpan> expiration = null, string userUri = null, string action = null, string conferenceUri = null, string fromUserUri = null, string realm = null)

## Namespace: Unity.Services.Wire.Internal

### public struct Unity.Services.Wire.Internal.ChannelToken

#### Fields
- public string ChannelName
- public string Token

### public interface Unity.Services.Wire.Internal.IChannel
- Interfaces: System.IDisposable

#### Events
- public event System.Action<byte[]> BinaryMessageReceived
- public event System.Action<string> ErrorReceived
- public event System.Action KickReceived
- public event System.Action<string> MessageReceived
- public event System.Action<Unity.Services.Wire.Internal.SubscriptionState> NewStateReceived

#### Methods
- public System.Threading.Tasks.Task SubscribeAsync()
- public System.Threading.Tasks.Task UnsubscribeAsync()

### public interface Unity.Services.Wire.Internal.IChannelTokenProvider

#### Methods
- public System.Threading.Tasks.Task<Unity.Services.Wire.Internal.ChannelToken> GetTokenAsync()

### public interface Unity.Services.Wire.Internal.IWire
- Interfaces: Unity.Services.Core.Internal.IServiceComponent

#### Methods
- public Unity.Services.Wire.Internal.IChannel CreateChannel(Unity.Services.Wire.Internal.IChannelTokenProvider tokenProvider)

### public enum Unity.Services.Wire.Internal.SubscriptionState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Error = 3
- Subscribing = 4
- Synced = 1
- Unsubscribed = 0
- Unsynced = 2

