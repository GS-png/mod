# Assembly: UnityEngine.AccessibilityModule
- Path: tools/WorldBox.Managed/UnityEngine.AccessibilityModule.dll
- Types: 3

## Namespace: UnityEngine.Accessibility

### private class UnityEngine.Accessibility.VisionUtility.<>c

#### Fields
- public static readonly UnityEngine.Accessibility.VisionUtility.<>c <>9
- public static System.Func<int, UnityEngine.Color> <>9__6_1

#### Constructors
- private static VisionUtility.<>c()
- public VisionUtility.<>c()

#### Methods
- internal float <.cctor>b__7_0(UnityEngine.Color c)
- internal UnityEngine.Color <GetColorBlindSafePaletteInternal>b__6_1(int i)

### private class UnityEngine.Accessibility.VisionUtility.<>c__DisplayClass6_0

#### Fields
- public float maximumLuminance
- public float minimumLuminance

#### Constructors
- public VisionUtility.<>c__DisplayClass6_0()

#### Methods
- internal bool <GetColorBlindSafePaletteInternal>b__0(int i)

### public static class UnityEngine.Accessibility.VisionUtility

#### Fields
- private static readonly UnityEngine.Color[] s_ColorBlindSafePalette
- private static readonly float[] s_ColorBlindSafePaletteLuminanceValues

#### Constructors
- private static VisionUtility()

#### Methods
- internal static float ComputePerceivedLuminance(UnityEngine.Color color)
- public static int GetColorBlindSafePalette(UnityEngine.Color[] palette, float minimumLuminance, float maximumLuminance)
- internal static int GetColorBlindSafePalette(UnityEngine.Color32[] palette, float minimumLuminance, float maximumLuminance)
- private static int GetColorBlindSafePaletteInternal(void* palette, int paletteLength, float minimumLuminance, float maximumLuminance, bool useColor32)
- internal static void GetLuminanceValuesForPalette(UnityEngine.Color[] palette, ref float[] outLuminanceValues)

