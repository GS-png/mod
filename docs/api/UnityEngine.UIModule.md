# Assembly: UnityEngine.UIModule
- Path: tools/WorldBox.Managed/UnityEngine.UIModule.dll
- Types: 11

## Namespace: UnityEngine

### public enum UnityEngine.AdditionalCanvasShaderChannels
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- None = 0
- Normal = 8
- Tangent = 16
- TexCoord1 = 1
- TexCoord2 = 2
- TexCoord3 = 4

### public class UnityEngine.Canvas
- Base: UnityEngine.Behaviour

#### Fields
- private static System.Action<int> <externBeginRenderOverlays>k__BackingField
- private static System.Action<int> <externEndRenderOverlays>k__BackingField
- private static System.Action<int, int> <externRenderOverlaysBefore>k__BackingField
- private static UnityEngine.Canvas.WillRenderCanvases preWillRenderCanvases
- private static UnityEngine.Canvas.WillRenderCanvases willRenderCanvases

#### Properties
- public UnityEngine.AdditionalCanvasShaderChannels additionalShaderChannels { get; set; }
- public int cachedSortingLayerValue { get; }
- internal static System.Action<int> externBeginRenderOverlays { get; set; }
- internal static System.Action<int> externEndRenderOverlays { get; set; }
- internal static System.Action<int, int> externRenderOverlaysBefore { get; set; }
- public bool isRootCanvas { get; }
- public float normalizedSortingGridSize { get; set; }
- public bool overridePixelPerfect { get; set; }
- public bool overrideSorting { get; set; }
- public bool pixelPerfect { get; set; }
- public UnityEngine.Rect pixelRect { get; }
- public float planeDistance { get; set; }
- public float referencePixelsPerUnit { get; set; }
- public UnityEngine.Vector2 renderingDisplaySize { get; }
- public UnityEngine.RenderMode renderMode { get; set; }
- public int renderOrder { get; }
- public UnityEngine.Canvas rootCanvas { get; }
- public float scaleFactor { get; set; }
- public int sortingGridNormalizedSize { get; set; }
- public int sortingLayerID { get; set; }
- public string sortingLayerName { get; set; }
- public int sortingOrder { get; set; }
- public int targetDisplay { get; set; }
- public UnityEngine.StandaloneRenderResize updateRectTransformForStandalone { get; set; }
- public bool vertexColorAlwaysGammaSpace { get; set; }
- public UnityEngine.Camera worldCamera { get; set; }

#### Events
- public static event UnityEngine.Canvas.WillRenderCanvases preWillRenderCanvases
- public static event UnityEngine.Canvas.WillRenderCanvases willRenderCanvases

#### Constructors
- public Canvas()

#### Methods
- private static void BeginRenderExtraOverlays(int displayIndex)
- private static void EndRenderExtraOverlays(int displayIndex)
- public static void ForceUpdateCanvases()
- public static UnityEngine.Material GetDefaultCanvasMaterial()
- public static UnityEngine.Material GetDefaultCanvasTextMaterial()
- public static UnityEngine.Material GetETC1SupportedCanvasMaterial()
- private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder)
- private static void SendPreWillRenderCanvases()
- private static void SendWillRenderCanvases()
- internal static void SetExternalCanvasEnabled(bool enabled)
- internal void UpdateCanvasRectTransform(bool alignWithCamera)

### public class UnityEngine.CanvasGroup
- Base: UnityEngine.Behaviour
- Interfaces: UnityEngine.ICanvasRaycastFilter

#### Properties
- public float alpha { get; set; }
- public bool blocksRaycasts { get; set; }
- public bool ignoreParentGroups { get; set; }
- public bool interactable { get; set; }

#### Constructors
- public CanvasGroup()

#### Methods
- public bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)

### public class UnityEngine.CanvasRenderer
- Base: UnityEngine.Component

#### Fields
- private bool <isMask>k__BackingField

#### Properties
- public int absoluteDepth { get; }
- public UnityEngine.Vector2 clippingSoftness { get; set; }
- public bool cull { get; set; }
- public bool cullTransparentMesh { get; set; }
- public bool hasMoved { get; }
- public bool hasPopInstruction { get; set; }
- public bool hasRectClipping { get; }
- public bool isMask { get; set; }
- public int materialCount { get; set; }
- public int popMaterialCount { get; set; }
- public int relativeDepth { get; }

#### Constructors
- public CanvasRenderer()

#### Methods
- public static void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents)
- public static void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents)
- public void Clear()
- public static void CreateUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices)
- public static void CreateUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices)
- private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices)
- public void DisableRectClipping()
- public void EnableRectClipping(UnityEngine.Rect rect)
- private void EnableRectClipping_Injected(ref UnityEngine.Rect rect)
- public float GetAlpha()
- public UnityEngine.Color GetColor()
- private void GetColor_Injected(out UnityEngine.Color ret)
- public float GetInheritedAlpha()
- public UnityEngine.Material GetMaterial(int index)
- public UnityEngine.Material GetMaterial()
- public UnityEngine.Mesh GetMesh()
- public UnityEngine.Material GetPopMaterial(int index)
- public void SetAlpha(float alpha)
- public void SetAlphaTexture(UnityEngine.Texture texture)
- public void SetColor(UnityEngine.Color color)
- private void SetColor_Injected(ref UnityEngine.Color color)
- public void SetMaterial(UnityEngine.Material material, int index)
- public void SetMaterial(UnityEngine.Material material, UnityEngine.Texture texture)
- public void SetMesh(UnityEngine.Mesh mesh)
- public void SetPopMaterial(UnityEngine.Material material, int index)
- public void SetTexture(UnityEngine.Texture texture)
- public void SetVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices)
- public void SetVertices(UnityEngine.UIVertex[] vertices, int size)
- private static void SplitIndicesStreamsInternal(object verts, object indices)
- public static void SplitUIVertexStreams(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices)
- public static void SplitUIVertexStreams(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<int> indices)
- private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents)

### public interface UnityEngine.ICanvasRaycastFilter

#### Methods
- public bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)

### public class UnityEngine.RectTransformUtility

#### Fields
- private static readonly UnityEngine.Vector3[] s_Corners

#### Constructors
- private RectTransformUtility()
- private static RectTransformUtility()

#### Methods
- public static UnityEngine.Bounds CalculateRelativeRectTransformBounds(UnityEngine.Transform root, UnityEngine.Transform child)
- public static UnityEngine.Bounds CalculateRelativeRectTransformBounds(UnityEngine.Transform trans)
- public static void FlipLayoutAxes(UnityEngine.RectTransform rect, bool keepPositioning, bool recursive)
- public static void FlipLayoutOnAxis(UnityEngine.RectTransform rect, int axis, bool keepPositioning, bool recursive)
- private static UnityEngine.Vector2 GetTransposed(UnityEngine.Vector2 input)
- public static UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point, UnityEngine.Transform elementTransform, UnityEngine.Canvas canvas)
- private static void PixelAdjustPoint_Injected(ref UnityEngine.Vector2 point, UnityEngine.Transform elementTransform, UnityEngine.Canvas canvas, out UnityEngine.Vector2 ret)
- public static UnityEngine.Rect PixelAdjustRect(UnityEngine.RectTransform rectTransform, UnityEngine.Canvas canvas)
- private static void PixelAdjustRect_Injected(UnityEngine.RectTransform rectTransform, UnityEngine.Canvas canvas, out UnityEngine.Rect ret)
- private static bool PointInRectangle(UnityEngine.Vector2 screenPoint, UnityEngine.RectTransform rect, UnityEngine.Camera cam, UnityEngine.Vector4 offset)
- private static bool PointInRectangle_Injected(ref UnityEngine.Vector2 screenPoint, UnityEngine.RectTransform rect, UnityEngine.Camera cam, ref UnityEngine.Vector4 offset)
- public static bool RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint)
- public static bool RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam)
- public static bool RectangleContainsScreenPoint(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, UnityEngine.Vector4 offset)
- public static bool ScreenPointToLocalPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, out UnityEngine.Vector2 localPoint)
- public static UnityEngine.Ray ScreenPointToRay(UnityEngine.Camera cam, UnityEngine.Vector2 screenPos)
- public static bool ScreenPointToWorldPointInRectangle(UnityEngine.RectTransform rect, UnityEngine.Vector2 screenPoint, UnityEngine.Camera cam, out UnityEngine.Vector3 worldPoint)
- public static UnityEngine.Vector2 WorldToScreenPoint(UnityEngine.Camera cam, UnityEngine.Vector3 worldPoint)

### public enum UnityEngine.RenderMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ScreenSpaceCamera = 1
- ScreenSpaceOverlay = 0
- WorldSpace = 2

### public enum UnityEngine.UISystemProfilerApi.SampleType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Layout = 0
- Render = 1

### public enum UnityEngine.StandaloneRenderResize
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Disabled = 1
- Enabled = 0

### public static class UnityEngine.UISystemProfilerApi

#### Methods
- public static void AddMarker(string name, UnityEngine.Object obj)
- public static void BeginSample(UnityEngine.UISystemProfilerApi.SampleType type)
- public static void EndSample(UnityEngine.UISystemProfilerApi.SampleType type)

### public delegate UnityEngine.Canvas.WillRenderCanvases
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Canvas.WillRenderCanvases(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke()

