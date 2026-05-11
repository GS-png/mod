# Assembly: UnityEngine.TextCoreFontEngineModule
- Path: tools/WorldBox.Managed/UnityEngine.TextCoreFontEngineModule.dll
- Types: 43

## Namespace: UnityEngine.TextCore

### public struct UnityEngine.TextCore.FaceInfo

#### Fields
- private float m_AscentLine
- private float m_Baseline
- private float m_CapLine
- private float m_DescentLine
- private int m_FaceIndex
- private string m_FamilyName
- private float m_LineHeight
- private float m_MeanLine
- private int m_PointSize
- private float m_Scale
- private float m_StrikethroughOffset
- private float m_StrikethroughThickness
- private string m_StyleName
- private float m_SubscriptOffset
- private float m_SubscriptSize
- private float m_SuperscriptOffset
- private float m_SuperscriptSize
- private float m_TabWidth
- private float m_UnderlineOffset
- private float m_UnderlineThickness
- private int m_UnitsPerEM

#### Properties
- public float ascentLine { get; set; }
- public float baseline { get; set; }
- public float capLine { get; set; }
- public float descentLine { get; set; }
- internal int faceIndex { get; set; }
- public string familyName { get; set; }
- public float lineHeight { get; set; }
- public float meanLine { get; set; }
- public int pointSize { get; set; }
- public float scale { get; set; }
- public float strikethroughOffset { get; set; }
- public float strikethroughThickness { get; set; }
- public string styleName { get; set; }
- public float subscriptOffset { get; set; }
- public float subscriptSize { get; set; }
- public float superscriptOffset { get; set; }
- public float superscriptSize { get; set; }
- public float tabWidth { get; set; }
- public float underlineOffset { get; set; }
- public float underlineThickness { get; set; }
- internal int unitsPerEM { get; set; }

#### Constructors
- internal FaceInfo(string familyName, string styleName, int pointSize, float scale, int unitsPerEM, float lineHeight, float ascentLine, float capLine, float meanLine, float baseline, float descentLine, float superscriptOffset, float superscriptSize, float subscriptOffset, float subscriptSize, float underlineOffset, float underlineThickness, float strikethroughOffset, float strikethroughThickness, float tabWidth)

#### Methods
- public bool Compare(UnityEngine.TextCore.FaceInfo other)

### public class UnityEngine.TextCore.Glyph

#### Fields
- private int m_AtlasIndex
- private UnityEngine.TextCore.GlyphClassDefinitionType m_ClassDefinitionType
- private UnityEngine.TextCore.GlyphRect m_GlyphRect
- private uint m_Index
- private UnityEngine.TextCore.GlyphMetrics m_Metrics
- private float m_Scale

#### Properties
- public int atlasIndex { get; set; }
- public UnityEngine.TextCore.GlyphClassDefinitionType classDefinitionType { get; set; }
- public UnityEngine.TextCore.GlyphRect glyphRect { get; set; }
- public uint index { get; set; }
- public UnityEngine.TextCore.GlyphMetrics metrics { get; set; }
- public float scale { get; set; }

#### Constructors
- public Glyph()
- public Glyph(UnityEngine.TextCore.Glyph glyph)
- internal Glyph(UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct)
- public Glyph(uint index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect)
- public Glyph(uint index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, float scale, int atlasIndex)

#### Methods
- public bool Compare(UnityEngine.TextCore.Glyph other)

### public enum UnityEngine.TextCore.GlyphClassDefinitionType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Base = 1
- Component = 4
- Ligature = 2
- Mark = 3
- Undefined = 0

### public struct UnityEngine.TextCore.GlyphMetrics
- Interfaces: System.IEquatable<UnityEngine.TextCore.GlyphMetrics>

#### Fields
- private float m_Height
- private float m_HorizontalAdvance
- private float m_HorizontalBearingX
- private float m_HorizontalBearingY
- private float m_Width

#### Properties
- public float height { get; set; }
- public float horizontalAdvance { get; set; }
- public float horizontalBearingX { get; set; }
- public float horizontalBearingY { get; set; }
- public float width { get; set; }

#### Constructors
- public GlyphMetrics(float width, float height, float bearingX, float bearingY, float advance)

#### Methods
- public override bool Equals(object obj)
- public bool Equals(UnityEngine.TextCore.GlyphMetrics other)
- public override int GetHashCode()
- public static bool op_Equality(UnityEngine.TextCore.GlyphMetrics lhs, UnityEngine.TextCore.GlyphMetrics rhs)
- public static bool op_Inequality(UnityEngine.TextCore.GlyphMetrics lhs, UnityEngine.TextCore.GlyphMetrics rhs)

### public struct UnityEngine.TextCore.GlyphRect
- Interfaces: System.IEquatable<UnityEngine.TextCore.GlyphRect>

#### Fields
- private int m_Height
- private int m_Width
- private int m_X
- private int m_Y
- private static readonly UnityEngine.TextCore.GlyphRect s_ZeroGlyphRect

#### Properties
- public int height { get; set; }
- public int width { get; set; }
- public int x { get; set; }
- public int y { get; set; }
- public static UnityEngine.TextCore.GlyphRect zero { get; }

#### Constructors
- private static GlyphRect()
- public GlyphRect(UnityEngine.Rect rect)
- public GlyphRect(int x, int y, int width, int height)

#### Methods
- public override bool Equals(object obj)
- public bool Equals(UnityEngine.TextCore.GlyphRect other)
- public override int GetHashCode()
- public static bool op_Equality(UnityEngine.TextCore.GlyphRect lhs, UnityEngine.TextCore.GlyphRect rhs)
- public static bool op_Inequality(UnityEngine.TextCore.GlyphRect lhs, UnityEngine.TextCore.GlyphRect rhs)

## Namespace: UnityEngine.TextCore.LowLevel

### internal struct UnityEngine.TextCore.LowLevel.AlternateSubstitutionRecord

#### Fields
- private uint[] m_SubstituteGlyphIDs
- private uint m_TargetGlyphID

#### Properties
- public uint[] substituteGlyphIDs { get; set; }
- public uint targetGlyphID { get; set; }

### internal struct UnityEngine.TextCore.LowLevel.ChainingContextualSubstitutionRecord

#### Fields
- private UnityEngine.TextCore.LowLevel.GlyphIDSequence[] m_BacktrackGlyphSequences
- private UnityEngine.TextCore.LowLevel.GlyphIDSequence[] m_InputGlyphSequences
- private UnityEngine.TextCore.LowLevel.GlyphIDSequence[] m_LookaheadGlyphSequences
- private UnityEngine.TextCore.LowLevel.SequenceLookupRecord[] m_SequenceLookupRecords

#### Properties
- public UnityEngine.TextCore.LowLevel.GlyphIDSequence[] backtrackGlyphSequences { get; set; }
- public UnityEngine.TextCore.LowLevel.GlyphIDSequence[] inputGlyphSequences { get; set; }
- public UnityEngine.TextCore.LowLevel.GlyphIDSequence[] lookaheadGlyphSequences { get; set; }
- public UnityEngine.TextCore.LowLevel.SequenceLookupRecord[] sequenceLookupRecords { get; set; }

### internal struct UnityEngine.TextCore.LowLevel.ContextualSubstitutionRecord

#### Fields
- private UnityEngine.TextCore.LowLevel.GlyphIDSequence[] m_InputGlyphSequences
- private UnityEngine.TextCore.LowLevel.SequenceLookupRecord[] m_SequenceLookupRecords

#### Properties
- public UnityEngine.TextCore.LowLevel.GlyphIDSequence[] inputSequences { get; set; }
- public UnityEngine.TextCore.LowLevel.SequenceLookupRecord[] sequenceLookupRecords { get; set; }

### public class UnityEngine.TextCore.LowLevel.FontEngine

#### Fields
- private static UnityEngine.TextCore.LowLevel.AlternateSubstitutionRecord[] s_AlternateSubstitutionRecords_MarshallingArray
- private static UnityEngine.TextCore.LowLevel.ChainingContextualSubstitutionRecord[] s_ChainingContextualSubstitutionRecords_MarshallingArray
- private static UnityEngine.TextCore.LowLevel.ContextualSubstitutionRecord[] s_ContextualSubstitutionRecords_MarshallingArray
- private static UnityEngine.TextCore.GlyphRect[] s_FreeGlyphRects
- private static uint[] s_GlyphIndexes_MarshallingArray_A
- private static uint[] s_GlyphIndexes_MarshallingArray_B
- private static System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Glyph> s_GlyphLookupDictionary
- private static UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN
- private static UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT
- private static UnityEngine.TextCore.Glyph[] s_Glyphs
- private static UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] s_LigatureSubstitutionRecords_MarshallingArray
- private static UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord[] s_MarkToBaseAdjustmentRecords_MarshallingArray
- private static UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord[] s_MarkToMarkAdjustmentRecords_MarshallingArray
- private static UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord[] s_MultipleSubstitutionRecords_MarshallingArray
- private static UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray
- private static UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord[] s_SingleAdjustmentRecords_MarshallingArray
- private static UnityEngine.TextCore.LowLevel.SingleSubstitutionRecord[] s_SingleSubstitutionRecords_MarshallingArray
- private static UnityEngine.TextCore.GlyphRect[] s_UsedGlyphRects

#### Properties
- internal static float generationProgress { get; }
- internal static bool isProcessingDone { get; }

#### Constructors
- internal FontEngine()
- private static FontEngine()

#### Methods
- public static UnityEngine.TextCore.LowLevel.FontEngineError DestroyFontEngine()
- private static int DestroyFontEngine_Internal()
- private static void GenericListToMarshallingArray<T>(ref System.Collections.Generic.List<T> srcList, ref T[] dstArray)
- internal static UnityEngine.TextCore.LowLevel.AlternateSubstitutionRecord[] GetAllAlternateSubstitutionRecords()
- internal static UnityEngine.TextCore.LowLevel.ChainingContextualSubstitutionRecord[] GetAllChainingContextualSubstitutionRecords()
- internal static UnityEngine.TextCore.LowLevel.ContextualSubstitutionRecord[] GetAllContextualSubstitutionRecords()
- internal static UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] GetAllLigatureSubstitutionRecords()
- internal static UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord[] GetAllMarkToBaseAdjustmentRecords()
- internal static UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord[] GetAllMarkToMarkAdjustmentRecords()
- internal static UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord[] GetAllMultipleSubstitutionRecords()
- internal static UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetAllPairAdjustmentRecords()
- internal static UnityEngine.TextCore.LowLevel.SingleSubstitutionRecord[] GetAllSingleSubstitutionRecords()
- internal static UnityEngine.TextCore.LowLevel.AlternateSubstitutionRecord[] GetAlternateSubstitutionRecords(int lookupIndex, uint glyphIndex)
- internal static UnityEngine.TextCore.LowLevel.AlternateSubstitutionRecord[] GetAlternateSubstitutionRecords(int lookupIndex, System.Collections.Generic.List<uint> glyphIndexes)
- private static UnityEngine.TextCore.LowLevel.AlternateSubstitutionRecord[] GetAlternateSubstitutionRecords(int lookupIndex, uint[] glyphIndexes)
- private static int GetAlternateSubstitutionRecordsFromMarshallingArray(UnityEngine.TextCore.LowLevel.AlternateSubstitutionRecord[] singleSubstitutionRecords)
- internal static UnityEngine.TextCore.LowLevel.ChainingContextualSubstitutionRecord[] GetChainingContextualSubstitutionRecords(int lookupIndex, uint glyphIndex)
- internal static UnityEngine.TextCore.LowLevel.ChainingContextualSubstitutionRecord[] GetChainingContextualSubstitutionRecords(int lookupIndex, System.Collections.Generic.List<uint> glyphIndexes)
- private static UnityEngine.TextCore.LowLevel.ChainingContextualSubstitutionRecord[] GetChainingContextualSubstitutionRecords(int lookupIndex, uint[] glyphIndexes)
- private static int GetChainingContextualSubstitutionRecordsFromMarshallingArray(UnityEngine.TextCore.LowLevel.ChainingContextualSubstitutionRecord[] substitutionRecords)
- internal static UnityEngine.TextCore.LowLevel.ContextualSubstitutionRecord[] GetContextualSubstitutionRecords(int lookupIndex, uint glyphIndex)
- internal static UnityEngine.TextCore.LowLevel.ContextualSubstitutionRecord[] GetContextualSubstitutionRecords(int lookupIndex, System.Collections.Generic.List<uint> glyphIndexes)
- private static UnityEngine.TextCore.LowLevel.ContextualSubstitutionRecord[] GetContextualSubstitutionRecords(int lookupIndex, uint[] glyphIndexes)
- private static int GetContextualSubstitutionRecordsFromMarshallingArray(UnityEngine.TextCore.LowLevel.ContextualSubstitutionRecord[] substitutionRecords)
- internal static int GetFaceCount()
- public static UnityEngine.TextCore.FaceInfo GetFaceInfo()
- private static int GetFaceInfo_Internal(ref UnityEngine.TextCore.FaceInfo faceInfo)
- public static string[] GetFontFaces()
- private static string[] GetFontFaces_Internal()
- internal static uint GetGlyphIndex(uint unicode)
- internal static UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord GetGlyphPairAdjustmentRecord(uint firstGlyphIndex, uint secondGlyphIndex)
- internal static UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(System.Collections.Generic.List<uint> glyphIndexes, out int recordCount)
- internal static UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(uint glyphIndex, out int recordCount)
- internal static UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(System.Collections.Generic.List<uint> newGlyphIndexes, System.Collections.Generic.List<uint> allGlyphIndexes)
- private static void GetGlyphPairAdjustmentRecord_Injected(uint firstGlyphIndex, uint secondGlyphIndex, out UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord ret)
- internal static UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes)
- internal static UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(uint glyphIndex)
- internal static UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(System.Collections.Generic.List<uint> glyphIndexes)
- internal static UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(int lookupIndex, uint glyphIndex)
- internal static UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(int lookupIndex, System.Collections.Generic.List<uint> glyphIndexes)
- private static UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(uint[] glyphIndexes)
- private static UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(int lookupIndex, uint[] glyphIndexes)
- private static int GetLigatureSubstitutionRecordsFromMarshallingArray(UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] ligatureSubstitutionRecords)
- internal static UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord GetMarkToBaseAdjustmentRecord(uint baseGlyphIndex, uint markGlyphIndex)
- internal static UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(uint baseGlyphIndex)
- internal static UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(System.Collections.Generic.List<uint> glyphIndexes)
- internal static UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(int lookupIndex, System.Collections.Generic.List<uint> glyphIndexes)
- private static UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(uint[] glyphIndexes)
- private static UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(int lookupIndex, uint[] glyphIndexes)
- private static int GetMarkToBaseAdjustmentRecordsFromMarshallingArray(UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord[] adjustmentRecords)
- private static void GetMarkToBaseAdjustmentRecord_Injected(uint baseGlyphIndex, uint markGlyphIndex, out UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord ret)
- internal static UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord GetMarkToMarkAdjustmentRecord(uint firstGlyphIndex, uint secondGlyphIndex)
- internal static UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(uint baseMarkGlyphIndex)
- internal static UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(System.Collections.Generic.List<uint> glyphIndexes)
- internal static UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(int lookupIndex, System.Collections.Generic.List<uint> glyphIndexes)
- private static UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(uint[] glyphIndexes)
- private static UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(int lookupIndex, uint[] glyphIndexes)
- private static int GetMarkToMarkAdjustmentRecordsFromMarshallingArray(UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord[] adjustmentRecords)
- private static void GetMarkToMarkAdjustmentRecord_Injected(uint firstGlyphIndex, uint secondGlyphIndex, out UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord ret)
- internal static UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord[] GetMultipleSubstitutionRecords(int lookupIndex, uint glyphIndex)
- internal static UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord[] GetMultipleSubstitutionRecords(int lookupIndex, System.Collections.Generic.List<uint> glyphIndexes)
- private static UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord[] GetMultipleSubstitutionRecords(int lookupIndex, uint[] glyphIndexes)
- private static int GetMultipleSubstitutionRecordsFromMarshallingArray(UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord[] substitutionRecords)
- internal static UnityEngine.TextCore.LowLevel.OpenTypeFeature[] GetOpenTypeFontFeatureList()
- internal static UnityEngine.TextCore.LowLevel.OTL_Feature[] GetOpenTypeLayoutFeatures()
- internal static UnityEngine.TextCore.LowLevel.OTL_Lookup[] GetOpenTypeLayoutLookups()
- internal static UnityEngine.TextCore.LowLevel.OTL_Script[] GetOpenTypeLayoutScripts()
- internal static UnityEngine.TextCore.LowLevel.OTL_Table GetOpenTypeLayoutTable(UnityEngine.TextCore.LowLevel.OTL_TableType type)
- private static void GetOpenTypeLayoutTable_Injected(UnityEngine.TextCore.LowLevel.OTL_TableType type, out UnityEngine.TextCore.LowLevel.OTL_Table ret)
- internal static UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord GetPairAdjustmentRecord(uint firstGlyphIndex, uint secondGlyphIndex)
- internal static UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(uint glyphIndex)
- internal static UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(System.Collections.Generic.List<uint> glyphIndexes)
- internal static UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(int lookupIndex, uint glyphIndex)
- internal static UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(int lookupIndex, System.Collections.Generic.List<uint> glyphIndexes)
- private static UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(uint[] glyphIndexes)
- private static UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(int lookupIndex, uint[] glyphIndexes)
- private static int GetPairAdjustmentRecordsFromMarshallingArray(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords)
- private static void GetPairAdjustmentRecord_Injected(uint firstGlyphIndex, uint secondGlyphIndex, out UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord ret)
- internal static UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord[] GetSingleAdjustmentRecords(int lookupIndex, uint glyphIndex)
- internal static UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord[] GetSingleAdjustmentRecords(int lookupIndex, System.Collections.Generic.List<uint> glyphIndexes)
- private static UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord[] GetSingleAdjustmentRecords(int lookupIndex, uint[] glyphIndexes)
- private static int GetSingleAdjustmentRecordsFromMarshallingArray(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord[] singleSubstitutionRecords)
- internal static UnityEngine.TextCore.LowLevel.SingleSubstitutionRecord[] GetSingleSubstitutionRecords(int lookupIndex, uint glyphIndex)
- internal static UnityEngine.TextCore.LowLevel.SingleSubstitutionRecord[] GetSingleSubstitutionRecords(int lookupIndex, System.Collections.Generic.List<uint> glyphIndexes)
- private static UnityEngine.TextCore.LowLevel.SingleSubstitutionRecord[] GetSingleSubstitutionRecords(int lookupIndex, uint[] glyphIndexes)
- private static int GetSingleSubstitutionRecordsFromMarshallingArray(UnityEngine.TextCore.LowLevel.SingleSubstitutionRecord[] singleSubstitutionRecords)
- public static string[] GetSystemFontNames()
- private static string[] GetSystemFontNames_Internal()
- internal static UnityEngine.TextCore.LowLevel.FontReference[] GetSystemFontReferences()
- internal static uint GetVariantGlyphIndex(uint unicode, uint variantSelectorUnicode)
- private static void GlyphIndexToMarshallingArray(uint glyphIndex, ref uint[] dstArray)
- public static UnityEngine.TextCore.LowLevel.FontEngineError InitializeFontEngine()
- private static int InitializeFontEngine_Internal()
- public static UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(string filePath)
- public static UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(string filePath, int pointSize)
- public static UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(string filePath, int pointSize, int faceIndex)
- public static UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(byte[] sourceFontFile)
- public static UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(byte[] sourceFontFile, int pointSize)
- public static UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(byte[] sourceFontFile, int pointSize, int faceIndex)
- public static UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(UnityEngine.Font font)
- public static UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(UnityEngine.Font font, int pointSize)
- public static UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(UnityEngine.Font font, int pointSize, int faceIndex)
- public static UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(string familyName, string styleName)
- public static UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(string familyName, string styleName, int pointSize)
- private static int LoadFontFace_by_FamilyName_and_StyleName_Internal(string familyName, string styleName)
- private static int LoadFontFace_FromFont_Internal(UnityEngine.Font font)
- private static int LoadFontFace_FromSourceFontFile_Internal(byte[] sourceFontFile)
- private static int LoadFontFace_Internal(string filePath)
- private static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(UnityEngine.Font font, int pointSize, int faceIndex)
- private static int LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_Internal(byte[] sourceFontFile, int pointSize, int faceIndex)
- private static int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex)
- private static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize)
- private static int LoadFontFace_With_Size_FromFont_Internal(UnityEngine.Font font, int pointSize)
- private static int LoadFontFace_With_Size_FromSourceFontFile_Internal(byte[] sourceFontFile, int pointSize)
- private static int LoadFontFace_With_Size_Internal(string filePath, int pointSize)
- internal static UnityEngine.TextCore.LowLevel.FontEngineError LoadGlyph(uint unicode, UnityEngine.TextCore.LowLevel.GlyphLoadFlags flags)
- private static int LoadGlyph_Internal(uint unicode, UnityEngine.TextCore.LowLevel.GlyphLoadFlags loadFlags)
- private static int PopulateAlternateSubstitutionRecordMarshallingArray_from_GlyphIndexes(uint[] glyphIndexes, int lookupIndex, out int recordCount)
- private static int PopulateChainingContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes(uint[] glyphIndexes, int lookupIndex, out int recordCount)
- private static int PopulateContextualSubstitutionRecordMarshallingArray_from_GlyphIndexes(uint[] glyphIndexes, int lookupIndex, out int recordCount)
- private static int PopulateLigatureSubstitutionRecordMarshallingArray(uint[] glyphIndexes, out int recordCount)
- private static int PopulateLigatureSubstitutionRecordMarshallingArray_for_LookupIndex(uint[] glyphIndexes, int lookupIndex, out int recordCount)
- private static int PopulateMarkToBaseAdjustmentRecordMarshallingArray(uint[] glyphIndexes, out int recordCount)
- private static int PopulateMarkToBaseAdjustmentRecordMarshallingArray_for_LookupIndex(uint[] glyphIndexes, int lookupIndex, out int recordCount)
- private static int PopulateMarkToMarkAdjustmentRecordMarshallingArray(uint[] glyphIndexes, out int recordCount)
- private static int PopulateMarkToMarkAdjustmentRecordMarshallingArray_for_LookupIndex(uint[] glyphIndexes, int lookupIndex, out int recordCount)
- private static int PopulateMultipleSubstitutionRecordMarshallingArray_from_GlyphIndexes(uint[] glyphIndexes, int lookupIndex, out int recordCount)
- private static int PopulatePairAdjustmentRecordMarshallingArray(uint[] glyphIndexes, out int recordCount)
- private static int PopulatePairAdjustmentRecordMarshallingArray_for_LookupIndex(uint[] glyphIndexes, int lookupIndex, out int recordCount)
- private static int PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexes(uint[] newGlyphIndexes, uint[] allGlyphIndexes, out int recordCount)
- private static int PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndex(uint glyphIndex, out int recordCount)
- private static int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(uint[] glyphIndexes, out int recordCount)
- private static int PopulateSingleAdjustmentRecordMarshallingArray_from_GlyphIndexes(uint[] glyphIndexes, int lookupIndex, out int recordCount)
- private static int PopulateSingleSubstitutionRecordMarshallingArray_from_GlyphIndexes(uint[] glyphIndexes, int lookupIndex, out int recordCount)
- internal static void ReleaseSharedTexture()
- internal static void RenderBufferToTexture(UnityEngine.Texture2D srcTexture, int padding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D dstTexture)
- internal static UnityEngine.TextCore.LowLevel.FontEngineError RenderGlyphsToSharedTexture(System.Collections.Generic.List<UnityEngine.TextCore.Glyph> glyphs, int padding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode)
- private static int RenderGlyphsToSharedTexture_Internal(UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] glyphs, int glyphCount, int padding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode)
- internal static UnityEngine.TextCore.LowLevel.FontEngineError RenderGlyphsToTexture(System.Collections.Generic.List<UnityEngine.TextCore.Glyph> glyphs, int padding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture)
- internal static UnityEngine.TextCore.LowLevel.FontEngineError RenderGlyphsToTexture(System.Collections.Generic.List<UnityEngine.TextCore.Glyph> glyphs, int padding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, byte[] texBuffer, int texWidth, int texHeight)
- private static int RenderGlyphsToTextureBuffer_Internal(UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] glyphs, int glyphCount, int padding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, byte[] texBuffer, int texWidth, int texHeight)
- private static int RenderGlyphsToTexture_Internal(UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] glyphs, int glyphCount, int padding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture)
- internal static UnityEngine.TextCore.LowLevel.FontEngineError RenderGlyphToTexture(UnityEngine.TextCore.Glyph glyph, int padding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture)
- private static int RenderGlyphToTexture_Internal(UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct, int padding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture)
- private static int RenderGlyphToTexture_Internal_Injected(ref UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct, int padding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture)
- internal static void ResetAtlasTexture(UnityEngine.Texture2D texture)
- internal static void SendCancellationRequest()
- private static void SendCancellationRequest_Internal()
- public static UnityEngine.TextCore.LowLevel.FontEngineError SetFaceSize(int pointSize)
- private static int SetFaceSize_Internal(int pointSize)
- private static void SetMarshallingArraySize<T>(ref T[] marshallingArray, int recordCount)
- internal static void SetSharedTexture(UnityEngine.Texture2D texture)
- internal static void SetTextureUploadMode(bool shouldUploadImmediately)
- internal static bool TryAddGlyphsToTexture(System.Collections.Generic.List<UnityEngine.TextCore.Glyph> glyphsToAdd, System.Collections.Generic.List<UnityEngine.TextCore.Glyph> glyphsAdded, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture)
- internal static bool TryAddGlyphsToTexture(System.Collections.Generic.List<uint> glyphIndexes, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, out UnityEngine.TextCore.Glyph[] glyphs)
- private static bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, UnityEngine.TextCore.GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, UnityEngine.TextCore.GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] glyphs, ref int glyphCount)
- private static bool TryAddGlyphsToTexture_Internal_MultiThread(UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] glyphsToAdd, ref int glyphsToAddCount, UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] glyphsAdded, ref int glyphsAddedCount, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, UnityEngine.TextCore.GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, UnityEngine.TextCore.GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture)
- internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, out UnityEngine.TextCore.Glyph glyph)
- private static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, UnityEngine.TextCore.GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, UnityEngine.TextCore.GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, out UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyph)
- public static bool TryGetGlyphIndex(uint unicode, out uint glyphIndex)
- public static bool TryGetGlyphWithIndexValue(uint glyphIndex, UnityEngine.TextCore.LowLevel.GlyphLoadFlags flags, out UnityEngine.TextCore.Glyph glyph)
- private static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, UnityEngine.TextCore.LowLevel.GlyphLoadFlags loadFlags, ref UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct)
- public static bool TryGetGlyphWithUnicodeValue(uint unicode, UnityEngine.TextCore.LowLevel.GlyphLoadFlags flags, out UnityEngine.TextCore.Glyph glyph)
- private static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, UnityEngine.TextCore.LowLevel.GlyphLoadFlags loadFlags, ref UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct)
- internal static bool TryGetSystemFontReference(string familyName, string styleName, out UnityEngine.TextCore.LowLevel.FontReference fontRef)
- private static bool TryGetSystemFontReference_Internal(string familyName, string styleName, out UnityEngine.TextCore.LowLevel.FontReference fontRef)
- internal static bool TryPackGlyphInAtlas(UnityEngine.TextCore.Glyph glyph, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int width, int height, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects)
- private static bool TryPackGlyphInAtlas_Internal(ref UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyph, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int width, int height, UnityEngine.TextCore.GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, UnityEngine.TextCore.GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount)
- internal static bool TryPackGlyphsInAtlas(System.Collections.Generic.List<UnityEngine.TextCore.Glyph> glyphsToAdd, System.Collections.Generic.List<UnityEngine.TextCore.Glyph> glyphsAdded, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int width, int height, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects)
- private static bool TryPackGlyphsInAtlas_Internal(UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] glyphsToAdd, ref int glyphsToAddCount, UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] glyphsAdded, ref int glyphsAddedCount, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int width, int height, UnityEngine.TextCore.GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, UnityEngine.TextCore.GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount)
- public static UnityEngine.TextCore.LowLevel.FontEngineError UnloadAllFontFaces()
- private static int UnloadAllFontFaces_Internal()
- public static UnityEngine.TextCore.LowLevel.FontEngineError UnloadFontFace()
- private static int UnloadFontFace_Internal()

### public enum UnityEngine.TextCore.LowLevel.FontEngineError
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Atlas_Generation_Cancelled = 100
- Invalid_Character_Code = 17
- Invalid_Face = 35
- Invalid_File = 4
- Invalid_File_Format = 2
- Invalid_File_Path = 1
- Invalid_File_Structure = 3
- Invalid_Glyph_Index = 16
- Invalid_Library = 33
- Invalid_Library_or_Face = 41
- Invalid_Pixel_Size = 23
- Invalid_SharedTextureData = 101
- Invalid_Table = 8
- OpenTypeLayoutLookup_Mismatch = 116
- Success = 0

### internal struct UnityEngine.TextCore.LowLevel.FontEngineUtilities

#### Methods
- internal static bool Approximately(float a, float b)
- internal static int MaxValue(int a, int b, int c)

### public enum UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- IgnoreLigatures = 4
- IgnoreSpacingAdjustments = 256
- None = 0

### internal struct UnityEngine.TextCore.LowLevel.FontReference

#### Fields
- public int faceIndex
- public string familyName
- public string filePath
- public string styleName

### public struct UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord
- Interfaces: System.IEquatable<UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord>

#### Fields
- private uint m_GlyphIndex
- private UnityEngine.TextCore.LowLevel.GlyphValueRecord m_GlyphValueRecord

#### Properties
- public uint glyphIndex { get; set; }
- public UnityEngine.TextCore.LowLevel.GlyphValueRecord glyphValueRecord { get; set; }

#### Constructors
- public GlyphAdjustmentRecord(uint glyphIndex, UnityEngine.TextCore.LowLevel.GlyphValueRecord glyphValueRecord)

#### Methods
- public override bool Equals(object obj)
- public bool Equals(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord other)
- public override int GetHashCode()
- public static bool op_Equality(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord lhs, UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord rhs)
- public static bool op_Inequality(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord lhs, UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord rhs)

### internal struct UnityEngine.TextCore.LowLevel.GlyphAnchorPoint

#### Fields
- private float m_XCoordinate
- private float m_YCoordinate

#### Properties
- public float xCoordinate { get; set; }
- public float yCoordinate { get; set; }

### internal struct UnityEngine.TextCore.LowLevel.GlyphIDSequence

#### Fields
- private uint[] m_GlyphIDs

#### Properties
- public uint[] glyphIDs { get; set; }

### public enum UnityEngine.TextCore.LowLevel.GlyphLoadFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- LOAD_BITMAP_METRICS_ONLY = 4194304
- LOAD_COLOR = 1048576
- LOAD_COMPUTE_METRICS = 2097152
- LOAD_DEFAULT = 0
- LOAD_FORCE_AUTOHINT = 32
- LOAD_MONOCHROME = 4096
- LOAD_NO_AUTOHINT = 32768
- LOAD_NO_BITMAP = 8
- LOAD_NO_HINTING = 2
- LOAD_NO_SCALE = 1
- LOAD_RENDER = 4

### internal struct UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct

#### Fields
- public int atlasIndex
- public UnityEngine.TextCore.GlyphClassDefinitionType classDefinitionType
- public UnityEngine.TextCore.GlyphRect glyphRect
- public uint index
- public UnityEngine.TextCore.GlyphMetrics metrics
- public float scale

#### Constructors
- public GlyphMarshallingStruct(UnityEngine.TextCore.Glyph glyph)
- public GlyphMarshallingStruct(uint index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, float scale, int atlasIndex)
- public GlyphMarshallingStruct(uint index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, float scale, int atlasIndex, UnityEngine.TextCore.GlyphClassDefinitionType classDefinitionType)

### public enum UnityEngine.TextCore.LowLevel.GlyphPackingMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BestAreaFit = 2
- BestLongSideFit = 1
- BestShortSideFit = 0
- BottomLeftRule = 3
- ContactPointRule = 4

### public struct UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord
- Interfaces: System.IEquatable<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>

#### Fields
- private UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags m_FeatureLookupFlags
- private UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord m_FirstAdjustmentRecord
- private UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord m_SecondAdjustmentRecord

#### Properties
- public UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags featureLookupFlags { get; set; }
- public UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord firstAdjustmentRecord { get; set; }
- public UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord secondAdjustmentRecord { get; set; }

#### Constructors
- public GlyphPairAdjustmentRecord(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord firstAdjustmentRecord, UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord secondAdjustmentRecord)

#### Methods
- public override bool Equals(object obj)
- public bool Equals(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord other)
- public override int GetHashCode()
- public static bool op_Equality(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord lhs, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord rhs)
- public static bool op_Inequality(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord lhs, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord rhs)

### internal enum UnityEngine.TextCore.LowLevel.GlyphRasterModes
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- RASTER_MODE_16X = 16384
- RASTER_MODE_1X = 4096
- RASTER_MODE_32X = 32768
- RASTER_MODE_8BIT = 1
- RASTER_MODE_8X = 8192
- RASTER_MODE_BITMAP = 16
- RASTER_MODE_COLOR = 65536
- RASTER_MODE_HINTED = 8
- RASTER_MODE_MONO = 2
- RASTER_MODE_MSDF = 256
- RASTER_MODE_MSDFA = 512
- RASTER_MODE_NO_HINTING = 4
- RASTER_MODE_SDF = 32
- RASTER_MODE_SDFAA = 64

### public enum UnityEngine.TextCore.LowLevel.GlyphRenderMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- COLOR = 69652
- COLOR_HINTED = 69656
- RASTER = 4118
- RASTER_HINTED = 4122
- SDF = 4134
- SDF16 = 16422
- SDF32 = 32806
- SDF8 = 8230
- SDFAA = 4165
- SDFAA_HINTED = 4169
- SMOOTH = 4117
- SMOOTH_HINTED = 4121

### public struct UnityEngine.TextCore.LowLevel.GlyphValueRecord
- Interfaces: System.IEquatable<UnityEngine.TextCore.LowLevel.GlyphValueRecord>

#### Fields
- private float m_XAdvance
- private float m_XPlacement
- private float m_YAdvance
- private float m_YPlacement

#### Properties
- public float xAdvance { get; set; }
- public float xPlacement { get; set; }
- public float yAdvance { get; set; }
- public float yPlacement { get; set; }

#### Constructors
- public GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance)

#### Methods
- public override bool Equals(object obj)
- public bool Equals(UnityEngine.TextCore.LowLevel.GlyphValueRecord other)
- public override int GetHashCode()
- public static UnityEngine.TextCore.LowLevel.GlyphValueRecord op_Addition(UnityEngine.TextCore.LowLevel.GlyphValueRecord a, UnityEngine.TextCore.LowLevel.GlyphValueRecord b)
- public static bool op_Equality(UnityEngine.TextCore.LowLevel.GlyphValueRecord lhs, UnityEngine.TextCore.LowLevel.GlyphValueRecord rhs)
- public static bool op_Inequality(UnityEngine.TextCore.LowLevel.GlyphValueRecord lhs, UnityEngine.TextCore.LowLevel.GlyphValueRecord rhs)
- public static UnityEngine.TextCore.LowLevel.GlyphValueRecord op_Multiply(UnityEngine.TextCore.LowLevel.GlyphValueRecord a, float emScale)

### internal struct UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord

#### Fields
- private uint[] m_ComponentGlyphIDs
- private uint m_LigatureGlyphID

#### Properties
- public uint[] componentGlyphIDs { get; set; }
- public uint ligatureGlyphID { get; set; }

### internal struct UnityEngine.TextCore.LowLevel.MarkPositionAdjustment

#### Fields
- private float m_XPositionAdjustment
- private float m_YPositionAdjustment

#### Properties
- public float xPositionAdjustment { get; set; }
- public float yPositionAdjustment { get; set; }

#### Constructors
- public MarkPositionAdjustment(float x, float y)

### internal struct UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord

#### Fields
- private UnityEngine.TextCore.LowLevel.GlyphAnchorPoint m_BaseGlyphAnchorPoint
- private uint m_BaseGlyphID
- private uint m_MarkGlyphID
- private UnityEngine.TextCore.LowLevel.MarkPositionAdjustment m_MarkPositionAdjustment

#### Properties
- public UnityEngine.TextCore.LowLevel.GlyphAnchorPoint baseGlyphAnchorPoint { get; set; }
- public uint baseGlyphID { get; set; }
- public uint markGlyphID { get; set; }
- public UnityEngine.TextCore.LowLevel.MarkPositionAdjustment markPositionAdjustment { get; set; }

### internal struct UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord

#### Fields
- private UnityEngine.TextCore.LowLevel.GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint
- private uint m_BaseMarkGlyphID
- private uint m_CombiningMarkGlyphID
- private UnityEngine.TextCore.LowLevel.MarkPositionAdjustment m_CombiningMarkPositionAdjustment

#### Properties
- public UnityEngine.TextCore.LowLevel.GlyphAnchorPoint baseMarkGlyphAnchorPoint { get; set; }
- public uint baseMarkGlyphID { get; set; }
- public uint combiningMarkGlyphID { get; set; }
- public UnityEngine.TextCore.LowLevel.MarkPositionAdjustment combiningMarkPositionAdjustment { get; set; }

### internal struct UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord

#### Fields
- private uint[] m_SubstituteGlyphIDs
- private uint m_TargetGlyphID

#### Properties
- public uint[] substituteGlyphIDs { get; set; }
- public uint targetGlyphID { get; set; }

### internal struct UnityEngine.TextCore.LowLevel.OpenTypeFeature

### internal struct UnityEngine.TextCore.LowLevel.OpenTypeLayoutFeature

#### Fields
- public uint[] lookupIndexes
- public string tag

### internal struct UnityEngine.TextCore.LowLevel.OpenTypeLayoutLanguage

#### Fields
- public uint[] featureIndexes
- public string tag

### internal class UnityEngine.TextCore.LowLevel.OpenTypeLayoutLookup

#### Fields
- public uint lookupFlag
- public uint lookupType
- public uint markFilteringSet

#### Constructors
- protected OpenTypeLayoutLookup()

#### Methods
- public abstract void ClearRecords()
- public abstract void InitializeLookupDictionary()
- public virtual void UpdateRecords(int lookupIndex, uint glyphIndex)
- public virtual void UpdateRecords(int lookupIndex, uint glyphIndex, float emScale)
- public virtual void UpdateRecords(int lookupIndex, System.Collections.Generic.List<uint> glyphIndexes)
- public virtual void UpdateRecords(int lookupIndex, System.Collections.Generic.List<uint> glyphIndexes, float emScale)

### internal struct UnityEngine.TextCore.LowLevel.OpenTypeLayoutScript

#### Fields
- public System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.OpenTypeLayoutLanguage> languages
- public string tag

### internal struct UnityEngine.TextCore.LowLevel.OpenTypeLayoutTable

#### Fields
- public System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.OpenTypeLayoutFeature> features
- public System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.OpenTypeLayoutLookup> lookups
- public System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.OpenTypeLayoutScript> scripts

### internal struct UnityEngine.TextCore.LowLevel.OTL_Feature

#### Fields
- public uint[] lookupIndexes
- public string tag

### internal struct UnityEngine.TextCore.LowLevel.OTL_Language

#### Fields
- public uint[] featureIndexes
- public string tag

### internal struct UnityEngine.TextCore.LowLevel.OTL_Lookup

#### Fields
- public uint lookupFlag
- public uint lookupType
- public uint markFilteringSet

### internal enum UnityEngine.TextCore.LowLevel.OTL_LookupType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Alternate_Substitution = 32771
- Chaining_Contextual_Positioning = 16392
- Chaining_Contextual_Substitution = 32774
- Contextual_Positioning = 16391
- Contextual_Substitution = 32773
- Cursive_Attachment = 16387
- Extension_Positioning = 16393
- Extension_Substitution = 32775
- Ligature_Substitution = 32772
- Mark_to_Base_Attachment = 16388
- Mark_to_Ligature_Attachment = 16389
- Mark_to_Mark_Attachment = 16390
- Multiple_Substitution = 32770
- Pair_Adjustment = 16386
- Reverse_Chaining_Contextual_Single_Substitution = 32776
- Single_Adjustment = 16385
- Single_Substitution = 32769

### internal struct UnityEngine.TextCore.LowLevel.OTL_Script

#### Fields
- public UnityEngine.TextCore.LowLevel.OTL_Language[] languages
- public string tag

### internal struct UnityEngine.TextCore.LowLevel.OTL_Table

#### Fields
- public UnityEngine.TextCore.LowLevel.OTL_Feature[] features
- public UnityEngine.TextCore.LowLevel.OTL_Lookup[] lookups
- public UnityEngine.TextCore.LowLevel.OTL_Script[] scripts

### internal enum UnityEngine.TextCore.LowLevel.OTL_TableType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BASE = 4096
- GDEF = 8192
- GPOS = 16384
- GSUB = 32768
- JSTF = 65536
- MATH = 131072

### internal struct UnityEngine.TextCore.LowLevel.SequenceLookupRecord

#### Fields
- private uint m_GlyphSequenceIndex
- private uint m_LookupListIndex

#### Properties
- public uint glyphSequenceIndex { get; set; }
- public uint lookupListIndex { get; set; }

### internal struct UnityEngine.TextCore.LowLevel.SingleSubstitutionRecord

#### Fields
- private uint m_SubstituteGlyphID
- private uint m_TargetGlyphID

#### Properties
- public uint substituteGlyphID { get; set; }
- public uint targetGlyphID { get; set; }

