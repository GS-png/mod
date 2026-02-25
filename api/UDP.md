# Assembly: UDP
- Path: tools/WorldBox.Managed/UDP.dll
- Types: 25

## Namespace: UnityEngine.UDP

### private class UnityEngine.UDP.PurchaseForwardCallback.<>c__DisplayClass2_0

#### Fields
- public UnityEngine.UDP.PurchaseForwardCallback <>4__this
- public string message
- public UnityEngine.UDP.PurchaseInfo purchaseInfo

#### Constructors
- public PurchaseForwardCallback.<>c__DisplayClass2_0()

#### Methods
- internal void <onPurchaseFinished>b__0()
- internal void <onPurchaseFinished>b__1()

### private class UnityEngine.UDP.InitLoginForwardCallback.<>c__DisplayClass2_0

#### Fields
- public UnityEngine.UDP.InitLoginForwardCallback.<>c__DisplayClass2_1 CS$<>8__locals1
- public UnityEngine.UDP.UserInfo userInfo

#### Constructors
- public InitLoginForwardCallback.<>c__DisplayClass2_0()

#### Methods
- internal void <onInitFinished>b__0()

### private class UnityEngine.UDP.InitLoginForwardCallback.<>c__DisplayClass2_1

#### Fields
- public UnityEngine.UDP.InitLoginForwardCallback <>4__this
- public string message

#### Constructors
- public InitLoginForwardCallback.<>c__DisplayClass2_1()

#### Methods
- internal void <onInitFinished>b__1()

### private class UnityEngine.UDP.PurchaseForwardCallback.<>c__DisplayClass3_0

#### Fields
- public UnityEngine.UDP.PurchaseForwardCallback <>4__this
- public string message
- public UnityEngine.UDP.PurchaseInfo purchaseInfo

#### Constructors
- public PurchaseForwardCallback.<>c__DisplayClass3_0()

#### Methods
- internal void <onConsumeFinished>b__0()
- internal void <onConsumeFinished>b__1()

### private class UnityEngine.UDP.PurchaseForwardCallback.<>c__DisplayClass4_0

#### Fields
- public UnityEngine.UDP.PurchaseForwardCallback.<>c__DisplayClass4_1 CS$<>8__locals1
- public UnityEngine.UDP.Inventory inventory

#### Constructors
- public PurchaseForwardCallback.<>c__DisplayClass4_0()

#### Methods
- internal void <onQueryInventory>b__0()

### private class UnityEngine.UDP.PurchaseForwardCallback.<>c__DisplayClass4_1

#### Fields
- public UnityEngine.UDP.PurchaseForwardCallback <>4__this
- public string message

#### Constructors
- public PurchaseForwardCallback.<>c__DisplayClass4_1()

#### Methods
- internal void <onQueryInventory>b__1()

### public class UnityEngine.UDP.AppInfo

#### Fields
- private string <AppSlug>k__BackingField
- private string <ClientId>k__BackingField
- private string <ClientKey>k__BackingField
- private string <RSAPublicKey>k__BackingField

#### Properties
- public string AppSlug { get; set; }
- public string ClientId { get; set; }
- public string ClientKey { get; set; }
- public string RSAPublicKey { get; set; }

#### Constructors
- public AppInfo()

### public interface UnityEngine.UDP.IInitListener

#### Methods
- public void OnInitialized(UnityEngine.UDP.UserInfo userInfo)
- public void OnInitializeFailed(string message)

### public class UnityEngine.UDP.InitLoginForwardCallback
- Base: UnityEngine.AndroidJavaProxy

#### Fields
- private UnityEngine.UDP.IInitListener _initListener

#### Constructors
- public InitLoginForwardCallback(UnityEngine.UDP.IInitListener initListener)

#### Methods
- public void onInitFinished(int resultCode, string message, UnityEngine.AndroidJavaObject jo)

### public class UnityEngine.UDP.Inventory

#### Fields
- private readonly System.Collections.Generic.Dictionary<string, UnityEngine.UDP.ProductInfo> _productDictionary
- private readonly System.Collections.Generic.Dictionary<string, UnityEngine.UDP.PurchaseInfo> _purchaseDictionary

#### Constructors
- public Inventory()

#### Methods
- internal void AddProduct(UnityEngine.UDP.ProductInfo productInfo)
- internal void AddPurchase(UnityEngine.UDP.PurchaseInfo purchaseInfo)
- public System.Collections.Generic.IDictionary<string, UnityEngine.UDP.ProductInfo> GetProductDictionary()
- public UnityEngine.UDP.ProductInfo GetProductInfo(string productId)
- public System.Collections.Generic.IList<UnityEngine.UDP.ProductInfo> GetProductList()
- public System.Collections.Generic.IDictionary<string, UnityEngine.UDP.PurchaseInfo> GetPurchaseDictionary()
- public UnityEngine.UDP.PurchaseInfo GetPurchaseInfo(string productId)
- public System.Collections.Generic.List<UnityEngine.UDP.PurchaseInfo> GetPurchaseList()
- public bool HasProduct(string productId)
- public bool HasPurchase(string productId)

### public interface UnityEngine.UDP.IPurchaseListener

#### Methods
- public void OnPurchase(UnityEngine.UDP.PurchaseInfo purchaseInfo)
- public void OnPurchaseConsume(UnityEngine.UDP.PurchaseInfo purchaseInfo)
- public void OnPurchaseConsumeFailed(string message, UnityEngine.UDP.PurchaseInfo purchaseInfo)
- public void OnPurchaseFailed(string message, UnityEngine.UDP.PurchaseInfo purchaseInfo)
- public void OnPurchaseRepeated(string productId)
- public void OnQueryInventory(UnityEngine.UDP.Inventory inventory)
- public void OnQueryInventoryFailed(string message)

### internal class UnityEngine.UDP.MainThreadDispatcher
- Base: UnityEngine.MonoBehaviour

#### Fields
- public static readonly string OBJECT_NAME
- private static System.Collections.Generic.List<System.Action> s_Callbacks
- private static bool s_CallbacksPending

#### Constructors
- public MainThreadDispatcher()
- private static MainThreadDispatcher()

#### Methods
- public static void RunOnMainThread(System.Action runnable)
- private void Start()
- private void Update()

### public class UnityEngine.UDP.ProductInfo

#### Fields
- private System.Nullable<bool> <Consumable>k__BackingField
- private string <Currency>k__BackingField
- private string <Description>k__BackingField
- private string <ItemType>k__BackingField
- private string <Price>k__BackingField
- private long <PriceAmountMicros>k__BackingField
- private string <ProductId>k__BackingField
- private string <Title>k__BackingField

#### Properties
- public System.Nullable<bool> Consumable { get; set; }
- public string Currency { get; set; }
- public string Description { get; set; }
- public string ItemType { get; set; }
- public string Price { get; set; }
- public long PriceAmountMicros { get; set; }
- public string ProductId { get; set; }
- public string Title { get; set; }

#### Constructors
- public ProductInfo()

### public class UnityEngine.UDP.PurchaseForwardCallback
- Base: UnityEngine.AndroidJavaProxy

#### Fields
- private UnityEngine.UDP.IPurchaseListener purchaseListener

#### Constructors
- public PurchaseForwardCallback(UnityEngine.UDP.IPurchaseListener purchaseListener)

#### Methods
- private static UnityEngine.UDP.Inventory ConvertInventory(string inventoryString)
- private static UnityEngine.UDP.ProductInfo ConvertProductInfo(string productInfoString)
- private static UnityEngine.UDP.ProductInfo ConvertProductInfo(System.Collections.Generic.Dictionary<string, object> productInfoMap)
- private static UnityEngine.UDP.PurchaseInfo ConvertPurchaseInfo(string purchaseInfoString)
- private static UnityEngine.UDP.PurchaseInfo ConvertPurchaseInfo(System.Collections.Generic.Dictionary<string, object> purchaseInfoMap)
- private static T GetValueOfDictionary<T>(System.Collections.Generic.IDictionary<string, object> dictionary, string key, T defaultValue)
- public void onConsumeFinished(int resultCode, string message, string purchaseInfoString)
- public void onPurchaseFinished(int resultCode, string message, string purchaseInfoString)
- public void onQueryInventory(int resultCode, string message, string inventoryString)

### public class UnityEngine.UDP.PurchaseInfo

#### Fields
- private string <DeveloperPayload>k__BackingField
- private string <GameOrderId>k__BackingField
- private string <ItemType>k__BackingField
- private string <OrderQueryToken>k__BackingField
- private string <ProductId>k__BackingField
- private string <StorePurchaseJsonString>k__BackingField

#### Properties
- public string DeveloperPayload { get; set; }
- public string GameOrderId { get; set; }
- public string ItemType { get; set; }
- public string OrderQueryToken { get; set; }
- public string ProductId { get; set; }
- public string StorePurchaseJsonString { get; set; }

#### Constructors
- public PurchaseInfo()

### public class UnityEngine.UDP.ReceiptInfo

#### Fields
- private string <gameOrderId>k__BackingField
- private string <signature>k__BackingField
- private string <signData>k__BackingField

#### Properties
- public string gameOrderId { get; set; }
- public string signature { get; set; }
- public string signData { get; set; }

#### Constructors
- public ReceiptInfo()

### public class UnityEngine.UDP.ResultCode

#### Fields
- public static const int SDK_CONSUME_PURCHASE_FAILED
- public static const int SDK_CONSUME_PURCHASE_SUCCESS
- public static const int SDK_INIT_ERROR
- public static const int SDK_INIT_SUCCESS
- public static const int SDK_NOT_INIT
- public static const int SDK_PURCHASE_CANCEL
- public static const int SDK_PURCHASE_FAILED
- public static const int SDK_PURCHASE_REPEAT
- public static const int SDK_PURCHASE_SUCCESS
- public static const int SDK_QUERY_INVENTORY_FAILED
- public static const int SDK_QUERY_INVENTORY_SUCCESS
- public static const int SDK_SERVER_INVALID

#### Constructors
- public ResultCode()

### public class UnityEngine.UDP.StoreService

#### Fields
- private static UnityEngine.AndroidJavaClass serviceClass

#### Properties
- public static string StoreName { get; }

#### Constructors
- public StoreService()
- private static StoreService()

#### Methods
- public static void ConsumePurchase(UnityEngine.UDP.PurchaseInfo purchaseInfo, UnityEngine.UDP.IPurchaseListener listener)
- public static void ConsumePurchase(System.Collections.Generic.List<UnityEngine.UDP.PurchaseInfo> purchaseInfos, UnityEngine.UDP.IPurchaseListener listener)
- public static void EnableDebugLogging(bool enable)
- public static void EnableDebugLogging(bool enable, string tag)
- public static void Initialize(UnityEngine.UDP.IInitListener listener, UnityEngine.UDP.AppInfo appInfo = null)
- internal static UnityEngine.AndroidJavaObject javaArrayFromCS(string[] values)
- internal static UnityEngine.AndroidJavaObject javaArrayFromCSList(System.Collections.Generic.List<string> values)
- public static void Purchase(string productId, string gameOrderId, string developerPayload, UnityEngine.UDP.IPurchaseListener listener)
- public static void QueryInventory(UnityEngine.UDP.IPurchaseListener listener)
- public static void QueryInventory(System.Collections.Generic.List<string> productIds, UnityEngine.UDP.IPurchaseListener listener)

### public class UnityEngine.UDP.UserInfo

#### Fields
- private string <Channel>k__BackingField
- private string <UserId>k__BackingField
- private string <UserLoginToken>k__BackingField

#### Properties
- public string Channel { get; set; }
- public string UserId { get; set; }
- public string UserLoginToken { get; set; }

#### Constructors
- public UserInfo()

## Namespace: UnityEngine.UDP.Common

### public class UnityEngine.UDP.Common.MiniJson

#### Constructors
- public MiniJson()

#### Methods
- public static System.Collections.Generic.Dictionary<string, object> JsonDecode(string json)
- public static string JsonEncode(object json)

## Namespace: UnityEngine.UDP.Common.MiniJSON

### public static class UnityEngine.UDP.Common.MiniJSON.Json

#### Methods
- public static object Deserialize(string json)
- public static string Serialize(object obj)

### public static class UnityEngine.UDP.Common.MiniJSON.MiniJsonExtensions

#### Methods
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

### private class UnityEngine.UDP.Common.MiniJSON.Json.Parser
- Interfaces: System.IDisposable

#### Fields
- private System.IO.StringReader json
- private static const string WORD_BREAK

#### Properties
- private char NextChar { get; }
- private UnityEngine.UDP.Common.MiniJSON.Json.Parser.TOKEN NextToken { get; }
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
- private object ParseByToken(UnityEngine.UDP.Common.MiniJSON.Json.Parser.TOKEN token)
- private object ParseNumber()
- private System.Collections.Generic.Dictionary<string, object> ParseObject()
- private string ParseString()
- private object ParseValue()

### private class UnityEngine.UDP.Common.MiniJSON.Json.Serializer

#### Fields
- private System.Text.StringBuilder builder

#### Constructors
- private Json.Serializer()

#### Methods
- public static string Serialize(object obj)
- private void SerializeArray(System.Collections.IList anArray)
- private void SerializeObject(System.Collections.IDictionary obj)
- private void SerializeOther(object value)
- private void SerializeString(string str)
- private void SerializeValue(object value)

### private enum UnityEngine.UDP.Common.MiniJSON.Json.Parser.TOKEN
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

