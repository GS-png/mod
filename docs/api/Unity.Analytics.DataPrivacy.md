# Assembly: Unity.Analytics.DataPrivacy
- Path: tools/WorldBox.Managed/Unity.Analytics.DataPrivacy.dll
- Types: 10

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=181 436E0C2BD86B343D78951243DE151E8F5B369F096F297064285DB0CEA8FE54FB
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=170 632FEA91C8DD5506546E372F906B29B0657C911EABEFF14EFAB56CF6F83A5E9A

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=170

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=181

## Namespace: UnityEngine.Analytics

### private class UnityEngine.Analytics.DataPrivacy.<>c__DisplayClass9_0

#### Fields
- public System.Action<string> failure
- public System.Action<string> success
- public UnityEngine.Networking.UnityWebRequest www

#### Constructors
- public DataPrivacy.<>c__DisplayClass9_0()

#### Methods
- internal void <FetchPrivacyUrl>b__0(UnityEngine.AsyncOperation async2)

### public class UnityEngine.Analytics.DataPrivacy

#### Fields
- internal static const string kBaseUrl
- private static const string kTokenUrl
- private static const string kVersion
- private static const string kVersionString

#### Constructors
- public DataPrivacy()

#### Methods
- public static void FetchPrivacyUrl(System.Action<string> success, System.Action<string> failure = null)
- private static string getErrorString(UnityEngine.Networking.UnityWebRequest www)
- private static string GetUserAgent()
- internal static UnityEngine.Analytics.DataPrivacy.UserPostData GetUserData()

### public class UnityEngine.Analytics.DataPrivacyButton
- Base: UnityEngine.UI.Button
- Interfaces: UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.ISubmitHandler

#### Fields
- private bool urlOpened

#### Constructors
- private DataPrivacyButton()

#### Methods
- private void OnApplicationFocus(bool hasFocus)
- private void OnFailure(string reason)
- private void OpenDataPrivacyUrl()
- private void OpenUrl(string url)

### internal struct UnityEngine.Analytics.DataPrivacy.TokenData

#### Fields
- public string token
- public string url

### internal struct UnityEngine.Analytics.DataPrivacy.UserPostData

#### Fields
- public string appid
- public bool debug_device
- public string deviceid
- public string platform
- public uint platformid
- public string plugin_ver
- public string sdk_ver
- public long sessionid
- public string userid

