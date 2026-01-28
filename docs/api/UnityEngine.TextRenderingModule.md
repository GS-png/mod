# Assembly: UnityEngine.TextRenderingModule
- Path: EraWheel/lib/UnityEngine.TextRenderingModule.dll
- Types: 16

## Namespace: UnityEngine

### public struct UnityEngine.CharacterInfo

#### Fields
- public bool flipped
- public int index
- public int size
- public UnityEngine.FontStyle style
- public UnityEngine.Rect uv
- public UnityEngine.Rect vert
- public float width

#### Properties
- public int advance { get; set; }
- public int bearing { get; set; }
- public int glyphHeight { get; set; }
- public int glyphWidth { get; set; }
- public int maxX { get; set; }
- public int maxY { get; set; }
- public int minX { get; set; }
- public int minY { get; set; }
- public UnityEngine.Vector2 uvBottomLeft { get; set; }
- internal UnityEngine.Vector2 uvBottomLeftUnFlipped { get; set; }
- public UnityEngine.Vector2 uvBottomRight { get; set; }
- internal UnityEngine.Vector2 uvBottomRightUnFlipped { get; set; }
- public UnityEngine.Vector2 uvTopLeft { get; set; }
- internal UnityEngine.Vector2 uvTopLeftUnFlipped { get; set; }
- public UnityEngine.Vector2 uvTopRight { get; set; }
- internal UnityEngine.Vector2 uvTopRightUnFlipped { get; set; }

### public class UnityEngine.Font
- Base: UnityEngine.Object

#### Fields
- private UnityEngine.Font.FontTextureRebuildCallback m_FontTextureRebuildCallback
- private static System.Action<UnityEngine.Font> textureRebuilt

#### Properties
- public int ascent { get; }
- public UnityEngine.CharacterInfo[] characterInfo { get; set; }
- public bool dynamic { get; }
- public string[] fontNames { get; set; }
- public int fontSize { get; }
- public int lineHeight { get; }
- public UnityEngine.Material material { get; set; }
- public UnityEngine.Font.FontTextureRebuildCallback textureRebuildCallback { get; set; }

#### Events
- private event UnityEngine.Font.FontTextureRebuildCallback m_FontTextureRebuildCallback
- public static event System.Action<UnityEngine.Font> textureRebuilt

#### Constructors
- public Font()
- public Font(string name)
- private Font(string[] names, int size)

#### Methods
- public static UnityEngine.Font CreateDynamicFontFromOSFont(string fontname, int size)
- public static UnityEngine.Font CreateDynamicFontFromOSFont(string[] fontnames, int size)
- public bool GetCharacterInfo(char ch, out UnityEngine.CharacterInfo info, int size, UnityEngine.FontStyle style)
- public bool GetCharacterInfo(char ch, out UnityEngine.CharacterInfo info, int size)
- public bool GetCharacterInfo(char ch, out UnityEngine.CharacterInfo info)
- internal static UnityEngine.Font GetDefault()
- public static int GetMaxVertsForString(string str)
- public static string[] GetOSInstalledFontNames()
- public static string[] GetPathsToOSFonts()
- public bool HasCharacter(char c)
- private bool HasCharacter(int c)
- private static void Internal_CreateDynamicFont(UnityEngine.Font self, string[] _names, int size)
- private static void Internal_CreateFont(UnityEngine.Font self, string name)
- private static void Internal_CreateFontFromPath(UnityEngine.Font self, string fontPath)
- internal static void InvokeTextureRebuilt_Internal(UnityEngine.Font font)
- public void RequestCharactersInTexture(string characters, int size, UnityEngine.FontStyle style)
- public void RequestCharactersInTexture(string characters, int size)
- public void RequestCharactersInTexture(string characters)

### public enum UnityEngine.FontStyle
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Bold = 1
- BoldAndItalic = 3
- Italic = 2
- Normal = 0

### public delegate UnityEngine.Font.FontTextureRebuildCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Font.FontTextureRebuildCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke()

### public class UnityEngine.GUIText

#### Properties
- public UnityEngine.TextAlignment alignment { get; set; }
- public UnityEngine.TextAnchor anchor { get; set; }
- public UnityEngine.Color color { get; set; }
- public UnityEngine.Font font { get; set; }
- public int fontSize { get; set; }
- public UnityEngine.FontStyle fontStyle { get; set; }
- public float lineSpacing { get; set; }
- public UnityEngine.Material material { get; set; }
- public UnityEngine.Vector2 pixelOffset { get; set; }
- public bool richText { get; set; }
- public float tabSize { get; set; }
- public bool text { get; set; }

#### Constructors
- public GUIText()

#### Methods
- private static void FeatureRemoved()

### public enum UnityEngine.HorizontalWrapMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Overflow = 1
- Wrap = 0

### public enum UnityEngine.TextAlignment
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Center = 1
- Left = 0
- Right = 2

### public enum UnityEngine.TextAnchor
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- LowerCenter = 7
- LowerLeft = 6
- LowerRight = 8
- MiddleCenter = 4
- MiddleLeft = 3
- MiddleRight = 5
- UpperCenter = 1
- UpperLeft = 0
- UpperRight = 2

### internal enum UnityEngine.TextGenerationError
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CustomSizeOnNonDynamicFont = 1
- CustomStyleOnNonDynamicFont = 2
- NoFont = 4
- None = 0

### public struct UnityEngine.TextGenerationSettings

#### Fields
- public bool alignByGeometry
- public UnityEngine.Color color
- public UnityEngine.Font font
- public int fontSize
- public UnityEngine.FontStyle fontStyle
- public bool generateOutOfBounds
- public UnityEngine.Vector2 generationExtents
- public UnityEngine.HorizontalWrapMode horizontalOverflow
- public float lineSpacing
- public UnityEngine.Vector2 pivot
- public bool resizeTextForBestFit
- public int resizeTextMaxSize
- public int resizeTextMinSize
- public bool richText
- public float scaleFactor
- public UnityEngine.TextAnchor textAnchor
- public bool updateBounds
- public UnityEngine.VerticalWrapMode verticalOverflow

#### Methods
- private bool CompareColors(UnityEngine.Color left, UnityEngine.Color right)
- private bool CompareVector2(UnityEngine.Vector2 left, UnityEngine.Vector2 right)
- public bool Equals(UnityEngine.TextGenerationSettings other)

### public class UnityEngine.TextGenerator
- Interfaces: System.IDisposable

#### Fields
- private bool m_CachedCharacters
- private bool m_CachedLines
- private bool m_CachedVerts
- private readonly System.Collections.Generic.List<UnityEngine.UICharInfo> m_Characters
- private bool m_HasGenerated
- private UnityEngine.TextGenerationSettings m_LastSettings
- private string m_LastString
- private UnityEngine.TextGenerationError m_LastValid
- private readonly System.Collections.Generic.List<UnityEngine.UILineInfo> m_Lines
- internal System.IntPtr m_Ptr
- private readonly System.Collections.Generic.List<UnityEngine.UIVertex> m_Verts

#### Properties
- public int characterCount { get; }
- public int characterCountVisible { get; }
- public System.Collections.Generic.IList<UnityEngine.UICharInfo> characters { get; }
- public int fontSizeUsedForBestFit { get; }
- public int lineCount { get; }
- public System.Collections.Generic.IList<UnityEngine.UILineInfo> lines { get; }
- public UnityEngine.Rect rectExtents { get; }
- public int vertexCount { get; }
- public System.Collections.Generic.IList<UnityEngine.UIVertex> verts { get; }

#### Constructors
- public TextGenerator()
- public TextGenerator(int initialCapacity)

#### Methods
- protected override void Finalize()
- public void GetCharacters(System.Collections.Generic.List<UnityEngine.UICharInfo> characters)
- public UnityEngine.UICharInfo[] GetCharactersArray()
- private void GetCharactersInternal(object characters)
- public void GetLines(System.Collections.Generic.List<UnityEngine.UILineInfo> lines)
- public UnityEngine.UILineInfo[] GetLinesArray()
- private void GetLinesInternal(object lines)
- public float GetPreferredHeight(string str, UnityEngine.TextGenerationSettings settings)
- public float GetPreferredWidth(string str, UnityEngine.TextGenerationSettings settings)
- public void GetVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices)
- public UnityEngine.UIVertex[] GetVerticesArray()
- private void GetVerticesInternal(object vertices)
- private static System.IntPtr Internal_Create()
- private static void Internal_Destroy(System.IntPtr ptr)
- public void Invalidate()
- public bool Populate(string str, UnityEngine.TextGenerationSettings settings)
- private UnityEngine.TextGenerationError PopulateAlways(string str, UnityEngine.TextGenerationSettings settings)
- private UnityEngine.TextGenerationError PopulateWithError(string str, UnityEngine.TextGenerationSettings settings)
- public bool PopulateWithErrors(string str, UnityEngine.TextGenerationSettings settings, UnityEngine.GameObject context)
- internal bool Populate_Internal(string str, UnityEngine.Font font, UnityEngine.Color color, int fontSize, float scaleFactor, float lineSpacing, UnityEngine.FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, UnityEngine.TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error)
- internal bool Populate_Internal(string str, UnityEngine.Font font, UnityEngine.Color color, int fontSize, float scaleFactor, float lineSpacing, UnityEngine.FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, UnityEngine.VerticalWrapMode verticalOverFlow, UnityEngine.HorizontalWrapMode horizontalOverflow, bool updateBounds, UnityEngine.TextAnchor anchor, UnityEngine.Vector2 extents, UnityEngine.Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out UnityEngine.TextGenerationError error)
- private bool Populate_Internal_Injected(string str, UnityEngine.Font font, ref UnityEngine.Color color, int fontSize, float scaleFactor, float lineSpacing, UnityEngine.FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, UnityEngine.TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error)
- private void System.IDisposable.Dispose()
- private UnityEngine.TextGenerationSettings ValidatedSettings(UnityEngine.TextGenerationSettings settings)

### public class UnityEngine.TextMesh
- Base: UnityEngine.Component

#### Properties
- public UnityEngine.TextAlignment alignment { get; set; }
- public UnityEngine.TextAnchor anchor { get; set; }
- public float characterSize { get; set; }
- public UnityEngine.Color color { get; set; }
- public UnityEngine.Font font { get; set; }
- public int fontSize { get; set; }
- public UnityEngine.FontStyle fontStyle { get; set; }
- public float lineSpacing { get; set; }
- public float offsetZ { get; set; }
- public bool richText { get; set; }
- public float tabSize { get; set; }
- public string text { get; set; }

#### Constructors
- public TextMesh()

### public struct UnityEngine.UICharInfo

#### Fields
- public float charWidth
- public UnityEngine.Vector2 cursorPos

### public struct UnityEngine.UILineInfo

#### Fields
- public int height
- public float leading
- public int startCharIdx
- public float topY

### public struct UnityEngine.UIVertex

#### Fields
- public UnityEngine.Color32 color
- public UnityEngine.Vector3 normal
- public UnityEngine.Vector3 position
- public static UnityEngine.UIVertex simpleVert
- private static readonly UnityEngine.Color32 s_DefaultColor
- private static readonly UnityEngine.Vector4 s_DefaultTangent
- public UnityEngine.Vector4 tangent
- public UnityEngine.Vector4 uv0
- public UnityEngine.Vector4 uv1
- public UnityEngine.Vector4 uv2
- public UnityEngine.Vector4 uv3

#### Constructors
- private static UIVertex()

### public enum UnityEngine.VerticalWrapMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Overflow = 1
- Truncate = 0

