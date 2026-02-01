# Assembly: UnityEngine.ImageConversionModule
- Path: tools/WorldBox.Managed/UnityEngine.ImageConversionModule.dll
- Types: 1

## Namespace: UnityEngine

### public static class UnityEngine.ImageConversion

#### Properties
- public static bool EnableLegacyPngGammaRuntimeLoadBehavior { get; set; }

#### Methods
- public static byte[] EncodeArrayToEXR(System.Array array, UnityEngine.Experimental.Rendering.GraphicsFormat format, uint width, uint height, uint rowBytes = 0, UnityEngine.Texture2D.EXRFlags flags = None)
- public static byte[] EncodeArrayToJPG(System.Array array, UnityEngine.Experimental.Rendering.GraphicsFormat format, uint width, uint height, uint rowBytes = 0, int quality = 75)
- public static byte[] EncodeArrayToPNG(System.Array array, UnityEngine.Experimental.Rendering.GraphicsFormat format, uint width, uint height, uint rowBytes = 0)
- public static byte[] EncodeArrayToTGA(System.Array array, UnityEngine.Experimental.Rendering.GraphicsFormat format, uint width, uint height, uint rowBytes = 0)
- public static Unity.Collections.NativeArray<byte> EncodeNativeArrayToEXR<T>(Unity.Collections.NativeArray<T> input, UnityEngine.Experimental.Rendering.GraphicsFormat format, uint width, uint height, uint rowBytes = 0, UnityEngine.Texture2D.EXRFlags flags = None)
- public static Unity.Collections.NativeArray<byte> EncodeNativeArrayToJPG<T>(Unity.Collections.NativeArray<T> input, UnityEngine.Experimental.Rendering.GraphicsFormat format, uint width, uint height, uint rowBytes = 0, int quality = 75)
- public static Unity.Collections.NativeArray<byte> EncodeNativeArrayToPNG<T>(Unity.Collections.NativeArray<T> input, UnityEngine.Experimental.Rendering.GraphicsFormat format, uint width, uint height, uint rowBytes = 0)
- public static Unity.Collections.NativeArray<byte> EncodeNativeArrayToTGA<T>(Unity.Collections.NativeArray<T> input, UnityEngine.Experimental.Rendering.GraphicsFormat format, uint width, uint height, uint rowBytes = 0)
- public static byte[] EncodeToEXR(UnityEngine.Texture2D tex, UnityEngine.Texture2D.EXRFlags flags)
- public static byte[] EncodeToEXR(UnityEngine.Texture2D tex)
- public static byte[] EncodeToJPG(UnityEngine.Texture2D tex, int quality)
- public static byte[] EncodeToJPG(UnityEngine.Texture2D tex)
- public static byte[] EncodeToPNG(UnityEngine.Texture2D tex)
- public static byte[] EncodeToTGA(UnityEngine.Texture2D tex)
- private static bool GetEnableLegacyPngGammaRuntimeLoadBehavior()
- public static bool LoadImage(UnityEngine.Texture2D tex, byte[] data, bool markNonReadable)
- public static bool LoadImage(UnityEngine.Texture2D tex, byte[] data)
- private static void SetEnableLegacyPngGammaRuntimeLoadBehavior(bool enable)
- private static void* UnsafeEncodeNativeArrayToEXR(void* array, ref int sizeInBytes, UnityEngine.Experimental.Rendering.GraphicsFormat format, uint width, uint height, uint rowBytes = 0, UnityEngine.Texture2D.EXRFlags flags = None)
- private static void* UnsafeEncodeNativeArrayToJPG(void* array, ref int sizeInBytes, UnityEngine.Experimental.Rendering.GraphicsFormat format, uint width, uint height, uint rowBytes = 0, int quality = 75)
- private static void* UnsafeEncodeNativeArrayToPNG(void* array, ref int sizeInBytes, UnityEngine.Experimental.Rendering.GraphicsFormat format, uint width, uint height, uint rowBytes = 0)
- private static void* UnsafeEncodeNativeArrayToTGA(void* array, ref int sizeInBytes, UnityEngine.Experimental.Rendering.GraphicsFormat format, uint width, uint height, uint rowBytes = 0)

