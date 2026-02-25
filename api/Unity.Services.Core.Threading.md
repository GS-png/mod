# Assembly: Unity.Services.Core.Threading
- Path: tools/WorldBox.Managed/Unity.Services.Core.Threading.dll
- Types: 6

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=68 442810E4628B37393A11E62F5D1EB987045E7B087084C5714A16FA7059522B9C
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=106 64C5C69C251D4E9DB39663C3D46A49D1E0D975B702CA5F44CD3792CA1B9B771A

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=106

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=68

## Namespace: Unity.Services.Core.Threading.Internal

### internal class Unity.Services.Core.Threading.Internal.UnityThreadUtilsInternal
- Interfaces: Unity.Services.Core.Threading.Internal.IUnityThreadUtils, Unity.Services.Core.Internal.IServiceComponent

#### Properties
- private bool Unity.Services.Core.Threading.Internal.IUnityThreadUtils.IsRunningOnUnityThread { get; }

#### Constructors
- public UnityThreadUtilsInternal()

#### Methods
- public static System.Threading.Tasks.Task PostAsync(System.Action action)
- public static System.Threading.Tasks.Task PostAsync(System.Action<object> action, object state)
- public static System.Threading.Tasks.Task<T> PostAsync<T>(System.Func<T> action)
- public static System.Threading.Tasks.Task<T> PostAsync<T>(System.Func<object, T> action, object state)
- public static void Send(System.Action action)
- public static void Send(System.Action<object> action, object state)
- public static T Send<T>(System.Func<T> action)
- public static T Send<T>(System.Func<object, T> action, object state)
- private System.Threading.Tasks.Task Unity.Services.Core.Threading.Internal.IUnityThreadUtils.PostAsync(System.Action action)
- private System.Threading.Tasks.Task Unity.Services.Core.Threading.Internal.IUnityThreadUtils.PostAsync(System.Action<object> action, object state)
- private System.Threading.Tasks.Task<T> Unity.Services.Core.Threading.Internal.IUnityThreadUtils.PostAsync<T>(System.Func<T> action)
- private System.Threading.Tasks.Task<T> Unity.Services.Core.Threading.Internal.IUnityThreadUtils.PostAsync<T>(System.Func<object, T> action, object state)
- private void Unity.Services.Core.Threading.Internal.IUnityThreadUtils.Send(System.Action action)
- private void Unity.Services.Core.Threading.Internal.IUnityThreadUtils.Send(System.Action<object> action, object state)
- private T Unity.Services.Core.Threading.Internal.IUnityThreadUtils.Send<T>(System.Func<T> action)
- private T Unity.Services.Core.Threading.Internal.IUnityThreadUtils.Send<T>(System.Func<object, T> action, object state)

