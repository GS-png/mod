# Assembly: UnityEngine.UnityWebRequestWWWModule
- Path: tools/WorldBox.Managed/UnityEngine.UnityWebRequestWWWModule.dll
- Types: 3

## Namespace: UnityEngine

### public class UnityEngine.WWW
- Base: UnityEngine.CustomYieldInstruction
- Interfaces: System.Collections.IEnumerator, System.IDisposable

#### Fields
- private UnityEngine.ThreadPriority <threadPriority>k__BackingField
- private UnityEngine.AssetBundle _assetBundle
- private System.Collections.Generic.Dictionary<string, string> _responseHeaders
- private UnityEngine.Networking.UnityWebRequest _uwr

#### Properties
- public UnityEngine.AssetBundle assetBundle { get; }
- public UnityEngine.Object audioClip { get; }
- public byte[] bytes { get; }
- public int bytesDownloaded { get; }
- public string data { get; }
- public string error { get; }
- public bool isDone { get; }
- public bool keepWaiting { get; }
- public UnityEngine.Object movie { get; }
- public float progress { get; }
- public System.Collections.Generic.Dictionary<string, string> responseHeaders { get; }
- public int size { get; }
- public string text { get; }
- public UnityEngine.Texture2D texture { get; }
- public UnityEngine.Texture2D textureNonReadable { get; }
- public UnityEngine.ThreadPriority threadPriority { get; set; }
- public float uploadProgress { get; }
- public string url { get; }

#### Constructors
- public WWW(string url)
- public WWW(string url, UnityEngine.WWWForm form)
- public WWW(string url, byte[] postData)
- public WWW(string url, byte[] postData, System.Collections.Hashtable headers)
- public WWW(string url, byte[] postData, System.Collections.Generic.Dictionary<string, string> headers)
- internal WWW(string url, string name, UnityEngine.Hash128 hash, uint crc)

#### Methods
- private UnityEngine.Texture2D CreateTextureFromDownloadedData(bool markNonReadable)
- public void Dispose()
- public static string EscapeURL(string s)
- public static string EscapeURL(string s, System.Text.Encoding e)
- public UnityEngine.AudioClip GetAudioClip()
- public UnityEngine.AudioClip GetAudioClip(bool threeD)
- public UnityEngine.AudioClip GetAudioClip(bool threeD, bool stream)
- public UnityEngine.AudioClip GetAudioClip(bool threeD, bool stream, UnityEngine.AudioType audioType)
- public UnityEngine.AudioClip GetAudioClipCompressed()
- public UnityEngine.AudioClip GetAudioClipCompressed(bool threeD)
- public UnityEngine.AudioClip GetAudioClipCompressed(bool threeD, UnityEngine.AudioType audioType)
- internal UnityEngine.Object GetAudioClipInternal(bool threeD, bool stream, bool compressed, UnityEngine.AudioType audioType)
- public UnityEngine.MovieTexture GetMovieTexture()
- public static UnityEngine.WWW LoadFromCacheOrDownload(string url, int version)
- public static UnityEngine.WWW LoadFromCacheOrDownload(string url, int version, uint crc)
- public static UnityEngine.WWW LoadFromCacheOrDownload(string url, UnityEngine.Hash128 hash)
- public static UnityEngine.WWW LoadFromCacheOrDownload(string url, UnityEngine.Hash128 hash, uint crc)
- public static UnityEngine.WWW LoadFromCacheOrDownload(string url, UnityEngine.CachedAssetBundle cachedBundle, uint crc = 0)
- public void LoadImageIntoTexture(UnityEngine.Texture2D texture)
- public static string UnEscapeURL(string s)
- public static string UnEscapeURL(string s, System.Text.Encoding e)
- private bool WaitUntilDoneIfPossible()

### public static class UnityEngine.WWWAudioExtensions

#### Methods
- public static UnityEngine.AudioClip GetAudioClip(UnityEngine.WWW www)
- public static UnityEngine.AudioClip GetAudioClip(UnityEngine.WWW www, bool threeD)
- public static UnityEngine.AudioClip GetAudioClip(UnityEngine.WWW www, bool threeD, bool stream)
- public static UnityEngine.AudioClip GetAudioClip(UnityEngine.WWW www, bool threeD, bool stream, UnityEngine.AudioType audioType)
- public static UnityEngine.AudioClip GetAudioClipCompressed(UnityEngine.WWW www)
- public static UnityEngine.AudioClip GetAudioClipCompressed(UnityEngine.WWW www, bool threeD)
- public static UnityEngine.AudioClip GetAudioClipCompressed(UnityEngine.WWW www, bool threeD, UnityEngine.AudioType audioType)
- public static UnityEngine.MovieTexture GetMovieTexture(UnityEngine.WWW www)

## Namespace: UnityEngine.Networking

### internal static class UnityEngine.Networking.WebRequestWWW

#### Methods
- internal static UnityEngine.AudioClip InternalCreateAudioClipUsingDH(UnityEngine.Networking.DownloadHandler dh, string url, bool stream, bool compressed, UnityEngine.AudioType audioType)

