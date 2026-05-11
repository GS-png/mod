# Assembly: UnityEngine.XRModule
- Path: tools/WorldBox.Managed/UnityEngine.XRModule.dll
- Types: 50

## Namespace: UnityEngine.XR

### internal enum UnityEngine.XR.AvailableTrackingData
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AccelerationAvailable = 16
- AngularAccelerationAvailable = 32
- AngularVelocityAvailable = 8
- None = 0
- PositionAvailable = 1
- RotationAvailable = 2
- VelocityAvailable = 4

### public struct UnityEngine.XR.Bone
- Interfaces: System.IEquatable<UnityEngine.XR.Bone>

#### Fields
- private ulong m_DeviceId
- private uint m_FeatureIndex

#### Properties
- internal ulong deviceId { get; }
- internal uint featureIndex { get; }

#### Methods
- private static bool Bone_TryGetChildBones(UnityEngine.XR.Bone bone, System.Collections.Generic.List<UnityEngine.XR.Bone> childBones)
- private static bool Bone_TryGetChildBones_Injected(ref UnityEngine.XR.Bone bone, System.Collections.Generic.List<UnityEngine.XR.Bone> childBones)
- private static bool Bone_TryGetParentBone(UnityEngine.XR.Bone bone, out UnityEngine.XR.Bone parentBone)
- private static bool Bone_TryGetParentBone_Injected(ref UnityEngine.XR.Bone bone, out UnityEngine.XR.Bone parentBone)
- private static bool Bone_TryGetPosition(UnityEngine.XR.Bone bone, out UnityEngine.Vector3 position)
- private static bool Bone_TryGetPosition_Injected(ref UnityEngine.XR.Bone bone, out UnityEngine.Vector3 position)
- private static bool Bone_TryGetRotation(UnityEngine.XR.Bone bone, out UnityEngine.Quaternion rotation)
- private static bool Bone_TryGetRotation_Injected(ref UnityEngine.XR.Bone bone, out UnityEngine.Quaternion rotation)
- public override bool Equals(object obj)
- public bool Equals(UnityEngine.XR.Bone other)
- public override int GetHashCode()
- public static bool op_Equality(UnityEngine.XR.Bone a, UnityEngine.XR.Bone b)
- public static bool op_Inequality(UnityEngine.XR.Bone a, UnityEngine.XR.Bone b)
- public bool TryGetChildBones(System.Collections.Generic.List<UnityEngine.XR.Bone> childBones)
- public bool TryGetParentBone(out UnityEngine.XR.Bone parentBone)
- public bool TryGetPosition(out UnityEngine.Vector3 position)
- public bool TryGetRotation(out UnityEngine.Quaternion rotation)

### public static class UnityEngine.XR.CommonUsages

#### Fields
- public static UnityEngine.XR.InputFeatureUsage<float> batteryLevel
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> centerEyeAcceleration
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> centerEyeAngularAcceleration
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> centerEyeAngularVelocity
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> centerEyePosition
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion> centerEyeRotation
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> centerEyeVelocity
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> colorCameraAcceleration
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> colorCameraAngularAcceleration
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> colorCameraAngularVelocity
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> colorCameraPosition
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion> colorCameraRotation
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> colorCameraVelocity
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> deviceAcceleration
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> deviceAngularAcceleration
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> deviceAngularVelocity
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> devicePosition
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion> deviceRotation
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> deviceVelocity
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector2> dPad
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.XR.Eyes> eyesData
- public static UnityEngine.XR.InputFeatureUsage<float> grip
- public static UnityEngine.XR.InputFeatureUsage<bool> gripButton
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.XR.Hand> handData
- public static UnityEngine.XR.InputFeatureUsage<float> indexFinger
- public static UnityEngine.XR.InputFeatureUsage<float> indexTouch
- public static UnityEngine.XR.InputFeatureUsage<bool> isTracked
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> leftEyeAcceleration
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> leftEyeAngularAcceleration
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> leftEyeAngularVelocity
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> leftEyePosition
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion> leftEyeRotation
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> leftEyeVelocity
- public static UnityEngine.XR.InputFeatureUsage<bool> menuButton
- public static UnityEngine.XR.InputFeatureUsage<float> middleFinger
- public static UnityEngine.XR.InputFeatureUsage<float> pinkyFinger
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector2> primary2DAxis
- public static UnityEngine.XR.InputFeatureUsage<bool> primary2DAxisClick
- public static UnityEngine.XR.InputFeatureUsage<bool> primary2DAxisTouch
- public static UnityEngine.XR.InputFeatureUsage<bool> primaryButton
- public static UnityEngine.XR.InputFeatureUsage<bool> primaryTouch
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> rightEyeAcceleration
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> rightEyeAngularAcceleration
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> rightEyeAngularVelocity
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> rightEyePosition
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion> rightEyeRotation
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> rightEyeVelocity
- public static UnityEngine.XR.InputFeatureUsage<float> ringFinger
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector2> secondary2DAxis
- public static UnityEngine.XR.InputFeatureUsage<bool> secondary2DAxisClick
- public static UnityEngine.XR.InputFeatureUsage<bool> secondary2DAxisTouch
- public static UnityEngine.XR.InputFeatureUsage<bool> secondaryButton
- public static UnityEngine.XR.InputFeatureUsage<bool> secondaryTouch
- public static UnityEngine.XR.InputFeatureUsage<bool> thumbrest
- public static UnityEngine.XR.InputFeatureUsage<float> thumbTouch
- public static UnityEngine.XR.InputFeatureUsage<UnityEngine.XR.InputTrackingState> trackingState
- public static UnityEngine.XR.InputFeatureUsage<float> trigger
- public static UnityEngine.XR.InputFeatureUsage<bool> triggerButton
- public static UnityEngine.XR.InputFeatureUsage<bool> userPresence

#### Constructors
- private static CommonUsages()

### internal enum UnityEngine.XR.ConnectionChangeType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ConfigChange = 2
- Connected = 0
- Disconnected = 1

### public struct UnityEngine.XR.Eyes
- Interfaces: System.IEquatable<UnityEngine.XR.Eyes>

#### Fields
- private ulong m_DeviceId
- private uint m_FeatureIndex

#### Properties
- internal ulong deviceId { get; }
- internal uint featureIndex { get; }

#### Methods
- public override bool Equals(object obj)
- public bool Equals(UnityEngine.XR.Eyes other)
- private static bool Eyes_TryGetEyeOpenAmount(UnityEngine.XR.Eyes eyes, UnityEngine.XR.EyeSide chirality, out float openAmount)
- private static bool Eyes_TryGetEyeOpenAmount_Injected(ref UnityEngine.XR.Eyes eyes, UnityEngine.XR.EyeSide chirality, out float openAmount)
- private static bool Eyes_TryGetEyePosition(UnityEngine.XR.Eyes eyes, UnityEngine.XR.EyeSide chirality, out UnityEngine.Vector3 position)
- private static bool Eyes_TryGetEyePosition_Injected(ref UnityEngine.XR.Eyes eyes, UnityEngine.XR.EyeSide chirality, out UnityEngine.Vector3 position)
- private static bool Eyes_TryGetEyeRotation(UnityEngine.XR.Eyes eyes, UnityEngine.XR.EyeSide chirality, out UnityEngine.Quaternion rotation)
- private static bool Eyes_TryGetEyeRotation_Injected(ref UnityEngine.XR.Eyes eyes, UnityEngine.XR.EyeSide chirality, out UnityEngine.Quaternion rotation)
- private static bool Eyes_TryGetFixationPoint(UnityEngine.XR.Eyes eyes, out UnityEngine.Vector3 fixationPoint)
- private static bool Eyes_TryGetFixationPoint_Injected(ref UnityEngine.XR.Eyes eyes, out UnityEngine.Vector3 fixationPoint)
- public override int GetHashCode()
- public static bool op_Equality(UnityEngine.XR.Eyes a, UnityEngine.XR.Eyes b)
- public static bool op_Inequality(UnityEngine.XR.Eyes a, UnityEngine.XR.Eyes b)
- public bool TryGetFixationPoint(out UnityEngine.Vector3 fixationPoint)
- public bool TryGetLeftEyeOpenAmount(out float openAmount)
- public bool TryGetLeftEyePosition(out UnityEngine.Vector3 position)
- public bool TryGetLeftEyeRotation(out UnityEngine.Quaternion rotation)
- public bool TryGetRightEyeOpenAmount(out float openAmount)
- public bool TryGetRightEyePosition(out UnityEngine.Vector3 position)
- public bool TryGetRightEyeRotation(out UnityEngine.Quaternion rotation)

### internal enum UnityEngine.XR.EyeSide
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Left = 0
- Right = 1

### public enum UnityEngine.XR.XRDisplaySubsystem.FoveatedRenderingFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- GazeAllowed = 1
- None = 0

### public struct UnityEngine.XR.Hand
- Interfaces: System.IEquatable<UnityEngine.XR.Hand>

#### Fields
- private ulong m_DeviceId
- private uint m_FeatureIndex

#### Properties
- internal ulong deviceId { get; }
- internal uint featureIndex { get; }

#### Methods
- public override bool Equals(object obj)
- public bool Equals(UnityEngine.XR.Hand other)
- public override int GetHashCode()
- private static bool Hand_TryGetFingerBonesAsList(UnityEngine.XR.Hand hand, UnityEngine.XR.HandFinger finger, System.Collections.Generic.List<UnityEngine.XR.Bone> bonesOut)
- private static bool Hand_TryGetFingerBonesAsList_Injected(ref UnityEngine.XR.Hand hand, UnityEngine.XR.HandFinger finger, System.Collections.Generic.List<UnityEngine.XR.Bone> bonesOut)
- private static bool Hand_TryGetRootBone(UnityEngine.XR.Hand hand, out UnityEngine.XR.Bone boneOut)
- private static bool Hand_TryGetRootBone_Injected(ref UnityEngine.XR.Hand hand, out UnityEngine.XR.Bone boneOut)
- public static bool op_Equality(UnityEngine.XR.Hand a, UnityEngine.XR.Hand b)
- public static bool op_Inequality(UnityEngine.XR.Hand a, UnityEngine.XR.Hand b)
- public bool TryGetFingerBones(UnityEngine.XR.HandFinger finger, System.Collections.Generic.List<UnityEngine.XR.Bone> bonesOut)
- public bool TryGetRootBone(out UnityEngine.XR.Bone boneOut)

### public enum UnityEngine.XR.HandFinger
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Index = 1
- Middle = 2
- Pinky = 4
- Ring = 3
- Thumb = 0

### public struct UnityEngine.XR.HapticCapabilities
- Interfaces: System.IEquatable<UnityEngine.XR.HapticCapabilities>

#### Fields
- private uint m_BufferFrequencyHz
- private uint m_BufferMaxSize
- private uint m_BufferOptimalSize
- private uint m_NumChannels
- private bool m_SupportsBuffer
- private bool m_SupportsImpulse

#### Properties
- public uint bufferFrequencyHz { get; internal set; }
- public uint bufferMaxSize { get; internal set; }
- public uint bufferOptimalSize { get; internal set; }
- public uint numChannels { get; internal set; }
- public bool supportsBuffer { get; internal set; }
- public bool supportsImpulse { get; internal set; }

#### Methods
- public override bool Equals(object obj)
- public bool Equals(UnityEngine.XR.HapticCapabilities other)
- public override int GetHashCode()
- public static bool op_Equality(UnityEngine.XR.HapticCapabilities a, UnityEngine.XR.HapticCapabilities b)
- public static bool op_Inequality(UnityEngine.XR.HapticCapabilities a, UnityEngine.XR.HapticCapabilities b)

### internal static class UnityEngine.XR.HashCodeHelper

#### Fields
- private static const int k_HashCodeMultiplier

#### Methods
- public static int Combine(int hash1, int hash2)
- public static int Combine(int hash1, int hash2, int hash3)
- public static int Combine(int hash1, int hash2, int hash3, int hash4)
- public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5)
- public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6)
- public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7)
- public static int Combine(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7, int hash8)

### public struct UnityEngine.XR.InputDevice
- Interfaces: System.IEquatable<UnityEngine.XR.InputDevice>

#### Fields
- private ulong m_DeviceId
- private bool m_Initialized
- private static System.Collections.Generic.List<UnityEngine.XR.XRInputSubsystem> s_InputSubsystemCache

#### Properties
- public UnityEngine.XR.InputDeviceCharacteristics characteristics { get; }
- private ulong deviceId { get; }
- public bool isValid { get; }
- public string manufacturer { get; }
- public string name { get; }
- public UnityEngine.XR.InputDeviceRole role { get; }
- public string serialNumber { get; }
- public UnityEngine.XR.XRInputSubsystem subsystem { get; }

#### Constructors
- internal InputDevice(ulong deviceId)

#### Methods
- private bool CheckValidAndSetDefault<T>(out T value)
- public override bool Equals(object obj)
- public bool Equals(UnityEngine.XR.InputDevice other)
- public override int GetHashCode()
- private bool IsValidId()
- public static bool op_Equality(UnityEngine.XR.InputDevice a, UnityEngine.XR.InputDevice b)
- public static bool op_Inequality(UnityEngine.XR.InputDevice a, UnityEngine.XR.InputDevice b)
- public bool SendHapticBuffer(uint channel, byte[] buffer)
- public bool SendHapticImpulse(uint channel, float amplitude, float duration = 1)
- public void StopHaptics()
- public bool TryGetFeatureUsages(System.Collections.Generic.List<UnityEngine.XR.InputFeatureUsage> featureUsages)
- public bool TryGetFeatureValue(UnityEngine.XR.InputFeatureUsage<bool> usage, out bool value)
- public bool TryGetFeatureValue(UnityEngine.XR.InputFeatureUsage<uint> usage, out uint value)
- public bool TryGetFeatureValue(UnityEngine.XR.InputFeatureUsage<float> usage, out float value)
- public bool TryGetFeatureValue(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector2> usage, out UnityEngine.Vector2 value)
- public bool TryGetFeatureValue(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> usage, out UnityEngine.Vector3 value)
- public bool TryGetFeatureValue(UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion> usage, out UnityEngine.Quaternion value)
- public bool TryGetFeatureValue(UnityEngine.XR.InputFeatureUsage<UnityEngine.XR.Hand> usage, out UnityEngine.XR.Hand value)
- public bool TryGetFeatureValue(UnityEngine.XR.InputFeatureUsage<UnityEngine.XR.Bone> usage, out UnityEngine.XR.Bone value)
- public bool TryGetFeatureValue(UnityEngine.XR.InputFeatureUsage<UnityEngine.XR.Eyes> usage, out UnityEngine.XR.Eyes value)
- public bool TryGetFeatureValue(UnityEngine.XR.InputFeatureUsage<byte[]> usage, byte[] value)
- public bool TryGetFeatureValue(UnityEngine.XR.InputFeatureUsage<UnityEngine.XR.InputTrackingState> usage, out UnityEngine.XR.InputTrackingState value)
- public bool TryGetFeatureValue(UnityEngine.XR.InputFeatureUsage<bool> usage, System.DateTime time, out bool value)
- public bool TryGetFeatureValue(UnityEngine.XR.InputFeatureUsage<uint> usage, System.DateTime time, out uint value)
- public bool TryGetFeatureValue(UnityEngine.XR.InputFeatureUsage<float> usage, System.DateTime time, out float value)
- public bool TryGetFeatureValue(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector2> usage, System.DateTime time, out UnityEngine.Vector2 value)
- public bool TryGetFeatureValue(UnityEngine.XR.InputFeatureUsage<UnityEngine.Vector3> usage, System.DateTime time, out UnityEngine.Vector3 value)
- public bool TryGetFeatureValue(UnityEngine.XR.InputFeatureUsage<UnityEngine.Quaternion> usage, System.DateTime time, out UnityEngine.Quaternion value)
- public bool TryGetFeatureValue(UnityEngine.XR.InputFeatureUsage<UnityEngine.XR.InputTrackingState> usage, System.DateTime time, out UnityEngine.XR.InputTrackingState value)
- public bool TryGetHapticCapabilities(out UnityEngine.XR.HapticCapabilities capabilities)

### public enum UnityEngine.XR.InputDeviceCharacteristics
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Camera = 2
- Controller = 64
- EyeTracking = 16
- HandTracking = 8
- HeadMounted = 1
- HeldInHand = 4
- Left = 256
- None = 0
- Right = 512
- Simulated6DOF = 1024
- TrackedDevice = 32
- TrackingReference = 128

### public enum UnityEngine.XR.InputDeviceRole
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- GameController = 4
- Generic = 1
- HardwareTracker = 6
- LeftHanded = 2
- LegacyController = 7
- RightHanded = 3
- TrackingReference = 5
- Unknown = 0

### public class UnityEngine.XR.InputDevices

#### Fields
- private static System.Action<UnityEngine.XR.InputDevice> deviceConfigChanged
- private static System.Action<UnityEngine.XR.InputDevice> deviceConnected
- private static System.Action<UnityEngine.XR.InputDevice> deviceDisconnected
- private static System.Collections.Generic.List<UnityEngine.XR.InputDevice> s_InputDeviceList

#### Events
- public static event System.Action<UnityEngine.XR.InputDevice> deviceConfigChanged
- public static event System.Action<UnityEngine.XR.InputDevice> deviceConnected
- public static event System.Action<UnityEngine.XR.InputDevice> deviceDisconnected

#### Constructors
- public InputDevices()

#### Methods
- public static UnityEngine.XR.InputDevice GetDeviceAtXRNode(UnityEngine.XR.XRNode node)
- internal static UnityEngine.XR.InputDeviceCharacteristics GetDeviceCharacteristics(ulong deviceId)
- internal static string GetDeviceManufacturer(ulong deviceId)
- internal static string GetDeviceName(ulong deviceId)
- internal static UnityEngine.XR.InputDeviceRole GetDeviceRole(ulong deviceId)
- public static void GetDevices(System.Collections.Generic.List<UnityEngine.XR.InputDevice> inputDevices)
- public static void GetDevicesAtXRNode(UnityEngine.XR.XRNode node, System.Collections.Generic.List<UnityEngine.XR.InputDevice> inputDevices)
- internal static string GetDeviceSerialNumber(ulong deviceId)
- public static void GetDevicesWithCharacteristics(UnityEngine.XR.InputDeviceCharacteristics desiredCharacteristics, System.Collections.Generic.List<UnityEngine.XR.InputDevice> inputDevices)
- public static void GetDevicesWithRole(UnityEngine.XR.InputDeviceRole role, System.Collections.Generic.List<UnityEngine.XR.InputDevice> inputDevices)
- private static void GetDevices_Internal(System.Collections.Generic.List<UnityEngine.XR.InputDevice> inputDevices)
- private static void InvokeConnectionEvent(ulong deviceId, UnityEngine.XR.ConnectionChangeType change)
- internal static bool IsDeviceValid(ulong deviceId)
- internal static bool SendHapticBuffer(ulong deviceId, uint channel, byte[] buffer)
- internal static bool SendHapticImpulse(ulong deviceId, uint channel, float amplitude, float duration)
- internal static void StopHaptics(ulong deviceId)
- internal static bool TryGetFeatureUsages(ulong deviceId, System.Collections.Generic.List<UnityEngine.XR.InputFeatureUsage> featureUsages)
- internal static bool TryGetFeatureValueAtTime_bool(ulong deviceId, string usage, long time, out bool value)
- internal static bool TryGetFeatureValueAtTime_float(ulong deviceId, string usage, long time, out float value)
- internal static bool TryGetFeatureValueAtTime_Quaternionf(ulong deviceId, string usage, long time, out UnityEngine.Quaternion value)
- internal static bool TryGetFeatureValueAtTime_UInt32(ulong deviceId, string usage, long time, out uint value)
- internal static bool TryGetFeatureValueAtTime_Vector2f(ulong deviceId, string usage, long time, out UnityEngine.Vector2 value)
- internal static bool TryGetFeatureValueAtTime_Vector3f(ulong deviceId, string usage, long time, out UnityEngine.Vector3 value)
- internal static bool TryGetFeatureValue_bool(ulong deviceId, string usage, out bool value)
- internal static bool TryGetFeatureValue_Custom(ulong deviceId, string usage, byte[] value)
- internal static bool TryGetFeatureValue_float(ulong deviceId, string usage, out float value)
- internal static bool TryGetFeatureValue_Quaternionf(ulong deviceId, string usage, out UnityEngine.Quaternion value)
- internal static bool TryGetFeatureValue_UInt32(ulong deviceId, string usage, out uint value)
- internal static bool TryGetFeatureValue_Vector2f(ulong deviceId, string usage, out UnityEngine.Vector2 value)
- internal static bool TryGetFeatureValue_Vector3f(ulong deviceId, string usage, out UnityEngine.Vector3 value)
- internal static bool TryGetFeatureValue_XRBone(ulong deviceId, string usage, out UnityEngine.XR.Bone value)
- internal static bool TryGetFeatureValue_XREyes(ulong deviceId, string usage, out UnityEngine.XR.Eyes value)
- internal static bool TryGetFeatureValue_XRHand(ulong deviceId, string usage, out UnityEngine.XR.Hand value)
- internal static bool TryGetHapticCapabilities(ulong deviceId, out UnityEngine.XR.HapticCapabilities capabilities)

### internal enum UnityEngine.XR.InputFeatureType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Axis1D = 3
- Axis2D = 4
- Axis3D = 5
- Binary = 1
- Bone = 8
- Custom = 0
- DiscreteStates = 2
- Eyes = 9
- Hand = 7
- kUnityXRInputFeatureTypeInvalid = 4294967295
- Rotation = 6

### public struct UnityEngine.XR.InputFeatureUsage
- Interfaces: System.IEquatable<UnityEngine.XR.InputFeatureUsage>

#### Fields
- internal UnityEngine.XR.InputFeatureType m_InternalType
- internal string m_Name

#### Properties
- internal UnityEngine.XR.InputFeatureType internalType { get; set; }
- public string name { get; internal set; }
- public System.Type type { get; }

#### Constructors
- internal InputFeatureUsage(string name, UnityEngine.XR.InputFeatureType type)

#### Methods
- public UnityEngine.XR.InputFeatureUsage<T> As<T>()
- public override bool Equals(object obj)
- public bool Equals(UnityEngine.XR.InputFeatureUsage other)
- public override int GetHashCode()
- public static bool op_Equality(UnityEngine.XR.InputFeatureUsage a, UnityEngine.XR.InputFeatureUsage b)
- public static bool op_Inequality(UnityEngine.XR.InputFeatureUsage a, UnityEngine.XR.InputFeatureUsage b)

### public struct UnityEngine.XR.InputFeatureUsage<T>
- Interfaces: System.IEquatable<UnityEngine.XR.InputFeatureUsage<T>>

#### Fields
- private string <name>k__BackingField

#### Properties
- public string name { get; set; }
- private System.Type usageType { get; }

#### Constructors
- public InputFeatureUsage<T>(string usageName)

#### Methods
- public override bool Equals(object obj)
- public bool Equals(UnityEngine.XR.InputFeatureUsage<T> other)
- public override int GetHashCode()
- public static bool op_Equality(UnityEngine.XR.InputFeatureUsage<T> a, UnityEngine.XR.InputFeatureUsage<T> b)
- public static UnityEngine.XR.InputFeatureUsage op_Explicit(UnityEngine.XR.InputFeatureUsage<T> self)
- public static bool op_Inequality(UnityEngine.XR.InputFeatureUsage<T> a, UnityEngine.XR.InputFeatureUsage<T> b)

### public static class UnityEngine.XR.InputTracking

#### Fields
- private static System.Action<UnityEngine.XR.XRNodeState> nodeAdded
- private static System.Action<UnityEngine.XR.XRNodeState> nodeRemoved
- private static System.Action<UnityEngine.XR.XRNodeState> trackingAcquired
- private static System.Action<UnityEngine.XR.XRNodeState> trackingLost

#### Properties
- public static bool disablePositionalTracking { get; set; }

#### Events
- public static event System.Action<UnityEngine.XR.XRNodeState> nodeAdded
- public static event System.Action<UnityEngine.XR.XRNodeState> nodeRemoved
- public static event System.Action<UnityEngine.XR.XRNodeState> trackingAcquired
- public static event System.Action<UnityEngine.XR.XRNodeState> trackingLost

#### Methods
- internal static ulong GetDeviceIdAtXRNode(UnityEngine.XR.XRNode node)
- internal static void GetDeviceIdsAtXRNode_Internal(UnityEngine.XR.XRNode node, System.Collections.Generic.List<ulong> deviceIds)
- public static UnityEngine.Vector3 GetLocalPosition(UnityEngine.XR.XRNode node)
- private static void GetLocalPosition_Injected(UnityEngine.XR.XRNode node, out UnityEngine.Vector3 ret)
- public static UnityEngine.Quaternion GetLocalRotation(UnityEngine.XR.XRNode node)
- private static void GetLocalRotation_Injected(UnityEngine.XR.XRNode node, out UnityEngine.Quaternion ret)
- public static string GetNodeName(ulong uniqueId)
- public static void GetNodeStates(System.Collections.Generic.List<UnityEngine.XR.XRNodeState> nodeStates)
- private static void GetNodeStates_Internal(System.Collections.Generic.List<UnityEngine.XR.XRNodeState> nodeStates)
- private static void InvokeTrackingEvent(UnityEngine.XR.InputTracking.TrackingStateEventType eventType, UnityEngine.XR.XRNode nodeType, long uniqueID, bool tracked)
- public static void Recenter()

### public enum UnityEngine.XR.InputTrackingState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Acceleration = 16
- All = 63
- AngularAcceleration = 32
- AngularVelocity = 8
- None = 0
- Position = 1
- Rotation = 2
- Velocity = 4

### public enum UnityEngine.XR.XRDisplaySubsystem.LateLatchNode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Head = 0
- LeftHand = 1
- RightHand = 2

### public enum UnityEngine.XR.MeshChangeState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Added = 0
- Removed = 2
- Unchanged = 3
- Updated = 1

### public enum UnityEngine.XR.MeshGenerationOptions
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ConsumeTransform = 1
- None = 0

### public struct UnityEngine.XR.MeshGenerationResult
- Interfaces: System.IEquatable<UnityEngine.XR.MeshGenerationResult>

#### Fields
- private readonly UnityEngine.XR.MeshVertexAttributes <Attributes>k__BackingField
- private readonly UnityEngine.Mesh <Mesh>k__BackingField
- private readonly UnityEngine.MeshCollider <MeshCollider>k__BackingField
- private readonly UnityEngine.XR.MeshId <MeshId>k__BackingField
- private readonly UnityEngine.Vector3 <Position>k__BackingField
- private readonly UnityEngine.Quaternion <Rotation>k__BackingField
- private readonly UnityEngine.Vector3 <Scale>k__BackingField
- private readonly UnityEngine.XR.MeshGenerationStatus <Status>k__BackingField
- private readonly ulong <Timestamp>k__BackingField

#### Properties
- public UnityEngine.XR.MeshVertexAttributes Attributes { get; }
- public UnityEngine.Mesh Mesh { get; }
- public UnityEngine.MeshCollider MeshCollider { get; }
- public UnityEngine.XR.MeshId MeshId { get; }
- public UnityEngine.Vector3 Position { get; }
- public UnityEngine.Quaternion Rotation { get; }
- public UnityEngine.Vector3 Scale { get; }
- public UnityEngine.XR.MeshGenerationStatus Status { get; }
- public ulong Timestamp { get; }

#### Methods
- public override bool Equals(object obj)
- public bool Equals(UnityEngine.XR.MeshGenerationResult other)
- public override int GetHashCode()
- public static bool op_Equality(UnityEngine.XR.MeshGenerationResult lhs, UnityEngine.XR.MeshGenerationResult rhs)
- public static bool op_Inequality(UnityEngine.XR.MeshGenerationResult lhs, UnityEngine.XR.MeshGenerationResult rhs)

### public enum UnityEngine.XR.MeshGenerationStatus
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Canceled = 3
- GenerationAlreadyInProgress = 2
- InvalidMeshId = 1
- Success = 0
- UnknownError = 4

### public struct UnityEngine.XR.MeshId
- Interfaces: System.IEquatable<UnityEngine.XR.MeshId>

#### Fields
- private ulong m_SubId1
- private ulong m_SubId2
- private static UnityEngine.XR.MeshId s_InvalidId

#### Properties
- public static UnityEngine.XR.MeshId InvalidId { get; }

#### Constructors
- private static MeshId()

#### Methods
- public override bool Equals(object obj)
- public bool Equals(UnityEngine.XR.MeshId other)
- public override int GetHashCode()
- public static bool op_Equality(UnityEngine.XR.MeshId id1, UnityEngine.XR.MeshId id2)
- public static bool op_Inequality(UnityEngine.XR.MeshId id1, UnityEngine.XR.MeshId id2)
- public override string ToString()

### public struct UnityEngine.XR.MeshInfo
- Interfaces: System.IEquatable<UnityEngine.XR.MeshInfo>

#### Fields
- private UnityEngine.XR.MeshChangeState <ChangeState>k__BackingField
- private UnityEngine.XR.MeshId <MeshId>k__BackingField
- private int <PriorityHint>k__BackingField

#### Properties
- public UnityEngine.XR.MeshChangeState ChangeState { get; set; }
- public UnityEngine.XR.MeshId MeshId { get; set; }
- public int PriorityHint { get; set; }

#### Methods
- public override bool Equals(object obj)
- public bool Equals(UnityEngine.XR.MeshInfo other)
- public override int GetHashCode()
- public static bool op_Equality(UnityEngine.XR.MeshInfo lhs, UnityEngine.XR.MeshInfo rhs)
- public static bool op_Inequality(UnityEngine.XR.MeshInfo lhs, UnityEngine.XR.MeshInfo rhs)

### public struct UnityEngine.XR.MeshTransform
- Interfaces: System.IEquatable<UnityEngine.XR.MeshTransform>

#### Fields
- private readonly UnityEngine.XR.MeshId <MeshId>k__BackingField
- private readonly UnityEngine.Vector3 <Position>k__BackingField
- private readonly UnityEngine.Quaternion <Rotation>k__BackingField
- private readonly UnityEngine.Vector3 <Scale>k__BackingField
- private readonly ulong <Timestamp>k__BackingField

#### Properties
- public UnityEngine.XR.MeshId MeshId { get; }
- public UnityEngine.Vector3 Position { get; }
- public UnityEngine.Quaternion Rotation { get; }
- public UnityEngine.Vector3 Scale { get; }
- public ulong Timestamp { get; }

#### Constructors
- public MeshTransform(in UnityEngine.XR.MeshId meshId, ulong timestamp, in UnityEngine.Vector3 position, in UnityEngine.Quaternion rotation, in UnityEngine.Vector3 scale)

#### Methods
- public override bool Equals(object obj)
- public bool Equals(UnityEngine.XR.MeshTransform other)
- public override int GetHashCode()
- public static bool op_Equality(UnityEngine.XR.MeshTransform lhs, UnityEngine.XR.MeshTransform rhs)
- public static bool op_Inequality(UnityEngine.XR.MeshTransform lhs, UnityEngine.XR.MeshTransform rhs)

### private struct UnityEngine.XR.XRMeshSubsystem.MeshTransformList
- Interfaces: System.IDisposable

#### Fields
- private readonly System.IntPtr m_Self

#### Properties
- public int Count { get; }
- public System.IntPtr Data { get; }

#### Constructors
- public XRMeshSubsystem.MeshTransformList(System.IntPtr self)

#### Methods
- public void Dispose()
- private static void Dispose(System.IntPtr self)
- private static System.IntPtr GetData(System.IntPtr self)
- private static int GetLength(System.IntPtr self)

### public enum UnityEngine.XR.MeshVertexAttributes
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Colors = 8
- None = 0
- Normals = 1
- Tangents = 2
- UVs = 4

### public enum UnityEngine.XR.XRDisplaySubsystem.ReprojectionMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- None = 3
- OrientationOnly = 2
- PositionAndOrientation = 1
- Unspecified = 0

### public enum UnityEngine.XR.XRDisplaySubsystem.TextureLayout
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- SeparateTexture2Ds = 4
- SingleTexture2D = 2
- Texture2DArray = 1

### internal static class UnityEngine.XR.TimeConverter

#### Fields
- private static readonly System.DateTime s_Epoch

#### Properties
- public static System.DateTime now { get; }

#### Constructors
- private static TimeConverter()

#### Methods
- public static long LocalDateTimeToUnixTimeMilliseconds(System.DateTime date)
- public static System.DateTime UnixTimeMillisecondsToLocalDateTime(long unixTimeInMilliseconds)

### public enum UnityEngine.XR.TrackingOriginModeFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Device = 1
- Floor = 2
- TrackingReference = 4
- Unbounded = 8
- Unknown = 0

### private enum UnityEngine.XR.InputTracking.TrackingStateEventType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- NodeAdded = 0
- NodeRemoved = 1
- TrackingAcquired = 2
- TrackingLost = 3

### public struct UnityEngine.XR.XRDisplaySubsystem.XRBlitParams

#### Fields
- public UnityEngine.Rect destRect
- public System.IntPtr foveatedRenderingInfo
- public UnityEngine.ColorGamut srcHdrColorGamut
- public bool srcHdrEncoded
- public int srcHdrMaxLuminance
- public UnityEngine.Rect srcRect
- public UnityEngine.RenderTexture srcTex
- public int srcTexArraySlice

### public class UnityEngine.XR.XRDisplaySubsystem
- Base: UnityEngine.IntegratedSubsystem<UnityEngine.XR.XRDisplaySubsystemDescriptor>
- Interfaces: UnityEngine.ISubsystem

#### Fields
- private System.Action<bool> displayFocusChanged
- private UnityEngine.HDROutputSettings m_HDROutputSettings

#### Properties
- public bool contentProtectionEnabled { get; set; }
- public bool disableLegacyRenderer { get; set; }
- public bool displayOpaque { get; }
- public UnityEngine.XR.XRDisplaySubsystem.FoveatedRenderingFlags foveatedRenderingFlags { get; set; }
- public float foveatedRenderingLevel { get; set; }
- public UnityEngine.HDROutputSettings hdrOutputSettings { get; }
- public float occlusionMaskScale { get; set; }
- public UnityEngine.XR.XRDisplaySubsystem.ReprojectionMode reprojectionMode { get; set; }
- public float scaleOfAllRenderTargets { get; set; }
- public float scaleOfAllViewports { get; set; }
- public bool singlePassRenderingDisabled { get; set; }
- public bool sRGB { get; set; }
- public UnityEngine.XR.XRDisplaySubsystem.TextureLayout supportedTextureLayouts { get; }
- public UnityEngine.XR.XRDisplaySubsystem.TextureLayout textureLayout { get; set; }
- public float zFar { get; set; }
- public float zNear { get; set; }

#### Events
- public event System.Action<bool> displayFocusChanged

#### Constructors
- public XRDisplaySubsystem()

#### Methods
- public bool AddGraphicsThreadMirrorViewBlit(UnityEngine.Rendering.CommandBuffer cmd, bool allowGraphicsStateInvalidate)
- public bool AddGraphicsThreadMirrorViewBlit(UnityEngine.Rendering.CommandBuffer cmd, bool allowGraphicsStateInvalidate, int mode)
- public void BeginRecordingIfLateLatched(UnityEngine.Camera camera)
- public void EndRecordingIfLateLatched(UnityEngine.Camera camera)
- public void GetCullingParameters(UnityEngine.Camera camera, int cullingPassIndex, out UnityEngine.Rendering.ScriptableCullingParameters scriptableCullingParameters)
- public bool GetMirrorViewBlitDesc(UnityEngine.RenderTexture mirrorRt, out UnityEngine.XR.XRDisplaySubsystem.XRMirrorViewBlitDesc outDesc)
- public bool GetMirrorViewBlitDesc(UnityEngine.RenderTexture mirrorRt, out UnityEngine.XR.XRDisplaySubsystem.XRMirrorViewBlitDesc outDesc, int mode)
- public int GetPreferredMirrorBlitMode()
- public void GetRenderPass(int renderPassIndex, out UnityEngine.XR.XRDisplaySubsystem.XRRenderPass renderPass)
- public int GetRenderPassCount()
- public UnityEngine.RenderTexture GetRenderTexture(uint unityXrRenderTextureId)
- public UnityEngine.RenderTexture GetRenderTextureForRenderPass(int renderPass)
- public UnityEngine.RenderTexture GetSharedDepthTextureForRenderPass(int renderPass)
- private bool Internal_TryBeginRecordingIfLateLatched(UnityEngine.Camera camera)
- private bool Internal_TryEndRecordingIfLateLatched(UnityEngine.Camera camera)
- private bool Internal_TryGetCullingParams(UnityEngine.Camera camera, int cullingPassIndex, out UnityEngine.Rendering.ScriptableCullingParameters scriptableCullingParameters)
- private bool Internal_TryGetRenderPass(int renderPassIndex, out UnityEngine.XR.XRDisplaySubsystem.XRRenderPass renderPass)
- private void InvokeDisplayFocusChanged(bool focus)
- public void MarkTransformLateLatched(UnityEngine.Transform transform, UnityEngine.XR.XRDisplaySubsystem.LateLatchNode nodeType)
- public void SetFocusPlane(UnityEngine.Vector3 point, UnityEngine.Vector3 normal, UnityEngine.Vector3 velocity)
- private void SetFocusPlane_Injected(ref UnityEngine.Vector3 point, ref UnityEngine.Vector3 normal, ref UnityEngine.Vector3 velocity)
- public void SetMSAALevel(int level)
- public void SetPreferredMirrorBlitMode(int blitMode)
- public bool TryGetAppGPUTimeLastFrame(out float gpuTimeLastFrame)
- public bool TryGetCompositorGPUTimeLastFrame(out float gpuTimeLastFrameCompositor)
- public bool TryGetDisplayRefreshRate(out float displayRefreshRate)
- public bool TryGetDroppedFrameCount(out int droppedFrameCount)
- public bool TryGetFramePresentCount(out int framePresentCount)
- public bool TryGetMotionToPhoton(out float motionToPhoton)

### public class UnityEngine.XR.XRDisplaySubsystemDescriptor
- Base: UnityEngine.IntegratedSubsystemDescriptor<UnityEngine.XR.XRDisplaySubsystem>
- Interfaces: UnityEngine.ISubsystemDescriptorImpl, UnityEngine.ISubsystemDescriptor

#### Properties
- public bool disablesLegacyVr { get; }
- public bool enableBackBufferMSAA { get; }

#### Constructors
- public XRDisplaySubsystemDescriptor()

#### Methods
- public int GetAvailableMirrorBlitModeCount()
- public void GetMirrorBlitModeByIndex(int index, out UnityEngine.XR.XRMirrorViewBlitModeDesc mode)

### public class UnityEngine.XR.XRInputSubsystem
- Base: UnityEngine.IntegratedSubsystem<UnityEngine.XR.XRInputSubsystemDescriptor>
- Interfaces: UnityEngine.ISubsystem

#### Fields
- private System.Action<UnityEngine.XR.XRInputSubsystem> boundaryChanged
- private System.Collections.Generic.List<ulong> m_DeviceIdsCache
- private System.Action<UnityEngine.XR.XRInputSubsystem> trackingOriginUpdated

#### Events
- public event System.Action<UnityEngine.XR.XRInputSubsystem> boundaryChanged
- public event System.Action<UnityEngine.XR.XRInputSubsystem> trackingOriginUpdated

#### Constructors
- public XRInputSubsystem()

#### Methods
- internal uint GetIndex()
- public UnityEngine.XR.TrackingOriginModeFlags GetSupportedTrackingOriginModes()
- public UnityEngine.XR.TrackingOriginModeFlags GetTrackingOriginMode()
- private static void InvokeBoundaryChangedEvent(System.IntPtr internalPtr)
- private static void InvokeTrackingOriginUpdatedEvent(System.IntPtr internalPtr)
- public bool TryGetBoundaryPoints(System.Collections.Generic.List<UnityEngine.Vector3> boundaryPoints)
- private bool TryGetBoundaryPoints_AsList(System.Collections.Generic.List<UnityEngine.Vector3> boundaryPoints)
- internal void TryGetDeviceIds_AsList(System.Collections.Generic.List<ulong> deviceIds)
- public bool TryGetInputDevices(System.Collections.Generic.List<UnityEngine.XR.InputDevice> devices)
- public bool TryRecenter()
- public bool TrySetTrackingOriginMode(UnityEngine.XR.TrackingOriginModeFlags origin)

### public class UnityEngine.XR.XRInputSubsystemDescriptor
- Base: UnityEngine.IntegratedSubsystemDescriptor<UnityEngine.XR.XRInputSubsystem>
- Interfaces: UnityEngine.ISubsystemDescriptorImpl, UnityEngine.ISubsystemDescriptor

#### Properties
- public bool disablesLegacyInput { get; }

#### Constructors
- public XRInputSubsystemDescriptor()

### public class UnityEngine.XR.XRMeshSubsystem
- Base: UnityEngine.IntegratedSubsystem<UnityEngine.XR.XRMeshSubsystemDescriptor>
- Interfaces: UnityEngine.ISubsystem

#### Properties
- public float meshDensity { get; set; }

#### Constructors
- public XRMeshSubsystem()

#### Methods
- public void GenerateMeshAsync(UnityEngine.XR.MeshId meshId, UnityEngine.Mesh mesh, UnityEngine.MeshCollider meshCollider, UnityEngine.XR.MeshVertexAttributes attributes, System.Action<UnityEngine.XR.MeshGenerationResult> onMeshGenerationComplete)
- public void GenerateMeshAsync(UnityEngine.XR.MeshId meshId, UnityEngine.Mesh mesh, UnityEngine.MeshCollider meshCollider, UnityEngine.XR.MeshVertexAttributes attributes, System.Action<UnityEngine.XR.MeshGenerationResult> onMeshGenerationComplete, UnityEngine.XR.MeshGenerationOptions options)
- private void GenerateMeshAsync_Injected(ref UnityEngine.XR.MeshId meshId, UnityEngine.Mesh mesh, UnityEngine.MeshCollider meshCollider, UnityEngine.XR.MeshVertexAttributes attributes, System.Action<UnityEngine.XR.MeshGenerationResult> onMeshGenerationComplete, UnityEngine.XR.MeshGenerationOptions options)
- private UnityEngine.XR.MeshInfo[] GetMeshInfosAsFixedArray()
- private bool GetMeshInfosAsList(System.Collections.Generic.List<UnityEngine.XR.MeshInfo> meshInfos)
- public Unity.Collections.NativeArray<UnityEngine.XR.MeshTransform> GetUpdatedMeshTransforms(Unity.Collections.Allocator allocator)
- private System.IntPtr GetUpdatedMeshTransforms()
- private void InvokeMeshReadyDelegate(UnityEngine.XR.MeshGenerationResult result, System.Action<UnityEngine.XR.MeshGenerationResult> onMeshGenerationComplete)
- public bool SetBoundingVolume(UnityEngine.Vector3 origin, UnityEngine.Vector3 extents)
- private bool SetBoundingVolume_Injected(ref UnityEngine.Vector3 origin, ref UnityEngine.Vector3 extents)
- public bool TryGetMeshInfos(System.Collections.Generic.List<UnityEngine.XR.MeshInfo> meshInfosOut)

### public class UnityEngine.XR.XRMeshSubsystemDescriptor
- Base: UnityEngine.IntegratedSubsystemDescriptor<UnityEngine.XR.XRMeshSubsystem>
- Interfaces: UnityEngine.ISubsystemDescriptorImpl, UnityEngine.ISubsystemDescriptor

#### Constructors
- public XRMeshSubsystemDescriptor()

### public struct UnityEngine.XR.XRDisplaySubsystem.XRMirrorViewBlitDesc

#### Fields
- public int blitParamsCount
- private System.IntPtr displaySubsystemInstance
- public bool nativeBlitAvailable
- public bool nativeBlitInvalidStates

#### Methods
- public void GetBlitParameter(int blitParameterIndex, out UnityEngine.XR.XRDisplaySubsystem.XRBlitParams blitParameter)
- private static void GetBlitParameter_Injected(ref UnityEngine.XR.XRDisplaySubsystem.XRMirrorViewBlitDesc _unity_self, int blitParameterIndex, out UnityEngine.XR.XRDisplaySubsystem.XRBlitParams blitParameter)

### public struct UnityEngine.XR.XRMirrorViewBlitMode

#### Fields
- public static const int Default
- public static const int Distort
- public static const int LeftEye
- public static const int None
- public static const int RightEye
- public static const int SideBySide
- public static const int SideBySideOcclusionMesh

### public struct UnityEngine.XR.XRMirrorViewBlitModeDesc

#### Fields
- public int blitMode
- public string blitModeDesc

### public enum UnityEngine.XR.XRNode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CenterEye = 2
- GameController = 6
- HardwareTracker = 8
- Head = 3
- LeftEye = 0
- LeftHand = 4
- RightEye = 1
- RightHand = 5
- TrackingReference = 7

### public struct UnityEngine.XR.XRNodeState

#### Fields
- private UnityEngine.Vector3 m_Acceleration
- private UnityEngine.Vector3 m_AngularAcceleration
- private UnityEngine.Vector3 m_AngularVelocity
- private UnityEngine.XR.AvailableTrackingData m_AvailableFields
- private UnityEngine.Vector3 m_Position
- private UnityEngine.Quaternion m_Rotation
- private int m_Tracked
- private UnityEngine.XR.XRNode m_Type
- private ulong m_UniqueID
- private UnityEngine.Vector3 m_Velocity

#### Properties
- public UnityEngine.Vector3 acceleration { set; }
- public UnityEngine.Vector3 angularAcceleration { set; }
- public UnityEngine.Vector3 angularVelocity { set; }
- public UnityEngine.XR.XRNode nodeType { get; set; }
- public UnityEngine.Vector3 position { set; }
- public UnityEngine.Quaternion rotation { set; }
- public bool tracked { get; set; }
- public ulong uniqueID { get; set; }
- public UnityEngine.Vector3 velocity { set; }

#### Methods
- private bool TryGet(UnityEngine.Vector3 inValue, UnityEngine.XR.AvailableTrackingData availabilityFlag, out UnityEngine.Vector3 outValue)
- private bool TryGet(UnityEngine.Quaternion inValue, UnityEngine.XR.AvailableTrackingData availabilityFlag, out UnityEngine.Quaternion outValue)
- public bool TryGetAcceleration(out UnityEngine.Vector3 acceleration)
- public bool TryGetAngularAcceleration(out UnityEngine.Vector3 angularAcceleration)
- public bool TryGetAngularVelocity(out UnityEngine.Vector3 angularVelocity)
- public bool TryGetPosition(out UnityEngine.Vector3 position)
- public bool TryGetRotation(out UnityEngine.Quaternion rotation)
- public bool TryGetVelocity(out UnityEngine.Vector3 velocity)

### public struct UnityEngine.XR.XRDisplaySubsystem.XRRenderParameter

#### Fields
- public bool isPreviousViewValid
- public UnityEngine.Mesh occlusionMesh
- public UnityEngine.Matrix4x4 previousView
- public UnityEngine.Matrix4x4 projection
- public int textureArraySlice
- public UnityEngine.Matrix4x4 view
- public UnityEngine.Rect viewport

### public struct UnityEngine.XR.XRDisplaySubsystem.XRRenderPass

#### Fields
- public int cullingPassIndex
- private System.IntPtr displaySubsystemInstance
- public System.IntPtr foveatedRenderingInfo
- public bool hasMotionVectorPass
- public UnityEngine.Rendering.RenderTargetIdentifier motionVectorRenderTarget
- public UnityEngine.RenderTextureDescriptor motionVectorRenderTargetDesc
- public int renderPassIndex
- public UnityEngine.Rendering.RenderTargetIdentifier renderTarget
- public UnityEngine.RenderTextureDescriptor renderTargetDesc
- public bool shouldFillOutDepth

#### Methods
- public void GetRenderParameter(UnityEngine.Camera camera, int renderParameterIndex, out UnityEngine.XR.XRDisplaySubsystem.XRRenderParameter renderParameter)
- public int GetRenderParameterCount()
- private static int GetRenderParameterCount_Injected(ref UnityEngine.XR.XRDisplaySubsystem.XRRenderPass _unity_self)
- private static void GetRenderParameter_Injected(ref UnityEngine.XR.XRDisplaySubsystem.XRRenderPass _unity_self, UnityEngine.Camera camera, int renderParameterIndex, out UnityEngine.XR.XRDisplaySubsystem.XRRenderParameter renderParameter)

## Namespace: UnityEngine.XR.Provider

### public static class UnityEngine.XR.Provider.XRStats

#### Methods
- public static bool TryGetStat(UnityEngine.IntegratedSubsystem xrSubsystem, string tag, out float value)
- private static bool TryGetStat_Internal(System.IntPtr ptr, string tag, out float value)

