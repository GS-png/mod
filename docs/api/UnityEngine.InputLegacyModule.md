# Assembly: UnityEngine.InputLegacyModule
- Path: tools/WorldBox.Managed/UnityEngine.InputLegacyModule.dll
- Types: 21

## Namespace: UnityEngine

### public struct UnityEngine.AccelerationEvent

#### Fields
- internal float m_TimeDelta
- internal float x
- internal float y
- internal float z

#### Properties
- public UnityEngine.Vector3 acceleration { get; }
- public float deltaTime { get; }

### internal class UnityEngine.CameraRaycastHelper

#### Constructors
- public CameraRaycastHelper()

#### Methods
- internal static UnityEngine.GameObject RaycastTry(UnityEngine.Camera cam, UnityEngine.Ray ray, float distance, int layerMask)
- internal static UnityEngine.GameObject RaycastTry2D(UnityEngine.Camera cam, UnityEngine.Ray ray, float distance, int layerMask)
- private static UnityEngine.GameObject RaycastTry2D_Injected(UnityEngine.Camera cam, ref UnityEngine.Ray ray, float distance, int layerMask)
- private static UnityEngine.GameObject RaycastTry_Injected(UnityEngine.Camera cam, ref UnityEngine.Ray ray, float distance, int layerMask)

### public class UnityEngine.Compass

#### Properties
- public bool enabled { get; set; }
- public float headingAccuracy { get; }
- public float magneticHeading { get; }
- public UnityEngine.Vector3 rawVector { get; }
- public double timestamp { get; }
- public float trueHeading { get; }

#### Constructors
- public Compass()

### public enum UnityEngine.DeviceOrientation
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FaceDown = 6
- FaceUp = 5
- LandscapeLeft = 3
- LandscapeRight = 4
- Portrait = 1
- PortraitUpsideDown = 2
- Unknown = 0

### public class UnityEngine.Gyroscope

#### Fields
- private int m_GyroIndex

#### Properties
- public UnityEngine.Quaternion attitude { get; }
- public bool enabled { get; set; }
- public UnityEngine.Vector3 gravity { get; }
- public UnityEngine.Vector3 rotationRate { get; }
- public UnityEngine.Vector3 rotationRateUnbiased { get; }
- public float updateInterval { get; set; }
- public UnityEngine.Vector3 userAcceleration { get; }

#### Constructors
- internal Gyroscope(int index)

#### Methods
- private static UnityEngine.Quaternion attitude_Internal(int idx)
- private static void attitude_Internal_Injected(int idx, out UnityEngine.Quaternion ret)
- private static bool getEnabled_Internal(int idx)
- private static float getUpdateInterval_Internal(int idx)
- private static UnityEngine.Vector3 gravity_Internal(int idx)
- private static void gravity_Internal_Injected(int idx, out UnityEngine.Vector3 ret)
- private static UnityEngine.Vector3 rotationRateUnbiased_Internal(int idx)
- private static void rotationRateUnbiased_Internal_Injected(int idx, out UnityEngine.Vector3 ret)
- private static UnityEngine.Vector3 rotationRate_Internal(int idx)
- private static void rotationRate_Internal_Injected(int idx, out UnityEngine.Vector3 ret)
- private static void setEnabled_Internal(int idx, bool enabled)
- private static void setUpdateInterval_Internal(int idx, float interval)
- private static UnityEngine.Vector3 userAcceleration_Internal(int idx)
- private static void userAcceleration_Internal_Injected(int idx, out UnityEngine.Vector3 ret)

### internal struct UnityEngine.LocationService.HeadingInfo

#### Fields
- public float headingAccuracy
- public float magneticHeading
- public UnityEngine.Vector3 raw
- public double timestamp
- public float trueHeading

### private struct UnityEngine.SendMouseEvents.HitInfo

#### Fields
- public UnityEngine.Camera camera
- public UnityEngine.GameObject target

#### Methods
- public static bool Compare(UnityEngine.SendMouseEvents.HitInfo lhs, UnityEngine.SendMouseEvents.HitInfo rhs)
- public static bool op_Implicit(UnityEngine.SendMouseEvents.HitInfo exists)
- public void SendMessage(string name)

### public enum UnityEngine.IMECompositionMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Auto = 0
- Off = 2
- On = 1

### public class UnityEngine.Input

#### Fields
- private static UnityEngine.Compass compassInstance
- private static UnityEngine.LocationService locationServiceInstance
- private static UnityEngine.Gyroscope s_MainGyro

#### Properties
- public static UnityEngine.Vector3 acceleration { get; }
- public static int accelerationEventCount { get; }
- public static UnityEngine.AccelerationEvent[] accelerationEvents { get; }
- public static bool anyKey { get; }
- public static bool anyKeyDown { get; }
- public static bool backButtonLeavesApp { get; set; }
- public static UnityEngine.Compass compass { get; }
- public static bool compensateSensors { get; set; }
- public static UnityEngine.Vector2 compositionCursorPos { get; set; }
- public static string compositionString { get; }
- public static UnityEngine.DeviceOrientation deviceOrientation { get; }
- public static bool eatKeyPressOnTextFieldFocus { get; set; }
- public static UnityEngine.Gyroscope gyro { get; }
- public static UnityEngine.IMECompositionMode imeCompositionMode { get; set; }
- public static bool imeIsSelected { get; }
- public static string inputString { get; }
- public static bool isGyroAvailable { get; }
- public static UnityEngine.LocationService location { get; }
- public static UnityEngine.Vector3 mousePosition { get; }
- public static bool mousePresent { get; }
- public static UnityEngine.Vector2 mouseScrollDelta { get; }
- public static bool multiTouchEnabled { get; set; }
- public static int penEventCount { get; }
- public static bool simulateMouseWithTouches { get; set; }
- public static bool stylusTouchSupported { get; }
- public static int touchCount { get; }
- public static UnityEngine.Touch[] touches { get; }
- public static bool touchPressureSupported { get; }
- public static bool touchSupported { get; }

#### Constructors
- public Input()

#### Methods
- internal static bool CheckDisabled()
- public static void ClearLastPenContactEvent()
- public static UnityEngine.AccelerationEvent GetAccelerationEvent(int index)
- private static void GetAccelerationEvent_Injected(int index, out UnityEngine.AccelerationEvent ret)
- public static float GetAxis(string axisName)
- public static float GetAxisRaw(string axisName)
- public static bool GetButton(string buttonName)
- public static bool GetButtonDown(string buttonName)
- public static bool GetButtonUp(string buttonName)
- private static int GetGyroInternal()
- public static string[] GetJoystickNames()
- public static bool GetKey(UnityEngine.KeyCode key)
- public static bool GetKey(string name)
- public static bool GetKeyDown(UnityEngine.KeyCode key)
- public static bool GetKeyDown(string name)
- private static bool GetKeyDownInt(UnityEngine.KeyCode key)
- private static bool GetKeyInt(UnityEngine.KeyCode key)
- public static bool GetKeyUp(UnityEngine.KeyCode key)
- public static bool GetKeyUp(string name)
- private static bool GetKeyUpInt(UnityEngine.KeyCode key)
- public static UnityEngine.PenData GetLastPenContactEvent()
- private static void GetLastPenContactEvent_Injected(out UnityEngine.PenData ret)
- public static bool GetMouseButton(int button)
- public static bool GetMouseButtonDown(int button)
- public static bool GetMouseButtonUp(int button)
- public static UnityEngine.PenData GetPenEvent(int index)
- private static void GetPenEvent_Injected(int index, out UnityEngine.PenData ret)
- public static UnityEngine.Touch GetTouch(int index)
- private static void GetTouch_Injected(int index, out UnityEngine.Touch ret)
- public static void ResetInputAxes()
- public static void ResetPenEvents()
- internal static void SimulateTouch(UnityEngine.Touch touch)
- private static void SimulateTouchInternal(UnityEngine.Touch touch, long timestamp)
- private static void SimulateTouchInternal_Injected(ref UnityEngine.Touch touch, long timestamp)

### public enum UnityEngine.SendMouseEvents.LeftMouseButtonState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- NotPressed = 0
- Pressed = 1
- PressedThisFrame = 2

### public struct UnityEngine.LocationInfo

#### Fields
- internal float m_Altitude
- internal float m_HorizontalAccuracy
- internal float m_Latitude
- internal float m_Longitude
- internal double m_Timestamp
- internal float m_VerticalAccuracy

#### Properties
- public float altitude { get; }
- public float horizontalAccuracy { get; }
- public float latitude { get; }
- public float longitude { get; }
- public double timestamp { get; }
- public float verticalAccuracy { get; }

### public class UnityEngine.LocationService

#### Properties
- public bool isEnabledByUser { get; }
- public UnityEngine.LocationInfo lastData { get; }
- public UnityEngine.LocationServiceStatus status { get; }

#### Constructors
- public LocationService()

#### Methods
- internal static UnityEngine.LocationService.HeadingInfo GetLastHeading()
- private static void GetLastHeading_Injected(out UnityEngine.LocationService.HeadingInfo ret)
- internal static UnityEngine.LocationInfo GetLastLocation()
- private static void GetLastLocation_Injected(out UnityEngine.LocationInfo ret)
- internal static UnityEngine.LocationServiceStatus GetLocationStatus()
- internal static bool IsHeadingUpdatesEnabled()
- internal static bool IsServiceEnabledByUser()
- internal static void SetDesiredAccuracy(float value)
- internal static void SetDistanceFilter(float value)
- internal static void SetHeadingUpdatesEnabled(bool value)
- public void Start(float desiredAccuracyInMeters, float updateDistanceInMeters)
- public void Start(float desiredAccuracyInMeters)
- public void Start()
- internal static void StartUpdatingLocation()
- public void Stop()
- internal static void StopUpdatingLocation()

### public enum UnityEngine.LocationServiceStatus
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Failed = 3
- Initializing = 1
- Running = 2
- Stopped = 0

### public struct UnityEngine.PenData

#### Fields
- public UnityEngine.PenEventType contactType
- public UnityEngine.Vector2 deltaPos
- public UnityEngine.PenStatus penStatus
- public UnityEngine.Vector2 position
- public float pressure
- public UnityEngine.Vector2 tilt
- public float twist

### public enum UnityEngine.PenEventType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- NoContact = 0
- PenDown = 1
- PenUp = 2

### public enum UnityEngine.PenStatus
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Barrel = 2
- Contact = 1
- Eraser = 8
- Inverted = 4
- None = 0

### internal class UnityEngine.SendMouseEvents

#### Fields
- private static UnityEngine.Camera[] m_Cameras
- private static readonly UnityEngine.SendMouseEvents.HitInfo[] m_CurrentHit
- private static const int m_HitIndexGUI
- private static const int m_HitIndexPhysics2D
- private static const int m_HitIndexPhysics3D
- private static readonly UnityEngine.SendMouseEvents.HitInfo[] m_LastHit
- private static readonly UnityEngine.SendMouseEvents.HitInfo[] m_MouseDownHit
- public static System.Func<System.Collections.Generic.KeyValuePair<int, UnityEngine.Vector2>> s_GetMouseState
- private static bool s_MouseButtonIsPressed
- private static bool s_MouseButtonPressedThisFrame
- private static UnityEngine.Vector2 s_MousePosition
- private static bool s_MouseUsed

#### Constructors
- public SendMouseEvents()
- private static SendMouseEvents()

#### Methods
- private static void DoSendMouseEvents(int skipRTCameras)
- private static void SendEvents(int i, UnityEngine.SendMouseEvents.HitInfo hit)
- private static void SetMouseMoved()
- private static void UpdateMouse()

### public struct UnityEngine.Touch

#### Fields
- private float m_AltitudeAngle
- private float m_AzimuthAngle
- private int m_FingerId
- private float m_maximumPossiblePressure
- private UnityEngine.TouchPhase m_Phase
- private UnityEngine.Vector2 m_Position
- private UnityEngine.Vector2 m_PositionDelta
- private float m_Pressure
- private float m_Radius
- private float m_RadiusVariance
- private UnityEngine.Vector2 m_RawPosition
- private int m_TapCount
- private float m_TimeDelta
- private UnityEngine.TouchType m_Type

#### Properties
- public float altitudeAngle { get; set; }
- public float azimuthAngle { get; set; }
- public UnityEngine.Vector2 deltaPosition { get; set; }
- public float deltaTime { get; set; }
- public int fingerId { get; set; }
- public float maximumPossiblePressure { get; set; }
- public UnityEngine.TouchPhase phase { get; set; }
- public UnityEngine.Vector2 position { get; set; }
- public float pressure { get; set; }
- public float radius { get; set; }
- public float radiusVariance { get; set; }
- public UnityEngine.Vector2 rawPosition { get; set; }
- public int tapCount { get; set; }
- public UnityEngine.TouchType type { get; set; }

### public enum UnityEngine.TouchPhase
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Began = 0
- Canceled = 4
- Ended = 3
- Moved = 1
- Stationary = 2

### public enum UnityEngine.TouchType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Direct = 0
- Indirect = 1
- Stylus = 2

## Namespace: UnityEngine.Internal

### internal static class UnityEngine.Internal.InputUnsafeUtility

#### Methods
- internal static float GetAxis(string axisName)
- internal static float GetAxisRaw(string axisName)
- internal static float GetAxisRaw__Unmanaged(byte* axisName, int axisNameLen)
- internal static float GetAxis__Unmanaged(byte* axisName, int axisNameLen)
- internal static bool GetButton(string buttonName)
- internal static bool GetButtonDown(string buttonName)
- internal static byte GetButtonDown__Unmanaged(byte* buttonName, int buttonNameLen)
- internal static bool GetButtonUp(string buttonName)
- internal static bool GetButtonUp__Unmanaged(byte* buttonName, int buttonNameLen)
- internal static bool GetButton__Unmanaged(byte* buttonName, int buttonNameLen)
- internal static bool GetKeyDownString(string name)
- internal static bool GetKeyDownString__Unmanaged(byte* name, int nameLen)
- internal static bool GetKeyString(string name)
- internal static bool GetKeyString__Unmanaged(byte* name, int nameLen)
- internal static bool GetKeyUpString(string name)
- internal static bool GetKeyUpString__Unmanaged(byte* name, int nameLen)

