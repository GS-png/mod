# Assembly: UnityEngine.AssetBundleModule
- Path: tools/WorldBox.Managed/UnityEngine.AssetBundleModule.dll
- Types: 9

## Namespace: UnityEngine

### public class UnityEngine.AssetBundle
- Base: UnityEngine.Object

#### Properties
- public bool isStreamedSceneAssetBundle { get; }
- public UnityEngine.Object mainAsset { get; }
- public static uint memoryBudgetKB { get; set; }

#### Constructors
- private AssetBundle()

#### Methods
- public string[] AllAssetNames()
- public bool Contains(string name)
- internal static T[] ConvertObjects<T>(UnityEngine.Object[] rawObjects)
- public string[] GetAllAssetNames()
- public static System.Collections.Generic.IEnumerable<UnityEngine.AssetBundle> GetAllLoadedAssetBundles()
- internal static UnityEngine.AssetBundle[] GetAllLoadedAssetBundles_Native()
- public string[] GetAllScenePaths()
- public UnityEngine.Object Load(string name)
- public UnityEngine.Object Load<T>(string name)
- private UnityEngine.Object Load(string name, System.Type type)
- private UnityEngine.Object[] LoadAll(System.Type type)
- public UnityEngine.Object[] LoadAll()
- public T[] LoadAll<T>()
- public UnityEngine.Object[] LoadAllAssets()
- public T[] LoadAllAssets<T>()
- public UnityEngine.Object[] LoadAllAssets(System.Type type)
- public UnityEngine.AssetBundleRequest LoadAllAssetsAsync()
- public UnityEngine.AssetBundleRequest LoadAllAssetsAsync<T>()
- public UnityEngine.AssetBundleRequest LoadAllAssetsAsync(System.Type type)
- public UnityEngine.Object LoadAsset(string name)
- public T LoadAsset<T>(string name)
- public UnityEngine.Object LoadAsset(string name, System.Type type)
- public UnityEngine.AssetBundleRequest LoadAssetAsync(string name)
- public UnityEngine.AssetBundleRequest LoadAssetAsync<T>(string name)
- public UnityEngine.AssetBundleRequest LoadAssetAsync(string name, System.Type type)
- private UnityEngine.AssetBundleRequest LoadAssetAsync_Internal(string name, System.Type type)
- public UnityEngine.Object[] LoadAssetWithSubAssets(string name)
- public T[] LoadAssetWithSubAssets<T>(string name)
- public UnityEngine.Object[] LoadAssetWithSubAssets(string name, System.Type type)
- public UnityEngine.AssetBundleRequest LoadAssetWithSubAssetsAsync(string name)
- public UnityEngine.AssetBundleRequest LoadAssetWithSubAssetsAsync<T>(string name)
- public UnityEngine.AssetBundleRequest LoadAssetWithSubAssetsAsync(string name, System.Type type)
- private UnityEngine.AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, System.Type type)
- internal UnityEngine.Object[] LoadAssetWithSubAssets_Internal(string name, System.Type type)
- private UnityEngine.Object LoadAsset_Internal(string name, System.Type type)
- private UnityEngine.AssetBundleRequest LoadAsync(string name, System.Type type)
- public static UnityEngine.AssetBundle LoadFromFile(string path)
- public static UnityEngine.AssetBundle LoadFromFile(string path, uint crc)
- public static UnityEngine.AssetBundle LoadFromFile(string path, uint crc, ulong offset)
- public static UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(string path)
- public static UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc)
- public static UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc, ulong offset)
- internal static UnityEngine.AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset)
- internal static UnityEngine.AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset)
- public static UnityEngine.AssetBundle LoadFromMemory(byte[] binary)
- public static UnityEngine.AssetBundle LoadFromMemory(byte[] binary, uint crc)
- public static UnityEngine.AssetBundleCreateRequest LoadFromMemoryAsync(byte[] binary)
- public static UnityEngine.AssetBundleCreateRequest LoadFromMemoryAsync(byte[] binary, uint crc)
- internal static UnityEngine.AssetBundleCreateRequest LoadFromMemoryAsync_Internal(byte[] binary, uint crc)
- internal static UnityEngine.AssetBundle LoadFromMemory_Internal(byte[] binary, uint crc)
- public static UnityEngine.AssetBundle LoadFromStream(System.IO.Stream stream, uint crc, uint managedReadBufferSize)
- public static UnityEngine.AssetBundle LoadFromStream(System.IO.Stream stream, uint crc)
- public static UnityEngine.AssetBundle LoadFromStream(System.IO.Stream stream)
- public static UnityEngine.AssetBundleCreateRequest LoadFromStreamAsync(System.IO.Stream stream, uint crc, uint managedReadBufferSize)
- public static UnityEngine.AssetBundleCreateRequest LoadFromStreamAsync(System.IO.Stream stream, uint crc)
- public static UnityEngine.AssetBundleCreateRequest LoadFromStreamAsync(System.IO.Stream stream)
- internal static UnityEngine.AssetBundleCreateRequest LoadFromStreamAsyncInternal(System.IO.Stream stream, uint crc, uint managedReadBufferSize)
- internal static UnityEngine.AssetBundle LoadFromStreamInternal(System.IO.Stream stream, uint crc, uint managedReadBufferSize)
- public static UnityEngine.AssetBundleRecompressOperation RecompressAssetBundleAsync(string inputPath, string outputPath, UnityEngine.BuildCompression method, uint expectedCRC = 0, UnityEngine.ThreadPriority priority = Low)
- internal static UnityEngine.AssetBundleRecompressOperation RecompressAssetBundleAsync_Internal(string inputPath, string outputPath, UnityEngine.BuildCompression method, uint expectedCRC, UnityEngine.ThreadPriority priority)
- private static UnityEngine.AssetBundleRecompressOperation RecompressAssetBundleAsync_Internal_Injected(string inputPath, string outputPath, ref UnityEngine.BuildCompression method, uint expectedCRC, UnityEngine.ThreadPriority priority)
- internal static UnityEngine.Object returnMainAsset(UnityEngine.AssetBundle bundle)
- public void Unload(bool unloadAllLoadedObjects)
- public static void UnloadAllAssetBundles(bool unloadAllObjects)
- public UnityEngine.AssetBundleUnloadOperation UnloadAsync(bool unloadAllLoadedObjects)
- internal static void ValidateLoadFromStream(System.IO.Stream stream)

### public class UnityEngine.AssetBundleCreateRequest
- Base: UnityEngine.AsyncOperation

#### Properties
- public UnityEngine.AssetBundle assetBundle { get; }

#### Constructors
- public AssetBundleCreateRequest()

#### Methods
- internal void DisableCompatibilityChecks()
- private void SetEnableCompatibilityChecks(bool set)

### internal static class UnityEngine.AssetBundleLoadingCache

#### Fields
- internal static const int kMinAllowedBlockCount
- internal static const int kMinAllowedMaxBlocksPerFile

#### Properties
- internal static uint blockCount { get; set; }
- internal static uint blockSize { get; }
- internal static uint maxBlocksPerFile { get; set; }
- internal static uint memoryBudgetKB { get; set; }

### public enum UnityEngine.AssetBundleLoadResult
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AlreadyLoaded = 7
- Cancelled = 1
- FailedCache = 3
- FailedDecompression = 9
- FailedDeleteRecompressionTarget = 11
- FailedRead = 8
- FailedWrite = 10
- NoSerializedData = 5
- NotCompatible = 6
- NotMatchingCrc = 2
- NotValidAssetBundle = 4
- RecompressionTargetExistsButNotArchive = 13
- RecompressionTargetIsLoaded = 12
- Success = 0

### public class UnityEngine.AssetBundleManifest
- Base: UnityEngine.Object

#### Constructors
- private AssetBundleManifest()

#### Methods
- public string[] GetAllAssetBundles()
- public string[] GetAllAssetBundlesWithVariant()
- public string[] GetAllDependencies(string assetBundleName)
- public UnityEngine.Hash128 GetAssetBundleHash(string assetBundleName)
- private void GetAssetBundleHash_Injected(string assetBundleName, out UnityEngine.Hash128 ret)
- public string[] GetDirectDependencies(string assetBundleName)

### public class UnityEngine.AssetBundleRecompressOperation
- Base: UnityEngine.AsyncOperation

#### Properties
- public string humanReadableResult { get; }
- public string inputPath { get; }
- public string outputPath { get; }
- public UnityEngine.AssetBundleLoadResult result { get; }
- public bool success { get; }

#### Constructors
- public AssetBundleRecompressOperation()

### public class UnityEngine.AssetBundleRequest
- Base: UnityEngine.ResourceRequest

#### Properties
- public UnityEngine.Object[] allAssets { get; }
- public UnityEngine.Object asset { get; }

#### Constructors
- public AssetBundleRequest()

#### Methods
- protected override UnityEngine.Object GetResult()

### public class UnityEngine.AssetBundleUnloadOperation
- Base: UnityEngine.AsyncOperation

#### Constructors
- public AssetBundleUnloadOperation()

#### Methods
- public void WaitForCompletion()

## Namespace: UnityEngine.Experimental.AssetBundlePatching

### public static class UnityEngine.Experimental.AssetBundlePatching.AssetBundleUtility

#### Methods
- public static void PatchAssetBundles(UnityEngine.AssetBundle[] bundles, string[] filenames)

