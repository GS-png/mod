# Assembly: UnityEngine.ParticleSystemModule
- Path: tools/WorldBox.Managed/UnityEngine.ParticleSystemModule.dll
- Types: 114

## Namespace: UnityEngine

### internal struct UnityEngine.ParticleSystemRenderer.BakeTextureOutput

#### Fields
- internal UnityEngine.Texture2D indices
- internal UnityEngine.Texture2D vertices

### public struct UnityEngine.ParticleSystem.Burst

#### Fields
- private UnityEngine.ParticleSystem.MinMaxCurve m_Count
- private float m_InvProbability
- private int m_RepeatCount
- private float m_RepeatInterval
- private float m_Time

#### Properties
- public UnityEngine.ParticleSystem.MinMaxCurve count { get; set; }
- public int cycleCount { get; set; }
- public short maxCount { get; set; }
- public short minCount { get; set; }
- public float probability { get; set; }
- public float repeatInterval { get; set; }
- public float time { get; set; }

#### Constructors
- public ParticleSystem.Burst(float _time, short _count)
- public ParticleSystem.Burst(float _time, UnityEngine.ParticleSystem.MinMaxCurve _count)
- public ParticleSystem.Burst(float _time, short _minCount, short _maxCount)
- public ParticleSystem.Burst(float _time, UnityEngine.ParticleSystem.MinMaxCurve _count, int _cycleCount, float _repeatInterval)
- public ParticleSystem.Burst(float _time, short _minCount, short _maxCount, int _cycleCount, float _repeatInterval)

### public struct UnityEngine.ParticleSystem.ColliderData

#### Fields
- internal int[] colliderIndices
- internal UnityEngine.Component[] colliders
- internal int[] particleStartIndices

#### Methods
- public UnityEngine.Component GetCollider(int particleIndex, int colliderIndex)
- public int GetColliderCount(int particleIndex)

### internal struct UnityEngine.ParticleSystem.PlaybackState.Collision

#### Fields
- public UnityEngine.ParticleSystem.PlaybackState.Seed4 m_Random

### public struct UnityEngine.ParticleSystem.CollisionModule

#### Fields
- internal UnityEngine.ParticleSystem m_ParticleSystem

#### Properties
- public UnityEngine.ParticleSystem.MinMaxCurve bounce { get; set; }
- public float bounceMultiplier { get; set; }
- public float colliderForce { get; set; }
- public UnityEngine.LayerMask collidesWith { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve dampen { get; set; }
- public float dampenMultiplier { get; set; }
- public bool enabled { get; set; }
- public bool enableDynamicColliders { get; set; }
- public bool enableInteriorCollisions { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve lifetimeLoss { get; set; }
- public float lifetimeLossMultiplier { get; set; }
- public int maxCollisionShapes { get; set; }
- public float maxKillSpeed { get; set; }
- public int maxPlaneCount { get; }
- public float minKillSpeed { get; set; }
- public UnityEngine.ParticleSystemCollisionMode mode { get; set; }
- public bool multiplyColliderForceByCollisionAngle { get; set; }
- public bool multiplyColliderForceByParticleSize { get; set; }
- public bool multiplyColliderForceByParticleSpeed { get; set; }
- public int planeCount { get; }
- public UnityEngine.ParticleSystemCollisionQuality quality { get; set; }
- public float radiusScale { get; set; }
- public bool sendCollisionMessages { get; set; }
- public UnityEngine.ParticleSystemCollisionType type { get; set; }
- public float voxelSize { get; set; }

#### Constructors
- internal ParticleSystem.CollisionModule(UnityEngine.ParticleSystem particleSystem)

#### Methods
- public void AddPlane(UnityEngine.Transform transform)
- private static void AddPlane_Injected(ref UnityEngine.ParticleSystem.CollisionModule _unity_self, UnityEngine.Transform transform)
- public UnityEngine.Transform GetPlane(int index)
- private static UnityEngine.Transform GetPlane_Injected(ref UnityEngine.ParticleSystem.CollisionModule _unity_self, int index)
- public void RemovePlane(int index)
- public void RemovePlane(UnityEngine.Transform transform)
- private void RemovePlaneObject(UnityEngine.Transform transform)
- private static void RemovePlaneObject_Injected(ref UnityEngine.ParticleSystem.CollisionModule _unity_self, UnityEngine.Transform transform)
- private static void RemovePlane_Injected(ref UnityEngine.ParticleSystem.CollisionModule _unity_self, int index)
- public void SetPlane(int index, UnityEngine.Transform transform)
- private static void SetPlane_Injected(ref UnityEngine.ParticleSystem.CollisionModule _unity_self, int index, UnityEngine.Transform transform)

### public struct UnityEngine.ParticleSystem.ColorBySpeedModule

#### Fields
- internal UnityEngine.ParticleSystem m_ParticleSystem

#### Properties
- public UnityEngine.ParticleSystem.MinMaxGradient color { get; set; }
- public bool enabled { get; set; }
- public UnityEngine.Vector2 range { get; set; }

#### Constructors
- internal ParticleSystem.ColorBySpeedModule(UnityEngine.ParticleSystem particleSystem)

### public struct UnityEngine.ParticleSystem.ColorOverLifetimeModule

#### Fields
- internal UnityEngine.ParticleSystem m_ParticleSystem

#### Properties
- public UnityEngine.ParticleSystem.MinMaxGradient color { get; set; }
- public bool enabled { get; set; }

#### Constructors
- internal ParticleSystem.ColorOverLifetimeModule(UnityEngine.ParticleSystem particleSystem)

### public struct UnityEngine.ParticleSystem.CustomDataModule

#### Fields
- internal UnityEngine.ParticleSystem m_ParticleSystem

#### Properties
- public bool enabled { get; set; }

#### Constructors
- internal ParticleSystem.CustomDataModule(UnityEngine.ParticleSystem particleSystem)

#### Methods
- public UnityEngine.ParticleSystem.MinMaxGradient GetColor(UnityEngine.ParticleSystemCustomData stream)
- private static void GetColor_Injected(ref UnityEngine.ParticleSystem.CustomDataModule _unity_self, UnityEngine.ParticleSystemCustomData stream, out UnityEngine.ParticleSystem.MinMaxGradient ret)
- public UnityEngine.ParticleSystemCustomDataMode GetMode(UnityEngine.ParticleSystemCustomData stream)
- private static UnityEngine.ParticleSystemCustomDataMode GetMode_Injected(ref UnityEngine.ParticleSystem.CustomDataModule _unity_self, UnityEngine.ParticleSystemCustomData stream)
- public UnityEngine.ParticleSystem.MinMaxCurve GetVector(UnityEngine.ParticleSystemCustomData stream, int component)
- public int GetVectorComponentCount(UnityEngine.ParticleSystemCustomData stream)
- private static int GetVectorComponentCount_Injected(ref UnityEngine.ParticleSystem.CustomDataModule _unity_self, UnityEngine.ParticleSystemCustomData stream)
- private static void GetVector_Injected(ref UnityEngine.ParticleSystem.CustomDataModule _unity_self, UnityEngine.ParticleSystemCustomData stream, int component, out UnityEngine.ParticleSystem.MinMaxCurve ret)
- public void SetColor(UnityEngine.ParticleSystemCustomData stream, UnityEngine.ParticleSystem.MinMaxGradient gradient)
- private static void SetColor_Injected(ref UnityEngine.ParticleSystem.CustomDataModule _unity_self, UnityEngine.ParticleSystemCustomData stream, ref UnityEngine.ParticleSystem.MinMaxGradient gradient)
- public void SetMode(UnityEngine.ParticleSystemCustomData stream, UnityEngine.ParticleSystemCustomDataMode mode)
- private static void SetMode_Injected(ref UnityEngine.ParticleSystem.CustomDataModule _unity_self, UnityEngine.ParticleSystemCustomData stream, UnityEngine.ParticleSystemCustomDataMode mode)
- public void SetVector(UnityEngine.ParticleSystemCustomData stream, int component, UnityEngine.ParticleSystem.MinMaxCurve curve)
- public void SetVectorComponentCount(UnityEngine.ParticleSystemCustomData stream, int count)
- private static void SetVectorComponentCount_Injected(ref UnityEngine.ParticleSystem.CustomDataModule _unity_self, UnityEngine.ParticleSystemCustomData stream, int count)
- private static void SetVector_Injected(ref UnityEngine.ParticleSystem.CustomDataModule _unity_self, UnityEngine.ParticleSystemCustomData stream, int component, ref UnityEngine.ParticleSystem.MinMaxCurve curve)

### internal struct UnityEngine.ParticleSystem.PlaybackState.Emission

#### Fields
- public float m_ParticleSpacing
- public UnityEngine.ParticleSystem.PlaybackState.Seed m_Random
- public float m_ToEmitAccumulator

### public struct UnityEngine.ParticleSystem.EmissionModule

#### Fields
- internal UnityEngine.ParticleSystem m_ParticleSystem

#### Properties
- public int burstCount { get; set; }
- public bool enabled { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve rate { get; set; }
- public float rateMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve rateOverDistance { get; set; }
- public float rateOverDistanceMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve rateOverTime { get; set; }
- public float rateOverTimeMultiplier { get; set; }
- public UnityEngine.ParticleSystemEmissionType type { get; set; }

#### Constructors
- internal ParticleSystem.EmissionModule(UnityEngine.ParticleSystem particleSystem)

#### Methods
- public UnityEngine.ParticleSystem.Burst GetBurst(int index)
- public int GetBursts(UnityEngine.ParticleSystem.Burst[] bursts)
- private static void GetBurst_Injected(ref UnityEngine.ParticleSystem.EmissionModule _unity_self, int index, out UnityEngine.ParticleSystem.Burst ret)
- public void SetBurst(int index, UnityEngine.ParticleSystem.Burst burst)
- public void SetBursts(UnityEngine.ParticleSystem.Burst[] bursts)
- public void SetBursts(UnityEngine.ParticleSystem.Burst[] bursts, int size)
- private static void SetBurst_Injected(ref UnityEngine.ParticleSystem.EmissionModule _unity_self, int index, ref UnityEngine.ParticleSystem.Burst burst)

### public struct UnityEngine.ParticleSystem.EmitParams

#### Fields
- private bool m_AngularVelocitySet
- private bool m_ApplyShapeToPosition
- private bool m_AxisOfRotationSet
- private bool m_MeshIndexSet
- private UnityEngine.ParticleSystem.Particle m_Particle
- private bool m_PositionSet
- private bool m_RandomSeedSet
- private bool m_RotationSet
- private bool m_StartColorSet
- private bool m_StartLifetimeSet
- private bool m_StartSizeSet
- private bool m_VelocitySet

#### Properties
- public float angularVelocity { get; set; }
- public UnityEngine.Vector3 angularVelocity3D { get; set; }
- public bool applyShapeToPosition { get; set; }
- public UnityEngine.Vector3 axisOfRotation { get; set; }
- public int meshIndex { set; }
- public UnityEngine.ParticleSystem.Particle particle { get; set; }
- public UnityEngine.Vector3 position { get; set; }
- public uint randomSeed { get; set; }
- public float rotation { get; set; }
- public UnityEngine.Vector3 rotation3D { get; set; }
- public UnityEngine.Color32 startColor { get; set; }
- public float startLifetime { get; set; }
- public float startSize { get; set; }
- public UnityEngine.Vector3 startSize3D { get; set; }
- public UnityEngine.Vector3 velocity { get; set; }

#### Methods
- public void ResetAngularVelocity()
- public void ResetAxisOfRotation()
- public void ResetMeshIndex()
- public void ResetPosition()
- public void ResetRandomSeed()
- public void ResetRotation()
- public void ResetStartColor()
- public void ResetStartLifetime()
- public void ResetStartSize()
- public void ResetVelocity()

### public struct UnityEngine.ParticleSystem.ExternalForcesModule

#### Fields
- internal UnityEngine.ParticleSystem m_ParticleSystem

#### Properties
- public bool enabled { get; set; }
- public int influenceCount { get; }
- public UnityEngine.ParticleSystemGameObjectFilter influenceFilter { get; set; }
- public UnityEngine.LayerMask influenceMask { get; set; }
- public float multiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve multiplierCurve { get; set; }

#### Constructors
- internal ParticleSystem.ExternalForcesModule(UnityEngine.ParticleSystem particleSystem)

#### Methods
- public void AddInfluence(UnityEngine.ParticleSystemForceField field)
- private static void AddInfluence_Injected(ref UnityEngine.ParticleSystem.ExternalForcesModule _unity_self, UnityEngine.ParticleSystemForceField field)
- public UnityEngine.ParticleSystemForceField GetInfluence(int index)
- private static UnityEngine.ParticleSystemForceField GetInfluence_Injected(ref UnityEngine.ParticleSystem.ExternalForcesModule _unity_self, int index)
- public bool IsAffectedBy(UnityEngine.ParticleSystemForceField field)
- private static bool IsAffectedBy_Injected(ref UnityEngine.ParticleSystem.ExternalForcesModule _unity_self, UnityEngine.ParticleSystemForceField field)
- public void RemoveAllInfluences()
- private static void RemoveAllInfluences_Injected(ref UnityEngine.ParticleSystem.ExternalForcesModule _unity_self)
- public void RemoveInfluence(int index)
- public void RemoveInfluence(UnityEngine.ParticleSystemForceField field)
- private void RemoveInfluenceAtIndex(int index)
- private static void RemoveInfluenceAtIndex_Injected(ref UnityEngine.ParticleSystem.ExternalForcesModule _unity_self, int index)
- private static void RemoveInfluence_Injected(ref UnityEngine.ParticleSystem.ExternalForcesModule _unity_self, UnityEngine.ParticleSystemForceField field)
- public void SetInfluence(int index, UnityEngine.ParticleSystemForceField field)
- private static void SetInfluence_Injected(ref UnityEngine.ParticleSystem.ExternalForcesModule _unity_self, int index, UnityEngine.ParticleSystemForceField field)

### private enum UnityEngine.ParticleSystem.Particle.Flags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- MeshIndex = 4
- Rotation3D = 2
- Size3D = 1

### internal struct UnityEngine.ParticleSystem.PlaybackState.Force

#### Fields
- public UnityEngine.ParticleSystem.PlaybackState.Seed4 m_Random

### public struct UnityEngine.ParticleSystem.ForceOverLifetimeModule

#### Fields
- internal UnityEngine.ParticleSystem m_ParticleSystem

#### Properties
- public bool enabled { get; set; }
- public bool randomized { get; set; }
- public UnityEngine.ParticleSystemSimulationSpace space { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve x { get; set; }
- public float xMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve y { get; set; }
- public float yMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve z { get; set; }
- public float zMultiplier { get; set; }

#### Constructors
- internal ParticleSystem.ForceOverLifetimeModule(UnityEngine.ParticleSystem particleSystem)

### public struct UnityEngine.ParticleSystem.InheritVelocityModule

#### Fields
- internal UnityEngine.ParticleSystem m_ParticleSystem

#### Properties
- public UnityEngine.ParticleSystem.MinMaxCurve curve { get; set; }
- public float curveMultiplier { get; set; }
- public bool enabled { get; set; }
- public UnityEngine.ParticleSystemInheritVelocityMode mode { get; set; }

#### Constructors
- internal ParticleSystem.InheritVelocityModule(UnityEngine.ParticleSystem particleSystem)

### internal struct UnityEngine.ParticleSystem.PlaybackState.Initial

#### Fields
- public UnityEngine.ParticleSystem.PlaybackState.Seed4 m_Random

### public struct UnityEngine.ParticleSystem.LifetimeByEmitterSpeedModule

#### Fields
- internal UnityEngine.ParticleSystem m_ParticleSystem

#### Properties
- public UnityEngine.ParticleSystem.MinMaxCurve curve { get; set; }
- public float curveMultiplier { get; set; }
- public bool enabled { get; set; }
- public UnityEngine.Vector2 range { get; set; }

#### Constructors
- internal ParticleSystem.LifetimeByEmitterSpeedModule(UnityEngine.ParticleSystem particleSystem)

### internal struct UnityEngine.ParticleSystem.PlaybackState.Lights

#### Fields
- public float m_ParticleEmissionCounter
- public UnityEngine.ParticleSystem.PlaybackState.Seed m_Random

### public struct UnityEngine.ParticleSystem.LightsModule

#### Fields
- internal UnityEngine.ParticleSystem m_ParticleSystem

#### Properties
- public bool alphaAffectsIntensity { get; set; }
- public bool enabled { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve intensity { get; set; }
- public float intensityMultiplier { get; set; }
- public UnityEngine.Light light { get; set; }
- public int maxLights { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve range { get; set; }
- public float rangeMultiplier { get; set; }
- public float ratio { get; set; }
- public bool sizeAffectsRange { get; set; }
- public bool useParticleColor { get; set; }
- public bool useRandomDistribution { get; set; }

#### Constructors
- internal ParticleSystem.LightsModule(UnityEngine.ParticleSystem particleSystem)

### public struct UnityEngine.ParticleSystem.LimitVelocityOverLifetimeModule

#### Fields
- internal UnityEngine.ParticleSystem m_ParticleSystem

#### Properties
- public float dampen { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve drag { get; set; }
- public float dragMultiplier { get; set; }
- public bool enabled { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve limit { get; set; }
- public float limitMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve limitX { get; set; }
- public float limitXMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve limitY { get; set; }
- public float limitYMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve limitZ { get; set; }
- public float limitZMultiplier { get; set; }
- public bool multiplyDragByParticleSize { get; set; }
- public bool multiplyDragByParticleVelocity { get; set; }
- public bool separateAxes { get; set; }
- public UnityEngine.ParticleSystemSimulationSpace space { get; set; }

#### Constructors
- internal ParticleSystem.LimitVelocityOverLifetimeModule(UnityEngine.ParticleSystem particleSystem)

### public struct UnityEngine.ParticleSystem.MainModule

#### Fields
- internal UnityEngine.ParticleSystem m_ParticleSystem

#### Properties
- public UnityEngine.ParticleSystemCullingMode cullingMode { get; set; }
- public UnityEngine.Transform customSimulationSpace { get; set; }
- public float duration { get; set; }
- public UnityEngine.Vector3 emitterVelocity { get; set; }
- public UnityEngine.ParticleSystemEmitterVelocityMode emitterVelocityMode { get; set; }
- public float flipRotation { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve gravityModifier { get; set; }
- public float gravityModifierMultiplier { get; set; }
- public UnityEngine.ParticleSystemGravitySource gravitySource { get; set; }
- public bool loop { get; set; }
- public int maxParticles { get; set; }
- public bool playOnAwake { get; set; }
- public bool prewarm { get; set; }
- public float randomizeRotationDirection { get; set; }
- public UnityEngine.Vector2 ringBufferLoopRange { get; set; }
- public UnityEngine.ParticleSystemRingBufferMode ringBufferMode { get; set; }
- public UnityEngine.ParticleSystemScalingMode scalingMode { get; set; }
- public UnityEngine.ParticleSystemSimulationSpace simulationSpace { get; set; }
- public float simulationSpeed { get; set; }
- public UnityEngine.ParticleSystem.MinMaxGradient startColor { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve startDelay { get; set; }
- public float startDelayMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve startLifetime { get; set; }
- public float startLifetimeMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve startRotation { get; set; }
- public bool startRotation3D { get; set; }
- public float startRotationMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve startRotationX { get; set; }
- public float startRotationXMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve startRotationY { get; set; }
- public float startRotationYMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve startRotationZ { get; set; }
- public float startRotationZMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve startSize { get; set; }
- public bool startSize3D { get; set; }
- public float startSizeMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve startSizeX { get; set; }
- public float startSizeXMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve startSizeY { get; set; }
- public float startSizeYMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve startSizeZ { get; set; }
- public float startSizeZMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve startSpeed { get; set; }
- public float startSpeedMultiplier { get; set; }
- public UnityEngine.ParticleSystemStopAction stopAction { get; set; }
- public bool useUnscaledTime { get; set; }

#### Constructors
- internal ParticleSystem.MainModule(UnityEngine.ParticleSystem particleSystem)

### public struct UnityEngine.ParticleSystem.MinMaxCurve

#### Fields
- private float m_ConstantMax
- private float m_ConstantMin
- private UnityEngine.AnimationCurve m_CurveMax
- private UnityEngine.AnimationCurve m_CurveMin
- private float m_CurveMultiplier
- private UnityEngine.ParticleSystemCurveMode m_Mode

#### Properties
- public float constant { get; set; }
- public float constantMax { get; set; }
- public float constantMin { get; set; }
- public UnityEngine.AnimationCurve curve { get; set; }
- public UnityEngine.AnimationCurve curveMax { get; set; }
- public UnityEngine.AnimationCurve curveMin { get; set; }
- public float curveMultiplier { get; set; }
- public UnityEngine.ParticleSystemCurveMode mode { get; set; }

#### Constructors
- public ParticleSystem.MinMaxCurve(float constant)
- public ParticleSystem.MinMaxCurve(float multiplier, UnityEngine.AnimationCurve curve)
- public ParticleSystem.MinMaxCurve(float min, float max)
- public ParticleSystem.MinMaxCurve(float multiplier, UnityEngine.AnimationCurve min, UnityEngine.AnimationCurve max)

#### Methods
- public float Evaluate(float time)
- public float Evaluate(float time, float lerpFactor)
- public static UnityEngine.ParticleSystem.MinMaxCurve op_Implicit(float constant)

### public struct UnityEngine.ParticleSystem.MinMaxGradient

#### Fields
- private UnityEngine.Color m_ColorMax
- private UnityEngine.Color m_ColorMin
- private UnityEngine.Gradient m_GradientMax
- private UnityEngine.Gradient m_GradientMin
- private UnityEngine.ParticleSystemGradientMode m_Mode

#### Properties
- public UnityEngine.Color color { get; set; }
- public UnityEngine.Color colorMax { get; set; }
- public UnityEngine.Color colorMin { get; set; }
- public UnityEngine.Gradient gradient { get; set; }
- public UnityEngine.Gradient gradientMax { get; set; }
- public UnityEngine.Gradient gradientMin { get; set; }
- public UnityEngine.ParticleSystemGradientMode mode { get; set; }

#### Constructors
- public ParticleSystem.MinMaxGradient(UnityEngine.Color color)
- public ParticleSystem.MinMaxGradient(UnityEngine.Gradient gradient)
- public ParticleSystem.MinMaxGradient(UnityEngine.Color min, UnityEngine.Color max)
- public ParticleSystem.MinMaxGradient(UnityEngine.Gradient min, UnityEngine.Gradient max)

#### Methods
- public UnityEngine.Color Evaluate(float time)
- public UnityEngine.Color Evaluate(float time, float lerpFactor)
- public static UnityEngine.ParticleSystem.MinMaxGradient op_Implicit(UnityEngine.Color color)
- public static UnityEngine.ParticleSystem.MinMaxGradient op_Implicit(UnityEngine.Gradient gradient)

### internal struct UnityEngine.ParticleSystem.PlaybackState.Noise

#### Fields
- public float m_ScrollOffset

### public struct UnityEngine.ParticleSystem.NoiseModule

#### Fields
- internal UnityEngine.ParticleSystem m_ParticleSystem

#### Properties
- public bool damping { get; set; }
- public bool enabled { get; set; }
- public float frequency { get; set; }
- public int octaveCount { get; set; }
- public float octaveMultiplier { get; set; }
- public float octaveScale { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve positionAmount { get; set; }
- public UnityEngine.ParticleSystemNoiseQuality quality { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve remap { get; set; }
- public bool remapEnabled { get; set; }
- public float remapMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve remapX { get; set; }
- public float remapXMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve remapY { get; set; }
- public float remapYMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve remapZ { get; set; }
- public float remapZMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve rotationAmount { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve scrollSpeed { get; set; }
- public float scrollSpeedMultiplier { get; set; }
- public bool separateAxes { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve sizeAmount { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve strength { get; set; }
- public float strengthMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve strengthX { get; set; }
- public float strengthXMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve strengthY { get; set; }
- public float strengthYMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve strengthZ { get; set; }
- public float strengthZMultiplier { get; set; }

#### Constructors
- internal ParticleSystem.NoiseModule(UnityEngine.ParticleSystem particleSystem)

### public struct UnityEngine.ParticleSystem.Particle

#### Fields
- private UnityEngine.Vector3 m_AngularVelocity
- private UnityEngine.Vector3 m_AnimatedVelocity
- private UnityEngine.Vector3 m_AxisOfRotation
- private float m_EmitAccumulator0
- private float m_EmitAccumulator1
- private uint m_Flags
- private UnityEngine.Vector3 m_InitialVelocity
- private float m_Lifetime
- private int m_MeshIndex
- private uint m_ParentRandomSeed
- private UnityEngine.Vector3 m_Position
- private uint m_RandomSeed
- private UnityEngine.Vector3 m_Rotation
- private UnityEngine.Color32 m_StartColor
- private float m_StartLifetime
- private UnityEngine.Vector3 m_StartSize
- private UnityEngine.Vector3 m_Velocity

#### Properties
- public float angularVelocity { get; set; }
- public UnityEngine.Vector3 angularVelocity3D { get; set; }
- public UnityEngine.Vector3 animatedVelocity { get; }
- public UnityEngine.Vector3 axisOfRotation { get; set; }
- public UnityEngine.Color32 color { get; set; }
- public float lifetime { get; set; }
- public UnityEngine.Vector3 position { get; set; }
- public uint randomSeed { get; set; }
- public float randomValue { get; set; }
- public float remainingLifetime { get; set; }
- public float rotation { get; set; }
- public UnityEngine.Vector3 rotation3D { get; set; }
- public float size { get; set; }
- public UnityEngine.Color32 startColor { get; set; }
- public float startLifetime { get; set; }
- public float startSize { get; set; }
- public UnityEngine.Vector3 startSize3D { get; set; }
- public UnityEngine.Vector3 totalVelocity { get; }
- public UnityEngine.Vector3 velocity { get; set; }

#### Methods
- public UnityEngine.Color32 GetCurrentColor(UnityEngine.ParticleSystem system)
- public float GetCurrentSize(UnityEngine.ParticleSystem system)
- public UnityEngine.Vector3 GetCurrentSize3D(UnityEngine.ParticleSystem system)
- public int GetMeshIndex(UnityEngine.ParticleSystem system)
- public void SetMeshIndex(int index)

### public struct UnityEngine.ParticleCollisionEvent

#### Fields
- internal int m_ColliderInstanceID
- internal UnityEngine.Vector3 m_Intersection
- internal UnityEngine.Vector3 m_Normal
- internal UnityEngine.Vector3 m_Velocity

#### Properties
- public UnityEngine.Component colliderComponent { get; }
- public UnityEngine.Vector3 intersection { get; }
- public UnityEngine.Vector3 normal { get; }
- public UnityEngine.Vector3 velocity { get; }

#### Methods
- private static UnityEngine.Component InstanceIDToColliderComponent(int instanceID)

### public static class UnityEngine.ParticlePhysicsExtensions

#### Methods
- public static int GetCollisionEvents(UnityEngine.ParticleSystem ps, UnityEngine.GameObject go, UnityEngine.ParticleCollisionEvent[] collisionEvents)
- public static int GetCollisionEvents(UnityEngine.ParticleSystem ps, UnityEngine.GameObject go, System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent> collisionEvents)
- public static int GetSafeCollisionEventSize(UnityEngine.ParticleSystem ps)
- public static int GetSafeTriggerParticlesSize(UnityEngine.ParticleSystem ps, UnityEngine.ParticleSystemTriggerEventType type)
- public static int GetTriggerParticles(UnityEngine.ParticleSystem ps, UnityEngine.ParticleSystemTriggerEventType type, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles)
- public static int GetTriggerParticles(UnityEngine.ParticleSystem ps, UnityEngine.ParticleSystemTriggerEventType type, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles, out UnityEngine.ParticleSystem.ColliderData colliderData)
- public static void SetTriggerParticles(UnityEngine.ParticleSystem ps, UnityEngine.ParticleSystemTriggerEventType type, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles, int offset, int count)
- public static void SetTriggerParticles(UnityEngine.ParticleSystem ps, UnityEngine.ParticleSystemTriggerEventType type, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles)

### public class UnityEngine.ParticleSystem
- Base: UnityEngine.Component

#### Properties
- public bool automaticCullingEnabled { get; }
- public UnityEngine.ParticleSystem.CollisionModule collision { get; }
- public UnityEngine.ParticleSystem.ColorBySpeedModule colorBySpeed { get; }
- public UnityEngine.ParticleSystem.ColorOverLifetimeModule colorOverLifetime { get; }
- public UnityEngine.ParticleSystem.CustomDataModule customData { get; }
- public float duration { get; }
- public UnityEngine.ParticleSystem.EmissionModule emission { get; }
- public float emissionRate { get; set; }
- public bool enableEmission { get; set; }
- public UnityEngine.ParticleSystem.ExternalForcesModule externalForces { get; }
- public UnityEngine.ParticleSystem.ForceOverLifetimeModule forceOverLifetime { get; }
- public float gravityModifier { get; set; }
- public bool has3DParticleRotations { get; }
- public bool hasNonUniformParticleSizes { get; }
- public UnityEngine.ParticleSystem.InheritVelocityModule inheritVelocity { get; }
- public bool isEmitting { get; }
- public bool isPaused { get; }
- public bool isPlaying { get; }
- public bool isStopped { get; }
- public UnityEngine.ParticleSystem.LifetimeByEmitterSpeedModule lifetimeByEmitterSpeed { get; }
- public UnityEngine.ParticleSystem.LightsModule lights { get; }
- public UnityEngine.ParticleSystem.LimitVelocityOverLifetimeModule limitVelocityOverLifetime { get; }
- public bool loop { get; set; }
- public UnityEngine.ParticleSystem.MainModule main { get; }
- public int maxParticles { get; set; }
- public UnityEngine.ParticleSystem.NoiseModule noise { get; }
- public int particleCount { get; }
- public float playbackSpeed { get; set; }
- public bool playOnAwake { get; set; }
- public bool proceduralSimulationSupported { get; }
- public uint randomSeed { get; set; }
- public UnityEngine.ParticleSystem.RotationBySpeedModule rotationBySpeed { get; }
- public UnityEngine.ParticleSystem.RotationOverLifetimeModule rotationOverLifetime { get; }
- public UnityEngine.ParticleSystemScalingMode scalingMode { get; set; }
- public UnityEngine.ParticleSystem.ShapeModule shape { get; }
- public UnityEngine.ParticleSystemSimulationSpace simulationSpace { get; set; }
- public UnityEngine.ParticleSystem.SizeBySpeedModule sizeBySpeed { get; }
- public UnityEngine.ParticleSystem.SizeOverLifetimeModule sizeOverLifetime { get; }
- public UnityEngine.Color startColor { get; set; }
- public float startDelay { get; set; }
- public float startLifetime { get; set; }
- public float startRotation { get; set; }
- public UnityEngine.Vector3 startRotation3D { get; set; }
- public float startSize { get; set; }
- public float startSpeed { get; set; }
- public UnityEngine.ParticleSystem.SubEmittersModule subEmitters { get; }
- public UnityEngine.ParticleSystem.TextureSheetAnimationModule textureSheetAnimation { get; }
- public float time { get; set; }
- public float totalTime { get; }
- public UnityEngine.ParticleSystem.TrailModule trails { get; }
- public UnityEngine.ParticleSystem.TriggerModule trigger { get; }
- public bool useAutoRandomSeed { get; set; }
- public UnityEngine.ParticleSystem.VelocityOverLifetimeModule velocityOverLifetime { get; }

#### Constructors
- public ParticleSystem()

#### Methods
- public void AllocateAxisOfRotationAttribute()
- public void AllocateCustomDataAttribute(UnityEngine.ParticleSystemCustomData stream)
- public void AllocateMeshIndexAttribute()
- public void Clear(bool withChildren)
- public void Clear()
- internal static void CopyManagedJobData(void* systemPtr, out UnityEngine.ParticleSystemJobs.NativeParticleData particleData)
- public void Emit(UnityEngine.Vector3 position, UnityEngine.Vector3 velocity, float size, float lifetime, UnityEngine.Color32 color)
- public void Emit(UnityEngine.ParticleSystem.Particle particle)
- public void Emit(int count)
- public void Emit(UnityEngine.ParticleSystem.EmitParams emitParams, int count)
- private void EmitOld_Internal(ref UnityEngine.ParticleSystem.Particle particle)
- private void Emit_Injected(ref UnityEngine.ParticleSystem.EmitParams emitParams, int count)
- private void Emit_Internal(int count)
- public int GetCustomParticleData(System.Collections.Generic.List<UnityEngine.Vector4> customData, UnityEngine.ParticleSystemCustomData streamIndex)
- internal void* GetManagedJobData()
- internal Unity.Jobs.JobHandle GetManagedJobHandle()
- private void GetManagedJobHandle_Injected(out Unity.Jobs.JobHandle ret)
- internal UnityEngine.Color32 GetParticleCurrentColor(ref UnityEngine.ParticleSystem.Particle particle)
- private void GetParticleCurrentColor_Injected(ref UnityEngine.ParticleSystem.Particle particle, out UnityEngine.Color32 ret)
- internal float GetParticleCurrentSize(ref UnityEngine.ParticleSystem.Particle particle)
- internal UnityEngine.Vector3 GetParticleCurrentSize3D(ref UnityEngine.ParticleSystem.Particle particle)
- private void GetParticleCurrentSize3D_Injected(ref UnityEngine.ParticleSystem.Particle particle, out UnityEngine.Vector3 ret)
- internal int GetParticleMeshIndex(ref UnityEngine.ParticleSystem.Particle particle)
- public int GetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size, int offset)
- public int GetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size)
- public int GetParticles(UnityEngine.ParticleSystem.Particle[] particles)
- public int GetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size, int offset)
- public int GetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size)
- public int GetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles)
- private int GetParticlesWithNativeArray(System.IntPtr particles, int particlesLength, int size, int offset)
- public UnityEngine.ParticleSystem.PlaybackState GetPlaybackState()
- private void GetPlaybackState_Injected(out UnityEngine.ParticleSystem.PlaybackState ret)
- private void GetTrailDataInternal(ref UnityEngine.ParticleSystem.Trails trailData)
- public UnityEngine.ParticleSystem.Trails GetTrails()
- public int GetTrails(ref UnityEngine.ParticleSystem.Trails trailData)
- public bool IsAlive(bool withChildren)
- public bool IsAlive()
- public void Pause(bool withChildren)
- public void Pause()
- public void Play(bool withChildren)
- public void Play()
- public static void ResetPreMappedBufferMemory()
- internal static Unity.Jobs.JobHandle ScheduleManagedJob(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* additionalData)
- private static void ScheduleManagedJob_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* additionalData, out Unity.Jobs.JobHandle ret)
- public void SetCustomParticleData(System.Collections.Generic.List<UnityEngine.Vector4> customData, UnityEngine.ParticleSystemCustomData streamIndex)
- internal void SetManagedJobHandle(Unity.Jobs.JobHandle handle)
- private void SetManagedJobHandle_Injected(ref Unity.Jobs.JobHandle handle)
- public static void SetMaximumPreMappedBufferCounts(int vertexBuffersCount, int indexBuffersCount)
- public void SetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size, int offset)
- public void SetParticles(UnityEngine.ParticleSystem.Particle[] particles, int size)
- public void SetParticles(UnityEngine.ParticleSystem.Particle[] particles)
- public void SetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size, int offset)
- public void SetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size)
- public void SetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles)
- private void SetParticlesWithNativeArray(System.IntPtr particles, int particlesLength, int size, int offset)
- public void SetPlaybackState(UnityEngine.ParticleSystem.PlaybackState playbackState)
- private void SetPlaybackState_Injected(ref UnityEngine.ParticleSystem.PlaybackState playbackState)
- public void SetTrails(UnityEngine.ParticleSystem.Trails trailData)
- private void SetTrails_Injected(ref UnityEngine.ParticleSystem.Trails trailData)
- public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep)
- public void Simulate(float t, bool withChildren, bool restart)
- public void Simulate(float t, bool withChildren)
- public void Simulate(float t)
- public void Stop(bool withChildren, UnityEngine.ParticleSystemStopBehavior stopBehavior)
- public void Stop(bool withChildren)
- public void Stop()
- public void TriggerSubEmitter(int subEmitterIndex)
- public void TriggerSubEmitter(int subEmitterIndex, ref UnityEngine.ParticleSystem.Particle particle)
- public void TriggerSubEmitter(int subEmitterIndex, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles)
- internal void TriggerSubEmitterForParticle(int subEmitterIndex, UnityEngine.ParticleSystem.Particle particle)
- private void TriggerSubEmitterForParticle_Injected(int subEmitterIndex, ref UnityEngine.ParticleSystem.Particle particle)
- internal static bool UserJobCanBeScheduled()

### public enum UnityEngine.ParticleSystemAnimationMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Grid = 0
- Sprites = 1

### public enum UnityEngine.ParticleSystemAnimationRowMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Custom = 0
- MeshIndex = 2
- Random = 1

### public enum UnityEngine.ParticleSystemAnimationTimeMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FPS = 2
- Lifetime = 0
- Speed = 1

### public enum UnityEngine.ParticleSystemAnimationType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- SingleRow = 1
- WholeSheet = 0

### public enum UnityEngine.ParticleSystemBakeMeshOptions
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BakePosition = 2
- BakeRotationAndScale = 1
- Default = 0

### public enum UnityEngine.ParticleSystemBakeTextureOptions
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BakePosition = 2
- BakeRotationAndScale = 1
- Default = 4
- IncludeParticleIndices = 16
- PerParticle = 8
- PerVertex = 4

### public enum UnityEngine.ParticleSystemColliderQueryMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- All = 2
- Disabled = 0
- One = 1

### public enum UnityEngine.ParticleSystemCollisionMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Collision2D = 1
- Collision3D = 0

### public enum UnityEngine.ParticleSystemCollisionQuality
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- High = 0
- Low = 2
- Medium = 1

### public enum UnityEngine.ParticleSystemCollisionType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Planes = 0
- World = 1

### public enum UnityEngine.ParticleSystemCullingMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AlwaysSimulate = 3
- Automatic = 0
- Pause = 2
- PauseAndCatchup = 1

### public enum UnityEngine.ParticleSystemCurveMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Constant = 0
- Curve = 1
- TwoConstants = 3
- TwoCurves = 2

### public enum UnityEngine.ParticleSystemCustomData
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Custom1 = 0
- Custom2 = 1

### public enum UnityEngine.ParticleSystemCustomDataMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Color = 2
- Disabled = 0
- Vector = 1

### public enum UnityEngine.ParticleSystemEmissionType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Distance = 1
- Time = 0

### public enum UnityEngine.ParticleSystemEmitterVelocityMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Custom = 2
- Rigidbody = 1
- Transform = 0

### internal class UnityEngine.ParticleSystemExtensionsImpl

#### Constructors
- public ParticleSystemExtensionsImpl()

#### Methods
- internal static int GetCollisionEvents(UnityEngine.ParticleSystem ps, UnityEngine.GameObject go, System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent> collisionEvents)
- internal static int GetCollisionEventsDeprecated(UnityEngine.ParticleSystem ps, UnityEngine.GameObject go, UnityEngine.ParticleCollisionEvent[] collisionEvents)
- internal static int GetSafeCollisionEventSize(UnityEngine.ParticleSystem ps)
- internal static int GetSafeTriggerParticlesSize(UnityEngine.ParticleSystem ps, int type)
- internal static int GetTriggerParticles(UnityEngine.ParticleSystem ps, int type, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles)
- internal static int GetTriggerParticlesWithData(UnityEngine.ParticleSystem ps, int type, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles, ref UnityEngine.ParticleSystem.ColliderData colliderData)
- internal static void SetTriggerParticles(UnityEngine.ParticleSystem ps, int type, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles, int offset, int count)

### public class UnityEngine.ParticleSystemForceField
- Base: UnityEngine.Behaviour

#### Properties
- public UnityEngine.ParticleSystem.MinMaxCurve directionX { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve directionY { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve directionZ { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve drag { get; set; }
- public float endRange { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve gravity { get; set; }
- public float gravityFocus { get; set; }
- public float length { get; set; }
- public bool multiplyDragByParticleSize { get; set; }
- public bool multiplyDragByParticleVelocity { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve rotationAttraction { get; set; }
- public UnityEngine.Vector2 rotationRandomness { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve rotationSpeed { get; set; }
- public UnityEngine.ParticleSystemForceFieldShape shape { get; set; }
- public float startRange { get; set; }
- public UnityEngine.Texture3D vectorField { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve vectorFieldAttraction { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve vectorFieldSpeed { get; set; }

#### Constructors
- public ParticleSystemForceField()

### public enum UnityEngine.ParticleSystemForceFieldShape
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Box = 3
- Cylinder = 2
- Hemisphere = 1
- Sphere = 0

### public enum UnityEngine.ParticleSystemGameObjectFilter
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- LayerMask = 0
- LayerMaskAndList = 2
- List = 1

### public enum UnityEngine.ParticleSystemGradientMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Color = 0
- Gradient = 1
- RandomColor = 4
- TwoColors = 2
- TwoGradients = 3

### public enum UnityEngine.ParticleSystemGravitySource
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Physics2D = 1
- Physics3D = 0

### public enum UnityEngine.ParticleSystemInheritVelocityMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Current = 1
- Initial = 0

### public enum UnityEngine.ParticleSystemMeshDistribution
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- NonUniformRandom = 1
- UniformRandom = 0

### public enum UnityEngine.ParticleSystemMeshShapeType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Edge = 1
- Triangle = 2
- Vertex = 0

### public enum UnityEngine.ParticleSystemNoiseQuality
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- High = 2
- Low = 0
- Medium = 1

### public enum UnityEngine.ParticleSystemOverlapAction
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Callback = 2
- Ignore = 0
- Kill = 1

### public class UnityEngine.ParticleSystemRenderer
- Base: UnityEngine.Renderer

#### Properties
- public int activeTrailVertexStreamsCount { get; }
- public int activeVertexStreamsCount { get; }
- public UnityEngine.ParticleSystemRenderSpace alignment { get; set; }
- public bool allowRoll { get; set; }
- public float cameraVelocityScale { get; set; }
- public bool enableGPUInstancing { get; set; }
- public UnityEngine.Vector3 flip { get; set; }
- public bool freeformStretching { get; set; }
- public float lengthScale { get; set; }
- public UnityEngine.SpriteMaskInteraction maskInteraction { get; set; }
- public float maxParticleSize { get; set; }
- public UnityEngine.Mesh mesh { get; set; }
- public int meshCount { get; }
- public UnityEngine.ParticleSystemMeshDistribution meshDistribution { get; set; }
- public float minParticleSize { get; set; }
- public float normalDirection { get; set; }
- internal UnityEngine.Material oldTrailMaterial { set; }
- public UnityEngine.Vector3 pivot { get; set; }
- public UnityEngine.ParticleSystemRenderMode renderMode { get; set; }
- public bool rotateWithStretchDirection { get; set; }
- public float shadowBias { get; set; }
- public float sortingFudge { get; set; }
- public UnityEngine.ParticleSystemSortMode sortMode { get; set; }
- public UnityEngine.Material trailMaterial { get; set; }
- public float velocityScale { get; set; }

#### Constructors
- public ParticleSystemRenderer()

#### Methods
- public bool AreVertexStreamsEnabled(UnityEngine.ParticleSystemVertexStreams streams)
- public void BakeMesh(UnityEngine.Mesh mesh, bool useTransform = false)
- public void BakeMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, bool useTransform = false)
- public void BakeMesh(UnityEngine.Mesh mesh, UnityEngine.ParticleSystemBakeMeshOptions options)
- public void BakeMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeMeshOptions options)
- public int BakeTexture(ref UnityEngine.Texture2D verticesTexture, UnityEngine.ParticleSystemBakeTextureOptions options)
- public int BakeTexture(ref UnityEngine.Texture2D verticesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options)
- public int BakeTexture(ref UnityEngine.Texture2D verticesTexture, ref UnityEngine.Texture2D indicesTexture, UnityEngine.ParticleSystemBakeTextureOptions options)
- public int BakeTexture(ref UnityEngine.Texture2D verticesTexture, ref UnityEngine.Texture2D indicesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options)
- private UnityEngine.ParticleSystemRenderer.BakeTextureOutput BakeTextureInternal(UnityEngine.Texture2D verticesTexture, UnityEngine.Texture2D indicesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options, out int indexCount)
- private void BakeTextureInternal_Injected(UnityEngine.Texture2D verticesTexture, UnityEngine.Texture2D indicesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options, out int indexCount, out UnityEngine.ParticleSystemRenderer.BakeTextureOutput ret)
- private UnityEngine.Texture2D BakeTextureNoIndicesInternal(UnityEngine.Texture2D verticesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options, out int indexCount)
- public void BakeTrailsMesh(UnityEngine.Mesh mesh, bool useTransform = false)
- public void BakeTrailsMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, bool useTransform = false)
- public void BakeTrailsMesh(UnityEngine.Mesh mesh, UnityEngine.ParticleSystemBakeMeshOptions options)
- public void BakeTrailsMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeMeshOptions options)
- public int BakeTrailsTexture(ref UnityEngine.Texture2D verticesTexture, ref UnityEngine.Texture2D indicesTexture, UnityEngine.ParticleSystemBakeTextureOptions options)
- public int BakeTrailsTexture(ref UnityEngine.Texture2D verticesTexture, ref UnityEngine.Texture2D indicesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options)
- private UnityEngine.ParticleSystemRenderer.BakeTextureOutput BakeTrailsTextureInternal(UnityEngine.Texture2D verticesTexture, UnityEngine.Texture2D indicesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options, out int indexCount)
- private void BakeTrailsTextureInternal_Injected(UnityEngine.Texture2D verticesTexture, UnityEngine.Texture2D indicesTexture, UnityEngine.Camera camera, UnityEngine.ParticleSystemBakeTextureOptions options, out int indexCount, out UnityEngine.ParticleSystemRenderer.BakeTextureOutput ret)
- public void DisableVertexStreams(UnityEngine.ParticleSystemVertexStreams streams)
- public void EnableVertexStreams(UnityEngine.ParticleSystemVertexStreams streams)
- public void GetActiveTrailVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams)
- public void GetActiveVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams)
- public UnityEngine.ParticleSystemVertexStreams GetEnabledVertexStreams(UnityEngine.ParticleSystemVertexStreams streams)
- public int GetMeshes(UnityEngine.Mesh[] meshes)
- public int GetMeshWeightings(float[] weightings)
- internal UnityEngine.ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(UnityEngine.ParticleSystemVertexStreams streams)
- internal void Internal_SetVertexStreams(UnityEngine.ParticleSystemVertexStreams streams, bool enabled)
- public void SetActiveTrailVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams)
- public void SetActiveVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams)
- public void SetMeshes(UnityEngine.Mesh[] meshes, int size)
- public void SetMeshes(UnityEngine.Mesh[] meshes)
- public void SetMeshWeightings(float[] weightings, int size)
- public void SetMeshWeightings(float[] weightings)

### public enum UnityEngine.ParticleSystemRenderMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Billboard = 0
- HorizontalBillboard = 2
- Mesh = 4
- None = 5
- Stretch = 1
- VerticalBillboard = 3

### public enum UnityEngine.ParticleSystemRenderSpace
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Facing = 3
- Local = 2
- Velocity = 4
- View = 0
- World = 1

### public enum UnityEngine.ParticleSystemRingBufferMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Disabled = 0
- LoopUntilReplaced = 2
- PauseUntilReplaced = 1

### public enum UnityEngine.ParticleSystemScalingMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Hierarchy = 0
- Local = 1
- Shape = 2

### public enum UnityEngine.ParticleSystemShapeMultiModeValue
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BurstSpread = 3
- Loop = 1
- PingPong = 2
- Random = 0

### public enum UnityEngine.ParticleSystemShapeTextureChannel
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Alpha = 3
- Blue = 2
- Green = 1
- Red = 0

### public enum UnityEngine.ParticleSystemShapeType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Box = 5
- BoxEdge = 16
- BoxShell = 15
- Circle = 10
- CircleEdge = 11
- Cone = 4
- ConeShell = 7
- ConeVolume = 8
- ConeVolumeShell = 9
- Donut = 17
- Hemisphere = 2
- HemisphereShell = 3
- Mesh = 6
- MeshRenderer = 13
- Rectangle = 18
- SingleSidedEdge = 12
- SkinnedMeshRenderer = 14
- Sphere = 0
- SphereShell = 1
- Sprite = 19
- SpriteRenderer = 20

### public enum UnityEngine.ParticleSystemSimulationSpace
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Custom = 2
- Local = 0
- World = 1

### public enum UnityEngine.ParticleSystemSortMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Depth = 4
- DepthReverse = 6
- Distance = 1
- DistanceReverse = 5
- None = 0
- OldestInFront = 2
- YoungestInFront = 3

### public enum UnityEngine.ParticleSystemStopAction
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Callback = 3
- Destroy = 2
- Disable = 1
- None = 0

### public enum UnityEngine.ParticleSystemStopBehavior
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- StopEmitting = 1
- StopEmittingAndClear = 0

### public enum UnityEngine.ParticleSystemSubEmitterProperties
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- InheritColor = 1
- InheritDuration = 16
- InheritEverything = 31
- InheritLifetime = 8
- InheritNothing = 0
- InheritRotation = 4
- InheritSize = 2

### public enum UnityEngine.ParticleSystemSubEmitterType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Birth = 0
- Collision = 1
- Death = 2
- Manual = 4
- Trigger = 3

### public enum UnityEngine.ParticleSystemTrailMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- PerParticle = 0
- Ribbon = 1

### public enum UnityEngine.ParticleSystemTrailTextureMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DistributePerSegment = 2
- RepeatPerSegment = 3
- Static = 4
- Stretch = 0
- Tile = 1

### public enum UnityEngine.ParticleSystemTriggerEventType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Enter = 2
- Exit = 3
- Inside = 0
- Outside = 1

### public enum UnityEngine.ParticleSystemVertexStream
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AgePercent = 21
- AnimBlend = 8
- AnimFrame = 9
- Center = 10
- Color = 3
- ColorPackedAsTwoFloats = 47
- Custom1X = 31
- Custom1XY = 32
- Custom1XYZ = 33
- Custom1XYZW = 34
- Custom2X = 35
- Custom2XY = 36
- Custom2XYZ = 37
- Custom2XYZW = 38
- InvStartLifetime = 22
- MeshAxisOfRotation = 48
- MeshIndex = 45
- NextTrailCenter = 49
- NoiseImpulseX = 42
- NoiseImpulseXY = 43
- NoiseImpulseXYZ = 44
- NoiseSumX = 39
- NoiseSumXY = 40
- NoiseSumXYZ = 41
- Normal = 1
- ParticleIndex = 46
- PercentageAlongTrail = 51
- Position = 0
- PreviousTrailCenter = 50
- Rotation = 15
- Rotation3D = 16
- RotationSpeed = 17
- RotationSpeed3D = 18
- SizeX = 12
- SizeXY = 13
- SizeXYZ = 14
- Speed = 20
- StableRandomX = 23
- StableRandomXY = 24
- StableRandomXYZ = 25
- StableRandomXYZW = 26
- Tangent = 2
- TrailWidth = 52
- UV = 4
- UV2 = 5
- UV3 = 6
- UV4 = 7
- VaryingRandomX = 27
- VaryingRandomXY = 28
- VaryingRandomXYZ = 29
- VaryingRandomXYZW = 30
- Velocity = 19
- VertexID = 11

### public enum UnityEngine.ParticleSystemVertexStreams
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- All = 2147483647
- CenterAndVertexID = 64
- Color = 8
- Custom1 = 2048
- Custom2 = 4096
- Lifetime = 1024
- None = 0
- Normal = 2
- Position = 1
- Random = 8192
- Rotation = 256
- Size = 128
- Tangent = 4
- UV = 16
- UV2BlendAndFrame = 32
- Velocity = 512

### public struct UnityEngine.ParticleSystem.PlaybackState

#### Fields
- internal float m_AccumulatedDt
- internal UnityEngine.ParticleSystem.PlaybackState.Collision m_Collision
- internal UnityEngine.ParticleSystem.PlaybackState.Emission m_Emission
- internal UnityEngine.ParticleSystem.PlaybackState.Force m_Force
- internal UnityEngine.ParticleSystem.PlaybackState.Initial m_Initial
- internal UnityEngine.ParticleSystem.PlaybackState.Lights m_Lights
- internal UnityEngine.ParticleSystem.PlaybackState.Noise m_Noise
- internal float m_PlaybackTime
- internal int m_RingBufferIndex
- internal UnityEngine.ParticleSystem.PlaybackState.Shape m_Shape
- internal float m_StartDelay
- internal UnityEngine.ParticleSystem.PlaybackState.Trail m_Trail

### public struct UnityEngine.ParticleSystem.RotationBySpeedModule

#### Fields
- internal UnityEngine.ParticleSystem m_ParticleSystem

#### Properties
- public bool enabled { get; set; }
- public UnityEngine.Vector2 range { get; set; }
- public bool separateAxes { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve x { get; set; }
- public float xMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve y { get; set; }
- public float yMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve z { get; set; }
- public float zMultiplier { get; set; }

#### Constructors
- internal ParticleSystem.RotationBySpeedModule(UnityEngine.ParticleSystem particleSystem)

### public struct UnityEngine.ParticleSystem.RotationOverLifetimeModule

#### Fields
- internal UnityEngine.ParticleSystem m_ParticleSystem

#### Properties
- public bool enabled { get; set; }
- public bool separateAxes { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve x { get; set; }
- public float xMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve y { get; set; }
- public float yMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve z { get; set; }
- public float zMultiplier { get; set; }

#### Constructors
- internal ParticleSystem.RotationOverLifetimeModule(UnityEngine.ParticleSystem particleSystem)

### internal struct UnityEngine.ParticleSystem.PlaybackState.Seed

#### Fields
- public uint w
- public uint x
- public uint y
- public uint z

### internal struct UnityEngine.ParticleSystem.PlaybackState.Seed4

#### Fields
- public UnityEngine.ParticleSystem.PlaybackState.Seed w
- public UnityEngine.ParticleSystem.PlaybackState.Seed x
- public UnityEngine.ParticleSystem.PlaybackState.Seed y
- public UnityEngine.ParticleSystem.PlaybackState.Seed z

### internal struct UnityEngine.ParticleSystem.PlaybackState.Shape

#### Fields
- public float m_ArcTimer
- public float m_ArcTimerPrev
- public float m_MeshSpawnTimer
- public float m_MeshSpawnTimerPrev
- public int m_OrderedMeshVertexIndex
- public float m_RadiusTimer
- public float m_RadiusTimerPrev
- public UnityEngine.ParticleSystem.PlaybackState.Seed4 m_Random

### public struct UnityEngine.ParticleSystem.ShapeModule

#### Fields
- internal UnityEngine.ParticleSystem m_ParticleSystem

#### Properties
- public bool alignToDirection { get; set; }
- public float angle { get; set; }
- public float arc { get; set; }
- public UnityEngine.ParticleSystemShapeMultiModeValue arcMode { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve arcSpeed { get; set; }
- public float arcSpeedMultiplier { get; set; }
- public float arcSpread { get; set; }
- public UnityEngine.Vector3 box { get; set; }
- public UnityEngine.Vector3 boxThickness { get; set; }
- public float donutRadius { get; set; }
- public bool enabled { get; set; }
- public float length { get; set; }
- public UnityEngine.Mesh mesh { get; set; }
- public int meshMaterialIndex { get; set; }
- public UnityEngine.MeshRenderer meshRenderer { get; set; }
- public float meshScale { get; set; }
- public UnityEngine.ParticleSystemMeshShapeType meshShapeType { get; set; }
- public UnityEngine.ParticleSystemShapeMultiModeValue meshSpawnMode { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve meshSpawnSpeed { get; set; }
- public float meshSpawnSpeedMultiplier { get; set; }
- public float meshSpawnSpread { get; set; }
- public float normalOffset { get; set; }
- public UnityEngine.Vector3 position { get; set; }
- public float radius { get; set; }
- public UnityEngine.ParticleSystemShapeMultiModeValue radiusMode { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve radiusSpeed { get; set; }
- public float radiusSpeedMultiplier { get; set; }
- public float radiusSpread { get; set; }
- public float radiusThickness { get; set; }
- public bool randomDirection { get; set; }
- public float randomDirectionAmount { get; set; }
- public float randomPositionAmount { get; set; }
- public UnityEngine.Vector3 rotation { get; set; }
- public UnityEngine.Vector3 scale { get; set; }
- public UnityEngine.ParticleSystemShapeType shapeType { get; set; }
- public UnityEngine.SkinnedMeshRenderer skinnedMeshRenderer { get; set; }
- public float sphericalDirectionAmount { get; set; }
- public UnityEngine.Sprite sprite { get; set; }
- public UnityEngine.SpriteRenderer spriteRenderer { get; set; }
- public UnityEngine.Texture2D texture { get; set; }
- public bool textureAlphaAffectsParticles { get; set; }
- public bool textureBilinearFiltering { get; set; }
- public UnityEngine.ParticleSystemShapeTextureChannel textureClipChannel { get; set; }
- public float textureClipThreshold { get; set; }
- public bool textureColorAffectsParticles { get; set; }
- public int textureUVChannel { get; set; }
- public bool useMeshColors { get; set; }
- public bool useMeshMaterialIndex { get; set; }

#### Constructors
- internal ParticleSystem.ShapeModule(UnityEngine.ParticleSystem particleSystem)

### public struct UnityEngine.ParticleSystem.SizeBySpeedModule

#### Fields
- internal UnityEngine.ParticleSystem m_ParticleSystem

#### Properties
- public bool enabled { get; set; }
- public UnityEngine.Vector2 range { get; set; }
- public bool separateAxes { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve size { get; set; }
- public float sizeMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve x { get; set; }
- public float xMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve y { get; set; }
- public float yMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve z { get; set; }
- public float zMultiplier { get; set; }

#### Constructors
- internal ParticleSystem.SizeBySpeedModule(UnityEngine.ParticleSystem particleSystem)

### public struct UnityEngine.ParticleSystem.SizeOverLifetimeModule

#### Fields
- internal UnityEngine.ParticleSystem m_ParticleSystem

#### Properties
- public bool enabled { get; set; }
- public bool separateAxes { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve size { get; set; }
- public float sizeMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve x { get; set; }
- public float xMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve y { get; set; }
- public float yMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve z { get; set; }
- public float zMultiplier { get; set; }

#### Constructors
- internal ParticleSystem.SizeOverLifetimeModule(UnityEngine.ParticleSystem particleSystem)

### public struct UnityEngine.ParticleSystem.SubEmittersModule

#### Fields
- internal UnityEngine.ParticleSystem m_ParticleSystem

#### Properties
- public UnityEngine.ParticleSystem birth0 { get; set; }
- public UnityEngine.ParticleSystem birth1 { get; set; }
- public UnityEngine.ParticleSystem collision0 { get; set; }
- public UnityEngine.ParticleSystem collision1 { get; set; }
- public UnityEngine.ParticleSystem death0 { get; set; }
- public UnityEngine.ParticleSystem death1 { get; set; }
- public bool enabled { get; set; }
- public int subEmittersCount { get; }

#### Constructors
- internal ParticleSystem.SubEmittersModule(UnityEngine.ParticleSystem particleSystem)

#### Methods
- public void AddSubEmitter(UnityEngine.ParticleSystem subEmitter, UnityEngine.ParticleSystemSubEmitterType type, UnityEngine.ParticleSystemSubEmitterProperties properties, float emitProbability)
- public void AddSubEmitter(UnityEngine.ParticleSystem subEmitter, UnityEngine.ParticleSystemSubEmitterType type, UnityEngine.ParticleSystemSubEmitterProperties properties)
- private static void AddSubEmitter_Injected(ref UnityEngine.ParticleSystem.SubEmittersModule _unity_self, UnityEngine.ParticleSystem subEmitter, UnityEngine.ParticleSystemSubEmitterType type, UnityEngine.ParticleSystemSubEmitterProperties properties, float emitProbability)
- public float GetSubEmitterEmitProbability(int index)
- private static float GetSubEmitterEmitProbability_Injected(ref UnityEngine.ParticleSystem.SubEmittersModule _unity_self, int index)
- public UnityEngine.ParticleSystemSubEmitterProperties GetSubEmitterProperties(int index)
- private static UnityEngine.ParticleSystemSubEmitterProperties GetSubEmitterProperties_Injected(ref UnityEngine.ParticleSystem.SubEmittersModule _unity_self, int index)
- public UnityEngine.ParticleSystem GetSubEmitterSystem(int index)
- private static UnityEngine.ParticleSystem GetSubEmitterSystem_Injected(ref UnityEngine.ParticleSystem.SubEmittersModule _unity_self, int index)
- public UnityEngine.ParticleSystemSubEmitterType GetSubEmitterType(int index)
- private static UnityEngine.ParticleSystemSubEmitterType GetSubEmitterType_Injected(ref UnityEngine.ParticleSystem.SubEmittersModule _unity_self, int index)
- public void RemoveSubEmitter(int index)
- public void RemoveSubEmitter(UnityEngine.ParticleSystem subEmitter)
- private void RemoveSubEmitterObject(UnityEngine.ParticleSystem subEmitter)
- private static void RemoveSubEmitterObject_Injected(ref UnityEngine.ParticleSystem.SubEmittersModule _unity_self, UnityEngine.ParticleSystem subEmitter)
- private static void RemoveSubEmitter_Injected(ref UnityEngine.ParticleSystem.SubEmittersModule _unity_self, int index)
- public void SetSubEmitterEmitProbability(int index, float emitProbability)
- private static void SetSubEmitterEmitProbability_Injected(ref UnityEngine.ParticleSystem.SubEmittersModule _unity_self, int index, float emitProbability)
- public void SetSubEmitterProperties(int index, UnityEngine.ParticleSystemSubEmitterProperties properties)
- private static void SetSubEmitterProperties_Injected(ref UnityEngine.ParticleSystem.SubEmittersModule _unity_self, int index, UnityEngine.ParticleSystemSubEmitterProperties properties)
- public void SetSubEmitterSystem(int index, UnityEngine.ParticleSystem subEmitter)
- private static void SetSubEmitterSystem_Injected(ref UnityEngine.ParticleSystem.SubEmittersModule _unity_self, int index, UnityEngine.ParticleSystem subEmitter)
- public void SetSubEmitterType(int index, UnityEngine.ParticleSystemSubEmitterType type)
- private static void SetSubEmitterType_Injected(ref UnityEngine.ParticleSystem.SubEmittersModule _unity_self, int index, UnityEngine.ParticleSystemSubEmitterType type)
- private static void ThrowNotImplemented()

### public struct UnityEngine.ParticleSystem.TextureSheetAnimationModule

#### Fields
- internal UnityEngine.ParticleSystem m_ParticleSystem

#### Properties
- public UnityEngine.ParticleSystemAnimationType animation { get; set; }
- public int cycleCount { get; set; }
- public bool enabled { get; set; }
- public float flipU { get; set; }
- public float flipV { get; set; }
- public float fps { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve frameOverTime { get; set; }
- public float frameOverTimeMultiplier { get; set; }
- public UnityEngine.ParticleSystemAnimationMode mode { get; set; }
- public int numTilesX { get; set; }
- public int numTilesY { get; set; }
- public int rowIndex { get; set; }
- public UnityEngine.ParticleSystemAnimationRowMode rowMode { get; set; }
- public UnityEngine.Vector2 speedRange { get; set; }
- public int spriteCount { get; }
- public UnityEngine.ParticleSystem.MinMaxCurve startFrame { get; set; }
- public float startFrameMultiplier { get; set; }
- public UnityEngine.ParticleSystemAnimationTimeMode timeMode { get; set; }
- public bool useRandomRow { get; set; }
- public UnityEngine.Rendering.UVChannelFlags uvChannelMask { get; set; }

#### Constructors
- internal ParticleSystem.TextureSheetAnimationModule(UnityEngine.ParticleSystem particleSystem)

#### Methods
- public void AddSprite(UnityEngine.Sprite sprite)
- private static void AddSprite_Injected(ref UnityEngine.ParticleSystem.TextureSheetAnimationModule _unity_self, UnityEngine.Sprite sprite)
- public UnityEngine.Sprite GetSprite(int index)
- private static UnityEngine.Sprite GetSprite_Injected(ref UnityEngine.ParticleSystem.TextureSheetAnimationModule _unity_self, int index)
- public void RemoveSprite(int index)
- private static void RemoveSprite_Injected(ref UnityEngine.ParticleSystem.TextureSheetAnimationModule _unity_self, int index)
- public void SetSprite(int index, UnityEngine.Sprite sprite)
- private static void SetSprite_Injected(ref UnityEngine.ParticleSystem.TextureSheetAnimationModule _unity_self, int index, UnityEngine.Sprite sprite)

### internal struct UnityEngine.ParticleSystem.PlaybackState.Trail

#### Fields
- public float m_Timer

### public struct UnityEngine.ParticleSystem.TrailModule

#### Fields
- internal UnityEngine.ParticleSystem m_ParticleSystem

#### Properties
- public bool attachRibbonsToTransform { get; set; }
- public UnityEngine.ParticleSystem.MinMaxGradient colorOverLifetime { get; set; }
- public UnityEngine.ParticleSystem.MinMaxGradient colorOverTrail { get; set; }
- public bool dieWithParticles { get; set; }
- public bool enabled { get; set; }
- public bool generateLightingData { get; set; }
- public bool inheritParticleColor { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve lifetime { get; set; }
- public float lifetimeMultiplier { get; set; }
- public float minVertexDistance { get; set; }
- public UnityEngine.ParticleSystemTrailMode mode { get; set; }
- public float ratio { get; set; }
- public int ribbonCount { get; set; }
- public float shadowBias { get; set; }
- public bool sizeAffectsLifetime { get; set; }
- public bool sizeAffectsWidth { get; set; }
- public bool splitSubEmitterRibbons { get; set; }
- public UnityEngine.ParticleSystemTrailTextureMode textureMode { get; set; }
- public UnityEngine.Vector2 textureScale { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve widthOverTrail { get; set; }
- public float widthOverTrailMultiplier { get; set; }
- public bool worldSpace { get; set; }

#### Constructors
- internal ParticleSystem.TrailModule(UnityEngine.ParticleSystem particleSystem)

### public struct UnityEngine.ParticleSystem.Trails

#### Fields
- internal System.Collections.Generic.List<int> backPositions
- internal System.Collections.Generic.List<int> frontPositions
- internal int maxPositionsPerTrailCount
- internal int maxTrailCount
- internal System.Collections.Generic.List<int> positionCounts
- internal System.Collections.Generic.List<UnityEngine.Vector4> positions
- internal System.Collections.Generic.List<float> textureOffsets

#### Properties
- public int capacity { get; set; }

#### Methods
- internal void Allocate()

### public struct UnityEngine.ParticleSystem.TriggerModule

#### Fields
- internal UnityEngine.ParticleSystem m_ParticleSystem

#### Properties
- public int colliderCount { get; }
- public UnityEngine.ParticleSystemColliderQueryMode colliderQueryMode { get; set; }
- public bool enabled { get; set; }
- public UnityEngine.ParticleSystemOverlapAction enter { get; set; }
- public UnityEngine.ParticleSystemOverlapAction exit { get; set; }
- public UnityEngine.ParticleSystemOverlapAction inside { get; set; }
- public int maxColliderCount { get; }
- public UnityEngine.ParticleSystemOverlapAction outside { get; set; }
- public float radiusScale { get; set; }

#### Constructors
- internal ParticleSystem.TriggerModule(UnityEngine.ParticleSystem particleSystem)

#### Methods
- public void AddCollider(UnityEngine.Component collider)
- private static void AddCollider_Injected(ref UnityEngine.ParticleSystem.TriggerModule _unity_self, UnityEngine.Component collider)
- public UnityEngine.Component GetCollider(int index)
- private static UnityEngine.Component GetCollider_Injected(ref UnityEngine.ParticleSystem.TriggerModule _unity_self, int index)
- public void RemoveCollider(int index)
- public void RemoveCollider(UnityEngine.Component collider)
- private void RemoveColliderObject(UnityEngine.Component collider)
- private static void RemoveColliderObject_Injected(ref UnityEngine.ParticleSystem.TriggerModule _unity_self, UnityEngine.Component collider)
- private static void RemoveCollider_Injected(ref UnityEngine.ParticleSystem.TriggerModule _unity_self, int index)
- public void SetCollider(int index, UnityEngine.Component collider)
- private static void SetCollider_Injected(ref UnityEngine.ParticleSystem.TriggerModule _unity_self, int index, UnityEngine.Component collider)

### public struct UnityEngine.ParticleSystem.VelocityOverLifetimeModule

#### Fields
- internal UnityEngine.ParticleSystem m_ParticleSystem

#### Properties
- public bool enabled { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve orbitalOffsetX { get; set; }
- public float orbitalOffsetXMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve orbitalOffsetY { get; set; }
- public float orbitalOffsetYMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve orbitalOffsetZ { get; set; }
- public float orbitalOffsetZMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve orbitalX { get; set; }
- public float orbitalXMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve orbitalY { get; set; }
- public float orbitalYMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve orbitalZ { get; set; }
- public float orbitalZMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve radial { get; set; }
- public float radialMultiplier { get; set; }
- public UnityEngine.ParticleSystemSimulationSpace space { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve speedModifier { get; set; }
- public float speedModifierMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve x { get; set; }
- public float xMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve y { get; set; }
- public float yMultiplier { get; set; }
- public UnityEngine.ParticleSystem.MinMaxCurve z { get; set; }
- public float zMultiplier { get; set; }

#### Constructors
- internal ParticleSystem.VelocityOverLifetimeModule(UnityEngine.ParticleSystem particleSystem)

## Namespace: UnityEngine.ParticleSystemJobs

### internal struct UnityEngine.ParticleSystemJobs.NativeParticleData.Array3

#### Fields
- internal float* x
- internal float* y
- internal float* z

### internal struct UnityEngine.ParticleSystemJobs.NativeParticleData.Array4

#### Fields
- internal float* w
- internal float* x
- internal float* y
- internal float* z

### public delegate UnityEngine.ParticleSystemJobs.ParticleSystemJobStruct<T>.ExecuteJobFunction<T>
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ParticleSystemJobStruct<T>.ExecuteJobFunction<T>(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref T data, System.IntPtr listDataPtr, System.IntPtr unusedPtr, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref T data, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, System.IAsyncResult result)
- public virtual void Invoke(ref T data, System.IntPtr listDataPtr, System.IntPtr unusedPtr, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex)

### public delegate UnityEngine.ParticleSystemJobs.ParticleSystemParallelForJobStruct<T>.ExecuteJobFunction<T>
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ParticleSystemParallelForJobStruct<T>.ExecuteJobFunction<T>(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref T data, System.IntPtr listDataPtr, System.IntPtr bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref T data, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, System.IAsyncResult result)
- public virtual void Invoke(ref T data, System.IntPtr listDataPtr, System.IntPtr bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex)

### public delegate UnityEngine.ParticleSystemJobs.ParticleSystemParallelForBatchJobStruct<T>.ExecuteJobFunction<T>
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ParticleSystemParallelForBatchJobStruct<T>.ExecuteJobFunction<T>(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref T data, System.IntPtr listDataPtr, System.IntPtr bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref T data, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, System.IAsyncResult result)
- public virtual void Invoke(ref T data, System.IntPtr listDataPtr, System.IntPtr bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex)

### public interface UnityEngine.ParticleSystemJobs.IJobParticleSystem

#### Methods
- public void Execute(UnityEngine.ParticleSystemJobs.ParticleSystemJobData jobData)

### public static class UnityEngine.ParticleSystemJobs.IJobParticleSystemExtensions

#### Methods
- public static void EarlyJobInit<T>()
- internal static System.IntPtr GetReflectionData<T>()

### public interface UnityEngine.ParticleSystemJobs.IJobParticleSystemParallelFor

#### Methods
- public void Execute(UnityEngine.ParticleSystemJobs.ParticleSystemJobData jobData, int index)

### public interface UnityEngine.ParticleSystemJobs.IJobParticleSystemParallelForBatch

#### Methods
- public void Execute(UnityEngine.ParticleSystemJobs.ParticleSystemJobData jobData, int startIndex, int count)

### public static class UnityEngine.ParticleSystemJobs.IJobParticleSystemParallelForBatchExtensions

#### Methods
- public static void EarlyJobInit<T>()
- internal static System.IntPtr GetReflectionData<T>()

### public static class UnityEngine.ParticleSystemJobs.IJobParticleSystemParallelForExtensions

#### Methods
- public static void EarlyJobInit<T>()
- internal static System.IntPtr GetReflectionData<T>()

### public static class UnityEngine.ParticleSystemJobs.IParticleSystemJobExtensions

#### Fields
- private static readonly string k_UserJobScheduledOutsideOfCallbackErrorMsg

#### Constructors
- private static IParticleSystemJobExtensions()

#### Methods
- public static Unity.Jobs.JobHandle Schedule<T>(T jobData, UnityEngine.ParticleSystem ps, Unity.Jobs.JobHandle dependsOn = null)
- public static Unity.Jobs.JobHandle Schedule<T>(T jobData, UnityEngine.ParticleSystem ps, int minIndicesPerJobCount, Unity.Jobs.JobHandle dependsOn = null)
- public static Unity.Jobs.JobHandle ScheduleBatch<T>(T jobData, UnityEngine.ParticleSystem ps, int innerLoopBatchCount, Unity.Jobs.JobHandle dependsOn = null)

### internal struct UnityEngine.ParticleSystemJobs.NativeListData

#### Fields
- public int capacity
- public int length
- public void* system

### internal struct UnityEngine.ParticleSystemJobs.NativeParticleData

#### Fields
- internal void* aliveTimePercent
- internal UnityEngine.ParticleSystemJobs.NativeParticleData.Array3 axisOfRotations
- internal int count
- internal UnityEngine.ParticleSystemJobs.NativeParticleData.Array4 customData1
- internal UnityEngine.ParticleSystemJobs.NativeParticleData.Array4 customData2
- internal void* inverseStartLifetimes
- internal void* meshIndices
- internal UnityEngine.ParticleSystemJobs.NativeParticleData.Array3 positions
- internal void* randomSeeds
- internal UnityEngine.ParticleSystemJobs.NativeParticleData.Array3 rotationalSpeeds
- internal UnityEngine.ParticleSystemJobs.NativeParticleData.Array3 rotations
- internal UnityEngine.ParticleSystemJobs.NativeParticleData.Array3 sizes
- internal void* startColors
- internal UnityEngine.ParticleSystemJobs.NativeParticleData.Array3 velocities

### public struct UnityEngine.ParticleSystemJobs.ParticleSystemJobData

#### Fields
- private readonly Unity.Collections.NativeArray<float> <aliveTimePercent>k__BackingField
- private readonly UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <axisOfRotations>k__BackingField
- private readonly int <count>k__BackingField
- private readonly UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray4 <customData1>k__BackingField
- private readonly UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray4 <customData2>k__BackingField
- private readonly Unity.Collections.NativeArray<float> <inverseStartLifetimes>k__BackingField
- private readonly Unity.Collections.NativeArray<int> <meshIndices>k__BackingField
- private readonly UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <positions>k__BackingField
- private readonly Unity.Collections.NativeArray<uint> <randomSeeds>k__BackingField
- private readonly UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <rotationalSpeeds>k__BackingField
- private readonly UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <rotations>k__BackingField
- private readonly UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <sizes>k__BackingField
- private readonly Unity.Collections.NativeArray<UnityEngine.Color32> <startColors>k__BackingField
- private readonly UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 <velocities>k__BackingField

#### Properties
- public Unity.Collections.NativeArray<float> aliveTimePercent { get; }
- public UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 axisOfRotations { get; }
- public int count { get; }
- public UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray4 customData1 { get; }
- public UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray4 customData2 { get; }
- public Unity.Collections.NativeArray<float> inverseStartLifetimes { get; }
- public Unity.Collections.NativeArray<int> meshIndices { get; }
- public UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 positions { get; }
- public Unity.Collections.NativeArray<uint> randomSeeds { get; }
- public UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 rotationalSpeeds { get; }
- public UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 rotations { get; }
- public UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 sizes { get; }
- public Unity.Collections.NativeArray<UnityEngine.Color32> startColors { get; }
- public UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 velocities { get; }

#### Constructors
- internal ParticleSystemJobData(ref UnityEngine.ParticleSystemJobs.NativeParticleData nativeData)

#### Methods
- internal Unity.Collections.NativeArray<T> CreateNativeArray<T>(void* src, int count)
- internal UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3 CreateNativeArray3(ref UnityEngine.ParticleSystemJobs.NativeParticleData.Array3 ptrs, int count)
- internal UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray4 CreateNativeArray4(ref UnityEngine.ParticleSystemJobs.NativeParticleData.Array4 ptrs, int count)

### internal struct UnityEngine.ParticleSystemJobs.ParticleSystemJobStruct<T>

#### Fields
- public static readonly Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<System.IntPtr> jobReflectionData

#### Constructors
- private static ParticleSystemJobStruct<T>()

#### Methods
- public static void Execute(ref T data, System.IntPtr listDataPtr, System.IntPtr unusedPtr, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex)
- public static void Initialize()

### internal static class UnityEngine.ParticleSystemJobs.ParticleSystemJobUtility

#### Methods
- internal static Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters CreateScheduleParams<T>(ref T jobData, UnityEngine.ParticleSystem ps, Unity.Jobs.JobHandle dependsOn, System.IntPtr jobReflectionData)

### public struct UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray3

#### Fields
- public Unity.Collections.NativeArray<float> x
- public Unity.Collections.NativeArray<float> y
- public Unity.Collections.NativeArray<float> z

#### Properties
- public UnityEngine.Vector3 Item { get; set; }

### public struct UnityEngine.ParticleSystemJobs.ParticleSystemNativeArray4

#### Fields
- public Unity.Collections.NativeArray<float> w
- public Unity.Collections.NativeArray<float> x
- public Unity.Collections.NativeArray<float> y
- public Unity.Collections.NativeArray<float> z

#### Properties
- public UnityEngine.Vector4 Item { get; set; }

### internal struct UnityEngine.ParticleSystemJobs.ParticleSystemParallelForBatchJobStruct<T>

#### Fields
- public static readonly Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<System.IntPtr> jobReflectionData

#### Constructors
- private static ParticleSystemParallelForBatchJobStruct<T>()

#### Methods
- public static void Execute(ref T data, System.IntPtr listDataPtr, System.IntPtr bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex)
- public static void Initialize()

### internal struct UnityEngine.ParticleSystemJobs.ParticleSystemParallelForJobStruct<T>

#### Fields
- public static readonly Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<System.IntPtr> jobReflectionData

#### Constructors
- private static ParticleSystemParallelForJobStruct<T>()

#### Methods
- public static void Execute(ref T data, System.IntPtr listDataPtr, System.IntPtr bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex)
- public static void Initialize()

## Namespace: UnityEngine.Rendering

### public enum UnityEngine.Rendering.UVChannelFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- UV0 = 1
- UV1 = 2
- UV2 = 4
- UV3 = 8

