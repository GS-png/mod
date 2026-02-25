# Assembly: UnityEngine.UnityWebRequestAssetBundleModule
- Path: tools/WorldBox.Managed/UnityEngine.UnityWebRequestAssetBundleModule.dll
- Types: 2

## Namespace: UnityEngine.Networking

### public class UnityEngine.Networking.DownloadHandlerAssetBundle
- Base: UnityEngine.Networking.DownloadHandler
- Interfaces: System.IDisposable

#### Properties
- public UnityEngine.AssetBundle assetBundle { get; }
- public bool autoLoadAssetBundle { get; set; }
- public bool isDownloadComplete { get; }

#### Constructors
- public DownloadHandlerAssetBundle(string url, uint crc)
- public DownloadHandlerAssetBundle(string url, uint version, uint crc)
- public DownloadHandlerAssetBundle(string url, UnityEngine.Hash128 hash, uint crc)
- public DownloadHandlerAssetBundle(string url, UnityEngine.CachedAssetBundle cachedBundle, uint crc)
- public DownloadHandlerAssetBundle(string url, string name, UnityEngine.Hash128 hash, uint crc)

#### Methods
- private static System.IntPtr Create(UnityEngine.Networking.DownloadHandlerAssetBundle obj, string url, uint crc)
- private static System.IntPtr CreateCached(UnityEngine.Networking.DownloadHandlerAssetBundle obj, string url, string name, UnityEngine.Hash128 hash, uint crc)
- private static System.IntPtr CreateCached_Injected(UnityEngine.Networking.DownloadHandlerAssetBundle obj, string url, string name, ref UnityEngine.Hash128 hash, uint crc)
- public static UnityEngine.AssetBundle GetContent(UnityEngine.Networking.UnityWebRequest www)
- protected override byte[] GetData()
- protected override string GetText()
- private void InternalCreateAssetBundle(string url, uint crc)
- private void InternalCreateAssetBundleCached(string url, string name, UnityEngine.Hash128 hash, uint crc)

### public static class UnityEngine.Networking.UnityWebRequestAssetBundle

#### Methods
- public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri)
- public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.Uri uri)
- public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri, uint crc)
- public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.Uri uri, uint crc)
- public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri, uint version, uint crc)
- public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.Uri uri, uint version, uint crc)
- public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri, UnityEngine.Hash128 hash, uint crc = 0)
- public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.Uri uri, UnityEngine.Hash128 hash, uint crc = 0)
- public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri, UnityEngine.CachedAssetBundle cachedAssetBundle, uint crc = 0)
- public static UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.Uri uri, UnityEngine.CachedAssetBundle cachedAssetBundle, uint crc = 0)

