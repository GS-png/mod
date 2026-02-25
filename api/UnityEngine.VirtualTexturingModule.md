# Assembly: UnityEngine.VirtualTexturingModule
- Path: tools/WorldBox.Managed/UnityEngine.VirtualTexturingModule.dll
- Types: 26

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 BF8B1BB84B6FB3C983D21ED84FADE89DCC6FDB7C91DE320DE34AB9ABE24493FC
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=88 C46F0FCA118FE72C10BF852A830B34A1639A8D2308DB41CA204DB0CB19AA3E4E

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=88

## Namespace: UnityEngine.Rendering.VirtualTexturing

### internal static class UnityEngine.Rendering.VirtualTexturing.Procedural.Binding

#### Methods
- internal static void BindGlobally(ulong handle, string name)
- internal static void BindToMaterial(ulong handle, UnityEngine.Material material, string name)
- internal static void BindToMaterialPropertyBlock(ulong handle, UnityEngine.MaterialPropertyBlock material, string name)
- internal static ulong Create(UnityEngine.Rendering.VirtualTexturing.Procedural.CreationParameters p)
- private static ulong Create_Injected(ref UnityEngine.Rendering.VirtualTexturing.Procedural.CreationParameters p)
- internal static void Destroy(ulong handle)
- public static void EvictRegion(ulong handle, UnityEngine.Rect r, int mipMap, int numMips)
- private static void EvictRegion_Injected(ulong handle, ref UnityEngine.Rect r, int mipMap, int numMips)
- internal static void GetRequestParameters(System.IntPtr requestHandles, System.IntPtr requestParameters, int length)
- internal static void InvalidateRegion(ulong handle, UnityEngine.Rect r, int mipMap, int numMips)
- private static void InvalidateRegion_Injected(ulong handle, ref UnityEngine.Rect r, int mipMap, int numMips)
- internal static int PopRequests(ulong handle, System.IntPtr requestHandles, int length)
- internal static void RequestRegion(ulong handle, UnityEngine.Rect r, int mipMap, int numMips)
- private static void RequestRegion_Injected(ulong handle, ref UnityEngine.Rect r, int mipMap, int numMips)
- internal static void UpdateRequestState(System.IntPtr requestHandles, System.IntPtr requestUpdates, int length)
- internal static void UpdateRequestStateWithCommandBuffer(System.IntPtr requestHandles, System.IntPtr requestUpdates, int length, UnityEngine.Rendering.CommandBuffer fenceBuffer)

### public class UnityEngine.Rendering.VirtualTexturing.Procedural.CPUTextureStack
- Base: UnityEngine.Rendering.VirtualTexturing.Procedural.TextureStackBase<UnityEngine.Rendering.VirtualTexturing.Procedural.CPUTextureStackRequestParameters>
- Interfaces: System.IDisposable

#### Constructors
- public Procedural.CPUTextureStack(string _name, UnityEngine.Rendering.VirtualTexturing.Procedural.CreationParameters creationParams)

### public struct UnityEngine.Rendering.VirtualTexturing.Procedural.CPUTextureStackRequestLayerParameters

#### Fields
- internal void* data
- internal int dataSize
- internal void* mipData
- internal int mipDataSize
- internal int _mipScanlineSize
- internal int _scanlineSize

#### Properties
- public int mipScanlineSize { get; }
- public bool requiresCachedMip { get; }
- public int scanlineSize { get; }

#### Methods
- public Unity.Collections.NativeArray<T> GetData<T>()
- public Unity.Collections.NativeArray<T> GetMipData<T>()

### public struct UnityEngine.Rendering.VirtualTexturing.Procedural.CPUTextureStackRequestParameters

#### Fields
- public int height
- private UnityEngine.Rendering.VirtualTexturing.Procedural.CPUTextureStackRequestLayerParameters layer0
- private UnityEngine.Rendering.VirtualTexturing.Procedural.CPUTextureStackRequestLayerParameters layer1
- private UnityEngine.Rendering.VirtualTexturing.Procedural.CPUTextureStackRequestLayerParameters layer2
- private UnityEngine.Rendering.VirtualTexturing.Procedural.CPUTextureStackRequestLayerParameters layer3
- public int level
- public int numLayers
- public int width
- public int x
- public int y

#### Methods
- public UnityEngine.Rendering.VirtualTexturing.Procedural.CPUTextureStackRequestLayerParameters GetLayer(int index)

### public struct UnityEngine.Rendering.VirtualTexturing.Procedural.CreationParameters

#### Fields
- internal int borderSize
- public UnityEngine.Rendering.VirtualTexturing.FilterMode filterMode
- internal int flags
- internal int gpuGeneration
- public int height
- public UnityEngine.Experimental.Rendering.GraphicsFormat[] layers
- public int maxActiveRequests
- public static const int MaxNumLayers
- public static const int MaxRequestsPerFrameSupported
- public int tilesize
- public int width

#### Methods
- internal void Validate()

### public static class UnityEngine.Rendering.VirtualTexturing.Debugging

#### Properties
- public static bool debugTilesEnabled { get; set; }
- public static bool flushEveryTickEnabled { get; set; }
- public static int mipPreloadedTextureCount { get; }
- public static bool resolvingEnabled { get; set; }

#### Methods
- public static string GetInfoDump()
- public static int GetNumHandles()
- public static void GrabHandleInfo(out UnityEngine.Rendering.VirtualTexturing.Debugging.Handle debugHandle, int index)

### public static class UnityEngine.Rendering.VirtualTexturing.EditorHelpers

#### Properties
- internal static int tileSize { get; }

#### Methods
- public static UnityEngine.Experimental.Rendering.GraphicsFormat[] QuerySupportedFormats()
- internal static UnityEngine.Rendering.VirtualTexturing.EditorHelpers.StackValidationResult[] ValidateMaterialTextureStacks(UnityEngine.Material mat)
- public static bool ValidateTextureStack(UnityEngine.Texture[] textures, out string errorMessage)

### public enum UnityEngine.Rendering.VirtualTexturing.FilterMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Bilinear = 1
- Trilinear = 2

### public struct UnityEngine.Rendering.VirtualTexturing.GPUCacheSetting

#### Fields
- public UnityEngine.Experimental.Rendering.GraphicsFormat format
- public uint sizeInMegaBytes

### public class UnityEngine.Rendering.VirtualTexturing.Procedural.GPUTextureStack
- Base: UnityEngine.Rendering.VirtualTexturing.Procedural.TextureStackBase<UnityEngine.Rendering.VirtualTexturing.Procedural.GPUTextureStackRequestParameters>
- Interfaces: System.IDisposable

#### Constructors
- public Procedural.GPUTextureStack(string _name, UnityEngine.Rendering.VirtualTexturing.Procedural.CreationParameters creationParams)

### public struct UnityEngine.Rendering.VirtualTexturing.Procedural.GPUTextureStackRequestLayerParameters

#### Fields
- public UnityEngine.Rendering.RenderTargetIdentifier dest
- public int destX
- public int destY

#### Methods
- public int GetHeight()
- private static int GetHeight_Injected(ref UnityEngine.Rendering.VirtualTexturing.Procedural.GPUTextureStackRequestLayerParameters _unity_self)
- public int GetWidth()
- private static int GetWidth_Injected(ref UnityEngine.Rendering.VirtualTexturing.Procedural.GPUTextureStackRequestLayerParameters _unity_self)

### public struct UnityEngine.Rendering.VirtualTexturing.Procedural.GPUTextureStackRequestParameters

#### Fields
- public int height
- private UnityEngine.Rendering.VirtualTexturing.Procedural.GPUTextureStackRequestLayerParameters layer0
- private UnityEngine.Rendering.VirtualTexturing.Procedural.GPUTextureStackRequestLayerParameters layer1
- private UnityEngine.Rendering.VirtualTexturing.Procedural.GPUTextureStackRequestLayerParameters layer2
- private UnityEngine.Rendering.VirtualTexturing.Procedural.GPUTextureStackRequestLayerParameters layer3
- public int level
- public int numLayers
- public int width
- public int x
- public int y

#### Methods
- public UnityEngine.Rendering.VirtualTexturing.Procedural.GPUTextureStackRequestLayerParameters GetLayer(int index)

### public struct UnityEngine.Rendering.VirtualTexturing.Debugging.Handle

#### Fields
- public string group
- public long handle
- public UnityEngine.Material material
- public string name
- public int numLayers

### public static class UnityEngine.Rendering.VirtualTexturing.Procedural

#### Methods
- public static int GetCPUCacheSize()
- public static UnityEngine.Rendering.VirtualTexturing.GPUCacheSetting[] GetGPUCacheSettings()
- public static uint GetGPUCacheStagingAreaCapacity()
- public static void SetCPUCacheSize(int sizeInMegabytes)
- public static void SetDebugFlagDouble(System.Guid guid, double value)
- public static void SetDebugFlagInteger(System.Guid guid, long value)
- public static void SetGPUCacheSettings(UnityEngine.Rendering.VirtualTexturing.GPUCacheSetting[] cacheSettings)
- public static void SetGPUCacheStagingAreaCapacity(uint tilesPerFrame)

### internal enum UnityEngine.Rendering.VirtualTexturing.Procedural.ProceduralTextureStackRequestStatus
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- StatusComplete = 65538
- StatusDropped = 65539
- StatusFree = 65535
- StatusProcessing = 65537
- StatusRequested = 65536

### internal struct UnityEngine.Rendering.VirtualTexturing.Procedural.RequestHandlePayload
- Interfaces: System.IEquatable<UnityEngine.Rendering.VirtualTexturing.Procedural.RequestHandlePayload>

#### Fields
- internal System.IntPtr callback
- internal int id
- internal int lifetime

#### Methods
- public override bool Equals(object obj)
- public bool Equals(UnityEngine.Rendering.VirtualTexturing.Procedural.RequestHandlePayload other)
- public override int GetHashCode()
- public static bool op_Equality(UnityEngine.Rendering.VirtualTexturing.Procedural.RequestHandlePayload lhs, UnityEngine.Rendering.VirtualTexturing.Procedural.RequestHandlePayload rhs)
- public static bool op_Inequality(UnityEngine.Rendering.VirtualTexturing.Procedural.RequestHandlePayload lhs, UnityEngine.Rendering.VirtualTexturing.Procedural.RequestHandlePayload rhs)

### public enum UnityEngine.Rendering.VirtualTexturing.Procedural.RequestStatus
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Dropped = 65539
- Generated = 65538

### public class UnityEngine.Rendering.VirtualTexturing.Resolver
- Interfaces: System.IDisposable

#### Fields
- private int <CurrentHeight>k__BackingField
- private int <CurrentWidth>k__BackingField
- internal System.IntPtr m_Ptr

#### Properties
- public int CurrentHeight { get; private set; }
- public int CurrentWidth { get; private set; }

#### Constructors
- public Resolver()

#### Methods
- public void Dispose()
- protected virtual void Dispose(bool disposing)
- protected override void Finalize()
- private void Flush_Internal()
- private static System.IntPtr InitNative()
- private void Init_Internal(int width, int height)
- public void Process(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier rt)
- public void Process(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier rt, int x, int width, int y, int height, int mip, int slice)
- private static void ReleaseNative(System.IntPtr ptr)
- public void UpdateSize(int width, int height)

### internal struct UnityEngine.Rendering.VirtualTexturing.EditorHelpers.StackValidationResult

#### Fields
- public string errorMessage
- public string stackName

### public static class UnityEngine.Rendering.VirtualTexturing.Streaming

#### Methods
- public static void EnableMipPreloading(int texturesPerFrame, int mipCount)
- public static int GetCPUCacheSize()
- public static UnityEngine.Rendering.VirtualTexturing.GPUCacheSetting[] GetGPUCacheSettings()
- public static void GetTextureStackSize(UnityEngine.Material mat, int stackNameId, out int width, out int height)
- public static void RequestRegion(UnityEngine.Material mat, int stackNameId, UnityEngine.Rect r, int mipMap, int numMips)
- private static void RequestRegion_Injected(UnityEngine.Material mat, int stackNameId, ref UnityEngine.Rect r, int mipMap, int numMips)
- public static void SetCPUCacheSize(int sizeInMegabytes)
- public static void SetGPUCacheSettings(UnityEngine.Rendering.VirtualTexturing.GPUCacheSetting[] cacheSettings)

### public static class UnityEngine.Rendering.VirtualTexturing.System

#### Fields
- public static const int AllMips

#### Properties
- internal static bool enabled { get; }

#### Methods
- internal static void SetDebugFlag(System.Guid guid, bool enabled)
- internal static void SetDebugFlagDouble(System.Guid guid, double value)
- private static void SetDebugFlagDouble(byte[] guid, double value)
- internal static void SetDebugFlagInteger(System.Guid guid, long value)
- private static void SetDebugFlagInteger(byte[] guid, long value)
- public static void Update()

### public class UnityEngine.Rendering.VirtualTexturing.Procedural.TextureStackBase<T>
- Interfaces: System.IDisposable

#### Fields
- public static const int AllMips
- public static readonly int borderSize
- private UnityEngine.Rendering.VirtualTexturing.Procedural.CreationParameters creationParams
- internal ulong handle
- private string name

#### Constructors
- private static Procedural.TextureStackBase<T>()
- public Procedural.TextureStackBase<T>(string _name, UnityEngine.Rendering.VirtualTexturing.Procedural.CreationParameters _creationParams, bool gpuGeneration)

#### Methods
- public void BindGlobally()
- public void BindToMaterial(UnityEngine.Material mat)
- public void BindToMaterialPropertyBlock(UnityEngine.MaterialPropertyBlock mpb)
- public void Dispose()
- public void EvictRegion(UnityEngine.Rect r, int mipMap, int numMips)
- public void InvalidateRegion(UnityEngine.Rect r, int mipMap, int numMips)
- public bool IsValid()
- public int PopRequests(Unity.Collections.NativeSlice<UnityEngine.Rendering.VirtualTexturing.Procedural.TextureStackRequestHandle<T>> requestHandles)
- public void RequestRegion(UnityEngine.Rect r, int mipMap, int numMips)

### public struct UnityEngine.Rendering.VirtualTexturing.Procedural.TextureStackRequestHandle<T>
- Interfaces: System.IEquatable<UnityEngine.Rendering.VirtualTexturing.Procedural.TextureStackRequestHandle<T>>

#### Fields
- internal UnityEngine.Rendering.VirtualTexturing.Procedural.RequestHandlePayload payload

#### Methods
- public void CompleteRequest(UnityEngine.Rendering.VirtualTexturing.Procedural.RequestStatus status)
- public void CompleteRequest(UnityEngine.Rendering.VirtualTexturing.Procedural.RequestStatus status, UnityEngine.Rendering.CommandBuffer fenceBuffer)
- public static void CompleteRequests(Unity.Collections.NativeSlice<UnityEngine.Rendering.VirtualTexturing.Procedural.TextureStackRequestHandle<T>> requestHandles, Unity.Collections.NativeSlice<UnityEngine.Rendering.VirtualTexturing.Procedural.RequestStatus> status)
- public static void CompleteRequests(Unity.Collections.NativeSlice<UnityEngine.Rendering.VirtualTexturing.Procedural.TextureStackRequestHandle<T>> requestHandles, Unity.Collections.NativeSlice<UnityEngine.Rendering.VirtualTexturing.Procedural.RequestStatus> status, UnityEngine.Rendering.CommandBuffer fenceBuffer)
- public override bool Equals(object obj)
- public bool Equals(UnityEngine.Rendering.VirtualTexturing.Procedural.TextureStackRequestHandle<T> other)
- public override int GetHashCode()
- public T GetRequestParameters()
- public static void GetRequestParameters(Unity.Collections.NativeSlice<UnityEngine.Rendering.VirtualTexturing.Procedural.TextureStackRequestHandle<T>> handles, Unity.Collections.NativeSlice<T> requests)
- public static bool op_Equality(UnityEngine.Rendering.VirtualTexturing.Procedural.TextureStackRequestHandle<T> h1, UnityEngine.Rendering.VirtualTexturing.Procedural.TextureStackRequestHandle<T> h2)
- public static bool op_Inequality(UnityEngine.Rendering.VirtualTexturing.Procedural.TextureStackRequestHandle<T> h1, UnityEngine.Rendering.VirtualTexturing.Procedural.TextureStackRequestHandle<T> h2)

