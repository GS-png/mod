# Assembly: GoogleMobileAds.Ump
- Path: tools/WorldBox.Managed/GoogleMobileAds.Ump.dll
- Types: 22

## Namespace: GoogleMobileAds.Ump.Api

### private class GoogleMobileAds.Ump.Api.ConsentForm.<Load>c__AnonStorey0

#### Fields
- internal GoogleMobileAds.Ump.Common.IConsentFormClient client
- internal System.Action<GoogleMobileAds.Ump.Api.ConsentForm, GoogleMobileAds.Ump.Api.FormError> formLoadCallback

#### Constructors
- public ConsentForm.<Load>c__AnonStorey0()

#### Methods
- internal void <>m__0()
- internal void <>m__1(GoogleMobileAds.Ump.Api.FormError error)
- internal void <>m__2()

### private class GoogleMobileAds.Ump.Api.ConsentForm.<Load>c__AnonStorey0.<Load>c__AnonStorey1

#### Fields
- internal GoogleMobileAds.Ump.Api.ConsentForm.<Load>c__AnonStorey0 <>f__ref$0
- internal GoogleMobileAds.Ump.Api.FormError error

#### Constructors
- public ConsentForm.<Load>c__AnonStorey0.<Load>c__AnonStorey1()

#### Methods
- internal void <>m__0()

### private class GoogleMobileAds.Ump.Api.ConsentForm.<LoadAndShowConsentFormIfRequired>c__AnonStorey4

#### Fields
- internal System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed

#### Constructors
- public ConsentForm.<LoadAndShowConsentFormIfRequired>c__AnonStorey4()

#### Methods
- internal void <>m__0(GoogleMobileAds.Ump.Api.FormError error)

### private class GoogleMobileAds.Ump.Api.ConsentForm.<LoadAndShowConsentFormIfRequired>c__AnonStorey4.<LoadAndShowConsentFormIfRequired>c__AnonStorey5

#### Fields
- internal GoogleMobileAds.Ump.Api.ConsentForm.<LoadAndShowConsentFormIfRequired>c__AnonStorey4 <>f__ref$4
- internal GoogleMobileAds.Ump.Api.FormError error

#### Constructors
- public ConsentForm.<LoadAndShowConsentFormIfRequired>c__AnonStorey4.<LoadAndShowConsentFormIfRequired>c__AnonStorey5()

#### Methods
- internal void <>m__0()

### private class GoogleMobileAds.Ump.Api.ConsentForm.<Show>c__AnonStorey2

#### Fields
- internal System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed

#### Constructors
- public ConsentForm.<Show>c__AnonStorey2()

#### Methods
- internal void <>m__0(GoogleMobileAds.Ump.Api.FormError error)

### private class GoogleMobileAds.Ump.Api.ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3

#### Fields
- internal GoogleMobileAds.Ump.Api.ConsentForm.<Show>c__AnonStorey2 <>f__ref$2
- internal GoogleMobileAds.Ump.Api.FormError error

#### Constructors
- public ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3()

#### Methods
- internal void <>m__0()

### private class GoogleMobileAds.Ump.Api.ConsentForm.<ShowPrivacyOptionsForm>c__AnonStorey6

#### Fields
- internal System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed

#### Constructors
- public ConsentForm.<ShowPrivacyOptionsForm>c__AnonStorey6()

#### Methods
- internal void <>m__0(GoogleMobileAds.Ump.Api.FormError error)

### private class GoogleMobileAds.Ump.Api.ConsentForm.<ShowPrivacyOptionsForm>c__AnonStorey6.<ShowPrivacyOptionsForm>c__AnonStorey7

#### Fields
- internal GoogleMobileAds.Ump.Api.ConsentForm.<ShowPrivacyOptionsForm>c__AnonStorey6 <>f__ref$6
- internal GoogleMobileAds.Ump.Api.FormError error

#### Constructors
- public ConsentForm.<ShowPrivacyOptionsForm>c__AnonStorey6.<ShowPrivacyOptionsForm>c__AnonStorey7()

#### Methods
- internal void <>m__0()

### private class GoogleMobileAds.Ump.Api.ConsentInformation.<Update>c__AnonStorey0

#### Fields
- internal System.Action<GoogleMobileAds.Ump.Api.FormError> consentInfoUpdateCallback

#### Constructors
- public ConsentInformation.<Update>c__AnonStorey0()

#### Methods
- internal void <>m__0()
- internal void <>m__1(GoogleMobileAds.Ump.Api.FormError error)
- internal void <>m__2()

### private class GoogleMobileAds.Ump.Api.ConsentInformation.<Update>c__AnonStorey0.<Update>c__AnonStorey1

#### Fields
- internal GoogleMobileAds.Ump.Api.ConsentInformation.<Update>c__AnonStorey0 <>f__ref$0
- internal GoogleMobileAds.Ump.Api.FormError error

#### Constructors
- public ConsentInformation.<Update>c__AnonStorey0.<Update>c__AnonStorey1()

#### Methods
- internal void <>m__0()

### public class GoogleMobileAds.Ump.Api.ConsentDebugSettings

#### Fields
- public GoogleMobileAds.Ump.Api.DebugGeography DebugGeography
- public System.Collections.Generic.List<string> TestDeviceHashedIds

#### Constructors
- public ConsentDebugSettings()

### public class GoogleMobileAds.Ump.Api.ConsentForm

#### Fields
- private GoogleMobileAds.Ump.Common.IConsentFormClient _client

#### Constructors
- internal ConsentForm(GoogleMobileAds.Ump.Common.IConsentFormClient client)

#### Methods
- public static void Load(System.Action<GoogleMobileAds.Ump.Api.ConsentForm, GoogleMobileAds.Ump.Api.FormError> formLoadCallback)
- public static void LoadAndShowConsentFormIfRequired(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed)
- public void Show(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed)
- public static void ShowPrivacyOptionsForm(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed)

### public class GoogleMobileAds.Ump.Api.ConsentInformation

#### Fields
- private static GoogleMobileAds.Ump.Common.IUmpClientFactory _clientFactory

#### Properties
- internal static GoogleMobileAds.Ump.Common.IUmpClientFactory ClientFactory { get; set; }
- public static GoogleMobileAds.Ump.Api.ConsentStatus ConsentStatus { get; }
- public static GoogleMobileAds.Ump.Api.PrivacyOptionsRequirementStatus PrivacyOptionsRequirementStatus { get; }

#### Constructors
- public ConsentInformation()

#### Methods
- public static bool CanRequestAds()
- public static bool IsConsentFormAvailable()
- public static void Reset()
- public static void Update(GoogleMobileAds.Ump.Api.ConsentRequestParameters request, System.Action<GoogleMobileAds.Ump.Api.FormError> consentInfoUpdateCallback)

### public class GoogleMobileAds.Ump.Api.ConsentRequestParameters

#### Fields
- public GoogleMobileAds.Ump.Api.ConsentDebugSettings ConsentDebugSettings
- public bool TagForUnderAgeOfConsent

#### Constructors
- public ConsentRequestParameters()

### public enum GoogleMobileAds.Ump.Api.ConsentStatus
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- NotRequired = 1
- Obtained = 3
- Required = 2
- Unknown = 0

### public enum GoogleMobileAds.Ump.Api.DebugGeography
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Disabled = 0
- EEA = 1
- NotEEA = 2
- Other = 4
- RegulatedUSState = 3

### public class GoogleMobileAds.Ump.Api.FormError

#### Fields
- private int <ErrorCode>k__BackingField
- private string <Message>k__BackingField

#### Properties
- public int ErrorCode { get; private set; }
- public string Message { get; private set; }

#### Constructors
- internal FormError(int errorCode, string message)

### public enum GoogleMobileAds.Ump.Api.PrivacyOptionsRequirementStatus
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- NotRequired = 1
- Required = 2
- Unknown = 0

### internal class GoogleMobileAds.Ump.Api.Utils

#### Constructors
- public Utils()

#### Methods
- internal static GoogleMobileAds.Ump.Common.IUmpClientFactory GetClientFactory()

## Namespace: GoogleMobileAds.Ump.Common

### public interface GoogleMobileAds.Ump.Common.IConsentFormClient

#### Methods
- public void Load(System.Action onFormLoaded, System.Action<GoogleMobileAds.Ump.Api.FormError> onError)
- public void LoadAndShowConsentFormIfRequired(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed)
- public void Show(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed)
- public void ShowPrivacyOptionsForm(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed)

### public interface GoogleMobileAds.Ump.Common.IConsentInformationClient

#### Methods
- public bool CanRequestAds()
- public int GetConsentStatus()
- public int GetPrivacyOptionsRequirementStatus()
- public bool IsConsentFormAvailable()
- public void Reset()
- public void Update(GoogleMobileAds.Ump.Api.ConsentRequestParameters consentRequestParameters, System.Action onConsentInfoUpdateSuccessCallback, System.Action<GoogleMobileAds.Ump.Api.FormError> onConsentInfoUpdateFailureCallback)

### public interface GoogleMobileAds.Ump.Common.IUmpClientFactory

#### Methods
- public GoogleMobileAds.Ump.Common.IConsentFormClient ConsentFormClient()
- public GoogleMobileAds.Ump.Common.IConsentInformationClient ConsentInformationClient()

