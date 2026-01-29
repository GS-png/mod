# Assembly: UnityEngine.Physics2DModule
- Path: tools/WorldBox.Managed/UnityEngine.Physics2DModule.dll
- Types: 62

## Namespace: UnityEngine

### public class UnityEngine.AnchoredJoint2D
- Base: UnityEngine.Joint2D

#### Properties
- public UnityEngine.Vector2 anchor { get; set; }
- public bool autoConfigureConnectedAnchor { get; set; }
- public UnityEngine.Vector2 connectedAnchor { get; set; }

#### Constructors
- public AnchoredJoint2D()

### public class UnityEngine.AreaEffector2D
- Base: UnityEngine.Effector2D

#### Properties
- public float angularDrag { get; set; }
- public float drag { get; set; }
- public float forceAngle { get; set; }
- public float forceDirection { get; set; }
- public float forceMagnitude { get; set; }
- public UnityEngine.EffectorSelection2D forceTarget { get; set; }
- public float forceVariation { get; set; }
- public bool useGlobalAngle { get; set; }

#### Constructors
- public AreaEffector2D()

### public class UnityEngine.BoxCollider2D
- Base: UnityEngine.Collider2D

#### Properties
- public bool autoTiling { get; set; }
- public UnityEngine.Vector2 center { get; set; }
- public float edgeRadius { get; set; }
- public UnityEngine.Vector2 size { get; set; }

#### Constructors
- public BoxCollider2D()

### public class UnityEngine.BuoyancyEffector2D
- Base: UnityEngine.Effector2D

#### Properties
- public float angularDrag { get; set; }
- public float density { get; set; }
- public float flowAngle { get; set; }
- public float flowMagnitude { get; set; }
- public float flowVariation { get; set; }
- public float linearDrag { get; set; }
- public float surfaceLevel { get; set; }

#### Constructors
- public BuoyancyEffector2D()

### public class UnityEngine.CapsuleCollider2D
- Base: UnityEngine.Collider2D

#### Properties
- public UnityEngine.CapsuleDirection2D direction { get; set; }
- public UnityEngine.Vector2 size { get; set; }

#### Constructors
- public CapsuleCollider2D()

### public enum UnityEngine.CapsuleDirection2D
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Horizontal = 1
- Vertical = 0

### public class UnityEngine.CircleCollider2D
- Base: UnityEngine.Collider2D

#### Properties
- public UnityEngine.Vector2 center { get; set; }
- public float radius { get; set; }

#### Constructors
- public CircleCollider2D()

### public class UnityEngine.Collider2D
- Base: UnityEngine.Behaviour

#### Properties
- public UnityEngine.Rigidbody2D attachedRigidbody { get; }
- public float bounciness { get; }
- public UnityEngine.Bounds bounds { get; }
- public UnityEngine.LayerMask callbackLayers { get; set; }
- public UnityEngine.CompositeCollider2D composite { get; }
- internal bool compositeCapable { get; }
- public UnityEngine.LayerMask contactCaptureLayers { get; set; }
- public float density { get; set; }
- public UnityEngine.ColliderErrorState2D errorState { get; }
- public UnityEngine.LayerMask excludeLayers { get; set; }
- public UnityEngine.LayerMask forceReceiveLayers { get; set; }
- public UnityEngine.LayerMask forceSendLayers { get; set; }
- public float friction { get; }
- public UnityEngine.LayerMask includeLayers { get; set; }
- public bool isTrigger { get; set; }
- public int layerOverridePriority { get; set; }
- public UnityEngine.Vector2 offset { get; set; }
- public int shapeCount { get; }
- public UnityEngine.PhysicsMaterial2D sharedMaterial { get; set; }
- public bool usedByComposite { get; set; }
- public bool usedByEffector { get; set; }

#### Constructors
- public Collider2D()

#### Methods
- public int Cast(UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results)
- public int Cast(UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance)
- public int Cast(UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, bool ignoreSiblingColliders)
- public int Cast(UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- public int Cast(UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results, float distance)
- public int Cast(UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results, float distance, bool ignoreSiblingColliders)
- public int Cast(UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results, float distance = Infinity, bool ignoreSiblingColliders = true)
- private int CastArray_Internal(UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, bool ignoreSiblingColliders, UnityEngine.RaycastHit2D[] results)
- private int CastArray_Internal_Injected(ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, bool ignoreSiblingColliders, UnityEngine.RaycastHit2D[] results)
- private int CastList_Internal(UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, bool ignoreSiblingColliders, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- private int CastList_Internal_Injected(ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, bool ignoreSiblingColliders, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- public UnityEngine.Vector2 ClosestPoint(UnityEngine.Vector2 position)
- public UnityEngine.Mesh CreateMesh(bool useBodyPosition, bool useBodyRotation)
- public UnityEngine.ColliderDistance2D Distance(UnityEngine.Collider2D collider)
- public int GetContacts(UnityEngine.ContactPoint2D[] contacts)
- public int GetContacts(System.Collections.Generic.List<UnityEngine.ContactPoint2D> contacts)
- public int GetContacts(UnityEngine.ContactFilter2D contactFilter, UnityEngine.ContactPoint2D[] contacts)
- public int GetContacts(UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.ContactPoint2D> contacts)
- public int GetContacts(UnityEngine.Collider2D[] colliders)
- public int GetContacts(System.Collections.Generic.List<UnityEngine.Collider2D> colliders)
- public int GetContacts(UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] colliders)
- public int GetContacts(UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> colliders)
- public uint GetShapeHash()
- public int GetShapes(UnityEngine.PhysicsShapeGroup2D physicsShapeGroup)
- public int GetShapes(UnityEngine.PhysicsShapeGroup2D physicsShapeGroup, int shapeIndex, int shapeCount = 1)
- private int GetShapes_Internal(ref UnityEngine.PhysicsShapeGroup2D.GroupState physicsShapeGroupState, int shapeIndex, int shapeCount)
- public bool IsTouching(UnityEngine.Collider2D collider)
- public bool IsTouching(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter)
- public bool IsTouching(UnityEngine.ContactFilter2D contactFilter)
- public bool IsTouchingLayers()
- public bool IsTouchingLayers(int layerMask)
- private bool IsTouching_AnyColliderWithFilter(UnityEngine.ContactFilter2D contactFilter)
- private bool IsTouching_AnyColliderWithFilter_Injected(ref UnityEngine.ContactFilter2D contactFilter)
- private bool IsTouching_OtherColliderWithFilter(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter)
- private bool IsTouching_OtherColliderWithFilter_Injected(UnityEngine.Collider2D collider, ref UnityEngine.ContactFilter2D contactFilter)
- public int OverlapCollider(UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- public int OverlapCollider(UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- public bool OverlapPoint(UnityEngine.Vector2 point)
- private bool OverlapPoint_Injected(ref UnityEngine.Vector2 point)
- public int Raycast(UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results)
- public int Raycast(UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance)
- public int Raycast(UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask)
- public int Raycast(UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask, float minDepth)
- public int Raycast(UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask, float minDepth, float maxDepth)
- public int Raycast(UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- public int Raycast(UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results, float distance)
- public int Raycast(UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results, float distance = Infinity)
- private int RaycastArray_Internal(UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- private int RaycastArray_Internal_Injected(ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- private int RaycastList_Internal(UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- private int RaycastList_Internal_Injected(ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)

### public struct UnityEngine.ColliderDistance2D

#### Fields
- private float m_Distance
- private int m_IsValid
- private UnityEngine.Vector2 m_Normal
- private UnityEngine.Vector2 m_PointA
- private UnityEngine.Vector2 m_PointB

#### Properties
- public float distance { get; set; }
- public bool isOverlapped { get; }
- public bool isValid { get; set; }
- public UnityEngine.Vector2 normal { get; }
- public UnityEngine.Vector2 pointA { get; set; }
- public UnityEngine.Vector2 pointB { get; set; }

### public enum UnityEngine.ColliderErrorState2D
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- None = 0
- NoShapes = 1
- RemovedShapes = 2

### public class UnityEngine.Collision2D

#### Fields
- internal int m_Collider
- internal int m_ContactCount
- internal int m_Enabled
- internal UnityEngine.ContactPoint2D[] m_LegacyContacts
- internal int m_OtherCollider
- internal int m_OtherRigidbody
- internal UnityEngine.Vector2 m_RelativeVelocity
- internal UnityEngine.ContactPoint2D[] m_ReusedContacts
- internal int m_Rigidbody

#### Properties
- public UnityEngine.Collider2D collider { get; }
- public int contactCount { get; }
- public UnityEngine.ContactPoint2D[] contacts { get; }
- public bool enabled { get; }
- public UnityEngine.GameObject gameObject { get; }
- public UnityEngine.Collider2D otherCollider { get; }
- public UnityEngine.Rigidbody2D otherRigidbody { get; }
- public UnityEngine.Vector2 relativeVelocity { get; }
- public UnityEngine.Rigidbody2D rigidbody { get; }
- public UnityEngine.Transform transform { get; }

#### Constructors
- public Collision2D()

#### Methods
- public UnityEngine.ContactPoint2D GetContact(int index)
- public int GetContacts(UnityEngine.ContactPoint2D[] contacts)
- public int GetContacts(System.Collections.Generic.List<UnityEngine.ContactPoint2D> contacts)
- private UnityEngine.ContactPoint2D[] GetContacts_Internal()

### public enum UnityEngine.CollisionDetectionMode2D
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Continuous = 1
- Discrete = 0
- None = 0

### public class UnityEngine.CompositeCollider2D
- Base: UnityEngine.Collider2D

#### Properties
- public float edgeRadius { get; set; }
- public UnityEngine.CompositeCollider2D.GenerationType generationType { get; set; }
- public UnityEngine.CompositeCollider2D.GeometryType geometryType { get; set; }
- public float offsetDistance { get; set; }
- public int pathCount { get; }
- public int pointCount { get; }
- public bool useDelaunayMesh { get; set; }
- public float vertexDistance { get; set; }

#### Constructors
- public CompositeCollider2D()

#### Methods
- public void GenerateGeometry()
- public int GetPath(int index, UnityEngine.Vector2[] points)
- public int GetPath(int index, System.Collections.Generic.List<UnityEngine.Vector2> points)
- private int GetPathArray_Internal(int index, UnityEngine.Vector2[] points)
- private int GetPathList_Internal(int index, System.Collections.Generic.List<UnityEngine.Vector2> points)
- public int GetPathPointCount(int index)
- private int GetPathPointCount_Internal(int index)

### public class UnityEngine.ConstantForce2D
- Base: UnityEngine.PhysicsUpdateBehaviour2D

#### Properties
- public UnityEngine.Vector2 force { get; set; }
- public UnityEngine.Vector2 relativeForce { get; set; }
- public float torque { get; set; }

#### Constructors
- public ConstantForce2D()

### public struct UnityEngine.ContactFilter2D

#### Fields
- public UnityEngine.LayerMask layerMask
- public float maxDepth
- public float maxNormalAngle
- public float minDepth
- public float minNormalAngle
- public static const float NormalAngleUpperLimit
- public bool useDepth
- public bool useLayerMask
- public bool useNormalAngle
- public bool useOutsideDepth
- public bool useOutsideNormalAngle
- public bool useTriggers

#### Properties
- public bool isFiltering { get; }

#### Methods
- private void CheckConsistency()
- private static void CheckConsistency_Injected(ref UnityEngine.ContactFilter2D _unity_self)
- public void ClearDepth()
- public void ClearLayerMask()
- public void ClearNormalAngle()
- internal static UnityEngine.ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth)
- public bool IsFilteringDepth(UnityEngine.GameObject obj)
- public bool IsFilteringLayerMask(UnityEngine.GameObject obj)
- public bool IsFilteringNormalAngle(UnityEngine.Vector2 normal)
- public bool IsFilteringNormalAngle(float angle)
- private bool IsFilteringNormalAngleUsingAngle(float angle)
- private static bool IsFilteringNormalAngleUsingAngle_Injected(ref UnityEngine.ContactFilter2D _unity_self, float angle)
- private static bool IsFilteringNormalAngle_Injected(ref UnityEngine.ContactFilter2D _unity_self, ref UnityEngine.Vector2 normal)
- public bool IsFilteringTrigger(UnityEngine.Collider2D collider)
- public UnityEngine.ContactFilter2D NoFilter()
- public void SetDepth(float minDepth, float maxDepth)
- public void SetLayerMask(UnityEngine.LayerMask layerMask)
- public void SetNormalAngle(float minNormalAngle, float maxNormalAngle)

### public struct UnityEngine.ContactPoint2D

#### Fields
- private int m_Collider
- private int m_Enabled
- private UnityEngine.Vector2 m_Normal
- private float m_NormalImpulse
- private int m_OtherCollider
- private int m_OtherRigidbody
- private UnityEngine.Vector2 m_Point
- private UnityEngine.Vector2 m_RelativeVelocity
- private int m_Rigidbody
- private float m_Separation
- private float m_TangentImpulse

#### Properties
- public UnityEngine.Collider2D collider { get; }
- public bool enabled { get; }
- public UnityEngine.Vector2 normal { get; }
- public float normalImpulse { get; }
- public UnityEngine.Collider2D otherCollider { get; }
- public UnityEngine.Rigidbody2D otherRigidbody { get; }
- public UnityEngine.Vector2 point { get; }
- public UnityEngine.Vector2 relativeVelocity { get; }
- public UnityEngine.Rigidbody2D rigidbody { get; }
- public float separation { get; }
- public float tangentImpulse { get; }

### public class UnityEngine.CustomCollider2D
- Base: UnityEngine.Collider2D

#### Properties
- public int customShapeCount { get; }
- public int customVertexCount { get; }

#### Constructors
- public CustomCollider2D()

#### Methods
- public void ClearCustomShapes(int shapeIndex, int shapeCount)
- public void ClearCustomShapes()
- private void ClearCustomShapes_Internal(int shapeIndex, int shapeCount)
- public int GetCustomShapes(UnityEngine.PhysicsShapeGroup2D physicsShapeGroup)
- public int GetCustomShapes(UnityEngine.PhysicsShapeGroup2D physicsShapeGroup, int shapeIndex, int shapeCount = 1)
- public int GetCustomShapes(Unity.Collections.NativeArray<UnityEngine.PhysicsShape2D> shapes, Unity.Collections.NativeArray<UnityEngine.Vector2> vertices)
- private int GetCustomShapesNative_Internal(System.IntPtr shapesPtr, int shapeCount, System.IntPtr verticesPtr, int vertexCount)
- private int GetCustomShapes_Internal(ref UnityEngine.PhysicsShapeGroup2D.GroupState physicsShapeGroupState, int shapeIndex, int shapeCount)
- public void SetCustomShape(UnityEngine.PhysicsShapeGroup2D physicsShapeGroup, int srcShapeIndex, int dstShapeIndex)
- public void SetCustomShape(Unity.Collections.NativeArray<UnityEngine.PhysicsShape2D> shapes, Unity.Collections.NativeArray<UnityEngine.Vector2> vertices, int srcShapeIndex, int dstShapeIndex)
- private void SetCustomShapeNative_Internal(System.IntPtr shapesPtr, int shapeCount, System.IntPtr verticesPtr, int vertexCount, int srcShapeIndex, int dstShapeIndex)
- public void SetCustomShapes(UnityEngine.PhysicsShapeGroup2D physicsShapeGroup)
- public void SetCustomShapes(Unity.Collections.NativeArray<UnityEngine.PhysicsShape2D> shapes, Unity.Collections.NativeArray<UnityEngine.Vector2> vertices)
- private void SetCustomShapesAll_Internal(ref UnityEngine.PhysicsShapeGroup2D.GroupState physicsShapeGroupState)
- private void SetCustomShapesNative_Internal(System.IntPtr shapesPtr, int shapeCount, System.IntPtr verticesPtr, int vertexCount)
- private void SetCustomShape_Internal(ref UnityEngine.PhysicsShapeGroup2D.GroupState physicsShapeGroupState, int srcShapeIndex, int dstShapeIndex)

### public class UnityEngine.DistanceJoint2D
- Base: UnityEngine.AnchoredJoint2D

#### Properties
- public bool autoConfigureDistance { get; set; }
- public float distance { get; set; }
- public bool maxDistanceOnly { get; set; }

#### Constructors
- public DistanceJoint2D()

### public class UnityEngine.EdgeCollider2D
- Base: UnityEngine.Collider2D

#### Properties
- public UnityEngine.Vector2 adjacentEndPoint { get; set; }
- public UnityEngine.Vector2 adjacentStartPoint { get; set; }
- public int edgeCount { get; }
- public float edgeRadius { get; set; }
- public int pointCount { get; }
- public UnityEngine.Vector2[] points { get; set; }
- public bool useAdjacentEndPoint { get; set; }
- public bool useAdjacentStartPoint { get; set; }

#### Constructors
- public EdgeCollider2D()

#### Methods
- public int GetPoints(System.Collections.Generic.List<UnityEngine.Vector2> points)
- public void Reset()
- public bool SetPoints(System.Collections.Generic.List<UnityEngine.Vector2> points)

### public class UnityEngine.Effector2D
- Base: UnityEngine.Behaviour

#### Properties
- public int colliderMask { get; set; }
- internal bool designedForNonTrigger { get; }
- internal bool designedForTrigger { get; }
- internal bool requiresCollider { get; }
- public bool useColliderMask { get; set; }

#### Constructors
- public Effector2D()

### public enum UnityEngine.EffectorForceMode2D
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Constant = 0
- InverseLinear = 1
- InverseSquared = 2

### public enum UnityEngine.EffectorSelection2D
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Collider = 1
- Rigidbody = 0

### public class UnityEngine.FixedJoint2D
- Base: UnityEngine.AnchoredJoint2D

#### Properties
- public float dampingRatio { get; set; }
- public float frequency { get; set; }
- public float referenceAngle { get; }

#### Constructors
- public FixedJoint2D()

### public enum UnityEngine.ForceMode2D
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Force = 0
- Impulse = 1

### public class UnityEngine.FrictionJoint2D
- Base: UnityEngine.AnchoredJoint2D

#### Properties
- public float maxForce { get; set; }
- public float maxTorque { get; set; }

#### Constructors
- public FrictionJoint2D()

### public enum UnityEngine.CompositeCollider2D.GenerationType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Manual = 1
- Synchronous = 0

### public enum UnityEngine.CompositeCollider2D.GeometryType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Outlines = 0
- Polygons = 1

### internal enum UnityEngine.Physics2D.GizmoOptions
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AllColliders = 1
- ColliderBounds = 32
- ColliderContacts = 16
- CollidersFilled = 4
- CollidersOutlined = 2
- CollidersSleeping = 8

### internal struct UnityEngine.PhysicsShapeGroup2D.GroupState

#### Fields
- public UnityEngine.Matrix4x4 m_LocalToWorld
- public System.Collections.Generic.List<UnityEngine.PhysicsShape2D> m_Shapes
- public System.Collections.Generic.List<UnityEngine.Vector2> m_Vertices

#### Methods
- public void ClearGeometry()

### public class UnityEngine.HingeJoint2D
- Base: UnityEngine.AnchoredJoint2D

#### Properties
- public float jointAngle { get; }
- public float jointSpeed { get; }
- public UnityEngine.JointAngleLimits2D limits { get; set; }
- public UnityEngine.JointLimitState2D limitState { get; }
- public UnityEngine.JointMotor2D motor { get; set; }
- public float referenceAngle { get; }
- public bool useLimits { get; set; }
- public bool useMotor { get; set; }

#### Constructors
- public HingeJoint2D()

#### Methods
- public float GetMotorTorque(float timeStep)

### public class UnityEngine.Joint2D
- Base: UnityEngine.Behaviour

#### Properties
- public UnityEngine.Rigidbody2D attachedRigidbody { get; }
- public UnityEngine.JointBreakAction2D breakAction { get; set; }
- public float breakForce { get; set; }
- public float breakTorque { get; set; }
- public bool collideConnected { get; set; }
- public UnityEngine.Rigidbody2D connectedBody { get; set; }
- public bool enableCollision { get; set; }
- public UnityEngine.Vector2 reactionForce { get; }
- public float reactionTorque { get; }

#### Constructors
- public Joint2D()

#### Methods
- public UnityEngine.Vector2 GetReactionForce(float timeStep)
- private void GetReactionForce_Injected(float timeStep, out UnityEngine.Vector2 ret)
- public float GetReactionTorque(float timeStep)

### public struct UnityEngine.JointAngleLimits2D

#### Fields
- private float m_LowerAngle
- private float m_UpperAngle

#### Properties
- public float max { get; set; }
- public float min { get; set; }

### public enum UnityEngine.JointBreakAction2D
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CallbackOnly = 1
- Destroy = 3
- Disable = 2
- Ignore = 0

### public enum UnityEngine.JointLimitState2D
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- EqualLimits = 3
- Inactive = 0
- LowerLimit = 1
- UpperLimit = 2

### public struct UnityEngine.JointMotor2D

#### Fields
- private float m_MaximumMotorTorque
- private float m_MotorSpeed

#### Properties
- public float maxMotorTorque { get; set; }
- public float motorSpeed { get; set; }

### public struct UnityEngine.JointSuspension2D

#### Fields
- private float m_Angle
- private float m_DampingRatio
- private float m_Frequency

#### Properties
- public float angle { get; set; }
- public float dampingRatio { get; set; }
- public float frequency { get; set; }

### public struct UnityEngine.JointTranslationLimits2D

#### Fields
- private float m_LowerTranslation
- private float m_UpperTranslation

#### Properties
- public float max { get; set; }
- public float min { get; set; }

### public class UnityEngine.Physics2D

#### Fields
- private static bool <alwaysShowColliders>k__BackingField
- private static bool <showColliderContacts>k__BackingField
- private static bool <showCollidersFilled>k__BackingField
- private static bool <showColliderSleep>k__BackingField
- public static const int AllLayers
- public static const int DefaultRaycastLayers
- public static const int IgnoreRaycastLayer
- public static const int MaxPolygonShapeVertices
- private static System.Collections.Generic.List<UnityEngine.Rigidbody2D> m_LastDisabledRigidbody2D

#### Properties
- public static bool alwaysShowColliders { get; set; }
- public static float angularSleepTolerance { get; set; }
- public static bool autoSimulation { get; set; }
- public static bool autoSyncTransforms { get; set; }
- public static float baumgarteScale { get; set; }
- public static float baumgarteTOIScale { get; set; }
- public static bool callbacksOnDisable { get; set; }
- public static bool changeStopsCallbacks { get; set; }
- public static UnityEngine.Color colliderAABBColor { get; set; }
- public static UnityEngine.Color colliderAsleepColor { get; set; }
- public static UnityEngine.Color colliderAwakeColor { get; set; }
- public static UnityEngine.Color colliderContactColor { get; set; }
- public static float contactArrowScale { get; set; }
- public static float defaultContactOffset { get; set; }
- public static UnityEngine.PhysicsScene2D defaultPhysicsScene { get; }
- public static bool deleteStopsCallbacks { get; set; }
- public static UnityEngine.Vector2 gravity { get; set; }
- public static UnityEngine.PhysicsJobOptions2D jobOptions { get; set; }
- public static float linearSleepTolerance { get; set; }
- public static float maxAngularCorrection { get; set; }
- public static float maxLinearCorrection { get; set; }
- public static float maxRotationSpeed { get; set; }
- public static float maxTranslationSpeed { get; set; }
- public static float minPenetrationForPenalty { get; set; }
- public static int positionIterations { get; set; }
- public static bool queriesHitTriggers { get; set; }
- public static bool queriesStartInColliders { get; set; }
- public static bool raycastsHitTriggers { get; set; }
- public static bool raycastsStartInColliders { get; set; }
- public static bool reuseCollisionCallbacks { get; set; }
- public static bool showColliderAABB { get; set; }
- public static bool showColliderContacts { get; set; }
- public static bool showCollidersFilled { get; set; }
- public static bool showColliderSleep { get; set; }
- public static UnityEngine.SimulationMode2D simulationMode { get; set; }
- public static float timeToSleep { get; set; }
- public static int velocityIterations { get; set; }
- public static float velocityThreshold { get; set; }

#### Constructors
- public Physics2D()
- private static Physics2D()

#### Methods
- public static UnityEngine.RaycastHit2D BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction)
- public static UnityEngine.RaycastHit2D BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance)
- public static UnityEngine.RaycastHit2D BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, int layerMask)
- public static UnityEngine.RaycastHit2D BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth)
- public static UnityEngine.RaycastHit2D BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
- public static int BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- public static int BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results, float distance)
- public static int BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results, float distance = Infinity)
- public static UnityEngine.RaycastHit2D[] BoxCastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction)
- public static UnityEngine.RaycastHit2D[] BoxCastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance)
- public static UnityEngine.RaycastHit2D[] BoxCastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, int layerMask)
- public static UnityEngine.RaycastHit2D[] BoxCastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth)
- public static UnityEngine.RaycastHit2D[] BoxCastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
- private static UnityEngine.RaycastHit2D[] BoxCastAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter)
- private static UnityEngine.RaycastHit2D[] BoxCastAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 size, float angle, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter)
- public static int BoxCastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results)
- public static int BoxCastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance)
- public static int BoxCastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask)
- public static int BoxCastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask, float minDepth)
- public static int BoxCastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask, float minDepth, float maxDepth)
- public static UnityEngine.RaycastHit2D CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction)
- public static UnityEngine.RaycastHit2D CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance)
- public static UnityEngine.RaycastHit2D CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, int layerMask)
- public static UnityEngine.RaycastHit2D CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth)
- public static UnityEngine.RaycastHit2D CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
- public static int CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- public static int CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results, float distance)
- public static int CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results, float distance = Infinity)
- public static UnityEngine.RaycastHit2D[] CapsuleCastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction)
- public static UnityEngine.RaycastHit2D[] CapsuleCastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance)
- public static UnityEngine.RaycastHit2D[] CapsuleCastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, int layerMask)
- public static UnityEngine.RaycastHit2D[] CapsuleCastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth)
- public static UnityEngine.RaycastHit2D[] CapsuleCastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
- private static UnityEngine.RaycastHit2D[] CapsuleCastAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter)
- private static UnityEngine.RaycastHit2D[] CapsuleCastAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter)
- public static int CapsuleCastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results)
- public static int CapsuleCastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance)
- public static int CapsuleCastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask)
- public static int CapsuleCastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask, float minDepth)
- public static int CapsuleCastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask, float minDepth, float maxDepth)
- public static UnityEngine.RaycastHit2D CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction)
- public static UnityEngine.RaycastHit2D CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance)
- public static UnityEngine.RaycastHit2D CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, int layerMask)
- public static UnityEngine.RaycastHit2D CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth)
- public static UnityEngine.RaycastHit2D CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
- public static int CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- public static int CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results, float distance)
- public static int CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results, float distance = Infinity)
- public static UnityEngine.RaycastHit2D[] CircleCastAll(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction)
- public static UnityEngine.RaycastHit2D[] CircleCastAll(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance)
- public static UnityEngine.RaycastHit2D[] CircleCastAll(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, int layerMask)
- public static UnityEngine.RaycastHit2D[] CircleCastAll(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth)
- public static UnityEngine.RaycastHit2D[] CircleCastAll(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
- private static UnityEngine.RaycastHit2D[] CircleCastAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter)
- private static UnityEngine.RaycastHit2D[] CircleCastAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, float radius, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter)
- public static int CircleCastNonAlloc(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results)
- public static int CircleCastNonAlloc(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance)
- public static int CircleCastNonAlloc(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask)
- public static int CircleCastNonAlloc(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask, float minDepth)
- public static int CircleCastNonAlloc(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask, float minDepth, float maxDepth)
- public static UnityEngine.Vector2 ClosestPoint(UnityEngine.Vector2 position, UnityEngine.Collider2D collider)
- public static UnityEngine.Vector2 ClosestPoint(UnityEngine.Vector2 position, UnityEngine.Rigidbody2D rigidbody)
- private static UnityEngine.Vector2 ClosestPoint_Collider(UnityEngine.Vector2 position, UnityEngine.Collider2D collider)
- private static void ClosestPoint_Collider_Injected(ref UnityEngine.Vector2 position, UnityEngine.Collider2D collider, out UnityEngine.Vector2 ret)
- private static UnityEngine.Vector2 ClosestPoint_Rigidbody(UnityEngine.Vector2 position, UnityEngine.Rigidbody2D rigidbody)
- private static void ClosestPoint_Rigidbody_Injected(ref UnityEngine.Vector2 position, UnityEngine.Rigidbody2D rigidbody, out UnityEngine.Vector2 ret)
- public static UnityEngine.ColliderDistance2D Distance(UnityEngine.Collider2D colliderA, UnityEngine.Collider2D colliderB)
- private static UnityEngine.ColliderDistance2D Distance_Internal(UnityEngine.Collider2D colliderA, UnityEngine.Collider2D colliderB)
- private static void Distance_Internal_Injected(UnityEngine.Collider2D colliderA, UnityEngine.Collider2D colliderB, out UnityEngine.ColliderDistance2D ret)
- private static int GetColliderColliderContactsArray(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2, UnityEngine.ContactFilter2D contactFilter, UnityEngine.ContactPoint2D[] results)
- private static int GetColliderColliderContactsArray_Injected(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.ContactPoint2D[] results)
- private static int GetColliderColliderContactsList(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.ContactPoint2D> results)
- private static int GetColliderColliderContactsList_Injected(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.ContactPoint2D> results)
- private static int GetColliderContactsArray(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, UnityEngine.ContactPoint2D[] results)
- private static int GetColliderContactsArray_Injected(UnityEngine.Collider2D collider, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.ContactPoint2D[] results)
- private static int GetColliderContactsCollidersOnlyArray(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- private static int GetColliderContactsCollidersOnlyArray_Injected(UnityEngine.Collider2D collider, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- private static int GetColliderContactsCollidersOnlyList(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- private static int GetColliderContactsCollidersOnlyList_Injected(UnityEngine.Collider2D collider, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- private static int GetColliderContactsList(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.ContactPoint2D> results)
- private static int GetColliderContactsList_Injected(UnityEngine.Collider2D collider, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.ContactPoint2D> results)
- public static int GetContacts(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2, UnityEngine.ContactFilter2D contactFilter, UnityEngine.ContactPoint2D[] contacts)
- public static int GetContacts(UnityEngine.Collider2D collider, UnityEngine.ContactPoint2D[] contacts)
- public static int GetContacts(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, UnityEngine.ContactPoint2D[] contacts)
- public static int GetContacts(UnityEngine.Collider2D collider, UnityEngine.Collider2D[] colliders)
- public static int GetContacts(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] colliders)
- public static int GetContacts(UnityEngine.Rigidbody2D rigidbody, UnityEngine.ContactPoint2D[] contacts)
- public static int GetContacts(UnityEngine.Rigidbody2D rigidbody, UnityEngine.ContactFilter2D contactFilter, UnityEngine.ContactPoint2D[] contacts)
- public static int GetContacts(UnityEngine.Rigidbody2D rigidbody, UnityEngine.Collider2D[] colliders)
- public static int GetContacts(UnityEngine.Rigidbody2D rigidbody, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] colliders)
- public static int GetContacts(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.ContactPoint2D> contacts)
- public static int GetContacts(UnityEngine.Collider2D collider, System.Collections.Generic.List<UnityEngine.ContactPoint2D> contacts)
- public static int GetContacts(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.ContactPoint2D> contacts)
- public static int GetContacts(UnityEngine.Collider2D collider, System.Collections.Generic.List<UnityEngine.Collider2D> colliders)
- public static int GetContacts(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> colliders)
- public static int GetContacts(UnityEngine.Rigidbody2D rigidbody, System.Collections.Generic.List<UnityEngine.ContactPoint2D> contacts)
- public static int GetContacts(UnityEngine.Rigidbody2D rigidbody, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.ContactPoint2D> contacts)
- public static int GetContacts(UnityEngine.Rigidbody2D rigidbody, System.Collections.Generic.List<UnityEngine.Collider2D> colliders)
- public static int GetContacts(UnityEngine.Rigidbody2D rigidbody, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> colliders)
- public static bool GetIgnoreCollision(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2)
- public static bool GetIgnoreLayerCollision(int layer1, int layer2)
- private static bool GetIgnoreLayerCollision_Internal(int layer1, int layer2)
- public static int GetLayerCollisionMask(int layer)
- private static int GetLayerCollisionMask_Internal(int layer)
- public static UnityEngine.RaycastHit2D GetRayIntersection(UnityEngine.Ray ray)
- public static UnityEngine.RaycastHit2D GetRayIntersection(UnityEngine.Ray ray, float distance)
- public static UnityEngine.RaycastHit2D GetRayIntersection(UnityEngine.Ray ray, float distance, int layerMask)
- public static UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray)
- public static UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray, float distance)
- public static UnityEngine.RaycastHit2D[] GetRayIntersectionAll(UnityEngine.Ray ray, float distance, int layerMask)
- private static UnityEngine.RaycastHit2D[] GetRayIntersectionAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layerMask)
- private static UnityEngine.RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector3 origin, ref UnityEngine.Vector3 direction, float distance, int layerMask)
- public static int GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results)
- public static int GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results, float distance)
- public static int GetRayIntersectionNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit2D[] results, float distance, int layerMask)
- private static int GetRigidbodyContactsArray(UnityEngine.Rigidbody2D rigidbody, UnityEngine.ContactFilter2D contactFilter, UnityEngine.ContactPoint2D[] results)
- private static int GetRigidbodyContactsArray_Injected(UnityEngine.Rigidbody2D rigidbody, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.ContactPoint2D[] results)
- private static int GetRigidbodyContactsCollidersOnlyArray(UnityEngine.Rigidbody2D rigidbody, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- private static int GetRigidbodyContactsCollidersOnlyArray_Injected(UnityEngine.Rigidbody2D rigidbody, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- private static int GetRigidbodyContactsCollidersOnlyList(UnityEngine.Rigidbody2D rigidbody, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- private static int GetRigidbodyContactsCollidersOnlyList_Injected(UnityEngine.Rigidbody2D rigidbody, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- private static int GetRigidbodyContactsList(UnityEngine.Rigidbody2D rigidbody, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.ContactPoint2D> results)
- private static int GetRigidbodyContactsList_Injected(UnityEngine.Rigidbody2D rigidbody, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.ContactPoint2D> results)
- public static void IgnoreCollision(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2)
- public static void IgnoreCollision(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2, bool ignore)
- public static void IgnoreLayerCollision(int layer1, int layer2)
- public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore)
- private static void IgnoreLayerCollision_Internal(int layer1, int layer2, bool ignore)
- public static bool IsTouching(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2)
- public static bool IsTouching(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2, UnityEngine.ContactFilter2D contactFilter)
- public static bool IsTouching(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter)
- public static bool IsTouchingLayers(UnityEngine.Collider2D collider)
- public static bool IsTouchingLayers(UnityEngine.Collider2D collider, int layerMask)
- private static bool IsTouching_SingleColliderWithFilter(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter)
- private static bool IsTouching_SingleColliderWithFilter_Injected(UnityEngine.Collider2D collider, ref UnityEngine.ContactFilter2D contactFilter)
- private static bool IsTouching_TwoCollidersWithFilter(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2, UnityEngine.ContactFilter2D contactFilter)
- private static bool IsTouching_TwoCollidersWithFilter_Injected(UnityEngine.Collider2D collider1, UnityEngine.Collider2D collider2, ref UnityEngine.ContactFilter2D contactFilter)
- public static UnityEngine.RaycastHit2D Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end)
- public static UnityEngine.RaycastHit2D Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, int layerMask)
- public static UnityEngine.RaycastHit2D Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, int layerMask, float minDepth)
- public static UnityEngine.RaycastHit2D Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, int layerMask, float minDepth, float maxDepth)
- public static int Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- public static int Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- public static UnityEngine.RaycastHit2D[] LinecastAll(UnityEngine.Vector2 start, UnityEngine.Vector2 end)
- public static UnityEngine.RaycastHit2D[] LinecastAll(UnityEngine.Vector2 start, UnityEngine.Vector2 end, int layerMask)
- public static UnityEngine.RaycastHit2D[] LinecastAll(UnityEngine.Vector2 start, UnityEngine.Vector2 end, int layerMask, float minDepth)
- public static UnityEngine.RaycastHit2D[] LinecastAll(UnityEngine.Vector2 start, UnityEngine.Vector2 end, int layerMask, float minDepth, float maxDepth)
- private static UnityEngine.RaycastHit2D[] LinecastAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter)
- private static UnityEngine.RaycastHit2D[] LinecastAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 start, ref UnityEngine.Vector2 end, ref UnityEngine.ContactFilter2D contactFilter)
- public static int LinecastNonAlloc(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.RaycastHit2D[] results)
- public static int LinecastNonAlloc(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.RaycastHit2D[] results, int layerMask)
- public static int LinecastNonAlloc(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.RaycastHit2D[] results, int layerMask, float minDepth)
- public static int LinecastNonAlloc(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.RaycastHit2D[] results, int layerMask, float minDepth, float maxDepth)
- public static UnityEngine.Collider2D OverlapArea(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB)
- public static UnityEngine.Collider2D OverlapArea(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, int layerMask)
- public static UnityEngine.Collider2D OverlapArea(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, int layerMask, float minDepth)
- public static UnityEngine.Collider2D OverlapArea(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, int layerMask, float minDepth, float maxDepth)
- public static int OverlapArea(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- public static int OverlapArea(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- public static UnityEngine.Collider2D[] OverlapAreaAll(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB)
- public static UnityEngine.Collider2D[] OverlapAreaAll(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, int layerMask)
- public static UnityEngine.Collider2D[] OverlapAreaAll(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, int layerMask, float minDepth)
- public static UnityEngine.Collider2D[] OverlapAreaAll(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, int layerMask, float minDepth, float maxDepth)
- private static UnityEngine.Collider2D[] OverlapAreaAllToBox_Internal(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, int layerMask, float minDepth, float maxDepth)
- public static int OverlapAreaNonAlloc(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.Collider2D[] results)
- public static int OverlapAreaNonAlloc(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.Collider2D[] results, int layerMask)
- public static int OverlapAreaNonAlloc(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.Collider2D[] results, int layerMask, float minDepth)
- public static int OverlapAreaNonAlloc(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.Collider2D[] results, int layerMask, float minDepth, float maxDepth)
- public static UnityEngine.Collider2D OverlapBox(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle)
- public static UnityEngine.Collider2D OverlapBox(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, int layerMask)
- public static UnityEngine.Collider2D OverlapBox(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, int layerMask, float minDepth)
- public static UnityEngine.Collider2D OverlapBox(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, int layerMask, float minDepth, float maxDepth)
- public static int OverlapBox(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- public static int OverlapBox(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- public static UnityEngine.Collider2D[] OverlapBoxAll(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle)
- public static UnityEngine.Collider2D[] OverlapBoxAll(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, int layerMask)
- public static UnityEngine.Collider2D[] OverlapBoxAll(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, int layerMask, float minDepth)
- public static UnityEngine.Collider2D[] OverlapBoxAll(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, int layerMask, float minDepth, float maxDepth)
- private static UnityEngine.Collider2D[] OverlapBoxAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.ContactFilter2D contactFilter)
- private static UnityEngine.Collider2D[] OverlapBoxAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.Vector2 size, float angle, ref UnityEngine.ContactFilter2D contactFilter)
- public static int OverlapBoxNonAlloc(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.Collider2D[] results)
- public static int OverlapBoxNonAlloc(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.Collider2D[] results, int layerMask)
- public static int OverlapBoxNonAlloc(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.Collider2D[] results, int layerMask, float minDepth)
- public static int OverlapBoxNonAlloc(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.Collider2D[] results, int layerMask, float minDepth, float maxDepth)
- public static UnityEngine.Collider2D OverlapCapsule(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle)
- public static UnityEngine.Collider2D OverlapCapsule(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, int layerMask)
- public static UnityEngine.Collider2D OverlapCapsule(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, int layerMask, float minDepth)
- public static UnityEngine.Collider2D OverlapCapsule(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, int layerMask, float minDepth, float maxDepth)
- public static int OverlapCapsule(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- public static int OverlapCapsule(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- public static UnityEngine.Collider2D[] OverlapCapsuleAll(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle)
- public static UnityEngine.Collider2D[] OverlapCapsuleAll(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, int layerMask)
- public static UnityEngine.Collider2D[] OverlapCapsuleAll(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, int layerMask, float minDepth)
- public static UnityEngine.Collider2D[] OverlapCapsuleAll(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, int layerMask, float minDepth, float maxDepth)
- private static UnityEngine.Collider2D[] OverlapCapsuleAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.ContactFilter2D contactFilter)
- private static UnityEngine.Collider2D[] OverlapCapsuleAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, ref UnityEngine.ContactFilter2D contactFilter)
- public static int OverlapCapsuleNonAlloc(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.Collider2D[] results)
- public static int OverlapCapsuleNonAlloc(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.Collider2D[] results, int layerMask)
- public static int OverlapCapsuleNonAlloc(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.Collider2D[] results, int layerMask, float minDepth)
- public static int OverlapCapsuleNonAlloc(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.Collider2D[] results, int layerMask, float minDepth, float maxDepth)
- public static UnityEngine.Collider2D OverlapCircle(UnityEngine.Vector2 point, float radius)
- public static UnityEngine.Collider2D OverlapCircle(UnityEngine.Vector2 point, float radius, int layerMask)
- public static UnityEngine.Collider2D OverlapCircle(UnityEngine.Vector2 point, float radius, int layerMask, float minDepth)
- public static UnityEngine.Collider2D OverlapCircle(UnityEngine.Vector2 point, float radius, int layerMask, float minDepth, float maxDepth)
- public static int OverlapCircle(UnityEngine.Vector2 point, float radius, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- public static int OverlapCircle(UnityEngine.Vector2 point, float radius, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- public static UnityEngine.Collider2D[] OverlapCircleAll(UnityEngine.Vector2 point, float radius)
- public static UnityEngine.Collider2D[] OverlapCircleAll(UnityEngine.Vector2 point, float radius, int layerMask)
- public static UnityEngine.Collider2D[] OverlapCircleAll(UnityEngine.Vector2 point, float radius, int layerMask, float minDepth)
- public static UnityEngine.Collider2D[] OverlapCircleAll(UnityEngine.Vector2 point, float radius, int layerMask, float minDepth, float maxDepth)
- private static UnityEngine.Collider2D[] OverlapCircleAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, float radius, UnityEngine.ContactFilter2D contactFilter)
- private static UnityEngine.Collider2D[] OverlapCircleAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, float radius, ref UnityEngine.ContactFilter2D contactFilter)
- public static int OverlapCircleNonAlloc(UnityEngine.Vector2 point, float radius, UnityEngine.Collider2D[] results)
- public static int OverlapCircleNonAlloc(UnityEngine.Vector2 point, float radius, UnityEngine.Collider2D[] results, int layerMask)
- public static int OverlapCircleNonAlloc(UnityEngine.Vector2 point, float radius, UnityEngine.Collider2D[] results, int layerMask, float minDepth)
- public static int OverlapCircleNonAlloc(UnityEngine.Vector2 point, float radius, UnityEngine.Collider2D[] results, int layerMask, float minDepth, float maxDepth)
- public static int OverlapCollider(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- public static int OverlapCollider(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- public static UnityEngine.Collider2D OverlapPoint(UnityEngine.Vector2 point)
- public static UnityEngine.Collider2D OverlapPoint(UnityEngine.Vector2 point, int layerMask)
- public static UnityEngine.Collider2D OverlapPoint(UnityEngine.Vector2 point, int layerMask, float minDepth)
- public static UnityEngine.Collider2D OverlapPoint(UnityEngine.Vector2 point, int layerMask, float minDepth, float maxDepth)
- public static int OverlapPoint(UnityEngine.Vector2 point, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- public static int OverlapPoint(UnityEngine.Vector2 point, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- public static UnityEngine.Collider2D[] OverlapPointAll(UnityEngine.Vector2 point)
- public static UnityEngine.Collider2D[] OverlapPointAll(UnityEngine.Vector2 point, int layerMask)
- public static UnityEngine.Collider2D[] OverlapPointAll(UnityEngine.Vector2 point, int layerMask, float minDepth)
- public static UnityEngine.Collider2D[] OverlapPointAll(UnityEngine.Vector2 point, int layerMask, float minDepth, float maxDepth)
- private static UnityEngine.Collider2D[] OverlapPointAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.ContactFilter2D contactFilter)
- private static UnityEngine.Collider2D[] OverlapPointAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.ContactFilter2D contactFilter)
- public static int OverlapPointNonAlloc(UnityEngine.Vector2 point, UnityEngine.Collider2D[] results)
- public static int OverlapPointNonAlloc(UnityEngine.Vector2 point, UnityEngine.Collider2D[] results, int layerMask)
- public static int OverlapPointNonAlloc(UnityEngine.Vector2 point, UnityEngine.Collider2D[] results, int layerMask, float minDepth)
- public static int OverlapPointNonAlloc(UnityEngine.Vector2 point, UnityEngine.Collider2D[] results, int layerMask, float minDepth, float maxDepth)
- public static UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction)
- public static UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance)
- public static UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask)
- public static UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth)
- public static UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
- public static int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- public static int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results, float distance)
- public static int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results, float distance = Infinity)
- public static UnityEngine.RaycastHit2D[] RaycastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction)
- public static UnityEngine.RaycastHit2D[] RaycastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance)
- public static UnityEngine.RaycastHit2D[] RaycastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask)
- public static UnityEngine.RaycastHit2D[] RaycastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth)
- public static UnityEngine.RaycastHit2D[] RaycastAll(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
- private static UnityEngine.RaycastHit2D[] RaycastAll_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter)
- private static UnityEngine.RaycastHit2D[] RaycastAll_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter)
- public static int RaycastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results)
- public static int RaycastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance)
- public static int RaycastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask)
- public static int RaycastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask, float minDepth)
- public static int RaycastNonAlloc(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance, int layerMask, float minDepth, float maxDepth)
- internal static void SetEditorDragMovement(bool dragging, UnityEngine.GameObject[] objs)
- public static void SetLayerCollisionMask(int layer, int layerMask)
- private static void SetLayerCollisionMask_Internal(int layer, int layerMask)
- public static bool Simulate(float step)
- internal static bool Simulate_Internal(UnityEngine.PhysicsScene2D physicsScene, float step)
- private static bool Simulate_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, float step)
- public static void SyncTransforms()

### public struct UnityEngine.PhysicsJobOptions2D

#### Fields
- private int m_ClearBodyForcesPerJob
- private int m_ClearFlagsPerJob
- private int m_CollideContactsPerJob
- private int m_FindNearestContactsPerJob
- private int m_InterpolationPosesPerJob
- private int m_IslandSolverBodiesPerJob
- private int m_IslandSolverBodyCostScale
- private int m_IslandSolverContactCostScale
- private int m_IslandSolverContactsPerJob
- private int m_IslandSolverCostThreshold
- private int m_IslandSolverJointCostScale
- private int m_NewContactsPerJob
- private int m_SyncContinuousFixturesPerJob
- private int m_SyncDiscreteFixturesPerJob
- private int m_UpdateTriggerContactsPerJob
- private bool m_UseConsistencySorting
- private bool m_UseMultithreading

#### Properties
- public int clearBodyForcesPerJob { get; set; }
- public int clearFlagsPerJob { get; set; }
- public int collideContactsPerJob { get; set; }
- public int findNearestContactsPerJob { get; set; }
- public int interpolationPosesPerJob { get; set; }
- public int islandSolverBodiesPerJob { get; set; }
- public int islandSolverBodyCostScale { get; set; }
- public int islandSolverContactCostScale { get; set; }
- public int islandSolverContactsPerJob { get; set; }
- public int islandSolverCostThreshold { get; set; }
- public int islandSolverJointCostScale { get; set; }
- public int newContactsPerJob { get; set; }
- public int syncContinuousFixturesPerJob { get; set; }
- public int syncDiscreteFixturesPerJob { get; set; }
- public int updateTriggerContactsPerJob { get; set; }
- public bool useConsistencySorting { get; set; }
- public bool useMultithreading { get; set; }

### public class UnityEngine.PhysicsMaterial2D
- Base: UnityEngine.Object

#### Properties
- public float bounciness { get; set; }
- public float friction { get; set; }

#### Constructors
- public PhysicsMaterial2D()
- public PhysicsMaterial2D(string name)

#### Methods
- private static void Create_Internal(UnityEngine.PhysicsMaterial2D scriptMaterial, string name)

### public struct UnityEngine.PhysicsScene2D
- Interfaces: System.IEquatable<UnityEngine.PhysicsScene2D>

#### Fields
- private int m_Handle

#### Methods
- public UnityEngine.RaycastHit2D BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, int layerMask = -5)
- public UnityEngine.RaycastHit2D BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter)
- public int BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.RaycastHit2D[] results, int layerMask = -5)
- public int BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- public int BoxCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- private static int BoxCastArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- private static int BoxCastArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 size, float angle, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- private static int BoxCastList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- private static int BoxCastList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 size, float angle, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- private static UnityEngine.RaycastHit2D BoxCast_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 size, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter)
- private static void BoxCast_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 size, float angle, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, out UnityEngine.RaycastHit2D ret)
- public UnityEngine.RaycastHit2D CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, int layerMask = -5)
- public UnityEngine.RaycastHit2D CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter)
- public int CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.RaycastHit2D[] results, int layerMask = -5)
- public int CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- public int CapsuleCast(UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- private static int CapsuleCastArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- private static int CapsuleCastArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- private static int CapsuleCastList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- private static int CapsuleCastList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- private static UnityEngine.RaycastHit2D CapsuleCast_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter)
- private static void CapsuleCast_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D capsuleDirection, float angle, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, out UnityEngine.RaycastHit2D ret)
- public UnityEngine.RaycastHit2D CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, int layerMask = -5)
- public UnityEngine.RaycastHit2D CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter)
- public int CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, UnityEngine.RaycastHit2D[] results, int layerMask = -5)
- public int CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- public int CircleCast(UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- private static int CircleCastArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- private static int CircleCastArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, float radius, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- private static int CircleCastList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- private static int CircleCastList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, float radius, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- private static UnityEngine.RaycastHit2D CircleCast_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, float radius, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter)
- private static void CircleCast_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, float radius, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, out UnityEngine.RaycastHit2D ret)
- public override bool Equals(object other)
- public bool Equals(UnityEngine.PhysicsScene2D other)
- public override int GetHashCode()
- public UnityEngine.RaycastHit2D GetRayIntersection(UnityEngine.Ray ray, float distance, int layerMask = -5)
- public int GetRayIntersection(UnityEngine.Ray ray, float distance, UnityEngine.RaycastHit2D[] results, int layerMask = -5)
- private static int GetRayIntersectionArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layerMask, UnityEngine.RaycastHit2D[] results)
- private static int GetRayIntersectionArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector3 origin, ref UnityEngine.Vector3 direction, float distance, int layerMask, UnityEngine.RaycastHit2D[] results)
- private static int GetRayIntersectionList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layerMask, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- private static int GetRayIntersectionList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector3 origin, ref UnityEngine.Vector3 direction, float distance, int layerMask, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- private static UnityEngine.RaycastHit2D GetRayIntersection_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layerMask)
- private static void GetRayIntersection_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector3 origin, ref UnityEngine.Vector3 direction, float distance, int layerMask, out UnityEngine.RaycastHit2D ret)
- public bool IsEmpty()
- private static bool IsEmpty_Internal(UnityEngine.PhysicsScene2D physicsScene)
- private static bool IsEmpty_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene)
- public bool IsValid()
- private static bool IsValid_Internal(UnityEngine.PhysicsScene2D physicsScene)
- private static bool IsValid_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene)
- public UnityEngine.RaycastHit2D Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, int layerMask = -5)
- public UnityEngine.RaycastHit2D Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter)
- public int Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.RaycastHit2D[] results, int layerMask = -5)
- public int Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- public int Linecast(UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- private static int LinecastArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- private static int LinecastArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 start, ref UnityEngine.Vector2 end, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- private static int LinecastNonAllocList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- private static int LinecastNonAllocList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 start, ref UnityEngine.Vector2 end, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- private static UnityEngine.RaycastHit2D Linecast_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 start, UnityEngine.Vector2 end, UnityEngine.ContactFilter2D contactFilter)
- private static void Linecast_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 start, ref UnityEngine.Vector2 end, ref UnityEngine.ContactFilter2D contactFilter, out UnityEngine.RaycastHit2D ret)
- public static bool op_Equality(UnityEngine.PhysicsScene2D lhs, UnityEngine.PhysicsScene2D rhs)
- public static bool op_Inequality(UnityEngine.PhysicsScene2D lhs, UnityEngine.PhysicsScene2D rhs)
- public UnityEngine.Collider2D OverlapArea(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, int layerMask = -5)
- public UnityEngine.Collider2D OverlapArea(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.ContactFilter2D contactFilter)
- public int OverlapArea(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.Collider2D[] results, int layerMask = -5)
- public int OverlapArea(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- public int OverlapArea(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- private UnityEngine.Collider2D OverlapAreaToBoxArray_Internal(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.ContactFilter2D contactFilter)
- private int OverlapAreaToBoxArray_Internal(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- private int OverlapAreaToBoxList_Internal(UnityEngine.Vector2 pointA, UnityEngine.Vector2 pointB, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- public UnityEngine.Collider2D OverlapBox(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, int layerMask = -5)
- public UnityEngine.Collider2D OverlapBox(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.ContactFilter2D contactFilter)
- public int OverlapBox(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.Collider2D[] results, int layerMask = -5)
- public int OverlapBox(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- public int OverlapBox(UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- private static int OverlapBoxArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- private static int OverlapBoxArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.Vector2 size, float angle, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- private static int OverlapBoxList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- private static int OverlapBoxList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.Vector2 size, float angle, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- private static UnityEngine.Collider2D OverlapBox_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.Vector2 size, float angle, UnityEngine.ContactFilter2D contactFilter)
- private static UnityEngine.Collider2D OverlapBox_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.Vector2 size, float angle, ref UnityEngine.ContactFilter2D contactFilter)
- public UnityEngine.Collider2D OverlapCapsule(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, int layerMask = -5)
- public UnityEngine.Collider2D OverlapCapsule(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.ContactFilter2D contactFilter)
- public int OverlapCapsule(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.Collider2D[] results, int layerMask = -5)
- public int OverlapCapsule(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- public int OverlapCapsule(UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- private static int OverlapCapsuleArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- private static int OverlapCapsuleArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- private static int OverlapCapsuleList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- private static int OverlapCapsuleList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- private static UnityEngine.Collider2D OverlapCapsule_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, UnityEngine.ContactFilter2D contactFilter)
- private static UnityEngine.Collider2D OverlapCapsule_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.Vector2 size, UnityEngine.CapsuleDirection2D direction, float angle, ref UnityEngine.ContactFilter2D contactFilter)
- public UnityEngine.Collider2D OverlapCircle(UnityEngine.Vector2 point, float radius, int layerMask = -5)
- public UnityEngine.Collider2D OverlapCircle(UnityEngine.Vector2 point, float radius, UnityEngine.ContactFilter2D contactFilter)
- public int OverlapCircle(UnityEngine.Vector2 point, float radius, UnityEngine.Collider2D[] results, int layerMask = -5)
- public int OverlapCircle(UnityEngine.Vector2 point, float radius, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- public int OverlapCircle(UnityEngine.Vector2 point, float radius, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- private static int OverlapCircleArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, float radius, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- private static int OverlapCircleArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, float radius, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- private static int OverlapCircleList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, float radius, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- private static int OverlapCircleList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, float radius, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- private static UnityEngine.Collider2D OverlapCircle_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, float radius, UnityEngine.ContactFilter2D contactFilter)
- private static UnityEngine.Collider2D OverlapCircle_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, float radius, ref UnityEngine.ContactFilter2D contactFilter)
- public static int OverlapCollider(UnityEngine.Collider2D collider, UnityEngine.Collider2D[] results, int layerMask = -5)
- public static int OverlapCollider(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- public static int OverlapCollider(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- private static int OverlapColliderArray_Internal(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- private static int OverlapColliderArray_Internal_Injected(UnityEngine.Collider2D collider, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- private static int OverlapColliderList_Internal(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- private static int OverlapColliderList_Internal_Injected(UnityEngine.Collider2D collider, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- public UnityEngine.Collider2D OverlapPoint(UnityEngine.Vector2 point, int layerMask = -5)
- public UnityEngine.Collider2D OverlapPoint(UnityEngine.Vector2 point, UnityEngine.ContactFilter2D contactFilter)
- public int OverlapPoint(UnityEngine.Vector2 point, UnityEngine.Collider2D[] results, int layerMask = -5)
- public int OverlapPoint(UnityEngine.Vector2 point, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- public int OverlapPoint(UnityEngine.Vector2 point, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- private static int OverlapPointArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- private static int OverlapPointArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- private static int OverlapPointList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- private static int OverlapPointList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- private static UnityEngine.Collider2D OverlapPoint_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 point, UnityEngine.ContactFilter2D contactFilter)
- private static UnityEngine.Collider2D OverlapPoint_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 point, ref UnityEngine.ContactFilter2D contactFilter)
- public UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, int layerMask = -5)
- public UnityEngine.RaycastHit2D Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter)
- public int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.RaycastHit2D[] results, int layerMask = -5)
- public int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- public int Raycast(UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- private static int RaycastArray_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- private static int RaycastArray_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- private static int RaycastList_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- private static int RaycastList_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- private static UnityEngine.RaycastHit2D Raycast_Internal(UnityEngine.PhysicsScene2D physicsScene, UnityEngine.Vector2 origin, UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter)
- private static void Raycast_Internal_Injected(ref UnityEngine.PhysicsScene2D physicsScene, ref UnityEngine.Vector2 origin, ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, out UnityEngine.RaycastHit2D ret)
- public bool Simulate(float step)
- public override string ToString()

### public static class UnityEngine.PhysicsSceneExtensions2D

#### Methods
- public static UnityEngine.PhysicsScene2D GetPhysicsScene2D(UnityEngine.SceneManagement.Scene scene)
- private static UnityEngine.PhysicsScene2D GetPhysicsScene_Internal(UnityEngine.SceneManagement.Scene scene)
- private static void GetPhysicsScene_Internal_Injected(ref UnityEngine.SceneManagement.Scene scene, out UnityEngine.PhysicsScene2D ret)

### public struct UnityEngine.PhysicsShape2D

#### Fields
- private UnityEngine.Vector2 m_AdjacentEnd
- private UnityEngine.Vector2 m_AdjacentStart
- private float m_Radius
- private UnityEngine.PhysicsShapeType2D m_ShapeType
- private int m_UseAdjacentEnd
- private int m_UseAdjacentStart
- private int m_VertexCount
- private int m_VertexStartIndex

#### Properties
- public UnityEngine.Vector2 adjacentEnd { get; set; }
- public UnityEngine.Vector2 adjacentStart { get; set; }
- public float radius { get; set; }
- public UnityEngine.PhysicsShapeType2D shapeType { get; set; }
- public bool useAdjacentEnd { get; set; }
- public bool useAdjacentStart { get; set; }
- public int vertexCount { get; set; }
- public int vertexStartIndex { get; set; }

### public class UnityEngine.PhysicsShapeGroup2D

#### Fields
- private static const float MinVertexSeparation
- internal UnityEngine.PhysicsShapeGroup2D.GroupState m_GroupState

#### Properties
- internal System.Collections.Generic.List<UnityEngine.PhysicsShape2D> groupShapes { get; }
- internal System.Collections.Generic.List<UnityEngine.Vector2> groupVertices { get; }
- public UnityEngine.Matrix4x4 localToWorldMatrix { get; set; }
- public int shapeCount { get; }
- public int vertexCount { get; }

#### Constructors
- public PhysicsShapeGroup2D(int shapeCapacity = 1, int vertexCapacity = 8)

#### Methods
- internal static UnityEngine.Vector2 <AddBox>g__Rotate|28_0(float cos, float sin, UnityEngine.Vector2 value)
- public void Add(UnityEngine.PhysicsShapeGroup2D physicsShapeGroup)
- public int AddBox(UnityEngine.Vector2 center, UnityEngine.Vector2 size, float angle = 0, float edgeRadius = 0)
- public int AddCapsule(UnityEngine.Vector2 vertex0, UnityEngine.Vector2 vertex1, float radius)
- public int AddCircle(UnityEngine.Vector2 center, float radius)
- public int AddEdges(System.Collections.Generic.List<UnityEngine.Vector2> vertices, float edgeRadius = 0)
- public int AddEdges(System.Collections.Generic.List<UnityEngine.Vector2> vertices, bool useAdjacentStart, bool useAdjacentEnd, UnityEngine.Vector2 adjacentStart, UnityEngine.Vector2 adjacentEnd, float edgeRadius = 0)
- public int AddPolygon(System.Collections.Generic.List<UnityEngine.Vector2> vertices)
- public void Clear()
- public void DeleteShape(int shapeIndex)
- public UnityEngine.PhysicsShape2D GetShape(int shapeIndex)
- public void GetShapeData(System.Collections.Generic.List<UnityEngine.PhysicsShape2D> shapes, System.Collections.Generic.List<UnityEngine.Vector2> vertices)
- public void GetShapeData(Unity.Collections.NativeArray<UnityEngine.PhysicsShape2D> shapes, Unity.Collections.NativeArray<UnityEngine.Vector2> vertices)
- public UnityEngine.Vector2 GetShapeVertex(int shapeIndex, int vertexIndex)
- public void GetShapeVertices(int shapeIndex, System.Collections.Generic.List<UnityEngine.Vector2> vertices)
- public void SetShapeAdjacentVertices(int shapeIndex, bool useAdjacentStart, bool useAdjacentEnd, UnityEngine.Vector2 adjacentStart, UnityEngine.Vector2 adjacentEnd)
- public void SetShapeRadius(int shapeIndex, float radius)
- public void SetShapeVertex(int shapeIndex, int vertexIndex, UnityEngine.Vector2 vertex)

### public enum UnityEngine.PhysicsShapeType2D
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Capsule = 1
- Circle = 0
- Edges = 3
- Polygon = 2

### public class UnityEngine.PhysicsUpdateBehaviour2D
- Base: UnityEngine.Behaviour

#### Constructors
- public PhysicsUpdateBehaviour2D()

### public class UnityEngine.PlatformEffector2D
- Base: UnityEngine.Effector2D

#### Properties
- public bool oneWay { get; set; }
- public float rotationalOffset { get; set; }
- public float sideAngleVariance { get; set; }
- public float sideArc { get; set; }
- public bool sideBounce { get; set; }
- public bool sideFriction { get; set; }
- public float surfaceArc { get; set; }
- public bool useOneWay { get; set; }
- public bool useOneWayGrouping { get; set; }
- public bool useSideBounce { get; set; }
- public bool useSideFriction { get; set; }

#### Constructors
- public PlatformEffector2D()

### public class UnityEngine.PointEffector2D
- Base: UnityEngine.Effector2D

#### Properties
- public float angularDrag { get; set; }
- public float distanceScale { get; set; }
- public float drag { get; set; }
- public float forceMagnitude { get; set; }
- public UnityEngine.EffectorForceMode2D forceMode { get; set; }
- public UnityEngine.EffectorSelection2D forceSource { get; set; }
- public UnityEngine.EffectorSelection2D forceTarget { get; set; }
- public float forceVariation { get; set; }

#### Constructors
- public PointEffector2D()

### public class UnityEngine.PolygonCollider2D
- Base: UnityEngine.Collider2D

#### Properties
- public bool autoTiling { get; set; }
- public int pathCount { get; set; }
- public UnityEngine.Vector2[] points { get; set; }
- public bool useDelaunayMesh { get; set; }

#### Constructors
- public PolygonCollider2D()

#### Methods
- public void CreatePrimitive(int sides)
- public void CreatePrimitive(int sides, UnityEngine.Vector2 scale)
- public void CreatePrimitive(int sides, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset)
- private void CreatePrimitive_Internal(int sides, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, bool autoRefresh)
- private void CreatePrimitive_Internal_Injected(int sides, ref UnityEngine.Vector2 scale, ref UnityEngine.Vector2 offset, bool autoRefresh)
- public UnityEngine.Vector2[] GetPath(int index)
- public int GetPath(int index, System.Collections.Generic.List<UnityEngine.Vector2> points)
- private int GetPathList_Internal(int index, System.Collections.Generic.List<UnityEngine.Vector2> points)
- private UnityEngine.Vector2[] GetPath_Internal(int index)
- public int GetTotalPointCount()
- public void SetPath(int index, UnityEngine.Vector2[] points)
- public void SetPath(int index, System.Collections.Generic.List<UnityEngine.Vector2> points)
- private void SetPathList_Internal(int index, System.Collections.Generic.List<UnityEngine.Vector2> points)
- private void SetPath_Internal(int index, UnityEngine.Vector2[] points)

### public struct UnityEngine.RaycastHit2D

#### Fields
- private UnityEngine.Vector2 m_Centroid
- private int m_Collider
- private float m_Distance
- private float m_Fraction
- private UnityEngine.Vector2 m_Normal
- private UnityEngine.Vector2 m_Point

#### Properties
- public UnityEngine.Vector2 centroid { get; set; }
- public UnityEngine.Collider2D collider { get; }
- public float distance { get; set; }
- public float fraction { get; set; }
- public UnityEngine.Vector2 normal { get; set; }
- public UnityEngine.Vector2 point { get; set; }
- public UnityEngine.Rigidbody2D rigidbody { get; }
- public UnityEngine.Transform transform { get; }

#### Methods
- public int CompareTo(UnityEngine.RaycastHit2D other)
- public static bool op_Implicit(UnityEngine.RaycastHit2D hit)

### public class UnityEngine.RelativeJoint2D
- Base: UnityEngine.Joint2D

#### Properties
- public float angularOffset { get; set; }
- public bool autoConfigureOffset { get; set; }
- public float correctionScale { get; set; }
- public UnityEngine.Vector2 linearOffset { get; set; }
- public float maxForce { get; set; }
- public float maxTorque { get; set; }
- public UnityEngine.Vector2 target { get; }

#### Constructors
- public RelativeJoint2D()

### public class UnityEngine.Rigidbody2D
- Base: UnityEngine.Component

#### Properties
- public float angularDrag { get; set; }
- public float angularVelocity { get; set; }
- public int attachedColliderCount { get; }
- public UnityEngine.RigidbodyType2D bodyType { get; set; }
- public UnityEngine.Vector2 centerOfMass { get; set; }
- public UnityEngine.CollisionDetectionMode2D collisionDetectionMode { get; set; }
- public UnityEngine.RigidbodyConstraints2D constraints { get; set; }
- public float drag { get; set; }
- public UnityEngine.LayerMask excludeLayers { get; set; }
- public bool fixedAngle { get; set; }
- public bool freezeRotation { get; set; }
- public float gravityScale { get; set; }
- public UnityEngine.LayerMask includeLayers { get; set; }
- public float inertia { get; set; }
- public UnityEngine.RigidbodyInterpolation2D interpolation { get; set; }
- public bool isKinematic { get; set; }
- public float mass { get; set; }
- public UnityEngine.Vector2 position { get; set; }
- public float rotation { get; set; }
- public UnityEngine.PhysicsMaterial2D sharedMaterial { get; set; }
- public bool simulated { get; set; }
- public UnityEngine.RigidbodySleepMode2D sleepMode { get; set; }
- public UnityEngine.Vector2 totalForce { get; set; }
- public float totalTorque { get; set; }
- public bool useAutoMass { get; set; }
- public bool useFullKinematicContacts { get; set; }
- public UnityEngine.Vector2 velocity { get; set; }
- public UnityEngine.Vector2 worldCenterOfMass { get; }

#### Constructors
- public Rigidbody2D()

#### Methods
- public void AddForce(UnityEngine.Vector2 force)
- public void AddForce(UnityEngine.Vector2 force, UnityEngine.ForceMode2D mode)
- public void AddForceAtPosition(UnityEngine.Vector2 force, UnityEngine.Vector2 position)
- public void AddForceAtPosition(UnityEngine.Vector2 force, UnityEngine.Vector2 position, UnityEngine.ForceMode2D mode)
- private void AddForceAtPosition_Injected(ref UnityEngine.Vector2 force, ref UnityEngine.Vector2 position, UnityEngine.ForceMode2D mode)
- private void AddForce_Injected(ref UnityEngine.Vector2 force, UnityEngine.ForceMode2D mode)
- public void AddRelativeForce(UnityEngine.Vector2 relativeForce)
- public void AddRelativeForce(UnityEngine.Vector2 relativeForce, UnityEngine.ForceMode2D mode)
- private void AddRelativeForce_Injected(ref UnityEngine.Vector2 relativeForce, UnityEngine.ForceMode2D mode)
- public void AddTorque(float torque)
- public void AddTorque(float torque, UnityEngine.ForceMode2D mode)
- public int Cast(UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results)
- public int Cast(UnityEngine.Vector2 direction, UnityEngine.RaycastHit2D[] results, float distance)
- public int Cast(UnityEngine.Vector2 direction, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results, float distance = Infinity)
- public int Cast(UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- public int Cast(UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results, float distance)
- public int Cast(UnityEngine.Vector2 direction, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results, float distance)
- private int CastArray_Internal(UnityEngine.Vector2 direction, float distance, UnityEngine.RaycastHit2D[] results)
- private int CastArray_Internal_Injected(ref UnityEngine.Vector2 direction, float distance, UnityEngine.RaycastHit2D[] results)
- private int CastFilteredArray_Internal(UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- private int CastFilteredArray_Internal_Injected(ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.RaycastHit2D[] results)
- private int CastFilteredList_Internal(UnityEngine.Vector2 direction, float distance, UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- private int CastFilteredList_Internal_Injected(ref UnityEngine.Vector2 direction, float distance, ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- private int CastList_Internal(UnityEngine.Vector2 direction, float distance, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- private int CastList_Internal_Injected(ref UnityEngine.Vector2 direction, float distance, System.Collections.Generic.List<UnityEngine.RaycastHit2D> results)
- public UnityEngine.Vector2 ClosestPoint(UnityEngine.Vector2 position)
- public UnityEngine.ColliderDistance2D Distance(UnityEngine.Collider2D collider)
- private UnityEngine.ColliderDistance2D Distance_Internal(UnityEngine.Collider2D collider)
- private void Distance_Internal_Injected(UnityEngine.Collider2D collider, out UnityEngine.ColliderDistance2D ret)
- public int GetAttachedColliders(UnityEngine.Collider2D[] results)
- public int GetAttachedColliders(System.Collections.Generic.List<UnityEngine.Collider2D> results)
- private int GetAttachedCollidersArray_Internal(UnityEngine.Collider2D[] results)
- private int GetAttachedCollidersList_Internal(System.Collections.Generic.List<UnityEngine.Collider2D> results)
- public int GetContacts(UnityEngine.ContactPoint2D[] contacts)
- public int GetContacts(System.Collections.Generic.List<UnityEngine.ContactPoint2D> contacts)
- public int GetContacts(UnityEngine.ContactFilter2D contactFilter, UnityEngine.ContactPoint2D[] contacts)
- public int GetContacts(UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.ContactPoint2D> contacts)
- public int GetContacts(UnityEngine.Collider2D[] colliders)
- public int GetContacts(System.Collections.Generic.List<UnityEngine.Collider2D> colliders)
- public int GetContacts(UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] colliders)
- public int GetContacts(UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> colliders)
- public UnityEngine.Vector2 GetPoint(UnityEngine.Vector2 point)
- public UnityEngine.Vector2 GetPointVelocity(UnityEngine.Vector2 point)
- private void GetPointVelocity_Injected(ref UnityEngine.Vector2 point, out UnityEngine.Vector2 ret)
- private void GetPoint_Injected(ref UnityEngine.Vector2 point, out UnityEngine.Vector2 ret)
- public UnityEngine.Vector2 GetRelativePoint(UnityEngine.Vector2 relativePoint)
- public UnityEngine.Vector2 GetRelativePointVelocity(UnityEngine.Vector2 relativePoint)
- private void GetRelativePointVelocity_Injected(ref UnityEngine.Vector2 relativePoint, out UnityEngine.Vector2 ret)
- private void GetRelativePoint_Injected(ref UnityEngine.Vector2 relativePoint, out UnityEngine.Vector2 ret)
- public UnityEngine.Vector2 GetRelativeVector(UnityEngine.Vector2 relativeVector)
- private void GetRelativeVector_Injected(ref UnityEngine.Vector2 relativeVector, out UnityEngine.Vector2 ret)
- public int GetShapes(UnityEngine.PhysicsShapeGroup2D physicsShapeGroup)
- private int GetShapes_Internal(ref UnityEngine.PhysicsShapeGroup2D.GroupState physicsShapeGroupState)
- public UnityEngine.Vector2 GetVector(UnityEngine.Vector2 vector)
- private void GetVector_Injected(ref UnityEngine.Vector2 vector, out UnityEngine.Vector2 ret)
- public bool IsAwake()
- public bool IsSleeping()
- public bool IsTouching(UnityEngine.Collider2D collider)
- public bool IsTouching(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter)
- public bool IsTouching(UnityEngine.ContactFilter2D contactFilter)
- public bool IsTouchingLayers()
- public bool IsTouchingLayers(int layerMask)
- private bool IsTouching_AnyColliderWithFilter_Internal(UnityEngine.ContactFilter2D contactFilter)
- private bool IsTouching_AnyColliderWithFilter_Internal_Injected(ref UnityEngine.ContactFilter2D contactFilter)
- private bool IsTouching_OtherColliderWithFilter_Internal(UnityEngine.Collider2D collider, UnityEngine.ContactFilter2D contactFilter)
- private bool IsTouching_OtherColliderWithFilter_Internal_Injected(UnityEngine.Collider2D collider, ref UnityEngine.ContactFilter2D contactFilter)
- public void MovePosition(UnityEngine.Vector2 position)
- private void MovePosition_Injected(ref UnityEngine.Vector2 position)
- public void MoveRotation(float angle)
- public void MoveRotation(UnityEngine.Quaternion rotation)
- private void MoveRotation_Angle(float angle)
- private void MoveRotation_Quaternion(UnityEngine.Quaternion rotation)
- private void MoveRotation_Quaternion_Injected(ref UnityEngine.Quaternion rotation)
- public int OverlapCollider(UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- public int OverlapCollider(UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- private int OverlapColliderArray_Internal(UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- private int OverlapColliderArray_Internal_Injected(ref UnityEngine.ContactFilter2D contactFilter, UnityEngine.Collider2D[] results)
- private int OverlapColliderList_Internal(UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- private int OverlapColliderList_Internal_Injected(ref UnityEngine.ContactFilter2D contactFilter, System.Collections.Generic.List<UnityEngine.Collider2D> results)
- public bool OverlapPoint(UnityEngine.Vector2 point)
- private bool OverlapPoint_Injected(ref UnityEngine.Vector2 point)
- internal void SetDragBehaviour(bool dragged)
- public void SetRotation(float angle)
- public void SetRotation(UnityEngine.Quaternion rotation)
- private void SetRotation_Angle(float angle)
- private void SetRotation_Quaternion(UnityEngine.Quaternion rotation)
- private void SetRotation_Quaternion_Injected(ref UnityEngine.Quaternion rotation)
- public void Sleep()
- public void WakeUp()

### public enum UnityEngine.RigidbodyConstraints2D
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FreezeAll = 7
- FreezePosition = 3
- FreezePositionX = 1
- FreezePositionY = 2
- FreezeRotation = 4
- None = 0

### public enum UnityEngine.RigidbodyInterpolation2D
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Extrapolate = 2
- Interpolate = 1
- None = 0

### public enum UnityEngine.RigidbodySleepMode2D
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- NeverSleep = 0
- StartAsleep = 2
- StartAwake = 1

### public enum UnityEngine.RigidbodyType2D
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Dynamic = 0
- Kinematic = 1
- Static = 2

### public enum UnityEngine.SimulationMode2D
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FixedUpdate = 0
- Script = 2
- Update = 1

### public class UnityEngine.SliderJoint2D
- Base: UnityEngine.AnchoredJoint2D

#### Properties
- public float angle { get; set; }
- public bool autoConfigureAngle { get; set; }
- public float jointSpeed { get; }
- public float jointTranslation { get; }
- public UnityEngine.JointTranslationLimits2D limits { get; set; }
- public UnityEngine.JointLimitState2D limitState { get; }
- public UnityEngine.JointMotor2D motor { get; set; }
- public float referenceAngle { get; }
- public bool useLimits { get; set; }
- public bool useMotor { get; set; }

#### Constructors
- public SliderJoint2D()

#### Methods
- public float GetMotorForce(float timeStep)

### public class UnityEngine.SpringJoint2D
- Base: UnityEngine.AnchoredJoint2D

#### Properties
- public bool autoConfigureDistance { get; set; }
- public float dampingRatio { get; set; }
- public float distance { get; set; }
- public float frequency { get; set; }

#### Constructors
- public SpringJoint2D()

### public class UnityEngine.SurfaceEffector2D
- Base: UnityEngine.Effector2D

#### Properties
- public float forceScale { get; set; }
- public float speed { get; set; }
- public float speedVariation { get; set; }
- public bool useBounce { get; set; }
- public bool useContactForce { get; set; }
- public bool useFriction { get; set; }

#### Constructors
- public SurfaceEffector2D()

### public class UnityEngine.TargetJoint2D
- Base: UnityEngine.Joint2D

#### Properties
- public UnityEngine.Vector2 anchor { get; set; }
- public bool autoConfigureTarget { get; set; }
- public float dampingRatio { get; set; }
- public float frequency { get; set; }
- public float maxForce { get; set; }
- public UnityEngine.Vector2 target { get; set; }

#### Constructors
- public TargetJoint2D()

### public class UnityEngine.WheelJoint2D
- Base: UnityEngine.AnchoredJoint2D

#### Properties
- public float jointAngle { get; }
- public float jointLinearSpeed { get; }
- public float jointSpeed { get; }
- public float jointTranslation { get; }
- public UnityEngine.JointMotor2D motor { get; set; }
- public UnityEngine.JointSuspension2D suspension { get; set; }
- public bool useMotor { get; set; }

#### Constructors
- public WheelJoint2D()

#### Methods
- public float GetMotorTorque(float timeStep)

