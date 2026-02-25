# Assembly: UnityEngine.ClusterRendererModule
- Path: tools/WorldBox.Managed/UnityEngine.ClusterRendererModule.dll
- Types: 2

## Namespace: UnityEngine

### public class UnityEngine.ClusterNetwork

#### Properties
- public static bool isDisconnected { get; }
- public static bool isMasterOfCluster { get; }
- public static int nodeIndex { get; set; }

#### Constructors
- public ClusterNetwork()

### public static class UnityEngine.ClusterSerialization

#### Methods
- public static bool RestoreClusterInputState(Unity.Collections.NativeArray<byte> buffer)
- private static bool RestoreClusterInputStateInternal(void* buffer, int bufferSize)
- public static bool RestoreInputManagerState(Unity.Collections.NativeArray<byte> buffer)
- private static bool RestoreInputManagerStateInternal(void* buffer, int bufferSize)
- public static bool RestoreTimeManagerState(Unity.Collections.NativeArray<byte> buffer)
- private static bool RestoreTimeManagerStateInternal(void* buffer, int bufferSize)
- public static int SaveClusterInputState(Unity.Collections.NativeArray<byte> buffer)
- private static int SaveClusterInputStateInternal(void* intBuffer, int bufferSize)
- public static int SaveInputManagerState(Unity.Collections.NativeArray<byte> buffer)
- private static int SaveInputManagerStateInternal(void* intBuffer, int bufferSize)
- public static int SaveTimeManagerState(Unity.Collections.NativeArray<byte> buffer)
- private static int SaveTimeManagerStateInternal(void* intBuffer, int bufferSize)

