# Assembly: UnityEngine.TextCoreTextEngineModule
- Path: tools/WorldBox.Managed/UnityEngine.TextCoreTextEngineModule.dll
- Types: 80

## Namespace: UnityEngine.TextCore.Text

### private class UnityEngine.TextCore.Text.FontAsset.<>c

#### Fields
- public static readonly UnityEngine.TextCore.Text.FontAsset.<>c <>9
- public static System.Func<UnityEngine.TextCore.Text.Character, uint> <>9__151_0
- public static System.Func<UnityEngine.TextCore.Glyph, uint> <>9__152_0

#### Constructors
- private static FontAsset.<>c()
- public FontAsset.<>c()

#### Methods
- internal uint <SortCharacterTable>b__151_0(UnityEngine.TextCore.Text.Character c)
- internal uint <SortGlyphTable>b__152_0(UnityEngine.TextCore.Glyph c)

### private class UnityEngine.TextCore.Text.FontFeatureTable.<>c

#### Fields
- public static readonly UnityEngine.TextCore.Text.FontFeatureTable.<>c <>9
- public static System.Func<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord, uint> <>9__25_0
- public static System.Func<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord, uint> <>9__25_1
- public static System.Func<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord, uint> <>9__26_0
- public static System.Func<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord, uint> <>9__26_1
- public static System.Func<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord, uint> <>9__27_0
- public static System.Func<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord, uint> <>9__27_1

#### Constructors
- private static FontFeatureTable.<>c()
- public FontFeatureTable.<>c()

#### Methods
- internal uint <SortGlyphPairAdjustmentRecords>b__25_0(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord s)
- internal uint <SortGlyphPairAdjustmentRecords>b__25_1(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord s)
- internal uint <SortMarkToBaseAdjustmentRecords>b__26_0(UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord s)
- internal uint <SortMarkToBaseAdjustmentRecords>b__26_1(UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord s)
- internal uint <SortMarkToMarkAdjustmentRecords>b__27_0(UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord s)
- internal uint <SortMarkToMarkAdjustmentRecords>b__27_1(UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord s)

### private class UnityEngine.TextCore.Text.SpriteAsset.<>c

#### Fields
- public static readonly UnityEngine.TextCore.Text.SpriteAsset.<>c <>9
- public static System.Func<UnityEngine.TextCore.Text.SpriteGlyph, uint> <>9__37_0
- public static System.Func<UnityEngine.TextCore.Text.SpriteCharacter, uint> <>9__38_0

#### Constructors
- private static SpriteAsset.<>c()
- public SpriteAsset.<>c()

#### Methods
- internal uint <SortCharacterTable>b__38_0(UnityEngine.TextCore.Text.SpriteCharacter c)
- internal uint <SortGlyphTable>b__37_0(UnityEngine.TextCore.Text.SpriteGlyph item)

### public enum UnityEngine.TextCore.Text.AtlasPopulationMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Dynamic = 1
- DynamicOS = 2
- Static = 0

### public class UnityEngine.TextCore.Text.Character
- Base: UnityEngine.TextCore.Text.TextElement

#### Constructors
- public Character()
- public Character(uint unicode, UnityEngine.TextCore.Glyph glyph)
- internal Character(uint unicode, uint glyphIndex)
- public Character(uint unicode, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Glyph glyph)

### internal struct UnityEngine.TextCore.Text.CharacterElement

#### Fields
- private UnityEngine.TextCore.Text.TextElement m_TextElement
- private uint m_Unicode

#### Properties
- public uint Unicode { get; set; }

#### Constructors
- public CharacterElement(UnityEngine.TextCore.Text.TextElement textElement)

### internal struct UnityEngine.TextCore.Text.CharacterSubstitution

#### Fields
- public int index
- public uint unicode

#### Constructors
- public CharacterSubstitution(int index, uint unicode)

### internal static class UnityEngine.TextCore.Text.CodePoint

#### Fields
- public static const uint APOSTROPHE
- public static const uint DOUBLE_QUOTE
- public static const uint HIGH_SURROGATE_END
- public static const uint HIGH_SURROGATE_START
- public static const uint HYPHEN
- public static const uint HYPHEN_MINUS
- public static const uint LOW_SURROGATE_END
- public static const uint LOW_SURROGATE_START
- public static const uint MINUS
- public static const uint NON_BREAKING_HYPHEN
- public static const uint NUMBER_SIGN
- public static const uint PERCENTAGE
- public static const uint PERIOD
- public static const uint PLUS
- public static const uint RIGHT_SINGLE_QUOTATION
- public static const uint SOFT_HYPHEN
- public static const uint SPACE
- public static const uint UNICODE_PLANE01_START
- public static const uint WORD_JOINER
- public static const uint ZERO_WIDTH_SPACE

### public enum UnityEngine.TextCore.Text.ColorGradientMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FourCornersGradient = 3
- HorizontalGradient = 1
- Single = 0
- VerticalGradient = 2

### internal static class UnityEngine.TextCore.Text.ColorUtilities

#### Methods
- internal static bool CompareColors(UnityEngine.Color32 a, UnityEngine.Color32 b)
- internal static bool CompareColors(UnityEngine.Color a, UnityEngine.Color b)
- internal static bool CompareColorsRgb(UnityEngine.Color32 a, UnityEngine.Color32 b)
- internal static bool CompareColorsRgb(UnityEngine.Color a, UnityEngine.Color b)
- internal static UnityEngine.Color32 MultiplyColors(UnityEngine.Color32 c1, UnityEngine.Color32 c2)

### internal struct UnityEngine.TextCore.Text.Extents

#### Fields
- public UnityEngine.Vector2 max
- public UnityEngine.Vector2 min

#### Constructors
- public Extents(UnityEngine.Vector2 min, UnityEngine.Vector2 max)

#### Methods
- public override string ToString()

### public class UnityEngine.TextCore.Text.FastAction

#### Fields
- private System.Collections.Generic.LinkedList<System.Action> delegates
- private System.Collections.Generic.Dictionary<System.Action, System.Collections.Generic.LinkedListNode<System.Action>> lookup

#### Constructors
- public FastAction()

#### Methods
- public void Add(System.Action rhs)
- public void Call()
- public void Remove(System.Action rhs)

### public class UnityEngine.TextCore.Text.FastAction<A>

#### Fields
- private System.Collections.Generic.LinkedList<System.Action<A>> delegates
- private System.Collections.Generic.Dictionary<System.Action<A>, System.Collections.Generic.LinkedListNode<System.Action<A>>> lookup

#### Constructors
- public FastAction<A>()

#### Methods
- public void Add(System.Action<A> rhs)
- public void Call(A a)
- public void Remove(System.Action<A> rhs)

### public class UnityEngine.TextCore.Text.FastAction<A, B>

#### Fields
- private System.Collections.Generic.LinkedList<System.Action<A, B>> delegates
- private System.Collections.Generic.Dictionary<System.Action<A, B>, System.Collections.Generic.LinkedListNode<System.Action<A, B>>> lookup

#### Constructors
- public FastAction<A, B>()

#### Methods
- public void Add(System.Action<A, B> rhs)
- public void Call(A a, B b)
- public void Remove(System.Action<A, B> rhs)

### public class UnityEngine.TextCore.Text.FastAction<A, B, C>

#### Fields
- private System.Collections.Generic.LinkedList<System.Action<A, B, C>> delegates
- private System.Collections.Generic.Dictionary<System.Action<A, B, C>, System.Collections.Generic.LinkedListNode<System.Action<A, B, C>>> lookup

#### Constructors
- public FastAction<A, B, C>()

#### Methods
- public void Add(System.Action<A, B, C> rhs)
- public void Call(A a, B b, C c)
- public void Remove(System.Action<A, B, C> rhs)

### public class UnityEngine.TextCore.Text.FontAsset
- Base: UnityEngine.TextCore.Text.TextAsset

#### Fields
- internal bool InternalDynamicOS
- internal bool IsFontAssetLookupTablesDirty
- private static Unity.Profiling.ProfilerMarker k_AddSynthesizedCharactersMarker
- private static Unity.Profiling.ProfilerMarker k_ClearFontAssetDataMarker
- private static System.Collections.Generic.List<UnityEngine.Texture2D> k_FontAssets_AtlasTexturesUpdateQueue
- private static System.Collections.Generic.HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup
- private static System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> k_FontAssets_FontFeaturesUpdateQueue
- private static System.Collections.Generic.HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup
- internal static uint[] k_GlyphIndexArray
- private static Unity.Profiling.ProfilerMarker k_ReadFontAssetDefinitionMarker
- private static System.Collections.Generic.HashSet<int> k_SearchedFontAssetLookup
- private static Unity.Profiling.ProfilerMarker k_TryAddCharacterMarker
- private static Unity.Profiling.ProfilerMarker k_TryAddCharactersMarker
- private static Unity.Profiling.ProfilerMarker k_TryAddGlyphMarker
- private static Unity.Profiling.ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker
- private static Unity.Profiling.ProfilerMarker k_UpdateFontAssetDataMarker
- private static Unity.Profiling.ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker
- internal int m_AtlasHeight
- internal int m_AtlasPadding
- private UnityEngine.TextCore.Text.AtlasPopulationMode m_AtlasPopulationMode
- internal UnityEngine.TextCore.LowLevel.GlyphRenderMode m_AtlasRenderMode
- internal UnityEngine.Texture2D m_AtlasTexture
- internal int m_AtlasTextureIndex
- internal UnityEngine.Texture2D[] m_AtlasTextures
- internal int m_AtlasWidth
- internal float m_BoldStyleSpacing
- internal float m_BoldStyleWeight
- internal System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.Character> m_CharacterLookupDictionary
- internal System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> m_CharactersToAdd
- internal System.Collections.Generic.HashSet<uint> m_CharactersToAddLookup
- internal System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> m_CharacterTable
- private bool m_ClearDynamicDataOnBuild
- internal UnityEngine.TextCore.FaceInfo m_FaceInfo
- internal System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> m_FallbackFontAssetTable
- private int m_FamilyNameHashCode
- internal UnityEngine.TextCore.Text.FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings
- internal UnityEngine.TextCore.Text.FontFeatureTable m_FontFeatureTable
- private UnityEngine.TextCore.Text.FontWeightPair[] m_FontWeightTable
- private System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_FreeGlyphRects
- private System.Collections.Generic.List<uint> m_GlyphIndexList
- private System.Collections.Generic.List<uint> m_GlyphIndexListNewlyAdded
- internal System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Glyph> m_GlyphLookupDictionary
- private System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsRendered
- internal System.Collections.Generic.List<uint> m_GlyphsToAdd
- internal System.Collections.Generic.HashSet<uint> m_GlyphsToAddLookup
- private System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsToRender
- internal System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphTable
- private bool m_IsMultiAtlasTexturesEnabled
- internal byte m_ItalicStyleSlant
- internal System.Collections.Generic.HashSet<uint> m_MissingUnicodesFromFontFile
- internal float m_RegularStyleSpacing
- internal float m_RegularStyleWeight
- private UnityEngine.Font m_SourceFontFile
- internal string m_SourceFontFileGUID
- private string m_SourceFontFilePath
- private int m_StyleNameHashCode
- internal byte m_TabMultiple
- private System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_UsedGlyphRects
- private static string s_DefaultMaterialSuffix
- internal System.Collections.Generic.List<uint> s_MissingCharacterList

#### Properties
- public int atlasHeight { get; internal set; }
- public int atlasPadding { get; internal set; }
- public UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode { get; set; }
- public UnityEngine.TextCore.LowLevel.GlyphRenderMode atlasRenderMode { get; internal set; }
- public UnityEngine.Texture2D atlasTexture { get; }
- public int atlasTextureCount { get; }
- public UnityEngine.Texture2D[] atlasTextures { get; set; }
- public int atlasWidth { get; internal set; }
- public float boldStyleSpacing { get; set; }
- public float boldStyleWeight { get; set; }
- public System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.Character> characterLookupTable { get; }
- public System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> characterTable { get; internal set; }
- internal bool clearDynamicDataOnBuild { get; set; }
- public UnityEngine.TextCore.FaceInfo faceInfo { get; set; }
- public System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> fallbackFontAssetTable { get; set; }
- internal int familyNameHashCode { get; set; }
- public UnityEngine.TextCore.Text.FontAssetCreationEditorSettings fontAssetCreationEditorSettings { get; set; }
- public UnityEngine.TextCore.Text.FontFeatureTable fontFeatureTable { get; internal set; }
- public UnityEngine.TextCore.Text.FontWeightPair[] fontWeightTable { get; internal set; }
- internal System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects { get; set; }
- public System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Glyph> glyphLookupTable { get; }
- public System.Collections.Generic.List<UnityEngine.TextCore.Glyph> glyphTable { get; internal set; }
- public bool isMultiAtlasTexturesEnabled { get; set; }
- public byte italicStyleSlant { get; set; }
- public float regularStyleSpacing { get; set; }
- public float regularStyleWeight { get; set; }
- public UnityEngine.Font sourceFontFile { get; internal set; }
- internal int styleNameHashCode { get; set; }
- public byte tabMultiple { get; set; }
- internal System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects { get; set; }

#### Constructors
- public FontAsset()
- private static FontAsset()

#### Methods
- internal void AddCharacterToLookupCache(uint unicode, UnityEngine.TextCore.Text.Character character)
- private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false)
- internal void AddSynthesizedCharactersAndFaceMetrics()
- private void Awake()
- internal void ClearAtlasTextures(bool setAtlasSizeToZero = false)
- public void ClearFontAssetData(bool setAtlasSizeToZero = false)
- internal void ClearFontAssetDataInternal(bool clearFontFeatures = false)
- internal void ClearFontAssetTables(bool clearFontFeatures)
- private void CopyListDataToArray<T>(System.Collections.Generic.List<T> srcList, ref T[] dstArray)
- public static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90)
- public static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight)
- private static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode = DynamicOS, bool enableMultiAtlasSupport = true)
- public static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font font)
- public static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font font, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode = Dynamic, bool enableMultiAtlasSupport = true)
- private static UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font font, int faceIndex, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode = Dynamic, bool enableMultiAtlasSupport = true)
- private static UnityEngine.TextCore.Text.FontAsset CreateFontAssetInstance(UnityEngine.Font font, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport)
- private void DestroyAtlasTextures()
- public static string GetCharacters(UnityEngine.TextCore.Text.FontAsset fontAsset)
- public static int[] GetCharactersArray(UnityEngine.TextCore.Text.FontAsset fontAsset)
- internal uint GetGlyphIndex(uint unicode)
- public bool HasCharacter(int character)
- public bool HasCharacter(char character, bool searchFallbacks = false, bool tryAddCharacter = false)
- public bool HasCharacter(uint character, bool searchFallbacks = false, bool tryAddCharacter = false)
- public bool HasCharacters(string text, out System.Collections.Generic.List<char> missingCharacters)
- public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = false, bool tryAddCharacter = false)
- public bool HasCharacters(string text)
- private bool HasCharacter_Internal(uint character, bool searchFallbacks = false, bool tryAddCharacter = false)
- internal void InitializeCharacterLookupDictionary()
- internal void InitializeDictionaryLookupTables()
- internal void InitializeGlyphLookupDictionary()
- internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary()
- internal void InitializeLigatureSubstitutionLookupDictionary()
- internal void InitializeMarkToBaseAdjustmentRecordsLookupDictionary()
- internal void InitializeMarkToMarkAdjustmentRecordsLookupDictionary()
- private UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace()
- private void OnDestroy()
- public void ReadFontAssetDefinition()
- internal static void RegisterAtlasTextureForApply(UnityEngine.Texture2D texture)
- internal static void RegisterFontAssetForFontFeatureUpdate(UnityEngine.TextCore.Text.FontAsset fontAsset)
- private void SetupNewAtlasTexture()
- internal void SortAllTables()
- internal void SortCharacterTable()
- internal void SortFontFeatureTable()
- internal void SortGlyphTable()
- internal bool TryAddCharacterInternal(uint unicode, out UnityEngine.TextCore.Text.Character character, bool shouldGetFontFeatures = false)
- public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = false)
- public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = false)
- public bool TryAddCharacters(string characters, bool includeFontFeatures = false)
- public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false)
- internal bool TryAddGlyphInternal(uint glyphIndex, out UnityEngine.TextCore.Glyph glyph)
- internal void TryAddGlyphsToAtlasTextures()
- private bool TryAddGlyphsToNewAtlasTexture()
- internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out UnityEngine.TextCore.Text.Character character, bool shouldGetFontFeatures = false)
- private void UpdateAllFontFeatures()
- internal static void UpdateAtlasTexturesInQueue()
- internal void UpdateFontAssetData()
- internal static void UpdateFontAssetsInUpdateQueue()
- internal static void UpdateFontFeaturesForFontAssetsInQueue()
- internal void UpdateGlyphAdjustmentRecords()
- internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes)
- internal void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<uint> glyphIndexes)
- internal void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<uint> newGlyphIndexes, System.Collections.Generic.List<uint> allGlyphIndexes)

### public struct UnityEngine.TextCore.Text.FontAssetCreationEditorSettings

#### Fields
- public int atlasHeight
- public int atlasWidth
- public string characterSequence
- public int characterSetSelectionMode
- public int faceIndex
- public int fontStyle
- public float fontStyleModifier
- public bool includeFontFeatures
- public int packingMode
- public int padding
- public int paddingMode
- public int pointSize
- public int pointSizeSamplingMode
- public string referencedFontAssetGUID
- public string referencedTextAssetGUID
- public int renderMode
- public string sourceFontFileGUID

#### Constructors
- internal FontAssetCreationEditorSettings(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode)

### private struct UnityEngine.TextCore.Text.TextResourceManager.FontAssetRef

#### Fields
- public long familyNameAndStyleHashCode
- public int familyNameHashCode
- public readonly UnityEngine.TextCore.Text.FontAsset fontAsset
- public int nameHashCode
- public int styleNameHashCode

#### Constructors
- public TextResourceManager.FontAssetRef(int nameHashCode, int familyNameHashCode, int styleNameHashCode, UnityEngine.TextCore.Text.FontAsset fontAsset)

### internal static class UnityEngine.TextCore.Text.FontAssetUtilities

#### Fields
- private static System.Collections.Generic.HashSet<int> k_SearchedAssets

#### Methods
- internal static UnityEngine.TextCore.Text.Character GetCharacterFromFontAsset(uint unicode, UnityEngine.TextCore.Text.FontAsset sourceFontAsset, bool includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, out bool isAlternativeTypeface)
- public static UnityEngine.TextCore.Text.Character GetCharacterFromFontAssets(uint unicode, UnityEngine.TextCore.Text.FontAsset sourceFontAsset, System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> fontAssets, bool includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, out bool isAlternativeTypeface)
- private static UnityEngine.TextCore.Text.Character GetCharacterFromFontAsset_Internal(uint unicode, UnityEngine.TextCore.Text.FontAsset sourceFontAsset, bool includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, out bool isAlternativeTypeface)
- public static UnityEngine.TextCore.Text.SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, bool includeFallbacks)
- private static UnityEngine.TextCore.Text.SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, bool includeFallbacks)

### public class UnityEngine.TextCore.Text.FontFeatureTable

#### Fields
- internal System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup
- internal System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords
- internal System.Collections.Generic.Dictionary<uint, System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord>> m_LigatureSubstitutionRecordLookup
- internal System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord> m_LigatureSubstitutionRecords
- internal System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecordLookup
- internal System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecords
- internal System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecordLookup
- internal System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecords
- internal System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord> m_MultipleSubstitutionRecords

#### Properties
- internal System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get; set; }
- internal System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord> ligatureRecords { get; set; }
- internal System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord> MarkToBaseAdjustmentRecords { get; set; }
- internal System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord> MarkToMarkAdjustmentRecords { get; set; }
- internal System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord> multipleSubstitutionRecords { get; set; }

#### Constructors
- internal FontFeatureTable()

#### Methods
- public void SortGlyphPairAdjustmentRecords()
- public void SortMarkToBaseAdjustmentRecords()
- public void SortMarkToMarkAdjustmentRecords()

### private struct UnityEngine.TextCore.Text.TextSettings.FontReferenceMap

#### Fields
- public UnityEngine.Font font
- public UnityEngine.TextCore.Text.FontAsset fontAsset

#### Constructors
- public TextSettings.FontReferenceMap(UnityEngine.Font font, UnityEngine.TextCore.Text.FontAsset fontAsset)

### public enum UnityEngine.TextCore.Text.FontStyles
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Bold = 1
- Highlight = 512
- Italic = 2
- LowerCase = 8
- Normal = 0
- SmallCaps = 32
- Strikethrough = 64
- Subscript = 256
- Superscript = 128
- Underline = 4
- UpperCase = 16

### internal struct UnityEngine.TextCore.Text.FontStyleStack

#### Fields
- public byte bold
- public byte highlight
- public byte italic
- public byte lowercase
- public byte smallcaps
- public byte strikethrough
- public byte subscript
- public byte superscript
- public byte underline
- public byte uppercase

#### Methods
- public byte Add(UnityEngine.TextCore.Text.FontStyles style)
- public void Clear()
- public byte Remove(UnityEngine.TextCore.Text.FontStyles style)

### public struct UnityEngine.TextCore.Text.FontWeightPair

#### Fields
- public UnityEngine.TextCore.Text.FontAsset italicTypeface
- public UnityEngine.TextCore.Text.FontAsset regularTypeface

### internal struct UnityEngine.TextCore.Text.HighlightState

#### Fields
- public UnityEngine.Color32 color
- public UnityEngine.TextCore.Text.Offset padding

#### Constructors
- public HighlightState(UnityEngine.Color32 color, UnityEngine.TextCore.Text.Offset padding)

#### Methods
- public override bool Equals(object obj)
- public bool Equals(UnityEngine.TextCore.Text.HighlightState other)
- public override int GetHashCode()
- public static bool op_Equality(UnityEngine.TextCore.Text.HighlightState lhs, UnityEngine.TextCore.Text.HighlightState rhs)
- public static bool op_Inequality(UnityEngine.TextCore.Text.HighlightState lhs, UnityEngine.TextCore.Text.HighlightState rhs)

### internal enum UnityEngine.TextCore.Text.HorizontalAlignment
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Center = 2
- Flush = 16
- Geometry = 32
- Justified = 8
- Left = 1
- Right = 4

### internal struct UnityEngine.TextCore.Text.LineInfo

#### Fields
- public UnityEngine.TextCore.Text.TextAlignment alignment
- public float ascender
- public float baseline
- public int characterCount
- internal int controlCharacterCount
- public float descender
- public int firstCharacterIndex
- public int firstVisibleCharacterIndex
- public int lastCharacterIndex
- public int lastVisibleCharacterIndex
- public float length
- public UnityEngine.TextCore.Text.Extents lineExtents
- public float lineHeight
- public float marginLeft
- public float marginRight
- public float maxAdvance
- public int spaceCount
- public int visibleCharacterCount
- public int visibleSpaceCount
- public float width
- public int wordCount

### internal struct UnityEngine.TextCore.Text.LinkInfo

#### Fields
- public int hashCode
- internal char[] linkId
- public int linkIdFirstCharacterIndex
- public int linkIdLength
- public int linkTextfirstCharacterIndex
- public int linkTextLength
- private string m_LinkIdString
- private string m_LinkTextString

#### Methods
- public string GetLinkId()
- public string GetLinkText(UnityEngine.TextCore.Text.TextInfo textInfo)
- internal void SetLinkId(char[] text, int startIndex, int length)

### internal struct UnityEngine.TextCore.Text.MarkupAttribute

#### Fields
- private int m_NameHashCode
- private int m_ValueHashCode
- private int m_ValueLength
- private int m_ValueStartIndex

#### Properties
- public int NameHashCode { get; set; }
- public int ValueHashCode { get; set; }
- public int ValueLength { get; set; }
- public int ValueStartIndex { get; set; }

### internal struct UnityEngine.TextCore.Text.MarkupElement

#### Fields
- private UnityEngine.TextCore.Text.MarkupAttribute[] m_Attributes

#### Properties
- public UnityEngine.TextCore.Text.MarkupAttribute[] Attributes { get; set; }
- public int NameHashCode { get; set; }
- public int ValueHashCode { get; set; }
- public int ValueLength { get; set; }
- public int ValueStartIndex { get; set; }

#### Constructors
- public MarkupElement(int nameHashCode, int startIndex, int length)

### internal enum UnityEngine.TextCore.Text.MarkupTag
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- A = 65
- ACTION = -1827519330
- ALIGN = 75138797
- ALLCAPS = 218273952
- ALPHA = 75165780
- ANGLE = 75347905
- ANIM = 2283339
- BLACK = 81074727
- BLUE = 2457214
- BOLD = 66
- BR = 2256
- CENTER = -1591113269
- CHARACTER_SPACE = -1584382009
- CLASS = 82115566
- COLOR = 81999901
- CR = 2289
- DEFAULT = -620974005
- EM = 2216
- FALSE = 85422813
- FAMILYNAME = 704251153
- FLUSH = 85552164
- FONT = 2586451
- FONT_WEIGHT = -1889896162
- FRAC = 2598518
- GRADIENT = -1999759898
- GREEN = 87065851
- HREF = 2535353
- INDENT = -1514123076
- INDEX = 84268030
- INVALID = 1585415185
- ITALIC = 73
- JUSTIFIED = 817091359
- LEFT = 2660507
- LIGA = 2655971
- LINE_HEIGHT = -799081892
- LINE_INDENT = -844305121
- LINK = 2656128
- LOWERCASE = -1506899689
- MARGIN = -1355614050
- MARGIN_LEFT = -272933656
- MARGIN_RIGHT = -447416589
- MARK = 2699125
- MATERIAL = 825491659
- MINUS = 45
- MINUS_EM = 46789
- MINUS_PCT = 1567082
- MINUS_PERCENTAGE = 1512
- MINUS_PX = 47461
- MONOSPACE = -1340221943
- NAME = 2875623
- NBSP = 2869039
- NONE = 2857034
- NORMAL = -1183493901
- NOTDEF = 612146780
- NO_BREAK = 2856657
- NO_PARSE = -408011596
- ORANGE = -1108587920
- PADDING = -2144568463
- PAGE = 2808691
- PCT = 85031
- PERCENTAGE = 37
- PLUS = 43
- PLUS_EM = 49091
- PLUS_PCT = 1634348
- PLUS_PERCENTAGE = 1454
- PLUS_PX = 49507
- POSITION = 85420
- PURPLE = -1250222130
- PX = 2568
- RED = 91635
- REGULAR = 1291372090
- RIGHT = 99937376
- ROTATE = -1000007783
- SCALE = 100553336
- SHY = 92674
- SIZE = 3061285
- SLASH_A = 1614
- SLASH_ACTION = -1187217679
- SLASH_ALIGN = 1916026786
- SLASH_ALLCAPS = -797437649
- SLASH_BOLD = 1613
- SLASH_CHARACTER_SPACE = -1394426712
- SLASH_COLOR = 1909026194
- SLASH_FONT = 57747708
- SLASH_FONT_WEIGHT = -757976431
- SLASH_FRAC = 57774681
- SLASH_GRADIENT = -1854491959
- SLASH_INDENT = -1496889389
- SLASH_ITALIC = 1606
- SLASH_LIGA = 57686604
- SLASH_LINE_HEIGHT = 200452819
- SLASH_LINE_INDENT = 93886352
- SLASH_LINK = 57686191
- SLASH_LOWERCASE = -1451284584
- SLASH_MARGIN = -1649644303
- SLASH_MARK = 57644506
- SLASH_MATERIAL = -1100708252
- SLASH_MONOSPACE = -1638865562
- SLASH_NO_BREAK = 57477502
- SLASH_NO_PARSE = -294095813
- SLASH_PAGE = 58683868
- SLASH_POSITION = 1777699
- SLASH_ROTATE = -764695562
- SLASH_SCALE = 1928413879
- SLASH_SIZE = 58429962
- SLASH_SMALLCAPS = 199921873
- SLASH_SPACE = 1927873067
- SLASH_STRIKETHROUGH = 1628
- SLASH_STYLE = 1927738392
- SLASH_SUBSCRIPT = 1770219
- SLASH_SUPERSCRIPT = 1770233
- SLASH_TABLE = -979118220
- SLASH_TD = 193346074
- SLASH_TH = 193346070
- SLASH_TR = 193346060
- SLASH_UNDERLINE = 1626
- SLASH_UPPERCASE = -582368199
- SLASH_VERTICAL_OFFSET = -11107948
- SLASH_WIDTH = 1923459625
- SMALLCAPS = -766062114
- SPACE = 100083556
- SPRITE = -991527447
- STRIKETHROUGH = 83
- STYLE = 100252951
- STYLENAME = -1207081936
- SUBSCRIPT = 92132
- SUPERSCRIPT = 92150
- TABLE = 226476955
- TD = 5862485
- TH = 5862489
- TINT = 2960519
- TR = 5862467
- TRUE = 2932022
- UNDERLINE = 85
- UPPERCASE = -305409418
- VERTICAL_OFFSET = 1952379995
- WHITE = 105680263
- WIDTH = 105793766
- YELLOW = -882444668
- ZWJ = 99623
- ZWSP = 3288238

### internal static class UnityEngine.TextCore.Text.MaterialManager

#### Fields
- private static System.Collections.Generic.Dictionary<long, UnityEngine.Material> s_FallbackMaterials

#### Constructors
- private static MaterialManager()

#### Methods
- private static void CopyMaterialPresetProperties(UnityEngine.Material source, UnityEngine.Material destination)
- public static UnityEngine.Material GetFallbackMaterial(UnityEngine.Material sourceMaterial, UnityEngine.Material targetMaterial)
- public static UnityEngine.Material GetFallbackMaterial(UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.Material sourceMaterial, int atlasIndex)

### internal struct UnityEngine.TextCore.Text.MaterialReference

#### Fields
- public UnityEngine.Material fallbackMaterial
- public UnityEngine.TextCore.Text.FontAsset fontAsset
- public int index
- public bool isDefaultMaterial
- public bool isFallbackMaterial
- public UnityEngine.Material material
- public float padding
- public int referenceCount
- public UnityEngine.TextCore.Text.SpriteAsset spriteAsset

#### Constructors
- public MaterialReference(int index, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, UnityEngine.Material material, float padding)

#### Methods
- public static int AddMaterialReference(UnityEngine.Material material, UnityEngine.TextCore.Text.FontAsset fontAsset, ref UnityEngine.TextCore.Text.MaterialReference[] materialReferences, System.Collections.Generic.Dictionary<int, int> materialReferenceIndexLookup)
- public static int AddMaterialReference(UnityEngine.Material material, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, ref UnityEngine.TextCore.Text.MaterialReference[] materialReferences, System.Collections.Generic.Dictionary<int, int> materialReferenceIndexLookup)
- public static bool Contains(UnityEngine.TextCore.Text.MaterialReference[] materialReferences, UnityEngine.TextCore.Text.FontAsset fontAsset)

### internal class UnityEngine.TextCore.Text.MaterialReferenceManager

#### Fields
- private System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.TextColorGradient> m_ColorGradientReferenceLookup
- private System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.FontAsset> m_FontAssetReferenceLookup
- private System.Collections.Generic.Dictionary<int, UnityEngine.Material> m_FontMaterialReferenceLookup
- private System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.SpriteAsset> m_SpriteAssetReferenceLookup
- private static UnityEngine.TextCore.Text.MaterialReferenceManager s_Instance

#### Properties
- public static UnityEngine.TextCore.Text.MaterialReferenceManager instance { get; }

#### Constructors
- public MaterialReferenceManager()

#### Methods
- public static void AddColorGradientPreset(int hashCode, UnityEngine.TextCore.Text.TextColorGradient spriteAsset)
- private void AddColorGradientPreset_Internal(int hashCode, UnityEngine.TextCore.Text.TextColorGradient spriteAsset)
- public static void AddFontAsset(UnityEngine.TextCore.Text.FontAsset fontAsset)
- private void AddFontAssetInternal(UnityEngine.TextCore.Text.FontAsset fontAsset)
- public static void AddFontMaterial(int hashCode, UnityEngine.Material material)
- private void AddFontMaterialInternal(int hashCode, UnityEngine.Material material)
- public static void AddSpriteAsset(UnityEngine.TextCore.Text.SpriteAsset spriteAsset)
- public static void AddSpriteAsset(int hashCode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset)
- private void AddSpriteAssetInternal(UnityEngine.TextCore.Text.SpriteAsset spriteAsset)
- private void AddSpriteAssetInternal(int hashCode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset)
- public bool Contains(UnityEngine.TextCore.Text.FontAsset font)
- public bool Contains(UnityEngine.TextCore.Text.SpriteAsset sprite)
- public static bool TryGetColorGradientPreset(int hashCode, out UnityEngine.TextCore.Text.TextColorGradient gradientPreset)
- private bool TryGetColorGradientPresetInternal(int hashCode, out UnityEngine.TextCore.Text.TextColorGradient gradientPreset)
- public static bool TryGetFontAsset(int hashCode, out UnityEngine.TextCore.Text.FontAsset fontAsset)
- private bool TryGetFontAssetInternal(int hashCode, out UnityEngine.TextCore.Text.FontAsset fontAsset)
- public static bool TryGetMaterial(int hashCode, out UnityEngine.Material material)
- private bool TryGetMaterialInternal(int hashCode, out UnityEngine.Material material)
- public static bool TryGetSpriteAsset(int hashCode, out UnityEngine.TextCore.Text.SpriteAsset spriteAsset)
- private bool TryGetSpriteAssetInternal(int hashCode, out UnityEngine.TextCore.Text.SpriteAsset spriteAsset)

### internal struct UnityEngine.TextCore.Text.MeshExtents

#### Fields
- public UnityEngine.Vector2 max
- public UnityEngine.Vector2 min

#### Constructors
- public MeshExtents(UnityEngine.Vector2 min, UnityEngine.Vector2 max)

#### Methods
- public override string ToString()

### internal struct UnityEngine.TextCore.Text.MeshInfo

#### Fields
- public UnityEngine.Color32[] colors32
- internal UnityEngine.TextCore.LowLevel.GlyphRenderMode glyphRenderMode
- private static readonly UnityEngine.Color32 k_DefaultColor
- private static readonly UnityEngine.Vector3 k_DefaultNormal
- private static readonly UnityEngine.Vector4 k_DefaultTangent
- public UnityEngine.Material material
- public UnityEngine.Vector3[] normals
- public UnityEngine.Vector4[] tangents
- public int[] triangles
- public UnityEngine.Vector4[] uvs0
- public UnityEngine.Vector2[] uvs2
- public int vertexCount
- public UnityEngine.Vector3[] vertices

#### Constructors
- private static MeshInfo()
- public MeshInfo(int size)

#### Methods
- internal void Clear(bool uploadChanges)
- internal void ClearUnusedVertices()
- public void ClearUnusedVertices(int startIndex, bool updateMesh)
- internal void ClearUnusedVertices(int startIndex)
- internal void ResizeMeshInfo(int size)
- internal void SortGeometry(UnityEngine.TextCore.Text.VertexSortingOrder order)
- internal void SwapVertexData(int src, int dst)

### public delegate UnityEngine.TextCore.Text.TextGenerator.MissingCharacterEventCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public TextGenerator.MissingCharacterEventCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(uint unicode, int stringIndex, UnityEngine.TextCore.Text.TextInfo text, UnityEngine.TextCore.Text.FontAsset fontAsset, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(uint unicode, int stringIndex, UnityEngine.TextCore.Text.TextInfo text, UnityEngine.TextCore.Text.FontAsset fontAsset)

### internal struct UnityEngine.TextCore.Text.Offset

#### Fields
- private static readonly UnityEngine.TextCore.Text.Offset k_ZeroOffset
- private float m_Bottom
- private float m_Left
- private float m_Right
- private float m_Top

#### Properties
- public float bottom { get; set; }
- public float horizontal { get; set; }
- public float left { get; set; }
- public float right { get; set; }
- public float top { get; set; }
- public float vertical { get; set; }
- public static UnityEngine.TextCore.Text.Offset zero { get; }

#### Constructors
- private static Offset()
- public Offset(float horizontal, float vertical)
- public Offset(float left, float right, float top, float bottom)

#### Methods
- public override bool Equals(object obj)
- public bool Equals(UnityEngine.TextCore.Text.Offset other)
- public override int GetHashCode()
- public static bool op_Equality(UnityEngine.TextCore.Text.Offset lhs, UnityEngine.TextCore.Text.Offset rhs)
- public static bool op_Inequality(UnityEngine.TextCore.Text.Offset lhs, UnityEngine.TextCore.Text.Offset rhs)
- public static UnityEngine.TextCore.Text.Offset op_Multiply(UnityEngine.TextCore.Text.Offset a, float b)

### internal struct UnityEngine.TextCore.Text.PageInfo

#### Fields
- public float ascender
- public float baseLine
- public float descender
- public int firstCharacterIndex
- public int lastCharacterIndex

### internal struct UnityEngine.TextCore.Text.RichTextTagAttribute

#### Fields
- public int nameHashCode
- public UnityEngine.TextCore.Text.TagUnitType unitType
- public int valueHashCode
- public int valueLength
- public int valueStartIndex
- public UnityEngine.TextCore.Text.TagValueType valueType

### protected struct UnityEngine.TextCore.Text.TextGenerator.SpecialCharacter

#### Fields
- public UnityEngine.TextCore.Text.Character character
- public UnityEngine.TextCore.Text.FontAsset fontAsset
- public UnityEngine.Material material
- public int materialIndex

#### Constructors
- public TextGenerator.SpecialCharacter(UnityEngine.TextCore.Text.Character character, int materialIndex)

### public class UnityEngine.TextCore.Text.SpriteAsset
- Base: UnityEngine.TextCore.Text.TextAsset

#### Fields
- public System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> fallbackSpriteAssets
- private static System.Collections.Generic.HashSet<int> k_searchedSpriteAssets
- internal UnityEngine.TextCore.FaceInfo m_FaceInfo
- internal System.Collections.Generic.Dictionary<uint, int> m_GlyphIndexLookup
- internal bool m_IsSpriteAssetLookupTablesDirty
- internal System.Collections.Generic.Dictionary<int, int> m_NameLookup
- internal UnityEngine.Texture m_SpriteAtlasTexture
- internal System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.SpriteCharacter> m_SpriteCharacterLookup
- private System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> m_SpriteCharacterTable
- internal System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.SpriteGlyph> m_SpriteGlyphLookup
- private System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> m_SpriteGlyphTable

#### Properties
- public UnityEngine.TextCore.FaceInfo faceInfo { get; internal set; }
- public System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.SpriteCharacter> spriteCharacterLookupTable { get; internal set; }
- public System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> spriteCharacterTable { get; internal set; }
- public System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> spriteGlyphTable { get; internal set; }
- public UnityEngine.Texture spriteSheet { get; internal set; }

#### Constructors
- public SpriteAsset()

#### Methods
- private void Awake()
- public int GetSpriteIndexFromHashcode(int hashCode)
- public int GetSpriteIndexFromName(string name)
- public int GetSpriteIndexFromUnicode(uint unicode)
- public static UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCode(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex, UnityEngine.TextCore.Text.TextSettings textSettings = null)
- private static UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCodeInternal(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex)
- private static UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCodeInternal(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex)
- public static UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicode(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
- private static UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicodeInternal(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex)
- private static UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicodeInternal(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
- internal void SortCharacterTable()
- internal void SortGlyphAndCharacterTables()
- public void SortGlyphTable()
- public void UpdateLookupTables()

### public class UnityEngine.TextCore.Text.SpriteCharacter
- Base: UnityEngine.TextCore.Text.TextElement

#### Fields
- private string m_Name

#### Properties
- public string name { get; set; }

#### Constructors
- public SpriteCharacter()
- public SpriteCharacter(uint unicode, UnityEngine.TextCore.Text.SpriteGlyph glyph)
- public SpriteCharacter(uint unicode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, UnityEngine.TextCore.Text.SpriteGlyph glyph)

### public class UnityEngine.TextCore.Text.SpriteGlyph
- Base: UnityEngine.TextCore.Glyph

#### Fields
- public UnityEngine.Sprite sprite

#### Constructors
- public SpriteGlyph()
- public SpriteGlyph(uint index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, float scale, int atlasIndex)
- public SpriteGlyph(uint index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, float scale, int atlasIndex, UnityEngine.Sprite sprite)

### internal enum UnityEngine.TextCore.Text.TagUnitType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FontUnits = 1
- Percentage = 2
- Pixels = 0

### internal enum UnityEngine.TextCore.Text.TagValueType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ColorValue = 4
- None = 0
- NumericalValue = 1
- StringValue = 2

### internal enum UnityEngine.TextCore.Text.TextAlignment
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BaselineCenter = 2050
- BaselineFlush = 2064
- BaselineGeoAligned = 2080
- BaselineJustified = 2056
- BaselineLeft = 2049
- BaselineRight = 2052
- BottomCenter = 1026
- BottomFlush = 1040
- BottomGeoAligned = 1056
- BottomJustified = 1032
- BottomLeft = 1025
- BottomRight = 1028
- CaplineCenter = 8194
- CaplineFlush = 8208
- CaplineGeoAligned = 8224
- CaplineJustified = 8200
- CaplineLeft = 8193
- CaplineRight = 8196
- MiddleCenter = 514
- MiddleFlush = 528
- MiddleGeoAligned = 544
- MiddleJustified = 520
- MiddleLeft = 513
- MiddleRight = 516
- MidlineCenter = 4098
- MidlineFlush = 4112
- MidlineGeoAligned = 4128
- MidlineJustified = 4104
- MidlineLeft = 4097
- MidlineRight = 4100
- TopCenter = 258
- TopFlush = 272
- TopGeoAligned = 288
- TopJustified = 264
- TopLeft = 257
- TopRight = 260

### public class UnityEngine.TextCore.Text.TextAsset
- Base: UnityEngine.ScriptableObject

#### Fields
- internal int m_HashCode
- internal int m_InstanceID
- internal UnityEngine.Material m_Material
- internal int m_MaterialHashCode
- internal string m_Version

#### Properties
- public int hashCode { get; set; }
- public int instanceID { get; }
- public UnityEngine.Material material { get; set; }
- public int materialHashCode { get; set; }
- public string version { get; internal set; }

#### Constructors
- protected TextAsset()

### internal struct UnityEngine.TextCore.Text.TextBackingContainer

#### Fields
- private uint[] m_Array
- private int m_Count

#### Properties
- public int Capacity { get; }
- public int Count { get; set; }
- public uint Item { get; set; }
- public uint[] Text { get; }

#### Constructors
- public TextBackingContainer(int size)

#### Methods
- public void Resize(int size)

### public class UnityEngine.TextCore.Text.TextColorGradient
- Base: UnityEngine.ScriptableObject

#### Fields
- public UnityEngine.Color bottomLeft
- public UnityEngine.Color bottomRight
- public UnityEngine.TextCore.Text.ColorGradientMode colorMode
- private static readonly UnityEngine.Color k_DefaultColor
- private static const UnityEngine.TextCore.Text.ColorGradientMode k_DefaultColorMode
- public UnityEngine.Color topLeft
- public UnityEngine.Color topRight

#### Constructors
- public TextColorGradient()
- private static TextColorGradient()
- public TextColorGradient(UnityEngine.Color color)
- public TextColorGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3)

### public class UnityEngine.TextCore.Text.TextElement

#### Fields
- protected UnityEngine.TextCore.Text.TextElementType m_ElementType
- internal UnityEngine.TextCore.Glyph m_Glyph
- internal uint m_GlyphIndex
- internal float m_Scale
- internal UnityEngine.TextCore.Text.TextAsset m_TextAsset
- internal uint m_Unicode

#### Properties
- public UnityEngine.TextCore.Text.TextElementType elementType { get; }
- public UnityEngine.TextCore.Glyph glyph { get; set; }
- public uint glyphIndex { get; set; }
- public float scale { get; set; }
- public UnityEngine.TextCore.Text.TextAsset textAsset { get; set; }
- public uint unicode { get; set; }

#### Constructors
- protected TextElement()

### internal struct UnityEngine.TextCore.Text.TextElementInfo

#### Fields
- internal float adjustedAscender
- internal float adjustedDescender
- internal float adjustedHorizontalAdvance
- public UnityEngine.TextCore.Glyph alternativeGlyph
- public float ascender
- public float aspectRatio
- public float baseLine
- public UnityEngine.Vector3 bottomLeft
- public UnityEngine.Vector3 bottomRight
- public char character
- public UnityEngine.Color32 color
- public float descender
- public UnityEngine.TextCore.Text.TextElementType elementType
- public UnityEngine.TextCore.Text.FontAsset fontAsset
- public UnityEngine.Color32 highlightColor
- public UnityEngine.TextCore.Text.HighlightState highlightState
- public int index
- public bool isUsingAlternateTypeface
- public bool isVisible
- public int lineNumber
- public UnityEngine.Material material
- public int materialReferenceIndex
- public float origin
- public int pageNumber
- public float pointSize
- public float scale
- public UnityEngine.TextCore.Text.SpriteAsset spriteAsset
- public int spriteIndex
- public UnityEngine.Color32 strikethroughColor
- public int strikethroughVertexIndex
- public int stringLength
- public UnityEngine.TextCore.Text.FontStyles style
- public UnityEngine.TextCore.Text.TextElement textElement
- public UnityEngine.Vector3 topLeft
- public UnityEngine.Vector3 topRight
- public UnityEngine.Color32 underlineColor
- public int underlineVertexIndex
- public UnityEngine.TextCore.Text.TextVertex vertexBottomLeft
- public UnityEngine.TextCore.Text.TextVertex vertexBottomRight
- public int vertexIndex
- public UnityEngine.TextCore.Text.TextVertex vertexTopLeft
- public UnityEngine.TextCore.Text.TextVertex vertexTopRight
- public float xAdvance

#### Methods
- public override string ToString()
- internal string ToStringTest()

### public enum UnityEngine.TextCore.Text.TextElementType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Character = 1
- Sprite = 2

### public static class UnityEngine.TextCore.Text.TextEventManager

#### Fields
- public static readonly UnityEngine.TextCore.Text.FastAction<UnityEngine.Object> COLOR_GRADIENT_PROPERTY_EVENT
- public static readonly UnityEngine.TextCore.Text.FastAction<UnityEngine.GameObject, UnityEngine.Material, UnityEngine.Material> DRAG_AND_DROP_MATERIAL_EVENT
- public static readonly UnityEngine.TextCore.Text.FastAction<bool, UnityEngine.Object> FONT_PROPERTY_EVENT
- public static readonly UnityEngine.TextCore.Text.FastAction<bool, UnityEngine.Material> MATERIAL_PROPERTY_EVENT
- public static readonly UnityEngine.TextCore.Text.FastAction OnPreRenderObject_Event
- public static readonly UnityEngine.TextCore.Text.FastAction RESOURCE_LOAD_EVENT
- public static readonly UnityEngine.TextCore.Text.FastAction<bool, UnityEngine.Object> SPRITE_ASSET_PROPERTY_EVENT
- public static readonly UnityEngine.TextCore.Text.FastAction<bool, UnityEngine.Object> TEXTMESHPRO_PROPERTY_EVENT
- public static readonly UnityEngine.TextCore.Text.FastAction<bool, UnityEngine.Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT
- public static readonly UnityEngine.TextCore.Text.FastAction<UnityEngine.Object> TEXT_CHANGED_EVENT
- public static readonly UnityEngine.TextCore.Text.FastAction<bool> TEXT_STYLE_PROPERTY_EVENT
- public static readonly UnityEngine.TextCore.Text.FastAction TMP_SETTINGS_PROPERTY_EVENT

#### Constructors
- private static TextEventManager()

#### Methods
- public static void ON_COLOR_GRADIENT_PROPERTY_CHANGED(UnityEngine.Object gradient)
- public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(UnityEngine.GameObject sender, UnityEngine.Material currentMaterial, UnityEngine.Material newMaterial)
- public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object font)
- public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, UnityEngine.Material mat)
- public static void ON_PRE_RENDER_OBJECT_CHANGED()
- public static void ON_RESOURCES_LOADED()
- public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj)
- public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj)
- public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj)
- public static void ON_TEXT_CHANGED(UnityEngine.Object obj)
- public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged)
- public static void ON_TMP_SETTINGS_CHANGED()

### public enum UnityEngine.TextCore.Text.TextFontWeight
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Black = 900
- Bold = 700
- ExtraLight = 200
- Heavy = 800
- Light = 300
- Medium = 500
- Regular = 400
- SemiBold = 600
- Thin = 100

### internal class UnityEngine.TextCore.Text.TextGenerationSettings
- Interfaces: System.IEquatable<UnityEngine.TextCore.Text.TextGenerationSettings>

#### Fields
- public bool autoSize
- public float characterSpacing
- public float charWidthMaxAdj
- public UnityEngine.Color color
- public bool enableKerning
- public float extraPadding
- public int firstVisibleCharacter
- public UnityEngine.TextCore.Text.FontAsset fontAsset
- public UnityEngine.TextCore.Text.TextColorGradient fontColorGradient
- public UnityEngine.TextCore.Text.TextColorGradient fontColorGradientPreset
- public float fontSize
- public float fontSizeMax
- public float fontSizeMin
- public UnityEngine.TextCore.Text.FontStyles fontStyle
- public UnityEngine.TextCore.Text.TextFontWeight fontWeight
- public UnityEngine.TextCore.Text.VertexSortingOrder geometrySortingOrder
- public UnityEngine.TextCore.Text.TextureMapping horizontalMapping
- internal UnityEngine.TextCore.Text.TextInputSource inputSource
- public bool inverseYAxis
- public bool isOrthographic
- public bool isRightToLeft
- public float lineSpacing
- public float lineSpacingMax
- public UnityEngine.Vector4 margins
- public UnityEngine.Material material
- public int maxVisibleCharacters
- public int maxVisibleLines
- public int maxVisibleWords
- public UnityEngine.TextCore.Text.TextOverflowMode overflowMode
- public bool overrideRichTextColors
- public int pageToDisplay
- public float paragraphSpacing
- public bool parseControlCharacters
- public bool richText
- public float scale
- public UnityEngine.Rect screenRect
- public bool shouldConvertToLinearSpace
- public UnityEngine.TextCore.Text.SpriteAsset spriteAsset
- public UnityEngine.TextCore.Text.TextStyleSheet styleSheet
- public bool tagNoParsing
- public string text
- public UnityEngine.TextCore.Text.TextAlignment textAlignment
- public UnityEngine.TextCore.Text.TextSettings textSettings
- public UnityEngine.TextCore.Text.TextWrappingMode textWrappingMode
- public bool tintSprites
- public bool useMaxVisibleDescender
- public float uvLineOffset
- public UnityEngine.TextCore.Text.TextureMapping verticalMapping
- public float wordSpacing
- public bool wordWrap
- public float wordWrappingRatio

#### Constructors
- public TextGenerationSettings()

#### Methods
- public bool Equals(UnityEngine.TextCore.Text.TextGenerationSettings other)
- public override bool Equals(object obj)
- public override int GetHashCode()
- public static bool op_Equality(UnityEngine.TextCore.Text.TextGenerationSettings left, UnityEngine.TextCore.Text.TextGenerationSettings right)
- public static bool op_Inequality(UnityEngine.TextCore.Text.TextGenerationSettings left, UnityEngine.TextCore.Text.TextGenerationSettings right)
- public override string ToString()

### internal class UnityEngine.TextCore.Text.TextGenerator

#### Fields
- private static const int k_CarriageReturn
- private static const int k_CjkEnd
- private static const int k_CjkFormsEnd
- private static const int k_CjkFormsStart
- private static const int k_CjkHalfwidthEnd
- private static const int k_CjkHalfwidthStart
- private static const int k_CjkIdeographsEnd
- private static const int k_CjkIdeographsStart
- private static const int k_CjkStart
- private static const int k_DoubleQuotes
- private static const int k_EndOfText
- private static const int k_Equal
- private static const int k_FigureSpace
- private static const float k_FloatUnset
- private static const int k_GreaterThan
- private static const int k_HangulJameExtendedEnd
- private static const int k_HangulJameExtendedStart
- private static const int k_HangulJamoEnd
- private static const int k_HangulJamoStart
- private static const int k_HangulSyllablesEnd
- private static const int k_HangulSyllablesStart
- private static const int k_HorizontalEllipsis
- private static const int k_Hyphen
- private static const int k_HyphenMinus
- private static const int k_LesserThan
- private static const int k_LineFeed
- private static const int k_MaxCharacters
- private static const int k_Minus
- private static const int k_NarrowNoBreakSpace
- private static const int k_NoBreakSpace
- private static const int k_NonBreakingHyphen
- private static const int k_NumberSign
- private static const int k_PercentSign
- private static const int k_Period
- private static const int k_Plus
- private static const int k_RightSingleQuote
- private static const int k_SingleQuote
- private static const int k_SoftHyphen
- private static const int k_Space
- private static const int k_Square
- private static const int k_Tab
- private static const int k_Underline
- private static const int k_WordJoiner
- private static const int k_ZeroWidthSpace
- private UnityEngine.TextCore.Text.TextProcessingStack<int> m_ActionStack
- private float[] m_AttributeParameterValues
- private int m_AutoSizeIterationCount
- private int m_AutoSizeMaxIterationCount
- private float m_BaselineOffset
- private UnityEngine.TextCore.Text.TextProcessingStack<float> m_BaselineOffsetStack
- private UnityEngine.TextCore.Text.TextElement m_CachedTextElement
- private int m_CharacterCount
- private float m_CharWidthAdjDelta
- private UnityEngine.TextCore.Text.TextColorGradient m_ColorGradientPreset
- private bool m_ColorGradientPresetIsTinted
- private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextColorGradient> m_ColorGradientStack
- private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> m_ColorStack
- private float m_CSpacing
- private UnityEngine.TextCore.Text.FontAsset m_CurrentFontAsset
- private float m_CurrentFontSize
- private UnityEngine.Material m_CurrentMaterial
- private int m_CurrentMaterialIndex
- private UnityEngine.TextCore.Text.SpriteAsset m_CurrentSpriteAsset
- private UnityEngine.TextCore.Text.SpriteAsset m_DefaultSpriteAsset
- protected UnityEngine.TextCore.Text.TextGenerator.SpecialCharacter m_Ellipsis
- private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.WordWrapState> m_EllipsisInsertionCandidateStack
- private int m_FirstCharacterOfLine
- private int m_FirstOverflowCharacterIndex
- private int m_FirstVisibleCharacterOfLine
- private UnityEngine.Color32 m_FontColor32
- private float m_FontScaleMultiplier
- private float m_FontSize
- private UnityEngine.TextCore.Text.FontStyles m_FontStyleInternal
- private UnityEngine.TextCore.Text.FontStyleStack m_FontStyleStack
- private UnityEngine.TextCore.Text.TextFontWeight m_FontWeightInternal
- private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextFontWeight> m_FontWeightStack
- private UnityEngine.Quaternion m_FXRotation
- private UnityEngine.Vector3 m_FXScale
- private UnityEngine.Color32 m_HighlightColor
- private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> m_HighlightColorStack
- internal UnityEngine.TextCore.Text.HighlightState m_HighlightState
- private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.HighlightState> m_HighlightStateStack
- private UnityEngine.Color32 m_HtmlColor
- private char[] m_HtmlTag
- private UnityEngine.TextCore.Text.TextProcessingStack<float> m_IndentStack
- private UnityEngine.TextCore.Text.TextElementInfo[] m_InternalTextElementInfo
- internal int m_InternalTextProcessingArraySize
- private bool m_IsAutoSizePointSizeSet
- private bool m_IsCalculatingPreferredValues
- private bool m_IsDrivenLineSpacing
- protected bool m_IsIgnoringAlignment
- private bool m_IsNewPage
- private bool m_IsNonBreakingSpace
- private bool m_isTextLayoutPhase
- protected static bool m_IsTextTruncated
- private int m_ItalicAngle
- private UnityEngine.TextCore.Text.TextProcessingStack<int> m_ItalicAngleStack
- private int m_LastBaseGlyphIndex
- private int m_LastCharacterOfLine
- private int m_LastVisibleCharacterOfLine
- private float m_LineHeight
- private UnityEngine.TextCore.Text.TextAlignment m_LineJustification
- private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextAlignment> m_LineJustificationStack
- private int m_LineNumber
- private float m_LineOffset
- private float m_LineSpacingDelta
- private int m_LineVisibleCharacterCount
- private int m_LineVisibleSpaceCount
- private float m_MarginHeight
- private float m_MarginLeft
- private float m_MarginRight
- private float m_MarginWidth
- private System.Collections.Generic.Dictionary<int, int> m_MaterialReferenceIndexLookup
- private UnityEngine.TextCore.Text.MaterialReference[] m_MaterialReferences
- private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.MaterialReference> m_MaterialReferenceStack
- private float m_MaxAscender
- private float m_MaxCapHeight
- private float m_MaxDescender
- private float m_MaxFontSize
- private float m_MaxLineAscender
- private float m_MaxLineDescender
- private UnityEngine.TextCore.Text.Extents m_MeshExtents
- private float m_MinFontSize
- private float m_MonoSpacing
- private float m_Padding
- private float m_PageAscender
- private int m_PageNumber
- private float m_PreferredHeight
- private float m_PreferredWidth
- private UnityEngine.Vector3[] m_RectTransformCorners
- private UnityEngine.TextCore.Text.WordWrapState m_SavedEllipsisState
- private UnityEngine.TextCore.Text.WordWrapState m_SavedLastValidState
- private UnityEngine.TextCore.Text.WordWrapState m_SavedLineState
- private UnityEngine.TextCore.Text.WordWrapState m_SavedSoftLineBreakState
- private UnityEngine.TextCore.Text.WordWrapState m_SavedWordWrapState
- private UnityEngine.TextCore.Text.TextProcessingStack<float> m_SizeStack
- private int m_SpriteAnimationId
- private UnityEngine.Color32 m_SpriteColor
- private int m_SpriteCount
- private int m_SpriteIndex
- private float m_StartOfLineAscender
- private UnityEngine.Color32 m_StrikethroughColor
- private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> m_StrikethroughColorStack
- private UnityEngine.TextCore.Text.TextProcessingStack<int> m_StyleStack
- private float m_TagIndent
- private float m_TagLineIndent
- private bool m_TagNoParsing
- private UnityEngine.TextCore.Text.TextBackingContainer m_TextBackingArray
- private UnityEngine.TextCore.Text.TextElementType m_TextElementType
- internal UnityEngine.TextCore.Text.TextProcessingElement[] m_TextProcessingArray
- protected int m_TextStyleStackDepth
- protected UnityEngine.TextCore.Text.TextProcessingStack<int>[] m_TextStyleStacks
- private bool m_TintSprite
- private int m_TotalCharacterCount
- protected UnityEngine.TextCore.Text.TextGenerator.SpecialCharacter m_Underline
- private UnityEngine.Color32 m_UnderlineColor
- private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> m_UnderlineColorStack
- protected bool m_VertexBufferAutoSizeReduction
- private float m_Width
- private float m_XAdvance
- private UnityEngine.TextCore.Text.RichTextTagAttribute[] m_XmlAttribute
- private static UnityEngine.TextCore.Text.TextGenerator.MissingCharacterEventCallback OnMissingCharacter
- private static UnityEngine.TextCore.Text.TextGenerator s_TextGenerator

#### Properties
- public static bool isTextTruncated { get; }
- private bool vertexBufferAutoSizeReduction { get; set; }

#### Events
- public static event UnityEngine.TextCore.Text.TextGenerator.MissingCharacterEventCallback OnMissingCharacter

#### Constructors
- public TextGenerator()

#### Methods
- protected virtual UnityEngine.Vector2 CalculatePreferredValues(ref float fontSize, UnityEngine.Vector2 marginSize, bool isTextAutoSizingEnabled, UnityEngine.TextCore.Text.TextWrappingMode textWrapMode, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
- private void ClearMarkupTagAttributes()
- private static void ClearMesh(bool updateMesh, UnityEngine.TextCore.Text.TextInfo textInfo)
- private void ComputeMarginSize(UnityEngine.Rect rect, UnityEngine.Vector4 margins)
- protected void DoMissingGlyphCallback(uint unicode, int stringIndex, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Text.TextInfo textInfo)
- private void DrawTextHighlight(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color32 highlightColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
- private void DrawUnderlineMesh(UnityEngine.Vector3 start, UnityEngine.Vector3 end, float startScale, float endScale, float maxScale, float sdfScale, UnityEngine.Color32 underlineColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
- public static void GenerateText(UnityEngine.TextCore.Text.TextGenerationSettings settings, UnityEngine.TextCore.Text.TextInfo textInfo)
- private void GenerateTextMesh(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
- public static UnityEngine.Vector2 GetCursorPosition(UnityEngine.TextCore.Text.TextGenerationSettings settings, int index)
- public static UnityEngine.Vector2 GetCursorPosition(UnityEngine.TextCore.Text.TextInfo textInfo, UnityEngine.Rect screenRect, int index, bool inverseYAxis = true)
- protected void GetEllipsisSpecialCharacter(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings)
- public static float GetPreferredHeight(UnityEngine.TextCore.Text.TextGenerationSettings settings, UnityEngine.TextCore.Text.TextInfo textInfo)
- private float GetPreferredHeightInternal(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
- public static UnityEngine.Vector2 GetPreferredValues(UnityEngine.TextCore.Text.TextGenerationSettings settings, UnityEngine.TextCore.Text.TextInfo textInfo)
- private UnityEngine.Vector2 GetPreferredValuesInternal(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
- public static float GetPreferredWidth(UnityEngine.TextCore.Text.TextGenerationSettings settings, UnityEngine.TextCore.Text.TextInfo textInfo)
- private float GetPreferredWidthInternal(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
- protected void GetSpecialCharacters(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings)
- internal UnityEngine.TextCore.Text.TextElement GetTextElement(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, uint unicode, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, out bool isUsingAlternativeTypeface)
- private static UnityEngine.TextCore.Text.TextGenerator GetTextGenerator()
- protected void GetUnderlineSpecialCharacter(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings)
- private void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
- private void PopulateTextBackingArray(string sourceText)
- private void PopulateTextBackingArray(string sourceText, int start, int length)
- private void PopulateTextBackingArray(System.Text.StringBuilder sourceText, int start, int length)
- private void PopulateTextBackingArray(char[] sourceText, int start, int length)
- private void PopulateTextProcessingArray(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings)
- private void Prepare(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
- protected int RestoreWordWrappingState(ref UnityEngine.TextCore.Text.WordWrapState state, UnityEngine.TextCore.Text.TextInfo textInfo)
- private void SaveGlyphVertexInfo(float padding, float stylePadding, UnityEngine.Color32 vertexColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
- private void SaveSpriteVertexInfo(UnityEngine.Color32 vertexColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
- private void SaveWordWrappingState(ref UnityEngine.TextCore.Text.WordWrapState state, int index, int count, UnityEngine.TextCore.Text.TextInfo textInfo)
- internal int SetArraySizes(UnityEngine.TextCore.Text.TextProcessingElement[] textProcessingArray, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
- protected bool ValidateHtmlTag(UnityEngine.TextCore.Text.TextProcessingElement[] chars, int startIndex, out int endIndex, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)

### internal static class UnityEngine.TextCore.Text.TextGeneratorUtilities

#### Fields
- private static const int k_DoubleQuotes
- private static const int k_GreaterThan
- private static const string k_LookupStringU
- private static const int k_ZeroWidthSpace
- public static const float largeNegativeFloat
- public static readonly UnityEngine.Vector2 largeNegativeVector2
- public static const float largePositiveFloat
- public static readonly UnityEngine.Vector2 largePositiveVector2

#### Constructors
- private static TextGeneratorUtilities()

#### Methods
- public static void AdjustLineOffset(int startIndex, int endIndex, float offset, UnityEngine.TextCore.Text.TextInfo textInfo)
- public static bool Approximately(float a, float b)
- public static float ConvertToFloat(char[] chars, int startIndex, int length)
- public static float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex)
- public static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate)
- public static void FillCharacterVertexBuffers(int i, bool convertToLinearSpace, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
- public static void FillSpriteVertexBuffers(int i, bool convertToLinearSpace, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo)
- internal static UnityEngine.Color32 GammaToLinear(UnityEngine.Color32 c)
- private static byte GammaToLinear(byte value)
- public static int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters)
- public static int GetMarkupTagHashCode(UnityEngine.TextCore.Text.TextBackingContainer styleDefinition, int readIndex)
- public static int GetMarkupTagHashCode(uint[] styleDefinition, int readIndex)
- public static UnityEngine.TextCore.Text.TextStyle GetStyle(UnityEngine.TextCore.Text.TextGenerationSettings generationSetting, int hashCode)
- public static int GetStyleHashCode(ref uint[] text, int index, out int closeIndex)
- public static int GetStyleHashCode(ref UnityEngine.TextCore.Text.TextBackingContainer text, int index, out int closeIndex)
- private static int GetTagHashCode(ref int[] text, int index, out int closeIndex)
- private static int GetTagHashCode(ref string text, int index, out int closeIndex)
- public static uint GetUTF16(uint[] text, int i)
- public static uint GetUTF16(UnityEngine.TextCore.Text.TextBackingContainer text, int i)
- public static uint GetUTF32(uint[] text, int i)
- public static uint GetUTF32(UnityEngine.TextCore.Text.TextBackingContainer text, int i)
- public static UnityEngine.Color32 HexCharsToColor(char[] hexChars, int tagCount)
- public static UnityEngine.Color32 HexCharsToColor(char[] hexChars, int startIndex, int length)
- public static uint HexToInt(char hex)
- internal static void InsertClosingStyleTag(ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int>[] textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings)
- internal static void InsertClosingTextStyle(UnityEngine.TextCore.Text.TextStyle style, ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int>[] textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings)
- internal static void InsertOpeningStyleTag(UnityEngine.TextCore.Text.TextStyle style, ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int>[] textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings)
- internal static void InsertOpeningTextStyle(UnityEngine.TextCore.Text.TextStyle style, ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int>[] textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings)
- private static void InsertTextStyleInTextProcessingArray(ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, uint[] styleDefinition, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int>[] textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings)
- public static bool IsBaseGlyph(uint c)
- public static bool IsBitmapRendering(UnityEngine.TextCore.LowLevel.GlyphRenderMode glyphRenderMode)
- internal static bool IsCJK(uint c)
- internal static bool IsEmoji(uint c)
- internal static bool IsHangul(uint c)
- private static bool IsTagName(ref string text, string tag, int index)
- private static bool IsTagName(ref int[] text, string tag, int index)
- public static bool IsValidUTF16(UnityEngine.TextCore.Text.TextBackingContainer text, int index)
- public static bool IsValidUTF32(UnityEngine.TextCore.Text.TextBackingContainer text, int index)
- public static UnityEngine.TextCore.Text.TextAlignment LegacyAlignmentToNewAlignment(UnityEngine.TextAnchor anchor)
- public static UnityEngine.TextCore.Text.FontStyles LegacyStyleToNewStyle(UnityEngine.FontStyle fontStyle)
- public static UnityEngine.Color MinAlpha(UnityEngine.Color c1, UnityEngine.Color c2)
- public static UnityEngine.Vector2 PackUV(float x, float y, float scale)
- public static void ReplaceClosingStyleTag(ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int>[] textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings)
- public static bool ReplaceOpeningStyleTag(ref UnityEngine.TextCore.Text.TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int>[] textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings)
- public static void ReplaceOpeningStyleTag(ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int>[] textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings)
- private static bool ReplaceOpeningStyleTag(ref uint[] sourceText, int srcIndex, out int srcOffset, ref UnityEngine.TextCore.Text.TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref UnityEngine.TextCore.Text.TextProcessingStack<int>[] textStyleStacks, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings)
- public static void ResizeInternalArray<T>(ref T[] array)
- public static void ResizeInternalArray<T>(ref T[] array, int size)
- public static void ResizeLineExtents(int size, UnityEngine.TextCore.Text.TextInfo textInfo)
- public static char ToUpperASCIIFast(char c)
- public static uint ToUpperASCIIFast(uint c)
- public static char ToUpperFast(char c)

### internal class UnityEngine.TextCore.Text.TextHandle

#### Fields
- private bool isDirty
- private static UnityEngine.TextCore.Text.TextInfo m_LayoutTextInfo
- private UnityEngine.Vector2 m_PreferredSize
- private int m_PreviousGenerationSettingsHash
- private UnityEngine.TextCore.Text.TextInfo m_TextInfo
- protected static UnityEngine.TextCore.Text.TextGenerationSettings s_LayoutSettings
- protected UnityEngine.TextCore.Text.TextGenerationSettings textGenerationSettings

#### Properties
- internal static UnityEngine.TextCore.Text.TextInfo layoutTextInfo { get; }
- internal UnityEngine.TextCore.Text.TextInfo textInfo { get; }

#### Constructors
- public TextHandle()
- private static TextHandle()

#### Methods
- protected float ComputeTextHeight(UnityEngine.TextCore.Text.TextGenerationSettings tgs)
- protected float ComputeTextWidth(UnityEngine.TextCore.Text.TextGenerationSettings tgs)
- private static float DistanceToLine(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 point)
- public int FindIntersectingLink(UnityEngine.Vector3 position, bool inverseYAxis = true)
- public int FindNearestCharacterOnLine(UnityEngine.Vector2 position, int line, bool visibleOnly)
- public int FindNearestLine(UnityEngine.Vector2 position)
- public int FindWordIndex(int cursorIndex)
- public float GetCharacterHeightFromIndex(int index)
- public int GetCursorIndexFromPosition(UnityEngine.Vector2 position, bool inverseYAxis = true)
- public UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, bool inverseYAxis = true)
- public UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, bool useXAdvance = false, bool inverseYAxis = true)
- public float GetLineHeight(int lineNumber)
- public float GetLineHeightFromCharacterIndex(int index)
- public int GetLineNumber(int index)
- public int IndexOf(char value, int startIndex)
- public bool IsDirty()
- public bool IsElided()
- internal bool IsTextInfoAllocated()
- public int LastIndexOf(char value, int startIndex)
- public int LineDownCharacterPosition(int originalPos)
- public int LineUpCharacterPosition(int originalPos)
- private static bool PointIntersectRectangle(UnityEngine.Vector3 m, UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c, UnityEngine.Vector3 d)
- public void SetDirty()
- public string Substring(int startIndex, int length)
- internal UnityEngine.TextCore.Text.TextInfo Update(string newText)
- protected UnityEngine.TextCore.Text.TextInfo Update(UnityEngine.TextCore.Text.TextGenerationSettings tgs)
- protected void UpdatePreferredValues(UnityEngine.TextCore.Text.TextGenerationSettings tgs)

### internal class UnityEngine.TextCore.Text.TextInfo

#### Fields
- public int characterCount
- public bool hasMultipleColors
- public bool isDirty
- public int lineCount
- public UnityEngine.TextCore.Text.LineInfo[] lineInfo
- public int linkCount
- public UnityEngine.TextCore.Text.LinkInfo[] linkInfo
- public int materialCount
- public UnityEngine.TextCore.Text.MeshInfo[] meshInfo
- public int pageCount
- public UnityEngine.TextCore.Text.PageInfo[] pageInfo
- public int spaceCount
- public int spriteCount
- private static UnityEngine.Vector2 s_InfinityVectorNegative
- private static UnityEngine.Vector2 s_InfinityVectorPositive
- public UnityEngine.TextCore.Text.TextElementInfo[] textElementInfo
- public int wordCount
- public UnityEngine.TextCore.Text.WordInfo[] wordInfo

#### Constructors
- public TextInfo()
- private static TextInfo()

#### Methods
- internal void Clear()
- internal void ClearLineInfo()
- internal void ClearMeshInfo(bool updateMesh)
- internal void ClearPageInfo()
- internal static void Resize<T>(ref T[] array, int size)
- internal static void Resize<T>(ref T[] array, int size, bool isBlockAllocated)

### internal enum UnityEngine.TextCore.Text.TextInputSource
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- SetText = 1
- SetTextArray = 2
- TextInputBox = 0
- TextString = 3

### internal enum UnityEngine.TextCore.Text.TextOverflowMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Ellipsis = 1
- Linked = 6
- Masking = 2
- Overflow = 0
- Page = 5
- ScrollRect = 4
- Truncate = 3

### internal struct UnityEngine.TextCore.Text.TextProcessingElement

#### Fields
- public UnityEngine.TextCore.Text.TextProcessingElementType elementType
- public int length
- public int stringIndex
- public uint unicode

### internal enum UnityEngine.TextCore.Text.TextProcessingElementType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- TextCharacterElement = 1
- TextMarkupElement = 2
- Undefined = 0

### internal struct UnityEngine.TextCore.Text.TextProcessingStack<T>

#### Fields
- public int index
- public T[] itemStack
- private static const int k_DefaultCapacity
- private int m_Capacity
- private int m_Count
- private T m_DefaultItem
- private int m_RolloverSize

#### Properties
- public int Count { get; }
- public T current { get; }
- public int rolloverSize { get; set; }

#### Constructors
- public TextProcessingStack<T>(T[] stack)
- public TextProcessingStack<T>(int capacity)
- public TextProcessingStack<T>(int capacity, int rolloverSize)

#### Methods
- public void Add(T item)
- public void Clear()
- public T CurrentItem()
- public T Peek()
- public T Pop()
- public T PreviousItem()
- public void Push(T item)
- public T Remove()
- internal static void SetDefault(UnityEngine.TextCore.Text.TextProcessingStack<T>[] stack, T item)
- public void SetDefault(T item)

### internal class UnityEngine.TextCore.Text.TextResourceManager

#### Fields
- private static readonly int k_RegularStyleHashCode
- private static readonly System.Collections.Generic.Dictionary<long, UnityEngine.TextCore.Text.FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup
- private static readonly System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.FontAsset> s_FontAssetNameReferenceLookup
- private static readonly System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.TextResourceManager.FontAssetRef> s_FontAssetReferences
- private static readonly System.Collections.Generic.List<int> s_FontAssetRemovalList

#### Constructors
- public TextResourceManager()
- private static TextResourceManager()

#### Methods
- internal static void AddFontAsset(UnityEngine.TextCore.Text.FontAsset fontAsset)
- internal static void RebuildFontAssetCache()
- public static void RemoveFontAsset(UnityEngine.TextCore.Text.FontAsset fontAsset)
- internal static bool TryGetFontAssetByFamilyName(int familyNameHashCode, int styleNameHashCode, out UnityEngine.TextCore.Text.FontAsset fontAsset)
- internal static bool TryGetFontAssetByName(int nameHashcode, out UnityEngine.TextCore.Text.FontAsset fontAsset)

### public class UnityEngine.TextCore.Text.TextSettings
- Base: UnityEngine.ScriptableObject

#### Fields
- protected bool m_ClearDynamicDataOnBuild
- protected string m_DefaultColorGradientPresetsPath
- protected UnityEngine.TextCore.Text.FontAsset m_DefaultFontAsset
- protected string m_DefaultFontAssetPath
- protected UnityEngine.TextCore.Text.SpriteAsset m_DefaultSpriteAsset
- protected string m_DefaultSpriteAssetPath
- protected UnityEngine.TextCore.Text.TextStyleSheet m_DefaultStyleSheet
- protected bool m_DisplayWarnings
- protected System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> m_FallbackFontAssets
- protected System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> m_FallbackSpriteAssets
- internal System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.FontAsset> m_FontLookup
- private System.Collections.Generic.List<UnityEngine.TextCore.Text.TextSettings.FontReferenceMap> m_FontReferences
- protected bool m_MatchMaterialPreset
- protected int m_MissingCharacterUnicode
- protected uint m_MissingSpriteCharacterUnicode
- protected string m_StyleSheetsResourcePath
- protected UnityEngine.TextCore.Text.UnicodeLineBreakingRules m_UnicodeLineBreakingRules
- private bool m_UseModernHangulLineBreakingRules
- protected string m_Version

#### Properties
- public bool clearDynamicDataOnBuild { get; set; }
- public string defaultColorGradientPresetsPath { get; set; }
- public UnityEngine.TextCore.Text.FontAsset defaultFontAsset { get; set; }
- public string defaultFontAssetPath { get; set; }
- public UnityEngine.TextCore.Text.SpriteAsset defaultSpriteAsset { get; set; }
- public string defaultSpriteAssetPath { get; set; }
- public UnityEngine.TextCore.Text.TextStyleSheet defaultStyleSheet { get; set; }
- public bool displayWarnings { get; set; }
- public System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> fallbackFontAssets { get; set; }
- public System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> fallbackSpriteAssets { get; set; }
- public UnityEngine.TextCore.Text.UnicodeLineBreakingRules lineBreakingRules { get; set; }
- public bool matchMaterialPreset { get; set; }
- public int missingCharacterUnicode { get; set; }
- public uint missingSpriteCharacterUnicode { get; set; }
- public string styleSheetsResourcePath { get; set; }
- public bool useModernHangulLineBreakingRules { get; set; }
- public string version { get; internal set; }

#### Constructors
- public TextSettings()

#### Methods
- protected UnityEngine.TextCore.Text.FontAsset GetCachedFontAssetInternal(UnityEngine.Font font)
- protected void InitializeFontReferenceLookup()
- private void OnEnable()

### public static class UnityEngine.TextCore.Text.TextShaderUtilities

#### Fields
- public static int ID_BevelAmount
- public static int ID_ClipRect
- public static int ID_EnvMap
- public static int ID_EnvMatrix
- public static int ID_EnvMatrixRotation
- public static int ID_FaceColor
- public static int ID_FaceDilate
- public static int ID_FaceTex
- public static int ID_GlowColor
- public static int ID_GlowInner
- public static int ID_GlowOffset
- public static int ID_GlowOuter
- public static int ID_GlowPower
- public static int ID_GradientScale
- public static int ID_IsoPerimeter
- public static int ID_LightAngle
- public static int ID_MainTex
- public static int ID_MaskCoord
- public static int ID_MaskSoftnessX
- public static int ID_MaskSoftnessY
- public static int ID_Outline2Color
- public static int ID_Outline2Width
- public static int ID_OutlineColor
- public static int ID_OutlineMode
- public static int ID_OutlineOffset1
- public static int ID_OutlineOffset2
- public static int ID_OutlineOffset3
- public static int ID_OutlineSoftness
- public static int ID_OutlineTex
- public static int ID_OutlineWidth
- public static int ID_Padding
- public static int ID_PerspectiveFilter
- public static int ID_ScaleRatio_A
- public static int ID_ScaleRatio_B
- public static int ID_ScaleRatio_C
- public static int ID_ScaleX
- public static int ID_ScaleY
- public static int ID_ShaderFlags
- public static int ID_Sharpness
- public static int ID_Shininess
- public static int ID_Softness
- public static int ID_StencilComp
- public static int ID_StencilID
- public static int ID_StencilOp
- public static int ID_StencilReadMask
- public static int ID_StencilWriteMask
- public static int ID_TextureHeight
- public static int ID_TextureWidth
- public static int ID_UnderlayColor
- public static int ID_UnderlayDilate
- public static int ID_UnderlayIsoPerimeter
- public static int ID_UnderlayOffset
- public static int ID_UnderlayOffsetX
- public static int ID_UnderlayOffsetY
- public static int ID_UnderlaySoftness
- public static int ID_UseClipRect
- public static int ID_VertexOffsetX
- public static int ID_VertexOffsetY
- public static int ID_WeightBold
- public static int ID_WeightNormal
- public static bool isInitialized
- public static string Keyword_Bevel
- public static string Keyword_Glow
- public static string Keyword_MASK_HARD
- public static string Keyword_MASK_SOFT
- public static string Keyword_MASK_TEX
- public static string Keyword_Outline
- public static string Keyword_Ratios
- public static string Keyword_Underlay
- private static UnityEngine.Shader k_ShaderRef_MobileBitmap
- private static UnityEngine.Shader k_ShaderRef_MobileSDF
- private static UnityEngine.Shader k_ShaderRef_Sprite
- private static float m_clamp
- public static string ShaderTag_CullMode
- public static string ShaderTag_ZTestMode

#### Properties
- internal static UnityEngine.Shader ShaderRef_MobileBitmap { get; }
- internal static UnityEngine.Shader ShaderRef_MobileSDF { get; }
- internal static UnityEngine.Shader ShaderRef_Sprite { get; }

#### Constructors
- private static TextShaderUtilities()

#### Methods
- private static float ComputePaddingForProperties(UnityEngine.Material mat)
- internal static UnityEngine.Vector4 GetFontExtent(UnityEngine.Material material)
- internal static float GetPadding(UnityEngine.Material material, bool enableExtraPadding, bool isBold)
- internal static float GetPadding(UnityEngine.Material[] materials, bool enableExtraPadding, bool isBold)
- internal static void GetShaderPropertyIDs()
- internal static bool IsMaskingEnabled(UnityEngine.Material material)
- private static void UpdateShaderRatios(UnityEngine.Material mat)

### public class UnityEngine.TextCore.Text.TextStyle

#### Fields
- internal static UnityEngine.TextCore.Text.TextStyle k_NormalStyle
- private string m_ClosingDefinition
- private uint[] m_ClosingTagArray
- internal uint[] m_ClosingTagUnicodeArray
- private int m_HashCode
- private string m_Name
- private string m_OpeningDefinition
- private uint[] m_OpeningTagArray
- internal uint[] m_OpeningTagUnicodeArray

#### Properties
- public int hashCode { get; set; }
- public string name { get; set; }
- public static UnityEngine.TextCore.Text.TextStyle NormalStyle { get; }
- public string styleClosingDefinition { get; }
- public uint[] styleClosingTagArray { get; }
- public string styleOpeningDefinition { get; }
- public uint[] styleOpeningTagArray { get; }

#### Constructors
- internal TextStyle(string styleName, string styleOpeningDefinition, string styleClosingDefinition)

#### Methods
- public void RefreshStyle()

### public class UnityEngine.TextCore.Text.TextStyleSheet
- Base: UnityEngine.ScriptableObject

#### Fields
- private System.Collections.Generic.List<UnityEngine.TextCore.Text.TextStyle> m_StyleList
- private System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.TextStyle> m_StyleLookupDictionary

#### Properties
- internal System.Collections.Generic.List<UnityEngine.TextCore.Text.TextStyle> styles { get; }

#### Constructors
- public TextStyleSheet()

#### Methods
- public UnityEngine.TextCore.Text.TextStyle GetStyle(int hashCode)
- public UnityEngine.TextCore.Text.TextStyle GetStyle(string name)
- private void LoadStyleDictionaryInternal()
- public void RefreshStyles()
- private void Reset()

### internal enum UnityEngine.TextCore.Text.TextureMapping
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Character = 0
- Line = 1
- MatchAspect = 3
- Paragraph = 2

### internal static class UnityEngine.TextCore.Text.TextUtilities

#### Fields
- private static const string k_LookupStringL
- private static const string k_LookupStringU

#### Methods
- internal static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate)
- public static int GetHashCodeCaseInSensitive(string s)
- public static int GetHashCodeCaseSensitive(string s)
- public static uint GetSimpleHashCodeLowercase(string s)
- private static uint HexToInt(char hex)
- internal static int NextPowerOfTwo(int v)
- internal static uint ReadUTF16(uint[] text, int index)
- internal static uint ReadUTF32(uint[] text, int index)
- internal static void ResizeArray<T>(ref T[] array)
- internal static void ResizeArray<T>(ref T[] array, int size)
- public static uint StringHexToInt(string s)
- internal static uint ToLowerASCIIFast(uint c)
- internal static char ToLowerFast(char c)
- internal static uint ToUpperASCIIFast(uint c)
- internal static char ToUpperFast(char c)
- internal static string UintToString(System.Collections.Generic.List<uint> unicodes)

### internal struct UnityEngine.TextCore.Text.TextVertex

#### Fields
- public UnityEngine.Color32 color
- public UnityEngine.Vector3 position
- public UnityEngine.Vector4 uv
- public UnityEngine.Vector2 uv2

### internal enum UnityEngine.TextCore.Text.TextWrappingMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Normal = 1
- NoWrap = 0
- PreserveWhitespace = 2
- PreserveWhitespaceNoWrap = 3

### public class UnityEngine.TextCore.Text.UnicodeLineBreakingRules

#### Fields
- private UnityEngine.TextAsset m_FollowingCharacters
- private System.Collections.Generic.HashSet<uint> m_FollowingCharactersLookup
- private UnityEngine.TextAsset m_LeadingCharacters
- private System.Collections.Generic.HashSet<uint> m_LeadingCharactersLookup
- private UnityEngine.TextAsset m_UnicodeLineBreakingRules
- private bool m_UseModernHangulLineBreakingRules

#### Properties
- public UnityEngine.TextAsset followingCharacters { get; }
- internal System.Collections.Generic.HashSet<uint> followingCharactersLookup { get; set; }
- public UnityEngine.TextAsset leadingCharacters { get; }
- internal System.Collections.Generic.HashSet<uint> leadingCharactersLookup { get; set; }
- public UnityEngine.TextAsset lineBreakingRules { get; }
- public bool useModernHangulLineBreakingRules { get; set; }

#### Constructors
- public UnicodeLineBreakingRules()

#### Methods
- private static System.Collections.Generic.HashSet<uint> GetCharacters(UnityEngine.TextAsset file)
- internal void LoadLineBreakingRules()
- internal void LoadLineBreakingRules(UnityEngine.TextAsset leadingRules, UnityEngine.TextAsset followingRules)

### internal enum UnityEngine.TextCore.Text.VertexSortingOrder
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Normal = 0
- Reverse = 1

### internal enum UnityEngine.TextCore.Text.VerticalAlignment
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Baseline = 2048
- Bottom = 1024
- Capline = 8192
- Middle = 512
- Midline = 4096
- Top = 256

### internal struct UnityEngine.TextCore.Text.WordInfo

#### Fields
- public int characterCount
- public int firstCharacterIndex
- public int lastCharacterIndex

### internal struct UnityEngine.TextCore.Text.WordWrapState

#### Fields
- public UnityEngine.TextCore.Text.TextProcessingStack<int> actionStack
- public float baselineOffset
- public UnityEngine.TextCore.Text.TextProcessingStack<float> baselineStack
- public UnityEngine.TextCore.Text.FontStyleStack basicStyleStack
- public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextColorGradient> colorGradientStack
- public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> colorStack
- public UnityEngine.TextCore.Text.FontAsset currentFontAsset
- public float currentFontSize
- public UnityEngine.Material currentMaterial
- public int currentMaterialIndex
- public UnityEngine.TextCore.Text.SpriteAsset currentSpriteAsset
- public int firstCharacterIndex
- public int firstVisibleCharacterIndex
- public float fontScale
- public float fontScaleMultiplier
- public UnityEngine.TextCore.Text.FontStyles fontStyle
- public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextFontWeight> fontWeightStack
- public UnityEngine.Quaternion fxRotation
- public UnityEngine.Vector3 fxScale
- public UnityEngine.Color32 highlightColor
- public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> highlightColorStack
- public UnityEngine.TextCore.Text.HighlightState highlightState
- public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.HighlightState> highlightStateStack
- public UnityEngine.TextCore.Text.TextProcessingStack<float> indentStack
- public bool isDrivenLineSpacing
- public bool isNonBreakingSpace
- public int italicAngle
- public UnityEngine.TextCore.Text.TextProcessingStack<int> italicAngleStack
- public int lastBaseGlyphIndex
- public int lastCharacterIndex
- public int lastVisibleCharIndex
- public UnityEngine.TextCore.Text.LineInfo lineInfo
- public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextAlignment> lineJustificationStack
- public int lineNumber
- public float lineOffset
- public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.MaterialReference> materialReferenceStack
- public float maxAscender
- public float maxCapHeight
- public float maxDescender
- public float maxLineAscender
- public float maxLineDescender
- public UnityEngine.TextCore.Text.Extents meshExtents
- public float pageAscender
- public float preferredHeight
- public float preferredWidth
- public float previousLineScale
- public int previousWordBreak
- public UnityEngine.TextCore.Text.TextProcessingStack<float> sizeStack
- public int spriteAnimationId
- public float startOfLineAscender
- public UnityEngine.Color32 strikethroughColor
- public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> strikethroughColorStack
- public UnityEngine.TextCore.Text.TextProcessingStack<int> styleStack
- public bool tagNoParsing
- public UnityEngine.TextCore.Text.TextInfo textInfo
- public int totalCharacterCount
- public UnityEngine.Color32 underlineColor
- public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> underlineColorStack
- public UnityEngine.Color32 vertexColor
- public int visibleCharacterCount
- public int visibleLinkCount
- public int visibleSpaceCount
- public int visibleSpriteCount
- public int wordCount
- public float xAdvance

### internal struct UnityEngine.TextCore.Text.XmlTagAttribute

#### Fields
- public int nameHashCode
- public int valueHashCode
- public int valueLength
- public int valueStartIndex
- public UnityEngine.TextCore.Text.TagValueType valueType

