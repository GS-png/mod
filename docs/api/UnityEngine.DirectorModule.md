# Assembly: UnityEngine.DirectorModule
- Path: tools/WorldBox.Managed/UnityEngine.DirectorModule.dll
- Types: 1

## Namespace: UnityEngine.Playables

### public class UnityEngine.Playables.PlayableDirector
- Base: UnityEngine.Behaviour
- Interfaces: UnityEngine.IExposedPropertyTable

#### Fields
- private System.Action<UnityEngine.Playables.PlayableDirector> paused
- private System.Action<UnityEngine.Playables.PlayableDirector> played
- private System.Action<UnityEngine.Playables.PlayableDirector> stopped

#### Properties
- public double duration { get; }
- public UnityEngine.Playables.DirectorWrapMode extrapolationMode { get; set; }
- public double initialTime { get; set; }
- public UnityEngine.Playables.PlayableAsset playableAsset { get; set; }
- public UnityEngine.Playables.PlayableGraph playableGraph { get; }
- public bool playOnAwake { get; set; }
- public UnityEngine.Playables.PlayState state { get; }
- public double time { get; set; }
- public UnityEngine.Playables.DirectorUpdateMode timeUpdateMode { get; set; }

#### Events
- public event System.Action<UnityEngine.Playables.PlayableDirector> paused
- public event System.Action<UnityEngine.Playables.PlayableDirector> played
- public event System.Action<UnityEngine.Playables.PlayableDirector> stopped

#### Constructors
- public PlayableDirector()

#### Methods
- public void ClearGenericBinding(UnityEngine.Object key)
- public void ClearReferenceValue(UnityEngine.PropertyName id)
- private void ClearReferenceValue_Injected(ref UnityEngine.PropertyName id)
- public void DeferredEvaluate()
- public void Evaluate()
- private void EvaluateNextFrame()
- public UnityEngine.Object GetGenericBinding(UnityEngine.Object key)
- private UnityEngine.Playables.PlayableGraph GetGraphHandle()
- private void GetGraphHandle_Injected(out UnityEngine.Playables.PlayableGraph ret)
- private bool GetPlayOnAwake()
- private UnityEngine.Playables.PlayState GetPlayState()
- public UnityEngine.Object GetReferenceValue(UnityEngine.PropertyName id, out bool idValid)
- private UnityEngine.Object GetReferenceValue_Injected(ref UnityEngine.PropertyName id, out bool idValid)
- private UnityEngine.Playables.DirectorWrapMode GetWrapMode()
- internal bool HasGenericBinding(UnityEngine.Object key)
- private UnityEngine.ScriptableObject Internal_GetPlayableAsset()
- private void Internal_SetGenericBinding(UnityEngine.Object key, UnityEngine.Object value)
- public void Pause()
- internal void Play(UnityEngine.Playables.FrameRate frameRate)
- public void Play(UnityEngine.Playables.PlayableAsset asset)
- public void Play(UnityEngine.Playables.PlayableAsset asset, UnityEngine.Playables.DirectorWrapMode mode)
- public void Play()
- private void PlayOnFrame(UnityEngine.Playables.FrameRate frameRate)
- private void PlayOnFrame_Injected(ref UnityEngine.Playables.FrameRate frameRate)
- internal void ProcessPendingGraphChanges()
- public void RebindPlayableGraphOutputs()
- public void RebuildGraph()
- internal static void ResetFrameTiming()
- public void Resume()
- private void SendOnPlayableDirectorPause()
- private void SendOnPlayableDirectorPlay()
- private void SendOnPlayableDirectorStop()
- public void SetGenericBinding(UnityEngine.Object key, UnityEngine.Object value)
- private void SetPlayableAsset(UnityEngine.ScriptableObject asset)
- private void SetPlayOnAwake(bool on)
- public void SetReferenceValue(UnityEngine.PropertyName id, UnityEngine.Object value)
- private void SetReferenceValue_Injected(ref UnityEngine.PropertyName id, UnityEngine.Object value)
- private void SetWrapMode(UnityEngine.Playables.DirectorWrapMode mode)
- public void Stop()

