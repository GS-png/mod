# Assembly: System.ComponentModel.Composition
- Path: tools/WorldBox.Managed/System.ComponentModel.Composition.dll
- Types: 264

## Namespace: (global)

### internal static class Consts

#### Fields
- public static const string AssemblyCorlib
- public static const string AssemblyI18N
- public static const string AssemblyMicrosoft_JScript
- public static const string AssemblyMicrosoft_VisualStudio
- public static const string AssemblyMicrosoft_VisualStudio_Web
- public static const string AssemblyMicrosoft_VSDesigner
- public static const string AssemblyMono_Http
- public static const string AssemblyMono_Messaging_RabbitMQ
- public static const string AssemblyMono_Posix
- public static const string AssemblyMono_Security
- public static const string AssemblyPresentationCore_3_5
- public static const string AssemblyPresentationCore_4_0
- public static const string AssemblyPresentationFramework_3_5
- public static const string AssemblySystem
- public static const string AssemblySystemCore_3_5
- public static const string AssemblySystemServiceModel_3_0
- public static const string AssemblySystem_2_0
- public static const string AssemblySystem_Core
- public static const string AssemblySystem_Data
- public static const string AssemblySystem_Design
- public static const string AssemblySystem_DirectoryServices
- public static const string AssemblySystem_Drawing
- public static const string AssemblySystem_Drawing_Design
- public static const string AssemblySystem_Messaging
- public static const string AssemblySystem_Security
- public static const string AssemblySystem_ServiceProcess
- public static const string AssemblySystem_Web
- public static const string AssemblySystem_Windows_Forms
- public static const string AssemblyWindowsBase
- public static const string EnvironmentVersion
- public static const string FxFileVersion
- public static const string FxVersion
- public static const string MonoCompany
- public static const string MonoCopyright
- public static const string MonoCorlibVersion
- public static const string MonoProduct
- public static const string MonoVersion
- private static const string PublicKeyToken
- public static const string VsFileVersion
- public static const string VsVersion
- public static const string WindowsBase_3_0

## Namespace: Microsoft.Internal

### private class Microsoft.Internal.ReflectionServices.<>c

#### Fields
- public static readonly Microsoft.Internal.ReflectionServices.<>c <>9
- public static System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo>> <>9__7_0

#### Constructors
- private static ReflectionServices.<>c()
- public ReflectionServices.<>c()

#### Methods
- internal System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> <GetAllProperties>b__7_0(System.Type itf)

### private class Microsoft.Internal.Requires.<>c__5<T>

#### Fields
- public static readonly Microsoft.Internal.Requires.<>c__5<T> <>9
- public static System.Predicate<T> <>9__5_0

#### Constructors
- private static Requires.<>c__5<T>()
- public Requires.<>c__5<T>()

#### Methods
- internal bool <NotNullElements>b__5_0(T value)

### private class Microsoft.Internal.Requires.<>c__6<TKey, TValue>

#### Fields
- public static readonly Microsoft.Internal.Requires.<>c__6<TKey, TValue> <>9
- public static System.Predicate<System.Collections.Generic.KeyValuePair<TKey, TValue>> <>9__6_0

#### Constructors
- private static Requires.<>c__6<TKey, TValue>()
- public Requires.<>c__6<TKey, TValue>()

#### Methods
- internal bool <NotNullElements>b__6_0(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValue)

### private class Microsoft.Internal.ReflectionServices.<GetDeclaredFields>d__11
- Interfaces: System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Reflection.FieldInfo>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private System.Reflection.FieldInfo <>2__current
- public System.Type <>3__type
- private System.Reflection.FieldInfo[] <>7__wrap1
- private int <>7__wrap2
- private int <>l__initialThreadId
- private System.Type type

#### Properties
- private System.Reflection.FieldInfo System.Collections.Generic.IEnumerator<System.Reflection.FieldInfo>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public ReflectionServices.<GetDeclaredFields>d__11(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<System.Reflection.FieldInfo> System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class Microsoft.Internal.ReflectionServices.<GetDeclaredMethods>d__9
- Interfaces: System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Reflection.MethodInfo>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private System.Reflection.MethodInfo <>2__current
- public System.Type <>3__type
- private System.Reflection.MethodInfo[] <>7__wrap1
- private int <>7__wrap2
- private int <>l__initialThreadId
- private System.Type type

#### Properties
- private System.Reflection.MethodInfo System.Collections.Generic.IEnumerator<System.Reflection.MethodInfo>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public ReflectionServices.<GetDeclaredMethods>d__9(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<System.Reflection.MethodInfo> System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### internal static class Microsoft.Internal.Assumes

#### Methods
- internal static void IsTrue(bool condition)
- internal static void IsTrue(bool condition, string message)
- internal static void NotNull<T>(T value)
- internal static void NotNull<T1, T2>(T1 value1, T2 value2)
- internal static void NotNull<T1, T2, T3>(T1 value1, T2 value2, T3 value3)
- internal static void NotNullOrEmpty(string value)
- internal static T NotReachable<T>()
- private static System.Exception UncatchableException(string message)

### internal static class Microsoft.Internal.AttributeServices

#### Methods
- public static T[] GetAttributes<T>(System.Reflection.ICustomAttributeProvider attributeProvider)
- public static T[] GetAttributes<T>(System.Reflection.ICustomAttributeProvider attributeProvider, bool inherit)
- public static T GetFirstAttribute<T>(System.Reflection.ICustomAttributeProvider attributeProvider)
- public static T GetFirstAttribute<T>(System.Reflection.ICustomAttributeProvider attributeProvider, bool inherit)
- public static bool IsAttributeDefined<T>(System.Reflection.ICustomAttributeProvider attributeProvider)
- public static bool IsAttributeDefined<T>(System.Reflection.ICustomAttributeProvider attributeProvider, bool inherit)

### internal static class Microsoft.Internal.ContractServices

#### Methods
- public static bool TryCast(System.Type contractType, object value, out object result)

### internal static class Microsoft.Internal.GenerationServices

#### Fields
- private static readonly System.Type BooleanType
- private static readonly System.Type ByteType
- private static readonly System.Type CharType
- private static readonly System.Reflection.MethodInfo DictionaryAdd
- private static readonly System.Type DoubleType
- private static readonly System.Reflection.MethodInfo ExceptionGetData
- private static readonly System.Type IEnumerableType
- private static readonly System.Type IEnumerableTypeofT
- private static readonly System.Type Int16Type
- private static readonly System.Type Int32Type
- private static readonly System.Type Int64Type
- private static readonly System.Reflection.ConstructorInfo ObjectCtor
- private static readonly System.Type SByteType
- private static readonly System.Type SingleType
- private static readonly System.Type StringType
- private static readonly System.Type TypeType
- private static readonly System.Type UInt16Type
- private static readonly System.Type UInt32Type
- private static readonly System.Type UInt64Type
- private static readonly System.Reflection.MethodInfo _typeGetTypeFromHandleMethod

#### Constructors
- private static GenerationServices()

#### Methods
- public static void AddItemToLocalDictionary(System.Reflection.Emit.ILGenerator ilGenerator, System.Reflection.Emit.LocalBuilder dictionary, object key, object value)
- public static void AddLocalToLocalDictionary(System.Reflection.Emit.ILGenerator ilGenerator, System.Reflection.Emit.LocalBuilder dictionary, object key, System.Reflection.Emit.LocalBuilder value)
- public static System.Reflection.Emit.ILGenerator CreateGeneratorForPublicConstructor(System.Reflection.Emit.TypeBuilder typeBuilder, System.Type[] ctrArgumentTypes)
- public static void GetExceptionDataAndStoreInLocal(System.Reflection.Emit.ILGenerator ilGenerator, System.Reflection.Emit.LocalBuilder exception, System.Reflection.Emit.LocalBuilder dataStore)
- private static bool IsBoxingRequiredForValue(object value)
- private static void LoadDouble(System.Reflection.Emit.ILGenerator ilGenerator, double value)
- private static void LoadEnumerable(System.Reflection.Emit.ILGenerator ilGenerator, System.Collections.IEnumerable enumerable)
- private static void LoadFloat(System.Reflection.Emit.ILGenerator ilGenerator, float value)
- private static void LoadInt(System.Reflection.Emit.ILGenerator ilGenerator, int value)
- private static void LoadLong(System.Reflection.Emit.ILGenerator ilGenerator, long value)
- private static void LoadNull(System.Reflection.Emit.ILGenerator ilGenerator)
- private static void LoadString(System.Reflection.Emit.ILGenerator ilGenerator, string s)
- private static void LoadTypeOf(System.Reflection.Emit.ILGenerator ilGenerator, System.Type type)
- public static void LoadValue(System.Reflection.Emit.ILGenerator ilGenerator, object value)

### private class Microsoft.Internal.Assumes.InternalErrorException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public Assumes.InternalErrorException(string message)
- protected Assumes.InternalErrorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)

### internal static class Microsoft.Internal.LazyServices

#### Methods
- public static T GetNotNullValue<T>(System.Lazy<T> lazy, string argument)

### internal class Microsoft.Internal.Lock
- Interfaces: System.IDisposable

#### Fields
- private int _isDisposed
- private System.Threading.ReaderWriterLockSlim _thisLock

#### Constructors
- public Lock()

#### Methods
- public void Dispose()
- public void EnterReadLock()
- public void EnterWriteLock()
- public void ExitReadLock()
- public void ExitWriteLock()

### internal struct Microsoft.Internal.ReadLock
- Interfaces: System.IDisposable

#### Fields
- private int _isDisposed
- private readonly Microsoft.Internal.Lock _lock

#### Constructors
- public ReadLock(Microsoft.Internal.Lock lock)

#### Methods
- public void Dispose()

### internal static class Microsoft.Internal.ReflectionInvoke

#### Methods
- public static void DemandMemberAccessIfNeeded(System.Reflection.MethodInfo method)
- private static void DemandMemberAccessIfNeeded(System.Reflection.ConstructorInfo constructor)
- private static void DemandMemberAccessIfNeeded(System.Reflection.FieldInfo field)
- public static void DemandMemberAccessIfNeeded(System.Type type)
- public static object SafeCreateInstance(System.Type type, params object[] arguments)
- public static object SafeGetValue(System.Reflection.FieldInfo field, object instance)
- public static object SafeInvoke(System.Reflection.ConstructorInfo constructor, params object[] arguments)
- public static object SafeInvoke(System.Reflection.MethodInfo method, object instance, params object[] arguments)
- public static void SafeSetValue(System.Reflection.FieldInfo field, object instance, object value)

### internal static class Microsoft.Internal.ReflectionServices

#### Methods
- public static System.Reflection.Assembly Assembly(System.Reflection.MemberInfo member)
- public static System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetAllFields(System.Type type)
- internal static System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> GetAllMethods(System.Type type)
- internal static System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetAllProperties(System.Type type)
- private static System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetDeclaredFields(System.Type type)
- private static System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> GetDeclaredMethods(System.Type type)
- public static string GetDisplayName(System.Type declaringType, string name)
- public static string GetDisplayName(System.Reflection.MemberInfo member)
- public static bool IsVisible(System.Reflection.ConstructorInfo constructor)
- public static bool IsVisible(System.Reflection.FieldInfo field)
- public static bool IsVisible(System.Reflection.MethodInfo method)
- internal static bool TryGetGenericInterfaceType(System.Type instanceType, System.Type targetOpenInterfaceType, out System.Type targetClosedInterfaceType)

### internal static class Microsoft.Internal.Requires

#### Methods
- public static void IsInMembertypeSet(System.Reflection.MemberTypes value, string parameterName, System.Reflection.MemberTypes enumFlagSet)
- public static void NotNull<T>(T value, string parameterName)
- private static void NotNullElements<T>(System.Collections.Generic.IEnumerable<T> values, string parameterName)
- private static void NotNullElements<TKey, TValue>(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>> values, string parameterName)
- public static void NotNullOrEmpty(string value, string parameterName)
- public static void NotNullOrNullElements<T>(System.Collections.Generic.IEnumerable<T> values, string parameterName)
- public static void NullOrNotNullElements<TKey, TValue>(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>> values, string parameterName)
- public static void NullOrNotNullElements<T>(System.Collections.Generic.IEnumerable<T> values, string parameterName)

### internal static class Microsoft.Internal.StringComparers

#### Properties
- public static System.StringComparer ContractName { get; }
- public static System.StringComparer MetadataKeyNames { get; }

### internal class Microsoft.Internal.Strings

#### Fields
- private static System.Globalization.CultureInfo resourceCulture
- private static System.Resources.ResourceManager resourceMan

#### Properties
- internal static string ArgumentException_EmptyString { get; }
- internal static string ArgumentOutOfRange_InvalidEnum { get; }
- internal static string ArgumentOutOfRange_InvalidEnumInSet { get; }
- internal static string ArgumentValueType { get; }
- internal static string Argument_AssemblyReflectionOnly { get; }
- internal static string Argument_ElementReflectionOnlyType { get; }
- internal static string Argument_ExportsEmpty { get; }
- internal static string Argument_ExportsTooMany { get; }
- internal static string Argument_NullElement { get; }
- internal static string Argument_ReflectionContextReturnsReflectionOnlyType { get; }
- internal static string AssemblyFileNotFoundOrWrongType { get; }
- internal static string AtomicComposition_AlreadyCompleted { get; }
- internal static string AtomicComposition_AlreadyNested { get; }
- internal static string AtomicComposition_PartOfAnotherAtomicComposition { get; }
- internal static string CardinalityMismatch_NoExports { get; }
- internal static string CardinalityMismatch_TooManyExports { get; }
- internal static string CatalogMutation_Invalid { get; }
- internal static string CompositionElement_UnknownOrigin { get; }
- internal static string CompositionException_ChangesRejected { get; }
- internal static string CompositionException_ElementPrefix { get; }
- internal static string CompositionException_ErrorPrefix { get; }
- internal static string CompositionException_MetadataViewInvalidConstructor { get; }
- internal static string CompositionException_MultipleErrorsWithMultiplePaths { get; }
- internal static string CompositionException_OriginFormat { get; }
- internal static string CompositionException_OriginSeparator { get; }
- internal static string CompositionException_PathsCountSeparator { get; }
- internal static string CompositionException_ReviewErrorProperty { get; }
- internal static string CompositionException_SingleErrorWithMultiplePaths { get; }
- internal static string CompositionException_SingleErrorWithSinglePath { get; }
- internal static string CompositionTrace_Discovery_AssemblyLoadFailed { get; }
- internal static string CompositionTrace_Discovery_DefinitionContainsNoExports { get; }
- internal static string CompositionTrace_Discovery_DefinitionMarkedWithPartNotDiscoverableAttribute { get; }
- internal static string CompositionTrace_Discovery_DefinitionMismatchedExportArity { get; }
- internal static string CompositionTrace_Discovery_MemberMarkedWithMultipleImportAndImportMany { get; }
- internal static string CompositionTrace_Rejection_DefinitionRejected { get; }
- internal static string CompositionTrace_Rejection_DefinitionResurrected { get; }
- internal static string ContractMismatch_ExportedValueCannotBeCastToT { get; }
- internal static string ContractMismatch_InvalidCastOnMetadataField { get; }
- internal static string ContractMismatch_MetadataViewImplementationCanNotBeNull { get; }
- internal static string ContractMismatch_MetadataViewImplementationDoesNotImplementViewInterface { get; }
- internal static string ContractMismatch_NullReferenceOnMetadataField { get; }
- internal static System.Globalization.CultureInfo Culture { get; set; }
- internal static string DirectoryNotFound { get; }
- internal static string Discovery_DuplicateMetadataNameValues { get; }
- internal static string Discovery_MetadataContainsValueWithInvalidType { get; }
- internal static string Discovery_ReservedMetadataNameUsed { get; }
- internal static string ExportDefinitionNotOnThisComposablePart { get; }
- internal static string ExportFactory_TooManyGenericParameters { get; }
- internal static string ExportNotValidOnIndexers { get; }
- internal static string ImportDefinitionNotOnThisComposablePart { get; }
- internal static string ImportEngine_ComposeTookTooManyIterations { get; }
- internal static string ImportEngine_InvalidStateForRecomposition { get; }
- internal static string ImportEngine_PartCannotActivate { get; }
- internal static string ImportEngine_PartCannotGetExportedValue { get; }
- internal static string ImportEngine_PartCannotSetImport { get; }
- internal static string ImportEngine_PartCycle { get; }
- internal static string ImportEngine_PreventedByExistingImport { get; }
- internal static string ImportNotSetOnPart { get; }
- internal static string ImportNotValidOnIndexers { get; }
- internal static string InternalExceptionMessage { get; }
- internal static string InvalidArgument_ReflectionContext { get; }
- internal static string InvalidMetadataValue { get; }
- internal static string InvalidMetadataView { get; }
- internal static string InvalidOperationReentrantCompose { get; }
- internal static string InvalidOperation_DefinitionCannotBeRecomposed { get; }
- internal static string InvalidOperation_GetExportedValueBeforePrereqImportSet { get; }
- internal static string InvalidPartCreationPolicyOnImport { get; }
- internal static string InvalidPartCreationPolicyOnPart { get; }
- internal static string InvalidSetterOnMetadataField { get; }
- internal static string LazyMemberInfo_AccessorsNull { get; }
- internal static string LazyMemberInfo_InvalidAccessorOnSimpleMember { get; }
- internal static string LazyMemberinfo_InvalidEventAccessors_AccessorType { get; }
- internal static string LazyMemberInfo_InvalidEventAccessors_Cardinality { get; }
- internal static string LazyMemberinfo_InvalidPropertyAccessors_AccessorType { get; }
- internal static string LazyMemberInfo_InvalidPropertyAccessors_Cardinality { get; }
- internal static string LazyMemberInfo_NoAccessors { get; }
- internal static string LazyServices_LazyResolvesToNull { get; }
- internal static string MetadataItemNotSupported { get; }
- internal static string NotImplemented_NotOverriddenByDerived { get; }
- internal static string NotSupportedCatalogChanges { get; }
- internal static string NotSupportedInterfaceMetadataView { get; }
- internal static string NotSupportedReadOnlyDictionary { get; }
- internal static string ObjectAlreadyInitialized { get; }
- internal static string ObjectMustBeInitialized { get; }
- internal static string ReentrantCompose { get; }
- internal static string ReflectionContext_Requires_DefaultConstructor { get; }
- internal static string ReflectionContext_Type_Required { get; }
- internal static string ReflectionModel_ExportNotReadable { get; }
- internal static string ReflectionModel_ExportThrewException { get; }
- internal static string ReflectionModel_ImportCollectionAddThrewException { get; }
- internal static string ReflectionModel_ImportCollectionClearThrewException { get; }
- internal static string ReflectionModel_ImportCollectionConstructionThrewException { get; }
- internal static string ReflectionModel_ImportCollectionGetThrewException { get; }
- internal static string ReflectionModel_ImportCollectionIsReadOnlyThrewException { get; }
- internal static string ReflectionModel_ImportCollectionNotWritable { get; }
- internal static string ReflectionModel_ImportCollectionNull { get; }
- internal static string ReflectionModel_ImportManyOnParameterCanOnlyBeAssigned { get; }
- internal static string ReflectionModel_ImportNotAssignableFromExport { get; }
- internal static string ReflectionModel_ImportNotWritable { get; }
- internal static string ReflectionModel_ImportThrewException { get; }
- internal static string ReflectionModel_InvalidExportDefinition { get; }
- internal static string ReflectionModel_InvalidImportDefinition { get; }
- internal static string ReflectionModel_InvalidMemberImportDefinition { get; }
- internal static string ReflectionModel_InvalidParameterImportDefinition { get; }
- internal static string ReflectionModel_InvalidPartDefinition { get; }
- internal static string ReflectionModel_PartConstructorMissing { get; }
- internal static string ReflectionModel_PartConstructorThrewException { get; }
- internal static string ReflectionModel_PartOnImportsSatisfiedThrewException { get; }
- internal static System.Resources.ResourceManager ResourceManager { get; }
- internal static string TypeCatalog_DisplayNameFormat { get; }
- internal static string TypeCatalog_Empty { get; }

#### Constructors
- internal Strings()

### internal struct Microsoft.Internal.WriteLock
- Interfaces: System.IDisposable

#### Fields
- private int _isDisposed
- private readonly Microsoft.Internal.Lock _lock

#### Constructors
- public WriteLock(Microsoft.Internal.Lock lock)

#### Methods
- public void Dispose()

## Namespace: Microsoft.Internal.Collections

### private class Microsoft.Internal.Collections.WeakReferenceCollection<T>.<>c<T>

#### Fields
- public static readonly Microsoft.Internal.Collections.WeakReferenceCollection<T>.<>c<T> <>9
- public static System.Predicate<System.WeakReference> <>9__6_0

#### Constructors
- private static WeakReferenceCollection<T>.<>c<T>()
- public WeakReferenceCollection<T>.<>c<T>()

#### Methods
- internal bool <CleanupDeadReferences>b__6_0(System.WeakReference w)

### private class Microsoft.Internal.Collections.CollectionServices.CollectionOfObjectList
- Interfaces: System.Collections.Generic.ICollection<object>, System.Collections.Generic.IEnumerable<object>, System.Collections.IEnumerable

#### Fields
- private readonly System.Collections.IList _list

#### Properties
- public int Count { get; }
- public bool IsReadOnly { get; }

#### Constructors
- public CollectionServices.CollectionOfObjectList(System.Collections.IList list)

#### Methods
- public void Add(object item)
- public void Clear()
- public bool Contains(object item)
- public void CopyTo(object[] array, int arrayIndex)
- public System.Collections.Generic.IEnumerator<object> GetEnumerator()
- public bool Remove(object item)
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()

### private class Microsoft.Internal.Collections.CollectionServices.CollectionOfObject<T>
- Interfaces: System.Collections.Generic.ICollection<object>, System.Collections.Generic.IEnumerable<object>, System.Collections.IEnumerable

#### Fields
- private readonly System.Collections.Generic.ICollection<T> _collectionOfT

#### Properties
- public int Count { get; }
- public bool IsReadOnly { get; }

#### Constructors
- public CollectionServices.CollectionOfObject<T>(object collectionOfT)

#### Methods
- public void Add(object item)
- public void Clear()
- public bool Contains(object item)
- public void CopyTo(object[] array, int arrayIndex)
- public System.Collections.Generic.IEnumerator<object> GetEnumerator()
- public bool Remove(object item)
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()

### internal static class Microsoft.Internal.Collections.CollectionServices

#### Fields
- private static readonly System.Type ICollectionOfTType
- private static readonly System.Type IEnumerableOfTType
- private static readonly System.Type IEnumerableType
- private static readonly System.Type StringType

#### Constructors
- private static CollectionServices()

#### Methods
- public static T[] AsArray<T>(System.Collections.Generic.IEnumerable<T> enumerable)
- public static System.Collections.Generic.List<T> AsList<T>(System.Collections.Generic.IEnumerable<T> enumerable)
- public static System.Collections.Generic.IEnumerable<T> ConcatAllowingNull<T>(System.Collections.Generic.IEnumerable<T> source, System.Collections.Generic.IEnumerable<T> second)
- public static System.Collections.Generic.ICollection<T> ConcatAllowingNull<T>(System.Collections.Generic.ICollection<T> source, System.Collections.Generic.ICollection<T> second)
- public static System.Collections.Generic.Stack<T> Copy<T>(System.Collections.Generic.Stack<T> stack)
- public static bool FastAny<T>(System.Collections.Generic.IEnumerable<T> source)
- public static System.Collections.Generic.List<T> FastAppendToListAllowNulls<T>(System.Collections.Generic.List<T> source, System.Collections.Generic.IEnumerable<T> second)
- public static void ForEach<T>(System.Collections.Generic.IEnumerable<T> source, System.Action<T> action)
- public static Microsoft.Internal.Collections.EnumerableCardinality GetCardinality<T>(System.Collections.Generic.IEnumerable<T> source)
- public static System.Type GetCollectionElementType(System.Type type)
- public static System.Collections.Generic.ICollection<object> GetCollectionWrapper(System.Type itemType, object collectionObject)
- public static System.Type GetEnumerableElementType(System.Type type)
- public static bool IsArrayEqual<T>(T[] thisArray, T[] thatArray)
- public static bool IsCollectionEqual<T>(System.Collections.Generic.IList<T> thisList, System.Collections.Generic.IList<T> thatList)
- public static bool IsEnumerableOfT(System.Type type)
- public static System.Collections.ObjectModel.ReadOnlyCollection<T> ToReadOnlyCollection<T>(System.Collections.Generic.IEnumerable<T> source)

### internal enum Microsoft.Internal.Collections.EnumerableCardinality
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- One = 1
- TwoOrMore = 2
- Zero = 0

### internal class Microsoft.Internal.Collections.WeakReferenceCollection<T>

#### Fields
- private readonly System.Collections.Generic.List<System.WeakReference> _items

#### Constructors
- public WeakReferenceCollection<T>()

#### Methods
- public void Add(T item)
- public System.Collections.Generic.List<T> AliveItemsToList()
- private void CleanupDeadReferences()
- public void Clear()
- public bool Contains(T item)
- private int IndexOf(T item)
- public void Remove(T item)

## Namespace: Microsoft.Internal.Runtime.Serialization

### internal static class Microsoft.Internal.Runtime.Serialization.SerializationServices

#### Methods
- public static T GetValue<T>(System.Runtime.Serialization.SerializationInfo info, string name)

## Namespace: System

### public class System.Lazy<T, TMetadata>
- Base: System.Lazy<T>

#### Fields
- private TMetadata _metadata

#### Properties
- public TMetadata Metadata { get; }

#### Constructors
- public Lazy<T, TMetadata>(TMetadata metadata)
- public Lazy<T, TMetadata>(System.Func<T> valueFactory, TMetadata metadata)
- public Lazy<T, TMetadata>(TMetadata metadata, bool isThreadSafe)
- public Lazy<T, TMetadata>(TMetadata metadata, System.Threading.LazyThreadSafetyMode mode)
- public Lazy<T, TMetadata>(System.Func<T> valueFactory, TMetadata metadata, bool isThreadSafe)
- public Lazy<T, TMetadata>(System.Func<T> valueFactory, TMetadata metadata, System.Threading.LazyThreadSafetyMode mode)

## Namespace: System.ComponentModel

### internal class System.ComponentModel.LocalizableAttribute
- Base: System.Attribute

#### Constructors
- public LocalizableAttribute(bool isLocalizable)

## Namespace: System.ComponentModel.Composition

### private class System.ComponentModel.Composition.AttributedModelServices.<>c

#### Fields
- public static readonly System.ComponentModel.Composition.AttributedModelServices.<>c <>9
- public static System.Func<object, System.ComponentModel.Composition.Primitives.ComposablePart> <>9__14_0

#### Constructors
- private static AttributedModelServices.<>c()
- public AttributedModelServices.<>c()

#### Methods
- internal System.ComponentModel.Composition.Primitives.ComposablePart <ComposeParts>b__14_0(object attributedPart)

### private class System.ComponentModel.Composition.CompositionException.<>c

#### Fields
- public static readonly System.ComponentModel.Composition.CompositionException.<>c <>9
- public static System.Func<System.ComponentModel.Composition.CompositionError, System.ComponentModel.Composition.CompositionError> <>9__8_1

#### Constructors
- private static CompositionException.<>c()
- public CompositionException.<>c()

#### Methods
- internal System.ComponentModel.Composition.CompositionError <.ctor>b__8_1(System.ComponentModel.Composition.CompositionError error)

### private class System.ComponentModel.Composition.AttributedModelServices.<>c__DisplayClass11_0<T>

#### Fields
- public T exportedValue

#### Constructors
- public AttributedModelServices.<>c__DisplayClass11_0<T>()

#### Methods
- internal object <AddExportedValue>b__0()

### private class System.ComponentModel.Composition.ExportServices.<>c__DisplayClass11_0<T, M>

#### Fields
- public System.ComponentModel.Composition.Primitives.Export export

#### Constructors
- public ExportServices.<>c__DisplayClass11_0<T, M>()

#### Methods
- internal T <CreateStronglyTypedLazyOfTM>b__0()
- internal T <CreateStronglyTypedLazyOfTM>b__1()

### private class System.ComponentModel.Composition.ExportServices.<>c__DisplayClass12_0<T>

#### Fields
- public System.ComponentModel.Composition.Primitives.Export export

#### Constructors
- public ExportServices.<>c__DisplayClass12_0<T>()

#### Methods
- internal T <CreateStronglyTypedLazyOfT>b__0()
- internal T <CreateStronglyTypedLazyOfT>b__1()

### private class System.ComponentModel.Composition.ExportServices.<>c__DisplayClass13_0<T, M>

#### Fields
- public System.ComponentModel.Composition.Primitives.Export export

#### Constructors
- public ExportServices.<>c__DisplayClass13_0<T, M>()

#### Methods
- internal object <CreateSemiStronglyTypedLazy>b__0()
- internal object <CreateSemiStronglyTypedLazy>b__1()

### private class System.ComponentModel.Composition.CompositionException.<>c__DisplayClass19_0

#### Fields
- public System.Collections.Generic.List<System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.CompositionError>> paths

#### Constructors
- public CompositionException.<>c__DisplayClass19_0()

#### Methods
- internal void <CalculatePaths>b__0(System.Collections.Generic.Stack<System.ComponentModel.Composition.CompositionError> path)

### public static class System.ComponentModel.Composition.AttributedModelServices

#### Methods
- public static System.ComponentModel.Composition.Primitives.ComposablePart AddExportedValue<T>(System.ComponentModel.Composition.Hosting.CompositionBatch batch, T exportedValue)
- public static System.ComponentModel.Composition.Primitives.ComposablePart AddExportedValue<T>(System.ComponentModel.Composition.Hosting.CompositionBatch batch, string contractName, T exportedValue)
- public static System.ComponentModel.Composition.Primitives.ComposablePart AddPart(System.ComponentModel.Composition.Hosting.CompositionBatch batch, object attributedPart)
- public static void ComposeExportedValue<T>(System.ComponentModel.Composition.Hosting.CompositionContainer container, T exportedValue)
- public static void ComposeExportedValue<T>(System.ComponentModel.Composition.Hosting.CompositionContainer container, string contractName, T exportedValue)
- public static void ComposeParts(System.ComponentModel.Composition.Hosting.CompositionContainer container, params object[] attributedParts)
- public static System.ComponentModel.Composition.Primitives.ComposablePart CreatePart(object attributedPart)
- public static System.ComponentModel.Composition.Primitives.ComposablePart CreatePart(object attributedPart, System.Reflection.ReflectionContext reflectionContext)
- public static System.ComponentModel.Composition.Primitives.ComposablePart CreatePart(System.ComponentModel.Composition.Primitives.ComposablePartDefinition partDefinition, object attributedPart)
- public static System.ComponentModel.Composition.Primitives.ComposablePartDefinition CreatePartDefinition(System.Type type, System.ComponentModel.Composition.Primitives.ICompositionElement origin)
- public static System.ComponentModel.Composition.Primitives.ComposablePartDefinition CreatePartDefinition(System.Type type, System.ComponentModel.Composition.Primitives.ICompositionElement origin, bool ensureIsDiscoverable)
- public static bool Exports(System.ComponentModel.Composition.Primitives.ComposablePartDefinition part, System.Type contractType)
- public static bool Exports<T>(System.ComponentModel.Composition.Primitives.ComposablePartDefinition part)
- public static string GetContractName(System.Type type)
- public static TMetadataView GetMetadataView<TMetadataView>(System.Collections.Generic.IDictionary<string, object> metadata)
- public static string GetTypeIdentity(System.Type type)
- public static string GetTypeIdentity(System.Reflection.MethodInfo method)
- public static bool Imports(System.ComponentModel.Composition.Primitives.ComposablePartDefinition part, System.Type contractType)
- public static bool Imports<T>(System.ComponentModel.Composition.Primitives.ComposablePartDefinition part)
- public static bool Imports(System.ComponentModel.Composition.Primitives.ComposablePartDefinition part, System.Type contractType, System.ComponentModel.Composition.Primitives.ImportCardinality importCardinality)
- public static bool Imports<T>(System.ComponentModel.Composition.Primitives.ComposablePartDefinition part, System.ComponentModel.Composition.Primitives.ImportCardinality importCardinality)
- public static System.ComponentModel.Composition.Primitives.ComposablePart SatisfyImportsOnce(System.ComponentModel.Composition.ICompositionService compositionService, object attributedPart)
- public static System.ComponentModel.Composition.Primitives.ComposablePart SatisfyImportsOnce(System.ComponentModel.Composition.ICompositionService compositionService, object attributedPart, System.Reflection.ReflectionContext reflectionContext)

### public class System.ComponentModel.Composition.CatalogReflectionContextAttribute
- Base: System.Attribute

#### Fields
- private System.Type _reflectionContextType

#### Constructors
- public CatalogReflectionContextAttribute(System.Type reflectionContextType)

#### Methods
- public System.Reflection.ReflectionContext CreateReflectionContext()

### public class System.ComponentModel.Composition.ChangeRejectedException
- Base: System.ComponentModel.Composition.CompositionException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Properties
- public string Message { get; }

#### Constructors
- public ChangeRejectedException()
- public ChangeRejectedException(string message)
- public ChangeRejectedException(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.CompositionError> errors)
- public ChangeRejectedException(string message, System.Exception innerException)

### public class System.ComponentModel.Composition.CompositionContractMismatchException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public CompositionContractMismatchException()
- public CompositionContractMismatchException(string message)
- public CompositionContractMismatchException(string message, System.Exception innerException)
- protected CompositionContractMismatchException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)

### public class System.ComponentModel.Composition.CompositionError

#### Fields
- private readonly string _description
- private readonly System.ComponentModel.Composition.Primitives.ICompositionElement _element
- private readonly System.Exception _exception
- private readonly System.ComponentModel.Composition.CompositionErrorId _id

#### Properties
- public string Description { get; }
- public System.ComponentModel.Composition.Primitives.ICompositionElement Element { get; }
- public System.Exception Exception { get; }
- internal System.ComponentModel.Composition.CompositionErrorId Id { get; }
- internal System.Exception InnerException { get; }

#### Constructors
- public CompositionError(string message)
- public CompositionError(string message, System.ComponentModel.Composition.Primitives.ICompositionElement element)
- public CompositionError(string message, System.Exception exception)
- public CompositionError(string message, System.ComponentModel.Composition.Primitives.ICompositionElement element, System.Exception exception)
- internal CompositionError(System.ComponentModel.Composition.CompositionErrorId id, string description, System.ComponentModel.Composition.Primitives.ICompositionElement element, System.Exception exception)

#### Methods
- internal static System.ComponentModel.Composition.CompositionError Create(System.ComponentModel.Composition.CompositionErrorId id, string format, params object[] parameters)
- internal static System.ComponentModel.Composition.CompositionError Create(System.ComponentModel.Composition.CompositionErrorId id, System.ComponentModel.Composition.Primitives.ICompositionElement element, string format, params object[] parameters)
- internal static System.ComponentModel.Composition.CompositionError Create(System.ComponentModel.Composition.CompositionErrorId id, System.ComponentModel.Composition.Primitives.ICompositionElement element, System.Exception exception, string format, params object[] parameters)
- public override string ToString()

### internal class System.ComponentModel.Composition.CompositionErrorDebuggerProxy

#### Fields
- private readonly System.ComponentModel.Composition.CompositionError _error

#### Properties
- public string Description { get; }
- public System.ComponentModel.Composition.Primitives.ICompositionElement Element { get; }
- public System.Exception Exception { get; }

#### Constructors
- public CompositionErrorDebuggerProxy(System.ComponentModel.Composition.CompositionError error)

### internal enum System.ComponentModel.Composition.CompositionErrorId
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ImportEngine_ComposeTookTooManyIterations = 3
- ImportEngine_ImportCardinalityMismatch = 4
- ImportEngine_InvalidStateForRecomposition = 10
- ImportEngine_PartCannotActivate = 8
- ImportEngine_PartCannotGetExportedValue = 7
- ImportEngine_PartCannotSetImport = 6
- ImportEngine_PartCycle = 5
- ImportEngine_PreventedByExistingImport = 9
- ImportNotSetOnPart = 2
- InvalidExportMetadata = 1
- ReflectionModel_ImportCollectionAddThrewException = 19
- ReflectionModel_ImportCollectionClearThrewException = 18
- ReflectionModel_ImportCollectionConstructionThrewException = 15
- ReflectionModel_ImportCollectionGetThrewException = 16
- ReflectionModel_ImportCollectionIsReadOnlyThrewException = 17
- ReflectionModel_ImportCollectionNotWritable = 14
- ReflectionModel_ImportCollectionNull = 13
- ReflectionModel_ImportManyOnParameterCanOnlyBeAssigned = 20
- ReflectionModel_ImportNotAssignableFromExport = 12
- ReflectionModel_ImportThrewException = 11
- Unknown = 0

### public class System.ComponentModel.Composition.CompositionException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Fields
- private static const string ErrorsKey
- private System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.CompositionError> _errors

#### Properties
- public System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.CompositionError> Errors { get; }
- public string Message { get; }
- public System.Collections.ObjectModel.ReadOnlyCollection<System.Exception> RootCauses { get; }

#### Constructors
- public CompositionException()
- public CompositionException(string message)
- internal CompositionException(System.ComponentModel.Composition.CompositionError error)
- public CompositionException(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.CompositionError> errors)
- public CompositionException(string message, System.Exception innerException)
- internal CompositionException(string message, System.Exception innerException, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.CompositionError> errors)

#### Methods
- private void <.ctor>b__8_0(object exception, System.Runtime.Serialization.SafeSerializationEventArgs eventArgs)
- private string BuildDefaultMessage()
- private static System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.CompositionError>> CalculatePaths(System.ComponentModel.Composition.CompositionException exception)
- private static void VisitCompositionException(System.ComponentModel.Composition.CompositionException exception, System.ComponentModel.Composition.CompositionException.VisitContext context)
- private static void VisitError(System.ComponentModel.Composition.CompositionError error, System.ComponentModel.Composition.CompositionException.VisitContext context)
- private static void VisitException(System.Exception exception, System.ComponentModel.Composition.CompositionException.VisitContext context)
- private static void WriteElementGraph(System.Text.StringBuilder writer, System.ComponentModel.Composition.Primitives.ICompositionElement element)
- private static void WriteError(System.Text.StringBuilder writer, System.ComponentModel.Composition.CompositionError error)
- private static void WriteHeader(System.Text.StringBuilder writer, int errorsCount, int pathCount)
- private static void WritePath(System.Text.StringBuilder writer, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.CompositionError> path, int ordinal)
- private static void WritePaths(System.Text.StringBuilder writer, System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.CompositionError>> paths)

### private struct System.ComponentModel.Composition.CompositionException.CompositionExceptionData
- Interfaces: System.Runtime.Serialization.ISafeSerializationData

#### Fields
- public System.ComponentModel.Composition.CompositionError[] _errors

#### Methods
- private void System.Runtime.Serialization.ISafeSerializationData.CompleteDeserialization(object obj)

### internal class System.ComponentModel.Composition.CompositionExceptionDebuggerProxy

#### Fields
- private readonly System.ComponentModel.Composition.CompositionException _exception

#### Properties
- public System.Collections.ObjectModel.ReadOnlyCollection<System.Exception> Exceptions { get; }
- public string Message { get; }
- public System.Collections.ObjectModel.ReadOnlyCollection<System.Exception> RootCauses { get; }

#### Constructors
- public CompositionExceptionDebuggerProxy(System.ComponentModel.Composition.CompositionException exception)

### internal struct System.ComponentModel.Composition.CompositionResult

#### Fields
- public static readonly System.ComponentModel.Composition.CompositionResult SucceededResult
- private readonly System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.CompositionError> _errors

#### Properties
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.CompositionError> Errors { get; }
- public bool Succeeded { get; }

#### Constructors
- private static CompositionResult()
- public CompositionResult(params System.ComponentModel.Composition.CompositionError[] errors)
- public CompositionResult(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.CompositionError> errors)

#### Methods
- public System.ComponentModel.Composition.CompositionResult MergeError(System.ComponentModel.Composition.CompositionError error)
- public System.ComponentModel.Composition.CompositionResult MergeErrors(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.CompositionError> errors)
- public System.ComponentModel.Composition.CompositionResult MergeResult(System.ComponentModel.Composition.CompositionResult result)
- public void ThrowOnErrors()
- public void ThrowOnErrors(System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- public System.ComponentModel.Composition.CompositionResult<T> ToResult<T>(T value)

### internal struct System.ComponentModel.Composition.CompositionResult<T>

#### Fields
- private readonly System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.CompositionError> _errors
- private readonly T _value

#### Properties
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.CompositionError> Errors { get; }
- public bool Succeeded { get; }
- public T Value { get; }

#### Constructors
- public CompositionResult<T>(T value)
- public CompositionResult<T>(params System.ComponentModel.Composition.CompositionError[] errors)
- public CompositionResult<T>(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.CompositionError> errors)
- internal CompositionResult<T>(T value, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.CompositionError> errors)

#### Methods
- private void ThrowOnErrors()
- internal System.ComponentModel.Composition.CompositionResult<TValue> ToResult<TValue>()
- internal System.ComponentModel.Composition.CompositionResult ToResult()

### internal static class System.ComponentModel.Composition.ConstraintServices

#### Fields
- private static readonly System.Reflection.PropertyInfo _exportDefinitionContractNameProperty
- private static readonly System.Reflection.PropertyInfo _exportDefinitionMetadataProperty
- private static readonly System.Reflection.MethodInfo _metadataContainsKeyMethod
- private static readonly System.Reflection.MethodInfo _metadataEqualsMethod
- private static readonly System.Reflection.MethodInfo _metadataItemMethod
- private static readonly System.Reflection.MethodInfo _typeIsInstanceOfTypeMethod

#### Constructors
- private static ConstraintServices()

#### Methods
- public static System.Linq.Expressions.Expression<System.Func<System.ComponentModel.Composition.Primitives.ExportDefinition, bool>> CreateConstraint(string contractName, string requiredTypeIdentity, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Type>> requiredMetadata, System.ComponentModel.Composition.CreationPolicy requiredCreationPolicy)
- private static System.Linq.Expressions.Expression CreateContractConstraintBody(string contractName, System.Linq.Expressions.ParameterExpression parameter)
- private static System.Linq.Expressions.Expression CreateCreationPolicyContraint(System.ComponentModel.Composition.CreationPolicy policy, System.Linq.Expressions.ParameterExpression parameter)
- private static System.Linq.Expressions.Expression CreateMetadataConstraintBody(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Type>> requiredMetadata, System.Linq.Expressions.ParameterExpression parameter)
- private static System.Linq.Expressions.Expression CreateMetadataContainsKeyExpression(System.Linq.Expressions.ParameterExpression parameter, string constantKey)
- private static System.Linq.Expressions.Expression CreateMetadataOfTypeExpression(System.Linq.Expressions.ParameterExpression parameter, string constantKey, System.Type constantType)
- private static System.Linq.Expressions.Expression CreateMetadataValueEqualsExpression(System.Linq.Expressions.ParameterExpression parameter, object constantValue, string metadataName)
- public static System.Linq.Expressions.Expression<System.Func<System.ComponentModel.Composition.Primitives.ExportDefinition, bool>> CreatePartCreatorConstraint(System.Linq.Expressions.Expression<System.Func<System.ComponentModel.Composition.Primitives.ExportDefinition, bool>> baseConstraint, System.ComponentModel.Composition.Primitives.ImportDefinition productImportDefinition)
- private static System.Linq.Expressions.Expression CreateTypeIdentityContraint(string requiredTypeIdentity, System.Linq.Expressions.ParameterExpression parameter)

### internal static class System.ComponentModel.Composition.ContractNameServices

#### Fields
- private static const char ArrayClosingBracket
- private static const char ArrayOpeningBracket
- private static const char ArraySeparator
- private static const char ContractNameGenericArgumentSeparator
- private static const char ContractNameGenericClosingBracket
- private static const char ContractNameGenericOpeningBracket
- private static const char CustomModifiersSeparator
- private static const char GenericArityBackQuote
- private static const char GenericFormatClosingBracket
- private static const char GenericFormatOpeningBracket
- private static const char NamespaceSeparator
- private static const char NestedClassSeparator
- private static const char PointerSymbol
- private static const char ReferenceSymbol
- private static System.Collections.Generic.Dictionary<System.Type, string> typeIdentityCache

#### Properties
- private static System.Collections.Generic.Dictionary<System.Type, string> TypeIdentityCache { get; }

#### Methods
- private static System.Type FindArrayElementType(System.Type type)
- private static string FindGenericTypeName(string genericName)
- private static int GetGenericArity(System.Type type)
- internal static string GetTypeIdentity(System.Type type)
- internal static string GetTypeIdentity(System.Type type, bool formatGenericName)
- internal static string GetTypeIdentityFromMethod(System.Reflection.MethodInfo method)
- internal static string GetTypeIdentityFromMethod(System.Reflection.MethodInfo method, bool formatGenericName)
- private static void WriteArrayType(System.Text.StringBuilder typeName, System.Type type, bool formatGenericName)
- private static void WriteArrayTypeDimensions(System.Text.StringBuilder typeName, System.Type type)
- private static void WriteByRefType(System.Text.StringBuilder typeName, System.Type type, bool formatGenericName)
- internal static void WriteCustomModifiers(System.Text.StringBuilder typeName, string customKeyword, System.Type[] types, bool formatGenericName)
- private static void WriteGenericType(System.Text.StringBuilder typeName, System.Type type, bool isDefinition, System.Collections.Generic.Queue<System.Type> genericTypeArguments, bool formatGenericName)
- private static void WriteGenericTypeName(System.Text.StringBuilder typeName, System.Type type, bool isDefinition, System.Collections.Generic.Queue<System.Type> genericTypeArguments, bool formatGenericName)
- private static void WriteNonGenericType(System.Text.StringBuilder typeName, System.Type type, bool formatGenericName)
- private static void WritePointerType(System.Text.StringBuilder typeName, System.Type type, bool formatGenericName)
- private static void WriteType(System.Text.StringBuilder typeName, System.Type type, bool formatGenericName)
- private static void WriteTypeArgument(System.Text.StringBuilder typeName, bool isDefinition, System.Type genericTypeArgument, bool formatGenericName)
- private static void WriteTypeArgumentsString(System.Text.StringBuilder typeName, int argumentsCount, bool isDefinition, System.Collections.Generic.Queue<System.Type> genericTypeArguments, bool formatGenericName)
- private static void WriteTypeWithNamespace(System.Text.StringBuilder typeName, System.Type type, bool formatGenericName)

### public enum System.ComponentModel.Composition.CreationPolicy
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Any = 0
- NewScope = 3
- NonShared = 2
- Shared = 1

### private class System.ComponentModel.Composition.ExportServices.DisposableLazy<T>
- Base: System.Lazy<T>
- Interfaces: System.IDisposable

#### Fields
- private System.IDisposable _disposable

#### Constructors
- public ExportServices.DisposableLazy<T>(System.Func<T> valueFactory, System.IDisposable disposable, System.Threading.LazyThreadSafetyMode mode)

#### Methods
- private void System.IDisposable.Dispose()

### private class System.ComponentModel.Composition.ExportServices.DisposableLazy<T, TMetadataView>
- Base: System.Lazy<T, TMetadataView>
- Interfaces: System.IDisposable

#### Fields
- private System.IDisposable _disposable

#### Constructors
- public ExportServices.DisposableLazy<T, TMetadataView>(System.Func<T> valueFactory, TMetadataView metadataView, System.IDisposable disposable, System.Threading.LazyThreadSafetyMode mode)

#### Methods
- private void System.IDisposable.Dispose()

### internal static class System.ComponentModel.Composition.ErrorBuilder

#### Methods
- public static System.ComponentModel.Composition.CompositionError ComposeTookTooManyIterations(int maximumNumberOfCompositionIterations)
- public static System.ComponentModel.Composition.CompositionError CreateCannotGetExportedValue(System.ComponentModel.Composition.Primitives.ComposablePart part, System.ComponentModel.Composition.Primitives.ExportDefinition definition, System.Exception innerException)
- public static System.ComponentModel.Composition.CompositionError CreateImportCardinalityMismatch(System.ComponentModel.Composition.ImportCardinalityMismatchException exception, System.ComponentModel.Composition.Primitives.ImportDefinition definition)
- public static System.ComponentModel.Composition.CompositionError CreatePartCannotActivate(System.ComponentModel.Composition.Primitives.ComposablePart part, System.Exception innerException)
- public static System.ComponentModel.Composition.CompositionError CreatePartCannotSetImport(System.ComponentModel.Composition.Primitives.ComposablePart part, System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.Exception innerException)
- public static System.ComponentModel.Composition.CompositionError CreatePartCycle(System.ComponentModel.Composition.Primitives.ComposablePart part)
- public static System.ComponentModel.Composition.CompositionError InvalidStateForRecompposition(System.ComponentModel.Composition.Primitives.ComposablePart part)
- public static System.ComponentModel.Composition.CompositionError PreventedByExistingImport(System.ComponentModel.Composition.Primitives.ComposablePart part, System.ComponentModel.Composition.Primitives.ImportDefinition import)

### internal static class System.ComponentModel.Composition.ExceptionBuilder

#### Methods
- public static System.ComponentModel.Composition.CompositionException CreateCannotGetExportedValue(System.ComponentModel.Composition.Primitives.ComposablePart part, System.ComponentModel.Composition.Primitives.ExportDefinition definition, System.Exception innerException)
- public static System.ArgumentException CreateContainsNullElement(string parameterName)
- public static System.Exception CreateDiscoveryException(string messageFormat, params string[] arguments)
- public static System.ArgumentException CreateExportDefinitionNotOnThisComposablePart(string parameterName)
- public static System.ArgumentException CreateImportDefinitionNotOnThisComposablePart(string parameterName)
- public static System.NotImplementedException CreateNotOverriddenByDerived(string memberName)
- public static System.ObjectDisposedException CreateObjectDisposed(object instance)
- public static System.ArgumentException CreateReflectionModelInvalidPartDefinition(string parameterName, System.Type partDefinitionType)
- public static System.ArgumentException ExportFactory_TooManyGenericParameters(string typeName)
- private static string Format(string format, params string[] arguments)

### public class System.ComponentModel.Composition.ExportAttribute
- Base: System.Attribute

#### Fields
- private string <ContractName>k__BackingField
- private System.Type <ContractType>k__BackingField

#### Properties
- public string ContractName { get; private set; }
- public System.Type ContractType { get; private set; }

#### Constructors
- public ExportAttribute()
- public ExportAttribute(System.Type contractType)
- public ExportAttribute(string contractName)
- public ExportAttribute(string contractName, System.Type contractType)

### internal enum System.ComponentModel.Composition.ExportCardinalityCheckResult
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Match = 0
- NoExports = 1
- TooManyExports = 2

### public class System.ComponentModel.Composition.ExportFactory<T>

#### Fields
- private System.Func<System.Tuple<T, System.Action>> _exportLifetimeContextCreator

#### Constructors
- public ExportFactory<T>(System.Func<System.Tuple<T, System.Action>> exportLifetimeContextCreator)

#### Methods
- public System.ComponentModel.Composition.ExportLifetimeContext<T> CreateExport()
- internal bool IncludeInScopedCatalog(System.ComponentModel.Composition.Primitives.ComposablePartDefinition composablePartDefinition)
- protected virtual bool OnFilterScopedCatalog(System.ComponentModel.Composition.Primitives.ComposablePartDefinition composablePartDefinition)

### public class System.ComponentModel.Composition.ExportFactory<T, TMetadata>
- Base: System.ComponentModel.Composition.ExportFactory<T>

#### Fields
- private readonly TMetadata _metadata

#### Properties
- public TMetadata Metadata { get; }

#### Constructors
- public ExportFactory<T, TMetadata>(System.Func<System.Tuple<T, System.Action>> exportLifetimeContextCreator, TMetadata metadata)

### public class System.ComponentModel.Composition.ExportLifetimeContext<T>
- Interfaces: System.IDisposable

#### Fields
- private readonly System.Action _disposeAction
- private readonly T _value

#### Properties
- public T Value { get; }

#### Constructors
- public ExportLifetimeContext<T>(T value, System.Action disposeAction)

#### Methods
- public void Dispose()

### public class System.ComponentModel.Composition.ExportMetadataAttribute
- Base: System.Attribute

#### Fields
- private bool <IsMultiple>k__BackingField
- private string <Name>k__BackingField
- private object <Value>k__BackingField

#### Properties
- public bool IsMultiple { get; set; }
- public string Name { get; private set; }
- public object Value { get; private set; }

#### Constructors
- public ExportMetadataAttribute(string name, object value)

### internal static class System.ComponentModel.Composition.ExportServices

#### Fields
- internal static readonly System.Type DefaultExportedValueType
- internal static readonly System.Type DefaultMetadataViewType
- private static readonly System.Reflection.MethodInfo _createSemiStronglyTypedLazy
- private static readonly System.Reflection.MethodInfo _createStronglyTypedLazyOfT
- private static readonly System.Reflection.MethodInfo _createStronglyTypedLazyOfTM

#### Constructors
- private static ExportServices()

#### Methods
- internal static T CastExportedValue<T>(System.ComponentModel.Composition.Primitives.ICompositionElement element, object exportedValue)
- internal static System.ComponentModel.Composition.ExportCardinalityCheckResult CheckCardinality<T>(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.Collections.Generic.IEnumerable<T> enumerable)
- internal static System.Lazy<object, object> CreateSemiStronglyTypedLazy<T, M>(System.ComponentModel.Composition.Primitives.Export export)
- internal static System.Func<System.ComponentModel.Composition.Primitives.Export, System.Lazy<object, object>> CreateSemiStronglyTypedLazyFactory(System.Type exportType, System.Type metadataViewType)
- internal static System.Func<System.ComponentModel.Composition.Primitives.Export, object> CreateStronglyTypedLazyFactory(System.Type exportType, System.Type metadataViewType)
- internal static System.Lazy<T> CreateStronglyTypedLazyOfT<T>(System.ComponentModel.Composition.Primitives.Export export)
- internal static System.Lazy<T, M> CreateStronglyTypedLazyOfTM<T, M>(System.ComponentModel.Composition.Primitives.Export export)
- internal static T GetCastedExportedValue<T>(System.ComponentModel.Composition.Primitives.Export export)
- internal static bool IsDefaultMetadataViewType(System.Type metadataViewType)
- internal static bool IsDictionaryConstructorViewType(System.Type metadataViewType)
- private static System.ComponentModel.Composition.ExportCardinalityCheckResult MatchCardinality(Microsoft.Internal.Collections.EnumerableCardinality actualCardinality, System.ComponentModel.Composition.Primitives.ImportCardinality importCardinality)

### internal interface System.ComponentModel.Composition.IAttributedImport

#### Properties
- public bool AllowRecomposition { get; }
- public System.ComponentModel.Composition.Primitives.ImportCardinality Cardinality { get; }
- public string ContractName { get; }
- public System.Type ContractType { get; }
- public System.ComponentModel.Composition.CreationPolicy RequiredCreationPolicy { get; }
- public System.ComponentModel.Composition.ImportSource Source { get; }

### public interface System.ComponentModel.Composition.ICompositionService

#### Methods
- public void SatisfyImportsOnce(System.ComponentModel.Composition.Primitives.ComposablePart part)

### public class System.ComponentModel.Composition.ImportAttribute
- Base: System.Attribute
- Interfaces: System.ComponentModel.Composition.IAttributedImport

#### Fields
- private bool <AllowDefault>k__BackingField
- private bool <AllowRecomposition>k__BackingField
- private string <ContractName>k__BackingField
- private System.Type <ContractType>k__BackingField
- private System.ComponentModel.Composition.CreationPolicy <RequiredCreationPolicy>k__BackingField
- private System.ComponentModel.Composition.ImportSource <Source>k__BackingField

#### Properties
- public bool AllowDefault { get; set; }
- public bool AllowRecomposition { get; set; }
- public string ContractName { get; private set; }
- public System.Type ContractType { get; private set; }
- public System.ComponentModel.Composition.CreationPolicy RequiredCreationPolicy { get; set; }
- public System.ComponentModel.Composition.ImportSource Source { get; set; }
- private System.ComponentModel.Composition.Primitives.ImportCardinality System.ComponentModel.Composition.IAttributedImport.Cardinality { get; }

#### Constructors
- public ImportAttribute()
- public ImportAttribute(System.Type contractType)
- public ImportAttribute(string contractName)
- public ImportAttribute(string contractName, System.Type contractType)

### public class System.ComponentModel.Composition.ImportCardinalityMismatchException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public ImportCardinalityMismatchException()
- public ImportCardinalityMismatchException(string message)
- public ImportCardinalityMismatchException(string message, System.Exception innerException)
- protected ImportCardinalityMismatchException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)

### internal class System.ComponentModel.Composition.ImportCardinalityMismatchExceptionDebuggerProxy

#### Fields
- private readonly System.ComponentModel.Composition.ImportCardinalityMismatchException _exception

#### Properties
- public System.Exception InnerException { get; }
- public string Message { get; }

#### Constructors
- public ImportCardinalityMismatchExceptionDebuggerProxy(System.ComponentModel.Composition.ImportCardinalityMismatchException exception)

### public class System.ComponentModel.Composition.ImportingConstructorAttribute
- Base: System.Attribute

#### Constructors
- public ImportingConstructorAttribute()

### public class System.ComponentModel.Composition.ImportManyAttribute
- Base: System.Attribute
- Interfaces: System.ComponentModel.Composition.IAttributedImport

#### Fields
- private bool <AllowRecomposition>k__BackingField
- private string <ContractName>k__BackingField
- private System.Type <ContractType>k__BackingField
- private System.ComponentModel.Composition.CreationPolicy <RequiredCreationPolicy>k__BackingField
- private System.ComponentModel.Composition.ImportSource <Source>k__BackingField

#### Properties
- public bool AllowRecomposition { get; set; }
- public string ContractName { get; private set; }
- public System.Type ContractType { get; private set; }
- public System.ComponentModel.Composition.CreationPolicy RequiredCreationPolicy { get; set; }
- public System.ComponentModel.Composition.ImportSource Source { get; set; }
- private System.ComponentModel.Composition.Primitives.ImportCardinality System.ComponentModel.Composition.IAttributedImport.Cardinality { get; }

#### Constructors
- public ImportManyAttribute()
- public ImportManyAttribute(System.Type contractType)
- public ImportManyAttribute(string contractName)
- public ImportManyAttribute(string contractName, System.Type contractType)

### public enum System.ComponentModel.Composition.ImportSource
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Any = 0
- Local = 1
- NonLocal = 2

### public class System.ComponentModel.Composition.InheritedExportAttribute
- Base: System.ComponentModel.Composition.ExportAttribute

#### Constructors
- public InheritedExportAttribute()
- public InheritedExportAttribute(System.Type contractType)
- public InheritedExportAttribute(string contractName)
- public InheritedExportAttribute(string contractName, System.Type contractType)

### public interface System.ComponentModel.Composition.IPartImportsSatisfiedNotification

#### Methods
- public void OnImportsSatisfied()

### public class System.ComponentModel.Composition.MetadataAttributeAttribute
- Base: System.Attribute

#### Constructors
- public MetadataAttributeAttribute()

### internal static class System.ComponentModel.Composition.MetadataServices

#### Fields
- public static readonly System.Collections.Generic.IDictionary<string, object> EmptyMetadata

#### Constructors
- private static MetadataServices()

#### Methods
- public static System.Collections.Generic.IDictionary<string, object> AsReadOnly(System.Collections.Generic.IDictionary<string, object> metadata)
- public static T GetValue<T>(System.Collections.Generic.IDictionary<string, object> metadata, string key)

### internal static class System.ComponentModel.Composition.MetadataViewGenerator

#### Fields
- private static System.Type[] CtorArgumentTypes
- public static const string MetadataItemKey
- public static const string MetadataItemSourceType
- public static const string MetadataItemTargetType
- public static const string MetadataItemValue
- public static const string MetadataViewType
- private static readonly System.Reflection.MethodInfo ObjectGetType
- private static System.Reflection.AssemblyName ProxyAssemblyName
- private static System.Reflection.Emit.ModuleBuilder transparentProxyModuleBuilder
- private static Microsoft.Internal.Lock _lock
- private static System.Reflection.MethodInfo _mdvDictionaryTryGet
- private static System.Collections.Generic.Dictionary<System.Type, System.Type> _proxies

#### Constructors
- private static MetadataViewGenerator()

#### Methods
- private static System.Reflection.Emit.AssemblyBuilder CreateProxyAssemblyBuilder(System.Reflection.ConstructorInfo constructorInfo)
- private static void GenerateFieldAssignmentFromLocalValue(System.Reflection.Emit.ILGenerator IL, System.Reflection.Emit.LocalBuilder local, System.Reflection.Emit.FieldBuilder field)
- private static System.Type GenerateInterfaceViewProxyType(System.Type viewType)
- private static void GenerateLocalAssignmentFromDefaultAttribute(System.Reflection.Emit.ILGenerator IL, System.ComponentModel.DefaultValueAttribute[] attrs, System.Reflection.Emit.LocalBuilder local)
- private static void GenerateLocalAssignmentFromFlag(System.Reflection.Emit.ILGenerator IL, System.Reflection.Emit.LocalBuilder local, bool flag)
- public static System.Type GenerateView(System.Type viewType)
- private static System.Reflection.Emit.ModuleBuilder GetProxyModuleBuilder(bool requiresCritical)

### public class System.ComponentModel.Composition.MetadataViewImplementationAttribute
- Base: System.Attribute

#### Fields
- private System.Type <ImplementationType>k__BackingField

#### Properties
- public System.Type ImplementationType { get; private set; }

#### Constructors
- public MetadataViewImplementationAttribute(System.Type implementationType)

### internal static class System.ComponentModel.Composition.MetadataViewProvider

#### Methods
- public static TMetadataView GetMetadataView<TMetadataView>(System.Collections.Generic.IDictionary<string, object> metadata)
- public static bool IsViewTypeValid(System.Type metadataViewType)

### public class System.ComponentModel.Composition.PartCreationPolicyAttribute
- Base: System.Attribute

#### Fields
- private System.ComponentModel.Composition.CreationPolicy <CreationPolicy>k__BackingField
- internal static System.ComponentModel.Composition.PartCreationPolicyAttribute Default
- internal static System.ComponentModel.Composition.PartCreationPolicyAttribute Shared

#### Properties
- public System.ComponentModel.Composition.CreationPolicy CreationPolicy { get; private set; }

#### Constructors
- private static PartCreationPolicyAttribute()
- public PartCreationPolicyAttribute(System.ComponentModel.Composition.CreationPolicy creationPolicy)

### public class System.ComponentModel.Composition.PartMetadataAttribute
- Base: System.Attribute

#### Fields
- private string <Name>k__BackingField
- private object <Value>k__BackingField

#### Properties
- public string Name { get; private set; }
- public object Value { get; private set; }

#### Constructors
- public PartMetadataAttribute(string name, object value)

### public class System.ComponentModel.Composition.PartNotDiscoverableAttribute
- Base: System.Attribute

#### Constructors
- public PartNotDiscoverableAttribute()

### private struct System.ComponentModel.Composition.CompositionException.VisitContext

#### Fields
- public System.Action<System.Collections.Generic.Stack<System.ComponentModel.Composition.CompositionError>> LeafVisitor
- public System.Collections.Generic.Stack<System.ComponentModel.Composition.CompositionError> Path

## Namespace: System.ComponentModel.Composition.AttributedModel

### private class System.ComponentModel.Composition.AttributedModel.AttributedModelDiscovery.<>c__DisplayClass5_0

#### Fields
- public System.Reflection.ParameterInfo parameter

#### Constructors
- public AttributedModelDiscovery.<>c__DisplayClass5_0()

#### Methods
- internal System.Reflection.ParameterInfo <CreateParameterImportDefinition>b__0()
- internal System.Reflection.ParameterInfo <CreateParameterImportDefinition>b__1()

### private class System.ComponentModel.Composition.AttributedModel.AttributedPartCreationInfo.<GetDeclaredOnlyImportMembers>d__38
- Interfaces: System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private System.Reflection.MemberInfo <>2__current
- public System.Type <>3__type
- private System.Reflection.FieldInfo[] <>7__wrap2
- private int <>7__wrap3
- private System.Reflection.PropertyInfo[] <>7__wrap4
- private int <>l__initialThreadId
- private System.Reflection.BindingFlags <flags>5__2
- private System.Type type

#### Properties
- private System.Reflection.MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public AttributedPartCreationInfo.<GetDeclaredOnlyImportMembers>d__38(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class System.ComponentModel.Composition.AttributedModel.AttributedPartCreationInfo.<GetExportMembers>d__32
- Interfaces: System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private System.Reflection.MemberInfo <>2__current
- public System.Type <>3__type
- private System.Reflection.FieldInfo[] <>7__wrap2
- private int <>7__wrap3
- private System.Reflection.PropertyInfo[] <>7__wrap4
- private System.Reflection.MethodInfo[] <>7__wrap5
- private int <>l__initialThreadId
- private System.Reflection.BindingFlags <flags>5__2
- private System.Type type

#### Properties
- private System.Reflection.MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public AttributedPartCreationInfo.<GetExportMembers>d__32(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class System.ComponentModel.Composition.AttributedModel.AttributedPartCreationInfo.<GetImportMembers>d__37
- Interfaces: System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private System.Reflection.MemberInfo <>2__current
- public System.Type <>3__type
- public System.ComponentModel.Composition.AttributedModel.AttributedPartCreationInfo <>4__this
- private System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo> <>7__wrap1
- private int <>l__initialThreadId
- private System.Type <baseType>5__3
- private System.Type type

#### Properties
- private System.Reflection.MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public AttributedPartCreationInfo.<GetImportMembers>d__37(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private void <>m__Finally2()
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class System.ComponentModel.Composition.AttributedModel.AttributedPartCreationInfo.<GetInheritedExports>d__33
- Interfaces: System.Collections.Generic.IEnumerable<System.Type>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Type>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private System.Type <>2__current
- public System.Type <>3__type
- private System.Type[] <>7__wrap2
- private int <>7__wrap3
- private int <>l__initialThreadId
- private System.Type <currentType>5__2
- private System.Type type

#### Properties
- private System.Type System.Collections.Generic.IEnumerator<System.Type>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public AttributedPartCreationInfo.<GetInheritedExports>d__33(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<System.Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### internal class System.ComponentModel.Composition.AttributedModel.AttributedExportDefinition
- Base: System.ComponentModel.Composition.Primitives.ExportDefinition

#### Fields
- private readonly System.ComponentModel.Composition.ExportAttribute _exportAttribute
- private readonly System.Reflection.MemberInfo _member
- private System.Collections.Generic.IDictionary<string, object> _metadata
- private readonly System.ComponentModel.Composition.AttributedModel.AttributedPartCreationInfo _partCreationInfo
- private readonly System.Type _typeIdentityType

#### Properties
- public System.Collections.Generic.IDictionary<string, object> Metadata { get; }

#### Constructors
- public AttributedExportDefinition(System.ComponentModel.Composition.AttributedModel.AttributedPartCreationInfo partCreationInfo, System.Reflection.MemberInfo member, System.ComponentModel.Composition.ExportAttribute exportAttribute, System.Type typeIdentityType, string contractName)

### internal static class System.ComponentModel.Composition.AttributedModel.AttributedModelDiscovery

#### Methods
- public static System.ComponentModel.Composition.ReflectionModel.ReflectionMemberImportDefinition CreateMemberImportDefinition(System.Reflection.MemberInfo member, System.ComponentModel.Composition.Primitives.ICompositionElement origin)
- public static System.ComponentModel.Composition.ReflectionModel.ReflectionParameterImportDefinition CreateParameterImportDefinition(System.Reflection.ParameterInfo parameter, System.ComponentModel.Composition.Primitives.ICompositionElement origin)
- public static System.ComponentModel.Composition.ReflectionModel.ReflectionComposablePart CreatePart(object attributedPart)
- public static System.ComponentModel.Composition.ReflectionModel.ReflectionComposablePart CreatePart(object attributedPart, System.Reflection.ReflectionContext reflectionContext)
- public static System.ComponentModel.Composition.ReflectionModel.ReflectionComposablePart CreatePart(System.ComponentModel.Composition.Primitives.ComposablePartDefinition partDefinition, object attributedPart)
- public static System.ComponentModel.Composition.ReflectionModel.ReflectionComposablePartDefinition CreatePartDefinition(System.Type type, System.ComponentModel.Composition.PartCreationPolicyAttribute partCreationPolicy, bool ignoreConstructorImports, System.ComponentModel.Composition.Primitives.ICompositionElement origin)
- public static System.ComponentModel.Composition.Primitives.ComposablePartDefinition CreatePartDefinitionIfDiscoverable(System.Type type, System.ComponentModel.Composition.Primitives.ICompositionElement origin)
- private static System.ComponentModel.Composition.IAttributedImport GetAttributedImport(System.ComponentModel.Composition.ReflectionModel.ReflectionItem item, System.Reflection.ICustomAttributeProvider attributeProvider)

### internal class System.ComponentModel.Composition.AttributedModel.AttributedPartCreationInfo
- Interfaces: System.ComponentModel.Composition.ReflectionModel.IReflectionPartCreationInfo, System.ComponentModel.Composition.Primitives.ICompositionElement

#### Fields
- private System.Reflection.ConstructorInfo _constructor
- private System.Collections.Generic.HashSet<string> _contractNamesOnNonInterfaces
- private System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> _exports
- private readonly bool _ignoreConstructorImports
- private System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition> _imports
- private readonly System.ComponentModel.Composition.Primitives.ICompositionElement _origin
- private System.ComponentModel.Composition.PartCreationPolicyAttribute _partCreationPolicy
- private readonly System.Type _type

#### Properties
- private System.ComponentModel.Composition.CreationPolicy CreationPolicy { get; }
- public bool IsDisposalRequired { get; }
- private string System.ComponentModel.Composition.Primitives.ICompositionElement.DisplayName { get; }
- private System.ComponentModel.Composition.Primitives.ICompositionElement System.ComponentModel.Composition.Primitives.ICompositionElement.Origin { get; }

#### Constructors
- public AttributedPartCreationInfo(System.Type type, System.ComponentModel.Composition.PartCreationPolicyAttribute partCreationPolicy, bool ignoreConstructorImports, System.ComponentModel.Composition.Primitives.ICompositionElement origin)

#### Methods
- private bool AllExportsHaveMatchingArity()
- private System.ComponentModel.Composition.AttributedModel.AttributedExportDefinition CreateExportDefinition(System.Reflection.MemberInfo member, System.ComponentModel.Composition.ExportAttribute exportAttribute)
- private void DiscoverExportsAndImports()
- public System.Reflection.ConstructorInfo GetConstructor()
- private System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> GetDeclaredOnlyImportMembers(System.Type type)
- private string GetDisplayName()
- private System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> GetExportDefinitions()
- private System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> GetExportMembers(System.Type type)
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> GetExports()
- private System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition> GetImportDefinitions()
- private System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> GetImportMembers(System.Type type)
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition> GetImports()
- private System.Collections.Generic.IEnumerable<System.Type> GetInheritedExports(System.Type type)
- public System.Lazy<System.Type> GetLazyPartType()
- public System.Collections.Generic.IDictionary<string, object> GetMetadata()
- public System.Type GetPartType()
- private bool HasExports()
- private static bool IsExport(System.Reflection.ICustomAttributeProvider attributeProvider)
- private static bool IsImport(System.Reflection.ICustomAttributeProvider attributeProvider)
- private static bool IsInheritedExport(System.Reflection.ICustomAttributeProvider attributedProvider)
- public bool IsPartDiscoverable()
- private static System.Reflection.ConstructorInfo SelectPartConstructor(System.Type type)
- public override string ToString()

## Namespace: System.ComponentModel.Composition.Diagnostics

### internal static class System.ComponentModel.Composition.Diagnostics.CompositionTrace

#### Methods
- internal static void AssemblyLoadFailed(System.ComponentModel.Composition.Hosting.DirectoryCatalog catalog, string fileName, System.Exception exception)
- internal static void DefinitionContainsNoExports(System.Type type)
- internal static void DefinitionMarkedWithPartNotDiscoverableAttribute(System.Type type)
- internal static void DefinitionMismatchedExportArity(System.Type type, System.Reflection.MemberInfo member)
- internal static void MemberMarkedWithMultipleImportAndImportMany(System.ComponentModel.Composition.ReflectionModel.ReflectionItem item)
- internal static void PartDefinitionRejected(System.ComponentModel.Composition.Primitives.ComposablePartDefinition definition, System.ComponentModel.Composition.ChangeRejectedException exception)
- internal static void PartDefinitionResurrected(System.ComponentModel.Composition.Primitives.ComposablePartDefinition definition)

### internal enum System.ComponentModel.Composition.Diagnostics.CompositionTraceId
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Discovery_AssemblyLoadFailed = 3
- Discovery_DefinitionContainsNoExports = 6
- Discovery_DefinitionMarkedWithPartNotDiscoverableAttribute = 4
- Discovery_DefinitionMismatchedExportArity = 5
- Discovery_MemberMarkedWithMultipleImportAndImportMany = 7
- Rejection_DefinitionRejected = 1
- Rejection_DefinitionResurrected = 2

### internal static class System.ComponentModel.Composition.Diagnostics.CompositionTraceSource

#### Fields
- private static readonly System.ComponentModel.Composition.Diagnostics.DebuggerTraceWriter Source

#### Properties
- public static bool CanWriteError { get; }
- public static bool CanWriteInformation { get; }
- public static bool CanWriteWarning { get; }

#### Constructors
- private static CompositionTraceSource()

#### Methods
- private static void EnsureEnabled(bool condition)
- public static void WriteError(System.ComponentModel.Composition.Diagnostics.CompositionTraceId traceId, string format, params object[] arguments)
- public static void WriteInformation(System.ComponentModel.Composition.Diagnostics.CompositionTraceId traceId, string format, params object[] arguments)
- public static void WriteWarning(System.ComponentModel.Composition.Diagnostics.CompositionTraceId traceId, string format, params object[] arguments)

### internal class System.ComponentModel.Composition.Diagnostics.DebuggerTraceWriter
- Base: System.ComponentModel.Composition.Diagnostics.TraceWriter

#### Fields
- private static readonly string SourceName

#### Properties
- public bool CanWriteError { get; }
- public bool CanWriteInformation { get; }
- public bool CanWriteWarning { get; }

#### Constructors
- public DebuggerTraceWriter()
- private static DebuggerTraceWriter()

#### Methods
- internal static string CreateLogMessage(System.ComponentModel.Composition.Diagnostics.DebuggerTraceWriter.TraceEventType eventType, System.ComponentModel.Composition.Diagnostics.CompositionTraceId traceId, string format, params object[] arguments)
- public override void WriteError(System.ComponentModel.Composition.Diagnostics.CompositionTraceId traceId, string format, params object[] arguments)
- private static void WriteEvent(System.ComponentModel.Composition.Diagnostics.DebuggerTraceWriter.TraceEventType eventType, System.ComponentModel.Composition.Diagnostics.CompositionTraceId traceId, string format, params object[] arguments)
- public override void WriteInformation(System.ComponentModel.Composition.Diagnostics.CompositionTraceId traceId, string format, params object[] arguments)
- public override void WriteWarning(System.ComponentModel.Composition.Diagnostics.CompositionTraceId traceId, string format, params object[] arguments)

### internal enum System.ComponentModel.Composition.Diagnostics.DebuggerTraceWriter.TraceEventType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Error = 2
- Information = 8
- Warning = 4

### internal class System.ComponentModel.Composition.Diagnostics.TraceWriter

#### Properties
- public bool CanWriteError { get; }
- public bool CanWriteInformation { get; }
- public bool CanWriteWarning { get; }

#### Constructors
- protected TraceWriter()

#### Methods
- public abstract void WriteError(System.ComponentModel.Composition.Diagnostics.CompositionTraceId traceId, string format, params object[] arguments)
- public abstract void WriteInformation(System.ComponentModel.Composition.Diagnostics.CompositionTraceId traceId, string format, params object[] arguments)
- public abstract void WriteWarning(System.ComponentModel.Composition.Diagnostics.CompositionTraceId traceId, string format, params object[] arguments)

## Namespace: System.ComponentModel.Composition.Hosting

### private class System.ComponentModel.Composition.Hosting.AggregateCatalog.<>c

#### Fields
- public static readonly System.ComponentModel.Composition.Hosting.AggregateCatalog.<>c <>9
- public static System.Func<System.ComponentModel.Composition.Primitives.ComposablePartCatalog, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>> <>9__15_0

#### Constructors
- private static AggregateCatalog.<>c()
- public AggregateCatalog.<>c()

#### Methods
- internal System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> <GetEnumerator>b__15_0(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog)

### private class System.ComponentModel.Composition.Hosting.CatalogExportProvider.<>c

#### Fields
- public static readonly System.ComponentModel.Composition.Hosting.CatalogExportProvider.<>c <>9
- public static System.Func<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Hosting.CatalogExportProvider.AtomicCompositionQueryState> <>9__49_0

#### Constructors
- private static CatalogExportProvider.<>c()
- public CatalogExportProvider.<>c()

#### Methods
- internal System.ComponentModel.Composition.Hosting.CatalogExportProvider.AtomicCompositionQueryState <GetAtomicCompositionQuery>b__49_0(System.ComponentModel.Composition.Primitives.ComposablePartDefinition definition)

### private class System.ComponentModel.Composition.Hosting.ComposablePartCatalogCollection.<>c

#### Fields
- public static readonly System.ComponentModel.Composition.Hosting.ComposablePartCatalogCollection.<>c <>9
- public static System.Func<System.ComponentModel.Composition.Primitives.ComposablePartCatalog, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>> <>9__15_1
- public static System.Action<System.ComponentModel.Composition.Primitives.ComposablePartCatalog> <>9__28_0

#### Constructors
- private static ComposablePartCatalogCollection.<>c()
- public ComposablePartCatalogCollection.<>c()

#### Methods
- internal System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> <Clear>b__15_1(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog)
- internal void <Dispose>b__28_0(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog)

### private class System.ComponentModel.Composition.Hosting.ComposablePartExportProvider.<>c

#### Fields
- public static readonly System.ComponentModel.Composition.Hosting.ComposablePartExportProvider.<>c <>9
- public static System.Func<System.ComponentModel.Composition.Primitives.ComposablePart, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition>> <>9__21_0
- public static System.Func<System.ComponentModel.Composition.Primitives.ComposablePart, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition>> <>9__21_1

#### Constructors
- private static ComposablePartExportProvider.<>c()
- public ComposablePartExportProvider.<>c()

#### Methods
- internal System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> <Recompose>b__21_0(System.ComponentModel.Composition.Primitives.ComposablePart part)
- internal System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> <Recompose>b__21_1(System.ComponentModel.Composition.Primitives.ComposablePart part)

### private class System.ComponentModel.Composition.Hosting.CompositionScopeDefinition.<>c

#### Fields
- public static readonly System.ComponentModel.Composition.Hosting.CompositionScopeDefinition.<>c <>9
- public static System.Func<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition>> <>9__12_0

#### Constructors
- private static CompositionScopeDefinition.<>c()
- public CompositionScopeDefinition.<>c()

#### Methods
- internal System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> <get_PublicSurface>b__12_0(System.ComponentModel.Composition.Primitives.ComposablePartDefinition p)

### private class System.ComponentModel.Composition.Hosting.CompositionServices.<>c

#### Fields
- public static readonly System.ComponentModel.Composition.Hosting.CompositionServices.<>c <>9
- public static System.Func<System.Reflection.PropertyInfo, bool> <>9__20_0
- public static System.Func<System.Reflection.PropertyInfo, System.Collections.Generic.KeyValuePair<string, System.Type>> <>9__20_1
- public static System.Func<System.ComponentModel.Composition.Primitives.ImportDefinition, bool> <>9__24_0

#### Constructors
- private static CompositionServices.<>c()
- public CompositionServices.<>c()

#### Methods
- internal bool <GetRequiredMetadata>b__20_0(System.Reflection.PropertyInfo property)
- internal System.Collections.Generic.KeyValuePair<string, System.Type> <GetRequiredMetadata>b__20_1(System.Reflection.PropertyInfo property)
- internal bool <IsRecomposable>b__24_0(System.ComponentModel.Composition.Primitives.ImportDefinition import)

### private class System.ComponentModel.Composition.Hosting.DirectoryCatalog.DirectoryCatalogDebuggerProxy.<>c

#### Fields
- public static readonly System.ComponentModel.Composition.Hosting.DirectoryCatalog.DirectoryCatalogDebuggerProxy.<>c <>9
- public static System.Func<System.ComponentModel.Composition.Hosting.AssemblyCatalog, System.Reflection.Assembly> <>9__3_0

#### Constructors
- private static DirectoryCatalog.DirectoryCatalogDebuggerProxy.<>c()
- public DirectoryCatalog.DirectoryCatalogDebuggerProxy.<>c()

#### Methods
- internal System.Reflection.Assembly <get_Assemblies>b__3_0(System.ComponentModel.Composition.Hosting.AssemblyCatalog catalog)

### private class System.ComponentModel.Composition.Hosting.DirectoryCatalog.<>c

#### Fields
- public static readonly System.ComponentModel.Composition.Hosting.DirectoryCatalog.<>c <>9
- public static System.Func<System.ComponentModel.Composition.Primitives.ComposablePartCatalog, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>> <>9__34_0
- public static System.Func<System.Tuple<string, System.ComponentModel.Composition.Hosting.AssemblyCatalog>, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>> <>9__38_0
- public static System.Func<System.Tuple<string, System.ComponentModel.Composition.Hosting.AssemblyCatalog>, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>> <>9__38_1

#### Constructors
- private static DirectoryCatalog.<>c()
- public DirectoryCatalog.<>c()

#### Methods
- internal System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> <GetEnumerator>b__34_0(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog)
- internal System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> <Refresh>b__38_0(System.Tuple<string, System.ComponentModel.Composition.Hosting.AssemblyCatalog> cat)
- internal System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> <Refresh>b__38_1(System.Tuple<string, System.ComponentModel.Composition.Hosting.AssemblyCatalog> cat)

### private class System.ComponentModel.Composition.Hosting.ExportsChangeEventArgs.<>c

#### Fields
- public static readonly System.ComponentModel.Composition.Hosting.ExportsChangeEventArgs.<>c <>9
- public static System.Func<System.ComponentModel.Composition.Primitives.ExportDefinition, string> <>9__9_0

#### Constructors
- private static ExportsChangeEventArgs.<>c()
- public ExportsChangeEventArgs.<>c()

#### Methods
- internal string <get_ChangedContractNames>b__9_0(System.ComponentModel.Composition.Primitives.ExportDefinition export)

### private class System.ComponentModel.Composition.Hosting.FilteredCatalog.<>c

#### Fields
- public static readonly System.ComponentModel.Composition.Hosting.FilteredCatalog.<>c <>9
- public static System.Func<System.ComponentModel.Composition.Primitives.ImportDefinition, bool> <>9__3_0
- public static System.Func<System.ComponentModel.Composition.Primitives.ImportDefinition, bool> <>9__5_0

#### Constructors
- private static FilteredCatalog.<>c()
- public FilteredCatalog.<>c()

#### Methods
- internal bool <IncludeDependencies>b__3_0(System.ComponentModel.Composition.Primitives.ImportDefinition i)
- internal bool <IncludeDependents>b__5_0(System.ComponentModel.Composition.Primitives.ImportDefinition i)

### private class System.ComponentModel.Composition.Hosting.ImportEngine.PartManager.<>c

#### Fields
- public static readonly System.ComponentModel.Composition.Hosting.ImportEngine.PartManager.<>c <>9
- public static System.Func<System.ComponentModel.Composition.Primitives.ImportDefinition, string> <>9__16_0
- public static System.Action<System.IDisposable> <>9__22_0
- public static System.Func<System.Collections.Generic.List<System.IDisposable>, System.Collections.Generic.IEnumerable<System.IDisposable>> <>9__23_0
- public static System.Action<System.IDisposable> <>9__23_1

#### Constructors
- private static ImportEngine.PartManager.<>c()
- public ImportEngine.PartManager.<>c()

#### Methods
- internal System.Collections.Generic.IEnumerable<System.IDisposable> <DisposeAllDependencies>b__23_0(System.Collections.Generic.List<System.IDisposable> exports)
- internal void <DisposeAllDependencies>b__23_1(System.IDisposable disposableExport)
- internal string <GetImportedContractNames>b__16_0(System.ComponentModel.Composition.Primitives.ImportDefinition import)
- internal void <UpdateDisposableDependencies>b__22_0(System.IDisposable disposable)

### private class System.ComponentModel.Composition.Hosting.ImportEngine.<>c

#### Fields
- public static readonly System.ComponentModel.Composition.Hosting.ImportEngine.<>c <>9
- public static System.Func<System.ComponentModel.Composition.Primitives.ImportDefinition, bool> <>9__21_0
- public static System.Func<System.ComponentModel.Composition.Primitives.ImportDefinition, bool> <>9__21_1

#### Constructors
- private static ImportEngine.<>c()
- public ImportEngine.<>c()

#### Methods
- internal bool <TrySatisfyImportsStateMachine>b__21_0(System.ComponentModel.Composition.Primitives.ImportDefinition import)
- internal bool <TrySatisfyImportsStateMachine>b__21_1(System.ComponentModel.Composition.Primitives.ImportDefinition import)

### private class System.ComponentModel.Composition.Hosting.TypeCatalog.<>c

#### Fields
- public static readonly System.ComponentModel.Composition.Hosting.TypeCatalog.<>c <>9
- public static System.Func<System.ComponentModel.Composition.Primitives.ExportDefinition, string> <>9__22_0

#### Constructors
- private static TypeCatalog.<>c()
- public TypeCatalog.<>c()

#### Methods
- internal string <CreateIndex>b__22_0(System.ComponentModel.Composition.Primitives.ExportDefinition export)

### private class System.ComponentModel.Composition.Hosting.ImportEngine.<>c__DisplayClass14_0

#### Fields
- public System.IDisposable compositionLockHolder

#### Constructors
- public ImportEngine.<>c__DisplayClass14_0()

#### Methods
- internal void <PreviewImports>b__0()
- internal void <PreviewImports>b__1()

### private class System.ComponentModel.Composition.Hosting.ComposablePartCatalogCollection.<>c__DisplayClass15_0

#### Fields
- public System.ComponentModel.Composition.Primitives.ComposablePartCatalog[] catalogs

#### Constructors
- public ComposablePartCatalogCollection.<>c__DisplayClass15_0()

#### Methods
- internal System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> <Clear>b__0()

### private class System.ComponentModel.Composition.Hosting.ImportEngine.PartManager.<>c__DisplayClass18_0

#### Fields
- public System.ComponentModel.Composition.Hosting.ImportEngine.PartManager <>4__this
- public System.ComponentModel.Composition.Primitives.ImportDefinition import
- public System.ComponentModel.Composition.Primitives.Export[] savedExports

#### Constructors
- public ImportEngine.PartManager.<>c__DisplayClass18_0()

#### Methods
- internal void <SetSavedImport>b__0()

### private class System.ComponentModel.Composition.Hosting.ComposablePartExportProvider.<>c__DisplayClass19_0

#### Fields
- public System.ComponentModel.Composition.Hosting.ComposablePartExportProvider <>4__this
- public System.ComponentModel.Composition.Primitives.ComposablePart part

#### Constructors
- public ComposablePartExportProvider.<>c__DisplayClass19_0()

#### Methods
- internal void <Compose>b__0()

### private class System.ComponentModel.Composition.Hosting.FilteredCatalog.<>c__DisplayClass19_0

#### Fields
- public System.Func<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, bool> filter

#### Constructors
- public FilteredCatalog.<>c__DisplayClass19_0()

#### Methods
- internal bool <.ctor>b__0(System.ComponentModel.Composition.Primitives.ComposablePartDefinition p)

### private class System.ComponentModel.Composition.Hosting.ImportEngine.<>c__DisplayClass20_0

#### Fields
- public System.ComponentModel.Composition.Hosting.ImportEngine.PartManager partManager

#### Constructors
- public ImportEngine.<>c__DisplayClass20_0()

#### Methods
- internal void <TryPreviewImportsStateMachine>b__0()

### private class System.ComponentModel.Composition.Hosting.ComposablePartExportProvider.<>c__DisplayClass21_0

#### Fields
- public System.ComponentModel.Composition.Hosting.ComposablePartExportProvider <>4__this
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> addedExports
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> removedExports

#### Constructors
- public ComposablePartExportProvider.<>c__DisplayClass21_0()

#### Methods
- internal void <Recompose>b__2()

### private class System.ComponentModel.Composition.Hosting.ComposablePartCatalogCollection.<>c__DisplayClass22_0

#### Fields
- public System.ComponentModel.Composition.Primitives.ComposablePartCatalog item

#### Constructors
- public ComposablePartCatalogCollection.<>c__DisplayClass22_0()

#### Methods
- internal System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> <Remove>b__0()

### private class System.ComponentModel.Composition.Hosting.ComposablePartExportProvider.<>c__DisplayClass22_0

#### Fields
- public System.ComponentModel.Composition.Hosting.ComposablePartExportProvider <>4__this
- public System.ComponentModel.Composition.Primitives.ExportDefinition export
- public System.ComponentModel.Composition.Primitives.ComposablePart part

#### Constructors
- public ComposablePartExportProvider.<>c__DisplayClass22_0()

#### Methods
- internal object <CreateExport>b__0()

### private class System.ComponentModel.Composition.Hosting.ImportEngine.<>c__DisplayClass25_0

#### Fields
- public System.ComponentModel.Composition.Hosting.ImportEngine.PartManager partManager

#### Constructors
- public ImportEngine.<>c__DisplayClass25_0()

#### Methods
- internal void <TryRecomposeImports>b__0()

### private class System.ComponentModel.Composition.Hosting.ImportEngine.<>c__DisplayClass26_0

#### Fields
- public System.ComponentModel.Composition.Primitives.Export[] exports
- public System.ComponentModel.Composition.Primitives.ImportDefinition import
- public System.ComponentModel.Composition.Hosting.ImportEngine.PartManager partManager

#### Constructors
- public ImportEngine.<>c__DisplayClass26_0()

#### Methods
- internal void <TryRecomposeImport>b__0()

### private class System.ComponentModel.Composition.Hosting.CatalogExportProvider.<>c__DisplayClass35_0

#### Fields
- public System.ComponentModel.Composition.Hosting.CatalogExportProvider <>4__this
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> addedExports
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> removedExports

#### Constructors
- public CatalogExportProvider.<>c__DisplayClass35_0()

#### Methods
- internal void <OnCatalogChanging>b__0()

### private class System.ComponentModel.Composition.Hosting.DirectoryCatalog.<>c__DisplayClass35_0

#### Fields
- public System.ComponentModel.Composition.Primitives.ImportDefinition definition

#### Constructors
- public DirectoryCatalog.<>c__DisplayClass35_0()

#### Methods
- internal System.Collections.Generic.IEnumerable<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>> <GetExports>b__0(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog)

### private class System.ComponentModel.Composition.Hosting.CatalogExportProvider.<>c__DisplayClass35_1

#### Fields
- public System.ComponentModel.Composition.Primitives.ComposablePartDefinition capturedDefinition
- public System.ComponentModel.Composition.Hosting.CatalogExportProvider.<>c__DisplayClass35_0 CS$<>8__locals1

#### Constructors
- public CatalogExportProvider.<>c__DisplayClass35_1()

#### Methods
- internal void <OnCatalogChanging>b__1()

### private class System.ComponentModel.Composition.Hosting.CatalogExportProvider.<>c__DisplayClass39_0

#### Fields
- public System.ComponentModel.Composition.Hosting.CatalogExportProvider <>4__this
- public System.IDisposable diposablePart
- public object exportedValue

#### Constructors
- public CatalogExportProvider.<>c__DisplayClass39_0()

#### Methods
- internal void <ReleasePart>b__0()
- internal void <ReleasePart>b__1()

### private class System.ComponentModel.Composition.Hosting.CatalogExportProvider.<>c__DisplayClass43_0

#### Fields
- public System.ComponentModel.Composition.Hosting.CatalogExportProvider <>4__this
- public System.ComponentModel.Composition.Primitives.ComposablePartDefinition definition
- public System.ComponentModel.Composition.ChangeRejectedException exception

#### Constructors
- public CatalogExportProvider.<>c__DisplayClass43_0()

#### Methods
- internal void <DetermineRejection>b__0()
- internal bool <DetermineRejection>b__1(System.ComponentModel.Composition.Primitives.ComposablePartDefinition def)
- internal bool <DetermineRejection>b__2(System.ComponentModel.Composition.Primitives.ComposablePartDefinition def)

### private class System.ComponentModel.Composition.Hosting.CatalogExportProvider.<>c__DisplayClass43_1

#### Fields
- public System.ComponentModel.Composition.Hosting.CatalogExportProvider.<>c__DisplayClass43_0 CS$<>8__locals1
- public System.ComponentModel.Composition.Primitives.ComposablePart newPart

#### Constructors
- public CatalogExportProvider.<>c__DisplayClass43_1()

#### Methods
- internal void <DetermineRejection>b__3()

### private class System.ComponentModel.Composition.Hosting.CatalogExportProvider.<>c__DisplayClass44_0

#### Fields
- public System.ComponentModel.Composition.Hosting.CatalogExportProvider <>4__this
- public System.Collections.Generic.HashSet<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> affectedRejections
- public System.Collections.Generic.List<System.ComponentModel.Composition.Primitives.ExportDefinition> resurrectedExports

#### Constructors
- public CatalogExportProvider.<>c__DisplayClass44_0()

#### Methods
- internal bool <UpdateRejections>b__0(System.ComponentModel.Composition.Primitives.ComposablePartDefinition def)
- internal void <UpdateRejections>b__1()

### private class System.ComponentModel.Composition.Hosting.CatalogExportProvider.<>c__DisplayClass44_1

#### Fields
- public System.ComponentModel.Composition.Primitives.ImportDefinition import

#### Constructors
- public CatalogExportProvider.<>c__DisplayClass44_1()

#### Methods
- internal bool <UpdateRejections>b__2(System.ComponentModel.Composition.Primitives.ExportDefinition export)

### private class System.ComponentModel.Composition.Hosting.CatalogExportProvider.<>c__DisplayClass44_2

#### Fields
- public System.ComponentModel.Composition.Primitives.ComposablePartDefinition capturedPartDefinition
- public System.ComponentModel.Composition.Hosting.CatalogExportProvider.<>c__DisplayClass44_0 CS$<>8__locals1

#### Constructors
- public CatalogExportProvider.<>c__DisplayClass44_2()

#### Methods
- internal void <UpdateRejections>b__3()

### private class System.ComponentModel.Composition.Hosting.CatalogExportProvider.<>c__DisplayClass50_0

#### Fields
- public System.Func<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Hosting.CatalogExportProvider.AtomicCompositionQueryState> parentQuery
- public System.Func<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, bool> query
- public System.ComponentModel.Composition.Hosting.CatalogExportProvider.AtomicCompositionQueryState state

#### Constructors
- public CatalogExportProvider.<>c__DisplayClass50_0()

#### Methods
- internal System.ComponentModel.Composition.Hosting.CatalogExportProvider.AtomicCompositionQueryState <UpdateAtomicCompositionQuery>b__0(System.ComponentModel.Composition.Primitives.ComposablePartDefinition definition)

### private class System.ComponentModel.Composition.Hosting.ImportEngine.RecompositionManager.<>c__DisplayClass6_0

#### Fields
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> changedExports

#### Constructors
- public ImportEngine.RecompositionManager.<>c__DisplayClass6_0()

#### Methods
- internal bool <GetAffectedImports>b__0(System.ComponentModel.Composition.Primitives.ImportDefinition import)

### private class System.ComponentModel.Composition.Hosting.FilteredCatalog.<>c__DisplayClass7_0

#### Fields
- public System.Collections.Generic.HashSet<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> traversalClosure

#### Constructors
- public FilteredCatalog.<>c__DisplayClass7_0()

#### Methods
- internal bool <Traverse>b__0(System.ComponentModel.Composition.Primitives.ComposablePartDefinition p)

### private class System.ComponentModel.Composition.Hosting.ComposablePartCatalogCollection.<>c__DisplayClass8_0

#### Fields
- public System.ComponentModel.Composition.Primitives.ComposablePartCatalog item

#### Constructors
- public ComposablePartCatalogCollection.<>c__DisplayClass8_0()

#### Methods
- internal System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> <Add>b__0()

### public class System.ComponentModel.Composition.Hosting.AggregateCatalog
- Base: System.ComponentModel.Composition.Primitives.ComposablePartCatalog
- Interfaces: System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>, System.Collections.IEnumerable, System.IDisposable, System.ComponentModel.Composition.Hosting.INotifyComposablePartCatalogChanged

#### Fields
- private System.ComponentModel.Composition.Hosting.ComposablePartCatalogCollection _catalogs
- private int _isDisposed

#### Properties
- public System.Collections.Generic.ICollection<System.ComponentModel.Composition.Primitives.ComposablePartCatalog> Catalogs { get; }

#### Events
- public event System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changed
- public event System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changing

#### Constructors
- public AggregateCatalog()
- public AggregateCatalog(params System.ComponentModel.Composition.Primitives.ComposablePartCatalog[] catalogs)
- public AggregateCatalog(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartCatalog> catalogs)

#### Methods
- protected override void Dispose(bool disposing)
- public override System.Collections.Generic.IEnumerator<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> GetEnumerator()
- public override System.Collections.Generic.IEnumerable<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>> GetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition)
- protected virtual void OnChanged(System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e)
- protected virtual void OnChanging(System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e)
- private void ThrowIfDisposed()

### public class System.ComponentModel.Composition.Hosting.AggregateExportProvider
- Base: System.ComponentModel.Composition.Hosting.ExportProvider
- Interfaces: System.IDisposable

#### Fields
- private int _isDisposed
- private readonly System.ComponentModel.Composition.Hosting.ExportProvider[] _providers
- private readonly System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.Hosting.ExportProvider> _readOnlyProviders

#### Properties
- public System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.Hosting.ExportProvider> Providers { get; }

#### Constructors
- public AggregateExportProvider(params System.ComponentModel.Composition.Hosting.ExportProvider[] providers)
- public AggregateExportProvider(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Hosting.ExportProvider> providers)

#### Methods
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- protected override System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> GetExportsCore(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- private void OnExportChangedInternal(object sender, System.ComponentModel.Composition.Hosting.ExportsChangeEventArgs e)
- private void OnExportChangingInternal(object sender, System.ComponentModel.Composition.Hosting.ExportsChangeEventArgs e)
- private void ThrowIfDisposed()

### public class System.ComponentModel.Composition.Hosting.ApplicationCatalog
- Base: System.ComponentModel.Composition.Primitives.ComposablePartCatalog
- Interfaces: System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>, System.Collections.IEnumerable, System.IDisposable, System.ComponentModel.Composition.Primitives.ICompositionElement

#### Fields
- private System.ComponentModel.Composition.Primitives.ICompositionElement _definitionOrigin
- private System.ComponentModel.Composition.Hosting.AggregateCatalog _innerCatalog
- private bool _isDisposed
- private System.Reflection.ReflectionContext _reflectionContext
- private readonly object _thisLock

#### Properties
- private System.ComponentModel.Composition.Hosting.AggregateCatalog InnerCatalog { get; }
- private string System.ComponentModel.Composition.Primitives.ICompositionElement.DisplayName { get; }
- private System.ComponentModel.Composition.Primitives.ICompositionElement System.ComponentModel.Composition.Primitives.ICompositionElement.Origin { get; }

#### Constructors
- public ApplicationCatalog()
- public ApplicationCatalog(System.ComponentModel.Composition.Primitives.ICompositionElement definitionOrigin)
- public ApplicationCatalog(System.Reflection.ReflectionContext reflectionContext)
- public ApplicationCatalog(System.Reflection.ReflectionContext reflectionContext, System.ComponentModel.Composition.Primitives.ICompositionElement definitionOrigin)

#### Methods
- internal System.ComponentModel.Composition.Primitives.ComposablePartCatalog CreateCatalog(string location, string pattern)
- protected override void Dispose(bool disposing)
- private string GetDisplayName()
- public override System.Collections.Generic.IEnumerator<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> GetEnumerator()
- public override System.Collections.Generic.IEnumerable<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>> GetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition)
- private void ThrowIfDisposed()
- public override string ToString()

### public class System.ComponentModel.Composition.Hosting.AssemblyCatalog
- Base: System.ComponentModel.Composition.Primitives.ComposablePartCatalog
- Interfaces: System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>, System.Collections.IEnumerable, System.IDisposable, System.ComponentModel.Composition.Primitives.ICompositionElement

#### Fields
- private System.Reflection.Assembly _assembly
- private readonly System.ComponentModel.Composition.Primitives.ICompositionElement _definitionOrigin
- private System.ComponentModel.Composition.Primitives.ComposablePartCatalog _innerCatalog
- private int _isDisposed
- private System.Reflection.ReflectionContext _reflectionContext
- private readonly object _thisLock

#### Properties
- public System.Reflection.Assembly Assembly { get; }
- private System.ComponentModel.Composition.Primitives.ComposablePartCatalog InnerCatalog { get; }
- private string System.ComponentModel.Composition.Primitives.ICompositionElement.DisplayName { get; }
- private System.ComponentModel.Composition.Primitives.ICompositionElement System.ComponentModel.Composition.Primitives.ICompositionElement.Origin { get; }

#### Constructors
- public AssemblyCatalog(string codeBase)
- public AssemblyCatalog(System.Reflection.Assembly assembly)
- public AssemblyCatalog(string codeBase, System.Reflection.ReflectionContext reflectionContext)
- public AssemblyCatalog(string codeBase, System.ComponentModel.Composition.Primitives.ICompositionElement definitionOrigin)
- public AssemblyCatalog(System.Reflection.Assembly assembly, System.Reflection.ReflectionContext reflectionContext)
- public AssemblyCatalog(System.Reflection.Assembly assembly, System.ComponentModel.Composition.Primitives.ICompositionElement definitionOrigin)
- public AssemblyCatalog(string codeBase, System.Reflection.ReflectionContext reflectionContext, System.ComponentModel.Composition.Primitives.ICompositionElement definitionOrigin)
- public AssemblyCatalog(System.Reflection.Assembly assembly, System.Reflection.ReflectionContext reflectionContext, System.ComponentModel.Composition.Primitives.ICompositionElement definitionOrigin)

#### Methods
- protected override void Dispose(bool disposing)
- private string GetDisplayName()
- public override System.Collections.Generic.IEnumerator<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> GetEnumerator()
- public override System.Collections.Generic.IEnumerable<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>> GetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition)
- private void InitializeAssemblyCatalog(System.Reflection.Assembly assembly)
- private static System.Reflection.Assembly LoadAssembly(string codeBase)
- private void ThrowIfDisposed()
- public override string ToString()

### internal class System.ComponentModel.Composition.Hosting.AssemblyCatalogDebuggerProxy

#### Fields
- private readonly System.ComponentModel.Composition.Hosting.AssemblyCatalog _catalog

#### Properties
- public System.Reflection.Assembly Assembly { get; }
- public System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> Parts { get; }

#### Constructors
- public AssemblyCatalogDebuggerProxy(System.ComponentModel.Composition.Hosting.AssemblyCatalog catalog)

### public class System.ComponentModel.Composition.Hosting.AtomicComposition
- Interfaces: System.IDisposable

#### Fields
- private System.Collections.Generic.List<System.Action> _completeActionList
- private bool _containsInnerAtomicComposition
- private bool _isCompleted
- private bool _isDisposed
- private readonly System.ComponentModel.Composition.Hosting.AtomicComposition _outerAtomicComposition
- private System.Collections.Generic.List<System.Action> _revertActionList
- private int _valueCount
- private System.Collections.Generic.KeyValuePair<object, object>[] _values

#### Properties
- private bool ContainsInnerAtomicComposition { set; }

#### Constructors
- public AtomicComposition()
- public AtomicComposition(System.ComponentModel.Composition.Hosting.AtomicComposition outerAtomicComposition)

#### Methods
- public void AddCompleteAction(System.Action completeAction)
- public void AddRevertAction(System.Action revertAction)
- public void Complete()
- private void CopyComplete()
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- private void FinalComplete()
- public void SetValue(object key, object value)
- private void SetValueInternal(object key, object value)
- private void ThrowIfCompleted()
- private void ThrowIfContainsInnerAtomicComposition()
- private void ThrowIfDisposed()
- public bool TryGetValue<T>(object key, out T value)
- public bool TryGetValue<T>(object key, bool localAtomicCompositionOnly, out T value)
- private bool TryGetValueInternal<T>(object key, bool localAtomicCompositionOnly, out T value)

### internal static class System.ComponentModel.Composition.Hosting.AtomicCompositionExtensions

#### Methods
- internal static void AddCompleteActionAllowNull(System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition, System.Action action)
- internal static void AddRevertActionAllowNull(System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition, System.Action action)
- internal static T GetValueAllowNull<T>(System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition, T defaultResultAndKey)
- internal static T GetValueAllowNull<T>(System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition, object key, T defaultResult)

### private enum System.ComponentModel.Composition.Hosting.CatalogExportProvider.AtomicCompositionQueryState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- NeedsTesting = 3
- TreatAsRejected = 1
- TreatAsValidated = 2
- Unknown = 0

### private class System.ComponentModel.Composition.Hosting.CatalogExportProvider.CatalogChangeProxy
- Base: System.ComponentModel.Composition.Primitives.ComposablePartCatalog
- Interfaces: System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>, System.Collections.IEnumerable, System.IDisposable

#### Fields
- private System.Collections.Generic.List<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> _addedParts
- private System.ComponentModel.Composition.Primitives.ComposablePartCatalog _originalCatalog
- private System.Collections.Generic.HashSet<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> _removedParts

#### Constructors
- public CatalogExportProvider.CatalogChangeProxy(System.ComponentModel.Composition.Primitives.ComposablePartCatalog originalCatalog, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> addedParts, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> removedParts)

#### Methods
- private bool <GetExports>b__5_0(System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition> partAndExport)
- public override System.Collections.Generic.IEnumerator<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> GetEnumerator()
- public override System.Collections.Generic.IEnumerable<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>> GetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition)

### private class System.ComponentModel.Composition.Hosting.CatalogExportProvider.CatalogExport
- Base: System.ComponentModel.Composition.Primitives.Export

#### Fields
- protected readonly System.ComponentModel.Composition.Hosting.CatalogExportProvider _catalogExportProvider
- protected readonly System.ComponentModel.Composition.Primitives.ExportDefinition _definition
- protected readonly System.ComponentModel.Composition.Primitives.ComposablePartDefinition _partDefinition

#### Properties
- public System.ComponentModel.Composition.Primitives.ExportDefinition Definition { get; }
- protected bool IsSharedPart { get; }

#### Constructors
- public CatalogExportProvider.CatalogExport(System.ComponentModel.Composition.Hosting.CatalogExportProvider catalogExportProvider, System.ComponentModel.Composition.Primitives.ComposablePartDefinition partDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition definition)

#### Methods
- public static System.ComponentModel.Composition.Hosting.CatalogExportProvider.CatalogExport CreateExport(System.ComponentModel.Composition.Hosting.CatalogExportProvider catalogExportProvider, System.ComponentModel.Composition.Primitives.ComposablePartDefinition partDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition definition, System.ComponentModel.Composition.CreationPolicy importCreationPolicy)
- protected override object GetExportedValueCore()
- protected virtual System.ComponentModel.Composition.Hosting.CatalogExportProvider.CatalogPart GetPart()
- protected System.ComponentModel.Composition.Hosting.CatalogExportProvider.CatalogPart GetPartCore()
- protected void ReleasePartCore(System.ComponentModel.Composition.Hosting.CatalogExportProvider.CatalogPart part, object value)
- private static bool ShouldUseSharedPart(System.ComponentModel.Composition.CreationPolicy partPolicy, System.ComponentModel.Composition.CreationPolicy importPolicy)

### public class System.ComponentModel.Composition.Hosting.CatalogExportProvider
- Base: System.ComponentModel.Composition.Hosting.ExportProvider
- Interfaces: System.IDisposable

#### Fields
- private System.Collections.Generic.Dictionary<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Hosting.CatalogExportProvider.CatalogPart> _activatedParts
- private System.ComponentModel.Composition.Primitives.ComposablePartCatalog _catalog
- private System.ComponentModel.Composition.Hosting.CompositionOptions _compositionOptions
- private System.Runtime.CompilerServices.ConditionalWeakTable<object, System.Collections.Generic.List<System.ComponentModel.Composition.Primitives.ComposablePart>> _gcRoots
- private System.ComponentModel.Composition.Hosting.ImportEngine _importEngine
- private System.ComponentModel.Composition.Hosting.ExportProvider _innerExportProvider
- private bool _isDisposed
- private bool _isRunning
- private readonly System.ComponentModel.Composition.Hosting.CompositionLock _lock
- private System.Collections.Generic.HashSet<System.IDisposable> _partsToDispose
- private System.Collections.Generic.HashSet<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> _rejectedParts
- private System.ComponentModel.Composition.Hosting.ExportProvider _sourceProvider

#### Properties
- public System.ComponentModel.Composition.Primitives.ComposablePartCatalog Catalog { get; }
- public System.ComponentModel.Composition.Hosting.ExportProvider SourceProvider { get; set; }

#### Constructors
- public CatalogExportProvider(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog)
- public CatalogExportProvider(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog, bool isThreadSafe)
- public CatalogExportProvider(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog, System.ComponentModel.Composition.Hosting.CompositionOptions compositionOptions)

#### Methods
- private void AllowPartCollection(object gcRoot)
- private System.ComponentModel.Composition.Primitives.Export CreateExport(System.ComponentModel.Composition.Primitives.ComposablePartDefinition partDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition exportDefinition, bool isExportFactory, System.ComponentModel.Composition.CreationPolicy importPolicy)
- private bool DetermineRejection(System.ComponentModel.Composition.Primitives.ComposablePartDefinition definition, System.ComponentModel.Composition.Hosting.AtomicComposition parentAtomicComposition)
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- private void EnsureCanRun()
- private void EnsureCanSet<T>(T currentValue)
- private void EnsureRunning()
- private System.Func<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Hosting.CatalogExportProvider.AtomicCompositionQueryState> GetAtomicCompositionQuery(System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- private System.ComponentModel.Composition.Hosting.CatalogExportProvider.CatalogPart GetComposablePart(System.ComponentModel.Composition.Primitives.ComposablePartDefinition partDefinition, bool isSharedPart)
- private object GetExportedValue(System.ComponentModel.Composition.Hosting.CatalogExportProvider.CatalogPart part, System.ComponentModel.Composition.Primitives.ExportDefinition export, bool isSharedPart)
- protected override System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> GetExportsCore(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- private static System.ComponentModel.Composition.Primitives.ExportDefinition[] GetExportsFromPartDefinitions(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> partDefinitions)
- private System.ComponentModel.Composition.Hosting.CatalogExportProvider.CatalogPart GetSharedPart(System.ComponentModel.Composition.Primitives.ComposablePartDefinition partDefinition)
- private System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> InternalGetExportsCore(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- private bool IsRejected(System.ComponentModel.Composition.Primitives.ComposablePartDefinition definition, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- private void OnCatalogChanging(object sender, System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e)
- private void OnExportsChangingInternal(object sender, System.ComponentModel.Composition.Hosting.ExportsChangeEventArgs e)
- private void PreventPartCollection(object exportedValue, System.ComponentModel.Composition.Primitives.ComposablePart part)
- private void ReleasePart(object exportedValue, System.ComponentModel.Composition.Hosting.CatalogExportProvider.CatalogPart catalogPart, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- private void ThrowIfDisposed()
- private void UpdateAtomicCompositionQuery(System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition, System.Func<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, bool> query, System.ComponentModel.Composition.Hosting.CatalogExportProvider.AtomicCompositionQueryState state)
- private void UpdateRejections(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> changedExports, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)

### public static class System.ComponentModel.Composition.Hosting.CatalogExtensions

#### Methods
- public static System.ComponentModel.Composition.Hosting.CompositionService CreateCompositionService(System.ComponentModel.Composition.Primitives.ComposablePartCatalog composablePartCatalog)

### private class System.ComponentModel.Composition.Hosting.CatalogExportProvider.CatalogPart

#### Fields
- private System.ComponentModel.Composition.Primitives.ComposablePart <Part>k__BackingField
- private bool _importsSatisfied

#### Properties
- public bool ImportsSatisfied { get; set; }
- public System.ComponentModel.Composition.Primitives.ComposablePart Part { get; private set; }

#### Constructors
- public CatalogExportProvider.CatalogPart(System.ComponentModel.Composition.Primitives.ComposablePart part)

### public class System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs
- Base: System.EventArgs

#### Fields
- private System.ComponentModel.Composition.Hosting.AtomicComposition <AtomicComposition>k__BackingField
- private readonly System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> _addedDefinitions
- private readonly System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> _removedDefinitions

#### Properties
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> AddedDefinitions { get; }
- public System.ComponentModel.Composition.Hosting.AtomicComposition AtomicComposition { get; private set; }
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> RemovedDefinitions { get; }

#### Constructors
- public ComposablePartCatalogChangeEventArgs(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> addedDefinitions, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> removedDefinitions, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)

### internal class System.ComponentModel.Composition.Hosting.ComposablePartCatalogCollection
- Interfaces: System.Collections.Generic.ICollection<System.ComponentModel.Composition.Primitives.ComposablePartCatalog>, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartCatalog>, System.Collections.IEnumerable, System.ComponentModel.Composition.Hosting.INotifyComposablePartCatalogChanged, System.IDisposable

#### Fields
- private System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changed
- private System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changing
- private System.Collections.Generic.List<System.ComponentModel.Composition.Primitives.ComposablePartCatalog> _catalogs
- private bool _hasChanged
- private bool _isCopyNeeded
- private bool _isDisposed
- private readonly Microsoft.Internal.Lock _lock
- private System.Action<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> _onChanged
- private System.Action<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> _onChanging

#### Properties
- public int Count { get; }
- internal bool HasChanged { get; }
- public bool IsReadOnly { get; }

#### Events
- public event System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changed
- public event System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changing

#### Constructors
- public ComposablePartCatalogCollection(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartCatalog> catalogs, System.Action<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> onChanged, System.Action<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> onChanging)

#### Methods
- public void Add(System.ComponentModel.Composition.Primitives.ComposablePartCatalog item)
- public void Clear()
- public bool Contains(System.ComponentModel.Composition.Primitives.ComposablePartCatalog item)
- public void CopyTo(System.ComponentModel.Composition.Primitives.ComposablePartCatalog[] array, int arrayIndex)
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- public System.Collections.Generic.IEnumerator<System.ComponentModel.Composition.Primitives.ComposablePartCatalog> GetEnumerator()
- public void OnChanged(object sender, System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e)
- public void OnChanging(object sender, System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e)
- private void OnContainedCatalogChanged(object sender, System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e)
- private void OnContainedCatalogChanging(object sender, System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e)
- private void RaiseChangedEvent(System.Lazy<System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>> addedDefinitions, System.Lazy<System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>> removedDefinitions)
- private void RaiseChangingEvent(System.Lazy<System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>> addedDefinitions, System.Lazy<System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>> removedDefinitions, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- public bool Remove(System.ComponentModel.Composition.Primitives.ComposablePartCatalog item)
- private void SubscribeToCatalogNotifications(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog)
- private void SubscribeToCatalogNotifications(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartCatalog> catalogs)
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void ThrowIfDisposed()
- private void UnsubscribeFromCatalogNotifications(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog)
- private void UnsubscribeFromCatalogNotifications(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartCatalog> catalogs)

### public class System.ComponentModel.Composition.Hosting.ComposablePartExportProvider
- Base: System.ComponentModel.Composition.Hosting.ExportProvider
- Interfaces: System.IDisposable

#### Fields
- private System.ComponentModel.Composition.Hosting.CompositionOptions _compositionOptions
- private bool _currentlyComposing
- private System.ComponentModel.Composition.Hosting.ImportEngine _importEngine
- private bool _isDisposed
- private bool _isRunning
- private System.ComponentModel.Composition.Hosting.CompositionLock _lock
- private System.Collections.Generic.List<System.ComponentModel.Composition.Primitives.ComposablePart> _parts
- private System.ComponentModel.Composition.Hosting.ExportProvider _sourceProvider

#### Properties
- private System.ComponentModel.Composition.Hosting.ImportEngine ImportEngine { get; }
- public System.ComponentModel.Composition.Hosting.ExportProvider SourceProvider { get; set; }

#### Constructors
- public ComposablePartExportProvider()
- public ComposablePartExportProvider(bool isThreadSafe)
- public ComposablePartExportProvider(System.ComponentModel.Composition.Hosting.CompositionOptions compositionOptions)

#### Methods
- public void Compose(System.ComponentModel.Composition.Hosting.CompositionBatch batch)
- private System.ComponentModel.Composition.Primitives.Export CreateExport(System.ComponentModel.Composition.Primitives.ComposablePart part, System.ComponentModel.Composition.Primitives.ExportDefinition export)
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- private void EnsureCanRun()
- private void EnsureCanSet<T>(T currentValue)
- private void EnsureRunning()
- private object GetExportedValue(System.ComponentModel.Composition.Primitives.ComposablePart part, System.ComponentModel.Composition.Primitives.ExportDefinition export)
- protected override System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> GetExportsCore(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- private System.Collections.Generic.List<System.ComponentModel.Composition.Primitives.ComposablePart> GetUpdatedPartsList(ref System.ComponentModel.Composition.Hosting.CompositionBatch batch)
- private void Recompose(System.ComponentModel.Composition.Hosting.CompositionBatch batch, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- private void ThrowIfDisposed()

### public class System.ComponentModel.Composition.Hosting.CompositionBatch

#### Fields
- private bool _copyNeededForAdd
- private bool _copyNeededForRemove
- private object _lock
- private System.Collections.Generic.List<System.ComponentModel.Composition.Primitives.ComposablePart> _partsToAdd
- private System.Collections.Generic.List<System.ComponentModel.Composition.Primitives.ComposablePart> _partsToRemove
- private System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.Primitives.ComposablePart> _readOnlyPartsToAdd
- private System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.Primitives.ComposablePart> _readOnlyPartsToRemove

#### Properties
- public System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.Primitives.ComposablePart> PartsToAdd { get; }
- public System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.Primitives.ComposablePart> PartsToRemove { get; }

#### Constructors
- public CompositionBatch()
- public CompositionBatch(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePart> partsToAdd, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePart> partsToRemove)

#### Methods
- public System.ComponentModel.Composition.Primitives.ComposablePart AddExport(System.ComponentModel.Composition.Primitives.Export export)
- public void AddPart(System.ComponentModel.Composition.Primitives.ComposablePart part)
- public void RemovePart(System.ComponentModel.Composition.Primitives.ComposablePart part)

### public static class System.ComponentModel.Composition.Hosting.CompositionConstants

#### Fields
- private static const string CompositionNamespace
- public static const string ExportTypeIdentityMetadataName
- public static const string GenericContractMetadataName
- internal static const string GenericExportParametersOrderMetadataName
- internal static const string GenericImportParametersOrderMetadataName
- internal static const string GenericParameterAttributesMetadataName
- internal static const string GenericParameterConstraintsMetadataName
- public static const string GenericParametersMetadataName
- internal static const string GenericPartArityMetadataName
- public static const string ImportSourceMetadataName
- public static const string IsGenericPartMetadataName
- public static const string PartCreationPolicyMetadataName
- internal static const string PartCreatorContractName
- internal static readonly string PartCreatorTypeIdentity
- internal static const string ProductDefinitionMetadataName

#### Constructors
- private static CompositionConstants()

### public class System.ComponentModel.Composition.Hosting.CompositionContainer
- Base: System.ComponentModel.Composition.Hosting.ExportProvider
- Interfaces: System.ComponentModel.Composition.ICompositionService, System.IDisposable

#### Fields
- private static System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.Hosting.ExportProvider> EmptyProviders
- private System.ComponentModel.Composition.Hosting.AggregateExportProvider _ancestorExportProvider
- private System.ComponentModel.Composition.Hosting.CatalogExportProvider _catalogExportProvider
- private System.ComponentModel.Composition.Hosting.CompositionOptions _compositionOptions
- private System.ComponentModel.Composition.Hosting.ImportEngine _importEngine
- private bool _isDisposed
- private System.ComponentModel.Composition.Hosting.AggregateExportProvider _localExportProvider
- private object _lock
- private System.ComponentModel.Composition.Hosting.ComposablePartExportProvider _partExportProvider
- private readonly System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.Hosting.ExportProvider> _providers
- private System.ComponentModel.Composition.Hosting.ExportProvider _rootProvider

#### Properties
- public System.ComponentModel.Composition.Primitives.ComposablePartCatalog Catalog { get; }
- internal System.ComponentModel.Composition.Hosting.CatalogExportProvider CatalogExportProvider { get; }
- internal System.ComponentModel.Composition.Hosting.CompositionOptions CompositionOptions { get; }
- public System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.Hosting.ExportProvider> Providers { get; }

#### Constructors
- public CompositionContainer()
- private static CompositionContainer()
- public CompositionContainer(params System.ComponentModel.Composition.Hosting.ExportProvider[] providers)
- public CompositionContainer(System.ComponentModel.Composition.Hosting.CompositionOptions compositionOptions, params System.ComponentModel.Composition.Hosting.ExportProvider[] providers)
- public CompositionContainer(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog, params System.ComponentModel.Composition.Hosting.ExportProvider[] providers)
- public CompositionContainer(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog, bool isThreadSafe, params System.ComponentModel.Composition.Hosting.ExportProvider[] providers)
- public CompositionContainer(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog, System.ComponentModel.Composition.Hosting.CompositionOptions compositionOptions, params System.ComponentModel.Composition.Hosting.ExportProvider[] providers)

#### Methods
- public void Compose(System.ComponentModel.Composition.Hosting.CompositionBatch batch)
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- protected override System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> GetExportsCore(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- internal void OnExportsChangedInternal(object sender, System.ComponentModel.Composition.Hosting.ExportsChangeEventArgs e)
- internal void OnExportsChangingInternal(object sender, System.ComponentModel.Composition.Hosting.ExportsChangeEventArgs e)
- public void ReleaseExport(System.ComponentModel.Composition.Primitives.Export export)
- public void ReleaseExport<T>(System.Lazy<T> export)
- public void ReleaseExports(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> exports)
- public void ReleaseExports<T>(System.Collections.Generic.IEnumerable<System.Lazy<T>> exports)
- public void ReleaseExports<T, TMetadataView>(System.Collections.Generic.IEnumerable<System.Lazy<T, TMetadataView>> exports)
- public void SatisfyImportsOnce(System.ComponentModel.Composition.Primitives.ComposablePart part)
- private void ThrowIfDisposed()

### internal class System.ComponentModel.Composition.Hosting.CompositionLock
- Interfaces: System.IDisposable

#### Fields
- private static object _compositionLock
- private static readonly System.ComponentModel.Composition.Hosting.CompositionLock.EmptyLockHolder _EmptyLockHolder
- private int _isDisposed
- private bool _isThreadSafe
- private readonly Microsoft.Internal.Lock _stateLock

#### Properties
- public bool IsThreadSafe { get; }

#### Constructors
- private static CompositionLock()
- public CompositionLock(bool isThreadSafe)

#### Methods
- public void Dispose()
- private void EnterCompositionLock()
- private void ExitCompositionLock()
- public System.IDisposable LockComposition()
- public System.IDisposable LockStateForRead()
- public System.IDisposable LockStateForWrite()

### public class System.ComponentModel.Composition.Hosting.CompositionLock.CompositionLockHolder
- Interfaces: System.IDisposable

#### Fields
- private int _isDisposed
- private System.ComponentModel.Composition.Hosting.CompositionLock _lock

#### Constructors
- public CompositionLock.CompositionLockHolder(System.ComponentModel.Composition.Hosting.CompositionLock lock)

#### Methods
- public void Dispose()

### public enum System.ComponentModel.Composition.Hosting.CompositionOptions
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Default = 0
- DisableSilentRejection = 1
- ExportCompositionService = 4
- IsThreadSafe = 2

### public class System.ComponentModel.Composition.Hosting.CompositionScopeDefinition
- Base: System.ComponentModel.Composition.Primitives.ComposablePartCatalog
- Interfaces: System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>, System.Collections.IEnumerable, System.IDisposable, System.ComponentModel.Composition.Hosting.INotifyComposablePartCatalogChanged

#### Fields
- private System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changed
- private System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changing
- private System.ComponentModel.Composition.Primitives.ComposablePartCatalog _catalog
- private System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Hosting.CompositionScopeDefinition> _children
- private int _isDisposed
- private System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> _publicSurface

#### Properties
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Hosting.CompositionScopeDefinition> Children { get; }
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> PublicSurface { get; }

#### Events
- public event System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changed
- public event System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changing

#### Constructors
- protected CompositionScopeDefinition()
- public CompositionScopeDefinition(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Hosting.CompositionScopeDefinition> children)
- public CompositionScopeDefinition(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Hosting.CompositionScopeDefinition> children, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> publicSurface)

#### Methods
- protected override void Dispose(bool disposing)
- public override System.Collections.Generic.IEnumerator<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> GetEnumerator()
- public override System.Collections.Generic.IEnumerable<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>> GetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition)
- internal System.Collections.Generic.IEnumerable<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>> GetExportsFromPublicSurface(System.ComponentModel.Composition.Primitives.ImportDefinition definition)
- private void InitializeCompositionScopeDefinition(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Hosting.CompositionScopeDefinition> children, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> publicSurface)
- protected virtual void OnChanged(System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e)
- private void OnChangedInternal(object sender, System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e)
- protected virtual void OnChanging(System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e)
- private void OnChangingInternal(object sender, System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e)
- private void ThrowIfDisposed()

### internal class System.ComponentModel.Composition.Hosting.CompositionScopeDefinitionDebuggerProxy

#### Fields
- private readonly System.ComponentModel.Composition.Hosting.CompositionScopeDefinition _compositionScopeDefinition

#### Properties
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Hosting.CompositionScopeDefinition> Children { get; }
- public System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> Parts { get; }
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> PublicSurface { get; }

#### Constructors
- public CompositionScopeDefinitionDebuggerProxy(System.ComponentModel.Composition.Hosting.CompositionScopeDefinition compositionScopeDefinition)

### public class System.ComponentModel.Composition.Hosting.CompositionService
- Interfaces: System.ComponentModel.Composition.ICompositionService, System.IDisposable

#### Fields
- private System.ComponentModel.Composition.Hosting.CompositionContainer _compositionContainer
- private System.ComponentModel.Composition.Hosting.INotifyComposablePartCatalogChanged _notifyCatalog

#### Constructors
- internal CompositionService()
- internal CompositionService(System.ComponentModel.Composition.Primitives.ComposablePartCatalog composablePartCatalog)

#### Methods
- public void Dispose()
- private void OnCatalogChanging(object sender, System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e)
- public void SatisfyImportsOnce(System.ComponentModel.Composition.Primitives.ComposablePart part)

### internal static class System.ComponentModel.Composition.Hosting.CompositionServices

#### Fields
- internal static readonly System.Type AttributeType
- internal static readonly System.Type ExportAttributeType
- internal static readonly System.Type InheritedExportAttributeType
- internal static readonly System.Type ObjectType
- private static readonly string[] reservedMetadataNames

#### Constructors
- private static CompositionServices()

#### Methods
- internal static System.Type AdjustSpecifiedTypeIdentityType(System.Type specifiedContractType, System.Reflection.MemberInfo member)
- internal static System.Type AdjustSpecifiedTypeIdentityType(System.Type specifiedContractType, System.Type memberType)
- private static string AdjustTypeIdentity(string originalTypeIdentity, System.Type typeIdentityType)
- internal static void GetContractInfoFromExport(System.Reflection.MemberInfo member, System.ComponentModel.Composition.ExportAttribute export, out System.Type typeIdentityType, out string contractName)
- internal static string GetContractNameFromImport(System.ComponentModel.Composition.IAttributedImport import, System.ComponentModel.Composition.ReflectionModel.ImportType importType)
- internal static System.Type GetContractTypeFromImport(System.ComponentModel.Composition.IAttributedImport import, System.ComponentModel.Composition.ReflectionModel.ImportType importType)
- internal static System.Type GetDefaultTypeFromMember(System.Reflection.MemberInfo member)
- internal static object GetExportedValueFromComposedPart(System.ComponentModel.Composition.Hosting.ImportEngine engine, System.ComponentModel.Composition.Primitives.ComposablePart part, System.ComponentModel.Composition.Primitives.ExportDefinition definition)
- internal static System.Collections.Generic.IDictionary<string, object> GetImportMetadata(System.ComponentModel.Composition.ReflectionModel.ImportType importType, System.ComponentModel.Composition.IAttributedImport attributedImport)
- internal static System.Collections.Generic.IDictionary<string, object> GetImportMetadata(System.Type type, System.ComponentModel.Composition.IAttributedImport attributedImport)
- internal static System.Collections.Generic.IDictionary<string, object> GetPartMetadataForType(System.Type type, System.ComponentModel.Composition.CreationPolicy creationPolicy)
- internal static System.ComponentModel.Composition.CreationPolicy GetRequiredCreationPolicy(System.ComponentModel.Composition.Primitives.ImportDefinition definition)
- internal static System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Type>> GetRequiredMetadata(System.Type metadataViewType)
- internal static string GetTypeIdentityFromExport(System.Reflection.MemberInfo member, System.Type typeIdentityType)
- internal static string GetTypeIdentityFromImport(System.ComponentModel.Composition.IAttributedImport import, System.ComponentModel.Composition.ReflectionModel.ImportType importType)
- private static System.Type GetTypeIdentityTypeFromExport(System.Reflection.MemberInfo member, System.ComponentModel.Composition.ExportAttribute export)
- internal static bool IsAtMostOne(System.ComponentModel.Composition.Primitives.ImportCardinality cardinality)
- internal static bool IsContractNameSameAsTypeIdentity(System.ComponentModel.Composition.ExportAttribute export)
- internal static bool IsRecomposable(System.ComponentModel.Composition.Primitives.ComposablePart part)
- private static bool IsValidAttributeType(System.Type type)
- private static bool IsValidAttributeType(System.Type type, bool arrayAllowed)
- private static bool TryContributeMetadataValue(System.Collections.Generic.IDictionary<string, object> dictionary, string name, object value, System.Type valueType, bool allowsMultiple)
- internal static void TryExportMetadataForMember(System.Reflection.MemberInfo member, out System.Collections.Generic.IDictionary<string, object> dictionary)
- internal static System.ComponentModel.Composition.CompositionResult TryFire<TEventArgs>(System.EventHandler<TEventArgs> _delegate, object sender, TEventArgs e)
- internal static System.ComponentModel.Composition.CompositionResult TryInvoke(System.Action action)

### private class System.ComponentModel.Composition.Hosting.CompositionContainer.CompositionServiceShim
- Interfaces: System.ComponentModel.Composition.ICompositionService

#### Fields
- private System.ComponentModel.Composition.Hosting.CompositionContainer _innerContainer

#### Constructors
- public CompositionContainer.CompositionServiceShim(System.ComponentModel.Composition.Hosting.CompositionContainer innerContainer)

#### Methods
- private void System.ComponentModel.Composition.ICompositionService.SatisfyImportsOnce(System.ComponentModel.Composition.Primitives.ComposablePart part)

### internal class System.ComponentModel.Composition.Hosting.FilteredCatalog.DependenciesTraversal
- Interfaces: System.ComponentModel.Composition.Hosting.FilteredCatalog.IComposablePartCatalogTraversal

#### Fields
- private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>> _exportersIndex
- private System.Func<System.ComponentModel.Composition.Primitives.ImportDefinition, bool> _importFilter
- private System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> _parts

#### Constructors
- public FilteredCatalog.DependenciesTraversal(System.ComponentModel.Composition.Hosting.FilteredCatalog catalog, System.Func<System.ComponentModel.Composition.Primitives.ImportDefinition, bool> importFilter)

#### Methods
- private void AddToExportersIndex(string contractName, System.ComponentModel.Composition.Primitives.ComposablePartDefinition part)
- private void BuildExportersIndex()
- public void Initialize()
- public bool TryTraverse(System.ComponentModel.Composition.Primitives.ComposablePartDefinition part, out System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> reachableParts)

### internal class System.ComponentModel.Composition.Hosting.FilteredCatalog.DependentsTraversal
- Interfaces: System.ComponentModel.Composition.Hosting.FilteredCatalog.IComposablePartCatalogTraversal

#### Fields
- private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>> _importersIndex
- private System.Func<System.ComponentModel.Composition.Primitives.ImportDefinition, bool> _importFilter
- private System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> _parts

#### Constructors
- public FilteredCatalog.DependentsTraversal(System.ComponentModel.Composition.Hosting.FilteredCatalog catalog, System.Func<System.ComponentModel.Composition.Primitives.ImportDefinition, bool> importFilter)

#### Methods
- private void AddToImportersIndex(string contractName, System.ComponentModel.Composition.Primitives.ComposablePartDefinition part)
- private void BuildImportersIndex()
- public void Initialize()
- public bool TryTraverse(System.ComponentModel.Composition.Primitives.ComposablePartDefinition part, out System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> reachableParts)

### public class System.ComponentModel.Composition.Hosting.DirectoryCatalog
- Base: System.ComponentModel.Composition.Primitives.ComposablePartCatalog
- Interfaces: System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>, System.Collections.IEnumerable, System.IDisposable, System.ComponentModel.Composition.Hosting.INotifyComposablePartCatalogChanged, System.ComponentModel.Composition.Primitives.ICompositionElement

#### Fields
- private System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changed
- private System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changing
- private System.Collections.Generic.Dictionary<string, System.ComponentModel.Composition.Hosting.AssemblyCatalog> _assemblyCatalogs
- private System.ComponentModel.Composition.Hosting.ComposablePartCatalogCollection _catalogCollection
- private readonly System.ComponentModel.Composition.Primitives.ICompositionElement _definitionOrigin
- private string _fullPath
- private bool _isDisposed
- private System.Collections.ObjectModel.ReadOnlyCollection<string> _loadedFiles
- private string _path
- private readonly System.Reflection.ReflectionContext _reflectionContext
- private string _searchPattern
- private readonly Microsoft.Internal.Lock _thisLock

#### Properties
- public string FullPath { get; }
- public System.Collections.ObjectModel.ReadOnlyCollection<string> LoadedFiles { get; }
- public string Path { get; }
- public string SearchPattern { get; }
- private string System.ComponentModel.Composition.Primitives.ICompositionElement.DisplayName { get; }
- private System.ComponentModel.Composition.Primitives.ICompositionElement System.ComponentModel.Composition.Primitives.ICompositionElement.Origin { get; }

#### Events
- public event System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changed
- public event System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changing

#### Constructors
- public DirectoryCatalog(string path)
- public DirectoryCatalog(string path, System.Reflection.ReflectionContext reflectionContext)
- public DirectoryCatalog(string path, System.ComponentModel.Composition.Primitives.ICompositionElement definitionOrigin)
- public DirectoryCatalog(string path, string searchPattern)
- public DirectoryCatalog(string path, System.Reflection.ReflectionContext reflectionContext, System.ComponentModel.Composition.Primitives.ICompositionElement definitionOrigin)
- public DirectoryCatalog(string path, string searchPattern, System.ComponentModel.Composition.Primitives.ICompositionElement definitionOrigin)
- public DirectoryCatalog(string path, string searchPattern, System.Reflection.ReflectionContext reflectionContext)
- public DirectoryCatalog(string path, string searchPattern, System.Reflection.ReflectionContext reflectionContext, System.ComponentModel.Composition.Primitives.ICompositionElement definitionOrigin)

#### Methods
- private System.ComponentModel.Composition.Hosting.AssemblyCatalog CreateAssemblyCatalogGuarded(string assemblyFilePath)
- private void DiffChanges(string[] beforeFiles, string[] afterFiles, out System.Collections.Generic.List<System.Tuple<string, System.ComponentModel.Composition.Hosting.AssemblyCatalog>> catalogsToAdd, out System.Collections.Generic.List<System.Tuple<string, System.ComponentModel.Composition.Hosting.AssemblyCatalog>> catalogsToRemove)
- protected override void Dispose(bool disposing)
- private string GetDisplayName()
- public override System.Collections.Generic.IEnumerator<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> GetEnumerator()
- public override System.Collections.Generic.IEnumerable<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>> GetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition)
- private string[] GetFiles()
- private static string GetFullPath(string path)
- private void Initialize(string path, string searchPattern)
- protected virtual void OnChanged(System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e)
- protected virtual void OnChanging(System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e)
- public void Refresh()
- private void ThrowIfDisposed()
- public override string ToString()

### internal class System.ComponentModel.Composition.Hosting.DirectoryCatalog.DirectoryCatalogDebuggerProxy

#### Fields
- private readonly System.ComponentModel.Composition.Hosting.DirectoryCatalog _catalog

#### Properties
- public System.Collections.ObjectModel.ReadOnlyCollection<System.Reflection.Assembly> Assemblies { get; }
- public string FullPath { get; }
- public System.Collections.ObjectModel.ReadOnlyCollection<string> LoadedFiles { get; }
- public System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> Parts { get; }
- public string Path { get; }
- public System.Reflection.ReflectionContext ReflectionContext { get; }
- public string SearchPattern { get; }

#### Constructors
- public DirectoryCatalog.DirectoryCatalogDebuggerProxy(System.ComponentModel.Composition.Hosting.DirectoryCatalog catalog)

### private class System.ComponentModel.Composition.Hosting.CompositionLock.EmptyLockHolder
- Interfaces: System.IDisposable

#### Constructors
- public CompositionLock.EmptyLockHolder()

#### Methods
- public void Dispose()

### private class System.ComponentModel.Composition.Hosting.ImportEngine.EngineContext

#### Fields
- private System.Collections.Generic.List<System.ComponentModel.Composition.Hosting.ImportEngine.PartManager> _addedPartManagers
- private System.ComponentModel.Composition.Hosting.ImportEngine _importEngine
- private System.ComponentModel.Composition.Hosting.ImportEngine.EngineContext _parentEngineContext
- private System.Collections.Generic.List<System.ComponentModel.Composition.Hosting.ImportEngine.PartManager> _removedPartManagers

#### Constructors
- public ImportEngine.EngineContext(System.ComponentModel.Composition.Hosting.ImportEngine importEngine, System.ComponentModel.Composition.Hosting.ImportEngine.EngineContext parentEngineContext)

#### Methods
- public void AddPartManager(System.ComponentModel.Composition.Hosting.ImportEngine.PartManager part)
- public void Complete()
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Hosting.ImportEngine.PartManager> GetAddedPartManagers()
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Hosting.ImportEngine.PartManager> GetRemovedPartManagers()
- public void RemovePartManager(System.ComponentModel.Composition.Hosting.ImportEngine.PartManager part)

### public class System.ComponentModel.Composition.Hosting.ExportProvider

#### Fields
- private static readonly System.ComponentModel.Composition.Primitives.Export[] EmptyExports
- private System.EventHandler<System.ComponentModel.Composition.Hosting.ExportsChangeEventArgs> ExportsChanged
- private System.EventHandler<System.ComponentModel.Composition.Hosting.ExportsChangeEventArgs> ExportsChanging

#### Events
- public event System.EventHandler<System.ComponentModel.Composition.Hosting.ExportsChangeEventArgs> ExportsChanged
- public event System.EventHandler<System.ComponentModel.Composition.Hosting.ExportsChangeEventArgs> ExportsChanging

#### Constructors
- protected ExportProvider()
- private static ExportProvider()

#### Methods
- private static System.ComponentModel.Composition.Primitives.ImportDefinition BuildImportDefinition(System.Type type, System.Type metadataViewType, string contractName, System.ComponentModel.Composition.Primitives.ImportCardinality cardinality)
- public System.Lazy<T> GetExport<T>()
- public System.Lazy<T> GetExport<T>(string contractName)
- public System.Lazy<T, TMetadataView> GetExport<T, TMetadataView>()
- public System.Lazy<T, TMetadataView> GetExport<T, TMetadataView>(string contractName)
- private System.Lazy<T, TMetadataView> GetExportCore<T, TMetadataView>(string contractName)
- private System.Lazy<T> GetExportCore<T>(string contractName)
- public T GetExportedValue<T>()
- public T GetExportedValue<T>(string contractName)
- private T GetExportedValueCore<T>(string contractName, System.ComponentModel.Composition.Primitives.ImportCardinality cardinality)
- public T GetExportedValueOrDefault<T>()
- public T GetExportedValueOrDefault<T>(string contractName)
- public System.Collections.Generic.IEnumerable<T> GetExportedValues<T>()
- public System.Collections.Generic.IEnumerable<T> GetExportedValues<T>(string contractName)
- private System.Collections.Generic.IEnumerable<T> GetExportedValuesCore<T>(string contractName)
- public System.Collections.Generic.IEnumerable<System.Lazy<object, object>> GetExports(System.Type type, System.Type metadataViewType, string contractName)
- public System.Collections.Generic.IEnumerable<System.Lazy<T>> GetExports<T>()
- public System.Collections.Generic.IEnumerable<System.Lazy<T>> GetExports<T>(string contractName)
- public System.Collections.Generic.IEnumerable<System.Lazy<T, TMetadataView>> GetExports<T, TMetadataView>()
- public System.Collections.Generic.IEnumerable<System.Lazy<T, TMetadataView>> GetExports<T, TMetadataView>(string contractName)
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> GetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition)
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> GetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- private System.Collections.Generic.IEnumerable<System.Lazy<T>> GetExportsCore<T>(string contractName)
- private System.Collections.Generic.IEnumerable<System.Lazy<T, TMetadataView>> GetExportsCore<T, TMetadataView>(string contractName)
- private System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> GetExportsCore(System.Type type, System.Type metadataViewType, string contractName, System.ComponentModel.Composition.Primitives.ImportCardinality cardinality)
- protected abstract System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> GetExportsCore(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- protected virtual void OnExportsChanged(System.ComponentModel.Composition.Hosting.ExportsChangeEventArgs e)
- protected virtual void OnExportsChanging(System.ComponentModel.Composition.Hosting.ExportsChangeEventArgs e)
- public bool TryGetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition, out System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> exports)
- private System.ComponentModel.Composition.ExportCardinalityCheckResult TryGetExportsCore(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition, out System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> exports)

### public class System.ComponentModel.Composition.Hosting.ExportsChangeEventArgs
- Base: System.EventArgs

#### Fields
- private System.ComponentModel.Composition.Hosting.AtomicComposition <AtomicComposition>k__BackingField
- private readonly System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> _addedExports
- private System.Collections.Generic.IEnumerable<string> _changedContractNames
- private readonly System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> _removedExports

#### Properties
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> AddedExports { get; }
- public System.ComponentModel.Composition.Hosting.AtomicComposition AtomicComposition { get; private set; }
- public System.Collections.Generic.IEnumerable<string> ChangedContractNames { get; }
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> RemovedExports { get; }

#### Constructors
- public ExportsChangeEventArgs(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> addedExports, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> removedExports, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)

### internal class System.ComponentModel.Composition.Hosting.CatalogExportProvider.FactoryExport
- Base: System.ComponentModel.Composition.Primitives.Export

#### Fields
- private readonly System.ComponentModel.Composition.Primitives.ExportDefinition _exportDefinition
- private System.ComponentModel.Composition.Primitives.ExportDefinition _factoryExportDefinition
- private System.ComponentModel.Composition.Hosting.CatalogExportProvider.FactoryExport.FactoryExportPartDefinition _factoryExportPartDefinition
- private readonly System.ComponentModel.Composition.Primitives.ComposablePartDefinition _partDefinition

#### Properties
- public System.ComponentModel.Composition.Primitives.ExportDefinition Definition { get; }
- protected System.ComponentModel.Composition.Primitives.ExportDefinition UnderlyingExportDefinition { get; }
- protected System.ComponentModel.Composition.Primitives.ComposablePartDefinition UnderlyingPartDefinition { get; }

#### Constructors
- public CatalogExportProvider.FactoryExport(System.ComponentModel.Composition.Primitives.ComposablePartDefinition partDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition exportDefinition)

#### Methods
- public abstract System.ComponentModel.Composition.Primitives.Export CreateExportProduct()
- protected override object GetExportedValueCore()

### private class System.ComponentModel.Composition.Hosting.CatalogExportProvider.FactoryExport.FactoryExportPart
- Base: System.ComponentModel.Composition.Primitives.ComposablePart
- Interfaces: System.IDisposable

#### Fields
- private readonly System.ComponentModel.Composition.Hosting.CatalogExportProvider.FactoryExport.FactoryExportPartDefinition _definition
- private readonly System.ComponentModel.Composition.Primitives.Export _export

#### Properties
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> ExportDefinitions { get; }
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition> ImportDefinitions { get; }

#### Constructors
- public CatalogExportProvider.FactoryExport.FactoryExportPart(System.ComponentModel.Composition.Hosting.CatalogExportProvider.FactoryExport.FactoryExportPartDefinition definition)

#### Methods
- public void Dispose()
- public override object GetExportedValue(System.ComponentModel.Composition.Primitives.ExportDefinition definition)
- public override void SetImport(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> exports)

### private class System.ComponentModel.Composition.Hosting.CatalogExportProvider.FactoryExport.FactoryExportPartDefinition
- Base: System.ComponentModel.Composition.Primitives.ComposablePartDefinition

#### Fields
- private readonly System.ComponentModel.Composition.Hosting.CatalogExportProvider.FactoryExport _FactoryExport

#### Properties
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> ExportDefinitions { get; }
- public System.ComponentModel.Composition.Primitives.ExportDefinition FactoryExportDefinition { get; }
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition> ImportDefinitions { get; }

#### Constructors
- public CatalogExportProvider.FactoryExport.FactoryExportPartDefinition(System.ComponentModel.Composition.Hosting.CatalogExportProvider.FactoryExport FactoryExport)

#### Methods
- public override System.ComponentModel.Composition.Primitives.ComposablePart CreatePart()
- public System.ComponentModel.Composition.Primitives.Export CreateProductExport()

### public class System.ComponentModel.Composition.Hosting.FilteredCatalog
- Base: System.ComponentModel.Composition.Primitives.ComposablePartCatalog
- Interfaces: System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>, System.Collections.IEnumerable, System.IDisposable, System.ComponentModel.Composition.Hosting.INotifyComposablePartCatalogChanged

#### Fields
- private System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changed
- private System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changing
- private System.ComponentModel.Composition.Hosting.FilteredCatalog _complement
- private System.Func<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, bool> _filter
- private System.ComponentModel.Composition.Primitives.ComposablePartCatalog _innerCatalog
- private bool _isDisposed
- private object _lock

#### Properties
- public System.ComponentModel.Composition.Hosting.FilteredCatalog Complement { get; }

#### Events
- public event System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changed
- public event System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changing

#### Constructors
- public FilteredCatalog(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog, System.Func<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, bool> filter)
- internal FilteredCatalog(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog, System.Func<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, bool> filter, System.ComponentModel.Composition.Hosting.FilteredCatalog complement)

#### Methods
- private bool <get_Complement>b__23_0(System.ComponentModel.Composition.Primitives.ComposablePartDefinition p)
- protected override void Dispose(bool disposing)
- private void FreezeInnerCatalog()
- public override System.Collections.Generic.IEnumerator<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> GetEnumerator()
- public override System.Collections.Generic.IEnumerable<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>> GetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition)
- private static System.Collections.Generic.HashSet<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> GetTraversalClosure(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> parts, System.ComponentModel.Composition.Hosting.FilteredCatalog.IComposablePartCatalogTraversal traversal)
- private static void GetTraversalClosure(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> parts, System.Collections.Generic.HashSet<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> traversedParts, System.ComponentModel.Composition.Hosting.FilteredCatalog.IComposablePartCatalogTraversal traversal)
- public System.ComponentModel.Composition.Hosting.FilteredCatalog IncludeDependencies()
- public System.ComponentModel.Composition.Hosting.FilteredCatalog IncludeDependencies(System.Func<System.ComponentModel.Composition.Primitives.ImportDefinition, bool> importFilter)
- public System.ComponentModel.Composition.Hosting.FilteredCatalog IncludeDependents()
- public System.ComponentModel.Composition.Hosting.FilteredCatalog IncludeDependents(System.Func<System.ComponentModel.Composition.Primitives.ImportDefinition, bool> importFilter)
- protected virtual void OnChanged(System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e)
- private void OnChangedInternal(object sender, System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e)
- protected virtual void OnChanging(System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e)
- private void OnChangingInternal(object sender, System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e)
- private System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs ProcessEventArgs(System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e)
- private void ThrowIfDisposed()
- private static void ThrowOnRecomposition(object sender, System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e)
- private System.ComponentModel.Composition.Hosting.FilteredCatalog Traverse(System.ComponentModel.Composition.Hosting.FilteredCatalog.IComposablePartCatalogTraversal traversal)
- private void UnfreezeInnerCatalog()

### internal interface System.ComponentModel.Composition.Hosting.FilteredCatalog.IComposablePartCatalogTraversal

#### Methods
- public void Initialize()
- public bool TryTraverse(System.ComponentModel.Composition.Primitives.ComposablePartDefinition part, out System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> reachableParts)

### public class System.ComponentModel.Composition.Hosting.ImportEngine
- Interfaces: System.ComponentModel.Composition.ICompositionService, System.IDisposable

#### Fields
- private static const int MaximumNumberOfCompositionIterations
- private readonly System.ComponentModel.Composition.Hosting.CompositionOptions _compositionOptions
- private bool _isDisposed
- private readonly System.ComponentModel.Composition.Hosting.CompositionLock _lock
- private System.Runtime.CompilerServices.ConditionalWeakTable<System.ComponentModel.Composition.Primitives.ComposablePart, System.ComponentModel.Composition.Hosting.ImportEngine.PartManager> _partManagers
- private System.ComponentModel.Composition.Hosting.ImportEngine.RecompositionManager _recompositionManager
- private System.Collections.Generic.Stack<System.ComponentModel.Composition.Hosting.ImportEngine.PartManager> _recursionStateStack
- private System.ComponentModel.Composition.Hosting.ExportProvider _sourceProvider

#### Constructors
- public ImportEngine(System.ComponentModel.Composition.Hosting.ExportProvider sourceProvider)
- public ImportEngine(System.ComponentModel.Composition.Hosting.ExportProvider sourceProvider, bool isThreadSafe)
- public ImportEngine(System.ComponentModel.Composition.Hosting.ExportProvider sourceProvider, System.ComponentModel.Composition.Hosting.CompositionOptions compositionOptions)

#### Methods
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- private System.ComponentModel.Composition.Hosting.ImportEngine.EngineContext GetEngineContext(System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- private System.ComponentModel.Composition.Hosting.ImportEngine.PartManager GetPartManager(System.ComponentModel.Composition.Primitives.ComposablePart part, bool createIfNotpresent)
- private bool InPrerequisiteLoop()
- internal static bool IsRequiredImportForPreview(System.ComponentModel.Composition.Primitives.ImportDefinition import)
- private void OnExportsChanging(object sender, System.ComponentModel.Composition.Hosting.ExportsChangeEventArgs e)
- public void PreviewImports(System.ComponentModel.Composition.Primitives.ComposablePart part, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- public void ReleaseImports(System.ComponentModel.Composition.Primitives.ComposablePart part, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- public void SatisfyImports(System.ComponentModel.Composition.Primitives.ComposablePart part)
- public void SatisfyImportsOnce(System.ComponentModel.Composition.Primitives.ComposablePart part)
- private void StartSatisfyingImports(System.ComponentModel.Composition.Hosting.ImportEngine.PartManager partManager, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- private void StopSatisfyingImports(System.ComponentModel.Composition.Hosting.ImportEngine.PartManager partManager, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- private void ThrowIfDisposed()
- private static System.ComponentModel.Composition.CompositionResult<System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export>> TryGetExports(System.ComponentModel.Composition.Hosting.ExportProvider provider, System.ComponentModel.Composition.Primitives.ComposablePart part, System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- private System.ComponentModel.Composition.CompositionResult TryPreviewImportsStateMachine(System.ComponentModel.Composition.Hosting.ImportEngine.PartManager partManager, System.ComponentModel.Composition.Primitives.ComposablePart part, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- private System.ComponentModel.Composition.CompositionResult TryRecomposeImport(System.ComponentModel.Composition.Hosting.ImportEngine.PartManager partManager, bool partComposed, System.ComponentModel.Composition.Primitives.ImportDefinition import, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- private System.ComponentModel.Composition.CompositionResult TryRecomposeImports(System.ComponentModel.Composition.Hosting.ImportEngine.PartManager partManager, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> changedExports, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- private System.ComponentModel.Composition.CompositionResult TrySatisfyImports(System.ComponentModel.Composition.Hosting.ImportEngine.PartManager partManager, System.ComponentModel.Composition.Primitives.ComposablePart part, bool shouldTrackImports)
- private System.ComponentModel.Composition.CompositionResult TrySatisfyImportsStateMachine(System.ComponentModel.Composition.Hosting.ImportEngine.PartManager partManager, System.ComponentModel.Composition.Primitives.ComposablePart part)
- private System.ComponentModel.Composition.CompositionResult TrySatisfyImportSubset(System.ComponentModel.Composition.Hosting.ImportEngine.PartManager partManager, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition> imports, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)

### internal static class System.ComponentModel.Composition.Hosting.ImportSourceImportDefinitionHelpers

#### Methods
- public static System.ComponentModel.Composition.Primitives.ImportDefinition RemoveImportSource(System.ComponentModel.Composition.Primitives.ImportDefinition definition)

### private enum System.ComponentModel.Composition.Hosting.ImportEngine.ImportState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Composed = 8
- ComposedNotifying = 7
- ImportsPreviewed = 2
- ImportsPreviewing = 1
- NoImportsSatisfied = 0
- PostExportImportsSatisfied = 6
- PostExportImportsSatisfying = 5
- PreExportImportsSatisfied = 4
- PreExportImportsSatisfying = 3

### private class System.ComponentModel.Composition.Hosting.CatalogExportProvider.InnerCatalogExportProvider
- Base: System.ComponentModel.Composition.Hosting.ExportProvider

#### Fields
- private System.Func<System.ComponentModel.Composition.Primitives.ImportDefinition, System.ComponentModel.Composition.Hosting.AtomicComposition, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export>> _getExportsCore

#### Constructors
- public CatalogExportProvider.InnerCatalogExportProvider(System.Func<System.ComponentModel.Composition.Primitives.ImportDefinition, System.ComponentModel.Composition.Hosting.AtomicComposition, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export>> getExportsCore)

#### Methods
- protected override System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> GetExportsCore(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)

### public interface System.ComponentModel.Composition.Hosting.INotifyComposablePartCatalogChanged

#### Events
- public event System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changed
- public event System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changing

### private class System.ComponentModel.Composition.Hosting.CompositionServices.MetadataList

#### Fields
- private static readonly System.Type ObjectType
- private static readonly System.Type TypeType
- private System.Type _arrayType
- private bool _containsNulls
- private System.Collections.ObjectModel.Collection<object> _innerList

#### Constructors
- public CompositionServices.MetadataList()
- private static CompositionServices.MetadataList()

#### Methods
- public void Add(object item, System.Type itemType)
- private void InferArrayType(System.Type itemType)
- public System.Array ToArray()

### internal class System.ComponentModel.Composition.Hosting.ImportSourceImportDefinitionHelpers.NonImportSourceImportDefinition
- Base: System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition

#### Fields
- private System.Collections.Generic.IDictionary<string, object> _metadata
- private System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition _sourceDefinition

#### Properties
- public System.ComponentModel.Composition.Primitives.ImportCardinality Cardinality { get; }
- public System.Linq.Expressions.Expression<System.Func<System.ComponentModel.Composition.Primitives.ExportDefinition, bool>> Constraint { get; }
- public string ContractName { get; }
- public bool IsPrerequisite { get; }
- public bool IsRecomposable { get; }
- public System.Collections.Generic.IDictionary<string, object> Metadata { get; }
- public System.ComponentModel.Composition.CreationPolicy RequiredCreationPolicy { get; }
- public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Type>> RequiredMetadata { get; }
- public string RequiredTypeIdentity { get; }

#### Constructors
- public ImportSourceImportDefinitionHelpers.NonImportSourceImportDefinition(System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition sourceDefinition)

#### Methods
- public override bool IsConstraintSatisfiedBy(System.ComponentModel.Composition.Primitives.ExportDefinition exportDefinition)
- public override string ToString()

### private class System.ComponentModel.Composition.Hosting.CatalogExportProvider.NonSharedCatalogExport
- Base: System.ComponentModel.Composition.Hosting.CatalogExportProvider.CatalogExport
- Interfaces: System.IDisposable

#### Fields
- private readonly object _lock
- private System.ComponentModel.Composition.Hosting.CatalogExportProvider.CatalogPart _part

#### Properties
- protected bool IsSharedPart { get; }

#### Constructors
- public CatalogExportProvider.NonSharedCatalogExport(System.ComponentModel.Composition.Hosting.CatalogExportProvider catalogExportProvider, System.ComponentModel.Composition.Primitives.ComposablePartDefinition partDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition definition)

#### Methods
- protected override System.ComponentModel.Composition.Hosting.CatalogExportProvider.CatalogPart GetPart()
- private void System.IDisposable.Dispose()

### internal class System.ComponentModel.Composition.Hosting.CatalogExportProvider.PartCreatorExport
- Base: System.ComponentModel.Composition.Hosting.CatalogExportProvider.FactoryExport

#### Fields
- private readonly System.ComponentModel.Composition.Hosting.CatalogExportProvider _catalogExportProvider

#### Constructors
- public CatalogExportProvider.PartCreatorExport(System.ComponentModel.Composition.Hosting.CatalogExportProvider catalogExportProvider, System.ComponentModel.Composition.Primitives.ComposablePartDefinition partDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition exportDefinition)

#### Methods
- public override System.ComponentModel.Composition.Primitives.Export CreateExportProduct()

### private class System.ComponentModel.Composition.Hosting.ImportEngine.PartManager

#### Fields
- private bool <TrackingImports>k__BackingField
- private System.Collections.Generic.Dictionary<System.ComponentModel.Composition.Primitives.ImportDefinition, System.ComponentModel.Composition.Primitives.Export[]> _importCache
- private string[] _importedContractNames
- private System.Collections.Generic.Dictionary<System.ComponentModel.Composition.Primitives.ImportDefinition, System.Collections.Generic.List<System.IDisposable>> _importedDisposableExports
- private readonly System.ComponentModel.Composition.Hosting.ImportEngine _importEngine
- private System.ComponentModel.Composition.Primitives.ComposablePart _part
- private System.ComponentModel.Composition.Hosting.ImportEngine.ImportState _state

#### Properties
- public System.ComponentModel.Composition.Primitives.ComposablePart Part { get; }
- public System.ComponentModel.Composition.Hosting.ImportEngine.ImportState State { get; set; }
- public bool TrackingImports { get; set; }

#### Constructors
- public ImportEngine.PartManager(System.ComponentModel.Composition.Hosting.ImportEngine importEngine, System.ComponentModel.Composition.Primitives.ComposablePart part)

#### Methods
- public void ClearSavedImports()
- public void DisposeAllDependencies()
- public System.Collections.Generic.IEnumerable<string> GetImportedContractNames()
- public System.ComponentModel.Composition.Primitives.Export[] GetSavedImport(System.ComponentModel.Composition.Primitives.ImportDefinition import)
- public void SetSavedImport(System.ComponentModel.Composition.Primitives.ImportDefinition import, System.ComponentModel.Composition.Primitives.Export[] exports, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- public System.ComponentModel.Composition.CompositionResult TryOnComposed()
- public System.ComponentModel.Composition.CompositionResult TrySetImport(System.ComponentModel.Composition.Primitives.ImportDefinition import, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> exports)
- public void UpdateDisposableDependencies(System.ComponentModel.Composition.Primitives.ImportDefinition import, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> exports)

### private class System.ComponentModel.Composition.Hosting.ImportEngine.RecompositionManager

#### Fields
- private System.Collections.Generic.Dictionary<string, Microsoft.Internal.Collections.WeakReferenceCollection<System.ComponentModel.Composition.Hosting.ImportEngine.PartManager>> _partManagerIndex
- private Microsoft.Internal.Collections.WeakReferenceCollection<System.ComponentModel.Composition.Hosting.ImportEngine.PartManager> _partsToIndex
- private Microsoft.Internal.Collections.WeakReferenceCollection<System.ComponentModel.Composition.Hosting.ImportEngine.PartManager> _partsToUnindex

#### Constructors
- public ImportEngine.RecompositionManager()

#### Methods
- private void AddIndexEntries(System.ComponentModel.Composition.Hosting.ImportEngine.PartManager partManager)
- public void AddPartToIndex(System.ComponentModel.Composition.Hosting.ImportEngine.PartManager partManager)
- public void AddPartToUnindex(System.ComponentModel.Composition.Hosting.ImportEngine.PartManager partManager)
- public static System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition> GetAffectedImports(System.ComponentModel.Composition.Primitives.ComposablePart part, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> changedExports)
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Hosting.ImportEngine.PartManager> GetAffectedParts(System.Collections.Generic.IEnumerable<string> changedContractNames)
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Hosting.ImportEngine.PartManager> GetPartsImporting(string contractName)
- private static bool IsAffectedImport(System.ComponentModel.Composition.Primitives.ImportDefinition import, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> changedExports)
- private void RemoveIndexEntries(System.ComponentModel.Composition.Hosting.ImportEngine.PartManager partManager)
- private void UpdateImportIndex()

### private class System.ComponentModel.Composition.Hosting.CatalogExportProvider.ScopeFactoryExport.ScopeCatalogExport
- Base: System.ComponentModel.Composition.Primitives.Export
- Interfaces: System.IDisposable

#### Fields
- private System.Func<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, bool> _catalogFilter
- private System.ComponentModel.Composition.Hosting.CompositionContainer _childContainer
- private System.ComponentModel.Composition.Primitives.Export _export
- private readonly object _lock
- private readonly System.ComponentModel.Composition.Hosting.CatalogExportProvider.ScopeFactoryExport _scopeFactoryExport

#### Properties
- public System.ComponentModel.Composition.Primitives.ExportDefinition Definition { get; }

#### Constructors
- public CatalogExportProvider.ScopeFactoryExport.ScopeCatalogExport(System.ComponentModel.Composition.Hosting.CatalogExportProvider.ScopeFactoryExport scopeFactoryExport, System.Func<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, bool> catalogFilter)

#### Methods
- public void Dispose()
- protected override object GetExportedValueCore()

### internal class System.ComponentModel.Composition.Hosting.CatalogExportProvider.ScopeFactoryExport
- Base: System.ComponentModel.Composition.Hosting.CatalogExportProvider.FactoryExport

#### Fields
- private readonly System.ComponentModel.Composition.Hosting.CompositionScopeDefinition _catalog
- private readonly System.ComponentModel.Composition.Hosting.CatalogExportProvider.ScopeManager _scopeManager

#### Constructors
- internal CatalogExportProvider.ScopeFactoryExport(System.ComponentModel.Composition.Hosting.CatalogExportProvider.ScopeManager scopeManager, System.ComponentModel.Composition.Hosting.CompositionScopeDefinition catalog, System.ComponentModel.Composition.Primitives.ComposablePartDefinition partDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition exportDefinition)

#### Methods
- public virtual System.ComponentModel.Composition.Primitives.Export CreateExportProduct(System.Func<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, bool> filter)
- public override System.ComponentModel.Composition.Primitives.Export CreateExportProduct()

### internal class System.ComponentModel.Composition.Hosting.CatalogExportProvider.ScopeManager
- Base: System.ComponentModel.Composition.Hosting.ExportProvider

#### Fields
- private System.ComponentModel.Composition.Hosting.CatalogExportProvider _catalogExportProvider
- private System.ComponentModel.Composition.Hosting.CompositionScopeDefinition _scopeDefinition

#### Constructors
- public CatalogExportProvider.ScopeManager(System.ComponentModel.Composition.Hosting.CatalogExportProvider catalogExportProvider, System.ComponentModel.Composition.Hosting.CompositionScopeDefinition scopeDefinition)

#### Methods
- internal System.ComponentModel.Composition.Hosting.CompositionContainer CreateChildContainer(System.ComponentModel.Composition.Primitives.ComposablePartCatalog childCatalog)
- private System.ComponentModel.Composition.Primitives.Export CreateScopeExport(System.ComponentModel.Composition.Hosting.CompositionScopeDefinition childCatalog, System.ComponentModel.Composition.Primitives.ComposablePartDefinition partDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition exportDefinition)
- protected override System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> GetExportsCore(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition)
- private static System.ComponentModel.Composition.Primitives.ImportDefinition TranslateImport(System.ComponentModel.Composition.Primitives.ImportDefinition definition)

### public static class System.ComponentModel.Composition.Hosting.ScopingExtensions

#### Methods
- public static bool ContainsPartMetadata<T>(System.ComponentModel.Composition.Primitives.ComposablePartDefinition part, string key, T value)
- public static bool ContainsPartMetadataWithKey(System.ComponentModel.Composition.Primitives.ComposablePartDefinition part, string key)
- public static bool Exports(System.ComponentModel.Composition.Primitives.ComposablePartDefinition part, string contractName)
- public static System.ComponentModel.Composition.Hosting.FilteredCatalog Filter(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog, System.Func<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, bool> filter)
- public static bool Imports(System.ComponentModel.Composition.Primitives.ComposablePartDefinition part, string contractName)
- public static bool Imports(System.ComponentModel.Composition.Primitives.ComposablePartDefinition part, string contractName, System.ComponentModel.Composition.Primitives.ImportCardinality importCardinality)

### private class System.ComponentModel.Composition.Hosting.CompositionBatch.SingleExportComposablePart
- Base: System.ComponentModel.Composition.Primitives.ComposablePart

#### Fields
- private readonly System.ComponentModel.Composition.Primitives.Export _export

#### Properties
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> ExportDefinitions { get; }
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition> ImportDefinitions { get; }
- public System.Collections.Generic.IDictionary<string, object> Metadata { get; }

#### Constructors
- public CompositionBatch.SingleExportComposablePart(System.ComponentModel.Composition.Primitives.Export export)

#### Methods
- public override object GetExportedValue(System.ComponentModel.Composition.Primitives.ExportDefinition definition)
- public override void SetImport(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> exports)

### public class System.ComponentModel.Composition.Hosting.TypeCatalog
- Base: System.ComponentModel.Composition.Primitives.ComposablePartCatalog
- Interfaces: System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>, System.Collections.IEnumerable, System.IDisposable, System.ComponentModel.Composition.Primitives.ICompositionElement

#### Fields
- private readonly System.Lazy<System.Collections.Generic.IDictionary<string, System.Collections.Generic.List<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>>> _contractPartIndex
- private readonly System.ComponentModel.Composition.Primitives.ICompositionElement _definitionOrigin
- private bool _isDisposed
- private System.Collections.Generic.List<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> _parts
- private readonly object _thisLock
- private System.Type[] _types

#### Properties
- private System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> PartsInternal { get; }
- private string System.ComponentModel.Composition.Primitives.ICompositionElement.DisplayName { get; }
- private System.ComponentModel.Composition.Primitives.ICompositionElement System.ComponentModel.Composition.Primitives.ICompositionElement.Origin { get; }

#### Constructors
- public TypeCatalog(params System.Type[] types)
- public TypeCatalog(System.Collections.Generic.IEnumerable<System.Type> types)
- public TypeCatalog(System.Collections.Generic.IEnumerable<System.Type> types, System.ComponentModel.Composition.Primitives.ICompositionElement definitionOrigin)
- public TypeCatalog(System.Collections.Generic.IEnumerable<System.Type> types, System.Reflection.ReflectionContext reflectionContext)
- public TypeCatalog(System.Collections.Generic.IEnumerable<System.Type> types, System.Reflection.ReflectionContext reflectionContext, System.ComponentModel.Composition.Primitives.ICompositionElement definitionOrigin)

#### Methods
- private System.Collections.Generic.IDictionary<string, System.Collections.Generic.List<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>> CreateIndex()
- protected override void Dispose(bool disposing)
- internal override System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> GetCandidateParts(System.ComponentModel.Composition.Primitives.ImportDefinition definition)
- private System.Collections.Generic.List<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> GetCandidateParts(string contractName)
- private string GetDisplayName()
- public override System.Collections.Generic.IEnumerator<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> GetEnumerator()
- private string GetTypesDisplay()
- private void InitializeTypeCatalog(System.Collections.Generic.IEnumerable<System.Type> types, System.Reflection.ReflectionContext reflectionContext)
- private void InitializeTypeCatalog(System.Collections.Generic.IEnumerable<System.Type> types)
- private void ThrowIfDisposed()
- public override string ToString()

## Namespace: System.ComponentModel.Composition.Primitives

### private class System.ComponentModel.Composition.Primitives.PrimitivesServices.<GetCandidateContractNames>d__2
- Interfaces: System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private string <>2__current
- public System.ComponentModel.Composition.Primitives.ImportDefinition <>3__import
- public System.ComponentModel.Composition.Primitives.ComposablePartDefinition <>3__part
- private int <>l__initialThreadId
- private string <genericContractName>5__2
- private System.ComponentModel.Composition.Primitives.ImportDefinition import
- private System.ComponentModel.Composition.Primitives.ComposablePartDefinition part

#### Properties
- private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public PrimitivesServices.<GetCandidateContractNames>d__2(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### public class System.ComponentModel.Composition.Primitives.ComposablePart

#### Properties
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> ExportDefinitions { get; }
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition> ImportDefinitions { get; }
- public System.Collections.Generic.IDictionary<string, object> Metadata { get; }

#### Constructors
- protected ComposablePart()

#### Methods
- public virtual void Activate()
- public abstract object GetExportedValue(System.ComponentModel.Composition.Primitives.ExportDefinition definition)
- public abstract void SetImport(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> exports)

### public class System.ComponentModel.Composition.Primitives.ComposablePartCatalog
- Interfaces: System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>, System.Collections.IEnumerable, System.IDisposable

#### Fields
- private static readonly System.Collections.Generic.List<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>> _EmptyExportsList
- private bool _isDisposed
- private System.Linq.IQueryable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> _queryableParts

#### Properties
- public System.Linq.IQueryable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> Parts { get; }

#### Constructors
- protected ComposablePartCatalog()
- private static ComposablePartCatalog()

#### Methods
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- internal virtual System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> GetCandidateParts(System.ComponentModel.Composition.Primitives.ImportDefinition definition)
- public virtual System.Collections.Generic.IEnumerator<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> GetEnumerator()
- public virtual System.Collections.Generic.IEnumerable<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>> GetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition)
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void ThrowIfDisposed()

### internal class System.ComponentModel.Composition.Primitives.ComposablePartCatalogDebuggerProxy

#### Fields
- private readonly System.ComponentModel.Composition.Primitives.ComposablePartCatalog _catalog

#### Properties
- public System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> Parts { get; }

#### Constructors
- public ComposablePartCatalogDebuggerProxy(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog)

### public class System.ComponentModel.Composition.Primitives.ComposablePartDefinition

#### Fields
- internal static readonly System.Collections.Generic.IEnumerable<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>> _EmptyExports

#### Properties
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> ExportDefinitions { get; }
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition> ImportDefinitions { get; }
- public System.Collections.Generic.IDictionary<string, object> Metadata { get; }

#### Constructors
- protected ComposablePartDefinition()
- private static ComposablePartDefinition()

#### Methods
- public abstract System.ComponentModel.Composition.Primitives.ComposablePart CreatePart()
- internal virtual System.Collections.Generic.IEnumerable<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>> GetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition)
- internal virtual System.ComponentModel.Composition.Primitives.ComposablePartDefinition GetGenericPartDefinition()

### public class System.ComponentModel.Composition.Primitives.ComposablePartException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Fields
- private readonly System.ComponentModel.Composition.Primitives.ICompositionElement _element

#### Properties
- public System.ComponentModel.Composition.Primitives.ICompositionElement Element { get; }

#### Constructors
- public ComposablePartException()
- public ComposablePartException(string message)
- public ComposablePartException(string message, System.ComponentModel.Composition.Primitives.ICompositionElement element)
- public ComposablePartException(string message, System.Exception innerException)
- protected ComposablePartException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
- public ComposablePartException(string message, System.ComponentModel.Composition.Primitives.ICompositionElement element, System.Exception innerException)

#### Methods
- public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)

### internal class System.ComponentModel.Composition.Primitives.ComposablePartExceptionDebuggerProxy

#### Fields
- private readonly System.ComponentModel.Composition.Primitives.ComposablePartException _exception

#### Properties
- public System.ComponentModel.Composition.Primitives.ICompositionElement Element { get; }
- public System.Exception InnerException { get; }
- public string Message { get; }

#### Constructors
- public ComposablePartExceptionDebuggerProxy(System.ComponentModel.Composition.Primitives.ComposablePartException exception)

### internal class System.ComponentModel.Composition.Primitives.CompositionElement
- Base: System.ComponentModel.Composition.Primitives.SerializableCompositionElement
- Interfaces: System.ComponentModel.Composition.Primitives.ICompositionElement

#### Fields
- private static readonly System.ComponentModel.Composition.Primitives.ICompositionElement UnknownOrigin
- private readonly object _underlyingObject

#### Properties
- public object UnderlyingObject { get; }

#### Constructors
- private static CompositionElement()
- public CompositionElement(object underlyingObject)

### internal class System.ComponentModel.Composition.Primitives.CompositionElementDebuggerProxy

#### Fields
- private readonly System.ComponentModel.Composition.Primitives.CompositionElement _element

#### Properties
- public string DisplayName { get; }
- public System.ComponentModel.Composition.Primitives.ICompositionElement Origin { get; }
- public object UnderlyingObject { get; }

#### Constructors
- public CompositionElementDebuggerProxy(System.ComponentModel.Composition.Primitives.CompositionElement element)

### internal static class System.ComponentModel.Composition.Primitives.CompositionElementExtensions

#### Methods
- public static string GetDisplayName(System.ComponentModel.Composition.Primitives.ComposablePartDefinition definition)
- public static string GetDisplayName(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog)
- private static string GetDisplayNameCore(object value)
- public static System.ComponentModel.Composition.Primitives.ICompositionElement ToElement(System.ComponentModel.Composition.Primitives.Export export)
- public static System.ComponentModel.Composition.Primitives.ICompositionElement ToElement(System.ComponentModel.Composition.Primitives.ExportDefinition definition)
- public static System.ComponentModel.Composition.Primitives.ICompositionElement ToElement(System.ComponentModel.Composition.Primitives.ImportDefinition definition)
- public static System.ComponentModel.Composition.Primitives.ICompositionElement ToElement(System.ComponentModel.Composition.Primitives.ComposablePart part)
- public static System.ComponentModel.Composition.Primitives.ICompositionElement ToElement(System.ComponentModel.Composition.Primitives.ComposablePartDefinition definition)
- private static System.ComponentModel.Composition.Primitives.ICompositionElement ToElementCore(object value)
- public static System.ComponentModel.Composition.Primitives.ICompositionElement ToSerializableElement(System.ComponentModel.Composition.Primitives.ICompositionElement element)

### public class System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition
- Base: System.ComponentModel.Composition.Primitives.ImportDefinition

#### Fields
- private System.Linq.Expressions.Expression<System.Func<System.ComponentModel.Composition.Primitives.ExportDefinition, bool>> _constraint
- private bool _isRequiredMetadataValidated
- private readonly System.ComponentModel.Composition.CreationPolicy _requiredCreationPolicy
- private readonly System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Type>> _requiredMetadata
- private readonly string _requiredTypeIdentity

#### Properties
- public System.Linq.Expressions.Expression<System.Func<System.ComponentModel.Composition.Primitives.ExportDefinition, bool>> Constraint { get; }
- public System.ComponentModel.Composition.CreationPolicy RequiredCreationPolicy { get; }
- public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Type>> RequiredMetadata { get; }
- public string RequiredTypeIdentity { get; }

#### Constructors
- protected ContractBasedImportDefinition()
- public ContractBasedImportDefinition(string contractName, string requiredTypeIdentity, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Type>> requiredMetadata, System.ComponentModel.Composition.Primitives.ImportCardinality cardinality, bool isRecomposable, bool isPrerequisite, System.ComponentModel.Composition.CreationPolicy requiredCreationPolicy)
- public ContractBasedImportDefinition(string contractName, string requiredTypeIdentity, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Type>> requiredMetadata, System.ComponentModel.Composition.Primitives.ImportCardinality cardinality, bool isRecomposable, bool isPrerequisite, System.ComponentModel.Composition.CreationPolicy requiredCreationPolicy, System.Collections.Generic.IDictionary<string, object> metadata)

#### Methods
- public override bool IsConstraintSatisfiedBy(System.ComponentModel.Composition.Primitives.ExportDefinition exportDefinition)
- private bool MatchRequiredMatadata(System.ComponentModel.Composition.Primitives.ExportDefinition definition)
- public override string ToString()
- private void ValidateRequiredMetadata()

### public class System.ComponentModel.Composition.Primitives.Export

#### Fields
- private readonly System.ComponentModel.Composition.Primitives.ExportDefinition _definition
- private static readonly object _EmptyValue
- private object _exportedValue
- private readonly System.Func<object> _exportedValueGetter

#### Properties
- public System.ComponentModel.Composition.Primitives.ExportDefinition Definition { get; }
- public System.Collections.Generic.IDictionary<string, object> Metadata { get; }
- public object Value { get; }

#### Constructors
- protected Export()
- private static Export()
- public Export(string contractName, System.Func<object> exportedValueGetter)
- public Export(System.ComponentModel.Composition.Primitives.ExportDefinition definition, System.Func<object> exportedValueGetter)
- public Export(string contractName, System.Collections.Generic.IDictionary<string, object> metadata, System.Func<object> exportedValueGetter)

#### Methods
- protected virtual object GetExportedValueCore()

### public class System.ComponentModel.Composition.Primitives.ExportDefinition

#### Fields
- private readonly string _contractName
- private readonly System.Collections.Generic.IDictionary<string, object> _metadata

#### Properties
- public string ContractName { get; }
- public System.Collections.Generic.IDictionary<string, object> Metadata { get; }

#### Constructors
- protected ExportDefinition()
- public ExportDefinition(string contractName, System.Collections.Generic.IDictionary<string, object> metadata)

#### Methods
- public override string ToString()

### public class System.ComponentModel.Composition.Primitives.ExportedDelegate

#### Fields
- private object _instance
- private System.Reflection.MethodInfo _method

#### Constructors
- protected ExportedDelegate()
- public ExportedDelegate(object instance, System.Reflection.MethodInfo method)

#### Methods
- public virtual System.Delegate CreateDelegate(System.Type delegateType)
- private System.Type CreateStandardDelegateType()

### public interface System.ComponentModel.Composition.Primitives.ICompositionElement

#### Properties
- public string DisplayName { get; }
- public System.ComponentModel.Composition.Primitives.ICompositionElement Origin { get; }

### public enum System.ComponentModel.Composition.Primitives.ImportCardinality
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ExactlyOne = 1
- ZeroOrMore = 2
- ZeroOrOne = 0

### public class System.ComponentModel.Composition.Primitives.ImportDefinition

#### Fields
- internal static readonly string EmptyContractName
- private readonly System.ComponentModel.Composition.Primitives.ImportCardinality _cardinality
- private System.Func<System.ComponentModel.Composition.Primitives.ExportDefinition, bool> _compiledConstraint
- private readonly System.Linq.Expressions.Expression<System.Func<System.ComponentModel.Composition.Primitives.ExportDefinition, bool>> _constraint
- private readonly string _contractName
- private readonly bool _isPrerequisite
- private readonly bool _isRecomposable
- private readonly System.Collections.Generic.IDictionary<string, object> _metadata

#### Properties
- public System.ComponentModel.Composition.Primitives.ImportCardinality Cardinality { get; }
- public System.Linq.Expressions.Expression<System.Func<System.ComponentModel.Composition.Primitives.ExportDefinition, bool>> Constraint { get; }
- public string ContractName { get; }
- public bool IsPrerequisite { get; }
- public bool IsRecomposable { get; }
- public System.Collections.Generic.IDictionary<string, object> Metadata { get; }

#### Constructors
- protected ImportDefinition()
- private static ImportDefinition()
- public ImportDefinition(System.Linq.Expressions.Expression<System.Func<System.ComponentModel.Composition.Primitives.ExportDefinition, bool>> constraint, string contractName, System.ComponentModel.Composition.Primitives.ImportCardinality cardinality, bool isRecomposable, bool isPrerequisite)
- internal ImportDefinition(string contractName, System.ComponentModel.Composition.Primitives.ImportCardinality cardinality, bool isRecomposable, bool isPrerequisite, System.Collections.Generic.IDictionary<string, object> metadata)
- public ImportDefinition(System.Linq.Expressions.Expression<System.Func<System.ComponentModel.Composition.Primitives.ExportDefinition, bool>> constraint, string contractName, System.ComponentModel.Composition.Primitives.ImportCardinality cardinality, bool isRecomposable, bool isPrerequisite, System.Collections.Generic.IDictionary<string, object> metadata)

#### Methods
- public virtual bool IsConstraintSatisfiedBy(System.ComponentModel.Composition.Primitives.ExportDefinition exportDefinition)
- public override string ToString()

### internal interface System.ComponentModel.Composition.Primitives.IPartCreatorImportDefinition

#### Properties
- public System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition ProductImportDefinition { get; }

### internal static class System.ComponentModel.Composition.Primitives.PrimitivesServices

#### Methods
- internal static System.Collections.Generic.IEnumerable<string> GetCandidateContractNames(System.ComponentModel.Composition.Primitives.ImportDefinition import, System.ComponentModel.Composition.Primitives.ComposablePartDefinition part)
- public static System.ComponentModel.Composition.Primitives.ImportDefinition GetProductImportDefinition(System.ComponentModel.Composition.Primitives.ImportDefinition import)
- public static bool IsGeneric(System.ComponentModel.Composition.Primitives.ComposablePartDefinition part)
- internal static bool IsImportDependentOnPart(System.ComponentModel.Composition.Primitives.ImportDefinition import, System.ComponentModel.Composition.Primitives.ComposablePartDefinition part, System.ComponentModel.Composition.Primitives.ExportDefinition export, bool expandGenerics)
- private static System.ComponentModel.Composition.Primitives.ImportDefinition TranslateImport(System.ComponentModel.Composition.Primitives.ImportDefinition import, System.ComponentModel.Composition.Primitives.ComposablePartDefinition part)

### internal class System.ComponentModel.Composition.Primitives.SerializableCompositionElement
- Interfaces: System.ComponentModel.Composition.Primitives.ICompositionElement

#### Fields
- private readonly string _displayName
- private readonly System.ComponentModel.Composition.Primitives.ICompositionElement _origin

#### Properties
- public string DisplayName { get; }
- public System.ComponentModel.Composition.Primitives.ICompositionElement Origin { get; }

#### Constructors
- public SerializableCompositionElement(string displayName, System.ComponentModel.Composition.Primitives.ICompositionElement origin)

#### Methods
- public static System.ComponentModel.Composition.Primitives.ICompositionElement FromICompositionElement(System.ComponentModel.Composition.Primitives.ICompositionElement element)
- public override string ToString()

## Namespace: System.ComponentModel.Composition.ReflectionModel

### private class System.ComponentModel.Composition.ReflectionModel.GenericServices.<>c

#### Fields
- public static readonly System.ComponentModel.Composition.ReflectionModel.GenericServices.<>c <>9
- public static System.Func<System.Type, int> <>9__3_0

#### Constructors
- private static GenericServices.<>c()
- public GenericServices.<>c()

#### Methods
- internal int <GetGenericParametersOrder>b__3_0(System.Type parameter)

### private class System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo.<>c

#### Fields
- public static readonly System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo.<>c <>9
- public static System.Func<System.Reflection.MemberInfo, bool> <>9__14_0
- public static System.Func<System.Reflection.MemberInfo, bool> <>9__14_1
- public static System.Func<System.Reflection.MemberInfo, bool> <>9__14_2

#### Constructors
- private static LazyMemberInfo.<>c()
- public LazyMemberInfo.<>c()

#### Methods
- internal bool <AreAccessorsValid>b__14_0(System.Reflection.MemberInfo accessor)
- internal bool <AreAccessorsValid>b__14_1(System.Reflection.MemberInfo accessor)
- internal bool <AreAccessorsValid>b__14_2(System.Reflection.MemberInfo accessor)

### private class System.ComponentModel.Composition.ReflectionModel.ReflectionComposablePart.<>c

#### Fields
- public static readonly System.ComponentModel.Composition.ReflectionModel.ReflectionComposablePart.<>c <>9
- public static System.Func<System.ComponentModel.Composition.Primitives.ImportDefinition, bool> <>9__37_0
- public static System.Func<System.ComponentModel.Composition.Primitives.ImportDefinition, bool> <>9__41_0
- public static System.Func<System.ComponentModel.Composition.Primitives.ImportDefinition, bool> <>9__42_0

#### Constructors
- private static ReflectionComposablePart.<>c()
- public ReflectionComposablePart.<>c()

#### Methods
- internal bool <EnsureGettable>b__37_0(System.ComponentModel.Composition.Primitives.ImportDefinition definition)
- internal bool <SetNonPrerequisiteImports>b__41_0(System.ComponentModel.Composition.Primitives.ImportDefinition import)
- internal bool <SetPrerequisiteImports>b__42_0(System.ComponentModel.Composition.Primitives.ImportDefinition import)

### private class System.ComponentModel.Composition.ReflectionModel.ReflectionPartCreationInfo.<>c

#### Fields
- public static readonly System.ComponentModel.Composition.ReflectionModel.ReflectionPartCreationInfo.<>c <>9
- public static System.Func<System.ComponentModel.Composition.ReflectionModel.ReflectionParameterImportDefinition, System.Reflection.MemberInfo> <>9__10_0

#### Constructors
- private static ReflectionPartCreationInfo.<>c()
- public ReflectionPartCreationInfo.<>c()

#### Methods
- internal System.Reflection.MemberInfo <GetConstructor>b__10_0(System.ComponentModel.Composition.ReflectionModel.ReflectionParameterImportDefinition parameterImport)

### private class System.ComponentModel.Composition.ReflectionModel.ExportFactoryCreator.LifetimeContext.<>c__6<T>

#### Fields
- public static readonly System.ComponentModel.Composition.ReflectionModel.ExportFactoryCreator.LifetimeContext.<>c__6<T> <>9
- public static System.Action <>9__6_1

#### Constructors
- private static ExportFactoryCreator.LifetimeContext.<>c__6<T>()
- public ExportFactoryCreator.LifetimeContext.<>c__6<T>()

#### Methods
- internal void <GetExportLifetimeContextFromExport>b__6_1()

### private class System.ComponentModel.Composition.ReflectionModel.GenericServices.<>c__DisplayClass0_0

#### Fields
- public System.Collections.Generic.List<System.Type> pureGenericParameters

#### Constructors
- public GenericServices.<>c__DisplayClass0_0()

#### Methods
- internal void <GetPureGenericParameters>b__0(System.Type t)

### private class System.ComponentModel.Composition.ReflectionModel.GenericSpecializationPartCreationInfo.<>c__DisplayClass13_0

#### Fields
- public System.ComponentModel.Composition.ReflectionModel.GenericSpecializationPartCreationInfo <>4__this
- public System.Type[] specialization

#### Constructors
- public GenericSpecializationPartCreationInfo.<>c__DisplayClass13_0()

#### Methods
- internal System.Type <.ctor>b__0()

### private class System.ComponentModel.Composition.ReflectionModel.GenericServices.<>c__DisplayClass1_0

#### Fields
- public int genericArity

#### Constructors
- public GenericServices.<>c__DisplayClass1_0()

#### Methods
- internal void <GetPureGenericArity>b__0(System.Type t)

### private class System.ComponentModel.Composition.ReflectionModel.GenericSpecializationPartCreationInfo.<>c__DisplayClass26_0

#### Fields
- public System.ComponentModel.Composition.ReflectionModel.GenericSpecializationPartCreationInfo <>4__this
- public System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo lazyMember

#### Constructors
- public GenericSpecializationPartCreationInfo.<>c__DisplayClass26_0()

#### Methods
- internal System.Reflection.MemberInfo[] <TranslateImport>b__0()

### private class System.ComponentModel.Composition.ReflectionModel.GenericSpecializationPartCreationInfo.<>c__DisplayClass26_1

#### Fields
- public System.ComponentModel.Composition.ReflectionModel.GenericSpecializationPartCreationInfo <>4__this
- public System.Lazy<System.Reflection.ParameterInfo> lazyParameter

#### Constructors
- public GenericSpecializationPartCreationInfo.<>c__DisplayClass26_1()

#### Methods
- internal System.Reflection.ParameterInfo <TranslateImport>b__1()

### private class System.ComponentModel.Composition.ReflectionModel.GenericSpecializationPartCreationInfo.<>c__DisplayClass28_0

#### Fields
- public System.ComponentModel.Composition.ReflectionModel.GenericSpecializationPartCreationInfo <>4__this
- public System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo capturedLazyMember
- public System.ComponentModel.Composition.ReflectionModel.ReflectionMemberExportDefinition capturedReflectionExport

#### Constructors
- public GenericSpecializationPartCreationInfo.<>c__DisplayClass28_0()

#### Methods
- internal System.Reflection.MemberInfo[] <TranslateExpot>b__0()
- internal System.Collections.Generic.IDictionary<string, object> <TranslateExpot>b__1()

### private class System.ComponentModel.Composition.ReflectionModel.ReflectionComposablePart.<>c__DisplayClass35_0

#### Fields
- public System.ComponentModel.Composition.ReflectionModel.ReflectionComposablePart <>4__this
- public object[] arguments

#### Constructors
- public ReflectionComposablePart.<>c__DisplayClass35_0()

#### Methods
- internal void <GetConstructorArguments>b__0(System.ComponentModel.Composition.ReflectionModel.ImportingItem import, System.ComponentModel.Composition.ReflectionModel.ReflectionParameterImportDefinition definition, object value)

### private class System.ComponentModel.Composition.ReflectionModel.ExportFactoryCreator.<>c__DisplayClass5_0

#### Fields
- public System.Func<System.ComponentModel.Composition.Primitives.Export, object> exportFactoryFactory

#### Constructors
- public ExportFactoryCreator.<>c__DisplayClass5_0()

#### Methods
- internal object <CreateStronglyTypedExportFactoryFactory>b__0(System.ComponentModel.Composition.Primitives.Export e)

### private class System.ComponentModel.Composition.ReflectionModel.GenericServices.<>c__DisplayClass6_0

#### Fields
- public System.Type[] specializationTypes

#### Constructors
- public GenericServices.<>c__DisplayClass6_0()

#### Methods
- internal System.Type <CreateTypeSpecializations>b__0(System.Type type)

### private class System.ComponentModel.Composition.ReflectionModel.ExportFactoryCreator.LifetimeContext.<>c__DisplayClass6_0<T>

#### Fields
- public System.IDisposable disposable

#### Constructors
- public ExportFactoryCreator.LifetimeContext.<>c__DisplayClass6_0<T>()

#### Methods
- internal void <GetExportLifetimeContextFromExport>b__0()

### private class System.ComponentModel.Composition.ReflectionModel.ExportFactoryCreator.<>c__DisplayClass6_0<T>

#### Fields
- public System.ComponentModel.Composition.Primitives.Export export
- public System.ComponentModel.Composition.ReflectionModel.ExportFactoryCreator.LifetimeContext lifetimeContext

#### Constructors
- public ExportFactoryCreator.<>c__DisplayClass6_0<T>()

#### Methods
- internal System.Tuple<T, System.Action> <CreateStronglyTypedExportFactoryOfT>b__0()

### private class System.ComponentModel.Composition.ReflectionModel.ExportFactoryCreator.<>c__DisplayClass7_0<T, M>

#### Fields
- public System.ComponentModel.Composition.Primitives.Export export
- public System.ComponentModel.Composition.ReflectionModel.ExportFactoryCreator.LifetimeContext lifetimeContext

#### Constructors
- public ExportFactoryCreator.<>c__DisplayClass7_0<T, M>()

#### Methods
- internal System.Tuple<T, System.Action> <CreateStronglyTypedExportFactoryOfTM>b__0()

### private class System.ComponentModel.Composition.ReflectionModel.ReflectionComposablePartDefinition.<GetCandidateParameters>d__21
- Interfaces: System.Collections.Generic.IEnumerable<System.Type[]>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Type[]>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private System.Type[] <>2__current
- public System.Type[] <>3__genericParameters
- public System.ComponentModel.Composition.ReflectionModel.ReflectionComposablePartDefinition <>4__this
- private System.Collections.Generic.IEnumerator<System.ComponentModel.Composition.Primitives.ExportDefinition> <>7__wrap1
- private int <>l__initialThreadId
- private System.Type[] genericParameters

#### Properties
- private System.Type[] System.Collections.Generic.IEnumerator<System.Type[]>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public ReflectionComposablePartDefinition.<GetCandidateParameters>d__21(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<System.Type[]> System.Collections.Generic.IEnumerable<System.Type[]>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class System.ComponentModel.Composition.ReflectionModel.ReflectionPartCreationInfo.<GetExports>d__14
- Interfaces: System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.ComponentModel.Composition.Primitives.ExportDefinition>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private System.ComponentModel.Composition.Primitives.ExportDefinition <>2__current
- public System.ComponentModel.Composition.ReflectionModel.ReflectionPartCreationInfo <>4__this
- private System.Collections.Generic.IEnumerator<System.ComponentModel.Composition.Primitives.ExportDefinition> <>7__wrap1
- private int <>l__initialThreadId

#### Properties
- private System.ComponentModel.Composition.Primitives.ExportDefinition System.Collections.Generic.IEnumerator<System.ComponentModel.Composition.Primitives.ExportDefinition>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public ReflectionPartCreationInfo.<GetExports>d__14(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<System.ComponentModel.Composition.Primitives.ExportDefinition> System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class System.ComponentModel.Composition.ReflectionModel.ReflectionPartCreationInfo.<GetImports>d__15
- Interfaces: System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.ComponentModel.Composition.Primitives.ImportDefinition>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private System.ComponentModel.Composition.Primitives.ImportDefinition <>2__current
- public System.ComponentModel.Composition.ReflectionModel.ReflectionPartCreationInfo <>4__this
- private System.Collections.Generic.IEnumerator<System.ComponentModel.Composition.Primitives.ImportDefinition> <>7__wrap1
- private int <>l__initialThreadId

#### Properties
- private System.ComponentModel.Composition.Primitives.ImportDefinition System.Collections.Generic.IEnumerator<System.ComponentModel.Composition.Primitives.ImportDefinition>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public ReflectionPartCreationInfo.<GetImports>d__15(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<System.ComponentModel.Composition.Primitives.ImportDefinition> System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### internal class System.ComponentModel.Composition.ReflectionModel.DisposableReflectionComposablePart
- Base: System.ComponentModel.Composition.ReflectionModel.ReflectionComposablePart
- Interfaces: System.ComponentModel.Composition.Primitives.ICompositionElement, System.IDisposable

#### Fields
- private int _isDisposed

#### Constructors
- public DisposableReflectionComposablePart(System.ComponentModel.Composition.ReflectionModel.ReflectionComposablePartDefinition definition)

#### Methods
- protected override void EnsureRunning()
- protected override void ReleaseInstanceIfNecessary(object instance)
- private void System.IDisposable.Dispose()

### internal class System.ComponentModel.Composition.ReflectionModel.ExportFactoryCreator

#### Fields
- private static readonly System.Reflection.MethodInfo _createStronglyTypedExportFactoryOfT
- private static readonly System.Reflection.MethodInfo _createStronglyTypedExportFactoryOfTM
- private System.Type _exportFactoryType

#### Constructors
- private static ExportFactoryCreator()
- public ExportFactoryCreator(System.Type exportFactoryType)

#### Methods
- public System.Func<System.ComponentModel.Composition.Primitives.Export, object> CreateStronglyTypedExportFactoryFactory(System.Type exportType, System.Type metadataViewType)
- private object CreateStronglyTypedExportFactoryOfT<T>(System.ComponentModel.Composition.Primitives.Export export)
- private object CreateStronglyTypedExportFactoryOfTM<T, M>(System.ComponentModel.Composition.Primitives.Export export)

### internal class System.ComponentModel.Composition.ReflectionModel.ExportingMember

#### Fields
- private object _cachedValue
- private readonly System.ComponentModel.Composition.Primitives.ExportDefinition _definition
- private bool _isValueCached
- private readonly System.ComponentModel.Composition.ReflectionModel.ReflectionMember _member

#### Properties
- public System.ComponentModel.Composition.Primitives.ExportDefinition Definition { get; }
- public bool RequiresInstance { get; }

#### Constructors
- public ExportingMember(System.ComponentModel.Composition.Primitives.ExportDefinition definition, System.ComponentModel.Composition.ReflectionModel.ReflectionMember member)

#### Methods
- private void EnsureReadable()
- public object GetExportedValue(object instance, object lock)

### internal static class System.ComponentModel.Composition.ReflectionModel.GenericServices

#### Methods
- public static bool CanSpecialize(System.Type type, System.Collections.Generic.IEnumerable<System.Type> constraints, System.Reflection.GenericParameterAttributes attributes)
- public static bool CanSpecialize(System.Type type, System.Collections.Generic.IEnumerable<System.Type> constraintTypes)
- public static bool CanSpecialize(System.Type type, System.Reflection.GenericParameterAttributes attributes)
- public static System.Type CreateTypeSpecialization(System.Type type, System.Type[] specializationTypes)
- public static System.Collections.Generic.IEnumerable<System.Type> CreateTypeSpecializations(System.Type[] types, System.Type[] specializationTypes)
- public static string GetGenericName(string originalGenericName, int[] genericParametersOrder, int genericArity)
- public static int[] GetGenericParametersOrder(System.Type type)
- internal static int GetPureGenericArity(System.Type type)
- internal static System.Collections.Generic.IList<System.Type> GetPureGenericParameters(System.Type type)
- public static T[] Reorder<T>(T[] original, int[] genericParametersOrder)
- private static void TraverseGenericType(System.Type type, System.Action<System.Type> onType)

### internal class System.ComponentModel.Composition.ReflectionModel.GenericSpecializationPartCreationInfo
- Interfaces: System.ComponentModel.Composition.ReflectionModel.IReflectionPartCreationInfo, System.ComponentModel.Composition.Primitives.ICompositionElement

#### Fields
- private System.Reflection.ConstructorInfo _constructor
- private System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> _exports
- private System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition> _imports
- private readonly System.Lazy<System.Type> _lazyPartType
- private object _lock
- private System.Collections.Generic.List<System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo> _members
- private System.Collections.Generic.Dictionary<System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo, System.Reflection.MemberInfo[]> _membersTable
- private readonly System.ComponentModel.Composition.ReflectionModel.ReflectionComposablePartDefinition _originalPart
- private readonly System.ComponentModel.Composition.ReflectionModel.IReflectionPartCreationInfo _originalPartCreationInfo
- private System.Collections.Generic.List<System.Lazy<System.Reflection.ParameterInfo>> _parameters
- private System.Collections.Generic.Dictionary<System.Lazy<System.Reflection.ParameterInfo>, System.Reflection.ParameterInfo> _parametersTable
- private readonly System.Type[] _specialization
- private readonly string[] _specializationIdentities

#### Properties
- public string DisplayName { get; }
- public bool IsDisposalRequired { get; }
- public System.ComponentModel.Composition.Primitives.ICompositionElement Origin { get; }
- public System.ComponentModel.Composition.ReflectionModel.ReflectionComposablePartDefinition OriginalPart { get; }

#### Constructors
- public GenericSpecializationPartCreationInfo(System.ComponentModel.Composition.ReflectionModel.IReflectionPartCreationInfo originalPartCreationInfo, System.ComponentModel.Composition.ReflectionModel.ReflectionComposablePartDefinition originalPart, System.Type[] specialization)

#### Methods
- private System.Collections.Generic.Dictionary<System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo, System.Reflection.MemberInfo[]> BuildMembersTable(System.Collections.Generic.List<System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo> members)
- private System.Collections.Generic.Dictionary<System.Lazy<System.Reflection.ParameterInfo>, System.Reflection.ParameterInfo> BuildParametersTable(System.Collections.Generic.List<System.Lazy<System.Reflection.ParameterInfo>> parameters)
- private void BuildTables()
- public static bool CanSpecialize(System.Collections.Generic.IDictionary<string, object> partMetadata, System.Type[] specialization)
- public override bool Equals(object obj)
- private System.Reflection.MemberInfo[] GetAccessors(System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo originalLazyMember)
- public System.Reflection.ConstructorInfo GetConstructor()
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> GetExports()
- public override int GetHashCode()
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition> GetImports()
- public System.Lazy<System.Type> GetLazyPartType()
- public System.Collections.Generic.IDictionary<string, object> GetMetadata()
- private System.Reflection.ParameterInfo GetParameter(System.Lazy<System.Reflection.ParameterInfo> originalParameter)
- public System.Type GetPartType()
- private System.Collections.Generic.List<System.ComponentModel.Composition.Primitives.ExportDefinition> PopulateExports(System.Collections.Generic.List<System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo> members)
- private System.Collections.Generic.List<System.ComponentModel.Composition.Primitives.ImportDefinition> PopulateImports(System.Collections.Generic.List<System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo> members, System.Collections.Generic.List<System.Lazy<System.Reflection.ParameterInfo>> parameters)
- private void PopulateImportsAndExports()
- private string Translate(string originalValue, int[] genericParametersOrder)
- private string Translate(string originalValue)
- private System.Collections.Generic.IDictionary<string, object> TranslateExportMetadata(System.ComponentModel.Composition.ReflectionModel.ReflectionMemberExportDefinition originalExport)
- public System.ComponentModel.Composition.Primitives.ExportDefinition TranslateExpot(System.ComponentModel.Composition.ReflectionModel.ReflectionMemberExportDefinition reflectionExport, System.Collections.Generic.List<System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo> members)
- private System.ComponentModel.Composition.Primitives.ImportDefinition TranslateImport(System.ComponentModel.Composition.ReflectionModel.ReflectionImportDefinition reflectionImport, System.Collections.Generic.List<System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo> members, System.Collections.Generic.List<System.Lazy<System.Reflection.ParameterInfo>> parameters)
- private System.Collections.Generic.IDictionary<string, object> TranslateImportMetadata(System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition originalImport)

### internal class System.ComponentModel.Composition.ReflectionModel.ImportingItem

#### Fields
- private readonly System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition _definition
- private readonly System.ComponentModel.Composition.ReflectionModel.ImportType _importType

#### Properties
- public System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition Definition { get; }
- public System.ComponentModel.Composition.ReflectionModel.ImportType ImportType { get; }

#### Constructors
- protected ImportingItem(System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition definition, System.ComponentModel.Composition.ReflectionModel.ImportType importType)

#### Methods
- private object Cast(System.Type type, System.ComponentModel.Composition.Primitives.Export export)
- private object CastExportsToCollectionImportType(System.ComponentModel.Composition.Primitives.Export[] exports)
- public object CastExportsToImportType(System.ComponentModel.Composition.Primitives.Export[] exports)
- private object CastExportsToSingleImportType(System.ComponentModel.Composition.Primitives.Export[] exports)
- private object CastSingleExportToImportType(System.Type type, System.ComponentModel.Composition.Primitives.Export export)

### internal class System.ComponentModel.Composition.ReflectionModel.ImportingMember
- Base: System.ComponentModel.Composition.ReflectionModel.ImportingItem

#### Fields
- private readonly System.ComponentModel.Composition.ReflectionModel.ReflectionWritableMember _member

#### Constructors
- public ImportingMember(System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition definition, System.ComponentModel.Composition.ReflectionModel.ReflectionWritableMember member, System.ComponentModel.Composition.ReflectionModel.ImportType importType)

#### Methods
- private void EnsureCollectionIsWritable(System.Collections.Generic.ICollection<object> collection)
- private void EnsureWritable()
- private System.Collections.Generic.ICollection<object> GetNormalizedCollection(System.Type itemType, object instance)
- private void PopulateCollection(System.Collections.Generic.ICollection<object> collection, System.Collections.IEnumerable values)
- private bool RequiresCollectionNormalization()
- private void SetCollectionMemberValue(object instance, System.Collections.IEnumerable values)
- public void SetExportedValue(object instance, object value)
- private void SetSingleMemberValue(object instance, object value)

### internal class System.ComponentModel.Composition.ReflectionModel.ImportingParameter
- Base: System.ComponentModel.Composition.ReflectionModel.ImportingItem

#### Constructors
- public ImportingParameter(System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition definition, System.ComponentModel.Composition.ReflectionModel.ImportType importType)

### internal class System.ComponentModel.Composition.ReflectionModel.ImportType

#### Fields
- private System.Type <ElementType>k__BackingField
- private bool <IsPartCreator>k__BackingField
- private System.Type <MetadataViewType>k__BackingField
- private static readonly System.Type ExportFactoryOfTMType
- private static readonly System.Type ExportFactoryOfTType
- private static readonly System.Type LazyOfTMType
- private static readonly System.Type LazyOfTType
- private System.Func<System.ComponentModel.Composition.Primitives.Export, object> _castSingleValue
- private readonly System.Type _contractType
- private readonly bool _isAssignableCollectionType
- private bool _isOpenGeneric
- private readonly System.Type _type

#### Properties
- public System.Type ActualType { get; }
- public System.Func<System.ComponentModel.Composition.Primitives.Export, object> CastExport { get; }
- public System.Type ContractType { get; }
- public System.Type ElementType { get; private set; }
- public bool IsAssignableCollectionType { get; }
- public bool IsPartCreator { get; private set; }
- public System.Type MetadataViewType { get; private set; }

#### Constructors
- private static ImportType()
- public ImportType(System.Type type, System.ComponentModel.Composition.Primitives.ImportCardinality cardinality)

#### Methods
- private System.Type CheckForCollection(System.Type type)
- private System.Type CheckForLazyAndPartCreator(System.Type type)
- public static bool IsDescendentOf(System.Type type, System.Type baseType)
- private static bool IsGenericDescendentOf(System.Type type, System.Type baseGenericTypeDefinition)
- private static bool IsTypeAssignableCollectionType(System.Type type)

### internal interface System.ComponentModel.Composition.ReflectionModel.IReflectionPartCreationInfo
- Interfaces: System.ComponentModel.Composition.Primitives.ICompositionElement

#### Properties
- public bool IsDisposalRequired { get; }

#### Methods
- public System.Reflection.ConstructorInfo GetConstructor()
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> GetExports()
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition> GetImports()
- public System.Lazy<System.Type> GetLazyPartType()
- public System.Collections.Generic.IDictionary<string, object> GetMetadata()
- public System.Type GetPartType()

### internal class System.ComponentModel.Composition.ReflectionModel.LazyExportDefinition
- Base: System.ComponentModel.Composition.Primitives.ExportDefinition

#### Fields
- private readonly System.Lazy<System.Collections.Generic.IDictionary<string, object>> _metadata

#### Properties
- public System.Collections.Generic.IDictionary<string, object> Metadata { get; }

#### Constructors
- public LazyExportDefinition(string contractName, System.Lazy<System.Collections.Generic.IDictionary<string, object>> metadata)

### public struct System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo

#### Fields
- private System.Reflection.MemberInfo[] _accessors
- private readonly System.Func<System.Reflection.MemberInfo[]> _accessorsCreator
- private readonly System.Reflection.MemberTypes _memberType

#### Properties
- public System.Reflection.MemberTypes MemberType { get; }

#### Constructors
- public LazyMemberInfo(System.Reflection.MemberInfo member)
- public LazyMemberInfo(System.Reflection.MemberTypes memberType, params System.Reflection.MemberInfo[] accessors)
- public LazyMemberInfo(System.Reflection.MemberTypes memberType, System.Func<System.Reflection.MemberInfo[]> accessorsCreator)

#### Methods
- private static bool AreAccessorsValid(System.Reflection.MemberTypes memberType, System.Reflection.MemberInfo[] accessors, out string errorMessage)
- private static void EnsureSupportedMemberType(System.Reflection.MemberTypes memberType, string argument)
- public override bool Equals(object obj)
- public System.Reflection.MemberInfo[] GetAccessors()
- public override int GetHashCode()
- public static bool op_Equality(System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo left, System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo right)
- public static bool op_Inequality(System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo left, System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo right)

### private class System.ComponentModel.Composition.ReflectionModel.ExportFactoryCreator.LifetimeContext

#### Fields
- private System.Func<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, bool> <CatalogFilter>k__BackingField
- private static System.Type[] types

#### Properties
- public System.Func<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, bool> CatalogFilter { get; private set; }

#### Constructors
- public ExportFactoryCreator.LifetimeContext()
- private static ExportFactoryCreator.LifetimeContext()

#### Methods
- public System.Tuple<T, System.Action> GetExportLifetimeContextFromExport<T>(System.ComponentModel.Composition.Primitives.Export export)
- public void SetInstance(object instance)

### internal class System.ComponentModel.Composition.ReflectionModel.PartCreatorExportDefinition
- Base: System.ComponentModel.Composition.Primitives.ExportDefinition

#### Fields
- private System.Collections.Generic.IDictionary<string, object> _metadata
- private readonly System.ComponentModel.Composition.Primitives.ExportDefinition _productDefinition

#### Properties
- public string ContractName { get; }
- public System.Collections.Generic.IDictionary<string, object> Metadata { get; }

#### Constructors
- public PartCreatorExportDefinition(System.ComponentModel.Composition.Primitives.ExportDefinition productDefinition)

#### Methods
- internal static bool IsProductConstraintSatisfiedBy(System.ComponentModel.Composition.Primitives.ImportDefinition productImportDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition exportDefinition)

### internal class System.ComponentModel.Composition.ReflectionModel.PartCreatorMemberImportDefinition
- Base: System.ComponentModel.Composition.ReflectionModel.ReflectionMemberImportDefinition
- Interfaces: System.ComponentModel.Composition.Primitives.ICompositionElement, System.ComponentModel.Composition.Primitives.IPartCreatorImportDefinition

#### Fields
- private readonly System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition _productImportDefinition

#### Properties
- public System.Linq.Expressions.Expression<System.Func<System.ComponentModel.Composition.Primitives.ExportDefinition, bool>> Constraint { get; }
- public System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition ProductImportDefinition { get; }

#### Constructors
- public PartCreatorMemberImportDefinition(System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo importingLazyMember, System.ComponentModel.Composition.Primitives.ICompositionElement origin, System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition productImportDefinition)

#### Methods
- public override bool IsConstraintSatisfiedBy(System.ComponentModel.Composition.Primitives.ExportDefinition exportDefinition)

### internal class System.ComponentModel.Composition.ReflectionModel.PartCreatorParameterImportDefinition
- Base: System.ComponentModel.Composition.ReflectionModel.ReflectionParameterImportDefinition
- Interfaces: System.ComponentModel.Composition.Primitives.ICompositionElement, System.ComponentModel.Composition.Primitives.IPartCreatorImportDefinition

#### Fields
- private readonly System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition _productImportDefinition

#### Properties
- public System.Linq.Expressions.Expression<System.Func<System.ComponentModel.Composition.Primitives.ExportDefinition, bool>> Constraint { get; }
- public System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition ProductImportDefinition { get; }

#### Constructors
- public PartCreatorParameterImportDefinition(System.Lazy<System.Reflection.ParameterInfo> importingLazyParameter, System.ComponentModel.Composition.Primitives.ICompositionElement origin, System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition productImportDefinition)

#### Methods
- public override bool IsConstraintSatisfiedBy(System.ComponentModel.Composition.Primitives.ExportDefinition exportDefinition)

### internal class System.ComponentModel.Composition.ReflectionModel.ReflectionComposablePart
- Base: System.ComponentModel.Composition.Primitives.ComposablePart
- Interfaces: System.ComponentModel.Composition.Primitives.ICompositionElement

#### Fields
- private object _cachedInstance
- private readonly System.ComponentModel.Composition.ReflectionModel.ReflectionComposablePartDefinition _definition
- private readonly System.Collections.Generic.Dictionary<int, System.ComponentModel.Composition.ReflectionModel.ExportingMember> _exportsCache
- private readonly System.Collections.Generic.Dictionary<System.ComponentModel.Composition.Primitives.ImportDefinition, System.ComponentModel.Composition.ReflectionModel.ImportingItem> _importsCache
- private readonly System.Collections.Generic.Dictionary<System.ComponentModel.Composition.Primitives.ImportDefinition, object> _importValues
- private bool _initialCompositionComplete
- private bool _invokeImportsSatisfied
- private bool _invokingImportsSatisfied
- private object _lock

#### Properties
- protected object CachedInstance { get; }
- public System.ComponentModel.Composition.ReflectionModel.ReflectionComposablePartDefinition Definition { get; }
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> ExportDefinitions { get; }
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition> ImportDefinitions { get; }
- public System.Collections.Generic.IDictionary<string, object> Metadata { get; }
- private string System.ComponentModel.Composition.Primitives.ICompositionElement.DisplayName { get; }
- private System.ComponentModel.Composition.Primitives.ICompositionElement System.ComponentModel.Composition.Primitives.ICompositionElement.Origin { get; }

#### Constructors
- public ReflectionComposablePart(System.ComponentModel.Composition.ReflectionModel.ReflectionComposablePartDefinition definition)
- public ReflectionComposablePart(System.ComponentModel.Composition.ReflectionModel.ReflectionComposablePartDefinition definition, object attributedPart)

#### Methods
- private bool <RequiresActivation>b__36_0(System.ComponentModel.Composition.Primitives.ExportDefinition definition)
- public override void Activate()
- private object CreateInstance(System.Reflection.ConstructorInfo constructor, object[] arguments)
- private static void EnsureCardinality(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.ComponentModel.Composition.Primitives.Export[] exports)
- private void EnsureGettable()
- protected virtual void EnsureRunning()
- private void EnsureSettable(System.ComponentModel.Composition.Primitives.ImportDefinition definition)
- private object[] GetConstructorArguments()
- private string GetDisplayName()
- public override object GetExportedValue(System.ComponentModel.Composition.Primitives.ExportDefinition definition)
- private object GetExportedValue(System.ComponentModel.Composition.ReflectionModel.ExportingMember member)
- private static System.ComponentModel.Composition.ReflectionModel.ExportingMember GetExportingMember(System.ComponentModel.Composition.Primitives.ExportDefinition definition)
- private System.ComponentModel.Composition.ReflectionModel.ExportingMember GetExportingMemberFromDefinition(System.ComponentModel.Composition.Primitives.ExportDefinition definition)
- private static System.ComponentModel.Composition.ReflectionModel.ImportingItem GetImportingItem(System.ComponentModel.Composition.Primitives.ImportDefinition definition)
- private System.ComponentModel.Composition.ReflectionModel.ImportingItem GetImportingItemFromDefinition(System.ComponentModel.Composition.Primitives.ImportDefinition definition)
- private object GetInstanceActivatingIfNeeded()
- private void NotifyImportSatisfied()
- protected virtual void ReleaseInstanceIfNecessary(object instance)
- private bool RequiresActivation()
- protected void RequiresRunning()
- private void SetExportedValueForImport(System.ComponentModel.Composition.ReflectionModel.ImportingItem import, System.ComponentModel.Composition.Primitives.ImportDefinition definition, object value)
- public override void SetImport(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> exports)
- private void SetImport(System.ComponentModel.Composition.ReflectionModel.ImportingItem item, System.ComponentModel.Composition.Primitives.Export[] exports)
- private void SetNonPrerequisiteImports()
- private void SetPrerequisiteImports()
- public override string ToString()
- private bool TryGetImportValue(System.ComponentModel.Composition.Primitives.ImportDefinition definition, out object value)
- private void UseImportedValues<TImportDefinition>(System.Collections.Generic.IEnumerable<TImportDefinition> definitions, System.Action<System.ComponentModel.Composition.ReflectionModel.ImportingItem, TImportDefinition, object> useImportValue, bool errorIfMissing)

### internal class System.ComponentModel.Composition.ReflectionModel.ReflectionComposablePartDefinition
- Base: System.ComponentModel.Composition.Primitives.ComposablePartDefinition
- Interfaces: System.ComponentModel.Composition.Primitives.ICompositionElement

#### Fields
- private System.Reflection.ConstructorInfo _constructor
- private readonly System.ComponentModel.Composition.ReflectionModel.IReflectionPartCreationInfo _creationInfo
- private System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> _exports
- private System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition> _imports
- private object _lock
- private System.Collections.Generic.IDictionary<string, object> _metadata

#### Properties
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> ExportDefinitions { get; }
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition> ImportDefinitions { get; }
- internal bool IsDisposalRequired { get; }
- public System.Collections.Generic.IDictionary<string, object> Metadata { get; }
- private string System.ComponentModel.Composition.Primitives.ICompositionElement.DisplayName { get; }
- private System.ComponentModel.Composition.Primitives.ICompositionElement System.ComponentModel.Composition.Primitives.ICompositionElement.Origin { get; }

#### Constructors
- public ReflectionComposablePartDefinition(System.ComponentModel.Composition.ReflectionModel.IReflectionPartCreationInfo creationInfo)

#### Methods
- public override System.ComponentModel.Composition.Primitives.ComposablePart CreatePart()
- public override bool Equals(object obj)
- private System.Collections.Generic.IEnumerable<System.Type[]> GetCandidateParameters(System.Type[] genericParameters)
- public System.Reflection.ConstructorInfo GetConstructor()
- internal override System.Collections.Generic.IEnumerable<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>> GetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition)
- internal override System.ComponentModel.Composition.Primitives.ComposablePartDefinition GetGenericPartDefinition()
- public override int GetHashCode()
- public System.Lazy<System.Type> GetLazyPartType()
- public System.Type GetPartType()
- public override string ToString()
- private static bool TryGetGenericTypeParameters(System.Collections.Generic.IEnumerable<object> genericParameters, out System.Type[] genericTypeParameters)
- internal bool TryMakeGenericPartDefinition(System.Type[] genericTypeParameters, out System.ComponentModel.Composition.Primitives.ComposablePartDefinition genericPartDefinition)

### internal static class System.ComponentModel.Composition.ReflectionModel.ReflectionExtensions

#### Methods
- public static System.ComponentModel.Composition.ReflectionModel.ReflectionProperty CreateReflectionProperty(System.Reflection.MethodInfo getMethod, System.Reflection.MethodInfo setMethod)
- public static System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo ToLazyMember(System.Reflection.MemberInfo member)
- public static System.ComponentModel.Composition.ReflectionModel.ReflectionField ToReflectionField(System.Reflection.FieldInfo field)
- public static System.ComponentModel.Composition.ReflectionModel.ReflectionMember ToReflectionMember(System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo lazyMember)
- public static System.ComponentModel.Composition.ReflectionModel.ReflectionMethod ToReflectionMethod(System.Reflection.MethodInfo method)
- public static System.ComponentModel.Composition.ReflectionModel.ReflectionParameter ToReflectionParameter(System.Reflection.ParameterInfo parameter)
- public static System.ComponentModel.Composition.ReflectionModel.ReflectionProperty ToReflectionProperty(System.Reflection.PropertyInfo property)
- public static System.ComponentModel.Composition.ReflectionModel.ReflectionType ToReflectionType(System.Type type)
- public static System.ComponentModel.Composition.ReflectionModel.ReflectionWritableMember ToReflectionWritableMember(System.Reflection.MemberInfo member)
- public static System.ComponentModel.Composition.ReflectionModel.ReflectionWritableMember ToReflectionWriteableMember(System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo lazyMember)

### internal class System.ComponentModel.Composition.ReflectionModel.ReflectionField
- Base: System.ComponentModel.Composition.ReflectionModel.ReflectionWritableMember

#### Fields
- private readonly System.Reflection.FieldInfo _field

#### Properties
- public bool CanRead { get; }
- public bool CanWrite { get; }
- public System.ComponentModel.Composition.ReflectionModel.ReflectionItemType ItemType { get; }
- public bool RequiresInstance { get; }
- public System.Type ReturnType { get; }
- public System.Reflection.FieldInfo UndelyingField { get; }
- public System.Reflection.MemberInfo UnderlyingMember { get; }

#### Constructors
- public ReflectionField(System.Reflection.FieldInfo field)

#### Methods
- public override object GetValue(object instance)
- public override void SetValue(object instance, object value)

### internal class System.ComponentModel.Composition.ReflectionModel.ReflectionImportDefinition
- Base: System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition
- Interfaces: System.ComponentModel.Composition.Primitives.ICompositionElement

#### Fields
- private readonly System.ComponentModel.Composition.Primitives.ICompositionElement _origin

#### Properties
- private string System.ComponentModel.Composition.Primitives.ICompositionElement.DisplayName { get; }
- private System.ComponentModel.Composition.Primitives.ICompositionElement System.ComponentModel.Composition.Primitives.ICompositionElement.Origin { get; }

#### Constructors
- public ReflectionImportDefinition(string contractName, string requiredTypeIdentity, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Type>> requiredMetadata, System.ComponentModel.Composition.Primitives.ImportCardinality cardinality, bool isRecomposable, bool isPrerequisite, System.ComponentModel.Composition.CreationPolicy requiredCreationPolicy, System.Collections.Generic.IDictionary<string, object> metadata, System.ComponentModel.Composition.Primitives.ICompositionElement origin)

#### Methods
- protected abstract string GetDisplayName()
- public abstract System.ComponentModel.Composition.ReflectionModel.ImportingItem ToImportingItem()

### internal class System.ComponentModel.Composition.ReflectionModel.ReflectionItem

#### Properties
- public System.ComponentModel.Composition.ReflectionModel.ReflectionItemType ItemType { get; }
- public string Name { get; }
- public System.Type ReturnType { get; }

#### Constructors
- protected ReflectionItem()

#### Methods
- public abstract string GetDisplayName()

### internal enum System.ComponentModel.Composition.ReflectionModel.ReflectionItemType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Field = 1
- Method = 3
- Parameter = 0
- Property = 2
- Type = 4

### internal class System.ComponentModel.Composition.ReflectionModel.ReflectionMember
- Base: System.ComponentModel.Composition.ReflectionModel.ReflectionItem

#### Properties
- public bool CanRead { get; }
- public System.Type DeclaringType { get; }
- public string Name { get; }
- public bool RequiresInstance { get; }
- public System.Reflection.MemberInfo UnderlyingMember { get; }

#### Constructors
- protected ReflectionMember()

#### Methods
- public override string GetDisplayName()
- public abstract object GetValue(object instance)

### internal class System.ComponentModel.Composition.ReflectionModel.ReflectionMemberExportDefinition
- Base: System.ComponentModel.Composition.Primitives.ExportDefinition
- Interfaces: System.ComponentModel.Composition.Primitives.ICompositionElement

#### Fields
- private readonly System.ComponentModel.Composition.Primitives.ExportDefinition _exportDefinition
- private readonly System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo _member
- private System.Collections.Generic.IDictionary<string, object> _metadata
- private readonly System.ComponentModel.Composition.Primitives.ICompositionElement _origin

#### Properties
- public string ContractName { get; }
- public System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo ExportingLazyMember { get; }
- public System.Collections.Generic.IDictionary<string, object> Metadata { get; }
- private string System.ComponentModel.Composition.Primitives.ICompositionElement.DisplayName { get; }
- private System.ComponentModel.Composition.Primitives.ICompositionElement System.ComponentModel.Composition.Primitives.ICompositionElement.Origin { get; }

#### Constructors
- public ReflectionMemberExportDefinition(System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo member, System.ComponentModel.Composition.Primitives.ExportDefinition exportDefinition, System.ComponentModel.Composition.Primitives.ICompositionElement origin)

#### Methods
- private string GetDisplayName()
- public int GetIndex()
- public System.ComponentModel.Composition.ReflectionModel.ExportingMember ToExportingMember()
- private System.ComponentModel.Composition.ReflectionModel.ReflectionMember ToReflectionMember()
- public override string ToString()

### internal class System.ComponentModel.Composition.ReflectionModel.ReflectionMemberImportDefinition
- Base: System.ComponentModel.Composition.ReflectionModel.ReflectionImportDefinition
- Interfaces: System.ComponentModel.Composition.Primitives.ICompositionElement

#### Fields
- private System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo _importingLazyMember

#### Properties
- public System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo ImportingLazyMember { get; }

#### Constructors
- public ReflectionMemberImportDefinition(System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo importingLazyMember, string contractName, string requiredTypeIdentity, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Type>> requiredMetadata, System.ComponentModel.Composition.Primitives.ImportCardinality cardinality, bool isRecomposable, bool isPrerequisite, System.ComponentModel.Composition.CreationPolicy requiredCreationPolicy, System.Collections.Generic.IDictionary<string, object> metadata, System.ComponentModel.Composition.Primitives.ICompositionElement origin)

#### Methods
- protected override string GetDisplayName()
- public override System.ComponentModel.Composition.ReflectionModel.ImportingItem ToImportingItem()

### internal class System.ComponentModel.Composition.ReflectionModel.ReflectionMethod
- Base: System.ComponentModel.Composition.ReflectionModel.ReflectionMember

#### Fields
- private readonly System.Reflection.MethodInfo _method

#### Properties
- public bool CanRead { get; }
- public System.ComponentModel.Composition.ReflectionModel.ReflectionItemType ItemType { get; }
- public bool RequiresInstance { get; }
- public System.Type ReturnType { get; }
- public System.Reflection.MemberInfo UnderlyingMember { get; }
- public System.Reflection.MethodInfo UnderlyingMethod { get; }

#### Constructors
- public ReflectionMethod(System.Reflection.MethodInfo method)

#### Methods
- public override object GetValue(object instance)
- private static System.ComponentModel.Composition.Primitives.ExportedDelegate SafeCreateExportedDelegate(object instance, System.Reflection.MethodInfo method)

### public static class System.ComponentModel.Composition.ReflectionModel.ReflectionModelServices

#### Methods
- public static System.ComponentModel.Composition.Primitives.ExportDefinition CreateExportDefinition(System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo exportingMember, string contractName, System.Lazy<System.Collections.Generic.IDictionary<string, object>> metadata, System.ComponentModel.Composition.Primitives.ICompositionElement origin)
- public static System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition CreateImportDefinition(System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo importingMember, string contractName, string requiredTypeIdentity, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Type>> requiredMetadata, System.ComponentModel.Composition.Primitives.ImportCardinality cardinality, bool isRecomposable, System.ComponentModel.Composition.CreationPolicy requiredCreationPolicy, System.ComponentModel.Composition.Primitives.ICompositionElement origin)
- public static System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition CreateImportDefinition(System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo importingMember, string contractName, string requiredTypeIdentity, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Type>> requiredMetadata, System.ComponentModel.Composition.Primitives.ImportCardinality cardinality, bool isRecomposable, System.ComponentModel.Composition.CreationPolicy requiredCreationPolicy, System.Collections.Generic.IDictionary<string, object> metadata, bool isExportFactory, System.ComponentModel.Composition.Primitives.ICompositionElement origin)
- public static System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition CreateImportDefinition(System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo importingMember, string contractName, string requiredTypeIdentity, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Type>> requiredMetadata, System.ComponentModel.Composition.Primitives.ImportCardinality cardinality, bool isRecomposable, bool isPreRequisite, System.ComponentModel.Composition.CreationPolicy requiredCreationPolicy, System.Collections.Generic.IDictionary<string, object> metadata, bool isExportFactory, System.ComponentModel.Composition.Primitives.ICompositionElement origin)
- public static System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition CreateImportDefinition(System.Lazy<System.Reflection.ParameterInfo> parameter, string contractName, string requiredTypeIdentity, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Type>> requiredMetadata, System.ComponentModel.Composition.Primitives.ImportCardinality cardinality, System.ComponentModel.Composition.CreationPolicy requiredCreationPolicy, System.ComponentModel.Composition.Primitives.ICompositionElement origin)
- public static System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition CreateImportDefinition(System.Lazy<System.Reflection.ParameterInfo> parameter, string contractName, string requiredTypeIdentity, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Type>> requiredMetadata, System.ComponentModel.Composition.Primitives.ImportCardinality cardinality, System.ComponentModel.Composition.CreationPolicy requiredCreationPolicy, System.Collections.Generic.IDictionary<string, object> metadata, bool isExportFactory, System.ComponentModel.Composition.Primitives.ICompositionElement origin)
- public static System.ComponentModel.Composition.Primitives.ComposablePartDefinition CreatePartDefinition(System.Lazy<System.Type> partType, bool isDisposalRequired, System.Lazy<System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition>> imports, System.Lazy<System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition>> exports, System.Lazy<System.Collections.Generic.IDictionary<string, object>> metadata, System.ComponentModel.Composition.Primitives.ICompositionElement origin)
- public static System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition GetExportFactoryProductImportDefinition(System.ComponentModel.Composition.Primitives.ImportDefinition importDefinition)
- public static System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo GetExportingMember(System.ComponentModel.Composition.Primitives.ExportDefinition exportDefinition)
- public static System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo GetImportingMember(System.ComponentModel.Composition.Primitives.ImportDefinition importDefinition)
- public static System.Lazy<System.Reflection.ParameterInfo> GetImportingParameter(System.ComponentModel.Composition.Primitives.ImportDefinition importDefinition)
- public static System.Lazy<System.Type> GetPartType(System.ComponentModel.Composition.Primitives.ComposablePartDefinition partDefinition)
- public static bool IsDisposalRequired(System.ComponentModel.Composition.Primitives.ComposablePartDefinition partDefinition)
- public static bool IsExportFactoryImportDefinition(System.ComponentModel.Composition.Primitives.ImportDefinition importDefinition)
- public static bool IsImportingParameter(System.ComponentModel.Composition.Primitives.ImportDefinition importDefinition)
- public static bool TryMakeGenericPartDefinition(System.ComponentModel.Composition.Primitives.ComposablePartDefinition partDefinition, System.Collections.Generic.IEnumerable<System.Type> genericParameters, out System.ComponentModel.Composition.Primitives.ComposablePartDefinition specialization)

### internal class System.ComponentModel.Composition.ReflectionModel.ReflectionParameter
- Base: System.ComponentModel.Composition.ReflectionModel.ReflectionItem

#### Fields
- private readonly System.Reflection.ParameterInfo _parameter

#### Properties
- public System.ComponentModel.Composition.ReflectionModel.ReflectionItemType ItemType { get; }
- public string Name { get; }
- public System.Type ReturnType { get; }
- public System.Reflection.ParameterInfo UnderlyingParameter { get; }

#### Constructors
- public ReflectionParameter(System.Reflection.ParameterInfo parameter)

#### Methods
- public override string GetDisplayName()

### internal class System.ComponentModel.Composition.ReflectionModel.ReflectionParameterImportDefinition
- Base: System.ComponentModel.Composition.ReflectionModel.ReflectionImportDefinition
- Interfaces: System.ComponentModel.Composition.Primitives.ICompositionElement

#### Fields
- private System.Lazy<System.Reflection.ParameterInfo> _importingLazyParameter

#### Properties
- public System.Lazy<System.Reflection.ParameterInfo> ImportingLazyParameter { get; }

#### Constructors
- public ReflectionParameterImportDefinition(System.Lazy<System.Reflection.ParameterInfo> importingLazyParameter, string contractName, string requiredTypeIdentity, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Type>> requiredMetadata, System.ComponentModel.Composition.Primitives.ImportCardinality cardinality, System.ComponentModel.Composition.CreationPolicy requiredCreationPolicy, System.Collections.Generic.IDictionary<string, object> metadata, System.ComponentModel.Composition.Primitives.ICompositionElement origin)

#### Methods
- protected override string GetDisplayName()
- public override System.ComponentModel.Composition.ReflectionModel.ImportingItem ToImportingItem()

### internal class System.ComponentModel.Composition.ReflectionModel.ReflectionPartCreationInfo
- Interfaces: System.ComponentModel.Composition.ReflectionModel.IReflectionPartCreationInfo, System.ComponentModel.Composition.Primitives.ICompositionElement

#### Fields
- private System.Reflection.ConstructorInfo _constructor
- private readonly System.Lazy<System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition>> _exports
- private readonly System.Lazy<System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition>> _imports
- private bool _isDisposalRequired
- private readonly System.Lazy<System.Collections.Generic.IDictionary<string, object>> _metadata
- private readonly System.ComponentModel.Composition.Primitives.ICompositionElement _origin
- private readonly System.Lazy<System.Type> _partType

#### Properties
- public string DisplayName { get; }
- public bool IsDisposalRequired { get; }
- public System.ComponentModel.Composition.Primitives.ICompositionElement Origin { get; }

#### Constructors
- public ReflectionPartCreationInfo(System.Lazy<System.Type> partType, bool isDisposalRequired, System.Lazy<System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition>> imports, System.Lazy<System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition>> exports, System.Lazy<System.Collections.Generic.IDictionary<string, object>> metadata, System.ComponentModel.Composition.Primitives.ICompositionElement origin)

#### Methods
- public System.Reflection.ConstructorInfo GetConstructor()
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> GetExports()
- public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition> GetImports()
- public System.Lazy<System.Type> GetLazyPartType()
- public System.Collections.Generic.IDictionary<string, object> GetMetadata()
- public System.Type GetPartType()

### internal class System.ComponentModel.Composition.ReflectionModel.ReflectionProperty
- Base: System.ComponentModel.Composition.ReflectionModel.ReflectionWritableMember

#### Fields
- private readonly System.Reflection.MethodInfo _getMethod
- private readonly System.Reflection.MethodInfo _setMethod

#### Properties
- public bool CanRead { get; }
- public bool CanWrite { get; }
- public System.ComponentModel.Composition.ReflectionModel.ReflectionItemType ItemType { get; }
- public string Name { get; }
- public bool RequiresInstance { get; }
- public System.Type ReturnType { get; }
- public System.Reflection.MethodInfo UnderlyingGetMethod { get; }
- public System.Reflection.MemberInfo UnderlyingMember { get; }
- public System.Reflection.MethodInfo UnderlyingSetMethod { get; }

#### Constructors
- public ReflectionProperty(System.Reflection.MethodInfo getMethod, System.Reflection.MethodInfo setMethod)

#### Methods
- public override string GetDisplayName()
- public override object GetValue(object instance)
- public override void SetValue(object instance, object value)

### internal class System.ComponentModel.Composition.ReflectionModel.ReflectionType
- Base: System.ComponentModel.Composition.ReflectionModel.ReflectionMember

#### Fields
- private System.Type _type

#### Properties
- public bool CanRead { get; }
- public System.ComponentModel.Composition.ReflectionModel.ReflectionItemType ItemType { get; }
- public bool RequiresInstance { get; }
- public System.Type ReturnType { get; }
- public System.Reflection.MemberInfo UnderlyingMember { get; }

#### Constructors
- public ReflectionType(System.Type type)

#### Methods
- public override object GetValue(object instance)

### internal class System.ComponentModel.Composition.ReflectionModel.ReflectionWritableMember
- Base: System.ComponentModel.Composition.ReflectionModel.ReflectionMember

#### Properties
- public bool CanWrite { get; }

#### Constructors
- protected ReflectionWritableMember()

#### Methods
- public abstract void SetValue(object instance, object value)

## Namespace: Unity

### internal class Unity.ThrowStub
- Base: System.ObjectDisposedException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Methods
- public static void ThrowNotSupportedException()

