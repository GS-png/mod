# Assembly: Unity.LevelPlay
- Path: tools/WorldBox.Managed/Unity.LevelPlay.dll
- Types: 148

## Namespace: (global)

### private class IronSourceSegment.<>c

#### Fields
- public static readonly IronSourceSegment.<>c <>9
- public static System.Func<System.Collections.Generic.KeyValuePair<string, string>, string> <>9__10_0
- public static System.Func<System.Linq.IGrouping<string, System.Collections.Generic.KeyValuePair<string, string>>, string> <>9__10_1
- public static System.Func<System.Linq.IGrouping<string, System.Collections.Generic.KeyValuePair<string, string>>, string> <>9__10_2

#### Constructors
- private static IronSourceSegment.<>c()
- public IronSourceSegment.<>c()

#### Methods
- internal string <getSegmentAsDict>b__10_0(System.Collections.Generic.KeyValuePair<string, string> d)
- internal string <getSegmentAsDict>b__10_1(System.Linq.IGrouping<string, System.Collections.Generic.KeyValuePair<string, string>> d)
- internal string <getSegmentAsDict>b__10_2(System.Linq.IGrouping<string, System.Collections.Generic.KeyValuePair<string, string>> d)

### private class IronSourceSegmentAndroid.<>c

#### Fields
- public static readonly IronSourceSegmentAndroid.<>c <>9
- public static System.Action<string> <>9__3_0

#### Constructors
- private static IronSourceSegmentAndroid.<>c()
- public IronSourceSegmentAndroid.<>c()

#### Methods
- internal void <.ctor>b__3_0(string <p0>)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4366 190B26802A9F9BA1A94D8E6F86005E9C6CF9303AAEC5CA1DCB3636CAB9D8701F
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4871 652EFED3C1E5EDE723EC2FC04760596DAA75E056DB2DB5566BCA4C95DD788FEB

### public enum AdFormat
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Banner = 2
- Interstitial = 1
- RewardedVideo = 0

### public static class dataSource

#### Properties
- public static string MOPUB { get; }

### public class IronSource
- Interfaces: IronSourceIAgent

#### Fields
- private static bool isUnsupportedPlatform
- public static string UNITY_PLUGIN_VERSION
- private static IronSource _instance
- private IronSourceIAgent _platformAgent

#### Properties
- public static IronSource Agent { get; }

#### Constructors
- private IronSource()
- private static IronSource()

#### Methods
- public void clearRewardedVideoServerParams()
- public void destroyBanner()
- public void displayBanner()
- public string getAdvertiserId()
- public System.Nullable<int> getConversionValue()
- public float getDeviceScreenWidth()
- public float getMaximalAdaptiveHeight(float width)
- public IronSourcePlacement getPlacementInfo(string placementName)
- public void hideBanner()
- public void init(string appKey)
- public void init(string appKey, params string[] adUnits)
- public bool isBannerPlacementCapped(string placementName)
- public bool isInterstitialPlacementCapped(string placementName)
- public bool isInterstitialReady()
- public bool isRewardedVideoAvailable()
- public bool isRewardedVideoPlacementCapped(string placementName)
- public void launchTestSuite()
- public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position)
- public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName)
- public void loadConsentViewWithType(string consentViewType)
- public void loadInterstitial()
- public void loadRewardedVideo()
- public void onApplicationPause(bool pause)
- public static string pluginVersion()
- public void setAdaptersDebug(bool enabled)
- public void setAdRevenueData(string dataSource, System.Collections.Generic.Dictionary<string, string> impressionData)
- public void setConsent(bool consent)
- public bool setDynamicUserId(string dynamicUserId)
- public void setManualLoadRewardedVideo(bool isOn)
- public void setMetaData(string key, string value)
- public void setMetaData(string key, params string[] values)
- public void setNetworkData(string networkKey, string networkData)
- public void SetPauseGame(bool pause)
- public void setRewardedVideoServerParams(System.Collections.Generic.Dictionary<string, string> parameters)
- public void setSegment(IronSourceSegment segment)
- public static void setUnsupportedPlatform()
- public void setUserId(string userId)
- public void SetWaterfallConfiguration(WaterfallConfiguration waterfallConfiguration, AdFormat adFormat)
- public void shouldTrackNetworkState(bool track)
- public void showConsentViewWithType(string consentViewType)
- public void showInterstitial()
- public void showInterstitial(string placementName)
- public void showRewardedVideo()
- public void showRewardedVideo(string placementName)
- public static string unityVersion()
- public void validateIntegration()

### public class IronSourceAdInfo

#### Fields
- public readonly string ab
- public readonly string adNetwork
- public readonly string adUnit
- public readonly string auctionId
- public readonly string country
- public readonly string creativeId
- public readonly string encryptedCPM
- public readonly string instanceId
- public readonly string instanceName
- public readonly System.Nullable<double> lifetimeRevenue
- public readonly string precision
- public readonly System.Nullable<double> revenue
- public readonly string segmentName

#### Constructors
- public IronSourceAdInfo(string json)

#### Methods
- public override string ToString()

### public static class IronSourceAdUnits

#### Properties
- public static string BANNER { get; }
- public static string INTERSTITIAL { get; }
- public static string OFFERWALL { get; }
- public static string REWARDED_VIDEO { get; }

### public class IronSourceBannerEvents
- Base: UnityEngine.MonoBehaviour

#### Fields
- private static System.Action<IronSourceAdInfo> _onAdClickedEvent
- private static System.Action<IronSourceAdInfo> _onAdLeftApplicationEvent
- private static System.Action<IronSourceAdInfo> _onAdLoadedEvent
- private static System.Action<IronSourceError> _onAdLoadFailedEvent
- private static System.Action<IronSourceAdInfo> _onAdScreenDismissedEvent
- private static System.Action<IronSourceAdInfo> _onAdScreenPresentedEvent

#### Events
- public static event System.Action<IronSourceAdInfo> onAdClickedEvent
- public static event System.Action<IronSourceAdInfo> onAdLeftApplicationEvent
- public static event System.Action<IronSourceAdInfo> onAdLoadedEvent
- public static event System.Action<IronSourceError> onAdLoadFailedEvent
- public static event System.Action<IronSourceAdInfo> onAdScreenDismissedEvent
- public static event System.Action<IronSourceAdInfo> onAdScreenPresentedEvent
- private static event System.Action<IronSourceAdInfo> _onAdClickedEvent
- private static event System.Action<IronSourceAdInfo> _onAdLeftApplicationEvent
- private static event System.Action<IronSourceAdInfo> _onAdLoadedEvent
- private static event System.Action<IronSourceError> _onAdLoadFailedEvent
- private static event System.Action<IronSourceAdInfo> _onAdScreenDismissedEvent
- private static event System.Action<IronSourceAdInfo> _onAdScreenPresentedEvent

#### Constructors
- public IronSourceBannerEvents()

#### Methods
- private void Awake()
- private IronSourceError getErrorFromErrorObject(object descriptionObject)
- private IronSourcePlacement getPlacementFromObject(object placementObject)
- public void onAdClicked(string args)
- public void onAdLeftApplication(string args)
- public void onAdLoaded(string args)
- public void onAdLoadFailed(string description)
- public void onAdScreenDismissed(string args)
- public void onAdScreenPresented(string args)

### public enum IronSourceBannerPosition
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BOTTOM = 2
- TOP = 1

### public class IronSourceBannerSize

#### Fields
- public static IronSourceBannerSize BANNER
- private string description
- private int height
- private bool isAdaptive
- private ISContainerParams isContainerParams
- public static IronSourceBannerSize LARGE
- public static IronSourceBannerSize RECTANGLE
- private bool respectAndroidCutouts
- public static IronSourceBannerSize SMART
- private int width

#### Properties
- public string Description { get; }
- public int Height { get; }
- public int Width { get; }

#### Constructors
- private IronSourceBannerSize()
- private static IronSourceBannerSize()
- public IronSourceBannerSize(string description)
- public IronSourceBannerSize(int width, int height)

#### Methods
- public ISContainerParams getBannerContainerParams()
- public bool IsAdaptiveEnabled()
- public bool IsRespectAndroidCutoutsEnabled()
- public void SetAdaptive(bool adaptive, int customWidth = -1)
- public void setBannerContainerParams(ISContainerParams parameters)
- public void SetRespectAndroidCutouts(bool respectAndroidCutouts)

### public class IronSourceConfig

#### Fields
- private static const string unsupportedPlatformStr
- private static IronSourceConfig _instance

#### Properties
- public static IronSourceConfig Instance { get; }

#### Constructors
- public IronSourceConfig()

#### Methods
- public void setClientSideCallbacks(bool status)
- public void setLanguage(string language)
- public void setRewardedVideoCustomParams(System.Collections.Generic.Dictionary<string, string> rewardedVideoCustomParams)

### public static class IronSourceConstants

#### Fields
- public static const string bridgeClass
- public static const string EMPTY_STRING
- public static const string ERROR_CODE
- public static const string ERROR_DESCRIPTION
- public static const string GENDER_FEMALE
- public static const string GENDER_MALE
- public static const string GENDER_UNKNOWN
- public static const string GET_INSTANCE_KEY
- public static const string impressionDataBridgeListenerClass
- public static const string IMPRESSION_DATA_KEY_ABTEST
- internal static const string IMPRESSION_DATA_KEY_AD_FORMAT
- public static const string IMPRESSION_DATA_KEY_AD_NETWORK
- public static const string IMPRESSION_DATA_KEY_AD_UNIT
- public static const string IMPRESSION_DATA_KEY_AUCTION_ID
- public static const string IMPRESSION_DATA_KEY_CONVERSION_VALUE
- public static const string IMPRESSION_DATA_KEY_COUNTRY
- public static const string IMPRESSION_DATA_KEY_ENCRYPTED_CPM
- public static const string IMPRESSION_DATA_KEY_INSTANCE_ID
- public static const string IMPRESSION_DATA_KEY_INSTANCE_NAME
- public static const string IMPRESSION_DATA_KEY_LIFETIME_REVENUE
- internal static const string IMPRESSION_DATA_KEY_MEDIATION_AD_UNIT_ID
- internal static const string IMPRESSION_DATA_KEY_MEDIATION_AD_UNIT_NAME
- public static const string IMPRESSION_DATA_KEY_PLACEMENT
- public static const string IMPRESSION_DATA_KEY_PRECISION
- public static const string IMPRESSION_DATA_KEY_REVENUE
- public static const string IMPRESSION_DATA_KEY_SEGMENT_NAME
- public static const string initializeBridgeListenerClass
- public static const string IRONSOURCE_MEDIATED_NETWORK_SETTING_NAME
- public static const string IRONSOURCE_MEDIATION_SETTING_NAME
- public static const string IRONSOURCE_RESOURCES_PATH
- public static const string IRONSOURCE_SKAN_ID_KEY
- internal static const string k_ImpressionDataKeyCreativeID
- public static const string LevelPlaybannerBridgeListenerClass
- public static const string LevelPlayinterstitialBridgeListenerClass
- public static const string LevelPlayRewardedVideoBridgeListenerClass
- public static const string LevelPlayRewardedVideoManualBridgeListenerClass
- public static const string segmentBridgeListenerClass

### public class IronSourceError

#### Fields
- private int code
- private string description

#### Constructors
- public IronSourceError(int errorCode, string errorDescription)

#### Methods
- public int getCode()
- public string getDescription()
- public int getErrorCode()
- public override string ToString()

### public class IronSourceEvents
- Base: UnityEngine.MonoBehaviour

#### Fields
- private static const string ERROR_CODE
- private static const string ERROR_DESCRIPTION
- private static System.Action<IronSourceImpressionData> onImpressionDataReadyEvent
- private static System.Action<string> _onConsentViewDidAcceptEvent
- private static System.Action<string> _onConsentViewDidDismissEvent
- private static System.Action<string, IronSourceError> _onConsentViewDidFailToLoadWithErrorEvent
- private static System.Action<string, IronSourceError> _onConsentViewDidFailToShowWithErrorEvent
- private static System.Action<string> _onConsentViewDidLoadSuccessEvent
- private static System.Action<string> _onConsentViewDidShowSuccessEvent
- private static System.Action _onSdkInitializationCompletedEvent
- private static System.Action<string> _onSegmentReceivedEvent

#### Events
- public static event System.Action<string> onConsentViewDidAcceptEvent
- public static event System.Action<string> onConsentViewDidDismissEvent
- public static event System.Action<string, IronSourceError> onConsentViewDidFailToLoadWithErrorEvent
- public static event System.Action<string, IronSourceError> onConsentViewDidFailToShowWithErrorEvent
- public static event System.Action<string> onConsentViewDidLoadSuccessEvent
- public static event System.Action<string> onConsentViewDidShowSuccessEvent
- public static event System.Action<IronSourceImpressionData> onImpressionDataReadyEvent
- public static event System.Action onSdkInitializationCompletedEvent
- public static event System.Action<string> onSegmentReceivedEvent
- private static event System.Action<string> _onConsentViewDidAcceptEvent
- private static event System.Action<string> _onConsentViewDidDismissEvent
- private static event System.Action<string, IronSourceError> _onConsentViewDidFailToLoadWithErrorEvent
- private static event System.Action<string, IronSourceError> _onConsentViewDidFailToShowWithErrorEvent
- private static event System.Action<string> _onConsentViewDidLoadSuccessEvent
- private static event System.Action<string> _onConsentViewDidShowSuccessEvent
- private static event System.Action _onSdkInitializationCompletedEvent
- private static event System.Action<string> _onSegmentReceivedEvent

#### Constructors
- public IronSourceEvents()

#### Methods
- private void Awake()
- private IronSourceError getErrorFromErrorObject(object descriptionObject)
- private IronSourcePlacement getPlacementFromObject(object placementObject)
- private static void InvokeEvent(System.Action<IronSourceImpressionData> evt, string args)
- public void onConsentViewDidAccept(string consentViewType)
- public void onConsentViewDidDismiss(string consentViewType)
- public void onConsentViewDidFailToLoadWithError(string args)
- public void onConsentViewDidFailToShowWithError(string args)
- public void onConsentViewDidLoadSuccess(string consentViewType)
- public void onConsentViewDidShowSuccess(string consentViewType)
- public void onSdkInitializationCompleted(string empty)
- public void onSegmentReceived(string segmentName)

### public class IronSourceEventsDispatcher
- Base: UnityEngine.MonoBehaviour

#### Fields
- private static IronSourceEventsDispatcher instance
- private static readonly System.Collections.Generic.Queue<System.Action> ironSourceExecuteOnMainThreadQueue

#### Constructors
- public IronSourceEventsDispatcher()
- private static IronSourceEventsDispatcher()

#### Methods
- public void Awake()
- public static void executeAction(System.Action action)
- public static void initialize()
- public static bool isCreated()
- public void OnDisable()
- public void removeFromParent()
- private void Update()

### public interface IronSourceIAgent

#### Methods
- public void clearRewardedVideoServerParams()
- public void destroyBanner()
- public void displayBanner()
- public string getAdvertiserId()
- public System.Nullable<int> getConversionValue()
- public float getDeviceScreenWidth()
- public float getMaximalAdaptiveHeight(float width)
- public IronSourcePlacement getPlacementInfo(string name)
- public void hideBanner()
- public void init(string appKey)
- public void init(string appKey, params string[] adUnits)
- public bool isBannerPlacementCapped(string placementName)
- public bool isInterstitialPlacementCapped(string placementName)
- public bool isInterstitialReady()
- public bool isRewardedVideoAvailable()
- public bool isRewardedVideoPlacementCapped(string placementName)
- public void launchTestSuite()
- public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position)
- public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName)
- public void loadConsentViewWithType(string consentViewType)
- public void loadInterstitial()
- public void loadRewardedVideo()
- public void onApplicationPause(bool pause)
- public void setAdaptersDebug(bool enabled)
- public void setAdRevenueData(string dataSource, System.Collections.Generic.Dictionary<string, string> impressionData)
- public void setConsent(bool consent)
- public bool setDynamicUserId(string dynamicUserId)
- public void setManualLoadRewardedVideo(bool isOn)
- public void setMetaData(string key, string value)
- public void setMetaData(string key, params string[] values)
- public void setNetworkData(string networkKey, string networkData)
- public void SetPauseGame(bool pause)
- public void setRewardedVideoServerParams(System.Collections.Generic.Dictionary<string, string> parameters)
- public void setSegment(IronSourceSegment segment)
- public void setUserId(string userId)
- public void SetWaterfallConfiguration(WaterfallConfiguration waterfallConfiguration, AdFormat adFormat)
- public void shouldTrackNetworkState(bool track)
- public void showConsentViewWithType(string consentViewType)
- public void showInterstitial()
- public void showInterstitial(string placementName)
- public void showRewardedVideo()
- public void showRewardedVideo(string placementName)
- public void validateIntegration()

### public class IronSourceImpressionData

#### Fields
- public readonly string ab
- public readonly string adFormat
- public readonly string adNetwork
- public readonly string adUnit
- public readonly string allData
- public readonly string auctionId
- public readonly System.Nullable<int> conversionValue
- public readonly string country
- public readonly string CreativeId
- public readonly string encryptedCPM
- public readonly string instanceId
- public readonly string instanceName
- public readonly System.Nullable<double> lifetimeRevenue
- public readonly string mediationAdUnitId
- public readonly string mediationAdUnitName
- public readonly string placement
- public readonly string precision
- public readonly System.Nullable<double> revenue
- public readonly string segmentName

#### Constructors
- public IronSourceImpressionData(string json)

#### Methods
- public override string ToString()

### public class IronSourceInitilizer

#### Constructors
- public IronSourceInitilizer()

### public class IronSourceInterstitialEvents
- Base: UnityEngine.MonoBehaviour

#### Fields
- private static System.Action<IronSourceAdInfo> _onAdClickedEvent
- private static System.Action<IronSourceAdInfo> _onAdClosedEvent
- private static System.Action<IronSourceError> _onAdLoadFailedEvent
- private static System.Action<IronSourceAdInfo> _onAdOpenedEvent
- private static System.Action<IronSourceAdInfo> _onAdReadyEvent
- private static System.Action<IronSourceError, IronSourceAdInfo> _onAdShowFailedEvent
- private static System.Action<IronSourceAdInfo> _onAdShowSucceededEvent

#### Events
- public static event System.Action<IronSourceAdInfo> onAdClickedEvent
- public static event System.Action<IronSourceAdInfo> onAdClosedEvent
- public static event System.Action<IronSourceError> onAdLoadFailedEvent
- public static event System.Action<IronSourceAdInfo> onAdOpenedEvent
- public static event System.Action<IronSourceAdInfo> onAdReadyEvent
- public static event System.Action<IronSourceError, IronSourceAdInfo> onAdShowFailedEvent
- public static event System.Action<IronSourceAdInfo> onAdShowSucceededEvent
- private static event System.Action<IronSourceAdInfo> _onAdClickedEvent
- private static event System.Action<IronSourceAdInfo> _onAdClosedEvent
- private static event System.Action<IronSourceError> _onAdLoadFailedEvent
- private static event System.Action<IronSourceAdInfo> _onAdOpenedEvent
- private static event System.Action<IronSourceAdInfo> _onAdReadyEvent
- private static event System.Action<IronSourceError, IronSourceAdInfo> _onAdShowFailedEvent
- private static event System.Action<IronSourceAdInfo> _onAdShowSucceededEvent

#### Constructors
- public IronSourceInterstitialEvents()

#### Methods
- private void Awake()
- private IronSourceError getErrorFromErrorObject(object descriptionObject)
- private IronSourcePlacement getPlacementFromObject(object placementObject)
- public void onAdClicked(string args)
- public void onAdClosed(string args)
- public void onAdLoadFailed(string description)
- public void onAdOpened(string args)
- public void onAdReady(string args)
- public void onAdShowFailed(string args)
- public void onAdShowSucceeded(string args)

### public class IronSourceMediationSettings
- Base: UnityEngine.ScriptableObject

#### Fields
- public bool AddIronsourceSkadnetworkID
- public string AndroidAppKey
- public bool DeclareAD_IDPermission
- public bool EnableAdapterDebug
- public bool EnableIntegrationHelper
- public bool EnableIronsourceSDKInitAPI
- public string IOSAppKey
- public static readonly string IRONSOURCE_SETTINGS_ASSET_PATH

#### Constructors
- public IronSourceMediationSettings()
- private static IronSourceMediationSettings()

### public class IronSourcePlacement

#### Fields
- private string placementName
- private int rewardAmount
- private string rewardName

#### Constructors
- public IronSourcePlacement(string placementName, string rewardName, int rewardAmount)

#### Methods
- public string getPlacementName()
- public int getRewardAmount()
- public string getRewardName()
- public override string ToString()

### public class IronSourceRewardedVideoEvents
- Base: UnityEngine.MonoBehaviour

#### Fields
- private static System.Action<IronSourceAdInfo> _onAdAvailableEvent
- private static System.Action<IronSourcePlacement, IronSourceAdInfo> _onAdClickedEvent
- private static System.Action<IronSourceAdInfo> _onAdClosedEvent
- private static System.Action<IronSourceError> _onAdLoadFailedEvent
- private static System.Action<IronSourceAdInfo> _onAdOpenedEvent
- private static System.Action<IronSourceAdInfo> _onAdReadyEvent
- private static System.Action<IronSourcePlacement, IronSourceAdInfo> _onAdRewardedEvent
- private static System.Action<IronSourceError, IronSourceAdInfo> _onAdShowFailedEvent
- private static System.Action _onAdUnavailableEvent

#### Events
- public static event System.Action<IronSourceAdInfo> onAdAvailableEvent
- public static event System.Action<IronSourcePlacement, IronSourceAdInfo> onAdClickedEvent
- public static event System.Action<IronSourceAdInfo> onAdClosedEvent
- public static event System.Action<IronSourceError> onAdLoadFailedEvent
- public static event System.Action<IronSourceAdInfo> onAdOpenedEvent
- public static event System.Action<IronSourceAdInfo> onAdReadyEvent
- public static event System.Action<IronSourcePlacement, IronSourceAdInfo> onAdRewardedEvent
- public static event System.Action<IronSourceError, IronSourceAdInfo> onAdShowFailedEvent
- public static event System.Action onAdUnavailableEvent
- private static event System.Action<IronSourceAdInfo> _onAdAvailableEvent
- private static event System.Action<IronSourcePlacement, IronSourceAdInfo> _onAdClickedEvent
- private static event System.Action<IronSourceAdInfo> _onAdClosedEvent
- private static event System.Action<IronSourceError> _onAdLoadFailedEvent
- private static event System.Action<IronSourceAdInfo> _onAdOpenedEvent
- private static event System.Action<IronSourceAdInfo> _onAdReadyEvent
- private static event System.Action<IronSourcePlacement, IronSourceAdInfo> _onAdRewardedEvent
- private static event System.Action<IronSourceError, IronSourceAdInfo> _onAdShowFailedEvent
- private static event System.Action _onAdUnavailableEvent

#### Constructors
- public IronSourceRewardedVideoEvents()

#### Methods
- private void Awake()
- private IronSourceError getErrorFromErrorObject(object descriptionObject)
- private IronSourcePlacement getPlacementFromObject(object placementObject)
- public void onAdAvailable(string args)
- public void onAdClicked(string args)
- public void onAdClosed(string args)
- public void onAdLoadFailed(string description)
- public void onAdOpened(string args)
- public void onAdReady(string adinfo)
- public void onAdRewarded(string args)
- public void onAdShowFailed(string args)
- public void onAdUnavailable()

### public class IronSourceSegment

#### Fields
- public int age
- public System.Collections.Generic.Dictionary<string, string> customs
- public string gender
- public double iapt
- public int isPaying
- public int level
- public string segmentName
- public long userCreationDate

#### Constructors
- public IronSourceSegment()

#### Methods
- public System.Collections.Generic.Dictionary<string, string> getSegmentAsDict()
- public void setCustom(string key, string value)

### public class IronSourceSegmentAndroid
- Base: UnityEngine.AndroidJavaProxy
- Interfaces: IUnitySegment

#### Fields
- private System.Action<string> OnSegmentRecieved

#### Events
- public event System.Action<string> OnSegmentRecieved

#### Constructors
- public IronSourceSegmentAndroid()

#### Methods
- public void onSegmentRecieved(string segmentName)

### public class IronSourceUtils

#### Fields
- private static const string ERROR_CODE
- private static const string ERROR_DESCRIPTION
- private static const string INSTANCE_ID_KEY
- private static const string PLACEMENT_KEY

#### Constructors
- public IronSourceUtils()

#### Methods
- public static IronSourceError getErrorFromErrorObject(object descriptionObject)
- public static IronSourcePlacement getPlacementFromObject(object placementObject)

### public class ISContainerParams

#### Fields
- private float <Height>k__BackingField
- private float <Width>k__BackingField

#### Properties
- public float Height { get; set; }
- public float Width { get; set; }

#### Constructors
- public ISContainerParams()

### public interface IUnityImpressionData

#### Events
- public event System.Action<IronSourceImpressionData> OnImpressionDataReady
- public event System.Action<IronSourceImpressionData> OnImpressionSuccess

### public interface IUnityInitialization

#### Events
- public event System.Action OnSdkInitializationCompletedEvent

### public interface IUnityLevelPlayBanner

#### Events
- public event System.Action<IronSourceAdInfo> OnAdClicked
- public event System.Action<IronSourceAdInfo> OnAdLeftApplication
- public event System.Action<IronSourceAdInfo> OnAdLoaded
- public event System.Action<IronSourceError> OnAdLoadFailed
- public event System.Action<IronSourceAdInfo> OnAdScreenDismissed
- public event System.Action<IronSourceAdInfo> OnAdScreenPresented

### public interface IUnityLevelPlayInterstitial

#### Events
- public event System.Action<IronSourceAdInfo> OnAdClicked
- public event System.Action<IronSourceAdInfo> OnAdClosed
- public event System.Action<IronSourceError> OnAdLoadFailed
- public event System.Action<IronSourceAdInfo> OnAdOpened
- public event System.Action<IronSourceAdInfo> OnAdReady
- public event System.Action<IronSourceError, IronSourceAdInfo> OnAdShowFailed
- public event System.Action<IronSourceAdInfo> OnAdShowSucceeded

### public interface IUnityLevelPlayRewardedVideo

#### Events
- public event System.Action<IronSourceAdInfo> OnAdAvailable
- public event System.Action<IronSourcePlacement, IronSourceAdInfo> OnAdClicked
- public event System.Action<IronSourceAdInfo> OnAdClosed
- public event System.Action<IronSourceAdInfo> OnAdOpened
- public event System.Action<IronSourcePlacement, IronSourceAdInfo> OnAdRewarded
- public event System.Action<IronSourceError, IronSourceAdInfo> OnAdShowFailed
- public event System.Action OnAdUnavailable

### public interface IUnityLevelPlayRewardedVideoManual

#### Events
- public event System.Action<IronSourceError> OnAdLoadFailed
- public event System.Action<IronSourceAdInfo> OnAdReady

### public interface IUnitySegment

#### Events
- public event System.Action<string> OnSegmentRecieved

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

### public class UnsupportedPlatformAgent
- Interfaces: IronSourceIAgent

#### Constructors
- public UnsupportedPlatformAgent()

#### Methods
- public void clearRewardedVideoServerParams()
- public void destroyBanner()
- public void displayBanner()
- public string getAdvertiserId()
- public System.Nullable<int> getConversionValue()
- public float getDeviceScreenWidth()
- public float getMaximalAdaptiveHeight(float width)
- public IronSourcePlacement getPlacementInfo(string placementName)
- public void hideBanner()
- public void init(string appKey)
- public void init(string appKey, params string[] adUnits)
- public bool isBannerPlacementCapped(string placementName)
- public bool isInterstitialPlacementCapped(string placementName)
- public bool isInterstitialReady()
- public bool isRewardedVideoAvailable()
- public bool isRewardedVideoPlacementCapped(string placementName)
- public void launchTestSuite()
- public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position)
- public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName)
- public void loadConsentViewWithType(string consentViewType)
- public void loadInterstitial()
- public void loadRewardedVideo()
- public void onApplicationPause(bool pause)
- public void setAdaptersDebug(bool enabled)
- public void setAdRevenueData(string dataSource, System.Collections.Generic.Dictionary<string, string> impressionData)
- public void setBannerContainerParams(ISContainerParams parameters)
- public void setConsent(bool consent)
- public bool setDynamicUserId(string dynamicUserId)
- public void setManualLoadRewardedVideo(bool isOn)
- public void setMetaData(string key, string value)
- public void setMetaData(string key, params string[] values)
- public void setNetworkData(string networkKey, string networkDataJson)
- public void SetPauseGame(bool pause)
- public void setRewardedVideoServerParams(System.Collections.Generic.Dictionary<string, string> parameters)
- public void setSegment(IronSourceSegment segment)
- public void setUserId(string userId)
- public void SetWaterfallConfiguration(WaterfallConfiguration waterfallConfiguration, AdFormat adFormat)
- public void shouldTrackNetworkState(bool track)
- public void showConsentViewWithType(string consentViewType)
- public void showInterstitial()
- public void showInterstitial(string placementName)
- public void showRewardedVideo()
- public void showRewardedVideo(string placementName)
- public void start()
- public void validateIntegration()

### public class WaterfallConfiguration

#### Fields
- private readonly System.Nullable<double> ceiling
- private readonly System.Nullable<double> floor

#### Properties
- public System.Nullable<double> Ceiling { get; }
- public System.Nullable<double> Floor { get; }

#### Constructors
- private WaterfallConfiguration(System.Nullable<double> ceiling, System.Nullable<double> floor)

#### Methods
- public static WaterfallConfiguration.WaterfallConfigurationBuilder Builder()
- public static WaterfallConfiguration Empty()

### public class WaterfallConfiguration.WaterfallConfigurationBuilder

#### Fields
- private System.Nullable<double> ceiling
- private System.Nullable<double> floor

#### Constructors
- internal WaterfallConfiguration.WaterfallConfigurationBuilder()

#### Methods
- public WaterfallConfiguration Build()
- public WaterfallConfiguration.WaterfallConfigurationBuilder SetCeiling(double ceiling)
- public WaterfallConfiguration.WaterfallConfigurationBuilder SetFloor(double floor)

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4366

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4871

## Namespace: com.unity3d.mediation

### public interface com.unity3d.mediation.ILevelPlayBannerAd
- Interfaces: Unity.Services.LevelPlay.ILevelPlayBannerAd, System.IDisposable

### public interface com.unity3d.mediation.ILevelPlayInterstitialAd
- Interfaces: Unity.Services.LevelPlay.ILevelPlayInterstitialAd, System.IDisposable

### public interface com.unity3d.mediation.ILevelPlayRewardedAd
- Interfaces: Unity.Services.LevelPlay.ILevelPlayRewardedAd, System.IDisposable

### public class com.unity3d.mediation.IosNativeObject
- Interfaces: System.IDisposable

#### Fields
- private System.IntPtr m_NativePtr
- private readonly bool m_UsesCallbacks
- private static System.Collections.Concurrent.ConcurrentDictionary<System.IntPtr, com.unity3d.mediation.IosNativeObject> s_Objects

#### Properties
- public System.IntPtr NativePtr { get; protected set; }

#### Constructors
- private static IosNativeObject()
- protected IosNativeObject(bool usesCallbacks)

#### Methods
- protected bool CheckDisposedAndLogError(string message)
- public virtual void Dispose()
- protected static T Get<T>(System.IntPtr ptr)

### public class com.unity3d.mediation.LevelPlay
- Base: Unity.Services.LevelPlay.LevelPlay

#### Constructors
- public LevelPlay()

### public class com.unity3d.mediation.LevelPlayAdDisplayInfoError
- Base: Unity.Services.LevelPlay.LevelPlayAdDisplayInfoError

#### Constructors
- public LevelPlayAdDisplayInfoError(Unity.Services.LevelPlay.LevelPlayAdInfo levelPlayAdInfo, Unity.Services.LevelPlay.LevelPlayAdError error)

### public class com.unity3d.mediation.LevelPlayAdError
- Base: Unity.Services.LevelPlay.LevelPlayAdError

#### Constructors
- internal LevelPlayAdError(string json)
- public LevelPlayAdError(string adUnitId, int errorCode, string errorMessage)

### public enum com.unity3d.mediation.LevelPlayAdFormat
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BANNER = 0
- INTERSTITIAL = 1
- REWARDED = 2

### public class com.unity3d.mediation.LevelPlayAdInfo
- Base: Unity.Services.LevelPlay.LevelPlayAdInfo

#### Constructors
- internal LevelPlayAdInfo(string json)

### public class com.unity3d.mediation.LevelPlayAdSize

#### Fields
- private readonly Unity.Services.LevelPlay.LevelPlayAdSize m_AdSize

#### Properties
- public static com.unity3d.mediation.LevelPlayAdSize BANNER { get; }
- public int CustomWidth { get; }
- public string Description { get; }
- public int Height { get; }
- public static com.unity3d.mediation.LevelPlayAdSize LARGE { get; }
- public static com.unity3d.mediation.LevelPlayAdSize LEADERBOARD { get; }
- public static com.unity3d.mediation.LevelPlayAdSize MEDIUM_RECTANGLE { get; }
- public int Width { get; }

#### Constructors
- private LevelPlayAdSize(Unity.Services.LevelPlay.LevelPlayAdSize adSize)

#### Methods
- public static com.unity3d.mediation.LevelPlayAdSize CreateAdaptiveAdSize(int customWidth = -1)
- public static com.unity3d.mediation.LevelPlayAdSize CreateCustomBannerSize(int width, int height)
- internal Unity.Services.LevelPlay.IPlatformLevelPlayAdSize GetPlatformLevelPlayAdSize()
- public override string ToString()

### public class com.unity3d.mediation.LevelPlayBannerAd
- Base: Unity.Services.LevelPlay.LevelPlayBannerAd
- Interfaces: Unity.Services.LevelPlay.ILevelPlayBannerAd, System.IDisposable

#### Constructors
- public LevelPlayBannerAd(string adUnitId, com.unity3d.mediation.LevelPlayAdSize size = null, com.unity3d.mediation.LevelPlayBannerPosition position = null, string placementName = null, bool displayOnLoad = true, bool respectSafeArea = false)

### public class com.unity3d.mediation.LevelPlayBannerPosition

#### Fields
- public static readonly com.unity3d.mediation.LevelPlayBannerPosition BottomCenter
- public static readonly com.unity3d.mediation.LevelPlayBannerPosition BottomLeft
- public static readonly com.unity3d.mediation.LevelPlayBannerPosition BottomRight
- public static readonly com.unity3d.mediation.LevelPlayBannerPosition Center
- public static readonly com.unity3d.mediation.LevelPlayBannerPosition CenterLeft
- public static readonly com.unity3d.mediation.LevelPlayBannerPosition CenterRight
- private readonly Unity.Services.LevelPlay.LevelPlayBannerPosition m_Position
- public static readonly com.unity3d.mediation.LevelPlayBannerPosition TopCenter
- public static readonly com.unity3d.mediation.LevelPlayBannerPosition TopLeft
- public static readonly com.unity3d.mediation.LevelPlayBannerPosition TopRight

#### Properties
- internal string Description { get; }
- internal UnityEngine.Vector2 Position { get; }

#### Constructors
- private static LevelPlayBannerPosition()
- private LevelPlayBannerPosition(Unity.Services.LevelPlay.LevelPlayBannerPosition position)
- public LevelPlayBannerPosition(UnityEngine.Vector2 position)

### public class com.unity3d.mediation.LevelPlayConfiguration
- Base: Unity.Services.LevelPlay.LevelPlayConfiguration

#### Constructors
- internal LevelPlayConfiguration(string json)

### public class com.unity3d.mediation.LevelPlayInitError
- Base: Unity.Services.LevelPlay.LevelPlayInitError

#### Constructors
- internal LevelPlayInitError(string json)

### public class com.unity3d.mediation.LevelPlayInterstitialAd
- Base: Unity.Services.LevelPlay.LevelPlayInterstitialAd
- Interfaces: Unity.Services.LevelPlay.ILevelPlayInterstitialAd, System.IDisposable

#### Constructors
- public LevelPlayInterstitialAd(string adUnitId)
- internal LevelPlayInterstitialAd(Unity.Services.LevelPlay.IPlatformInterstitialAd platformInterstitialAd)

### public class com.unity3d.mediation.LevelPlayReward
- Base: Unity.Services.LevelPlay.LevelPlayReward

#### Constructors
- internal LevelPlayReward(string name, int amount)

### public class com.unity3d.mediation.LevelPlayRewardedAd
- Base: Unity.Services.LevelPlay.LevelPlayRewardedAd
- Interfaces: Unity.Services.LevelPlay.ILevelPlayRewardedAd, System.IDisposable

#### Constructors
- public LevelPlayRewardedAd(string adUnitId)
- internal LevelPlayRewardedAd(Unity.Services.LevelPlay.IPlatformRewardedAd platformRewardedAd)

### public class com.unity3d.mediation.UnsupportedBannerAd
- Base: Unity.Services.LevelPlay.UnsupportedBannerAd
- Interfaces: Unity.Services.LevelPlay.IPlatformBannerAd, System.IDisposable

#### Constructors
- public UnsupportedBannerAd(string adUnitId, com.unity3d.mediation.LevelPlayAdSize size, com.unity3d.mediation.LevelPlayBannerPosition position, string placementId)

## Namespace: IronSourceJSON

### public static class IronSourceJSON.Json

#### Methods
- public static object Deserialize(string json)
- public static string Serialize(object obj)

### private class IronSourceJSON.Json.Parser
- Interfaces: System.IDisposable

#### Fields
- private System.IO.StringReader json
- private static const string WHITE_SPACE
- private static const string WORD_BREAK

#### Properties
- private char NextChar { get; }
- private IronSourceJSON.Json.Parser.TOKEN NextToken { get; }
- private string NextWord { get; }
- private char PeekChar { get; }

#### Constructors
- private Json.Parser(string jsonString)

#### Methods
- public void Dispose()
- private void EatWhitespace()
- public static object Parse(string jsonString)
- private System.Collections.Generic.List<object> ParseArray()
- private object ParseByToken(IronSourceJSON.Json.Parser.TOKEN token)
- private object ParseNumber()
- private System.Collections.Generic.Dictionary<string, object> ParseObject()
- private string ParseString()
- private object ParseValue()

### private class IronSourceJSON.Json.Serializer

#### Fields
- private System.Text.StringBuilder builder

#### Constructors
- private Json.Serializer()

#### Methods
- public static string Serialize(object obj)
- private void SerializeArray(System.Collections.IList anArray)
- private void SerializeObject(System.Collections.IDictionary obj)
- private void SerializeOther(object value)
- private void SerializeString(string str)
- private void SerializeValue(object value)

### private enum IronSourceJSON.Json.Parser.TOKEN
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- COLON = 5
- COMMA = 6
- CURLY_CLOSE = 2
- CURLY_OPEN = 1
- FALSE = 10
- NONE = 0
- NULL = 11
- NUMBER = 8
- SQUARED_CLOSE = 4
- SQUARED_OPEN = 3
- STRING = 7
- TRUE = 9

## Namespace: Unity.Services.LevelPlay

### private class Unity.Services.LevelPlay.UnityRewardedAdListener.<>c__DisplayClass10_0

#### Fields
- public Unity.Services.LevelPlay.UnityRewardedAdListener <>4__this
- public string adInfo

#### Constructors
- public UnityRewardedAdListener.<>c__DisplayClass10_0()

#### Methods
- internal void <onAdInfoChanged>b__0(object state)

### private class Unity.Services.LevelPlay.AndroidInterstitialAd.<>c__DisplayClass37_0

#### Fields
- public Unity.Services.LevelPlay.AndroidInterstitialAd <>4__this
- public string adUnitId

#### Constructors
- public AndroidInterstitialAd.<>c__DisplayClass37_0()

#### Methods
- internal void <.ctor>b__0(object state)

### private class Unity.Services.LevelPlay.AndroidInterstitialAd.<>c__DisplayClass38_0

#### Fields
- public Unity.Services.LevelPlay.AndroidInterstitialAd <>4__this
- public string adUnitId
- public Unity.Services.LevelPlay.AndroidInterstitialAd.Config config

#### Constructors
- public AndroidInterstitialAd.<>c__DisplayClass38_0()

#### Methods
- internal void <.ctor>b__0(object state)

### private class Unity.Services.LevelPlay.UnityInterstitialAdListener.<>c__DisplayClass3_0

#### Fields
- public Unity.Services.LevelPlay.UnityInterstitialAdListener <>4__this
- public string adInfo

#### Constructors
- public UnityInterstitialAdListener.<>c__DisplayClass3_0()

#### Methods
- internal void <onAdLoaded>b__0(object state)

### private class Unity.Services.LevelPlay.UnityRewardedAdListener.<>c__DisplayClass3_0

#### Fields
- public Unity.Services.LevelPlay.UnityRewardedAdListener <>4__this
- public string adInfo

#### Constructors
- public UnityRewardedAdListener.<>c__DisplayClass3_0()

#### Methods
- internal void <onAdLoaded>b__0(object state)

### private class Unity.Services.LevelPlay.AndroidInterstitialAd.<>c__DisplayClass40_0

#### Fields
- public Unity.Services.LevelPlay.AndroidInterstitialAd <>4__this
- public string placementName

#### Constructors
- public AndroidInterstitialAd.<>c__DisplayClass40_0()

#### Methods
- internal void <ShowAd>b__0(object state)

### private class Unity.Services.LevelPlay.AndroidRewardedAd.<>c__DisplayClass40_0

#### Fields
- public Unity.Services.LevelPlay.AndroidRewardedAd <>4__this
- public string adUnitId

#### Constructors
- public AndroidRewardedAd.<>c__DisplayClass40_0()

#### Methods
- internal void <.ctor>b__0(object state)

### private class Unity.Services.LevelPlay.AndroidRewardedAd.<>c__DisplayClass41_0

#### Fields
- public Unity.Services.LevelPlay.AndroidRewardedAd <>4__this
- public string adUnitId
- public Unity.Services.LevelPlay.AndroidRewardedAd.Config config

#### Constructors
- public AndroidRewardedAd.<>c__DisplayClass41_0()

#### Methods
- internal void <.ctor>b__0(object state)

### private class Unity.Services.LevelPlay.AndroidRewardedAd.<>c__DisplayClass43_0

#### Fields
- public Unity.Services.LevelPlay.AndroidRewardedAd <>4__this
- public string placementName

#### Constructors
- public AndroidRewardedAd.<>c__DisplayClass43_0()

#### Methods
- internal void <ShowAd>b__0(object state)

### private class Unity.Services.LevelPlay.UnityInterstitialAdListener.<>c__DisplayClass4_0

#### Fields
- public Unity.Services.LevelPlay.UnityInterstitialAdListener <>4__this
- public string error

#### Constructors
- public UnityInterstitialAdListener.<>c__DisplayClass4_0()

#### Methods
- internal void <onAdLoadFailed>b__0(object state)

### private class Unity.Services.LevelPlay.UnityRewardedAdListener.<>c__DisplayClass4_0

#### Fields
- public Unity.Services.LevelPlay.UnityRewardedAdListener <>4__this
- public string error

#### Constructors
- public UnityRewardedAdListener.<>c__DisplayClass4_0()

#### Methods
- internal void <onAdLoadFailed>b__0(object state)

### private class Unity.Services.LevelPlay.UnityInterstitialAdListener.<>c__DisplayClass5_0

#### Fields
- public Unity.Services.LevelPlay.UnityInterstitialAdListener <>4__this
- public string adInfo

#### Constructors
- public UnityInterstitialAdListener.<>c__DisplayClass5_0()

#### Methods
- internal void <onAdDisplayed>b__0(object state)

### private class Unity.Services.LevelPlay.UnityRewardedAdListener.<>c__DisplayClass5_0

#### Fields
- public Unity.Services.LevelPlay.UnityRewardedAdListener <>4__this
- public string adInfo

#### Constructors
- public UnityRewardedAdListener.<>c__DisplayClass5_0()

#### Methods
- internal void <onAdDisplayed>b__0(object state)

### private class Unity.Services.LevelPlay.UnityInterstitialAdListener.<>c__DisplayClass6_0

#### Fields
- public Unity.Services.LevelPlay.UnityInterstitialAdListener <>4__this
- public string adInfo
- public string error

#### Constructors
- public UnityInterstitialAdListener.<>c__DisplayClass6_0()

#### Methods
- internal void <onAdDisplayFailed>b__0(object state)

### private class Unity.Services.LevelPlay.UnityRewardedAdListener.<>c__DisplayClass6_0

#### Fields
- public Unity.Services.LevelPlay.UnityRewardedAdListener <>4__this
- public string adInfo
- public string error

#### Constructors
- public UnityRewardedAdListener.<>c__DisplayClass6_0()

#### Methods
- internal void <onAdDisplayFailed>b__0(object state)

### private class Unity.Services.LevelPlay.UnityInterstitialAdListener.<>c__DisplayClass7_0

#### Fields
- public Unity.Services.LevelPlay.UnityInterstitialAdListener <>4__this
- public string adInfo

#### Constructors
- public UnityInterstitialAdListener.<>c__DisplayClass7_0()

#### Methods
- internal void <onAdClosed>b__0(object state)

### private class Unity.Services.LevelPlay.UnityRewardedAdListener.<>c__DisplayClass7_0

#### Fields
- public Unity.Services.LevelPlay.UnityRewardedAdListener <>4__this
- public string adInfo
- public int rewardAmount
- public string rewardName

#### Constructors
- public UnityRewardedAdListener.<>c__DisplayClass7_0()

#### Methods
- internal void <onAdRewarded>b__0(object state)

### private class Unity.Services.LevelPlay.UnityInterstitialAdListener.<>c__DisplayClass8_0

#### Fields
- public Unity.Services.LevelPlay.UnityInterstitialAdListener <>4__this
- public string adInfo

#### Constructors
- public UnityInterstitialAdListener.<>c__DisplayClass8_0()

#### Methods
- internal void <onAdClicked>b__0(object state)

### private class Unity.Services.LevelPlay.UnityRewardedAdListener.<>c__DisplayClass8_0

#### Fields
- public Unity.Services.LevelPlay.UnityRewardedAdListener <>4__this
- public string adInfo

#### Constructors
- public UnityRewardedAdListener.<>c__DisplayClass8_0()

#### Methods
- internal void <onAdClicked>b__0(object state)

### private class Unity.Services.LevelPlay.UnityInterstitialAdListener.<>c__DisplayClass9_0

#### Fields
- public Unity.Services.LevelPlay.UnityInterstitialAdListener <>4__this
- public string adInfo

#### Constructors
- public UnityInterstitialAdListener.<>c__DisplayClass9_0()

#### Methods
- internal void <onAdInfoChanged>b__0(object state)

### private class Unity.Services.LevelPlay.UnityRewardedAdListener.<>c__DisplayClass9_0

#### Fields
- public Unity.Services.LevelPlay.UnityRewardedAdListener <>4__this
- public string adInfo

#### Constructors
- public UnityRewardedAdListener.<>c__DisplayClass9_0()

#### Methods
- internal void <onAdClosed>b__0(object state)

### internal class Unity.Services.LevelPlay.AdPrefab
- Base: UnityEngine.MonoBehaviour

#### Constructors
- public AdPrefab()

### internal class Unity.Services.LevelPlay.AndroidInterstitialAd
- Interfaces: Unity.Services.LevelPlay.IPlatformInterstitialAd, System.IDisposable, Unity.Services.LevelPlay.IUnityInterstitialAdListener

#### Fields
- private readonly string <AdUnitId>k__BackingField
- private static const string k_AndroidInterstitialClass
- private static const string k_AndroidLoadAdFunction
- private static const string k_AndroidShowAdFunction
- private static const string k_ErrorDisposed
- private static const string k_FuncGetAdId
- private static const string k_IsAdReadyFunction
- private static const string k_IsPlacementCappedStaticFunction
- private bool m_Disposed
- private UnityEngine.AndroidJavaObject m_InterstitialJavaObject
- private Unity.Services.LevelPlay.IUnityInterstitialAdListener m_InterstitialListener
- private bool m_IsReady
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed
- private System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded
- private System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed

#### Properties
- public string AdId { get; }
- public string AdUnitId { get; }

#### Events
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed
- public event System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded
- public event System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed

#### Constructors
- internal AndroidInterstitialAd(string adUnitId)
- internal AndroidInterstitialAd(string adUnitId, Unity.Services.LevelPlay.AndroidInterstitialAd.Config config)

#### Methods
- private void <Dispose>b__50_0(object state)
- private void <IsAdReady>b__41_0(object state)
- private void <LoadAd>b__39_0(object state)
- private bool CheckDisposedAndLogError()
- private void Dispose(bool disposing)
- public void Dispose()
- protected override void Finalize()
- public bool IsAdReady()
- public static bool IsPlacementCapped(string placementName)
- public void LoadAd()
- public void onAdClicked(string adInfo)
- public void onAdClosed(string adInfo)
- public void onAdDisplayed(string adInfo)
- public void onAdDisplayFailed(string error, string adInfo)
- public void onAdInfoChanged(string adInfo)
- public void onAdLoaded(string adInfo)
- public void onAdLoadFailed(string error)
- public void ShowAd(string placementName)

### internal class Unity.Services.LevelPlay.AndroidRewardedAd
- Interfaces: Unity.Services.LevelPlay.IPlatformRewardedAd, System.IDisposable, Unity.Services.LevelPlay.IUnityRewardedAdListener

#### Fields
- private readonly string <AdUnitId>k__BackingField
- private static const string k_AndroidLoadAdFunction
- private static const string k_AndroidRewardedAdClass
- private static const string k_AndroidShowAdFunction
- private static const string k_ErrorDisposed
- private static const string k_FuncGetAdId
- private static const string k_IsAdReadyFunction
- private static const string k_IsPlacementCappedStaticFunction
- private bool m_Disposed
- private bool m_IsReady
- private UnityEngine.AndroidJavaObject m_RewardedAdJavaObject
- private Unity.Services.LevelPlay.IUnityRewardedAdListener m_RewardedAdListener
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed
- private System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded
- private System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo, com.unity3d.mediation.LevelPlayReward> OnAdRewarded

#### Properties
- public string AdId { get; }
- public string AdUnitId { get; }

#### Events
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed
- public event System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded
- public event System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo, com.unity3d.mediation.LevelPlayReward> OnAdRewarded

#### Constructors
- internal AndroidRewardedAd(string adUnitId)
- internal AndroidRewardedAd(string adUnitId, Unity.Services.LevelPlay.AndroidRewardedAd.Config config)

#### Methods
- private void <Dispose>b__54_0(object state)
- private void <IsAdReady>b__44_0(object state)
- private void <LoadAd>b__42_0(object state)
- private bool CheckDisposedAndLogError()
- private void Dispose(bool disposing)
- public void Dispose()
- protected override void Finalize()
- public bool IsAdReady()
- public static bool IsPlacementCapped(string placementName)
- public void LoadAd()
- public void onAdClicked(string adInfo)
- public void onAdClosed(string adInfo)
- public void onAdDisplayed(string adInfo)
- public void onAdDisplayFailed(string error, string adInfo)
- public void onAdInfoChanged(string adInfo)
- public void onAdLoaded(string adInfo)
- public void onAdLoadFailed(string error)
- public void onAdRewarded(string adInfo, string rewardName, int rewardAmount)
- public void ShowAd(string placementName)

### internal class Unity.Services.LevelPlay.BannerPrefab
- Base: Unity.Services.LevelPlay.AdPrefab

#### Constructors
- public BannerPrefab()

### public class Unity.Services.LevelPlay.LevelPlayBannerAd.Config.Builder

#### Fields
- private readonly Unity.Services.LevelPlay.IPlatformBannerAd.IConfigBuilder m_Builder

#### Constructors
- public LevelPlayBannerAd.Config.Builder()

#### Methods
- public Unity.Services.LevelPlay.LevelPlayBannerAd.Config Build()
- public Unity.Services.LevelPlay.LevelPlayBannerAd.Config.Builder SetBidFloor(double bidFloor)
- public Unity.Services.LevelPlay.LevelPlayBannerAd.Config.Builder SetDisplayOnLoad(bool displayOnLoad)
- public Unity.Services.LevelPlay.LevelPlayBannerAd.Config.Builder SetPlacementName(string placementName)
- public Unity.Services.LevelPlay.LevelPlayBannerAd.Config.Builder SetPosition(com.unity3d.mediation.LevelPlayBannerPosition position)
- public Unity.Services.LevelPlay.LevelPlayBannerAd.Config.Builder SetRespectSafeArea(bool respectSafeArea)
- public Unity.Services.LevelPlay.LevelPlayBannerAd.Config.Builder SetSize(com.unity3d.mediation.LevelPlayAdSize size)

### public class Unity.Services.LevelPlay.LevelPlayInterstitialAd.Config.Builder

#### Fields
- private readonly Unity.Services.LevelPlay.IPlatformInterstitialAd.IConfigBuilder m_Builder

#### Constructors
- public LevelPlayInterstitialAd.Config.Builder()

#### Methods
- public Unity.Services.LevelPlay.LevelPlayInterstitialAd.Config Build()
- public Unity.Services.LevelPlay.LevelPlayInterstitialAd.Config.Builder SetBidFloor(double bidFloor)

### public class Unity.Services.LevelPlay.LevelPlayRewardedAd.Config.Builder

#### Fields
- private readonly Unity.Services.LevelPlay.IPlatformRewardedAd.IConfigBuilder m_Builder

#### Constructors
- public LevelPlayRewardedAd.Config.Builder()

#### Methods
- public Unity.Services.LevelPlay.LevelPlayRewardedAd.Config Build()
- public Unity.Services.LevelPlay.LevelPlayRewardedAd.Config.Builder SetBidFloor(double bidFloor)

### internal class Unity.Services.LevelPlay.AndroidInterstitialAd.Config.Builder
- Interfaces: Unity.Services.LevelPlay.IPlatformInterstitialAd.IConfigBuilder

#### Fields
- private static const string KBuilderClass
- private readonly UnityEngine.AndroidJavaObject m_BuilderJavaObject

#### Constructors
- internal AndroidInterstitialAd.Config.Builder()

#### Methods
- public Unity.Services.LevelPlay.IPlatformInterstitialAd.IConfig Build()
- public void SetBidFloor(double bidFloor)

### internal class Unity.Services.LevelPlay.AndroidRewardedAd.Config.Builder
- Interfaces: Unity.Services.LevelPlay.IPlatformRewardedAd.IConfigBuilder

#### Fields
- private static const string KBuilderClass
- private readonly UnityEngine.AndroidJavaObject m_BuilderJavaObject

#### Constructors
- internal AndroidRewardedAd.Config.Builder()

#### Methods
- public Unity.Services.LevelPlay.IPlatformRewardedAd.IConfig Build()
- public void SetBidFloor(double bidFloor)

### internal class Unity.Services.LevelPlay.UnsupportedBannerAd.Config.Builder
- Interfaces: Unity.Services.LevelPlay.IPlatformBannerAd.IConfigBuilder

#### Constructors
- public UnsupportedBannerAd.Config.Builder()

#### Methods
- public Unity.Services.LevelPlay.IPlatformBannerAd.IConfig Build()
- public void SetBidFloor(double bidFloor)
- public void SetDisplayOnLoad(bool displayOnLoad)
- public void SetPlacementName(string placementName)
- public void SetPosition(com.unity3d.mediation.LevelPlayBannerPosition position)
- public void SetRespectSafeArea(bool respectSafeArea)
- public void SetSize(com.unity3d.mediation.LevelPlayAdSize size)

### internal class Unity.Services.LevelPlay.UnsupportedInterstitialAd.Config.Builder
- Interfaces: Unity.Services.LevelPlay.IPlatformInterstitialAd.IConfigBuilder

#### Constructors
- public UnsupportedInterstitialAd.Config.Builder()

#### Methods
- public Unity.Services.LevelPlay.IPlatformInterstitialAd.IConfig Build()
- public void SetBidFloor(double bidFloor)

### internal class Unity.Services.LevelPlay.UnsupportedRewardedAd.Config.Builder
- Interfaces: Unity.Services.LevelPlay.IPlatformRewardedAd.IConfigBuilder

#### Constructors
- public UnsupportedRewardedAd.Config.Builder()

#### Methods
- public Unity.Services.LevelPlay.IPlatformRewardedAd.IConfig Build()
- public void SetBidFloor(double bidFloor)

### public class Unity.Services.LevelPlay.LevelPlayBannerAd.Config

#### Fields
- private readonly Unity.Services.LevelPlay.IPlatformBannerAd.IConfig <PlatformConfig>k__BackingField

#### Properties
- internal Unity.Services.LevelPlay.IPlatformBannerAd.IConfig PlatformConfig { get; }

#### Constructors
- private LevelPlayBannerAd.Config(Unity.Services.LevelPlay.IPlatformBannerAd.IConfig platformConfig)

### public class Unity.Services.LevelPlay.LevelPlayInterstitialAd.Config

#### Fields
- private readonly Unity.Services.LevelPlay.IPlatformInterstitialAd.IConfig <PlatformConfig>k__BackingField

#### Properties
- internal Unity.Services.LevelPlay.IPlatformInterstitialAd.IConfig PlatformConfig { get; }

#### Constructors
- private LevelPlayInterstitialAd.Config(Unity.Services.LevelPlay.IPlatformInterstitialAd.IConfig platformConfig)

### public class Unity.Services.LevelPlay.LevelPlayRewardedAd.Config

#### Fields
- private readonly Unity.Services.LevelPlay.IPlatformRewardedAd.IConfig <PlatformConfig>k__BackingField

#### Properties
- internal Unity.Services.LevelPlay.IPlatformRewardedAd.IConfig PlatformConfig { get; }

#### Constructors
- private LevelPlayRewardedAd.Config(Unity.Services.LevelPlay.IPlatformRewardedAd.IConfig platformConfig)

### internal class Unity.Services.LevelPlay.AndroidInterstitialAd.Config
- Interfaces: Unity.Services.LevelPlay.IPlatformInterstitialAd.IConfig

#### Fields
- private readonly UnityEngine.AndroidJavaObject <ConfigJavaObject>k__BackingField

#### Properties
- internal UnityEngine.AndroidJavaObject ConfigJavaObject { get; }

#### Constructors
- private AndroidInterstitialAd.Config(UnityEngine.AndroidJavaObject config)

### internal class Unity.Services.LevelPlay.AndroidRewardedAd.Config
- Interfaces: Unity.Services.LevelPlay.IPlatformRewardedAd.IConfig

#### Fields
- private readonly UnityEngine.AndroidJavaObject <ConfigJavaObject>k__BackingField

#### Properties
- internal UnityEngine.AndroidJavaObject ConfigJavaObject { get; }

#### Constructors
- private AndroidRewardedAd.Config(UnityEngine.AndroidJavaObject config)

### internal class Unity.Services.LevelPlay.UnsupportedBannerAd.Config
- Interfaces: Unity.Services.LevelPlay.IPlatformBannerAd.IConfig

#### Constructors
- public UnsupportedBannerAd.Config()

### internal class Unity.Services.LevelPlay.UnsupportedInterstitialAd.Config
- Interfaces: Unity.Services.LevelPlay.IPlatformInterstitialAd.IConfig

#### Constructors
- public UnsupportedInterstitialAd.Config()

### internal class Unity.Services.LevelPlay.UnsupportedRewardedAd.Config
- Interfaces: Unity.Services.LevelPlay.IPlatformRewardedAd.IConfig

#### Constructors
- public UnsupportedRewardedAd.Config()

### internal static class Unity.Services.LevelPlay.Constants

#### Fields
- internal static const string AnnotatedPackageVersion
- internal static const string PackageAnalyticsIdentifier
- internal static const string PackageName
- internal static const string PackageVersion
- internal static const string PackageVersionAnnotation
- internal static const string UnityPackageDirectoryName

### internal interface Unity.Services.LevelPlay.IPlatformBannerAd.IConfig

### internal interface Unity.Services.LevelPlay.IPlatformInterstitialAd.IConfig

### internal interface Unity.Services.LevelPlay.IPlatformRewardedAd.IConfig

### internal interface Unity.Services.LevelPlay.IPlatformBannerAd.IConfigBuilder

#### Methods
- public Unity.Services.LevelPlay.IPlatformBannerAd.IConfig Build()
- public void SetBidFloor(double bidFloor)
- public void SetDisplayOnLoad(bool displayOnLoad)
- public void SetPlacementName(string placementName)
- public void SetPosition(com.unity3d.mediation.LevelPlayBannerPosition position)
- public void SetRespectSafeArea(bool respectSafeArea)
- public void SetSize(com.unity3d.mediation.LevelPlayAdSize size)

### internal interface Unity.Services.LevelPlay.IPlatformInterstitialAd.IConfigBuilder

#### Methods
- public Unity.Services.LevelPlay.IPlatformInterstitialAd.IConfig Build()
- public void SetBidFloor(double bidFloor)

### internal interface Unity.Services.LevelPlay.IPlatformRewardedAd.IConfigBuilder

#### Methods
- public Unity.Services.LevelPlay.IPlatformRewardedAd.IConfig Build()
- public void SetBidFloor(double bidFloor)

### public interface Unity.Services.LevelPlay.ILevelPlayBannerAd
- Interfaces: System.IDisposable

#### Events
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdCollapsed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed
- public event System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdExpanded
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLeftApplication
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded
- public event System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed

#### Methods
- public void DestroyAd()
- public string GetAdId()
- public com.unity3d.mediation.LevelPlayAdSize GetAdSize()
- public string GetAdUnitId()
- public string GetPlacementName()
- public com.unity3d.mediation.LevelPlayBannerPosition GetPosition()
- public void HideAd()
- public void LoadAd()
- public void PauseAutoRefresh()
- public void ResumeAutoRefresh()
- public void ShowAd()

### public interface Unity.Services.LevelPlay.ILevelPlayInterstitialAd
- Interfaces: System.IDisposable

#### Properties
- public string AdUnitId { get; }

#### Events
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed
- public event System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded
- public event System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed

#### Methods
- public void DestroyAd()
- public string GetAdId()
- public bool IsAdReady()
- public void LoadAd()
- public void ShowAd(string placementName = null)

### public interface Unity.Services.LevelPlay.ILevelPlayRewardedAd
- Interfaces: System.IDisposable

#### Properties
- public string AdUnitId { get; }

#### Events
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed
- public event System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded
- public event System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo, com.unity3d.mediation.LevelPlayReward> OnAdRewarded

#### Methods
- public void DestroyAd()
- public string GetAdId()
- public bool IsAdReady()
- public void LoadAd()
- public void ShowAd(string placementName = null)

### internal class Unity.Services.LevelPlay.InterstitialPrefab
- Base: Unity.Services.LevelPlay.AdPrefab

#### Constructors
- public InterstitialPrefab()

### internal interface Unity.Services.LevelPlay.IPlatformBannerAd
- Interfaces: System.IDisposable

#### Properties
- public string AdId { get; }
- public com.unity3d.mediation.LevelPlayAdSize AdSize { get; }
- public string AdUnitId { get; }
- public string PlacementName { get; }
- public com.unity3d.mediation.LevelPlayBannerPosition Position { get; }

#### Events
- public event System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked
- public event System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdCollapsed
- public event System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed
- public event System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed
- public event System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdExpanded
- public event System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdLeftApplication
- public event System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded
- public event System.EventHandler<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed

#### Methods
- public void DestroyAd()
- public void HideAd()
- public void Load()
- public void PauseAutoRefresh()
- public void ResumeAutoRefresh()
- public void ShowAd()

### internal interface Unity.Services.LevelPlay.IPlatformInterstitialAd
- Interfaces: System.IDisposable

#### Properties
- public string AdId { get; }
- public string AdUnitId { get; }

#### Events
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed
- public event System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded
- public event System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed

#### Methods
- public bool IsAdReady()
- public void LoadAd()
- public void ShowAd(string placementName)

### internal interface Unity.Services.LevelPlay.IPlatformLevelPlayAdSize

#### Properties
- public Unity.Services.LevelPlay.PlatformLevelPlayAdSizeType AdSizeType { get; }
- public int Height { get; }
- public int Width { get; }

### internal interface Unity.Services.LevelPlay.IPlatformRewardedAd
- Interfaces: System.IDisposable

#### Properties
- public string AdId { get; }
- public string AdUnitId { get; }

#### Events
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed
- public event System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded
- public event System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo, com.unity3d.mediation.LevelPlayReward> OnAdRewarded

#### Methods
- public bool IsAdReady()
- public void LoadAd()
- public void ShowAd(string placementName)

### internal interface Unity.Services.LevelPlay.IUnityInterstitialAdListener

#### Methods
- public void onAdClicked(string adInfo)
- public void onAdClosed(string adInfo)
- public void onAdDisplayed(string adInfo)
- public void onAdDisplayFailed(string error, string adInfo)
- public void onAdInfoChanged(string adInfo)
- public void onAdLoaded(string adInfo)
- public void onAdLoadFailed(string error)

### internal interface Unity.Services.LevelPlay.IUnityRewardedAdListener

#### Methods
- public void onAdClicked(string adInfo)
- public void onAdClosed(string adInfo)
- public void onAdDisplayed(string adInfo)
- public void onAdDisplayFailed(string error, string adInfo)
- public void onAdInfoChanged(string adInfo)
- public void onAdLoaded(string adInfo)
- public void onAdLoadFailed(string error)
- public void onAdRewarded(string adInfo, string rewardName, int rewardAmount)

### public class Unity.Services.LevelPlay.LevelPlay

#### Fields
- private static System.Action<Unity.Services.LevelPlay.LevelPlayImpressionData> OnImpressionDataReadyReceived
- private static System.Action<com.unity3d.mediation.LevelPlayInitError> OnInitFailedReceived
- private static System.Action<com.unity3d.mediation.LevelPlayConfiguration> OnInitSuccessReceived

#### Properties
- public static string PluginVersion { get; }
- public static string UnityVersion { get; }

#### Events
- public static event System.Action<Unity.Services.LevelPlay.LevelPlayImpressionData> OnImpressionDataReady
- private static event System.Action<Unity.Services.LevelPlay.LevelPlayImpressionData> OnImpressionDataReadyReceived
- public static event System.Action<com.unity3d.mediation.LevelPlayInitError> OnInitFailed
- private static event System.Action<com.unity3d.mediation.LevelPlayInitError> OnInitFailedReceived
- public static event System.Action<com.unity3d.mediation.LevelPlayConfiguration> OnInitSuccess
- private static event System.Action<com.unity3d.mediation.LevelPlayConfiguration> OnInitSuccessReceived

#### Constructors
- private static LevelPlay()
- public LevelPlay()

#### Methods
- public static void Init(string appKey, string userId = null, com.unity3d.mediation.LevelPlayAdFormat[] adFormats = null)
- public static void LaunchTestSuite()
- public static void SetAdaptersDebug(bool enabled)
- public static void SetConsent(bool consent)
- public static bool SetDynamicUserId(string dynamicUserId)
- public static void SetMetaData(string key, string value)
- public static void SetMetaData(string key, params string[] values)
- public static void SetNetworkData(string networkKey, string networkData)
- public static void SetPauseGame(bool pause)
- public static void SetSegment(Unity.Services.LevelPlay.LevelPlaySegment segment)
- public static void ValidateIntegration()

### public class Unity.Services.LevelPlay.LevelPlayAdDisplayInfoError

#### Fields
- private Unity.Services.LevelPlay.LevelPlayAdInfo <DisplayLevelPlayAdInfo>k__BackingField
- private Unity.Services.LevelPlay.LevelPlayAdError <LevelPlayError>k__BackingField

#### Properties
- public Unity.Services.LevelPlay.LevelPlayAdInfo DisplayLevelPlayAdInfo { get; private set; }
- public Unity.Services.LevelPlay.LevelPlayAdError LevelPlayError { get; private set; }

#### Constructors
- internal LevelPlayAdDisplayInfoError(Unity.Services.LevelPlay.LevelPlayAdInfo levelPlayAdInfo, Unity.Services.LevelPlay.LevelPlayAdError error)

#### Methods
- public override string ToString()

### public class Unity.Services.LevelPlay.LevelPlayAdError

#### Fields
- private readonly string <AdId>k__BackingField
- private readonly string <AdUnitId>k__BackingField
- private readonly int <ErrorCode>k__BackingField
- private readonly string <ErrorMessage>k__BackingField

#### Properties
- public string AdId { get; }
- public string AdUnitId { get; }
- public int ErrorCode { get; }
- public string ErrorMessage { get; }

#### Constructors
- internal LevelPlayAdError(string json)
- internal LevelPlayAdError(string adUnitId, int errorCode, string errorMessage)
- internal LevelPlayAdError(string adUnitId, int errorCode, string errorMessage, string adId)

#### Methods
- public override string ToString()

### public enum Unity.Services.LevelPlay.LevelPlayAdFormat
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BANNER = 0
- INTERSTITIAL = 1
- REWARDED = 2

### public class Unity.Services.LevelPlay.LevelPlayAdInfo

#### Fields
- public readonly string ab
- public readonly string Ab
- private static const string AbKey
- public readonly string adFormat
- public readonly string AdFormat
- private static const string AdFormatKey
- public readonly string AdId
- private static const string AdIdKey
- public readonly string adNetwork
- public readonly string AdNetwork
- private static const string AdNetworkKey
- public readonly Unity.Services.LevelPlay.LevelPlayAdSize adSize
- public readonly Unity.Services.LevelPlay.LevelPlayAdSize AdSize
- private static const string AdSizeDescriptionKey
- private static const string AdSizeHeightKey
- private static const string AdSizeKey
- private static const string AdSizeWidthKey
- public readonly string adUnitId
- public readonly string AdUnitId
- private static const string AdUnitIdKey
- public readonly string adUnitName
- public readonly string AdUnitName
- private static const string AdUnitNameKey
- public readonly string auctionId
- public readonly string AuctionId
- private static const string AuctionIdKey
- public readonly string country
- public readonly string Country
- private static const string CountryKey
- public readonly string CreativeId
- public readonly string encryptedCPM
- public readonly string EncryptedCPM
- private static const string EncryptedCpmKey
- public readonly string instanceId
- public readonly string InstanceId
- private static const string InstanceIdKey
- public readonly string instanceName
- public readonly string InstanceName
- private static const string InstanceNameKey
- public readonly string placementName
- public readonly string PlacementName
- private static const string PlacementNameKey
- public readonly string precision
- public readonly string Precision
- private static const string PrecisionKey
- public readonly System.Nullable<double> revenue
- public readonly System.Nullable<double> Revenue
- private static const string RevenueKey
- public readonly string segmentName
- public readonly string SegmentName
- private static const string SegmentNameKey

#### Constructors
- internal LevelPlayAdInfo(string json)

#### Methods
- private static Unity.Services.LevelPlay.LevelPlayAdSize GetAdSize(string adSizeJson)
- private static Unity.Services.LevelPlay.LevelPlayAdSize GetAdSize(string description, int width = 0, int height = 0)
- public override string ToString()

### public class Unity.Services.LevelPlay.LevelPlayAdSize

#### Fields
- public static Unity.Services.LevelPlay.LevelPlayAdSize BANNER
- public static Unity.Services.LevelPlay.LevelPlayAdSize LARGE
- public static Unity.Services.LevelPlay.LevelPlayAdSize LEADERBOARD
- public static Unity.Services.LevelPlay.LevelPlayAdSize MEDIUM_RECTANGLE
- private Unity.Services.LevelPlay.IPlatformLevelPlayAdSize m_PlatformLevelPlayAdSize

#### Properties
- public int CustomWidth { get; }
- public string Description { get; }
- public int Height { get; }
- public int Width { get; }

#### Constructors
- internal LevelPlayAdSize()
- private static LevelPlayAdSize()
- internal LevelPlayAdSize(Unity.Services.LevelPlay.IPlatformLevelPlayAdSize adSize)
- private LevelPlayAdSize(Unity.Services.LevelPlay.PlatformLevelPlayAdSizeType adSizeType)
- private LevelPlayAdSize(int width, int height)

#### Methods
- public static Unity.Services.LevelPlay.LevelPlayAdSize CreateAdaptiveAdSize(int customWidth = -1)
- public static Unity.Services.LevelPlay.LevelPlayAdSize CreateCustomBannerSize(int width, int height)
- internal Unity.Services.LevelPlay.IPlatformLevelPlayAdSize GetPlatformLevelPlayAdSize()
- public override string ToString()

### public class Unity.Services.LevelPlay.LevelPlayBannerAd
- Interfaces: Unity.Services.LevelPlay.ILevelPlayBannerAd, System.IDisposable

#### Fields
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdCollapsed
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed
- private System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdExpanded
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLeftApplication
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded
- private System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed
- private bool _autoRefresh
- private readonly Unity.Services.LevelPlay.IPlatformBannerAd _bannerAd

#### Events
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdCollapsed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed
- public event System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdExpanded
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLeftApplication
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded
- public event System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed

#### Constructors
- public LevelPlayBannerAd(string adUnitId, Unity.Services.LevelPlay.LevelPlayBannerAd.Config config)
- public LevelPlayBannerAd(string adUnitId, com.unity3d.mediation.LevelPlayAdSize size = null, com.unity3d.mediation.LevelPlayBannerPosition position = null, string placementName = null, bool displayOnLoad = true, bool respectSafeArea = false)

#### Methods
- private void <SetupCallbacks>b__39_0(object sender, com.unity3d.mediation.LevelPlayAdInfo args)
- private void <SetupCallbacks>b__39_1(object sender, com.unity3d.mediation.LevelPlayAdError args)
- private void <SetupCallbacks>b__39_2(object sender, com.unity3d.mediation.LevelPlayAdInfo args)
- private void <SetupCallbacks>b__39_3(object sender, com.unity3d.mediation.LevelPlayAdInfo args)
- private void <SetupCallbacks>b__39_4(object sender, com.unity3d.mediation.LevelPlayAdDisplayInfoError args)
- private void <SetupCallbacks>b__39_5(object sender, com.unity3d.mediation.LevelPlayAdInfo args)
- private void <SetupCallbacks>b__39_6(object sender, com.unity3d.mediation.LevelPlayAdInfo args)
- private void <SetupCallbacks>b__39_7(object sender, com.unity3d.mediation.LevelPlayAdInfo args)
- public void DestroyAd()
- public void Dispose()
- public string GetAdId()
- public com.unity3d.mediation.LevelPlayAdSize GetAdSize()
- public string GetAdUnitId()
- public string GetPlacementName()
- public com.unity3d.mediation.LevelPlayBannerPosition GetPosition()
- public void HideAd()
- public void LoadAd()
- public void PauseAutoRefresh()
- public void ResumeAutoRefresh()
- private void SetupCallbacks()
- public void ShowAd()

### public class Unity.Services.LevelPlay.LevelPlayBannerPosition

#### Fields
- public static readonly Unity.Services.LevelPlay.LevelPlayBannerPosition BottomCenter
- public static readonly Unity.Services.LevelPlay.LevelPlayBannerPosition BottomLeft
- public static readonly Unity.Services.LevelPlay.LevelPlayBannerPosition BottomRight
- public static readonly Unity.Services.LevelPlay.LevelPlayBannerPosition Center
- public static readonly Unity.Services.LevelPlay.LevelPlayBannerPosition CenterLeft
- public static readonly Unity.Services.LevelPlay.LevelPlayBannerPosition CenterRight
- public readonly string Description
- internal readonly UnityEngine.Vector2 Position
- public static readonly Unity.Services.LevelPlay.LevelPlayBannerPosition TopCenter
- public static readonly Unity.Services.LevelPlay.LevelPlayBannerPosition TopLeft
- public static readonly Unity.Services.LevelPlay.LevelPlayBannerPosition TopRight

#### Constructors
- private static LevelPlayBannerPosition()
- public LevelPlayBannerPosition(UnityEngine.Vector2 position)
- private LevelPlayBannerPosition(Unity.Services.LevelPlay.LevelPlayBannerPosition.Presets presets, UnityEngine.Vector2 position = null)

#### Methods
- public override string ToString()

### public class Unity.Services.LevelPlay.LevelPlayConfiguration

#### Fields
- private readonly bool <IsAdQualityEnabled>k__BackingField
- private static const string k_IsAdQualityEnabled

#### Properties
- public bool IsAdQualityEnabled { get; }

#### Constructors
- internal LevelPlayConfiguration(string json)

### public class Unity.Services.LevelPlay.LevelPlayImpressionData

#### Fields
- private readonly string <AllData>k__BackingField
- private readonly System.Collections.Generic.Dictionary<string, object> InternalDictionary

#### Properties
- public string Ab { get; }
- public string AdFormat { get; }
- public string AdNetwork { get; }
- public string AllData { get; }
- public string AuctionId { get; }
- public System.Nullable<int> ConversionValue { get; }
- public string Country { get; }
- public string CreativeId { get; }
- public string EncryptedCpm { get; }
- public string InstanceId { get; }
- public string InstanceName { get; }
- public string MediationAdUnitId { get; }
- public string MediationAdUnitName { get; }
- public string Placement { get; }
- public string Precision { get; }
- public System.Nullable<double> Revenue { get; }
- public string SegmentName { get; }

#### Constructors
- internal LevelPlayImpressionData(string levelplayImpressionJson)

#### Methods
- private System.Nullable<double> GetValueAsDouble(string key)
- private System.Nullable<int> GetValueAsInt(string key)
- private string GetValueAsString(string key)
- private System.Collections.Generic.Dictionary<string, object> ParseJson(string json)
- public override string ToString()

### public class Unity.Services.LevelPlay.LevelPlayInitError

#### Fields
- private readonly int <ErrorCode>k__BackingField
- private readonly string <ErrorMessage>k__BackingField

#### Properties
- public int ErrorCode { get; }
- public string ErrorMessage { get; }

#### Constructors
- internal LevelPlayInitError(string json)

#### Methods
- public override string ToString()

### public class Unity.Services.LevelPlay.LevelPlayInterstitialAd
- Interfaces: Unity.Services.LevelPlay.ILevelPlayInterstitialAd, System.IDisposable

#### Fields
- private readonly Unity.Services.LevelPlay.IPlatformInterstitialAd m_InterstitialAd
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed
- private System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded
- private System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed

#### Properties
- public string AdUnitId { get; }

#### Events
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed
- public event System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded
- public event System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed

#### Constructors
- public LevelPlayInterstitialAd(string adUnitId)
- internal LevelPlayInterstitialAd(Unity.Services.LevelPlay.IPlatformInterstitialAd platformInterstitialAd)
- public LevelPlayInterstitialAd(string adUnitId, Unity.Services.LevelPlay.LevelPlayInterstitialAd.Config config)

#### Methods
- private void <SetupEvents>b__26_0(com.unity3d.mediation.LevelPlayAdInfo info)
- private void <SetupEvents>b__26_1(com.unity3d.mediation.LevelPlayAdError error)
- private void <SetupEvents>b__26_2(com.unity3d.mediation.LevelPlayAdInfo info)
- private void <SetupEvents>b__26_3(com.unity3d.mediation.LevelPlayAdInfo info)
- private void <SetupEvents>b__26_4(com.unity3d.mediation.LevelPlayAdInfo info)
- private void <SetupEvents>b__26_5(com.unity3d.mediation.LevelPlayAdDisplayInfoError infoError)
- private void <SetupEvents>b__26_6(com.unity3d.mediation.LevelPlayAdInfo info)
- public void DestroyAd()
- public void Dispose()
- public string GetAdId()
- public bool IsAdReady()
- public static bool IsPlacementCapped(string placementName)
- public void LoadAd()
- private void SetupEvents()
- public void ShowAd(string placementName = null)

### internal static class Unity.Services.LevelPlay.LevelPlayLogger

#### Fields
- private static const string k_Tag
- private static const string k_UnityAssertions
- private static const string k_VerboseLoggingDefine

#### Methods
- public static void Log(object message)
- public static void LogAssertion(object message)
- public static void LogError(object message)
- public static void LogException(System.Exception exception)
- public static void LogVerbose(object message)
- public static void LogWarning(object message)

### public class Unity.Services.LevelPlay.LevelPlayReward

#### Fields
- private readonly int <Amount>k__BackingField
- private readonly string <Name>k__BackingField

#### Properties
- public int Amount { get; }
- public string Name { get; }

#### Constructors
- internal LevelPlayReward(string name, int amount)

### public class Unity.Services.LevelPlay.LevelPlayRewardedAd
- Interfaces: Unity.Services.LevelPlay.ILevelPlayRewardedAd, System.IDisposable

#### Fields
- private readonly Unity.Services.LevelPlay.IPlatformRewardedAd m_RewardedAd
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed
- private System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded
- private System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo, com.unity3d.mediation.LevelPlayReward> OnAdRewarded

#### Properties
- public string AdUnitId { get; }

#### Events
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed
- public event System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded
- public event System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo, com.unity3d.mediation.LevelPlayReward> OnAdRewarded

#### Constructors
- public LevelPlayRewardedAd(string adUnitId)
- internal LevelPlayRewardedAd(Unity.Services.LevelPlay.IPlatformRewardedAd platformRewardedAd)
- public LevelPlayRewardedAd(string adUnitId, Unity.Services.LevelPlay.LevelPlayRewardedAd.Config config)

#### Methods
- private void <SetupEvents>b__29_0(com.unity3d.mediation.LevelPlayAdInfo info)
- private void <SetupEvents>b__29_1(com.unity3d.mediation.LevelPlayAdError error)
- private void <SetupEvents>b__29_2(com.unity3d.mediation.LevelPlayAdInfo info)
- private void <SetupEvents>b__29_3(com.unity3d.mediation.LevelPlayAdDisplayInfoError infoError)
- private void <SetupEvents>b__29_4(com.unity3d.mediation.LevelPlayAdInfo info, com.unity3d.mediation.LevelPlayReward reward)
- private void <SetupEvents>b__29_5(com.unity3d.mediation.LevelPlayAdInfo info)
- private void <SetupEvents>b__29_6(com.unity3d.mediation.LevelPlayAdInfo info)
- private void <SetupEvents>b__29_7(com.unity3d.mediation.LevelPlayAdInfo info)
- public void DestroyAd()
- public void Dispose()
- public string GetAdId()
- public bool IsAdReady()
- public static bool IsPlacementCapped(string placementName)
- public void LoadAd()
- private void SetupEvents()
- public void ShowAd(string placementName = null)

### public class Unity.Services.LevelPlay.LevelPlaySegment

#### Fields
- public readonly System.Collections.Generic.Dictionary<string, string> CustomData
- public double IapTotal
- public int IsPaying
- public int Level
- public string SegmentName
- public long UserCreationDate

#### Constructors
- public LevelPlaySegment()

#### Methods
- public System.Collections.Generic.Dictionary<string, string> GetSegmentAsDictionary()
- public void SetCustom(string key, string value)

### internal static class Unity.Services.LevelPlay.ObjectUtility

#### Methods
- internal static void DestroySafely<T>(T obj)

### internal enum Unity.Services.LevelPlay.PlatformLevelPlayAdSizeType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Adaptive = 6
- Banner = 1
- Custom = 4
- Large = 2
- LeaderBoard = 5
- MediumRectangle = 3
- Unknown = 0

### private enum Unity.Services.LevelPlay.LevelPlayBannerPosition.Presets
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BottomCenter = 7
- BottomLeft = 6
- BottomRight = 8
- Center = 4
- CenterLeft = 3
- CenterRight = 5
- Custom = 9
- TopCenter = 1
- TopLeft = 0
- TopRight = 2

### internal class Unity.Services.LevelPlay.RewardedPrefab
- Base: Unity.Services.LevelPlay.AdPrefab

#### Constructors
- public RewardedPrefab()

### internal static class Unity.Services.LevelPlay.ThreadUtil

#### Fields
- internal static System.Threading.SynchronizationContext UnitySynchronizationContext

#### Methods
- private static void Init()
- public static void Post(System.Threading.SendOrPostCallback d, object state = null)
- public static void Send(System.Threading.SendOrPostCallback d, object state = null)

### internal class Unity.Services.LevelPlay.UnityInterstitialAdListener
- Base: UnityEngine.AndroidJavaProxy
- Interfaces: Unity.Services.LevelPlay.IUnityInterstitialAdListener

#### Fields
- private static const string k_AndroidInterstitialListenerName
- private readonly Unity.Services.LevelPlay.IUnityInterstitialAdListener m_UnityListener

#### Constructors
- public UnityInterstitialAdListener(Unity.Services.LevelPlay.IUnityInterstitialAdListener listener)

#### Methods
- public void onAdClicked(string adInfo)
- public void onAdClosed(string adInfo)
- public void onAdDisplayed(string adInfo)
- public void onAdDisplayFailed(string error, string adInfo)
- public void onAdInfoChanged(string adInfo)
- public void onAdLoaded(string adInfo)
- public void onAdLoadFailed(string error)

### internal class Unity.Services.LevelPlay.UnityRewardedAdListener
- Base: UnityEngine.AndroidJavaProxy
- Interfaces: Unity.Services.LevelPlay.IUnityRewardedAdListener

#### Fields
- private static const string k_AndroidRewardedAdListenerName
- private readonly Unity.Services.LevelPlay.IUnityRewardedAdListener m_UnityListener

#### Constructors
- public UnityRewardedAdListener(Unity.Services.LevelPlay.IUnityRewardedAdListener listener)

#### Methods
- public void onAdClicked(string adInfo)
- public void onAdClosed(string adInfo)
- public void onAdDisplayed(string adInfo)
- public void onAdDisplayFailed(string error, string adInfo)
- public void onAdInfoChanged(string adInfo)
- public void onAdLoaded(string adInfo)
- public void onAdLoadFailed(string error)
- public void onAdRewarded(string adInfo, string rewardName, int rewardAmount)

### public class Unity.Services.LevelPlay.UnsupportedBannerAd
- Interfaces: Unity.Services.LevelPlay.IPlatformBannerAd, System.IDisposable

#### Fields
- private readonly string <AdId>k__BackingField
- private readonly com.unity3d.mediation.LevelPlayAdSize <AdSize>k__BackingField
- private readonly string <AdUnitId>k__BackingField
- private readonly string <PlacementName>k__BackingField
- private readonly com.unity3d.mediation.LevelPlayBannerPosition <Position>k__BackingField
- private readonly Unity.Services.LevelPlay.LevelPlayAdSize <Size>k__BackingField
- private System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked
- private System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdCollapsed
- private System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed
- private System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed
- private System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdExpanded
- private System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdLeftApplication
- private System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded
- private System.EventHandler<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed

#### Properties
- public string AdId { get; }
- public com.unity3d.mediation.LevelPlayAdSize AdSize { get; }
- public string AdUnitId { get; }
- public string PlacementName { get; }
- public com.unity3d.mediation.LevelPlayBannerPosition Position { get; }
- public Unity.Services.LevelPlay.LevelPlayAdSize Size { get; }

#### Events
- public event System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked
- public event System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdCollapsed
- public event System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed
- public event System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed
- public event System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdExpanded
- public event System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdLeftApplication
- public event System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded
- public event System.EventHandler<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed

#### Constructors
- internal UnsupportedBannerAd(string adUnitId, Unity.Services.LevelPlay.UnsupportedBannerAd.Config config)
- public UnsupportedBannerAd(string adUnitId, com.unity3d.mediation.LevelPlayAdSize size, com.unity3d.mediation.LevelPlayBannerPosition position, string placementId)

#### Methods
- public void DestroyAd()
- public void Dispose()
- public void HideAd()
- public void Load()
- public void PauseAutoRefresh()
- public void ResumeAutoRefresh()
- public void SetAutoRefresh(bool flag)
- public void ShowAd()

### internal class Unity.Services.LevelPlay.UnsupportedInterstitialAd
- Interfaces: Unity.Services.LevelPlay.IPlatformInterstitialAd, System.IDisposable

#### Fields
- private readonly string <AdId>k__BackingField
- private readonly string <AdUnitId>k__BackingField
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed
- private System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded
- private System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed

#### Properties
- public string AdId { get; }
- public string AdUnitId { get; }

#### Events
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed
- public event System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded
- public event System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed

#### Constructors
- public UnsupportedInterstitialAd(string adUnitId)

#### Methods
- public void Dispose()
- public bool IsAdReady()
- public void LoadAd()
- public void ShowAd(string placementName)

### internal class Unity.Services.LevelPlay.UnsupportedLevelPlayAdSize
- Interfaces: Unity.Services.LevelPlay.IPlatformLevelPlayAdSize

#### Properties
- public Unity.Services.LevelPlay.PlatformLevelPlayAdSizeType AdSizeType { get; }
- public int Height { get; }
- public int Width { get; }

#### Constructors
- internal UnsupportedLevelPlayAdSize()

### internal class Unity.Services.LevelPlay.UnsupportedRewardedAd
- Interfaces: Unity.Services.LevelPlay.IPlatformRewardedAd, System.IDisposable

#### Fields
- private readonly string <AdId>k__BackingField
- private readonly string <AdUnitId>k__BackingField
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed
- private System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded
- private System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed
- private System.Action<com.unity3d.mediation.LevelPlayAdInfo, com.unity3d.mediation.LevelPlayReward> OnAdRewarded

#### Properties
- public string AdId { get; }
- public string AdUnitId { get; }

#### Events
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed
- public event System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded
- public event System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed
- public event System.Action<com.unity3d.mediation.LevelPlayAdInfo, com.unity3d.mediation.LevelPlayReward> OnAdRewarded

#### Constructors
- public UnsupportedRewardedAd(string adUnitId)

#### Methods
- public void Dispose()
- public bool IsAdReady()
- public void LoadAd()
- public void ShowAd(string placementName)

