# Assembly: Unity.Services.Analytics
- Path: tools/WorldBox.Managed/Unity.Services.Analytics.dll
- Types: 77

## Namespace: (global)

### private struct Ua2CoreInitializeCallback.<Initialize>d__1
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1
- public Unity.Services.Core.Internal.CoreRegistry registry

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 5DFD08902631E8C424E3803A27CCA0D46EB96FA95BCFD9A825E96E89A8A74659
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3032 653683422880F01A65088FE3FE3E510F3D2C5CDEDAAC5157B61184AE55B1DCB8
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 84D89877F0D4041EFB6BF91A16F0248F2FD573E6AF05C19F96BEDB9F882F7882
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2869 B32D99A6B8F05948E1B1FA8F316AE2C46E3B30D88E932648C3C711085033CB4C

### private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData

#### Fields
- public byte[] FilePathsData
- public bool IsEditorOnly
- public int TotalFiles
- public int TotalTypes
- public byte[] TypesData

### internal class Ua2CoreInitializeCallback
- Interfaces: Unity.Services.Core.Internal.IInitializablePackage

#### Constructors
- public Ua2CoreInitializeCallback()

#### Methods
- public System.Threading.Tasks.Task Initialize(Unity.Services.Core.Internal.CoreRegistry registry)
- private static void Register()

### internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1

#### Constructors
- public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()

#### Methods
- private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2869

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3032

## Namespace: Unity.Services.Analytics

### private class Unity.Services.Analytics.CustomEvent.<GetEnumerator>d__4
- Interfaces: System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- public Unity.Services.Analytics.CustomEvent <>4__this
- private System.Collections.Generic.Dictionary<TKey, TValue>.Enumerator<string, string> <>7__wrap1
- private System.Collections.Generic.Dictionary<TKey, TValue>.Enumerator<string, long> <>7__wrap2
- private System.Collections.Generic.Dictionary<TKey, TValue>.Enumerator<string, double> <>7__wrap3
- private System.Collections.Generic.Dictionary<TKey, TValue>.Enumerator<string, bool> <>7__wrap4

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public CustomEvent.<GetEnumerator>d__4(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private void <>m__Finally2()
- private void <>m__Finally3()
- private void <>m__Finally4()
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### public class Unity.Services.Analytics.AcquisitionSourceEvent
- Base: Unity.Services.Analytics.Event

#### Properties
- public string AcquisitionCampaignId { set; }
- public string AcquisitionCampaignName { set; }
- public string AcquisitionCampaignType { set; }
- public string AcquisitionChannel { set; }
- public float AcquisitionCost { set; }
- public string AcquisitionCostCurrency { set; }
- public string AcquisitionCreativeId { set; }
- public string AcquisitionNetwork { set; }
- public string AcquisitionProvider { set; }

#### Constructors
- public AcquisitionSourceEvent()

#### Methods
- public override void Validate()

### public enum Unity.Services.Analytics.AdCompletionStatus
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Completed = 0
- Incomplete = 2
- Partial = 1

### public class Unity.Services.Analytics.AdImpressionEvent
- Base: Unity.Services.Analytics.Event

#### Fields
- private static readonly string[] k_AdCompletionStatusValues
- private static readonly string[] k_AdPlacementTypeValues
- private static readonly string[] k_AdProviderValues

#### Properties
- public Unity.Services.Analytics.AdCompletionStatus AdCompletionStatus { set; }
- public double AdEcpmUsd { set; }
- public bool AdHasClicked { set; }
- public string AdImpressionId { set; }
- public long AdLengthMs { set; }
- public string AdMediaType { set; }
- public Unity.Services.Analytics.AdProvider AdProvider { set; }
- public string AdSdkVersion { set; }
- public string AdSource { set; }
- public string AdStatusCallback { set; }
- public string AdStoreDestinationId { set; }
- public long AdTimeCloseButtonShownMs { set; }
- public long AdTimeWatchedMs { set; }
- public string PlacementId { set; }
- public string PlacementName { set; }
- public Unity.Services.Analytics.AdPlacementType PlacementType { set; }

#### Constructors
- public AdImpressionEvent()
- private static AdImpressionEvent()

#### Methods
- public override void Validate()

### public enum Unity.Services.Analytics.AdPlacementType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BANNER = 0
- INTERSTITIAL = 2
- OTHER = 3
- REWARDED = 1

### public enum Unity.Services.Analytics.AdProvider
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AdColony = 0
- AdMob = 1
- Amazon = 2
- AppLovin = 3
- ChartBoost = 4
- Facebook = 5
- Fyber = 6
- Hyprmx = 7
- Inmobi = 8
- IrnSource = 14
- Maio = 9
- Other = 15
- Pangle = 10
- Tapjoy = 11
- UnityAds = 12
- Vungle = 13

### internal class Unity.Services.Analytics.AnalyticsContainer
- Base: UnityEngine.MonoBehaviour
- Interfaces: Unity.Services.Analytics.IAnalyticsContainer, Unity.Services.Analytics.Internal.IContainerDebug

#### Fields
- private static const float k_AutoFlushPeriod
- private static const float k_GameRunningPeriod
- private float m_AutoFlushTime
- private float m_GameRunningTime
- private static Unity.Services.Analytics.AnalyticsContainer m_Instance
- private Unity.Services.Analytics.AnalyticsServiceInstance m_Service
- private static UnityEngine.GameObject s_Container
- private static bool s_Created

#### Properties
- private float AutoFlushPeriod { get; }
- internal static Unity.Services.Analytics.Internal.IContainerDebug ContainerDebug { get; }
- public float TimeUntilNextHeartbeat { get; }

#### Constructors
- public AnalyticsContainer()

#### Methods
- private void CleanUp()
- internal static Unity.Services.Analytics.AnalyticsContainer CreateContainer()
- public void Disable()
- public void Enable()
- public void Initialize(Unity.Services.Analytics.AnalyticsServiceInstance service)
- private void OnApplicationPause(bool paused)
- private void Update()

### public static class Unity.Services.Analytics.AnalyticsService

#### Fields
- private static const string k_CollectUrlPattern
- private static Unity.Services.Analytics.Internal.IBufferDebug m_BufferDebug
- private static Unity.Services.Analytics.Internal.IDispatcherDebug m_DispatcherDebug
- private static System.Action<string, string, System.DateTime, byte[]> m_EventRecordedCallback
- private static System.Action<System.Collections.Generic.HashSet<string>> m_EventsClearingCallback
- private static System.Action<int, bool, bool, bool, bool, byte[]> m_FlushCompletedCallback
- private static System.Action<byte[]> m_FlushStartedCallback
- private static Unity.Services.Analytics.AnalyticsServiceInstance m_Instance

#### Properties
- internal static Unity.Services.Analytics.Internal.IDispatcherDebug DispatcherDebug { get; }
- public static Unity.Services.Analytics.IAnalyticsService Instance { get; }
- internal static bool IsInitialized { get; }
- internal static Unity.Services.Analytics.Internal.IServiceDebug ServiceDebug { get; }

#### Methods
- internal static void Initialize(Unity.Services.Core.Internal.CoreRegistry registry)
- internal static void SubscribeDebugEvents(System.Action<string, string, System.DateTime, byte[]> eventRecordedCallback, System.Action<System.Collections.Generic.HashSet<string>> eventsUploadingCallback, System.Action<byte[]> flushStarted, System.Action<int, bool, bool, bool, bool, byte[]> flushCompleted)
- internal static void TearDown()
- internal static void UnsubscribeDebugEvents()

### internal class Unity.Services.Analytics.AnalyticsServiceInstance
- Interfaces: Unity.Services.Analytics.IAnalyticsService, Unity.Services.Analytics.IUnstructuredEventRecorder, Unity.Services.Analytics.Internal.IServiceDebug

#### Fields
- private readonly Unity.Services.Analytics.TransactionCurrencyConverter converter
- private readonly System.TimeSpan k_BackgroundSessionRefreshPeriod
- private static const string k_ForgetCallingId
- internal static const string k_InvokedByUserCallingId
- private static const string k_PlayerChangedCallingId
- private static const string k_StartUpCallingId
- private readonly Unity.Services.Analytics.Internal.IAnalyticsForgetter m_AnalyticsForgetter
- private System.DateTime m_ApplicationPauseTime
- private int m_BufferLengthAtLastGameRunning
- private readonly Unity.Services.Analytics.IAnalyticsContainer m_Container
- private readonly Unity.Services.Analytics.ICoreStatsHelper m_CoreStatsHelper
- internal Unity.Services.Analytics.Internal.IBuffer m_DataBuffer
- private readonly Unity.Services.Analytics.Internal.IDispatcher m_DataDispatcher
- private readonly Unity.Services.Analytics.Data.IDataGenerator m_DataGenerator
- private bool m_IsActive
- private readonly Unity.Services.Analytics.Internal.ISessionManager m_Session
- private bool m_StartUpEventsRecorded
- private readonly Unity.Services.Analytics.IAnalyticsServiceSystemCalls m_SystemCalls
- private readonly Unity.Services.Analytics.Internal.IIdentityManager m_UserIdentity

#### Properties
- internal bool Active { get; set; }
- internal int AutoflushPeriodMultiplier { get; }
- public bool IsActive { get; }
- public string PrivacyUrl { get; }
- public string SessionID { get; }
- public Unity.Services.Analytics.Internal.IIdentityManager UserIdentity { get; }

#### Constructors
- internal AnalyticsServiceInstance(Unity.Services.Analytics.Data.IDataGenerator dataGenerator, Unity.Services.Analytics.Internal.IBuffer realBuffer, Unity.Services.Analytics.ICoreStatsHelper coreStatsHelper, Unity.Services.Analytics.Internal.IDispatcher dispatcher, Unity.Services.Analytics.Internal.IAnalyticsForgetter forgetter, Unity.Services.Analytics.Internal.IIdentityManager userIdentity, string environment, Unity.Services.Analytics.IAnalyticsServiceSystemCalls systemCalls, Unity.Services.Analytics.IAnalyticsContainer container, Unity.Services.Analytics.Internal.ISessionManager session)

#### Methods
- private void Activate()
- internal void ApplicationPaused(bool paused)
- internal void ApplicationQuit()
- public long ConvertCurrencyToMinorUnits(string currencyCode, double value)
- public void CustomData(string eventName)
- public void CustomData(string eventName, System.Collections.Generic.IDictionary<string, object> eventParams)
- public void CustomData(string eventName, System.Collections.Generic.IDictionary<string, object> eventParams, System.Nullable<int> eventVersion, bool isStandardEvent, string callingMethodIdentifier)
- private void DataDeletionCompleted()
- private void Deactivate()
- internal void DeactivateWithDataDeletionRequest()
- public void Flush()
- public string GetAnalyticsUserID()
- private void PlayerChanged()
- public void RecordEvent(string name)
- public void RecordEvent(Unity.Services.Analytics.Event e)
- internal void RecordEvent(Unity.Services.Analytics.Event e, string callingMethodIdentifier)
- internal void RecordGameRunningIfNecessary()
- private void RecordStartupEvents(string callingId)
- public void RequestDataDeletion()
- internal void ResumeDataDeletionIfNecessary()
- public void StartDataCollection()
- public void StopDataCollection()

### internal class Unity.Services.Analytics.AnalyticsServiceSystemCalls
- Interfaces: Unity.Services.Analytics.IAnalyticsServiceSystemCalls

#### Properties
- public System.DateTime UtcNow { get; }

#### Constructors
- public AnalyticsServiceSystemCalls()

### internal class Unity.Services.Analytics.CoreStatsHelper
- Interfaces: Unity.Services.Analytics.ICoreStatsHelper

#### Constructors
- public CoreStatsHelper()

#### Methods
- public void SetCoreStatsConsent(bool userProvidedConsent)

### public class Unity.Services.Analytics.CustomEvent
- Base: Unity.Services.Analytics.Event
- Interfaces: System.Collections.IEnumerable

#### Properties
- public object Item { set; }

#### Constructors
- public CustomEvent(string name)

#### Methods
- public void Add(string key, object value)
- public System.Collections.IEnumerator GetEnumerator()

### public class Unity.Services.Analytics.Event

#### Fields
- internal readonly int EventVersion
- private protected readonly System.Collections.Generic.Dictionary<string, bool> m_Booleans
- private protected readonly System.Collections.Generic.Dictionary<string, double> m_Floats
- private protected readonly System.Collections.Generic.Dictionary<string, long> m_Integers
- private protected readonly System.Collections.Generic.Dictionary<string, string> m_Strings
- internal readonly string Name
- internal readonly bool StandardEvent

#### Constructors
- protected Event(string name)
- internal Event(string name, bool standardEvent, int eventVersion)

#### Methods
- internal static string[] BakeEnum2String<T>(bool toUpper = false)
- protected bool ParameterHasBeenSet(string name)
- public virtual void Reset()
- internal virtual void Serialize(Unity.Services.Analytics.Internal.IBuffer buffer)
- protected void SetParameter(string name, string value)
- protected void SetParameter(string name, bool value)
- protected void SetParameter(string name, int value)
- protected void SetParameter(string name, long value)
- protected void SetParameter(string name, float value)
- protected void SetParameter(string name, double value)
- public virtual void Validate()

### internal interface Unity.Services.Analytics.IAnalyticsContainer

#### Methods
- public void Disable()
- public void Enable()
- public void Initialize(Unity.Services.Analytics.AnalyticsServiceInstance service)

### public interface Unity.Services.Analytics.IAnalyticsService

#### Properties
- public string PrivacyUrl { get; }
- public string SessionID { get; }

#### Methods
- public long ConvertCurrencyToMinorUnits(string currencyCode, double value)
- public void Flush()
- public string GetAnalyticsUserID()
- public void RecordEvent(Unity.Services.Analytics.Event e)
- public void RecordEvent(string eventName)
- public void RequestDataDeletion()
- public void StartDataCollection()
- public void StopDataCollection()

### internal interface Unity.Services.Analytics.IAnalyticsServiceSystemCalls

#### Properties
- public System.DateTime UtcNow { get; }

### internal interface Unity.Services.Analytics.ICoreStatsHelper

#### Methods
- public void SetCoreStatsConsent(bool userProvidedConsent)

### internal interface Unity.Services.Analytics.IUnstructuredEventRecorder

#### Methods
- public void CustomData(string eventName, System.Collections.Generic.IDictionary<string, object> eventParams, System.Nullable<int> eventVersion, bool isStandardEvent, string callingMethodIdentifier)

### public static class Unity.Services.Analytics.SdkVersion

#### Fields
- public static readonly string SDK_VERSION

#### Constructors
- private static SdkVersion()

### internal class Unity.Services.Analytics.TransactionCurrencyConverter

#### Fields
- private readonly System.Collections.Generic.Dictionary<string, int> m_Iso4217CurrencyMinorUnits

#### Constructors
- public TransactionCurrencyConverter()

#### Methods
- public long Convert(string currencyCode, double value)

### public class Unity.Services.Analytics.TransactionEvent
- Base: Unity.Services.Analytics.Event

#### Fields
- private System.Collections.Generic.List<Unity.Services.Analytics.TransactionItem> <ReceivedItems>k__BackingField
- private Unity.Services.Analytics.TransactionRealCurrency <ReceivedRealCurrency>k__BackingField
- private System.Collections.Generic.List<Unity.Services.Analytics.TransactionVirtualCurrency> <ReceivedVirtualCurrencies>k__BackingField
- private System.Collections.Generic.List<Unity.Services.Analytics.TransactionItem> <SpentItems>k__BackingField
- private Unity.Services.Analytics.TransactionRealCurrency <SpentRealCurrency>k__BackingField
- private System.Collections.Generic.List<Unity.Services.Analytics.TransactionVirtualCurrency> <SpentVirtualCurrencies>k__BackingField
- private static readonly string[] k_TransactionServerValues
- private static readonly string[] k_TransactionTypeValues

#### Properties
- public string PaymentCountry { set; }
- public string ProductId { set; }
- public System.Collections.Generic.List<Unity.Services.Analytics.TransactionItem> ReceivedItems { get; private set; }
- public Unity.Services.Analytics.TransactionRealCurrency ReceivedRealCurrency { get; set; }
- public System.Collections.Generic.List<Unity.Services.Analytics.TransactionVirtualCurrency> ReceivedVirtualCurrencies { get; private set; }
- public System.Collections.Generic.List<Unity.Services.Analytics.TransactionItem> SpentItems { get; private set; }
- public Unity.Services.Analytics.TransactionRealCurrency SpentRealCurrency { get; set; }
- public System.Collections.Generic.List<Unity.Services.Analytics.TransactionVirtualCurrency> SpentVirtualCurrencies { get; private set; }
- public string StoreId { set; }
- public string StoreItemId { set; }
- public string StoreItemSkuId { set; }
- public string StoreSourceId { set; }
- public string TransactionId { set; }
- public string TransactionName { set; }
- public string TransactionReceipt { set; }
- public string TransactionReceiptSignature { set; }
- public Unity.Services.Analytics.TransactionServer TransactionServer { set; }
- public Unity.Services.Analytics.TransactionType TransactionType { set; }
- public string TransactorID { set; }

#### Constructors
- public TransactionEvent()
- private static TransactionEvent()
- protected internal TransactionEvent(string name)

#### Methods
- public override void Reset()
- internal override void Serialize(Unity.Services.Analytics.Internal.IBuffer buffer)
- public override void Validate()

### public class Unity.Services.Analytics.TransactionFailedEvent
- Base: Unity.Services.Analytics.TransactionEvent

#### Properties
- public string FailureReason { set; }

#### Constructors
- public TransactionFailedEvent()

#### Methods
- public override void Validate()

### public class Unity.Services.Analytics.TransactionItem

#### Fields
- public long ItemAmount
- public string ItemName
- public string ItemType

#### Constructors
- public TransactionItem()

#### Methods
- internal void Serialize(Unity.Services.Analytics.Internal.IBuffer buffer)

### public class Unity.Services.Analytics.TransactionRealCurrency

#### Fields
- public long RealCurrencyAmount
- public string RealCurrencyType

#### Constructors
- public TransactionRealCurrency()

#### Methods
- internal void Serialize(Unity.Services.Analytics.Internal.IBuffer buffer)

### public enum Unity.Services.Analytics.TransactionServer
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AMAZON = 1
- APPLE = 0
- GOOGLE = 2
- VALVE = 3

### public enum Unity.Services.Analytics.TransactionType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- INVALID = 0
- PURCHASE = 2
- SALE = 1
- TRADE = 3

### public class Unity.Services.Analytics.TransactionVirtualCurrency

#### Fields
- private static readonly string[] k_VirtualCurrencyTypeValues
- public long VirtualCurrencyAmount
- public string VirtualCurrencyName
- public Unity.Services.Analytics.VirtualCurrencyType VirtualCurrencyType

#### Constructors
- public TransactionVirtualCurrency()
- private static TransactionVirtualCurrency()

#### Methods
- internal void Serialize(Unity.Services.Analytics.Internal.IBuffer buffer)

### public enum Unity.Services.Analytics.VirtualCurrencyType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- GRIND = 0
- PREMIUM = 1
- PREMIUM_GRIND = 2

## Namespace: Unity.Services.Analytics.Data

### internal class Unity.Services.Analytics.Data.CommonDataWrapper
- Interfaces: Unity.Services.Analytics.Data.ICommonData

#### Fields
- private readonly string <BuildGUID>k__BackingField
- private readonly string <GameBundleId>k__BackingField
- private readonly string <GameStoreId>k__BackingField
- private readonly bool <HasVolume>k__BackingField
- private readonly string <Idfv>k__BackingField
- private readonly string <Platform>k__BackingField
- private readonly string <ProjectId>k__BackingField
- private readonly string <Version>k__BackingField

#### Properties
- public string AnalyticsRegionLanguageCode { get; }
- public double BatteryLevel { get; }
- public string BuildGUID { get; }
- public string GameBundleId { get; }
- public string GameStoreId { get; }
- public bool HasVolume { get; }
- public string Idfv { get; }
- public string Platform { get; }
- public string ProjectId { get; }
- public string Version { get; }
- public float Volume { get; }

#### Constructors
- public CommonDataWrapper(string cloudProjectId)

#### Methods
- private static string GetPlatform()

### internal class Unity.Services.Analytics.Data.DataGenerator
- Interfaces: Unity.Services.Analytics.Data.IDataGenerator

#### Fields
- private readonly Unity.Services.Analytics.Internal.IBuffer m_Buffer
- private readonly Unity.Services.Analytics.Data.ICommonData m_CommonData
- private readonly Unity.Services.Analytics.Data.IDeviceData m_DeviceData

#### Constructors
- public DataGenerator(Unity.Services.Analytics.Internal.IBuffer buffer, Unity.Services.Analytics.Data.ICommonData staticData, Unity.Services.Analytics.Data.IDeviceData deviceData)

#### Methods
- public void ClientDevice(string callingMethodIdentifier)
- public void GameEnded(string callingMethodIdentifier, Unity.Services.Analytics.Data.DataGenerator.SessionEndState quitState)
- public void GameRunning(string callingMethodIdentifier)
- public void GameStarted(string callingMethodIdentifier)
- public void NewPlayer(string callingMethodIdentifier)
- public void PushCommonParams(string callingMethodIdentifier)
- public void PushEmptyEvent(string name)
- public void PushEvent(string callingMethodIdentifier, Unity.Services.Analytics.Event e)
- public void SdkStartup(string callingMethodIdentifier)

### internal class Unity.Services.Analytics.Data.DeviceDataWrapper
- Interfaces: Unity.Services.Analytics.Data.IDeviceData

#### Properties
- public int CpuCores { get; }
- public string CpuType { get; }
- public string DeviceModel { get; }
- public string GpuType { get; }
- public bool IsDebugDevice { get; }
- public bool IsTiny { get; }
- public string OperatingSystem { get; }
- public int RamTotal { get; }
- public float ScreenDpi { get; }
- public int ScreenHeight { get; }
- public int ScreenWidth { get; }

#### Constructors
- public DeviceDataWrapper()

### internal interface Unity.Services.Analytics.Data.ICommonData

#### Properties
- public string AnalyticsRegionLanguageCode { get; }
- public double BatteryLevel { get; }
- public string BuildGUID { get; }
- public string GameBundleId { get; }
- public string GameStoreId { get; }
- public bool HasVolume { get; }
- public string Idfv { get; }
- public string Platform { get; }
- public string ProjectId { get; }
- public string Version { get; }
- public float Volume { get; }

### internal interface Unity.Services.Analytics.Data.IDataGenerator

#### Methods
- public void ClientDevice(string callingMethodIdentifier)
- public void GameEnded(string callingMethodIdentifier, Unity.Services.Analytics.Data.DataGenerator.SessionEndState quitState)
- public void GameRunning(string callingMethodIdentifier)
- public void GameStarted(string callingMethodIdentifier)
- public void NewPlayer(string callingMethodIdentifier)
- public void PushCommonParams(string callingMethodIdentifier)
- public void PushEmptyEvent(string name)
- public void PushEvent(string callingMethodIdentifier, Unity.Services.Analytics.Event e)
- public void SdkStartup(string callingMethodIdentifier)

### internal interface Unity.Services.Analytics.Data.IDeviceData

#### Properties
- public int CpuCores { get; }
- public string CpuType { get; }
- public string DeviceModel { get; }
- public string GpuType { get; }
- public bool IsDebugDevice { get; }
- public bool IsTiny { get; }
- public string OperatingSystem { get; }
- public int RamTotal { get; }
- public float ScreenDpi { get; }
- public int ScreenHeight { get; }
- public int ScreenWidth { get; }

### internal enum Unity.Services.Analytics.Data.DataGenerator.SessionEndState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- KILLEDINBACKGROUND = 1
- KILLEDINFOREGROUND = 2
- PAUSED = 0
- QUIT = 3

## Namespace: Unity.Services.Analytics.Internal

### private class Unity.Services.Analytics.Internal.WebRequestHelper.<>c__DisplayClass2_0

#### Fields
- public System.Action<long> onCompleted
- public UnityEngine.Networking.UnityWebRequestAsyncOperation requestOp

#### Constructors
- public WebRequestHelper.<>c__DisplayClass2_0()

#### Methods
- internal void <SendWebRequest>b__0(UnityEngine.AsyncOperation <p0>)

### internal class Unity.Services.Analytics.Internal.AnalyticsForgetter
- Interfaces: Unity.Services.Analytics.Internal.IAnalyticsForgetter

#### Fields
- private static const string k_ForgottenStatusKey
- private System.Action m_Callback
- private readonly string m_CollectUrl
- private Unity.Services.Analytics.Internal.AnalyticsForgetter.DataDeletionStatus m_DeletionStatus
- private readonly Unity.Services.Analytics.Internal.IPersistence m_Persistence
- private Unity.Services.Analytics.Internal.IWebRequest m_Request
- private readonly Unity.Services.Analytics.Internal.IWebRequestHelper m_WebRequestHelper

#### Properties
- public bool DeletionInProgress { get; }

#### Constructors
- internal AnalyticsForgetter(string collectUrl, Unity.Services.Analytics.Internal.IPersistence persistence, Unity.Services.Analytics.Internal.IWebRequestHelper webRequestHelper)

#### Methods
- public void AttemptToForget(string userId, string installationId, string playerId, string timestamp, string callingMethod, System.Action successfulUploadCallback)
- public void ResetDataDeletionStatus()
- private void SetForgettingStatus(Unity.Services.Analytics.Internal.AnalyticsForgetter.DataDeletionStatus state)
- private void UploadComplete(long code)

### internal class Unity.Services.Analytics.Internal.AnalyticsUserIdServiceComponent
- Interfaces: Unity.Services.Core.Analytics.Internal.IAnalyticsUserId, Unity.Services.Core.Internal.IServiceComponent

#### Fields
- private readonly Unity.Services.Analytics.IAnalyticsService m_AnalyticsService

#### Constructors
- public AnalyticsUserIdServiceComponent(Unity.Services.Analytics.IAnalyticsService analyticsService)

#### Methods
- public string GetAnalyticsUserId()

### internal class Unity.Services.Analytics.Internal.AnalyticsWebRequest
- Base: UnityEngine.Networking.UnityWebRequest
- Interfaces: System.IDisposable, Unity.Services.Analytics.Internal.IWebRequest

#### Properties
- public bool IsNetworkError { get; }

#### Constructors
- internal AnalyticsWebRequest(string url, string method)

#### Methods
- private UnityEngine.Networking.UploadHandler Unity.Services.Analytics.Internal.IWebRequest.get_uploadHandler()
- private UnityEngine.Networking.UnityWebRequestAsyncOperation Unity.Services.Analytics.Internal.IWebRequest.SendWebRequest()
- private void Unity.Services.Analytics.Internal.IWebRequest.SetRequestHeader(string key, string value)
- private void Unity.Services.Analytics.Internal.IWebRequest.set_uploadHandler(UnityEngine.Networking.UploadHandler value)

### internal class Unity.Services.Analytics.Internal.BufferSystemCalls
- Interfaces: Unity.Services.Analytics.Internal.IBufferSystemCalls

#### Constructors
- public BufferSystemCalls()

#### Methods
- public string GenerateGuid()
- public System.TimeSpan GetTimeZoneUtcOffset(System.DateTime dateTime)
- public System.DateTime Now()

### internal class Unity.Services.Analytics.Internal.BufferX
- Interfaces: Unity.Services.Analytics.Internal.IBuffer, Unity.Services.Analytics.Internal.IBufferDebug

#### Fields
- private System.Action<string, string, System.DateTime, byte[]> EventRecorded
- private System.Action<System.Collections.Generic.HashSet<string>> EventsCleared
- private System.Action<System.Collections.Generic.HashSet<string>> EventsClearing
- private readonly byte[] k_CloseBraceComma
- private readonly byte[] k_CloseBracketComma
- private readonly byte[] k_CloseEvent
- private readonly byte k_Colon
- private readonly byte[] k_Comma
- private readonly byte k_Dash
- private readonly byte[] k_False
- private readonly byte[] k_HeaderEventName
- private readonly byte[] k_HeaderEventUUID
- private readonly byte[] k_HeaderEventVersion
- private readonly byte[] k_HeaderInstallationID
- private readonly byte[] k_HeaderOpenEventParams
- private readonly byte[] k_HeaderPlayerID
- private readonly byte[] k_HeaderSessionID
- private readonly byte[] k_HeaderTimestamp
- private readonly byte[] k_HeaderUserName
- private readonly byte[] k_Int2CharacterByte
- private static const string k_MillisecondDateFormat
- private readonly byte k_Negative
- private readonly byte[] k_OpenBrace
- private readonly byte[] k_OpenBracket
- private readonly long[] k_Order
- private readonly byte[] k_PayloadHeader
- private readonly byte k_Point
- private readonly byte k_Positive
- private readonly byte k_Quote
- private readonly byte[] k_QuoteColon
- private readonly byte[] k_QuoteComma
- private readonly byte k_Space
- private readonly byte[] k_True
- private static const long k_UploadBatchMaximumSizeInBytes
- private readonly byte[] k_WorkingBuffer
- private readonly char[] k_WorkingCharacterBuffer
- private System.IO.MemoryStream m_Buffer
- private string m_CurrentEventId
- private string m_CurrentEventName
- private System.DateTime m_CurrentEventTimestamp
- private readonly Unity.Services.Analytics.Internal.IDiskCache m_DiskCache
- private readonly System.Collections.Generic.List<Unity.Services.Analytics.Internal.EventSummary> m_EventSummaries
- private readonly Unity.Services.Analytics.Internal.ISessionManager m_Session
- private System.IO.MemoryStream m_SpareBuffer
- private readonly Unity.Services.Analytics.Internal.IBufferSystemCalls m_SystemCalls
- private readonly Unity.Services.Analytics.Internal.IIdentityManager m_UserIdentity

#### Properties
- internal int EventsRecorded { get; }
- internal System.Collections.Generic.IReadOnlyList<Unity.Services.Analytics.Internal.EventSummary> EventSummaries { get; }
- public int Length { get; }
- internal byte[] RawContents { get; }

#### Events
- public event System.Action<string, string, System.DateTime, byte[]> EventRecorded
- public event System.Action<System.Collections.Generic.HashSet<string>> EventsCleared
- public event System.Action<System.Collections.Generic.HashSet<string>> EventsClearing

#### Constructors
- public BufferX(Unity.Services.Analytics.Internal.IBufferSystemCalls eventIdGenerator, Unity.Services.Analytics.Internal.IDiskCache diskCache, Unity.Services.Analytics.Internal.IIdentityManager userIdentity, Unity.Services.Analytics.Internal.ISessionManager session)

#### Methods
- public void ClearBuffer()
- public void ClearBuffer(long upTo)
- public void ClearDiskCache()
- public void FlushToDisk()
- public void LoadFromDisk()
- private int ProcessCharacterOntoWorkingBuffer(int index, char character)
- public void PushArrayEnd()
- public void PushArrayStart(string name)
- public void PushBool(string name, bool value)
- private void PushCommonEventStart(string name)
- public void PushCustomEventStart(string name)
- public void PushDouble(string name, double value)
- public void PushEndEvent()
- public void PushFloat(string name, float value)
- public void PushInt(string name, int value)
- public void PushInt64(string name, long value)
- public void PushObject(string name, object value)
- public void PushObjectEnd()
- public void PushObjectStart(string name)
- public void PushProduct(string name, Unity.Services.Analytics.TransactionRealCurrency realCurrency, System.Collections.Generic.List<Unity.Services.Analytics.TransactionVirtualCurrency> virtualCurrencies, System.Collections.Generic.List<Unity.Services.Analytics.TransactionItem> items)
- public void PushStandardEventStart(string name, int version)
- public void PushString(string name, string value)
- public void PushTimestamp(string name, System.DateTime value)
- public byte[] Serialize()
- internal static string SerializeDateTime(System.DateTime dateTime)
- private int SerializeLong(in long number, in byte[] buffer, in int startIndex, in int minimumLength)
- private void StripTrailingCommaIfNecessary()
- private void WriteByte(in byte value)
- private void WriteBytes(in byte[] bytes)
- private void WriteDateTime(System.DateTime dateTime)
- private void WriteLong(in long value)
- private void WriteName(string name)
- private void WriteString(in string value)

### private enum Unity.Services.Analytics.Internal.AnalyticsForgetter.DataDeletionStatus
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DataAllowed = 0
- DeletionInProgress = 1
- SuccessfullyDeleted = 2

### internal class Unity.Services.Analytics.Internal.DiskCache
- Interfaces: Unity.Services.Analytics.Internal.IDiskCache

#### Fields
- private readonly long k_CacheFileMaximumSize
- private readonly string k_CacheFilePath
- internal static const int k_CacheFileVersionOne
- internal static const int k_CacheFileVersionTwo
- internal static const string k_FileHeaderString
- private readonly Unity.Services.Analytics.Internal.IFileSystemCalls k_SystemCalls

#### Constructors
- internal DiskCache(Unity.Services.Analytics.Internal.IFileSystemCalls systemCalls)
- internal DiskCache(string cacheFilePath, Unity.Services.Analytics.Internal.IFileSystemCalls systemCalls, long maximumFileSize)

#### Methods
- public void Clear()
- public bool Read(System.Collections.Generic.List<Unity.Services.Analytics.Internal.EventSummary> eventSummaries, System.IO.Stream buffer)
- private void ReadVersionOneCacheFile(in System.Collections.Generic.List<Unity.Services.Analytics.Internal.EventSummary> eventEndIndices, System.IO.BinaryReader reader, in System.IO.Stream buffer)
- private void ReadVersionTwoCacheFile(in System.Collections.Generic.List<Unity.Services.Analytics.Internal.EventSummary> eventSummaries, System.IO.BinaryReader reader, in System.IO.Stream buffer)
- public void Write(System.Collections.Generic.List<Unity.Services.Analytics.Internal.EventSummary> eventSummaries, System.IO.Stream payload)

### internal class Unity.Services.Analytics.Internal.Dispatcher
- Interfaces: Unity.Services.Analytics.Internal.IDispatcher, Unity.Services.Analytics.Internal.IDispatcherDebug

#### Fields
- private int <ConsecutiveFailedUploadCount>k__BackingField
- private bool <FlushInProgress>k__BackingField
- private System.Action<int, bool, bool, bool, bool, byte[]> FlushFinished
- private System.Action<byte[]> FlushStarted
- internal static const string k_HeaderTrueValue
- internal static const string k_PiplConsentHeaderKey
- internal static const string k_PiplExportHeaderKey
- private readonly string m_CollectUrl
- private Unity.Services.Analytics.Internal.IBuffer m_DataBuffer
- private int m_FlushBufferIndex
- private Unity.Services.Analytics.Internal.IWebRequest m_FlushRequest
- private byte[] m_LastFlushPayload
- private readonly Unity.Services.Analytics.Internal.IWebRequestHelper m_WebRequestHelper

#### Properties
- public int ConsecutiveFailedUploadCount { get; private set; }
- public bool FlushInProgress { get; private set; }

#### Events
- public event System.Action<int, bool, bool, bool, bool, byte[]> FlushFinished
- public event System.Action<byte[]> FlushStarted

#### Constructors
- public Dispatcher(Unity.Services.Analytics.Internal.IWebRequestHelper webRequestHelper, string collectUrl)

#### Methods
- public void Flush()
- private void FlushBufferToService()
- public void SetBuffer(Unity.Services.Analytics.Internal.IBuffer buffer)
- private void UploadCompleted(long responseCode)

### internal struct Unity.Services.Analytics.Internal.EventSummary

#### Fields
- internal int EndIndex
- internal string Id
- internal int StartIndex

### internal class Unity.Services.Analytics.Internal.FileSystemCalls
- Interfaces: Unity.Services.Analytics.Internal.IFileSystemCalls

#### Fields
- private readonly bool m_CanAccessFileSystem

#### Constructors
- internal FileSystemCalls()

#### Methods
- public bool CanAccessFileSystem()
- public void DeleteFile(string path)
- public bool FileExists(string path)
- public System.IO.Stream OpenFileForReading(string path)
- public System.IO.Stream OpenFileForWriting(string path)

### internal interface Unity.Services.Analytics.Internal.IAnalyticsForgetter

#### Properties
- public bool DeletionInProgress { get; }

#### Methods
- public void AttemptToForget(string userId, string installationId, string playerId, string timestamp, string callingMethod, System.Action successfulUploadCallback)
- public void ResetDataDeletionStatus()

### internal interface Unity.Services.Analytics.Internal.IBuffer

#### Properties
- public int Length { get; }

#### Methods
- public void ClearBuffer()
- public void ClearBuffer(long upTo)
- public void ClearDiskCache()
- public void FlushToDisk()
- public void LoadFromDisk()
- public void PushBool(string name, bool value)
- public void PushCustomEventStart(string name)
- public void PushDouble(string name, double value)
- public void PushEndEvent()
- public void PushFloat(string name, float value)
- public void PushInt(string name, int value)
- public void PushInt64(string name, long value)
- public void PushObject(string name, object value)
- public void PushProduct(string name, Unity.Services.Analytics.TransactionRealCurrency realCurrency, System.Collections.Generic.List<Unity.Services.Analytics.TransactionVirtualCurrency> virtualCurrencies, System.Collections.Generic.List<Unity.Services.Analytics.TransactionItem> items)
- public void PushStandardEventStart(string name, int version)
- public void PushString(string name, string value)
- public byte[] Serialize()

### internal interface Unity.Services.Analytics.Internal.IBufferDebug

#### Events
- public event System.Action<string, string, System.DateTime, byte[]> EventRecorded
- public event System.Action<System.Collections.Generic.HashSet<string>> EventsCleared
- public event System.Action<System.Collections.Generic.HashSet<string>> EventsClearing

### internal interface Unity.Services.Analytics.Internal.IBufferSystemCalls

#### Methods
- public string GenerateGuid()
- public System.TimeSpan GetTimeZoneUtcOffset(System.DateTime dateTime)
- public System.DateTime Now()

### internal interface Unity.Services.Analytics.Internal.IContainerDebug

#### Properties
- public float TimeUntilNextHeartbeat { get; }

### internal class Unity.Services.Analytics.Internal.IdentityManager
- Interfaces: Unity.Services.Analytics.Internal.IIdentityManager

#### Fields
- private string <ExternalId>k__BackingField
- private string <InstallId>k__BackingField
- private bool <IsNewPlayer>k__BackingField
- private string <UserId>k__BackingField
- internal static const string k_UnityAnalyticsInstallationIdKey
- internal static const string k_UnityAnalyticsUserIdKey
- private readonly Unity.Services.Core.Configuration.Internal.IExternalUserId m_ExternalIdProvider
- private bool m_Initialized
- private readonly Unity.Services.Analytics.Internal.IPersistence m_Persistence
- private readonly Unity.Services.Authentication.Internal.IPlayerId m_PlayerId
- private System.Action OnPlayerChanged

#### Properties
- public string ExternalId { get; private set; }
- public string InstallId { get; private set; }
- public bool IsNewPlayer { get; private set; }
- public string PlayerId { get; }
- public string UserId { get; private set; }

#### Events
- public event System.Action OnPlayerChanged

#### Constructors
- public IdentityManager(Unity.Services.Core.Device.Internal.IInstallationId installId, Unity.Services.Authentication.Internal.IPlayerId playerId, Unity.Services.Core.Configuration.Internal.IExternalUserId externalId, Unity.Services.Analytics.Internal.IPersistence persistence)

#### Methods
- private void ExternalUserIdChanged(string newName)
- public void Initialize()

### internal interface Unity.Services.Analytics.Internal.IDiskCache

#### Methods
- public void Clear()
- public bool Read(System.Collections.Generic.List<Unity.Services.Analytics.Internal.EventSummary> eventSummaries, System.IO.Stream buffer)
- public void Write(System.Collections.Generic.List<Unity.Services.Analytics.Internal.EventSummary> eventSummaries, System.IO.Stream payload)

### internal interface Unity.Services.Analytics.Internal.IDispatcher

#### Properties
- public int ConsecutiveFailedUploadCount { get; }

#### Methods
- public void Flush()
- public void SetBuffer(Unity.Services.Analytics.Internal.IBuffer buffer)

### internal interface Unity.Services.Analytics.Internal.IDispatcherDebug

#### Properties
- public bool FlushInProgress { get; }

#### Events
- public event System.Action<int, bool, bool, bool, bool, byte[]> FlushFinished
- public event System.Action<byte[]> FlushStarted

### internal interface Unity.Services.Analytics.Internal.IFileSystemCalls

#### Methods
- public bool CanAccessFileSystem()
- public void DeleteFile(string path)
- public bool FileExists(string path)
- public System.IO.Stream OpenFileForReading(string path)
- public System.IO.Stream OpenFileForWriting(string path)

### internal interface Unity.Services.Analytics.Internal.IIdentityManager

#### Properties
- public string ExternalId { get; }
- public string InstallId { get; }
- public bool IsNewPlayer { get; }
- public string PlayerId { get; }
- public string UserId { get; }

#### Events
- public event System.Action OnPlayerChanged

#### Methods
- public void Initialize()

### internal interface Unity.Services.Analytics.Internal.IPersistence

#### Methods
- public void ClearValue(string key)
- public int LoadInt(string key)
- public string LoadString(string key)
- public void SaveValue(string key, int value)
- public void SaveValue(string key, string value)

### internal interface Unity.Services.Analytics.Internal.IServiceDebug

#### Properties
- public bool IsActive { get; }
- public Unity.Services.Analytics.Internal.IIdentityManager UserIdentity { get; }

### internal interface Unity.Services.Analytics.Internal.ISessionManager

#### Properties
- public string SessionId { get; }

#### Methods
- public void StartNewSession()

### internal interface Unity.Services.Analytics.Internal.IWebRequest
- Interfaces: System.IDisposable

#### Properties
- public bool IsNetworkError { get; }
- public UnityEngine.Networking.UploadHandler uploadHandler { get; set; }

#### Methods
- public UnityEngine.Networking.UnityWebRequestAsyncOperation SendWebRequest()
- public void SetRequestHeader(string key, string value)

### internal interface Unity.Services.Analytics.Internal.IWebRequestHelper

#### Methods
- public Unity.Services.Analytics.Internal.IWebRequest CreateWebRequest(string url, string method, byte[] postBytes)
- public void SendWebRequest(Unity.Services.Analytics.Internal.IWebRequest request, System.Action<long> onCompleted)

### internal static class Unity.Services.Analytics.Internal.Locale

#### Methods
- internal static string AnalyticsRegionLanguageCode()
- internal static string CurrentLanguageCode()

### internal class Unity.Services.Analytics.Internal.PlayerPrefsPersistence
- Interfaces: Unity.Services.Analytics.Internal.IPersistence

#### Constructors
- public PlayerPrefsPersistence()

#### Methods
- public void ClearValue(string key)
- public int LoadInt(string key)
- public string LoadString(string key)
- public void SaveValue(string key, int value)
- public void SaveValue(string key, string value)

### internal class Unity.Services.Analytics.Internal.SessionManager
- Interfaces: Unity.Services.Analytics.Internal.ISessionManager

#### Fields
- private string <SessionId>k__BackingField

#### Properties
- public string SessionId { get; private set; }

#### Constructors
- public SessionManager()

#### Methods
- public void StartNewSession()

### internal class Unity.Services.Analytics.Internal.StandardEventServiceComponent
- Interfaces: Unity.Services.Core.Analytics.Internal.IAnalyticsStandardEventComponent, Unity.Services.Core.Internal.IServiceComponent

#### Fields
- private readonly Unity.Services.Analytics.IUnstructuredEventRecorder m_AnalyticsService
- private readonly Unity.Services.Core.Configuration.Internal.IProjectConfiguration m_Configuration

#### Constructors
- public StandardEventServiceComponent(Unity.Services.Core.Configuration.Internal.IProjectConfiguration configuration, Unity.Services.Analytics.IUnstructuredEventRecorder analyticsService)

#### Methods
- public void Record(string eventName, System.Collections.Generic.IDictionary<string, object> eventParameters, int eventVersion, string packageName)

### internal class Unity.Services.Analytics.Internal.WebRequestHelper
- Interfaces: Unity.Services.Analytics.Internal.IWebRequestHelper

#### Fields
- private readonly string k_ClientIdHeaderValue

#### Constructors
- public WebRequestHelper()

#### Methods
- public Unity.Services.Analytics.Internal.IWebRequest CreateWebRequest(string url, string method, byte[] postBytes)
- public void SendWebRequest(Unity.Services.Analytics.Internal.IWebRequest request, System.Action<long> onCompleted)

## Namespace: Unity.Services.Analytics.Platform

### internal static class Unity.Services.Analytics.Platform.DeviceVolumeProvider

#### Properties
- internal static bool VolumeAvailable { get; }

#### Methods
- internal static float GetDeviceVolume()

