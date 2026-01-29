# Assembly: UnityEngine.SpriteShapeModule
- Path: tools/WorldBox.Managed/UnityEngine.SpriteShapeModule.dll
- Types: 8

## Namespace: UnityEngine.U2D

### public struct UnityEngine.U2D.AngleRangeInfo

#### Fields
- public float end
- public uint order
- public int[] sprites
- public float start

### public struct UnityEngine.U2D.ShapeControlPoint

#### Fields
- public UnityEngine.Vector3 leftTangent
- public int mode
- public UnityEngine.Vector3 position
- public UnityEngine.Vector3 rightTangent

### internal enum UnityEngine.U2D.SpriteShapeDataType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BoundingBox = 2
- ChannelColor = 7
- ChannelNormal = 5
- ChannelTangent = 6
- ChannelTexCoord0 = 4
- ChannelVertex = 3
- DataCount = 8
- Index = 0
- Segment = 1

### public struct UnityEngine.U2D.SpriteShapeMetaData

#### Fields
- public float bevelCutoff
- public float bevelSize
- public bool corner
- public float height
- public uint spriteIndex

### public struct UnityEngine.U2D.SpriteShapeParameters

#### Fields
- public bool adaptiveUV
- public float angleThreshold
- public float bevelCutoff
- public float bevelSize
- public float borderPivot
- public bool carpet
- public uint fillScale
- public UnityEngine.Texture2D fillTexture
- public bool smartSprite
- public uint splineDetail
- public bool spriteBorders
- public bool stretchUV
- public UnityEngine.Matrix4x4 transform

### public class UnityEngine.U2D.SpriteShapeRenderer
- Base: UnityEngine.Renderer

#### Properties
- public UnityEngine.Color color { get; set; }
- public UnityEngine.SpriteMaskInteraction maskInteraction { get; set; }

#### Constructors
- public SpriteShapeRenderer()

#### Methods
- public Unity.Collections.NativeArray<UnityEngine.Bounds> GetBounds()
- private Unity.Collections.NativeSlice<T> GetChannelDataArray<T>(UnityEngine.U2D.SpriteShapeDataType dataType, UnityEngine.Rendering.VertexAttribute channel)
- private UnityEngine.U2D.SpriteChannelInfo GetChannelInfo(UnityEngine.Rendering.VertexAttribute channel)
- private void GetChannelInfo_Injected(UnityEngine.Rendering.VertexAttribute channel, out UnityEngine.U2D.SpriteChannelInfo ret)
- public void GetChannels(int dataSize, out Unity.Collections.NativeArray<ushort> indices, out Unity.Collections.NativeSlice<UnityEngine.Vector3> vertices, out Unity.Collections.NativeSlice<UnityEngine.Vector2> texcoords)
- public void GetChannels(int dataSize, out Unity.Collections.NativeArray<ushort> indices, out Unity.Collections.NativeSlice<UnityEngine.Vector3> vertices, out Unity.Collections.NativeSlice<UnityEngine.Vector2> texcoords, out Unity.Collections.NativeSlice<UnityEngine.Color32> colors)
- public void GetChannels(int dataSize, out Unity.Collections.NativeArray<ushort> indices, out Unity.Collections.NativeSlice<UnityEngine.Vector3> vertices, out Unity.Collections.NativeSlice<UnityEngine.Vector2> texcoords, out Unity.Collections.NativeSlice<UnityEngine.Vector4> tangents)
- public void GetChannels(int dataSize, out Unity.Collections.NativeArray<ushort> indices, out Unity.Collections.NativeSlice<UnityEngine.Vector3> vertices, out Unity.Collections.NativeSlice<UnityEngine.Vector2> texcoords, out Unity.Collections.NativeSlice<UnityEngine.Color32> colors, out Unity.Collections.NativeSlice<UnityEngine.Vector4> tangents)
- public void GetChannels(int dataSize, out Unity.Collections.NativeArray<ushort> indices, out Unity.Collections.NativeSlice<UnityEngine.Vector3> vertices, out Unity.Collections.NativeSlice<UnityEngine.Vector2> texcoords, out Unity.Collections.NativeSlice<UnityEngine.Vector4> tangents, out Unity.Collections.NativeSlice<UnityEngine.Vector3> normals)
- public void GetChannels(int dataSize, out Unity.Collections.NativeArray<ushort> indices, out Unity.Collections.NativeSlice<UnityEngine.Vector3> vertices, out Unity.Collections.NativeSlice<UnityEngine.Vector2> texcoords, out Unity.Collections.NativeSlice<UnityEngine.Color32> colors, out Unity.Collections.NativeSlice<UnityEngine.Vector4> tangents, out Unity.Collections.NativeSlice<UnityEngine.Vector3> normals)
- private UnityEngine.U2D.SpriteChannelInfo GetDataInfo(UnityEngine.U2D.SpriteShapeDataType arrayType)
- private void GetDataInfo_Injected(UnityEngine.U2D.SpriteShapeDataType arrayType, out UnityEngine.U2D.SpriteChannelInfo ret)
- private Unity.Collections.NativeArray<T> GetNativeDataArray<T>(UnityEngine.U2D.SpriteShapeDataType dataType)
- public Unity.Collections.NativeArray<UnityEngine.U2D.SpriteShapeSegment> GetSegments(int dataSize)
- public void Prepare(Unity.Jobs.JobHandle handle, UnityEngine.U2D.SpriteShapeParameters shapeParams, UnityEngine.Sprite[] sprites)
- private void Prepare_Injected(ref Unity.Jobs.JobHandle handle, ref UnityEngine.U2D.SpriteShapeParameters shapeParams, UnityEngine.Sprite[] sprites)
- public void SetLocalAABB(UnityEngine.Bounds bounds)
- private void SetLocalAABB_Injected(ref UnityEngine.Bounds bounds)
- private void SetMeshChannelInfo(int vertexCount, int indexCount, int hotChannelMask)
- private void SetMeshDataCount(int vertexCount, int indexCount)
- private void SetSegmentCount(int geomCount)

### public struct UnityEngine.U2D.SpriteShapeSegment

#### Fields
- private int m_GeomIndex
- private int m_IndexCount
- private int m_SpriteIndex
- private int m_VertexCount

#### Properties
- public int geomIndex { get; set; }
- public int indexCount { get; set; }
- public int spriteIndex { get; set; }
- public int vertexCount { get; set; }

### public class UnityEngine.U2D.SpriteShapeUtility

#### Constructors
- public SpriteShapeUtility()

#### Methods
- public static int[] Generate(UnityEngine.Mesh mesh, UnityEngine.U2D.SpriteShapeParameters shapeParams, UnityEngine.U2D.ShapeControlPoint[] points, UnityEngine.U2D.SpriteShapeMetaData[] metaData, UnityEngine.U2D.AngleRangeInfo[] angleRange, UnityEngine.Sprite[] sprites, UnityEngine.Sprite[] corners)
- public static void GenerateSpriteShape(UnityEngine.U2D.SpriteShapeRenderer renderer, UnityEngine.U2D.SpriteShapeParameters shapeParams, UnityEngine.U2D.ShapeControlPoint[] points, UnityEngine.U2D.SpriteShapeMetaData[] metaData, UnityEngine.U2D.AngleRangeInfo[] angleRange, UnityEngine.Sprite[] sprites, UnityEngine.Sprite[] corners)
- private static void GenerateSpriteShape_Injected(UnityEngine.U2D.SpriteShapeRenderer renderer, ref UnityEngine.U2D.SpriteShapeParameters shapeParams, UnityEngine.U2D.ShapeControlPoint[] points, UnityEngine.U2D.SpriteShapeMetaData[] metaData, UnityEngine.U2D.AngleRangeInfo[] angleRange, UnityEngine.Sprite[] sprites, UnityEngine.Sprite[] corners)
- private static int[] Generate_Injected(UnityEngine.Mesh mesh, ref UnityEngine.U2D.SpriteShapeParameters shapeParams, UnityEngine.U2D.ShapeControlPoint[] points, UnityEngine.U2D.SpriteShapeMetaData[] metaData, UnityEngine.U2D.AngleRangeInfo[] angleRange, UnityEngine.Sprite[] sprites, UnityEngine.Sprite[] corners)

