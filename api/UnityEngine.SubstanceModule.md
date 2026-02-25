# Assembly: UnityEngine.SubstanceModule
- Path: tools/WorldBox.Managed/UnityEngine.SubstanceModule.dll
- Types: 8

## Namespace: UnityEngine

### public enum UnityEngine.ProceduralCacheSize
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Heavy = 2
- Medium = 1
- NoLimit = 3
- None = 4
- Tiny = 0

### public enum UnityEngine.ProceduralLoadingBehavior
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BakeAndDiscard = 3
- BakeAndKeep = 2
- Cache = 4
- DoNothing = 0
- DoNothingAndCache = 5
- Generate = 1

### public class UnityEngine.ProceduralMaterial
- Base: UnityEngine.Material

#### Properties
- public int animationUpdateRate { get; set; }
- public UnityEngine.ProceduralCacheSize cacheSize { get; set; }
- public bool isCachedDataAvailable { get; }
- public bool isFrozen { get; }
- public bool isLoadTimeGenerated { get; set; }
- public bool isProcessing { get; }
- public bool isReadable { get; set; }
- public static bool isSupported { get; }
- public UnityEngine.ProceduralLoadingBehavior loadingBehavior { get; }
- public string preset { get; set; }
- public static UnityEngine.ProceduralProcessorUsage substanceProcessorUsage { get; set; }

#### Constructors
- internal ProceduralMaterial()

#### Methods
- public void CacheProceduralProperty(string inputName, bool value)
- public void ClearCache()
- private static void FeatureRemoved()
- public void FreezeAndReleaseSourceData()
- public UnityEngine.ProceduralTexture GetGeneratedTexture(string textureName)
- public UnityEngine.Texture[] GetGeneratedTextures()
- public bool GetProceduralBoolean(string inputName)
- public UnityEngine.Color GetProceduralColor(string inputName)
- public int GetProceduralEnum(string inputName)
- public float GetProceduralFloat(string inputName)
- public UnityEngine.ProceduralPropertyDescription[] GetProceduralPropertyDescriptions()
- public string GetProceduralString(string inputName)
- public UnityEngine.Texture2D GetProceduralTexture(string inputName)
- public UnityEngine.Vector4 GetProceduralVector(string inputName)
- public bool HasProceduralProperty(string inputName)
- public bool IsProceduralPropertyCached(string inputName)
- public bool IsProceduralPropertyVisible(string inputName)
- public void RebuildTextures()
- public void RebuildTexturesImmediately()
- public void SetProceduralBoolean(string inputName, bool value)
- public void SetProceduralColor(string inputName, UnityEngine.Color value)
- public void SetProceduralEnum(string inputName, int value)
- public void SetProceduralFloat(string inputName, float value)
- public void SetProceduralString(string inputName, string value)
- public void SetProceduralTexture(string inputName, UnityEngine.Texture2D value)
- public void SetProceduralVector(string inputName, UnityEngine.Vector4 value)
- public static void StopRebuilds()

### public enum UnityEngine.ProceduralOutputType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AmbientOcclusion = 8
- DetailMask = 9
- Diffuse = 1
- Emissive = 4
- Height = 3
- Metallic = 10
- Normal = 2
- Opacity = 6
- Roughness = 11
- Smoothness = 7
- Specular = 5
- Unknown = 0

### public enum UnityEngine.ProceduralProcessorUsage
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- All = 3
- Half = 2
- One = 1
- Unsupported = 0

### public class UnityEngine.ProceduralPropertyDescription

#### Fields
- public string[] componentLabels
- public string[] enumOptions
- public string group
- public bool hasRange
- public string label
- public float maximum
- public float minimum
- public string name
- public float step
- public UnityEngine.ProceduralPropertyType type

#### Constructors
- public ProceduralPropertyDescription()

### public enum UnityEngine.ProceduralPropertyType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Boolean = 0
- Color3 = 5
- Color4 = 6
- Enum = 7
- Float = 1
- String = 9
- Texture = 8
- Vector2 = 2
- Vector3 = 3
- Vector4 = 4

### public class UnityEngine.ProceduralTexture
- Base: UnityEngine.Texture

#### Properties
- public UnityEngine.TextureFormat format { get; }
- public bool hasAlpha { get; }

#### Constructors
- private ProceduralTexture()

#### Methods
- public UnityEngine.Color32[] GetPixels32(int x, int y, int blockWidth, int blockHeight)
- internal UnityEngine.ProceduralMaterial GetProceduralMaterial()
- public UnityEngine.ProceduralOutputType GetProceduralOutputType()

