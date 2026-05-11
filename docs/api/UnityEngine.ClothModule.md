# Assembly: UnityEngine.ClothModule
- Path: tools/WorldBox.Managed/UnityEngine.ClothModule.dll
- Types: 3

## Namespace: UnityEngine

### public class UnityEngine.Cloth
- Base: UnityEngine.Component

#### Fields
- private readonly bool <selfCollision>k__BackingField
- private float <useContinuousCollision>k__BackingField

#### Properties
- public float bendingStiffness { get; set; }
- public UnityEngine.CapsuleCollider[] capsuleColliders { get; set; }
- public float clothSolverFrequency { get; set; }
- public UnityEngine.ClothSkinningCoefficient[] coefficients { get; set; }
- public float collisionMassScale { get; set; }
- public float damping { get; set; }
- public bool enableContinuousCollision { get; set; }
- public bool enabled { get; set; }
- public UnityEngine.Vector3 externalAcceleration { get; set; }
- public float friction { get; set; }
- public UnityEngine.Vector3[] normals { get; }
- public UnityEngine.Vector3 randomAcceleration { get; set; }
- public bool selfCollision { get; }
- public float selfCollisionDistance { get; set; }
- public float selfCollisionStiffness { get; set; }
- public float sleepThreshold { get; set; }
- public bool solverFrequency { get; set; }
- public UnityEngine.ClothSphereColliderPair[] sphereColliders { get; set; }
- public float stiffnessFrequency { get; set; }
- public float stretchingStiffness { get; set; }
- public float useContinuousCollision { get; set; }
- public bool useGravity { get; set; }
- public bool useTethers { get; set; }
- public float useVirtualParticles { get; set; }
- public UnityEngine.Vector3[] vertices { get; }
- public float worldAccelerationScale { get; set; }
- public float worldVelocityScale { get; set; }

#### Constructors
- public Cloth()

#### Methods
- public void ClearTransformMotion()
- public void GetSelfAndInterCollisionIndices(System.Collections.Generic.List<uint> indices)
- public void GetVirtualParticleIndices(System.Collections.Generic.List<uint> indicesOutList)
- public void GetVirtualParticleWeights(System.Collections.Generic.List<UnityEngine.Vector3> weightsOutList)
- internal UnityEngine.RaycastHit Raycast(UnityEngine.Ray ray, float maxDistance, ref bool hasHit)
- private void Raycast_Injected(ref UnityEngine.Ray ray, float maxDistance, ref bool hasHit, out UnityEngine.RaycastHit ret)
- public void SetEnabledFading(bool enabled, float interpolationTime)
- public void SetEnabledFading(bool enabled)
- public void SetSelfAndInterCollisionIndices(System.Collections.Generic.List<uint> indices)
- public void SetVirtualParticleIndices(System.Collections.Generic.List<uint> indicesIn)
- public void SetVirtualParticleWeights(System.Collections.Generic.List<UnityEngine.Vector3> weights)

### public struct UnityEngine.ClothSkinningCoefficient

#### Fields
- public float collisionSphereDistance
- public float maxDistance

### public struct UnityEngine.ClothSphereColliderPair

#### Fields
- private UnityEngine.SphereCollider <first>k__BackingField
- private UnityEngine.SphereCollider <second>k__BackingField

#### Properties
- public UnityEngine.SphereCollider first { get; set; }
- public UnityEngine.SphereCollider second { get; set; }

#### Constructors
- public ClothSphereColliderPair(UnityEngine.SphereCollider a)
- public ClothSphereColliderPair(UnityEngine.SphereCollider a, UnityEngine.SphereCollider b)

