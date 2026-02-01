# Assembly: Beebyte.Obfuscator
- Path: tools/WorldBox.Managed/Beebyte.Obfuscator.dll
- Types: 13

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=447 322939EC70D71C7642652CB4415A047420E11659F2ECF07A5581788271ED997C
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=311 9034EAFF8CE1CD15B52B0DB7B481167E20215736A2806F40A69413F8349338EF

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=311

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=447

## Namespace: Beebyte.Obfuscator

### public class Beebyte.Obfuscator.DoNotFakeAttribute
- Base: System.Attribute

#### Constructors
- public DoNotFakeAttribute()

### public enum Beebyte.Obfuscator.MessageCode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- UnityReflectionMethodNotFound = 0

### public class Beebyte.Obfuscator.ObfuscateLiteralsAttribute
- Base: System.Attribute

#### Constructors
- public ObfuscateLiteralsAttribute()

### public class Beebyte.Obfuscator.RenameAttribute
- Base: System.Attribute

#### Fields
- private readonly string target

#### Constructors
- private RenameAttribute()
- public RenameAttribute(string target)

#### Methods
- public string GetTarget()

### public class Beebyte.Obfuscator.ReplaceLiteralsWithNameAttribute
- Base: System.Attribute

#### Constructors
- public ReplaceLiteralsWithNameAttribute()

### public class Beebyte.Obfuscator.SkipAttribute
- Base: System.Attribute

#### Constructors
- public SkipAttribute()

### public class Beebyte.Obfuscator.SkipRenameAttribute
- Base: System.Attribute

#### Constructors
- public SkipRenameAttribute()

### public class Beebyte.Obfuscator.SuppressLogAttribute
- Base: System.Attribute

#### Fields
- private readonly Beebyte.Obfuscator.MessageCode _messageCode

#### Constructors
- private SuppressLogAttribute()
- public SuppressLogAttribute(Beebyte.Obfuscator.MessageCode messageCode)

