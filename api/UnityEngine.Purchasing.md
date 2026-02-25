# Assembly: UnityEngine.Purchasing
- Path: tools/WorldBox.Managed/UnityEngine.Purchasing.dll
- Types: 90

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=7624 1CE2232E012528A440590472F8BA22A226E0CD28C800B60EE0BEF28738E5B4E8
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3569 F8A63ED4A0FCACA85CBEE3409C03FD51A1B3F9D3CF23A955CD7A6FA06F8C46D4

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3569

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=7624

## Namespace: Microsoft.CodeAnalysis

### internal class Microsoft.CodeAnalysis.EmbeddedAttribute
- Base: System.Attribute

#### Constructors
- public EmbeddedAttribute()

## Namespace: System.Runtime.CompilerServices

### internal class System.Runtime.CompilerServices.NullableAttribute
- Base: System.Attribute

#### Fields
- public readonly byte[] NullableFlags

#### Constructors
- public NullableAttribute(byte )
- public NullableAttribute(byte[] )

### internal class System.Runtime.CompilerServices.NullableContextAttribute
- Base: System.Attribute

#### Fields
- public readonly byte Flag

#### Constructors
- public NullableContextAttribute(byte )

## Namespace: Uniject

### internal interface Uniject.IUtil

#### Properties
- public string cloudProjectId { get; }
- public System.DateTime currentTime { get; }
- public string deviceModel { get; }
- public string deviceName { get; }
- public UnityEngine.DeviceType deviceType { get; }
- public string deviceUniqueIdentifier { get; }
- public string gameVersion { get; }
- public bool isEditor { get; }
- public string operatingSystem { get; }
- public string persistentDataPath { get; }
- public UnityEngine.RuntimePlatform platform { get; }
- public float screenDpi { get; }
- public int screenHeight { get; }
- public string screenOrientation { get; }
- public int screenWidth { get; }
- public ulong sessionId { get; }
- public string unityVersion { get; }
- public string userId { get; }

#### Methods
- public void AddPauseListener(System.Action<bool> runnable)
- public T[] GetAnyComponentsOfType<T>()
- public object GetWaitForSeconds(int seconds)
- public object InitiateCoroutine(System.Collections.IEnumerator start)
- public void InitiateCoroutine(System.Collections.IEnumerator start, int delayInSeconds)
- public bool IsClassOrSubclass(System.Type potentialBase, System.Type potentialDescendant)
- public void RunOnMainThread(System.Action runnable)

## Namespace: UnityEngine.Purchasing

### private class UnityEngine.Purchasing.ProductCollection.<>c

#### Fields
- public static readonly UnityEngine.Purchasing.ProductCollection.<>c <>9
- public static System.Func<UnityEngine.Purchasing.Product, string> <>9__3_0
- public static System.Func<UnityEngine.Purchasing.Product, string> <>9__3_1

#### Constructors
- private static ProductCollection.<>c()
- public ProductCollection.<>c()

#### Methods
- internal string <AddProducts>b__3_0(UnityEngine.Purchasing.Product x)
- internal string <AddProducts>b__3_1(UnityEngine.Purchasing.Product x)

### private class UnityEngine.Purchasing.PurchasingManager.<>c

#### Fields
- public static readonly UnityEngine.Purchasing.PurchasingManager.<>c <>9
- public static System.Func<UnityEngine.Purchasing.ProductDefinition, UnityEngine.Purchasing.Product> <>9__38_0
- public static System.Func<UnityEngine.Purchasing.ProductDefinition, UnityEngine.Purchasing.Product> <>9__39_0
- public static System.Func<UnityEngine.Purchasing.ProductDefinition, UnityEngine.Purchasing.Product> <>9__45_0

#### Constructors
- private static PurchasingManager.<>c()
- public PurchasingManager.<>c()

#### Methods
- internal UnityEngine.Purchasing.Product <FetchAdditionalProducts>b__38_0(UnityEngine.Purchasing.ProductDefinition x)
- internal UnityEngine.Purchasing.Product <FetchAdditionalProducts>b__39_0(UnityEngine.Purchasing.ProductDefinition x)
- internal UnityEngine.Purchasing.Product <Initialize>b__45_0(UnityEngine.Purchasing.ProductDefinition x)

### private class UnityEngine.Purchasing.PurchasingManager.<>c__DisplayClass27_0

#### Fields
- public UnityEngine.Purchasing.Product product

#### Constructors
- public PurchasingManager.<>c__DisplayClass27_0()

#### Methods
- internal bool <OnAllPurchasesRetrieved>b__0(UnityEngine.Purchasing.Product firstPurchasedProduct)

### private class UnityEngine.Purchasing.UnityPurchasing.<>c__DisplayClass5_0

#### Fields
- public UnityEngine.Purchasing.PurchasingManager manager
- public UnityEngine.Purchasing.StoreListenerProxy proxy

#### Constructors
- public UnityPurchasing.<>c__DisplayClass5_0()

#### Methods
- internal void <Initialize>b__0(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> response)

### private class UnityEngine.Purchasing.UnityPurchasing.<>c__DisplayClass6_0

#### Fields
- public System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback
- public System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> localProductSet

#### Constructors
- public UnityPurchasing.<>c__DisplayClass6_0()

#### Methods
- internal void <FetchAndMergeProducts>b__0(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> cloudProducts)

### internal class UnityEngine.Purchasing.AnalyticsClient
- Interfaces: UnityEngine.Purchasing.IAnalyticsClient

#### Fields
- private readonly UnityEngine.Purchasing.IAnalyticsAdapter m_Analytics
- private readonly UnityEngine.Purchasing.IAnalyticsAdapter m_LegacyAnalytics

#### Constructors
- public AnalyticsClient(UnityEngine.Purchasing.IAnalyticsAdapter analytics, UnityEngine.Purchasing.IAnalyticsAdapter legacyAnalytics)

#### Methods
- public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription description)
- public void OnPurchaseSucceeded(UnityEngine.Purchasing.Product product)

### internal class UnityEngine.Purchasing.AnalyticsTransactionReceipt

#### Fields
- private string <transactionReceipt>k__BackingField
- private string <transactionReceiptSignature>k__BackingField
- private System.Nullable<Unity.Services.Analytics.TransactionServer> <transactionServer>k__BackingField

#### Properties
- public string transactionReceipt { get; set; }
- public string transactionReceiptSignature { get; set; }
- public System.Nullable<Unity.Services.Analytics.TransactionServer> transactionServer { get; set; }

#### Constructors
- public AnalyticsTransactionReceipt()

### public class UnityEngine.Purchasing.ConfigurationBuilder

#### Fields
- private readonly UnityEngine.Purchasing.PurchasingFactory <factory>k__BackingField
- private bool <logUnavailableProducts>k__BackingField
- private readonly System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> <products>k__BackingField
- private bool <useCatalogProvider>k__BackingField

#### Properties
- internal UnityEngine.Purchasing.PurchasingFactory factory { get; }
- public bool logUnavailableProducts { get; set; }
- public System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> products { get; }
- public bool useCatalogProvider { get; set; }

#### Constructors
- internal ConfigurationBuilder(UnityEngine.Purchasing.PurchasingFactory factory)

#### Methods
- public UnityEngine.Purchasing.ConfigurationBuilder AddProduct(string id, UnityEngine.Purchasing.ProductType type)
- public UnityEngine.Purchasing.ConfigurationBuilder AddProduct(string id, UnityEngine.Purchasing.ProductType type, UnityEngine.Purchasing.IDs storeIDs)
- public UnityEngine.Purchasing.ConfigurationBuilder AddProduct(string id, UnityEngine.Purchasing.ProductType type, UnityEngine.Purchasing.IDs storeIDs, UnityEngine.Purchasing.PayoutDefinition payout)
- public UnityEngine.Purchasing.ConfigurationBuilder AddProduct(string id, UnityEngine.Purchasing.ProductType type, UnityEngine.Purchasing.IDs storeIDs, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> payouts)
- public UnityEngine.Purchasing.ConfigurationBuilder AddProducts(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products)
- public T Configure<T>()
- public static UnityEngine.Purchasing.ConfigurationBuilder Instance(UnityEngine.Purchasing.Extension.IPurchasingModule first, params UnityEngine.Purchasing.Extension.IPurchasingModule[] rest)

### internal class UnityEngine.Purchasing.CoreAnalyticsAdapter
- Interfaces: UnityEngine.Purchasing.IAnalyticsAdapter

#### Fields
- private static const string k_PurchasingPackageName
- private static const string k_TransactionEventName
- private static const int k_TransactionEventVersion
- private static const string k_TransactionFailedEventName
- private static const int k_TransactionFailedEventVersion
- private readonly Unity.Services.Analytics.IAnalyticsService m_Analytics
- private Unity.Services.Core.Analytics.Internal.IAnalyticsStandardEventComponent m_CoreAnalytics
- private readonly UnityEngine.ILogger m_Logger

#### Constructors
- public CoreAnalyticsAdapter(Unity.Services.Analytics.IAnalyticsService analytics, UnityEngine.ILogger logger)

#### Methods
- private System.Collections.Generic.Dictionary<string, object> BuildTransactionFailedParameters(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason reason)
- private System.Collections.Generic.Dictionary<string, object> BuildTransactionParameters(UnityEngine.Purchasing.Product product)
- private long CheckCurrencyCodeAndExtractRealCurrencyAmount(UnityEngine.Purchasing.Product product)
- private Unity.Services.Core.Analytics.Internal.IAnalyticsStandardEventComponent CoreAnalytics()
- private System.Collections.Generic.Dictionary<string, object> CreateRealCurrencyFromProduct(UnityEngine.Purchasing.Product product)
- private long ExtractRealCurrencyAmount(UnityEngine.Purchasing.Product product)
- private static System.Collections.Generic.Dictionary<string, object> GenerateItemReceivedForPurchase(UnityEngine.Purchasing.Product product)
- private System.Collections.Generic.Dictionary<string, object> GenerateRealCurrencySpentOnPurchase(UnityEngine.Purchasing.Product product)
- private static string GetTransactionName(UnityEngine.Purchasing.Product product)
- public void SendTransactionEvent(UnityEngine.Purchasing.Product product)
- public void SendTransactionFailedEvent(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription description)

### internal class UnityEngine.Purchasing.CoreServicesEnvironmentSubject

#### Fields
- private static const string k_DefaultLiveEnvironment
- private string m_LastKnownEnvironment
- private System.Collections.Generic.List<UnityEngine.Purchasing.ICoreServicesEnvironmentObserver> m_Observers
- private static UnityEngine.Purchasing.CoreServicesEnvironmentSubject s_Instance

#### Constructors
- public CoreServicesEnvironmentSubject()

#### Methods
- internal static UnityEngine.Purchasing.CoreServicesEnvironmentSubject Instance()
- internal bool IsDefaultLiveEnvironment(string environment)
- private void NotifyObservers()
- public void SubscribeToUpdatesAndGetCurrent(UnityEngine.Purchasing.ICoreServicesEnvironmentObserver newObserver)
- internal void UpdateCurrentEnvironment(string currentEnvironment)

### internal class UnityEngine.Purchasing.EmptyAnalyticsAdapter
- Interfaces: UnityEngine.Purchasing.IAnalyticsAdapter

#### Constructors
- public EmptyAnalyticsAdapter()

#### Methods
- public void SendTransactionEvent(UnityEngine.Purchasing.Product product)
- public void SendTransactionFailedEvent(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription reason)

### internal class UnityEngine.Purchasing.GoogleReceipt

#### Fields
- public string json
- public string signature

#### Constructors
- public GoogleReceipt()

### internal interface UnityEngine.Purchasing.IAnalyticsAdapter

#### Methods
- public void SendTransactionEvent(UnityEngine.Purchasing.Product product)
- public void SendTransactionFailedEvent(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription description)

### internal interface UnityEngine.Purchasing.IAnalyticsClient

#### Methods
- public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription purchaseFailureDescription)
- public void OnPurchaseSucceeded(UnityEngine.Purchasing.Product product)

### internal interface UnityEngine.Purchasing.ICoreServicesEnvironmentObserver

#### Methods
- public void OnUpdatedCoreServicesEnvironment(string currentEnvironment)

### public interface UnityEngine.Purchasing.IDetailedStoreListener
- Interfaces: UnityEngine.Purchasing.IStoreListener

#### Methods
- public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription failureDescription)

### public class UnityEngine.Purchasing.IDs
- Interfaces: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.IEnumerable

#### Fields
- private readonly System.Collections.Generic.Dictionary<string, string> m_Dic

#### Constructors
- public IDs()

#### Methods
- public void Add(string id, params string[] stores)
- public void Add(string id, params object[] stores)
- public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> GetEnumerator()
- internal string SpecificIDForStore(string store, string defaultValue)
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()

### public interface UnityEngine.Purchasing.IExtensionProvider

#### Methods
- public T GetExtension<T>()

### internal interface UnityEngine.Purchasing.IInternalStoreListener

#### Methods
- public void OnInitialized(UnityEngine.Purchasing.IStoreController controller)
- public void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error, string message = null)
- public void OnPurchaseFailed(UnityEngine.Purchasing.Product i, UnityEngine.Purchasing.Extension.PurchaseFailureDescription p)
- public UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e)
- public void SendTransactionEvent(UnityEngine.Purchasing.Product product)

### internal interface UnityEngine.Purchasing.ILegacyUnityAnalytics

#### Methods
- public void SendCustomEvent(string name, System.Collections.Generic.Dictionary<string, object> data)
- public void SendTransactionEvent(string productId, decimal amount, string currency, string receiptPurchaseData, string signature)

### public enum UnityEngine.Purchasing.InitializationFailureReason
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AppNotKnown = 2
- NoProductsAvailable = 1
- PurchasingUnavailable = 0

### public interface UnityEngine.Purchasing.IStoreController

#### Properties
- public UnityEngine.Purchasing.ProductCollection products { get; }

#### Methods
- public void ConfirmPendingPurchase(UnityEngine.Purchasing.Product product)
- public void FetchAdditionalProducts(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> additionalProducts, System.Action successCallback, System.Action<UnityEngine.Purchasing.InitializationFailureReason> failCallback)
- public void FetchAdditionalProducts(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> additionalProducts, System.Action successCallback, System.Action<UnityEngine.Purchasing.InitializationFailureReason, string> failCallback)
- public void InitiatePurchase(UnityEngine.Purchasing.Product product, string payload)
- public void InitiatePurchase(string productId, string payload)
- public void InitiatePurchase(UnityEngine.Purchasing.Product product)
- public void InitiatePurchase(string productId)

### public interface UnityEngine.Purchasing.IStoreExtension

### public interface UnityEngine.Purchasing.IStoreListener

#### Methods
- public void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions)
- public void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error)
- public void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error, string message)
- public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason failureReason)
- public UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs purchaseEvent)

### internal interface UnityEngine.Purchasing.IUnityServicesInitializationChecker

#### Methods
- public void CheckAndLogWarning()

### internal class UnityEngine.Purchasing.LegacyAnalyticsAdapter
- Interfaces: UnityEngine.Purchasing.IAnalyticsAdapter

#### Fields
- private readonly UnityEngine.Purchasing.ILegacyUnityAnalytics m_LegacyAnalytics

#### Constructors
- public LegacyAnalyticsAdapter(UnityEngine.Purchasing.ILegacyUnityAnalytics legacyAnalytics)

#### Methods
- public void SendTransactionEvent(UnityEngine.Purchasing.Product product)
- public void SendTransactionFailedEvent(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription description)

### internal class UnityEngine.Purchasing.LegacyAnalyticsWrapper
- Interfaces: UnityEngine.Purchasing.IAnalyticsAdapter, UnityEngine.Purchasing.ICoreServicesEnvironmentObserver

#### Fields
- private UnityEngine.Purchasing.IAnalyticsAdapter m_EmptyAdapter
- private bool m_Enabled
- private UnityEngine.Purchasing.IAnalyticsAdapter m_LegacyAdapter

#### Properties
- private UnityEngine.Purchasing.IAnalyticsAdapter m_AnalyticsAdapter { get; }

#### Constructors
- internal LegacyAnalyticsWrapper(UnityEngine.Purchasing.IAnalyticsAdapter legacyAdapter, UnityEngine.Purchasing.IAnalyticsAdapter emptyAdapter)

#### Methods
- public void OnUpdatedCoreServicesEnvironment(string currentEnvironment)
- public void SendTransactionEvent(UnityEngine.Purchasing.Product product)
- public void SendTransactionFailedEvent(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription description)

### internal class UnityEngine.Purchasing.LegacyUnityAnalytics
- Interfaces: UnityEngine.Purchasing.ILegacyUnityAnalytics

#### Constructors
- public LegacyUnityAnalytics()

#### Methods
- public void SendCustomEvent(string name, System.Collections.Generic.Dictionary<string, object> data)
- public void SendTransactionEvent(string productId, decimal amount, string currency, string receiptPurchaseData, string signature)

### internal static class UnityEngine.Purchasing.LoggerExtensions

#### Fields
- private static const string IAPLogTag

#### Methods
- public static void LogIAPError(UnityEngine.ILogger logger, string message)
- public static void LogIAPWarning(UnityEngine.ILogger logger, string message)

### public class UnityEngine.Purchasing.PayoutDefinition

#### Fields
- public static const int MaxDataLength
- public static const int MaxSubtypeLength
- private string m_Data
- private double m_Quantity
- private string m_Subtype
- private UnityEngine.Purchasing.PayoutType m_Type

#### Properties
- public string data { get; private set; }
- public double quantity { get; private set; }
- public string subtype { get; private set; }
- public UnityEngine.Purchasing.PayoutType type { get; private set; }
- public string typeString { get; }

#### Constructors
- public PayoutDefinition()
- public PayoutDefinition(string subtype, double quantity)
- public PayoutDefinition(string typeString, string subtype, double quantity)
- public PayoutDefinition(string subtype, double quantity, string data)
- public PayoutDefinition(UnityEngine.Purchasing.PayoutType type, string subtype, double quantity)
- public PayoutDefinition(string typeString, string subtype, double quantity, string data)
- public PayoutDefinition(UnityEngine.Purchasing.PayoutType type, string subtype, double quantity, string data)

### public enum UnityEngine.Purchasing.PayoutType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Currency = 1
- Item = 2
- Other = 0
- Resource = 3

### public class UnityEngine.Purchasing.Product

#### Fields
- private string <appleOriginalTransactionID>k__BackingField
- private bool <appleProductIsRestored>k__BackingField
- private bool <availableToPurchase>k__BackingField
- private UnityEngine.Purchasing.ProductDefinition <definition>k__BackingField
- private UnityEngine.Purchasing.ProductMetadata <metadata>k__BackingField
- private string <receipt>k__BackingField
- private string <transactionID>k__BackingField

#### Properties
- public string appleOriginalTransactionID { get; internal set; }
- public bool appleProductIsRestored { get; internal set; }
- public bool availableToPurchase { get; internal set; }
- public UnityEngine.Purchasing.ProductDefinition definition { get; private set; }
- public bool hasReceipt { get; }
- public UnityEngine.Purchasing.ProductMetadata metadata { get; internal set; }
- public string receipt { get; internal set; }
- public string transactionID { get; internal set; }

#### Constructors
- internal Product(UnityEngine.Purchasing.ProductDefinition definition, UnityEngine.Purchasing.ProductMetadata metadata)
- internal Product(UnityEngine.Purchasing.ProductDefinition definition, UnityEngine.Purchasing.ProductMetadata metadata, string receipt)

#### Methods
- public override bool Equals(object obj)
- public override int GetHashCode()

### public class UnityEngine.Purchasing.ProductCollection

#### Fields
- private UnityEngine.Purchasing.Product[] <all>k__BackingField
- private readonly System.Collections.Generic.HashSet<UnityEngine.Purchasing.Product> <set>k__BackingField
- private System.Collections.Generic.Dictionary<string, UnityEngine.Purchasing.Product> m_IdToProduct
- private System.Collections.Generic.Dictionary<string, UnityEngine.Purchasing.Product> m_StoreSpecificIdToProduct

#### Properties
- public UnityEngine.Purchasing.Product[] all { get; private set; }
- public System.Collections.Generic.HashSet<UnityEngine.Purchasing.Product> set { get; }

#### Constructors
- internal ProductCollection(UnityEngine.Purchasing.Product[] products)

#### Methods
- internal void AddProducts(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> products)
- public UnityEngine.Purchasing.Product WithID(string id)
- public UnityEngine.Purchasing.Product WithStoreSpecificID(string id)

### public class UnityEngine.Purchasing.ProductDefinition

#### Fields
- private bool <enabled>k__BackingField
- private string <id>k__BackingField
- private string <storeSpecificId>k__BackingField
- private UnityEngine.Purchasing.ProductType <type>k__BackingField
- private readonly System.Collections.Generic.List<UnityEngine.Purchasing.PayoutDefinition> m_Payouts

#### Properties
- public bool enabled { get; private set; }
- public string id { get; private set; }
- public UnityEngine.Purchasing.PayoutDefinition payout { get; }
- public System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> payouts { get; }
- public string storeSpecificId { get; private set; }
- public UnityEngine.Purchasing.ProductType type { get; private set; }

#### Constructors
- private ProductDefinition()
- public ProductDefinition(string id, UnityEngine.Purchasing.ProductType type)
- public ProductDefinition(string id, string storeSpecificId, UnityEngine.Purchasing.ProductType type)
- public ProductDefinition(string id, string storeSpecificId, UnityEngine.Purchasing.ProductType type, bool enabled)
- public ProductDefinition(string id, string storeSpecificId, UnityEngine.Purchasing.ProductType type, bool enabled, UnityEngine.Purchasing.PayoutDefinition payout)
- public ProductDefinition(string id, string storeSpecificId, UnityEngine.Purchasing.ProductType type, bool enabled, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> payouts)

#### Methods
- public override bool Equals(object obj)
- public override int GetHashCode()
- internal void SetPayouts(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> newPayouts)

### public class UnityEngine.Purchasing.ProductMetadata

#### Fields
- private string <isoCurrencyCode>k__BackingField
- private string <localizedDescription>k__BackingField
- private decimal <localizedPrice>k__BackingField
- private string <localizedPriceString>k__BackingField
- private string <localizedTitle>k__BackingField

#### Properties
- public string isoCurrencyCode { get; internal set; }
- public string localizedDescription { get; internal set; }
- public decimal localizedPrice { get; internal set; }
- public string localizedPriceString { get; internal set; }
- public string localizedTitle { get; internal set; }

#### Constructors
- public ProductMetadata()
- public ProductMetadata(UnityEngine.Purchasing.ProductMetadata productMetadata)
- public ProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice)

### internal static class UnityEngine.Purchasing.ProductPurchaseUpdater

#### Methods
- internal static void UpdateProductReceiptAndTransactionID(UnityEngine.Purchasing.Product product, string receipt, string transactionId, string storeName)

### public enum UnityEngine.Purchasing.ProductType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Consumable = 0
- NonConsumable = 1
- Subscription = 2

### public class UnityEngine.Purchasing.PurchaseEventArgs

#### Fields
- private UnityEngine.Purchasing.Product <purchasedProduct>k__BackingField

#### Properties
- public UnityEngine.Purchasing.Product purchasedProduct { get; private set; }

#### Constructors
- internal PurchaseEventArgs(UnityEngine.Purchasing.Product purchasedProduct)

### public class UnityEngine.Purchasing.PurchaseFailedEventArgs

#### Fields
- private string <message>k__BackingField
- private UnityEngine.Purchasing.Product <purchasedProduct>k__BackingField
- private UnityEngine.Purchasing.PurchaseFailureReason <reason>k__BackingField

#### Properties
- public string message { get; private set; }
- public UnityEngine.Purchasing.Product purchasedProduct { get; private set; }
- public UnityEngine.Purchasing.PurchaseFailureReason reason { get; private set; }

#### Constructors
- internal PurchaseFailedEventArgs(UnityEngine.Purchasing.Product purchasedProduct, UnityEngine.Purchasing.PurchaseFailureReason reason, string message)

### public enum UnityEngine.Purchasing.PurchaseFailureReason
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DuplicateTransaction = 6
- ExistingPurchasePending = 1
- PaymentDeclined = 5
- ProductUnavailable = 2
- PurchasingUnavailable = 0
- SignatureInvalid = 3
- Unknown = 7
- UserCancelled = 4

### public enum UnityEngine.Purchasing.PurchaseProcessingResult
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Complete = 0
- Pending = 1

### internal class UnityEngine.Purchasing.PurchasingFactory
- Interfaces: UnityEngine.Purchasing.Extension.IPurchasingBinder, UnityEngine.Purchasing.IExtensionProvider

#### Fields
- private string <storeName>k__BackingField
- private UnityEngine.Purchasing.Extension.ICatalogProvider m_CatalogProvider
- private readonly System.Collections.Generic.Dictionary<System.Type, UnityEngine.Purchasing.Extension.IStoreConfiguration> m_ConfigMap
- private readonly System.Collections.Generic.Dictionary<System.Type, UnityEngine.Purchasing.IStoreExtension> m_ExtensionMap
- private UnityEngine.Purchasing.Extension.IStore m_Store

#### Properties
- public UnityEngine.Purchasing.Extension.IStore service { get; set; }
- public string storeName { get; private set; }

#### Constructors
- public PurchasingFactory(UnityEngine.Purchasing.Extension.IPurchasingModule first, params UnityEngine.Purchasing.Extension.IPurchasingModule[] remainingModules)

#### Methods
- internal UnityEngine.Purchasing.Extension.ICatalogProvider GetCatalogProvider()
- public T GetConfig<T>()
- public T GetExtension<T>()
- public void RegisterConfiguration<T>(T instance)
- public void RegisterExtension<T>(T instance)
- public void RegisterStore(string name, UnityEngine.Purchasing.Extension.IStore s)
- public void SetCatalogProvider(UnityEngine.Purchasing.Extension.ICatalogProvider provider)
- public void SetCatalogProviderFunction(System.Action<System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>>> func)

### internal class UnityEngine.Purchasing.PurchasingManager
- Interfaces: UnityEngine.Purchasing.Extension.IStoreCallback, UnityEngine.Purchasing.IStoreController

#### Fields
- private UnityEngine.Purchasing.ProductCollection <products>k__BackingField
- private bool <useTransactionLog>k__BackingField
- private bool initialized
- private System.Action m_AdditionalProductsCallback
- private System.Action<UnityEngine.Purchasing.InitializationFailureReason, string> m_AdditionalProductsDetailedFailCallback
- private System.Action<UnityEngine.Purchasing.InitializationFailureReason> m_AdditionalProductsFailCallback
- private UnityEngine.Purchasing.IInternalStoreListener m_Listener
- private readonly UnityEngine.ILogger m_Logger
- private readonly bool m_logUnavailableProducts
- private readonly UnityEngine.Purchasing.Extension.IStore m_Store
- private readonly string m_StoreName
- private readonly UnityEngine.Purchasing.TransactionLog m_TransactionLog
- private readonly UnityEngine.Purchasing.IUnityServicesInitializationChecker m_UnityServicesInitializationChecker
- private readonly System.Collections.Generic.HashSet<string> purchasesProcessedInSession

#### Properties
- public UnityEngine.Purchasing.ProductCollection products { get; private set; }
- public bool useTransactionLog { get; set; }

#### Constructors
- internal PurchasingManager(UnityEngine.Purchasing.TransactionLog tDb, UnityEngine.ILogger logger, UnityEngine.Purchasing.Extension.IStore store, string storeName, UnityEngine.Purchasing.IUnityServicesInitializationChecker unityServicesInitializationChecker, bool logUnavailableProducts)

#### Methods
- private void CheckForInitialization(int productCount)
- private static void ClearProductReceipt(UnityEngine.Purchasing.Product product)
- public void ConfirmPendingPurchase(UnityEngine.Purchasing.Product product)
- private string CreateUnifiedReceipt(string rawReceipt, string transactionId)
- public void FetchAdditionalProducts(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> additionalProducts, System.Action successCallback, System.Action<UnityEngine.Purchasing.InitializationFailureReason> failCallback)
- public void FetchAdditionalProducts(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> additionalProducts, System.Action successCallback, System.Action<UnityEngine.Purchasing.InitializationFailureReason, string> failCallback)
- private void HandlePurchaseRetrieved(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Product purchasedProduct)
- private bool HasAvailableProductsToPurchase()
- private bool HasRecordedTransaction(string transactionId)
- public void Initialize(UnityEngine.Purchasing.IInternalStoreListener listener, System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> products)
- public void InitiatePurchase(UnityEngine.Purchasing.Product product)
- public void InitiatePurchase(string productId)
- public void InitiatePurchase(UnityEngine.Purchasing.Product product, string developerPayload)
- public void InitiatePurchase(string purchasableId, string developerPayload)
- public void OnAllPurchasesRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts)
- internal static void OnEntitlementRevoked(UnityEngine.Purchasing.Product revokedProduct)
- public void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products)
- public void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription description)
- public void OnPurchaseSucceeded(string id, string receipt, string transactionId)
- public void OnSetupFailed(UnityEngine.Purchasing.InitializationFailureReason reason)
- public void OnSetupFailed(UnityEngine.Purchasing.InitializationFailureReason reason, string message)
- private void ProcessPurchaseIfNew(UnityEngine.Purchasing.Product product)
- private void ProcessPurchaseOnStart()
- private void UpdateProductReceiptAndTransactionID(UnityEngine.Purchasing.Product product, string receipt, string transactionId)
- private bool WasPurchaseAlreadyProcessed(string transactionId)

### internal class UnityEngine.Purchasing.SimpleCatalogProvider
- Interfaces: UnityEngine.Purchasing.Extension.ICatalogProvider

#### Fields
- private readonly System.Action<System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>>> m_Func

#### Constructors
- internal SimpleCatalogProvider(System.Action<System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>>> func)

#### Methods
- public void FetchProducts(System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback)

### internal class UnityEngine.Purchasing.StoreListenerProxy
- Interfaces: UnityEngine.Purchasing.IInternalStoreListener

#### Fields
- private readonly UnityEngine.Purchasing.IAnalyticsClient m_Analytics
- private readonly UnityEngine.Purchasing.IExtensionProvider m_Extensions
- private readonly UnityEngine.Purchasing.IStoreListener m_ForwardTo

#### Constructors
- public StoreListenerProxy(UnityEngine.Purchasing.IStoreListener forwardTo, UnityEngine.Purchasing.IAnalyticsClient analytics, UnityEngine.Purchasing.IExtensionProvider extensions)

#### Methods
- public void OnInitialized(UnityEngine.Purchasing.IStoreController controller)
- public void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error, string message)
- public void OnPurchaseFailed(UnityEngine.Purchasing.Product i, UnityEngine.Purchasing.Extension.PurchaseFailureDescription p)
- public UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e)
- public void SendTransactionEvent(UnityEngine.Purchasing.Product product)

### internal class UnityEngine.Purchasing.TransactionLog

#### Fields
- private readonly UnityEngine.ILogger logger
- private readonly string persistentDataPath

#### Constructors
- public TransactionLog(UnityEngine.ILogger logger, string persistentDataPath)

#### Methods
- public void Clear()
- internal static string ComputeHash(string transactionID)
- private string GetRecordPath(string transactionID)
- public bool HasRecordOf(string transactionID)
- public void Record(string transactionID)

### public class UnityEngine.Purchasing.UnifiedReceipt

#### Fields
- public string Payload
- public string Store
- public string TransactionID

#### Constructors
- public UnifiedReceipt()

### internal static class UnityEngine.Purchasing.UnifiedReceiptExtensions

#### Methods
- public static UnityEngine.Purchasing.AnalyticsTransactionReceipt ToReceiptAndSignature(UnityEngine.Purchasing.UnifiedReceipt receipt)
- private static System.Nullable<Unity.Services.Analytics.TransactionServer> ToTransactionServer(UnityEngine.Purchasing.UnifiedReceipt receipt)

### internal static class UnityEngine.Purchasing.UnifiedReceiptFormatter

#### Methods
- internal static string FormatUnifiedReceipt(string platformReceipt, string transactionId, string storeName)

### public class UnityEngine.Purchasing.UnityPurchasing

#### Constructors
- protected UnityPurchasing()

#### Methods
- public static void ClearTransactionLog()
- internal static void FetchAndMergeProducts(bool useCatalog, System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> localProductSet, UnityEngine.Purchasing.Extension.ICatalogProvider catalog, System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback)
- private static UnityEngine.Purchasing.IAnalyticsAdapter GenerateLegacyUnityAnalytics()
- private static UnityEngine.Purchasing.IAnalyticsAdapter GenerateUnityAnalytics(UnityEngine.ILogger logger)
- public static void Initialize(UnityEngine.Purchasing.IStoreListener listener, UnityEngine.Purchasing.ConfigurationBuilder builder)
- public static void Initialize(UnityEngine.Purchasing.IDetailedStoreListener listener, UnityEngine.Purchasing.ConfigurationBuilder builder)
- internal static void Initialize(UnityEngine.Purchasing.IStoreListener listener, UnityEngine.Purchasing.ConfigurationBuilder builder, UnityEngine.ILogger logger, string persistentDatapath, UnityEngine.Purchasing.IAnalyticsAdapter ugsAnalytics, UnityEngine.Purchasing.IAnalyticsAdapter legacyAnalytics, UnityEngine.Purchasing.Extension.ICatalogProvider catalog, UnityEngine.Purchasing.IUnityServicesInitializationChecker unityServicesInitializationChecker)

### internal class UnityEngine.Purchasing.UnityServicesInitializationChecker
- Interfaces: UnityEngine.Purchasing.IUnityServicesInitializationChecker

#### Fields
- private readonly UnityEngine.ILogger m_Logger
- private static const string UgsUninitializedMessage

#### Constructors
- public UnityServicesInitializationChecker(UnityEngine.ILogger logger)

#### Methods
- public void CheckAndLogWarning()
- private bool IsUninitialized()
- private void LogWarning()

## Namespace: UnityEngine.Purchasing.Extension

### public class UnityEngine.Purchasing.Extension.AbstractPurchasingModule
- Interfaces: UnityEngine.Purchasing.Extension.IPurchasingModule

#### Fields
- protected UnityEngine.Purchasing.Extension.IPurchasingBinder m_Binder

#### Constructors
- protected AbstractPurchasingModule()

#### Methods
- protected void BindConfiguration<T>(T instance)
- protected void BindExtension<T>(T instance)
- public void Configure(UnityEngine.Purchasing.Extension.IPurchasingBinder binder)
- public abstract void Configure()
- protected void RegisterStore(string name, UnityEngine.Purchasing.Extension.IStore store)

### public class UnityEngine.Purchasing.Extension.AbstractStore
- Interfaces: UnityEngine.Purchasing.Extension.IStore

#### Constructors
- protected AbstractStore()

#### Methods
- public abstract void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId)
- public abstract void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback)
- public abstract void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload)
- public abstract void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products)

### public interface UnityEngine.Purchasing.Extension.ICatalogProvider

#### Methods
- public void FetchProducts(System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback)

### public interface UnityEngine.Purchasing.Extension.IPurchasingBinder

#### Methods
- public void RegisterConfiguration<T>(T instance)
- public void RegisterExtension<T>(T instance)
- public void RegisterStore(string name, UnityEngine.Purchasing.Extension.IStore store)
- public void SetCatalogProvider(UnityEngine.Purchasing.Extension.ICatalogProvider provider)
- public void SetCatalogProviderFunction(System.Action<System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>>> func)

### public interface UnityEngine.Purchasing.Extension.IPurchasingModule

#### Methods
- public void Configure(UnityEngine.Purchasing.Extension.IPurchasingBinder binder)

### public interface UnityEngine.Purchasing.Extension.IStore

#### Methods
- public void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId)
- public void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback)
- public void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload)
- public void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products)

### public interface UnityEngine.Purchasing.Extension.IStoreCallback

#### Properties
- public UnityEngine.Purchasing.ProductCollection products { get; }
- public bool useTransactionLog { get; set; }

#### Methods
- public void OnAllPurchasesRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts)
- public void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products)
- public void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription desc)
- public void OnPurchaseSucceeded(string storeSpecificId, string receipt, string transactionIdentifier)
- public void OnSetupFailed(UnityEngine.Purchasing.InitializationFailureReason reason)
- public void OnSetupFailed(UnityEngine.Purchasing.InitializationFailureReason reason, string message)

### public interface UnityEngine.Purchasing.Extension.IStoreConfiguration

### public class UnityEngine.Purchasing.Extension.ProductDescription

#### Fields
- private UnityEngine.Purchasing.ProductMetadata <metadata>k__BackingField
- private string <receipt>k__BackingField
- private string <storeSpecificId>k__BackingField
- private string <transactionId>k__BackingField
- public UnityEngine.Purchasing.ProductType type

#### Properties
- public UnityEngine.Purchasing.ProductMetadata metadata { get; private set; }
- public string receipt { get; private set; }
- public string storeSpecificId { get; private set; }
- public string transactionId { get; set; }

#### Constructors
- public ProductDescription(string id, UnityEngine.Purchasing.ProductMetadata metadata)
- public ProductDescription(string id, UnityEngine.Purchasing.ProductMetadata metadata, string receipt, string transactionId)
- public ProductDescription(string id, UnityEngine.Purchasing.ProductMetadata metadata, string receipt, string transactionId, UnityEngine.Purchasing.ProductType type)

### public class UnityEngine.Purchasing.Extension.PurchaseFailureDescription

#### Fields
- private string <message>k__BackingField
- private string <productId>k__BackingField
- private UnityEngine.Purchasing.PurchaseFailureReason <reason>k__BackingField

#### Properties
- public string message { get; private set; }
- public string productId { get; private set; }
- public UnityEngine.Purchasing.PurchaseFailureReason reason { get; private set; }

#### Constructors
- public PurchaseFailureDescription(string productId, UnityEngine.Purchasing.PurchaseFailureReason reason, string message)

## Namespace: UnityEngine.Purchasing.Telemetry

### private class UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticsInstanceWrapper.<>c__DisplayClass7_0

#### Fields
- public UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticsInstanceWrapper <>4__this
- public UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticParams diagnosticParams

#### Constructors
- public TelemetryDiagnosticsInstanceWrapper.<>c__DisplayClass7_0()

#### Methods
- internal void <SendDiagnosticOnMainThread>b__0()

### private class UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper.<>c__DisplayClass7_0

#### Fields
- public UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper <>4__this
- public UnityEngine.Purchasing.Telemetry.TelemetryMetricParams metricParams

#### Constructors
- public TelemetryMetricsInstanceWrapper.<>c__DisplayClass7_0()

#### Methods
- internal void <SendMetricOnMainThread>b__0()

### internal class UnityEngine.Purchasing.Telemetry.IapTelemetryException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public IapTelemetryException()
- public IapTelemetryException(string message)
- public IapTelemetryException(string message, System.Exception innerException)

### internal interface UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics

#### Methods
- public void SendDiagnostic(string diagnosticName, System.Exception e)

### internal interface UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper

#### Methods
- public void SendDiagnostic(string diagnosticName, string diagnosticException)
- public void SetDiagnosticsInstance(Unity.Services.Core.Telemetry.Internal.IDiagnostics diagnosticsInstance)

### internal interface UnityEngine.Purchasing.Telemetry.ITelemetryMetricEvent

#### Methods
- public void StartMetric()
- public void StopAndSendMetric()

### internal interface UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper

#### Methods
- public void SendMetric(UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes telemetryMetricTypes, string metricName, double metricTimeSeconds)
- public void SetMetricsInstance(Unity.Services.Core.Telemetry.Internal.IMetrics metricsInstance)

### internal interface UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService

#### Methods
- public UnityEngine.Purchasing.Telemetry.ITelemetryMetricEvent CreateAndStartMetricEvent(UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition metricDefinition)
- public void ExecuteTimedAction(System.Action timedAction, UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition metricDefinition)

### internal static class UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticNames

#### Fields
- internal static const string FetchPurchasesError
- internal static const string InvalidProductError
- internal static const string ParseReceiptTransactionError
- internal static const string QueryAsyncSkuError
- internal static const string SkuDetailsResponseConsolidatorError
- internal static const string SkuDetailsResponseError

### internal struct UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticParams

#### Fields
- internal string exception
- internal string name

#### Constructors
- internal TelemetryDiagnosticParams(string diagnosticName, string diagnosticException)

### internal class UnityEngine.Purchasing.Telemetry.TelemetryDiagnostics
- Interfaces: UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics

#### Fields
- private readonly UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper m_TelemetryDiagnosticsInstanceWrapper

#### Constructors
- public TelemetryDiagnostics(UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper)

#### Methods
- public void SendDiagnostic(string diagnosticName, System.Exception e)

### internal class UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticsInstanceWrapper
- Interfaces: UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper

#### Fields
- private Unity.Services.Core.Telemetry.Internal.IDiagnostics m_Instance
- private UnityEngine.ILogger m_Logger
- private readonly UnityEngine.Purchasing.Telemetry.TelemetryQueue<UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticParams> m_Queue
- private Uniject.IUtil m_Util

#### Constructors
- public TelemetryDiagnosticsInstanceWrapper(UnityEngine.ILogger logger, Uniject.IUtil util)

#### Methods
- public void SendDiagnostic(string diagnosticName, string diagnosticException)
- private void SendDiagnosticAndCatchExceptions(UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticParams diagnosticParams)
- private void SendDiagnosticOnMainThread(UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticParams diagnosticParams)
- public void SetDiagnosticsInstance(Unity.Services.Core.Telemetry.Internal.IDiagnostics diagnosticsInstance)

### internal struct UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition

#### Fields
- private readonly string <MetricName>k__BackingField
- private readonly UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes <MetricType>k__BackingField

#### Properties
- public string MetricName { get; }
- public UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes MetricType { get; }

#### Constructors
- public TelemetryMetricDefinition(string metricName, UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes metricType = Histogram)

#### Methods
- public static UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition op_Implicit(string name)

### internal static class UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinitions

#### Fields
- internal static readonly UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition confirmSubscriptionPriceChangeName
- internal static readonly UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition continuePromotionalPurchasesName
- internal static readonly UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition dequeueQueryProductsTimeName
- internal static readonly UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition dequeueQueryPurchasesTimeName
- internal static readonly UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition fetchStorePromotionOrderName
- internal static readonly UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition fetchStorePromotionVisibilityName
- internal static readonly UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition initPurchaseName
- internal static readonly UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition packageInitTimeName
- internal static readonly UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition presentCodeRedemptionSheetName
- internal static readonly UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition refreshAppReceiptName
- internal static readonly UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition restoreTransactionName
- internal static readonly UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition retrieveProductsName
- internal static readonly UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition setStorePromotionOrderName
- internal static readonly UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition setStorePromotionVisibilityName
- internal static readonly UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition upgradeDowngradeSubscriptionName

#### Constructors
- private static TelemetryMetricDefinitions()

### internal class UnityEngine.Purchasing.Telemetry.TelemetryMetricEvent
- Interfaces: UnityEngine.Purchasing.Telemetry.ITelemetryMetricEvent

#### Fields
- private readonly string m_MetricName
- private readonly UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes m_MetricType
- private System.Diagnostics.Stopwatch m_Stopwatch
- private readonly UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper

#### Constructors
- internal TelemetryMetricEvent(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper, UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes metricType, string metricName)

#### Methods
- public void StartMetric()
- public void StopAndSendMetric()

### internal struct UnityEngine.Purchasing.Telemetry.TelemetryMetricParams

#### Fields
- internal string name
- internal double timeSeconds
- internal UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes type

#### Constructors
- internal TelemetryMetricParams(UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes metricType, string metricName, double metricTimeSeconds)

### internal class UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper
- Interfaces: UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper

#### Fields
- private Unity.Services.Core.Telemetry.Internal.IMetrics m_Instance
- private UnityEngine.ILogger m_Logger
- private readonly UnityEngine.Purchasing.Telemetry.TelemetryQueue<UnityEngine.Purchasing.Telemetry.TelemetryMetricParams> m_Queue
- private Uniject.IUtil m_Util

#### Constructors
- public TelemetryMetricsInstanceWrapper(UnityEngine.ILogger logger, Uniject.IUtil util)

#### Methods
- public void SendMetric(UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes metricType, string metricName, double metricTimeSeconds)
- private void SendMetricByType(UnityEngine.Purchasing.Telemetry.TelemetryMetricParams metricParams)
- private void SendMetricByTypeAndCatchExceptions(UnityEngine.Purchasing.Telemetry.TelemetryMetricParams metricParams)
- private void SendMetricOnMainThread(UnityEngine.Purchasing.Telemetry.TelemetryMetricParams metricParams)
- public void SetMetricsInstance(Unity.Services.Core.Telemetry.Internal.IMetrics metricsInstance)

### internal class UnityEngine.Purchasing.Telemetry.TelemetryMetricsService
- Interfaces: UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService

#### Fields
- private readonly UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper

#### Constructors
- public TelemetryMetricsService(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper)

#### Methods
- public UnityEngine.Purchasing.Telemetry.ITelemetryMetricEvent CreateAndStartMetricEvent(UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition metricDefinition)
- public void ExecuteTimedAction(System.Action timedAction, UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition metricDefinition)

### internal enum UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Gauge = 0
- Histogram = 2
- Sum = 1

### internal class UnityEngine.Purchasing.Telemetry.TelemetryQueue<TTelemetryEventParams>

#### Fields
- internal static const int k_maxQueueSize
- private System.Collections.Concurrent.ConcurrentQueue<TTelemetryEventParams> m_Queue
- private readonly System.Action<TTelemetryEventParams> m_SendTelemetryEvent

#### Constructors
- public TelemetryQueue<TTelemetryEventParams>(System.Action<TTelemetryEventParams> sendTelemetryEvent)

#### Methods
- internal void QueueEvent(TTelemetryEventParams telemetryEvent)
- internal void SendQueuedEvents()

