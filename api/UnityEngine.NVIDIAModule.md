# Assembly: UnityEngine.NVIDIAModule
- Path: tools/WorldBox.Managed/UnityEngine.NVIDIAModule.dll
- Types: 19

## Namespace: UnityEngine.NVIDIA

### public struct UnityEngine.NVIDIA.DLSSCommandExecutionData

#### Fields
- private uint m_FeatureSlot
- private uint m_InvertXAxis
- private uint m_InvertYAxis
- private float m_JitterOffsetX
- private float m_JitterOffsetY
- private float m_MVScaleX
- private float m_MVScaleY
- private float m_PreExposure
- private int m_Reset
- private float m_Sharpness
- private uint m_SubrectHeight
- private uint m_SubrectOffsetX
- private uint m_SubrectOffsetY
- private uint m_SubrectWidth

#### Properties
- internal uint featureSlot { get; set; }
- public uint invertXAxis { get; set; }
- public uint invertYAxis { get; set; }
- public float jitterOffsetX { get; set; }
- public float jitterOffsetY { get; set; }
- public float mvScaleX { get; set; }
- public float mvScaleY { get; set; }
- public float preExposure { get; set; }
- public int reset { get; set; }
- public float sharpness { get; set; }
- public uint subrectHeight { get; set; }
- public uint subrectOffsetX { get; set; }
- public uint subrectOffsetY { get; set; }
- public uint subrectWidth { get; set; }

### public struct UnityEngine.NVIDIA.DLSSCommandInitializationData

#### Fields
- private uint m_FeatureSlot
- private UnityEngine.NVIDIA.DLSSFeatureFlags m_Flags
- private uint m_InputRTHeight
- private uint m_InputRTWidth
- private uint m_OutputRTHeight
- private uint m_OutputRTWidth
- private UnityEngine.NVIDIA.DLSSQuality m_Quality

#### Properties
- public UnityEngine.NVIDIA.DLSSFeatureFlags featureFlags { get; set; }
- internal uint featureSlot { get; set; }
- public uint inputRTHeight { get; set; }
- public uint inputRTWidth { get; set; }
- public uint outputRTHeight { get; set; }
- public uint outputRTWidth { get; set; }
- public UnityEngine.NVIDIA.DLSSQuality quality { get; set; }

#### Methods
- public bool GetFlag(UnityEngine.NVIDIA.DLSSFeatureFlags flag)
- public void SetFlag(UnityEngine.NVIDIA.DLSSFeatureFlags flag, bool value)

### public class UnityEngine.NVIDIA.DLSSContext

#### Fields
- private UnityEngine.NVIDIA.NativeData<UnityEngine.NVIDIA.DLSSCommandExecutionData> m_ExecData
- private UnityEngine.NVIDIA.NativeData<UnityEngine.NVIDIA.DLSSCommandInitializationData> m_InitData

#### Properties
- public UnityEngine.NVIDIA.DLSSCommandExecutionData executeData { get; }
- internal uint featureSlot { get; }
- public UnityEngine.NVIDIA.DLSSCommandInitializationData initData { get; }

#### Constructors
- internal DLSSContext()

#### Methods
- internal System.IntPtr GetExecuteCmdPtr()
- internal System.IntPtr GetInitCmdPtr()
- internal void Init(UnityEngine.NVIDIA.DLSSCommandInitializationData initSettings, uint featureSlot)
- internal void Reset()

### public struct UnityEngine.NVIDIA.DLSSDebugFeatureInfos

#### Fields
- private readonly UnityEngine.NVIDIA.DLSSCommandExecutionData m_ExecData
- private readonly uint m_FeatureSlot
- private readonly UnityEngine.NVIDIA.DLSSCommandInitializationData m_InitData
- private readonly bool m_ValidFeature

#### Properties
- public UnityEngine.NVIDIA.DLSSCommandExecutionData execData { get; }
- public uint featureSlot { get; }
- public UnityEngine.NVIDIA.DLSSCommandInitializationData initData { get; }
- public bool validFeature { get; }

### public enum UnityEngine.NVIDIA.DLSSFeatureFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DepthInverted = 8
- DoSharpening = 16
- IsHDR = 1
- MVJittered = 4
- MVLowRes = 2
- None = 0

### public enum UnityEngine.NVIDIA.DLSSQuality
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Balanced = 1
- MaximumPerformance = 0
- MaximumQuality = 2
- UltraPerformance = 3

### public struct UnityEngine.NVIDIA.DLSSTextureTable

#### Fields
- private UnityEngine.Texture <biasColorMask>k__BackingField
- private UnityEngine.Texture <colorInput>k__BackingField
- private UnityEngine.Texture <colorOutput>k__BackingField
- private UnityEngine.Texture <depth>k__BackingField
- private UnityEngine.Texture <exposureTexture>k__BackingField
- private UnityEngine.Texture <motionVectors>k__BackingField
- private UnityEngine.Texture <transparencyMask>k__BackingField

#### Properties
- public UnityEngine.Texture biasColorMask { get; set; }
- public UnityEngine.Texture colorInput { get; set; }
- public UnityEngine.Texture colorOutput { get; set; }
- public UnityEngine.Texture depth { get; set; }
- public UnityEngine.Texture exposureTexture { get; set; }
- public UnityEngine.Texture motionVectors { get; set; }
- public UnityEngine.Texture transparencyMask { get; set; }

### public class UnityEngine.NVIDIA.GraphicsDevice

#### Fields
- private UnityEngine.NVIDIA.InitDeviceContext m_InitDeviceContext
- private static UnityEngine.NVIDIA.GraphicsDevice sGraphicsDeviceInstance
- private System.Collections.Generic.Stack<UnityEngine.NVIDIA.DLSSContext> s_ContextObjectPool
- private static string s_DefaultAppDir
- private static string s_DefaultProjectID

#### Properties
- public static UnityEngine.NVIDIA.GraphicsDevice device { get; }
- public static uint version { get; }

#### Constructors
- private static GraphicsDevice()
- private GraphicsDevice(string projectId, string engineVersion, string appDir)

#### Methods
- public UnityEngine.NVIDIA.GraphicsDeviceDebugView CreateDebugView()
- internal uint CreateDebugViewId()
- public UnityEngine.NVIDIA.DLSSContext CreateFeature(UnityEngine.Rendering.CommandBuffer cmd, in UnityEngine.NVIDIA.DLSSCommandInitializationData initSettings)
- public static UnityEngine.NVIDIA.GraphicsDevice CreateGraphicsDevice()
- public static UnityEngine.NVIDIA.GraphicsDevice CreateGraphicsDevice(string projectID)
- public static UnityEngine.NVIDIA.GraphicsDevice CreateGraphicsDevice(string projectID, string appDir)
- private static int CreateSetTextureUserData(int featureId, int textureSlot, bool clearTextureTable)
- public void DeleteDebugView(UnityEngine.NVIDIA.GraphicsDeviceDebugView debugView)
- internal void DeleteDebugViewId(uint debugViewId)
- public void DestroyFeature(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.NVIDIA.DLSSContext dlssContext)
- public void ExecuteDLSS(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.NVIDIA.DLSSContext dlssContext, in UnityEngine.NVIDIA.DLSSTextureTable textures)
- protected override void Finalize()
- internal UnityEngine.NVIDIA.GraphicsDeviceDebugInfo GetDebugInfo(uint debugViewId)
- public bool GetOptimalSettings(uint targetWidth, uint targetHeight, UnityEngine.NVIDIA.DLSSQuality quality, out UnityEngine.NVIDIA.OptimalDLSSSettingsData optimalSettings)
- private bool Initialize()
- private void InsertEventCall(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.NVIDIA.PluginEvent pluginEvent, System.IntPtr ptr)
- private static UnityEngine.NVIDIA.GraphicsDevice InternalCreate(string appIdOrProjectId, string engineVersion, string appDir)
- public bool IsFeatureAvailable(UnityEngine.NVIDIA.GraphicsDeviceFeature featureID)
- private static uint NVUP_CreateDebugView()
- private static uint NVUP_CreateFeatureSlot()
- private static void NVUP_DeleteDebugView(uint debugViewId)
- private static int NVUP_GetBaseEventId()
- private static uint NVUP_GetDeviceVersion()
- private static void NVUP_GetGraphicsDeviceDebugInfo(uint debugViewId, out UnityEngine.NVIDIA.GraphicsDeviceDebugInfo data)
- private static bool NVUP_GetOptimalSettings(uint inTargetWidth, uint inTargetHeight, UnityEngine.NVIDIA.DLSSQuality inPerfVQuality, out UnityEngine.NVIDIA.OptimalDLSSSettingsData data)
- private static System.IntPtr NVUP_GetRenderEventCallback()
- private static System.IntPtr NVUP_GetSetTextureEventCallback()
- private static bool NVUP_InitApi(System.IntPtr initData)
- private static bool NVUP_IsFeatureAvailable(UnityEngine.NVIDIA.GraphicsDeviceFeature featureID)
- private static void NVUP_ShutdownApi()
- private void SetTexture(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.NVIDIA.DLSSContext dlssContext, UnityEngine.NVIDIA.DLSSCommandExecutionData.Textures textureSlot, UnityEngine.Texture texture, bool clearTextureTable = false)
- private void Shutdown()
- public void UpdateDebugView(UnityEngine.NVIDIA.GraphicsDeviceDebugView debugView)

### internal struct UnityEngine.NVIDIA.GraphicsDeviceDebugInfo

#### Fields
- public UnityEngine.NVIDIA.DLSSDebugFeatureInfos* dlssInfos
- public uint dlssInfosCount
- public uint NGXVersion
- public uint NVDeviceVersion

### public class UnityEngine.NVIDIA.GraphicsDeviceDebugView

#### Fields
- internal uint m_DeviceVersion
- internal UnityEngine.NVIDIA.DLSSDebugFeatureInfos[] m_DlssDebugFeatures
- internal uint m_NgxVersion
- internal uint m_ViewId

#### Properties
- public uint deviceVersion { get; }
- public System.Collections.Generic.IEnumerable<UnityEngine.NVIDIA.DLSSDebugFeatureInfos> dlssFeatureInfos { get; }
- public uint ngxVersion { get; }

#### Constructors
- internal GraphicsDeviceDebugView(uint viewId)

### public enum UnityEngine.NVIDIA.GraphicsDeviceFeature
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DLSS = 0

### internal struct UnityEngine.NVIDIA.InitDeviceCmdData

#### Fields
- private System.IntPtr m_AppDir
- private System.IntPtr m_EngineVersion
- private System.IntPtr m_ProjectId

#### Properties
- public System.IntPtr appDir { get; set; }
- public System.IntPtr engineVersion { get; set; }
- public System.IntPtr projectId { get; set; }

### internal class UnityEngine.NVIDIA.InitDeviceContext

#### Fields
- private UnityEngine.NVIDIA.NativeStr m_AppDir
- private UnityEngine.NVIDIA.NativeStr m_EngineVersion
- private UnityEngine.NVIDIA.NativeData<UnityEngine.NVIDIA.InitDeviceCmdData> m_InitData
- private UnityEngine.NVIDIA.NativeStr m_ProjectId

#### Constructors
- public InitDeviceContext(string projectId, string engineVersion, string appDir)

#### Methods
- internal System.IntPtr GetInitCmdPtr()

### internal class UnityEngine.NVIDIA.NativeData<T>
- Interfaces: System.IDisposable

#### Fields
- private System.IntPtr m_MarshalledValue
- public T Value

#### Properties
- public System.IntPtr Ptr { get; }

#### Constructors
- public NativeData<T>()

#### Methods
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- protected override void Finalize()

### internal class UnityEngine.NVIDIA.NativeStr
- Interfaces: System.IDisposable

#### Fields
- private System.IntPtr m_MarshalledString
- private string m_Str

#### Properties
- public System.IntPtr Ptr { get; }
- public string Str { set; }

#### Constructors
- public NativeStr()

#### Methods
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- protected override void Finalize()

### public static class UnityEngine.NVIDIA.NVUnityPlugin

#### Methods
- public static bool IsLoaded()
- public static bool Load()

### public struct UnityEngine.NVIDIA.OptimalDLSSSettingsData

#### Fields
- private readonly uint m_MaxHeight
- private readonly uint m_MaxWidth
- private readonly uint m_MinHeight
- private readonly uint m_MinWidth
- private readonly uint m_OutRenderHeight
- private readonly uint m_OutRenderWidth
- private readonly float m_Sharpness

#### Properties
- public uint maxHeight { get; }
- public uint maxWidth { get; }
- public uint minHeight { get; }
- public uint minWidth { get; }
- public uint outRenderHeight { get; }
- public uint outRenderWidth { get; }
- public float sharpness { get; }

### internal enum UnityEngine.NVIDIA.PluginEvent
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DestroyFeature = 0
- DLSSExecute = 1
- DLSSInit = 2

### internal enum UnityEngine.NVIDIA.DLSSCommandExecutionData.Textures
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BiasColorMask = 6
- ColorInput = 0
- ColorOutput = 1
- Depth = 2
- ExposureTexture = 5
- MotionVectors = 3
- TransparencyMask = 4

