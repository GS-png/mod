# Assembly: UnityEngine.ARModule
- Path: tools/WorldBox.Managed/UnityEngine.ARModule.dll
- Types: 3

## Namespace: UnityEngine.XR.Tango

### internal struct UnityEngine.XR.Tango.PoseData

#### Fields
- public double orientation_w
- public double orientation_x
- public double orientation_y
- public double orientation_z
- public UnityEngine.XR.Tango.PoseStatus statusCode
- public double translation_x
- public double translation_y
- public double translation_z

#### Properties
- public UnityEngine.Vector3 position { get; }
- public UnityEngine.Quaternion rotation { get; }

### internal enum UnityEngine.XR.Tango.PoseStatus
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Initializing = 0
- Invalid = 2
- Unknown = 3
- Valid = 1

### internal static class UnityEngine.XR.Tango.TangoInputTracking

#### Methods
- private static bool Internal_TryGetPoseAtTime(out UnityEngine.XR.Tango.PoseData pose)
- internal static bool TryGetPoseAtTime(out UnityEngine.XR.Tango.PoseData pose)

