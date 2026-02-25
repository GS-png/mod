# Assembly: UnityEngine.UnityAnalyticsModule
- Path: tools/WorldBox.Managed/UnityEngine.UnityAnalyticsModule.dll
- Types: 15

## Namespace: UnityEngine

### public class UnityEngine.RemoteConfigSettings
- Interfaces: System.IDisposable

#### Fields
- internal System.IntPtr m_Ptr
- private System.Action<bool> Updated

#### Events
- public event System.Action<bool> Updated

#### Constructors
- private RemoteConfigSettings()
- public RemoteConfigSettings(string configKey)

#### Methods
- public static void AddSessionTag(string tag)
- private void Destroy()
- public void Dispose()
- protected override void Finalize()
- public void ForceUpdate()
- internal object GetAsScriptingObject(System.Type t, object defaultValue, string key)
- public bool GetBool(string key)
- public bool GetBool(string key, bool defaultValue)
- public int GetCount()
- public System.Collections.Generic.IDictionary<string, object> GetDictionary(string key = "")
- public float GetFloat(string key)
- public float GetFloat(string key, float defaultValue)
- public int GetInt(string key)
- public int GetInt(string key, int defaultValue)
- public string[] GetKeys()
- public long GetLong(string key)
- public long GetLong(string key, long defaultValue)
- public T GetObject<T>(string key = "")
- public object GetObject(System.Type type, string key = "")
- public object GetObject(string key, object defaultValue)
- internal System.IntPtr GetSafeTopMap()
- public string GetString(string key)
- public string GetString(string key, string defaultValue)
- public bool HasKey(string key)
- internal static System.IntPtr Internal_Create(UnityEngine.RemoteConfigSettings rcs, string configKey)
- internal static void Internal_Destroy(System.IntPtr ptr)
- public static bool QueueConfig(string name, object param, int ver = 1, string prefix = "")
- internal void ReleaseSafeLock()
- internal static void RemoteConfigSettingsUpdated(UnityEngine.RemoteConfigSettings rcs, bool wasLastUpdatedFromServer)
- public static bool SendDeviceInfoInConfigRequest()
- internal void UseSafeLock()
- public bool WasLastUpdatedFromServer()

### internal static class UnityEngine.RemoteConfigSettingsHelper

#### Methods
- internal static object GetArrayArrayEntries(System.IntPtr a, long i)
- internal static object GetArrayEntries(System.IntPtr a)
- internal static T[] GetArrayEntriesType<T>(System.IntPtr a, long size, System.Func<System.IntPtr, long, T> f)
- internal static System.Collections.Generic.IDictionary<string, object> GetArrayMapEntries(System.IntPtr a, long i)
- public static System.Collections.Generic.IDictionary<string, object> GetDictionary(System.IntPtr m, string key)
- internal static System.Collections.Generic.IDictionary<string, object> GetDictionary(System.IntPtr m)
- internal static object GetMixedArrayEntries(System.IntPtr a)
- internal static System.IntPtr GetSafeArray(System.IntPtr m, string key)
- internal static System.IntPtr GetSafeArrayArray(System.IntPtr a, long i)
- internal static bool GetSafeArrayBool(System.IntPtr a, long i)
- internal static float GetSafeArrayFloat(System.IntPtr a, long i)
- internal static System.IntPtr GetSafeArrayMap(System.IntPtr a, long i)
- internal static long GetSafeArraySize(System.IntPtr a)
- internal static string GetSafeArrayStringValue(System.IntPtr a, long i)
- internal static UnityEngine.RemoteConfigSettingsHelper.Tag GetSafeArrayType(System.IntPtr a, long i)
- internal static bool GetSafeBool(System.IntPtr m, string key, bool defaultValue)
- internal static float GetSafeFloat(System.IntPtr m, string key, float defaultValue)
- internal static System.IntPtr GetSafeMap(System.IntPtr m, string key)
- internal static string[] GetSafeMapKeys(System.IntPtr m)
- internal static UnityEngine.RemoteConfigSettingsHelper.Tag[] GetSafeMapTypes(System.IntPtr m)
- internal static long GetSafeNumber(System.IntPtr m, string key, long defaultValue)
- internal static long GetSafeNumberArray(System.IntPtr a, long i)
- internal static string GetSafeStringValue(System.IntPtr m, string key, string defaultValue)
- internal static void SetDictKeyType(System.IntPtr m, System.Collections.Generic.IDictionary<string, object> dict, string key, UnityEngine.RemoteConfigSettingsHelper.Tag tag)

### public static class UnityEngine.RemoteSettings

#### Fields
- private static System.Action BeforeFetchFromServer
- private static System.Action<bool, bool, int> Completed
- private static UnityEngine.RemoteSettings.UpdatedEventHandler Updated

#### Events
- public static event System.Action BeforeFetchFromServer
- public static event System.Action<bool, bool, int> Completed
- public static event UnityEngine.RemoteSettings.UpdatedEventHandler Updated

#### Methods
- public static void CallOnUpdate()
- public static void ForceUpdate()
- internal static object GetAsScriptingObject(System.Type t, object defaultValue, string key)
- public static bool GetBool(string key)
- public static bool GetBool(string key, bool defaultValue)
- public static int GetCount()
- public static System.Collections.Generic.IDictionary<string, object> GetDictionary(string key = "")
- public static float GetFloat(string key)
- public static float GetFloat(string key, float defaultValue)
- public static int GetInt(string key)
- public static int GetInt(string key, int defaultValue)
- public static string[] GetKeys()
- public static long GetLong(string key)
- public static long GetLong(string key, long defaultValue)
- public static T GetObject<T>(string key = "")
- public static object GetObject(System.Type type, string key = "")
- public static object GetObject(string key, object defaultValue)
- internal static System.IntPtr GetSafeTopMap()
- public static string GetString(string key)
- public static string GetString(string key, string defaultValue)
- public static bool HasKey(string key)
- internal static void ReleaseSafeLock()
- internal static void RemoteSettingsBeforeFetchFromServer()
- internal static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response)
- internal static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer)
- internal static void UseSafeLock()
- public static bool WasLastUpdatedFromServer()

### internal enum UnityEngine.RemoteConfigSettingsHelper.Tag
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- kArrayVal = 7
- kBoolVal = 5
- kDoubleVal = 4
- kInt64Val = 2
- kIntVal = 1
- kMapVal = 9
- kMaxTags = 10
- kMixedArrayVal = 8
- kStringVal = 6
- kUInt64Val = 3
- kUnknown = 0

### public delegate UnityEngine.RemoteSettings.UpdatedEventHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public RemoteSettings.UpdatedEventHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke()

## Namespace: UnityEngine.Analytics

### public static class UnityEngine.Analytics.Analytics

#### Properties
- public static string configUrl { get; }
- private static string configUrlInternal { get; }
- public static string dashboardUrl { get; }
- private static string dashboardUrlInternal { get; }
- public static bool deviceStatsEnabled { get; set; }
- private static bool deviceStatsEnabledInternal { get; set; }
- public static bool enabled { get; set; }
- private static bool enabledInternal { get; set; }
- public static string eventUrl { get; }
- private static string eventUrlInternal { get; }
- public static bool initializeOnStartup { get; set; }
- private static bool initializeOnStartupInternal { get; set; }
- public static bool limitUserTracking { get; set; }
- private static bool limitUserTrackingInternal { get; set; }
- public static bool playerOptedOut { get; }
- private static bool playerOptedOutInternal { get; }

#### Methods
- public static UnityEngine.Analytics.AnalyticsResult CustomEvent(string customEventName)
- public static UnityEngine.Analytics.AnalyticsResult CustomEvent(string customEventName, UnityEngine.Vector3 position)
- public static UnityEngine.Analytics.AnalyticsResult CustomEvent(string customEventName, System.Collections.Generic.IDictionary<string, object> eventData)
- public static UnityEngine.Analytics.AnalyticsResult EnableCustomEvent(string customEventName, bool enabled)
- internal static UnityEngine.Analytics.AnalyticsResult EnableCustomEventWithLimit(string customEventName, bool enable)
- public static UnityEngine.Analytics.AnalyticsResult EnableEvent(string eventName, bool enabled, int ver = 1, string prefix = "")
- internal static UnityEngine.Analytics.AnalyticsResult EnableEventWithLimit(string eventName, bool enable, int ver, string prefix)
- private static bool FlushArchivedEvents()
- public static UnityEngine.Analytics.AnalyticsResult FlushEvents()
- public static UnityEngine.Analytics.AnalyticsResult IsCustomEventEnabled(string customEventName)
- internal static UnityEngine.Analytics.AnalyticsResult IsCustomEventWithLimitEnabled(string customEventName)
- public static UnityEngine.Analytics.AnalyticsResult IsEventEnabled(string eventName, int ver = 1, string prefix = "")
- internal static UnityEngine.Analytics.AnalyticsResult IsEventWithLimitEnabled(string eventName, int ver, string prefix)
- internal static bool IsInitialized()
- internal static bool QueueEvent(string eventName, object parameters, int ver, string prefix)
- public static UnityEngine.Analytics.AnalyticsResult RegisterEvent(string eventName, int maxEventPerHour, int maxItems, string vendorKey = "", string prefix = "")
- public static UnityEngine.Analytics.AnalyticsResult RegisterEvent(string eventName, int maxEventPerHour, int maxItems, string vendorKey, int ver, string prefix = "")
- private static UnityEngine.Analytics.AnalyticsResult RegisterEvent(string eventName, int maxEventPerHour, int maxItems, string vendorKey, int ver, string prefix, string assemblyInfo)
- internal static UnityEngine.Analytics.AnalyticsResult RegisterEventsWithLimit(string[] eventName, int maxEventPerHour, int maxItems, string vendorKey, int ver, string prefix, string assemblyInfo, bool notifyServer)
- internal static UnityEngine.Analytics.AnalyticsResult RegisterEventWithLimit(string eventName, int maxEventPerHour, int maxItems, string vendorKey, int ver, string prefix, string assemblyInfo, bool notifyServer)
- public static UnityEngine.Analytics.AnalyticsResult ResumeInitialization()
- private static UnityEngine.Analytics.AnalyticsResult ResumeInitializationInternal()
- private static UnityEngine.Analytics.AnalyticsResult SendCustomEvent(UnityEngine.Analytics.CustomEventData eventData)
- private static UnityEngine.Analytics.AnalyticsResult SendCustomEventName(string customEventName)
- public static UnityEngine.Analytics.AnalyticsResult SendEvent(string eventName, object parameters, int ver = 1, string prefix = "")
- internal static UnityEngine.Analytics.AnalyticsResult SendEventWithLimit(string eventName, object parameters, int ver, string prefix)
- private static UnityEngine.Analytics.AnalyticsResult SendUserInfoEvent(object param)
- public static UnityEngine.Analytics.AnalyticsResult SetEventEndPoint(string eventName, string endPoint, int ver = 1, string prefix = "")
- public static UnityEngine.Analytics.AnalyticsResult SetEventPriority(string eventName, UnityEngine.Analytics.AnalyticsEventPriority eventPriority, int ver = 1, string prefix = "")
- internal static UnityEngine.Analytics.AnalyticsResult SetEventWithLimitEndPoint(string eventName, string endPoint, int ver, string prefix)
- internal static UnityEngine.Analytics.AnalyticsResult SetEventWithLimitPriority(string eventName, UnityEngine.Analytics.AnalyticsEventPriority eventPriority, int ver, string prefix)
- public static UnityEngine.Analytics.AnalyticsResult SetUserBirthYear(int birthYear)
- public static UnityEngine.Analytics.AnalyticsResult SetUserGender(UnityEngine.Analytics.Gender gender)
- public static UnityEngine.Analytics.AnalyticsResult SetUserId(string userId)
- private static UnityEngine.Analytics.AnalyticsResult Transaction(string productId, double amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService)
- public static UnityEngine.Analytics.AnalyticsResult Transaction(string productId, decimal amount, string currency)
- public static UnityEngine.Analytics.AnalyticsResult Transaction(string productId, decimal amount, string currency, string receiptPurchaseData, string signature)
- public static UnityEngine.Analytics.AnalyticsResult Transaction(string productId, decimal amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService)

### public enum UnityEngine.Analytics.AnalyticsEventPriority
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AllowInStopModeFlag = 4
- CacheImmediatelyFlag = 2
- FlushQueueFlag = 1
- HighestPriorityEvent = 9
- HighestPriorityEvent_NoRetryNoCaching = 49
- HighPriorityEvent = 1
- HighPriorityEvent_InStopMode = 5
- NoCachingFlag = 16
- NoRetryFlag = 32
- NormalPriorityEvent = 0
- NormalPriorityEvent_NoRetryNoCaching = 48
- NormalPriorityEvent_WithCaching = 2
- SendImmediateFlag = 8

### public enum UnityEngine.Analytics.AnalyticsResult
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AnalyticsDisabled = 2
- InvalidData = 6
- NotInitialized = 1
- Ok = 0
- SizeLimitReached = 4
- TooManyItems = 3
- TooManyRequests = 5
- UnsupportedPlatform = 7

### public static class UnityEngine.Analytics.AnalyticsSessionInfo

#### Fields
- private static UnityEngine.Analytics.AnalyticsSessionInfo.IdentityTokenChanged identityTokenChanged
- private static UnityEngine.Analytics.AnalyticsSessionInfo.SessionStateChanged sessionStateChanged

#### Properties
- public static string customDeviceId { get; set; }
- private static string customDeviceIdInternal { get; set; }
- public static string customUserId { get; set; }
- private static string customUserIdInternal { get; set; }
- public static string identityToken { get; }
- private static string identityTokenInternal { get; }
- public static long sessionCount { get; }
- public static long sessionElapsedTime { get; }
- public static bool sessionFirstRun { get; }
- public static long sessionId { get; }
- public static UnityEngine.Analytics.AnalyticsSessionState sessionState { get; }
- public static string userId { get; }

#### Events
- public static event UnityEngine.Analytics.AnalyticsSessionInfo.IdentityTokenChanged identityTokenChanged
- public static event UnityEngine.Analytics.AnalyticsSessionInfo.SessionStateChanged sessionStateChanged

#### Methods
- internal static void CallIdentityTokenChanged(string token)
- internal static void CallSessionStateChanged(UnityEngine.Analytics.AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged)

### public enum UnityEngine.Analytics.AnalyticsSessionState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- kSessionPaused = 2
- kSessionResumed = 3
- kSessionStarted = 1
- kSessionStopped = 0

### public class UnityEngine.Analytics.ContinuousEvent

#### Constructors
- public ContinuousEvent()

#### Methods
- public static UnityEngine.Analytics.AnalyticsResult ConfigureCustomEvent(string customEventName, string metricName, float interval, float period, bool enabled = true)
- public static UnityEngine.Analytics.AnalyticsResult ConfigureEvent(string eventName, string metricName, float interval, float period, bool enabled = true, int ver = 1, string prefix = "")
- private static UnityEngine.Analytics.AnalyticsResult InternalConfigureCustomEvent(string customEventName, string metricName, float interval, float period, bool enabled)
- private static UnityEngine.Analytics.AnalyticsResult InternalConfigureEvent(string eventName, string metricName, float interval, float period, bool enabled, int ver, string prefix)
- private static UnityEngine.Analytics.AnalyticsResult InternalRegisterCollector(string type, string metricName, object collector)
- private static UnityEngine.Analytics.AnalyticsResult InternalSetCustomEventHistogramThresholds(string type, string eventName, int count, object data)
- private static UnityEngine.Analytics.AnalyticsResult InternalSetEventHistogramThresholds(string type, string eventName, int count, object data, int ver, string prefix)
- internal static bool IsInitialized()
- public static UnityEngine.Analytics.AnalyticsResult RegisterCollector<T>(string metricName, System.Func<T> del)
- public static UnityEngine.Analytics.AnalyticsResult SetCustomEventHistogramThresholds<T>(string eventName, int count, T[] data)
- public static UnityEngine.Analytics.AnalyticsResult SetEventHistogramThresholds<T>(string eventName, int count, T[] data, int ver = 1, string prefix = "")

### internal class UnityEngine.Analytics.CustomEventData
- Interfaces: System.IDisposable

#### Fields
- internal System.IntPtr m_Ptr

#### Constructors
- private CustomEventData()
- public CustomEventData(string name)

#### Methods
- public bool AddBool(string key, bool value)
- public bool AddDictionary(System.Collections.Generic.IDictionary<string, object> eventData)
- public bool AddDouble(string key, double value)
- public bool AddInt32(string key, int value)
- public bool AddInt64(string key, long value)
- public bool AddString(string key, string value)
- public bool AddUInt32(string key, uint value)
- public bool AddUInt64(string key, ulong value)
- private void Destroy()
- public void Dispose()
- protected override void Finalize()
- internal static System.IntPtr Internal_Create(UnityEngine.Analytics.CustomEventData ced, string name)
- internal static void Internal_Destroy(System.IntPtr ptr)

### public enum UnityEngine.Analytics.Gender
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Female = 1
- Male = 0
- Unknown = 2

### public delegate UnityEngine.Analytics.AnalyticsSessionInfo.IdentityTokenChanged
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public AnalyticsSessionInfo.IdentityTokenChanged(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(string token, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(string token)

### public delegate UnityEngine.Analytics.AnalyticsSessionInfo.SessionStateChanged
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public AnalyticsSessionInfo.SessionStateChanged(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(UnityEngine.Analytics.AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(UnityEngine.Analytics.AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged)

