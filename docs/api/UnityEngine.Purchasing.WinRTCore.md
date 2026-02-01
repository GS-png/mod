# Assembly: UnityEngine.Purchasing.WinRTCore
- Path: tools/WorldBox.Managed/UnityEngine.Purchasing.WinRTCore.dll
- Types: 8

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=185 DD5079F0E306FBC79861B52CFA40B133FC018F39698AB7D4971B6F911A2B47AB
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=159 DE10C8266A47E52C6C11E4A2115CB45B08E8B8569532D335391BC6D5697469EA

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=159

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=185

## Namespace: UnityEngine.Purchasing.Default

### public interface UnityEngine.Purchasing.Default.IWindowsIAP

#### Methods
- public void BuildDummyProducts(System.Collections.Generic.List<UnityEngine.Purchasing.Default.WinProductDescription> products)
- public void FinaliseTransaction(string transactionId)
- public void Initialize(UnityEngine.Purchasing.Default.IWindowsIAPCallback callback)
- public void Purchase(string productId)
- public void RetrieveProducts(bool retryIfOffline)

### public interface UnityEngine.Purchasing.Default.IWindowsIAPCallback

#### Methods
- public void log(string message)
- public void logError(string error)
- public void OnProductListError(string message)
- public void OnProductListReceived(UnityEngine.Purchasing.Default.WinProductDescription[] winProducts)
- public void OnPurchaseFailed(string productId, string error)
- public void OnPurchaseSucceeded(string productId, string receipt, string transactionId)

### public class UnityEngine.Purchasing.Default.WinProductDescription

#### Fields
- private bool <consumable>k__BackingField
- private string <description>k__BackingField
- private string <ISOCurrencyCode>k__BackingField
- private string <platformSpecificID>k__BackingField
- private string <price>k__BackingField
- private decimal <priceDecimal>k__BackingField
- private string <receipt>k__BackingField
- private string <title>k__BackingField
- private string <transactionID>k__BackingField

#### Properties
- public bool consumable { get; private set; }
- public string description { get; private set; }
- public string ISOCurrencyCode { get; private set; }
- public string platformSpecificID { get; private set; }
- public string price { get; private set; }
- public decimal priceDecimal { get; private set; }
- public string receipt { get; private set; }
- public string title { get; private set; }
- public string transactionID { get; private set; }

#### Constructors
- public WinProductDescription(string id, string price, string title, string description, string isoCode, decimal priceD, string receipt = null, string transactionId = null, bool consumable = false)

