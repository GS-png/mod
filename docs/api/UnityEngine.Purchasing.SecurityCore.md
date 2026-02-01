# Assembly: UnityEngine.Purchasing.SecurityCore
- Path: tools/WorldBox.Managed/UnityEngine.Purchasing.SecurityCore.dll
- Types: 10

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=294 957744B9CED4C5AB350296770CA60457128370E266BFB0E997B56E2EF00D7A0D
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=283 BC3FC242FC6CCCB13858FA4EDEE758D61612D9D88A5133499FFA738034FF9C21

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=283

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=294

## Namespace: UnityEngine.Purchasing.Security

### public class UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt
- Interfaces: UnityEngine.Purchasing.Security.IPurchaseReceipt

#### Fields
- private System.DateTime <cancellationDate>k__BackingField
- private int <isFreeTrial>k__BackingField
- private int <isIntroductoryPricePeriod>k__BackingField
- private System.DateTime <originalPurchaseDate>k__BackingField
- private string <originalTransactionIdentifier>k__BackingField
- private string <productID>k__BackingField
- private int <productType>k__BackingField
- private System.DateTime <purchaseDate>k__BackingField
- private int <quantity>k__BackingField
- private System.DateTime <subscriptionExpirationDate>k__BackingField
- private string <transactionID>k__BackingField

#### Properties
- public System.DateTime cancellationDate { get; internal set; }
- public int isFreeTrial { get; internal set; }
- public int isIntroductoryPricePeriod { get; internal set; }
- public System.DateTime originalPurchaseDate { get; internal set; }
- public string originalTransactionIdentifier { get; internal set; }
- public string productID { get; internal set; }
- public int productType { get; internal set; }
- public System.DateTime purchaseDate { get; internal set; }
- public int quantity { get; internal set; }
- public System.DateTime subscriptionExpirationDate { get; internal set; }
- public string transactionID { get; internal set; }

#### Constructors
- public AppleInAppPurchaseReceipt()

### public class UnityEngine.Purchasing.Security.AppleReceipt

#### Fields
- private string <appVersion>k__BackingField
- private string <bundleID>k__BackingField
- private System.DateTime <expirationDate>k__BackingField
- private byte[] <hash>k__BackingField
- private byte[] <opaque>k__BackingField
- private string <originalApplicationVersion>k__BackingField
- private System.DateTime <receiptCreationDate>k__BackingField
- public UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt[] inAppPurchaseReceipts

#### Properties
- public string appVersion { get; internal set; }
- public string bundleID { get; internal set; }
- public System.DateTime expirationDate { get; internal set; }
- public byte[] hash { get; internal set; }
- public byte[] opaque { get; internal set; }
- public string originalApplicationVersion { get; internal set; }
- public System.DateTime receiptCreationDate { get; internal set; }

#### Constructors
- public AppleReceipt()

### public class UnityEngine.Purchasing.Security.IAPSecurityException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public IAPSecurityException()
- public IAPSecurityException(string message)

### public class UnityEngine.Purchasing.Security.InvalidSignatureException
- Base: UnityEngine.Purchasing.Security.IAPSecurityException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public InvalidSignatureException()

### public interface UnityEngine.Purchasing.Security.IPurchaseReceipt

#### Properties
- public string productID { get; }
- public System.DateTime purchaseDate { get; }
- public string transactionID { get; }

