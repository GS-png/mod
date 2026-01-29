# Assembly: UnityEngine.ContentLoadModule
- Path: tools/WorldBox.Managed/UnityEngine.ContentLoadModule.dll
- Types: 8

## Namespace: Unity.Loading

### public struct Unity.Loading.ContentFile

#### Fields
- internal ulong Id

#### Properties
- public static Unity.Loading.ContentFile GlobalTableDependency { get; }
- public bool IsValid { get; }
- public Unity.Loading.LoadingStatus LoadingStatus { get; }

#### Methods
- public UnityEngine.Object GetObject(ulong localIdentifierInFile)
- public UnityEngine.Object[] GetObjects()
- private void ThrowIfInvalidHandle()
- private void ThrowIfNotComplete()
- public Unity.Loading.ContentFileUnloadHandle UnloadAsync()
- public bool WaitForCompletion(int timeoutMs)

### internal enum Unity.Loading.ContentFileReservedID
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- None = 0
- ResolveReferencesWithPM = 1

### public struct Unity.Loading.ContentFileUnloadHandle

#### Fields
- internal Unity.Loading.ContentFile Id

#### Properties
- public bool IsCompleted { get; }

#### Methods
- public bool WaitForCompletion(int timeoutMs)

### public static class Unity.Loading.ContentLoadInterface

#### Properties
- internal static float IntegrationTimeMS { get; set; }

#### Methods
- internal static Unity.Loading.LoadingStatus ContentFile_GetLoadingStatus(Unity.Loading.ContentFile handle)
- private static Unity.Loading.LoadingStatus ContentFile_GetLoadingStatus_Injected(ref Unity.Loading.ContentFile handle)
- internal static UnityEngine.Object ContentFile_GetObject(Unity.Loading.ContentFile handle, ulong localIdentifierInFile)
- internal static UnityEngine.Object[] ContentFile_GetObjects(Unity.Loading.ContentFile handle)
- private static UnityEngine.Object[] ContentFile_GetObjects_Injected(ref Unity.Loading.ContentFile handle)
- private static UnityEngine.Object ContentFile_GetObject_Injected(ref Unity.Loading.ContentFile handle, ulong localIdentifierInFile)
- internal static bool ContentFile_IsHandleValid(Unity.Loading.ContentFile handle)
- private static bool ContentFile_IsHandleValid_Injected(ref Unity.Loading.ContentFile handle)
- internal static bool ContentFile_IsUnloadComplete(Unity.Loading.ContentFile handle)
- private static bool ContentFile_IsUnloadComplete_Injected(ref Unity.Loading.ContentFile handle)
- internal static void ContentFile_UnloadAsync(Unity.Loading.ContentFile handle)
- private static void ContentFile_UnloadAsync_Injected(ref Unity.Loading.ContentFile handle)
- internal static UnityEngine.SceneManagement.Scene ContentSceneFile_GetScene(Unity.Loading.ContentSceneFile handle)
- private static void ContentSceneFile_GetScene_Injected(ref Unity.Loading.ContentSceneFile handle, out UnityEngine.SceneManagement.Scene ret)
- internal static Unity.Loading.SceneLoadingStatus ContentSceneFile_GetStatus(Unity.Loading.ContentSceneFile handle)
- private static Unity.Loading.SceneLoadingStatus ContentSceneFile_GetStatus_Injected(ref Unity.Loading.ContentSceneFile handle)
- internal static void ContentSceneFile_IntegrateAtEndOfFrame(Unity.Loading.ContentSceneFile handle)
- private static void ContentSceneFile_IntegrateAtEndOfFrame_Injected(ref Unity.Loading.ContentSceneFile handle)
- internal static bool ContentSceneFile_IsHandleValid(Unity.Loading.ContentSceneFile handle)
- private static bool ContentSceneFile_IsHandleValid_Injected(ref Unity.Loading.ContentSceneFile handle)
- internal static bool ContentSceneFile_UnloadAtEndOfFrame(Unity.Loading.ContentSceneFile handle)
- private static bool ContentSceneFile_UnloadAtEndOfFrame_Injected(ref Unity.Loading.ContentSceneFile handle)
- internal static bool ContentSceneFile_WaitForCompletion(Unity.Loading.ContentSceneFile handle, int timeoutMs)
- private static bool ContentSceneFile_WaitForCompletion_Injected(ref Unity.Loading.ContentSceneFile handle, int timeoutMs)
- public static Unity.Loading.ContentFile[] GetContentFiles(Unity.Content.ContentNamespace nameSpace)
- private static Unity.Loading.ContentFile[] GetContentFiles_Injected(ref Unity.Content.ContentNamespace nameSpace)
- public static float GetIntegrationTimeMS()
- public static Unity.Loading.ContentSceneFile[] GetSceneFiles(Unity.Content.ContentNamespace nameSpace)
- private static Unity.Loading.ContentSceneFile[] GetSceneFiles_Injected(ref Unity.Content.ContentNamespace nameSpace)
- internal static Unity.Loading.ContentFile LoadContentFileAsync(Unity.Content.ContentNamespace nameSpace, string filename, void* dependencies, int dependencyCount, Unity.Jobs.JobHandle dependentFence, bool useUnsafe = false)
- public static Unity.Loading.ContentFile LoadContentFileAsync(Unity.Content.ContentNamespace nameSpace, string filename, Unity.Collections.NativeArray<Unity.Loading.ContentFile> dependencies, Unity.Jobs.JobHandle dependentFence = null)
- private static void LoadContentFileAsync_Injected(ref Unity.Content.ContentNamespace nameSpace, string filename, void* dependencies, int dependencyCount, ref Unity.Jobs.JobHandle dependentFence, bool useUnsafe = false, out Unity.Loading.ContentFile ret)
- internal static Unity.Loading.ContentSceneFile LoadSceneAsync(Unity.Content.ContentNamespace nameSpace, string filename, string sceneName, Unity.Loading.ContentSceneParameters sceneParams, Unity.Loading.ContentFile* dependencies, int dependencyCount, Unity.Jobs.JobHandle dependentFence)
- public static Unity.Loading.ContentSceneFile LoadSceneAsync(Unity.Content.ContentNamespace nameSpace, string filename, string sceneName, Unity.Loading.ContentSceneParameters sceneParams, Unity.Collections.NativeArray<Unity.Loading.ContentFile> dependencies, Unity.Jobs.JobHandle dependentFence = null)
- private static void LoadSceneAsync_Injected(ref Unity.Content.ContentNamespace nameSpace, string filename, string sceneName, ref Unity.Loading.ContentSceneParameters sceneParams, Unity.Loading.ContentFile* dependencies, int dependencyCount, ref Unity.Jobs.JobHandle dependentFence, out Unity.Loading.ContentSceneFile ret)
- public static void SetIntegrationTimeMS(float integrationTimeMS)
- internal static bool WaitForLoadCompletion(Unity.Loading.ContentFile handle, int timeoutMs)
- private static bool WaitForLoadCompletion_Injected(ref Unity.Loading.ContentFile handle, int timeoutMs)
- internal static bool WaitForUnloadCompletion(Unity.Loading.ContentFile handle, int timeoutMs)
- private static bool WaitForUnloadCompletion_Injected(ref Unity.Loading.ContentFile handle, int timeoutMs)

### public struct Unity.Loading.ContentSceneFile

#### Fields
- internal ulong Id

#### Properties
- public bool IsValid { get; }
- public UnityEngine.SceneManagement.Scene Scene { get; }
- public Unity.Loading.SceneLoadingStatus Status { get; }

#### Methods
- public void IntegrateAtEndOfFrame()
- private void ThrowIfInvalidHandle()
- public bool UnloadAtEndOfFrame()
- public bool WaitForLoadCompletion(int timeoutMs)

### public struct Unity.Loading.ContentSceneParameters

#### Fields
- internal bool m_AutoIntegrate
- internal UnityEngine.SceneManagement.LoadSceneMode m_LoadSceneMode
- internal UnityEngine.SceneManagement.LocalPhysicsMode m_LocalPhysicsMode

#### Properties
- public bool autoIntegrate { get; set; }
- public UnityEngine.SceneManagement.LoadSceneMode loadSceneMode { get; set; }
- public UnityEngine.SceneManagement.LocalPhysicsMode localPhysicsMode { get; set; }

### public enum Unity.Loading.LoadingStatus
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Completed = 1
- Failed = 2
- InProgress = 0

### public enum Unity.Loading.SceneLoadingStatus
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Complete = 3
- Failed = 4
- InProgress = 0
- WaitingForIntegrate = 1
- WillIntegrateNextFrame = 2

