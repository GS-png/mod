# Assembly: UnityEngine.VRModule
- Path: tools/WorldBox.Managed/UnityEngine.VRModule.dll
- Types: 10

## Namespace: UnityEngine.Experimental.XR

### internal enum UnityEngine.Experimental.XR.DeleteMe
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Please = 0

## Namespace: UnityEngine.XR

### public enum UnityEngine.XR.GameViewRenderMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BothEyes = 3
- LeftEye = 1
- None = 0
- OcclusionMesh = 4
- RightEye = 2

### public enum UnityEngine.XR.XRSettings.StereoRenderingMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- MultiPass = 0
- SinglePass = 1
- SinglePassInstanced = 2
- SinglePassMultiview = 3

### public enum UnityEngine.XR.TrackingSpaceType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- RoomScale = 1
- Stationary = 0

### public static class UnityEngine.XR.XRDevice

#### Fields
- private static System.Action<string> deviceLoaded

#### Properties
- public static float fovZoomFactor { get; set; }
- public static bool isPresent { get; }
- public static float refreshRate { get; }

#### Events
- public static event System.Action<string> deviceLoaded

#### Methods
- public static void DisableAutoXRCameraTracking(UnityEngine.Camera camera, bool disabled)
- public static System.IntPtr GetNativePtr()
- public static UnityEngine.XR.TrackingSpaceType GetTrackingSpaceType()
- private static void InvokeDeviceLoaded(string loadedDeviceName)
- public static bool SetTrackingSpaceType(UnityEngine.XR.TrackingSpaceType trackingSpaceType)
- public static void UpdateEyeTextureMSAASetting()

### public static class UnityEngine.XR.XRSettings

#### Properties
- public static UnityEngine.Rendering.TextureDimension deviceEyeTextureDimension { get; }
- public static bool enabled { get; set; }
- public static UnityEngine.RenderTextureDescriptor eyeTextureDesc { get; }
- public static int eyeTextureHeight { get; }
- public static float eyeTextureResolutionScale { get; set; }
- public static int eyeTextureWidth { get; }
- public static UnityEngine.XR.GameViewRenderMode gameViewRenderMode { get; set; }
- public static bool isDeviceActive { get; }
- public static string loadedDeviceName { get; }
- public static float occlusionMaskScale { get; set; }
- public static float renderViewportScale { get; set; }
- internal static float renderViewportScaleInternal { get; set; }
- public static bool showDeviceView { get; set; }
- public static UnityEngine.XR.XRSettings.StereoRenderingMode stereoRenderingMode { get; }
- public static string[] supportedDevices { get; }
- public static bool useOcclusionMesh { get; set; }

#### Methods
- public static void LoadDeviceByName(string deviceName)
- public static void LoadDeviceByName(string[] prioritizedDeviceNameList)

### public static class UnityEngine.XR.XRStats

#### Methods
- public static bool TryGetDroppedFrameCount(out int droppedFrameCount)
- public static bool TryGetFramePresentCount(out int framePresentCount)
- public static bool TryGetGPUTimeLastFrame(out float gpuTimeLastFrame)

## Namespace: UnityEngine.XR.WSA

### public enum UnityEngine.XR.WSA.RemoteDeviceVersion
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- V1 = 0
- V2 = 1

## Namespace: UnityEngine.XR.WSA.Input

### internal enum UnityEngine.XR.WSA.Input.DeleteMe
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Please = 0

## Namespace: UnityEngineInternal.XR.WSA

### public class UnityEngineInternal.XR.WSA.RemoteSpeechAccess

#### Constructors
- public RemoteSpeechAccess()

#### Methods
- public static void DisableRemoteSpeech()
- public static void EnableRemoteSpeech(UnityEngine.XR.WSA.RemoteDeviceVersion version)

