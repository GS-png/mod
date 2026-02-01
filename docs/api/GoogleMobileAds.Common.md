# Assembly: GoogleMobileAds.Common
- Path: tools/WorldBox.Managed/GoogleMobileAds.Common.dll
- Types: 27

## Namespace: GoogleMobileAds

### public interface GoogleMobileAds.IClientFactory

#### Methods
- public GoogleMobileAds.Common.IApplicationPreferencesClient ApplicationPreferencesInstance()
- public GoogleMobileAds.Common.IAdManagerBannerClient BuildAdManagerBannerClient()
- public GoogleMobileAds.Common.IAdManagerInterstitialClient BuildAdManagerInterstitialClient()
- public GoogleMobileAds.Common.IAppOpenAdClient BuildAppOpenAdClient()
- public GoogleMobileAds.Common.IAppStateEventClient BuildAppStateEventClient()
- public GoogleMobileAds.Common.IBannerClient BuildBannerClient()
- public GoogleMobileAds.Common.IInterstitialClient BuildInterstitialClient()
- public GoogleMobileAds.Common.INativeOverlayAdClient BuildNativeOverlayAdClient()
- public GoogleMobileAds.Common.IRewardedAdClient BuildRewardedAdClient()
- public GoogleMobileAds.Common.IRewardedInterstitialAdClient BuildRewardedInterstitialAdClient()
- public GoogleMobileAds.Common.IMobileAdsClient MobileAdsInstance()

## Namespace: GoogleMobileAds.Common

### private class GoogleMobileAds.Common.MobileAdsEventExecutor.<InvokeInUpdate>c__AnonStorey0

#### Fields
- internal UnityEngine.Events.UnityEvent eventParam

#### Constructors
- public MobileAdsEventExecutor.<InvokeInUpdate>c__AnonStorey0()

#### Methods
- internal void <>m__0()

### public class GoogleMobileAds.Common.AdErrorClientEventArgs
- Base: System.EventArgs

#### Fields
- private GoogleMobileAds.Common.IAdErrorClient <AdErrorClient>k__BackingField

#### Properties
- public GoogleMobileAds.Common.IAdErrorClient AdErrorClient { get; set; }

#### Constructors
- public AdErrorClientEventArgs()

### public class GoogleMobileAds.Common.AdInspectorErrorClientEventArgs
- Base: System.EventArgs

#### Fields
- private GoogleMobileAds.Common.IAdInspectorErrorClient <AdErrorClient>k__BackingField

#### Properties
- public GoogleMobileAds.Common.IAdInspectorErrorClient AdErrorClient { get; set; }

#### Constructors
- public AdInspectorErrorClientEventArgs()

### public enum GoogleMobileAds.Common.AppState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Background = 0
- Foreground = 1

### public class GoogleMobileAds.Common.AppStateEventClient
- Base: UnityEngine.MonoBehaviour
- Interfaces: GoogleMobileAds.Common.IAppStateEventClient

#### Fields
- private static System.Action<GoogleMobileAds.Common.AppState> <>f__am$cache0
- private System.Action<GoogleMobileAds.Common.AppState> AppStateChanged
- private static GoogleMobileAds.Common.AppStateEventClient instance

#### Properties
- public static GoogleMobileAds.Common.AppStateEventClient Instance { get; }

#### Events
- public event System.Action<GoogleMobileAds.Common.AppState> AppStateChanged

#### Constructors
- public AppStateEventClient()

#### Methods
- private static void <AppStateChanged>m__0(GoogleMobileAds.Common.AppState )
- private void OnApplicationPause(bool isPaused)

### public interface GoogleMobileAds.Common.IAdapterResponseInfoClient

#### Properties
- public string AdapterClassName { get; }
- public GoogleMobileAds.Common.IAdErrorClient AdError { get; }
- public string AdSourceId { get; }
- public string AdSourceInstanceId { get; }
- public string AdSourceInstanceName { get; }
- public string AdSourceName { get; }
- public System.Collections.Generic.Dictionary<string, string> AdUnitMapping { get; }
- public long LatencyMillis { get; }

### public interface GoogleMobileAds.Common.IAdErrorClient

#### Methods
- public GoogleMobileAds.Common.IAdErrorClient GetCause()
- public int GetCode()
- public string GetDomain()
- public string GetMessage()

### public interface GoogleMobileAds.Common.IAdInspectorErrorClient
- Interfaces: GoogleMobileAds.Common.IAdErrorClient

### public interface GoogleMobileAds.Common.IAdManagerBannerClient
- Interfaces: GoogleMobileAds.Common.IBannerClient

#### Properties
- public System.Collections.Generic.List<GoogleMobileAds.Api.AdSize> ValidAdSizes { get; set; }

#### Events
- public event System.Action<GoogleMobileAds.Api.AdManager.AppEvent> OnAppEvent

### public interface GoogleMobileAds.Common.IAdManagerInterstitialClient
- Interfaces: GoogleMobileAds.Common.IInterstitialClient

#### Events
- public event System.Action<GoogleMobileAds.Api.AdManager.AppEvent> OnAppEvent

#### Methods
- public GoogleMobileAds.Common.IAdManagerInterstitialClient PollAdManagerAd(string adUnitId)

### public interface GoogleMobileAds.Common.IApplicationPreferencesClient

#### Methods
- public int GetInt(string key)
- public string GetString(string key)
- public void SetInt(string key, int value)
- public void SetString(string key, string value)

### public interface GoogleMobileAds.Common.IAppOpenAdClient

#### Events
- public event System.Action OnAdClicked
- public event System.EventHandler<System.EventArgs> OnAdDidDismissFullScreenContent
- public event System.EventHandler<System.EventArgs> OnAdDidPresentFullScreenContent
- public event System.EventHandler<System.EventArgs> OnAdDidRecordImpression
- public event System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad
- public event System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> OnAdFailedToPresentFullScreenContent
- public event System.EventHandler<System.EventArgs> OnAdLoaded
- public event System.Action<GoogleMobileAds.Api.AdValue> OnPaidEvent

#### Methods
- public void CreateAppOpenAd()
- public void DestroyAppOpenAd()
- public string GetAdUnitID()
- public GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient()
- public bool IsAdAvailable(string adUnitId)
- public void LoadAd(string adUnitID, GoogleMobileAds.Api.AdRequest request)
- public GoogleMobileAds.Common.IAppOpenAdClient PollAd(string adUnitId)
- public void Show()

### public interface GoogleMobileAds.Common.IAppStateEventClient

#### Events
- public event System.Action<GoogleMobileAds.Common.AppState> AppStateChanged

### public interface GoogleMobileAds.Common.IBannerClient

#### Events
- public event System.Action OnAdClicked
- public event System.EventHandler<System.EventArgs> OnAdClosed
- public event System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad
- public event System.Action OnAdImpressionRecorded
- public event System.EventHandler<System.EventArgs> OnAdLoaded
- public event System.EventHandler<System.EventArgs> OnAdOpening
- public event System.Action<GoogleMobileAds.Api.AdValue> OnPaidEvent

#### Methods
- public void CreateBannerView(string adUnitId, GoogleMobileAds.Api.AdSize adSize, GoogleMobileAds.Api.AdPosition position)
- public void CreateBannerView(string adUnitId, GoogleMobileAds.Api.AdSize adSize, int x, int y)
- public void DestroyBannerView()
- public string GetAdUnitID()
- public float GetHeightInPixels()
- public GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient()
- public float GetWidthInPixels()
- public void HideBannerView()
- public bool IsCollapsible()
- public void LoadAd(GoogleMobileAds.Api.AdRequest request)
- public void SetPosition(GoogleMobileAds.Api.AdPosition adPosition)
- public void SetPosition(int x, int y)
- public void ShowBannerView()

### public interface GoogleMobileAds.Common.IInitializationStatusClient

#### Methods
- public GoogleMobileAds.Api.AdapterStatus getAdapterStatusForClassName(string className)
- public System.Collections.Generic.Dictionary<string, GoogleMobileAds.Api.AdapterStatus> getAdapterStatusMap()

### public interface GoogleMobileAds.Common.IInterstitialClient

#### Events
- public event System.Action OnAdClicked
- public event System.EventHandler<System.EventArgs> OnAdDidDismissFullScreenContent
- public event System.EventHandler<System.EventArgs> OnAdDidPresentFullScreenContent
- public event System.EventHandler<System.EventArgs> OnAdDidRecordImpression
- public event System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad
- public event System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> OnAdFailedToPresentFullScreenContent
- public event System.EventHandler<System.EventArgs> OnAdLoaded
- public event System.Action<GoogleMobileAds.Api.AdValue> OnPaidEvent

#### Methods
- public void CreateInterstitialAd()
- public void DestroyInterstitial()
- public string GetAdUnitID()
- public GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient()
- public bool IsAdAvailable(string adUnitId)
- public void LoadAd(string adUnitID, GoogleMobileAds.Api.AdRequest request)
- public GoogleMobileAds.Common.IInterstitialClient PollAd(string adUnitId)
- public void Show()

### public interface GoogleMobileAds.Common.ILoadAdErrorClient
- Interfaces: GoogleMobileAds.Common.IAdErrorClient

#### Methods
- public GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient()

### public interface GoogleMobileAds.Common.IMobileAdsClient

#### Methods
- public void DisableMediationInitialization()
- public void DisableSDKCrashReporting()
- public int GetDeviceSafeWidth()
- public float GetDeviceScale()
- public GoogleMobileAds.Api.RequestConfiguration GetRequestConfiguration()
- public System.Version GetSDKVersion()
- public void Initialize(System.Action<GoogleMobileAds.Common.IInitializationStatusClient> initCompleteAction)
- public void OpenAdInspector(System.Action<GoogleMobileAds.Common.AdInspectorErrorClientEventArgs> adInspectorClosedAction)
- public void Preload(System.Collections.Generic.List<GoogleMobileAds.Api.PreloadConfiguration> configurations, System.Action<GoogleMobileAds.Api.PreloadConfiguration> onAdAvailable, System.Action<GoogleMobileAds.Api.PreloadConfiguration> onAdsExhausted)
- public void SetApplicationMuted(bool muted)
- public void SetApplicationVolume(float volume)
- public void SetiOSAppPauseOnBackground(bool pause)
- public void SetRequestConfiguration(GoogleMobileAds.Api.RequestConfiguration requestConfiguration)

### public interface GoogleMobileAds.Common.INativeOverlayAdClient

#### Events
- public event System.Action OnAdClicked
- public event System.EventHandler<System.EventArgs> OnAdDidDismissFullScreenContent
- public event System.EventHandler<System.EventArgs> OnAdDidPresentFullScreenContent
- public event System.EventHandler<System.EventArgs> OnAdDidRecordImpression
- public event System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad
- public event System.EventHandler<System.EventArgs> OnAdLoaded
- public event System.Action<GoogleMobileAds.Api.AdValue> OnPaidEvent

#### Methods
- public void DestroyAd()
- public float GetHeightInPixels()
- public GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient()
- public float GetWidthInPixels()
- public void Hide()
- public void Load(string adUnitId, GoogleMobileAds.Api.AdRequest request, GoogleMobileAds.Api.NativeAdOptions nativeOptions)
- public void Render(GoogleMobileAds.Api.NativeTemplateStyle templateViewStyle, GoogleMobileAds.Api.AdSize adSize, GoogleMobileAds.Api.AdPosition adPosition)
- public void Render(GoogleMobileAds.Api.NativeTemplateStyle templateViewStyle, GoogleMobileAds.Api.AdSize adSize, int x, int y)
- public void Render(GoogleMobileAds.Api.NativeTemplateStyle templateViewStyle, GoogleMobileAds.Api.AdPosition adPosition)
- public void Render(GoogleMobileAds.Api.NativeTemplateStyle templateViewStyle, int x, int y)
- public void SetPosition(GoogleMobileAds.Api.AdPosition adPosition)
- public void SetPosition(int x, int y)
- public void Show()

### public interface GoogleMobileAds.Common.IResponseInfoClient

#### Methods
- public System.Collections.Generic.List<GoogleMobileAds.Common.IAdapterResponseInfoClient> GetAdapterResponses()
- public GoogleMobileAds.Common.IAdapterResponseInfoClient GetLoadedAdapterResponseInfo()
- public string GetMediationAdapterClassName()
- public System.Collections.Generic.Dictionary<string, string> GetResponseExtras()
- public string GetResponseId()

### public interface GoogleMobileAds.Common.IRewardedAdClient

#### Events
- public event System.Action OnAdClicked
- public event System.EventHandler<System.EventArgs> OnAdDidDismissFullScreenContent
- public event System.EventHandler<System.EventArgs> OnAdDidPresentFullScreenContent
- public event System.EventHandler<System.EventArgs> OnAdDidRecordImpression
- public event System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad
- public event System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> OnAdFailedToPresentFullScreenContent
- public event System.EventHandler<System.EventArgs> OnAdLoaded
- public event System.Action<GoogleMobileAds.Api.AdValue> OnPaidEvent
- public event System.EventHandler<GoogleMobileAds.Api.Reward> OnUserEarnedReward

#### Methods
- public void CreateRewardedAd()
- public void DestroyRewardedAd()
- public string GetAdUnitID()
- public GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient()
- public GoogleMobileAds.Api.Reward GetRewardItem()
- public bool IsAdAvailable(string adUnitId)
- public void LoadAd(string adUnitID, GoogleMobileAds.Api.AdRequest request)
- public GoogleMobileAds.Common.IRewardedAdClient PollAd(string adUnitId)
- public void SetServerSideVerificationOptions(GoogleMobileAds.Api.ServerSideVerificationOptions serverSideVerificationOptions)
- public void Show()

### public interface GoogleMobileAds.Common.IRewardedInterstitialAdClient

#### Events
- public event System.Action OnAdClicked
- public event System.EventHandler<System.EventArgs> OnAdDidDismissFullScreenContent
- public event System.EventHandler<System.EventArgs> OnAdDidPresentFullScreenContent
- public event System.EventHandler<System.EventArgs> OnAdDidRecordImpression
- public event System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad
- public event System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> OnAdFailedToPresentFullScreenContent
- public event System.EventHandler<System.EventArgs> OnAdLoaded
- public event System.Action<GoogleMobileAds.Api.AdValue> OnPaidEvent
- public event System.EventHandler<GoogleMobileAds.Api.Reward> OnUserEarnedReward

#### Methods
- public void CreateRewardedInterstitialAd()
- public void DestroyRewardedInterstitialAd()
- public string GetAdUnitID()
- public GoogleMobileAds.Common.IResponseInfoClient GetResponseInfoClient()
- public GoogleMobileAds.Api.Reward GetRewardItem()
- public void LoadAd(string adUnitID, GoogleMobileAds.Api.AdRequest request)
- public void SetServerSideVerificationOptions(GoogleMobileAds.Api.ServerSideVerificationOptions serverSideVerificationOptions)
- public void Show()

### public class GoogleMobileAds.Common.LoadAdErrorClientEventArgs
- Base: System.EventArgs

#### Fields
- private GoogleMobileAds.Common.ILoadAdErrorClient <LoadAdErrorClient>k__BackingField

#### Properties
- public GoogleMobileAds.Common.ILoadAdErrorClient LoadAdErrorClient { get; set; }

#### Constructors
- public LoadAdErrorClientEventArgs()

### public class GoogleMobileAds.Common.MobileAdsEventExecutor
- Base: UnityEngine.MonoBehaviour

#### Fields
- private static System.Collections.Generic.List<System.Action> adEventsQueue
- private static bool adEventsQueueEmpty
- public static GoogleMobileAds.Common.MobileAdsEventExecutor instance

#### Constructors
- public MobileAdsEventExecutor()
- private static MobileAdsEventExecutor()

#### Methods
- public void Awake()
- public static void ExecuteInUpdate(System.Action action)
- public static void Initialize()
- public static void InvokeInUpdate(UnityEngine.Events.UnityEvent eventParam)
- public static bool IsActive()
- public void OnDisable()
- public void Update()

### public enum GoogleMobileAds.Common.ResponseInfoClientType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AdError = 2
- AdLoaded = 1

### internal class GoogleMobileAds.Common.Utils

#### Constructors
- public Utils()

#### Methods
- public static void CheckInitialization()
- public static UnityEngine.Texture2D GetTexture2DFromByteArray(byte[] img)

