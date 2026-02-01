# Assembly: UltimateJoystick
- Path: tools/WorldBox.Managed/UltimateJoystick.dll
- Types: 18

## Namespace: (global)

### private class UltimateJoystick.<FadeLogic>d__83
- Interfaces: System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- public UltimateJoystick <>4__this
- private float <currentFade>5__2
- private float <fadeIn>5__3

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public UltimateJoystick.<FadeLogic>d__83(int <>1__state)

#### Methods
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class UltimateJoystick.<GravityHandler>d__80
- Interfaces: System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- public UltimateJoystick <>4__this
- private float <speed>5__2
- private UnityEngine.Vector3 <startJoyPos>5__3
- private float <t>5__4

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public UltimateJoystick.<GravityHandler>d__80(int <>1__state)

#### Methods
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=155 0F0F0674FB8D4FF6F114E700BC29A0EEED59F6F80433BDB12E80D8C5A79101C2
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=61 868F6B78D2909E71D50C7E10DD3E4AC098573B6F5E14383EBB69A11EE8FF37E5

### private class UltimateJoystick.<TapCountDelay>d__85
- Interfaces: System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- public UltimateJoystick <>4__this

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public UltimateJoystick.<TapCountDelay>d__85(int <>1__state)

#### Methods
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class UltimateJoystick.<TapCountdown>d__84
- Interfaces: System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- public UltimateJoystick <>4__this

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public UltimateJoystick.<TapCountdown>d__84(int <>1__state)

#### Methods
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class UltimateJoystickScreenSizeUpdater.<YieldPositioning>d__1
- Interfaces: System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public UltimateJoystickScreenSizeUpdater.<YieldPositioning>d__1(int <>1__state)

#### Methods
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### public enum UltimateJoystick.Anchor
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Left = 0
- Right = 1

### public enum UltimateJoystick.Axis
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Both = 0
- X = 1
- Y = 2

### public enum UltimateJoystick.Boundary
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Circular = 0
- Square = 1

### public enum UltimateJoystick.JoystickTouchSize
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Custom = 3
- Default = 0
- Large = 2
- Medium = 1

### private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData

#### Fields
- public byte[] FilePathsData
- public bool IsEditorOnly
- public int TotalFiles
- public int TotalTypes
- public byte[] TypesData

### public enum UltimateJoystick.ScalingAxis
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Height = 1
- Width = 0

### public enum UltimateJoystick.TapCountOption
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Accumulate = 1
- NoCount = 0
- TouchRelease = 2

### public class UltimateJoystick
- Base: UnityEngine.MonoBehaviour
- Interfaces: UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IPointerUpHandler

#### Fields
- private float <HorizontalAxis>k__BackingField
- private float <VerticalAxis>k__BackingField
- public UltimateJoystick.Anchor anchor
- private int animationID
- public UltimateJoystick.Axis axis
- private UnityEngine.RectTransform baseTrans
- public UltimateJoystick.Boundary boundary
- private float currentTapTime
- public float customSpacing_X
- public float customSpacing_Y
- public float customTouchSizePos_X
- public float customTouchSizePos_Y
- public float customTouchSize_X
- public float customTouchSize_Y
- public float deadZone
- private UnityEngine.Vector2 defaultPos
- public bool disableVisuals
- public bool dynamicPositioning
- public bool extendRadius
- public float fadeInDuration
- private float fadeInSpeed
- public float fadeOutDuration
- private float fadeOutSpeed
- public float fadeTouched
- public float fadeUntouched
- public float gravity
- private bool gravityActive
- public UnityEngine.UI.Image highlightBase
- public UnityEngine.Color highlightColor
- public UnityEngine.UI.Image highlightJoystick
- public UnityEngine.RectTransform joystick
- public UnityEngine.Animator joystickAnimator
- public UnityEngine.RectTransform joystickBase
- private UnityEngine.Vector3 joystickCenter
- private UnityEngine.CanvasGroup joystickGroup
- public string joystickName
- public float joystickSize
- public UnityEngine.RectTransform joystickSizeFolder
- private bool joystickState
- public UltimateJoystick.JoystickTouchSize joystickTouchSize
- public static const float JOYSTICK_SIZE_LANDSCAPE
- public static const float JOYSTICK_SIZE_PORTRAIT
- private float radius
- public float radiusModifier
- public UltimateJoystick.ScalingAxis scalingAxis
- public bool showHighlight
- public bool showTension
- private int tapCount
- private bool tapCountAchieved
- public float tapCountDuration
- public UltimateJoystick.TapCountOption tapCountOption
- public int targetTapCount
- public UnityEngine.UI.Image tensionAccentDown
- public UnityEngine.UI.Image tensionAccentLeft
- public UnityEngine.UI.Image tensionAccentRight
- public UnityEngine.UI.Image tensionAccentUp
- public UnityEngine.Color tensionColorFull
- public UnityEngine.Color tensionColorNone
- private UnityEngine.Vector2 textureCenter
- private static System.Collections.Generic.Dictionary<string, UltimateJoystick> UltimateJoysticks
- private bool updateHighlightPosition
- public bool useAnimation
- public bool useFade
- private int _pointerId

#### Properties
- public float HorizontalAxis { get; private set; }
- public float VerticalAxis { get; private set; }

#### Constructors
- public UltimateJoystick()
- private static UltimateJoystick()

#### Methods
- private void Awake()
- private void CheckJoystickHighlightForUse()
- private void checkSize()
- private UnityEngine.Vector2 ConfigureImagePosition(UnityEngine.Vector2 textureSize, UnityEngine.Vector2 customSpacing)
- public void DisableJoystick()
- public static void DisableJoystick(string joystickName)
- public void EnableJoystick()
- public static void EnableJoystick(string joystickName)
- private System.Collections.IEnumerator FadeLogic()
- private UnityEngine.CanvasGroup GetCanvasGroup()
- public float GetDistance()
- public static float GetDistance(string joystickName)
- public float GetHorizontalAxis()
- public static float GetHorizontalAxis(string joystickName)
- public float GetHorizontalAxisRaw()
- public static float GetHorizontalAxisRaw(string joystickName)
- public static int getJoyCount()
- public bool GetJoystickState()
- public static bool GetJoystickState(string joystickName)
- private UnityEngine.Canvas GetParentCanvas()
- public bool GetTapCount()
- public static bool GetTapCount(string joystickName)
- public int getTouchId()
- public static UltimateJoystick GetUltimateJoystick(string joystickName)
- public float GetVerticalAxis()
- public static float GetVerticalAxis(string joystickName)
- public float GetVerticalAxisRaw()
- public static float GetVerticalAxisRaw(string joystickName)
- private System.Collections.IEnumerator GravityHandler()
- private static bool JoystickConfirmed(string joystickName)
- public void OnDrag(UnityEngine.EventSystems.PointerEventData touchInfo)
- private void OnEnable()
- public void OnPointerDown(UnityEngine.EventSystems.PointerEventData touchInfo)
- public void OnPointerUp(UnityEngine.EventSystems.PointerEventData touchInfo = null)
- public void ResetJoystick()
- public static void ResetJoysticks()
- private void Start()
- private System.Collections.IEnumerator TapCountDelay()
- private System.Collections.IEnumerator TapCountdown()
- private void TensionAccentDisplay()
- private void TensionAccentReset()
- public void UpdateHighlightColor(UnityEngine.Color targetColor)
- private void UpdateJoystick(UnityEngine.EventSystems.PointerEventData touchInfo)
- public void UpdatePositioning()
- private void UpdatePositionValues()
- private void UpdateSizeAndPlacement()
- public void UpdateSizeAndPlacement(UnityEngine.RectTransform pRect)
- public void UpdateTensionColors(UnityEngine.Color targetTensionNone, UnityEngine.Color targetTensionFull)

### public class UltimateJoystickScreenSizeUpdater
- Base: UnityEngine.EventSystems.UIBehaviour

#### Constructors
- public UltimateJoystickScreenSizeUpdater()

#### Methods
- protected override void OnRectTransformDimensionsChange()
- private System.Collections.IEnumerator YieldPositioning()

### internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1

#### Constructors
- public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()

#### Methods
- private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=155

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=61

