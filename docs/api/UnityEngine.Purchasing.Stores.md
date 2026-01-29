# Assembly: UnityEngine.Purchasing.Stores
- Path: tools/WorldBox.Managed/UnityEngine.Purchasing.Stores.dll
- Types: 287

## Namespace: (global)

### internal class <>f__AnonymousType0<<product>j__TPar, <metadata>j__TPar>

#### Fields
- private readonly <metadata>j__TPar <metadata>i__Field
- private readonly <product>j__TPar <product>i__Field

#### Properties
- public <metadata>j__TPar metadata { get; }
- public <product>j__TPar product { get; }

#### Constructors
- public <>f__AnonymousType0<<product>j__TPar, <metadata>j__TPar>(<product>j__TPar product, <metadata>j__TPar metadata)

#### Methods
- public override bool Equals(object value)
- public override int GetHashCode()
- public override string ToString()

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=8459 41EB0297398A8CE425E397D20D8CC5262D0453E1754EF9C6F2C8BDBA0A762BB4
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 64E402E7D8F13D589722D4368AD99BC4134C7B4F479B01925E258B03358BC87C
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16264 BCC7E472E64556BE1B229311DA941B4C4915ECA6DF81F897BD9DC51571E4A578
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=112 CBA27012B0DFF992F7858C87D9D4D5EF5E79A27A359B56B8F4AC4E4CBFEC69F5

#### Methods
- internal static uint ComputeStringHash(string s)

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=112

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16264

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=8459

## Namespace: Microsoft.CodeAnalysis

### internal class Microsoft.CodeAnalysis.EmbeddedAttribute
- Base: System.Attribute

#### Constructors
- public EmbeddedAttribute()

## Namespace: Stores.Util

### internal class Stores.Util.JsonProductDescriptionsDeserializer

#### Constructors
- public JsonProductDescriptionsDeserializer()

#### Methods
- internal virtual UnityEngine.Purchasing.ProductMetadata DeserializeMetadata(System.Collections.Generic.Dictionary<string, object> data)
- public System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> DeserializeProductDescriptions(string json)

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

## Namespace: UnityEngine.Purchasing

### private struct UnityEngine.Purchasing.ExponentialRetryPolicy.<>c__DisplayClass4_0.<<Invoke>g__Retry|0>d
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public UnityEngine.Purchasing.ExponentialRetryPolicy.<>c__DisplayClass4_0 <>4__this
- public System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct UnityEngine.Purchasing.GoogleConnectionRetryPolicy.<>c__DisplayClass4_0.<<Invoke>g__WaitAndRetry|0>d
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public UnityEngine.Purchasing.GoogleConnectionRetryPolicy.<>c__DisplayClass4_0 <>4__this
- public System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct UnityEngine.Purchasing.ExponentialRetryPolicy.<>c__DisplayClass4_0.<<Invoke>g__WaitAndRetry|1>d
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public UnityEngine.Purchasing.ExponentialRetryPolicy.<>c__DisplayClass4_0 <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class UnityEngine.Purchasing.GoogleCachedQueryProductDetailsService.<>c

#### Fields
- public static readonly UnityEngine.Purchasing.GoogleCachedQueryProductDetailsService.<>c <>9
- public static System.Func<UnityEngine.Purchasing.ProductDefinition, string> <>9__5_0

#### Constructors
- private static GoogleCachedQueryProductDetailsService.<>c()
- public GoogleCachedQueryProductDetailsService.<>c()

#### Methods
- internal string <GetCachedQueriedProductDetails>b__5_0(UnityEngine.Purchasing.ProductDefinition product)

### private class UnityEngine.Purchasing.GoogleQueryPurchasesService.<>c

#### Fields
- public static readonly UnityEngine.Purchasing.GoogleQueryPurchasesService.<>c <>9
- public static System.Func<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>9__3_0

#### Constructors
- private static GoogleQueryPurchasesService.<>c()
- public GoogleQueryPurchasesService.<>c()

#### Methods
- internal System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> <QueryPurchases>b__3_0(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> result)

### private class UnityEngine.Purchasing.ProductDetailsQueryResponse.<>c

#### Fields
- public static readonly UnityEngine.Purchasing.ProductDetailsQueryResponse.<>c <>9
- public static System.Func<UnityEngine.AndroidJavaObject, UnityEngine.AndroidJavaObject> <>9__2_0
- public static System.Func<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>, bool> <>9__3_0
- public static System.Func<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> <>9__3_1
- public static System.Func<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>, UnityEngine.Purchasing.Models.IGoogleBillingResult> <>9__4_0
- public static System.Func<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>, UnityEngine.Purchasing.Models.IGoogleBillingResult> <>9__5_0
- public static System.Func<UnityEngine.Purchasing.Models.IGoogleBillingResult, bool> <>9__5_1

#### Constructors
- private static ProductDetailsQueryResponse.<>c()
- public ProductDetailsQueryResponse.<>c()

#### Methods
- internal UnityEngine.AndroidJavaObject <AddResponse>b__2_0(UnityEngine.AndroidJavaObject product)
- internal UnityEngine.Purchasing.Models.IGoogleBillingResult <GetGoogleBillingResult>b__5_0(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response)
- internal bool <GetGoogleBillingResult>b__5_1(UnityEngine.Purchasing.Models.IGoogleBillingResult response)
- internal UnityEngine.Purchasing.Models.IGoogleBillingResult <IsRecoverable>b__4_0(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response)
- internal bool <ProductDetails>b__3_0(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response)
- internal System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> <ProductDetails>b__3_1(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response)

### private class UnityEngine.Purchasing.QueryProductDetailsService.<>c

#### Fields
- public static readonly UnityEngine.Purchasing.QueryProductDetailsService.<>c <>9
- public static System.Func<bool, bool> <>9__14_0
- public static System.Func<UnityEngine.Purchasing.ProductDefinition, bool> <>9__16_0
- public static System.Func<UnityEngine.Purchasing.ProductDefinition, string> <>9__16_1
- public static System.Func<UnityEngine.Purchasing.ProductDefinition, bool> <>9__17_0
- public static System.Func<UnityEngine.Purchasing.ProductDefinition, string> <>9__17_1

#### Constructors
- private static QueryProductDetailsService.<>c()
- public QueryProductDetailsService.<>c()

#### Methods
- internal bool <AreAllProductDetailsCached>b__14_0(bool isCached)
- internal bool <QueryInAppsAsync>b__16_0(UnityEngine.Purchasing.ProductDefinition product)
- internal string <QueryInAppsAsync>b__16_1(UnityEngine.Purchasing.ProductDefinition product)
- internal bool <QuerySubsAsync>b__17_0(UnityEngine.Purchasing.ProductDefinition product)
- internal string <QuerySubsAsync>b__17_1(UnityEngine.Purchasing.ProductDefinition product)

### private class UnityEngine.Purchasing.GoogleFetchPurchases.<>c

#### Fields
- public static readonly UnityEngine.Purchasing.GoogleFetchPurchases.<>c <>9
- public static System.Func<UnityEngine.Purchasing.Interfaces.IGooglePurchase, bool> <>9__11_0
- public static System.Func<UnityEngine.Purchasing.Interfaces.IGooglePurchase, bool> <>9__12_0

#### Constructors
- private static GoogleFetchPurchases.<>c()
- public GoogleFetchPurchases.<>c()

#### Methods
- internal bool <PurchaseIsPending>b__12_0(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase)
- internal bool <PurchaseIsPurchased>b__11_0(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase)

### private class UnityEngine.Purchasing.AppleStoreImpl.<>c

#### Fields
- public static readonly UnityEngine.Purchasing.AppleStoreImpl.<>c <>9
- public static System.Comparison<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt> <>9__39_1
- public static System.Func<System.Collections.Generic.KeyValuePair<string, object>, string> <>9__62_0
- public static System.Func<System.Collections.Generic.KeyValuePair<string, object>, string> <>9__62_1

#### Constructors
- private static AppleStoreImpl.<>c()
- public AppleStoreImpl.<>c()

#### Methods
- internal int <FindMostRecentReceipt>b__39_1(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt b, UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt a)
- internal string <OnFetchStorePromotionVisibilitySucceeded>b__62_0(System.Collections.Generic.KeyValuePair<string, object> k)
- internal string <OnFetchStorePromotionVisibilitySucceeded>b__62_1(System.Collections.Generic.KeyValuePair<string, object> k)

### private class UnityEngine.Purchasing.UIFakeStore.<>c

#### Fields
- public static readonly UnityEngine.Purchasing.UIFakeStore.<>c <>9
- public static System.Func<UnityEngine.Purchasing.ProductDefinition, string> <>9__20_0

#### Constructors
- private static UIFakeStore.<>c()
- public UIFakeStore.<>c()

#### Methods
- internal string <CreateRetrieveProductsQuestion>b__20_0(UnityEngine.Purchasing.ProductDefinition pid)

### private class UnityEngine.Purchasing.LocalizedProductDescription.<>c

#### Fields
- public static readonly UnityEngine.Purchasing.LocalizedProductDescription.<>c <>9
- public static System.Text.RegularExpressions.MatchEvaluator <>9__11_0

#### Constructors
- private static LocalizedProductDescription.<>c()
- public LocalizedProductDescription.<>c()

#### Methods
- internal string <DecodeNonLatinCharacters>b__11_0(System.Text.RegularExpressions.Match m)

### private class UnityEngine.Purchasing.ProductCatalog.<>c

#### Fields
- public static readonly UnityEngine.Purchasing.ProductCatalog.<>c <>9
- public static System.Func<UnityEngine.Purchasing.ProductCatalogItem, bool> <>9__9_0

#### Constructors
- private static ProductCatalog.<>c()
- public ProductCatalog.<>c()

#### Methods
- internal bool <get_allValidProducts>b__9_0(UnityEngine.Purchasing.ProductCatalogItem x)

### private class UnityEngine.Purchasing.SubscriptionManager.<>c

#### Fields
- public static readonly UnityEngine.Purchasing.SubscriptionManager.<>c <>9
- public static System.Comparison<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt> <>9__11_0
- public static System.Func<object, string> <>9__12_0

#### Constructors
- private static SubscriptionManager.<>c()
- public SubscriptionManager.<>c()

#### Methods
- internal int <findMostRecentReceipt>b__11_0(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt b, UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt a)
- internal string <getGooglePlayStoreSubInfo>b__12_0(object obj)

### private class UnityEngine.Purchasing.WinRTStore.<>c

#### Fields
- public static readonly UnityEngine.Purchasing.WinRTStore.<>c <>9
- public static System.Func<UnityEngine.Purchasing.Default.WinProductDescription, <>f__AnonymousType0<UnityEngine.Purchasing.Default.WinProductDescription, UnityEngine.Purchasing.ProductMetadata>> <>9__15_1
- public static System.Func<<>f__AnonymousType0<UnityEngine.Purchasing.Default.WinProductDescription, UnityEngine.Purchasing.ProductMetadata>, UnityEngine.Purchasing.Extension.ProductDescription> <>9__15_2
- public static System.Func<UnityEngine.Purchasing.ProductDefinition, bool> <>9__8_0
- public static System.Func<UnityEngine.Purchasing.ProductDefinition, UnityEngine.Purchasing.Default.WinProductDescription> <>9__8_1

#### Constructors
- private static WinRTStore.<>c()
- public WinRTStore.<>c()

#### Methods
- internal <>f__AnonymousType0<UnityEngine.Purchasing.Default.WinProductDescription, UnityEngine.Purchasing.ProductMetadata> <OnProductListReceived>b__15_1(UnityEngine.Purchasing.Default.WinProductDescription product)
- internal UnityEngine.Purchasing.Extension.ProductDescription <OnProductListReceived>b__15_2(<>f__AnonymousType0<UnityEngine.Purchasing.Default.WinProductDescription, UnityEngine.Purchasing.ProductMetadata> <>h__TransparentIdentifier0)
- internal bool <RetrieveProducts>b__8_0(UnityEngine.Purchasing.ProductDefinition def)
- internal UnityEngine.Purchasing.Default.WinProductDescription <RetrieveProducts>b__8_1(UnityEngine.Purchasing.ProductDefinition def)

### private class UnityEngine.Purchasing.EnumerableExtensions.<>c__0<T>

#### Fields
- public static readonly UnityEngine.Purchasing.EnumerableExtensions.<>c__0<T> <>9
- public static System.Func<T, bool> <>9__0_0

#### Constructors
- private static EnumerableExtensions.<>c__0<T>()
- public EnumerableExtensions.<>c__0<T>()

#### Methods
- internal bool <NonNull>b__0_0(T obj)

### private class UnityEngine.Purchasing.QueryProductDetailsService.<>c__DisplayClass10_0

#### Fields
- public UnityEngine.Purchasing.QueryProductDetailsService <>4__this
- public System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse
- public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products
- public int retryCount

#### Constructors
- public QueryProductDetailsService.<>c__DisplayClass10_0()

#### Methods
- internal void <QueryAsyncProduct>b__0(System.Action retryAction)
- internal void <QueryAsyncProduct>g__OnActionRetry|1()

### private class UnityEngine.Purchasing.GoogleFetchPurchases.<>c__DisplayClass10_0

#### Fields
- public UnityEngine.Purchasing.GoogleFetchPurchases <>4__this
- public System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> deferredPurchases

#### Constructors
- public GoogleFetchPurchases.<>c__DisplayClass10_0()

#### Methods
- internal void <OnFetchedPurchase>b__0()

### private class UnityEngine.Purchasing.GooglePlayStoreRetrieveProductsService.<>c__DisplayClass10_0

#### Fields
- public UnityEngine.Purchasing.GooglePlayStoreRetrieveProductsService <>4__this
- public System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts

#### Constructors
- public GooglePlayStoreRetrieveProductsService.<>c__DisplayClass10_0()

#### Methods
- internal void <OnProductsRetrievedWithPurchaseFetch>b__0(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchaseProducts)

### private class UnityEngine.Purchasing.ScriptingStoreCallback.<>c__DisplayClass10_0

#### Fields
- public UnityEngine.Purchasing.ScriptingStoreCallback <>4__this
- public UnityEngine.Purchasing.Extension.PurchaseFailureDescription desc

#### Constructors
- public ScriptingStoreCallback.<>c__DisplayClass10_0()

#### Methods
- internal void <OnPurchaseFailed>b__0()

### private class UnityEngine.Purchasing.UDPImpl.<>c__DisplayClass10_0

#### Fields
- public UnityEngine.Purchasing.UDPImpl <>4__this
- public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products

#### Constructors
- public UDPImpl.<>c__DisplayClass10_0()

#### Methods
- internal void <RetrieveProducts>b__1(bool success, string message)
- internal void <RetrieveProducts>g__retrieveCallback|0(bool success, string json)

### private class UnityEngine.Purchasing.MetricizedAppleStoreImpl.<>c__DisplayClass10_0

#### Fields
- public UnityEngine.Purchasing.MetricizedAppleStoreImpl <>4__this
- public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products

#### Constructors
- public MetricizedAppleStoreImpl.<>c__DisplayClass10_0()

#### Methods
- internal void <RetrieveProducts>b__0()

### private class UnityEngine.Purchasing.UIFakeStore.<>c__DisplayClass10_0<T>

#### Fields
- public System.Action<bool, T> callback

#### Constructors
- public UIFakeStore.<>c__DisplayClass10_0<T>()

#### Methods
- internal void <StartUI>b__0(bool result, int codeValue)

### private class UnityEngine.Purchasing.UDPImpl.<>c__DisplayClass11_0

#### Fields
- public UnityEngine.Purchasing.UDPImpl <>4__this
- public UnityEngine.Purchasing.ProductDefinition product

#### Constructors
- public UDPImpl.<>c__DisplayClass11_0()

#### Methods
- internal void <Purchase>b__0(bool success, string message)

### private class UnityEngine.Purchasing.MetricizedAppleStoreImpl.<>c__DisplayClass11_0

#### Fields
- public UnityEngine.Purchasing.MetricizedAppleStoreImpl <>4__this
- public string developerPayload
- public UnityEngine.Purchasing.ProductDefinition product

#### Constructors
- public MetricizedAppleStoreImpl.<>c__DisplayClass11_0()

#### Methods
- internal void <Purchase>b__0()

### private class UnityEngine.Purchasing.QueryProductDetailsService.<>c__DisplayClass12_0

#### Fields
- public UnityEngine.Purchasing.QueryProductDetailsService <>4__this
- public System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse
- public System.Collections.Generic.IReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products
- public System.Action retryQuery

#### Constructors
- public QueryProductDetailsService.<>c__DisplayClass12_0()

#### Methods
- internal void <TryQueryAsyncProductWithRetries>b__0(UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse productDetailsQueryResponse)

### private class UnityEngine.Purchasing.GooglePlayStoreExtensions.<>c__DisplayClass12_0

#### Fields
- public System.Action<bool> callback

#### Constructors
- public GooglePlayStoreExtensions.<>c__DisplayClass12_0()

#### Methods
- internal void <RestoreTransactions>b__0(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> _)

### private class UnityEngine.Purchasing.GooglePlayStoreExtensions.<>c__DisplayClass13_0

#### Fields
- public System.Action<bool, string> callback

#### Constructors
- public GooglePlayStoreExtensions.<>c__DisplayClass13_0()

#### Methods
- internal void <RestoreTransactions>b__0(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> _)

### private class UnityEngine.Purchasing.FakeStore.<>c__DisplayClass13_0

#### Fields
- public UnityEngine.Purchasing.FakeStore <>4__this
- public System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products

#### Constructors
- public FakeStore.<>c__DisplayClass13_0()

#### Methods
- internal void <StoreRetrieveProducts>g__handleAllowInitializeOrRetrieveProducts|0(bool allow, UnityEngine.Purchasing.InitializationFailureReason failureReason)

### private class UnityEngine.Purchasing.GooglePlayStoreRetrieveProductsService.<>c__DisplayClass14_0

#### Fields
- public UnityEngine.Purchasing.Product purchaseProduct

#### Constructors
- public GooglePlayStoreRetrieveProductsService.<>c__DisplayClass14_0()

#### Methods
- internal bool <MakePurchasesIntoProducts>b__0(UnityEngine.Purchasing.Extension.ProductDescription product)

### private class UnityEngine.Purchasing.FakeStore.<>c__DisplayClass15_0

#### Fields
- public UnityEngine.Purchasing.FakeStore <>4__this
- public UnityEngine.Purchasing.ProductDefinition product

#### Constructors
- public FakeStore.<>c__DisplayClass15_0()

#### Methods
- internal void <FakePurchase>g__handleAllowPurchase|0(bool allow, UnityEngine.Purchasing.PurchaseFailureReason failureReason)

### private class UnityEngine.Purchasing.WinRTStore.<>c__DisplayClass15_0

#### Fields
- public UnityEngine.Purchasing.WinRTStore <>4__this
- public UnityEngine.Purchasing.Default.WinProductDescription[] winProducts

#### Constructors
- public WinRTStore.<>c__DisplayClass15_0()

#### Methods
- internal void <OnProductListReceived>b__0()

### private class UnityEngine.Purchasing.ProductCatalogItem.<>c__DisplayClass16_0

#### Fields
- public string aStore

#### Constructors
- public ProductCatalogItem.<>c__DisplayClass16_0()

#### Methods
- internal bool <SetStoreID>b__0(UnityEngine.Purchasing.StoreID obj)

### private class UnityEngine.Purchasing.WinRTStore.<>c__DisplayClass16_0

#### Fields
- public UnityEngine.Purchasing.WinRTStore <>4__this
- public string message

#### Constructors
- public WinRTStore.<>c__DisplayClass16_0()

#### Methods
- internal void <log>b__0()

### private class UnityEngine.Purchasing.ProductCatalogItem.<>c__DisplayClass17_0

#### Fields
- public string store

#### Constructors
- public ProductCatalogItem.<>c__DisplayClass17_0()

#### Methods
- internal bool <GetStoreID>b__0(UnityEngine.Purchasing.StoreID obj)

### private class UnityEngine.Purchasing.WinRTStore.<>c__DisplayClass17_0

#### Fields
- public UnityEngine.Purchasing.WinRTStore <>4__this
- public string error
- public string productId

#### Constructors
- public WinRTStore.<>c__DisplayClass17_0()

#### Methods
- internal void <OnPurchaseFailed>b__0()

### private class UnityEngine.Purchasing.WinRTStore.<>c__DisplayClass18_0

#### Fields
- public UnityEngine.Purchasing.WinRTStore <>4__this
- public string productId
- public string receipt
- public string tranId

#### Constructors
- public WinRTStore.<>c__DisplayClass18_0()

#### Methods
- internal void <OnPurchaseSucceeded>b__0()

### private class UnityEngine.Purchasing.WinRTStore.<>c__DisplayClass19_0

#### Fields
- public UnityEngine.Purchasing.WinRTStore <>4__this
- public string message

#### Constructors
- public WinRTStore.<>c__DisplayClass19_0()

#### Methods
- internal void <OnProductListError>b__0()

### private class UnityEngine.Purchasing.ProductCatalogItem.<>c__DisplayClass20_0

#### Fields
- public UnityEngine.Purchasing.StoreID storeId

#### Constructors
- public ProductCatalogItem.<>c__DisplayClass20_0()

#### Methods
- internal bool <SetStoreIDs>b__0(UnityEngine.Purchasing.StoreID obj)

### private class UnityEngine.Purchasing.GooglePlayStoreService.<>c__DisplayClass21_0

#### Fields
- public UnityEngine.Purchasing.GooglePlayStoreService <>4__this
- public System.Action ActionToRetry

#### Constructors
- public GooglePlayStoreService.<>c__DisplayClass21_0()

#### Methods
- internal void <RetryConnection>b__0()

### private class UnityEngine.Purchasing.ProductCatalogItem.<>c__DisplayClass21_0

#### Fields
- public UnityEngine.Purchasing.TranslationLocale locale

#### Constructors
- public ProductCatalogItem.<>c__DisplayClass21_0()

#### Methods
- internal bool <GetDescription>b__0(UnityEngine.Purchasing.LocalizedProductDescription obj)

### private class UnityEngine.Purchasing.ProductCatalogItem.<>c__DisplayClass24_0

#### Fields
- public UnityEngine.Purchasing.TranslationLocale locale

#### Constructors
- public ProductCatalogItem.<>c__DisplayClass24_0()

#### Methods
- internal bool <RemoveDescription>b__0(UnityEngine.Purchasing.LocalizedProductDescription obj)

### private class UnityEngine.Purchasing.MetricizedGooglePlayStoreExtensions.<>c__DisplayClass2_0

#### Fields
- public UnityEngine.Purchasing.MetricizedGooglePlayStoreExtensions <>4__this
- public UnityEngine.Purchasing.GooglePlayReplacementMode desiredReplacementMode
- public string newSku
- public string oldSku

#### Constructors
- public MetricizedGooglePlayStoreExtensions.<>c__DisplayClass2_0()

#### Methods
- internal void <UpgradeDowngradeSubscription>b__0()

### private class UnityEngine.Purchasing.MetricizedAppleStoreImpl.<>c__DisplayClass2_0

#### Fields
- public UnityEngine.Purchasing.MetricizedAppleStoreImpl <>4__this
- public System.Action errorCallback
- public System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> successCallback

#### Constructors
- public MetricizedAppleStoreImpl.<>c__DisplayClass2_0()

#### Methods
- internal void <FetchStorePromotionOrder>b__0()

### private class UnityEngine.Purchasing.MetricizedJsonStore.<>c__DisplayClass2_0

#### Fields
- public UnityEngine.Purchasing.MetricizedJsonStore <>4__this
- public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products

#### Constructors
- public MetricizedJsonStore.<>c__DisplayClass2_0()

#### Methods
- internal void <RetrieveProducts>b__0()

### private class UnityEngine.Purchasing.AppleStoreImpl.<>c__DisplayClass39_0

#### Fields
- public string productId

#### Constructors
- public AppleStoreImpl.<>c__DisplayClass39_0()

#### Methods
- internal bool <FindMostRecentReceipt>b__0(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt r)

### private class UnityEngine.Purchasing.MetricizedGooglePlayStoreService.<>c__DisplayClass3_0

#### Fields
- public UnityEngine.Purchasing.MetricizedGooglePlayStoreService <>4__this
- public UnityEngine.Purchasing.Models.GoogleBillingResponseCode googleBillingResponseCode

#### Constructors
- public MetricizedGooglePlayStoreService.<>c__DisplayClass3_0()

#### Methods
- internal void <DequeueQueryProducts>b__0()

### private class UnityEngine.Purchasing.MetricizedGooglePlayStoreExtensions.<>c__DisplayClass3_0

#### Fields
- public UnityEngine.Purchasing.MetricizedGooglePlayStoreExtensions <>4__this
- public System.Action<bool> callback

#### Constructors
- public MetricizedGooglePlayStoreExtensions.<>c__DisplayClass3_0()

#### Methods
- internal void <RestoreTransactions>b__0()

### private class UnityEngine.Purchasing.ScriptingUnityCallback.<>c__DisplayClass3_0

#### Fields
- public UnityEngine.Purchasing.ScriptingUnityCallback <>4__this
- public string json

#### Constructors
- public ScriptingUnityCallback.<>c__DisplayClass3_0()

#### Methods
- internal void <OnSetupFailed>b__0()

### private class UnityEngine.Purchasing.MetricizedAppleStoreImpl.<>c__DisplayClass3_0

#### Fields
- public UnityEngine.Purchasing.MetricizedAppleStoreImpl <>4__this
- public System.Action errorCallback
- public UnityEngine.Purchasing.Product product
- public System.Action<string, UnityEngine.Purchasing.AppleStorePromotionVisibility> successCallback

#### Constructors
- public MetricizedAppleStoreImpl.<>c__DisplayClass3_0()

#### Methods
- internal void <FetchStorePromotionVisibility>b__0()

### private class UnityEngine.Purchasing.MetricizedJsonStore.<>c__DisplayClass3_0

#### Fields
- public UnityEngine.Purchasing.MetricizedJsonStore <>4__this
- public string developerPayload
- public UnityEngine.Purchasing.ProductDefinition product

#### Constructors
- public MetricizedJsonStore.<>c__DisplayClass3_0()

#### Methods
- internal void <Purchase>b__0()

### private class UnityEngine.Purchasing.AppleStoreImpl.<>c__DisplayClass44_0

#### Fields
- public System.Action errorCallback

#### Constructors
- public AppleStoreImpl.<>c__DisplayClass44_0()

#### Methods
- internal void <RefreshAppReceipt>b__0(string _)

### private class UnityEngine.Purchasing.GoogleFinishTransactionService.<>c__DisplayClass4_0

#### Fields
- public string purchaseToken

#### Constructors
- public GoogleFinishTransactionService.<>c__DisplayClass4_0()

#### Methods
- internal bool <FindPurchase>b__0(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase)

### private class UnityEngine.Purchasing.GooglePurchaseService.<>c__DisplayClass4_0

#### Fields
- public UnityEngine.Purchasing.GooglePurchaseService <>4__this
- public System.Nullable<UnityEngine.Purchasing.GooglePlayReplacementMode> desiredProrationMode
- public UnityEngine.Purchasing.Product oldProduct
- public UnityEngine.Purchasing.ProductDefinition product

#### Constructors
- public GooglePurchaseService.<>c__DisplayClass4_0()

#### Methods
- internal void <Purchase>b__0(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> productDetailsList, UnityEngine.Purchasing.Models.IGoogleBillingResult _)

### private class UnityEngine.Purchasing.GoogleQueryPurchasesService.<>c__DisplayClass4_0

#### Fields
- public UnityEngine.Purchasing.GoogleQueryPurchasesService <>4__this
- public System.Threading.Tasks.TaskCompletionSource<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> taskCompletion

#### Constructors
- public GoogleQueryPurchasesService.<>c__DisplayClass4_0()

#### Methods
- internal void <QueryPurchasesWithSkuType>b__0(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> purchases)

### private class UnityEngine.Purchasing.MetricizedGooglePlayStoreExtensions.<>c__DisplayClass4_0

#### Fields
- public UnityEngine.Purchasing.MetricizedGooglePlayStoreExtensions <>4__this
- public System.Action<bool, string> callback

#### Constructors
- public MetricizedGooglePlayStoreExtensions.<>c__DisplayClass4_0()

#### Methods
- internal void <RestoreTransactions>b__0()

### private class UnityEngine.Purchasing.ScriptingUnityCallback.<>c__DisplayClass4_0

#### Fields
- public UnityEngine.Purchasing.ScriptingUnityCallback <>4__this
- public string json

#### Constructors
- public ScriptingUnityCallback.<>c__DisplayClass4_0()

#### Methods
- internal void <OnProductsRetrieved>b__0()

### private class UnityEngine.Purchasing.MetricizedAppleStoreImpl.<>c__DisplayClass4_0

#### Fields
- public UnityEngine.Purchasing.MetricizedAppleStoreImpl <>4__this
- public System.Collections.Generic.List<UnityEngine.Purchasing.Product> products

#### Constructors
- public MetricizedAppleStoreImpl.<>c__DisplayClass4_0()

#### Methods
- internal void <SetStorePromotionOrder>b__0()

### private class UnityEngine.Purchasing.ExponentialRetryPolicy.<>c__DisplayClass4_0

#### Fields
- public UnityEngine.Purchasing.ExponentialRetryPolicy <>4__this
- public System.Action<System.Action> actionToTry
- public int currentRetryDelay
- public System.Action onRetryAction

#### Constructors
- public ExponentialRetryPolicy.<>c__DisplayClass4_0()

#### Methods
- internal void <Invoke>g__Retry|0()
- internal System.Threading.Tasks.Task <Invoke>g__WaitAndRetry|1()

### private class UnityEngine.Purchasing.GoogleConnectionRetryPolicy.<>c__DisplayClass4_0

#### Fields
- public UnityEngine.Purchasing.GoogleConnectionRetryPolicy <>4__this
- public System.Action<System.Action> actionToTry
- public int currentRetryDelay
- public System.Action onRetryAction
- public int retryAttempts

#### Constructors
- public GoogleConnectionRetryPolicy.<>c__DisplayClass4_0()

#### Methods
- internal void <Invoke>g__WaitAndRetry|0()

### private class UnityEngine.Purchasing.GoogleFinishTransactionService.<>c__DisplayClass5_0

#### Fields
- public System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished
- public UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase

#### Constructors
- public GoogleFinishTransactionService.<>c__DisplayClass5_0()

#### Methods
- internal void <FinishTransactionForPurchase>b__0(UnityEngine.Purchasing.Models.IGoogleBillingResult result)
- internal void <FinishTransactionForPurchase>b__1(UnityEngine.Purchasing.Models.IGoogleBillingResult result)

### private class UnityEngine.Purchasing.GoogleQueryPurchasesService.<>c__DisplayClass5_0

#### Fields
- public UnityEngine.Purchasing.GoogleQueryPurchasesService <>4__this
- public System.Func<UnityEngine.AndroidJavaObject, bool> <>9__1
- public string purchaseToken
- public System.Threading.Tasks.TaskCompletionSource<UnityEngine.Purchasing.Interfaces.IGooglePurchase> taskCompletion

#### Constructors
- public GoogleQueryPurchasesService.<>c__DisplayClass5_0()

#### Methods
- internal void <GetPurchaseByToken>b__0(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> purchases)
- internal bool <GetPurchaseByToken>b__1(UnityEngine.AndroidJavaObject purchase)

### private class UnityEngine.Purchasing.ProductDetailsResponseListener.<>c__DisplayClass5_0

#### Fields
- public UnityEngine.Purchasing.ProductDetailsResponseListener <>4__this
- public UnityEngine.AndroidJavaObject billingResult
- public UnityEngine.AndroidJavaObject productDetails

#### Constructors
- public ProductDetailsResponseListener.<>c__DisplayClass5_0()

#### Methods
- internal void <onProductDetailsResponse>b__0()

### private class UnityEngine.Purchasing.MetricizedGooglePlayStoreService.<>c__DisplayClass5_0

#### Fields
- public UnityEngine.Purchasing.MetricizedGooglePlayStoreService <>4__this
- public System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived
- public System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed
- public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products

#### Constructors
- public MetricizedGooglePlayStoreService.<>c__DisplayClass5_0()

#### Methods
- internal void <RetrieveProducts>b__0()

### private class UnityEngine.Purchasing.ScriptingStoreCallback.<>c__DisplayClass5_0

#### Fields
- public UnityEngine.Purchasing.ScriptingStoreCallback <>4__this
- public UnityEngine.Purchasing.InitializationFailureReason reason

#### Constructors
- public ScriptingStoreCallback.<>c__DisplayClass5_0()

#### Methods
- internal void <OnSetupFailed>b__0()

### private class UnityEngine.Purchasing.ScriptingUnityCallback.<>c__DisplayClass5_0

#### Fields
- public UnityEngine.Purchasing.ScriptingUnityCallback <>4__this
- public string id
- public string receipt
- public string transactionID

#### Constructors
- public ScriptingUnityCallback.<>c__DisplayClass5_0()

#### Methods
- internal void <OnPurchaseSucceeded>b__0()

### private class UnityEngine.Purchasing.MetricizedAppleStoreImpl.<>c__DisplayClass5_0

#### Fields
- public UnityEngine.Purchasing.MetricizedAppleStoreImpl <>4__this
- public System.Action<bool> callback

#### Constructors
- public MetricizedAppleStoreImpl.<>c__DisplayClass5_0()

#### Methods
- internal void <RestoreTransactions>b__0()

### private class UnityEngine.Purchasing.AppleStoreImpl.<>c__DisplayClass64_0

#### Fields
- public bool isRestored
- public string originalTransactionId
- public string payload
- public string receipt
- public string subject
- public string transactionId

#### Constructors
- public AppleStoreImpl.<>c__DisplayClass64_0()

#### Methods
- internal void <MessageCallback>b__0()

### private class UnityEngine.Purchasing.MetricizedGooglePlayStoreService.<>c__DisplayClass6_0

#### Fields
- public UnityEngine.Purchasing.MetricizedGooglePlayStoreService <>4__this
- public System.Nullable<UnityEngine.Purchasing.GooglePlayReplacementMode> desiredReplacementMode
- public UnityEngine.Purchasing.Product oldProduct
- public UnityEngine.Purchasing.ProductDefinition product

#### Constructors
- public MetricizedGooglePlayStoreService.<>c__DisplayClass6_0()

#### Methods
- internal void <Purchase>b__0()

### private class UnityEngine.Purchasing.GoogleFetchPurchases.<>c__DisplayClass6_0

#### Fields
- public UnityEngine.Purchasing.GoogleFetchPurchases <>4__this
- public System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> onQueryPurchaseSucceed

#### Constructors
- public GoogleFetchPurchases.<>c__DisplayClass6_0()

#### Methods
- internal void <FetchPurchases>b__0(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> googlePurchases)

### private class UnityEngine.Purchasing.ScriptingStoreCallback.<>c__DisplayClass6_0

#### Fields
- public UnityEngine.Purchasing.ScriptingStoreCallback <>4__this
- public string message
- public UnityEngine.Purchasing.InitializationFailureReason reason

#### Constructors
- public ScriptingStoreCallback.<>c__DisplayClass6_0()

#### Methods
- internal void <OnSetupFailed>b__0()

### private class UnityEngine.Purchasing.ScriptingUnityCallback.<>c__DisplayClass6_0

#### Fields
- public UnityEngine.Purchasing.ScriptingUnityCallback <>4__this
- public string json

#### Constructors
- public ScriptingUnityCallback.<>c__DisplayClass6_0()

#### Methods
- internal void <OnPurchaseFailed>b__0()

### private class UnityEngine.Purchasing.UDPReflectionUtils.<>c__DisplayClass6_0

#### Fields
- public System.Reflection.Assembly assembly

#### Constructors
- public UDPReflectionUtils.<>c__DisplayClass6_0()

#### Methods
- internal bool <GetTypeByName>b__0(string x)

### private class UnityEngine.Purchasing.MetricizedAppleStoreImpl.<>c__DisplayClass6_0

#### Fields
- public UnityEngine.Purchasing.MetricizedAppleStoreImpl <>4__this
- public System.Action<bool, string> callback

#### Constructors
- public MetricizedAppleStoreImpl.<>c__DisplayClass6_0()

#### Methods
- internal void <RestoreTransactions>b__0()

### private class UnityEngine.Purchasing.GooglePlayStoreFinishTransactionService.<>c__DisplayClass7_0

#### Fields
- public UnityEngine.Purchasing.GooglePlayStoreFinishTransactionService <>4__this
- public UnityEngine.Purchasing.ProductDefinition product

#### Constructors
- public GooglePlayStoreFinishTransactionService.<>c__DisplayClass7_0()

#### Methods
- internal void <FinishTransaction>b__0(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase)

### private class UnityEngine.Purchasing.ScriptingStoreCallback.<>c__DisplayClass7_0

#### Fields
- public UnityEngine.Purchasing.ScriptingStoreCallback <>4__this
- public System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products

#### Constructors
- public ScriptingStoreCallback.<>c__DisplayClass7_0()

#### Methods
- internal void <OnProductsRetrieved>b__0()

### private class UnityEngine.Purchasing.MetricizedAppleStoreImpl.<>c__DisplayClass7_0

#### Fields
- public UnityEngine.Purchasing.MetricizedAppleStoreImpl <>4__this
- public System.Action<string> errorCallback
- public System.Action<string> successCallback

#### Constructors
- public MetricizedAppleStoreImpl.<>c__DisplayClass7_0()

#### Methods
- internal void <RefreshAppReceipt>b__0()

### private class UnityEngine.Purchasing.GooglePlayPurchaseCallback.<>c__DisplayClass8_0

#### Fields
- public UnityEngine.Purchasing.GooglePlayPurchaseCallback <>4__this
- public UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase
- public string purchaseToken
- public string receipt

#### Constructors
- public GooglePlayPurchaseCallback.<>c__DisplayClass8_0()

#### Methods
- internal void <NotifyDeferredPurchase>b__0()

### private class UnityEngine.Purchasing.GoogleFetchPurchases.<>c__DisplayClass8_0

#### Fields
- public UnityEngine.Purchasing.GoogleFetchPurchases <>4__this
- public UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase

#### Constructors
- public GoogleFetchPurchases.<>c__DisplayClass8_0()

#### Methods
- internal UnityEngine.Purchasing.Product <BuildProductsFromPurchase>b__0(string sku)
- internal UnityEngine.Purchasing.Product <BuildProductsFromPurchase>b__1(UnityEngine.Purchasing.Product product)

### private class UnityEngine.Purchasing.ScriptingStoreCallback.<>c__DisplayClass8_0

#### Fields
- public UnityEngine.Purchasing.ScriptingStoreCallback <>4__this
- public string id
- public string receipt
- public string transactionID

#### Constructors
- public ScriptingStoreCallback.<>c__DisplayClass8_0()

#### Methods
- internal void <OnPurchaseSucceeded>b__0()

### private class UnityEngine.Purchasing.QueryProductDetailsService.<>c__DisplayClass9_0

#### Fields
- public UnityEngine.Purchasing.QueryProductDetailsService <>4__this
- public System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse

#### Constructors
- public QueryProductDetailsService.<>c__DisplayClass9_0()

#### Methods
- internal void <QueryAsyncProduct>b__0(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> productDetails, UnityEngine.Purchasing.Models.IGoogleBillingResult responseCode)

### private class UnityEngine.Purchasing.GooglePlayPurchaseCallback.<>c__DisplayClass9_0

#### Fields
- public UnityEngine.Purchasing.GooglePlayPurchaseCallback <>4__this
- public string sku

#### Constructors
- public GooglePlayPurchaseCallback.<>c__DisplayClass9_0()

#### Methods
- internal void <NotifyDeferredProrationUpgradeDowngradeSubscription>b__0()

### private class UnityEngine.Purchasing.ScriptingStoreCallback.<>c__DisplayClass9_0

#### Fields
- public UnityEngine.Purchasing.ScriptingStoreCallback <>4__this
- public System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts

#### Constructors
- public ScriptingStoreCallback.<>c__DisplayClass9_0()

#### Methods
- internal void <OnAllPurchasesRetrieved>b__0()

### private struct UnityEngine.Purchasing.GooglePlayStoreService.<FetchPurchases>d__33
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public UnityEngine.Purchasing.GooglePlayStoreService <>4__this
- public System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1
- public System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct UnityEngine.Purchasing.GoogleFinishTransactionService.<FindPurchase>d__4
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public UnityEngine.Purchasing.GoogleFinishTransactionService <>4__this
- private UnityEngine.Purchasing.GoogleFinishTransactionService.<>c__DisplayClass4_0 <>8__1
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<UnityEngine.Purchasing.Interfaces.IGooglePurchase> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>u__1
- public string purchaseToken

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct UnityEngine.Purchasing.GoogleFinishTransactionService.<FinishTransaction>d__3
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public UnityEngine.Purchasing.GoogleFinishTransactionService <>4__this
- public System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Purchasing.Interfaces.IGooglePurchase> <>u__1
- public System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished
- public UnityEngine.Purchasing.ProductDefinition product
- public string purchaseToken

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct UnityEngine.Purchasing.GooglePurchaseUpdatedListener.<HandleUserCancelledPurchaseFailure>d__14
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public UnityEngine.Purchasing.GooglePurchaseUpdatedListener <>4__this
- public System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>u__1
- public UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class UnityEngine.Purchasing.EnumerableExtensions.<IgnoreExceptions>d__1<T, TException>
- Interfaces: System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private T <>2__current
- public System.Collections.Generic.IEnumerable<T> <>3__enumerable
- public System.Action<TException> <>3__onException
- private int <>l__initialThreadId
- private System.Collections.Generic.IEnumerator<T> <enumerator>5__2
- private bool <hasNext>5__3
- private System.Collections.Generic.IEnumerable<T> enumerable
- private System.Action<TException> onException

#### Properties
- private T System.Collections.Generic.IEnumerator<T>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public EnumerableExtensions.<IgnoreExceptions>d__1<T, TException>(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private struct UnityEngine.Purchasing.GoogleQueryPurchasesService.<QueryPurchases>d__3
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public UnityEngine.Purchasing.GoogleQueryPurchasesService <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>[]> <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct UnityEngine.Purchasing.GooglePlayStoreService.<TryFetchPurchases>d__34
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public UnityEngine.Purchasing.GooglePlayStoreService <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>u__1
- public System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### public class UnityEngine.Purchasing.AmazonApps

#### Fields
- public static const string Name

#### Constructors
- public AmazonApps()

### public class UnityEngine.Purchasing.AmazonAppStoreStoreExtensions
- Interfaces: UnityEngine.Purchasing.IAmazonExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.IAmazonConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration

#### Fields
- private readonly UnityEngine.AndroidJavaObject android

#### Properties
- public string amazonUserId { get; }

#### Constructors
- public AmazonAppStoreStoreExtensions(UnityEngine.AndroidJavaObject a)

#### Methods
- public void NotifyUnableToFulfillUnavailableProduct(string transactionID)
- public void WriteSandboxJSON(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> products)

### internal class UnityEngine.Purchasing.AndroidJavaStore
- Interfaces: UnityEngine.Purchasing.INativeStore

#### Fields
- private readonly UnityEngine.AndroidJavaObject m_Store

#### Constructors
- public AndroidJavaStore(UnityEngine.AndroidJavaObject store)

#### Methods
- public virtual void FinishTransaction(string productJSON, string transactionID)
- protected UnityEngine.AndroidJavaObject GetStore()
- public virtual void Purchase(string productJSON, string developerPayload)
- public void RetrieveProducts(string json)

### public enum UnityEngine.Purchasing.AndroidStore
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AmazonAppStore = 1
- GooglePlay = 0
- NotSpecified = 3
- UDP = 2

### public enum UnityEngine.Purchasing.AndroidStoreMeta
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AndroidStoreEnd = 2
- AndroidStoreStart = 0

### public class UnityEngine.Purchasing.AppleAppStore

#### Fields
- public static const string Name

#### Constructors
- public AppleAppStore()

### internal class UnityEngine.Purchasing.AppleJsonProductDescriptionsDeserializer
- Base: Stores.Util.JsonProductDescriptionsDeserializer

#### Constructors
- public AppleJsonProductDescriptionsDeserializer()

#### Methods
- internal override UnityEngine.Purchasing.ProductMetadata DeserializeMetadata(System.Collections.Generic.Dictionary<string, object> data)

### public class UnityEngine.Purchasing.AppleProductMetadata
- Base: UnityEngine.Purchasing.ProductMetadata

#### Fields
- private readonly bool <isFamilyShareable>k__BackingField

#### Properties
- public bool isFamilyShareable { get; }

#### Constructors
- internal AppleProductMetadata(UnityEngine.Purchasing.ProductMetadata baseProductMetadata, string isFamilyShareable)
- internal AppleProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice, string isFamilyShareable)

### internal class UnityEngine.Purchasing.AppleStoreImpl
- Base: UnityEngine.Purchasing.JSONStore
- Interfaces: UnityEngine.Purchasing.Extension.IStore, UnityEngine.Purchasing.IUnityCallback, UnityEngine.Purchasing.IStoreInternal, UnityEngine.Purchasing.ITransactionHistoryExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.IAppleExtensions, UnityEngine.Purchasing.IAppleConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration

#### Fields
- private string m_CachedAppReceipt
- private System.Nullable<double> m_CachedAppReceiptModificationDate
- private System.Action<UnityEngine.Purchasing.Product> m_DeferredCallback
- private System.Action m_FetchStorePromotionOrderError
- private System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> m_FetchStorePromotionOrderSuccess
- private System.Action m_FetchStorePromotionVisibilityError
- private System.Action<string, UnityEngine.Purchasing.AppleStorePromotionVisibility> m_FetchStorePromotionVisibilitySuccess
- private UnityEngine.Purchasing.INativeAppleStore m_Native
- private System.Action<bool> m_ObsoleteRestoreCallback
- private string m_ProductsJson
- private System.Action<UnityEngine.Purchasing.Product> m_PromotionalPurchaseCallback
- private System.Action<string> m_RefreshReceiptError
- private System.Action<string> m_RefreshReceiptSuccess
- private System.Action<bool, string> m_RestoreCallback
- private System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> m_RevokedCallback
- private readonly UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics
- private static UnityEngine.Purchasing.AppleStoreImpl s_Instance
- private static Uniject.IUtil s_Util

#### Properties
- public string appReceipt { get; }
- private System.Nullable<double> appReceiptModificationDate { get; }
- public bool canMakePayments { get; }
- public bool simulateAskToBuy { get; set; }

#### Constructors
- protected AppleStoreImpl(Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics)

#### Methods
- public virtual void ContinuePromotionalPurchases()
- private System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> EnrichProductDescriptions(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> productDescriptions, UnityEngine.Purchasing.Security.AppleReceipt appleReceipt)
- public virtual void FetchStorePromotionOrder(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> successCallback, System.Action errorCallback)
- public virtual void FetchStorePromotionVisibility(UnityEngine.Purchasing.Product product, System.Action<string, UnityEngine.Purchasing.AppleStorePromotionVisibility> successCallback, System.Action errorCallback)
- private static UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt FindMostRecentReceipt(UnityEngine.Purchasing.Security.AppleReceipt appleReceipt, string productId)
- private static UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt FirstNonCancelledReceipt(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt[] foundReceipts)
- private UnityEngine.Purchasing.Security.AppleReceipt GetAppleReceiptFromBase64String(string receipt)
- public System.Collections.Generic.Dictionary<string, string> GetIntroductoryPriceDictionary()
- public System.Collections.Generic.Dictionary<string, string> GetProductDetails()
- public string GetTransactionReceiptForProduct(UnityEngine.Purchasing.Product product)
- private bool HasInAppPurchaseReceipts(UnityEngine.Purchasing.Security.AppleReceipt appleReceipt)
- private static bool IsNonSubscriptionRestored(string transactionId, string originalTransactionId)
- private bool IsRestored(string productId, UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt productReceipt, string transactionId, string originalTransactionId)
- private static bool IsSubscriptionRestored(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt productReceipt, UnityEngine.Purchasing.Product previousProduct)
- private static bool IsValidPurchaseState(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt mostRecentReceipt, string productId)
- private static void MessageCallback(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored)
- public void OnAppReceiptRefreshedFailed(string error)
- public void OnAppReceiptRetrieved(string receipt)
- private void OnEntitlementsRevoked(string productIds)
- public void OnFetchStorePromotionOrderFailed()
- public void OnFetchStorePromotionOrderSucceeded(string productIds)
- public void OnFetchStorePromotionVisibilityFailed()
- public void OnFetchStorePromotionVisibilitySucceeded(string result)
- public override void OnProductsRetrieved(string json)
- public void OnPromotionalPurchaseAttempted(string productId)
- public void OnPurchaseDeferred(string productId)
- public void OnPurchaseSucceeded(string id, string receipt, string transactionId, string originalTransactionId, bool isRestored)
- public void OnTransactionsRestoredFail(string error)
- public void OnTransactionsRestoredSuccess()
- public virtual void PresentCodeRedemptionSheet()
- private void ProcessMessage(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored)
- public virtual void RefreshAppReceipt(System.Action<string> successCallback, System.Action<string> errorCallback)
- public virtual void RefreshAppReceipt(System.Action<string> successCallback, System.Action errorCallback)
- public void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> callback)
- private bool RestoreActiveEntitlement(UnityEngine.Purchasing.Security.AppleReceipt appleReceipt, string productId)
- public virtual void RestoreTransactions(System.Action<bool> callback)
- public virtual void RestoreTransactions(System.Action<bool, string> callback)
- private void RevokeEntitlement(UnityEngine.Purchasing.Security.AppleReceipt appleReceipt, string productId, System.Collections.Generic.List<UnityEngine.Purchasing.Product> revokedProducts, UnityEngine.Purchasing.Product product)
- public void SetApplePromotionalPurchaseInterceptorCallback(System.Action<UnityEngine.Purchasing.Product> callback)
- public void SetApplicationUsername(string applicationUsername)
- public void SetEntitlementsRevokedListener(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> callback)
- public void SetNativeStore(UnityEngine.Purchasing.INativeAppleStore apple)
- public virtual void SetStorePromotionOrder(System.Collections.Generic.List<UnityEngine.Purchasing.Product> products)
- public void SetStorePromotionVisibility(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.AppleStorePromotionVisibility visibility)
- private void UpdateAppleProductFields(string id, string originalTransactionId, bool isRestored)

### internal enum UnityEngine.Purchasing.AppleStoreProductType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AutoRenewingSubscription = 3
- Consumable = 1
- NonConsumable = 0
- NonRenewingSubscription = 2

### public enum UnityEngine.Purchasing.AppleStorePromotionVisibility
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Default = 0
- Hide = 1
- Show = 2

### public enum UnityEngine.Purchasing.AppStore
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AmazonAppStore = 2
- AppleAppStore = 5
- fake = 7
- GooglePlay = 1
- MacAppStore = 4
- NotSpecified = 0
- UDP = 3
- WinRT = 6

### public enum UnityEngine.Purchasing.AppStoreMeta
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AndroidStoreEnd = 3
- AndroidStoreStart = 1

### internal class UnityEngine.Purchasing.AppStoreSettingsInterface

#### Fields
- private static System.Type s_typeCache

#### Constructors
- public AppStoreSettingsInterface()

#### Methods
- internal static System.Reflection.FieldInfo GetAppSlugField()
- internal static System.Reflection.FieldInfo GetAssetPathField()
- internal static System.Type GetClassType()
- internal static System.Reflection.FieldInfo GetClientIDField()

### internal class UnityEngine.Purchasing.BillingClientStateListener
- Base: UnityEngine.AndroidJavaProxy
- Interfaces: UnityEngine.Purchasing.Interfaces.IBillingClientStateListener

#### Fields
- private static const string k_AndroidBillingClientStateListenerClassName
- private System.Action<UnityEngine.Purchasing.Models.GoogleBillingResponseCode> m_Disconnect
- private System.Action m_OnConnected

#### Constructors
- internal BillingClientStateListener()

#### Methods
- public void onBillingServiceDisconnected()
- public void onBillingSetupFinished(UnityEngine.AndroidJavaObject billingResult)
- public void RegisterOnConnected(System.Action onConnected)
- public void RegisterOnDisconnected(System.Action<UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onDisconnected)

### internal class UnityEngine.Purchasing.BuildConfigInterface

#### Fields
- private static System.Type s_typeCache

#### Constructors
- public BuildConfigInterface()

#### Methods
- internal static string GetApiEndpoint()
- private static System.Reflection.FieldInfo GetApiEndpointField()
- internal static System.Type GetClassType()
- internal static string GetIdEndpoint()
- private static System.Reflection.FieldInfo GetIdEndpointField()
- internal static string GetUdpEndpoint()
- private static System.Reflection.FieldInfo GetUdpEndpointField()
- internal static string GetVersion()
- private static System.Reflection.FieldInfo GetVersionField()

### internal class UnityEngine.Purchasing.DialogRequest

#### Fields
- public System.Action<bool, int> Callback
- public string CancelButtonText
- public string OkayButtonText
- public System.Collections.Generic.List<string> Options
- public string QueryText

#### Constructors
- public DialogRequest()

### protected enum UnityEngine.Purchasing.FakeStore.DialogType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Purchase = 0
- RetrieveProducts = 1

### internal static class UnityEngine.Purchasing.EnumerableExtensions

#### Methods
- public static System.Collections.Generic.IEnumerable<T> IgnoreExceptions<T, TException>(System.Collections.Generic.IEnumerable<T> enumerable, System.Action<TException> onException = null)
- public static System.Collections.Generic.IEnumerable<T> NonNull<T>(System.Collections.Generic.IEnumerable<T> enumerable)

### internal class UnityEngine.Purchasing.ExponentialRetryPolicy
- Interfaces: UnityEngine.Purchasing.Stores.Util.IRetryPolicy

#### Fields
- private readonly int m_BaseRetryDelay
- private readonly int m_ExponentialFactor
- private readonly int m_MaxRetryDelay

#### Constructors
- public ExponentialRetryPolicy(int baseRetryDelay = 1000, int maxRetryDelay = 30000, int exponentialFactor = 2)

#### Methods
- private int AdjustDelay(int delay)
- public void Invoke(System.Action<System.Action> actionToTry, System.Action onRetryAction)

### public class UnityEngine.Purchasing.FakeAmazonExtensions
- Interfaces: UnityEngine.Purchasing.IAmazonExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.IAmazonConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration

#### Properties
- public string amazonUserId { get; }

#### Constructors
- public FakeAmazonExtensions()

#### Methods
- public void NotifyUnableToFulfillUnavailableProduct(string transactionID)
- public void WriteSandboxJSON(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> products)

### internal class UnityEngine.Purchasing.FakeAppleConfiguration
- Interfaces: UnityEngine.Purchasing.IAppleConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration

#### Properties
- public string appReceipt { get; }
- public bool canMakePayments { get; }

#### Constructors
- public FakeAppleConfiguration()

#### Methods
- public void SetApplePromotionalPurchaseInterceptorCallback(System.Action<UnityEngine.Purchasing.Product> callback)
- public void SetEntitlementsRevokedListener(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> callback)

### internal class UnityEngine.Purchasing.FakeAppleExtensions
- Interfaces: UnityEngine.Purchasing.IAppleExtensions, UnityEngine.Purchasing.IStoreExtension

#### Fields
- private bool <simulateAskToBuy>k__BackingField
- private bool m_FailRefresh

#### Properties
- public bool simulateAskToBuy { get; set; }

#### Constructors
- public FakeAppleExtensions()

#### Methods
- public void ContinuePromotionalPurchases()
- public void FetchStorePromotionOrder(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> successCallback, System.Action errorCallback)
- public void FetchStorePromotionVisibility(UnityEngine.Purchasing.Product product, System.Action<string, UnityEngine.Purchasing.AppleStorePromotionVisibility> successCallback, System.Action errorCallback)
- public System.Collections.Generic.Dictionary<string, string> GetIntroductoryPriceDictionary()
- public System.Collections.Generic.Dictionary<string, string> GetProductDetails()
- public string GetTransactionReceiptForProduct(UnityEngine.Purchasing.Product product)
- public void PresentCodeRedemptionSheet()
- public void RefreshAppReceipt(System.Action<string> successCallback, System.Action<string> errorCallback)
- public void RefreshAppReceipt(System.Action<string> successCallback, System.Action errorCallback)
- public void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> callback)
- public void RestoreTransactions(System.Action<bool> callback)
- public void RestoreTransactions(System.Action<bool, string> callback)
- public void SetApplicationUsername(string applicationUsername)
- public void SetStorePromotionOrder(System.Collections.Generic.List<UnityEngine.Purchasing.Product> products)
- public void SetStorePromotionVisibility(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.AppleStorePromotionVisibility visible)

### public class UnityEngine.Purchasing.FakeGooglePlayStoreConfiguration
- Interfaces: UnityEngine.Purchasing.IGooglePlayConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration

#### Constructors
- public FakeGooglePlayStoreConfiguration()

#### Methods
- public void SetDeferredProrationUpgradeDowngradeSubscriptionListener(System.Action<UnityEngine.Purchasing.Product> action)
- public void SetDeferredPurchaseListener(System.Action<UnityEngine.Purchasing.Product> action)
- public void SetFetchPurchasesAtInitialize(bool enable)
- public void SetFetchPurchasesExcludeDeferred(bool exclude)
- public void SetMaxConnectionAttempts(int maxConnectionAttempts)
- public void SetObfuscatedAccountId(string accountId)
- public void SetObfuscatedProfileId(string profileId)
- public void SetQueryProductDetailsFailedListener(System.Action<int> action)
- public void SetServiceDisconnectAtInitializeListener(System.Action action)

### public class UnityEngine.Purchasing.FakeGooglePlayStoreExtensions
- Interfaces: UnityEngine.Purchasing.IGooglePlayStoreExtensions, UnityEngine.Purchasing.IStoreExtension

#### Constructors
- public FakeGooglePlayStoreExtensions()

#### Methods
- public void ConfirmSubscriptionPriceChange(string productId, System.Action<bool> callback)
- public string GetObfuscatedAccountId(UnityEngine.Purchasing.Product product)
- public string GetObfuscatedProfileId(UnityEngine.Purchasing.Product product)
- public UnityEngine.Purchasing.Security.GooglePurchaseState GetPurchaseState(UnityEngine.Purchasing.Product product)
- public bool IsPurchasedProductDeferred(UnityEngine.Purchasing.Product product)
- public void RestoreTransactions(System.Action<bool> callback)
- public void RestoreTransactions(System.Action<bool, string> callback)
- public void UpgradeDowngradeSubscription(string oldSku, string newSku)
- public void UpgradeDowngradeSubscription(string oldSku, string newSku, int desiredProrationMode)
- public void UpgradeDowngradeSubscription(string oldSku, string newSku, UnityEngine.Purchasing.GooglePlayProrationMode desiredProrationMode)
- public void UpgradeDowngradeSubscription(string oldSku, string newSku, UnityEngine.Purchasing.GooglePlayReplacementMode desiredReplacementMode)

### internal class UnityEngine.Purchasing.FakeMicrosoftExtensions
- Interfaces: UnityEngine.Purchasing.IMicrosoftExtensions, UnityEngine.Purchasing.IStoreExtension

#### Constructors
- public FakeMicrosoftExtensions()

#### Methods
- public void RestoreTransactions()

### internal class UnityEngine.Purchasing.FakeStore
- Base: UnityEngine.Purchasing.JSONStore
- Interfaces: UnityEngine.Purchasing.Extension.IStore, UnityEngine.Purchasing.IUnityCallback, UnityEngine.Purchasing.IStoreInternal, UnityEngine.Purchasing.ITransactionHistoryExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.IFakeExtensions, UnityEngine.Purchasing.INativeStore

#### Fields
- private string <unavailableProductId>k__BackingField
- private UnityEngine.Purchasing.Extension.IStoreCallback m_Biller
- private readonly System.Collections.Generic.List<string> m_PurchasedProducts
- public static const string Name
- public bool purchaseCalled
- public bool restoreCalled
- public UnityEngine.Purchasing.FakeStoreUIMode UIMode

#### Properties
- public string unavailableProductId { get; set; }

#### Constructors
- public FakeStore()

#### Methods
- private void <>n__0(string id, string receipt, string transactionID)
- private void FakePurchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload)
- public void FinishTransaction(string productJSON, string transactionID)
- public override void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId)
- public override void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback biller)
- public void Purchase(string productJSON, string developerPayload)
- public void RegisterPurchaseForRestore(string productId)
- public void RestoreTransactions(System.Action<bool, string> callback)
- public void RetrieveProducts(string json)
- protected virtual bool StartUI<T>(object model, UnityEngine.Purchasing.FakeStore.DialogType dialogType, System.Action<bool, T> callback)
- public void StoreRetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> productDefinitions)

### public enum UnityEngine.Purchasing.FakeStoreUIMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Default = 0
- DeveloperUser = 2
- StandardUser = 1

### internal class UnityEngine.Purchasing.FakeTransactionHistoryExtensions
- Interfaces: UnityEngine.Purchasing.ITransactionHistoryExtensions, UnityEngine.Purchasing.IStoreExtension

#### Constructors
- public FakeTransactionHistoryExtensions()

#### Methods
- public UnityEngine.Purchasing.Extension.PurchaseFailureDescription GetLastPurchaseFailureDescription()
- public UnityEngine.Purchasing.StoreSpecificPurchaseErrorCode GetLastStoreSpecificPurchaseErrorCode()

### public class UnityEngine.Purchasing.FakeUDPExtension
- Interfaces: UnityEngine.Purchasing.IUDPExtensions, UnityEngine.Purchasing.IStoreExtension

#### Constructors
- public FakeUDPExtension()

#### Methods
- public void EnableDebugLog(bool enable)
- public string GetLastInitializationError()
- public string GetLastPurchaseError()
- public object GetUserInfo()
- public void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> action)

### internal class UnityEngine.Purchasing.FileReference

#### Fields
- private readonly string m_FilePath
- private readonly UnityEngine.ILogger m_Logger

#### Constructors
- internal FileReference(string filePath, UnityEngine.ILogger logger)

#### Methods
- internal static UnityEngine.Purchasing.FileReference CreateInstance(string filename, UnityEngine.ILogger logger, Uniject.IUtil util)
- internal void Delete()
- internal string Load()
- internal void Save(string payload)

### public static class UnityEngine.Purchasing.GetAppleProductMetadataExtension

#### Methods
- public static UnityEngine.Purchasing.AppleProductMetadata GetAppleProductMetadata(UnityEngine.Purchasing.ProductMetadata productMetadata)

### public static class UnityEngine.Purchasing.GetGoogleProductMetadataExtension

#### Methods
- public static UnityEngine.Purchasing.GoogleProductMetadata GetGoogleProductMetadata(UnityEngine.Purchasing.ProductMetadata productMetadata)

### internal class UnityEngine.Purchasing.GoogleAcknowledgePurchaseListener
- Base: UnityEngine.AndroidJavaProxy

#### Fields
- private static const string k_AndroidAcknowledgePurchaseResponseListenerClassName
- private readonly System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> m_OnAcknowledgePurchaseResponse

#### Constructors
- internal GoogleAcknowledgePurchaseListener(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledgePurchaseResponseAction)

#### Methods
- private void onAcknowledgePurchaseResponse(UnityEngine.AndroidJavaObject billingResult)

### internal enum UnityEngine.Purchasing.GoogleBillingConnectionState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Closed = 3
- Connected = 2
- Connecting = 1
- Disconnected = 0

### internal class UnityEngine.Purchasing.GoogleCachedQueryProductDetailsService
- Interfaces: UnityEngine.Purchasing.IGoogleCachedQueryProductDetailsService

#### Fields
- private readonly System.Collections.Generic.Dictionary<string, UnityEngine.AndroidJavaObject> m_CachedQueriedProductDetails

#### Constructors
- public GoogleCachedQueryProductDetailsService()

#### Methods
- public void AddCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> queriedProducts)
- private bool Contains(string productId)
- public bool Contains(UnityEngine.Purchasing.ProductDefinition products)
- protected override void Finalize()
- private UnityEngine.AndroidJavaObject GetCachedQueriedProductDetails(string productId)
- private System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<string> productIds)
- public System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products)
- public System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProducts()

### internal class UnityEngine.Purchasing.GoogleConnectionRetryPolicy
- Interfaces: UnityEngine.Purchasing.Stores.Util.IRetryPolicy

#### Fields
- private readonly int m_BaseRetryDelay
- private readonly int m_ExponentialFactor
- private readonly int m_MaxRetryDelay

#### Constructors
- public GoogleConnectionRetryPolicy(int baseRetryDelay = 2000, int maxRetryDelay = 30000, int exponentialFactor = 2)

#### Methods
- private int AdjustDelay(int delay)
- public void Invoke(System.Action<System.Action> actionToTry, System.Action onRetryAction)

### internal class UnityEngine.Purchasing.GoogleConsumeResponseListener
- Base: UnityEngine.AndroidJavaProxy

#### Fields
- private static const string k_AndroidConsumeResponseListenerClassName
- private readonly System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> m_OnConsumeResponse

#### Constructors
- internal GoogleConsumeResponseListener(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsumeResponseAction)

#### Methods
- private void onConsumeResponse(UnityEngine.AndroidJavaObject billingResult, string purchaseToken)

### internal class UnityEngine.Purchasing.GoogleFetchPurchases
- Interfaces: UnityEngine.Purchasing.IGoogleFetchPurchases

#### Fields
- private readonly UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService
- private UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback
- private Uniject.IUtil m_Util

#### Constructors
- internal GoogleFetchPurchases(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, Uniject.IUtil util)

#### Methods
- private System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> BuildProductsFromPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase)
- private static UnityEngine.Purchasing.Product CompleteProductInfoWithPurchase(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase)
- public void FetchPurchases()
- public void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> onQueryPurchaseSucceed)
- private System.Collections.Generic.List<UnityEngine.Purchasing.Product> FillProductsWithPurchases(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases)
- private void OnFetchedPurchase(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases)
- private static System.Func<UnityEngine.Purchasing.Interfaces.IGooglePurchase, bool> PurchaseIsPending()
- private static System.Func<UnityEngine.Purchasing.Interfaces.IGooglePurchase, bool> PurchaseIsPurchased()
- public void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback)
- private void UpdateDeferredProduct(UnityEngine.Purchasing.Interfaces.IGooglePurchase deferredPurchase, string sku)
- private void UpdateDeferredProductsByPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase deferredPurchase)
- private void UpdateDeferredProductsByPurchases(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> deferredPurchases)

### internal class UnityEngine.Purchasing.GoogleFinishTransactionService
- Interfaces: UnityEngine.Purchasing.Interfaces.IGoogleFinishTransactionService

#### Fields
- private readonly UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient
- private readonly UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService m_GoogleQueryPurchasesService

#### Constructors
- internal GoogleFinishTransactionService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService googleQueryPurchasesService)

#### Methods
- private System.Threading.Tasks.Task<UnityEngine.Purchasing.Interfaces.IGooglePurchase> FindPurchase(string purchaseToken)
- public void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished)
- private void FinishTransactionForPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished)

### internal class UnityEngine.Purchasing.GoogleLastKnownProductService
- Interfaces: UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService

#### Fields
- private string <LastKnownOldProductId>k__BackingField
- private string <LastKnownProductId>k__BackingField
- private System.Nullable<UnityEngine.Purchasing.GooglePlayReplacementMode> <LastKnownReplacementMode>k__BackingField

#### Properties
- public string LastKnownOldProductId { get; set; }
- public string LastKnownProductId { get; set; }
- public System.Nullable<UnityEngine.Purchasing.GooglePlayReplacementMode> LastKnownReplacementMode { get; set; }

#### Constructors
- public GoogleLastKnownProductService()

### public class UnityEngine.Purchasing.GooglePlay

#### Fields
- public static const string Name

#### Constructors
- public GooglePlay()

### internal class UnityEngine.Purchasing.GooglePlayConfiguration
- Interfaces: UnityEngine.Purchasing.IGooglePlayConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration, UnityEngine.Purchasing.IGooglePlayConfigurationInternal

#### Fields
- private System.Action<UnityEngine.Purchasing.Product> m_DeferredProrationUpgradeDowngradeSubscriptionAction
- private System.Action<UnityEngine.Purchasing.Product> m_DeferredPurchaseAction
- private bool m_FetchPurchasesAtInitialize
- private bool m_FetchPurchasesExcludeDeferred
- private readonly UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService
- private System.Action m_InitializationConnectionLister
- private System.Action<int> m_QueryProductDetailsFailedListener

#### Constructors
- public GooglePlayConfiguration(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService)

#### Methods
- public bool DoesRetrievePurchasesExcludeDeferred()
- public bool IsFetchPurchasesAtInitializeSkipped()
- public void NotifyDeferredProrationUpgradeDowngradeSubscription(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback, string productId)
- public void NotifyDeferredPurchase(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback, UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string transactionId)
- public void NotifyInitializationConnectionFailed()
- public void NotifyQueryProductDetailsFailed(int retryCount)
- public void SetDeferredProrationUpgradeDowngradeSubscriptionListener(System.Action<UnityEngine.Purchasing.Product> action)
- public void SetDeferredPurchaseListener(System.Action<UnityEngine.Purchasing.Product> action)
- public void SetFetchPurchasesAtInitialize(bool enable)
- public void SetFetchPurchasesExcludeDeferred(bool exclude)
- public void SetMaxConnectionAttempts(int maxConnectionAttempts)
- public void SetObfuscatedAccountId(string accountId)
- public void SetObfuscatedProfileId(string profileId)
- public void SetQueryProductDetailsFailedListener(System.Action<int> action)
- public void SetServiceDisconnectAtInitializeListener(System.Action action)

### internal class UnityEngine.Purchasing.GooglePlayProductCallback
- Interfaces: UnityEngine.Purchasing.Interfaces.IGoogleProductCallback

#### Fields
- private UnityEngine.Purchasing.IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal

#### Constructors
- public GooglePlayProductCallback()

#### Methods
- public void NotifyQueryProductDetailsFailed(int retryCount)
- public void SetStoreConfiguration(UnityEngine.Purchasing.IGooglePlayConfigurationInternal configuration)

### public enum UnityEngine.Purchasing.GooglePlayProrationMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Deferred = 4
- ImmediateAndChargeFullPrice = 5
- ImmediateAndChargeProratedPrice = 2
- ImmediateWithoutProration = 3
- ImmediateWithTimeProration = 1
- UnknownSubscriptionUpgradeDowngradePolicy = 0

### internal class UnityEngine.Purchasing.GooglePlayPurchaseCallback
- Interfaces: UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback

#### Fields
- private UnityEngine.Purchasing.IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal
- private UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback
- private readonly Uniject.IUtil m_Util

#### Constructors
- public GooglePlayPurchaseCallback(Uniject.IUtil util)

#### Methods
- public void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku)
- public void NotifyDeferredPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string purchaseToken)
- public void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription purchaseFailureDescription)
- public void OnPurchaseSuccessful(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string purchaseToken)
- public void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback)
- public void SetStoreConfiguration(UnityEngine.Purchasing.IGooglePlayConfigurationInternal configuration)

### public enum UnityEngine.Purchasing.GooglePlayReplacementMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ChargeFullPrice = 5
- ChargeProratedPrice = 2
- Deferred = 4
- UnknownReplacementMode = 0
- WithoutProration = 3
- WithTimeProration = 1

### internal class UnityEngine.Purchasing.GooglePlayStore
- Base: UnityEngine.Purchasing.Extension.AbstractStore
- Interfaces: UnityEngine.Purchasing.Extension.IStore

#### Fields
- private readonly UnityEngine.Purchasing.IGoogleFetchPurchases m_FetchPurchases
- private readonly UnityEngine.Purchasing.IGooglePlayStoreFinishTransactionService m_FinishTransactionService
- private readonly UnityEngine.Purchasing.IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal
- private readonly UnityEngine.Purchasing.IGooglePlayStoreExtensionsInternal m_GooglePlayStoreExtensions
- private readonly UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback m_GooglePurchaseCallback
- private readonly UnityEngine.Purchasing.IGooglePlayStoreRetrieveProductsService m_RetrieveProductsService
- private readonly UnityEngine.Purchasing.IGooglePlayStorePurchaseService m_StorePurchaseService
- private readonly Uniject.IUtil m_Util

#### Constructors
- public GooglePlayStore(UnityEngine.Purchasing.IGooglePlayStoreRetrieveProductsService retrieveProductsService, UnityEngine.Purchasing.IGooglePlayStorePurchaseService storePurchaseService, UnityEngine.Purchasing.IGoogleFetchPurchases fetchPurchases, UnityEngine.Purchasing.IGooglePlayStoreFinishTransactionService transactionService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.IGooglePlayConfigurationInternal googlePlayConfigurationInternal, UnityEngine.Purchasing.IGooglePlayStoreExtensionsInternal googlePlayStoreExtensions, Uniject.IUtil util)

#### Methods
- public override void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId)
- private bool HasInitiallyRetrievedProducts()
- public override void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback)
- public void OnPause(bool isPaused)
- public override void Purchase(UnityEngine.Purchasing.ProductDefinition product, string dummy)
- public override void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products)
- private bool ShouldFetchPurchasesNext()

### internal class UnityEngine.Purchasing.GooglePlayStoreExtensions
- Interfaces: UnityEngine.Purchasing.IGooglePlayStoreExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.IGooglePlayStoreExtensionsInternal

#### Fields
- private readonly System.Action<UnityEngine.Purchasing.Product> m_DeferredProrationUpgradeDowngradeSubscriptionAction
- private readonly System.Action<UnityEngine.Purchasing.Product> m_DeferredPurchaseAction
- private readonly UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService
- private readonly UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider m_GooglePurchaseStateEnumProvider
- private readonly UnityEngine.ILogger m_Logger
- private UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback
- private readonly UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics

#### Constructors
- internal GooglePlayStoreExtensions(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, UnityEngine.ILogger logger, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics)

#### Methods
- public void ConfirmSubscriptionPriceChange(string productId, System.Action<bool> callback)
- public string GetObfuscatedAccountId(UnityEngine.Purchasing.Product product)
- public string GetObfuscatedProfileId(UnityEngine.Purchasing.Product product)
- public UnityEngine.Purchasing.Security.GooglePurchaseState GetPurchaseState(UnityEngine.Purchasing.Product product)
- private UnityEngine.Purchasing.Interfaces.IGooglePurchase GooglePurchaseFromProduct(UnityEngine.Purchasing.Product product)
- public bool IsPurchasedProductDeferred(UnityEngine.Purchasing.Product product)
- public virtual void RestoreTransactions(System.Action<bool> callback)
- public virtual void RestoreTransactions(System.Action<bool, string> callback)
- public void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback)
- private bool TryIsPurchasedProductDeferred(UnityEngine.Purchasing.Product product)
- public void UpgradeDowngradeSubscription(string oldSku, string newSku)
- public void UpgradeDowngradeSubscription(string oldSku, string newSku, int desiredProrationMode)
- public void UpgradeDowngradeSubscription(string oldSku, string newSku, UnityEngine.Purchasing.GooglePlayProrationMode desiredProrationMode)
- public virtual void UpgradeDowngradeSubscription(string oldSku, string newSku, UnityEngine.Purchasing.GooglePlayReplacementMode desiredReplacementMode)

### internal class UnityEngine.Purchasing.GooglePlayStoreFinishTransactionService
- Interfaces: UnityEngine.Purchasing.IGooglePlayStoreFinishTransactionService

#### Fields
- private static const int k_MaxRetryAttempts
- private readonly UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService
- private readonly System.Collections.Generic.HashSet<string> m_ProcessedPurchaseToken
- private int m_RetryCount
- private UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback

#### Constructors
- internal GooglePlayStoreFinishTransactionService(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService)

#### Methods
- private void CallPurchaseSucceededUpdateReceipt(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase)
- public void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken)
- private void HandleFinishTransaction(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase)
- private static bool IsResponseCodeInRecoverableState(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult)
- public void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback)

### internal class UnityEngine.Purchasing.GooglePlayStorePurchaseService
- Interfaces: UnityEngine.Purchasing.IGooglePlayStorePurchaseService

#### Fields
- private readonly UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService

#### Constructors
- internal GooglePlayStorePurchaseService(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService)

#### Methods
- public void Purchase(UnityEngine.Purchasing.ProductDefinition product)

### internal class UnityEngine.Purchasing.GooglePlayStoreRetrieveProductsService
- Interfaces: UnityEngine.Purchasing.IGooglePlayStoreRetrieveProductsService

#### Fields
- private readonly UnityEngine.Purchasing.IGoogleFetchPurchases m_GoogleFetchPurchases
- private readonly UnityEngine.Purchasing.IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal
- private readonly UnityEngine.Purchasing.IGooglePlayStoreExtensions m_GooglePlayStoreExtensions
- private readonly UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService
- private bool m_HasInitiallyRetrievedProducts
- private bool m_RetrieveProductsFailed
- private UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback

#### Constructors
- internal GooglePlayStoreRetrieveProductsService(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, UnityEngine.Purchasing.IGoogleFetchPurchases googleFetchPurchases, UnityEngine.Purchasing.IGooglePlayConfigurationInternal googlePlayConfigurationInternal, UnityEngine.Purchasing.IGooglePlayStoreExtensions googlePlayStoreExtensions)

#### Methods
- public bool HasInitiallyRetrievedProducts()
- private bool IsPurchasedProductDeferred(UnityEngine.Purchasing.Product product)
- private System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> MakePurchasesIntoProducts(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> purchaseProducts)
- private void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts, UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult)
- private void OnProductsRetrievedWithPurchaseFetch(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts, UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult)
- private void OnRetrieveProductsFailed(UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason reason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode responseCode)
- public void ResumeConnection()
- public void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, bool wantPurchases = true)
- public void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback)

### internal class UnityEngine.Purchasing.GooglePlayStoreService
- Interfaces: UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService

#### Fields
- private readonly UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient
- private readonly UnityEngine.Purchasing.Interfaces.IBillingClientStateListener m_BillingClientStateListener
- private int m_CurrentConnectionAttempts
- private readonly UnityEngine.Purchasing.Interfaces.IGoogleFinishTransactionService m_GoogleFinishTransactionService
- private readonly UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService m_GoogleLastKnownProductService
- private readonly UnityEngine.Purchasing.Interfaces.IGooglePurchaseService m_GooglePurchaseService
- private readonly UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService m_GoogleQueryPurchasesService
- private readonly UnityEngine.ILogger m_Logger
- private int m_MaxConnectionAttempts
- private readonly System.Collections.Concurrent.ConcurrentQueue<System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>>> m_OnPurchaseSucceededQueue
- private readonly System.Collections.Concurrent.ConcurrentQueue<UnityEngine.Purchasing.Models.ProductDescriptionQuery> m_ProductsToQuery
- private readonly UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService m_QueryProductDetailsService
- private readonly UnityEngine.Purchasing.Stores.Util.IRetryPolicy m_RetryPolicy
- private readonly UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics
- private readonly Uniject.IUtil m_Util

#### Constructors
- internal GooglePlayStoreService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService queryProductDetailsService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseService purchaseService, UnityEngine.Purchasing.Interfaces.IGoogleFinishTransactionService finishTransactionService, UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService queryPurchasesService, UnityEngine.Purchasing.Interfaces.IBillingClientStateListener billingClientStateListener, UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService lastKnownProductService, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, UnityEngine.ILogger logger, UnityEngine.Purchasing.Stores.Util.IRetryPolicy retryPolicy, Uniject.IUtil util)

#### Methods
- private void <AttemptReconnection>b__19_0(System.Action retryAction)
- private bool AreConnectionAttemptsExhausted()
- private void AttemptReconnection()
- protected virtual void DequeueFetchPurchases()
- protected virtual void DequeueQueryProducts(UnityEngine.Purchasing.Models.GoogleBillingResponseCode googleBillingResponseCode)
- public void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed)
- public void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished)
- public UnityEngine.Purchasing.Interfaces.IGooglePurchase GetPurchase(string purchaseToken, string skuType)
- private void HandleRetrieveProductsNotConnected(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed)
- internal void InitConnectionWithGooglePlay()
- public bool IsConnectionReady()
- private void OnConnected()
- private void OnDisconnected(UnityEngine.Purchasing.Models.GoogleBillingResponseCode googleBillingResponseCode)
- public void Purchase(UnityEngine.Purchasing.ProductDefinition product)
- public virtual void Purchase(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayReplacementMode> desiredReplacementMode)
- public void ResumeConnection()
- public virtual void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed)
- private void RetryConnection(System.Action ActionToRetry)
- private void RetryConnectionAttempt(System.Action ActionToRetry)
- public void SetMaxConnectionAttempts(int maxConnectionAttempts)
- public void SetObfuscatedAccountId(string obfuscatedAccountId)
- public void SetObfuscatedProfileId(string obfuscatedProfileId)
- private void StartConnection()
- private System.Threading.Tasks.Task TryFetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed)

### public class UnityEngine.Purchasing.GoogleProductMetadata
- Base: UnityEngine.Purchasing.ProductMetadata

#### Fields
- private string <freeTrialPeriod>k__BackingField
- private string <introductoryPrice>k__BackingField
- private int <introductoryPriceCycles>k__BackingField
- private string <introductoryPricePeriod>k__BackingField
- private string <originalJson>k__BackingField
- private string <subscriptionPeriod>k__BackingField

#### Properties
- public string freeTrialPeriod { get; internal set; }
- public string introductoryPrice { get; internal set; }
- public int introductoryPriceCycles { get; internal set; }
- public string introductoryPricePeriod { get; internal set; }
- public string originalJson { get; internal set; }
- public string subscriptionPeriod { get; internal set; }

#### Constructors
- internal GoogleProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice)

### internal class UnityEngine.Purchasing.GooglePurchaseService
- Interfaces: UnityEngine.Purchasing.Interfaces.IGooglePurchaseService

#### Fields
- private readonly UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient
- private readonly UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback m_GooglePurchaseCallback
- private readonly UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService m_QueryProductDetailsService

#### Constructors
- internal GooglePurchaseService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService queryProductDetailsService)

#### Methods
- private void HandleBillingFlowResult(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, UnityEngine.AndroidJavaObject sku)
- private void LaunchGoogleBillingFlow(UnityEngine.AndroidJavaObject productToPurchase, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayReplacementMode> desiredProrationMode)
- private void OnQueryProductDetailsResponse(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> productDetailsList, UnityEngine.Purchasing.ProductDefinition productToBuy, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayReplacementMode> desiredProrationMode)
- public void Purchase(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayReplacementMode> desiredProrationMode)
- private void PurchaseFailedInvalidOldProduct(UnityEngine.Purchasing.ProductDefinition productToBuy, UnityEngine.Purchasing.Product oldProduct)
- private void PurchaseFailedSkuNotFound(UnityEngine.Purchasing.ProductDefinition productToBuy)
- private bool ValidateOldProduct(UnityEngine.Purchasing.Product oldProduct)
- private bool ValidateQueryProductDetailsResponseParams(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus, UnityEngine.Purchasing.ProductDefinition productToBuy, UnityEngine.Purchasing.Product oldProduct)
- private bool ValidateSkus(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus)
- private static void VerifyAndWarnIfMoreThanOneSku(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus)

### internal class UnityEngine.Purchasing.GooglePurchasesResponseListener
- Base: UnityEngine.AndroidJavaProxy

#### Fields
- private static const string k_AndroidPurchasesResponseListenerClassName
- private readonly System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> m_OnQueryPurchasesResponse

#### Constructors
- internal GooglePurchasesResponseListener(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> onQueryPurchasesResponse)

#### Methods
- public void onQueryPurchasesResponse(UnityEngine.AndroidJavaObject billingResult, UnityEngine.AndroidJavaObject purchases)

### internal class UnityEngine.Purchasing.GooglePurchaseUpdatedListener
- Base: UnityEngine.AndroidJavaProxy
- Interfaces: UnityEngine.Purchasing.Interfaces.IGooglePurchaseUpdatedListener

#### Fields
- private static const string k_AndroidPurchaseListenerClassName
- private readonly UnityEngine.Purchasing.IGoogleCachedQueryProductDetailsService m_GoogleCachedQueryProductDetailsService
- private readonly UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback m_GooglePurchaseCallback
- private readonly UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider m_GooglePurchaseStateEnumProvider
- private UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService m_GoogleQueryPurchasesService
- private readonly UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService m_LastKnownProductService
- private readonly UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder m_PurchaseBuilder

#### Constructors
- internal GooglePurchaseUpdatedListener(UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService googleLastKnownProductService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder purchaseBuilder, UnityEngine.Purchasing.IGoogleCachedQueryProductDetailsService googleCachedQueryProductDetailsService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService googleQueryPurchasesService = null)

#### Methods
- private bool <HandleUserCancelledPurchaseFailure>b__15_0(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase)
- private void ApplyOnPurchases(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases, System.Action<UnityEngine.Purchasing.Interfaces.IGooglePurchase> action)
- private void ApplyOnPurchases(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases, UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Action<UnityEngine.Purchasing.Interfaces.IGooglePurchase, string> action)
- private void HandleErrorCases(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases)
- private void HandleErrorGoogleBillingResult(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult)
- private void HandlePurchasedProduct(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase)
- private void HandleResultOkCases(UnityEngine.Purchasing.Models.IGoogleBillingResult result, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases)
- private void HandleUserCancelledPurchaseFailure(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult)
- private void HandleUserCancelledPurchaseFailure(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> googlePurchases)
- private bool IsDeferredSubscriptionChange(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase)
- private bool IsLastProrationModeDeferred()
- private void OnPurchaseAlreadyOwned(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase)
- private void OnPurchaseCancelled(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult)
- private void OnPurchaseCancelled(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase)
- private void OnPurchaseFailed(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase, string debugMessage)
- private void OnPurchaseOk(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase)
- public void onPurchasesUpdated(UnityEngine.AndroidJavaObject billingResult, UnityEngine.AndroidJavaObject javaPurchasesList)
- internal void OnPurchasesUpdated(UnityEngine.Purchasing.Models.IGoogleBillingResult result, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases)
- public void SetGoogleQueryPurchaseService(UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService googleFetchPurchases)

### internal class UnityEngine.Purchasing.GoogleQueryPurchasesService
- Interfaces: UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService

#### Fields
- private readonly UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient
- private readonly UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder m_PurchaseBuilder

#### Constructors
- internal GoogleQueryPurchasesService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder purchaseBuilder)

#### Methods
- public UnityEngine.Purchasing.Interfaces.IGooglePurchase GetPurchaseByToken(string purchaseToken, string skuType)
- private static bool IsResultOk(UnityEngine.Purchasing.Models.IGoogleBillingResult result)
- public System.Threading.Tasks.Task<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchases()
- private System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchasesWithSkuType(string skuType)

### public interface UnityEngine.Purchasing.IAmazonConfiguration
- Interfaces: UnityEngine.Purchasing.Extension.IStoreConfiguration

#### Methods
- public void WriteSandboxJSON(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> products)

### public interface UnityEngine.Purchasing.IAmazonExtensions
- Interfaces: UnityEngine.Purchasing.IStoreExtension

#### Properties
- public string amazonUserId { get; }

#### Methods
- public void NotifyUnableToFulfillUnavailableProduct(string transactionID)

### public interface UnityEngine.Purchasing.IAndroidStoreSelection
- Interfaces: UnityEngine.Purchasing.Extension.IStoreConfiguration

#### Properties
- public UnityEngine.Purchasing.AppStore appStore { get; }

### public interface UnityEngine.Purchasing.IAppleConfiguration
- Interfaces: UnityEngine.Purchasing.Extension.IStoreConfiguration

#### Properties
- public string appReceipt { get; }
- public bool canMakePayments { get; }

#### Methods
- public void SetApplePromotionalPurchaseInterceptorCallback(System.Action<UnityEngine.Purchasing.Product> callback)
- public void SetEntitlementsRevokedListener(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> callback)

### public interface UnityEngine.Purchasing.IAppleExtensions
- Interfaces: UnityEngine.Purchasing.IStoreExtension

#### Properties
- public bool simulateAskToBuy { get; set; }

#### Methods
- public void ContinuePromotionalPurchases()
- public void FetchStorePromotionOrder(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> successCallback, System.Action errorCallback)
- public void FetchStorePromotionVisibility(UnityEngine.Purchasing.Product product, System.Action<string, UnityEngine.Purchasing.AppleStorePromotionVisibility> successCallback, System.Action errorCallback)
- public System.Collections.Generic.Dictionary<string, string> GetIntroductoryPriceDictionary()
- public System.Collections.Generic.Dictionary<string, string> GetProductDetails()
- public string GetTransactionReceiptForProduct(UnityEngine.Purchasing.Product product)
- public void PresentCodeRedemptionSheet()
- public void RefreshAppReceipt(System.Action<string> successCallback, System.Action<string> errorCallback)
- public void RefreshAppReceipt(System.Action<string> successCallback, System.Action errorCallback)
- public void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> callback)
- public void RestoreTransactions(System.Action<bool> callback)
- public void RestoreTransactions(System.Action<bool, string> callback)
- public void SetApplicationUsername(string applicationUsername)
- public void SetStorePromotionOrder(System.Collections.Generic.List<UnityEngine.Purchasing.Product> products)
- public void SetStorePromotionVisibility(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.AppleStorePromotionVisibility visible)

### internal interface UnityEngine.Purchasing.IFakeExtensions
- Interfaces: UnityEngine.Purchasing.IStoreExtension

#### Properties
- public string unavailableProductId { get; set; }

### internal interface UnityEngine.Purchasing.IGoogleCachedQueryProductDetailsService

#### Methods
- public void AddCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> queriedProducts)
- public bool Contains(UnityEngine.Purchasing.ProductDefinition products)
- public System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products)
- public System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProducts()

### internal interface UnityEngine.Purchasing.IGoogleFetchPurchases

#### Methods
- public void FetchPurchases()
- public void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> onQueryPurchaseSucceed)
- public void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback)

### public interface UnityEngine.Purchasing.IGooglePlayConfiguration
- Interfaces: UnityEngine.Purchasing.Extension.IStoreConfiguration

#### Methods
- public void SetDeferredProrationUpgradeDowngradeSubscriptionListener(System.Action<UnityEngine.Purchasing.Product> action)
- public void SetDeferredPurchaseListener(System.Action<UnityEngine.Purchasing.Product> action)
- public void SetFetchPurchasesAtInitialize(bool enable)
- public void SetFetchPurchasesExcludeDeferred(bool exclude)
- public void SetMaxConnectionAttempts(int maxConnectionAttempts)
- public void SetObfuscatedAccountId(string accountId)
- public void SetObfuscatedProfileId(string profileId)
- public void SetQueryProductDetailsFailedListener(System.Action<int> action)
- public void SetServiceDisconnectAtInitializeListener(System.Action action)

### internal interface UnityEngine.Purchasing.IGooglePlayConfigurationInternal

#### Methods
- public bool DoesRetrievePurchasesExcludeDeferred()
- public bool IsFetchPurchasesAtInitializeSkipped()
- public void NotifyDeferredProrationUpgradeDowngradeSubscription(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback, string productId)
- public void NotifyDeferredPurchase(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback, UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string transactionId)
- public void NotifyInitializationConnectionFailed()
- public void NotifyQueryProductDetailsFailed(int retryCount)

### public interface UnityEngine.Purchasing.IGooglePlayStoreExtensions
- Interfaces: UnityEngine.Purchasing.IStoreExtension

#### Methods
- public void ConfirmSubscriptionPriceChange(string productId, System.Action<bool> callback)
- public string GetObfuscatedAccountId(UnityEngine.Purchasing.Product product)
- public string GetObfuscatedProfileId(UnityEngine.Purchasing.Product product)
- public UnityEngine.Purchasing.Security.GooglePurchaseState GetPurchaseState(UnityEngine.Purchasing.Product product)
- public bool IsPurchasedProductDeferred(UnityEngine.Purchasing.Product product)
- public void RestoreTransactions(System.Action<bool> callback)
- public void RestoreTransactions(System.Action<bool, string> callback)
- public void UpgradeDowngradeSubscription(string oldSku, string newSku)
- public void UpgradeDowngradeSubscription(string oldSku, string newSku, int desiredProrationMode)
- public void UpgradeDowngradeSubscription(string oldSku, string newSku, UnityEngine.Purchasing.GooglePlayProrationMode desiredProrationMode)
- public void UpgradeDowngradeSubscription(string oldSku, string newSku, UnityEngine.Purchasing.GooglePlayReplacementMode desiredReplacementMode)

### internal interface UnityEngine.Purchasing.IGooglePlayStoreExtensionsInternal

#### Methods
- public void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback)

### internal interface UnityEngine.Purchasing.IGooglePlayStoreFinishTransactionService

#### Methods
- public void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken)
- public void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback)

### internal interface UnityEngine.Purchasing.IGooglePlayStorePurchaseService

#### Methods
- public void Purchase(UnityEngine.Purchasing.ProductDefinition product)

### internal interface UnityEngine.Purchasing.IGooglePlayStoreRetrieveProductsService

#### Methods
- public bool HasInitiallyRetrievedProducts()
- public void ResumeConnection()
- public void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, bool wantPurchases)
- public void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback)

### public interface UnityEngine.Purchasing.IMicrosoftConfiguration
- Interfaces: UnityEngine.Purchasing.Extension.IStoreConfiguration

#### Properties
- public bool useMockBillingSystem { get; set; }

### public interface UnityEngine.Purchasing.IMicrosoftExtensions
- Interfaces: UnityEngine.Purchasing.IStoreExtension

#### Methods
- public void RestoreTransactions()

### internal interface UnityEngine.Purchasing.INativeStoreProvider

#### Methods
- public UnityEngine.Purchasing.INativeStore GetAndroidStore(UnityEngine.Purchasing.IUnityCallback callback, UnityEngine.Purchasing.AppStore store, UnityEngine.Purchasing.Extension.IPurchasingBinder binder, Uniject.IUtil util)
- public UnityEngine.Purchasing.INativeAppleStore GetStorekit(UnityEngine.Purchasing.IUnityCallback callback)

### internal interface UnityEngine.Purchasing.INativeUDPStore
- Interfaces: UnityEngine.Purchasing.INativeStore

#### Methods
- public void FinishTransaction(UnityEngine.Purchasing.ProductDefinition productDefinition, string transactionID)
- public void Initialize(System.Action<bool, string> callback)
- public void Purchase(string productId, System.Action<bool, string> callback, string developerPayload = null)
- public void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<bool, string> callback)

### public class UnityEngine.Purchasing.InvalidProductTypeException
- Base: UnityEngine.Purchasing.ReceiptParserException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public InvalidProductTypeException()

### internal class UnityEngine.Purchasing.InventoryInterface

#### Fields
- private static System.Type s_typeCache

#### Constructors
- public InventoryInterface()

#### Methods
- internal static System.Type GetClassType()
- internal static System.Reflection.MethodInfo GetProductListMethod()
- internal static System.Reflection.MethodInfo GetPurchaseInfoMethod()
- internal static System.Reflection.MethodInfo HasPurchaseMethod()

### public interface UnityEngine.Purchasing.IProductCatalogImpl

#### Methods
- public UnityEngine.Purchasing.ProductCatalog LoadDefaultCatalog()

### internal interface UnityEngine.Purchasing.IStoreInternal

#### Methods
- public void SetModule(UnityEngine.Purchasing.StandardPurchasingModule module)

### public interface UnityEngine.Purchasing.ITransactionHistoryExtensions
- Interfaces: UnityEngine.Purchasing.IStoreExtension

#### Methods
- public UnityEngine.Purchasing.Extension.PurchaseFailureDescription GetLastPurchaseFailureDescription()
- public UnityEngine.Purchasing.StoreSpecificPurchaseErrorCode GetLastStoreSpecificPurchaseErrorCode()

### public interface UnityEngine.Purchasing.IUDPExtensions
- Interfaces: UnityEngine.Purchasing.IStoreExtension

#### Methods
- public void EnableDebugLog(bool enable)
- public string GetLastInitializationError()
- public object GetUserInfo()
- public void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> action)

### internal interface UnityEngine.Purchasing.IUnityCallback

#### Methods
- public void OnProductsRetrieved(string json)
- public void OnPurchaseFailed(string json)
- public void OnPurchaseSucceeded(string id, string receipt, string transactionID)
- public void OnSetupFailed(string json)

### internal class UnityEngine.Purchasing.JavaBridge
- Base: UnityEngine.AndroidJavaProxy
- Interfaces: UnityEngine.Purchasing.IUnityCallback

#### Fields
- private readonly UnityEngine.Purchasing.IUnityCallback forwardTo

#### Constructors
- public JavaBridge(UnityEngine.Purchasing.IUnityCallback forwardTo)
- public JavaBridge(UnityEngine.Purchasing.IUnityCallback forwardTo, string javaInterface)

#### Methods
- public void OnProductsRetrieved(string json)
- public void OnPurchaseFailed(string json)
- public void OnPurchaseSucceeded(string id, string receipt, string transactionID)
- public void OnSetupFailed(string json)

### internal class UnityEngine.Purchasing.JSONSerializer

#### Constructors
- public JSONSerializer()

#### Methods
- private static string BuildPurchaseFailureDescriptionMessage(System.Collections.Generic.Dictionary<string, object> dic)
- public static UnityEngine.Purchasing.Extension.PurchaseFailureDescription DeserializeFailureReason(string json)
- public static System.Collections.Generic.Dictionary<string, string> DeserializeProductDetails(string json)
- public static System.Collections.Generic.Dictionary<string, string> DeserializeSubscriptionDescriptions(string json)
- private static System.Collections.Generic.Dictionary<string, object> EncodeProductDef(UnityEngine.Purchasing.ProductDefinition product)
- private static System.Collections.Generic.Dictionary<string, object> EncodeProductDesc(UnityEngine.Purchasing.Extension.ProductDescription product)
- private static System.Collections.Generic.Dictionary<string, object> EncodeProductMeta(UnityEngine.Purchasing.ProductMetadata product)
- public static string SerializeProductDef(UnityEngine.Purchasing.ProductDefinition product)
- public static string SerializeProductDefs(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products)
- public static string SerializeProductDescs(UnityEngine.Purchasing.Extension.ProductDescription product)
- public static string SerializeProductDescs(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Extension.ProductDescription> products)

### internal class UnityEngine.Purchasing.JSONStore
- Base: UnityEngine.Purchasing.Extension.AbstractStore
- Interfaces: UnityEngine.Purchasing.Extension.IStore, UnityEngine.Purchasing.IUnityCallback, UnityEngine.Purchasing.IStoreInternal, UnityEngine.Purchasing.ITransactionHistoryExtensions, UnityEngine.Purchasing.IStoreExtension

#### Fields
- private static const string k_StoreSpecificErrorCodeKey
- private bool m_IsRefreshing
- private UnityEngine.Purchasing.StoreSpecificPurchaseErrorCode m_LastPurchaseErrorCode
- protected UnityEngine.Purchasing.Extension.PurchaseFailureDescription m_LastPurchaseFailureDescription
- protected UnityEngine.ILogger m_Logger
- private UnityEngine.Purchasing.StandardPurchasingModule m_Module
- protected Stores.Util.JsonProductDescriptionsDeserializer m_ProductDescriptionsDeserializer
- private System.Action m_RefreshCallback
- private UnityEngine.Purchasing.INativeStore m_Store
- private System.Collections.Generic.List<UnityEngine.Purchasing.ProductDefinition> m_StoreCatalog
- protected UnityEngine.Purchasing.Extension.IStoreCallback unity

#### Properties
- public UnityEngine.Purchasing.Product[] storeCatalog { get; }

#### Constructors
- public JSONStore()

#### Methods
- public override void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId)
- public UnityEngine.Purchasing.Extension.PurchaseFailureDescription GetLastPurchaseFailureDescription()
- public UnityEngine.Purchasing.StoreSpecificPurchaseErrorCode GetLastStoreSpecificPurchaseErrorCode()
- public override void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback)
- public virtual void OnProductsRetrieved(string json)
- public void OnPurchaseFailed(string json)
- public void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription failure, string json = null)
- public virtual void OnPurchaseSucceeded(string id, string receipt, string transactionID)
- public void OnSetupFailed(string reason)
- private UnityEngine.Purchasing.StoreSpecificPurchaseErrorCode ParseStoreSpecificPurchaseErrorCode(string json)
- internal void ProcessManagedStoreResponse(System.Collections.Generic.List<UnityEngine.Purchasing.ProductDefinition> storeProducts)
- public override void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload)
- public override void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products)
- public void SetNativeStore(UnityEngine.Purchasing.INativeStore native)
- private void UnityEngine.Purchasing.IStoreInternal.SetModule(UnityEngine.Purchasing.StandardPurchasingModule module)

### internal class UnityEngine.Purchasing.LifecycleNotifier
- Base: UnityEngine.MonoBehaviour

#### Fields
- public System.Action OnDestroyCallback

#### Constructors
- public LifecycleNotifier()

#### Methods
- private void OnDestroy()

### internal static class UnityEngine.Purchasing.ListExtension

#### Methods
- internal static UnityEngine.AndroidJavaObject ToJava<T>(System.Collections.Generic.List<T> values)
- private static UnityEngine.AndroidJavaObject ToJavaArray<T>(System.Collections.Generic.List<T> values)

### public static class UnityEngine.Purchasing.LocaleExtensions

#### Fields
- private static readonly UnityEngine.Purchasing.TranslationLocale[] AppleLocales
- private static readonly UnityEngine.Purchasing.TranslationLocale[] GoogleLocales
- private static readonly string[] Labels
- private static string[] LabelsWithSupportedPlatforms

#### Constructors
- private static LocaleExtensions()

#### Methods
- public static string[] GetLabelsWithSupportedPlatforms()
- public static bool SupportedOnApple(UnityEngine.Purchasing.TranslationLocale locale)
- public static bool SupportedOnGoogle(UnityEngine.Purchasing.TranslationLocale locale)

### public class UnityEngine.Purchasing.LocalizedProductDescription

#### Fields
- private string description
- public UnityEngine.Purchasing.TranslationLocale googleLocale
- private string title

#### Properties
- public string Description { get; set; }
- public string Title { get; set; }

#### Constructors
- public LocalizedProductDescription()

#### Methods
- public UnityEngine.Purchasing.LocalizedProductDescription Clone()
- private static string DecodeNonLatinCharacters(string s)
- private static string EncodeNonLatinCharacters(string s)

### public class UnityEngine.Purchasing.MacAppStore

#### Fields
- public static const string Name

#### Constructors
- public MacAppStore()

### internal class UnityEngine.Purchasing.MetricizedAppleStoreImpl
- Base: UnityEngine.Purchasing.AppleStoreImpl
- Interfaces: UnityEngine.Purchasing.Extension.IStore, UnityEngine.Purchasing.IUnityCallback, UnityEngine.Purchasing.IStoreInternal, UnityEngine.Purchasing.ITransactionHistoryExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.IAppleExtensions, UnityEngine.Purchasing.IAppleConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration

#### Fields
- private readonly UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService

#### Constructors
- public MetricizedAppleStoreImpl(Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService telemetryMetricsService)

#### Methods
- private void <>n__0(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> successCallback, System.Action errorCallback)
- private void <>n__1(UnityEngine.Purchasing.Product product, System.Action<string, UnityEngine.Purchasing.AppleStorePromotionVisibility> successCallback, System.Action errorCallback)
- private void <>n__2(System.Collections.Generic.List<UnityEngine.Purchasing.Product> products)
- private void <>n__3(System.Action<bool> callback)
- private void <>n__4(System.Action<bool, string> callback)
- private void <>n__5(System.Action<string> successCallback, System.Action<string> errorCallback)
- private void <>n__6(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products)
- private void <>n__7(UnityEngine.Purchasing.ProductDefinition product, string developerPayload)
- public override void ContinuePromotionalPurchases()
- public override void FetchStorePromotionOrder(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> successCallback, System.Action errorCallback)
- public override void FetchStorePromotionVisibility(UnityEngine.Purchasing.Product product, System.Action<string, UnityEngine.Purchasing.AppleStorePromotionVisibility> successCallback, System.Action errorCallback)
- public override void PresentCodeRedemptionSheet()
- public override void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload)
- public override void RefreshAppReceipt(System.Action<string> successCallback, System.Action<string> errorCallback)
- public override void RestoreTransactions(System.Action<bool> callback)
- public override void RestoreTransactions(System.Action<bool, string> callback)
- public override void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products)
- public override void SetStorePromotionOrder(System.Collections.Generic.List<UnityEngine.Purchasing.Product> products)

### internal class UnityEngine.Purchasing.MetricizedGooglePlayStoreExtensions
- Base: UnityEngine.Purchasing.GooglePlayStoreExtensions
- Interfaces: UnityEngine.Purchasing.IGooglePlayStoreExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.IGooglePlayStoreExtensionsInternal

#### Fields
- private readonly UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService

#### Constructors
- internal MetricizedGooglePlayStoreExtensions(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, UnityEngine.ILogger logger, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService telemetryMetricsService)

#### Methods
- private void <>n__0(string oldSku, string newSku, UnityEngine.Purchasing.GooglePlayReplacementMode desiredReplacementMode)
- private void <>n__1(System.Action<bool> callback)
- private void <>n__2(System.Action<bool, string> callback)
- public override void RestoreTransactions(System.Action<bool> callback)
- public override void RestoreTransactions(System.Action<bool, string> callback)
- public override void UpgradeDowngradeSubscription(string oldSku, string newSku, UnityEngine.Purchasing.GooglePlayReplacementMode desiredReplacementMode)

### internal class UnityEngine.Purchasing.MetricizedGooglePlayStoreService
- Base: UnityEngine.Purchasing.GooglePlayStoreService
- Interfaces: UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService

#### Fields
- private readonly UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics
- private readonly UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService

#### Constructors
- internal MetricizedGooglePlayStoreService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService queryProductDetailsService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseService purchaseService, UnityEngine.Purchasing.Interfaces.IGoogleFinishTransactionService finishTransactionService, UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService queryPurchasesService, UnityEngine.Purchasing.Interfaces.IBillingClientStateListener billingClientStateListener, UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService lastKnownProductService, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService telemetryMetricsService, UnityEngine.ILogger logger, UnityEngine.Purchasing.Stores.Util.IRetryPolicy retryPolicy, Uniject.IUtil util)

#### Methods
- private void <>n__0(UnityEngine.Purchasing.Models.GoogleBillingResponseCode googleBillingResponseCode)
- private void <>n__1(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed)
- private void <>n__2(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayReplacementMode> desiredReplacementMode)
- protected override void DequeueFetchPurchases()
- protected override void DequeueQueryProducts(UnityEngine.Purchasing.Models.GoogleBillingResponseCode googleBillingResponseCode)
- public override void Purchase(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayReplacementMode> desiredReplacementMode)
- public override void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed)

### internal class UnityEngine.Purchasing.MetricizedJsonStore
- Base: UnityEngine.Purchasing.JSONStore
- Interfaces: UnityEngine.Purchasing.Extension.IStore, UnityEngine.Purchasing.IUnityCallback, UnityEngine.Purchasing.IStoreInternal, UnityEngine.Purchasing.ITransactionHistoryExtensions, UnityEngine.Purchasing.IStoreExtension

#### Fields
- private readonly UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService

#### Constructors
- public MetricizedJsonStore(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService telemetryMetricsService)

#### Methods
- private void <>n__0(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products)
- private void <>n__1(UnityEngine.Purchasing.ProductDefinition product, string developerPayload)
- public override void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload)
- public override void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products)

### private class UnityEngine.Purchasing.StandardPurchasingModule.MicrosoftConfiguration
- Interfaces: UnityEngine.Purchasing.IMicrosoftConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration

#### Fields
- private readonly UnityEngine.Purchasing.StandardPurchasingModule module
- private bool useMock

#### Properties
- public bool useMockBillingSystem { get; set; }

#### Constructors
- public StandardPurchasingModule.MicrosoftConfiguration(UnityEngine.Purchasing.StandardPurchasingModule module)

### internal class UnityEngine.Purchasing.NativeStoreProvider
- Interfaces: UnityEngine.Purchasing.INativeStoreProvider

#### Constructors
- public NativeStoreProvider()

#### Methods
- public UnityEngine.Purchasing.INativeStore GetAndroidStore(UnityEngine.Purchasing.IUnityCallback callback, UnityEngine.Purchasing.AppStore store, UnityEngine.Purchasing.Extension.IPurchasingBinder binder, Uniject.IUtil util)
- private UnityEngine.Purchasing.INativeStore GetAndroidStoreHelper(UnityEngine.Purchasing.IUnityCallback callback, UnityEngine.Purchasing.AppStore store, UnityEngine.Purchasing.Extension.IPurchasingBinder binder, Uniject.IUtil util)
- public UnityEngine.Purchasing.INativeAppleStore GetStorekit(UnityEngine.Purchasing.IUnityCallback callback)

### public class UnityEngine.Purchasing.NullProductIdException
- Base: UnityEngine.Purchasing.ReceiptParserException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public NullProductIdException()

### public class UnityEngine.Purchasing.NullReceiptException
- Base: UnityEngine.Purchasing.ReceiptParserException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public NullReceiptException()

### public class UnityEngine.Purchasing.Price
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Fields
- private int[] data
- private double num
- public decimal value

#### Constructors
- public Price()

#### Methods
- public void OnAfterDeserialize()
- public void OnBeforeSerialize()

### public class UnityEngine.Purchasing.ProductCatalog

#### Fields
- public string appleSKU
- public string appleTeamID
- public bool enableCodelessAutoInitialization
- public bool enableUnityGamingServicesAutoInitialization
- private static UnityEngine.Purchasing.IProductCatalogImpl instance
- public static const string kCatalogPath
- public static const string kPrevCatalogPath
- private System.Collections.Generic.List<UnityEngine.Purchasing.ProductCatalogItem> products

#### Properties
- public System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductCatalogItem> allProducts { get; }
- public System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductCatalogItem> allValidProducts { get; }

#### Constructors
- public ProductCatalog()

#### Methods
- public void Add(UnityEngine.Purchasing.ProductCatalogItem item)
- public static UnityEngine.Purchasing.ProductCatalog Deserialize(string catalogJSON)
- public static UnityEngine.Purchasing.ProductCatalog FromTextAsset(UnityEngine.TextAsset asset)
- internal static void Initialize()
- public static void Initialize(UnityEngine.Purchasing.IProductCatalogImpl productCatalogImpl)
- public bool IsEmpty()
- public static UnityEngine.Purchasing.ProductCatalog LoadDefaultCatalog()
- public void Remove(UnityEngine.Purchasing.ProductCatalogItem item)
- public static string Serialize(UnityEngine.Purchasing.ProductCatalog catalog)

### internal class UnityEngine.Purchasing.ProductCatalogImpl
- Interfaces: UnityEngine.Purchasing.IProductCatalogImpl

#### Constructors
- public ProductCatalogImpl()

#### Methods
- public UnityEngine.Purchasing.ProductCatalog LoadDefaultCatalog()

### public class UnityEngine.Purchasing.ProductCatalogItem

#### Fields
- public int applePriceTier
- public UnityEngine.Purchasing.LocalizedProductDescription defaultDescription
- private System.Collections.Generic.List<UnityEngine.Purchasing.LocalizedProductDescription> descriptions
- public UnityEngine.Purchasing.Price googlePrice
- public string id
- private System.Collections.Generic.List<UnityEngine.Purchasing.ProductCatalogPayout> payouts
- public string pricingTemplateID
- public string screenshotPath
- private System.Collections.Generic.List<UnityEngine.Purchasing.StoreID> storeIDs
- public UnityEngine.Purchasing.ProductType type
- public UnityEngine.Purchasing.Price udpPrice

#### Properties
- public System.Collections.Generic.ICollection<UnityEngine.Purchasing.StoreID> allStoreIDs { get; }
- public bool HasAvailableLocale { get; }
- public UnityEngine.Purchasing.TranslationLocale NextAvailableLocale { get; }
- public System.Collections.Generic.IList<UnityEngine.Purchasing.ProductCatalogPayout> Payouts { get; }
- public System.Collections.Generic.ICollection<UnityEngine.Purchasing.LocalizedProductDescription> translatedDescriptions { get; }

#### Constructors
- public ProductCatalogItem()

#### Methods
- public UnityEngine.Purchasing.LocalizedProductDescription AddDescription(UnityEngine.Purchasing.TranslationLocale locale)
- public void AddPayout()
- public UnityEngine.Purchasing.ProductCatalogItem Clone()
- public UnityEngine.Purchasing.LocalizedProductDescription GetDescription(UnityEngine.Purchasing.TranslationLocale locale)
- public UnityEngine.Purchasing.LocalizedProductDescription GetOrCreateDescription(UnityEngine.Purchasing.TranslationLocale locale)
- public string GetStoreID(string store)
- public void RemoveDescription(UnityEngine.Purchasing.TranslationLocale locale)
- public void RemovePayout(UnityEngine.Purchasing.ProductCatalogPayout payout)
- public void SetStoreID(string aStore, string aId)
- public void SetStoreIDs(System.Collections.Generic.ICollection<UnityEngine.Purchasing.StoreID> storeIds)

### public class UnityEngine.Purchasing.ProductCatalogPayout

#### Fields
- private string d
- public static const int MaxDataLength
- public static const int MaxSubtypeLength
- private double q
- private string st
- private string t

#### Properties
- public string data { get; set; }
- public double quantity { get; set; }
- public string subtype { get; set; }
- public UnityEngine.Purchasing.ProductCatalogPayout.ProductCatalogPayoutType type { get; set; }
- public string typeString { get; }

#### Constructors
- public ProductCatalogPayout()

### public enum UnityEngine.Purchasing.ProductCatalogPayout.ProductCatalogPayoutType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Currency = 1
- Item = 2
- Other = 0
- Resource = 3

### internal static class UnityEngine.Purchasing.ProductDefinitionExtensions

#### Methods
- internal static System.Collections.Generic.List<UnityEngine.Purchasing.ProductDefinition> DecodeJSON(System.Collections.Generic.List<object> productsList, string storeName)

### internal class UnityEngine.Purchasing.ProductDetailsQueryResponse
- Interfaces: UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse

#### Fields
- private readonly System.Collections.Concurrent.ConcurrentBag<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>> m_Responses

#### Constructors
- public ProductDetailsQueryResponse()

#### Methods
- public void AddResponse(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails)
- protected override void Finalize()
- public UnityEngine.Purchasing.Models.IGoogleBillingResult GetGoogleBillingResult()
- public bool IsRecoverable()
- private static bool IsRecoverable(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult)
- public System.Collections.Generic.List<UnityEngine.AndroidJavaObject> ProductDetails()

### internal class UnityEngine.Purchasing.ProductDetailsResponseConsolidator
- Interfaces: UnityEngine.Purchasing.Interfaces.IProductDetailsResponseConsolidator

#### Fields
- private static const int k_RequiredNumberOfCallbacks
- private int m_NumberReceivedCallbacks
- private readonly System.Action<UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse> m_OnProductDetailsResponseConsolidated
- private readonly UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse m_Responses
- private readonly UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics
- private readonly Uniject.IUtil m_Util

#### Constructors
- internal ProductDetailsResponseConsolidator(Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, System.Action<UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse> onProductDetailsResponseConsolidated)

#### Methods
- public void Consolidate(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails)

### internal class UnityEngine.Purchasing.ProductDetailsResponseListener
- Base: UnityEngine.AndroidJavaProxy

#### Fields
- private static const string k_AndroidProductDetailsResponseListenerClassName
- private readonly System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> m_OnProductDetailsResponse
- private readonly UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics
- private readonly Uniject.IUtil m_Util

#### Constructors
- internal ProductDetailsResponseListener(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onProductDetailsResponseAction, Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics)

#### Methods
- public void onProductDetailsResponse(UnityEngine.AndroidJavaObject billingResult, UnityEngine.AndroidJavaObject productDetails)

### internal class UnityEngine.Purchasing.ProductInfoInterface

#### Fields
- private static System.Type s_typeCache

#### Constructors
- public ProductInfoInterface()

#### Methods
- private static System.Type GetClassType()
- public static System.Reflection.PropertyInfo GetCurrencyProp()
- public static System.Reflection.PropertyInfo GetDescriptionProp()
- public static System.Reflection.PropertyInfo GetPriceAmountMicrosProp()
- public static System.Reflection.PropertyInfo GetPriceProp()
- public static System.Reflection.PropertyInfo GetProductIdProp()
- public static System.Reflection.PropertyInfo GetTitleProp()

### internal static class UnityEngine.Purchasing.QueryHelper

#### Methods
- internal static string ToQueryString(System.Collections.Generic.Dictionary<string, object> parameters)

### internal class UnityEngine.Purchasing.QueryProductDetailsService
- Interfaces: UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService

#### Fields
- private readonly UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient
- private readonly UnityEngine.Purchasing.IGoogleCachedQueryProductDetailsService m_GoogleCachedQueryProductDetailsService
- private readonly UnityEngine.Purchasing.Interfaces.IGoogleProductCallback m_GoogleProductCallback
- private readonly UnityEngine.Purchasing.Interfaces.IProductDetailsConverter m_ProductDetailsConverter
- private readonly UnityEngine.Purchasing.Stores.Util.IRetryPolicy m_RetryPolicy
- private readonly UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics
- private readonly Uniject.IUtil m_Util

#### Constructors
- internal QueryProductDetailsService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.IGoogleCachedQueryProductDetailsService googleCachedQueryProductDetailsService, UnityEngine.Purchasing.Interfaces.IProductDetailsConverter productDetailsConverter, UnityEngine.Purchasing.Stores.Util.IRetryPolicy retryPolicy, UnityEngine.Purchasing.Interfaces.IGoogleProductCallback googleProductCallback, Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics)

#### Methods
- private bool AreAllProductDetailsCached(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products)
- private System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products)
- public void QueryAsyncProduct(UnityEngine.Purchasing.ProductDefinition product, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse)
- public void QueryAsyncProduct(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse)
- public void QueryAsyncProduct(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse)
- private void QueryAsyncProductWithRetries(System.Collections.Generic.IReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse, System.Action retryQuery)
- private void QueryInAppsAsync(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products, UnityEngine.Purchasing.Interfaces.IProductDetailsResponseConsolidator consolidator)
- private void QueryProductDetails(System.Collections.Generic.List<string> productList, string type, UnityEngine.Purchasing.Interfaces.IProductDetailsResponseConsolidator consolidator)
- private void QuerySubsAsync(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products, UnityEngine.Purchasing.Interfaces.IProductDetailsResponseConsolidator consolidator)
- private bool ShouldRetryQuery(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> requestedProducts, UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse queryResponse)
- private void TryQueryAsyncProductWithRetries(System.Collections.Generic.IReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse, System.Action retryQuery)

### public class UnityEngine.Purchasing.ReceiptParserException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public ReceiptParserException()
- public ReceiptParserException(string message)

### public enum UnityEngine.Purchasing.Result
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- False = 1
- True = 0
- Unsupported = 2

### internal class UnityEngine.Purchasing.ScriptingStoreCallback
- Interfaces: UnityEngine.Purchasing.Extension.IStoreCallback

#### Fields
- private bool <useTransactionLog>k__BackingField
- private readonly UnityEngine.Purchasing.Extension.IStoreCallback m_ForwardTo
- private readonly Uniject.IUtil m_Util

#### Properties
- public UnityEngine.Purchasing.ProductCollection products { get; }
- public bool useTransactionLog { get; set; }

#### Constructors
- public ScriptingStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback forwardTo, Uniject.IUtil util)

#### Methods
- public void OnAllPurchasesRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts)
- public void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products)
- public void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription desc)
- public void OnPurchaseSucceeded(string id, string receipt, string transactionID)
- public void OnSetupFailed(UnityEngine.Purchasing.InitializationFailureReason reason)
- public void OnSetupFailed(UnityEngine.Purchasing.InitializationFailureReason reason, string message)

### internal class UnityEngine.Purchasing.ScriptingUnityCallback
- Interfaces: UnityEngine.Purchasing.IUnityCallback

#### Fields
- private readonly UnityEngine.Purchasing.IUnityCallback forwardTo
- private readonly Uniject.IUtil util

#### Constructors
- public ScriptingUnityCallback(UnityEngine.Purchasing.IUnityCallback forwardTo, Uniject.IUtil util)

#### Methods
- public void OnProductsRetrieved(string json)
- public void OnPurchaseFailed(string json)
- public void OnPurchaseSucceeded(string id, string receipt, string transactionID)
- public void OnSetupFailed(string json)

### internal static class UnityEngine.Purchasing.SerializationExtensions

#### Methods
- public static string TryGetString(System.Collections.Generic.Dictionary<string, object> dic, string key)

### public class UnityEngine.Purchasing.StandardPurchasingModule
- Base: UnityEngine.Purchasing.Extension.AbstractPurchasingModule
- Interfaces: UnityEngine.Purchasing.Extension.IPurchasingModule, UnityEngine.Purchasing.IAndroidStoreSelection, UnityEngine.Purchasing.Extension.IStoreConfiguration

#### Fields
- private UnityEngine.Purchasing.AppStore <appStore>k__BackingField
- private UnityEngine.ILogger <logger>k__BackingField
- private UnityEngine.Purchasing.StandardPurchasingModule.StoreInstance <storeInstance>k__BackingField
- private UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper <telemetryDiagnosticsInstanceWrapper>k__BackingField
- private UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper <telemetryMetricsInstanceWrapper>k__BackingField
- private bool <useFakeStoreAlways>k__BackingField
- private UnityEngine.Purchasing.FakeStoreUIMode <useFakeStoreUIMode>k__BackingField
- private Uniject.IUtil <util>k__BackingField
- private static readonly System.Collections.Generic.Dictionary<UnityEngine.Purchasing.AppStore, string> AndroidStoreNameMap
- public static const string k_PackageVersion
- internal readonly string k_Version
- private static UnityEngine.Purchasing.StandardPurchasingModule ModuleInstance
- private readonly UnityEngine.Purchasing.INativeStoreProvider m_NativeStoreProvider
- private readonly UnityEngine.RuntimePlatform m_RuntimePlatform
- private readonly bool usingMockMicrosoft
- private UnityEngine.Purchasing.WinRTStore windowsStore

#### Properties
- public UnityEngine.Purchasing.AppStore appStore { get; private set; }
- internal UnityEngine.ILogger logger { get; private set; }
- internal UnityEngine.Purchasing.StandardPurchasingModule.StoreInstance storeInstance { get; private set; }
- internal UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper { get; set; }
- internal UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper { get; set; }
- public bool useFakeStoreAlways { get; set; }
- public UnityEngine.Purchasing.FakeStoreUIMode useFakeStoreUIMode { get; set; }
- internal Uniject.IUtil util { get; private set; }
- public string Version { get; }

#### Constructors
- private static StandardPurchasingModule()
- internal StandardPurchasingModule(Uniject.IUtil util, UnityEngine.ILogger logger, UnityEngine.Purchasing.INativeStoreProvider nativeStoreProvider, UnityEngine.RuntimePlatform platform, UnityEngine.Purchasing.AppStore android, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper, UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper)

#### Methods
- private void BindGoogleConfiguration(UnityEngine.Purchasing.GooglePlayConfiguration googlePlayConfiguration)
- private void BindGoogleExtension(UnityEngine.Purchasing.GooglePlayStoreExtensions googlePlayStoreExtensions)
- private UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService BuildAndInitGooglePlayStoreServiceAar(UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.Interfaces.IGoogleProductCallback googleProductCallback, UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider)
- private static UnityEngine.Purchasing.GooglePlayConfiguration BuildGooglePlayStoreConfiguration(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.Interfaces.IGoogleProductCallback googleProductCallback)
- public override void Configure()
- private UnityEngine.Purchasing.INativeStore GetAndroidNativeStore(UnityEngine.Purchasing.JSONStore store)
- public static UnityEngine.Purchasing.StandardPurchasingModule Instance()
- public static UnityEngine.Purchasing.StandardPurchasingModule Instance(UnityEngine.Purchasing.AppStore androidStore)
- private UnityEngine.Purchasing.Extension.IStore InstantiateAndroid()
- private UnityEngine.Purchasing.Extension.IStore InstantiateAndroidHelper(UnityEngine.Purchasing.JSONStore store)
- private UnityEngine.Purchasing.Extension.IStore InstantiateApple()
- private UnityEngine.Purchasing.Extension.IStore InstantiateFakeStore()
- private UnityEngine.Purchasing.Extension.IStore InstantiateGoogleStore()
- private UnityEngine.Purchasing.StandardPurchasingModule.StoreInstance InstantiateStore()
- private UnityEngine.Purchasing.Extension.IStore InstantiateUDP()
- private UnityEngine.Purchasing.Extension.IStore instantiateWindowsStore()
- private void UseMockWindowsStore(bool value)

### public static class UnityEngine.Purchasing.StoreCallbackExtensionMethods

#### Methods
- public static UnityEngine.Purchasing.Product FindProductById(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback, string sku)

### internal class UnityEngine.Purchasing.StoreConfiguration

#### Fields
- private UnityEngine.Purchasing.AppStore <androidStore>k__BackingField

#### Properties
- public UnityEngine.Purchasing.AppStore androidStore { get; private set; }

#### Constructors
- public StoreConfiguration(UnityEngine.Purchasing.AppStore store)

#### Methods
- public static UnityEngine.Purchasing.StoreConfiguration Deserialize(string json)
- public static string Serialize(UnityEngine.Purchasing.StoreConfiguration store)

### public class UnityEngine.Purchasing.StoreID

#### Fields
- public string id
- public string store

#### Constructors
- public StoreID(string store_, string id_)

### internal class UnityEngine.Purchasing.StandardPurchasingModule.StoreInstance

#### Fields
- private readonly UnityEngine.Purchasing.Extension.IStore <instance>k__BackingField
- private readonly string <storeName>k__BackingField

#### Properties
- internal UnityEngine.Purchasing.Extension.IStore instance { get; }
- internal string storeName { get; }

#### Constructors
- internal StandardPurchasingModule.StoreInstance(string name, UnityEngine.Purchasing.Extension.IStore instance)

### internal class UnityEngine.Purchasing.StoreServiceInterface

#### Fields
- private static System.Type s_typeCache

#### Constructors
- public StoreServiceInterface()

#### Methods
- internal static System.Type GetClassType()
- internal static System.Reflection.MethodInfo GetEnableDebugLoggingMethod()
- internal static string GetName()
- private static System.Reflection.PropertyInfo GetNameProp()

### public enum UnityEngine.Purchasing.StoreSpecificPurchaseErrorCode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Amazon_ALREADY_PURCHASED = 29
- Amazon_FAILED = 30
- Amazon_INVALID_SKU = 31
- Amazon_NOT_SUPPORTED = 32
- BILLING_RESPONSE_RESULT_BILLING_UNAVAILABLE = 12
- BILLING_RESPONSE_RESULT_DEVELOPER_ERROR = 14
- BILLING_RESPONSE_RESULT_ERROR = 15
- BILLING_RESPONSE_RESULT_ITEM_ALREADY_OWNED = 16
- BILLING_RESPONSE_RESULT_ITEM_NOT_OWNED = 17
- BILLING_RESPONSE_RESULT_ITEM_UNAVAILABLE = 13
- BILLING_RESPONSE_RESULT_OK = 9
- BILLING_RESPONSE_RESULT_SERVICE_UNAVAILABLE = 11
- BILLING_RESPONSE_RESULT_USER_CANCELED = 10
- IABHELPER_BAD_RESPONSE = 20
- IABHELPER_ERROR_BASE = 18
- IABHELPER_INVALID_CONSUMPTION = 28
- IABHELPER_MISSING_TOKEN = 25
- IABHELPER_REMOTE_EXCEPTION = 19
- IABHELPER_SEND_INTENT_FAILED = 22
- IABHELPER_SUBSCRIPTIONS_NOT_AVAILABLE = 27
- IABHELPER_UNKNOWN_ERROR = 26
- IABHELPER_UNKNOWN_PURCHASE_RESPONSE = 24
- IABHELPER_USER_CANCELLED = 23
- IABHELPER_VERIFICATION_FAILED = 21
- SKErrorClientInvalid = 1
- SKErrorCloudServiceNetworkConnectionFailed = 7
- SKErrorCloudServicePermissionDenied = 6
- SKErrorCloudServiceRevoked = 8
- SKErrorPaymentCancelled = 2
- SKErrorPaymentInvalid = 3
- SKErrorPaymentNotAllowed = 4
- SKErrorStoreProductNotAvailable = 5
- SKErrorUnknown = 0
- Unknown = 33

### public class UnityEngine.Purchasing.StoreSubscriptionInfoNotSupportedException
- Base: UnityEngine.Purchasing.ReceiptParserException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public StoreSubscriptionInfoNotSupportedException(string message)

### public class UnityEngine.Purchasing.SubscriptionInfo

#### Fields
- private readonly System.TimeSpan freeTrialPeriod
- private readonly string free_trial_period_string
- private readonly string introductory_price
- private readonly long introductory_price_cycles
- private readonly System.TimeSpan introductory_price_period
- private readonly UnityEngine.Purchasing.Result is_auto_renewing
- private readonly UnityEngine.Purchasing.Result is_cancelled
- private readonly UnityEngine.Purchasing.Result is_expired
- private readonly UnityEngine.Purchasing.Result is_free_trial
- private readonly UnityEngine.Purchasing.Result is_introductory_price_period
- private readonly UnityEngine.Purchasing.Result is_subscribed
- private readonly string productId
- private readonly System.DateTime purchaseDate
- private readonly System.TimeSpan remainedTime
- private readonly string sku_details
- private readonly System.DateTime subscriptionCancelDate
- private readonly System.DateTime subscriptionExpireDate
- private readonly System.TimeSpan subscriptionPeriod

#### Constructors
- public SubscriptionInfo(string productId)
- public SubscriptionInfo(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt r, string intro_json)
- public SubscriptionInfo(string skuDetails, bool isAutoRenewing, System.DateTime purchaseDate, bool isFreeTrial, bool hasIntroductoryPriceTrial, bool purchaseHistorySupported, string updateMetadata)

#### Methods
- private System.TimeSpan accumulateIntroductoryDuration(UnityEngine.Purchasing.TimeSpanUnits units, long cycles)
- private double computeExtraTime(string metadata, double new_sku_period_in_seconds)
- private System.TimeSpan computePeriodTimeSpan(UnityEngine.Purchasing.TimeSpanUnits units)
- public System.DateTime getCancelDate()
- public System.DateTime getExpireDate()
- public System.TimeSpan getFreeTrialPeriod()
- public string getFreeTrialPeriodString()
- public string getIntroductoryPrice()
- public System.TimeSpan getIntroductoryPricePeriod()
- public long getIntroductoryPricePeriodCycles()
- public string getProductId()
- public System.DateTime getPurchaseDate()
- public System.TimeSpan getRemainingTime()
- public string getSkuDetails()
- public string getSubscriptionInfoJsonString()
- public System.TimeSpan getSubscriptionPeriod()
- public UnityEngine.Purchasing.Result isAutoRenewing()
- public UnityEngine.Purchasing.Result isCancelled()
- public UnityEngine.Purchasing.Result isExpired()
- public UnityEngine.Purchasing.Result isFreeTrial()
- public UnityEngine.Purchasing.Result isIntroductoryPricePeriod()
- public UnityEngine.Purchasing.Result isSubscribed()
- private System.DateTime nextBillingDate(System.DateTime billing_begin_date, UnityEngine.Purchasing.TimeSpanUnits units)
- private UnityEngine.Purchasing.TimeSpanUnits parsePeriodTimeSpanUnits(string time_span)
- private System.TimeSpan parseTimeSpan(string period_string)

### public class UnityEngine.Purchasing.SubscriptionManager

#### Fields
- private readonly string intro_json
- private readonly string productId
- private readonly string receipt

#### Constructors
- public SubscriptionManager(UnityEngine.Purchasing.Product product, string intro_json)
- public SubscriptionManager(string receipt, string id, string intro_json)

#### Methods
- private UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt findMostRecentReceipt(System.Collections.Generic.List<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt> receipts)
- private UnityEngine.Purchasing.SubscriptionInfo getAmazonAppStoreSubInfo(string productId)
- private UnityEngine.Purchasing.SubscriptionInfo getAppleAppStoreSubInfo(string payload, string productId)
- private UnityEngine.Purchasing.SubscriptionInfo getGooglePlayStoreSubInfo(string payload)
- public UnityEngine.Purchasing.SubscriptionInfo getSubscriptionInfo()
- public static void UpdateSubscription(UnityEngine.Purchasing.Product newProduct, UnityEngine.Purchasing.Product oldProduct, string developerPayload, System.Action<UnityEngine.Purchasing.Product, string> appleStore, System.Action<string, string> googleStore)
- public static void UpdateSubscriptionInAppleStore(UnityEngine.Purchasing.Product newProduct, string developerPayload, System.Action<UnityEngine.Purchasing.Product, string> appleStoreUpdateCallback)
- public static void UpdateSubscriptionInGooglePlayStore(UnityEngine.Purchasing.Product oldProduct, UnityEngine.Purchasing.Product newProduct, System.Action<string, string> googlePlayUpdateCallback)

### public enum UnityEngine.Purchasing.SubscriptionPeriodUnit
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Day = 0
- Month = 1
- NotAvailable = 4
- Week = 2
- Year = 3

### public class UnityEngine.Purchasing.TimeSpanUnits

#### Fields
- public double days
- public int months
- public int years

#### Constructors
- public TimeSpanUnits(double d, int m, int y)

### public enum UnityEngine.Purchasing.TranslationLocale
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- cs_CZ = 1
- da_DK = 2
- de_DE = 7
- el_GR = 24
- en_AU = 20
- en_CA = 21
- en_GB = 22
- en_US = 4
- es_ES = 17
- es_MX = 28
- fi_FI = 6
- fr_CA = 23
- fr_FR = 5
- hi_IN = 9
- id_ID = 25
- it_IT = 10
- iw_IL = 8
- ja_JP = 11
- ko_KR = 12
- ms_MY = 26
- nl_NL = 3
- no_NO = 13
- pl_PL = 14
- pt_BR = 27
- pt_PT = 15
- ru_RU = 16
- sv_SE = 18
- th_TH = 29
- tr_TR = 30
- vi_VN = 31
- zh_CN = 19
- zh_TW = 0

### public class UnityEngine.Purchasing.UDP

#### Properties
- public static string Name { get; }

#### Constructors
- public UDP()

### internal class UnityEngine.Purchasing.UDPBindings
- Interfaces: UnityEngine.Purchasing.INativeUDPStore, UnityEngine.Purchasing.INativeStore

#### Fields
- private readonly object m_Bridge
- private System.Action<bool, string> m_RetrieveProductsCallbackCache

#### Constructors
- public UDPBindings()

#### Methods
- public void FinishTransaction(UnityEngine.Purchasing.ProductDefinition productDefinition, string transactionID)
- public void FinishTransaction(string productJSON, string transactionID)
- public void Initialize(System.Action<bool, string> callback)
- private void OnInventoryQueried(bool success, object payload)
- public void Purchase(string productId, System.Action<bool, string> callback, string developerPayload = null)
- public void Purchase(string productJSON, string developerPayload)
- public void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<bool, string> callback)
- public void RetrieveProducts(string json)
- internal static System.Collections.Generic.Dictionary<string, string> StringPropertyToDictionary(object info)

### internal class UnityEngine.Purchasing.UdpIapBridgeInterface

#### Fields
- private static System.Type s_typeCache

#### Constructors
- public UdpIapBridgeInterface()

#### Methods
- internal static System.Type GetClassType()
- internal static System.Reflection.MethodInfo GetFinishTransactionMethod()
- internal static System.Reflection.MethodInfo GetInitMethod()
- internal static System.Reflection.MethodInfo GetPurchaseMethod()
- internal static System.Reflection.MethodInfo GetRetrieveProductsMethod()

### internal class UnityEngine.Purchasing.UDPImpl
- Base: UnityEngine.Purchasing.JSONStore
- Interfaces: UnityEngine.Purchasing.Extension.IStore, UnityEngine.Purchasing.IUnityCallback, UnityEngine.Purchasing.IStoreInternal, UnityEngine.Purchasing.ITransactionHistoryExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.IUDPExtensions

#### Fields
- private static const string k_Errorcode
- private static const string k_Unknown
- private UnityEngine.Purchasing.INativeUDPStore m_Bindings
- private System.Action<UnityEngine.Purchasing.Product> m_DeferredCallback
- private bool m_Initialized
- private string m_LastInitError
- private object m_UserInfo
- private static const int PURCHASE_PENDING_CODE

#### Constructors
- public UDPImpl()

#### Methods
- private static void DictionaryToStringProperty(System.Collections.Generic.Dictionary<string, object> dic, object info)
- public void EnableDebugLog(bool enable)
- public override void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId)
- public string GetLastInitializationError()
- public object GetUserInfo()
- public override void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback)
- private void OnPurchaseDeferred(string productId)
- public override void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload)
- public void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> callback)
- public override void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products)
- public void SetNativeStore(UnityEngine.Purchasing.INativeUDPStore nativeUdpStore)

### internal struct UnityEngine.Purchasing.UDPReflectionConsts

#### Fields
- internal static const string k_AppStoreSettingsAppSlugField
- internal static const string k_AppStoreSettingsAssetPathField
- internal static const string k_AppStoreSettingsClientIDField
- internal static const string k_AppStoreSettingsType
- internal static const string k_BuildConfigApiEndpointField
- internal static const string k_BuildConfigIdEndpointField
- internal static const string k_BuildConfigType
- internal static const string k_BuildConfigUdpEndpointField
- internal static const string k_BuildConfigVersionField
- internal static const string k_InventoryGetProductListMethod
- internal static const string k_InventoryGetPurchaseInfoMethod
- internal static const string k_InventoryHasPurchaseMethod
- internal static const string k_InventoryType
- internal static const string k_ProductInfoCurrencyProp
- internal static const string k_ProductInfoDescProp
- internal static const string k_ProductInfoIdProp
- internal static const string k_ProductInfoPriceProp
- internal static const string k_ProductInfoTitleProp
- internal static const string k_ProductInfoType
- internal static const string k_ProductnfoPriceAmountMicrosProp
- internal static const string k_StoreServiceEnableDebugLoggingMethod
- internal static const string k_StoreServiceNameProp
- internal static const string k_StoreServiceType
- private static const string k_UdpEngineNamespace
- internal static const string k_UdpIapBridgeFinishTransactionMethod
- internal static const string k_UdpIapBridgeInitMethod
- internal static const string k_UdpIapBridgePurchaseMethod
- internal static const string k_UdpIapBridgeRetrieveProductsMethod
- internal static const string k_UdpIapBridgeType
- internal static const string k_UserInfoChannelProp
- internal static const string k_UserInfoIdProp
- internal static const string k_UserInfoLoginTokenProp
- internal static const string k_UserInfoType

### internal class UnityEngine.Purchasing.UDPReflectionUtils

#### Fields
- internal static const System.Reflection.BindingFlags k_InstanceBindingFlags
- internal static const System.Reflection.BindingFlags k_PrivateStaticBindingFlags
- internal static const System.Reflection.BindingFlags k_StaticBindingFlags
- private static readonly string[] k_whiteListedAssemblies
- private static readonly System.Collections.Generic.Dictionary<System.Reflection.Assembly, System.Type[]> s_assemblyTypeCache
- private static readonly System.Collections.Generic.Dictionary<string, System.Type> s_typeCache

#### Constructors
- public UDPReflectionUtils()
- private static UDPReflectionUtils()

#### Methods
- private static System.Collections.Generic.IEnumerable<System.Reflection.Assembly> GetAllAssemblies()
- internal static System.Type GetTypeByName(string typeName)
- private static System.Collections.Generic.IEnumerable<System.Type> GetTypes(System.Reflection.Assembly assembly)

### internal class UnityEngine.Purchasing.UIFakeStore
- Base: UnityEngine.Purchasing.FakeStore
- Interfaces: UnityEngine.Purchasing.Extension.IStore, UnityEngine.Purchasing.IUnityCallback, UnityEngine.Purchasing.IStoreInternal, UnityEngine.Purchasing.ITransactionHistoryExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.IFakeExtensions, UnityEngine.Purchasing.INativeStore

#### Fields
- private static const string EnvironmentDescriptionPostfix
- private UnityEngine.Purchasing.DialogRequest m_CurrentDialog
- private UnityEngine.GameObject m_EventSystem
- private int m_LastSelectedDropdownIndex
- private UnityEngine.GameObject m_UIFakeStoreWindowObject
- private readonly Uniject.IUtil m_Util
- private static const int RetrieveProductsDescriptionCount
- private static const string SuccessString

#### Constructors
- public UIFakeStore()
- public UIFakeStore(Uniject.IUtil util)

#### Methods
- private void <AddLifeCycleNotifierAndSetDestroyCallback>b__14_0()
- private void AddLifeCycleNotifierAndSetDestroyCallback(UnityEngine.GameObject gameObject)
- private void CancelButtonClicked()
- private void CloseDialog()
- private void ConfigureDialogWindow(UnityEngine.Purchasing.UIFakeStoreWindow dialogWindow)
- private void ConfigureDialogWindowCallbacks(UnityEngine.Purchasing.UIFakeStoreWindow dialogWindow, bool assignCancelCallback, bool assignDropDownCallback)
- private void CreateEventSystem(UnityEngine.Transform rootTransform)
- private string CreatePurchaseQuestion(UnityEngine.Purchasing.ProductDefinition definition)
- private string CreateRetrieveProductsQuestion(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> definitions)
- private void DropdownValueChanged(int selectedItem)
- private void EnsureEventSystemCreated(UnityEngine.Transform rootTransform)
- private UnityEngine.Purchasing.UIFakeStoreWindow GetOrCreateFakeStoreWindow()
- private void InstantiateDialog()
- public bool IsShowingDialog()
- private void OkayButtonClicked()
- protected override bool StartUI<T>(object model, UnityEngine.Purchasing.FakeStore.DialogType dialogType, System.Action<bool, T> callback)
- private bool StartUI(string queryText, string okayButtonText, string cancelButtonText, System.Collections.Generic.List<string> options, System.Action<bool, int> callback)

### internal class UnityEngine.Purchasing.UIFakeStoreDropdown

#### Fields
- private System.Action<int, string> m_OnDropdown
- private System.Collections.Generic.List<string> m_Options
- private UnityEngine.Vector2 scrollPosition

#### Constructors
- public UIFakeStoreDropdown()

#### Methods
- public void DoPopup(int windowID)
- private void OnOptionSelected(int optionIndex)
- internal void SetOptions(System.Collections.Generic.List<string> options)
- internal void SetSelectionAction(System.Action<int, string> onDropdown)

### internal class UnityEngine.Purchasing.UIFakeStoreWindow
- Base: UnityEngine.MonoBehaviour

#### Fields
- private static const float k_MenuScreenRatio
- private bool m_CancelEnabled
- private string m_CancelText
- private bool m_DoDropdown
- private readonly UnityEngine.Purchasing.UIFakeStoreDropdown m_Dropdown
- private bool m_DropdownEnabled
- private string m_LastSelectedOptionText
- private string m_OkText
- private System.Action m_OnCancel
- private System.Action<int> m_OnDropdown
- private System.Action m_OnOk
- private string m_QueryText
- private UnityEngine.Vector2 scrollPosition

#### Constructors
- public UIFakeStoreWindow()

#### Methods
- internal void AssignCallbacks(System.Action onOk, System.Action onCancel, System.Action<int> onDropdown)
- internal void ConfigureDropdownOptions(System.Collections.Generic.List<string> options)
- internal void ConfigureMainDialogText(string queryText, string okText, string cancelText)
- private UnityEngine.Rect CreateCenteredWindowRect()
- private void DoDropDown()
- private void DoMainGUI(int windowID)
- private void OnCancelClicked()
- private void OnDropdown(int index, string selectionText)
- private void OnGUI()
- private void OnOkClicked()

### internal class UnityEngine.Purchasing.UnityActivity

#### Fields
- private static const string k_AndroidClassName
- private static UnityEngine.AndroidJavaClass s_UnityPlayerClass

#### Constructors
- public UnityActivity()

#### Methods
- internal static UnityEngine.AndroidJavaObject GetCurrentActivity()
- private static UnityEngine.AndroidJavaClass GetUnityPlayerClass()

### internal class UnityEngine.Purchasing.UserInfoInterface

#### Fields
- private static System.Type s_typeCache

#### Constructors
- public UserInfoInterface()

#### Methods
- internal static System.Reflection.PropertyInfo GetChannelProp()
- internal static System.Type GetClassType()
- internal static System.Reflection.PropertyInfo GetIdProp()
- internal static System.Reflection.PropertyInfo GetLoginTokenProp()

### public class UnityEngine.Purchasing.WindowsStore

#### Fields
- public static const string Name

#### Constructors
- public WindowsStore()

### internal class UnityEngine.Purchasing.WinRTStore
- Base: UnityEngine.Purchasing.Extension.AbstractStore
- Interfaces: UnityEngine.Purchasing.Extension.IStore, UnityEngine.Purchasing.Default.IWindowsIAPCallback, UnityEngine.Purchasing.IMicrosoftExtensions, UnityEngine.Purchasing.IStoreExtension

#### Fields
- private UnityEngine.Purchasing.Extension.IStoreCallback callback
- private readonly UnityEngine.ILogger logger
- private bool m_CanReceivePurchases
- private readonly Uniject.IUtil util
- private UnityEngine.Purchasing.Default.IWindowsIAP win8

#### Constructors
- public WinRTStore(UnityEngine.Purchasing.Default.IWindowsIAP win8, Uniject.IUtil util, UnityEngine.ILogger logger)

#### Methods
- public override void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId)
- private void init(int delay)
- public override void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback biller)
- public void log(string message)
- public void logError(string error)
- public void OnProductListError(string message)
- public void OnProductListReceived(UnityEngine.Purchasing.Default.WinProductDescription[] winProducts)
- public void OnPurchaseFailed(string productId, string error)
- public void OnPurchaseSucceeded(string productId, string receipt, string tranId)
- public override void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload)
- public void restoreTransactions(bool pausing)
- public void RestoreTransactions()
- public override void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> productDefs)
- public void SetWindowsIAP(UnityEngine.Purchasing.Default.IWindowsIAP iap)

## Namespace: UnityEngine.Purchasing.Extension

### private class UnityEngine.Purchasing.Extension.UnityUtil.<DelayedCoroutine>d__48
- Interfaces: System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- public UnityEngine.Purchasing.Extension.UnityUtil <>4__this
- public System.Collections.IEnumerator coroutine
- public int delay

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public UnityUtil.<DelayedCoroutine>d__48(int <>1__state)

#### Methods
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### internal class UnityEngine.Purchasing.Extension.UnityUtil
- Base: UnityEngine.MonoBehaviour
- Interfaces: Uniject.IUtil

#### Fields
- private readonly System.Collections.Generic.List<System.Action<bool>> pauseListeners
- private static readonly System.Collections.Generic.List<System.Action> s_Callbacks
- private static bool s_CallbacksPending
- private static readonly System.Collections.Generic.List<UnityEngine.RuntimePlatform> s_PcControlledPlatforms

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

#### Constructors
- public UnityUtil()
- private static UnityUtil()

#### Methods
- public void AddPauseListener(System.Action<bool> runnable)
- private System.Collections.IEnumerator DelayedCoroutine(System.Collections.IEnumerator coroutine, int delay)
- public static T FindInstanceOfType<T>()
- public T[] GetAnyComponentsOfType<T>()
- public object GetWaitForSeconds(int seconds)
- public bool IsClassOrSubclass(System.Type potentialBase, System.Type potentialDescendant)
- public static T LoadResourceInstanceOfType<T>()
- public void OnApplicationPause(bool paused)
- public static bool PcPlatform()
- public void RunOnMainThread(System.Action runnable)
- private void Start()
- private object Uniject.IUtil.InitiateCoroutine(System.Collections.IEnumerator start)
- private void Uniject.IUtil.InitiateCoroutine(System.Collections.IEnumerator start, int delay)
- private void Update()

## Namespace: UnityEngine.Purchasing.Interfaces

### internal interface UnityEngine.Purchasing.Interfaces.IBillingClientStateListener

#### Methods
- public void RegisterOnConnected(System.Action onConnected)
- public void RegisterOnDisconnected(System.Action<UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onDisconnected)

### internal interface UnityEngine.Purchasing.Interfaces.IGoogleBillingClient

#### Methods
- public void AcknowledgePurchase(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledge)
- public void ConsumeAsync(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsume)
- public void EndConnection()
- public UnityEngine.Purchasing.GoogleBillingConnectionState GetConnectionState()
- public bool IsReady()
- public UnityEngine.AndroidJavaObject LaunchBillingFlow(UnityEngine.AndroidJavaObject productDetails, string oldPurchaseToken, System.Nullable<UnityEngine.Purchasing.GooglePlayReplacementMode> replacementMode)
- public void QueryProductDetailsAsync(System.Collections.Generic.List<string> skus, string type, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onProductDetailsResponseAction)
- public void QueryPurchasesAsync(string skuType, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> onQueryPurchasesResponse)
- public void SetObfuscationAccountId(string obfuscationAccountId)
- public void SetObfuscationProfileId(string obfuscationProfileId)
- public void StartConnection(UnityEngine.Purchasing.Interfaces.IBillingClientStateListener billingClientStateListener)

### internal interface UnityEngine.Purchasing.Interfaces.IGoogleFinishTransactionService

#### Methods
- public void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished)

### internal interface UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService

#### Properties
- public string LastKnownOldProductId { get; set; }
- public string LastKnownProductId { get; set; }
- public System.Nullable<UnityEngine.Purchasing.GooglePlayReplacementMode> LastKnownReplacementMode { get; set; }

### internal interface UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService

#### Methods
- public void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed)
- public void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished)
- public UnityEngine.Purchasing.Interfaces.IGooglePurchase GetPurchase(string purchaseToken, string skuType)
- public bool IsConnectionReady()
- public void Purchase(UnityEngine.Purchasing.ProductDefinition product)
- public void Purchase(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayReplacementMode> desiredReplacementMode)
- public void ResumeConnection()
- public void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductFailed)
- public void SetMaxConnectionAttempts(int maxConnectionAttempts)
- public void SetObfuscatedAccountId(string obfuscatedAccountId)
- public void SetObfuscatedProfileId(string obfuscatedProfileId)

### internal interface UnityEngine.Purchasing.Interfaces.IGoogleProductCallback

#### Methods
- public void NotifyQueryProductDetailsFailed(int retryCount)
- public void SetStoreConfiguration(UnityEngine.Purchasing.IGooglePlayConfigurationInternal configuration)

### internal interface UnityEngine.Purchasing.Interfaces.IGooglePurchase

#### Properties
- public string obfuscatedAccountId { get; }
- public string obfuscatedProfileId { get; }
- public string orderId { get; }
- public string originalJson { get; }
- public int purchaseState { get; }
- public string purchaseToken { get; }
- public string receipt { get; }
- public string signature { get; }
- public string sku { get; }
- public System.Collections.Generic.List<string> skus { get; }

#### Methods
- public bool IsAcknowledged()
- public bool IsPending()
- public bool IsPurchased()

### internal interface UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder

#### Methods
- public UnityEngine.Purchasing.Interfaces.IGooglePurchase BuildPurchase(UnityEngine.AndroidJavaObject purchase)
- public System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> BuildPurchases(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> purchases)

### internal interface UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback

#### Methods
- public void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku)
- public void NotifyDeferredPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string purchaseToken)
- public void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription purchaseFailureDescription)
- public void OnPurchaseSuccessful(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string purchaseToken)
- public void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback)
- public void SetStoreConfiguration(UnityEngine.Purchasing.IGooglePlayConfigurationInternal configuration)

### internal interface UnityEngine.Purchasing.Interfaces.IGooglePurchaseService

#### Methods
- public void Purchase(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayReplacementMode> desiredReplacementMode)

### internal interface UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider

#### Methods
- public int Pending()
- public int Purchased()

### internal interface UnityEngine.Purchasing.Interfaces.IGooglePurchaseUpdatedListener

### internal interface UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService

#### Methods
- public UnityEngine.Purchasing.Interfaces.IGooglePurchase GetPurchaseByToken(string token, string skuType)
- public System.Threading.Tasks.Task<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchases()

### internal interface UnityEngine.Purchasing.Interfaces.IProductDetailsConverter

#### Methods
- public System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> ConvertOnQueryProductDetailsResponse(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails)

### internal interface UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse

#### Methods
- public void AddResponse(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails)
- public UnityEngine.Purchasing.Models.IGoogleBillingResult GetGoogleBillingResult()
- public bool IsRecoverable()
- public System.Collections.Generic.List<UnityEngine.AndroidJavaObject> ProductDetails()

### internal interface UnityEngine.Purchasing.Interfaces.IProductDetailsResponseConsolidator

#### Methods
- public void Consolidate(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails)

### internal interface UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService

#### Methods
- public void QueryAsyncProduct(UnityEngine.Purchasing.ProductDefinition product, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse)
- public void QueryAsyncProduct(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse)
- public void QueryAsyncProduct(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse)

## Namespace: UnityEngine.Purchasing.Models

### private class UnityEngine.Purchasing.Models.GooglePurchase.<>c

#### Fields
- public static readonly UnityEngine.Purchasing.Models.GooglePurchase.<>c <>9
- public static System.Func<UnityEngine.AndroidJavaObject, string> <>9__32_0

#### Constructors
- private static GooglePurchase.<>c()
- public GooglePurchase.<>c()

#### Methods
- internal string <.ctor>b__32_0(UnityEngine.AndroidJavaObject productDetails)

### private class UnityEngine.Purchasing.Models.AndroidJavaObjectExtensions.<>c__DisplayClass0_0<T>

#### Fields
- public UnityEngine.AndroidJavaObject androidJavaList

#### Constructors
- public AndroidJavaObjectExtensions.<>c__DisplayClass0_0<T>()

#### Methods
- internal T <Enumerate>b__0(int i)

### private class UnityEngine.Purchasing.Models.GoogleBillingClient.<>c__DisplayClass39_0

#### Fields
- public string type

#### Constructors
- public GoogleBillingClient.<>c__DisplayClass39_0()

#### Methods
- internal UnityEngine.AndroidJavaObject <QueryProductDetailsParamsProductList>b__0(string product)

### internal static class UnityEngine.Purchasing.Models.AndroidJavaObjectExtensions

#### Methods
- internal static System.Collections.Generic.IEnumerable<T> Enumerate<T>(UnityEngine.AndroidJavaObject androidJavaList)
- internal static System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> Enumerate(UnityEngine.AndroidJavaObject androidJavaList)

### internal class UnityEngine.Purchasing.Models.GoogleBillingClient
- Interfaces: UnityEngine.Purchasing.Interfaces.IGoogleBillingClient

#### Fields
- private static const string k_AndroidAcknowledgePurchaseParamsClassName
- private static const string k_AndroidBillingClientClassName
- private static const string k_AndroidBillingFlowParamClassName
- private static const string k_AndroidConsumeParamsClassName
- private static const string k_AndroidProductClassName
- private static const string k_AndroidProductDetailsParamsClassName
- private static const string k_AndroidQueryProductDetailsParamsClassName
- private static const string k_AndroidSubscriptionUpdateParamClassName
- private readonly UnityEngine.AndroidJavaObject m_BillingClient
- private string m_ObfuscatedAccountId
- private string m_ObfuscatedProfileId
- private readonly UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics
- private readonly Uniject.IUtil m_Util
- private static UnityEngine.AndroidJavaClass s_AcknowledgePurchaseParamsClass
- private static UnityEngine.AndroidJavaClass s_AndroidProductClassName
- private static UnityEngine.AndroidJavaClass s_AndroidQueryProductDetailsParamsClassName
- private static UnityEngine.AndroidJavaClass s_BillingClientClass
- private static UnityEngine.AndroidJavaClass s_BillingFlowParamsClass
- private static UnityEngine.AndroidJavaClass s_ConsumeParamsClass
- private static UnityEngine.AndroidJavaClass s_ProductDetailsParamsClass
- private static UnityEngine.AndroidJavaClass s_SubscriptionUpdateParamsClass

#### Constructors
- internal GoogleBillingClient(UnityEngine.Purchasing.Interfaces.IGooglePurchaseUpdatedListener googlePurchaseUpdatedListener, Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics)

#### Methods
- public void AcknowledgePurchase(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledge)
- private static UnityEngine.AndroidJavaObject BuildSubscriptionUpdateParams(string oldPurchaseToken, UnityEngine.Purchasing.GooglePlayReplacementMode replacementMode)
- public void ConsumeAsync(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsume)
- public void EndConnection()
- private static UnityEngine.AndroidJavaClass GetAcknowledgePurchaseParamsClass()
- private static UnityEngine.AndroidJavaClass GetBillingClientClass()
- private static UnityEngine.AndroidJavaClass GetBillingFlowParamClass()
- public UnityEngine.Purchasing.GoogleBillingConnectionState GetConnectionState()
- private static UnityEngine.AndroidJavaClass GetConsumeParamsClass()
- private static UnityEngine.AndroidJavaClass GetProductDetailsParamsClass()
- private static UnityEngine.AndroidJavaClass GetProductParamsClass()
- private static UnityEngine.AndroidJavaClass GetQueryProductDetailsParamsParamsClass()
- private static UnityEngine.AndroidJavaClass GetSubscriptionUpdateParamClass()
- public bool IsReady()
- public UnityEngine.AndroidJavaObject LaunchBillingFlow(UnityEngine.AndroidJavaObject productDetails, string oldPurchaseToken, System.Nullable<UnityEngine.Purchasing.GooglePlayReplacementMode> replacementMode)
- private UnityEngine.AndroidJavaObject MakeBillingFlowParams(UnityEngine.AndroidJavaObject productDetailsParamsList, string oldPurchaseToken, System.Nullable<UnityEngine.Purchasing.GooglePlayReplacementMode> replacementMode)
- public void QueryProductDetailsAsync(System.Collections.Generic.List<string> products, string type, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onProductDetailsResponseAction)
- private static UnityEngine.AndroidJavaObject QueryProductDetailsParams(System.Collections.Generic.List<string> products, string type)
- private static UnityEngine.AndroidJavaObject QueryProductDetailsParamsProduct(string type, string product)
- private static UnityEngine.AndroidJavaObject QueryProductDetailsParamsProductList(System.Collections.Generic.List<string> products, string type)
- public void QueryPurchasesAsync(string skuType, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> onQueryPurchasesResponse)
- private UnityEngine.AndroidJavaObject SetObfuscatedAccountIdIfNeeded(UnityEngine.AndroidJavaObject billingFlowParams)
- private UnityEngine.AndroidJavaObject SetObfuscatedProfileIdIfNeeded(UnityEngine.AndroidJavaObject billingFlowParams)
- public void SetObfuscationAccountId(string obfuscationAccountId)
- public void SetObfuscationProfileId(string obfuscationProfileId)
- public void StartConnection(UnityEngine.Purchasing.Interfaces.IBillingClientStateListener billingClientStateListener)

### internal enum UnityEngine.Purchasing.Models.GoogleBillingResponseCode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BillingUnavailable = 3
- DeveloperError = 5
- FatalError = 6
- FeatureNotSupported = -2
- ItemAlreadyOwned = 7
- ItemNotOwned = 8
- ItemUnavailable = 4
- NetworkError = 12
- Ok = 0
- ServiceDisconnected = -1
- ServiceTimeout = -3
- ServiceUnavailable = 2
- UserCanceled = 1

### internal class UnityEngine.Purchasing.Models.GoogleBillingResult
- Interfaces: UnityEngine.Purchasing.Models.IGoogleBillingResult

#### Fields
- private readonly string <debugMessage>k__BackingField
- private readonly UnityEngine.Purchasing.Models.GoogleBillingResponseCode <responseCode>k__BackingField

#### Properties
- public string debugMessage { get; }
- public UnityEngine.Purchasing.Models.GoogleBillingResponseCode responseCode { get; }

#### Constructors
- internal GoogleBillingResult(UnityEngine.AndroidJavaObject billingResult)

### internal static class UnityEngine.Purchasing.Models.GoogleBillingStrings

#### Fields
- internal static const string errorItemAlreadyOwned
- internal static const string errorPurchaseStateUnspecified
- internal static const string errorUserCancelled

#### Methods
- internal static string getWarningMessageMoreThanOneSkuFound(string sku)

### internal static class UnityEngine.Purchasing.Models.GoogleProductTypeEnum

#### Methods
- internal static string InApp()
- internal static string Sub()

### internal class UnityEngine.Purchasing.Models.GooglePurchase
- Interfaces: UnityEngine.Purchasing.Interfaces.IGooglePurchase

#### Fields
- private readonly bool <isAcknowledged>k__BackingField
- private readonly string <obfuscatedAccountId>k__BackingField
- private readonly string <obfuscatedProfileId>k__BackingField
- private readonly string <orderId>k__BackingField
- private readonly string <originalJson>k__BackingField
- private readonly int <purchaseState>k__BackingField
- private readonly string <purchaseToken>k__BackingField
- private readonly string <receipt>k__BackingField
- private readonly string <signature>k__BackingField
- private readonly System.Collections.Generic.List<string> <skus>k__BackingField

#### Properties
- public bool isAcknowledged { get; }
- public string obfuscatedAccountId { get; }
- public string obfuscatedProfileId { get; }
- public string orderId { get; }
- public string originalJson { get; }
- public int purchaseState { get; }
- public string purchaseToken { get; }
- public string receipt { get; }
- public string signature { get; }
- public string sku { get; }
- public System.Collections.Generic.List<string> skus { get; }

#### Constructors
- internal GooglePurchase(UnityEngine.AndroidJavaObject purchase, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetailsEnum)

#### Methods
- public virtual bool IsAcknowledged()
- public virtual bool IsPending()
- public virtual bool IsPurchased()

### internal static class UnityEngine.Purchasing.Models.GooglePurchaseStateEnum

#### Fields
- private static const string k_AndroidPurchaseStateClassName
- private static System.Nullable<int> s_Pending
- private static System.Nullable<int> s_Purchased

#### Methods
- private static UnityEngine.AndroidJavaObject GetPurchaseStateJavaObject()
- internal static int Pending()
- internal static int Purchased()

### internal class UnityEngine.Purchasing.Models.GooglePurchaseStateEnumProvider
- Interfaces: UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider

#### Constructors
- public GooglePurchaseStateEnumProvider()

#### Methods
- public int Pending()
- public int Purchased()

### internal enum UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BillingServiceDisconnected = 0
- BillingServiceUnavailable = 1

### internal interface UnityEngine.Purchasing.Models.IGoogleBillingResult

#### Properties
- public string debugMessage { get; }
- public UnityEngine.Purchasing.Models.GoogleBillingResponseCode responseCode { get; }

### internal class UnityEngine.Purchasing.Models.ProductDescriptionQuery

#### Fields
- internal System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived
- internal System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed
- internal System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products

#### Constructors
- internal ProductDescriptionQuery(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed)

## Namespace: UnityEngine.Purchasing.Registration

### private class UnityEngine.Purchasing.Registration.IapCoreInitializeCallback.<>c__DisplayClass2_0

#### Fields
- public UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper diagnosticsInstanceWrapper
- public UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper metricsInstanceWrapper
- public Unity.Services.Core.Internal.CoreRegistry registry

#### Constructors
- public IapCoreInitializeCallback.<>c__DisplayClass2_0()

#### Methods
- internal void <Initialize>b__0()

### internal class UnityEngine.Purchasing.Registration.IapCoreInitializeCallback
- Interfaces: Unity.Services.Core.Internal.IInitializablePackage

#### Fields
- private static const string k_PurchasingPackageName

#### Constructors
- public IapCoreInitializeCallback()

#### Methods
- private static void CacheInitializedEnvironment(Unity.Services.Core.Internal.CoreRegistry registry)
- private static string GetCurrentEnvironment(Unity.Services.Core.Internal.CoreRegistry registry)
- public System.Threading.Tasks.Task Initialize(Unity.Services.Core.Internal.CoreRegistry registry)
- private static void InitializeTelemetryComponents(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper metricsInstanceWrapper, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper diagnosticsInstanceWrapper)
- private static void Register()

## Namespace: UnityEngine.Purchasing.Stores.Util

### internal interface UnityEngine.Purchasing.Stores.Util.IRetryPolicy

#### Methods
- public void Invoke(System.Action<System.Action> actionToTry, System.Action onRetryAction = null)

## Namespace: UnityEngine.Purchasing.Utils

### private class UnityEngine.Purchasing.Utils.GooglePurchaseBuilder.<>c__DisplayClass6_0

#### Fields
- public System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails

#### Constructors
- public GooglePurchaseBuilder.<>c__DisplayClass6_0()

#### Methods
- internal UnityEngine.AndroidJavaObject <TryFindAllProductDetails>b__0(string sku)

### private class UnityEngine.Purchasing.Utils.GooglePurchaseBuilder.<>c__DisplayClass6_1

#### Fields
- public string sku

#### Constructors
- public GooglePurchaseBuilder.<>c__DisplayClass6_1()

#### Methods
- internal bool <TryFindAllProductDetails>b__1(UnityEngine.AndroidJavaObject productDetail)

### internal class UnityEngine.Purchasing.Utils.GooglePurchaseBuilder
- Interfaces: UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder

#### Fields
- private readonly UnityEngine.Purchasing.IGoogleCachedQueryProductDetailsService m_CachedQueryProductDetailsService
- private readonly UnityEngine.ILogger m_Logger

#### Constructors
- public GooglePurchaseBuilder(UnityEngine.Purchasing.IGoogleCachedQueryProductDetailsService cachedQueryProductDetailsService, UnityEngine.ILogger logger)

#### Methods
- public UnityEngine.Purchasing.Interfaces.IGooglePurchase BuildPurchase(UnityEngine.AndroidJavaObject purchase)
- public System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> BuildPurchases(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> purchases)
- private void LogWarningForException(System.Exception exception)
- private static System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> TryFindAllProductDetails(System.Collections.Generic.IEnumerable<string> skus, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails)

### internal static class UnityEngine.Purchasing.Utils.GoogleReceiptEncoder

#### Methods
- internal static string EncodeReceipt(string purchaseOriginalJson, string purchaseSignature, System.Collections.Generic.List<string> productDetailsJson)

### internal class UnityEngine.Purchasing.Utils.ProductDetailsConverter
- Interfaces: UnityEngine.Purchasing.Interfaces.IProductDetailsConverter

#### Constructors
- public ProductDetailsConverter()

#### Methods
- internal static UnityEngine.Purchasing.Extension.ProductDescription BuildProductDescription(UnityEngine.AndroidJavaObject productDetails)
- public System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> ConvertOnQueryProductDetailsResponse(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails)
- private static UnityEngine.Purchasing.Extension.ProductDescription ToProductDescription(UnityEngine.AndroidJavaObject productDetails)

