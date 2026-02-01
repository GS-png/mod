# Assembly: FMODUnity
- Path: tools/WorldBox.Managed/FMODUnity.dll
- Types: 339

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1948 02B7AD703162CC3192ABA3B53A60AD8681534EEFAB6D34DA9E9E101CF25D2BC4
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4891 6AC701EC86B12AFB97E2AD5B67D79439770C7F00F89E3C478F5A4BAD5C662DAB

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1948

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4891

## Namespace: FMOD

### public struct FMOD.ADVANCEDSETTINGS

#### Fields
- public System.IntPtr ASIOChannelList
- public int ASIONumChannels
- public System.IntPtr ASIOSpeakerList
- public int cbSize
- public uint defaultDecodeBufferSize
- public float distanceFilterCenterFreq
- public int DSPBufferPoolSize
- public uint geometryMaxFadeTime
- public int maxADPCMCodecs
- public int maxAT9Codecs
- public int maxConvolutionThreads
- public int maxFADPCMCodecs
- public int maxMPEGCodecs
- public int maxOpusCodecs
- public int maxPCMCodecs
- public int maxSpatialObjects
- public int maxVorbisCodecs
- public int maxXMACodecs
- public ushort profilePort
- public uint randomSeed
- public FMOD.DSP_RESAMPLER resamplerMethod
- public int reverb3Dinstance
- public float vol0virtualvol

### public struct FMOD.ASYNCREADINFO

#### Fields
- public System.IntPtr buffer
- public uint bytesread
- public FMOD.FILE_ASYNCDONE_FUNC done
- public System.IntPtr handle
- public uint offset
- public int priority
- public uint sizebytes
- public System.IntPtr userdata

### public struct FMOD.ATTRIBUTES_3D

#### Fields
- public FMOD.VECTOR forward
- public FMOD.VECTOR position
- public FMOD.VECTOR up
- public FMOD.VECTOR velocity

### public delegate FMOD.CB_3D_ROLLOFF_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public CB_3D_ROLLOFF_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr channelcontrol, float distance, System.AsyncCallback callback, object object)
- public virtual float EndInvoke(System.IAsyncResult result)
- public virtual float Invoke(System.IntPtr channelcontrol, float distance)

### public struct FMOD.Channel
- Interfaces: FMOD.IChannelControl

#### Fields
- public System.IntPtr handle

#### Constructors
- public Channel(System.IntPtr ptr)

#### Methods
- public FMOD.RESULT addDSP(int index, FMOD.DSP dsp)
- public FMOD.RESULT addFadePoint(ulong dspclock, float volume)
- public void clearHandle()
- private static FMOD.RESULT FMOD5_Channel_AddDSP(System.IntPtr channel, int index, System.IntPtr dsp)
- private static FMOD.RESULT FMOD5_Channel_AddFadePoint(System.IntPtr channel, ulong dspclock, float volume)
- private static FMOD.RESULT FMOD5_Channel_Get3DAttributes(System.IntPtr channel, out FMOD.VECTOR pos, out FMOD.VECTOR vel)
- private static FMOD.RESULT FMOD5_Channel_Get3DConeOrientation(System.IntPtr channel, out FMOD.VECTOR orientation)
- private static FMOD.RESULT FMOD5_Channel_Get3DConeSettings(System.IntPtr channel, out float insideconeangle, out float outsideconeangle, out float outsidevolume)
- private static FMOD.RESULT FMOD5_Channel_Get3DCustomRolloff(System.IntPtr channel, out System.IntPtr points, out int numpoints)
- private static FMOD.RESULT FMOD5_Channel_Get3DDistanceFilter(System.IntPtr channel, out bool custom, out float customLevel, out float centerFreq)
- private static FMOD.RESULT FMOD5_Channel_Get3DDopplerLevel(System.IntPtr channel, out float level)
- private static FMOD.RESULT FMOD5_Channel_Get3DLevel(System.IntPtr channel, out float level)
- private static FMOD.RESULT FMOD5_Channel_Get3DMinMaxDistance(System.IntPtr channel, out float mindistance, out float maxdistance)
- private static FMOD.RESULT FMOD5_Channel_Get3DOcclusion(System.IntPtr channel, out float directocclusion, out float reverbocclusion)
- private static FMOD.RESULT FMOD5_Channel_Get3DSpread(System.IntPtr channel, out float angle)
- private static FMOD.RESULT FMOD5_Channel_GetAudibility(System.IntPtr channel, out float audibility)
- private static FMOD.RESULT FMOD5_Channel_GetChannelGroup(System.IntPtr channel, out System.IntPtr channelgroup)
- private static FMOD.RESULT FMOD5_Channel_GetCurrentSound(System.IntPtr channel, out System.IntPtr sound)
- private static FMOD.RESULT FMOD5_Channel_GetDelay(System.IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, System.IntPtr zero)
- private static FMOD.RESULT FMOD5_Channel_GetDelay(System.IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
- private static FMOD.RESULT FMOD5_Channel_GetDSP(System.IntPtr channel, int index, out System.IntPtr dsp)
- private static FMOD.RESULT FMOD5_Channel_GetDSPClock(System.IntPtr channel, out ulong dspclock, out ulong parentclock)
- private static FMOD.RESULT FMOD5_Channel_GetDSPIndex(System.IntPtr channel, System.IntPtr dsp, out int index)
- private static FMOD.RESULT FMOD5_Channel_GetFadePoints(System.IntPtr channel, ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
- private static FMOD.RESULT FMOD5_Channel_GetFrequency(System.IntPtr channel, out float frequency)
- private static FMOD.RESULT FMOD5_Channel_GetIndex(System.IntPtr channel, out int index)
- private static FMOD.RESULT FMOD5_Channel_GetLoopCount(System.IntPtr channel, out int loopcount)
- private static FMOD.RESULT FMOD5_Channel_GetLoopPoints(System.IntPtr channel, out uint loopstart, FMOD.TIMEUNIT loopstarttype, out uint loopend, FMOD.TIMEUNIT loopendtype)
- private static FMOD.RESULT FMOD5_Channel_GetLowPassGain(System.IntPtr channel, out float gain)
- private static FMOD.RESULT FMOD5_Channel_GetMixMatrix(System.IntPtr channel, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop)
- private static FMOD.RESULT FMOD5_Channel_GetMode(System.IntPtr channel, out FMOD.MODE mode)
- private static FMOD.RESULT FMOD5_Channel_GetMute(System.IntPtr channel, out bool mute)
- private static FMOD.RESULT FMOD5_Channel_GetNumDSPs(System.IntPtr channel, out int numdsps)
- private static FMOD.RESULT FMOD5_Channel_GetPaused(System.IntPtr channel, out bool paused)
- private static FMOD.RESULT FMOD5_Channel_GetPitch(System.IntPtr channel, out float pitch)
- private static FMOD.RESULT FMOD5_Channel_GetPosition(System.IntPtr channel, out uint position, FMOD.TIMEUNIT postype)
- private static FMOD.RESULT FMOD5_Channel_GetPriority(System.IntPtr channel, out int priority)
- private static FMOD.RESULT FMOD5_Channel_GetReverbProperties(System.IntPtr channel, int instance, out float wet)
- private static FMOD.RESULT FMOD5_Channel_GetSystemObject(System.IntPtr channel, out System.IntPtr system)
- private static FMOD.RESULT FMOD5_Channel_GetUserData(System.IntPtr channel, out System.IntPtr userdata)
- private static FMOD.RESULT FMOD5_Channel_GetVolume(System.IntPtr channel, out float volume)
- private static FMOD.RESULT FMOD5_Channel_GetVolumeRamp(System.IntPtr channel, out bool ramp)
- private static FMOD.RESULT FMOD5_Channel_IsPlaying(System.IntPtr channel, out bool isplaying)
- private static FMOD.RESULT FMOD5_Channel_IsVirtual(System.IntPtr channel, out bool isvirtual)
- private static FMOD.RESULT FMOD5_Channel_RemoveDSP(System.IntPtr channel, System.IntPtr dsp)
- private static FMOD.RESULT FMOD5_Channel_RemoveFadePoints(System.IntPtr channel, ulong dspclock_start, ulong dspclock_end)
- private static FMOD.RESULT FMOD5_Channel_Set3DAttributes(System.IntPtr channel, ref FMOD.VECTOR pos, ref FMOD.VECTOR vel)
- private static FMOD.RESULT FMOD5_Channel_Set3DConeOrientation(System.IntPtr channel, ref FMOD.VECTOR orientation)
- private static FMOD.RESULT FMOD5_Channel_Set3DConeSettings(System.IntPtr channel, float insideconeangle, float outsideconeangle, float outsidevolume)
- private static FMOD.RESULT FMOD5_Channel_Set3DCustomRolloff(System.IntPtr channel, ref FMOD.VECTOR points, int numpoints)
- private static FMOD.RESULT FMOD5_Channel_Set3DDistanceFilter(System.IntPtr channel, bool custom, float customLevel, float centerFreq)
- private static FMOD.RESULT FMOD5_Channel_Set3DDopplerLevel(System.IntPtr channel, float level)
- private static FMOD.RESULT FMOD5_Channel_Set3DLevel(System.IntPtr channel, float level)
- private static FMOD.RESULT FMOD5_Channel_Set3DMinMaxDistance(System.IntPtr channel, float mindistance, float maxdistance)
- private static FMOD.RESULT FMOD5_Channel_Set3DOcclusion(System.IntPtr channel, float directocclusion, float reverbocclusion)
- private static FMOD.RESULT FMOD5_Channel_Set3DSpread(System.IntPtr channel, float angle)
- private static FMOD.RESULT FMOD5_Channel_SetCallback(System.IntPtr channel, FMOD.CHANNELCONTROL_CALLBACK callback)
- private static FMOD.RESULT FMOD5_Channel_SetChannelGroup(System.IntPtr channel, System.IntPtr channelgroup)
- private static FMOD.RESULT FMOD5_Channel_SetDelay(System.IntPtr channel, ulong dspclock_start, ulong dspclock_end, bool stopchannels)
- private static FMOD.RESULT FMOD5_Channel_SetDSPIndex(System.IntPtr channel, System.IntPtr dsp, int index)
- private static FMOD.RESULT FMOD5_Channel_SetFadePointRamp(System.IntPtr channel, ulong dspclock, float volume)
- private static FMOD.RESULT FMOD5_Channel_SetFrequency(System.IntPtr channel, float frequency)
- private static FMOD.RESULT FMOD5_Channel_SetLoopCount(System.IntPtr channel, int loopcount)
- private static FMOD.RESULT FMOD5_Channel_SetLoopPoints(System.IntPtr channel, uint loopstart, FMOD.TIMEUNIT loopstarttype, uint loopend, FMOD.TIMEUNIT loopendtype)
- private static FMOD.RESULT FMOD5_Channel_SetLowPassGain(System.IntPtr channel, float gain)
- private static FMOD.RESULT FMOD5_Channel_SetMixLevelsInput(System.IntPtr channel, float[] levels, int numlevels)
- private static FMOD.RESULT FMOD5_Channel_SetMixLevelsOutput(System.IntPtr channel, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
- private static FMOD.RESULT FMOD5_Channel_SetMixMatrix(System.IntPtr channel, float[] matrix, int outchannels, int inchannels, int inchannel_hop)
- private static FMOD.RESULT FMOD5_Channel_SetMode(System.IntPtr channel, FMOD.MODE mode)
- private static FMOD.RESULT FMOD5_Channel_SetMute(System.IntPtr channel, bool mute)
- private static FMOD.RESULT FMOD5_Channel_SetPan(System.IntPtr channel, float pan)
- private static FMOD.RESULT FMOD5_Channel_SetPaused(System.IntPtr channel, bool paused)
- private static FMOD.RESULT FMOD5_Channel_SetPitch(System.IntPtr channel, float pitch)
- private static FMOD.RESULT FMOD5_Channel_SetPosition(System.IntPtr channel, uint position, FMOD.TIMEUNIT postype)
- private static FMOD.RESULT FMOD5_Channel_SetPriority(System.IntPtr channel, int priority)
- private static FMOD.RESULT FMOD5_Channel_SetReverbProperties(System.IntPtr channel, int instance, float wet)
- private static FMOD.RESULT FMOD5_Channel_SetUserData(System.IntPtr channel, System.IntPtr userdata)
- private static FMOD.RESULT FMOD5_Channel_SetVolume(System.IntPtr channel, float volume)
- private static FMOD.RESULT FMOD5_Channel_SetVolumeRamp(System.IntPtr channel, bool ramp)
- private static FMOD.RESULT FMOD5_Channel_Stop(System.IntPtr channel)
- public FMOD.RESULT get3DAttributes(out FMOD.VECTOR pos, out FMOD.VECTOR vel)
- public FMOD.RESULT get3DConeOrientation(out FMOD.VECTOR orientation)
- public FMOD.RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
- public FMOD.RESULT get3DCustomRolloff(out System.IntPtr points, out int numpoints)
- public FMOD.RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
- public FMOD.RESULT get3DDopplerLevel(out float level)
- public FMOD.RESULT get3DLevel(out float level)
- public FMOD.RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
- public FMOD.RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
- public FMOD.RESULT get3DSpread(out float angle)
- public FMOD.RESULT getAudibility(out float audibility)
- public FMOD.RESULT getChannelGroup(out FMOD.ChannelGroup channelgroup)
- public FMOD.RESULT getCurrentSound(out FMOD.Sound sound)
- public FMOD.RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
- public FMOD.RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
- public FMOD.RESULT getDSP(int index, out FMOD.DSP dsp)
- public FMOD.RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
- public FMOD.RESULT getDSPIndex(FMOD.DSP dsp, out int index)
- public FMOD.RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
- public FMOD.RESULT getFrequency(out float frequency)
- public FMOD.RESULT getIndex(out int index)
- public FMOD.RESULT getLoopCount(out int loopcount)
- public FMOD.RESULT getLoopPoints(out uint loopstart, FMOD.TIMEUNIT loopstarttype, out uint loopend, FMOD.TIMEUNIT loopendtype)
- public FMOD.RESULT getLowPassGain(out float gain)
- public FMOD.RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0)
- public FMOD.RESULT getMode(out FMOD.MODE mode)
- public FMOD.RESULT getMute(out bool mute)
- public FMOD.RESULT getNumDSPs(out int numdsps)
- public FMOD.RESULT getPaused(out bool paused)
- public FMOD.RESULT getPitch(out float pitch)
- public FMOD.RESULT getPosition(out uint position, FMOD.TIMEUNIT postype)
- public FMOD.RESULT getPriority(out int priority)
- public FMOD.RESULT getReverbProperties(int instance, out float wet)
- public FMOD.RESULT getSystemObject(out FMOD.System system)
- public FMOD.RESULT getUserData(out System.IntPtr userdata)
- public FMOD.RESULT getVolume(out float volume)
- public FMOD.RESULT getVolumeRamp(out bool ramp)
- public bool hasHandle()
- public FMOD.RESULT isPlaying(out bool isplaying)
- public FMOD.RESULT isVirtual(out bool isvirtual)
- public FMOD.RESULT removeDSP(FMOD.DSP dsp)
- public FMOD.RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
- public FMOD.RESULT set3DAttributes(ref FMOD.VECTOR pos, ref FMOD.VECTOR vel)
- public FMOD.RESULT set3DConeOrientation(ref FMOD.VECTOR orientation)
- public FMOD.RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
- public FMOD.RESULT set3DCustomRolloff(ref FMOD.VECTOR points, int numpoints)
- public FMOD.RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
- public FMOD.RESULT set3DDopplerLevel(float level)
- public FMOD.RESULT set3DLevel(float level)
- public FMOD.RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
- public FMOD.RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
- public FMOD.RESULT set3DSpread(float angle)
- public FMOD.RESULT setCallback(FMOD.CHANNELCONTROL_CALLBACK callback)
- public FMOD.RESULT setChannelGroup(FMOD.ChannelGroup channelgroup)
- public FMOD.RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels = true)
- public FMOD.RESULT setDSPIndex(FMOD.DSP dsp, int index)
- public FMOD.RESULT setFadePointRamp(ulong dspclock, float volume)
- public FMOD.RESULT setFrequency(float frequency)
- public FMOD.RESULT setLoopCount(int loopcount)
- public FMOD.RESULT setLoopPoints(uint loopstart, FMOD.TIMEUNIT loopstarttype, uint loopend, FMOD.TIMEUNIT loopendtype)
- public FMOD.RESULT setLowPassGain(float gain)
- public FMOD.RESULT setMixLevelsInput(float[] levels, int numlevels)
- public FMOD.RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
- public FMOD.RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0)
- public FMOD.RESULT setMode(FMOD.MODE mode)
- public FMOD.RESULT setMute(bool mute)
- public FMOD.RESULT setPan(float pan)
- public FMOD.RESULT setPaused(bool paused)
- public FMOD.RESULT setPitch(float pitch)
- public FMOD.RESULT setPosition(uint position, FMOD.TIMEUNIT postype)
- public FMOD.RESULT setPriority(int priority)
- public FMOD.RESULT setReverbProperties(int instance, float wet)
- public FMOD.RESULT setUserData(System.IntPtr userdata)
- public FMOD.RESULT setVolume(float volume)
- public FMOD.RESULT setVolumeRamp(bool ramp)
- public FMOD.RESULT stop()

### public delegate FMOD.CHANNELCONTROL_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public CHANNELCONTROL_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr channelcontrol, FMOD.CHANNELCONTROL_TYPE controltype, FMOD.CHANNELCONTROL_CALLBACK_TYPE callbacktype, System.IntPtr commanddata1, System.IntPtr commanddata2, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(System.IntPtr channelcontrol, FMOD.CHANNELCONTROL_TYPE controltype, FMOD.CHANNELCONTROL_CALLBACK_TYPE callbacktype, System.IntPtr commanddata1, System.IntPtr commanddata2)

### public enum FMOD.CHANNELCONTROL_CALLBACK_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- END = 0
- MAX = 4
- OCCLUSION = 3
- SYNCPOINT = 2
- VIRTUALVOICE = 1

### public struct FMOD.CHANNELCONTROL_DSP_INDEX

#### Fields
- public static const int FADER
- public static const int HEAD
- public static const int TAIL

### public enum FMOD.CHANNELCONTROL_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CHANNEL = 0
- CHANNELGROUP = 1
- MAX = 2

### public struct FMOD.ChannelGroup
- Interfaces: FMOD.IChannelControl

#### Fields
- public System.IntPtr handle

#### Constructors
- public ChannelGroup(System.IntPtr ptr)

#### Methods
- public FMOD.RESULT addDSP(int index, FMOD.DSP dsp)
- public FMOD.RESULT addFadePoint(ulong dspclock, float volume)
- public FMOD.RESULT addGroup(FMOD.ChannelGroup group, bool propagatedspclock = true)
- public FMOD.RESULT addGroup(FMOD.ChannelGroup group, bool propagatedspclock, out FMOD.DSPConnection connection)
- public void clearHandle()
- private static FMOD.RESULT FMOD5_ChannelGroup_AddDSP(System.IntPtr channelgroup, int index, System.IntPtr dsp)
- private static FMOD.RESULT FMOD5_ChannelGroup_AddFadePoint(System.IntPtr channelgroup, ulong dspclock, float volume)
- private static FMOD.RESULT FMOD5_ChannelGroup_AddGroup(System.IntPtr channelgroup, System.IntPtr group, bool propagatedspclock, System.IntPtr zero)
- private static FMOD.RESULT FMOD5_ChannelGroup_AddGroup(System.IntPtr channelgroup, System.IntPtr group, bool propagatedspclock, out System.IntPtr connection)
- private static FMOD.RESULT FMOD5_ChannelGroup_Get3DAttributes(System.IntPtr channelgroup, out FMOD.VECTOR pos, out FMOD.VECTOR vel)
- private static FMOD.RESULT FMOD5_ChannelGroup_Get3DConeOrientation(System.IntPtr channelgroup, out FMOD.VECTOR orientation)
- private static FMOD.RESULT FMOD5_ChannelGroup_Get3DConeSettings(System.IntPtr channelgroup, out float insideconeangle, out float outsideconeangle, out float outsidevolume)
- private static FMOD.RESULT FMOD5_ChannelGroup_Get3DCustomRolloff(System.IntPtr channelgroup, out System.IntPtr points, out int numpoints)
- private static FMOD.RESULT FMOD5_ChannelGroup_Get3DDistanceFilter(System.IntPtr channelgroup, out bool custom, out float customLevel, out float centerFreq)
- private static FMOD.RESULT FMOD5_ChannelGroup_Get3DDopplerLevel(System.IntPtr channelgroup, out float level)
- private static FMOD.RESULT FMOD5_ChannelGroup_Get3DLevel(System.IntPtr channelgroup, out float level)
- private static FMOD.RESULT FMOD5_ChannelGroup_Get3DMinMaxDistance(System.IntPtr channelgroup, out float mindistance, out float maxdistance)
- private static FMOD.RESULT FMOD5_ChannelGroup_Get3DOcclusion(System.IntPtr channelgroup, out float directocclusion, out float reverbocclusion)
- private static FMOD.RESULT FMOD5_ChannelGroup_Get3DSpread(System.IntPtr channelgroup, out float angle)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetAudibility(System.IntPtr channelgroup, out float audibility)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetChannel(System.IntPtr channelgroup, int index, out System.IntPtr channel)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetDelay(System.IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, System.IntPtr zero)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetDelay(System.IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetDSP(System.IntPtr channelgroup, int index, out System.IntPtr dsp)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetDSPClock(System.IntPtr channelgroup, out ulong dspclock, out ulong parentclock)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetDSPIndex(System.IntPtr channelgroup, System.IntPtr dsp, out int index)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetFadePoints(System.IntPtr channelgroup, ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetGroup(System.IntPtr channelgroup, int index, out System.IntPtr group)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetLowPassGain(System.IntPtr channelgroup, out float gain)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetMixMatrix(System.IntPtr channelgroup, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetMode(System.IntPtr channelgroup, out FMOD.MODE mode)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetMute(System.IntPtr channelgroup, out bool mute)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetName(System.IntPtr channelgroup, System.IntPtr name, int namelen)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetNumChannels(System.IntPtr channelgroup, out int numchannels)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetNumDSPs(System.IntPtr channelgroup, out int numdsps)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetNumGroups(System.IntPtr channelgroup, out int numgroups)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetParentGroup(System.IntPtr channelgroup, out System.IntPtr group)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetPaused(System.IntPtr channelgroup, out bool paused)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetPitch(System.IntPtr channelgroup, out float pitch)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetReverbProperties(System.IntPtr channelgroup, int instance, out float wet)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetSystemObject(System.IntPtr channelgroup, out System.IntPtr system)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetUserData(System.IntPtr channelgroup, out System.IntPtr userdata)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetVolume(System.IntPtr channelgroup, out float volume)
- private static FMOD.RESULT FMOD5_ChannelGroup_GetVolumeRamp(System.IntPtr channelgroup, out bool ramp)
- private static FMOD.RESULT FMOD5_ChannelGroup_IsPlaying(System.IntPtr channelgroup, out bool isplaying)
- private static FMOD.RESULT FMOD5_ChannelGroup_Release(System.IntPtr channelgroup)
- private static FMOD.RESULT FMOD5_ChannelGroup_RemoveDSP(System.IntPtr channelgroup, System.IntPtr dsp)
- private static FMOD.RESULT FMOD5_ChannelGroup_RemoveFadePoints(System.IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end)
- private static FMOD.RESULT FMOD5_ChannelGroup_Set3DAttributes(System.IntPtr channelgroup, ref FMOD.VECTOR pos, ref FMOD.VECTOR vel)
- private static FMOD.RESULT FMOD5_ChannelGroup_Set3DConeOrientation(System.IntPtr channelgroup, ref FMOD.VECTOR orientation)
- private static FMOD.RESULT FMOD5_ChannelGroup_Set3DConeSettings(System.IntPtr channelgroup, float insideconeangle, float outsideconeangle, float outsidevolume)
- private static FMOD.RESULT FMOD5_ChannelGroup_Set3DCustomRolloff(System.IntPtr channelgroup, ref FMOD.VECTOR points, int numpoints)
- private static FMOD.RESULT FMOD5_ChannelGroup_Set3DDistanceFilter(System.IntPtr channelgroup, bool custom, float customLevel, float centerFreq)
- private static FMOD.RESULT FMOD5_ChannelGroup_Set3DDopplerLevel(System.IntPtr channelgroup, float level)
- private static FMOD.RESULT FMOD5_ChannelGroup_Set3DLevel(System.IntPtr channelgroup, float level)
- private static FMOD.RESULT FMOD5_ChannelGroup_Set3DMinMaxDistance(System.IntPtr channelgroup, float mindistance, float maxdistance)
- private static FMOD.RESULT FMOD5_ChannelGroup_Set3DOcclusion(System.IntPtr channelgroup, float directocclusion, float reverbocclusion)
- private static FMOD.RESULT FMOD5_ChannelGroup_Set3DSpread(System.IntPtr channelgroup, float angle)
- private static FMOD.RESULT FMOD5_ChannelGroup_SetCallback(System.IntPtr channelgroup, FMOD.CHANNELCONTROL_CALLBACK callback)
- private static FMOD.RESULT FMOD5_ChannelGroup_SetDelay(System.IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end, bool stopchannels)
- private static FMOD.RESULT FMOD5_ChannelGroup_SetDSPIndex(System.IntPtr channelgroup, System.IntPtr dsp, int index)
- private static FMOD.RESULT FMOD5_ChannelGroup_SetFadePointRamp(System.IntPtr channelgroup, ulong dspclock, float volume)
- private static FMOD.RESULT FMOD5_ChannelGroup_SetLowPassGain(System.IntPtr channelgroup, float gain)
- private static FMOD.RESULT FMOD5_ChannelGroup_SetMixLevelsInput(System.IntPtr channelgroup, float[] levels, int numlevels)
- private static FMOD.RESULT FMOD5_ChannelGroup_SetMixLevelsOutput(System.IntPtr channelgroup, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
- private static FMOD.RESULT FMOD5_ChannelGroup_SetMixMatrix(System.IntPtr channelgroup, float[] matrix, int outchannels, int inchannels, int inchannel_hop)
- private static FMOD.RESULT FMOD5_ChannelGroup_SetMode(System.IntPtr channelgroup, FMOD.MODE mode)
- private static FMOD.RESULT FMOD5_ChannelGroup_SetMute(System.IntPtr channelgroup, bool mute)
- private static FMOD.RESULT FMOD5_ChannelGroup_SetPan(System.IntPtr channelgroup, float pan)
- private static FMOD.RESULT FMOD5_ChannelGroup_SetPaused(System.IntPtr channelgroup, bool paused)
- private static FMOD.RESULT FMOD5_ChannelGroup_SetPitch(System.IntPtr channelgroup, float pitch)
- private static FMOD.RESULT FMOD5_ChannelGroup_SetReverbProperties(System.IntPtr channelgroup, int instance, float wet)
- private static FMOD.RESULT FMOD5_ChannelGroup_SetUserData(System.IntPtr channelgroup, System.IntPtr userdata)
- private static FMOD.RESULT FMOD5_ChannelGroup_SetVolume(System.IntPtr channelgroup, float volume)
- private static FMOD.RESULT FMOD5_ChannelGroup_SetVolumeRamp(System.IntPtr channelgroup, bool ramp)
- private static FMOD.RESULT FMOD5_ChannelGroup_Stop(System.IntPtr channelgroup)
- public FMOD.RESULT get3DAttributes(out FMOD.VECTOR pos, out FMOD.VECTOR vel)
- public FMOD.RESULT get3DConeOrientation(out FMOD.VECTOR orientation)
- public FMOD.RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
- public FMOD.RESULT get3DCustomRolloff(out System.IntPtr points, out int numpoints)
- public FMOD.RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
- public FMOD.RESULT get3DDopplerLevel(out float level)
- public FMOD.RESULT get3DLevel(out float level)
- public FMOD.RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
- public FMOD.RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
- public FMOD.RESULT get3DSpread(out float angle)
- public FMOD.RESULT getAudibility(out float audibility)
- public FMOD.RESULT getChannel(int index, out FMOD.Channel channel)
- public FMOD.RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
- public FMOD.RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
- public FMOD.RESULT getDSP(int index, out FMOD.DSP dsp)
- public FMOD.RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
- public FMOD.RESULT getDSPIndex(FMOD.DSP dsp, out int index)
- public FMOD.RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
- public FMOD.RESULT getGroup(int index, out FMOD.ChannelGroup group)
- public FMOD.RESULT getLowPassGain(out float gain)
- public FMOD.RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop)
- public FMOD.RESULT getMode(out FMOD.MODE mode)
- public FMOD.RESULT getMute(out bool mute)
- public FMOD.RESULT getName(out string name, int namelen)
- public FMOD.RESULT getNumChannels(out int numchannels)
- public FMOD.RESULT getNumDSPs(out int numdsps)
- public FMOD.RESULT getNumGroups(out int numgroups)
- public FMOD.RESULT getParentGroup(out FMOD.ChannelGroup group)
- public FMOD.RESULT getPaused(out bool paused)
- public FMOD.RESULT getPitch(out float pitch)
- public FMOD.RESULT getReverbProperties(int instance, out float wet)
- public FMOD.RESULT getSystemObject(out FMOD.System system)
- public FMOD.RESULT getUserData(out System.IntPtr userdata)
- public FMOD.RESULT getVolume(out float volume)
- public FMOD.RESULT getVolumeRamp(out bool ramp)
- public bool hasHandle()
- public FMOD.RESULT isPlaying(out bool isplaying)
- public FMOD.RESULT release()
- public FMOD.RESULT removeDSP(FMOD.DSP dsp)
- public FMOD.RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
- public FMOD.RESULT set3DAttributes(ref FMOD.VECTOR pos, ref FMOD.VECTOR vel)
- public FMOD.RESULT set3DConeOrientation(ref FMOD.VECTOR orientation)
- public FMOD.RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
- public FMOD.RESULT set3DCustomRolloff(ref FMOD.VECTOR points, int numpoints)
- public FMOD.RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
- public FMOD.RESULT set3DDopplerLevel(float level)
- public FMOD.RESULT set3DLevel(float level)
- public FMOD.RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
- public FMOD.RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
- public FMOD.RESULT set3DSpread(float angle)
- public FMOD.RESULT setCallback(FMOD.CHANNELCONTROL_CALLBACK callback)
- public FMOD.RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels)
- public FMOD.RESULT setDSPIndex(FMOD.DSP dsp, int index)
- public FMOD.RESULT setFadePointRamp(ulong dspclock, float volume)
- public FMOD.RESULT setLowPassGain(float gain)
- public FMOD.RESULT setMixLevelsInput(float[] levels, int numlevels)
- public FMOD.RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
- public FMOD.RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop)
- public FMOD.RESULT setMode(FMOD.MODE mode)
- public FMOD.RESULT setMute(bool mute)
- public FMOD.RESULT setPan(float pan)
- public FMOD.RESULT setPaused(bool paused)
- public FMOD.RESULT setPitch(float pitch)
- public FMOD.RESULT setReverbProperties(int instance, float wet)
- public FMOD.RESULT setUserData(System.IntPtr userdata)
- public FMOD.RESULT setVolume(float volume)
- public FMOD.RESULT setVolumeRamp(bool ramp)
- public FMOD.RESULT stop()

### public enum FMOD.CHANNELMASK
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BACK_CENTER = 256
- BACK_LEFT = 64
- BACK_RIGHT = 128
- FRONT_CENTER = 4
- FRONT_LEFT = 1
- FRONT_RIGHT = 2
- LOW_FREQUENCY = 8
- LRC = 7
- MONO = 1
- QUAD = 51
- STEREO = 3
- SURROUND = 55
- SURROUND_LEFT = 16
- SURROUND_RIGHT = 32
- _5POINT1 = 63
- _5POINT1_REARS = 207
- _7POINT0 = 247
- _7POINT1 = 255

### public enum FMOD.CHANNELORDER
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ALLMONO = 3
- ALLSTEREO = 4
- ALSA = 5
- DEFAULT = 0
- MAX = 6
- PROTOOLS = 2
- WAVEFORMAT = 1

### public struct FMOD.COMPLEX

#### Fields
- public float imag
- public float real

### public class FMOD.CONSTANTS

#### Fields
- public static const int MAX_CHANNEL_WIDTH
- public static const int MAX_LISTENERS
- public static const int MAX_SYSTEMS
- public static const int REVERB_MAXINSTANCES

#### Constructors
- public CONSTANTS()

### public struct FMOD.CPU_USAGE

#### Fields
- public float convolution1
- public float convolution2
- public float dsp
- public float geometry
- public float stream
- public float update

### public struct FMOD.CREATESOUNDEXINFO

#### Fields
- public uint audioqueuepolicy
- public int cbsize
- public FMOD.CHANNELORDER channelorder
- public uint decodebuffersize
- public int defaultfrequency
- public System.IntPtr dlsname
- public System.IntPtr encryptionkey
- public int filebuffersize
- public uint fileoffset
- public System.IntPtr fileuserasynccancel_internal
- public System.IntPtr fileuserasyncread_internal
- public System.IntPtr fileuserclose_internal
- public System.IntPtr fileuserdata
- public System.IntPtr fileuseropen_internal
- public System.IntPtr fileuserread_internal
- public System.IntPtr fileuserseek_internal
- public FMOD.SOUND_FORMAT format
- public System.IntPtr fsbguid
- public int ignoresetfilesystem
- public System.IntPtr inclusionlist
- public int inclusionlistnum
- public uint initialseekposition
- public FMOD.TIMEUNIT initialseekpostype
- public System.IntPtr initialsoundgroup
- public int initialsubsound
- public uint length
- public int maxpolyphony
- public uint minmidigranularity
- public System.IntPtr nonblockcallback_internal
- public int nonblockthreadid
- public int numchannels
- public int numsubsounds
- public System.IntPtr pcmreadcallback_internal
- public System.IntPtr pcmsetposcallback_internal
- public FMOD.SOUND_TYPE suggestedsoundtype
- public System.IntPtr userdata

#### Properties
- public FMOD.FILE_ASYNCCANCEL_CALLBACK fileuserasynccancel { get; set; }
- public FMOD.FILE_ASYNCREAD_CALLBACK fileuserasyncread { get; set; }
- public FMOD.FILE_CLOSE_CALLBACK fileuserclose { get; set; }
- public FMOD.FILE_OPEN_CALLBACK fileuseropen { get; set; }
- public FMOD.FILE_READ_CALLBACK fileuserread { get; set; }
- public FMOD.FILE_SEEK_CALLBACK fileuserseek { get; set; }
- public FMOD.SOUND_NONBLOCK_CALLBACK nonblockcallback { get; set; }
- public FMOD.SOUND_PCMREAD_CALLBACK pcmreadcallback { get; set; }
- public FMOD.SOUND_PCMSETPOS_CALLBACK pcmsetposcallback { get; set; }

### public struct FMOD.Debug

#### Methods
- private static FMOD.RESULT FMOD5_Debug_Initialize(FMOD.DEBUG_FLAGS flags, FMOD.DEBUG_MODE mode, FMOD.DEBUG_CALLBACK callback, byte[] filename)
- public static FMOD.RESULT Initialize(FMOD.DEBUG_FLAGS flags, FMOD.DEBUG_MODE mode = TTY, FMOD.DEBUG_CALLBACK callback = null, string filename = null)

### public delegate FMOD.DEBUG_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DEBUG_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(FMOD.DEBUG_FLAGS flags, System.IntPtr file, int line, System.IntPtr func, System.IntPtr message, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(FMOD.DEBUG_FLAGS flags, System.IntPtr file, int line, System.IntPtr func, System.IntPtr message)

### public enum FMOD.DEBUG_FLAGS
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DISPLAY_LINENUMBERS = 131072
- DISPLAY_THREAD = 262144
- DISPLAY_TIMESTAMPS = 65536
- ERROR = 1
- LOG = 4
- NONE = 0
- TYPE_CODEC = 1024
- TYPE_FILE = 512
- TYPE_MEMORY = 256
- TYPE_TRACE = 2048
- WARNING = 2

### public enum FMOD.DEBUG_MODE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CALLBACK = 2
- FILE = 1
- TTY = 0

### public enum FMOD.DRIVER_STATE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CONNECTED = 1
- DEFAULT = 2

### public struct FMOD.DSP

#### Fields
- public System.IntPtr handle

#### Constructors
- public DSP(System.IntPtr ptr)

#### Methods
- public FMOD.RESULT addInput(FMOD.DSP input)
- public FMOD.RESULT addInput(FMOD.DSP input, out FMOD.DSPConnection connection, FMOD.DSPCONNECTION_TYPE type = STANDARD)
- public void clearHandle()
- public FMOD.RESULT disconnectAll(bool inputs, bool outputs)
- public FMOD.RESULT disconnectFrom(FMOD.DSP target, FMOD.DSPConnection connection)
- private static FMOD.RESULT FMOD5_DSP_AddInput(System.IntPtr dsp, System.IntPtr input, System.IntPtr zero, FMOD.DSPCONNECTION_TYPE type)
- private static FMOD.RESULT FMOD5_DSP_AddInput(System.IntPtr dsp, System.IntPtr input, out System.IntPtr connection, FMOD.DSPCONNECTION_TYPE type)
- private static FMOD.RESULT FMOD5_DSP_DisconnectAll(System.IntPtr dsp, bool inputs, bool outputs)
- private static FMOD.RESULT FMOD5_DSP_DisconnectFrom(System.IntPtr dsp, System.IntPtr target, System.IntPtr connection)
- private static FMOD.RESULT FMOD5_DSP_GetActive(System.IntPtr dsp, out bool active)
- private static FMOD.RESULT FMOD5_DSP_GetBypass(System.IntPtr dsp, out bool bypass)
- private static FMOD.RESULT FMOD5_DSP_GetChannelFormat(System.IntPtr dsp, out FMOD.CHANNELMASK channelmask, out int numchannels, out FMOD.SPEAKERMODE source_speakermode)
- public static FMOD.RESULT FMOD5_DSP_GetCPUUsage(System.IntPtr dsp, out uint exclusive, out uint inclusive)
- private static FMOD.RESULT FMOD5_DSP_GetDataParameterIndex(System.IntPtr dsp, int datatype, out int index)
- private static FMOD.RESULT FMOD5_DSP_GetIdle(System.IntPtr dsp, out bool idle)
- private static FMOD.RESULT FMOD5_DSP_GetInfo(System.IntPtr dsp, System.IntPtr name, out uint version, out int channels, out int configwidth, out int configheight)
- private static FMOD.RESULT FMOD5_DSP_GetInput(System.IntPtr dsp, int index, out System.IntPtr input, out System.IntPtr inputconnection)
- public static FMOD.RESULT FMOD5_DSP_GetMeteringEnabled(System.IntPtr dsp, out bool inputEnabled, out bool outputEnabled)
- public static FMOD.RESULT FMOD5_DSP_GetMeteringInfo(System.IntPtr dsp, System.IntPtr zero, out FMOD.DSP_METERING_INFO outputInfo)
- public static FMOD.RESULT FMOD5_DSP_GetMeteringInfo(System.IntPtr dsp, out FMOD.DSP_METERING_INFO inputInfo, System.IntPtr zero)
- public static FMOD.RESULT FMOD5_DSP_GetMeteringInfo(System.IntPtr dsp, out FMOD.DSP_METERING_INFO inputInfo, out FMOD.DSP_METERING_INFO outputInfo)
- private static FMOD.RESULT FMOD5_DSP_GetNumInputs(System.IntPtr dsp, out int numinputs)
- private static FMOD.RESULT FMOD5_DSP_GetNumOutputs(System.IntPtr dsp, out int numoutputs)
- private static FMOD.RESULT FMOD5_DSP_GetNumParameters(System.IntPtr dsp, out int numparams)
- private static FMOD.RESULT FMOD5_DSP_GetOutput(System.IntPtr dsp, int index, out System.IntPtr output, out System.IntPtr outputconnection)
- private static FMOD.RESULT FMOD5_DSP_GetOutputChannelFormat(System.IntPtr dsp, FMOD.CHANNELMASK inmask, int inchannels, FMOD.SPEAKERMODE inspeakermode, out FMOD.CHANNELMASK outmask, out int outchannels, out FMOD.SPEAKERMODE outspeakermode)
- private static FMOD.RESULT FMOD5_DSP_GetParameterBool(System.IntPtr dsp, int index, out bool value, System.IntPtr valuestr, int valuestrlen)
- private static FMOD.RESULT FMOD5_DSP_GetParameterData(System.IntPtr dsp, int index, out System.IntPtr data, out uint length, System.IntPtr valuestr, int valuestrlen)
- private static FMOD.RESULT FMOD5_DSP_GetParameterFloat(System.IntPtr dsp, int index, out float value, System.IntPtr valuestr, int valuestrlen)
- private static FMOD.RESULT FMOD5_DSP_GetParameterInfo(System.IntPtr dsp, int index, out System.IntPtr desc)
- private static FMOD.RESULT FMOD5_DSP_GetParameterInt(System.IntPtr dsp, int index, out int value, System.IntPtr valuestr, int valuestrlen)
- private static FMOD.RESULT FMOD5_DSP_GetSystemObject(System.IntPtr dsp, out System.IntPtr system)
- private static FMOD.RESULT FMOD5_DSP_GetType(System.IntPtr dsp, out FMOD.DSP_TYPE type)
- private static FMOD.RESULT FMOD5_DSP_GetUserData(System.IntPtr dsp, out System.IntPtr userdata)
- private static FMOD.RESULT FMOD5_DSP_GetWetDryMix(System.IntPtr dsp, out float prewet, out float postwet, out float dry)
- private static FMOD.RESULT FMOD5_DSP_Release(System.IntPtr dsp)
- private static FMOD.RESULT FMOD5_DSP_Reset(System.IntPtr dsp)
- private static FMOD.RESULT FMOD5_DSP_SetActive(System.IntPtr dsp, bool active)
- private static FMOD.RESULT FMOD5_DSP_SetBypass(System.IntPtr dsp, bool bypass)
- private static FMOD.RESULT FMOD5_DSP_SetCallback(System.IntPtr dsp, FMOD.DSP_CALLBACK callback)
- private static FMOD.RESULT FMOD5_DSP_SetChannelFormat(System.IntPtr dsp, FMOD.CHANNELMASK channelmask, int numchannels, FMOD.SPEAKERMODE source_speakermode)
- public static FMOD.RESULT FMOD5_DSP_SetMeteringEnabled(System.IntPtr dsp, bool inputEnabled, bool outputEnabled)
- private static FMOD.RESULT FMOD5_DSP_SetParameterBool(System.IntPtr dsp, int index, bool value)
- private static FMOD.RESULT FMOD5_DSP_SetParameterData(System.IntPtr dsp, int index, byte[] data, uint length)
- private static FMOD.RESULT FMOD5_DSP_SetParameterFloat(System.IntPtr dsp, int index, float value)
- private static FMOD.RESULT FMOD5_DSP_SetParameterInt(System.IntPtr dsp, int index, int value)
- private static FMOD.RESULT FMOD5_DSP_SetUserData(System.IntPtr dsp, System.IntPtr userdata)
- private static FMOD.RESULT FMOD5_DSP_SetWetDryMix(System.IntPtr dsp, float prewet, float postwet, float dry)
- private static FMOD.RESULT FMOD5_DSP_ShowConfigDialog(System.IntPtr dsp, System.IntPtr hwnd, bool show)
- public FMOD.RESULT getActive(out bool active)
- public FMOD.RESULT getBypass(out bool bypass)
- public FMOD.RESULT getChannelFormat(out FMOD.CHANNELMASK channelmask, out int numchannels, out FMOD.SPEAKERMODE source_speakermode)
- public FMOD.RESULT getCPUUsage(out uint exclusive, out uint inclusive)
- public FMOD.RESULT getDataParameterIndex(int datatype, out int index)
- public FMOD.RESULT getIdle(out bool idle)
- public FMOD.RESULT getInfo(out string name, out uint version, out int channels, out int configwidth, out int configheight)
- public FMOD.RESULT getInfo(out uint version, out int channels, out int configwidth, out int configheight)
- public FMOD.RESULT getInput(int index, out FMOD.DSP input, out FMOD.DSPConnection inputconnection)
- public FMOD.RESULT getMeteringEnabled(out bool inputEnabled, out bool outputEnabled)
- public FMOD.RESULT getMeteringInfo(System.IntPtr zero, out FMOD.DSP_METERING_INFO outputInfo)
- public FMOD.RESULT getMeteringInfo(out FMOD.DSP_METERING_INFO inputInfo, System.IntPtr zero)
- public FMOD.RESULT getMeteringInfo(out FMOD.DSP_METERING_INFO inputInfo, out FMOD.DSP_METERING_INFO outputInfo)
- public FMOD.RESULT getNumInputs(out int numinputs)
- public FMOD.RESULT getNumOutputs(out int numoutputs)
- public FMOD.RESULT getNumParameters(out int numparams)
- public FMOD.RESULT getOutput(int index, out FMOD.DSP output, out FMOD.DSPConnection outputconnection)
- public FMOD.RESULT getOutputChannelFormat(FMOD.CHANNELMASK inmask, int inchannels, FMOD.SPEAKERMODE inspeakermode, out FMOD.CHANNELMASK outmask, out int outchannels, out FMOD.SPEAKERMODE outspeakermode)
- public FMOD.RESULT getParameterBool(int index, out bool value)
- public FMOD.RESULT getParameterData(int index, out System.IntPtr data, out uint length)
- public FMOD.RESULT getParameterFloat(int index, out float value)
- public FMOD.RESULT getParameterInfo(int index, out FMOD.DSP_PARAMETER_DESC desc)
- public FMOD.RESULT getParameterInt(int index, out int value)
- public FMOD.RESULT getSystemObject(out FMOD.System system)
- public FMOD.RESULT getType(out FMOD.DSP_TYPE type)
- public FMOD.RESULT getUserData(out System.IntPtr userdata)
- public FMOD.RESULT getWetDryMix(out float prewet, out float postwet, out float dry)
- public bool hasHandle()
- public FMOD.RESULT release()
- public FMOD.RESULT reset()
- public FMOD.RESULT setActive(bool active)
- public FMOD.RESULT setBypass(bool bypass)
- public FMOD.RESULT setCallback(FMOD.DSP_CALLBACK callback)
- public FMOD.RESULT setChannelFormat(FMOD.CHANNELMASK channelmask, int numchannels, FMOD.SPEAKERMODE source_speakermode)
- public FMOD.RESULT setMeteringEnabled(bool inputEnabled, bool outputEnabled)
- public FMOD.RESULT setParameterBool(int index, bool value)
- public FMOD.RESULT setParameterData(int index, byte[] data)
- public FMOD.RESULT setParameterFloat(int index, float value)
- public FMOD.RESULT setParameterInt(int index, int value)
- public FMOD.RESULT setUserData(System.IntPtr userdata)
- public FMOD.RESULT setWetDryMix(float prewet, float postwet, float dry)
- public FMOD.RESULT showConfigDialog(System.IntPtr hwnd, bool show)

### public struct FMOD.DSPConnection

#### Fields
- public System.IntPtr handle

#### Constructors
- public DSPConnection(System.IntPtr ptr)

#### Methods
- public void clearHandle()
- private static FMOD.RESULT FMOD5_DSPConnection_GetInput(System.IntPtr dspconnection, out System.IntPtr input)
- private static FMOD.RESULT FMOD5_DSPConnection_GetMix(System.IntPtr dspconnection, out float volume)
- private static FMOD.RESULT FMOD5_DSPConnection_GetMixMatrix(System.IntPtr dspconnection, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop)
- private static FMOD.RESULT FMOD5_DSPConnection_GetOutput(System.IntPtr dspconnection, out System.IntPtr output)
- private static FMOD.RESULT FMOD5_DSPConnection_GetType(System.IntPtr dspconnection, out FMOD.DSPCONNECTION_TYPE type)
- private static FMOD.RESULT FMOD5_DSPConnection_GetUserData(System.IntPtr dspconnection, out System.IntPtr userdata)
- private static FMOD.RESULT FMOD5_DSPConnection_SetMix(System.IntPtr dspconnection, float volume)
- private static FMOD.RESULT FMOD5_DSPConnection_SetMixMatrix(System.IntPtr dspconnection, float[] matrix, int outchannels, int inchannels, int inchannel_hop)
- private static FMOD.RESULT FMOD5_DSPConnection_SetUserData(System.IntPtr dspconnection, System.IntPtr userdata)
- public FMOD.RESULT getInput(out FMOD.DSP input)
- public FMOD.RESULT getMix(out float volume)
- public FMOD.RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0)
- public FMOD.RESULT getOutput(out FMOD.DSP output)
- public FMOD.RESULT getType(out FMOD.DSPCONNECTION_TYPE type)
- public FMOD.RESULT getUserData(out System.IntPtr userdata)
- public bool hasHandle()
- public FMOD.RESULT setMix(float volume)
- public FMOD.RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0)
- public FMOD.RESULT setUserData(System.IntPtr userdata)

### public enum FMOD.DSPCONNECTION_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- MAX = 4
- SEND = 2
- SEND_SIDECHAIN = 3
- SIDECHAIN = 1
- STANDARD = 0

### public delegate FMOD.DSP_ALLOC_FUNC
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_ALLOC_FUNC(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(uint size, FMOD.MEMORY_TYPE type, System.IntPtr sourcestr, System.AsyncCallback callback, object object)
- public virtual System.IntPtr EndInvoke(System.IAsyncResult result)
- public virtual System.IntPtr Invoke(uint size, FMOD.MEMORY_TYPE type, System.IntPtr sourcestr)

### public struct FMOD.DSP_BUFFER_ARRAY

#### Fields
- public System.IntPtr bufferchannelmask
- public System.IntPtr buffernumchannels
- public System.IntPtr buffers
- public int numbuffers
- public FMOD.SPEAKERMODE speakermode

#### Properties
- public System.IntPtr buffer { get; set; }
- public int numchannels { get; set; }

### public delegate FMOD.DSP_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr dsp, FMOD.DSP_CALLBACK_TYPE type, System.IntPtr data, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(System.IntPtr dsp, FMOD.DSP_CALLBACK_TYPE type, System.IntPtr data)

### public enum FMOD.DSP_CALLBACK_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DATAPARAMETERRELEASE = 0
- MAX = 1

### public enum FMOD.DSP_CHANNELMIX
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- GAIN_CH0 = 1
- GAIN_CH1 = 2
- GAIN_CH10 = 11
- GAIN_CH11 = 12
- GAIN_CH12 = 13
- GAIN_CH13 = 14
- GAIN_CH14 = 15
- GAIN_CH15 = 16
- GAIN_CH16 = 17
- GAIN_CH17 = 18
- GAIN_CH18 = 19
- GAIN_CH19 = 20
- GAIN_CH2 = 3
- GAIN_CH20 = 21
- GAIN_CH21 = 22
- GAIN_CH22 = 23
- GAIN_CH23 = 24
- GAIN_CH24 = 25
- GAIN_CH25 = 26
- GAIN_CH26 = 27
- GAIN_CH27 = 28
- GAIN_CH28 = 29
- GAIN_CH29 = 30
- GAIN_CH3 = 4
- GAIN_CH30 = 31
- GAIN_CH31 = 32
- GAIN_CH4 = 5
- GAIN_CH5 = 6
- GAIN_CH6 = 7
- GAIN_CH7 = 8
- GAIN_CH8 = 9
- GAIN_CH9 = 10
- OUTPUTGROUPING = 0
- OUTPUT_CH0 = 33
- OUTPUT_CH1 = 34
- OUTPUT_CH10 = 43
- OUTPUT_CH11 = 44
- OUTPUT_CH12 = 45
- OUTPUT_CH13 = 46
- OUTPUT_CH14 = 47
- OUTPUT_CH15 = 48
- OUTPUT_CH16 = 49
- OUTPUT_CH17 = 50
- OUTPUT_CH18 = 51
- OUTPUT_CH19 = 52
- OUTPUT_CH2 = 35
- OUTPUT_CH20 = 53
- OUTPUT_CH21 = 54
- OUTPUT_CH22 = 55
- OUTPUT_CH23 = 56
- OUTPUT_CH24 = 57
- OUTPUT_CH25 = 58
- OUTPUT_CH26 = 59
- OUTPUT_CH27 = 60
- OUTPUT_CH28 = 61
- OUTPUT_CH29 = 62
- OUTPUT_CH3 = 36
- OUTPUT_CH30 = 63
- OUTPUT_CH31 = 64
- OUTPUT_CH4 = 37
- OUTPUT_CH5 = 38
- OUTPUT_CH6 = 39
- OUTPUT_CH7 = 40
- OUTPUT_CH8 = 41
- OUTPUT_CH9 = 42

### public enum FMOD.DSP_CHANNELMIX_OUTPUT
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ALL5POINT1 = 4
- ALL7POINT1 = 5
- ALL7POINT1POINT4 = 7
- ALLLFE = 6
- ALLMONO = 1
- ALLQUAD = 3
- ALLSTEREO = 2
- DEFAULT = 0

### public enum FMOD.DSP_CHORUS
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DEPTH = 2
- MIX = 0
- RATE = 1

### public enum FMOD.DSP_COMPRESSOR
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ATTACK = 2
- GAINMAKEUP = 4
- LINKED = 6
- RATIO = 1
- RELEASE = 3
- THRESHOLD = 0
- USESIDECHAIN = 5

### public enum FMOD.DSP_CONVOLUTION_REVERB
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DRY = 2
- IR = 0
- LINKED = 3
- WET = 1

### public delegate FMOD.DSP_CREATE_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_CREATE_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state)

### public struct FMOD.DSP_DATA_PARAMETER_INFO

#### Fields
- public System.IntPtr data
- public int index
- public uint length

### public enum FMOD.DSP_DELAY
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CH0 = 0
- CH1 = 1
- CH10 = 10
- CH11 = 11
- CH12 = 12
- CH13 = 13
- CH14 = 14
- CH15 = 15
- CH2 = 2
- CH3 = 3
- CH4 = 4
- CH5 = 5
- CH6 = 6
- CH7 = 7
- CH8 = 8
- CH9 = 9
- MAXDELAY = 16

### public struct FMOD.DSP_DESCRIPTION

#### Fields
- public FMOD.DSP_CREATE_CALLBACK create
- public FMOD.DSP_GETPARAM_BOOL_CALLBACK getparameterbool
- public FMOD.DSP_GETPARAM_DATA_CALLBACK getparameterdata
- public FMOD.DSP_GETPARAM_FLOAT_CALLBACK getparameterfloat
- public FMOD.DSP_GETPARAM_INT_CALLBACK getparameterint
- public byte[] name
- public int numinputbuffers
- public int numoutputbuffers
- public int numparameters
- public System.IntPtr paramdesc
- public uint pluginsdkversion
- public FMOD.DSP_PROCESS_CALLBACK process
- public FMOD.DSP_READ_CALLBACK read
- public FMOD.DSP_RELEASE_CALLBACK release
- public FMOD.DSP_RESET_CALLBACK reset
- public FMOD.DSP_SETPARAM_BOOL_CALLBACK setparameterbool
- public FMOD.DSP_SETPARAM_DATA_CALLBACK setparameterdata
- public FMOD.DSP_SETPARAM_FLOAT_CALLBACK setparameterfloat
- public FMOD.DSP_SETPARAM_INT_CALLBACK setparameterint
- public FMOD.DSP_SETPOSITION_CALLBACK setposition
- public FMOD.DSP_SHOULDIPROCESS_CALLBACK shouldiprocess
- public FMOD.DSP_SYSTEM_DEREGISTER_CALLBACK sys_deregister
- public FMOD.DSP_SYSTEM_MIX_CALLBACK sys_mix
- public FMOD.DSP_SYSTEM_REGISTER_CALLBACK sys_register
- public System.IntPtr userdata
- public uint version

### public delegate FMOD.DSP_DFT_FFTREAL_FUNC
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_DFT_FFTREAL_FUNC(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, int size, System.IntPtr signal, System.IntPtr dft, System.IntPtr window, int signalhop, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, int size, System.IntPtr signal, System.IntPtr dft, System.IntPtr window, int signalhop)

### public delegate FMOD.DSP_DFT_IFFTREAL_FUNC
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_DFT_IFFTREAL_FUNC(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, int size, System.IntPtr dft, System.IntPtr signal, System.IntPtr window, int signalhop, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, int size, System.IntPtr dft, System.IntPtr signal, System.IntPtr window, int signalhop)

### public enum FMOD.DSP_DISTORTION
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- LEVEL = 0

### public enum FMOD.DSP_ECHO
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DELAY = 0
- DRYLEVEL = 2
- FEEDBACK = 1
- WETLEVEL = 3

### public enum FMOD.DSP_ENVELOPEFOLLOWER
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ATTACK = 0
- ENVELOPE = 2
- RELEASE = 1
- USESIDECHAIN = 3

### public enum FMOD.DSP_FADER
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- GAIN = 0
- OVERALL_GAIN = 1

### public enum FMOD.DSP_FFT
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DOMINANT_FREQ = 3
- SPECTRUMDATA = 2
- WINDOWSIZE = 0
- WINDOWTYPE = 1

### public enum FMOD.DSP_FFT_WINDOW
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BLACKMAN = 4
- BLACKMANHARRIS = 5
- HAMMING = 2
- HANNING = 3
- RECT = 0
- TRIANGLE = 1

### public enum FMOD.DSP_FLANGE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DEPTH = 1
- MIX = 0
- RATE = 2

### public delegate FMOD.DSP_FREE_FUNC
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_FREE_FUNC(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, FMOD.MEMORY_TYPE type, System.IntPtr sourcestr, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, FMOD.MEMORY_TYPE type, System.IntPtr sourcestr)

### public delegate FMOD.DSP_GETBLOCKSIZE_FUNC
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_GETBLOCKSIZE_FUNC(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, ref uint blocksize, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, ref uint blocksize, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, ref uint blocksize)

### public delegate FMOD.DSP_GETCLOCK_FUNC
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_GETCLOCK_FUNC(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, out ulong clock, out uint offset, out uint length, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, out ulong clock, out uint offset, out uint length, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, out ulong clock, out uint offset, out uint length)

### public delegate FMOD.DSP_GETLISTENERATTRIBUTES_FUNC
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_GETLISTENERATTRIBUTES_FUNC(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, ref int numlisteners, System.IntPtr attributes, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, ref int numlisteners, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, ref int numlisteners, System.IntPtr attributes)

### public delegate FMOD.DSP_GETPARAM_BOOL_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_GETPARAM_BOOL_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, int index, ref bool value, System.IntPtr valuestr, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, ref bool value, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, int index, ref bool value, System.IntPtr valuestr)

### public delegate FMOD.DSP_GETPARAM_DATA_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_GETPARAM_DATA_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, int index, ref System.IntPtr data, ref uint length, System.IntPtr valuestr, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, ref System.IntPtr data, ref uint length, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, int index, ref System.IntPtr data, ref uint length, System.IntPtr valuestr)

### public delegate FMOD.DSP_GETPARAM_FLOAT_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_GETPARAM_FLOAT_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, int index, ref float value, System.IntPtr valuestr, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, ref float value, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, int index, ref float value, System.IntPtr valuestr)

### public delegate FMOD.DSP_GETPARAM_INT_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_GETPARAM_INT_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, int index, ref int value, System.IntPtr valuestr, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, ref int value, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, int index, ref int value, System.IntPtr valuestr)

### public delegate FMOD.DSP_GETSAMPLERATE_FUNC
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_GETSAMPLERATE_FUNC(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, ref int rate, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, ref int rate, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, ref int rate)

### public delegate FMOD.DSP_GETSPEAKERMODE_FUNC
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_GETSPEAKERMODE_FUNC(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, ref int speakermode_mixer, ref int speakermode_output, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, ref int speakermode_mixer, ref int speakermode_output, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, ref int speakermode_mixer, ref int speakermode_output)

### public delegate FMOD.DSP_GETUSERDATA_FUNC
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_GETUSERDATA_FUNC(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, out System.IntPtr userdata, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, out System.IntPtr userdata, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, out System.IntPtr userdata)

### public enum FMOD.DSP_HIGHPASS
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CUTOFF = 0
- RESONANCE = 1

### public enum FMOD.DSP_HIGHPASS_SIMPLE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CUTOFF = 0

### public enum FMOD.DSP_ITECHO
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FEEDBACK = 1
- LEFTDELAY = 2
- PANDELAY = 4
- RIGHTDELAY = 3
- WETDRYMIX = 0

### public enum FMOD.DSP_ITLOWPASS
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CUTOFF = 0
- RESONANCE = 1

### public enum FMOD.DSP_LIMITER
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CEILING = 1
- MAXIMIZERGAIN = 2
- MODE = 3
- RELEASETIME = 0

### public delegate FMOD.DSP_LOG_FUNC
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_LOG_FUNC(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(FMOD.DEBUG_FLAGS level, System.IntPtr file, int line, System.IntPtr function, System.IntPtr str, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(FMOD.DEBUG_FLAGS level, System.IntPtr file, int line, System.IntPtr function, System.IntPtr str)

### public enum FMOD.DSP_LOUDNESS_METER
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- INFO = 2
- STATE = 0
- WEIGHTING = 1

### public struct FMOD.DSP_LOUDNESS_METER_INFO_TYPE

#### Fields
- public float integratedloudness
- public float loudness10thpercentile
- public float loudness95thpercentile
- public float[] loudnesshistogram
- public float maxmomentaryloudness
- public float maxtruepeak
- public float momentaryloudness
- public float shorttermloudness

### public enum FMOD.DSP_LOUDNESS_METER_STATE_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ANALYZING = 1
- PAUSED = 0
- RESET_ALL = -1
- RESET_INTEGRATED = -3
- RESET_MAXPEAK = -2

### public struct FMOD.DSP_LOUDNESS_METER_WEIGHTING_TYPE

#### Fields
- public float[] channelweight

### public enum FMOD.DSP_LOWPASS
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CUTOFF = 0
- RESONANCE = 1

### public enum FMOD.DSP_LOWPASS_SIMPLE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CUTOFF = 0

### public struct FMOD.DSP_METERING_INFO

#### Fields
- public short numchannels
- public int numsamples
- public float[] peaklevel
- public float[] rmslevel

### public enum FMOD.DSP_MULTIBAND_EQ
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- A_FILTER = 0
- A_FREQUENCY = 1
- A_GAIN = 3
- A_Q = 2
- B_FILTER = 4
- B_FREQUENCY = 5
- B_GAIN = 7
- B_Q = 6
- C_FILTER = 8
- C_FREQUENCY = 9
- C_GAIN = 11
- C_Q = 10
- D_FILTER = 12
- D_FREQUENCY = 13
- D_GAIN = 15
- D_Q = 14
- E_FILTER = 16
- E_FREQUENCY = 17
- E_GAIN = 19
- E_Q = 18

### public enum FMOD.DSP_MULTIBAND_EQ_FILTER_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ALLPASS = 12
- BANDPASS = 10
- DISABLED = 0
- HIGHPASS_12DB = 4
- HIGHPASS_24DB = 5
- HIGHPASS_48DB = 6
- HIGHSHELF = 8
- LOWPASS_12DB = 1
- LOWPASS_24DB = 2
- LOWPASS_48DB = 3
- LOWSHELF = 7
- NOTCH = 11
- PEAKING = 9

### public enum FMOD.DSP_NORMALIZE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FADETIME = 0
- MAXAMP = 2
- THRESHOLD = 1

### public enum FMOD.DSP_OBJECTPAN
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ATTENUATION_RANGE = 9
- OUTPUTGAIN = 8
- OVERALL_GAIN = 7
- OVERRIDE_RANGE = 10
- _3D_EXTENT_MODE = 4
- _3D_MAX_DISTANCE = 3
- _3D_MIN_DISTANCE = 2
- _3D_MIN_EXTENT = 6
- _3D_POSITION = 0
- _3D_ROLLOFF = 1
- _3D_SOUND_SIZE = 5

### public enum FMOD.DSP_OSCILLATOR
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- RATE = 1
- TYPE = 0

### public enum FMOD.DSP_PAN
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ATTENUATION_RANGE = 22
- ENABLED_SPEAKERS = 9
- LFE_UPMIX_ENABLED = 18
- MODE = 0
- OVERALL_GAIN = 19
- OVERRIDE_RANGE = 23
- SURROUND_SPEAKER_MODE = 20
- _2D_DIRECTION = 2
- _2D_EXTENT = 3
- _2D_HEIGHT_BLEND = 21
- _2D_LFE_LEVEL = 5
- _2D_ROTATION = 4
- _2D_STEREO_AXIS = 8
- _2D_STEREO_MODE = 6
- _2D_STEREO_POSITION = 1
- _2D_STEREO_SEPARATION = 7
- _3D_EXTENT_MODE = 14
- _3D_MAX_DISTANCE = 13
- _3D_MIN_DISTANCE = 12
- _3D_MIN_EXTENT = 16
- _3D_PAN_BLEND = 17
- _3D_POSITION = 10
- _3D_ROLLOFF = 11
- _3D_SOUND_SIZE = 15

### public enum FMOD.DSP_PAN_2D_STEREO_MODE_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DISCRETE = 1
- DISTRIBUTED = 0

### public enum FMOD.DSP_PAN_3D_EXTENT_MODE_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AUTO = 0
- OFF = 2
- USER = 1

### public enum FMOD.DSP_PAN_3D_ROLLOFF_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CUSTOM = 4
- INVERSE = 2
- INVERSETAPERED = 3
- LINEAR = 1
- LINEARSQUARED = 0

### public delegate FMOD.DSP_PAN_GETROLLOFFGAIN_FUNC
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_PAN_GETROLLOFFGAIN_FUNC(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, FMOD.DSP_PAN_3D_ROLLOFF_TYPE rolloff, float distance, float mindistance, float maxdistance, out float gain, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, out float gain, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, FMOD.DSP_PAN_3D_ROLLOFF_TYPE rolloff, float distance, float mindistance, float maxdistance, out float gain)

### public enum FMOD.DSP_PAN_MODE_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- MONO = 0
- STEREO = 1
- SURROUND = 2

### public delegate FMOD.DSP_PAN_SUMMONOMATRIX_FUNC
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_PAN_SUMMONOMATRIX_FUNC(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, int sourceSpeakerMode, float lowFrequencyGain, float overallGain, System.IntPtr matrix, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, int sourceSpeakerMode, float lowFrequencyGain, float overallGain, System.IntPtr matrix)

### public delegate FMOD.DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float lowFrequencyGain, float overallGain, int matrixHop, System.IntPtr matrix, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float lowFrequencyGain, float overallGain, int matrixHop, System.IntPtr matrix)

### public delegate FMOD.DSP_PAN_SUMSTEREOMATRIX_FUNC
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_PAN_SUMSTEREOMATRIX_FUNC(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, int sourceSpeakerMode, float pan, float lowFrequencyGain, float overallGain, int matrixHop, System.IntPtr matrix, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, int sourceSpeakerMode, float pan, float lowFrequencyGain, float overallGain, int matrixHop, System.IntPtr matrix)

### public delegate FMOD.DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, System.IntPtr matrix, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, System.IntPtr matrix)

### public delegate FMOD.DSP_PAN_SUMSURROUNDMATRIX_FUNC
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_PAN_SUMSURROUNDMATRIX_FUNC(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, int sourceSpeakerMode, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, System.IntPtr matrix, FMOD.DSP_PAN_SURROUND_FLAGS flags, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, int sourceSpeakerMode, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, System.IntPtr matrix, FMOD.DSP_PAN_SURROUND_FLAGS flags)

### public enum FMOD.DSP_PAN_SURROUND_FLAGS
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DEFAULT = 0
- ROTATION_NOT_BIASED = 1

### public enum FMOD.DSP_PARAMEQ
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BANDWIDTH = 1
- CENTER = 0
- GAIN = 2

### public struct FMOD.DSP_PARAMETER_3DATTRIBUTES

#### Fields
- public FMOD.ATTRIBUTES_3D absolute
- public FMOD.ATTRIBUTES_3D relative

### public struct FMOD.DSP_PARAMETER_3DATTRIBUTES_MULTI

#### Fields
- public FMOD.ATTRIBUTES_3D absolute
- public int numlisteners
- public FMOD.ATTRIBUTES_3D[] relative
- public float[] weight

### public struct FMOD.DSP_PARAMETER_ATTENUATION_RANGE

#### Fields
- public float max
- public float min

### public enum FMOD.DSP_PARAMETER_DATA_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DSP_PARAMETER_DATA_TYPE_3DATTRIBUTES = -2
- DSP_PARAMETER_DATA_TYPE_3DATTRIBUTES_MULTI = -5
- DSP_PARAMETER_DATA_TYPE_ATTENUATION_RANGE = -6
- DSP_PARAMETER_DATA_TYPE_FFT = -4
- DSP_PARAMETER_DATA_TYPE_OVERALLGAIN = -1
- DSP_PARAMETER_DATA_TYPE_SIDECHAIN = -3
- DSP_PARAMETER_DATA_TYPE_USER = 0

### public struct FMOD.DSP_PARAMETER_DESC

#### Fields
- public FMOD.DSP_PARAMETER_DESC_UNION desc
- public string description
- public byte[] label
- public byte[] name
- public FMOD.DSP_PARAMETER_TYPE type

### public struct FMOD.DSP_PARAMETER_DESC_BOOL

#### Fields
- public bool defaultval
- public System.IntPtr valuenames

### public struct FMOD.DSP_PARAMETER_DESC_DATA

#### Fields
- public int datatype

### public struct FMOD.DSP_PARAMETER_DESC_FLOAT

#### Fields
- public float defaultval
- public FMOD.DSP_PARAMETER_FLOAT_MAPPING mapping
- public float max
- public float min

### public struct FMOD.DSP_PARAMETER_DESC_INT

#### Fields
- public int defaultval
- public bool goestoinf
- public int max
- public int min
- public System.IntPtr valuenames

### public struct FMOD.DSP_PARAMETER_DESC_UNION

#### Fields
- public FMOD.DSP_PARAMETER_DESC_BOOL booldesc
- public FMOD.DSP_PARAMETER_DESC_DATA datadesc
- public FMOD.DSP_PARAMETER_DESC_FLOAT floatdesc
- public FMOD.DSP_PARAMETER_DESC_INT intdesc

### public struct FMOD.DSP_PARAMETER_FFT

#### Fields
- public int length
- public int numchannels
- private System.IntPtr[] spectrum_internal

#### Properties
- public float[][] spectrum { get; }

#### Methods
- public void getSpectrum(ref float[][] buffer)
- public void getSpectrum(int channel, ref float[] buffer)

### public struct FMOD.DSP_PARAMETER_FLOAT_MAPPING

#### Fields
- public FMOD.DSP_PARAMETER_FLOAT_MAPPING_PIECEWISE_LINEAR piecewiselinearmapping
- public FMOD.DSP_PARAMETER_FLOAT_MAPPING_TYPE type

### public struct FMOD.DSP_PARAMETER_FLOAT_MAPPING_PIECEWISE_LINEAR

#### Fields
- public int numpoints
- public System.IntPtr pointparamvalues
- public System.IntPtr pointpositions

### public enum FMOD.DSP_PARAMETER_FLOAT_MAPPING_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DSP_PARAMETER_FLOAT_MAPPING_TYPE_AUTO = 1
- DSP_PARAMETER_FLOAT_MAPPING_TYPE_LINEAR = 0
- DSP_PARAMETER_FLOAT_MAPPING_TYPE_PIECEWISE_LINEAR = 2

### public struct FMOD.DSP_PARAMETER_OVERALLGAIN

#### Fields
- public float linear_gain
- public float linear_gain_additive

### public struct FMOD.DSP_PARAMETER_SIDECHAIN

#### Fields
- public int sidechainenable

### public enum FMOD.DSP_PARAMETER_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BOOL = 2
- DATA = 3
- FLOAT = 0
- INT = 1
- MAX = 4

### public enum FMOD.DSP_PITCHSHIFT
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FFTSIZE = 1
- MAXCHANNELS = 3
- OVERLAP = 2
- PITCH = 0

### public delegate FMOD.DSP_PROCESS_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_PROCESS_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, uint length, ref FMOD.DSP_BUFFER_ARRAY inbufferarray, ref FMOD.DSP_BUFFER_ARRAY outbufferarray, bool inputsidle, FMOD.DSP_PROCESS_OPERATION op, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, ref FMOD.DSP_BUFFER_ARRAY inbufferarray, ref FMOD.DSP_BUFFER_ARRAY outbufferarray, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, uint length, ref FMOD.DSP_BUFFER_ARRAY inbufferarray, ref FMOD.DSP_BUFFER_ARRAY outbufferarray, bool inputsidle, FMOD.DSP_PROCESS_OPERATION op)

### public enum FMOD.DSP_PROCESS_OPERATION
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- PROCESS_PERFORM = 0
- PROCESS_QUERY = 1

### public delegate FMOD.DSP_READ_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_READ_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, System.IntPtr inbuffer, System.IntPtr outbuffer, uint length, int inchannels, ref int outchannels, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, ref int outchannels, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, System.IntPtr inbuffer, System.IntPtr outbuffer, uint length, int inchannels, ref int outchannels)

### public delegate FMOD.DSP_REALLOC_FUNC
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_REALLOC_FUNC(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, uint size, FMOD.MEMORY_TYPE type, System.IntPtr sourcestr, System.AsyncCallback callback, object object)
- public virtual System.IntPtr EndInvoke(System.IAsyncResult result)
- public virtual System.IntPtr Invoke(System.IntPtr ptr, uint size, FMOD.MEMORY_TYPE type, System.IntPtr sourcestr)

### public delegate FMOD.DSP_RELEASE_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_RELEASE_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state)

### public enum FMOD.DSP_RESAMPLER
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CUBIC = 3
- DEFAULT = 0
- LINEAR = 2
- MAX = 5
- NOINTERP = 1
- SPLINE = 4

### public delegate FMOD.DSP_RESET_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_RESET_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state)

### public enum FMOD.DSP_RETURN
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ID = 0
- INPUT_SPEAKER_MODE = 1

### public enum FMOD.DSP_SEND
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- LEVEL = 1
- RETURNID = 0

### public delegate FMOD.DSP_SETPARAM_BOOL_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_SETPARAM_BOOL_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, int index, bool value, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, int index, bool value)

### public delegate FMOD.DSP_SETPARAM_DATA_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_SETPARAM_DATA_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, int index, System.IntPtr data, uint length, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, int index, System.IntPtr data, uint length)

### public delegate FMOD.DSP_SETPARAM_FLOAT_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_SETPARAM_FLOAT_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, int index, float value, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, int index, float value)

### public delegate FMOD.DSP_SETPARAM_INT_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_SETPARAM_INT_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, int index, int value, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, int index, int value)

### public delegate FMOD.DSP_SETPOSITION_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_SETPOSITION_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, uint pos, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, uint pos)

### public enum FMOD.DSP_SFXREVERB
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DECAYTIME = 0
- DENSITY = 6
- DIFFUSION = 5
- DRYLEVEL = 12
- EARLYDELAY = 1
- EARLYLATEMIX = 10
- HFDECAYRATIO = 4
- HFREFERENCE = 3
- HIGHCUT = 9
- LATEDELAY = 2
- LOWSHELFFREQUENCY = 7
- LOWSHELFGAIN = 8
- WETLEVEL = 11

### public delegate FMOD.DSP_SHOULDIPROCESS_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_SHOULDIPROCESS_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, bool inputsidle, uint length, FMOD.CHANNELMASK inmask, int inchannels, FMOD.SPEAKERMODE speakermode, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, bool inputsidle, uint length, FMOD.CHANNELMASK inmask, int inchannels, FMOD.SPEAKERMODE speakermode)

### public struct FMOD.DSP_STATE

#### Fields
- public uint channelmask
- public System.IntPtr functions
- public System.IntPtr instance
- public System.IntPtr plugindata
- public int sidechainchannels
- public System.IntPtr sidechaindata
- public int source_speakermode
- public int systemobject

### public struct FMOD.DSP_STATE_DFT_FUNCTIONS

#### Fields
- public FMOD.DSP_DFT_FFTREAL_FUNC fftreal
- public FMOD.DSP_DFT_IFFTREAL_FUNC inversefftreal

### public struct FMOD.DSP_STATE_FUNCTIONS

#### Fields
- public FMOD.DSP_ALLOC_FUNC alloc
- public System.IntPtr dft
- public FMOD.DSP_FREE_FUNC free
- public FMOD.DSP_GETBLOCKSIZE_FUNC getblocksize
- public FMOD.DSP_GETCLOCK_FUNC getclock
- public FMOD.DSP_GETLISTENERATTRIBUTES_FUNC getlistenerattributes
- public FMOD.DSP_GETSAMPLERATE_FUNC getsamplerate
- public FMOD.DSP_GETSPEAKERMODE_FUNC getspeakermode
- public FMOD.DSP_GETUSERDATA_FUNC getuserdata
- public FMOD.DSP_LOG_FUNC log
- public System.IntPtr pan
- public FMOD.DSP_REALLOC_FUNC realloc

### public struct FMOD.DSP_STATE_PAN_FUNCTIONS

#### Fields
- public FMOD.DSP_PAN_GETROLLOFFGAIN_FUNC getrolloffgain
- public FMOD.DSP_PAN_SUMMONOMATRIX_FUNC summonomatrix
- public FMOD.DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC summonotosurroundmatrix
- public FMOD.DSP_PAN_SUMSTEREOMATRIX_FUNC sumstereomatrix
- public FMOD.DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC sumstereotosurroundmatrix
- public FMOD.DSP_PAN_SUMSURROUNDMATRIX_FUNC sumsurroundmatrix

### public delegate FMOD.DSP_SYSTEM_DEREGISTER_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_SYSTEM_DEREGISTER_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state)

### public delegate FMOD.DSP_SYSTEM_MIX_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_SYSTEM_MIX_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, int stage, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state, int stage)

### public delegate FMOD.DSP_SYSTEM_REGISTER_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DSP_SYSTEM_REGISTER_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref FMOD.DSP_STATE dsp_state, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref FMOD.DSP_STATE dsp_state, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(ref FMOD.DSP_STATE dsp_state)

### public enum FMOD.DSP_THREE_EQ
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CROSSOVERSLOPE = 5
- HIGHCROSSOVER = 4
- HIGHGAIN = 2
- LOWCROSSOVER = 3
- LOWGAIN = 0
- MIDGAIN = 1

### public enum FMOD.DSP_THREE_EQ_CROSSOVERSLOPE_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- _12DB = 0
- _24DB = 1
- _48DB = 2

### public enum FMOD.DSP_TRANSCEIVER
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CHANNEL = 2
- GAIN = 1
- TRANSMIT = 0
- TRANSMITSPEAKERMODE = 3

### public enum FMOD.DSP_TRANSCEIVER_SPEAKERMODE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AUTO = -1
- MONO = 0
- STEREO = 1
- SURROUND = 2

### public enum FMOD.DSP_TREMOLO
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DEPTH = 1
- DUTY = 4
- FREQUENCY = 0
- PHASE = 6
- SHAPE = 2
- SKEW = 3
- SPREAD = 7
- SQUARE = 5

### public enum FMOD.DSP_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CHANNELMIX = 33
- CHORUS = 14
- COMPRESSOR = 18
- CONVOLUTIONREVERB = 32
- DELAY = 21
- DISTORTION = 9
- ECHO = 6
- ENVELOPEFOLLOWER = 31
- FADER = 7
- FFT = 29
- FLANGE = 8
- HIGHPASS = 5
- HIGHPASS_SIMPLE = 26
- ITECHO = 17
- ITLOWPASS = 4
- LADSPAPLUGIN = 23
- LIMITER = 11
- LOUDNESS_METER = 30
- LOWPASS = 3
- LOWPASS_SIMPLE = 20
- MAX = 37
- MIXER = 1
- MULTIBAND_EQ = 36
- NORMALIZE = 10
- OBJECTPAN = 35
- OSCILLATOR = 2
- PAN = 27
- PARAMEQ = 12
- PITCHSHIFT = 13
- RETURN = 25
- SEND = 24
- SFXREVERB = 19
- THREE_EQ = 28
- TRANSCEIVER = 34
- TREMOLO = 22
- UNKNOWN = 0
- VSTPLUGIN = 15
- WINAMPPLUGIN = 16

### public class FMOD.Error

#### Constructors
- public Error()

#### Methods
- public static string String(FMOD.RESULT errcode)

### public struct FMOD.ERRORCALLBACK_INFO

#### Fields
- public FMOD.StringWrapper functionname
- public FMOD.StringWrapper functionparams
- public System.IntPtr instance
- public FMOD.ERRORCALLBACK_INSTANCETYPE instancetype
- public FMOD.RESULT result

### public enum FMOD.ERRORCALLBACK_INSTANCETYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CHANNEL = 2
- CHANNELCONTROL = 4
- CHANNELGROUP = 3
- DSP = 7
- DSPCONNECTION = 8
- GEOMETRY = 9
- NONE = 0
- REVERB3D = 10
- SOUND = 5
- SOUNDGROUP = 6
- STUDIO_BANK = 17
- STUDIO_BUS = 15
- STUDIO_COMMANDREPLAY = 18
- STUDIO_EVENTDESCRIPTION = 12
- STUDIO_EVENTINSTANCE = 13
- STUDIO_PARAMETERINSTANCE = 14
- STUDIO_SYSTEM = 11
- STUDIO_VCA = 16
- SYSTEM = 1

### public struct FMOD.Factory

#### Methods
- private static FMOD.RESULT FMOD5_System_Create(out System.IntPtr system, uint headerversion)
- public static FMOD.RESULT System_Create(out FMOD.System system)

### public delegate FMOD.FILE_ASYNCCANCEL_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public FILE_ASYNCCANCEL_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr info, System.IntPtr userdata, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(System.IntPtr info, System.IntPtr userdata)

### public delegate FMOD.FILE_ASYNCDONE_FUNC
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public FILE_ASYNCDONE_FUNC(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr info, FMOD.RESULT result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr info, FMOD.RESULT result)

### public delegate FMOD.FILE_ASYNCREAD_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public FILE_ASYNCREAD_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr info, System.IntPtr userdata, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(System.IntPtr info, System.IntPtr userdata)

### public delegate FMOD.FILE_CLOSE_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public FILE_CLOSE_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr handle, System.IntPtr userdata, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(System.IntPtr handle, System.IntPtr userdata)

### public delegate FMOD.FILE_OPEN_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public FILE_OPEN_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr name, ref uint filesize, ref System.IntPtr handle, System.IntPtr userdata, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref uint filesize, ref System.IntPtr handle, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(System.IntPtr name, ref uint filesize, ref System.IntPtr handle, System.IntPtr userdata)

### public delegate FMOD.FILE_READ_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public FILE_READ_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr handle, System.IntPtr buffer, uint sizebytes, ref uint bytesread, System.IntPtr userdata, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(ref uint bytesread, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(System.IntPtr handle, System.IntPtr buffer, uint sizebytes, ref uint bytesread, System.IntPtr userdata)

### public delegate FMOD.FILE_SEEK_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public FILE_SEEK_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr handle, uint pos, System.IntPtr userdata, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(System.IntPtr handle, uint pos, System.IntPtr userdata)

### public struct FMOD.Geometry

#### Fields
- public System.IntPtr handle

#### Constructors
- public Geometry(System.IntPtr ptr)

#### Methods
- public FMOD.RESULT addPolygon(float directocclusion, float reverbocclusion, bool doublesided, int numvertices, FMOD.VECTOR[] vertices, out int polygonindex)
- public void clearHandle()
- private static FMOD.RESULT FMOD5_Geometry_AddPolygon(System.IntPtr geometry, float directocclusion, float reverbocclusion, bool doublesided, int numvertices, FMOD.VECTOR[] vertices, out int polygonindex)
- private static FMOD.RESULT FMOD5_Geometry_GetActive(System.IntPtr geometry, out bool active)
- private static FMOD.RESULT FMOD5_Geometry_GetMaxPolygons(System.IntPtr geometry, out int maxpolygons, out int maxvertices)
- private static FMOD.RESULT FMOD5_Geometry_GetNumPolygons(System.IntPtr geometry, out int numpolygons)
- private static FMOD.RESULT FMOD5_Geometry_GetPolygonAttributes(System.IntPtr geometry, int index, out float directocclusion, out float reverbocclusion, out bool doublesided)
- private static FMOD.RESULT FMOD5_Geometry_GetPolygonNumVertices(System.IntPtr geometry, int index, out int numvertices)
- private static FMOD.RESULT FMOD5_Geometry_GetPolygonVertex(System.IntPtr geometry, int index, int vertexindex, out FMOD.VECTOR vertex)
- private static FMOD.RESULT FMOD5_Geometry_GetPosition(System.IntPtr geometry, out FMOD.VECTOR position)
- private static FMOD.RESULT FMOD5_Geometry_GetRotation(System.IntPtr geometry, out FMOD.VECTOR forward, out FMOD.VECTOR up)
- private static FMOD.RESULT FMOD5_Geometry_GetScale(System.IntPtr geometry, out FMOD.VECTOR scale)
- private static FMOD.RESULT FMOD5_Geometry_GetUserData(System.IntPtr geometry, out System.IntPtr userdata)
- private static FMOD.RESULT FMOD5_Geometry_Release(System.IntPtr geometry)
- private static FMOD.RESULT FMOD5_Geometry_Save(System.IntPtr geometry, System.IntPtr data, out int datasize)
- private static FMOD.RESULT FMOD5_Geometry_SetActive(System.IntPtr geometry, bool active)
- private static FMOD.RESULT FMOD5_Geometry_SetPolygonAttributes(System.IntPtr geometry, int index, float directocclusion, float reverbocclusion, bool doublesided)
- private static FMOD.RESULT FMOD5_Geometry_SetPolygonVertex(System.IntPtr geometry, int index, int vertexindex, ref FMOD.VECTOR vertex)
- private static FMOD.RESULT FMOD5_Geometry_SetPosition(System.IntPtr geometry, ref FMOD.VECTOR position)
- private static FMOD.RESULT FMOD5_Geometry_SetRotation(System.IntPtr geometry, ref FMOD.VECTOR forward, ref FMOD.VECTOR up)
- private static FMOD.RESULT FMOD5_Geometry_SetScale(System.IntPtr geometry, ref FMOD.VECTOR scale)
- private static FMOD.RESULT FMOD5_Geometry_SetUserData(System.IntPtr geometry, System.IntPtr userdata)
- public FMOD.RESULT getActive(out bool active)
- public FMOD.RESULT getMaxPolygons(out int maxpolygons, out int maxvertices)
- public FMOD.RESULT getNumPolygons(out int numpolygons)
- public FMOD.RESULT getPolygonAttributes(int index, out float directocclusion, out float reverbocclusion, out bool doublesided)
- public FMOD.RESULT getPolygonNumVertices(int index, out int numvertices)
- public FMOD.RESULT getPolygonVertex(int index, int vertexindex, out FMOD.VECTOR vertex)
- public FMOD.RESULT getPosition(out FMOD.VECTOR position)
- public FMOD.RESULT getRotation(out FMOD.VECTOR forward, out FMOD.VECTOR up)
- public FMOD.RESULT getScale(out FMOD.VECTOR scale)
- public FMOD.RESULT getUserData(out System.IntPtr userdata)
- public bool hasHandle()
- public FMOD.RESULT release()
- public FMOD.RESULT save(System.IntPtr data, out int datasize)
- public FMOD.RESULT setActive(bool active)
- public FMOD.RESULT setPolygonAttributes(int index, float directocclusion, float reverbocclusion, bool doublesided)
- public FMOD.RESULT setPolygonVertex(int index, int vertexindex, ref FMOD.VECTOR vertex)
- public FMOD.RESULT setPosition(ref FMOD.VECTOR position)
- public FMOD.RESULT setRotation(ref FMOD.VECTOR forward, ref FMOD.VECTOR up)
- public FMOD.RESULT setScale(ref FMOD.VECTOR scale)
- public FMOD.RESULT setUserData(System.IntPtr userdata)

### public struct FMOD.GUID
- Interfaces: System.IEquatable<FMOD.GUID>

#### Fields
- public int Data1
- public int Data2
- public int Data3
- public int Data4

#### Properties
- public bool IsNull { get; }

#### Constructors
- public GUID(System.Guid guid)

#### Methods
- public override bool Equals(object other)
- public bool Equals(FMOD.GUID other)
- public override int GetHashCode()
- public static bool op_Equality(FMOD.GUID a, FMOD.GUID b)
- public static System.Guid op_Implicit(FMOD.GUID guid)
- public static bool op_Inequality(FMOD.GUID a, FMOD.GUID b)
- public static FMOD.GUID Parse(string s)
- public override string ToString()

### internal interface FMOD.IChannelControl

#### Methods
- public FMOD.RESULT addDSP(int index, FMOD.DSP dsp)
- public FMOD.RESULT addFadePoint(ulong dspclock, float volume)
- public FMOD.RESULT get3DAttributes(out FMOD.VECTOR pos, out FMOD.VECTOR vel)
- public FMOD.RESULT get3DConeOrientation(out FMOD.VECTOR orientation)
- public FMOD.RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
- public FMOD.RESULT get3DCustomRolloff(out System.IntPtr points, out int numpoints)
- public FMOD.RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
- public FMOD.RESULT get3DDopplerLevel(out float level)
- public FMOD.RESULT get3DLevel(out float level)
- public FMOD.RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
- public FMOD.RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
- public FMOD.RESULT get3DSpread(out float angle)
- public FMOD.RESULT getAudibility(out float audibility)
- public FMOD.RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
- public FMOD.RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
- public FMOD.RESULT getDSP(int index, out FMOD.DSP dsp)
- public FMOD.RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
- public FMOD.RESULT getDSPIndex(FMOD.DSP dsp, out int index)
- public FMOD.RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
- public FMOD.RESULT getLowPassGain(out float gain)
- public FMOD.RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop)
- public FMOD.RESULT getMode(out FMOD.MODE mode)
- public FMOD.RESULT getMute(out bool mute)
- public FMOD.RESULT getNumDSPs(out int numdsps)
- public FMOD.RESULT getPaused(out bool paused)
- public FMOD.RESULT getPitch(out float pitch)
- public FMOD.RESULT getReverbProperties(int instance, out float wet)
- public FMOD.RESULT getSystemObject(out FMOD.System system)
- public FMOD.RESULT getUserData(out System.IntPtr userdata)
- public FMOD.RESULT getVolume(out float volume)
- public FMOD.RESULT getVolumeRamp(out bool ramp)
- public FMOD.RESULT isPlaying(out bool isplaying)
- public FMOD.RESULT removeDSP(FMOD.DSP dsp)
- public FMOD.RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
- public FMOD.RESULT set3DAttributes(ref FMOD.VECTOR pos, ref FMOD.VECTOR vel)
- public FMOD.RESULT set3DConeOrientation(ref FMOD.VECTOR orientation)
- public FMOD.RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
- public FMOD.RESULT set3DCustomRolloff(ref FMOD.VECTOR points, int numpoints)
- public FMOD.RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
- public FMOD.RESULT set3DDopplerLevel(float level)
- public FMOD.RESULT set3DLevel(float level)
- public FMOD.RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
- public FMOD.RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
- public FMOD.RESULT set3DSpread(float angle)
- public FMOD.RESULT setCallback(FMOD.CHANNELCONTROL_CALLBACK callback)
- public FMOD.RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels)
- public FMOD.RESULT setDSPIndex(FMOD.DSP dsp, int index)
- public FMOD.RESULT setFadePointRamp(ulong dspclock, float volume)
- public FMOD.RESULT setLowPassGain(float gain)
- public FMOD.RESULT setMixLevelsInput(float[] levels, int numlevels)
- public FMOD.RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
- public FMOD.RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop)
- public FMOD.RESULT setMode(FMOD.MODE mode)
- public FMOD.RESULT setMute(bool mute)
- public FMOD.RESULT setPan(float pan)
- public FMOD.RESULT setPaused(bool paused)
- public FMOD.RESULT setPitch(float pitch)
- public FMOD.RESULT setReverbProperties(int instance, float wet)
- public FMOD.RESULT setUserData(System.IntPtr userdata)
- public FMOD.RESULT setVolume(float volume)
- public FMOD.RESULT setVolumeRamp(bool ramp)
- public FMOD.RESULT stop()

### public enum FMOD.INITFLAGS
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CHANNEL_DISTANCEFILTER = 512
- CHANNEL_LOWPASS = 256
- CLIP_OUTPUT = 8
- GEOMETRY_USECLOSEST = 262144
- MEMORY_TRACKING = 4194304
- MIX_FROM_UPDATE = 2
- NORMAL = 0
- PREFER_DOLBY_DOWNMIX = 524288
- PROFILE_ENABLE = 65536
- PROFILE_METER_ALL = 2097152
- STREAM_FROM_UPDATE = 1
- THREAD_UNSAFE = 1048576
- VOL0_BECOMES_VIRTUAL = 131072
- _3D_RIGHTHANDED = 4

### public struct FMOD.Memory

#### Methods
- private static FMOD.RESULT FMOD5_Memory_GetStats(out int currentalloced, out int maxalloced, bool blocking)
- private static FMOD.RESULT FMOD5_Memory_Initialize(System.IntPtr poolmem, int poollen, FMOD.MEMORY_ALLOC_CALLBACK useralloc, FMOD.MEMORY_REALLOC_CALLBACK userrealloc, FMOD.MEMORY_FREE_CALLBACK userfree, FMOD.MEMORY_TYPE memtypeflags)
- public static FMOD.RESULT GetStats(out int currentalloced, out int maxalloced, bool blocking = true)
- public static FMOD.RESULT Initialize(System.IntPtr poolmem, int poollen, FMOD.MEMORY_ALLOC_CALLBACK useralloc, FMOD.MEMORY_REALLOC_CALLBACK userrealloc, FMOD.MEMORY_FREE_CALLBACK userfree, FMOD.MEMORY_TYPE memtypeflags = ALL)

### public delegate FMOD.MEMORY_ALLOC_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public MEMORY_ALLOC_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(uint size, FMOD.MEMORY_TYPE type, System.IntPtr sourcestr, System.AsyncCallback callback, object object)
- public virtual System.IntPtr EndInvoke(System.IAsyncResult result)
- public virtual System.IntPtr Invoke(uint size, FMOD.MEMORY_TYPE type, System.IntPtr sourcestr)

### public delegate FMOD.MEMORY_FREE_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public MEMORY_FREE_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, FMOD.MEMORY_TYPE type, System.IntPtr sourcestr, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, FMOD.MEMORY_TYPE type, System.IntPtr sourcestr)

### public delegate FMOD.MEMORY_REALLOC_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public MEMORY_REALLOC_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, uint size, FMOD.MEMORY_TYPE type, System.IntPtr sourcestr, System.AsyncCallback callback, object object)
- public virtual System.IntPtr EndInvoke(System.IAsyncResult result)
- public virtual System.IntPtr Invoke(System.IntPtr ptr, uint size, FMOD.MEMORY_TYPE type, System.IntPtr sourcestr)

### public enum FMOD.MEMORY_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ALL = 4294967295
- DSP_BUFFER = 8
- NORMAL = 0
- PERSISTENT = 2097152
- PLUGIN = 16
- SAMPLEDATA = 4
- STREAM_DECODE = 2
- STREAM_FILE = 1

### public enum FMOD.MODE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ACCURATETIME = 16384
- CREATECOMPRESSEDSAMPLE = 512
- CREATESAMPLE = 256
- CREATESTREAM = 128
- DEFAULT = 0
- IGNORETAGS = 33554432
- LOOP_BIDI = 4
- LOOP_NORMAL = 2
- LOOP_OFF = 1
- LOWMEM = 134217728
- MPEGSEARCH = 32768
- NONBLOCKING = 65536
- OPENMEMORY = 2048
- OPENMEMORY_POINT = 268435456
- OPENONLY = 8192
- OPENRAW = 4096
- OPENUSER = 1024
- UNIQUE = 131072
- VIRTUAL_PLAYFROMSTART = 2147483648
- _2D = 8
- _3D = 16
- _3D_CUSTOMROLLOFF = 67108864
- _3D_HEADRELATIVE = 262144
- _3D_IGNOREGEOMETRY = 1073741824
- _3D_INVERSEROLLOFF = 1048576
- _3D_INVERSETAPEREDROLLOFF = 8388608
- _3D_LINEARROLLOFF = 2097152
- _3D_LINEARSQUAREROLLOFF = 4194304
- _3D_WORLDRELATIVE = 524288

### public enum FMOD.OPENSTATE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BUFFERING = 4
- CONNECTING = 3
- ERROR = 2
- LOADING = 1
- MAX = 8
- PLAYING = 6
- READY = 0
- SEEKING = 5
- SETPOSITION = 7

### public enum FMOD.OUTPUTTYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AAUDIO = 18
- ALSA = 9
- ASIO = 7
- AUDIO3D = 14
- AUDIOOUT = 13
- AUDIOTRACK = 11
- AUDIOWORKLET = 19
- AUTODETECT = 0
- COREAUDIO = 10
- MAX = 22
- NNAUDIO = 16
- NOSOUND = 2
- NOSOUND_NRT = 4
- OHAUDIO = 21
- OPENSL = 12
- PHASE = 20
- PULSEAUDIO = 8
- UNKNOWN = 1
- WASAPI = 6
- WAVWRITER = 3
- WAVWRITER_NRT = 5
- WEBAUDIO = 15
- WINSONIC = 17

### public struct FMOD.PLUGINLIST

#### Fields
- private System.IntPtr description
- private FMOD.PLUGINTYPE type

### public enum FMOD.PLUGINTYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CODEC = 1
- DSP = 2
- MAX = 3
- OUTPUT = 0

### public struct FMOD.PORT_INDEX

#### Fields
- public static const ulong FLAG_VR_CONTROLLER
- public static const ulong NONE

### public enum FMOD.PORT_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AUX = 6
- CONTROLLER = 3
- COPYRIGHT_MUSIC = 1
- MAX = 7
- MUSIC = 0
- PERSONAL = 4
- VIBRATION = 5
- VOICE = 2

### public class FMOD.PRESET

#### Constructors
- public PRESET()

#### Methods
- public static FMOD.REVERB_PROPERTIES ALLEY()
- public static FMOD.REVERB_PROPERTIES ARENA()
- public static FMOD.REVERB_PROPERTIES AUDITORIUM()
- public static FMOD.REVERB_PROPERTIES BATHROOM()
- public static FMOD.REVERB_PROPERTIES CARPETTEDHALLWAY()
- public static FMOD.REVERB_PROPERTIES CAVE()
- public static FMOD.REVERB_PROPERTIES CITY()
- public static FMOD.REVERB_PROPERTIES CONCERTHALL()
- public static FMOD.REVERB_PROPERTIES FOREST()
- public static FMOD.REVERB_PROPERTIES GENERIC()
- public static FMOD.REVERB_PROPERTIES HALLWAY()
- public static FMOD.REVERB_PROPERTIES HANGAR()
- public static FMOD.REVERB_PROPERTIES LIVINGROOM()
- public static FMOD.REVERB_PROPERTIES MOUNTAINS()
- public static FMOD.REVERB_PROPERTIES OFF()
- public static FMOD.REVERB_PROPERTIES PADDEDCELL()
- public static FMOD.REVERB_PROPERTIES PARKINGLOT()
- public static FMOD.REVERB_PROPERTIES PLAIN()
- public static FMOD.REVERB_PROPERTIES QUARRY()
- public static FMOD.REVERB_PROPERTIES ROOM()
- public static FMOD.REVERB_PROPERTIES SEWERPIPE()
- public static FMOD.REVERB_PROPERTIES STONECORRIDOR()
- public static FMOD.REVERB_PROPERTIES STONEROOM()
- public static FMOD.REVERB_PROPERTIES UNDERWATER()

### public enum FMOD.RESULT
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ERR_ALREADY_LOCKED = 78
- ERR_BADCOMMAND = 1
- ERR_CHANNEL_ALLOC = 2
- ERR_CHANNEL_STOLEN = 3
- ERR_DMA = 4
- ERR_DSP_CONNECTION = 5
- ERR_DSP_DONTPROCESS = 6
- ERR_DSP_FORMAT = 7
- ERR_DSP_INUSE = 8
- ERR_DSP_NOTFOUND = 9
- ERR_DSP_RESERVED = 10
- ERR_DSP_SILENCE = 11
- ERR_DSP_TYPE = 12
- ERR_EVENT_ALREADY_LOADED = 70
- ERR_EVENT_LIVEUPDATE_BUSY = 71
- ERR_EVENT_LIVEUPDATE_MISMATCH = 72
- ERR_EVENT_LIVEUPDATE_TIMEOUT = 73
- ERR_EVENT_NOTFOUND = 74
- ERR_FILE_BAD = 13
- ERR_FILE_COULDNOTSEEK = 14
- ERR_FILE_DISKEJECTED = 15
- ERR_FILE_ENDOFDATA = 17
- ERR_FILE_EOF = 16
- ERR_FILE_NOTFOUND = 18
- ERR_FORMAT = 19
- ERR_HEADER_MISMATCH = 20
- ERR_HTTP = 21
- ERR_HTTP_ACCESS = 22
- ERR_HTTP_PROXY_AUTH = 23
- ERR_HTTP_SERVER_ERROR = 24
- ERR_HTTP_TIMEOUT = 25
- ERR_INITIALIZATION = 26
- ERR_INITIALIZED = 27
- ERR_INTERNAL = 28
- ERR_INVALID_FLOAT = 29
- ERR_INVALID_HANDLE = 30
- ERR_INVALID_PARAM = 31
- ERR_INVALID_POSITION = 32
- ERR_INVALID_SPEAKER = 33
- ERR_INVALID_STRING = 77
- ERR_INVALID_SYNCPOINT = 34
- ERR_INVALID_THREAD = 35
- ERR_INVALID_VECTOR = 36
- ERR_MAXAUDIBLE = 37
- ERR_MEMORY = 38
- ERR_MEMORY_CANTPOINT = 39
- ERR_NEEDS3D = 40
- ERR_NEEDSHARDWARE = 41
- ERR_NET_CONNECT = 42
- ERR_NET_SOCKET_ERROR = 43
- ERR_NET_URL = 44
- ERR_NET_WOULD_BLOCK = 45
- ERR_NOTREADY = 46
- ERR_NOT_LOCKED = 79
- ERR_OUTPUT_ALLOCATED = 47
- ERR_OUTPUT_CREATEBUFFER = 48
- ERR_OUTPUT_DRIVERCALL = 49
- ERR_OUTPUT_FORMAT = 50
- ERR_OUTPUT_INIT = 51
- ERR_OUTPUT_NODRIVERS = 52
- ERR_PLUGIN = 53
- ERR_PLUGIN_MISSING = 54
- ERR_PLUGIN_RESOURCE = 55
- ERR_PLUGIN_VERSION = 56
- ERR_RECORD = 57
- ERR_RECORD_DISCONNECTED = 80
- ERR_REVERB_CHANNELGROUP = 58
- ERR_REVERB_INSTANCE = 59
- ERR_STUDIO_NOT_LOADED = 76
- ERR_STUDIO_UNINITIALIZED = 75
- ERR_SUBSOUNDS = 60
- ERR_SUBSOUND_ALLOCATED = 61
- ERR_SUBSOUND_CANTMOVE = 62
- ERR_TAGNOTFOUND = 63
- ERR_TOOMANYCHANNELS = 64
- ERR_TOOMANYSAMPLES = 81
- ERR_TRUNCATED = 65
- ERR_UNIMPLEMENTED = 66
- ERR_UNINITIALIZED = 67
- ERR_UNSUPPORTED = 68
- ERR_VERSION = 69
- OK = 0

### public struct FMOD.Reverb3D

#### Fields
- public System.IntPtr handle

#### Constructors
- public Reverb3D(System.IntPtr ptr)

#### Methods
- public void clearHandle()
- private static FMOD.RESULT FMOD5_Reverb3D_Get3DAttributes(System.IntPtr reverb3d, ref FMOD.VECTOR position, ref float mindistance, ref float maxdistance)
- private static FMOD.RESULT FMOD5_Reverb3D_GetActive(System.IntPtr reverb3d, out bool active)
- private static FMOD.RESULT FMOD5_Reverb3D_GetProperties(System.IntPtr reverb3d, ref FMOD.REVERB_PROPERTIES properties)
- private static FMOD.RESULT FMOD5_Reverb3D_GetUserData(System.IntPtr reverb3d, out System.IntPtr userdata)
- private static FMOD.RESULT FMOD5_Reverb3D_Release(System.IntPtr reverb3d)
- private static FMOD.RESULT FMOD5_Reverb3D_Set3DAttributes(System.IntPtr reverb3d, ref FMOD.VECTOR position, float mindistance, float maxdistance)
- private static FMOD.RESULT FMOD5_Reverb3D_SetActive(System.IntPtr reverb3d, bool active)
- private static FMOD.RESULT FMOD5_Reverb3D_SetProperties(System.IntPtr reverb3d, ref FMOD.REVERB_PROPERTIES properties)
- private static FMOD.RESULT FMOD5_Reverb3D_SetUserData(System.IntPtr reverb3d, System.IntPtr userdata)
- public FMOD.RESULT get3DAttributes(ref FMOD.VECTOR position, ref float mindistance, ref float maxdistance)
- public FMOD.RESULT getActive(out bool active)
- public FMOD.RESULT getProperties(ref FMOD.REVERB_PROPERTIES properties)
- public FMOD.RESULT getUserData(out System.IntPtr userdata)
- public bool hasHandle()
- public FMOD.RESULT release()
- public FMOD.RESULT set3DAttributes(ref FMOD.VECTOR position, float mindistance, float maxdistance)
- public FMOD.RESULT setActive(bool active)
- public FMOD.RESULT setProperties(ref FMOD.REVERB_PROPERTIES properties)
- public FMOD.RESULT setUserData(System.IntPtr userdata)

### public struct FMOD.REVERB_PROPERTIES

#### Fields
- public float DecayTime
- public float Density
- public float Diffusion
- public float EarlyDelay
- public float EarlyLateMix
- public float HFDecayRatio
- public float HFReference
- public float HighCut
- public float LateDelay
- public float LowShelfFrequency
- public float LowShelfGain
- public float WetLevel

#### Constructors
- public REVERB_PROPERTIES(float decayTime, float earlyDelay, float lateDelay, float hfReference, float hfDecayRatio, float diffusion, float density, float lowShelfFrequency, float lowShelfGain, float highCut, float earlyLateMix, float wetLevel)

### public struct FMOD.Sound

#### Fields
- public System.IntPtr handle

#### Constructors
- public Sound(System.IntPtr ptr)

#### Methods
- public FMOD.RESULT addSyncPoint(uint offset, FMOD.TIMEUNIT offsettype, string name, out System.IntPtr point)
- public void clearHandle()
- public FMOD.RESULT deleteSyncPoint(System.IntPtr point)
- private static FMOD.RESULT FMOD5_Sound_AddSyncPoint(System.IntPtr sound, uint offset, FMOD.TIMEUNIT offsettype, byte[] name, out System.IntPtr point)
- private static FMOD.RESULT FMOD5_Sound_DeleteSyncPoint(System.IntPtr sound, System.IntPtr point)
- private static FMOD.RESULT FMOD5_Sound_Get3DConeSettings(System.IntPtr sound, out float insideconeangle, out float outsideconeangle, out float outsidevolume)
- private static FMOD.RESULT FMOD5_Sound_Get3DCustomRolloff(System.IntPtr sound, out System.IntPtr points, out int numpoints)
- private static FMOD.RESULT FMOD5_Sound_Get3DMinMaxDistance(System.IntPtr sound, out float min, out float max)
- private static FMOD.RESULT FMOD5_Sound_GetDefaults(System.IntPtr sound, out float frequency, out int priority)
- private static FMOD.RESULT FMOD5_Sound_GetFormat(System.IntPtr sound, out FMOD.SOUND_TYPE type, out FMOD.SOUND_FORMAT format, out int channels, out int bits)
- private static FMOD.RESULT FMOD5_Sound_GetLength(System.IntPtr sound, out uint length, FMOD.TIMEUNIT lengthtype)
- private static FMOD.RESULT FMOD5_Sound_GetLoopCount(System.IntPtr sound, out int loopcount)
- private static FMOD.RESULT FMOD5_Sound_GetLoopPoints(System.IntPtr sound, out uint loopstart, FMOD.TIMEUNIT loopstarttype, out uint loopend, FMOD.TIMEUNIT loopendtype)
- private static FMOD.RESULT FMOD5_Sound_GetMode(System.IntPtr sound, out FMOD.MODE mode)
- private static FMOD.RESULT FMOD5_Sound_GetMusicChannelVolume(System.IntPtr sound, int channel, out float volume)
- private static FMOD.RESULT FMOD5_Sound_GetMusicNumChannels(System.IntPtr sound, out int numchannels)
- private static FMOD.RESULT FMOD5_Sound_GetMusicSpeed(System.IntPtr sound, out float speed)
- private static FMOD.RESULT FMOD5_Sound_GetName(System.IntPtr sound, System.IntPtr name, int namelen)
- private static FMOD.RESULT FMOD5_Sound_GetNumSubSounds(System.IntPtr sound, out int numsubsounds)
- private static FMOD.RESULT FMOD5_Sound_GetNumSyncPoints(System.IntPtr sound, out int numsyncpoints)
- private static FMOD.RESULT FMOD5_Sound_GetNumTags(System.IntPtr sound, out int numtags, out int numtagsupdated)
- private static FMOD.RESULT FMOD5_Sound_GetOpenState(System.IntPtr sound, out FMOD.OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy)
- private static FMOD.RESULT FMOD5_Sound_GetSoundGroup(System.IntPtr sound, out System.IntPtr soundgroup)
- private static FMOD.RESULT FMOD5_Sound_GetSubSound(System.IntPtr sound, int index, out System.IntPtr subsound)
- private static FMOD.RESULT FMOD5_Sound_GetSubSoundParent(System.IntPtr sound, out System.IntPtr parentsound)
- private static FMOD.RESULT FMOD5_Sound_GetSyncPoint(System.IntPtr sound, int index, out System.IntPtr point)
- private static FMOD.RESULT FMOD5_Sound_GetSyncPointInfo(System.IntPtr sound, System.IntPtr point, System.IntPtr name, int namelen, out uint offset, FMOD.TIMEUNIT offsettype)
- private static FMOD.RESULT FMOD5_Sound_GetSystemObject(System.IntPtr sound, out System.IntPtr system)
- private static FMOD.RESULT FMOD5_Sound_GetTag(System.IntPtr sound, byte[] name, int index, out FMOD.TAG tag)
- private static FMOD.RESULT FMOD5_Sound_GetUserData(System.IntPtr sound, out System.IntPtr userdata)
- private static FMOD.RESULT FMOD5_Sound_Lock(System.IntPtr sound, uint offset, uint length, out System.IntPtr ptr1, out System.IntPtr ptr2, out uint len1, out uint len2)
- private static FMOD.RESULT FMOD5_Sound_ReadData(System.IntPtr sound, byte[] buffer, uint length, System.IntPtr zero)
- private static FMOD.RESULT FMOD5_Sound_ReadData(System.IntPtr sound, byte[] buffer, uint length, out uint read)
- private static FMOD.RESULT FMOD5_Sound_ReadData(System.IntPtr sound, System.IntPtr buffer, uint length, out uint read)
- private static FMOD.RESULT FMOD5_Sound_Release(System.IntPtr sound)
- private static FMOD.RESULT FMOD5_Sound_SeekData(System.IntPtr sound, uint pcm)
- private static FMOD.RESULT FMOD5_Sound_Set3DConeSettings(System.IntPtr sound, float insideconeangle, float outsideconeangle, float outsidevolume)
- private static FMOD.RESULT FMOD5_Sound_Set3DCustomRolloff(System.IntPtr sound, ref FMOD.VECTOR points, int numpoints)
- private static FMOD.RESULT FMOD5_Sound_Set3DMinMaxDistance(System.IntPtr sound, float min, float max)
- private static FMOD.RESULT FMOD5_Sound_SetDefaults(System.IntPtr sound, float frequency, int priority)
- private static FMOD.RESULT FMOD5_Sound_SetLoopCount(System.IntPtr sound, int loopcount)
- private static FMOD.RESULT FMOD5_Sound_SetLoopPoints(System.IntPtr sound, uint loopstart, FMOD.TIMEUNIT loopstarttype, uint loopend, FMOD.TIMEUNIT loopendtype)
- private static FMOD.RESULT FMOD5_Sound_SetMode(System.IntPtr sound, FMOD.MODE mode)
- private static FMOD.RESULT FMOD5_Sound_SetMusicChannelVolume(System.IntPtr sound, int channel, float volume)
- private static FMOD.RESULT FMOD5_Sound_SetMusicSpeed(System.IntPtr sound, float speed)
- private static FMOD.RESULT FMOD5_Sound_SetSoundGroup(System.IntPtr sound, System.IntPtr soundgroup)
- private static FMOD.RESULT FMOD5_Sound_SetUserData(System.IntPtr sound, System.IntPtr userdata)
- private static FMOD.RESULT FMOD5_Sound_Unlock(System.IntPtr sound, System.IntPtr ptr1, System.IntPtr ptr2, uint len1, uint len2)
- public FMOD.RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
- public FMOD.RESULT get3DCustomRolloff(out System.IntPtr points, out int numpoints)
- public FMOD.RESULT get3DMinMaxDistance(out float min, out float max)
- public FMOD.RESULT getDefaults(out float frequency, out int priority)
- public FMOD.RESULT getFormat(out FMOD.SOUND_TYPE type, out FMOD.SOUND_FORMAT format, out int channels, out int bits)
- public FMOD.RESULT getLength(out uint length, FMOD.TIMEUNIT lengthtype)
- public FMOD.RESULT getLoopCount(out int loopcount)
- public FMOD.RESULT getLoopPoints(out uint loopstart, FMOD.TIMEUNIT loopstarttype, out uint loopend, FMOD.TIMEUNIT loopendtype)
- public FMOD.RESULT getMode(out FMOD.MODE mode)
- public FMOD.RESULT getMusicChannelVolume(int channel, out float volume)
- public FMOD.RESULT getMusicNumChannels(out int numchannels)
- public FMOD.RESULT getMusicSpeed(out float speed)
- public FMOD.RESULT getName(out string name, int namelen)
- public FMOD.RESULT getNumSubSounds(out int numsubsounds)
- public FMOD.RESULT getNumSyncPoints(out int numsyncpoints)
- public FMOD.RESULT getNumTags(out int numtags, out int numtagsupdated)
- public FMOD.RESULT getOpenState(out FMOD.OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy)
- public FMOD.RESULT getSoundGroup(out FMOD.SoundGroup soundgroup)
- public FMOD.RESULT getSubSound(int index, out FMOD.Sound subsound)
- public FMOD.RESULT getSubSoundParent(out FMOD.Sound parentsound)
- public FMOD.RESULT getSyncPoint(int index, out System.IntPtr point)
- public FMOD.RESULT getSyncPointInfo(System.IntPtr point, out string name, int namelen, out uint offset, FMOD.TIMEUNIT offsettype)
- public FMOD.RESULT getSyncPointInfo(System.IntPtr point, out uint offset, FMOD.TIMEUNIT offsettype)
- public FMOD.RESULT getSystemObject(out FMOD.System system)
- public FMOD.RESULT getTag(string name, int index, out FMOD.TAG tag)
- public FMOD.RESULT getUserData(out System.IntPtr userdata)
- public bool hasHandle()
- public FMOD.RESULT lock(uint offset, uint length, out System.IntPtr ptr1, out System.IntPtr ptr2, out uint len1, out uint len2)
- public FMOD.RESULT readData(byte[] buffer)
- public FMOD.RESULT readData(byte[] buffer, out uint read)
- public FMOD.RESULT readData(System.IntPtr buffer, uint length, out uint read)
- public FMOD.RESULT release()
- public FMOD.RESULT seekData(uint pcm)
- public FMOD.RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
- public FMOD.RESULT set3DCustomRolloff(ref FMOD.VECTOR points, int numpoints)
- public FMOD.RESULT set3DMinMaxDistance(float min, float max)
- public FMOD.RESULT setDefaults(float frequency, int priority)
- public FMOD.RESULT setLoopCount(int loopcount)
- public FMOD.RESULT setLoopPoints(uint loopstart, FMOD.TIMEUNIT loopstarttype, uint loopend, FMOD.TIMEUNIT loopendtype)
- public FMOD.RESULT setMode(FMOD.MODE mode)
- public FMOD.RESULT setMusicChannelVolume(int channel, float volume)
- public FMOD.RESULT setMusicSpeed(float speed)
- public FMOD.RESULT setSoundGroup(FMOD.SoundGroup soundgroup)
- public FMOD.RESULT setUserData(System.IntPtr userdata)
- public FMOD.RESULT unlock(System.IntPtr ptr1, System.IntPtr ptr2, uint len1, uint len2)

### public struct FMOD.SoundGroup

#### Fields
- public System.IntPtr handle

#### Constructors
- public SoundGroup(System.IntPtr ptr)

#### Methods
- public void clearHandle()
- private static FMOD.RESULT FMOD5_SoundGroup_GetMaxAudible(System.IntPtr soundgroup, out int maxaudible)
- private static FMOD.RESULT FMOD5_SoundGroup_GetMaxAudibleBehavior(System.IntPtr soundgroup, out FMOD.SOUNDGROUP_BEHAVIOR behavior)
- private static FMOD.RESULT FMOD5_SoundGroup_GetMuteFadeSpeed(System.IntPtr soundgroup, out float speed)
- private static FMOD.RESULT FMOD5_SoundGroup_GetName(System.IntPtr soundgroup, System.IntPtr name, int namelen)
- private static FMOD.RESULT FMOD5_SoundGroup_GetNumPlaying(System.IntPtr soundgroup, out int numplaying)
- private static FMOD.RESULT FMOD5_SoundGroup_GetNumSounds(System.IntPtr soundgroup, out int numsounds)
- private static FMOD.RESULT FMOD5_SoundGroup_GetSound(System.IntPtr soundgroup, int index, out System.IntPtr sound)
- private static FMOD.RESULT FMOD5_SoundGroup_GetSystemObject(System.IntPtr soundgroup, out System.IntPtr system)
- private static FMOD.RESULT FMOD5_SoundGroup_GetUserData(System.IntPtr soundgroup, out System.IntPtr userdata)
- private static FMOD.RESULT FMOD5_SoundGroup_GetVolume(System.IntPtr soundgroup, out float volume)
- private static FMOD.RESULT FMOD5_SoundGroup_Release(System.IntPtr soundgroup)
- private static FMOD.RESULT FMOD5_SoundGroup_SetMaxAudible(System.IntPtr soundgroup, int maxaudible)
- private static FMOD.RESULT FMOD5_SoundGroup_SetMaxAudibleBehavior(System.IntPtr soundgroup, FMOD.SOUNDGROUP_BEHAVIOR behavior)
- private static FMOD.RESULT FMOD5_SoundGroup_SetMuteFadeSpeed(System.IntPtr soundgroup, float speed)
- private static FMOD.RESULT FMOD5_SoundGroup_SetUserData(System.IntPtr soundgroup, System.IntPtr userdata)
- private static FMOD.RESULT FMOD5_SoundGroup_SetVolume(System.IntPtr soundgroup, float volume)
- private static FMOD.RESULT FMOD5_SoundGroup_Stop(System.IntPtr soundgroup)
- public FMOD.RESULT getMaxAudible(out int maxaudible)
- public FMOD.RESULT getMaxAudibleBehavior(out FMOD.SOUNDGROUP_BEHAVIOR behavior)
- public FMOD.RESULT getMuteFadeSpeed(out float speed)
- public FMOD.RESULT getName(out string name, int namelen)
- public FMOD.RESULT getNumPlaying(out int numplaying)
- public FMOD.RESULT getNumSounds(out int numsounds)
- public FMOD.RESULT getSound(int index, out FMOD.Sound sound)
- public FMOD.RESULT getSystemObject(out FMOD.System system)
- public FMOD.RESULT getUserData(out System.IntPtr userdata)
- public FMOD.RESULT getVolume(out float volume)
- public bool hasHandle()
- public FMOD.RESULT release()
- public FMOD.RESULT setMaxAudible(int maxaudible)
- public FMOD.RESULT setMaxAudibleBehavior(FMOD.SOUNDGROUP_BEHAVIOR behavior)
- public FMOD.RESULT setMuteFadeSpeed(float speed)
- public FMOD.RESULT setUserData(System.IntPtr userdata)
- public FMOD.RESULT setVolume(float volume)
- public FMOD.RESULT stop()

### public enum FMOD.SOUNDGROUP_BEHAVIOR
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BEHAVIOR_FAIL = 0
- BEHAVIOR_MUTE = 1
- BEHAVIOR_STEALLOWEST = 2
- MAX = 3

### public enum FMOD.SOUND_FORMAT
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BITSTREAM = 6
- MAX = 7
- NONE = 0
- PCM16 = 2
- PCM24 = 3
- PCM32 = 4
- PCM8 = 1
- PCMFLOAT = 5

### public delegate FMOD.SOUND_NONBLOCK_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public SOUND_NONBLOCK_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr sound, FMOD.RESULT result, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(System.IntPtr sound, FMOD.RESULT result)

### public delegate FMOD.SOUND_PCMREAD_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public SOUND_PCMREAD_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr sound, System.IntPtr data, uint datalen, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(System.IntPtr sound, System.IntPtr data, uint datalen)

### public delegate FMOD.SOUND_PCMSETPOS_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public SOUND_PCMSETPOS_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr sound, int subsound, uint position, FMOD.TIMEUNIT postype, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(System.IntPtr sound, int subsound, uint position, FMOD.TIMEUNIT postype)

### public enum FMOD.SOUND_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AIFF = 1
- ASF = 2
- AT9 = 19
- AUDIOQUEUE = 18
- DLS = 3
- FADPCM = 23
- FLAC = 4
- FSB = 5
- IT = 6
- MAX = 25
- MEDIACODEC = 22
- MEDIA_FOUNDATION = 21
- MIDI = 7
- MOD = 8
- MPEG = 9
- OGGVORBIS = 10
- OPUS = 24
- PLAYLIST = 11
- RAW = 12
- S3M = 13
- UNKNOWN = 0
- USER = 14
- VORBIS = 20
- WAV = 15
- XM = 16
- XMA = 17

### public enum FMOD.SPEAKER
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BACK_LEFT = 6
- BACK_RIGHT = 7
- FRONT_CENTER = 2
- FRONT_LEFT = 0
- FRONT_RIGHT = 1
- LOW_FREQUENCY = 3
- MAX = 12
- NONE = -1
- SURROUND_LEFT = 4
- SURROUND_RIGHT = 5
- TOP_BACK_LEFT = 10
- TOP_BACK_RIGHT = 11
- TOP_FRONT_LEFT = 8
- TOP_FRONT_RIGHT = 9

### public enum FMOD.SPEAKERMODE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DEFAULT = 0
- MAX = 9
- MONO = 2
- QUAD = 4
- RAW = 1
- STEREO = 3
- SURROUND = 5
- _5POINT1 = 6
- _7POINT1 = 7
- _7POINT1POINT4 = 8

### internal static class FMOD.StringHelper

#### Fields
- private static System.Collections.Generic.List<FMOD.StringHelper.ThreadSafeEncoding> encoders

#### Constructors
- private static StringHelper()

#### Methods
- public static FMOD.StringHelper.ThreadSafeEncoding GetFreeHelper()

### public struct FMOD.StringWrapper

#### Fields
- private System.IntPtr nativeUtf8Ptr

#### Constructors
- public StringWrapper(System.IntPtr ptr)

#### Methods
- public bool Equals(byte[] comparison)
- public static string op_Implicit(FMOD.StringWrapper fstring)
- public bool StartsWith(byte[] prefix)

### public struct FMOD.System

#### Fields
- public System.IntPtr handle

#### Constructors
- public System(System.IntPtr ptr)

#### Methods
- public FMOD.RESULT attachChannelGroupToPort(FMOD.PORT_TYPE portType, ulong portIndex, FMOD.ChannelGroup channelgroup, bool passThru = false)
- public FMOD.RESULT attachFileSystem(FMOD.FILE_OPEN_CALLBACK useropen, FMOD.FILE_CLOSE_CALLBACK userclose, FMOD.FILE_READ_CALLBACK userread, FMOD.FILE_SEEK_CALLBACK userseek)
- public void clearHandle()
- public FMOD.RESULT close()
- public FMOD.RESULT createChannelGroup(string name, out FMOD.ChannelGroup channelgroup)
- public FMOD.RESULT createDSP(ref FMOD.DSP_DESCRIPTION description, out FMOD.DSP dsp)
- public FMOD.RESULT createDSPByPlugin(uint handle, out FMOD.DSP dsp)
- public FMOD.RESULT createDSPByType(FMOD.DSP_TYPE type, out FMOD.DSP dsp)
- public FMOD.RESULT createGeometry(int maxpolygons, int maxvertices, out FMOD.Geometry geometry)
- public FMOD.RESULT createReverb3D(out FMOD.Reverb3D reverb)
- public FMOD.RESULT createSound(string name, FMOD.MODE mode, ref FMOD.CREATESOUNDEXINFO exinfo, out FMOD.Sound sound)
- public FMOD.RESULT createSound(byte[] data, FMOD.MODE mode, ref FMOD.CREATESOUNDEXINFO exinfo, out FMOD.Sound sound)
- public FMOD.RESULT createSound(System.IntPtr name_or_data, FMOD.MODE mode, ref FMOD.CREATESOUNDEXINFO exinfo, out FMOD.Sound sound)
- public FMOD.RESULT createSound(string name, FMOD.MODE mode, out FMOD.Sound sound)
- public FMOD.RESULT createSoundGroup(string name, out FMOD.SoundGroup soundgroup)
- public FMOD.RESULT createStream(string name, FMOD.MODE mode, ref FMOD.CREATESOUNDEXINFO exinfo, out FMOD.Sound sound)
- public FMOD.RESULT createStream(byte[] data, FMOD.MODE mode, ref FMOD.CREATESOUNDEXINFO exinfo, out FMOD.Sound sound)
- public FMOD.RESULT createStream(System.IntPtr name_or_data, FMOD.MODE mode, ref FMOD.CREATESOUNDEXINFO exinfo, out FMOD.Sound sound)
- public FMOD.RESULT createStream(string name, FMOD.MODE mode, out FMOD.Sound sound)
- public FMOD.RESULT detachChannelGroupFromPort(FMOD.ChannelGroup channelgroup)
- private static FMOD.RESULT FMOD5_System_AttachChannelGroupToPort(System.IntPtr system, FMOD.PORT_TYPE portType, ulong portIndex, System.IntPtr channelgroup, bool passThru)
- private static FMOD.RESULT FMOD5_System_AttachFileSystem(System.IntPtr system, FMOD.FILE_OPEN_CALLBACK useropen, FMOD.FILE_CLOSE_CALLBACK userclose, FMOD.FILE_READ_CALLBACK userread, FMOD.FILE_SEEK_CALLBACK userseek)
- private static FMOD.RESULT FMOD5_System_Close(System.IntPtr system)
- private static FMOD.RESULT FMOD5_System_CreateChannelGroup(System.IntPtr system, byte[] name, out System.IntPtr channelgroup)
- private static FMOD.RESULT FMOD5_System_CreateDSP(System.IntPtr system, ref FMOD.DSP_DESCRIPTION description, out System.IntPtr dsp)
- private static FMOD.RESULT FMOD5_System_CreateDSPByPlugin(System.IntPtr system, uint handle, out System.IntPtr dsp)
- private static FMOD.RESULT FMOD5_System_CreateDSPByType(System.IntPtr system, FMOD.DSP_TYPE type, out System.IntPtr dsp)
- private static FMOD.RESULT FMOD5_System_CreateGeometry(System.IntPtr system, int maxpolygons, int maxvertices, out System.IntPtr geometry)
- private static FMOD.RESULT FMOD5_System_CreateReverb3D(System.IntPtr system, out System.IntPtr reverb)
- private static FMOD.RESULT FMOD5_System_CreateSound(System.IntPtr system, byte[] name_or_data, FMOD.MODE mode, ref FMOD.CREATESOUNDEXINFO exinfo, out System.IntPtr sound)
- private static FMOD.RESULT FMOD5_System_CreateSound(System.IntPtr system, System.IntPtr name_or_data, FMOD.MODE mode, ref FMOD.CREATESOUNDEXINFO exinfo, out System.IntPtr sound)
- private static FMOD.RESULT FMOD5_System_CreateSoundGroup(System.IntPtr system, byte[] name, out System.IntPtr soundgroup)
- private static FMOD.RESULT FMOD5_System_CreateStream(System.IntPtr system, byte[] name_or_data, FMOD.MODE mode, ref FMOD.CREATESOUNDEXINFO exinfo, out System.IntPtr sound)
- private static FMOD.RESULT FMOD5_System_CreateStream(System.IntPtr system, System.IntPtr name_or_data, FMOD.MODE mode, ref FMOD.CREATESOUNDEXINFO exinfo, out System.IntPtr sound)
- private static FMOD.RESULT FMOD5_System_DetachChannelGroupFromPort(System.IntPtr system, System.IntPtr channelgroup)
- private static FMOD.RESULT FMOD5_System_Get3DListenerAttributes(System.IntPtr system, int listener, out FMOD.VECTOR pos, out FMOD.VECTOR vel, out FMOD.VECTOR forward, out FMOD.VECTOR up)
- private static FMOD.RESULT FMOD5_System_Get3DNumListeners(System.IntPtr system, out int numlisteners)
- private static FMOD.RESULT FMOD5_System_Get3DSettings(System.IntPtr system, out float dopplerscale, out float distancefactor, out float rolloffscale)
- private static FMOD.RESULT FMOD5_System_GetAdvancedSettings(System.IntPtr system, ref FMOD.ADVANCEDSETTINGS settings)
- private static FMOD.RESULT FMOD5_System_GetChannel(System.IntPtr system, int channelid, out System.IntPtr channel)
- private static FMOD.RESULT FMOD5_System_GetChannelsPlaying(System.IntPtr system, out int channels, System.IntPtr zero)
- private static FMOD.RESULT FMOD5_System_GetChannelsPlaying(System.IntPtr system, out int channels, out int realchannels)
- private static FMOD.RESULT FMOD5_System_GetCPUUsage(System.IntPtr system, out FMOD.CPU_USAGE usage)
- private static FMOD.RESULT FMOD5_System_GetDefaultMixMatrix(System.IntPtr system, FMOD.SPEAKERMODE sourcespeakermode, FMOD.SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop)
- private static FMOD.RESULT FMOD5_System_GetDriver(System.IntPtr system, out int driver)
- private static FMOD.RESULT FMOD5_System_GetDriverInfo(System.IntPtr system, int id, System.IntPtr name, int namelen, out System.Guid guid, out int systemrate, out FMOD.SPEAKERMODE speakermode, out int speakermodechannels)
- private static FMOD.RESULT FMOD5_System_GetDSPBufferSize(System.IntPtr system, out uint bufferlength, out int numbuffers)
- private static FMOD.RESULT FMOD5_System_GetDSPInfoByPlugin(System.IntPtr system, uint handle, out System.IntPtr description)
- private static FMOD.RESULT FMOD5_System_GetDSPInfoByType(System.IntPtr system, FMOD.DSP_TYPE type, out System.IntPtr description)
- private static FMOD.RESULT FMOD5_System_GetFileUsage(System.IntPtr system, out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead)
- private static FMOD.RESULT FMOD5_System_GetGeometryOcclusion(System.IntPtr system, ref FMOD.VECTOR listener, ref FMOD.VECTOR source, out float direct, out float reverb)
- private static FMOD.RESULT FMOD5_System_GetGeometrySettings(System.IntPtr system, out float maxworldsize)
- private static FMOD.RESULT FMOD5_System_GetMasterChannelGroup(System.IntPtr system, out System.IntPtr channelgroup)
- private static FMOD.RESULT FMOD5_System_GetMasterSoundGroup(System.IntPtr system, out System.IntPtr soundgroup)
- private static FMOD.RESULT FMOD5_System_GetNestedPlugin(System.IntPtr system, uint handle, int index, out uint nestedhandle)
- private static FMOD.RESULT FMOD5_System_GetNetworkProxy(System.IntPtr system, System.IntPtr proxy, int proxylen)
- private static FMOD.RESULT FMOD5_System_GetNetworkTimeout(System.IntPtr system, out int timeout)
- private static FMOD.RESULT FMOD5_System_GetNumDrivers(System.IntPtr system, out int numdrivers)
- private static FMOD.RESULT FMOD5_System_GetNumNestedPlugins(System.IntPtr system, uint handle, out int count)
- private static FMOD.RESULT FMOD5_System_GetNumPlugins(System.IntPtr system, FMOD.PLUGINTYPE plugintype, out int numplugins)
- private static FMOD.RESULT FMOD5_System_GetOutput(System.IntPtr system, out FMOD.OUTPUTTYPE output)
- private static FMOD.RESULT FMOD5_System_GetOutputByPlugin(System.IntPtr system, out uint handle)
- private static FMOD.RESULT FMOD5_System_GetOutputHandle(System.IntPtr system, out System.IntPtr handle)
- private static FMOD.RESULT FMOD5_System_GetPluginHandle(System.IntPtr system, FMOD.PLUGINTYPE plugintype, int index, out uint handle)
- private static FMOD.RESULT FMOD5_System_GetPluginInfo(System.IntPtr system, uint handle, out FMOD.PLUGINTYPE plugintype, System.IntPtr name, int namelen, out uint version)
- private static FMOD.RESULT FMOD5_System_GetRecordDriverInfo(System.IntPtr system, int id, System.IntPtr name, int namelen, out System.Guid guid, out int systemrate, out FMOD.SPEAKERMODE speakermode, out int speakermodechannels, out FMOD.DRIVER_STATE state)
- private static FMOD.RESULT FMOD5_System_GetRecordNumDrivers(System.IntPtr system, out int numdrivers, out int numconnected)
- private static FMOD.RESULT FMOD5_System_GetRecordPosition(System.IntPtr system, int id, out uint position)
- private static FMOD.RESULT FMOD5_System_GetReverbProperties(System.IntPtr system, int instance, out FMOD.REVERB_PROPERTIES prop)
- private static FMOD.RESULT FMOD5_System_GetSoftwareChannels(System.IntPtr system, out int numsoftwarechannels)
- private static FMOD.RESULT FMOD5_System_GetSoftwareFormat(System.IntPtr system, out int samplerate, out FMOD.SPEAKERMODE speakermode, out int numrawspeakers)
- private static FMOD.RESULT FMOD5_System_GetSpeakerModeChannels(System.IntPtr system, FMOD.SPEAKERMODE mode, out int channels)
- private static FMOD.RESULT FMOD5_System_GetSpeakerPosition(System.IntPtr system, FMOD.SPEAKER speaker, out float x, out float y, out bool active)
- private static FMOD.RESULT FMOD5_System_GetStreamBufferSize(System.IntPtr system, out uint filebuffersize, out FMOD.TIMEUNIT filebuffersizetype)
- private static FMOD.RESULT FMOD5_System_GetUserData(System.IntPtr system, out System.IntPtr userdata)
- private static FMOD.RESULT FMOD5_System_GetVersion(System.IntPtr system, out uint version)
- private static FMOD.RESULT FMOD5_System_Init(System.IntPtr system, int maxchannels, FMOD.INITFLAGS flags, System.IntPtr extradriverdata)
- private static FMOD.RESULT FMOD5_System_IsRecording(System.IntPtr system, int id, out bool recording)
- private static FMOD.RESULT FMOD5_System_LoadGeometry(System.IntPtr system, System.IntPtr data, int datasize, out System.IntPtr geometry)
- private static FMOD.RESULT FMOD5_System_LoadPlugin(System.IntPtr system, byte[] filename, out uint handle, uint priority)
- private static FMOD.RESULT FMOD5_System_LockDSP(System.IntPtr system)
- private static FMOD.RESULT FMOD5_System_MixerResume(System.IntPtr system)
- private static FMOD.RESULT FMOD5_System_MixerSuspend(System.IntPtr system)
- private static FMOD.RESULT FMOD5_System_PlayDSP(System.IntPtr system, System.IntPtr dsp, System.IntPtr channelgroup, bool paused, out System.IntPtr channel)
- private static FMOD.RESULT FMOD5_System_PlaySound(System.IntPtr system, System.IntPtr sound, System.IntPtr channelgroup, bool paused, out System.IntPtr channel)
- private static FMOD.RESULT FMOD5_System_RecordStart(System.IntPtr system, int id, System.IntPtr sound, bool loop)
- private static FMOD.RESULT FMOD5_System_RecordStop(System.IntPtr system, int id)
- private static FMOD.RESULT FMOD5_System_RegisterDSP(System.IntPtr system, ref FMOD.DSP_DESCRIPTION description, out uint handle)
- private static FMOD.RESULT FMOD5_System_Release(System.IntPtr system)
- private static FMOD.RESULT FMOD5_System_Set3DListenerAttributes(System.IntPtr system, int listener, ref FMOD.VECTOR pos, ref FMOD.VECTOR vel, ref FMOD.VECTOR forward, ref FMOD.VECTOR up)
- private static FMOD.RESULT FMOD5_System_Set3DNumListeners(System.IntPtr system, int numlisteners)
- private static FMOD.RESULT FMOD5_System_Set3DRolloffCallback(System.IntPtr system, FMOD.CB_3D_ROLLOFF_CALLBACK callback)
- private static FMOD.RESULT FMOD5_System_Set3DSettings(System.IntPtr system, float dopplerscale, float distancefactor, float rolloffscale)
- private static FMOD.RESULT FMOD5_System_SetAdvancedSettings(System.IntPtr system, ref FMOD.ADVANCEDSETTINGS settings)
- private static FMOD.RESULT FMOD5_System_SetCallback(System.IntPtr system, FMOD.SYSTEM_CALLBACK callback, FMOD.SYSTEM_CALLBACK_TYPE callbackmask)
- private static FMOD.RESULT FMOD5_System_SetDriver(System.IntPtr system, int driver)
- private static FMOD.RESULT FMOD5_System_SetDSPBufferSize(System.IntPtr system, uint bufferlength, int numbuffers)
- private static FMOD.RESULT FMOD5_System_SetFileSystem(System.IntPtr system, FMOD.FILE_OPEN_CALLBACK useropen, FMOD.FILE_CLOSE_CALLBACK userclose, FMOD.FILE_READ_CALLBACK userread, FMOD.FILE_SEEK_CALLBACK userseek, FMOD.FILE_ASYNCREAD_CALLBACK userasyncread, FMOD.FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign)
- private static FMOD.RESULT FMOD5_System_SetGeometrySettings(System.IntPtr system, float maxworldsize)
- private static FMOD.RESULT FMOD5_System_SetNetworkProxy(System.IntPtr system, byte[] proxy)
- private static FMOD.RESULT FMOD5_System_SetNetworkTimeout(System.IntPtr system, int timeout)
- private static FMOD.RESULT FMOD5_System_SetOutput(System.IntPtr system, FMOD.OUTPUTTYPE output)
- private static FMOD.RESULT FMOD5_System_SetOutputByPlugin(System.IntPtr system, uint handle)
- private static FMOD.RESULT FMOD5_System_SetPluginPath(System.IntPtr system, byte[] path)
- private static FMOD.RESULT FMOD5_System_SetReverbProperties(System.IntPtr system, int instance, ref FMOD.REVERB_PROPERTIES prop)
- private static FMOD.RESULT FMOD5_System_SetSoftwareChannels(System.IntPtr system, int numsoftwarechannels)
- private static FMOD.RESULT FMOD5_System_SetSoftwareFormat(System.IntPtr system, int samplerate, FMOD.SPEAKERMODE speakermode, int numrawspeakers)
- private static FMOD.RESULT FMOD5_System_SetSpeakerPosition(System.IntPtr system, FMOD.SPEAKER speaker, float x, float y, bool active)
- private static FMOD.RESULT FMOD5_System_SetStreamBufferSize(System.IntPtr system, uint filebuffersize, FMOD.TIMEUNIT filebuffersizetype)
- private static FMOD.RESULT FMOD5_System_SetUserData(System.IntPtr system, System.IntPtr userdata)
- private static FMOD.RESULT FMOD5_System_UnloadPlugin(System.IntPtr system, uint handle)
- private static FMOD.RESULT FMOD5_System_UnlockDSP(System.IntPtr system)
- private static FMOD.RESULT FMOD5_System_Update(System.IntPtr system)
- public FMOD.RESULT get3DListenerAttributes(int listener, out FMOD.VECTOR pos, out FMOD.VECTOR vel, out FMOD.VECTOR forward, out FMOD.VECTOR up)
- public FMOD.RESULT get3DNumListeners(out int numlisteners)
- public FMOD.RESULT get3DSettings(out float dopplerscale, out float distancefactor, out float rolloffscale)
- public FMOD.RESULT getAdvancedSettings(ref FMOD.ADVANCEDSETTINGS settings)
- public FMOD.RESULT getChannel(int channelid, out FMOD.Channel channel)
- public FMOD.RESULT getChannelsPlaying(out int channels)
- public FMOD.RESULT getChannelsPlaying(out int channels, out int realchannels)
- public FMOD.RESULT getCPUUsage(out FMOD.CPU_USAGE usage)
- public FMOD.RESULT getDefaultMixMatrix(FMOD.SPEAKERMODE sourcespeakermode, FMOD.SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop)
- public FMOD.RESULT getDriver(out int driver)
- public FMOD.RESULT getDriverInfo(int id, out string name, int namelen, out System.Guid guid, out int systemrate, out FMOD.SPEAKERMODE speakermode, out int speakermodechannels)
- public FMOD.RESULT getDriverInfo(int id, out System.Guid guid, out int systemrate, out FMOD.SPEAKERMODE speakermode, out int speakermodechannels)
- public FMOD.RESULT getDSPBufferSize(out uint bufferlength, out int numbuffers)
- public FMOD.RESULT getDSPInfoByPlugin(uint handle, out System.IntPtr description)
- public FMOD.RESULT getDSPInfoByType(FMOD.DSP_TYPE type, out System.IntPtr description)
- public FMOD.RESULT getFileUsage(out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead)
- public FMOD.RESULT getGeometryOcclusion(ref FMOD.VECTOR listener, ref FMOD.VECTOR source, out float direct, out float reverb)
- public FMOD.RESULT getGeometrySettings(out float maxworldsize)
- public FMOD.RESULT getMasterChannelGroup(out FMOD.ChannelGroup channelgroup)
- public FMOD.RESULT getMasterSoundGroup(out FMOD.SoundGroup soundgroup)
- public FMOD.RESULT getNestedPlugin(uint handle, int index, out uint nestedhandle)
- public FMOD.RESULT getNetworkProxy(out string proxy, int proxylen)
- public FMOD.RESULT getNetworkTimeout(out int timeout)
- public FMOD.RESULT getNumDrivers(out int numdrivers)
- public FMOD.RESULT getNumNestedPlugins(uint handle, out int count)
- public FMOD.RESULT getNumPlugins(FMOD.PLUGINTYPE plugintype, out int numplugins)
- public FMOD.RESULT getOutput(out FMOD.OUTPUTTYPE output)
- public FMOD.RESULT getOutputByPlugin(out uint handle)
- public FMOD.RESULT getOutputHandle(out System.IntPtr handle)
- public FMOD.RESULT getPluginHandle(FMOD.PLUGINTYPE plugintype, int index, out uint handle)
- public FMOD.RESULT getPluginInfo(uint handle, out FMOD.PLUGINTYPE plugintype, out string name, int namelen, out uint version)
- public FMOD.RESULT getPluginInfo(uint handle, out FMOD.PLUGINTYPE plugintype, out uint version)
- public FMOD.RESULT getRecordDriverInfo(int id, out string name, int namelen, out System.Guid guid, out int systemrate, out FMOD.SPEAKERMODE speakermode, out int speakermodechannels, out FMOD.DRIVER_STATE state)
- public FMOD.RESULT getRecordDriverInfo(int id, out System.Guid guid, out int systemrate, out FMOD.SPEAKERMODE speakermode, out int speakermodechannels, out FMOD.DRIVER_STATE state)
- public FMOD.RESULT getRecordNumDrivers(out int numdrivers, out int numconnected)
- public FMOD.RESULT getRecordPosition(int id, out uint position)
- public FMOD.RESULT getReverbProperties(int instance, out FMOD.REVERB_PROPERTIES prop)
- public FMOD.RESULT getSoftwareChannels(out int numsoftwarechannels)
- public FMOD.RESULT getSoftwareFormat(out int samplerate, out FMOD.SPEAKERMODE speakermode, out int numrawspeakers)
- public FMOD.RESULT getSpeakerModeChannels(FMOD.SPEAKERMODE mode, out int channels)
- public FMOD.RESULT getSpeakerPosition(FMOD.SPEAKER speaker, out float x, out float y, out bool active)
- public FMOD.RESULT getStreamBufferSize(out uint filebuffersize, out FMOD.TIMEUNIT filebuffersizetype)
- public FMOD.RESULT getUserData(out System.IntPtr userdata)
- public FMOD.RESULT getVersion(out uint version)
- public bool hasHandle()
- public FMOD.RESULT init(int maxchannels, FMOD.INITFLAGS flags, System.IntPtr extradriverdata)
- public FMOD.RESULT isRecording(int id, out bool recording)
- public FMOD.RESULT loadGeometry(System.IntPtr data, int datasize, out FMOD.Geometry geometry)
- public FMOD.RESULT loadPlugin(string filename, out uint handle, uint priority = 0)
- public FMOD.RESULT lockDSP()
- public FMOD.RESULT mixerResume()
- public FMOD.RESULT mixerSuspend()
- public FMOD.RESULT playDSP(FMOD.DSP dsp, FMOD.ChannelGroup channelgroup, bool paused, out FMOD.Channel channel)
- public FMOD.RESULT playSound(FMOD.Sound sound, FMOD.ChannelGroup channelgroup, bool paused, out FMOD.Channel channel)
- public FMOD.RESULT recordStart(int id, FMOD.Sound sound, bool loop)
- public FMOD.RESULT recordStop(int id)
- public FMOD.RESULT registerDSP(ref FMOD.DSP_DESCRIPTION description, out uint handle)
- public FMOD.RESULT release()
- public FMOD.RESULT set3DListenerAttributes(int listener, ref FMOD.VECTOR pos, ref FMOD.VECTOR vel, ref FMOD.VECTOR forward, ref FMOD.VECTOR up)
- public FMOD.RESULT set3DNumListeners(int numlisteners)
- public FMOD.RESULT set3DRolloffCallback(FMOD.CB_3D_ROLLOFF_CALLBACK callback)
- public FMOD.RESULT set3DSettings(float dopplerscale, float distancefactor, float rolloffscale)
- public FMOD.RESULT setAdvancedSettings(ref FMOD.ADVANCEDSETTINGS settings)
- public FMOD.RESULT setCallback(FMOD.SYSTEM_CALLBACK callback, FMOD.SYSTEM_CALLBACK_TYPE callbackmask = ALL)
- public FMOD.RESULT setDriver(int driver)
- public FMOD.RESULT setDSPBufferSize(uint bufferlength, int numbuffers)
- public FMOD.RESULT setFileSystem(FMOD.FILE_OPEN_CALLBACK useropen, FMOD.FILE_CLOSE_CALLBACK userclose, FMOD.FILE_READ_CALLBACK userread, FMOD.FILE_SEEK_CALLBACK userseek, FMOD.FILE_ASYNCREAD_CALLBACK userasyncread, FMOD.FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign)
- public FMOD.RESULT setGeometrySettings(float maxworldsize)
- public FMOD.RESULT setNetworkProxy(string proxy)
- public FMOD.RESULT setNetworkTimeout(int timeout)
- public FMOD.RESULT setOutput(FMOD.OUTPUTTYPE output)
- public FMOD.RESULT setOutputByPlugin(uint handle)
- public FMOD.RESULT setPluginPath(string path)
- public FMOD.RESULT setReverbProperties(int instance, ref FMOD.REVERB_PROPERTIES prop)
- public FMOD.RESULT setSoftwareChannels(int numsoftwarechannels)
- public FMOD.RESULT setSoftwareFormat(int samplerate, FMOD.SPEAKERMODE speakermode, int numrawspeakers)
- public FMOD.RESULT setSpeakerPosition(FMOD.SPEAKER speaker, float x, float y, bool active)
- public FMOD.RESULT setStreamBufferSize(uint filebuffersize, FMOD.TIMEUNIT filebuffersizetype)
- public FMOD.RESULT setUserData(System.IntPtr userdata)
- public FMOD.RESULT unloadPlugin(uint handle)
- public FMOD.RESULT unlockDSP()
- public FMOD.RESULT update()

### public delegate FMOD.SYSTEM_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public SYSTEM_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr system, FMOD.SYSTEM_CALLBACK_TYPE type, System.IntPtr commanddata1, System.IntPtr commanddata2, System.IntPtr userdata, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(System.IntPtr system, FMOD.SYSTEM_CALLBACK_TYPE type, System.IntPtr commanddata1, System.IntPtr commanddata2, System.IntPtr userdata)

### public enum FMOD.SYSTEM_CALLBACK_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ALL = 4294967295
- BADDSPCONNECTION = 16
- BUFFEREDNOMIX = 8192
- DEVICELISTCHANGED = 1
- DEVICELOST = 2
- DEVICEREINITIALIZE = 16384
- ERROR = 128
- MEMORYALLOCATIONFAILED = 4
- MIDMIX = 256
- OUTPUTUNDERRUN = 32768
- POSTMIX = 64
- POSTUPDATE = 2048
- PREMIX = 32
- PREUPDATE = 1024
- RECORDLISTCHANGED = 4096
- RECORDPOSITIONCHANGED = 65536
- THREADCREATED = 8
- THREADDESTROYED = 512

### public struct FMOD.TAG

#### Fields
- public System.IntPtr data
- public uint datalen
- public FMOD.TAGDATATYPE datatype
- public FMOD.StringWrapper name
- public FMOD.TAGTYPE type
- public bool updated

### public enum FMOD.TAGDATATYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BINARY = 0
- FLOAT = 2
- INT = 1
- MAX = 7
- STRING = 3
- STRING_UTF16 = 4
- STRING_UTF16BE = 5
- STRING_UTF8 = 6

### public enum FMOD.TAGTYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ASF = 6
- FMOD = 9
- ICECAST = 5
- ID3V1 = 1
- ID3V2 = 2
- MAX = 11
- MIDI = 7
- PLAYLIST = 8
- SHOUTCAST = 4
- UNKNOWN = 0
- USER = 10
- VORBISCOMMENT = 3

### public struct FMOD.Thread

#### Methods
- private static FMOD.RESULT FMOD5_Thread_SetAttributes(FMOD.THREAD_TYPE type, FMOD.THREAD_AFFINITY affinity, FMOD.THREAD_PRIORITY priority, FMOD.THREAD_STACK_SIZE stacksize)
- public static FMOD.RESULT SetAttributes(FMOD.THREAD_TYPE type, FMOD.THREAD_AFFINITY affinity = GROUP_DEFAULT, FMOD.THREAD_PRIORITY priority = DEFAULT, FMOD.THREAD_STACK_SIZE stacksize = DEFAULT)

### public class FMOD.StringHelper.ThreadSafeEncoding
- Interfaces: System.IDisposable

#### Fields
- private char[] decodedBuffer
- private byte[] encodedBuffer
- private System.Text.UTF8Encoding encoding
- private System.Runtime.InteropServices.GCHandle gcHandle
- private bool inUse

#### Constructors
- public StringHelper.ThreadSafeEncoding()

#### Methods
- public byte[] byteFromStringUTF8(string s)
- public void Dispose()
- public System.IntPtr intptrFromStringUTF8(string s)
- public bool InUse()
- private int roundUpPowerTwo(int number)
- public void SetInUse()
- public string stringFromNative(System.IntPtr nativePtr)

### public enum FMOD.THREAD_AFFINITY
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CONVOLUTION1 = 4611686018427387907
- CONVOLUTION2 = 4611686018427387907
- CORE_0 = 1
- CORE_1 = 2
- CORE_10 = 1024
- CORE_11 = 2048
- CORE_12 = 4096
- CORE_13 = 8192
- CORE_14 = 16384
- CORE_15 = 32768
- CORE_2 = 4
- CORE_3 = 8
- CORE_4 = 16
- CORE_5 = 32
- CORE_6 = 64
- CORE_7 = 128
- CORE_8 = 256
- CORE_9 = 512
- CORE_ALL = 0
- FEEDER = 4611686018427387907
- FILE = 4611686018427387907
- GEOMETRY = 4611686018427387907
- GROUP_A = 4611686018427387905
- GROUP_B = 4611686018427387906
- GROUP_C = 4611686018427387907
- GROUP_DEFAULT = 4611686018427387904
- MIXER = 4611686018427387905
- NONBLOCKING = 4611686018427387907
- PROFILER = 4611686018427387907
- RECORD = 4611686018427387907
- STREAM = 4611686018427387907
- STUDIO_LOAD_BANK = 4611686018427387907
- STUDIO_LOAD_SAMPLE = 4611686018427387907
- STUDIO_UPDATE = 4611686018427387906

### public enum FMOD.THREAD_PRIORITY
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CONVOLUTION1 = -32773
- CONVOLUTION2 = -32773
- CRITICAL = -32775
- DEFAULT = -32769
- EXTREME = -32774
- FEEDER = -32775
- FILE = -32772
- GEOMETRY = -32770
- HIGH = -32772
- LOW = -32770
- MEDIUM = -32771
- MIXER = -32774
- NONBLOCKING = -32772
- PLATFORM_MAX = 32768
- PLATFORM_MIN = -32768
- PROFILER = -32771
- RECORD = -32772
- STREAM = -32773
- STUDIO_LOAD_BANK = -32771
- STUDIO_LOAD_SAMPLE = -32771
- STUDIO_UPDATE = -32771
- VERY_HIGH = -32773

### public enum FMOD.THREAD_STACK_SIZE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CONVOLUTION1 = 16384
- CONVOLUTION2 = 16384
- DEFAULT = 0
- FEEDER = 16384
- FILE = 65536
- GEOMETRY = 49152
- MIXER = 81920
- NONBLOCKING = 114688
- PROFILER = 131072
- RECORD = 16384
- STREAM = 98304
- STUDIO_LOAD_BANK = 98304
- STUDIO_LOAD_SAMPLE = 98304
- STUDIO_UPDATE = 98304

### public enum FMOD.THREAD_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CONVOLUTION1 = 11
- CONVOLUTION2 = 12
- FEEDER = 1
- FILE = 3
- GEOMETRY = 6
- MAX = 13
- MIXER = 0
- NONBLOCKING = 4
- PROFILER = 7
- RECORD = 5
- STREAM = 2
- STUDIO_LOAD_BANK = 9
- STUDIO_LOAD_SAMPLE = 10
- STUDIO_UPDATE = 8

### public enum FMOD.TIMEUNIT
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- MODORDER = 256
- MODPATTERN = 1024
- MODROW = 512
- MS = 1
- PCM = 2
- PCMBYTES = 4
- PCMFRACTION = 16
- RAWBYTES = 8

### public struct FMOD.VECTOR

#### Fields
- public float x
- public float y
- public float z

### public class FMOD.VERSION

#### Fields
- public static const string dll
- public static const string dllSuffix
- public static const int number

#### Constructors
- public VERSION()

## Namespace: FMOD.Studio

### public struct FMOD.Studio.ADVANCEDSETTINGS

#### Fields
- public int cbsize
- public int commandqueuesize
- public System.IntPtr encryptionkey
- public int handleinitialsize
- public int idlesampledatapoolsize
- public int streamingscheduledelay
- public int studioupdateperiod

### public struct FMOD.Studio.Bank

#### Fields
- public System.IntPtr handle

#### Constructors
- public Bank(System.IntPtr ptr)

#### Methods
- public void clearHandle()
- private static FMOD.RESULT FMOD_Studio_Bank_GetBusCount(System.IntPtr bank, out int count)
- private static FMOD.RESULT FMOD_Studio_Bank_GetBusList(System.IntPtr bank, System.IntPtr[] array, int capacity, out int count)
- private static FMOD.RESULT FMOD_Studio_Bank_GetEventCount(System.IntPtr bank, out int count)
- private static FMOD.RESULT FMOD_Studio_Bank_GetEventList(System.IntPtr bank, System.IntPtr[] array, int capacity, out int count)
- private static FMOD.RESULT FMOD_Studio_Bank_GetID(System.IntPtr bank, out FMOD.GUID id)
- private static FMOD.RESULT FMOD_Studio_Bank_GetLoadingState(System.IntPtr bank, out FMOD.Studio.LOADING_STATE state)
- private static FMOD.RESULT FMOD_Studio_Bank_GetPath(System.IntPtr bank, System.IntPtr path, int size, out int retrieved)
- private static FMOD.RESULT FMOD_Studio_Bank_GetSampleLoadingState(System.IntPtr bank, out FMOD.Studio.LOADING_STATE state)
- private static FMOD.RESULT FMOD_Studio_Bank_GetStringCount(System.IntPtr bank, out int count)
- private static FMOD.RESULT FMOD_Studio_Bank_GetStringInfo(System.IntPtr bank, int index, out FMOD.GUID id, System.IntPtr path, int size, out int retrieved)
- private static FMOD.RESULT FMOD_Studio_Bank_GetUserData(System.IntPtr bank, out System.IntPtr userdata)
- private static FMOD.RESULT FMOD_Studio_Bank_GetVCACount(System.IntPtr bank, out int count)
- private static FMOD.RESULT FMOD_Studio_Bank_GetVCAList(System.IntPtr bank, System.IntPtr[] array, int capacity, out int count)
- private static bool FMOD_Studio_Bank_IsValid(System.IntPtr bank)
- private static FMOD.RESULT FMOD_Studio_Bank_LoadSampleData(System.IntPtr bank)
- private static FMOD.RESULT FMOD_Studio_Bank_SetUserData(System.IntPtr bank, System.IntPtr userdata)
- private static FMOD.RESULT FMOD_Studio_Bank_Unload(System.IntPtr bank)
- private static FMOD.RESULT FMOD_Studio_Bank_UnloadSampleData(System.IntPtr bank)
- public FMOD.RESULT getBusCount(out int count)
- public FMOD.RESULT getBusList(out FMOD.Studio.Bus[] array)
- public FMOD.RESULT getEventCount(out int count)
- public FMOD.RESULT getEventList(out FMOD.Studio.EventDescription[] array)
- public FMOD.RESULT getID(out FMOD.GUID id)
- public FMOD.RESULT getLoadingState(out FMOD.Studio.LOADING_STATE state)
- public FMOD.RESULT getPath(out string path)
- public FMOD.RESULT getSampleLoadingState(out FMOD.Studio.LOADING_STATE state)
- public FMOD.RESULT getStringCount(out int count)
- public FMOD.RESULT getStringInfo(int index, out FMOD.GUID id, out string path)
- public FMOD.RESULT getUserData(out System.IntPtr userdata)
- public FMOD.RESULT getVCACount(out int count)
- public FMOD.RESULT getVCAList(out FMOD.Studio.VCA[] array)
- public bool hasHandle()
- public bool isValid()
- public FMOD.RESULT loadSampleData()
- public FMOD.RESULT setUserData(System.IntPtr userdata)
- public FMOD.RESULT unload()
- public FMOD.RESULT unloadSampleData()

### public struct FMOD.Studio.BANK_INFO

#### Fields
- public FMOD.FILE_CLOSE_CALLBACK closecallback
- public FMOD.FILE_OPEN_CALLBACK opencallback
- public FMOD.FILE_READ_CALLBACK readcallback
- public FMOD.FILE_SEEK_CALLBACK seekcallback
- public int size
- public System.IntPtr userdata
- public int userdatalength

### public struct FMOD.Studio.BUFFER_INFO

#### Fields
- public int capacity
- public int currentusage
- public int peakusage
- public int stallcount
- public float stalltime

### public struct FMOD.Studio.BUFFER_USAGE

#### Fields
- public FMOD.Studio.BUFFER_INFO studiocommandqueue
- public FMOD.Studio.BUFFER_INFO studiohandle

### public struct FMOD.Studio.Bus

#### Fields
- public System.IntPtr handle

#### Constructors
- public Bus(System.IntPtr ptr)

#### Methods
- public void clearHandle()
- private static FMOD.RESULT FMOD_Studio_Bus_GetChannelGroup(System.IntPtr bus, out System.IntPtr group)
- private static FMOD.RESULT FMOD_Studio_Bus_GetCPUUsage(System.IntPtr bus, out uint exclusive, out uint inclusive)
- private static FMOD.RESULT FMOD_Studio_Bus_GetID(System.IntPtr bus, out FMOD.GUID id)
- private static FMOD.RESULT FMOD_Studio_Bus_GetMemoryUsage(System.IntPtr bus, out FMOD.Studio.MEMORY_USAGE memoryusage)
- private static FMOD.RESULT FMOD_Studio_Bus_GetMute(System.IntPtr bus, out bool mute)
- private static FMOD.RESULT FMOD_Studio_Bus_GetPath(System.IntPtr bus, System.IntPtr path, int size, out int retrieved)
- private static FMOD.RESULT FMOD_Studio_Bus_GetPaused(System.IntPtr bus, out bool paused)
- private static FMOD.RESULT FMOD_Studio_Bus_GetPortIndex(System.IntPtr bus, out ulong index)
- private static FMOD.RESULT FMOD_Studio_Bus_GetVolume(System.IntPtr bus, out float volume, out float finalvolume)
- private static bool FMOD_Studio_Bus_IsValid(System.IntPtr bus)
- private static FMOD.RESULT FMOD_Studio_Bus_LockChannelGroup(System.IntPtr bus)
- private static FMOD.RESULT FMOD_Studio_Bus_SetMute(System.IntPtr bus, bool mute)
- private static FMOD.RESULT FMOD_Studio_Bus_SetPaused(System.IntPtr bus, bool paused)
- private static FMOD.RESULT FMOD_Studio_Bus_SetPortIndex(System.IntPtr bus, ulong index)
- private static FMOD.RESULT FMOD_Studio_Bus_SetVolume(System.IntPtr bus, float volume)
- private static FMOD.RESULT FMOD_Studio_Bus_StopAllEvents(System.IntPtr bus, FMOD.Studio.STOP_MODE mode)
- private static FMOD.RESULT FMOD_Studio_Bus_UnlockChannelGroup(System.IntPtr bus)
- public FMOD.RESULT getChannelGroup(out FMOD.ChannelGroup group)
- public FMOD.RESULT getCPUUsage(out uint exclusive, out uint inclusive)
- public FMOD.RESULT getID(out FMOD.GUID id)
- public FMOD.RESULT getMemoryUsage(out FMOD.Studio.MEMORY_USAGE memoryusage)
- public FMOD.RESULT getMute(out bool mute)
- public FMOD.RESULT getPath(out string path)
- public FMOD.RESULT getPaused(out bool paused)
- public FMOD.RESULT getPortIndex(out ulong index)
- public FMOD.RESULT getVolume(out float volume)
- public FMOD.RESULT getVolume(out float volume, out float finalvolume)
- public bool hasHandle()
- public bool isValid()
- public FMOD.RESULT lockChannelGroup()
- public FMOD.RESULT setMute(bool mute)
- public FMOD.RESULT setPaused(bool paused)
- public FMOD.RESULT setPortIndex(ulong index)
- public FMOD.RESULT setVolume(float volume)
- public FMOD.RESULT stopAllEvents(FMOD.Studio.STOP_MODE mode)
- public FMOD.RESULT unlockChannelGroup()

### public enum FMOD.Studio.COMMANDCAPTURE_FLAGS
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FILEFLUSH = 1
- NORMAL = 0
- SKIP_INITIAL_STATE = 2

### public struct FMOD.Studio.CommandReplay

#### Fields
- public System.IntPtr handle

#### Constructors
- public CommandReplay(System.IntPtr ptr)

#### Methods
- public void clearHandle()
- private static FMOD.RESULT FMOD_Studio_CommandReplay_GetCommandAtTime(System.IntPtr replay, float time, out int commandIndex)
- private static FMOD.RESULT FMOD_Studio_CommandReplay_GetCommandCount(System.IntPtr replay, out int count)
- private static FMOD.RESULT FMOD_Studio_CommandReplay_GetCommandInfo(System.IntPtr replay, int commandindex, out FMOD.Studio.COMMAND_INFO info)
- private static FMOD.RESULT FMOD_Studio_CommandReplay_GetCommandString(System.IntPtr replay, int commandIndex, System.IntPtr buffer, int length)
- private static FMOD.RESULT FMOD_Studio_CommandReplay_GetCurrentCommand(System.IntPtr replay, out int commandIndex, out float currentTime)
- private static FMOD.RESULT FMOD_Studio_CommandReplay_GetLength(System.IntPtr replay, out float length)
- private static FMOD.RESULT FMOD_Studio_CommandReplay_GetPaused(System.IntPtr replay, out bool paused)
- private static FMOD.RESULT FMOD_Studio_CommandReplay_GetPlaybackState(System.IntPtr replay, out FMOD.Studio.PLAYBACK_STATE state)
- private static FMOD.RESULT FMOD_Studio_CommandReplay_GetSystem(System.IntPtr replay, out System.IntPtr system)
- private static FMOD.RESULT FMOD_Studio_CommandReplay_GetUserData(System.IntPtr replay, out System.IntPtr userdata)
- private static bool FMOD_Studio_CommandReplay_IsValid(System.IntPtr replay)
- private static FMOD.RESULT FMOD_Studio_CommandReplay_Release(System.IntPtr replay)
- private static FMOD.RESULT FMOD_Studio_CommandReplay_SeekToCommand(System.IntPtr replay, int commandIndex)
- private static FMOD.RESULT FMOD_Studio_CommandReplay_SeekToTime(System.IntPtr replay, float time)
- private static FMOD.RESULT FMOD_Studio_CommandReplay_SetBankPath(System.IntPtr replay, byte[] bankPath)
- private static FMOD.RESULT FMOD_Studio_CommandReplay_SetCreateInstanceCallback(System.IntPtr replay, FMOD.Studio.COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback)
- private static FMOD.RESULT FMOD_Studio_CommandReplay_SetFrameCallback(System.IntPtr replay, FMOD.Studio.COMMANDREPLAY_FRAME_CALLBACK callback)
- private static FMOD.RESULT FMOD_Studio_CommandReplay_SetLoadBankCallback(System.IntPtr replay, FMOD.Studio.COMMANDREPLAY_LOAD_BANK_CALLBACK callback)
- private static FMOD.RESULT FMOD_Studio_CommandReplay_SetPaused(System.IntPtr replay, bool paused)
- private static FMOD.RESULT FMOD_Studio_CommandReplay_SetUserData(System.IntPtr replay, System.IntPtr userdata)
- private static FMOD.RESULT FMOD_Studio_CommandReplay_Start(System.IntPtr replay)
- private static FMOD.RESULT FMOD_Studio_CommandReplay_Stop(System.IntPtr replay)
- public FMOD.RESULT getCommandAtTime(float time, out int commandIndex)
- public FMOD.RESULT getCommandCount(out int count)
- public FMOD.RESULT getCommandInfo(int commandIndex, out FMOD.Studio.COMMAND_INFO info)
- public FMOD.RESULT getCommandString(int commandIndex, out string buffer)
- public FMOD.RESULT getCurrentCommand(out int commandIndex, out float currentTime)
- public FMOD.RESULT getLength(out float length)
- public FMOD.RESULT getPaused(out bool paused)
- public FMOD.RESULT getPlaybackState(out FMOD.Studio.PLAYBACK_STATE state)
- public FMOD.RESULT getSystem(out FMOD.Studio.System system)
- public FMOD.RESULT getUserData(out System.IntPtr userdata)
- public bool hasHandle()
- public bool isValid()
- public FMOD.RESULT release()
- public FMOD.RESULT seekToCommand(int commandIndex)
- public FMOD.RESULT seekToTime(float time)
- public FMOD.RESULT setBankPath(string bankPath)
- public FMOD.RESULT setCreateInstanceCallback(FMOD.Studio.COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback)
- public FMOD.RESULT setFrameCallback(FMOD.Studio.COMMANDREPLAY_FRAME_CALLBACK callback)
- public FMOD.RESULT setLoadBankCallback(FMOD.Studio.COMMANDREPLAY_LOAD_BANK_CALLBACK callback)
- public FMOD.RESULT setPaused(bool paused)
- public FMOD.RESULT setUserData(System.IntPtr userdata)
- public FMOD.RESULT start()
- public FMOD.RESULT stop()

### public delegate FMOD.Studio.COMMANDREPLAY_CREATE_INSTANCE_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public COMMANDREPLAY_CREATE_INSTANCE_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr replay, int commandindex, System.IntPtr eventdescription, out System.IntPtr instance, System.IntPtr userdata, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(out System.IntPtr instance, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(System.IntPtr replay, int commandindex, System.IntPtr eventdescription, out System.IntPtr instance, System.IntPtr userdata)

### public enum FMOD.Studio.COMMANDREPLAY_FLAGS
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FAST_FORWARD = 2
- NORMAL = 0
- SKIP_BANK_LOAD = 4
- SKIP_CLEANUP = 1

### public delegate FMOD.Studio.COMMANDREPLAY_FRAME_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public COMMANDREPLAY_FRAME_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr replay, int commandindex, float currenttime, System.IntPtr userdata, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(System.IntPtr replay, int commandindex, float currenttime, System.IntPtr userdata)

### public delegate FMOD.Studio.COMMANDREPLAY_LOAD_BANK_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public COMMANDREPLAY_LOAD_BANK_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr replay, int commandindex, FMOD.GUID bankguid, System.IntPtr bankfilename, FMOD.Studio.LOAD_BANK_FLAGS flags, out System.IntPtr bank, System.IntPtr userdata, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(out System.IntPtr bank, System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(System.IntPtr replay, int commandindex, FMOD.GUID bankguid, System.IntPtr bankfilename, FMOD.Studio.LOAD_BANK_FLAGS flags, out System.IntPtr bank, System.IntPtr userdata)

### public struct FMOD.Studio.COMMAND_INFO

#### Fields
- public FMOD.StringWrapper commandname
- public int framenumber
- public float frametime
- public uint instancehandle
- public FMOD.Studio.INSTANCETYPE instancetype
- public uint outputhandle
- public FMOD.Studio.INSTANCETYPE outputtype
- public int parentcommandindex

### public struct FMOD.Studio.CPU_USAGE

#### Fields
- public float update

### public struct FMOD.Studio.EventDescription

#### Fields
- public System.IntPtr handle

#### Constructors
- public EventDescription(System.IntPtr ptr)

#### Methods
- public void clearHandle()
- public FMOD.RESULT createInstance(out FMOD.Studio.EventInstance instance)
- private static FMOD.RESULT FMOD_Studio_EventDescription_CreateInstance(System.IntPtr eventdescription, out System.IntPtr instance)
- private static FMOD.RESULT FMOD_Studio_EventDescription_GetID(System.IntPtr eventdescription, out FMOD.GUID id)
- private static FMOD.RESULT FMOD_Studio_EventDescription_GetInstanceCount(System.IntPtr eventdescription, out int count)
- private static FMOD.RESULT FMOD_Studio_EventDescription_GetInstanceList(System.IntPtr eventdescription, System.IntPtr[] array, int capacity, out int count)
- private static FMOD.RESULT FMOD_Studio_EventDescription_GetLength(System.IntPtr eventdescription, out int length)
- private static FMOD.RESULT FMOD_Studio_EventDescription_GetMinMaxDistance(System.IntPtr eventdescription, out float min, out float max)
- private static FMOD.RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByID(System.IntPtr eventdescription, FMOD.Studio.PARAMETER_ID id, out FMOD.Studio.PARAMETER_DESCRIPTION parameter)
- private static FMOD.RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByIndex(System.IntPtr eventdescription, int index, out FMOD.Studio.PARAMETER_DESCRIPTION parameter)
- private static FMOD.RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByName(System.IntPtr eventdescription, byte[] name, out FMOD.Studio.PARAMETER_DESCRIPTION parameter)
- private static FMOD.RESULT FMOD_Studio_EventDescription_GetParameterDescriptionCount(System.IntPtr eventdescription, out int count)
- private static FMOD.RESULT FMOD_Studio_EventDescription_GetParameterLabelByID(System.IntPtr eventdescription, FMOD.Studio.PARAMETER_ID id, int labelindex, System.IntPtr label, int size, out int retrieved)
- private static FMOD.RESULT FMOD_Studio_EventDescription_GetParameterLabelByIndex(System.IntPtr eventdescription, int index, int labelindex, System.IntPtr label, int size, out int retrieved)
- private static FMOD.RESULT FMOD_Studio_EventDescription_GetParameterLabelByName(System.IntPtr eventdescription, byte[] name, int labelindex, System.IntPtr label, int size, out int retrieved)
- private static FMOD.RESULT FMOD_Studio_EventDescription_GetPath(System.IntPtr eventdescription, System.IntPtr path, int size, out int retrieved)
- private static FMOD.RESULT FMOD_Studio_EventDescription_GetSampleLoadingState(System.IntPtr eventdescription, out FMOD.Studio.LOADING_STATE state)
- private static FMOD.RESULT FMOD_Studio_EventDescription_GetSoundSize(System.IntPtr eventdescription, out float size)
- private static FMOD.RESULT FMOD_Studio_EventDescription_GetUserData(System.IntPtr eventdescription, out System.IntPtr userdata)
- private static FMOD.RESULT FMOD_Studio_EventDescription_GetUserProperty(System.IntPtr eventdescription, byte[] name, out FMOD.Studio.USER_PROPERTY property)
- private static FMOD.RESULT FMOD_Studio_EventDescription_GetUserPropertyByIndex(System.IntPtr eventdescription, int index, out FMOD.Studio.USER_PROPERTY property)
- private static FMOD.RESULT FMOD_Studio_EventDescription_GetUserPropertyCount(System.IntPtr eventdescription, out int count)
- private static FMOD.RESULT FMOD_Studio_EventDescription_HasSustainPoint(System.IntPtr eventdescription, out bool sustainPoint)
- private static FMOD.RESULT FMOD_Studio_EventDescription_Is3D(System.IntPtr eventdescription, out bool is3D)
- private static FMOD.RESULT FMOD_Studio_EventDescription_IsDopplerEnabled(System.IntPtr eventdescription, out bool doppler)
- private static FMOD.RESULT FMOD_Studio_EventDescription_IsOneshot(System.IntPtr eventdescription, out bool oneshot)
- private static FMOD.RESULT FMOD_Studio_EventDescription_IsSnapshot(System.IntPtr eventdescription, out bool snapshot)
- private static FMOD.RESULT FMOD_Studio_EventDescription_IsStream(System.IntPtr eventdescription, out bool isStream)
- private static bool FMOD_Studio_EventDescription_IsValid(System.IntPtr eventdescription)
- private static FMOD.RESULT FMOD_Studio_EventDescription_LoadSampleData(System.IntPtr eventdescription)
- private static FMOD.RESULT FMOD_Studio_EventDescription_ReleaseAllInstances(System.IntPtr eventdescription)
- private static FMOD.RESULT FMOD_Studio_EventDescription_SetCallback(System.IntPtr eventdescription, FMOD.Studio.EVENT_CALLBACK callback, FMOD.Studio.EVENT_CALLBACK_TYPE callbackmask)
- private static FMOD.RESULT FMOD_Studio_EventDescription_SetUserData(System.IntPtr eventdescription, System.IntPtr userdata)
- private static FMOD.RESULT FMOD_Studio_EventDescription_UnloadSampleData(System.IntPtr eventdescription)
- public FMOD.RESULT getID(out FMOD.GUID id)
- public FMOD.RESULT getInstanceCount(out int count)
- public FMOD.RESULT getInstanceList(out FMOD.Studio.EventInstance[] array)
- public FMOD.RESULT getLength(out int length)
- public FMOD.RESULT getMinMaxDistance(out float min, out float max)
- public FMOD.RESULT getParameterDescriptionByID(FMOD.Studio.PARAMETER_ID id, out FMOD.Studio.PARAMETER_DESCRIPTION parameter)
- public FMOD.RESULT getParameterDescriptionByIndex(int index, out FMOD.Studio.PARAMETER_DESCRIPTION parameter)
- public FMOD.RESULT getParameterDescriptionByName(string name, out FMOD.Studio.PARAMETER_DESCRIPTION parameter)
- public FMOD.RESULT getParameterDescriptionCount(out int count)
- public FMOD.RESULT getParameterLabelByID(FMOD.Studio.PARAMETER_ID id, int labelindex, out string label)
- public FMOD.RESULT getParameterLabelByIndex(int index, int labelindex, out string label)
- public FMOD.RESULT getParameterLabelByName(string name, int labelindex, out string label)
- public FMOD.RESULT getPath(out string path)
- public FMOD.RESULT getSampleLoadingState(out FMOD.Studio.LOADING_STATE state)
- public FMOD.RESULT getSoundSize(out float size)
- public FMOD.RESULT getUserData(out System.IntPtr userdata)
- public FMOD.RESULT getUserProperty(string name, out FMOD.Studio.USER_PROPERTY property)
- public FMOD.RESULT getUserPropertyByIndex(int index, out FMOD.Studio.USER_PROPERTY property)
- public FMOD.RESULT getUserPropertyCount(out int count)
- public bool hasHandle()
- public FMOD.RESULT hasSustainPoint(out bool sustainPoint)
- public FMOD.RESULT is3D(out bool is3D)
- public FMOD.RESULT isDopplerEnabled(out bool doppler)
- public FMOD.RESULT isOneshot(out bool oneshot)
- public FMOD.RESULT isSnapshot(out bool snapshot)
- public FMOD.RESULT isStream(out bool isStream)
- public bool isValid()
- public FMOD.RESULT loadSampleData()
- public FMOD.RESULT releaseAllInstances()
- public FMOD.RESULT setCallback(FMOD.Studio.EVENT_CALLBACK callback, FMOD.Studio.EVENT_CALLBACK_TYPE callbackmask = ALL)
- public FMOD.RESULT setUserData(System.IntPtr userdata)
- public FMOD.RESULT unloadSampleData()

### public struct FMOD.Studio.EventInstance

#### Fields
- public System.IntPtr handle

#### Constructors
- public EventInstance(System.IntPtr ptr)

#### Methods
- public void clearHandle()
- private static FMOD.RESULT FMOD_Studio_EventInstance_Get3DAttributes(System.IntPtr _event, out FMOD.ATTRIBUTES_3D attributes)
- private static FMOD.RESULT FMOD_Studio_EventInstance_GetChannelGroup(System.IntPtr _event, out System.IntPtr group)
- private static FMOD.RESULT FMOD_Studio_EventInstance_GetCPUUsage(System.IntPtr _event, out uint exclusive, out uint inclusive)
- private static FMOD.RESULT FMOD_Studio_EventInstance_GetDescription(System.IntPtr _event, out System.IntPtr description)
- private static FMOD.RESULT FMOD_Studio_EventInstance_GetListenerMask(System.IntPtr _event, out uint mask)
- private static FMOD.RESULT FMOD_Studio_EventInstance_GetMemoryUsage(System.IntPtr _event, out FMOD.Studio.MEMORY_USAGE memoryusage)
- private static FMOD.RESULT FMOD_Studio_EventInstance_GetMinMaxDistance(System.IntPtr _event, out float min, out float max)
- private static FMOD.RESULT FMOD_Studio_EventInstance_GetParameterByID(System.IntPtr _event, FMOD.Studio.PARAMETER_ID id, out float value, out float finalvalue)
- private static FMOD.RESULT FMOD_Studio_EventInstance_GetParameterByName(System.IntPtr _event, byte[] name, out float value, out float finalvalue)
- private static FMOD.RESULT FMOD_Studio_EventInstance_GetPaused(System.IntPtr _event, out bool paused)
- private static FMOD.RESULT FMOD_Studio_EventInstance_GetPitch(System.IntPtr _event, out float pitch, System.IntPtr zero)
- private static FMOD.RESULT FMOD_Studio_EventInstance_GetPitch(System.IntPtr _event, out float pitch, out float finalpitch)
- private static FMOD.RESULT FMOD_Studio_EventInstance_GetPlaybackState(System.IntPtr _event, out FMOD.Studio.PLAYBACK_STATE state)
- private static FMOD.RESULT FMOD_Studio_EventInstance_GetProperty(System.IntPtr _event, FMOD.Studio.EVENT_PROPERTY index, out float value)
- private static FMOD.RESULT FMOD_Studio_EventInstance_GetReverbLevel(System.IntPtr _event, int index, out float level)
- private static FMOD.RESULT FMOD_Studio_EventInstance_GetTimelinePosition(System.IntPtr _event, out int position)
- private static FMOD.RESULT FMOD_Studio_EventInstance_GetUserData(System.IntPtr _event, out System.IntPtr userdata)
- private static FMOD.RESULT FMOD_Studio_EventInstance_GetVolume(System.IntPtr _event, out float volume, System.IntPtr zero)
- private static FMOD.RESULT FMOD_Studio_EventInstance_GetVolume(System.IntPtr _event, out float volume, out float finalvolume)
- private static bool FMOD_Studio_EventInstance_IsValid(System.IntPtr _event)
- private static FMOD.RESULT FMOD_Studio_EventInstance_IsVirtual(System.IntPtr _event, out bool virtualstate)
- private static FMOD.RESULT FMOD_Studio_EventInstance_KeyOff(System.IntPtr _event)
- private static FMOD.RESULT FMOD_Studio_EventInstance_Release(System.IntPtr _event)
- private static FMOD.RESULT FMOD_Studio_EventInstance_Set3DAttributes(System.IntPtr _event, ref FMOD.ATTRIBUTES_3D attributes)
- private static FMOD.RESULT FMOD_Studio_EventInstance_SetCallback(System.IntPtr _event, FMOD.Studio.EVENT_CALLBACK callback, FMOD.Studio.EVENT_CALLBACK_TYPE callbackmask)
- private static FMOD.RESULT FMOD_Studio_EventInstance_SetListenerMask(System.IntPtr _event, uint mask)
- private static FMOD.RESULT FMOD_Studio_EventInstance_SetParameterByID(System.IntPtr _event, FMOD.Studio.PARAMETER_ID id, float value, bool ignoreseekspeed)
- private static FMOD.RESULT FMOD_Studio_EventInstance_SetParameterByIDWithLabel(System.IntPtr _event, FMOD.Studio.PARAMETER_ID id, byte[] label, bool ignoreseekspeed)
- private static FMOD.RESULT FMOD_Studio_EventInstance_SetParameterByName(System.IntPtr _event, byte[] name, float value, bool ignoreseekspeed)
- private static FMOD.RESULT FMOD_Studio_EventInstance_SetParameterByNameWithLabel(System.IntPtr _event, byte[] name, byte[] label, bool ignoreseekspeed)
- private static FMOD.RESULT FMOD_Studio_EventInstance_SetParametersByIDs(System.IntPtr _event, FMOD.Studio.PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed)
- private static FMOD.RESULT FMOD_Studio_EventInstance_SetPaused(System.IntPtr _event, bool paused)
- private static FMOD.RESULT FMOD_Studio_EventInstance_SetPitch(System.IntPtr _event, float pitch)
- private static FMOD.RESULT FMOD_Studio_EventInstance_SetProperty(System.IntPtr _event, FMOD.Studio.EVENT_PROPERTY index, float value)
- private static FMOD.RESULT FMOD_Studio_EventInstance_SetReverbLevel(System.IntPtr _event, int index, float level)
- private static FMOD.RESULT FMOD_Studio_EventInstance_SetTimelinePosition(System.IntPtr _event, int position)
- private static FMOD.RESULT FMOD_Studio_EventInstance_SetUserData(System.IntPtr _event, System.IntPtr userdata)
- private static FMOD.RESULT FMOD_Studio_EventInstance_SetVolume(System.IntPtr _event, float volume)
- private static FMOD.RESULT FMOD_Studio_EventInstance_Start(System.IntPtr _event)
- private static FMOD.RESULT FMOD_Studio_EventInstance_Stop(System.IntPtr _event, FMOD.Studio.STOP_MODE mode)
- public FMOD.RESULT get3DAttributes(out FMOD.ATTRIBUTES_3D attributes)
- public FMOD.RESULT getChannelGroup(out FMOD.ChannelGroup group)
- public FMOD.RESULT getCPUUsage(out uint exclusive, out uint inclusive)
- public FMOD.RESULT getDescription(out FMOD.Studio.EventDescription description)
- public FMOD.RESULT getListenerMask(out uint mask)
- public FMOD.RESULT getMemoryUsage(out FMOD.Studio.MEMORY_USAGE memoryusage)
- public FMOD.RESULT getMinMaxDistance(out float min, out float max)
- public FMOD.RESULT getParameterByID(FMOD.Studio.PARAMETER_ID id, out float value)
- public FMOD.RESULT getParameterByID(FMOD.Studio.PARAMETER_ID id, out float value, out float finalvalue)
- public FMOD.RESULT getParameterByName(string name, out float value)
- public FMOD.RESULT getParameterByName(string name, out float value, out float finalvalue)
- public FMOD.RESULT getPaused(out bool paused)
- public FMOD.RESULT getPitch(out float pitch)
- public FMOD.RESULT getPitch(out float pitch, out float finalpitch)
- public FMOD.RESULT getPlaybackState(out FMOD.Studio.PLAYBACK_STATE state)
- public FMOD.RESULT getProperty(FMOD.Studio.EVENT_PROPERTY index, out float value)
- public FMOD.RESULT getReverbLevel(int index, out float level)
- public FMOD.RESULT getTimelinePosition(out int position)
- public FMOD.RESULT getUserData(out System.IntPtr userdata)
- public FMOD.RESULT getVolume(out float volume)
- public FMOD.RESULT getVolume(out float volume, out float finalvolume)
- public bool hasHandle()
- public bool isValid()
- public FMOD.RESULT isVirtual(out bool virtualstate)
- public FMOD.RESULT keyOff()
- public FMOD.RESULT release()
- public FMOD.RESULT set3DAttributes(FMOD.ATTRIBUTES_3D attributes)
- public FMOD.RESULT setCallback(FMOD.Studio.EVENT_CALLBACK callback, FMOD.Studio.EVENT_CALLBACK_TYPE callbackmask = ALL)
- public FMOD.RESULT setListenerMask(uint mask)
- public FMOD.RESULT setParameterByID(FMOD.Studio.PARAMETER_ID id, float value, bool ignoreseekspeed = false)
- public FMOD.RESULT setParameterByIDWithLabel(FMOD.Studio.PARAMETER_ID id, string label, bool ignoreseekspeed = false)
- public FMOD.RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
- public FMOD.RESULT setParameterByNameWithLabel(string name, string label, bool ignoreseekspeed = false)
- public FMOD.RESULT setParametersByIDs(FMOD.Studio.PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false)
- public FMOD.RESULT setPaused(bool paused)
- public FMOD.RESULT setPitch(float pitch)
- public FMOD.RESULT setProperty(FMOD.Studio.EVENT_PROPERTY index, float value)
- public FMOD.RESULT setReverbLevel(int index, float level)
- public FMOD.RESULT setTimelinePosition(int position)
- public FMOD.RESULT setUserData(System.IntPtr userdata)
- public FMOD.RESULT setVolume(float volume)
- public FMOD.RESULT start()
- public FMOD.RESULT stop(FMOD.Studio.STOP_MODE mode)

### public delegate FMOD.Studio.EVENT_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public EVENT_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(FMOD.Studio.EVENT_CALLBACK_TYPE type, System.IntPtr _event, System.IntPtr parameters, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(FMOD.Studio.EVENT_CALLBACK_TYPE type, System.IntPtr _event, System.IntPtr parameters)

### public enum FMOD.Studio.EVENT_CALLBACK_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ALL = 4294967295
- CREATED = 1
- CREATE_PROGRAMMER_SOUND = 128
- DESTROYED = 2
- DESTROY_PROGRAMMER_SOUND = 256
- NESTED_TIMELINE_BEAT = 262144
- PLUGIN_CREATED = 512
- PLUGIN_DESTROYED = 1024
- REAL_TO_VIRTUAL = 32768
- RESTARTED = 16
- SOUND_PLAYED = 8192
- SOUND_STOPPED = 16384
- STARTED = 8
- STARTING = 4
- START_EVENT_COMMAND = 131072
- START_FAILED = 64
- STOPPED = 32
- TIMELINE_BEAT = 4096
- TIMELINE_MARKER = 2048
- VIRTUAL_TO_REAL = 65536

### public enum FMOD.Studio.EVENT_PROPERTY
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CHANNELPRIORITY = 0
- COOLDOWN = 5
- MAX = 6
- MAXIMUM_DISTANCE = 4
- MINIMUM_DISTANCE = 3
- SCHEDULE_DELAY = 1
- SCHEDULE_LOOKAHEAD = 2

### public enum FMOD.Studio.INITFLAGS
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ALLOW_MISSING_PLUGINS = 2
- DEFERRED_CALLBACKS = 8
- LIVEUPDATE = 1
- LOAD_FROM_UPDATE = 16
- MEMORY_TRACKING = 32
- NORMAL = 0
- SYNCHRONOUS_UPDATE = 4

### public enum FMOD.Studio.INSTANCETYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BANK = 7
- BUS = 5
- COMMANDREPLAY = 8
- EVENTDESCRIPTION = 2
- EVENTINSTANCE = 3
- NONE = 0
- PARAMETERINSTANCE = 4
- SYSTEM = 1
- VCA = 6

### public enum FMOD.Studio.LOADING_STATE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ERROR = 4
- LOADED = 3
- LOADING = 2
- UNLOADED = 1
- UNLOADING = 0

### public enum FMOD.Studio.LOAD_BANK_FLAGS
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DECOMPRESS_SAMPLES = 2
- NONBLOCKING = 1
- NORMAL = 0
- UNENCRYPTED = 4

### internal enum FMOD.Studio.LOAD_MEMORY_ALIGNMENT
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- VALUE = 32

### internal enum FMOD.Studio.LOAD_MEMORY_MODE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- LOAD_MEMORY = 0
- LOAD_MEMORY_POINT = 1

### public struct FMOD.Studio.MEMORY_USAGE

#### Fields
- public int exclusive
- public int inclusive
- public int sampledata

### public struct FMOD.Studio.PARAMETER_DESCRIPTION

#### Fields
- public float defaultvalue
- public FMOD.Studio.PARAMETER_FLAGS flags
- public FMOD.GUID guid
- public FMOD.Studio.PARAMETER_ID id
- public float maximum
- public float minimum
- public FMOD.StringWrapper name
- public FMOD.Studio.PARAMETER_TYPE type

### public enum FMOD.Studio.PARAMETER_FLAGS
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AUTOMATIC = 2
- DISCRETE = 8
- GLOBAL = 4
- LABELED = 16
- READONLY = 1

### public struct FMOD.Studio.PARAMETER_ID

#### Fields
- public uint data1
- public uint data2

### public enum FMOD.Studio.PARAMETER_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AUTOMATIC_DIRECTION = 4
- AUTOMATIC_DISTANCE = 1
- AUTOMATIC_DISTANCE_NORMALIZED = 9
- AUTOMATIC_ELEVATION = 5
- AUTOMATIC_EVENT_CONE_ANGLE = 2
- AUTOMATIC_EVENT_ORIENTATION = 3
- AUTOMATIC_LISTENER_ORIENTATION = 6
- AUTOMATIC_SPEED = 7
- AUTOMATIC_SPEED_ABSOLUTE = 8
- GAME_CONTROLLED = 0
- MAX = 10

### public enum FMOD.Studio.PLAYBACK_STATE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- PLAYING = 0
- STARTING = 3
- STOPPED = 2
- STOPPING = 4
- SUSTAINING = 1

### public struct FMOD.Studio.PLUGIN_INSTANCE_PROPERTIES

#### Fields
- public System.IntPtr dsp
- public System.IntPtr name

### public struct FMOD.Studio.PROGRAMMER_SOUND_PROPERTIES

#### Fields
- public FMOD.StringWrapper name
- public System.IntPtr sound
- public int subsoundIndex

### public struct FMOD.Studio.SOUND_INFO

#### Fields
- public FMOD.CREATESOUNDEXINFO exinfo
- public FMOD.MODE mode
- public System.IntPtr name_or_data
- public int subsoundindex

#### Properties
- public string name { get; }

### public enum FMOD.Studio.STOP_MODE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ALLOWFADEOUT = 0
- IMMEDIATE = 1

### public class FMOD.Studio.STUDIO_VERSION

#### Fields
- public static const string dll
- public static const string dllSuffix

#### Constructors
- public STUDIO_VERSION()

### public struct FMOD.Studio.System

#### Fields
- public System.IntPtr handle

#### Constructors
- public System(System.IntPtr ptr)

#### Methods
- public void clearHandle()
- public static FMOD.RESULT create(out FMOD.Studio.System system)
- public FMOD.RESULT flushCommands()
- public FMOD.RESULT flushSampleLoading()
- private static FMOD.RESULT FMOD_Studio_System_Create(out System.IntPtr system, uint headerversion)
- private static FMOD.RESULT FMOD_Studio_System_FlushCommands(System.IntPtr system)
- private static FMOD.RESULT FMOD_Studio_System_FlushSampleLoading(System.IntPtr system)
- private static FMOD.RESULT FMOD_Studio_System_GetAdvancedSettings(System.IntPtr system, out FMOD.Studio.ADVANCEDSETTINGS settings)
- private static FMOD.RESULT FMOD_Studio_System_GetBank(System.IntPtr system, byte[] path, out System.IntPtr bank)
- private static FMOD.RESULT FMOD_Studio_System_GetBankByID(System.IntPtr system, ref FMOD.GUID id, out System.IntPtr bank)
- private static FMOD.RESULT FMOD_Studio_System_GetBankCount(System.IntPtr system, out int count)
- private static FMOD.RESULT FMOD_Studio_System_GetBankList(System.IntPtr system, System.IntPtr[] array, int capacity, out int count)
- private static FMOD.RESULT FMOD_Studio_System_GetBufferUsage(System.IntPtr system, out FMOD.Studio.BUFFER_USAGE usage)
- private static FMOD.RESULT FMOD_Studio_System_GetBus(System.IntPtr system, byte[] path, out System.IntPtr bus)
- private static FMOD.RESULT FMOD_Studio_System_GetBusByID(System.IntPtr system, ref FMOD.GUID id, out System.IntPtr bus)
- private static FMOD.RESULT FMOD_Studio_System_GetCoreSystem(System.IntPtr system, out System.IntPtr coresystem)
- private static FMOD.RESULT FMOD_Studio_System_GetCPUUsage(System.IntPtr system, out FMOD.Studio.CPU_USAGE usage, out FMOD.CPU_USAGE usage_core)
- private static FMOD.RESULT FMOD_Studio_System_GetEvent(System.IntPtr system, byte[] path, out System.IntPtr _event)
- private static FMOD.RESULT FMOD_Studio_System_GetEventByID(System.IntPtr system, ref FMOD.GUID id, out System.IntPtr _event)
- private static FMOD.RESULT FMOD_Studio_System_GetListenerAttributes(System.IntPtr system, int listener, out FMOD.ATTRIBUTES_3D attributes, System.IntPtr zero)
- private static FMOD.RESULT FMOD_Studio_System_GetListenerAttributes(System.IntPtr system, int listener, out FMOD.ATTRIBUTES_3D attributes, out FMOD.VECTOR attenuationposition)
- private static FMOD.RESULT FMOD_Studio_System_GetListenerWeight(System.IntPtr system, int listener, out float weight)
- private static FMOD.RESULT FMOD_Studio_System_GetMemoryUsage(System.IntPtr system, out FMOD.Studio.MEMORY_USAGE memoryusage)
- private static FMOD.RESULT FMOD_Studio_System_GetNumListeners(System.IntPtr system, out int numlisteners)
- private static FMOD.RESULT FMOD_Studio_System_GetParameterByID(System.IntPtr system, FMOD.Studio.PARAMETER_ID id, out float value, out float finalvalue)
- private static FMOD.RESULT FMOD_Studio_System_GetParameterByName(System.IntPtr system, byte[] name, out float value, out float finalvalue)
- private static FMOD.RESULT FMOD_Studio_System_GetParameterDescriptionByID(System.IntPtr system, FMOD.Studio.PARAMETER_ID id, out FMOD.Studio.PARAMETER_DESCRIPTION parameter)
- private static FMOD.RESULT FMOD_Studio_System_GetParameterDescriptionByName(System.IntPtr system, byte[] name, out FMOD.Studio.PARAMETER_DESCRIPTION parameter)
- private static FMOD.RESULT FMOD_Studio_System_GetParameterDescriptionCount(System.IntPtr system, out int count)
- private static FMOD.RESULT FMOD_Studio_System_GetParameterDescriptionList(System.IntPtr system, FMOD.Studio.PARAMETER_DESCRIPTION[] array, int capacity, out int count)
- private static FMOD.RESULT FMOD_Studio_System_GetParameterLabelByID(System.IntPtr system, FMOD.Studio.PARAMETER_ID id, int labelindex, System.IntPtr label, int size, out int retrieved)
- private static FMOD.RESULT FMOD_Studio_System_GetParameterLabelByName(System.IntPtr system, byte[] name, int labelindex, System.IntPtr label, int size, out int retrieved)
- private static FMOD.RESULT FMOD_Studio_System_GetSoundInfo(System.IntPtr system, byte[] key, out FMOD.Studio.SOUND_INFO info)
- private static FMOD.RESULT FMOD_Studio_System_GetUserData(System.IntPtr system, out System.IntPtr userdata)
- private static FMOD.RESULT FMOD_Studio_System_GetVCA(System.IntPtr system, byte[] path, out System.IntPtr vca)
- private static FMOD.RESULT FMOD_Studio_System_GetVCAByID(System.IntPtr system, ref FMOD.GUID id, out System.IntPtr vca)
- private static FMOD.RESULT FMOD_Studio_System_Initialize(System.IntPtr system, int maxchannels, FMOD.Studio.INITFLAGS studioflags, FMOD.INITFLAGS flags, System.IntPtr extradriverdata)
- private static bool FMOD_Studio_System_IsValid(System.IntPtr system)
- private static FMOD.RESULT FMOD_Studio_System_LoadBankCustom(System.IntPtr system, ref FMOD.Studio.BANK_INFO info, FMOD.Studio.LOAD_BANK_FLAGS flags, out System.IntPtr bank)
- private static FMOD.RESULT FMOD_Studio_System_LoadBankFile(System.IntPtr system, byte[] filename, FMOD.Studio.LOAD_BANK_FLAGS flags, out System.IntPtr bank)
- private static FMOD.RESULT FMOD_Studio_System_LoadBankMemory(System.IntPtr system, System.IntPtr buffer, int length, FMOD.Studio.LOAD_MEMORY_MODE mode, FMOD.Studio.LOAD_BANK_FLAGS flags, out System.IntPtr bank)
- private static FMOD.RESULT FMOD_Studio_System_LoadCommandReplay(System.IntPtr system, byte[] filename, FMOD.Studio.COMMANDREPLAY_FLAGS flags, out System.IntPtr replay)
- private static FMOD.RESULT FMOD_Studio_System_LookupID(System.IntPtr system, byte[] path, out FMOD.GUID id)
- private static FMOD.RESULT FMOD_Studio_System_LookupPath(System.IntPtr system, ref FMOD.GUID id, System.IntPtr path, int size, out int retrieved)
- private static FMOD.RESULT FMOD_Studio_System_Release(System.IntPtr system)
- private static FMOD.RESULT FMOD_Studio_System_ResetBufferUsage(System.IntPtr system)
- private static FMOD.RESULT FMOD_Studio_System_SetAdvancedSettings(System.IntPtr system, ref FMOD.Studio.ADVANCEDSETTINGS settings)
- private static FMOD.RESULT FMOD_Studio_System_SetCallback(System.IntPtr system, FMOD.Studio.SYSTEM_CALLBACK callback, FMOD.Studio.SYSTEM_CALLBACK_TYPE callbackmask)
- private static FMOD.RESULT FMOD_Studio_System_SetListenerAttributes(System.IntPtr system, int listener, ref FMOD.ATTRIBUTES_3D attributes, System.IntPtr zero)
- private static FMOD.RESULT FMOD_Studio_System_SetListenerAttributes(System.IntPtr system, int listener, ref FMOD.ATTRIBUTES_3D attributes, ref FMOD.VECTOR attenuationposition)
- private static FMOD.RESULT FMOD_Studio_System_SetListenerWeight(System.IntPtr system, int listener, float weight)
- private static FMOD.RESULT FMOD_Studio_System_SetNumListeners(System.IntPtr system, int numlisteners)
- private static FMOD.RESULT FMOD_Studio_System_SetParameterByID(System.IntPtr system, FMOD.Studio.PARAMETER_ID id, float value, bool ignoreseekspeed)
- private static FMOD.RESULT FMOD_Studio_System_SetParameterByIDWithLabel(System.IntPtr system, FMOD.Studio.PARAMETER_ID id, byte[] label, bool ignoreseekspeed)
- private static FMOD.RESULT FMOD_Studio_System_SetParameterByName(System.IntPtr system, byte[] name, float value, bool ignoreseekspeed)
- private static FMOD.RESULT FMOD_Studio_System_SetParameterByNameWithLabel(System.IntPtr system, byte[] name, byte[] label, bool ignoreseekspeed)
- private static FMOD.RESULT FMOD_Studio_System_SetParametersByIDs(System.IntPtr system, FMOD.Studio.PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed)
- private static FMOD.RESULT FMOD_Studio_System_SetUserData(System.IntPtr system, System.IntPtr userdata)
- private static FMOD.RESULT FMOD_Studio_System_StartCommandCapture(System.IntPtr system, byte[] filename, FMOD.Studio.COMMANDCAPTURE_FLAGS flags)
- private static FMOD.RESULT FMOD_Studio_System_StopCommandCapture(System.IntPtr system)
- private static FMOD.RESULT FMOD_Studio_System_UnloadAll(System.IntPtr system)
- private static FMOD.RESULT FMOD_Studio_System_Update(System.IntPtr system)
- public FMOD.RESULT getAdvancedSettings(out FMOD.Studio.ADVANCEDSETTINGS settings)
- public FMOD.RESULT getBank(string path, out FMOD.Studio.Bank bank)
- public FMOD.RESULT getBankByID(FMOD.GUID id, out FMOD.Studio.Bank bank)
- public FMOD.RESULT getBankCount(out int count)
- public FMOD.RESULT getBankList(out FMOD.Studio.Bank[] array)
- public FMOD.RESULT getBufferUsage(out FMOD.Studio.BUFFER_USAGE usage)
- public FMOD.RESULT getBus(string path, out FMOD.Studio.Bus bus)
- public FMOD.RESULT getBusByID(FMOD.GUID id, out FMOD.Studio.Bus bus)
- public FMOD.RESULT getCoreSystem(out FMOD.System coresystem)
- public FMOD.RESULT getCPUUsage(out FMOD.Studio.CPU_USAGE usage, out FMOD.CPU_USAGE usage_core)
- public FMOD.RESULT getEvent(string path, out FMOD.Studio.EventDescription _event)
- public FMOD.RESULT getEventByID(FMOD.GUID id, out FMOD.Studio.EventDescription _event)
- public FMOD.RESULT getListenerAttributes(int listener, out FMOD.ATTRIBUTES_3D attributes)
- public FMOD.RESULT getListenerAttributes(int listener, out FMOD.ATTRIBUTES_3D attributes, out FMOD.VECTOR attenuationposition)
- public FMOD.RESULT getListenerWeight(int listener, out float weight)
- public FMOD.RESULT getMemoryUsage(out FMOD.Studio.MEMORY_USAGE memoryusage)
- public FMOD.RESULT getNumListeners(out int numlisteners)
- public FMOD.RESULT getParameterByID(FMOD.Studio.PARAMETER_ID id, out float value)
- public FMOD.RESULT getParameterByID(FMOD.Studio.PARAMETER_ID id, out float value, out float finalvalue)
- public FMOD.RESULT getParameterByName(string name, out float value)
- public FMOD.RESULT getParameterByName(string name, out float value, out float finalvalue)
- public FMOD.RESULT getParameterDescriptionByID(FMOD.Studio.PARAMETER_ID id, out FMOD.Studio.PARAMETER_DESCRIPTION parameter)
- public FMOD.RESULT getParameterDescriptionByName(string name, out FMOD.Studio.PARAMETER_DESCRIPTION parameter)
- public FMOD.RESULT getParameterDescriptionCount(out int count)
- public FMOD.RESULT getParameterDescriptionList(out FMOD.Studio.PARAMETER_DESCRIPTION[] array)
- public FMOD.RESULT getParameterLabelByID(FMOD.Studio.PARAMETER_ID id, int labelindex, out string label)
- public FMOD.RESULT getParameterLabelByName(string name, int labelindex, out string label)
- public FMOD.RESULT getSoundInfo(string key, out FMOD.Studio.SOUND_INFO info)
- public FMOD.RESULT getUserData(out System.IntPtr userdata)
- public FMOD.RESULT getVCA(string path, out FMOD.Studio.VCA vca)
- public FMOD.RESULT getVCAByID(FMOD.GUID id, out FMOD.Studio.VCA vca)
- public bool hasHandle()
- public FMOD.RESULT initialize(int maxchannels, FMOD.Studio.INITFLAGS studioflags, FMOD.INITFLAGS flags, System.IntPtr extradriverdata)
- public bool isValid()
- public FMOD.RESULT loadBankCustom(FMOD.Studio.BANK_INFO info, FMOD.Studio.LOAD_BANK_FLAGS flags, out FMOD.Studio.Bank bank)
- public FMOD.RESULT loadBankFile(string filename, FMOD.Studio.LOAD_BANK_FLAGS flags, out FMOD.Studio.Bank bank)
- public FMOD.RESULT loadBankMemory(byte[] buffer, FMOD.Studio.LOAD_BANK_FLAGS flags, out FMOD.Studio.Bank bank)
- public FMOD.RESULT loadCommandReplay(string filename, FMOD.Studio.COMMANDREPLAY_FLAGS flags, out FMOD.Studio.CommandReplay replay)
- public FMOD.RESULT lookupID(string path, out FMOD.GUID id)
- public FMOD.RESULT lookupPath(FMOD.GUID id, out string path)
- public FMOD.RESULT release()
- public FMOD.RESULT resetBufferUsage()
- public FMOD.RESULT setAdvancedSettings(FMOD.Studio.ADVANCEDSETTINGS settings)
- public FMOD.RESULT setAdvancedSettings(FMOD.Studio.ADVANCEDSETTINGS settings, string encryptionKey)
- public FMOD.RESULT setCallback(FMOD.Studio.SYSTEM_CALLBACK callback, FMOD.Studio.SYSTEM_CALLBACK_TYPE callbackmask = ALL)
- public FMOD.RESULT setListenerAttributes(int listener, FMOD.ATTRIBUTES_3D attributes)
- public FMOD.RESULT setListenerAttributes(int listener, FMOD.ATTRIBUTES_3D attributes, FMOD.VECTOR attenuationposition)
- public FMOD.RESULT setListenerWeight(int listener, float weight)
- public FMOD.RESULT setNumListeners(int numlisteners)
- public FMOD.RESULT setParameterByID(FMOD.Studio.PARAMETER_ID id, float value, bool ignoreseekspeed = false)
- public FMOD.RESULT setParameterByIDWithLabel(FMOD.Studio.PARAMETER_ID id, string label, bool ignoreseekspeed = false)
- public FMOD.RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
- public FMOD.RESULT setParameterByNameWithLabel(string name, string label, bool ignoreseekspeed = false)
- public FMOD.RESULT setParametersByIDs(FMOD.Studio.PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false)
- public FMOD.RESULT setUserData(System.IntPtr userdata)
- public FMOD.RESULT startCommandCapture(string filename, FMOD.Studio.COMMANDCAPTURE_FLAGS flags)
- public FMOD.RESULT stopCommandCapture()
- public FMOD.RESULT unloadAll()
- public FMOD.RESULT update()

### public delegate FMOD.Studio.SYSTEM_CALLBACK
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public SYSTEM_CALLBACK(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr system, FMOD.Studio.SYSTEM_CALLBACK_TYPE type, System.IntPtr commanddata, System.IntPtr userdata, System.AsyncCallback callback, object object)
- public virtual FMOD.RESULT EndInvoke(System.IAsyncResult result)
- public virtual FMOD.RESULT Invoke(System.IntPtr system, FMOD.Studio.SYSTEM_CALLBACK_TYPE type, System.IntPtr commanddata, System.IntPtr userdata)

### public enum FMOD.Studio.SYSTEM_CALLBACK_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ALL = 4294967295
- BANK_UNLOAD = 4
- LIVEUPDATE_CONNECTED = 8
- LIVEUPDATE_DISCONNECTED = 16
- POSTUPDATE = 2
- PREUPDATE = 1

### public struct FMOD.Studio.TIMELINE_BEAT_PROPERTIES

#### Fields
- public int bar
- public int beat
- public int position
- public float tempo
- public int timesignaturelower
- public int timesignatureupper

### public struct FMOD.Studio.TIMELINE_MARKER_PROPERTIES

#### Fields
- public FMOD.StringWrapper name
- public int position

### public struct FMOD.Studio.TIMELINE_NESTED_BEAT_PROPERTIES

#### Fields
- public FMOD.GUID eventid
- public FMOD.Studio.TIMELINE_BEAT_PROPERTIES properties

### internal struct FMOD.Studio.Union_IntBoolFloatString

#### Fields
- public bool boolvalue
- public float floatvalue
- public int intvalue
- public FMOD.StringWrapper stringvalue

### public struct FMOD.Studio.USER_PROPERTY

#### Fields
- public FMOD.StringWrapper name
- public FMOD.Studio.USER_PROPERTY_TYPE type
- private FMOD.Studio.Union_IntBoolFloatString value

#### Methods
- public bool boolValue()
- public float floatValue()
- public int intValue()
- public string stringValue()

### public enum FMOD.Studio.USER_PROPERTY_TYPE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BOOLEAN = 1
- FLOAT = 2
- INTEGER = 0
- STRING = 3

### public struct FMOD.Studio.Util

#### Methods
- private static FMOD.RESULT FMOD_Studio_ParseID(byte[] idString, out FMOD.GUID id)
- public static FMOD.RESULT parseID(string idString, out FMOD.GUID id)

### public struct FMOD.Studio.VCA

#### Fields
- public System.IntPtr handle

#### Constructors
- public VCA(System.IntPtr ptr)

#### Methods
- public void clearHandle()
- private static FMOD.RESULT FMOD_Studio_VCA_GetID(System.IntPtr vca, out FMOD.GUID id)
- private static FMOD.RESULT FMOD_Studio_VCA_GetPath(System.IntPtr vca, System.IntPtr path, int size, out int retrieved)
- private static FMOD.RESULT FMOD_Studio_VCA_GetVolume(System.IntPtr vca, out float volume, out float finalvolume)
- private static bool FMOD_Studio_VCA_IsValid(System.IntPtr vca)
- private static FMOD.RESULT FMOD_Studio_VCA_SetVolume(System.IntPtr vca, float volume)
- public FMOD.RESULT getID(out FMOD.GUID id)
- public FMOD.RESULT getPath(out string path)
- public FMOD.RESULT getVolume(out float volume)
- public FMOD.RESULT getVolume(out float volume, out float finalvolume)
- public bool hasHandle()
- public bool isValid()
- public FMOD.RESULT setVolume(float volume)

## Namespace: FMODUnity

### private class FMODUnity.Settings.<>c

#### Fields
- public static readonly FMODUnity.Settings.<>c <>9
- public static System.Comparison<FMODUnity.Platform> <>9__76_0
- public static System.Func<FMODUnity.Platform, bool> <>9__85_0
- public static System.Func<FMODUnity.Platform, bool> <>9__85_1

#### Constructors
- private static Settings.<>c()
- public Settings.<>c()

#### Methods
- internal int <DeclareRuntimePlatform>b__76_0(FMODUnity.Platform a, FMODUnity.Platform b)
- internal bool <OnEnable>b__85_0(FMODUnity.Platform platform)
- internal bool <OnEnable>b__85_1(FMODUnity.Platform platform)

### private class FMODUnity.Platform.PropertyAccessors.<>c

#### Fields
- public static readonly FMODUnity.Platform.PropertyAccessors.<>c <>9

#### Constructors
- private static Platform.PropertyAccessors.<>c()
- public Platform.PropertyAccessors.<>c()

#### Methods
- internal FMODUnity.Platform.Property<FMODUnity.TriStateBool> <.cctor>b__16_0(FMODUnity.Platform.PropertyStorage properties)
- internal FMODUnity.Platform.Property<int> <.cctor>b__16_1(FMODUnity.Platform.PropertyStorage properties)
- internal FMODUnity.Platform.Property<int> <.cctor>b__16_10(FMODUnity.Platform.PropertyStorage properties)
- internal FMODUnity.Platform.Property<int> <.cctor>b__16_11(FMODUnity.Platform.PropertyStorage properties)
- internal FMODUnity.Platform.Property<int> <.cctor>b__16_12(FMODUnity.Platform.PropertyStorage properties)
- internal FMODUnity.Platform.Property<System.Collections.Generic.List<string>> <.cctor>b__16_13(FMODUnity.Platform.PropertyStorage properties)
- internal FMODUnity.Platform.Property<System.Collections.Generic.List<string>> <.cctor>b__16_14(FMODUnity.Platform.PropertyStorage properties)
- internal FMODUnity.Platform.Property<FMODUnity.PlatformCallbackHandler> <.cctor>b__16_15(FMODUnity.Platform.PropertyStorage properties)
- internal FMODUnity.Platform.Property<FMODUnity.TriStateBool> <.cctor>b__16_2(FMODUnity.Platform.PropertyStorage properties)
- internal FMODUnity.Platform.Property<FMODUnity.ScreenPosition> <.cctor>b__16_3(FMODUnity.Platform.PropertyStorage properties)
- internal FMODUnity.Platform.Property<int> <.cctor>b__16_4(FMODUnity.Platform.PropertyStorage properties)
- internal FMODUnity.Platform.Property<FMODUnity.TriStateBool> <.cctor>b__16_5(FMODUnity.Platform.PropertyStorage properties)
- internal FMODUnity.Platform.Property<int> <.cctor>b__16_6(FMODUnity.Platform.PropertyStorage properties)
- internal FMODUnity.Platform.Property<string> <.cctor>b__16_7(FMODUnity.Platform.PropertyStorage properties)
- internal FMODUnity.Platform.Property<FMOD.SPEAKERMODE> <.cctor>b__16_8(FMODUnity.Platform.PropertyStorage properties)
- internal FMODUnity.Platform.Property<int> <.cctor>b__16_9(FMODUnity.Platform.PropertyStorage properties)

### private class FMODUnity.RuntimeManager.<>c__DisplayClass40_0

#### Fields
- public FMODUnity.CodecType format

#### Constructors
- public RuntimeManager.<>c__DisplayClass40_0()

#### Methods
- internal bool <GetChannelCountForFormat>b__0(FMODUnity.CodecChannelCount x)

### private class FMODUnity.RuntimeManager.<>c__DisplayClass44_0

#### Fields
- public FMOD.Studio.EventInstance instance

#### Constructors
- public RuntimeManager.<>c__DisplayClass44_0()

#### Methods
- internal bool <FindOrAddAttachedInstance>b__0(FMODUnity.RuntimeManager.AttachedInstance x)

### private class FMODUnity.StudioEventEmitter.<>c__DisplayClass49_0

#### Fields
- public string findName

#### Constructors
- public StudioEventEmitter.<>c__DisplayClass49_0()

#### Methods
- internal bool <SetParameter>b__0(FMODUnity.ParamRef x)

### private class FMODUnity.StudioEventEmitter.<>c__DisplayClass50_0

#### Fields
- public FMOD.Studio.PARAMETER_ID findId

#### Constructors
- public StudioEventEmitter.<>c__DisplayClass50_0()

#### Methods
- internal bool <SetParameter>b__0(FMODUnity.ParamRef x)

### private class FMODUnity.Legacy.<>c__DisplayClass6_0<T, U>

#### Fields
- public FMODUnity.Legacy.Platform fromPlatform
- public FMODUnity.Legacy.Platform toPlatform

#### Constructors
- public Legacy.<>c__DisplayClass6_0<T, U>()

#### Methods
- internal bool <CopySetting>b__0(T x)
- internal bool <CopySetting>b__1(T x)

### private class FMODUnity.Settings.<>c__DisplayClass74_0

#### Fields
- public string identifier

#### Constructors
- public Settings.<>c__DisplayClass74_0()

#### Methods
- internal bool <RemovePlatform>b__0(FMODUnity.Platform p)

### private class FMODUnity.Settings.<>c__DisplayClass83_0<T>

#### Fields
- public string identifier

#### Constructors
- public Settings.<>c__DisplayClass83_0<T>()

#### Methods
- internal FMODUnity.Platform <AddPlatformTemplate>b__0()

### private class FMODUnity.RuntimeManager.<BanksToLoad>d__66
- Interfaces: System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private string <>2__current
- public FMODUnity.Settings <>3__fmodSettings
- private System.Collections.Generic.List<T>.Enumerator<string> <>7__wrap1
- private int <>l__initialThreadId
- private string <masterBankFileName>5__3
- private FMODUnity.Settings fmodSettings

#### Properties
- private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public RuntimeManager.<BanksToLoad>d__66(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private void <>m__Finally2()
- private void <>m__Finally3()
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class FMODUnity.RuntimeManager.AttachedInstance

#### Fields
- public FMOD.Studio.EventInstance instance
- public UnityEngine.Vector3 lastFramePosition
- public bool nonRigidbodyVelocity
- public UnityEngine.Rigidbody rigidBody
- public UnityEngine.Rigidbody2D rigidBody2D
- public UnityEngine.Transform transform

#### Constructors
- public RuntimeManager.AttachedInstance()

### public struct FMODUnity.AutomatableSlots

#### Fields
- public static const int Count
- public float Slot00
- public float Slot01
- public float Slot02
- public float Slot03
- public float Slot04
- public float Slot05
- public float Slot06
- public float Slot07
- public float Slot08
- public float Slot09
- public float Slot10
- public float Slot11
- public float Slot12
- public float Slot13
- public float Slot14
- public float Slot15

#### Methods
- public float GetValue(int index)

### public class FMODUnity.BankLoadException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Fields
- public string Path
- public FMOD.RESULT Result

#### Constructors
- public BankLoadException(string path, FMOD.RESULT result)
- public BankLoadException(string path, string error)

### public enum FMODUnity.BankLoadType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- All = 0
- None = 2
- Specified = 1

### public class FMODUnity.BankRefAttribute
- Base: UnityEngine.PropertyAttribute

#### Constructors
- public BankRefAttribute()

### public class FMODUnity.BusNotFoundException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Fields
- public string Path

#### Constructors
- public BusNotFoundException(string path)

### public class FMODUnity.CodecChannelCount

#### Fields
- public int channels
- public FMODUnity.CodecType format

#### Constructors
- public CodecChannelCount()
- public CodecChannelCount(FMODUnity.CodecChannelCount other)

### public enum FMODUnity.CodecType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AT9 = 2
- FADPCM = 0
- Opus = 4
- Vorbis = 1
- XMA = 3

### public enum FMODUnity.EmitterGameEvent
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CollisionEnter = 7
- CollisionEnter2D = 9
- CollisionExit = 8
- CollisionExit2D = 10
- None = 0
- ObjectDestroy = 2
- ObjectDisable = 12
- ObjectEnable = 11
- ObjectMouseDown = 15
- ObjectMouseEnter = 13
- ObjectMouseExit = 14
- ObjectMouseUp = 16
- ObjectStart = 1
- TriggerEnter = 3
- TriggerEnter2D = 5
- TriggerExit = 4
- TriggerExit2D = 6
- UIMouseDown = 19
- UIMouseEnter = 17
- UIMouseExit = 18
- UIMouseUp = 20

### public class FMODUnity.EmitterRef

#### Fields
- public FMODUnity.ParamRef[] Params
- public FMODUnity.StudioEventEmitter Target

#### Constructors
- public EmitterRef()

### public class FMODUnity.FMODEventPlayableBehavior.EventArgs
- Base: System.EventArgs

#### Fields
- private FMOD.Studio.EventInstance <eventInstance>k__BackingField

#### Properties
- public FMOD.Studio.EventInstance eventInstance { get; set; }

#### Constructors
- public FMODEventPlayableBehavior.EventArgs()

### public class FMODUnity.EventHandler
- Base: UnityEngine.MonoBehaviour
- Interfaces: UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler

#### Fields
- public string CollisionTag

#### Constructors
- protected EventHandler()

#### Methods
- protected abstract void HandleGameEvent(FMODUnity.EmitterGameEvent gameEvent)
- private void OnCollisionEnter()
- private void OnCollisionEnter2D()
- private void OnCollisionExit()
- private void OnCollisionExit2D()
- protected virtual void OnDestroy()
- private void OnDisable()
- private void OnEnable()
- private void OnMouseDown()
- private void OnMouseEnter()
- private void OnMouseExit()
- private void OnMouseUp()
- public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
- public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
- public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
- public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
- private void OnTriggerEnter(UnityEngine.Collider other)
- private void OnTriggerEnter2D(UnityEngine.Collider2D other)
- private void OnTriggerExit(UnityEngine.Collider other)
- private void OnTriggerExit2D(UnityEngine.Collider2D other)
- protected virtual void Start()

### public enum FMODUnity.EventLinkage
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- GUID = 1
- Path = 0

### public class FMODUnity.EventNotFoundException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Fields
- public FMOD.GUID Guid
- public string Path

#### Constructors
- public EventNotFoundException(string path)
- public EventNotFoundException(FMOD.GUID guid)
- public EventNotFoundException(FMODUnity.EventReference eventReference)

### public class FMODUnity.EventRefAttribute
- Base: UnityEngine.PropertyAttribute

#### Fields
- public string MigrateTo

#### Constructors
- public EventRefAttribute()

### public struct FMODUnity.EventReference

#### Fields
- public FMOD.GUID Guid

#### Properties
- public bool IsNull { get; }

#### Methods
- public override string ToString()

### public class FMODUnity.FMODEventMixerBehaviour
- Base: UnityEngine.Playables.PlayableBehaviour
- Interfaces: UnityEngine.Playables.IPlayableBehaviour, System.ICloneable

#### Fields
- public float volume

#### Constructors
- public FMODEventMixerBehaviour()

#### Methods
- public override void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData)

### public class FMODUnity.FMODEventPlayable
- Base: UnityEngine.Playables.PlayableAsset
- Interfaces: UnityEngine.Playables.IPlayableAsset, UnityEngine.Timeline.ITimelineClipAsset

#### Fields
- private UnityEngine.Timeline.TimelineClip <OwningClip>k__BackingField
- private UnityEngine.GameObject <TrackTargetObject>k__BackingField
- private FMODUnity.FMODEventPlayableBehavior behavior
- public bool CachedParameters
- public float EventLength
- public string eventName
- public FMODUnity.EventReference EventReference
- private static System.EventHandler<System.EventArgs> OnCreatePlayable
- public FMODUnity.ParamRef[] Parameters
- public FMODUnity.STOP_MODE StopType
- public FMODUnity.FMODEventPlayableBehavior Template

#### Properties
- public UnityEngine.Timeline.ClipCaps clipCaps { get; }
- public double duration { get; }
- public UnityEngine.Timeline.TimelineClip OwningClip { get; set; }
- public UnityEngine.GameObject TrackTargetObject { get; set; }

#### Events
- public static event System.EventHandler<System.EventArgs> OnCreatePlayable

#### Constructors
- public FMODEventPlayable()

#### Methods
- public override UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
- public void LinkParameters(FMOD.Studio.EventDescription eventDescription)

### public class FMODUnity.FMODEventPlayableBehavior
- Base: UnityEngine.Playables.PlayableBehaviour
- Interfaces: UnityEngine.Playables.IPlayableBehaviour, System.ICloneable

#### Fields
- private float <ClipStartTime>k__BackingField
- private float <CurrentVolume>k__BackingField
- private static System.EventHandler<FMODUnity.FMODEventPlayableBehavior.EventArgs> Enter
- private FMOD.Studio.EventInstance eventInstance
- public FMODUnity.EventReference EventReference
- private static System.EventHandler<FMODUnity.FMODEventPlayableBehavior.EventArgs> Exit
- private static System.EventHandler<FMODUnity.FMODEventPlayableBehavior.EventArgs> GraphStop
- private bool isPlayheadInside
- public UnityEngine.Timeline.TimelineClip OwningClip
- public FMODUnity.AutomatableSlots ParameterAutomation
- public System.Collections.Generic.List<FMODUnity.ParameterAutomationLink> ParameterLinks
- public FMODUnity.ParamRef[] Parameters
- public FMODUnity.STOP_MODE StopType
- public UnityEngine.GameObject TrackTargetObject

#### Properties
- public float ClipStartTime { get; private set; }
- public float CurrentVolume { get; private set; }

#### Events
- public static event System.EventHandler<FMODUnity.FMODEventPlayableBehavior.EventArgs> Enter
- public static event System.EventHandler<FMODUnity.FMODEventPlayableBehavior.EventArgs> Exit
- public static event System.EventHandler<FMODUnity.FMODEventPlayableBehavior.EventArgs> GraphStop

#### Constructors
- public FMODEventPlayableBehavior()

#### Methods
- protected virtual void OnEnter()
- protected virtual void OnExit()
- public override void OnGraphStop(UnityEngine.Playables.Playable playable)
- protected void PlayEvent()
- public override void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData)
- public void UpdateBehavior(float time, float volume)

### public class FMODUnity.FMODEventTrack
- Base: UnityEngine.Timeline.TrackAsset
- Interfaces: UnityEngine.Playables.IPlayableAsset, UnityEngine.ISerializationCallbackReceiver, UnityEngine.Timeline.IPropertyPreview, UnityEngine.Timeline.ICurvesOwner

#### Fields
- public FMODUnity.FMODEventMixerBehaviour template

#### Constructors
- public FMODEventTrack()

#### Methods
- public override UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount)

### public class FMODUnity.FMODRuntimeManagerOnGUIHelper
- Base: UnityEngine.MonoBehaviour

#### Fields
- public FMODUnity.RuntimeManager TargetRuntimeManager

#### Constructors
- public FMODRuntimeManagerOnGUIHelper()

#### Methods
- private void OnGUI()

### private class FMODUnity.RuntimeManager.GuidComparer
- Interfaces: System.Collections.Generic.IEqualityComparer<FMOD.GUID>

#### Constructors
- public RuntimeManager.GuidComparer()

#### Methods
- private bool System.Collections.Generic.IEqualityComparer<FMOD.GUID>.Equals(FMOD.GUID x, FMOD.GUID y)
- private int System.Collections.Generic.IEqualityComparer<FMOD.GUID>.GetHashCode(FMOD.GUID obj)

### public interface FMODUnity.IEditorSettings

### public enum FMODUnity.ImportType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AssetBundle = 1
- StreamingAssets = 0

### internal static class FMODUnity.Legacy

#### Methods
- public static void CopySetting<T, U>(System.Collections.Generic.List<T> list, FMODUnity.Legacy.Platform fromPlatform, FMODUnity.Legacy.Platform toPlatform)
- public static void CopySetting(System.Collections.Generic.List<FMODUnity.Legacy.PlatformBoolSetting> list, FMODUnity.Legacy.Platform fromPlatform, FMODUnity.Legacy.Platform toPlatform)
- public static void CopySetting(System.Collections.Generic.List<FMODUnity.Legacy.PlatformIntSetting> list, FMODUnity.Legacy.Platform fromPlatform, FMODUnity.Legacy.Platform toPlatform)
- public static string DisplayName(FMODUnity.Legacy.Platform platform)
- public static bool IsGroup(FMODUnity.Legacy.Platform platform)
- public static FMODUnity.Legacy.Platform Parent(FMODUnity.Legacy.Platform platform)
- public static float SortOrder(FMODUnity.Legacy.Platform legacyPlatform)

### private struct FMODUnity.RuntimeManager.LoadedBank

#### Fields
- public FMOD.Studio.Bank Bank
- public int RefCount

### public enum FMODUnity.LoaderGameEvent
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- None = 0
- ObjectDestroy = 2
- ObjectDisable = 8
- ObjectEnable = 7
- ObjectStart = 1
- TriggerEnter = 3
- TriggerEnter2D = 5
- TriggerExit = 4
- TriggerExit2D = 6

### public enum FMODUnity.MeterChannelOrderingType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Positional = 2
- SeparateLFE = 1
- Standard = 0

### public class FMODUnity.ParameterAutomationLink

#### Fields
- public FMOD.Studio.PARAMETER_ID ID
- public string Name
- public int Slot

#### Constructors
- public ParameterAutomationLink()

### public class FMODUnity.ParamRef

#### Fields
- public FMOD.Studio.PARAMETER_ID ID
- public string Name
- public float Value

#### Constructors
- public ParamRef()

### public class FMODUnity.ParamRefAttribute
- Base: UnityEngine.PropertyAttribute

#### Constructors
- public ParamRefAttribute()

### public class FMODUnity.Platform
- Base: UnityEngine.ScriptableObject

#### Fields
- private bool active
- private FMODUnity.Platform.PropertyCodecChannels codecChannels
- internal static const float DefaultPriority
- private string identifier
- internal string OutputTypeName
- public FMODUnity.Platform Parent
- private string parentIdentifier
- protected FMODUnity.Platform.PropertyStorage Properties
- internal static const string RegisterStaticPluginsClassName
- internal static const string RegisterStaticPluginsFunctionName
- private static System.Collections.Generic.List<FMODUnity.CodecChannelCount> staticCodecChannels
- private static System.Collections.Generic.List<FMODUnity.ThreadAffinityGroup> StaticThreadAffinities
- private FMODUnity.Platform.PropertyThreadAffinityList threadAffinities

#### Properties
- internal bool Active { get; }
- public string BuildDirectory { get; }
- public FMODUnity.PlatformCallbackHandler CallbackHandler { get; }
- internal System.Collections.Generic.List<FMODUnity.CodecChannelCount> CodecChannels { get; }
- internal FMODUnity.Platform.PropertyCodecChannels CodecChannelsProperty { get; }
- internal System.Collections.Generic.List<FMODUnity.CodecChannelCount> DefaultCodecChannels { get; }
- internal System.Collections.Generic.List<FMODUnity.ThreadAffinityGroup> DefaultThreadAffinities { get; }
- internal string DisplayName { get; }
- public int DSPBufferCount { get; }
- public int DSPBufferLength { get; }
- internal bool HasAnyOverriddenProperties { get; }
- internal string Identifier { get; set; }
- internal bool IsIntrinsic { get; }
- internal bool IsLiveUpdateEnabled { get; }
- internal bool IsOverlayEnabled { get; }
- public FMODUnity.TriStateBool LiveUpdate { get; }
- public int LiveUpdatePort { get; }
- public FMODUnity.TriStateBool Logging { get; }
- internal bool MatchesCurrentEnvironment { get; }
- public FMODUnity.TriStateBool Overlay { get; }
- public int OverlayFontSize { get; }
- public FMODUnity.ScreenPosition OverlayRect { get; }
- internal string ParentIdentifier { get; set; }
- public System.Collections.Generic.List<string> Plugins { get; }
- internal float Priority { get; }
- public int RealChannelCount { get; }
- public int SampleRate { get; }
- public FMOD.SPEAKERMODE SpeakerMode { get; }
- public System.Collections.Generic.List<string> StaticPlugins { get; }
- public System.Collections.Generic.IEnumerable<FMODUnity.ThreadAffinityGroup> ThreadAffinities { get; }
- internal FMODUnity.Platform.PropertyThreadAffinityList ThreadAffinitiesProperty { get; }
- public int VirtualChannelCount { get; }

#### Constructors
- protected Platform()
- private static Platform()

#### Methods
- internal void AffirmProperties()
- internal void ClearProperties()
- internal abstract void DeclareRuntimePlatforms(FMODUnity.Settings settings)
- internal virtual void EnsurePropertiesAreValid()
- internal virtual string GetBankFolder()
- internal FMOD.OUTPUTTYPE GetOutputType()
- protected virtual string GetPluginBasePath()
- internal virtual string GetPluginPath(string pluginName)
- internal bool InheritsFrom(FMODUnity.Platform platform)
- internal virtual void InitializeProperties()
- internal virtual void LoadDynamicPlugins(FMOD.System coreSystem, System.Action<FMOD.RESULT, string> reportResult)
- internal virtual void LoadPlugins(FMOD.System coreSystem, System.Action<FMOD.RESULT, string> reportResult)
- internal virtual void LoadStaticPlugins(FMOD.System coreSystem, System.Action<FMOD.RESULT, string> reportResult)
- internal virtual void PreInitialize(FMOD.Studio.System studioSystem)
- internal virtual void PreSystemCreate(System.Action<FMOD.RESULT, string> reportResult)
- public void SetOverlayFontSize(int size)

### public enum FMODUnity.Legacy.Platform
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Android = 12
- AppleTV = 18
- Console = 7
- Count = 26
- Default = 2
- Deprecated_1 = 13
- Deprecated_2 = 16
- Deprecated_3 = 17
- Deprecated_4 = 22
- Desktop = 3
- iOS = 11
- Linux = 10
- Mac = 9
- Mobile = 4
- MobileHigh = 5
- MobileLow = 6
- None = 0
- PlayInEditor = 1
- PS4 = 15
- Reserved_1 = 23
- Reserved_2 = 24
- Reserved_3 = 25
- Switch = 20
- UWP = 19
- WebGL = 21
- Windows = 8
- XboxOne = 14

### public class FMODUnity.PlatformAndroid
- Base: FMODUnity.Platform

#### Properties
- internal string DisplayName { get; }

#### Constructors
- private static PlatformAndroid()
- public PlatformAndroid()

#### Methods
- internal override void DeclareRuntimePlatforms(FMODUnity.Settings settings)
- internal override string GetBankFolder()
- internal override string GetPluginPath(string pluginName)
- internal static string StaticGetBankFolder()
- internal static string StaticGetPluginPath(string pluginName)

### public class FMODUnity.PlatformAppleTV
- Base: FMODUnity.Platform

#### Properties
- internal string DisplayName { get; }

#### Constructors
- private static PlatformAppleTV()
- public PlatformAppleTV()

#### Methods
- internal override void DeclareRuntimePlatforms(FMODUnity.Settings settings)
- internal override void LoadPlugins(FMOD.System coreSystem, System.Action<FMOD.RESULT, string> reportResult)

### public class FMODUnity.Legacy.PlatformBoolSetting
- Base: FMODUnity.Legacy.PlatformSetting<FMODUnity.TriStateBool>

#### Constructors
- public Legacy.PlatformBoolSetting()

### public class FMODUnity.PlatformCallbackHandler
- Base: UnityEngine.ScriptableObject

#### Constructors
- public PlatformCallbackHandler()

#### Methods
- public virtual void PreInitialize(FMOD.Studio.System system, System.Action<FMOD.RESULT, string> reportResult)

### public class FMODUnity.PlatformDefault
- Base: FMODUnity.Platform

#### Fields
- public static const string ConstIdentifier

#### Properties
- internal string DisplayName { get; }
- internal bool IsIntrinsic { get; }

#### Constructors
- public PlatformDefault()

#### Methods
- internal override void DeclareRuntimePlatforms(FMODUnity.Settings settings)
- internal override void EnsurePropertiesAreValid()
- internal override void InitializeProperties()

### public class FMODUnity.PlatformGroup
- Base: FMODUnity.Platform

#### Fields
- private string displayName
- private FMODUnity.Legacy.Platform legacyIdentifier

#### Properties
- internal string DisplayName { get; }

#### Constructors
- public PlatformGroup()

#### Methods
- internal override void DeclareRuntimePlatforms(FMODUnity.Settings settings)

### public class FMODUnity.Legacy.PlatformIntSetting
- Base: FMODUnity.Legacy.PlatformSetting<int>

#### Constructors
- public Legacy.PlatformIntSetting()

### public class FMODUnity.PlatformIOS
- Base: FMODUnity.Platform

#### Properties
- internal string DisplayName { get; }

#### Constructors
- private static PlatformIOS()
- public PlatformIOS()

#### Methods
- internal override void DeclareRuntimePlatforms(FMODUnity.Settings settings)
- internal override void LoadPlugins(FMOD.System coreSystem, System.Action<FMOD.RESULT, string> reportResult)
- public static void StaticLoadPlugins(FMODUnity.Platform platform, FMOD.System coreSystem, System.Action<FMOD.RESULT, string> reportResult)

### public class FMODUnity.PlatformLinux
- Base: FMODUnity.Platform

#### Fields
- private static System.Collections.Generic.List<FMODUnity.CodecChannelCount> staticCodecChannels

#### Properties
- internal System.Collections.Generic.List<FMODUnity.CodecChannelCount> DefaultCodecChannels { get; }
- internal string DisplayName { get; }

#### Constructors
- private static PlatformLinux()
- public PlatformLinux()

#### Methods
- internal override void DeclareRuntimePlatforms(FMODUnity.Settings settings)
- internal override string GetPluginPath(string pluginName)

### public class FMODUnity.PlatformMac
- Base: FMODUnity.Platform

#### Fields
- private static System.Collections.Generic.List<FMODUnity.CodecChannelCount> staticCodecChannels

#### Properties
- internal System.Collections.Generic.List<FMODUnity.CodecChannelCount> DefaultCodecChannels { get; }
- internal string DisplayName { get; }

#### Constructors
- private static PlatformMac()
- public PlatformMac()

#### Methods
- internal override void DeclareRuntimePlatforms(FMODUnity.Settings settings)
- internal override string GetPluginPath(string pluginName)

### public class FMODUnity.PlatformMobileHigh
- Base: FMODUnity.PlatformMobileLow

#### Properties
- internal string DisplayName { get; }
- internal bool MatchesCurrentEnvironment { get; }
- internal float Priority { get; }

#### Constructors
- private static PlatformMobileHigh()
- public PlatformMobileHigh()

### public class FMODUnity.PlatformMobileLow
- Base: FMODUnity.Platform

#### Properties
- internal string DisplayName { get; }
- internal bool MatchesCurrentEnvironment { get; }
- internal float Priority { get; }

#### Constructors
- private static PlatformMobileLow()
- public PlatformMobileLow()

#### Methods
- internal override void DeclareRuntimePlatforms(FMODUnity.Settings settings)

### public class FMODUnity.PlatformPlayInEditor
- Base: FMODUnity.Platform

#### Fields
- private static System.Collections.Generic.List<FMODUnity.CodecChannelCount> staticCodecChannels

#### Properties
- internal System.Collections.Generic.List<FMODUnity.CodecChannelCount> DefaultCodecChannels { get; }
- internal string DisplayName { get; }
- internal bool IsIntrinsic { get; }

#### Constructors
- public PlatformPlayInEditor()
- private static PlatformPlayInEditor()

#### Methods
- internal override void DeclareRuntimePlatforms(FMODUnity.Settings settings)
- internal override string GetBankFolder()
- internal override void InitializeProperties()
- internal override void LoadStaticPlugins(FMOD.System coreSystem, System.Action<FMOD.RESULT, string> reportResult)

### public class FMODUnity.Legacy.PlatformSettingBase

#### Fields
- public FMODUnity.Legacy.Platform Platform

#### Constructors
- public Legacy.PlatformSettingBase()

### public class FMODUnity.Legacy.PlatformSetting<T>
- Base: FMODUnity.Legacy.PlatformSettingBase

#### Fields
- public T Value

#### Constructors
- public Legacy.PlatformSetting<T>()

### public class FMODUnity.Legacy.PlatformStringSetting
- Base: FMODUnity.Legacy.PlatformSetting<string>

#### Constructors
- public Legacy.PlatformStringSetting()

### internal struct FMODUnity.Settings.PlatformTemplate

#### Fields
- public System.Func<FMODUnity.Platform> CreateInstance
- public string Identifier

### public class FMODUnity.PlatformVisionOS
- Base: FMODUnity.Platform

#### Properties
- internal string DisplayName { get; }

#### Constructors
- private static PlatformVisionOS()
- public PlatformVisionOS()

#### Methods
- internal override void DeclareRuntimePlatforms(FMODUnity.Settings settings)
- internal override void LoadPlugins(FMOD.System coreSystem, System.Action<FMOD.RESULT, string> reportResult)

### public class FMODUnity.PlatformWebGL
- Base: FMODUnity.Platform

#### Properties
- internal string DisplayName { get; }

#### Constructors
- private static PlatformWebGL()
- public PlatformWebGL()

#### Methods
- internal override void DeclareRuntimePlatforms(FMODUnity.Settings settings)
- internal override string GetPluginPath(string pluginName)

### public class FMODUnity.PlatformWindows
- Base: FMODUnity.Platform

#### Fields
- private static System.Collections.Generic.List<FMODUnity.CodecChannelCount> staticCodecChannels

#### Properties
- internal System.Collections.Generic.List<FMODUnity.CodecChannelCount> DefaultCodecChannels { get; }
- internal string DisplayName { get; }

#### Constructors
- private static PlatformWindows()
- public PlatformWindows()

#### Methods
- internal override void DeclareRuntimePlatforms(FMODUnity.Settings settings)
- internal override string GetPluginPath(string pluginName)

### public static class FMODUnity.Platform.PropertyAccessors

#### Fields
- public static readonly FMODUnity.Platform.PropertyAccessor<string> BuildDirectory
- public static readonly FMODUnity.Platform.PropertyAccessor<FMODUnity.PlatformCallbackHandler> CallbackHandler
- public static readonly FMODUnity.Platform.PropertyAccessor<int> DSPBufferCount
- public static readonly FMODUnity.Platform.PropertyAccessor<int> DSPBufferLength
- public static readonly FMODUnity.Platform.PropertyAccessor<FMODUnity.TriStateBool> LiveUpdate
- public static readonly FMODUnity.Platform.PropertyAccessor<int> LiveUpdatePort
- public static readonly FMODUnity.Platform.PropertyAccessor<FMODUnity.TriStateBool> Logging
- public static readonly FMODUnity.Platform.PropertyAccessor<FMODUnity.TriStateBool> Overlay
- public static readonly FMODUnity.Platform.PropertyAccessor<int> OverlayFontSize
- public static readonly FMODUnity.Platform.PropertyAccessor<FMODUnity.ScreenPosition> OverlayPosition
- public static readonly FMODUnity.Platform.PropertyAccessor<System.Collections.Generic.List<string>> Plugins
- public static readonly FMODUnity.Platform.PropertyAccessor<int> RealChannelCount
- public static readonly FMODUnity.Platform.PropertyAccessor<int> SampleRate
- public static readonly FMODUnity.Platform.PropertyAccessor<FMOD.SPEAKERMODE> SpeakerMode
- public static readonly FMODUnity.Platform.PropertyAccessor<System.Collections.Generic.List<string>> StaticPlugins
- public static readonly FMODUnity.Platform.PropertyAccessor<int> VirtualChannelCount

#### Constructors
- private static Platform.PropertyAccessors()

### public struct FMODUnity.Platform.PropertyAccessor<T>
- Interfaces: FMODUnity.Platform.PropertyOverrideControl

#### Fields
- private readonly T DefaultValue
- private readonly System.Func<FMODUnity.Platform.PropertyStorage, FMODUnity.Platform.Property<T>> Getter

#### Constructors
- public Platform.PropertyAccessor<T>(System.Func<FMODUnity.Platform.PropertyStorage, FMODUnity.Platform.Property<T>> getter, T defaultValue)

#### Methods
- public void Clear(FMODUnity.Platform platform)
- public T Get(FMODUnity.Platform platform)
- public bool HasValue(FMODUnity.Platform platform)
- public void Set(FMODUnity.Platform platform, T value)

### public class FMODUnity.Platform.PropertyBool
- Base: FMODUnity.Platform.Property<FMODUnity.TriStateBool>

#### Constructors
- public Platform.PropertyBool()

### public class FMODUnity.Platform.PropertyCallbackHandler
- Base: FMODUnity.Platform.Property<FMODUnity.PlatformCallbackHandler>

#### Constructors
- public Platform.PropertyCallbackHandler()

### internal class FMODUnity.Platform.PropertyCodecChannels
- Base: FMODUnity.Platform.Property<System.Collections.Generic.List<FMODUnity.CodecChannelCount>>

#### Constructors
- public Platform.PropertyCodecChannels()

### public class FMODUnity.Platform.PropertyInt
- Base: FMODUnity.Platform.Property<int>

#### Constructors
- public Platform.PropertyInt()

### internal interface FMODUnity.Platform.PropertyOverrideControl

#### Methods
- public void Clear(FMODUnity.Platform platform)
- public bool HasValue(FMODUnity.Platform platform)

### public class FMODUnity.Platform.PropertyScreenPosition
- Base: FMODUnity.Platform.Property<FMODUnity.ScreenPosition>

#### Constructors
- public Platform.PropertyScreenPosition()

### public class FMODUnity.Platform.PropertySpeakerMode
- Base: FMODUnity.Platform.Property<FMOD.SPEAKERMODE>

#### Constructors
- public Platform.PropertySpeakerMode()

### public class FMODUnity.Platform.PropertyStorage

#### Fields
- public FMODUnity.Platform.PropertyString BuildDirectory
- public FMODUnity.Platform.PropertyCallbackHandler CallbackHandler
- public FMODUnity.Platform.PropertyInt DSPBufferCount
- public FMODUnity.Platform.PropertyInt DSPBufferLength
- public FMODUnity.Platform.PropertyBool LiveUpdate
- public FMODUnity.Platform.PropertyInt LiveUpdatePort
- public FMODUnity.Platform.PropertyBool Logging
- public FMODUnity.Platform.PropertyBool Overlay
- public FMODUnity.Platform.PropertyInt OverlayFontSize
- public FMODUnity.Platform.PropertyScreenPosition OverlayPosition
- public FMODUnity.Platform.PropertyStringList Plugins
- public FMODUnity.Platform.PropertyInt RealChannelCount
- public FMODUnity.Platform.PropertyInt SampleRate
- public FMODUnity.Platform.PropertySpeakerMode SpeakerMode
- public FMODUnity.Platform.PropertyStringList StaticPlugins
- public FMODUnity.Platform.PropertyInt VirtualChannelCount

#### Constructors
- public Platform.PropertyStorage()

### public class FMODUnity.Platform.PropertyString
- Base: FMODUnity.Platform.Property<string>

#### Constructors
- public Platform.PropertyString()

### public class FMODUnity.Platform.PropertyStringList
- Base: FMODUnity.Platform.Property<System.Collections.Generic.List<string>>

#### Constructors
- public Platform.PropertyStringList()

### public class FMODUnity.Platform.PropertyThreadAffinityList
- Base: FMODUnity.Platform.Property<System.Collections.Generic.List<FMODUnity.ThreadAffinityGroup>>

#### Constructors
- public Platform.PropertyThreadAffinityList()

### public class FMODUnity.Platform.Property<T>

#### Fields
- public bool HasValue
- public T Value

#### Constructors
- public Platform.Property<T>()

### public class FMODUnity.RuntimeManager
- Base: UnityEngine.MonoBehaviour

#### Fields
- private System.Collections.Generic.List<FMODUnity.RuntimeManager.AttachedInstance> attachedInstances
- public static const string BankStubPrefix
- private System.Collections.Generic.Dictionary<FMOD.GUID, FMOD.Studio.EventDescription> cachedDescriptions
- private FMOD.System coreSystem
- private FMODUnity.Platform currentPlatform
- private FMOD.DEBUG_CALLBACK debugCallback
- private FMOD.SYSTEM_CALLBACK errorCallback
- private static byte[] eventSet3DAttributes
- private static FMODUnity.SystemNotInitializedException initException
- private static FMODUnity.RuntimeManager instance
- private bool isMuted
- protected bool isOverlayEnabled
- private string lastDebugText
- private float lastDebugUpdate
- private bool listenerWarningIssued
- private System.Collections.Generic.Dictionary<string, FMODUnity.RuntimeManager.LoadedBank> loadedBanks
- private int loadingBanksRef
- private static byte[] masterBusPrefix
- private FMOD.DSP mixerHead
- private FMODUnity.FMODRuntimeManagerOnGUIHelper overlayDrawer
- private System.Collections.Generic.List<string> sampleLoadRequests
- private FMOD.Studio.System studioSystem
- private static byte[] systemGetBus
- private UnityEngine.Rect windowRect

#### Properties
- public static FMOD.System CoreSystem { get; }
- public static bool HaveAllBanksLoaded { get; }
- public static bool HaveMasterBanksLoaded { get; }
- private static FMODUnity.RuntimeManager Instance { get; }
- public static bool IsInitialized { get; }
- public static bool IsMuted { get; }
- public static FMOD.Studio.System StudioSystem { get; }

#### Constructors
- private static RuntimeManager()
- public RuntimeManager()

#### Methods
- public static bool AnyBankLoading()
- public static bool AnySampleDataLoading()
- private static void ApplyMuteState()
- public static void AttachInstanceToGameObject(FMOD.Studio.EventInstance instance, UnityEngine.GameObject gameObject, bool nonRigidbodyVelocity = false)
- public static void AttachInstanceToGameObject(FMOD.Studio.EventInstance instance, UnityEngine.Transform transform, bool nonRigidbodyVelocity = false)
- public static void AttachInstanceToGameObject(FMOD.Studio.EventInstance instance, UnityEngine.GameObject gameObject, UnityEngine.Rigidbody rigidBody)
- public static void AttachInstanceToGameObject(FMOD.Studio.EventInstance instance, UnityEngine.Transform transform, UnityEngine.Rigidbody rigidBody)
- public static void AttachInstanceToGameObject(FMOD.Studio.EventInstance instance, UnityEngine.GameObject gameObject, UnityEngine.Rigidbody2D rigidBody2D)
- public static void AttachInstanceToGameObject(FMOD.Studio.EventInstance instance, UnityEngine.Transform transform, UnityEngine.Rigidbody2D rigidBody2D)
- private System.Collections.Generic.IEnumerable<string> BanksToLoad(FMODUnity.Settings fmodSettings)
- private void CheckInitResult(FMOD.RESULT result, string cause)
- public static FMOD.Studio.EventInstance CreateInstance(FMODUnity.EventReference eventReference)
- public static FMOD.Studio.EventInstance CreateInstance(string path)
- public static FMOD.Studio.EventInstance CreateInstance(FMOD.GUID guid)
- private static FMOD.RESULT DEBUG_CALLBACK(FMOD.DEBUG_FLAGS flags, System.IntPtr filePtr, int line, System.IntPtr funcPtr, System.IntPtr messagePtr)
- public static void DetachInstanceFromGameObject(FMOD.Studio.EventInstance instance)
- private void DrawDebugOverlay(int windowID)
- private static FMOD.RESULT ERROR_CALLBACK(System.IntPtr system, FMOD.SYSTEM_CALLBACK_TYPE type, System.IntPtr commanddata1, System.IntPtr commanddata2, System.IntPtr userdata)
- internal void ExecuteOnGUI()
- private void ExecuteSampleLoadRequestsIfReady()
- private static FMODUnity.RuntimeManager.AttachedInstance FindOrAddAttachedInstance(FMOD.Studio.EventInstance instance, UnityEngine.Transform transform, FMOD.ATTRIBUTES_3D attributes)
- public static FMOD.Studio.Bus GetBus(string path)
- private int GetChannelCountForFormat(FMODUnity.CodecType format)
- public static FMOD.Studio.EventDescription GetEventDescription(FMODUnity.EventReference eventReference)
- public static FMOD.Studio.EventDescription GetEventDescription(string path)
- public static FMOD.Studio.EventDescription GetEventDescription(FMOD.GUID guid)
- public static FMOD.Studio.VCA GetVCA(string path)
- public static bool HasBankLoaded(string loadedBank)
- private FMOD.RESULT Initialize()
- public static void LoadBank(string bankName, bool loadSamples = false)
- private static void LoadBank(string bankName, bool loadSamples, string bankId)
- public static void LoadBank(UnityEngine.TextAsset asset, bool loadSamples = false)
- private static void LoadBank(UnityEngine.TextAsset asset, bool loadSamples, string bankId)
- private void LoadBanks(FMODUnity.Settings fmodSettings)
- public static void MuteAllEvents(bool muted)
- private void OnApplicationPause(bool pauseStatus)
- private void OnDestroy()
- public static FMODUnity.EventReference PathToEventReference(string path)
- public static FMOD.GUID PathToGUID(string path)
- public static void PauseAllEvents(bool paused)
- public static void PlayOneShot(FMODUnity.EventReference eventReference, UnityEngine.Vector3 position = null)
- public static void PlayOneShot(string path, UnityEngine.Vector3 position = null)
- public static void PlayOneShot(FMOD.GUID guid, UnityEngine.Vector3 position = null)
- public static void PlayOneShotAttached(FMODUnity.EventReference eventReference, UnityEngine.GameObject gameObject)
- public static void PlayOneShotAttached(string path, UnityEngine.GameObject gameObject)
- public static void PlayOneShotAttached(FMOD.GUID guid, UnityEngine.GameObject gameObject)
- private static void ReferenceLoadedBank(string bankName, bool loadSamples)
- private void RegisterLoadedBank(FMODUnity.RuntimeManager.LoadedBank loadedBank, string bankPath, string bankName, bool loadSamples, FMOD.RESULT loadResult)
- private void ReleaseStudioSystem()
- public static void SetListenerLocation(UnityEngine.GameObject gameObject, UnityEngine.Rigidbody rigidBody, UnityEngine.GameObject attenuationObject = null)
- public static void SetListenerLocation(int listenerIndex, UnityEngine.GameObject gameObject, UnityEngine.Rigidbody rigidBody, UnityEngine.GameObject attenuationObject = null)
- public static void SetListenerLocation(UnityEngine.GameObject gameObject, UnityEngine.Rigidbody2D rigidBody2D, UnityEngine.GameObject attenuationObject = null)
- public static void SetListenerLocation(int listenerIndex, UnityEngine.GameObject gameObject, UnityEngine.Rigidbody2D rigidBody2D, UnityEngine.GameObject attenuationObject = null)
- public static void SetListenerLocation(int listenerIndex, UnityEngine.GameObject gameObject, UnityEngine.GameObject attenuationObject = null, UnityEngine.Vector3 velocity = null)
- public static void SetListenerLocation(UnityEngine.GameObject gameObject, UnityEngine.GameObject attenuationObject = null)
- public static void SetListenerLocation(int listenerIndex, UnityEngine.GameObject gameObject, UnityEngine.GameObject attenuationObject = null)
- private void SetOverlayPosition()
- private static void SetThreadAffinities(FMODUnity.Platform platform)
- private void Start()
- public static void UnloadBank(string bankName)
- public static void UnloadBank(UnityEngine.TextAsset asset)
- private void Update()
- private void UpdateDebugText()
- public static void WaitForAllLoads()
- public static void WaitForAllSampleLoading()

### public static class FMODUnity.RuntimeUtils

#### Methods
- public static void DebugLog(string message)
- public static void DebugLogError(string message)
- public static void DebugLogErrorFormat(string format, params object[] args)
- public static void DebugLogException(System.Exception e)
- public static void DebugLogFormat(string format, params object[] args)
- public static void DebugLogWarning(string message)
- public static void DebugLogWarningFormat(string format, params object[] args)
- public static string DisplayName(FMODUnity.ThreadType thread)
- public static void EnforceLibraryOrder()
- public static string GetCommonPlatformPath(string path)
- private static void SetFMODAffinityBit(FMODUnity.ThreadAffinity affinity, FMODUnity.ThreadAffinity mask, FMOD.THREAD_AFFINITY fmodMask, ref FMOD.THREAD_AFFINITY fmodAffinity)
- public static FMOD.ATTRIBUTES_3D To3DAttributes(UnityEngine.Vector3 pos)
- public static FMOD.ATTRIBUTES_3D To3DAttributes(UnityEngine.Transform transform)
- public static FMOD.ATTRIBUTES_3D To3DAttributes(UnityEngine.Transform transform, UnityEngine.Vector3 velocity)
- public static FMOD.ATTRIBUTES_3D To3DAttributes(UnityEngine.GameObject go)
- public static FMOD.ATTRIBUTES_3D To3DAttributes(UnityEngine.Transform transform, UnityEngine.Rigidbody rigidbody = null)
- public static FMOD.ATTRIBUTES_3D To3DAttributes(UnityEngine.GameObject go, UnityEngine.Rigidbody rigidbody)
- public static FMOD.ATTRIBUTES_3D To3DAttributes(UnityEngine.Transform transform, UnityEngine.Rigidbody2D rigidbody)
- public static FMOD.ATTRIBUTES_3D To3DAttributes(UnityEngine.GameObject go, UnityEngine.Rigidbody2D rigidbody)
- public static FMOD.THREAD_AFFINITY ToFMODThreadAffinity(FMODUnity.ThreadAffinity affinity)
- public static FMOD.THREAD_TYPE ToFMODThreadType(FMODUnity.ThreadType threadType)
- public static FMOD.VECTOR ToFMODVector(UnityEngine.Vector3 vec)

### public enum FMODUnity.ScreenPosition
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BottomCenter = 4
- BottomLeft = 3
- BottomRight = 5
- Center = 6
- TopCenter = 1
- TopLeft = 0
- TopRight = 2
- VR = 7

### public class FMODUnity.Settings
- Base: UnityEngine.ScriptableObject

#### Fields
- public bool AndroidPatchBuild
- public bool AndroidUseOBB
- public bool AutomaticEventLoading
- public bool AutomaticSampleLoading
- internal System.Collections.Generic.List<FMODUnity.Legacy.PlatformStringSetting> BankDirectorySettings
- public FMODUnity.BankLoadType BankLoadType
- public int BankRefreshCooldown
- internal static const int BankRefreshManual
- internal static const int BankRefreshPrompt
- public System.Collections.Generic.List<string> Banks
- public System.Collections.Generic.List<string> BanksToLoad
- internal bool BoltUnitOptionsBuildPending
- internal int CurrentVersion
- public FMODUnity.Platform DefaultPlatform
- private static FMODUnity.IEditorSettings editorSettings
- public bool EnableErrorCallback
- public bool EnableMemoryTracking
- public string EncryptionKey
- public FMODUnity.EventLinkage EventLinkage
- private bool hasLoaded
- public bool HasPlatforms
- public bool HasSourceProject
- public bool HideSetupWizard
- public FMODUnity.ImportType ImportType
- private static FMODUnity.Settings instance
- private static bool isInitializing
- internal int LastEventReferenceScanVersion
- public ushort LiveUpdatePort
- internal System.Collections.Generic.List<FMODUnity.Legacy.PlatformBoolSetting> LiveUpdateSettings
- public FMOD.DEBUG_FLAGS LoggingLevel
- public System.Collections.Generic.List<string> MasterBanks
- public FMODUnity.MeterChannelOrderingType MeterChannelOrdering
- internal System.Collections.Generic.List<FMODUnity.Legacy.PlatformBoolSetting> OverlaySettings
- internal System.Collections.Generic.Dictionary<UnityEngine.RuntimePlatform, System.Collections.Generic.List<FMODUnity.Platform>> PlatformForRuntimePlatform
- public System.Collections.Generic.List<FMODUnity.Platform> Platforms
- internal static System.Collections.Generic.List<FMODUnity.Settings.PlatformTemplate> PlatformTemplates
- public FMODUnity.Platform PlayInEditorPlatform
- internal System.Collections.Generic.List<string> Plugins
- internal System.Collections.Generic.List<FMODUnity.Legacy.PlatformIntSetting> RealChannelSettings
- internal System.Collections.Generic.List<FMODUnity.Legacy.PlatformIntSetting> SampleRateSettings
- internal static const string SettingsAssetName
- internal double SharedLibraryTimeSinceStart
- internal FMODUnity.Settings.SharedLibraryUpdateStages SharedLibraryUpdateStage
- public bool ShowBankRefreshWindow
- private string sourceBankPath
- private string sourceBankPathUnformatted
- private string sourceProjectPath
- internal System.Collections.Generic.List<FMODUnity.Legacy.PlatformIntSetting> SpeakerModeSettings
- public bool StopEventsOutsideMaxDistance
- public string TargetAssetPath
- public string TargetBankFolder
- internal System.Collections.Generic.List<FMODUnity.Legacy.PlatformIntSetting> VirtualChannelSettings

#### Properties
- internal static FMODUnity.IEditorSettings EditorSettings { get; set; }
- public static FMODUnity.Settings Instance { get; }
- public string SourceBankPath { get; set; }
- public string SourceProjectPath { get; set; }
- internal string TargetPath { get; }
- public string TargetSubFolder { get; set; }

#### Constructors
- private Settings()
- private static Settings()

#### Methods
- internal void AddPlatform(FMODUnity.Platform platform)
- internal void AddPlatformProperties(FMODUnity.Platform platform)
- internal static void AddPlatformTemplate<T>(string identifier)
- private static FMODUnity.Platform CreatePlatformInstance<T>(string identifier)
- internal void DeclareRuntimePlatform(UnityEngine.RuntimePlatform runtimePlatform, FMODUnity.Platform platform)
- public FMODUnity.Platform FindCurrentPlatform()
- internal FMODUnity.Platform FindPlatform(string identifier)
- internal static void Initialize()
- internal static bool IsInitialized()
- internal void LinkPlatform(FMODUnity.Platform platform)
- private void LinkPlatformToParent(FMODUnity.Platform platform)
- internal void OnEnable()
- internal bool PlatformExists(string identifier)
- private void PopulatePlatformsFromAsset()
- internal void RemovePlatform(string identifier)
- public void SetPlatformParent(FMODUnity.Platform platform, FMODUnity.Platform newParent)

### internal enum FMODUnity.Settings.SharedLibraryUpdateStages
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CopyNewLibraries = 3
- DisableExistingLibraries = 1
- RestartUnity = 2
- Start = 0

### public enum FMODUnity.STOP_MODE
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AllowFadeout = 0
- Immediate = 1
- None = 2

### public class FMODUnity.StudioBankLoader
- Base: UnityEngine.MonoBehaviour

#### Fields
- public System.Collections.Generic.List<string> Banks
- public string CollisionTag
- private bool isQuitting
- public FMODUnity.LoaderGameEvent LoadEvent
- public bool PreloadSamples
- public FMODUnity.LoaderGameEvent UnloadEvent

#### Constructors
- public StudioBankLoader()

#### Methods
- private void HandleGameEvent(FMODUnity.LoaderGameEvent gameEvent)
- public void Load()
- private void OnApplicationQuit()
- private void OnDestroy()
- private void OnDisable()
- private void OnEnable()
- private void OnTriggerEnter(UnityEngine.Collider other)
- private void OnTriggerEnter2D(UnityEngine.Collider2D other)
- private void OnTriggerExit(UnityEngine.Collider other)
- private void OnTriggerExit2D(UnityEngine.Collider2D other)
- private void Start()
- public void Unload()

### public class FMODUnity.StudioEventEmitter
- Base: FMODUnity.EventHandler
- Interfaces: UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler

#### Fields
- private bool <IsActive>k__BackingField
- private static System.Collections.Generic.List<FMODUnity.StudioEventEmitter> activeEmitters
- public bool AllowFadeout
- private System.Collections.Generic.List<FMODUnity.ParamRef> cachedParams
- public string Event
- protected FMOD.Studio.EventDescription eventDescription
- public FMODUnity.EmitterGameEvent EventPlayTrigger
- public FMODUnity.EventReference EventReference
- public FMODUnity.EmitterGameEvent EventStopTrigger
- private bool hasTriggered
- protected FMOD.Studio.EventInstance instance
- private bool isOneshot
- private bool isQuitting
- public bool NonRigidbodyVelocity
- public bool OverrideAttenuation
- public float OverrideMaxDistance
- public float OverrideMinDistance
- public FMODUnity.ParamRef[] Params
- public bool Preload
- private static const string SnapshotString
- public bool TriggerOnce

#### Properties
- public FMOD.Studio.EventDescription EventDescription { get; }
- public FMOD.Studio.EventInstance EventInstance { get; }
- public bool IsActive { get; private set; }
- private float MaxDistance { get; }
- public FMODUnity.EmitterGameEvent PlayEvent { get; set; }
- public FMODUnity.EmitterGameEvent StopEvent { get; set; }

#### Constructors
- public StudioEventEmitter()
- private static StudioEventEmitter()

#### Methods
- private static void DeregisterActiveEmitter(FMODUnity.StudioEventEmitter emitter)
- protected override void HandleGameEvent(FMODUnity.EmitterGameEvent gameEvent)
- public bool IsPlaying()
- private void Lookup()
- private void OnApplicationQuit()
- protected override void OnDestroy()
- public void Play()
- private void PlayInstance()
- private static void RegisterActiveEmitter(FMODUnity.StudioEventEmitter emitter)
- public void SetParameter(string name, float value, bool ignoreseekspeed = false)
- public void SetParameter(FMOD.Studio.PARAMETER_ID id, float value, bool ignoreseekspeed = false)
- protected override void Start()
- public void Stop()
- private void StopInstance()
- public static void UpdateActiveEmitters()
- private void UpdatePlayingStatus(bool force = false)

### public class FMODUnity.StudioGlobalParameterTrigger
- Base: FMODUnity.EventHandler
- Interfaces: UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler

#### Fields
- public string Parameter
- private FMOD.Studio.PARAMETER_DESCRIPTION parameterDescription
- public FMODUnity.EmitterGameEvent TriggerEvent
- public float Value

#### Properties
- public FMOD.Studio.PARAMETER_DESCRIPTION ParameterDescription { get; }

#### Constructors
- public StudioGlobalParameterTrigger()

#### Methods
- protected override void HandleGameEvent(FMODUnity.EmitterGameEvent gameEvent)
- public void TriggerParameters()

### public class FMODUnity.StudioListener
- Base: UnityEngine.MonoBehaviour

#### Fields
- private UnityEngine.GameObject attenuationObject
- private UnityEngine.Vector3 lastFramePosition
- private static System.Collections.Generic.List<FMODUnity.StudioListener> listeners
- private bool nonRigidbodyVelocity
- private UnityEngine.Rigidbody rigidBody
- private UnityEngine.Rigidbody2D rigidBody2D

#### Properties
- public static int ListenerCount { get; }
- public int ListenerNumber { get; }

#### Constructors
- public StudioListener()
- private static StudioListener()

#### Methods
- private static void AddListener(FMODUnity.StudioListener listener)
- public static float DistanceSquaredToNearestListener(UnityEngine.Vector3 position)
- public static float DistanceToNearestListener(UnityEngine.Vector3 position)
- private void OnDisable()
- private void OnEnable()
- private static void RemoveListener(FMODUnity.StudioListener listener)
- private void Update()

### public class FMODUnity.StudioParameterTrigger
- Base: FMODUnity.EventHandler
- Interfaces: UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler

#### Fields
- public FMODUnity.EmitterRef[] Emitters
- public FMODUnity.EmitterGameEvent TriggerEvent

#### Constructors
- public StudioParameterTrigger()

#### Methods
- private void Awake()
- protected override void HandleGameEvent(FMODUnity.EmitterGameEvent gameEvent)
- public void TriggerParameters()

### public class FMODUnity.SystemNotInitializedException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Fields
- public string Location
- public FMOD.RESULT Result

#### Constructors
- public SystemNotInitializedException(System.Exception inner)
- public SystemNotInitializedException(FMOD.RESULT result, string location)

### public enum FMODUnity.ThreadAffinity
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Any = 0
- Core0 = 1
- Core1 = 2
- Core10 = 1024
- Core11 = 2048
- Core12 = 4096
- Core13 = 8192
- Core14 = 16384
- Core15 = 32768
- Core2 = 4
- Core3 = 8
- Core4 = 16
- Core5 = 32
- Core6 = 64
- Core7 = 128
- Core8 = 256
- Core9 = 512

### public class FMODUnity.ThreadAffinityGroup

#### Fields
- public FMODUnity.ThreadAffinity affinity
- public System.Collections.Generic.List<FMODUnity.ThreadType> threads

#### Constructors
- public ThreadAffinityGroup()
- public ThreadAffinityGroup(FMODUnity.ThreadAffinityGroup other)
- public ThreadAffinityGroup(FMODUnity.ThreadAffinity affinity, params FMODUnity.ThreadType[] threads)

### public enum FMODUnity.ThreadType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Convolution_1 = 11
- Convolution_2 = 12
- Feeder = 1
- File = 3
- Geometry = 6
- Mixer = 0
- Nonblocking = 4
- Profiler = 7
- Record = 5
- Stream = 2
- Studio_Load_Bank = 9
- Studio_Load_Sample = 10
- Studio_Update = 8

### public enum FMODUnity.TriStateBool
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Development = 2
- Disabled = 0
- Enabled = 1

### public class FMODUnity.VCANotFoundException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Fields
- public string Path

#### Constructors
- public VCANotFoundException(string path)

