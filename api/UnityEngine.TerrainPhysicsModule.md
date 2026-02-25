# Assembly: UnityEngine.TerrainPhysicsModule
- Path: tools/WorldBox.Managed/UnityEngine.TerrainPhysicsModule.dll
- Types: 1

## Namespace: UnityEngine

### public class UnityEngine.TerrainCollider
- Base: UnityEngine.Collider

#### Properties
- public UnityEngine.TerrainData terrainData { get; set; }

#### Constructors
- public TerrainCollider()

#### Methods
- private UnityEngine.RaycastHit Raycast(UnityEngine.Ray ray, float maxDistance, bool hitHoles, ref bool hasHit)
- internal bool Raycast(UnityEngine.Ray ray, out UnityEngine.RaycastHit hitInfo, float maxDistance, bool hitHoles)
- private void Raycast_Injected(ref UnityEngine.Ray ray, float maxDistance, bool hitHoles, ref bool hasHit, out UnityEngine.RaycastHit ret)

