# Assembly: UnityEngine.AudioModule
- Path: tools/WorldBox.Managed/UnityEngine.AudioModule.dll
- Types: 53

## Namespace: Unity.Audio

### internal interface Unity.Audio.IHandle<HandleType>
- Interfaces: Unity.Audio.IValidatable, System.IEquatable<HandleType>

### internal interface Unity.Audio.IValidatable

#### Properties
- public bool Valid { get; }

## Namespace: UnityEngine

### public class UnityEngine.AudioBehaviour
- Base: UnityEngine.Behaviour

#### Constructors
- public AudioBehaviour()

### public class UnityEngine.AudioChorusFilter
- Base: UnityEngine.Behaviour

#### Properties
- public float delay { get; set; }
- public float depth { get; set; }
- public float dryMix { get; set; }
- public float feedback { get; set; }
- public float rate { get; set; }
- public float wetMix1 { get; set; }
- public float wetMix2 { get; set; }
- public float wetMix3 { get; set; }

#### Constructors
- public AudioChorusFilter()

### public class UnityEngine.AudioClip
- Base: UnityEngine.Object

#### Fields
- private UnityEngine.AudioClip.PCMReaderCallback m_PCMReaderCallback
- private UnityEngine.AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback

#### Properties
- public bool ambisonic { get; }
- public int channels { get; }
- public int frequency { get; }
- public bool isReadyToPlay { get; }
- public float length { get; }
- public bool loadInBackground { get; }
- public UnityEngine.AudioDataLoadState loadState { get; }
- public UnityEngine.AudioClipLoadType loadType { get; }
- public bool preloadAudioData { get; }
- public int samples { get; }

#### Events
- private event UnityEngine.AudioClip.PCMReaderCallback m_PCMReaderCallback
- private event UnityEngine.AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback

#### Constructors
- private AudioClip()

#### Methods
- private static UnityEngine.AudioClip Construct_Internal()
- public static UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream)
- public static UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, UnityEngine.AudioClip.PCMReaderCallback pcmreadercallback)
- public static UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, UnityEngine.AudioClip.PCMReaderCallback pcmreadercallback, UnityEngine.AudioClip.PCMSetPositionCallback pcmsetpositioncallback)
- public static UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream)
- public static UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, UnityEngine.AudioClip.PCMReaderCallback pcmreadercallback)
- public static UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, UnityEngine.AudioClip.PCMReaderCallback pcmreadercallback, UnityEngine.AudioClip.PCMSetPositionCallback pcmsetpositioncallback)
- private void CreateUserSound(string name, int lengthSamples, int channels, int frequency, bool stream)
- private static bool GetData(UnityEngine.AudioClip clip, float[] data, int numSamples, int samplesOffset)
- public bool GetData(float[] data, int offsetSamples)
- private string GetName()
- private void InvokePCMReaderCallback_Internal(float[] data)
- private void InvokePCMSetPositionCallback_Internal(int position)
- public bool LoadAudioData()
- private static bool SetData(UnityEngine.AudioClip clip, float[] data, int numsamples, int samplesOffset)
- public bool SetData(float[] data, int offsetSamples)
- public bool UnloadAudioData()

### public enum UnityEngine.AudioClipLoadType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CompressedInMemory = 1
- DecompressOnLoad = 0
- Streaming = 2

### public enum UnityEngine.AudioCompressionFormat
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AAC = 7
- ADPCM = 2
- ATRAC9 = 9
- GCADPCM = 8
- HEVAG = 5
- MP3 = 3
- PCM = 0
- VAG = 4
- Vorbis = 1
- XMA = 6

### public struct UnityEngine.AudioConfiguration

#### Fields
- public int dspBufferSize
- public int numRealVoices
- public int numVirtualVoices
- public int sampleRate
- public UnityEngine.AudioSpeakerMode speakerMode

### public delegate UnityEngine.AudioSettings.AudioConfigurationChangeHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public AudioSettings.AudioConfigurationChangeHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(bool deviceWasChanged, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(bool deviceWasChanged)

### public enum UnityEngine.AudioDataLoadState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Failed = 3
- Loaded = 2
- Loading = 1
- Unloaded = 0

### public class UnityEngine.AudioDistortionFilter
- Base: UnityEngine.Behaviour

#### Properties
- public float distortionLevel { get; set; }

#### Constructors
- public AudioDistortionFilter()

### public class UnityEngine.AudioEchoFilter
- Base: UnityEngine.Behaviour

#### Properties
- public float decayRatio { get; set; }
- public float delay { get; set; }
- public float dryMix { get; set; }
- public float wetMix { get; set; }

#### Constructors
- public AudioEchoFilter()

### public class UnityEngine.AudioHighPassFilter
- Base: UnityEngine.Behaviour

#### Properties
- public float cutoffFrequency { get; set; }
- public float highpassResonanceQ { get; set; }

#### Constructors
- public AudioHighPassFilter()

### public class UnityEngine.AudioListener
- Base: UnityEngine.AudioBehaviour

#### Properties
- public static bool pause { get; set; }
- public UnityEngine.AudioVelocityUpdateMode velocityUpdateMode { get; set; }
- public static float volume { get; set; }

#### Constructors
- public AudioListener()

#### Methods
- public static float[] GetOutputData(int numSamples, int channel)
- public static void GetOutputData(float[] samples, int channel)
- private static void GetOutputDataHelper(float[] samples, int channel)
- public static float[] GetSpectrumData(int numSamples, int channel, UnityEngine.FFTWindow window)
- public static void GetSpectrumData(float[] samples, int channel, UnityEngine.FFTWindow window)
- private static void GetSpectrumDataHelper(float[] samples, int channel, UnityEngine.FFTWindow window)

### public class UnityEngine.AudioLowPassFilter
- Base: UnityEngine.Behaviour

#### Properties
- public UnityEngine.AnimationCurve customCutoffCurve { get; set; }
- public float cutoffFrequency { get; set; }
- public float lowpassResonanceQ { get; set; }

#### Constructors
- public AudioLowPassFilter()

#### Methods
- private UnityEngine.AnimationCurve GetCustomLowpassLevelCurveCopy()
- private static void SetCustomLowpassLevelCurveHelper(UnityEngine.AudioLowPassFilter source, UnityEngine.AnimationCurve curve)

### public class UnityEngine.AudioRenderer

#### Constructors
- public AudioRenderer()

#### Methods
- internal static bool AddMixerGroupSink(UnityEngine.Audio.AudioMixerGroup mixerGroup, Unity.Collections.NativeArray<float> buffer, bool excludeFromMix)
- public static int GetSampleCountForCaptureFrame()
- internal static bool Internal_AudioRenderer_AddMixerGroupSink(UnityEngine.Audio.AudioMixerGroup mixerGroup, void* ptr, int length, bool excludeFromMix)
- internal static int Internal_AudioRenderer_GetSampleCountForCaptureFrame()
- internal static bool Internal_AudioRenderer_Render(void* ptr, int length)
- internal static bool Internal_AudioRenderer_Start()
- internal static bool Internal_AudioRenderer_Stop()
- public static bool Render(Unity.Collections.NativeArray<float> buffer)
- public static bool Start()
- public static bool Stop()

### public class UnityEngine.AudioReverbFilter
- Base: UnityEngine.Behaviour

#### Properties
- public float decayHFRatio { get; set; }
- public float decayTime { get; set; }
- public float density { get; set; }
- public float diffusion { get; set; }
- public float dryLevel { get; set; }
- public float hfReference { get; set; }
- public float lfReference { get; set; }
- public float reflectionsDelay { get; set; }
- public float reflectionsLevel { get; set; }
- public float reverbDelay { get; set; }
- public float reverbLevel { get; set; }
- public UnityEngine.AudioReverbPreset reverbPreset { get; set; }
- public float room { get; set; }
- public float roomHF { get; set; }
- public float roomLF { get; set; }
- public float roomRolloffFactor { get; set; }

#### Constructors
- public AudioReverbFilter()

### public enum UnityEngine.AudioReverbPreset
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Alley = 15
- Arena = 10
- Auditorium = 7
- Bathroom = 4
- CarpetedHallway = 12
- Cave = 9
- City = 17
- Concerthall = 8
- Dizzy = 25
- Drugged = 24
- Forest = 16
- Generic = 1
- Hallway = 13
- Hangar = 11
- Livingroom = 5
- Mountains = 18
- Off = 0
- PaddedCell = 2
- ParkingLot = 21
- Plain = 20
- Psychotic = 26
- Quarry = 19
- Room = 3
- SewerPipe = 22
- StoneCorridor = 14
- Stoneroom = 6
- Underwater = 23
- User = 27

### public class UnityEngine.AudioReverbZone
- Base: UnityEngine.Behaviour

#### Properties
- public float decayHFRatio { get; set; }
- public float decayTime { get; set; }
- public float density { get; set; }
- public float diffusion { get; set; }
- public float HFReference { get; set; }
- public float LFReference { get; set; }
- public float maxDistance { get; set; }
- public float minDistance { get; set; }
- public int reflections { get; set; }
- public float reflectionsDelay { get; set; }
- public int reverb { get; set; }
- public float reverbDelay { get; set; }
- public UnityEngine.AudioReverbPreset reverbPreset { get; set; }
- public int room { get; set; }
- public int roomHF { get; set; }
- public int roomLF { get; set; }
- public float roomRolloffFactor { get; set; }

#### Constructors
- public AudioReverbZone()

### public enum UnityEngine.AudioRolloffMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Custom = 2
- Linear = 1
- Logarithmic = 0

### public class UnityEngine.AudioSettings

#### Fields
- private static UnityEngine.AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged
- private static System.Action OnAudioSystemShuttingDown
- private static System.Action OnAudioSystemStartedUp

#### Properties
- public static UnityEngine.AudioSpatialExperience audioSpatialExperience { get; set; }
- public static UnityEngine.AudioSpeakerMode driverCapabilities { get; }
- public static double dspTime { get; }
- public static int outputSampleRate { get; set; }
- internal static int profilerCaptureFlags { get; }
- public static UnityEngine.AudioSpeakerMode speakerMode { get; set; }
- internal static bool unityAudioDisabled { get; set; }

#### Events
- public static event UnityEngine.AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged
- internal static event System.Action OnAudioSystemShuttingDown
- internal static event System.Action OnAudioSystemStartedUp

#### Constructors
- public AudioSettings()

#### Methods
- internal static string GetAmbisonicDecoderPluginName()
- public static UnityEngine.AudioConfiguration GetConfiguration()
- private static void GetConfiguration_Injected(out UnityEngine.AudioConfiguration ret)
- public static void GetDSPBufferSize(out int bufferLength, out int numBuffers)
- private static int GetSampleRate()
- public static string GetSpatializerPluginName()
- private static UnityEngine.AudioSpeakerMode GetSpeakerMode()
- internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged)
- internal static void InvokeOnAudioSystemShuttingDown()
- internal static void InvokeOnAudioSystemStartedUp()
- public static bool Reset(UnityEngine.AudioConfiguration config)
- private static bool SetConfiguration(UnityEngine.AudioConfiguration config)
- private static bool SetConfiguration_Injected(ref UnityEngine.AudioConfiguration config)
- public static void SetDSPBufferSize(int bufferLength, int numBuffers)

### public class UnityEngine.AudioSource
- Base: UnityEngine.AudioBehaviour

#### Properties
- public bool bypassEffects { get; set; }
- public bool bypassListenerEffects { get; set; }
- public bool bypassReverbZones { get; set; }
- public UnityEngine.AudioClip clip { get; set; }
- public float dopplerLevel { get; set; }
- public bool ignoreListenerPause { get; set; }
- public bool ignoreListenerVolume { get; set; }
- public bool isPlaying { get; }
- public bool isVirtual { get; }
- public bool loop { get; set; }
- public float maxDistance { get; set; }
- public float maxVolume { get; set; }
- public float minDistance { get; set; }
- public float minVolume { get; set; }
- public bool mute { get; set; }
- public UnityEngine.Audio.AudioMixerGroup outputAudioMixerGroup { get; set; }
- public float panStereo { get; set; }
- public float pitch { get; set; }
- public bool playOnAwake { get; set; }
- public int priority { get; set; }
- public float reverbZoneMix { get; set; }
- public float rolloffFactor { get; set; }
- public UnityEngine.AudioRolloffMode rolloffMode { get; set; }
- public float spatialBlend { get; set; }
- public bool spatialize { get; set; }
- public bool spatializePostEffects { get; set; }
- public float spread { get; set; }
- public float time { get; set; }
- public int timeSamples { get; set; }
- public UnityEngine.AudioVelocityUpdateMode velocityUpdateMode { get; set; }
- public float volume { get; set; }

#### Constructors
- public AudioSource()

#### Methods
- public bool GetAmbisonicDecoderFloat(int index, out float value)
- public UnityEngine.AnimationCurve GetCustomCurve(UnityEngine.AudioSourceCurveType type)
- private static UnityEngine.AnimationCurve GetCustomCurveHelper(UnityEngine.AudioSource source, UnityEngine.AudioSourceCurveType type)
- public float[] GetOutputData(int numSamples, int channel)
- public void GetOutputData(float[] samples, int channel)
- private static void GetOutputDataHelper(UnityEngine.AudioSource source, float[] samples, int channel)
- private static float GetPitch(UnityEngine.AudioSource source)
- public bool GetSpatializerFloat(int index, out float value)
- public float[] GetSpectrumData(int numSamples, int channel, UnityEngine.FFTWindow window)
- public void GetSpectrumData(float[] samples, int channel, UnityEngine.FFTWindow window)
- private static void GetSpectrumDataHelper(UnityEngine.AudioSource source, float[] samples, int channel, UnityEngine.FFTWindow window)
- public void Pause()
- private void Play(double delay)
- public void Play()
- public void Play(ulong delay)
- public static void PlayClipAtPoint(UnityEngine.AudioClip clip, UnityEngine.Vector3 position)
- public static void PlayClipAtPoint(UnityEngine.AudioClip clip, UnityEngine.Vector3 position, float volume)
- public void PlayDelayed(float delay)
- private static void PlayHelper(UnityEngine.AudioSource source, ulong delay)
- public void PlayOneShot(UnityEngine.AudioClip clip)
- public void PlayOneShot(UnityEngine.AudioClip clip, float volumeScale)
- private static void PlayOneShotHelper(UnityEngine.AudioSource source, UnityEngine.AudioClip clip, float volumeScale)
- public void PlayScheduled(double time)
- public bool SetAmbisonicDecoderFloat(int index, float value)
- public void SetCustomCurve(UnityEngine.AudioSourceCurveType type, UnityEngine.AnimationCurve curve)
- private static void SetCustomCurveHelper(UnityEngine.AudioSource source, UnityEngine.AudioSourceCurveType type, UnityEngine.AnimationCurve curve)
- private static void SetPitch(UnityEngine.AudioSource source, float pitch)
- public void SetScheduledEndTime(double time)
- public void SetScheduledStartTime(double time)
- public bool SetSpatializerFloat(int index, float value)
- private void Stop(bool stopOneShots)
- public void Stop()
- public void UnPause()

### public enum UnityEngine.AudioSourceCurveType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CustomRolloff = 0
- ReverbZoneMix = 2
- SpatialBlend = 1
- Spread = 3

### public enum UnityEngine.AudioSpatialExperience
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Bypassed = 0
- Fixed = 2
- HeadTracked = 1

### public enum UnityEngine.AudioSpeakerMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Mode5point1 = 5
- Mode7point1 = 6
- Mono = 1
- Prologic = 7
- Quad = 3
- Raw = 0
- Stereo = 2
- Surround = 4

### public enum UnityEngine.AudioVelocityUpdateMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Auto = 0
- Dynamic = 2
- Fixed = 1

### public enum UnityEngine.FFTWindow
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Blackman = 4
- BlackmanHarris = 5
- Hamming = 2
- Hanning = 3
- Rectangular = 0
- Triangle = 1

### public class UnityEngine.Microphone

#### Properties
- public static string[] devices { get; }
- internal static bool isAnyDeviceRecording { get; }

#### Constructors
- public Microphone()

#### Methods
- public static void End(string deviceName)
- private static void EndRecord(int deviceID)
- private static void GetDeviceCaps(int deviceID, out int minFreq, out int maxFreq)
- public static void GetDeviceCaps(string deviceName, out int minFreq, out int maxFreq)
- private static int GetMicrophoneDeviceIDFromName(string name)
- public static int GetPosition(string deviceName)
- private static int GetRecordPosition(int deviceID)
- private static bool IsRecording(int deviceID)
- public static bool IsRecording(string deviceName)
- public static UnityEngine.AudioClip Start(string deviceName, bool loop, int lengthSec, int frequency)
- private static UnityEngine.AudioClip StartRecord(int deviceID, bool loop, float lengthSec, int frequency)

### public static class UnityEngine.AudioSettings.Mobile

#### Fields
- private static System.Action<bool> OnMuteStateChanged

#### Properties
- public static bool audioOutputStarted { get; }
- public static bool muteState { get; }
- public static bool stopAudioOutputOnMute { get; set; }

#### Events
- public static event System.Action<bool> OnMuteStateChanged

#### Methods
- public static void StartAudioOutput()
- public static void StopAudioOutput()

### public class UnityEngine.MovieTexture
- Base: UnityEngine.Texture

#### Properties
- public UnityEngine.AudioClip audioClip { get; }
- public float duration { get; }
- public bool isPlaying { get; }
- public bool isReadyToPlay { get; }
- public bool loop { get; set; }

#### Constructors
- private MovieTexture()

#### Methods
- private static void FeatureRemoved()
- public void Pause()
- public void Play()
- public void Stop()

### public delegate UnityEngine.AudioClip.PCMReaderCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public AudioClip.PCMReaderCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(float[] data, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(float[] data)

### public delegate UnityEngine.AudioClip.PCMSetPositionCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public AudioClip.PCMSetPositionCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(int position, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(int position)

### public struct UnityEngine.WebCamDevice

#### Fields
- internal string m_DepthCameraName
- internal int m_Flags
- internal UnityEngine.WebCamKind m_Kind
- internal string m_Name
- internal UnityEngine.Resolution[] m_Resolutions

#### Properties
- public UnityEngine.Resolution[] availableResolutions { get; }
- public string depthCameraName { get; }
- public bool isAutoFocusPointSupported { get; }
- public bool isFrontFacing { get; }
- public UnityEngine.WebCamKind kind { get; }
- public string name { get; }

### public enum UnityEngine.WebCamFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AutoFocusPointSupported = 2
- FrontFacing = 1

### public enum UnityEngine.WebCamKind
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ColorAndDepth = 3
- Telephoto = 2
- UltraWideAngle = 4
- WideAngle = 1

### public class UnityEngine.WebCamTexture
- Base: UnityEngine.Texture

#### Properties
- public System.Nullable<UnityEngine.Vector2> autoFocusPoint { get; set; }
- public string deviceName { get; set; }
- public static UnityEngine.WebCamDevice[] devices { get; }
- public bool didUpdateThisFrame { get; }
- internal UnityEngine.Vector2 internalAutoFocusPoint { get; set; }
- public bool isDepth { get; }
- public bool isPlaying { get; }
- public float requestedFPS { get; set; }
- public int requestedHeight { get; set; }
- public int requestedWidth { get; set; }
- public int videoRotationAngle { get; }
- public bool videoVerticallyMirrored { get; }

#### Constructors
- public WebCamTexture()
- public WebCamTexture(string deviceName)
- public WebCamTexture(int requestedWidth, int requestedHeight)
- public WebCamTexture(string deviceName, int requestedWidth, int requestedHeight)
- public WebCamTexture(int requestedWidth, int requestedHeight, int requestedFPS)
- public WebCamTexture(string deviceName, int requestedWidth, int requestedHeight, int requestedFPS)

#### Methods
- public UnityEngine.Color GetPixel(int x, int y)
- public UnityEngine.Color[] GetPixels()
- public UnityEngine.Color[] GetPixels(int x, int y, int blockWidth, int blockHeight)
- public UnityEngine.Color32[] GetPixels32()
- public UnityEngine.Color32[] GetPixels32(UnityEngine.Color32[] colors)
- private void GetPixel_Injected(int x, int y, out UnityEngine.Color ret)
- private static void Internal_CreateWebCamTexture(UnityEngine.WebCamTexture self, string scriptingDevice, int requestedWidth, int requestedHeight, int maxFramerate)
- public void Pause()
- public void Play()
- public void Stop()

## Namespace: UnityEngine.Audio

### public struct UnityEngine.Audio.AudioClipPlayable
- Interfaces: UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Audio.AudioClipPlayable>

#### Fields
- private UnityEngine.Playables.PlayableHandle m_Handle

#### Constructors
- internal AudioClipPlayable(UnityEngine.Playables.PlayableHandle handle)

#### Methods
- public static UnityEngine.Audio.AudioClipPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AudioClip clip, bool looping)
- private static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AudioClip clip, bool looping)
- public bool Equals(UnityEngine.Audio.AudioClipPlayable other)
- public UnityEngine.AudioClip GetClip()
- private static UnityEngine.AudioClip GetClipInternal(ref UnityEngine.Playables.PlayableHandle hdl)
- public UnityEngine.Playables.PlayableHandle GetHandle()
- private static bool GetIsChannelPlayingInternal(ref UnityEngine.Playables.PlayableHandle hdl)
- public bool GetLooped()
- private static bool GetLoopedInternal(ref UnityEngine.Playables.PlayableHandle hdl)
- public double GetPauseDelay()
- internal void GetPauseDelay(double value)
- private static double GetPauseDelayInternal(ref UnityEngine.Playables.PlayableHandle hdl)
- internal float GetSpatialBlend()
- private static float GetSpatialBlendInternal(ref UnityEngine.Playables.PlayableHandle hdl)
- public double GetStartDelay()
- private static double GetStartDelayInternal(ref UnityEngine.Playables.PlayableHandle hdl)
- internal float GetStereoPan()
- private static float GetStereoPanInternal(ref UnityEngine.Playables.PlayableHandle hdl)
- internal float GetVolume()
- private static float GetVolumeInternal(ref UnityEngine.Playables.PlayableHandle hdl)
- private static bool InternalCreateAudioClipPlayable(ref UnityEngine.Playables.PlayableGraph graph, UnityEngine.AudioClip clip, bool looping, ref UnityEngine.Playables.PlayableHandle handle)
- public bool IsChannelPlaying()
- public bool IsPlaying()
- public static UnityEngine.Audio.AudioClipPlayable op_Explicit(UnityEngine.Playables.Playable playable)
- public static UnityEngine.Playables.Playable op_Implicit(UnityEngine.Audio.AudioClipPlayable playable)
- public void Seek(double startTime, double startDelay)
- public void Seek(double startTime, double startDelay, double duration)
- public void SetClip(UnityEngine.AudioClip value)
- private static void SetClipInternal(ref UnityEngine.Playables.PlayableHandle hdl, UnityEngine.AudioClip clip)
- public void SetLooped(bool value)
- private static void SetLoopedInternal(ref UnityEngine.Playables.PlayableHandle hdl, bool looped)
- private static void SetPauseDelayInternal(ref UnityEngine.Playables.PlayableHandle hdl, double delay)
- internal void SetSpatialBlend(float value)
- private static void SetSpatialBlendInternal(ref UnityEngine.Playables.PlayableHandle hdl, float spatialBlend)
- internal void SetStartDelay(double value)
- private static void SetStartDelayInternal(ref UnityEngine.Playables.PlayableHandle hdl, double delay)
- internal void SetStereoPan(float value)
- private static void SetStereoPanInternal(ref UnityEngine.Playables.PlayableHandle hdl, float stereoPan)
- internal void SetVolume(float value)
- private static void SetVolumeInternal(ref UnityEngine.Playables.PlayableHandle hdl, float volume)
- private static bool ValidateType(ref UnityEngine.Playables.PlayableHandle hdl)

### internal class UnityEngine.Audio.AudioManagerTestProxy

#### Constructors
- public AudioManagerTestProxy()

#### Methods
- internal static bool ComputeAudibilityConsistency()

### public class UnityEngine.Audio.AudioMixer
- Base: UnityEngine.Object

#### Properties
- public UnityEngine.Audio.AudioMixerGroup outputAudioMixerGroup { get; set; }
- public UnityEngine.Audio.AudioMixerUpdateMode updateMode { get; set; }

#### Constructors
- internal AudioMixer()

#### Methods
- public bool ClearFloat(string name)
- public UnityEngine.Audio.AudioMixerGroup[] FindMatchingGroups(string subPath)
- public UnityEngine.Audio.AudioMixerSnapshot FindSnapshot(string name)
- internal float GetAbsoluteAudibilityFromGroup(UnityEngine.Audio.AudioMixerGroup group)
- public bool GetFloat(string name, out float value)
- public bool SetFloat(string name, float value)
- internal void TransitionToSnapshot(UnityEngine.Audio.AudioMixerSnapshot snapshot, float timeToReach)
- private void TransitionToSnapshotInternal(UnityEngine.Audio.AudioMixerSnapshot snapshot, float timeToReach)
- public void TransitionToSnapshots(UnityEngine.Audio.AudioMixerSnapshot[] snapshots, float[] weights, float timeToReach)

### public class UnityEngine.Audio.AudioMixerGroup
- Base: UnityEngine.Object
- Interfaces: UnityEngine.Internal.ISubAssetNotDuplicatable

#### Properties
- public UnityEngine.Audio.AudioMixer audioMixer { get; }

#### Constructors
- internal AudioMixerGroup()

### public struct UnityEngine.Audio.AudioMixerPlayable
- Interfaces: UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Audio.AudioMixerPlayable>

#### Fields
- private UnityEngine.Playables.PlayableHandle m_Handle

#### Constructors
- internal AudioMixerPlayable(UnityEngine.Playables.PlayableHandle handle)

#### Methods
- public static UnityEngine.Audio.AudioMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount = 0, bool normalizeInputVolumes = false)
- private static bool CreateAudioMixerPlayableInternal(ref UnityEngine.Playables.PlayableGraph graph, bool normalizeInputVolumes, ref UnityEngine.Playables.PlayableHandle handle)
- private static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, int inputCount, bool normalizeInputVolumes)
- public bool Equals(UnityEngine.Audio.AudioMixerPlayable other)
- public UnityEngine.Playables.PlayableHandle GetHandle()
- public static UnityEngine.Audio.AudioMixerPlayable op_Explicit(UnityEngine.Playables.Playable playable)
- public static UnityEngine.Playables.Playable op_Implicit(UnityEngine.Audio.AudioMixerPlayable playable)

### public class UnityEngine.Audio.AudioMixerSnapshot
- Base: UnityEngine.Object
- Interfaces: UnityEngine.Internal.ISubAssetNotDuplicatable

#### Properties
- public UnityEngine.Audio.AudioMixer audioMixer { get; }

#### Constructors
- internal AudioMixerSnapshot()

#### Methods
- public void TransitionTo(float timeToReach)

### public enum UnityEngine.Audio.AudioMixerUpdateMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Normal = 0
- UnscaledTime = 1

### public static class UnityEngine.Audio.AudioPlayableBinding

#### Methods
- public static UnityEngine.Playables.PlayableBinding Create(string name, UnityEngine.Object key)
- private static UnityEngine.Playables.PlayableOutput CreateAudioOutput(UnityEngine.Playables.PlayableGraph graph, string name)

### internal static class UnityEngine.Audio.AudioPlayableGraphExtensions

#### Methods
- internal static bool InternalCreateAudioOutput(ref UnityEngine.Playables.PlayableGraph graph, string name, out UnityEngine.Playables.PlayableOutputHandle handle)

### public struct UnityEngine.Audio.AudioPlayableOutput
- Interfaces: UnityEngine.Playables.IPlayableOutput

#### Fields
- private UnityEngine.Playables.PlayableOutputHandle m_Handle

#### Properties
- public static UnityEngine.Audio.AudioPlayableOutput Null { get; }

#### Constructors
- internal AudioPlayableOutput(UnityEngine.Playables.PlayableOutputHandle handle)

#### Methods
- public static UnityEngine.Audio.AudioPlayableOutput Create(UnityEngine.Playables.PlayableGraph graph, string name, UnityEngine.AudioSource target)
- public bool GetEvaluateOnSeek()
- public UnityEngine.Playables.PlayableOutputHandle GetHandle()
- public UnityEngine.AudioSource GetTarget()
- private static bool InternalGetEvaluateOnSeek(ref UnityEngine.Playables.PlayableOutputHandle output)
- private static UnityEngine.AudioSource InternalGetTarget(ref UnityEngine.Playables.PlayableOutputHandle output)
- private static void InternalSetEvaluateOnSeek(ref UnityEngine.Playables.PlayableOutputHandle output, bool value)
- private static void InternalSetTarget(ref UnityEngine.Playables.PlayableOutputHandle output, UnityEngine.AudioSource target)
- public static UnityEngine.Audio.AudioPlayableOutput op_Explicit(UnityEngine.Playables.PlayableOutput output)
- public static UnityEngine.Playables.PlayableOutput op_Implicit(UnityEngine.Audio.AudioPlayableOutput output)
- public void SetEvaluateOnSeek(bool value)
- public void SetTarget(UnityEngine.AudioSource value)

## Namespace: UnityEngine.Experimental.Audio

### internal static class UnityEngine.Experimental.Audio.AudioClipExtensionsInternal

#### Methods
- public static uint Internal_CreateAudioClipSampleProvider(UnityEngine.AudioClip audioClip, ulong start, long end, bool loop, bool allowDrop, bool loopPointIsStart = false)

### public class UnityEngine.Experimental.Audio.AudioSampleProvider
- Interfaces: System.IDisposable

#### Fields
- private ushort <channelCount>k__BackingField
- private uint <id>k__BackingField
- private UnityEngine.Object <owner>k__BackingField
- private uint <sampleRate>k__BackingField
- private ushort <trackIndex>k__BackingField
- private UnityEngine.Experimental.Audio.AudioSampleProvider.ConsumeSampleFramesNativeFunction m_ConsumeSampleFramesNativeFunction
- private UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler sampleFramesAvailable
- private UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler sampleFramesOverflow

#### Properties
- public uint availableSampleFrameCount { get; }
- public ushort channelCount { get; private set; }
- public static UnityEngine.Experimental.Audio.AudioSampleProvider.ConsumeSampleFramesNativeFunction consumeSampleFramesNativeFunction { get; }
- public bool enableSampleFramesAvailableEvents { get; set; }
- public bool enableSilencePadding { get; set; }
- public uint freeSampleFrameCount { get; }
- public uint freeSampleFrameCountLowThreshold { get; set; }
- public uint id { get; private set; }
- public uint maxSampleFrameCount { get; }
- public UnityEngine.Object owner { get; private set; }
- public uint sampleRate { get; private set; }
- public ushort trackIndex { get; private set; }
- public bool valid { get; }

#### Events
- public event UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler sampleFramesAvailable
- public event UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler sampleFramesOverflow

#### Constructors
- private AudioSampleProvider(uint providerId, UnityEngine.Object ownerObj, ushort trackIdx)

#### Methods
- public void ClearSampleFramesAvailableNativeHandler()
- public void ClearSampleFramesOverflowNativeHandler()
- public uint ConsumeSampleFrames(Unity.Collections.NativeArray<float> sampleFrames)
- internal static UnityEngine.Experimental.Audio.AudioSampleProvider Create(ushort channelCount, uint sampleRate)
- public void Dispose()
- protected override void Finalize()
- private static void InternalClearSampleFramesAvailableNativeHandler(uint providerId)
- private static void InternalClearSampleFramesOverflowNativeHandler(uint providerId)
- private static uint InternalCreateSampleProvider(ushort channelCount, uint sampleRate)
- private static uint InternalGetAvailableSampleFrameCount(uint providerId)
- private static System.IntPtr InternalGetConsumeSampleFramesNativeFunctionPtr()
- private static bool InternalGetEnableSampleFramesAvailableEvents(uint providerId)
- private static bool InternalGetEnableSilencePadding(uint id)
- private static void InternalGetFormatInfo(uint providerId, out ushort chCount, out uint sRate)
- private static uint InternalGetFreeSampleFrameCount(uint providerId)
- private static uint InternalGetFreeSampleFrameCountLowThreshold(uint providerId)
- private static uint InternalGetMaxSampleFrameCount(uint providerId)
- private static UnityEngine.Experimental.Audio.AudioSampleProvider InternalGetScriptingPtr(uint providerId)
- internal static bool InternalIsValid(uint providerId)
- private static uint InternalQueueSampleFrames(uint id, System.IntPtr interleavedSampleFrames, uint sampleFrameCount)
- internal static void InternalRemove(uint providerId)
- private static void InternalSetEnableSampleFramesAvailableEvents(uint providerId, bool enable)
- private static void InternalSetEnableSilencePadding(uint id, bool enabled)
- private static void InternalSetFreeSampleFrameCountLowThreshold(uint providerId, uint sampleFrameCount)
- private static void InternalSetSampleFramesAvailableNativeHandler(uint providerId, System.IntPtr handler, System.IntPtr userData)
- private static void InternalSetSampleFramesOverflowNativeHandler(uint providerId, System.IntPtr handler, System.IntPtr userData)
- private static void InternalSetScriptingPtr(uint providerId, UnityEngine.Experimental.Audio.AudioSampleProvider provider)
- private void InvokeSampleFramesAvailable(int sampleFrameCount)
- private void InvokeSampleFramesOverflow(int droppedSampleFrameCount)
- internal static UnityEngine.Experimental.Audio.AudioSampleProvider Lookup(uint providerId, UnityEngine.Object ownerObj, ushort trackIndex)
- internal uint QueueSampleFrames(Unity.Collections.NativeArray<float> sampleFrames)
- public void SetSampleFramesAvailableNativeHandler(UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesEventNativeFunction handler, System.IntPtr userData)
- public void SetSampleFramesOverflowNativeHandler(UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesEventNativeFunction handler, System.IntPtr userData)

### internal static class UnityEngine.Experimental.Audio.AudioSampleProviderExtensionsInternal

#### Methods
- public static float GetSpeed(UnityEngine.Experimental.Audio.AudioSampleProvider provider)
- private static float InternalGetAudioSampleProviderSpeed(uint providerId)

### internal static class UnityEngine.Experimental.Audio.AudioSourceExtensionsInternal

#### Methods
- private static void Internal_RegisterSampleProviderWithAudioSource(UnityEngine.AudioSource source, uint providerId)
- private static void Internal_UnregisterSampleProviderFromAudioSource(UnityEngine.AudioSource source, uint providerId)
- public static void RegisterSampleProvider(UnityEngine.AudioSource source, UnityEngine.Experimental.Audio.AudioSampleProvider provider)
- public static void UnregisterSampleProvider(UnityEngine.AudioSource source, UnityEngine.Experimental.Audio.AudioSampleProvider provider)

### public delegate UnityEngine.Experimental.Audio.AudioSampleProvider.ConsumeSampleFramesNativeFunction
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public AudioSampleProvider.ConsumeSampleFramesNativeFunction(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(uint providerId, System.IntPtr interleavedSampleFrames, uint sampleFrameCount, System.AsyncCallback callback, object object)
- public virtual uint EndInvoke(System.IAsyncResult result)
- public virtual uint Invoke(uint providerId, System.IntPtr interleavedSampleFrames, uint sampleFrameCount)

### public delegate UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesEventNativeFunction
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public AudioSampleProvider.SampleFramesEventNativeFunction(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr userData, uint providerId, uint sampleFrameCount, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr userData, uint providerId, uint sampleFrameCount)

### public delegate UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public AudioSampleProvider.SampleFramesHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(UnityEngine.Experimental.Audio.AudioSampleProvider provider, uint sampleFrameCount, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(UnityEngine.Experimental.Audio.AudioSampleProvider provider, uint sampleFrameCount)

