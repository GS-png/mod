# Assembly: Purchasing.Common
- Path: tools/WorldBox.Managed/Purchasing.Common.dll
- Types: 15

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=260 313628D3918F4A846E7D0449F6894CDD6F5B7558CE3BE3F68B4650FF8E2A1BDC
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=360 675AE83A23601FAC01228C141233F49DF24E8FBC2FAB7A4751D1A2C9445B3CA2
- internal static readonly long F642F9B52A17FCAEDFF8B008B645A49C9B6C1C229ACA7ABC830E359B614ABCD2

### private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData

#### Fields
- public byte[] FilePathsData
- public bool IsEditorOnly
- public int TotalFiles
- public int TotalTypes
- public byte[] TypesData

### internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1

#### Constructors
- public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()

#### Methods
- private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=260

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=360

## Namespace: UnityEngine.Purchasing

### public interface UnityEngine.Purchasing.INativeStore

#### Methods
- public void FinishTransaction(string productJSON, string transactionID)
- public void Purchase(string productJSON, string developerPayload)
- public void RetrieveProducts(string json)

### public class UnityEngine.Purchasing.MiniJson

#### Constructors
- public MiniJson()

#### Methods
- public static object JsonDecode(string json)
- public static string JsonEncode(object json)

### internal delegate UnityEngine.Purchasing.UnityPurchasingCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public UnityPurchasingCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored)

### internal struct UnityEngine.Purchasing.VersionCheck.Version

#### Fields
- public int major
- public int minor
- public int patch

### internal static class UnityEngine.Purchasing.VersionCheck

#### Methods
- public static bool Equal(string versionA, string versionB)
- public static bool GreaterThan(string versionA, string versionB)
- public static bool GreaterThanOrEqual(string versionA, string versionB)
- public static bool LessThan(string versionA, string versionB)
- public static bool LessThanOrEqual(string versionA, string versionB)
- public static int MajorVersion(string version)
- public static int MinorVersion(string version)
- public static UnityEngine.Purchasing.VersionCheck.Version Parse(string version)
- private static int PartialVersion(string version, int index)
- public static int PatchVersion(string version)

## Namespace: UnityEngine.Purchasing.MiniJSON

### public static class UnityEngine.Purchasing.MiniJSON.Json

#### Methods
- public static object Deserialize(string json)
- public static string Serialize(object obj)

### public static class UnityEngine.Purchasing.MiniJSON.MiniJsonExtensions

#### Methods
- public static System.Collections.Generic.List<object> ArrayListFromJson(string json)
- public static T Get<T>(System.Collections.Generic.Dictionary<string, object> dic, string key)
- public static bool GetBool(System.Collections.Generic.Dictionary<string, object> dic, string key)
- public static T GetEnum<T>(System.Collections.Generic.Dictionary<string, object> dic, string key)
- public static System.Collections.Generic.Dictionary<string, object> GetHash(System.Collections.Generic.Dictionary<string, object> dic, string key)
- public static long GetLong(System.Collections.Generic.Dictionary<string, object> dic, string key)
- public static string GetString(System.Collections.Generic.Dictionary<string, object> dic, string key, string defaultValue = "")
- public static System.Collections.Generic.List<string> GetStringList(System.Collections.Generic.Dictionary<string, object> dic, string key)
- public static System.Collections.Generic.Dictionary<string, object> HashtableFromJson(string json)
- public static string toJson(System.Collections.Generic.Dictionary<string, object> obj)
- public static string toJson(System.Collections.Generic.Dictionary<string, string> obj)
- public static string toJson(string[] array)

### private class UnityEngine.Purchasing.MiniJSON.Json.Parser
- Interfaces: System.IDisposable

#### Fields
- private System.IO.StringReader json
- private static const string WORD_BREAK

#### Properties
- private char NextChar { get; }
- private UnityEngine.Purchasing.MiniJSON.Json.Parser.TOKEN NextToken { get; }
- private string NextWord { get; }
- private char PeekChar { get; }

#### Constructors
- private Json.Parser(string jsonString)

#### Methods
- public void Dispose()
- private void EatWhitespace()
- public static bool IsWordBreak(char c)
- public static object Parse(string jsonString)
- private System.Collections.Generic.List<object> ParseArray()
- private object ParseByToken(UnityEngine.Purchasing.MiniJSON.Json.Parser.TOKEN token)
- private object ParseNumber()
- private System.Collections.Generic.Dictionary<string, object> ParseObject()
- private string ParseString()
- private object ParseValue()

### private class UnityEngine.Purchasing.MiniJSON.Json.Serializer

#### Fields
- private readonly System.Text.StringBuilder builder

#### Constructors
- private Json.Serializer()

#### Methods
- public static string Serialize(object obj)
- private void SerializeArray(System.Collections.IList anArray)
- private void SerializeObject(System.Collections.IDictionary obj)
- private void SerializeOther(object value)
- private void SerializeString(string str)
- private void SerializeValue(object value)

### private enum UnityEngine.Purchasing.MiniJSON.Json.Parser.TOKEN
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- COLON = 5
- COMMA = 6
- CURLY_CLOSE = 2
- CURLY_OPEN = 1
- FALSE = 10
- NONE = 0
- NULL = 11
- NUMBER = 8
- SQUARED_CLOSE = 4
- SQUARED_OPEN = 3
- STRING = 7
- TRUE = 9

