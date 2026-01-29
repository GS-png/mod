# Assembly: UnityEngine.Purchasing.AppleMacosStub
- Path: tools/WorldBox.Managed/UnityEngine.Purchasing.AppleMacosStub.dll
- Types: 6

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=100 2BD017E3CA565BB53D264868DFB41589DF93D0AE83D6265AA4513255BB2EBB5C
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 52A14700EE4BEAA94AEE5E43BE57B506877027BFAF593F70FFD06758308B72F4

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=100

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44

## Namespace: UnityEngine.Purchasing

### internal class UnityEngine.Purchasing.OSXStoreBindings
- Interfaces: UnityEngine.Purchasing.INativeAppleStore, UnityEngine.Purchasing.INativeStore

#### Properties
- public string appReceipt { get; }
- public double appReceiptModificationDate { get; }
- public bool canMakePayments { get; }
- public bool simulateAskToBuy { get; set; }

#### Constructors
- public OSXStoreBindings()

#### Methods
- public void AddTransactionObserver()
- public void ContinuePromotionalPurchases()
- public void FetchStorePromotionOrder()
- public void FetchStorePromotionVisibility(string productId)
- public void FinishTransaction(string productJSON, string transactionID)
- public string GetTransactionReceiptForProductId(string productId)
- public void InterceptPromotionalPurchases()
- public void PresentCodeRedemptionSheet()
- public void Purchase(string productJSON, string developerPayload)
- public void RefreshAppReceipt()
- public void RestoreTransactions()
- public void RetrieveProducts(string json)
- public void SetApplicationUsername(string applicationUsername)
- public void SetStorePromotionOrder(string json)
- public void SetStorePromotionVisibility(string productId, string visibility)
- public void SetUnityPurchasingCallback(UnityEngine.Purchasing.UnityPurchasingCallback AsyncCallback)

