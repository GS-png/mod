# Assembly: Unity.Services.Core.Configuration
- Path: tools/WorldBox.Managed/Unity.Services.Core.Configuration.dll
- Types: 18

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=673 64E9C7B69A880DA21AAF5A5F489451043DD906362721E5E1CCF59FE6BDC1E65B
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1196 A1C3C7BD2AEE185F2E15F1D600BCDC8EF13BCECAA6AC10446CB078FA9528BE76

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1196

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=673

## Namespace: Unity.Services.Core.Configuration

### private class Unity.Services.Core.Configuration.ProjectConfiguration.<>c

#### Fields
- public static readonly Unity.Services.Core.Configuration.ProjectConfiguration.<>c <>9
- public static System.Func<System.Collections.Generic.KeyValuePair<string, Unity.Services.Core.Configuration.ConfigurationEntry>, string> <>9__10_0
- public static System.Func<System.Collections.Generic.KeyValuePair<string, Unity.Services.Core.Configuration.ConfigurationEntry>, string> <>9__10_1

#### Constructors
- private static ProjectConfiguration.<>c()
- public ProjectConfiguration.<>c()

#### Methods
- internal string <ToJson>b__10_0(System.Collections.Generic.KeyValuePair<string, Unity.Services.Core.Configuration.ConfigurationEntry> pair)
- internal string <ToJson>b__10_1(System.Collections.Generic.KeyValuePair<string, Unity.Services.Core.Configuration.ConfigurationEntry> pair)

### private struct Unity.Services.Core.Configuration.StreamingAssetsConfigurationLoader.<GetConfigAsync>d__2
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Unity.Services.Core.Configuration.StreamingAssetsConfigurationLoader <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<string> <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### internal class Unity.Services.Core.Configuration.CloudProjectId
- Interfaces: Unity.Services.Core.Configuration.Internal.ICloudProjectId, Unity.Services.Core.Internal.IServiceComponent

#### Constructors
- public CloudProjectId()

#### Methods
- public string GetCloudProjectId()

### internal static class Unity.Services.Core.Configuration.ConfigurationCollectionHelper

#### Methods
- public static void FillWith(System.Collections.Generic.IDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> self, Unity.Services.Core.Configuration.SerializableProjectConfiguration config)
- public static void FillWith(System.Collections.Generic.IDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> self, Unity.Services.Core.InitializationOptions options)
- private static void SetOrCreateEntry(System.Collections.Generic.IDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> self, string key, Unity.Services.Core.Configuration.ConfigurationEntry entry)

### internal class Unity.Services.Core.Configuration.ConfigurationEntry

#### Fields
- private bool m_IsReadOnly
- private string m_Value

#### Properties
- public bool IsReadOnly { get; internal set; }
- public string Value { get; }

#### Constructors
- public ConfigurationEntry()
- public ConfigurationEntry(string value, bool isReadOnly = false)

#### Methods
- public static string op_Implicit(Unity.Services.Core.Configuration.ConfigurationEntry entry)
- public static Unity.Services.Core.Configuration.ConfigurationEntry op_Implicit(string value)
- public bool TrySetValue(string value)

### internal static class Unity.Services.Core.Configuration.ConfigurationUtils

#### Fields
- private static Unity.Services.Core.Configuration.IConfigurationLoader <ConfigurationLoader>k__BackingField
- public static const string ConfigFileName

#### Properties
- public static Unity.Services.Core.Configuration.IConfigurationLoader ConfigurationLoader { get; internal set; }

#### Constructors
- private static ConfigurationUtils()

### internal class Unity.Services.Core.Configuration.ExternalUserId
- Interfaces: Unity.Services.Core.Configuration.Internal.IExternalUserId, Unity.Services.Core.Internal.IServiceComponent

#### Properties
- public string UserId { get; }

#### Events
- public event System.Action<string> UserIdChanged

#### Constructors
- public ExternalUserId()

### internal interface Unity.Services.Core.Configuration.IConfigurationLoader

#### Methods
- public System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetConfigAsync()

### internal class Unity.Services.Core.Configuration.MemoryConfigurationLoader
- Interfaces: Unity.Services.Core.Configuration.IConfigurationLoader

#### Fields
- private Unity.Services.Core.Configuration.SerializableProjectConfiguration <Config>k__BackingField

#### Properties
- public Unity.Services.Core.Configuration.SerializableProjectConfiguration Config { get; set; }

#### Constructors
- public MemoryConfigurationLoader()

#### Methods
- private System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> Unity.Services.Core.Configuration.IConfigurationLoader.GetConfigAsync()

### internal class Unity.Services.Core.Configuration.ProjectConfiguration
- Interfaces: Unity.Services.Core.Configuration.Internal.IProjectConfiguration, Unity.Services.Core.Internal.IServiceComponent

#### Fields
- private readonly Unity.Services.Core.Internal.Serialization.IJsonSerializer <Serializer>k__BackingField
- private readonly System.Collections.Generic.IReadOnlyDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> m_ConfigValues
- private string m_JsonCache

#### Properties
- internal Unity.Services.Core.Internal.Serialization.IJsonSerializer Serializer { get; }

#### Constructors
- public ProjectConfiguration(System.Collections.Generic.IReadOnlyDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> configValues, Unity.Services.Core.Internal.Serialization.IJsonSerializer serializer)

#### Methods
- public bool GetBool(string key, bool defaultValue = false)
- public float GetFloat(string key, float defaultValue = 0)
- public int GetInt(string key, int defaultValue = 0)
- public string GetString(string key, string defaultValue = null)
- public string ToJson()

### internal struct Unity.Services.Core.Configuration.SerializableProjectConfiguration

#### Fields
- internal string[] Keys
- internal Unity.Services.Core.Configuration.ConfigurationEntry[] Values

#### Properties
- public static Unity.Services.Core.Configuration.SerializableProjectConfiguration Empty { get; }

#### Constructors
- public SerializableProjectConfiguration(System.Collections.Generic.IDictionary<string, Unity.Services.Core.Configuration.ConfigurationEntry> configValues)

### internal class Unity.Services.Core.Configuration.StreamingAssetsConfigurationLoader
- Interfaces: Unity.Services.Core.Configuration.IConfigurationLoader

#### Fields
- private readonly Unity.Services.Core.Internal.Serialization.IJsonSerializer m_Serializer

#### Constructors
- public StreamingAssetsConfigurationLoader(Unity.Services.Core.Internal.Serialization.IJsonSerializer serializer)

#### Methods
- public System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetConfigAsync()

### internal static class Unity.Services.Core.Configuration.StreamingAssetsUtils

#### Methods
- public static System.Threading.Tasks.Task<string> GetFileTextFromStreamingAssetsAsync(string path)

