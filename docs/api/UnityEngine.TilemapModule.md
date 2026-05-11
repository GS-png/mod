# Assembly: UnityEngine.TilemapModule
- Path: tools/WorldBox.Managed/UnityEngine.TilemapModule.dll
- Types: 24

## Namespace: UnityEngine

### public class UnityEngine.CustomGridBrushAttribute
- Base: System.Attribute

#### Fields
- private bool m_DefaultBrush
- private string m_DefaultName
- private bool m_HideAssetInstances
- private bool m_HideDefaultInstance

#### Properties
- public bool defaultBrush { get; }
- public string defaultName { get; }
- public bool hideAssetInstances { get; }
- public bool hideDefaultInstance { get; }

#### Constructors
- public CustomGridBrushAttribute()
- public CustomGridBrushAttribute(bool hideAssetInstances, bool hideDefaultInstance, bool defaultBrush, string defaultName)

### public enum UnityEngine.GridBrushBase.FlipAxis
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- X = 0
- Y = 1

### public class UnityEngine.GridBrushBase
- Base: UnityEngine.ScriptableObject

#### Constructors
- protected GridBrushBase()

#### Methods
- public virtual void BoxErase(UnityEngine.GridLayout gridLayout, UnityEngine.GameObject brushTarget, UnityEngine.BoundsInt position)
- public virtual void BoxFill(UnityEngine.GridLayout gridLayout, UnityEngine.GameObject brushTarget, UnityEngine.BoundsInt position)
- public virtual void ChangeZPosition(int change)
- public virtual void Erase(UnityEngine.GridLayout gridLayout, UnityEngine.GameObject brushTarget, UnityEngine.Vector3Int position)
- public virtual void Flip(UnityEngine.GridBrushBase.FlipAxis flip, UnityEngine.GridLayout.CellLayout layout)
- public virtual void FloodFill(UnityEngine.GridLayout gridLayout, UnityEngine.GameObject brushTarget, UnityEngine.Vector3Int position)
- public virtual void Move(UnityEngine.GridLayout gridLayout, UnityEngine.GameObject brushTarget, UnityEngine.BoundsInt from, UnityEngine.BoundsInt to)
- public virtual void MoveEnd(UnityEngine.GridLayout gridLayout, UnityEngine.GameObject brushTarget, UnityEngine.BoundsInt position)
- public virtual void MoveStart(UnityEngine.GridLayout gridLayout, UnityEngine.GameObject brushTarget, UnityEngine.BoundsInt position)
- public virtual void Paint(UnityEngine.GridLayout gridLayout, UnityEngine.GameObject brushTarget, UnityEngine.Vector3Int position)
- public virtual void Pick(UnityEngine.GridLayout gridLayout, UnityEngine.GameObject brushTarget, UnityEngine.BoundsInt position, UnityEngine.Vector3Int pivot)
- public virtual void ResetZPosition()
- public virtual void Rotate(UnityEngine.GridBrushBase.RotationDirection direction, UnityEngine.GridLayout.CellLayout layout)
- public virtual void Select(UnityEngine.GridLayout gridLayout, UnityEngine.GameObject brushTarget, UnityEngine.BoundsInt position)

### public enum UnityEngine.GridBrushBase.RotationDirection
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Clockwise = 0
- CounterClockwise = 1

### public enum UnityEngine.GridBrushBase.Tool
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Box = 3
- Erase = 5
- FloodFill = 6
- Move = 1
- Other = 7
- Paint = 2
- Pick = 4
- Select = 0

## Namespace: UnityEngine.Tilemaps

### public enum UnityEngine.Tilemaps.Tile.ColliderType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Grid = 2
- None = 0
- Sprite = 1

### public enum UnityEngine.Tilemaps.TilemapRenderer.DetectChunkCullingBounds
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Auto = 0
- Manual = 1

### public class UnityEngine.Tilemaps.ITilemap

#### Fields
- internal bool m_AddToList
- internal int m_RefreshCount
- internal Unity.Collections.NativeArray<UnityEngine.Vector3Int> m_RefreshPos
- internal UnityEngine.Tilemaps.Tilemap m_Tilemap
- internal static UnityEngine.Tilemaps.ITilemap s_Instance

#### Properties
- public UnityEngine.BoundsInt cellBounds { get; }
- public UnityEngine.Bounds localBounds { get; }
- public UnityEngine.Vector3Int origin { get; }
- public UnityEngine.Vector3Int size { get; }

#### Constructors
- internal ITilemap()
- public ITilemap(UnityEngine.Tilemaps.Tilemap tilemap)

#### Methods
- private static UnityEngine.Tilemaps.ITilemap CreateInstance()
- private static void FindAllRefreshPositions(UnityEngine.Tilemaps.ITilemap tilemap, int count, System.IntPtr oldTilesIntPtr, System.IntPtr newTilesIntPtr, System.IntPtr positionsIntPtr)
- private static void GetAllTileData(UnityEngine.Tilemaps.ITilemap tilemap, int count, System.IntPtr tilesIntPtr, System.IntPtr positionsIntPtr, System.IntPtr outTileDataIntPtr)
- public virtual UnityEngine.Color GetColor(UnityEngine.Vector3Int position)
- public T GetComponent<T>()
- public virtual UnityEngine.Sprite GetSprite(UnityEngine.Vector3Int position)
- public virtual UnityEngine.Tilemaps.TileBase GetTile(UnityEngine.Vector3Int position)
- public virtual T GetTile<T>(UnityEngine.Vector3Int position)
- public virtual UnityEngine.Tilemaps.TileFlags GetTileFlags(UnityEngine.Vector3Int position)
- public virtual UnityEngine.Matrix4x4 GetTransformMatrix(UnityEngine.Vector3Int position)
- public static UnityEngine.Tilemaps.ITilemap op_Implicit(UnityEngine.Tilemaps.Tilemap tilemap)
- public void RefreshTile(UnityEngine.Vector3Int position)
- internal void SetTilemapInstance(UnityEngine.Tilemaps.Tilemap tilemap)

### public enum UnityEngine.Tilemaps.TilemapRenderer.Mode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Chunk = 0
- Individual = 1

### public enum UnityEngine.Tilemaps.Tilemap.Orientation
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Custom = 6
- XY = 0
- XZ = 1
- YX = 2
- YZ = 3
- ZX = 4
- ZY = 5

### public enum UnityEngine.Tilemaps.TilemapRenderer.SortOrder
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BottomLeft = 0
- BottomRight = 1
- TopLeft = 2
- TopRight = 3

### public struct UnityEngine.Tilemaps.Tilemap.SyncTile

#### Fields
- internal UnityEngine.Vector3Int m_Position
- internal UnityEngine.Tilemaps.TileBase m_Tile
- internal UnityEngine.Tilemaps.TileData m_TileData

#### Properties
- public UnityEngine.Vector3Int position { get; }
- public UnityEngine.Tilemaps.TileBase tile { get; }
- public UnityEngine.Tilemaps.TileData tileData { get; }

### internal struct UnityEngine.Tilemaps.Tilemap.SyncTileCallbackSettings

#### Fields
- internal bool hasPositionsChangedCallback
- internal bool hasSyncTileCallback
- internal bool isBufferSyncTile

### public class UnityEngine.Tilemaps.Tile
- Base: UnityEngine.Tilemaps.TileBase

#### Fields
- private UnityEngine.Tilemaps.Tile.ColliderType m_ColliderType
- private UnityEngine.Color m_Color
- private UnityEngine.Tilemaps.TileFlags m_Flags
- private UnityEngine.GameObject m_InstancedGameObject
- private UnityEngine.Sprite m_Sprite
- private UnityEngine.Matrix4x4 m_Transform

#### Properties
- public UnityEngine.Tilemaps.Tile.ColliderType colliderType { get; set; }
- public UnityEngine.Color color { get; set; }
- public UnityEngine.Tilemaps.TileFlags flags { get; set; }
- public UnityEngine.GameObject gameObject { get; set; }
- public UnityEngine.Sprite sprite { get; set; }
- public UnityEngine.Matrix4x4 transform { get; set; }

#### Constructors
- public Tile()

#### Methods
- public override void GetTileData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileData tileData)

### public struct UnityEngine.Tilemaps.TileAnimationData

#### Fields
- private UnityEngine.Sprite[] m_AnimatedSprites
- private float m_AnimationSpeed
- private float m_AnimationStartTime
- private UnityEngine.Tilemaps.TileAnimationFlags m_Flags

#### Properties
- public UnityEngine.Sprite[] animatedSprites { get; set; }
- public float animationSpeed { get; set; }
- public float animationStartTime { get; set; }
- public UnityEngine.Tilemaps.TileAnimationFlags flags { get; set; }

### public enum UnityEngine.Tilemaps.TileAnimationFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- LoopOnce = 1
- None = 0
- PauseAnimation = 2
- UpdatePhysics = 4

### public class UnityEngine.Tilemaps.TileBase
- Base: UnityEngine.ScriptableObject

#### Constructors
- protected TileBase()

#### Methods
- public virtual bool GetTileAnimationData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileAnimationData tileAnimationData)
- private UnityEngine.Tilemaps.TileAnimationData GetTileAnimationDataNoRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap)
- private void GetTileAnimationDataRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileAnimationData tileAnimationData, ref bool hasAnimation)
- public virtual void GetTileData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, ref UnityEngine.Tilemaps.TileData tileData)
- private UnityEngine.Tilemaps.TileData GetTileDataNoRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap)
- public virtual void RefreshTile(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap)
- public virtual bool StartUp(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.GameObject go)
- private void StartUpRef(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.ITilemap tilemap, UnityEngine.GameObject go, ref bool startUpInvokedByUser)

### public struct UnityEngine.Tilemaps.TileChangeData

#### Fields
- private UnityEngine.Color m_Color
- private UnityEngine.Vector3Int m_Position
- private UnityEngine.Object m_TileAsset
- private UnityEngine.Matrix4x4 m_Transform

#### Properties
- public UnityEngine.Color color { get; set; }
- public UnityEngine.Vector3Int position { get; set; }
- public UnityEngine.Tilemaps.TileBase tile { get; set; }
- public UnityEngine.Matrix4x4 transform { get; set; }

#### Constructors
- public TileChangeData(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileBase tile, UnityEngine.Color color, UnityEngine.Matrix4x4 transform)

### public struct UnityEngine.Tilemaps.TileData

#### Fields
- internal static readonly UnityEngine.Tilemaps.TileData Default
- private UnityEngine.Tilemaps.Tile.ColliderType m_ColliderType
- private UnityEngine.Color m_Color
- private UnityEngine.Tilemaps.TileFlags m_Flags
- private int m_GameObject
- private int m_Sprite
- private UnityEngine.Matrix4x4 m_Transform

#### Properties
- public UnityEngine.Tilemaps.Tile.ColliderType colliderType { get; set; }
- public UnityEngine.Color color { get; set; }
- public UnityEngine.Tilemaps.TileFlags flags { get; set; }
- public UnityEngine.GameObject gameObject { get; set; }
- public UnityEngine.Sprite sprite { get; set; }
- public UnityEngine.Matrix4x4 transform { get; set; }

#### Constructors
- private static TileData()

#### Methods
- private static UnityEngine.Tilemaps.TileData CreateDefault()

### internal struct UnityEngine.Tilemaps.TileDataNative

#### Fields
- private UnityEngine.Tilemaps.Tile.ColliderType m_ColliderType
- private UnityEngine.Color m_Color
- private UnityEngine.Tilemaps.TileFlags m_Flags
- private int m_GameObject
- private int m_Sprite
- private UnityEngine.Matrix4x4 m_Transform

#### Properties
- public UnityEngine.Tilemaps.Tile.ColliderType colliderType { get; set; }
- public UnityEngine.Color color { get; set; }
- public UnityEngine.Tilemaps.TileFlags flags { get; set; }
- public int gameObject { get; set; }
- public int sprite { get; set; }
- public UnityEngine.Matrix4x4 transform { get; set; }

#### Methods
- public static UnityEngine.Tilemaps.TileDataNative op_Implicit(UnityEngine.Tilemaps.TileData td)

### public enum UnityEngine.Tilemaps.TileFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- InstantiateGameObjectRuntimeOnly = 4
- KeepGameObjectRuntimeOnly = 8
- LockAll = 3
- LockColor = 1
- LockTransform = 2
- None = 0

### public class UnityEngine.Tilemaps.Tilemap
- Base: UnityEngine.GridLayout

#### Fields
- private bool m_BufferSyncTile
- private static System.Action<UnityEngine.Tilemaps.Tilemap, Unity.Collections.NativeArray<UnityEngine.Vector3Int>> tilemapPositionsChanged
- private static System.Action<UnityEngine.Tilemaps.Tilemap, UnityEngine.Tilemaps.Tilemap.SyncTile[]> tilemapTileChanged

#### Properties
- public float animationFrameRate { get; set; }
- internal bool bufferSyncTile { get; set; }
- public UnityEngine.BoundsInt cellBounds { get; }
- public UnityEngine.Color color { get; set; }
- public UnityEngine.Grid layoutGrid { get; }
- public UnityEngine.Bounds localBounds { get; }
- internal UnityEngine.Bounds localFrameBounds { get; }
- public UnityEngine.Tilemaps.Tilemap.Orientation orientation { get; set; }
- public UnityEngine.Matrix4x4 orientationMatrix { get; set; }
- public UnityEngine.Vector3Int origin { get; set; }
- public UnityEngine.Vector3Int size { get; set; }
- public UnityEngine.Vector3 tileAnchor { get; set; }

#### Events
- public static event System.Action<UnityEngine.Tilemaps.Tilemap, Unity.Collections.NativeArray<UnityEngine.Vector3Int>> tilemapPositionsChanged
- public static event System.Action<UnityEngine.Tilemaps.Tilemap, UnityEngine.Tilemaps.Tilemap.SyncTile[]> tilemapTileChanged

#### Constructors
- public Tilemap()

#### Methods
- public void AddTileAnimationFlags(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileAnimationFlags flags)
- private void AddTileAnimationFlags_Injected(ref UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileAnimationFlags flags)
- public void AddTileFlags(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileFlags flags)
- private void AddTileFlags_Injected(ref UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileFlags flags)
- public void BoxFill(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileBase tile, int startX, int startY, int endX, int endY)
- private void BoxFillTileAsset(UnityEngine.Vector3Int position, UnityEngine.Object tile, int startX, int startY, int endX, int endY)
- private void BoxFillTileAsset_Injected(ref UnityEngine.Vector3Int position, UnityEngine.Object tile, int startX, int startY, int endX, int endY)
- public void ClearAllTiles()
- public void CompressBounds()
- public bool ContainsTile(UnityEngine.Tilemaps.TileBase tileAsset)
- internal bool ContainsTileAsset(UnityEngine.Object tileAsset)
- public void DeleteCells(UnityEngine.Vector3Int position, UnityEngine.Vector3Int deleteCells)
- public void DeleteCells(UnityEngine.Vector3Int position, int numColumns, int numRows, int numLayers)
- private void DeleteCells_Injected(ref UnityEngine.Vector3Int position, int numColumns, int numRows, int numLayers)
- private void DoPositionsChangedCallback(int count, System.IntPtr positionsIntPtr)
- private void DoSyncTileCallback(UnityEngine.Tilemaps.Tilemap.SyncTile[] syncTiles)
- public void FloodFill(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileBase tile)
- private void FloodFillTileAsset(UnityEngine.Vector3Int position, UnityEngine.Object tile)
- private void FloodFillTileAsset_Injected(ref UnityEngine.Vector3Int position, UnityEngine.Object tile)
- public int GetAnimationFrame(UnityEngine.Vector3Int position)
- public int GetAnimationFrameCount(UnityEngine.Vector3Int position)
- private int GetAnimationFrameCount_Injected(ref UnityEngine.Vector3Int position)
- private int GetAnimationFrame_Injected(ref UnityEngine.Vector3Int position)
- public float GetAnimationTime(UnityEngine.Vector3Int position)
- private float GetAnimationTime_Injected(ref UnityEngine.Vector3Int position)
- public UnityEngine.Vector3 GetCellCenterLocal(UnityEngine.Vector3Int position)
- public UnityEngine.Vector3 GetCellCenterWorld(UnityEngine.Vector3Int position)
- public UnityEngine.Tilemaps.Tile.ColliderType GetColliderType(UnityEngine.Vector3Int position)
- private UnityEngine.Tilemaps.Tile.ColliderType GetColliderType_Injected(ref UnityEngine.Vector3Int position)
- public UnityEngine.Color GetColor(UnityEngine.Vector3Int position)
- private void GetColor_Injected(ref UnityEngine.Vector3Int position, out UnityEngine.Color ret)
- public UnityEngine.GameObject GetInstantiatedObject(UnityEngine.Vector3Int position)
- private UnityEngine.GameObject GetInstantiatedObject_Injected(ref UnityEngine.Vector3Int position)
- public UnityEngine.GameObject GetObjectToInstantiate(UnityEngine.Vector3Int position)
- private UnityEngine.GameObject GetObjectToInstantiate_Injected(ref UnityEngine.Vector3Int position)
- public UnityEngine.Sprite GetSprite(UnityEngine.Vector3Int position)
- private UnityEngine.Sprite GetSprite_Injected(ref UnityEngine.Vector3Int position)
- internal void GetSyncTileCallbackSettings(ref UnityEngine.Tilemaps.Tilemap.SyncTileCallbackSettings settings)
- public UnityEngine.Tilemaps.TileBase GetTile(UnityEngine.Vector3Int position)
- public T GetTile<T>(UnityEngine.Vector3Int position)
- public UnityEngine.Tilemaps.TileAnimationFlags GetTileAnimationFlags(UnityEngine.Vector3Int position)
- private UnityEngine.Tilemaps.TileAnimationFlags GetTileAnimationFlags_Injected(ref UnityEngine.Vector3Int position)
- internal UnityEngine.Object GetTileAsset(UnityEngine.Vector3Int position)
- internal UnityEngine.Object[] GetTileAssetsBlock(UnityEngine.Vector3Int position, UnityEngine.Vector3Int blockDimensions)
- internal int GetTileAssetsBlockNonAlloc(UnityEngine.Vector3Int startPosition, UnityEngine.Vector3Int endPosition, UnityEngine.Object[] tiles)
- private int GetTileAssetsBlockNonAlloc_Injected(ref UnityEngine.Vector3Int startPosition, ref UnityEngine.Vector3Int endPosition, UnityEngine.Object[] tiles)
- private UnityEngine.Object[] GetTileAssetsBlock_Injected(ref UnityEngine.Vector3Int position, ref UnityEngine.Vector3Int blockDimensions)
- internal int GetTileAssetsRangeNonAlloc(UnityEngine.Vector3Int startPosition, UnityEngine.Vector3Int endPosition, UnityEngine.Vector3Int[] positions, UnityEngine.Object[] tiles)
- private int GetTileAssetsRangeNonAlloc_Injected(ref UnityEngine.Vector3Int startPosition, ref UnityEngine.Vector3Int endPosition, UnityEngine.Vector3Int[] positions, UnityEngine.Object[] tiles)
- private UnityEngine.Object GetTileAsset_Injected(ref UnityEngine.Vector3Int position)
- public UnityEngine.Tilemaps.TileFlags GetTileFlags(UnityEngine.Vector3Int position)
- private UnityEngine.Tilemaps.TileFlags GetTileFlags_Injected(ref UnityEngine.Vector3Int position)
- public UnityEngine.Tilemaps.TileBase[] GetTilesBlock(UnityEngine.BoundsInt bounds)
- public int GetTilesBlockNonAlloc(UnityEngine.BoundsInt bounds, UnityEngine.Tilemaps.TileBase[] tiles)
- public int GetTilesRangeCount(UnityEngine.Vector3Int startPosition, UnityEngine.Vector3Int endPosition)
- private int GetTilesRangeCount_Injected(ref UnityEngine.Vector3Int startPosition, ref UnityEngine.Vector3Int endPosition)
- public int GetTilesRangeNonAlloc(UnityEngine.Vector3Int startPosition, UnityEngine.Vector3Int endPosition, UnityEngine.Vector3Int[] positions, UnityEngine.Tilemaps.TileBase[] tiles)
- public UnityEngine.Matrix4x4 GetTransformMatrix(UnityEngine.Vector3Int position)
- private void GetTransformMatrix_Injected(ref UnityEngine.Vector3Int position, out UnityEngine.Matrix4x4 ret)
- public int GetUsedSpritesCount()
- public int GetUsedSpritesNonAlloc(UnityEngine.Sprite[] usedSprites)
- public int GetUsedTilesCount()
- public int GetUsedTilesNonAlloc(UnityEngine.Tilemaps.TileBase[] usedTiles)
- private void HandlePositionsChangedCallback(int count, System.IntPtr positionsIntPtr)
- private void HandleSyncTileCallback(UnityEngine.Tilemaps.Tilemap.SyncTile[] syncTiles)
- internal static bool HasPositionsChangedCallback()
- internal static bool HasSyncTileCallback()
- public bool HasTile(UnityEngine.Vector3Int position)
- public void InsertCells(UnityEngine.Vector3Int position, UnityEngine.Vector3Int insertCells)
- public void InsertCells(UnityEngine.Vector3Int position, int numColumns, int numRows, int numLayers)
- private void InsertCells_Injected(ref UnityEngine.Vector3Int position, int numColumns, int numRows, int numLayers)
- private void INTERNAL_CALL_SetTileAssetsBlock(UnityEngine.Vector3Int position, UnityEngine.Vector3Int blockDimensions, UnityEngine.Object[] tileArray)
- private void INTERNAL_CALL_SetTileAssetsBlock_Injected(ref UnityEngine.Vector3Int position, ref UnityEngine.Vector3Int blockDimensions, UnityEngine.Object[] tileArray)
- internal int Internal_GetUsedSpritesNonAlloc(UnityEngine.Object[] usedSprites)
- internal int Internal_GetUsedTilesNonAlloc(UnityEngine.Object[] usedTiles)
- public void RefreshAllTiles()
- public void RefreshTile(UnityEngine.Vector3Int position)
- internal void RefreshTilesNative(void* positions, int count)
- private void RefreshTile_Injected(ref UnityEngine.Vector3Int position)
- internal static void RemoveSyncTileCallback(System.Action<UnityEngine.Tilemaps.Tilemap, UnityEngine.Tilemaps.Tilemap.SyncTile[]> callback)
- public void RemoveTileAnimationFlags(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileAnimationFlags flags)
- private void RemoveTileAnimationFlags_Injected(ref UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileAnimationFlags flags)
- public void RemoveTileFlags(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileFlags flags)
- private void RemoveTileFlags_Injected(ref UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileFlags flags)
- public void ResizeBounds()
- internal void SendAndClearSyncTileBuffer()
- private void SendTilemapPositionsChangedCallback(Unity.Collections.NativeArray<UnityEngine.Vector3Int> positions)
- private void SendTilemapTileChangedCallback(UnityEngine.Tilemaps.Tilemap.SyncTile[] syncTiles)
- public void SetAnimationFrame(UnityEngine.Vector3Int position, int frame)
- private void SetAnimationFrame_Injected(ref UnityEngine.Vector3Int position, int frame)
- public void SetAnimationTime(UnityEngine.Vector3Int position, float time)
- private void SetAnimationTime_Injected(ref UnityEngine.Vector3Int position, float time)
- public void SetColliderType(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.Tile.ColliderType colliderType)
- private void SetColliderType_Injected(ref UnityEngine.Vector3Int position, UnityEngine.Tilemaps.Tile.ColliderType colliderType)
- public void SetColor(UnityEngine.Vector3Int position, UnityEngine.Color color)
- private void SetColor_Injected(ref UnityEngine.Vector3Int position, ref UnityEngine.Color color)
- internal static void SetSyncTileCallback(System.Action<UnityEngine.Tilemaps.Tilemap, UnityEngine.Tilemaps.Tilemap.SyncTile[]> callback)
- public void SetTile(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileBase tile)
- public void SetTile(UnityEngine.Tilemaps.TileChangeData tileChangeData, bool ignoreLockFlags)
- public void SetTileAnimationFlags(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileAnimationFlags flags)
- private void SetTileAnimationFlags_Injected(ref UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileAnimationFlags flags)
- internal void SetTileAsset(UnityEngine.Vector3Int position, UnityEngine.Object tile)
- internal void SetTileAssets(UnityEngine.Vector3Int[] positionArray, UnityEngine.Object[] tileArray)
- private void SetTileAsset_Injected(ref UnityEngine.Vector3Int position, UnityEngine.Object tile)
- public void SetTileFlags(UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileFlags flags)
- private void SetTileFlags_Injected(ref UnityEngine.Vector3Int position, UnityEngine.Tilemaps.TileFlags flags)
- public void SetTiles(UnityEngine.Vector3Int[] positionArray, UnityEngine.Tilemaps.TileBase[] tileArray)
- public void SetTiles(UnityEngine.Tilemaps.TileChangeData[] tileChangeDataArray, bool ignoreLockFlags)
- public void SetTilesBlock(UnityEngine.BoundsInt position, UnityEngine.Tilemaps.TileBase[] tileArray)
- private void SetTile_Injected(ref UnityEngine.Tilemaps.TileChangeData tileChangeData, bool ignoreLockFlags)
- public void SetTransformMatrix(UnityEngine.Vector3Int position, UnityEngine.Matrix4x4 transform)
- private void SetTransformMatrix_Injected(ref UnityEngine.Vector3Int position, ref UnityEngine.Matrix4x4 transform)
- public void SwapTile(UnityEngine.Tilemaps.TileBase changeTile, UnityEngine.Tilemaps.TileBase newTile)
- internal void SwapTileAsset(UnityEngine.Object changeTile, UnityEngine.Object newTile)

### public class UnityEngine.Tilemaps.TilemapCollider2D
- Base: UnityEngine.Collider2D

#### Properties
- public float extrusionFactor { get; set; }
- public bool hasTilemapChanges { get; }
- public uint maximumTileChangeCount { get; set; }
- public bool useDelaunayMesh { get; set; }

#### Constructors
- public TilemapCollider2D()

#### Methods
- public void ProcessTilemapChanges()

### public class UnityEngine.Tilemaps.TilemapRenderer
- Base: UnityEngine.Renderer

#### Properties
- public UnityEngine.Vector3 chunkCullingBounds { get; set; }
- public UnityEngine.Vector3Int chunkSize { get; set; }
- public UnityEngine.Tilemaps.TilemapRenderer.DetectChunkCullingBounds detectChunkCullingBounds { get; set; }
- public UnityEngine.SpriteMaskInteraction maskInteraction { get; set; }
- public int maxChunkCount { get; set; }
- public int maxFrameAge { get; set; }
- public UnityEngine.Tilemaps.TilemapRenderer.Mode mode { get; set; }
- public UnityEngine.Tilemaps.TilemapRenderer.SortOrder sortOrder { get; set; }

#### Constructors
- public TilemapRenderer()

#### Methods
- internal void OnSpriteAtlasRegistered(UnityEngine.U2D.SpriteAtlas atlas)
- internal void RegisterSpriteAtlasRegistered()
- internal void UnregisterSpriteAtlasRegistered()

