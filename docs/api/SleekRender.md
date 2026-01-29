# Assembly: SleekRender
- Path: tools/WorldBox.Managed/SleekRender.dll
- Types: 14

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 0C6A9A02BE5F7EB53FB20C6B5B3C610B857B50E630614FEC5F4BFCD7FC6F1567
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=250 4F2A5972DDAC31430166C86AB53CC450C19B7E6D8A178804FA677D497C3BA10A
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=388 58CA097C9702B679E25DEE4DC23E98EA9C0EA41E763573E051CA61CA2E3D354D

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=250

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=388

## Namespace: SleekRender

### public class SleekRender.DualFilterBloomRenderer

#### Fields
- private int _baseTextureHeight
- private int _baseTextureWidth
- private int _bloomPasses
- private UnityEngine.RenderTexture[] _blurTextures
- private UnityEngine.Material _brightpassBlurMaterial
- private UnityEngine.Material _downsampleBlurMaterial
- private bool _preserveAspectRatio
- private SleekRender.PassRenderer _renderer

#### Constructors
- public DualFilterBloomRenderer(SleekRender.PassRenderer renderer)

#### Methods
- public UnityEngine.RenderTexture ApplyToAndReturn(UnityEngine.RenderTexture source, SleekRender.SleekRenderSettings settings)
- private void CalculateBloomHeightAndWidth(SleekRender.SleekRenderSettings settings, UnityEngine.Camera camera)
- public void CreateResources(SleekRender.SleekRenderSettings settings, UnityEngine.Camera camera)
- public void ReleaseResources()
- public bool SomeSettingsHaveChanged(SleekRender.SleekRenderSettings settings)

### public static class SleekRender.HelperExtensions

#### Methods
- public static UnityEngine.Material CreateMaterialFromShader(string shaderName)
- public static UnityEngine.RenderTexture CreateTransientRenderTexture(string textureName, int width, int height)
- public static void DestroyImmediateIfNotNull(UnityEngine.Object obj)
- public static UnityEngine.Vector4 GetLuminanceThreshold(SleekRender.SleekRenderSettings settings)

### private static class SleekRender.SleekRenderPostProcess.Keywords

#### Fields
- public static const string BLOOM_ON
- public static const string BRIGHTNESS_CONTRAST_ON
- public static const string COLORIZE_ON
- public static const string VIGNETTE_ON

### public enum SleekRender.LumaVectorType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Custom = 2
- sRGB = 1
- Uniform = 0

### public class SleekRender.PassRenderer

#### Fields
- private UnityEngine.Mesh _fullscreenQuadMesh

#### Constructors
- public PassRenderer()

#### Methods
- public void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture destination, UnityEngine.Material material, int materialPass = 0)
- private UnityEngine.Mesh CreateScreenSpaceQuadMesh()
- public void DrawFullscreenQuad(UnityEngine.Texture source, UnityEngine.Material material, int materialPass = 0)
- public void SetActiveRenderTextureAndClear(UnityEngine.RenderTexture destination)

### public class SleekRender.SleekRenderPostProcess
- Base: UnityEngine.MonoBehaviour

#### Fields
- public SleekRender.SleekRenderSettings settings
- private SleekRender.DualFilterBloomRenderer _bloomRenderer
- private UnityEngine.RenderTexture _bloomResultTexture
- private UnityEngine.Material _composeMaterial
- private int _currentCameraPixelHeight
- private int _currentCameraPixelWidth
- private bool _isBloomAlreadyEnabled
- private bool _isColorizeAlreadyEnabled
- private bool _isContrastAndBrightnessAlreadyEnabled
- private bool _isVignetteAlreadyEnabled
- private UnityEngine.Camera _mainCamera
- private SleekRender.PassRenderer _passRenderer
- private UnityEngine.Material _preComposeMaterial
- private UnityEngine.RenderTexture _preComposeTexture

#### Constructors
- public SleekRenderPostProcess()

#### Methods
- private void ApplyPostProcess(UnityEngine.RenderTexture source)
- private void Bloom(UnityEngine.RenderTexture source, bool isBloomEnabled)
- private void CheckSetupChangeAndRecreateResourcesIfNeeded(UnityEngine.Camera mainCamera)
- private void Compose(UnityEngine.RenderTexture source, UnityEngine.RenderTexture target)
- private void CreateDefaultSettingsIfNoneLinked()
- private UnityEngine.RenderTexture CreateMainRenderTexture(int width, int height)
- private void CreateResources()
- private float GetCurrentAspect(UnityEngine.Camera mainCamera)
- private void OnDisable()
- private void OnEnable()
- private void OnRenderImage(UnityEngine.RenderTexture source, UnityEngine.RenderTexture target)
- private void Precompose(UnityEngine.RenderTexture source, bool isBloomEnabled)
- private void ReleaseResources()

### public class SleekRender.SleekRenderSettings
- Base: UnityEngine.ScriptableObject

#### Fields
- public bool bloomEnabled
- public bool bloomExpanded
- public float bloomIntensity
- public SleekRender.LumaVectorType bloomLumaCalculationType
- public UnityEngine.Vector3 bloomLumaVector
- public int bloomPasses
- public int bloomTextureHeight
- public int bloomTextureWidth
- public float bloomThreshold
- public UnityEngine.Color bloomTint
- public float brightness
- public bool brightnessContrastEnabled
- public bool brightnessContrastExpanded
- public UnityEngine.Color32 colorize
- public bool colorizeEnabled
- public bool colorizeExpanded
- public float contrast
- public bool preserveAspectRatio
- public float vignetteBeginRadius
- public UnityEngine.Color vignetteColor
- public bool vignetteEnabled
- public bool vignetteExpanded
- public float vignetteExpandRadius

#### Constructors
- public SleekRenderSettings()

### public static class SleekRender.Uniforms

#### Fields
- public static readonly int _BloomIntencity
- public static readonly int _BloomTex
- public static readonly int _BloomTint
- public static readonly int _BrightnessContrast
- public static readonly int _Colorize
- public static readonly int _LuminanceConst
- public static readonly int _LuminanceThreshold
- public static readonly int _MainTex
- public static readonly int _PreComposeTex
- public static readonly int _TexelSize
- public static readonly int _VignetteColor
- public static readonly int _VignetteShape

#### Constructors
- private static Uniforms()

