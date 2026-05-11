# Assembly: GoogleMobileAds.Core
- Path: tools/WorldBox.Managed/GoogleMobileAds.Core.dll
- Types: 30

## Namespace: GoogleMobileAds.Api

### public enum GoogleMobileAds.Api.AdapterState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- NotReady = 0
- Ready = 1

### public class GoogleMobileAds.Api.AdapterStatus

#### Fields
- private string <Description>k__BackingField
- private GoogleMobileAds.Api.AdapterState <InitializationState>k__BackingField
- private int <Latency>k__BackingField

#### Properties
- public string Description { get; private set; }
- public GoogleMobileAds.Api.AdapterState InitializationState { get; private set; }
- public int Latency { get; private set; }

#### Constructors
- internal AdapterStatus(GoogleMobileAds.Api.AdapterState state, string description, int latency)

### public enum GoogleMobileAds.Api.AdChoicesPlacement
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BottomLeftCorner = 3
- BottomRightCorner = 2
- TopLeftCorner = 1
- TopRightCorner = 0

### public enum GoogleMobileAds.Api.AdFormat
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- APP_OPEN_AD = 5
- BANNER = 0
- INTERSTITIAL = 1
- NATIVE = 4
- REWARDED = 2
- REWARDED_INTERSTITIAL = 3

### public enum GoogleMobileAds.Api.AdPosition
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Bottom = 1
- BottomLeft = 4
- BottomRight = 5
- Center = 6
- Top = 0
- TopLeft = 2
- TopRight = 3

### public class GoogleMobileAds.Api.AdRequest

#### Fields
- private static string <Version>k__BackingField
- public System.Collections.Generic.Dictionary<string, string> CustomTargeting
- public System.Collections.Generic.Dictionary<string, string> Extras
- public System.Collections.Generic.HashSet<string> Keywords
- public System.Collections.Generic.List<GoogleMobileAds.Api.Mediation.MediationExtras> MediationExtras
- public static const string TestDeviceSimulator

#### Properties
- public static string Version { get; private set; }

#### Constructors
- private static AdRequest()
- public AdRequest()
- public AdRequest(GoogleMobileAds.Api.AdRequest request)

#### Methods
- internal static string BuildVersionString(string nativePluginVersion = null)

### public class GoogleMobileAds.Api.AdSize

#### Fields
- public static readonly GoogleMobileAds.Api.AdSize Banner
- public static readonly int FullWidth
- public static readonly GoogleMobileAds.Api.AdSize IABBanner
- public static readonly GoogleMobileAds.Api.AdSize Leaderboard
- public static readonly GoogleMobileAds.Api.AdSize MediumRectangle
- public static readonly GoogleMobileAds.Api.AdSize SmartBanner
- private int _height
- private GoogleMobileAds.Api.Orientation _orientation
- private GoogleMobileAds.Api.AdSize.Type _type
- private int _width

#### Properties
- public GoogleMobileAds.Api.AdSize.Type AdType { get; }
- public int Height { get; }
- internal GoogleMobileAds.Api.Orientation Orientation { get; }
- public int Width { get; }

#### Constructors
- private static AdSize()
- public AdSize(int width, int height)
- private AdSize(int width, int height, GoogleMobileAds.Api.AdSize.Type type)

#### Methods
- private static GoogleMobileAds.Api.AdSize CreateAnchoredAdaptiveAdSize(int width, GoogleMobileAds.Api.Orientation orientation)
- public override bool Equals(object obj)
- public static GoogleMobileAds.Api.AdSize GetCurrentOrientationAnchoredAdaptiveBannerAdSizeWithWidth(int width)
- public override int GetHashCode()
- public static GoogleMobileAds.Api.AdSize GetLandscapeAnchoredAdaptiveBannerAdSizeWithWidth(int width)
- public static GoogleMobileAds.Api.AdSize GetPortraitAnchoredAdaptiveBannerAdSizeWithWidth(int width)
- public static bool op_Equality(GoogleMobileAds.Api.AdSize a, GoogleMobileAds.Api.AdSize b)
- public static bool op_Inequality(GoogleMobileAds.Api.AdSize a, GoogleMobileAds.Api.AdSize b)

### public class GoogleMobileAds.Api.AdValue

#### Fields
- private string <CurrencyCode>k__BackingField
- private GoogleMobileAds.Api.AdValue.PrecisionType <Precision>k__BackingField
- private long <Value>k__BackingField

#### Properties
- public string CurrencyCode { get; set; }
- public GoogleMobileAds.Api.AdValue.PrecisionType Precision { get; set; }
- public long Value { get; set; }

#### Constructors
- public AdValue()

### public enum GoogleMobileAds.Api.Gender
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Female = 2
- Male = 1
- Unknown = 0

### public class GoogleMobileAds.Api.MaxAdContentRating

#### Fields
- private string <Value>k__BackingField

#### Properties
- public static GoogleMobileAds.Api.MaxAdContentRating G { get; }
- public static GoogleMobileAds.Api.MaxAdContentRating MA { get; }
- public static GoogleMobileAds.Api.MaxAdContentRating PG { get; }
- public static GoogleMobileAds.Api.MaxAdContentRating T { get; }
- public static GoogleMobileAds.Api.MaxAdContentRating Unspecified { get; }
- public string Value { get; set; }

#### Constructors
- private MaxAdContentRating(string value)

#### Methods
- public static GoogleMobileAds.Api.MaxAdContentRating ToMaxAdContentRating(string value)

### public enum GoogleMobileAds.Api.MediaAspectRatio
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Any = 1
- Landscape = 2
- Portrait = 3
- Square = 4
- Unknown = 0

### public class GoogleMobileAds.Api.NativeAdOptions

#### Fields
- public GoogleMobileAds.Api.AdChoicesPlacement AdChoicesPlacement
- public GoogleMobileAds.Api.MediaAspectRatio MediaAspectRatio
- public GoogleMobileAds.Api.VideoOptions VideoOptions

#### Constructors
- public NativeAdOptions()
- public NativeAdOptions(GoogleMobileAds.Api.NativeAdOptions options)

### public enum GoogleMobileAds.Api.NativeTemplateFontStyle
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Bold = 1
- Italic = 2
- Monospace = 3
- Normal = 0

### public class GoogleMobileAds.Api.NativeTemplateId

#### Fields
- public static const string Medium
- public static const string Small

#### Constructors
- public NativeTemplateId()

### public class GoogleMobileAds.Api.NativeTemplateStyle

#### Fields
- public GoogleMobileAds.Api.NativeTemplateTextStyle CallToActionText
- public UnityEngine.Color MainBackgroundColor
- public GoogleMobileAds.Api.NativeTemplateTextStyle PrimaryText
- public GoogleMobileAds.Api.NativeTemplateTextStyle SecondaryText
- public string TemplateId
- public GoogleMobileAds.Api.NativeTemplateTextStyle TertiaryText

#### Constructors
- public NativeTemplateStyle()
- public NativeTemplateStyle(GoogleMobileAds.Api.NativeTemplateStyle templateStyle)

### public class GoogleMobileAds.Api.NativeTemplateTextStyle

#### Fields
- private UnityEngine.Color <BackgroundColor>k__BackingField
- private int <FontSize>k__BackingField
- private GoogleMobileAds.Api.NativeTemplateFontStyle <Style>k__BackingField
- private UnityEngine.Color <TextColor>k__BackingField

#### Properties
- public UnityEngine.Color BackgroundColor { get; set; }
- public int FontSize { get; set; }
- public GoogleMobileAds.Api.NativeTemplateFontStyle Style { get; set; }
- public UnityEngine.Color TextColor { get; set; }

#### Constructors
- public NativeTemplateTextStyle()

### internal enum GoogleMobileAds.Api.Orientation
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Current = 0
- Landscape = 1
- Portrait = 2

### public enum GoogleMobileAds.Api.AdValue.PrecisionType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Estimated = 1
- Precise = 3
- PublisherProvided = 2
- Unknown = 0

### public class GoogleMobileAds.Api.PreloadConfiguration

#### Fields
- public string AdUnitId
- public uint BufferSize
- public GoogleMobileAds.Api.AdFormat Format
- public GoogleMobileAds.Api.AdRequest Request

#### Constructors
- public PreloadConfiguration()
- public PreloadConfiguration(GoogleMobileAds.Api.PreloadConfiguration configuration)

### public enum GoogleMobileAds.Api.PublisherPrivacyPersonalizationState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Default = 0
- Disabled = 2
- Enabled = 1

### public class GoogleMobileAds.Api.RequestConfiguration

#### Fields
- public GoogleMobileAds.Api.MaxAdContentRating MaxAdContentRating
- public System.Nullable<bool> PublisherFirstPartyIdEnabled
- public System.Nullable<GoogleMobileAds.Api.PublisherPrivacyPersonalizationState> PublisherPrivacyPersonalizationState
- public System.Nullable<GoogleMobileAds.Api.TagForChildDirectedTreatment> TagForChildDirectedTreatment
- public System.Nullable<GoogleMobileAds.Api.TagForUnderAgeOfConsent> TagForUnderAgeOfConsent
- public System.Collections.Generic.List<string> TestDeviceIds

#### Constructors
- public RequestConfiguration()
- public RequestConfiguration(GoogleMobileAds.Api.RequestConfiguration requestConfiguration)

### public class GoogleMobileAds.Api.Reward
- Base: System.EventArgs

#### Fields
- public double Amount
- public string Type

#### Constructors
- public Reward()
- public Reward(GoogleMobileAds.Api.Reward reward)

### public class GoogleMobileAds.Api.ServerSideVerificationOptions

#### Fields
- public string CustomData
- public string UserId

#### Constructors
- public ServerSideVerificationOptions()
- public ServerSideVerificationOptions(GoogleMobileAds.Api.ServerSideVerificationOptions options)

### public enum GoogleMobileAds.Api.TagForChildDirectedTreatment
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- False = 0
- True = 1
- Unspecified = -1

### public enum GoogleMobileAds.Api.TagForUnderAgeOfConsent
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- False = 0
- True = 1
- Unspecified = -1

### public enum GoogleMobileAds.Api.AdSize.Type
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AnchoredAdaptive = 2
- SmartBanner = 1
- Standard = 0

### public class GoogleMobileAds.Api.VideoOptions

#### Fields
- public bool ClickToExpandRequested
- public bool CustomControlsRequested
- public bool StartMuted

#### Constructors
- public VideoOptions()

## Namespace: GoogleMobileAds.Api.AdManager

### public class GoogleMobileAds.Api.AdManager.AdManagerAdRequest
- Base: GoogleMobileAds.Api.AdRequest

#### Fields
- public System.Collections.Generic.HashSet<string> CategoryExclusions
- public string PublisherProvidedId

#### Constructors
- public AdManagerAdRequest()
- public AdManagerAdRequest(GoogleMobileAds.Api.AdManager.AdManagerAdRequest request)

### public class GoogleMobileAds.Api.AdManager.AppEvent

#### Fields
- private string <Data>k__BackingField
- private string <Name>k__BackingField

#### Properties
- public string Data { get; set; }
- public string Name { get; set; }

#### Constructors
- public AppEvent()

## Namespace: GoogleMobileAds.Api.Mediation

### public class GoogleMobileAds.Api.Mediation.MediationExtras

#### Fields
- private System.Collections.Generic.Dictionary<string, string> <Extras>k__BackingField

#### Properties
- public string AndroidMediationExtraBuilderClassName { get; }
- public System.Collections.Generic.Dictionary<string, string> Extras { get; protected set; }
- public string IOSMediationExtraBuilderClassName { get; }

#### Constructors
- public MediationExtras()

