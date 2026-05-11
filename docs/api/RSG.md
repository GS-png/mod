# Assembly: RSG
- Path: tools/WorldBox.Managed/RSG.dll
- Types: 76

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=562 51221E1F7BC6A54B498B966BF0AE3EB22E693FA8849ADE54DB85A05EBC63869F
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=536 F7ACCE152E65EE7446B1A713BF166CF2131CF0F47CF1C954ED20D04EA3A5606D

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=536

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=562

## Namespace: RSG

### private class RSG.PromiseHelpers.<>c__1<T1, T2, T3>

#### Fields
- public static readonly RSG.PromiseHelpers.<>c__1<T1, T2, T3> <>9
- public static System.Func<RSG.Tuple<RSG.Tuple<T1, T2>, T3>, RSG.Tuple<T1, T2, T3>> <>9__1_0

#### Constructors
- private static PromiseHelpers.<>c__1<T1, T2, T3>()
- public PromiseHelpers.<>c__1<T1, T2, T3>()

#### Methods
- internal RSG.Tuple<T1, T2, T3> <All>b__1_0(RSG.Tuple<RSG.Tuple<T1, T2>, T3> vals)

### private class RSG.PromiseHelpers.<>c__2<T1, T2, T3, T4>

#### Fields
- public static readonly RSG.PromiseHelpers.<>c__2<T1, T2, T3, T4> <>9
- public static System.Func<RSG.Tuple<RSG.Tuple<T1, T2>, RSG.Tuple<T3, T4>>, RSG.Tuple<T1, T2, T3, T4>> <>9__2_0

#### Constructors
- private static PromiseHelpers.<>c__2<T1, T2, T3, T4>()
- public PromiseHelpers.<>c__2<T1, T2, T3, T4>()

#### Methods
- internal RSG.Tuple<T1, T2, T3, T4> <All>b__2_0(RSG.Tuple<RSG.Tuple<T1, T2>, RSG.Tuple<T3, T4>> vals)

### private class RSG.PromiseHelpers.<>c__DisplayClass0_0<T1, T2>

#### Fields
- public bool alreadyRejected
- public int numUnresolved
- public RSG.Promise<RSG.Tuple<T1, T2>> promise
- public T1 val1
- public T2 val2

#### Constructors
- public PromiseHelpers.<>c__DisplayClass0_0<T1, T2>()

#### Methods
- internal void <All>b__0(T1 val)
- internal void <All>b__1(System.Exception e)
- internal void <All>b__2(T2 val)
- internal void <All>b__3(System.Exception e)

### private class RSG.Promise<PromisedT>.<>c__DisplayClass24_0<PromisedT>

#### Fields
- public RSG.Promise<PromisedT> <>4__this
- public System.Exception ex

#### Constructors
- public Promise<PromisedT>.<>c__DisplayClass24_0<PromisedT>()

#### Methods
- internal void <InvokeRejectHandlers>b__0(RSG.RejectHandler handler)

### private class RSG.Promise<PromisedT>.<>c__DisplayClass26_0<PromisedT>

#### Fields
- public RSG.Promise<PromisedT> <>4__this
- public float progress

#### Constructors
- public Promise<PromisedT>.<>c__DisplayClass26_0<PromisedT>()

#### Methods
- internal void <InvokeProgressHandlers>b__0(RSG.ProgressHandler handler)

### private class RSG.Promise<PromisedT>.<>c__DisplayClass34_0<PromisedT>

#### Fields
- public System.Action<System.Exception> onRejected
- public RSG.Promise resultPromise

#### Constructors
- public Promise<PromisedT>.<>c__DisplayClass34_0<PromisedT>()

#### Methods
- internal void <Catch>b__0(PromisedT _)
- internal void <Catch>b__1(System.Exception ex)
- internal void <Catch>b__2(float v)

### private class RSG.Promise.<>c__DisplayClass34_0

#### Fields
- public RSG.Promise <>4__this
- public System.Exception ex

#### Constructors
- public Promise.<>c__DisplayClass34_0()

#### Methods
- internal void <InvokeRejectHandlers>b__0(RSG.RejectHandler handler)

### private class RSG.Promise<PromisedT>.<>c__DisplayClass35_0<PromisedT>

#### Fields
- public System.Func<System.Exception, PromisedT> onRejected
- public RSG.Promise<PromisedT> resultPromise

#### Constructors
- public Promise<PromisedT>.<>c__DisplayClass35_0<PromisedT>()

#### Methods
- internal void <Catch>b__0(PromisedT v)
- internal void <Catch>b__1(System.Exception ex)
- internal void <Catch>b__2(float v)

### private class RSG.Promise.<>c__DisplayClass36_0

#### Fields
- public RSG.Promise <>4__this
- public float progress

#### Constructors
- public Promise.<>c__DisplayClass36_0()

#### Methods
- internal void <InvokeProgressHandlers>b__0(RSG.ProgressHandler handler)

### private class RSG.PromiseTimer.<>c__DisplayClass3_0

#### Fields
- public float seconds

#### Constructors
- public PromiseTimer.<>c__DisplayClass3_0()

#### Methods
- internal bool <WaitFor>b__0(RSG.TimeData t)

### private class RSG.Promise<PromisedT>.<>c__DisplayClass42_0<PromisedT, ConvertedT>

#### Fields
- public System.Action<float> <>9__2
- public System.Action<ConvertedT> <>9__3
- public System.Action<System.Exception> <>9__4
- public System.Action<ConvertedT> <>9__5
- public System.Action<System.Exception> <>9__6
- public System.Func<System.Exception, RSG.IPromise<ConvertedT>> onRejected
- public System.Func<PromisedT, RSG.IPromise<ConvertedT>> onResolved
- public RSG.Promise<ConvertedT> resultPromise

#### Constructors
- public Promise<PromisedT>.<>c__DisplayClass42_0<PromisedT, ConvertedT>()

#### Methods
- internal void <Then>b__0(PromisedT v)
- internal void <Then>b__1(System.Exception ex)
- internal void <Then>b__2(float progress)
- internal void <Then>b__3(ConvertedT chainedValue)
- internal void <Then>b__4(System.Exception ex)
- internal void <Then>b__5(ConvertedT chainedValue)
- internal void <Then>b__6(System.Exception callbackEx)

### private class RSG.Promise<PromisedT>.<>c__DisplayClass43_0<PromisedT>

#### Fields
- public System.Action<float> <>9__2
- public System.Action <>9__3
- public System.Action<System.Exception> <>9__4
- public System.Action<System.Exception> onRejected
- public System.Func<PromisedT, RSG.IPromise> onResolved
- public RSG.Promise resultPromise

#### Constructors
- public Promise<PromisedT>.<>c__DisplayClass43_0<PromisedT>()

#### Methods
- internal void <Then>b__0(PromisedT v)
- internal void <Then>b__1(System.Exception ex)
- internal void <Then>b__2(float progress)
- internal void <Then>b__3()
- internal void <Then>b__4(System.Exception ex)

### private class RSG.Promise<PromisedT>.<>c__DisplayClass44_0<PromisedT>

#### Fields
- public System.Action<System.Exception> onRejected
- public System.Action<PromisedT> onResolved
- public RSG.Promise resultPromise

#### Constructors
- public Promise<PromisedT>.<>c__DisplayClass44_0<PromisedT>()

#### Methods
- internal void <Then>b__0(PromisedT v)
- internal void <Then>b__1(System.Exception ex)

### private class RSG.Promise.<>c__DisplayClass44_0

#### Fields
- public System.Action<System.Exception> onRejected
- public RSG.Promise resultPromise

#### Constructors
- public Promise.<>c__DisplayClass44_0()

#### Methods
- internal void <Catch>b__0()
- internal void <Catch>b__1(System.Exception ex)
- internal void <Catch>b__2(float v)

### private class RSG.Promise<PromisedT>.<>c__DisplayClass45_0<PromisedT, ConvertedT>

#### Fields
- public System.Func<PromisedT, ConvertedT> transform

#### Constructors
- public Promise<PromisedT>.<>c__DisplayClass45_0<PromisedT, ConvertedT>()

#### Methods
- internal RSG.IPromise<ConvertedT> <Then>b__0(PromisedT value)

### private class RSG.Promise<PromisedT>.<>c__DisplayClass48_0<PromisedT, ConvertedT>

#### Fields
- public System.Func<PromisedT, System.Collections.Generic.IEnumerable<RSG.IPromise<ConvertedT>>> chain

#### Constructors
- public Promise<PromisedT>.<>c__DisplayClass48_0<PromisedT, ConvertedT>()

#### Methods
- internal RSG.IPromise<System.Collections.Generic.IEnumerable<ConvertedT>> <ThenAll>b__0(PromisedT value)

### private class RSG.Promise<PromisedT>.<>c__DisplayClass49_0<PromisedT>

#### Fields
- public System.Func<PromisedT, System.Collections.Generic.IEnumerable<RSG.IPromise>> chain

#### Constructors
- public Promise<PromisedT>.<>c__DisplayClass49_0<PromisedT>()

#### Methods
- internal RSG.IPromise <ThenAll>b__0(PromisedT value)

### private class RSG.PromiseTimer.<>c__DisplayClass4_0

#### Fields
- public System.Func<RSG.TimeData, bool> predicate

#### Constructors
- public PromiseTimer.<>c__DisplayClass4_0()

#### Methods
- internal bool <WaitWhile>b__0(RSG.TimeData t)

### private class RSG.Promise<PromisedT>.<>c__DisplayClass51_0<PromisedT>

#### Fields
- public System.Action<System.Exception> <>9__3
- public float[] progress
- public int remainingCount
- public RSG.Promise<System.Collections.Generic.IEnumerable<PromisedT>> resultPromise
- public PromisedT[] results

#### Constructors
- public Promise<PromisedT>.<>c__DisplayClass51_0<PromisedT>()

#### Methods
- internal void <All>b__0(RSG.IPromise<PromisedT> promise, int index)
- internal void <All>b__3(System.Exception ex)

### private class RSG.Promise.<>c__DisplayClass51_0<ConvertedT>

#### Fields
- public System.Action<float> <>9__2
- public System.Action<ConvertedT> <>9__3
- public System.Action<System.Exception> <>9__4
- public System.Action<ConvertedT> <>9__5
- public System.Action<System.Exception> <>9__6
- public System.Func<System.Exception, RSG.IPromise<ConvertedT>> onRejected
- public System.Func<RSG.IPromise<ConvertedT>> onResolved
- public RSG.Promise<ConvertedT> resultPromise

#### Constructors
- public Promise.<>c__DisplayClass51_0<ConvertedT>()

#### Methods
- internal void <Then>b__0()
- internal void <Then>b__1(System.Exception ex)
- internal void <Then>b__2(float progress)
- internal void <Then>b__3(ConvertedT chainedValue)
- internal void <Then>b__4(System.Exception ex)
- internal void <Then>b__5(ConvertedT chainedValue)
- internal void <Then>b__6(System.Exception callbackEx)

### private class RSG.Promise<PromisedT>.<>c__DisplayClass51_1<PromisedT>

#### Fields
- public RSG.Promise<PromisedT>.<>c__DisplayClass51_0<PromisedT> CS$<>8__locals1
- public int index

#### Constructors
- public Promise<PromisedT>.<>c__DisplayClass51_1<PromisedT>()

#### Methods
- internal void <All>b__1(float v)
- internal void <All>b__2(PromisedT result)

### private class RSG.Promise.<>c__DisplayClass52_0

#### Fields
- public System.Action<float> <>9__2
- public System.Action <>9__3
- public System.Action<System.Exception> <>9__4
- public System.Action<System.Exception> onRejected
- public System.Func<RSG.IPromise> onResolved
- public RSG.Promise resultPromise

#### Constructors
- public Promise.<>c__DisplayClass52_0()

#### Methods
- internal void <Then>b__0()
- internal void <Then>b__1(System.Exception ex)
- internal void <Then>b__2(float progress)
- internal void <Then>b__3()
- internal void <Then>b__4(System.Exception ex)

### private class RSG.Promise<PromisedT>.<>c__DisplayClass52_0<PromisedT, ConvertedT>

#### Fields
- public System.Func<PromisedT, System.Collections.Generic.IEnumerable<RSG.IPromise<ConvertedT>>> chain

#### Constructors
- public Promise<PromisedT>.<>c__DisplayClass52_0<PromisedT, ConvertedT>()

#### Methods
- internal RSG.IPromise<ConvertedT> <ThenRace>b__0(PromisedT value)

### private class RSG.Promise<PromisedT>.<>c__DisplayClass53_0<PromisedT>

#### Fields
- public System.Func<PromisedT, System.Collections.Generic.IEnumerable<RSG.IPromise>> chain

#### Constructors
- public Promise<PromisedT>.<>c__DisplayClass53_0<PromisedT>()

#### Methods
- internal RSG.IPromise <ThenRace>b__0(PromisedT value)

### private class RSG.Promise.<>c__DisplayClass53_0

#### Fields
- public System.Action<System.Exception> onRejected
- public System.Action onResolved
- public RSG.Promise resultPromise

#### Constructors
- public Promise.<>c__DisplayClass53_0()

#### Methods
- internal void <Then>b__0()
- internal void <Then>b__1(System.Exception ex)

### private class RSG.Promise<PromisedT>.<>c__DisplayClass55_0<PromisedT>

#### Fields
- public System.Action<PromisedT> <>9__2
- public System.Action<System.Exception> <>9__3
- public float[] progress
- public RSG.Promise<PromisedT> resultPromise

#### Constructors
- public Promise<PromisedT>.<>c__DisplayClass55_0<PromisedT>()

#### Methods
- internal void <Race>b__0(RSG.IPromise<PromisedT> promise, int index)
- internal void <Race>b__2(PromisedT result)
- internal void <Race>b__3(System.Exception ex)

### private class RSG.Promise<PromisedT>.<>c__DisplayClass55_1<PromisedT>

#### Fields
- public RSG.Promise<PromisedT>.<>c__DisplayClass55_0<PromisedT> CS$<>8__locals1
- public int index

#### Constructors
- public Promise<PromisedT>.<>c__DisplayClass55_1<PromisedT>()

#### Methods
- internal void <Race>b__1(float v)

### private class RSG.Promise.<>c__DisplayClass56_0

#### Fields
- public System.Func<System.Collections.Generic.IEnumerable<RSG.IPromise>> chain

#### Constructors
- public Promise.<>c__DisplayClass56_0()

#### Methods
- internal RSG.IPromise <ThenAll>b__0()

### private class RSG.Promise.<>c__DisplayClass57_0<ConvertedT>

#### Fields
- public System.Func<System.Collections.Generic.IEnumerable<RSG.IPromise<ConvertedT>>> chain

#### Constructors
- public Promise.<>c__DisplayClass57_0<ConvertedT>()

#### Methods
- internal RSG.IPromise<System.Collections.Generic.IEnumerable<ConvertedT>> <ThenAll>b__0()

### private class RSG.Promise<PromisedT>.<>c__DisplayClass58_0<PromisedT>

#### Fields
- public System.Action onComplete
- public RSG.Promise<PromisedT> promise

#### Constructors
- public Promise<PromisedT>.<>c__DisplayClass58_0<PromisedT>()

#### Methods
- internal void <Finally>b__0(PromisedT x)
- internal void <Finally>b__1(System.Exception e)
- internal PromisedT <Finally>b__2(PromisedT v)

### private class RSG.Promise<PromisedT>.<>c__DisplayClass59_0<PromisedT>

#### Fields
- public RSG.Promise promise

#### Constructors
- public Promise<PromisedT>.<>c__DisplayClass59_0<PromisedT>()

#### Methods
- internal void <ContinueWith>b__0(PromisedT x)
- internal void <ContinueWith>b__1(System.Exception e)

### private class RSG.Promise.<>c__DisplayClass59_0

#### Fields
- public System.Action<System.Exception> <>9__3
- public float[] progress
- public int remainingCount
- public RSG.Promise resultPromise

#### Constructors
- public Promise.<>c__DisplayClass59_0()

#### Methods
- internal void <All>b__0(RSG.IPromise promise, int index)
- internal void <All>b__3(System.Exception ex)

### private class RSG.Promise.<>c__DisplayClass59_1

#### Fields
- public RSG.Promise.<>c__DisplayClass59_0 CS$<>8__locals1
- public int index

#### Constructors
- public Promise.<>c__DisplayClass59_1()

#### Methods
- internal void <All>b__1(float v)
- internal void <All>b__2()

### private class RSG.Promise.<>c__DisplayClass60_0

#### Fields
- public System.Func<System.Collections.Generic.IEnumerable<System.Func<RSG.IPromise>>> chain

#### Constructors
- public Promise.<>c__DisplayClass60_0()

#### Methods
- internal RSG.IPromise <ThenSequence>b__0()

### private class RSG.Promise<PromisedT>.<>c__DisplayClass60_0<PromisedT, ConvertedT>

#### Fields
- public RSG.Promise promise

#### Constructors
- public Promise<PromisedT>.<>c__DisplayClass60_0<PromisedT, ConvertedT>()

#### Methods
- internal void <ContinueWith>b__0(PromisedT x)
- internal void <ContinueWith>b__1(System.Exception e)

### private class RSG.Promise.<>c__DisplayClass62_0

#### Fields
- public int count
- public RSG.Promise promise

#### Constructors
- public Promise.<>c__DisplayClass62_0()

#### Methods
- internal RSG.IPromise <Sequence>b__0(RSG.IPromise prevPromise, System.Func<RSG.IPromise> fn)
- internal void <Sequence>b__1()

### private class RSG.Promise.<>c__DisplayClass62_1

#### Fields
- public RSG.Promise.<>c__DisplayClass62_0 CS$<>8__locals1
- public System.Func<RSG.IPromise> fn
- public int itemSequence

#### Constructors
- public Promise.<>c__DisplayClass62_1()

#### Methods
- internal RSG.IPromise <Sequence>b__2()
- internal void <Sequence>b__3(float v)

### private class RSG.Promise.<>c__DisplayClass63_0

#### Fields
- public System.Func<System.Collections.Generic.IEnumerable<RSG.IPromise>> chain

#### Constructors
- public Promise.<>c__DisplayClass63_0()

#### Methods
- internal RSG.IPromise <ThenRace>b__0()

### private class RSG.Promise.<>c__DisplayClass64_0<ConvertedT>

#### Fields
- public System.Func<System.Collections.Generic.IEnumerable<RSG.IPromise<ConvertedT>>> chain

#### Constructors
- public Promise.<>c__DisplayClass64_0<ConvertedT>()

#### Methods
- internal RSG.IPromise<ConvertedT> <ThenRace>b__0()

### private class RSG.Promise.<>c__DisplayClass66_0

#### Fields
- public System.Action<System.Exception> <>9__2
- public System.Action <>9__3
- public float[] progress
- public RSG.Promise resultPromise

#### Constructors
- public Promise.<>c__DisplayClass66_0()

#### Methods
- internal void <Race>b__0(RSG.IPromise promise, int index)
- internal void <Race>b__2(System.Exception ex)
- internal void <Race>b__3()

### private class RSG.Promise.<>c__DisplayClass66_1

#### Fields
- public RSG.Promise.<>c__DisplayClass66_0 CS$<>8__locals1
- public int index

#### Constructors
- public Promise.<>c__DisplayClass66_1()

#### Methods
- internal void <Race>b__1(float v)

### private class RSG.Promise.<>c__DisplayClass69_0

#### Fields
- public System.Action onComplete
- public RSG.Promise promise

#### Constructors
- public Promise.<>c__DisplayClass69_0()

#### Methods
- internal void <Finally>b__0()
- internal void <Finally>b__1(System.Exception e)

### private class RSG.Promise.<>c__DisplayClass70_0

#### Fields
- public RSG.Promise promise

#### Constructors
- public Promise.<>c__DisplayClass70_0()

#### Methods
- internal void <ContinueWith>b__0()
- internal void <ContinueWith>b__1(System.Exception e)

### private class RSG.Promise.<>c__DisplayClass71_0<ConvertedT>

#### Fields
- public RSG.Promise promise

#### Constructors
- public Promise.<>c__DisplayClass71_0<ConvertedT>()

#### Methods
- internal void <ContinueWith>b__0()
- internal void <ContinueWith>b__1(System.Exception e)

### public class RSG.ExceptionEventArgs
- Base: System.EventArgs

#### Fields
- private System.Exception <Exception>k__BackingField

#### Properties
- public System.Exception Exception { get; private set; }

#### Constructors
- internal ExceptionEventArgs(System.Exception exception)

### public interface RSG.IPendingPromise
- Interfaces: RSG.IRejectable

#### Properties
- public int Id { get; }

#### Methods
- public void ReportProgress(float progress)
- public void Resolve()

### public interface RSG.IPendingPromise<PromisedT>
- Interfaces: RSG.IRejectable

#### Properties
- public int Id { get; }

#### Methods
- public void ReportProgress(float progress)
- public void Resolve(PromisedT value)

### public interface RSG.IPromise

#### Properties
- public int Id { get; }

#### Methods
- public RSG.IPromise Catch(System.Action<System.Exception> onRejected)
- public RSG.IPromise ContinueWith(System.Func<RSG.IPromise> onResolved)
- public RSG.IPromise<ConvertedT> ContinueWith<ConvertedT>(System.Func<RSG.IPromise<ConvertedT>> onComplete)
- public void Done(System.Action onResolved, System.Action<System.Exception> onRejected)
- public void Done(System.Action onResolved)
- public void Done()
- public RSG.IPromise Finally(System.Action onComplete)
- public RSG.IPromise Progress(System.Action<float> onProgress)
- public RSG.IPromise<ConvertedT> Then<ConvertedT>(System.Func<RSG.IPromise<ConvertedT>> onResolved)
- public RSG.IPromise Then(System.Func<RSG.IPromise> onResolved)
- public RSG.IPromise Then(System.Action onResolved)
- public RSG.IPromise<ConvertedT> Then<ConvertedT>(System.Func<RSG.IPromise<ConvertedT>> onResolved, System.Func<System.Exception, RSG.IPromise<ConvertedT>> onRejected)
- public RSG.IPromise Then(System.Func<RSG.IPromise> onResolved, System.Action<System.Exception> onRejected)
- public RSG.IPromise Then(System.Action onResolved, System.Action<System.Exception> onRejected)
- public RSG.IPromise<ConvertedT> Then<ConvertedT>(System.Func<RSG.IPromise<ConvertedT>> onResolved, System.Func<System.Exception, RSG.IPromise<ConvertedT>> onRejected, System.Action<float> onProgress)
- public RSG.IPromise Then(System.Func<RSG.IPromise> onResolved, System.Action<System.Exception> onRejected, System.Action<float> onProgress)
- public RSG.IPromise Then(System.Action onResolved, System.Action<System.Exception> onRejected, System.Action<float> onProgress)
- public RSG.IPromise ThenAll(System.Func<System.Collections.Generic.IEnumerable<RSG.IPromise>> chain)
- public RSG.IPromise<System.Collections.Generic.IEnumerable<ConvertedT>> ThenAll<ConvertedT>(System.Func<System.Collections.Generic.IEnumerable<RSG.IPromise<ConvertedT>>> chain)
- public RSG.IPromise ThenRace(System.Func<System.Collections.Generic.IEnumerable<RSG.IPromise>> chain)
- public RSG.IPromise<ConvertedT> ThenRace<ConvertedT>(System.Func<System.Collections.Generic.IEnumerable<RSG.IPromise<ConvertedT>>> chain)
- public RSG.IPromise ThenSequence(System.Func<System.Collections.Generic.IEnumerable<System.Func<RSG.IPromise>>> chain)
- public RSG.IPromise WithName(string name)

### public interface RSG.IPromiseInfo

#### Properties
- public int Id { get; }
- public string Name { get; }

### public interface RSG.IPromiseTimer

#### Methods
- public bool Cancel(RSG.IPromise promise)
- public void Update(float deltaTime)
- public RSG.IPromise WaitFor(float seconds)
- public RSG.IPromise WaitUntil(System.Func<RSG.TimeData, bool> predicate)
- public RSG.IPromise WaitWhile(System.Func<RSG.TimeData, bool> predicate)

### public interface RSG.IPromise<PromisedT>

#### Properties
- public int Id { get; }

#### Methods
- public RSG.IPromise Catch(System.Action<System.Exception> onRejected)
- public RSG.IPromise<PromisedT> Catch(System.Func<System.Exception, PromisedT> onRejected)
- public RSG.IPromise ContinueWith(System.Func<RSG.IPromise> onResolved)
- public RSG.IPromise<ConvertedT> ContinueWith<ConvertedT>(System.Func<RSG.IPromise<ConvertedT>> onComplete)
- public void Done(System.Action<PromisedT> onResolved, System.Action<System.Exception> onRejected)
- public void Done(System.Action<PromisedT> onResolved)
- public void Done()
- public RSG.IPromise<PromisedT> Finally(System.Action onComplete)
- public RSG.IPromise<PromisedT> Progress(System.Action<float> onProgress)
- public RSG.IPromise<ConvertedT> Then<ConvertedT>(System.Func<PromisedT, RSG.IPromise<ConvertedT>> onResolved)
- public RSG.IPromise Then(System.Func<PromisedT, RSG.IPromise> onResolved)
- public RSG.IPromise Then(System.Action<PromisedT> onResolved)
- public RSG.IPromise<ConvertedT> Then<ConvertedT>(System.Func<PromisedT, RSG.IPromise<ConvertedT>> onResolved, System.Func<System.Exception, RSG.IPromise<ConvertedT>> onRejected)
- public RSG.IPromise Then(System.Func<PromisedT, RSG.IPromise> onResolved, System.Action<System.Exception> onRejected)
- public RSG.IPromise Then(System.Action<PromisedT> onResolved, System.Action<System.Exception> onRejected)
- public RSG.IPromise<ConvertedT> Then<ConvertedT>(System.Func<PromisedT, RSG.IPromise<ConvertedT>> onResolved, System.Func<System.Exception, RSG.IPromise<ConvertedT>> onRejected, System.Action<float> onProgress)
- public RSG.IPromise Then(System.Func<PromisedT, RSG.IPromise> onResolved, System.Action<System.Exception> onRejected, System.Action<float> onProgress)
- public RSG.IPromise Then(System.Action<PromisedT> onResolved, System.Action<System.Exception> onRejected, System.Action<float> onProgress)
- public RSG.IPromise<ConvertedT> Then<ConvertedT>(System.Func<PromisedT, ConvertedT> transform)
- public RSG.IPromise<System.Collections.Generic.IEnumerable<ConvertedT>> ThenAll<ConvertedT>(System.Func<PromisedT, System.Collections.Generic.IEnumerable<RSG.IPromise<ConvertedT>>> chain)
- public RSG.IPromise ThenAll(System.Func<PromisedT, System.Collections.Generic.IEnumerable<RSG.IPromise>> chain)
- public RSG.IPromise<ConvertedT> ThenRace<ConvertedT>(System.Func<PromisedT, System.Collections.Generic.IEnumerable<RSG.IPromise<ConvertedT>>> chain)
- public RSG.IPromise ThenRace(System.Func<PromisedT, System.Collections.Generic.IEnumerable<RSG.IPromise>> chain)
- public RSG.IPromise<PromisedT> WithName(string name)

### public interface RSG.IRejectable

#### Methods
- public void Reject(System.Exception ex)

### internal class RSG.PredicateWait

#### Fields
- public int frameStarted
- public RSG.IPendingPromise pendingPromise
- public System.Func<RSG.TimeData, bool> predicate
- public RSG.TimeData timeData
- public float timeStarted

#### Constructors
- public PredicateWait()

### public struct RSG.ProgressHandler

#### Fields
- public System.Action<float> callback
- public RSG.IRejectable rejectable

### public class RSG.Promise
- Interfaces: RSG.IPromise, RSG.IPendingPromise, RSG.IRejectable, RSG.IPromiseInfo

#### Fields
- private RSG.PromiseState <CurState>k__BackingField
- private string <Name>k__BackingField
- public static bool EnablePromiseTracking
- private readonly int id
- private static int nextPromiseId
- internal static readonly System.Collections.Generic.HashSet<RSG.IPromiseInfo> PendingPromises
- private System.Collections.Generic.List<RSG.ProgressHandler> progressHandlers
- private System.Collections.Generic.List<RSG.RejectHandler> rejectHandlers
- private System.Exception rejectionException
- private System.Collections.Generic.List<RSG.Promise.ResolveHandler> resolveHandlers
- private static System.EventHandler<RSG.ExceptionEventArgs> unhandlerException

#### Properties
- public RSG.PromiseState CurState { get; private set; }
- public int Id { get; }
- public string Name { get; private set; }

#### Events
- public static event System.EventHandler<RSG.ExceptionEventArgs> UnhandledException

#### Constructors
- public Promise()
- private static Promise()
- public Promise(System.Action<System.Action, System.Action<System.Exception>> resolver)

#### Methods
- private void <Done>b__40_0(System.Exception ex)
- private void <Done>b__41_0(System.Exception ex)
- private void <Done>b__42_0(System.Exception ex)
- private void <InvokeResolveHandlers>b__35_0(RSG.Promise.ResolveHandler handler)
- private void ActionHandlers(RSG.IRejectable resultPromise, System.Action resolveHandler, System.Action<System.Exception> rejectHandler)
- private void AddProgressHandler(System.Action<float> onProgress, RSG.IRejectable rejectable)
- private void AddRejectHandler(System.Action<System.Exception> onRejected, RSG.IRejectable rejectable)
- private void AddResolveHandler(System.Action onResolved, RSG.IRejectable rejectable)
- public static RSG.IPromise All(params RSG.IPromise[] promises)
- public static RSG.IPromise All(System.Collections.Generic.IEnumerable<RSG.IPromise> promises)
- public RSG.IPromise Catch(System.Action<System.Exception> onRejected)
- private void ClearHandlers()
- public RSG.IPromise ContinueWith(System.Func<RSG.IPromise> onComplete)
- public RSG.IPromise<ConvertedT> ContinueWith<ConvertedT>(System.Func<RSG.IPromise<ConvertedT>> onComplete)
- public void Done(System.Action onResolved, System.Action<System.Exception> onRejected)
- public void Done(System.Action onResolved)
- public void Done()
- public RSG.IPromise Finally(System.Action onComplete)
- public static System.Collections.Generic.IEnumerable<RSG.IPromiseInfo> GetPendingPromises()
- private void InvokeProgressHandler(System.Action<float> callback, RSG.IRejectable rejectable, float progress)
- private void InvokeProgressHandlers(float progress)
- private void InvokeRejectHandler(System.Action<System.Exception> callback, RSG.IRejectable rejectable, System.Exception value)
- private void InvokeRejectHandlers(System.Exception ex)
- private void InvokeResolveHandler(System.Action callback, RSG.IRejectable rejectable)
- private void InvokeResolveHandlers()
- internal static int NextId()
- public RSG.IPromise Progress(System.Action<float> onProgress)
- private void ProgressHandlers(RSG.IRejectable resultPromise, System.Action<float> progressHandler)
- internal static void PropagateUnhandledException(object sender, System.Exception ex)
- public static RSG.IPromise Race(params RSG.IPromise[] promises)
- public static RSG.IPromise Race(System.Collections.Generic.IEnumerable<RSG.IPromise> promises)
- public void Reject(System.Exception ex)
- public static RSG.IPromise Rejected(System.Exception ex)
- public void ReportProgress(float progress)
- public void Resolve()
- public static RSG.IPromise Resolved()
- public static RSG.IPromise Sequence(params System.Func<RSG.IPromise>[] fns)
- public static RSG.IPromise Sequence(System.Collections.Generic.IEnumerable<System.Func<RSG.IPromise>> fns)
- public RSG.IPromise<ConvertedT> Then<ConvertedT>(System.Func<RSG.IPromise<ConvertedT>> onResolved)
- public RSG.IPromise Then(System.Func<RSG.IPromise> onResolved)
- public RSG.IPromise Then(System.Action onResolved)
- public RSG.IPromise<ConvertedT> Then<ConvertedT>(System.Func<RSG.IPromise<ConvertedT>> onResolved, System.Func<System.Exception, RSG.IPromise<ConvertedT>> onRejected)
- public RSG.IPromise Then(System.Func<RSG.IPromise> onResolved, System.Action<System.Exception> onRejected)
- public RSG.IPromise Then(System.Action onResolved, System.Action<System.Exception> onRejected)
- public RSG.IPromise<ConvertedT> Then<ConvertedT>(System.Func<RSG.IPromise<ConvertedT>> onResolved, System.Func<System.Exception, RSG.IPromise<ConvertedT>> onRejected, System.Action<float> onProgress)
- public RSG.IPromise Then(System.Func<RSG.IPromise> onResolved, System.Action<System.Exception> onRejected, System.Action<float> onProgress)
- public RSG.IPromise Then(System.Action onResolved, System.Action<System.Exception> onRejected, System.Action<float> onProgress)
- public RSG.IPromise ThenAll(System.Func<System.Collections.Generic.IEnumerable<RSG.IPromise>> chain)
- public RSG.IPromise<System.Collections.Generic.IEnumerable<ConvertedT>> ThenAll<ConvertedT>(System.Func<System.Collections.Generic.IEnumerable<RSG.IPromise<ConvertedT>>> chain)
- public RSG.IPromise ThenRace(System.Func<System.Collections.Generic.IEnumerable<RSG.IPromise>> chain)
- public RSG.IPromise<ConvertedT> ThenRace<ConvertedT>(System.Func<System.Collections.Generic.IEnumerable<RSG.IPromise<ConvertedT>>> chain)
- public RSG.IPromise ThenSequence(System.Func<System.Collections.Generic.IEnumerable<System.Func<RSG.IPromise>>> chain)
- public RSG.IPromise WithName(string name)

### public class RSG.PromiseCancelledException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public PromiseCancelledException()
- public PromiseCancelledException(string message)

### public static class RSG.PromiseHelpers

#### Methods
- public static RSG.IPromise<RSG.Tuple<T1, T2>> All<T1, T2>(RSG.IPromise<T1> p1, RSG.IPromise<T2> p2)
- public static RSG.IPromise<RSG.Tuple<T1, T2, T3>> All<T1, T2, T3>(RSG.IPromise<T1> p1, RSG.IPromise<T2> p2, RSG.IPromise<T3> p3)
- public static RSG.IPromise<RSG.Tuple<T1, T2, T3, T4>> All<T1, T2, T3, T4>(RSG.IPromise<T1> p1, RSG.IPromise<T2> p2, RSG.IPromise<T3> p3, RSG.IPromise<T4> p4)

### public enum RSG.PromiseState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Pending = 0
- Rejected = 1
- Resolved = 2

### public class RSG.PromiseTimer
- Interfaces: RSG.IPromiseTimer

#### Fields
- private int curFrame
- private float curTime
- private readonly System.Collections.Generic.LinkedList<RSG.PredicateWait> waiting

#### Constructors
- public PromiseTimer()

#### Methods
- public bool Cancel(RSG.IPromise promise)
- private System.Collections.Generic.LinkedListNode<RSG.PredicateWait> FindInWaiting(RSG.IPromise promise)
- private System.Collections.Generic.LinkedListNode<RSG.PredicateWait> RemoveNode(System.Collections.Generic.LinkedListNode<RSG.PredicateWait> node)
- public void Update(float deltaTime)
- public RSG.IPromise WaitFor(float seconds)
- public RSG.IPromise WaitUntil(System.Func<RSG.TimeData, bool> predicate)
- public RSG.IPromise WaitWhile(System.Func<RSG.TimeData, bool> predicate)

### public class RSG.Promise<PromisedT>
- Interfaces: RSG.IPromise<PromisedT>, RSG.IPendingPromise<PromisedT>, RSG.IRejectable, RSG.IPromiseInfo

#### Fields
- private RSG.PromiseState <CurState>k__BackingField
- private string <Name>k__BackingField
- private readonly int id
- private System.Collections.Generic.List<RSG.ProgressHandler> progressHandlers
- private System.Collections.Generic.List<RSG.RejectHandler> rejectHandlers
- private System.Exception rejectionException
- private System.Collections.Generic.List<System.Action<PromisedT>> resolveCallbacks
- private System.Collections.Generic.List<RSG.IRejectable> resolveRejectables
- private PromisedT resolveValue

#### Properties
- public RSG.PromiseState CurState { get; private set; }
- public int Id { get; }
- public string Name { get; private set; }

#### Constructors
- public Promise<PromisedT>()
- public Promise<PromisedT>(System.Action<System.Action<PromisedT>, System.Action<System.Exception>> resolver)

#### Methods
- private void <Done>b__30_0(System.Exception ex)
- private void <Done>b__31_0(System.Exception ex)
- private void <Done>b__32_0(System.Exception ex)
- private void ActionHandlers(RSG.IRejectable resultPromise, System.Action<PromisedT> resolveHandler, System.Action<System.Exception> rejectHandler)
- private void AddProgressHandler(System.Action<float> onProgress, RSG.IRejectable rejectable)
- private void AddRejectHandler(System.Action<System.Exception> onRejected, RSG.IRejectable rejectable)
- private void AddResolveHandler(System.Action<PromisedT> onResolved, RSG.IRejectable rejectable)
- public static RSG.IPromise<System.Collections.Generic.IEnumerable<PromisedT>> All(params RSG.IPromise<PromisedT>[] promises)
- public static RSG.IPromise<System.Collections.Generic.IEnumerable<PromisedT>> All(System.Collections.Generic.IEnumerable<RSG.IPromise<PromisedT>> promises)
- public RSG.IPromise Catch(System.Action<System.Exception> onRejected)
- public RSG.IPromise<PromisedT> Catch(System.Func<System.Exception, PromisedT> onRejected)
- private void ClearHandlers()
- public RSG.IPromise ContinueWith(System.Func<RSG.IPromise> onComplete)
- public RSG.IPromise<ConvertedT> ContinueWith<ConvertedT>(System.Func<RSG.IPromise<ConvertedT>> onComplete)
- public void Done(System.Action<PromisedT> onResolved, System.Action<System.Exception> onRejected)
- public void Done(System.Action<PromisedT> onResolved)
- public void Done()
- public RSG.IPromise<PromisedT> Finally(System.Action onComplete)
- private void InvokeHandler<T>(System.Action<T> callback, RSG.IRejectable rejectable, T value)
- private void InvokeProgressHandlers(float progress)
- private void InvokeRejectHandlers(System.Exception ex)
- private void InvokeResolveHandlers(PromisedT value)
- public RSG.IPromise<PromisedT> Progress(System.Action<float> onProgress)
- private void ProgressHandlers(RSG.IRejectable resultPromise, System.Action<float> progressHandler)
- public static RSG.IPromise<PromisedT> Race(params RSG.IPromise<PromisedT>[] promises)
- public static RSG.IPromise<PromisedT> Race(System.Collections.Generic.IEnumerable<RSG.IPromise<PromisedT>> promises)
- public void Reject(System.Exception ex)
- public static RSG.IPromise<PromisedT> Rejected(System.Exception ex)
- public void ReportProgress(float progress)
- public void Resolve(PromisedT value)
- public static RSG.IPromise<PromisedT> Resolved(PromisedT promisedValue)
- public RSG.IPromise<ConvertedT> Then<ConvertedT>(System.Func<PromisedT, RSG.IPromise<ConvertedT>> onResolved)
- public RSG.IPromise Then(System.Func<PromisedT, RSG.IPromise> onResolved)
- public RSG.IPromise Then(System.Action<PromisedT> onResolved)
- public RSG.IPromise<ConvertedT> Then<ConvertedT>(System.Func<PromisedT, RSG.IPromise<ConvertedT>> onResolved, System.Func<System.Exception, RSG.IPromise<ConvertedT>> onRejected)
- public RSG.IPromise Then(System.Func<PromisedT, RSG.IPromise> onResolved, System.Action<System.Exception> onRejected)
- public RSG.IPromise Then(System.Action<PromisedT> onResolved, System.Action<System.Exception> onRejected)
- public RSG.IPromise<ConvertedT> Then<ConvertedT>(System.Func<PromisedT, RSG.IPromise<ConvertedT>> onResolved, System.Func<System.Exception, RSG.IPromise<ConvertedT>> onRejected, System.Action<float> onProgress)
- public RSG.IPromise Then(System.Func<PromisedT, RSG.IPromise> onResolved, System.Action<System.Exception> onRejected, System.Action<float> onProgress)
- public RSG.IPromise Then(System.Action<PromisedT> onResolved, System.Action<System.Exception> onRejected, System.Action<float> onProgress)
- public RSG.IPromise<ConvertedT> Then<ConvertedT>(System.Func<PromisedT, ConvertedT> transform)
- public RSG.IPromise<System.Collections.Generic.IEnumerable<ConvertedT>> ThenAll<ConvertedT>(System.Func<PromisedT, System.Collections.Generic.IEnumerable<RSG.IPromise<ConvertedT>>> chain)
- public RSG.IPromise ThenAll(System.Func<PromisedT, System.Collections.Generic.IEnumerable<RSG.IPromise>> chain)
- public RSG.IPromise<ConvertedT> ThenRace<ConvertedT>(System.Func<PromisedT, System.Collections.Generic.IEnumerable<RSG.IPromise<ConvertedT>>> chain)
- public RSG.IPromise ThenRace(System.Func<PromisedT, System.Collections.Generic.IEnumerable<RSG.IPromise>> chain)
- public RSG.IPromise<PromisedT> WithName(string name)

### public struct RSG.RejectHandler

#### Fields
- public System.Action<System.Exception> callback
- public RSG.IRejectable rejectable

### public struct RSG.Promise.ResolveHandler

#### Fields
- public System.Action callback
- public RSG.IRejectable rejectable

### public struct RSG.TimeData

#### Fields
- public float deltaTime
- public float elapsedTime
- public int elapsedUpdates

### public class RSG.Tuple

#### Constructors
- public Tuple()

#### Methods
- public static RSG.Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
- public static RSG.Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
- public static RSG.Tuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4)

### public class RSG.Tuple<T1, T2>

#### Fields
- private T1 <Item1>k__BackingField
- private T2 <Item2>k__BackingField

#### Properties
- public T1 Item1 { get; private set; }
- public T2 Item2 { get; private set; }

#### Constructors
- internal Tuple<T1, T2>(T1 item1, T2 item2)

### public class RSG.Tuple<T1, T2, T3>

#### Fields
- private T1 <Item1>k__BackingField
- private T2 <Item2>k__BackingField
- private T3 <Item3>k__BackingField

#### Properties
- public T1 Item1 { get; private set; }
- public T2 Item2 { get; private set; }
- public T3 Item3 { get; private set; }

#### Constructors
- internal Tuple<T1, T2, T3>(T1 item1, T2 item2, T3 item3)

### public class RSG.Tuple<T1, T2, T3, T4>

#### Fields
- private T1 <Item1>k__BackingField
- private T2 <Item2>k__BackingField
- private T3 <Item3>k__BackingField
- private T4 <Item4>k__BackingField

#### Properties
- public T1 Item1 { get; private set; }
- public T2 Item2 { get; private set; }
- public T3 Item3 { get; private set; }
- public T4 Item4 { get; private set; }

#### Constructors
- internal Tuple<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4)

## Namespace: RSG.Exceptions

### public class RSG.Exceptions.PromiseException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public PromiseException()
- public PromiseException(string message)
- public PromiseException(string message, System.Exception inner)

### public class RSG.Exceptions.PromiseStateException
- Base: RSG.Exceptions.PromiseException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public PromiseStateException()
- public PromiseStateException(string message)
- public PromiseStateException(string message, System.Exception inner)

## Namespace: RSG.Promises

### private class RSG.Promises.EnumerableExt.<FromItems>d__2<T>
- Interfaces: System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private T <>2__current
- public T[] <>3__items
- private T[] <>7__wrap1
- private int <>7__wrap2
- private int <>l__initialThreadId
- private T[] items

#### Properties
- private T System.Collections.Generic.IEnumerator<T>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public EnumerableExt.<FromItems>d__2<T>(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### public static class RSG.Promises.EnumerableExt

#### Methods
- public static void Each<T>(System.Collections.Generic.IEnumerable<T> source, System.Action<T> fn)
- public static void Each<T>(System.Collections.Generic.IEnumerable<T> source, System.Action<T, int> fn)
- public static System.Collections.Generic.IEnumerable<T> FromItems<T>(params T[] items)

