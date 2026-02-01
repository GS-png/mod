# Assembly: UnityEngine.SharedInternalsModule
- Path: tools/WorldBox.Managed/UnityEngine.SharedInternalsModule.dll
- Types: 45

## Namespace: UnityEngine

### internal class UnityEngine.AssetFileNameExtensionAttribute
- Base: System.Attribute

#### Fields
- private readonly System.Collections.Generic.IEnumerable<string> <otherExtensions>k__BackingField
- private readonly string <preferredExtension>k__BackingField

#### Properties
- public System.Collections.Generic.IEnumerable<string> otherExtensions { get; }
- public string preferredExtension { get; }

#### Constructors
- public AssetFileNameExtensionAttribute(string preferredExtension, params string[] otherExtensions)

### internal class UnityEngine.IL2CPPStructAlignmentAttribute
- Base: System.Attribute

#### Fields
- public int Align

#### Constructors
- public IL2CPPStructAlignmentAttribute()

### internal class UnityEngine.NativeClassAttribute
- Base: System.Attribute

#### Fields
- private string <Declaration>k__BackingField
- private string <QualifiedNativeName>k__BackingField

#### Properties
- public string Declaration { get; private set; }
- public string QualifiedNativeName { get; private set; }

#### Constructors
- public NativeClassAttribute(string qualifiedCppName)
- public NativeClassAttribute(string qualifiedCppName, string declaration)

### internal class UnityEngine.RejectDragAndDropMaterial
- Base: System.Attribute

#### Constructors
- public RejectDragAndDropMaterial()

### internal class UnityEngine.ThreadAndSerializationSafeAttribute
- Base: System.Attribute

#### Constructors
- public ThreadAndSerializationSafeAttribute()

### internal class UnityEngine.UnityEngineModuleAssembly
- Base: System.Attribute

#### Constructors
- public UnityEngineModuleAssembly()

### internal class UnityEngine.UnityString

#### Constructors
- public UnityString()

#### Methods
- public static string Format(string fmt, params object[] args)

### internal class UnityEngine.WritableAttribute
- Base: System.Attribute

#### Constructors
- public WritableAttribute()

## Namespace: UnityEngine.Bindings

### internal enum UnityEngine.Bindings.CodegenOptions
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Auto = 0
- Custom = 1
- Force = 2

### internal class UnityEngine.Bindings.FreeFunctionAttribute
- Base: UnityEngine.Bindings.NativeMethodAttribute
- Interfaces: UnityEngine.Bindings.IBindingsNameProviderAttribute, UnityEngine.Bindings.IBindingsAttribute, UnityEngine.Bindings.IBindingsIsThreadSafeProviderAttribute, UnityEngine.Bindings.IBindingsIsFreeFunctionProviderAttribute, UnityEngine.Bindings.IBindingsThrowsProviderAttribute

#### Constructors
- public FreeFunctionAttribute()
- public FreeFunctionAttribute(string name)
- public FreeFunctionAttribute(string name, bool isThreadSafe)

### internal interface UnityEngine.Bindings.IBindingsAttribute

### internal interface UnityEngine.Bindings.IBindingsGenerateMarshallingTypeAttribute
- Interfaces: UnityEngine.Bindings.IBindingsAttribute

#### Properties
- public UnityEngine.Bindings.CodegenOptions CodegenOptions { get; set; }

### internal interface UnityEngine.Bindings.IBindingsHeaderProviderAttribute
- Interfaces: UnityEngine.Bindings.IBindingsAttribute

#### Properties
- public string Header { get; set; }

### internal interface UnityEngine.Bindings.IBindingsIsFreeFunctionProviderAttribute
- Interfaces: UnityEngine.Bindings.IBindingsAttribute

#### Properties
- public bool HasExplicitThis { get; set; }
- public bool IsFreeFunction { get; set; }

### internal interface UnityEngine.Bindings.IBindingsIsThreadSafeProviderAttribute
- Interfaces: UnityEngine.Bindings.IBindingsAttribute

#### Properties
- public bool IsThreadSafe { get; set; }

### internal interface UnityEngine.Bindings.IBindingsMarshalAsSpan

#### Properties
- public bool IsReadOnly { get; }
- public string SizeParameter { get; }

### internal interface UnityEngine.Bindings.IBindingsNameProviderAttribute
- Interfaces: UnityEngine.Bindings.IBindingsAttribute

#### Properties
- public string Name { get; set; }

### internal interface UnityEngine.Bindings.IBindingsPreventExecution

#### Properties
- public string howToFix { get; set; }
- public UnityEngine.Bindings.PreventExecutionSeverity severity { get; set; }
- public object singleFlagValue { get; set; }

### internal interface UnityEngine.Bindings.IBindingsThrowsProviderAttribute
- Interfaces: UnityEngine.Bindings.IBindingsAttribute

#### Properties
- public bool ThrowsException { get; set; }

### internal interface UnityEngine.Bindings.IBindingsWritableSelfProviderAttribute
- Interfaces: UnityEngine.Bindings.IBindingsAttribute

#### Properties
- public bool WritableSelf { get; set; }

### internal class UnityEngine.Bindings.IgnoreAttribute
- Base: System.Attribute
- Interfaces: UnityEngine.Bindings.IBindingsAttribute

#### Fields
- private bool <DoesNotContributeToSize>k__BackingField

#### Properties
- public bool DoesNotContributeToSize { get; set; }

#### Constructors
- public IgnoreAttribute()

### internal class UnityEngine.Bindings.MarshalUnityObjectAs
- Base: System.Attribute
- Interfaces: UnityEngine.Bindings.IBindingsAttribute

#### Fields
- private System.Type <MarshalAsType>k__BackingField

#### Properties
- public System.Type MarshalAsType { get; set; }

#### Constructors
- public MarshalUnityObjectAs(System.Type marshalAsType)

### internal class UnityEngine.Bindings.NativeAsStructAttribute
- Base: System.Attribute
- Interfaces: UnityEngine.Bindings.IBindingsAttribute

#### Constructors
- public NativeAsStructAttribute()

### internal class UnityEngine.Bindings.NativeConditionalAttribute
- Base: System.Attribute
- Interfaces: UnityEngine.Bindings.IBindingsAttribute

#### Fields
- private string <Condition>k__BackingField
- private bool <Enabled>k__BackingField
- private string <StubReturnStatement>k__BackingField

#### Properties
- public string Condition { get; set; }
- public bool Enabled { get; set; }
- public string StubReturnStatement { get; set; }

#### Constructors
- public NativeConditionalAttribute()
- public NativeConditionalAttribute(string condition)
- public NativeConditionalAttribute(bool enabled)
- public NativeConditionalAttribute(string condition, bool enabled)
- public NativeConditionalAttribute(string condition, string stubReturnStatement)
- public NativeConditionalAttribute(string condition, string stubReturnStatement, bool enabled)

### internal class UnityEngine.Bindings.NativeHeaderAttribute
- Base: System.Attribute
- Interfaces: UnityEngine.Bindings.IBindingsHeaderProviderAttribute, UnityEngine.Bindings.IBindingsAttribute

#### Fields
- private string <Header>k__BackingField

#### Properties
- public string Header { get; set; }

#### Constructors
- public NativeHeaderAttribute()
- public NativeHeaderAttribute(string header)

### internal class UnityEngine.Bindings.NativeMethodAttribute
- Base: System.Attribute
- Interfaces: UnityEngine.Bindings.IBindingsNameProviderAttribute, UnityEngine.Bindings.IBindingsAttribute, UnityEngine.Bindings.IBindingsIsThreadSafeProviderAttribute, UnityEngine.Bindings.IBindingsIsFreeFunctionProviderAttribute, UnityEngine.Bindings.IBindingsThrowsProviderAttribute

#### Fields
- private bool <HasExplicitThis>k__BackingField
- private bool <IsFreeFunction>k__BackingField
- private bool <IsThreadSafe>k__BackingField
- private string <Name>k__BackingField
- private bool <ThrowsException>k__BackingField
- private bool <WritableSelf>k__BackingField

#### Properties
- public bool HasExplicitThis { get; set; }
- public bool IsFreeFunction { get; set; }
- public bool IsThreadSafe { get; set; }
- public string Name { get; set; }
- public bool ThrowsException { get; set; }
- public bool WritableSelf { get; set; }

#### Constructors
- public NativeMethodAttribute()
- public NativeMethodAttribute(string name)
- public NativeMethodAttribute(string name, bool isFreeFunction)
- public NativeMethodAttribute(string name, bool isFreeFunction, bool isThreadSafe)
- public NativeMethodAttribute(string name, bool isFreeFunction, bool isThreadSafe, bool throws)

### internal class UnityEngine.Bindings.NativeNameAttribute
- Base: System.Attribute
- Interfaces: UnityEngine.Bindings.IBindingsNameProviderAttribute, UnityEngine.Bindings.IBindingsAttribute

#### Fields
- private string <Name>k__BackingField

#### Properties
- public string Name { get; set; }

#### Constructors
- public NativeNameAttribute()
- public NativeNameAttribute(string name)

### internal class UnityEngine.Bindings.NativePropertyAttribute
- Base: UnityEngine.Bindings.NativeMethodAttribute
- Interfaces: UnityEngine.Bindings.IBindingsNameProviderAttribute, UnityEngine.Bindings.IBindingsAttribute, UnityEngine.Bindings.IBindingsIsThreadSafeProviderAttribute, UnityEngine.Bindings.IBindingsIsFreeFunctionProviderAttribute, UnityEngine.Bindings.IBindingsThrowsProviderAttribute

#### Fields
- private UnityEngine.Bindings.TargetType <TargetType>k__BackingField

#### Properties
- public UnityEngine.Bindings.TargetType TargetType { get; set; }

#### Constructors
- public NativePropertyAttribute()
- public NativePropertyAttribute(string name)
- public NativePropertyAttribute(string name, UnityEngine.Bindings.TargetType targetType)
- public NativePropertyAttribute(string name, bool isFree, UnityEngine.Bindings.TargetType targetType)
- public NativePropertyAttribute(string name, bool isFree, UnityEngine.Bindings.TargetType targetType, bool isThreadSafe)

### internal class UnityEngine.Bindings.NativeThrowsAttribute
- Base: System.Attribute
- Interfaces: UnityEngine.Bindings.IBindingsThrowsProviderAttribute, UnityEngine.Bindings.IBindingsAttribute

#### Fields
- private bool <ThrowsException>k__BackingField

#### Properties
- public bool ThrowsException { get; set; }

#### Constructors
- public NativeThrowsAttribute()
- public NativeThrowsAttribute(bool throwsException)

### internal class UnityEngine.Bindings.NativeTypeAttribute
- Base: System.Attribute
- Interfaces: UnityEngine.Bindings.IBindingsHeaderProviderAttribute, UnityEngine.Bindings.IBindingsAttribute, UnityEngine.Bindings.IBindingsGenerateMarshallingTypeAttribute

#### Fields
- private UnityEngine.Bindings.CodegenOptions <CodegenOptions>k__BackingField
- private string <Header>k__BackingField
- private string <IntermediateScriptingStructName>k__BackingField

#### Properties
- public UnityEngine.Bindings.CodegenOptions CodegenOptions { get; set; }
- public string Header { get; set; }
- public string IntermediateScriptingStructName { get; set; }

#### Constructors
- public NativeTypeAttribute()
- public NativeTypeAttribute(UnityEngine.Bindings.CodegenOptions codegenOptions)
- public NativeTypeAttribute(string header)
- public NativeTypeAttribute(string header, UnityEngine.Bindings.CodegenOptions codegenOptions)
- public NativeTypeAttribute(UnityEngine.Bindings.CodegenOptions codegenOptions, string intermediateStructName)

### internal class UnityEngine.Bindings.NativeWritableSelfAttribute
- Base: System.Attribute
- Interfaces: UnityEngine.Bindings.IBindingsWritableSelfProviderAttribute, UnityEngine.Bindings.IBindingsAttribute

#### Fields
- private bool <WritableSelf>k__BackingField

#### Properties
- public bool WritableSelf { get; set; }

#### Constructors
- public NativeWritableSelfAttribute()
- public NativeWritableSelfAttribute(bool writable)

### internal class UnityEngine.Bindings.NotNullAttribute
- Base: System.Attribute
- Interfaces: UnityEngine.Bindings.IBindingsAttribute

#### Fields
- private string <Exception>k__BackingField

#### Properties
- public string Exception { get; set; }

#### Constructors
- public NotNullAttribute(string exception = "ArgumentNullException")

### internal class UnityEngine.Bindings.PreventExecutionInStateAttribute
- Base: System.Attribute
- Interfaces: UnityEngine.Bindings.IBindingsPreventExecution

#### Fields
- private string <howToFix>k__BackingField
- private UnityEngine.Bindings.PreventExecutionSeverity <severity>k__BackingField
- private object <singleFlagValue>k__BackingField

#### Properties
- public string howToFix { get; set; }
- public UnityEngine.Bindings.PreventExecutionSeverity severity { get; set; }
- public object singleFlagValue { get; set; }

#### Constructors
- public PreventExecutionInStateAttribute(object systemAndFlags, UnityEngine.Bindings.PreventExecutionSeverity reportSeverity, string howToString = "")

### internal enum UnityEngine.Bindings.PreventExecutionSeverity
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- PreventExecution_Error = 0
- PreventExecution_ManagedException = 1
- PreventExecution_Warning = 2

### internal class UnityEngine.Bindings.PreventReadOnlyInstanceModificationAttribute
- Base: System.Attribute

#### Constructors
- public PreventReadOnlyInstanceModificationAttribute()

### internal class UnityEngine.Bindings.SpanAttribute
- Base: System.Attribute
- Interfaces: UnityEngine.Bindings.IBindingsMarshalAsSpan

#### Fields
- private readonly bool <IsReadOnly>k__BackingField
- private readonly string <SizeParameter>k__BackingField

#### Properties
- public bool IsReadOnly { get; }
- public string SizeParameter { get; }

#### Constructors
- public SpanAttribute(string sizeParameter, bool isReadOnly = false)

### internal class UnityEngine.Bindings.StaticAccessorAttribute
- Base: System.Attribute
- Interfaces: UnityEngine.Bindings.IBindingsAttribute

#### Fields
- private string <Name>k__BackingField
- private UnityEngine.Bindings.StaticAccessorType <Type>k__BackingField

#### Properties
- public string Name { get; set; }
- public UnityEngine.Bindings.StaticAccessorType Type { get; set; }

#### Constructors
- public StaticAccessorAttribute()
- internal StaticAccessorAttribute(string name)
- public StaticAccessorAttribute(UnityEngine.Bindings.StaticAccessorType type)
- public StaticAccessorAttribute(string name, UnityEngine.Bindings.StaticAccessorType type)

### internal enum UnityEngine.Bindings.StaticAccessorType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Arrow = 1
- ArrowWithDefaultReturnIfNull = 3
- Dot = 0
- DoubleColon = 2

### internal enum UnityEngine.Bindings.TargetType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Field = 1
- Function = 0

### internal class UnityEngine.Bindings.ThreadSafeAttribute
- Base: UnityEngine.Bindings.NativeMethodAttribute
- Interfaces: UnityEngine.Bindings.IBindingsNameProviderAttribute, UnityEngine.Bindings.IBindingsAttribute, UnityEngine.Bindings.IBindingsIsThreadSafeProviderAttribute, UnityEngine.Bindings.IBindingsIsFreeFunctionProviderAttribute, UnityEngine.Bindings.IBindingsThrowsProviderAttribute

#### Constructors
- public ThreadSafeAttribute()

### internal class UnityEngine.Bindings.UnityTypeAttribute
- Base: System.Attribute
- Interfaces: UnityEngine.Bindings.IBindingsAttribute

#### Constructors
- public UnityTypeAttribute()

### internal class UnityEngine.Bindings.UnmarshalledAttribute
- Base: System.Attribute
- Interfaces: UnityEngine.Bindings.IBindingsAttribute

#### Constructors
- public UnmarshalledAttribute()

### internal class UnityEngine.Bindings.VisibleToOtherModulesAttribute
- Base: System.Attribute

#### Constructors
- public VisibleToOtherModulesAttribute()
- public VisibleToOtherModulesAttribute(params string[] modules)

## Namespace: UnityEngine.Scripting

### internal class UnityEngine.Scripting.RequiredByNativeCodeAttribute
- Base: System.Attribute

#### Fields
- private bool <GenerateProxy>k__BackingField
- private string <Name>k__BackingField
- private bool <Optional>k__BackingField

#### Properties
- public bool GenerateProxy { get; set; }
- public string Name { get; set; }
- public bool Optional { get; set; }

#### Constructors
- public RequiredByNativeCodeAttribute()
- public RequiredByNativeCodeAttribute(string name)
- public RequiredByNativeCodeAttribute(bool optional)
- public RequiredByNativeCodeAttribute(string name, bool optional)

### internal class UnityEngine.Scripting.UsedByNativeCodeAttribute
- Base: System.Attribute

#### Fields
- private string <Name>k__BackingField

#### Properties
- public string Name { get; set; }

#### Constructors
- public UsedByNativeCodeAttribute()
- public UsedByNativeCodeAttribute(string name)

