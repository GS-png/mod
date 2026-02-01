# Assembly: UnityEngine.Purchasing.SecurityStub
- Path: tools/WorldBox.Managed/UnityEngine.Purchasing.SecurityStub.dll
- Types: 11

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=391 495AB271A5EF299C8D72709662A5D175A555BF55455A8D743EEA13C74B933C29
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=266 532BB52D86E8297A9516627C1DFDB3601339798147DC1B77332B7FB071D9390C

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=266

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=391

## Namespace: UnityEngine.Purchasing.Security

### public class UnityEngine.Purchasing.Security.AppleReceiptParser

#### Constructors
- public AppleReceiptParser()

#### Methods
- public UnityEngine.Purchasing.Security.AppleReceipt Parse(byte[] receiptData)

### public class UnityEngine.Purchasing.Security.AppleValidator

#### Constructors
- public AppleValidator(byte[] appleRootCertificate)

#### Methods
- public UnityEngine.Purchasing.Security.AppleReceipt Validate(byte[] receiptData)

### public class UnityEngine.Purchasing.Security.CrossPlatformValidator

#### Constructors
- public CrossPlatformValidator(byte[] googlePublicKey, byte[] appleRootCert, string appBundleId)
- public CrossPlatformValidator(byte[] googlePublicKey, byte[] appleRootCert, string googleBundleId, string appleBundleId)

#### Methods
- public UnityEngine.Purchasing.Security.IPurchaseReceipt[] Validate(string unityIAPReceipt)

### public class UnityEngine.Purchasing.Security.GooglePlayReceipt
- Interfaces: UnityEngine.Purchasing.Security.IPurchaseReceipt

#### Fields
- private string <orderID>k__BackingField
- private string <packageName>k__BackingField
- private string <productID>k__BackingField
- private System.DateTime <purchaseDate>k__BackingField
- private UnityEngine.Purchasing.Security.GooglePurchaseState <purchaseState>k__BackingField
- private string <purchaseToken>k__BackingField

#### Properties
- public string orderID { get; private set; }
- public string packageName { get; private set; }
- public string productID { get; private set; }
- public System.DateTime purchaseDate { get; private set; }
- public UnityEngine.Purchasing.Security.GooglePurchaseState purchaseState { get; private set; }
- public string purchaseToken { get; private set; }
- public string transactionID { get; }

#### Constructors
- public GooglePlayReceipt(string productID, string orderID, string packageName, string purchaseToken, System.DateTime purchaseTime, UnityEngine.Purchasing.Security.GooglePurchaseState purchaseState)

### public enum UnityEngine.Purchasing.Security.GooglePurchaseState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Cancelled = 1
- Deferred = 4
- Purchased = 0
- Refunded = 2

### public static class UnityEngine.Purchasing.Security.Obfuscator

#### Methods
- public static byte[] DeObfuscate(byte[] data, int[] order, int key)

