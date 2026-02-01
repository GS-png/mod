# Assembly: UnityEngine.Purchasing.AppleCore
- Path: tools/WorldBox.Managed/UnityEngine.Purchasing.AppleCore.dll
- Types: 6

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=96 8203204887F54889CD0E0D4802510580C2D1D1C0BFF6EDE3865452618E2B6E44
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=45 BAD54347FDFD09227435A6BCFFDF61F856035D8ED2716B102C3972B477C88F67

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=45

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=96

## Namespace: UnityEngine.Purchasing

### internal interface UnityEngine.Purchasing.INativeAppleStore
- Interfaces: UnityEngine.Purchasing.INativeStore

#### Properties
- public string appReceipt { get; }
- public double appReceiptModificationDate { get; }
- public bool canMakePayments { get; }
- public bool simulateAskToBuy { get; set; }

#### Methods
- public void AddTransactionObserver()
- public void ContinuePromotionalPurchases()
- public void FetchStorePromotionOrder()
- public void FetchStorePromotionVisibility(string productId)
- public string GetTransactionReceiptForProductId(string productId)
- public void InterceptPromotionalPurchases()
- public void PresentCodeRedemptionSheet()
- public void RefreshAppReceipt()
- public void RestoreTransactions()
- public void SetApplicationUsername(string applicationUsername)
- public void SetStorePromotionOrder(string json)
- public void SetStorePromotionVisibility(string productId, string visibility)
- public void SetUnityPurchasingCallback(UnityEngine.Purchasing.UnityPurchasingCallback AsyncCallback)

