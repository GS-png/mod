# Assembly: Unity.Services.Core.Components
- Path: tools/WorldBox.Managed/Unity.Services.Core.Components.dll
- Types: 11

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=316 EDF3AA3E97B42179F8CF73CD22AA74A4516AEE51451990F7A65392F6B150D830
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=175 F7E34D3DFF13FD8D10A0DBAEBF800F0D68F0F548AD8AE92D8BA39DDEC362B415

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=175

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=316

## Namespace: Unity.Services.Core.Components

### private struct Unity.Services.Core.Components.ServicesInitialization.<InitializeOnStartAsync>d__13
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Unity.Services.Core.Components.ServicesInitialization <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Unity.Services.Core.Components.ServicesInitialization.<OnServicesReady>d__9
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Unity.Services.Core.Components.ServicesInitialization <>4__this
- public System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct Unity.Services.Core.Components.ServicesInitialization.<SetupAsync>d__12
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Unity.Services.Core.Components.ServicesInitialization <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### public class Unity.Services.Core.Components.ServicesBehaviour
- Base: UnityEngine.MonoBehaviour

#### Fields
- private Unity.Services.Core.IUnityServices <Services>k__BackingField
- public string ServicesIdentifier
- public bool UseCustomServices

#### Properties
- public Unity.Services.Core.IUnityServices Services { get; internal set; }

#### Constructors
- protected ServicesBehaviour()

#### Methods
- protected abstract void Cleanup()
- internal virtual void OnDestroy()
- protected abstract void OnServicesInitialized()
- protected abstract void OnServicesReady()
- private void SetRegistry()
- internal virtual void Start()

### public class Unity.Services.Core.Components.ServicesInitialization
- Base: Unity.Services.Core.Components.ServicesBehaviour

#### Fields
- private bool <IsSetupDone>k__BackingField
- public string EnvironmentName
- public Unity.Services.Core.Components.ServicesInitializationEvents Events
- public bool InitializeOnStart
- public bool UseCustomEnvironment

#### Properties
- internal bool IsSetupDone { get; private set; }

#### Constructors
- internal ServicesInitialization()

#### Methods
- internal Unity.Services.Core.InitializationOptions BuildInitializationOptions()
- protected override void Cleanup()
- internal System.Threading.Tasks.Task InitializeOnStartAsync()
- private void OnInitialized()
- private void OnInitializeFailed(System.Exception e)
- protected override void OnServicesInitialized()
- protected override void OnServicesReady()
- internal System.Threading.Tasks.Task SetupAsync()

### public class Unity.Services.Core.Components.ServicesInitializationEvents

#### Fields
- public UnityEngine.Events.UnityEvent Initialized
- public UnityEngine.Events.UnityEvent<System.Exception> InitializeFailed

#### Constructors
- public ServicesInitializationEvents()

