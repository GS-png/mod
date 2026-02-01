# Assembly: UnityEngine.UnityWebRequestModule
- Path: tools/WorldBox.Managed/UnityEngine.UnityWebRequestModule.dll
- Types: 19

## Namespace: UnityEngine

### public class UnityEngine.WWWForm

#### Fields
- private static byte[] ampersand
- private byte[] boundary
- private bool containsFiles
- private static byte[] contentTypeHeader
- private static byte[] crlf
- private static byte[] dDash
- private static byte[] dispositionHeader
- private static byte[] endQuote
- private static byte[] equal
- private System.Collections.Generic.List<string> fieldNames
- private static byte[] fileNameField
- private System.Collections.Generic.List<string> fileNames
- private System.Collections.Generic.List<byte[]> formData
- private System.Collections.Generic.List<string> types

#### Properties
- public byte[] data { get; }
- internal static System.Text.Encoding DefaultEncoding { get; }
- public System.Collections.Generic.Dictionary<string, string> headers { get; }

#### Constructors
- public WWWForm()
- private static WWWForm()

#### Methods
- public void AddBinaryData(string fieldName, byte[] contents)
- public void AddBinaryData(string fieldName, byte[] contents, string fileName)
- public void AddBinaryData(string fieldName, byte[] contents, string fileName, string mimeType)
- public void AddField(string fieldName, string value)
- public void AddField(string fieldName, string value, System.Text.Encoding e)
- public void AddField(string fieldName, int i)

### internal class UnityEngine.WWWTranscoder

#### Fields
- private static byte[] dataSpace
- private static byte[] lcHexChars
- private static byte qpEscapeChar
- private static byte[] qpForbidden
- private static byte[] qpSpace
- private static byte[] ucHexChars
- private static byte urlEscapeChar
- private static byte[] urlForbidden
- private static byte[] urlSpace

#### Constructors
- public WWWTranscoder()
- private static WWWTranscoder()

#### Methods
- private static void Byte2Hex(byte b, byte[] hexChars, out byte byte0, out byte byte1)
- private static bool ByteArrayContains(byte[] array, byte b)
- private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand)
- public static string DataDecode(string toDecode)
- public static string DataDecode(string toDecode, System.Text.Encoding e)
- public static byte[] DataDecode(byte[] toDecode)
- public static string DataEncode(string toEncode)
- public static string DataEncode(string toEncode, System.Text.Encoding e)
- public static byte[] DataEncode(byte[] toEncode)
- public static byte[] Decode(byte[] input, byte escapeChar, byte[] space)
- public static byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase)
- private static byte Hex2Byte(byte[] b, int offset)
- public static string QPDecode(string toEncode)
- public static string QPDecode(string toEncode, System.Text.Encoding e)
- public static byte[] QPDecode(byte[] toEncode)
- public static string QPEncode(string toEncode)
- public static string QPEncode(string toEncode, System.Text.Encoding e)
- public static byte[] QPEncode(byte[] toEncode)
- public static bool SevenBitClean(string s)
- public static bool SevenBitClean(string s, System.Text.Encoding e)
- public static bool SevenBitClean(byte* input, int inputLength)
- public static string URLDecode(string toEncode)
- public static string URLDecode(string toEncode, System.Text.Encoding e)
- public static byte[] URLDecode(byte[] toEncode)
- public static string URLEncode(string toEncode)
- public static string URLEncode(string toEncode, System.Text.Encoding e)
- public static byte[] URLEncode(byte[] toEncode)

## Namespace: UnityEngine.Networking

### public class UnityEngine.Networking.CertificateHandler
- Interfaces: System.IDisposable

#### Fields
- internal System.IntPtr m_Ptr

#### Constructors
- protected CertificateHandler()

#### Methods
- private static System.IntPtr Create(UnityEngine.Networking.CertificateHandler obj)
- public void Dispose()
- protected override void Finalize()
- private void Release()
- protected virtual bool ValidateCertificate(byte[] certificateData)
- internal bool ValidateCertificateNative(byte[] certificateData)

### public class UnityEngine.Networking.DownloadHandler
- Interfaces: System.IDisposable

#### Fields
- internal System.IntPtr m_Ptr

#### Properties
- public byte[] data { get; }
- public string error { get; }
- public bool isDone { get; }
- public Unity.Collections.NativeArray<T>.ReadOnly<byte> nativeData { get; }
- public string text { get; }

#### Constructors
- internal DownloadHandler()

#### Methods
- protected virtual void CompleteContent()
- internal static void CreateNativeArrayForNativeData(ref Unity.Collections.NativeArray<byte> data, byte* bytes, int length)
- public virtual void Dispose()
- internal static void DisposeNativeArray(ref Unity.Collections.NativeArray<byte> data)
- protected override void Finalize()
- protected static T GetCheckedDownloader<T>(UnityEngine.Networking.UnityWebRequest www)
- private string GetContentType()
- protected virtual byte[] GetData()
- private string GetErrorMsg()
- protected virtual Unity.Collections.NativeArray<byte> GetNativeData()
- protected virtual float GetProgress()
- protected virtual string GetText()
- private System.Text.Encoding GetTextEncoder()
- internal static byte* InternalGetByteArray(UnityEngine.Networking.DownloadHandler dh, out int length)
- internal static byte[] InternalGetByteArray(UnityEngine.Networking.DownloadHandler dh)
- internal static Unity.Collections.NativeArray<byte> InternalGetNativeArray(UnityEngine.Networking.DownloadHandler dh, ref Unity.Collections.NativeArray<byte> nativeArray)
- private bool IsDone()
- protected virtual void ReceiveContentLength(int contentLength)
- protected virtual void ReceiveContentLengthHeader(ulong contentLength)
- protected virtual bool ReceiveData(byte[] data, int dataLength)
- private void Release()

### public class UnityEngine.Networking.DownloadHandlerBuffer
- Base: UnityEngine.Networking.DownloadHandler
- Interfaces: System.IDisposable

#### Fields
- private Unity.Collections.NativeArray<byte> m_NativeData

#### Constructors
- public DownloadHandlerBuffer()

#### Methods
- private static System.IntPtr Create(UnityEngine.Networking.DownloadHandlerBuffer obj)
- public override void Dispose()
- public static string GetContent(UnityEngine.Networking.UnityWebRequest www)
- protected override Unity.Collections.NativeArray<byte> GetNativeData()
- private void InternalCreateBuffer()

### public class UnityEngine.Networking.DownloadHandlerFile
- Base: UnityEngine.Networking.DownloadHandler
- Interfaces: System.IDisposable

#### Properties
- public bool removeFileOnAbort { get; set; }

#### Constructors
- public DownloadHandlerFile(string path)
- public DownloadHandlerFile(string path, bool append)

#### Methods
- private static System.IntPtr Create(UnityEngine.Networking.DownloadHandlerFile obj, string path, bool append)
- protected override byte[] GetData()
- protected override Unity.Collections.NativeArray<byte> GetNativeData()
- protected override string GetText()
- private void InternalCreateVFS(string path, bool append)

### public class UnityEngine.Networking.DownloadHandlerScript
- Base: UnityEngine.Networking.DownloadHandler
- Interfaces: System.IDisposable

#### Constructors
- public DownloadHandlerScript()
- public DownloadHandlerScript(byte[] preallocatedBuffer)

#### Methods
- private static System.IntPtr Create(UnityEngine.Networking.DownloadHandlerScript obj)
- private static System.IntPtr CreatePreallocated(UnityEngine.Networking.DownloadHandlerScript obj, byte[] preallocatedBuffer)
- private void InternalCreateScript()
- private void InternalCreateScript(byte[] preallocatedBuffer)

### public interface UnityEngine.Networking.IMultipartFormSection

#### Properties
- public string contentType { get; }
- public string fileName { get; }
- public byte[] sectionData { get; }
- public string sectionName { get; }

### public class UnityEngine.Networking.MultipartFormDataSection
- Interfaces: UnityEngine.Networking.IMultipartFormSection

#### Fields
- private string content
- private byte[] data
- private string name

#### Properties
- public string contentType { get; }
- public string fileName { get; }
- public byte[] sectionData { get; }
- public string sectionName { get; }

#### Constructors
- public MultipartFormDataSection(byte[] data)
- public MultipartFormDataSection(string data)
- public MultipartFormDataSection(string name, byte[] data)
- public MultipartFormDataSection(string name, string data)
- public MultipartFormDataSection(string name, byte[] data, string contentType)
- public MultipartFormDataSection(string name, string data, string contentType)
- public MultipartFormDataSection(string name, string data, System.Text.Encoding encoding, string contentType)

### public class UnityEngine.Networking.MultipartFormFileSection
- Interfaces: UnityEngine.Networking.IMultipartFormSection

#### Fields
- private string content
- private byte[] data
- private string file
- private string name

#### Properties
- public string contentType { get; }
- public string fileName { get; }
- public byte[] sectionData { get; }
- public string sectionName { get; }

#### Constructors
- public MultipartFormFileSection(byte[] data)
- public MultipartFormFileSection(string fileName, byte[] data)
- public MultipartFormFileSection(string data, string fileName)
- public MultipartFormFileSection(string data, System.Text.Encoding dataEncoding, string fileName)
- public MultipartFormFileSection(string name, byte[] data, string fileName, string contentType)
- public MultipartFormFileSection(string name, string data, System.Text.Encoding dataEncoding, string fileName)

#### Methods
- private void Init(string name, byte[] data, string fileName, string contentType)

### public enum UnityEngine.Networking.UnityWebRequest.Result
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ConnectionError = 2
- DataProcessingError = 4
- InProgress = 0
- ProtocolError = 3
- Success = 1

### public class UnityEngine.Networking.UnityWebRequest
- Interfaces: System.IDisposable

#### Fields
- private bool <disposeCertificateHandlerOnDispose>k__BackingField
- private bool <disposeDownloadHandlerOnDispose>k__BackingField
- private bool <disposeUploadHandlerOnDispose>k__BackingField
- public static const string kHttpVerbCREATE
- public static const string kHttpVerbDELETE
- public static const string kHttpVerbGET
- public static const string kHttpVerbHEAD
- public static const string kHttpVerbPOST
- public static const string kHttpVerbPUT
- internal UnityEngine.Networking.CertificateHandler m_CertificateHandler
- internal UnityEngine.Networking.DownloadHandler m_DownloadHandler
- internal System.IntPtr m_Ptr
- internal UnityEngine.Networking.UploadHandler m_UploadHandler
- internal System.Uri m_Uri

#### Properties
- public UnityEngine.Networking.CertificateHandler certificateHandler { get; set; }
- public bool chunkedTransfer { get; set; }
- public bool disposeCertificateHandlerOnDispose { get; set; }
- public bool disposeDownloadHandlerOnDispose { get; set; }
- public bool disposeUploadHandlerOnDispose { get; set; }
- public ulong downloadedBytes { get; }
- public UnityEngine.Networking.DownloadHandler downloadHandler { get; set; }
- public float downloadProgress { get; }
- public string error { get; }
- public bool isDone { get; }
- public bool isHttpError { get; }
- public bool isModifiable { get; }
- public bool isNetworkError { get; }
- public string method { get; set; }
- public int redirectLimit { get; set; }
- public long responseCode { get; }
- public UnityEngine.Networking.UnityWebRequest.Result result { get; }
- internal bool suppressErrorsToConsole { get; set; }
- public int timeout { get; set; }
- public ulong uploadedBytes { get; }
- public UnityEngine.Networking.UploadHandler uploadHandler { get; set; }
- public float uploadProgress { get; }
- public System.Uri uri { get; set; }
- public string url { get; set; }
- private bool use100Continue { get; set; }
- public bool useHttpContinue { get; set; }

#### Constructors
- public UnityWebRequest()
- public UnityWebRequest(string url)
- public UnityWebRequest(System.Uri uri)
- public UnityWebRequest(string url, string method)
- public UnityWebRequest(System.Uri uri, string method)
- public UnityWebRequest(string url, string method, UnityEngine.Networking.DownloadHandler downloadHandler, UnityEngine.Networking.UploadHandler uploadHandler)
- public UnityWebRequest(System.Uri uri, string method, UnityEngine.Networking.DownloadHandler downloadHandler, UnityEngine.Networking.UploadHandler uploadHandler)

#### Methods
- public void Abort()
- internal UnityEngine.Networking.UnityWebRequestAsyncOperation BeginWebRequest()
- public static void ClearCookieCache()
- public static void ClearCookieCache(System.Uri uri)
- private static void ClearCookieCache(string domain, string path)
- internal static System.IntPtr Create()
- public static UnityEngine.Networking.UnityWebRequest Delete(string uri)
- public static UnityEngine.Networking.UnityWebRequest Delete(System.Uri uri)
- public void Dispose()
- private void DisposeHandlers()
- public static string EscapeURL(string s)
- public static string EscapeURL(string s, System.Text.Encoding e)
- protected override void Finalize()
- public static byte[] GenerateBoundary()
- public static UnityEngine.Networking.UnityWebRequest Get(string uri)
- public static UnityEngine.Networking.UnityWebRequest Get(System.Uri uri)
- public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri)
- public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri, uint crc)
- public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri, uint version, uint crc)
- public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri, UnityEngine.Hash128 hash, uint crc)
- public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri, UnityEngine.CachedAssetBundle cachedAssetBundle, uint crc)
- public static UnityEngine.Networking.UnityWebRequest GetAudioClip(string uri, UnityEngine.AudioType audioType)
- private bool GetChunked()
- internal string GetCustomMethod()
- private float GetDownloadProgress()
- private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError GetError()
- internal static string GetHTTPStatusString(long responseCode)
- internal UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod GetMethod()
- private int GetRedirectLimit()
- public string GetRequestHeader(string name)
- public string GetResponseHeader(string name)
- internal string[] GetResponseHeaderKeys()
- public System.Collections.Generic.Dictionary<string, string> GetResponseHeaders()
- private bool GetSuppressErrorsToConsole()
- public static UnityEngine.Networking.UnityWebRequest GetTexture(string uri)
- public static UnityEngine.Networking.UnityWebRequest GetTexture(string uri, bool nonReadable)
- private int GetTimeoutMsec()
- private float GetUploadProgress()
- private string GetUrl()
- private static string GetWebErrorString(UnityEngine.Networking.UnityWebRequest.UnityWebRequestError err)
- public static UnityEngine.Networking.UnityWebRequest Head(string uri)
- public static UnityEngine.Networking.UnityWebRequest Head(System.Uri uri)
- internal void InternalDestroy()
- internal void InternalSetCustomMethod(string customMethodName)
- private void InternalSetDefaults()
- internal void InternalSetMethod(UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod methodType)
- internal UnityEngine.Networking.UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(string name, string value)
- private void InternalSetUrl(string url)
- private bool IsExecuting()
- public static UnityEngine.Networking.UnityWebRequest Post(string uri, string postData)
- public static UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, string postData)
- public static UnityEngine.Networking.UnityWebRequest Post(string uri, string postData, string contentType)
- public static UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, string postData, string contentType)
- public static UnityEngine.Networking.UnityWebRequest Post(string uri, UnityEngine.WWWForm formData)
- public static UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, UnityEngine.WWWForm formData)
- public static UnityEngine.Networking.UnityWebRequest Post(string uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections)
- public static UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections)
- public static UnityEngine.Networking.UnityWebRequest Post(string uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections, byte[] boundary)
- public static UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections, byte[] boundary)
- public static UnityEngine.Networking.UnityWebRequest Post(string uri, System.Collections.Generic.Dictionary<string, string> formFields)
- public static UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, System.Collections.Generic.Dictionary<string, string> formFields)
- public static UnityEngine.Networking.UnityWebRequest PostWwwForm(string uri, string form)
- public static UnityEngine.Networking.UnityWebRequest PostWwwForm(System.Uri uri, string form)
- public static UnityEngine.Networking.UnityWebRequest Put(string uri, byte[] bodyData)
- public static UnityEngine.Networking.UnityWebRequest Put(System.Uri uri, byte[] bodyData)
- public static UnityEngine.Networking.UnityWebRequest Put(string uri, string bodyData)
- public static UnityEngine.Networking.UnityWebRequest Put(System.Uri uri, string bodyData)
- private void Release()
- public UnityEngine.AsyncOperation Send()
- public UnityEngine.Networking.UnityWebRequestAsyncOperation SendWebRequest()
- public static byte[] SerializeFormSections(System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections, byte[] boundary)
- public static byte[] SerializeSimpleForm(System.Collections.Generic.Dictionary<string, string> formFields)
- private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCertificateHandler(UnityEngine.Networking.CertificateHandler ch)
- private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetChunked(bool chunked)
- private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName)
- private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetDownloadHandler(UnityEngine.Networking.DownloadHandler dh)
- private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetMethod(UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod methodType)
- private void SetRedirectLimitFromScripting(int limit)
- public void SetRequestHeader(string name, string value)
- private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetSuppressErrorsToConsole(bool suppress)
- private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetTimeoutMsec(int timeout)
- private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUploadHandler(UnityEngine.Networking.UploadHandler uh)
- private static void SetupPost(UnityEngine.Networking.UnityWebRequest request, string postData, string contentType)
- private static void SetupPost(UnityEngine.Networking.UnityWebRequest request, UnityEngine.WWWForm formData)
- private static void SetupPost(UnityEngine.Networking.UnityWebRequest request, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections, byte[] boundary)
- private static void SetupPost(UnityEngine.Networking.UnityWebRequest request, System.Collections.Generic.Dictionary<string, string> formFields)
- private static void SetupPostWwwForm(UnityEngine.Networking.UnityWebRequest request, string postData)
- private UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUrl(string url)
- public static string UnEscapeURL(string s)
- public static string UnEscapeURL(string s, System.Text.Encoding e)

### public class UnityEngine.Networking.UnityWebRequestAsyncOperation
- Base: UnityEngine.AsyncOperation

#### Fields
- private UnityEngine.Networking.UnityWebRequest <webRequest>k__BackingField

#### Properties
- public UnityEngine.Networking.UnityWebRequest webRequest { get; internal set; }

#### Constructors
- public UnityWebRequestAsyncOperation()

### internal enum UnityEngine.Networking.UnityWebRequest.UnityWebRequestError
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Aborted = 17
- AccessDenied = 9
- AlreadySent = 35
- CannotConnectToHost = 8
- CannotModifyRequest = 31
- CannotOverrideSystemHeaders = 34
- CannotResolveHost = 7
- CannotResolveProxy = 6
- DataProcessingError = 39
- FailedToReceiveData = 22
- FailedToSendData = 21
- GenericHttpError = 10
- HeaderNameContainsInvalidCharacters = 32
- HeaderValueContainsInvalidCharacters = 33
- HTTPPostError = 15
- InsecureConnectionNotAllowed = 40
- InvalidMethod = 36
- InvalidRedirect = 30
- LoginFailed = 27
- MalformattedUrl = 5
- NoInternetConnection = 38
- NotImplemented = 37
- OK = 0
- OKCached = 1
- OutOfMemory = 13
- ReadError = 12
- ReceivedNoData = 19
- RedirectLimitInvalid = 29
- SDKError = 3
- SSLCACertError = 25
- SSLCannotConnect = 16
- SSLCertificateError = 23
- SSLCipherNotAvailable = 24
- SSLNotSupported = 20
- SSLShutdownFailed = 28
- Timeout = 14
- TooManyRedirects = 18
- Unknown = 2
- UnrecognizedContentEncoding = 26
- UnsupportedProtocol = 4
- WriteError = 11

### internal enum UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Custom = 4
- Get = 0
- Head = 3
- Post = 1
- Put = 2

### public class UnityEngine.Networking.UploadHandler
- Interfaces: System.IDisposable

#### Fields
- internal System.IntPtr m_Ptr

#### Properties
- public string contentType { get; set; }
- public byte[] data { get; }
- public float progress { get; }

#### Constructors
- internal UploadHandler()

#### Methods
- public virtual void Dispose()
- protected override void Finalize()
- internal virtual string GetContentType()
- internal virtual byte[] GetData()
- internal virtual float GetProgress()
- private string InternalGetContentType()
- private float InternalGetProgress()
- private void InternalSetContentType(string newContentType)
- private void Release()
- internal virtual void SetContentType(string newContentType)

### public class UnityEngine.Networking.UploadHandlerFile
- Base: UnityEngine.Networking.UploadHandler
- Interfaces: System.IDisposable

#### Constructors
- public UploadHandlerFile(string filePath)

#### Methods
- private static System.IntPtr Create(UnityEngine.Networking.UploadHandlerFile self, string filePath)

### public class UnityEngine.Networking.UploadHandlerRaw
- Base: UnityEngine.Networking.UploadHandler
- Interfaces: System.IDisposable

#### Fields
- private Unity.Collections.NativeArray<byte> m_Payload

#### Constructors
- public UploadHandlerRaw(byte[] data)
- public UploadHandlerRaw(Unity.Collections.NativeArray<T>.ReadOnly<byte> data)
- public UploadHandlerRaw(Unity.Collections.NativeArray<byte> data, bool transferOwnership)

#### Methods
- private static System.IntPtr Create(UnityEngine.Networking.UploadHandlerRaw self, byte* data, int dataLength)
- public override void Dispose()
- internal override byte[] GetData()

## Namespace: UnityEngineInternal

### internal static class UnityEngineInternal.WebRequestUtils

#### Fields
- private static System.Text.RegularExpressions.Regex domainRegex

#### Constructors
- private static WebRequestUtils()

#### Methods
- internal static string MakeInitialUrl(string targetUrl, string localUrl)
- internal static string MakeUriString(System.Uri targetUri, string targetUrl, bool prependProtocol)
- internal static string RedirectTo(string baseUri, string redirectUri)
- private static string URLDecode(string encoded)

