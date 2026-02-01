# Assembly: UnityEngine.Purchasing.AppleStub
- Path: tools/WorldBox.Managed/UnityEngine.Purchasing.AppleStub.dll
- Types: 6

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 3DE23A9D551E5FCDFE592B0AC0DB74867A5035D24F72440C324BE8C373F4C1E1
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=95 4BF49334782FF315370333CC1291A2842A42AEFF00041D3B8525FE73FFC67278

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=95

## Namespace: UnityEngine.Purchasing

### internal class UnityEngine.Purchasing.iOSStoreBindings
- Interfaces: UnityEngine.Purchasing.INativeAppleStore, UnityEngine.Purchasing.INativeStore

#### Properties
- public string appReceipt { get; }
- public double appReceiptModificationDate { get; }
- public bool canMakePayments { get; }
- public bool simulateAskToBuy { get; set; }

#### Constructors
- public iOSStoreBindings()

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

