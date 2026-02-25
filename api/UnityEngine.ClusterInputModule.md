# Assembly: UnityEngine.ClusterInputModule
- Path: tools/WorldBox.Managed/UnityEngine.ClusterInputModule.dll
- Types: 2

## Namespace: UnityEngine

### public class UnityEngine.ClusterInput

#### Constructors
- public ClusterInput()

#### Methods
- public static bool AddInput(string name, string deviceName, string serverUrl, int index, UnityEngine.ClusterInputType type)
- public static bool CheckConnectionToServer(string name)
- public static bool EditInput(string name, string deviceName, string serverUrl, int index, UnityEngine.ClusterInputType type)
- public static float GetAxis(string name)
- public static bool GetButton(string name)
- public static UnityEngine.Vector3 GetTrackerPosition(string name)
- private static void GetTrackerPosition_Injected(string name, out UnityEngine.Vector3 ret)
- public static UnityEngine.Quaternion GetTrackerRotation(string name)
- private static void GetTrackerRotation_Injected(string name, out UnityEngine.Quaternion ret)
- public static void SetAxis(string name, float value)
- public static void SetButton(string name, bool value)
- public static void SetTrackerPosition(string name, UnityEngine.Vector3 value)
- private static void SetTrackerPosition_Injected(string name, ref UnityEngine.Vector3 value)
- public static void SetTrackerRotation(string name, UnityEngine.Quaternion value)
- private static void SetTrackerRotation_Injected(string name, ref UnityEngine.Quaternion value)

### public enum UnityEngine.ClusterInputType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Axis = 1
- Button = 0
- CustomProvidedInput = 3
- Tracker = 2

