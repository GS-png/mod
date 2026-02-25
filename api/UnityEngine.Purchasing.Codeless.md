# Assembly: UnityEngine.Purchasing.Codeless
- Path: tools/WorldBox.Managed/UnityEngine.Purchasing.Codeless.dll
- Types: 29

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=983 06EC90FD14012FF7EE56731E1183BB9FCB20BF0021D289408D790FAB92DCCCBF
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=564 B24B0C3DFEC35343AF1EE3F852CDCF9E0859EFE1FD36D1204966677EED99ADD5

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=564

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=983

## Namespace: UnityEngine.Purchasing

### private class UnityEngine.Purchasing.CodelessIAPStoreListener.<>c__DisplayClass31_0

#### Fields
- public System.Func<UnityEngine.Purchasing.IAPButton, bool> <>9__0
- public System.Func<UnityEngine.Purchasing.CodelessIAPButton, bool> <>9__1
- public string productID

#### Constructors
- public CodelessIAPStoreListener.<>c__DisplayClass31_0()

#### Methods
- internal bool <SendPurchaseFailedEventsToAllButtons>b__0(UnityEngine.Purchasing.IAPButton button)
- internal bool <SendPurchaseFailedEventsToAllButtons>b__1(UnityEngine.Purchasing.CodelessIAPButton button)

### private class UnityEngine.Purchasing.CodelessIAPStoreListener.<>c__DisplayClass36_0

#### Fields
- public System.Func<UnityEngine.Purchasing.IAPButton, bool> <>9__0
- public System.Func<UnityEngine.Purchasing.CodelessIAPButton, bool> <>9__1
- public UnityEngine.Purchasing.PurchaseEventArgs e

#### Constructors
- public CodelessIAPStoreListener.<>c__DisplayClass36_0()

#### Methods
- internal bool <ProcessPurchase>b__0(UnityEngine.Purchasing.IAPButton button)
- internal bool <ProcessPurchase>b__1(UnityEngine.Purchasing.CodelessIAPButton button)

### private class UnityEngine.Purchasing.CodelessIAPStoreListener.<>c__DisplayClass37_0

#### Fields
- public System.Func<UnityEngine.Purchasing.IAPButton, bool> <>9__1
- public UnityEngine.Purchasing.Product product

#### Constructors
- public CodelessIAPStoreListener.<>c__DisplayClass37_0()

#### Methods
- internal bool <OnPurchaseFailed>b__0(UnityEngine.Purchasing.CodelessIAPButton button)
- internal bool <OnPurchaseFailed>b__1(UnityEngine.Purchasing.IAPButton button)

### private class UnityEngine.Purchasing.CodelessIAPStoreListener.<>c__DisplayClass38_0

#### Fields
- public System.Func<UnityEngine.Purchasing.CodelessIAPButton, bool> <>9__0
- public UnityEngine.Purchasing.Product product

#### Constructors
- public CodelessIAPStoreListener.<>c__DisplayClass38_0()

#### Methods
- internal bool <OnPurchaseFailed>b__0(UnityEngine.Purchasing.CodelessIAPButton button)

### private struct UnityEngine.Purchasing.CodelessIAPStoreListener.<CreateCodelessIAPStoreListenerInstance>d__17
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### public class UnityEngine.Purchasing.BaseIAPButton
- Base: UnityEngine.MonoBehaviour

#### Constructors
- protected BaseIAPButton()

#### Methods
- protected abstract void AddButtonToCodelessListener()
- internal abstract string GetProductId()
- protected abstract UnityEngine.UI.Button GetPurchaseButton()
- internal abstract bool IsAPurchaseButton()
- protected abstract bool IsARestoreButton()
- private void OnDisable()
- private void OnEnable()
- internal abstract void OnInitCompleted()
- protected abstract void OnPurchaseComplete(UnityEngine.Purchasing.Product purchasedProduct)
- protected abstract void OnTransactionsRestored(bool success, string error)
- protected UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchaseInternal(UnityEngine.Purchasing.PurchaseEventArgs args)
- private void PurchaseProduct()
- protected abstract void RemoveButtonToCodelessListener()
- private void Restore()
- protected abstract bool ShouldConsumePurchase()
- private void Start()

### public enum UnityEngine.Purchasing.IAPButton.ButtonType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Purchase = 0
- Restore = 1

### public enum UnityEngine.Purchasing.CodelessButtonType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Purchase = 0
- Restore = 1

### public class UnityEngine.Purchasing.CodelessIAPButton
- Base: UnityEngine.Purchasing.BaseIAPButton

#### Fields
- public UnityEngine.UI.Button button
- public UnityEngine.Purchasing.CodelessButtonType buttonType
- public bool consumePurchase
- public UnityEngine.Purchasing.CodelessIAPButton.OnProductFetchedEvent onProductFetched
- public UnityEngine.Purchasing.CodelessIAPButton.OnPurchaseCompletedEvent onPurchaseComplete
- public UnityEngine.Purchasing.CodelessIAPButton.OnPurchaseFailedEvent onPurchaseFailed
- public UnityEngine.Purchasing.CodelessIAPButton.OnTransactionsRestoredEvent onTransactionsRestored
- public string productId

#### Constructors
- public CodelessIAPButton()

#### Methods
- protected override void AddButtonToCodelessListener()
- internal override string GetProductId()
- protected override UnityEngine.UI.Button GetPurchaseButton()
- internal override bool IsAPurchaseButton()
- protected override bool IsARestoreButton()
- internal override void OnInitCompleted()
- protected override void OnPurchaseComplete(UnityEngine.Purchasing.Product purchasedProduct)
- public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription failureDescription)
- protected override void OnTransactionsRestored(bool success, string error)
- public UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs args)
- protected override void RemoveButtonToCodelessListener()
- protected override bool ShouldConsumePurchase()

### public class UnityEngine.Purchasing.CodelessIAPStoreListener
- Interfaces: UnityEngine.Purchasing.IDetailedStoreListener, UnityEngine.Purchasing.IStoreListener

#### Fields
- private readonly System.Collections.Generic.List<UnityEngine.Purchasing.IAPButton> activeButtons
- private readonly System.Collections.Generic.List<UnityEngine.Purchasing.CodelessIAPButton> activeCodelessButtons
- private readonly System.Collections.Generic.List<UnityEngine.Purchasing.IAPListener> activeListeners
- protected UnityEngine.Purchasing.ProductCatalog catalog
- protected UnityEngine.Purchasing.IStoreController controller
- protected UnityEngine.Purchasing.IExtensionProvider extensions
- public static bool initializationComplete
- private static UnityEngine.Purchasing.CodelessIAPStoreListener instance
- private UnityEngine.Purchasing.ConfigurationBuilder m_Builder
- private static bool unityPurchasingInitialized

#### Properties
- public static UnityEngine.Purchasing.CodelessIAPStoreListener Instance { get; }
- public UnityEngine.Purchasing.IStoreController StoreController { get; }

#### Constructors
- private CodelessIAPStoreListener()

#### Methods
- public void AddButton(UnityEngine.Purchasing.IAPButton button)
- public void AddButton(UnityEngine.Purchasing.CodelessIAPButton button)
- public void AddListener(UnityEngine.Purchasing.IAPListener listener)
- private static System.Threading.Tasks.Task AutoInitializeUnityGamingServicesIfEnabled()
- private static void CreateCodelessIAPStoreListenerInstance()
- public UnityEngine.Purchasing.Product GetProduct(string productID)
- public T GetStoreConfiguration<T>()
- public T GetStoreExtensions<T>()
- private void HandleOnInitForAllButtons()
- public bool HasProductInCatalog(string productID)
- private static void InitializeCodelessPurchasingOnLoad()
- private static void InitializePurchasing()
- public void InitiatePurchase(string productID)
- public void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions)
- public void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error)
- public void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error, string message)
- public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason reason)
- public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription description)
- public UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e)
- public void RemoveButton(UnityEngine.Purchasing.IAPButton button)
- public void RemoveButton(UnityEngine.Purchasing.CodelessIAPButton button)
- public void RemoveListener(UnityEngine.Purchasing.IAPListener listener)
- private void SendPurchaseFailedEventsToAllButtons(string productID)
- private static bool ShouldAutoInitUgs()

### public class UnityEngine.Purchasing.IAPButton
- Base: UnityEngine.Purchasing.BaseIAPButton

#### Fields
- public UnityEngine.Purchasing.IAPButton.ButtonType buttonType
- public bool consumePurchase
- public UnityEngine.UI.Text descriptionText
- public UnityEngine.Purchasing.IAPButton.OnPurchaseCompletedEvent onPurchaseComplete
- public UnityEngine.Purchasing.IAPButton.OnPurchaseFailedEvent onPurchaseFailed
- public UnityEngine.Purchasing.IAPButton.OnTransactionsRestoredEvent onTransactionsRestored
- public UnityEngine.UI.Text priceText
- public string productId
- public UnityEngine.UI.Text titleText

#### Constructors
- public IAPButton()

#### Methods
- protected override void AddButtonToCodelessListener()
- internal override string GetProductId()
- protected override UnityEngine.UI.Button GetPurchaseButton()
- internal override bool IsAPurchaseButton()
- protected override bool IsARestoreButton()
- internal override void OnInitCompleted()
- protected override void OnPurchaseComplete(UnityEngine.Purchasing.Product purchasedProduct)
- public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason reason)
- protected override void OnTransactionsRestored(bool success, string error)
- public UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e)
- protected override void RemoveButtonToCodelessListener()
- protected override bool ShouldConsumePurchase()
- private void UpdateAllTexts()

### public static class UnityEngine.Purchasing.IAPConfigurationHelper

#### Methods
- public static void PopulateConfigurationBuilder(ref UnityEngine.Purchasing.ConfigurationBuilder builder, UnityEngine.Purchasing.ProductCatalog catalog)

### public class UnityEngine.Purchasing.IAPListener
- Base: UnityEngine.MonoBehaviour

#### Fields
- public bool consumePurchase
- public bool dontDestroyOnLoad
- public UnityEngine.Purchasing.IAPListener.OnProductsFetchedEvent onProductsFetched
- public UnityEngine.Purchasing.IAPListener.OnPurchaseCompletedEvent onPurchaseComplete
- public UnityEngine.Purchasing.IAPListener.OnPurchaseDetailedFailedEvent onPurchaseDetailedFailedEvent
- public UnityEngine.Purchasing.IAPListener.OnPurchaseFailedEvent onPurchaseFailed

#### Constructors
- public IAPListener()

#### Methods
- private void OnDisable()
- private void OnEnable()
- public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason reason)
- public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription description)
- public UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e)

### public class UnityEngine.Purchasing.CodelessIAPButton.OnProductFetchedEvent
- Base: UnityEngine.Events.UnityEvent<UnityEngine.Purchasing.Product>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public CodelessIAPButton.OnProductFetchedEvent()

### public class UnityEngine.Purchasing.IAPListener.OnProductsFetchedEvent
- Base: UnityEngine.Events.UnityEvent<UnityEngine.Purchasing.ProductCollection>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public IAPListener.OnProductsFetchedEvent()

### public class UnityEngine.Purchasing.CodelessIAPButton.OnPurchaseCompletedEvent
- Base: UnityEngine.Events.UnityEvent<UnityEngine.Purchasing.Product>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public CodelessIAPButton.OnPurchaseCompletedEvent()

### public class UnityEngine.Purchasing.IAPButton.OnPurchaseCompletedEvent
- Base: UnityEngine.Events.UnityEvent<UnityEngine.Purchasing.Product>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public IAPButton.OnPurchaseCompletedEvent()

### public class UnityEngine.Purchasing.IAPListener.OnPurchaseCompletedEvent
- Base: UnityEngine.Events.UnityEvent<UnityEngine.Purchasing.Product>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public IAPListener.OnPurchaseCompletedEvent()

### public class UnityEngine.Purchasing.IAPListener.OnPurchaseDetailedFailedEvent
- Base: UnityEngine.Events.UnityEvent<UnityEngine.Purchasing.Product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public IAPListener.OnPurchaseDetailedFailedEvent()

### public class UnityEngine.Purchasing.CodelessIAPButton.OnPurchaseFailedEvent
- Base: UnityEngine.Events.UnityEvent<UnityEngine.Purchasing.Product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public CodelessIAPButton.OnPurchaseFailedEvent()

### public class UnityEngine.Purchasing.IAPButton.OnPurchaseFailedEvent
- Base: UnityEngine.Events.UnityEvent<UnityEngine.Purchasing.Product, UnityEngine.Purchasing.PurchaseFailureReason>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public IAPButton.OnPurchaseFailedEvent()

### public class UnityEngine.Purchasing.IAPListener.OnPurchaseFailedEvent
- Base: UnityEngine.Events.UnityEvent<UnityEngine.Purchasing.Product, UnityEngine.Purchasing.PurchaseFailureReason>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public IAPListener.OnPurchaseFailedEvent()

### public class UnityEngine.Purchasing.CodelessIAPButton.OnTransactionsRestoredEvent
- Base: UnityEngine.Events.UnityEvent<bool, string>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public CodelessIAPButton.OnTransactionsRestoredEvent()

### public class UnityEngine.Purchasing.IAPButton.OnTransactionsRestoredEvent
- Base: UnityEngine.Events.UnityEvent<bool, string>
- Interfaces: UnityEngine.ISerializationCallbackReceiver

#### Constructors
- public IAPButton.OnTransactionsRestoredEvent()

