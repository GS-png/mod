# Assembly: UnityEngine.TerrainModule
- Path: tools/WorldBox.Managed/UnityEngine.TerrainModule.dll
- Types: 47

## Namespace: UnityEngine

### private enum UnityEngine.TerrainData.BoundaryValueType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- MaxAlphamapRes = 6
- MaxBaseMapRes = 8
- MaxCoveragePerRes = 4
- MaxDetailPatchCount = 3
- MaxDetailResPerPatch = 2
- MaxHeightmapRes = 0
- MinAlphamapRes = 5
- MinBaseMapRes = 7
- MinDetailResPerPatch = 1

### public struct UnityEngine.DetailInstanceTransform

#### Fields
- public float posX
- public float posY
- public float posZ
- public float rotationY
- public float scaleXZ
- public float scaleY

### public class UnityEngine.DetailPrototype

#### Fields
- internal static readonly UnityEngine.Color DefaultDryColor
- internal static readonly UnityEngine.Color DefaultHealthColor
- internal float m_AlignToGround
- internal float m_Density
- internal UnityEngine.Color m_DryColor
- internal UnityEngine.Color m_HealthyColor
- internal float m_HoleEdgePadding
- internal float m_MaxHeight
- internal float m_MaxWidth
- internal float m_MinHeight
- internal float m_MinWidth
- internal int m_NoiseSeed
- internal float m_NoiseSpread
- internal float m_PositionJitter
- internal UnityEngine.GameObject m_Prototype
- internal UnityEngine.Texture2D m_PrototypeTexture
- internal int m_RenderMode
- internal float m_TargetCoverage
- internal int m_UseDensityScaling
- internal int m_UseInstancing
- internal int m_UsePrototypeMesh

#### Properties
- public float alignToGround { get; set; }
- public float bendFactor { get; set; }
- public float density { get; set; }
- public UnityEngine.Color dryColor { get; set; }
- public UnityEngine.Color healthyColor { get; set; }
- public float holeEdgePadding { get; set; }
- public float maxHeight { get; set; }
- public float maxWidth { get; set; }
- public float minHeight { get; set; }
- public float minWidth { get; set; }
- public int noiseSeed { get; set; }
- public float noiseSpread { get; set; }
- public float positionJitter { get; set; }
- public UnityEngine.GameObject prototype { get; set; }
- public UnityEngine.Texture2D prototypeTexture { get; set; }
- public UnityEngine.DetailRenderMode renderMode { get; set; }
- public float targetCoverage { get; set; }
- public bool useDensityScaling { get; set; }
- public bool useInstancing { get; set; }
- public bool usePrototypeMesh { get; set; }

#### Constructors
- public DetailPrototype()
- private static DetailPrototype()
- public DetailPrototype(UnityEngine.DetailPrototype other)

#### Methods
- public override bool Equals(object obj)
- private bool Equals(UnityEngine.DetailPrototype other)
- public override int GetHashCode()
- internal static bool IsModeSupportedByRenderPipeline(UnityEngine.DetailRenderMode renderMode, bool useInstancing, out string errorMessage)
- public bool Validate()
- public bool Validate(out string errorMessage)
- internal static bool ValidateDetailPrototype(UnityEngine.DetailPrototype prototype, out string errorMessage)

### public enum UnityEngine.DetailRenderMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Grass = 2
- GrassBillboard = 0
- VertexLit = 1

### public enum UnityEngine.DetailScatterMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CoverageMode = 0
- InstanceCountMode = 1

### public delegate UnityEngine.TerrainCallbacks.HeightmapChangedCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public TerrainCallbacks.HeightmapChangedCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(UnityEngine.Terrain terrain, UnityEngine.RectInt heightRegion, bool synched, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(UnityEngine.Terrain terrain, UnityEngine.RectInt heightRegion, bool synched)

### public enum UnityEngine.Terrain.MaterialType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BuiltInLegacyDiffuse = 1
- BuiltInLegacySpecular = 2
- BuiltInStandard = 0
- Custom = 3

### public struct UnityEngine.PatchExtents

#### Fields
- internal float m_max
- internal float m_min

#### Properties
- public float max { get; set; }
- public float min { get; set; }

### internal class UnityEngine.SpeedTreeWindAsset
- Base: UnityEngine.Object

#### Constructors
- private SpeedTreeWindAsset()

### public class UnityEngine.SplatPrototype

#### Fields
- internal UnityEngine.Texture2D m_NormalMap
- internal float m_Smoothness
- internal UnityEngine.Vector4 m_SpecularMetallic
- internal UnityEngine.Texture2D m_Texture
- internal UnityEngine.Vector2 m_TileOffset
- internal UnityEngine.Vector2 m_TileSize

#### Properties
- public float metallic { get; set; }
- public UnityEngine.Texture2D normalMap { get; set; }
- public float smoothness { get; set; }
- public UnityEngine.Color specular { get; set; }
- public UnityEngine.Texture2D texture { get; set; }
- public UnityEngine.Vector2 tileOffset { get; set; }
- public UnityEngine.Vector2 tileSize { get; set; }

#### Constructors
- public SplatPrototype()

### public class UnityEngine.Terrain
- Base: UnityEngine.Behaviour

#### Properties
- public static UnityEngine.Terrain activeTerrain { get; }
- public static UnityEngine.Terrain[] activeTerrains { get; }
- public bool allowAutoConnect { get; set; }
- public float basemapDistance { get; set; }
- public UnityEngine.Terrain bottomNeighbor { get; }
- public bool castShadows { get; set; }
- public bool collectDetailPatches { get; set; }
- public static UnityEngine.Experimental.Rendering.GraphicsFormat compressedHolesFormat { get; }
- public static UnityEngine.TextureFormat compressedHolesTextureFormat { get; }
- public float detailObjectDensity { get; set; }
- public float detailObjectDistance { get; set; }
- public bool drawHeightmap { get; set; }
- public bool drawInstanced { get; set; }
- public bool drawTreesAndFoliage { get; set; }
- public UnityEngine.TerrainRenderFlags editorRenderFlags { get; set; }
- public bool enableHeightmapRayTracing { get; set; }
- public bool freeUnusedRenderingResources { get; set; }
- public int groupingID { get; set; }
- public static UnityEngine.Experimental.Rendering.GraphicsFormat heightmapFormat { get; }
- public int heightmapMaximumLOD { get; set; }
- public int heightmapMinimumLODSimplification { get; set; }
- public float heightmapPixelError { get; set; }
- public static UnityEngine.RenderTextureFormat heightmapRenderTextureFormat { get; }
- public static UnityEngine.TextureFormat heightmapTextureFormat { get; }
- public static UnityEngine.Experimental.Rendering.GraphicsFormat holesFormat { get; }
- public static UnityEngine.RenderTextureFormat holesRenderTextureFormat { get; }
- public bool ignoreQualitySettings { get; set; }
- public bool keepUnusedRenderingResources { get; set; }
- public UnityEngine.Terrain leftNeighbor { get; }
- public float legacyShininess { get; set; }
- public UnityEngine.Color legacySpecular { get; set; }
- public int lightmapIndex { get; set; }
- public UnityEngine.Vector4 lightmapScaleOffset { get; set; }
- public UnityEngine.Material materialTemplate { get; set; }
- public UnityEngine.Terrain.MaterialType materialType { get; set; }
- public static UnityEngine.Experimental.Rendering.GraphicsFormat normalmapFormat { get; }
- public static UnityEngine.RenderTextureFormat normalmapRenderTextureFormat { get; }
- public UnityEngine.RenderTexture normalmapTexture { get; }
- public static UnityEngine.TextureFormat normalmapTextureFormat { get; }
- public UnityEngine.Vector3 patchBoundsMultiplier { get; set; }
- public bool preserveTreePrototypeLayers { get; set; }
- public int realtimeLightmapIndex { get; set; }
- public UnityEngine.Vector4 realtimeLightmapScaleOffset { get; set; }
- public UnityEngine.Rendering.ReflectionProbeUsage reflectionProbeUsage { get; set; }
- public uint renderingLayerMask { get; set; }
- public UnityEngine.Terrain rightNeighbor { get; }
- public UnityEngine.Rendering.ShadowCastingMode shadowCastingMode { get; set; }
- public float splatmapDistance { get; set; }
- public UnityEngine.TerrainData terrainData { get; set; }
- public UnityEngine.Terrain topNeighbor { get; }
- public float treeBillboardDistance { get; set; }
- public float treeCrossFadeLength { get; set; }
- public float treeDistance { get; set; }
- public float treeLODBiasMultiplier { get; set; }
- public int treeMaximumFullLODCount { get; set; }
- public UnityEngine.TreeMotionVectorModeOverride treeMotionVectorModeOverride { get; set; }

#### Constructors
- public Terrain()

#### Methods
- public void AddTreeInstance(UnityEngine.TreeInstance instance)
- private void AddTreeInstance_Injected(ref UnityEngine.TreeInstance instance)
- public void ApplyDelayedHeightmapModification()
- public static UnityEngine.GameObject CreateTerrainGameObject(UnityEngine.TerrainData assignTerrain)
- public void Flush()
- public static void GetActiveTerrains(System.Collections.Generic.List<UnityEngine.Terrain> terrainList)
- public void GetClosestReflectionProbes(System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo> result)
- public bool GetKeepUnusedCameraRenderingResources(int cameraInstanceID)
- public UnityEngine.Vector3 GetPosition()
- private void GetPosition_Injected(out UnityEngine.Vector3 ret)
- public void GetSplatMaterialPropertyBlock(UnityEngine.MaterialPropertyBlock dest)
- private static void Internal_FillActiveTerrainList(object terrainList)
- private void Internal_GetSplatMaterialPropertyBlock(UnityEngine.MaterialPropertyBlock dest)
- internal void RemoveTrees(UnityEngine.Vector2 position, float radius, int prototypeIndex)
- private void RemoveTrees_Injected(ref UnityEngine.Vector2 position, float radius, int prototypeIndex)
- public float SampleHeight(UnityEngine.Vector3 worldPosition)
- private float SampleHeight_Injected(ref UnityEngine.Vector3 worldPosition)
- public static void SetConnectivityDirty()
- public void SetKeepUnusedCameraRenderingResources(int cameraInstanceID, bool keepUnused)
- public void SetNeighbors(UnityEngine.Terrain left, UnityEngine.Terrain top, UnityEngine.Terrain right, UnityEngine.Terrain bottom)
- public void SetSplatMaterialPropertyBlock(UnityEngine.MaterialPropertyBlock properties)

### public static class UnityEngine.TerrainCallbacks

#### Fields
- private static UnityEngine.TerrainCallbacks.HeightmapChangedCallback heightmapChanged
- private static UnityEngine.TerrainCallbacks.TextureChangedCallback textureChanged

#### Events
- public static event UnityEngine.TerrainCallbacks.HeightmapChangedCallback heightmapChanged
- public static event UnityEngine.TerrainCallbacks.TextureChangedCallback textureChanged

#### Methods
- internal static void InvokeHeightmapChangedCallback(UnityEngine.TerrainData terrainData, UnityEngine.RectInt heightRegion, bool synched)
- internal static void InvokeTextureChangedCallback(UnityEngine.TerrainData terrainData, string textureName, UnityEngine.RectInt texelRegion, bool synched)

### public enum UnityEngine.TerrainChangedFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DelayedHeightmapUpdate = 4
- DelayedHolesUpdate = 128
- FlushEverythingImmediately = 8
- Heightmap = 1
- HeightmapResolution = 32
- Holes = 64
- RemoveDirtyDetailsImmediately = 16
- TreeInstances = 2
- WillBeDestroyed = 256

### public class UnityEngine.TerrainData
- Base: UnityEngine.Object

#### Fields
- private static const string k_DetailDatabasePrefix
- private static const string k_HeightmapPrefix
- internal static readonly int k_MaximumAlphamapResolution
- internal static readonly int k_MaximumBaseMapResolution
- internal static readonly int k_MaximumDetailPatchCount
- internal static readonly int k_MaximumDetailResolutionPerPatch
- internal static readonly int k_MaximumResolution
- internal static readonly int k_MinimumAlphamapResolution
- internal static readonly int k_MinimumBaseMapResolution
- internal static readonly int k_MinimumDetailResolutionPerPatch
- private static const string k_ScriptingInterfaceName
- private static const string k_ScriptingInterfacePrefix
- private static const string k_SplatDatabasePrefix
- private static const string k_TreeDatabasePrefix

#### Properties
- public int alphamapHeight { get; }
- public int alphamapLayers { get; }
- public int alphamapResolution { get; set; }
- public int alphamapTextureCount { get; }
- public static string AlphamapTextureName { get; }
- public UnityEngine.Texture2D[] alphamapTextures { get; }
- public int alphamapWidth { get; }
- internal UnityEngine.TextureFormat atlasFormat { get; }
- public int baseMapResolution { get; set; }
- public UnityEngine.Bounds bounds { get; }
- public int detailHeight { get; }
- public int detailPatchCount { get; }
- public UnityEngine.DetailPrototype[] detailPrototypes { get; set; }
- public int detailResolution { get; }
- public int detailResolutionPerPatch { get; }
- public UnityEngine.DetailScatterMode detailScatterMode { get; }
- public int detailWidth { get; }
- public bool enableHolesTextureCompression { get; set; }
- public int heightmapHeight { get; }
- public int heightmapResolution { get; set; }
- public UnityEngine.Vector3 heightmapScale { get; }
- public UnityEngine.RenderTexture heightmapTexture { get; }
- public int heightmapWidth { get; }
- internal UnityEngine.RenderTexture holesRenderTexture { get; }
- public int holesResolution { get; }
- public UnityEngine.Texture holesTexture { get; }
- public static string HolesTextureName { get; }
- private int internalHeightmapResolution { get; set; }
- private int Internal_alphamapResolution { get; set; }
- private int Internal_baseMapResolution { get; set; }
- public int maxDetailScatterPerRes { get; }
- public UnityEngine.Vector3 size { get; set; }
- public UnityEngine.SplatPrototype[] splatPrototypes { get; set; }
- private static bool SupportsCopyTextureBetweenRTAndTexture { get; }
- public UnityEngine.TerrainLayer[] terrainLayers { get; set; }
- public float thickness { get; set; }
- public int treeInstanceCount { get; }
- public UnityEngine.TreeInstance[] treeInstances { get; set; }
- public UnityEngine.TreePrototype[] treePrototypes { get; set; }
- internal UnityEngine.Terrain[] users { get; }
- public float wavingGrassAmount { get; set; }
- public float wavingGrassSpeed { get; set; }
- public float wavingGrassStrength { get; set; }
- public UnityEngine.Color wavingGrassTint { get; set; }

#### Constructors
- public TerrainData()
- private static TerrainData()

#### Methods
- internal void AddTree(ref UnityEngine.TreeInstance tree)
- public float ComputeDetailCoverage(int detailPrototypeIndex)
- public UnityEngine.DetailInstanceTransform[] ComputeDetailInstanceTransforms(int patchX, int patchY, int layer, float density, out UnityEngine.Bounds bounds)
- public void CopyActiveRenderTextureToHeightmap(UnityEngine.RectInt sourceRect, UnityEngine.Vector2Int dest, UnityEngine.TerrainHeightmapSyncControl syncControl)
- public void CopyActiveRenderTextureToTexture(string textureName, int textureIndex, UnityEngine.RectInt sourceRect, UnityEngine.Vector2Int dest, bool allowDelayedCPUSync)
- public void DirtyHeightmapRegion(UnityEngine.RectInt region, UnityEngine.TerrainHeightmapSyncControl syncControl)
- public void DirtyTextureRegion(string textureName, UnityEngine.RectInt region, bool allowDelayedCPUSync)
- internal int GetAdjustedSize(int size)
- internal float GetAlphamapResolutionInternal()
- public float[,,] GetAlphamaps(int x, int y, int width, int height)
- public UnityEngine.Texture2D GetAlphamapTexture(int index)
- private static int GetBoundaryValue(UnityEngine.TerrainData.BoundaryValueType type)
- internal UnityEngine.Texture2D GetCompressedHolesTexture()
- public int[,] GetDetailLayer(int xBase, int yBase, int width, int height, int layer)
- public int[,] GetDetailLayer(UnityEngine.Vector2Int positionBase, UnityEngine.Vector2Int size, int layer)
- public float GetHeight(int x, int y)
- public float[,] GetHeights(int xBase, int yBase, int width, int height)
- public bool[,] GetHoles(int xBase, int yBase, int width, int height)
- internal UnityEngine.RenderTexture GetHolesTexture()
- public float GetInterpolatedHeight(float x, float y)
- public float[,] GetInterpolatedHeights(float xBase, float yBase, int xCount, int yCount, float xInterval, float yInterval)
- public void GetInterpolatedHeights(float[,] results, int resultXOffset, int resultYOffset, float xBase, float yBase, int xCount, int yCount, float xInterval, float yInterval)
- public UnityEngine.Vector3 GetInterpolatedNormal(float x, float y)
- private void GetInterpolatedNormal_Injected(float x, float y, out UnityEngine.Vector3 ret)
- public float[] GetMaximumHeightError()
- public UnityEngine.PatchExtents[] GetPatchMinMaxHeights()
- public float GetSteepness(float x, float y)
- public int[] GetSupportedLayers(int xBase, int yBase, int totalWidth, int totalHeight)
- public int[] GetSupportedLayers(UnityEngine.Vector2Int positionBase, UnityEngine.Vector2Int size)
- public UnityEngine.TreeInstance GetTreeInstance(int index)
- private void Internal_ClearAlphamapDirtyRegion(int alphamapIndex)
- private void Internal_CopyActiveRenderTextureToHeightmap(UnityEngine.RectInt rect, int destX, int destY, UnityEngine.TerrainHeightmapSyncControl syncControl)
- private void Internal_CopyActiveRenderTextureToHeightmap_Injected(ref UnityEngine.RectInt rect, int destX, int destY, UnityEngine.TerrainHeightmapSyncControl syncControl)
- private void Internal_CopyActiveRenderTextureToHoles(UnityEngine.RectInt rect, int destX, int destY, bool allowDelayedCPUSync)
- private void Internal_CopyActiveRenderTextureToHoles_Injected(ref UnityEngine.RectInt rect, int destX, int destY, bool allowDelayedCPUSync)
- private static void Internal_Create(UnityEngine.TerrainData terrainData)
- private void Internal_DirtyHeightmapRegion(int x, int y, int width, int height, UnityEngine.TerrainHeightmapSyncControl syncControl)
- private void Internal_DirtyHolesRegion(int x, int y, int width, int height, bool allowDelayedCPUSync)
- private float[,,] Internal_GetAlphamaps(int x, int y, int width, int height)
- private float[,] Internal_GetHeights(int xBase, int yBase, int width, int height)
- private bool[,] Internal_GetHoles(int xBase, int yBase, int width, int height)
- private void Internal_GetInterpolatedHeights(float[,] results, int resultXDimension, int resultXOffset, int resultYOffset, float xBase, float yBase, int xCount, int yCount, float xInterval, float yInterval)
- private UnityEngine.TreeInstance Internal_GetTreeInstance(int index)
- private UnityEngine.TreeInstance[] Internal_GetTreeInstances()
- private void Internal_GetTreeInstance_Injected(int index, out UnityEngine.TreeInstance ret)
- private bool Internal_IsHole(int x, int y)
- private void Internal_MarkAlphamapDirtyRegion(int alphamapIndex, int x, int y, int width, int height)
- private void Internal_SetAlphamaps(int x, int y, int width, int height, float[,,] map)
- private void Internal_SetDetailLayer(int xBase, int yBase, int totalWidth, int totalHeight, int detailIndex, int[,] data)
- private void Internal_SetDetailResolution(int patchCount, int resolutionPerPatch)
- private void Internal_SetDetailScatterMode(UnityEngine.DetailScatterMode scatterMode)
- private void Internal_SetHeights(int xBase, int yBase, int width, int height, float[,] heights)
- private void Internal_SetHeightsDelayLOD(int xBase, int yBase, int width, int height, float[,] heights)
- private void Internal_SetHoles(int xBase, int yBase, int width, int height, bool[,] holes)
- private void Internal_SetHolesDelayLOD(int xBase, int yBase, int width, int height, bool[,] holes)
- private void Internal_SyncAlphamaps()
- private void Internal_SyncHoles()
- public bool IsHole(int x, int y)
- internal bool IsHolesTextureCompressed()
- internal bool NeedUpgradeScaledTreePrototypes()
- public void OverrideMaximumHeightError(float[] maxError)
- public void OverrideMinMaxPatchHeights(UnityEngine.PatchExtents[] minMaxHeights)
- public void RefreshPrototypes()
- public void RemoveDetailPrototype(int index)
- internal void RemoveTreePrototype(int index)
- internal int RemoveTrees(UnityEngine.Vector2 position, float radius, int prototypeIndex)
- private int RemoveTrees_Injected(ref UnityEngine.Vector2 position, float radius, int prototypeIndex)
- internal void ResetDirtyDetails()
- public void SetAlphamaps(int x, int y, float[,,] map)
- public void SetBaseMapDirty()
- public void SetDetailLayer(int xBase, int yBase, int layer, int[,] details)
- public void SetDetailLayer(UnityEngine.Vector2Int basePosition, int layer, int[,] details)
- public void SetDetailResolution(int detailResolution, int resolutionPerPatch)
- public void SetDetailScatterMode(UnityEngine.DetailScatterMode scatterMode)
- public void SetHeights(int xBase, int yBase, float[,] heights)
- public void SetHeightsDelayLOD(int xBase, int yBase, float[,] heights)
- public void SetHoles(int xBase, int yBase, bool[,] holes)
- public void SetHolesDelayLOD(int xBase, int yBase, bool[,] holes)
- public void SetTreeInstance(int index, UnityEngine.TreeInstance instance)
- public void SetTreeInstances(UnityEngine.TreeInstance[] instances, bool snapToHeightmap)
- private void SetTreeInstance_Injected(int index, ref UnityEngine.TreeInstance instance)
- public void SyncHeightmap()
- public void SyncTexture(string textureName)
- public void UpdateDirtyRegion(int x, int y, int width, int height, bool syncHeightmapTextureImmediately)
- internal void UpgradeScaledTreePrototype()

### public static class UnityEngine.TerrainExtensions

#### Methods
- public static void UpdateGIMaterials(UnityEngine.Terrain terrain)
- public static void UpdateGIMaterials(UnityEngine.Terrain terrain, int x, int y, int width, int height)
- internal static void UpdateGIMaterialsForTerrain(int terrainInstanceID, UnityEngine.Rect uvBounds)
- private static void UpdateGIMaterialsForTerrain_Injected(int terrainInstanceID, ref UnityEngine.Rect uvBounds)

### public enum UnityEngine.TerrainHeightmapSyncControl
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- HeightAndLod = 2
- HeightOnly = 1
- None = 0

### public class UnityEngine.TerrainLayer
- Base: UnityEngine.Object

#### Properties
- public UnityEngine.Vector4 diffuseRemapMax { get; set; }
- public UnityEngine.Vector4 diffuseRemapMin { get; set; }
- public UnityEngine.Texture2D diffuseTexture { get; set; }
- public UnityEngine.Vector4 maskMapRemapMax { get; set; }
- public UnityEngine.Vector4 maskMapRemapMin { get; set; }
- public UnityEngine.Texture2D maskMapTexture { get; set; }
- public float metallic { get; set; }
- public UnityEngine.Texture2D normalMapTexture { get; set; }
- public float normalScale { get; set; }
- public float smoothness { get; set; }
- public UnityEngine.Color specular { get; set; }
- public UnityEngine.Vector2 tileOffset { get; set; }
- public UnityEngine.Vector2 tileSize { get; set; }

#### Constructors
- public TerrainLayer()

#### Methods
- private static void Internal_Create(UnityEngine.TerrainLayer layer)

### public enum UnityEngine.TerrainRenderFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- all = 7
- All = 7
- details = 4
- Details = 4
- heightmap = 1
- Heightmap = 1
- trees = 2
- Trees = 2

### public delegate UnityEngine.TerrainCallbacks.TextureChangedCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public TerrainCallbacks.TextureChangedCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(UnityEngine.Terrain terrain, string textureName, UnityEngine.RectInt texelRegion, bool synched, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(UnityEngine.Terrain terrain, string textureName, UnityEngine.RectInt texelRegion, bool synched)

### public class UnityEngine.Tree
- Base: UnityEngine.Component

#### Properties
- public UnityEngine.ScriptableObject data { get; set; }
- public bool hasSpeedTreeWind { get; }

#### Constructors
- public Tree()

### public struct UnityEngine.TreeInstance

#### Fields
- public UnityEngine.Color32 color
- public float heightScale
- public UnityEngine.Color32 lightmapColor
- public UnityEngine.Vector3 position
- public int prototypeIndex
- public float rotation
- internal float temporaryDistance
- public float widthScale

### public enum UnityEngine.TreeMotionVectorModeOverride
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CameraMotionOnly = 0
- ForceNoMotion = 2
- InheritFromPrototype = 3
- PerObjectMotion = 1

### public class UnityEngine.TreePrototype

#### Fields
- internal float m_BendFactor
- internal int m_NavMeshLod
- internal UnityEngine.GameObject m_Prefab

#### Properties
- public float bendFactor { get; set; }
- public int navMeshLod { get; set; }
- public UnityEngine.GameObject prefab { get; set; }

#### Constructors
- public TreePrototype()
- public TreePrototype(UnityEngine.TreePrototype other)

#### Methods
- public override bool Equals(object obj)
- private bool Equals(UnityEngine.TreePrototype other)
- public override int GetHashCode()
- internal bool Validate(out string errorMessage)
- internal static bool ValidateTreePrototype(UnityEngine.TreePrototype prototype, out string errorMessage)

## Namespace: UnityEngine.TerrainTools

### private class UnityEngine.TerrainTools.PaintContext.<>c

#### Fields
- public static readonly UnityEngine.TerrainTools.PaintContext.<>c <>9
- public static System.Func<UnityEngine.TerrainTools.PaintContext.ITerrainInfo, UnityEngine.Texture> <>9__60_0
- public static System.Func<UnityEngine.TerrainTools.PaintContext.ITerrainInfo, UnityEngine.RenderTexture> <>9__61_0
- public static System.Action<UnityEngine.TerrainTools.PaintContext.ITerrainInfo> <>9__61_2
- public static System.Func<UnityEngine.TerrainTools.PaintContext.ITerrainInfo, UnityEngine.Texture> <>9__62_0
- public static System.Func<UnityEngine.TerrainTools.PaintContext.ITerrainInfo, UnityEngine.Texture> <>9__64_0

#### Constructors
- private static PaintContext.<>c()
- public PaintContext.<>c()

#### Methods
- internal UnityEngine.Texture <GatherHeightmap>b__60_0(UnityEngine.TerrainTools.PaintContext.ITerrainInfo t)
- internal UnityEngine.Texture <GatherHoles>b__62_0(UnityEngine.TerrainTools.PaintContext.ITerrainInfo t)
- internal UnityEngine.Texture <GatherNormals>b__64_0(UnityEngine.TerrainTools.PaintContext.ITerrainInfo t)
- internal UnityEngine.RenderTexture <ScatterHeightmap>b__61_0(UnityEngine.TerrainTools.PaintContext.ITerrainInfo t)
- internal void <ScatterHeightmap>b__61_2(UnityEngine.TerrainTools.PaintContext.ITerrainInfo t)

### private class UnityEngine.TerrainTools.PaintContext.<>c__DisplayClass53_0

#### Fields
- public float maxX
- public float maxZ
- public float minX
- public float minZ

#### Constructors
- public PaintContext.<>c__DisplayClass53_0()

#### Methods
- internal bool <FindTerrainTilesUnlimited>b__0(UnityEngine.Terrain t)

### private class UnityEngine.TerrainTools.PaintContext.<>c__DisplayClass60_0

#### Fields
- public UnityEngine.TerrainTools.PaintContext <>4__this
- public UnityEngine.Material blitMaterial

#### Constructors
- public PaintContext.<>c__DisplayClass60_0()

#### Methods
- internal void <GatherHeightmap>b__1(UnityEngine.TerrainTools.PaintContext.ITerrainInfo t)

### private class UnityEngine.TerrainTools.PaintContext.<>c__DisplayClass61_0

#### Fields
- public UnityEngine.TerrainTools.PaintContext <>4__this
- public UnityEngine.Material blitMaterial
- public string editorUndoName

#### Constructors
- public PaintContext.<>c__DisplayClass61_0()

#### Methods
- internal void <ScatterHeightmap>b__1(UnityEngine.TerrainTools.PaintContext.ITerrainInfo t)

### private class UnityEngine.TerrainTools.PaintContext.<>c__DisplayClass63_0

#### Fields
- public string editorUndoName

#### Constructors
- public PaintContext.<>c__DisplayClass63_0()

#### Methods
- internal UnityEngine.RenderTexture <ScatterHoles>b__0(UnityEngine.TerrainTools.PaintContext.ITerrainInfo t)

### private class UnityEngine.TerrainTools.PaintContext.<>c__DisplayClass66_0

#### Fields
- public UnityEngine.TerrainTools.PaintContext <>4__this
- public bool addLayerIfDoesntExist
- public UnityEngine.Material copyTerrainLayerMaterial
- public UnityEngine.TerrainLayer inputLayer
- public UnityEngine.Vector4[] layerMasks

#### Constructors
- public PaintContext.<>c__DisplayClass66_0()

#### Methods
- internal UnityEngine.Texture <GatherAlphamap>b__0(UnityEngine.TerrainTools.PaintContext.ITerrainInfo t)
- internal void <GatherAlphamap>b__1(UnityEngine.TerrainTools.PaintContext.ITerrainInfo t)

### private class UnityEngine.TerrainTools.PaintContext.<>c__DisplayClass67_0

#### Fields
- public UnityEngine.TerrainTools.PaintContext <>4__this
- public UnityEngine.Material copyTerrainLayerMaterial
- public string editorUndoName
- public UnityEngine.Vector4[] layerMasks
- public UnityEngine.RenderTexture tempTarget

#### Constructors
- public PaintContext.<>c__DisplayClass67_0()

#### Methods
- internal UnityEngine.RenderTexture <ScatterAlphamap>b__0(UnityEngine.TerrainTools.PaintContext.ITerrainInfo t)

### public struct UnityEngine.TerrainTools.BrushTransform

#### Fields
- private readonly UnityEngine.Vector2 <brushOrigin>k__BackingField
- private readonly UnityEngine.Vector2 <brushU>k__BackingField
- private readonly UnityEngine.Vector2 <brushV>k__BackingField
- private readonly UnityEngine.Vector2 <targetOrigin>k__BackingField
- private readonly UnityEngine.Vector2 <targetX>k__BackingField
- private readonly UnityEngine.Vector2 <targetY>k__BackingField

#### Properties
- public UnityEngine.Vector2 brushOrigin { get; }
- public UnityEngine.Vector2 brushU { get; }
- public UnityEngine.Vector2 brushV { get; }
- public UnityEngine.Vector2 targetOrigin { get; }
- public UnityEngine.Vector2 targetX { get; }
- public UnityEngine.Vector2 targetY { get; }

#### Constructors
- public BrushTransform(UnityEngine.Vector2 brushOrigin, UnityEngine.Vector2 brushU, UnityEngine.Vector2 brushV)

#### Methods
- public UnityEngine.Vector2 FromBrushUV(UnityEngine.Vector2 brushUV)
- public static UnityEngine.TerrainTools.BrushTransform FromRect(UnityEngine.Rect brushRect)
- public UnityEngine.Rect GetBrushXYBounds()
- public UnityEngine.Vector2 ToBrushUV(UnityEngine.Vector2 targetXY)

### public interface UnityEngine.TerrainTools.PaintContext.ITerrainInfo

#### Properties
- public UnityEngine.RectInt clippedPCPixels { get; }
- public UnityEngine.RectInt clippedTerrainPixels { get; }
- public bool gatherEnable { get; set; }
- public UnityEngine.RectInt paddedPCPixels { get; }
- public UnityEngine.RectInt paddedTerrainPixels { get; }
- public bool scatterEnable { get; set; }
- public UnityEngine.Terrain terrain { get; }
- public object userData { get; set; }

### public class UnityEngine.TerrainTools.PaintContext

#### Fields
- private UnityEngine.RenderTexture <destinationRenderTexture>k__BackingField
- private UnityEngine.RenderTexture <oldRenderTexture>k__BackingField
- private readonly UnityEngine.Terrain <originTerrain>k__BackingField
- private readonly UnityEngine.RectInt <pixelRect>k__BackingField
- private readonly UnityEngine.Vector2 <pixelSize>k__BackingField
- private UnityEngine.RenderTexture <sourceRenderTexture>k__BackingField
- private readonly int <targetTextureHeight>k__BackingField
- private readonly int <targetTextureWidth>k__BackingField
- internal static const int k_MaximumResolution
- internal static const int k_MinimumResolution
- private float m_HeightWorldSpaceMax
- private float m_HeightWorldSpaceMin
- private System.Collections.Generic.List<UnityEngine.TerrainTools.PaintContext.TerrainTile> m_TerrainTiles
- private static System.Action<UnityEngine.TerrainTools.PaintContext.ITerrainInfo, UnityEngine.TerrainTools.PaintContext.ToolAction, string> onTerrainTileBeforePaint
- private static System.Collections.Generic.List<UnityEngine.TerrainTools.PaintContext.PaintedTerrain> s_PaintedTerrain

#### Properties
- public UnityEngine.RenderTexture destinationRenderTexture { get; private set; }
- public float heightWorldSpaceMin { get; }
- public float heightWorldSpaceSize { get; }
- public static float kNormalizedHeightScale { get; }
- public UnityEngine.RenderTexture oldRenderTexture { get; private set; }
- public UnityEngine.Terrain originTerrain { get; }
- public UnityEngine.RectInt pixelRect { get; }
- public UnityEngine.Vector2 pixelSize { get; }
- public UnityEngine.RenderTexture sourceRenderTexture { get; private set; }
- public int targetTextureHeight { get; }
- public int targetTextureWidth { get; }
- public int terrainCount { get; }

#### Events
- internal static event System.Action<UnityEngine.TerrainTools.PaintContext.ITerrainInfo, UnityEngine.TerrainTools.PaintContext.ToolAction, string> onTerrainTileBeforePaint

#### Constructors
- private static PaintContext()
- public PaintContext(UnityEngine.Terrain terrain, UnityEngine.RectInt pixelRect, int targetTextureWidth, int targetTextureHeight, bool sharedBoundaryTexel = true, bool fillOutsideTerrain = true)

#### Methods
- public static void ApplyDelayedActions()
- internal static int ClampContextResolution(int resolution)
- public void Cleanup(bool restoreRenderTexture = true)
- public static UnityEngine.TerrainTools.PaintContext CreateFromBounds(UnityEngine.Terrain terrain, UnityEngine.Rect boundsInTerrainSpace, int inputTextureWidth, int inputTextureHeight, int extraBorderPixels = 0, bool sharedBoundaryTexel = true, bool fillOutsideTerrain = true)
- public void CreateRenderTargets(UnityEngine.RenderTextureFormat colorFormat)
- private void FindTerrainTilesUnlimited(bool sharedBoundaryTexel, bool fillOutsideTerrain)
- public void Gather(System.Func<UnityEngine.TerrainTools.PaintContext.ITerrainInfo, UnityEngine.Texture> terrainSource, UnityEngine.Color defaultColor, UnityEngine.Material blitMaterial = null, int blitPass = 0, System.Action<UnityEngine.TerrainTools.PaintContext.ITerrainInfo> beforeBlit = null, System.Action<UnityEngine.TerrainTools.PaintContext.ITerrainInfo> afterBlit = null)
- public void GatherAlphamap(UnityEngine.TerrainLayer inputLayer, bool addLayerIfDoesntExist = true)
- public void GatherHeightmap()
- public void GatherHoles()
- private void GatherInternal(System.Func<UnityEngine.TerrainTools.PaintContext.ITerrainInfo, UnityEngine.Texture> terrainToTexture, UnityEngine.Color defaultColor, string operationName, UnityEngine.Material blitMaterial = null, int blitPass = 0, System.Action<UnityEngine.TerrainTools.PaintContext.ITerrainInfo> beforeBlit = null, System.Action<UnityEngine.TerrainTools.PaintContext.ITerrainInfo> afterBlit = null)
- public void GatherNormals()
- public UnityEngine.RectInt GetClippedPixelRectInRenderTexturePixels(int terrainIndex)
- public UnityEngine.RectInt GetClippedPixelRectInTerrainPixels(int terrainIndex)
- public UnityEngine.Terrain GetTerrain(int terrainIndex)
- private UnityEngine.TerrainTools.PaintContext.SplatmapUserData GetTerrainLayerUserData(UnityEngine.TerrainTools.PaintContext.ITerrainInfo context, UnityEngine.TerrainLayer terrainLayer = null, bool addLayerIfDoesntExist = false)
- private static void OnTerrainPainted(UnityEngine.TerrainTools.PaintContext.ITerrainInfo tile, UnityEngine.TerrainTools.PaintContext.ToolAction action)
- public void Scatter(System.Func<UnityEngine.TerrainTools.PaintContext.ITerrainInfo, UnityEngine.RenderTexture> terrainDest, UnityEngine.Material blitMaterial = null, int blitPass = 0, System.Action<UnityEngine.TerrainTools.PaintContext.ITerrainInfo> beforeBlit = null, System.Action<UnityEngine.TerrainTools.PaintContext.ITerrainInfo> afterBlit = null)
- public void ScatterAlphamap(string editorUndoName)
- public void ScatterHeightmap(string editorUndoName)
- public void ScatterHoles(string editorUndoName)
- private void ScatterInternal(System.Func<UnityEngine.TerrainTools.PaintContext.ITerrainInfo, UnityEngine.RenderTexture> terrainToRT, string operationName, UnityEngine.Material blitMaterial = null, int blitPass = 0, System.Action<UnityEngine.TerrainTools.PaintContext.ITerrainInfo> beforeBlit = null, System.Action<UnityEngine.TerrainTools.PaintContext.ITerrainInfo> afterBlit = null)

### private struct UnityEngine.TerrainTools.PaintContext.PaintedTerrain

#### Fields
- public UnityEngine.TerrainTools.PaintContext.ToolAction action
- public UnityEngine.Terrain terrain

### private class UnityEngine.TerrainTools.PaintContext.SplatmapUserData

#### Fields
- public int channelIndex
- public int mapIndex
- public UnityEngine.TerrainLayer terrainLayer
- public int terrainLayerIndex

#### Constructors
- public PaintContext.SplatmapUserData()

### public enum UnityEngine.TerrainTools.TerrainBuiltinPaintMaterialPasses
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- PaintHoles = 5
- PaintTexture = 4
- RaiseLowerHeight = 0
- SetHeights = 2
- SmoothHeights = 3
- StampHeight = 1

### public static class UnityEngine.TerrainTools.TerrainPaintUtility

#### Fields
- private static UnityEngine.Material s_BlitMaterial
- private static UnityEngine.Material s_BuiltinPaintMaterial
- private static UnityEngine.Material s_CopyTerrainLayerMaterial
- private static UnityEngine.Material s_HeightBlitMaterial

#### Properties
- internal static bool paintTextureUsesCopyTexture { get; }

#### Methods
- internal static int AddTerrainLayer(UnityEngine.Terrain terrain, UnityEngine.TerrainLayer inputLayer)
- public static UnityEngine.TerrainTools.PaintContext BeginPaintHeightmap(UnityEngine.Terrain terrain, UnityEngine.Rect boundsInTerrainSpace, int extraBorderPixels = 0, bool fillOutsideTerrain = true)
- public static UnityEngine.TerrainTools.PaintContext BeginPaintHoles(UnityEngine.Terrain terrain, UnityEngine.Rect boundsInTerrainSpace, int extraBorderPixels = 0, bool fillOutsideTerrain = true)
- public static UnityEngine.TerrainTools.PaintContext BeginPaintTexture(UnityEngine.Terrain terrain, UnityEngine.Rect boundsInTerrainSpace, UnityEngine.TerrainLayer inputLayer, int extraBorderPixels = 0, bool fillOutsideTerrain = true)
- public static void BuildTransformPaintContextUVToPaintContextUV(UnityEngine.TerrainTools.PaintContext src, UnityEngine.TerrainTools.PaintContext dst, out UnityEngine.Vector4 scaleOffset)
- internal static UnityEngine.RectInt CalcPixelRectFromBounds(UnityEngine.Terrain terrain, UnityEngine.Rect boundsInTerrainSpace, int textureWidth, int textureHeight, int extraBorderPixels, bool sharedBoundaryTexel)
- public static UnityEngine.TerrainTools.BrushTransform CalculateBrushTransform(UnityEngine.Terrain terrain, UnityEngine.Vector2 brushCenterTerrainUV, float brushSize, float brushRotationDegrees)
- public static UnityEngine.TerrainTools.PaintContext CollectNormals(UnityEngine.Terrain terrain, UnityEngine.Rect boundsInTerrainSpace, int extraBorderPixels = 0, bool fillOutsideTerrain = true)
- internal static void DrawQuad(UnityEngine.RectInt destinationPixels, UnityEngine.RectInt sourcePixels, UnityEngine.Texture sourceTexture)
- internal static void DrawQuad2(UnityEngine.RectInt destinationPixels, UnityEngine.RectInt sourcePixels, UnityEngine.Texture sourceTexture, UnityEngine.RectInt sourcePixels2, UnityEngine.Texture sourceTexture2)
- internal static void DrawQuadPadded(UnityEngine.RectInt destinationPixels, UnityEngine.RectInt destinationPixelsPadded, UnityEngine.RectInt sourcePixels, UnityEngine.RectInt sourcePixelsPadded, UnityEngine.Texture sourceTexture)
- public static void EndPaintHeightmap(UnityEngine.TerrainTools.PaintContext ctx, string editorUndoName)
- public static void EndPaintHoles(UnityEngine.TerrainTools.PaintContext ctx, string editorUndoName)
- public static void EndPaintTexture(UnityEngine.TerrainTools.PaintContext ctx, string editorUndoName)
- public static int FindTerrainLayerIndex(UnityEngine.Terrain terrain, UnityEngine.TerrainLayer inputLayer)
- public static UnityEngine.Material GetBlitMaterial()
- public static void GetBrushWorldSizeLimits(out float minBrushWorldSize, out float maxBrushWorldSize, float terrainTileWorldSize, int terrainTileTextureResolutionPixels, int minBrushResolutionPixels = 1, int maxBrushResolutionPixels = 8192)
- public static UnityEngine.Material GetBuiltinPaintMaterial()
- public static UnityEngine.Material GetCopyTerrainLayerMaterial()
- public static UnityEngine.Material GetHeightBlitMaterial()
- public static UnityEngine.Texture2D GetTerrainAlphaMapChecked(UnityEngine.Terrain terrain, int mapIndex)
- internal static UnityEngine.TerrainTools.PaintContext InitializePaintContext(UnityEngine.Terrain terrain, int targetWidth, int targetHeight, UnityEngine.RenderTextureFormat pcFormat, UnityEngine.Rect boundsInTerrainSpace, int extraBorderPixels = 0, bool sharedBoundaryTexel = true, bool fillOutsideTerrain = true)
- public static void ReleaseContextResources(UnityEngine.TerrainTools.PaintContext ctx)
- public static void SetupTerrainToolMaterialProperties(UnityEngine.TerrainTools.PaintContext paintContext, in UnityEngine.TerrainTools.BrushTransform brushXform, UnityEngine.Material material)

### private class UnityEngine.TerrainTools.PaintContext.TerrainTile
- Interfaces: UnityEngine.TerrainTools.PaintContext.ITerrainInfo

#### Fields
- public UnityEngine.RectInt clippedPCPixels
- public UnityEngine.RectInt clippedTerrainPixels
- public bool gatherEnable
- public UnityEngine.RectInt paddedPCPixels
- public UnityEngine.RectInt paddedTerrainPixels
- public bool scatterEnable
- public UnityEngine.Terrain terrain
- public UnityEngine.Vector2Int tileOriginPixels
- public object userData

#### Properties
- private UnityEngine.RectInt UnityEngine.TerrainTools.PaintContext.ITerrainInfo.clippedPCPixels { get; }
- private UnityEngine.RectInt UnityEngine.TerrainTools.PaintContext.ITerrainInfo.clippedTerrainPixels { get; }
- private bool UnityEngine.TerrainTools.PaintContext.ITerrainInfo.gatherEnable { get; set; }
- private UnityEngine.RectInt UnityEngine.TerrainTools.PaintContext.ITerrainInfo.paddedPCPixels { get; }
- private UnityEngine.RectInt UnityEngine.TerrainTools.PaintContext.ITerrainInfo.paddedTerrainPixels { get; }
- private bool UnityEngine.TerrainTools.PaintContext.ITerrainInfo.scatterEnable { get; set; }
- private UnityEngine.Terrain UnityEngine.TerrainTools.PaintContext.ITerrainInfo.terrain { get; }
- private object UnityEngine.TerrainTools.PaintContext.ITerrainInfo.userData { get; set; }

#### Constructors
- public PaintContext.TerrainTile()

#### Methods
- public static UnityEngine.TerrainTools.PaintContext.TerrainTile Make(UnityEngine.Terrain terrain, int tileOriginPixelsX, int tileOriginPixelsY, UnityEngine.RectInt pixelRect, int targetTextureWidth, int targetTextureHeight, int edgePad = 0)

### internal enum UnityEngine.TerrainTools.PaintContext.ToolAction
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AddTerrainLayer = 8
- None = 0
- PaintHeightmap = 1
- PaintHoles = 4
- PaintTexture = 2

## Namespace: UnityEngine.TerrainUtils

### private class UnityEngine.TerrainUtils.TerrainUtility.<>c__DisplayClass2_0

#### Fields
- public bool onlyAutoConnectedTerrains

#### Constructors
- public TerrainUtility.<>c__DisplayClass2_0()

### private class UnityEngine.TerrainUtils.TerrainUtility.<>c__DisplayClass2_1

#### Fields
- public UnityEngine.TerrainUtils.TerrainUtility.<>c__DisplayClass2_0 CS$<>8__locals1
- public UnityEngine.Terrain t

#### Constructors
- public TerrainUtility.<>c__DisplayClass2_1()

#### Methods
- internal bool <CollectTerrains>b__0(UnityEngine.Terrain x)

### private class UnityEngine.TerrainUtils.TerrainMap.<>c__DisplayClass3_0

#### Fields
- public int groupID

#### Constructors
- public TerrainMap.<>c__DisplayClass3_0()

#### Methods
- internal bool <CreateFromPlacement>b__0(UnityEngine.Terrain x)

### private struct UnityEngine.TerrainUtils.TerrainMap.QueueElement

#### Fields
- public readonly UnityEngine.Terrain terrain
- public readonly int tileX
- public readonly int tileZ

#### Constructors
- public TerrainMap.QueueElement(int tileX, int tileZ, UnityEngine.Terrain terrain)

### public class UnityEngine.TerrainUtils.TerrainMap

#### Fields
- private UnityEngine.TerrainUtils.TerrainMapStatusCode m_errorCode
- private UnityEngine.Vector3 m_patchSize
- private System.Collections.Generic.Dictionary<UnityEngine.TerrainUtils.TerrainTileCoord, UnityEngine.Terrain> m_terrainTiles

#### Properties
- public System.Collections.Generic.Dictionary<UnityEngine.TerrainUtils.TerrainTileCoord, UnityEngine.Terrain> terrainTiles { get; }

#### Constructors
- public TerrainMap()

#### Methods
- private void AddTerrainInternal(int x, int z, UnityEngine.Terrain terrain)
- public static UnityEngine.TerrainUtils.TerrainMap CreateFromConnectedNeighbors(UnityEngine.Terrain originTerrain, System.Predicate<UnityEngine.Terrain> filter = null, bool fullValidation = true)
- public static UnityEngine.TerrainUtils.TerrainMap CreateFromPlacement(UnityEngine.Terrain originTerrain, System.Predicate<UnityEngine.Terrain> filter = null, bool fullValidation = true)
- public static UnityEngine.TerrainUtils.TerrainMap CreateFromPlacement(UnityEngine.Vector2 gridOrigin, UnityEngine.Vector2 gridSize, System.Predicate<UnityEngine.Terrain> filter = null, bool fullValidation = true)
- public UnityEngine.Terrain GetTerrain(int tileX, int tileZ)
- private bool TryToAddTerrain(int tileX, int tileZ, UnityEngine.Terrain terrain)
- private UnityEngine.TerrainUtils.TerrainMapStatusCode Validate()
- private void ValidateTerrain(int tileX, int tileZ)

### internal enum UnityEngine.TerrainUtils.TerrainMapStatusCode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- EdgeAlignmentMismatch = 8
- OK = 0
- Overlapping = 1
- SizeMismatch = 4

### public struct UnityEngine.TerrainUtils.TerrainTileCoord

#### Fields
- public readonly int tileX
- public readonly int tileZ

#### Constructors
- public TerrainTileCoord(int tileX, int tileZ)

### public static class UnityEngine.TerrainUtils.TerrainUtility

#### Methods
- public static void AutoConnect()
- internal static void ClearConnectivity()
- internal static System.Collections.Generic.Dictionary<int, UnityEngine.TerrainUtils.TerrainMap> CollectTerrains(bool onlyAutoConnectedTerrains = true)
- internal static bool ValidTerrainsExist()

