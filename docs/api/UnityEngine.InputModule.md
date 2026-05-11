# Assembly: UnityEngine.InputModule
- Path: tools/WorldBox.Managed/UnityEngine.InputModule.dll
- Types: 6

## Namespace: UnityEngineInternal.Input

### internal struct UnityEngineInternal.Input.NativeInputEvent

#### Fields
- public ushort deviceId
- public int eventId
- public ushort sizeInBytes
- public static const int structSize
- public double time
- public UnityEngineInternal.Input.NativeInputEventType type

#### Constructors
- public NativeInputEvent(UnityEngineInternal.Input.NativeInputEventType type, int sizeInBytes, int deviceId, double time)

### internal struct UnityEngineInternal.Input.NativeInputEventBuffer

#### Fields
- public int capacityInBytes
- public void* eventBuffer
- public int eventCount
- public int sizeInBytes
- public static const int structSize

### internal enum UnityEngineInternal.Input.NativeInputEventType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Delta = 1145852993
- DeviceConfigChanged = 1145259591
- DeviceRemoved = 1146242381
- State = 1398030676
- Text = 1413830740

### internal class UnityEngineInternal.Input.NativeInputSystem

#### Fields
- public static System.Action<UnityEngineInternal.Input.NativeInputUpdateType> onBeforeUpdate
- public static System.Func<UnityEngineInternal.Input.NativeInputUpdateType, bool> onShouldRunUpdate
- public static UnityEngineInternal.Input.NativeUpdateCallback onUpdate
- private static System.Action<int, string> s_OnDeviceDiscoveredCallback

#### Properties
- internal static bool allowInputDeviceCreationFromEvents { get; set; }
- public static double currentTime { get; }
- public static double currentTimeOffsetToRealtimeSinceStartup { get; }
- internal static bool hasDeviceDiscoveredCallback { set; }
- public static System.Action<int, string> onDeviceDiscovered { get; set; }

#### Constructors
- private static NativeInputSystem()
- public NativeInputSystem()

#### Methods
- public static int AllocateDeviceId()
- internal static ulong GetBackgroundEventBufferSize()
- public static long IOCTL(int deviceId, int code, System.IntPtr data, int sizeInBytes)
- internal static void NotifyBeforeUpdate(UnityEngineInternal.Input.NativeInputUpdateType updateType)
- internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor)
- internal static void NotifyUpdate(UnityEngineInternal.Input.NativeInputUpdateType updateType, System.IntPtr eventBuffer)
- public static void QueueInputEvent<TInputEvent>(ref TInputEvent inputEvent)
- public static void QueueInputEvent(System.IntPtr inputEvent)
- public static void SetPollingFrequency(float hertz)
- public static void SetUpdateMask(UnityEngineInternal.Input.NativeInputUpdateType mask)
- internal static void ShouldRunUpdate(UnityEngineInternal.Input.NativeInputUpdateType updateType, out bool retval)
- public static void Update(UnityEngineInternal.Input.NativeInputUpdateType updateType)

### internal enum UnityEngineInternal.Input.NativeInputUpdateType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BeforeRender = 4
- Dynamic = 1
- Editor = 8
- Fixed = 2
- IgnoreFocus = -2147483648

### internal delegate UnityEngineInternal.Input.NativeUpdateCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public NativeUpdateCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(UnityEngineInternal.Input.NativeInputUpdateType updateType, UnityEngineInternal.Input.NativeInputEventBuffer* buffer, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(UnityEngineInternal.Input.NativeInputUpdateType updateType, UnityEngineInternal.Input.NativeInputEventBuffer* buffer)

