# Assembly: UnityPools
- Path: tools/WorldBox.Managed/UnityPools.dll
- Types: 10

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=123 11051652AC0911B29DD1F1B6880A030BDD9F4AA12D21C278F8CD0B6F92B5BD76
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=263 914663B8763F94CFA68DA4406B10D388439AB28544DED73F19F1A601057657B8

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

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=123

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=263

## Namespace: UnityPools

### private class UnityPools.UnsafeCollectionPool<TCollection, TItem>.<>c<TCollection, TItem>

#### Fields
- public static readonly UnityPools.UnsafeCollectionPool<TCollection, TItem>.<>c<TCollection, TItem> <>9

#### Constructors
- private static UnsafeCollectionPool<TCollection, TItem>.<>c<TCollection, TItem>()
- public UnsafeCollectionPool<TCollection, TItem>.<>c<TCollection, TItem>()

#### Methods
- internal TCollection <.cctor>b__5_0()
- internal void <.cctor>b__5_1(TCollection l)

### public class UnityPools.DictionaryPool<TKey, TValue>
- Base: UnityPools.UnsafeCollectionPool<System.Collections.Generic.Dictionary<TKey, TValue>, System.Collections.Generic.KeyValuePair<TKey, TValue>>

#### Constructors
- public DictionaryPool<TKey, TValue>()

### public class UnityPools.HashSetPool<T>
- Base: UnityPools.UnsafeCollectionPool<System.Collections.Generic.HashSet<T>, T>

#### Constructors
- public HashSetPool<T>()

### public class UnityPools.UnsafeCollectionPool<TCollection, TItem>

#### Fields
- internal static readonly UnityEngine.Pool.ObjectPool<TCollection> s_Pool

#### Constructors
- public UnsafeCollectionPool<TCollection, TItem>()
- private static UnsafeCollectionPool<TCollection, TItem>()

#### Methods
- public static TCollection Get()
- public static UnityEngine.Pool.PooledObject<TCollection> Get(out TCollection value)
- public static void Release(TCollection toRelease)

### public class UnityPools.UnsafeListPool<T>
- Base: UnityPools.UnsafeCollectionPool<System.Collections.Generic.List<T>, T>

#### Constructors
- public UnsafeListPool<T>()

