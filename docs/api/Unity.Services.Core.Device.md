# Assembly: Unity.Services.Core.Device
- Path: tools/WorldBox.Managed/Unity.Services.Core.Device.dll
- Types: 9

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=443 6175823F1BC7BB82D601298A7C40BD635F142AFBE5A17D2E7BFF4C5D316F3604
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=207 6CA30339308EECA19B8B6EA8320C48BE58A32CCC248CD737A401F32529A9CEC4

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=207

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=443

## Namespace: Unity.Services.Core.Device

### internal class Unity.Services.Core.Device.InstallationId
- Interfaces: Unity.Services.Core.Device.Internal.IInstallationId, Unity.Services.Core.Internal.IServiceComponent

#### Fields
- internal string Identifier
- private static const string k_UnityInstallationIdKey
- internal Unity.Services.Core.Device.IUserIdentifierProvider UnityAdsIdentifierProvider
- internal Unity.Services.Core.Device.IUserIdentifierProvider UnityAnalyticsIdentifierProvider

#### Constructors
- public InstallationId()

#### Methods
- public void CreateIdentifier()
- private static string GenerateGuid()
- public string GetOrCreateIdentifier()
- private static string ReadIdentifierFromFile()
- private static void WriteIdentifierToFile(string identifier)

### internal interface Unity.Services.Core.Device.IUserIdentifierProvider

#### Properties
- public string UserId { get; set; }

### internal class Unity.Services.Core.Device.UnityAdsIdentifier
- Interfaces: Unity.Services.Core.Device.IUserIdentifierProvider

#### Properties
- public string UserId { get; set; }

#### Constructors
- public UnityAdsIdentifier()

### internal class Unity.Services.Core.Device.UnityAnalyticsIdentifier
- Interfaces: Unity.Services.Core.Device.IUserIdentifierProvider

#### Fields
- private static const string k_PlayerUserIdKey

#### Properties
- public string UserId { get; set; }

#### Constructors
- public UnityAnalyticsIdentifier()

