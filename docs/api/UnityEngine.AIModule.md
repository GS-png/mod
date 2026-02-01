# Assembly: UnityEngine.AIModule
- Path: tools/WorldBox.Managed/UnityEngine.AIModule.dll
- Types: 32

## Namespace: UnityEngine.AI

### public static class UnityEngine.AI.NavMesh

#### Fields
- public static const int AllAreas
- public static UnityEngine.AI.NavMesh.OnNavMeshPreUpdate onPreUpdate

#### Properties
- public static float avoidancePredictionTime { get; set; }
- public static int pathfindingIterationsPerFrame { get; set; }

#### Methods
- public static UnityEngine.AI.NavMeshLinkInstance AddLink(UnityEngine.AI.NavMeshLinkData link)
- public static UnityEngine.AI.NavMeshLinkInstance AddLink(UnityEngine.AI.NavMeshLinkData link, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
- internal static int AddLinkInternal(UnityEngine.AI.NavMeshLinkData link, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
- private static int AddLinkInternal_Injected(ref UnityEngine.AI.NavMeshLinkData link, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation)
- public static UnityEngine.AI.NavMeshDataInstance AddNavMeshData(UnityEngine.AI.NavMeshData navMeshData)
- public static UnityEngine.AI.NavMeshDataInstance AddNavMeshData(UnityEngine.AI.NavMeshData navMeshData, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
- internal static int AddNavMeshDataInternal(UnityEngine.AI.NavMeshData navMeshData)
- internal static int AddNavMeshDataTransformedInternal(UnityEngine.AI.NavMeshData navMeshData, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
- private static int AddNavMeshDataTransformedInternal_Injected(UnityEngine.AI.NavMeshData navMeshData, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation)
- public static void AddOffMeshLinks()
- public static bool CalculatePath(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, int areaMask, UnityEngine.AI.NavMeshPath path)
- public static bool CalculatePath(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, UnityEngine.AI.NavMeshQueryFilter filter, UnityEngine.AI.NavMeshPath path)
- private static bool CalculatePathFilterInternal(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, UnityEngine.AI.NavMeshPath path, int type, int mask, float[] costs)
- private static bool CalculatePathFilterInternal_Injected(ref UnityEngine.Vector3 sourcePosition, ref UnityEngine.Vector3 targetPosition, UnityEngine.AI.NavMeshPath path, int type, int mask, float[] costs)
- private static bool CalculatePathInternal(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, int areaMask, UnityEngine.AI.NavMeshPath path)
- private static bool CalculatePathInternal_Injected(ref UnityEngine.Vector3 sourcePosition, ref UnityEngine.Vector3 targetPosition, int areaMask, UnityEngine.AI.NavMeshPath path)
- public static UnityEngine.AI.NavMeshTriangulation CalculateTriangulation()
- private static void CalculateTriangulation_Injected(out UnityEngine.AI.NavMeshTriangulation ret)
- public static UnityEngine.AI.NavMeshBuildSettings CreateSettings()
- private static void CreateSettings_Injected(out UnityEngine.AI.NavMeshBuildSettings ret)
- public static bool FindClosestEdge(UnityEngine.Vector3 sourcePosition, out UnityEngine.AI.NavMeshHit hit, int areaMask)
- public static bool FindClosestEdge(UnityEngine.Vector3 sourcePosition, out UnityEngine.AI.NavMeshHit hit, UnityEngine.AI.NavMeshQueryFilter filter)
- private static bool FindClosestEdgeFilter(UnityEngine.Vector3 sourcePosition, out UnityEngine.AI.NavMeshHit hit, int type, int mask)
- private static bool FindClosestEdgeFilter_Injected(ref UnityEngine.Vector3 sourcePosition, out UnityEngine.AI.NavMeshHit hit, int type, int mask)
- private static bool FindClosestEdge_Injected(ref UnityEngine.Vector3 sourcePosition, out UnityEngine.AI.NavMeshHit hit, int areaMask)
- public static float GetAreaCost(int areaIndex)
- public static int GetAreaFromName(string areaName)
- public static float GetLayerCost(int layer)
- public static int GetNavMeshLayerFromName(string layerName)
- public static UnityEngine.AI.NavMeshBuildSettings GetSettingsByID(int agentTypeID)
- private static void GetSettingsByID_Injected(int agentTypeID, out UnityEngine.AI.NavMeshBuildSettings ret)
- public static UnityEngine.AI.NavMeshBuildSettings GetSettingsByIndex(int index)
- private static void GetSettingsByIndex_Injected(int index, out UnityEngine.AI.NavMeshBuildSettings ret)
- public static int GetSettingsCount()
- public static string GetSettingsNameFromID(int agentTypeID)
- internal static UnityEngine.Object InternalGetLinkOwner(int linkID)
- internal static UnityEngine.Object InternalGetOwner(int dataID)
- internal static bool InternalSetLinkOwner(int linkID, int ownerID)
- internal static bool InternalSetOwner(int dataID, int ownerID)
- private static void Internal_CallOnNavMeshPreUpdate()
- internal static bool IsValidLinkHandle(int handle)
- internal static bool IsValidNavMeshDataHandle(int handle)
- public static bool Raycast(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, out UnityEngine.AI.NavMeshHit hit, int areaMask)
- public static bool Raycast(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, out UnityEngine.AI.NavMeshHit hit, UnityEngine.AI.NavMeshQueryFilter filter)
- private static bool RaycastFilter(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, out UnityEngine.AI.NavMeshHit hit, int type, int mask)
- private static bool RaycastFilter_Injected(ref UnityEngine.Vector3 sourcePosition, ref UnityEngine.Vector3 targetPosition, out UnityEngine.AI.NavMeshHit hit, int type, int mask)
- private static bool Raycast_Injected(ref UnityEngine.Vector3 sourcePosition, ref UnityEngine.Vector3 targetPosition, out UnityEngine.AI.NavMeshHit hit, int areaMask)
- public static void RemoveAllNavMeshData()
- public static void RemoveLink(UnityEngine.AI.NavMeshLinkInstance handle)
- internal static void RemoveLinkInternal(int handle)
- public static void RemoveNavMeshData(UnityEngine.AI.NavMeshDataInstance handle)
- internal static void RemoveNavMeshDataInternal(int handle)
- public static void RemoveSettings(int agentTypeID)
- public static void RestoreNavMesh()
- public static bool SamplePosition(UnityEngine.Vector3 sourcePosition, out UnityEngine.AI.NavMeshHit hit, float maxDistance, int areaMask)
- public static bool SamplePosition(UnityEngine.Vector3 sourcePosition, out UnityEngine.AI.NavMeshHit hit, float maxDistance, UnityEngine.AI.NavMeshQueryFilter filter)
- private static bool SamplePositionFilter(UnityEngine.Vector3 sourcePosition, out UnityEngine.AI.NavMeshHit hit, float maxDistance, int type, int mask)
- private static bool SamplePositionFilter_Injected(ref UnityEngine.Vector3 sourcePosition, out UnityEngine.AI.NavMeshHit hit, float maxDistance, int type, int mask)
- private static bool SamplePosition_Injected(ref UnityEngine.Vector3 sourcePosition, out UnityEngine.AI.NavMeshHit hit, float maxDistance, int areaMask)
- public static void SetAreaCost(int areaIndex, float cost)
- public static void SetLayerCost(int layer, float cost)
- public static void Triangulate(out UnityEngine.Vector3[] vertices, out int[] indices)

### public class UnityEngine.AI.NavMeshAgent
- Base: UnityEngine.Behaviour

#### Properties
- public float acceleration { get; set; }
- public int agentTypeID { get; set; }
- public float angularSpeed { get; set; }
- public int areaMask { get; set; }
- public bool autoBraking { get; set; }
- public bool autoRepath { get; set; }
- public bool autoTraverseOffMeshLink { get; set; }
- public int avoidancePriority { get; set; }
- public float baseOffset { get; set; }
- public UnityEngine.AI.OffMeshLinkData currentOffMeshLinkData { get; }
- public UnityEngine.Vector3 desiredVelocity { get; }
- public UnityEngine.Vector3 destination { get; set; }
- public bool hasPath { get; }
- public float height { get; set; }
- public bool isOnNavMesh { get; }
- public bool isOnOffMeshLink { get; }
- public bool isPathStale { get; }
- public bool isStopped { get; set; }
- public UnityEngine.Object navMeshOwner { get; }
- public UnityEngine.AI.OffMeshLinkData nextOffMeshLinkData { get; }
- public UnityEngine.Vector3 nextPosition { get; set; }
- public UnityEngine.AI.ObstacleAvoidanceType obstacleAvoidanceType { get; set; }
- public UnityEngine.AI.NavMeshPath path { get; set; }
- public UnityEngine.Vector3 pathEndPosition { get; }
- public bool pathPending { get; }
- public UnityEngine.AI.NavMeshPathStatus pathStatus { get; }
- public float radius { get; set; }
- public float remainingDistance { get; }
- public float speed { get; set; }
- public UnityEngine.Vector3 steeringTarget { get; }
- public float stoppingDistance { get; set; }
- public bool updatePosition { get; set; }
- public bool updateRotation { get; set; }
- public bool updateUpAxis { get; set; }
- public UnityEngine.Vector3 velocity { get; set; }
- public int walkableMask { get; set; }

#### Constructors
- public NavMeshAgent()

#### Methods
- public void ActivateCurrentOffMeshLink(bool activated)
- public bool CalculatePath(UnityEngine.Vector3 targetPosition, UnityEngine.AI.NavMeshPath path)
- private bool CalculatePathInternal(UnityEngine.Vector3 targetPosition, UnityEngine.AI.NavMeshPath path)
- private bool CalculatePathInternal_Injected(ref UnityEngine.Vector3 targetPosition, UnityEngine.AI.NavMeshPath path)
- public void CompleteOffMeshLink()
- internal void CopyPathTo(UnityEngine.AI.NavMeshPath path)
- public bool FindClosestEdge(out UnityEngine.AI.NavMeshHit hit)
- public float GetAreaCost(int areaIndex)
- internal UnityEngine.AI.OffMeshLinkData GetCurrentOffMeshLinkDataInternal()
- private void GetCurrentOffMeshLinkDataInternal_Injected(out UnityEngine.AI.OffMeshLinkData ret)
- public float GetLayerCost(int layer)
- internal UnityEngine.AI.OffMeshLinkData GetNextOffMeshLinkDataInternal()
- private void GetNextOffMeshLinkDataInternal_Injected(out UnityEngine.AI.OffMeshLinkData ret)
- private UnityEngine.Object GetOwnerInternal()
- public void Move(UnityEngine.Vector3 offset)
- private void Move_Injected(ref UnityEngine.Vector3 offset)
- public bool Raycast(UnityEngine.Vector3 targetPosition, out UnityEngine.AI.NavMeshHit hit)
- private bool Raycast_Injected(ref UnityEngine.Vector3 targetPosition, out UnityEngine.AI.NavMeshHit hit)
- public void ResetPath()
- public void Resume()
- public bool SamplePathPosition(int areaMask, float maxDistance, out UnityEngine.AI.NavMeshHit hit)
- public void SetAreaCost(int areaIndex, float areaCost)
- public bool SetDestination(UnityEngine.Vector3 target)
- private bool SetDestination_Injected(ref UnityEngine.Vector3 target)
- public void SetLayerCost(int layer, float cost)
- public bool SetPath(UnityEngine.AI.NavMeshPath path)
- public void Stop()
- public void Stop(bool stopUpdates)
- public bool Warp(UnityEngine.Vector3 newPosition)
- private bool Warp_Injected(ref UnityEngine.Vector3 newPosition)

### public enum UnityEngine.AI.NavMeshBuildDebugFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- All = 127
- InputGeometry = 1
- None = 0
- PolygonMeshes = 32
- PolygonMeshesDetail = 64
- RawContours = 8
- Regions = 4
- SimplifiedContours = 16
- Voxels = 2

### public struct UnityEngine.AI.NavMeshBuildDebugSettings

#### Fields
- private byte m_Flags

#### Properties
- public UnityEngine.AI.NavMeshBuildDebugFlags flags { get; set; }

### public static class UnityEngine.AI.NavMeshBuilder

#### Methods
- public static UnityEngine.AI.NavMeshData BuildNavMeshData(UnityEngine.AI.NavMeshBuildSettings buildSettings, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources, UnityEngine.Bounds localBounds, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
- public static void Cancel(UnityEngine.AI.NavMeshData data)
- public static void CollectSources(UnityEngine.Bounds includedWorldBounds, int includedLayerMask, UnityEngine.AI.NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> markups, bool includeOnlyMarkedObjects, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> results)
- public static void CollectSources(UnityEngine.Bounds includedWorldBounds, int includedLayerMask, UnityEngine.AI.NavMeshCollectGeometry geometry, int defaultArea, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> markups, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> results)
- public static void CollectSources(UnityEngine.Transform root, int includedLayerMask, UnityEngine.AI.NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> markups, bool includeOnlyMarkedObjects, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> results)
- public static void CollectSources(UnityEngine.Transform root, int includedLayerMask, UnityEngine.AI.NavMeshCollectGeometry geometry, int defaultArea, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> markups, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> results)
- private static UnityEngine.AI.NavMeshBuildSource[] CollectSourcesInternal(int includedLayerMask, UnityEngine.Bounds includedWorldBounds, UnityEngine.Transform root, bool useBounds, UnityEngine.AI.NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, UnityEngine.AI.NavMeshBuildMarkup[] markups, bool includeOnlyMarkedObjects)
- private static UnityEngine.AI.NavMeshBuildSource[] CollectSourcesInternal_Injected(int includedLayerMask, ref UnityEngine.Bounds includedWorldBounds, UnityEngine.Transform root, bool useBounds, UnityEngine.AI.NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, UnityEngine.AI.NavMeshBuildMarkup[] markups, bool includeOnlyMarkedObjects)
- public static bool UpdateNavMeshData(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings buildSettings, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources, UnityEngine.Bounds localBounds)
- public static UnityEngine.AsyncOperation UpdateNavMeshDataAsync(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings buildSettings, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources, UnityEngine.Bounds localBounds)
- private static UnityEngine.AsyncOperation UpdateNavMeshDataAsyncListInternal(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings buildSettings, object sources, UnityEngine.Bounds localBounds)
- private static UnityEngine.AsyncOperation UpdateNavMeshDataAsyncListInternal_Injected(UnityEngine.AI.NavMeshData data, ref UnityEngine.AI.NavMeshBuildSettings buildSettings, object sources, ref UnityEngine.Bounds localBounds)
- private static bool UpdateNavMeshDataListInternal(UnityEngine.AI.NavMeshData data, UnityEngine.AI.NavMeshBuildSettings buildSettings, object sources, UnityEngine.Bounds localBounds)
- private static bool UpdateNavMeshDataListInternal_Injected(UnityEngine.AI.NavMeshData data, ref UnityEngine.AI.NavMeshBuildSettings buildSettings, object sources, ref UnityEngine.Bounds localBounds)

### public struct UnityEngine.AI.NavMeshBuildMarkup

#### Fields
- private int m_Area
- private int m_GenerateLinks
- private int m_IgnoreChildren
- private int m_IgnoreFromBuild
- private int m_InheritIgnoreFromBuild
- private int m_InstanceID
- private int m_OverrideArea
- private int m_OverrideGenerateLinks

#### Properties
- public bool applyToChildren { get; set; }
- public int area { get; set; }
- public bool generateLinks { get; set; }
- public bool ignoreFromBuild { get; set; }
- public bool overrideArea { get; set; }
- public bool overrideGenerateLinks { get; set; }
- public bool overrideIgnore { get; set; }
- public UnityEngine.Transform root { get; set; }

#### Methods
- private static UnityEngine.Transform InternalGetRootGO(int instanceID)

### public struct UnityEngine.AI.NavMeshBuildSettings

#### Fields
- private float m_AgentClimb
- private float m_AgentHeight
- private float m_AgentRadius
- private float m_AgentSlope
- private int m_AgentTypeID
- private int m_BuildHeightMesh
- private UnityEngine.AI.NavMeshBuildDebugSettings m_Debug
- private float m_LedgeDropHeight
- private uint m_MaxJobWorkers
- private float m_MaxJumpAcrossDistance
- private float m_MinRegionArea
- private int m_OverrideTileSize
- private int m_OverrideVoxelSize
- private int m_PreserveTilesOutsideBounds
- private int m_TileSize
- private float m_VoxelSize

#### Properties
- public float agentClimb { get; set; }
- public float agentHeight { get; set; }
- public float agentRadius { get; set; }
- public float agentSlope { get; set; }
- public int agentTypeID { get; set; }
- public bool buildHeightMesh { get; set; }
- public UnityEngine.AI.NavMeshBuildDebugSettings debug { get; set; }
- public float ledgeDropHeight { get; set; }
- public uint maxJobWorkers { get; set; }
- public float maxJumpAcrossDistance { get; set; }
- public float minRegionArea { get; set; }
- public bool overrideTileSize { get; set; }
- public bool overrideVoxelSize { get; set; }
- public bool preserveTilesOutsideBounds { get; set; }
- public int tileSize { get; set; }
- public float voxelSize { get; set; }

#### Methods
- private static string[] InternalValidationReport(UnityEngine.AI.NavMeshBuildSettings buildSettings, UnityEngine.Bounds buildBounds)
- private static string[] InternalValidationReport_Injected(ref UnityEngine.AI.NavMeshBuildSettings buildSettings, ref UnityEngine.Bounds buildBounds)
- public string[] ValidationReport(UnityEngine.Bounds buildBounds)

### public struct UnityEngine.AI.NavMeshBuildSource

#### Fields
- private int m_Area
- private int m_ComponentID
- private int m_GenerateLinks
- private int m_InstanceID
- private UnityEngine.AI.NavMeshBuildSourceShape m_Shape
- private UnityEngine.Vector3 m_Size
- private UnityEngine.Matrix4x4 m_Transform

#### Properties
- public int area { get; set; }
- public UnityEngine.Component component { get; set; }
- public bool generateLinks { get; set; }
- public UnityEngine.AI.NavMeshBuildSourceShape shape { get; set; }
- public UnityEngine.Vector3 size { get; set; }
- public UnityEngine.Object sourceObject { get; set; }
- public UnityEngine.Matrix4x4 transform { get; set; }

#### Methods
- private static UnityEngine.Component InternalGetComponent(int instanceID)
- private static UnityEngine.Object InternalGetObject(int instanceID)

### public enum UnityEngine.AI.NavMeshBuildSourceShape
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Box = 2
- Capsule = 4
- Mesh = 0
- ModifierBox = 5
- Sphere = 3
- Terrain = 1

### public enum UnityEngine.AI.NavMeshCollectGeometry
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- PhysicsColliders = 1
- RenderMeshes = 0

### public class UnityEngine.AI.NavMeshData
- Base: UnityEngine.Object

#### Properties
- internal UnityEngine.AI.NavMeshBuildSettings buildSettings { get; }
- internal bool hasHeightMeshData { get; }
- public UnityEngine.Vector3 position { get; set; }
- public UnityEngine.Quaternion rotation { get; set; }
- public UnityEngine.Bounds sourceBounds { get; }

#### Constructors
- public NavMeshData()
- public NavMeshData(int agentTypeID)

#### Methods
- private static void Internal_Create(UnityEngine.AI.NavMeshData mono, int agentTypeID)

### public struct UnityEngine.AI.NavMeshDataInstance

#### Fields
- private int <id>k__BackingField

#### Properties
- internal int id { get; set; }
- public UnityEngine.Object owner { get; set; }
- public bool valid { get; }

#### Methods
- public void Remove()

### public struct UnityEngine.AI.NavMeshHit

#### Fields
- private float m_Distance
- private int m_Hit
- private int m_Mask
- private UnityEngine.Vector3 m_Normal
- private UnityEngine.Vector3 m_Position

#### Properties
- public float distance { get; set; }
- public bool hit { get; set; }
- public int mask { get; set; }
- public UnityEngine.Vector3 normal { get; set; }
- public UnityEngine.Vector3 position { get; set; }

### public struct UnityEngine.AI.NavMeshLinkData

#### Fields
- private int m_AgentTypeID
- private int m_Area
- private int m_Bidirectional
- private float m_CostModifier
- private UnityEngine.Vector3 m_EndPosition
- private UnityEngine.Vector3 m_StartPosition
- private float m_Width

#### Properties
- public int agentTypeID { get; set; }
- public int area { get; set; }
- public bool bidirectional { get; set; }
- public float costModifier { get; set; }
- public UnityEngine.Vector3 endPosition { get; set; }
- public UnityEngine.Vector3 startPosition { get; set; }
- public float width { get; set; }

### public struct UnityEngine.AI.NavMeshLinkInstance

#### Fields
- private int <id>k__BackingField

#### Properties
- internal int id { get; set; }
- public UnityEngine.Object owner { get; set; }
- public bool valid { get; }

#### Methods
- public void Remove()

### public class UnityEngine.AI.NavMeshObstacle
- Base: UnityEngine.Behaviour

#### Properties
- public bool carveOnlyStationary { get; set; }
- public bool carving { get; set; }
- public float carvingMoveThreshold { get; set; }
- public float carvingTimeToStationary { get; set; }
- public UnityEngine.Vector3 center { get; set; }
- public float height { get; set; }
- public float radius { get; set; }
- public UnityEngine.AI.NavMeshObstacleShape shape { get; set; }
- public UnityEngine.Vector3 size { get; set; }
- public UnityEngine.Vector3 velocity { get; set; }

#### Constructors
- public NavMeshObstacle()

#### Methods
- internal void FitExtents()

### public enum UnityEngine.AI.NavMeshObstacleShape
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Box = 1
- Capsule = 0

### public class UnityEngine.AI.NavMeshPath

#### Fields
- internal UnityEngine.Vector3[] m_Corners
- internal System.IntPtr m_Ptr

#### Properties
- public UnityEngine.Vector3[] corners { get; }
- public UnityEngine.AI.NavMeshPathStatus status { get; }

#### Constructors
- public NavMeshPath()

#### Methods
- private void CalculateCorners()
- private UnityEngine.Vector3[] CalculateCornersInternal()
- public void ClearCorners()
- private void ClearCornersInternal()
- private static void DestroyNavMeshPath(System.IntPtr ptr)
- protected override void Finalize()
- public int GetCornersNonAlloc(UnityEngine.Vector3[] results)
- private static System.IntPtr InitializeNavMeshPath()

### public enum UnityEngine.AI.NavMeshPathStatus
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- PathComplete = 0
- PathInvalid = 2
- PathPartial = 1

### public struct UnityEngine.AI.NavMeshQueryFilter

#### Fields
- private int <agentTypeID>k__BackingField
- private int <areaMask>k__BackingField
- private float[] <costs>k__BackingField
- private static const int k_AreaCostElementCount

#### Properties
- public int agentTypeID { get; set; }
- public int areaMask { get; set; }
- internal float[] costs { get; private set; }

#### Methods
- public float GetAreaCost(int areaIndex)
- public void SetAreaCost(int areaIndex, float cost)

### public struct UnityEngine.AI.NavMeshTriangulation

#### Fields
- public int[] areas
- public int[] indices
- public UnityEngine.Vector3[] vertices

#### Properties
- public int[] layers { get; }

### public enum UnityEngine.AI.ObstacleAvoidanceType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- GoodQualityObstacleAvoidance = 3
- HighQualityObstacleAvoidance = 4
- LowQualityObstacleAvoidance = 1
- MedQualityObstacleAvoidance = 2
- NoObstacleAvoidance = 0

### public class UnityEngine.AI.OffMeshLink
- Base: UnityEngine.Behaviour

#### Properties
- public bool activated { get; set; }
- public int area { get; set; }
- public bool autoUpdatePositions { get; set; }
- public bool biDirectional { get; set; }
- public float costOverride { get; set; }
- public UnityEngine.Transform endTransform { get; set; }
- public int navMeshLayer { get; set; }
- public bool occupied { get; }
- public UnityEngine.Transform startTransform { get; set; }

#### Constructors
- public OffMeshLink()

#### Methods
- public void UpdatePositions()

### public struct UnityEngine.AI.OffMeshLinkData

#### Fields
- internal int m_Activated
- internal UnityEngine.Vector3 m_EndPos
- internal int m_InstanceID
- internal UnityEngine.AI.OffMeshLinkType m_LinkType
- internal UnityEngine.Vector3 m_StartPos
- internal int m_Valid

#### Properties
- public bool activated { get; }
- public UnityEngine.Vector3 endPos { get; }
- public UnityEngine.AI.OffMeshLinkType linkType { get; }
- public UnityEngine.AI.OffMeshLink offMeshLink { get; }
- public UnityEngine.Vector3 startPos { get; }
- public bool valid { get; }

#### Methods
- internal static UnityEngine.AI.OffMeshLink GetOffMeshLinkInternal(int instanceID)

### public enum UnityEngine.AI.OffMeshLinkType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- LinkTypeDropDown = 1
- LinkTypeJumpAcross = 2
- LinkTypeManual = 0

### public delegate UnityEngine.AI.NavMesh.OnNavMeshPreUpdate
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public NavMesh.OnNavMeshPreUpdate(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke()

## Namespace: UnityEngine.Experimental.AI

### public struct UnityEngine.Experimental.AI.NavMeshLocation

#### Fields
- private readonly UnityEngine.Experimental.AI.PolygonId <polygon>k__BackingField
- private readonly UnityEngine.Vector3 <position>k__BackingField

#### Properties
- public UnityEngine.Experimental.AI.PolygonId polygon { get; }
- public UnityEngine.Vector3 position { get; }

#### Constructors
- internal NavMeshLocation(UnityEngine.Vector3 position, UnityEngine.Experimental.AI.PolygonId polygon)

### public enum UnityEngine.Experimental.AI.NavMeshPolyTypes
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Ground = 0
- OffMeshConnection = 1

### public struct UnityEngine.Experimental.AI.NavMeshQuery
- Interfaces: System.IDisposable

#### Fields
- internal System.IntPtr m_NavMeshQuery

#### Constructors
- public NavMeshQuery(UnityEngine.Experimental.AI.NavMeshWorld world, Unity.Collections.Allocator allocator, int pathNodePoolSize = 0)

#### Methods
- public UnityEngine.Experimental.AI.PathQueryStatus BeginFindPath(UnityEngine.Experimental.AI.NavMeshLocation start, UnityEngine.Experimental.AI.NavMeshLocation end, int areaMask = -1, Unity.Collections.NativeArray<float> costs = null)
- private static UnityEngine.Experimental.AI.PathQueryStatus BeginFindPath(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.NavMeshLocation start, UnityEngine.Experimental.AI.NavMeshLocation end, int areaMask, void* costs)
- private static UnityEngine.Experimental.AI.PathQueryStatus BeginFindPath_Injected(System.IntPtr navMeshQuery, ref UnityEngine.Experimental.AI.NavMeshLocation start, ref UnityEngine.Experimental.AI.NavMeshLocation end, int areaMask, void* costs)
- private static System.IntPtr Create(UnityEngine.Experimental.AI.NavMeshWorld world, int nodePoolSize)
- public UnityEngine.Experimental.AI.NavMeshLocation CreateLocation(UnityEngine.Vector3 position, UnityEngine.Experimental.AI.PolygonId polygon)
- private static System.IntPtr Create_Injected(ref UnityEngine.Experimental.AI.NavMeshWorld world, int nodePoolSize)
- private static void Destroy(System.IntPtr navMeshQuery)
- public void Dispose()
- public UnityEngine.Experimental.AI.PathQueryStatus EndFindPath(out int pathSize)
- private static UnityEngine.Experimental.AI.PathQueryStatus EndFindPath(System.IntPtr navMeshQuery, out int pathSize)
- private static int GetAgentTypeIdForPolygon(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.PolygonId polygon)
- public int GetAgentTypeIdForPolygon(UnityEngine.Experimental.AI.PolygonId polygon)
- private static int GetAgentTypeIdForPolygon_Injected(System.IntPtr navMeshQuery, ref UnityEngine.Experimental.AI.PolygonId polygon)
- private static UnityEngine.Experimental.AI.PathQueryStatus GetClosestPointOnPoly(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.PolygonId polygon, UnityEngine.Vector3 position, out UnityEngine.Vector3 nearest)
- private static UnityEngine.Experimental.AI.PathQueryStatus GetClosestPointOnPoly_Injected(System.IntPtr navMeshQuery, ref UnityEngine.Experimental.AI.PolygonId polygon, ref UnityEngine.Vector3 position, out UnityEngine.Vector3 nearest)
- private static UnityEngine.Experimental.AI.PathQueryStatus GetEdgesAndNeighbors(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.PolygonId node, int maxVerts, int maxNei, void* verts, void* neighbors, void* edgeIndices, out int vertCount, out int neighborsCount)
- public UnityEngine.Experimental.AI.PathQueryStatus GetEdgesAndNeighbors(UnityEngine.Experimental.AI.PolygonId node, Unity.Collections.NativeSlice<UnityEngine.Vector3> edgeVertices, Unity.Collections.NativeSlice<UnityEngine.Experimental.AI.PolygonId> neighbors, Unity.Collections.NativeSlice<byte> edgeIndices, out int verticesCount, out int neighborsCount)
- private static UnityEngine.Experimental.AI.PathQueryStatus GetEdgesAndNeighbors_Injected(System.IntPtr navMeshQuery, ref UnityEngine.Experimental.AI.PolygonId node, int maxVerts, int maxNei, void* verts, void* neighbors, void* edgeIndices, out int vertCount, out int neighborsCount)
- public int GetPathResult(Unity.Collections.NativeSlice<UnityEngine.Experimental.AI.PolygonId> path)
- private static int GetPathResult(System.IntPtr navMeshQuery, void* path, int maxPath)
- private static UnityEngine.Experimental.AI.NavMeshPolyTypes GetPolygonType(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.PolygonId polygon)
- public UnityEngine.Experimental.AI.NavMeshPolyTypes GetPolygonType(UnityEngine.Experimental.AI.PolygonId polygon)
- private static UnityEngine.Experimental.AI.NavMeshPolyTypes GetPolygonType_Injected(System.IntPtr navMeshQuery, ref UnityEngine.Experimental.AI.PolygonId polygon)
- private static bool GetPortalPoints(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.PolygonId polygon, UnityEngine.Experimental.AI.PolygonId neighbourPolygon, out UnityEngine.Vector3 left, out UnityEngine.Vector3 right)
- public bool GetPortalPoints(UnityEngine.Experimental.AI.PolygonId polygon, UnityEngine.Experimental.AI.PolygonId neighbourPolygon, out UnityEngine.Vector3 left, out UnityEngine.Vector3 right)
- private static bool GetPortalPoints_Injected(System.IntPtr navMeshQuery, ref UnityEngine.Experimental.AI.PolygonId polygon, ref UnityEngine.Experimental.AI.PolygonId neighbourPolygon, out UnityEngine.Vector3 left, out UnityEngine.Vector3 right)
- private static bool IsPositionInPolygon(System.IntPtr navMeshQuery, UnityEngine.Vector3 position, UnityEngine.Experimental.AI.PolygonId polygon)
- private static bool IsPositionInPolygon_Injected(System.IntPtr navMeshQuery, ref UnityEngine.Vector3 position, ref UnityEngine.Experimental.AI.PolygonId polygon)
- public bool IsValid(UnityEngine.Experimental.AI.PolygonId polygon)
- public bool IsValid(UnityEngine.Experimental.AI.NavMeshLocation location)
- private static bool IsValidPolygon(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.PolygonId polygon)
- private static bool IsValidPolygon_Injected(System.IntPtr navMeshQuery, ref UnityEngine.Experimental.AI.PolygonId polygon)
- private static UnityEngine.Experimental.AI.NavMeshLocation MapLocation(System.IntPtr navMeshQuery, UnityEngine.Vector3 position, UnityEngine.Vector3 extents, int agentTypeID, int areaMask = -1)
- public UnityEngine.Experimental.AI.NavMeshLocation MapLocation(UnityEngine.Vector3 position, UnityEngine.Vector3 extents, int agentTypeID, int areaMask = -1)
- private static void MapLocation_Injected(System.IntPtr navMeshQuery, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 extents, int agentTypeID, int areaMask = -1, out UnityEngine.Experimental.AI.NavMeshLocation ret)
- private static UnityEngine.Experimental.AI.NavMeshLocation MoveLocation(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.NavMeshLocation location, UnityEngine.Vector3 target, int areaMask)
- public UnityEngine.Experimental.AI.NavMeshLocation MoveLocation(UnityEngine.Experimental.AI.NavMeshLocation location, UnityEngine.Vector3 target, int areaMask = -1)
- private static void MoveLocations(System.IntPtr navMeshQuery, void* locations, void* targets, void* areaMasks, int count)
- public void MoveLocations(Unity.Collections.NativeSlice<UnityEngine.Experimental.AI.NavMeshLocation> locations, Unity.Collections.NativeSlice<UnityEngine.Vector3> targets, Unity.Collections.NativeSlice<int> areaMasks)
- private static void MoveLocationsInSameAreas(System.IntPtr navMeshQuery, void* locations, void* targets, int count, int areaMask)
- public void MoveLocationsInSameAreas(Unity.Collections.NativeSlice<UnityEngine.Experimental.AI.NavMeshLocation> locations, Unity.Collections.NativeSlice<UnityEngine.Vector3> targets, int areaMask = -1)
- private static void MoveLocation_Injected(System.IntPtr navMeshQuery, ref UnityEngine.Experimental.AI.NavMeshLocation location, ref UnityEngine.Vector3 target, int areaMask, out UnityEngine.Experimental.AI.NavMeshLocation ret)
- private static UnityEngine.Matrix4x4 PolygonLocalToWorldMatrix(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.PolygonId polygon)
- public UnityEngine.Matrix4x4 PolygonLocalToWorldMatrix(UnityEngine.Experimental.AI.PolygonId polygon)
- private static void PolygonLocalToWorldMatrix_Injected(System.IntPtr navMeshQuery, ref UnityEngine.Experimental.AI.PolygonId polygon, out UnityEngine.Matrix4x4 ret)
- private static UnityEngine.Matrix4x4 PolygonWorldToLocalMatrix(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.PolygonId polygon)
- public UnityEngine.Matrix4x4 PolygonWorldToLocalMatrix(UnityEngine.Experimental.AI.PolygonId polygon)
- private static void PolygonWorldToLocalMatrix_Injected(System.IntPtr navMeshQuery, ref UnityEngine.Experimental.AI.PolygonId polygon, out UnityEngine.Matrix4x4 ret)
- private static UnityEngine.Experimental.AI.PathQueryStatus Raycast(System.IntPtr navMeshQuery, UnityEngine.Experimental.AI.NavMeshLocation start, UnityEngine.Vector3 targetPosition, int areaMask, void* costs, out UnityEngine.AI.NavMeshHit hit, void* path, out int pathCount, int maxPath)
- public UnityEngine.Experimental.AI.PathQueryStatus Raycast(out UnityEngine.AI.NavMeshHit hit, UnityEngine.Experimental.AI.NavMeshLocation start, UnityEngine.Vector3 targetPosition, int areaMask = -1, Unity.Collections.NativeArray<float> costs = null)
- public UnityEngine.Experimental.AI.PathQueryStatus Raycast(out UnityEngine.AI.NavMeshHit hit, Unity.Collections.NativeSlice<UnityEngine.Experimental.AI.PolygonId> path, out int pathCount, UnityEngine.Experimental.AI.NavMeshLocation start, UnityEngine.Vector3 targetPosition, int areaMask = -1, Unity.Collections.NativeArray<float> costs = null)
- private static UnityEngine.Experimental.AI.PathQueryStatus Raycast_Injected(System.IntPtr navMeshQuery, ref UnityEngine.Experimental.AI.NavMeshLocation start, ref UnityEngine.Vector3 targetPosition, int areaMask, void* costs, out UnityEngine.AI.NavMeshHit hit, void* path, out int pathCount, int maxPath)
- public UnityEngine.Experimental.AI.PathQueryStatus UpdateFindPath(int iterations, out int iterationsPerformed)
- private static UnityEngine.Experimental.AI.PathQueryStatus UpdateFindPath(System.IntPtr navMeshQuery, int iterations, out int iterationsPerformed)

### public struct UnityEngine.Experimental.AI.NavMeshWorld

#### Fields
- internal System.IntPtr world

#### Methods
- public void AddDependency(Unity.Jobs.JobHandle job)
- private static void AddDependencyInternal(System.IntPtr navmesh, Unity.Jobs.JobHandle handle)
- private static void AddDependencyInternal_Injected(System.IntPtr navmesh, ref Unity.Jobs.JobHandle handle)
- public static UnityEngine.Experimental.AI.NavMeshWorld GetDefaultWorld()
- private static void GetDefaultWorld_Injected(out UnityEngine.Experimental.AI.NavMeshWorld ret)
- public bool IsValid()

### public enum UnityEngine.Experimental.AI.PathQueryStatus
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BufferTooSmall = 16
- Failure = -2147483648
- InProgress = 536870912
- InvalidParam = 8
- OutOfMemory = 4
- OutOfNodes = 32
- PartialResult = 64
- StatusDetailMask = 16777215
- Success = 1073741824
- WrongMagic = 1
- WrongVersion = 2

### public struct UnityEngine.Experimental.AI.PolygonId
- Interfaces: System.IEquatable<UnityEngine.Experimental.AI.PolygonId>

#### Fields
- internal ulong polyRef

#### Methods
- public bool Equals(UnityEngine.Experimental.AI.PolygonId rhs)
- public override bool Equals(object obj)
- public override int GetHashCode()
- public bool IsNull()
- public static bool op_Equality(UnityEngine.Experimental.AI.PolygonId x, UnityEngine.Experimental.AI.PolygonId y)
- public static bool op_Inequality(UnityEngine.Experimental.AI.PolygonId x, UnityEngine.Experimental.AI.PolygonId y)

