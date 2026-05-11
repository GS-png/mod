# Assembly: Assembly-CSharp-firstpass
- Path: tools/WorldBox.Managed/Assembly-CSharp-firstpass.dll
- Types: 474

## Namespace: (global)

### private class GameManager.<>c__DisplayClass13_0

#### Fields
- public GameManager <>4__this
- public System.Collections.Generic.List<string> productIds

#### Constructors
- public GameManager.<>c__DisplayClass13_0()

#### Methods
- internal void <InitUI>b__0()
- internal void <InitUI>b__1()
- internal void <InitUI>b__2()
- internal void <InitUI>b__3()
- internal void <InitUI>b__4()

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3494 155826C881D57DF237E64137BE16416DB42B65ECEE86994E970C7CDEBDAF66F5
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 79A23603D3CE783C42F8D58E64DA7C09FC11EBABB6360CBB23A346630C9E208D
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1256 96A43D5F40C4A5780B6B7A3730637B760054A05A90808FD14C69A7030B1421F6
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 F09E7E5ABCD1EB0B0C296F5AE19B4CB6506C19012EA1A8B11BF90BC36CF13BD3

#### Methods
- internal static uint ComputeStringHash(string s)

### private class iTween.<Start>d__228
- Interfaces: System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- public iTween <>4__this

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public iTween.<Start>d__228(int <>1__state)

#### Methods
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class iTween.<TweenDelay>d__144
- Interfaces: System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- public iTween <>4__this

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public iTween.<TweenDelay>d__144(int <>1__state)

#### Methods
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class iTween.<TweenRestart>d__146
- Interfaces: System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- public iTween <>4__this

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public iTween.<TweenRestart>d__146(int <>1__state)

#### Methods
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private delegate iTween.ApplyTween
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public iTween.ApplyTween(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke()

### private class iTween.CRSpline

#### Fields
- public UnityEngine.Vector3[] pts

#### Constructors
- public iTween.CRSpline(params UnityEngine.Vector3[] pts)

#### Methods
- public UnityEngine.Vector3 Interp(float t)

### public static class iTween.Defaults

#### Fields
- public static UnityEngine.Color color
- public static float delay
- public static iTween.EaseType easeType
- public static bool isLocal
- public static float lookAhead
- public static float lookSpeed
- public static iTween.LoopType loopType
- public static iTween.NamedValueColor namedColorValue
- public static bool orientToPath
- public static UnityEngine.Space space
- public static float time
- public static UnityEngine.Vector3 up
- public static float updateTime
- public static float updateTimePercentage
- public static bool useRealTime

#### Constructors
- private static iTween.Defaults()

### public enum iTween.EaseType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- easeInBack = 26
- easeInBounce = 23
- easeInCirc = 18
- easeInCubic = 3
- easeInElastic = 29
- easeInExpo = 15
- easeInOutBack = 28
- easeInOutBounce = 25
- easeInOutCirc = 20
- easeInOutCubic = 5
- easeInOutElastic = 31
- easeInOutExpo = 17
- easeInOutQuad = 2
- easeInOutQuart = 8
- easeInOutQuint = 11
- easeInOutSine = 14
- easeInQuad = 0
- easeInQuart = 6
- easeInQuint = 9
- easeInSine = 12
- easeOutBack = 27
- easeOutBounce = 24
- easeOutCirc = 19
- easeOutCubic = 4
- easeOutElastic = 30
- easeOutExpo = 16
- easeOutQuad = 1
- easeOutQuart = 7
- easeOutQuint = 10
- easeOutSine = 13
- linear = 21
- punch = 32
- spring = 22

### public delegate EasingFunction
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public EasingFunction(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(float start, float end, float Value, System.AsyncCallback callback, object object)
- public virtual float EndInvoke(System.IAsyncResult result)
- public virtual float Invoke(float start, float end, float Value)

### public class GameManager
- Base: UnityEngine.MonoBehaviour

#### Fields
- private UnityEngine.UDP.AppInfo appInfo
- private GameManager.InitListener initListener
- private static bool m_consumeOnPurchase
- private System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> options
- public string Product1
- public string Product2
- private GameManager.PurchaseListener purchaseListener
- private static bool _consumeOnQuery
- private UnityEngine.UI.Dropdown _dropdown
- private static bool _initialized
- private static UnityEngine.UI.Text _textField

#### Constructors
- public GameManager()

#### Methods
- private UnityEngine.UI.Button GetButton(string buttonName)
- private void InitUI()
- private static void Show(string message, bool append = false)
- private void Start()

### public class GameManager.InitListener
- Interfaces: UnityEngine.UDP.IInitListener

#### Constructors
- public GameManager.InitListener()

#### Methods
- public void OnInitialized(UnityEngine.UDP.UserInfo userInfo)
- public void OnInitializeFailed(string message)

### public class iTween
- Base: UnityEngine.MonoBehaviour

#### Fields
- private iTween.ApplyTween apply
- private UnityEngine.AudioSource audioSource
- private UnityEngine.Color[,] colors
- public float delay
- private float delayStarted
- private EasingFunction ease
- public iTween.EaseType easeType
- private float[] floats
- public string id
- private bool isLocal
- public bool isPaused
- public bool isRunning
- private bool kinematic
- private float lastRealTime
- private bool loop
- public iTween.LoopType loopType
- public string method
- private iTween.NamedValueColor namedcolorvalue
- private iTween.CRSpline path
- private float percentage
- private bool physics
- private UnityEngine.Vector3 postUpdate
- private UnityEngine.Vector3 preUpdate
- private UnityEngine.Rect[] rects
- private bool reverse
- private float runningTime
- private UnityEngine.Space space
- private UnityEngine.Transform thisTransform
- public float time
- private System.Collections.Hashtable tweenArguments
- public static System.Collections.Generic.List<System.Collections.Hashtable> tweens
- public string type
- private bool useRealTime
- private UnityEngine.Vector2[] vector2s
- private UnityEngine.Vector3[] vector3s
- private bool wasPaused
- public string _name

#### Constructors
- private static iTween()
- private iTween(System.Collections.Hashtable h)

#### Methods
- private void ApplyAudioToTargets()
- private void ApplyColorTargets()
- private void ApplyColorToTargets()
- private void ApplyFloatTargets()
- private void ApplyLookToTargets()
- private void ApplyMoveByTargets()
- private void ApplyMoveToPathTargets()
- private void ApplyMoveToTargets()
- private void ApplyPunchPositionTargets()
- private void ApplyPunchRotationTargets()
- private void ApplyPunchScaleTargets()
- private void ApplyRectTargets()
- private void ApplyRotateAddTargets()
- private void ApplyRotateToTargets()
- private void ApplyScaleToTargets()
- private void ApplyShakePositionTargets()
- private void ApplyShakeRotationTargets()
- private void ApplyShakeScaleTargets()
- private void ApplyStabTargets()
- private void ApplyVector2Targets()
- private void ApplyVector3Targets()
- public static void AudioFrom(UnityEngine.GameObject target, float volume, float pitch, float time)
- public static void AudioFrom(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void AudioTo(UnityEngine.GameObject target, float volume, float pitch, float time)
- public static void AudioTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void AudioUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void AudioUpdate(UnityEngine.GameObject target, float volume, float pitch, float time)
- private void Awake()
- private void CallBack(string callbackType)
- private static System.Collections.Hashtable CleanArgs(System.Collections.Hashtable args)
- private float clerp(float start, float end, float value)
- public static void ColorFrom(UnityEngine.GameObject target, UnityEngine.Color color, float time)
- public static void ColorFrom(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void ColorTo(UnityEngine.GameObject target, UnityEngine.Color color, float time)
- public static void ColorTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void ColorUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void ColorUpdate(UnityEngine.GameObject target, UnityEngine.Color color, float time)
- private void ConflictCheck()
- public static int Count()
- public static int Count(string type)
- public static int Count(UnityEngine.GameObject target)
- public static int Count(UnityEngine.GameObject target, string type)
- private void DisableKinematic()
- private void Dispose()
- public static void DrawLine(UnityEngine.Vector3[] line)
- public static void DrawLine(UnityEngine.Vector3[] line, UnityEngine.Color color)
- public static void DrawLine(UnityEngine.Transform[] line)
- public static void DrawLine(UnityEngine.Transform[] line, UnityEngine.Color color)
- public static void DrawLineGizmos(UnityEngine.Vector3[] line)
- public static void DrawLineGizmos(UnityEngine.Vector3[] line, UnityEngine.Color color)
- public static void DrawLineGizmos(UnityEngine.Transform[] line)
- public static void DrawLineGizmos(UnityEngine.Transform[] line, UnityEngine.Color color)
- public static void DrawLineHandles(UnityEngine.Vector3[] line)
- public static void DrawLineHandles(UnityEngine.Vector3[] line, UnityEngine.Color color)
- public static void DrawLineHandles(UnityEngine.Transform[] line)
- public static void DrawLineHandles(UnityEngine.Transform[] line, UnityEngine.Color color)
- private static void DrawLineHelper(UnityEngine.Vector3[] line, UnityEngine.Color color, string method)
- public static void DrawPath(UnityEngine.Vector3[] path)
- public static void DrawPath(UnityEngine.Vector3[] path, UnityEngine.Color color)
- public static void DrawPath(UnityEngine.Transform[] path)
- public static void DrawPath(UnityEngine.Transform[] path, UnityEngine.Color color)
- public static void DrawPathGizmos(UnityEngine.Vector3[] path)
- public static void DrawPathGizmos(UnityEngine.Vector3[] path, UnityEngine.Color color)
- public static void DrawPathGizmos(UnityEngine.Transform[] path)
- public static void DrawPathGizmos(UnityEngine.Transform[] path, UnityEngine.Color color)
- public static void DrawPathHandles(UnityEngine.Vector3[] path)
- public static void DrawPathHandles(UnityEngine.Vector3[] path, UnityEngine.Color color)
- public static void DrawPathHandles(UnityEngine.Transform[] path)
- public static void DrawPathHandles(UnityEngine.Transform[] path, UnityEngine.Color color)
- private static void DrawPathHelper(UnityEngine.Vector3[] path, UnityEngine.Color color, string method)
- public static float easeInBack(float start, float end, float value)
- public static float easeInBounce(float start, float end, float value)
- public static float easeInCirc(float start, float end, float value)
- public static float easeInCubic(float start, float end, float value)
- private float easeInElastic(float start, float end, float value)
- public static float easeInExpo(float start, float end, float value)
- public static float easeInOutBack(float start, float end, float value)
- private float easeInOutBounce(float start, float end, float value)
- public static float easeInOutCirc(float start, float end, float value)
- public static float easeInOutCubic(float start, float end, float value)
- private float easeInOutElastic(float start, float end, float value)
- private float easeInOutExpo(float start, float end, float value)
- public static float easeInOutQuad(float start, float end, float value)
- private float easeInOutQuart(float start, float end, float value)
- public static float easeInOutQuint(float start, float end, float value)
- private float easeInOutSine(float start, float end, float value)
- public static float easeInQuad(float start, float end, float value)
- public static float easeInQuart(float start, float end, float value)
- private float easeInQuint(float start, float end, float value)
- private float easeInSine(float start, float end, float value)
- public static float easeOutBack(float start, float end, float value)
- public static float easeOutBounce(float start, float end, float value)
- public static float easeOutCirc(float start, float end, float value)
- public static float easeOutCubic(float start, float end, float value)
- public static float easeOutElastic(float start, float end, float value)
- private float easeOutExpo(float start, float end, float value)
- public static float easeOutQuad(float start, float end, float value)
- private float easeOutQuart(float start, float end, float value)
- public static float easeOutQuint(float start, float end, float value)
- private float easeOutSine(float start, float end, float value)
- private void EnableKinematic()
- public static void FadeFrom(UnityEngine.GameObject target, float alpha, float time)
- public static void FadeFrom(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void FadeTo(UnityEngine.GameObject target, float alpha, float time)
- public static void FadeTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void FadeUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void FadeUpdate(UnityEngine.GameObject target, float alpha, float time)
- private void FixedUpdate()
- public static float FloatUpdate(float currentValue, float targetValue, float speed)
- private void GenerateAudioToTargets()
- private void GenerateColorTargets()
- private void GenerateColorToTargets()
- private void GenerateFloatTargets()
- private static string GenerateID()
- private void GenerateLookToTargets()
- private void GenerateMoveByTargets()
- private void GenerateMoveToPathTargets()
- private void GenerateMoveToTargets()
- private void GeneratePunchPositionTargets()
- private void GeneratePunchRotationTargets()
- private void GeneratePunchScaleTargets()
- private void GenerateRectTargets()
- private void GenerateRotateAddTargets()
- private void GenerateRotateByTargets()
- private void GenerateRotateToTargets()
- private void GenerateScaleAddTargets()
- private void GenerateScaleByTargets()
- private void GenerateScaleToTargets()
- private void GenerateShakePositionTargets()
- private void GenerateShakeRotationTargets()
- private void GenerateShakeScaleTargets()
- private void GenerateStabTargets()
- private void GenerateTargets()
- private void GenerateVector2Targets()
- private void GenerateVector3Targets()
- private void GetEasingFunction()
- public static System.Collections.Hashtable Hash(params object[] args)
- public static void Init(UnityEngine.GameObject target)
- private static UnityEngine.Vector3 Interp(UnityEngine.Vector3[] pts, float t)
- private void LateUpdate()
- private static void Launch(UnityEngine.GameObject target, System.Collections.Hashtable args)
- private float linear(float start, float end, float value)
- public static void LookFrom(UnityEngine.GameObject target, UnityEngine.Vector3 looktarget, float time)
- public static void LookFrom(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void LookTo(UnityEngine.GameObject target, UnityEngine.Vector3 looktarget, float time)
- public static void LookTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void LookUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void LookUpdate(UnityEngine.GameObject target, UnityEngine.Vector3 looktarget, float time)
- public static void MoveAdd(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
- public static void MoveAdd(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void MoveBy(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
- public static void MoveBy(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void MoveFrom(UnityEngine.GameObject target, UnityEngine.Vector3 position, float time)
- public static void MoveFrom(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void MoveTo(UnityEngine.GameObject target, UnityEngine.Vector3 position, float time)
- public static void MoveTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void MoveUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void MoveUpdate(UnityEngine.GameObject target, UnityEngine.Vector3 position, float time)
- private void OnDisable()
- private void OnEnable()
- private static UnityEngine.Vector3[] PathControlPointGenerator(UnityEngine.Vector3[] path)
- public static float PathLength(UnityEngine.Transform[] path)
- public static float PathLength(UnityEngine.Vector3[] path)
- public static void Pause(UnityEngine.GameObject target)
- public static void Pause(UnityEngine.GameObject target, bool includechildren)
- public static void Pause(UnityEngine.GameObject target, string type)
- public static void Pause(UnityEngine.GameObject target, string type, bool includechildren)
- public static void Pause()
- public static void Pause(string type)
- public static UnityEngine.Vector3 PointOnPath(UnityEngine.Transform[] path, float percent)
- public static UnityEngine.Vector3 PointOnPath(UnityEngine.Vector3[] path, float percent)
- private float punch(float amplitude, float value)
- public static void PunchPosition(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
- public static void PunchPosition(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void PunchRotation(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
- public static void PunchRotation(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void PunchScale(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
- public static void PunchScale(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void PutOnPath(UnityEngine.GameObject target, UnityEngine.Vector3[] path, float percent)
- public static void PutOnPath(UnityEngine.Transform target, UnityEngine.Vector3[] path, float percent)
- public static void PutOnPath(UnityEngine.GameObject target, UnityEngine.Transform[] path, float percent)
- public static void PutOnPath(UnityEngine.Transform target, UnityEngine.Transform[] path, float percent)
- public static UnityEngine.Rect RectUpdate(UnityEngine.Rect currentValue, UnityEngine.Rect targetValue, float speed)
- public static void Resume(UnityEngine.GameObject target)
- public static void Resume(UnityEngine.GameObject target, bool includechildren)
- public static void Resume(UnityEngine.GameObject target, string type)
- public static void Resume(UnityEngine.GameObject target, string type, bool includechildren)
- public static void Resume()
- public static void Resume(string type)
- private void ResumeDelay()
- private void RetrieveArgs()
- public static void RotateAdd(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
- public static void RotateAdd(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void RotateBy(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
- public static void RotateBy(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void RotateFrom(UnityEngine.GameObject target, UnityEngine.Vector3 rotation, float time)
- public static void RotateFrom(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void RotateTo(UnityEngine.GameObject target, UnityEngine.Vector3 rotation, float time)
- public static void RotateTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void RotateUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void RotateUpdate(UnityEngine.GameObject target, UnityEngine.Vector3 rotation, float time)
- public static void ScaleAdd(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
- public static void ScaleAdd(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void ScaleBy(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
- public static void ScaleBy(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void ScaleFrom(UnityEngine.GameObject target, UnityEngine.Vector3 scale, float time)
- public static void ScaleFrom(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void ScaleTo(UnityEngine.GameObject target, UnityEngine.Vector3 scale, float time)
- public static void ScaleTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void ScaleUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void ScaleUpdate(UnityEngine.GameObject target, UnityEngine.Vector3 scale, float time)
- public static void ShakePosition(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
- public static void ShakePosition(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void ShakeRotation(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
- public static void ShakeRotation(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static void ShakeScale(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
- public static void ShakeScale(UnityEngine.GameObject target, System.Collections.Hashtable args)
- private float spring(float start, float end, float value)
- public static void Stab(UnityEngine.GameObject target, UnityEngine.AudioClip audioclip, float delay)
- public static void Stab(UnityEngine.GameObject target, System.Collections.Hashtable args)
- private System.Collections.IEnumerator Start()
- public static void Stop()
- public static void Stop(string type)
- public static void Stop(UnityEngine.GameObject target)
- public static void Stop(UnityEngine.GameObject target, bool includechildren)
- public static void Stop(UnityEngine.GameObject target, string type)
- public static void Stop(UnityEngine.GameObject target, string type, bool includechildren)
- public static void StopByName(string name)
- public static void StopByName(UnityEngine.GameObject target, string name)
- public static void StopByName(UnityEngine.GameObject target, string name, bool includechildren)
- private void TweenComplete()
- private System.Collections.IEnumerator TweenDelay()
- private void TweenLoop()
- private System.Collections.IEnumerator TweenRestart()
- private void TweenStart()
- private void TweenUpdate()
- private void Update()
- private void UpdatePercentage()
- public static void ValueTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
- public static UnityEngine.Vector2 Vector2Update(UnityEngine.Vector2 currentValue, UnityEngine.Vector2 targetValue, float speed)
- public static UnityEngine.Vector3 Vector3Update(UnityEngine.Vector3 currentValue, UnityEngine.Vector3 targetValue, float speed)

### public enum iTween.LoopType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- loop = 1
- none = 0
- pingPong = 2

### private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData

#### Fields
- public byte[] FilePathsData
- public bool IsEditorOnly
- public int TotalFiles
- public int TotalTypes
- public byte[] TypesData

### public class MoveSample
- Base: UnityEngine.MonoBehaviour

#### Constructors
- public MoveSample()

#### Methods
- private void Start()

### public enum iTween.NamedValueColor
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- _Color = 0
- _Emission = 2
- _ReflectColor = 3
- _SpecColor = 1

### public class GameManager.PurchaseListener
- Interfaces: UnityEngine.UDP.IPurchaseListener

#### Constructors
- public GameManager.PurchaseListener()

#### Methods
- public void OnMultiPurchaseConsume(System.Collections.Generic.List<bool> successful, System.Collections.Generic.List<UnityEngine.UDP.PurchaseInfo> purchaseInfos, System.Collections.Generic.List<string> messages)
- public void OnPurchase(UnityEngine.UDP.PurchaseInfo purchaseInfo)
- public void OnPurchaseConsume(UnityEngine.UDP.PurchaseInfo purchaseInfo)
- public void OnPurchaseConsumeFailed(string message, UnityEngine.UDP.PurchaseInfo purchaseInfo)
- public void OnPurchaseFailed(string message, UnityEngine.UDP.PurchaseInfo purchaseInfo)
- public void OnPurchaseRepeated(string productCode)
- public void OnQueryInventory(UnityEngine.UDP.Inventory inventory)
- public void OnQueryInventoryFailed(string message)

### public class RotateSample
- Base: UnityEngine.MonoBehaviour

#### Constructors
- public RotateSample()

#### Methods
- private void Start()

### public class SampleInfo
- Base: UnityEngine.MonoBehaviour

#### Constructors
- public SampleInfo()

#### Methods
- private void OnGUI()

### internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1

#### Constructors
- public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()

#### Methods
- private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1256

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3494

## Namespace: BuildHelpers

### public static class BuildHelpers.GitHelpers

#### Methods
- public static string getGitBranch()
- public static string getGitCommit()
- public static void saveGitInfo()

## Namespace: DG.Tweening

### private class DG.Tweening.DOTweenModuleAudio.<>c__DisplayClass0_0

#### Fields
- public UnityEngine.AudioSource target

#### Constructors
- public DOTweenModuleAudio.<>c__DisplayClass0_0()

#### Methods
- internal float <DOFade>b__0()
- internal void <DOFade>b__1(float x)

### private class DG.Tweening.DOTweenModulePhysics.<>c__DisplayClass0_0

#### Fields
- public UnityEngine.Rigidbody target

#### Constructors
- public DOTweenModulePhysics.<>c__DisplayClass0_0()

#### Methods
- internal UnityEngine.Vector3 <DOMove>b__0()

### private class DG.Tweening.DOTweenModulePhysics2D.<>c__DisplayClass0_0

#### Fields
- public UnityEngine.Rigidbody2D target

#### Constructors
- public DOTweenModulePhysics2D.<>c__DisplayClass0_0()

#### Methods
- internal UnityEngine.Vector2 <DOMove>b__0()

### private class DG.Tweening.DOTweenModuleSprite.<>c__DisplayClass0_0

#### Fields
- public UnityEngine.SpriteRenderer target

#### Constructors
- public DOTweenModuleSprite.<>c__DisplayClass0_0()

#### Methods
- internal UnityEngine.Color <DOColor>b__0()
- internal void <DOColor>b__1(UnityEngine.Color x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass0_0

#### Fields
- public UnityEngine.CanvasGroup target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass0_0()

#### Methods
- internal float <DOFade>b__0()
- internal void <DOFade>b__1(float x)

### private class DG.Tweening.DOTweenModulePhysics.<>c__DisplayClass10_0

#### Fields
- public UnityEngine.Rigidbody target
- public UnityEngine.Transform trans

#### Constructors
- public DOTweenModulePhysics.<>c__DisplayClass10_0()

#### Methods
- internal UnityEngine.Vector3 <DOLocalPath>b__0()
- internal void <DOLocalPath>b__1(UnityEngine.Vector3 x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass10_0

#### Fields
- public UnityEngine.UI.Outline target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass10_0()

#### Methods
- internal UnityEngine.Color <DOColor>b__0()
- internal void <DOColor>b__1(UnityEngine.Color x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass11_0

#### Fields
- public UnityEngine.UI.Outline target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass11_0()

#### Methods
- internal UnityEngine.Color <DOFade>b__0()
- internal void <DOFade>b__1(UnityEngine.Color x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass12_0

#### Fields
- public UnityEngine.UI.Outline target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass12_0()

#### Methods
- internal UnityEngine.Vector2 <DOScale>b__0()
- internal void <DOScale>b__1(UnityEngine.Vector2 x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass13_0

#### Fields
- public UnityEngine.RectTransform target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass13_0()

#### Methods
- internal UnityEngine.Vector2 <DOAnchorPos>b__0()
- internal void <DOAnchorPos>b__1(UnityEngine.Vector2 x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass14_0

#### Fields
- public UnityEngine.RectTransform target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass14_0()

#### Methods
- internal UnityEngine.Vector2 <DOAnchorPosX>b__0()
- internal void <DOAnchorPosX>b__1(UnityEngine.Vector2 x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass15_0

#### Fields
- public UnityEngine.RectTransform target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass15_0()

#### Methods
- internal UnityEngine.Vector2 <DOAnchorPosY>b__0()
- internal void <DOAnchorPosY>b__1(UnityEngine.Vector2 x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass16_0

#### Fields
- public UnityEngine.RectTransform target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass16_0()

#### Methods
- internal UnityEngine.Vector3 <DOAnchorPos3D>b__0()
- internal void <DOAnchorPos3D>b__1(UnityEngine.Vector3 x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass17_0

#### Fields
- public UnityEngine.RectTransform target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass17_0()

#### Methods
- internal UnityEngine.Vector3 <DOAnchorPos3DX>b__0()
- internal void <DOAnchorPos3DX>b__1(UnityEngine.Vector3 x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass18_0

#### Fields
- public UnityEngine.RectTransform target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass18_0()

#### Methods
- internal UnityEngine.Vector3 <DOAnchorPos3DY>b__0()
- internal void <DOAnchorPos3DY>b__1(UnityEngine.Vector3 x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass19_0

#### Fields
- public UnityEngine.RectTransform target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass19_0()

#### Methods
- internal UnityEngine.Vector3 <DOAnchorPos3DZ>b__0()
- internal void <DOAnchorPos3DZ>b__1(UnityEngine.Vector3 x)

### private class DG.Tweening.DOTweenModuleAudio.<>c__DisplayClass1_0

#### Fields
- public UnityEngine.AudioSource target

#### Constructors
- public DOTweenModuleAudio.<>c__DisplayClass1_0()

#### Methods
- internal float <DOPitch>b__0()
- internal void <DOPitch>b__1(float x)

### private class DG.Tweening.DOTweenModulePhysics.<>c__DisplayClass1_0

#### Fields
- public UnityEngine.Rigidbody target

#### Constructors
- public DOTweenModulePhysics.<>c__DisplayClass1_0()

#### Methods
- internal UnityEngine.Vector3 <DOMoveX>b__0()

### private class DG.Tweening.DOTweenModulePhysics2D.<>c__DisplayClass1_0

#### Fields
- public UnityEngine.Rigidbody2D target

#### Constructors
- public DOTweenModulePhysics2D.<>c__DisplayClass1_0()

#### Methods
- internal UnityEngine.Vector2 <DOMoveX>b__0()

### private class DG.Tweening.DOTweenModuleSprite.<>c__DisplayClass1_0

#### Fields
- public UnityEngine.SpriteRenderer target

#### Constructors
- public DOTweenModuleSprite.<>c__DisplayClass1_0()

#### Methods
- internal UnityEngine.Color <DOFade>b__0()
- internal void <DOFade>b__1(UnityEngine.Color x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass1_0

#### Fields
- public UnityEngine.UI.Graphic target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass1_0()

#### Methods
- internal UnityEngine.Color <DOColor>b__0()
- internal void <DOColor>b__1(UnityEngine.Color x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass20_0

#### Fields
- public UnityEngine.RectTransform target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass20_0()

#### Methods
- internal UnityEngine.Vector2 <DOAnchorMax>b__0()
- internal void <DOAnchorMax>b__1(UnityEngine.Vector2 x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass21_0

#### Fields
- public UnityEngine.RectTransform target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass21_0()

#### Methods
- internal UnityEngine.Vector2 <DOAnchorMin>b__0()
- internal void <DOAnchorMin>b__1(UnityEngine.Vector2 x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass22_0

#### Fields
- public UnityEngine.RectTransform target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass22_0()

#### Methods
- internal UnityEngine.Vector2 <DOPivot>b__0()
- internal void <DOPivot>b__1(UnityEngine.Vector2 x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass23_0

#### Fields
- public UnityEngine.RectTransform target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass23_0()

#### Methods
- internal UnityEngine.Vector2 <DOPivotX>b__0()
- internal void <DOPivotX>b__1(UnityEngine.Vector2 x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass24_0

#### Fields
- public UnityEngine.RectTransform target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass24_0()

#### Methods
- internal UnityEngine.Vector2 <DOPivotY>b__0()
- internal void <DOPivotY>b__1(UnityEngine.Vector2 x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass25_0

#### Fields
- public UnityEngine.RectTransform target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass25_0()

#### Methods
- internal UnityEngine.Vector2 <DOSizeDelta>b__0()
- internal void <DOSizeDelta>b__1(UnityEngine.Vector2 x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass26_0

#### Fields
- public UnityEngine.RectTransform target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass26_0()

#### Methods
- internal UnityEngine.Vector3 <DOPunchAnchorPos>b__0()
- internal void <DOPunchAnchorPos>b__1(UnityEngine.Vector3 x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass27_0

#### Fields
- public UnityEngine.RectTransform target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass27_0()

#### Methods
- internal UnityEngine.Vector3 <DOShakeAnchorPos>b__0()
- internal void <DOShakeAnchorPos>b__1(UnityEngine.Vector3 x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass28_0

#### Fields
- public UnityEngine.RectTransform target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass28_0()

#### Methods
- internal UnityEngine.Vector3 <DOShakeAnchorPos>b__0()
- internal void <DOShakeAnchorPos>b__1(UnityEngine.Vector3 x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass29_0

#### Fields
- public UnityEngine.Vector2 endValue
- public float offsetY
- public bool offsetYSet
- public DG.Tweening.Sequence s
- public float startPosY
- public UnityEngine.RectTransform target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass29_0()

#### Methods
- internal UnityEngine.Vector2 <DOJumpAnchorPos>b__0()
- internal void <DOJumpAnchorPos>b__1(UnityEngine.Vector2 x)
- internal void <DOJumpAnchorPos>b__2()
- internal UnityEngine.Vector2 <DOJumpAnchorPos>b__3()
- internal void <DOJumpAnchorPos>b__4(UnityEngine.Vector2 x)
- internal void <DOJumpAnchorPos>b__5()

### private class DG.Tweening.DOTweenModuleAudio.<>c__DisplayClass2_0

#### Fields
- public string floatName
- public UnityEngine.Audio.AudioMixer target

#### Constructors
- public DOTweenModuleAudio.<>c__DisplayClass2_0()

#### Methods
- internal float <DOSetFloat>b__0()
- internal void <DOSetFloat>b__1(float x)

### private class DG.Tweening.DOTweenModulePhysics.<>c__DisplayClass2_0

#### Fields
- public UnityEngine.Rigidbody target

#### Constructors
- public DOTweenModulePhysics.<>c__DisplayClass2_0()

#### Methods
- internal UnityEngine.Vector3 <DOMoveY>b__0()

### private class DG.Tweening.DOTweenModulePhysics2D.<>c__DisplayClass2_0

#### Fields
- public UnityEngine.Rigidbody2D target

#### Constructors
- public DOTweenModulePhysics2D.<>c__DisplayClass2_0()

#### Methods
- internal UnityEngine.Vector2 <DOMoveY>b__0()

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass2_0

#### Fields
- public UnityEngine.UI.Graphic target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass2_0()

#### Methods
- internal UnityEngine.Color <DOFade>b__0()
- internal void <DOFade>b__1(UnityEngine.Color x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass30_0

#### Fields
- public UnityEngine.UI.ScrollRect target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass30_0()

#### Methods
- internal UnityEngine.Vector2 <DONormalizedPos>b__0()
- internal void <DONormalizedPos>b__1(UnityEngine.Vector2 x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass31_0

#### Fields
- public UnityEngine.UI.ScrollRect target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass31_0()

#### Methods
- internal float <DOHorizontalNormalizedPos>b__0()
- internal void <DOHorizontalNormalizedPos>b__1(float x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass32_0

#### Fields
- public UnityEngine.UI.ScrollRect target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass32_0()

#### Methods
- internal float <DOVerticalNormalizedPos>b__0()
- internal void <DOVerticalNormalizedPos>b__1(float x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass33_0

#### Fields
- public UnityEngine.UI.Slider target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass33_0()

#### Methods
- internal float <DOValue>b__0()
- internal void <DOValue>b__1(float x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass34_0

#### Fields
- public UnityEngine.UI.Text target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass34_0()

#### Methods
- internal UnityEngine.Color <DOColor>b__0()
- internal void <DOColor>b__1(UnityEngine.Color x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass35_0

#### Fields
- public bool addThousandsSeparator
- public System.Globalization.CultureInfo cInfo
- public UnityEngine.UI.Text target
- public int v

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass35_0()

#### Methods
- internal int <DOCounter>b__0()
- internal void <DOCounter>b__1(int x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass36_0

#### Fields
- public UnityEngine.UI.Text target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass36_0()

#### Methods
- internal UnityEngine.Color <DOFade>b__0()
- internal void <DOFade>b__1(UnityEngine.Color x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass37_0

#### Fields
- public UnityEngine.UI.Text target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass37_0()

#### Methods
- internal string <DOText>b__0()
- internal void <DOText>b__1(string x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass38_0

#### Fields
- public UnityEngine.UI.Graphic target
- public UnityEngine.Color to

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass38_0()

#### Methods
- internal UnityEngine.Color <DOBlendableColor>b__0()
- internal void <DOBlendableColor>b__1(UnityEngine.Color x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass39_0

#### Fields
- public UnityEngine.UI.Image target
- public UnityEngine.Color to

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass39_0()

#### Methods
- internal UnityEngine.Color <DOBlendableColor>b__0()
- internal void <DOBlendableColor>b__1(UnityEngine.Color x)

### private class DG.Tweening.DOTweenModulePhysics.<>c__DisplayClass3_0

#### Fields
- public UnityEngine.Rigidbody target

#### Constructors
- public DOTweenModulePhysics.<>c__DisplayClass3_0()

#### Methods
- internal UnityEngine.Vector3 <DOMoveZ>b__0()

### private class DG.Tweening.DOTweenModulePhysics2D.<>c__DisplayClass3_0

#### Fields
- public UnityEngine.Rigidbody2D target

#### Constructors
- public DOTweenModulePhysics2D.<>c__DisplayClass3_0()

#### Methods
- internal float <DORotate>b__0()

### private class DG.Tweening.DOTweenModuleSprite.<>c__DisplayClass3_0

#### Fields
- public UnityEngine.SpriteRenderer target
- public UnityEngine.Color to

#### Constructors
- public DOTweenModuleSprite.<>c__DisplayClass3_0()

#### Methods
- internal UnityEngine.Color <DOBlendableColor>b__0()
- internal void <DOBlendableColor>b__1(UnityEngine.Color x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass3_0

#### Fields
- public UnityEngine.UI.Image target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass3_0()

#### Methods
- internal UnityEngine.Color <DOColor>b__0()
- internal void <DOColor>b__1(UnityEngine.Color x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass40_0

#### Fields
- public UnityEngine.UI.Text target
- public UnityEngine.Color to

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass40_0()

#### Methods
- internal UnityEngine.Color <DOBlendableColor>b__0()
- internal void <DOBlendableColor>b__1(UnityEngine.Color x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass41_0

#### Fields
- public UnityEngine.RectTransform target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass41_0()

#### Methods
- internal UnityEngine.Vector2 <DOShapeCircle>b__0()
- internal void <DOShapeCircle>b__1(UnityEngine.Vector2 x)

### private class DG.Tweening.DOTweenModulePhysics.<>c__DisplayClass4_0

#### Fields
- public UnityEngine.Rigidbody target

#### Constructors
- public DOTweenModulePhysics.<>c__DisplayClass4_0()

#### Methods
- internal UnityEngine.Quaternion <DORotate>b__0()

### private class DG.Tweening.DOTweenModulePhysics2D.<>c__DisplayClass4_0

#### Fields
- public UnityEngine.Vector2 endValue
- public float offsetY
- public bool offsetYSet
- public DG.Tweening.Sequence s
- public float startPosY
- public UnityEngine.Rigidbody2D target
- public DG.Tweening.Tween yTween

#### Constructors
- public DOTweenModulePhysics2D.<>c__DisplayClass4_0()

#### Methods
- internal UnityEngine.Vector2 <DOJump>b__0()
- internal void <DOJump>b__1(UnityEngine.Vector2 x)
- internal void <DOJump>b__2()
- internal UnityEngine.Vector2 <DOJump>b__3()
- internal void <DOJump>b__4(UnityEngine.Vector2 x)
- internal void <DOJump>b__5()

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass4_0

#### Fields
- public UnityEngine.UI.Image target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass4_0()

#### Methods
- internal UnityEngine.Color <DOFade>b__0()
- internal void <DOFade>b__1(UnityEngine.Color x)

### private class DG.Tweening.DOTweenModulePhysics.<>c__DisplayClass5_0

#### Fields
- public UnityEngine.Rigidbody target

#### Constructors
- public DOTweenModulePhysics.<>c__DisplayClass5_0()

#### Methods
- internal UnityEngine.Quaternion <DOLookAt>b__0()

### private class DG.Tweening.DOTweenModulePhysics2D.<>c__DisplayClass5_0

#### Fields
- public UnityEngine.Rigidbody2D target

#### Constructors
- public DOTweenModulePhysics2D.<>c__DisplayClass5_0()

#### Methods
- internal UnityEngine.Vector3 <DOPath>b__0()
- internal void <DOPath>b__1(UnityEngine.Vector3 x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass5_0

#### Fields
- public UnityEngine.UI.Image target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass5_0()

#### Methods
- internal float <DOFillAmount>b__0()
- internal void <DOFillAmount>b__1(float x)

### private class DG.Tweening.DOTweenModulePhysics.<>c__DisplayClass6_0

#### Fields
- public UnityEngine.Vector3 endValue
- public float offsetY
- public bool offsetYSet
- public DG.Tweening.Sequence s
- public float startPosY
- public UnityEngine.Rigidbody target
- public DG.Tweening.Tween yTween

#### Constructors
- public DOTweenModulePhysics.<>c__DisplayClass6_0()

#### Methods
- internal UnityEngine.Vector3 <DOJump>b__0()
- internal void <DOJump>b__1()
- internal UnityEngine.Vector3 <DOJump>b__2()
- internal UnityEngine.Vector3 <DOJump>b__3()
- internal void <DOJump>b__4()

### private class DG.Tweening.DOTweenModulePhysics2D.<>c__DisplayClass6_0

#### Fields
- public UnityEngine.Rigidbody2D target
- public UnityEngine.Transform trans

#### Constructors
- public DOTweenModulePhysics2D.<>c__DisplayClass6_0()

#### Methods
- internal UnityEngine.Vector3 <DOLocalPath>b__0()
- internal void <DOLocalPath>b__1(UnityEngine.Vector3 x)

### private class DG.Tweening.DOTweenModulePhysics.<>c__DisplayClass7_0

#### Fields
- public UnityEngine.Rigidbody target

#### Constructors
- public DOTweenModulePhysics.<>c__DisplayClass7_0()

#### Methods
- internal UnityEngine.Vector3 <DOPath>b__0()

### private class DG.Tweening.DOTweenModulePhysics2D.<>c__DisplayClass7_0

#### Fields
- public UnityEngine.Rigidbody2D target

#### Constructors
- public DOTweenModulePhysics2D.<>c__DisplayClass7_0()

#### Methods
- internal UnityEngine.Vector3 <DOPath>b__0()
- internal void <DOPath>b__1(UnityEngine.Vector3 x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass7_0

#### Fields
- public UnityEngine.UI.LayoutElement target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass7_0()

#### Methods
- internal UnityEngine.Vector2 <DOFlexibleSize>b__0()
- internal void <DOFlexibleSize>b__1(UnityEngine.Vector2 x)

### private class DG.Tweening.DOTweenModulePhysics.<>c__DisplayClass8_0

#### Fields
- public UnityEngine.Rigidbody target
- public UnityEngine.Transform trans

#### Constructors
- public DOTweenModulePhysics.<>c__DisplayClass8_0()

#### Methods
- internal UnityEngine.Vector3 <DOLocalPath>b__0()
- internal void <DOLocalPath>b__1(UnityEngine.Vector3 x)

### private class DG.Tweening.DOTweenModulePhysics2D.<>c__DisplayClass8_0

#### Fields
- public UnityEngine.Rigidbody2D target
- public UnityEngine.Transform trans

#### Constructors
- public DOTweenModulePhysics2D.<>c__DisplayClass8_0()

#### Methods
- internal UnityEngine.Vector3 <DOLocalPath>b__0()
- internal void <DOLocalPath>b__1(UnityEngine.Vector3 x)

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass8_0

#### Fields
- public UnityEngine.UI.LayoutElement target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass8_0()

#### Methods
- internal UnityEngine.Vector2 <DOMinSize>b__0()
- internal void <DOMinSize>b__1(UnityEngine.Vector2 x)

### private class DG.Tweening.DOTweenModuleUnityVersion.<>c__DisplayClass8_0

#### Fields
- public int propertyID
- public UnityEngine.Material target

#### Constructors
- public DOTweenModuleUnityVersion.<>c__DisplayClass8_0()

#### Methods
- internal UnityEngine.Vector2 <DOOffset>b__0()
- internal void <DOOffset>b__1(UnityEngine.Vector2 x)

### private class DG.Tweening.DOTweenModulePhysics.<>c__DisplayClass9_0

#### Fields
- public UnityEngine.Rigidbody target

#### Constructors
- public DOTweenModulePhysics.<>c__DisplayClass9_0()

#### Methods
- internal UnityEngine.Vector3 <DOPath>b__0()

### private class DG.Tweening.DOTweenModuleUI.<>c__DisplayClass9_0

#### Fields
- public UnityEngine.UI.LayoutElement target

#### Constructors
- public DOTweenModuleUI.<>c__DisplayClass9_0()

#### Methods
- internal UnityEngine.Vector2 <DOPreferredSize>b__0()
- internal void <DOPreferredSize>b__1(UnityEngine.Vector2 x)

### private class DG.Tweening.DOTweenModuleUnityVersion.<>c__DisplayClass9_0

#### Fields
- public int propertyID
- public UnityEngine.Material target

#### Constructors
- public DOTweenModuleUnityVersion.<>c__DisplayClass9_0()

#### Methods
- internal UnityEngine.Vector2 <DOTiling>b__0()
- internal void <DOTiling>b__1(UnityEngine.Vector2 x)

### private struct DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForCompletion>d__10
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1
- public DG.Tweening.Tween t

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForElapsedLoops>d__13
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1
- public int elapsedLoops
- public DG.Tweening.Tween t

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForKill>d__12
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1
- public DG.Tweening.Tween t

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForPosition>d__14
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1
- public float position
- public DG.Tweening.Tween t

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForRewind>d__11
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1
- public DG.Tweening.Tween t

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForStart>d__15
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1
- public DG.Tweening.Tween t

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### public static class DG.Tweening.DOTweenCYInstruction

### public static class DG.Tweening.DOTweenModuleAudio

#### Methods
- public static int DOComplete(UnityEngine.Audio.AudioMixer target, bool withCallbacks = false)
- public static DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFade(UnityEngine.AudioSource target, float endValue, float duration)
- public static int DOFlip(UnityEngine.Audio.AudioMixer target)
- public static int DOGoto(UnityEngine.Audio.AudioMixer target, float to, bool andPlay = false)
- public static int DOKill(UnityEngine.Audio.AudioMixer target, bool complete = false)
- public static int DOPause(UnityEngine.Audio.AudioMixer target)
- public static DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOPitch(UnityEngine.AudioSource target, float endValue, float duration)
- public static int DOPlay(UnityEngine.Audio.AudioMixer target)
- public static int DOPlayBackwards(UnityEngine.Audio.AudioMixer target)
- public static int DOPlayForward(UnityEngine.Audio.AudioMixer target)
- public static int DORestart(UnityEngine.Audio.AudioMixer target)
- public static int DORewind(UnityEngine.Audio.AudioMixer target)
- public static DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOSetFloat(UnityEngine.Audio.AudioMixer target, string floatName, float endValue, float duration)
- public static int DOSmoothRewind(UnityEngine.Audio.AudioMixer target)
- public static int DOTogglePause(UnityEngine.Audio.AudioMixer target)

### public static class DG.Tweening.DOTweenModulePhysics

#### Methods
- public static DG.Tweening.Sequence DOJump(UnityEngine.Rigidbody target, UnityEngine.Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType = Linear, DG.Tweening.PathMode pathMode = Full3D, int resolution = 10, System.Nullable<UnityEngine.Color> gizmoColor = null)
- internal static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode = Full3D)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> DOLookAt(UnityEngine.Rigidbody target, UnityEngine.Vector3 towards, float duration, DG.Tweening.AxisConstraint axisConstraint = None, System.Nullable<UnityEngine.Vector3> up = null)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMove(UnityEngine.Rigidbody target, UnityEngine.Vector3 endValue, float duration, bool snapping = false)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveX(UnityEngine.Rigidbody target, float endValue, float duration, bool snapping = false)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveY(UnityEngine.Rigidbody target, float endValue, float duration, bool snapping = false)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveZ(UnityEngine.Rigidbody target, float endValue, float duration, bool snapping = false)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType = Linear, DG.Tweening.PathMode pathMode = Full3D, int resolution = 10, System.Nullable<UnityEngine.Color> gizmoColor = null)
- internal static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode = Full3D)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> DORotate(UnityEngine.Rigidbody target, UnityEngine.Vector3 endValue, float duration, DG.Tweening.RotateMode mode = Fast)

### public static class DG.Tweening.DOTweenModulePhysics2D

#### Methods
- public static DG.Tweening.Sequence DOJump(UnityEngine.Rigidbody2D target, UnityEngine.Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody2D target, UnityEngine.Vector2[] path, float duration, DG.Tweening.PathType pathType = Linear, DG.Tweening.PathMode pathMode = Full3D, int resolution = 10, System.Nullable<UnityEngine.Color> gizmoColor = null)
- internal static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody2D target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode = Full3D)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMove(UnityEngine.Rigidbody2D target, UnityEngine.Vector2 endValue, float duration, bool snapping = false)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMoveX(UnityEngine.Rigidbody2D target, float endValue, float duration, bool snapping = false)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMoveY(UnityEngine.Rigidbody2D target, float endValue, float duration, bool snapping = false)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody2D target, UnityEngine.Vector2[] path, float duration, DG.Tweening.PathType pathType = Linear, DG.Tweening.PathMode pathMode = Full3D, int resolution = 10, System.Nullable<UnityEngine.Color> gizmoColor = null)
- internal static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody2D target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode = Full3D)
- public static DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DORotate(UnityEngine.Rigidbody2D target, float endValue, float duration)

### public static class DG.Tweening.DOTweenModuleSprite

#### Methods
- public static DG.Tweening.Tweener DOBlendableColor(UnityEngine.SpriteRenderer target, UnityEngine.Color endValue, float duration)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.SpriteRenderer target, UnityEngine.Color endValue, float duration)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.SpriteRenderer target, float endValue, float duration)
- public static DG.Tweening.Sequence DOGradientColor(UnityEngine.SpriteRenderer target, UnityEngine.Gradient gradient, float duration)

### public static class DG.Tweening.DOTweenModuleUI

#### Methods
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorMax(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping = false)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorMin(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping = false)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping = false)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3D(UnityEngine.RectTransform target, UnityEngine.Vector3 endValue, float duration, bool snapping = false)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3DX(UnityEngine.RectTransform target, float endValue, float duration, bool snapping = false)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3DY(UnityEngine.RectTransform target, float endValue, float duration, bool snapping = false)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3DZ(UnityEngine.RectTransform target, float endValue, float duration, bool snapping = false)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPosX(UnityEngine.RectTransform target, float endValue, float duration, bool snapping = false)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPosY(UnityEngine.RectTransform target, float endValue, float duration, bool snapping = false)
- public static DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Graphic target, UnityEngine.Color endValue, float duration)
- public static DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Image target, UnityEngine.Color endValue, float duration)
- public static DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Text target, UnityEngine.Color endValue, float duration)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Graphic target, UnityEngine.Color endValue, float duration)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Image target, UnityEngine.Color endValue, float duration)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Outline target, UnityEngine.Color endValue, float duration)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Text target, UnityEngine.Color endValue, float duration)
- public static DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> DOCounter(UnityEngine.UI.Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, System.Globalization.CultureInfo culture = null)
- public static DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFade(UnityEngine.CanvasGroup target, float endValue, float duration)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Graphic target, float endValue, float duration)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Image target, float endValue, float duration)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Outline target, float endValue, float duration)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Text target, float endValue, float duration)
- public static DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFillAmount(UnityEngine.UI.Image target, float endValue, float duration)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOFlexibleSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping = false)
- public static DG.Tweening.Sequence DOGradientColor(UnityEngine.UI.Image target, UnityEngine.Gradient gradient, float duration)
- public static DG.Tweening.Tweener DOHorizontalNormalizedPos(UnityEngine.UI.ScrollRect target, float endValue, float duration, bool snapping = false)
- public static DG.Tweening.Sequence DOJumpAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMinSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping = false)
- public static DG.Tweening.Tweener DONormalizedPos(UnityEngine.UI.ScrollRect target, UnityEngine.Vector2 endValue, float duration, bool snapping = false)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPivot(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPivotX(UnityEngine.RectTransform target, float endValue, float duration)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPivotY(UnityEngine.RectTransform target, float endValue, float duration)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPreferredSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping = false)
- public static DG.Tweening.Tweener DOPunchAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 punch, float duration, int vibrato = 10, float elasticity = 1, bool snapping = false)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOScale(UnityEngine.UI.Outline target, UnityEngine.Vector2 endValue, float duration)
- public static DG.Tweening.Tweener DOShakeAnchorPos(UnityEngine.RectTransform target, float duration, float strength = 100, int vibrato = 10, float randomness = 90, bool snapping = false, bool fadeOut = true, DG.Tweening.ShakeRandomnessMode randomnessMode = Full)
- public static DG.Tweening.Tweener DOShakeAnchorPos(UnityEngine.RectTransform target, float duration, UnityEngine.Vector2 strength, int vibrato = 10, float randomness = 90, bool snapping = false, bool fadeOut = true, DG.Tweening.ShakeRandomnessMode randomnessMode = Full)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> DOShapeCircle(UnityEngine.RectTransform target, UnityEngine.Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false, bool snapping = false)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOSizeDelta(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping = false)
- public static DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> DOText(UnityEngine.UI.Text target, string endValue, float duration, bool richTextEnabled = true, DG.Tweening.ScrambleMode scrambleMode = None, string scrambleChars = null)
- public static DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOValue(UnityEngine.UI.Slider target, float endValue, float duration, bool snapping = false)
- public static DG.Tweening.Tweener DOVerticalNormalizedPos(UnityEngine.UI.ScrollRect target, float endValue, float duration, bool snapping = false)

### public static class DG.Tweening.DOTweenModuleUnityVersion

#### Methods
- public static System.Threading.Tasks.Task AsyncWaitForCompletion(DG.Tweening.Tween t)
- public static System.Threading.Tasks.Task AsyncWaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops)
- public static System.Threading.Tasks.Task AsyncWaitForKill(DG.Tweening.Tween t)
- public static System.Threading.Tasks.Task AsyncWaitForPosition(DG.Tweening.Tween t, float position)
- public static System.Threading.Tasks.Task AsyncWaitForRewind(DG.Tweening.Tween t)
- public static System.Threading.Tasks.Task AsyncWaitForStart(DG.Tweening.Tween t)
- public static DG.Tweening.Sequence DOGradientColor(UnityEngine.Material target, UnityEngine.Gradient gradient, float duration)
- public static DG.Tweening.Sequence DOGradientColor(UnityEngine.Material target, UnityEngine.Gradient gradient, string property, float duration)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOOffset(UnityEngine.Material target, UnityEngine.Vector2 endValue, int propertyID, float duration)
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOTiling(UnityEngine.Material target, UnityEngine.Vector2 endValue, int propertyID, float duration)
- public static UnityEngine.CustomYieldInstruction WaitForCompletion(DG.Tweening.Tween t, bool returnCustomYieldInstruction)
- public static UnityEngine.CustomYieldInstruction WaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
- public static UnityEngine.CustomYieldInstruction WaitForKill(DG.Tweening.Tween t, bool returnCustomYieldInstruction)
- public static UnityEngine.CustomYieldInstruction WaitForPosition(DG.Tweening.Tween t, float position, bool returnCustomYieldInstruction)
- public static UnityEngine.CustomYieldInstruction WaitForRewind(DG.Tweening.Tween t, bool returnCustomYieldInstruction)
- public static UnityEngine.CustomYieldInstruction WaitForStart(DG.Tweening.Tween t, bool returnCustomYieldInstruction)

### public static class DG.Tweening.DOTweenModuleUtils

#### Fields
- private static bool _initialized

#### Methods
- public static void Init()
- private static void Preserver()

### public static class DG.Tweening.DOTweenModuleUtils.Physics

#### Methods
- public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> CreateDOTweenPathTween(UnityEngine.MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode)
- public static bool HasRigidbody(UnityEngine.Component target)
- public static bool HasRigidbody2D(UnityEngine.Component target)
- public static void SetOrientationOnPath(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, UnityEngine.Quaternion newRot, UnityEngine.Transform trans)

### public static class DG.Tweening.DOTweenModuleUI.Utils

#### Methods
- public static UnityEngine.Vector2 SwitchToRectTransform(UnityEngine.RectTransform from, UnityEngine.RectTransform to)

### public class DG.Tweening.DOTweenCYInstruction.WaitForCompletion
- Base: UnityEngine.CustomYieldInstruction
- Interfaces: System.Collections.IEnumerator

#### Fields
- private readonly DG.Tweening.Tween t

#### Properties
- public bool keepWaiting { get; }

#### Constructors
- public DOTweenCYInstruction.WaitForCompletion(DG.Tweening.Tween tween)

### public class DG.Tweening.DOTweenCYInstruction.WaitForElapsedLoops
- Base: UnityEngine.CustomYieldInstruction
- Interfaces: System.Collections.IEnumerator

#### Fields
- private readonly int elapsedLoops
- private readonly DG.Tweening.Tween t

#### Properties
- public bool keepWaiting { get; }

#### Constructors
- public DOTweenCYInstruction.WaitForElapsedLoops(DG.Tweening.Tween tween, int elapsedLoops)

### public class DG.Tweening.DOTweenCYInstruction.WaitForKill
- Base: UnityEngine.CustomYieldInstruction
- Interfaces: System.Collections.IEnumerator

#### Fields
- private readonly DG.Tweening.Tween t

#### Properties
- public bool keepWaiting { get; }

#### Constructors
- public DOTweenCYInstruction.WaitForKill(DG.Tweening.Tween tween)

### public class DG.Tweening.DOTweenCYInstruction.WaitForPosition
- Base: UnityEngine.CustomYieldInstruction
- Interfaces: System.Collections.IEnumerator

#### Fields
- private readonly float position
- private readonly DG.Tweening.Tween t

#### Properties
- public bool keepWaiting { get; }

#### Constructors
- public DOTweenCYInstruction.WaitForPosition(DG.Tweening.Tween tween, float position)

### public class DG.Tweening.DOTweenCYInstruction.WaitForRewind
- Base: UnityEngine.CustomYieldInstruction
- Interfaces: System.Collections.IEnumerator

#### Fields
- private readonly DG.Tweening.Tween t

#### Properties
- public bool keepWaiting { get; }

#### Constructors
- public DOTweenCYInstruction.WaitForRewind(DG.Tweening.Tween tween)

### public class DG.Tweening.DOTweenCYInstruction.WaitForStart
- Base: UnityEngine.CustomYieldInstruction
- Interfaces: System.Collections.IEnumerator

#### Fields
- private readonly DG.Tweening.Tween t

#### Properties
- public bool keepWaiting { get; }

#### Constructors
- public DOTweenCYInstruction.WaitForStart(DG.Tweening.Tween tween)

## Namespace: Discord

### internal delegate Discord.ActivityManager.FFIMethods.AcceptInviteCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.FFIMethods.AcceptInviteCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.ActivityManager.AcceptInviteHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.AcceptInviteHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.ActivityManager.FFIMethods.AcceptInviteMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.FFIMethods.AcceptInviteMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long userId, System.IntPtr callbackData, Discord.ActivityManager.FFIMethods.AcceptInviteCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, long userId, System.IntPtr callbackData, Discord.ActivityManager.FFIMethods.AcceptInviteCallback callback)

### public class Discord.AchievementManager

#### Fields
- private System.IntPtr MethodsPtr
- private object MethodsStructure
- private Discord.AchievementManager.UserAchievementUpdateHandler OnUserAchievementUpdate

#### Properties
- private Discord.AchievementManager.FFIMethods Methods { get; }

#### Events
- public event Discord.AchievementManager.UserAchievementUpdateHandler OnUserAchievementUpdate

#### Constructors
- internal AchievementManager(System.IntPtr ptr, System.IntPtr eventsPtr, ref Discord.AchievementManager.FFIEvents events)

#### Methods
- public int CountUserAchievements()
- public void FetchUserAchievements(Discord.AchievementManager.FetchUserAchievementsHandler callback)
- private static void FetchUserAchievementsCallbackImpl(System.IntPtr ptr, Discord.Result result)
- public Discord.UserAchievement GetUserAchievement(long userAchievementId)
- public Discord.UserAchievement GetUserAchievementAt(int index)
- private void InitEvents(System.IntPtr eventsPtr, ref Discord.AchievementManager.FFIEvents events)
- private static void OnUserAchievementUpdateImpl(System.IntPtr ptr, ref Discord.UserAchievement userAchievement)
- public void SetUserAchievement(long achievementId, byte percentComplete, Discord.AchievementManager.SetUserAchievementHandler callback)
- private static void SetUserAchievementCallbackImpl(System.IntPtr ptr, Discord.Result result)

### public struct Discord.Activity

#### Fields
- public long ApplicationId
- public Discord.ActivityAssets Assets
- public string Details
- public bool Instance
- public string Name
- public Discord.ActivityParty Party
- public Discord.ActivitySecrets Secrets
- public string State
- public Discord.ActivityTimestamps Timestamps
- public Discord.ActivityType Type

### public enum Discord.ActivityActionType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Join = 1
- Spectate = 2

### public struct Discord.ActivityAssets

#### Fields
- public string LargeImage
- public string LargeText
- public string SmallImage
- public string SmallText

### public delegate Discord.ActivityManager.ActivityInviteHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.ActivityInviteHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.ActivityActionType type, ref Discord.User user, ref Discord.Activity activity, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref Discord.User user, ref Discord.Activity activity, System.IAsyncResult result)
- public virtual void Invoke(Discord.ActivityActionType type, ref Discord.User user, ref Discord.Activity activity)

### internal delegate Discord.ActivityManager.FFIEvents.ActivityInviteHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.FFIEvents.ActivityInviteHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.ActivityActionType type, ref Discord.User user, ref Discord.Activity activity, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref Discord.User user, ref Discord.Activity activity, System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.ActivityActionType type, ref Discord.User user, ref Discord.Activity activity)

### public delegate Discord.ActivityManager.ActivityJoinHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.ActivityJoinHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(string secret, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(string secret)

### internal delegate Discord.ActivityManager.FFIEvents.ActivityJoinHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.FFIEvents.ActivityJoinHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, string secret, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, string secret)

### public delegate Discord.ActivityManager.ActivityJoinRequestHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.ActivityJoinRequestHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref Discord.User user, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref Discord.User user, System.IAsyncResult result)
- public virtual void Invoke(ref Discord.User user)

### internal delegate Discord.ActivityManager.FFIEvents.ActivityJoinRequestHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.FFIEvents.ActivityJoinRequestHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, ref Discord.User user, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref Discord.User user, System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, ref Discord.User user)

### public enum Discord.ActivityJoinRequestReply
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Ignore = 2
- No = 0
- Yes = 1

### public class Discord.ActivityManager

#### Fields
- private System.IntPtr MethodsPtr
- private object MethodsStructure
- private Discord.ActivityManager.ActivityInviteHandler OnActivityInvite
- private Discord.ActivityManager.ActivityJoinHandler OnActivityJoin
- private Discord.ActivityManager.ActivityJoinRequestHandler OnActivityJoinRequest
- private Discord.ActivityManager.ActivitySpectateHandler OnActivitySpectate

#### Properties
- private Discord.ActivityManager.FFIMethods Methods { get; }

#### Events
- public event Discord.ActivityManager.ActivityInviteHandler OnActivityInvite
- public event Discord.ActivityManager.ActivityJoinHandler OnActivityJoin
- public event Discord.ActivityManager.ActivityJoinRequestHandler OnActivityJoinRequest
- public event Discord.ActivityManager.ActivitySpectateHandler OnActivitySpectate

#### Constructors
- internal ActivityManager(System.IntPtr ptr, System.IntPtr eventsPtr, ref Discord.ActivityManager.FFIEvents events)

#### Methods
- public void AcceptInvite(long userId, Discord.ActivityManager.AcceptInviteHandler callback)
- private static void AcceptInviteCallbackImpl(System.IntPtr ptr, Discord.Result result)
- public void ClearActivity(Discord.ActivityManager.ClearActivityHandler callback)
- private static void ClearActivityCallbackImpl(System.IntPtr ptr, Discord.Result result)
- private void InitEvents(System.IntPtr eventsPtr, ref Discord.ActivityManager.FFIEvents events)
- private static void OnActivityInviteImpl(System.IntPtr ptr, Discord.ActivityActionType type, ref Discord.User user, ref Discord.Activity activity)
- private static void OnActivityJoinImpl(System.IntPtr ptr, string secret)
- private static void OnActivityJoinRequestImpl(System.IntPtr ptr, ref Discord.User user)
- private static void OnActivitySpectateImpl(System.IntPtr ptr, string secret)
- public void RegisterCommand()
- public void RegisterCommand(string command)
- public void RegisterSteam(uint steamId)
- public void SendInvite(long userId, Discord.ActivityActionType type, string content, Discord.ActivityManager.SendInviteHandler callback)
- private static void SendInviteCallbackImpl(System.IntPtr ptr, Discord.Result result)
- public void SendRequestReply(long userId, Discord.ActivityJoinRequestReply reply, Discord.ActivityManager.SendRequestReplyHandler callback)
- private static void SendRequestReplyCallbackImpl(System.IntPtr ptr, Discord.Result result)
- public void UpdateActivity(Discord.Activity activity, Discord.ActivityManager.UpdateActivityHandler callback)
- private static void UpdateActivityCallbackImpl(System.IntPtr ptr, Discord.Result result)

### public struct Discord.ActivityParty

#### Fields
- public string Id
- public Discord.PartySize Size

### public struct Discord.ActivitySecrets

#### Fields
- public string Join
- public string Match
- public string Spectate

### public delegate Discord.ActivityManager.ActivitySpectateHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.ActivitySpectateHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(string secret, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(string secret)

### internal delegate Discord.ActivityManager.FFIEvents.ActivitySpectateHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.FFIEvents.ActivitySpectateHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, string secret, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, string secret)

### public struct Discord.ActivityTimestamps

#### Fields
- public long End
- public long Start

### public enum Discord.ActivityType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Listening = 2
- Playing = 0
- Streaming = 1
- Watching = 3

### public class Discord.ApplicationManager

#### Fields
- private System.IntPtr MethodsPtr
- private object MethodsStructure

#### Properties
- private Discord.ApplicationManager.FFIMethods Methods { get; }

#### Constructors
- internal ApplicationManager(System.IntPtr ptr, System.IntPtr eventsPtr, ref Discord.ApplicationManager.FFIEvents events)

#### Methods
- public string GetCurrentBranch()
- public string GetCurrentLocale()
- public void GetOAuth2Token(Discord.ApplicationManager.GetOAuth2TokenHandler callback)
- private static void GetOAuth2TokenCallbackImpl(System.IntPtr ptr, Discord.Result result, ref Discord.OAuth2Token oauth2Token)
- public void GetTicket(Discord.ApplicationManager.GetTicketHandler callback)
- private static void GetTicketCallbackImpl(System.IntPtr ptr, Discord.Result result, ref string data)
- private void InitEvents(System.IntPtr eventsPtr, ref Discord.ApplicationManager.FFIEvents events)
- public void ValidateOrExit(Discord.ApplicationManager.ValidateOrExitHandler callback)
- private static void ValidateOrExitCallbackImpl(System.IntPtr ptr, Discord.Result result)

### internal delegate Discord.ActivityManager.FFIMethods.ClearActivityCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.FFIMethods.ClearActivityCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.ActivityManager.ClearActivityHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.ClearActivityHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.ActivityManager.FFIMethods.ClearActivityMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.FFIMethods.ClearActivityMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, System.IntPtr callbackData, Discord.ActivityManager.FFIMethods.ClearActivityCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, System.IntPtr callbackData, Discord.ActivityManager.FFIMethods.ClearActivityCallback callback)

### internal delegate Discord.NetworkManager.FFIMethods.CloseChannelMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public NetworkManager.FFIMethods.CloseChannelMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, ulong peerId, byte channelId, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, ulong peerId, byte channelId)

### internal delegate Discord.NetworkManager.FFIMethods.ClosePeerMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public NetworkManager.FFIMethods.ClosePeerMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, ulong peerId, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, ulong peerId)

### internal delegate Discord.LobbyManager.FFIMethods.ConnectLobbyCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.ConnectLobbyCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, ref Discord.Lobby lobby, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref Discord.Lobby lobby, System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result, ref Discord.Lobby lobby)

### public delegate Discord.LobbyManager.ConnectLobbyHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.ConnectLobbyHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, ref Discord.Lobby lobby, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref Discord.Lobby lobby, System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result, ref Discord.Lobby lobby)

### internal delegate Discord.LobbyManager.FFIMethods.ConnectLobbyMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.ConnectLobbyMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, string secret, System.IntPtr callbackData, Discord.LobbyManager.FFIMethods.ConnectLobbyCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, long lobbyId, string secret, System.IntPtr callbackData, Discord.LobbyManager.FFIMethods.ConnectLobbyCallback callback)

### internal delegate Discord.LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, ref Discord.Lobby lobby, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref Discord.Lobby lobby, System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result, ref Discord.Lobby lobby)

### public delegate Discord.LobbyManager.ConnectLobbyWithActivitySecretHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.ConnectLobbyWithActivitySecretHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, ref Discord.Lobby lobby, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref Discord.Lobby lobby, System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result, ref Discord.Lobby lobby)

### internal delegate Discord.LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, string activitySecret, System.IntPtr callbackData, Discord.LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, string activitySecret, System.IntPtr callbackData, Discord.LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback callback)

### internal delegate Discord.LobbyManager.FFIMethods.ConnectNetworkMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.ConnectNetworkMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long lobbyId)

### internal delegate Discord.LobbyManager.FFIMethods.ConnectVoiceCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.ConnectVoiceCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.LobbyManager.ConnectVoiceHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.ConnectVoiceHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.LobbyManager.FFIMethods.ConnectVoiceMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.ConnectVoiceMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, System.IntPtr callbackData, Discord.LobbyManager.FFIMethods.ConnectVoiceCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, long lobbyId, System.IntPtr callbackData, Discord.LobbyManager.FFIMethods.ConnectVoiceCallback callback)

### internal static class Discord.Constants

#### Fields
- public static const string DllName

### internal delegate Discord.StoreManager.FFIMethods.CountEntitlementsMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StoreManager.FFIMethods.CountEntitlementsMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, ref int count, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref int count, System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, ref int count)

### internal delegate Discord.RelationshipManager.FFIMethods.CountMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public RelationshipManager.FFIMethods.CountMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, ref int count, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref int count, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, ref int count)

### internal delegate Discord.StorageManager.FFIMethods.CountMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StorageManager.FFIMethods.CountMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, ref int count, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref int count, System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, ref int count)

### internal delegate Discord.StoreManager.FFIMethods.CountSkusMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StoreManager.FFIMethods.CountSkusMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, ref int count, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref int count, System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, ref int count)

### internal delegate Discord.AchievementManager.FFIMethods.CountUserAchievementsMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public AchievementManager.FFIMethods.CountUserAchievementsMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, ref int count, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref int count, System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, ref int count)

### public enum Discord.CreateFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Default = 0
- NoRequireDiscord = 1

### internal delegate Discord.LobbyManager.FFIMethods.CreateLobbyCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.CreateLobbyCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, ref Discord.Lobby lobby, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref Discord.Lobby lobby, System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result, ref Discord.Lobby lobby)

### public delegate Discord.LobbyManager.CreateLobbyHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.CreateLobbyHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, ref Discord.Lobby lobby, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref Discord.Lobby lobby, System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result, ref Discord.Lobby lobby)

### internal delegate Discord.LobbyManager.FFIMethods.CreateLobbyMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.CreateLobbyMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, System.IntPtr transaction, System.IntPtr callbackData, Discord.LobbyManager.FFIMethods.CreateLobbyCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, System.IntPtr transaction, System.IntPtr callbackData, Discord.LobbyManager.FFIMethods.CreateLobbyCallback callback)

### internal delegate Discord.UserManager.FFIMethods.CurrentUserHasFlagMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public UserManager.FFIMethods.CurrentUserHasFlagMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, Discord.UserFlag flag, ref bool hasFlag, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref bool hasFlag, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, Discord.UserFlag flag, ref bool hasFlag)

### public delegate Discord.UserManager.CurrentUserUpdateHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public UserManager.CurrentUserUpdateHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke()

### internal delegate Discord.UserManager.FFIEvents.CurrentUserUpdateHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public UserManager.FFIEvents.CurrentUserUpdateHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr)

### internal delegate Discord.LobbyManager.FFIMethods.DeleteLobbyCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.DeleteLobbyCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.LobbyManager.DeleteLobbyHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.DeleteLobbyHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.LobbyManager.FFIMethods.DeleteLobbyMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.DeleteLobbyMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, System.IntPtr callbackData, Discord.LobbyManager.FFIMethods.DeleteLobbyCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, long lobbyId, System.IntPtr callbackData, Discord.LobbyManager.FFIMethods.DeleteLobbyCallback callback)

### internal delegate Discord.LobbyTransaction.FFIMethods.DeleteMetadataMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyTransaction.FFIMethods.DeleteMetadataMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, string key, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, string key)

### internal delegate Discord.LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, string key, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, string key)

### internal delegate Discord.StorageManager.FFIMethods.DeleteMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StorageManager.FFIMethods.DeleteMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, string name, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, string name)

### internal delegate Discord.Discord.FFIMethods.DestroyHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Discord.FFIMethods.DestroyHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr MethodsPtr, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr MethodsPtr)

### internal delegate Discord.LobbyManager.FFIMethods.DisconnectLobbyCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.DisconnectLobbyCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.LobbyManager.DisconnectLobbyHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.DisconnectLobbyHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.LobbyManager.FFIMethods.DisconnectLobbyMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.DisconnectLobbyMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, System.IntPtr callbackData, Discord.LobbyManager.FFIMethods.DisconnectLobbyCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, long lobbyId, System.IntPtr callbackData, Discord.LobbyManager.FFIMethods.DisconnectLobbyCallback callback)

### internal delegate Discord.LobbyManager.FFIMethods.DisconnectNetworkMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.DisconnectNetworkMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long lobbyId)

### internal delegate Discord.LobbyManager.FFIMethods.DisconnectVoiceCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.DisconnectVoiceCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.LobbyManager.DisconnectVoiceHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.DisconnectVoiceHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.LobbyManager.FFIMethods.DisconnectVoiceMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.DisconnectVoiceMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, System.IntPtr callbackData, Discord.LobbyManager.FFIMethods.DisconnectVoiceCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, long lobbyId, System.IntPtr callbackData, Discord.LobbyManager.FFIMethods.DisconnectVoiceCallback callback)

### public class Discord.Discord
- Interfaces: System.IDisposable

#### Fields
- private Discord.AchievementManager.FFIEvents AchievementEvents
- private System.IntPtr AchievementEventsPtr
- internal Discord.AchievementManager AchievementManagerInstance
- private Discord.ActivityManager.FFIEvents ActivityEvents
- private System.IntPtr ActivityEventsPtr
- internal Discord.ActivityManager ActivityManagerInstance
- private Discord.ApplicationManager.FFIEvents ApplicationEvents
- private System.IntPtr ApplicationEventsPtr
- internal Discord.ApplicationManager ApplicationManagerInstance
- private Discord.Discord.FFIEvents Events
- private System.IntPtr EventsPtr
- private Discord.ImageManager.FFIEvents ImageEvents
- private System.IntPtr ImageEventsPtr
- internal Discord.ImageManager ImageManagerInstance
- private Discord.LobbyManager.FFIEvents LobbyEvents
- private System.IntPtr LobbyEventsPtr
- internal Discord.LobbyManager LobbyManagerInstance
- private System.IntPtr MethodsPtr
- private object MethodsStructure
- private Discord.NetworkManager.FFIEvents NetworkEvents
- private System.IntPtr NetworkEventsPtr
- internal Discord.NetworkManager NetworkManagerInstance
- private Discord.OverlayManager.FFIEvents OverlayEvents
- private System.IntPtr OverlayEventsPtr
- internal Discord.OverlayManager OverlayManagerInstance
- private Discord.RelationshipManager.FFIEvents RelationshipEvents
- private System.IntPtr RelationshipEventsPtr
- internal Discord.RelationshipManager RelationshipManagerInstance
- private System.Runtime.InteropServices.GCHandle SelfHandle
- private System.Nullable<System.Runtime.InteropServices.GCHandle> setLogHook
- private Discord.StorageManager.FFIEvents StorageEvents
- private System.IntPtr StorageEventsPtr
- internal Discord.StorageManager StorageManagerInstance
- private Discord.StoreManager.FFIEvents StoreEvents
- private System.IntPtr StoreEventsPtr
- internal Discord.StoreManager StoreManagerInstance
- private Discord.UserManager.FFIEvents UserEvents
- private System.IntPtr UserEventsPtr
- internal Discord.UserManager UserManagerInstance
- private Discord.VoiceManager.FFIEvents VoiceEvents
- private System.IntPtr VoiceEventsPtr
- internal Discord.VoiceManager VoiceManagerInstance

#### Properties
- private Discord.Discord.FFIMethods Methods { get; }

#### Constructors
- public Discord(long clientId, ulong flags)

#### Methods
- private static Discord.Result DiscordCreate(uint version, ref Discord.Discord.FFICreateParams createParams, out System.IntPtr manager)
- public void Dispose()
- public Discord.AchievementManager GetAchievementManager()
- public Discord.ActivityManager GetActivityManager()
- public Discord.ApplicationManager GetApplicationManager()
- public Discord.ImageManager GetImageManager()
- public Discord.LobbyManager GetLobbyManager()
- public Discord.NetworkManager GetNetworkManager()
- public Discord.OverlayManager GetOverlayManager()
- public Discord.RelationshipManager GetRelationshipManager()
- public Discord.StorageManager GetStorageManager()
- public Discord.StoreManager GetStoreManager()
- public Discord.UserManager GetUserManager()
- public Discord.VoiceManager GetVoiceManager()
- private void InitEvents(System.IntPtr eventsPtr, ref Discord.Discord.FFIEvents events)
- public void RunCallbacks()
- public void SetLogHook(Discord.LogLevel minLevel, Discord.Discord.SetLogHookHandler callback)
- private static void SetLogHookCallbackImpl(System.IntPtr ptr, Discord.LogLevel level, string message)

### internal delegate Discord.LobbySearchQuery.FFIMethods.DistanceMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbySearchQuery.FFIMethods.DistanceMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, Discord.LobbySearchDistance distance, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, Discord.LobbySearchDistance distance)

### public struct Discord.Entitlement

#### Fields
- public long Id
- public long SkuId
- public Discord.EntitlementType Type

### public delegate Discord.StoreManager.EntitlementCreateHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StoreManager.EntitlementCreateHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref Discord.Entitlement entitlement, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref Discord.Entitlement entitlement, System.IAsyncResult result)
- public virtual void Invoke(ref Discord.Entitlement entitlement)

### internal delegate Discord.StoreManager.FFIEvents.EntitlementCreateHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StoreManager.FFIEvents.EntitlementCreateHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, ref Discord.Entitlement entitlement, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref Discord.Entitlement entitlement, System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, ref Discord.Entitlement entitlement)

### public delegate Discord.StoreManager.EntitlementDeleteHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StoreManager.EntitlementDeleteHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref Discord.Entitlement entitlement, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref Discord.Entitlement entitlement, System.IAsyncResult result)
- public virtual void Invoke(ref Discord.Entitlement entitlement)

### internal delegate Discord.StoreManager.FFIEvents.EntitlementDeleteHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StoreManager.FFIEvents.EntitlementDeleteHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, ref Discord.Entitlement entitlement, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref Discord.Entitlement entitlement, System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, ref Discord.Entitlement entitlement)

### public enum Discord.EntitlementType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DeveloperGift = 3
- FreePurchase = 5
- PremiumPurchase = 7
- PremiumSubscription = 2
- Purchase = 1
- TestModePurchase = 4
- UserGift = 6

### internal delegate Discord.StorageManager.FFIMethods.ExistsMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StorageManager.FFIMethods.ExistsMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, string name, ref bool exists, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref bool exists, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, string name, ref bool exists)

### internal delegate Discord.ImageManager.FFIMethods.FetchCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ImageManager.FFIMethods.FetchCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, Discord.ImageHandle handleResult, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result, Discord.ImageHandle handleResult)

### internal delegate Discord.StoreManager.FFIMethods.FetchEntitlementsCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StoreManager.FFIMethods.FetchEntitlementsCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.StoreManager.FetchEntitlementsHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StoreManager.FetchEntitlementsHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.StoreManager.FFIMethods.FetchEntitlementsMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StoreManager.FFIMethods.FetchEntitlementsMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, System.IntPtr callbackData, Discord.StoreManager.FFIMethods.FetchEntitlementsCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, System.IntPtr callbackData, Discord.StoreManager.FFIMethods.FetchEntitlementsCallback callback)

### public delegate Discord.ImageManager.FetchHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ImageManager.FetchHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, Discord.ImageHandle handleResult, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result, Discord.ImageHandle handleResult)

### internal delegate Discord.ImageManager.FFIMethods.FetchMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ImageManager.FFIMethods.FetchMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, Discord.ImageHandle handle, bool refresh, System.IntPtr callbackData, Discord.ImageManager.FFIMethods.FetchCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, Discord.ImageHandle handle, bool refresh, System.IntPtr callbackData, Discord.ImageManager.FFIMethods.FetchCallback callback)

### internal delegate Discord.StoreManager.FFIMethods.FetchSkusCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StoreManager.FFIMethods.FetchSkusCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.StoreManager.FetchSkusHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StoreManager.FetchSkusHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.StoreManager.FFIMethods.FetchSkusMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StoreManager.FFIMethods.FetchSkusMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, System.IntPtr callbackData, Discord.StoreManager.FFIMethods.FetchSkusCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, System.IntPtr callbackData, Discord.StoreManager.FFIMethods.FetchSkusCallback callback)

### internal delegate Discord.AchievementManager.FFIMethods.FetchUserAchievementsCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public AchievementManager.FFIMethods.FetchUserAchievementsCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.AchievementManager.FetchUserAchievementsHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public AchievementManager.FetchUserAchievementsHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.AchievementManager.FFIMethods.FetchUserAchievementsMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public AchievementManager.FFIMethods.FetchUserAchievementsMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, System.IntPtr callbackData, Discord.AchievementManager.FFIMethods.FetchUserAchievementsCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, System.IntPtr callbackData, Discord.AchievementManager.FFIMethods.FetchUserAchievementsCallback callback)

### internal struct Discord.Discord.FFICreateParams

#### Fields
- internal System.IntPtr AchievementEvents
- internal uint AchievementVersion
- internal System.IntPtr ActivityEvents
- internal uint ActivityVersion
- internal System.IntPtr ApplicationEvents
- internal uint ApplicationVersion
- internal long ClientId
- internal System.IntPtr EventData
- internal System.IntPtr Events
- internal ulong Flags
- internal System.IntPtr ImageEvents
- internal uint ImageVersion
- internal System.IntPtr LobbyEvents
- internal uint LobbyVersion
- internal System.IntPtr NetworkEvents
- internal uint NetworkVersion
- internal System.IntPtr OverlayEvents
- internal uint OverlayVersion
- internal System.IntPtr RelationshipEvents
- internal uint RelationshipVersion
- internal System.IntPtr StorageEvents
- internal uint StorageVersion
- internal System.IntPtr StoreEvents
- internal uint StoreVersion
- internal System.IntPtr UserEvents
- internal uint UserVersion
- internal System.IntPtr VoiceEvents
- internal uint VoiceVersion

### internal struct Discord.ActivityManager.FFIEvents

#### Fields
- internal Discord.ActivityManager.FFIEvents.ActivityInviteHandler OnActivityInvite
- internal Discord.ActivityManager.FFIEvents.ActivityJoinHandler OnActivityJoin
- internal Discord.ActivityManager.FFIEvents.ActivityJoinRequestHandler OnActivityJoinRequest
- internal Discord.ActivityManager.FFIEvents.ActivitySpectateHandler OnActivitySpectate

### internal struct Discord.Discord.FFIEvents

### internal struct Discord.ApplicationManager.FFIEvents

### internal struct Discord.UserManager.FFIEvents

#### Fields
- internal Discord.UserManager.FFIEvents.CurrentUserUpdateHandler OnCurrentUserUpdate

### internal struct Discord.ImageManager.FFIEvents

### internal struct Discord.RelationshipManager.FFIEvents

#### Fields
- internal Discord.RelationshipManager.FFIEvents.RefreshHandler OnRefresh
- internal Discord.RelationshipManager.FFIEvents.RelationshipUpdateHandler OnRelationshipUpdate

### internal struct Discord.LobbyManager.FFIEvents

#### Fields
- internal Discord.LobbyManager.FFIEvents.LobbyDeleteHandler OnLobbyDelete
- internal Discord.LobbyManager.FFIEvents.LobbyMessageHandler OnLobbyMessage
- internal Discord.LobbyManager.FFIEvents.LobbyUpdateHandler OnLobbyUpdate
- internal Discord.LobbyManager.FFIEvents.MemberConnectHandler OnMemberConnect
- internal Discord.LobbyManager.FFIEvents.MemberDisconnectHandler OnMemberDisconnect
- internal Discord.LobbyManager.FFIEvents.MemberUpdateHandler OnMemberUpdate
- internal Discord.LobbyManager.FFIEvents.NetworkMessageHandler OnNetworkMessage
- internal Discord.LobbyManager.FFIEvents.SpeakingHandler OnSpeaking

### internal struct Discord.NetworkManager.FFIEvents

#### Fields
- internal Discord.NetworkManager.FFIEvents.MessageHandler OnMessage
- internal Discord.NetworkManager.FFIEvents.RouteUpdateHandler OnRouteUpdate

### internal struct Discord.OverlayManager.FFIEvents

#### Fields
- internal Discord.OverlayManager.FFIEvents.ToggleHandler OnToggle

### internal struct Discord.StorageManager.FFIEvents

### internal struct Discord.StoreManager.FFIEvents

#### Fields
- internal Discord.StoreManager.FFIEvents.EntitlementCreateHandler OnEntitlementCreate
- internal Discord.StoreManager.FFIEvents.EntitlementDeleteHandler OnEntitlementDelete

### internal struct Discord.VoiceManager.FFIEvents

#### Fields
- internal Discord.VoiceManager.FFIEvents.SettingsUpdateHandler OnSettingsUpdate

### internal struct Discord.AchievementManager.FFIEvents

#### Fields
- internal Discord.AchievementManager.FFIEvents.UserAchievementUpdateHandler OnUserAchievementUpdate

### internal struct Discord.ActivityManager.FFIMethods

#### Fields
- internal Discord.ActivityManager.FFIMethods.AcceptInviteMethod AcceptInvite
- internal Discord.ActivityManager.FFIMethods.ClearActivityMethod ClearActivity
- internal Discord.ActivityManager.FFIMethods.RegisterCommandMethod RegisterCommand
- internal Discord.ActivityManager.FFIMethods.RegisterSteamMethod RegisterSteam
- internal Discord.ActivityManager.FFIMethods.SendInviteMethod SendInvite
- internal Discord.ActivityManager.FFIMethods.SendRequestReplyMethod SendRequestReply
- internal Discord.ActivityManager.FFIMethods.UpdateActivityMethod UpdateActivity

### internal struct Discord.LobbyTransaction.FFIMethods

#### Fields
- internal Discord.LobbyTransaction.FFIMethods.DeleteMetadataMethod DeleteMetadata
- internal Discord.LobbyTransaction.FFIMethods.SetCapacityMethod SetCapacity
- internal Discord.LobbyTransaction.FFIMethods.SetLockedMethod SetLocked
- internal Discord.LobbyTransaction.FFIMethods.SetMetadataMethod SetMetadata
- internal Discord.LobbyTransaction.FFIMethods.SetOwnerMethod SetOwner
- internal Discord.LobbyTransaction.FFIMethods.SetTypeMethod SetType

### internal struct Discord.LobbyMemberTransaction.FFIMethods

#### Fields
- internal Discord.LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod DeleteMetadata
- internal Discord.LobbyMemberTransaction.FFIMethods.SetMetadataMethod SetMetadata

### internal struct Discord.LobbySearchQuery.FFIMethods

#### Fields
- internal Discord.LobbySearchQuery.FFIMethods.DistanceMethod Distance
- internal Discord.LobbySearchQuery.FFIMethods.FilterMethod Filter
- internal Discord.LobbySearchQuery.FFIMethods.LimitMethod Limit
- internal Discord.LobbySearchQuery.FFIMethods.SortMethod Sort

### internal struct Discord.Discord.FFIMethods

#### Fields
- internal Discord.Discord.FFIMethods.DestroyHandler Destroy
- internal Discord.Discord.FFIMethods.GetAchievementManagerMethod GetAchievementManager
- internal Discord.Discord.FFIMethods.GetActivityManagerMethod GetActivityManager
- internal Discord.Discord.FFIMethods.GetApplicationManagerMethod GetApplicationManager
- internal Discord.Discord.FFIMethods.GetImageManagerMethod GetImageManager
- internal Discord.Discord.FFIMethods.GetLobbyManagerMethod GetLobbyManager
- internal Discord.Discord.FFIMethods.GetNetworkManagerMethod GetNetworkManager
- internal Discord.Discord.FFIMethods.GetOverlayManagerMethod GetOverlayManager
- internal Discord.Discord.FFIMethods.GetRelationshipManagerMethod GetRelationshipManager
- internal Discord.Discord.FFIMethods.GetStorageManagerMethod GetStorageManager
- internal Discord.Discord.FFIMethods.GetStoreManagerMethod GetStoreManager
- internal Discord.Discord.FFIMethods.GetUserManagerMethod GetUserManager
- internal Discord.Discord.FFIMethods.GetVoiceManagerMethod GetVoiceManager
- internal Discord.Discord.FFIMethods.RunCallbacksMethod RunCallbacks
- internal Discord.Discord.FFIMethods.SetLogHookMethod SetLogHook

### internal struct Discord.ApplicationManager.FFIMethods

#### Fields
- internal Discord.ApplicationManager.FFIMethods.GetCurrentBranchMethod GetCurrentBranch
- internal Discord.ApplicationManager.FFIMethods.GetCurrentLocaleMethod GetCurrentLocale
- internal Discord.ApplicationManager.FFIMethods.GetOAuth2TokenMethod GetOAuth2Token
- internal Discord.ApplicationManager.FFIMethods.GetTicketMethod GetTicket
- internal Discord.ApplicationManager.FFIMethods.ValidateOrExitMethod ValidateOrExit

### internal struct Discord.UserManager.FFIMethods

#### Fields
- internal Discord.UserManager.FFIMethods.CurrentUserHasFlagMethod CurrentUserHasFlag
- internal Discord.UserManager.FFIMethods.GetCurrentUserMethod GetCurrentUser
- internal Discord.UserManager.FFIMethods.GetCurrentUserPremiumTypeMethod GetCurrentUserPremiumType
- internal Discord.UserManager.FFIMethods.GetUserMethod GetUser

### internal struct Discord.ImageManager.FFIMethods

#### Fields
- internal Discord.ImageManager.FFIMethods.FetchMethod Fetch
- internal Discord.ImageManager.FFIMethods.GetDataMethod GetData
- internal Discord.ImageManager.FFIMethods.GetDimensionsMethod GetDimensions

### internal struct Discord.RelationshipManager.FFIMethods

#### Fields
- internal Discord.RelationshipManager.FFIMethods.CountMethod Count
- internal Discord.RelationshipManager.FFIMethods.FilterMethod Filter
- internal Discord.RelationshipManager.FFIMethods.GetMethod Get
- internal Discord.RelationshipManager.FFIMethods.GetAtMethod GetAt

### internal struct Discord.LobbyManager.FFIMethods

#### Fields
- internal Discord.LobbyManager.FFIMethods.ConnectLobbyMethod ConnectLobby
- internal Discord.LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod ConnectLobbyWithActivitySecret
- internal Discord.LobbyManager.FFIMethods.ConnectNetworkMethod ConnectNetwork
- internal Discord.LobbyManager.FFIMethods.ConnectVoiceMethod ConnectVoice
- internal Discord.LobbyManager.FFIMethods.CreateLobbyMethod CreateLobby
- internal Discord.LobbyManager.FFIMethods.DeleteLobbyMethod DeleteLobby
- internal Discord.LobbyManager.FFIMethods.DisconnectLobbyMethod DisconnectLobby
- internal Discord.LobbyManager.FFIMethods.DisconnectNetworkMethod DisconnectNetwork
- internal Discord.LobbyManager.FFIMethods.DisconnectVoiceMethod DisconnectVoice
- internal Discord.LobbyManager.FFIMethods.FlushNetworkMethod FlushNetwork
- internal Discord.LobbyManager.FFIMethods.GetLobbyMethod GetLobby
- internal Discord.LobbyManager.FFIMethods.GetLobbyActivitySecretMethod GetLobbyActivitySecret
- internal Discord.LobbyManager.FFIMethods.GetLobbyCreateTransactionMethod GetLobbyCreateTransaction
- internal Discord.LobbyManager.FFIMethods.GetLobbyIdMethod GetLobbyId
- internal Discord.LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod GetLobbyMetadataKey
- internal Discord.LobbyManager.FFIMethods.GetLobbyMetadataValueMethod GetLobbyMetadataValue
- internal Discord.LobbyManager.FFIMethods.GetLobbyUpdateTransactionMethod GetLobbyUpdateTransaction
- internal Discord.LobbyManager.FFIMethods.GetMemberMetadataKeyMethod GetMemberMetadataKey
- internal Discord.LobbyManager.FFIMethods.GetMemberMetadataValueMethod GetMemberMetadataValue
- internal Discord.LobbyManager.FFIMethods.GetMemberUpdateTransactionMethod GetMemberUpdateTransaction
- internal Discord.LobbyManager.FFIMethods.GetMemberUserMethod GetMemberUser
- internal Discord.LobbyManager.FFIMethods.GetMemberUserIdMethod GetMemberUserId
- internal Discord.LobbyManager.FFIMethods.GetSearchQueryMethod GetSearchQuery
- internal Discord.LobbyManager.FFIMethods.LobbyCountMethod LobbyCount
- internal Discord.LobbyManager.FFIMethods.LobbyMetadataCountMethod LobbyMetadataCount
- internal Discord.LobbyManager.FFIMethods.MemberCountMethod MemberCount
- internal Discord.LobbyManager.FFIMethods.MemberMetadataCountMethod MemberMetadataCount
- internal Discord.LobbyManager.FFIMethods.OpenNetworkChannelMethod OpenNetworkChannel
- internal Discord.LobbyManager.FFIMethods.SearchMethod Search
- internal Discord.LobbyManager.FFIMethods.SendLobbyMessageMethod SendLobbyMessage
- internal Discord.LobbyManager.FFIMethods.SendNetworkMessageMethod SendNetworkMessage
- internal Discord.LobbyManager.FFIMethods.UpdateLobbyMethod UpdateLobby
- internal Discord.LobbyManager.FFIMethods.UpdateMemberMethod UpdateMember

### internal struct Discord.NetworkManager.FFIMethods

#### Fields
- internal Discord.NetworkManager.FFIMethods.CloseChannelMethod CloseChannel
- internal Discord.NetworkManager.FFIMethods.ClosePeerMethod ClosePeer
- internal Discord.NetworkManager.FFIMethods.FlushMethod Flush
- internal Discord.NetworkManager.FFIMethods.GetPeerIdMethod GetPeerId
- internal Discord.NetworkManager.FFIMethods.OpenChannelMethod OpenChannel
- internal Discord.NetworkManager.FFIMethods.OpenPeerMethod OpenPeer
- internal Discord.NetworkManager.FFIMethods.SendMessageMethod SendMessage
- internal Discord.NetworkManager.FFIMethods.UpdatePeerMethod UpdatePeer

### internal struct Discord.OverlayManager.FFIMethods

#### Fields
- internal Discord.OverlayManager.FFIMethods.IsEnabledMethod IsEnabled
- internal Discord.OverlayManager.FFIMethods.IsLockedMethod IsLocked
- internal Discord.OverlayManager.FFIMethods.OpenActivityInviteMethod OpenActivityInvite
- internal Discord.OverlayManager.FFIMethods.OpenGuildInviteMethod OpenGuildInvite
- internal Discord.OverlayManager.FFIMethods.OpenVoiceSettingsMethod OpenVoiceSettings
- internal Discord.OverlayManager.FFIMethods.SetLockedMethod SetLocked

### internal struct Discord.StorageManager.FFIMethods

#### Fields
- internal Discord.StorageManager.FFIMethods.CountMethod Count
- internal Discord.StorageManager.FFIMethods.DeleteMethod Delete
- internal Discord.StorageManager.FFIMethods.ExistsMethod Exists
- internal Discord.StorageManager.FFIMethods.GetPathMethod GetPath
- internal Discord.StorageManager.FFIMethods.ReadMethod Read
- internal Discord.StorageManager.FFIMethods.ReadAsyncMethod ReadAsync
- internal Discord.StorageManager.FFIMethods.ReadAsyncPartialMethod ReadAsyncPartial
- internal Discord.StorageManager.FFIMethods.StatMethod Stat
- internal Discord.StorageManager.FFIMethods.StatAtMethod StatAt
- internal Discord.StorageManager.FFIMethods.WriteMethod Write
- internal Discord.StorageManager.FFIMethods.WriteAsyncMethod WriteAsync

### internal struct Discord.StoreManager.FFIMethods

#### Fields
- internal Discord.StoreManager.FFIMethods.CountEntitlementsMethod CountEntitlements
- internal Discord.StoreManager.FFIMethods.CountSkusMethod CountSkus
- internal Discord.StoreManager.FFIMethods.FetchEntitlementsMethod FetchEntitlements
- internal Discord.StoreManager.FFIMethods.FetchSkusMethod FetchSkus
- internal Discord.StoreManager.FFIMethods.GetEntitlementMethod GetEntitlement
- internal Discord.StoreManager.FFIMethods.GetEntitlementAtMethod GetEntitlementAt
- internal Discord.StoreManager.FFIMethods.GetSkuMethod GetSku
- internal Discord.StoreManager.FFIMethods.GetSkuAtMethod GetSkuAt
- internal Discord.StoreManager.FFIMethods.HasSkuEntitlementMethod HasSkuEntitlement
- internal Discord.StoreManager.FFIMethods.StartPurchaseMethod StartPurchase

### internal struct Discord.VoiceManager.FFIMethods

#### Fields
- internal Discord.VoiceManager.FFIMethods.GetInputModeMethod GetInputMode
- internal Discord.VoiceManager.FFIMethods.GetLocalVolumeMethod GetLocalVolume
- internal Discord.VoiceManager.FFIMethods.IsLocalMuteMethod IsLocalMute
- internal Discord.VoiceManager.FFIMethods.IsSelfDeafMethod IsSelfDeaf
- internal Discord.VoiceManager.FFIMethods.IsSelfMuteMethod IsSelfMute
- internal Discord.VoiceManager.FFIMethods.SetInputModeMethod SetInputMode
- internal Discord.VoiceManager.FFIMethods.SetLocalMuteMethod SetLocalMute
- internal Discord.VoiceManager.FFIMethods.SetLocalVolumeMethod SetLocalVolume
- internal Discord.VoiceManager.FFIMethods.SetSelfDeafMethod SetSelfDeaf
- internal Discord.VoiceManager.FFIMethods.SetSelfMuteMethod SetSelfMute

### internal struct Discord.AchievementManager.FFIMethods

#### Fields
- internal Discord.AchievementManager.FFIMethods.CountUserAchievementsMethod CountUserAchievements
- internal Discord.AchievementManager.FFIMethods.FetchUserAchievementsMethod FetchUserAchievements
- internal Discord.AchievementManager.FFIMethods.GetUserAchievementMethod GetUserAchievement
- internal Discord.AchievementManager.FFIMethods.GetUserAchievementAtMethod GetUserAchievementAt
- internal Discord.AchievementManager.FFIMethods.SetUserAchievementMethod SetUserAchievement

### public struct Discord.FileStat

#### Fields
- public string Filename
- public ulong LastModified
- public ulong Size

### internal delegate Discord.RelationshipManager.FFIMethods.FilterCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public RelationshipManager.FFIMethods.FilterCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, ref Discord.Relationship relationship, System.AsyncCallback callback, object object)
- public virtual bool EndInvoke(ref Discord.Relationship relationship, System.IAsyncResult result)
- public virtual bool Invoke(System.IntPtr ptr, ref Discord.Relationship relationship)

### public delegate Discord.RelationshipManager.FilterHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public RelationshipManager.FilterHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref Discord.Relationship relationship, System.AsyncCallback callback, object object)
- public virtual bool EndInvoke(ref Discord.Relationship relationship, System.IAsyncResult result)
- public virtual bool Invoke(ref Discord.Relationship relationship)

### internal delegate Discord.LobbySearchQuery.FFIMethods.FilterMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbySearchQuery.FFIMethods.FilterMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, string key, Discord.LobbySearchComparison comparison, Discord.LobbySearchCast cast, string value, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, string key, Discord.LobbySearchComparison comparison, Discord.LobbySearchCast cast, string value)

### internal delegate Discord.RelationshipManager.FFIMethods.FilterMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public RelationshipManager.FFIMethods.FilterMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, System.IntPtr callbackData, Discord.RelationshipManager.FFIMethods.FilterCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, System.IntPtr callbackData, Discord.RelationshipManager.FFIMethods.FilterCallback callback)

### internal delegate Discord.NetworkManager.FFIMethods.FlushMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public NetworkManager.FFIMethods.FlushMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr)

### internal delegate Discord.LobbyManager.FFIMethods.FlushNetworkMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.FlushNetworkMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr)

### internal delegate Discord.Discord.FFIMethods.GetAchievementManagerMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Discord.FFIMethods.GetAchievementManagerMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr discordPtr, System.AsyncCallback callback, object object)
- public virtual System.IntPtr EndInvoke(System.IAsyncResult result)
- public virtual System.IntPtr Invoke(System.IntPtr discordPtr)

### internal delegate Discord.Discord.FFIMethods.GetActivityManagerMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Discord.FFIMethods.GetActivityManagerMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr discordPtr, System.AsyncCallback callback, object object)
- public virtual System.IntPtr EndInvoke(System.IAsyncResult result)
- public virtual System.IntPtr Invoke(System.IntPtr discordPtr)

### internal delegate Discord.Discord.FFIMethods.GetApplicationManagerMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Discord.FFIMethods.GetApplicationManagerMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr discordPtr, System.AsyncCallback callback, object object)
- public virtual System.IntPtr EndInvoke(System.IAsyncResult result)
- public virtual System.IntPtr Invoke(System.IntPtr discordPtr)

### internal delegate Discord.RelationshipManager.FFIMethods.GetAtMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public RelationshipManager.FFIMethods.GetAtMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, uint index, ref Discord.Relationship relationship, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref Discord.Relationship relationship, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, uint index, ref Discord.Relationship relationship)

### internal delegate Discord.ApplicationManager.FFIMethods.GetCurrentBranchMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ApplicationManager.FFIMethods.GetCurrentBranchMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, System.Text.StringBuilder branch, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, System.Text.StringBuilder branch)

### internal delegate Discord.ApplicationManager.FFIMethods.GetCurrentLocaleMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ApplicationManager.FFIMethods.GetCurrentLocaleMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, System.Text.StringBuilder locale, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, System.Text.StringBuilder locale)

### internal delegate Discord.UserManager.FFIMethods.GetCurrentUserMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public UserManager.FFIMethods.GetCurrentUserMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, ref Discord.User currentUser, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref Discord.User currentUser, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, ref Discord.User currentUser)

### internal delegate Discord.UserManager.FFIMethods.GetCurrentUserPremiumTypeMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public UserManager.FFIMethods.GetCurrentUserPremiumTypeMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, ref Discord.PremiumType premiumType, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref Discord.PremiumType premiumType, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, ref Discord.PremiumType premiumType)

### internal delegate Discord.ImageManager.FFIMethods.GetDataMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ImageManager.FFIMethods.GetDataMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, Discord.ImageHandle handle, byte[] data, int dataLen, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, Discord.ImageHandle handle, byte[] data, int dataLen)

### internal delegate Discord.ImageManager.FFIMethods.GetDimensionsMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ImageManager.FFIMethods.GetDimensionsMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, Discord.ImageHandle handle, ref Discord.ImageDimensions dimensions, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref Discord.ImageDimensions dimensions, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, Discord.ImageHandle handle, ref Discord.ImageDimensions dimensions)

### internal delegate Discord.StoreManager.FFIMethods.GetEntitlementAtMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StoreManager.FFIMethods.GetEntitlementAtMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, int index, ref Discord.Entitlement entitlement, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref Discord.Entitlement entitlement, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, int index, ref Discord.Entitlement entitlement)

### internal delegate Discord.StoreManager.FFIMethods.GetEntitlementMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StoreManager.FFIMethods.GetEntitlementMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long entitlementId, ref Discord.Entitlement entitlement, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref Discord.Entitlement entitlement, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long entitlementId, ref Discord.Entitlement entitlement)

### internal delegate Discord.Discord.FFIMethods.GetImageManagerMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Discord.FFIMethods.GetImageManagerMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr discordPtr, System.AsyncCallback callback, object object)
- public virtual System.IntPtr EndInvoke(System.IAsyncResult result)
- public virtual System.IntPtr Invoke(System.IntPtr discordPtr)

### internal delegate Discord.VoiceManager.FFIMethods.GetInputModeMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public VoiceManager.FFIMethods.GetInputModeMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, ref Discord.InputMode inputMode, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref Discord.InputMode inputMode, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, ref Discord.InputMode inputMode)

### internal delegate Discord.LobbyManager.FFIMethods.GetLobbyActivitySecretMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.GetLobbyActivitySecretMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, System.Text.StringBuilder secret, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long lobbyId, System.Text.StringBuilder secret)

### internal delegate Discord.LobbyManager.FFIMethods.GetLobbyCreateTransactionMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.GetLobbyCreateTransactionMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, ref System.IntPtr transaction, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref System.IntPtr transaction, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, ref System.IntPtr transaction)

### internal delegate Discord.LobbyManager.FFIMethods.GetLobbyIdMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.GetLobbyIdMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, int index, ref long lobbyId, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref long lobbyId, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, int index, ref long lobbyId)

### internal delegate Discord.Discord.FFIMethods.GetLobbyManagerMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Discord.FFIMethods.GetLobbyManagerMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr discordPtr, System.AsyncCallback callback, object object)
- public virtual System.IntPtr EndInvoke(System.IAsyncResult result)
- public virtual System.IntPtr Invoke(System.IntPtr discordPtr)

### internal delegate Discord.LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, int index, System.Text.StringBuilder key, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long lobbyId, int index, System.Text.StringBuilder key)

### internal delegate Discord.LobbyManager.FFIMethods.GetLobbyMetadataValueMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.GetLobbyMetadataValueMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, string key, System.Text.StringBuilder value, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long lobbyId, string key, System.Text.StringBuilder value)

### internal delegate Discord.LobbyManager.FFIMethods.GetLobbyMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.GetLobbyMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, ref Discord.Lobby lobby, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref Discord.Lobby lobby, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long lobbyId, ref Discord.Lobby lobby)

### internal delegate Discord.LobbyManager.FFIMethods.GetLobbyUpdateTransactionMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.GetLobbyUpdateTransactionMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, ref System.IntPtr transaction, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref System.IntPtr transaction, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long lobbyId, ref System.IntPtr transaction)

### internal delegate Discord.VoiceManager.FFIMethods.GetLocalVolumeMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public VoiceManager.FFIMethods.GetLocalVolumeMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long userId, ref byte volume, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref byte volume, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long userId, ref byte volume)

### internal delegate Discord.LobbyManager.FFIMethods.GetMemberMetadataKeyMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.GetMemberMetadataKeyMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, long userId, int index, System.Text.StringBuilder key, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long lobbyId, long userId, int index, System.Text.StringBuilder key)

### internal delegate Discord.LobbyManager.FFIMethods.GetMemberMetadataValueMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.GetMemberMetadataValueMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, long userId, string key, System.Text.StringBuilder value, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long lobbyId, long userId, string key, System.Text.StringBuilder value)

### internal delegate Discord.LobbyManager.FFIMethods.GetMemberUpdateTransactionMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.GetMemberUpdateTransactionMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, long userId, ref System.IntPtr transaction, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref System.IntPtr transaction, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long lobbyId, long userId, ref System.IntPtr transaction)

### internal delegate Discord.LobbyManager.FFIMethods.GetMemberUserIdMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.GetMemberUserIdMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, int index, ref long userId, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref long userId, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long lobbyId, int index, ref long userId)

### internal delegate Discord.LobbyManager.FFIMethods.GetMemberUserMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.GetMemberUserMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, long userId, ref Discord.User user, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref Discord.User user, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long lobbyId, long userId, ref Discord.User user)

### internal delegate Discord.RelationshipManager.FFIMethods.GetMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public RelationshipManager.FFIMethods.GetMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long userId, ref Discord.Relationship relationship, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref Discord.Relationship relationship, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long userId, ref Discord.Relationship relationship)

### internal delegate Discord.Discord.FFIMethods.GetNetworkManagerMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Discord.FFIMethods.GetNetworkManagerMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr discordPtr, System.AsyncCallback callback, object object)
- public virtual System.IntPtr EndInvoke(System.IAsyncResult result)
- public virtual System.IntPtr Invoke(System.IntPtr discordPtr)

### internal delegate Discord.ApplicationManager.FFIMethods.GetOAuth2TokenCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ApplicationManager.FFIMethods.GetOAuth2TokenCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, ref Discord.OAuth2Token oauth2Token, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref Discord.OAuth2Token oauth2Token, System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result, ref Discord.OAuth2Token oauth2Token)

### public delegate Discord.ApplicationManager.GetOAuth2TokenHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ApplicationManager.GetOAuth2TokenHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, ref Discord.OAuth2Token oauth2Token, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref Discord.OAuth2Token oauth2Token, System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result, ref Discord.OAuth2Token oauth2Token)

### internal delegate Discord.ApplicationManager.FFIMethods.GetOAuth2TokenMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ApplicationManager.FFIMethods.GetOAuth2TokenMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, System.IntPtr callbackData, Discord.ApplicationManager.FFIMethods.GetOAuth2TokenCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, System.IntPtr callbackData, Discord.ApplicationManager.FFIMethods.GetOAuth2TokenCallback callback)

### internal delegate Discord.Discord.FFIMethods.GetOverlayManagerMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Discord.FFIMethods.GetOverlayManagerMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr discordPtr, System.AsyncCallback callback, object object)
- public virtual System.IntPtr EndInvoke(System.IAsyncResult result)
- public virtual System.IntPtr Invoke(System.IntPtr discordPtr)

### internal delegate Discord.StorageManager.FFIMethods.GetPathMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StorageManager.FFIMethods.GetPathMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, System.Text.StringBuilder path, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, System.Text.StringBuilder path)

### internal delegate Discord.NetworkManager.FFIMethods.GetPeerIdMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public NetworkManager.FFIMethods.GetPeerIdMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, ref ulong peerId, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref ulong peerId, System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, ref ulong peerId)

### internal delegate Discord.Discord.FFIMethods.GetRelationshipManagerMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Discord.FFIMethods.GetRelationshipManagerMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr discordPtr, System.AsyncCallback callback, object object)
- public virtual System.IntPtr EndInvoke(System.IAsyncResult result)
- public virtual System.IntPtr Invoke(System.IntPtr discordPtr)

### internal delegate Discord.LobbyManager.FFIMethods.GetSearchQueryMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.GetSearchQueryMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, ref System.IntPtr query, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref System.IntPtr query, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, ref System.IntPtr query)

### internal delegate Discord.StoreManager.FFIMethods.GetSkuAtMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StoreManager.FFIMethods.GetSkuAtMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, int index, ref Discord.Sku sku, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref Discord.Sku sku, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, int index, ref Discord.Sku sku)

### internal delegate Discord.StoreManager.FFIMethods.GetSkuMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StoreManager.FFIMethods.GetSkuMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long skuId, ref Discord.Sku sku, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref Discord.Sku sku, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long skuId, ref Discord.Sku sku)

### internal delegate Discord.Discord.FFIMethods.GetStorageManagerMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Discord.FFIMethods.GetStorageManagerMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr discordPtr, System.AsyncCallback callback, object object)
- public virtual System.IntPtr EndInvoke(System.IAsyncResult result)
- public virtual System.IntPtr Invoke(System.IntPtr discordPtr)

### internal delegate Discord.Discord.FFIMethods.GetStoreManagerMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Discord.FFIMethods.GetStoreManagerMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr discordPtr, System.AsyncCallback callback, object object)
- public virtual System.IntPtr EndInvoke(System.IAsyncResult result)
- public virtual System.IntPtr Invoke(System.IntPtr discordPtr)

### internal delegate Discord.ApplicationManager.FFIMethods.GetTicketCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ApplicationManager.FFIMethods.GetTicketCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, ref string data, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref string data, System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result, ref string data)

### public delegate Discord.ApplicationManager.GetTicketHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ApplicationManager.GetTicketHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, ref string data, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref string data, System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result, ref string data)

### internal delegate Discord.ApplicationManager.FFIMethods.GetTicketMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ApplicationManager.FFIMethods.GetTicketMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, System.IntPtr callbackData, Discord.ApplicationManager.FFIMethods.GetTicketCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, System.IntPtr callbackData, Discord.ApplicationManager.FFIMethods.GetTicketCallback callback)

### internal delegate Discord.AchievementManager.FFIMethods.GetUserAchievementAtMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public AchievementManager.FFIMethods.GetUserAchievementAtMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, int index, ref Discord.UserAchievement userAchievement, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref Discord.UserAchievement userAchievement, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, int index, ref Discord.UserAchievement userAchievement)

### internal delegate Discord.AchievementManager.FFIMethods.GetUserAchievementMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public AchievementManager.FFIMethods.GetUserAchievementMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long userAchievementId, ref Discord.UserAchievement userAchievement, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref Discord.UserAchievement userAchievement, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long userAchievementId, ref Discord.UserAchievement userAchievement)

### internal delegate Discord.UserManager.FFIMethods.GetUserCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public UserManager.FFIMethods.GetUserCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, ref Discord.User user, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref Discord.User user, System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result, ref Discord.User user)

### public delegate Discord.UserManager.GetUserHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public UserManager.GetUserHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, ref Discord.User user, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref Discord.User user, System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result, ref Discord.User user)

### internal delegate Discord.Discord.FFIMethods.GetUserManagerMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Discord.FFIMethods.GetUserManagerMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr discordPtr, System.AsyncCallback callback, object object)
- public virtual System.IntPtr EndInvoke(System.IAsyncResult result)
- public virtual System.IntPtr Invoke(System.IntPtr discordPtr)

### internal delegate Discord.UserManager.FFIMethods.GetUserMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public UserManager.FFIMethods.GetUserMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long userId, System.IntPtr callbackData, Discord.UserManager.FFIMethods.GetUserCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, long userId, System.IntPtr callbackData, Discord.UserManager.FFIMethods.GetUserCallback callback)

### internal delegate Discord.Discord.FFIMethods.GetVoiceManagerMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Discord.FFIMethods.GetVoiceManagerMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr discordPtr, System.AsyncCallback callback, object object)
- public virtual System.IntPtr EndInvoke(System.IAsyncResult result)
- public virtual System.IntPtr Invoke(System.IntPtr discordPtr)

### internal delegate Discord.StoreManager.FFIMethods.HasSkuEntitlementMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StoreManager.FFIMethods.HasSkuEntitlementMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long skuId, ref bool hasEntitlement, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref bool hasEntitlement, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long skuId, ref bool hasEntitlement)

### public struct Discord.ImageDimensions

#### Fields
- public uint Height
- public uint Width

### public struct Discord.ImageHandle

#### Fields
- public long Id
- public uint Size
- public Discord.ImageType Type

#### Methods
- public static Discord.ImageHandle User(long id)
- public static Discord.ImageHandle User(long id, uint size)

### public class Discord.ImageManager

#### Fields
- private System.IntPtr MethodsPtr
- private object MethodsStructure

#### Properties
- private Discord.ImageManager.FFIMethods Methods { get; }

#### Constructors
- internal ImageManager(System.IntPtr ptr, System.IntPtr eventsPtr, ref Discord.ImageManager.FFIEvents events)

#### Methods
- public void Fetch(Discord.ImageHandle handle, bool refresh, Discord.ImageManager.FetchHandler callback)
- public void Fetch(Discord.ImageHandle handle, Discord.ImageManager.FetchHandler callback)
- private static void FetchCallbackImpl(System.IntPtr ptr, Discord.Result result, Discord.ImageHandle handleResult)
- public void GetData(Discord.ImageHandle handle, byte[] data)
- public byte[] GetData(Discord.ImageHandle handle)
- public Discord.ImageDimensions GetDimensions(Discord.ImageHandle handle)
- public UnityEngine.Texture2D GetTexture(Discord.ImageHandle handle)
- private void InitEvents(System.IntPtr eventsPtr, ref Discord.ImageManager.FFIEvents events)

### public enum Discord.ImageType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- User = 0

### public struct Discord.InputMode

#### Fields
- public string Shortcut
- public Discord.InputModeType Type

### public enum Discord.InputModeType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- PushToTalk = 1
- VoiceActivity = 0

### internal delegate Discord.OverlayManager.FFIMethods.IsEnabledMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public OverlayManager.FFIMethods.IsEnabledMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, ref bool enabled, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref bool enabled, System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, ref bool enabled)

### internal delegate Discord.VoiceManager.FFIMethods.IsLocalMuteMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public VoiceManager.FFIMethods.IsLocalMuteMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long userId, ref bool mute, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref bool mute, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long userId, ref bool mute)

### internal delegate Discord.OverlayManager.FFIMethods.IsLockedMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public OverlayManager.FFIMethods.IsLockedMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, ref bool locked, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref bool locked, System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, ref bool locked)

### internal delegate Discord.VoiceManager.FFIMethods.IsSelfDeafMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public VoiceManager.FFIMethods.IsSelfDeafMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, ref bool deaf, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref bool deaf, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, ref bool deaf)

### internal delegate Discord.VoiceManager.FFIMethods.IsSelfMuteMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public VoiceManager.FFIMethods.IsSelfMuteMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, ref bool mute, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref bool mute, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, ref bool mute)

### internal delegate Discord.LobbySearchQuery.FFIMethods.LimitMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbySearchQuery.FFIMethods.LimitMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, uint limit, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, uint limit)

### public struct Discord.Lobby

#### Fields
- public uint Capacity
- public long Id
- public bool Locked
- public long OwnerId
- public string Secret
- public Discord.LobbyType Type

### internal delegate Discord.LobbyManager.FFIMethods.LobbyCountMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.LobbyCountMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, ref int count, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref int count, System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, ref int count)

### public delegate Discord.LobbyManager.LobbyDeleteHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.LobbyDeleteHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(long lobbyId, uint reason, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(long lobbyId, uint reason)

### internal delegate Discord.LobbyManager.FFIEvents.LobbyDeleteHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIEvents.LobbyDeleteHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, long lobbyId, uint reason, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, long lobbyId, uint reason)

### public class Discord.LobbyManager

#### Fields
- private System.IntPtr MethodsPtr
- private object MethodsStructure
- private Discord.LobbyManager.LobbyDeleteHandler OnLobbyDelete
- private Discord.LobbyManager.LobbyMessageHandler OnLobbyMessage
- private Discord.LobbyManager.LobbyUpdateHandler OnLobbyUpdate
- private Discord.LobbyManager.MemberConnectHandler OnMemberConnect
- private Discord.LobbyManager.MemberDisconnectHandler OnMemberDisconnect
- private Discord.LobbyManager.MemberUpdateHandler OnMemberUpdate
- private Discord.LobbyManager.NetworkMessageHandler OnNetworkMessage
- private Discord.LobbyManager.SpeakingHandler OnSpeaking

#### Properties
- private Discord.LobbyManager.FFIMethods Methods { get; }

#### Events
- public event Discord.LobbyManager.LobbyDeleteHandler OnLobbyDelete
- public event Discord.LobbyManager.LobbyMessageHandler OnLobbyMessage
- public event Discord.LobbyManager.LobbyUpdateHandler OnLobbyUpdate
- public event Discord.LobbyManager.MemberConnectHandler OnMemberConnect
- public event Discord.LobbyManager.MemberDisconnectHandler OnMemberDisconnect
- public event Discord.LobbyManager.MemberUpdateHandler OnMemberUpdate
- public event Discord.LobbyManager.NetworkMessageHandler OnNetworkMessage
- public event Discord.LobbyManager.SpeakingHandler OnSpeaking

#### Constructors
- internal LobbyManager(System.IntPtr ptr, System.IntPtr eventsPtr, ref Discord.LobbyManager.FFIEvents events)

#### Methods
- public void ConnectLobby(long lobbyId, string secret, Discord.LobbyManager.ConnectLobbyHandler callback)
- private static void ConnectLobbyCallbackImpl(System.IntPtr ptr, Discord.Result result, ref Discord.Lobby lobby)
- public void ConnectLobbyWithActivitySecret(string activitySecret, Discord.LobbyManager.ConnectLobbyWithActivitySecretHandler callback)
- private static void ConnectLobbyWithActivitySecretCallbackImpl(System.IntPtr ptr, Discord.Result result, ref Discord.Lobby lobby)
- public void ConnectNetwork(long lobbyId)
- public void ConnectVoice(long lobbyId, Discord.LobbyManager.ConnectVoiceHandler callback)
- private static void ConnectVoiceCallbackImpl(System.IntPtr ptr, Discord.Result result)
- public void CreateLobby(Discord.LobbyTransaction transaction, Discord.LobbyManager.CreateLobbyHandler callback)
- private static void CreateLobbyCallbackImpl(System.IntPtr ptr, Discord.Result result, ref Discord.Lobby lobby)
- public void DeleteLobby(long lobbyId, Discord.LobbyManager.DeleteLobbyHandler callback)
- private static void DeleteLobbyCallbackImpl(System.IntPtr ptr, Discord.Result result)
- public void DisconnectLobby(long lobbyId, Discord.LobbyManager.DisconnectLobbyHandler callback)
- private static void DisconnectLobbyCallbackImpl(System.IntPtr ptr, Discord.Result result)
- public void DisconnectNetwork(long lobbyId)
- public void DisconnectVoice(long lobbyId, Discord.LobbyManager.DisconnectVoiceHandler callback)
- private static void DisconnectVoiceCallbackImpl(System.IntPtr ptr, Discord.Result result)
- public void FlushNetwork()
- public Discord.Lobby GetLobby(long lobbyId)
- public string GetLobbyActivitySecret(long lobbyId)
- public Discord.LobbyTransaction GetLobbyCreateTransaction()
- public long GetLobbyId(int index)
- public string GetLobbyMetadataKey(long lobbyId, int index)
- public string GetLobbyMetadataValue(long lobbyId, string key)
- public Discord.LobbyTransaction GetLobbyUpdateTransaction(long lobbyId)
- public string GetMemberMetadataKey(long lobbyId, long userId, int index)
- public string GetMemberMetadataValue(long lobbyId, long userId, string key)
- public Discord.LobbyMemberTransaction GetMemberUpdateTransaction(long lobbyId, long userId)
- public Discord.User GetMemberUser(long lobbyId, long userId)
- public long GetMemberUserId(long lobbyId, int index)
- public System.Collections.Generic.IEnumerable<Discord.User> GetMemberUsers(long lobbyID)
- public Discord.LobbySearchQuery GetSearchQuery()
- private void InitEvents(System.IntPtr eventsPtr, ref Discord.LobbyManager.FFIEvents events)
- public int LobbyCount()
- public int LobbyMetadataCount(long lobbyId)
- public int MemberCount(long lobbyId)
- public int MemberMetadataCount(long lobbyId, long userId)
- private static void OnLobbyDeleteImpl(System.IntPtr ptr, long lobbyId, uint reason)
- private static void OnLobbyMessageImpl(System.IntPtr ptr, long lobbyId, long userId, System.IntPtr dataPtr, int dataLen)
- private static void OnLobbyUpdateImpl(System.IntPtr ptr, long lobbyId)
- private static void OnMemberConnectImpl(System.IntPtr ptr, long lobbyId, long userId)
- private static void OnMemberDisconnectImpl(System.IntPtr ptr, long lobbyId, long userId)
- private static void OnMemberUpdateImpl(System.IntPtr ptr, long lobbyId, long userId)
- private static void OnNetworkMessageImpl(System.IntPtr ptr, long lobbyId, long userId, byte channelId, System.IntPtr dataPtr, int dataLen)
- private static void OnSpeakingImpl(System.IntPtr ptr, long lobbyId, long userId, bool speaking)
- public void OpenNetworkChannel(long lobbyId, byte channelId, bool reliable)
- public void Search(Discord.LobbySearchQuery query, Discord.LobbyManager.SearchHandler callback)
- private static void SearchCallbackImpl(System.IntPtr ptr, Discord.Result result)
- public void SendLobbyMessage(long lobbyId, byte[] data, Discord.LobbyManager.SendLobbyMessageHandler callback)
- public void SendLobbyMessage(long lobbyID, string data, Discord.LobbyManager.SendLobbyMessageHandler handler)
- private static void SendLobbyMessageCallbackImpl(System.IntPtr ptr, Discord.Result result)
- public void SendNetworkMessage(long lobbyId, long userId, byte channelId, byte[] data)
- public void UpdateLobby(long lobbyId, Discord.LobbyTransaction transaction, Discord.LobbyManager.UpdateLobbyHandler callback)
- private static void UpdateLobbyCallbackImpl(System.IntPtr ptr, Discord.Result result)
- public void UpdateMember(long lobbyId, long userId, Discord.LobbyMemberTransaction transaction, Discord.LobbyManager.UpdateMemberHandler callback)
- private static void UpdateMemberCallbackImpl(System.IntPtr ptr, Discord.Result result)

### public struct Discord.LobbyMemberTransaction

#### Fields
- internal System.IntPtr MethodsPtr
- internal object MethodsStructure

#### Properties
- private Discord.LobbyMemberTransaction.FFIMethods Methods { get; }

#### Methods
- public void DeleteMetadata(string key)
- public void SetMetadata(string key, string value)

### public delegate Discord.LobbyManager.LobbyMessageHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.LobbyMessageHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(long lobbyId, long userId, byte[] data, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(long lobbyId, long userId, byte[] data)

### internal delegate Discord.LobbyManager.FFIEvents.LobbyMessageHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIEvents.LobbyMessageHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, long lobbyId, long userId, System.IntPtr dataPtr, int dataLen, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, long lobbyId, long userId, System.IntPtr dataPtr, int dataLen)

### internal delegate Discord.LobbyManager.FFIMethods.LobbyMetadataCountMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.LobbyMetadataCountMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, ref int count, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref int count, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long lobbyId, ref int count)

### public enum Discord.LobbySearchCast
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Number = 2
- String = 1

### public enum Discord.LobbySearchComparison
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Equal = 0
- GreaterThan = 1
- GreaterThanOrEqual = 2
- LessThan = -1
- LessThanOrEqual = -2
- NotEqual = 3

### public enum Discord.LobbySearchDistance
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Default = 1
- Extended = 2
- Global = 3
- Local = 0

### public struct Discord.LobbySearchQuery

#### Fields
- internal System.IntPtr MethodsPtr
- internal object MethodsStructure

#### Properties
- private Discord.LobbySearchQuery.FFIMethods Methods { get; }

#### Methods
- public void Distance(Discord.LobbySearchDistance distance)
- public void Filter(string key, Discord.LobbySearchComparison comparison, Discord.LobbySearchCast cast, string value)
- public void Limit(uint limit)
- public void Sort(string key, Discord.LobbySearchCast cast, string value)

### public struct Discord.LobbyTransaction

#### Fields
- internal System.IntPtr MethodsPtr
- internal object MethodsStructure

#### Properties
- private Discord.LobbyTransaction.FFIMethods Methods { get; }

#### Methods
- public void DeleteMetadata(string key)
- public void SetCapacity(uint capacity)
- public void SetLocked(bool locked)
- public void SetMetadata(string key, string value)
- public void SetOwner(long ownerId)
- public void SetType(Discord.LobbyType type)

### public enum Discord.LobbyType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Private = 1
- Public = 2

### public delegate Discord.LobbyManager.LobbyUpdateHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.LobbyUpdateHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(long lobbyId, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(long lobbyId)

### internal delegate Discord.LobbyManager.FFIEvents.LobbyUpdateHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIEvents.LobbyUpdateHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, long lobbyId, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, long lobbyId)

### public enum Discord.LogLevel
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Debug = 4
- Error = 1
- Info = 3
- Warn = 2

### public delegate Discord.LobbyManager.MemberConnectHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.MemberConnectHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(long lobbyId, long userId, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(long lobbyId, long userId)

### internal delegate Discord.LobbyManager.FFIEvents.MemberConnectHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIEvents.MemberConnectHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, long lobbyId, long userId, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, long lobbyId, long userId)

### internal delegate Discord.LobbyManager.FFIMethods.MemberCountMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.MemberCountMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, ref int count, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref int count, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long lobbyId, ref int count)

### public delegate Discord.LobbyManager.MemberDisconnectHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.MemberDisconnectHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(long lobbyId, long userId, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(long lobbyId, long userId)

### internal delegate Discord.LobbyManager.FFIEvents.MemberDisconnectHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIEvents.MemberDisconnectHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, long lobbyId, long userId, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, long lobbyId, long userId)

### internal delegate Discord.LobbyManager.FFIMethods.MemberMetadataCountMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.MemberMetadataCountMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, long userId, ref int count, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref int count, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long lobbyId, long userId, ref int count)

### public delegate Discord.LobbyManager.MemberUpdateHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.MemberUpdateHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(long lobbyId, long userId, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(long lobbyId, long userId)

### internal delegate Discord.LobbyManager.FFIEvents.MemberUpdateHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIEvents.MemberUpdateHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, long lobbyId, long userId, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, long lobbyId, long userId)

### public delegate Discord.NetworkManager.MessageHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public NetworkManager.MessageHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ulong peerId, byte channelId, byte[] data, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(ulong peerId, byte channelId, byte[] data)

### internal delegate Discord.NetworkManager.FFIEvents.MessageHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public NetworkManager.FFIEvents.MessageHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, ulong peerId, byte channelId, System.IntPtr dataPtr, int dataLen, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, ulong peerId, byte channelId, System.IntPtr dataPtr, int dataLen)

### internal class Discord.MonoPInvokeCallbackAttribute
- Base: System.Attribute

#### Constructors
- public MonoPInvokeCallbackAttribute()

### public class Discord.NetworkManager

#### Fields
- private System.IntPtr MethodsPtr
- private object MethodsStructure
- private Discord.NetworkManager.MessageHandler OnMessage
- private Discord.NetworkManager.RouteUpdateHandler OnRouteUpdate

#### Properties
- private Discord.NetworkManager.FFIMethods Methods { get; }

#### Events
- public event Discord.NetworkManager.MessageHandler OnMessage
- public event Discord.NetworkManager.RouteUpdateHandler OnRouteUpdate

#### Constructors
- internal NetworkManager(System.IntPtr ptr, System.IntPtr eventsPtr, ref Discord.NetworkManager.FFIEvents events)

#### Methods
- public void CloseChannel(ulong peerId, byte channelId)
- public void ClosePeer(ulong peerId)
- public void Flush()
- public ulong GetPeerId()
- private void InitEvents(System.IntPtr eventsPtr, ref Discord.NetworkManager.FFIEvents events)
- private static void OnMessageImpl(System.IntPtr ptr, ulong peerId, byte channelId, System.IntPtr dataPtr, int dataLen)
- private static void OnRouteUpdateImpl(System.IntPtr ptr, string routeData)
- public void OpenChannel(ulong peerId, byte channelId, bool reliable)
- public void OpenPeer(ulong peerId, string routeData)
- public void SendMessage(ulong peerId, byte channelId, byte[] data)
- public void UpdatePeer(ulong peerId, string routeData)

### public delegate Discord.LobbyManager.NetworkMessageHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.NetworkMessageHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(long lobbyId, long userId, byte channelId, byte[] data, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(long lobbyId, long userId, byte channelId, byte[] data)

### internal delegate Discord.LobbyManager.FFIEvents.NetworkMessageHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIEvents.NetworkMessageHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, long lobbyId, long userId, byte channelId, System.IntPtr dataPtr, int dataLen, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, long lobbyId, long userId, byte channelId, System.IntPtr dataPtr, int dataLen)

### public struct Discord.OAuth2Token

#### Fields
- public string AccessToken
- public long Expires
- public string Scopes

### internal delegate Discord.OverlayManager.FFIMethods.OpenActivityInviteCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public OverlayManager.FFIMethods.OpenActivityInviteCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.OverlayManager.OpenActivityInviteHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public OverlayManager.OpenActivityInviteHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.OverlayManager.FFIMethods.OpenActivityInviteMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public OverlayManager.FFIMethods.OpenActivityInviteMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, Discord.ActivityActionType type, System.IntPtr callbackData, Discord.OverlayManager.FFIMethods.OpenActivityInviteCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, Discord.ActivityActionType type, System.IntPtr callbackData, Discord.OverlayManager.FFIMethods.OpenActivityInviteCallback callback)

### internal delegate Discord.NetworkManager.FFIMethods.OpenChannelMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public NetworkManager.FFIMethods.OpenChannelMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, ulong peerId, byte channelId, bool reliable, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, ulong peerId, byte channelId, bool reliable)

### internal delegate Discord.OverlayManager.FFIMethods.OpenGuildInviteCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public OverlayManager.FFIMethods.OpenGuildInviteCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.OverlayManager.OpenGuildInviteHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public OverlayManager.OpenGuildInviteHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.OverlayManager.FFIMethods.OpenGuildInviteMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public OverlayManager.FFIMethods.OpenGuildInviteMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, string code, System.IntPtr callbackData, Discord.OverlayManager.FFIMethods.OpenGuildInviteCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, string code, System.IntPtr callbackData, Discord.OverlayManager.FFIMethods.OpenGuildInviteCallback callback)

### internal delegate Discord.LobbyManager.FFIMethods.OpenNetworkChannelMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.OpenNetworkChannelMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, byte channelId, bool reliable, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long lobbyId, byte channelId, bool reliable)

### internal delegate Discord.NetworkManager.FFIMethods.OpenPeerMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public NetworkManager.FFIMethods.OpenPeerMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, ulong peerId, string routeData, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, ulong peerId, string routeData)

### internal delegate Discord.OverlayManager.FFIMethods.OpenVoiceSettingsCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public OverlayManager.FFIMethods.OpenVoiceSettingsCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.OverlayManager.OpenVoiceSettingsHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public OverlayManager.OpenVoiceSettingsHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.OverlayManager.FFIMethods.OpenVoiceSettingsMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public OverlayManager.FFIMethods.OpenVoiceSettingsMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, System.IntPtr callbackData, Discord.OverlayManager.FFIMethods.OpenVoiceSettingsCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, System.IntPtr callbackData, Discord.OverlayManager.FFIMethods.OpenVoiceSettingsCallback callback)

### public class Discord.OverlayManager

#### Fields
- private System.IntPtr MethodsPtr
- private object MethodsStructure
- private Discord.OverlayManager.ToggleHandler OnToggle

#### Properties
- private Discord.OverlayManager.FFIMethods Methods { get; }

#### Events
- public event Discord.OverlayManager.ToggleHandler OnToggle

#### Constructors
- internal OverlayManager(System.IntPtr ptr, System.IntPtr eventsPtr, ref Discord.OverlayManager.FFIEvents events)

#### Methods
- private void InitEvents(System.IntPtr eventsPtr, ref Discord.OverlayManager.FFIEvents events)
- public bool IsEnabled()
- public bool IsLocked()
- private static void OnToggleImpl(System.IntPtr ptr, bool locked)
- public void OpenActivityInvite(Discord.ActivityActionType type, Discord.OverlayManager.OpenActivityInviteHandler callback)
- private static void OpenActivityInviteCallbackImpl(System.IntPtr ptr, Discord.Result result)
- public void OpenGuildInvite(string code, Discord.OverlayManager.OpenGuildInviteHandler callback)
- private static void OpenGuildInviteCallbackImpl(System.IntPtr ptr, Discord.Result result)
- public void OpenVoiceSettings(Discord.OverlayManager.OpenVoiceSettingsHandler callback)
- private static void OpenVoiceSettingsCallbackImpl(System.IntPtr ptr, Discord.Result result)
- public void SetLocked(bool locked, Discord.OverlayManager.SetLockedHandler callback)
- private static void SetLockedCallbackImpl(System.IntPtr ptr, Discord.Result result)

### public struct Discord.PartySize

#### Fields
- public int CurrentSize
- public int MaxSize

### public enum Discord.PremiumType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- None = 0
- Tier1 = 1
- Tier2 = 2

### public struct Discord.Presence

#### Fields
- public Discord.Activity Activity
- public Discord.Status Status

### internal delegate Discord.StorageManager.FFIMethods.ReadAsyncCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StorageManager.FFIMethods.ReadAsyncCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.IntPtr dataPtr, int dataLen, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result, System.IntPtr dataPtr, int dataLen)

### public delegate Discord.StorageManager.ReadAsyncHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StorageManager.ReadAsyncHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, byte[] data, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result, byte[] data)

### internal delegate Discord.StorageManager.FFIMethods.ReadAsyncMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StorageManager.FFIMethods.ReadAsyncMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, string name, System.IntPtr callbackData, Discord.StorageManager.FFIMethods.ReadAsyncCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, string name, System.IntPtr callbackData, Discord.StorageManager.FFIMethods.ReadAsyncCallback callback)

### internal delegate Discord.StorageManager.FFIMethods.ReadAsyncPartialCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StorageManager.FFIMethods.ReadAsyncPartialCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.IntPtr dataPtr, int dataLen, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result, System.IntPtr dataPtr, int dataLen)

### public delegate Discord.StorageManager.ReadAsyncPartialHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StorageManager.ReadAsyncPartialHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, byte[] data, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result, byte[] data)

### internal delegate Discord.StorageManager.FFIMethods.ReadAsyncPartialMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StorageManager.FFIMethods.ReadAsyncPartialMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, string name, ulong offset, ulong length, System.IntPtr callbackData, Discord.StorageManager.FFIMethods.ReadAsyncPartialCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, string name, ulong offset, ulong length, System.IntPtr callbackData, Discord.StorageManager.FFIMethods.ReadAsyncPartialCallback callback)

### internal delegate Discord.StorageManager.FFIMethods.ReadMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StorageManager.FFIMethods.ReadMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, string name, byte[] data, int dataLen, ref uint read, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref uint read, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, string name, byte[] data, int dataLen, ref uint read)

### public delegate Discord.RelationshipManager.RefreshHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public RelationshipManager.RefreshHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke()

### internal delegate Discord.RelationshipManager.FFIEvents.RefreshHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public RelationshipManager.FFIEvents.RefreshHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr)

### internal delegate Discord.ActivityManager.FFIMethods.RegisterCommandMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.FFIMethods.RegisterCommandMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, string command, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, string command)

### internal delegate Discord.ActivityManager.FFIMethods.RegisterSteamMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.FFIMethods.RegisterSteamMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, uint steamId, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, uint steamId)

### public struct Discord.Relationship

#### Fields
- public Discord.Presence Presence
- public Discord.RelationshipType Type
- public Discord.User User

### public class Discord.RelationshipManager

#### Fields
- private System.IntPtr MethodsPtr
- private object MethodsStructure
- private Discord.RelationshipManager.RefreshHandler OnRefresh
- private Discord.RelationshipManager.RelationshipUpdateHandler OnRelationshipUpdate

#### Properties
- private Discord.RelationshipManager.FFIMethods Methods { get; }

#### Events
- public event Discord.RelationshipManager.RefreshHandler OnRefresh
- public event Discord.RelationshipManager.RelationshipUpdateHandler OnRelationshipUpdate

#### Constructors
- internal RelationshipManager(System.IntPtr ptr, System.IntPtr eventsPtr, ref Discord.RelationshipManager.FFIEvents events)

#### Methods
- public int Count()
- public void Filter(Discord.RelationshipManager.FilterHandler callback)
- private static bool FilterCallbackImpl(System.IntPtr ptr, ref Discord.Relationship relationship)
- public Discord.Relationship Get(long userId)
- public Discord.Relationship GetAt(uint index)
- private void InitEvents(System.IntPtr eventsPtr, ref Discord.RelationshipManager.FFIEvents events)
- private static void OnRefreshImpl(System.IntPtr ptr)
- private static void OnRelationshipUpdateImpl(System.IntPtr ptr, ref Discord.Relationship relationship)

### public enum Discord.RelationshipType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Blocked = 2
- Friend = 1
- Implicit = 5
- None = 0
- PendingIncoming = 3
- PendingOutgoing = 4

### public delegate Discord.RelationshipManager.RelationshipUpdateHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public RelationshipManager.RelationshipUpdateHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref Discord.Relationship relationship, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref Discord.Relationship relationship, System.IAsyncResult result)
- public virtual void Invoke(ref Discord.Relationship relationship)

### internal delegate Discord.RelationshipManager.FFIEvents.RelationshipUpdateHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public RelationshipManager.FFIEvents.RelationshipUpdateHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, ref Discord.Relationship relationship, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref Discord.Relationship relationship, System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, ref Discord.Relationship relationship)

### public enum Discord.Result
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ApplicationMismatch = 17
- CaptureShortcutAlreadyListening = 39
- Conflict = 10
- GetGuildTimeout = 37
- InsufficientBuffer = 28
- InternalError = 4
- InvalidAccessToken = 16
- InvalidBase64 = 19
- InvalidChannel = 32
- InvalidCommand = 6
- InvalidDataUrl = 18
- InvalidEntitlement = 25
- InvalidEvent = 31
- InvalidFilename = 23
- InvalidFileSize = 24
- InvalidGiftCode = 41
- InvalidGuild = 30
- InvalidInvite = 14
- InvalidJoinSecret = 12
- InvalidLobbySecret = 22
- InvalidOrigin = 33
- InvalidPayload = 5
- InvalidPermissions = 7
- InvalidSecret = 11
- InvalidVersion = 2
- LobbyFull = 21
- LockFailed = 3
- NoEligibleActivity = 13
- NotAuthenticated = 15
- NotFetched = 8
- NotFiltered = 20
- NotFound = 9
- NotInstalled = 26
- NotRunning = 27
- OAuth2Error = 35
- Ok = 0
- PurchaseCanceled = 29
- PurchaseError = 42
- RateLimited = 34
- SelectChannelTimeout = 36
- SelectVoiceForceRequired = 38
- ServiceUnavailable = 1
- TransactionAborted = 43
- UnauthorizedForAchievement = 40

### public class Discord.ResultException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Fields
- public readonly Discord.Result Result

#### Constructors
- public ResultException(Discord.Result result)

### public delegate Discord.NetworkManager.RouteUpdateHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public NetworkManager.RouteUpdateHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(string routeData, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(string routeData)

### internal delegate Discord.NetworkManager.FFIEvents.RouteUpdateHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public NetworkManager.FFIEvents.RouteUpdateHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, string routeData, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, string routeData)

### internal delegate Discord.Discord.FFIMethods.RunCallbacksMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Discord.FFIMethods.RunCallbacksMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr)

### internal delegate Discord.LobbyManager.FFIMethods.SearchCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.SearchCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.LobbyManager.SearchHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.SearchHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.LobbyManager.FFIMethods.SearchMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.SearchMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, System.IntPtr query, System.IntPtr callbackData, Discord.LobbyManager.FFIMethods.SearchCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, System.IntPtr query, System.IntPtr callbackData, Discord.LobbyManager.FFIMethods.SearchCallback callback)

### internal delegate Discord.ActivityManager.FFIMethods.SendInviteCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.FFIMethods.SendInviteCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.ActivityManager.SendInviteHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.SendInviteHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.ActivityManager.FFIMethods.SendInviteMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.FFIMethods.SendInviteMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long userId, Discord.ActivityActionType type, string content, System.IntPtr callbackData, Discord.ActivityManager.FFIMethods.SendInviteCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, long userId, Discord.ActivityActionType type, string content, System.IntPtr callbackData, Discord.ActivityManager.FFIMethods.SendInviteCallback callback)

### internal delegate Discord.LobbyManager.FFIMethods.SendLobbyMessageCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.SendLobbyMessageCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.LobbyManager.SendLobbyMessageHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.SendLobbyMessageHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.LobbyManager.FFIMethods.SendLobbyMessageMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.SendLobbyMessageMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, byte[] data, int dataLen, System.IntPtr callbackData, Discord.LobbyManager.FFIMethods.SendLobbyMessageCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, long lobbyId, byte[] data, int dataLen, System.IntPtr callbackData, Discord.LobbyManager.FFIMethods.SendLobbyMessageCallback callback)

### internal delegate Discord.NetworkManager.FFIMethods.SendMessageMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public NetworkManager.FFIMethods.SendMessageMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, ulong peerId, byte channelId, byte[] data, int dataLen, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, ulong peerId, byte channelId, byte[] data, int dataLen)

### internal delegate Discord.LobbyManager.FFIMethods.SendNetworkMessageMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.SendNetworkMessageMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, long userId, byte channelId, byte[] data, int dataLen, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long lobbyId, long userId, byte channelId, byte[] data, int dataLen)

### internal delegate Discord.ActivityManager.FFIMethods.SendRequestReplyCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.FFIMethods.SendRequestReplyCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.ActivityManager.SendRequestReplyHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.SendRequestReplyHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.ActivityManager.FFIMethods.SendRequestReplyMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.FFIMethods.SendRequestReplyMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long userId, Discord.ActivityJoinRequestReply reply, System.IntPtr callbackData, Discord.ActivityManager.FFIMethods.SendRequestReplyCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, long userId, Discord.ActivityJoinRequestReply reply, System.IntPtr callbackData, Discord.ActivityManager.FFIMethods.SendRequestReplyCallback callback)

### internal delegate Discord.LobbyTransaction.FFIMethods.SetCapacityMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyTransaction.FFIMethods.SetCapacityMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, uint capacity, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, uint capacity)

### internal delegate Discord.VoiceManager.FFIMethods.SetInputModeCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public VoiceManager.FFIMethods.SetInputModeCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.VoiceManager.SetInputModeHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public VoiceManager.SetInputModeHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.VoiceManager.FFIMethods.SetInputModeMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public VoiceManager.FFIMethods.SetInputModeMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, Discord.InputMode inputMode, System.IntPtr callbackData, Discord.VoiceManager.FFIMethods.SetInputModeCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, Discord.InputMode inputMode, System.IntPtr callbackData, Discord.VoiceManager.FFIMethods.SetInputModeCallback callback)

### internal delegate Discord.VoiceManager.FFIMethods.SetLocalMuteMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public VoiceManager.FFIMethods.SetLocalMuteMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long userId, bool mute, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long userId, bool mute)

### internal delegate Discord.VoiceManager.FFIMethods.SetLocalVolumeMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public VoiceManager.FFIMethods.SetLocalVolumeMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long userId, byte volume, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long userId, byte volume)

### internal delegate Discord.OverlayManager.FFIMethods.SetLockedCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public OverlayManager.FFIMethods.SetLockedCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.OverlayManager.SetLockedHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public OverlayManager.SetLockedHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.LobbyTransaction.FFIMethods.SetLockedMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyTransaction.FFIMethods.SetLockedMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, bool locked, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, bool locked)

### internal delegate Discord.OverlayManager.FFIMethods.SetLockedMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public OverlayManager.FFIMethods.SetLockedMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, bool locked, System.IntPtr callbackData, Discord.OverlayManager.FFIMethods.SetLockedCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, bool locked, System.IntPtr callbackData, Discord.OverlayManager.FFIMethods.SetLockedCallback callback)

### internal delegate Discord.Discord.FFIMethods.SetLogHookCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Discord.FFIMethods.SetLogHookCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.LogLevel level, string message, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.LogLevel level, string message)

### public delegate Discord.Discord.SetLogHookHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Discord.SetLogHookHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.LogLevel level, string message, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.LogLevel level, string message)

### internal delegate Discord.Discord.FFIMethods.SetLogHookMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Discord.FFIMethods.SetLogHookMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, Discord.LogLevel minLevel, System.IntPtr callbackData, Discord.Discord.FFIMethods.SetLogHookCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, Discord.LogLevel minLevel, System.IntPtr callbackData, Discord.Discord.FFIMethods.SetLogHookCallback callback)

### internal delegate Discord.LobbyTransaction.FFIMethods.SetMetadataMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyTransaction.FFIMethods.SetMetadataMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, string key, string value, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, string key, string value)

### internal delegate Discord.LobbyMemberTransaction.FFIMethods.SetMetadataMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyMemberTransaction.FFIMethods.SetMetadataMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, string key, string value, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, string key, string value)

### internal delegate Discord.LobbyTransaction.FFIMethods.SetOwnerMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyTransaction.FFIMethods.SetOwnerMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long ownerId, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, long ownerId)

### internal delegate Discord.VoiceManager.FFIMethods.SetSelfDeafMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public VoiceManager.FFIMethods.SetSelfDeafMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, bool deaf, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, bool deaf)

### internal delegate Discord.VoiceManager.FFIMethods.SetSelfMuteMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public VoiceManager.FFIMethods.SetSelfMuteMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, bool mute, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, bool mute)

### public delegate Discord.VoiceManager.SettingsUpdateHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public VoiceManager.SettingsUpdateHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke()

### internal delegate Discord.VoiceManager.FFIEvents.SettingsUpdateHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public VoiceManager.FFIEvents.SettingsUpdateHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr)

### internal delegate Discord.LobbyTransaction.FFIMethods.SetTypeMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyTransaction.FFIMethods.SetTypeMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, Discord.LobbyType type, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, Discord.LobbyType type)

### internal delegate Discord.AchievementManager.FFIMethods.SetUserAchievementCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public AchievementManager.FFIMethods.SetUserAchievementCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.AchievementManager.SetUserAchievementHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public AchievementManager.SetUserAchievementHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.AchievementManager.FFIMethods.SetUserAchievementMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public AchievementManager.FFIMethods.SetUserAchievementMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long achievementId, byte percentComplete, System.IntPtr callbackData, Discord.AchievementManager.FFIMethods.SetUserAchievementCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, long achievementId, byte percentComplete, System.IntPtr callbackData, Discord.AchievementManager.FFIMethods.SetUserAchievementCallback callback)

### public struct Discord.Sku

#### Fields
- public long Id
- public string Name
- public Discord.SkuPrice Price
- public Discord.SkuType Type

### public struct Discord.SkuPrice

#### Fields
- public uint Amount
- public string Currency

### public enum Discord.SkuType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Application = 1
- Bundle = 4
- Consumable = 3
- DLC = 2

### internal delegate Discord.LobbySearchQuery.FFIMethods.SortMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbySearchQuery.FFIMethods.SortMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, string key, Discord.LobbySearchCast cast, string value, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, string key, Discord.LobbySearchCast cast, string value)

### public delegate Discord.LobbyManager.SpeakingHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.SpeakingHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(long lobbyId, long userId, bool speaking, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(long lobbyId, long userId, bool speaking)

### internal delegate Discord.LobbyManager.FFIEvents.SpeakingHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIEvents.SpeakingHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, long lobbyId, long userId, bool speaking, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, long lobbyId, long userId, bool speaking)

### internal delegate Discord.StoreManager.FFIMethods.StartPurchaseCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StoreManager.FFIMethods.StartPurchaseCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.StoreManager.StartPurchaseHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StoreManager.StartPurchaseHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.StoreManager.FFIMethods.StartPurchaseMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StoreManager.FFIMethods.StartPurchaseMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long skuId, System.IntPtr callbackData, Discord.StoreManager.FFIMethods.StartPurchaseCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, long skuId, System.IntPtr callbackData, Discord.StoreManager.FFIMethods.StartPurchaseCallback callback)

### internal delegate Discord.StorageManager.FFIMethods.StatAtMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StorageManager.FFIMethods.StatAtMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, int index, ref Discord.FileStat stat, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref Discord.FileStat stat, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, int index, ref Discord.FileStat stat)

### internal delegate Discord.StorageManager.FFIMethods.StatMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StorageManager.FFIMethods.StatMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, string name, ref Discord.FileStat stat, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(ref Discord.FileStat stat, System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, string name, ref Discord.FileStat stat)

### public enum Discord.Status
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DoNotDisturb = 3
- Idle = 2
- Offline = 0
- Online = 1

### public class Discord.StorageManager

#### Fields
- private System.IntPtr MethodsPtr
- private object MethodsStructure

#### Properties
- private Discord.StorageManager.FFIMethods Methods { get; }

#### Constructors
- internal StorageManager(System.IntPtr ptr, System.IntPtr eventsPtr, ref Discord.StorageManager.FFIEvents events)

#### Methods
- public int Count()
- public void Delete(string name)
- public bool Exists(string name)
- public System.Collections.Generic.IEnumerable<Discord.FileStat> Files()
- public string GetPath()
- private void InitEvents(System.IntPtr eventsPtr, ref Discord.StorageManager.FFIEvents events)
- public uint Read(string name, byte[] data)
- public void ReadAsync(string name, Discord.StorageManager.ReadAsyncHandler callback)
- private static void ReadAsyncCallbackImpl(System.IntPtr ptr, Discord.Result result, System.IntPtr dataPtr, int dataLen)
- public void ReadAsyncPartial(string name, ulong offset, ulong length, Discord.StorageManager.ReadAsyncPartialHandler callback)
- private static void ReadAsyncPartialCallbackImpl(System.IntPtr ptr, Discord.Result result, System.IntPtr dataPtr, int dataLen)
- public Discord.FileStat Stat(string name)
- public Discord.FileStat StatAt(int index)
- public void Write(string name, byte[] data)
- public void WriteAsync(string name, byte[] data, Discord.StorageManager.WriteAsyncHandler callback)
- private static void WriteAsyncCallbackImpl(System.IntPtr ptr, Discord.Result result)

### public class Discord.StoreManager

#### Fields
- private System.IntPtr MethodsPtr
- private object MethodsStructure
- private Discord.StoreManager.EntitlementCreateHandler OnEntitlementCreate
- private Discord.StoreManager.EntitlementDeleteHandler OnEntitlementDelete

#### Properties
- private Discord.StoreManager.FFIMethods Methods { get; }

#### Events
- public event Discord.StoreManager.EntitlementCreateHandler OnEntitlementCreate
- public event Discord.StoreManager.EntitlementDeleteHandler OnEntitlementDelete

#### Constructors
- internal StoreManager(System.IntPtr ptr, System.IntPtr eventsPtr, ref Discord.StoreManager.FFIEvents events)

#### Methods
- public int CountEntitlements()
- public int CountSkus()
- public void FetchEntitlements(Discord.StoreManager.FetchEntitlementsHandler callback)
- private static void FetchEntitlementsCallbackImpl(System.IntPtr ptr, Discord.Result result)
- public void FetchSkus(Discord.StoreManager.FetchSkusHandler callback)
- private static void FetchSkusCallbackImpl(System.IntPtr ptr, Discord.Result result)
- public Discord.Entitlement GetEntitlement(long entitlementId)
- public Discord.Entitlement GetEntitlementAt(int index)
- public System.Collections.Generic.IEnumerable<Discord.Entitlement> GetEntitlements()
- public Discord.Sku GetSku(long skuId)
- public Discord.Sku GetSkuAt(int index)
- public System.Collections.Generic.IEnumerable<Discord.Sku> GetSkus()
- public bool HasSkuEntitlement(long skuId)
- private void InitEvents(System.IntPtr eventsPtr, ref Discord.StoreManager.FFIEvents events)
- private static void OnEntitlementCreateImpl(System.IntPtr ptr, ref Discord.Entitlement entitlement)
- private static void OnEntitlementDeleteImpl(System.IntPtr ptr, ref Discord.Entitlement entitlement)
- public void StartPurchase(long skuId, Discord.StoreManager.StartPurchaseHandler callback)
- private static void StartPurchaseCallbackImpl(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.OverlayManager.ToggleHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public OverlayManager.ToggleHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(bool locked, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(bool locked)

### internal delegate Discord.OverlayManager.FFIEvents.ToggleHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public OverlayManager.FFIEvents.ToggleHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, bool locked, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, bool locked)

### internal delegate Discord.ActivityManager.FFIMethods.UpdateActivityCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.FFIMethods.UpdateActivityCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.ActivityManager.UpdateActivityHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.UpdateActivityHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.ActivityManager.FFIMethods.UpdateActivityMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ActivityManager.FFIMethods.UpdateActivityMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, ref Discord.Activity activity, System.IntPtr callbackData, Discord.ActivityManager.FFIMethods.UpdateActivityCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(ref Discord.Activity activity, System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, ref Discord.Activity activity, System.IntPtr callbackData, Discord.ActivityManager.FFIMethods.UpdateActivityCallback callback)

### internal delegate Discord.LobbyManager.FFIMethods.UpdateLobbyCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.UpdateLobbyCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.LobbyManager.UpdateLobbyHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.UpdateLobbyHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.LobbyManager.FFIMethods.UpdateLobbyMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.UpdateLobbyMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, System.IntPtr transaction, System.IntPtr callbackData, Discord.LobbyManager.FFIMethods.UpdateLobbyCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, long lobbyId, System.IntPtr transaction, System.IntPtr callbackData, Discord.LobbyManager.FFIMethods.UpdateLobbyCallback callback)

### internal delegate Discord.LobbyManager.FFIMethods.UpdateMemberCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.UpdateMemberCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.LobbyManager.UpdateMemberHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.UpdateMemberHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.LobbyManager.FFIMethods.UpdateMemberMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public LobbyManager.FFIMethods.UpdateMemberMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, long lobbyId, long userId, System.IntPtr transaction, System.IntPtr callbackData, Discord.LobbyManager.FFIMethods.UpdateMemberCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, long lobbyId, long userId, System.IntPtr transaction, System.IntPtr callbackData, Discord.LobbyManager.FFIMethods.UpdateMemberCallback callback)

### internal delegate Discord.NetworkManager.FFIMethods.UpdatePeerMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public NetworkManager.FFIMethods.UpdatePeerMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, ulong peerId, string routeData, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, ulong peerId, string routeData)

### public struct Discord.User

#### Fields
- public string Avatar
- public bool Bot
- public string Discriminator
- public long Id
- public string Username

### public struct Discord.UserAchievement

#### Fields
- public long AchievementId
- public byte PercentComplete
- public string UnlockedAt
- public long UserId

### public delegate Discord.AchievementManager.UserAchievementUpdateHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public AchievementManager.UserAchievementUpdateHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref Discord.UserAchievement userAchievement, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref Discord.UserAchievement userAchievement, System.IAsyncResult result)
- public virtual void Invoke(ref Discord.UserAchievement userAchievement)

### internal delegate Discord.AchievementManager.FFIEvents.UserAchievementUpdateHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public AchievementManager.FFIEvents.UserAchievementUpdateHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, ref Discord.UserAchievement userAchievement, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref Discord.UserAchievement userAchievement, System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, ref Discord.UserAchievement userAchievement)

### public enum Discord.UserFlag
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- HypeSquadEvents = 4
- HypeSquadHouse1 = 64
- HypeSquadHouse2 = 128
- HypeSquadHouse3 = 256
- Partner = 2

### public class Discord.UserManager

#### Fields
- private System.IntPtr MethodsPtr
- private object MethodsStructure
- private Discord.UserManager.CurrentUserUpdateHandler OnCurrentUserUpdate

#### Properties
- private Discord.UserManager.FFIMethods Methods { get; }

#### Events
- public event Discord.UserManager.CurrentUserUpdateHandler OnCurrentUserUpdate

#### Constructors
- internal UserManager(System.IntPtr ptr, System.IntPtr eventsPtr, ref Discord.UserManager.FFIEvents events)

#### Methods
- public bool CurrentUserHasFlag(Discord.UserFlag flag)
- public Discord.User GetCurrentUser()
- public Discord.PremiumType GetCurrentUserPremiumType()
- public void GetUser(long userId, Discord.UserManager.GetUserHandler callback)
- private static void GetUserCallbackImpl(System.IntPtr ptr, Discord.Result result, ref Discord.User user)
- private void InitEvents(System.IntPtr eventsPtr, ref Discord.UserManager.FFIEvents events)
- private static void OnCurrentUserUpdateImpl(System.IntPtr ptr)

### internal delegate Discord.ApplicationManager.FFIMethods.ValidateOrExitCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ApplicationManager.FFIMethods.ValidateOrExitCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.ApplicationManager.ValidateOrExitHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ApplicationManager.ValidateOrExitHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.ApplicationManager.FFIMethods.ValidateOrExitMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ApplicationManager.FFIMethods.ValidateOrExitMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, System.IntPtr callbackData, Discord.ApplicationManager.FFIMethods.ValidateOrExitCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, System.IntPtr callbackData, Discord.ApplicationManager.FFIMethods.ValidateOrExitCallback callback)

### public class Discord.VoiceManager

#### Fields
- private System.IntPtr MethodsPtr
- private object MethodsStructure
- private Discord.VoiceManager.SettingsUpdateHandler OnSettingsUpdate

#### Properties
- private Discord.VoiceManager.FFIMethods Methods { get; }

#### Events
- public event Discord.VoiceManager.SettingsUpdateHandler OnSettingsUpdate

#### Constructors
- internal VoiceManager(System.IntPtr ptr, System.IntPtr eventsPtr, ref Discord.VoiceManager.FFIEvents events)

#### Methods
- public Discord.InputMode GetInputMode()
- public byte GetLocalVolume(long userId)
- private void InitEvents(System.IntPtr eventsPtr, ref Discord.VoiceManager.FFIEvents events)
- public bool IsLocalMute(long userId)
- public bool IsSelfDeaf()
- public bool IsSelfMute()
- private static void OnSettingsUpdateImpl(System.IntPtr ptr)
- public void SetInputMode(Discord.InputMode inputMode, Discord.VoiceManager.SetInputModeHandler callback)
- private static void SetInputModeCallbackImpl(System.IntPtr ptr, Discord.Result result)
- public void SetLocalMute(long userId, bool mute)
- public void SetLocalVolume(long userId, byte volume)
- public void SetSelfDeaf(bool deaf)
- public void SetSelfMute(bool mute)

### internal delegate Discord.StorageManager.FFIMethods.WriteAsyncCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StorageManager.FFIMethods.WriteAsyncCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr ptr, Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr ptr, Discord.Result result)

### public delegate Discord.StorageManager.WriteAsyncHandler
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StorageManager.WriteAsyncHandler(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Discord.Result result, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Discord.Result result)

### internal delegate Discord.StorageManager.FFIMethods.WriteAsyncMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StorageManager.FFIMethods.WriteAsyncMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, string name, byte[] data, int dataLen, System.IntPtr callbackData, Discord.StorageManager.FFIMethods.WriteAsyncCallback callback, System.AsyncCallback __callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr methodsPtr, string name, byte[] data, int dataLen, System.IntPtr callbackData, Discord.StorageManager.FFIMethods.WriteAsyncCallback callback)

### internal delegate Discord.StorageManager.FFIMethods.WriteMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public StorageManager.FFIMethods.WriteMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr methodsPtr, string name, byte[] data, int dataLen, System.AsyncCallback callback, object object)
- public virtual Discord.Result EndInvoke(System.IAsyncResult result)
- public virtual Discord.Result Invoke(System.IntPtr methodsPtr, string name, byte[] data, int dataLen)

## Namespace: SAES

### public class SAES.SAES

#### Fields
- private System.Security.Cryptography.ICryptoTransform _d
- private System.Security.Cryptography.ICryptoTransform _e
- private System.Text.UTF8Encoding _en
- private static byte[] _kl
- private static byte[] _vl

#### Constructors
- public SAES()
- private static SAES()

#### Methods
- public byte[] FromBytes(byte[] pBuf)
- public string FromString(string pUn)
- public void init(bool pI = false)
- public string rshl(string pS = "")
- public string rshl(bool pI = true, string pS = "")
- public string rshr(string pS = "")
- public string rshr(bool pI = true, string pS = "")
- public static bool shl(byte[] bytes)
- public static bool shr(byte[] bytes)
- public byte[] ToBytes(byte[] pBuf)
- public string ToString(string pEn)
- protected byte[] trsf(byte[] pBuf, System.Security.Cryptography.ICryptoTransform pTrsf)

## Namespace: SimpleJSON

### private class SimpleJSON.JSONObject.<>c__DisplayClass21_0

#### Fields
- public SimpleJSON.JSONNode aNode

#### Constructors
- public JSONObject.<>c__DisplayClass21_0()

#### Methods
- internal bool <Remove>b__0(System.Collections.Generic.KeyValuePair<string, SimpleJSON.JSONNode> k)

### private class SimpleJSON.JSONArray.<get_Children>d__24
- Interfaces: System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private SimpleJSON.JSONNode <>2__current
- public SimpleJSON.JSONArray <>4__this
- private System.Collections.Generic.List<T>.Enumerator<SimpleJSON.JSONNode> <>7__wrap1
- private int <>l__initialThreadId

#### Properties
- private SimpleJSON.JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public JSONArray.<get_Children>d__24(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class SimpleJSON.JSONObject.<get_Children>d__27
- Interfaces: System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private SimpleJSON.JSONNode <>2__current
- public SimpleJSON.JSONObject <>4__this
- private System.Collections.Generic.Dictionary<TKey, TValue>.Enumerator<string, SimpleJSON.JSONNode> <>7__wrap1
- private int <>l__initialThreadId

#### Properties
- private SimpleJSON.JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public JSONObject.<get_Children>d__27(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class SimpleJSON.JSONNode.<get_Children>d__43
- Interfaces: System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private SimpleJSON.JSONNode <>2__current
- private int <>l__initialThreadId

#### Properties
- private SimpleJSON.JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public JSONNode.<get_Children>d__43(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class SimpleJSON.JSONNode.<get_DeepChildren>d__45
- Interfaces: System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private SimpleJSON.JSONNode <>2__current
- public SimpleJSON.JSONNode <>4__this
- private System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode> <>7__wrap1
- private System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode> <>7__wrap2
- private int <>l__initialThreadId

#### Properties
- private SimpleJSON.JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public JSONNode.<get_DeepChildren>d__45(int <>1__state)

#### Methods
- private void <>m__Finally1()
- private void <>m__Finally2()
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### public struct SimpleJSON.JSONNode.Enumerator

#### Fields
- private System.Collections.Generic.List<T>.Enumerator<SimpleJSON.JSONNode> m_Array
- private System.Collections.Generic.Dictionary<TKey, TValue>.Enumerator<string, SimpleJSON.JSONNode> m_Object
- private SimpleJSON.JSONNode.Enumerator.Type type

#### Properties
- public System.Collections.Generic.KeyValuePair<string, SimpleJSON.JSONNode> Current { get; }
- public bool IsValid { get; }

#### Constructors
- public JSONNode.Enumerator(System.Collections.Generic.List<T>.Enumerator<SimpleJSON.JSONNode> aArrayEnum)
- public JSONNode.Enumerator(System.Collections.Generic.Dictionary<TKey, TValue>.Enumerator<string, SimpleJSON.JSONNode> aDictEnum)

#### Methods
- public bool MoveNext()

### public static class SimpleJSON.JSON

#### Methods
- public static SimpleJSON.JSONNode Parse(string aJSON)

### public class SimpleJSON.JSONArray
- Base: SimpleJSON.JSONNode

#### Fields
- private bool inline
- private System.Collections.Generic.List<SimpleJSON.JSONNode> m_List

#### Properties
- public System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> Children { get; }
- public int Count { get; }
- public bool Inline { get; set; }
- public bool IsArray { get; }
- public SimpleJSON.JSONNode Item { get; set; }
- public SimpleJSON.JSONNode Item { get; set; }
- public SimpleJSON.JSONNodeType Tag { get; }

#### Constructors
- public JSONArray()

#### Methods
- public override void Add(string aKey, SimpleJSON.JSONNode aItem)
- public override void Clear()
- public override SimpleJSON.JSONNode Clone()
- public override SimpleJSON.JSONNode.Enumerator GetEnumerator()
- public override SimpleJSON.JSONNode Remove(int aIndex)
- public override SimpleJSON.JSONNode Remove(SimpleJSON.JSONNode aNode)
- internal override void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON.JSONTextMode aMode)

### public class SimpleJSON.JSONBool
- Base: SimpleJSON.JSONNode

#### Fields
- private bool m_Data

#### Properties
- public bool AsBool { get; set; }
- public bool IsBoolean { get; }
- public SimpleJSON.JSONNodeType Tag { get; }
- public string Value { get; set; }

#### Constructors
- public JSONBool(bool aData)
- public JSONBool(string aData)

#### Methods
- public override void Clear()
- public override SimpleJSON.JSONNode Clone()
- public override bool Equals(object obj)
- public override SimpleJSON.JSONNode.Enumerator GetEnumerator()
- public override int GetHashCode()
- internal override void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON.JSONTextMode aMode)

### internal class SimpleJSON.JSONLazyCreator
- Base: SimpleJSON.JSONNode

#### Fields
- private string m_Key
- private SimpleJSON.JSONNode m_Node

#### Properties
- public SimpleJSON.JSONArray AsArray { get; }
- public bool AsBool { get; set; }
- public double AsDouble { get; set; }
- public float AsFloat { get; set; }
- public int AsInt { get; set; }
- public long AsLong { get; set; }
- public SimpleJSON.JSONObject AsObject { get; }
- public ulong AsULong { get; set; }
- public SimpleJSON.JSONNode Item { get; set; }
- public SimpleJSON.JSONNode Item { get; set; }
- public SimpleJSON.JSONNodeType Tag { get; }

#### Constructors
- public JSONLazyCreator(SimpleJSON.JSONNode aNode)
- public JSONLazyCreator(SimpleJSON.JSONNode aNode, string aKey)

#### Methods
- public override void Add(SimpleJSON.JSONNode aItem)
- public override void Add(string aKey, SimpleJSON.JSONNode aItem)
- public override bool Equals(object obj)
- public override SimpleJSON.JSONNode.Enumerator GetEnumerator()
- public override int GetHashCode()
- public static bool op_Equality(SimpleJSON.JSONLazyCreator a, object b)
- public static bool op_Inequality(SimpleJSON.JSONLazyCreator a, object b)
- private T Set<T>(T aVal)
- internal override void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON.JSONTextMode aMode)

### public class SimpleJSON.JSONNode

#### Fields
- public static bool allowLineComments
- public static bool forceASCII
- public static bool longAsString
- private static System.Text.StringBuilder m_EscapeBuilder

#### Properties
- public SimpleJSON.JSONArray AsArray { get; }
- public bool AsBool { get; set; }
- public double AsDouble { get; set; }
- public float AsFloat { get; set; }
- public int AsInt { get; set; }
- public long AsLong { get; set; }
- public SimpleJSON.JSONObject AsObject { get; }
- public ulong AsULong { get; set; }
- public System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> Children { get; }
- public int Count { get; }
- public System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> DeepChildren { get; }
- internal static System.Text.StringBuilder EscapeBuilder { get; }
- public bool Inline { get; set; }
- public bool IsArray { get; }
- public bool IsBoolean { get; }
- public bool IsNull { get; }
- public bool IsNumber { get; }
- public bool IsObject { get; }
- public bool IsString { get; }
- public SimpleJSON.JSONNode Item { get; set; }
- public SimpleJSON.JSONNode Item { get; set; }
- public SimpleJSON.JSONNode.KeyEnumerator Keys { get; }
- public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, SimpleJSON.JSONNode>> Linq { get; }
- public SimpleJSON.JSONNodeType Tag { get; }
- public string Value { get; set; }
- public SimpleJSON.JSONNode.ValueEnumerator Values { get; }

#### Constructors
- protected JSONNode()
- private static JSONNode()

#### Methods
- public virtual void Add(string aKey, SimpleJSON.JSONNode aItem)
- public virtual void Add(SimpleJSON.JSONNode aItem)
- public virtual void Clear()
- public virtual SimpleJSON.JSONNode Clone()
- public override bool Equals(object obj)
- internal static string Escape(string aText)
- public abstract SimpleJSON.JSONNode.Enumerator GetEnumerator()
- public override int GetHashCode()
- public virtual SimpleJSON.JSONNode GetValueOrDefault(string aKey, SimpleJSON.JSONNode aDefault)
- public virtual bool HasKey(string aKey)
- public static bool op_Equality(SimpleJSON.JSONNode a, object b)
- public static SimpleJSON.JSONNode op_Implicit(string s)
- public static string op_Implicit(SimpleJSON.JSONNode d)
- public static SimpleJSON.JSONNode op_Implicit(double n)
- public static double op_Implicit(SimpleJSON.JSONNode d)
- public static SimpleJSON.JSONNode op_Implicit(float n)
- public static float op_Implicit(SimpleJSON.JSONNode d)
- public static SimpleJSON.JSONNode op_Implicit(int n)
- public static int op_Implicit(SimpleJSON.JSONNode d)
- public static SimpleJSON.JSONNode op_Implicit(long n)
- public static long op_Implicit(SimpleJSON.JSONNode d)
- public static SimpleJSON.JSONNode op_Implicit(ulong n)
- public static ulong op_Implicit(SimpleJSON.JSONNode d)
- public static SimpleJSON.JSONNode op_Implicit(bool b)
- public static bool op_Implicit(SimpleJSON.JSONNode d)
- public static SimpleJSON.JSONNode op_Implicit(System.Collections.Generic.KeyValuePair<string, SimpleJSON.JSONNode> aKeyValue)
- public static bool op_Inequality(SimpleJSON.JSONNode a, object b)
- public static SimpleJSON.JSONNode Parse(string aJSON)
- private static SimpleJSON.JSONNode ParseElement(string token, bool quoted)
- public virtual SimpleJSON.JSONNode Remove(string aKey)
- public virtual SimpleJSON.JSONNode Remove(int aIndex)
- public virtual SimpleJSON.JSONNode Remove(SimpleJSON.JSONNode aNode)
- public override string ToString()
- public virtual string ToString(int aIndent)
- internal abstract void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON.JSONTextMode aMode)

### public enum SimpleJSON.JSONNodeType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Array = 1
- Boolean = 6
- Custom = 255
- None = 7
- NullValue = 5
- Number = 4
- Object = 2
- String = 3

### public class SimpleJSON.JSONNull
- Base: SimpleJSON.JSONNode

#### Fields
- private static SimpleJSON.JSONNull m_StaticInstance
- public static bool reuseSameInstance

#### Properties
- public bool AsBool { get; set; }
- public bool IsNull { get; }
- public SimpleJSON.JSONNodeType Tag { get; }
- public string Value { get; set; }

#### Constructors
- private JSONNull()
- private static JSONNull()

#### Methods
- public override SimpleJSON.JSONNode Clone()
- public static SimpleJSON.JSONNull CreateOrGet()
- public override bool Equals(object obj)
- public override SimpleJSON.JSONNode.Enumerator GetEnumerator()
- public override int GetHashCode()
- internal override void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON.JSONTextMode aMode)

### public class SimpleJSON.JSONNumber
- Base: SimpleJSON.JSONNode

#### Fields
- private double m_Data

#### Properties
- public double AsDouble { get; set; }
- public long AsLong { get; set; }
- public ulong AsULong { get; set; }
- public bool IsNumber { get; }
- public SimpleJSON.JSONNodeType Tag { get; }
- public string Value { get; set; }

#### Constructors
- public JSONNumber(double aData)
- public JSONNumber(string aData)

#### Methods
- public override void Clear()
- public override SimpleJSON.JSONNode Clone()
- public override bool Equals(object obj)
- public override SimpleJSON.JSONNode.Enumerator GetEnumerator()
- public override int GetHashCode()
- private static bool IsNumeric(object value)
- internal override void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON.JSONTextMode aMode)

### public class SimpleJSON.JSONObject
- Base: SimpleJSON.JSONNode

#### Fields
- private bool inline
- private System.Collections.Generic.Dictionary<string, SimpleJSON.JSONNode> m_Dict

#### Properties
- public System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> Children { get; }
- public int Count { get; }
- public bool Inline { get; set; }
- public bool IsObject { get; }
- public SimpleJSON.JSONNode Item { get; set; }
- public SimpleJSON.JSONNode Item { get; set; }
- public SimpleJSON.JSONNodeType Tag { get; }

#### Constructors
- public JSONObject()

#### Methods
- public override void Add(string aKey, SimpleJSON.JSONNode aItem)
- public override void Clear()
- public override SimpleJSON.JSONNode Clone()
- public override SimpleJSON.JSONNode.Enumerator GetEnumerator()
- public override SimpleJSON.JSONNode GetValueOrDefault(string aKey, SimpleJSON.JSONNode aDefault)
- public override bool HasKey(string aKey)
- public override SimpleJSON.JSONNode Remove(string aKey)
- public override SimpleJSON.JSONNode Remove(int aIndex)
- public override SimpleJSON.JSONNode Remove(SimpleJSON.JSONNode aNode)
- internal override void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON.JSONTextMode aMode)

### public class SimpleJSON.JSONString
- Base: SimpleJSON.JSONNode

#### Fields
- private string m_Data

#### Properties
- public bool IsString { get; }
- public SimpleJSON.JSONNodeType Tag { get; }
- public string Value { get; set; }

#### Constructors
- public JSONString(string aData)

#### Methods
- public override void Clear()
- public override SimpleJSON.JSONNode Clone()
- public override bool Equals(object obj)
- public override SimpleJSON.JSONNode.Enumerator GetEnumerator()
- public override int GetHashCode()
- internal override void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON.JSONTextMode aMode)

### public enum SimpleJSON.JSONTextMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Compact = 0
- Indent = 1

### public struct SimpleJSON.JSONNode.KeyEnumerator

#### Fields
- private SimpleJSON.JSONNode.Enumerator m_Enumerator

#### Properties
- public string Current { get; }

#### Constructors
- public JSONNode.KeyEnumerator(System.Collections.Generic.List<T>.Enumerator<SimpleJSON.JSONNode> aArrayEnum)
- public JSONNode.KeyEnumerator(System.Collections.Generic.Dictionary<TKey, TValue>.Enumerator<string, SimpleJSON.JSONNode> aDictEnum)
- public JSONNode.KeyEnumerator(SimpleJSON.JSONNode.Enumerator aEnumerator)

#### Methods
- public SimpleJSON.JSONNode.KeyEnumerator GetEnumerator()
- public bool MoveNext()

### public class SimpleJSON.JSONNode.LinqEnumerator
- Interfaces: System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, SimpleJSON.JSONNode>>, System.IDisposable, System.Collections.IEnumerator, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, SimpleJSON.JSONNode>>, System.Collections.IEnumerable

#### Fields
- private SimpleJSON.JSONNode.Enumerator m_Enumerator
- private SimpleJSON.JSONNode m_Node

#### Properties
- public System.Collections.Generic.KeyValuePair<string, SimpleJSON.JSONNode> Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- internal JSONNode.LinqEnumerator(SimpleJSON.JSONNode aNode)

#### Methods
- public void Dispose()
- public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, SimpleJSON.JSONNode>> GetEnumerator()
- public bool MoveNext()
- public void Reset()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()

### private enum SimpleJSON.JSONNode.Enumerator.Type
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Array = 1
- None = 0
- Object = 2

### public struct SimpleJSON.JSONNode.ValueEnumerator

#### Fields
- private SimpleJSON.JSONNode.Enumerator m_Enumerator

#### Properties
- public SimpleJSON.JSONNode Current { get; }

#### Constructors
- public JSONNode.ValueEnumerator(System.Collections.Generic.List<T>.Enumerator<SimpleJSON.JSONNode> aArrayEnum)
- public JSONNode.ValueEnumerator(System.Collections.Generic.Dictionary<TKey, TValue>.Enumerator<string, SimpleJSON.JSONNode> aDictEnum)
- public JSONNode.ValueEnumerator(SimpleJSON.JSONNode.Enumerator aEnumerator)

#### Methods
- public SimpleJSON.JSONNode.ValueEnumerator GetEnumerator()
- public bool MoveNext()

