# Assembly: Unity.Analytics.StandardEvents
- Path: tools/WorldBox.Managed/Unity.Analytics.StandardEvents.dll
- Types: 52

## Namespace: UnityEngine.Analytics

### public struct UnityEngine.Analytics.AchievementStep

#### Fields
- public string achievementId
- public int stepIndex

### public struct UnityEngine.Analytics.AchievementUnlocked

#### Fields
- public string achievementId

### public enum UnityEngine.Analytics.AcquisitionSource
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Earned = 2
- Gift = 4
- None = 0
- Promotion = 3
- RewardedAd = 5
- SocialReward = 7
- Store = 1
- TimedReward = 6

### public enum UnityEngine.Analytics.AcquisitionType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Premium = 1
- Soft = 0

### public struct UnityEngine.Analytics.AdComplete

#### Fields
- public UnityEngine.Analytics.AdvertisingNetwork network
- public string placementId
- public bool rewarded

### public struct UnityEngine.Analytics.AdOffer

#### Fields
- public UnityEngine.Analytics.AdvertisingNetwork network
- public string placementId
- public bool rewarded

### public struct UnityEngine.Analytics.AdSkip

#### Fields
- public UnityEngine.Analytics.AdvertisingNetwork network
- public string placementId
- public bool rewarded

### public struct UnityEngine.Analytics.AdStart

#### Fields
- public UnityEngine.Analytics.AdvertisingNetwork network
- public string placementId
- public bool rewarded

### public enum UnityEngine.Analytics.AdvertisingNetwork
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Aarki = 1
- AdAction = 2
- AdapTv = 3
- Adcash = 4
- AdColony = 5
- AdMob = 6
- AerServ = 7
- Airpush = 8
- Altrooz = 9
- Ampush = 10
- AppleSearch = 11
- AppLift = 12
- AppLovin = 13
- Appnext = 14
- AppNexus = 15
- Appoday = 16
- Appodeal = 17
- AppsUnion = 18
- Avazu = 19
- BlueStacks = 20
- Chartboost = 21
- ClickDealer = 22
- CPAlead = 23
- CrossChannel = 24
- CrossInstall = 25
- Epom = 26
- Facebook = 27
- Fetch = 28
- Fiksu = 29
- Flurry = 30
- Fuse = 31
- Fyber = 32
- Glispa = 33
- Google = 34
- GrowMobile = 35
- HeyZap = 36
- HyperMX = 37
- Iddiction = 38
- IndexExchange = 39
- InMobi = 40
- Instagram = 41
- Instal = 42
- Ipsos = 43
- IronSource = 44
- Jirbo = 45
- Kimia = 46
- Leadbolt = 47
- Liftoff = 48
- Manage = 49
- Matomy = 50
- MediaBrix = 51
- MillenialMedia = 52
- Minimob = 53
- MobAir = 54
- MobileCore = 55
- Mobobeat = 56
- Mobusi = 57
- Mobvista = 58
- MoPub = 59
- Motive = 60
- Msales = 61
- NativeX = 62
- None = 0
- OpenX = 63
- Pandora = 64
- PropellerAds = 65
- Revmob = 66
- RubiconProject = 67
- SiriusAd = 68
- Smaato = 69
- SponsorPay = 70
- SpotXchange = 71
- StartApp = 72
- Tapjoy = 73
- Taptica = 74
- Tremor = 75
- TrialPay = 76
- Twitter = 77
- UnityAds = 78
- Vungle = 79
- Yeahmobi = 80
- YuMe = 81

### public static class UnityEngine.Analytics.AnalyticsEvent

#### Fields
- private static System.Collections.Generic.Dictionary<string, string> enumRenameTable
- private static readonly string k_SdkVersion
- private static readonly System.Collections.Generic.Dictionary<string, object> m_EventData
- private static System.Action<System.Collections.Generic.IDictionary<string, object>> s_StandardEventCallback
- private static bool _debugMode

#### Properties
- public static bool debugMode { get; set; }
- public static string sdkVersion { get; }

#### Constructors
- private static AnalyticsEvent()

#### Methods
- private static void <s_StandardEventCallback>m__0(System.Collections.Generic.IDictionary<string, object> )
- public static UnityEngine.Analytics.AnalyticsResult AchievementStep(int stepIndex, string achievementId, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult AchievementUnlocked(string achievementId, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult AdComplete(bool rewarded, UnityEngine.Analytics.AdvertisingNetwork network, string placementId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult AdComplete(bool rewarded, string network = null, string placementId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- private static void AddCustomEventData(System.Collections.Generic.IDictionary<string, object> eventData)
- public static UnityEngine.Analytics.AnalyticsResult AdOffer(bool rewarded, UnityEngine.Analytics.AdvertisingNetwork network, string placementId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult AdOffer(bool rewarded, string network = null, string placementId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult AdSkip(bool rewarded, UnityEngine.Analytics.AdvertisingNetwork network, string placementId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult AdSkip(bool rewarded, string network = null, string placementId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult AdStart(bool rewarded, UnityEngine.Analytics.AdvertisingNetwork network, string placementId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult AdStart(bool rewarded, string network = null, string placementId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult ChatMessageSent(System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult Custom(string eventName, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult CustomEvent(System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult CutsceneSkip(string name, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult CutsceneStart(string name, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult FirstInteraction(string actionId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult GameOver(int index, string name = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult GameOver(string name = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult GameStart(System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult IAPTransaction(string transactionContext, float price, string itemId, string itemType = null, string level = null, string transactionId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult ItemAcquired(UnityEngine.Analytics.AcquisitionType currencyType, string transactionContext, float amount, string itemId, float balance, string itemType = null, string level = null, string transactionId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult ItemAcquired(UnityEngine.Analytics.AcquisitionType currencyType, string transactionContext, float amount, string itemId, string itemType = null, string level = null, string transactionId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult ItemSpent(UnityEngine.Analytics.AcquisitionType currencyType, string transactionContext, float amount, string itemId, float balance, string itemType = null, string level = null, string transactionId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult ItemSpent(UnityEngine.Analytics.AcquisitionType currencyType, string transactionContext, float amount, string itemId, string itemType = null, string level = null, string transactionId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult LevelComplete(string name, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult LevelComplete(int index, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult LevelComplete(string name, int index, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult LevelFail(string name, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult LevelFail(int index, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult LevelFail(string name, int index, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult LevelQuit(string name, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult LevelQuit(int index, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult LevelQuit(string name, int index, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult LevelSkip(string name, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult LevelSkip(int index, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult LevelSkip(string name, int index, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult LevelStart(string name, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult LevelStart(int index, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult LevelStart(string name, int index, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult LevelUp(string name, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult LevelUp(int index, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult LevelUp(string name, int index, System.Collections.Generic.IDictionary<string, object> eventData = null)
- private static void OnValidationFailed(string message)
- public static UnityEngine.Analytics.AnalyticsResult PostAdAction(bool rewarded, UnityEngine.Analytics.AdvertisingNetwork network, string placementId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult PostAdAction(bool rewarded, string network = null, string placementId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult PushNotificationClick(string message_id, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult PushNotificationEnable(System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static void Register(System.Action<System.Collections.Generic.IDictionary<string, object>> action)
- private static string RenameEnum(string enumName)
- public static UnityEngine.Analytics.AnalyticsResult ScreenVisit(UnityEngine.Analytics.ScreenName screenName, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult ScreenVisit(string screenName, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult SocialShare(UnityEngine.Analytics.ShareType shareType, UnityEngine.Analytics.SocialNetwork socialNetwork, string senderId = null, string recipientId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult SocialShare(UnityEngine.Analytics.ShareType shareType, string socialNetwork, string senderId = null, string recipientId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult SocialShare(string shareType, UnityEngine.Analytics.SocialNetwork socialNetwork, string senderId = null, string recipientId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult SocialShare(string shareType, string socialNetwork, string senderId = null, string recipientId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult SocialShareAccept(UnityEngine.Analytics.ShareType shareType, UnityEngine.Analytics.SocialNetwork socialNetwork, string senderId = null, string recipientId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult SocialShareAccept(UnityEngine.Analytics.ShareType shareType, string socialNetwork, string senderId = null, string recipientId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult SocialShareAccept(string shareType, UnityEngine.Analytics.SocialNetwork socialNetwork, string senderId = null, string recipientId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult SocialShareAccept(string shareType, string socialNetwork, string senderId = null, string recipientId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult StoreItemClick(UnityEngine.Analytics.StoreType storeType, string itemId, string itemName = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult StoreOpened(UnityEngine.Analytics.StoreType storeType, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult TutorialComplete(string tutorialId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult TutorialSkip(string tutorialId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult TutorialStart(string tutorialId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult TutorialStep(int stepIndex, string tutorialId = null, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static void Unregister(System.Action<System.Collections.Generic.IDictionary<string, object>> action)
- public static UnityEngine.Analytics.AnalyticsResult UserSignup(UnityEngine.Analytics.AuthorizationNetwork authorizationNetwork, System.Collections.Generic.IDictionary<string, object> eventData = null)
- public static UnityEngine.Analytics.AnalyticsResult UserSignup(string authorizationNetwork, System.Collections.Generic.IDictionary<string, object> eventData = null)

### public class UnityEngine.Analytics.AnalyticsEventAttribute
- Base: System.Attribute

#### Constructors
- public AnalyticsEventAttribute()

### public class UnityEngine.Analytics.AnalyticsEventParameter
- Base: UnityEngine.Analytics.AnalyticsEventAttribute

#### Fields
- public string groupId
- public string sendName
- public string tooltip

#### Constructors
- public AnalyticsEventParameter(string sendName, string tooltip, string groupId = null)

### public enum UnityEngine.Analytics.AuthorizationNetwork
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Facebook = 2
- GameCenter = 5
- Google = 4
- Internal = 1
- None = 0
- Twitter = 3

### public struct UnityEngine.Analytics.ChatMessageSent

### public struct UnityEngine.Analytics.CustomEvent

### public class UnityEngine.Analytics.CustomizableEnum
- Base: UnityEngine.Analytics.AnalyticsEventAttribute

#### Fields
- public bool Customizable

#### Constructors
- public CustomizableEnum(bool customizable)

### public struct UnityEngine.Analytics.CutsceneSkip

#### Fields
- public string name

### public struct UnityEngine.Analytics.CutsceneStart

#### Fields
- public string name

### public class UnityEngine.Analytics.EnumCase
- Base: UnityEngine.Analytics.AnalyticsEventAttribute

#### Fields
- public UnityEngine.Analytics.EnumCase.Styles Style

#### Constructors
- public EnumCase(UnityEngine.Analytics.EnumCase.Styles style)

### public struct UnityEngine.Analytics.FirstInteraction

#### Fields
- public string actionId

### public struct UnityEngine.Analytics.GameOver

#### Fields
- public int index
- public string name

### public struct UnityEngine.Analytics.GameStart

### public struct UnityEngine.Analytics.IAPTransaction

#### Fields
- public string itemId
- public string itemType
- public string level
- public float price
- public string transactionContext
- public string transactionId

### public struct UnityEngine.Analytics.ItemAcquired

#### Fields
- public float amount
- public float balance
- public UnityEngine.Analytics.AcquisitionType currencyType
- public string itemId
- public string itemType
- public string level
- public string transactionContext
- public string transactionId

### public struct UnityEngine.Analytics.ItemSpent

#### Fields
- public float amount
- public float balance
- public UnityEngine.Analytics.AcquisitionType currencyType
- public string itemId
- public string itemType
- public string level
- public string transactionContext
- public string transactionId

### public struct UnityEngine.Analytics.LevelComplete

#### Fields
- public int index
- public string name

### public struct UnityEngine.Analytics.LevelFail

#### Fields
- public int index
- public string name

### public struct UnityEngine.Analytics.LevelQuit

#### Fields
- public int index
- public string name

### public struct UnityEngine.Analytics.LevelSkip

#### Fields
- public int index
- public string name

### public struct UnityEngine.Analytics.LevelStart

#### Fields
- public int index
- public string name

### public struct UnityEngine.Analytics.LevelUp

#### Fields
- public int index
- public string name

### public class UnityEngine.Analytics.OptionalParameter
- Base: UnityEngine.Analytics.AnalyticsEventParameter

#### Constructors
- public OptionalParameter(string sendName, string tooltip)

### public struct UnityEngine.Analytics.PostAdAction

#### Fields
- public UnityEngine.Analytics.AdvertisingNetwork network
- public string placementId
- public bool rewarded

### public struct UnityEngine.Analytics.PushNotificationClick

#### Fields
- public string message_id

### public struct UnityEngine.Analytics.PushNotificationEnable

### public class UnityEngine.Analytics.RequiredParameter
- Base: UnityEngine.Analytics.AnalyticsEventParameter

#### Constructors
- public RequiredParameter(string sendName, string tooltip, string groupId = null)

### public enum UnityEngine.Analytics.ScreenName
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Achievements = 15
- Credits = 6
- CrossPromo = 9
- FeaturePromo = 10
- Hint = 11
- IAPPromo = 8
- Inventory = 13
- Leaderboard = 14
- Lobby = 16
- Lose = 4
- MainMenu = 1
- Map = 3
- None = 0
- Pause = 12
- Settings = 2
- Title = 7
- Win = 5

### public struct UnityEngine.Analytics.ScreenVisit

#### Fields
- public UnityEngine.Analytics.ScreenName screenName

### public enum UnityEngine.Analytics.ShareType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Achievement = 5
- Image = 2
- Invite = 4
- None = 0
- TextOnly = 1
- Video = 3

### public enum UnityEngine.Analytics.SocialNetwork
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Facebook = 1
- GooglePlus = 4
- Instagram = 3
- None = 0
- OK_ru = 12
- Pinterest = 5
- QQ = 9
- SinaWeibo = 7
- TencentWeibo = 8
- Twitter = 2
- VK = 11
- WeChat = 6
- Zhihu = 10

### public struct UnityEngine.Analytics.SocialShare

#### Fields
- public string recipientId
- public string senderId
- public UnityEngine.Analytics.ShareType shareType
- public UnityEngine.Analytics.SocialNetwork socialNetwork

### public struct UnityEngine.Analytics.SocialShareAccept

#### Fields
- public string recipientId
- public string senderId
- public UnityEngine.Analytics.ShareType shareType
- public UnityEngine.Analytics.SocialNetwork socialNetwork

### public class UnityEngine.Analytics.StandardEventName
- Base: UnityEngine.Analytics.AnalyticsEventAttribute

#### Fields
- public string path
- public string sendName
- public string tooltip

#### Constructors
- public StandardEventName(string sendName, string path, string tooltip)

### public struct UnityEngine.Analytics.StoreItemClick

#### Fields
- public string itemId
- public string itemName
- public UnityEngine.Analytics.StoreType storeType

### public struct UnityEngine.Analytics.StoreOpened

#### Fields
- public UnityEngine.Analytics.StoreType storeType

### public enum UnityEngine.Analytics.StoreType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Premium = 1
- Soft = 0

### public enum UnityEngine.Analytics.EnumCase.Styles
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Lower = 2
- None = 0
- Snake = 1

### public struct UnityEngine.Analytics.TutorialComplete

#### Fields
- public string tutorialId

### public struct UnityEngine.Analytics.TutorialSkip

#### Fields
- public string tutorialId

### public struct UnityEngine.Analytics.TutorialStart

#### Fields
- public string tutorialId

### public struct UnityEngine.Analytics.TutorialStep

#### Fields
- public int stepIndex
- public string tutorialId

### public struct UnityEngine.Analytics.UserSignup

#### Fields
- public UnityEngine.Analytics.AuthorizationNetwork authorizationNetwork

