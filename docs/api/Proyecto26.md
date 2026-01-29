# Assembly: Proyecto26
- Path: tools/WorldBox.Managed/Proyecto26.dll
- Types: 22

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=972 DF70F40DE9A007E6B3FE6A22B27B077F6706F9F19468A0DFC4CAC6E0CA596027
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=438 FA83B7D84A703C4BE6153A9D3215D1F076E89C34D857FC46824A782765A86F4E

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=438

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=972

## Namespace: Proyecto26

### private class Proyecto26.HttpBase.<>c__DisplayClass6_0<TResponse>

#### Fields
- public System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper, TResponse> callback
- public Proyecto26.RequestHelper options

#### Constructors
- public HttpBase.<>c__DisplayClass6_0<TResponse>()

#### Methods
- internal void <DefaultUnityWebRequest>b__0(Proyecto26.RequestException err, Proyecto26.ResponseHelper res)

### private class Proyecto26.HttpBase.<>c__DisplayClass7_0<TResponse>

#### Fields
- public System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper, TResponse[]> callback
- public Proyecto26.RequestHelper options

#### Constructors
- public HttpBase.<>c__DisplayClass7_0<TResponse>()

#### Methods
- internal void <DefaultUnityWebRequest>b__0(Proyecto26.RequestException err, Proyecto26.ResponseHelper res)

### private class Proyecto26.HttpBase.<CreateRequestAndRetry>d__1
- Interfaces: System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- private bool <IsNetworkError>5__4
- private UnityEngine.Networking.UnityWebRequest <request>5__3
- private int <retries>5__2
- private UnityEngine.AsyncOperation <sendRequest>5__5
- public System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper> callback
- public Proyecto26.RequestHelper options

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public HttpBase.<CreateRequestAndRetry>d__1(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class Proyecto26.StaticCoroutine.CoroutineHolder
- Base: UnityEngine.MonoBehaviour

#### Constructors
- public StaticCoroutine.CoroutineHolder()

### public static class Proyecto26.HttpBase

#### Fields
- private static const int HTTP_NO_CONTENT

#### Methods
- private static Proyecto26.RequestException CreateException(Proyecto26.RequestHelper options, UnityEngine.Networking.UnityWebRequest request)
- private static UnityEngine.Networking.UnityWebRequest CreateRequest(Proyecto26.RequestHelper options)
- public static System.Collections.IEnumerator CreateRequestAndRetry(Proyecto26.RequestHelper options, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper> callback)
- public static void DebugLog(bool debugEnabled, object message, bool isError)
- public static System.Collections.IEnumerator DefaultUnityWebRequest(Proyecto26.RequestHelper options, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper> callback)
- public static System.Collections.IEnumerator DefaultUnityWebRequest<TResponse>(Proyecto26.RequestHelper options, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper, TResponse> callback)
- public static System.Collections.IEnumerator DefaultUnityWebRequest<TResponse>(Proyecto26.RequestHelper options, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper, TResponse[]> callback)

### public static class Proyecto26.JsonHelper

#### Methods
- public static T[] ArrayFromJson<T>(string json)
- public static string ArrayToJsonString<T>(T[] array)
- public static string ArrayToJsonString<T>(T[] array, bool prettyPrint)
- public static T[] FromJsonString<T>(string json)

### public class Proyecto26.RequestException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Fields
- private bool _isHttpError
- private bool _isNetworkError
- private Proyecto26.RequestHelper _request
- private string _response
- private string _serverMessage
- private long _statusCode

#### Properties
- public bool IsHttpError { get; private set; }
- public bool IsNetworkError { get; private set; }
- public Proyecto26.RequestHelper Request { get; private set; }
- public string Response { get; set; }
- public string ServerMessage { get; set; }
- public long StatusCode { get; private set; }

#### Constructors
- public RequestException()
- public RequestException(string message)
- public RequestException(Proyecto26.RequestHelper request, string message, bool isHttpError, bool isNetworkError, long statusCode, string response)

### public class Proyecto26.RequestHelper

#### Fields
- private UnityEngine.Networking.UnityWebRequest <Request>k__BackingField
- private object _body
- private byte[] _bodyRaw
- private string _bodyString
- private UnityEngine.Networking.CertificateHandler _certificateHandler
- private string _contentType
- private bool _defaultContentType
- private UnityEngine.Networking.DownloadHandler _downloadHandler
- private bool _enableDebug
- private UnityEngine.WWWForm _formData
- private System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> _formSections
- private System.Collections.Generic.Dictionary<string, string> _headers
- private bool _ignoreHttpException
- private bool _isAborted
- private string _method
- private System.Collections.Generic.Dictionary<string, string> _params
- private bool _parseResponseBody
- private System.Action<float> _progressCallback
- private System.Nullable<int> _redirectLimit
- private int _retries
- private System.Action<Proyecto26.RequestException, int> _retryCallback
- private bool _retryCallbackOnlyOnNetworkErrors
- private float _retrySecondsDelay
- private System.Collections.Generic.Dictionary<string, string> _simpleForm
- private System.Nullable<int> _timeout
- private UnityEngine.Networking.UploadHandler _uploadHandler
- private string _uri
- private System.Nullable<bool> _useHttpContinue

#### Properties
- public object Body { get; set; }
- public byte[] BodyRaw { get; set; }
- public string BodyString { get; set; }
- public UnityEngine.Networking.CertificateHandler CertificateHandler { get; set; }
- public string ContentType { get; set; }
- public bool DefaultContentType { get; set; }
- public ulong DownloadedBytes { get; }
- public UnityEngine.Networking.DownloadHandler DownloadHandler { get; set; }
- public float DownloadProgress { get; }
- public bool EnableDebug { get; set; }
- public UnityEngine.WWWForm FormData { get; set; }
- public System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> FormSections { get; set; }
- public System.Collections.Generic.Dictionary<string, string> Headers { get; set; }
- public bool IgnoreHttpException { get; set; }
- public bool IsAborted { get; set; }
- public string Method { get; set; }
- public System.Collections.Generic.Dictionary<string, string> Params { get; set; }
- public bool ParseResponseBody { get; set; }
- public System.Action<float> ProgressCallback { get; set; }
- public System.Nullable<int> RedirectLimit { get; set; }
- public UnityEngine.Networking.UnityWebRequest Request { private get; set; }
- public int Retries { get; set; }
- public System.Action<Proyecto26.RequestException, int> RetryCallback { get; set; }
- public bool RetryCallbackOnlyOnNetworkErrors { get; set; }
- public float RetrySecondsDelay { get; set; }
- public System.Collections.Generic.Dictionary<string, string> SimpleForm { get; set; }
- public System.Nullable<int> Timeout { get; set; }
- public ulong UploadedBytes { get; }
- public UnityEngine.Networking.UploadHandler UploadHandler { get; set; }
- public float UploadProgress { get; }
- public string Uri { get; set; }
- public System.Nullable<bool> UseHttpContinue { get; set; }

#### Constructors
- public RequestHelper()

#### Methods
- public void Abort()
- public string GetHeader(string name)

### public class Proyecto26.ResponseHelper

#### Fields
- private UnityEngine.Networking.UnityWebRequest <Request>k__BackingField

#### Properties
- public byte[] Data { get; }
- public string Error { get; }
- public System.Collections.Generic.Dictionary<string, string> Headers { get; }
- public UnityEngine.Networking.UnityWebRequest Request { get; private set; }
- public long StatusCode { get; }
- public string Text { get; }

#### Constructors
- public ResponseHelper(UnityEngine.Networking.UnityWebRequest request)

#### Methods
- public string GetHeader(string name)
- public override string ToString()

### public static class Proyecto26.RestClient

#### Fields
- private static System.Collections.Generic.Dictionary<string, string> _defaultRequestHeaders
- private static System.Collections.Generic.Dictionary<string, string> _defaultRequestParams
- private static System.Version _version

#### Properties
- public static System.Collections.Generic.Dictionary<string, string> DefaultRequestHeaders { get; set; }
- public static System.Collections.Generic.Dictionary<string, string> DefaultRequestParams { get; set; }
- public static System.Version Version { get; }

#### Methods
- public static void ClearDefaultHeaders()
- public static void ClearDefaultParams()
- public static void Delete(string url, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper> callback)
- public static void Delete(Proyecto26.RequestHelper options, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper> callback)
- public static RSG.IPromise<Proyecto26.ResponseHelper> Delete(string url)
- public static RSG.IPromise<Proyecto26.ResponseHelper> Delete(Proyecto26.RequestHelper options)
- public static void Get(string url, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper> callback)
- public static void Get(Proyecto26.RequestHelper options, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper> callback)
- public static void Get<T>(string url, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper, T> callback)
- public static void Get<T>(Proyecto26.RequestHelper options, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper, T> callback)
- public static RSG.IPromise<Proyecto26.ResponseHelper> Get(string url)
- public static RSG.IPromise<Proyecto26.ResponseHelper> Get(Proyecto26.RequestHelper options)
- public static RSG.IPromise<T> Get<T>(string url)
- public static RSG.IPromise<T> Get<T>(Proyecto26.RequestHelper options)
- public static void GetArray<T>(string url, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper, T[]> callback)
- public static void GetArray<T>(Proyecto26.RequestHelper options, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper, T[]> callback)
- public static RSG.IPromise<T[]> GetArray<T>(string url)
- public static RSG.IPromise<T[]> GetArray<T>(Proyecto26.RequestHelper options)
- public static void Head(string url, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper> callback)
- public static void Head(Proyecto26.RequestHelper options, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper> callback)
- public static RSG.IPromise<Proyecto26.ResponseHelper> Head(string url)
- public static RSG.IPromise<Proyecto26.ResponseHelper> Head(Proyecto26.RequestHelper options)
- public static void Patch(string url, object body, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper> callback)
- public static void Patch(string url, string bodyString, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper> callback)
- public static void Patch(Proyecto26.RequestHelper options, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper> callback)
- public static void Patch<T>(string url, object body, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper, T> callback)
- public static void Patch<T>(string url, string bodyString, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper, T> callback)
- public static void Patch<T>(Proyecto26.RequestHelper options, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper, T> callback)
- public static RSG.IPromise<Proyecto26.ResponseHelper> Patch(string url, object body)
- public static RSG.IPromise<Proyecto26.ResponseHelper> Patch(string url, string bodyString)
- public static RSG.IPromise<Proyecto26.ResponseHelper> Patch(Proyecto26.RequestHelper options)
- public static RSG.IPromise<T> Patch<T>(string url, object body)
- public static RSG.IPromise<T> Patch<T>(string url, string bodyString)
- public static RSG.IPromise<T> Patch<T>(Proyecto26.RequestHelper options)
- public static void Post(string url, object body, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper> callback)
- public static void Post(string url, string bodyString, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper> callback)
- public static void Post(Proyecto26.RequestHelper options, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper> callback)
- public static void Post<T>(string url, object body, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper, T> callback)
- public static void Post<T>(string url, string bodyString, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper, T> callback)
- public static void Post<T>(Proyecto26.RequestHelper options, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper, T> callback)
- public static RSG.IPromise<Proyecto26.ResponseHelper> Post(string url, object body)
- public static RSG.IPromise<Proyecto26.ResponseHelper> Post(string url, string bodyString)
- public static RSG.IPromise<Proyecto26.ResponseHelper> Post(Proyecto26.RequestHelper options)
- public static RSG.IPromise<T> Post<T>(string url, object body)
- public static RSG.IPromise<T> Post<T>(string url, string bodyString)
- public static RSG.IPromise<T> Post<T>(Proyecto26.RequestHelper options)
- public static void PostArray<T>(string url, object body, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper, T[]> callback)
- public static void PostArray<T>(string url, string bodyString, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper, T[]> callback)
- public static void PostArray<T>(Proyecto26.RequestHelper options, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper, T[]> callback)
- public static RSG.IPromise<T[]> PostArray<T>(string url, object body)
- public static RSG.IPromise<T[]> PostArray<T>(string url, string bodyString)
- public static RSG.IPromise<T[]> PostArray<T>(Proyecto26.RequestHelper options)
- private static void Promisify<T>(RSG.Promise<T> promise, Proyecto26.RequestException error, T response)
- private static void Promisify<T>(RSG.Promise<T> promise, Proyecto26.RequestException error, Proyecto26.ResponseHelper response, T body)
- public static void Put(string url, object body, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper> callback)
- public static void Put(string url, string bodyString, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper> callback)
- public static void Put(Proyecto26.RequestHelper options, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper> callback)
- public static void Put<T>(string url, object body, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper, T> callback)
- public static void Put<T>(string url, string bodyString, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper, T> callback)
- public static void Put<T>(Proyecto26.RequestHelper options, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper, T> callback)
- public static RSG.IPromise<Proyecto26.ResponseHelper> Put(string url, object body)
- public static RSG.IPromise<Proyecto26.ResponseHelper> Put(string url, string bodyString)
- public static RSG.IPromise<Proyecto26.ResponseHelper> Put(Proyecto26.RequestHelper options)
- public static RSG.IPromise<T> Put<T>(string url, object body)
- public static RSG.IPromise<T> Put<T>(string url, string bodyString)
- public static RSG.IPromise<T> Put<T>(Proyecto26.RequestHelper options)
- public static void Request(Proyecto26.RequestHelper options, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper> callback)
- public static void Request<T>(Proyecto26.RequestHelper options, System.Action<Proyecto26.RequestException, Proyecto26.ResponseHelper, T> callback)
- public static RSG.IPromise<Proyecto26.ResponseHelper> Request(Proyecto26.RequestHelper options)
- public static RSG.IPromise<T> Request<T>(Proyecto26.RequestHelper options)

### public static class Proyecto26.StaticCoroutine

#### Fields
- private static Proyecto26.StaticCoroutine.CoroutineHolder _runner

#### Properties
- private static Proyecto26.StaticCoroutine.CoroutineHolder Runner { get; }

#### Methods
- public static UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator coroutine)

### private class Proyecto26.JsonHelper.Wrapper<T>

#### Fields
- public T[] Items

#### Constructors
- public JsonHelper.Wrapper<T>()

## Namespace: Proyecto26.Common

### private class Proyecto26.Common.Extensions.<>c

#### Fields
- public static readonly Proyecto26.Common.Extensions.<>c <>9
- public static System.Func<System.Collections.Generic.KeyValuePair<string, string>, string> <>9__3_1

#### Constructors
- private static Extensions.<>c()
- public Extensions.<>c()

#### Methods
- internal string <BuildUrl>b__3_1(System.Collections.Generic.KeyValuePair<string, string> p)

### private class Proyecto26.Common.Extensions.<>c__DisplayClass3_0

#### Fields
- public System.Collections.Generic.Dictionary<TKey, TValue>.KeyCollection<string, string> urlParamKeys

#### Constructors
- public Extensions.<>c__DisplayClass3_0()

#### Methods
- internal bool <BuildUrl>b__0(System.Collections.Generic.KeyValuePair<string, string> p)

### public static class Proyecto26.Common.Common

#### Fields
- private static const string CONTENT_TYPE_HEADER
- private static const string DEFAULT_CONTENT_TYPE

#### Methods
- private static void ConfigureWebRequestWithOptions(UnityEngine.Networking.UnityWebRequest request, byte[] bodyRaw, string contentType, Proyecto26.RequestHelper options)
- private static string GetFormSectionsContentType(out byte[] bodyRaw, Proyecto26.RequestHelper options)
- public static UnityEngine.AsyncOperation SendWebRequestWithOptions(UnityEngine.Networking.UnityWebRequest request, Proyecto26.RequestHelper options)

### public static class Proyecto26.Common.Extensions

#### Methods
- public static string BuildUrl(string uri, System.Collections.Generic.Dictionary<string, string> queryParams)
- public static Proyecto26.ResponseHelper CreateWebResponse(UnityEngine.Networking.UnityWebRequest request)
- public static string EscapeURL(string queryParam)
- public static bool IsValidRequest(UnityEngine.Networking.UnityWebRequest request, Proyecto26.RequestHelper options)

## Namespace: Proyecto26.Helper

### public class Proyecto26.Helper.ExecuteOnMainThread
- Base: UnityEngine.MonoBehaviour

#### Fields
- private static Proyecto26.Helper.ExecuteOnMainThread _instance

#### Properties
- public static Proyecto26.Helper.ExecuteOnMainThread Instance { get; }

#### Constructors
- public ExecuteOnMainThread()

#### Methods
- private void Awake()

