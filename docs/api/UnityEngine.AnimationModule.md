# Assembly: UnityEngine.AnimationModule
- Path: tools/WorldBox.Managed/UnityEngine.AnimationModule.dll
- Types: 107

## Namespace: UnityEngine

### public class UnityEngine.Animation
- Base: UnityEngine.Behaviour
- Interfaces: System.Collections.IEnumerable

#### Properties
- public bool animateOnlyIfVisible { get; set; }
- public bool animatePhysics { get; set; }
- public UnityEngine.AnimationClip clip { get; set; }
- public UnityEngine.AnimationCullingType cullingType { get; set; }
- public bool isPlaying { get; }
- public UnityEngine.AnimationState Item { get; }
- public UnityEngine.Bounds localBounds { get; set; }
- public bool playAutomatically { get; set; }
- public UnityEngine.WrapMode wrapMode { get; set; }

#### Constructors
- public Animation()

#### Methods
- public void AddClip(UnityEngine.AnimationClip clip, string newName)
- public void AddClip(UnityEngine.AnimationClip clip, string newName, int firstFrame, int lastFrame)
- public void AddClip(UnityEngine.AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame)
- public void Blend(string animation)
- public void Blend(string animation, float targetWeight)
- public void Blend(string animation, float targetWeight, float fadeLength)
- public void CrossFade(string animation)
- public void CrossFade(string animation, float fadeLength)
- public void CrossFade(string animation, float fadeLength, UnityEngine.PlayMode mode)
- public UnityEngine.AnimationState CrossFadeQueued(string animation)
- public UnityEngine.AnimationState CrossFadeQueued(string animation, float fadeLength)
- public UnityEngine.AnimationState CrossFadeQueued(string animation, float fadeLength, UnityEngine.QueueMode queue)
- public UnityEngine.AnimationState CrossFadeQueued(string animation, float fadeLength, UnityEngine.QueueMode queue, UnityEngine.PlayMode mode)
- public UnityEngine.AnimationClip GetClip(string name)
- public int GetClipCount()
- public System.Collections.IEnumerator GetEnumerator()
- internal UnityEngine.AnimationState GetState(string name)
- internal UnityEngine.AnimationState GetStateAtIndex(int index)
- internal int GetStateCount()
- public bool IsPlaying(string name)
- public bool Play()
- public bool Play(UnityEngine.PlayMode mode)
- public bool Play(string animation)
- public bool Play(string animation, UnityEngine.PlayMode mode)
- public bool Play(UnityEngine.AnimationPlayMode mode)
- public bool Play(string animation, UnityEngine.AnimationPlayMode mode)
- private bool PlayDefaultAnimation(UnityEngine.PlayMode mode)
- public UnityEngine.AnimationState PlayQueued(string animation)
- public UnityEngine.AnimationState PlayQueued(string animation, UnityEngine.QueueMode queue)
- public UnityEngine.AnimationState PlayQueued(string animation, UnityEngine.QueueMode queue, UnityEngine.PlayMode mode)
- public void RemoveClip(UnityEngine.AnimationClip clip)
- public void RemoveClip(string clipName)
- private void RemoveClipNamed(string clipName)
- public void Rewind()
- public void Rewind(string name)
- private void RewindNamed(string name)
- public void Sample()
- public void Stop()
- public void Stop(string name)
- private void StopNamed(string name)
- public void SyncLayer(int layer)

### public enum UnityEngine.AnimationBlendMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Additive = 1
- Blend = 0

### public class UnityEngine.AnimationClip
- Base: UnityEngine.Motion

#### Properties
- public bool empty { get; }
- public UnityEngine.AnimationEvent[] events { get; set; }
- public float frameRate { get; set; }
- public bool hasGenericRootTransform { get; }
- public bool hasMotionCurves { get; }
- public bool hasMotionFloatCurves { get; }
- public bool hasRootCurves { get; }
- internal bool hasRootMotion { get; }
- public bool humanMotion { get; }
- public bool legacy { get; set; }
- public float length { get; }
- public UnityEngine.Bounds localBounds { get; set; }
- internal float startTime { get; }
- internal float stopTime { get; }
- public UnityEngine.WrapMode wrapMode { get; set; }

#### Constructors
- public AnimationClip()

#### Methods
- public void AddEvent(UnityEngine.AnimationEvent evt)
- private void AddEventInternal(object evt)
- public void ClearCurves()
- public void EnsureQuaternionContinuity()
- private System.Array GetEventsInternal()
- private static void Internal_CreateAnimationClip(UnityEngine.AnimationClip self)
- public void SampleAnimation(UnityEngine.GameObject go, float time)
- internal static void SampleAnimation(UnityEngine.GameObject go, UnityEngine.AnimationClip clip, float inTime, UnityEngine.WrapMode wrapMode)
- public void SetCurve(string relativePath, System.Type type, string propertyName, UnityEngine.AnimationCurve curve)
- private void SetEventsInternal(System.Array value)

### public class UnityEngine.AnimationClipPair

#### Fields
- public UnityEngine.AnimationClip originalClip
- public UnityEngine.AnimationClip overrideClip

#### Constructors
- public AnimationClipPair()

### public enum UnityEngine.AnimationCullingType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AlwaysAnimate = 0
- BasedOnClipBounds = 2
- BasedOnRenderers = 1
- BasedOnUserBounds = 3

### public class UnityEngine.AnimationEvent

#### Fields
- internal UnityEngine.AnimatorClipInfo m_AnimatorClipInfo
- internal UnityEngine.AnimatorStateInfo m_AnimatorStateInfo
- internal float m_FloatParameter
- internal string m_FunctionName
- internal int m_IntParameter
- internal int m_MessageOptions
- internal UnityEngine.Object m_ObjectReferenceParameter
- internal UnityEngine.AnimationEventSource m_Source
- internal UnityEngine.AnimationState m_StateSender
- internal string m_StringParameter
- internal float m_Time

#### Properties
- public UnityEngine.AnimationState animationState { get; }
- public UnityEngine.AnimatorClipInfo animatorClipInfo { get; }
- public UnityEngine.AnimatorStateInfo animatorStateInfo { get; }
- public string data { get; set; }
- public float floatParameter { get; set; }
- public string functionName { get; set; }
- public int intParameter { get; set; }
- public bool isFiredByAnimator { get; }
- public bool isFiredByLegacy { get; }
- public UnityEngine.SendMessageOptions messageOptions { get; set; }
- public UnityEngine.Object objectReferenceParameter { get; set; }
- public string stringParameter { get; set; }
- public float time { get; set; }

#### Constructors
- public AnimationEvent()

#### Methods
- internal int GetHash()

### internal enum UnityEngine.AnimationEventSource
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Animator = 2
- Legacy = 1
- NoSource = 0

### public enum UnityEngine.AnimationPlayMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Mix = 2
- Queue = 1
- Stop = 0

### public class UnityEngine.AnimationState
- Base: UnityEngine.TrackedReference

#### Properties
- public UnityEngine.AnimationBlendMode blendMode { get; set; }
- public UnityEngine.AnimationClip clip { get; }
- public bool enabled { get; set; }
- public int layer { get; set; }
- public float length { get; }
- public string name { get; set; }
- public float normalizedSpeed { get; set; }
- public float normalizedTime { get; set; }
- public float speed { get; set; }
- public float time { get; set; }
- public float weight { get; set; }
- public UnityEngine.WrapMode wrapMode { get; set; }

#### Constructors
- public AnimationState()

#### Methods
- public void AddMixingTransform(UnityEngine.Transform mix)
- public void AddMixingTransform(UnityEngine.Transform mix, bool recursive)
- public void RemoveMixingTransform(UnityEngine.Transform mix)

### public class UnityEngine.Animator
- Base: UnityEngine.Behaviour

#### Properties
- internal bool allowConstantClipSamplingOptimization { get; set; }
- public UnityEngine.Vector3 angularVelocity { get; }
- public bool animatePhysics { get; set; }
- public bool applyRootMotion { get; set; }
- public UnityEngine.Avatar avatar { get; set; }
- public UnityEngine.Transform avatarRoot { get; }
- public UnityEngine.Vector3 bodyPosition { get; set; }
- internal UnityEngine.Vector3 bodyPositionInternal { get; set; }
- public UnityEngine.Quaternion bodyRotation { get; set; }
- internal UnityEngine.Quaternion bodyRotationInternal { get; set; }
- public UnityEngine.AnimatorCullingMode cullingMode { get; set; }
- public UnityEngine.Vector3 deltaPosition { get; }
- public UnityEngine.Quaternion deltaRotation { get; }
- public float feetPivotActive { get; set; }
- public bool fireEvents { get; set; }
- public float gravityWeight { get; }
- public bool hasBoundPlayables { get; }
- public bool hasRootMotion { get; }
- public bool hasTransformHierarchy { get; }
- public float humanScale { get; }
- public bool isHuman { get; }
- public bool isInitialized { get; }
- public bool isMatchingTarget { get; }
- public bool isOptimizable { get; }
- internal bool isRootPositionOrRotationControlledByCurves { get; }
- public bool keepAnimatorControllerStateOnDisable { get; set; }
- public bool keepAnimatorStateOnDisable { get; set; }
- public int layerCount { get; }
- public bool layersAffectMassCenter { get; set; }
- public float leftFeetBottomHeight { get; }
- public bool linearVelocityBlending { get; set; }
- public bool logWarnings { get; set; }
- public int parameterCount { get; }
- public UnityEngine.AnimatorControllerParameter[] parameters { get; }
- public UnityEngine.Vector3 pivotPosition { get; }
- public float pivotWeight { get; }
- public UnityEngine.Playables.PlayableGraph playableGraph { get; }
- public float playbackTime { get; set; }
- public UnityEngine.AnimatorRecorderMode recorderMode { get; }
- public float recorderStartTime { get; set; }
- public float recorderStopTime { get; set; }
- public float rightFeetBottomHeight { get; }
- public UnityEngine.Vector3 rootPosition { get; set; }
- public UnityEngine.Quaternion rootRotation { get; set; }
- public UnityEngine.RuntimeAnimatorController runtimeAnimatorController { get; set; }
- public float speed { get; set; }
- public bool stabilizeFeet { get; set; }
- internal bool supportsOnAnimatorMove { get; }
- public UnityEngine.Vector3 targetPosition { get; }
- public UnityEngine.Quaternion targetRotation { get; }
- public UnityEngine.AnimatorUpdateMode updateMode { get; set; }
- public UnityEngine.Vector3 velocity { get; }
- public bool writeDefaultValuesOnDisable { get; set; }

#### Constructors
- public Animator()

#### Methods
- public void ApplyBuiltinRootMotion()
- private void CheckIfInIKPass()
- internal void ClearInternalControllerPlayable()
- private static T[] ConvertStateMachineBehaviour<T>(UnityEngine.ScriptableObject[] rawObjects)
- public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset)
- public void CrossFade(string stateName, float normalizedTransitionDuration, int layer)
- public void CrossFade(string stateName, float normalizedTransitionDuration)
- public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime)
- public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime)
- public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset)
- public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer)
- public void CrossFade(int stateHashName, float normalizedTransitionDuration)
- public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration)
- public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer)
- public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset)
- public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime)
- public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset)
- public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer)
- public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration)
- public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime)
- internal void EvaluateController()
- private void EvaluateController(float deltaTime)
- public void ForceStateNormalizedTime(float normalizedTime)
- internal int GetAnimatorClipInfoCount(int layerIndex, bool current)
- private void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips)
- private void GetAnimatorStateInfo(int layerIndex, UnityEngine.StateInfoIndex stateInfoIndex, out UnityEngine.AnimatorStateInfo info)
- private string GetAnimatorStateName(int layerIndex, bool current)
- private void GetAnimatorTransitionInfo(int layerIndex, out UnityEngine.AnimatorTransitionInfo info)
- public UnityEngine.AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex)
- private UnityEngine.ScriptableObject GetBehaviour(System.Type type)
- public T GetBehaviour<T>()
- public T[] GetBehaviours<T>()
- public UnityEngine.StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex)
- public UnityEngine.Transform GetBoneTransform(UnityEngine.HumanBodyBones humanBoneId)
- internal UnityEngine.Transform GetBoneTransformInternal(int humanBoneId)
- public bool GetBool(string name)
- public bool GetBool(int id)
- private bool GetBoolID(int id)
- private bool GetBoolString(string name)
- public UnityEngine.AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex)
- public void GetCurrentAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips)
- public int GetCurrentAnimatorClipInfoCount(int layerIndex)
- public UnityEngine.AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex)
- private void GetCurrentGraph(ref UnityEngine.Playables.PlayableGraph graph)
- internal string GetCurrentStateName(int layerIndex)
- public float GetFloat(string name)
- public float GetFloat(int id)
- private float GetFloatID(int id)
- private float GetFloatString(string name)
- private UnityEngine.Vector3 GetGoalPosition(UnityEngine.AvatarIKGoal goal)
- private void GetGoalPosition_Injected(UnityEngine.AvatarIKGoal goal, out UnityEngine.Vector3 ret)
- private UnityEngine.Quaternion GetGoalRotation(UnityEngine.AvatarIKGoal goal)
- private void GetGoalRotation_Injected(UnityEngine.AvatarIKGoal goal, out UnityEngine.Quaternion ret)
- private float GetGoalWeightPosition(UnityEngine.AvatarIKGoal goal)
- private float GetGoalWeightRotation(UnityEngine.AvatarIKGoal goal)
- private UnityEngine.Vector3 GetHintPosition(UnityEngine.AvatarIKHint hint)
- private void GetHintPosition_Injected(UnityEngine.AvatarIKHint hint, out UnityEngine.Vector3 ret)
- private float GetHintWeightPosition(UnityEngine.AvatarIKHint hint)
- public UnityEngine.Vector3 GetIKHintPosition(UnityEngine.AvatarIKHint hint)
- public float GetIKHintPositionWeight(UnityEngine.AvatarIKHint hint)
- public UnityEngine.Vector3 GetIKPosition(UnityEngine.AvatarIKGoal goal)
- public float GetIKPositionWeight(UnityEngine.AvatarIKGoal goal)
- public UnityEngine.Quaternion GetIKRotation(UnityEngine.AvatarIKGoal goal)
- public float GetIKRotationWeight(UnityEngine.AvatarIKGoal goal)
- public int GetInteger(string name)
- public int GetInteger(int id)
- private int GetIntegerID(int id)
- private int GetIntegerString(string name)
- public int GetLayerIndex(string layerName)
- public string GetLayerName(int layerIndex)
- public float GetLayerWeight(int layerIndex)
- public UnityEngine.AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex)
- public void GetNextAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips)
- public int GetNextAnimatorClipInfoCount(int layerIndex)
- public UnityEngine.AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex)
- internal string GetNextStateName(int layerIndex)
- public UnityEngine.AnimatorControllerParameter GetParameter(int index)
- private UnityEngine.AnimatorControllerParameter GetParameterInternal(int index)
- public UnityEngine.Quaternion GetQuaternion(string name)
- public UnityEngine.Quaternion GetQuaternion(int id)
- private float GetRecorderStartTime()
- private float GetRecorderStopTime()
- internal string GetStats()
- public UnityEngine.Vector3 GetVector(string name)
- public UnityEngine.Vector3 GetVector(int id)
- public bool HasState(int layerIndex, int stateID)
- internal UnityEngine.ScriptableObject[] InternalGetBehaviours(System.Type type)
- internal UnityEngine.ScriptableObject[] InternalGetBehavioursByKey(int fullPathHash, int layerIndex, System.Type type)
- public void InterruptMatchTarget()
- public void InterruptMatchTarget(bool completeMatch)
- internal bool IsBoneTransform(UnityEngine.Transform transform)
- public bool IsControlled(UnityEngine.Transform transform)
- private bool IsInIKPass()
- public bool IsInTransition(int layerIndex)
- public bool IsParameterControlledByCurve(string name)
- public bool IsParameterControlledByCurve(int id)
- private bool IsParameterControlledByCurveID(int id)
- private bool IsParameterControlledByCurveString(string name)
- private void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, int targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch)
- public void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime)
- public void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime)
- public void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch)
- private void MatchTarget_Injected(ref UnityEngine.Vector3 matchPosition, ref UnityEngine.Quaternion matchRotation, int targetBodyPart, ref UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch)
- internal void OnCullingModeChanged()
- internal void OnUpdateModeChanged()
- public void Play(string stateName, int layer)
- public void Play(string stateName)
- public void Play(string stateName, int layer, float normalizedTime)
- public void Play(int stateNameHash, int layer, float normalizedTime)
- public void Play(int stateNameHash, int layer)
- public void Play(int stateNameHash)
- public void PlayInFixedTime(string stateName, int layer)
- public void PlayInFixedTime(string stateName)
- public void PlayInFixedTime(string stateName, int layer, float fixedTime)
- public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime)
- public void PlayInFixedTime(int stateNameHash, int layer)
- public void PlayInFixedTime(int stateNameHash)
- public void Rebind()
- private void Rebind(bool writeDefaultValues)
- public void ResetTrigger(string name)
- public void ResetTrigger(int id)
- private void ResetTriggerID(int id)
- private void ResetTriggerString(string name)
- internal string ResolveHash(int hash)
- public void SetBoneLocalRotation(UnityEngine.HumanBodyBones humanBoneId, UnityEngine.Quaternion rotation)
- private void SetBoneLocalRotationInternal(int humanBoneId, UnityEngine.Quaternion rotation)
- private void SetBoneLocalRotationInternal_Injected(int humanBoneId, ref UnityEngine.Quaternion rotation)
- public void SetBool(string name, bool value)
- public void SetBool(int id, bool value)
- private void SetBoolID(int id, bool value)
- private void SetBoolString(string name, bool value)
- public void SetFloat(string name, float value)
- public void SetFloat(string name, float value, float dampTime, float deltaTime)
- public void SetFloat(int id, float value)
- public void SetFloat(int id, float value, float dampTime, float deltaTime)
- private void SetFloatID(int id, float value)
- private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime)
- private void SetFloatString(string name, float value)
- private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime)
- private void SetGoalPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 goalPosition)
- private void SetGoalPosition_Injected(UnityEngine.AvatarIKGoal goal, ref UnityEngine.Vector3 goalPosition)
- private void SetGoalRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion goalRotation)
- private void SetGoalRotation_Injected(UnityEngine.AvatarIKGoal goal, ref UnityEngine.Quaternion goalRotation)
- private void SetGoalWeightPosition(UnityEngine.AvatarIKGoal goal, float value)
- private void SetGoalWeightRotation(UnityEngine.AvatarIKGoal goal, float value)
- private void SetHintPosition(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3 hintPosition)
- private void SetHintPosition_Injected(UnityEngine.AvatarIKHint hint, ref UnityEngine.Vector3 hintPosition)
- private void SetHintWeightPosition(UnityEngine.AvatarIKHint hint, float value)
- public void SetIKHintPosition(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3 hintPosition)
- public void SetIKHintPositionWeight(UnityEngine.AvatarIKHint hint, float value)
- public void SetIKPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 goalPosition)
- public void SetIKPositionWeight(UnityEngine.AvatarIKGoal goal, float value)
- public void SetIKRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion goalRotation)
- public void SetIKRotationWeight(UnityEngine.AvatarIKGoal goal, float value)
- public void SetInteger(string name, int value)
- public void SetInteger(int id, int value)
- private void SetIntegerID(int id, int value)
- private void SetIntegerString(string name, int value)
- public void SetLayerWeight(int layerIndex, float weight)
- public void SetLookAtPosition(UnityEngine.Vector3 lookAtPosition)
- private void SetLookAtPositionInternal(UnityEngine.Vector3 lookAtPosition)
- private void SetLookAtPositionInternal_Injected(ref UnityEngine.Vector3 lookAtPosition)
- public void SetLookAtWeight(float weight)
- public void SetLookAtWeight(float weight, float bodyWeight)
- public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
- public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
- public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
- private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
- public void SetQuaternion(string name, UnityEngine.Quaternion value)
- public void SetQuaternion(int id, UnityEngine.Quaternion value)
- public void SetTarget(UnityEngine.AvatarTarget targetIndex, float targetNormalizedTime)
- public void SetTrigger(string name)
- public void SetTrigger(int id)
- private void SetTriggerID(int id)
- private void SetTriggerString(string name)
- public void SetVector(string name, UnityEngine.Vector3 value)
- public void SetVector(int id, UnityEngine.Vector3 value)
- public void StartPlayback()
- public void StartRecording(int frameCount)
- public void StopPlayback()
- public void StopRecording()
- public static int StringToHash(string name)
- public void Update(float deltaTime)
- internal void WriteDefaultPose()
- public void WriteDefaultValues()

### public struct UnityEngine.AnimatorClipInfo

#### Fields
- private int m_ClipInstanceID
- private float m_Weight

#### Properties
- public UnityEngine.AnimationClip clip { get; }
- public float weight { get; }

#### Methods
- private static UnityEngine.AnimationClip InstanceIDToAnimationClipPPtr(int instanceID)

### public class UnityEngine.AnimatorControllerParameter

#### Fields
- internal bool m_DefaultBool
- internal float m_DefaultFloat
- internal int m_DefaultInt
- internal string m_Name
- internal UnityEngine.AnimatorControllerParameterType m_Type

#### Properties
- public bool defaultBool { get; set; }
- public float defaultFloat { get; set; }
- public int defaultInt { get; set; }
- public string name { get; }
- public int nameHash { get; }
- public UnityEngine.AnimatorControllerParameterType type { get; set; }

#### Constructors
- public AnimatorControllerParameter()

#### Methods
- public override bool Equals(object o)
- public override int GetHashCode()

### public enum UnityEngine.AnimatorControllerParameterType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Bool = 4
- Float = 1
- Int = 3
- Trigger = 9

### internal static class UnityEngine.AnimatorControllerParameterTypeConstants

#### Fields
- public static const int InvalidType

### public enum UnityEngine.AnimatorCullingMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AlwaysAnimate = 0
- CullCompletely = 2
- CullUpdateTransforms = 1

### public class UnityEngine.AnimatorOverrideController
- Base: UnityEngine.RuntimeAnimatorController

#### Fields
- internal UnityEngine.AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty

#### Properties
- public UnityEngine.AnimationClipPair[] clips { get; set; }
- public UnityEngine.AnimationClip Item { get; set; }
- public UnityEngine.AnimationClip Item { get; set; }
- public int overridesCount { get; }
- public UnityEngine.RuntimeAnimatorController runtimeAnimatorController { get; set; }

#### Constructors
- public AnimatorOverrideController()
- public AnimatorOverrideController(UnityEngine.RuntimeAnimatorController controller)

#### Methods
- public void ApplyOverrides(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>> overrides)
- private UnityEngine.AnimationClip GetClip(UnityEngine.AnimationClip originalClip, bool returnEffectiveClip)
- private UnityEngine.AnimationClip GetOriginalClip(int index)
- private UnityEngine.AnimationClip GetOverrideClip(UnityEngine.AnimationClip originalClip)
- public void GetOverrides(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>> overrides)
- private static void Internal_Create(UnityEngine.AnimatorOverrideController self, UnityEngine.RuntimeAnimatorController controller)
- private UnityEngine.AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip)
- private void Internal_SetClipByName(string name, UnityEngine.AnimationClip clip)
- internal static void OnInvalidateOverrideController(UnityEngine.AnimatorOverrideController controller)
- internal void PerformOverrideClipListCleanup()
- private void SendNotification()
- private void SetClip(UnityEngine.AnimationClip originalClip, UnityEngine.AnimationClip overrideClip, bool notify)

### public enum UnityEngine.AnimatorRecorderMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Offline = 0
- Playback = 1
- Record = 2

### public struct UnityEngine.AnimatorStateInfo

#### Fields
- private int m_FullPath
- private float m_Length
- private int m_Loop
- private int m_Name
- private float m_NormalizedTime
- private int m_Path
- private float m_Speed
- private float m_SpeedMultiplier
- private int m_Tag

#### Properties
- public int fullPathHash { get; }
- public float length { get; }
- public bool loop { get; }
- public int nameHash { get; }
- public float normalizedTime { get; }
- public int shortNameHash { get; }
- public float speed { get; }
- public float speedMultiplier { get; }
- public int tagHash { get; }

#### Methods
- public bool IsName(string name)
- public bool IsTag(string tag)

### public struct UnityEngine.AnimatorTransitionInfo

#### Fields
- private bool m_AnyState
- private float m_Duration
- private int m_FullPath
- private bool m_HasFixedDuration
- private int m_Name
- private float m_NormalizedTime
- private int m_TransitionType
- private int m_UserName

#### Properties
- public bool anyState { get; }
- public float duration { get; }
- public UnityEngine.DurationUnit durationUnit { get; }
- internal bool entry { get; }
- internal bool exit { get; }
- public int fullPathHash { get; }
- public int nameHash { get; }
- public float normalizedTime { get; }
- public int userNameHash { get; }

#### Methods
- public bool IsName(string name)
- public bool IsUserName(string name)

### public enum UnityEngine.AnimatorUpdateMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AnimatePhysics = 1
- Normal = 0
- UnscaledTime = 2

### public class UnityEngine.AnimatorUtility

#### Constructors
- public AnimatorUtility()

#### Methods
- public static void DeoptimizeTransformHierarchy(UnityEngine.GameObject go)
- public static void OptimizeTransformHierarchy(UnityEngine.GameObject go, string[] exposedTransforms)

### public enum UnityEngine.ArmDof
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ArmDownUp = 2
- ArmFrontBack = 3
- ArmRollInOut = 4
- ForeArmCloseOpen = 5
- ForeArmRollInOut = 6
- HandDownUp = 7
- HandInOut = 8
- LastArmDof = 9
- ShoulderDownUp = 0
- ShoulderFrontBack = 1

### public class UnityEngine.Avatar
- Base: UnityEngine.Object

#### Properties
- public UnityEngine.HumanDescription humanDescription { get; }
- public bool isHuman { get; }
- public bool isValid { get; }

#### Constructors
- private Avatar()

#### Methods
- internal float GetAxisLength(int humanId)
- internal UnityEngine.Vector3 GetLimitSign(int humanId)
- internal UnityEngine.Quaternion GetPostRotation(int humanId)
- internal UnityEngine.Quaternion GetPreRotation(int humanId)
- internal UnityEngine.Quaternion GetZYPostQ(int humanId, UnityEngine.Quaternion parentQ, UnityEngine.Quaternion q)
- internal UnityEngine.Quaternion GetZYRoll(int humanId, UnityEngine.Vector3 uvw)
- internal float Internal_GetAxisLength(int humanId)
- internal UnityEngine.Vector3 Internal_GetLimitSign(int humanId)
- private void Internal_GetLimitSign_Injected(int humanId, out UnityEngine.Vector3 ret)
- internal UnityEngine.Quaternion Internal_GetPostRotation(int humanId)
- private void Internal_GetPostRotation_Injected(int humanId, out UnityEngine.Quaternion ret)
- internal UnityEngine.Quaternion Internal_GetPreRotation(int humanId)
- private void Internal_GetPreRotation_Injected(int humanId, out UnityEngine.Quaternion ret)
- internal UnityEngine.Quaternion Internal_GetZYPostQ(int humanId, UnityEngine.Quaternion parentQ, UnityEngine.Quaternion q)
- private void Internal_GetZYPostQ_Injected(int humanId, ref UnityEngine.Quaternion parentQ, ref UnityEngine.Quaternion q, out UnityEngine.Quaternion ret)
- internal UnityEngine.Quaternion Internal_GetZYRoll(int humanId, UnityEngine.Vector3 uvw)
- private void Internal_GetZYRoll_Injected(int humanId, ref UnityEngine.Vector3 uvw, out UnityEngine.Quaternion ret)
- internal void SetMuscleMinMax(int muscleId, float min, float max)
- internal void SetParameter(int parameterId, float value)

### public class UnityEngine.AvatarBuilder

#### Constructors
- public AvatarBuilder()

#### Methods
- public static UnityEngine.Avatar BuildGenericAvatar(UnityEngine.GameObject go, string rootMotionTransformName)
- public static UnityEngine.Avatar BuildHumanAvatar(UnityEngine.GameObject go, UnityEngine.HumanDescription humanDescription)
- private static UnityEngine.Avatar BuildHumanAvatarInternal(UnityEngine.GameObject go, UnityEngine.HumanDescription humanDescription)
- private static UnityEngine.Avatar BuildHumanAvatarInternal_Injected(UnityEngine.GameObject go, ref UnityEngine.HumanDescription humanDescription)

### public enum UnityEngine.AvatarIKGoal
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- LeftFoot = 0
- LeftHand = 2
- RightFoot = 1
- RightHand = 3

### public enum UnityEngine.AvatarIKHint
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- LeftElbow = 2
- LeftKnee = 0
- RightElbow = 3
- RightKnee = 1

### public class UnityEngine.AvatarMask
- Base: UnityEngine.Object

#### Properties
- internal bool hasFeetIK { get; }
- public int humanoidBodyPartCount { get; }
- public int transformCount { get; set; }

#### Constructors
- public AvatarMask()

#### Methods
- public void AddTransformPath(UnityEngine.Transform transform)
- public void AddTransformPath(UnityEngine.Transform transform, bool recursive)
- internal void Copy(UnityEngine.AvatarMask other)
- public bool GetHumanoidBodyPartActive(UnityEngine.AvatarMaskBodyPart index)
- public bool GetTransformActive(int index)
- public string GetTransformPath(int index)
- private float GetTransformWeight(int index)
- private static void Internal_Create(UnityEngine.AvatarMask self)
- public void RemoveTransformPath(UnityEngine.Transform transform)
- public void RemoveTransformPath(UnityEngine.Transform transform, bool recursive)
- public void SetHumanoidBodyPartActive(UnityEngine.AvatarMaskBodyPart index, bool value)
- public void SetTransformActive(int index, bool value)
- public void SetTransformPath(int index, string path)
- private void SetTransformWeight(int index, float weight)

### public enum UnityEngine.AvatarMaskBodyPart
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Body = 1
- Head = 2
- LastBodyPart = 13
- LeftArm = 5
- LeftFingers = 7
- LeftFootIK = 9
- LeftHandIK = 11
- LeftLeg = 3
- RightArm = 6
- RightFingers = 8
- RightFootIK = 10
- RightHandIK = 12
- RightLeg = 4
- Root = 0

### public enum UnityEngine.AvatarTarget
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Body = 1
- LeftFoot = 2
- LeftHand = 4
- RightFoot = 3
- RightHand = 5
- Root = 0

### public enum UnityEngine.BodyDof
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ChestFrontBack = 3
- ChestLeftRight = 4
- ChestRollLeftRight = 5
- LastBodyDof = 9
- SpineFrontBack = 0
- SpineLeftRight = 1
- SpineRollLeftRight = 2
- UpperChestFrontBack = 6
- UpperChestLeftRight = 7
- UpperChestRollLeftRight = 8

### internal enum UnityEngine.Dof
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BodyDofStart = 0
- HeadDofStart = 9
- LastDof = 95
- LeftArmDofStart = 37
- LeftIndexDofStart = 59
- LeftLegDofStart = 21
- LeftLittleDofStart = 71
- LeftMiddleDofStart = 63
- LeftRingDofStart = 67
- LeftThumbDofStart = 55
- RightArmDofStart = 46
- RightIndexDofStart = 79
- RightLegDofStart = 29
- RightLittleDofStart = 91
- RightMiddleDofStart = 83
- RightRingDofStart = 87
- RightThumbDofStart = 75

### public enum UnityEngine.DurationUnit
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Fixed = 0
- Normalized = 1

### private class UnityEngine.Animation.Enumerator
- Interfaces: System.Collections.IEnumerator

#### Fields
- private int m_CurrentIndex
- private UnityEngine.Animation m_Outer

#### Properties
- public object Current { get; }

#### Constructors
- internal Animation.Enumerator(UnityEngine.Animation outer)

#### Methods
- public bool MoveNext()
- public void Reset()

### public enum UnityEngine.FingerDof
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DistalCloseOpen = 3
- IntermediateCloseOpen = 2
- LastFingerDof = 4
- ProximalDownUp = 0
- ProximalInOut = 1

### public enum UnityEngine.HeadDof
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- HeadFrontBack = 3
- HeadLeftRight = 4
- HeadRollLeftRight = 5
- JawDownUp = 10
- JawLeftRight = 11
- LastHeadDof = 12
- LeftEyeDownUp = 6
- LeftEyeInOut = 7
- NeckFrontBack = 0
- NeckLeftRight = 1
- NeckRollLeftRight = 2
- RightEyeDownUp = 8
- RightEyeInOut = 9

### public enum UnityEngine.HumanBodyBones
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Chest = 8
- Head = 10
- Hips = 0
- Jaw = 23
- LastBone = 55
- LeftEye = 21
- LeftFoot = 5
- LeftHand = 17
- LeftIndexDistal = 29
- LeftIndexIntermediate = 28
- LeftIndexProximal = 27
- LeftLittleDistal = 38
- LeftLittleIntermediate = 37
- LeftLittleProximal = 36
- LeftLowerArm = 15
- LeftLowerLeg = 3
- LeftMiddleDistal = 32
- LeftMiddleIntermediate = 31
- LeftMiddleProximal = 30
- LeftRingDistal = 35
- LeftRingIntermediate = 34
- LeftRingProximal = 33
- LeftShoulder = 11
- LeftThumbDistal = 26
- LeftThumbIntermediate = 25
- LeftThumbProximal = 24
- LeftToes = 19
- LeftUpperArm = 13
- LeftUpperLeg = 1
- Neck = 9
- RightEye = 22
- RightFoot = 6
- RightHand = 18
- RightIndexDistal = 44
- RightIndexIntermediate = 43
- RightIndexProximal = 42
- RightLittleDistal = 53
- RightLittleIntermediate = 52
- RightLittleProximal = 51
- RightLowerArm = 16
- RightLowerLeg = 4
- RightMiddleDistal = 47
- RightMiddleIntermediate = 46
- RightMiddleProximal = 45
- RightRingDistal = 50
- RightRingIntermediate = 49
- RightRingProximal = 48
- RightShoulder = 12
- RightThumbDistal = 41
- RightThumbIntermediate = 40
- RightThumbProximal = 39
- RightToes = 20
- RightUpperArm = 14
- RightUpperLeg = 2
- Spine = 7
- UpperChest = 54

### public struct UnityEngine.HumanBone

#### Fields
- public UnityEngine.HumanLimit limit
- private string m_BoneName
- private string m_HumanName

#### Properties
- public string boneName { get; set; }
- public string humanName { get; set; }

### public struct UnityEngine.HumanDescription

#### Fields
- public UnityEngine.HumanBone[] human
- internal float m_ArmStretch
- internal float m_ArmTwist
- internal float m_FeetSpacing
- internal float m_ForeArmTwist
- internal float m_GlobalScale
- internal bool m_HasExtraRoot
- internal bool m_HasTranslationDoF
- internal float m_LegStretch
- internal float m_LegTwist
- internal string m_RootMotionBoneName
- internal bool m_SkeletonHasParents
- internal float m_UpperLegTwist
- public UnityEngine.SkeletonBone[] skeleton

#### Properties
- public float armStretch { get; set; }
- public float feetSpacing { get; set; }
- public bool hasTranslationDoF { get; set; }
- public float legStretch { get; set; }
- public float lowerArmTwist { get; set; }
- public float lowerLegTwist { get; set; }
- public float upperArmTwist { get; set; }
- public float upperLegTwist { get; set; }

### public struct UnityEngine.HumanLimit

#### Fields
- private float m_AxisLength
- private UnityEngine.Vector3 m_Center
- private UnityEngine.Vector3 m_Max
- private UnityEngine.Vector3 m_Min
- private int m_UseDefaultValues

#### Properties
- public float axisLength { get; set; }
- public UnityEngine.Vector3 center { get; set; }
- public UnityEngine.Vector3 max { get; set; }
- public UnityEngine.Vector3 min { get; set; }
- public bool useDefaultValues { get; set; }

### internal enum UnityEngine.HumanParameter
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ArmStretch = 4
- FeetSpacing = 6
- LegStretch = 5
- LowerArmTwist = 1
- LowerLegTwist = 3
- UpperArmTwist = 0
- UpperLegTwist = 2

### public enum UnityEngine.HumanPartDof
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Body = 0
- Head = 1
- LastHumanPartDof = 16
- LeftArm = 4
- LeftIndex = 7
- LeftLeg = 2
- LeftLittle = 10
- LeftMiddle = 8
- LeftRing = 9
- LeftThumb = 6
- RightArm = 5
- RightIndex = 12
- RightLeg = 3
- RightLittle = 15
- RightMiddle = 13
- RightRing = 14
- RightThumb = 11

### public struct UnityEngine.HumanPose

#### Fields
- public UnityEngine.Vector3 bodyPosition
- public UnityEngine.Quaternion bodyRotation
- public float[] muscles

#### Methods
- internal void Init()

### public class UnityEngine.HumanPoseHandler
- Interfaces: System.IDisposable

#### Fields
- internal System.IntPtr m_Ptr

#### Constructors
- public HumanPoseHandler(UnityEngine.Avatar avatar, UnityEngine.Transform root)
- public HumanPoseHandler(UnityEngine.Avatar avatar, string[] jointPaths)

#### Methods
- public void Dispose()
- private void GetHumanPose(out UnityEngine.Vector3 bodyPosition, out UnityEngine.Quaternion bodyRotation, float[] muscles)
- public void GetHumanPose(ref UnityEngine.HumanPose humanPose)
- private void GetInternalAvatarPose(void* avatarPose, int avatarPoseLength)
- public void GetInternalAvatarPose(Unity.Collections.NativeArray<float> avatarPose)
- private void GetInternalHumanPose(out UnityEngine.Vector3 bodyPosition, out UnityEngine.Quaternion bodyRotation, float[] muscles)
- public void GetInternalHumanPose(ref UnityEngine.HumanPose humanPose)
- private static System.IntPtr Internal_CreateFromJointPaths(UnityEngine.Avatar avatar, string[] jointPaths)
- private static System.IntPtr Internal_CreateFromRoot(UnityEngine.Avatar avatar, UnityEngine.Transform root)
- private static void Internal_Destroy(System.IntPtr ptr)
- private void SetHumanPose(ref UnityEngine.Vector3 bodyPosition, ref UnityEngine.Quaternion bodyRotation, float[] muscles)
- public void SetHumanPose(ref UnityEngine.HumanPose humanPose)
- private void SetInternalAvatarPose(void* avatarPose, int avatarPoseLength)
- public void SetInternalAvatarPose(Unity.Collections.NativeArray<float> avatarPose)
- private void SetInternalHumanPose(ref UnityEngine.Vector3 bodyPosition, ref UnityEngine.Quaternion bodyRotation, float[] muscles)
- public void SetInternalHumanPose(ref UnityEngine.HumanPose humanPose)

### public class UnityEngine.HumanTrait

#### Properties
- public static int BoneCount { get; }
- public static string[] BoneName { get; }
- public static int MuscleCount { get; }
- public static string[] MuscleName { get; }
- public static int RequiredBoneCount { get; }

#### Constructors
- public HumanTrait()

#### Methods
- public static int BoneFromMuscle(int i)
- public static float GetBoneDefaultHierarchyMass(int i)
- internal static int GetBoneIndexFromMono(int humanId)
- internal static int GetBoneIndexToMono(int boneIndex)
- public static float GetMuscleDefaultMax(int i)
- public static float GetMuscleDefaultMin(int i)
- public static int GetParentBone(int i)
- private static int Internal_BoneFromMuscle(int i)
- private static float Internal_GetBoneHierarchyMass(int i)
- private static int Internal_GetParent(int i)
- private static int Internal_MuscleFromBone(int i, int dofIndex)
- private static bool Internal_RequiredBone(int i)
- public static int MuscleFromBone(int i, int dofIndex)
- public static bool RequiredBone(int i)

### public interface UnityEngine.IAnimationClipSource

#### Methods
- public void GetAnimationClips(System.Collections.Generic.List<UnityEngine.AnimationClip> results)

### public enum UnityEngine.LegDof
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FootCloseOpen = 5
- FootInOut = 6
- LastLegDof = 8
- LegCloseOpen = 3
- LegRollInOut = 4
- ToesUpDown = 7
- UpperLegFrontBack = 0
- UpperLegInOut = 1
- UpperLegRollInOut = 2

### public struct UnityEngine.MatchTargetWeightMask

#### Fields
- private UnityEngine.Vector3 m_PositionXYZWeight
- private float m_RotationWeight

#### Properties
- public UnityEngine.Vector3 positionXYZWeight { get; set; }
- public float rotationWeight { get; set; }

#### Constructors
- public MatchTargetWeightMask(UnityEngine.Vector3 positionXYZWeight, float rotationWeight)

### public class UnityEngine.Motion
- Base: UnityEngine.Object

#### Fields
- private readonly bool <isAnimatorMotion>k__BackingField

#### Properties
- public float apparentSpeed { get; }
- public float averageAngularSpeed { get; }
- public float averageDuration { get; }
- public UnityEngine.Vector3 averageSpeed { get; }
- public bool isAnimatorMotion { get; }
- public bool isHumanMotion { get; }
- public bool isLooping { get; }
- public bool legacy { get; }

#### Constructors
- protected Motion()

#### Methods
- public bool ValidateIfRetargetable(bool val)

### internal delegate UnityEngine.AnimatorOverrideController.OnOverrideControllerDirtyCallback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public AnimatorOverrideController.OnOverrideControllerDirtyCallback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke()

### public enum UnityEngine.PlayMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- StopAll = 4
- StopSameLayer = 0

### public enum UnityEngine.QueueMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CompleteOthers = 0
- PlayNow = 2

### public class UnityEngine.RuntimeAnimatorController
- Base: UnityEngine.Object

#### Properties
- public UnityEngine.AnimationClip[] animationClips { get; }

#### Constructors
- protected RuntimeAnimatorController()

### public class UnityEngine.SharedBetweenAnimatorsAttribute
- Base: System.Attribute

#### Constructors
- public SharedBetweenAnimatorsAttribute()

### public struct UnityEngine.SkeletonBone

#### Fields
- public string name
- internal string parentName
- public UnityEngine.Vector3 position
- public UnityEngine.Quaternion rotation
- public UnityEngine.Vector3 scale

#### Properties
- public int transformModified { get; set; }

### internal enum UnityEngine.StateInfoIndex
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CurrentState = 0
- ExitState = 2
- InterruptedState = 3
- NextState = 1

### public class UnityEngine.StateMachineBehaviour
- Base: UnityEngine.ScriptableObject

#### Constructors
- protected StateMachineBehaviour()

#### Methods
- public virtual void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
- public virtual void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller)
- public virtual void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
- public virtual void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller)
- public virtual void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
- public virtual void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller)
- public virtual void OnStateMachineEnter(UnityEngine.Animator animator, int stateMachinePathHash)
- public virtual void OnStateMachineEnter(UnityEngine.Animator animator, int stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller)
- public virtual void OnStateMachineExit(UnityEngine.Animator animator, int stateMachinePathHash)
- public virtual void OnStateMachineExit(UnityEngine.Animator animator, int stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller)
- public virtual void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
- public virtual void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller)
- public virtual void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
- public virtual void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller)

### internal enum UnityEngine.TransitionType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Entry = 2
- Exit = 4
- Normal = 1

## Namespace: UnityEngine.Animations

### public class UnityEngine.Animations.AimConstraint
- Base: UnityEngine.Behaviour
- Interfaces: UnityEngine.Animations.IConstraint, UnityEngine.Animations.IConstraintInternal

#### Properties
- public UnityEngine.Vector3 aimVector { get; set; }
- public bool constraintActive { get; set; }
- public bool locked { get; set; }
- public UnityEngine.Vector3 rotationAtRest { get; set; }
- public UnityEngine.Animations.Axis rotationAxis { get; set; }
- public UnityEngine.Vector3 rotationOffset { get; set; }
- public int sourceCount { get; }
- public UnityEngine.Vector3 upVector { get; set; }
- public float weight { get; set; }
- public UnityEngine.Transform worldUpObject { get; set; }
- public UnityEngine.Animations.AimConstraint.WorldUpType worldUpType { get; set; }
- public UnityEngine.Vector3 worldUpVector { get; set; }

#### Constructors
- private AimConstraint()

#### Methods
- public int AddSource(UnityEngine.Animations.ConstraintSource source)
- private int AddSource_Injected(ref UnityEngine.Animations.ConstraintSource source)
- public UnityEngine.Animations.ConstraintSource GetSource(int index)
- private static int GetSourceCountInternal(UnityEngine.Animations.AimConstraint self)
- private UnityEngine.Animations.ConstraintSource GetSourceInternal(int index)
- private void GetSourceInternal_Injected(int index, out UnityEngine.Animations.ConstraintSource ret)
- public void GetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources)
- private static void Internal_Create(UnityEngine.Animations.AimConstraint self)
- public void RemoveSource(int index)
- private void RemoveSourceInternal(int index)
- public void SetSource(int index, UnityEngine.Animations.ConstraintSource source)
- private void SetSourceInternal(int index, UnityEngine.Animations.ConstraintSource source)
- private void SetSourceInternal_Injected(int index, ref UnityEngine.Animations.ConstraintSource source)
- public void SetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources)
- private static void SetSourcesInternal(UnityEngine.Animations.AimConstraint self, System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources)
- private void ValidateSourceIndex(int index)

### public struct UnityEngine.Animations.AnimationClipPlayable
- Interfaces: UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationClipPlayable>

#### Fields
- private UnityEngine.Playables.PlayableHandle m_Handle

#### Constructors
- internal AnimationClipPlayable(UnityEngine.Playables.PlayableHandle handle)

#### Methods
- public static UnityEngine.Animations.AnimationClipPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip)
- private static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip)
- private static bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip, ref UnityEngine.Playables.PlayableHandle handle)
- private static bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip, ref UnityEngine.Playables.PlayableHandle handle)
- public bool Equals(UnityEngine.Animations.AnimationClipPlayable other)
- public UnityEngine.AnimationClip GetAnimationClip()
- private static UnityEngine.AnimationClip GetAnimationClipInternal(ref UnityEngine.Playables.PlayableHandle handle)
- public bool GetApplyFootIK()
- private static bool GetApplyFootIKInternal(ref UnityEngine.Playables.PlayableHandle handle)
- public bool GetApplyPlayableIK()
- private static bool GetApplyPlayableIKInternal(ref UnityEngine.Playables.PlayableHandle handle)
- public UnityEngine.Playables.PlayableHandle GetHandle()
- internal bool GetLoopTime()
- private static bool GetLoopTimeInternal(ref UnityEngine.Playables.PlayableHandle handle)
- internal bool GetOverrideLoopTime()
- private static bool GetOverrideLoopTimeInternal(ref UnityEngine.Playables.PlayableHandle handle)
- internal bool GetRemoveStartOffset()
- private static bool GetRemoveStartOffsetInternal(ref UnityEngine.Playables.PlayableHandle handle)
- internal float GetSampleRate()
- private static float GetSampleRateInternal(ref UnityEngine.Playables.PlayableHandle handle)
- public static UnityEngine.Animations.AnimationClipPlayable op_Explicit(UnityEngine.Playables.Playable playable)
- public static UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationClipPlayable playable)
- public void SetApplyFootIK(bool value)
- private static void SetApplyFootIKInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value)
- public void SetApplyPlayableIK(bool value)
- private static void SetApplyPlayableIKInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value)
- internal void SetLoopTime(bool value)
- private static void SetLoopTimeInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value)
- internal void SetOverrideLoopTime(bool value)
- private static void SetOverrideLoopTimeInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value)
- internal void SetRemoveStartOffset(bool value)
- private static void SetRemoveStartOffsetInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value)
- internal void SetSampleRate(float value)
- private static void SetSampleRateInternal(ref UnityEngine.Playables.PlayableHandle handle, float value)

### public struct UnityEngine.Animations.AnimationHumanStream

#### Fields
- private System.IntPtr stream

#### Properties
- public UnityEngine.Vector3 bodyLocalPosition { get; set; }
- public UnityEngine.Quaternion bodyLocalRotation { get; set; }
- public UnityEngine.Vector3 bodyPosition { get; set; }
- public UnityEngine.Quaternion bodyRotation { get; set; }
- public float humanScale { get; }
- public bool isValid { get; }
- public float leftFootHeight { get; }
- public UnityEngine.Vector3 leftFootVelocity { get; }
- public float rightFootHeight { get; }
- public UnityEngine.Vector3 rightFootVelocity { get; }

#### Methods
- private float GetFootHeight(bool left)
- private static float GetFootHeight_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, bool left)
- public UnityEngine.Vector3 GetGoalLocalPosition(UnityEngine.AvatarIKGoal index)
- public UnityEngine.Quaternion GetGoalLocalRotation(UnityEngine.AvatarIKGoal index)
- public UnityEngine.Vector3 GetGoalPosition(UnityEngine.AvatarIKGoal index)
- public UnityEngine.Vector3 GetGoalPositionFromPose(UnityEngine.AvatarIKGoal index)
- public UnityEngine.Quaternion GetGoalRotation(UnityEngine.AvatarIKGoal index)
- public UnityEngine.Quaternion GetGoalRotationFromPose(UnityEngine.AvatarIKGoal index)
- public float GetGoalWeightPosition(UnityEngine.AvatarIKGoal index)
- public float GetGoalWeightRotation(UnityEngine.AvatarIKGoal index)
- public UnityEngine.Vector3 GetHintPosition(UnityEngine.AvatarIKHint index)
- public float GetHintWeightPosition(UnityEngine.AvatarIKHint index)
- private float GetHumanScale()
- private static float GetHumanScale_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self)
- private UnityEngine.Vector3 GetLeftFootVelocity()
- private static void GetLeftFootVelocity_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, out UnityEngine.Vector3 ret)
- public float GetMuscle(UnityEngine.Animations.MuscleHandle muscle)
- private UnityEngine.Vector3 GetRightFootVelocity()
- private static void GetRightFootVelocity_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, out UnityEngine.Vector3 ret)
- private UnityEngine.Vector3 InternalGetBodyLocalPosition()
- private static void InternalGetBodyLocalPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, out UnityEngine.Vector3 ret)
- private UnityEngine.Quaternion InternalGetBodyLocalRotation()
- private static void InternalGetBodyLocalRotation_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, out UnityEngine.Quaternion ret)
- private UnityEngine.Vector3 InternalGetBodyPosition()
- private static void InternalGetBodyPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, out UnityEngine.Vector3 ret)
- private UnityEngine.Quaternion InternalGetBodyRotation()
- private static void InternalGetBodyRotation_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, out UnityEngine.Quaternion ret)
- private UnityEngine.Vector3 InternalGetGoalLocalPosition(UnityEngine.AvatarIKGoal index)
- private static void InternalGetGoalLocalPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, out UnityEngine.Vector3 ret)
- private UnityEngine.Quaternion InternalGetGoalLocalRotation(UnityEngine.AvatarIKGoal index)
- private static void InternalGetGoalLocalRotation_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, out UnityEngine.Quaternion ret)
- private UnityEngine.Vector3 InternalGetGoalPosition(UnityEngine.AvatarIKGoal index)
- private UnityEngine.Vector3 InternalGetGoalPositionFromPose(UnityEngine.AvatarIKGoal index)
- private static void InternalGetGoalPositionFromPose_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, out UnityEngine.Vector3 ret)
- private static void InternalGetGoalPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, out UnityEngine.Vector3 ret)
- private UnityEngine.Quaternion InternalGetGoalRotation(UnityEngine.AvatarIKGoal index)
- private UnityEngine.Quaternion InternalGetGoalRotationFromPose(UnityEngine.AvatarIKGoal index)
- private static void InternalGetGoalRotationFromPose_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, out UnityEngine.Quaternion ret)
- private static void InternalGetGoalRotation_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, out UnityEngine.Quaternion ret)
- private float InternalGetGoalWeightPosition(UnityEngine.AvatarIKGoal index)
- private static float InternalGetGoalWeightPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index)
- private float InternalGetGoalWeightRotation(UnityEngine.AvatarIKGoal index)
- private static float InternalGetGoalWeightRotation_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index)
- private UnityEngine.Vector3 InternalGetHintPosition(UnityEngine.AvatarIKHint index)
- private static void InternalGetHintPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKHint index, out UnityEngine.Vector3 ret)
- private float InternalGetHintWeightPosition(UnityEngine.AvatarIKHint index)
- private static float InternalGetHintWeightPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKHint index)
- private float InternalGetMuscle(UnityEngine.Animations.MuscleHandle muscle)
- private static float InternalGetMuscle_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, ref UnityEngine.Animations.MuscleHandle muscle)
- private void InternalResetToStancePose()
- private static void InternalResetToStancePose_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self)
- private void InternalSetBodyLocalPosition(UnityEngine.Vector3 value)
- private static void InternalSetBodyLocalPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, ref UnityEngine.Vector3 value)
- private void InternalSetBodyLocalRotation(UnityEngine.Quaternion value)
- private static void InternalSetBodyLocalRotation_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, ref UnityEngine.Quaternion value)
- private void InternalSetBodyPosition(UnityEngine.Vector3 value)
- private static void InternalSetBodyPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, ref UnityEngine.Vector3 value)
- private void InternalSetBodyRotation(UnityEngine.Quaternion value)
- private static void InternalSetBodyRotation_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, ref UnityEngine.Quaternion value)
- private void InternalSetGoalLocalPosition(UnityEngine.AvatarIKGoal index, UnityEngine.Vector3 pos)
- private static void InternalSetGoalLocalPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, ref UnityEngine.Vector3 pos)
- private void InternalSetGoalLocalRotation(UnityEngine.AvatarIKGoal index, UnityEngine.Quaternion rot)
- private static void InternalSetGoalLocalRotation_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, ref UnityEngine.Quaternion rot)
- private void InternalSetGoalPosition(UnityEngine.AvatarIKGoal index, UnityEngine.Vector3 pos)
- private static void InternalSetGoalPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, ref UnityEngine.Vector3 pos)
- private void InternalSetGoalRotation(UnityEngine.AvatarIKGoal index, UnityEngine.Quaternion rot)
- private static void InternalSetGoalRotation_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, ref UnityEngine.Quaternion rot)
- private void InternalSetGoalWeightPosition(UnityEngine.AvatarIKGoal index, float value)
- private static void InternalSetGoalWeightPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, float value)
- private void InternalSetGoalWeightRotation(UnityEngine.AvatarIKGoal index, float value)
- private static void InternalSetGoalWeightRotation_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKGoal index, float value)
- private void InternalSetHintPosition(UnityEngine.AvatarIKHint index, UnityEngine.Vector3 pos)
- private static void InternalSetHintPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKHint index, ref UnityEngine.Vector3 pos)
- private void InternalSetHintWeightPosition(UnityEngine.AvatarIKHint index, float value)
- private static void InternalSetHintWeightPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, UnityEngine.AvatarIKHint index, float value)
- private void InternalSetLookAtBodyWeight(float weight)
- private static void InternalSetLookAtBodyWeight_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, float weight)
- private void InternalSetLookAtClampWeight(float weight)
- private static void InternalSetLookAtClampWeight_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, float weight)
- private void InternalSetLookAtEyesWeight(float weight)
- private static void InternalSetLookAtEyesWeight_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, float weight)
- private void InternalSetLookAtHeadWeight(float weight)
- private static void InternalSetLookAtHeadWeight_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, float weight)
- private void InternalSetLookAtPosition(UnityEngine.Vector3 lookAtPosition)
- private static void InternalSetLookAtPosition_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, ref UnityEngine.Vector3 lookAtPosition)
- private void InternalSetMuscle(UnityEngine.Animations.MuscleHandle muscle, float value)
- private static void InternalSetMuscle_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self, ref UnityEngine.Animations.MuscleHandle muscle, float value)
- private void InternalSolveIK()
- private static void InternalSolveIK_Injected(ref UnityEngine.Animations.AnimationHumanStream _unity_self)
- public void ResetToStancePose()
- public void SetGoalLocalPosition(UnityEngine.AvatarIKGoal index, UnityEngine.Vector3 pos)
- public void SetGoalLocalRotation(UnityEngine.AvatarIKGoal index, UnityEngine.Quaternion rot)
- public void SetGoalPosition(UnityEngine.AvatarIKGoal index, UnityEngine.Vector3 pos)
- public void SetGoalRotation(UnityEngine.AvatarIKGoal index, UnityEngine.Quaternion rot)
- public void SetGoalWeightPosition(UnityEngine.AvatarIKGoal index, float value)
- public void SetGoalWeightRotation(UnityEngine.AvatarIKGoal index, float value)
- public void SetHintPosition(UnityEngine.AvatarIKHint index, UnityEngine.Vector3 pos)
- public void SetHintWeightPosition(UnityEngine.AvatarIKHint index, float value)
- public void SetLookAtBodyWeight(float weight)
- public void SetLookAtClampWeight(float weight)
- public void SetLookAtEyesWeight(float weight)
- public void SetLookAtHeadWeight(float weight)
- public void SetLookAtPosition(UnityEngine.Vector3 lookAtPosition)
- public void SetMuscle(UnityEngine.Animations.MuscleHandle muscle, float value)
- public void SolveIK()
- private void ThrowIfInvalid()

### public struct UnityEngine.Animations.AnimationLayerMixerPlayable
- Interfaces: UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationLayerMixerPlayable>

#### Fields
- private UnityEngine.Playables.PlayableHandle m_Handle
- private static readonly UnityEngine.Animations.AnimationLayerMixerPlayable m_NullPlayable

#### Properties
- public static UnityEngine.Animations.AnimationLayerMixerPlayable Null { get; }

#### Constructors
- private static AnimationLayerMixerPlayable()
- internal AnimationLayerMixerPlayable(UnityEngine.Playables.PlayableHandle handle, bool singleLayerOptimization = true)

#### Methods
- public static UnityEngine.Animations.AnimationLayerMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount = 0)
- public static UnityEngine.Animations.AnimationLayerMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount, bool singleLayerOptimization)
- private static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, int inputCount = 0)
- private static bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle)
- private static bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle)
- public bool Equals(UnityEngine.Animations.AnimationLayerMixerPlayable other)
- public UnityEngine.Playables.PlayableHandle GetHandle()
- public bool IsLayerAdditive(uint layerIndex)
- private static bool IsLayerAdditiveInternal(ref UnityEngine.Playables.PlayableHandle handle, uint layerIndex)
- public static UnityEngine.Animations.AnimationLayerMixerPlayable op_Explicit(UnityEngine.Playables.Playable playable)
- public static UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationLayerMixerPlayable playable)
- public void SetLayerAdditive(uint layerIndex, bool value)
- private static void SetLayerAdditiveInternal(ref UnityEngine.Playables.PlayableHandle handle, uint layerIndex, bool value)
- public void SetLayerMaskFromAvatarMask(uint layerIndex, UnityEngine.AvatarMask mask)
- private static void SetLayerMaskFromAvatarMaskInternal(ref UnityEngine.Playables.PlayableHandle handle, uint layerIndex, UnityEngine.AvatarMask mask)
- private static void SetSingleLayerOptimizationInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value)

### public struct UnityEngine.Animations.AnimationMixerPlayable
- Interfaces: UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationMixerPlayable>

#### Fields
- private UnityEngine.Playables.PlayableHandle m_Handle
- private static readonly UnityEngine.Animations.AnimationMixerPlayable m_NullPlayable

#### Properties
- public static UnityEngine.Animations.AnimationMixerPlayable Null { get; }

#### Constructors
- private static AnimationMixerPlayable()
- internal AnimationMixerPlayable(UnityEngine.Playables.PlayableHandle handle)

#### Methods
- public static UnityEngine.Animations.AnimationMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount, bool normalizeWeights)
- public static UnityEngine.Animations.AnimationMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount = 0)
- private static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, int inputCount = 0)
- private static bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle)
- private static bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle)
- public bool Equals(UnityEngine.Animations.AnimationMixerPlayable other)
- public UnityEngine.Playables.PlayableHandle GetHandle()
- public static UnityEngine.Animations.AnimationMixerPlayable op_Explicit(UnityEngine.Playables.Playable playable)
- public static UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationMixerPlayable playable)

### internal struct UnityEngine.Animations.AnimationMotionXToDeltaPlayable
- Interfaces: UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationMotionXToDeltaPlayable>

#### Fields
- private UnityEngine.Playables.PlayableHandle m_Handle
- private static readonly UnityEngine.Animations.AnimationMotionXToDeltaPlayable m_NullPlayable

#### Properties
- public static UnityEngine.Animations.AnimationMotionXToDeltaPlayable Null { get; }

#### Constructors
- private static AnimationMotionXToDeltaPlayable()
- private AnimationMotionXToDeltaPlayable(UnityEngine.Playables.PlayableHandle handle)

#### Methods
- public static UnityEngine.Animations.AnimationMotionXToDeltaPlayable Create(UnityEngine.Playables.PlayableGraph graph)
- private static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph)
- private static bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle)
- private static bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle)
- public bool Equals(UnityEngine.Animations.AnimationMotionXToDeltaPlayable other)
- public UnityEngine.Playables.PlayableHandle GetHandle()
- public bool IsAbsoluteMotion()
- private static bool IsAbsoluteMotionInternal(ref UnityEngine.Playables.PlayableHandle handle)
- public static UnityEngine.Animations.AnimationMotionXToDeltaPlayable op_Explicit(UnityEngine.Playables.Playable playable)
- public static UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationMotionXToDeltaPlayable playable)
- public void SetAbsoluteMotion(bool value)
- private static void SetAbsoluteMotionInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value)

### internal struct UnityEngine.Animations.AnimationOffsetPlayable
- Interfaces: UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationOffsetPlayable>

#### Fields
- private UnityEngine.Playables.PlayableHandle m_Handle
- private static readonly UnityEngine.Animations.AnimationOffsetPlayable m_NullPlayable

#### Properties
- public static UnityEngine.Animations.AnimationOffsetPlayable Null { get; }

#### Constructors
- private static AnimationOffsetPlayable()
- internal AnimationOffsetPlayable(UnityEngine.Playables.PlayableHandle handle)

#### Methods
- public static UnityEngine.Animations.AnimationOffsetPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, int inputCount)
- private static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, int inputCount)
- private static bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, ref UnityEngine.Playables.PlayableHandle handle)
- private static bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, ref UnityEngine.Playables.PlayableHandle handle)
- public bool Equals(UnityEngine.Animations.AnimationOffsetPlayable other)
- public UnityEngine.Playables.PlayableHandle GetHandle()
- public UnityEngine.Vector3 GetPosition()
- private static UnityEngine.Vector3 GetPositionInternal(ref UnityEngine.Playables.PlayableHandle handle)
- private static void GetPositionInternal_Injected(ref UnityEngine.Playables.PlayableHandle handle, out UnityEngine.Vector3 ret)
- public UnityEngine.Quaternion GetRotation()
- private static UnityEngine.Quaternion GetRotationInternal(ref UnityEngine.Playables.PlayableHandle handle)
- private static void GetRotationInternal_Injected(ref UnityEngine.Playables.PlayableHandle handle, out UnityEngine.Quaternion ret)
- public static UnityEngine.Animations.AnimationOffsetPlayable op_Explicit(UnityEngine.Playables.Playable playable)
- public static UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationOffsetPlayable playable)
- public void SetPosition(UnityEngine.Vector3 value)
- private static void SetPositionInternal(ref UnityEngine.Playables.PlayableHandle handle, UnityEngine.Vector3 value)
- private static void SetPositionInternal_Injected(ref UnityEngine.Playables.PlayableHandle handle, ref UnityEngine.Vector3 value)
- public void SetRotation(UnityEngine.Quaternion value)
- private static void SetRotationInternal(ref UnityEngine.Playables.PlayableHandle handle, UnityEngine.Quaternion value)
- private static void SetRotationInternal_Injected(ref UnityEngine.Playables.PlayableHandle handle, ref UnityEngine.Quaternion value)

### public static class UnityEngine.Animations.AnimationPlayableBinding

#### Methods
- public static UnityEngine.Playables.PlayableBinding Create(string name, UnityEngine.Object key)
- private static UnityEngine.Playables.PlayableOutput CreateAnimationOutput(UnityEngine.Playables.PlayableGraph graph, string name)

### public static class UnityEngine.Animations.AnimationPlayableExtensions

#### Methods
- public static void SetAnimatedProperties<U>(U playable, UnityEngine.AnimationClip clip)
- internal static void SetAnimatedPropertiesInternal(ref UnityEngine.Playables.PlayableHandle playable, UnityEngine.AnimationClip animatedProperties)

### internal static class UnityEngine.Animations.AnimationPlayableGraphExtensions

#### Methods
- internal static void DestroyOutput(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.PlayableOutputHandle handle)
- private static int InternalAnimationOutputCount(ref UnityEngine.Playables.PlayableGraph graph)
- internal static bool InternalCreateAnimationOutput(ref UnityEngine.Playables.PlayableGraph graph, string name, out UnityEngine.Playables.PlayableOutputHandle handle)
- private static void InternalDestroyOutput(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableOutputHandle handle)
- private static bool InternalGetAnimationOutput(ref UnityEngine.Playables.PlayableGraph graph, int index, out UnityEngine.Playables.PlayableOutputHandle handle)
- internal static void InternalSyncUpdateAndTimeMode(ref UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animator animator)
- internal static void SyncUpdateAndTimeMode(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animator animator)

### public struct UnityEngine.Animations.AnimationPlayableOutput
- Interfaces: UnityEngine.Playables.IPlayableOutput

#### Fields
- private UnityEngine.Playables.PlayableOutputHandle m_Handle

#### Properties
- public static UnityEngine.Animations.AnimationPlayableOutput Null { get; }

#### Constructors
- internal AnimationPlayableOutput(UnityEngine.Playables.PlayableOutputHandle handle)

#### Methods
- public static UnityEngine.Animations.AnimationPlayableOutput Create(UnityEngine.Playables.PlayableGraph graph, string name, UnityEngine.Animator target)
- public UnityEngine.Playables.PlayableOutputHandle GetHandle()
- public UnityEngine.Animator GetTarget()
- private static UnityEngine.Animator InternalGetTarget(ref UnityEngine.Playables.PlayableOutputHandle handle)
- private static void InternalSetTarget(ref UnityEngine.Playables.PlayableOutputHandle handle, UnityEngine.Animator target)
- public static UnityEngine.Animations.AnimationPlayableOutput op_Explicit(UnityEngine.Playables.PlayableOutput output)
- public static UnityEngine.Playables.PlayableOutput op_Implicit(UnityEngine.Animations.AnimationPlayableOutput output)
- public void SetTarget(UnityEngine.Animator value)

### internal struct UnityEngine.Animations.AnimationPosePlayable
- Interfaces: UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationPosePlayable>

#### Fields
- private UnityEngine.Playables.PlayableHandle m_Handle
- private static readonly UnityEngine.Animations.AnimationPosePlayable m_NullPlayable

#### Properties
- public static UnityEngine.Animations.AnimationPosePlayable Null { get; }

#### Constructors
- private static AnimationPosePlayable()
- internal AnimationPosePlayable(UnityEngine.Playables.PlayableHandle handle)

#### Methods
- public static UnityEngine.Animations.AnimationPosePlayable Create(UnityEngine.Playables.PlayableGraph graph)
- private static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph)
- private static bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle)
- private static bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle)
- public bool Equals(UnityEngine.Animations.AnimationPosePlayable other)
- public bool GetApplyFootIK()
- private static bool GetApplyFootIKInternal(ref UnityEngine.Playables.PlayableHandle handle)
- public UnityEngine.Playables.PlayableHandle GetHandle()
- public bool GetMustReadPreviousPose()
- private static bool GetMustReadPreviousPoseInternal(ref UnityEngine.Playables.PlayableHandle handle)
- public bool GetReadDefaultPose()
- private static bool GetReadDefaultPoseInternal(ref UnityEngine.Playables.PlayableHandle handle)
- public static UnityEngine.Animations.AnimationPosePlayable op_Explicit(UnityEngine.Playables.Playable playable)
- public static UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationPosePlayable playable)
- public void SetApplyFootIK(bool value)
- private static void SetApplyFootIKInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value)
- public void SetMustReadPreviousPose(bool value)
- private static void SetMustReadPreviousPoseInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value)
- public void SetReadDefaultPose(bool value)
- private static void SetReadDefaultPoseInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value)

### internal struct UnityEngine.Animations.AnimationRemoveScalePlayable
- Interfaces: UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationRemoveScalePlayable>

#### Fields
- private UnityEngine.Playables.PlayableHandle m_Handle
- private static readonly UnityEngine.Animations.AnimationRemoveScalePlayable m_NullPlayable

#### Properties
- public static UnityEngine.Animations.AnimationRemoveScalePlayable Null { get; }

#### Constructors
- private static AnimationRemoveScalePlayable()
- internal AnimationRemoveScalePlayable(UnityEngine.Playables.PlayableHandle handle)

#### Methods
- public static UnityEngine.Animations.AnimationRemoveScalePlayable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount)
- private static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, int inputCount)
- private static bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle)
- private static bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle)
- public bool Equals(UnityEngine.Animations.AnimationRemoveScalePlayable other)
- public UnityEngine.Playables.PlayableHandle GetHandle()
- public static UnityEngine.Animations.AnimationRemoveScalePlayable op_Explicit(UnityEngine.Playables.Playable playable)
- public static UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationRemoveScalePlayable playable)

### public static class UnityEngine.Animations.AnimationSceneHandleUtility

#### Methods
- public static void ReadFloats(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertySceneHandle> handles, Unity.Collections.NativeArray<float> buffer)
- public static void ReadInts(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertySceneHandle> handles, Unity.Collections.NativeArray<int> buffer)
- private static void ReadSceneFloatsInternal(ref UnityEngine.Animations.AnimationStream stream, void* propertySceneHandles, void* floatBuffer, int count)
- private static void ReadSceneIntsInternal(ref UnityEngine.Animations.AnimationStream stream, void* propertySceneHandles, void* intBuffer, int count)
- internal static int ValidateAndGetArrayCount<T0, T1>(ref UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<T0> handles, Unity.Collections.NativeArray<T1> buffer)

### public struct UnityEngine.Animations.AnimationScriptPlayable
- Interfaces: UnityEngine.Animations.IAnimationJobPlayable, UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationScriptPlayable>

#### Fields
- private UnityEngine.Playables.PlayableHandle m_Handle
- private static readonly UnityEngine.Animations.AnimationScriptPlayable m_NullPlayable

#### Properties
- public static UnityEngine.Animations.AnimationScriptPlayable Null { get; }

#### Constructors
- private static AnimationScriptPlayable()
- internal AnimationScriptPlayable(UnityEngine.Playables.PlayableHandle handle)

#### Methods
- private void CheckJobTypeValidity<T>()
- public static UnityEngine.Animations.AnimationScriptPlayable Create<T>(UnityEngine.Playables.PlayableGraph graph, T jobData, int inputCount = 0)
- private static UnityEngine.Playables.PlayableHandle CreateHandle<T>(UnityEngine.Playables.PlayableGraph graph, int inputCount)
- private static bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle, System.IntPtr jobReflectionData)
- private static bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle, System.IntPtr jobReflectionData)
- public bool Equals(UnityEngine.Animations.AnimationScriptPlayable other)
- public UnityEngine.Playables.PlayableHandle GetHandle()
- public T GetJobData<T>()
- public bool GetProcessInputs()
- private static bool GetProcessInputsInternal(UnityEngine.Playables.PlayableHandle handle)
- private static bool GetProcessInputsInternal_Injected(ref UnityEngine.Playables.PlayableHandle handle)
- public static UnityEngine.Animations.AnimationScriptPlayable op_Explicit(UnityEngine.Playables.Playable playable)
- public static UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationScriptPlayable playable)
- public void SetJobData<T>(T jobData)
- public void SetProcessInputs(bool value)
- private static void SetProcessInputsInternal(UnityEngine.Playables.PlayableHandle handle, bool value)
- private static void SetProcessInputsInternal_Injected(ref UnityEngine.Playables.PlayableHandle handle, bool value)

### public struct UnityEngine.Animations.AnimationStream

#### Fields
- private System.IntPtr animationHandleBinder
- private System.IntPtr constant
- private System.IntPtr input
- private System.IntPtr inputStreamAccessor
- internal static const int InvalidIndex
- private uint m_AnimatorBindingsVersion
- private System.IntPtr output
- private System.IntPtr workspace

#### Properties
- public UnityEngine.Vector3 angularVelocity { get; set; }
- internal uint animatorBindingsVersion { get; }
- public float deltaTime { get; }
- public int inputStreamCount { get; }
- public bool isHumanStream { get; }
- public bool isValid { get; }
- public UnityEngine.Vector3 rootMotionPosition { get; }
- public UnityEngine.Quaternion rootMotionRotation { get; }
- public UnityEngine.Vector3 velocity { get; set; }

#### Methods
- public UnityEngine.Animations.AnimationHumanStream AsHuman()
- internal void CheckIsValid()
- public void CopyAnimationStreamMotion(UnityEngine.Animations.AnimationStream animationStream)
- private void CopyAnimationStreamMotionInternal(UnityEngine.Animations.AnimationStream animationStream)
- private static void CopyAnimationStreamMotionInternal_Injected(ref UnityEngine.Animations.AnimationStream _unity_self, ref UnityEngine.Animations.AnimationStream animationStream)
- private UnityEngine.Vector3 GetAngularVelocity()
- private static void GetAngularVelocity_Injected(ref UnityEngine.Animations.AnimationStream _unity_self, out UnityEngine.Vector3 ret)
- private float GetDeltaTime()
- private static float GetDeltaTime_Injected(ref UnityEngine.Animations.AnimationStream _unity_self)
- private UnityEngine.Animations.AnimationHumanStream GetHumanStream()
- private static void GetHumanStream_Injected(ref UnityEngine.Animations.AnimationStream _unity_self, out UnityEngine.Animations.AnimationHumanStream ret)
- public UnityEngine.Animations.AnimationStream GetInputStream(int index)
- private int GetInputStreamCount()
- private static int GetInputStreamCount_Injected(ref UnityEngine.Animations.AnimationStream _unity_self)
- public float GetInputWeight(int index)
- private bool GetIsHumanStream()
- private static bool GetIsHumanStream_Injected(ref UnityEngine.Animations.AnimationStream _unity_self)
- private UnityEngine.Vector3 GetRootMotionPosition()
- private static void GetRootMotionPosition_Injected(ref UnityEngine.Animations.AnimationStream _unity_self, out UnityEngine.Vector3 ret)
- private UnityEngine.Quaternion GetRootMotionRotation()
- private static void GetRootMotionRotation_Injected(ref UnityEngine.Animations.AnimationStream _unity_self, out UnityEngine.Quaternion ret)
- private UnityEngine.Vector3 GetVelocity()
- private static void GetVelocity_Injected(ref UnityEngine.Animations.AnimationStream _unity_self, out UnityEngine.Vector3 ret)
- private UnityEngine.Animations.AnimationStream InternalGetInputStream(int index)
- private static void InternalGetInputStream_Injected(ref UnityEngine.Animations.AnimationStream _unity_self, int index, out UnityEngine.Animations.AnimationStream ret)
- private float InternalGetInputWeight(int index)
- private static float InternalGetInputWeight_Injected(ref UnityEngine.Animations.AnimationStream _unity_self, int index)
- private void InternalReadSceneTransforms()
- private static void InternalReadSceneTransforms_Injected(ref UnityEngine.Animations.AnimationStream _unity_self)
- private void InternalWriteSceneTransforms()
- private static void InternalWriteSceneTransforms_Injected(ref UnityEngine.Animations.AnimationStream _unity_self)
- private void ReadSceneTransforms()
- private void SetAngularVelocity(UnityEngine.Vector3 velocity)
- private static void SetAngularVelocity_Injected(ref UnityEngine.Animations.AnimationStream _unity_self, ref UnityEngine.Vector3 velocity)
- private void SetVelocity(UnityEngine.Vector3 velocity)
- private static void SetVelocity_Injected(ref UnityEngine.Animations.AnimationStream _unity_self, ref UnityEngine.Vector3 velocity)
- private void WriteSceneTransforms()

### public static class UnityEngine.Animations.AnimationStreamHandleUtility

#### Methods
- public static void ReadFloats(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<float> buffer)
- public static void ReadInts(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<int> buffer)
- private static void ReadStreamFloatsInternal(ref UnityEngine.Animations.AnimationStream stream, void* propertyStreamHandles, void* floatBuffer, int count)
- private static void ReadStreamIntsInternal(ref UnityEngine.Animations.AnimationStream stream, void* propertyStreamHandles, void* intBuffer, int count)
- public static void WriteFloats(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<float> buffer, bool useMask)
- public static void WriteInts(UnityEngine.Animations.AnimationStream stream, Unity.Collections.NativeArray<UnityEngine.Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<int> buffer, bool useMask)
- private static void WriteStreamFloatsInternal(ref UnityEngine.Animations.AnimationStream stream, void* propertyStreamHandles, void* floatBuffer, int count, bool useMask)
- private static void WriteStreamIntsInternal(ref UnityEngine.Animations.AnimationStream stream, void* propertyStreamHandles, void* intBuffer, int count, bool useMask)

### internal enum UnityEngine.Animations.AnimatorBindingsVersion
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- kInvalidNotNative = 0
- kInvalidUnresolved = 1
- kValidMinVersion = 2

### public struct UnityEngine.Animations.AnimatorControllerPlayable
- Interfaces: UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimatorControllerPlayable>

#### Fields
- private UnityEngine.Playables.PlayableHandle m_Handle
- private static readonly UnityEngine.Animations.AnimatorControllerPlayable m_NullPlayable

#### Properties
- public static UnityEngine.Animations.AnimatorControllerPlayable Null { get; }

#### Constructors
- private static AnimatorControllerPlayable()
- internal AnimatorControllerPlayable(UnityEngine.Playables.PlayableHandle handle)

#### Methods
- public static UnityEngine.Animations.AnimatorControllerPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.RuntimeAnimatorController controller)
- private static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.RuntimeAnimatorController controller)
- private static bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.RuntimeAnimatorController controller, ref UnityEngine.Playables.PlayableHandle handle)
- private static bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, UnityEngine.RuntimeAnimatorController controller, ref UnityEngine.Playables.PlayableHandle handle)
- public void CrossFade(string stateName, float transitionDuration)
- public void CrossFade(string stateName, float transitionDuration, int layer)
- public void CrossFade(string stateName, float transitionDuration, int layer, float normalizedTime)
- public void CrossFade(int stateNameHash, float transitionDuration)
- public void CrossFade(int stateNameHash, float transitionDuration, int layer)
- public void CrossFade(int stateNameHash, float transitionDuration, int layer, float normalizedTime)
- public void CrossFadeInFixedTime(string stateName, float transitionDuration)
- public void CrossFadeInFixedTime(string stateName, float transitionDuration, int layer)
- public void CrossFadeInFixedTime(string stateName, float transitionDuration, int layer, float fixedTime)
- public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration)
- public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, int layer)
- public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, int layer, float fixedTime)
- private static void CrossFadeInFixedTimeInternal(ref UnityEngine.Playables.PlayableHandle handle, int stateNameHash, float transitionDuration, int layer, float fixedTime)
- private static void CrossFadeInternal(ref UnityEngine.Playables.PlayableHandle handle, int stateNameHash, float transitionDuration, int layer, float normalizedTime)
- public bool Equals(UnityEngine.Animations.AnimatorControllerPlayable other)
- private static int GetAnimatorClipInfoCountInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex, bool current)
- private static void GetAnimatorClipInfoInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex, bool isCurrent, object clips)
- private static UnityEngine.RuntimeAnimatorController GetAnimatorControllerInternal(ref UnityEngine.Playables.PlayableHandle handle)
- public UnityEngine.AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex)
- private static UnityEngine.AnimatorTransitionInfo GetAnimatorTransitionInfoInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex)
- private static void GetAnimatorTransitionInfoInternal_Injected(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex, out UnityEngine.AnimatorTransitionInfo ret)
- public bool GetBool(string name)
- public bool GetBool(int id)
- private static bool GetBoolID(ref UnityEngine.Playables.PlayableHandle handle, int id)
- private static bool GetBoolString(ref UnityEngine.Playables.PlayableHandle handle, string name)
- public UnityEngine.AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex)
- public void GetCurrentAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips)
- public int GetCurrentAnimatorClipInfoCount(int layerIndex)
- private static UnityEngine.AnimatorClipInfo[] GetCurrentAnimatorClipInfoInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex)
- public UnityEngine.AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex)
- private static UnityEngine.AnimatorStateInfo GetCurrentAnimatorStateInfoInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex)
- private static void GetCurrentAnimatorStateInfoInternal_Injected(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex, out UnityEngine.AnimatorStateInfo ret)
- public float GetFloat(string name)
- public float GetFloat(int id)
- private static float GetFloatID(ref UnityEngine.Playables.PlayableHandle handle, int id)
- private static float GetFloatString(ref UnityEngine.Playables.PlayableHandle handle, string name)
- public UnityEngine.Playables.PlayableHandle GetHandle()
- public int GetInteger(string name)
- public int GetInteger(int id)
- private static int GetIntegerID(ref UnityEngine.Playables.PlayableHandle handle, int id)
- private static int GetIntegerString(ref UnityEngine.Playables.PlayableHandle handle, string name)
- public int GetLayerCount()
- private static int GetLayerCountInternal(ref UnityEngine.Playables.PlayableHandle handle)
- public int GetLayerIndex(string layerName)
- private static int GetLayerIndexInternal(ref UnityEngine.Playables.PlayableHandle handle, string layerName)
- public string GetLayerName(int layerIndex)
- private static string GetLayerNameInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex)
- public float GetLayerWeight(int layerIndex)
- private static float GetLayerWeightInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex)
- public void GetNextAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips)
- public UnityEngine.AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex)
- public int GetNextAnimatorClipInfoCount(int layerIndex)
- private static UnityEngine.AnimatorClipInfo[] GetNextAnimatorClipInfoInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex)
- public UnityEngine.AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex)
- private static UnityEngine.AnimatorStateInfo GetNextAnimatorStateInfoInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex)
- private static void GetNextAnimatorStateInfoInternal_Injected(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex, out UnityEngine.AnimatorStateInfo ret)
- public UnityEngine.AnimatorControllerParameter GetParameter(int index)
- public int GetParameterCount()
- private static int GetParameterCountInternal(ref UnityEngine.Playables.PlayableHandle handle)
- private static UnityEngine.AnimatorControllerParameter GetParameterInternal(ref UnityEngine.Playables.PlayableHandle handle, int index)
- public bool HasState(int layerIndex, int stateID)
- private static bool HasStateInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex, int stateID)
- public bool IsInTransition(int layerIndex)
- private static bool IsInTransitionInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex)
- public bool IsParameterControlledByCurve(string name)
- public bool IsParameterControlledByCurve(int id)
- private static bool IsParameterControlledByCurveID(ref UnityEngine.Playables.PlayableHandle handle, int id)
- private static bool IsParameterControlledByCurveString(ref UnityEngine.Playables.PlayableHandle handle, string name)
- public static UnityEngine.Animations.AnimatorControllerPlayable op_Explicit(UnityEngine.Playables.Playable playable)
- public static UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimatorControllerPlayable playable)
- public void Play(string stateName)
- public void Play(string stateName, int layer)
- public void Play(string stateName, int layer, float normalizedTime)
- public void Play(int stateNameHash)
- public void Play(int stateNameHash, int layer)
- public void Play(int stateNameHash, int layer, float normalizedTime)
- public void PlayInFixedTime(string stateName)
- public void PlayInFixedTime(string stateName, int layer)
- public void PlayInFixedTime(string stateName, int layer, float fixedTime)
- public void PlayInFixedTime(int stateNameHash)
- public void PlayInFixedTime(int stateNameHash, int layer)
- public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime)
- private static void PlayInFixedTimeInternal(ref UnityEngine.Playables.PlayableHandle handle, int stateNameHash, int layer, float fixedTime)
- private static void PlayInternal(ref UnityEngine.Playables.PlayableHandle handle, int stateNameHash, int layer, float normalizedTime)
- public void ResetTrigger(string name)
- public void ResetTrigger(int id)
- private static void ResetTriggerID(ref UnityEngine.Playables.PlayableHandle handle, int id)
- private static void ResetTriggerString(ref UnityEngine.Playables.PlayableHandle handle, string name)
- internal string ResolveHash(int hash)
- private static string ResolveHashInternal(ref UnityEngine.Playables.PlayableHandle handle, int hash)
- public void SetBool(string name, bool value)
- public void SetBool(int id, bool value)
- private static void SetBoolID(ref UnityEngine.Playables.PlayableHandle handle, int id, bool value)
- private static void SetBoolString(ref UnityEngine.Playables.PlayableHandle handle, string name, bool value)
- public void SetFloat(string name, float value)
- public void SetFloat(int id, float value)
- private static void SetFloatID(ref UnityEngine.Playables.PlayableHandle handle, int id, float value)
- private static void SetFloatString(ref UnityEngine.Playables.PlayableHandle handle, string name, float value)
- public void SetHandle(UnityEngine.Playables.PlayableHandle handle)
- public void SetInteger(string name, int value)
- public void SetInteger(int id, int value)
- private static void SetIntegerID(ref UnityEngine.Playables.PlayableHandle handle, int id, int value)
- private static void SetIntegerString(ref UnityEngine.Playables.PlayableHandle handle, string name, int value)
- public void SetLayerWeight(int layerIndex, float weight)
- private static void SetLayerWeightInternal(ref UnityEngine.Playables.PlayableHandle handle, int layerIndex, float weight)
- public void SetTrigger(string name)
- public void SetTrigger(int id)
- private static void SetTriggerID(ref UnityEngine.Playables.PlayableHandle handle, int id)
- private static void SetTriggerString(ref UnityEngine.Playables.PlayableHandle handle, string name)
- private static int StringToHash(string name)

### public static class UnityEngine.Animations.AnimatorJobExtensions

#### Methods
- public static void AddJobDependency(UnityEngine.Animator animator, Unity.Jobs.JobHandle jobHandle)
- public static UnityEngine.Animations.PropertyStreamHandle BindCustomStreamProperty(UnityEngine.Animator animator, string property, UnityEngine.Animations.CustomStreamPropertyType type)
- public static UnityEngine.Animations.PropertySceneHandle BindSceneProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, string property)
- public static UnityEngine.Animations.PropertySceneHandle BindSceneProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, string property, bool isObjectReference)
- public static UnityEngine.Animations.TransformSceneHandle BindSceneTransform(UnityEngine.Animator animator, UnityEngine.Transform transform)
- public static UnityEngine.Animations.PropertyStreamHandle BindStreamProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, string property)
- public static UnityEngine.Animations.PropertyStreamHandle BindStreamProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, string property, bool isObjectReference)
- public static UnityEngine.Animations.TransformStreamHandle BindStreamTransform(UnityEngine.Animator animator, UnityEngine.Transform transform)
- public static void CloseAnimationStream(UnityEngine.Animator animator, ref UnityEngine.Animations.AnimationStream stream)
- private static void InternalAddJobDependency(UnityEngine.Animator animator, Unity.Jobs.JobHandle jobHandle)
- private static void InternalAddJobDependency_Injected(UnityEngine.Animator animator, ref Unity.Jobs.JobHandle jobHandle)
- private static void InternalBindCustomStreamProperty(UnityEngine.Animator animator, string property, UnityEngine.Animations.CustomStreamPropertyType propertyType, out UnityEngine.Animations.PropertyStreamHandle propertyStreamHandle)
- private static void InternalBindSceneProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, string property, bool isObjectReference, out UnityEngine.Animations.PropertySceneHandle propertySceneHandle)
- private static void InternalBindSceneTransform(UnityEngine.Animator animator, UnityEngine.Transform transform, out UnityEngine.Animations.TransformSceneHandle transformSceneHandle)
- private static void InternalBindStreamProperty(UnityEngine.Animator animator, UnityEngine.Transform transform, System.Type type, string property, bool isObjectReference, out UnityEngine.Animations.PropertyStreamHandle propertyStreamHandle)
- private static void InternalBindStreamTransform(UnityEngine.Animator animator, UnityEngine.Transform transform, out UnityEngine.Animations.TransformStreamHandle transformStreamHandle)
- private static void InternalCloseAnimationStream(UnityEngine.Animator animator, ref UnityEngine.Animations.AnimationStream stream)
- private static bool InternalOpenAnimationStream(UnityEngine.Animator animator, ref UnityEngine.Animations.AnimationStream stream)
- private static void InternalResolveAllSceneHandles(UnityEngine.Animator animator)
- private static void InternalResolveAllStreamHandles(UnityEngine.Animator animator)
- private static void InternalUnbindAllSceneHandles(UnityEngine.Animator animator)
- private static void InternalUnbindAllStreamHandles(UnityEngine.Animator animator)
- public static bool OpenAnimationStream(UnityEngine.Animator animator, ref UnityEngine.Animations.AnimationStream stream)
- public static void ResolveAllSceneHandles(UnityEngine.Animator animator)
- public static void ResolveAllStreamHandles(UnityEngine.Animator animator)
- internal static void UnbindAllHandles(UnityEngine.Animator animator)
- public static void UnbindAllSceneHandles(UnityEngine.Animator animator)
- public static void UnbindAllStreamHandles(UnityEngine.Animator animator)

### public enum UnityEngine.Animations.Axis
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- None = 0
- X = 1
- Y = 2
- Z = 4

### internal enum UnityEngine.Animations.BindType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Bool = 6
- DiscreetInt = 11
- Float = 5
- GameObjectActive = 7
- Int = 10
- ObjectReference = 9
- Unbound = 0

### public struct UnityEngine.Animations.ConstraintSource

#### Fields
- private UnityEngine.Transform m_SourceTransform
- private float m_Weight

#### Properties
- public UnityEngine.Transform sourceTransform { get; set; }
- public float weight { get; set; }

### public enum UnityEngine.Animations.CustomStreamPropertyType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Bool = 6
- Float = 5
- Int = 10

### public class UnityEngine.Animations.DiscreteEvaluationAttribute
- Base: System.Attribute

#### Constructors
- public DiscreteEvaluationAttribute()

### internal static class UnityEngine.Animations.DiscreteEvaluationAttributeUtilities

#### Methods
- public static float ConvertDiscreteIntToFloat(int f)
- public static int ConvertFloatToDiscreteInt(float f)

### public delegate UnityEngine.Animations.ProcessAnimationJobStruct<T>.ExecuteJobFunction<T>
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public ProcessAnimationJobStruct<T>.ExecuteJobFunction<T>(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(ref T data, System.IntPtr animationStreamPtr, System.IntPtr unusedPtr, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(ref T data, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, System.IAsyncResult result)
- public virtual void Invoke(ref T data, System.IntPtr animationStreamPtr, System.IntPtr unusedPtr, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex)

### public interface UnityEngine.Animations.IAnimationJob

#### Methods
- public void ProcessAnimation(UnityEngine.Animations.AnimationStream stream)
- public void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream)

### public interface UnityEngine.Animations.IAnimationJobPlayable
- Interfaces: UnityEngine.Playables.IPlayable

#### Methods
- public T GetJobData<T>()
- public void SetJobData<T>(T jobData)

### internal interface UnityEngine.Animations.IAnimationPreviewable

#### Methods
- public void OnPreviewUpdate()

### public interface UnityEngine.Animations.IAnimationWindowPreview

#### Methods
- public UnityEngine.Playables.Playable BuildPreviewGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable inputPlayable)
- public void StartPreview()
- public void StopPreview()
- public void UpdatePreviewGraph(UnityEngine.Playables.PlayableGraph graph)

### public interface UnityEngine.Animations.IConstraint

#### Properties
- public bool constraintActive { get; set; }
- public bool locked { get; set; }
- public int sourceCount { get; }
- public float weight { get; set; }

#### Methods
- public int AddSource(UnityEngine.Animations.ConstraintSource source)
- public UnityEngine.Animations.ConstraintSource GetSource(int index)
- public void GetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources)
- public void RemoveSource(int index)
- public void SetSource(int index, UnityEngine.Animations.ConstraintSource source)
- public void SetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources)

### internal interface UnityEngine.Animations.IConstraintInternal

### internal enum UnityEngine.Animations.JobMethodIndex
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- MethodIndexCount = 2
- ProcessAnimationMethodIndex = 1
- ProcessRootMotionMethodIndex = 0

### public class UnityEngine.Animations.LookAtConstraint
- Base: UnityEngine.Behaviour
- Interfaces: UnityEngine.Animations.IConstraint, UnityEngine.Animations.IConstraintInternal

#### Properties
- public bool constraintActive { get; set; }
- public bool locked { get; set; }
- public float roll { get; set; }
- public UnityEngine.Vector3 rotationAtRest { get; set; }
- public UnityEngine.Vector3 rotationOffset { get; set; }
- public int sourceCount { get; }
- public bool useUpObject { get; set; }
- public float weight { get; set; }
- public UnityEngine.Transform worldUpObject { get; set; }

#### Constructors
- private LookAtConstraint()

#### Methods
- public int AddSource(UnityEngine.Animations.ConstraintSource source)
- private int AddSource_Injected(ref UnityEngine.Animations.ConstraintSource source)
- public UnityEngine.Animations.ConstraintSource GetSource(int index)
- private static int GetSourceCountInternal(UnityEngine.Animations.LookAtConstraint self)
- private UnityEngine.Animations.ConstraintSource GetSourceInternal(int index)
- private void GetSourceInternal_Injected(int index, out UnityEngine.Animations.ConstraintSource ret)
- public void GetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources)
- private static void Internal_Create(UnityEngine.Animations.LookAtConstraint self)
- public void RemoveSource(int index)
- private void RemoveSourceInternal(int index)
- public void SetSource(int index, UnityEngine.Animations.ConstraintSource source)
- private void SetSourceInternal(int index, UnityEngine.Animations.ConstraintSource source)
- private void SetSourceInternal_Injected(int index, ref UnityEngine.Animations.ConstraintSource source)
- public void SetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources)
- private static void SetSourcesInternal(UnityEngine.Animations.LookAtConstraint self, System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources)
- private void ValidateSourceIndex(int index)

### public struct UnityEngine.Animations.MuscleHandle

#### Fields
- private int <dof>k__BackingField
- private UnityEngine.HumanPartDof <humanPartDof>k__BackingField

#### Properties
- public int dof { get; private set; }
- public UnityEngine.HumanPartDof humanPartDof { get; private set; }
- public static int muscleHandleCount { get; }
- public string name { get; }

#### Constructors
- public MuscleHandle(UnityEngine.BodyDof bodyDof)
- public MuscleHandle(UnityEngine.HeadDof headDof)
- public MuscleHandle(UnityEngine.HumanPartDof partDof, UnityEngine.LegDof legDof)
- public MuscleHandle(UnityEngine.HumanPartDof partDof, UnityEngine.ArmDof armDof)
- public MuscleHandle(UnityEngine.HumanPartDof partDof, UnityEngine.FingerDof fingerDof)

#### Methods
- private static int GetMuscleHandleCount()
- public static void GetMuscleHandles(UnityEngine.Animations.MuscleHandle[] muscleHandles)
- private string GetName()
- private static string GetName_Injected(ref UnityEngine.Animations.MuscleHandle _unity_self)

### public class UnityEngine.Animations.NotKeyableAttribute
- Base: System.Attribute

#### Constructors
- public NotKeyableAttribute()

### public class UnityEngine.Animations.ParentConstraint
- Base: UnityEngine.Behaviour
- Interfaces: UnityEngine.Animations.IConstraint, UnityEngine.Animations.IConstraintInternal

#### Properties
- public bool constraintActive { get; set; }
- public bool locked { get; set; }
- public UnityEngine.Vector3 rotationAtRest { get; set; }
- public UnityEngine.Animations.Axis rotationAxis { get; set; }
- public UnityEngine.Vector3[] rotationOffsets { get; set; }
- public int sourceCount { get; }
- public UnityEngine.Vector3 translationAtRest { get; set; }
- public UnityEngine.Animations.Axis translationAxis { get; set; }
- public UnityEngine.Vector3[] translationOffsets { get; set; }
- public float weight { get; set; }

#### Constructors
- private ParentConstraint()

#### Methods
- public int AddSource(UnityEngine.Animations.ConstraintSource source)
- private int AddSource_Injected(ref UnityEngine.Animations.ConstraintSource source)
- public UnityEngine.Vector3 GetRotationOffset(int index)
- private UnityEngine.Vector3 GetRotationOffsetInternal(int index)
- private void GetRotationOffsetInternal_Injected(int index, out UnityEngine.Vector3 ret)
- public UnityEngine.Animations.ConstraintSource GetSource(int index)
- private static int GetSourceCountInternal(UnityEngine.Animations.ParentConstraint self)
- private UnityEngine.Animations.ConstraintSource GetSourceInternal(int index)
- private void GetSourceInternal_Injected(int index, out UnityEngine.Animations.ConstraintSource ret)
- public void GetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources)
- public UnityEngine.Vector3 GetTranslationOffset(int index)
- private UnityEngine.Vector3 GetTranslationOffsetInternal(int index)
- private void GetTranslationOffsetInternal_Injected(int index, out UnityEngine.Vector3 ret)
- private static void Internal_Create(UnityEngine.Animations.ParentConstraint self)
- public void RemoveSource(int index)
- private void RemoveSourceInternal(int index)
- public void SetRotationOffset(int index, UnityEngine.Vector3 value)
- private void SetRotationOffsetInternal(int index, UnityEngine.Vector3 value)
- private void SetRotationOffsetInternal_Injected(int index, ref UnityEngine.Vector3 value)
- public void SetSource(int index, UnityEngine.Animations.ConstraintSource source)
- private void SetSourceInternal(int index, UnityEngine.Animations.ConstraintSource source)
- private void SetSourceInternal_Injected(int index, ref UnityEngine.Animations.ConstraintSource source)
- public void SetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources)
- private static void SetSourcesInternal(UnityEngine.Animations.ParentConstraint self, System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources)
- public void SetTranslationOffset(int index, UnityEngine.Vector3 value)
- private void SetTranslationOffsetInternal(int index, UnityEngine.Vector3 value)
- private void SetTranslationOffsetInternal_Injected(int index, ref UnityEngine.Vector3 value)
- private void ValidateSourceIndex(int index)

### public class UnityEngine.Animations.PositionConstraint
- Base: UnityEngine.Behaviour
- Interfaces: UnityEngine.Animations.IConstraint, UnityEngine.Animations.IConstraintInternal

#### Properties
- public bool constraintActive { get; set; }
- public bool locked { get; set; }
- public int sourceCount { get; }
- public UnityEngine.Vector3 translationAtRest { get; set; }
- public UnityEngine.Animations.Axis translationAxis { get; set; }
- public UnityEngine.Vector3 translationOffset { get; set; }
- public float weight { get; set; }

#### Constructors
- private PositionConstraint()

#### Methods
- public int AddSource(UnityEngine.Animations.ConstraintSource source)
- private int AddSource_Injected(ref UnityEngine.Animations.ConstraintSource source)
- public UnityEngine.Animations.ConstraintSource GetSource(int index)
- private static int GetSourceCountInternal(UnityEngine.Animations.PositionConstraint self)
- private UnityEngine.Animations.ConstraintSource GetSourceInternal(int index)
- private void GetSourceInternal_Injected(int index, out UnityEngine.Animations.ConstraintSource ret)
- public void GetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources)
- private static void Internal_Create(UnityEngine.Animations.PositionConstraint self)
- public void RemoveSource(int index)
- private void RemoveSourceInternal(int index)
- public void SetSource(int index, UnityEngine.Animations.ConstraintSource source)
- private void SetSourceInternal(int index, UnityEngine.Animations.ConstraintSource source)
- private void SetSourceInternal_Injected(int index, ref UnityEngine.Animations.ConstraintSource source)
- public void SetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources)
- private static void SetSourcesInternal(UnityEngine.Animations.PositionConstraint self, System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources)
- private void ValidateSourceIndex(int index)

### internal struct UnityEngine.Animations.ProcessAnimationJobStruct<T>

#### Fields
- private static System.IntPtr jobReflectionData

#### Methods
- public static void Execute(ref T data, System.IntPtr animationStreamPtr, System.IntPtr methodIndex, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex)
- public static System.IntPtr GetJobReflectionData()

### public struct UnityEngine.Animations.PropertySceneHandle

#### Fields
- private int handleIndex
- private uint valid

#### Properties
- private bool createdByNative { get; }
- private bool hasHandleIndex { get; }

#### Methods
- private void CheckIsValid(ref UnityEngine.Animations.AnimationStream stream)
- public bool GetBool(UnityEngine.Animations.AnimationStream stream)
- private bool GetBoolInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static bool GetBoolInternal_Injected(ref UnityEngine.Animations.PropertySceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream)
- public float GetFloat(UnityEngine.Animations.AnimationStream stream)
- private float GetFloatInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static float GetFloatInternal_Injected(ref UnityEngine.Animations.PropertySceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream)
- public int GetInt(UnityEngine.Animations.AnimationStream stream)
- private int GetIntInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static int GetIntInternal_Injected(ref UnityEngine.Animations.PropertySceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream)
- private bool HasValidTransform(ref UnityEngine.Animations.AnimationStream stream)
- private static bool HasValidTransform_Injected(ref UnityEngine.Animations.PropertySceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream)
- private bool IsBound(ref UnityEngine.Animations.AnimationStream stream)
- private static bool IsBound_Injected(ref UnityEngine.Animations.PropertySceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream)
- public bool IsResolved(UnityEngine.Animations.AnimationStream stream)
- public bool IsValid(UnityEngine.Animations.AnimationStream stream)
- private bool IsValidInternal(ref UnityEngine.Animations.AnimationStream stream)
- public void Resolve(UnityEngine.Animations.AnimationStream stream)
- private void ResolveInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static void ResolveInternal_Injected(ref UnityEngine.Animations.PropertySceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream)
- public void SetBool(UnityEngine.Animations.AnimationStream stream, bool value)
- public void SetFloat(UnityEngine.Animations.AnimationStream stream, float value)
- public void SetInt(UnityEngine.Animations.AnimationStream stream, int value)

### public struct UnityEngine.Animations.PropertyStreamHandle

#### Fields
- private int bindType
- private int handleIndex
- private uint m_AnimatorBindingsVersion
- private int valueArrayIndex

#### Properties
- internal uint animatorBindingsVersion { get; private set; }
- private bool createdByNative { get; }
- private bool hasBindType { get; }
- private bool hasHandleIndex { get; }
- private bool hasValueArrayIndex { get; }

#### Methods
- private void CheckIsValidAndResolve(ref UnityEngine.Animations.AnimationStream stream)
- public bool GetBool(UnityEngine.Animations.AnimationStream stream)
- private bool GetBoolInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static bool GetBoolInternal_Injected(ref UnityEngine.Animations.PropertyStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream)
- public float GetFloat(UnityEngine.Animations.AnimationStream stream)
- private float GetFloatInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static float GetFloatInternal_Injected(ref UnityEngine.Animations.PropertyStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream)
- public int GetInt(UnityEngine.Animations.AnimationStream stream)
- private int GetIntInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static int GetIntInternal_Injected(ref UnityEngine.Animations.PropertyStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream)
- public bool GetReadMask(UnityEngine.Animations.AnimationStream stream)
- private bool GetReadMaskInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static bool GetReadMaskInternal_Injected(ref UnityEngine.Animations.PropertyStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream)
- public bool IsResolved(UnityEngine.Animations.AnimationStream stream)
- private bool IsResolvedInternal(ref UnityEngine.Animations.AnimationStream stream)
- private bool IsSameVersionAsStream(ref UnityEngine.Animations.AnimationStream stream)
- public bool IsValid(UnityEngine.Animations.AnimationStream stream)
- private bool IsValidInternal(ref UnityEngine.Animations.AnimationStream stream)
- public void Resolve(UnityEngine.Animations.AnimationStream stream)
- private void ResolveInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static void ResolveInternal_Injected(ref UnityEngine.Animations.PropertyStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream)
- public void SetBool(UnityEngine.Animations.AnimationStream stream, bool value)
- private void SetBoolInternal(ref UnityEngine.Animations.AnimationStream stream, bool value)
- private static void SetBoolInternal_Injected(ref UnityEngine.Animations.PropertyStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, bool value)
- public void SetFloat(UnityEngine.Animations.AnimationStream stream, float value)
- private void SetFloatInternal(ref UnityEngine.Animations.AnimationStream stream, float value)
- private static void SetFloatInternal_Injected(ref UnityEngine.Animations.PropertyStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, float value)
- public void SetInt(UnityEngine.Animations.AnimationStream stream, int value)
- private void SetIntInternal(ref UnityEngine.Animations.AnimationStream stream, int value)
- private static void SetIntInternal_Injected(ref UnityEngine.Animations.PropertyStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, int value)

### public class UnityEngine.Animations.RotationConstraint
- Base: UnityEngine.Behaviour
- Interfaces: UnityEngine.Animations.IConstraint, UnityEngine.Animations.IConstraintInternal

#### Properties
- public bool constraintActive { get; set; }
- public bool locked { get; set; }
- public UnityEngine.Vector3 rotationAtRest { get; set; }
- public UnityEngine.Animations.Axis rotationAxis { get; set; }
- public UnityEngine.Vector3 rotationOffset { get; set; }
- public int sourceCount { get; }
- public float weight { get; set; }

#### Constructors
- private RotationConstraint()

#### Methods
- public int AddSource(UnityEngine.Animations.ConstraintSource source)
- private int AddSource_Injected(ref UnityEngine.Animations.ConstraintSource source)
- public UnityEngine.Animations.ConstraintSource GetSource(int index)
- private static int GetSourceCountInternal(UnityEngine.Animations.RotationConstraint self)
- private UnityEngine.Animations.ConstraintSource GetSourceInternal(int index)
- private void GetSourceInternal_Injected(int index, out UnityEngine.Animations.ConstraintSource ret)
- public void GetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources)
- private static void Internal_Create(UnityEngine.Animations.RotationConstraint self)
- public void RemoveSource(int index)
- private void RemoveSourceInternal(int index)
- public void SetSource(int index, UnityEngine.Animations.ConstraintSource source)
- private void SetSourceInternal(int index, UnityEngine.Animations.ConstraintSource source)
- private void SetSourceInternal_Injected(int index, ref UnityEngine.Animations.ConstraintSource source)
- public void SetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources)
- private static void SetSourcesInternal(UnityEngine.Animations.RotationConstraint self, System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources)
- private void ValidateSourceIndex(int index)

### public class UnityEngine.Animations.ScaleConstraint
- Base: UnityEngine.Behaviour
- Interfaces: UnityEngine.Animations.IConstraint, UnityEngine.Animations.IConstraintInternal

#### Properties
- public bool constraintActive { get; set; }
- public bool locked { get; set; }
- public UnityEngine.Vector3 scaleAtRest { get; set; }
- public UnityEngine.Vector3 scaleOffset { get; set; }
- public UnityEngine.Animations.Axis scalingAxis { get; set; }
- public int sourceCount { get; }
- public float weight { get; set; }

#### Constructors
- private ScaleConstraint()

#### Methods
- public int AddSource(UnityEngine.Animations.ConstraintSource source)
- private int AddSource_Injected(ref UnityEngine.Animations.ConstraintSource source)
- public UnityEngine.Animations.ConstraintSource GetSource(int index)
- private static int GetSourceCountInternal(UnityEngine.Animations.ScaleConstraint self)
- private UnityEngine.Animations.ConstraintSource GetSourceInternal(int index)
- private void GetSourceInternal_Injected(int index, out UnityEngine.Animations.ConstraintSource ret)
- public void GetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources)
- private static void Internal_Create(UnityEngine.Animations.ScaleConstraint self)
- public void RemoveSource(int index)
- private void RemoveSourceInternal(int index)
- public void SetSource(int index, UnityEngine.Animations.ConstraintSource source)
- private void SetSourceInternal(int index, UnityEngine.Animations.ConstraintSource source)
- private void SetSourceInternal_Injected(int index, ref UnityEngine.Animations.ConstraintSource source)
- public void SetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources)
- private static void SetSourcesInternal(UnityEngine.Animations.ScaleConstraint self, System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources)
- private void ValidateSourceIndex(int index)

### public struct UnityEngine.Animations.TransformSceneHandle

#### Fields
- private int transformSceneHandleDefinitionIndex
- private uint valid

#### Properties
- private bool createdByNative { get; }
- private bool hasTransformSceneHandleDefinitionIndex { get; }

#### Methods
- private void CheckIsValid(ref UnityEngine.Animations.AnimationStream stream)
- public void GetGlobalTR(UnityEngine.Animations.AnimationStream stream, out UnityEngine.Vector3 position, out UnityEngine.Quaternion rotation)
- private void GetGlobalTRInternal(ref UnityEngine.Animations.AnimationStream stream, out UnityEngine.Vector3 position, out UnityEngine.Quaternion rotation)
- private static void GetGlobalTRInternal_Injected(ref UnityEngine.Animations.TransformSceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, out UnityEngine.Vector3 position, out UnityEngine.Quaternion rotation)
- public UnityEngine.Vector3 GetLocalPosition(UnityEngine.Animations.AnimationStream stream)
- private UnityEngine.Vector3 GetLocalPositionInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static void GetLocalPositionInternal_Injected(ref UnityEngine.Animations.TransformSceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, out UnityEngine.Vector3 ret)
- public UnityEngine.Quaternion GetLocalRotation(UnityEngine.Animations.AnimationStream stream)
- private UnityEngine.Quaternion GetLocalRotationInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static void GetLocalRotationInternal_Injected(ref UnityEngine.Animations.TransformSceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, out UnityEngine.Quaternion ret)
- public UnityEngine.Vector3 GetLocalScale(UnityEngine.Animations.AnimationStream stream)
- private UnityEngine.Vector3 GetLocalScaleInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static void GetLocalScaleInternal_Injected(ref UnityEngine.Animations.TransformSceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, out UnityEngine.Vector3 ret)
- public UnityEngine.Matrix4x4 GetLocalToParentMatrix(UnityEngine.Animations.AnimationStream stream)
- private UnityEngine.Matrix4x4 GetLocalToParentMatrixInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static void GetLocalToParentMatrixInternal_Injected(ref UnityEngine.Animations.TransformSceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, out UnityEngine.Matrix4x4 ret)
- public UnityEngine.Matrix4x4 GetLocalToWorldMatrix(UnityEngine.Animations.AnimationStream stream)
- private UnityEngine.Matrix4x4 GetLocalToWorldMatrixInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static void GetLocalToWorldMatrixInternal_Injected(ref UnityEngine.Animations.TransformSceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, out UnityEngine.Matrix4x4 ret)
- public void GetLocalTRS(UnityEngine.Animations.AnimationStream stream, out UnityEngine.Vector3 position, out UnityEngine.Quaternion rotation, out UnityEngine.Vector3 scale)
- private void GetLocalTRSInternal(ref UnityEngine.Animations.AnimationStream stream, out UnityEngine.Vector3 position, out UnityEngine.Quaternion rotation, out UnityEngine.Vector3 scale)
- private static void GetLocalTRSInternal_Injected(ref UnityEngine.Animations.TransformSceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, out UnityEngine.Vector3 position, out UnityEngine.Quaternion rotation, out UnityEngine.Vector3 scale)
- public UnityEngine.Vector3 GetPosition(UnityEngine.Animations.AnimationStream stream)
- private UnityEngine.Vector3 GetPositionInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static void GetPositionInternal_Injected(ref UnityEngine.Animations.TransformSceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, out UnityEngine.Vector3 ret)
- public UnityEngine.Quaternion GetRotation(UnityEngine.Animations.AnimationStream stream)
- private UnityEngine.Quaternion GetRotationInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static void GetRotationInternal_Injected(ref UnityEngine.Animations.TransformSceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, out UnityEngine.Quaternion ret)
- private bool HasValidTransform(ref UnityEngine.Animations.AnimationStream stream)
- private static bool HasValidTransform_Injected(ref UnityEngine.Animations.TransformSceneHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream)
- public bool IsValid(UnityEngine.Animations.AnimationStream stream)
- public void SetLocalPosition(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position)
- public void SetLocalRotation(UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation)
- public void SetLocalScale(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 scale)
- public void SetPosition(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position)
- public void SetRotation(UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation)

### public struct UnityEngine.Animations.TransformStreamHandle

#### Fields
- private int handleIndex
- private uint m_AnimatorBindingsVersion
- private int skeletonIndex

#### Properties
- internal uint animatorBindingsVersion { get; private set; }
- private bool createdByNative { get; }
- private bool hasHandleIndex { get; }
- private bool hasSkeletonIndex { get; }

#### Methods
- private void CheckIsValidAndResolve(ref UnityEngine.Animations.AnimationStream stream)
- public void GetGlobalTR(UnityEngine.Animations.AnimationStream stream, out UnityEngine.Vector3 position, out UnityEngine.Quaternion rotation)
- private void GetGlobalTRInternal(ref UnityEngine.Animations.AnimationStream stream, out UnityEngine.Vector3 position, out UnityEngine.Quaternion rotation)
- private static void GetGlobalTRInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, out UnityEngine.Vector3 position, out UnityEngine.Quaternion rotation)
- public UnityEngine.Vector3 GetLocalPosition(UnityEngine.Animations.AnimationStream stream)
- private UnityEngine.Vector3 GetLocalPositionInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static void GetLocalPositionInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, out UnityEngine.Vector3 ret)
- public UnityEngine.Quaternion GetLocalRotation(UnityEngine.Animations.AnimationStream stream)
- private UnityEngine.Quaternion GetLocalRotationInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static void GetLocalRotationInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, out UnityEngine.Quaternion ret)
- public UnityEngine.Vector3 GetLocalScale(UnityEngine.Animations.AnimationStream stream)
- private UnityEngine.Vector3 GetLocalScaleInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static void GetLocalScaleInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, out UnityEngine.Vector3 ret)
- public UnityEngine.Matrix4x4 GetLocalToParentMatrix(UnityEngine.Animations.AnimationStream stream)
- private UnityEngine.Matrix4x4 GetLocalToParentMatrixInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static void GetLocalToParentMatrixInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, out UnityEngine.Matrix4x4 ret)
- public UnityEngine.Matrix4x4 GetLocalToWorldMatrix(UnityEngine.Animations.AnimationStream stream)
- private UnityEngine.Matrix4x4 GetLocalToWorldMatrixInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static void GetLocalToWorldMatrixInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, out UnityEngine.Matrix4x4 ret)
- public void GetLocalTRS(UnityEngine.Animations.AnimationStream stream, out UnityEngine.Vector3 position, out UnityEngine.Quaternion rotation, out UnityEngine.Vector3 scale)
- private void GetLocalTRSInternal(ref UnityEngine.Animations.AnimationStream stream, out UnityEngine.Vector3 position, out UnityEngine.Quaternion rotation, out UnityEngine.Vector3 scale)
- private static void GetLocalTRSInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, out UnityEngine.Vector3 position, out UnityEngine.Quaternion rotation, out UnityEngine.Vector3 scale)
- public UnityEngine.Vector3 GetPosition(UnityEngine.Animations.AnimationStream stream)
- private UnityEngine.Vector3 GetPositionInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static void GetPositionInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, out UnityEngine.Vector3 ret)
- public bool GetPositionReadMask(UnityEngine.Animations.AnimationStream stream)
- private bool GetPositionReadMaskInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static bool GetPositionReadMaskInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream)
- public UnityEngine.Quaternion GetRotation(UnityEngine.Animations.AnimationStream stream)
- private UnityEngine.Quaternion GetRotationInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static void GetRotationInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, out UnityEngine.Quaternion ret)
- public bool GetRotationReadMask(UnityEngine.Animations.AnimationStream stream)
- private bool GetRotationReadMaskInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static bool GetRotationReadMaskInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream)
- public bool GetScaleReadMask(UnityEngine.Animations.AnimationStream stream)
- private bool GetScaleReadMaskInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static bool GetScaleReadMaskInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream)
- public bool IsResolved(UnityEngine.Animations.AnimationStream stream)
- private bool IsResolvedInternal(ref UnityEngine.Animations.AnimationStream stream)
- private bool IsSameVersionAsStream(ref UnityEngine.Animations.AnimationStream stream)
- public bool IsValid(UnityEngine.Animations.AnimationStream stream)
- private bool IsValidInternal(ref UnityEngine.Animations.AnimationStream stream)
- public void Resolve(UnityEngine.Animations.AnimationStream stream)
- private void ResolveInternal(ref UnityEngine.Animations.AnimationStream stream)
- private static void ResolveInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream)
- public void SetGlobalTR(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, bool useMask)
- private void SetGlobalTRInternal(ref UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, bool useMask)
- private static void SetGlobalTRInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, bool useMask)
- public void SetLocalPosition(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position)
- private void SetLocalPositionInternal(ref UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position)
- private static void SetLocalPositionInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 position)
- public void SetLocalRotation(UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation)
- private void SetLocalRotationInternal(ref UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation)
- private static void SetLocalRotationInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Quaternion rotation)
- public void SetLocalScale(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 scale)
- private void SetLocalScaleInternal(ref UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 scale)
- private static void SetLocalScaleInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 scale)
- public void SetLocalTRS(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, bool useMask)
- private void SetLocalTRSInternal(ref UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, bool useMask)
- private static void SetLocalTRSInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, ref UnityEngine.Vector3 scale, bool useMask)
- public void SetPosition(UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position)
- private void SetPositionInternal(ref UnityEngine.Animations.AnimationStream stream, UnityEngine.Vector3 position)
- private static void SetPositionInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Vector3 position)
- public void SetRotation(UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation)
- private void SetRotationInternal(ref UnityEngine.Animations.AnimationStream stream, UnityEngine.Quaternion rotation)
- private static void SetRotationInternal_Injected(ref UnityEngine.Animations.TransformStreamHandle _unity_self, ref UnityEngine.Animations.AnimationStream stream, ref UnityEngine.Quaternion rotation)

### public enum UnityEngine.Animations.AimConstraint.WorldUpType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- None = 4
- ObjectRotationUp = 2
- ObjectUp = 1
- SceneUp = 0
- Vector = 3

## Namespace: UnityEngine.Experimental.Animations

### public static class UnityEngine.Experimental.Animations.AnimationPlayableOutputExtensions

#### Methods
- public static UnityEngine.Experimental.Animations.AnimationStreamSource GetAnimationStreamSource(UnityEngine.Animations.AnimationPlayableOutput output)
- public static ushort GetSortingOrder(UnityEngine.Animations.AnimationPlayableOutput output)
- private static UnityEngine.Experimental.Animations.AnimationStreamSource InternalGetAnimationStreamSource(UnityEngine.Playables.PlayableOutputHandle output)
- private static UnityEngine.Experimental.Animations.AnimationStreamSource InternalGetAnimationStreamSource_Injected(ref UnityEngine.Playables.PlayableOutputHandle output)
- private static int InternalGetSortingOrder(UnityEngine.Playables.PlayableOutputHandle output)
- private static int InternalGetSortingOrder_Injected(ref UnityEngine.Playables.PlayableOutputHandle output)
- private static void InternalSetAnimationStreamSource(UnityEngine.Playables.PlayableOutputHandle output, UnityEngine.Experimental.Animations.AnimationStreamSource streamSource)
- private static void InternalSetAnimationStreamSource_Injected(ref UnityEngine.Playables.PlayableOutputHandle output, UnityEngine.Experimental.Animations.AnimationStreamSource streamSource)
- private static void InternalSetSortingOrder(UnityEngine.Playables.PlayableOutputHandle output, int sortingOrder)
- private static void InternalSetSortingOrder_Injected(ref UnityEngine.Playables.PlayableOutputHandle output, int sortingOrder)
- public static void SetAnimationStreamSource(UnityEngine.Animations.AnimationPlayableOutput output, UnityEngine.Experimental.Animations.AnimationStreamSource streamSource)
- public static void SetSortingOrder(UnityEngine.Animations.AnimationPlayableOutput output, ushort sortingOrder)

### public enum UnityEngine.Experimental.Animations.AnimationStreamSource
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DefaultValues = 0
- PreviousInputs = 1

## Namespace: UnityEngine.Playables

### public static class UnityEngine.Playables.AnimationPlayableUtilities

#### Methods
- public static void Play(UnityEngine.Animator animator, UnityEngine.Playables.Playable playable, UnityEngine.Playables.PlayableGraph graph)
- public static UnityEngine.Animations.AnimatorControllerPlayable PlayAnimatorController(UnityEngine.Animator animator, UnityEngine.RuntimeAnimatorController controller, out UnityEngine.Playables.PlayableGraph graph)
- public static UnityEngine.Animations.AnimationClipPlayable PlayClip(UnityEngine.Animator animator, UnityEngine.AnimationClip clip, out UnityEngine.Playables.PlayableGraph graph)
- public static UnityEngine.Animations.AnimationLayerMixerPlayable PlayLayerMixer(UnityEngine.Animator animator, int inputCount, out UnityEngine.Playables.PlayableGraph graph)
- public static UnityEngine.Animations.AnimationMixerPlayable PlayMixer(UnityEngine.Animator animator, int inputCount, out UnityEngine.Playables.PlayableGraph graph)

