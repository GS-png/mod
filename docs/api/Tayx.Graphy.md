# Assembly: Tayx.Graphy
- Path: tools/WorldBox.Managed/Tayx.Graphy.dll
- Types: 51

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1157 0392D69976B83616DEBB1254870C5CEBA0A771145C51FB9DB6E26F6C1C4DADD9
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2587 2CC4E48FE4C8F7E51A4DE73D7E05A980D3059241B53122025EEB8DFFAA4E133C
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 69E57350522E4ECC12B50316F80F71B81FE20C753CD48D5613BE2386EB0AE164

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1157

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2587

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28

## Namespace: Tayx.Graphy

### private class Tayx.Graphy.GraphyDebugger.<>c

#### Fields
- public static readonly Tayx.Graphy.GraphyDebugger.<>c <>9
- public static System.Predicate<Tayx.Graphy.GraphyDebugger.DebugPacket> <>9__24_0

#### Constructors
- private static GraphyDebugger.<>c()
- public GraphyDebugger.<>c()

#### Methods
- internal bool <CheckDebugPackets>b__24_0(Tayx.Graphy.GraphyDebugger.DebugPacket packet)

### private class Tayx.Graphy.GraphyDebugger.<>c__DisplayClass18_0

#### Fields
- public int packetId

#### Constructors
- public GraphyDebugger.<>c__DisplayClass18_0()

#### Methods
- internal bool <GetFirstDebugPacketWithId>b__0(Tayx.Graphy.GraphyDebugger.DebugPacket x)

### private class Tayx.Graphy.GraphyDebugger.<>c__DisplayClass19_0

#### Fields
- public int packetId

#### Constructors
- public GraphyDebugger.<>c__DisplayClass19_0()

#### Methods
- internal bool <GetAllDebugPacketsWithId>b__0(Tayx.Graphy.GraphyDebugger.DebugPacket x)

### private class Tayx.Graphy.GraphyDebugger.<>c__DisplayClass21_0

#### Fields
- public int packetId

#### Constructors
- public GraphyDebugger.<>c__DisplayClass21_0()

#### Methods
- internal bool <RemoveAllDebugPacketsWithId>b__0(Tayx.Graphy.GraphyDebugger.DebugPacket x)

### public enum Tayx.Graphy.GraphyDebugger.ConditionEvaluation
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- All_conditions_must_be_met = 0
- Only_one_condition_has_to_be_met = 1

### public enum Tayx.Graphy.GraphyDebugger.DebugComparer
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Equals = 2
- Equals_or_greater_than = 3
- Equals_or_less_than = 1
- Greater_than = 4
- Less_than = 0

### public struct Tayx.Graphy.GraphyDebugger.DebugCondition

#### Fields
- public Tayx.Graphy.GraphyDebugger.DebugComparer Comparer
- public float Value
- public Tayx.Graphy.GraphyDebugger.DebugVariable Variable

### public class Tayx.Graphy.GraphyDebugger.DebugPacket

#### Fields
- public bool Active
- public System.Collections.Generic.List<System.Action> Callbacks
- private bool canBeChecked
- public Tayx.Graphy.GraphyDebugger.ConditionEvaluation ConditionEvaluation
- public bool DebugBreak
- public System.Collections.Generic.List<Tayx.Graphy.GraphyDebugger.DebugCondition> DebugConditions
- private bool executed
- public bool ExecuteOnce
- public float ExecuteSleepTime
- public int Id
- public float InitSleepTime
- public string Message
- public Tayx.Graphy.GraphyDebugger.MessageType MessageType
- public string ScreenshotFileName
- public bool TakeScreenshot
- private float timePassed
- public UnityEngine.Events.UnityEvent UnityEvents

#### Properties
- public bool Check { get; }

#### Constructors
- public GraphyDebugger.DebugPacket()

#### Methods
- public void Executed()
- public void Update()

### public enum Tayx.Graphy.GraphyDebugger.DebugVariable
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Audio_DB = 7
- Fps = 0
- Fps_Avg = 3
- Fps_Max = 2
- Fps_Min = 1
- Ram_Allocated = 4
- Ram_Mono = 6
- Ram_Reserved = 5

### public class Tayx.Graphy.GraphyDebugger
- Base: Tayx.Graphy.Utils.G_Singleton<Tayx.Graphy.GraphyDebugger>

#### Fields
- private Tayx.Graphy.Audio.G_AudioMonitor m_audioMonitor
- private System.Collections.Generic.List<Tayx.Graphy.GraphyDebugger.DebugPacket> m_debugPackets
- private Tayx.Graphy.Fps.G_FpsMonitor m_fpsMonitor
- private Tayx.Graphy.Ram.G_RamMonitor m_ramMonitor

#### Constructors
- protected GraphyDebugger()

#### Methods
- public void AddCallbackToAllDebugPacketWithId(System.Action callback, int id)
- public void AddCallbackToFirstDebugPacketWithId(System.Action callback, int id)
- public void AddNewDebugPacket(Tayx.Graphy.GraphyDebugger.DebugPacket newDebugPacket)
- public void AddNewDebugPacket(int newId, Tayx.Graphy.GraphyDebugger.DebugCondition newDebugCondition, Tayx.Graphy.GraphyDebugger.MessageType newMessageType, string newMessage, bool newDebugBreak, System.Action newCallback)
- public void AddNewDebugPacket(int newId, System.Collections.Generic.List<Tayx.Graphy.GraphyDebugger.DebugCondition> newDebugConditions, Tayx.Graphy.GraphyDebugger.MessageType newMessageType, string newMessage, bool newDebugBreak, System.Action newCallback)
- public void AddNewDebugPacket(int newId, Tayx.Graphy.GraphyDebugger.DebugCondition newDebugCondition, Tayx.Graphy.GraphyDebugger.MessageType newMessageType, string newMessage, bool newDebugBreak, System.Collections.Generic.List<System.Action> newCallbacks)
- public void AddNewDebugPacket(int newId, System.Collections.Generic.List<Tayx.Graphy.GraphyDebugger.DebugCondition> newDebugConditions, Tayx.Graphy.GraphyDebugger.MessageType newMessageType, string newMessage, bool newDebugBreak, System.Collections.Generic.List<System.Action> newCallbacks)
- private void CheckDebugPackets()
- private bool CheckIfConditionIsMet(Tayx.Graphy.GraphyDebugger.DebugCondition debugCondition)
- private void ExecuteOperationsInDebugPacket(Tayx.Graphy.GraphyDebugger.DebugPacket debugPacket)
- public System.Collections.Generic.List<Tayx.Graphy.GraphyDebugger.DebugPacket> GetAllDebugPacketsWithId(int packetId)
- public Tayx.Graphy.GraphyDebugger.DebugPacket GetFirstDebugPacketWithId(int packetId)
- private float GetRequestedValueFromDebugVariable(Tayx.Graphy.GraphyDebugger.DebugVariable debugVariable)
- public void RemoveAllDebugPacketsWithId(int packetId)
- public void RemoveFirstDebugPacketWithId(int packetId)
- private void Start()
- private void Update()

### public class Tayx.Graphy.GraphyManager
- Base: Tayx.Graphy.Utils.G_Singleton<Tayx.Graphy.GraphyManager>

#### Fields
- private bool m_active
- private Tayx.Graphy.Advanced.G_AdvancedData m_advancedData
- private Tayx.Graphy.GraphyManager.ModulePosition m_advancedModulePosition
- private Tayx.Graphy.GraphyManager.ModuleState m_advancedModuleState
- private UnityEngine.Color m_allocatedRamColor
- private UnityEngine.Color m_audioGraphColor
- private int m_audioGraphResolution
- private UnityEngine.AudioListener m_audioListener
- private Tayx.Graphy.Audio.G_AudioManager m_audioManager
- private Tayx.Graphy.GraphyManager.ModuleState m_audioModuleState
- private Tayx.Graphy.Audio.G_AudioMonitor m_audioMonitor
- private int m_audioTextUpdateRate
- private bool m_background
- private UnityEngine.Color m_backgroundColor
- private UnityEngine.Color m_cautionFpsColor
- private int m_cautionFpsThreshold
- private UnityEngine.Color m_criticalFpsColor
- private bool m_enableHotkeys
- private bool m_enableOnStartup
- private UnityEngine.FFTWindow m_FFTWindow
- private Tayx.Graphy.GraphyManager.LookForAudioListener m_findAudioListenerInCameraIfNull
- private bool m_focused
- private int m_fpsGraphResolution
- private Tayx.Graphy.Fps.G_FpsManager m_fpsManager
- private Tayx.Graphy.GraphyManager.ModuleState m_fpsModuleState
- private Tayx.Graphy.Fps.G_FpsMonitor m_fpsMonitor
- private int m_fpsTextUpdateRate
- private UnityEngine.Color m_goodFpsColor
- private int m_goodFpsThreshold
- private Tayx.Graphy.GraphyManager.ModulePosition m_graphModulePosition
- private Tayx.Graphy.GraphyManager.Mode m_graphyMode
- private bool m_initialized
- private bool m_keepAlive
- private Tayx.Graphy.GraphyManager.ModulePreset m_modulePresetState
- private UnityEngine.Color m_monoRamColor
- private int m_ramGraphResolution
- private Tayx.Graphy.Ram.G_RamManager m_ramManager
- private Tayx.Graphy.GraphyManager.ModuleState m_ramModuleState
- private Tayx.Graphy.Ram.G_RamMonitor m_ramMonitor
- private int m_ramTextUpdateRate
- private UnityEngine.Color m_reservedRamColor
- private int m_spectrumSize
- private int m_timeToResetMinMaxFps
- private bool m_toggleActiveAlt
- private bool m_toggleActiveCtrl
- private UnityEngine.KeyCode m_toggleActiveKeyCode
- private bool m_toggleModeAlt
- private bool m_toggleModeCtrl
- private UnityEngine.KeyCode m_toggleModeKeyCode

#### Properties
- public Tayx.Graphy.GraphyManager.ModulePosition AdvancedModulePosition { get; set; }
- public Tayx.Graphy.GraphyManager.ModuleState AdvancedModuleState { get; set; }
- public float AllocatedRam { get; }
- public UnityEngine.Color AllocatedRamColor { get; set; }
- public UnityEngine.Color AudioGraphColor { get; set; }
- public int AudioGraphResolution { get; set; }
- public UnityEngine.AudioListener AudioListener { get; set; }
- public Tayx.Graphy.GraphyManager.ModuleState AudioModuleState { get; set; }
- public int AudioTextUpdateRate { get; set; }
- public float AverageFPS { get; }
- public bool Background { get; set; }
- public UnityEngine.Color BackgroundColor { get; set; }
- public UnityEngine.Color CautionFPSColor { get; set; }
- public int CautionFPSThreshold { get; set; }
- public UnityEngine.Color CriticalFPSColor { get; set; }
- public float CurrentFPS { get; }
- public bool EnableOnStartup { get; }
- public UnityEngine.FFTWindow FftWindow { get; set; }
- public Tayx.Graphy.GraphyManager.LookForAudioListener FindAudioListenerInCameraIfNull { get; set; }
- public int FpsGraphResolution { get; set; }
- public Tayx.Graphy.GraphyManager.ModuleState FpsModuleState { get; set; }
- public int FpsTextUpdateRate { get; set; }
- public UnityEngine.Color GoodFPSColor { get; set; }
- public int GoodFPSThreshold { get; set; }
- public Tayx.Graphy.GraphyManager.ModulePosition GraphModulePosition { get; set; }
- public Tayx.Graphy.GraphyManager.Mode GraphyMode { get; set; }
- public bool KeepAlive { get; }
- public float MaxDB { get; }
- public float MaxFPS { get; }
- public float MinFPS { get; }
- public float MonoRam { get; }
- public UnityEngine.Color MonoRamColor { get; set; }
- public int RamGraphResolution { get; set; }
- public Tayx.Graphy.GraphyManager.ModuleState RamModuleState { get; set; }
- public int RamTextUpdateRate { get; set; }
- public float ReservedRam { get; }
- public UnityEngine.Color ReservedRamColor { get; set; }
- public float[] Spectrum { get; }
- public int SpectrumSize { get; set; }
- public int TimeToResetMinMaxFps { get; set; }

#### Constructors
- protected GraphyManager()

#### Methods
- private bool CheckFor1KeyPress(UnityEngine.KeyCode key)
- private bool CheckFor2KeyPress(UnityEngine.KeyCode key1, UnityEngine.KeyCode key2)
- private bool CheckFor3KeyPress(UnityEngine.KeyCode key1, UnityEngine.KeyCode key2, UnityEngine.KeyCode key3)
- private void CheckForHotkeyPresses()
- public void Disable()
- public void Enable()
- private void Init()
- private void OnApplicationFocus(bool isFocused)
- private void RefreshAllParameters()
- public void SetModuleMode(Tayx.Graphy.GraphyManager.ModuleType moduleType, Tayx.Graphy.GraphyManager.ModuleState moduleState)
- public void SetModulePosition(Tayx.Graphy.GraphyManager.ModuleType moduleType, Tayx.Graphy.GraphyManager.ModulePosition modulePosition)
- public void SetPreset(Tayx.Graphy.GraphyManager.ModulePreset modulePreset)
- private void Start()
- public void ToggleActive()
- public void ToggleModes()
- private void Update()
- private void UpdateAllParameters()

### public class Tayx.Graphy.G_GraphShader

#### Fields
- public float[] Array
- public int ArrayMaxSize
- public static const int ArrayMaxSizeFull
- public static const int ArrayMaxSizeLight
- public float Average
- private int averagePropertyId
- public UnityEngine.Color CautionColor
- private int cautionColorPropertyId
- public float CautionThreshold
- private int cautionThresholdPropertyId
- public UnityEngine.Color CriticalColor
- private int criticalColorPropertyId
- public UnityEngine.Color GoodColor
- private int goodColorPropertyId
- public float GoodThreshold
- private int goodThresholdPropertyId
- public UnityEngine.UI.Image Image
- private string Name
- private string Name_Length

#### Constructors
- public G_GraphShader()

#### Methods
- public void InitializeShader()
- public void UpdateArray()
- public void UpdateAverage()
- public void UpdateColors()
- public void UpdatePoints()
- public void UpdateThresholds()

### public enum Tayx.Graphy.GraphyManager.LookForAudioListener
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ALWAYS = 0
- NEVER = 2
- ON_SCENE_LOAD = 1

### public enum Tayx.Graphy.GraphyDebugger.MessageType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Error = 2
- Log = 0
- Warning = 1

### public enum Tayx.Graphy.GraphyManager.Mode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FULL = 0
- LIGHT = 1

### public enum Tayx.Graphy.GraphyManager.ModulePosition
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BOTTOM_LEFT = 3
- BOTTOM_RIGHT = 2
- FREE = 4
- TOP_LEFT = 1
- TOP_RIGHT = 0

### public enum Tayx.Graphy.GraphyManager.ModulePreset
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FPS_BASIC = 0
- FPS_BASIC_ADVANCED_FULL = 11
- FPS_FULL = 2
- FPS_FULL_RAM_FULL = 5
- FPS_FULL_RAM_FULL_AUDIO_FULL = 9
- FPS_FULL_RAM_FULL_AUDIO_FULL_ADVANCED_FULL = 10
- FPS_FULL_RAM_FULL_AUDIO_TEXT = 8
- FPS_FULL_RAM_TEXT = 4
- FPS_FULL_RAM_TEXT_AUDIO_TEXT = 7
- FPS_TEXT = 1
- FPS_TEXT_RAM_TEXT = 3
- FPS_TEXT_RAM_TEXT_AUDIO_TEXT = 6

### public enum Tayx.Graphy.GraphyManager.ModuleState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BACKGROUND = 3
- BASIC = 2
- FULL = 0
- OFF = 4
- TEXT = 1

### public enum Tayx.Graphy.GraphyManager.ModuleType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ADVANCED = 3
- AUDIO = 2
- FPS = 0
- RAM = 1

## Namespace: Tayx.Graphy.Advanced

### public class Tayx.Graphy.Advanced.G_AdvancedData
- Base: UnityEngine.MonoBehaviour
- Interfaces: Tayx.Graphy.UI.IMovable, Tayx.Graphy.UI.IModifiableState

#### Fields
- private System.Collections.Generic.List<UnityEngine.UI.Image> m_backgroundImages
- private Tayx.Graphy.GraphyManager.ModuleState m_currentModuleState
- private float m_deltaTime
- private UnityEngine.UI.Text m_gameWindowResolutionText
- private UnityEngine.UI.Text m_graphicsDeviceNameText
- private UnityEngine.UI.Text m_graphicsDeviceVersionText
- private UnityEngine.UI.Text m_graphicsMemorySizeText
- private Tayx.Graphy.GraphyManager m_graphyManager
- private UnityEngine.UI.Text m_operatingSystemText
- private Tayx.Graphy.GraphyManager.ModuleState m_previousModuleState
- private UnityEngine.UI.Text m_processorTypeText
- private UnityEngine.RectTransform m_rectTransform
- private System.Text.StringBuilder m_sb
- private UnityEngine.UI.Text m_screenResolutionText
- private UnityEngine.UI.Text m_systemMemoryText
- private float m_updateRate
- private readonly string[] m_windowStrings

#### Constructors
- public G_AdvancedData()

#### Methods
- private void Init()
- private void OnEnable()
- public void RefreshParameters()
- public void RestorePreviousState()
- public void SetPosition(Tayx.Graphy.GraphyManager.ModulePosition newModulePosition)
- public void SetState(Tayx.Graphy.GraphyManager.ModuleState state, bool silentUpdate = false)
- private void Update()
- public void UpdateParameters()

## Namespace: Tayx.Graphy.Audio

### public class Tayx.Graphy.Audio.G_AudioGraph
- Base: Tayx.Graphy.Graph.G_Graph

#### Fields
- private Tayx.Graphy.Audio.G_AudioMonitor m_audioMonitor
- private float[] m_graphArray
- private float[] m_graphArrayHighestValue
- private Tayx.Graphy.GraphyManager m_graphyManager
- private UnityEngine.UI.Image m_imageGraph
- private UnityEngine.UI.Image m_imageGraphHighestValues
- private int m_resolution
- private Tayx.Graphy.G_GraphShader m_shaderGraph
- private Tayx.Graphy.G_GraphShader m_shaderGraphHighestValues
- private UnityEngine.Shader ShaderFull
- private UnityEngine.Shader ShaderLight

#### Constructors
- public G_AudioGraph()

#### Methods
- protected override void CreatePoints()
- private void Init()
- private void OnEnable()
- private void Update()
- protected override void UpdateGraph()
- public void UpdateParameters()

### public class Tayx.Graphy.Audio.G_AudioManager
- Base: UnityEngine.MonoBehaviour
- Interfaces: Tayx.Graphy.UI.IMovable, Tayx.Graphy.UI.IModifiableState

#### Fields
- private UnityEngine.UI.Text m_audioDbText
- private Tayx.Graphy.Audio.G_AudioGraph m_audioGraph
- private UnityEngine.GameObject m_audioGraphGameObject
- private Tayx.Graphy.Audio.G_AudioMonitor m_audioMonitor
- private Tayx.Graphy.Audio.G_AudioText m_audioText
- private System.Collections.Generic.List<UnityEngine.UI.Image> m_backgroundImages
- private System.Collections.Generic.List<UnityEngine.GameObject> m_childrenGameObjects
- private Tayx.Graphy.GraphyManager.ModuleState m_currentModuleState
- private Tayx.Graphy.GraphyManager m_graphyManager
- private Tayx.Graphy.GraphyManager.ModuleState m_previousModuleState
- private UnityEngine.RectTransform m_rectTransform

#### Constructors
- public G_AudioManager()

#### Methods
- private void Awake()
- private void Init()
- public void RefreshParameters()
- public void RestorePreviousState()
- private void SetGraphActive(bool active)
- public void SetPosition(Tayx.Graphy.GraphyManager.ModulePosition newModulePosition)
- public void SetState(Tayx.Graphy.GraphyManager.ModuleState state, bool silentUpdate = false)
- private void Start()
- public void UpdateParameters()

### public class Tayx.Graphy.Audio.G_AudioMonitor
- Base: UnityEngine.MonoBehaviour

#### Fields
- private UnityEngine.AudioListener m_audioListener
- private UnityEngine.FFTWindow m_FFTWindow
- private Tayx.Graphy.GraphyManager.LookForAudioListener m_findAudioListenerInCameraIfNull
- private Tayx.Graphy.GraphyManager m_graphyManager
- private float m_maxDB
- private static const float m_refValue
- private float[] m_spectrum
- private float[] m_spectrumHighestValues
- private int m_spectrumSize

#### Properties
- public float MaxDB { get; }
- public float[] Spectrum { get; }
- public bool SpectrumDataAvailable { get; }
- public float[] SpectrumHighestValues { get; }

#### Constructors
- public G_AudioMonitor()

#### Methods
- private void <Init>b__23_0(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode loadMode)
- private void Awake()
- public float dBNormalized(float db)
- private void FindAudioListener()
- private void Init()
- public float lin2dB(float linear)
- private void Update()
- public void UpdateParameters()

### public class Tayx.Graphy.Audio.G_AudioText
- Base: UnityEngine.MonoBehaviour

#### Fields
- private Tayx.Graphy.Audio.G_AudioMonitor m_audioMonitor
- private UnityEngine.UI.Text m_DBText
- private float m_deltaTimeOffset
- private Tayx.Graphy.GraphyManager m_graphyManager
- private int m_updateRate

#### Constructors
- public G_AudioText()

#### Methods
- private void Awake()
- private void Init()
- private void Update()
- public void UpdateParameters()

## Namespace: Tayx.Graphy.CustomizationScene

### private class Tayx.Graphy.CustomizationScene.G_CUIColorPicker.<>c__DisplayClass13_0

#### Fields
- public Tayx.Graphy.CustomizationScene.G_CUIColorPicker <>4__this
- public System.Action applyHue
- public System.Action applySaturationValue
- public System.Action dragH
- public System.Action dragSV
- public float Hue
- public UnityEngine.Color[] hueColors
- public UnityEngine.GameObject hueGO
- public UnityEngine.GameObject hueKnob
- public UnityEngine.Vector2 hueSz
- public System.Action idle
- public System.Action resetSatValTexture
- public UnityEngine.GameObject result
- public float Saturation
- public UnityEngine.Color[] satvalColors
- public UnityEngine.GameObject satvalGO
- public UnityEngine.GameObject satvalKnob
- public UnityEngine.Vector2 satvalSz
- public UnityEngine.Texture2D satvalTex
- public float Value

#### Constructors
- public G_CUIColorPicker.<>c__DisplayClass13_0()

#### Methods
- internal void <Setup>b__0()
- internal void <Setup>b__1()
- internal void <Setup>b__2()
- internal void <Setup>b__3()
- internal void <Setup>b__4()
- internal void <Setup>b__5()

### public class Tayx.Graphy.CustomizationScene.CustomizeGraphy
- Base: UnityEngine.MonoBehaviour

#### Fields
- private UnityEngine.UI.Dropdown m_advancedModulePositionDropdown
- private UnityEngine.UI.Toggle m_advancedModuleToggle
- private UnityEngine.UI.Button m_allocatedColorButton
- private UnityEngine.UI.Button m_audioGraphColorButton
- private UnityEngine.UI.Slider m_audioGraphResolutionSlider
- private UnityEngine.UI.Dropdown m_audioModuleStateDropdown
- private UnityEngine.UI.Slider m_audioTextUpdateRateSlider
- private UnityEngine.UI.Button m_backgroundColorButton
- private UnityEngine.UI.Toggle m_backgroundToggle
- private UnityEngine.UI.Button m_cautionColorButton
- private UnityEngine.UI.InputField m_cautionInputField
- private Tayx.Graphy.CustomizationScene.G_CUIColorPicker m_colorPicker
- private UnityEngine.UI.Button m_criticalColorButton
- private UnityEngine.UI.Dropdown m_findAudioListenerDropdown
- private UnityEngine.UI.Slider m_fpsGraphResolutionSlider
- private UnityEngine.UI.Dropdown m_fpsModuleStateDropdown
- private UnityEngine.UI.Slider m_fpsTextUpdateRateSlider
- private UnityEngine.UI.Dropdown m_fttWindowDropdown
- private UnityEngine.UI.Button m_goodColorButton
- private UnityEngine.UI.InputField m_goodInputField
- private UnityEngine.UI.Dropdown m_graphModulePositionDropdown
- private Tayx.Graphy.GraphyManager m_graphyManager
- private UnityEngine.UI.Dropdown m_graphyModeDropdown
- private UnityEngine.UI.Button m_monoColorButton
- private UnityEngine.AudioSource m_musicAudioSource
- private UnityEngine.UI.Button m_musicButton
- private UnityEngine.UI.Slider m_musicVolumeSlider
- private UnityEngine.UI.Slider m_ramGraphResolutionSlider
- private UnityEngine.UI.Dropdown m_ramModuleStateDropdown
- private UnityEngine.UI.Slider m_ramTextUpdateRateSlider
- private UnityEngine.UI.Button m_reservedColorButton
- private System.Collections.Generic.List<UnityEngine.AudioClip> m_sfxAudioClips
- private UnityEngine.AudioSource m_sfxAudioSource
- private UnityEngine.UI.Button m_sfxButton
- private UnityEngine.UI.Slider m_sfxVolumeSlider
- private UnityEngine.UI.Slider m_spectrumSizeSlider
- private UnityEngine.UI.Slider m_timeToResetMinMaxSlider

#### Constructors
- public CustomizeGraphy()

#### Methods
- private void <SetupCallbacks>b__38_0(bool value)
- private void <SetupCallbacks>b__38_1()
- private void <SetupCallbacks>b__38_10(float value)
- private void <SetupCallbacks>b__38_11(float value)
- private void <SetupCallbacks>b__38_12(float value)
- private void <SetupCallbacks>b__38_13(int value)
- private void <SetupCallbacks>b__38_14()
- private void <SetupCallbacks>b__38_15()
- private void <SetupCallbacks>b__38_16()
- private void <SetupCallbacks>b__38_17(float value)
- private void <SetupCallbacks>b__38_18(float value)
- private void <SetupCallbacks>b__38_19(int value)
- private void <SetupCallbacks>b__38_2(int value)
- private void <SetupCallbacks>b__38_20()
- private void <SetupCallbacks>b__38_21(int value)
- private void <SetupCallbacks>b__38_22(int value)
- private void <SetupCallbacks>b__38_23(float value)
- private void <SetupCallbacks>b__38_24(float value)
- private void <SetupCallbacks>b__38_25(float value)
- private void <SetupCallbacks>b__38_26(int value)
- private void <SetupCallbacks>b__38_27(bool value)
- private void <SetupCallbacks>b__38_28(float value)
- private void <SetupCallbacks>b__38_29(float value)
- private void <SetupCallbacks>b__38_3(int value)
- private void <SetupCallbacks>b__38_30(UnityEngine.Color color)
- private void <SetupCallbacks>b__38_31(UnityEngine.Color color)
- private void <SetupCallbacks>b__38_32(UnityEngine.Color color)
- private void <SetupCallbacks>b__38_33(UnityEngine.Color color)
- private void <SetupCallbacks>b__38_34(UnityEngine.Color color)
- private void <SetupCallbacks>b__38_35(UnityEngine.Color color)
- private void <SetupCallbacks>b__38_36(UnityEngine.Color color)
- private void <SetupCallbacks>b__38_37(UnityEngine.Color color)
- private void <SetupCallbacks>b__38_4(int value)
- private void <SetupCallbacks>b__38_5(string value)
- private void <SetupCallbacks>b__38_6(string value)
- private void <SetupCallbacks>b__38_7()
- private void <SetupCallbacks>b__38_8()
- private void <SetupCallbacks>b__38_9()
- private void OnEnable()
- private void PlayRandomSFX()
- private void SetupCallbacks()
- private void ToggleMusic()

### public class Tayx.Graphy.CustomizationScene.ForceSliderToMultipleOf3
- Base: UnityEngine.MonoBehaviour

#### Fields
- private UnityEngine.UI.Slider m_slider

#### Constructors
- public ForceSliderToMultipleOf3()

#### Methods
- private void Start()
- private void UpdateValue(float value)

### public class Tayx.Graphy.CustomizationScene.ForceSliderToPowerOf2
- Base: UnityEngine.MonoBehaviour

#### Fields
- private int[] m_powerOf2Values
- private UnityEngine.UI.Slider m_slider
- private UnityEngine.UI.Text m_text

#### Constructors
- public ForceSliderToPowerOf2()

#### Methods
- private void Start()
- private void UpdateValue(float value)

### public class Tayx.Graphy.CustomizationScene.G_CUIColorPicker
- Base: UnityEngine.MonoBehaviour

#### Fields
- private UnityEngine.UI.Slider alphaSlider
- private UnityEngine.UI.Image alphaSliderBGImage
- private UnityEngine.Color _color
- private System.Action<UnityEngine.Color> _onValueChange
- private System.Action _update

#### Properties
- public UnityEngine.Color Color { get; set; }

#### Constructors
- public G_CUIColorPicker()

#### Methods
- private void <Start>b__16_0(float value)
- private void Awake()
- private static bool GetLocalMouse(UnityEngine.GameObject go, out UnityEngine.Vector2 result)
- private static UnityEngine.Vector2 GetWidgetSize(UnityEngine.GameObject go)
- private UnityEngine.GameObject GO(string name)
- private static void RGBToHSV(UnityEngine.Color color, out float h, out float s, out float v)
- public void SetOnValueChangeCallback(System.Action<UnityEngine.Color> onValueChange)
- public void SetRandomColor()
- private void Setup(UnityEngine.Color inputColor)
- private void Start()
- private void Update()

### public class Tayx.Graphy.CustomizationScene.UpdateTextWithSliderValue
- Base: UnityEngine.MonoBehaviour

#### Fields
- private UnityEngine.UI.Slider m_slider
- private UnityEngine.UI.Text m_text

#### Constructors
- public UpdateTextWithSliderValue()

#### Methods
- private void Start()
- private void UpdateText(float value)

## Namespace: Tayx.Graphy.Fps

### public class Tayx.Graphy.Fps.G_FpsGraph
- Base: Tayx.Graphy.Graph.G_Graph

#### Fields
- private int[] m_fpsArray
- private Tayx.Graphy.Fps.G_FpsMonitor m_fpsMonitor
- private Tayx.Graphy.GraphyManager m_graphyManager
- private int m_highestFps
- private UnityEngine.UI.Image m_imageGraph
- private int m_resolution
- private Tayx.Graphy.G_GraphShader m_shaderGraph
- private UnityEngine.Shader ShaderFull
- private UnityEngine.Shader ShaderLight

#### Constructors
- public G_FpsGraph()

#### Methods
- protected override void CreatePoints()
- private void Init()
- private void OnEnable()
- private void Update()
- protected override void UpdateGraph()
- public void UpdateParameters()

### public class Tayx.Graphy.Fps.G_FpsManager
- Base: UnityEngine.MonoBehaviour
- Interfaces: Tayx.Graphy.UI.IMovable, Tayx.Graphy.UI.IModifiableState

#### Fields
- private System.Collections.Generic.List<UnityEngine.UI.Image> m_backgroundImages
- private System.Collections.Generic.List<UnityEngine.GameObject> m_childrenGameObjects
- private Tayx.Graphy.GraphyManager.ModuleState m_currentModuleState
- private Tayx.Graphy.Fps.G_FpsGraph m_fpsGraph
- private UnityEngine.GameObject m_fpsGraphGameObject
- private Tayx.Graphy.Fps.G_FpsMonitor m_fpsMonitor
- private Tayx.Graphy.Fps.G_FpsText m_fpsText
- private Tayx.Graphy.GraphyManager m_graphyManager
- private System.Collections.Generic.List<UnityEngine.GameObject> m_nonBasicTextGameObjects
- private Tayx.Graphy.GraphyManager.ModuleState m_previousModuleState
- private UnityEngine.RectTransform m_rectTransform

#### Constructors
- public G_FpsManager()

#### Methods
- private void Awake()
- private void Init()
- public void RefreshParameters()
- public void RestorePreviousState()
- private void SetGraphActive(bool active)
- public void SetPosition(Tayx.Graphy.GraphyManager.ModulePosition newModulePosition)
- public void SetState(Tayx.Graphy.GraphyManager.ModuleState state, bool silentUpdate = false)
- private void Start()
- public void UpdateParameters()

### public class Tayx.Graphy.Fps.G_FpsMonitor
- Base: UnityEngine.MonoBehaviour

#### Fields
- private System.Collections.Generic.List<float> m_averageFpsSamples
- private int m_averageSamples
- private float m_avgFps
- private float m_currentFps
- private Tayx.Graphy.GraphyManager m_graphyManager
- private float m_maxFps
- private float m_minFps
- private float m_timeToResetMaxFpsPassed
- private float m_timeToResetMinFpsPassed
- private int m_timeToResetMinMaxFps
- private float unscaledDeltaTime

#### Properties
- public float AverageFPS { get; }
- public float CurrentFPS { get; }
- public float MaxFPS { get; }
- public float MinFPS { get; }

#### Constructors
- public G_FpsMonitor()

#### Methods
- private void Awake()
- private void Init()
- private void Update()
- public void UpdateParameters()

### public class Tayx.Graphy.Fps.G_FpsText
- Base: UnityEngine.MonoBehaviour

#### Fields
- private UnityEngine.UI.Text m_avgFpsText
- private float m_deltaTime
- private float m_fps
- private Tayx.Graphy.Fps.G_FpsMonitor m_fpsMonitor
- private UnityEngine.UI.Text m_fpsText
- private int m_frameCount
- private Tayx.Graphy.GraphyManager m_graphyManager
- private static const int m_maxFps
- private UnityEngine.UI.Text m_maxFpsText
- private static const int m_minFps
- private UnityEngine.UI.Text m_minFpsText
- private static const string m_msStringFormat
- private UnityEngine.UI.Text m_msText
- private int m_updateRate

#### Constructors
- public G_FpsText()

#### Methods
- private void Awake()
- private void Init()
- private void SetFpsRelatedTextColor(UnityEngine.UI.Text text, float fps)
- private void Update()
- public void UpdateParameters()

## Namespace: Tayx.Graphy.Graph

### public class Tayx.Graphy.Graph.G_Graph
- Base: UnityEngine.MonoBehaviour

#### Constructors
- protected G_Graph()

#### Methods
- protected abstract void CreatePoints()
- protected abstract void UpdateGraph()

## Namespace: Tayx.Graphy.Ram

### public class Tayx.Graphy.Ram.G_RamGraph
- Base: Tayx.Graphy.Graph.G_Graph

#### Fields
- private float[] m_allocatedArray
- private Tayx.Graphy.GraphyManager m_graphyManager
- private float m_highestMemory
- private UnityEngine.UI.Image m_imageAllocated
- private UnityEngine.UI.Image m_imageMono
- private UnityEngine.UI.Image m_imageReserved
- private float[] m_monoArray
- private Tayx.Graphy.Ram.G_RamMonitor m_ramMonitor
- private float[] m_reservedArray
- private int m_resolution
- private Tayx.Graphy.G_GraphShader m_shaderGraphAllocated
- private Tayx.Graphy.G_GraphShader m_shaderGraphMono
- private Tayx.Graphy.G_GraphShader m_shaderGraphReserved
- private UnityEngine.Shader ShaderFull
- private UnityEngine.Shader ShaderLight

#### Constructors
- public G_RamGraph()

#### Methods
- protected override void CreatePoints()
- private void Init()
- private void OnEnable()
- private void Update()
- protected override void UpdateGraph()
- public void UpdateParameters()

### public class Tayx.Graphy.Ram.G_RamManager
- Base: UnityEngine.MonoBehaviour
- Interfaces: Tayx.Graphy.UI.IMovable, Tayx.Graphy.UI.IModifiableState

#### Fields
- private System.Collections.Generic.List<UnityEngine.UI.Image> m_backgroundImages
- private System.Collections.Generic.List<UnityEngine.GameObject> m_childrenGameObjects
- private Tayx.Graphy.GraphyManager.ModuleState m_currentModuleState
- private Tayx.Graphy.GraphyManager m_graphyManager
- private Tayx.Graphy.GraphyManager.ModuleState m_previousModuleState
- private Tayx.Graphy.Ram.G_RamGraph m_ramGraph
- private UnityEngine.GameObject m_ramGraphGameObject
- private Tayx.Graphy.Ram.G_RamText m_ramText
- private UnityEngine.RectTransform m_rectTransform

#### Constructors
- public G_RamManager()

#### Methods
- private void Awake()
- private void Init()
- public void RefreshParameters()
- public void RestorePreviousState()
- private void SetGraphActive(bool active)
- public void SetPosition(Tayx.Graphy.GraphyManager.ModulePosition newModulePosition)
- public void SetState(Tayx.Graphy.GraphyManager.ModuleState state, bool silentUpdate = false)
- private void Start()
- public void UpdateParameters()

### public class Tayx.Graphy.Ram.G_RamMonitor
- Base: UnityEngine.MonoBehaviour

#### Fields
- private float m_allocatedRam
- private float m_monoRam
- private float m_reservedRam

#### Properties
- public float AllocatedRam { get; }
- public float MonoRam { get; }
- public float ReservedRam { get; }

#### Constructors
- public G_RamMonitor()

#### Methods
- private void Update()

### public class Tayx.Graphy.Ram.G_RamText
- Base: UnityEngine.MonoBehaviour

#### Fields
- private UnityEngine.UI.Text m_allocatedSystemMemorySizeText
- private float m_deltaTime
- private Tayx.Graphy.GraphyManager m_graphyManager
- private readonly string m_memoryStringFormat
- private UnityEngine.UI.Text m_monoSystemMemorySizeText
- private Tayx.Graphy.Ram.G_RamMonitor m_ramMonitor
- private UnityEngine.UI.Text m_reservedSystemMemorySizeText
- private float m_updateRate

#### Constructors
- public G_RamText()

#### Methods
- private void Awake()
- private void Init()
- private void Update()
- public void UpdateParameters()

## Namespace: Tayx.Graphy.UI

### public interface Tayx.Graphy.UI.IModifiableState

#### Methods
- public void SetState(Tayx.Graphy.GraphyManager.ModuleState newState, bool silentUpdate)

### public interface Tayx.Graphy.UI.IMovable

#### Methods
- public void SetPosition(Tayx.Graphy.GraphyManager.ModulePosition newModulePosition)

## Namespace: Tayx.Graphy.Utils

### public static class Tayx.Graphy.Utils.G_ExtensionMethods

#### Methods
- public static System.Collections.Generic.List<UnityEngine.GameObject> SetAllActive(System.Collections.Generic.List<UnityEngine.GameObject> gameObjects, bool active)
- public static System.Collections.Generic.List<UnityEngine.UI.Image> SetAllActive(System.Collections.Generic.List<UnityEngine.UI.Image> images, bool active)
- public static System.Collections.Generic.List<UnityEngine.UI.Image> SetOneActive(System.Collections.Generic.List<UnityEngine.UI.Image> images, int active)

### public class Tayx.Graphy.Utils.G_Singleton<T>
- Base: UnityEngine.MonoBehaviour

#### Fields
- private static bool _applicationIsQuitting
- private static T _instance
- private static object _lock

#### Properties
- public static T Instance { get; }

#### Constructors
- public G_Singleton<T>()
- private static G_Singleton<T>()

#### Methods
- private void Awake()
- private void OnDestroy()

## Namespace: Tayx.Graphy.Utils.NumString

### public static class Tayx.Graphy.Utils.NumString.G_FloatString

#### Fields
- private static float decimalMultiplier
- private static const string floatFormat
- private static string[] negativeBuffer
- private static string[] positiveBuffer

#### Properties
- public static bool Inited { get; }
- public static float MaxValue { get; }
- public static float MinValue { get; }

#### Constructors
- private static G_FloatString()

#### Methods
- private static float FromIndex(int i)
- public static void Init(float minNegativeValue, float maxPositiveValue, int decimals = 1)
- private static int Pow(int f, int p)
- public static float ToFloat(int i)
- private static int ToIndex(float f)
- public static int ToInt(float f)
- public static string ToStringNonAlloc(float value)
- public static string ToStringNonAlloc(float value, string format)

### public static class Tayx.Graphy.Utils.NumString.G_IntString

#### Fields
- private static string[] negativeBuffer
- private static string[] positiveBuffer

#### Properties
- public static bool Inited { get; }
- public static int MaxValue { get; }
- public static int MinValue { get; }

#### Constructors
- private static G_IntString()

#### Methods
- public static void Init(int minNegativeValue, int maxPositiveValue)
- public static string ToStringNonAlloc(int value)

