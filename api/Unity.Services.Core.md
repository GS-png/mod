# Assembly: Unity.Services.Core
- Path: tools/WorldBox.Managed/Unity.Services.Core.dll
- Types: 21

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1350 3003D238978BF13A79EA98BAF83CB1DA2107B91BF9242D84AD830C519A1C031F
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=602 A1F212915A3E9DAE646449489FB04630F076354DC5E298C0F32EA5583AF6C6B6

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1350

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=602

## Namespace: System.Runtime.CompilerServices

### internal class System.Runtime.CompilerServices.PreserveDependencyAttribute
- Base: System.Attribute

#### Fields
- private string <Condition>k__BackingField

#### Properties
- public string Condition { get; set; }

#### Constructors
- public PreserveDependencyAttribute(string memberSignature)
- public PreserveDependencyAttribute(string memberSignature, string typeName)
- public PreserveDependencyAttribute(string memberSignature, string typeName, string assembly)

## Namespace: Unity.Services.Core

### private struct Unity.Services.Core.UnityServices.<InitializeAsync>d__26
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<object> <>u__1
- private System.Runtime.CompilerServices.TaskAwaiter <>u__2
- public Unity.Services.Core.InitializationOptions options

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### public static class Unity.Services.Core.CommonErrorCodes

#### Fields
- public static const int ApiMissing
- public static const int Conflict
- public static const int Forbidden
- public static const int InvalidRequest
- public static const int InvalidToken
- public static const int NotFound
- public static const int PlayerPolicyAccessDenied
- public static const int ProjectPolicyAccessDenied
- public static const int RequestRejected
- public static const int ServiceUnavailable
- public static const int Timeout
- public static const int TokenExpired
- public static const int TooManyRequests
- public static const int TransportError
- public static const int Unknown

### internal delegate Unity.Services.Core.UnityServicesBuilder.CreationDelegate
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public UnityServicesBuilder.CreationDelegate(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(string servicesId, System.AsyncCallback callback, object object)
- public virtual Unity.Services.Core.IUnityServices EndInvoke(System.IAsyncResult result)
- public virtual Unity.Services.Core.IUnityServices Invoke(string servicesId)

### internal class Unity.Services.Core.ExternalUserIdProperty

#### Fields
- private string m_UserId
- private System.Action<string> UserIdChanged

#### Properties
- public string UserId { get; set; }

#### Events
- public event System.Action<string> UserIdChanged

#### Constructors
- public ExternalUserIdProperty()

### public class Unity.Services.Core.InitializationOptions

#### Fields
- private readonly System.Collections.Generic.IDictionary<string, object> <Values>k__BackingField

#### Properties
- internal System.Collections.Generic.IDictionary<string, object> Values { get; }

#### Constructors
- public InitializationOptions()
- internal InitializationOptions(System.Collections.Generic.IDictionary<string, object> values)
- internal InitializationOptions(Unity.Services.Core.InitializationOptions source)

#### Methods
- public Unity.Services.Core.InitializationOptions SetOption(string key, bool value)
- public Unity.Services.Core.InitializationOptions SetOption(string key, int value)
- public Unity.Services.Core.InitializationOptions SetOption(string key, float value)
- public Unity.Services.Core.InitializationOptions SetOption(string key, string value)
- public bool TryGetOption(string key, out bool option)
- public bool TryGetOption(string key, out int option)
- public bool TryGetOption(string key, out float option)
- public bool TryGetOption(string key, out string option)
- private bool TryGetOption<T>(string key, out T option)

### public interface Unity.Services.Core.IService

### public interface Unity.Services.Core.IUnityServices

#### Properties
- public Unity.Services.Core.ServicesInitializationState State { get; }

#### Events
- public event System.Action Initialized
- public event System.Action<System.Exception> InitializeFailed

#### Methods
- public string GetIdentifier()
- public T GetService<T>()
- public System.Threading.Tasks.Task InitializeAsync(Unity.Services.Core.InitializationOptions options = null)

### public class Unity.Services.Core.RequestFailedException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Fields
- private readonly int <ErrorCode>k__BackingField

#### Properties
- public int ErrorCode { get; }

#### Constructors
- public RequestFailedException(int errorCode, string message)
- public RequestFailedException(int errorCode, string message, System.Exception innerException)

### public class Unity.Services.Core.ServicesCreationException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public ServicesCreationException(string message)

### public class Unity.Services.Core.ServicesInitializationException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public ServicesInitializationException()
- public ServicesInitializationException(string message)
- public ServicesInitializationException(string message, System.Exception innerException)

### public enum Unity.Services.Core.ServicesInitializationState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Initialized = 2
- Initializing = 1
- Uninitialized = 0

### internal class Unity.Services.Core.UnityProjectNotLinkedException
- Base: Unity.Services.Core.ServicesInitializationException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public UnityProjectNotLinkedException()
- public UnityProjectNotLinkedException(string message)

### public static class Unity.Services.Core.UnityServices

#### Fields
- private static Unity.Services.Core.IUnityServices <Instance>k__BackingField
- private static System.Threading.Tasks.TaskCompletionSource<object> <InstantiationCompletion>k__BackingField
- private static readonly System.Collections.Generic.Dictionary<string, Unity.Services.Core.IUnityServices> <s_Services>k__BackingField
- internal static Unity.Services.Core.ExternalUserIdProperty ExternalUserIdProperty

#### Properties
- public static string ExternalUserId { get; set; }
- public static Unity.Services.Core.IUnityServices Instance { get; set; }
- internal static System.Threading.Tasks.TaskCompletionSource<object> InstantiationCompletion { get; set; }
- public static System.Collections.Generic.IReadOnlyDictionary<string, Unity.Services.Core.IUnityServices> Services { get; }
- public static Unity.Services.Core.ServicesInitializationState State { get; }
- private static System.Collections.Generic.Dictionary<string, Unity.Services.Core.IUnityServices> s_Services { get; }

#### Events
- public static event System.Action Initialized
- public static event System.Action<System.Exception> InitializeFailed

#### Constructors
- private static UnityServices()

#### Methods
- internal static void ClearServices()
- public static Unity.Services.Core.IUnityServices CreateServices()
- public static Unity.Services.Core.IUnityServices CreateServices(string servicesId)
- public static System.Threading.Tasks.Task InitializeAsync()
- public static System.Threading.Tasks.Task InitializeAsync(Unity.Services.Core.InitializationOptions options)

### internal static class Unity.Services.Core.UnityServicesBuilder

#### Fields
- private static Unity.Services.Core.UnityServicesBuilder.CreationDelegate <InstanceCreationDelegate>k__BackingField

#### Properties
- internal static Unity.Services.Core.UnityServicesBuilder.CreationDelegate InstanceCreationDelegate { get; set; }

#### Methods
- public static Unity.Services.Core.IUnityServices Create(string servicesId)

### internal static class Unity.Services.Core.UnityThreadUtils

#### Fields
- private static System.Threading.Tasks.TaskScheduler <UnityThreadScheduler>k__BackingField
- private static int s_UnityThreadId

#### Properties
- public static bool IsRunningOnUnityThread { get; }
- internal static System.Threading.Tasks.TaskScheduler UnityThreadScheduler { get; private set; }

#### Methods
- private static void CaptureUnityThreadInfo()

