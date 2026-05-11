# Assembly: Newtonsoft.Json.UnityConverters
- Path: tools/WorldBox.Managed/Newtonsoft.Json.UnityConverters.dll
- Types: 14

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=528 5B94CC430EA36DAD45F3C7B4A3E96BE98875ADB1C724C3627A1C74B043442EA2
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=582 F962F2F58242D3A115F0144683257FB763E441F5D75EA0B4A1CDC33D170FD2FB

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=528

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=582

## Namespace: Newtonsoft.Json.UnityConverters

### public class Newtonsoft.Json.UnityConverters.PartialConverter<T>
- Base: Newtonsoft.Json.JsonConverter

#### Properties
- public bool CanRead { get; }
- public bool CanWrite { get; }

#### Constructors
- protected PartialConverter<T>()

#### Methods
- public override bool CanConvert(System.Type objectType)
- public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
- protected abstract void ReadValue(ref T value, string name, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.JsonSerializer serializer)
- public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
- protected abstract void WriteJsonProperties(Newtonsoft.Json.JsonWriter writer, T value, Newtonsoft.Json.JsonSerializer serializer)

## Namespace: Newtonsoft.Json.UnityConverters.Helpers

### internal static class Newtonsoft.Json.UnityConverters.Helpers.JsonHelperExtensions

#### Fields
- internal static readonly System.Reflection.ConstructorInfo _JsonSerializationExceptionPositionalCtor

#### Constructors
- private static JsonHelperExtensions()

#### Methods
- public static Newtonsoft.Json.JsonSerializationException CreateSerializationException(Newtonsoft.Json.JsonReader reader, string message, System.Exception innerException = null)
- private static System.Text.StringBuilder CreateStringBuilderWithSpaceAfter(string message)
- public static Newtonsoft.Json.JsonWriterException CreateWriterException(Newtonsoft.Json.JsonWriter writer, string message, System.Exception innerException = null)
- private static Newtonsoft.Json.JsonSerializationException NewJsonSerializationException(string message, string path, int lineNumber, int linePosition, System.Exception innerException)
- public static System.Nullable<float> ReadAsFloat(Newtonsoft.Json.JsonReader reader)
- public static System.Nullable<byte> ReadAsInt8(Newtonsoft.Json.JsonReader reader)
- public static T ReadViaSerializer<T>(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.JsonSerializer serializer)

## Namespace: Newtonsoft.Json.UnityConverters.Math

### public class Newtonsoft.Json.UnityConverters.Math.Color32Converter
- Base: Newtonsoft.Json.UnityConverters.PartialConverter<UnityEngine.Color32>

#### Constructors
- public Color32Converter()

#### Methods
- protected override void ReadValue(ref UnityEngine.Color32 value, string name, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.JsonSerializer serializer)
- protected override void WriteJsonProperties(Newtonsoft.Json.JsonWriter writer, UnityEngine.Color32 value, Newtonsoft.Json.JsonSerializer serializer)

### public class Newtonsoft.Json.UnityConverters.Math.ColorConverter
- Base: Newtonsoft.Json.UnityConverters.PartialConverter<UnityEngine.Color>

#### Constructors
- public ColorConverter()

#### Methods
- protected override void ReadValue(ref UnityEngine.Color value, string name, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.JsonSerializer serializer)
- protected override void WriteJsonProperties(Newtonsoft.Json.JsonWriter writer, UnityEngine.Color value, Newtonsoft.Json.JsonSerializer serializer)

### public class Newtonsoft.Json.UnityConverters.Math.Vector2Converter
- Base: Newtonsoft.Json.UnityConverters.PartialConverter<UnityEngine.Vector2>

#### Constructors
- public Vector2Converter()

#### Methods
- protected override void ReadValue(ref UnityEngine.Vector2 value, string name, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.JsonSerializer serializer)
- protected override void WriteJsonProperties(Newtonsoft.Json.JsonWriter writer, UnityEngine.Vector2 value, Newtonsoft.Json.JsonSerializer serializer)

### public class Newtonsoft.Json.UnityConverters.Math.Vector2IntConverter
- Base: Newtonsoft.Json.UnityConverters.PartialConverter<UnityEngine.Vector2Int>

#### Constructors
- public Vector2IntConverter()

#### Methods
- protected override void ReadValue(ref UnityEngine.Vector2Int value, string name, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.JsonSerializer serializer)
- protected override void WriteJsonProperties(Newtonsoft.Json.JsonWriter writer, UnityEngine.Vector2Int value, Newtonsoft.Json.JsonSerializer serializer)

### public class Newtonsoft.Json.UnityConverters.Math.Vector3Converter
- Base: Newtonsoft.Json.UnityConverters.PartialConverter<UnityEngine.Vector3>

#### Constructors
- public Vector3Converter()

#### Methods
- protected override void ReadValue(ref UnityEngine.Vector3 value, string name, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.JsonSerializer serializer)
- protected override void WriteJsonProperties(Newtonsoft.Json.JsonWriter writer, UnityEngine.Vector3 value, Newtonsoft.Json.JsonSerializer serializer)

### public class Newtonsoft.Json.UnityConverters.Math.Vector3IntConverter
- Base: Newtonsoft.Json.UnityConverters.PartialConverter<UnityEngine.Vector3Int>

#### Constructors
- public Vector3IntConverter()

#### Methods
- protected override void ReadValue(ref UnityEngine.Vector3Int value, string name, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.JsonSerializer serializer)
- protected override void WriteJsonProperties(Newtonsoft.Json.JsonWriter writer, UnityEngine.Vector3Int value, Newtonsoft.Json.JsonSerializer serializer)

### public class Newtonsoft.Json.UnityConverters.Math.Vector4Converter
- Base: Newtonsoft.Json.UnityConverters.PartialConverter<UnityEngine.Vector4>

#### Constructors
- public Vector4Converter()

#### Methods
- protected override void ReadValue(ref UnityEngine.Vector4 value, string name, Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.JsonSerializer serializer)
- protected override void WriteJsonProperties(Newtonsoft.Json.JsonWriter writer, UnityEngine.Vector4 value, Newtonsoft.Json.JsonSerializer serializer)

