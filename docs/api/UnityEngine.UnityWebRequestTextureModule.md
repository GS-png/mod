# Assembly: UnityEngine.UnityWebRequestTextureModule
- Path: tools/WorldBox.Managed/UnityEngine.UnityWebRequestTextureModule.dll
- Types: 2

## Namespace: UnityEngine.Networking

### public class UnityEngine.Networking.DownloadHandlerTexture
- Base: UnityEngine.Networking.DownloadHandler
- Interfaces: System.IDisposable

#### Fields
- private bool mNonReadable
- private Unity.Collections.NativeArray<byte> m_NativeData

#### Properties
- public UnityEngine.Texture2D texture { get; }

#### Constructors
- public DownloadHandlerTexture()
- public DownloadHandlerTexture(bool readable)

#### Methods
- private static System.IntPtr Create(UnityEngine.Networking.DownloadHandlerTexture obj, bool readable)
- public override void Dispose()
- public static UnityEngine.Texture2D GetContent(UnityEngine.Networking.UnityWebRequest www)
- protected override Unity.Collections.NativeArray<byte> GetNativeData()
- private void InternalCreateTexture(bool readable)
- private UnityEngine.Texture2D InternalGetTextureNative()

### public static class UnityEngine.Networking.UnityWebRequestTexture

#### Methods
- public static UnityEngine.Networking.UnityWebRequest GetTexture(string uri)
- public static UnityEngine.Networking.UnityWebRequest GetTexture(System.Uri uri)
- public static UnityEngine.Networking.UnityWebRequest GetTexture(string uri, bool nonReadable)
- public static UnityEngine.Networking.UnityWebRequest GetTexture(System.Uri uri, bool nonReadable)

