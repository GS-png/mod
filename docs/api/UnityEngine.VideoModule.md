# Assembly: UnityEngine.VideoModule
- Path: tools/WorldBox.Managed/UnityEngine.VideoModule.dll
- Types: 24

## Namespace: UnityEngine.Experimental.Video

### public struct UnityEngine.Experimental.Video.VideoClipPlayable
- Interfaces: UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Experimental.Video.VideoClipPlayable>

#### Fields
- private UnityEngine.Playables.PlayableHandle m_Handle

#### Constructors
- internal VideoClipPlayable(UnityEngine.Playables.PlayableHandle handle)

#### Methods
- public static UnityEngine.Experimental.Video.VideoClipPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Video.VideoClip clip, bool looping)
- private static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Video.VideoClip clip, bool looping)
- public bool Equals(UnityEngine.Experimental.Video.VideoClipPlayable other)
- public UnityEngine.Video.VideoClip GetClip()
- private static UnityEngine.Video.VideoClip GetClipInternal(ref UnityEngine.Playables.PlayableHandle hdl)
- public UnityEngine.Playables.PlayableHandle GetHandle()
- private static bool GetIsPlayingInternal(ref UnityEngine.Playables.PlayableHandle hdl)
- public bool GetLooped()
- private static bool GetLoopedInternal(ref UnityEngine.Playables.PlayableHandle hdl)
- public double GetPauseDelay()
- internal void GetPauseDelay(double value)
- private static double GetPauseDelayInternal(ref UnityEngine.Playables.PlayableHandle hdl)
- public double GetStartDelay()
- private static double GetStartDelayInternal(ref UnityEngine.Playables.PlayableHandle hdl)
- private static bool InternalCreateVideoClipPlayable(ref UnityEngine.Playables.PlayableGraph graph, UnityEngine.Video.VideoClip clip, bool looping, ref UnityEngine.Playables.PlayableHandle handle)
- public bool IsPlaying()
- public static UnityEngine.Experimental.Video.VideoClipPlayable op_Explicit(UnityEngine.Playables.Playable playable)
- public static UnityEngine.Playables.Playable op_Implicit(UnityEngine.Experimental.Video.VideoClipPlayable playable)
- public void Seek(double startTime, double startDelay)
- public void Seek(double startTime, double startDelay, double duration)
- public void SetClip(UnityEngine.Video.VideoClip value)
- private static void SetClipInternal(ref UnityEngine.Playables.PlayableHandle hdl, UnityEngine.Video.VideoClip clip)
- public void SetLooped(bool value)
- private static void SetLoopedInternal(ref UnityEngine.Playables.PlayableHandle hdl, bool looped)
- private static void SetPauseDelayInternal(ref UnityEngine.Playables.PlayableHandle hdl, double delay)
- internal void SetStartDelay(double value)
- private static void SetStartDelayInternal(ref UnityEngine.Playables.PlayableHandle hdl, double delay)
- private void ValidateStartDelayInternal(double startDelay)
- private static bool ValidateType(ref UnityEngine.Playables.PlayableHandle hdl)

### public static class UnityEngine.Experimental.Video.VideoPlayerExtensions

#### Methods
- public static UnityEngine.Experimental.Audio.AudioSampleProvider GetAudioSampleProvider(UnityEngine.Video.VideoPlayer vp, ushort trackIndex)
- internal static uint InternalGetAudioSampleProviderId(UnityEngine.Video.VideoPlayer vp, ushort trackIndex)

## Namespace: UnityEngine.Video

### public delegate UnityEngine.Video.VideoPlayer.ErrorEventHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public VideoPlayer.ErrorEventHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(UnityEngine.Video.VideoPlayer source, string message, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(UnityEngine.Video.VideoPlayer source, string message)

### public delegate UnityEngine.Video.VideoPlayer.EventHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public VideoPlayer.EventHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(UnityEngine.Video.VideoPlayer source, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(UnityEngine.Video.VideoPlayer source)

### public delegate UnityEngine.Video.VideoPlayer.FrameReadyEventHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public VideoPlayer.FrameReadyEventHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(UnityEngine.Video.VideoPlayer source, long frameIdx, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(UnityEngine.Video.VideoPlayer source, long frameIdx)

### public delegate UnityEngine.Video.VideoPlayer.TimeEventHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public VideoPlayer.TimeEventHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(UnityEngine.Video.VideoPlayer source, double seconds, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(UnityEngine.Video.VideoPlayer source, double seconds)

### public enum UnityEngine.Video.Video3DLayout
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- No3D = 0
- OverUnder3D = 2
- SideBySide3D = 1

### public enum UnityEngine.Video.VideoAspectRatio
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FitHorizontally = 2
- FitInside = 3
- FitOutside = 4
- FitVertically = 1
- NoScaling = 0
- Stretch = 5

### public enum UnityEngine.Video.VideoAudioOutputMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- APIOnly = 3
- AudioSource = 1
- Direct = 2
- None = 0

### public class UnityEngine.Video.VideoClip
- Base: UnityEngine.Object

#### Properties
- public ushort audioTrackCount { get; }
- public ulong frameCount { get; }
- public double frameRate { get; }
- public uint height { get; }
- public double length { get; }
- public string originalPath { get; }
- public uint pixelAspectRatioDenominator { get; }
- public uint pixelAspectRatioNumerator { get; }
- public bool sRGB { get; }
- public uint width { get; }

#### Constructors
- private VideoClip()

#### Methods
- public ushort GetAudioChannelCount(ushort audioTrackIdx)
- public string GetAudioLanguage(ushort audioTrackIdx)
- public uint GetAudioSampleRate(ushort audioTrackIdx)

### public class UnityEngine.Video.VideoPlayer
- Base: UnityEngine.Behaviour

#### Fields
- private UnityEngine.Video.VideoPlayer.TimeEventHandler clockResyncOccurred
- private UnityEngine.Video.VideoPlayer.ErrorEventHandler errorReceived
- private UnityEngine.Video.VideoPlayer.EventHandler frameDropped
- private UnityEngine.Video.VideoPlayer.FrameReadyEventHandler frameReady
- private UnityEngine.Video.VideoPlayer.EventHandler loopPointReached
- private UnityEngine.Video.VideoPlayer.EventHandler prepareCompleted
- private UnityEngine.Video.VideoPlayer.EventHandler seekCompleted
- private UnityEngine.Video.VideoPlayer.EventHandler started

#### Properties
- public UnityEngine.Video.VideoAspectRatio aspectRatio { get; set; }
- public UnityEngine.Video.VideoAudioOutputMode audioOutputMode { get; set; }
- public ushort audioTrackCount { get; }
- public bool canSetDirectAudioVolume { get; }
- public bool canSetPlaybackSpeed { get; }
- public bool canSetSkipOnDrop { get; }
- public bool canSetTime { get; }
- public bool canSetTimeSource { get; }
- public bool canSetTimeUpdateMode { get; }
- public bool canStep { get; }
- public UnityEngine.Video.VideoClip clip { get; set; }
- public double clockTime { get; }
- public ushort controlledAudioTrackCount { get; set; }
- public static ushort controlledAudioTrackMaxCount { get; }
- public double externalReferenceTime { get; set; }
- public long frame { get; set; }
- public ulong frameCount { get; }
- public float frameRate { get; }
- public uint height { get; }
- public bool isLooping { get; set; }
- public bool isPaused { get; }
- public bool isPlaying { get; }
- public bool isPrepared { get; }
- public double length { get; }
- public uint pixelAspectRatioDenominator { get; }
- public uint pixelAspectRatioNumerator { get; }
- public float playbackSpeed { get; set; }
- public bool playOnAwake { get; set; }
- public UnityEngine.Video.VideoRenderMode renderMode { get; set; }
- public bool sendFrameReadyEvents { get; set; }
- public bool skipOnDrop { get; set; }
- public UnityEngine.Video.VideoSource source { get; set; }
- public UnityEngine.Camera targetCamera { get; set; }
- public UnityEngine.Video.Video3DLayout targetCamera3DLayout { get; set; }
- public float targetCameraAlpha { get; set; }
- public string targetMaterialProperty { get; set; }
- public UnityEngine.Renderer targetMaterialRenderer { get; set; }
- public UnityEngine.RenderTexture targetTexture { get; set; }
- public UnityEngine.Texture texture { get; }
- public double time { get; set; }
- public UnityEngine.Video.VideoTimeReference timeReference { get; set; }
- public UnityEngine.Video.VideoTimeSource timeSource { get; set; }
- public UnityEngine.Video.VideoTimeUpdateMode timeUpdateMode { get; set; }
- public string url { get; set; }
- public bool waitForFirstFrame { get; set; }
- public uint width { get; }

#### Events
- public event UnityEngine.Video.VideoPlayer.TimeEventHandler clockResyncOccurred
- public event UnityEngine.Video.VideoPlayer.ErrorEventHandler errorReceived
- public event UnityEngine.Video.VideoPlayer.EventHandler frameDropped
- public event UnityEngine.Video.VideoPlayer.FrameReadyEventHandler frameReady
- public event UnityEngine.Video.VideoPlayer.EventHandler loopPointReached
- public event UnityEngine.Video.VideoPlayer.EventHandler prepareCompleted
- public event UnityEngine.Video.VideoPlayer.EventHandler seekCompleted
- public event UnityEngine.Video.VideoPlayer.EventHandler started

#### Constructors
- public VideoPlayer()

#### Methods
- public void EnableAudioTrack(ushort trackIndex, bool enabled)
- public ushort GetAudioChannelCount(ushort trackIndex)
- public string GetAudioLanguageCode(ushort trackIndex)
- public uint GetAudioSampleRate(ushort trackIndex)
- private ushort GetControlledAudioTrackCount()
- public bool GetDirectAudioMute(ushort trackIndex)
- public float GetDirectAudioVolume(ushort trackIndex)
- public UnityEngine.AudioSource GetTargetAudioSource(ushort trackIndex)
- private static void InvokeClockResyncOccurredCallback_Internal(UnityEngine.Video.VideoPlayer source, double seconds)
- private static void InvokeErrorReceivedCallback_Internal(UnityEngine.Video.VideoPlayer source, string errorStr)
- private static void InvokeFrameDroppedCallback_Internal(UnityEngine.Video.VideoPlayer source)
- private static void InvokeFrameReadyCallback_Internal(UnityEngine.Video.VideoPlayer source, long frameIdx)
- private static void InvokeLoopPointReachedCallback_Internal(UnityEngine.Video.VideoPlayer source)
- private static void InvokePrepareCompletedCallback_Internal(UnityEngine.Video.VideoPlayer source)
- private static void InvokeSeekCompletedCallback_Internal(UnityEngine.Video.VideoPlayer source)
- private static void InvokeStartedCallback_Internal(UnityEngine.Video.VideoPlayer source)
- public bool IsAudioTrackEnabled(ushort trackIndex)
- public void Pause()
- public void Play()
- public void Prepare()
- private void SetControlledAudioTrackCount(ushort value)
- public void SetDirectAudioMute(ushort trackIndex, bool mute)
- public void SetDirectAudioVolume(ushort trackIndex, float volume)
- public void SetTargetAudioSource(ushort trackIndex, UnityEngine.AudioSource source)
- public void StepForward()
- public void Stop()

### public enum UnityEngine.Video.VideoRenderMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- APIOnly = 4
- CameraFarPlane = 0
- CameraNearPlane = 1
- MaterialOverride = 3
- RenderTexture = 2

### public enum UnityEngine.Video.VideoSource
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Url = 1
- VideoClip = 0

### public enum UnityEngine.Video.VideoTimeReference
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ExternalTime = 2
- Freerun = 0
- InternalTime = 1

### public enum UnityEngine.Video.VideoTimeSource
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AudioDSPTimeSource = 0
- GameTimeSource = 1

### public enum UnityEngine.Video.VideoTimeUpdateMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DSPTime = 0
- GameTime = 1
- UnscaledGameTime = 2

## Namespace: UnityEngineInternal.Video

### public delegate UnityEngineInternal.Video.VideoPlayback.Callback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public VideoPlayback.Callback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke()

### public delegate UnityEngineInternal.Video.VideoPlaybackMgr.Callback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public VideoPlaybackMgr.Callback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke()

### public delegate UnityEngineInternal.Video.VideoPlaybackMgr.MessageCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public VideoPlaybackMgr.MessageCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(string message, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(string message)

### internal enum UnityEngineInternal.Video.VideoAlphaLayout
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Native = 0
- Split = 1

### internal enum UnityEngineInternal.Video.VideoError
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BadParams = 4
- BadPermissions = 6
- CantReadFile = 2
- CantWriteFile = 3
- DeviceNotAvailable = 7
- NetworkErr = 9
- NoData = 5
- NoErr = 0
- OutOfMemoryErr = 1
- ResourceNotAvailable = 8

### internal enum UnityEngineInternal.Video.VideoPixelFormat
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- RGB = 0
- RGBA = 1
- YUV = 2
- YUVA = 3

### internal class UnityEngineInternal.Video.VideoPlayback

#### Fields
- internal System.IntPtr m_Ptr

#### Constructors
- public VideoPlayback()

#### Methods
- public bool CanNotSkipOnDrop()
- public bool CanStep()
- public ushort GetAudioChannelCount(ushort trackIdx)
- public string GetAudioLanguageCode(ushort trackIdx)
- public UnityEngine.Experimental.Audio.AudioSampleProvider GetAudioSampleProvider(ushort trackIndex)
- private uint GetAudioSampleProviderId(ushort trackIndex)
- public uint GetAudioSampleRate(ushort trackIdx)
- public ushort GetAudioTrackCount()
- public float GetDuration()
- public ulong GetFrameCount()
- public float GetFrameRate()
- public uint GetHeight()
- public bool GetLoop()
- public uint GetPixelAspectRatioDenominator()
- public uint GetPixelAspectRatioNumerator()
- public UnityEngineInternal.Video.VideoPixelFormat GetPixelFormat()
- public float GetPlaybackSpeed()
- public UnityEngineInternal.Video.VideoError GetStatus()
- public bool GetTexture(UnityEngine.Texture texture, out long outputFrameNum)
- public uint GetWidth()
- public bool IsPlaying()
- public bool IsReady()
- public void PausePlayback()
- internal static bool PlatformSupportsH265()
- public void SeekToFrame(long frameIndex, UnityEngineInternal.Video.VideoPlayback.Callback seekCompletedCallback)
- public void SeekToTime(double secs, UnityEngineInternal.Video.VideoPlayback.Callback seekCompletedCallback)
- public void SetAdjustToLinearSpace(bool enable)
- public void SetAudioTarget(ushort trackIdx, bool enabled, bool softwareOutput, UnityEngine.AudioSource audioSource)
- public void SetLoop(bool value)
- public void SetPlaybackSpeed(float value)
- public void SetSkipOnDrop(bool skipOnDrop)
- public void StartPlayback()
- public void Step()
- public void StopPlayback()

### internal class UnityEngineInternal.Video.VideoPlaybackMgr
- Interfaces: System.IDisposable

#### Fields
- internal System.IntPtr m_Ptr

#### Properties
- public ulong videoPlaybackCount { get; }

#### Constructors
- public VideoPlaybackMgr()

#### Methods
- public UnityEngineInternal.Video.VideoPlayback CreateVideoPlayback(string fileName, UnityEngineInternal.Video.VideoPlaybackMgr.MessageCallback errorCallback, UnityEngineInternal.Video.VideoPlaybackMgr.Callback readyCallback, UnityEngineInternal.Video.VideoPlaybackMgr.Callback reachedEndCallback, bool splitAlpha = false)
- public void Dispose()
- private static System.IntPtr Internal_Create()
- private static void Internal_Destroy(System.IntPtr ptr)
- internal static void ProcessOSMainLoopMessagesForTesting()
- public void ReleaseVideoPlayback(UnityEngineInternal.Video.VideoPlayback playback)
- public void Update()

