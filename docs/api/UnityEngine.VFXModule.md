# Assembly: UnityEngine.VFXModule
- Path: tools/WorldBox.Managed/UnityEngine.VFXModule.dll
- Types: 30

## Namespace: UnityEngine.Experimental.VFX

### internal static class UnityEngine.Experimental.VFX.VFXManager

## Namespace: UnityEngine.VFX

### public struct UnityEngine.VFX.VFXBatchedEffectInfo

#### Fields
- public uint activeBatchCount
- public uint activeInstanceCount
- public uint inactiveBatchCount
- public uint maxInstancePerBatchCapacity
- public ulong totalCPUSizeInBytes
- public ulong totalGPUSizeInBytes
- public uint totalInstanceCapacity
- public uint unbatchedInstanceCount
- public UnityEngine.VFX.VisualEffectAsset vfxAsset

### internal struct UnityEngine.VFX.VFXBatchInfo

#### Fields
- public uint activeInstanceCount
- public uint capacity

### public enum UnityEngine.VFX.VFXCameraBufferTypes
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Color = 2
- Depth = 1
- None = 0
- Normal = 4

### public struct UnityEngine.VFX.VFXCameraXRSettings

#### Fields
- public uint viewCount
- public uint viewOffset
- public uint viewTotal

### internal enum UnityEngine.VFX.VFXCullingFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CullBoundsUpdate = 2
- CullDefault = 3
- CullNone = 0
- CullSimulation = 1

### public class UnityEngine.VFX.VFXEventAttribute
- Interfaces: System.IDisposable

#### Fields
- private bool m_Owner
- private System.IntPtr m_Ptr
- private UnityEngine.VFX.VisualEffectAsset m_VfxAsset

#### Properties
- internal UnityEngine.VFX.VisualEffectAsset vfxAsset { get; }

#### Constructors
- private VFXEventAttribute()
- public VFXEventAttribute(UnityEngine.VFX.VFXEventAttribute original)
- private VFXEventAttribute(System.IntPtr ptr, bool owner, UnityEngine.VFX.VisualEffectAsset vfxAsset)

#### Methods
- public void CopyValuesFrom(UnityEngine.VFX.VFXEventAttribute eventAttibute)
- internal static UnityEngine.VFX.VFXEventAttribute CreateEventAttributeWrapper()
- public void Dispose()
- protected override void Finalize()
- public bool GetBool(int nameID)
- public bool GetBool(string name)
- public float GetFloat(int nameID)
- public float GetFloat(string name)
- public int GetInt(int nameID)
- public int GetInt(string name)
- public UnityEngine.Matrix4x4 GetMatrix4x4(int nameID)
- public UnityEngine.Matrix4x4 GetMatrix4x4(string name)
- private void GetMatrix4x4_Injected(int nameID, out UnityEngine.Matrix4x4 ret)
- public uint GetUint(int nameID)
- public uint GetUint(string name)
- public UnityEngine.Vector2 GetVector2(int nameID)
- public UnityEngine.Vector2 GetVector2(string name)
- private void GetVector2_Injected(int nameID, out UnityEngine.Vector2 ret)
- public UnityEngine.Vector3 GetVector3(int nameID)
- public UnityEngine.Vector3 GetVector3(string name)
- private void GetVector3_Injected(int nameID, out UnityEngine.Vector3 ret)
- public UnityEngine.Vector4 GetVector4(int nameID)
- public UnityEngine.Vector4 GetVector4(string name)
- private void GetVector4_Injected(int nameID, out UnityEngine.Vector4 ret)
- public bool HasBool(int nameID)
- public bool HasBool(string name)
- public bool HasFloat(int nameID)
- public bool HasFloat(string name)
- public bool HasInt(int nameID)
- public bool HasInt(string name)
- public bool HasMatrix4x4(int nameID)
- public bool HasMatrix4x4(string name)
- public bool HasUint(int nameID)
- public bool HasUint(string name)
- public bool HasVector2(int nameID)
- public bool HasVector2(string name)
- public bool HasVector3(int nameID)
- public bool HasVector3(string name)
- public bool HasVector4(int nameID)
- public bool HasVector4(string name)
- internal static System.IntPtr Internal_Create()
- internal static void Internal_Destroy(System.IntPtr ptr)
- internal void Internal_InitFromAsset(UnityEngine.VFX.VisualEffectAsset vfxAsset)
- internal void Internal_InitFromEventAttribute(UnityEngine.VFX.VFXEventAttribute vfxEventAttribute)
- internal static UnityEngine.VFX.VFXEventAttribute Internal_InstanciateVFXEventAttribute(UnityEngine.VFX.VisualEffectAsset vfxAsset)
- private void Release()
- public void SetBool(int nameID, bool b)
- public void SetBool(string name, bool b)
- public void SetFloat(int nameID, float f)
- public void SetFloat(string name, float f)
- public void SetInt(int nameID, int i)
- public void SetInt(string name, int i)
- public void SetMatrix4x4(int nameID, UnityEngine.Matrix4x4 v)
- public void SetMatrix4x4(string name, UnityEngine.Matrix4x4 v)
- private void SetMatrix4x4_Injected(int nameID, ref UnityEngine.Matrix4x4 v)
- public void SetUint(int nameID, uint i)
- public void SetUint(string name, uint i)
- public void SetVector2(int nameID, UnityEngine.Vector2 v)
- public void SetVector2(string name, UnityEngine.Vector2 v)
- private void SetVector2_Injected(int nameID, ref UnityEngine.Vector2 v)
- public void SetVector3(int nameID, UnityEngine.Vector3 v)
- public void SetVector3(string name, UnityEngine.Vector3 v)
- private void SetVector3_Injected(int nameID, ref UnityEngine.Vector3 v)
- public void SetVector4(int nameID, UnityEngine.Vector4 v)
- public void SetVector4(string name, UnityEngine.Vector4 v)
- private void SetVector4_Injected(int nameID, ref UnityEngine.Vector4 v)
- internal void SetWrapValue(System.IntPtr ptrToEventAttribute)

### public struct UnityEngine.VFX.VFXExposedProperty

#### Fields
- public string name
- public System.Type type

### internal enum UnityEngine.VFX.VFXExpressionOperation
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Abs = 29
- ACos = 27
- Add = 39
- ASin = 26
- ATan = 28
- ATan2 = 44
- BakeCurve = 74
- BakeGradient = 75
- BitwiseAnd = 79
- BitwiseComplement = 81
- BitwiseLeftShift = 76
- BitwiseOr = 78
- BitwiseRightShift = 77
- BitwiseXor = 80
- Branch = 97
- BufferCount = 137
- BufferStride = 136
- CastBoolToFloat = 93
- CastBoolToInt = 91
- CastBoolToUint = 92
- CastFloatToBool = 90
- CastFloatToInt = 86
- CastFloatToUint = 84
- CastIntToBool = 88
- CastIntToFloat = 83
- CastIntToUint = 85
- CastUintToBool = 89
- CastUintToFloat = 82
- CastUintToInt = 87
- Ceil = 32
- CellularCurlNoise2D = 127
- CellularCurlNoise3D = 128
- CellularNoise1D = 124
- CellularNoise2D = 125
- CellularNoise3D = 126
- Combine2f = 2
- Combine3f = 3
- Combine4f = 4
- Condition = 96
- Cos = 24
- DeltaTime = 6
- Divide = 38
- ExtractAnglesFromMatrix = 50
- ExtractAspectRatioFromMainCamera = 104
- ExtractComponent = 5
- ExtractFarPlaneFromMainCamera = 103
- ExtractFOVFromMainCamera = 101
- ExtractLensShiftFromMainCamera = 107
- ExtractMatrixFromMainCamera = 100
- ExtractNearPlaneFromMainCamera = 102
- ExtractPixelDimensionsFromMainCamera = 105
- ExtractPositionFromMatrix = 49
- ExtractScaledPixelDimensionsFromMainCamera = 106
- ExtractScaleFromMatrix = 51
- Floor = 35
- Frac = 34
- FrameIndex = 11
- GameDeltaTime = 16
- GameSmoothDeltaTime = 18
- GameTimeScale = 22
- GameTotalTime = 19
- GameTotalTimeSinceSceneLoad = 21
- GameUnscaledDeltaTime = 17
- GameUnscaledTotalTime = 20
- GenerateFixedRandom = 99
- GenerateRandom = 98
- GetBufferFromMainCamera = 108
- GetOrthographicSizeFromMainCamera = 110
- HSVtoRGB = 95
- IndexBufferFromMesh = 71
- InverseMatrix = 46
- InverseTRSMatrix = 47
- IsMainCameraOrthographic = 109
- LocalToWorld = 9
- Log2 = 36
- LogicalAnd = 111
- LogicalNot = 113
- LogicalOr = 112
- ManagerFixedTimeStep = 15
- ManagerMaxDeltaTime = 14
- MatrixToVector3s = 59
- MatrixToVector4s = 60
- Max = 42
- MeshChannelInfos = 132
- MeshChannelOffset = 131
- MeshFromSkinnedMeshRenderer = 72
- MeshIndexCount = 134
- MeshIndexFormat = 135
- MeshVertexCount = 130
- MeshVertexStride = 133
- Min = 41
- Mul = 37
- None = 0
- PerlinCurlNoise2D = 122
- PerlinCurlNoise3D = 123
- PerlinNoise1D = 119
- PerlinNoise2D = 120
- PerlinNoise3D = 121
- PlayRate = 12
- Pow = 43
- ReadEventAttribute = 141
- RGBtoHSV = 94
- RootBoneTransformFromSkinnedMeshRenderer = 73
- Round = 33
- SampleCurve = 61
- SampleGradient = 62
- SampleMeshIndex = 68
- SampleMeshVertexColor = 67
- SampleMeshVertexFloat = 63
- SampleMeshVertexFloat2 = 64
- SampleMeshVertexFloat3 = 65
- SampleMeshVertexFloat4 = 66
- Saturate = 31
- Sign = 30
- Sin = 23
- SpawnerStateDelayAfterLoop = 149
- SpawnerStateDelayBeforeLoop = 147
- SpawnerStateDeltaTime = 145
- SpawnerStateLoopCount = 151
- SpawnerStateLoopDuration = 148
- SpawnerStateLoopIndex = 150
- SpawnerStateLoopState = 143
- SpawnerStateNewLoop = 142
- SpawnerStateSpawnCount = 144
- SpawnerStateTotalTime = 146
- Subtract = 40
- SystemSeed = 8
- Tan = 25
- TextureDepth = 140
- TextureHeight = 139
- TextureWidth = 138
- TotalTime = 7
- TransformDir = 55
- TransformMatrix = 52
- TransformPos = 53
- TransformVec = 54
- TransformVector4 = 56
- TransposeMatrix = 48
- TRSToMatrix = 45
- UnscaledDeltaTime = 13
- Value = 1
- ValueCurlNoise2D = 117
- ValueCurlNoise3D = 118
- ValueNoise1D = 114
- ValueNoise2D = 115
- ValueNoise3D = 116
- Vector3sToMatrix = 57
- Vector4sToMatrix = 58
- VertexBufferFromMesh = 69
- VertexBufferFromSkinnedMeshRenderer = 70
- VoroNoise2D = 129
- WorldToLocal = 10

### public class UnityEngine.VFX.VFXExpressionValues

#### Fields
- internal System.IntPtr m_Ptr

#### Constructors
- private VFXExpressionValues()

#### Methods
- internal static UnityEngine.VFX.VFXExpressionValues CreateExpressionValuesWrapper(System.IntPtr ptr)
- public UnityEngine.AnimationCurve GetAnimationCurve(int nameID)
- public UnityEngine.AnimationCurve GetAnimationCurve(string name)
- public bool GetBool(int nameID)
- public bool GetBool(string name)
- public float GetFloat(int nameID)
- public float GetFloat(string name)
- public UnityEngine.Gradient GetGradient(int nameID)
- public UnityEngine.Gradient GetGradient(string name)
- public int GetInt(int nameID)
- public int GetInt(string name)
- public UnityEngine.Matrix4x4 GetMatrix4x4(int nameID)
- public UnityEngine.Matrix4x4 GetMatrix4x4(string name)
- private void GetMatrix4x4_Injected(int nameID, out UnityEngine.Matrix4x4 ret)
- public UnityEngine.Mesh GetMesh(int nameID)
- public UnityEngine.Mesh GetMesh(string name)
- public UnityEngine.Texture GetTexture(int nameID)
- public UnityEngine.Texture GetTexture(string name)
- public uint GetUInt(int nameID)
- public uint GetUInt(string name)
- public UnityEngine.Vector2 GetVector2(int nameID)
- public UnityEngine.Vector2 GetVector2(string name)
- private void GetVector2_Injected(int nameID, out UnityEngine.Vector2 ret)
- public UnityEngine.Vector3 GetVector3(int nameID)
- public UnityEngine.Vector3 GetVector3(string name)
- private void GetVector3_Injected(int nameID, out UnityEngine.Vector3 ret)
- public UnityEngine.Vector4 GetVector4(int nameID)
- public UnityEngine.Vector4 GetVector4(string name)
- private void GetVector4_Injected(int nameID, out UnityEngine.Vector4 ret)
- internal void Internal_GetAnimationCurveFromScript(int nameID, UnityEngine.AnimationCurve curve)
- internal void Internal_GetGradientFromScript(int nameID, UnityEngine.Gradient gradient)

### internal enum UnityEngine.VFX.VFXInstancingDisabledReason
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AutomaticBounds = 8
- ExposedObject = 32
- GPUEvent = 4
- IndirectDraw = 1
- MeshOutput = 16
- None = 0
- OutputEvent = 2
- Unknown = -1

### internal enum UnityEngine.VFX.VFXInstancingMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Auto = 0
- Custom = 1
- Disabled = -1

### internal enum UnityEngine.VFX.VFXMainCameraBufferFallback
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- NoFallback = 0
- PreferMainCamera = 1
- PreferSceneCamera = 2

### public static class UnityEngine.VFX.VFXManager

#### Fields
- private static readonly UnityEngine.VFX.VFXCameraXRSettings kDefaultCameraXRSettings

#### Properties
- internal static uint batchEmptyLifetime { get; set; }
- public static float fixedTimeStep { get; set; }
- public static float maxDeltaTime { get; set; }
- internal static float maxScrubTime { get; set; }
- internal static string renderPipeSettingsPath { get; }
- internal static UnityEngine.ScriptableObject runtimeResources { get; }

#### Constructors
- private static VFXManager()

#### Methods
- internal static void CleanupEmptyBatches(bool force = false)
- public static void FlushEmptyBatches()
- public static UnityEngine.VFX.VFXBatchedEffectInfo GetBatchedEffectInfo(UnityEngine.VFX.VisualEffectAsset vfx)
- public static void GetBatchedEffectInfos(System.Collections.Generic.List<UnityEngine.VFX.VFXBatchedEffectInfo> infos)
- private static void GetBatchedEffectInfo_Injected(UnityEngine.VFX.VisualEffectAsset vfx, out UnityEngine.VFX.VFXBatchedEffectInfo ret)
- internal static UnityEngine.VFX.VFXBatchInfo GetBatchInfo(UnityEngine.VFX.VisualEffectAsset vfx, uint batchIndex)
- private static void GetBatchInfo_Injected(UnityEngine.VFX.VisualEffectAsset vfx, uint batchIndex, out UnityEngine.VFX.VFXBatchInfo ret)
- public static UnityEngine.VFX.VisualEffect[] GetComponents()
- private static void Internal_ProcessCameraCommand(UnityEngine.Camera cam, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.VFX.VFXCameraXRSettings camXRSettings, System.IntPtr cullResults)
- private static void Internal_ProcessCameraCommand_Injected(UnityEngine.Camera cam, UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.VFX.VFXCameraXRSettings camXRSettings, System.IntPtr cullResults)
- public static UnityEngine.VFX.VFXCameraBufferTypes IsCameraBufferNeeded(UnityEngine.Camera cam)
- public static void PrepareCamera(UnityEngine.Camera cam)
- public static void PrepareCamera(UnityEngine.Camera cam, UnityEngine.VFX.VFXCameraXRSettings camXRSettings)
- private static void PrepareCamera_Injected(UnityEngine.Camera cam, ref UnityEngine.VFX.VFXCameraXRSettings camXRSettings)
- public static void ProcessCamera(UnityEngine.Camera cam)
- public static void ProcessCameraCommand(UnityEngine.Camera cam, UnityEngine.Rendering.CommandBuffer cmd)
- public static void ProcessCameraCommand(UnityEngine.Camera cam, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.VFX.VFXCameraXRSettings camXRSettings)
- public static void ProcessCameraCommand(UnityEngine.Camera cam, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.VFX.VFXCameraXRSettings camXRSettings, UnityEngine.Rendering.CullingResults results)
- public static void SetCameraBuffer(UnityEngine.Camera cam, UnityEngine.VFX.VFXCameraBufferTypes type, UnityEngine.Texture buffer, int x, int y, int width, int height)

### public struct UnityEngine.VFX.VFXOutputEventArgs

#### Fields
- private readonly UnityEngine.VFX.VFXEventAttribute <eventAttribute>k__BackingField
- private readonly int <nameId>k__BackingField

#### Properties
- public UnityEngine.VFX.VFXEventAttribute eventAttribute { get; }
- public int nameId { get; }

#### Constructors
- public VFXOutputEventArgs(int nameId, UnityEngine.VFX.VFXEventAttribute eventAttribute)

### public struct UnityEngine.VFX.VFXParticleSystemInfo

#### Fields
- public uint aliveCount
- public UnityEngine.Bounds bounds
- public uint capacity
- public bool sleeping

#### Constructors
- public VFXParticleSystemInfo(uint aliveCount, uint capacity, bool sleeping, UnityEngine.Bounds bounds)

### internal class UnityEngine.VFX.VFXRenderer
- Base: UnityEngine.Renderer

#### Constructors
- public VFXRenderer()

### internal enum UnityEngine.VFX.VFXSkinnedMeshFrame
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Current = 0
- Previous = 1

### internal enum UnityEngine.VFX.VFXSkinnedTransform
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- LocalRootBoneTransform = 0
- WorldRootBoneTransform = 1

### public class UnityEngine.VFX.VFXSpawnerCallbacks
- Base: UnityEngine.ScriptableObject

#### Constructors
- protected VFXSpawnerCallbacks()

#### Methods
- public abstract void OnPlay(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent)
- public abstract void OnStop(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent)
- public abstract void OnUpdate(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent)

### public enum UnityEngine.VFX.VFXSpawnerLoopState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DelayingAfterLoop = 3
- DelayingBeforeLoop = 1
- Finished = 0
- Looping = 2

### public class UnityEngine.VFX.VFXSpawnerState
- Interfaces: System.IDisposable

#### Fields
- private bool m_Owner
- private System.IntPtr m_Ptr
- private UnityEngine.VFX.VFXEventAttribute m_WrapEventAttribute

#### Properties
- public float delayAfterLoop { get; set; }
- public float delayBeforeLoop { get; set; }
- public float deltaTime { get; set; }
- public int loopCount { get; set; }
- public float loopDuration { get; set; }
- public int loopIndex { get; set; }
- public UnityEngine.VFX.VFXSpawnerLoopState loopState { get; set; }
- public bool newLoop { get; }
- public bool playing { get; set; }
- public float spawnCount { get; set; }
- public float totalTime { get; set; }
- public UnityEngine.VFX.VFXEventAttribute vfxEventAttribute { get; }

#### Constructors
- public VFXSpawnerState()
- internal VFXSpawnerState(System.IntPtr ptr, bool owner)

#### Methods
- internal static UnityEngine.VFX.VFXSpawnerState CreateSpawnerStateWrapper()
- public void Dispose()
- protected override void Finalize()
- internal System.IntPtr GetPtr()
- internal static System.IntPtr Internal_Create()
- private static void Internal_Destroy(System.IntPtr ptr)
- internal UnityEngine.VFX.VFXEventAttribute Internal_GetVFXEventAttribute()
- private void PrepareWrapper()
- private void Release()
- internal void SetWrapValue(System.IntPtr ptrToSpawnerState, System.IntPtr ptrToEventAttribute)

### internal enum UnityEngine.VFX.VFXSystemFlag
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- SystemAutomaticBounds = 32
- SystemDefault = 0
- SystemHasAttributeBuffer = 256
- SystemHasDirectLink = 128
- SystemHasIndirectBuffer = 2
- SystemHasKill = 1
- SystemHasStrips = 8
- SystemInWorldSpace = 64
- SystemNeedsComputeBounds = 16
- SystemReceivedEventGPU = 4
- SystemUsesInstancedRendering = 512

### internal enum UnityEngine.VFX.VFXSystemType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Mesh = 2
- OutputEvent = 3
- Particle = 1
- Spawner = 0

### internal enum UnityEngine.VFX.VFXTaskType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BurstSpawner = 268435457
- CameraSort = 805306369
- ConstantRateSpawner = 268435456
- CustomCallbackSpawner = 268435460
- EvaluateExpressionsSpawner = 268435462
- GlobalSort = 805306373
- Initialize = 536870912
- None = 0
- Output = 1073741824
- ParticleHexahedronOutput = 1073741827
- ParticleLineOutput = 1073741825
- ParticleMeshOutput = 1073741828
- ParticleOctagonOutput = 1073741830
- ParticlePointOutput = 1073741824
- ParticleQuadOutput = 1073741826
- ParticleTriangleOutput = 1073741829
- PerCameraSort = 805306371
- PerCameraUpdate = 805306370
- PeriodicBurstSpawner = 268435458
- PerOutputSort = 805306372
- SetAttributeSpawner = 268435461
- Spawner = 268435456
- Update = 805306368
- VariableRateSpawner = 268435459

### internal enum UnityEngine.VFX.VFXUpdateMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DeltaTime = 1
- DeltaTimeAndIgnoreTimeScale = 3
- ExactFixedTimeStep = 4
- FixedDeltaAndExactTime = 4
- FixedDeltaAndExactTimeAndIgnoreTimeScale = 6
- FixedDeltaTime = 0
- IgnoreTimeScale = 2

### internal enum UnityEngine.VFX.VFXValueType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Boolean = 18
- Buffer = 19
- CameraBuffer = 12
- ColorGradient = 15
- Curve = 14
- Float = 1
- Float2 = 2
- Float3 = 3
- Float4 = 4
- Int32 = 5
- Matrix4x4 = 13
- Mesh = 16
- None = 0
- SkinnedMeshRenderer = 20
- Spline = 17
- Texture2D = 7
- Texture2DArray = 8
- Texture3D = 9
- TextureCube = 10
- TextureCubeArray = 11
- Uint32 = 6

### public class UnityEngine.VFX.VisualEffect
- Base: UnityEngine.Behaviour

#### Fields
- private UnityEngine.VFX.VFXEventAttribute m_cachedEventAttribute
- public System.Action<UnityEngine.VFX.VFXOutputEventArgs> outputEventReceived

#### Properties
- public int aliveParticleCount { get; }
- public bool culled { get; }
- public int initialEventID { get; set; }
- public string initialEventName { get; set; }
- public bool pause { get; set; }
- public float playRate { get; set; }
- public bool resetSeedOnPlay { get; set; }
- public uint startSeed { get; set; }
- internal float time { get; }
- public UnityEngine.VFX.VisualEffectAsset visualEffectAsset { get; set; }

#### Constructors
- public VisualEffect()

#### Methods
- public void AdvanceOneFrame()
- private void CheckValidVFXEventAttribute(UnityEngine.VFX.VFXEventAttribute eventAttribute)
- public UnityEngine.VFX.VFXEventAttribute CreateVFXEventAttribute()
- public UnityEngine.AnimationCurve GetAnimationCurve(int nameID)
- public UnityEngine.AnimationCurve GetAnimationCurve(string name)
- public bool GetBool(int nameID)
- public bool GetBool(string name)
- internal UnityEngine.Bounds GetComputedBounds(int nameID)
- internal UnityEngine.Bounds GetComputedBounds(string name)
- private void GetComputedBounds_Injected(int nameID, out UnityEngine.Bounds ret)
- internal UnityEngine.Vector3 GetCurrentBoundsPadding(int nameID)
- internal UnityEngine.Vector3 GetCurrentBoundsPadding(string name)
- private void GetCurrentBoundsPadding_Injected(int nameID, out UnityEngine.Vector3 ret)
- public float GetFloat(int nameID)
- public float GetFloat(string name)
- public UnityEngine.Gradient GetGradient(int nameID)
- public UnityEngine.Gradient GetGradient(string name)
- internal UnityEngine.GraphicsBuffer GetGraphicsBuffer(int nameID)
- internal UnityEngine.GraphicsBuffer GetGraphicsBuffer(string name)
- public int GetInt(int nameID)
- public int GetInt(string name)
- public UnityEngine.Matrix4x4 GetMatrix4x4(int nameID)
- public UnityEngine.Matrix4x4 GetMatrix4x4(string name)
- private void GetMatrix4x4_Injected(int nameID, out UnityEngine.Matrix4x4 ret)
- public UnityEngine.Mesh GetMesh(int nameID)
- public UnityEngine.Mesh GetMesh(string name)
- public void GetOutputEventNames(System.Collections.Generic.List<string> names)
- public UnityEngine.VFX.VFXParticleSystemInfo GetParticleSystemInfo(int nameID)
- public UnityEngine.VFX.VFXParticleSystemInfo GetParticleSystemInfo(string name)
- private void GetParticleSystemInfo_Injected(int nameID, out UnityEngine.VFX.VFXParticleSystemInfo ret)
- public void GetParticleSystemNames(System.Collections.Generic.List<string> names)
- public UnityEngine.SkinnedMeshRenderer GetSkinnedMeshRenderer(int nameID)
- public UnityEngine.SkinnedMeshRenderer GetSkinnedMeshRenderer(string name)
- private void GetSpawnSystemInfo(int nameID, System.IntPtr spawnerState)
- public void GetSpawnSystemInfo(int nameID, UnityEngine.VFX.VFXSpawnerState spawnState)
- public UnityEngine.VFX.VFXSpawnerState GetSpawnSystemInfo(int nameID)
- public UnityEngine.VFX.VFXSpawnerState GetSpawnSystemInfo(string name)
- public void GetSpawnSystemNames(System.Collections.Generic.List<string> names)
- public void GetSystemNames(System.Collections.Generic.List<string> names)
- public UnityEngine.Texture GetTexture(int nameID)
- public UnityEngine.Texture GetTexture(string name)
- public UnityEngine.Rendering.TextureDimension GetTextureDimension(int nameID)
- public UnityEngine.Rendering.TextureDimension GetTextureDimension(string name)
- public uint GetUInt(int nameID)
- public uint GetUInt(string name)
- public UnityEngine.Vector2 GetVector2(int nameID)
- public UnityEngine.Vector2 GetVector2(string name)
- private void GetVector2_Injected(int nameID, out UnityEngine.Vector2 ret)
- public UnityEngine.Vector3 GetVector3(int nameID)
- public UnityEngine.Vector3 GetVector3(string name)
- private void GetVector3_Injected(int nameID, out UnityEngine.Vector3 ret)
- public UnityEngine.Vector4 GetVector4(int nameID)
- public UnityEngine.Vector4 GetVector4(string name)
- private void GetVector4_Injected(int nameID, out UnityEngine.Vector4 ret)
- public bool HasAnimationCurve(int nameID)
- public bool HasAnimationCurve(string name)
- public bool HasAnySystemAwake()
- public bool HasBool(int nameID)
- public bool HasBool(string name)
- public bool HasFloat(int nameID)
- public bool HasFloat(string name)
- public bool HasGradient(int nameID)
- public bool HasGradient(string name)
- public bool HasGraphicsBuffer(int nameID)
- public bool HasGraphicsBuffer(string name)
- public bool HasInt(int nameID)
- public bool HasInt(string name)
- public bool HasMatrix4x4(int nameID)
- public bool HasMatrix4x4(string name)
- public bool HasMesh(int nameID)
- public bool HasMesh(string name)
- public bool HasSkinnedMeshRenderer(int nameID)
- public bool HasSkinnedMeshRenderer(string name)
- public bool HasSystem(int nameID)
- public bool HasSystem(string name)
- public bool HasTexture(int nameID)
- public bool HasTexture(string name)
- public bool HasUInt(int nameID)
- public bool HasUInt(string name)
- public bool HasVector2(int nameID)
- public bool HasVector2(string name)
- public bool HasVector3(int nameID)
- public bool HasVector3(string name)
- public bool HasVector4(int nameID)
- public bool HasVector4(string name)
- private void Internal_GetAnimationCurve(int nameID, UnityEngine.AnimationCurve curve)
- private void Internal_GetGradient(int nameID, UnityEngine.Gradient gradient)
- private static UnityEngine.VFX.VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(UnityEngine.VFX.VisualEffect source)
- private static void InvokeOutputEventReceived_Internal(UnityEngine.VFX.VisualEffect source, int eventNameId)
- public void Play(UnityEngine.VFX.VFXEventAttribute eventAttribute)
- public void Play()
- internal void RecreateData()
- public void Reinit()
- internal void Reinit(bool sendInitialEventAndPrewarm = true)
- public void ResetOverride(int nameID)
- public void ResetOverride(string name)
- public void SendEvent(int eventNameID, UnityEngine.VFX.VFXEventAttribute eventAttribute)
- public void SendEvent(string eventName, UnityEngine.VFX.VFXEventAttribute eventAttribute)
- public void SendEvent(int eventNameID)
- public void SendEvent(string eventName)
- private void SendEventFromScript(int eventNameID, UnityEngine.VFX.VFXEventAttribute eventAttribute)
- public void SetAnimationCurve(int nameID, UnityEngine.AnimationCurve c)
- public void SetAnimationCurve(string name, UnityEngine.AnimationCurve c)
- public void SetBool(int nameID, bool b)
- public void SetBool(string name, bool b)
- public void SetFloat(int nameID, float f)
- public void SetFloat(string name, float f)
- public void SetGradient(int nameID, UnityEngine.Gradient g)
- public void SetGradient(string name, UnityEngine.Gradient g)
- public void SetGraphicsBuffer(int nameID, UnityEngine.GraphicsBuffer g)
- public void SetGraphicsBuffer(string name, UnityEngine.GraphicsBuffer g)
- public void SetInt(int nameID, int i)
- public void SetInt(string name, int i)
- public void SetMatrix4x4(int nameID, UnityEngine.Matrix4x4 v)
- public void SetMatrix4x4(string name, UnityEngine.Matrix4x4 v)
- private void SetMatrix4x4_Injected(int nameID, ref UnityEngine.Matrix4x4 v)
- public void SetMesh(int nameID, UnityEngine.Mesh m)
- public void SetMesh(string name, UnityEngine.Mesh m)
- public void SetSkinnedMeshRenderer(int nameID, UnityEngine.SkinnedMeshRenderer m)
- public void SetSkinnedMeshRenderer(string name, UnityEngine.SkinnedMeshRenderer m)
- public void SetTexture(int nameID, UnityEngine.Texture t)
- public void SetTexture(string name, UnityEngine.Texture t)
- public void SetUInt(int nameID, uint i)
- public void SetUInt(string name, uint i)
- public void SetVector2(int nameID, UnityEngine.Vector2 v)
- public void SetVector2(string name, UnityEngine.Vector2 v)
- private void SetVector2_Injected(int nameID, ref UnityEngine.Vector2 v)
- public void SetVector3(int nameID, UnityEngine.Vector3 v)
- public void SetVector3(string name, UnityEngine.Vector3 v)
- private void SetVector3_Injected(int nameID, ref UnityEngine.Vector3 v)
- public void SetVector4(int nameID, UnityEngine.Vector4 v)
- public void SetVector4(string name, UnityEngine.Vector4 v)
- private void SetVector4_Injected(int nameID, ref UnityEngine.Vector4 v)
- public void Simulate(float stepDeltaTime, uint stepCount = 1)
- public void Stop(UnityEngine.VFX.VFXEventAttribute eventAttribute)
- public void Stop()

### public class UnityEngine.VFX.VisualEffectAsset
- Base: UnityEngine.VFX.VisualEffectObject

#### Fields
- public static readonly int PlayEventID
- public static const string PlayEventName
- public static readonly int StopEventID
- public static const string StopEventName

#### Constructors
- public VisualEffectAsset()
- private static VisualEffectAsset()

#### Methods
- public void GetEvents(System.Collections.Generic.List<string> names)
- public void GetExposedProperties(System.Collections.Generic.List<UnityEngine.VFX.VFXExposedProperty> exposedProperties)
- internal void GetOutputEventNames(System.Collections.Generic.List<string> names)
- internal void GetParticleSystemNames(System.Collections.Generic.List<string> names)
- internal void GetSpawnSystemNames(System.Collections.Generic.List<string> names)
- internal void GetSystemNames(System.Collections.Generic.List<string> names)
- public UnityEngine.Rendering.TextureDimension GetTextureDimension(int nameID)
- public UnityEngine.Rendering.TextureDimension GetTextureDimension(string name)
- internal bool HasSystem(int nameID)

### public class UnityEngine.VFX.VisualEffectObject
- Base: UnityEngine.Object

#### Constructors
- protected VisualEffectObject()

