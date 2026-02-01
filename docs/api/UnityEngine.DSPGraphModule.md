# Assembly: UnityEngine.DSPGraphModule
- Path: tools/WorldBox.Managed/UnityEngine.DSPGraphModule.dll
- Types: 10

## Namespace: Unity.Audio

### internal struct Unity.Audio.AudioMemoryManager

#### Methods
- public static void* Internal_AllocateAudioMemory(int size, int alignment)
- public static void Internal_FreeAudioMemory(void* memory)

### internal struct Unity.Audio.AudioOutputHookManager

#### Methods
- public static void Internal_CreateAudioOutputHook(out Unity.Audio.Handle outputHook, void* jobReflectionData, void* jobData)
- public static void Internal_DisposeAudioOutputHook(ref Unity.Audio.Handle outputHook)

### internal struct Unity.Audio.DSPCommandBlockInternal

#### Methods
- public static void Internal_AddAttenuationKey(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle block, ref Unity.Audio.Handle connection, ulong dspClock, void* value, byte dimension)
- public static void Internal_AddFloatKey(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle block, ref Unity.Audio.Handle node, void* jobReflectionData, uint pIndex, ulong dspClock, float value)
- public static void Internal_AddInletPort(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle block, ref Unity.Audio.Handle node, int channelCount, int format)
- public static void Internal_AddOutletPort(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle block, ref Unity.Audio.Handle node, int channelCount, int format)
- public static void Internal_Cancel(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle block)
- public static void Internal_Complete(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle block)
- public static void Internal_Connect(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle block, ref Unity.Audio.Handle output, int outputPort, ref Unity.Audio.Handle input, int inputPort, ref Unity.Audio.Handle connection)
- public static void Internal_CreateDSPNode(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle block, ref Unity.Audio.Handle node, void* jobReflectionData, void* jobMemory, void* parameterDescriptionArray, int parameterCount, void* sampleProviderDescriptionArray, int sampleProviderCount)
- public static void Internal_CreateUpdateRequest(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle block, ref Unity.Audio.Handle node, ref Unity.Audio.Handle request, object callback, void* updateJobMem, void* updateJobReflectionData, void* nodeReflectionData)
- public static void Internal_Disconnect(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle block, ref Unity.Audio.Handle output, int outputPort, ref Unity.Audio.Handle input, int inputPort)
- public static void Internal_DisconnectByHandle(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle block, ref Unity.Audio.Handle connection)
- public static void Internal_InsertSampleProvider(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle block, ref Unity.Audio.Handle node, int item, int index, uint audioSampleProviderId, bool destroyOnRemove)
- public static void Internal_ReleaseDSPNode(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle block, ref Unity.Audio.Handle node)
- public static void Internal_RemoveSampleProvider(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle block, ref Unity.Audio.Handle node, int item, int index)
- public static void Internal_SetAttenuation(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle block, ref Unity.Audio.Handle connection, void* value, byte dimension, uint interpolationLength)
- public static void Internal_SetFloat(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle block, ref Unity.Audio.Handle node, void* jobReflectionData, uint pIndex, float value, uint interpolationLength)
- public static void Internal_SetSampleProvider(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle block, ref Unity.Audio.Handle node, int item, int index, uint audioSampleProviderId, bool destroyOnRemove)
- public static void Internal_SustainAttenuation(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle block, ref Unity.Audio.Handle connection, ulong dspClock)
- public static void Internal_SustainFloat(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle block, ref Unity.Audio.Handle node, void* jobReflectionData, uint pIndex, ulong dspClock)
- public static void Internal_UpdateAudioJob(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle block, ref Unity.Audio.Handle node, void* updateJobMem, void* updateJobReflectionData, void* nodeReflectionData)

### internal struct Unity.Audio.DSPGraphExecutionNode

#### Fields
- public int FenceCount
- public int FenceIndex
- public int FunctionIndex
- public void* JobData
- public void* JobStructData
- public void* ReflectionData
- public void* ResourceContext

### internal struct Unity.Audio.DSPGraphInternal

#### Methods
- public static uint Internal_AddNodeEventHandler(ref Unity.Audio.Handle graph, long eventTypeHashCode, object handler)
- public static Unity.Audio.Handle Internal_AllocateHandle(ref Unity.Audio.Handle graph)
- private static void Internal_AllocateHandle_Injected(ref Unity.Audio.Handle graph, out Unity.Audio.Handle ret)
- public static bool Internal_AssertMainThread(ref Unity.Audio.Handle graph)
- public static bool Internal_AssertMixerThread(ref Unity.Audio.Handle graph)
- public static void Internal_BeginMix(ref Unity.Audio.Handle graph, int frameCount, int executionMode)
- public static void Internal_CreateDSPCommandBlock(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle block)
- public static void Internal_CreateDSPGraph(out Unity.Audio.Handle graph, int outputFormat, uint outputChannels, uint dspBufferSize, uint sampleRate)
- public static void Internal_DisposeDSPGraph(ref Unity.Audio.Handle graph)
- public static void Internal_DisposeJob(void* jobStructData, void* jobReflectionData, void* resourceContext)
- public static void Internal_ExecuteJob(void* jobStructData, void* jobReflectionData, void* jobData, void* resourceContext)
- public static void Internal_ExecuteUpdateJob(void* updateStructMemory, void* updateReflectionData, void* jobStructMemory, void* jobReflectionData, void* resourceContext, ref Unity.Audio.Handle requestHandle, ref Unity.Jobs.JobHandle fence)
- public static ulong Internal_GetDSPClock(ref Unity.Audio.Handle graph)
- public static void Internal_GetRootDSP(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle root)
- public static void Internal_InitializeJob(void* jobStructData, void* jobReflectionData, void* resourceContext)
- public static void Internal_ReadMix(ref Unity.Audio.Handle graph, void* buffer, int frameCount)
- public static bool Internal_RemoveNodeEventHandler(ref Unity.Audio.Handle graph, uint handlerId)
- public static void Internal_ScheduleGraph(Unity.Jobs.JobHandle inputDeps, void* nodes, int nodeCount, int* childTable, void* dependencies)
- private static void Internal_ScheduleGraph_Injected(ref Unity.Jobs.JobHandle inputDeps, void* nodes, int nodeCount, int* childTable, void* dependencies)
- public static void Internal_SyncFenceNoWorkSteal(Unity.Jobs.JobHandle handle)
- private static void Internal_SyncFenceNoWorkSteal_Injected(ref Unity.Jobs.JobHandle handle)
- public static void Internal_Update(ref Unity.Audio.Handle graph)

### internal struct Unity.Audio.DSPNodeUpdateRequestHandleInternal

#### Methods
- public static void Internal_Dispose(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle requestHandle)
- public static void Internal_GetDSPNode(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle requestHandle, ref Unity.Audio.Handle node)
- public static void Internal_GetFence(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle requestHandle, ref Unity.Jobs.JobHandle fence)
- public static void* Internal_GetUpdateJobData(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle requestHandle)
- public static bool Internal_HasError(ref Unity.Audio.Handle graph, ref Unity.Audio.Handle requestHandle)

### internal struct Unity.Audio.DSPSampleProviderInternal

#### Methods
- public static ushort Internal_GetChannelCount(void* provider)
- public static ushort Internal_GetChannelCountById(uint providerId)
- public static uint Internal_GetSampleRate(void* provider)
- public static uint Internal_GetSampleRateById(uint providerId)
- public static int Internal_ReadFloatFromSampleProvider(void* provider, void* buffer, int length)
- public static int Internal_ReadFloatFromSampleProviderById(uint providerId, void* buffer, int length)
- public static int Internal_ReadSInt16FromSampleProvider(void* provider, int format, void* buffer, int length)
- public static int Internal_ReadSInt16FromSampleProviderById(uint providerId, int format, void* buffer, int length)
- public static int Internal_ReadUInt8FromSampleProvider(void* provider, int format, void* buffer, int length)
- public static int Internal_ReadUInt8FromSampleProviderById(uint providerId, int format, void* buffer, int length)

### internal struct Unity.Audio.ExecuteContextInternal

#### Methods
- public static void Internal_PostEvent(void* dspNodePtr, long eventTypeHashCode, void* eventPtr, int eventSize)

### internal struct Unity.Audio.Handle
- Interfaces: Unity.Audio.IHandle<Unity.Audio.Handle>, Unity.Audio.IValidatable, System.IEquatable<Unity.Audio.Handle>

#### Fields
- private System.IntPtr m_Node
- public int Version

#### Properties
- public bool Alive { get; }
- public Unity.Audio.Handle.Node* AtomicNode { get; set; }
- public int Id { get; set; }
- public bool Valid { get; }

#### Constructors
- public Handle(Unity.Audio.Handle.Node* node)

#### Methods
- public bool Equals(Unity.Audio.Handle other)
- public override bool Equals(object obj)
- public void FlushNode()
- public override int GetHashCode()

### internal struct Unity.Audio.Handle.Node

#### Fields
- public int DidAllocate
- public int Id
- public static const int InvalidId
- public long Next
- public int Version

