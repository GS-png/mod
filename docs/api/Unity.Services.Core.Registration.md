# Assembly: Unity.Services.Core.Registration
- Path: tools/WorldBox.Managed/Unity.Services.Core.Registration.dll
- Types: 12

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=107 3FC4ED754DF26C8E60DE71F8D9CE83A44A2807866706C36F30B658CDFF9D4F6C
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=60 AB67D1DC98F15F881C9E854C32002F43AE8EE92BEC4031BCE48157E23FE7BB5B

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=107

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=60

## Namespace: Unity.Services.Core.Registration

### private struct Unity.Services.Core.Registration.CorePackageInitializer.<CreateDiagnosticsComponents>d__61
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Unity.Services.Core.Registration.CorePackageInitializer <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Unity.Services.Core.Registration.CorePackageInitializer.<GenerateProjectConfigurationAsync>d__53
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Unity.Services.Core.Registration.CorePackageInitializer <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Configuration.ProjectConfiguration> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>u__1
- public Unity.Services.Core.InitializationOptions options

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Unity.Services.Core.Registration.CorePackageInitializer.<GetSerializedConfigOrEmptyAsync>d__54
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Unity.Services.Core.Registration.CorePackageInitializer.<GetSerializedProjectConfigurationAsync>d__63
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Unity.Services.Core.Registration.CorePackageInitializer <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<string> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Unity.Services.Core.Registration.CorePackageInitializer.<InitializeComponents>d__47
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Unity.Services.Core.Registration.CorePackageInitializer <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Unity.Services.Core.Registration.CorePackageInitializer.<InitializeProjectConfigAsync>d__52
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Unity.Services.Core.Registration.CorePackageInitializer <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Configuration.ProjectConfiguration> <>u__1
- public Unity.Services.Core.InitializationOptions options

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### internal class Unity.Services.Core.Registration.CorePackageInitializer
- Interfaces: Unity.Services.Core.Internal.IInitializablePackageV2, Unity.Services.Core.Internal.IInitializablePackage, Unity.Services.Core.Telemetry.Internal.IDiagnosticsComponentProvider

#### Fields
- private Unity.Services.Core.Scheduler.Internal.ActionScheduler <ActionScheduler>k__BackingField
- private Unity.Services.Core.Configuration.Internal.ICloudProjectId <CloudProjectId>k__BackingField
- private Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory <DiagnosticsFactory>k__BackingField
- private Unity.Services.Core.Environments.Internal.Environments <Environments>k__BackingField
- private Unity.Services.Core.Configuration.ExternalUserId <ExternalUserId>k__BackingField
- private Unity.Services.Core.Device.InstallationId <InstallationId>k__BackingField
- private Unity.Services.Core.Telemetry.Internal.IMetricsFactory <MetricsFactory>k__BackingField
- private Unity.Services.Core.Configuration.ProjectConfiguration <ProjectConfig>k__BackingField
- private Unity.Services.Core.Threading.Internal.UnityThreadUtilsInternal <UnityThreadUtils>k__BackingField
- internal static const string CorePackageName
- private Unity.Services.Core.InitializationOptions m_CurrentInitializationOptions
- private Unity.Services.Core.Internal.CoreRegistry m_Registry
- private readonly Unity.Services.Core.Internal.Serialization.IJsonSerializer m_Serializer
- internal static const string ProjectUnlinkMessage

#### Properties
- internal Unity.Services.Core.Scheduler.Internal.ActionScheduler ActionScheduler { get; private set; }
- internal Unity.Services.Core.Configuration.Internal.ICloudProjectId CloudProjectId { get; private set; }
- internal Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory DiagnosticsFactory { get; private set; }
- internal Unity.Services.Core.Environments.Internal.Environments Environments { get; private set; }
- internal Unity.Services.Core.Configuration.ExternalUserId ExternalUserId { get; private set; }
- internal Unity.Services.Core.Device.InstallationId InstallationId { get; private set; }
- internal Unity.Services.Core.Telemetry.Internal.IMetricsFactory MetricsFactory { get; private set; }
- internal Unity.Services.Core.Configuration.ProjectConfiguration ProjectConfig { get; private set; }
- internal Unity.Services.Core.Threading.Internal.UnityThreadUtilsInternal UnityThreadUtils { get; private set; }

#### Constructors
- public CorePackageInitializer()
- public CorePackageInitializer(Unity.Services.Core.Internal.Serialization.IJsonSerializer serializer)

#### Methods
- private void <InitializeComponents>g__RegisterProvidedComponents|47_0()
- internal static bool <InitializeComponents>g__SendFailedInitDiagnostic|47_1(System.Exception reason)
- public System.Threading.Tasks.Task<Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory> CreateDiagnosticsComponents()
- private void FreeOptionsDependantComponents()
- internal System.Threading.Tasks.Task<Unity.Services.Core.Configuration.ProjectConfiguration> GenerateProjectConfigurationAsync(Unity.Services.Core.InitializationOptions options)
- internal static System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetSerializedConfigOrEmptyAsync()
- public System.Threading.Tasks.Task<string> GetSerializedProjectConfigurationAsync()
- private bool HaveInitOptionsChanged()
- public System.Threading.Tasks.Task Initialize(Unity.Services.Core.Internal.CoreRegistry registry)
- internal void InitializeActionScheduler()
- internal void InitializeCloudProjectId(Unity.Services.Core.Configuration.Internal.ICloudProjectId cloudProjectId = null)
- private System.Threading.Tasks.Task InitializeComponents()
- internal void InitializeDiagnostics()
- internal void InitializeEnvironments(Unity.Services.Core.Configuration.Internal.IProjectConfiguration projectConfiguration)
- internal void InitializeExternalUserId(Unity.Services.Core.Configuration.Internal.IProjectConfiguration projectConfiguration)
- internal void InitializeInstallationId()
- public System.Threading.Tasks.Task InitializeInstanceAsync(Unity.Services.Core.Internal.CoreRegistry registry)
- internal void InitializeMetrics()
- private static void InitializeOnLoad()
- internal System.Threading.Tasks.Task InitializeProjectConfigAsync(Unity.Services.Core.InitializationOptions options)
- internal void InitializeUnityThreadUtils()
- private void LogInitializationInfoJson()
- public void Register(Unity.Services.Core.Internal.CorePackageRegistry registry)

