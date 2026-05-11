# Assembly: NeoModLoader
- Path: tools/WorldBox.Managed/NeoModLoader.dll
- Types: 336

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 0A366DECC04BD06780381606B6B7F3719C3B4A4B09FF159559403DE0CB20A719
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 0EDD7184B7F467EE54B4081D81E10A29AF4EEF0B88AA86661C09F3643ACE8BE1
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 4163C618F140D5A595A943F87788E663A02F086F30B667C206A4297DCC1B3F99

#### Methods
- internal static uint ComputeStringHash(string s)
- internal static void ThrowInvalidOperationException()

### internal struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16

### internal struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6

## Namespace: BepInEx

### public class BepInEx.BaseUnityPlugin
- Base: UnityEngine.MonoBehaviour

#### Constructors
- protected BaseUnityPlugin()

### public class BepInEx.BepInPlugin
- Base: System.Attribute

#### Constructors
- public BepInPlugin(string id, string name, string version)

## Namespace: Microsoft.CodeAnalysis

### internal class Microsoft.CodeAnalysis.EmbeddedAttribute
- Base: System.Attribute

#### Constructors
- public EmbeddedAttribute()

## Namespace: ModDeclaration

### public class ModDeclaration.Info

#### Fields
- public readonly string Author
- public static readonly string DataPath
- public readonly string Description
- public readonly string IconPath
- public static readonly string ModsPath
- public readonly string Name
- public static readonly string NCMSModsPath
- public static readonly string NCMSPath
- public readonly string Path
- public readonly string Version

#### Constructors
- private static Info()
- internal Info(NCMS.NCMod mod)

## Namespace: NCMS

### public class NCMS.Core

#### Fields
- public static string AssembliesPath
- public static string CorePath
- public static string ManagedPath
- public static string ModsPath
- public static string NCMSModsPath
- public static string NCMSPath
- public static string TempPath
- public static string WBGamePath

#### Constructors
- public Core()
- private static Core()

### public class NCMS.ModEntry
- Base: System.Attribute

#### Constructors
- public ModEntry()

### public class NCMS.ModLoader

#### Fields
- public static System.Collections.Generic.List<NCMS.NCMod> Mods

#### Constructors
- public ModLoader()

### public class NCMS.NCMod

#### Fields
- public string author
- public string description
- public string iconPath
- public string name
- public string path
- public int targetGameBuild
- public string version

#### Constructors
- public NCMod()

### public class NCMS.WorldBoxMod

#### Constructors
- public WorldBoxMod()

#### Methods
- private void Update()

## Namespace: NCMS.Extensions

### public static class NCMS.Extensions.DictionaryRange

#### Methods
- public static void AddRange<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> dic, System.Collections.Generic.IDictionary<TKey, TValue> dicToAdd)
- public static void AddRangeNewOnly<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> dic, System.Collections.Generic.IDictionary<TKey, TValue> dicToAdd)
- public static void AddRangeOverride<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> dic, System.Collections.Generic.IDictionary<TKey, TValue> dicToAdd)
- public static bool ContainsKeys<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> dic, System.Collections.Generic.IEnumerable<TKey> keys)
- public static void ForEach<T>(System.Collections.Generic.IEnumerable<T> source, System.Action<T> action)
- public static void ForEachOrBreak<T>(System.Collections.Generic.IEnumerable<T> source, System.Func<T, bool> func)

## Namespace: NCMS.Utils

### private class NCMS.Utils.GameObjects.<>c__DisplayClass0_0

#### Fields
- public string Name

#### Constructors
- public GameObjects.<>c__DisplayClass0_0()

#### Methods
- internal bool <FindEvenInactive>b__0(UnityEngine.GameObject obj)

### private class NCMS.Utils.PowerButtons.<>c__DisplayClass3_0

#### Fields
- public string name

#### Constructors
- public PowerButtons.<>c__DisplayClass3_0()

#### Methods
- internal void <CreateButton>b__0()

### public enum NCMS.Utils.ButtonType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Click = 0
- GodPower = 1
- Toggle = 2

### public class NCMS.Utils.GameObjects

#### Constructors
- public GameObjects()

#### Methods
- public static UnityEngine.GameObject FindEvenInactive(string Name)

### public class NCMS.Utils.Localization

#### Constructors
- public Localization()

#### Methods
- public static void Add(string key, string value)
- public static void addLocalization(string key, string value)
- public static void AddOrSet(string key, string value)
- public static string Get(string key)
- public static string getLocalization(string key)
- public static void Set(string key, string value)
- public static void setLocalization(string key, string value)

### public class NCMS.Utils.PowerButtons

#### Fields
- public static System.Collections.Generic.Dictionary<string, PowerButton> CustomButtons
- public static System.Collections.Generic.Dictionary<string, bool> ToggleValues
- private static System.Collections.Generic.Dictionary<string, PowerButton> toggle_buttons

#### Constructors
- public PowerButtons()
- private static PowerButtons()

#### Methods
- public static void AddButtonToTab(PowerButton button, NCMS.Utils.PowerTab tab, UnityEngine.Vector2 position)
- public static PowerButton CreateButton(string name, UnityEngine.Sprite sprite, string title, string description, UnityEngine.Vector2 position, NCMS.Utils.ButtonType type = Click, UnityEngine.Transform parent = null, UnityEngine.Events.UnityAction call = null)
- public static UnityEngine.UI.Button CreateTextButton(string name, string text, UnityEngine.Vector2 position, UnityEngine.Color color, UnityEngine.Transform parent = null, UnityEngine.Events.UnityAction callback = null)
- public static bool GetToggleValue(string name)
- public static void ToggleButton(string name)

### public enum NCMS.Utils.PowerTab
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Bombs = 5
- Creatures = 3
- Drawing = 1
- Kingdoms = 2
- Main = 0
- Nature = 4
- Other = 6

### public class NCMS.Utils.ResourcesPatch

#### Fields
- internal static System.Collections.Generic.Dictionary<string, UnityEngine.Object> modsResources
- internal static System.Collections.Generic.Dictionary<string, UnityEngine.Object> modsResourcesReplace

#### Constructors
- public ResourcesPatch()
- private static ResourcesPatch()

### public class NCMS.Utils.Sprites

#### Constructors
- public Sprites()

#### Methods
- public static UnityEngine.Sprite LoadSprite(string path, float offsetX = 0, float offsetY = 0)

### public class NCMS.Utils.Windows

#### Fields
- public static System.Collections.Generic.Dictionary<string, ScrollWindow> AllWindows

#### Constructors
- public Windows()

#### Methods
- public static ScrollWindow CreateNewWindow(string pWindowID, string pWindowTitle)
- public static ScrollWindow GetWindow(string pWindowID)
- internal static void init()
- public static void ShowWindow(string pWindowID)

## Namespace: NeoModLoader

### private class NeoModLoader.WorldBoxMod.<>c

#### Fields
- public static readonly NeoModLoader.WorldBoxMod.<>c <>9
- public static System.Func<NeoModLoader.api.IMod, bool> <>9__10_7
- public static System.Func<NeoModLoader.api.IMod, bool> <>9__10_9

#### Constructors
- private static WorldBoxMod.<>c()
- public WorldBoxMod.<>c()

#### Methods
- internal bool <Update>b__10_7(NeoModLoader.api.IMod mod)
- internal bool <Update>b__10_9(NeoModLoader.api.IMod mod)

### private class NeoModLoader.WorldBoxMod.<>c__DisplayClass10_0

#### Fields
- public NeoModLoader.WorldBoxMod <>4__this
- public MapLoaderAction <>9__4
- public System.Collections.Generic.List<NeoModLoader.utils.ModDependencyNode> mod_nodes

#### Constructors
- public WorldBoxMod.<>c__DisplayClass10_0()

#### Methods
- internal void <Update>b__0()
- internal void <Update>b__1()
- internal void <Update>b__2()
- internal void <Update>b__4()

### private class NeoModLoader.WorldBoxMod.<>c__DisplayClass10_1

#### Fields
- public NeoModLoader.utils.Builders.MasterBuilder Builder
- public System.Collections.Generic.List<NeoModLoader.api.ModDeclare> mods_to_load

#### Constructors
- public WorldBoxMod.<>c__DisplayClass10_1()

#### Methods
- internal void <Update>b__3()

### private class NeoModLoader.WorldBoxMod.<>c__DisplayClass10_2

#### Fields
- public NeoModLoader.WorldBoxMod.<>c__DisplayClass10_1 CS$<>8__locals1
- public NeoModLoader.utils.ModDependencyNode mod

#### Constructors
- public WorldBoxMod.<>c__DisplayClass10_2()

#### Methods
- internal void <Update>b__5()

### private class NeoModLoader.WorldBoxMod.<>c__DisplayClass10_3

#### Fields
- public NeoModLoader.WorldBoxMod.<>c__DisplayClass10_1 CS$<>8__locals2
- public NeoModLoader.utils.ModDependencyNode mod

#### Constructors
- public WorldBoxMod.<>c__DisplayClass10_3()

#### Methods
- internal void <Update>b__6()

### private class NeoModLoader.WorldBoxMod.<>c__DisplayClass10_4

#### Fields
- public System.Collections.Generic.Dictionary<NeoModLoader.api.IMod, bool> successfulInit

#### Constructors
- public WorldBoxMod.<>c__DisplayClass10_4()

### private class NeoModLoader.WorldBoxMod.<>c__DisplayClass10_5

#### Fields
- public NeoModLoader.WorldBoxMod.<>c__DisplayClass10_4 CS$<>8__locals3
- public NeoModLoader.api.IMod mod

#### Constructors
- public WorldBoxMod.<>c__DisplayClass10_5()

#### Methods
- internal void <Update>b__8()

### private class NeoModLoader.WorldBoxMod.<>c__DisplayClass10_6

#### Fields
- public NeoModLoader.WorldBoxMod.<>c__DisplayClass10_4 CS$<>8__locals4
- public NeoModLoader.api.IMod mod

#### Constructors
- public WorldBoxMod.<>c__DisplayClass10_6()

#### Methods
- internal void <Update>b__10()

### private static class NeoModLoader.WorldBoxMod.<>O

#### Fields
- public static MapLoaderAction <0>__CheckExternalModInstall

### public class NeoModLoader.WorldBoxMod
- Base: UnityEngine.MonoBehaviour

#### Fields
- internal static System.Collections.Generic.Dictionary<NeoModLoader.api.ModDeclare, NeoModLoader.api.ModState> AllRecognizedMods
- internal static UnityEngine.Transform InactiveTransform
- private bool initialized
- private bool initialized_successfully
- public static System.Collections.Generic.List<NeoModLoader.api.IMod> LoadedMods
- internal static System.Reflection.Assembly NeoModLoaderAssembly
- internal static UnityEngine.Transform Transform

#### Constructors
- public WorldBoxMod()
- private static WorldBoxMod()

#### Methods
- internal static void <fileSystemInitialize>g__extractAssemblies|12_0()
- private void fileSystemInitialize()
- private static System.Reflection.Assembly LoadFrom(string path)
- private void LoadLocales()
- private void Start()
- private static void UnityExplorerFix()
- private void Update()

## Namespace: NeoModLoader.api

### private class NeoModLoader.api.ModDeclareExtensions.<>c

#### Fields
- public static readonly NeoModLoader.api.ModDeclareExtensions.<>c <>9
- public static System.Func<System.Reflection.Module, System.Collections.Generic.IEnumerable<System.Type>> <>9__1_1
- public static System.Func<System.Type, bool> <>9__1_2
- public static System.Func<char, bool> <>9__1_5

#### Constructors
- private static ModDeclareExtensions.<>c()
- public ModDeclareExtensions.<>c()

#### Methods
- internal System.Collections.Generic.IEnumerable<System.Type> <TryGetDeclaration>b__1_1(System.Reflection.Module m)
- internal bool <TryGetDeclaration>b__1_2(System.Type t)
- internal bool <TryGetDeclaration>b__1_5(char c)

### private class NeoModLoader.api.ModFeatureManager<TMod>.<>c<TMod>

#### Fields
- public static readonly NeoModLoader.api.ModFeatureManager<TMod>.<>c<TMod> <>9
- public static System.Func<NeoModLoader.api.IModFeature, bool> <>9__16_0
- public static System.Func<System.Reflection.Module, System.Collections.Generic.IEnumerable<System.Type>> <>9__18_0
- public static System.Func<System.Type, bool> <>9__18_1
- public static System.Func<System.Type, bool> <>9__18_2
- public static System.Func<System.Type, bool> <>9__18_3
- public static System.Func<System.Type, System.ValueTuple<System.Type, System.Reflection.ConstructorInfo>> <>9__18_4
- public static System.Func<System.Reflection.ConstructorInfo, bool> <>9__18_5
- public static System.Func<System.Type, bool> <>9__19_0
- public static System.Func<System.Type, string> <>9__19_1
- public static System.Func<System.Type, bool> <>9__19_2
- public static System.Func<System.Type, string> <>9__19_3
- public static System.Func<System.Type, string> <>9__21_1

#### Constructors
- private static ModFeatureManager<TMod>.<>c<TMod>()
- public ModFeatureManager<TMod>.<>c<TMod>()

#### Methods
- internal System.Collections.Generic.IEnumerable<System.Type> <FindAndInstantiateModFeatures>b__18_0(System.Reflection.Module m)
- internal bool <FindAndInstantiateModFeatures>b__18_1(System.Type t)
- internal bool <FindAndInstantiateModFeatures>b__18_2(System.Type ft)
- internal bool <FindAndInstantiateModFeatures>b__18_3(System.Type ft)
- internal System.ValueTuple<System.Type, System.Reflection.ConstructorInfo> <FindAndInstantiateModFeatures>b__18_4(System.Type featureType)
- internal bool <FindAndInstantiateModFeatures>b__18_5(System.Reflection.ConstructorInfo constructor)
- internal bool <InstantiateModFeature>b__19_0(System.Type requiredFeature)
- internal string <InstantiateModFeature>b__19_1(System.Type type)
- internal bool <InstantiateModFeature>b__19_2(System.Type optionalFeature)
- internal string <InstantiateModFeature>b__19_3(System.Type type)
- internal bool <PostInit>b__16_0(NeoModLoader.api.IModFeature feature)
- internal string <SafePerformActionOnFeature>b__21_1(System.Type type)

### private class NeoModLoader.api.ModFeatureManager<TMod>.<>c__DisplayClass10_0<TMod>

#### Fields
- public System.Type featureType

#### Constructors
- public ModFeatureManager<TMod>.<>c__DisplayClass10_0<TMod>()

#### Methods
- internal bool <GetFeature>b__0(NeoModLoader.api.IModFeature feature)

### private class NeoModLoader.api.ModDeclareExtensions.<>c__DisplayClass1_0

#### Fields
- public System.Func<string, bool> <>9__4
- public System.Reflection.Assembly pModAssembly

#### Constructors
- public ModDeclareExtensions.<>c__DisplayClass1_0()

#### Methods
- internal bool <TryGetDeclaration>b__4(string possible_file)

### private class NeoModLoader.api.ModDeclareExtensions.<>c__DisplayClass1_1

#### Fields
- public NeoModLoader.api.ModDeclare mod

#### Constructors
- public ModDeclareExtensions.<>c__DisplayClass1_1()

#### Methods
- internal bool <TryGetDeclaration>b__0(NeoModLoader.api.IMod m)

### private class NeoModLoader.api.ModDeclareExtensions.<>c__DisplayClass1_2

#### Fields
- public NeoModLoader.api.IMod modObj

#### Constructors
- public ModDeclareExtensions.<>c__DisplayClass1_2()

#### Methods
- internal bool <TryGetDeclaration>b__3(System.Type modClass)

### private class NeoModLoader.api.ModFeatureManager<TMod>.<>c__DisplayClass20_0<TMod>

#### Fields
- public NeoModLoader.api.ModFeatureManager<TMod> <>4__this
- public NeoModLoader.api.IModFeature modFeature

#### Constructors
- public ModFeatureManager<TMod>.<>c__DisplayClass20_0<TMod>()

#### Methods
- internal bool <InitFeature>b__0(NeoModLoader.api.IModFeature feature)

### private class NeoModLoader.api.ModConfig.<>c__DisplayClass5_0

#### Fields
- public System.Func<string, bool> <>9__0
- public System.Collections.Generic.Dictionary<string, NeoModLoader.api.ModConfigItem> default_group

#### Constructors
- public ModConfig.<>c__DisplayClass5_0()

#### Methods
- internal bool <MergeWith>b__0(string item)

### private class NeoModLoader.api.ModConfig.<>c__DisplayClass5_1

#### Fields
- public System.Func<string, bool> <>9__1
- public System.Func<string, bool> <>9__2
- public System.Collections.Generic.Dictionary<string, NeoModLoader.api.ModConfigItem> group

#### Constructors
- public ModConfig.<>c__DisplayClass5_1()

#### Methods
- internal bool <MergeWith>b__1(string item)
- internal bool <MergeWith>b__2(string item)

### private class NeoModLoader.api.ModFeatureManager<TMod>.<>c__DisplayClass8_0<TMod>

#### Fields
- public System.Type featureType

#### Constructors
- public ModFeatureManager<TMod>.<>c__DisplayClass8_0<TMod>()

#### Methods
- internal bool <IsFeatureLoaded>b__0(NeoModLoader.api.IModFeature feature)

### public class NeoModLoader.api.AbstractListWindowItem<TItem>
- Base: UnityEngine.MonoBehaviour

#### Constructors
- protected AbstractListWindowItem<TItem>()

#### Methods
- public abstract void Setup(TItem pObject)

### public class NeoModLoader.api.AbstractListWindow<T, TItem>
- Base: NeoModLoader.api.AbstractWindow<T>

#### Fields
- protected System.Collections.Generic.Dictionary<TItem, NeoModLoader.api.AbstractListWindowItem<TItem>> ItemMap
- protected static NeoModLoader.api.AbstractListWindowItem<TItem> ItemPrefab
- private ObjectPoolGenericMono<NeoModLoader.api.AbstractListWindowItem<TItem>> _pool

#### Constructors
- protected AbstractListWindow<T, TItem>()

#### Methods
- protected virtual void AddItemToList(TItem item)
- protected virtual void ClearList()
- public static T CreateAndInit(string pWindowId)
- protected abstract NeoModLoader.api.AbstractListWindowItem<TItem> CreateItemPrefab()
- protected virtual void RemoveItemFromList(TItem item)

### public class NeoModLoader.api.AbstractWideWindow<T>
- Base: NeoModLoader.api.AbstractWindow<T>

#### Constructors
- protected AbstractWideWindow<T>()

#### Methods
- public static T CreateAndInit(string pWindowId, UnityEngine.Vector2 pSize = null)
- public void SetSize(UnityEngine.Vector2 pSize)

### public class NeoModLoader.api.AbstractWindow<T>
- Base: UnityEngine.MonoBehaviour

#### Fields
- private UnityEngine.Transform <BackgroundTransform>k__BackingField
- private UnityEngine.Transform <ContentTransform>k__BackingField
- private static T <Instance>k__BackingField
- private static string <WindowId>k__BackingField
- protected bool Initialized
- protected bool IsFirstOpen
- protected bool IsOpened

#### Properties
- protected UnityEngine.Transform BackgroundTransform { get; set; }
- protected UnityEngine.Transform ContentTransform { get; set; }
- public static T Instance { get; protected set; }
- public static string WindowId { get; protected set; }

#### Constructors
- protected AbstractWindow<T>()

#### Methods
- public static T CreateAndInit(string pWindowId)
- protected abstract void Init()
- private void OnDisable()
- private void OnEnable()
- public virtual void OnFirstEnable()
- public virtual void OnNormalDisable()
- public virtual void OnNormalEnable()

### public class NeoModLoader.api.AttachedModComponent
- Base: UnityEngine.MonoBehaviour
- Interfaces: NeoModLoader.api.IMod

#### Fields
- private NeoModLoader.api.ModDeclare _declare

#### Constructors
- public AttachedModComponent()

#### Methods
- public NeoModLoader.api.ModDeclare GetDeclaration()
- public UnityEngine.GameObject GetGameObject()
- public string GetUrl()
- public void OnLoad(NeoModLoader.api.ModDeclare pModDecl, UnityEngine.GameObject pGameObject)

### public class NeoModLoader.api.BasicMod<T>
- Base: UnityEngine.MonoBehaviour
- Interfaces: NeoModLoader.api.IMod, NeoModLoader.api.ILocalizable, NeoModLoader.api.IConfigurable, NeoModLoader.api.IFeatureLoadManaged, NeoModLoader.api.IStagedLoad

#### Fields
- private static T <Instance>k__BackingField
- private NeoModLoader.api.IModFeatureManager <ModFeatureManager>k__BackingField
- private NeoModLoader.api.ModConfig _config
- private NeoModLoader.api.ModDeclare _declare
- private bool _isLoaded
- private UnityEngine.Transform _prefab_library

#### Properties
- public static T I { get; }
- public static T Instance { get; private set; }
- public NeoModLoader.api.IModFeatureManager ModFeatureManager { get; private set; }
- public UnityEngine.Transform PrefabLibrary { get; }

#### Constructors
- protected BasicMod<T>()

#### Methods
- public NeoModLoader.api.ModConfig GetConfig()
- public NeoModLoader.api.ModDeclare GetDeclaration()
- public UnityEngine.GameObject GetGameObject()
- public string GetLocaleFilesDirectory(NeoModLoader.api.ModDeclare pModDeclare)
- public virtual string GetUrl()
- public virtual void Init()
- private NeoModLoader.api.ModConfig LoadConfig()
- public static void LogError(string message)
- public static void LogInfo(string message)
- public static void LogWarning(string message)
- public static UnityEngine.GameObject NewPrefab(string name)
- public void OnLoad(NeoModLoader.api.ModDeclare pModDecl, UnityEngine.GameObject pGameObject)
- protected abstract void OnModLoad()
- public virtual void PostInit()

### public class NeoModLoader.api.BepinexMod
- Base: NeoModLoader.api.VirtualMod
- Interfaces: NeoModLoader.api.IMod

#### Fields
- private UnityEngine.MonoBehaviour _modComponent

#### Constructors
- public BepinexMod()

#### Methods
- public UnityEngine.MonoBehaviour GetModComponent()
- public void OnLoad(NeoModLoader.api.ModDeclare pModDecl, UnityEngine.MonoBehaviour pModComponent)

### public enum NeoModLoader.api.ConfigItemType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- INT_SLIDER = 4
- SELECT = 3
- SLIDER = 1
- SWITCH = 0
- TEXT = 2

### public class NeoModLoader.api.FeatureLoadException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public FeatureLoadException(string message)
- protected FeatureLoadException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
- public FeatureLoadException(string message, System.Exception innerException)

### private class NeoModLoader.api.ModFeatureManager<TMod>.FeatureLoadPathNode<TMod>

#### Fields
- private NeoModLoader.api.ModFeatureManager<TMod>.FeatureLoadPathNode<TMod> <DependencyFeature>k__BackingField
- private NeoModLoader.api.ModFeatureManager<TMod>.FeatureLoadPathNode<TMod> <DependentFeature>k__BackingField
- private readonly NeoModLoader.api.IModFeature <ModFeature>k__BackingField

#### Properties
- internal NeoModLoader.api.ModFeatureManager<TMod>.FeatureLoadPathNode<TMod> DependencyFeature { get; private set; }
- internal NeoModLoader.api.ModFeatureManager<TMod>.FeatureLoadPathNode<TMod> DependentFeature { get; private set; }
- internal NeoModLoader.api.IModFeature ModFeature { get; }

#### Constructors
- internal ModFeatureManager<TMod>.FeatureLoadPathNode<TMod>(NeoModLoader.api.IModFeature modFeature)

#### Methods
- internal static NeoModLoader.api.ModFeatureManager<TMod>.FeatureLoadPathNode<TMod> CreateFeatureLoadPath(NeoModLoader.api.ModFeatureManager<TMod>.FeatureTreeNode<TMod>[] featureTrees)

### private class NeoModLoader.api.ModFeatureManager<TMod>.FeatureTreeNode<TMod>

#### Fields
- private readonly System.Collections.Generic.List<NeoModLoader.api.ModFeatureManager<TMod>.FeatureTreeNode<TMod>> <DependentFeatures>k__BackingField
- private readonly NeoModLoader.api.IModFeature <ModFeature>k__BackingField

#### Properties
- internal System.Collections.Generic.List<NeoModLoader.api.ModFeatureManager<TMod>.FeatureTreeNode<TMod>> DependentFeatures { get; }
- internal NeoModLoader.api.IModFeature ModFeature { get; }

#### Constructors
- internal ModFeatureManager<TMod>.FeatureTreeNode<TMod>(NeoModLoader.api.IModFeature modFeature)

#### Methods
- internal static NeoModLoader.api.ModFeatureManager<TMod>.FeatureTreeNode<TMod>[] CreateFeatureTrees(NeoModLoader.api.IModFeature[] features)

### public interface NeoModLoader.api.IConfigurable

#### Methods
- public NeoModLoader.api.ModConfig GetConfig()

### public interface NeoModLoader.api.ICsvSepCustomized

#### Methods
- public char GetCsvSeparator()

### public interface NeoModLoader.api.IDecoratePanel

#### Methods
- public void DecoratePanel(NeoModLoader.ui.prefabs.ModInfoPanel pPanel)

### public interface NeoModLoader.api.IFeatureLoadManaged

#### Properties
- public NeoModLoader.api.IModFeatureManager ModFeatureManager { get; }

### public interface NeoModLoader.api.ILocalizable

#### Methods
- public string GetLocaleFilesDirectory(NeoModLoader.api.ModDeclare pModDeclare)

### public interface NeoModLoader.api.IMod

#### Methods
- public NeoModLoader.api.ModDeclare GetDeclaration()
- public UnityEngine.GameObject GetGameObject()
- public string GetUrl()
- public void OnLoad(NeoModLoader.api.ModDeclare pModDecl, UnityEngine.GameObject pGameObject)

### public interface NeoModLoader.api.IModFeature

#### Properties
- public NeoModLoader.api.IModFeatureManager ModFeatureManager { get; set; }
- public NeoModLoader.api.ModFeatureRequirementList OptionalModFeatures { get; }
- public NeoModLoader.api.ModFeatureRequirementList RequiredModFeatures { get; }

#### Methods
- public bool Init()
- public bool PostInit()

### public interface NeoModLoader.api.IModFeatureManager
- Interfaces: NeoModLoader.api.IStagedLoad

#### Methods
- public T GetFeature<T>(NeoModLoader.api.IModFeature askingModFeature)
- public void InstantiateFeatures()
- public bool IsFeatureLoaded<T>()
- public bool TryGetFeature<T>(NeoModLoader.api.IModFeature askingModFeature, out T feature)

### public interface NeoModLoader.api.IReloadable

#### Methods
- public void Reload()

### public interface NeoModLoader.api.IStagedLoad

#### Methods
- public void Init()
- public void PostInit()

### public interface NeoModLoader.api.IUnloadable

#### Methods
- public void OnUnload()

### internal class NeoModLoader.api.ModCompilationCache

#### Fields
- public System.Collections.Generic.List<string> dependencies
- public bool disabled
- public string mod_id
- public System.Collections.Generic.List<string> optional_dependencies
- public long timestamp

#### Constructors
- private ModCompilationCache()
- public ModCompilationCache(string pModID)
- public ModCompilationCache(NeoModLoader.api.ModDeclare pModDeclare, System.Collections.Generic.List<string> pDependencies, System.Collections.Generic.List<string> pOptionalDependencies)

### public class NeoModLoader.api.ModConfig

#### Fields
- internal System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, NeoModLoader.api.ModConfigItem>> _config
- private readonly string _path

#### Properties
- public System.Collections.Generic.Dictionary<string, NeoModLoader.api.ModConfigItem> Item { get; }

#### Constructors
- public ModConfig(string path, bool pIsPersistent = false)

#### Methods
- public NeoModLoader.api.ModConfigItem AddConfigItem(string pGroupId, string pId, NeoModLoader.api.ConfigItemType pType, object pDefaultValue, string pIconPath = "", string pCallback = "")
- public NeoModLoader.api.ModConfigItem AddConfigSliderItemWithIntRange(string pGroupId, string pId, int pDefaultValue, int pMinValue, int pMaxValue, string pIconPath = "", string pCallback = "")
- public NeoModLoader.api.ModConfigItem AddConfigSliderItemWithRange(string pGroupId, string pId, float pDefaultValue, float pMinValue, float pMaxValue, string pIconPath = "", string pCallback = "")
- public void CreateGroup(string pId)
- public void MergeWith(NeoModLoader.api.ModConfig pDefaultConfig)
- public void Save(string path = null)

### public class NeoModLoader.api.ModConfigItem

#### Fields
- private bool <BoolVal>k__BackingField
- private string <CallBack>k__BackingField
- private float <FloatVal>k__BackingField
- private string <IconPath>k__BackingField
- private string <Id>k__BackingField
- private int <IntVal>k__BackingField
- private float <MaxFloatVal>k__BackingField
- private int <MaxIntVal>k__BackingField
- private float <MinFloatVal>k__BackingField
- private int <MinIntVal>k__BackingField
- private string <TextVal>k__BackingField
- private NeoModLoader.api.ConfigItemType <Type>k__BackingField
- private System.Reflection.MethodInfo callback

#### Properties
- public bool BoolVal { get; internal set; }
- public string CallBack { get; internal set; }
- public float FloatVal { get; internal set; }
- public string IconPath { get; internal set; }
- public string Id { get; internal set; }
- public int IntVal { get; internal set; }
- public float MaxFloatVal { get; internal set; }
- public int MaxIntVal { get; internal set; }
- public float MinFloatVal { get; internal set; }
- public int MinIntVal { get; internal set; }
- public string TextVal { get; internal set; }
- public NeoModLoader.api.ConfigItemType Type { get; internal set; }

#### Constructors
- public ModConfigItem()

#### Methods
- public object GetValue()
- public void SetFloatRange(float pMin, float pMax)
- public void SetIntRange(int pMin, int pMax)
- public void SetValue(object val, bool pSkipCallback = false)

### public class NeoModLoader.api.ModDeclare

#### Fields
- private string <Author>k__BackingField
- private string[] <Dependencies>k__BackingField
- private string <Description>k__BackingField
- private readonly System.Text.StringBuilder <FailReason>k__BackingField
- private string <FolderPath>k__BackingField
- private string <IconPath>k__BackingField
- private string[] <IncompatibleWith>k__BackingField
- private bool <IsNCMSMod>k__BackingField
- private bool <IsWorkshopLoaded>k__BackingField
- private NeoModLoader.api.ModTypeEnum <ModType>k__BackingField
- private string <Name>k__BackingField
- private string[] <OptionalDependencies>k__BackingField
- private string <RepoUrl>k__BackingField
- private int <TargetGameBuild>k__BackingField
- private string <UID>k__BackingField
- private bool <UsePublicizedAssembly>k__BackingField
- private string <Version>k__BackingField

#### Properties
- public string Author { get; private set; }
- public string[] Dependencies { get; private set; }
- public string Description { get; private set; }
- public System.Text.StringBuilder FailReason { get; }
- public string FolderPath { get; private set; }
- public string IconPath { get; private set; }
- public string[] IncompatibleWith { get; private set; }
- public bool IsNCMSMod { get; internal set; }
- public bool IsWorkshopLoaded { get; internal set; }
- public NeoModLoader.api.ModTypeEnum ModType { get; private set; }
- public string Name { get; private set; }
- public string[] OptionalDependencies { get; private set; }
- public string RepoUrl { get; private set; }
- public int TargetGameBuild { get; private set; }
- public string UID { get; private set; }
- public bool UsePublicizedAssembly { get; private set; }
- public string Version { get; private set; }

#### Constructors
- private ModDeclare()
- public ModDeclare(string pFilePath)
- public ModDeclare(string pName, string pAuthor, string pIconPath, string pVersion, string pDescription, string pFolderPath, string[] pDependencies, string[] pOptionalDependencies, string[] pIncompatibleWith, bool pIsWorkshopLoaded = false)

#### Methods
- internal void SetIconPath(string iconPath)
- internal void SetModType(NeoModLoader.api.ModTypeEnum modType)
- internal void SetRepoUrlToWorkshopPage(string id)

### public static class NeoModLoader.api.ModDeclareExtensions

#### Methods
- public static System.Version ParseVersion(NeoModLoader.api.ModDeclare pModDeclare)
- public static bool TryGetDeclaration(System.Reflection.Assembly pModAssembly, out NeoModLoader.api.ModDeclare pModDeclare)

### public class NeoModLoader.api.ModFeature
- Interfaces: NeoModLoader.api.IModFeature

#### Fields
- private NeoModLoader.api.IModFeatureManager <ModFeatureManager>k__BackingField
- private readonly NeoModLoader.api.ModFeatureRequirementList <OptionalModFeatures>k__BackingField
- private readonly NeoModLoader.api.ModFeatureRequirementList <RequiredModFeatures>k__BackingField

#### Properties
- public NeoModLoader.api.IModFeatureManager ModFeatureManager { get; set; }
- public NeoModLoader.api.ModFeatureRequirementList OptionalModFeatures { get; }
- public NeoModLoader.api.ModFeatureRequirementList RequiredModFeatures { get; }

#### Constructors
- protected ModFeature()

#### Methods
- protected T GetFeature<T>()
- public abstract bool Init()
- protected bool IsFeatureLoaded<T>()
- public virtual bool PostInit()
- protected bool TryGetFeature<T>(out T feature)

### public class NeoModLoader.api.ModFeatureManager<TMod>
- Interfaces: NeoModLoader.api.IModFeatureManager, NeoModLoader.api.IStagedLoad

#### Fields
- private NeoModLoader.api.ModFeatureManager<TMod>.FeatureLoadPathNode<TMod> _featureLoadPath
- private System.Diagnostics.StackTrace _firstInstantiationStackTrace
- private System.Diagnostics.StackTrace _firstLoadStackTrace
- private readonly System.Collections.Generic.List<NeoModLoader.api.IModFeature> _foundFeatures
- private readonly System.Collections.Generic.List<NeoModLoader.api.IModFeature> _loadedFeatures
- private readonly NeoModLoader.api.BasicMod<TMod> _mod

#### Constructors
- public ModFeatureManager<TMod>(NeoModLoader.api.BasicMod<TMod> mod)

#### Methods
- private bool <SafePerformActionOnFeature>b__21_0(System.Type requiredFeature)
- private System.Collections.Generic.List<NeoModLoader.api.IModFeature> FindAndInstantiateModFeatures()
- public T GetFeature<T>(NeoModLoader.api.IModFeature askingModFeature)
- private NeoModLoader.api.IModFeature GetFeature(System.Type featureType)
- public void Init()
- private void InitFeature(NeoModLoader.api.IModFeature modFeature)
- public void InstantiateFeatures()
- private void InstantiateModFeature(System.Type featureType, System.Reflection.ConstructorInfo instanceConstructor, System.Collections.Generic.List<NeoModLoader.api.IModFeature> features)
- public bool IsFeatureLoaded<T>()
- private bool IsFeatureLoaded(System.Type featureType)
- private static NeoModLoader.api.ModFeatureManager<TMod>.FeatureLoadPathNode<TMod> ParseModFeaturesIntoLoadPath(System.Collections.Generic.List<NeoModLoader.api.IModFeature> features)
- public void PostInit()
- private void SafePerformActionOnFeature(NeoModLoader.api.IModFeature modFeature, string actionVerb, System.Func<NeoModLoader.api.IModFeature, bool> performAction, bool log = true)
- public bool TryGetFeature<T>(NeoModLoader.api.IModFeature askingModFeature, out T feature)

### public class NeoModLoader.api.ModFeatureRequirementList
- Interfaces: System.Collections.Generic.IEnumerable<System.Type>, System.Collections.IEnumerable

#### Fields
- private readonly System.Collections.Generic.List<System.Type> <RequiredFeatureList>k__BackingField

#### Properties
- private System.Collections.Generic.List<System.Type> RequiredFeatureList { get; }

#### Constructors
- public ModFeatureRequirementList(params System.Type[] types)

#### Methods
- public System.Collections.Generic.IEnumerator<System.Type> GetEnumerator()
- public static NeoModLoader.api.ModFeatureRequirementList op_Addition(NeoModLoader.api.ModFeatureRequirementList list, System.Type type)
- public static NeoModLoader.api.ModFeatureRequirementList op_Implicit(System.Collections.Generic.List<System.Type> list)
- public static System.Collections.Generic.List<System.Type> op_Implicit(NeoModLoader.api.ModFeatureRequirementList list)
- public static NeoModLoader.api.ModFeatureRequirementList op_Implicit(System.Type type)
- public static NeoModLoader.api.ModFeatureRequirementList op_Implicit(System.Type[] list)
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()

### internal enum NeoModLoader.api.ModState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DISABLED = 0
- FAILED = 2
- LOADED = 1

### public enum NeoModLoader.api.ModTypeEnum
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BEPINEX = 2
- COMPILED_NEOMOD = 1
- NEOMOD = 0
- RESOURCE_PACK = 3

### private class NeoModLoader.api.ModFeatureManager<TMod>.FeatureLoadPathNode<TMod>.PlaceholderRootModFeature<TMod>
- Base: NeoModLoader.api.ModFeature
- Interfaces: NeoModLoader.api.IModFeature

#### Constructors
- public ModFeatureManager<TMod>.FeatureLoadPathNode<TMod>.PlaceholderRootModFeature<TMod>()

#### Methods
- public override bool Init()

### public class NeoModLoader.api.VirtualMod
- Interfaces: NeoModLoader.api.IMod

#### Fields
- private UnityEngine.GameObject _boundGameObject
- private NeoModLoader.api.ModDeclare _declare

#### Constructors
- public VirtualMod()

#### Methods
- public NeoModLoader.api.ModDeclare GetDeclaration()
- public UnityEngine.GameObject GetGameObject()
- public string GetUrl()
- public void OnLoad(NeoModLoader.api.ModDeclare pModDecl, UnityEngine.GameObject pGameObject)

## Namespace: NeoModLoader.api.attributes

### public class NeoModLoader.api.attributes.ExperimentalAttribute
- Base: System.Attribute

#### Constructors
- public ExperimentalAttribute()
- public ExperimentalAttribute(string tip)

### public class NeoModLoader.api.attributes.HotfixableAttribute
- Base: System.Attribute

#### Constructors
- public HotfixableAttribute()

## Namespace: NeoModLoader.api.exceptions

### public class NeoModLoader.api.exceptions.UnrecognizableResourceFileException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public UnrecognizableResourceFileException(string path)

### public class NeoModLoader.api.exceptions.UnsupportedFileTypeException
- Base: System.IO.IOException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public UnsupportedFileTypeException(string filePath)

## Namespace: NeoModLoader.api.features

### public class NeoModLoader.api.features.ModAssetFeature<TAsset>
- Base: NeoModLoader.api.features.ModObjectFeature<TAsset>
- Interfaces: NeoModLoader.api.IModFeature

#### Properties
- protected bool AddToLibrary { get; }

#### Constructors
- protected ModAssetFeature<TAsset>()

#### Methods
- public override bool Init()

### public class NeoModLoader.api.features.ModButtonFeature<TPowersTabFeature>
- Base: NeoModLoader.api.features.ModObjectFeature<PowerButton>
- Interfaces: NeoModLoader.api.IModFeature

#### Properties
- public NeoModLoader.api.ModFeatureRequirementList RequiredModFeatures { get; }
- protected PowersTab Tab { get; }

#### Constructors
- protected ModButtonFeature<TPowersTabFeature>()

#### Methods
- public override bool Init()

### public class NeoModLoader.api.features.ModGodPowerButtonFeature<TGodPowerFeature, TPowersTabFeature>
- Base: NeoModLoader.api.features.ModButtonFeature<TPowersTabFeature>
- Interfaces: NeoModLoader.api.IModFeature

#### Properties
- public NeoModLoader.api.ModFeatureRequirementList RequiredModFeatures { get; }
- public string SpritePath { get; }

#### Constructors
- protected ModGodPowerButtonFeature<TGodPowerFeature, TPowersTabFeature>()

#### Methods
- protected override PowerButton InitObject()

### public class NeoModLoader.api.features.ModObjectFeature<TObject>
- Base: NeoModLoader.api.ModFeature
- Interfaces: NeoModLoader.api.IModFeature

#### Fields
- private TObject <Object>k__BackingField

#### Properties
- public TObject Object { get; private set; }

#### Constructors
- protected ModObjectFeature<TObject>()

#### Methods
- public override bool Init()
- protected abstract TObject InitObject()
- public static TObject op_Implicit(NeoModLoader.api.features.ModObjectFeature<TObject> feature)

### public class NeoModLoader.api.features.ModPowerTabFeature
- Base: NeoModLoader.api.features.ModObjectFeature<PowersTab>
- Interfaces: NeoModLoader.api.IModFeature

#### Constructors
- protected ModPowerTabFeature()

#### Methods
- public abstract bool PositionButton(PowerButton button)

### public class NeoModLoader.api.features.ModWindowButtonFeature<TWindowFeature, TPowersTabFeature>
- Base: NeoModLoader.api.features.ModButtonFeature<TPowersTabFeature>
- Interfaces: NeoModLoader.api.IModFeature

#### Properties
- public NeoModLoader.api.ModFeatureRequirementList RequiredModFeatures { get; }
- public string SpritePath { get; }
- protected ScrollWindow Window { get; }
- public UnityEngine.Events.UnityAction WindowOpenAction { get; }

#### Constructors
- protected ModWindowButtonFeature<TWindowFeature, TPowersTabFeature>()

#### Methods
- protected override PowerButton InitObject()

## Namespace: NeoModLoader.constants

### private static class NeoModLoader.constants.Paths.<>O

#### Fields
- public static System.Func<string, string, string> <0>__Combine

### public static class NeoModLoader.constants.CoreConstants

#### Fields
- internal static const string DefaultLocaleID
- internal static const ulong GameId
- public static const string ModName
- public static const string OrgName
- public static const string OrgURL
- public static const string RepoName
- public static const string RepoURL
- internal static const ulong WorkshopFileId

### public static class NeoModLoader.constants.Others

#### Fields
- private static bool <unity_player_enabled>k__BackingField
- internal static const long confirmed_compile_time
- internal static const string harmony_id

#### Properties
- public static bool is_editor { get; }
- public static bool unity_player_enabled { get; internal set; }

### public static class NeoModLoader.constants.Paths

#### Fields
- public static readonly string BepInExPluginsPath
- public static readonly string CommonModsWorkshopPath
- public static readonly string CompiledModsPath
- public static readonly System.Collections.Generic.HashSet<string> IgnoreSearchDirectories
- internal static readonly string LinuxSteamLocalConfigPath
- public static readonly string ManagedPath
- public static readonly string ModAssetBundleFolderName
- public static readonly string ModCompileRecordPath
- public static readonly string ModDeclarationFileName
- public static readonly string ModDefaultConfigFileName
- public static readonly string ModResourceFolderName
- public static readonly string ModsConfigPath
- public static readonly string ModsDisabledRecordPath
- public static readonly string ModsPath
- public static readonly string NativeModsPath
- public static readonly string NCMSAdditionModResourceFolderName
- public static readonly string NCMSModEmbededResourceFolderName
- public static readonly string NMLAssembliesPath
- public static readonly string NMLAutoUpdateModulePath
- public static readonly string NMLCommitPath
- public static readonly string NMLModPath
- public static readonly string NMLPath
- public static readonly string PersistentDataPath
- public static readonly string PublicizedAssemblyPath
- public static readonly string StreamingAssetsPath
- public static readonly string TabOrderRecordPath

#### Properties
- public static string GamePath { get; }

#### Constructors
- private static Paths()

#### Methods
- private static string Combine(params string[] paths)

### internal static class NeoModLoader.constants.Setting

#### Fields
- public static const string discord_auth_client_id
- public static const string github_auth_client_id

## Namespace: NeoModLoader.General

### private class NeoModLoader.General.LM.<>c

#### Fields
- public static readonly NeoModLoader.General.LM.<>c <>9
- public static System.Func<System.Collections.Generic.KeyValuePair<string, string>, System.ValueTuple<string, string>> <>9__11_0
- public static System.Func<string, bool> <>9__11_1
- public static System.Func<System.Collections.Generic.KeyValuePair<string, string>, System.ValueTuple<string, string>> <>9__12_0
- public static System.Func<string, bool> <>9__12_1
- public static System.Func<string, string, string> <>9__6_0
- public static System.Func<System.Collections.Generic.KeyValuePair<string, string>, System.ValueTuple<string, string>> <>9__7_0
- public static System.Func<System.Collections.Generic.KeyValuePair<string, string>, System.ValueTuple<string, string>> <>9__8_0

#### Constructors
- private static LM.<>c()
- public LM.<>c()

#### Methods
- internal System.ValueTuple<string, string> <ApplyLocale>b__11_0(System.Collections.Generic.KeyValuePair<string, string> pair)
- internal bool <ApplyLocale>b__11_1(string key)
- internal System.ValueTuple<string, string> <ApplyLocale>b__12_0(System.Collections.Generic.KeyValuePair<string, string> pair)
- internal bool <ApplyLocale>b__12_1(string key)
- internal System.ValueTuple<string, string> <LoadLocale>b__7_0(System.Collections.Generic.KeyValuePair<string, string> pair)
- internal System.ValueTuple<string, string> <LoadLocale>b__8_0(System.Collections.Generic.KeyValuePair<string, string> pair)
- internal string <ParseCSV>b__6_0(string current, string key)

### public static class NeoModLoader.General.LM

#### Fields
- private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> locales
- private static readonly System.Collections.Generic.Dictionary<string, string> str2esc

#### Constructors
- private static LM()

#### Methods
- public static void Add(string language, string key, string value)
- public static void AddToCurrentLocale(string key, string value)
- public static void ApplyLocale(string language, bool pUpdateTexts = true)
- public static void ApplyLocale(bool pUpdateTexts = true)
- public static string Get(string key)
- public static bool Has(string key, string lang = "")
- public static void LoadLocale(string pLanguage, System.IO.Stream pStream)
- public static void LoadLocale(string pLanguage, string pFilePath)
- public static void LoadLocales(string pFilePath, char pSep = ',')
- public static void LoadLocales(System.IO.Stream pStream, char pSep = ',')
- private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> ParseCSV(string pText, char sep)
- internal static void setLanguagePostfix(string pLanguage)

### public static class NeoModLoader.General.OT

#### Methods
- public static void InitializeCommonText(UnityEngine.UI.Text text)
- public static void InitializeNoActionVerticalLayoutGroup(UnityEngine.UI.VerticalLayoutGroup pVerticalLayoutGroup)

### public static class NeoModLoader.General.PowerButtonCreator

#### Methods
- internal static void <CreateToggleButton>g__toggleOption|3_0(string pPower)
- public static void AddButtonToTab(PowerButton button, PowersTab tab, UnityEngine.Vector2 position, System.Nullable<int> siblingIndex = null)
- public static void AddButtonToTab(PowerButton button, PowersTab tab, System.Nullable<int> siblingIndex = null)
- public static PowerButton CreateGodPowerButton(string pGodPowerId, UnityEngine.Sprite pIcon, UnityEngine.Transform pParent = null, UnityEngine.Vector2 pLocalPosition = null)
- public static PowerButton CreateSimpleButton(string pId, UnityEngine.Events.UnityAction pAction, UnityEngine.Sprite pIcon, UnityEngine.Transform pParent = null, UnityEngine.Vector2 pLocalPosition = null)
- public static PowerButton CreateToggleButton(string pGodPowerId, UnityEngine.Sprite pIcon, UnityEngine.Transform pParent = null, UnityEngine.Vector2 pLocalPosition = null, bool pNoAutoSetToggleAction = false)
- public static PowerButton CreateWindowButton(string pId, string pWindowId, UnityEngine.Sprite pIcon, UnityEngine.Transform pParent = null, UnityEngine.Vector2 pLocalPosition = null)
- public static PowersTab GetTab(string pId)

### public static class NeoModLoader.General.PowerTabNames

#### Fields
- public static const string Bombs
- public static const string Creatures
- public static const string Drawing
- public static const string Kingdoms
- public static const string Main
- public static const string Nature
- public static const string Other

#### Methods
- public static System.Collections.Generic.List<string> GetNames()

### public static class NeoModLoader.General.ResourcesFinder

#### Fields
- private static System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.Dictionary<string, UnityEngine.Object>> objects_cache

#### Constructors
- private static ResourcesFinder()

#### Methods
- public static T FindResource<T>(string name)
- public static T[] FindResources<T>(string name)

### public static class NeoModLoader.General.RF

#### Fields
- private static System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.Dictionary<string, System.Delegate>> _getter_cache
- private static System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.Dictionary<string, System.Delegate>> _method_cache
- private static System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.Dictionary<string, System.Delegate>> _setter_cache

#### Constructors
- private static RF()

#### Methods
- public static TF GetField<TF, TI>(TI obj, string name)
- public static TF GetField<TF>(object obj, string name)
- public static object GetField(object obj, string name, System.Type field_type)
- public static System.Delegate GetMethodDelegate(System.Type type, string name, bool is_static = false)
- public static TF GetStaticField<TF, TI>(string name)
- public static TF GetStaticField<TF>(string name, System.Type type)
- public static void SetField<TF, TI>(TI obj, string name, TF value)
- public static void SetStaticField<TF, TI>(string name, TF value)
- public static void SetStaticField<TF>(string name, TF value, System.Type TI)

### public static class NeoModLoader.General.WindowCreator

#### Methods
- public static ScrollWindow CreateEmptyWindow(string pWindowID, string pWindowTitleKey, string pWindowIcon = "neomodloader")
- internal static void init()

## Namespace: NeoModLoader.General.Event

### public class NeoModLoader.General.Event.AbstractHandler<THandler>

#### Fields
- private bool <enabled>k__BackingField
- private int error_hit

#### Properties
- public bool enabled { get; private set; }

#### Constructors
- protected AbstractHandler<THandler>()

#### Methods
- internal void HitException()

### public class NeoModLoader.General.Event.AbstractListener<TListener, THandler>
- Base: NeoModLoader.General.Event.BaseListener

#### Fields
- private readonly System.Collections.Generic.List<THandler> <handlers>k__BackingField
- private static TListener <instance>k__BackingField
- private bool _patched

#### Properties
- protected System.Collections.Generic.List<THandler> handlers { get; }
- protected static TListener instance { get; private set; }

#### Constructors
- public AbstractListener<TListener, THandler>()

#### Methods
- protected static void InsertCallHandleCode(System.Collections.Generic.List<HarmonyLib.CodeInstruction> codes, int pos)
- public static void RegisterHandler(THandler handler)

### public class NeoModLoader.General.Event.BaseListener

#### Constructors
- protected BaseListener()

### internal static class NeoModLoader.General.Event.ListenerManager

#### Fields
- private static readonly string ListenerNamespace
- private static readonly System.Collections.Generic.HashSet<NeoModLoader.General.Event.BaseListener> _listeners

#### Constructors
- private static ListenerManager()

#### Methods
- public static void _init()

## Namespace: NeoModLoader.General.Event.Handlers

### public class NeoModLoader.General.Event.Handlers.ActorTryToAttackHandler
- Base: NeoModLoader.General.Event.AbstractHandler<NeoModLoader.General.Event.Handlers.ActorTryToAttackHandler>

#### Constructors
- protected ActorTryToAttackHandler()

#### Methods
- public abstract void Handle(Actor pAttacker, BaseSimObject pTarget, CombatActionAsset pCombatActionAsset, AttackData pAttackData)

### public class NeoModLoader.General.Event.Handlers.AllianceCreateHandler
- Base: NeoModLoader.General.Event.AbstractHandler<NeoModLoader.General.Event.Handlers.AllianceCreateHandler>

#### Constructors
- protected AllianceCreateHandler()

#### Methods
- public abstract void Handle(Alliance pAlliance, Kingdom pKingdom, Kingdom pKingdom2)

### public class NeoModLoader.General.Event.Handlers.CityCreateHandler
- Base: NeoModLoader.General.Event.AbstractHandler<NeoModLoader.General.Event.Handlers.CityCreateHandler>

#### Constructors
- protected CityCreateHandler()

#### Methods
- public abstract void Handle(City pCity)

### public class NeoModLoader.General.Event.Handlers.ClanCreateHandler
- Base: NeoModLoader.General.Event.AbstractHandler<NeoModLoader.General.Event.Handlers.ClanCreateHandler>

#### Constructors
- protected ClanCreateHandler()

#### Methods
- public abstract void Handle(Clan pClan, Actor pFounder)

### public class NeoModLoader.General.Event.Handlers.CultureCreateHandler
- Base: NeoModLoader.General.Event.AbstractHandler<NeoModLoader.General.Event.Handlers.CultureCreateHandler>

#### Constructors
- protected CultureCreateHandler()

#### Methods
- public abstract void Handle(Culture pCulture, Actor pActor, City pCity)

### public class NeoModLoader.General.Event.Handlers.KingdomSetupHandler
- Base: NeoModLoader.General.Event.AbstractHandler<NeoModLoader.General.Event.Handlers.KingdomSetupHandler>

#### Constructors
- protected KingdomSetupHandler()

#### Methods
- public abstract void Handle(Kingdom pKingdom, bool pCiv)

### public class NeoModLoader.General.Event.Handlers.PlotStartHandler
- Base: NeoModLoader.General.Event.AbstractHandler<NeoModLoader.General.Event.Handlers.PlotStartHandler>

#### Constructors
- protected PlotStartHandler()

#### Methods
- public abstract void Handle(Plot pPlot, Actor pActor, PlotAsset pAsset)

### public class NeoModLoader.General.Event.Handlers.WarEndHandler
- Base: NeoModLoader.General.Event.AbstractHandler<NeoModLoader.General.Event.Handlers.WarEndHandler>

#### Constructors
- protected WarEndHandler()

#### Methods
- public abstract void Handle(WarManager pWarManager, War pWar)

### public class NeoModLoader.General.Event.Handlers.WarStartHandler
- Base: NeoModLoader.General.Event.AbstractHandler<NeoModLoader.General.Event.Handlers.WarStartHandler>

#### Constructors
- protected WarStartHandler()

#### Methods
- public abstract void Handle(War pWar, Kingdom pAttacker, Kingdom pDefender, WarTypeAsset pWarType)

### public class NeoModLoader.General.Event.Handlers.WorldLogMessageHandler
- Base: NeoModLoader.General.Event.AbstractHandler<NeoModLoader.General.Event.Handlers.WorldLogMessageHandler>

#### Constructors
- protected WorldLogMessageHandler()

#### Methods
- public abstract void Handle(ref WorldLogMessage pMessage, ref string pText, ref UnityEngine.Color pColor, ref bool pColorField, bool pColorTags)

## Namespace: NeoModLoader.General.Event.Listeners

### private class NeoModLoader.General.Event.Listeners.ActorTryToAttackListener.<>c

#### Fields
- public static readonly NeoModLoader.General.Event.Listeners.ActorTryToAttackListener.<>c <>9
- public static System.Predicate<HarmonyLib.CodeInstruction> <>9__1_0

#### Constructors
- private static ActorTryToAttackListener.<>c()
- public ActorTryToAttackListener.<>c()

#### Methods
- internal bool <_tryToAttack_Patch>b__1_0(HarmonyLib.CodeInstruction x)

### private class NeoModLoader.General.Event.Listeners.PlotStartListener.<>c

#### Fields
- public static readonly NeoModLoader.General.Event.Listeners.PlotStartListener.<>c <>9
- public static System.Predicate<HarmonyLib.CodeInstruction> <>9__1_0

#### Constructors
- private static PlotStartListener.<>c()
- public PlotStartListener.<>c()

#### Methods
- internal bool <_newPlot_Patch>b__1_0(HarmonyLib.CodeInstruction code)

### private class NeoModLoader.General.Event.Listeners.WarStartListener.<>c

#### Fields
- public static readonly NeoModLoader.General.Event.Listeners.WarStartListener.<>c <>9
- public static System.Predicate<HarmonyLib.CodeInstruction> <>9__1_0

#### Constructors
- private static WarStartListener.<>c()
- public WarStartListener.<>c()

#### Methods
- internal bool <_newWar_Patch>b__1_0(HarmonyLib.CodeInstruction c)

### public class NeoModLoader.General.Event.Listeners.ActorTryToAttackListener
- Base: NeoModLoader.General.Event.AbstractListener<NeoModLoader.General.Event.Listeners.ActorTryToAttackListener, NeoModLoader.General.Event.Handlers.ActorTryToAttackHandler>

#### Constructors
- public ActorTryToAttackListener()

#### Methods
- protected static void HandleAll(Actor pAttacker, BaseSimObject pTarget, CombatActionAsset pCombatActionAsset, AttackData pAttackData)
- private static System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> _tryToAttack_Patch(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> instr)

### public class NeoModLoader.General.Event.Listeners.AllianceCreateListener
- Base: NeoModLoader.General.Event.AbstractListener<NeoModLoader.General.Event.Listeners.AllianceCreateListener, NeoModLoader.General.Event.Handlers.AllianceCreateHandler>

#### Constructors
- public AllianceCreateListener()

#### Methods
- protected static void HandleAll(Alliance pAlliance, Kingdom pKingdom, Kingdom pKingdom2)
- private static System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> _newAllianceEvent_Patch(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> instr)

### public class NeoModLoader.General.Event.Listeners.CityCreateListener
- Base: NeoModLoader.General.Event.AbstractListener<NeoModLoader.General.Event.Listeners.CityCreateListener, NeoModLoader.General.Event.Handlers.CityCreateHandler>

#### Constructors
- public CityCreateListener()

#### Methods
- protected static void HandleAll(City pCity)
- private static System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> _newCityEvent_Patch(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> instr)

### public class NeoModLoader.General.Event.Listeners.ClanCreateListener
- Base: NeoModLoader.General.Event.AbstractListener<NeoModLoader.General.Event.Listeners.ClanCreateListener, NeoModLoader.General.Event.Handlers.ClanCreateHandler>

#### Constructors
- public ClanCreateListener()

#### Methods
- protected static void HandleAll(Clan pClan, Actor pActor)
- private static System.Reflection.MethodInfo _createHandleAllMethodByIL()
- private static System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> _newClan_Patch(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> instr)

### public class NeoModLoader.General.Event.Listeners.CultureCreateListener
- Base: NeoModLoader.General.Event.AbstractListener<NeoModLoader.General.Event.Listeners.CultureCreateListener, NeoModLoader.General.Event.Handlers.CultureCreateHandler>

#### Constructors
- public CultureCreateListener()

#### Methods
- protected static void HandleAll(Culture pCulture, Actor pActor, City pCity)
- private static System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> _createCulture_Patch(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> instr)

### public class NeoModLoader.General.Event.Listeners.KingdomSetupListener
- Base: NeoModLoader.General.Event.AbstractListener<NeoModLoader.General.Event.Listeners.KingdomSetupListener, NeoModLoader.General.Event.Handlers.KingdomSetupHandler>

#### Constructors
- public KingdomSetupListener()

#### Methods
- protected static void HandleAll(Kingdom pKingdom, bool pCiv)
- private static System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> _setupKingdom_Patch(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> instr)

### public class NeoModLoader.General.Event.Listeners.PlotStartListener
- Base: NeoModLoader.General.Event.AbstractListener<NeoModLoader.General.Event.Listeners.PlotStartListener, NeoModLoader.General.Event.Handlers.PlotStartHandler>

#### Constructors
- public PlotStartListener()

#### Methods
- protected static void HandleAll(Plot pPlot, Actor pActor, PlotAsset pAsset)
- private static System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> _newPlot_Patch(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> instr)

### public class NeoModLoader.General.Event.Listeners.WarEndListener
- Base: NeoModLoader.General.Event.AbstractListener<NeoModLoader.General.Event.Listeners.WarEndListener, NeoModLoader.General.Event.Handlers.WarEndHandler>

#### Constructors
- public WarEndListener()

#### Methods
- protected static void HandleAll(WarManager pWarManager, War pWar)
- private static System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> _endWar_Patch(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> instr)

### public class NeoModLoader.General.Event.Listeners.WarStartListener
- Base: NeoModLoader.General.Event.AbstractListener<NeoModLoader.General.Event.Listeners.WarStartListener, NeoModLoader.General.Event.Handlers.WarStartHandler>

#### Constructors
- public WarStartListener()

#### Methods
- protected static void HandleAll(War pWar, Kingdom pAttacker, Kingdom pDefender, WarTypeAsset pWarType)
- private static System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> _newWar_Patch(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> instr)

### public class NeoModLoader.General.Event.Listeners.WorldLogMessageListener
- Base: NeoModLoader.General.Event.AbstractListener<NeoModLoader.General.Event.Listeners.WorldLogMessageListener, NeoModLoader.General.Event.Handlers.WorldLogMessageHandler>

#### Constructors
- public WorldLogMessageListener()

#### Methods
- protected static string HandleAll(ref WorldLogMessage pMessage, string pCurrentText, UnityEngine.Color pCurrentColor, UnityEngine.UI.Text pTextfield, bool pColorField, bool pColorTags)
- private static System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> _WorldLogMessage_getFormatedText_Patch(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> instr)

## Namespace: NeoModLoader.General.Game.extensions

### private class NeoModLoader.General.Game.extensions.AssetExtensionInternal<TAsset, TLibrary>.<>c<TAsset, TLibrary>

#### Fields
- public static readonly NeoModLoader.General.Game.extensions.AssetExtensionInternal<TAsset, TLibrary>.<>c<TAsset, TLibrary> <>9
- public static System.Func<TAsset, string> <>9__2_1
- public static System.Func<System.Reflection.MethodInfo, bool> <>9__2_2

#### Constructors
- private static AssetExtensionInternal<TAsset, TLibrary>.<>c<TAsset, TLibrary>()
- public AssetExtensionInternal<TAsset, TLibrary>.<>c<TAsset, TLibrary>()

#### Methods
- internal string <ForEach>b__2_1(TAsset x)
- internal bool <ForEach>b__2_2(System.Reflection.MethodInfo x)

### private class NeoModLoader.General.Game.extensions.AssetExtensionInternal<TAsset, TLibrary>.<>c__DisplayClass2_0<TAsset, TLibrary>

#### Fields
- public System.Action<TAsset> pAction

#### Constructors
- public AssetExtensionInternal<TAsset, TLibrary>.<>c__DisplayClass2_0<TAsset, TLibrary>()

#### Methods
- internal void <ForEach>b__0(TAsset asset)

### public static class NeoModLoader.General.Game.extensions.AssetExtension

#### Methods
- public static void ForEach<TAsset, TLibrary>(TLibrary pLibrary, System.Action<TAsset> pAction)

### internal static class NeoModLoader.General.Game.extensions.AssetExtensionInternal<TAsset, TLibrary>

#### Fields
- private static bool _assetlibrary_patched
- private static readonly System.Collections.Generic.Dictionary<TLibrary, System.Collections.Generic.List<NeoModLoader.General.Game.extensions.AssetExtensionInternal<TAsset, TLibrary>.LibraryState<TAsset, TLibrary>>> _states

#### Constructors
- private static AssetExtensionInternal<TAsset, TLibrary>()

#### Methods
- private static void AppendAssetToAction(TLibrary __instance, TAsset pAsset)
- public static void ForEach(TLibrary pLibrary, System.Action<TAsset> pAction)

### public class NeoModLoader.General.Game.extensions.BasicCustomData<TDataClass>
- Interfaces: NeoModLoader.General.Game.extensions.ICustomData

#### Fields
- private TDataClass <Data>k__BackingField

#### Properties
- public TDataClass Data { get; private set; }

#### Constructors
- public BasicCustomData<TDataClass>()
- public BasicCustomData<TDataClass>(TDataClass data)

#### Methods
- public void Deserialize(NeoModLoader.General.Game.extensions.SerializedCustomData data)
- public NeoModLoader.General.Game.extensions.SerializedCustomData Serialize()

### public static class NeoModLoader.General.Game.extensions.DataExtension

#### Methods
- public static void Set<TCustomData>(BaseSystemData data, string key, TCustomData value)
- public static bool TryGet<TCustomData>(BaseSystemData data, string key, out TCustomData result)

### public interface NeoModLoader.General.Game.extensions.ICustomData

#### Methods
- public void Deserialize(NeoModLoader.General.Game.extensions.SerializedCustomData data)
- public NeoModLoader.General.Game.extensions.SerializedCustomData Serialize()

### private class NeoModLoader.General.Game.extensions.AssetExtensionInternal<TAsset, TLibrary>.LibraryState<TAsset, TLibrary>

#### Fields
- public System.Action<TAsset> action
- public readonly System.Collections.Generic.HashSet<string> done

#### Constructors
- public AssetExtensionInternal<TAsset, TLibrary>.LibraryState<TAsset, TLibrary>()

### public class NeoModLoader.General.Game.extensions.SerializedCustomData

#### Fields
- public Newtonsoft.Json.Linq.JObject Data
- public string DataVersion
- public string ModId

#### Constructors
- public SerializedCustomData(string modId, string dataVersion, Newtonsoft.Json.Linq.JObject data)

## Namespace: NeoModLoader.General.UI.Prefabs

### private class NeoModLoader.General.UI.Prefabs.SwitchButton.<>c__DisplayClass13_0

#### Fields
- public NeoModLoader.General.UI.Prefabs.SwitchButton <>4__this
- public bool value
- public System.Action value_update

#### Constructors
- public SwitchButton.<>c__DisplayClass13_0()

#### Methods
- internal void <Setup>b__0()

### private class NeoModLoader.General.UI.Prefabs.SimpleButton.<>c__DisplayClass16_0

#### Fields
- public NeoModLoader.General.UI.Prefabs.SimpleButton <>4__this
- public TooltipData pTipData

#### Constructors
- public SimpleButton.<>c__DisplayClass16_0()

#### Methods
- internal void <Setup>b__0()

### public class NeoModLoader.General.UI.Prefabs.APrefab<T>
- Base: UnityEngine.MonoBehaviour

#### Fields
- protected bool Initialized
- private static T mPrefab

#### Properties
- public static T Prefab { get; protected set; }

#### Constructors
- protected APrefab<T>()

#### Methods
- protected virtual void Init()
- public static T Instantiate(UnityEngine.Transform pParent = null, bool pWorldPositionStays = false, string pName = null)
- public virtual void SetSize(UnityEngine.Vector2 pSize)

### public class NeoModLoader.General.UI.Prefabs.SimpleButton
- Base: NeoModLoader.General.UI.Prefabs.APrefab<NeoModLoader.General.UI.Prefabs.SimpleButton>

#### Fields
- private UnityEngine.UI.Image background
- private UnityEngine.UI.Button button
- private UnityEngine.UI.Image icon
- private UnityEngine.UI.Text text
- private TipButton tipButton

#### Properties
- public UnityEngine.UI.Image Background { get; }
- public UnityEngine.UI.Button Button { get; }
- public UnityEngine.UI.Image Icon { get; }
- public UnityEngine.UI.Text Text { get; }
- public TipButton TipButton { get; }

#### Constructors
- public SimpleButton()

#### Methods
- private void Awake()
- public override void SetSize(UnityEngine.Vector2 pSize)
- public void Setup(UnityEngine.Events.UnityAction pClickAction, UnityEngine.Sprite pIcon, string pText = null, UnityEngine.Vector2 pSize = null, string pTipType = null, TooltipData pTipData = null)
- internal static void _init()

### public class NeoModLoader.General.UI.Prefabs.SimpleStatBar
- Base: NeoModLoader.General.UI.Prefabs.APrefab<NeoModLoader.General.UI.Prefabs.SimpleStatBar>

#### Fields
- private UnityEngine.UI.Image _background
- private UnityEngine.UI.Image _bar
- private UnityEngine.UI.Image _icon
- private StatBar _stat_bar

#### Properties
- public UnityEngine.UI.Image background { get; }
- public UnityEngine.UI.Image bar { get; }
- public UnityEngine.UI.Image icon { get; }
- public StatBar stat_bar { get; }

#### Constructors
- public SimpleStatBar()

#### Methods
- public virtual void Setup(float value, float max_value, string pEndText, UnityEngine.Sprite pIcon, UnityEngine.Sprite pBackground, UnityEngine.Color pBarColor, UnityEngine.Vector2 pSize, bool pReset = true, bool pFloat = false, bool pUpdateText = true, float pSpeed = 0.3)
- public void UpdateBar(float value, float max_value, string pEndText, UnityEngine.Color pBarColor = null, bool pReset = true, bool pFloat = false, bool pUpdateText = true, float pSpeed = 0.3)
- internal static void _init()

### public class NeoModLoader.General.UI.Prefabs.SliderBar
- Base: NeoModLoader.General.UI.Prefabs.APrefab<NeoModLoader.General.UI.Prefabs.SliderBar>

#### Fields
- private UnityEngine.UI.Slider _slider
- private TipButton _tip_button

#### Properties
- public UnityEngine.UI.Slider slider { get; }
- public TipButton tip_button { get; }

#### Constructors
- public SliderBar()

#### Methods
- private void Awake()
- public override void SetSize(UnityEngine.Vector2 size)
- public void Setup(float value, float min, float max, UnityEngine.Events.UnityAction<float> value_update, UnityEngine.Vector2 size = null, bool whole_numbers = false)
- internal static void _init()

### public class NeoModLoader.General.UI.Prefabs.SwitchButton
- Base: NeoModLoader.General.UI.Prefabs.APrefab<NeoModLoader.General.UI.Prefabs.SwitchButton>

#### Fields
- private UnityEngine.UI.Button _button
- private UnityEngine.UI.Image _icon
- private UnityEngine.UI.Text _text
- private TipButton _tip_button

#### Properties
- public UnityEngine.UI.Button button { get; }
- public UnityEngine.UI.Image icon { get; }
- public UnityEngine.UI.Text text { get; }
- public TipButton tip_button { get; }

#### Constructors
- public SwitchButton()

#### Methods
- private void Awake()
- public void Setup(bool value, System.Action value_update)
- internal static void _init()

### public class NeoModLoader.General.UI.Prefabs.TextInput
- Base: NeoModLoader.General.UI.Prefabs.APrefab<NeoModLoader.General.UI.Prefabs.TextInput>

#### Fields
- private UnityEngine.UI.Image _icon
- private UnityEngine.UI.InputField _input
- private UnityEngine.UI.Text _text
- private TipButton _tip_button

#### Properties
- public UnityEngine.UI.Image icon { get; }
- public UnityEngine.UI.InputField input { get; }
- public UnityEngine.UI.Text text { get; }
- public TipButton tip_button { get; }

#### Constructors
- public TextInput()

#### Methods
- private void Awake()
- public override void SetSize(UnityEngine.Vector2 size)
- public virtual void Setup(string value, UnityEngine.Events.UnityAction<string> value_update, UnityEngine.Sprite pIcon = null, UnityEngine.Sprite pBackground = null)
- internal static void _init()

## Namespace: NeoModLoader.General.UI.Tab

### private class NeoModLoader.General.UI.Tab.ReconstructedVanillaTab.<>c

#### Fields
- public static readonly NeoModLoader.General.UI.Tab.ReconstructedVanillaTab.<>c <>9
- public static System.Comparison<UnityEngine.Transform> <>9__8_0
- public static System.Comparison<UnityEngine.Vector2> <>9__8_1

#### Constructors
- private static ReconstructedVanillaTab.<>c()
- public ReconstructedVanillaTab.<>c()

#### Methods
- internal int <TrackElements>b__8_0(UnityEngine.Transform a, UnityEngine.Transform b)
- internal int <TrackElements>b__8_1(UnityEngine.Vector2 a, UnityEngine.Vector2 b)

### private class NeoModLoader.General.UI.Tab.TabManager.<>c

#### Fields
- public static readonly NeoModLoader.General.UI.Tab.TabManager.<>c <>9
- public static System.Func<string, string, string> <>9__29_1
- public static System.Func<UnityEngine.GameObject, PowersTab> <>9__36_0
- public static System.Func<PowersTab, bool> <>9__36_1

#### Constructors
- private static TabManager.<>c()
- public TabManager.<>c()

#### Methods
- internal PowersTab <CreateTab>b__36_0(UnityEngine.GameObject tgo)
- internal bool <CreateTab>b__36_1(PowersTab t)
- internal string <_checkNewTabs>b__29_1(string current, string fix)

### private class NeoModLoader.General.UI.Tab.TabManager.<>c__DisplayClass30_0

#### Fields
- public string pTabName
- public UnityEngine.UI.Button tab_entry

#### Constructors
- public TabManager.<>c__DisplayClass30_0()

#### Methods
- internal void <_addDragEventTo>b__0(UnityEngine.EventSystems.BaseEventData data)
- internal void <_addDragEventTo>b__1(UnityEngine.EventSystems.BaseEventData data)

### private struct NeoModLoader.General.UI.Tab.TabManager.<>c__DisplayClass32_0

#### Fields
- public UnityEngine.Vector3 current_pos
- public UnityEngine.Vector3 delta
- public int index
- public UnityEngine.RectTransform tab_entry_rect

### private class NeoModLoader.General.UI.Tab.TabManager.<>c__DisplayClass36_0

#### Fields
- public PowersTab tab
- public UnityEngine.GameObject tab_entry
- public UnityEngine.UI.Button tab_entry_button

#### Constructors
- public TabManager.<>c__DisplayClass36_0()

#### Methods
- internal void <CreateTab>b__2()
- internal void <CreateTab>b__3()
- internal PowersTab <CreateTab>b__4()

### private class NeoModLoader.General.UI.Tab.WrappedPowersTab.PlaceholdRegions

#### Fields
- private System.Collections.Generic.HashSet<NeoModLoader.General.UI.Tab.WrappedPowersTab.PlaceholdRegions.SimpleRegion> _regions

#### Constructors
- public WrappedPowersTab.PlaceholdRegions()

#### Methods
- public void AddRegion(UnityEngine.RectTransform pRect)
- public bool Overlap(UnityEngine.RectTransform pRect)

### public static class NeoModLoader.General.UI.Tab.PowersTabExtension

#### Fields
- private static System.Collections.Generic.Dictionary<string, NeoModLoader.General.UI.Tab.WrappedPowersTab> _wrapped_powers_tabs

#### Constructors
- private static PowersTabExtension()

#### Methods
- public static void AddPowerButton(PowersTab pTab, string pGroupId, PowerButton pPowerButton)
- public static void PutElement(PowersTab pTab, string pGroupId, UnityEngine.RectTransform pObjRect, UnityEngine.Vector2 pPositionInGroup, bool pPlacehold = true)
- public static void SetLayout(PowersTab pTab, System.Collections.Generic.List<string> pGroupIds)
- public static void UpdateLayout(PowersTab pTab)
- private static NeoModLoader.General.UI.Tab.WrappedPowersTab _getWrappedPowersTab(PowersTab pTab)

### public class NeoModLoader.General.UI.Tab.ReconstructedVanillaTab

#### Fields
- internal NeoModLoader.General.UI.Tab.WrappedPowersTab tab

#### Properties
- protected string[] Groups { get; }

#### Constructors
- protected ReconstructedVanillaTab()

#### Methods
- public void AddCustomRect(string pGroupId, UnityEngine.RectTransform pCustomRect, UnityEngine.Vector2 pPosInGroup, bool pPlaceholder)
- public void AddPowerButton(string pGroupId, PowerButton pPowerButton)
- internal void Init()
- protected abstract void InitTab()
- protected System.Collections.Generic.List<System.Collections.Generic.List<NeoModLoader.General.UI.Tab.ReconstructedVanillaTab.TabElement>> TrackElements()
- private bool _is_line(UnityEngine.Transform pTransform)
- private void _sort_group(System.Collections.Generic.List<NeoModLoader.General.UI.Tab.ReconstructedVanillaTab.TabElement> group)

### private class NeoModLoader.General.UI.Tab.WrappedPowersTab.PlaceholdRegions.SimpleRegion

#### Fields
- public readonly UnityEngine.Vector2 LeftUpCorner
- public readonly UnityEngine.Vector2 RightDownCorner

#### Constructors
- public WrappedPowersTab.PlaceholdRegions.SimpleRegion(UnityEngine.RectTransform pRect)

#### Methods
- public bool Contains(float pX, float pY)
- public bool ContainsX(float pX)
- public bool ContainsY(float pY)

### public class NeoModLoader.General.UI.Tab.TabBombs
- Base: NeoModLoader.General.UI.Tab.ReconstructedVanillaTab

#### Properties
- protected string[] Groups { get; }

#### Constructors
- public TabBombs()

#### Methods
- protected override void InitTab()

### public class NeoModLoader.General.UI.Tab.TabCreatures
- Base: NeoModLoader.General.UI.Tab.ReconstructedVanillaTab

#### Fields
- public static const string IMPROPER_CREATURES
- public static const string LAND_CREATURES
- public static const string MAGICAL_CREATURES
- public static const string RACES
- public static const string SEA_CREATURES
- public static const string UNDEAD_CREATURES

#### Properties
- protected string[] Groups { get; }

#### Constructors
- public TabCreatures()

#### Methods
- protected override void InitTab()

### public class NeoModLoader.General.UI.Tab.TabDrawing
- Base: NeoModLoader.General.UI.Tab.ReconstructedVanillaTab

#### Fields
- public static const string CLEANER
- public static const string DELETOR
- public static const string MAP_HELPER
- public static const string TILE_BRUSH

#### Properties
- protected string[] Groups { get; }

#### Constructors
- public TabDrawing()

#### Methods
- protected override void InitTab()

### protected class NeoModLoader.General.UI.Tab.ReconstructedVanillaTab.TabElement

#### Fields
- public UnityEngine.RectTransform element
- public UnityEngine.Vector2 pos_in_group

#### Constructors
- public ReconstructedVanillaTab.TabElement()

### public class NeoModLoader.General.UI.Tab.TabKingdoms
- Base: NeoModLoader.General.UI.Tab.ReconstructedVanillaTab

#### Fields
- public static const string ACTIVITY
- public static const string FORCE_VIEW
- public static const string INSPECT
- public static const string MAPLAYER
- public static const string RELATION

#### Properties
- protected string[] Groups { get; }

#### Constructors
- public TabKingdoms()

#### Methods
- protected override void InitTab()

### public class NeoModLoader.General.UI.Tab.TabMain
- Base: NeoModLoader.General.UI.Tab.ReconstructedVanillaTab

#### Fields
- public static const string CUSTOM
- public static const string GAME_SETTING
- public static const string OTHERS
- public static const string REBUILD
- public static const string WORLD_INFO
- private static readonly string[] _groups

#### Properties
- protected string[] Groups { get; }

#### Constructors
- public TabMain()
- private static TabMain()

#### Methods
- protected override void InitTab()

### public static class NeoModLoader.General.UI.Tab.TabManager

#### Fields
- private static const float check_new_tabs_interval
- private static readonly System.Collections.Generic.List<string> common_fix_for_tab_button
- private static const float default_icon_height
- private static const float default_icon_width
- private static const float default_tab_height
- private static const float default_tab_width
- private static const float default_tab_y
- private static const float shrink_coef
- public static readonly NeoModLoader.General.UI.Tab.TabCreatures TabCreatures
- public static readonly NeoModLoader.General.UI.Tab.TabDrawing TabDrawing
- public static readonly NeoModLoader.General.UI.Tab.TabKingdoms TabKingdoms
- public static readonly NeoModLoader.General.UI.Tab.TabMain TabMain
- public static readonly NeoModLoader.General.UI.Tab.TabNature TabNature
- public static readonly NeoModLoader.General.UI.Tab.TabOther TabOther
- private static readonly UnityEngine.Transform tab_container
- private static const int tab_count_each_line
- private static readonly System.Collections.Generic.List<UnityEngine.UI.Button> tab_entries
- private static readonly UnityEngine.Transform tab_entry_container
- private static readonly System.Collections.Generic.List<string> tab_names
- private static readonly System.Collections.Generic.HashSet<string> tab_names_set
- private static float _check_timer
- private static UnityEngine.Vector3 _last_mouse_pos

#### Constructors
- private static TabManager()

#### Methods
- internal static string <_checkNewTabs>g__GetTabMainPart|29_0(string name)
- internal static void <_onDragTabEntry>g__swap|32_0(bool left, ref NeoModLoader.General.UI.Tab.TabManager.<>c__DisplayClass32_0 )
- public static PowersTab CreateTab(string name, string pTitleKey, string pDescKey, UnityEngine.Sprite pIcon, string pOptionDescKey = "hotkey_tip_tab_other")
- private static void _addDragEventTo(UnityEngine.UI.Button tab_entry, string pTabName)
- private static void _addTabEntry(UnityEngine.GameObject pTabEntry, string pTabId)
- internal static void _checkNewTabs()
- private static UnityEngine.UI.Button _getNext_Overwrite(PowerTabController instance, string pActiveTab)
- private static System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> _getNext_Patch(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> instr)
- private static UnityEngine.UI.Button _getPrev_Overwrite(PowerTabController instance, string pActiveTab)
- private static System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> _getPrev_Patch(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> instr)
- internal static void _init()
- private static void _loadPredefinedOrder()
- private static void _onDragTabEntry(UnityEngine.UI.Button pTabEntry, string pTabName)
- private static void _savePredefinedOrder()
- private static void _setToValidPosition(UnityEngine.UI.Button pTabEntry, string pTabName)
- private static void _updateTabEntryRectAs(UnityEngine.UI.Button tab, int index)
- private static void _updateTabLayout()

### public class NeoModLoader.General.UI.Tab.TabNature
- Base: NeoModLoader.General.UI.Tab.ReconstructedVanillaTab

#### Fields
- public static const string BIOMES
- public static const string DROP
- public static const string FERTILITY
- public static const string PHENOMENON
- public static const string RESOURCES

#### Properties
- protected string[] Groups { get; }

#### Constructors
- public TabNature()

#### Methods
- protected override void InitTab()

### public class NeoModLoader.General.UI.Tab.TabOther
- Base: NeoModLoader.General.UI.Tab.ReconstructedVanillaTab

#### Fields
- public static const string EDITOR_RAIN
- public static const string INFO
- public static const string LIFE_GAME
- public static const string SHAPE_PRINTER
- public static const string STATUS

#### Properties
- protected string[] Groups { get; }

#### Constructors
- public TabOther()

#### Methods
- protected override void InitTab()

### internal class NeoModLoader.General.UI.Tab.WrappedPowersTab

#### Fields
- private static const float assumed_button_size
- private static readonly float[] available_y
- private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<PowerButton>> ButtonGroups
- private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<NeoModLoader.General.UI.Tab.WrappedPowersTab.WrappedRectTransform>> CustomRectGroups
- public bool Modifiable
- private static const float space
- public PowersTab Tab
- private static const float tab_start_x
- private System.Collections.Generic.Queue<UnityEngine.GameObject> _active_lines
- private static readonly UnityEngine.RectTransform _empty_button_placehold
- private System.Collections.Generic.Queue<UnityEngine.GameObject> _inactive_lines

#### Constructors
- private static WrappedPowersTab()
- public WrappedPowersTab(PowersTab pPowersTab)

#### Methods
- public void AddCustomRect(string pGroupId, UnityEngine.RectTransform pRect, UnityEngine.Vector2 pPositionInGroup, bool pPlacehold)
- public void AddGroup(string pGroupId)
- public void AddPowerButton(string pGroupId, PowerButton pPowerButton)
- public bool HasGroup(string pGroupId)
- internal void RecordLine(UnityEngine.GameObject line)
- public void ResetGroups()
- public void UpdateLayout()
- private void _add_line(float pX)
- public static void _init()

### private class NeoModLoader.General.UI.Tab.WrappedPowersTab.WrappedRectTransform

#### Fields
- public readonly bool Placehold
- public readonly UnityEngine.Vector2 PositionInGroup
- public readonly UnityEngine.RectTransform Rect

#### Constructors
- public WrappedPowersTab.WrappedRectTransform(UnityEngine.RectTransform pRect, UnityEngine.Vector2 pPositionInGroup, bool pPlacehold)

## Namespace: NeoModLoader.General.UI.Window

### private class NeoModLoader.General.UI.Window.MultiTabWindow<T>.<>c__DisplayClass8_0<T>

#### Fields
- public NeoModLoader.General.UI.Window.MultiTabWindow<T> <>4__this
- public System.Func<System.Collections.Generic.KeyValuePair<NeoModLoader.General.UI.Prefabs.SimpleButton, NeoModLoader.General.UI.Window.Layout.AutoVertLayoutGroup>, bool> <>9__1
- public UnityEngine.Events.UnityAction<string> pAdditionTabSwitchAction
- public string pTabID
- public NeoModLoader.General.UI.Window.Layout.AutoVertLayoutGroup tab
- public NeoModLoader.General.UI.Prefabs.SimpleButton tab_entry

#### Constructors
- public MultiTabWindow<T>.<>c__DisplayClass8_0<T>()

#### Methods
- internal void <CreateTab>b__0()
- internal bool <CreateTab>b__1(System.Collections.Generic.KeyValuePair<NeoModLoader.General.UI.Prefabs.SimpleButton, NeoModLoader.General.UI.Window.Layout.AutoVertLayoutGroup> tab_entry_pair)

### public class NeoModLoader.General.UI.Window.AutoLayoutElement<T>
- Base: NeoModLoader.General.UI.Prefabs.APrefab<T>

#### Constructors
- protected AutoLayoutElement<T>()

### public class NeoModLoader.General.UI.Window.AutoLayoutGroup<T, TElement>
- Base: NeoModLoader.General.UI.Window.AutoLayoutElement<TElement>

#### Fields
- protected UnityEngine.UI.ContentSizeFitter m_fitter
- protected T m_layout

#### Properties
- public UnityEngine.UI.ContentSizeFitter fitter { get; }
- public T layout { get; }

#### Constructors
- protected AutoLayoutGroup<T, TElement>()

#### Methods
- public virtual void AddChild(UnityEngine.GameObject pChild, int pIndex = -1)
- public TSub BeginSubGroup<TSub, TSubGroup>(UnityEngine.Vector2 pSize = null)
- public virtual T GetLayoutGroup()
- public override void SetSize(UnityEngine.Vector2 pSize)

### public class NeoModLoader.General.UI.Window.AutoLayoutWindow<T>
- Base: NeoModLoader.General.UI.Window.Layout.AutoVertLayoutGroup

#### Fields
- private UnityEngine.Transform <BackgroundTransform>k__BackingField
- private UnityEngine.Transform <ContentTransform>k__BackingField
- private ScrollWindow <ScrollWindowComponent>k__BackingField
- private string <WindowID>k__BackingField
- protected bool Initialized
- protected bool IsFirstOpen
- protected bool IsOpened

#### Properties
- protected UnityEngine.Transform BackgroundTransform { get; set; }
- protected UnityEngine.Transform ContentTransform { get; set; }
- protected ScrollWindow ScrollWindowComponent { get; set; }
- protected internal string WindowID { get; set; }

#### Constructors
- protected AutoLayoutWindow<T>()

#### Methods
- public static T CreateWindow(string pWindowID, string pWindowTitleKey)
- protected abstract void Init()
- private void OnDisable()
- private void OnEnable()
- public virtual void OnFirstEnable()
- public virtual void OnNormalDisable()
- public virtual void OnNormalEnable()
- public static void Reconstruct(ref T pWindow)

### public class NeoModLoader.General.UI.Window.MultiTabWindow<T>
- Base: NeoModLoader.General.UI.Window.AutoLayoutWindow<T>

#### Fields
- private string <CurrentTab>k__BackingField
- private readonly System.Collections.Generic.Dictionary<NeoModLoader.General.UI.Prefabs.SimpleButton, NeoModLoader.General.UI.Window.Layout.AutoVertLayoutGroup> m_tabs
- private UnityEngine.RectTransform m_tab_entries_left
- private UnityEngine.RectTransform m_tab_entries_right

#### Properties
- protected string CurrentTab { get; private set; }

#### Constructors
- protected MultiTabWindow<T>()

#### Methods
- protected NeoModLoader.General.UI.Window.Layout.AutoVertLayoutGroup CreateTab(string pTabID, UnityEngine.Sprite pTabIcon, UnityEngine.Events.UnityAction<string> pAdditionTabSwitchAction = null)
- public static T CreateWindow(string pWindowID, string pWindowTitleKey)
- private void ResizeTabEntries()

### public class NeoModLoader.General.UI.Window.SingleAutoLayoutWindow<T>
- Base: NeoModLoader.General.UI.Window.AutoLayoutWindow<T>

#### Fields
- private static T <Instance>k__BackingField

#### Properties
- public static T Instance { get; private set; }
- public static string WindowId { get; }

#### Constructors
- protected SingleAutoLayoutWindow<T>()

#### Methods
- public static T CreateWindow(string pWindowID, string pWindowTitleKey)

## Namespace: NeoModLoader.General.UI.Window.Layout

### public class NeoModLoader.General.UI.Window.Layout.AutoGridLayoutGroup
- Base: NeoModLoader.General.UI.Window.AutoLayoutGroup<UnityEngine.UI.GridLayoutGroup, NeoModLoader.General.UI.Window.Layout.AutoGridLayoutGroup>

#### Constructors
- public AutoGridLayoutGroup()

#### Methods
- public void Setup(int pConstraintCount, UnityEngine.UI.GridLayoutGroup.Constraint pConstraint = FixedColumnCount, UnityEngine.Vector2 pSize = null, UnityEngine.Vector2 pCellSize = null, UnityEngine.Vector2 pSpacing = null, UnityEngine.UI.GridLayoutGroup.Axis pStartAxis = Horizontal, UnityEngine.UI.GridLayoutGroup.Corner pStartCorner = UpperLeft)
- internal static void _init()

### public class NeoModLoader.General.UI.Window.Layout.AutoHoriLayoutGroup
- Base: NeoModLoader.General.UI.Window.AutoLayoutGroup<UnityEngine.UI.HorizontalLayoutGroup, NeoModLoader.General.UI.Window.Layout.AutoHoriLayoutGroup>

#### Constructors
- public AutoHoriLayoutGroup()

#### Methods
- public void Setup(UnityEngine.Vector2 pSize = null, UnityEngine.TextAnchor pAlignment = MiddleLeft, float pSpacing = 3, UnityEngine.RectOffset pPadding = null)
- internal static void _init()

### public class NeoModLoader.General.UI.Window.Layout.AutoVertLayoutGroup
- Base: NeoModLoader.General.UI.Window.AutoLayoutGroup<UnityEngine.UI.VerticalLayoutGroup, NeoModLoader.General.UI.Window.Layout.AutoVertLayoutGroup>

#### Constructors
- public AutoVertLayoutGroup()

#### Methods
- public void Setup(UnityEngine.Vector2 pSize = null, UnityEngine.TextAnchor pAlignment = UpperCenter, float pSpacing = 3, UnityEngine.RectOffset pPadding = null)
- internal static void _init()

## Namespace: NeoModLoader.General.UI.Window.Utils.Extensions

### public static class NeoModLoader.General.UI.Window.Utils.Extensions.AutoLayoutGroupExtension

#### Methods
- public static NeoModLoader.General.UI.Window.Layout.AutoGridLayoutGroup BeginGridGroup<T, TElement>(NeoModLoader.General.UI.Window.AutoLayoutGroup<T, TElement> pThis, int pConstraintCount, UnityEngine.UI.GridLayoutGroup.Constraint pConstraint = FixedColumnCount, UnityEngine.Vector2 pSize = null, UnityEngine.Vector2 pCellSize = null, UnityEngine.Vector2 pSpacing = null, UnityEngine.UI.GridLayoutGroup.Axis pStartAxis = Horizontal, UnityEngine.UI.GridLayoutGroup.Corner pStartCorner = UpperLeft)
- public static NeoModLoader.General.UI.Window.Layout.AutoHoriLayoutGroup BeginHoriGroup<T, TElement>(NeoModLoader.General.UI.Window.AutoLayoutGroup<T, TElement> pThis, UnityEngine.Vector2 pSize = null, UnityEngine.TextAnchor pAlignment = MiddleLeft, float pSpacing = 3, UnityEngine.RectOffset pPadding = null)
- public static NeoModLoader.General.UI.Window.Layout.AutoVertLayoutGroup BeginVertGroup<T, TElement>(NeoModLoader.General.UI.Window.AutoLayoutGroup<T, TElement> pThis, UnityEngine.Vector2 pSize = null, UnityEngine.TextAnchor pAlignment = UpperCenter, float pSpacing = 3, UnityEngine.RectOffset pPadding = null)

## Namespace: NeoModLoader.ncms_compatible_layer

### private class NeoModLoader.ncms_compatible_layer.NCMSCompatibleLayer.<>c

#### Fields
- public static readonly NeoModLoader.ncms_compatible_layer.NCMSCompatibleLayer.<>c <>9
- public static System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax, bool> <>9__4_0
- public static System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, bool> <>9__4_1

#### Constructors
- private static NCMSCompatibleLayer.<>c()
- public NCMSCompatibleLayer.<>c()

#### Methods
- internal bool <IsNCMSMod>b__4_0(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax a)
- internal bool <IsNCMSMod>b__4_1(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax a)

### internal static class NeoModLoader.ncms_compatible_layer.NCMSCompatibleLayer

#### Fields
- public static const string modGlobalObject

#### Methods
- public static NCMS.NCMod GenerateNCMSMod(NeoModLoader.api.ModDeclare modDeclare)
- public static void Init()
- public static bool IsNCMSMod(Microsoft.CodeAnalysis.SyntaxTree syntaxTree)
- public static void PreInit()

## Namespace: NeoModLoader.services

### private class NeoModLoader.services.ExternalModInstallService.<>c

#### Fields
- public static readonly NeoModLoader.services.ExternalModInstallService.<>c <>9
- public static System.Func<System.Type, bool> <>9__0_0
- public static System.Func<System.Type, NeoModLoader.utils.installers.ACmdModInstaller> <>9__0_1

#### Constructors
- private static ExternalModInstallService.<>c()
- public ExternalModInstallService.<>c()

#### Methods
- internal bool <CheckExternalModInstall>b__0_0(System.Type type)
- internal NeoModLoader.utils.installers.ACmdModInstaller <CheckExternalModInstall>b__0_1(System.Type type)

### private class NeoModLoader.services.ModCompileLoadService.<>c

#### Fields
- public static readonly NeoModLoader.services.ModCompileLoadService.<>c <>9
- public static System.Func<string, Microsoft.CodeAnalysis.PortableExecutableReference> <>9__6_0
- public static System.Func<string, bool> <>9__6_1
- public static System.Func<string, bool> <>9__6_2
- public static System.Func<string, bool> <>9__9_0

#### Constructors
- private static ModCompileLoadService.<>c()
- public ModCompileLoadService.<>c()

#### Methods
- internal Microsoft.CodeAnalysis.PortableExecutableReference <compileMod>b__6_0(string inc)
- internal bool <compileMod>b__6_1(string file_name)
- internal bool <compileMod>b__6_2(string dir_name)
- internal bool <compileMod>b__9_0(string file)

### private class NeoModLoader.services.ModUploadAuthenticationService.<>c

#### Fields
- public static readonly NeoModLoader.services.ModUploadAuthenticationService.<>c <>9
- public static System.Action <>9__4_0

#### Constructors
- private static ModUploadAuthenticationService.<>c()
- public ModUploadAuthenticationService.<>c()

#### Methods
- internal void <AutoAuth>b__4_0()

### private class NeoModLoader.services.ModWorkshopService.<>c

#### Fields
- public static readonly NeoModLoader.services.ModWorkshopService.<>c <>9
- public static System.Func<string, bool> <>9__4_0
- public static System.Func<string, bool> <>9__4_1
- public static System.Func<string, bool> <>9__5_0
- public static System.Func<string, bool> <>9__5_1

#### Constructors
- private static ModWorkshopService.<>c()
- public ModWorkshopService.<>c()

#### Methods
- internal bool <TryEditMod>b__5_0(string filename)
- internal bool <TryEditMod>b__5_1(string dirname)
- internal bool <UploadMod>b__4_0(string filename)
- internal bool <UploadMod>b__4_1(string dirname)

### private class NeoModLoader.services.ModWorkshopServiceUnix.<>c

#### Fields
- public static readonly NeoModLoader.services.ModWorkshopServiceUnix.<>c <>9
- public static System.Action<System.Threading.Tasks.Task<Steamworks.Ugc.PublishResult>> <>9__2_0

#### Constructors
- private static ModWorkshopServiceUnix.<>c()
- public ModWorkshopServiceUnix.<>c()

#### Methods
- internal void <UploadModLoader>b__2_0(System.Threading.Tasks.Task<Steamworks.Ugc.PublishResult> taskResult)

### private class NeoModLoader.services.ModWorkshopServiceWindows.<>c

#### Fields
- public static readonly NeoModLoader.services.ModWorkshopServiceWindows.<>c <>9
- public static System.Action<System.Threading.Tasks.Task<Steamworks.Ugc.PublishResult>> <>9__2_0

#### Constructors
- private static ModWorkshopServiceWindows.<>c()
- public ModWorkshopServiceWindows.<>c()

#### Methods
- internal void <UploadModLoader>b__2_0(System.Threading.Tasks.Task<Steamworks.Ugc.PublishResult> taskResult)

### private struct NeoModLoader.services.ModCompileLoadService.<>c__DisplayClass11_0

#### Fields
- public NeoModLoader.api.ModDeclare pMod

### private class NeoModLoader.services.ModCompileLoadService.<>c__DisplayClass17_0

#### Fields
- public System.Func<UnityEngine.MonoBehaviour, bool> <>9__0
- public NeoModLoader.api.ModDeclare mod

#### Constructors
- public ModCompileLoadService.<>c__DisplayClass17_0()

#### Methods
- internal bool <loadInfoOfBepInExPlugins>b__0(UnityEngine.MonoBehaviour component)

### private class NeoModLoader.services.ModWorkshopServiceUnix.<>c__DisplayClass3_0

#### Fields
- public RSG.Promise promise

#### Constructors
- public ModWorkshopServiceUnix.<>c__DisplayClass3_0()

#### Methods
- internal void <UploadMod>b__0(System.Threading.Tasks.Task<Steamworks.Ugc.PublishResult> taskResult)

### private class NeoModLoader.services.ModWorkshopServiceWindows.<>c__DisplayClass3_0

#### Fields
- public RSG.Promise promise

#### Constructors
- public ModWorkshopServiceWindows.<>c__DisplayClass3_0()

#### Methods
- internal void <UploadMod>b__0(System.Threading.Tasks.Task<Steamworks.Ugc.PublishResult> taskResult)

### private class NeoModLoader.services.ModWorkshopServiceUnix.<>c__DisplayClass4_0

#### Fields
- public RSG.Promise promise

#### Constructors
- public ModWorkshopServiceUnix.<>c__DisplayClass4_0()

#### Methods
- internal void <EditMod>b__0(System.Threading.Tasks.Task<Steamworks.Ugc.PublishResult> taskResult)

### private class NeoModLoader.services.ModWorkshopServiceWindows.<>c__DisplayClass4_0

#### Fields
- public RSG.Promise promise

#### Constructors
- public ModWorkshopServiceWindows.<>c__DisplayClass4_0()

#### Methods
- internal void <EditMod>b__0(System.Threading.Tasks.Task<Steamworks.Ugc.PublishResult> taskResult)

### private class NeoModLoader.services.ModUploadAuthenticationService.<>c__DisplayClass5_0

#### Fields
- public RSG.Promise promise

#### Constructors
- public ModUploadAuthenticationService.<>c__DisplayClass5_0()

#### Methods
- internal void <Authenticate>b__0()
- internal void <Authenticate>b__1()

### private struct NeoModLoader.services.ModCompileLoadService.<>c__DisplayClass6_0

#### Fields
- public string[] pAddInc
- public NeoModLoader.api.ModDeclare pModDecl

### private class NeoModLoader.services.ModCompileLoadService.<>c__DisplayClass6_1

#### Fields
- public string file

#### Constructors
- public ModCompileLoadService.<>c__DisplayClass6_1()

#### Methods
- internal System.IO.Stream <compileMod>b__4()

### private class NeoModLoader.services.ExternalModInstallService.<CheckExternalModInstall>d__0
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Collections.Generic.List<T>.Enumerator<string> <>s__4
- private System.Collections.Generic.List<T>.Enumerator<NeoModLoader.utils.installers.ACmdModInstaller> <>s__6
- private bool <>s__9
- public System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<bool> <>u__1
- private string <arg>5__5
- private System.Collections.Generic.List<string> <args>5__1
- private System.Collections.Generic.List<NeoModLoader.utils.installers.ACmdModInstaller> <cmd_installers>5__3
- private int <i>5__8
- private NeoModLoader.utils.installers.ACmdModInstaller <installer>5__7
- private System.Type[] <types>5__2

#### Constructors
- public ExternalModInstallService.<CheckExternalModInstall>d__0()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class NeoModLoader.services.ModWorkshopServiceUnix.<FindSubscribedMods>d__5
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public NeoModLoader.services.ModWorkshopServiceUnix <>4__this
- private System.Collections.Generic.List<Steamworks.Ugc.Item> <>s__2
- private System.Collections.Generic.List<T>.Enumerator<Steamworks.Ugc.Item> <>s__3
- public System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<Steamworks.Ugc.Item>> <>u__1
- private Steamworks.Ugc.Item <item>5__4
- private System.Collections.Generic.List<Steamworks.Ugc.Item> <items>5__1

#### Constructors
- public ModWorkshopServiceUnix.<FindSubscribedMods>d__5()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class NeoModLoader.services.ModWorkshopServiceWindows.<FindSubscribedMods>d__6
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public NeoModLoader.services.ModWorkshopServiceWindows <>4__this
- private System.Collections.Generic.List<Steamworks.Ugc.Item> <>s__2
- private System.Collections.Generic.List<T>.Enumerator<Steamworks.Ugc.Item> <>s__3
- public System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<Steamworks.Ugc.Item>> <>u__1
- private Steamworks.Ugc.Item <item>5__4
- private System.Collections.Generic.List<Steamworks.Ugc.Item> <items>5__1

#### Constructors
- public ModWorkshopServiceWindows.<FindSubscribedMods>d__6()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class NeoModLoader.services.ModWorkshopServiceUnix.<GetSubscribedItems>d__7
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Ugc.ResultPage> <>s__6
- private System.Collections.Generic.IEnumerator<Steamworks.Ugc.Item> <>s__7
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.List<Steamworks.Ugc.Item>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<Steamworks.Ugc.ResultPage>> <>u__1
- private int <count>5__2
- private int <curr>5__3
- private Steamworks.Ugc.Item <entry>5__8
- private int <page>5__4
- private Steamworks.Ugc.Query <q>5__1
- private System.Nullable<Steamworks.Ugc.ResultPage> <resultPage>5__5

#### Constructors
- public ModWorkshopServiceUnix.<GetSubscribedItems>d__7()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class NeoModLoader.services.ModWorkshopServiceWindows.<GetSubscribedItems>d__7
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Ugc.ResultPage> <>s__6
- private System.Collections.Generic.IEnumerator<Steamworks.Ugc.Item> <>s__7
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.List<Steamworks.Ugc.Item>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<Steamworks.Ugc.ResultPage>> <>u__1
- private int <count>5__2
- private int <curr>5__3
- private Steamworks.Ugc.Item <entry>5__8
- private int <page>5__4
- private Steamworks.Ugc.Query <q>5__1
- private System.Nullable<Steamworks.Ugc.ResultPage> <resultPage>5__5

#### Constructors
- public ModWorkshopServiceWindows.<GetSubscribedItems>d__7()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class NeoModLoader.services.LogService.ConcurrentLogHandle
- Base: UnityEngine.MonoBehaviour

#### Constructors
- public LogService.ConcurrentLogHandle()

#### Methods
- private void Update()

### internal static class NeoModLoader.services.ExternalModInstallService

#### Methods
- public static void CheckExternalModInstall()

### internal interface NeoModLoader.services.IPlatformSpecificModWorkshopService

#### Methods
- public RSG.Promise EditMod(ulong fileID, string previewImagePath, string workshopPath, string changelog)
- public void FindSubscribedMods()
- public NeoModLoader.api.ModDeclare GetNextModFromWorkshopItem()
- public RSG.Promise UploadMod(string name, string description, string previewImagePath, string workshopPath, string changelog, bool verified)
- public void UploadModLoader(string changelog)

### public static class NeoModLoader.services.LogService

#### Fields
- private static readonly System.Collections.Concurrent.ConcurrentQueue<NeoModLoader.services.LogService.WrappedMessage> concurrent_log_queue
- private static const int pool_size
- private static System.Collections.Concurrent.ConcurrentBag<NeoModLoader.services.LogService.WrappedMessage> _pool

#### Constructors
- private static LogService()

#### Methods
- internal static void Init()
- public static void LogError(string message)
- public static void LogErrorConcurrent(string message)
- public static void LogException(System.Exception exception)
- public static void LogInfo(string message)
- public static void LogInfoConcurrent(string message)
- public static void LogStackTraceAsError()
- public static void LogStackTraceAsInfo()
- public static void LogStackTraceAsWarning()
- public static void LogWarning(string message)
- public static void LogWarningConcurrent(string message)
- public static void PullAllConcurrentLogToCurrentThread()

### private enum NeoModLoader.services.LogService.LogType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Error = 2
- Info = 0
- Warning = 1

### public static class NeoModLoader.services.ModCompileLoadService

#### Fields
- private static readonly System.Collections.Generic.Dictionary<string, string> mod_inc_path
- private static readonly System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.MetadataReference> mod_ref
- private static Microsoft.CodeAnalysis.MetadataReference[] _default_ref
- private static string[] _default_ref_path
- private static readonly System.Collections.Generic.HashSet<string> _loaded_ref
- private static Microsoft.CodeAnalysis.MetadataReference _publicized_assembly_ref

#### Constructors
- private static ModCompileLoadService()

#### Methods
- internal static void <compileMod>g__LoadAddInc|6_3(ref NeoModLoader.services.ModCompileLoadService.<>c__DisplayClass6_0 )
- internal static void <LoadMod>g__auto_localize|11_0(object mod_component, ref NeoModLoader.services.ModCompileLoadService.<>c__DisplayClass11_0 )
- private static bool compileMod(NeoModLoader.api.ModDeclare pModDecl, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference> pDefaultInc, string[] pAddInc, System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.MetadataReference> pModInc, bool pForce = false, bool pDisableOptionalDepen = false)
- public static bool compileMod(NeoModLoader.utils.ModDependencyNode pModNode, bool pForce = false)
- public static bool IsModLoaded(string uid)
- public static void loadInfoOfBepInExPlugins()
- public static void LoadMod(NeoModLoader.api.ModDeclare pMod)
- public static void loadMods(System.Collections.Generic.List<NeoModLoader.api.ModDeclare> mods_to_load)
- public static void PostInitMod(NeoModLoader.api.IMod mod)
- public static void prepareCompile(System.Collections.Generic.List<NeoModLoader.utils.ModDependencyNode> pModNodes)
- public static void prepareCompileRuntime(NeoModLoader.utils.ModDependencyNode pModNode)
- public static bool TryCompileAndLoadModAtRuntime(NeoModLoader.api.ModDeclare mod_declare)
- public static bool TryCompileModAtRuntime(NeoModLoader.api.ModDeclare pModDeclare, bool pForce = false)
- public static bool TryInitMod(NeoModLoader.api.IMod mod)

### internal static class NeoModLoader.services.ModDepenSolveService

#### Fields
- private static NeoModLoader.utils.ModDependencyGraph graph

#### Methods
- public static System.Collections.Generic.List<NeoModLoader.utils.ModDependencyNode> SolveModDependencies(System.Collections.Generic.List<NeoModLoader.api.ModDeclare> mods)
- public static NeoModLoader.utils.ModDependencyNode SolveModDependencyRuntime(NeoModLoader.api.ModDeclare mod)

### internal static class NeoModLoader.services.ModReloadService

#### Methods
- public static bool HotfixMethods(NeoModLoader.api.IReloadable pMod, NeoModLoader.api.ModDeclare pModDeclare)
- public static void ReloadLocales(NeoModLoader.api.IMod pMod)
- public static bool ReloadResources(NeoModLoader.api.IMod pMod)

### public static class NeoModLoader.services.ModUploadAuthenticationService

#### Fields
- private static bool <Authed>k__BackingField

#### Properties
- public static bool Authed { get; private set; }

#### Methods
- public static RSG.Promise Authenticate()
- public static void AutoAuth()

### internal static class NeoModLoader.services.ModWorkshopService

#### Fields
- internal static RSG.Promise steamWorkshopPromise
- private static NeoModLoader.services.IPlatformSpecificModWorkshopService workshopServiceBackend

#### Methods
- public static void FindSubscribedMods()
- public static NeoModLoader.api.ModDeclare GetNextModFromWorkshopItem()
- public static void Init()
- public static RSG.Promise TryEditMod(ulong fileID, NeoModLoader.api.IMod mod, string changelog)
- public static RSG.Promise UploadMod(NeoModLoader.api.IMod mod, string changelog, bool verified = false)
- private static void UploadModLoader(string changelog)

### internal class NeoModLoader.services.ModWorkshopServiceUnix
- Interfaces: NeoModLoader.services.IPlatformSpecificModWorkshopService

#### Fields
- private static System.Collections.Generic.List<Steamworks.Ugc.Item> subscribedItems
- private static System.Collections.Generic.Queue<Steamworks.Ugc.Item> subscribedModsQueue

#### Constructors
- public ModWorkshopServiceUnix()
- private static ModWorkshopServiceUnix()

#### Methods
- internal static bool <GetSubscribedItems>g__available|7_0(Steamworks.Ugc.Item item)
- public RSG.Promise EditMod(ulong fileID, string previewImagePath, string workshopPath, string changelog)
- public void FindSubscribedMods()
- public NeoModLoader.api.ModDeclare GetNextModFromWorkshopItem()
- private static System.Threading.Tasks.Task<System.Collections.Generic.List<Steamworks.Ugc.Item>> GetSubscribedItems()
- public RSG.Promise UploadMod(string name, string description, string previewImagePath, string workshopPath, string changelog, bool verified)
- public void UploadModLoader(string changelog)

### internal class NeoModLoader.services.ModWorkshopServiceWindows
- Interfaces: NeoModLoader.services.IPlatformSpecificModWorkshopService

#### Fields
- private static System.Collections.Generic.List<Steamworks.Ugc.Item> subscribedItems
- private static System.Collections.Generic.Queue<Steamworks.Ugc.Item> subscribedModsQueue

#### Constructors
- public ModWorkshopServiceWindows()
- private static ModWorkshopServiceWindows()

#### Methods
- internal static bool <GetSubscribedItems>g__available|7_0(Steamworks.Ugc.Item item)
- public RSG.Promise EditMod(ulong fileID, string previewImagePath, string workshopPath, string changelog)
- public void FindSubscribedMods()
- public NeoModLoader.api.ModDeclare GetNextModFromWorkshopItem()
- private static System.Threading.Tasks.Task<System.Collections.Generic.List<Steamworks.Ugc.Item>> GetSubscribedItems()
- public RSG.Promise UploadMod(string name, string description, string previewImagePath, string workshopPath, string changelog, bool verified)
- public void UploadModLoader(string changelog)

### private class NeoModLoader.services.LogService.WrappedMessage

#### Fields
- public string message
- public NeoModLoader.services.LogService.LogType type

#### Constructors
- public LogService.WrappedMessage(string message, NeoModLoader.services.LogService.LogType type)

#### Methods
- public void Reset(string message, NeoModLoader.services.LogService.LogType type)

## Namespace: NeoModLoader.ui

### private class NeoModLoader.ui.ModListWindow.<>c

#### Fields
- public static readonly NeoModLoader.ui.ModListWindow.<>c <>9
- public static UnityEngine.Events.UnityAction <>9__6_0
- public static UnityEngine.Events.UnityAction <>9__6_1

#### Constructors
- private static ModListWindow.<>c()
- public ModListWindow.<>c()

#### Methods
- internal void <Init>b__6_0()
- internal void <Init>b__6_1()

### private class NeoModLoader.ui.ModUploadAuthenticationWindow.<>c

#### Fields
- public static readonly NeoModLoader.ui.ModUploadAuthenticationWindow.<>c <>9

#### Constructors
- private static ModUploadAuthenticationWindow.<>c()
- public ModUploadAuthenticationWindow.<>c()

#### Methods
- internal bool <.cctor>b__17_0()

### private class NeoModLoader.ui.ModUploadWindow.<>c

#### Fields
- public static readonly NeoModLoader.ui.ModUploadWindow.<>c <>9
- public static System.Func<char, bool> <>9__10_1
- public static UnityEngine.Events.UnityAction<string> <>9__9_0
- public static UnityEngine.Events.UnityAction<string> <>9__9_2

#### Constructors
- private static ModUploadWindow.<>c()
- public ModUploadWindow.<>c()

#### Methods
- internal void <Init>b__9_0(string fileid)
- internal void <Init>b__9_2(string fileid)
- internal bool <uploadSelectedMod>b__10_1(char c)

### private class NeoModLoader.ui.WorkshopModListWindow.<>c

#### Fields
- public static readonly NeoModLoader.ui.WorkshopModListWindow.<>c <>9
- public static System.Action<System.Exception> <>9__4_0

#### Constructors
- private static WorkshopModListWindow.<>c()
- public WorkshopModListWindow.<>c()

#### Methods
- internal void <OnNormalEnable>b__4_0(System.Exception err)

### private class NeoModLoader.ui.WorkshopModListWindow.WorkshopModListItem.<>c__DisplayClass0_0

#### Fields
- public NeoModLoader.api.ModDeclare modDeclare

#### Constructors
- public WorkshopModListWindow.WorkshopModListItem.<>c__DisplayClass0_0()

#### Methods
- internal void <Setup>b__0()
- internal void <Setup>b__1()

### private class NeoModLoader.ui.NewModListWindow.<>c__DisplayClass15_0

#### Fields
- public NeoModLoader.ui.NewModListWindow <>4__this
- public NeoModLoader.api.ModDeclare local_mod

#### Constructors
- public NewModListWindow.<>c__DisplayClass15_0()

#### Methods
- internal void <ShowMods>b__0()

### private class NeoModLoader.ui.ModListWindow.ModListItem.<>c__DisplayClass2_0

#### Fields
- public NeoModLoader.ui.ModListWindow.ModListItem <>4__this
- public NeoModLoader.api.IConfigurable configurable
- public string current_state_text
- public UnityEngine.UI.Image icon
- public TipButton icon_tip_button
- public NeoModLoader.api.IMod mod
- public NeoModLoader.api.ModDeclare mod_declare
- public string next_state_text
- public NeoModLoader.api.IReloadable reloadable
- public UnityEngine.UI.Text state_text

#### Constructors
- public ModListWindow.ModListItem.<>c__DisplayClass2_0()

#### Methods
- internal void <Setup>b__0()
- internal void <Setup>b__1()
- internal void <Setup>b__2()
- internal void <Setup>b__3()
- internal void <Setup>b__4()
- internal void <Setup>b__5()
- internal void <Setup>b__6()

### private class NeoModLoader.ui.ModConfigureWindow.ModConfigListItem.<>c__DisplayClass5_0

#### Fields
- public NeoModLoader.api.ModConfigItem pItem

#### Constructors
- public ModConfigureWindow.ModConfigListItem.<>c__DisplayClass5_0()

#### Methods
- internal void <setup_text>b__0(string pStringVal)

### private class NeoModLoader.ui.ModConfigureWindow.ModConfigListItem.<>c__DisplayClass6_0

#### Fields
- public NeoModLoader.api.ModConfigItem pItem
- public UnityEngine.UI.Text value

#### Constructors
- public ModConfigureWindow.ModConfigListItem.<>c__DisplayClass6_0()

#### Methods
- internal void <setup_slider>b__0(float pFloatVal)

### private class NeoModLoader.ui.ModConfigureWindow.ModConfigListItem.<>c__DisplayClass7_0

#### Fields
- public NeoModLoader.api.ModConfigItem pItem
- public UnityEngine.UI.Text value

#### Constructors
- public ModConfigureWindow.ModConfigListItem.<>c__DisplayClass7_0()

#### Methods
- internal void <setup_int_slider>b__0(float pIntVal)

### private class NeoModLoader.ui.ModConfigureWindow.ModConfigListItem.<>c__DisplayClass8_0

#### Fields
- public NeoModLoader.api.ModConfigItem pItem

#### Constructors
- public ModConfigureWindow.ModConfigListItem.<>c__DisplayClass8_0()

#### Methods
- internal void <setup_switch>b__0()

### private class NeoModLoader.ui.ModUploadAuthenticationWindow.<>c__DisplayClass9_0

#### Fields
- public NeoModLoader.ui.ModUploadAuthenticationWindow <>4__this
- public System.Func<bool> pAuthFunc

#### Constructors
- public ModUploadAuthenticationWindow.<>c__DisplayClass9_0()

#### Methods
- internal void <CreateAuthButton>b__0()

### private struct NeoModLoader.ui.ModUploadWindow.<>c__DisplayClass9_0

#### Fields
- public UnityEngine.GameObject info_grids

### private static class NeoModLoader.ui.ModUploadAuthenticationWindow.<>O

#### Fields
- public static System.Func<bool> <0>__Authenticate
- public static System.Func<bool> <1>__Authenticate

### private static class NeoModLoader.ui.ModUploadWindow.<>O

#### Fields
- public static System.Action <0>__FinishUpload
- public static System.Action<System.Exception> <1>__ErrorUpload

### private static class NeoModLoader.ui.WorkshopModListWindow.<>O

#### Fields
- public static System.Action <0>__FindSubscribedMods

### private class NeoModLoader.ui.ModListWindow.ModListItem.<WaitOpenWindow>d__1
- Interfaces: System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private object <>2__current
- public NeoModLoader.ui.ModListWindow.ModListItem <>4__this

#### Properties
- private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public ModListWindow.ModListItem.<WaitOpenWindow>d__1(int <>1__state)

#### Methods
- private bool MoveNext()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private enum NeoModLoader.ui.NewModListWindow.DisplayType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Mod = 0
- Resource = 1

### public class NeoModLoader.ui.InformationWindow
- Base: NeoModLoader.General.UI.Window.SingleAutoLayoutWindow<NeoModLoader.ui.InformationWindow>

#### Fields
- private System.Action on_close
- private UnityEngine.UI.Text text

#### Constructors
- public InformationWindow()

#### Methods
- public static void Back()
- public static void HideWindow()
- protected override void Init()
- public override void OnNormalDisable()
- public static void ShowWindow(string info, System.Action on_close = null)

### private class NeoModLoader.ui.ModConfigureWindow.ModConfigGrid
- Base: UnityEngine.MonoBehaviour

#### Fields
- private UnityEngine.Transform grid
- private UnityEngine.UI.Text title

#### Constructors
- public ModConfigureWindow.ModConfigGrid()

#### Methods
- private void OnEnable()
- public void Setup(string id, System.Collections.Generic.Dictionary<string, NeoModLoader.api.ModConfigItem> items)

### private class NeoModLoader.ui.ModConfigureWindow.ModConfigListItem
- Base: UnityEngine.MonoBehaviour

#### Fields
- public UnityEngine.GameObject select_area
- public UnityEngine.GameObject slider_area
- public UnityEngine.GameObject switch_area
- public UnityEngine.GameObject text_area

#### Constructors
- public ModConfigureWindow.ModConfigListItem()

#### Methods
- public void Setup(NeoModLoader.api.ModConfigItem pItem)
- private void setup_int_slider(NeoModLoader.api.ModConfigItem pItem)
- private void setup_slider(NeoModLoader.api.ModConfigItem pItem)
- private void setup_switch(NeoModLoader.api.ModConfigItem pItem)
- private void setup_text(NeoModLoader.api.ModConfigItem pItem)

### public class NeoModLoader.ui.ModConfigureWindow
- Base: NeoModLoader.api.AbstractWindow<NeoModLoader.ui.ModConfigureWindow>

#### Fields
- private NeoModLoader.api.ModConfig _config
- private static ObjectPoolGenericMono<NeoModLoader.ui.ModConfigureWindow.ModConfigGrid> _gridPool
- private static NeoModLoader.ui.ModConfigureWindow.ModConfigGrid _gridPrefab
- private static ObjectPoolGenericMono<NeoModLoader.ui.ModConfigureWindow.ModConfigListItem> _itemPool
- private static NeoModLoader.ui.ModConfigureWindow.ModConfigListItem _itemPrefab
- private readonly System.Collections.Generic.Dictionary<NeoModLoader.api.ModConfigItem, object> _modifiedItems

#### Constructors
- public ModConfigureWindow()

#### Methods
- protected override void Init()
- public override void OnNormalDisable()
- public override void OnNormalEnable()
- public static void ShowWindow(NeoModLoader.api.ModConfig pConfig)
- private static void _createGridPrefab()
- private static void _createItemPrefab()

### public class NeoModLoader.ui.ModListWindow.ModListItem
- Base: NeoModLoader.api.AbstractListWindowItem<NeoModLoader.api.IMod>

#### Fields
- private NeoModLoader.api.IMod _mod

#### Constructors
- public ModListWindow.ModListItem()

#### Methods
- public override void Setup(NeoModLoader.api.IMod mod)
- private System.Collections.IEnumerator WaitOpenWindow()

### public class NeoModLoader.ui.ModListWindow
- Base: NeoModLoader.api.AbstractListWindow<NeoModLoader.ui.ModListWindow, NeoModLoader.api.IMod>

#### Fields
- private NeoModLoader.api.ModDeclare clickedMod
- private int clickTimes
- private float lastClickTime
- private bool needRefresh
- private readonly System.Collections.Generic.Queue<NeoModLoader.api.IMod> to_add

#### Constructors
- public ModListWindow()

#### Methods
- protected override NeoModLoader.api.AbstractListWindowItem<NeoModLoader.api.IMod> CreateItemPrefab()
- protected override void Init()
- public override void OnNormalEnable()
- private void Update()

### internal class NeoModLoader.ui.ModUploadAuthenticationWindow
- Base: NeoModLoader.api.AbstractWindow<NeoModLoader.ui.ModUploadAuthenticationWindow>

#### Fields
- internal static System.Collections.Generic.List<System.Func<bool>> all_auto_auth_funcs
- internal System.Func<bool> AuthFunc
- internal bool AuthFuncSelected
- internal bool AuthSkipped
- private UnityEngine.Transform auth_grid_transform
- private UnityEngine.UI.Text auth_text
- private LocalizedText localized_auth_text
- private static UnityEngine.UI.Button prefab_auth_button

#### Constructors
- public ModUploadAuthenticationWindow()
- private static ModUploadAuthenticationWindow()

#### Methods
- private UnityEngine.UI.Button CreateAuthButton(string pId, UnityEngine.Sprite pIcon, System.Func<bool> pAuthFunc, UnityEngine.Vector2 pIconSize = null)
- private UnityEngine.UI.Button CreateAuthButton(string pId, string pIconPath, System.Func<bool> pAuthFunc, UnityEngine.Vector2 pIconSize = null)
- protected override void Init()
- public override void OnNormalDisable()
- public override void OnNormalEnable()
- public bool Opened()
- public static void SetState(bool pAuthState, string pTipText = null)
- public static void SetText(string pText, UnityEngine.Color pColor = null)

### internal class NeoModLoader.ui.ModUploadingProgressWindow
- Base: NeoModLoader.api.AbstractWindow<NeoModLoader.ui.ModUploadingProgressWindow>

#### Fields
- private UnityEngine.UI.Image bar
- internal ulong fileId
- private UnityEngine.UI.Text percent
- private float progress
- private float real_progress
- private float start_time
- private bool uploading
- private NeoModLoader.ui.ModUploadingProgressWindow.UploadProgress uploadProgress

#### Constructors
- public ModUploadingProgressWindow()

#### Methods
- public static void ErrorUpload(System.Exception obj)
- public static void FinishUpload()
- protected override void Init()
- public override void OnNormalDisable()
- public override void OnNormalEnable()
- public static NeoModLoader.ui.ModUploadingProgressWindow.UploadProgress ShowWindow()
- private void Update()
- private void UpdateDisplay()

### internal class NeoModLoader.ui.ModUploadWindow
- Base: NeoModLoader.api.AbstractWindow<NeoModLoader.ui.ModUploadWindow>

#### Fields
- private UnityEngine.UI.Text changelog_text
- private UnityEngine.UI.Text mod_author_text
- private UnityEngine.UI.Text mod_description_text
- private UnityEngine.UI.Text mod_fileid_text
- private UnityEngine.UI.Image mod_icon_image
- private UnityEngine.UI.Text mod_name_text
- private UnityEngine.UI.Text mod_version_text
- private NeoModLoader.api.IMod selected_mod

#### Constructors
- public ModUploadWindow()

#### Methods
- internal static UnityEngine.UI.Text <Init>g__create_grid_text|9_1(string name, ref NeoModLoader.ui.ModUploadWindow.<>c__DisplayClass9_0 )
- private RSG.IPromise <uploadSelectedMod>b__10_0()
- protected override void Init()
- public static void ShowWindow(NeoModLoader.api.IMod mod)
- private void uploadSelectedMod()

### internal class NeoModLoader.ui.NewModListWindow
- Base: NeoModLoader.api.AbstractWideWindow<NeoModLoader.ui.NewModListWindow>

#### Fields
- private NeoModLoader.ui.NewModListWindow.DisplayType CurrentDisplayType
- private NeoModLoader.api.ModDeclare CurrentSelected
- private ObjectPoolGenericMono<NeoModLoader.ui.prefabs.ModListItem> ListItemPool
- private UnityEngine.RectTransform ListPart
- private System.Collections.Generic.List<NeoModLoader.api.ModDeclare> ListToShow
- private NeoModLoader.General.UI.Prefabs.SimpleButton ModCommunityButton
- private NeoModLoader.General.UI.Prefabs.SimpleButton ModConfigureButton
- private readonly System.Collections.Generic.Dictionary<NeoModLoader.api.ModDeclare, NeoModLoader.ui.prefabs.ModInfoPanel> ModInfoPanels
- private UnityEngine.RectTransform ModInfoPart
- private NeoModLoader.General.UI.Prefabs.SimpleButton OpenModFolderButton
- private NeoModLoader.General.UI.Prefabs.SimpleButton ReloadModButton
- private NeoModLoader.General.UI.Prefabs.SimpleButton ToggleModButton
- private NeoModLoader.General.UI.Prefabs.SimpleButton UploadModButton

#### Constructors
- public NewModListWindow()

#### Methods
- private void Clean()
- private void CommunityOfSelectedMod()
- private void ConfigureSelectedMod()
- private void FolderOfSelectedMod()
- protected override void Init()
- public override void OnFirstEnable()
- public override void OnNormalEnable()
- private void RefreshControlPart()
- private void RefreshInfoPart()
- private void ReloadSelectedMod()
- private void Select(NeoModLoader.api.ModDeclare pDeclare)
- private void ShowMods()
- private void ShowResources()
- private void ToggleSelectedMod()
- private void UploadSelectedMod()

### internal static class NeoModLoader.ui.UIManager

#### Methods
- public static void init()

### public class NeoModLoader.ui.ModUploadingProgressWindow.UploadProgress
- Interfaces: System.IProgress<float>

#### Constructors
- public ModUploadingProgressWindow.UploadProgress()

#### Methods
- public void Report(float value)
- public void Reset()

### public class NeoModLoader.ui.WorkshopModListWindow.WorkshopModListItem
- Base: NeoModLoader.api.AbstractListWindowItem<NeoModLoader.api.ModDeclare>

#### Constructors
- public WorkshopModListWindow.WorkshopModListItem()

#### Methods
- public override void Setup(NeoModLoader.api.ModDeclare modDeclare)

### internal class NeoModLoader.ui.WorkshopModListWindow
- Base: NeoModLoader.api.AbstractListWindow<NeoModLoader.ui.WorkshopModListWindow, NeoModLoader.api.ModDeclare>

#### Fields
- private float checkTimer
- private System.Collections.Generic.HashSet<string> showedMods

#### Constructors
- public WorkshopModListWindow()

#### Methods
- protected override void AddItemToList(NeoModLoader.api.ModDeclare item)
- protected override NeoModLoader.api.AbstractListWindowItem<NeoModLoader.api.ModDeclare> CreateItemPrefab()
- protected override void Init()
- public override void OnNormalEnable()
- private void showNextMod()
- private void Update()

## Namespace: NeoModLoader.ui.prefabs

### private class NeoModLoader.ui.prefabs.ModInfoPanel.<>c__DisplayClass0_0

#### Fields
- public NeoModLoader.api.ModDeclare pModDeclaration

#### Constructors
- public ModInfoPanel.<>c__DisplayClass0_0()

#### Methods
- internal bool <Setup>b__0(NeoModLoader.api.IMod x)

### public class NeoModLoader.ui.prefabs.ModInfoPanel
- Base: NeoModLoader.General.UI.Prefabs.APrefab<NeoModLoader.ui.prefabs.ModInfoPanel>

#### Constructors
- public ModInfoPanel()

#### Methods
- internal void Setup(NeoModLoader.api.ModDeclare pModDeclaration)
- private static void _init()

### internal class NeoModLoader.ui.prefabs.ModListItem
- Base: NeoModLoader.General.UI.Prefabs.APrefab<NeoModLoader.ui.prefabs.ModListItem>

#### Fields
- private UnityEngine.UI.Image icon
- private UnityEngine.UI.Text text

#### Constructors
- public ModListItem()

#### Methods
- protected override void Init()
- public void Setup(NeoModLoader.api.ModDeclare pDeclare, System.Action pAction)
- private static void _init()

## Namespace: NeoModLoader.utils

### private class NeoModLoader.utils.ModInfoUtils.<>c

#### Fields
- public static readonly NeoModLoader.utils.ModInfoUtils.<>c <>9
- public static System.Func<string, bool> <>9__13_0
- public static System.Func<string, bool> <>9__13_1
- public static System.Func<string, bool> <>9__23_0
- public static System.Func<string, bool> <>9__23_1
- public static System.Func<string, System.IO.FileInfo> <>9__23_2
- public static System.Func<System.IO.FileInfo, long> <>9__23_3
- public static System.Func<string, bool> <>9__5_0
- public static System.Func<string, bool> <>9__5_1

#### Constructors
- private static ModInfoUtils.<>c()
- public ModInfoUtils.<>c()

#### Methods
- internal bool <getModNewestUpdateTimestamp>b__23_0(string filename)
- internal bool <getModNewestUpdateTimestamp>b__23_1(string dirname)
- internal System.IO.FileInfo <getModNewestUpdateTimestamp>b__23_2(string filepath)
- internal long <getModNewestUpdateTimestamp>b__23_3(System.IO.FileInfo file_info)
- internal bool <recogMod>b__13_0(string file_name)
- internal bool <recogMod>b__13_1(string _)
- internal bool <TryToUnzipModZip>b__5_0(string filename)
- internal bool <TryToUnzipModZip>b__5_1(string dirname)

### private class NeoModLoader.utils.ModReloadUtils.<>c

#### Fields
- public static readonly NeoModLoader.utils.ModReloadUtils.<>c <>9
- public static System.Func<Mono.Cecil.TypeDefinition, System.Collections.Generic.IEnumerable<Mono.Cecil.MethodDefinition>> <>9__11_0
- public static System.Func<Mono.Cecil.TypeDefinition, System.Collections.Generic.IEnumerable<Mono.Cecil.MethodDefinition>> <>9__12_0
- public static System.Func<Mono.Cecil.TypeDefinition, System.Collections.Generic.IEnumerable<Mono.Cecil.TypeDefinition>> <>9__12_1
- public static System.Func<Mono.Cecil.ParameterDefinition, System.Type> <>9__12_2
- public static System.Func<Mono.Cecil.ParameterDefinition, System.Type> <>9__12_3
- public static System.Func<Mono.Cecil.TypeDefinition, System.Collections.Generic.IEnumerable<Mono.Cecil.MethodDefinition>> <>9__17_0
- public static System.Func<Mono.Cecil.TypeDefinition, System.Collections.Generic.IEnumerable<Mono.Cecil.TypeDefinition>> <>9__17_1
- public static System.Func<Mono.Cecil.ParameterDefinition, System.Type> <>9__17_2
- public static System.Func<Mono.Cecil.ParameterDefinition, System.Type> <>9__18_0
- public static System.Func<Mono.Cecil.ParameterDefinition, System.Type> <>9__21_0

#### Constructors
- private static ModReloadUtils.<>c()
- public ModReloadUtils.<>c()

#### Methods
- internal System.Collections.Generic.IEnumerable<Mono.Cecil.MethodDefinition> <CompileNew>b__11_0(Mono.Cecil.TypeDefinition nested_type)
- internal System.Type <CreateMethod>b__18_0(Mono.Cecil.ParameterDefinition x)
- internal System.Collections.Generic.IEnumerable<Mono.Cecil.MethodDefinition> <PatchHotfixMethods>b__12_0(Mono.Cecil.TypeDefinition type)
- internal System.Collections.Generic.IEnumerable<Mono.Cecil.TypeDefinition> <PatchHotfixMethods>b__12_1(Mono.Cecil.TypeDefinition type)
- internal System.Type <PatchHotfixMethods>b__12_2(Mono.Cecil.ParameterDefinition x)
- internal System.Type <PatchHotfixMethods>b__12_3(Mono.Cecil.ParameterDefinition x)
- internal System.Collections.Generic.IEnumerable<Mono.Cecil.MethodDefinition> <PatchHotfixMethodsNT>b__17_0(Mono.Cecil.TypeDefinition type)
- internal System.Collections.Generic.IEnumerable<Mono.Cecil.TypeDefinition> <PatchHotfixMethodsNT>b__17_1(Mono.Cecil.TypeDefinition type)
- internal System.Type <PatchHotfixMethodsNT>b__17_2(Mono.Cecil.ParameterDefinition x)
- internal System.Type <regenerate>b__21_0(Mono.Cecil.ParameterDefinition x)

### private class NeoModLoader.utils.ReflectionHelper.<>c

#### Fields
- public static readonly NeoModLoader.utils.ReflectionHelper.<>c <>9
- public static System.Func<System.Reflection.ParameterInfo, int, System.Linq.Expressions.ParameterExpression> <>9__7_0

#### Constructors
- private static ReflectionHelper.<>c()
- public ReflectionHelper.<>c()

#### Methods
- internal System.Linq.Expressions.ParameterExpression <createMethodDelegate>b__7_0(System.Reflection.ParameterInfo p, int i)

### private class NeoModLoader.utils.ResourcesPatch.<>c

#### Fields
- public static readonly NeoModLoader.utils.ResourcesPatch.<>c <>9
- public static System.Func<UnityEngine.Object, string> <>9__11_0
- public static System.Func<UnityEngine.U2D.SpriteAtlas, bool> <>9__3_0
- public static System.Func<string, bool> <>9__8_0
- public static System.Func<string, bool> <>9__8_1

#### Constructors
- private static ResourcesPatch.<>c()
- public ResourcesPatch.<>c()

#### Methods
- internal bool <Initialize>b__3_0(UnityEngine.U2D.SpriteAtlas x)
- internal string <LoadAll_Postfix>b__11_0(UnityEngine.Object x)
- internal bool <LoadResourceFromFolder>b__8_0(string filename)
- internal bool <LoadResourceFromFolder>b__8_1(string dirname)

### private class NeoModLoader.utils.HarmonyUtils.<>c__DisplayClass0_0

#### Fields
- public System.Collections.Generic.List<HarmonyLib.CodeInstruction> pCodes

#### Constructors
- public HarmonyUtils.<>c__DisplayClass0_0()

### private class NeoModLoader.utils.ReflectionHelper.<>c__DisplayClass0_0

#### Fields
- public string assembly_name

#### Constructors
- public ReflectionHelper.<>c__DisplayClass0_0()

#### Methods
- internal bool <IsAssemblyLoaded>b__0(System.Reflection.Assembly a)

### private class NeoModLoader.utils.HarmonyUtils.<>c__DisplayClass0_1

#### Fields
- public NeoModLoader.utils.HarmonyUtils.<>c__DisplayClass0_0 CS$<>8__locals1
- public int i

#### Constructors
- public HarmonyUtils.<>c__DisplayClass0_1()

#### Methods
- internal bool <FindCodeSnippet>b__0(NeoModLoader.utils.instpredictors.BaseInstPredictor t, int j)

### private class NeoModLoader.utils.ResourcesPatch.<>c__DisplayClass11_0

#### Fields
- public System.Collections.Generic.HashSet<string> names

#### Constructors
- public ResourcesPatch.<>c__DisplayClass11_0()

#### Methods
- internal bool <LoadAll_Postfix>b__1(UnityEngine.Object x)

### private class NeoModLoader.utils.ModReloadUtils.<>c__DisplayClass19_0

#### Fields
- public Mono.Cecil.MethodDefinition newMethod

#### Constructors
- public ModReloadUtils.<>c__DisplayClass19_0()

#### Methods
- internal void <Replace>b__0(MonoMod.Cil.ILContext il)

### private class NeoModLoader.utils.HarmonyUtils.<>c__DisplayClass1_0

#### Fields
- public System.Collections.Generic.List<HarmonyLib.CodeInstruction> pCodes

#### Constructors
- public HarmonyUtils.<>c__DisplayClass1_0()

### private class NeoModLoader.utils.ModDependencyUtils.<>c__DisplayClass1_0

#### Fields
- public string dependency

#### Constructors
- public ModDependencyUtils.<>c__DisplayClass1_0()

#### Methods
- internal bool <TryToAppendMod>b__0(NeoModLoader.utils.ModDependencyNode n)

### private class NeoModLoader.utils.HarmonyUtils.<>c__DisplayClass1_1

#### Fields
- public NeoModLoader.utils.HarmonyUtils.<>c__DisplayClass1_0 CS$<>8__locals1
- public int i

#### Constructors
- public HarmonyUtils.<>c__DisplayClass1_1()

#### Methods
- internal bool <FindCodeSnippetIdx>b__0(NeoModLoader.utils.instpredictors.BaseInstPredictor t, int j)

### private class NeoModLoader.utils.ModDependencyUtils.<>c__DisplayClass3_0

#### Fields
- public string incompatible_with

#### Constructors
- public ModDependencyUtils.<>c__DisplayClass3_0()

#### Methods
- internal bool <RemoveIncompatibleMods>b__0(NeoModLoader.utils.ModDependencyNode node)

### private class NeoModLoader.utils.ModDependencyUtils.<>c__DisplayClass4_0

#### Fields
- public string dependency

#### Constructors
- public ModDependencyUtils.<>c__DisplayClass4_0()

#### Methods
- internal bool <RemoveModsWithoutRequiredDependencies>b__0(NeoModLoader.utils.ModDependencyNode node)

### private class NeoModLoader.utils.ModDependencyUtils.<>c__DisplayClass4_1

#### Fields
- public string optional_dependency

#### Constructors
- public ModDependencyUtils.<>c__DisplayClass4_1()

#### Methods
- internal bool <RemoveModsWithoutRequiredDependencies>b__1(NeoModLoader.utils.ModDependencyNode node)
- internal bool <RemoveModsWithoutRequiredDependencies>b__2(NeoModLoader.utils.ModDependencyNode node)

### private static class NeoModLoader.utils.ModInfoUtils.<>O

#### Fields
- public static System.Action <0>__InstallBepInExMod

### public static class NeoModLoader.utils.AssetBundleUtils

#### Fields
- private static readonly System.Collections.Generic.Dictionary<string, NeoModLoader.utils.WrappedAssetBundle> LoadedAssetBundles
- private static readonly System.Collections.Generic.Dictionary<string, NeoModLoader.utils.WrappedAssetBundle> LoadedAssetBundlesByPath

#### Constructors
- private static AssetBundleUtils()

#### Methods
- public static NeoModLoader.utils.WrappedAssetBundle GetAssetBundle(string name)
- public static NeoModLoader.utils.WrappedAssetBundle LoadFromFile(string pPath, bool pForceReload = false)
- public static NeoModLoader.utils.WrappedAssetBundle[] LoadFromFolder(string pFolder)

### private class NeoModLoader.utils.WrappedAssetBundle.AssetNode

#### Fields
- public readonly System.Collections.Generic.Dictionary<string, NeoModLoader.utils.WrappedAssetBundle.AssetNode> children
- public readonly System.Collections.Generic.List<string> resources_full_names

#### Constructors
- public WrappedAssetBundle.AssetNode()

### internal class NeoModLoader.utils.AssetPatches

#### Constructors
- public AssetPatches()

#### Methods
- private static BaseStats[] GetCustomStats(ActorTrait trait)
- private static void MergeCustomStats(Actor __instance)
- private static System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> MergeWithCustomStats(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> instructions)
- private static System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> ShowCustomStats(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> instructions)

### internal static class NeoModLoader.utils.BenchUtils

#### Fields
- private static System.Collections.Generic.Dictionary<string, float> bench

#### Constructors
- private static BenchUtils()

#### Methods
- public static float End(string key)
- public static void Start(string key)

### public struct NeoModLoader.utils.ChannelContainer

#### Fields
- private FMOD.Channel <Channel>k__BackingField
- public UnityEngine.Transform AttachedTo
- public UnityEngine.Vector3 PosAndVolume

#### Properties
- public FMOD.Channel Channel { get; internal set; }
- public bool Finushed { get; }

#### Constructors
- internal ChannelContainer(FMOD.Channel channel, UnityEngine.Transform attachedTo = null, UnityEngine.Vector3 PosAndVolume = null)

### public class NeoModLoader.utils.CustomAudioManager

#### Fields
- internal static readonly System.Collections.Generic.Dictionary<string, NeoModLoader.utils.WavContainer> AudioWavLibrary
- private static readonly System.Collections.Generic.List<NeoModLoader.utils.ChannelContainer> Channels
- private static readonly System.Collections.Generic.Dictionary<string, NeoModLoader.utils.ChannelContainer> DrawingSounds
- private static FMOD.System fmodSystem
- private static FMOD.ChannelGroup MusicGroup
- private static FMOD.ChannelGroup SFXGroup
- private static FMOD.ChannelGroup UIGroup

#### Constructors
- public CustomAudioManager()
- private static CustomAudioManager()

#### Methods
- internal static void AddChannel(FMOD.Channel channel, UnityEngine.Transform AttachedTo = null, UnityEngine.Vector3 PosAndVolume = null)
- public static void ClearAllCustomSounds()
- private static float GetVolume(NeoModLoader.utils.SoundType soundType)
- internal static void Initialize()
- public static NeoModLoader.utils.ChannelContainer LoadCustomSound(string WAVName, float pX, float pY, UnityEngine.Transform AttachedTo = null)
- public static NeoModLoader.utils.ChannelContainer LoadDrawingSound(string pSoundPath, float pX, float pY)
- public static void ModifyWavData(string ID, float Volume, NeoModLoader.utils.SoundMode Mode, int LoopCount = 0, bool Ramp = false, NeoModLoader.utils.SoundType Type = Sound)
- private static bool PlayDrawingSoundPatch(string pSoundPath, float pX, float pY)
- private static bool PlaySoundPatch(string pSoundPath, float pX, float pY, bool pGameViewOnly)
- public static void SetChannelPosition(NeoModLoader.utils.ChannelContainer channel, float pX, float pY)
- public static void SetChannelPosition(FMOD.Channel channel, float pX, float pY)
- private static void Update()
- private static bool UpdateChannel(NeoModLoader.utils.ChannelContainer channel)
- private static void UpdateMonoVolume(NeoModLoader.utils.ChannelContainer Channel)

### public static class NeoModLoader.utils.DelegateExtentions

#### Methods
- public static D AsDelegate<D>(string String)
- public static System.Delegate AsDelegate(string String, System.Type DelegateType = null)
- public static string AsString(System.Delegate pDelegate, bool IncludeType = false)
- public static System.Type[] GetDelegateParameters(System.Type delegateType)

### public static class NeoModLoader.utils.HarmonyUtils

#### Methods
- public static int FindCodeSnippet(System.Collections.Generic.List<HarmonyLib.CodeInstruction> pCodes, out System.Collections.Generic.List<HarmonyLib.CodeInstruction> pResult, params NeoModLoader.utils.instpredictors.BaseInstPredictor[] pSnippetPredictors)
- public static int FindCodeSnippetIdx(System.Collections.Generic.List<HarmonyLib.CodeInstruction> pCodes, params NeoModLoader.utils.instpredictors.BaseInstPredictor[] pSnippetPredictors)
- public static HarmonyLib.CodeInstruction FindInst(System.Collections.Generic.List<HarmonyLib.CodeInstruction> pCodes, NeoModLoader.utils.instpredictors.BaseInstPredictor pPredictor)
- public static int FindInstIdx<TOperand>(System.Collections.Generic.List<HarmonyLib.CodeInstruction> pCodes, NeoModLoader.utils.instpredictors.BaseInstPredictor pPredictor)
- public static TOperand FindInstOperand<TOperand>(System.Collections.Generic.List<HarmonyLib.CodeInstruction> pCodes, NeoModLoader.utils.instpredictors.BaseInstPredictor pPredictor)
- internal static void _init()

### public static class NeoModLoader.utils.HttpUtils

#### Methods
- public static System.Net.Http.HttpResponseMessage Get(string url, System.Collections.Generic.Dictionary<string, string> headers)
- public static string Post(string url, System.Collections.Generic.Dictionary<string, string> params, System.Collections.Generic.Dictionary<string, string> headers = null, double timeout = 30)
- public static string Request(string url, string param = "", string method = "get")

### internal static class NeoModLoader.utils.InternalResourcesGetter

#### Fields
- private static string commit
- private static UnityEngine.Sprite github_icon
- private static UnityEngine.Sprite icon_frame
- private static UnityEngine.Sprite icon_reload
- private static long last_write_time
- private static UnityEngine.Sprite mod_icon
- private static UnityEngine.Sprite window_big_close
- private static UnityEngine.Sprite window_empty_frame
- private static UnityEngine.Sprite window_vert_name_plate

#### Constructors
- private static InternalResourcesGetter()

#### Methods
- public static string GetCommit()
- public static UnityEngine.Sprite GetGitHubIcon()
- public static UnityEngine.Sprite GetIcon()
- public static UnityEngine.Sprite GetIconFrame()
- public static long GetLastWriteTime()
- public static UnityEngine.Sprite GetReloadIcon()
- public static UnityEngine.Sprite GetWindowBigCloseSliced()
- public static UnityEngine.Sprite GetWindowEmptyFrame()
- public static UnityEngine.Sprite GetWindowVertNamePlate()
- private static byte[] LoadManifestBytes(string path_under_resources)
- private static UnityEngine.Texture2D LoadManifestTexture(string path_under_resources)

### private class NeoModLoader.utils.SpriteLoadUtils.MetaFile

#### Fields
- public NeoModLoader.utils.TextureImporter TextureImporter

#### Constructors
- public SpriteLoadUtils.MetaFile()

### public class NeoModLoader.utils.ModDependencyGraph

#### Fields
- public System.Collections.Generic.HashSet<NeoModLoader.utils.ModDependencyNode> nodes

#### Constructors
- public ModDependencyGraph(System.Collections.Generic.ICollection<NeoModLoader.api.ModDeclare> mods)

### public class NeoModLoader.utils.ModDependencyNode

#### Fields
- private readonly NeoModLoader.api.ModDeclare <mod_decl>k__BackingField
- public System.Collections.Generic.HashSet<NeoModLoader.utils.ModDependencyNode> depend_by
- public System.Collections.Generic.HashSet<NeoModLoader.utils.ModDependencyNode> depend_on
- public System.Collections.Generic.HashSet<NeoModLoader.utils.ModDependencyNode> necessary_depend_on

#### Properties
- public NeoModLoader.api.ModDeclare mod_decl { get; }

#### Constructors
- public ModDependencyNode(NeoModLoader.api.ModDeclare pModDecl)

#### Methods
- public System.Collections.Generic.List<string> GetAdditionReferences(bool recursive = true)

### internal static class NeoModLoader.utils.ModDependencyUtils

#### Methods
- public static string ParseDepenNameToPreprocessSymbol(string pDepenName)
- public static void RemoveCircleDependencies(NeoModLoader.utils.ModDependencyGraph pGraph)
- public static void RemoveIncompatibleMods(NeoModLoader.utils.ModDependencyGraph pGraph)
- public static void RemoveModsWithoutRequiredDependencies(NeoModLoader.utils.ModDependencyGraph pGraph)
- public static System.Collections.Generic.List<NeoModLoader.utils.ModDependencyNode> SortModsCompileOrderFromDependencyTopology(NeoModLoader.utils.ModDependencyGraph pGraph)
- public static NeoModLoader.utils.ModDependencyNode TryToAppendMod(NeoModLoader.utils.ModDependencyGraph pGraph, NeoModLoader.api.ModDeclare pModAppend)

### internal static class NeoModLoader.utils.ModInfoUtils

#### Fields
- private static System.Collections.Generic.Queue<NeoModLoader.api.ModDeclare> link_request_mods
- private static System.Collections.Generic.Dictionary<string, NeoModLoader.api.ModCompilationCache> mod_compilation_caches
- private static readonly System.Collections.Generic.Dictionary<string, long> mod_last_update_timestamps
- private static bool to_install_bepinex

#### Constructors
- private static ModInfoUtils()

#### Methods
- internal static bool <findAndPrepareMods>g__NCMSHere|7_0()
- public static void CheckModsFolder(string pFolderPath, System.Collections.Generic.HashSet<string> pFindModsIDs, System.Collections.Generic.List<NeoModLoader.api.ModDeclare> pModsToFill, bool pLogModJsonNotFound = true)
- public static void clearModCompileTimestamp(string pModUUID, bool pSave = true)
- internal static void DealWithBepInExModLinkRequests()
- public static bool doesModNeedRecompile(NeoModLoader.api.ModDeclare pModDeclare, System.Collections.Generic.List<string> pDependencies, System.Collections.Generic.List<string> pOptionalDependencies)
- public static System.Collections.Generic.List<NeoModLoader.api.ModDeclare> findAndPrepareMods()
- private static long getModLastCompileTimestamp(string pModUID)
- private static long getModNewestUpdateTimestamp(string pModFolderPath)
- public static void InitializeModCompileCache()
- private static void InstallBepInEx()
- private static void InstallBepInExMod()
- public static bool isModDisabled(string pModUID)
- internal static void LinkBepInExModToLocalRequest(NeoModLoader.api.ModDeclare mod)
- public static NeoModLoader.api.ModDeclare recogBepInExMod(string folder, System.Reflection.Assembly pAssembly)
- public static System.Collections.Generic.List<NeoModLoader.api.ModDeclare> recogBepInExMods()
- public static NeoModLoader.api.ModDeclare recogMod(string pModFolderPath, bool pLogModJsonNotFound = true)
- public static void RecordMod(NeoModLoader.api.ModDeclare pModDeclare, System.Collections.Generic.List<string> pDependencies, System.Collections.Generic.List<string> pOptionalDependencies, bool pDisabled = false, bool pSave = true)
- private static System.Collections.Generic.List<NeoModLoader.api.ModDeclare> removeDisabledMods(System.Collections.Generic.List<NeoModLoader.api.ModDeclare> mods_to_process)
- public static void SaveModRecords()
- public static bool toggleMod(string pModUID, bool pSave = true)
- public static string TryToUnzipModZip(string pZipFile)

### internal static class NeoModLoader.utils.ModReloadUtils

#### Fields
- private static readonly System.Collections.Generic.Dictionary<System.Reflection.MethodInfo, MonoMod.RuntimeDetour.ILHook> _create_hooks
- private static System.Collections.Generic.Dictionary<System.Type, System.Reflection.MethodInfo> _emit_method_cache
- private static NeoModLoader.api.IReloadable _mod
- private static NeoModLoader.api.ModDeclare _mod_declare
- private static string _new_compiled_dll_path
- private static string _new_compiled_pdb_path
- private static Mono.Cecil.AssemblyDefinition _old_assembly_definition
- private static System.Collections.Generic.Dictionary<string, Mono.Cecil.MethodDefinition> _old_method_definitions
- private static System.Collections.Generic.Dictionary<Mono.Cecil.Cil.OpCode, System.Reflection.Emit.OpCode> _op_code_map
- private static System.Collections.Generic.Dictionary<Mono.Cecil.MethodDefinition, System.Reflection.MethodInfo> _regenerated_brand_new_methods

#### Constructors
- private static ModReloadUtils()

#### Methods
- public static bool CompileNew()
- private static void CreateBrandNewMethods(System.Collections.Generic.HashSet<Mono.Cecil.MethodDefinition> pBrandNewMethods)
- private static System.Reflection.MethodInfo CreateMethod(Mono.Cecil.MethodDefinition newMethod)
- private static void HotfixMethod(HarmonyLib.Harmony pHarmony, Mono.Cecil.MethodDefinition pNewMethod, System.Reflection.MethodInfo pOldMethod)
- private static void InitializeOpcodeMap()
- private static bool NeedHotfix(System.Reflection.MethodInfo pOldMethod, Mono.Cecil.MethodDefinition pNewMethod)
- public static bool PatchHotfixMethods()
- public static bool PatchHotfixMethodsNT()
- public static bool Prepare(NeoModLoader.api.IReloadable pMod, NeoModLoader.api.ModDeclare pModDeclare)
- private static MonoMod.Utils.DynamicMethodDefinition regenerate(Mono.Cecil.MethodDefinition pMethodDefinition)
- public static bool Reload()
- private static void Replace(System.Reflection.MethodInfo oldMethod, Mono.Cecil.MethodDefinition newMethod)
- private static void ReplaceMethod(System.Reflection.MethodInfo pOldMethod, MonoMod.Utils.DynamicMethodDefinition pNewMethod)

### private class NeoModLoader.utils.SpriteLoadUtils.NCMSSpritesSettings

#### Fields
- public NeoModLoader.utils.SpriteLoadUtils.NCMSSpritesSettings.SpecificSetting Default
- public System.Collections.Generic.List<NeoModLoader.utils.SpriteLoadUtils.NCMSSpritesSettings.SpecificSetting> Specific

#### Constructors
- public SpriteLoadUtils.NCMSSpritesSettings()

#### Methods
- public override string ToString()

### public static class NeoModLoader.utils.OtherUtils

#### Methods
- public static bool CalledBy(string pMethodName, System.Type pTypeConstraint, bool pSearchAll = false)
- public static string GetStackTrace(int skip_frames = 0, string indent = "")

### public class NeoModLoader.utils.PriorityQueue<T>
- Interfaces: System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable

#### Fields
- private int <Count>k__BackingField
- private readonly System.Collections.Generic.IComparer<T> comparer
- private T[] heap

#### Properties
- public int Count { get; private set; }
- public T Item { get; }

#### Constructors
- public PriorityQueue<T>(int capacity, System.Collections.Generic.IComparer<T> comparer)

#### Methods
- public T Dequeue()
- public int Enqueue(T x)
- public System.Collections.Generic.IEnumerator<T> GetEnumerator()
- private static int Left(int i)
- private static int Parent(int i)
- public T Peek()
- private void SiftDown(int i, T x)
- private int SiftUp(int i)
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()

### internal static class NeoModLoader.utils.ReflectionHelper

#### Methods
- internal static System.Delegate CreateFieldGetter(string field_name, System.Type instance_type, System.Type output_type)
- internal static System.Delegate CreateFieldGetter<OutType>(string field_name, System.Type instance_type)
- internal static System.Func<InstanceType, OutType> CreateFieldGetter<InstanceType, OutType>(string field_name)
- internal static System.Action<TI, TF> CreateFieldSetter<TI, TF>(string field_name)
- private static System.Delegate createMethodDelegate(System.Reflection.MethodInfo method_info)
- internal static System.Delegate GetMethod<T>(string method_name, bool is_static = false)
- internal static System.Delegate GetMethod(System.Type type, string method_name, bool is_static = false)
- internal static bool IsAssemblyLoaded(string assembly_name)

### public static class NeoModLoader.utils.ResourcesPatch

#### Fields
- private static NeoModLoader.utils.ResourcesPatch.ResourceTree tree

#### Methods
- public static System.Collections.Generic.Dictionary<string, UnityEngine.Object> GetAllPatchedResources()
- internal static void Initialize()
- private static UnityEngine.Object[] LoadAll_Postfix(UnityEngine.Object[] __result, string path, System.Type systemTypeInstance)
- private static void LoadAll_Prefix(ref string path)
- private static NeoModLoader.utils.Builders.Builder LoadAsset(string Path, string Extention)
- internal static void LoadAssetBundlesFromFolder(string pFolder)
- public static UnityEngine.Object[] LoadResourceFile(ref string path, ref string pLowerPath)
- internal static void LoadResourceFromFolder(string pFolder, out System.Collections.Generic.List<NeoModLoader.utils.Builders.Builder> Builders)
- private static UnityEngine.TextAsset LoadTextAsset(string path)
- private static void LoadWavFile(string path)
- private static UnityEngine.Object Load_Postfix(UnityEngine.Object __result, string path, System.Type systemTypeInstance)
- private static void Load_Prefix(ref string path)
- public static void PatchResource(string pPath, UnityEngine.Object pObject)

### private class NeoModLoader.utils.ResourcesPatch.ResourceTree

#### Fields
- internal System.Collections.Generic.Dictionary<string, UnityEngine.Object> direct_objects
- private NeoModLoader.utils.ResourcesPatch.ResourceTreeNode root

#### Constructors
- public ResourcesPatch.ResourceTree()

#### Methods
- public void Add(string path, UnityEngine.Object obj)
- public void AddFromFile(string path, string absPath, out NeoModLoader.utils.Builders.Builder Builder)
- public NeoModLoader.utils.ResourcesPatch.ResourceTreeNode Find(string path, bool createNodeAlong = false, bool visitLast = true)
- public UnityEngine.Object Get(string path)

### private class NeoModLoader.utils.ResourcesPatch.ResourceTreeNode

#### Fields
- private NeoModLoader.utils.ResourcesPatch.ResourceTreeNode <parent>k__BackingField
- public readonly System.Collections.Generic.Dictionary<string, NeoModLoader.utils.ResourcesPatch.ResourceTreeNode> children
- public readonly System.Collections.Generic.Dictionary<string, UnityEngine.Object> objects

#### Properties
- public NeoModLoader.utils.ResourcesPatch.ResourceTreeNode parent { get; internal set; }

#### Constructors
- public ResourcesPatch.ResourceTreeNode(NeoModLoader.utils.ResourcesPatch.ResourceTreeNode parent)

#### Methods
- public System.Collections.Generic.List<UnityEngine.Object> GetAllObjects(System.Type systemTypeInstance)

### internal class NeoModLoader.utils.SingleSpriteMetaData

#### Fields
- public UnityEngine.SpriteAlignment alignment
- public UnityEngine.Vector4 border
- public string name
- public UnityEngine.Vector2 pivot
- public UnityEngine.Rect rect

#### Constructors
- public SingleSpriteMetaData()

### public enum NeoModLoader.utils.SoundMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Basic = 0
- Mono3D = 2
- Stereo3D = 1

### public enum NeoModLoader.utils.SoundType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Music = 0
- Sound = 1
- UI = 2

### public class NeoModLoader.utils.SpriteLoadUtils.NCMSSpritesSettings.SpecificSetting

#### Fields
- public string Alias
- public float BorderB
- public float BorderL
- public float BorderR
- public float BorderT
- public string Path
- public float PivotX
- public float PivotY
- public float PixelsPerUnit
- public float RectH
- public float RectW
- public float RectX
- public float RectY

#### Constructors
- public SpriteLoadUtils.NCMSSpritesSettings.SpecificSetting()

#### Methods
- public UnityEngine.Sprite loadFromPath(string path)

### public static class NeoModLoader.utils.SpriteLoadUtils

#### Fields
- private static NeoModLoader.utils.SpriteLoadUtils.NCMSSpritesSettings.SpecificSetting defaultNCMSSetting
- private static YamlDotNet.Serialization.IDeserializer deserializer
- private static System.Collections.Generic.Dictionary<string, NeoModLoader.utils.SpriteLoadUtils.NCMSSpritesSettings> dirNCMSSettings
- private static System.Collections.Generic.HashSet<string> ignoreNCMSSettingsSearchPath
- private static System.Collections.Generic.Dictionary<string, UnityEngine.Sprite> singleSpriteCache

#### Constructors
- private static SpriteLoadUtils()

#### Methods
- internal static NeoModLoader.utils.SpriteLoadUtils.NCMSSpritesSettings.SpecificSetting <searchUpNCMSSetting>g__getInternalSetting|7_0(string i_path, NeoModLoader.utils.SpriteLoadUtils.NCMSSpritesSettings settings)
- private static NeoModLoader.utils.TextureImporter loadMeta(string path)
- public static UnityEngine.Sprite LoadSingleSprite(string path)
- public static UnityEngine.Sprite[] LoadSprites(string path)
- private static UnityEngine.Sprite loadSpriteSimply(string path)
- private static UnityEngine.Sprite[] loadSpriteWithMeta(string path, NeoModLoader.utils.TextureImporter textureImporter)
- private static NeoModLoader.utils.SpriteLoadUtils.NCMSSpritesSettings.SpecificSetting searchUpNCMSSetting(string path)

### internal class NeoModLoader.utils.SpriteSheet

#### Fields
- public System.Collections.Generic.List<NeoModLoader.utils.SingleSpriteMetaData> sprites

#### Constructors
- public SpriteSheet()

### public static class NeoModLoader.utils.SystemUtils

#### Methods
- public static void BashRun(string[] parameters)
- public static void CmdRunAs(string[] parameters)
- public static void CopyDirectory(string pSource, string pTarget)
- public static System.Collections.Generic.List<string> SearchFileRecursive(string path, System.Func<string, bool> fileNameJudge, System.Func<string, bool> dirNameJudge)

### internal class NeoModLoader.utils.TextureImporter

#### Fields
- public NeoModLoader.utils.SpriteSheet spriteSheet

#### Constructors
- public TextureImporter()

### internal struct NeoModLoader.utils.WavContainer

#### Fields
- public int LoopCount
- public NeoModLoader.utils.SoundMode Mode
- public string Path
- public bool Ramp
- public NeoModLoader.utils.SoundType Type
- public float Volume

#### Constructors
- public WavContainer(string Path, NeoModLoader.utils.SoundMode Mode, float Volume, int LoopCount = 0, bool Ramp = false, NeoModLoader.utils.SoundType Type = Sound)

### public class NeoModLoader.utils.WrappedAssetBundle

#### Fields
- private readonly UnityEngine.AssetBundle assetBundle
- private readonly System.Collections.Generic.Dictionary<string, NeoModLoader.utils.WrappedAssetBundle.AssetNode> direct_visit
- private readonly NeoModLoader.utils.WrappedAssetBundle.AssetNode root

#### Properties
- public string Name { get; }

#### Constructors
- internal WrappedAssetBundle(UnityEngine.AssetBundle ab)

#### Methods
- public string[] GetAllAssetNames()
- public UnityEngine.Object[] GetAllObjects(System.Type pType)
- public T[] GetAllObjects<T>()
- public UnityEngine.Object[] GetAllObjects(string pPath, System.Type pType)
- public T[] GetAllObjects<T>(string pPath)
- public string[] GetAllScenePaths()
- public UnityEngine.Object GetObject(string pName)
- public UnityEngine.Object GetObject(string pName, System.Type type)
- public T GetObject<T>(string pName)

## Namespace: NeoModLoader.utils.authentication

### private class NeoModLoader.utils.authentication.DiscordCommonAuthLogic.<>c

#### Fields
- public static readonly NeoModLoader.utils.authentication.DiscordCommonAuthLogic.<>c <>9
- public static System.Func<string, string> <>9__0_0
- public static System.Func<string, bool> <>9__1_0

#### Constructors
- private static DiscordCommonAuthLogic.<>c()
- public DiscordCommonAuthLogic.<>c()

#### Methods
- internal string <GetRolesOfUser>b__0_0(string role)
- internal bool <ModderIsInRolesList>b__1_0(string role)

### private class NeoModLoader.utils.authentication.DiscordRoleAuthViaUserLoginUtils.<>c

#### Fields
- public static readonly NeoModLoader.utils.authentication.DiscordRoleAuthViaUserLoginUtils.<>c <>9
- public static System.Func<string, string[]> <>9__3_0
- public static System.Func<string[], bool> <>9__3_1
- public static System.Func<char, byte> <>9__4_1
- public static System.Func<char, byte> <>9__4_2

#### Constructors
- private static DiscordRoleAuthViaUserLoginUtils.<>c()
- public DiscordRoleAuthViaUserLoginUtils.<>c()

#### Methods
- internal byte <GetAuthToken>b__4_1(char c)
- internal byte <GetAuthToken>b__4_2(char c)
- internal string[] <GetUserID>b__3_0(string segment)
- internal bool <GetUserID>b__3_1(string[] pair)

### private class NeoModLoader.utils.authentication.DiscordRoleAuthViaUserLoginUtils.<>c__DisplayClass4_0

#### Fields
- public System.Net.HttpListener listener

#### Constructors
- public DiscordRoleAuthViaUserLoginUtils.<>c__DisplayClass4_0()

#### Methods
- internal void <GetAuthToken>b__0()

### private static class NeoModLoader.utils.authentication.DiscordRoleAuthViaUserLoginUtils.<>O

#### Fields
- public static System.Action<string> <0>__WriteLine

### public class NeoModLoader.utils.authentication.AuthenticaticationException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public AuthenticaticationException()
- public AuthenticaticationException(string message)
- public AuthenticaticationException(string message, System.Exception innerException)

### private struct NeoModLoader.utils.authentication.GithubOrgAuthUtils.DeviceFlow

#### Fields
- public string device_code
- public int expires_in
- public int interval
- public string user_code
- public string verification_uri

### public class NeoModLoader.utils.authentication.DiscordAutomaticRoleAuthUtils

#### Constructors
- public DiscordAutomaticRoleAuthUtils()

#### Methods
- public static bool Authenticate()

### internal static class NeoModLoader.utils.authentication.DiscordCommonAuthLogic

#### Methods
- internal static System.Collections.Generic.IEnumerable<string> GetRolesOfUser(string user_id)
- internal static bool ModderIsInRolesList(System.Collections.Generic.IEnumerable<string> roles)

### public class NeoModLoader.utils.authentication.DiscordRoleAuthViaUserLoginUtils

#### Fields
- private static const string client_id

#### Constructors
- public DiscordRoleAuthViaUserLoginUtils()

#### Methods
- public static bool Authenticate()
- private static NeoModLoader.utils.authentication.DiscordRoleAuthViaUserLoginUtils.TokenInfo GetAuthToken()
- private static string GetUserID(NeoModLoader.utils.authentication.DiscordRoleAuthViaUserLoginUtils.TokenInfo token_info)
- public static void Test()

### public static class NeoModLoader.utils.authentication.GithubOrgAuthUtils

#### Fields
- private static const string client_id
- private static string domain
- private static readonly string[] _alter_domains

#### Constructors
- private static GithubOrgAuthUtils()

#### Methods
- public static bool Authenticate()
- private static string GetTokenByDeviceFlow()

### private struct NeoModLoader.utils.authentication.DiscordRoleAuthViaUserLoginUtils.TokenInfo

#### Fields
- public string access_token
- public string expires_in
- public string refresh_token
- public string scope
- public string token_type

### private struct NeoModLoader.utils.authentication.GithubOrgAuthUtils.TokenInfo

#### Fields
- public string access_token
- public string scope
- public string token_type

### private struct NeoModLoader.utils.authentication.GithubOrgAuthUtils.UserInfo

#### Fields
- public string login

## Namespace: NeoModLoader.utils.Builders

### private class NeoModLoader.utils.Builders.CultureTraitBuilder.<>c

#### Fields
- public static readonly NeoModLoader.utils.Builders.CultureTraitBuilder.<>c <>9
- public static System.Func<CultureTrait, bool> <>9__12_0

#### Constructors
- private static CultureTraitBuilder.<>c()
- public CultureTraitBuilder.<>c()

#### Methods
- internal bool <LinkAssets>b__12_0(CultureTrait trait)

### private class NeoModLoader.utils.Builders.SubspeciesTraitBuilder.<>c

#### Fields
- public static readonly NeoModLoader.utils.Builders.SubspeciesTraitBuilder.<>c <>9
- public static System.Func<SubspeciesTrait, bool> <>9__6_0
- public static System.Func<SubspeciesTrait, bool> <>9__6_1
- public static System.Func<SubspeciesTrait, bool> <>9__6_2

#### Constructors
- private static SubspeciesTraitBuilder.<>c()
- public SubspeciesTraitBuilder.<>c()

#### Methods
- internal bool <LinkAssets>b__6_0(SubspeciesTrait trait)
- internal bool <LinkAssets>b__6_1(SubspeciesTrait trait)
- internal bool <LinkAssets>b__6_2(SubspeciesTrait trait)

### public class NeoModLoader.utils.Builders.ActorAssetBuilder
- Base: NeoModLoader.utils.Builders.UnlockableAssetBuilder<ActorAsset, ActorAssetLibrary>

#### Constructors
- public ActorAssetBuilder(string ID)
- public ActorAssetBuilder(string FilePath, bool LoadImmediately)
- public ActorAssetBuilder(string ID, string CopyFrom)

### public class NeoModLoader.utils.Builders.ActorTraitBuilder
- Base: NeoModLoader.utils.Builders.BaseTraitBuilder<ActorTrait, ActorTraitLibrary>

#### Fields
- internal static System.Collections.Concurrent.ConcurrentDictionary<string, NeoModLoader.utils.Builders.GetAdditionalBaseStatsMethod> AdditionalBaseStatMethods

#### Properties
- public bool ActiveInDarkEra { get; set; }
- public bool ActiveInMoonEra { get; set; }
- public float ActorsLikeability { get; set; }
- public NeoModLoader.utils.Builders.GetAdditionalBaseStatsMethod AdditionalBaseStatsMethod { set; }
- public bool AffectsMind { get; set; }
- public bool CanBeCured { get; set; }
- public string ForcedKingdomID { get; set; }
- public bool IsCombatSkill { get; set; }
- public int OppositeTraitLikeability { get; set; }
- public int RateAcquireWhenGrownUp { get; set; }
- public int RateBirth { get; set; }
- public int RateInherit { get; set; }
- public bool RemovedByAcceleratedHealing { get; set; }
- public bool RemovedByDevineLight { get; set; }
- public bool RemoveForZombies { get; set; }
- public int SameTraitLikeability { get; set; }
- public TraitType Type { get; set; }
- public bool UsedInMutationBox { get; set; }

#### Constructors
- private static ActorTraitBuilder()
- public ActorTraitBuilder(string ID)
- public ActorTraitBuilder(string ID, bool LoadImmediately)
- public ActorTraitBuilder(string ID, string CopyFrom)

#### Methods
- public override void Build(bool SetRarityAutomatically = false, bool AutoLocalize = true, bool LinkWithOtherAssets = false)
- private void LinkWithLibrary()
- protected override void LoadFromPath(string FilePathToBuild)

### public class NeoModLoader.utils.Builders.AssetBuilder<A, AL>
- Base: NeoModLoader.utils.Builders.Builder

#### Fields
- private A <Asset>k__BackingField
- internal string FilePathToBuild
- public readonly AL Library

#### Properties
- public A Asset { get; protected set; }

#### Constructors
- private AssetBuilder<A, AL>()
- public AssetBuilder<A, AL>(string ID)
- public AssetBuilder<A, AL>(string FilePath, bool LoadImmediately)
- public AssetBuilder<A, AL>(string ID, string CopyFrom)

#### Methods
- public override void Build(bool LinkWithOtherAssets)
- protected virtual A CreateAsset(string ID)
- private AL GetLibrary()
- protected virtual void Init()
- public override void LinkAssets()
- private void LoadAssetFromPath(string FilePathToBuild)
- protected virtual void LoadFromPath(string FilePathToBuild)

### public class NeoModLoader.utils.Builders.AugmentationAssetBuilder<A, AL>
- Base: NeoModLoader.utils.Builders.UnlockableAssetBuilder<A, AL>

#### Properties
- public WorldActionTrait ActionOnLoad { get; set; }
- public WorldActionTrait ActionWhenAdded { get; set; }
- public WorldActionTrait ActionWhenRemoved { get; set; }
- public WorldAction ActonSpecialEffect { get; set; }
- public AttackAction AttackAction { get; set; }
- public bool CanBeGiven { get; set; }
- public bool CanBeRemoved { get; set; }
- public System.Collections.Generic.IEnumerable<string> CombatActions { get; set; }
- public System.Collections.Generic.IEnumerable<string> Decisions { get; set; }
- public string Group { get; set; }
- public int Priority { get; set; }
- public bool ShowInMetaEditor { get; set; }
- public float SpecialEffectCoolDown { get; set; }
- public System.Collections.Generic.IEnumerable<string> Spells { get; set; }

#### Constructors
- public AugmentationAssetBuilder<A, AL>(string ID)
- public AugmentationAssetBuilder<A, AL>(string FilePath, bool LoadImmediately)
- public AugmentationAssetBuilder<A, AL>(string ID, string CopyFrom)

#### Methods
- public override void LinkAssets()
- private void LinkDecisions()

### public class NeoModLoader.utils.Builders.BaseTraitBuilder<A, AL>
- Base: NeoModLoader.utils.Builders.AugmentationAssetBuilder<A, AL>

#### Properties
- public GetHitAction ActionGetHit { get; set; }
- public WorldAction ActionOnBirth { get; set; }
- public WorldAction ActionOnDeath { get; set; }
- public WorldAction ActionOnGrowth { get; set; }
- public BaseStats BaseStatsMeta { get; set; }
- public bool CanBeInBook { get; set; }
- public int ChanceToGetOnCreation { get; set; }
- public float CustomValue { get; set; }
- public string Description1ID { get; set; }
- public string Description2ID { get; set; }
- public System.Collections.Generic.IEnumerable<string> MetaTags { get; set; }
- public string NameID { get; set; }
- public System.Collections.Generic.IEnumerable<System.Func<A, bool>> OpposeAllOtherTraits { set; }
- public System.Collections.Generic.IEnumerable<string> OppositeTraits { get; set; }
- public string PlotID { get; set; }
- public Rarity Rarity { get; set; }
- public System.Collections.Generic.IEnumerable<string> TraitsToRemove { get; set; }

#### Constructors
- public BaseTraitBuilder<A, AL>(string ID)
- public BaseTraitBuilder<A, AL>(string FilePath, bool LoadImmediately)
- public BaseTraitBuilder<A, AL>(string ID, string CopyFrom)

#### Methods
- public override void Build(bool LinkWithOtherAssets)
- public virtual void Build(bool SetRarityAutomatically = false, bool AutoLocalize = true, bool LinkWithOtherAssets = false)
- private void CheckIcon()
- protected override void Init()
- public override void LinkAssets()
- private void LinkWithActors()
- private void LinkWithBaseLibrary()
- private void LinkWithTraits()
- public void Localize(string Name = null, string Description = null, string Description2 = null)
- private void SetRarityAutomatically()

### public class NeoModLoader.utils.Builders.Builder

#### Constructors
- protected Builder()

#### Methods
- public virtual void Build(bool LinkWithOtherAssets)
- public abstract void LinkAssets()

### public class NeoModLoader.utils.Builders.ClanTraitBuilder
- Base: NeoModLoader.utils.Builders.BaseTraitBuilder<ClanTrait, ClanTraitLibrary>

#### Properties
- public BaseStats BaseStatsFemale { get; set; }
- public BaseStats BaseStatsMale { get; set; }

#### Constructors
- public ClanTraitBuilder(string ID)
- public ClanTraitBuilder(string FilePath, bool LoadImmediately)
- public ClanTraitBuilder(string ID, string CopyFrom)

### public class NeoModLoader.utils.Builders.CultureTraitBuilder
- Base: NeoModLoader.utils.Builders.BaseTraitBuilder<CultureTrait, CultureTraitLibrary>

#### Properties
- public PassableZoneChecker TownLayoutPlan { get; set; }
- public System.Collections.Generic.IEnumerable<string> Weapons { get; set; }
- public System.Collections.Generic.IEnumerable<string> WeaponSubTypes { get; set; }

#### Constructors
- public CultureTraitBuilder(string ID)
- public CultureTraitBuilder(string FilePath, bool LoadImmediately)
- public CultureTraitBuilder(string ID, string CopyFrom)

#### Methods
- public override void LinkAssets()

### public delegate NeoModLoader.utils.Builders.GetAdditionalBaseStatsMethod
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public GetAdditionalBaseStatsMethod(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Actor Actor, System.AsyncCallback callback, object object)
- public virtual BaseStats EndInvoke(System.IAsyncResult result)
- public virtual BaseStats Invoke(Actor Actor)

### public class NeoModLoader.utils.Builders.GroupAssetBuilder<A>
- Base: NeoModLoader.utils.Builders.AssetBuilder<A, AssetLibrary<A>>

#### Properties
- public string ColorHexCode { get; set; }
- public string Name { get; set; }

#### Constructors
- public GroupAssetBuilder<A>(string ID)
- public GroupAssetBuilder<A>(string FilePath, bool LoadImmediately)
- public GroupAssetBuilder<A>(string ID, string CopyFrom)

#### Methods
- public override void Build(bool LinkWithOtherAssets)
- public void Localize(string LocalName = null)
- public void SetColor(UnityEngine.Color color)

### public class NeoModLoader.utils.Builders.MasterBuilder

#### Fields
- private readonly System.Collections.Generic.List<NeoModLoader.utils.Builders.Builder> Builders

#### Constructors
- public MasterBuilder()

#### Methods
- public B AddBuilder<B>(B Builder)
- public void AddBuilders(System.Collections.Generic.IEnumerable<NeoModLoader.utils.Builders.Builder> Builders)
- public void BuildAll()

### public enum NeoModLoader.utils.Builders.SubSpeciesTrait
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Egg = 2
- PhenoType = 1
- SkinMutation = 3
- Trait = 0

### public class NeoModLoader.utils.Builders.SubspeciesTraitBuilder
- Base: NeoModLoader.utils.Builders.BaseTraitBuilder<SubspeciesTrait, SubspeciesTraitLibrary>

#### Properties
- public bool CanBeAddedFromMutations { get; set; }
- public bool CanbeRemovedFromMutations { get; set; }
- public bool DietRelated { get; set; }
- public bool DontRotateWhenUnconscious { get; set; }
- public System.Collections.Generic.List<string> FemaleSkins { get; set; }
- public System.ValueTuple<string[], float> IdleAnimation { get; set; }
- public System.Collections.Generic.List<string> MaleSkins { get; set; }
- public bool RemoveIfZombieSubSpecies { get; set; }
- public System.ValueTuple<string[], float> SwimAnimation { get; set; }
- public bool UsesSpecialIconLogic { get; set; }
- public System.ValueTuple<string[], float> WalkAnimation { get; set; }
- public System.Collections.Generic.List<string> WarriorSkins { get; set; }

#### Constructors
- public SubspeciesTraitBuilder(string ID, AfterHatchFromEggAction afterHatchFromEggAction)
- public SubspeciesTraitBuilder(string ID, NeoModLoader.utils.Builders.SubSpeciesTrait Type)
- public SubspeciesTraitBuilder(string FilePath, bool LoadImmediately)
- public SubspeciesTraitBuilder(string ID, string CopyFrom)
- public SubspeciesTraitBuilder(string ID, string OverridePath, bool RenderChildHeads)

#### Methods
- public override void Build(bool SetRarityAutomatically = false, bool AutoLocalize = true, bool LinkWithOtherAssets = false)
- public override void LinkAssets()
- private void LinkWithLibrary()
- private static string TraitToDerive(NeoModLoader.utils.Builders.SubSpeciesTrait trait)

### public class NeoModLoader.utils.Builders.UnlockableAssetBuilder<A, AL>
- Base: NeoModLoader.utils.Builders.AssetBuilder<A, AL>

#### Properties
- public string AchievmentToUnlockThis { get; set; }
- public BaseStats BaseStats { get; set; }
- public bool NeedsToBeExplored { get; set; }
- public string PathIcon { get; set; }
- public bool ShowInKnowledgeWindow { get; set; }
- public System.Collections.Generic.Dictionary<string, float> Stats { set; }

#### Constructors
- public UnlockableAssetBuilder<A, AL>(string ID)
- public UnlockableAssetBuilder<A, AL>(string FilePath, bool LoadImmediately)
- public UnlockableAssetBuilder<A, AL>(string ID, string CopyFrom)

#### Methods
- public override void LinkAssets()
- private void LinkWithAchievment()
- public void UnlockByDefault()

## Namespace: NeoModLoader.utils.installers

### private class NeoModLoader.utils.installers.GBModInstaller.<CheckInstall>d__2
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public NeoModLoader.utils.installers.GBModInstaller <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1
- private bool <addition_match>5__2
- private bool <base_match>5__7
- private System.Net.WebClient <client>5__4
- private System.Text.RegularExpressions.Match <match>5__1
- private string <mod_folder_path>5__6
- private string <url_to_archive>5__3
- private string <zip_file_path>5__5
- public string pParam

#### Constructors
- public GBModInstaller.<CheckInstall>d__2()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### internal class NeoModLoader.utils.installers.ACmdModInstaller

#### Constructors
- protected ACmdModInstaller()

#### Methods
- public abstract System.Threading.Tasks.Task<bool> CheckInstall(string pParam)

### internal class NeoModLoader.utils.installers.GBModInstaller
- Base: NeoModLoader.utils.installers.ACmdModInstaller

#### Fields
- private static const string addition_match_regex
- private static const string base_match_regex

#### Constructors
- public GBModInstaller()

#### Methods
- public override System.Threading.Tasks.Task<bool> CheckInstall(string pParam)

## Namespace: NeoModLoader.utils.instpredictors

### private class NeoModLoader.utils.instpredictors.BaseInstPredictor.<>c__DisplayClass3_0

#### Fields
- public System.Reflection.Emit.OpCode pOpCode

#### Constructors
- public BaseInstPredictor.<>c__DisplayClass3_0()

#### Methods
- internal bool <.ctor>b__0(HarmonyLib.CodeInstruction inst)

### private class NeoModLoader.utils.instpredictors.BaseInstPredictor.<>c__DisplayClass4_0

#### Fields
- public object pOperand

#### Constructors
- public BaseInstPredictor.<>c__DisplayClass4_0()

#### Methods
- internal bool <.ctor>b__0(HarmonyLib.CodeInstruction inst)

### private class NeoModLoader.utils.instpredictors.BaseInstPredictor.<>c__DisplayClass5_0

#### Fields
- public System.Reflection.Emit.OpCode pOpCode
- public object pOperand

#### Constructors
- public BaseInstPredictor.<>c__DisplayClass5_0()

#### Methods
- internal bool <.ctor>b__0(HarmonyLib.CodeInstruction inst)

### public class NeoModLoader.utils.instpredictors.BaseInstPredictor

#### Fields
- private static readonly System.Collections.Generic.Dictionary<System.Reflection.Emit.OpCode, System.Collections.Generic.HashSet<System.Reflection.Emit.OpCode>> equal_opcodes
- private readonly System.Func<HarmonyLib.CodeInstruction, bool> predicate

#### Constructors
- protected BaseInstPredictor()
- private static BaseInstPredictor()
- public BaseInstPredictor(System.Reflection.Emit.OpCode pOpCode)
- public BaseInstPredictor(object pOperand)
- public BaseInstPredictor(System.Func<HarmonyLib.CodeInstruction, bool> pPredicate)
- public BaseInstPredictor(System.Reflection.Emit.OpCode pOpCode, object pOperand)

#### Methods
- private static void AddEqualOpCodes(params System.Reflection.Emit.OpCode[] pOpCodes)
- protected static bool OpcodeEquals(System.Reflection.Emit.OpCode pOpCode, System.Reflection.Emit.OpCode pOpCodeAnother)
- protected static bool OpcodeEquals(HarmonyLib.CodeInstruction pInst, HarmonyLib.CodeInstruction pInstAnother)
- protected static bool OpcodeEquals(System.Reflection.Emit.OpCode pOpCode, HarmonyLib.CodeInstruction pInst)
- protected static bool OpcodeEquals(HarmonyLib.CodeInstruction pInst, System.Reflection.Emit.OpCode pOpCode)
- public virtual bool Predict(HarmonyLib.CodeInstruction pInst)
- internal static void _init()

## Namespace: NeoModLoader.utils.SerializedAssets

### public class NeoModLoader.utils.SerializedAssets.SerializableAsset<A>

#### Fields
- public System.Collections.Generic.Dictionary<string, string> Delegates
- public System.Collections.Generic.Dictionary<string, object> Variables

#### Constructors
- public SerializableAsset<A>()

#### Methods
- internal static object <Deserialize>g__GetRealValueOfObject|4_0(object Value, System.Type Type)
- public static void Deserialize(NeoModLoader.utils.SerializedAssets.SerializableAsset<A> Asset, A asset)
- public static NeoModLoader.utils.SerializedAssets.SerializableAsset<A> FromAsset(A Asset)
- public static void Serialize(A Asset, NeoModLoader.utils.SerializedAssets.SerializableAsset<A> asset)
- public static A ToAsset(NeoModLoader.utils.SerializedAssets.SerializableAsset<A> Asset)

### public class NeoModLoader.utils.SerializedAssets.SerializedActorTrait
- Base: NeoModLoader.utils.SerializedAssets.SerializableAsset<ActorTrait>

#### Fields
- public string AdditionalBaseStatsMethod

#### Constructors
- public SerializedActorTrait()

#### Methods
- public static NeoModLoader.utils.SerializedAssets.SerializedActorTrait FromAsset(ActorTrait Asset, NeoModLoader.utils.Builders.GetAdditionalBaseStatsMethod Method = null)
- public static ActorTrait ToAsset(NeoModLoader.utils.SerializedAssets.SerializedActorTrait Asset)

### public class NeoModLoader.utils.SerializedAssets.SerializedItemAsset
- Base: NeoModLoader.utils.SerializedAssets.SerializableAsset<ItemAsset>

#### Fields
- internal string[] CultureTraitsThisItemIsIn
- internal string[] CultureTraitsThisItemsTypeIsIn

#### Constructors
- public SerializedItemAsset()

#### Methods
- public static NeoModLoader.utils.SerializedAssets.SerializedItemAsset FromAsset(ItemAsset Asset, System.Collections.Generic.IEnumerable<string> cultureTraitsItem = null, System.Collections.Generic.IEnumerable<string> cultureTraitsType = null)
- public static ItemAsset ToAsset(NeoModLoader.utils.SerializedAssets.SerializedItemAsset Asset)

## Namespace: ReflectionUtility

### public static class ReflectionUtility.Reflection

#### Methods
- public static object CallMethod(object o, string methodName, params object[] args)
- public static object CallStaticMethod(System.Type type, string methodName, params object[] args)
- public static object GetField(System.Type type, object instance, string fieldName)
- public static void SetField<T>(object originalObject, string fieldName, T newValue)
- public static void SetStaticField<T>(System.Type objectType, string fieldName, T newValue)

## Namespace: System.Runtime.CompilerServices

### internal class System.Runtime.CompilerServices.NullableAttribute
- Base: System.Attribute

#### Fields
- public readonly byte[] NullableFlags

#### Constructors
- public NullableAttribute(byte )
- public NullableAttribute(byte[] )

### internal class System.Runtime.CompilerServices.NullableContextAttribute
- Base: System.Attribute

#### Fields
- public readonly byte Flag

#### Constructors
- public NullableContextAttribute(byte )

### internal class System.Runtime.CompilerServices.RefSafetyRulesAttribute
- Base: System.Attribute

#### Fields
- public readonly int Version

#### Constructors
- public RefSafetyRulesAttribute(int )

