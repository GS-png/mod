# Assembly: Unity.Services.Core.Networking
- Path: tools/WorldBox.Managed/Unity.Services.Core.Networking.dll
- Types: 8

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=110 B848F0BA1F5348B3857323C18078F9DEE3399F26BB3AE33B79124259A8E44413
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=204 B8F9F9538BEAEB985CD76998D520D7243659F70EF599ECA01C34B8E9F4E27C03

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=110

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=204

## Namespace: Unity.Services.Core.Networking

### private class Unity.Services.Core.Networking.UnityWebRequestClient.<>c__DisplayClass5_0

#### Fields
- public Unity.Services.Core.Internal.AsyncOperation<Unity.Services.Core.Networking.Internal.ReadOnlyHttpResponse> operation
- public Unity.Services.Core.Networking.Internal.HttpRequest request

#### Constructors
- public UnityWebRequestClient.<>c__DisplayClass5_0()

#### Methods
- internal void <Send>g__OnWebRequestCompleted|0(UnityEngine.AsyncOperation unityOperation)

### internal struct Unity.Services.Core.Networking.HttpServiceConfig

#### Fields
- public string BaseUrl
- public Unity.Services.Core.Networking.Internal.HttpOptions DefaultOptions
- public string ServiceId

### internal class Unity.Services.Core.Networking.UnityWebRequestClient
- Interfaces: Unity.Services.Core.Networking.Internal.IHttpClient, Unity.Services.Core.Internal.IServiceComponent

#### Fields
- private readonly System.Collections.Generic.Dictionary<string, Unity.Services.Core.Networking.HttpServiceConfig> m_ServiceIdToConfig

#### Constructors
- public UnityWebRequestClient()

#### Methods
- internal static string CombinePaths(string path1, string path2)
- private static Unity.Services.Core.Networking.Internal.HttpResponse ConvertToResponse(UnityEngine.Networking.UnityWebRequest webRequest)
- private static UnityEngine.Networking.UnityWebRequest ConvertToWebRequest(Unity.Services.Core.Networking.Internal.HttpRequest request)
- public Unity.Services.Core.Networking.Internal.HttpRequest CreateRequestForService(string serviceId, string resourcePath)
- public string GetBaseUrlFor(string serviceId)
- public Unity.Services.Core.Networking.Internal.HttpOptions GetDefaultOptionsFor(string serviceId)
- public Unity.Services.Core.Internal.IAsyncOperation<Unity.Services.Core.Networking.Internal.ReadOnlyHttpResponse> Send(Unity.Services.Core.Networking.Internal.HttpRequest request)
- internal void SetServiceConfig(Unity.Services.Core.Networking.HttpServiceConfig config)

