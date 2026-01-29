# Assembly: UnityEngine.SubsystemsModule
- Path: tools/WorldBox.Managed/UnityEngine.SubsystemsModule.dll
- Types: 27

## Namespace: UnityEngine

### public class UnityEngine.IntegratedSubsystem
- Interfaces: UnityEngine.ISubsystem

#### Fields
- internal System.IntPtr m_Ptr
- internal UnityEngine.ISubsystemDescriptor m_SubsystemDescriptor

#### Properties
- public bool running { get; }
- internal bool valid { get; }

#### Constructors
- public IntegratedSubsystem()

#### Methods
- public void Destroy()
- internal bool IsRunning()
- internal void SetHandle(UnityEngine.IntegratedSubsystem subsystem)
- public void Start()
- public void Stop()

### public class UnityEngine.IntegratedSubsystemDescriptor
- Interfaces: UnityEngine.ISubsystemDescriptorImpl, UnityEngine.ISubsystemDescriptor

#### Fields
- internal System.IntPtr m_Ptr

#### Properties
- public string id { get; }
- private System.IntPtr UnityEngine.ISubsystemDescriptorImpl.ptr { get; set; }

#### Constructors
- protected IntegratedSubsystemDescriptor()

#### Methods
- internal abstract UnityEngine.ISubsystem CreateImpl()
- private UnityEngine.ISubsystem UnityEngine.ISubsystemDescriptor.Create()

### public class UnityEngine.IntegratedSubsystemDescriptor<TSubsystem>
- Base: UnityEngine.IntegratedSubsystemDescriptor
- Interfaces: UnityEngine.ISubsystemDescriptorImpl, UnityEngine.ISubsystemDescriptor

#### Constructors
- public IntegratedSubsystemDescriptor<TSubsystem>()

#### Methods
- public TSubsystem Create()
- internal override UnityEngine.ISubsystem CreateImpl()

### public class UnityEngine.IntegratedSubsystem<TSubsystemDescriptor>
- Base: UnityEngine.IntegratedSubsystem
- Interfaces: UnityEngine.ISubsystem

#### Properties
- public TSubsystemDescriptor subsystemDescriptor { get; }
- public TSubsystemDescriptor SubsystemDescriptor { get; }

#### Constructors
- public IntegratedSubsystem<TSubsystemDescriptor>()

### internal static class UnityEngine.Internal_SubsystemDescriptors

#### Methods
- internal static void Internal_AddDescriptor(UnityEngine.SubsystemDescriptor descriptor)

### public interface UnityEngine.ISubsystem

#### Properties
- public bool running { get; }

#### Methods
- public void Destroy()
- public void Start()
- public void Stop()

### public interface UnityEngine.ISubsystemDescriptor

#### Properties
- public string id { get; }

#### Methods
- public UnityEngine.ISubsystem Create()

### internal interface UnityEngine.ISubsystemDescriptorImpl
- Interfaces: UnityEngine.ISubsystemDescriptor

#### Properties
- public System.IntPtr ptr { get; set; }

### public class UnityEngine.Subsystem
- Interfaces: UnityEngine.ISubsystem

#### Fields
- internal UnityEngine.ISubsystemDescriptor m_SubsystemDescriptor

#### Properties
- public bool running { get; }

#### Constructors
- protected Subsystem()

#### Methods
- public void Destroy()
- protected abstract void OnDestroy()
- public abstract void Start()
- public abstract void Stop()

### internal static class UnityEngine.SubsystemBindings

#### Methods
- internal static void DestroySubsystem(System.IntPtr nativePtr)

### public class UnityEngine.SubsystemDescriptor
- Interfaces: UnityEngine.ISubsystemDescriptor

#### Fields
- private string <id>k__BackingField
- private System.Type <subsystemImplementationType>k__BackingField

#### Properties
- public string id { get; set; }
- public System.Type subsystemImplementationType { get; set; }

#### Constructors
- protected SubsystemDescriptor()

#### Methods
- internal abstract UnityEngine.ISubsystem CreateImpl()
- private UnityEngine.ISubsystem UnityEngine.ISubsystemDescriptor.Create()

### internal static class UnityEngine.SubsystemDescriptorBindings

#### Methods
- public static System.IntPtr Create(System.IntPtr descriptorPtr)
- public static string GetId(System.IntPtr descriptorPtr)

### public class UnityEngine.SubsystemDescriptor<TSubsystem>
- Base: UnityEngine.SubsystemDescriptor
- Interfaces: UnityEngine.ISubsystemDescriptor

#### Constructors
- public SubsystemDescriptor<TSubsystem>()

#### Methods
- public TSubsystem Create()
- internal override UnityEngine.ISubsystem CreateImpl()

### public static class UnityEngine.SubsystemManager

#### Fields
- private static System.Action afterReloadSubsystems
- private static System.Action beforeReloadSubsystems
- private static System.Action reloadSubsytemsCompleted
- private static System.Action reloadSubsytemsStarted
- private static System.Collections.Generic.List<UnityEngine.Subsystem> s_DeprecatedSubsystems
- private static System.Collections.Generic.List<UnityEngine.IntegratedSubsystem> s_IntegratedSubsystems
- private static System.Collections.Generic.List<UnityEngine.SubsystemsImplementation.SubsystemWithProvider> s_StandaloneSubsystems

#### Events
- public static event System.Action afterReloadSubsystems
- public static event System.Action beforeReloadSubsystems
- public static event System.Action reloadSubsytemsCompleted
- public static event System.Action reloadSubsytemsStarted

#### Constructors
- private static SubsystemManager()

#### Methods
- internal static void AddDeprecatedSubsystem(UnityEngine.Subsystem subsystem)
- internal static void AddStandaloneSubsystem(UnityEngine.SubsystemsImplementation.SubsystemWithProvider subsystem)
- private static void AddSubsystemSubset<TBaseTypeInList, TQueryType>(System.Collections.Generic.List<TBaseTypeInList> copyFrom, System.Collections.Generic.List<TQueryType> copyTo)
- private static void ClearSubsystems()
- internal static UnityEngine.Subsystem FindDeprecatedSubsystemByDescriptor(UnityEngine.SubsystemDescriptor descriptor)
- internal static UnityEngine.SubsystemsImplementation.SubsystemWithProvider FindStandaloneSubsystemByDescriptor(UnityEngine.SubsystemsImplementation.SubsystemDescriptorWithProvider descriptor)
- public static void GetAllSubsystemDescriptors(System.Collections.Generic.List<UnityEngine.ISubsystemDescriptor> descriptors)
- public static void GetInstances<T>(System.Collections.Generic.List<T> subsystems)
- internal static UnityEngine.IntegratedSubsystem GetIntegratedSubsystemByPtr(System.IntPtr ptr)
- public static void GetSubsystemDescriptors<T>(System.Collections.Generic.List<T> descriptors)
- public static void GetSubsystems<T>(System.Collections.Generic.List<T> subsystems)
- private static void InitializeIntegratedSubsystem(System.IntPtr ptr, UnityEngine.IntegratedSubsystem subsystem)
- private static void ReloadSubsystemsCompleted()
- private static void ReloadSubsystemsStarted()
- internal static bool RemoveDeprecatedSubsystem(UnityEngine.Subsystem subsystem)
- internal static void RemoveIntegratedSubsystemByPtr(System.IntPtr ptr)
- internal static bool RemoveStandaloneSubsystem(UnityEngine.SubsystemsImplementation.SubsystemWithProvider subsystem)
- internal static void ReportSingleSubsystemAnalytics(string id)
- private static void StaticConstructScriptingClassMap()

### public class UnityEngine.Subsystem<TSubsystemDescriptor>
- Base: UnityEngine.Subsystem
- Interfaces: UnityEngine.ISubsystem

#### Properties
- public TSubsystemDescriptor SubsystemDescriptor { get; }

#### Constructors
- protected Subsystem<TSubsystemDescriptor>()

## Namespace: UnityEngine.Subsystems

### public class UnityEngine.Subsystems.ExampleSubsystem
- Base: UnityEngine.IntegratedSubsystem<UnityEngine.Subsystems.ExampleSubsystemDescriptor>
- Interfaces: UnityEngine.ISubsystem

#### Constructors
- public ExampleSubsystem()

#### Methods
- public bool GetBool()
- public void PrintExample()

### public class UnityEngine.Subsystems.ExampleSubsystemDescriptor
- Base: UnityEngine.IntegratedSubsystemDescriptor<UnityEngine.Subsystems.ExampleSubsystem>
- Interfaces: UnityEngine.ISubsystemDescriptorImpl, UnityEngine.ISubsystemDescriptor

#### Properties
- public bool disableBackbufferMSAA { get; }
- public bool stereoscopicBackbuffer { get; }
- public bool supportsEditorMode { get; }
- public bool usePBufferEGL { get; }

#### Constructors
- public ExampleSubsystemDescriptor()

## Namespace: UnityEngine.SubsystemsImplementation

### public static class UnityEngine.SubsystemsImplementation.SubsystemDescriptorStore

#### Fields
- private static System.Collections.Generic.List<UnityEngine.SubsystemDescriptor> s_DeprecatedDescriptors
- private static System.Collections.Generic.List<UnityEngine.IntegratedSubsystemDescriptor> s_IntegratedDescriptors
- private static System.Collections.Generic.List<UnityEngine.SubsystemsImplementation.SubsystemDescriptorWithProvider> s_StandaloneDescriptors

#### Constructors
- private static SubsystemDescriptorStore()

#### Methods
- private static void AddDescriptorSubset<TBaseTypeInList>(System.Collections.Generic.List<TBaseTypeInList> copyFrom, System.Collections.Generic.List<UnityEngine.ISubsystemDescriptor> copyTo)
- private static void AddDescriptorSubset<TBaseTypeInList, TQueryType>(System.Collections.Generic.List<TBaseTypeInList> copyFrom, System.Collections.Generic.List<TQueryType> copyTo)
- internal static void ClearManagedDescriptors()
- internal static void GetAllSubsystemDescriptors(System.Collections.Generic.List<UnityEngine.ISubsystemDescriptor> descriptors)
- internal static void GetSubsystemDescriptors<T>(System.Collections.Generic.List<T> descriptors)
- internal static void InitializeManagedDescriptor(System.IntPtr ptr, UnityEngine.IntegratedSubsystemDescriptor desc)
- internal static void RegisterDeprecatedDescriptor(UnityEngine.SubsystemDescriptor descriptor)
- public static void RegisterDescriptor(UnityEngine.SubsystemsImplementation.SubsystemDescriptorWithProvider descriptor)
- internal static void RegisterDescriptor<TDescriptor, TBaseTypeInList>(TDescriptor descriptor, System.Collections.Generic.List<TBaseTypeInList> storeInList)
- private static void ReportSingleSubsystemAnalytics(string id)

### public class UnityEngine.SubsystemsImplementation.SubsystemDescriptorWithProvider
- Interfaces: UnityEngine.ISubsystemDescriptor

#### Fields
- private string <id>k__BackingField
- private System.Type <providerType>k__BackingField
- private System.Type <subsystemTypeOverride>k__BackingField

#### Properties
- public string id { get; set; }
- protected internal System.Type providerType { get; set; }
- protected internal System.Type subsystemTypeOverride { get; set; }

#### Constructors
- protected SubsystemDescriptorWithProvider()

#### Methods
- internal abstract UnityEngine.ISubsystem CreateImpl()
- internal abstract void ThrowIfInvalid()
- private UnityEngine.ISubsystem UnityEngine.ISubsystemDescriptor.Create()

### public class UnityEngine.SubsystemsImplementation.SubsystemDescriptorWithProvider<TSubsystem, TProvider>
- Base: UnityEngine.SubsystemsImplementation.SubsystemDescriptorWithProvider
- Interfaces: UnityEngine.ISubsystemDescriptor

#### Constructors
- public SubsystemDescriptorWithProvider<TSubsystem, TProvider>()

#### Methods
- public TSubsystem Create()
- internal override UnityEngine.ISubsystem CreateImpl()
- internal TProvider CreateProvider()
- internal override void ThrowIfInvalid()

### public class UnityEngine.SubsystemsImplementation.SubsystemProvider

#### Fields
- internal bool m_Running

#### Properties
- public bool running { get; }

#### Constructors
- protected SubsystemProvider()

### public class UnityEngine.SubsystemsImplementation.SubsystemProvider<TSubsystem>
- Base: UnityEngine.SubsystemsImplementation.SubsystemProvider

#### Constructors
- protected SubsystemProvider<TSubsystem>()

#### Methods
- public abstract void Destroy()
- public abstract void Start()
- public abstract void Stop()
- protected internal virtual bool TryInitialize()

### public class UnityEngine.SubsystemsImplementation.SubsystemProxy<TSubsystem, TProvider>

#### Fields
- private TProvider <provider>k__BackingField

#### Properties
- public TProvider provider { get; private set; }
- public bool running { get; set; }

#### Constructors
- internal SubsystemProxy<TSubsystem, TProvider>(TProvider provider)

### public class UnityEngine.SubsystemsImplementation.SubsystemWithProvider
- Interfaces: UnityEngine.ISubsystem

#### Fields
- private UnityEngine.SubsystemsImplementation.SubsystemProvider <providerBase>k__BackingField
- private bool <running>k__BackingField

#### Properties
- internal UnityEngine.SubsystemsImplementation.SubsystemDescriptorWithProvider descriptor { get; }
- internal UnityEngine.SubsystemsImplementation.SubsystemProvider providerBase { get; set; }
- public bool running { get; private set; }

#### Constructors
- protected SubsystemWithProvider()

#### Methods
- public void Destroy()
- internal abstract void Initialize(UnityEngine.SubsystemsImplementation.SubsystemDescriptorWithProvider descriptor, UnityEngine.SubsystemsImplementation.SubsystemProvider subsystemProvider)
- protected abstract void OnDestroy()
- protected abstract void OnStart()
- protected abstract void OnStop()
- public void Start()
- public void Stop()

### public class UnityEngine.SubsystemsImplementation.SubsystemWithProvider<TSubsystem, TSubsystemDescriptor, TProvider>
- Base: UnityEngine.SubsystemsImplementation.SubsystemWithProvider
- Interfaces: UnityEngine.ISubsystem

#### Fields
- private TProvider <provider>k__BackingField
- private TSubsystemDescriptor <subsystemDescriptor>k__BackingField

#### Properties
- internal UnityEngine.SubsystemsImplementation.SubsystemDescriptorWithProvider descriptor { get; }
- protected internal TProvider provider { get; private set; }
- public TSubsystemDescriptor subsystemDescriptor { get; private set; }

#### Constructors
- protected SubsystemWithProvider<TSubsystem, TSubsystemDescriptor, TProvider>()

#### Methods
- internal override void Initialize(UnityEngine.SubsystemsImplementation.SubsystemDescriptorWithProvider descriptor, UnityEngine.SubsystemsImplementation.SubsystemProvider provider)
- protected virtual void OnCreate()
- protected override void OnDestroy()
- protected override void OnStart()
- protected override void OnStop()

## Namespace: UnityEngine.SubsystemsImplementation.Extensions

### public static class UnityEngine.SubsystemsImplementation.Extensions.SubsystemDescriptorExtensions

#### Methods
- public static UnityEngine.SubsystemsImplementation.SubsystemProxy<TSubsystem, TProvider> CreateProxy<TSubsystem, TProvider>(UnityEngine.SubsystemsImplementation.SubsystemDescriptorWithProvider<TSubsystem, TProvider> descriptor)

### public static class UnityEngine.SubsystemsImplementation.Extensions.SubsystemExtensions

#### Methods
- public static TProvider GetProvider<TSubsystem, TDescriptor, TProvider>(UnityEngine.SubsystemsImplementation.SubsystemWithProvider<TSubsystem, TDescriptor, TProvider> subsystem)

