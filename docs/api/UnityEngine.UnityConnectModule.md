# Assembly: UnityEngine.UnityConnectModule
- Path: tools/WorldBox.Managed/UnityEngine.UnityConnectModule.dll
- Types: 2

## Namespace: UnityEngine.Advertisements

### internal static class UnityEngine.Advertisements.UnityAdsSettings

#### Properties
- public static bool enabled { get; set; }
- public static bool initializeOnStartup { get; set; }
- public static bool testMode { get; set; }

#### Methods
- public static string GetGameId(UnityEngine.RuntimePlatform platform)
- public static bool IsPlatformEnabled(UnityEngine.RuntimePlatform platform)
- public static void SetGameId(UnityEngine.RuntimePlatform platform, string gameId)
- public static void SetPlatformEnabled(UnityEngine.RuntimePlatform platform, bool value)

## Namespace: UnityEngine.Connect

### internal class UnityEngine.Connect.UnityConnectSettings
- Base: UnityEngine.Object

#### Properties
- public static string configUrl { get; set; }
- public static bool enabled { get; set; }
- public static string eventOldUrl { get; set; }
- public static string eventUrl { get; set; }
- public static int testInitMode { get; set; }
- public static bool testMode { get; set; }

#### Constructors
- public UnityConnectSettings()

