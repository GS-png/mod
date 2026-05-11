# Assembly: System.EnterpriseServices
- Path: tools/WorldBox.Managed/System.EnterpriseServices.dll
- Types: 120

## Namespace: (global)

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

## Namespace: System

### internal class System.MonoDocumentationNoteAttribute
- Base: System.MonoTODOAttribute

#### Constructors
- public MonoDocumentationNoteAttribute(string comment)

### internal class System.MonoExtensionAttribute
- Base: System.MonoTODOAttribute

#### Constructors
- public MonoExtensionAttribute(string comment)

### internal class System.MonoInternalNoteAttribute
- Base: System.MonoTODOAttribute

#### Constructors
- public MonoInternalNoteAttribute(string comment)

### internal class System.MonoLimitationAttribute
- Base: System.MonoTODOAttribute

#### Constructors
- public MonoLimitationAttribute(string comment)

### internal class System.MonoNotSupportedAttribute
- Base: System.MonoTODOAttribute

#### Constructors
- public MonoNotSupportedAttribute(string comment)

### internal class System.MonoTODOAttribute
- Base: System.Attribute

#### Fields
- private string comment

#### Properties
- public string Comment { get; }

#### Constructors
- public MonoTODOAttribute()
- public MonoTODOAttribute(string comment)

## Namespace: System.EnterpriseServices

### public enum System.EnterpriseServices.AccessChecksLevelOption
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Application = 0
- ApplicationComponent = 1

### public enum System.EnterpriseServices.ActivationOption
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Library = 0
- Server = 1

### public class System.EnterpriseServices.Activity

#### Constructors
- public Activity(System.EnterpriseServices.ServiceConfig cfg)

#### Methods
- public void AsynchronousCall(System.EnterpriseServices.IServiceCall serviceCall)
- public void BindToCurrentThread()
- public void SynchronousCall(System.EnterpriseServices.IServiceCall serviceCall)
- public void UnbindFromThread()

### public class System.EnterpriseServices.ApplicationAccessControlAttribute
- Base: System.Attribute
- Interfaces: System.EnterpriseServices.IConfigurationAttribute

#### Fields
- private System.EnterpriseServices.AccessChecksLevelOption accessChecksLevel
- private System.EnterpriseServices.AuthenticationOption authentication
- private System.EnterpriseServices.ImpersonationLevelOption impersonation
- private bool val

#### Properties
- public System.EnterpriseServices.AccessChecksLevelOption AccessChecksLevel { get; set; }
- public System.EnterpriseServices.AuthenticationOption Authentication { get; set; }
- public System.EnterpriseServices.ImpersonationLevelOption ImpersonationLevel { get; set; }
- public bool Value { get; set; }

#### Constructors
- public ApplicationAccessControlAttribute()
- public ApplicationAccessControlAttribute(bool val)

#### Methods
- private bool System.EnterpriseServices.IConfigurationAttribute.AfterSaveChanges(System.Collections.Hashtable info)
- private bool System.EnterpriseServices.IConfigurationAttribute.Apply(System.Collections.Hashtable cache)
- private bool System.EnterpriseServices.IConfigurationAttribute.IsValidTarget(string s)

### public class System.EnterpriseServices.ApplicationActivationAttribute
- Base: System.Attribute
- Interfaces: System.EnterpriseServices.IConfigurationAttribute

#### Fields
- private System.EnterpriseServices.ActivationOption opt
- private string soapMailbox
- private string soapVRoot

#### Properties
- public string SoapMailbox { get; set; }
- public string SoapVRoot { get; set; }
- public System.EnterpriseServices.ActivationOption Value { get; }

#### Constructors
- public ApplicationActivationAttribute(System.EnterpriseServices.ActivationOption opt)

#### Methods
- private bool System.EnterpriseServices.IConfigurationAttribute.AfterSaveChanges(System.Collections.Hashtable info)
- private bool System.EnterpriseServices.IConfigurationAttribute.Apply(System.Collections.Hashtable cache)
- private bool System.EnterpriseServices.IConfigurationAttribute.IsValidTarget(string s)

### public class System.EnterpriseServices.ApplicationIDAttribute
- Base: System.Attribute
- Interfaces: System.EnterpriseServices.IConfigurationAttribute

#### Fields
- private System.Guid guid

#### Properties
- public System.Guid Value { get; }

#### Constructors
- public ApplicationIDAttribute(string guid)

#### Methods
- private bool System.EnterpriseServices.IConfigurationAttribute.AfterSaveChanges(System.Collections.Hashtable info)
- private bool System.EnterpriseServices.IConfigurationAttribute.Apply(System.Collections.Hashtable cache)
- private bool System.EnterpriseServices.IConfigurationAttribute.IsValidTarget(string s)

### public class System.EnterpriseServices.ApplicationNameAttribute
- Base: System.Attribute
- Interfaces: System.EnterpriseServices.IConfigurationAttribute

#### Fields
- private string name

#### Properties
- public string Value { get; }

#### Constructors
- public ApplicationNameAttribute(string name)

#### Methods
- private bool System.EnterpriseServices.IConfigurationAttribute.AfterSaveChanges(System.Collections.Hashtable info)
- private bool System.EnterpriseServices.IConfigurationAttribute.Apply(System.Collections.Hashtable cache)
- private bool System.EnterpriseServices.IConfigurationAttribute.IsValidTarget(string s)

### public class System.EnterpriseServices.ApplicationQueuingAttribute
- Base: System.Attribute

#### Fields
- private bool enabled
- private int maxListenerThreads
- private bool queueListenerEnabled

#### Properties
- public bool Enabled { get; set; }
- public int MaxListenerThreads { get; set; }
- public bool QueueListenerEnabled { get; set; }

#### Constructors
- public ApplicationQueuingAttribute()

### public enum System.EnterpriseServices.AuthenticationOption
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Call = 3
- Connect = 2
- Default = 0
- Integrity = 5
- None = 1
- Packet = 4
- Privacy = 6

### public class System.EnterpriseServices.AutoCompleteAttribute
- Base: System.Attribute

#### Fields
- private bool val

#### Properties
- public bool Value { get; }

#### Constructors
- public AutoCompleteAttribute()
- public AutoCompleteAttribute(bool val)

### public enum System.EnterpriseServices.BindingOption
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BindingToPoolThread = 1
- NoBinding = 0

### public struct System.EnterpriseServices.BOID

#### Fields
- public byte[] rgb

### public class System.EnterpriseServices.BYOT

#### Constructors
- private BYOT()

#### Methods
- public static object CreateWithTipTransaction(string url, System.Type t)
- public static object CreateWithTransaction(object transaction, System.Type t)

### public class System.EnterpriseServices.ComponentAccessControlAttribute
- Base: System.Attribute

#### Fields
- private bool val

#### Properties
- public bool Value { get; }

#### Constructors
- public ComponentAccessControlAttribute()
- public ComponentAccessControlAttribute(bool val)

### public class System.EnterpriseServices.COMTIIntrinsicsAttribute
- Base: System.Attribute

#### Fields
- private bool val

#### Properties
- public bool Value { get; }

#### Constructors
- public COMTIIntrinsicsAttribute()
- public COMTIIntrinsicsAttribute(bool val)

### public class System.EnterpriseServices.ConstructionEnabledAttribute
- Base: System.Attribute

#### Fields
- private string def
- private bool enabled

#### Properties
- public string Default { get; set; }
- public bool Enabled { get; set; }

#### Constructors
- public ConstructionEnabledAttribute()
- public ConstructionEnabledAttribute(bool val)

### public class System.EnterpriseServices.ContextUtil

#### Fields
- private static bool deactivateOnReturn
- private static System.EnterpriseServices.TransactionVote myTransactionVote

#### Properties
- public static System.Guid ActivityId { get; }
- public static System.Guid ApplicationId { get; }
- public static System.Guid ApplicationInstanceId { get; }
- public static System.Guid ContextId { get; }
- public static bool DeactivateOnReturn { get; set; }
- public static bool IsInTransaction { get; }
- public static bool IsSecurityEnabled { get; }
- public static System.EnterpriseServices.TransactionVote MyTransactionVote { get; set; }
- public static System.Guid PartitionId { get; }
- public static System.Transactions.Transaction SystemTransaction { get; }
- public static object Transaction { get; }
- public static System.Guid TransactionId { get; }

#### Constructors
- internal ContextUtil()

#### Methods
- public static void DisableCommit()
- public static void EnableCommit()
- public static object GetNamedProperty(string name)
- public static bool IsCallerInRole(string role)
- public static bool IsDefaultContext()
- public static void SetAbort()
- public static void SetComplete()
- public static void SetNamedProperty(string name, object value)

### public class System.EnterpriseServices.DescriptionAttribute
- Base: System.Attribute

#### Constructors
- public DescriptionAttribute(string desc)

### public class System.EnterpriseServices.EventClassAttribute
- Base: System.Attribute

#### Fields
- private bool allowInProcSubscribers
- private bool fireInParallel
- private string publisherFilter

#### Properties
- public bool AllowInprocSubscribers { get; set; }
- public bool FireInParallel { get; set; }
- public string PublisherFilter { get; set; }

#### Constructors
- public EventClassAttribute()

### public class System.EnterpriseServices.EventTrackingEnabledAttribute
- Base: System.Attribute

#### Fields
- private bool val

#### Properties
- public bool Value { get; }

#### Constructors
- public EventTrackingEnabledAttribute()
- public EventTrackingEnabledAttribute(bool val)

### public class System.EnterpriseServices.ExceptionClassAttribute
- Base: System.Attribute

#### Fields
- private string name

#### Properties
- public string Value { get; }

#### Constructors
- public ExceptionClassAttribute(string name)

### public interface System.EnterpriseServices.IAsyncErrorNotify

#### Methods
- public void OnError(int hresult)

### internal interface System.EnterpriseServices.IConfigurationAttribute

#### Methods
- public bool AfterSaveChanges(System.Collections.Hashtable info)
- public bool Apply(System.Collections.Hashtable info)
- public bool IsValidTarget(string s)

### public class System.EnterpriseServices.IISIntrinsicsAttribute
- Base: System.Attribute

#### Fields
- private bool val

#### Properties
- public bool Value { get; }

#### Constructors
- public IISIntrinsicsAttribute()
- public IISIntrinsicsAttribute(bool val)

### public enum System.EnterpriseServices.ImpersonationLevelOption
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Anonymous = 1
- Default = 0
- Delegate = 4
- Identify = 2
- Impersonate = 3

### public enum System.EnterpriseServices.InheritanceOption
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Ignore = 1
- Inherit = 0

### public enum System.EnterpriseServices.InstallationFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Configure = 1024
- ConfigureComponentsOnly = 16
- CreateTargetApplication = 2
- Default = 0
- ExpectExistingTypeLib = 1
- FindOrCreateTargetApplication = 4
- Install = 512
- ReconfigureExistingApplication = 8
- Register = 256
- ReportWarningsToConsole = 32

### public class System.EnterpriseServices.InterfaceQueuingAttribute
- Base: System.Attribute

#### Fields
- private bool enabled
- private string interfaceName

#### Properties
- public bool Enabled { get; set; }
- public string Interface { get; set; }

#### Constructors
- public InterfaceQueuingAttribute()
- public InterfaceQueuingAttribute(bool enabled)

### public interface System.EnterpriseServices.IPlaybackControl

#### Methods
- public void FinalClientRetry()
- public void FinalServerRetry()

### public interface System.EnterpriseServices.IProcessInitControl

#### Methods
- public void ResetInitializerTimeout(int dwSecondsRemaining)

### public interface System.EnterpriseServices.IProcessInitializer

#### Methods
- public void Shutdown()
- public void Startup(object punkProcessControl)

### public interface System.EnterpriseServices.IRegistrationHelper

#### Methods
- public void InstallAssembly(string assembly, out string application, out string tlb, System.EnterpriseServices.InstallationFlags installFlags)
- public void UninstallAssembly(string assembly, string application)

### public interface System.EnterpriseServices.IRemoteDispatch

#### Methods
- public string RemoteDispatchAutoDone(string s)
- public string RemoteDispatchNotAutoDone(string s)

### internal interface System.EnterpriseServices.ISecurityCallContext

#### Properties
- public int Count { get; }

#### Methods
- public void GetEnumerator(ref System.Collections.IEnumerator enumerator)
- public object GetItem(string user)
- public bool IsCallerInRole(string role)
- public bool IsSecurityEnabled()
- public bool IsUserInRole(ref object user, string role)

### internal interface System.EnterpriseServices.ISecurityCallersColl

#### Properties
- public int Count { get; }

#### Methods
- public void GetEnumerator(out System.Collections.IEnumerator enumerator)
- public System.EnterpriseServices.ISecurityIdentityColl GetItem(int idx)

### internal interface System.EnterpriseServices.ISecurityIdentityColl

#### Properties
- public int Count { get; }

#### Methods
- public void GetEnumerator(out System.Collections.IEnumerator enumerator)
- public System.EnterpriseServices.SecurityIdentity GetItem(int idx)

### public interface System.EnterpriseServices.IServiceCall

#### Methods
- public void OnCall()

### public interface System.EnterpriseServices.IServicedComponentInfo

#### Methods
- public void GetComponentInfo(ref int infoMask, out string[] infoArray)

### internal interface System.EnterpriseServices.ISharedProperty

#### Properties
- public object Value { get; set; }

### internal interface System.EnterpriseServices.ISharedPropertyGroup

#### Methods
- public System.EnterpriseServices.ISharedProperty CreateProperty(string name, out bool fExists)
- public System.EnterpriseServices.ISharedProperty CreatePropertyByPosition(int position, out bool fExists)
- public System.EnterpriseServices.ISharedProperty Property(string name)
- public System.EnterpriseServices.ISharedProperty PropertyByPosition(int position)

### public interface System.EnterpriseServices.ITransaction

#### Methods
- public void Abort(ref System.EnterpriseServices.BOID pboidReason, int fRetaining, int fAsync)
- public void Commit(int fRetaining, int grfTC, int grfRM)
- public void GetTransactionInfo(out System.EnterpriseServices.XACTTRANSINFO pinfo)

### public class System.EnterpriseServices.JustInTimeActivationAttribute
- Base: System.Attribute

#### Fields
- private bool val

#### Properties
- public bool Value { get; }

#### Constructors
- public JustInTimeActivationAttribute()
- public JustInTimeActivationAttribute(bool val)

### public class System.EnterpriseServices.LoadBalancingSupportedAttribute
- Base: System.Attribute

#### Fields
- private bool val

#### Properties
- public bool Value { get; }

#### Constructors
- public LoadBalancingSupportedAttribute()
- public LoadBalancingSupportedAttribute(bool val)

### public class System.EnterpriseServices.MustRunInClientContextAttribute
- Base: System.Attribute

#### Fields
- private bool val

#### Properties
- public bool Value { get; }

#### Constructors
- public MustRunInClientContextAttribute()
- public MustRunInClientContextAttribute(bool val)

### public class System.EnterpriseServices.ObjectPoolingAttribute
- Base: System.Attribute
- Interfaces: System.EnterpriseServices.IConfigurationAttribute

#### Fields
- private int creationTimeout
- private bool enabled
- private int maxPoolSize
- private int minPoolSize

#### Properties
- public int CreationTimeout { get; set; }
- public bool Enabled { get; set; }
- public int MaxPoolSize { get; set; }
- public int MinPoolSize { get; set; }

#### Constructors
- public ObjectPoolingAttribute()
- public ObjectPoolingAttribute(bool enable)
- public ObjectPoolingAttribute(int minPoolSize, int maxPoolSize)
- public ObjectPoolingAttribute(bool enable, int minPoolSize, int maxPoolSize)

#### Methods
- public bool AfterSaveChanges(System.Collections.Hashtable info)
- public bool Apply(System.Collections.Hashtable info)
- public bool IsValidTarget(string s)

### public enum System.EnterpriseServices.PartitionOption
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Ignore = 0
- Inherit = 1
- New = 2

### public class System.EnterpriseServices.PrivateComponentAttribute
- Base: System.Attribute

#### Constructors
- public PrivateComponentAttribute()

### public enum System.EnterpriseServices.PropertyLockMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Method = 1
- SetGet = 0

### public enum System.EnterpriseServices.PropertyReleaseMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Process = 1
- Standard = 0

### public class System.EnterpriseServices.RegistrationConfig

#### Properties
- public string Application { get; set; }
- public string ApplicationRootDirectory { get; set; }
- public string AssemblyFile { get; set; }
- public System.EnterpriseServices.InstallationFlags InstallationFlags { get; set; }
- public string Partition { get; set; }
- public string TypeLibrary { get; set; }

#### Constructors
- public RegistrationConfig()

### public class System.EnterpriseServices.RegistrationErrorInfo

#### Fields
- private int errorCode
- private string errorString
- private string majorRef
- private string minorRef
- private string name

#### Properties
- public int ErrorCode { get; }
- public string ErrorString { get; }
- public string MajorRef { get; }
- public string MinorRef { get; }
- public string Name { get; }

#### Constructors
- internal RegistrationErrorInfo()
- internal RegistrationErrorInfo(string name, string majorRef, string minorRef, int errorCode)

### public class System.EnterpriseServices.RegistrationException
- Base: System.SystemException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Fields
- private System.EnterpriseServices.RegistrationErrorInfo[] errorInfo

#### Properties
- public System.EnterpriseServices.RegistrationErrorInfo[] ErrorInfo { get; }

#### Constructors
- public RegistrationException()
- public RegistrationException(string msg)
- public RegistrationException(string msg, System.Exception inner)

#### Methods
- public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext ctx)

### public class System.EnterpriseServices.RegistrationHelper
- Base: System.MarshalByRefObject
- Interfaces: System.EnterpriseServices.IRegistrationHelper

#### Constructors
- public RegistrationHelper()

#### Methods
- public void InstallAssembly(string assembly, ref string application, ref string tlb, System.EnterpriseServices.InstallationFlags installFlags)
- public void InstallAssembly(string assembly, ref string application, string partition, ref string tlb, System.EnterpriseServices.InstallationFlags installFlags)
- public void InstallAssemblyFromConfig(ref System.EnterpriseServices.RegistrationConfig regConfig)
- public void UninstallAssembly(string assembly, string application)
- public void UninstallAssembly(string assembly, string application, string partition)
- public void UninstallAssemblyFromConfig(ref System.EnterpriseServices.RegistrationConfig regConfig)

### public class System.EnterpriseServices.RegistrationHelperTx
- Base: System.EnterpriseServices.ServicedComponent
- Interfaces: System.IDisposable, System.EnterpriseServices.IRemoteDispatch, System.EnterpriseServices.IServicedComponentInfo

#### Constructors
- public RegistrationHelperTx()

#### Methods
- protected internal override void Activate()
- protected internal override void Deactivate()
- public void InstallAssembly(string assembly, ref string application, ref string tlb, System.EnterpriseServices.InstallationFlags installFlags, object sync)
- public void InstallAssembly(string assembly, ref string application, string partition, ref string tlb, System.EnterpriseServices.InstallationFlags installFlags, object sync)
- public void InstallAssemblyFromConfig(ref System.EnterpriseServices.RegistrationConfig regConfig, object sync)
- public bool IsInTransaction()
- public void UninstallAssembly(string assembly, string application, object sync)
- public void UninstallAssembly(string assembly, string application, string partition, object sync)
- public void UninstallAssemblyFromConfig(ref System.EnterpriseServices.RegistrationConfig regConfig, object sync)

### public class System.EnterpriseServices.ResourcePool

#### Constructors
- public ResourcePool(System.EnterpriseServices.ResourcePool.TransactionEndDelegate cb)

#### Methods
- public object GetResource()
- public bool PutResource(object resource)

### public class System.EnterpriseServices.SecureMethodAttribute
- Base: System.Attribute

#### Constructors
- public SecureMethodAttribute()

### public class System.EnterpriseServices.SecurityCallContext

#### Properties
- public System.EnterpriseServices.SecurityCallers Callers { get; }
- public static System.EnterpriseServices.SecurityCallContext CurrentCall { get; }
- public System.EnterpriseServices.SecurityIdentity DirectCaller { get; }
- public bool IsSecurityEnabled { get; }
- public int MinAuthenticationLevel { get; }
- public int NumCallers { get; }
- public System.EnterpriseServices.SecurityIdentity OriginalCaller { get; }

#### Constructors
- internal SecurityCallContext()
- internal SecurityCallContext(System.EnterpriseServices.ISecurityCallContext context)

#### Methods
- public bool IsCallerInRole(string role)
- public bool IsUserInRole(string user, string role)

### public class System.EnterpriseServices.SecurityCallers
- Interfaces: System.Collections.IEnumerable

#### Properties
- public int Count { get; }
- public System.EnterpriseServices.SecurityIdentity Item { get; }

#### Constructors
- internal SecurityCallers()
- internal SecurityCallers(System.EnterpriseServices.ISecurityCallersColl collection)

#### Methods
- public System.Collections.IEnumerator GetEnumerator()

### public class System.EnterpriseServices.SecurityIdentity

#### Properties
- public string AccountName { get; }
- public System.EnterpriseServices.AuthenticationOption AuthenticationLevel { get; }
- public int AuthenticationService { get; }
- public System.EnterpriseServices.ImpersonationLevelOption ImpersonationLevel { get; }

#### Constructors
- internal SecurityIdentity()
- internal SecurityIdentity(System.EnterpriseServices.ISecurityIdentityColl collection)

### public class System.EnterpriseServices.SecurityRoleAttribute
- Base: System.Attribute

#### Fields
- private string description
- private bool everyone
- private string role

#### Properties
- public string Description { get; set; }
- public string Role { get; set; }
- public bool SetEveryoneAccess { get; set; }

#### Constructors
- public SecurityRoleAttribute(string role)
- public SecurityRoleAttribute(string role, bool everyone)

### public class System.EnterpriseServices.ServiceConfig

#### Properties
- public System.EnterpriseServices.BindingOption Binding { get; set; }
- public System.Transactions.Transaction BringYourOwnSystemTransaction { get; set; }
- public System.EnterpriseServices.ITransaction BringYourOwnTransaction { get; set; }
- public bool COMTIIntrinsicsEnabled { get; set; }
- public bool IISIntrinsicsEnabled { get; set; }
- public System.EnterpriseServices.InheritanceOption Inheritance { get; set; }
- public System.EnterpriseServices.TransactionIsolationLevel IsolationLevel { get; set; }
- public System.Guid PartitionId { get; set; }
- public System.EnterpriseServices.PartitionOption PartitionOption { get; set; }
- public string SxsDirectory { get; set; }
- public string SxsName { get; set; }
- public System.EnterpriseServices.SxsOption SxsOption { get; set; }
- public System.EnterpriseServices.SynchronizationOption Synchronization { get; set; }
- public System.EnterpriseServices.ThreadPoolOption ThreadPool { get; set; }
- public string TipUrl { get; set; }
- public string TrackingAppName { get; set; }
- public string TrackingComponentName { get; set; }
- public bool TrackingEnabled { get; set; }
- public System.EnterpriseServices.TransactionOption Transaction { get; set; }
- public string TransactionDescription { get; set; }
- public int TransactionTimeout { get; set; }

#### Constructors
- public ServiceConfig()

### public class System.EnterpriseServices.ServicedComponent
- Base: System.ContextBoundObject
- Interfaces: System.IDisposable, System.EnterpriseServices.IRemoteDispatch, System.EnterpriseServices.IServicedComponentInfo

#### Constructors
- public ServicedComponent()

#### Methods
- protected internal virtual void Activate()
- protected internal virtual bool CanBePooled()
- protected internal virtual void Construct(string s)
- protected internal virtual void Deactivate()
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- public static void DisposeObject(System.EnterpriseServices.ServicedComponent sc)
- private string System.EnterpriseServices.IRemoteDispatch.RemoteDispatchAutoDone(string s)
- private string System.EnterpriseServices.IRemoteDispatch.RemoteDispatchNotAutoDone(string s)
- private void System.EnterpriseServices.IServicedComponentInfo.GetComponentInfo(ref int infoMask, out string[] infoArray)

### public class System.EnterpriseServices.ServicedComponentException
- Base: System.SystemException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public ServicedComponentException()
- public ServicedComponentException(string message)
- public ServicedComponentException(string message, System.Exception innerException)

### public class System.EnterpriseServices.ServiceDomain

#### Constructors
- private ServiceDomain()

#### Methods
- public static void Enter(System.EnterpriseServices.ServiceConfig cfg)
- public static System.EnterpriseServices.TransactionStatus Leave()

### public class System.EnterpriseServices.SharedProperty

#### Fields
- private System.EnterpriseServices.ISharedProperty property

#### Properties
- public object Value { get; set; }

#### Constructors
- internal SharedProperty()
- internal SharedProperty(System.EnterpriseServices.ISharedProperty property)

### public class System.EnterpriseServices.SharedPropertyGroup

#### Fields
- private System.EnterpriseServices.ISharedPropertyGroup propertyGroup

#### Constructors
- internal SharedPropertyGroup()
- internal SharedPropertyGroup(System.EnterpriseServices.ISharedPropertyGroup propertyGroup)

#### Methods
- public System.EnterpriseServices.SharedProperty CreateProperty(string name, out bool fExists)
- public System.EnterpriseServices.SharedProperty CreatePropertyByPosition(int position, out bool fExists)
- public System.EnterpriseServices.SharedProperty Property(string name)
- public System.EnterpriseServices.SharedProperty PropertyByPosition(int position)

### public class System.EnterpriseServices.SharedPropertyGroupManager
- Interfaces: System.Collections.IEnumerable

#### Constructors
- public SharedPropertyGroupManager()

#### Methods
- public System.EnterpriseServices.SharedPropertyGroup CreatePropertyGroup(string name, ref System.EnterpriseServices.PropertyLockMode dwIsoMode, ref System.EnterpriseServices.PropertyReleaseMode dwRelMode, out bool fExist)
- public System.Collections.IEnumerator GetEnumerator()
- public System.EnterpriseServices.SharedPropertyGroup Group(string name)

### public enum System.EnterpriseServices.SxsOption
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Ignore = 0
- Inherit = 1
- New = 2

### public class System.EnterpriseServices.SynchronizationAttribute
- Base: System.Attribute

#### Fields
- private System.EnterpriseServices.SynchronizationOption val

#### Properties
- public System.EnterpriseServices.SynchronizationOption Value { get; }

#### Constructors
- public SynchronizationAttribute()
- public SynchronizationAttribute(System.EnterpriseServices.SynchronizationOption val)

### public enum System.EnterpriseServices.SynchronizationOption
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Disabled = 0
- NotSupported = 1
- Required = 3
- RequiresNew = 4
- Supported = 2

### public enum System.EnterpriseServices.ThreadPoolOption
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Inherit = 1
- MTA = 3
- None = 0
- STA = 2

### public class System.EnterpriseServices.TransactionAttribute
- Base: System.Attribute

#### Fields
- private System.EnterpriseServices.TransactionIsolationLevel isolation
- private int timeout
- private System.EnterpriseServices.TransactionOption val

#### Properties
- public System.EnterpriseServices.TransactionIsolationLevel Isolation { get; set; }
- public int Timeout { get; set; }
- public System.EnterpriseServices.TransactionOption Value { get; }

#### Constructors
- public TransactionAttribute()
- public TransactionAttribute(System.EnterpriseServices.TransactionOption val)

### public delegate System.EnterpriseServices.ResourcePool.TransactionEndDelegate
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ResourcePool.TransactionEndDelegate(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(object resource, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(object resource)

### public enum System.EnterpriseServices.TransactionIsolationLevel
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Any = 0
- ReadCommitted = 2
- ReadUncommitted = 1
- RepeatableRead = 3
- Serializable = 4

### public enum System.EnterpriseServices.TransactionOption
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Disabled = 0
- NotSupported = 1
- Required = 3
- RequiresNew = 4
- Supported = 2

### public enum System.EnterpriseServices.TransactionStatus
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Aborted = 4
- Aborting = 3
- Commited = 0
- LocallyOk = 1
- NoTransaction = 2

### public enum System.EnterpriseServices.TransactionVote
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Abort = 1
- Commit = 0

### public struct System.EnterpriseServices.XACTTRANSINFO

#### Fields
- public int grfRMSupported
- public int grfRMSupportedRetaining
- public int grfTCSupported
- public int grfTCSupportedRetaining
- public int isoFlags
- public int isoLevel
- public System.EnterpriseServices.BOID uow

## Namespace: System.EnterpriseServices.CompensatingResourceManager

### public class System.EnterpriseServices.CompensatingResourceManager.ApplicationCrmEnabledAttribute
- Base: System.Attribute

#### Fields
- private bool val

#### Properties
- public bool Value { get; }

#### Constructors
- public ApplicationCrmEnabledAttribute()
- public ApplicationCrmEnabledAttribute(bool val)

### public class System.EnterpriseServices.CompensatingResourceManager.Clerk

#### Properties
- public int LogRecordCount { get; }
- public string TransactionUOW { get; }

#### Constructors
- public Clerk(string compensator, string description, System.EnterpriseServices.CompensatingResourceManager.CompensatorOptions flags)
- public Clerk(System.Type compensator, string description, System.EnterpriseServices.CompensatingResourceManager.CompensatorOptions flags)

#### Methods
- protected override void Finalize()
- public void ForceLog()
- public void ForceTransactionToAbort()
- public void ForgetLogRecord()
- public void WriteLogRecord(object record)

### public class System.EnterpriseServices.CompensatingResourceManager.ClerkInfo

#### Properties
- public string ActivityId { get; }
- public System.EnterpriseServices.CompensatingResourceManager.Clerk Clerk { get; }
- public string Compensator { get; }
- public string Description { get; }
- public string InstanceId { get; }
- public string TransactionUOW { get; }

#### Constructors
- internal ClerkInfo()

#### Methods
- protected override void Finalize()

### public class System.EnterpriseServices.CompensatingResourceManager.ClerkMonitor
- Interfaces: System.Collections.IEnumerable

#### Properties
- public int Count { get; }
- public System.EnterpriseServices.CompensatingResourceManager.ClerkInfo Item { get; }
- public System.EnterpriseServices.CompensatingResourceManager.ClerkInfo Item { get; }

#### Constructors
- public ClerkMonitor()

#### Methods
- protected override void Finalize()
- public System.Collections.IEnumerator GetEnumerator()
- public void Populate()

### public class System.EnterpriseServices.CompensatingResourceManager.Compensator
- Base: System.EnterpriseServices.ServicedComponent
- Interfaces: System.IDisposable, System.EnterpriseServices.IRemoteDispatch, System.EnterpriseServices.IServicedComponentInfo

#### Properties
- public System.EnterpriseServices.CompensatingResourceManager.Clerk Clerk { get; }

#### Constructors
- public Compensator()

#### Methods
- public virtual bool AbortRecord(System.EnterpriseServices.CompensatingResourceManager.LogRecord rec)
- public virtual void BeginAbort(bool fRecovery)
- public virtual void BeginCommit(bool fRecovery)
- public virtual void BeginPrepare()
- public virtual bool CommitRecord(System.EnterpriseServices.CompensatingResourceManager.LogRecord rec)
- public virtual void EndAbort()
- public virtual void EndCommit()
- public virtual bool EndPrepare()
- public virtual bool PrepareRecord(System.EnterpriseServices.CompensatingResourceManager.LogRecord rec)

### public enum System.EnterpriseServices.CompensatingResourceManager.CompensatorOptions
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AbortPhase = 4
- AllPhases = 7
- CommitPhase = 2
- FailIfInDoubtsRemain = 16
- PreparePhase = 1

### public class System.EnterpriseServices.CompensatingResourceManager.LogRecord

#### Fields
- private System.EnterpriseServices.CompensatingResourceManager.LogRecordFlags flags
- private object record
- private int sequence

#### Properties
- public System.EnterpriseServices.CompensatingResourceManager.LogRecordFlags Flags { get; }
- public object Record { get; }
- public int Sequence { get; }

#### Constructors
- internal LogRecord()
- internal LogRecord(System.EnterpriseServices.CompensatingResourceManager._LogRecord logRecord)

### public enum System.EnterpriseServices.CompensatingResourceManager.LogRecordFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ForgetTarget = 1
- ReplayInProgress = 64
- WrittenDuringAbort = 8
- WrittenDuringCommit = 4
- WrittenDuringPrepare = 2
- WrittenDuringReplay = 32
- WrittenDurringRecovery = 16

### public enum System.EnterpriseServices.CompensatingResourceManager.TransactionState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Aborted = 2
- Active = 0
- Committed = 1
- Indoubt = 3

### internal struct System.EnterpriseServices.CompensatingResourceManager._LogRecord

#### Fields
- public object blobUserData
- public int dwCrmFlags
- public int dwSequenceNumber

## Namespace: System.EnterpriseServices.Internal

### public class System.EnterpriseServices.Internal.AppDomainHelper

#### Constructors
- public AppDomainHelper()

#### Methods
- protected override void Finalize()

### public class System.EnterpriseServices.Internal.AssemblyLocator
- Base: System.MarshalByRefObject

#### Constructors
- public AssemblyLocator()

### public class System.EnterpriseServices.Internal.ClientRemotingConfig

#### Constructors
- public ClientRemotingConfig()

#### Methods
- public static bool Write(string DestinationDirectory, string VRoot, string BaseUrl, string AssemblyName, string TypeName, string ProgId, string Mode, string Transport)

### public class System.EnterpriseServices.Internal.ClrObjectFactory
- Interfaces: System.EnterpriseServices.Internal.IClrObjectFactory

#### Constructors
- public ClrObjectFactory()

#### Methods
- public object CreateFromAssembly(string AssemblyName, string TypeName, string Mode)
- public object CreateFromMailbox(string Mailbox, string Mode)
- public object CreateFromVroot(string VrootUrl, string Mode)
- public object CreateFromWsdl(string WsdlUrl, string Mode)

### public class System.EnterpriseServices.Internal.ComManagedImportUtil
- Interfaces: System.EnterpriseServices.Internal.IComManagedImportUtil

#### Constructors
- public ComManagedImportUtil()

#### Methods
- public void GetComponentInfo(string assemblyPath, out string numComponents, out string componentInfo)
- public void InstallAssembly(string asmpath, string parname, string appname)

### public class System.EnterpriseServices.Internal.ComSoapPublishError

#### Constructors
- public ComSoapPublishError()

#### Methods
- public static void Report(string s)

### public class System.EnterpriseServices.Internal.GenerateMetadata
- Interfaces: System.EnterpriseServices.Internal.IComSoapMetadata

#### Constructors
- public GenerateMetadata()

#### Methods
- public string Generate(string strSrcTypeLib, string outPath)
- public string GenerateMetaData(string strSrcTypeLib, string outPath, byte[] PublicKey, System.Reflection.StrongNameKeyPair KeyPair)
- public string GenerateSigned(string strSrcTypeLib, string outPath, bool InstallGac, out string Error)
- public static int SearchPath(string path, string fileName, string extension, int numBufferChars, string buffer, int[] filePart)

### public interface System.EnterpriseServices.Internal.IClrObjectFactory

#### Methods
- public object CreateFromAssembly(string assembly, string type, string mode)
- public object CreateFromMailbox(string Mailbox, string Mode)
- public object CreateFromVroot(string VrootUrl, string Mode)
- public object CreateFromWsdl(string WsdlUrl, string Mode)

### public interface System.EnterpriseServices.Internal.IComManagedImportUtil

#### Methods
- public void GetComponentInfo(string assemblyPath, out string numComponents, out string componentInfo)
- public void InstallAssembly(string filename, string parname, string appname)

### public interface System.EnterpriseServices.Internal.IComSoapIISVRoot

#### Methods
- public void Create(string RootWeb, string PhysicalDirectory, string VirtualDirectory, out string Error)
- public void Delete(string RootWeb, string PhysicalDirectory, string VirtualDirectory, out string Error)

### public interface System.EnterpriseServices.Internal.IComSoapMetadata

#### Methods
- public string Generate(string SrcTypeLibFileName, string OutPath)
- public string GenerateSigned(string SrcTypeLibFileName, string OutPath, bool InstallGac, out string Error)

### public interface System.EnterpriseServices.Internal.IComSoapPublisher

#### Methods
- public void CreateMailBox(string RootMailServer, string MailBox, out string SmtpName, out string Domain, out string PhysicalPath, out string Error)
- public void CreateVirtualRoot(string Operation, string FullUrl, out string BaseUrl, out string VirtualRoot, out string PhysicalPath, out string Error)
- public void DeleteMailBox(string RootMailServer, string MailBox, out string Error)
- public void DeleteVirtualRoot(string RootWebServer, string FullUrl, out string Error)
- public void GacInstall(string AssemblyPath)
- public void GacRemove(string AssemblyPath)
- public void GetAssemblyNameForCache(string TypeLibPath, out string CachePath)
- public string GetTypeNameFromProgId(string AssemblyPath, string ProgId)
- public void ProcessClientTlb(string ProgId, string SrcTlbPath, string PhysicalPath, string VRoot, string BaseUrl, string Mode, string Transport, out string AssemblyName, out string TypeName, out string Error)
- public void ProcessServerTlb(string ProgId, string SrcTlbPath, string PhysicalPath, string Operation, out string AssemblyName, out string TypeName, out string Error)
- public void RegisterAssembly(string AssemblyPath)
- public void UnRegisterAssembly(string AssemblyPath)

### public class System.EnterpriseServices.Internal.IISVirtualRoot
- Interfaces: System.EnterpriseServices.Internal.IComSoapIISVRoot

#### Constructors
- public IISVirtualRoot()

#### Methods
- public void Create(string RootWeb, string inPhysicalDirectory, string VirtualDirectory, out string Error)
- public void Delete(string RootWeb, string PhysicalDirectory, string VirtualDirectory, out string Error)

### public interface System.EnterpriseServices.Internal.IServerWebConfig

#### Methods
- public void AddElement(string FilePath, string AssemblyName, string TypeName, string ProgId, string Mode, out string Error)
- public void Create(string FilePath, string FileRootName, out string Error)

### public interface System.EnterpriseServices.Internal.ISoapClientImport

#### Methods
- public void ProcessClientTlbEx(string progId, string virtualRoot, string baseUrl, string authentication, string assemblyName, string typeName)

### public interface System.EnterpriseServices.Internal.ISoapServerTlb

#### Methods
- public void AddServerTlb(string progId, string classId, string interfaceId, string srcTlbPath, string rootWebServer, string baseUrl, string virtualRoot, string clientActivated, string wellKnown, string discoFile, string operation, out string assemblyName, out string typeName)
- public void DeleteServerTlb(string progId, string classId, string interfaceId, string srcTlbPath, string rootWebServer, string baseUrl, string virtualRoot, string operation, string assemblyName, string typeName)

### public interface System.EnterpriseServices.Internal.ISoapServerVRoot

#### Methods
- public void CreateVirtualRootEx(string rootWebServer, string inBaseUrl, string inVirtualRoot, string homePage, string discoFile, string secureSockets, string authentication, string operation, out string baseUrl, out string virtualRoot, out string physicalPath)
- public void DeleteVirtualRootEx(string rootWebServer, string baseUrl, string virtualRoot)
- public void GetVirtualRootStatus(string rootWebServer, string inBaseUrl, string inVirtualRoot, out string exists, out string secureSockets, out string windowsAuth, out string anonymous, out string homePage, out string discoFile, out string physicalPath, out string baseUrl, out string virtualRoot)

### public interface System.EnterpriseServices.Internal.ISoapUtility

#### Methods
- public void GetServerBinPath(string rootWebServer, string inBaseUrl, string inVirtualRoot, out string binPath)
- public void GetServerPhysicalPath(string rootWebServer, string inBaseUrl, string inVirtualRoot, out string physicalPath)
- public void Present()

### public class System.EnterpriseServices.Internal.Publish
- Interfaces: System.EnterpriseServices.Internal.IComSoapPublisher

#### Constructors
- public Publish()

#### Methods
- public void CreateMailBox(string RootMailServer, string MailBox, out string SmtpName, out string Domain, out string PhysicalPath, out string Error)
- public void CreateVirtualRoot(string Operation, string FullUrl, out string BaseUrl, out string VirtualRoot, out string PhysicalPath, out string Error)
- public void DeleteMailBox(string RootMailServer, string MailBox, out string Error)
- public void DeleteVirtualRoot(string RootWebServer, string FullUrl, out string Error)
- public void GacInstall(string AssemblyPath)
- public void GacRemove(string AssemblyPath)
- public void GetAssemblyNameForCache(string TypeLibPath, out string CachePath)
- public static string GetClientPhysicalPath(bool CreateDir)
- public string GetTypeNameFromProgId(string AssemblyPath, string ProgId)
- public static void ParseUrl(string FullUrl, out string BaseUrl, out string VirtualRoot)
- public void ProcessClientTlb(string ProgId, string SrcTlbPath, string PhysicalPath, string VRoot, string BaseUrl, string Mode, string Transport, out string AssemblyName, out string TypeName, out string Error)
- public void ProcessServerTlb(string ProgId, string SrcTlbPath, string PhysicalPath, string Operation, out string strAssemblyName, out string TypeName, out string Error)
- public void RegisterAssembly(string AssemblyPath)
- public void UnRegisterAssembly(string AssemblyPath)

### public class System.EnterpriseServices.Internal.ServerWebConfig
- Interfaces: System.EnterpriseServices.Internal.IServerWebConfig

#### Constructors
- public ServerWebConfig()

#### Methods
- public void AddElement(string FilePath, string AssemblyName, string TypeName, string ProgId, string WkoMode, out string Error)
- public void Create(string FilePath, string FilePrefix, out string Error)

### public class System.EnterpriseServices.Internal.SoapClientImport
- Interfaces: System.EnterpriseServices.Internal.ISoapClientImport

#### Constructors
- public SoapClientImport()

#### Methods
- public void ProcessClientTlbEx(string progId, string virtualRoot, string baseUrl, string authentication, string assemblyName, string typeName)

### public class System.EnterpriseServices.Internal.SoapServerTlb
- Interfaces: System.EnterpriseServices.Internal.ISoapServerTlb

#### Constructors
- public SoapServerTlb()

#### Methods
- public void AddServerTlb(string progId, string classId, string interfaceId, string srcTlbPath, string rootWebServer, string inBaseUrl, string inVirtualRoot, string clientActivated, string wellKnown, string discoFile, string operation, out string strAssemblyName, out string typeName)
- public void DeleteServerTlb(string progId, string classId, string interfaceId, string srcTlbPath, string rootWebServer, string baseUrl, string virtualRoot, string operation, string assemblyName, string typeName)

### public class System.EnterpriseServices.Internal.SoapServerVRoot
- Interfaces: System.EnterpriseServices.Internal.ISoapServerVRoot

#### Constructors
- public SoapServerVRoot()

#### Methods
- public void CreateVirtualRootEx(string rootWebServer, string inBaseUrl, string inVirtualRoot, string homePage, string discoFile, string secureSockets, string authentication, string operation, out string baseUrl, out string virtualRoot, out string physicalPath)
- public void DeleteVirtualRootEx(string rootWebServer, string inBaseUrl, string inVirtualRoot)
- public void GetVirtualRootStatus(string RootWebServer, string inBaseUrl, string inVirtualRoot, out string Exists, out string SSL, out string WindowsAuth, out string Anonymous, out string HomePage, out string DiscoFile, out string PhysicalPath, out string BaseUrl, out string VirtualRoot)

### public class System.EnterpriseServices.Internal.SoapUtility
- Interfaces: System.EnterpriseServices.Internal.ISoapUtility

#### Constructors
- public SoapUtility()

#### Methods
- public void GetServerBinPath(string rootWebServer, string inBaseUrl, string inVirtualRoot, out string binPath)
- public void GetServerPhysicalPath(string rootWebServer, string inBaseUrl, string inVirtualRoot, out string physicalPath)
- public void Present()

## Namespace: Unity

### internal class Unity.ThrowStub
- Base: System.ObjectDisposedException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Methods
- public static void ThrowNotSupportedException()

