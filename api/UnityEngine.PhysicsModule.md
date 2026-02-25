# Assembly: UnityEngine.PhysicsModule
- Path: tools/WorldBox.Managed/UnityEngine.PhysicsModule.dll
- Types: 73

## Namespace: UnityEngine

### public struct UnityEngine.ArticulationReducedSpace.<x>e__FixedBuffer

#### Fields
- public float FixedElementField

### public class UnityEngine.ArticulationBody
- Base: UnityEngine.Behaviour

#### Properties
- public UnityEngine.Vector3 anchorPosition { get; set; }
- public UnityEngine.Quaternion anchorRotation { get; set; }
- public float angularDamping { get; set; }
- public UnityEngine.Vector3 angularVelocity { get; set; }
- public bool automaticCenterOfMass { get; set; }
- public bool automaticInertiaTensor { get; set; }
- public UnityEngine.Vector3 centerOfMass { get; set; }
- public UnityEngine.CollisionDetectionMode collisionDetectionMode { get; set; }
- public bool computeParentAnchor { get; set; }
- public int dofCount { get; }
- public UnityEngine.ArticulationReducedSpace driveForce { get; }
- public UnityEngine.LayerMask excludeLayers { get; set; }
- public bool immovable { get; set; }
- public UnityEngine.LayerMask includeLayers { get; set; }
- public int index { get; }
- public UnityEngine.Vector3 inertiaTensor { get; set; }
- public UnityEngine.Quaternion inertiaTensorRotation { get; set; }
- public bool isRoot { get; }
- public UnityEngine.ArticulationReducedSpace jointAcceleration { get; set; }
- public UnityEngine.ArticulationReducedSpace jointForce { get; set; }
- public float jointFriction { get; set; }
- public UnityEngine.ArticulationReducedSpace jointPosition { get; set; }
- public UnityEngine.ArticulationJointType jointType { get; set; }
- public UnityEngine.ArticulationReducedSpace jointVelocity { get; set; }
- public float linearDamping { get; set; }
- public UnityEngine.ArticulationDofLock linearLockX { get; set; }
- public UnityEngine.ArticulationDofLock linearLockY { get; set; }
- public UnityEngine.ArticulationDofLock linearLockZ { get; set; }
- public float mass { get; set; }
- public bool matchAnchors { get; set; }
- public float maxAngularVelocity { get; set; }
- public float maxDepenetrationVelocity { get; set; }
- public float maxJointVelocity { get; set; }
- public float maxLinearVelocity { get; set; }
- public UnityEngine.Vector3 parentAnchorPosition { get; set; }
- public UnityEngine.Quaternion parentAnchorRotation { get; set; }
- public float sleepThreshold { get; set; }
- public int solverIterations { get; set; }
- public int solverVelocityIterations { get; set; }
- public UnityEngine.ArticulationDofLock swingYLock { get; set; }
- public UnityEngine.ArticulationDofLock swingZLock { get; set; }
- public UnityEngine.ArticulationDofLock twistLock { get; set; }
- public bool useGravity { get; set; }
- public UnityEngine.Vector3 velocity { get; set; }
- public UnityEngine.Vector3 worldCenterOfMass { get; }
- public UnityEngine.ArticulationDrive xDrive { get; set; }
- public UnityEngine.ArticulationDrive yDrive { get; set; }
- public UnityEngine.ArticulationDrive zDrive { get; set; }

#### Constructors
- public ArticulationBody()

#### Methods
- public void AddForce(UnityEngine.Vector3 force, UnityEngine.ForceMode mode)
- public void AddForce(UnityEngine.Vector3 force)
- public void AddForceAtPosition(UnityEngine.Vector3 force, UnityEngine.Vector3 position, UnityEngine.ForceMode mode)
- public void AddForceAtPosition(UnityEngine.Vector3 force, UnityEngine.Vector3 position)
- private void AddForceAtPosition_Injected(ref UnityEngine.Vector3 force, ref UnityEngine.Vector3 position, UnityEngine.ForceMode mode)
- private void AddForce_Injected(ref UnityEngine.Vector3 force, UnityEngine.ForceMode mode)
- public void AddRelativeForce(UnityEngine.Vector3 force, UnityEngine.ForceMode mode)
- public void AddRelativeForce(UnityEngine.Vector3 force)
- private void AddRelativeForce_Injected(ref UnityEngine.Vector3 force, UnityEngine.ForceMode mode)
- public void AddRelativeTorque(UnityEngine.Vector3 torque, UnityEngine.ForceMode mode)
- public void AddRelativeTorque(UnityEngine.Vector3 torque)
- private void AddRelativeTorque_Injected(ref UnityEngine.Vector3 torque, UnityEngine.ForceMode mode)
- public void AddTorque(UnityEngine.Vector3 torque, UnityEngine.ForceMode mode)
- public void AddTorque(UnityEngine.Vector3 torque)
- private void AddTorque_Injected(ref UnityEngine.Vector3 torque, UnityEngine.ForceMode mode)
- public UnityEngine.Vector3 GetAccumulatedForce(float step)
- public UnityEngine.Vector3 GetAccumulatedForce()
- private void GetAccumulatedForce_Injected(float step, out UnityEngine.Vector3 ret)
- public UnityEngine.Vector3 GetAccumulatedTorque(float step)
- public UnityEngine.Vector3 GetAccumulatedTorque()
- private void GetAccumulatedTorque_Injected(float step, out UnityEngine.Vector3 ret)
- public UnityEngine.Vector3 GetClosestPoint(UnityEngine.Vector3 point)
- private void GetClosestPoint_Injected(ref UnityEngine.Vector3 point, out UnityEngine.Vector3 ret)
- public int GetDenseJacobian(ref UnityEngine.ArticulationJacobian jacobian)
- private int GetDenseJacobian_Internal(ref UnityEngine.ArticulationJacobian jacobian)
- public int GetDofStartIndices(System.Collections.Generic.List<int> dofStartIndices)
- public int GetDriveForces(System.Collections.Generic.List<float> forces)
- public int GetDriveTargets(System.Collections.Generic.List<float> targets)
- public int GetDriveTargetVelocities(System.Collections.Generic.List<float> targetVelocities)
- public int GetJointAccelerations(System.Collections.Generic.List<float> accelerations)
- public int GetJointCoriolisCentrifugalForces(System.Collections.Generic.List<float> forces)
- public int GetJointExternalForces(System.Collections.Generic.List<float> forces, float step)
- public int GetJointForces(System.Collections.Generic.List<float> forces)
- public UnityEngine.ArticulationReducedSpace GetJointForcesForAcceleration(UnityEngine.ArticulationReducedSpace acceleration)
- private void GetJointForcesForAcceleration_Injected(ref UnityEngine.ArticulationReducedSpace acceleration, out UnityEngine.ArticulationReducedSpace ret)
- public int GetJointGravityForces(System.Collections.Generic.List<float> forces)
- public int GetJointPositions(System.Collections.Generic.List<float> positions)
- public int GetJointVelocities(System.Collections.Generic.List<float> velocities)
- public UnityEngine.Vector3 GetPointVelocity(UnityEngine.Vector3 worldPoint)
- private void GetPointVelocity_Injected(ref UnityEngine.Vector3 worldPoint, out UnityEngine.Vector3 ret)
- public UnityEngine.Vector3 GetRelativePointVelocity(UnityEngine.Vector3 relativePoint)
- private void GetRelativePointVelocity_Injected(ref UnityEngine.Vector3 relativePoint, out UnityEngine.Vector3 ret)
- public bool IsSleeping()
- public void ResetCenterOfMass()
- public void ResetInertiaTensor()
- public void SetDriveDamping(UnityEngine.ArticulationDriveAxis axis, float value)
- public void SetDriveForceLimit(UnityEngine.ArticulationDriveAxis axis, float value)
- public void SetDriveLimits(UnityEngine.ArticulationDriveAxis axis, float lower, float upper)
- public void SetDriveStiffness(UnityEngine.ArticulationDriveAxis axis, float value)
- public void SetDriveTarget(UnityEngine.ArticulationDriveAxis axis, float value)
- public void SetDriveTargets(System.Collections.Generic.List<float> targets)
- public void SetDriveTargetVelocities(System.Collections.Generic.List<float> targetVelocities)
- public void SetDriveTargetVelocity(UnityEngine.ArticulationDriveAxis axis, float value)
- public void SetJointAccelerations(System.Collections.Generic.List<float> accelerations)
- public void SetJointForces(System.Collections.Generic.List<float> forces)
- public void SetJointPositions(System.Collections.Generic.List<float> positions)
- public void SetJointVelocities(System.Collections.Generic.List<float> velocities)
- public void Sleep()
- public void SnapAnchorToClosestContact()
- public void TeleportRoot(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
- private void TeleportRoot_Injected(ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation)
- public void WakeUp()

### public enum UnityEngine.ArticulationDofLock
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FreeMotion = 2
- LimitedMotion = 1
- LockedMotion = 0

### public struct UnityEngine.ArticulationDrive

#### Fields
- public float damping
- public UnityEngine.ArticulationDriveType driveType
- public float forceLimit
- public float lowerLimit
- public float stiffness
- public float target
- public float targetVelocity
- public float upperLimit

### public enum UnityEngine.ArticulationDriveAxis
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- X = 0
- Y = 1
- Z = 2

### public enum UnityEngine.ArticulationDriveType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Acceleration = 1
- Force = 0
- Target = 2
- Velocity = 3

### public struct UnityEngine.ArticulationJacobian

#### Fields
- private int colsCount
- private System.Collections.Generic.List<float> matrixData
- private int rowsCount

#### Properties
- public int columns { get; set; }
- public System.Collections.Generic.List<float> elements { get; set; }
- public float Item { get; set; }
- public int rows { get; set; }

#### Constructors
- public ArticulationJacobian(int rows, int cols)

### public enum UnityEngine.ArticulationJointType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FixedJoint = 0
- PrismaticJoint = 1
- RevoluteJoint = 2
- SphericalJoint = 3

### public struct UnityEngine.ArticulationReducedSpace

#### Fields
- public int dofCount
- private UnityEngine.ArticulationReducedSpace.<x>e__FixedBuffer x

#### Properties
- public float Item { get; set; }

#### Constructors
- public ArticulationReducedSpace(float a)
- public ArticulationReducedSpace(float a, float b)
- public ArticulationReducedSpace(float a, float b, float c)

### public struct UnityEngine.BoxcastCommand

#### Fields
- private UnityEngine.Vector3 <center>k__BackingField
- private UnityEngine.Vector3 <direction>k__BackingField
- private float <distance>k__BackingField
- private UnityEngine.Vector3 <halfExtents>k__BackingField
- private UnityEngine.Quaternion <orientation>k__BackingField
- private UnityEngine.PhysicsScene <physicsScene>k__BackingField
- public UnityEngine.QueryParameters queryParameters

#### Properties
- public UnityEngine.Vector3 center { get; set; }
- public UnityEngine.Vector3 direction { get; set; }
- public float distance { get; set; }
- public UnityEngine.Vector3 halfExtents { get; set; }
- public int layerMask { get; set; }
- public UnityEngine.Quaternion orientation { get; set; }
- public UnityEngine.PhysicsScene physicsScene { get; set; }

#### Constructors
- public BoxcastCommand(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, UnityEngine.Vector3 direction, UnityEngine.QueryParameters queryParameters, float distance = 3.4028235E+38)
- public BoxcastCommand(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, UnityEngine.Vector3 direction, float distance = 3.4028235E+38, int layerMask = -5)
- public BoxcastCommand(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, UnityEngine.Vector3 direction, UnityEngine.QueryParameters queryParameters, float distance = 3.4028235E+38)
- public BoxcastCommand(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, UnityEngine.Vector3 direction, float distance = 3.4028235E+38, int layerMask = -5)

#### Methods
- public static Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.BoxcastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, int minCommandsPerJob, int maxHits, Unity.Jobs.JobHandle dependsOn = null)
- public static Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.BoxcastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, int minCommandsPerJob, Unity.Jobs.JobHandle dependsOn = null)
- private static Unity.Jobs.JobHandle ScheduleBoxcastBatch(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits)
- private static void ScheduleBoxcastBatch_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits, out Unity.Jobs.JobHandle ret)

### public class UnityEngine.BoxCollider
- Base: UnityEngine.Collider

#### Properties
- public UnityEngine.Vector3 center { get; set; }
- public UnityEngine.Vector3 extents { get; set; }
- public UnityEngine.Vector3 size { get; set; }

#### Constructors
- public BoxCollider()

### public struct UnityEngine.CapsulecastCommand

#### Fields
- private UnityEngine.Vector3 <direction>k__BackingField
- private float <distance>k__BackingField
- private UnityEngine.PhysicsScene <physicsScene>k__BackingField
- private UnityEngine.Vector3 <point1>k__BackingField
- private UnityEngine.Vector3 <point2>k__BackingField
- private float <radius>k__BackingField
- public UnityEngine.QueryParameters queryParameters

#### Properties
- public UnityEngine.Vector3 direction { get; set; }
- public float distance { get; set; }
- public int layerMask { get; set; }
- public UnityEngine.PhysicsScene physicsScene { get; set; }
- public UnityEngine.Vector3 point1 { get; set; }
- public UnityEngine.Vector3 point2 { get; set; }
- public float radius { get; set; }

#### Constructors
- public CapsulecastCommand(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, float radius, UnityEngine.Vector3 direction, UnityEngine.QueryParameters queryParameters, float distance = 3.4028235E+38)
- public CapsulecastCommand(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, float radius, UnityEngine.Vector3 direction, float distance = 3.4028235E+38, int layerMask = -5)
- public CapsulecastCommand(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, float radius, UnityEngine.Vector3 direction, UnityEngine.QueryParameters queryParameters, float distance = 3.4028235E+38)
- public CapsulecastCommand(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, float radius, UnityEngine.Vector3 direction, float distance = 3.4028235E+38, int layerMask = -5)

#### Methods
- public static Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.CapsulecastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, int minCommandsPerJob, int maxHits, Unity.Jobs.JobHandle dependsOn = null)
- public static Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.CapsulecastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, int minCommandsPerJob, Unity.Jobs.JobHandle dependsOn = null)
- private static Unity.Jobs.JobHandle ScheduleCapsulecastBatch(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits)
- private static void ScheduleCapsulecastBatch_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits, out Unity.Jobs.JobHandle ret)

### public class UnityEngine.CapsuleCollider
- Base: UnityEngine.Collider

#### Properties
- public UnityEngine.Vector3 center { get; set; }
- public int direction { get; set; }
- public float height { get; set; }
- public float radius { get; set; }

#### Constructors
- public CapsuleCollider()

#### Methods
- internal UnityEngine.Matrix4x4 CalculateTransform()
- private void CalculateTransform_Injected(out UnityEngine.Matrix4x4 ret)
- internal UnityEngine.Vector2 GetGlobalExtents()
- private void GetGlobalExtents_Injected(out UnityEngine.Vector2 ret)

### public class UnityEngine.CharacterController
- Base: UnityEngine.Collider

#### Properties
- public UnityEngine.Vector3 center { get; set; }
- public UnityEngine.CollisionFlags collisionFlags { get; }
- public bool detectCollisions { get; set; }
- public bool enableOverlapRecovery { get; set; }
- public float height { get; set; }
- public bool isGrounded { get; }
- public float minMoveDistance { get; set; }
- public float radius { get; set; }
- public float skinWidth { get; set; }
- public float slopeLimit { get; set; }
- public float stepOffset { get; set; }
- public UnityEngine.Vector3 velocity { get; }

#### Constructors
- public CharacterController()

#### Methods
- public UnityEngine.CollisionFlags Move(UnityEngine.Vector3 motion)
- private UnityEngine.CollisionFlags Move_Injected(ref UnityEngine.Vector3 motion)
- public bool SimpleMove(UnityEngine.Vector3 speed)
- private bool SimpleMove_Injected(ref UnityEngine.Vector3 speed)

### public class UnityEngine.CharacterJoint
- Base: UnityEngine.Joint

#### Fields
- public UnityEngine.JointDrive rotationDrive
- public UnityEngine.Vector3 targetAngularVelocity
- public UnityEngine.Quaternion targetRotation

#### Properties
- public bool enableProjection { get; set; }
- public UnityEngine.SoftJointLimit highTwistLimit { get; set; }
- public UnityEngine.SoftJointLimit lowTwistLimit { get; set; }
- public float projectionAngle { get; set; }
- public float projectionDistance { get; set; }
- public UnityEngine.SoftJointLimit swing1Limit { get; set; }
- public UnityEngine.SoftJointLimit swing2Limit { get; set; }
- public UnityEngine.Vector3 swingAxis { get; set; }
- public UnityEngine.SoftJointLimitSpring swingLimitSpring { get; set; }
- public UnityEngine.SoftJointLimitSpring twistLimitSpring { get; set; }

#### Constructors
- public CharacterJoint()

### public struct UnityEngine.ClosestPointCommand

#### Fields
- private int <colliderInstanceID>k__BackingField
- private UnityEngine.Vector3 <point>k__BackingField
- private UnityEngine.Vector3 <position>k__BackingField
- private UnityEngine.Quaternion <rotation>k__BackingField
- private UnityEngine.Vector3 <scale>k__BackingField

#### Properties
- public int colliderInstanceID { get; set; }
- public UnityEngine.Vector3 point { get; set; }
- public UnityEngine.Vector3 position { get; set; }
- public UnityEngine.Quaternion rotation { get; set; }
- public UnityEngine.Vector3 scale { get; set; }

#### Constructors
- public ClosestPointCommand(UnityEngine.Vector3 point, int colliderInstanceID, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale)
- public ClosestPointCommand(UnityEngine.Vector3 point, UnityEngine.Collider collider, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale)

#### Methods
- public static Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.ClosestPointCommand> commands, Unity.Collections.NativeArray<UnityEngine.Vector3> results, int minCommandsPerJob, Unity.Jobs.JobHandle dependsOn = null)
- private static Unity.Jobs.JobHandle ScheduleClosestPointCommandBatch(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob)
- private static void ScheduleClosestPointCommandBatch_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, out Unity.Jobs.JobHandle ret)

### public class UnityEngine.Collider
- Base: UnityEngine.Component

#### Properties
- public UnityEngine.ArticulationBody attachedArticulationBody { get; }
- public UnityEngine.Rigidbody attachedRigidbody { get; }
- public UnityEngine.Bounds bounds { get; }
- public float contactOffset { get; set; }
- public bool enabled { get; set; }
- public UnityEngine.LayerMask excludeLayers { get; set; }
- public bool hasModifiableContacts { get; set; }
- public UnityEngine.LayerMask includeLayers { get; set; }
- public bool isTrigger { get; set; }
- public int layerOverridePriority { get; set; }
- public UnityEngine.PhysicMaterial material { get; set; }
- public bool providesContacts { get; set; }
- public UnityEngine.PhysicMaterial sharedMaterial { get; set; }

#### Constructors
- public Collider()

#### Methods
- public UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 position)
- public UnityEngine.Vector3 ClosestPointOnBounds(UnityEngine.Vector3 position)
- private void ClosestPoint_Injected(ref UnityEngine.Vector3 position, out UnityEngine.Vector3 ret)
- private void Internal_ClosestPointOnBounds(UnityEngine.Vector3 point, ref UnityEngine.Vector3 outPos, ref float distance)
- private void Internal_ClosestPointOnBounds_Injected(ref UnityEngine.Vector3 point, ref UnityEngine.Vector3 outPos, ref float distance)
- private UnityEngine.RaycastHit Raycast(UnityEngine.Ray ray, float maxDistance, ref bool hasHit)
- public bool Raycast(UnityEngine.Ray ray, out UnityEngine.RaycastHit hitInfo, float maxDistance)
- private void Raycast_Injected(ref UnityEngine.Ray ray, float maxDistance, ref bool hasHit, out UnityEngine.RaycastHit ret)

### public struct UnityEngine.ColliderHit

#### Fields
- private int m_ColliderInstanceID

#### Properties
- public UnityEngine.Collider collider { get; }
- public int instanceID { get; }

### public class UnityEngine.Collision

#### Fields
- private bool m_Flipped
- private UnityEngine.ContactPairHeader m_Header
- private UnityEngine.ContactPoint[] m_LegacyContacts
- private UnityEngine.ContactPair m_Pair

#### Properties
- public UnityEngine.ArticulationBody articulationBody { get; }
- public UnityEngine.Component body { get; }
- public UnityEngine.Collider collider { get; }
- public int contactCount { get; }
- public UnityEngine.ContactPoint[] contacts { get; }
- internal bool Flipped { get; set; }
- public UnityEngine.Vector3 frictionForceSum { get; }
- public UnityEngine.GameObject gameObject { get; }
- public UnityEngine.Vector3 impactForceSum { get; }
- public UnityEngine.Vector3 impulse { get; }
- public UnityEngine.Component other { get; }
- public UnityEngine.Vector3 relativeVelocity { get; }
- public UnityEngine.Rigidbody rigidbody { get; }
- public UnityEngine.Transform transform { get; }

#### Constructors
- public Collision()
- internal Collision(in UnityEngine.ContactPairHeader header, in UnityEngine.ContactPair pair, bool flipped)

#### Methods
- public UnityEngine.ContactPoint GetContact(int index)
- public int GetContacts(UnityEngine.ContactPoint[] contacts)
- public int GetContacts(System.Collections.Generic.List<UnityEngine.ContactPoint> contacts)
- public virtual System.Collections.IEnumerator GetEnumerator()
- internal void Reuse(in UnityEngine.ContactPairHeader header, in UnityEngine.ContactPair pair)

### public enum UnityEngine.CollisionDetectionMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Continuous = 1
- ContinuousDynamic = 2
- ContinuousSpeculative = 3
- Discrete = 0

### public enum UnityEngine.CollisionFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Above = 2
- Below = 4
- CollidedAbove = 2
- CollidedBelow = 4
- CollidedSides = 1
- None = 0
- Sides = 1

### internal enum UnityEngine.CollisionPairEventFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ContactDefault = 1025
- ContactEventPose = 16384
- DetectCCDContact = 2048
- DetectDiscreteContact = 1024
- ModifyContacts = 2
- NextFree = 32768
- NotifyContactPoint = 512
- NotifyThresholdForceFound = 64
- NotifyThresholdForceLost = 256
- NotifyThresholdForcePersists = 128
- NotifyTouchCCD = 32
- NotifyTouchFound = 4
- NotifyTouchLost = 16
- NotifyTouchPersists = 8
- PostSolverVelocity = 8192
- PreSolverVelocity = 4096
- SolveContacts = 1
- TriggerDefault = 1044

### internal enum UnityEngine.CollisionPairFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ActorPairHasFirstTouch = 4
- ActorPairLostTouch = 8
- InternalContactsAreFlipped = 32
- InternalHasImpulses = 16
- RemovedOtherShape = 2
- RemovedShape = 1

### internal enum UnityEngine.CollisionPairHeaderFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- RemovedActor = 1
- RemovedOtherActor = 2

### public class UnityEngine.ConfigurableJoint
- Base: UnityEngine.Joint

#### Properties
- public UnityEngine.JointDrive angularXDrive { get; set; }
- public UnityEngine.SoftJointLimitSpring angularXLimitSpring { get; set; }
- public UnityEngine.ConfigurableJointMotion angularXMotion { get; set; }
- public UnityEngine.SoftJointLimit angularYLimit { get; set; }
- public UnityEngine.ConfigurableJointMotion angularYMotion { get; set; }
- public UnityEngine.JointDrive angularYZDrive { get; set; }
- public UnityEngine.SoftJointLimitSpring angularYZLimitSpring { get; set; }
- public UnityEngine.SoftJointLimit angularZLimit { get; set; }
- public UnityEngine.ConfigurableJointMotion angularZMotion { get; set; }
- public bool configuredInWorldSpace { get; set; }
- public UnityEngine.SoftJointLimit highAngularXLimit { get; set; }
- public UnityEngine.SoftJointLimit linearLimit { get; set; }
- public UnityEngine.SoftJointLimitSpring linearLimitSpring { get; set; }
- public UnityEngine.SoftJointLimit lowAngularXLimit { get; set; }
- public float projectionAngle { get; set; }
- public float projectionDistance { get; set; }
- public UnityEngine.JointProjectionMode projectionMode { get; set; }
- public UnityEngine.RotationDriveMode rotationDriveMode { get; set; }
- public UnityEngine.Vector3 secondaryAxis { get; set; }
- public UnityEngine.JointDrive slerpDrive { get; set; }
- public bool swapBodies { get; set; }
- public UnityEngine.Vector3 targetAngularVelocity { get; set; }
- public UnityEngine.Vector3 targetPosition { get; set; }
- public UnityEngine.Quaternion targetRotation { get; set; }
- public UnityEngine.Vector3 targetVelocity { get; set; }
- public UnityEngine.JointDrive xDrive { get; set; }
- public UnityEngine.ConfigurableJointMotion xMotion { get; set; }
- public UnityEngine.JointDrive yDrive { get; set; }
- public UnityEngine.ConfigurableJointMotion yMotion { get; set; }
- public UnityEngine.JointDrive zDrive { get; set; }
- public UnityEngine.ConfigurableJointMotion zMotion { get; set; }

#### Constructors
- public ConfigurableJoint()

### public enum UnityEngine.ConfigurableJointMotion
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Free = 2
- Limited = 1
- Locked = 0

### public class UnityEngine.ConstantForce
- Base: UnityEngine.Behaviour

#### Properties
- public UnityEngine.Vector3 force { get; set; }
- public UnityEngine.Vector3 relativeForce { get; set; }
- public UnityEngine.Vector3 relativeTorque { get; set; }
- public UnityEngine.Vector3 torque { get; set; }

#### Constructors
- public ConstantForce()

### public delegate UnityEngine.Physics.ContactEventDelegate
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Physics.ContactEventDelegate(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(UnityEngine.PhysicsScene scene, Unity.Collections.NativeArray<T>.ReadOnly<UnityEngine.ContactPairHeader> headerArray, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(UnityEngine.PhysicsScene scene, Unity.Collections.NativeArray<T>.ReadOnly<UnityEngine.ContactPairHeader> headerArray)

### public struct UnityEngine.ContactPair

#### Fields
- private static const uint c_InvalidFaceIndex
- internal readonly int m_ColliderID
- internal readonly UnityEngine.CollisionPairEventFlags m_Events
- internal readonly UnityEngine.CollisionPairFlags m_Flags
- internal readonly UnityEngine.Vector3 m_ImpulseSum
- internal readonly uint m_NbPoints
- internal readonly int m_OtherColliderID
- internal readonly System.IntPtr m_StartPtr

#### Properties
- public UnityEngine.Collider Collider { get; }
- public int ColliderInstanceID { get; }
- public int ContactCount { get; }
- internal bool HasRemovedCollider { get; }
- public UnityEngine.Vector3 ImpulseSum { get; }
- public bool IsCollisionEnter { get; }
- public bool IsCollisionExit { get; }
- public bool IsCollisionStay { get; }
- public UnityEngine.Collider OtherCollider { get; }
- public int OtherColliderInstanceID { get; }

#### Methods
- public void CopyToNativeArray(Unity.Collections.NativeArray<UnityEngine.ContactPairPoint> buffer)
- internal int ExtractContacts(System.Collections.Generic.List<UnityEngine.ContactPoint> managedContainer, bool flipped)
- internal int ExtractContactsArray(UnityEngine.ContactPoint[] managedContainer, bool flipped)
- private static int ExtractContactsArray_Injected(ref UnityEngine.ContactPair _unity_self, UnityEngine.ContactPoint[] managedContainer, bool flipped)
- private static int ExtractContacts_Injected(ref UnityEngine.ContactPair _unity_self, System.Collections.Generic.List<UnityEngine.ContactPoint> managedContainer, bool flipped)
- public UnityEngine.ContactPairPoint GetContactPoint(int index)
- public uint GetContactPointFaceIndex(int contactIndex)
- internal UnityEngine.ContactPairPoint* GetContactPoint_Internal(int index)

### public struct UnityEngine.ContactPairHeader

#### Fields
- internal readonly int m_BodyID
- internal readonly UnityEngine.CollisionPairHeaderFlags m_Flags
- internal readonly uint m_NbPairs
- internal readonly int m_OtherBodyID
- internal readonly UnityEngine.Vector3 m_RelativeVelocity
- internal readonly System.IntPtr m_StartPtr

#### Properties
- public UnityEngine.Component Body { get; }
- public int BodyInstanceID { get; }
- internal bool HasRemovedBody { get; }
- public UnityEngine.Component OtherBody { get; }
- public int OtherBodyInstanceID { get; }
- public int PairCount { get; }

#### Methods
- public UnityEngine.ContactPair GetContactPair(int index)
- internal UnityEngine.ContactPair* GetContactPair_Internal(int index)

### public struct UnityEngine.ContactPairPoint

#### Fields
- internal readonly UnityEngine.Vector3 m_Impulse
- internal readonly uint m_InternalFaceIndex0
- internal readonly uint m_InternalFaceIndex1
- internal readonly UnityEngine.Vector3 m_Normal
- internal readonly UnityEngine.Vector3 m_Position
- internal readonly float m_Separation

#### Properties
- public UnityEngine.Vector3 Impulse { get; }
- public UnityEngine.Vector3 Normal { get; }
- public UnityEngine.Vector3 Position { get; }
- public float Separation { get; }

### public struct UnityEngine.ContactPoint

#### Fields
- internal UnityEngine.Vector3 m_Impulse
- internal UnityEngine.Vector3 m_Normal
- internal int m_OtherColliderInstanceID
- internal UnityEngine.Vector3 m_Point
- internal float m_Separation
- internal int m_ThisColliderInstanceID

#### Properties
- public UnityEngine.Vector3 impulse { get; }
- public UnityEngine.Vector3 normal { get; }
- public UnityEngine.Collider otherCollider { get; }
- public UnityEngine.Vector3 point { get; }
- public float separation { get; }
- public UnityEngine.Collider thisCollider { get; }

#### Constructors
- internal ContactPoint(UnityEngine.Vector3 point, UnityEngine.Vector3 normal, UnityEngine.Vector3 impulse, float separation, int thisInstanceID, int otherInstenceID)

### public class UnityEngine.ControllerColliderHit

#### Fields
- internal UnityEngine.Collider m_Collider
- internal UnityEngine.CharacterController m_Controller
- internal UnityEngine.Vector3 m_MoveDirection
- internal float m_MoveLength
- internal UnityEngine.Vector3 m_Normal
- internal UnityEngine.Vector3 m_Point
- internal int m_Push

#### Properties
- public UnityEngine.Collider collider { get; }
- public UnityEngine.CharacterController controller { get; }
- public UnityEngine.GameObject gameObject { get; }
- public UnityEngine.Vector3 moveDirection { get; }
- public float moveLength { get; }
- public UnityEngine.Vector3 normal { get; }
- public UnityEngine.Vector3 point { get; }
- private bool push { get; set; }
- public UnityEngine.Rigidbody rigidbody { get; }
- public UnityEngine.Transform transform { get; }

#### Constructors
- public ControllerColliderHit()

### public class UnityEngine.FixedJoint
- Base: UnityEngine.Joint

#### Constructors
- public FixedJoint()

### public enum UnityEngine.ModifiableContactPatch.Flags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- HasFaceIndices = 1
- HasMaxImpulse = 32
- HasModifiedMassRatios = 8
- HasTargetVelocity = 16
- RegeneratePatches = 64

### public enum UnityEngine.ForceMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Acceleration = 5
- Force = 0
- Impulse = 1
- VelocityChange = 2

### public class UnityEngine.HingeJoint
- Base: UnityEngine.Joint

#### Properties
- public float angle { get; }
- public bool extendedLimits { get; set; }
- public UnityEngine.JointLimits limits { get; set; }
- public UnityEngine.JointMotor motor { get; set; }
- public UnityEngine.JointSpring spring { get; set; }
- public bool useAcceleration { get; set; }
- public bool useLimits { get; set; }
- public bool useMotor { get; set; }
- public bool useSpring { get; set; }
- public float velocity { get; }

#### Constructors
- public HingeJoint()

### public class UnityEngine.Joint
- Base: UnityEngine.Component

#### Properties
- public UnityEngine.Vector3 anchor { get; set; }
- public bool autoConfigureConnectedAnchor { get; set; }
- public UnityEngine.Vector3 axis { get; set; }
- public float breakForce { get; set; }
- public float breakTorque { get; set; }
- public UnityEngine.Vector3 connectedAnchor { get; set; }
- public UnityEngine.ArticulationBody connectedArticulationBody { get; set; }
- public UnityEngine.Rigidbody connectedBody { get; set; }
- public float connectedMassScale { get; set; }
- public UnityEngine.Vector3 currentForce { get; }
- public UnityEngine.Vector3 currentTorque { get; }
- public bool enableCollision { get; set; }
- public bool enablePreprocessing { get; set; }
- public float massScale { get; set; }

#### Constructors
- public Joint()

#### Methods
- private void GetCurrentForces(ref UnityEngine.Vector3 linearForce, ref UnityEngine.Vector3 angularForce)

### public struct UnityEngine.JointDrive

#### Fields
- private float m_MaximumForce
- private float m_PositionDamper
- private float m_PositionSpring
- private int m_UseAcceleration

#### Properties
- public float maximumForce { get; set; }
- public UnityEngine.JointDriveMode mode { get; set; }
- public float positionDamper { get; set; }
- public float positionSpring { get; set; }
- public bool useAcceleration { get; set; }

### public enum UnityEngine.JointDriveMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- None = 0
- Position = 1
- PositionAndVelocity = 3
- Velocity = 2

### public struct UnityEngine.JointLimits

#### Fields
- public float maxBounce
- public float minBounce
- private float m_BounceMinVelocity
- private float m_Bounciness
- private float m_ContactDistance
- private float m_Max
- private float m_Min

#### Properties
- public float bounceMinVelocity { get; set; }
- public float bounciness { get; set; }
- public float contactDistance { get; set; }
- public float max { get; set; }
- public float min { get; set; }

### public struct UnityEngine.JointMotor

#### Fields
- private float m_Force
- private int m_FreeSpin
- private float m_TargetVelocity

#### Properties
- public float force { get; set; }
- public bool freeSpin { get; set; }
- public float targetVelocity { get; set; }

### public enum UnityEngine.JointProjectionMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- None = 0
- PositionAndRotation = 1
- PositionOnly = 2

### public struct UnityEngine.JointSpring

#### Fields
- public float damper
- public float spring
- public float targetPosition

### public class UnityEngine.MeshCollider
- Base: UnityEngine.Collider

#### Properties
- public bool convex { get; set; }
- public UnityEngine.MeshColliderCookingOptions cookingOptions { get; set; }
- public bool inflateMesh { get; set; }
- public UnityEngine.Mesh sharedMesh { get; set; }
- public float skinWidth { get; set; }
- public bool smoothSphereCollisions { get; set; }

#### Constructors
- public MeshCollider()

### public enum UnityEngine.MeshColliderCookingOptions
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CookForFasterSimulation = 2
- EnableMeshCleaning = 4
- InflateConvexMesh = 1
- None = 0
- UseFastMidphase = 16
- WeldColocatedVertices = 8

### internal struct UnityEngine.ModifiableContact

#### Fields
- public UnityEngine.Vector3 contact
- public float dynamicFriction
- public uint materialFlags
- public ushort materialIndex
- public float maxImpulse
- public UnityEngine.Vector3 normal
- public ushort otherMaterialIndex
- public float restitution
- public float separation
- public float staticFriction
- public UnityEngine.Vector3 targetVelocity

### public struct UnityEngine.ModifiableContactPair

#### Fields
- private System.IntPtr actor
- private System.IntPtr contacts
- private int numContacts
- private System.IntPtr otherActor
- public UnityEngine.Vector3 otherPosition
- public UnityEngine.Quaternion otherRotation
- private System.IntPtr otherShape
- public UnityEngine.Vector3 position
- public UnityEngine.Quaternion rotation
- private System.IntPtr shape

#### Properties
- public UnityEngine.Vector3 bodyAngularVelocity { get; }
- public int bodyInstanceID { get; }
- public UnityEngine.Vector3 bodyVelocity { get; }
- public int colliderInstanceID { get; }
- public int contactCount { get; }
- public UnityEngine.ModifiableMassProperties massProperties { get; set; }
- public UnityEngine.Vector3 otherBodyAngularVelocity { get; }
- public int otherBodyInstanceID { get; }
- public UnityEngine.Vector3 otherBodyVelocity { get; }
- public int otherColliderInstanceID { get; }

#### Methods
- public float GetBounciness(int i)
- private UnityEngine.ModifiableContact* GetContact(int index)
- private UnityEngine.ModifiableContactPatch* GetContactPatch()
- public float GetDynamicFriction(int i)
- public uint GetFaceIndex(int i)
- public float GetMaxImpulse(int i)
- public UnityEngine.Vector3 GetNormal(int i)
- public UnityEngine.Vector3 GetPoint(int i)
- public float GetSeparation(int i)
- public float GetStaticFriction(int i)
- public UnityEngine.Vector3 GetTargetVelocity(int i)
- public void IgnoreContact(int i)
- public void SetBounciness(int i, float bounciness)
- public void SetDynamicFriction(int i, float dynamicFriction)
- public void SetMaxImpulse(int i, float value)
- public void SetNormal(int i, UnityEngine.Vector3 normal)
- public void SetPoint(int i, UnityEngine.Vector3 v)
- public void SetSeparation(int i, float separation)
- public void SetStaticFriction(int i, float staticFriction)
- public void SetTargetVelocity(int i, UnityEngine.Vector3 velocity)

### internal struct UnityEngine.ModifiableContactPatch

#### Fields
- public byte contactCount
- public float dynamicFriction
- public byte internalFlags
- public UnityEngine.ModifiableMassProperties massProperties
- public byte materialFlags
- public ushort materialIndex
- public UnityEngine.Vector3 normal
- public ushort otherMaterialIndex
- public float restitution
- public byte startContactIndex
- public float staticFriction

### public struct UnityEngine.ModifiableMassProperties

#### Fields
- public float inverseInertiaScale
- public float inverseMassScale
- public float otherInverseInertiaScale
- public float otherInverseMassScale

### public struct UnityEngine.OverlapBoxCommand

#### Fields
- private UnityEngine.Vector3 <center>k__BackingField
- private UnityEngine.Vector3 <halfExtents>k__BackingField
- private UnityEngine.Quaternion <orientation>k__BackingField
- private UnityEngine.PhysicsScene <physicsScene>k__BackingField
- public UnityEngine.QueryParameters queryParameters

#### Properties
- public UnityEngine.Vector3 center { get; set; }
- public UnityEngine.Vector3 halfExtents { get; set; }
- public UnityEngine.Quaternion orientation { get; set; }
- public UnityEngine.PhysicsScene physicsScene { get; set; }

#### Constructors
- public OverlapBoxCommand(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, UnityEngine.QueryParameters queryParameters)
- public OverlapBoxCommand(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, UnityEngine.QueryParameters queryParameters)

#### Methods
- public static Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.OverlapBoxCommand> commands, Unity.Collections.NativeArray<UnityEngine.ColliderHit> results, int minCommandsPerJob, int maxHits, Unity.Jobs.JobHandle dependsOn = null)
- private static Unity.Jobs.JobHandle ScheduleOverlapBoxBatch(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits)
- private static void ScheduleOverlapBoxBatch_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits, out Unity.Jobs.JobHandle ret)

### public struct UnityEngine.OverlapCapsuleCommand

#### Fields
- private UnityEngine.PhysicsScene <physicsScene>k__BackingField
- private UnityEngine.Vector3 <point0>k__BackingField
- private UnityEngine.Vector3 <point1>k__BackingField
- private float <radius>k__BackingField
- public UnityEngine.QueryParameters queryParameters

#### Properties
- public UnityEngine.PhysicsScene physicsScene { get; set; }
- public UnityEngine.Vector3 point0 { get; set; }
- public UnityEngine.Vector3 point1 { get; set; }
- public float radius { get; set; }

#### Constructors
- public OverlapCapsuleCommand(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, UnityEngine.QueryParameters queryParameters)
- public OverlapCapsuleCommand(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, UnityEngine.QueryParameters queryParameters)

#### Methods
- public static Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.OverlapCapsuleCommand> commands, Unity.Collections.NativeArray<UnityEngine.ColliderHit> results, int minCommandsPerJob, int maxHits, Unity.Jobs.JobHandle dependsOn = null)
- private static Unity.Jobs.JobHandle ScheduleOverlapCapsuleBatch(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits)
- private static void ScheduleOverlapCapsuleBatch_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits, out Unity.Jobs.JobHandle ret)

### public struct UnityEngine.OverlapSphereCommand

#### Fields
- private UnityEngine.PhysicsScene <physicsScene>k__BackingField
- private UnityEngine.Vector3 <point>k__BackingField
- private float <radius>k__BackingField
- public UnityEngine.QueryParameters queryParameters

#### Properties
- public UnityEngine.PhysicsScene physicsScene { get; set; }
- public UnityEngine.Vector3 point { get; set; }
- public float radius { get; set; }

#### Constructors
- public OverlapSphereCommand(UnityEngine.Vector3 point, float radius, UnityEngine.QueryParameters queryParameters)
- public OverlapSphereCommand(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point, float radius, UnityEngine.QueryParameters queryParameters)

#### Methods
- public static Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.OverlapSphereCommand> commands, Unity.Collections.NativeArray<UnityEngine.ColliderHit> results, int minCommandsPerJob, int maxHits, Unity.Jobs.JobHandle dependsOn = null)
- private static Unity.Jobs.JobHandle ScheduleOverlapSphereBatch(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits)
- private static void ScheduleOverlapSphereBatch_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits, out Unity.Jobs.JobHandle ret)

### public class UnityEngine.PhysicMaterial
- Base: UnityEngine.Object

#### Properties
- public UnityEngine.PhysicMaterialCombine bounceCombine { get; set; }
- public float bounciness { get; set; }
- public float bouncyness { get; set; }
- public float dynamicFriction { get; set; }
- public float dynamicFriction2 { get; set; }
- public UnityEngine.PhysicMaterialCombine frictionCombine { get; set; }
- public UnityEngine.Vector3 frictionDirection { get; set; }
- public UnityEngine.Vector3 frictionDirection2 { get; set; }
- public float staticFriction { get; set; }
- public float staticFriction2 { get; set; }

#### Constructors
- public PhysicMaterial()
- public PhysicMaterial(string name)

#### Methods
- private static void Internal_CreateDynamicsMaterial(UnityEngine.PhysicMaterial mat, string name)

### public enum UnityEngine.PhysicMaterialCombine
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Average = 0
- Maximum = 3
- Minimum = 2
- Multiply = 1

### public class UnityEngine.Physics

#### Fields
- public static const int AllLayers
- private static UnityEngine.Physics.ContactEventDelegate ContactEvent
- private static System.Action<UnityEngine.PhysicsScene, Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEvent
- private static System.Action<UnityEngine.PhysicsScene, Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEventCCD
- public static const int DefaultRaycastLayers
- public static const int IgnoreRaycastLayer
- public static const int kAllLayers
- public static const int kDefaultRaycastLayers
- public static const int kIgnoreRaycastLayer
- internal static const float k_MaxFloatMinusEpsilon
- private static readonly UnityEngine.Collision s_ReusableCollision

#### Properties
- public static bool autoSimulation { get; set; }
- public static bool autoSyncTransforms { get; set; }
- public static float bounceThreshold { get; set; }
- public static float bounceTreshold { get; set; }
- public static UnityEngine.Vector3 clothGravity { get; set; }
- public static float defaultContactOffset { get; set; }
- public static float defaultMaxAngularSpeed { get; set; }
- public static float defaultMaxDepenetrationVelocity { get; set; }
- public static UnityEngine.PhysicsScene defaultPhysicsScene { get; }
- public static int defaultSolverIterations { get; set; }
- public static int defaultSolverVelocityIterations { get; set; }
- public static UnityEngine.Vector3 gravity { get; set; }
- public static bool improvedPatchFriction { get; set; }
- public static float interCollisionDistance { get; set; }
- public static bool interCollisionSettingsToggle { get; set; }
- public static float interCollisionStiffness { get; set; }
- public static bool invokeCollisionCallbacks { get; set; }
- public static float maxAngularVelocity { get; set; }
- public static float minPenetrationForPenalty { get; set; }
- public static float penetrationPenaltyForce { get; set; }
- public static bool queriesHitBackfaces { get; set; }
- public static bool queriesHitTriggers { get; set; }
- public static bool reuseCollisionCallbacks { get; set; }
- public static UnityEngine.SimulationMode simulationMode { get; set; }
- public static float sleepAngularVelocity { get; set; }
- public static float sleepThreshold { get; set; }
- public static float sleepVelocity { get; set; }
- public static int solverIterationCount { get; set; }
- public static int solverVelocityIterationCount { get; set; }

#### Events
- public static event UnityEngine.Physics.ContactEventDelegate ContactEvent
- public static event System.Action<UnityEngine.PhysicsScene, Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEvent
- public static event System.Action<UnityEngine.PhysicsScene, Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEventCCD

#### Constructors
- public Physics()
- private static Physics()

#### Methods
- public static void BakeMesh(int meshID, bool convex, UnityEngine.MeshColliderCookingOptions cookingOptions)
- public static void BakeMesh(int meshID, bool convex)
- public static bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, float maxDistance, int layerMask)
- public static bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, float maxDistance)
- public static bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation)
- public static bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction)
- public static bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, UnityEngine.Quaternion orientation, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, UnityEngine.Quaternion orientation, float maxDistance, int layerMask)
- public static bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, UnityEngine.Quaternion orientation, float maxDistance)
- public static bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, UnityEngine.Quaternion orientation)
- public static bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo)
- public static UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, float maxDistance, int layerMask)
- public static UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, float maxDistance)
- public static UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation)
- public static UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction)
- public static int BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static int BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation)
- public static int BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, float maxDistance)
- public static int BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, float maxDistance, int layerMask)
- public static int BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results)
- public static bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float maxDistance, int layerMask)
- public static bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float maxDistance)
- public static bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction)
- public static bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask)
- public static bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance)
- public static bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo)
- public static UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float maxDistance, int layerMask)
- public static UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float maxDistance)
- public static UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction)
- public static int CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static int CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask)
- public static int CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance)
- public static int CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results)
- public static bool CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, int layermask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static bool CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, int layerMask)
- public static bool CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation)
- public static bool CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents)
- private static bool CheckBox_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, int layermask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static bool CheckBox_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 center, ref UnityEngine.Vector3 halfExtents, ref UnityEngine.Quaternion orientation, int layermask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static bool CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static bool CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, float radius, int layerMask)
- public static bool CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, float radius)
- private static bool CheckCapsule_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 start, UnityEngine.Vector3 end, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static bool CheckCapsule_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 start, ref UnityEngine.Vector3 end, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static bool CheckSphere(UnityEngine.Vector3 position, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static bool CheckSphere(UnityEngine.Vector3 position, float radius, int layerMask)
- public static bool CheckSphere(UnityEngine.Vector3 position, float radius)
- private static bool CheckSphere_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static bool CheckSphere_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 position, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 point, UnityEngine.Collider collider, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
- public static bool ComputePenetration(UnityEngine.Collider colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, out UnityEngine.Vector3 direction, out float distance)
- internal static UnityEngine.Vector3 GetActorAngularVelocity(System.IntPtr actorPtr)
- private static void GetActorAngularVelocity_Injected(System.IntPtr actorPtr, out UnityEngine.Vector3 ret)
- internal static UnityEngine.Vector3 GetActorLinearVelocity(System.IntPtr actorPtr)
- private static void GetActorLinearVelocity_Injected(System.IntPtr actorPtr, out UnityEngine.Vector3 ret)
- internal static UnityEngine.Component GetBodyByInstanceID(int instanceID)
- internal static UnityEngine.Collider GetColliderByInstanceID(int instanceID)
- private static UnityEngine.Collision GetCollisionToReport(in UnityEngine.ContactPairHeader header, in UnityEngine.ContactPair pair, bool flipped)
- public static bool GetIgnoreCollision(UnityEngine.Collider collider1, UnityEngine.Collider collider2)
- public static bool GetIgnoreLayerCollision(int layer1, int layer2)
- public static void IgnoreCollision(UnityEngine.Collider collider1, UnityEngine.Collider collider2, bool ignore)
- public static void IgnoreCollision(UnityEngine.Collider collider1, UnityEngine.Collider collider2)
- public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore)
- public static void IgnoreLayerCollision(int layer1, int layer2)
- private static UnityEngine.RaycastHit[] Internal_BoxCastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static UnityEngine.RaycastHit[] Internal_BoxCastAll_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 center, ref UnityEngine.Vector3 halfExtents, ref UnityEngine.Vector3 direction, ref UnityEngine.Quaternion orientation, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static UnityEngine.RaycastHit[] Internal_RaycastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static UnityEngine.RaycastHit[] Internal_RaycastAll_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static void Internal_RebuildBroadphaseRegions(UnityEngine.Bounds bounds, int subdivisions)
- private static void Internal_RebuildBroadphaseRegions_Injected(ref UnityEngine.Bounds bounds, int subdivisions)
- internal static void InterpolateBodies_Internal(UnityEngine.PhysicsScene physicsScene)
- private static void InterpolateBodies_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene)
- internal static bool IsShapeTrigger(System.IntPtr shapePtr)
- public static bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, int layerMask)
- public static bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end)
- public static bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, out UnityEngine.RaycastHit hitInfo, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, out UnityEngine.RaycastHit hitInfo, int layerMask)
- public static bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, out UnityEngine.RaycastHit hitInfo)
- private static void OnSceneContact(UnityEngine.PhysicsScene scene, System.IntPtr buffer, int count)
- private static void OnSceneContactModify(UnityEngine.PhysicsScene scene, System.IntPtr buffer, int count, bool isCCD)
- public static UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, int layerMask)
- public static UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation)
- public static UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents)
- public static int OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static int OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, int mask)
- public static int OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation)
- public static int OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results)
- private static UnityEngine.Collider[] OverlapBox_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static UnityEngine.Collider[] OverlapBox_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 center, ref UnityEngine.Vector3 halfExtents, ref UnityEngine.Quaternion orientation, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static UnityEngine.Collider[] OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static UnityEngine.Collider[] OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, int layerMask)
- public static UnityEngine.Collider[] OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius)
- public static int OverlapCapsuleNonAlloc(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static int OverlapCapsuleNonAlloc(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, UnityEngine.Collider[] results, int layerMask)
- public static int OverlapCapsuleNonAlloc(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, UnityEngine.Collider[] results)
- private static UnityEngine.Collider[] OverlapCapsule_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static UnityEngine.Collider[] OverlapCapsule_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 point0, ref UnityEngine.Vector3 point1, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, float radius, int layerMask)
- public static UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, float radius)
- public static int OverlapSphereNonAlloc(UnityEngine.Vector3 position, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static int OverlapSphereNonAlloc(UnityEngine.Vector3 position, float radius, UnityEngine.Collider[] results, int layerMask)
- public static int OverlapSphereNonAlloc(UnityEngine.Vector3 position, float radius, UnityEngine.Collider[] results)
- private static UnityEngine.Collider[] OverlapSphere_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static UnityEngine.Collider[] OverlapSphere_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 position, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static UnityEngine.RaycastHit[] Query_CapsuleCastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, float radius, UnityEngine.Vector3 direction, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static UnityEngine.RaycastHit[] Query_CapsuleCastAll_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 p0, ref UnityEngine.Vector3 p1, float radius, ref UnityEngine.Vector3 direction, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static UnityEngine.Vector3 Query_ClosestPoint(UnityEngine.Collider collider, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 point)
- private static void Query_ClosestPoint_Injected(UnityEngine.Collider collider, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, ref UnityEngine.Vector3 point, out UnityEngine.Vector3 ret)
- private static bool Query_ComputePenetration(UnityEngine.Collider colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, ref UnityEngine.Vector3 direction, ref float distance)
- private static bool Query_ComputePenetration_Injected(UnityEngine.Collider colliderA, ref UnityEngine.Vector3 positionA, ref UnityEngine.Quaternion rotationA, UnityEngine.Collider colliderB, ref UnityEngine.Vector3 positionB, ref UnityEngine.Quaternion rotationB, ref UnityEngine.Vector3 direction, ref float distance)
- private static UnityEngine.RaycastHit[] Query_SphereCastAll(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static UnityEngine.RaycastHit[] Query_SphereCastAll_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 origin, float radius, ref UnityEngine.Vector3 direction, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask)
- public static bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance)
- public static bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction)
- public static bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask)
- public static bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance)
- public static bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo)
- public static bool Raycast(UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static bool Raycast(UnityEngine.Ray ray, float maxDistance, int layerMask)
- public static bool Raycast(UnityEngine.Ray ray, float maxDistance)
- public static bool Raycast(UnityEngine.Ray ray)
- public static bool Raycast(UnityEngine.Ray ray, out UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static bool Raycast(UnityEngine.Ray ray, out UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask)
- public static bool Raycast(UnityEngine.Ray ray, out UnityEngine.RaycastHit hitInfo, float maxDistance)
- public static bool Raycast(UnityEngine.Ray ray, out UnityEngine.RaycastHit hitInfo)
- public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask)
- public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance)
- public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction)
- public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance, int layerMask)
- public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance)
- public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray)
- public static int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask)
- public static int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance)
- public static int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results)
- public static int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask)
- public static int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance)
- public static int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results)
- public static void RebuildBroadphaseRegions(UnityEngine.Bounds worldBounds, int subdivisions)
- private static void ReportContacts(Unity.Collections.NativeArray<T>.ReadOnly<UnityEngine.ContactPairHeader> array)
- internal static void ResetInterpolationPoses_Internal(UnityEngine.PhysicsScene physicsScene)
- private static void ResetInterpolationPoses_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene)
- internal static UnityEngine.Component ResolveActorToComponent(System.IntPtr actorPtr)
- internal static int ResolveActorToInstanceID(System.IntPtr actorPtr)
- internal static UnityEngine.Collider ResolveShapeToCollider(System.IntPtr shapePtr)
- internal static int ResolveShapeToInstanceID(System.IntPtr shapePtr)
- private static void SendOnCollisionEnter(UnityEngine.Component component, UnityEngine.Collision collision)
- private static void SendOnCollisionExit(UnityEngine.Component component, UnityEngine.Collision collision)
- private static void SendOnCollisionStay(UnityEngine.Component component, UnityEngine.Collision collision)
- public static void Simulate(float step)
- internal static void Simulate_Internal(UnityEngine.PhysicsScene physicsScene, float step)
- private static void Simulate_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, float step)
- public static bool SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static bool SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask)
- public static bool SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance)
- public static bool SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo)
- public static bool SphereCast(UnityEngine.Ray ray, float radius, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static bool SphereCast(UnityEngine.Ray ray, float radius, float maxDistance, int layerMask)
- public static bool SphereCast(UnityEngine.Ray ray, float radius, float maxDistance)
- public static bool SphereCast(UnityEngine.Ray ray, float radius)
- public static bool SphereCast(UnityEngine.Ray ray, float radius, out UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static bool SphereCast(UnityEngine.Ray ray, float radius, out UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask)
- public static bool SphereCast(UnityEngine.Ray ray, float radius, out UnityEngine.RaycastHit hitInfo, float maxDistance)
- public static bool SphereCast(UnityEngine.Ray ray, float radius, out UnityEngine.RaycastHit hitInfo)
- public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, float maxDistance, int layerMask)
- public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, float maxDistance)
- public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction)
- public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, float radius, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, float radius, float maxDistance, int layerMask)
- public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, float radius, float maxDistance)
- public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, float radius)
- public static int SphereCastNonAlloc(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static int SphereCastNonAlloc(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask)
- public static int SphereCastNonAlloc(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance)
- public static int SphereCastNonAlloc(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results)
- public static int SphereCastNonAlloc(UnityEngine.Ray ray, float radius, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public static int SphereCastNonAlloc(UnityEngine.Ray ray, float radius, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask)
- public static int SphereCastNonAlloc(UnityEngine.Ray ray, float radius, UnityEngine.RaycastHit[] results, float maxDistance)
- public static int SphereCastNonAlloc(UnityEngine.Ray ray, float radius, UnityEngine.RaycastHit[] results)
- public static void SyncTransforms()
- internal static uint TranslateTriangleIndex(System.IntPtr shapePtr, uint rawIndex)
- internal static uint TranslateTriangleIndexFromID(int instanceID, uint faceIndex)

### public struct UnityEngine.PhysicsScene
- Interfaces: System.IEquatable<UnityEngine.PhysicsScene>

#### Fields
- private int m_Handle

#### Methods
- public bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, UnityEngine.Quaternion orientation, float maxDistance = Infinity, int layerMask = -5, UnityEngine.QueryTriggerInteraction queryTriggerInteraction = UseGlobal)
- public bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo)
- public int BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, float maxDistance = Infinity, int layerMask = -5, UnityEngine.QueryTriggerInteraction queryTriggerInteraction = UseGlobal)
- public int BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results)
- public bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance = Infinity, int layerMask = -5, UnityEngine.QueryTriggerInteraction queryTriggerInteraction = UseGlobal)
- public int CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance = Infinity, int layerMask = -5, UnityEngine.QueryTriggerInteraction queryTriggerInteraction = UseGlobal)
- public override bool Equals(object other)
- public bool Equals(UnityEngine.PhysicsScene other)
- public override int GetHashCode()
- private static bool Internal_BoxCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static int Internal_BoxCastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, UnityEngine.Quaternion orientation, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static int Internal_BoxCastNonAlloc_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 center, ref UnityEngine.Vector3 halfExtents, ref UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, ref UnityEngine.Quaternion orientation, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static bool Internal_CapsuleCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static int Internal_CapsuleCastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static int Internal_CapsuleCastNonAlloc_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 p0, ref UnityEngine.Vector3 p1, float radius, ref UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static bool Internal_Raycast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, ref UnityEngine.RaycastHit hit, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static int Internal_RaycastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static int Internal_RaycastNonAlloc_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static bool Internal_RaycastTest(UnityEngine.PhysicsScene physicsScene, UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static bool Internal_RaycastTest_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static bool Internal_Raycast_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Ray ray, float maxDistance, ref UnityEngine.RaycastHit hit, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static bool Internal_SphereCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static int Internal_SphereCastNonAlloc(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static int Internal_SphereCastNonAlloc_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 origin, float radius, ref UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, float maxDistance, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public void InterpolateBodies()
- public bool IsEmpty()
- private static bool IsEmpty_Internal(UnityEngine.PhysicsScene physicsScene)
- private static bool IsEmpty_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene)
- public bool IsValid()
- private static bool IsValid_Internal(UnityEngine.PhysicsScene physicsScene)
- private static bool IsValid_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene)
- public static bool op_Equality(UnityEngine.PhysicsScene lhs, UnityEngine.PhysicsScene rhs)
- public static bool op_Inequality(UnityEngine.PhysicsScene lhs, UnityEngine.PhysicsScene rhs)
- public int OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, int layerMask = -5, UnityEngine.QueryTriggerInteraction queryTriggerInteraction = UseGlobal)
- public int OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results)
- private static int OverlapBoxNonAlloc_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static int OverlapBoxNonAlloc_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 center, ref UnityEngine.Vector3 halfExtents, UnityEngine.Collider[] results, ref UnityEngine.Quaternion orientation, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public int OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, UnityEngine.Collider[] results, int layerMask = -1, UnityEngine.QueryTriggerInteraction queryTriggerInteraction = UseGlobal)
- private static int OverlapCapsuleNonAlloc_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static int OverlapCapsuleNonAlloc_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 point0, ref UnityEngine.Vector3 point1, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public int OverlapSphere(UnityEngine.Vector3 position, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static int OverlapSphereNonAlloc_Internal(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 position, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static int OverlapSphereNonAlloc_Internal_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 position, float radius, UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static bool Query_BoxCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, float maxDistance, ref UnityEngine.RaycastHit outHit, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static bool Query_BoxCast_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 center, ref UnityEngine.Vector3 halfExtents, ref UnityEngine.Vector3 direction, ref UnityEngine.Quaternion orientation, float maxDistance, ref UnityEngine.RaycastHit outHit, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static bool Query_CapsuleCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float maxDistance, ref UnityEngine.RaycastHit hitInfo, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static bool Query_CapsuleCast_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 point1, ref UnityEngine.Vector3 point2, float radius, ref UnityEngine.Vector3 direction, float maxDistance, ref UnityEngine.RaycastHit hitInfo, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static bool Query_SphereCast(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, float maxDistance, ref UnityEngine.RaycastHit hitInfo, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private static bool Query_SphereCast_Injected(ref UnityEngine.PhysicsScene physicsScene, ref UnityEngine.Vector3 origin, float radius, ref UnityEngine.Vector3 direction, float maxDistance, ref UnityEngine.RaycastHit hitInfo, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance = Infinity, int layerMask = -5, UnityEngine.QueryTriggerInteraction queryTriggerInteraction = UseGlobal)
- public bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance = Infinity, int layerMask = -5, UnityEngine.QueryTriggerInteraction queryTriggerInteraction = UseGlobal)
- public int Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] raycastHits, float maxDistance = Infinity, int layerMask = -5, UnityEngine.QueryTriggerInteraction queryTriggerInteraction = UseGlobal)
- public void ResetInterpolationPoses()
- public void Simulate(float step)
- public bool SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance = Infinity, int layerMask = -5, UnityEngine.QueryTriggerInteraction queryTriggerInteraction = UseGlobal)
- public int SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance = Infinity, int layerMask = -5, UnityEngine.QueryTriggerInteraction queryTriggerInteraction = UseGlobal)
- public override string ToString()

### public static class UnityEngine.PhysicsSceneExtensions

#### Methods
- public static UnityEngine.PhysicsScene GetPhysicsScene(UnityEngine.SceneManagement.Scene scene)
- private static UnityEngine.PhysicsScene GetPhysicsScene_Internal(UnityEngine.SceneManagement.Scene scene)
- private static void GetPhysicsScene_Internal_Injected(ref UnityEngine.SceneManagement.Scene scene, out UnityEngine.PhysicsScene ret)

### public struct UnityEngine.QueryParameters

#### Fields
- public bool hitBackfaces
- public bool hitMultipleFaces
- public UnityEngine.QueryTriggerInteraction hitTriggers
- public int layerMask

#### Properties
- public static UnityEngine.QueryParameters Default { get; }

#### Constructors
- public QueryParameters(int layerMask = -5, bool hitMultipleFaces = false, UnityEngine.QueryTriggerInteraction hitTriggers = UseGlobal, bool hitBackfaces = false)

### public enum UnityEngine.QueryTriggerInteraction
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Collide = 2
- Ignore = 1
- UseGlobal = 0

### public struct UnityEngine.RaycastCommand

#### Fields
- private UnityEngine.Vector3 <direction>k__BackingField
- private float <distance>k__BackingField
- private UnityEngine.Vector3 <from>k__BackingField
- private UnityEngine.PhysicsScene <physicsScene>k__BackingField
- public UnityEngine.QueryParameters queryParameters

#### Properties
- public UnityEngine.Vector3 direction { get; set; }
- public float distance { get; set; }
- public UnityEngine.Vector3 from { get; set; }
- public int layerMask { get; set; }
- public int maxHits { get; set; }
- public UnityEngine.PhysicsScene physicsScene { get; set; }

#### Constructors
- public RaycastCommand(UnityEngine.Vector3 from, UnityEngine.Vector3 direction, UnityEngine.QueryParameters queryParameters, float distance = 3.4028235E+38)
- public RaycastCommand(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 from, UnityEngine.Vector3 direction, UnityEngine.QueryParameters queryParameters, float distance = 3.4028235E+38)
- public RaycastCommand(UnityEngine.Vector3 from, UnityEngine.Vector3 direction, float distance = 3.4028235E+38, int layerMask = -5, int maxHits = 1)
- public RaycastCommand(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 from, UnityEngine.Vector3 direction, float distance = 3.4028235E+38, int layerMask = -5, int maxHits = 1)

#### Methods
- public static Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.RaycastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, int minCommandsPerJob, int maxHits, Unity.Jobs.JobHandle dependsOn = null)
- public static Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.RaycastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, int minCommandsPerJob, Unity.Jobs.JobHandle dependsOn = null)
- private static Unity.Jobs.JobHandle ScheduleRaycastBatch(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits)
- private static void ScheduleRaycastBatch_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits, out Unity.Jobs.JobHandle ret)

### public struct UnityEngine.RaycastHit

#### Fields
- internal int m_Collider
- internal float m_Distance
- internal uint m_FaceID
- internal UnityEngine.Vector3 m_Normal
- internal UnityEngine.Vector3 m_Point
- internal UnityEngine.Vector2 m_UV

#### Properties
- public UnityEngine.ArticulationBody articulationBody { get; }
- public UnityEngine.Vector3 barycentricCoordinate { get; set; }
- public UnityEngine.Collider collider { get; }
- public int colliderInstanceID { get; }
- public float distance { get; set; }
- public UnityEngine.Vector2 lightmapCoord { get; }
- public UnityEngine.Vector3 normal { get; set; }
- public UnityEngine.Vector3 point { get; set; }
- public UnityEngine.Rigidbody rigidbody { get; }
- public UnityEngine.Vector2 textureCoord { get; }
- public UnityEngine.Vector2 textureCoord1 { get; }
- public UnityEngine.Vector2 textureCoord2 { get; }
- public UnityEngine.Transform transform { get; }
- public int triangleIndex { get; }

#### Methods
- private static UnityEngine.Vector2 CalculateRaycastTexCoord(int colliderInstanceID, UnityEngine.Vector2 uv, UnityEngine.Vector3 pos, uint face, int textcoord)
- private static void CalculateRaycastTexCoord_Injected(int colliderInstanceID, ref UnityEngine.Vector2 uv, ref UnityEngine.Vector3 pos, uint face, int textcoord, out UnityEngine.Vector2 ret)

### public class UnityEngine.Rigidbody
- Base: UnityEngine.Component

#### Properties
- public float angularDrag { get; set; }
- public UnityEngine.Vector3 angularVelocity { get; set; }
- public bool automaticCenterOfMass { get; set; }
- public bool automaticInertiaTensor { get; set; }
- public UnityEngine.Vector3 centerOfMass { get; set; }
- public UnityEngine.CollisionDetectionMode collisionDetectionMode { get; set; }
- public UnityEngine.RigidbodyConstraints constraints { get; set; }
- public bool detectCollisions { get; set; }
- public float drag { get; set; }
- public UnityEngine.LayerMask excludeLayers { get; set; }
- public bool freezeRotation { get; set; }
- public UnityEngine.LayerMask includeLayers { get; set; }
- public UnityEngine.Vector3 inertiaTensor { get; set; }
- public UnityEngine.Quaternion inertiaTensorRotation { get; set; }
- public UnityEngine.RigidbodyInterpolation interpolation { get; set; }
- public bool isKinematic { get; set; }
- public float mass { get; set; }
- public float maxAngularVelocity { get; set; }
- public float maxDepenetrationVelocity { get; set; }
- public float maxLinearVelocity { get; set; }
- public UnityEngine.Vector3 position { get; set; }
- public UnityEngine.Quaternion rotation { get; set; }
- public float sleepAngularVelocity { get; set; }
- public float sleepThreshold { get; set; }
- public float sleepVelocity { get; set; }
- public int solverIterationCount { get; set; }
- public int solverIterations { get; set; }
- public int solverVelocityIterationCount { get; set; }
- public int solverVelocityIterations { get; set; }
- public bool useConeFriction { get; set; }
- public bool useGravity { get; set; }
- public UnityEngine.Vector3 velocity { get; set; }
- public UnityEngine.Vector3 worldCenterOfMass { get; }

#### Constructors
- public Rigidbody()

#### Methods
- public void AddExplosionForce(float explosionForce, UnityEngine.Vector3 explosionPosition, float explosionRadius, float upwardsModifier, UnityEngine.ForceMode mode)
- public void AddExplosionForce(float explosionForce, UnityEngine.Vector3 explosionPosition, float explosionRadius, float upwardsModifier)
- public void AddExplosionForce(float explosionForce, UnityEngine.Vector3 explosionPosition, float explosionRadius)
- private void AddExplosionForce_Injected(float explosionForce, ref UnityEngine.Vector3 explosionPosition, float explosionRadius, float upwardsModifier, UnityEngine.ForceMode mode)
- public void AddForce(UnityEngine.Vector3 force, UnityEngine.ForceMode mode)
- public void AddForce(UnityEngine.Vector3 force)
- public void AddForce(float x, float y, float z, UnityEngine.ForceMode mode)
- public void AddForce(float x, float y, float z)
- public void AddForceAtPosition(UnityEngine.Vector3 force, UnityEngine.Vector3 position, UnityEngine.ForceMode mode)
- public void AddForceAtPosition(UnityEngine.Vector3 force, UnityEngine.Vector3 position)
- private void AddForceAtPosition_Injected(ref UnityEngine.Vector3 force, ref UnityEngine.Vector3 position, UnityEngine.ForceMode mode)
- private void AddForce_Injected(ref UnityEngine.Vector3 force, UnityEngine.ForceMode mode)
- public void AddRelativeForce(UnityEngine.Vector3 force, UnityEngine.ForceMode mode)
- public void AddRelativeForce(UnityEngine.Vector3 force)
- public void AddRelativeForce(float x, float y, float z, UnityEngine.ForceMode mode)
- public void AddRelativeForce(float x, float y, float z)
- private void AddRelativeForce_Injected(ref UnityEngine.Vector3 force, UnityEngine.ForceMode mode)
- public void AddRelativeTorque(UnityEngine.Vector3 torque, UnityEngine.ForceMode mode)
- public void AddRelativeTorque(UnityEngine.Vector3 torque)
- public void AddRelativeTorque(float x, float y, float z, UnityEngine.ForceMode mode)
- public void AddRelativeTorque(float x, float y, float z)
- private void AddRelativeTorque_Injected(ref UnityEngine.Vector3 torque, UnityEngine.ForceMode mode)
- public void AddTorque(UnityEngine.Vector3 torque, UnityEngine.ForceMode mode)
- public void AddTorque(UnityEngine.Vector3 torque)
- public void AddTorque(float x, float y, float z, UnityEngine.ForceMode mode)
- public void AddTorque(float x, float y, float z)
- private void AddTorque_Injected(ref UnityEngine.Vector3 torque, UnityEngine.ForceMode mode)
- public UnityEngine.Vector3 ClosestPointOnBounds(UnityEngine.Vector3 position)
- public UnityEngine.Vector3 GetAccumulatedForce(float step)
- public UnityEngine.Vector3 GetAccumulatedForce()
- private void GetAccumulatedForce_Injected(float step, out UnityEngine.Vector3 ret)
- public UnityEngine.Vector3 GetAccumulatedTorque(float step)
- public UnityEngine.Vector3 GetAccumulatedTorque()
- private void GetAccumulatedTorque_Injected(float step, out UnityEngine.Vector3 ret)
- public UnityEngine.Vector3 GetPointVelocity(UnityEngine.Vector3 worldPoint)
- private void GetPointVelocity_Injected(ref UnityEngine.Vector3 worldPoint, out UnityEngine.Vector3 ret)
- public UnityEngine.Vector3 GetRelativePointVelocity(UnityEngine.Vector3 relativePoint)
- private void GetRelativePointVelocity_Injected(ref UnityEngine.Vector3 relativePoint, out UnityEngine.Vector3 ret)
- private void Internal_ClosestPointOnBounds(UnityEngine.Vector3 point, ref UnityEngine.Vector3 outPos, ref float distance)
- private void Internal_ClosestPointOnBounds_Injected(ref UnityEngine.Vector3 point, ref UnityEngine.Vector3 outPos, ref float distance)
- private UnityEngine.RaycastHit[] Internal_SweepTestAll(UnityEngine.Vector3 direction, float maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- private UnityEngine.RaycastHit[] Internal_SweepTestAll_Injected(ref UnityEngine.Vector3 direction, float maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public bool IsSleeping()
- public void Move(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
- public void MovePosition(UnityEngine.Vector3 position)
- private void MovePosition_Injected(ref UnityEngine.Vector3 position)
- public void MoveRotation(UnityEngine.Quaternion rot)
- private void MoveRotation_Injected(ref UnityEngine.Quaternion rot)
- private void Move_Injected(ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation)
- public void ResetCenterOfMass()
- public void ResetInertiaTensor()
- public void SetDensity(float density)
- public void SetMaxAngularVelocity(float a)
- public void Sleep()
- private UnityEngine.RaycastHit SweepTest(UnityEngine.Vector3 direction, float maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit)
- public bool SweepTest(UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public bool SweepTest(UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance)
- public bool SweepTest(UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo)
- public UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3 direction, float maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction)
- public UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3 direction, float maxDistance)
- public UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3 direction)
- private void SweepTest_Injected(ref UnityEngine.Vector3 direction, float maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit, out UnityEngine.RaycastHit ret)
- public void WakeUp()

### public enum UnityEngine.RigidbodyConstraints
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FreezeAll = 126
- FreezePosition = 14
- FreezePositionX = 2
- FreezePositionY = 4
- FreezePositionZ = 8
- FreezeRotation = 112
- FreezeRotationX = 16
- FreezeRotationY = 32
- FreezeRotationZ = 64
- None = 0

### public enum UnityEngine.RigidbodyInterpolation
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Extrapolate = 2
- Interpolate = 1
- None = 0

### public enum UnityEngine.RotationDriveMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Slerp = 1
- XYAndZ = 0

### public enum UnityEngine.SimulationMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FixedUpdate = 0
- Script = 2
- Update = 1

### public struct UnityEngine.SoftJointLimit

#### Fields
- private float m_Bounciness
- private float m_ContactDistance
- private float m_Limit

#### Properties
- public float bounciness { get; set; }
- public float bouncyness { get; set; }
- public float contactDistance { get; set; }
- public float damper { get; set; }
- public float limit { get; set; }
- public float spring { get; set; }

### public struct UnityEngine.SoftJointLimitSpring

#### Fields
- private float m_Damper
- private float m_Spring

#### Properties
- public float damper { get; set; }
- public float spring { get; set; }

### public struct UnityEngine.SpherecastCommand

#### Fields
- private UnityEngine.Vector3 <direction>k__BackingField
- private float <distance>k__BackingField
- private UnityEngine.Vector3 <origin>k__BackingField
- private UnityEngine.PhysicsScene <physicsScene>k__BackingField
- private float <radius>k__BackingField
- public UnityEngine.QueryParameters queryParameters

#### Properties
- public UnityEngine.Vector3 direction { get; set; }
- public float distance { get; set; }
- public int layerMask { get; set; }
- public UnityEngine.Vector3 origin { get; set; }
- public UnityEngine.PhysicsScene physicsScene { get; set; }
- public float radius { get; set; }

#### Constructors
- public SpherecastCommand(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.QueryParameters queryParameters, float distance = 3.4028235E+38)
- public SpherecastCommand(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, float distance = 3.4028235E+38, int layerMask = -5)
- public SpherecastCommand(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.QueryParameters queryParameters, float distance = 3.4028235E+38)
- public SpherecastCommand(UnityEngine.PhysicsScene physicsScene, UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, float distance = 3.4028235E+38, int layerMask = -5)

#### Methods
- public static Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.SpherecastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, int minCommandsPerJob, int maxHits, Unity.Jobs.JobHandle dependsOn = null)
- public static Unity.Jobs.JobHandle ScheduleBatch(Unity.Collections.NativeArray<UnityEngine.SpherecastCommand> commands, Unity.Collections.NativeArray<UnityEngine.RaycastHit> results, int minCommandsPerJob, Unity.Jobs.JobHandle dependsOn = null)
- private static Unity.Jobs.JobHandle ScheduleSpherecastBatch(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits)
- private static void ScheduleSpherecastBatch_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits, out Unity.Jobs.JobHandle ret)

### public class UnityEngine.SphereCollider
- Base: UnityEngine.Collider

#### Properties
- public UnityEngine.Vector3 center { get; set; }
- public float radius { get; set; }

#### Constructors
- public SphereCollider()

### public class UnityEngine.SpringJoint
- Base: UnityEngine.Joint

#### Properties
- public float damper { get; set; }
- public float maxDistance { get; set; }
- public float minDistance { get; set; }
- public float spring { get; set; }
- public float tolerance { get; set; }

#### Constructors
- public SpringJoint()

### public struct UnityEngine.WheelFrictionCurve

#### Fields
- private float m_AsymptoteSlip
- private float m_AsymptoteValue
- private float m_ExtremumSlip
- private float m_ExtremumValue
- private float m_Stiffness

#### Properties
- public float asymptoteSlip { get; set; }
- public float asymptoteValue { get; set; }
- public float extremumSlip { get; set; }
- public float extremumValue { get; set; }
- public float stiffness { get; set; }

