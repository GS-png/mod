# Assembly: UnityEngine.ScreenCaptureModule
- Path: tools/WorldBox.Managed/UnityEngine.ScreenCaptureModule.dll
- Types: 2

## Namespace: UnityEngine

### public static class UnityEngine.ScreenCapture

#### Methods
- public static void CaptureScreenshot(string filename)
- public static void CaptureScreenshot(string filename, int superSize)
- public static void CaptureScreenshot(string filename, UnityEngine.ScreenCapture.StereoScreenCaptureMode stereoCaptureMode)
- private static void CaptureScreenshot(string filename, int superSize, UnityEngine.ScreenCapture.StereoScreenCaptureMode CaptureMode)
- public static UnityEngine.Texture2D CaptureScreenshotAsTexture()
- public static UnityEngine.Texture2D CaptureScreenshotAsTexture(int superSize)
- public static UnityEngine.Texture2D CaptureScreenshotAsTexture(UnityEngine.ScreenCapture.StereoScreenCaptureMode stereoCaptureMode)
- private static UnityEngine.Texture2D CaptureScreenshotAsTexture(int superSize, UnityEngine.ScreenCapture.StereoScreenCaptureMode stereoScreenCaptureMode)
- public static void CaptureScreenshotIntoRenderTexture(UnityEngine.RenderTexture renderTexture)

### public enum UnityEngine.ScreenCapture.StereoScreenCaptureMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BothEyes = 3
- LeftEye = 1
- RightEye = 2

