# Assembly: FMODUnityResonance
- Path: tools/WorldBox.Managed/FMODUnityResonance.dll
- Types: 9

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=164 0481731F33E7E9F59E03DC3894D8BAE5CA4EA3E2285CBF6FBF2ADE2958851835
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=145 68BCACD21844545E141B28CAF2194A274C4DCC63A4DFC610F7C5D97ECC2F7584

### private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData

#### Fields
- public byte[] FilePathsData
- public bool IsEditorOnly
- public int TotalFiles
- public int TotalTypes
- public byte[] TypesData

### internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1

#### Constructors
- public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()

#### Methods
- private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=145

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=164

## Namespace: FMODUnityResonance

### public static class FMODUnityResonance.FmodResonanceAudio

#### Fields
- private static UnityEngine.Bounds bounds
- private static System.Collections.Generic.List<FMODUnityResonance.FmodResonanceAudioRoom> enabledRooms
- private static readonly UnityEngine.Matrix4x4 flipZ
- private static FMOD.DSP listenerPlugin
- private static readonly string listenerPluginName
- private static FMOD.VECTOR listenerPositionFmod
- public static const float MaxGainDb
- public static const float MaxReflectivity
- public static const float MaxReverbBrightness
- public static const float MaxReverbTime
- public static const float MinGainDb
- public static const float MinReverbBrightness
- private static readonly int roomPropertiesIndex
- private static readonly int roomPropertiesSize

#### Properties
- private static FMOD.DSP ListenerPlugin { get; }

#### Constructors
- private static FmodResonanceAudio()

#### Methods
- private static float ConvertAmplitudeFromDb(float db)
- private static void ConvertAudioTransformFromUnity(ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation)
- private static byte[] GetBytes(System.IntPtr ptr, int length)
- private static FMODUnityResonance.FmodResonanceAudio.RoomProperties GetRoomProperties(FMODUnityResonance.FmodResonanceAudioRoom room)
- private static FMOD.DSP Initialize()
- public static bool IsListenerInsideRoom(FMODUnityResonance.FmodResonanceAudioRoom room)
- public static void UpdateAudioRoom(FMODUnityResonance.FmodResonanceAudioRoom room, bool roomEnabled)

### public class FMODUnityResonance.FmodResonanceAudioRoom
- Base: UnityEngine.MonoBehaviour

#### Fields
- public FMODUnityResonance.FmodResonanceAudioRoom.SurfaceMaterial BackWall
- public FMODUnityResonance.FmodResonanceAudioRoom.SurfaceMaterial Ceiling
- public FMODUnityResonance.FmodResonanceAudioRoom.SurfaceMaterial Floor
- public FMODUnityResonance.FmodResonanceAudioRoom.SurfaceMaterial FrontWall
- public FMODUnityResonance.FmodResonanceAudioRoom.SurfaceMaterial LeftWall
- public float Reflectivity
- public float ReverbBrightness
- public float ReverbGainDb
- public float ReverbTime
- public FMODUnityResonance.FmodResonanceAudioRoom.SurfaceMaterial RightWall
- public UnityEngine.Vector3 Size

#### Constructors
- public FmodResonanceAudioRoom()

#### Methods
- private void OnDisable()
- private void OnDrawGizmosSelected()
- private void OnEnable()
- private void Update()

### private struct FMODUnityResonance.FmodResonanceAudio.RoomProperties

#### Fields
- public float DimensionsX
- public float DimensionsY
- public float DimensionsZ
- public FMODUnityResonance.FmodResonanceAudioRoom.SurfaceMaterial MaterialBack
- public FMODUnityResonance.FmodResonanceAudioRoom.SurfaceMaterial MaterialBottom
- public FMODUnityResonance.FmodResonanceAudioRoom.SurfaceMaterial MaterialFront
- public FMODUnityResonance.FmodResonanceAudioRoom.SurfaceMaterial MaterialLeft
- public FMODUnityResonance.FmodResonanceAudioRoom.SurfaceMaterial MaterialRight
- public FMODUnityResonance.FmodResonanceAudioRoom.SurfaceMaterial MaterialTop
- public float PositionX
- public float PositionY
- public float PositionZ
- public float ReflectionScalar
- public float ReverbBrightness
- public float ReverbGain
- public float ReverbTime
- public float RotationW
- public float RotationX
- public float RotationY
- public float RotationZ

### public enum FMODUnityResonance.FmodResonanceAudioRoom.SurfaceMaterial
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AcousticCeilingTiles = 1
- BrickBare = 2
- BrickPainted = 3
- ConcreteBlockCoarse = 4
- ConcreteBlockPainted = 5
- CurtainHeavy = 6
- FiberglassInsulation = 7
- GlassThick = 9
- GlassThin = 8
- Grass = 10
- LinoleumOnConcrete = 11
- Marble = 12
- Metal = 13
- ParquetOnConcrete = 14
- PlasterRough = 15
- PlasterSmooth = 16
- PlywoodPanel = 17
- PolishedConcreteOrTile = 18
- Sheetrock = 19
- Transparent = 0
- WaterOrIceSurface = 20
- WoodCeiling = 21
- WoodPanel = 22

