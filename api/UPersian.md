# Assembly: UPersian
- Path: tools/WorldBox.Managed/UPersian.dll
- Types: 15

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=174 0CFA63144E946E6DFD9E69C606BF1723D93F08F3F70649BE7E05B204A09A40CE
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 6B37F2DC3CBC36CB512AAB959CD9F9E3A5ED19A1282D3D8D0EF02E14C2935C71
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=188 A6F04D75C5DE4E1A66CD10ACD5F8DE6ABA7FA2E15FF2936EB8B8B84B88E1D0E0

### internal class ArabicFixerTool

#### Fields
- internal static bool combineTashkeel
- internal static bool showTashkeel
- internal static bool useHinduNumbers

#### Constructors
- public ArabicFixerTool()
- private static ArabicFixerTool()

#### Methods
- internal static string FixLine(string str)
- internal static bool IsFinishingLetter(char[] letters, int index)
- internal static bool IsIgnoredCharacter(char ch)
- internal static bool IsLeadingLetter(char[] letters, int index)
- internal static bool IsMiddleLetter(char[] letters, int index)
- internal static string RemoveTashkeel(string str, out System.Collections.Generic.List<TashkeelLocation> tashkeelLocation)
- internal static char[] ReturnTashkeel(char[] letters, System.Collections.Generic.List<TashkeelLocation> tashkeelLocation)

### internal class ArabicMapping

#### Fields
- public int from
- public int to

#### Constructors
- public ArabicMapping(int from, int to)

### internal class ArabicTable

#### Fields
- private static ArabicTable arabicMapper
- private static System.Collections.Generic.List<ArabicMapping> mapList

#### Properties
- internal static ArabicTable ArabicMapper { get; }

#### Constructors
- private ArabicTable()

#### Methods
- internal int Convert(int toBeConverted)

### internal enum GeneralArabicLetters
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Ain = 1593
- Alef = 1575
- AlefHamza = 1571
- AlefMad = 1570
- AlefMagsora = 1609
- AlefMaksoor = 1573
- Ba = 1576
- Dal = 1583
- Dha = 1590
- Fa = 1601
- Gaf = 1602
- Gain = 1594
- H7aa = 1581
- Ha = 1607
- Hamza = 1569
- HamzaNabera = 1574
- Jeem = 1580
- Kaf = 1603
- Khaa2 = 1582
- Lam = 1604
- Meem = 1605
- Noon = 1606
- PersianChe = 1670
- PersianGaf = 1711
- PersianGaf2 = 1705
- PersianPe = 1662
- PersianYeh = 1740
- PersianZe = 1688
- Ra2 = 1585
- S9a = 1589
- Seen = 1587
- Sheen = 1588
- T6a = 1591
- T6ha = 1592
- Ta = 1578
- TaMarboota = 1577
- Tha2 = 1579
- Thal = 1584
- Waw = 1608
- WawHamza = 1572
- Ya = 1610
- Zeen = 1586

### internal enum IsolatedArabicLetters
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Ain = 65225
- Alef = 65165
- AlefHamza = 65155
- AlefMad = 65153
- AlefMaksoor = 65159
- AlefMaksora = 64508
- Ba = 65167
- Dal = 65193
- Dha = 65213
- Fa = 65233
- Gaf = 65237
- Gain = 65229
- H7aa = 65185
- Ha = 65257
- Hamza = 65152
- HamzaNabera = 65161
- Jeem = 65181
- Kaf = 65241
- Khaa2 = 65189
- Lam = 65245
- Meem = 65249
- Noon = 65253
- PersianChe = 64378
- PersianGaf = 64402
- PersianGaf2 = 64398
- PersianPe = 64342
- PersianYeh = 64508
- PersianZe = 64394
- Ra2 = 65197
- S9a = 65209
- Seen = 65201
- Sheen = 65205
- T6a = 65217
- T6ha = 65221
- Ta = 65173
- TaMarboota = 65171
- Tha2 = 65177
- Thal = 65195
- Waw = 65261
- WawHamza = 65157
- Ya = 65265
- Zeen = 65199

### private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData

#### Fields
- public byte[] FilePathsData
- public bool IsEditorOnly
- public int TotalFiles
- public int TotalTypes
- public byte[] TypesData

### internal class TashkeelLocation

#### Fields
- public int position
- public char tashkeel

#### Constructors
- public TashkeelLocation(char tashkeel, int position)

### internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1

#### Constructors
- public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()

#### Methods
- private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=174

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=188

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24

## Namespace: ArabicSupport

### public class ArabicSupport.ArabicFixer

#### Constructors
- public ArabicFixer()

#### Methods
- public static string Fix(string str)
- public static string Fix(string str, bool rtl)
- public static string Fix(string str, bool showTashkeel, bool useHinduNumbers)
- public static string Fix(string str, bool showTashkeel, bool combineTashkeel, bool useHinduNumbers)

## Namespace: UPersian.Components

### public class UPersian.Components.RtlText
- Base: UnityEngine.UI.Text
- Interfaces: UnityEngine.UI.ICanvasElement, UnityEngine.UI.IClippable, UnityEngine.UI.IMaskable, UnityEngine.UI.IMaterialModifier, UnityEngine.UI.ILayoutElement

#### Fields
- protected char LineEnding

#### Properties
- public string BaseText { get; }
- public string text { get; set; }

#### Constructors
- public RtlText()

## Namespace: UPersian.Utils

### public static class UPersian.Utils.UPersianUtils

#### Fields
- private static const string COLOR_END
- private static const string SIZE_END
- private static System.Collections.Generic.List<string> _colors
- private static string[] _new_lines
- private static System.Collections.Generic.List<string> _sizes

#### Constructors
- private static UPersianUtils()

#### Methods
- private static void colorFixPost(ref string pStr)
- private static void colorFixPre(ref string pStr)
- public static bool IsRtl(string pString)
- public static void replaceFirst(ref string pText, string pSearch, string pReplace)
- public static void RtlFix(ref string pStr)
- private static void sizeFixPost(ref string pStr)
- private static void sizeFixPre(ref string pStr)

