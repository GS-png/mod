# Assembly: UnityEngine.UnityWebRequestAudioModule
- Path: tools/WorldBox.Managed/UnityEngine.UnityWebRequestAudioModule.dll
- Types: 3

## Namespace: UnityEngine.Networking

### public class UnityEngine.Networking.DownloadHandlerAudioClip
- Base: UnityEngine.Networking.DownloadHandler
- Interfaces: System.IDisposable

#### Fields
- private Unity.Collections.NativeArray<byte> m_NativeData

#### Properties
- public UnityEngine.AudioClip audioClip { get; }
- public bool compressed { get; set; }
- public bool streamAudio { get; set; }

#### Constructors
- public DownloadHandlerAudioClip(string url, UnityEngine.AudioType audioType)
- public DownloadHandlerAudioClip(System.Uri uri, UnityEngine.AudioType audioType)

#### Methods
- private static System.IntPtr Create(UnityEngine.Networking.DownloadHandlerAudioClip obj, string url, UnityEngine.AudioType audioType)
- public override void Dispose()
- public static UnityEngine.AudioClip GetContent(UnityEngine.Networking.UnityWebRequest www)
- protected override Unity.Collections.NativeArray<byte> GetNativeData()
- protected override string GetText()
- private void InternalCreateAudioClip(string url, UnityEngine.AudioType audioType)

### public class UnityEngine.Networking.DownloadHandlerMovieTexture
- Base: UnityEngine.Networking.DownloadHandler
- Interfaces: System.IDisposable

#### Properties
- public UnityEngine.MovieTexture movieTexture { get; }

#### Constructors
- public DownloadHandlerMovieTexture()

#### Methods
- private static void FeatureRemoved()
- public static UnityEngine.MovieTexture GetContent(UnityEngine.Networking.UnityWebRequest uwr)
- protected override byte[] GetData()
- protected override string GetText()

### public static class UnityEngine.Networking.UnityWebRequestMultimedia

#### Methods
- public static UnityEngine.Networking.UnityWebRequest GetAudioClip(string uri, UnityEngine.AudioType audioType)
- public static UnityEngine.Networking.UnityWebRequest GetAudioClip(System.Uri uri, UnityEngine.AudioType audioType)
- public static UnityEngine.Networking.UnityWebRequest GetMovieTexture(string uri)
- public static UnityEngine.Networking.UnityWebRequest GetMovieTexture(System.Uri uri)

