#define DEBUG
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Versioning;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using DG.Tweening;
using FMOD;
using FMODUnity;
using Gameloop.Vdf;
using Gameloop.Vdf.Linq;
using HarmonyLib;
using HarmonyLib.Tools;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Text;
using ModDeclaration;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Pdb;
using Mono.Collections.Generic;
using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using MonoMod.Utils;
using NCMS;
using NCMS.Utils;
using NeoModLoader.General;
using NeoModLoader.General.Event;
using NeoModLoader.General.Event.Handlers;
using NeoModLoader.General.UI.Prefabs;
using NeoModLoader.General.UI.Tab;
using NeoModLoader.General.UI.Window;
using NeoModLoader.General.UI.Window.Layout;
using NeoModLoader.api;
using NeoModLoader.api.attributes;
using NeoModLoader.api.exceptions;
using NeoModLoader.constants;
using NeoModLoader.ncms_compatible_layer;
using NeoModLoader.services;
using NeoModLoader.ui;
using NeoModLoader.ui.prefabs;
using NeoModLoader.utils;
using NeoModLoader.utils.Builders;
using NeoModLoader.utils.SerializedAssets;
using NeoModLoader.utils.authentication;
using NeoModLoader.utils.installers;
using NeoModLoader.utils.instpredictors;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using RSG;
using Steamworks;
using Steamworks.Data;
using Steamworks.Ugc;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.U2D;
using UnityEngine.UI;
using YamlDotNet.Serialization;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints | DebuggableAttribute.DebuggingModes.EnableEditAndContinue)]
[assembly: TargetFramework(".NETFramework,Version=v4.8", FrameworkDisplayName = ".NET Framework 4.8")]
[assembly: AssemblyCompany("WorldBoxOpenMods")]
[assembly: AssemblyConfiguration("Debug")]
[assembly: AssemblyFileVersion("1.2.0.1")]
[assembly: AssemblyInformationalVersion("1.0.0+cd47a1a6c437718d38e8f29240bdb761d543e09a")]
[assembly: AssemblyProduct("NeoModLoader")]
[assembly: AssemblyTitle("NeoModLoader")]
[assembly: AssemblyMetadata("RepositoryUrl", "https://github.com/WorldBoxOpenMods/ModLoader")]
[assembly: SecurityPermission(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification = true)]
[assembly: AssemblyVersion("1.2.0.1")]
[module: UnverifiableCode]
[module: System.Runtime.CompilerServices.RefSafetyRules(11)]
namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
	}
}
namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		public readonly byte[] NullableFlags;

		public NullableAttribute(byte P_0)
		{
			NullableFlags = new byte[1] { P_0 };
		}

		public NullableAttribute(byte[] P_0)
		{
			NullableFlags = P_0;
		}
	}
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		public readonly byte Flag;

		public NullableContextAttribute(byte P_0)
		{
			Flag = P_0;
		}
	}
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Module, AllowMultiple = false, Inherited = false)]
	internal sealed class RefSafetyRulesAttribute : Attribute
	{
		public readonly int Version;

		public RefSafetyRulesAttribute(int P_0)
		{
			Version = P_0;
		}
	}
}
namespace ReflectionUtility
{
	[Obsolete("Compatible Layer will not be maintained and be removed in the future")]
	public static class Reflection
	{
		public static object CallMethod(this object o, string methodName, params object[] args)
		{
			Type type = o.GetType();
			MethodInfo method = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			while (type.BaseType != null && type != type.BaseType && method == null)
			{
				type = type.BaseType;
				method = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			}
			if (method == null)
			{
				throw new MissingMethodException(type.Name, methodName);
			}
			return method.Invoke(o, args);
		}

		public static object CallStaticMethod(Type type, string methodName, params object[] args)
		{
			MethodInfo method = type.GetMethod(methodName, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			if (method == null)
			{
				throw new MissingMethodException(type.Name, methodName);
			}
			return method.Invoke(null, args);
		}

		public static object GetField(Type type, object instance, string fieldName)
		{
			FieldInfo field = type.GetField(fieldName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			if (field == null)
			{
				throw new MissingFieldException(type.Name, fieldName);
			}
			return field.GetValue(instance);
		}

		public static void SetField<T>(object originalObject, string fieldName, T newValue)
		{
			Type type = originalObject.GetType();
			FieldInfo field = type.GetField(fieldName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			if (field == null)
			{
				throw new MissingFieldException(type.Name, fieldName);
			}
			field.SetValue(originalObject, newValue);
		}

		public static void SetStaticField<T>(Type objectType, string fieldName, T newValue)
		{
			RF.SetStaticField(fieldName, newValue, objectType);
		}
	}
}
namespace NCMS
{
	public class Core
	{
		public static string WBGamePath = ((Application.platform == RuntimePlatform.WindowsPlayer) ? (Application.dataPath + "/..") : (Application.dataPath + "/../.."));

		public static string ModsPath = Application.streamingAssetsPath + "/Mods";

		public static string ManagedPath = Application.streamingAssetsPath + "/../Managed";

		public static string NCMSPath = ModsPath + "/NCMS";

		public static string NCMSModsPath = WBGamePath + "/Mods";

		public static string CorePath = NCMSPath + "/Core";

		public static string AssembliesPath = CorePath + "/Assemblies";

		public static string TempPath = CorePath + "/Temp";
	}
	[Obsolete("Compatible Layer will not be maintained and be removed in the future")]
	[AttributeUsage(AttributeTargets.Class)]
	public class ModEntry : Attribute
	{
	}
	[Obsolete("Compatible Layer will not be maintained and be removed in the future")]
	public class ModLoader
	{
		public static List<NCMod> Mods;
	}
	[Obsolete("Compatible Layer will not be maintained and be removed in the future")]
	public class NCMod
	{
		public string author;

		public string description;

		public string iconPath;

		public string name;

		public string path;

		public int targetGameBuild = 444;

		public string version;
	}
	public class WorldBoxMod
	{
		private void Update()
		{
		}
	}
}
namespace NCMS.Utils
{
	[Obsolete("Compatible Layer will not be maintained and be removed in the future")]
	public enum ButtonType
	{
		Click,
		GodPower,
		Toggle
	}
	[Obsolete("Compatible Layer will not be maintained and be removed in the future")]
	public class GameObjects
	{
		[Obsolete("Use ResourcesFinder.FindResources<T>(string name) instead")]
		public static GameObject FindEvenInactive(string Name)
		{
			GameObject[] source = Resources.FindObjectsOfTypeAll<GameObject>();
			return source.FirstOrDefault((GameObject obj) => string.Equals(obj.name, Name, StringComparison.CurrentCultureIgnoreCase));
		}
	}
	[Obsolete("Compatible Layer will not be maintained and be removed in the future")]
	public class Localization
	{
		public static void Add(string key, string value)
		{
			LM.AddToCurrentLocale(key, value);
		}

		[Obsolete("Localization.addLocalization is deprecated, please use Localization.Add instead")]
		public static void addLocalization(string key, string value)
		{
			Add(key, value);
		}

		public static void Set(string key, string value)
		{
			Add(key, value);
		}

		[Obsolete("Localization.setLocalization is deprecated, please use Localization.Set instead")]
		public static void setLocalization(string key, string value)
		{
			Add(key, value);
		}

		public static void AddOrSet(string key, string value)
		{
			Add(key, value);
		}

		public static string Get(string key)
		{
			return LocalizedTextManager.instance._localized_text[key];
		}

		[Obsolete("Localization.getLocalization is deprecated, please use Localization.Get instead")]
		public static string getLocalization(string key)
		{
			return Get(key);
		}
	}
	[Obsolete("Compatible Layer will not be maintained and be removed in the future")]
	public class PowerButtons
	{
		private static Dictionary<string, PowerButton> toggle_buttons = new Dictionary<string, PowerButton>();

		public static Dictionary<string, PowerButton> CustomButtons = new Dictionary<string, PowerButton>();

		public static Dictionary<string, bool> ToggleValues = new Dictionary<string, bool>();

		public static PowerButton CreateButton(string name, Sprite sprite, string title, string description, Vector2 position, ButtonType type = ButtonType.Click, Transform parent = null, UnityAction call = null)
		{
			LM.AddToCurrentLocale(name, title);
			LM.AddToCurrentLocale(name + " Description", description);
			LM.ApplyLocale(pUpdateTexts: false);
			switch (type)
			{
			case ButtonType.Click:
			{
				PowerButton component = PowerButtonCreator.CreateSimpleButton(name, call, sprite, parent, position);
				CustomButtons[name] = component;
				return component;
			}
			case ButtonType.GodPower:
			{
				PowerButton component = PowerButtonCreator.CreateGodPowerButton(name, sprite, parent, position);
				if (call != null)
				{
					component._button.onClick.AddListener(call);
				}
				CustomButtons[name] = component;
				return component;
			}
			default:
				throw new ArgumentOutOfRangeException("type", type, null);
			case ButtonType.Toggle:
			{
				GameObject gameObject = ResourcesFinder.FindResource<PowerButton>("map_kings_leaders").gameObject;
				bool activeSelf = gameObject.activeSelf;
				gameObject.SetActive(value: false);
				GameObject gameObject2 = ((parent == null) ? UnityEngine.Object.Instantiate(gameObject) : UnityEngine.Object.Instantiate(gameObject, parent));
				gameObject.SetActive(activeSelf);
				gameObject2.transform.localPosition = position;
				PowerButton component = gameObject2.GetComponent<PowerButton>();
				Button component2 = gameObject2.GetComponent<Button>();
				component2.onClick.RemoveAllListeners();
				component.open_window_id = string.Empty;
				component.name = name;
				component.icon.sprite = sprite;
				component.type = PowerButtonType.Library;
				toggle_buttons[name] = component;
				ToggleValues.Add(name, value: false);
				component2.onClick.AddListener(delegate
				{
					ToggleButton(name);
				});
				if (call != null)
				{
					component2.onClick.AddListener(call);
				}
				gameObject2.transform.Find("ToggleIcon").GetComponent<ToggleIcon>().updateIcon(pEnabled: false);
				gameObject2.SetActive(value: true);
				CustomButtons[name] = component;
				return component;
			}
			}
		}

		public static Button CreateTextButton(string name, string text, Vector2 position, UnityEngine.Color color, Transform parent = null, UnityAction callback = null)
		{
			GameObject gameObject = new GameObject(name, typeof(UnityEngine.UI.Image), typeof(Button));
			if (parent != null)
			{
				gameObject.transform.SetParent(parent);
			}
			gameObject.transform.localScale = Vector3.one;
			gameObject.transform.localPosition = position;
			gameObject.GetComponent<UnityEngine.UI.Image>().sprite = SpriteTextureLoader.getSprite("ui/special/special_buttonRed");
			gameObject.GetComponent<UnityEngine.UI.Image>().color = color;
			gameObject.GetComponent<UnityEngine.UI.Image>().SetNativeSize();
			gameObject.GetComponent<Button>().onClick.AddListener(callback);
			GameObject gameObject2 = new GameObject(name + "_text", typeof(Text), typeof(Outline));
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.transform.localScale = Vector3.one;
			gameObject2.transform.localPosition = Vector3.zero;
			Text component = gameObject2.GetComponent<Text>();
			component.font = Resources.Load<Font>("fonts/roboto-bold");
			component.color = UnityEngine.Color.white;
			component.text = text;
			component.fontSize = 12;
			component.alignment = TextAnchor.MiddleCenter;
			gameObject2.GetComponent<RectTransform>().sizeDelta = gameObject.GetComponent<RectTransform>().sizeDelta;
			Outline component2 = gameObject2.GetComponent<Outline>();
			component2.effectDistance = new Vector2(1f, -1f);
			component2.effectColor = new UnityEngine.Color(0f, 0f, 0f, 0.2f);
			return gameObject.GetComponent<Button>();
		}

		public static void AddButtonToTab(PowerButton button, PowerTab tab, Vector2 position)
		{
			PowerButtonCreator.AddButtonToTab(button, PowerButtonCreator.GetTab("Tab_" + tab), position);
		}

		public static bool GetToggleValue(string name)
		{
			if (!toggle_buttons.TryGetValue(name, out var value))
			{
				throw new Exception("Toggle button added by NCMS Method not found for " + name);
			}
			if (value.transform.Find("ToggleIcon") == null)
			{
				throw new Exception("Toggle button added by NCMS Method is invalid for " + name);
			}
			GodPower godPower = AssetManager.powers.get(name);
			return (godPower == null) ? ToggleValues[name] : PlayerConfig.dict[godPower.toggle_name].boolVal;
		}

		public static void ToggleButton(string name)
		{
			if (toggle_buttons.TryGetValue(name, out var value))
			{
				Transform transform = value.transform.Find("ToggleIcon");
				if (value.transform.Find("ToggleIcon") == null)
				{
					throw new Exception("Toggle button added by NCMS Method is invalid for " + name);
				}
				GodPower godPower = AssetManager.powers.get(name);
				if (godPower == null)
				{
					ToggleValues[name] = !ToggleValues[name];
					transform.GetComponent<ToggleIcon>().updateIcon(ToggleValues[name]);
				}
				else
				{
					PlayerConfig.dict[godPower.toggle_name].boolVal = !PlayerConfig.dict[godPower.toggle_name].boolVal;
					value.checkToggleIcon();
				}
				return;
			}
			throw new Exception("Toggle button added by NCMS Method not found for " + name);
		}
	}
	public enum PowerTab
	{
		Main,
		Drawing,
		Kingdoms,
		Creatures,
		Nature,
		Bombs,
		Other
	}
	public class ResourcesPatch
	{
		internal static Dictionary<string, UnityEngine.Object> modsResources;

		internal static Dictionary<string, UnityEngine.Object> modsResourcesReplace = new Dictionary<string, UnityEngine.Object>();
	}
	public class Sprites
	{
		public static Sprite LoadSprite(string path, float offsetX = 0f, float offsetY = 0f)
		{
			Texture2D texture2D = new Texture2D(0, 0);
			texture2D.anisoLevel = 0;
			texture2D.filterMode = FilterMode.Point;
			texture2D.LoadImage(File.ReadAllBytes(path));
			return Sprite.Create(texture2D, new Rect(0f, 0f, texture2D.width, texture2D.height), new Vector2(offsetX, offsetY), 1f);
		}
	}
	[Obsolete("Compatible Layer will not be maintained and be removed in the future")]
	public class Windows
	{
		public static Dictionary<string, ScrollWindow> AllWindows;

		internal static void init()
		{
			AllWindows = ScrollWindow._all_windows;
		}

		public static ScrollWindow GetWindow(string pWindowID)
		{
			ScrollWindow value;
			return ScrollWindow._all_windows.TryGetValue(pWindowID, out value) ? value : null;
		}

		public static ScrollWindow CreateNewWindow(string pWindowID, string pWindowTitle)
		{
			if (!LocalizedTextManager.stringExists(pWindowID))
			{
				LM.AddToCurrentLocale(pWindowID, pWindowTitle);
			}
			ScrollWindow scrollWindow = WindowCreator.CreateEmptyWindow(pWindowID, pWindowID);
			scrollWindow.gameObject.transform.Find("Background/Title").GetComponent<LocalizedText>().setKeyAndUpdate(pWindowID);
			scrollWindow.gameObject.transform.Find("Background/Title").GetComponent<LocalizedText>().autoField = false;
			return scrollWindow;
		}

		public static void ShowWindow(string pWindowID)
		{
			ScrollWindow.showWindow(pWindowID);
		}
	}
}
namespace NCMS.Extensions
{
	public static class DictionaryRange
	{
		public static void AddRangeOverride<TKey, TValue>(this IDictionary<TKey, TValue> dic, IDictionary<TKey, TValue> dicToAdd)
		{
			foreach (TKey key in dicToAdd.Keys)
			{
				dic[key] = dicToAdd[key];
			}
		}

		public static void AddRangeNewOnly<TKey, TValue>(this IDictionary<TKey, TValue> dic, IDictionary<TKey, TValue> dicToAdd)
		{
			foreach (TKey key in dicToAdd.Keys)
			{
				if (!dic.ContainsKey(key))
				{
					dic[key] = dicToAdd[key];
				}
			}
		}

		public static void AddRange<TKey, TValue>(this IDictionary<TKey, TValue> dic, IDictionary<TKey, TValue> dicToAdd)
		{
			MonoMod.Utils.Extensions.AddRange(dic, dicToAdd);
		}

		public static bool ContainsKeys<TKey, TValue>(this IDictionary<TKey, TValue> dic, IEnumerable<TKey> keys)
		{
			foreach (TKey key in keys)
			{
				if (!dic.ContainsKey(key))
				{
					return false;
				}
			}
			return true;
		}

		public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
		{
			foreach (T item in source)
			{
				action(item);
			}
		}

		public static void ForEachOrBreak<T>(this IEnumerable<T> source, Func<T, bool> func)
		{
			foreach (T item in source)
			{
				if (func(item))
				{
					break;
				}
			}
		}
	}
}
namespace ModDeclaration
{
	[Obsolete("Compatible Layer will not be maintained and be removed in the future")]
	public class Info
	{
		public static readonly string DataPath = Application.dataPath;

		public static readonly string ModsPath = DataPath + "/StreamingAssets/Mods";

		public static readonly string NCMSPath = ModsPath + "/NCMS";

		public static readonly string NCMSModsPath = Paths.ModsPath;

		public readonly string Author;

		public readonly string Description;

		public readonly string IconPath;

		public readonly string Name;

		public readonly string Path;

		public readonly string Version;

		internal Info(NCMod mod)
		{
			Name = mod.name;
			Author = mod.author;
			Version = mod.version;
			Description = mod.description;
			IconPath = mod.iconPath;
			Path = mod.path;
		}
	}
}
namespace BepInEx
{
	public abstract class BaseUnityPlugin : MonoBehaviour
	{
	}
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class BepInPlugin : Attribute
	{
		public BepInPlugin(string id, string name, string version)
		{
		}
	}
}
namespace NeoModLoader
{
	public class WorldBoxMod : MonoBehaviour
	{
		public static List<IMod> LoadedMods = new List<IMod>();

		internal static Dictionary<ModDeclare, ModState> AllRecognizedMods = new Dictionary<ModDeclare, ModState>();

		internal static Transform Transform;

		internal static Transform InactiveTransform;

		internal static Assembly NeoModLoaderAssembly = Assembly.GetExecutingAssembly();

		private bool initialized = false;

		private bool initialized_successfully = false;

		private static void UnityExplorerFix()
		{
			Harmony harmony = new Harmony("wbom.nml");
			MethodInfo original = AccessTools.Method(typeof(Assembly), "LoadFrom", new Type[1] { typeof(string) });
			MethodInfo method = AccessTools.Method(typeof(WorldBoxMod), "LoadFrom");
			ReversePatcher reversePatcher = harmony.CreateReversePatcher(original, new HarmonyMethod(method));
			reversePatcher.Patch();
		}

		private static Assembly LoadFrom(string path)
		{
			return Assembly.LoadFrom(path);
		}

		private void Start()
		{
			Others.unity_player_enabled = true;
			Transform = base.transform;
			InactiveTransform = new GameObject("Inactive").transform;
			InactiveTransform.SetParent(Transform);
			InactiveTransform.gameObject.SetActive(value: false);
			LogService.Init();
			if (NeoModLoader.utils.ReflectionHelper.IsAssemblyLoaded("0Harmony"))
			{
				UnityExplorerFix();
			}
			fileSystemInitialize();
			LogService.LogInfo("NeoModLoader Version: " + InternalResourcesGetter.GetCommit());
		}

		private void Update()
		{
			if (!Config.game_loaded)
			{
				return;
			}
			if (initialized_successfully)
			{
				TabManager._checkNewTabs();
			}
			if (initialized)
			{
				return;
			}
			initialized = true;
			ModUploadAuthenticationService.AutoAuth();
			HarmonyUtils._init();
			Harmony.CreateAndPatchAll(typeof(LM), "wbom.nml");
			Harmony.CreateAndPatchAll(typeof(NeoModLoader.utils.ResourcesPatch), "wbom.nml");
			Harmony.CreateAndPatchAll(typeof(CustomAudioManager), "wbom.nml");
			Harmony.CreateAndPatchAll(typeof(AssetPatches), "wbom.nml");
			if (!SmoothLoader.isLoading())
			{
				SmoothLoader.prepare();
			}
			SmoothLoader.add(delegate
			{
				NeoModLoader.utils.ResourcesPatch.Initialize();
				LoadLocales();
				LM.ApplyLocale();
				TabManager._init();
				WindowCreator.init();
				ListenerManager._init();
				WrappedPowersTab._init();
				NCMSCompatibleLayer.PreInit();
				ModInfoUtils.InitializeModCompileCache();
			}, "Initialize NeoModLoader");
			List<ModDependencyNode> mod_nodes = new List<ModDependencyNode>();
			SmoothLoader.add(delegate
			{
				ModCompileLoadService.loadInfoOfBepInExPlugins();
				List<ModDeclare> mods = ModInfoUtils.findAndPrepareMods();
				mod_nodes.AddRange(ModDepenSolveService.SolveModDependencies(mods));
				ModCompileLoadService.prepareCompile(mod_nodes);
			}, "Load Mods Info And Prepare Mods");
			SmoothLoader.add(delegate
			{
				List<ModDeclare> mods_to_load = new List<ModDeclare>();
				foreach (ModDependencyNode mod in mod_nodes)
				{
					SmoothLoader.add(delegate
					{
						if (ModCompileLoadService.compileMod(mod))
						{
							mods_to_load.Add(mod.mod_decl);
						}
						else
						{
							LogService.LogError("Failed to compile mod " + mod.mod_decl.Name);
						}
					}, "Compile Mod " + mod.mod_decl.Name);
				}
				MasterBuilder Builder = new MasterBuilder();
				foreach (ModDependencyNode mod2 in mod_nodes)
				{
					SmoothLoader.add(delegate
					{
						if (mods_to_load.Contains(mod2.mod_decl))
						{
							NeoModLoader.utils.ResourcesPatch.LoadResourceFromFolder(Path.Combine(mod2.mod_decl.FolderPath, Paths.ModResourceFolderName), out var Builders);
							Builder.AddBuilders(Builders);
							NeoModLoader.utils.ResourcesPatch.LoadResourceFromFolder(Path.Combine(mod2.mod_decl.FolderPath, Paths.NCMSAdditionModResourceFolderName), out var Builders2);
							Builder.AddBuilders(Builders2);
							NeoModLoader.utils.ResourcesPatch.LoadAssetBundlesFromFolder(Path.Combine(mod2.mod_decl.FolderPath, Paths.ModAssetBundleFolderName));
						}
					}, "Load Resources From Mod " + mod2.mod_decl.Name);
				}
				SmoothLoader.add(delegate
				{
					ModCompileLoadService.loadMods(mods_to_load);
					Builder.BuildAll();
					ModInfoUtils.SaveModRecords();
					NCMSCompatibleLayer.Init();
					Dictionary<IMod, bool> successfulInit = new Dictionary<IMod, bool>();
					foreach (IMod mod3 in LoadedMods.Where((IMod mod5) => mod5 is IStagedLoad))
					{
						SmoothLoader.add(delegate
						{
							successfulInit.Add(mod3, ModCompileLoadService.TryInitMod(mod3));
						}, "Init Mod " + mod3.GetDeclaration().Name);
					}
					foreach (IMod mod4 in LoadedMods.Where((IMod mod5) => mod5 is IStagedLoad))
					{
						SmoothLoader.add(delegate
						{
							if (successfulInit.ContainsKey(mod4) && successfulInit[mod4])
							{
								ModCompileLoadService.PostInitMod(mod4);
							}
						}, "Post-Init Mod " + mod4.GetDeclaration().Name);
					}
				}, "Load Mods");
				SmoothLoader.add(delegate
				{
					ModWorkshopService.Init();
					UIManager.init();
					ModInfoUtils.DealWithBepInExModLinkRequests();
					LM.ApplyLocale();
					initialized_successfully = true;
				}, "NeoModLoader Post Initialize");
				SmoothLoader.add(ExternalModInstallService.CheckExternalModInstall, "Check External Mods to Install");
			}, "Compile Mods And Load resources");
		}

		private void LoadLocales()
		{
			string[] manifestResourceNames = NeoModLoaderAssembly.GetManifestResourceNames();
			string text = "NeoModLoader.resources.locales.";
			string[] array = manifestResourceNames;
			foreach (string text2 in array)
			{
				if (text2.StartsWith(text))
				{
					LM.LoadLocale(text2.Replace(text, "").Replace(".json", ""), NeoModLoaderAssembly.GetManifestResourceStream(text2));
				}
			}
		}

		private void fileSystemInitialize()
		{
			if (!Directory.Exists(Paths.ModsPath))
			{
				Directory.CreateDirectory(Paths.ModsPath);
				LogService.LogInfo("Create Mods folder at " + Paths.ModsPath);
			}
			if (!Directory.Exists(Paths.CompiledModsPath))
			{
				Directory.CreateDirectory(Paths.CompiledModsPath);
				LogService.LogInfo("Create CompiledMods folder at " + Paths.CompiledModsPath);
			}
			if (!Directory.Exists(Paths.ModsConfigPath))
			{
				Directory.CreateDirectory(Paths.ModsConfigPath);
				LogService.LogInfo("Create mods_config folder at " + Paths.ModsConfigPath);
			}
			if (!File.Exists(Paths.ModCompileRecordPath))
			{
				File.Create(Paths.ModCompileRecordPath).Close();
				LogService.LogInfo("Create mod_compile_records.json at " + Paths.ModCompileRecordPath);
			}
			if (!Directory.Exists(Paths.NMLAssembliesPath))
			{
				Directory.CreateDirectory(Paths.NMLAssembliesPath);
				LogService.LogInfo("Create NMLAssemblies folder at " + Paths.NMLAssembliesPath);
				extractAssemblies();
			}
			else
			{
				DateTime lastWriteTime = new FileInfo(Paths.NMLModPath).LastWriteTime;
				DateTime creationTime = new DirectoryInfo(Paths.NMLAssembliesPath).CreationTime;
				if (lastWriteTime > creationTime)
				{
					LogService.LogInfo("NeoModLoader.dll is newer than assemblies in NMLAssemblies folder, re-extract assemblies from NeoModLoader.dll");
					UnityEngine.Debug.Log(Paths.NMLAssembliesPath);
					Directory.Delete(Paths.NMLAssembliesPath, recursive: true);
					Directory.CreateDirectory(Paths.NMLAssembliesPath);
					LogService.LogInfo("Create new NMLAssemblies folder at " + Paths.NMLAssembliesPath);
					extractAssemblies();
				}
			}
			try
			{
				using Stream stream = NeoModLoaderAssembly.GetManifestResourceStream("NeoModLoader.resources.assemblies.Assembly-CSharp-Publicized.dll");
				if (File.Exists(Paths.PublicizedAssemblyPath))
				{
					DateTime lastWriteTime2 = new FileInfo(Paths.NMLModPath).LastWriteTime;
					DateTime creationTime2 = new FileInfo(Paths.PublicizedAssemblyPath).CreationTime;
					if (lastWriteTime2 > creationTime2)
					{
						LogService.LogInfo("NeoModLoader.dll is newer than Assembly-CSharp-Publicized.dll, re-extract Assembly-CSharp-Publicized.dll from NeoModLoader.dll");
						File.Delete(Paths.PublicizedAssemblyPath);
						using FileStream destination = new FileStream(Paths.PublicizedAssemblyPath, FileMode.Create, FileAccess.Write);
						stream.CopyTo(destination);
					}
				}
				else
				{
					using FileStream destination2 = new FileStream(Paths.PublicizedAssemblyPath, FileMode.CreateNew, FileAccess.Write);
					stream.CopyTo(destination2);
				}
			}
			catch (UnauthorizedAccessException)
			{
				File.Delete(Paths.PublicizedAssemblyPath);
				using Stream stream2 = NeoModLoaderAssembly.GetManifestResourceStream("NeoModLoader.resources.assemblies.Assembly-CSharp-Publicized.dll");
				using FileStream destination3 = new FileStream(Paths.PublicizedAssemblyPath, FileMode.CreateNew, FileAccess.Write);
				stream2.CopyTo(destination3);
			}
			string[] files = Directory.GetFiles(Paths.NMLAssembliesPath, "*.dll");
			foreach (string text in files)
			{
				try
				{
					LoadFrom(text);
				}
				catch (BadImageFormatException)
				{
					LogService.LogError("BadImageFormatException: The file " + text + " is not a valid assembly.");
				}
				catch (Exception ex3)
				{
					LogService.LogError("Exception: Failed to load assembly " + text + ".");
					LogService.LogError(ex3.Message);
					LogService.LogError(ex3.StackTrace);
				}
			}
			File.WriteAllText(Paths.NMLCommitPath, InternalResourcesGetter.GetCommit());
			if (File.Exists(Paths.NMLAutoUpdateModulePath))
			{
				FileInfo fileInfo = new FileInfo(Paths.NMLAutoUpdateModulePath);
				if (fileInfo.LastWriteTimeUtc.Ticks < InternalResourcesGetter.GetLastWriteTime())
				{
					try
					{
						fileInfo.Delete();
						LogService.LogInfo("NeoModLoader.dll is newer than AutoUpdate.dll, re-extract AutoUpdate.dll from NeoModLoader.dll");
					}
					catch (Exception)
					{
					}
				}
			}
			if (File.Exists(Paths.NMLAutoUpdateModulePath))
			{
				return;
			}
			using (Stream stream3 = NeoModLoaderAssembly.GetManifestResourceStream("NeoModLoader.resources.assemblies.NeoModLoader.AutoUpdate.dll"))
			{
				using FileStream destination4 = new FileStream(Paths.NMLAutoUpdateModulePath, FileMode.CreateNew, FileAccess.Write);
				stream3.CopyTo(destination4);
			}
			static void extractAssemblies()
			{
				string[] manifestResourceNames = NeoModLoaderAssembly.GetManifestResourceNames();
				string[] array = manifestResourceNames;
				foreach (string text2 in array)
				{
					if (text2.EndsWith(".dll") && !text2.Contains("Assembly-CSharp-Publicized") && !text2.Contains("AutoUpdate"))
					{
						string path = text2.Replace("NeoModLoader.resources.assemblies.", "");
						string path2 = Path.Combine(Paths.NMLAssembliesPath, path).Replace("-renamed", "");
						using Stream stream4 = NeoModLoaderAssembly.GetManifestResourceStream(text2);
						using FileStream destination5 = new FileStream(path2, FileMode.Create, FileAccess.Write);
						stream4.CopyTo(destination5);
					}
				}
			}
		}
	}
}
namespace NeoModLoader.utils
{
	public class WrappedAssetBundle
	{
		private class AssetNode
		{
			public readonly Dictionary<string, AssetNode> children = new Dictionary<string, AssetNode>();

			public readonly List<string> resources_full_names = new List<string>();
		}

		private readonly AssetBundle assetBundle;

		private readonly Dictionary<string, AssetNode> direct_visit = new Dictionary<string, AssetNode>();

		private readonly AssetNode root = new AssetNode();

		public string Name => assetBundle.name;

		internal WrappedAssetBundle(AssetBundle ab)
		{
			assetBundle = ab;
			string[] allAssetNames = ab.GetAllAssetNames();
			string[] array = allAssetNames;
			foreach (string text in array)
			{
				string[] array2 = text.Split(new char[1] { '/' });
				AssetNode assetNode = root;
				for (int j = 0; j < array2.Length - 1; j++)
				{
					string key = array2[j];
					if (!assetNode.children.TryGetValue(key, out var value))
					{
						value = new AssetNode();
						assetNode.children[key] = value;
					}
					assetNode = value;
				}
				assetNode.resources_full_names.Add(text);
			}
		}

		public string[] GetAllAssetNames()
		{
			return assetBundle.GetAllAssetNames();
		}

		public string[] GetAllScenePaths()
		{
			return assetBundle.GetAllScenePaths();
		}

		public UnityEngine.Object GetObject(string pName)
		{
			return assetBundle.LoadAsset(pName);
		}

		public UnityEngine.Object GetObject(string pName, Type type)
		{
			return assetBundle.LoadAsset(pName, type);
		}

		public T GetObject<T>(string pName) where T : UnityEngine.Object
		{
			return assetBundle.LoadAsset<T>(pName);
		}

		public UnityEngine.Object[] GetAllObjects(Type pType)
		{
			return assetBundle.LoadAllAssets(pType);
		}

		public T[] GetAllObjects<T>() where T : UnityEngine.Object
		{
			return assetBundle.LoadAllAssets<T>();
		}

		public UnityEngine.Object[] GetAllObjects(string pPath, Type pType)
		{
			pPath = pPath.ToLower();
			if (!direct_visit.TryGetValue(pPath, out var value))
			{
				value = root;
				string[] array = pPath.ToLower().Split(new char[1] { '/' });
				foreach (string key in array)
				{
					if (!value.children.ContainsKey(key))
					{
						return null;
					}
					value = value.children[key];
				}
				direct_visit[pPath] = value;
			}
			if (value.resources_full_names.Count == 0)
			{
				return null;
			}
			List<UnityEngine.Object> list = new List<UnityEngine.Object>();
			foreach (string resources_full_name in value.resources_full_names)
			{
				UnityEngine.Object obj = assetBundle.LoadAsset(resources_full_name, pType);
				if (obj != null)
				{
					list.Add(obj);
				}
			}
			return list.ToArray();
		}

		public T[] GetAllObjects<T>(string pPath) where T : UnityEngine.Object
		{
			pPath = pPath.ToLower();
			if (!direct_visit.TryGetValue(pPath, out var value))
			{
				value = root;
				string[] array = pPath.ToLower().Split(new char[1] { '/' });
				foreach (string key in array)
				{
					if (!value.children.ContainsKey(key))
					{
						return null;
					}
					value = value.children[key];
				}
				direct_visit[pPath] = value;
			}
			if (value.resources_full_names.Count == 0)
			{
				return null;
			}
			List<T> list = new List<T>();
			foreach (string resources_full_name in value.resources_full_names)
			{
				T val = assetBundle.LoadAsset<T>(resources_full_name);
				if (val != null)
				{
					list.Add(val);
				}
			}
			return list.ToArray();
		}
	}
	public static class AssetBundleUtils
	{
		private static readonly Dictionary<string, WrappedAssetBundle> LoadedAssetBundles = new Dictionary<string, WrappedAssetBundle>();

		private static readonly Dictionary<string, WrappedAssetBundle> LoadedAssetBundlesByPath = new Dictionary<string, WrappedAssetBundle>();

		public static WrappedAssetBundle GetAssetBundle(string name)
		{
			return LoadedAssetBundles[name];
		}

		public static WrappedAssetBundle LoadFromFile(string pPath, bool pForceReload = false)
		{
			FileInfo fileInfo = new FileInfo(pPath);
			if (LoadedAssetBundlesByPath.ContainsKey(fileInfo.FullName) && !pForceReload)
			{
				return LoadedAssetBundlesByPath[fileInfo.FullName];
			}
			using Stream stream = fileInfo.OpenRead();
			WrappedAssetBundle wrappedAssetBundle = new WrappedAssetBundle(AssetBundle.LoadFromStream(stream));
			LoadedAssetBundlesByPath[fileInfo.FullName] = wrappedAssetBundle;
			LoadedAssetBundles[wrappedAssetBundle.Name] = wrappedAssetBundle;
			return wrappedAssetBundle;
		}

		public static WrappedAssetBundle[] LoadFromFolder(string pFolder)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(pFolder);
			FileInfo[] files = directoryInfo.GetFiles();
			List<WrappedAssetBundle> list = new List<WrappedAssetBundle>();
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				if (fileInfo.Extension != ".manifest")
				{
					try
					{
						list.Add(LoadFromFile(fileInfo.FullName));
					}
					catch (Exception arg)
					{
						LogService.LogError($"Failed to load asset bundle {fileInfo.FullName}.\n{arg}");
					}
				}
			}
			return list.ToArray();
		}
	}
	internal static class BenchUtils
	{
		private static Dictionary<string, float> bench = new Dictionary<string, float>();

		public static void Start(string key)
		{
			if (!bench.ContainsKey(key))
			{
				bench.Add(key, 0f);
			}
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			bench[key] = realtimeSinceStartup;
		}

		public static float End(string key)
		{
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			if (bench.TryGetValue(key, out var value))
			{
				return realtimeSinceStartup - value;
			}
			return -1f;
		}
	}
	internal class AssetPatches
	{
		[HarmonyPatch(typeof(Actor), "updateStats")]
		[HarmonyTranspiler]
		private static IEnumerable<CodeInstruction> MergeWithCustomStats(IEnumerable<CodeInstruction> instructions)
		{
			CodeMatcher codeMatcher = new CodeMatcher(instructions);
			codeMatcher.MatchForward(false, new CodeMatch(System.Reflection.Emit.OpCodes.Callvirt, AccessTools.Method(typeof(BaseStats), "clear")));
			codeMatcher.Advance(1);
			codeMatcher.Insert(new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_0), new CodeInstruction(System.Reflection.Emit.OpCodes.Call, AccessTools.Method(typeof(AssetPatches), "MergeCustomStats")));
			return codeMatcher.Instructions();
		}

		private static void MergeCustomStats(Actor __instance)
		{
			foreach (ActorTrait trait in __instance.traits)
			{
				if (ActorTraitBuilder.AdditionalBaseStatMethods.TryGetValue(trait.id, out var value))
				{
					((BaseSimObject)__instance).stats.mergeStats(value(__instance), 1f);
				}
			}
		}

		private static BaseStats[] GetCustomStats(ActorTrait trait)
		{
			if (SelectedUnit.unit == null || !SelectedUnit.unit.hasTrait(trait))
			{
				return Array.Empty<BaseStats>();
			}
			if (!ActorTraitBuilder.AdditionalBaseStatMethods.TryGetValue(trait.id, out var value))
			{
				return Array.Empty<BaseStats>();
			}
			return new BaseStats[1] { value(SelectedUnit.unit) };
		}

		[HarmonyPatch(typeof(TooltipLibrary), "showTrait")]
		[HarmonyTranspiler]
		private static IEnumerable<CodeInstruction> ShowCustomStats(IEnumerable<CodeInstruction> instructions)
		{
			CodeMatcher codeMatcher = new CodeMatcher(instructions);
			codeMatcher.MatchForward(false, new CodeMatch(System.Reflection.Emit.OpCodes.Call, AccessTools.Field(typeof(Array), "Empty")));
			codeMatcher.RemoveInstruction();
			codeMatcher.Insert(new CodeInstruction(System.Reflection.Emit.OpCodes.Ldloc_0), new CodeInstruction(System.Reflection.Emit.OpCodes.Call, AccessTools.Method(typeof(AssetPatches), "GetCustomStats")));
			return codeMatcher.Instructions();
		}
	}
	public static class DelegateExtentions
	{
		public static Type[] GetDelegateParameters(this Type delegateType)
		{
			MethodInfo method = delegateType.GetMethod("Invoke");
			ParameterInfo[] parameters = method.GetParameters();
			Type[] array = new Type[parameters.Length];
			for (int i = 0; i < parameters.Length; i++)
			{
				array[i] = parameters[i].ParameterType;
			}
			return array;
		}

		public static D AsDelegate<D>(this string String) where D : Delegate
		{
			return (D)String.AsDelegate(typeof(D));
		}

		public static Delegate AsDelegate(this string String, Type DelegateType = null)
		{
			if (String == null)
			{
				throw new ArgumentNullException("The String is null!");
			}
			if (String.Contains("&"))
			{
				string[] array = String.Split(new char[1] { '&' });
				if ((object)DelegateType == null)
				{
					DelegateType = Type.GetType(array[0]);
				}
				String = array[1];
			}
			string[] array2 = String.Split(new char[1] { '+' });
			Delegate[] array3 = new Delegate[array2.Length];
			Type[] types = DelegateType?.GetDelegateParameters() ?? throw new ArgumentException("The String Does Not Contain the delegate type!");
			for (int i = 0; i < array2.Length; i++)
			{
				string[] array4 = array2[i].Split(new char[1] { ':' });
				MethodInfo method = Type.GetType(array4[0]).GetMethod(array4[1], BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, types, null);
				array3[i] = method.CreateDelegate(DelegateType);
			}
			return Delegate.Combine(array3);
		}

		public static string AsString(this Delegate pDelegate, bool IncludeType = false)
		{
			Delegate[] array = pDelegate?.GetInvocationList() ?? throw new ArgumentNullException("The Delegate is null!");
			string[] array2 = new string[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				MethodInfo method = array[i].Method;
				array2[i] = method.DeclaringType.AssemblyQualifiedName + ":" + method.Name;
			}
			string text = string.Join("+", array2);
			if (IncludeType)
			{
				text = string.Join("&", pDelegate.GetType().AssemblyQualifiedName, text);
			}
			return text;
		}
	}
	public static class HarmonyUtils
	{
		public static int FindCodeSnippet(List<CodeInstruction> pCodes, out List<CodeInstruction> pResult, params BaseInstPredictor[] pSnippetPredictors)
		{
			int i;
			for (i = 0; i < pCodes.Count - pSnippetPredictors.Length; i++)
			{
				if (!pSnippetPredictors.Where((BaseInstPredictor t, int j) => !t.Predict(pCodes[i + j])).Any())
				{
					pResult = pCodes.GetRange(i, pSnippetPredictors.Length);
					return i;
				}
			}
			pResult = null;
			return -1;
		}

		public static int FindCodeSnippetIdx(List<CodeInstruction> pCodes, params BaseInstPredictor[] pSnippetPredictors)
		{
			int i;
			for (i = 0; i < pCodes.Count - pSnippetPredictors.Length; i++)
			{
				if (!pSnippetPredictors.Where((BaseInstPredictor t, int j) => !t.Predict(pCodes[i + j])).Any())
				{
					return i;
				}
			}
			return -1;
		}

		public static CodeInstruction FindInst(List<CodeInstruction> pCodes, BaseInstPredictor pPredictor)
		{
			return pCodes.FirstOrDefault(pPredictor.Predict);
		}

		public static TOperand FindInstOperand<TOperand>(List<CodeInstruction> pCodes, BaseInstPredictor pPredictor)
		{
			CodeInstruction codeInstruction = FindInst(pCodes, pPredictor);
			if (codeInstruction == null)
			{
				return default(TOperand);
			}
			return (codeInstruction.operand is TOperand val) ? val : default(TOperand);
		}

		public static int FindInstIdx<TOperand>(List<CodeInstruction> pCodes, BaseInstPredictor pPredictor)
		{
			for (int i = 0; i < pCodes.Count; i++)
			{
				if (pPredictor.Predict(pCodes[i]))
				{
					return i;
				}
			}
			return -1;
		}

		internal static void _init()
		{
			BaseInstPredictor._init();
		}
	}
	public static class HttpUtils
	{
		public static HttpResponseMessage Get(string url, Dictionary<string, string> headers)
		{
			using HttpClient httpClient = new HttpClient();
			httpClient.DefaultRequestHeaders.Clear();
			foreach (KeyValuePair<string, string> header in headers)
			{
				httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
			}
			return httpClient.GetAsync(url).Result;
		}

		public static string Post(string url, Dictionary<string, string> @params, Dictionary<string, string> headers = null, double timeout = 30.0)
		{
			using HttpClient httpClient = new HttpClient();
			FormUrlEncodedContent content = new FormUrlEncodedContent(@params);
			if (headers != null)
			{
				httpClient.DefaultRequestHeaders.Clear();
				foreach (KeyValuePair<string, string> header in headers)
				{
					httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
				}
			}
			httpClient.Timeout = TimeSpan.FromSeconds(timeout);
			try
			{
				HttpResponseMessage result = httpClient.PostAsync(url, content).Result;
				return (result.StatusCode == HttpStatusCode.OK) ? result.Content.ReadAsStringAsync().Result : "";
			}
			catch (Exception ex)
			{
				LogService.LogErrorConcurrent(ex.Message);
				LogService.LogErrorConcurrent(ex.StackTrace);
			}
			return "";
		}

		public static string Request(string url, string param = "", string method = "get")
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			string result = "";
			HttpWebRequest httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
			HttpWebResponse httpWebResponse = null;
			if (httpWebRequest == null)
			{
				return result;
			}
			httpWebRequest.Method = method;
			httpWebRequest.ContentType = "application/octet-stream";
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/57.0.2987.133 Safari/537.36";
			byte[] bytes = Encoding.GetEncoding("UTF-8").GetBytes(param);
			if (bytes.Length != 0)
			{
				httpWebRequest.ContentLength = bytes.Length;
				httpWebRequest.Timeout = 15000;
				Stream requestStream = httpWebRequest.GetRequestStream();
				requestStream.Write(bytes, 0, bytes.Length);
				requestStream.Flush();
				requestStream.Close();
				try
				{
					httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
					Stream responseStream = httpWebResponse.GetResponseStream();
					Encoding encoding = Encoding.GetEncoding("UTF-8");
					StreamReader streamReader = new StreamReader(responseStream, encoding);
					result = streamReader.ReadToEnd();
				}
				catch (Exception ex)
				{
					LogService.LogErrorConcurrent(ex.Message);
					return result;
				}
			}
			else
			{
				try
				{
					httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
					Stream responseStream2 = httpWebResponse.GetResponseStream();
					Encoding encoding2 = Encoding.GetEncoding("UTF-8");
					StreamReader streamReader2 = new StreamReader(responseStream2, encoding2);
					result = streamReader2.ReadToEnd();
					streamReader2.Close();
				}
				catch (Exception ex2)
				{
					LogService.LogErrorConcurrent(ex2.Message);
					return result;
				}
			}
			return result;
		}
	}
	internal static class InternalResourcesGetter
	{
		private static Sprite mod_icon;

		private static Sprite icon_frame;

		private static Sprite icon_reload;

		private static Sprite github_icon;

		private static Sprite window_empty_frame;

		private static Sprite window_big_close;

		private static Sprite window_vert_name_plate;

		private static string commit = "";

		private static long last_write_time;

		private static Texture2D LoadManifestTexture(string path_under_resources)
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("NeoModLoader.resources." + path_under_resources);
			byte[] array = new byte[manifestResourceStream.Length];
			manifestResourceStream.Read(array, 0, array.Length);
			Texture2D texture2D = new Texture2D(0, 0);
			texture2D.filterMode = FilterMode.Point;
			texture2D.LoadImage(array);
			return texture2D;
		}

		private static byte[] LoadManifestBytes(string path_under_resources)
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("NeoModLoader.resources." + path_under_resources);
			byte[] array = new byte[manifestResourceStream.Length];
			manifestResourceStream.Read(array, 0, array.Length);
			return array;
		}

		public static long GetLastWriteTime()
		{
			if (last_write_time == 0)
			{
				FileInfo fileInfo = new FileInfo(Paths.NMLModPath);
				last_write_time = fileInfo.LastWriteTimeUtc.Ticks;
			}
			return last_write_time;
		}

		public static string GetCommit()
		{
			if (string.IsNullOrEmpty(commit))
			{
				Stream manifestResourceStream = WorldBoxMod.NeoModLoaderAssembly.GetManifestResourceStream("NeoModLoader.resources.commit");
				commit = new StreamReader(manifestResourceStream).ReadToEnd().Replace("\n", "").Replace("\r", "");
				manifestResourceStream.Close();
			}
			return commit;
		}

		public static Sprite GetIcon()
		{
			if (mod_icon != null)
			{
				return mod_icon;
			}
			SpriteTextureLoader.addSprite("ui/icons/neomodloader", LoadManifestBytes("logo.png"));
			mod_icon = SpriteTextureLoader.getSprite("ui/icons/neomodloader");
			mod_icon.name = "NeoModLoader";
			ResourcesPatch.PatchResource("ui/icons/neomodloader", mod_icon);
			return mod_icon;
		}

		public static Sprite GetIconFrame()
		{
			if (icon_frame != null)
			{
				return icon_frame;
			}
			Texture2D texture2D = LoadManifestTexture("square_frame_only.png");
			icon_frame = Sprite.Create(texture2D, new Rect(0f, 0f, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f), 1f, 0u, SpriteMeshType.Tight, new Vector4(7f, 7f, 7f, 7f));
			return icon_frame;
		}

		public static Sprite GetGitHubIcon()
		{
			if (github_icon != null)
			{
				return github_icon;
			}
			SpriteTextureLoader.addSprite("ui/icons/iconGithub", LoadManifestBytes("github.png"));
			github_icon = SpriteTextureLoader.getSprite("ui/icons/iconGithub");
			github_icon.name = "iconGithub";
			return github_icon;
		}

		public static Sprite GetReloadIcon()
		{
			if (icon_reload != null)
			{
				return icon_reload;
			}
			Texture2D texture2D = LoadManifestTexture("reload.png");
			icon_reload = Sprite.Create(texture2D, new Rect(0f, 0f, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f), 1f, 0u, SpriteMeshType.Tight, new Vector4(0f, 0f, 0f, 0f));
			return icon_reload;
		}

		public static Sprite GetWindowEmptyFrame()
		{
			if (window_empty_frame != null)
			{
				return window_empty_frame;
			}
			Texture2D texture = LoadManifestTexture("window_empty_frame.png");
			window_empty_frame = Sprite.Create(texture, new Rect(0f, 0f, 216f, 252f), new Vector2(0.5f, 0.5f), 1f, 1u, SpriteMeshType.Tight, new Vector4(12f, 12f, 12f, 12f));
			window_empty_frame.name = "windowEmptyFrame";
			SpriteTextureLoader._cached_sprites["ui/special/" + window_empty_frame.name] = window_empty_frame;
			return window_empty_frame;
		}

		public static Sprite GetWindowBigCloseSliced()
		{
			if (window_big_close != null)
			{
				return window_big_close;
			}
			Texture2D texture = LoadManifestTexture("windowBigCloseSliced.png");
			window_big_close = Sprite.Create(texture, new Rect(0f, 0f, 36f, 35f), new Vector2(0.5f, 0.5f), 1f, 1u, SpriteMeshType.Tight, new Vector4(8f, 8f, 8f, 8f));
			window_big_close.name = "windowBigCloseSliced";
			SpriteTextureLoader._cached_sprites["ui/special/" + window_big_close.name] = window_big_close;
			return window_big_close;
		}

		public static Sprite GetWindowVertNamePlate()
		{
			if (window_vert_name_plate != null)
			{
				return window_vert_name_plate;
			}
			Texture2D texture = LoadManifestTexture("windowVertNamePlate.png");
			window_vert_name_plate = Sprite.Create(texture, new Rect(0f, 0f, 18f, 43f), new Vector2(0.5f, 0.5f), 1f, 1u, SpriteMeshType.Tight, new Vector4(2f, 2f, 2f, 2f));
			window_vert_name_plate.name = "windowVertNamePlate";
			SpriteTextureLoader._cached_sprites["ui/special/" + window_vert_name_plate.name] = window_vert_name_plate;
			return window_vert_name_plate;
		}
	}
	public class ModDependencyNode
	{
		public HashSet<ModDependencyNode> depend_by;

		public HashSet<ModDependencyNode> depend_on;

		public HashSet<ModDependencyNode> necessary_depend_on;

		public ModDeclare mod_decl { get; }

		public ModDependencyNode(ModDeclare pModDecl)
		{
			mod_decl = pModDecl;
			necessary_depend_on = new HashSet<ModDependencyNode>();
			depend_on = new HashSet<ModDependencyNode>();
			depend_by = new HashSet<ModDependencyNode>();
		}

		public List<string> GetAdditionReferences(bool recursive = true)
		{
			List<string> list = new List<string>();
			string path = Path.Combine(mod_decl.FolderPath, "Assemblies");
			if (Directory.Exists(path))
			{
				list.AddRange(Directory.GetFiles(path, "*.dll"));
			}
			if (recursive)
			{
				foreach (ModDependencyNode item in depend_on)
				{
					list.AddRange(item.GetAdditionReferences());
				}
			}
			return list;
		}
	}
	public class ModDependencyGraph
	{
		public HashSet<ModDependencyNode> nodes;

		public ModDependencyGraph(ICollection<ModDeclare> mods)
		{
			Dictionary<string, ModDependencyNode> dictionary = new Dictionary<string, ModDependencyNode>();
			foreach (ModDeclare mod in mods)
			{
				dictionary.Add(mod.UID, new ModDependencyNode(mod));
			}
			foreach (ModDeclare mod2 in mods)
			{
				ModDependencyNode modDependencyNode = dictionary[mod2.UID];
				string[] dependencies = mod2.Dependencies;
				foreach (string key in dependencies)
				{
					if (dictionary.TryGetValue(key, out var value))
					{
						value.depend_by.Add(modDependencyNode);
						modDependencyNode.necessary_depend_on.Add(value);
					}
				}
				modDependencyNode.depend_on.UnionWith(modDependencyNode.necessary_depend_on);
				string[] optionalDependencies = mod2.OptionalDependencies;
				foreach (string key2 in optionalDependencies)
				{
					if (dictionary.TryGetValue(key2, out var value2))
					{
						value2.depend_by.Add(modDependencyNode);
						modDependencyNode.depend_on.Add(value2);
					}
				}
			}
			nodes = new HashSet<ModDependencyNode>();
			nodes.UnionWith(dictionary.Values);
			ModDependencyUtils.RemoveModsWithoutRequiredDependencies(this);
		}
	}
	internal static class ModDependencyUtils
	{
		public static string ParseDepenNameToPreprocessSymbol(string pDepenName)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (char c in pDepenName)
			{
				stringBuilder.Append((!char.IsLetterOrDigit(c) && c <= 'Ā') ? '_' : char.ToUpper(c));
			}
			return stringBuilder.ToString();
		}

		public static ModDependencyNode TryToAppendMod(ModDependencyGraph pGraph, ModDeclare pModAppend)
		{
			bool flag = true;
			StringBuilder stringBuilder = new StringBuilder();
			if (pModAppend.IncompatibleWith != null && pModAppend.IncompatibleWith.Length != 0)
			{
				bool flag2 = false;
				foreach (ModDependencyNode node in pGraph.nodes)
				{
					if (pModAppend.IncompatibleWith.Contains(node.mod_decl.UID))
					{
						if (!flag2)
						{
							stringBuilder.AppendLine("Mod " + pModAppend.UID + " is incompatible with mods:");
							flag2 = true;
							flag = false;
						}
						stringBuilder.AppendLine("    " + node.mod_decl.UID);
					}
				}
			}
			ModDependencyNode modDependencyNode = new ModDependencyNode(pModAppend);
			bool flag3 = false;
			string[] dependencies = pModAppend.Dependencies;
			foreach (string dependency in dependencies)
			{
				try
				{
					ModDependencyNode modDependencyNode2 = pGraph.nodes.First((ModDependencyNode n) => n.mod_decl.UID == dependency);
					if (!flag3 && flag)
					{
						modDependencyNode.necessary_depend_on.Add(modDependencyNode2);
						modDependencyNode2.depend_by.Add(modDependencyNode);
					}
				}
				catch (InvalidOperationException)
				{
					if (!flag3)
					{
						stringBuilder.AppendLine("Mod " + pModAppend.UID + " has missing dependencies:");
						flag3 = true;
						flag = false;
					}
					else
					{
						stringBuilder.AppendLine("    " + dependency);
					}
				}
			}
			if (!flag)
			{
				LogService.LogError(stringBuilder.ToString());
				pModAppend.FailReason.AppendLine(stringBuilder.ToString());
				return null;
			}
			string[] optionalDependencies = pModAppend.OptionalDependencies;
			foreach (string text in optionalDependencies)
			{
				foreach (ModDependencyNode node2 in pGraph.nodes)
				{
					if (node2.mod_decl.UID == text)
					{
						modDependencyNode.depend_on.Add(node2);
						node2.depend_by.Add(modDependencyNode);
					}
				}
			}
			pGraph.nodes.Add(modDependencyNode);
			return modDependencyNode;
		}

		public static void RemoveCircleDependencies(ModDependencyGraph pGraph)
		{
		}

		public static void RemoveIncompatibleMods(ModDependencyGraph pGraph)
		{
			Queue<ModDependencyNode> queue = new Queue<ModDependencyNode>();
			foreach (ModDependencyNode node in pGraph.nodes)
			{
				queue.Enqueue(node);
			}
			while (queue.Count > 0)
			{
				ModDependencyNode modDependencyNode = queue.Dequeue();
				if (!pGraph.nodes.Contains(modDependencyNode) || modDependencyNode.mod_decl.IncompatibleWith.Length == 0)
				{
					continue;
				}
				foreach (ModDependencyNode item2 in modDependencyNode.depend_by)
				{
					queue.Enqueue(item2);
				}
				pGraph.nodes.Remove(modDependencyNode);
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendLine("Mod " + modDependencyNode.mod_decl.UID + " is incompatible with mods:");
				string[] incompatibleWith = modDependencyNode.mod_decl.IncompatibleWith;
				foreach (string incompatible_with in incompatibleWith)
				{
					try
					{
						ModDependencyNode item = pGraph.nodes.First((ModDependencyNode node) => node.mod_decl.UID == incompatible_with);
						if (modDependencyNode.necessary_depend_on.Contains(item))
						{
							stringBuilder.AppendLine("    " + incompatible_with);
						}
					}
					catch (InvalidOperationException)
					{
						stringBuilder.AppendLine("    " + incompatible_with);
					}
				}
				modDependencyNode.mod_decl.FailReason.AppendLine(stringBuilder.ToString());
				LogService.LogWarning(stringBuilder.ToString());
			}
		}

		public static void RemoveModsWithoutRequiredDependencies(ModDependencyGraph pGraph)
		{
			Queue<ModDependencyNode> queue = new Queue<ModDependencyNode>();
			foreach (ModDependencyNode node in pGraph.nodes)
			{
				queue.Enqueue(node);
			}
			while (queue.Count > 0)
			{
				ModDependencyNode modDependencyNode = queue.Dequeue();
				if (!pGraph.nodes.Contains(modDependencyNode))
				{
					continue;
				}
				if (modDependencyNode.necessary_depend_on.Count < modDependencyNode.mod_decl.Dependencies.Length)
				{
					foreach (ModDependencyNode item3 in modDependencyNode.depend_by)
					{
						queue.Enqueue(item3);
					}
					foreach (ModDependencyNode item4 in modDependencyNode.depend_on)
					{
						item4.depend_by.Remove(modDependencyNode);
					}
					pGraph.nodes.Remove(modDependencyNode);
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.AppendLine("Mod " + modDependencyNode.mod_decl.UID + " has missing dependencies:");
					string[] dependencies = modDependencyNode.mod_decl.Dependencies;
					foreach (string dependency in dependencies)
					{
						try
						{
							ModDependencyNode item = pGraph.nodes.First((ModDependencyNode node) => node.mod_decl.UID == dependency);
							if (!modDependencyNode.necessary_depend_on.Contains(item))
							{
								stringBuilder.AppendLine("    " + dependency);
							}
						}
						catch (InvalidOperationException)
						{
							stringBuilder.AppendLine("    " + dependency);
						}
					}
					modDependencyNode.mod_decl.FailReason.AppendLine(stringBuilder.ToString());
					LogService.LogError(stringBuilder.ToString());
					continue;
				}
				string[] optionalDependencies = modDependencyNode.mod_decl.OptionalDependencies;
				foreach (string optional_dependency in optionalDependencies)
				{
					if (!pGraph.nodes.All((ModDependencyNode node) => node.mod_decl.UID != optional_dependency))
					{
						continue;
					}
					try
					{
						ModDependencyNode item2 = pGraph.nodes.First((ModDependencyNode node) => node.mod_decl.UID == optional_dependency);
						if (modDependencyNode.depend_on.Contains(item2))
						{
							modDependencyNode.depend_on.Remove(item2);
						}
					}
					catch (InvalidOperationException)
					{
					}
				}
			}
		}

		public static List<ModDependencyNode> SortModsCompileOrderFromDependencyTopology(ModDependencyGraph pGraph)
		{
			Dictionary<ModDependencyNode, int> dictionary = new Dictionary<ModDependencyNode, int>();
			Queue<ModDependencyNode> queue = new Queue<ModDependencyNode>();
			foreach (ModDependencyNode node in pGraph.nodes)
			{
				dictionary.Add(node, node.depend_on.Count);
				if (node.depend_on.Count == 0)
				{
					queue.Enqueue(node);
				}
			}
			List<ModDependencyNode> list = new List<ModDependencyNode>();
			while (queue.Count > 0)
			{
				ModDependencyNode modDependencyNode = queue.Dequeue();
				list.Add(modDependencyNode);
				foreach (ModDependencyNode item in modDependencyNode.depend_by)
				{
					try
					{
						dictionary[item]--;
						if (dictionary[item] == 0)
						{
							queue.Enqueue(item);
						}
					}
					catch (KeyNotFoundException)
					{
						LogService.LogError("Key " + item.mod_decl.UID + " not found in node_in_degree when checking " + modDependencyNode.mod_decl.UID);
					}
				}
			}
			return list;
		}
	}
	internal static class ModInfoUtils
	{
		private static Queue<ModDeclare> link_request_mods = new Queue<ModDeclare>();

		private static bool to_install_bepinex;

		private static Dictionary<string, ModCompilationCache> mod_compilation_caches;

		private static readonly Dictionary<string, long> mod_last_update_timestamps = new Dictionary<string, long>();

		public static void InitializeModCompileCache()
		{
			if (!File.Exists(Paths.ModCompileRecordPath))
			{
				File.WriteAllText(Paths.ModCompileRecordPath, "{}");
			}
			string value = File.ReadAllText(Paths.ModCompileRecordPath);
			JsonSerializerSettings settings = new JsonSerializerSettings
			{
				ContractResolver = new CamelCasePropertyNamesContractResolver(),
				Formatting = Formatting.Indented
			};
			try
			{
				mod_compilation_caches = JsonConvert.DeserializeObject<Dictionary<string, ModCompilationCache>>(value, settings) ?? new Dictionary<string, ModCompilationCache>();
			}
			catch (Exception)
			{
				mod_compilation_caches = new Dictionary<string, ModCompilationCache>();
			}
			finally
			{
				if (mod_compilation_caches == null)
				{
					mod_compilation_caches = new Dictionary<string, ModCompilationCache>();
				}
			}
			if (!File.Exists(Paths.ModsDisabledRecordPath))
			{
				return;
			}
			List<string> list = new List<string>(File.ReadAllLines(Paths.ModsDisabledRecordPath));
			foreach (string item in list)
			{
				if (!mod_compilation_caches.ContainsKey(item))
				{
					mod_compilation_caches[item] = new ModCompilationCache(item);
					mod_compilation_caches[item].disabled = true;
				}
				else
				{
					mod_compilation_caches[item].disabled = true;
				}
			}
			File.Delete(Paths.ModsDisabledRecordPath);
		}

		public static string TryToUnzipModZip(string pZipFile)
		{
			string text = Path.Combine(Application.temporaryCachePath, Path.GetFileNameWithoutExtension(pZipFile));
			if (Directory.Exists(text))
			{
				Directory.Delete(text, recursive: true);
			}
			try
			{
				ZipFile.ExtractToDirectory(pZipFile, text);
			}
			catch (Exception ex)
			{
				if (Directory.Exists(text))
				{
					Directory.Delete(text, recursive: true);
				}
				LogService.LogError("Error occurs when extracting " + pZipFile);
				LogService.LogError(ex.Message);
				LogService.LogError(ex.StackTrace);
				return "";
			}
			List<string> list = SystemUtils.SearchFileRecursive(text, (string filename) => filename == Paths.ModDeclarationFileName, (string dirname) => true);
			if (list.Count == 0)
			{
				Directory.Delete(text, recursive: true);
				return "";
			}
			if (list.Count > 1)
			{
				LogService.LogWarning("More than one mod.json file in " + pZipFile + ", only load the first one");
			}
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(pZipFile);
			try
			{
				ModDeclare modDeclare = new ModDeclare(list[0]);
				fileNameWithoutExtension = modDeclare.UID;
			}
			catch (Exception)
			{
				return "";
			}
			try
			{
				SystemUtils.CopyDirectory(Path.GetDirectoryName(list[0]), Path.Combine(Paths.ModsPath, fileNameWithoutExtension));
				return Path.Combine(Paths.ModsPath, fileNameWithoutExtension);
			}
			catch (UnauthorizedAccessException)
			{
				ZipFile.ExtractToDirectory(pZipFile, Path.Combine(Paths.ModsPath, Path.GetFileNameWithoutExtension(pZipFile)));
			}
			finally
			{
				try
				{
					File.Delete(pZipFile);
					if (Directory.Exists(text))
					{
						Directory.Delete(text, recursive: true);
					}
				}
				catch (Exception)
				{
				}
			}
			return "";
		}

		public static void CheckModsFolder(string pFolderPath, HashSet<string> pFindModsIDs, List<ModDeclare> pModsToFill, bool pLogModJsonNotFound = true)
		{
			if (!Directory.Exists(pFolderPath))
			{
				return;
			}
			IEnumerable<string> enumerable = new HashSet<string>(Directory.GetFiles(pFolderPath, "*.zip")).Union(Directory.GetFiles(pFolderPath, "*.7z")).Union(Directory.GetFiles(pFolderPath, "*.rar")).Union(Directory.GetFiles(pFolderPath, "*.tar"))
				.Union(Directory.GetFiles(pFolderPath, "*.tar.gz"))
				.Union(Directory.GetFiles(pFolderPath, "*.mod"));
			foreach (string item in enumerable)
			{
				TryToUnzipModZip(item);
			}
			string[] directories = Directory.GetDirectories(pFolderPath);
			string[] array = directories;
			foreach (string pModFolderPath in array)
			{
				ModDeclare modDeclare = recogMod(pModFolderPath, pLogModJsonNotFound);
				if (modDeclare != null)
				{
					if (pFindModsIDs.Contains(modDeclare.UID))
					{
						LogService.LogWarning("Repeat Mod with " + modDeclare.UID + ", Only load one of them");
						continue;
					}
					pModsToFill.Add(modDeclare);
					pFindModsIDs.Add(modDeclare.UID);
				}
			}
		}

		public static List<ModDeclare> findAndPrepareMods()
		{
			HashSet<string> hashSet = new HashSet<string>();
			List<ModDeclare> list = new List<ModDeclare>();
			if (!NCMSHere())
			{
				CheckModsFolder(Paths.ModsPath, hashSet, list);
			}
			CheckModsFolder(Paths.NativeModsPath, hashSet, list, pLogModJsonNotFound: false);
			if (!Others.is_editor)
			{
				string[] directories;
				try
				{
					RuntimePlatform platform = Application.platform;
					RuntimePlatform runtimePlatform = platform;
					if ((uint)(runtimePlatform - 1) <= 1u || runtimePlatform == RuntimePlatform.LinuxPlayer)
					{
						directories = Directory.GetDirectories(Paths.CommonModsWorkshopPath);
					}
					else
					{
						LogService.LogWarning("Your platform " + Application.platform.ToString() + " doesn't have defined behaviour, trying to handle it like Windows...");
						directories = Directory.GetDirectories(Paths.CommonModsWorkshopPath);
					}
				}
				catch (DirectoryNotFoundException)
				{
					LogService.LogWarning("Workshop folder not found, skip loading workshop mods");
					goto IL_0199;
				}
				string[] array = directories;
				foreach (string text in array)
				{
					ModDeclare modDeclare = recogMod(text, pLogModJsonNotFound: false);
					if (modDeclare == null)
					{
						continue;
					}
					if (modDeclare.ModType == ModTypeEnum.NEOMOD)
					{
						if (hashSet.Contains(modDeclare.UID))
						{
							LogService.LogWarning("Repeat Mod with " + modDeclare.UID + ", Only load one of them");
							continue;
						}
						if (string.IsNullOrEmpty(modDeclare.RepoUrl))
						{
							modDeclare.SetRepoUrlToWorkshopPage(Path.GetFileName(text));
						}
						list.Add(modDeclare);
						hashSet.Add(modDeclare.UID);
					}
					else if (modDeclare.ModType == ModTypeEnum.BEPINEX)
					{
						LinkBepInExModToLocalRequest(modDeclare);
					}
				}
			}
			goto IL_0199;
			IL_0199:
			foreach (ModDeclare item in list)
			{
				WorldBoxMod.AllRecognizedMods[item] = ModState.FAILED;
			}
			return removeDisabledMods(list);
			static bool NCMSHere()
			{
				return false;
			}
		}

		private static List<ModDeclare> removeDisabledMods(List<ModDeclare> mods_to_process)
		{
			List<ModDeclare> list = new List<ModDeclare>();
			foreach (ModDeclare item in mods_to_process)
			{
				if (isModDisabled(item.UID))
				{
					WorldBoxMod.AllRecognizedMods[item] = ModState.DISABLED;
				}
				else
				{
					list.Add(item);
				}
			}
			return list;
		}

		internal static void DealWithBepInExModLinkRequests()
		{
			if (link_request_mods.Count != 0)
			{
				InformationWindow.ShowWindow(LM.Get("ModLinkRequest"), InstallBepInExMod);
			}
		}

		private static void InstallBepInExMod()
		{
			if (to_install_bepinex)
			{
				try
				{
					InstallBepInEx();
				}
				catch (Exception ex)
				{
					LogService.LogError(ex.Message);
					LogService.LogError(ex.StackTrace);
					return;
				}
				to_install_bepinex = false;
			}
			if (!Directory.Exists(Paths.BepInExPluginsPath))
			{
				Directory.CreateDirectory(Paths.BepInExPluginsPath);
			}
			List<string> list = new List<string>();
			switch (Application.platform)
			{
			case RuntimePlatform.WindowsPlayer:
				list.Add("/c");
				while (link_request_mods.Count > 0)
				{
					ModDeclare modDeclare2 = link_request_mods.Dequeue();
					if (list.Count != 1)
					{
						list.Add("&&");
					}
					list.Add("mklink");
					list.Add("/D");
					list.Add("\"" + Path.Combine(Paths.BepInExPluginsPath, modDeclare2.Name) + "\"");
					list.Add("\"" + modDeclare2.FolderPath + "\"");
				}
				SystemUtils.CmdRunAs(list.ToArray());
				break;
			case RuntimePlatform.OSXPlayer:
			case RuntimePlatform.LinuxPlayer:
				list.Add("-c");
				while (link_request_mods.Count > 0)
				{
					ModDeclare modDeclare = link_request_mods.Dequeue();
					if (list.Count != 1)
					{
						list.Add("&&");
					}
					list.Add("ln");
					list.Add("-s");
					list.Add("\"" + modDeclare.FolderPath + "\"");
					list.Add("\"" + Path.Combine(Paths.BepInExPluginsPath, modDeclare.Name) + "\"");
				}
				SystemUtils.BashRun(list.ToArray());
				break;
			}
		}

		private static void InstallBepInEx()
		{
			WebClient webClient = new WebClient();
			string text = Path.Combine(Path.GetTempPath(), "bepinex.zip");
			RuntimePlatform platform = Application.platform;
			if (1 == 0)
			{
			}
			string text2 = platform switch
			{
				RuntimePlatform.WindowsPlayer => "https://github.com/BepInEx/BepInEx/releases/download/v5.4.22/BepInEx_x64_5.4.22.0.zip", 
				RuntimePlatform.LinuxPlayer => "https://github.com/BepInEx/BepInEx/releases/download/v5.4.22/BepInEx_unix_5.4.22.0.zip", 
				RuntimePlatform.OSXPlayer => "https://github.com/BepInEx/BepInEx/releases/download/v5.4.22/BepInEx_unix_5.4.22.0.zip", 
				_ => "https://github.com/BepInEx/BepInEx/releases/download/v5.4.22/BepInEx_x64_5.4.22.0.zip", 
			};
			if (1 == 0)
			{
			}
			string address = text2;
			webClient.DownloadFile(address, text);
			try
			{
				ZipFile.ExtractToDirectory(text, Paths.GamePath);
			}
			catch (Exception)
			{
			}
			File.Delete(text);
			RuntimePlatform platform2 = Application.platform;
			RuntimePlatform runtimePlatform = platform2;
			if (runtimePlatform == RuntimePlatform.OSXPlayer || runtimePlatform == RuntimePlatform.LinuxPlayer)
			{
				string text3 = Path.Combine(Paths.GamePath, "run_bepinex.sh");
				string text4 = "";
				string[] files = Directory.GetFiles(Paths.GamePath);
				foreach (string fileName in files)
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (fileInfo.Name.Contains("worldbox"))
					{
						text4 = fileInfo.Name;
						break;
					}
				}
				if (string.IsNullOrEmpty(text4))
				{
					LogService.LogErrorConcurrent("Failed to find WorldBox executable file!");
					LogService.LogWarningConcurrent("Set it as \"worldbox\" automatically");
					text4 = "worldbox";
				}
				string text5 = File.ReadAllText(text3);
				text5 = text5.Replace("executable_name=\"\"", "executable_name=\"" + text4 + "\"");
				File.WriteAllText(text3, text5);
				if (Application.platform == RuntimePlatform.LinuxPlayer)
				{
					string path = string.Format(Paths.LinuxSteamLocalConfigPath, SteamClient.SteamId.AccountId.ToString());
					VProperty vProperty = VdfConvert.Deserialize(File.ReadAllText(path));
					vProperty.Value["Software"]["Valve"]["Steam"]["apps"][1206560uL.ToString()]["LaunchOptions"] = new VValue(text3 + " %command%");
					File.WriteAllText(path, VdfConvert.Serialize(vProperty));
				}
				else
				{
					LogService.LogWarningConcurrent("You are using macOS, please add launch script manually");
				}
				SystemUtils.BashRun(new string[4] { "-c", "chmod", "u+x", text3 });
			}
			LogService.LogInfo("Install BepInEx to " + Paths.GamePath);
		}

		internal static void LinkBepInExModToLocalRequest(ModDeclare mod)
		{
			if (!Directory.Exists(Paths.BepInExPluginsPath))
			{
				LogService.LogInfo("Find a BepInEx mod " + mod.Name + " but BepInEx not found, Add Install BepInEx Task into queue");
				to_install_bepinex = true;
			}
			bool flag = false;
			foreach (IMod loadedMod in WorldBoxMod.LoadedMods)
			{
				if (loadedMod.GetDeclaration().UID == mod.UID)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				link_request_mods.Enqueue(mod);
			}
		}

		public static ModDeclare recogMod(string pModFolderPath, bool pLogModJsonNotFound = true)
		{
			string text = Path.Combine(pModFolderPath, Paths.ModDeclarationFileName);
			if (!File.Exists(text))
			{
				List<string> list = SystemUtils.SearchFileRecursive(pModFolderPath, (string file_name) => file_name == Paths.ModDeclarationFileName, (string _) => true);
				if (list.Count == 0)
				{
					if (pLogModJsonNotFound)
					{
						LogService.LogWarning("No mod.json file for folder " + pModFolderPath + " in Mods");
					}
					return null;
				}
				if (list.Count > 1)
				{
					LogService.LogWarning("More than one mod.json file in mod folder, only load the first one at '" + list[0] + "'");
				}
				text = list[0];
			}
			try
			{
				return new ModDeclare(text);
			}
			catch (Exception ex)
			{
				LogService.LogError("Error occurs when loading mod config file " + text);
				LogService.LogError(ex.Message);
				LogService.LogError(ex.StackTrace);
				return null;
			}
		}

		public static List<ModDeclare> recogBepInExMods()
		{
			List<ModDeclare> list = new List<ModDeclare>();
			if (!Directory.Exists(Paths.BepInExPluginsPath))
			{
				return list;
			}
			DirectoryInfo directoryInfo = new DirectoryInfo(Paths.BepInExPluginsPath);
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			HashSet<string> hashSet = new HashSet<string>();
			DirectoryInfo[] array = directories;
			foreach (DirectoryInfo directoryInfo2 in array)
			{
				FileInfo[] files;
				try
				{
					files = directoryInfo2.GetFiles("*.dll");
				}
				catch (DirectoryNotFoundException)
				{
					continue;
				}
				if (files.Length != 0)
				{
					hashSet.Add(files[0].FullName);
				}
			}
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			Assembly[] array2 = assemblies;
			foreach (Assembly assembly in array2)
			{
				string location;
				try
				{
					location = assembly.Location;
				}
				catch (NotSupportedException)
				{
					continue;
				}
				if (!hashSet.Contains(location))
				{
					continue;
				}
				string directoryName = Path.GetDirectoryName(location);
				ModDeclare modDeclare = recogBepInExMod(directoryName, assembly);
				if (modDeclare != null)
				{
					if (File.Exists(Path.Combine(directoryName, "icon.png")))
					{
						modDeclare.SetIconPath(Path.Combine(directoryName, "icon.png"));
					}
					list.Add(modDeclare);
				}
			}
			return list;
		}

		public static ModDeclare recogBepInExMod(string folder, Assembly pAssembly)
		{
			AssemblyName[] referencedAssemblies = pAssembly.GetReferencedAssemblies();
			bool flag = false;
			LogService.LogWarning("Checking " + pAssembly.FullName);
			AssemblyName[] array = referencedAssemblies;
			foreach (AssemblyName assemblyName in array)
			{
				if (!(assemblyName.FullName != "Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return null;
			}
			string pName = pAssembly.GetCustomAttribute<AssemblyTitleAttribute>()?.Title;
			string pAuthor = pAssembly.GetCustomAttribute<AssemblyCompanyAttribute>()?.Company;
			string text = pAssembly.GetCustomAttribute<AssemblyVersionAttribute>()?.Version;
			if (string.IsNullOrEmpty(text))
			{
				text = pAssembly.GetName().Version.ToString();
			}
			string pDescription = pAssembly.GetCustomAttribute<AssemblyDescriptionAttribute>()?.Description;
			ModDeclare modDeclare = new ModDeclare(pName, pAuthor, null, text, pDescription, folder, null, null, null);
			modDeclare.SetModType(ModTypeEnum.BEPINEX);
			return modDeclare;
		}

		public static bool isModDisabled(string pModUID)
		{
			ModCompilationCache value;
			return mod_compilation_caches.TryGetValue(pModUID, out value) && value.disabled;
		}

		public static bool toggleMod(string pModUID, bool pSave = true)
		{
			if (!mod_compilation_caches.TryGetValue(pModUID, out var value))
			{
				value = new ModCompilationCache(pModUID);
				value.disabled = true;
				mod_compilation_caches[pModUID] = value;
				return false;
			}
			bool disabled = value.disabled;
			value.disabled = !value.disabled;
			if (pSave)
			{
				SaveModRecords();
			}
			return disabled;
		}

		public static void SaveModRecords()
		{
			JsonSerializerSettings settings = new JsonSerializerSettings
			{
				ContractResolver = new DefaultContractResolver(),
				Formatting = Formatting.Indented
			};
			string contents = JsonConvert.SerializeObject(mod_compilation_caches, settings);
			File.WriteAllText(Paths.ModCompileRecordPath, contents);
		}

		public static void RecordMod(ModDeclare pModDeclare, List<string> pDependencies, List<string> pOptionalDependencies, bool pDisabled = false, bool pSave = true)
		{
			if (!mod_compilation_caches.TryGetValue(pModDeclare.UID, out var value))
			{
				value = new ModCompilationCache(pModDeclare, pDependencies, pOptionalDependencies);
			}
			else
			{
				value.dependencies = new List<string>(pDependencies);
				value.optional_dependencies = new List<string>(pOptionalDependencies);
			}
			value.disabled = pDisabled;
			value.timestamp = getModNewestUpdateTimestamp(pModDeclare.FolderPath);
			mod_compilation_caches[pModDeclare.UID] = value;
			if (pSave)
			{
				SaveModRecords();
			}
		}

		public static bool doesModNeedRecompile(ModDeclare pModDeclare, List<string> pDependencies, List<string> pOptionalDependencies)
		{
			if (!mod_compilation_caches.TryGetValue(pModDeclare.UID, out var value))
			{
				return true;
			}
			if (!File.Exists(Path.Combine(Paths.CompiledModsPath, pModDeclare.UID)))
			{
				return true;
			}
			HashSet<string> hashSet = new HashSet<string>(pDependencies);
			HashSet<string> hashSet2 = new HashSet<string>(value.dependencies);
			if (!hashSet.SetEquals(hashSet2))
			{
				return true;
			}
			hashSet = new HashSet<string>(pOptionalDependencies);
			hashSet2 = new HashSet<string>(value.optional_dependencies);
			if (!hashSet.SetEquals(hashSet2))
			{
				return true;
			}
			long timestamp = value.timestamp;
			bool flag = timestamp < 100000000 + getModNewestUpdateTimestamp(pModDeclare.FolderPath);
			if (flag)
			{
				return true;
			}
			foreach (string pDependency in pDependencies)
			{
				flag |= timestamp < 100000000 + getModLastCompileTimestamp(pDependency);
				if (flag)
				{
					return true;
				}
			}
			foreach (string pOptionalDependency in pOptionalDependencies)
			{
				flag |= timestamp < 100000000 + getModLastCompileTimestamp(pOptionalDependency);
				if (flag)
				{
					return true;
				}
			}
			return false;
		}

		public static void clearModCompileTimestamp(string pModUUID, bool pSave = true)
		{
			if (!mod_compilation_caches.TryGetValue(pModUUID, out var value))
			{
				value = new ModCompilationCache(pModUUID);
				value.disabled = false;
				value.timestamp = 0L;
				mod_compilation_caches[pModUUID] = value;
			}
			else
			{
				value.timestamp = 0L;
				if (pSave)
				{
					SaveModRecords();
				}
			}
		}

		private static long getModLastCompileTimestamp(string pModUID)
		{
			ModCompilationCache value;
			return mod_compilation_caches.TryGetValue(pModUID, out value) ? value.timestamp : 0;
		}

		private static long getModNewestUpdateTimestamp(string pModFolderPath)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(pModFolderPath);
			if (mod_last_update_timestamps.ContainsKey(directoryInfo.FullName))
			{
				return mod_last_update_timestamps[directoryInfo.FullName];
			}
			List<string> source = SystemUtils.SearchFileRecursive(directoryInfo.FullName, (string filename) => !filename.StartsWith("."), (string dirname) => !dirname.StartsWith(".") && !Paths.IgnoreSearchDirectories.Contains(dirname));
			long num = (from filepath in source
				select new FileInfo(filepath) into file_info
				select Math.Max(file_info.CreationTimeUtc.Ticks, file_info.LastWriteTimeUtc.Ticks)).Prepend(Math.Max(directoryInfo.CreationTimeUtc.Ticks, directoryInfo.LastWriteTimeUtc.Ticks)).Prepend(InternalResourcesGetter.GetLastWriteTime()).Max();
			mod_last_update_timestamps[directoryInfo.FullName] = num;
			return num;
		}
	}
	internal static class ModReloadUtils
	{
		private static IReloadable _mod;

		private static ModDeclare _mod_declare;

		private static string _new_compiled_dll_path;

		private static string _new_compiled_pdb_path;

		private static AssemblyDefinition _old_assembly_definition;

		private static Dictionary<string, MethodDefinition> _old_method_definitions = new Dictionary<string, MethodDefinition>();

		private static Dictionary<Mono.Cecil.Cil.OpCode, System.Reflection.Emit.OpCode> _op_code_map = new Dictionary<Mono.Cecil.Cil.OpCode, System.Reflection.Emit.OpCode>();

		private static Dictionary<MethodDefinition, MethodInfo> _regenerated_brand_new_methods = new Dictionary<MethodDefinition, MethodInfo>();

		private static Dictionary<Type, MethodInfo> _emit_method_cache = new Dictionary<Type, MethodInfo>();

		private static readonly Dictionary<MethodInfo, ILHook> _create_hooks = new Dictionary<MethodInfo, ILHook>();

		public static bool Prepare(IReloadable pMod, ModDeclare pModDeclare)
		{
			_mod = pMod;
			_mod_declare = pModDeclare;
			_new_compiled_dll_path = Path.Combine(Paths.CompiledModsPath, _mod_declare.UID + ".dll");
			_new_compiled_pdb_path = Path.Combine(Paths.CompiledModsPath, _mod_declare.UID + ".pdb");
			try
			{
				_old_assembly_definition.Dispose();
				_old_assembly_definition = null;
				_old_method_definitions.Clear();
			}
			catch (Exception)
			{
			}
			if (!File.Exists(_new_compiled_dll_path))
			{
				LogService.LogError("No compiled dll found for mod " + _mod_declare.UID);
				return false;
			}
			if (File.Exists(_new_compiled_pdb_path + ".bak"))
			{
				File.Delete(_new_compiled_pdb_path + ".bak");
			}
			File.Copy(_new_compiled_dll_path, _new_compiled_dll_path + ".bak", overwrite: true);
			_old_assembly_definition = AssemblyDefinition.ReadAssembly(_new_compiled_dll_path + ".bak");
			return true;
		}

		public static bool CompileNew()
		{
			if (!ModCompileLoadService.TryCompileModAtRuntime(_mod_declare, pForce: true))
			{
				return false;
			}
			foreach (TypeDefinition type in _old_assembly_definition.MainModule.Types)
			{
				foreach (MethodDefinition method in type.Methods)
				{
					_old_method_definitions[method.FullName] = method;
				}
				foreach (MethodDefinition item in type.NestedTypes.SelectMany((TypeDefinition nested_type) => nested_type.Methods))
				{
					_old_method_definitions[item.FullName] = item;
				}
			}
			return true;
		}

		public static bool PatchHotfixMethods()
		{
			HarmonyFileLog.Enabled = true;
			AssemblyDefinition assemblyDefinition = AssemblyDefinition.ReadAssembly(_new_compiled_dll_path);
			List<MethodDefinition> list = new List<MethodDefinition>();
			list.AddRange(assemblyDefinition.MainModule.Types.SelectMany((TypeDefinition type) => type.Methods));
			foreach (TypeDefinition item in assemblyDefinition.MainModule.Types.SelectMany((TypeDefinition type) => type.NestedTypes))
			{
				list.AddRange(item.Methods);
			}
			Assembly assembly = _mod.GetType().Assembly;
			Harmony pHarmony = new Harmony(_mod_declare.UID);
			if (_op_code_map.Count == 0)
			{
				InitializeOpcodeMap();
			}
			HashSet<MethodDefinition> hashSet = new HashSet<MethodDefinition>();
			foreach (MethodDefinition item2 in list)
			{
				if (!item2.HasBody)
				{
					continue;
				}
				bool flag = false;
				foreach (CustomAttribute customAttribute in item2.CustomAttributes)
				{
					if (customAttribute.AttributeType.FullName == typeof(HotfixableAttribute).FullName)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					MethodInfo method = assembly.GetType(item2.DeclaringType.FullName).GetMethod(item2.Name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, item2.Parameters.Select((ParameterDefinition x) => x.ParameterType.ResolveReflection()).ToArray(), null);
					if (!(method != null))
					{
						LogService.LogWarning("No found method " + item2.DeclaringType.FullName + "::" + item2.Name + " in old assembly");
						hashSet.Add(item2);
					}
				}
			}
			if (hashSet.Count > 0)
			{
				CreateBrandNewMethods(hashSet);
			}
			foreach (MethodDefinition item3 in list)
			{
				if (!item3.HasBody)
				{
					continue;
				}
				bool flag2 = false;
				foreach (CustomAttribute customAttribute2 in item3.CustomAttributes)
				{
					if (customAttribute2.AttributeType.FullName == typeof(HotfixableAttribute).FullName)
					{
						flag2 = true;
						break;
					}
				}
				if (!flag2 || hashSet.Contains(item3))
				{
					continue;
				}
				try
				{
					MethodInfo method2 = assembly.GetType(item3.DeclaringType.FullName).GetMethod(item3.Name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, item3.Parameters.Select((ParameterDefinition x) => x.ParameterType.ResolveReflection()).ToArray(), null);
					if (!(method2 == null))
					{
						if (!NeedHotfix(method2, item3))
						{
							LogService.LogInfo("Method " + item3.Name + " does not need hotfix");
							continue;
						}
						LogService.LogInfo($"Hotfixing method {item3.Name} with following instructions(total {item3.Body.Instructions.Count}):");
						HotfixMethod(pHarmony, item3, method2);
					}
				}
				catch (Exception ex)
				{
					LogService.LogError("Failed to hotfix method " + item3.Name + ", Most likely because NeoModLoader does not support such method hotfix now.");
					LogService.LogError(ex.Message);
					LogService.LogError(ex.StackTrace);
				}
			}
			assemblyDefinition.Dispose();
			return true;
		}

		private static void CreateBrandNewMethods(HashSet<MethodDefinition> pBrandNewMethods)
		{
			LogService.LogWarning($"Find {pBrandNewMethods.Count} brand new methods, creating...");
			int count = pBrandNewMethods.Count;
			HashSet<MethodDefinition> hashSet = new HashSet<MethodDefinition>(pBrandNewMethods);
			while (count-- > 0)
			{
				foreach (MethodDefinition item in hashSet)
				{
					try
					{
						DynamicMethodDefinition dynamicMethodDefinition = regenerate(item);
						MethodInfo value = dynamicMethodDefinition.Generate();
						_regenerated_brand_new_methods[item] = value;
					}
					catch (Exception ex)
					{
						LogService.LogError("Failed to create brand new method " + item.FullName);
						LogService.LogError(ex.Message);
						LogService.LogError(ex.StackTrace);
						continue;
					}
					pBrandNewMethods.Remove(item);
				}
			}
		}

		private static bool NeedHotfix(MethodInfo pOldMethod, MethodDefinition pNewMethod)
		{
			if (!_old_method_definitions.TryGetValue(pNewMethod.FullName, out var value))
			{
				LogService.LogWarning("No found method " + pNewMethod.FullName + " in old assembly");
				return true;
			}
			Collection<Instruction> instructions = value.Body.Instructions;
			Collection<Instruction> instructions2 = pNewMethod.Body.Instructions;
			if (instructions.Count != instructions2.Count)
			{
				return true;
			}
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = new StringBuilder();
			foreach (Instruction item in instructions)
			{
				if (item.Operand is Instruction instruction)
				{
					stringBuilder.AppendLine($"{item.OpCode} {instruction.Offset - item.Offset}");
				}
				else
				{
					stringBuilder.AppendLine(item.ToString().Substring("IL_0000: ".Length));
				}
			}
			foreach (Instruction item2 in instructions2)
			{
				if (item2.Operand is Instruction instruction2)
				{
					stringBuilder2.AppendLine($"{item2.OpCode} {instruction2.Offset - item2.Offset}");
				}
				else
				{
					stringBuilder2.AppendLine(item2.ToString().Substring("IL_0000: ".Length));
				}
			}
			return stringBuilder.ToString().GetHashCode() != stringBuilder2.ToString().GetHashCode();
		}

		private static void InitializeOpcodeMap()
		{
			FieldInfo[] fields = typeof(System.Reflection.Emit.OpCodes).GetFields();
			foreach (FieldInfo fieldInfo in fields)
			{
				if (!(fieldInfo.FieldType != typeof(System.Reflection.Emit.OpCode)))
				{
					System.Reflection.Emit.OpCode value = (System.Reflection.Emit.OpCode)fieldInfo.GetValue(null);
					try
					{
						_op_code_map.Add((Mono.Cecil.Cil.OpCode)typeof(Mono.Cecil.Cil.OpCodes).GetField(fieldInfo.Name).GetValue(null), value);
					}
					catch (Exception)
					{
					}
				}
			}
			_op_code_map.Add(Mono.Cecil.Cil.OpCodes.Stelem_Any, System.Reflection.Emit.OpCodes.Stelem);
			_op_code_map.Add(Mono.Cecil.Cil.OpCodes.Ldelem_Any, System.Reflection.Emit.OpCodes.Ldelem);
			_op_code_map.Add(Mono.Cecil.Cil.OpCodes.Tail, System.Reflection.Emit.OpCodes.Tailcall);
		}

		private static void HotfixMethod(Harmony pHarmony, MethodDefinition pNewMethod, MethodInfo pOldMethod)
		{
			ReplaceMethod(pOldMethod, regenerate(pNewMethod));
		}

		public static bool PatchHotfixMethodsNT()
		{
			byte[] buffer = File.ReadAllBytes(_new_compiled_dll_path);
			byte[] buffer2 = File.ReadAllBytes(_new_compiled_pdb_path);
			using MemoryStream stream = new MemoryStream(buffer);
			using MemoryStream symbolStream = new MemoryStream(buffer2);
			AssemblyDefinition assemblyDefinition = AssemblyDefinition.ReadAssembly(stream, new ReaderParameters
			{
				ReadSymbols = true,
				SymbolStream = symbolStream,
				SymbolReaderProvider = new PdbReaderProvider()
			});
			List<MethodDefinition> list = new List<MethodDefinition>();
			list.AddRange(assemblyDefinition.MainModule.Types.SelectMany((TypeDefinition typeDefinition) => typeDefinition.Methods));
			foreach (TypeDefinition item in assemblyDefinition.MainModule.Types.SelectMany((TypeDefinition typeDefinition) => typeDefinition.NestedTypes))
			{
				list.AddRange(item.Methods);
			}
			HashSet<MethodDefinition> hashSet = new HashSet<MethodDefinition>();
			List<(MethodInfo, MethodDefinition)> list2 = new List<(MethodInfo, MethodDefinition)>();
			foreach (MethodDefinition item2 in list)
			{
				if (!item2.HasBody)
				{
					continue;
				}
				bool flag = false;
				foreach (CustomAttribute customAttribute in item2.CustomAttributes)
				{
					if (customAttribute.AttributeType.FullName == typeof(HotfixableAttribute).FullName)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					continue;
				}
				Type type = AccessTools.TypeByName(item2.DeclaringType.FullName);
				if (!(type == null))
				{
					MethodInfo method = type.GetMethod(item2.Name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, item2.Parameters.Select((ParameterDefinition x) => x.ParameterType.ResolveReflection()).ToArray(), null);
					if (!(method == null))
					{
						list2.Add((method, item2));
					}
				}
			}
			while (hashSet.Count > 0)
			{
				HashSet<MethodDefinition> hashSet2 = new HashSet<MethodDefinition>();
				foreach (MethodDefinition item3 in hashSet)
				{
					try
					{
						_regenerated_brand_new_methods[item3] = CreateMethod(item3);
					}
					catch (Exception ex)
					{
						LogService.LogError("Failed to create brand new method " + item3.FullName);
						LogService.LogError(ex.Message);
						LogService.LogError(ex.StackTrace);
						continue;
					}
					hashSet2.Add(item3);
				}
				if (hashSet2.Count == 0)
				{
					break;
				}
				hashSet.ExceptWith(hashSet2);
			}
			foreach (var (oldMethod, methodDefinition) in list2)
			{
				try
				{
					Replace(oldMethod, methodDefinition);
				}
				catch (Exception ex2)
				{
					LogService.LogError("Failed to hotfix method " + methodDefinition.FullName);
					LogService.LogError(ex2.Message);
					LogService.LogError(ex2.StackTrace);
				}
			}
			return true;
		}

		private static MethodInfo CreateMethod(MethodDefinition newMethod)
		{
			DynamicMethodDefinition dynamicMethodDefinition = new DynamicMethodDefinition(newMethod.Name, newMethod.ReturnType.ResolveReflection(), newMethod.Parameters.Select((ParameterDefinition x) => x.ParameterType.ResolveReflection()).ToArray());
			if (!newMethod.IsStatic)
			{
				dynamicMethodDefinition.Definition.Parameters.Insert(0, new ParameterDefinition(newMethod.DeclaringType));
			}
			Mono.Cecil.Cil.MethodBody body = dynamicMethodDefinition.Definition.Body;
			Mono.Cecil.Cil.MethodBody body2 = newMethod.Body;
			body.Variables.Clear();
			body.Instructions.Clear();
			body.ExceptionHandlers.Clear();
			body.Variables.AddRange(body2.Variables);
			body.Instructions.AddRange(body2.Instructions);
			body.ExceptionHandlers.AddRange(body2.ExceptionHandlers);
			return dynamicMethodDefinition.Generate();
		}

		private static void Replace(MethodInfo oldMethod, MethodDefinition newMethod)
		{
			if (_create_hooks.ContainsKey(oldMethod))
			{
				_create_hooks[oldMethod].Dispose();
			}
			ILHook iLHook = new ILHook(oldMethod, delegate(ILContext il)
			{
				il.Body.Variables.Clear();
				il.Body.Instructions.Clear();
				il.Body.ExceptionHandlers.Clear();
				il.Body.Variables.AddRange(newMethod.Body.Variables);
				il.Body.Instructions.AddRange(newMethod.Body.Instructions);
				il.Body.ExceptionHandlers.AddRange(newMethod.Body.ExceptionHandlers);
			});
			iLHook.Apply();
			_create_hooks[oldMethod] = iLHook;
		}

		private unsafe static void ReplaceMethod(MethodInfo pOldMethod, DynamicMethodDefinition pNewMethod)
		{
			MethodInfo methodInfo = pNewMethod.Generate();
			RuntimeHelpers.PrepareMethod(pOldMethod.MethodHandle);
			IntPtr functionPointer = pOldMethod.MethodHandle.GetFunctionPointer();
			RuntimeHelpers.PrepareMethod(methodInfo.MethodHandle);
			IntPtr functionPointer2 = methodInfo.MethodHandle.GetFunctionPointer();
			LogService.LogInfo($"Is 64bit: {Environment.Is64BitProcess}");
			byte* ptr = (byte*)functionPointer.ToPointer();
			byte* ptr2 = (byte*)functionPointer2.ToPointer();
			long num = ptr2 - ptr - 5;
			if (num < uint.MaxValue && num > -4294967295L)
			{
				LogService.LogInfo($"diff is {num} doing relative jmp");
				LogService.LogInfo($"patching on {(ulong)ptr:X}, target: {(ulong)ptr2:X}");
				*ptr = 233;
				*(int*)(ptr + 1) = (int)num;
			}
			else
			{
				LogService.LogInfo($"diff is {num} doing push+ret trampoline");
				LogService.LogInfo($"patching on {(ulong)ptr:X}, target: {(ulong)ptr2:X}");
				if (Environment.Is64BitProcess)
				{
					byte* ptr3 = ptr;
					*(ptr3++) = 104;
					*(int*)ptr3 = (int)ptr2;
					ptr3 += 4;
					*(ptr3++) = 199;
					*(ptr3++) = 68;
					*(ptr3++) = 36;
					*(ptr3++) = 4;
					*(int*)ptr3 = (int)((ulong)ptr2 >> 32);
					ptr3 += 4;
					*(ptr3++) = 195;
				}
				else
				{
					*ptr = 104;
					*(int*)(ptr + 1) = (int)ptr2;
					ptr[5] = 195;
				}
			}
			LogService.LogInfo($"Patched 0x{(ulong)ptr:X} to 0x{(ulong)ptr2:X}.");
		}

		private static DynamicMethodDefinition regenerate(MethodDefinition pMethodDefinition)
		{
			DynamicMethodDefinition dynamicMethodDefinition = new DynamicMethodDefinition(pMethodDefinition.Name, pMethodDefinition.ReturnType.ResolveReflection(), pMethodDefinition.Parameters.Select((ParameterDefinition x) => x.ParameterType.ResolveReflection()).ToArray());
			if (!pMethodDefinition.IsStatic)
			{
				dynamicMethodDefinition.Definition.Parameters.Insert(0, new ParameterDefinition(pMethodDefinition.DeclaringType));
			}
			foreach (ParameterDefinition parameter in pMethodDefinition.Parameters)
			{
				LogService.LogInfo("\tDeclare parameter " + parameter.ToString() + "(" + parameter.ParameterType.FullName + ")");
			}
			ILGenerator iLGenerator = dynamicMethodDefinition.GetILGenerator();
			if (pMethodDefinition.Body.InitLocals)
			{
				dynamicMethodDefinition.Definition.Body.InitLocals = true;
			}
			foreach (VariableDefinition variable in pMethodDefinition.Body.Variables)
			{
				LogService.LogInfo("\tDeclare local variable " + variable.ToString() + "(" + variable.VariableType.FullName + ")");
				iLGenerator.DeclareLocal(variable.VariableType.ResolveReflection());
			}
			Dictionary<Instruction, Label> dictionary = new Dictionary<Instruction, Label>();
			foreach (Instruction instruction2 in pMethodDefinition.Body.Instructions)
			{
				if (instruction2.Operand is Instruction instruction)
				{
					LogService.LogInfo("\tDeclare label for " + instruction.ToString());
					dictionary[instruction] = iLGenerator.DefineLabel();
				}
				else if (instruction2.Operand is Instruction[] array)
				{
					Instruction[] array2 = array;
					foreach (Instruction key in array2)
					{
						dictionary[key] = iLGenerator.DefineLabel();
					}
				}
			}
			Dictionary<Instruction, Mono.Cecil.Cil.ExceptionHandler> dictionary2 = new Dictionary<Instruction, Mono.Cecil.Cil.ExceptionHandler>();
			foreach (Mono.Cecil.Cil.ExceptionHandler exceptionHandler in pMethodDefinition.Body.ExceptionHandlers)
			{
				LogService.LogInfo("\tDeclare exception handler for " + exceptionHandler.ToString());
				dictionary2[exceptionHandler.TryStart] = exceptionHandler;
				dictionary2[exceptionHandler.TryEnd] = exceptionHandler;
				dictionary2[exceptionHandler.HandlerStart] = exceptionHandler;
				dictionary2[exceptionHandler.HandlerEnd] = exceptionHandler;
				if (exceptionHandler.TryStart == null)
				{
				}
			}
			try
			{
				foreach (Instruction instruction3 in pMethodDefinition.Body.Instructions)
				{
					if (dictionary.TryGetValue(instruction3, out var value))
					{
						iLGenerator.MarkLabel(value);
					}
					if (dictionary2.TryGetValue(instruction3, out var value2))
					{
						if (instruction3 == value2.TryEnd)
						{
							LogService.LogWarning("TryEnd");
						}
						else if (instruction3 == value2.HandlerStart)
						{
							LogService.LogWarning("HandlerStart");
						}
						else if (instruction3 == value2.HandlerEnd)
						{
							LogService.LogWarning("HandlerEnd");
						}
						else
						{
							LogService.LogWarning("TryStart");
						}
					}
					System.Reflection.Emit.OpCode opCode = _op_code_map[instruction3.OpCode];
					if (opCode == System.Reflection.Emit.OpCodes.Endfinally)
					{
						continue;
					}
					LogService.LogInfo($"\t{opCode}\t\t {instruction3.Operand}({instruction3.Operand?.GetType().FullName})");
					if (instruction3.Operand == null)
					{
						iLGenerator.Emit(opCode);
						continue;
					}
					if (instruction3.Operand is Instruction)
					{
						iLGenerator.Emit(opCode, dictionary[(Instruction)instruction3.Operand]);
						continue;
					}
					Type type = instruction3.Operand.GetType();
					if (instruction3.Operand is MemberReference memberReference)
					{
						MemberInfo memberInfo = null;
						try
						{
							memberInfo = memberReference.ResolveReflection();
							if (memberInfo == null)
							{
								throw new Exception("Failed to resolve member reference " + memberReference.FullName);
							}
						}
						catch (Exception ex)
						{
							try
							{
								if (memberReference is MethodReference methodReference)
								{
									memberInfo = _regenerated_brand_new_methods[methodReference.Resolve()];
								}
							}
							catch (Exception)
							{
								LogService.LogError("Failed to resolve member reference " + memberReference.FullName);
								LogService.LogError(ex.Message);
								LogService.LogError(ex.StackTrace);
							}
						}
						type = memberInfo.GetType();
						if (!_emit_method_cache.TryGetValue(type, out var value3))
						{
							value3 = AccessTools.Method(typeof(ILGenerator), "Emit", new Type[2]
							{
								typeof(System.Reflection.Emit.OpCode),
								type
							});
							_emit_method_cache[type] = value3;
						}
						if (value3 == null)
						{
							throw new Exception("Failed to get emit method for " + type.FullName);
						}
						value3.Invoke(iLGenerator, new object[2] { opCode, memberInfo });
						continue;
					}
					if (instruction3.Operand is VariableReference variableReference)
					{
						iLGenerator.Emit(opCode, variableReference.Index);
						continue;
					}
					if (instruction3.Operand is Instruction[] array3)
					{
						Label[] array4 = new Label[array3.Length];
						for (int num2 = 0; num2 < array3.Length; num2++)
						{
							array4[num2] = dictionary[array3[num2]];
						}
						iLGenerator.Emit(System.Reflection.Emit.OpCodes.Switch, array4);
						continue;
					}
					if (instruction3.Operand is ParameterDefinition parameterDefinition)
					{
						iLGenerator.Emit(opCode, parameterDefinition.Sequence);
						continue;
					}
					if (!_emit_method_cache.TryGetValue(type, out var value4))
					{
						value4 = AccessTools.Method(typeof(ILGenerator), "Emit", new Type[2]
						{
							typeof(System.Reflection.Emit.OpCode),
							type
						});
						_emit_method_cache[type] = value4;
					}
					if (value4 == null)
					{
						throw new Exception("Failed to get emit method for " + type.FullName);
					}
					try
					{
						value4.Invoke(iLGenerator, new object[2] { opCode, instruction3.Operand });
					}
					catch (Exception ex3)
					{
						if (instruction3.Operand is sbyte arg)
						{
							iLGenerator.Emit(opCode, (int)arg);
							continue;
						}
						LogService.LogError($"Failed to emit {opCode} {instruction3.Operand}({instruction3.Operand?.GetType().FullName})");
						LogService.LogError(ex3.Message);
						LogService.LogError(ex3.StackTrace);
					}
				}
			}
			catch (Exception ex4)
			{
				LogService.LogError(ex4.Message);
				LogService.LogError(ex4.StackTrace);
			}
			finally
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendLine("Current instructions:");
				foreach (Instruction instruction4 in dynamicMethodDefinition.GetILProcessor().Body.Instructions)
				{
					stringBuilder.AppendLine($"\t{instruction4.OpCode}\t\t {instruction4.Operand}({instruction4.Operand?.GetType().FullName})");
				}
				LogService.LogWarning(stringBuilder.ToString());
			}
			return dynamicMethodDefinition;
		}

		public static bool Reload()
		{
			try
			{
				_mod.Reload();
			}
			catch (Exception ex)
			{
				LogService.LogError(ex.Message);
				LogService.LogError(ex.StackTrace);
				return false;
			}
			return true;
		}
	}
	public static class OtherUtils
	{
		public static string GetStackTrace(int skip_frames = 0, string indent = "")
		{
			string stackTrace = Environment.StackTrace;
			StringBuilder stringBuilder = new StringBuilder();
			string[] array = stackTrace.Split(new char[1] { '\n' });
			if (!string.IsNullOrEmpty(indent))
			{
				for (int i = skip_frames; i < array.Length; i++)
				{
					stringBuilder.AppendLine(array[i]);
				}
			}
			else
			{
				for (int j = skip_frames; j < array.Length; j++)
				{
					for (int k = 0; k < j - skip_frames; k++)
					{
						stringBuilder.Append(indent);
					}
					stringBuilder.AppendLine(array[j]);
				}
			}
			return stringBuilder.ToString();
		}

		public static bool CalledBy(string pMethodName, Type pTypeConstraint, bool pSearchAll = false)
		{
			StackTrace stackTrace = new StackTrace();
			StackFrame[] frames = stackTrace.GetFrames();
			if (frames == null)
			{
				return false;
			}
			if (frames.Length < 3)
			{
				return false;
			}
			if (!pSearchAll)
			{
				return frames[2].GetMethod().Name == pMethodName && (frames[2].GetType() == pTypeConstraint || frames[2].GetType().IsSubclassOf(pTypeConstraint));
			}
			for (int i = 2; i < frames.Length; i++)
			{
				if (frames[i].GetMethod().Name == pMethodName && (frames[i].GetType() == pTypeConstraint || frames[i].GetType().IsSubclassOf(pTypeConstraint)))
				{
					return true;
				}
			}
			return false;
		}
	}
	public class PriorityQueue<T> : IEnumerable<T>, IEnumerable
	{
		private readonly IComparer<T> comparer;

		private T[] heap;

		public int Count { get; private set; }

		public T this[int index]
		{
			get
			{
				if (index > Count || index < 0)
				{
					throw new IndexOutOfRangeException($"{index} / {Count}");
				}
				return heap[index];
			}
		}

		public PriorityQueue(int capacity, IComparer<T> comparer)
		{
			this.comparer = comparer;
			heap = new T[(capacity > 0) ? capacity : 8];
		}

		public IEnumerator<T> GetEnumerator()
		{
			IEnumerator enumerator = heap.GetEnumerator() as IEnumerator<T>;
			return (IEnumerator<T>)(enumerator ?? Array.Empty<T>().GetEnumerator());
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		private static int Parent(int i)
		{
			return i - 1 >> 1;
		}

		private static int Left(int i)
		{
			return (i << 1) + 1;
		}

		public T Peek()
		{
			if (Count == 0)
			{
				throw new InvalidOperationException("PriorityQueue is empty");
			}
			return heap[0];
		}

		public int Enqueue(T x)
		{
			if (Count == heap.Length)
			{
				Array.Resize(ref heap, Count << 1);
			}
			Count++;
			heap[Count - 1] = x;
			return SiftUp(Count - 1);
		}

		private int SiftUp(int i)
		{
			T val = heap[i];
			while (i > 0)
			{
				int num = Parent(i);
				if (comparer.Compare(val, heap[num]) >= 0)
				{
					break;
				}
				heap[i] = heap[num];
				i = num;
			}
			heap[i] = val;
			return i;
		}

		public T Dequeue()
		{
			if (Count == 0)
			{
				throw new InvalidOperationException("PriorityQueue is empty");
			}
			T result = heap[0];
			T x = heap[Count - 1];
			Count--;
			if (Count != 0)
			{
				SiftDown(0, x);
			}
			return result;
		}

		private void SiftDown(int i, T x)
		{
			while (true)
			{
				int num = Left(i);
				if (num > Count - 1)
				{
					break;
				}
				int num2 = num + 1;
				int num3 = ((num2 > Count - 1 || comparer.Compare(heap[num], heap[num2]) <= 0) ? num : num2);
				if (comparer.Compare(x, heap[num3]) <= 0)
				{
					break;
				}
				heap[i] = heap[num3];
				i = num3;
			}
			heap[i] = x;
		}
	}
	internal static class ReflectionHelper
	{
		internal static bool IsAssemblyLoaded(string assembly_name)
		{
			return AppDomain.CurrentDomain.GetAssemblies().Any((Assembly a) => a.GetName().Name.Equals(assembly_name));
		}

		internal static Delegate GetMethod<T>(string method_name, bool is_static = false)
		{
			return createMethodDelegate(is_static ? typeof(T).GetMethod(method_name, BindingFlags.Static | BindingFlags.NonPublic) : AccessTools.Method(typeof(T), method_name));
		}

		internal static Delegate GetMethod(Type type, string method_name, bool is_static = false)
		{
			return createMethodDelegate(is_static ? type.GetMethod(method_name, BindingFlags.Static | BindingFlags.NonPublic) : AccessTools.Method(type, method_name));
		}

		internal static Delegate CreateFieldGetter(string field_name, Type instance_type, Type output_type)
		{
			FieldInfo fieldInfo = instance_type.GetField(field_name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic) ?? AccessTools.Field(instance_type, field_name);
			if (fieldInfo == null)
			{
				MonoBehaviour.print("Cannot find '" + field_name + "' in type " + instance_type.FullName);
			}
			try
			{
				ParameterExpression parameterExpression = Expression.Parameter(instance_type, "instance");
				UnaryExpression expression = ((!fieldInfo.DeclaringType.IsValueType) ? Expression.TypeAs(parameterExpression, fieldInfo.DeclaringType) : Expression.Convert(parameterExpression, fieldInfo.DeclaringType));
				return (!output_type.IsPrimitive) ? Expression.Lambda<Delegate>(Expression.TypeAs(Expression.Field(expression, fieldInfo), output_type), new ParameterExpression[1] { parameterExpression }).Compile() : Expression.Lambda<Delegate>(Expression.Field(expression, fieldInfo), new ParameterExpression[1] { parameterExpression }).Compile();
			}
			catch (Exception)
			{
				UnityEngine.Debug.LogError("Expression Tree-Getter:" + fieldInfo.DeclaringType?.ToString() + "::" + field_name);
				return null;
			}
		}

		internal static Delegate CreateFieldGetter<OutType>(string field_name, Type instance_type)
		{
			return CreateFieldGetter(field_name, instance_type, typeof(OutType));
		}

		internal static Func<InstanceType, OutType> CreateFieldGetter<InstanceType, OutType>(string field_name)
		{
			FieldInfo fieldInfo = typeof(InstanceType).GetField(field_name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic) ?? AccessTools.Field(typeof(InstanceType), field_name);
			if (fieldInfo == null)
			{
				MonoBehaviour.print("Cannot find '" + field_name + "' in type " + typeof(InstanceType).FullName);
			}
			try
			{
				ParameterExpression parameterExpression = Expression.Parameter(typeof(InstanceType), "instance");
				UnaryExpression expression = ((!fieldInfo.DeclaringType.IsValueType) ? Expression.TypeAs(parameterExpression, fieldInfo.DeclaringType) : Expression.Convert(parameterExpression, fieldInfo.DeclaringType));
				return (!typeof(OutType).IsPrimitive) ? Expression.Lambda<Func<InstanceType, OutType>>(Expression.TypeAs(Expression.Field(expression, fieldInfo), typeof(OutType)), new ParameterExpression[1] { parameterExpression }).Compile() : Expression.Lambda<Func<InstanceType, OutType>>(Expression.Field(expression, fieldInfo), new ParameterExpression[1] { parameterExpression }).Compile();
			}
			catch (Exception)
			{
				UnityEngine.Debug.LogError("Expression Tree-Getter:" + fieldInfo.DeclaringType?.ToString() + "::" + field_name);
				return null;
			}
		}

		internal static Action<TI, TF> CreateFieldSetter<TI, TF>(string field_name)
		{
			FieldInfo field = typeof(TI).GetField(field_name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			ParameterExpression parameterExpression = Expression.Parameter(typeof(TI), "instance");
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(TF), field_name);
			if (field.FieldType == typeof(TF))
			{
				return Expression.Lambda<Action<TI, TF>>(Expression.Assign(Expression.Field(parameterExpression, field), parameterExpression2), new ParameterExpression[2] { parameterExpression, parameterExpression2 }).Compile();
			}
			return Expression.Lambda<Action<TI, TF>>(Expression.Assign(Expression.Field(parameterExpression, field), field.FieldType.IsValueType ? Expression.Convert(parameterExpression2, field.FieldType) : Expression.TypeAs(parameterExpression2, field.FieldType)), new ParameterExpression[2] { parameterExpression, parameterExpression2 }).Compile();
		}

		private static Delegate createMethodDelegate(MethodInfo method_info)
		{
			List<ParameterExpression> list = method_info.GetParameters().Select((ParameterInfo p, int i) => Expression.Parameter(p.ParameterType, p.Name)).ToList();
			MethodCallExpression body;
			if (method_info.IsStatic)
			{
				body = Expression.Call(method_info, list);
			}
			else
			{
				ParameterExpression parameterExpression = Expression.Parameter(method_info.ReflectedType, "instance");
				body = Expression.Call(parameterExpression, method_info, list);
				list.Insert(0, parameterExpression);
			}
			LambdaExpression lambdaExpression = Expression.Lambda(body, list);
			return lambdaExpression.Compile();
		}
	}
	public static class ResourcesPatch
	{
		private class ResourceTree
		{
			internal Dictionary<string, UnityEngine.Object> direct_objects = new Dictionary<string, UnityEngine.Object>();

			private ResourceTreeNode root = new ResourceTreeNode(null);

			public ResourceTree()
			{
				root.parent = root;
			}

			public ResourceTreeNode Find(string path, bool createNodeAlong = false, bool visitLast = true)
			{
				path = path.ToLower();
				string[] array = ((!path.EndsWith("/")) ? path.Split(new char[1] { '/' }) : path.Substring(0, path.Length - 1).Split(new char[1] { '/' }));
				ResourceTreeNode resourceTreeNode = root;
				for (int i = 0; i < array.Length - ((!visitLast) ? 1 : 0); i++)
				{
					string text = array[i];
					if (text == "..")
					{
						resourceTreeNode = resourceTreeNode.parent;
					}
					else
					{
						if (text == ".")
						{
							continue;
						}
						if (!resourceTreeNode.children.ContainsKey(text))
						{
							if (!createNodeAlong)
							{
								return null;
							}
							resourceTreeNode.children[text] = new ResourceTreeNode(resourceTreeNode);
						}
						resourceTreeNode = resourceTreeNode.children[text];
					}
				}
				return resourceTreeNode;
			}

			public UnityEngine.Object Get(string path)
			{
				if (direct_objects.TryGetValue(path.ToLower(), out var value))
				{
					return value;
				}
				ResourceTreeNode resourceTreeNode = Find(path, createNodeAlong: true, visitLast: false);
				if (resourceTreeNode == null)
				{
					return null;
				}
				if (resourceTreeNode.objects.TryGetValue(Path.GetFileNameWithoutExtension(path.ToLower()), out value))
				{
					direct_objects[path] = value;
					return value;
				}
				return null;
			}

			public void Add(string path, UnityEngine.Object obj)
			{
				string text = path.ToLower();
				direct_objects[text] = obj;
				ResourceTreeNode resourceTreeNode = Find(path, createNodeAlong: true, visitLast: false);
				resourceTreeNode.objects[Path.GetFileNameWithoutExtension(text)] = obj;
			}

			public void AddFromFile(string path, string absPath, out Builder Builder)
			{
				Builder = null;
				string text = path.ToLower();
				if (text.EndsWith(".meta") || text.EndsWith("sprites.json"))
				{
					return;
				}
				if (text.EndsWith(".wav"))
				{
					LoadWavFile(absPath);
					return;
				}
				if (text.EndsWith("asset"))
				{
					Builder = LoadAsset(absPath, Path.GetExtension(text));
					return;
				}
				string directoryName = Path.GetDirectoryName(text);
				UnityEngine.Object[] array;
				try
				{
					string pLowerPath = absPath.ToLower();
					array = LoadResourceFile(ref absPath, ref pLowerPath);
					UnityEngine.Object[] array2 = array;
					foreach (UnityEngine.Object obj in array2)
					{
						if (directoryName == null)
						{
							direct_objects[obj.name] = obj;
						}
						else
						{
							direct_objects[Path.Combine(directoryName, obj.name).Replace('\\', '/').ToLower()] = obj;
						}
					}
				}
				catch (UnrecognizableResourceFileException)
				{
					LogService.LogWarning("Cannot recognize resource file " + path);
					return;
				}
				if (array.Length != 0)
				{
					ResourceTreeNode resourceTreeNode = Find(path, createNodeAlong: true, visitLast: false);
					UnityEngine.Object[] array3 = array;
					foreach (UnityEngine.Object obj2 in array3)
					{
						resourceTreeNode.objects[obj2.name.ToLower()] = obj2;
					}
				}
			}
		}

		private class ResourceTreeNode
		{
			public readonly Dictionary<string, ResourceTreeNode> children = new Dictionary<string, ResourceTreeNode>();

			public readonly Dictionary<string, UnityEngine.Object> objects = new Dictionary<string, UnityEngine.Object>();

			public ResourceTreeNode parent { get; internal set; }

			public ResourceTreeNode(ResourceTreeNode parent)
			{
				this.parent = parent;
			}

			public List<UnityEngine.Object> GetAllObjects(Type systemTypeInstance)
			{
				List<UnityEngine.Object> list = new List<UnityEngine.Object>(objects.Count);
				Queue<ResourceTreeNode> queue = new Queue<ResourceTreeNode>(children.Count);
				queue.Enqueue(this);
				while (queue.Count > 0)
				{
					ResourceTreeNode resourceTreeNode = queue.Dequeue();
					foreach (UnityEngine.Object value in resourceTreeNode.objects.Values)
					{
						if (systemTypeInstance.IsInstanceOfType(value))
						{
							list.Add(value);
						}
					}
					foreach (ResourceTreeNode value2 in resourceTreeNode.children.Values)
					{
						queue.Enqueue(value2);
					}
				}
				return list;
			}
		}

		private static ResourceTree tree;

		public static Dictionary<string, UnityEngine.Object> GetAllPatchedResources()
		{
			return tree.direct_objects;
		}

		public static void PatchResource(string pPath, UnityEngine.Object pObject)
		{
			tree.Add(pPath, pObject);
		}

		internal static void Initialize()
		{
			CustomAudioManager.Initialize();
			tree = new ResourceTree();
			SpriteAtlas spriteAtlas = Resources.FindObjectsOfTypeAll<SpriteAtlas>().FirstOrDefault((SpriteAtlas x) => x.name == "SpriteAtlasUI");
			Sprite[] array = new Sprite[spriteAtlas.spriteCount];
			spriteAtlas.GetSprites(array);
			Sprite[] array2 = array;
			foreach (Sprite sprite in array2)
			{
				sprite.name = sprite.name.Replace("(Clone)", "");
				tree.Add("ui/special/" + sprite.name, sprite);
			}
			MethodInfo[] methods = typeof(InternalResourcesGetter).GetMethods();
			foreach (MethodInfo methodInfo in methods)
			{
				if (!(methodInfo.ReturnType != typeof(Sprite)) && methodInfo.GetParameters().Length == 0)
				{
					methodInfo.Invoke(null, null);
				}
			}
		}

		public static UnityEngine.Object[] LoadResourceFile(ref string path, ref string pLowerPath)
		{
			if (pLowerPath.EndsWith(".png") || pLowerPath.EndsWith(".jpg") || pLowerPath.EndsWith(".jpeg"))
			{
				return SpriteLoadUtils.LoadSprites(path);
			}
			return new UnityEngine.Object[1] { LoadTextAsset(path) };
		}

		private static Builder LoadAsset(string Path, string Extention)
		{
			if (1 == 0)
			{
			}
			Builder result = Extention switch
			{
				".actortraitasset" => new ActorTraitBuilder(Path, LoadImmediately: false), 
				".subspeciestraitasset" => new SubspeciesTraitBuilder(Path, LoadImmediately: false), 
				".clantraitasset" => new ClanTraitBuilder(Path, LoadImmediately: false), 
				".culturetraitasset" => new CultureTraitBuilder(Path, LoadImmediately: false), 
				".actortraitgroupasset" => new GroupAssetBuilder<ActorTraitGroupAsset>(Path, LoadImmediately: false), 
				".achievementgroupasset" => new GroupAssetBuilder<AchievementGroupAsset>(Path, LoadImmediately: false), 
				".clantraitgroupasset" => new GroupAssetBuilder<ClanTraitGroupAsset>(Path, LoadImmediately: false), 
				".culturetraitgroupasset" => new GroupAssetBuilder<CultureTraitGroupAsset>(Path, LoadImmediately: false), 
				".itemgroupasset" => new GroupAssetBuilder<ItemGroupAsset>(Path, LoadImmediately: false), 
				".kingdomtraitgroupasset" => new GroupAssetBuilder<KingdomTraitGroupAsset>(Path, LoadImmediately: false), 
				".languagetraitgroupasset" => new GroupAssetBuilder<LanguageTraitGroupAsset>(Path, LoadImmediately: false), 
				".plotcategoryasset" => new GroupAssetBuilder<PlotCategoryAsset>(Path, LoadImmediately: false), 
				".religiontraitgroupasset" => new GroupAssetBuilder<ReligionTraitGroupAsset>(Path, LoadImmediately: false), 
				".subspeciestraitgroupasset" => new GroupAssetBuilder<SubspeciesTraitGroupAsset>(Path, LoadImmediately: false), 
				".worldlawgroupasset" => new GroupAssetBuilder<WorldLawGroupAsset>(Path, LoadImmediately: false), 
				_ => throw new NotSupportedException("the asset " + Extention + " has not been supported yet!"), 
			};
			if (1 == 0)
			{
			}
			return result;
		}

		private static void LoadWavFile(string path)
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path);
			if (CustomAudioManager.AudioWavLibrary.ContainsKey(fileNameWithoutExtension))
			{
				LogService.LogError("The Sound file " + fileNameWithoutExtension + " has already been loaded!");
				return;
			}
			WavContainer value;
			try
			{
				value = JsonConvert.DeserializeObject<WavContainer>(File.ReadAllText(Path.GetDirectoryName(path) + "/" + fileNameWithoutExtension + ".json"));
				value.Path = path;
			}
			catch (Exception)
			{
				value = new WavContainer(path, SoundMode.Stereo3D, 50f);
			}
			CustomAudioManager.AudioWavLibrary.Add(fileNameWithoutExtension, value);
		}

		private static TextAsset LoadTextAsset(string path)
		{
			TextAsset textAsset = new TextAsset(File.ReadAllText(path));
			textAsset.name = Path.GetFileNameWithoutExtension(path);
			return textAsset;
		}

		internal static void LoadResourceFromFolder(string pFolder, out List<Builder> Builders)
		{
			Builders = null;
			if (!Directory.Exists(pFolder))
			{
				return;
			}
			List<string> list = SystemUtils.SearchFileRecursive(pFolder, (string filename) => !filename.StartsWith("."), (string dirname) => !dirname.StartsWith("."));
			foreach (string item in list)
			{
				tree.AddFromFile(item.Replace(pFolder, "").Replace('\\', '/').Substring(1), item, out var Builder);
				if (Builder != null)
				{
					if (Builders == null)
					{
						Builders = new List<Builder>();
					}
					Builders.Add(Builder);
				}
			}
		}

		internal static void LoadAssetBundlesFromFolder(string pFolder)
		{
			if (Directory.Exists(pFolder))
			{
				RuntimePlatform platform = Application.platform;
				if (1 == 0)
				{
				}
				string text = platform switch
				{
					RuntimePlatform.WindowsPlayer => "win", 
					RuntimePlatform.WindowsEditor => "win", 
					RuntimePlatform.OSXPlayer => "osx", 
					RuntimePlatform.OSXEditor => "osx", 
					RuntimePlatform.LinuxPlayer => "linux", 
					RuntimePlatform.LinuxEditor => "linux", 
					_ => "win", 
				};
				if (1 == 0)
				{
				}
				string path = text;
				string text2 = Path.Combine(pFolder, path);
				if (Directory.Exists(text2))
				{
					AssetBundleUtils.LoadFromFolder(text2);
				}
			}
		}

		[HarmonyPrefix]
		[HarmonyPatch(typeof(Resources), "LoadAll", new Type[]
		{
			typeof(string),
			typeof(Type)
		})]
		private static void LoadAll_Prefix(ref string path)
		{
			if (!path.Contains(".."))
			{
				return;
			}
			string[] array = path.Split(new char[1] { '/' });
			List<string> list = new List<string>(array.Length);
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == ".." && list.Count > 0)
				{
					list.RemoveAt(list.Count - 1);
				}
				else
				{
					list.Add(array[i]);
				}
			}
			path = string.Join("/", list);
		}

		[HarmonyPostfix]
		[HarmonyPatch(typeof(Resources), "LoadAll", new Type[]
		{
			typeof(string),
			typeof(Type)
		})]
		private static UnityEngine.Object[] LoadAll_Postfix(UnityEngine.Object[] __result, string path, Type systemTypeInstance)
		{
			if (tree == null)
			{
				return __result;
			}
			ResourceTreeNode resourceTreeNode = tree.Find(path);
			if (resourceTreeNode == null)
			{
				return __result;
			}
			List<UnityEngine.Object> allObjects = resourceTreeNode.GetAllObjects(systemTypeInstance);
			if (allObjects.Count == 0)
			{
				return __result;
			}
			List<UnityEngine.Object> list = new List<UnityEngine.Object>(__result);
			HashSet<string> names = new HashSet<string>(allObjects.Select((UnityEngine.Object x) => x.name));
			list.RemoveAll((UnityEngine.Object x) => names.Contains(x.name));
			list.AddRange(allObjects);
			return list.ToArray();
		}

		[HarmonyPrefix]
		[HarmonyPatch(typeof(Resources), "Load", new Type[]
		{
			typeof(string),
			typeof(Type)
		})]
		private static void Load_Prefix(ref string path)
		{
			if (!path.Contains(".."))
			{
				return;
			}
			string[] array = path.Split(new char[1] { '/' });
			List<string> list = new List<string>(array.Length);
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == ".." && list.Count > 0)
				{
					list.RemoveAt(list.Count - 1);
				}
				else
				{
					list.Add(array[i]);
				}
			}
			path = string.Join("/", list);
		}

		[HarmonyPostfix]
		[HarmonyPatch(typeof(Resources), "Load", new Type[]
		{
			typeof(string),
			typeof(Type)
		})]
		private static UnityEngine.Object Load_Postfix(UnityEngine.Object __result, string path, Type systemTypeInstance)
		{
			if (tree == null)
			{
				return __result;
			}
			UnityEngine.Object obj = tree.Get(path);
			if (obj != null && systemTypeInstance.IsInstanceOfType(obj))
			{
				return obj;
			}
			return __result;
		}
	}
	public enum SoundType
	{
		Music,
		Sound,
		UI
	}
	public enum SoundMode
	{
		Basic,
		Stereo3D,
		Mono3D
	}
	internal struct WavContainer
	{
		[JsonIgnore]
		public string Path;

		public SoundMode Mode;

		public float Volume;

		public SoundType Type;

		public int LoopCount;

		public bool Ramp;

		public WavContainer(string Path, SoundMode Mode, float Volume, int LoopCount = 0, bool Ramp = false, SoundType Type = SoundType.Sound)
		{
			this.Ramp = Ramp;
			this.Path = Path;
			this.Mode = Mode;
			this.Volume = Volume;
			this.Type = Type;
			this.LoopCount = LoopCount;
		}
	}
	public struct ChannelContainer
	{
		public Vector3 PosAndVolume;

		public Transform AttachedTo;

		public Channel Channel { get; internal set; }

		public readonly bool Finushed
		{
			get
			{
				bool isplaying;
				return Channel.isPlaying(out isplaying) != RESULT.OK || !isplaying;
			}
		}

		internal ChannelContainer(Channel channel, Transform attachedTo = null, Vector3 PosAndVolume = default(Vector3))
		{
			this.PosAndVolume = default(Vector3);
			Channel = channel;
			this.PosAndVolume = PosAndVolume;
			AttachedTo = attachedTo;
		}
	}
	public class CustomAudioManager
	{
		private static FMOD.System fmodSystem;

		private static ChannelGroup SFXGroup;

		private static ChannelGroup MusicGroup;

		private static ChannelGroup UIGroup;

		internal static readonly Dictionary<string, WavContainer> AudioWavLibrary = new Dictionary<string, WavContainer>();

		private static readonly List<ChannelContainer> Channels = new List<ChannelContainer>();

		private static readonly Dictionary<string, ChannelContainer> DrawingSounds = new Dictionary<string, ChannelContainer>();

		[HarmonyPostfix]
		[HarmonyPatch(typeof(RuntimeManager), "Update")]
		private static void Update()
		{
			SFXGroup.setVolume(GetVolume(SoundType.Sound));
			MusicGroup.setVolume(GetVolume(SoundType.Music));
			UIGroup.setVolume(GetVolume(SoundType.UI));
			for (int i = 0; i < Channels.Count; i++)
			{
				ChannelContainer channelContainer = Channels[i];
				if (!UpdateChannel(channelContainer))
				{
					Channels.Remove(channelContainer);
					i--;
				}
			}
		}

		[HarmonyPrefix]
		[HarmonyPatch(typeof(MusicBox), "playSound", new Type[]
		{
			typeof(string),
			typeof(float),
			typeof(float),
			typeof(bool),
			typeof(bool)
		})]
		[HarmonyPriority(0)]
		private static bool PlaySoundPatch(string pSoundPath, float pX, float pY, bool pGameViewOnly)
		{
			if (!MusicBox.sounds_on)
			{
				return true;
			}
			if (pGameViewOnly && World.world.quality_changer.isLowRes())
			{
				return true;
			}
			if (!AudioWavLibrary.ContainsKey(pSoundPath))
			{
				return true;
			}
			LoadCustomSound(pSoundPath, pX, pY);
			return false;
		}

		[HarmonyPrefix]
		[HarmonyPatch(typeof(MusicBox), "playDrawingSound")]
		[HarmonyPriority(0)]
		private static bool PlayDrawingSoundPatch(string pSoundPath, float pX, float pY)
		{
			if (!MusicBox.sounds_on)
			{
				return true;
			}
			if (!AudioWavLibrary.ContainsKey(pSoundPath))
			{
				return true;
			}
			LoadDrawingSound(pSoundPath, pX, pY);
			return false;
		}

		public static ChannelContainer LoadDrawingSound(string pSoundPath, float pX, float pY)
		{
			if (DrawingSounds.TryGetValue(pSoundPath, out var value) && !value.Finushed)
			{
				SetChannelPosition(value, pX, pY);
			}
			else
			{
				DrawingSounds.Remove(pSoundPath);
				value = LoadCustomSound(pSoundPath, pX, pY);
				DrawingSounds.Add(pSoundPath, value);
			}
			return value;
		}

		public static ChannelContainer LoadCustomSound(string WAVName, float pX, float pY, Transform AttachedTo = null)
		{
			WavContainer wavContainer = AudioWavLibrary[WAVName];
			if (wavContainer.Mode == SoundMode.Basic)
			{
				AttachedTo = null;
			}
			if (fmodSystem.createSound(wavContainer.Path, (wavContainer.Mode == SoundMode.Stereo3D) ? (MODE.LOOP_NORMAL | MODE._3D) : MODE.LOOP_NORMAL, out var sound) != RESULT.OK)
			{
				LogService.LogError("Unable to play sound " + WAVName + "!");
				return default(ChannelContainer);
			}
			sound.setLoopCount(wavContainer.LoopCount);
			Channel channel = default(Channel);
			switch (wavContainer.Type)
			{
			case SoundType.Music:
				fmodSystem.playSound(sound, MusicGroup, paused: false, out channel);
				break;
			case SoundType.Sound:
				fmodSystem.playSound(sound, SFXGroup, paused: false, out channel);
				break;
			case SoundType.UI:
				fmodSystem.playSound(sound, UIGroup, paused: false, out channel);
				break;
			}
			channel.setVolumeRamp(wavContainer.Ramp);
			channel.setVolume(wavContainer.Volume / 100f);
			AddChannel(channel, AttachedTo, (wavContainer.Mode == SoundMode.Mono3D) ? new Vector3(pX, pY, wavContainer.Volume) : default(Vector3));
			if (wavContainer.Mode == SoundMode.Stereo3D)
			{
				SetChannelPosition(channel, pX, pY);
			}
			return Channels[Channels.Count - 1];
		}

		internal static void Initialize()
		{
			if (RuntimeManager.StudioSystem.getCoreSystem(out fmodSystem) != RESULT.OK)
			{
				LogService.LogError("Failed to initialize FMOD Core System!");
				return;
			}
			if (fmodSystem.createChannelGroup("SFXGroup", out SFXGroup) != RESULT.OK)
			{
				LogService.LogError("Failed to create SFXGroup!");
			}
			if (fmodSystem.createChannelGroup("MusicGroup", out MusicGroup) != RESULT.OK)
			{
				LogService.LogError("Failed to create MusicGroup!");
			}
			if (fmodSystem.createChannelGroup("UIGroup", out UIGroup) != RESULT.OK)
			{
				LogService.LogError("Failed to create UIGroup!");
			}
		}

		internal static void AddChannel(Channel channel, Transform AttachedTo = null, Vector3 PosAndVolume = default(Vector3))
		{
			Channels.Add(new ChannelContainer(channel, AttachedTo, PosAndVolume));
		}

		public static void ModifyWavData(string ID, float Volume, SoundMode Mode, int LoopCount = 0, bool Ramp = false, SoundType Type = SoundType.Sound)
		{
			if (AudioWavLibrary.ContainsKey(ID))
			{
				AudioWavLibrary[ID] = new WavContainer(AudioWavLibrary[ID].Path, Mode, Volume, LoopCount, Ramp, Type);
			}
		}

		private static bool UpdateChannel(ChannelContainer channel)
		{
			if (channel.Finushed)
			{
				return false;
			}
			if (channel.AttachedTo != null)
			{
				SetChannelPosition(channel, channel.AttachedTo.position.x, channel.AttachedTo.position.y);
			}
			if (channel.PosAndVolume != default(Vector3))
			{
				UpdateMonoVolume(channel);
			}
			return true;
		}

		private static void UpdateMonoVolume(ChannelContainer Channel)
		{
			Vector3 position = Camera.main.transform.position;
			float num = Vector3.Distance(new Vector3(position.x, position.y, Camera.main.orthographicSize), new Vector2(Channel.PosAndVolume.x, Channel.PosAndVolume.y));
			Channel.Channel.setVolume(Mathf.Clamp01(Channel.PosAndVolume.z / num));
		}

		[HarmonyPrefix]
		[HarmonyPatch(typeof(MapBox), "clearWorld")]
		public static void ClearAllCustomSounds()
		{
			foreach (ChannelContainer channel in Channels)
			{
				channel.Channel.stop();
			}
			Channels.Clear();
		}

		public static void SetChannelPosition(ChannelContainer channel, float pX, float pY)
		{
			if (channel.PosAndVolume == default(Vector3))
			{
				SetChannelPosition(channel.Channel, pX, pY);
				return;
			}
			channel.PosAndVolume.x = pX;
			channel.PosAndVolume.y = pY;
		}

		public static void SetChannelPosition(Channel channel, float pX, float pY)
		{
			channel.get3DAttributes(out var pos, out var vel);
			if (pos.x != pX || pos.y != pY)
			{
				VECTOR pos2 = new VECTOR
				{
					x = pX,
					y = pY,
					z = 0f
				};
				channel.set3DAttributes(ref pos2, ref vel);
			}
		}

		private static float GetVolume(SoundType soundType)
		{
			float num = 1f;
			return soundType switch
			{
				SoundType.Music => num * ((float)PlayerConfig.getIntValue("volume_music") / 100f), 
				SoundType.Sound => num * ((float)PlayerConfig.getIntValue("volume_sound_effects") / 100f), 
				_ => num * ((float)PlayerConfig.getIntValue("volume_ui") / 100f), 
			} * ((float)PlayerConfig.getIntValue("volume_master_sound") / 100f);
		}
	}
	[Serializable]
	internal class TextureImporter
	{
		public SpriteSheet spriteSheet;
	}
	[Serializable]
	internal class SpriteSheet
	{
		public List<SingleSpriteMetaData> sprites;
	}
	[Serializable]
	internal class SingleSpriteMetaData
	{
		public string name;

		public Rect rect;

		public SpriteAlignment alignment;

		public Vector2 pivot;

		public Vector4 border;
	}
	public static class SpriteLoadUtils
	{
		private class MetaFile
		{
			public TextureImporter TextureImporter;
		}

		private class NCMSSpritesSettings
		{
			public class SpecificSetting
			{
				public string Alias = "";

				public float BorderB = 0f;

				public float BorderL = 0f;

				public float BorderR = 0f;

				public float BorderT = 0f;

				public string Path = "\\";

				public float PivotX = 0.5f;

				public float PivotY = 0f;

				public float PixelsPerUnit = 1f;

				public float RectH = -1f;

				public float RectW = -1f;

				public float RectX = 0f;

				public float RectY = 0f;

				public Sprite loadFromPath(string path)
				{
					Texture2D texture2D = new Texture2D(0, 0);
					texture2D.filterMode = FilterMode.Point;
					texture2D.LoadImage(File.ReadAllBytes(path));
					Sprite sprite = Sprite.Create(texture2D, new Rect(RectX, RectY, (RectW < 0f) ? ((float)texture2D.width) : RectW, (RectH < 0f) ? ((float)texture2D.height) : RectH), new Vector2(PivotX, PivotY), PixelsPerUnit, 1u, SpriteMeshType.Tight, new Vector4(BorderL, BorderB, BorderR, BorderT));
					sprite.name = (string.IsNullOrEmpty(Alias) ? System.IO.Path.GetFileNameWithoutExtension(path) : Alias);
					return sprite;
				}
			}

			public SpecificSetting Default;

			public List<SpecificSetting> Specific;

			public override string ToString()
			{
				return JsonConvert.SerializeObject(this);
			}
		}

		private static Dictionary<string, Sprite> singleSpriteCache = new Dictionary<string, Sprite>();

		private static Dictionary<string, NCMSSpritesSettings> dirNCMSSettings = new Dictionary<string, NCMSSpritesSettings>();

		private static HashSet<string> ignoreNCMSSettingsSearchPath = new HashSet<string>();

		private static NCMSSpritesSettings.SpecificSetting defaultNCMSSetting = new NCMSSpritesSettings.SpecificSetting();

		private static IDeserializer deserializer = new DeserializerBuilder().IgnoreUnmatchedProperties().Build();

		public static Sprite LoadSingleSprite(string path)
		{
			if (singleSpriteCache.TryGetValue(path, out var value))
			{
				return value;
			}
			Sprite sprite = loadSpriteSimply(path);
			singleSpriteCache[path] = sprite;
			return sprite;
		}

		public static Sprite[] LoadSprites(string path)
		{
			TextureImporter textureImporter = loadMeta(path + ".meta");
			if (textureImporter == null)
			{
				NCMSSpritesSettings.SpecificSetting specificSetting = searchUpNCMSSetting(path);
				if (specificSetting == null)
				{
					Sprite sprite = loadSpriteSimply(path);
					if (sprite == null)
					{
						return Array.Empty<Sprite>();
					}
					sprite.name = Path.GetFileNameWithoutExtension(path);
					return new Sprite[1] { sprite };
				}
				try
				{
					Sprite sprite2 = specificSetting.loadFromPath(path);
					if (sprite2 != null)
					{
						return new Sprite[1] { sprite2 };
					}
				}
				catch (Exception ex)
				{
					LogService.LogError("Failed to load sprite from " + path + " with NCMSSetting " + specificSetting.GetType().FullName);
					LogService.LogError(ex.ToString());
					return Array.Empty<Sprite>();
				}
			}
			return loadSpriteWithMeta(path, textureImporter);
		}

		private static NCMSSpritesSettings.SpecificSetting searchUpNCMSSetting(string path)
		{
			string directoryName = Path.GetDirectoryName(path);
			do
			{
				if (!ignoreNCMSSettingsSearchPath.Contains(directoryName))
				{
					if (dirNCMSSettings.ContainsKey(directoryName))
					{
						return getInternalSetting(path, dirNCMSSettings[directoryName]);
					}
					string text = Path.Combine(directoryName, "sprites.json");
					if (File.Exists(text))
					{
						NCMSSpritesSettings nCMSSpritesSettings = JsonConvert.DeserializeObject<NCMSSpritesSettings>(File.ReadAllText(text));
						if (nCMSSpritesSettings != null)
						{
							NCMSSpritesSettings nCMSSpritesSettings2 = nCMSSpritesSettings;
							if (nCMSSpritesSettings2.Default == null)
							{
								nCMSSpritesSettings2.Default = defaultNCMSSetting;
							}
							dirNCMSSettings.Add(directoryName, nCMSSpritesSettings);
							List<NCMSSpritesSettings.SpecificSetting> specific = nCMSSpritesSettings.Specific;
							if (specific != null && specific.Contains(null))
							{
								LogService.LogWarning("Here is something wrong at " + text);
							}
							return getInternalSetting(path, nCMSSpritesSettings);
						}
						LogService.LogWarning("Wrong sprite settings file at " + text);
					}
					ignoreNCMSSettingsSearchPath.Add(directoryName);
				}
				if (directoryName == Paths.ModsPath)
				{
					return defaultNCMSSetting;
				}
				directoryName = Path.GetDirectoryName(directoryName);
			}
			while (!string.IsNullOrEmpty(directoryName));
			return defaultNCMSSetting;
			static NCMSSpritesSettings.SpecificSetting getInternalSetting(string i_path, NCMSSpritesSettings settings)
			{
				if (settings.Specific == null)
				{
					return settings.Default;
				}
				foreach (NCMSSpritesSettings.SpecificSetting item in settings.Specific)
				{
					if (item != null && item.Path == Path.GetFileName(i_path))
					{
						return item;
					}
				}
				return settings.Default;
			}
		}

		private static Sprite loadSpriteSimply(string path)
		{
			byte[] data = File.ReadAllBytes(path);
			Texture2D texture2D = new Texture2D(0, 0);
			texture2D.filterMode = FilterMode.Point;
			texture2D.LoadImage(data);
			return Sprite.Create(texture2D, new Rect(0f, 0f, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f), 1f);
		}

		private static Sprite[] loadSpriteWithMeta(string path, TextureImporter textureImporter)
		{
			Texture2D texture2D = new Texture2D(0, 0);
			texture2D.filterMode = FilterMode.Point;
			texture2D.LoadImage(File.ReadAllBytes(path));
			Sprite[] array = new Sprite[textureImporter.spriteSheet.sprites.Count];
			for (int i = 0; i < array.Length; i++)
			{
				SingleSpriteMetaData singleSpriteMetaData = textureImporter.spriteSheet.sprites[i];
				array[i] = Sprite.Create(texture2D, singleSpriteMetaData.rect, singleSpriteMetaData.pivot, 1f, 0u, SpriteMeshType.FullRect, singleSpriteMetaData.border);
				array[i].name = singleSpriteMetaData.name;
			}
			return array;
		}

		private static TextureImporter loadMeta(string path)
		{
			if (!File.Exists(path))
			{
				return null;
			}
			return deserializer.Deserialize<MetaFile>(File.ReadAllText(path))?.TextureImporter;
		}
	}
	public static class SystemUtils
	{
		public static void CmdRunAs(string[] parameters)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "cmd.exe";
			processStartInfo.Arguments = string.Join(" ", parameters);
			Console.WriteLine(processStartInfo.Arguments);
			processStartInfo.Verb = "runas";
			Process.Start(processStartInfo);
		}

		public static void BashRun(string[] parameters)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "bash";
			processStartInfo.Arguments = string.Join(" ", parameters);
			Console.WriteLine(processStartInfo.Arguments);
			Process.Start(processStartInfo);
		}

		public static List<string> SearchFileRecursive(string path, Func<string, bool> fileNameJudge, Func<string, bool> dirNameJudge)
		{
			List<string> list = new List<string>();
			Queue<DirectoryInfo> queue = new Queue<DirectoryInfo>();
			queue.Enqueue(new DirectoryInfo(path));
			while (queue.Count > 0)
			{
				DirectoryInfo directoryInfo = queue.Dequeue();
				FileInfo[] files = directoryInfo.GetFiles();
				foreach (FileInfo fileInfo in files)
				{
					if (fileNameJudge(fileInfo.Name))
					{
						list.Add(fileInfo.FullName);
					}
				}
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				foreach (DirectoryInfo directoryInfo2 in directories)
				{
					if (dirNameJudge(directoryInfo2.Name))
					{
						queue.Enqueue(directoryInfo2);
					}
				}
			}
			return list;
		}

		public static void CopyDirectory(string pSource, string pTarget)
		{
			if (string.IsNullOrEmpty(pSource) || string.IsNullOrEmpty(pTarget))
			{
				LogService.LogWarning("Source or target is null or empty");
				LogService.LogStackTraceAsWarning();
				return;
			}
			if (!Directory.Exists(pSource))
			{
				LogService.LogWarning("Source directory " + pSource + " does not exist");
				LogService.LogStackTraceAsWarning();
				return;
			}
			if (!Directory.Exists(pTarget))
			{
				Directory.CreateDirectory(pTarget);
			}
			Queue<string> queue = new Queue<string>();
			queue.Enqueue("");
			while (queue.Count > 0)
			{
				string text = queue.Dequeue();
				DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(pSource, text));
				DirectoryInfo directoryInfo2 = new DirectoryInfo(Path.Combine(pTarget, text));
				if (!directoryInfo2.Exists)
				{
					directoryInfo2.Create();
				}
				FileInfo[] files = directoryInfo.GetFiles();
				foreach (FileInfo fileInfo in files)
				{
					fileInfo.CopyTo(Path.Combine(pTarget, text, fileInfo.Name), overwrite: true);
				}
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				foreach (DirectoryInfo directoryInfo3 in directories)
				{
					queue.Enqueue(Path.Combine(text, directoryInfo3.Name));
				}
			}
		}
	}
}
namespace NeoModLoader.utils.SerializedAssets
{
	[Serializable]
	public class SerializableAsset<A> where A : Asset, new()
	{
		public Dictionary<string, object> Variables = new Dictionary<string, object>();

		public Dictionary<string, string> Delegates = new Dictionary<string, string>();

		public static void Serialize(A Asset, SerializableAsset<A> asset)
		{
			FieldInfo[] fields = typeof(A).GetFields();
			foreach (FieldInfo fieldInfo in fields)
			{
				object value = fieldInfo.GetValue(Asset);
				if (value is Delegate pDelegate)
				{
					asset.Delegates.Add(fieldInfo.Name, pDelegate.AsString());
				}
				else
				{
					asset.Variables.Add(fieldInfo.Name, value);
				}
			}
		}

		public static SerializableAsset<A> FromAsset(A Asset)
		{
			SerializableAsset<A> serializableAsset = new SerializableAsset<A>();
			Serialize(Asset, serializableAsset);
			return serializableAsset;
		}

		public static void Deserialize(SerializableAsset<A> Asset, A asset)
		{
			FieldInfo[] fields = typeof(A).GetFields();
			foreach (FieldInfo fieldInfo in fields)
			{
				object value2;
				if (typeof(Delegate).IsAssignableFrom(fieldInfo.FieldType))
				{
					if (Asset.Delegates.TryGetValue(fieldInfo.Name, out var value))
					{
						fieldInfo.SetValue(asset, value.AsDelegate(fieldInfo.FieldType));
					}
				}
				else if (Asset.Variables.TryGetValue(fieldInfo.Name, out value2))
				{
					fieldInfo.SetValue(asset, GetRealValueOfObject(value2, fieldInfo.FieldType));
				}
			}
			static object GetRealValueOfObject(object Value, Type Type)
			{
				if (Type == typeof(int))
				{
					return Convert.ToInt32(Value);
				}
				if (Type == typeof(float))
				{
					return Convert.ToSingle(Value);
				}
				if (Value is JObject jObject)
				{
					return jObject.ToObject(Type);
				}
				return Value;
			}
		}

		public static A ToAsset(SerializableAsset<A> Asset)
		{
			A val = new A();
			Deserialize(Asset, val);
			return val;
		}
	}
	public class SerializedActorTrait : SerializableAsset<ActorTrait>
	{
		public string AdditionalBaseStatsMethod;

		public static SerializedActorTrait FromAsset(ActorTrait Asset, GetAdditionalBaseStatsMethod Method = null)
		{
			SerializedActorTrait serializedActorTrait = new SerializedActorTrait();
			SerializableAsset<ActorTrait>.Serialize(Asset, serializedActorTrait);
			if (Method != null)
			{
				serializedActorTrait.AdditionalBaseStatsMethod = Method.AsString();
			}
			return serializedActorTrait;
		}

		public static ActorTrait ToAsset(SerializedActorTrait Asset)
		{
			ActorTrait actorTrait = new ActorTrait();
			SerializableAsset<ActorTrait>.Deserialize(Asset, actorTrait);
			if (Asset.AdditionalBaseStatsMethod != null)
			{
				ActorTraitBuilder.AdditionalBaseStatMethods.TryAdd(actorTrait.id, Asset.AdditionalBaseStatsMethod.AsDelegate<GetAdditionalBaseStatsMethod>());
			}
			return actorTrait;
		}
	}
	public class SerializedItemAsset : SerializableAsset<ItemAsset>
	{
		internal string[] CultureTraitsThisItemIsIn;

		internal string[] CultureTraitsThisItemsTypeIsIn;

		public static SerializedItemAsset FromAsset(ItemAsset Asset, IEnumerable<string> cultureTraitsItem = null, IEnumerable<string> cultureTraitsType = null)
		{
			SerializedItemAsset serializedItemAsset = new SerializedItemAsset();
			SerializableAsset<ItemAsset>.Serialize(Asset, serializedItemAsset);
			if (cultureTraitsItem != null)
			{
				serializedItemAsset.CultureTraitsThisItemIsIn = cultureTraitsItem.ToArray();
			}
			if (cultureTraitsType != null)
			{
				serializedItemAsset.CultureTraitsThisItemsTypeIsIn = cultureTraitsType.ToArray();
			}
			return serializedItemAsset;
		}

		public static ItemAsset ToAsset(SerializedItemAsset Asset)
		{
			ItemAsset itemAsset = new ItemAsset();
			SerializableAsset<ItemAsset>.Deserialize(Asset, itemAsset);
			return itemAsset;
		}
	}
}
namespace NeoModLoader.utils.instpredictors
{
	public class BaseInstPredictor
	{
		private static readonly Dictionary<System.Reflection.Emit.OpCode, HashSet<System.Reflection.Emit.OpCode>> equal_opcodes = new Dictionary<System.Reflection.Emit.OpCode, HashSet<System.Reflection.Emit.OpCode>>();

		private readonly Func<CodeInstruction, bool> predicate;

		protected BaseInstPredictor()
		{
		}

		public BaseInstPredictor(System.Reflection.Emit.OpCode pOpCode)
		{
			predicate = (CodeInstruction inst) => OpcodeEquals(pOpCode, inst);
		}

		public BaseInstPredictor(object pOperand)
		{
			predicate = (CodeInstruction inst) => inst.operand == pOperand;
		}

		public BaseInstPredictor(System.Reflection.Emit.OpCode pOpCode, object pOperand)
		{
			predicate = (CodeInstruction inst) => OpcodeEquals(pOpCode, inst) && inst.operand == pOperand;
		}

		public BaseInstPredictor(Func<CodeInstruction, bool> pPredicate)
		{
			predicate = pPredicate;
		}

		public virtual bool Predict(CodeInstruction pInst)
		{
			return predicate?.Invoke(pInst) ?? true;
		}

		protected static bool OpcodeEquals(System.Reflection.Emit.OpCode pOpCode, System.Reflection.Emit.OpCode pOpCodeAnother)
		{
			return pOpCodeAnother == pOpCode;
		}

		protected static bool OpcodeEquals(CodeInstruction pInst, CodeInstruction pInstAnother)
		{
			HashSet<System.Reflection.Emit.OpCode> value;
			return pInst.opcode == pInstAnother.opcode || (equal_opcodes.TryGetValue(pInst.opcode, out value) && value.Contains(pInstAnother.opcode));
		}

		protected static bool OpcodeEquals(System.Reflection.Emit.OpCode pOpCode, CodeInstruction pInst)
		{
			HashSet<System.Reflection.Emit.OpCode> value;
			return pInst.opcode == pOpCode || (equal_opcodes.TryGetValue(pOpCode, out value) && value.Contains(pInst.opcode));
		}

		protected static bool OpcodeEquals(CodeInstruction pInst, System.Reflection.Emit.OpCode pOpCode)
		{
			HashSet<System.Reflection.Emit.OpCode> value;
			return pInst.opcode == pOpCode || (equal_opcodes.TryGetValue(pOpCode, out value) && value.Contains(pInst.opcode));
		}

		internal static void _init()
		{
			AddEqualOpCodes(System.Reflection.Emit.OpCodes.Br, System.Reflection.Emit.OpCodes.Br_S);
			AddEqualOpCodes(System.Reflection.Emit.OpCodes.Brtrue, System.Reflection.Emit.OpCodes.Brtrue_S);
			AddEqualOpCodes(System.Reflection.Emit.OpCodes.Brfalse, System.Reflection.Emit.OpCodes.Brfalse_S);
		}

		private static void AddEqualOpCodes(params System.Reflection.Emit.OpCode[] pOpCodes)
		{
			foreach (System.Reflection.Emit.OpCode key in pOpCodes)
			{
				if (!equal_opcodes.TryGetValue(key, out var value))
				{
					value = new HashSet<System.Reflection.Emit.OpCode>();
					equal_opcodes[key] = value;
				}
				value.UnionWith(pOpCodes);
				foreach (System.Reflection.Emit.OpCode key2 in pOpCodes)
				{
					if (equal_opcodes.TryGetValue(key2, out var value2))
					{
						value.UnionWith(value2);
					}
				}
			}
		}
	}
}
namespace NeoModLoader.utils.installers
{
	internal abstract class ACmdModInstaller
	{
		public abstract Task<bool> CheckInstall(string pParam);
	}
	internal class GBModInstaller : ACmdModInstaller
	{
		private const string base_match_regex = "^(?<scheme>ncms|nml):(?<url_to_archive>.*)$";

		private const string addition_match_regex = "^(?<scheme>ncms|nml):(?<url_to_archive>.*),(?<mod_type>.*),(?<mod_id>.*)$";

		public override async Task<bool> CheckInstall(string pParam)
		{
			if (!pParam.StartsWith("ncms:") && !pParam.StartsWith("nml:"))
			{
				return false;
			}
			Match match;
			if (!Regex.IsMatch(pParam, "^(?<scheme>ncms|nml):(?<url_to_archive>.*),(?<mod_type>.*),(?<mod_id>.*)$"))
			{
				if (!Regex.IsMatch(pParam, "^(?<scheme>ncms|nml):(?<url_to_archive>.*)$"))
				{
					return false;
				}
				match = Regex.Match(pParam, "^(?<scheme>ncms|nml):(?<url_to_archive>.*)$");
			}
			else
			{
				match = Regex.Match(pParam, "^(?<scheme>ncms|nml):(?<url_to_archive>.*),(?<mod_type>.*),(?<mod_id>.*)$");
			}
			string url_to_archive = match.Groups["url_to_archive"].Value;
			using WebClient client = new WebClient();
			string zip_file_path = Path.Combine(Paths.ModsPath, Guid.NewGuid().ToString() + ".zip");
			await client.DownloadFileTaskAsync(new Uri(url_to_archive), zip_file_path);
			string mod_folder_path = ModInfoUtils.TryToUnzipModZip(zip_file_path);
			return ModCompileLoadService.TryCompileAndLoadModAtRuntime(ModInfoUtils.recogMod(mod_folder_path));
		}
	}
}
namespace NeoModLoader.utils.Builders
{
	public sealed class ActorAssetBuilder : UnlockableAssetBuilder<ActorAsset, ActorAssetLibrary>
	{
		public ActorAssetBuilder(string ID)
			: base(ID)
		{
		}

		public ActorAssetBuilder(string FilePath, bool LoadImmediately)
			: base(FilePath, LoadImmediately)
		{
		}

		public ActorAssetBuilder(string ID, string CopyFrom)
			: base(ID, CopyFrom)
		{
		}
	}
	public delegate BaseStats GetAdditionalBaseStatsMethod(Actor Actor);
	public sealed class ActorTraitBuilder : BaseTraitBuilder<ActorTrait, ActorTraitLibrary>
	{
		internal static ConcurrentDictionary<string, GetAdditionalBaseStatsMethod> AdditionalBaseStatMethods = new ConcurrentDictionary<string, GetAdditionalBaseStatsMethod>();

		public GetAdditionalBaseStatsMethod AdditionalBaseStatsMethod
		{
			set
			{
				if (!AdditionalBaseStatMethods.TryAdd(base.Asset.id, value))
				{
					AdditionalBaseStatMethods[base.Asset.id] = value;
				}
			}
		}

		public bool AffectsMind
		{
			get
			{
				return base.Asset.affects_mind;
			}
			set
			{
				base.Asset.affects_mind = value;
			}
		}

		public bool CanBeCured
		{
			get
			{
				return base.Asset.can_be_cured;
			}
			set
			{
				base.Asset.can_be_cured = value;
			}
		}

		public bool RemovedByAcceleratedHealing
		{
			get
			{
				return base.Asset.can_be_removed_by_accelerated_healing;
			}
			set
			{
				base.Asset.can_be_removed_by_accelerated_healing = value;
			}
		}

		public bool RemovedByDevineLight
		{
			get
			{
				return base.Asset.can_be_removed_by_accelerated_healing;
			}
			set
			{
				base.Asset.can_be_removed_by_divine_light = value;
			}
		}

		public bool IsCombatSkill
		{
			get
			{
				return base.Asset.in_training_dummy_combat_pot;
			}
			set
			{
				base.Asset.in_training_dummy_combat_pot = value;
			}
		}

		public bool ActiveInDarkEra
		{
			get
			{
				return base.Asset.era_active_night;
			}
			set
			{
				base.Asset.era_active_night = value;
			}
		}

		public bool ActiveInMoonEra
		{
			get
			{
				return base.Asset.era_active_moon;
			}
			set
			{
				base.Asset.era_active_moon = value;
			}
		}

		public string ForcedKingdomID
		{
			get
			{
				return base.Asset.forced_kingdom;
			}
			set
			{
				base.Asset.forced_kingdom = value;
			}
		}

		public bool UsedInMutationBox
		{
			get
			{
				return base.Asset.is_mutation_box_allowed;
			}
			set
			{
				base.Asset.is_mutation_box_allowed = value;
			}
		}

		public float ActorsLikeability
		{
			get
			{
				return base.Asset.likeability;
			}
			set
			{
				base.Asset.likeability = value;
			}
		}

		public int OppositeTraitLikeability
		{
			get
			{
				return base.Asset.opposite_trait_mod;
			}
			set
			{
				base.Asset.opposite_trait_mod = value;
			}
		}

		public int RateAcquireWhenGrownUp
		{
			get
			{
				return base.Asset.rate_acquire_grow_up;
			}
			set
			{
				base.Asset.rate_acquire_grow_up = value;
			}
		}

		public int RateBirth
		{
			get
			{
				return base.Asset.rate_birth;
			}
			set
			{
				base.Asset.rate_birth = value;
			}
		}

		public int RateInherit
		{
			get
			{
				return base.Asset.rate_inherit;
			}
			set
			{
				base.Asset.rate_inherit = value;
			}
		}

		public bool RemoveForZombies
		{
			get
			{
				return base.Asset.remove_for_zombie_actor_asset;
			}
			set
			{
				base.Asset.remove_for_zombie_actor_asset = value;
			}
		}

		public int SameTraitLikeability
		{
			get
			{
				return base.Asset.same_trait_mod;
			}
			set
			{
				base.Asset.same_trait_mod = value;
			}
		}

		public TraitType Type
		{
			get
			{
				return base.Asset.type;
			}
			set
			{
				base.Asset.type = value;
			}
		}

		public ActorTraitBuilder(string ID)
			: base(ID)
		{
			base.Group = "miscellaneous";
		}

		protected override void LoadFromPath(string FilePathToBuild)
		{
			SerializedActorTrait asset = JsonConvert.DeserializeObject<SerializedActorTrait>(File.ReadAllText(FilePathToBuild));
			base.Asset = SerializedActorTrait.ToAsset(asset);
		}

		public ActorTraitBuilder(string ID, bool LoadImmediately)
			: base(ID, LoadImmediately)
		{
		}

		public ActorTraitBuilder(string ID, string CopyFrom)
			: base(ID, CopyFrom)
		{
		}

		private void LinkWithLibrary()
		{
			if (base.Asset.in_training_dummy_combat_pot)
			{
				Library.pot_traits_combat.Add(base.Asset);
			}
			if (base.Asset.is_mutation_box_allowed)
			{
				Library.pot_traits_mutation_box.Add(base.Asset);
			}
			if (base.Asset.rate_acquire_grow_up != 0)
			{
				for (int i = 0; i < base.Asset.rate_acquire_grow_up; i++)
				{
					Library.pot_traits_growup.Add(base.Asset);
				}
			}
			if (base.Asset.rate_birth != 0)
			{
				for (int j = 0; j < base.Asset.rate_birth; j++)
				{
					Library.pot_traits_birth.Add(base.Asset);
				}
			}
		}

		public override void Build(bool SetRarityAutomatically = false, bool AutoLocalize = true, bool LinkWithOtherAssets = false)
		{
			base.Build(SetRarityAutomatically, AutoLocalize, LinkWithOtherAssets);
			LinkWithLibrary();
			Library.checkDefault(base.Asset);
			base.Asset.only_active_on_era_flag = base.Asset.era_active_moon || base.Asset.era_active_night;
		}
	}
	public class AssetBuilder<A, AL> : Builder where A : Asset, new() where AL : AssetLibrary<A>
	{
		public readonly AL Library;

		internal string FilePathToBuild = null;

		public A Asset { get; protected set; }

		private AssetBuilder()
		{
			Library = GetLibrary();
		}

		protected virtual A CreateAsset(string ID)
		{
			return new A
			{
				id = ID
			};
		}

		protected virtual void Init()
		{
		}

		protected virtual void LoadFromPath(string FilePathToBuild)
		{
			SerializableAsset<A> asset = JsonConvert.DeserializeObject<SerializableAsset<A>>(File.ReadAllText(FilePathToBuild));
			Asset = SerializableAsset<A>.ToAsset(asset);
		}

		private void LoadAssetFromPath(string FilePathToBuild)
		{
			try
			{
				LoadFromPath(FilePathToBuild);
			}
			catch
			{
				LogService.LogError("the asset " + Path.GetFileName(FilePathToBuild) + " is outdated or corrupted!, make sure to serialize it on the latest version and use default serialization settings");
			}
		}

		public AssetBuilder(string ID)
			: this()
		{
			Asset = CreateAsset(ID);
			Init();
		}

		public AssetBuilder(string FilePath, bool LoadImmediately)
			: this()
		{
			if (LoadImmediately)
			{
				LoadAssetFromPath(FilePath);
			}
			else
			{
				FilePathToBuild = FilePath;
			}
		}

		public AssetBuilder(string ID, string CopyFrom)
			: this()
		{
			if (CopyFrom != null)
			{
				Library.clone(out var pNew, Library.get(CopyFrom));
				pNew.id = ID;
				Asset = pNew;
			}
			else
			{
				Asset = CreateAsset(ID);
			}
			Init();
		}

		private AL GetLibrary()
		{
			return AssetManager._instance._list.OfType<AL>().FirstOrDefault() ?? throw new NotImplementedException("No library found for " + typeof(A).Name + "!");
		}

		public override void Build(bool LinkWithOtherAssets)
		{
			if (FilePathToBuild != null)
			{
				LoadAssetFromPath(FilePathToBuild);
			}
			Library.add(Asset);
			base.Build(LinkWithOtherAssets);
		}

		public override void LinkAssets()
		{
		}
	}
	public class AugmentationAssetBuilder<A, AL> : UnlockableAssetBuilder<A, AL> where A : BaseAugmentationAsset, new() where AL : BaseLibraryWithUnlockables<A>
	{
		public IEnumerable<string> CombatActions
		{
			get
			{
				return base.Asset.combat_actions_ids;
			}
			set
			{
				foreach (string item in value)
				{
					base.Asset.addCombatAction(item);
				}
			}
		}

		public IEnumerable<string> Decisions
		{
			get
			{
				return base.Asset.decision_ids;
			}
			set
			{
				foreach (string item in value)
				{
					base.Asset.addDecision(item);
				}
			}
		}

		public IEnumerable<string> Spells
		{
			get
			{
				return base.Asset.spells_ids;
			}
			set
			{
				foreach (string item in value)
				{
					base.Asset.addSpell(item);
				}
			}
		}

		public AttackAction AttackAction
		{
			get
			{
				return base.Asset.action_attack_target;
			}
			set
			{
				base.Asset.action_attack_target = value;
			}
		}

		public WorldActionTrait ActionWhenAdded
		{
			get
			{
				return base.Asset.action_on_augmentation_add;
			}
			set
			{
				base.Asset.action_on_augmentation_add = value;
			}
		}

		public WorldActionTrait ActionWhenRemoved
		{
			get
			{
				return base.Asset.action_on_augmentation_remove;
			}
			set
			{
				base.Asset.action_on_augmentation_remove = value;
			}
		}

		public WorldActionTrait ActionOnLoad
		{
			get
			{
				return base.Asset.action_on_augmentation_load;
			}
			set
			{
				base.Asset.action_on_augmentation_load = value;
			}
		}

		public WorldAction ActonSpecialEffect
		{
			get
			{
				return base.Asset.action_special_effect;
			}
			set
			{
				base.Asset.action_special_effect = value;
			}
		}

		public float SpecialEffectCoolDown
		{
			get
			{
				return base.Asset.special_effect_interval;
			}
			set
			{
				base.Asset.special_effect_interval = value;
			}
		}

		public bool CanBeRemoved
		{
			get
			{
				return base.Asset.can_be_removed;
			}
			set
			{
				base.Asset.can_be_removed = value;
			}
		}

		public bool CanBeGiven
		{
			get
			{
				return base.Asset.can_be_given;
			}
			set
			{
				base.Asset.can_be_given = value;
			}
		}

		public string Group
		{
			get
			{
				return base.Asset.group_id;
			}
			set
			{
				base.Asset.group_id = value;
			}
		}

		public int Priority
		{
			get
			{
				return base.Asset.priority;
			}
			set
			{
				base.Asset.priority = value;
			}
		}

		public bool ShowInMetaEditor
		{
			get
			{
				return base.Asset.show_in_meta_editor;
			}
			set
			{
				base.Asset.show_in_meta_editor = value;
			}
		}

		public AugmentationAssetBuilder(string FilePath, bool LoadImmediately)
			: base(FilePath, LoadImmediately)
		{
		}

		public AugmentationAssetBuilder(string ID)
			: base(ID)
		{
		}

		public AugmentationAssetBuilder(string ID, string CopyFrom)
			: base(ID, CopyFrom)
		{
		}

		private void LinkDecisions()
		{
			if (base.Asset.decision_ids != null)
			{
				base.Asset.decisions_assets = new DecisionAsset[base.Asset.decision_ids.Count];
				for (int i = 0; i < base.Asset.decision_ids.Count; i++)
				{
					string pID = base.Asset.decision_ids[i];
					DecisionAsset decisionAsset = AssetManager.decisions_library.get(pID);
					base.Asset.decisions_assets[i] = decisionAsset;
				}
			}
		}

		public override void LinkAssets()
		{
			LinkDecisions();
			base.Asset.linkCombatActions();
			base.Asset.linkSpells();
			base.LinkAssets();
		}
	}
	public class BaseTraitBuilder<A, AL> : AugmentationAssetBuilder<A, AL> where A : BaseTrait<A>, new() where AL : BaseTraitLibrary<A>
	{
		public IEnumerable<string> OppositeTraits
		{
			get
			{
				return base.Asset.opposite_list;
			}
			set
			{
				foreach (string item in value)
				{
					base.Asset.addOpposite(item);
				}
			}
		}

		public IEnumerable<string> MetaTags
		{
			get
			{
				return base.Asset.base_stats_meta._tags;
			}
			set
			{
				foreach (string item in value)
				{
					base.Asset.base_stats_meta.addTag(item);
				}
			}
		}

		public IEnumerable<string> TraitsToRemove
		{
			get
			{
				return base.Asset.traits_to_remove_ids;
			}
			set
			{
				base.Asset.traits_to_remove_ids = TraitsToRemove.ToArray();
			}
		}

		public IEnumerable<Func<A, bool>> OpposeAllOtherTraits
		{
			set
			{
				foreach (Func<A, bool> item in value)
				{
					foreach (A item2 in Library.list)
					{
						if (item2.id != base.Asset.id && item(item2))
						{
							base.Asset.addOpposite(item2.id);
						}
					}
				}
			}
		}

		public int ChanceToGetOnCreation
		{
			get
			{
				return base.Asset.spawn_random_rate;
			}
			set
			{
				base.Asset.spawn_random_rate = value;
				base.Asset.spawn_random_trait_allowed = value > 0;
			}
		}

		public string Description1ID
		{
			get
			{
				return base.Asset.special_locale_description;
			}
			set
			{
				base.Asset.special_locale_description = value;
				if (value == null)
				{
					base.Asset.has_description_1 = false;
				}
				else
				{
					base.Asset.has_description_1 = true;
				}
			}
		}

		public string Description2ID
		{
			get
			{
				return base.Asset.special_locale_description_2;
			}
			set
			{
				base.Asset.special_locale_description_2 = value;
				if (value == null)
				{
					base.Asset.has_description_2 = false;
				}
				else
				{
					base.Asset.has_description_2 = true;
				}
			}
		}

		public string NameID
		{
			get
			{
				return base.Asset.special_locale_id;
			}
			set
			{
				base.Asset.special_locale_id = value;
				if (value == null)
				{
					base.Asset.has_localized_id = false;
				}
				else
				{
					base.Asset.has_localized_id = true;
				}
			}
		}

		public Rarity Rarity
		{
			get
			{
				return base.Asset.rarity;
			}
			set
			{
				base.Asset.rarity = value;
			}
		}

		public BaseStats BaseStatsMeta
		{
			get
			{
				return base.Asset.base_stats_meta;
			}
			set
			{
				base.Asset.base_stats_meta = value;
			}
		}

		public WorldAction ActionOnBirth
		{
			get
			{
				return base.Asset.action_birth;
			}
			set
			{
				base.Asset.action_birth = value;
			}
		}

		public WorldAction ActionOnDeath
		{
			get
			{
				return base.Asset.action_death;
			}
			set
			{
				base.Asset.action_death = value;
			}
		}

		public WorldAction ActionOnGrowth
		{
			get
			{
				return base.Asset.action_growth;
			}
			set
			{
				base.Asset.action_growth = value;
			}
		}

		public GetHitAction ActionGetHit
		{
			get
			{
				return base.Asset.action_get_hit;
			}
			set
			{
				base.Asset.action_get_hit = value;
			}
		}

		public bool CanBeInBook
		{
			get
			{
				return base.Asset.can_be_in_book;
			}
			set
			{
				base.Asset.can_be_in_book = value;
			}
		}

		public float CustomValue
		{
			get
			{
				return base.Asset.value;
			}
			set
			{
				base.Asset.value = value;
			}
		}

		public string PlotID
		{
			get
			{
				return base.Asset.plot_id;
			}
			set
			{
				base.Asset.plot_id = value;
			}
		}

		public BaseTraitBuilder(string ID)
			: base(ID)
		{
		}

		public BaseTraitBuilder(string FilePath, bool LoadImmediately)
			: base(FilePath, LoadImmediately)
		{
		}

		public BaseTraitBuilder(string ID, string CopyFrom)
			: base(ID, CopyFrom)
		{
		}

		protected override void Init()
		{
			Description1ID = null;
			Description2ID = null;
			NameID = null;
		}

		public override void Build(bool LinkWithOtherAssets)
		{
			Build(SetRarityAutomatically: false, AutoLocalize: true, LinkWithOtherAssets);
		}

		private void LinkWithActors()
		{
			foreach (ActorAsset item in AssetManager.actor_library.list)
			{
				List<string> defaultTraitsForMeta = ((BaseTraitLibrary<A>)Library).getDefaultTraitsForMeta(item);
				if (defaultTraitsForMeta != null && defaultTraitsForMeta.Contains(base.Asset.id))
				{
					BaseTrait<A> asset = base.Asset;
					if (asset.default_for_actor_assets == null)
					{
						asset.default_for_actor_assets = new List<ActorAsset>();
					}
					base.Asset.default_for_actor_assets.Add(item);
				}
			}
		}

		private void LinkWithTraits()
		{
			if (base.Asset.opposite_list != null && base.Asset.opposite_list.Count > 0)
			{
				base.Asset.opposite_traits = new HashSet<A>(base.Asset.opposite_list.Count);
				foreach (string item2 in base.Asset.opposite_list)
				{
					A item = Library.get(item2);
					base.Asset.opposite_traits.Add(item);
				}
			}
			if (base.Asset.traits_to_remove_ids != null)
			{
				int num = base.Asset.traits_to_remove_ids.Length;
				base.Asset.traits_to_remove = new A[num];
				for (int i = 0; i < num; i++)
				{
					string pID = base.Asset.traits_to_remove_ids[i];
					A val = Library.get(pID);
					base.Asset.traits_to_remove[i] = val;
				}
			}
		}

		private void CheckIcon()
		{
			if (string.IsNullOrEmpty(base.Asset.path_icon))
			{
				base.Asset.path_icon = ((BaseTraitLibrary<A>)Library).icon_path + base.Asset.getLocaleID();
			}
		}

		private void LinkWithBaseLibrary()
		{
			if (base.Asset.spawn_random_trait_allowed)
			{
				((BaseTraitLibrary<A>)Library)._pot_allowed_to_be_given_randomly.AddTimes(base.Asset.spawn_random_rate, base.Asset);
			}
		}

		private void SetRarityAutomatically()
		{
			if (base.Asset.unlocked_with_achievement)
			{
				base.Asset.rarity = Rarity.R3_Legendary;
				return;
			}
			bool flag = base.Asset.decision_ids != null;
			bool flag2 = base.Asset.spells_ids != null;
			bool flag3 = base.Asset.combat_actions_ids != null;
			bool flag4 = base.Asset.base_stats.hasTags();
			bool flag5 = !string.IsNullOrEmpty(base.Asset.plot_id);
			int num = 0;
			if (base.Asset.action_death != null || base.Asset.action_special_effect != null || base.Asset.action_get_hit != null || base.Asset.action_birth != null || base.Asset.action_attack_target != null || base.Asset.action_on_augmentation_add != null || base.Asset.action_on_augmentation_remove != null || base.Asset.action_on_augmentation_load != null)
			{
				num++;
			}
			if (flag)
			{
				num++;
			}
			if (flag2)
			{
				num++;
			}
			if (flag3)
			{
				num++;
			}
			if (flag4)
			{
				num++;
			}
			if (flag5)
			{
				num++;
			}
			if (num > 0)
			{
				if (num == 1)
				{
					base.Asset.rarity = Rarity.R1_Rare;
				}
				else
				{
					base.Asset.rarity = Rarity.R2_Epic;
				}
			}
		}

		public override void LinkAssets()
		{
			LinkWithTraits();
			LinkWithActors();
			base.LinkAssets();
		}

		public virtual void Build(bool SetRarityAutomatically = false, bool AutoLocalize = true, bool LinkWithOtherAssets = false)
		{
			base.Build(LinkWithOtherAssets);
			if (AutoLocalize)
			{
				Localize(base.Asset.special_locale_id, base.Asset.special_locale_description, base.Asset.special_locale_description_2);
			}
			if (SetRarityAutomatically)
			{
				this.SetRarityAutomatically();
			}
			CheckIcon();
			LinkWithBaseLibrary();
		}

		public void Localize(string Name = null, string Description = null, string Description2 = null)
		{
			if (Name != null)
			{
				LM.AddToCurrentLocale(base.Asset.special_locale_id, Name);
			}
			if (Description != null)
			{
				LM.AddToCurrentLocale(base.Asset.special_locale_description, Description);
			}
			if (Description2 != null)
			{
				LM.AddToCurrentLocale(base.Asset.special_locale_description_2, Description2);
			}
		}
	}
	public abstract class Builder
	{
		public virtual void Build(bool LinkWithOtherAssets)
		{
			if (LinkWithOtherAssets)
			{
				LinkAssets();
			}
		}

		public abstract void LinkAssets();
	}
	public sealed class ClanTraitBuilder : BaseTraitBuilder<ClanTrait, ClanTraitLibrary>
	{
		public BaseStats BaseStatsMale
		{
			get
			{
				return base.Asset.base_stats_male;
			}
			set
			{
				base.Asset.base_stats_male = value;
			}
		}

		public BaseStats BaseStatsFemale
		{
			get
			{
				return base.Asset.base_stats_female;
			}
			set
			{
				base.Asset.base_stats_female = value;
			}
		}

		public ClanTraitBuilder(string ID)
			: base(ID)
		{
		}

		public ClanTraitBuilder(string FilePath, bool LoadImmediately)
			: base(FilePath, LoadImmediately)
		{
		}

		public ClanTraitBuilder(string ID, string CopyFrom)
			: base(ID, CopyFrom)
		{
		}
	}
	public sealed class CultureTraitBuilder : BaseTraitBuilder<CultureTrait, CultureTraitLibrary>
	{
		public IEnumerable<string> Weapons
		{
			get
			{
				return base.Asset.related_weapons_ids;
			}
			set
			{
				foreach (string item in value)
				{
					base.Asset.addWeaponSpecial(item);
				}
			}
		}

		public IEnumerable<string> WeaponSubTypes
		{
			get
			{
				return base.Asset.related_weapon_subtype_ids;
			}
			set
			{
				foreach (string item in value)
				{
					base.Asset.addWeaponSubtype(item);
				}
			}
		}

		public PassableZoneChecker TownLayoutPlan
		{
			get
			{
				return base.Asset.passable_zone_checker;
			}
			set
			{
				base.Asset.setTownLayoutPlan(value);
			}
		}

		public CultureTraitBuilder(string ID)
			: base(ID)
		{
		}

		public CultureTraitBuilder(string FilePath, bool LoadImmediately)
			: base(FilePath, LoadImmediately)
		{
		}

		public CultureTraitBuilder(string ID, string CopyFrom)
			: base(ID, CopyFrom)
		{
		}

		public override void LinkAssets()
		{
			if (base.Asset.town_layout_plan)
			{
				base.OpposeAllOtherTraits = new Func<CultureTrait, bool>[1]
				{
					(CultureTrait trait) => trait.town_layout_plan
				};
			}
			base.LinkAssets();
		}
	}
	public sealed class GroupAssetBuilder<A> : AssetBuilder<A, AssetLibrary<A>> where A : BaseCategoryAsset, new()
	{
		public string Name
		{
			get
			{
				return base.Asset.name;
			}
			set
			{
				base.Asset.name = value;
			}
		}

		public string ColorHexCode
		{
			get
			{
				return base.Asset.color;
			}
			set
			{
				base.Asset.color = value;
			}
		}

		public GroupAssetBuilder(string ID)
			: base(ID)
		{
		}

		public GroupAssetBuilder(string FilePath, bool LoadImmediately)
			: base(FilePath, LoadImmediately)
		{
		}

		public GroupAssetBuilder(string ID, string CopyFrom)
			: base(ID, CopyFrom)
		{
		}

		public override void Build(bool LinkWithOtherAssets)
		{
			Localize();
			Build(LinkWithOtherAssets);
		}

		public void Localize(string LocalName = null)
		{
			if (LocalName == null)
			{
				LocalName = base.Asset.getLocaleID();
			}
			LM.AddToCurrentLocale(base.Asset.getLocaleID(), LocalName);
		}

		public void SetColor(UnityEngine.Color color)
		{
			ColorHexCode = Toolbox.colorToHex(color);
		}
	}
	public sealed class MasterBuilder
	{
		private readonly List<Builder> Builders = new List<Builder>();

		public B AddBuilder<B>(B Builder) where B : Builder
		{
			Builders.Add(Builder);
			return Builder;
		}

		public void AddBuilders(IEnumerable<Builder> Builders)
		{
			if (Builders != null)
			{
				this.Builders.AddRange(Builders);
			}
		}

		public void BuildAll()
		{
			foreach (Builder builder in Builders)
			{
				builder.Build(LinkWithOtherAssets: false);
			}
			foreach (Builder builder2 in Builders)
			{
				builder2.LinkAssets();
			}
		}
	}
	public enum SubSpeciesTrait
	{
		Trait,
		PhenoType,
		Egg,
		SkinMutation
	}
	public sealed class SubspeciesTraitBuilder : BaseTraitBuilder<SubspeciesTrait, SubspeciesTraitLibrary>
	{
		public bool UsesSpecialIconLogic
		{
			get
			{
				return base.Asset.special_icon_logic;
			}
			set
			{
				base.Asset.special_icon_logic = value;
			}
		}

		public (string[], float) SwimAnimation
		{
			get
			{
				return (base.Asset.animation_swim, base.Asset.animation_swim_speed);
			}
			set
			{
				base.Asset.animation_swim = value.Item1;
				base.Asset.animation_swim_speed = value.Item2;
			}
		}

		public (string[], float) WalkAnimation
		{
			get
			{
				return (base.Asset.animation_walk, base.Asset.animation_walk_speed);
			}
			set
			{
				base.Asset.animation_walk = value.Item1;
				base.Asset.animation_walk_speed = value.Item2;
			}
		}

		public (string[], float) IdleAnimation
		{
			get
			{
				return (base.Asset.animation_idle, base.Asset.animation_idle_speed);
			}
			set
			{
				base.Asset.animation_idle = value.Item1;
				base.Asset.animation_idle_speed = value.Item2;
			}
		}

		public bool CanBeAddedFromMutations
		{
			get
			{
				return base.Asset.in_mutation_pot_add;
			}
			set
			{
				base.Asset.in_mutation_pot_add = value;
			}
		}

		public bool CanbeRemovedFromMutations
		{
			get
			{
				return base.Asset.in_mutation_pot_remove;
			}
			set
			{
				base.Asset.in_mutation_pot_remove = value;
			}
		}

		public List<string> FemaleSkins
		{
			get
			{
				return base.Asset.skin_citizen_female;
			}
			set
			{
				base.Asset.skin_citizen_female = value;
			}
		}

		public List<string> MaleSkins
		{
			get
			{
				return base.Asset.skin_citizen_male;
			}
			set
			{
				base.Asset.skin_citizen_male = value;
			}
		}

		public List<string> WarriorSkins
		{
			get
			{
				return base.Asset.skin_warrior;
			}
			set
			{
				base.Asset.skin_warrior = value;
			}
		}

		public bool DietRelated
		{
			get
			{
				return base.Asset.is_diet_related;
			}
			set
			{
				base.Asset.is_diet_related = value;
			}
		}

		public bool RemoveIfZombieSubSpecies
		{
			get
			{
				return base.Asset.remove_for_zombies;
			}
			set
			{
				base.Asset.remove_for_zombies = value;
			}
		}

		public bool DontRotateWhenUnconscious
		{
			get
			{
				return base.Asset.prevent_unconscious_rotation;
			}
			set
			{
				base.Asset.prevent_unconscious_rotation = value;
			}
		}

		private static string TraitToDerive(SubSpeciesTrait trait)
		{
			if (1 == 0)
			{
			}
			string result = trait switch
			{
				SubSpeciesTrait.Trait => null, 
				SubSpeciesTrait.Egg => "$egg$", 
				SubSpeciesTrait.SkinMutation => "$skin_mutation$", 
				_ => null, 
			};
			if (1 == 0)
			{
			}
			return result;
		}

		public SubspeciesTraitBuilder(string ID, AfterHatchFromEggAction afterHatchFromEggAction)
			: this(ID, SubSpeciesTrait.Egg)
		{
			base.Asset.after_hatch_from_egg_action = afterHatchFromEggAction;
		}

		public SubspeciesTraitBuilder(string ID, string OverridePath, bool RenderChildHeads)
			: this(ID, SubSpeciesTrait.SkinMutation)
		{
			base.Asset.render_heads_for_children = RenderChildHeads;
			base.Asset.sprite_path = OverridePath;
		}

		public SubspeciesTraitBuilder(string ID, SubSpeciesTrait Type)
			: base(ID, TraitToDerive(Type))
		{
			switch (Type)
			{
			case SubSpeciesTrait.PhenoType:
				UsesSpecialIconLogic = true;
				base.PathIcon = "ui/Icons/iconPhenotype";
				base.Asset.id = "phenotype_skin_" + ID;
				base.Asset.phenotype_skin = true;
				base.Asset.id_phenotype = ID;
				base.Asset.group_id = "phenotypes";
				base.NameID = "subspecies_trait_phenotype";
				base.Description1ID = "subspecies_trait_phenotype_info";
				base.Asset.spawn_random_trait_allowed = false;
				break;
			case SubSpeciesTrait.Egg:
				base.Asset.id_egg = base.Asset.id;
				base.Asset.sprite_path = "eggs/" + base.Asset.id_egg;
				break;
			}
		}

		private void LinkWithLibrary()
		{
			if (base.Asset.spawn_random_trait_allowed)
			{
				((BaseTraitLibrary<SubspeciesTrait>)Library)._pot_allowed_to_be_given_randomly.Add(base.Asset);
			}
			if (base.Asset.in_mutation_pot_add)
			{
				int rate = base.Asset.rarity.GetRate();
				Library._pot_mutation_traits_add.AddTimes(rate, base.Asset);
			}
			if (base.Asset.in_mutation_pot_remove)
			{
				int rate2 = base.Asset.rarity.GetRate();
				Library._pot_mutation_traits_remove.AddTimes(rate2, base.Asset);
			}
			if (base.Asset.phenotype_egg && base.Asset.after_hatch_from_egg_action != null)
			{
				base.Asset.has_after_hatch_from_egg_action = true;
			}
		}

		public override void Build(bool SetRarityAutomatically = false, bool AutoLocalize = true, bool LinkWithOtherAssets = false)
		{
			base.Build(SetRarityAutomatically, AutoLocalize, LinkWithOtherAssets);
			Library.loadSpritesPaths(base.Asset);
			LinkWithLibrary();
		}

		public override void LinkAssets()
		{
			if (base.Asset.id_phenotype != null)
			{
				PhenotypeAsset phenotypeAsset = AssetManager.phenotype_library.get(base.Asset.id_phenotype);
				phenotypeAsset.subspecies_trait_id = base.Asset.id;
				base.Asset.priority = phenotypeAsset.priority;
			}
			if (base.Asset.is_mutation_skin)
			{
				base.OpposeAllOtherTraits = new Func<SubspeciesTrait, bool>[1]
				{
					(SubspeciesTrait trait) => trait.is_mutation_skin
				};
			}
			if (base.Asset.phenotype_skin)
			{
				base.OpposeAllOtherTraits = new Func<SubspeciesTrait, bool>[1]
				{
					(SubspeciesTrait trait) => trait.phenotype_skin
				};
			}
			if (base.Asset.phenotype_egg)
			{
				base.OpposeAllOtherTraits = new Func<SubspeciesTrait, bool>[1]
				{
					(SubspeciesTrait trait) => trait.phenotype_egg
				};
			}
			base.LinkAssets();
		}

		public SubspeciesTraitBuilder(string FilePath, bool LoadImmediately)
			: base(FilePath, LoadImmediately)
		{
		}

		public SubspeciesTraitBuilder(string ID, string CopyFrom)
			: base(ID, CopyFrom)
		{
		}
	}
	public class UnlockableAssetBuilder<A, AL> : AssetBuilder<A, AL> where A : BaseUnlockableAsset, new() where AL : BaseLibraryWithUnlockables<A>
	{
		public bool NeedsToBeExplored
		{
			get
			{
				return base.Asset.needs_to_be_explored;
			}
			set
			{
				base.Asset.needs_to_be_explored = value;
			}
		}

		public string AchievmentToUnlockThis
		{
			get
			{
				return base.Asset.achievement_id;
			}
			set
			{
				base.Asset.unlocked_with_achievement = value != null;
				base.Asset.achievement_id = value;
			}
		}

		public Dictionary<string, float> Stats
		{
			set
			{
				foreach (KeyValuePair<string, float> item in value)
				{
					BaseStats[item.Key] = item.Value;
				}
			}
		}

		public BaseStats BaseStats
		{
			get
			{
				return base.Asset.base_stats;
			}
			set
			{
				base.Asset.base_stats = value;
			}
		}

		public string PathIcon
		{
			get
			{
				return base.Asset.path_icon;
			}
			set
			{
				base.Asset.path_icon = value;
			}
		}

		public bool ShowInKnowledgeWindow
		{
			get
			{
				return base.Asset.show_in_knowledge_window;
			}
			set
			{
				base.Asset.show_in_knowledge_window = value;
			}
		}

		public UnlockableAssetBuilder(string ID)
			: base(ID)
		{
			BaseStats = new BaseStats();
		}

		public UnlockableAssetBuilder(string FilePath, bool LoadImmediately)
			: base(FilePath, LoadImmediately)
		{
		}

		public UnlockableAssetBuilder(string ID, string CopyFrom)
			: base(ID, CopyFrom)
		{
		}

		private void LinkWithAchievment()
		{
			if (base.Asset.unlocked_with_achievement)
			{
				Achievement achievement = AssetManager.achievements.get(base.Asset.achievement_id);
				if (achievement.unlock_assets == null)
				{
					achievement.unlock_assets = new List<BaseUnlockableAsset>();
					achievement.unlocks_something = true;
				}
				achievement.unlock_assets.Add(base.Asset);
			}
		}

		public override void LinkAssets()
		{
			LinkWithAchievment();
		}

		public void UnlockByDefault()
		{
			base.Asset.unlocked_with_achievement = false;
			base.Asset.achievement_id = null;
			base.Asset.needs_to_be_explored = false;
		}
	}
}
namespace NeoModLoader.utils.authentication
{
	public class AuthenticaticationException : Exception
	{
		public AuthenticaticationException()
		{
		}

		public AuthenticaticationException(string message)
			: base(message)
		{
		}

		public AuthenticaticationException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
	public class DiscordAutomaticRoleAuthUtils
	{
		public static bool Authenticate()
		{
			if (Config.game_loaded)
			{
				if (Config.discordId != null)
				{
					return DiscordCommonAuthLogic.ModderIsInRolesList(DiscordCommonAuthLogic.GetRolesOfUser(Config.discordId));
				}
				throw new AuthenticaticationException("The game was unable to fetch a Discord ID.");
			}
			throw new AuthenticaticationException("The game isn't loaded yet, so no Discord ID is available.");
		}
	}
	internal static class DiscordCommonAuthLogic
	{
		internal static IEnumerable<string> GetRolesOfUser(string user_id)
		{
			HttpResponseMessage httpResponseMessage = HttpUtils.Get("http://95.216.161.50:3000/user/roles/" + user_id, new Dictionary<string, string>());
			if (httpResponseMessage.StatusCode != HttpStatusCode.OK)
			{
				httpResponseMessage = HttpUtils.Get("https://keymasterer.uk:5000/user/roles/" + user_id, new Dictionary<string, string>());
			}
			string result = httpResponseMessage.Content.ReadAsStringAsync().Result;
			return from role in result.Trim('[', ']', ' ').Split(new char[1] { ',' })
				select role.Trim('"', ' ');
		}

		internal static bool ModderIsInRolesList(IEnumerable<string> roles)
		{
			return roles.Any((string role) => role == "647734005625651220");
		}
	}
	public class DiscordRoleAuthViaUserLoginUtils
	{
		private struct TokenInfo
		{
			public string access_token;

			public string token_type;

			public string expires_in;

			public string refresh_token;

			public string scope;
		}

		private const string client_id = "1171719697557880892";

		public static bool Authenticate()
		{
			return DiscordCommonAuthLogic.ModderIsInRolesList(DiscordCommonAuthLogic.GetRolesOfUser(GetUserID(GetAuthToken())));
		}

		public static void Test()
		{
			TokenInfo authToken = GetAuthToken();
			System.Diagnostics.Debug.WriteLine(authToken.access_token);
			string userID = GetUserID(authToken);
			System.Diagnostics.Debug.WriteLine(userID);
			IEnumerable<string> rolesOfUser = DiscordCommonAuthLogic.GetRolesOfUser(userID);
			bool flag = DiscordCommonAuthLogic.ModderIsInRolesList(rolesOfUser);
			System.Diagnostics.Debug.WriteLine(flag);
			if (flag)
			{
				Console.WriteLine("You are a modder!");
			}
			else
			{
				Console.WriteLine("You are not a modder!");
			}
			Console.WriteLine("Tests:");
			rolesOfUser = DiscordCommonAuthLogic.GetRolesOfUser("1171719697557880892");
			rolesOfUser.ToList().ForEach(Console.WriteLine);
			rolesOfUser = DiscordCommonAuthLogic.GetRolesOfUser("0000000000000000000");
			rolesOfUser.ToList().ForEach(Console.WriteLine);
		}

		private static string GetUserID(TokenInfo token_info)
		{
			HttpResponseMessage httpResponseMessage = HttpUtils.Get("https://discordapp.com/api/users/@me", new Dictionary<string, string> { 
			{
				"Authorization",
				token_info.token_type + " " + token_info.access_token
			} });
			string result = httpResponseMessage.Content.ReadAsStringAsync().Result;
			string[] source = result.Trim(' ', 'd', 'a', 't', 'a', ':', '{', '}').Split(new char[1] { ',' });
			using (IEnumerator<string[]> enumerator = (from segment in source
				select segment.Split(new char[1] { ':' }) into pair
				where pair[0].Trim('"', ' ') == "id"
				select pair).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					string[] current = enumerator.Current;
					return current[1].Trim('"', ' ');
				}
			}
			return "";
		}

		private static TokenInfo GetAuthToken()
		{
			HttpListener listener = new HttpListener();
			listener.Prefixes.Add("http://localhost:36549/");
			listener.Start();
			Application.OpenURL("https://discord.com/api/oauth2/authorize?client_id=1171719697557880892&redirect_uri=http%3A%2F%2Flocalhost%3A36549&response_type=code&scope=identify");
			new Task(delegate
			{
				HttpListener httpListener = listener;
				int num = 0;
				while (num < 60000)
				{
					if (!httpListener.IsListening)
					{
						return;
					}
					num += 100;
					System.Threading.Thread.Sleep(100);
				}
				httpListener.Close();
			}).Start();
			HttpListenerContext context;
			try
			{
				context = listener.GetContext();
			}
			catch (InvalidOperationException innerException)
			{
				throw new Exception("Failed to get context", innerException);
			}
			HttpListenerRequest request = context.Request;
			HttpListenerResponse response = context.Response;
			string text;
			try
			{
				text = request.QueryString["code"];
				string text2 = "<html><head><title>NeoModLoader</title><style>body {background-color: black; color: white;}</style></head><body>Success!<br>You can close this page!</body></html>";
				response.OutputStream.Write((from c in text2.ToCharArray()
					select (byte)c).ToArray(), 0, text2.Length);
			}
			catch (Exception)
			{
				string text2 = "<html><head><title>NeoModLoader</title><style>body {background-color: black; color: white;}</style></head><body>Error!<br>Authentication declined!</body></html>";
				UnityEngine.Debug.LogWarning("Manual Discord Authentication declined!");
				response.OutputStream.Write((from c in text2.ToCharArray()
					select (byte)c).ToArray(), 0, text2.Length);
				throw new AuthenticaticationException("Discord user authentication declined.");
			}
			response.Close();
			System.Diagnostics.Debug.WriteLine(text);
			listener.Close();
			HttpResponseMessage result;
			using (HttpClient httpClient = new HttpClient())
			{
				result = httpClient.GetAsync("https://keymasterer.uk/nml/api/get-discord-access-token/" + text).Result;
			}
			string result2 = result.Content.ReadAsStringAsync().Result;
			System.Diagnostics.Debug.WriteLine(result2);
			Console.WriteLine(result2);
			string[] array = result2.Split(new char[1] { ',' });
			return new TokenInfo
			{
				token_type = array[0].Split(new char[1] { ':' })[1].Trim('"', ' '),
				access_token = array[1].Split(new char[1] { ':' })[1].Trim('"', ' '),
				expires_in = array[2].Split(new char[1] { ':' })[1].Trim('"', ' '),
				refresh_token = array[3].Split(new char[1] { ':' })[1].Trim('"', ' '),
				scope = array[4].Split(new char[1] { ':' })[1].Trim('"', ' ', '}')
			};
		}
	}
	public static class GithubOrgAuthUtils
	{
		private struct TokenInfo
		{
			public string access_token;

			public string token_type;

			public string scope;
		}

		private struct UserInfo
		{
			public string login;
		}

		private struct DeviceFlow
		{
			public string device_code;

			public string user_code;

			public string verification_uri;

			public int interval;

			public int expires_in;
		}

		private const string client_id = "Iv1.c85ea6bddeb2ed41";

		private static string domain = "github.com";

		private static readonly string[] _alter_domains = new string[1] { "github.com" };

		public static bool Authenticate()
		{
			string tokenByDeviceFlow = GetTokenByDeviceFlow();
			if (string.IsNullOrEmpty(tokenByDeviceFlow))
			{
				return false;
			}
			HttpResponseMessage httpResponseMessage = HttpUtils.Get("https://api." + domain + "/user", new Dictionary<string, string>
			{
				{
					"Authorization",
					"Bearer " + tokenByDeviceFlow
				},
				{ "User-Agent", "NeoModLoader" }
			});
			UserInfo userInfo = JsonConvert.DeserializeObject<UserInfo>(httpResponseMessage.Content.ReadAsStringAsync().Result);
			httpResponseMessage = HttpUtils.Get("https://api." + domain + "/orgs/WorldBoxOpenMods/members/" + userInfo.login, new Dictionary<string, string>
			{
				{
					"Authorization",
					"Bearer " + tokenByDeviceFlow
				},
				{ "User-Agent", "NeoModLoader" },
				{ "Accept", "application/vnd.github.v3+json" }
			});
			if (httpResponseMessage.StatusCode == HttpStatusCode.NoContent)
			{
				return true;
			}
			return false;
		}

		private static string GetTokenByDeviceFlow()
		{
			string text = "";
			string[] alter_domains = _alter_domains;
			foreach (string text2 in alter_domains)
			{
				try
				{
					text = HttpUtils.Post("https://" + text2 + "/login/device/code", new Dictionary<string, string> { { "client_id", "Iv1.c85ea6bddeb2ed41" } }, new Dictionary<string, string> { { "Accept", "application/json" } }, 5.0);
					if (!string.IsNullOrEmpty(text))
					{
						domain = text2;
						break;
					}
				}
				catch (Exception)
				{
				}
			}
			if (string.IsNullOrEmpty(text))
			{
				throw new AuthenticaticationException("Failed to get device code.");
			}
			DeviceFlow deviceFlow = JsonConvert.DeserializeObject<DeviceFlow>(text);
			InformationWindow.ShowWindow(string.Format(LM.Get("GithubAuth Tip"), deviceFlow.user_code));
			Application.OpenURL(deviceFlow.verification_uri);
			int num = 0;
			while (num < deviceFlow.expires_in * 1000)
			{
				System.Threading.Thread.Sleep(deviceFlow.interval * 1000);
				num += deviceFlow.interval * 1000;
				text = HttpUtils.Post("https://" + domain + "/login/oauth/access_token", new Dictionary<string, string>
				{
					{ "client_id", "Iv1.c85ea6bddeb2ed41" },
					{ "device_code", deviceFlow.device_code },
					{ "grant_type", "urn:ietf:params:oauth:grant-type:device_code" }
				}, new Dictionary<string, string> { { "Accept", "application/json" } });
				if (text.Contains("access_token"))
				{
					break;
				}
			}
			InformationWindow.Back();
			return JsonConvert.DeserializeObject<TokenInfo>(text).access_token;
		}
	}
}
namespace NeoModLoader.ui
{
	public class InformationWindow : SingleAutoLayoutWindow<InformationWindow>
	{
		private Action on_close;

		private Text text;

		protected override void Init()
		{
			text = new GameObject("Text", typeof(Text)).GetComponent<Text>();
			OT.InitializeCommonText(text);
			text.resizeTextForBestFit = true;
			text.resizeTextMinSize = 10;
			text.resizeTextMaxSize = 14;
			text.alignment = TextAnchor.MiddleCenter;
			AddChild(text.gameObject);
		}

		public static void ShowWindow(string info, Action on_close = null)
		{
			SingleAutoLayoutWindow<InformationWindow>.Instance.text.text = info;
			SingleAutoLayoutWindow<InformationWindow>.Instance.on_close = on_close;
			ScrollWindow.showWindow(SingleAutoLayoutWindow<InformationWindow>.WindowId);
		}

		public override void OnNormalDisable()
		{
			try
			{
				on_close?.Invoke();
			}
			catch (Exception ex)
			{
				LogService.LogError(ex.Message);
				LogService.LogError(ex.StackTrace);
			}
			on_close = null;
		}

		public static void HideWindow()
		{
			SingleAutoLayoutWindow<InformationWindow>.Instance.ScrollWindowComponent.clickHide();
		}

		public static void Back()
		{
			SingleAutoLayoutWindow<InformationWindow>.Instance.ScrollWindowComponent.clickBack();
		}
	}
	public class ModConfigureWindow : AbstractWindow<ModConfigureWindow>
	{
		private class ModConfigGrid : MonoBehaviour
		{
			private Transform grid;

			private Text title;

			private void OnEnable()
			{
				title = base.transform.Find("Title").GetComponent<Text>();
				grid = base.transform.Find("Grid");
			}

			public void Setup(string id, Dictionary<string, ModConfigItem> items)
			{
				base.name = id;
				title.text = LM.Get(id);
				foreach (KeyValuePair<string, ModConfigItem> item in items)
				{
					ModConfigListItem next = _itemPool.getNext();
					Transform transform;
					(transform = next.transform).SetParent(grid);
					transform.localScale = Vector3.one;
					next.Setup(item.Value);
				}
			}
		}

		private class ModConfigListItem : MonoBehaviour
		{
			public GameObject switch_area;

			public GameObject slider_area;

			public GameObject text_area;

			public GameObject select_area;

			public void Setup(ModConfigItem pItem)
			{
				base.name = pItem.Id;
				switch_area.SetActive(value: false);
				slider_area.SetActive(value: false);
				text_area.SetActive(value: false);
				select_area.SetActive(value: false);
				switch (pItem.Type)
				{
				case ConfigItemType.SWITCH:
					setup_switch(pItem);
					break;
				case ConfigItemType.SLIDER:
					setup_slider(pItem);
					break;
				case ConfigItemType.INT_SLIDER:
					setup_int_slider(pItem);
					break;
				case ConfigItemType.TEXT:
					setup_text(pItem);
					break;
				case ConfigItemType.SELECT:
					break;
				}
			}

			private void setup_text(ModConfigItem pItem)
			{
				text_area.SetActive(value: true);
				TextInput component = text_area.transform.Find("Input").GetComponent<TextInput>();
				component.Setup(pItem.TextVal, delegate(string pStringVal)
				{
					if (!AbstractWindow<ModConfigureWindow>.Instance._modifiedItems.ContainsKey(pItem))
					{
						AbstractWindow<ModConfigureWindow>.Instance._modifiedItems.Add(pItem, pItem.GetValue());
					}
					pItem.SetValue(pStringVal, pSkipCallback: true);
				});
				component.tip_button.textOnClick = pItem.Id;
				component.tip_button.text_description_2 = pItem.Id + " Description";
				text_area.transform.Find("Info/Text").GetComponent<Text>().text = LM.Get(pItem.Id);
				if (string.IsNullOrEmpty(pItem.IconPath))
				{
					text_area.transform.Find("Info/Icon").gameObject.SetActive(value: false);
					return;
				}
				UnityEngine.UI.Image component2 = text_area.transform.Find("Info/Icon").GetComponent<UnityEngine.UI.Image>();
				component2.gameObject.SetActive(value: true);
				component2.sprite = SpriteTextureLoader.getSprite(pItem.IconPath);
			}

			private void setup_slider(ModConfigItem pItem)
			{
				slider_area.SetActive(value: true);
				Text value = slider_area.transform.Find("Info/Value").GetComponent<Text>();
				value.text = $"{pItem.FloatVal:F2}";
				SliderBar component = slider_area.transform.Find("Slider").GetComponent<SliderBar>();
				component.Setup(pItem.FloatVal, pItem.MinFloatVal, pItem.MaxFloatVal, delegate(float pFloatVal)
				{
					if (!AbstractWindow<ModConfigureWindow>.Instance._modifiedItems.ContainsKey(pItem))
					{
						AbstractWindow<ModConfigureWindow>.Instance._modifiedItems.Add(pItem, pItem.GetValue());
					}
					pItem.SetValue(pFloatVal, pSkipCallback: true);
					value.text = $"{pItem.FloatVal:F2}";
				});
				component.tip_button.textOnClick = pItem.Id;
				component.tip_button.text_description_2 = pItem.Id + " Description";
				slider_area.transform.Find("Info/Text").GetComponent<Text>().text = LM.Get(pItem.Id);
				if (string.IsNullOrEmpty(pItem.IconPath))
				{
					slider_area.transform.Find("Info/Icon").gameObject.SetActive(value: false);
					return;
				}
				UnityEngine.UI.Image component2 = slider_area.transform.Find("Info/Icon").GetComponent<UnityEngine.UI.Image>();
				component2.gameObject.SetActive(value: true);
				component2.sprite = SpriteTextureLoader.getSprite(pItem.IconPath);
			}

			private void setup_int_slider(ModConfigItem pItem)
			{
				slider_area.SetActive(value: true);
				Text value = slider_area.transform.Find("Info/Value").GetComponent<Text>();
				value.text = $"{pItem.IntVal}";
				SliderBar component = slider_area.transform.Find("Slider").GetComponent<SliderBar>();
				component.Setup(pItem.IntVal, pItem.MinIntVal, pItem.MaxIntVal, delegate(float pIntVal)
				{
					if (!AbstractWindow<ModConfigureWindow>.Instance._modifiedItems.ContainsKey(pItem))
					{
						AbstractWindow<ModConfigureWindow>.Instance._modifiedItems.Add(pItem, pItem.GetValue());
					}
					pItem.SetValue(pIntVal, pSkipCallback: true);
					value.text = $"{pItem.IntVal}";
				}, default(Vector2), whole_numbers: true);
				component.tip_button.textOnClick = pItem.Id;
				component.tip_button.text_description_2 = pItem.Id + " Description";
				slider_area.transform.Find("Info/Text").GetComponent<Text>().text = LM.Get(pItem.Id);
				if (string.IsNullOrEmpty(pItem.IconPath))
				{
					slider_area.transform.Find("Info/Icon").gameObject.SetActive(value: false);
					return;
				}
				UnityEngine.UI.Image component2 = slider_area.transform.Find("Info/Icon").GetComponent<UnityEngine.UI.Image>();
				component2.gameObject.SetActive(value: true);
				component2.sprite = SpriteTextureLoader.getSprite(pItem.IconPath);
			}

			private void setup_switch(ModConfigItem pItem)
			{
				switch_area.SetActive(value: true);
				NeoModLoader.General.UI.Prefabs.SwitchButton component = switch_area.transform.Find("Button").GetComponent<NeoModLoader.General.UI.Prefabs.SwitchButton>();
				component.Setup(pItem.BoolVal, delegate
				{
					if (!AbstractWindow<ModConfigureWindow>.Instance._modifiedItems.ContainsKey(pItem))
					{
						AbstractWindow<ModConfigureWindow>.Instance._modifiedItems.Add(pItem, pItem.GetValue());
					}
					pItem.SetValue(!pItem.BoolVal, pSkipCallback: true);
				});
				component.tip_button.textOnClick = pItem.Id;
				component.tip_button.text_description_2 = pItem.Id + " Description";
				switch_area.transform.Find("Text").GetComponent<Text>().text = LM.Get(pItem.Id);
				if (string.IsNullOrEmpty(pItem.IconPath))
				{
					switch_area.transform.Find("Icon").gameObject.SetActive(value: false);
					return;
				}
				UnityEngine.UI.Image component2 = switch_area.transform.Find("Icon").GetComponent<UnityEngine.UI.Image>();
				component2.gameObject.SetActive(value: true);
				component2.sprite = SpriteTextureLoader.getSprite(pItem.IconPath);
			}
		}

		private static ModConfigGrid _gridPrefab;

		private static ModConfigListItem _itemPrefab;

		private static ObjectPoolGenericMono<ModConfigGrid> _gridPool;

		private static ObjectPoolGenericMono<ModConfigListItem> _itemPool;

		private readonly Dictionary<ModConfigItem, object> _modifiedItems = new Dictionary<ModConfigItem, object>();

		private ModConfig _config;

		protected override void Init()
		{
			base.BackgroundTransform.Find("Scroll View").gameObject.SetActive(value: true);
			base.BackgroundTransform.Find("Scroll View").GetComponent<RectTransform>().sizeDelta = new Vector2(232f, 270f);
			base.BackgroundTransform.Find("Scroll View").localPosition = new Vector3(0f, -6f);
			base.BackgroundTransform.Find("Scroll View/Viewport").GetComponent<RectTransform>().sizeDelta = new Vector2(30f, 0f);
			base.BackgroundTransform.Find("Scroll View/Viewport").localPosition = new Vector3(-131f, 135f);
			VerticalLayoutGroup verticalLayoutGroup = base.ContentTransform.gameObject.AddComponent<VerticalLayoutGroup>();
			verticalLayoutGroup.childControlHeight = true;
			verticalLayoutGroup.childControlWidth = true;
			verticalLayoutGroup.childForceExpandHeight = false;
			verticalLayoutGroup.childForceExpandWidth = false;
			verticalLayoutGroup.childAlignment = TextAnchor.UpperCenter;
			verticalLayoutGroup.padding = new RectOffset(32, 32, 0, 0);
			ContentSizeFitter contentSizeFitter = base.ContentTransform.gameObject.AddComponent<ContentSizeFitter>();
			contentSizeFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
			_createGridPrefab();
			_createItemPrefab();
			_gridPool = new ObjectPoolGenericMono<ModConfigGrid>(_gridPrefab, base.ContentTransform);
			_itemPool = new ObjectPoolGenericMono<ModConfigListItem>(_itemPrefab, base.BackgroundTransform);
		}

		private static void _createItemPrefab()
		{
			GameObject gameObject = new GameObject("ConfigItem", typeof(UnityEngine.UI.Image), typeof(VerticalLayoutGroup));
			VerticalLayoutGroup component = gameObject.GetComponent<VerticalLayoutGroup>();
			component.childAlignment = TextAnchor.MiddleLeft;
			component.padding = new RectOffset(4, 4, 3, 3);
			GameObject gameObject2 = new GameObject("SwitchArea", typeof(HorizontalLayoutGroup));
			HorizontalLayoutGroup component2 = gameObject2.GetComponent<HorizontalLayoutGroup>();
			component2.childControlWidth = false;
			component2.childControlHeight = false;
			component2.childAlignment = TextAnchor.MiddleLeft;
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.transform.localScale = Vector3.one;
			NeoModLoader.General.UI.Prefabs.SwitchButton switchButton = UnityEngine.Object.Instantiate(APrefab<NeoModLoader.General.UI.Prefabs.SwitchButton>.Prefab, gameObject2.transform);
			switchButton.transform.localScale = Vector3.one;
			switchButton.name = "Button";
			GameObject gameObject3 = new GameObject("Icon", typeof(UnityEngine.UI.Image));
			gameObject3.transform.SetParent(gameObject2.transform);
			gameObject3.transform.localScale = Vector3.one;
			gameObject3.GetComponent<RectTransform>().sizeDelta = new Vector2(16f, 16f);
			GameObject gameObject4 = new GameObject("Text", typeof(Text));
			gameObject4.transform.SetParent(gameObject2.transform);
			gameObject4.transform.localScale = Vector3.one;
			gameObject4.GetComponent<RectTransform>().sizeDelta = new Vector2(100f, 16f);
			Text component3 = gameObject4.GetComponent<Text>();
			OT.InitializeCommonText(component3);
			component3.alignment = TextAnchor.MiddleLeft;
			component3.resizeTextForBestFit = true;
			component3.resizeTextMinSize = 1;
			GameObject gameObject5 = new GameObject("SliderArea", typeof(RectTransform), typeof(VerticalLayoutGroup));
			gameObject5.transform.SetParent(gameObject.transform);
			gameObject5.transform.localScale = Vector3.one;
			VerticalLayoutGroup component4 = gameObject5.GetComponent<VerticalLayoutGroup>();
			component4.childControlWidth = true;
			component4.childControlHeight = false;
			component4.childForceExpandWidth = false;
			component4.childAlignment = TextAnchor.UpperCenter;
			component4.spacing = 4f;
			GameObject gameObject6 = new GameObject("Info", typeof(RectTransform), typeof(HorizontalLayoutGroup));
			gameObject6.transform.SetParent(gameObject5.transform);
			gameObject6.transform.localScale = Vector3.one;
			gameObject6.GetComponent<RectTransform>().sizeDelta = new Vector2(0f, 18f);
			HorizontalLayoutGroup component5 = gameObject6.GetComponent<HorizontalLayoutGroup>();
			component5.childControlWidth = false;
			component5.childControlHeight = false;
			component5.childAlignment = TextAnchor.MiddleLeft;
			GameObject gameObject7 = new GameObject("Icon", typeof(UnityEngine.UI.Image));
			gameObject7.transform.SetParent(gameObject6.transform);
			gameObject7.transform.localScale = Vector3.one;
			gameObject7.GetComponent<RectTransform>().sizeDelta = new Vector2(16f, 16f);
			GameObject gameObject8 = new GameObject("Text", typeof(Text));
			gameObject8.transform.SetParent(gameObject6.transform);
			gameObject8.transform.localScale = Vector3.one;
			gameObject8.GetComponent<RectTransform>().sizeDelta = new Vector2(100f, 16f);
			Text component6 = gameObject8.GetComponent<Text>();
			OT.InitializeCommonText(component6);
			component6.alignment = TextAnchor.MiddleLeft;
			component6.resizeTextForBestFit = true;
			GameObject gameObject9 = new GameObject("Value", typeof(Text));
			gameObject9.transform.SetParent(gameObject6.transform);
			gameObject9.transform.localScale = Vector3.one;
			gameObject9.GetComponent<RectTransform>().sizeDelta = new Vector2(32f, 16f);
			Text component7 = gameObject9.GetComponent<Text>();
			OT.InitializeCommonText(component7);
			component7.alignment = TextAnchor.MiddleRight;
			component7.resizeTextForBestFit = true;
			component7.resizeTextMinSize = 1;
			SliderBar sliderBar = UnityEngine.Object.Instantiate(APrefab<SliderBar>.Prefab, gameObject5.transform);
			sliderBar.transform.localScale = Vector3.one;
			sliderBar.name = "Slider";
			sliderBar.SetSize(new Vector2(170f, 20f));
			GameObject gameObject10 = new GameObject("TextArea", typeof(RectTransform), typeof(VerticalLayoutGroup));
			gameObject10.transform.SetParent(gameObject.transform);
			gameObject10.transform.localScale = Vector3.one;
			VerticalLayoutGroup component8 = gameObject10.GetComponent<VerticalLayoutGroup>();
			component8.childControlWidth = true;
			component8.childControlHeight = false;
			component8.childAlignment = TextAnchor.UpperCenter;
			component8.spacing = 4f;
			GameObject gameObject11 = new GameObject("Info", typeof(RectTransform), typeof(HorizontalLayoutGroup));
			gameObject11.transform.SetParent(gameObject10.transform);
			gameObject11.transform.localScale = Vector3.one;
			gameObject11.GetComponent<RectTransform>().sizeDelta = new Vector2(0f, 18f);
			HorizontalLayoutGroup component9 = gameObject11.GetComponent<HorizontalLayoutGroup>();
			component9.childControlWidth = false;
			component9.childControlHeight = false;
			component9.childForceExpandWidth = false;
			component9.childAlignment = TextAnchor.MiddleLeft;
			component9.spacing = 8f;
			GameObject gameObject12 = new GameObject("Icon", typeof(UnityEngine.UI.Image));
			gameObject12.transform.SetParent(gameObject11.transform);
			gameObject12.transform.localScale = Vector3.one;
			gameObject12.GetComponent<RectTransform>().sizeDelta = new Vector2(16f, 16f);
			GameObject gameObject13 = new GameObject("Text", typeof(Text));
			gameObject13.transform.SetParent(gameObject11.transform);
			gameObject13.transform.localScale = Vector3.one;
			gameObject13.GetComponent<RectTransform>().sizeDelta = new Vector2(100f, 16f);
			Text component10 = gameObject13.GetComponent<Text>();
			OT.InitializeCommonText(component10);
			component10.alignment = TextAnchor.MiddleLeft;
			component10.resizeTextForBestFit = true;
			component10.resizeTextMinSize = 1;
			TextInput textInput = UnityEngine.Object.Instantiate(APrefab<TextInput>.Prefab, gameObject10.transform);
			textInput.transform.localScale = Vector3.one;
			textInput.name = "Input";
			textInput.SetSize(new Vector2(170f, 20f));
			GameObject gameObject14 = new GameObject("SelectArea", typeof(RectTransform));
			gameObject14.transform.SetParent(gameObject.transform);
			gameObject14.transform.localScale = Vector3.one;
			gameObject.GetComponent<UnityEngine.UI.Image>().sprite = SpriteTextureLoader.getSprite("ui/special/windowInnerSliced");
			gameObject.GetComponent<UnityEngine.UI.Image>().type = UnityEngine.UI.Image.Type.Sliced;
			gameObject.transform.SetParent(WorldBoxMod.Transform);
			_itemPrefab = gameObject.AddComponent<ModConfigListItem>();
			_itemPrefab.switch_area = gameObject2;
			_itemPrefab.slider_area = gameObject5;
			_itemPrefab.text_area = gameObject10;
			_itemPrefab.select_area = gameObject14;
		}

		private static void _createGridPrefab()
		{
			GameObject gameObject = new GameObject("ConfigGrid", typeof(VerticalLayoutGroup));
			VerticalLayoutGroup component = gameObject.GetComponent<VerticalLayoutGroup>();
			component.childControlHeight = true;
			component.childControlWidth = true;
			component.childForceExpandHeight = false;
			component.childForceExpandWidth = false;
			component.childAlignment = TextAnchor.UpperCenter;
			GameObject gameObject2 = new GameObject("Title", typeof(Text));
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.transform.localScale = Vector3.one;
			Text component2 = gameObject2.GetComponent<Text>();
			component2.text = "Mod Config";
			component2.font = LocalizedTextManager.current_font;
			component2.resizeTextForBestFit = true;
			component2.resizeTextMinSize = 1;
			component2.resizeTextMaxSize = 10;
			component2.alignment = TextAnchor.MiddleCenter;
			GameObject gameObject3 = new GameObject("Grid", typeof(UnityEngine.UI.Image), typeof(VerticalLayoutGroup));
			gameObject3.transform.SetParent(gameObject.transform);
			gameObject3.transform.localScale = Vector3.one;
			component = gameObject3.GetComponent<VerticalLayoutGroup>();
			component.childControlHeight = true;
			component.childControlWidth = true;
			component.childForceExpandHeight = false;
			component.childForceExpandWidth = false;
			component.childAlignment = TextAnchor.UpperCenter;
			component.padding = new RectOffset(4, 4, 5, 5);
			component.spacing = 4f;
			gameObject3.GetComponent<UnityEngine.UI.Image>().sprite = SpriteTextureLoader.getSprite("ui/special/windowInnerSliced");
			gameObject3.GetComponent<UnityEngine.UI.Image>().type = UnityEngine.UI.Image.Type.Sliced;
			gameObject3.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color(1f, 1f, 1f, 0.5608f);
			gameObject.transform.SetParent(WorldBoxMod.Transform);
			_gridPrefab = gameObject.AddComponent<ModConfigGrid>();
		}

		public static void ShowWindow(ModConfig pConfig)
		{
			if (pConfig != null)
			{
				AbstractWindow<ModConfigureWindow>.Instance._config = pConfig;
				ScrollWindow.showWindow(AbstractWindow<ModConfigureWindow>.WindowId);
			}
		}

		public override void OnNormalEnable()
		{
			_modifiedItems.Clear();
			foreach (KeyValuePair<string, Dictionary<string, ModConfigItem>> item in _config._config)
			{
				ModConfigGrid next = _gridPool.getNext();
				next.Setup(item.Key, item.Value);
			}
		}

		public override void OnNormalDisable()
		{
			_gridPool.clear();
			_itemPool.clear();
			foreach (KeyValuePair<ModConfigItem, object> modifiedItem in _modifiedItems)
			{
				object value = modifiedItem.Key.GetValue();
				if (value != modifiedItem.Value)
				{
					modifiedItem.Key.SetValue(value);
				}
			}
			_config?.Save();
			_config = null;
		}
	}
	public class ModListWindow : AbstractListWindow<ModListWindow, IMod>
	{
		public class ModListItem : AbstractListWindowItem<IMod>
		{
			private IMod _mod;

			private IEnumerator WaitOpenWindow()
			{
				yield return new WaitForSeconds(3f);
				if (AbstractWindow<ModListWindow>.Instance.clickTimes == 8)
				{
					ModUploadWindow.ShowWindow(_mod);
				}
			}

			public override void Setup(IMod mod)
			{
				_mod = mod;
				ModDeclare mod_declare = mod.GetDeclaration();
				ModState modState = WorldBoxMod.AllRecognizedMods[mod_declare];
				Text component = base.transform.Find("Text").GetComponent<Text>();
				Text state_text = base.transform.Find("StateText").GetComponent<Text>();
				string text = mod_declare.Name;
				string text2 = mod_declare.Author;
				string text3 = mod_declare.Description;
				string text4 = text + "_" + LocalizedTextManager.instance.language;
				string text5 = text2 + "_" + LocalizedTextManager.instance.language;
				string text6 = text3 + "_" + LocalizedTextManager.instance.language;
				if (LocalizedTextManager.stringExists(text4))
				{
					text = LM.Get(text4);
				}
				if (LocalizedTextManager.stringExists(text5))
				{
					text2 = LM.Get(text5);
				}
				if (LocalizedTextManager.stringExists(text6))
				{
					text3 = LM.Get(text6);
				}
				switch (mod_declare.ModType)
				{
				case ModTypeEnum.NEOMOD:
				case ModTypeEnum.COMPILED_NEOMOD:
				case ModTypeEnum.RESOURCE_PACK:
					component.text = text + "\t" + mod_declare.Version + "\n" + text2 + "\n" + text3;
					break;
				case ModTypeEnum.BEPINEX:
					component.text = "[BepInEx] " + text + "\t" + mod_declare.Version + "\n" + text2 + "\n" + text3;
					break;
				default:
					throw new ArgumentOutOfRangeException();
				}
				Sprite sprite = null;
				if (!string.IsNullOrEmpty(mod_declare.IconPath) && File.Exists(Path.Combine(mod_declare.FolderPath, mod_declare.IconPath)))
				{
					sprite = SpriteLoadUtils.LoadSingleSprite(Path.Combine(mod_declare.FolderPath, mod_declare.IconPath));
				}
				if (sprite == null)
				{
					sprite = InternalResourcesGetter.GetIcon();
				}
				UnityEngine.UI.Image icon = base.transform.Find("Icon").GetComponent<UnityEngine.UI.Image>();
				Button component2 = base.transform.Find("Configure").GetComponent<Button>();
				Button component3 = base.transform.Find("Website").GetComponent<Button>();
				Button component4 = base.transform.Find("OpenFolder").GetComponent<Button>();
				TipButton icon_tip_button = icon.GetComponent<TipButton>();
				icon.sprite = sprite;
				IConfigurable configurable = mod.GetGameObject()?.GetComponent<IConfigurable>();
				component2.gameObject.SetActive(configurable != null);
				icon.GetComponent<Button>().onClick.RemoveAllListeners();
				component2.onClick.RemoveAllListeners();
				component3.onClick.RemoveAllListeners();
				component4.onClick.RemoveAllListeners();
				component4.onClick.AddListener(delegate
				{
					Application.OpenURL(mod_declare.FolderPath);
				});
				if (modState == ModState.LOADED)
				{
					icon.GetComponent<Button>().onClick.AddListener(delegate
					{
						float time = Time.time;
						if (time - AbstractWindow<ModListWindow>.Instance.lastClickTime > 1f)
						{
							AbstractWindow<ModListWindow>.Instance.clickTimes = 0;
						}
						if (mod_declare != AbstractWindow<ModListWindow>.Instance.clickedMod)
						{
							AbstractWindow<ModListWindow>.Instance.clickedMod = mod_declare;
							AbstractWindow<ModListWindow>.Instance.clickTimes = 0;
						}
						AbstractWindow<ModListWindow>.Instance.lastClickTime = time;
						AbstractWindow<ModListWindow>.Instance.clickTimes++;
						if (AbstractWindow<ModListWindow>.Instance.clickTimes == 8)
						{
							StartCoroutine("WaitOpenWindow");
						}
					});
				}
				if (1 == 0)
				{
				}
				string text7 = default(string);
				switch (modState)
				{
				case ModState.DISABLED:
					text7 = LM.Get("mod_state_disabled");
					break;
				case ModState.LOADED:
					text7 = LM.Get("mod_state_enabled");
					break;
				case ModState.FAILED:
					text7 = LM.Get("mod_state_failed");
					break;
				default:
					if (1 == 0)
					{
					}
					global::<PrivateImplementationDetails>.ThrowInvalidOperationException();
					break;
				}
				if (1 == 0)
				{
				}
				string current_state_text = text7;
				string next_state_text = LM.Get(ModInfoUtils.isModDisabled(mod_declare.UID) ? "mod_next_state_disabled" : "mod_next_state_enabled");
				state_text.text = current_state_text + ", " + next_state_text;
				if (modState == ModState.FAILED)
				{
					icon_tip_button.textOnClick = "ModLoadFailed Title";
					icon_tip_button.textOnClickDescription = "ModLoadFailed Description";
					icon_tip_button.text_description_2 = mod_declare.FailReason.ToString();
					icon.color = UnityEngine.Color.red;
					icon.GetComponent<Button>().onClick.AddListener(delegate
					{
						bool flag = ModInfoUtils.toggleMod(mod_declare.UID);
						icon.color = (flag ? UnityEngine.Color.red : UnityEngine.Color.yellow);
						next_state_text = LM.Get((!flag) ? "mod_next_state_disabled" : "mod_next_state_enabled");
						state_text.text = current_state_text + ", " + next_state_text;
					});
				}
				else
				{
					icon_tip_button.textOnClick = "ToggleMod Title";
					icon_tip_button.textOnClickDescription = (ModInfoUtils.isModDisabled(mod_declare.UID) ? "ModDisabled Description" : "ModEnabled Description");
					icon.color = (ModInfoUtils.isModDisabled(mod_declare.UID) ? UnityEngine.Color.gray : UnityEngine.Color.white);
					icon.GetComponent<Button>().onClick.AddListener(delegate
					{
						bool flag = ModInfoUtils.toggleMod(mod_declare.UID);
						icon_tip_button.textOnClickDescription = (flag ? "ModEnabled Description" : "ModDisabled Description");
						icon.color = (flag ? UnityEngine.Color.white : UnityEngine.Color.gray);
						next_state_text = LM.Get((!flag) ? "mod_next_state_disabled" : "mod_next_state_enabled");
						state_text.text = current_state_text + ", " + next_state_text;
						if (flag)
						{
							ModCompileLoadService.TryCompileAndLoadModAtRuntime(mod_declare);
						}
					});
					icon_tip_button.text_description_2 = "";
				}
				component2.onClick.AddListener(delegate
				{
					ModConfigureWindow.ShowWindow(configurable?.GetConfig());
				});
				component3.onClick.AddListener(delegate
				{
					Application.OpenURL(mod.GetUrl());
				});
				if (!Config.isEditor)
				{
					base.transform.Find("Reload").gameObject.SetActive(value: false);
					return;
				}
				IReloadable reloadable = mod.GetGameObject()?.GetComponent<IReloadable>();
				if (reloadable == null)
				{
					base.transform.Find("Reload").gameObject.SetActive(value: false);
					return;
				}
				Button component5 = base.transform.Find("Reload").GetComponent<Button>();
				component5.gameObject.SetActive(value: true);
				component5.onClick.RemoveAllListeners();
				component5.onClick.AddListener(delegate
				{
					if (!ModReloadUtils.Prepare(reloadable, mod_declare))
					{
						LogService.LogWarning("Failed to prepare mod " + mod_declare.Name + " for reloading.");
					}
					else if (!ModReloadUtils.CompileNew())
					{
						LogService.LogWarning("Failed to compile new mod " + mod_declare.Name + " for reloading.");
					}
					else if (!ModReloadUtils.PatchHotfixMethodsNT())
					{
						LogService.LogWarning("Failed to patch hotfix methods of mod " + mod_declare.Name + " for reloading.");
					}
					else if (!ModReloadUtils.Reload())
					{
						LogService.LogWarning("Failed to reload mod " + mod_declare.Name + ".");
					}
				});
			}
		}

		private readonly Queue<IMod> to_add = new Queue<IMod>();

		private ModDeclare clickedMod;

		private int clickTimes;

		private float lastClickTime;

		private bool needRefresh;

		private void Update()
		{
			if (IsOpened && needRefresh)
			{
				if (to_add.Any())
				{
					AddItemToList(to_add.Dequeue());
				}
				else
				{
					needRefresh = false;
				}
			}
		}

		protected override void Init()
		{
			GameObject gameObject = new GameObject("WorkshopButton", typeof(UnityEngine.UI.Image), typeof(Button), typeof(TipButton));
			gameObject.transform.SetParent(base.BackgroundTransform);
			gameObject.transform.localPosition = new Vector3(140f, 0f);
			gameObject.transform.localScale = Vector3.one;
			gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(20f, 20f);
			UnityEngine.UI.Image component = gameObject.GetComponent<UnityEngine.UI.Image>();
			component.sprite = Resources.Load<Sprite>("ui/icons/iconSteam");
			Button component2 = gameObject.GetComponent<Button>();
			component2.onClick.AddListener(delegate
			{
				if (Others.is_editor)
				{
					InformationWindow.ShowWindow("WorkshopMods Window is not supported in editor environment");
				}
				else
				{
					ScrollWindow.showWindow("WorkshopMods");
				}
			});
			TipButton component3 = gameObject.GetComponent<TipButton>();
			component3.textOnClick = "WorkshopMods Title";
			GameObject gameObject2 = new GameObject("ModLoaderButton", typeof(UnityEngine.UI.Image), typeof(Button), typeof(TipButton));
			gameObject2.transform.SetParent(base.BackgroundTransform);
			gameObject2.transform.localPosition = new Vector3(-125f, 0f);
			gameObject2.transform.localScale = Vector3.one;
			gameObject2.GetComponent<RectTransform>().sizeDelta = new Vector2(20f, 20f);
			UnityEngine.UI.Image component4 = gameObject2.GetComponent<UnityEngine.UI.Image>();
			component4.sprite = InternalResourcesGetter.GetIcon();
			TipButton component5 = gameObject2.GetComponent<TipButton>();
			component5.textOnClick = "NeoModLoader-v" + WorldBoxMod.NeoModLoaderAssembly.GetName().Version;
			foreach (string allLanguage in LocalizedTextManager.getAllLanguages())
			{
				LM.Add(allLanguage, "NMLCommit", "commit\n" + InternalResourcesGetter.GetCommit());
			}
			component5.text_description_2 = "NMLCommit";
			component5.textOnClickDescription = "NeoModLoader Report";
			Button component6 = gameObject2.GetComponent<Button>();
			component6.onClick.AddListener(delegate
			{
				Application.OpenURL("https://github.com/WorldBoxOpenMods/ModLoader");
			});
		}

		public override void OnNormalEnable()
		{
			needRefresh = true;
			ClearList();
			foreach (IMod loadedMod in WorldBoxMod.LoadedMods)
			{
				to_add.Enqueue(loadedMod);
			}
			foreach (ModDeclare key in WorldBoxMod.AllRecognizedMods.Keys)
			{
				if (WorldBoxMod.AllRecognizedMods[key] != ModState.LOADED)
				{
					VirtualMod virtualMod = new VirtualMod();
					virtualMod.OnLoad(key, null);
					to_add.Enqueue(virtualMod);
				}
			}
		}

		protected override AbstractListWindowItem<IMod> CreateItemPrefab()
		{
			GameObject gameObject = new GameObject("ModListItemPrefab", typeof(UnityEngine.UI.Image), typeof(ModListItem));
			gameObject.SetActive(value: false);
			gameObject.transform.SetParent(WorldBoxMod.Transform);
			gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(0f, 50f);
			UnityEngine.UI.Image component = gameObject.GetComponent<UnityEngine.UI.Image>();
			component.sprite = Resources.Load<Sprite>("ui/special/windowInnerSliced");
			component.type = UnityEngine.UI.Image.Type.Sliced;
			GameObject gameObject2 = new GameObject("Icon", typeof(UnityEngine.UI.Image), typeof(Button), typeof(TipButton));
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.transform.localPosition = new Vector3(-75f, 0f);
			gameObject2.transform.localScale = Vector3.one;
			gameObject2.GetComponent<RectTransform>().sizeDelta = new Vector2(40f, 40f);
			gameObject2.GetComponent<TipButton>().type = "normal";
			UnityEngine.UI.Image component2 = gameObject2.GetComponent<UnityEngine.UI.Image>();
			component2.sprite = InternalResourcesGetter.GetIcon();
			GameObject gameObject3 = new GameObject("IconFrame", typeof(UnityEngine.UI.Image));
			gameObject3.transform.SetParent(gameObject2.transform);
			gameObject3.transform.localPosition = Vector3.zero;
			gameObject3.transform.localScale = Vector3.one;
			gameObject3.GetComponent<RectTransform>().sizeDelta = gameObject2.GetComponent<RectTransform>().sizeDelta + new Vector2(5f, 5f);
			UnityEngine.UI.Image component3 = gameObject3.GetComponent<UnityEngine.UI.Image>();
			component3.sprite = InternalResourcesGetter.GetIconFrame();
			component3.type = UnityEngine.UI.Image.Type.Sliced;
			GameObject gameObject4 = new GameObject("Text", typeof(Text));
			gameObject4.transform.SetParent(gameObject.transform);
			gameObject4.transform.localPosition = new Vector3(2.5f, 0f);
			gameObject4.transform.localScale = Vector3.one;
			gameObject4.GetComponent<RectTransform>().sizeDelta = new Vector2(105f, 50f);
			Text component4 = gameObject4.GetComponent<Text>();
			component4.font = LocalizedTextManager.current_font;
			component4.fontSize = 6;
			component4.supportRichText = true;
			GameObject gameObject5 = new GameObject("StateText", typeof(Text));
			gameObject5.transform.SetParent(gameObject.transform);
			gameObject5.transform.localPosition = new Vector3(2.5f, -15.5f);
			gameObject5.transform.localScale = Vector3.one;
			gameObject5.GetComponent<RectTransform>().sizeDelta = new Vector2(105f, 10f);
			Text component5 = gameObject5.GetComponent<Text>();
			component5.font = LocalizedTextManager.current_font;
			component5.fontSize = 6;
			component5.supportRichText = true;
			component5.alignment = TextAnchor.LowerLeft;
			Vector2 vector = new Vector2(22f, 22f);
			GameObject gameObject6 = new GameObject("Configure", typeof(UnityEngine.UI.Image), typeof(Button), typeof(TipButton));
			gameObject6.transform.SetParent(gameObject.transform);
			gameObject6.transform.localPosition = new Vector3(87f, 12f);
			gameObject6.transform.localScale = Vector3.one;
			gameObject6.GetComponent<RectTransform>().sizeDelta = vector;
			gameObject6.GetComponent<TipButton>().textOnClick = "ModConfigure Title";
			UnityEngine.UI.Image component6 = gameObject6.GetComponent<UnityEngine.UI.Image>();
			component6.sprite = Resources.Load<Sprite>("ui/special/button2");
			component6.type = UnityEngine.UI.Image.Type.Sliced;
			GameObject gameObject7 = new GameObject("Icon", typeof(UnityEngine.UI.Image));
			gameObject7.transform.SetParent(gameObject6.transform);
			gameObject7.transform.localPosition = Vector3.zero;
			gameObject7.transform.localScale = Vector3.one;
			gameObject7.GetComponent<RectTransform>().sizeDelta = vector * 0.875f;
			UnityEngine.UI.Image component7 = gameObject7.GetComponent<UnityEngine.UI.Image>();
			component7.sprite = Resources.Load<Sprite>("ui/icons/iconoptions");
			GameObject gameObject8 = new GameObject("Website", typeof(UnityEngine.UI.Image), typeof(Button), typeof(TipButton));
			gameObject8.transform.SetParent(gameObject.transform);
			gameObject8.transform.localPosition = new Vector3(87f, -12f);
			gameObject8.transform.localScale = Vector3.one;
			gameObject8.GetComponent<RectTransform>().sizeDelta = vector;
			gameObject8.GetComponent<TipButton>().textOnClick = "ModCommunity Title";
			UnityEngine.UI.Image component8 = gameObject8.GetComponent<UnityEngine.UI.Image>();
			component8.sprite = Resources.Load<Sprite>("ui/special/button2");
			component8.type = UnityEngine.UI.Image.Type.Sliced;
			GameObject gameObject9 = new GameObject("Icon", typeof(UnityEngine.UI.Image));
			gameObject9.transform.SetParent(gameObject8.transform);
			gameObject9.transform.localPosition = Vector3.zero;
			gameObject9.transform.localScale = Vector3.one;
			gameObject9.GetComponent<RectTransform>().sizeDelta = vector * 0.875f;
			UnityEngine.UI.Image component9 = gameObject9.GetComponent<UnityEngine.UI.Image>();
			component9.sprite = Resources.Load<Sprite>("ui/icons/actor_traits/iconcommunity");
			GameObject gameObject10 = new GameObject("Reload", typeof(UnityEngine.UI.Image), typeof(Button), typeof(TipButton));
			gameObject10.transform.SetParent(gameObject.transform);
			gameObject10.transform.localPosition = new Vector3(64f, -12f);
			gameObject10.transform.localScale = Vector3.one;
			gameObject10.GetComponent<RectTransform>().sizeDelta = vector * 0.9f;
			gameObject10.GetComponent<TipButton>().textOnClick = "ModReload Title";
			UnityEngine.UI.Image component10 = gameObject10.GetComponent<UnityEngine.UI.Image>();
			component10.sprite = Resources.Load<Sprite>("ui/special/special_buttonred");
			component10.type = UnityEngine.UI.Image.Type.Sliced;
			GameObject gameObject11 = new GameObject("Icon", typeof(UnityEngine.UI.Image));
			gameObject11.transform.SetParent(gameObject10.transform);
			gameObject11.transform.localPosition = Vector3.zero;
			gameObject11.transform.localScale = Vector3.one;
			gameObject11.GetComponent<RectTransform>().sizeDelta = vector * 0.875f * 0.9f;
			UnityEngine.UI.Image component11 = gameObject11.GetComponent<UnityEngine.UI.Image>();
			component11.sprite = InternalResourcesGetter.GetReloadIcon();
			GameObject gameObject12 = new GameObject("OpenFolder", typeof(UnityEngine.UI.Image), typeof(Button), typeof(TipButton));
			gameObject12.transform.SetParent(gameObject.transform);
			gameObject12.transform.localPosition = new Vector3(64f, 11f);
			gameObject12.transform.localScale = Vector3.one;
			gameObject12.GetComponent<RectTransform>().sizeDelta = vector * 0.9f;
			gameObject12.GetComponent<TipButton>().textOnClick = "OpenFolder Title";
			UnityEngine.UI.Image component12 = gameObject12.GetComponent<UnityEngine.UI.Image>();
			component12.sprite = Resources.Load<Sprite>("ui/special/special_buttonred");
			component12.type = UnityEngine.UI.Image.Type.Sliced;
			GameObject gameObject13 = new GameObject("Icon", typeof(UnityEngine.UI.Image));
			gameObject13.transform.SetParent(gameObject12.transform);
			gameObject13.transform.localPosition = Vector3.zero;
			gameObject13.transform.localScale = Vector3.one;
			gameObject13.GetComponent<RectTransform>().sizeDelta = vector * 0.875f * 0.9f;
			UnityEngine.UI.Image component13 = gameObject13.GetComponent<UnityEngine.UI.Image>();
			component13.sprite = SpriteTextureLoader.getSprite("ui/icons/iconCustomWorld");
			return gameObject.GetComponent<ModListItem>();
		}
	}
	internal class ModUploadAuthenticationWindow : AbstractWindow<ModUploadAuthenticationWindow>
	{
		private static Button prefab_auth_button;

		internal static List<Func<bool>> all_auto_auth_funcs = new List<Func<bool>>
		{
			delegate
			{
				while (true)
				{
					if (!string.IsNullOrEmpty(Config.discordId))
					{
						return DiscordAutomaticRoleAuthUtils.Authenticate();
					}
					if (DiscordTracker._user_tries <= 0)
					{
						break;
					}
					System.Threading.Thread.Sleep(10000);
				}
				return false;
			}
		};

		private Transform auth_grid_transform;

		private Text auth_text;

		internal Func<bool> AuthFunc;

		internal bool AuthFuncSelected = false;

		internal bool AuthSkipped;

		private LocalizedText localized_auth_text;

		protected override void Init()
		{
			VerticalLayoutGroup verticalLayoutGroup = base.ContentTransform.gameObject.AddComponent<VerticalLayoutGroup>();
			verticalLayoutGroup.childAlignment = TextAnchor.UpperCenter;
			verticalLayoutGroup.childControlHeight = false;
			verticalLayoutGroup.childControlWidth = false;
			verticalLayoutGroup.childForceExpandHeight = false;
			verticalLayoutGroup.childForceExpandWidth = false;
			verticalLayoutGroup.spacing = 5f;
			verticalLayoutGroup.padding = new RectOffset(5, 5, 5, 5);
			GameObject gameObject = new GameObject("AuthText", typeof(Text), typeof(LocalizedText));
			gameObject.transform.SetParent(base.ContentTransform);
			gameObject.transform.localScale = Vector3.one;
			gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(190f, 50f);
			auth_text = gameObject.GetComponent<Text>();
			OT.InitializeCommonText(auth_text);
			auth_text.alignment = TextAnchor.MiddleCenter;
			auth_text.resizeTextForBestFit = true;
			auth_text.resizeTextMinSize = 6;
			auth_text.resizeTextMaxSize = 14;
			auth_text.color = UnityEngine.Color.white;
			localized_auth_text = gameObject.GetComponent<LocalizedText>();
			localized_auth_text.setKeyAndUpdate("nml_authentication");
			LocalizedTextManager.addTextField(localized_auth_text);
			GameObject gameObject2 = new GameObject("AuthGrid", typeof(GridLayoutGroup));
			gameObject2.transform.SetParent(base.ContentTransform);
			gameObject2.transform.localScale = Vector3.one;
			gameObject2.GetComponent<RectTransform>().sizeDelta = new Vector2(200f, 100f);
			auth_grid_transform = gameObject2.transform;
			GridLayoutGroup component = gameObject2.GetComponent<GridLayoutGroup>();
			component.cellSize = new Vector2(48f, 48f);
			component.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
			component.constraintCount = 3;
			component.spacing = new Vector2(5f, 5f);
			component.padding = new RectOffset(5, 5, 5, 5);
			component.childAlignment = TextAnchor.MiddleCenter;
			GameObject gameObject3 = new GameObject("AuthButton", typeof(UnityEngine.UI.Image), typeof(Button), typeof(TipButton));
			gameObject3.transform.SetParent(WorldBoxMod.Transform);
			prefab_auth_button = gameObject3.GetComponent<Button>();
			prefab_auth_button.image.sprite = SpriteTextureLoader.getSprite("ui/special/special_buttonred");
			prefab_auth_button.image.type = UnityEngine.UI.Image.Type.Sliced;
			GameObject gameObject4 = new GameObject("Icon", typeof(UnityEngine.UI.Image));
			gameObject4.transform.SetParent(gameObject3.transform);
			gameObject4.transform.localPosition = Vector3.zero;
			gameObject4.transform.localScale = Vector3.one;
			gameObject4.GetComponent<RectTransform>().sizeDelta = new Vector2(42f, 42f);
			CreateAuthButton("DiscordAuth", "ui/icons/iconDiscordWhite", DiscordRoleAuthViaUserLoginUtils.Authenticate, new Vector2(42f, 30.7f));
			CreateAuthButton("GithubAuth", InternalResourcesGetter.GetGitHubIcon(), GithubOrgAuthUtils.Authenticate);
			CreateAuthButton("SkipAuth", "ui/icons/iconArrowBack", null);
		}

		private Button CreateAuthButton(string pId, Sprite pIcon, Func<bool> pAuthFunc, Vector2 pIconSize = default(Vector2))
		{
			Button button = UnityEngine.Object.Instantiate(prefab_auth_button, auth_grid_transform);
			button.transform.Find("Icon").GetComponent<UnityEngine.UI.Image>().sprite = pIcon;
			if (pIconSize != default(Vector2))
			{
				button.transform.Find("Icon").GetComponent<RectTransform>().sizeDelta = pIconSize;
			}
			button.onClick.AddListener(delegate
			{
				if (pAuthFunc != null)
				{
					AuthFunc = pAuthFunc;
					AuthFuncSelected = true;
				}
				else
				{
					AuthSkipped = true;
				}
			});
			TipButton component = button.GetComponent<TipButton>();
			component.textOnClick = pId + " Title";
			component.text_description_2 = pId + " Description";
			return button;
		}

		private Button CreateAuthButton(string pId, string pIconPath, Func<bool> pAuthFunc, Vector2 pIconSize = default(Vector2))
		{
			return CreateAuthButton(pId, SpriteTextureLoader.getSprite(pIconPath), pAuthFunc, pIconSize);
		}

		public static void SetState(bool pAuthState, string pTipText = null)
		{
			AbstractWindow<ModUploadAuthenticationWindow>.Instance.auth_text.color = (pAuthState ? UnityEngine.Color.green : UnityEngine.Color.red);
			AbstractWindow<ModUploadAuthenticationWindow>.Instance.localized_auth_text.setKeyAndUpdate(pAuthState ? "nml_authenticated" : "nml_authentication_failed");
			if (!string.IsNullOrEmpty(pTipText))
			{
				Text text = AbstractWindow<ModUploadAuthenticationWindow>.Instance.auth_text;
				text.text = text.text + "\n" + pTipText;
				LogService.LogInfoConcurrent(pTipText);
			}
		}

		public static void SetText(string pText, UnityEngine.Color pColor = default(UnityEngine.Color))
		{
			AbstractWindow<ModUploadAuthenticationWindow>.Instance.auth_text.color = ((pColor == default(UnityEngine.Color)) ? UnityEngine.Color.white : pColor);
			AbstractWindow<ModUploadAuthenticationWindow>.Instance.auth_text.text = pText;
		}

		public bool Opened()
		{
			return IsOpened;
		}

		public override void OnNormalEnable()
		{
			base.OnNormalEnable();
			AuthSkipped = false;
			AuthFuncSelected = false;
			AuthFunc = null;
		}

		public override void OnNormalDisable()
		{
			base.OnNormalDisable();
		}
	}
	internal class ModUploadingProgressWindow : AbstractWindow<ModUploadingProgressWindow>
	{
		public class UploadProgress : IProgress<float>
		{
			public void Report(float value)
			{
				AbstractWindow<ModUploadingProgressWindow>.Instance.real_progress = value;
				if (!(AbstractWindow<ModUploadingProgressWindow>.Instance.progress >= value))
				{
					AbstractWindow<ModUploadingProgressWindow>.Instance.progress = value;
				}
			}

			public void Reset()
			{
				AbstractWindow<ModUploadingProgressWindow>.Instance.progress = 0f;
				AbstractWindow<ModUploadingProgressWindow>.Instance.real_progress = 0f;
			}
		}

		private UnityEngine.UI.Image bar;

		internal ulong fileId;

		private Text percent;

		private float progress = 0f;

		private float real_progress = 0f;

		private float start_time;

		private bool uploading = false;

		private UploadProgress uploadProgress = new UploadProgress();

		private void Update()
		{
			if (Initialized && IsOpened && uploading)
			{
				if (progress < 0.9f)
				{
					progress += Math.Max(0f, real_progress / (Time.time - start_time) * Time.deltaTime);
				}
				else
				{
					progress = Math.Max(progress, Mathf.Lerp(progress, real_progress, Time.deltaTime * 0.1f));
				}
				UpdateDisplay();
			}
		}

		protected override void Init()
		{
			percent = new GameObject("Percent", typeof(Text)).GetComponent<Text>();
			RectTransform component = percent.GetComponent<RectTransform>();
			component.SetParent(base.ContentTransform);
			component.localScale = Vector3.one;
			component.localPosition = new Vector3(130f, -100f);
			component.sizeDelta = new Vector2(180f, 30f);
			OT.InitializeCommonText(percent);
			percent.alignment = TextAnchor.MiddleCenter;
			percent.resizeTextMaxSize = 14;
			percent.resizeTextMinSize = 6;
			percent.resizeTextForBestFit = true;
			UnityEngine.UI.Image component2 = new GameObject("Bar", typeof(UnityEngine.UI.Image), typeof(Mask)).GetComponent<UnityEngine.UI.Image>();
			component2.sprite = SpriteTextureLoader.getSprite("ui/special/windowInnerSliced");
			component2.type = UnityEngine.UI.Image.Type.Sliced;
			component2.color = UnityEngine.Color.gray;
			RectTransform rectTransform;
			(rectTransform = (RectTransform)component2.transform).SetParent(base.ContentTransform);
			rectTransform.localScale = Vector3.one;
			rectTransform.localPosition = new Vector3(130f, -123f);
			rectTransform.sizeDelta = new Vector2(190f, 20f);
			bar = new GameObject("Image", typeof(UnityEngine.UI.Image)).GetComponent<UnityEngine.UI.Image>();
			RectTransform rectTransform2;
			(rectTransform2 = (RectTransform)bar.transform).SetParent(rectTransform);
			rectTransform2.localScale = Vector3.one;
			rectTransform2.sizeDelta = new Vector2(190f, 20f);
			rectTransform2.localPosition = new Vector3((0f - rectTransform2.sizeDelta.x) / 2f, 0f);
			rectTransform2.pivot = new Vector2(0f, 0.5f);
			bar.color = UnityEngine.Color.green;
		}

		public static UploadProgress ShowWindow()
		{
			AbstractWindow<ModUploadingProgressWindow>.Instance.uploading = true;
			AbstractWindow<ModUploadingProgressWindow>.Instance.uploadProgress.Reset();
			ScrollWindow.showWindow(AbstractWindow<ModUploadingProgressWindow>.WindowId);
			AbstractWindow<ModUploadingProgressWindow>.Instance.start_time = Time.time;
			return AbstractWindow<ModUploadingProgressWindow>.Instance.uploadProgress;
		}

		public override void OnNormalEnable()
		{
			base.OnNormalEnable();
			progress = 0f;
			fileId = 0uL;
			percent.color = UnityEngine.Color.white;
			uploadProgress.Reset();
		}

		public override void OnNormalDisable()
		{
			base.OnNormalDisable();
			uploading = false;
		}

		private void UpdateDisplay()
		{
			bar.transform.localScale = new Vector3(progress, 1f, 1f);
			percent.text = $"{(int)(progress * 100f)}%";
		}

		public static void FinishUpload()
		{
			AbstractWindow<ModUploadingProgressWindow>.Instance.uploading = false;
			AbstractWindow<ModUploadingProgressWindow>.Instance.progress = 1f;
			AbstractWindow<ModUploadingProgressWindow>.Instance.UpdateDisplay();
			AbstractWindow<ModUploadingProgressWindow>.Instance.percent.text = LM.Get("ModUploadFinish");
			AbstractWindow<ModUploadingProgressWindow>.Instance.percent.color = UnityEngine.Color.green;
			if (AbstractWindow<ModUploadingProgressWindow>.Instance.fileId != 0)
			{
				Application.OpenURL("steam://url/CommunityFilePage/" + AbstractWindow<ModUploadingProgressWindow>.Instance.fileId);
			}
		}

		public static void ErrorUpload(Exception obj)
		{
			AbstractWindow<ModUploadingProgressWindow>.Instance.uploading = false;
			AbstractWindow<ModUploadingProgressWindow>.Instance.percent.text = LM.Get("NML_" + obj.Message);
			AbstractWindow<ModUploadingProgressWindow>.Instance.percent.color = UnityEngine.Color.red;
		}
	}
	internal class ModUploadWindow : AbstractWindow<ModUploadWindow>
	{
		private Text changelog_text;

		private Text mod_author_text;

		private Text mod_description_text;

		private Text mod_fileid_text;

		private UnityEngine.UI.Image mod_icon_image;

		private Text mod_name_text;

		private Text mod_version_text;

		private IMod selected_mod;

		public static void ShowWindow(IMod mod)
		{
			AbstractWindow<ModUploadWindow>.Instance.selected_mod = mod;
			ModDeclare declaration = mod.GetDeclaration();
			if (string.IsNullOrEmpty(declaration.IconPath))
			{
				AbstractWindow<ModUploadWindow>.Instance.mod_icon_image.sprite = InternalResourcesGetter.GetIcon();
			}
			else
			{
				AbstractWindow<ModUploadWindow>.Instance.mod_icon_image.sprite = SpriteLoadUtils.LoadSingleSprite(Path.Combine(declaration.FolderPath, declaration.IconPath));
			}
			AbstractWindow<ModUploadWindow>.Instance.mod_name_text.text = declaration.Name;
			AbstractWindow<ModUploadWindow>.Instance.mod_author_text.text = declaration.Author;
			AbstractWindow<ModUploadWindow>.Instance.mod_version_text.text = declaration.Version;
			AbstractWindow<ModUploadWindow>.Instance.mod_description_text.text = declaration.Description;
			ScrollWindow.showWindow(AbstractWindow<ModUploadWindow>.WindowId);
		}

		protected override void Init()
		{
			base.ContentTransform.gameObject.AddComponent<ContentSizeFitter>().verticalFit = ContentSizeFitter.FitMode.PreferredSize;
			VerticalLayoutGroup verticalLayoutGroup = base.ContentTransform.gameObject.AddComponent<VerticalLayoutGroup>();
			verticalLayoutGroup.childAlignment = TextAnchor.UpperCenter;
			verticalLayoutGroup.childControlHeight = false;
			verticalLayoutGroup.childControlWidth = false;
			verticalLayoutGroup.childForceExpandHeight = false;
			verticalLayoutGroup.childForceExpandWidth = false;
			verticalLayoutGroup.childScaleHeight = false;
			verticalLayoutGroup.childScaleWidth = false;
			verticalLayoutGroup.spacing = 10f;
			verticalLayoutGroup.padding = new RectOffset(0, 0, 5, 0);
			GameObject gameObject = new GameObject("TopBar", typeof(RectTransform));
			gameObject.transform.SetParent(base.ContentTransform);
			gameObject.transform.localScale = Vector3.one;
			gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(190f, 17f);
			GameObject gameObject2 = new GameObject("DescIcon", typeof(UnityEngine.UI.Image));
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.transform.localPosition = new Vector3(-90f, 0f);
			gameObject2.transform.localScale = Vector3.one;
			gameObject2.GetComponent<RectTransform>().sizeDelta = new Vector2(15f, 15f);
			gameObject2.GetComponent<UnityEngine.UI.Image>().sprite = InternalResourcesGetter.GetIcon();
			GameObject gameObject3 = new GameObject("Input FileId", typeof(UnityEngine.UI.Image));
			gameObject3.transform.SetParent(gameObject.transform);
			gameObject3.transform.localScale = Vector3.one;
			gameObject3.transform.localPosition = new Vector3(5f, 0f);
			UnityEngine.UI.Image component = gameObject3.GetComponent<UnityEngine.UI.Image>();
			component.sprite = SpriteTextureLoader.getSprite("ui/special/darkInputFieldEmpty");
			component.type = UnityEngine.UI.Image.Type.Sliced;
			GameObject gameObject4 = new GameObject("InputField", typeof(Text), typeof(InputField));
			gameObject4.transform.SetParent(gameObject3.transform);
			gameObject4.transform.localPosition = Vector3.zero;
			gameObject4.transform.localScale = Vector3.one;
			Text component2 = gameObject4.GetComponent<Text>();
			gameObject4.GetComponent<InputField>().textComponent = component2;
			component2.text = "";
			mod_fileid_text = component2;
			OT.InitializeCommonText(component2);
			component2.alignment = TextAnchor.MiddleLeft;
			component2.resizeTextForBestFit = true;
			component2.resizeTextMinSize = 6;
			GameObject gameObject5 = new GameObject("Image", typeof(UnityEngine.UI.Image));
			gameObject5.transform.SetParent(gameObject3.transform);
			gameObject5.transform.localPosition = new Vector3(77f, 0f);
			gameObject5.transform.localScale = Vector3.one;
			gameObject5.GetComponent<UnityEngine.UI.Image>().sprite = SpriteTextureLoader.getSprite("ui/special/inputFieldIcon");
			gameObject5.GetComponent<RectTransform>().sizeDelta = new Vector2(15f, 15f);
			NameInput nameInput = gameObject3.AddComponent<NameInput>();
			nameInput.inputField = gameObject4.GetComponent<InputField>();
			nameInput.textField = component2;
			nameInput.addListener(delegate
			{
			});
			RectTransform component3 = gameObject4.GetComponent<RectTransform>();
			component3.sizeDelta = new Vector2(170f, 15f);
			gameObject3.GetComponent<RectTransform>().sizeDelta = component3.sizeDelta + new Vector2(2f, 2f);
			GameObject gameObject6 = new GameObject("ModInfo", typeof(UnityEngine.UI.Image));
			gameObject6.transform.SetParent(base.ContentTransform);
			gameObject6.transform.localPosition = new Vector3(130f, -78f, 0f);
			gameObject6.transform.localScale = Vector3.one;
			gameObject6.GetComponent<UnityEngine.UI.Image>().sprite = SpriteTextureLoader.getSprite("ui/special/windowInnerSliced");
			gameObject6.GetComponent<UnityEngine.UI.Image>().type = UnityEngine.UI.Image.Type.Sliced;
			gameObject6.GetComponent<RectTransform>().sizeDelta = new Vector2(190f, 95f);
			GameObject gameObject7 = new GameObject("ModIcon", typeof(UnityEngine.UI.Image));
			gameObject7.transform.SetParent(gameObject6.transform);
			gameObject7.transform.localScale = Vector3.one;
			gameObject7.transform.localPosition = new Vector3(-48f, 0f);
			gameObject7.GetComponent<RectTransform>().sizeDelta = new Vector2(90f, 90f);
			mod_icon_image = gameObject7.GetComponent<UnityEngine.UI.Image>();
			GameObject gameObject8 = new GameObject("ModIconFrame", typeof(UnityEngine.UI.Image));
			gameObject8.transform.SetParent(gameObject7.transform);
			gameObject8.GetComponent<UnityEngine.UI.Image>().sprite = InternalResourcesGetter.GetIconFrame();
			gameObject8.GetComponent<UnityEngine.UI.Image>().type = UnityEngine.UI.Image.Type.Sliced;
			gameObject8.GetComponent<RectTransform>().sizeDelta = gameObject7.GetComponent<RectTransform>().sizeDelta;
			GameObject info_grids = new GameObject("InfoGrids", typeof(GridLayoutGroup));
			info_grids.transform.SetParent(gameObject6.transform);
			info_grids.transform.localScale = Vector3.one;
			info_grids.transform.localPosition = new Vector3(48f, 0f);
			info_grids.GetComponent<RectTransform>().sizeDelta = new Vector2(92f, 92f);
			GridLayoutGroup component4 = info_grids.GetComponent<GridLayoutGroup>();
			component4.childAlignment = TextAnchor.UpperCenter;
			component4.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
			component4.constraintCount = 1;
			component4.spacing = new Vector2(0f, 1f);
			component4.cellSize = new Vector2(92f, 15f);
			mod_name_text = create_grid_text("Mod Name");
			mod_author_text = create_grid_text("Mod Author");
			mod_version_text = create_grid_text("Mod Version");
			mod_description_text = create_grid_text("Mod Description");
			GameObject gameObject9 = new GameObject("Input ChangeLog", typeof(UnityEngine.UI.Image));
			gameObject9.transform.SetParent(base.ContentTransform);
			gameObject9.transform.localScale = Vector3.one;
			gameObject9.transform.localPosition = new Vector3(130f, -170f);
			UnityEngine.UI.Image component5 = gameObject9.GetComponent<UnityEngine.UI.Image>();
			component5.sprite = SpriteTextureLoader.getSprite("ui/special/darkInputFieldEmpty");
			component5.type = UnityEngine.UI.Image.Type.Sliced;
			GameObject gameObject10 = new GameObject("InputField", typeof(Text), typeof(InputField));
			gameObject10.transform.SetParent(gameObject9.transform);
			gameObject10.transform.localScale = Vector3.one;
			gameObject10.transform.localPosition = Vector3.zero;
			Text component6 = gameObject10.GetComponent<Text>();
			gameObject10.GetComponent<InputField>().textComponent = component6;
			component6.text = "#CHANGELOG";
			changelog_text = component6;
			OT.InitializeCommonText(component6);
			component6.alignment = TextAnchor.UpperLeft;
			component6.resizeTextForBestFit = true;
			component6.resizeTextMinSize = 6;
			component6.resizeTextMaxSize = 10;
			gameObject10.GetComponent<InputField>().lineType = InputField.LineType.MultiLineNewline;
			NameInput nameInput2 = gameObject9.AddComponent<NameInput>();
			nameInput2.inputField = gameObject10.GetComponent<InputField>();
			nameInput2.textField = component6;
			nameInput2.addListener(delegate
			{
			});
			RectTransform component7 = gameObject10.GetComponent<RectTransform>();
			component7.sizeDelta = new Vector2(190f, 80f);
			gameObject9.GetComponent<RectTransform>().sizeDelta = component7.sizeDelta + new Vector2(2f, 2f);
			GameObject gameObject11 = new GameObject("UploadButton", typeof(UnityEngine.UI.Image), typeof(Button));
			gameObject11.transform.SetParent(base.ContentTransform);
			gameObject11.transform.localPosition = new Vector3(130f, -260f);
			gameObject11.transform.localScale = Vector3.one;
			gameObject11.GetComponent<RectTransform>().sizeDelta = new Vector2(190f, 30f);
			UnityEngine.UI.Image component8 = gameObject11.GetComponent<UnityEngine.UI.Image>();
			component8.sprite = SpriteTextureLoader.getSprite("ui/special/special_buttonred");
			component8.type = UnityEngine.UI.Image.Type.Sliced;
			GameObject gameObject12 = new GameObject("Desc1", typeof(UnityEngine.UI.Image));
			gameObject12.transform.SetParent(gameObject11.transform);
			gameObject12.transform.localPosition = new Vector3(-80f, 0f);
			gameObject12.transform.localScale = Vector3.one;
			gameObject12.GetComponent<RectTransform>().sizeDelta = new Vector2(30f, 30f);
			gameObject12.GetComponent<UnityEngine.UI.Image>().sprite = SpriteTextureLoader.getSprite("ui/icons/iconSaveCloud");
			GameObject gameObject13 = new GameObject("Desc2", typeof(UnityEngine.UI.Image));
			gameObject13.transform.SetParent(gameObject11.transform);
			gameObject13.transform.localPosition = new Vector3(80f, 0f);
			gameObject13.transform.localScale = Vector3.one;
			gameObject13.GetComponent<RectTransform>().sizeDelta = new Vector2(30f, 30f);
			gameObject13.GetComponent<UnityEngine.UI.Image>().sprite = SpriteTextureLoader.getSprite("ui/icons/iconSteam");
			GameObject gameObject14 = new GameObject("Text", typeof(Text), typeof(LocalizedText));
			gameObject14.transform.SetParent(gameObject11.transform);
			gameObject14.transform.localPosition = Vector3.zero;
			gameObject14.transform.localScale = Vector3.one;
			gameObject14.GetComponent<RectTransform>().sizeDelta = new Vector2(190f, 30f);
			Text component9 = gameObject14.GetComponent<Text>();
			OT.InitializeCommonText(component9);
			component9.alignment = TextAnchor.MiddleCenter;
			LocalizedText component10 = gameObject14.GetComponent<LocalizedText>();
			component10.key = "ModUpload Title";
			gameObject11.GetComponent<Button>().onClick.AddListener(uploadSelectedMod);
			LocalizedTextManager.addTextField(component10);
			Text create_grid_text(string name)
			{
				Text component11 = new GameObject(name, typeof(Text)).GetComponent<Text>();
				Transform transform;
				(transform = component11.transform).SetParent(info_grids.transform);
				transform.localScale = Vector3.one;
				OT.InitializeCommonText(component11);
				component11.resizeTextForBestFit = true;
				component11.resizeTextMaxSize = 10;
				component11.resizeTextMinSize = 6;
				component11.text = name;
				component11.alignment = TextAnchor.MiddleLeft;
				return component11;
			}
		}

		private void uploadSelectedMod()
		{
			string text = mod_fileid_text.text;
			if (text.Any((char c) => !char.IsDigit(c)))
			{
				text = null;
			}
			if (string.IsNullOrEmpty(text))
			{
				ModUploadAuthenticationService.Authenticate().Then(() => ModWorkshopService.UploadMod(selected_mod, changelog_text.text, ModUploadAuthenticationService.Authed)).Then((Action)ModUploadingProgressWindow.FinishUpload, (Action<Exception>)ModUploadingProgressWindow.ErrorUpload);
			}
			else
			{
				ulong fileID = ulong.Parse(text);
				ModWorkshopService.TryEditMod(fileID, selected_mod, changelog_text.text).Then((Action)ModUploadingProgressWindow.FinishUpload, (Action<Exception>)ModUploadingProgressWindow.ErrorUpload).Done();
			}
		}
	}
	internal class NewModListWindow : AbstractWideWindow<NewModListWindow>
	{
		private enum DisplayType
		{
			Mod,
			Resource
		}

		private readonly Dictionary<ModDeclare, ModInfoPanel> ModInfoPanels = new Dictionary<ModDeclare, ModInfoPanel>();

		private DisplayType CurrentDisplayType;

		private ModDeclare CurrentSelected;

		private ObjectPoolGenericMono<ModListItem> ListItemPool;

		private RectTransform ListPart;

		private List<ModDeclare> ListToShow;

		private SimpleButton ModCommunityButton;

		private SimpleButton ModConfigureButton;

		private RectTransform ModInfoPart;

		private SimpleButton OpenModFolderButton;

		private SimpleButton ReloadModButton;

		private SimpleButton ToggleModButton;

		private SimpleButton UploadModButton;

		protected override void Init()
		{
			GameObject gameObject = new GameObject("TypeSelectPart", typeof(UnityEngine.UI.Image), typeof(VerticalLayoutGroup));
			gameObject.transform.SetParent(base.BackgroundTransform);
			gameObject.transform.localPosition = new Vector3(-260f, 0f);
			gameObject.transform.localScale = Vector3.one;
			gameObject.GetComponent<UnityEngine.UI.Image>().sprite = InternalResourcesGetter.GetWindowEmptyFrame();
			gameObject.GetComponent<UnityEngine.UI.Image>().type = UnityEngine.UI.Image.Type.Sliced;
			gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(48f, 255f);
			OT.InitializeNoActionVerticalLayoutGroup(gameObject.GetComponent<VerticalLayoutGroup>());
			gameObject.GetComponent<VerticalLayoutGroup>().padding = new RectOffset(0, 0, 12, 0);
			SimpleButton simpleButton = UnityEngine.Object.Instantiate(APrefab<SimpleButton>.Prefab, gameObject.transform);
			simpleButton.name = "TypeMod";
			simpleButton.Setup(ShowMods, InternalResourcesGetter.GetIcon(), null, new Vector2(32f, 32f), "normal", new TooltipData
			{
				tip_name = "TypeMod Title"
			});
			simpleButton.Background.enabled = false;
			SimpleButton simpleButton2 = UnityEngine.Object.Instantiate(APrefab<SimpleButton>.Prefab, gameObject.transform);
			simpleButton2.name = "TypeResource";
			simpleButton2.Setup(ShowResources, SpriteTextureLoader.getSprite("ui/icons/tech/icon_tech_city_storage_3"), null, new Vector2(32f, 32f), "normal", new TooltipData
			{
				tip_name = "TypeResource Title"
			});
			simpleButton2.Background.enabled = false;
			GameObject gameObject2 = base.BackgroundTransform.Find("Scroll View").gameObject;
			gameObject2.name = "List Scroll View";
			RectTransform component = gameObject2.GetComponent<RectTransform>();
			component.sizeDelta = new Vector2(108f, 255f);
			component.localPosition = new Vector3(-174f, 0f, 0f);
			component.localScale = Vector3.one;
			ScrollRect component2 = gameObject2.GetComponent<ScrollRect>();
			component2.verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.Permanent;
			component2.verticalScrollbar.GetComponent<RectTransform>().sizeDelta = new Vector2(10f, 0f);
			UnityEngine.UI.Image component3 = gameObject2.GetComponent<UnityEngine.UI.Image>();
			component3.sprite = SpriteTextureLoader.getSprite("ui/special/windowEmptyFrame");
			component3.type = UnityEngine.UI.Image.Type.Sliced;
			component3.color = UnityEngine.Color.white;
			RectTransform component4 = gameObject2.transform.Find("Viewport").GetComponent<RectTransform>();
			component4.sizeDelta = new Vector2(0f, -20f);
			component4.localPosition -= new Vector3(0f, 10f);
			VerticalLayoutGroup pVerticalLayoutGroup = base.ContentTransform.gameObject.AddComponent<VerticalLayoutGroup>();
			OT.InitializeNoActionVerticalLayoutGroup(pVerticalLayoutGroup);
			ContentSizeFitter contentSizeFitter = base.ContentTransform.gameObject.AddComponent<ContentSizeFitter>();
			contentSizeFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
			base.BackgroundTransform.Find("Scrollgradient").GetComponent<UnityEngine.UI.Image>().enabled = false;
			ListPart = base.ContentTransform as RectTransform;
			ListItemPool = new ObjectPoolGenericMono<ModListItem>(APrefab<ModListItem>.Prefab, ListPart);
			GameObject gameObject3 = new GameObject("ModInfoPart", typeof(UnityEngine.UI.Image), typeof(VerticalLayoutGroup));
			gameObject3.transform.SetParent(base.BackgroundTransform);
			gameObject3.transform.localPosition = new Vector3(60f, 25f);
			gameObject3.transform.localScale = Vector3.one;
			gameObject3.GetComponent<UnityEngine.UI.Image>().sprite = SpriteTextureLoader.getSprite("ui/special/windowInnerSliced");
			gameObject3.GetComponent<UnityEngine.UI.Image>().type = UnityEngine.UI.Image.Type.Sliced;
			ModInfoPart = gameObject3.GetComponent<RectTransform>();
			GameObject gameObject4 = new GameObject("ModControlPart", typeof(UnityEngine.UI.Image), typeof(HorizontalLayoutGroup));
			gameObject4.transform.SetParent(base.BackgroundTransform);
			gameObject4.transform.localPosition = new Vector3(60f, -102f);
			gameObject4.transform.localScale = Vector3.one;
			gameObject4.GetComponent<UnityEngine.UI.Image>().sprite = InternalResourcesGetter.GetWindowEmptyFrame();
			gameObject4.GetComponent<UnityEngine.UI.Image>().type = UnityEngine.UI.Image.Type.Sliced;
			GameObject gameObject5 = new GameObject("NMLGeneralPart", typeof(UnityEngine.UI.Image), typeof(VerticalLayoutGroup));
			gameObject5.transform.SetParent(base.BackgroundTransform);
			gameObject5.transform.localPosition = new Vector3(264f, 0f);
			gameObject5.transform.localScale = Vector3.one;
			gameObject5.GetComponent<UnityEngine.UI.Image>().sprite = InternalResourcesGetter.GetWindowEmptyFrame();
			gameObject5.GetComponent<UnityEngine.UI.Image>().type = UnityEngine.UI.Image.Type.Sliced;
			component = gameObject4.GetComponent<RectTransform>();
			component.sizeDelta = new Vector2(350f, 48f);
			HorizontalLayoutGroup component5 = gameObject4.GetComponent<HorizontalLayoutGroup>();
			component5.childAlignment = TextAnchor.MiddleLeft;
			component5.childControlHeight = false;
			component5.childControlWidth = false;
			component5.childForceExpandHeight = false;
			component5.childForceExpandWidth = false;
			component5.childScaleHeight = false;
			component5.childScaleWidth = false;
			component5.spacing = 4f;
			component5.padding = new RectOffset(12, 0, 0, 0);
			ModConfigureButton = UnityEngine.Object.Instantiate(APrefab<SimpleButton>.Prefab, component);
			ModConfigureButton.name = "ModConfigureButton";
			ModConfigureButton.Setup(ConfigureSelectedMod, SpriteTextureLoader.getSprite("ui/icons/iconOptions"), null, new Vector2(32f, 32f), "normal", new TooltipData
			{
				tip_name = "ModConfigure Title"
			});
			ModConfigureButton.Background.enabled = false;
			ModCommunityButton = UnityEngine.Object.Instantiate(APrefab<SimpleButton>.Prefab, component);
			ModCommunityButton.name = "ModCommunityButton";
			ModCommunityButton.Setup(CommunityOfSelectedMod, SpriteTextureLoader.getSprite("ui/icons/iconCommunity"), null, new Vector2(32f, 32f), "normal", new TooltipData
			{
				tip_name = "ModCommunity Title"
			});
			ModCommunityButton.Background.enabled = false;
			OpenModFolderButton = UnityEngine.Object.Instantiate(APrefab<SimpleButton>.Prefab, component);
			OpenModFolderButton.name = "OpenModFolderButton";
			OpenModFolderButton.Setup(FolderOfSelectedMod, SpriteTextureLoader.getSprite("ui/icons/iconCustomWorld"), null, new Vector2(32f, 32f), "normal", new TooltipData
			{
				tip_name = "OpenFolder Title"
			});
			OpenModFolderButton.Background.enabled = false;
			ToggleModButton = UnityEngine.Object.Instantiate(APrefab<SimpleButton>.Prefab, component);
			ToggleModButton.name = "ToggleModButton";
			ToggleModButton.Setup(ToggleSelectedMod, SpriteTextureLoader.getSprite("ui/icons/iconOn"), null, new Vector2(32f, 32f), "normal", new TooltipData
			{
				tip_name = "ToggleMod Title"
			});
			ToggleModButton.Background.enabled = false;
			ReloadModButton = UnityEngine.Object.Instantiate(APrefab<SimpleButton>.Prefab, component);
			ReloadModButton.name = "ReloadModButton";
			ReloadModButton.Setup(ReloadSelectedMod, InternalResourcesGetter.GetReloadIcon(), null, new Vector2(32f, 32f), "normal", new TooltipData
			{
				tip_name = "ReloadMod Title"
			});
			ReloadModButton.Background.enabled = false;
			UploadModButton = UnityEngine.Object.Instantiate(APrefab<SimpleButton>.Prefab, component);
			UploadModButton.name = "UploadModButton";
			UploadModButton.Setup(UploadSelectedMod, SpriteTextureLoader.getSprite("ui/icons/iconSaveCloud"), null, new Vector2(32f, 32f), "normal", new TooltipData
			{
				tip_name = "UploadMod Title"
			});
			UploadModButton.Background.enabled = false;
			component = gameObject3.GetComponent<RectTransform>();
			component.sizeDelta = new Vector2(350f, 200f);
			component = gameObject5.GetComponent<RectTransform>();
			component.sizeDelta = new Vector2(48f, 255f);
		}

		private void ShowResources()
		{
			Clean();
		}

		private void ShowMods()
		{
			Clean();
			ListToShow = WorldBoxMod.AllRecognizedMods.Keys.ToList();
			foreach (ModDeclare item in ListToShow)
			{
				ModListItem next = ListItemPool.getNext();
				ModDeclare local_mod = item;
				next.Setup(item, delegate
				{
					Select(local_mod);
				});
			}
		}

		public override void OnFirstEnable()
		{
			CurrentDisplayType = DisplayType.Mod;
		}

		public override void OnNormalEnable()
		{
			switch (CurrentDisplayType)
			{
			case DisplayType.Mod:
				ShowMods();
				break;
			case DisplayType.Resource:
				ShowResources();
				break;
			}
		}

		private void Clean()
		{
			ListItemPool.clear();
		}

		private void Select(ModDeclare pDeclare)
		{
			if (CurrentSelected != pDeclare)
			{
				CurrentSelected = pDeclare;
				RefreshInfoPart();
				RefreshControlPart();
			}
		}

		private void RefreshControlPart()
		{
			throw new NotImplementedException();
		}

		private void RefreshInfoPart()
		{
			foreach (ModInfoPanel value in ModInfoPanels.Values)
			{
				value.gameObject.SetActive(value: false);
			}
			if (ModInfoPanels.ContainsKey(CurrentSelected))
			{
				ModInfoPanels[CurrentSelected].gameObject.SetActive(value: true);
				return;
			}
			ModInfoPanel modInfoPanel = UnityEngine.Object.Instantiate(APrefab<ModInfoPanel>.Prefab, ModInfoPart);
			modInfoPanel.Setup(CurrentSelected);
			ModInfoPanels.Add(CurrentSelected, modInfoPanel);
		}

		private void CommunityOfSelectedMod()
		{
			throw new NotImplementedException();
		}

		private void ConfigureSelectedMod()
		{
			throw new NotImplementedException();
		}

		private void UploadSelectedMod()
		{
			throw new NotImplementedException();
		}

		private void ReloadSelectedMod()
		{
			throw new NotImplementedException();
		}

		private void ToggleSelectedMod()
		{
			throw new NotImplementedException();
		}

		private void FolderOfSelectedMod()
		{
			throw new NotImplementedException();
		}
	}
	internal static class UIManager
	{
		public static void init()
		{
			SingleAutoLayoutWindow<InformationWindow>.CreateWindow("Information", "Information Title");
			AbstractListWindow<ModListWindow, IMod>.CreateAndInit("NeoModList");
			AbstractListWindow<WorkshopModListWindow, ModDeclare>.CreateAndInit("WorkshopMods");
			AbstractWindow<ModUploadWindow>.CreateAndInit("ModUpload");
			AbstractWindow<ModUploadingProgressWindow>.CreateAndInit("ModUploadingProgress");
			AbstractWindow<ModUploadAuthenticationWindow>.CreateAndInit("ModUploadAuthentication");
			AbstractWindow<ModConfigureWindow>.CreateAndInit("ModConfigure");
			PowerButtonCreator.AddButtonToTab(PowerButtonCreator.CreateWindowButton("NML_ModsList", "NeoModList", InternalResourcesGetter.GetIcon()), PowerButtonCreator.GetTab("main"), 22);
		}
	}
	internal class WorkshopModListWindow : AbstractListWindow<WorkshopModListWindow, ModDeclare>
	{
		public class WorkshopModListItem : AbstractListWindowItem<ModDeclare>
		{
			public override void Setup(ModDeclare modDeclare)
			{
				Text component = base.transform.Find("Text").GetComponent<Text>();
				component.text = modDeclare.Name + "\t" + modDeclare.Version + "\n" + modDeclare.Author + "\n" + modDeclare.Description;
				Sprite sprite = null;
				if (!string.IsNullOrEmpty(modDeclare.IconPath))
				{
					sprite = SpriteLoadUtils.LoadSingleSprite(Path.Combine(modDeclare.FolderPath, modDeclare.IconPath));
				}
				if (sprite == null)
				{
					sprite = InternalResourcesGetter.GetIcon();
				}
				UnityEngine.UI.Image component2 = base.transform.Find("Icon").GetComponent<UnityEngine.UI.Image>();
				component2.sprite = sprite;
				Button component3 = base.transform.Find("Load").GetComponent<Button>();
				component3.onClick.AddListener(delegate
				{
					if (ModCompileLoadService.IsModLoaded(modDeclare.UID))
					{
						ErrorWindow.errorMessage = "Failed to load mod " + modDeclare.Name + ":\nMod already loaded.";
						ScrollWindow.get("error_with_reason").clickShow();
					}
					else
					{
						ModCompileLoadService.TryCompileAndLoadModAtRuntime(modDeclare);
					}
				});
				Button component4 = base.transform.Find("Website").GetComponent<Button>();
				component4.onClick.AddListener(delegate
				{
					string fileName = Path.GetFileName(modDeclare.FolderPath);
					Application.OpenURL("https://steamcommunity.com/sharedfiles/filedetails/?id=" + fileName);
				});
			}
		}

		private float checkTimer = 0.015f;

		private HashSet<string> showedMods = new HashSet<string>();

		private void Update()
		{
			if (checkTimer > 0f)
			{
				checkTimer -= Time.deltaTime;
				return;
			}
			checkTimer = 0.015f;
			showNextMod();
		}

		protected override void Init()
		{
		}

		public override void OnNormalEnable()
		{
			ModWorkshopService.steamWorkshopPromise.Then((Action)ModWorkshopService.FindSubscribedMods).Catch(delegate(Exception err)
			{
				UnityEngine.Debug.LogError(err);
				ErrorWindow.errorMessage = "Error happened while connecting to Steam Workshop:\n" + err.Message.ToString();
				ScrollWindow.get("error_with_reason").clickShow();
			});
		}

		private void showNextMod()
		{
			ModDeclare nextModFromWorkshopItem = ModWorkshopService.GetNextModFromWorkshopItem();
			if (nextModFromWorkshopItem != null)
			{
				AddItemToList(nextModFromWorkshopItem);
			}
		}

		protected override void AddItemToList(ModDeclare item)
		{
			if (!showedMods.Contains(item.UID))
			{
				showedMods.Add(item.UID);
				base.AddItemToList(item);
			}
		}

		protected override AbstractListWindowItem<ModDeclare> CreateItemPrefab()
		{
			GameObject gameObject = new GameObject("WorkshopModListItemPrefab", typeof(UnityEngine.UI.Image), typeof(WorkshopModListItem));
			gameObject.SetActive(value: false);
			gameObject.transform.SetParent(WorldBoxMod.Transform);
			gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(0f, 50f);
			UnityEngine.UI.Image component = gameObject.GetComponent<UnityEngine.UI.Image>();
			component.sprite = Resources.Load<Sprite>("ui/special/windowInnerSliced");
			component.type = UnityEngine.UI.Image.Type.Sliced;
			GameObject gameObject2 = new GameObject("Icon", typeof(UnityEngine.UI.Image));
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.transform.localPosition = new Vector3(-75f, 0f);
			gameObject2.transform.localScale = Vector3.one;
			gameObject2.GetComponent<RectTransform>().sizeDelta = new Vector2(40f, 40f);
			UnityEngine.UI.Image component2 = gameObject2.GetComponent<UnityEngine.UI.Image>();
			component2.sprite = InternalResourcesGetter.GetIcon();
			GameObject gameObject3 = new GameObject("IconFrame", typeof(UnityEngine.UI.Image));
			gameObject3.transform.SetParent(gameObject2.transform);
			gameObject3.transform.localPosition = Vector3.zero;
			gameObject3.transform.localScale = Vector3.one;
			gameObject3.GetComponent<RectTransform>().sizeDelta = gameObject2.GetComponent<RectTransform>().sizeDelta + new Vector2(5f, 5f);
			UnityEngine.UI.Image component3 = gameObject3.GetComponent<UnityEngine.UI.Image>();
			component3.sprite = InternalResourcesGetter.GetIconFrame();
			component3.type = UnityEngine.UI.Image.Type.Sliced;
			GameObject gameObject4 = new GameObject("Text", typeof(Text));
			gameObject4.transform.SetParent(gameObject.transform);
			gameObject4.transform.localPosition = new Vector3(12.5f, 0f);
			gameObject4.transform.localScale = Vector3.one;
			gameObject4.GetComponent<RectTransform>().sizeDelta = new Vector2(125f, 50f);
			Text component4 = gameObject4.GetComponent<Text>();
			component4.font = LocalizedTextManager.current_font;
			component4.fontSize = 6;
			component4.supportRichText = true;
			Vector2 vector = new Vector2(22f, 22f);
			GameObject gameObject5 = new GameObject("Load", typeof(UnityEngine.UI.Image), typeof(Button));
			gameObject5.transform.SetParent(gameObject.transform);
			gameObject5.transform.localPosition = new Vector3(87f, 12f);
			gameObject5.transform.localScale = Vector3.one;
			gameObject5.GetComponent<RectTransform>().sizeDelta = vector;
			UnityEngine.UI.Image component5 = gameObject5.GetComponent<UnityEngine.UI.Image>();
			component5.sprite = Resources.Load<Sprite>("ui/special/button2");
			component5.type = UnityEngine.UI.Image.Type.Sliced;
			GameObject gameObject6 = new GameObject("Icon", typeof(UnityEngine.UI.Image));
			gameObject6.transform.SetParent(gameObject5.transform);
			gameObject6.transform.localPosition = Vector3.zero;
			gameObject6.transform.localScale = Vector3.one;
			gameObject6.GetComponent<RectTransform>().sizeDelta = vector * 0.875f;
			UnityEngine.UI.Image component6 = gameObject6.GetComponent<UnityEngine.UI.Image>();
			component6.sprite = Resources.Load<Sprite>("ui/icons/iconGameServices");
			GameObject gameObject7 = new GameObject("Website", typeof(UnityEngine.UI.Image), typeof(Button));
			gameObject7.transform.SetParent(gameObject.transform);
			gameObject7.transform.localPosition = new Vector3(87f, -12f);
			gameObject7.transform.localScale = Vector3.one;
			gameObject7.GetComponent<RectTransform>().sizeDelta = vector;
			UnityEngine.UI.Image component7 = gameObject7.GetComponent<UnityEngine.UI.Image>();
			component7.sprite = Resources.Load<Sprite>("ui/special/button2");
			component7.type = UnityEngine.UI.Image.Type.Sliced;
			GameObject gameObject8 = new GameObject("Icon", typeof(UnityEngine.UI.Image));
			gameObject8.transform.SetParent(gameObject7.transform);
			gameObject8.transform.localPosition = Vector3.zero;
			gameObject8.transform.localScale = Vector3.one;
			gameObject8.GetComponent<RectTransform>().sizeDelta = vector * 0.875f;
			UnityEngine.UI.Image component8 = gameObject8.GetComponent<UnityEngine.UI.Image>();
			component8.sprite = Resources.Load<Sprite>("ui/icons/iconCommunity");
			return gameObject.GetComponent<WorkshopModListItem>();
		}
	}
}
namespace NeoModLoader.ui.prefabs
{
	public class ModInfoPanel : APrefab<ModInfoPanel>
	{
		internal void Setup(ModDeclare pModDeclaration)
		{
			ModState modState = WorldBoxMod.AllRecognizedMods[pModDeclaration];
			if (modState == ModState.LOADED)
			{
				IMod mod = WorldBoxMod.LoadedMods.Find((IMod x) => x.GetDeclaration() == pModDeclaration);
				if (mod is IDecoratePanel decoratePanel)
				{
					decoratePanel.DecoratePanel(this);
				}
			}
		}

		private static void _init()
		{
			GameObject gameObject = new GameObject("ModInfoPanel", typeof(RectTransform));
			APrefab<ModInfoPanel>.Prefab = gameObject.AddComponent<ModInfoPanel>();
		}
	}
	internal class ModListItem : APrefab<ModListItem>
	{
		private UnityEngine.UI.Image icon;

		private Text text;

		protected override void Init()
		{
			if (!Initialized)
			{
				base.Init();
				icon = base.transform.Find("ModIcon").GetComponent<UnityEngine.UI.Image>();
				text = base.transform.Find("SimpleInfo").GetComponent<Text>();
			}
		}

		public void Setup(ModDeclare pDeclare, Action pAction)
		{
			Init();
			if (!string.IsNullOrEmpty(pDeclare.IconPath))
			{
				icon.sprite = SpriteLoadUtils.LoadSingleSprite(Path.Combine(pDeclare.FolderPath, pDeclare.IconPath));
			}
			if (icon.sprite == null)
			{
				icon.sprite = InternalResourcesGetter.GetIcon();
			}
			base.name = pDeclare.Name;
			string text = pDeclare.Name;
			string text2 = pDeclare.Author;
			string text3 = text + "_" + LocalizedTextManager.instance.language;
			string text4 = text2 + "_" + LocalizedTextManager.instance.language;
			if (LocalizedTextManager.stringExists(text3))
			{
				text = LM.Get(text3);
			}
			if (LocalizedTextManager.stringExists(text4))
			{
				text2 = LM.Get(text4);
			}
			this.text.text = text + "\n" + text2;
		}

		private static void _init()
		{
			GameObject gameObject = new GameObject("ModListItem", typeof(UnityEngine.UI.Image));
			gameObject.GetComponent<UnityEngine.UI.Image>().sprite = SpriteTextureLoader.getSprite("ui/special/windowInnerSliced");
			gameObject.GetComponent<UnityEngine.UI.Image>().type = UnityEngine.UI.Image.Type.Sliced;
			gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(88f, 40f);
			GameObject gameObject2 = new GameObject("ModIcon", typeof(UnityEngine.UI.Image));
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.transform.localPosition = new Vector3(-24.5f, 0f, 0f);
			gameObject2.transform.localScale = Vector3.one;
			gameObject2.GetComponent<UnityEngine.UI.Image>().sprite = InternalResourcesGetter.GetIcon();
			gameObject2.GetComponent<RectTransform>().sizeDelta = new Vector2(28f, 28f);
			GameObject gameObject3 = new GameObject("IconFrame", typeof(UnityEngine.UI.Image));
			gameObject3.transform.SetParent(gameObject2.transform);
			gameObject3.transform.localPosition = Vector3.zero;
			gameObject3.transform.localScale = Vector3.one;
			gameObject3.GetComponent<UnityEngine.UI.Image>().sprite = InternalResourcesGetter.GetIconFrame();
			gameObject3.GetComponent<RectTransform>().sizeDelta = new Vector2(36f, 36f);
			GameObject gameObject4 = new GameObject("ModName", typeof(Text));
			gameObject4.transform.SetParent(gameObject.transform);
			gameObject4.transform.localPosition = new Vector3(20f, 0f, 0f);
			gameObject4.transform.localScale = Vector3.one;
			gameObject4.GetComponent<RectTransform>().sizeDelta = new Vector2(48f, 34f);
			Text component = gameObject4.GetComponent<Text>();
			component.text = "Mod Name\nMod Author";
			component.alignment = TextAnchor.UpperLeft;
			component.font = LocalizedTextManager.current_font;
			component.fontSize = 6;
			component.supportRichText = true;
			APrefab<ModListItem>.Prefab = gameObject.AddComponent<ModListItem>();
		}
	}
}
namespace NeoModLoader.services
{
	internal static class ExternalModInstallService
	{
		public static async void CheckExternalModInstall()
		{
			List<string> args = new List<string>(Environment.GetCommandLineArgs());
			args.RemoveAt(0);
			foreach (string arg in args)
			{
				LogService.LogInfo(arg);
			}
			Type[] types = WorldBoxMod.NeoModLoaderAssembly.GetTypes();
			List<ACmdModInstaller> cmd_installers = (from type in types
				where type.IsSubclassOf(typeof(ACmdModInstaller)) && !type.IsAbstract
				select (ACmdModInstaller)Activator.CreateInstance(type)).ToList();
			foreach (ACmdModInstaller installer in cmd_installers)
			{
				for (int i = 0; i < args.Count; i++)
				{
					if (await installer.CheckInstall(args[i]))
					{
						args.RemoveAt(i--);
					}
				}
			}
		}
	}
	internal interface IPlatformSpecificModWorkshopService
	{
		void UploadModLoader(string changelog);

		Promise UploadMod(string name, string description, string previewImagePath, string workshopPath, string changelog, bool verified);

		Promise EditMod(ulong fileID, string previewImagePath, string workshopPath, string changelog);

		void FindSubscribedMods();

		ModDeclare GetNextModFromWorkshopItem();
	}
	public static class LogService
	{
		private enum LogType
		{
			Info,
			Warning,
			Error
		}

		private class WrappedMessage
		{
			public string message;

			public LogType type;

			public WrappedMessage(string message, LogType type)
			{
				this.message = message;
				this.type = type;
			}

			public void Reset(string message, LogType type)
			{
				this.message = message;
				this.type = type;
			}
		}

		private class ConcurrentLogHandle : MonoBehaviour
		{
			private void Update()
			{
				int num = 0;
				WrappedMessage result;
				while (num <= 32 && concurrent_log_queue.TryDequeue(out result))
				{
					num++;
					switch (result.type)
					{
					case LogType.Info:
						LogInfo(result.message);
						break;
					case LogType.Warning:
						LogWarning(result.message);
						break;
					case LogType.Error:
						LogError(result.message);
						break;
					default:
						throw new ArgumentOutOfRangeException();
					}
					if (_pool.Count < 100)
					{
						_pool.Add(result);
					}
				}
			}
		}

		private static readonly ConcurrentQueue<WrappedMessage> concurrent_log_queue = new ConcurrentQueue<WrappedMessage>();

		private static ConcurrentBag<WrappedMessage> _pool = new ConcurrentBag<WrappedMessage>();

		private const int pool_size = 100;

		public static void PullAllConcurrentLogToCurrentThread()
		{
			WrappedMessage result;
			while (concurrent_log_queue.TryDequeue(out result))
			{
				switch (result.type)
				{
				case LogType.Info:
					LogInfo(result.message);
					break;
				case LogType.Warning:
					LogWarning(result.message);
					break;
				case LogType.Error:
					LogError(result.message);
					break;
				default:
					throw new ArgumentOutOfRangeException();
				}
				if (_pool.Count < 100)
				{
					_pool.Add(result);
				}
			}
		}

		internal static void Init()
		{
			WorldBoxMod.Transform.gameObject.AddComponent<ConcurrentLogHandle>();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LogInfoConcurrent(string message)
		{
			if (_pool.TryTake(out var result))
			{
				result.Reset(message, LogType.Info);
			}
			else
			{
				result = new WrappedMessage(message, LogType.Info);
			}
			concurrent_log_queue.Enqueue(result);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LogWarningConcurrent(string message)
		{
			if (_pool.TryTake(out var result))
			{
				result.Reset(message, LogType.Warning);
			}
			else
			{
				result = new WrappedMessage(message, LogType.Warning);
			}
			concurrent_log_queue.Enqueue(result);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LogErrorConcurrent(string message)
		{
			if (_pool.TryTake(out var result))
			{
				result.Reset(message, LogType.Error);
			}
			else
			{
				result = new WrappedMessage(message, LogType.Error);
			}
			concurrent_log_queue.Enqueue(result);
		}

		public static void LogException(Exception exception)
		{
			if (Others.unity_player_enabled)
			{
				UnityEngine.Debug.LogException(exception);
			}
			else
			{
				Console.WriteLine(exception);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LogError(string message)
		{
			if (Others.unity_player_enabled)
			{
				UnityEngine.Debug.LogError("[NML]: " + message);
			}
			else
			{
				Console.Error.WriteLine("[NML]: " + message);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LogWarning(string message)
		{
			if (Others.unity_player_enabled)
			{
				UnityEngine.Debug.LogWarning("[NML]: " + message);
			}
			else
			{
				Console.WriteLine("[NML]: " + message);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LogInfo(string message)
		{
			if (Others.unity_player_enabled)
			{
				UnityEngine.Debug.Log("[NML]: " + message);
			}
			else
			{
				Console.WriteLine("[NML]: " + message);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LogStackTraceAsInfo()
		{
			LogInfo(OtherUtils.GetStackTrace(2));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LogStackTraceAsWarning()
		{
			LogWarning(OtherUtils.GetStackTrace(2));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LogStackTraceAsError()
		{
			LogError(OtherUtils.GetStackTrace(2));
		}
	}
	public static class ModCompileLoadService
	{
		private static string[] _default_ref_path = null;

		private static readonly Dictionary<string, string> mod_inc_path = new Dictionary<string, string>();

		private static readonly HashSet<string> _loaded_ref = new HashSet<string>();

		private static MetadataReference[] _default_ref = null;

		private static MetadataReference _publicized_assembly_ref = null;

		private static readonly Dictionary<string, MetadataReference> mod_ref = new Dictionary<string, MetadataReference>();

		private static bool compileMod(ModDeclare pModDecl, IEnumerable<MetadataReference> pDefaultInc, string[] pAddInc, Dictionary<string, MetadataReference> pModInc, bool pForce = false, bool pDisableOptionalDepen = false)
		{
			List<string> list = (pDisableOptionalDepen ? new List<string>() : pModDecl.OptionalDependencies.Where(pModInc.ContainsKey).ToList());
			List<string> list2 = pModDecl.Dependencies.Where(pModInc.ContainsKey).ToList();
			if (!pForce && !ModInfoUtils.doesModNeedRecompile(pModDecl, list2, list))
			{
				LoadAddInc();
				return true;
			}
			List<string> list3 = new List<string>();
			List<MetadataReference> list4 = pDefaultInc.ToList();
			list4.AddRange(pAddInc.Select((string inc) => MetadataReference.CreateFromFile(inc)));
			LoadAddInc();
			if (pModDecl.UsePublicizedAssembly)
			{
				list4.Add(_publicized_assembly_ref);
			}
			foreach (string item3 in list2)
			{
				list4.Add(pModInc[item3]);
				if (pModInc[item3] != null)
				{
					continue;
				}
				LogService.LogError(pModDecl.UID + "'s optional ref of " + item3 + " instance is null");
				return false;
			}
			foreach (string item4 in list)
			{
				list4.Add(pModInc[item4]);
				list3.Add(ModDependencyUtils.ParseDepenNameToPreprocessSymbol(item4));
				if (pModInc[item4] != null)
				{
					continue;
				}
				LogService.LogError(pModDecl.UID + "'s optional ref of " + item4 + " instance is null");
				return false;
			}
			List<SyntaxTree> list5 = new List<SyntaxTree>();
			List<string> list6 = SystemUtils.SearchFileRecursive(pModDecl.FolderPath, (string file_name) => file_name.EndsWith(".cs") && !file_name.StartsWith("."), (string dir_name) => !dir_name.StartsWith(".") && !Paths.IgnoreSearchDirectories.Contains(dir_name));
			List<ResourceDescription> list7 = new List<ResourceDescription>();
			bool flag = false;
			CSharpParseOptions options = new CSharpParseOptions(LanguageVersion.Latest, DocumentationMode.Parse, SourceCodeKind.Regular, list3);
			foreach (string item5 in list6)
			{
				SourceText text = SourceText.From(File.ReadAllText(item5), Encoding.UTF8);
				SyntaxTree syntaxTree = CSharpSyntaxTree.ParseText(text, options, item5.Substring(pModDecl.FolderPath.Length + 1));
				list5.Add(syntaxTree);
				if (!flag)
				{
					flag = NCMSCompatibleLayer.IsNCMSMod(syntaxTree);
				}
			}
			if (flag)
			{
				string text2 = Path.Combine(pModDecl.FolderPath, Paths.NCMSModEmbededResourceFolderName);
				if (Directory.Exists(text2))
				{
					string[] files = Directory.GetFiles(text2, "*", SearchOption.AllDirectories);
					string[] array = files;
					foreach (string file in array)
					{
						string text3 = file.Substring(text2.Length + 1);
						string resourceName = pModDecl.Name + ".Resources." + text3.Replace('\\', '.').Replace('/', '.');
						ResourceDescription item = new ResourceDescription(resourceName, () => File.OpenRead(file), isPublic: true);
						list7.Add(item);
					}
				}
				SourceText text4 = SourceText.From("\r\n    using System;\r\n    using System.IO;\r\n    using System.Reflection;\r\n    using UnityEngine;\r\n    using UnityEngine.Events;\r\n    using UnityEngine.UI;\r\n    using NeoModLoader.services;\r\n    using System.Collections.Generic;\r\n\r\n\r\n    internal class Mod\r\n    {\r\n        public static ModDeclaration.Info Info;\r\n        public static GameObject GameObject;\r\n        public static Action OnDebug;\r\n\r\n        private static int debugClicked = 0;\r\n\r\n        public static void Initialize(Button button)\r\n        {\r\n            OnDebug += new Action(() => { LogService.LogInfo($\"Debug toggled for mod {Info.Name}\"); });\r\n\r\n            button.onClick.AddListener(new UnityAction(() =>\r\n            {\r\n                if (debugClicked < 10)\r\n                {\r\n                    debugClicked++;\r\n                    return;\r\n                }\r\n\r\n                OnDebug();\r\n            }));\r\n        }\r\n\r\n        public class EmbededResources\r\n        {\r\n            private static Assembly this_assembly = Assembly.GetExecutingAssembly();\r\n\r\n            public static Sprite LoadSprite(string name, float pivotX = 0, float pivotY = 0, float pixelsPerUnit = 1f)\r\n            {\r\n                string hash = $\"{name}-{pivotX}-{pivotY}-{pixelsPerUnit}\";\r\n                if (sprite_cache.TryGetValue(hash, out var sprite))\r\n                    return sprite;\r\n                Texture2D texture2D = new Texture2D(0, 0);\r\n                texture2D.LoadImage(GetBytes(name));\r\n                texture2D.anisoLevel = 0;\r\n                texture2D.filterMode = FilterMode.Point;\r\n                sprite = Sprite.Create(texture2D, new Rect(0.0f, 0.0f, (float)texture2D.width, (float)texture2D.height),\r\n                    new Vector2(pivotX, pivotY), pixelsPerUnit);\r\n                sprite_cache.Add(hash, sprite);\r\n                return sprite;\r\n            }\r\n\r\n            private static Dictionary<string, Sprite> sprite_cache = new();\r\n\r\n            public static byte[] GetBytes(string name)\r\n            {\r\n                return ReadFully(this_assembly.GetManifestResourceStream(name));\r\n            }\r\n\r\n            internal static byte[] ReadFully(Stream input)\r\n            {\r\n                using var ms = new MemoryStream();\r\n                input.CopyTo(ms);\r\n                return ms.ToArray();\r\n            }\r\n        }\r\n    }", Encoding.UTF8);
				SyntaxTree item2 = CSharpSyntaxTree.ParseText(text4, options, pModDecl.Name + ".GlobalObject.cs");
				list5.Add(item2);
			}
			pModDecl.IsNCMSMod = flag;
			AssemblyIdentity assemblyIdentity = new AssemblyIdentity(pModDecl.UID, pModDecl.ParseVersion());
			string assemblyName = pModDecl.UID ?? "";
			AssemblyIdentityComparer assemblyIdentityComparer = AssemblyIdentityComparer.Default;
			CSharpCompilation cSharpCompilation = CSharpCompilation.Create(assemblyName, list5, list4, new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary, reportSuppressedDiagnostics: false, null, null, null, null, OptimizationLevel.Debug, checkOverflow: false, allowUnsafe: true, null, null, default(ImmutableArray<byte>), null, Microsoft.CodeAnalysis.Platform.AnyCpu, ReportDiagnostic.Default, 4, null, concurrentBuild: true, deterministic: true, null, null, null, assemblyIdentityComparer));
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using MemoryStream memoryStream2 = new MemoryStream();
				string path = Path.Combine(Paths.CompiledModsPath, pModDecl.UID + ".dll");
				string text5 = Path.Combine(Paths.CompiledModsPath, pModDecl.UID + ".pdb");
				EmitResult emitResult = cSharpCompilation.Emit(memoryStream, memoryStream2, null, null, list7, new EmitOptions(metadataOnly: false, DebugInformationFormat.PortablePdb, text5, null, 0, 0uL));
				if (!emitResult.Success)
				{
					StringBuilder stringBuilder = new StringBuilder();
					ImmutableArray<Diagnostic>.Enumerator enumerator4 = emitResult.Diagnostics.GetEnumerator();
					while (enumerator4.MoveNext())
					{
						Diagnostic current4 = enumerator4.Current;
						if (current4.Severity == DiagnosticSeverity.Error)
						{
							stringBuilder.AppendLine(current4.ToString());
						}
					}
					LogService.LogError(stringBuilder.ToString());
					return false;
				}
				using FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
				memoryStream.Seek(0L, SeekOrigin.Begin);
				memoryStream.WriteTo(stream);
				using FileStream stream2 = new FileStream(text5, FileMode.Create, FileAccess.Write);
				memoryStream2.Seek(0L, SeekOrigin.Begin);
				memoryStream2.WriteTo(stream2);
				ModInfoUtils.RecordMod(pModDecl, list2, list, pDisabled: false, pSave: false);
				return true;
			}
			void LoadAddInc()
			{
				string[] array2 = pAddInc;
				foreach (string text6 in array2)
				{
					string fileName = Path.GetFileName(text6);
					if (!(fileName == "Assembly-CSharp.dll") && !_loaded_ref.Contains(fileName))
					{
						_loaded_ref.Add(fileName);
						try
						{
							Assembly assembly = Assembly.LoadFrom(text6);
							LogService.LogInfo("Load " + assembly.FullName);
						}
						catch (Exception ex)
						{
							LogService.LogWarning("Failed to load Assembly " + fileName + " for mod " + pModDecl.UID);
							LogService.LogWarning(ex.Message);
							LogService.LogWarning(ex.StackTrace);
						}
					}
				}
			}
		}

		public static void prepareCompile(List<ModDependencyNode> pModNodes)
		{
			foreach (ModDependencyNode pModNode in pModNodes)
			{
				mod_inc_path.Add(pModNode.mod_decl.UID, Path.Combine(Paths.CompiledModsPath, pModNode.mod_decl.UID + ".dll"));
			}
			List<string> list = new List<string>();
			list.AddRange(Directory.GetFiles(Paths.ManagedPath, "*.dll"));
			list.AddRange(Directory.GetFiles(Paths.NMLAssembliesPath, "*.dll"));
			list.Add(Paths.NMLModPath);
			_default_ref_path = list.ToArray();
			_default_ref = new MetadataReference[_default_ref_path.Length];
			for (int i = 0; i < _default_ref_path.Length; i++)
			{
				try
				{
					_default_ref[i] = MetadataReference.CreateFromFile(_default_ref_path[i]);
					if (_default_ref[i] == null)
					{
						throw new Exception("Ref created is null");
					}
				}
				catch (Exception ex)
				{
					LogService.LogError("Error when load default reference " + _default_ref_path[i] + ": " + ex.Message);
				}
			}
			_publicized_assembly_ref = MetadataReference.CreateFromFile(Paths.PublicizedAssemblyPath);
		}

		public static void prepareCompileRuntime(ModDependencyNode pModNode)
		{
			mod_inc_path.Add(pModNode.mod_decl.UID, Path.Combine(Paths.CompiledModsPath, pModNode.mod_decl.UID + ".dll"));
		}

		public static bool compileMod(ModDependencyNode pModNode, bool pForce = false)
		{
			if (Directory.GetFiles(pModNode.mod_decl.FolderPath).Any((string file) => file.EndsWith(".dll")))
			{
				LogService.LogInfo(pModNode.mod_decl.UID + " detected as precompiled, compilation phase will be skipped on it!");
				pModNode.mod_decl.SetModType(ModTypeEnum.COMPILED_NEOMOD);
				return true;
			}
			bool flag = false;
			bool flag2 = false;
			while (true)
			{
				flag = compileMod(pModNode.mod_decl, _default_ref, pModNode.GetAdditionReferences(!flag2).ToArray(), mod_ref, pForce, flag2);
				if (flag)
				{
					mod_ref[pModNode.mod_decl.UID] = MetadataReference.CreateFromFile(Path.Combine(Paths.CompiledModsPath, pModNode.mod_decl.UID + ".dll"));
					break;
				}
				if (flag2 || pModNode.mod_decl.OptionalDependencies.Length == 0)
				{
					break;
				}
				LogService.LogWarning("Cannot compile mod " + pModNode.mod_decl.UID + " with Optional Dependencies, try to disable them");
				flag2 = true;
			}
			if (!flag)
			{
				mod_inc_path.Remove(pModNode.mod_decl.UID);
				pModNode.mod_decl.FailReason.AppendLine("Compile Failed\n Check Log for details\n All mods compiled before it will be recompiled next time");
				File.WriteAllText(Paths.ModCompileRecordPath, "");
			}
			return flag;
		}

		public static void loadMods(List<ModDeclare> mods_to_load)
		{
			foreach (ModDeclare item in mods_to_load)
			{
				try
				{
					LoadMod(item);
				}
				catch (ReflectionTypeLoadException exception)
				{
					LogService.LogError("Compiled mod " + item.UID + " out of date, if it happens again after restarting game, please update, delete or unsubscribe it");
					LogService.LogException(exception);
					string path = Path.Combine(Paths.CompiledModsPath, item.UID + ".dll");
					string path2 = Path.Combine(Paths.CompiledModsPath, item.UID + ".pdb");
					try
					{
						if (File.Exists(path))
						{
							File.Delete(path);
						}
						if (File.Exists(path2))
						{
							File.Delete(path2);
						}
					}
					catch (Exception)
					{
					}
					ModInfoUtils.clearModCompileTimestamp(item.UID);
				}
			}
		}

		public static void LoadMod(ModDeclare pMod)
		{
			Assembly[] array;
			switch (pMod.ModType)
			{
			case ModTypeEnum.NEOMOD:
				array = new Assembly[1] { Assembly.Load(File.ReadAllBytes(Path.Combine(Paths.CompiledModsPath, pMod.UID + ".dll")), File.ReadAllBytes(Path.Combine(Paths.CompiledModsPath, pMod.UID + ".pdb"))) };
				break;
			case ModTypeEnum.COMPILED_NEOMOD:
			{
				string[] files = Directory.GetFiles(pMod.FolderPath, "*.dll");
				List<string> list = Directory.GetFiles(pMod.FolderPath, "*.pdb").ToList();
				array = new Assembly[files.Length];
				for (int i = 0; i < files.Length; i++)
				{
					string text = Path.GetFileName(files[i]).Replace(".dll", "");
					int num = list.IndexOf(Path.Combine(pMod.FolderPath, text + ".pdb"));
					if (num != -1)
					{
						array[i] = Assembly.Load(File.ReadAllBytes(files[i]), File.ReadAllBytes(list[num]));
						list.RemoveAt(num);
					}
					else
					{
						array[i] = Assembly.Load(File.ReadAllBytes(files[i]));
					}
				}
				break;
			}
			default:
				throw new ArgumentException("Cannot load mod of type " + pMod.ModType.ToString() + " with NML!");
			}
			Assembly[] array2 = array;
			foreach (Assembly assembly in array2)
			{
				Type[] types = assembly.GetTypes();
				foreach (Type type in types)
				{
					Attribute customAttribute = Attribute.GetCustomAttribute(type, typeof(ModEntry));
					if (!type.IsSubclassOf(typeof(MonoBehaviour)) || (type.GetInterface("IMod") == null && customAttribute == null) || type.IsAbstract)
					{
						continue;
					}
					GameObject gameObject = new GameObject(pMod.Name);
					gameObject.transform.parent = GameObject.Find("Services/ModLoader").transform;
					GameObject gameObject2 = gameObject;
					gameObject2.SetActive(value: false);
					if (customAttribute != null)
					{
						pMod.IsNCMSMod = true;
						Type type2 = assembly.GetType("Mod");
						type2.GetField("Info")?.SetValue(null, new Info(NCMSCompatibleLayer.GenerateNCMSMod(pMod)));
						type2.GetField("GameObject")?.SetValue(null, gameObject2);
					}
					IMod mod = null;
					try
					{
						MonoBehaviour monoBehaviour = null;
						if (type.GetInterface("IMod") == null)
						{
							mod = gameObject2.AddComponent<AttachedModComponent>();
							monoBehaviour = (MonoBehaviour)gameObject2.AddComponent(type);
						}
						else
						{
							mod = (IMod)gameObject2.AddComponent(type);
							monoBehaviour = (MonoBehaviour)mod;
						}
						auto_localize(monoBehaviour);
						mod.OnLoad(pMod, gameObject2);
						gameObject2.SetActive(value: true);
					}
					catch (Exception ex)
					{
						LogService.LogError(ex.Message);
						if (ex.StackTrace != null)
						{
							LogService.LogError(ex.StackTrace);
						}
						gameObject2.SetActive(value: false);
						LogService.LogError(pMod.Name + " has been disabled due to an error. Please check the log for details.");
						continue;
					}
					WorldBoxMod.LoadedMods.Add(gameObject2.GetComponent<IMod>());
					WorldBoxMod.AllRecognizedMods[pMod] = ModState.LOADED;
					break;
				}
				if (WorldBoxMod.AllRecognizedMods[pMod] != ModState.LOADED)
				{
					pMod.FailReason.AppendLine("No Valid Mod Component Found");
					ModInfoUtils.clearModCompileTimestamp(pMod.UID);
				}
			}
			void auto_localize(object mod_component)
			{
				if (mod_component is ILocalizable localizable)
				{
					string localeFilesDirectory = localizable.GetLocaleFilesDirectory(pMod);
					if (Directory.Exists(localeFilesDirectory))
					{
						string[] files2 = Directory.GetFiles(localeFilesDirectory, "*", SearchOption.AllDirectories);
						char pSep = ',';
						if (mod_component is ICsvSepCustomized csvSepCustomized)
						{
							pSep = csvSepCustomized.GetCsvSeparator();
						}
						string[] array3 = files2;
						foreach (string text2 in array3)
						{
							try
							{
								if (text2.EndsWith(".json"))
								{
									LM.LoadLocale(Path.GetFileNameWithoutExtension(text2), text2);
								}
								else if (text2.EndsWith(".csv"))
								{
									LM.LoadLocales(text2, pSep);
								}
							}
							catch (FormatException ex2)
							{
								LogService.LogWarning(ex2.Message);
							}
						}
						LM.ApplyLocale(pUpdateTexts: false);
					}
				}
			}
		}

		public static bool TryInitMod(IMod mod)
		{
			if (mod is IStagedLoad stagedLoad)
			{
				try
				{
					stagedLoad.Init();
				}
				catch (Exception ex)
				{
					LogService.LogError(ex.Message);
					if (ex.StackTrace != null)
					{
						LogService.LogError(ex.StackTrace);
					}
					mod.GetGameObject().SetActive(value: false);
					LogService.LogError(mod.GetDeclaration().Name + " has been disabled due to an init error. Please check the log for details.");
					return false;
				}
				return true;
			}
			return false;
		}

		public static void PostInitMod(IMod mod)
		{
			if (!(mod is IStagedLoad stagedLoad))
			{
				return;
			}
			try
			{
				stagedLoad.PostInit();
			}
			catch (Exception ex)
			{
				LogService.LogError(ex.Message);
				if (ex.StackTrace != null)
				{
					LogService.LogError(ex.StackTrace);
				}
				mod.GetGameObject().SetActive(value: false);
				LogService.LogError(mod.GetDeclaration().Name + " has been disabled due to a post init error. Please check the log for details.");
			}
		}

		public static bool IsModLoaded(string uid)
		{
			foreach (IMod loadedMod in WorldBoxMod.LoadedMods)
			{
				if (loadedMod.GetDeclaration().UID == uid)
				{
					return true;
				}
			}
			return false;
		}

		public static bool TryCompileModAtRuntime(ModDeclare pModDeclare, bool pForce = false)
		{
			if (pModDeclare.ModType == ModTypeEnum.BEPINEX)
			{
				ModInfoUtils.LinkBepInExModToLocalRequest(pModDeclare);
				ModInfoUtils.DealWithBepInExModLinkRequests();
				return false;
			}
			ModDependencyNode modDependencyNode = ModDepenSolveService.SolveModDependencyRuntime(pModDeclare);
			if (modDependencyNode == null)
			{
				ErrorWindow.errorMessage = "Failed to load mod " + pModDeclare.Name + ":\nFailed to solve mod dependency.Check Incompatible mods and dependencies, then try again.";
				ScrollWindow.get("error_with_reason").clickShow();
				return false;
			}
			if (!compileMod(modDependencyNode, pForce))
			{
				ErrorWindow.errorMessage = "Failed to load mod " + pModDeclare.Name + ":\nFailed to compile mod.Check Incompatible mods and dependencies, then try again.";
				ScrollWindow.get("error_with_reason").clickShow();
				return false;
			}
			ModInfoUtils.SaveModRecords();
			return true;
		}

		public static bool TryCompileAndLoadModAtRuntime(ModDeclare mod_declare)
		{
			if (IsModLoaded(mod_declare.UID))
			{
				return false;
			}
			if (!TryCompileModAtRuntime(mod_declare))
			{
				return false;
			}
			MasterBuilder masterBuilder = new MasterBuilder();
			NeoModLoader.utils.ResourcesPatch.LoadResourceFromFolder(Path.Combine(mod_declare.FolderPath, Paths.ModResourceFolderName), out var Builders);
			NeoModLoader.utils.ResourcesPatch.LoadResourceFromFolder(Path.Combine(mod_declare.FolderPath, Paths.NCMSAdditionModResourceFolderName), out var Builders2);
			LoadMod(mod_declare);
			masterBuilder.AddBuilders(Builders);
			masterBuilder.AddBuilders(Builders2);
			masterBuilder.BuildAll();
			return true;
		}

		public static void loadInfoOfBepInExPlugins()
		{
			List<ModDeclare> list = ModInfoUtils.recogBepInExMods();
			GameObject gameObject = GameObject.Find("BepInEx_Manager");
			foreach (ModDeclare mod in list)
			{
				if (IsModLoaded(mod.UID))
				{
					LogService.LogWarning("Repeat Mod with " + mod.UID + ", Only load one of them");
					continue;
				}
				BepinexMod bepinexMod = new BepinexMod();
				MonoBehaviour pModComponent = null;
				if (gameObject != null)
				{
					MonoBehaviour[] components = gameObject.GetComponents<MonoBehaviour>();
					using IEnumerator<MonoBehaviour> enumerator2 = components.Where((MonoBehaviour component) => (component.GetType().FullName ?? "").Contains(mod.Name)).GetEnumerator();
					if (enumerator2.MoveNext())
					{
						MonoBehaviour current = enumerator2.Current;
						pModComponent = current;
					}
				}
				bepinexMod.OnLoad(mod, pModComponent);
				WorldBoxMod.LoadedMods.Add(bepinexMod);
				WorldBoxMod.AllRecognizedMods[mod] = ModState.LOADED;
			}
		}
	}
	internal static class ModDepenSolveService
	{
		private static ModDependencyGraph graph;

		public static List<ModDependencyNode> SolveModDependencies(List<ModDeclare> mods)
		{
			graph = new ModDependencyGraph(mods);
			mods.Clear();
			ModDependencyUtils.RemoveCircleDependencies(graph);
			ModDependencyUtils.RemoveModsWithoutRequiredDependencies(graph);
			return ModDependencyUtils.SortModsCompileOrderFromDependencyTopology(graph);
		}

		public static ModDependencyNode SolveModDependencyRuntime(ModDeclare mod)
		{
			return ModDependencyUtils.TryToAppendMod(graph, mod);
		}
	}
	internal static class ModReloadService
	{
		public static bool HotfixMethods(IReloadable pMod, ModDeclare pModDeclare)
		{
			if (!ModReloadUtils.Prepare(pMod, pModDeclare))
			{
				return false;
			}
			if (!ModReloadUtils.CompileNew())
			{
				return false;
			}
			if (!ModReloadUtils.PatchHotfixMethodsNT())
			{
				return false;
			}
			return true;
		}

		public static bool ReloadResources(IMod pMod)
		{
			MasterBuilder masterBuilder = new MasterBuilder();
			NeoModLoader.utils.ResourcesPatch.LoadResourceFromFolder(Path.Combine(pMod.GetDeclaration().FolderPath, Paths.ModResourceFolderName), out var Builders);
			NeoModLoader.utils.ResourcesPatch.LoadResourceFromFolder(Path.Combine(pMod.GetDeclaration().FolderPath, Paths.NCMSAdditionModResourceFolderName), out var Builders2);
			masterBuilder.AddBuilders(Builders);
			masterBuilder.AddBuilders(Builders2);
			masterBuilder.BuildAll();
			return false;
		}

		public static void ReloadLocales(IMod pMod)
		{
			if (!(pMod is ILocalizable localizable))
			{
				return;
			}
			string localeFilesDirectory = localizable.GetLocaleFilesDirectory(pMod.GetDeclaration());
			if (Directory.Exists(localeFilesDirectory))
			{
				string[] files = Directory.GetFiles(localeFilesDirectory);
				string[] array = files;
				foreach (string text in array)
				{
					LogService.LogInfo("Reload " + text + " as " + Path.GetFileNameWithoutExtension(text));
					LM.LoadLocale(Path.GetFileNameWithoutExtension(text), text);
				}
				LM.ApplyLocale();
			}
		}
	}
	public static class ModUploadAuthenticationService
	{
		public static bool Authed { get; private set; }

		public static void AutoAuth()
		{
			new Task(delegate
			{
				int num = 0;
				foreach (Func<bool> all_auto_auth_func in ModUploadAuthenticationWindow.all_auto_auth_funcs)
				{
					try
					{
						LogService.LogInfoConcurrent($"Trying auto auth at {num}...");
						Authed = all_auto_auth_func();
						if (Authed)
						{
							LogService.LogInfoConcurrent("Auto auth success!");
							break;
						}
						LogService.LogInfoConcurrent($"Failed auto auth at {num}.");
					}
					catch (Exception ex)
					{
						LogService.LogInfoConcurrent($"Failed auto auth at {num}: {ex.Message}");
					}
					finally
					{
						num++;
					}
				}
			}).Start();
		}

		public static Promise Authenticate()
		{
			Promise promise = new Promise();
			if (Authed)
			{
				new Task(delegate
				{
					System.Threading.Thread.Sleep(500);
					promise.Resolve();
				}).Start();
				return promise;
			}
			ScrollWindow.showWindow(AbstractWindow<ModUploadAuthenticationWindow>.WindowId);
			new Task(delegate
			{
				while (true)
				{
					if (!AbstractWindow<ModUploadAuthenticationWindow>.Instance.Opened())
					{
						promise.Reject(new Exception("Canceled"));
						return;
					}
					if (AbstractWindow<ModUploadAuthenticationWindow>.Instance.AuthSkipped)
					{
						promise.Resolve();
						return;
					}
					if (AbstractWindow<ModUploadAuthenticationWindow>.Instance.AuthFuncSelected)
					{
						AbstractWindow<ModUploadAuthenticationWindow>.Instance.AuthFuncSelected = false;
						bool result;
						try
						{
							CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
							Task<bool> task = new Task<bool>(AbstractWindow<ModUploadAuthenticationWindow>.Instance.AuthFunc, cancellationTokenSource.Token);
							ModUploadAuthenticationWindow.SetText(LM.Get("nml_authentication_waiting"));
							task.Start();
							int num = 0;
							while (!task.IsCompleted)
							{
								System.Threading.Thread.Sleep(100);
								num += 100;
								if (num >= 60000)
								{
									cancellationTokenSource.Cancel();
									throw new AuthenticaticationException("Authentication timeout.");
								}
							}
							if (task.IsFaulted && task.Exception != null)
							{
								throw task.Exception;
							}
							result = task.Result;
						}
						catch (AuthenticaticationException ex)
						{
							Exception ex2 = ex;
							StringBuilder stringBuilder = new StringBuilder();
							stringBuilder.AppendLine("Exception when auth: ");
							do
							{
								stringBuilder.AppendLine($"{ex.GetType()}: {ex.Message}");
								stringBuilder.AppendLine(ex.StackTrace);
								ex2 = ex2.InnerException;
							}
							while (ex2 != null);
							LogService.LogInfoConcurrent(stringBuilder.ToString());
							ModUploadAuthenticationWindow.SetState(pAuthState: false, ex.Message);
							continue;
						}
						catch (Exception innerException)
						{
							StringBuilder stringBuilder2 = new StringBuilder();
							stringBuilder2.AppendLine("Exception when auth: ");
							do
							{
								stringBuilder2.AppendLine($"{innerException.GetType()}: {innerException.Message}");
								stringBuilder2.AppendLine(innerException.StackTrace);
								innerException = innerException.InnerException;
							}
							while (innerException != null);
							LogService.LogInfoConcurrent(stringBuilder2.ToString());
							ModUploadAuthenticationWindow.SetState(pAuthState: false, innerException.Message);
							continue;
						}
						LogService.LogInfoConcurrent($"Auth result: {result}");
						if (result)
						{
							break;
						}
						ModUploadAuthenticationWindow.SetState(pAuthState: false);
					}
				}
				Authed = true;
				ModUploadAuthenticationWindow.SetState(pAuthState: true);
				promise.Resolve();
			}).Start();
			return promise;
		}
	}
	[Experimental]
	internal static class ModWorkshopService
	{
		internal static Promise steamWorkshopPromise;

		private static IPlatformSpecificModWorkshopService workshopServiceBackend;

		public static void Init()
		{
			steamWorkshopPromise = RF.GetStaticField<Promise, SteamSDK>("steamInitialized");
			if (Application.platform == RuntimePlatform.WindowsPlayer)
			{
				workshopServiceBackend = new ModWorkshopServiceWindows();
			}
			else
			{
				workshopServiceBackend = new ModWorkshopServiceUnix();
			}
		}

		private static void UploadModLoader(string changelog)
		{
			workshopServiceBackend.UploadModLoader(changelog);
		}

		public static Promise UploadMod(IMod mod, string changelog, bool verified = false)
		{
			ModDeclare declaration = mod.GetDeclaration();
			string name = declaration.Name;
			string description = name + " Uploaded by NeoModLoader\n" + name + " 由NeoModLoader上传\n\n" + declaration.Description + "\n\nModLoader: https://github.com/WorldBoxOpenMods/ModLoader\n\n模组加载器: https://github.com/WorldBoxOpenMods/ModLoader";
			string text = Path.Combine(SaveManager.generateMainPath("workshop_upload_mod") + declaration.UID);
			if (Directory.Exists(text))
			{
				Directory.Delete(text, recursive: true);
			}
			if (!Directory.Exists(SaveManager.generateMainPath("workshop_upload_mod")))
			{
				Directory.CreateDirectory(SaveManager.generateMainPath("workshop_upload_mod"));
			}
			Directory.CreateDirectory(text);
			List<string> list = SystemUtils.SearchFileRecursive(declaration.FolderPath, (string filename) => !filename.StartsWith("."), (string dirname) => !dirname.StartsWith(".") && !Paths.IgnoreSearchDirectories.Contains(dirname));
			foreach (string item in list)
			{
				string text2 = Path.Combine(text, item.Replace(declaration.FolderPath, "").Replace("\\", "/").Substring(1));
				if (!Directory.Exists(Path.GetDirectoryName(text2)))
				{
					Directory.CreateDirectory(Path.GetDirectoryName(text2));
				}
				File.Copy(item, text2);
			}
			string previewImagePath;
			if (string.IsNullOrEmpty(declaration.IconPath))
			{
				using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("NeoModLoader.resources.logo.png");
				using FileStream destination = File.Create(Path.Combine(text, "preview.png"));
				stream.Seek(0L, SeekOrigin.Begin);
				stream.CopyTo(destination);
				previewImagePath = Path.Combine(text, "preview.png");
			}
			else
			{
				previewImagePath = Path.Combine(text, declaration.IconPath);
			}
			if (!File.Exists(Path.Combine(text, "mod.json")))
			{
				File.WriteAllText(Path.Combine(text, "mod.json"), JsonConvert.SerializeObject(declaration));
			}
			return workshopServiceBackend.UploadMod(name, description, previewImagePath, text, changelog, verified);
		}

		public static Promise TryEditMod(ulong fileID, IMod mod, string changelog)
		{
			ModDeclare declaration = mod.GetDeclaration();
			string text = Path.Combine(SaveManager.generateMainPath("workshop_upload_mod") + declaration.UID);
			if (Directory.Exists(text))
			{
				Directory.Delete(text, recursive: true);
			}
			if (!Directory.Exists(SaveManager.generateMainPath("workshop_upload_mod")))
			{
				Directory.CreateDirectory(SaveManager.generateMainPath("workshop_upload_mod"));
			}
			Directory.CreateDirectory(text);
			List<string> list = SystemUtils.SearchFileRecursive(declaration.FolderPath, (string filename) => !filename.StartsWith("."), (string dirname) => !dirname.StartsWith(".") && !Paths.IgnoreSearchDirectories.Contains(dirname));
			foreach (string item in list)
			{
				string text2 = Path.Combine(text, item.Replace(declaration.FolderPath, "").Replace("\\", "/").Substring(1));
				if (!Directory.Exists(Path.GetDirectoryName(text2)))
				{
					Directory.CreateDirectory(Path.GetDirectoryName(text2));
				}
				File.Copy(item, text2);
			}
			string previewImagePath;
			if (string.IsNullOrEmpty(declaration.IconPath))
			{
				using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("NeoModLoader.resources.logo.png");
				using FileStream destination = File.Create(Path.Combine(text, "preview.png"));
				stream.Seek(0L, SeekOrigin.Begin);
				stream.CopyTo(destination);
				previewImagePath = Path.Combine(text, "preview.png");
			}
			else
			{
				previewImagePath = Path.Combine(text, declaration.IconPath);
			}
			if (!File.Exists(Path.Combine(text, "mod.json")))
			{
				File.WriteAllText(Path.Combine(text, "mod.json"), JsonConvert.SerializeObject(declaration));
			}
			return workshopServiceBackend.EditMod(fileID, previewImagePath, text, changelog);
		}

		public static void FindSubscribedMods()
		{
			workshopServiceBackend.FindSubscribedMods();
		}

		public static ModDeclare GetNextModFromWorkshopItem()
		{
			return workshopServiceBackend.GetNextModFromWorkshopItem();
		}
	}
	internal class ModWorkshopServiceUnix : IPlatformSpecificModWorkshopService
	{
		private static List<Steamworks.Ugc.Item> subscribedItems = new List<Steamworks.Ugc.Item>();

		private static Queue<Steamworks.Ugc.Item> subscribedModsQueue = new Queue<Steamworks.Ugc.Item>();

		public void UploadModLoader(string changelog)
		{
			string text = SaveManager.generateWorkshopPath("NeoModLoader");
			string text2 = Path.Combine(text, "preview.png");
			if (Directory.Exists(text))
			{
				Directory.Delete(text, recursive: true);
			}
			Directory.CreateDirectory(text);
			File.Copy(Paths.NMLModPath, Path.Combine(text, "NeoModLoader.dll"));
			File.Copy(Paths.NMLModPath.Replace(".dll", ".pdb"), Path.Combine(text, "NeoModLoader.pdb"));
			using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("NeoModLoader.resources.logo.png");
			using FileStream fileStream = File.Create(text2);
			stream.Seek(0L, SeekOrigin.Begin);
			stream.CopyTo(fileStream);
			fileStream.Close();
			new Editor(3080294469uL).WithContent(text).WithTag("Mod Loader").WithPreviewFile(text2)
				.WithChangeLog(changelog)
				.SubmitAsync()
				.ContinueWith(delegate(Task<PublishResult> taskResult)
				{
					if (taskResult.Status != TaskStatus.RanToCompletion)
					{
						LogService.LogErrorConcurrent("!RanToCompletion");
					}
					else
					{
						PublishResult result = taskResult.Result;
						if (!result.Success)
						{
							LogService.LogErrorConcurrent("!result.Success");
						}
						if (result.NeedsWorkshopAgreement)
						{
							PublishedFileId fileId = result.FileId;
							Application.OpenURL("steam://url/CommunityFilePage/" + fileId.ToString());
						}
						if (result.Result != Result.OK)
						{
							LogService.LogErrorConcurrent(result.Result.ToString());
						}
					}
				}, TaskScheduler.Default);
		}

		public Promise UploadMod(string name, string description, string previewImagePath, string workshopPath, string changelog, bool verified)
		{
			Editor editor = Editor.NewCommunityFile.WithTag(verified ? "Mod" : "Unverified Mod").WithTitle(name).WithDescription(description)
				.WithPreviewFile(previewImagePath)
				.WithContent(workshopPath)
				.WithChangeLog(changelog);
			Promise promise = new Promise();
			ModUploadingProgressWindow.UploadProgress progress = ModUploadingProgressWindow.ShowWindow();
			editor.SubmitAsync(progress).ContinueWith(delegate(Task<PublishResult> taskResult)
			{
				if (taskResult.Status != TaskStatus.RanToCompletion)
				{
					promise.Reject(taskResult.Exception.GetBaseException());
				}
				else
				{
					PublishResult result = taskResult.Result;
					if (!result.Success)
					{
						LogService.LogError("!result.Success");
					}
					if (result.NeedsWorkshopAgreement)
					{
						PublishedFileId fileId = result.FileId;
						Application.OpenURL("steam://url/CommunityFilePage/" + fileId.ToString());
					}
					if (result.Result != Result.OK)
					{
						promise.Reject(new Exception("Something went wrong: " + result.Result));
					}
					else
					{
						AbstractWindow<ModUploadingProgressWindow>.Instance.fileId = result.FileId;
						promise.Resolve();
					}
				}
			}, TaskScheduler.Default);
			return promise;
		}

		public Promise EditMod(ulong fileID, string previewImagePath, string workshopPath, string changelog)
		{
			Promise promise = new Promise();
			new Editor(fileID).WithPreviewFile(previewImagePath).WithContent(workshopPath).WithChangeLog(changelog)
				.SubmitAsync(ModUploadingProgressWindow.ShowWindow())
				.ContinueWith(delegate(Task<PublishResult> taskResult)
				{
					if (taskResult.Status != TaskStatus.RanToCompletion)
					{
						promise.Reject(taskResult.Exception.GetBaseException());
					}
					else
					{
						PublishResult result = taskResult.Result;
						if (result.NeedsWorkshopAgreement)
						{
							LogService.LogWarning("Needs Workshop Agreement");
							PublishedFileId fileId = result.FileId;
							Application.OpenURL("steam://url/CommunityFilePage/" + fileId.ToString());
						}
						if (result.Result != Result.OK)
						{
							promise.Reject(new Exception(result.Result.ToString()));
						}
						else
						{
							promise.Resolve();
						}
					}
				}, TaskScheduler.FromCurrentSynchronizationContext());
			return promise;
		}

		public async void FindSubscribedMods()
		{
			foreach (Steamworks.Ugc.Item item in await GetSubscribedItems())
			{
				subscribedModsQueue.Enqueue(item);
			}
		}

		public ModDeclare GetNextModFromWorkshopItem()
		{
			if (subscribedModsQueue.Count == 0)
			{
				return null;
			}
			Steamworks.Ugc.Item item = subscribedModsQueue.Dequeue();
			ModDeclare modDeclare = ModInfoUtils.recogMod(item.Directory);
			if (string.IsNullOrEmpty(modDeclare.RepoUrl))
			{
				string fileName = Path.GetFileName(item.Directory);
				modDeclare.SetRepoUrlToWorkshopPage(fileName);
			}
			return modDeclare;
		}

		private static async Task<List<Steamworks.Ugc.Item>> GetSubscribedItems()
		{
			Query q = Query.ItemsReadyToUse.WhereUserSubscribed().WithTag("Mod").SortByCreationDateAsc();
			subscribedItems.Clear();
			int count = 1;
			int curr = 0;
			int page = 1;
			while (count > curr)
			{
				ResultPage? resultPage = await q.GetPageAsync(page++);
				if (!resultPage.HasValue)
				{
					break;
				}
				count = resultPage.Value.TotalCount;
				curr += resultPage.Value.ResultCount;
				foreach (Steamworks.Ugc.Item entry in resultPage.Value.Entries)
				{
					if (entry.IsInstalled && !entry.IsDownloadPending && !entry.IsDownloading)
					{
						if (!available(entry))
						{
							LogService.LogWarning("Incomplete mod " + entry.Title + " found, skip");
						}
						else
						{
							subscribedItems.Add(entry);
						}
					}
				}
			}
			return subscribedItems;
			static bool available(Steamworks.Ugc.Item item)
			{
				return true;
			}
		}
	}
	internal class ModWorkshopServiceWindows : IPlatformSpecificModWorkshopService
	{
		private static List<Steamworks.Ugc.Item> subscribedItems = new List<Steamworks.Ugc.Item>();

		private static Queue<Steamworks.Ugc.Item> subscribedModsQueue = new Queue<Steamworks.Ugc.Item>();

		public void UploadModLoader(string changelog)
		{
			string text = SaveManager.generateWorkshopPath("NeoModLoader");
			string text2 = Path.Combine(text, "preview.png");
			if (Directory.Exists(text))
			{
				Directory.Delete(text, recursive: true);
			}
			Directory.CreateDirectory(text);
			File.Copy(Paths.NMLModPath, Path.Combine(text, "NeoModLoader.dll"));
			File.Copy(Paths.NMLModPath.Replace(".dll", ".pdb"), Path.Combine(text, "NeoModLoader.pdb"));
			using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("NeoModLoader.resources.logo.png");
			using FileStream fileStream = File.Create(text2);
			stream.Seek(0L, SeekOrigin.Begin);
			stream.CopyTo(fileStream);
			fileStream.Close();
			new Editor(3080294469uL).WithContent(text).WithTag("Mod Loader").WithPreviewFile(text2)
				.WithChangeLog(changelog)
				.SubmitAsync()
				.ContinueWith(delegate(Task<PublishResult> taskResult)
				{
					if (taskResult.Status != TaskStatus.RanToCompletion)
					{
						LogService.LogErrorConcurrent("!RanToCompletion");
					}
					else
					{
						PublishResult result = taskResult.Result;
						if (!result.Success)
						{
							LogService.LogErrorConcurrent("!result.Success");
						}
						if (result.NeedsWorkshopAgreement)
						{
							PublishedFileId fileId = result.FileId;
							Application.OpenURL("steam://url/CommunityFilePage/" + fileId.ToString());
						}
						if (result.Result != Result.OK)
						{
							LogService.LogErrorConcurrent(result.Result.ToString());
						}
					}
				}, TaskScheduler.Default);
		}

		public Promise UploadMod(string name, string description, string previewImagePath, string workshopPath, string changelog, bool verified)
		{
			Editor editor = Editor.NewCommunityFile.WithTag(verified ? "Mod" : "Unverified Mod").WithTitle(name).WithDescription(description)
				.WithPreviewFile(previewImagePath)
				.WithContent(workshopPath)
				.WithChangeLog(changelog);
			Promise promise = new Promise();
			ModUploadingProgressWindow.UploadProgress progress = ModUploadingProgressWindow.ShowWindow();
			editor.SubmitAsync(progress).ContinueWith(delegate(Task<PublishResult> taskResult)
			{
				if (taskResult.Status != TaskStatus.RanToCompletion)
				{
					promise.Reject(taskResult.Exception.GetBaseException());
				}
				else
				{
					PublishResult result = taskResult.Result;
					if (!result.Success)
					{
						LogService.LogError("!result.Success");
					}
					if (result.NeedsWorkshopAgreement)
					{
						PublishedFileId fileId = result.FileId;
						Application.OpenURL("steam://url/CommunityFilePage/" + fileId.ToString());
					}
					if (result.Result != Result.OK)
					{
						promise.Reject(new Exception("Something went wrong: " + result.Result));
					}
					else
					{
						AbstractWindow<ModUploadingProgressWindow>.Instance.fileId = result.FileId;
						promise.Resolve();
					}
				}
			}, TaskScheduler.Default);
			return promise;
		}

		public Promise EditMod(ulong fileID, string previewImagePath, string workshopPath, string changelog)
		{
			Promise promise = new Promise();
			new Editor(fileID).WithPreviewFile(previewImagePath).WithContent(workshopPath).WithChangeLog(changelog)
				.SubmitAsync(ModUploadingProgressWindow.ShowWindow())
				.ContinueWith(delegate(Task<PublishResult> taskResult)
				{
					if (taskResult.Status != TaskStatus.RanToCompletion)
					{
						promise.Reject(taskResult.Exception.GetBaseException());
					}
					else
					{
						PublishResult result = taskResult.Result;
						if (result.NeedsWorkshopAgreement)
						{
							LogService.LogWarning("Needs Workshop Agreement");
							PublishedFileId fileId = result.FileId;
							Application.OpenURL("steam://url/CommunityFilePage/" + fileId.ToString());
						}
						if (result.Result != Result.OK)
						{
							promise.Reject(new Exception(result.Result.ToString()));
						}
						else
						{
							promise.Resolve();
						}
					}
				}, TaskScheduler.FromCurrentSynchronizationContext());
			return promise;
		}

		public ModDeclare GetNextModFromWorkshopItem()
		{
			if (subscribedModsQueue.Count == 0)
			{
				return null;
			}
			Steamworks.Ugc.Item item = subscribedModsQueue.Dequeue();
			ModDeclare modDeclare = ModInfoUtils.recogMod(item.Directory);
			if (string.IsNullOrEmpty(modDeclare.RepoUrl))
			{
				string fileName = Path.GetFileName(item.Directory);
				modDeclare.SetRepoUrlToWorkshopPage(fileName);
			}
			return modDeclare;
		}

		public async void FindSubscribedMods()
		{
			foreach (Steamworks.Ugc.Item item in await GetSubscribedItems())
			{
				subscribedModsQueue.Enqueue(item);
			}
		}

		private static async Task<List<Steamworks.Ugc.Item>> GetSubscribedItems()
		{
			Query q = Query.ItemsReadyToUse.WhereUserSubscribed().WithTag("Mod").SortByCreationDateAsc();
			subscribedItems.Clear();
			int count = 1;
			int curr = 0;
			int page = 1;
			while (count > curr)
			{
				ResultPage? resultPage = await q.GetPageAsync(page++);
				if (!resultPage.HasValue)
				{
					break;
				}
				count = resultPage.Value.TotalCount;
				curr += resultPage.Value.ResultCount;
				foreach (Steamworks.Ugc.Item entry in resultPage.Value.Entries)
				{
					if (entry.IsInstalled && !entry.IsDownloadPending && !entry.IsDownloading)
					{
						if (!available(entry))
						{
							LogService.LogWarning("Incomplete mod " + entry.Title + " found, skip");
						}
						else
						{
							subscribedItems.Add(entry);
						}
					}
				}
			}
			return subscribedItems;
			static bool available(Steamworks.Ugc.Item item)
			{
				return true;
			}
		}
	}
}
namespace NeoModLoader.ncms_compatible_layer
{
	internal static class NCMSCompatibleLayer
	{
		public const string modGlobalObject = "\r\n    using System;\r\n    using System.IO;\r\n    using System.Reflection;\r\n    using UnityEngine;\r\n    using UnityEngine.Events;\r\n    using UnityEngine.UI;\r\n    using NeoModLoader.services;\r\n    using System.Collections.Generic;\r\n\r\n\r\n    internal class Mod\r\n    {\r\n        public static ModDeclaration.Info Info;\r\n        public static GameObject GameObject;\r\n        public static Action OnDebug;\r\n\r\n        private static int debugClicked = 0;\r\n\r\n        public static void Initialize(Button button)\r\n        {\r\n            OnDebug += new Action(() => { LogService.LogInfo($\"Debug toggled for mod {Info.Name}\"); });\r\n\r\n            button.onClick.AddListener(new UnityAction(() =>\r\n            {\r\n                if (debugClicked < 10)\r\n                {\r\n                    debugClicked++;\r\n                    return;\r\n                }\r\n\r\n                OnDebug();\r\n            }));\r\n        }\r\n\r\n        public class EmbededResources\r\n        {\r\n            private static Assembly this_assembly = Assembly.GetExecutingAssembly();\r\n\r\n            public static Sprite LoadSprite(string name, float pivotX = 0, float pivotY = 0, float pixelsPerUnit = 1f)\r\n            {\r\n                string hash = $\"{name}-{pivotX}-{pivotY}-{pixelsPerUnit}\";\r\n                if (sprite_cache.TryGetValue(hash, out var sprite))\r\n                    return sprite;\r\n                Texture2D texture2D = new Texture2D(0, 0);\r\n                texture2D.LoadImage(GetBytes(name));\r\n                texture2D.anisoLevel = 0;\r\n                texture2D.filterMode = FilterMode.Point;\r\n                sprite = Sprite.Create(texture2D, new Rect(0.0f, 0.0f, (float)texture2D.width, (float)texture2D.height),\r\n                    new Vector2(pivotX, pivotY), pixelsPerUnit);\r\n                sprite_cache.Add(hash, sprite);\r\n                return sprite;\r\n            }\r\n\r\n            private static Dictionary<string, Sprite> sprite_cache = new();\r\n\r\n            public static byte[] GetBytes(string name)\r\n            {\r\n                return ReadFully(this_assembly.GetManifestResourceStream(name));\r\n            }\r\n\r\n            internal static byte[] ReadFully(Stream input)\r\n            {\r\n                using var ms = new MemoryStream();\r\n                input.CopyTo(ms);\r\n                return ms.ToArray();\r\n            }\r\n        }\r\n    }";

		public static void PreInit()
		{
			Windows.init();
			if (NCMS.Utils.ResourcesPatch.modsResources == null)
			{
				NCMS.Utils.ResourcesPatch.modsResources = NeoModLoader.utils.ResourcesPatch.GetAllPatchedResources();
			}
		}

		public static void Init()
		{
			if (NCMS.ModLoader.Mods == null)
			{
				NCMS.ModLoader.Mods = new List<NCMod>();
			}
			foreach (IMod loadedMod in WorldBoxMod.LoadedMods)
			{
				ModDeclare declaration = loadedMod.GetDeclaration();
				NCMS.ModLoader.Mods.Add(GenerateNCMSMod(declaration));
			}
			LogService.LogInfo("NCMS Compatible Layer has been initialized.");
		}

		public static NCMod GenerateNCMSMod(ModDeclare modDeclare)
		{
			return new NCMod
			{
				author = modDeclare.Author,
				description = modDeclare.Description,
				iconPath = modDeclare.IconPath,
				name = modDeclare.Name,
				path = modDeclare.FolderPath,
				version = modDeclare.Version,
				targetGameBuild = modDeclare.TargetGameBuild
			};
		}

		public static bool IsNCMSMod(SyntaxTree syntaxTree)
		{
			CompilationUnitSyntax compilationUnitRoot = syntaxTree.GetCompilationUnitRoot();
			foreach (SyntaxNode item in compilationUnitRoot.DescendantNodes())
			{
				if (!(item is ClassDeclarationSyntax classDeclarationSyntax) || !classDeclarationSyntax.AttributeLists.Any((AttributeListSyntax a) => a.Attributes.Any((AttributeSyntax attributeSyntax) => attributeSyntax.Name.ToString().Contains("ModEntry"))))
				{
					continue;
				}
				return true;
			}
			return false;
		}
	}
}
namespace NeoModLoader.General
{
	public static class LM
	{
		private static Dictionary<string, Dictionary<string, string>> locales = new Dictionary<string, Dictionary<string, string>>();

		private static readonly Dictionary<string, string> str2esc = new Dictionary<string, string>
		{
			{ "\\n", "\n" },
			{ "\\r", "\r" },
			{ "\\t", "\t" },
			{ "\\b", "\b" },
			{ "\\f", "\f" },
			{ "\\\"", "\"" },
			{ "\\'", "'" },
			{ "\\\\", "\\" },
			{ "\\0", "\0" }
		};

		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.AggressiveInlining)]
		public static string Get(string key)
		{
			return LocalizedTextManager.getText(key);
		}

		public static bool Has(string key, string lang = "")
		{
			Dictionary<string, string> value;
			return string.IsNullOrEmpty(lang) ? LocalizedTextManager.instance._localized_text.ContainsKey(key) : (locales.TryGetValue(lang, out value) && value.ContainsKey(key));
		}

		public static void LoadLocales(string pFilePath, char pSep = ',')
		{
			if (pFilePath.ToLower().EndsWith(".csv"))
			{
				Dictionary<string, Dictionary<string, string>> dictionary = null;
				try
				{
					dictionary = ParseCSV(File.ReadAllText(pFilePath), pSep);
				}
				catch (Exception ex)
				{
					LogService.LogWarning("Failed to load locale file at " + pFilePath + " as csv: " + ex.Message);
					return;
				}
				if (dictionary != null)
				{
					foreach (string key in dictionary.Keys)
					{
						Dictionary<string, string> dictionary2 = dictionary[key];
						foreach (string key2 in dictionary2.Keys)
						{
							Add(key, key2, dictionary2[key2]);
						}
					}
					return;
				}
				LogService.LogWarning("Failed to load locale file at " + pFilePath + " as csv");
			}
			else
			{
				LogService.LogWarning("Unsupported locale file type of path: " + pFilePath);
			}
		}

		public static void LoadLocales(Stream pStream, char pSep = ',')
		{
			string text = new StreamReader(pStream).ReadToEnd();
			Dictionary<string, Dictionary<string, string>> dictionary = null;
			try
			{
				dictionary = ParseCSV(text, pSep);
			}
			catch (Exception ex)
			{
				LogService.LogWarning("Failed to load locale text \"" + text + "\" as csv: " + ex.Message);
				return;
			}
			if (dictionary == null)
			{
				LogService.LogWarning("Failed to load locale text \"" + text + "\" as csv");
				return;
			}
			foreach (string key in dictionary.Keys)
			{
				Dictionary<string, string> dictionary2 = dictionary[key];
				foreach (string key2 in dictionary2.Keys)
				{
					Add(key, key2, dictionary2[key2]);
				}
			}
		}

		private static Dictionary<string, Dictionary<string, string>> ParseCSV(string pText, char sep)
		{
			pText = pText.Replace("\r\n", "\n");
			string[] array = pText.Split(new char[1] { '\n' });
			if (array.Length < 2)
			{
				return null;
			}
			if (string.IsNullOrEmpty(array[0].Trim()))
			{
				return null;
			}
			if (!Enumerable.Contains(array[0], sep))
			{
				return null;
			}
			string[] array2 = array[0].Split(new char[1] { sep });
			Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();
			for (int i = 1; i < array2.Length; i++)
			{
				dictionary[array2[i]] = new Dictionary<string, string>();
			}
			for (int j = 1; j < array.Length; j++)
			{
				if (string.IsNullOrEmpty(array[j].Trim()) || !Enumerable.Contains(array[j], sep))
				{
					continue;
				}
				string[] array3 = str2esc.Keys.Aggregate(array[j], (string current, string key) => current.Replace(key, str2esc[key])).Split(new char[1] { sep });
				string text = array3[0];
				if (!string.IsNullOrEmpty(text))
				{
					if (array3.Length > array2.Length)
					{
						throw new Exception($"Line {j} has more ',' than its head.");
					}
					for (int num = 1; num < array3.Length; num++)
					{
						dictionary[array2[num]][text] = array3[num];
					}
				}
			}
			return dictionary;
		}

		public static void LoadLocale(string pLanguage, Stream pStream)
		{
			string value = new StreamReader(pStream).ReadToEnd();
			Dictionary<string, string> dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(value);
			if (dictionary == null)
			{
				throw new FormatException("Failed to load locale file for stream as json");
			}
			foreach (var (key, value2) in dictionary.Select((KeyValuePair<string, string> pair) => (key: pair.Key, value: pair.Value)))
			{
				Add(pLanguage, key, value2);
			}
		}

		public static void LoadLocale(string pLanguage, string pFilePath)
		{
			if (pFilePath.ToLower().EndsWith(".json"))
			{
				Dictionary<string, string> dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(pFilePath));
				if (dictionary == null)
				{
					throw new FormatException("Failed to load locale file at " + pFilePath + " as json");
				}
				{
					foreach (var (key, value) in dictionary.Select((KeyValuePair<string, string> pair) => (key: pair.Key, value: pair.Value)))
					{
						Add(pLanguage, key, value);
					}
					return;
				}
			}
			LogService.LogWarning("Unsupported locale file type of path: " + pFilePath);
		}

		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.AggressiveInlining)]
		public static void AddToCurrentLocale(string key, string value)
		{
			LocalizedTextManager.instance._localized_text[key] = value;
			Add(LocalizedTextManager.instance.language, key, value);
		}

		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.AggressiveInlining)]
		public static void Add(string language, string key, string value)
		{
			if (!locales.ContainsKey(language))
			{
				locales[language] = new Dictionary<string, string>();
			}
			locales[language][key] = value;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public static void ApplyLocale(string language, bool pUpdateTexts = true)
		{
			if (!locales.ContainsKey(language))
			{
				locales[language] = new Dictionary<string, string>();
			}
			foreach (var (key, value) in locales[language].Select((KeyValuePair<string, string> pair) => (key: pair.Key, value: pair.Value)))
			{
				LocalizedTextManager.instance._localized_text[key] = value;
			}
			foreach (string item in locales["en"].Keys.Where((string key2) => !LocalizedTextManager.instance._localized_text.ContainsKey(key2)))
			{
				LocalizedTextManager.instance._localized_text[item] = locales["en"][item];
			}
			LocalizedTextManager.updateTexts();
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public static void ApplyLocale(bool pUpdateTexts = true)
		{
			if (!locales.ContainsKey(LocalizedTextManager.instance.language))
			{
				locales[LocalizedTextManager.instance.language] = new Dictionary<string, string>();
			}
			foreach (var (key, value) in locales[LocalizedTextManager.instance.language].Select((KeyValuePair<string, string> pair) => (key: pair.Key, value: pair.Value)))
			{
				LocalizedTextManager.instance._localized_text[key] = value;
			}
			foreach (string item in locales["en"].Keys.Where((string key2) => !LocalizedTextManager.instance._localized_text.ContainsKey(key2)))
			{
				LocalizedTextManager.instance._localized_text[item] = locales["en"][item];
			}
			if (pUpdateTexts)
			{
				LocalizedTextManager.updateTexts();
			}
		}

		[HarmonyPostfix]
		[HarmonyPatch(typeof(LocalizedTextManager), "setLanguage")]
		internal static void setLanguagePostfix(string pLanguage)
		{
			ApplyLocale(pLanguage);
		}
	}
	public static class OT
	{
		public static void InitializeCommonText(Text text)
		{
			text.font = LocalizedTextManager.current_font;
			text.supportRichText = true;
		}

		public static void InitializeNoActionVerticalLayoutGroup(VerticalLayoutGroup pVerticalLayoutGroup)
		{
			pVerticalLayoutGroup.childAlignment = TextAnchor.UpperCenter;
			pVerticalLayoutGroup.childControlHeight = false;
			pVerticalLayoutGroup.childControlWidth = false;
			pVerticalLayoutGroup.childForceExpandHeight = false;
			pVerticalLayoutGroup.childForceExpandWidth = false;
			pVerticalLayoutGroup.childScaleHeight = false;
			pVerticalLayoutGroup.childScaleWidth = false;
		}
	}
	public static class PowerButtonCreator
	{
		public static PowerButton CreateWindowButton([NotNull] string pId, [NotNull] string pWindowId, Sprite pIcon, [CanBeNull] Transform pParent = null, Vector2 pLocalPosition = default(Vector2))
		{
			PowerButton powerButton = ResourcesFinder.FindResource<PowerButton>("world_laws");
			bool activeSelf = powerButton.gameObject.activeSelf;
			if (activeSelf)
			{
				powerButton.gameObject.SetActive(value: false);
			}
			PowerButton powerButton2 = ((!(pParent == null)) ? UnityEngine.Object.Instantiate(powerButton, pParent) : UnityEngine.Object.Instantiate(powerButton));
			if (activeSelf)
			{
				powerButton.gameObject.SetActive(value: true);
			}
			powerButton2.name = pId;
			powerButton2.icon.sprite = pIcon;
			powerButton2.icon.overrideSprite = pIcon;
			powerButton2.open_window_id = pWindowId;
			powerButton2.type = PowerButtonType.Window;
			Transform transform = powerButton2.transform;
			transform.localPosition = pLocalPosition;
			transform.localScale = Vector3.one;
			powerButton2.gameObject.SetActive(value: true);
			return powerButton2;
		}

		public static PowerButton CreateSimpleButton([NotNull] string pId, UnityAction pAction, Sprite pIcon, [CanBeNull] Transform pParent = null, Vector2 pLocalPosition = default(Vector2))
		{
			PowerButton powerButton = ResourcesFinder.FindResource<PowerButton>("world_laws");
			bool activeSelf = powerButton.gameObject.activeSelf;
			if (activeSelf)
			{
				powerButton.gameObject.SetActive(value: false);
			}
			PowerButton powerButton2 = ((pParent == null) ? UnityEngine.Object.Instantiate(powerButton) : UnityEngine.Object.Instantiate(powerButton, pParent));
			if (activeSelf)
			{
				powerButton.gameObject.SetActive(value: true);
			}
			powerButton2.name = pId;
			powerButton2.icon.sprite = pIcon;
			powerButton2.icon.overrideSprite = pIcon;
			powerButton2.type = PowerButtonType.Library;
			if (pAction != null)
			{
				powerButton2.GetComponent<Button>().onClick.AddListener(pAction);
			}
			Transform transform = powerButton2.transform;
			transform.localPosition = pLocalPosition;
			transform.localScale = Vector3.one;
			powerButton2.gameObject.SetActive(value: true);
			return powerButton2;
		}

		public static PowerButton CreateGodPowerButton(string pGodPowerId, Sprite pIcon, [CanBeNull] Transform pParent = null, Vector2 pLocalPosition = default(Vector2))
		{
			PowerButton powerButton = ResourcesFinder.FindResource<PowerButton>("inspect");
			bool activeSelf = powerButton.gameObject.activeSelf;
			if (activeSelf)
			{
				powerButton.gameObject.SetActive(value: false);
			}
			PowerButton powerButton2 = ((pParent == null) ? UnityEngine.Object.Instantiate(powerButton) : UnityEngine.Object.Instantiate(powerButton, pParent));
			if (activeSelf)
			{
				powerButton.gameObject.SetActive(value: true);
			}
			powerButton2.name = pGodPowerId;
			powerButton2.icon.sprite = pIcon;
			powerButton2.icon.overrideSprite = pIcon;
			powerButton2.open_window_id = null;
			powerButton2.type = PowerButtonType.Active;
			Transform transform = powerButton2.transform;
			transform.localPosition = pLocalPosition;
			transform.localScale = Vector3.one;
			powerButton2.gameObject.SetActive(value: true);
			return powerButton2;
		}

		public static PowerButton CreateToggleButton(string pGodPowerId, Sprite pIcon, [CanBeNull] Transform pParent = null, Vector2 pLocalPosition = default(Vector2), bool pNoAutoSetToggleAction = false)
		{
			GodPower godPower = AssetManager.powers.get(pGodPowerId);
			if (godPower == null)
			{
				LogService.LogError("Cannot find GodPower with id " + pGodPowerId);
				return null;
			}
			if (godPower.toggle_action == null)
			{
				godPower.toggle_action = toggleOption;
			}
			else if (!pNoAutoSetToggleAction)
			{
				godPower.toggle_action = (PowerToggleAction)Delegate.Combine(godPower.toggle_action, new PowerToggleAction(toggleOption));
			}
			if (!PlayerConfig.dict.TryGetValue(godPower.toggle_name, out var value))
			{
				AssetManager.options_library.add(new OptionAsset
				{
					id = godPower.toggle_name,
					default_bool = false,
					type = OptionType.Bool
				});
				value = PlayerConfig.instance.data.add(new PlayerOptionData(godPower.toggle_name)
				{
					boolVal = false
				});
			}
			PowerButton powerButton = ResourcesFinder.FindResource<PowerButton>("map_kings_leaders");
			bool activeSelf = powerButton.gameObject.activeSelf;
			if (activeSelf)
			{
				powerButton.gameObject.SetActive(value: false);
			}
			PowerButton powerButton2 = ((pParent == null) ? UnityEngine.Object.Instantiate(powerButton) : UnityEngine.Object.Instantiate(powerButton, pParent));
			if (activeSelf)
			{
				powerButton.gameObject.SetActive(value: true);
			}
			powerButton2.name = pGodPowerId;
			powerButton2.icon.sprite = pIcon;
			powerButton2.icon.overrideSprite = pIcon;
			powerButton2.open_window_id = null;
			powerButton2.type = PowerButtonType.Special;
			powerButton2.transform.Find("ToggleIcon").GetComponent<ToggleIcon>().updateIcon(value.boolVal);
			LogService.LogInfo($"Set {powerButton2.name} toggle to {value.boolVal}");
			Transform transform = powerButton2.transform;
			transform.localPosition = pLocalPosition;
			transform.localScale = Vector3.one;
			powerButton2.gameObject.SetActive(value: true);
			return powerButton2;
			static void toggleOption(string pPower)
			{
				GodPower godPower2 = AssetManager.powers.get(pPower);
				WorldTip.instance.showToolbarText(godPower2);
				if (!PlayerConfig.dict.TryGetValue(godPower2.toggle_name, out var value2))
				{
					value2 = new PlayerOptionData(godPower2.toggle_name)
					{
						boolVal = false
					};
					PlayerConfig.instance.data.add(value2);
				}
				value2.boolVal = !value2.boolVal;
				if (value2.boolVal && godPower2.map_modes_switch)
				{
					PowerLibrary.disableAllOtherMapModes(pPower);
				}
				PlayerConfig.saveData();
			}
		}

		public static PowersTab GetTab(string pId)
		{
			if (string.IsNullOrEmpty(pId))
			{
				return null;
			}
			Transform transform = CanvasMain.instance.canvas_ui.transform.Find("CanvasBottom/BottomElements/BottomElementsMover/CanvasScrollView/Scroll View/Viewport/Content/Power Tabs/" + pId);
			return (transform == null) ? null : transform.GetComponent<PowersTab>();
		}

		[Obsolete("Specifying a position vector has become useless in 0.50.5, tab order is now determined by sibling index.")]
		public static void AddButtonToTab(PowerButton button, PowersTab tab, Vector2 position, int? siblingIndex = null)
		{
			AddButtonToTab(button, tab, siblingIndex);
		}

		public static void AddButtonToTab(PowerButton button, PowersTab tab, int? siblingIndex = null)
		{
			Transform transform;
			(transform = button.transform).SetParent(tab.transform);
			transform.localScale = Vector3.one;
			if (siblingIndex.HasValue)
			{
				transform.SetSiblingIndex(siblingIndex.Value);
			}
			tab._power_buttons.Add(button);
		}
	}
	public static class PowerTabNames
	{
		public const string Main = "main";

		public const string Drawing = "creation";

		public const string Kingdoms = "noosphere";

		public const string Creatures = "units";

		public const string Nature = "nature";

		public const string Bombs = "destruction";

		public const string Other = "other";

		public static List<string> GetNames()
		{
			return new List<string> { "main", "creation", "noosphere", "units", "nature", "destruction", "other" };
		}
	}
	public static class ResourcesFinder
	{
		private static Dictionary<Type, Dictionary<string, UnityEngine.Object>> objects_cache = new Dictionary<Type, Dictionary<string, UnityEngine.Object>>();

		public static T[] FindResources<T>(string name) where T : UnityEngine.Object
		{
			T[] array = Resources.FindObjectsOfTypeAll<T>();
			List<T> list = new List<T>(array.Length / 16);
			string text = name.ToLower();
			T[] array2 = array;
			foreach (T val in array2)
			{
				if (val.name.ToLower() == text)
				{
					list.Add(val);
				}
			}
			return list.ToArray();
		}

		public static T FindResource<T>(string name) where T : UnityEngine.Object
		{
			string text = name.ToLower();
			if (objects_cache.TryGetValue(typeof(T), out var value))
			{
				if (value.TryGetValue(text, out var value2))
				{
					return (T)value2;
				}
			}
			else
			{
				value = new Dictionary<string, UnityEngine.Object>();
				objects_cache.Add(typeof(T), value);
			}
			T[] array = Resources.FindObjectsOfTypeAll<T>();
			T[] array2 = array;
			foreach (T val in array2)
			{
				if (val.name.ToLower() == text)
				{
					T val2 = UnityEngine.Object.Instantiate(val, WorldBoxMod.InactiveTransform);
					val2.name = val.name;
					value.Add(text, val2);
					return val;
				}
			}
			return null;
		}
	}
	[Experimental("This helper class is experimental. Maybe some errors will occur.")]
	public static class RF
	{
		private static Dictionary<Type, Dictionary<string, Delegate>> _method_cache = new Dictionary<Type, Dictionary<string, Delegate>>();

		private static Dictionary<Type, Dictionary<string, Delegate>> _getter_cache = new Dictionary<Type, Dictionary<string, Delegate>>();

		private static Dictionary<Type, Dictionary<string, Delegate>> _setter_cache = new Dictionary<Type, Dictionary<string, Delegate>>();

		public static Delegate GetMethodDelegate(this Type type, string name, bool is_static = false)
		{
			if (_method_cache.TryGetValue(type, out var value))
			{
				if (value.TryGetValue(name, out var value2))
				{
					return value2;
				}
				Delegate method = NeoModLoader.utils.ReflectionHelper.GetMethod(type, name, is_static);
				value.Add(name, method);
				return method;
			}
			Delegate method2 = NeoModLoader.utils.ReflectionHelper.GetMethod(type, name, is_static);
			_method_cache.Add(type, new Dictionary<string, Delegate> { { name, method2 } });
			return method2;
		}

		public static TF GetField<TF, TI>(this TI obj, string name)
		{
			if (_getter_cache.TryGetValue(typeof(TI), out var value))
			{
				if (value.TryGetValue(name, out var value2))
				{
					return ((Func<TI, TF>)value2)(obj);
				}
				Func<TI, TF> func = NeoModLoader.utils.ReflectionHelper.CreateFieldGetter<TI, TF>(name);
				value.Add(name, func);
				return func(obj);
			}
			Func<TI, TF> func2 = NeoModLoader.utils.ReflectionHelper.CreateFieldGetter<TI, TF>(name);
			_getter_cache.Add(typeof(TI), new Dictionary<string, Delegate> { { name, func2 } });
			return func2(obj);
		}

		public static TF GetField<TF>(this object obj, string name)
		{
			Type type = obj.GetType();
			if (_getter_cache.TryGetValue(type, out var value))
			{
				if (value.TryGetValue(name, out var value2))
				{
					return (TF)value2.DynamicInvoke(obj);
				}
				Delegate obj2 = NeoModLoader.utils.ReflectionHelper.CreateFieldGetter<TF>(name, type);
				value.Add(name, obj2);
				return (TF)obj2.DynamicInvoke(obj);
			}
			Delegate obj3 = NeoModLoader.utils.ReflectionHelper.CreateFieldGetter<TF>(name, type);
			_getter_cache.Add(type, new Dictionary<string, Delegate> { { name, obj3 } });
			return (TF)obj3.DynamicInvoke(obj);
		}

		public static object GetField(this object obj, string name, Type field_type)
		{
			Type type = obj.GetType();
			if (_getter_cache.TryGetValue(type, out var value))
			{
				if (value.TryGetValue(name, out var value2))
				{
					return value2.DynamicInvoke(obj);
				}
				Delegate obj2 = NeoModLoader.utils.ReflectionHelper.CreateFieldGetter(name, type, field_type);
				value.Add(name, obj2);
				return obj2.DynamicInvoke(obj);
			}
			Delegate obj3 = NeoModLoader.utils.ReflectionHelper.CreateFieldGetter(name, type, field_type);
			_getter_cache.Add(type, new Dictionary<string, Delegate> { { name, obj3 } });
			return obj3.DynamicInvoke(obj);
		}

		public static TF GetStaticField<TF, TI>(string name)
		{
			FieldInfo field = typeof(TI).GetField(name, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			if (field != null)
			{
				return (TF)field.GetValue(null);
			}
			LogService.LogWarning("Cannot find '" + name + "' in type " + typeof(TI).FullName + ". Return default value.");
			try
			{
				throw new Exception();
			}
			catch (Exception ex)
			{
				LogService.LogWarning(ex.StackTrace);
			}
			return default(TF);
		}

		public static TF GetStaticField<TF>(string name, Type type)
		{
			FieldInfo field = type.GetField(name, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			if (field != null)
			{
				return (TF)field.GetValue(null);
			}
			LogService.LogWarning("Cannot find '" + name + "' in type " + type.FullName + ". Return default value.");
			try
			{
				throw new Exception();
			}
			catch (Exception ex)
			{
				LogService.LogWarning(ex.StackTrace);
			}
			return default(TF);
		}

		public static void SetField<TF, TI>(this TI obj, string name, TF value)
		{
			if (_setter_cache.TryGetValue(typeof(TI), out var value2))
			{
				if (value2.TryGetValue(name, out var value3))
				{
					((Action<TI, TF>)value3)(obj, value);
					return;
				}
				Action<TI, TF> action = NeoModLoader.utils.ReflectionHelper.CreateFieldSetter<TI, TF>(name);
				value2.Add(name, action);
				action(obj, value);
			}
			else
			{
				Action<TI, TF> action2 = NeoModLoader.utils.ReflectionHelper.CreateFieldSetter<TI, TF>(name);
				_setter_cache.Add(typeof(TI), new Dictionary<string, Delegate> { { name, action2 } });
				action2(obj, value);
			}
		}

		public static void SetStaticField<TF, TI>(string name, TF value)
		{
			FieldInfo field = typeof(TI).GetField(name, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			if (field != null)
			{
				field.SetValue(null, value);
				return;
			}
			LogService.LogWarning("Cannot find '" + name + "' in type " + typeof(TI).FullName + ". No action taken.");
			try
			{
				throw new Exception();
			}
			catch (Exception ex)
			{
				LogService.LogWarning(ex.StackTrace);
			}
		}

		public static void SetStaticField<TF>(string name, TF value, Type TI)
		{
			FieldInfo field = TI.GetField(name, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			if (field != null)
			{
				field.SetValue(null, value);
				return;
			}
			LogService.LogWarning("Cannot find '" + name + "' in type " + TI.FullName + ". No action taken.");
			try
			{
				throw new Exception();
			}
			catch (Exception ex)
			{
				LogService.LogWarning(ex.StackTrace);
			}
		}
	}
	public static class WindowCreator
	{
		internal static void init()
		{
		}

		public static ScrollWindow CreateEmptyWindow(string pWindowID, string pWindowTitleKey, string pWindowIcon = "neomodloader")
		{
			if (ScrollWindow._all_windows.TryGetValue(pWindowID, out var value))
			{
				return value;
			}
			ScrollWindow scrollWindow = UnityEngine.Object.Instantiate(Resources.Load<ScrollWindow>("windows/empty"), CanvasMain.instance.transformWindows);
			scrollWindow.screen_id = pWindowID;
			scrollWindow.name = pWindowID;
			LocalizedText component = scrollWindow.titleText.GetComponent<LocalizedText>();
			component.key = pWindowTitleKey;
			LocalizedTextManager.instance.texts.Add(component);
			ScrollWindow._all_windows[pWindowID] = scrollWindow;
			scrollWindow.create(pHide: true);
			Transform transform = scrollWindow.transform.Find("Background");
			transform.Find("Scroll View").gameObject.SetActive(value: true);
			transform.Find("Scroll View").GetComponent<RectTransform>().sizeDelta = new Vector2(232f, 270f);
			transform.Find("Scroll View").localPosition = new Vector3(0f, -6f);
			transform.Find("Scroll View/Viewport").GetComponent<RectTransform>().sizeDelta = new Vector2(30f, 0f);
			transform.Find("Scroll View/Viewport").localPosition = new Vector3(-131f, 135f);
			AssetManager.window_library.add(new WindowAsset
			{
				id = pWindowID,
				icon_path = pWindowIcon
			});
			return scrollWindow;
		}
	}
}
namespace NeoModLoader.General.UI.Window
{
	public abstract class AutoLayoutElement<T> : APrefab<T> where T : AutoLayoutElement<T>
	{
	}
	public abstract class AutoLayoutGroup<T, TElement> : AutoLayoutElement<TElement> where T : LayoutGroup where TElement : AutoLayoutGroup<T, TElement>
	{
		protected ContentSizeFitter m_fitter;

		protected T m_layout;

		public ContentSizeFitter fitter
		{
			get
			{
				if (m_fitter == null)
				{
					m_fitter = base.gameObject.GetComponent<ContentSizeFitter>();
				}
				return m_fitter;
			}
		}

		public T layout
		{
			get
			{
				if (m_layout == null)
				{
					m_layout = GetLayoutGroup();
				}
				return m_layout;
			}
		}

		public virtual void AddChild(GameObject pChild, int pIndex = -1)
		{
			Transform transform;
			(transform = pChild.transform).SetParent(base.transform);
			transform.localScale = Vector3.one;
			int childCount = base.transform.childCount;
			transform.SetSiblingIndex((pIndex + childCount) % childCount);
		}

		public virtual T GetLayoutGroup()
		{
			T component = base.gameObject.GetComponent<T>();
			return (component != null) ? component : base.gameObject.AddComponent<T>();
		}

		public TSub BeginSubGroup<TSub, TSubGroup>(Vector2 pSize = default(Vector2)) where TSub : AutoLayoutGroup<TSubGroup, TSub> where TSubGroup : LayoutGroup
		{
			GameObject gameObject = new GameObject("TSubGroup", typeof(TSub), typeof(TSubGroup));
			TSub component = gameObject.GetComponent<TSub>();
			if (pSize != default(Vector2))
			{
				component.SetSize(pSize);
			}
			AddChild(gameObject);
			return component;
		}

		public override void SetSize(Vector2 pSize)
		{
			GetComponent<RectTransform>().sizeDelta = pSize;
		}
	}
	public abstract class AutoLayoutWindow<T> : AutoVertLayoutGroup where T : AutoLayoutWindow<T>
	{
		protected new bool Initialized;

		protected bool IsFirstOpen = true;

		protected bool IsOpened;

		protected ScrollWindow ScrollWindowComponent { get; set; }

		protected Transform ContentTransform { get; set; }

		protected Transform BackgroundTransform { get; set; }

		protected internal string WindowID { get; set; }

		private void OnEnable()
		{
			if (Initialized)
			{
				if (IsFirstOpen)
				{
					IsFirstOpen = false;
					OnFirstEnable();
				}
				OnNormalEnable();
				IsOpened = true;
			}
		}

		private void OnDisable()
		{
			if (Initialized)
			{
				IsOpened = false;
				OnNormalDisable();
			}
		}

		public static T CreateWindow(string pWindowID, string pWindowTitleKey)
		{
			ScrollWindow scrollWindow = WindowCreator.CreateEmptyWindow(pWindowID, pWindowTitleKey);
			scrollWindow.gameObject.SetActive(value: false);
			scrollWindow.transform_content.gameObject.AddComponent<VerticalLayoutGroup>();
			T val = scrollWindow.transform_content.gameObject.AddComponent<T>();
			val.BackgroundTransform = scrollWindow.transform.Find("Background");
			scrollWindow.transform_scrollRect.gameObject.SetActive(value: true);
			val.ContentTransform = scrollWindow.transform_content;
			val.ScrollWindowComponent = scrollWindow;
			VerticalLayoutGroup layoutGroup = val.GetLayoutGroup();
			layoutGroup.childAlignment = TextAnchor.UpperCenter;
			layoutGroup.childControlHeight = false;
			layoutGroup.childControlWidth = false;
			layoutGroup.childForceExpandHeight = false;
			layoutGroup.childForceExpandWidth = false;
			layoutGroup.childScaleHeight = false;
			layoutGroup.childScaleWidth = false;
			layoutGroup.spacing = 10f;
			layoutGroup.padding = new RectOffset(3, 3, 10, 10);
			ContentSizeFitter contentSizeFitter = scrollWindow.transform_content.gameObject.AddComponent<ContentSizeFitter>();
			contentSizeFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
			contentSizeFitter.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
			val.WindowID = pWindowID;
			val.Init();
			val.Initialized = true;
			return val;
		}

		protected new abstract void Init();

		public static void Reconstruct(ref T pWindow)
		{
			pWindow.ScrollWindowComponent.clickHide();
			ScrollWindow._all_windows.Remove(pWindow.WindowID);
			string windowID = pWindow.WindowID;
			string key = pWindow.ScrollWindowComponent.titleText.GetComponent<LocalizedText>().key;
			UnityEngine.Object.Destroy(pWindow.ScrollWindowComponent.gameObject);
			pWindow = CreateWindow(windowID, key);
		}

		public virtual void OnNormalDisable()
		{
		}

		public virtual void OnFirstEnable()
		{
		}

		public virtual void OnNormalEnable()
		{
		}
	}
	public abstract class MultiTabWindow<T> : AutoLayoutWindow<T> where T : MultiTabWindow<T>
	{
		private readonly Dictionary<SimpleButton, AutoVertLayoutGroup> m_tabs = new Dictionary<SimpleButton, AutoVertLayoutGroup>();

		private RectTransform m_tab_entries_left;

		private RectTransform m_tab_entries_right;

		protected string CurrentTab { get; private set; } = "Default";

		public new static T CreateWindow(string pWindowID, string pWindowTitleKey)
		{
			ScrollWindow scrollWindow = WindowCreator.CreateEmptyWindow(pWindowID, pWindowTitleKey);
			scrollWindow.gameObject.SetActive(value: false);
			scrollWindow.transform_content.gameObject.AddComponent<VerticalLayoutGroup>();
			T val = scrollWindow.transform_content.gameObject.AddComponent<T>();
			val.BackgroundTransform = scrollWindow.transform.Find("Background");
			scrollWindow.transform_scrollRect.gameObject.SetActive(value: true);
			scrollWindow.transform_scrollRect.sizeDelta = new Vector2(210f, scrollWindow.transform_scrollRect.sizeDelta.y);
			val.ContentTransform = scrollWindow.transform_content;
			val.ScrollWindowComponent = scrollWindow;
			VerticalLayoutGroup layoutGroup = val.GetLayoutGroup();
			layoutGroup.childAlignment = TextAnchor.UpperCenter;
			layoutGroup.childControlHeight = false;
			layoutGroup.childControlWidth = false;
			layoutGroup.childForceExpandHeight = false;
			layoutGroup.childForceExpandWidth = false;
			layoutGroup.childScaleHeight = false;
			layoutGroup.childScaleWidth = false;
			layoutGroup.spacing = 10f;
			layoutGroup.padding = new RectOffset(3, 3, 10, 10);
			ContentSizeFitter contentSizeFitter = scrollWindow.transform_content.gameObject.AddComponent<ContentSizeFitter>();
			contentSizeFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
			contentSizeFitter.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
			GameObject gameObject = new GameObject("TabEntriesContainer", typeof(RectTransform), typeof(HorizontalLayoutGroup));
			gameObject.transform.SetParent(val.BackgroundTransform);
			gameObject.transform.SetAsFirstSibling();
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(256f, 220f);
			HorizontalLayoutGroup component = gameObject.GetComponent<HorizontalLayoutGroup>();
			component.childAlignment = TextAnchor.MiddleCenter;
			component.childControlHeight = false;
			component.childControlWidth = false;
			component.childForceExpandHeight = false;
			component.childForceExpandWidth = false;
			component.childScaleHeight = false;
			component.childScaleWidth = false;
			component.spacing = 208f;
			GameObject gameObject2 = new GameObject("LeftContainer", typeof(RectTransform), typeof(VerticalLayoutGroup), typeof(Mask), typeof(UnityEngine.UI.Image));
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.transform.localScale = Vector3.one;
			gameObject2.GetComponent<Mask>().showMaskGraphic = false;
			VerticalLayoutGroup component2 = gameObject2.GetComponent<VerticalLayoutGroup>();
			component2.childAlignment = TextAnchor.UpperCenter;
			component2.childControlHeight = false;
			component2.childControlWidth = false;
			component2.childForceExpandHeight = false;
			component2.childForceExpandWidth = false;
			component2.childScaleHeight = false;
			component2.childScaleWidth = false;
			component2.spacing = 4f;
			component2.padding = new RectOffset(4, 0, 0, 0);
			gameObject2.GetComponent<RectTransform>().sizeDelta = new Vector2(24f, 220f);
			val.m_tab_entries_left = gameObject2.GetComponent<RectTransform>();
			GameObject gameObject3 = UnityEngine.Object.Instantiate(gameObject2, gameObject.transform);
			gameObject3.name = "RightContainer";
			gameObject3.transform.localScale = Vector3.one;
			gameObject3.GetComponent<VerticalLayoutGroup>().padding = new RectOffset(0, 4, 0, 0);
			val.m_tab_entries_right = gameObject3.GetComponent<RectTransform>();
			val.WindowID = pWindowID;
			val.Init();
			val.Initialized = true;
			return val;
		}

		protected AutoVertLayoutGroup CreateTab(string pTabID, Sprite pTabIcon, UnityAction<string> pAdditionTabSwitchAction = null)
		{
			AutoVertLayoutGroup tab = UnityEngine.Object.Instantiate(APrefab<AutoVertLayoutGroup>.Prefab, base.ContentTransform.parent);
			tab.Setup(default(Vector2), TextAnchor.UpperCenter, 10f, new RectOffset(3, 3, 10, 10));
			tab.transform.localScale = Vector3.one;
			tab.transform.localPosition = Vector3.zero;
			tab.GetComponent<RectTransform>().pivot = new Vector2(0f, 1f);
			tab.gameObject.SetActive(value: false);
			tab.name = pTabID;
			SimpleButton tab_entry = UnityEngine.Object.Instantiate(APrefab<SimpleButton>.Prefab, (m_tab_entries_left.childCount > m_tab_entries_right.childCount) ? m_tab_entries_right : m_tab_entries_left);
			tab_entry.Setup(delegate
			{
				foreach (Transform item in base.ContentTransform.parent)
				{
					item.gameObject.SetActive(value: false);
				}
				if (tab_entry.Background.color == UnityEngine.Color.gray)
				{
					tab_entry.Background.color = UnityEngine.Color.white;
					CurrentTab = "Default";
					tab.gameObject.SetActive(value: false);
					base.ContentTransform.gameObject.SetActive(value: true);
				}
				else
				{
					tab_entry.Background.color = UnityEngine.Color.gray;
					CurrentTab = pTabID;
					tab.gameObject.SetActive(value: true);
					pAdditionTabSwitchAction?.Invoke(pTabID);
				}
				foreach (KeyValuePair<SimpleButton, AutoVertLayoutGroup> item2 in m_tabs.Where((KeyValuePair<SimpleButton, AutoVertLayoutGroup> tab_entry_pair) => tab_entry_pair.Key != tab_entry))
				{
					item2.Key.Background.color = UnityEngine.Color.white;
					item2.Value.gameObject.SetActive(value: false);
				}
			}, pTabIcon, null, new Vector2(24f, 48f), "normal", new TooltipData
			{
				tip_name = pTabID,
				tip_description = pTabID + " Description"
			});
			tab_entry.Background.sprite = InternalResourcesGetter.GetWindowVertNamePlate();
			m_tabs.Add(tab_entry, tab);
			ResizeTabEntries();
			return tab;
		}

		private void ResizeTabEntries()
		{
			int num = 0;
			VerticalLayoutGroup verticalLayoutGroup = null;
			RectTransform rectTransform = null;
			num = m_tab_entries_left.childCount;
			verticalLayoutGroup = m_tab_entries_left.GetComponent<VerticalLayoutGroup>();
			rectTransform = m_tab_entries_left;
			if (num <= 4)
			{
				verticalLayoutGroup.spacing = 4f;
			}
			else
			{
				verticalLayoutGroup.spacing = (rectTransform.sizeDelta.y - (float)(num * 48)) / (float)(num - 1);
			}
			num = m_tab_entries_right.childCount;
			verticalLayoutGroup = m_tab_entries_right.GetComponent<VerticalLayoutGroup>();
			rectTransform = m_tab_entries_right;
			if (num <= 4)
			{
				verticalLayoutGroup.spacing = 4f;
			}
			else
			{
				verticalLayoutGroup.spacing = (rectTransform.sizeDelta.y - (float)(num * 48)) / (float)(num - 1);
			}
		}
	}
	public abstract class SingleAutoLayoutWindow<T> : AutoLayoutWindow<T> where T : AutoLayoutWindow<T>
	{
		public static T Instance { get; private set; }

		public static string WindowId => Instance.WindowID;

		public new static T CreateWindow(string pWindowID, string pWindowTitleKey)
		{
			if (Instance != null)
			{
				LogService.LogError("Cannot create more than one instance of this window.");
				return Instance;
			}
			Instance = AutoLayoutWindow<T>.CreateWindow(pWindowID, pWindowTitleKey);
			return Instance;
		}
	}
}
namespace NeoModLoader.General.UI.Window.Utils.Extensions
{
	public static class AutoLayoutGroupExtension
	{
		public static AutoHoriLayoutGroup BeginHoriGroup<T, TElement>(this AutoLayoutGroup<T, TElement> pThis, Vector2 pSize = default(Vector2), TextAnchor pAlignment = TextAnchor.MiddleLeft, float pSpacing = 3f, RectOffset pPadding = null) where T : LayoutGroup where TElement : AutoLayoutGroup<T, TElement>
		{
			AutoHoriLayoutGroup autoHoriLayoutGroup = pThis.BeginSubGroup<AutoHoriLayoutGroup, HorizontalLayoutGroup>(pSize);
			if (pSize == default(Vector2))
			{
				ContentSizeFitter contentSizeFitter = autoHoriLayoutGroup.gameObject.GetComponent<ContentSizeFitter>();
				if (contentSizeFitter == null)
				{
					contentSizeFitter = autoHoriLayoutGroup.gameObject.AddComponent<ContentSizeFitter>();
				}
				contentSizeFitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
				contentSizeFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
			}
			HorizontalLayoutGroup layoutGroup = autoHoriLayoutGroup.GetLayoutGroup();
			layoutGroup.childAlignment = pAlignment;
			layoutGroup.childControlHeight = false;
			layoutGroup.childControlWidth = false;
			layoutGroup.childForceExpandHeight = false;
			layoutGroup.childForceExpandWidth = false;
			layoutGroup.childScaleHeight = false;
			layoutGroup.childScaleWidth = false;
			layoutGroup.spacing = pSpacing;
			layoutGroup.padding = pPadding ?? new RectOffset(3, 3, 3, 3);
			return autoHoriLayoutGroup;
		}

		public static AutoVertLayoutGroup BeginVertGroup<T, TElement>(this AutoLayoutGroup<T, TElement> pThis, Vector2 pSize = default(Vector2), TextAnchor pAlignment = TextAnchor.UpperCenter, float pSpacing = 3f, RectOffset pPadding = null) where T : LayoutGroup where TElement : AutoLayoutGroup<T, TElement>
		{
			AutoVertLayoutGroup autoVertLayoutGroup = pThis.BeginSubGroup<AutoVertLayoutGroup, VerticalLayoutGroup>(pSize);
			if (pSize == default(Vector2))
			{
				ContentSizeFitter contentSizeFitter = autoVertLayoutGroup.gameObject.GetComponent<ContentSizeFitter>();
				if (contentSizeFitter == null)
				{
					contentSizeFitter = autoVertLayoutGroup.gameObject.AddComponent<ContentSizeFitter>();
				}
				contentSizeFitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
				contentSizeFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
			}
			VerticalLayoutGroup layoutGroup = autoVertLayoutGroup.GetLayoutGroup();
			layoutGroup.childAlignment = pAlignment;
			layoutGroup.childControlHeight = false;
			layoutGroup.childControlWidth = false;
			layoutGroup.childForceExpandHeight = false;
			layoutGroup.childForceExpandWidth = false;
			layoutGroup.childScaleHeight = false;
			layoutGroup.childScaleWidth = false;
			layoutGroup.spacing = pSpacing;
			layoutGroup.padding = pPadding ?? new RectOffset(3, 3, 3, 3);
			return autoVertLayoutGroup;
		}

		public static AutoGridLayoutGroup BeginGridGroup<T, TElement>(this AutoLayoutGroup<T, TElement> pThis, int pConstraintCount, GridLayoutGroup.Constraint pConstraint = GridLayoutGroup.Constraint.FixedColumnCount, Vector2 pSize = default(Vector2), Vector2 pCellSize = default(Vector2), Vector2 pSpacing = default(Vector2), GridLayoutGroup.Axis pStartAxis = GridLayoutGroup.Axis.Horizontal, GridLayoutGroup.Corner pStartCorner = GridLayoutGroup.Corner.UpperLeft) where T : LayoutGroup where TElement : AutoLayoutGroup<T, TElement>
		{
			AutoGridLayoutGroup autoGridLayoutGroup = pThis.BeginSubGroup<AutoGridLayoutGroup, GridLayoutGroup>(pSize);
			if (pSize == default(Vector2))
			{
				ContentSizeFitter contentSizeFitter = autoGridLayoutGroup.gameObject.GetComponent<ContentSizeFitter>();
				if (contentSizeFitter == null)
				{
					contentSizeFitter = autoGridLayoutGroup.gameObject.AddComponent<ContentSizeFitter>();
				}
				contentSizeFitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
				contentSizeFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
			}
			GridLayoutGroup layoutGroup = autoGridLayoutGroup.GetLayoutGroup();
			layoutGroup.constraint = pConstraint;
			layoutGroup.constraintCount = pConstraintCount;
			layoutGroup.cellSize = ((pCellSize == default(Vector2)) ? new Vector2(16f, 16f) : pCellSize);
			layoutGroup.spacing = ((pSpacing == default(Vector2)) ? new Vector2(3f, 3f) : pSpacing);
			layoutGroup.startAxis = pStartAxis;
			layoutGroup.startCorner = pStartCorner;
			return autoGridLayoutGroup;
		}
	}
}
namespace NeoModLoader.General.UI.Window.Layout
{
	public class AutoGridLayoutGroup : AutoLayoutGroup<GridLayoutGroup, AutoGridLayoutGroup>
	{
		public void Setup(int pConstraintCount, GridLayoutGroup.Constraint pConstraint = GridLayoutGroup.Constraint.FixedColumnCount, Vector2 pSize = default(Vector2), Vector2 pCellSize = default(Vector2), Vector2 pSpacing = default(Vector2), GridLayoutGroup.Axis pStartAxis = GridLayoutGroup.Axis.Horizontal, GridLayoutGroup.Corner pStartCorner = GridLayoutGroup.Corner.UpperLeft)
		{
			Init();
			if (pSize == default(Vector2))
			{
				base.fitter.enabled = true;
			}
			else
			{
				base.fitter.enabled = false;
				GetComponent<RectTransform>().sizeDelta = pSize;
			}
			base.layout.constraint = pConstraint;
			base.layout.constraintCount = pConstraintCount;
			base.layout.cellSize = ((pCellSize == default(Vector2)) ? new Vector2(16f, 16f) : pCellSize);
			base.layout.spacing = ((pSpacing == default(Vector2)) ? new Vector2(3f, 3f) : pSpacing);
			base.layout.startAxis = pStartAxis;
			base.layout.startCorner = pStartCorner;
		}

		internal static void _init()
		{
			GameObject gameObject = new GameObject("AutoGridLayoutGroup", typeof(GridLayoutGroup), typeof(AutoGridLayoutGroup), typeof(ContentSizeFitter));
			ContentSizeFitter component = gameObject.GetComponent<ContentSizeFitter>();
			component.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
			component.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
			GridLayoutGroup component2 = gameObject.GetComponent<GridLayoutGroup>();
			component2.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
			component2.constraintCount = 3;
			component2.cellSize = new Vector2(16f, 16f);
			component2.spacing = new Vector2(3f, 3f);
			component2.startAxis = GridLayoutGroup.Axis.Horizontal;
			component2.startCorner = GridLayoutGroup.Corner.UpperLeft;
			APrefab<AutoGridLayoutGroup>.Prefab = gameObject.GetComponent<AutoGridLayoutGroup>();
		}
	}
	public class AutoHoriLayoutGroup : AutoLayoutGroup<HorizontalLayoutGroup, AutoHoriLayoutGroup>
	{
		public void Setup(Vector2 pSize = default(Vector2), TextAnchor pAlignment = TextAnchor.MiddleLeft, float pSpacing = 3f, RectOffset pPadding = null)
		{
			Init();
			if (pSize == default(Vector2))
			{
				base.fitter.enabled = true;
			}
			else
			{
				base.fitter.enabled = false;
				GetComponent<RectTransform>().sizeDelta = pSize;
			}
			base.layout.childAlignment = pAlignment;
			base.layout.spacing = pSpacing;
			base.layout.padding = pPadding ?? new RectOffset(3, 3, 3, 3);
		}

		internal static void _init()
		{
			GameObject gameObject = new GameObject("AutoHoriLayoutGroup", typeof(HorizontalLayoutGroup), typeof(AutoHoriLayoutGroup), typeof(ContentSizeFitter));
			ContentSizeFitter component = gameObject.GetComponent<ContentSizeFitter>();
			component.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
			component.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
			HorizontalLayoutGroup component2 = gameObject.GetComponent<HorizontalLayoutGroup>();
			component2.childAlignment = TextAnchor.MiddleLeft;
			component2.childControlHeight = false;
			component2.childControlWidth = false;
			component2.childForceExpandHeight = false;
			component2.childForceExpandWidth = false;
			component2.childScaleHeight = false;
			component2.childScaleWidth = false;
			component2.spacing = 3f;
			component2.padding = new RectOffset(3, 3, 3, 3);
			APrefab<AutoHoriLayoutGroup>.Prefab = gameObject.GetComponent<AutoHoriLayoutGroup>();
		}
	}
	public class AutoVertLayoutGroup : AutoLayoutGroup<VerticalLayoutGroup, AutoVertLayoutGroup>
	{
		public void Setup(Vector2 pSize = default(Vector2), TextAnchor pAlignment = TextAnchor.UpperCenter, float pSpacing = 3f, RectOffset pPadding = null)
		{
			Init();
			if (pSize == default(Vector2))
			{
				base.fitter.enabled = true;
			}
			else
			{
				base.fitter.enabled = false;
				GetComponent<RectTransform>().sizeDelta = pSize;
			}
			base.layout.childAlignment = pAlignment;
			base.layout.spacing = pSpacing;
			base.layout.padding = pPadding ?? new RectOffset(3, 3, 3, 3);
		}

		internal static void _init()
		{
			GameObject gameObject = new GameObject("AutoVertLayoutGroup", typeof(VerticalLayoutGroup), typeof(AutoVertLayoutGroup), typeof(ContentSizeFitter));
			gameObject.transform.SetParent(WorldBoxMod.Transform);
			ContentSizeFitter component = gameObject.GetComponent<ContentSizeFitter>();
			component.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
			component.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
			VerticalLayoutGroup component2 = gameObject.GetComponent<VerticalLayoutGroup>();
			component2.childAlignment = TextAnchor.UpperCenter;
			component2.childControlHeight = false;
			component2.childControlWidth = false;
			component2.childForceExpandHeight = false;
			component2.childForceExpandWidth = false;
			component2.childScaleHeight = false;
			component2.childScaleWidth = false;
			component2.spacing = 3f;
			component2.padding = new RectOffset(3, 3, 3, 3);
			APrefab<AutoVertLayoutGroup>.Prefab = gameObject.GetComponent<AutoVertLayoutGroup>();
		}
	}
}
namespace NeoModLoader.General.UI.Tab
{
	public static class PowersTabExtension
	{
		private static Dictionary<string, WrappedPowersTab> _wrapped_powers_tabs = new Dictionary<string, WrappedPowersTab>();

		public static void SetLayout(this PowersTab pTab, List<string> pGroupIds)
		{
			WrappedPowersTab wrappedPowersTab = _getWrappedPowersTab(pTab);
			if (!wrappedPowersTab.Modifiable)
			{
				LogService.LogWarning(pTab.name + "'s layout cannot be changed");
				LogService.LogStackTraceAsWarning();
				return;
			}
			wrappedPowersTab.ResetGroups();
			foreach (string pGroupId in pGroupIds)
			{
				wrappedPowersTab.AddGroup(pGroupId);
			}
			wrappedPowersTab.Modifiable = false;
		}

		public static void AddPowerButton(this PowersTab pTab, string pGroupId, PowerButton pPowerButton)
		{
			WrappedPowersTab wrappedPowersTab = _getWrappedPowersTab(pTab);
			if (!wrappedPowersTab.HasGroup(pGroupId))
			{
				LogService.LogWarning(pTab.name + "'s layout does not contain group \"" + pGroupId + "\"");
				LogService.LogStackTraceAsWarning();
			}
			else
			{
				wrappedPowersTab.AddPowerButton(pGroupId, pPowerButton);
			}
		}

		public static void PutElement(this PowersTab pTab, string pGroupId, RectTransform pObjRect, Vector2 pPositionInGroup, bool pPlacehold = true)
		{
			WrappedPowersTab wrappedPowersTab = _getWrappedPowersTab(pTab);
			if (!wrappedPowersTab.HasGroup(pGroupId))
			{
				LogService.LogWarning(pTab.name + "'s layout does not contain group \"" + pGroupId + "\"");
				LogService.LogStackTraceAsWarning();
			}
			else
			{
				wrappedPowersTab.AddCustomRect(pGroupId, pObjRect, pPositionInGroup, pPlacehold);
			}
		}

		public static void UpdateLayout(this PowersTab pTab)
		{
			_getWrappedPowersTab(pTab).UpdateLayout();
		}

		private static WrappedPowersTab _getWrappedPowersTab(PowersTab pTab)
		{
			if (!_wrapped_powers_tabs.TryGetValue(pTab.name, out var value))
			{
				value = new WrappedPowersTab(pTab);
				_wrapped_powers_tabs.Add(pTab.name, value);
			}
			return value;
		}
	}
	public abstract class ReconstructedVanillaTab
	{
		protected class TabElement
		{
			public Vector2 pos_in_group;

			public RectTransform element;
		}

		internal WrappedPowersTab tab;

		protected abstract string[] Groups { get; }

		internal void Init()
		{
			InitTab();
		}

		protected abstract void InitTab();

		public void AddPowerButton(string pGroupId, PowerButton pPowerButton)
		{
			tab.AddPowerButton(pGroupId, pPowerButton);
		}

		public void AddCustomRect(string pGroupId, RectTransform pCustomRect, Vector2 pPosInGroup, bool pPlaceholder)
		{
			tab.AddCustomRect(pGroupId, pCustomRect, pPosInGroup, pPlaceholder);
		}

		protected List<List<TabElement>> TrackElements()
		{
			Transform transform = tab.Tab.transform;
			int childCount = transform.childCount;
			List<Transform> list = new List<Transform>();
			List<Vector2> list2 = new List<Vector2>();
			for (int i = 0; i < childCount; i++)
			{
				Transform child = transform.GetChild(i);
				if (_is_line(child))
				{
					tab.RecordLine(child.gameObject);
					list2.Add(child.position);
				}
				else
				{
					list.Add(child);
				}
			}
			list.Sort((Transform a, Transform b) => a.position.x.CompareTo(b.position.x));
			list2.Sort((Vector2 a, Vector2 b) => a.x.CompareTo(b.x));
			List<List<TabElement>> list3 = new List<List<TabElement>>();
			foreach (Vector2 item in list2)
			{
				List<TabElement> list4 = new List<TabElement>();
				foreach (Transform item2 in list)
				{
					if (item2.position.x < item.x)
					{
						list4.Add(new TabElement
						{
							pos_in_group = item2.localPosition - new Vector3(item.x, 0f),
							element = item2.GetComponent<RectTransform>()
						});
					}
				}
				_sort_group(list4);
				list3.Add(list4);
			}
			return list3;
		}

		private bool _is_line(Transform pTransform)
		{
			return pTransform.name.ToLower().Contains("line");
		}

		private void _sort_group(List<TabElement> group)
		{
			throw new NotImplementedException();
		}
	}
	public class TabBombs : ReconstructedVanillaTab
	{
		protected override string[] Groups => new string[0];

		protected override void InitTab()
		{
			tab = new WrappedPowersTab(PowerButtonCreator.GetTab("destruction"));
		}
	}
	public class TabCreatures : ReconstructedVanillaTab
	{
		public const string RACES = "races";

		public const string LAND_CREATURES = "land_creatures";

		public const string SEA_CREATURES = "sea_creatures";

		public const string MAGICAL_CREATURES = "magical_creatures";

		public const string UNDEAD_CREATURES = "undead_creatures";

		public const string IMPROPER_CREATURES = "improper_creatures";

		protected override string[] Groups => new string[6] { "races", "land_creatures", "sea_creatures", "magical_creatures", "undead_creatures", "improper_creatures" };

		protected override void InitTab()
		{
			tab = new WrappedPowersTab(PowerButtonCreator.GetTab("units"));
		}
	}
	public class TabDrawing : ReconstructedVanillaTab
	{
		public const string TILE_BRUSH = "tile_brush";

		public const string MAP_HELPER = "map_helper";

		public const string CLEANER = "cleaner";

		public const string DELETOR = "deletor";

		protected override string[] Groups => new string[4] { "tile_brush", "map_helper", "cleaner", "deletor" };

		protected override void InitTab()
		{
			tab = new WrappedPowersTab(PowerButtonCreator.GetTab("creation"));
		}
	}
	public class TabKingdoms : ReconstructedVanillaTab
	{
		public const string INSPECT = "inspect";

		public const string RELATION = "relation";

		public const string ACTIVITY = "activity";

		public const string FORCE_VIEW = "force_view";

		public const string MAPLAYER = "maplayer";

		protected override string[] Groups => new string[5] { "inspect", "relation", "activity", "force_view", "maplayer" };

		protected override void InitTab()
		{
			tab = new WrappedPowersTab(PowerButtonCreator.GetTab("noosphere"));
		}
	}
	public class TabMain : ReconstructedVanillaTab
	{
		public const string WORLD_INFO = "world_info";

		public const string REBUILD = "rebuild";

		public const string GAME_SETTING = "game_setting";

		public const string OTHERS = "others";

		public const string CUSTOM = "custom";

		private static readonly string[] _groups = new string[5] { "world_info", "rebuild", "game_setting", "others", "custom" };

		protected override string[] Groups => _groups;

		protected override void InitTab()
		{
			tab = new WrappedPowersTab(PowerButtonCreator.GetTab("main"));
		}
	}
	public static class TabManager
	{
		private const int tab_count_each_line = 14;

		private const float check_new_tabs_interval = 1f;

		private const float shrink_coef = 0.79f;

		private const float default_tab_width = 43f;

		private const float default_tab_height = 18f;

		private const float default_icon_width = 33f;

		private const float default_icon_height = 11f;

		private const float default_tab_y = 2.0082f;

		private static readonly Transform tab_entry_container = CanvasMain.instance.canvas_ui.transform.Find("CanvasBottom/BottomElements/BottomElementsMover/TabsButtons");

		private static readonly Transform tab_container = CanvasMain.instance.canvas_ui.transform.Find("CanvasBottom/BottomElements/BottomElementsMover/CanvasScrollView/Scroll View/Viewport/Content/Power Tabs");

		private static readonly List<Button> tab_entries = new List<Button>(PowerTabController.instance._buttons);

		private static readonly List<string> tab_names = new List<string>();

		private static readonly HashSet<string> tab_names_set = new HashSet<string>();

		private static float _check_timer;

		private static Vector3 _last_mouse_pos = Vector3.zero;

		public static readonly TabMain TabMain = new TabMain();

		public static readonly TabDrawing TabDrawing = new TabDrawing();

		public static readonly TabKingdoms TabKingdoms = new TabKingdoms();

		public static readonly TabCreatures TabCreatures = new TabCreatures();

		public static readonly TabNature TabNature = new TabNature();

		public static readonly TabOther TabOther = new TabOther();

		private static readonly List<string> common_fix_for_tab_button = new List<string> { "newtab", "new_tab", "tab", "newbutton", "new_button", "button", "additional", "_", " " };

		internal static void _init()
		{
			Harmony.CreateAndPatchAll(typeof(TabManager), "wbom.nml");
			List<string> names = PowerTabNames.GetNames();
			for (int i = 1; i < names.Count; i++)
			{
				tab_names.Add(names[i]);
				tab_names_set.Add(names[i]);
			}
			TabMain.Init();
			TabDrawing.Init();
			TabKingdoms.Init();
			TabCreatures.Init();
			TabNature.Init();
			TabOther.Init();
		}

		private static void _loadPredefinedOrder()
		{
			if (!File.Exists(Paths.TabOrderRecordPath))
			{
				return;
			}
			List<string> list = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText(Paths.TabOrderRecordPath));
			if (list == null)
			{
				return;
			}
			List<int> list2 = new List<int>();
			foreach (string item in list)
			{
				int num = tab_names.IndexOf(item);
				if (num >= 0)
				{
					list2.Add(num);
				}
			}
			List<int> list3 = new List<int>(list2);
			list3.Sort();
			for (int i = 0; i < list3.Count; i++)
			{
				int num2 = list2[i];
				int num3 = list3[i];
				if (num2 == num3)
				{
					continue;
				}
				tab_names.Swap(num2, num3);
				tab_entries.Swap(num2, num3);
				for (int j = i + 1; j < list3.Count; j++)
				{
					if (list2[j] == num3)
					{
						list2[j] = num2;
						break;
					}
				}
			}
		}

		private static void _savePredefinedOrder()
		{
			File.WriteAllText(Paths.TabOrderRecordPath, JsonConvert.SerializeObject(tab_names));
		}

		[HarmonyTranspiler]
		[HarmonyPatch(typeof(PowerTabController), "getNext")]
		private static IEnumerable<CodeInstruction> _getNext_Patch(IEnumerable<CodeInstruction> instr)
		{
			List<CodeInstruction> list = new List<CodeInstruction>();
			list.Add(new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_0));
			list.Add(new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_1));
			list.Add(new CodeInstruction(System.Reflection.Emit.OpCodes.Call, AccessTools.Method(typeof(TabManager), "_getNext_Overwrite")));
			list.Add(new CodeInstruction(System.Reflection.Emit.OpCodes.Ret));
			return list;
		}

		[HarmonyTranspiler]
		[HarmonyPatch(typeof(PowerTabController), "getPrev")]
		private static IEnumerable<CodeInstruction> _getPrev_Patch(IEnumerable<CodeInstruction> instr)
		{
			List<CodeInstruction> list = new List<CodeInstruction>();
			list.Add(new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_0));
			list.Add(new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_1));
			list.Add(new CodeInstruction(System.Reflection.Emit.OpCodes.Call, AccessTools.Method(typeof(TabManager), "_getPrev_Overwrite")));
			list.Add(new CodeInstruction(System.Reflection.Emit.OpCodes.Ret));
			return list;
		}

		private static Button _getNext_Overwrite(this PowerTabController instance, string pActiveTab)
		{
			return tab_entries[(tab_names.IndexOf(pActiveTab) + 1) % tab_entries.Count];
		}

		private static Button _getPrev_Overwrite(this PowerTabController instance, string pActiveTab)
		{
			int num = tab_names.IndexOf(pActiveTab);
			if (num < 0)
			{
				num = 1;
			}
			if (num == 0)
			{
				num = tab_entries.Count;
			}
			return tab_entries[num - 1];
		}

		internal static void _checkNewTabs()
		{
			if (_check_timer > 0f)
			{
				_check_timer -= Time.deltaTime;
				return;
			}
			_check_timer = 1f;
			PowersTab[] componentsInChildren = tab_container.GetComponentsInChildren<PowersTab>(includeInactive: true);
			Button[] componentsInChildren2 = tab_entry_container.GetComponentsInChildren<Button>(includeInactive: false);
			if (componentsInChildren2.Length == tab_entries.Count)
			{
				return;
			}
			bool flag = false;
			PowersTab[] array = componentsInChildren;
			foreach (PowersTab powersTab in array)
			{
				string name = powersTab.name;
				if (tab_names_set.Contains(name))
				{
					continue;
				}
				string text = GetTabMainPart(name);
				Button[] array2 = componentsInChildren2;
				foreach (Button button in array2)
				{
					if (!(GetTabMainPart(button.name) != text))
					{
						flag = true;
						_addDragEventTo(button, name);
						_addTabEntry(button.gameObject, name);
						break;
					}
				}
			}
			if (flag)
			{
				_updateTabLayout();
			}
			static string GetTabMainPart(string text2)
			{
				return common_fix_for_tab_button.Aggregate(text2.ToLower(), (string current, string fix) => current.Replace(fix, ""));
			}
		}

		private static void _addDragEventTo(Button tab_entry, string pTabName)
		{
			EventTrigger eventTrigger = tab_entry.GetComponent<EventTrigger>();
			if (eventTrigger == null)
			{
				eventTrigger = tab_entry.gameObject.AddComponent<EventTrigger>();
			}
			EventTrigger.Entry entry = new EventTrigger.Entry();
			entry.eventID = EventTriggerType.EndDrag;
			entry.callback.AddListener(delegate
			{
				_setToValidPosition(tab_entry, pTabName);
			});
			eventTrigger.triggers.Add(entry);
			entry = new EventTrigger.Entry();
			entry.eventID = EventTriggerType.Drag;
			entry.callback.AddListener(delegate
			{
				_onDragTabEntry(tab_entry, pTabName);
			});
			eventTrigger.triggers.Add(entry);
		}

		private static void _setToValidPosition(Button pTabEntry, string pTabName)
		{
			_last_mouse_pos = Vector3.zero;
			_savePredefinedOrder();
			_updateTabLayout();
		}

		private static void _onDragTabEntry(Button pTabEntry, string pTabName)
		{
			RectTransform tab_entry_rect = pTabEntry.GetComponent<RectTransform>();
			Vector3 mousePosition = Input.mousePosition;
			Vector3 vector = tab_entry_rect.parent.InverseTransformPoint(mousePosition);
			if (_last_mouse_pos == Vector3.zero)
			{
				_last_mouse_pos = vector;
				return;
			}
			Vector3 delta = vector - _last_mouse_pos;
			Vector3 current_pos = tab_entry_rect.localPosition;
			int index = tab_names.IndexOf(pTabName);
			if (index == 0)
			{
				if (delta.x > 0f)
				{
					Vector3 localPosition = tab_entries[1].transform.localPosition;
					if (current_pos.x > localPosition.x)
					{
						swap(left: false);
					}
				}
			}
			else if (index == tab_names.Count - 1)
			{
				if (delta.x < 0f)
				{
					Vector3 localPosition2 = tab_entries[index - 1].transform.localPosition;
					if (current_pos.x < localPosition2.x)
					{
						swap(left: true);
					}
				}
			}
			else if (delta.x < 0f)
			{
				Vector3 localPosition3 = tab_entries[index - 1].transform.localPosition;
				if (current_pos.x < localPosition3.x)
				{
					swap(left: true);
				}
			}
			else
			{
				Vector3 localPosition4 = tab_entries[index + 1].transform.localPosition;
				if (current_pos.x > localPosition4.x)
				{
					swap(left: false);
				}
			}
			_last_mouse_pos = vector;
			tab_entry_rect.localPosition = new Vector3(current_pos.x + delta.x, current_pos.y, current_pos.z);
			void swap(bool left)
			{
				tab_names.Swap(index, index + ((!left) ? 1 : (-1)));
				tab_entries.Swap(index, index + ((!left) ? 1 : (-1)));
				_updateTabEntryRectAs(tab_entries[index], index);
				_updateTabEntryRectAs(tab_entries[index + ((!left) ? 1 : (-1))], index + ((!left) ? 1 : (-1)));
				Vector3 localPosition5 = tab_entry_rect.localPosition;
				if (Math.Abs(localPosition5.y - current_pos.y) > 0.01f)
				{
					delta.x = 0f;
					current_pos = localPosition5;
				}
			}
		}

		private static void _updateTabLayout()
		{
			_loadPredefinedOrder();
			int num = 0;
			foreach (Button tab_entry in tab_entries)
			{
				_updateTabEntryRectAs(tab_entry, num++);
			}
		}

		private static void _updateTabEntryRectAs(Button tab, int index)
		{
			int num = Math.Min(14, tab_entries.Count);
			int num2 = index % num - num / 2;
			int num3 = index / num;
			RectTransform component = tab.gameObject.GetComponent<RectTransform>();
			float y = 2.0082f + (Mathf.Pow(0.79f, num3) * 18f - 18f) / 2f + (1f - Mathf.Pow(0.79f, num3)) / 0.20999998f * 18f;
			component.sizeDelta = new Vector2(Mathf.Pow(0.79f, num3) * 43f, Mathf.Pow(0.79f, num3) * 18f);
			component.localPosition = new Vector3((float)num2 * 43f, y, component.localPosition.z);
			try
			{
				RectTransform component2 = tab.transform.Find("Icon").gameObject.GetComponent<RectTransform>();
				component2.sizeDelta = new Vector2(Mathf.Pow(0.79f, num3) * 33f, Mathf.Pow(0.79f, num3) * 11f);
			}
			catch (Exception)
			{
			}
		}

		private static void _addTabEntry(GameObject pTabEntry, string pTabId)
		{
			if (tab_entries.Count % 2 == 0)
			{
				tab_entries.Insert(0, pTabEntry.GetComponent<Button>());
				tab_names.Insert(0, pTabId);
			}
			else
			{
				tab_entries.Add(pTabEntry.GetComponent<Button>());
				tab_names.Add(pTabId);
			}
			tab_names_set.Add(pTabId);
		}

		public static PowersTab CreateTab(string name, string pTitleKey, string pDescKey, Sprite pIcon, string pOptionDescKey = "hotkey_tip_tab_other")
		{
			GameObject tab_entry = UnityEngine.Object.Instantiate(ResourcesFinder.FindResources<GameObject>("Button_Other")[0], tab_entry_container);
			UnityEngine.Object.DestroyImmediate(tab_entry.GetComponent<GraphicRaycaster>());
			UnityEngine.Object.DestroyImmediate(tab_entry.GetComponent<Canvas>());
			tab_entry.name = "Button_" + name;
			tab_entry.transform.Find("Icon").GetComponent<UnityEngine.UI.Image>().sprite = pIcon;
			PowersTab tab = UnityEngine.Object.Instantiate((from tgo in ResourcesFinder.FindResources<GameObject>("units")
				select tgo.GetComponent<PowersTab>()).First((PowersTab t) => t != null), tab_container);
			tab.name = name;
			PowerTabAsset powerTabAsset = new PowerTabAsset
			{
				id = name,
				locale_key = pTitleKey,
				tab_type_main = true,
				get_power_tab = () => tab
			};
			AssetManager.power_tab_library.add(powerTabAsset);
			tab._asset = powerTabAsset;
			Button tab_entry_button = tab_entry.GetComponent<Button>();
			tab_entry_button.onClick = new Button.ButtonClickedEvent();
			tab_entry_button.onClick.AddListener(delegate
			{
				tab.showTab(tab_entry_button);
			});
			tab_entry_button.onClick.AddListener(delegate
			{
				tab_entry.GetComponent<ButtonSfx>().playSound();
			});
			TipButton component = tab_entry.GetComponent<TipButton>();
			component.textOnClick = pTitleKey;
			component.textOnClickDescription = pDescKey;
			component.text_description_2 = pOptionDescKey;
			for (int num = 6; num < tab.transform.childCount; num++)
			{
				UnityEngine.Object.Destroy(tab.transform.GetChild(num).gameObject);
			}
			tab._power_buttons.Clear();
			PowerButton[] componentsInChildren = tab.GetComponentsInChildren<PowerButton>();
			foreach (PowerButton powerButton in componentsInChildren)
			{
				if (!(powerButton == null) && !(powerButton.rect_transform == null))
				{
					tab._power_buttons.Add(powerButton);
				}
			}
			foreach (PowerButton power_button in tab._power_buttons)
			{
				power_button.findNeighbours(tab._power_buttons, pCheckForActive: false);
			}
			_addDragEventTo(tab_entry_button, tab.name);
			_addTabEntry(tab_entry, tab.name);
			_updateTabLayout();
			tab.gameObject.SetActive(value: false);
			tab.gameObject.SetActive(value: true);
			return tab;
		}
	}
	public class TabNature : ReconstructedVanillaTab
	{
		public const string PHENOMENON = "phenomenon";

		public const string BIOMES = "biomes";

		public const string FERTILITY = "fertility";

		public const string RESOURCES = "resources";

		public const string DROP = "drop";

		protected override string[] Groups => new string[5] { "phenomenon", "biomes", "fertility", "resources", "drop" };

		protected override void InitTab()
		{
			tab = new WrappedPowersTab(PowerButtonCreator.GetTab("nature"));
		}
	}
	public class TabOther : ReconstructedVanillaTab
	{
		public const string INFO = "info";

		public const string STATUS = "status";

		public const string EDITOR_RAIN = "editor_rain";

		public const string LIFE_GAME = "life_game";

		public const string SHAPE_PRINTER = "shape_printer";

		protected override string[] Groups => new string[5] { "info", "status", "editor_rain", "life_game", "shape_printer" };

		protected override void InitTab()
		{
			tab = new WrappedPowersTab(PowerButtonCreator.GetTab("other"));
		}
	}
	internal class WrappedPowersTab
	{
		private class WrappedRectTransform
		{
			public readonly bool Placehold;

			public readonly Vector2 PositionInGroup;

			public readonly RectTransform Rect;

			public WrappedRectTransform(RectTransform pRect, Vector2 pPositionInGroup, bool pPlacehold)
			{
				Rect = pRect;
				PositionInGroup = pPositionInGroup;
				Placehold = pPlacehold;
			}
		}

		private class PlaceholdRegions
		{
			private class SimpleRegion
			{
				public readonly Vector2 LeftUpCorner;

				public readonly Vector2 RightDownCorner;

				public SimpleRegion(RectTransform pRect)
				{
					Rect rect = pRect.rect;
					LeftUpCorner = new Vector2(rect.xMin, rect.yMax);
					RightDownCorner = new Vector2(rect.xMax, rect.yMin);
				}

				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public bool Contains(float pX, float pY)
				{
					return ContainsX(pX) && ContainsY(pY);
				}

				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public bool ContainsX(float pX)
				{
					return pX >= LeftUpCorner.x && pX <= RightDownCorner.x;
				}

				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public bool ContainsY(float pY)
				{
					return pY >= RightDownCorner.y && pY <= RightDownCorner.y;
				}
			}

			private HashSet<SimpleRegion> _regions = new HashSet<SimpleRegion>();

			public void AddRegion(RectTransform pRect)
			{
				_regions.Add(new SimpleRegion(pRect));
			}

			public bool Overlap(RectTransform pRect)
			{
				Rect rect = pRect.rect;
				foreach (SimpleRegion region in _regions)
				{
					if (region.Contains(rect.xMin, rect.yMin) || region.Contains(rect.xMin, rect.yMax) || region.Contains(rect.xMax, rect.yMin) || region.Contains(rect.xMax, rect.yMax))
					{
						return true;
					}
				}
				return false;
			}
		}

		private const float space = 4f;

		private const float tab_start_x = 87.4f;

		private const float assumed_button_size = 32f;

		private static readonly RectTransform _empty_button_placehold = new GameObject("Empty Button Placehold", typeof(RectTransform)).GetComponent<RectTransform>();

		private static readonly float[] available_y = new float[2] { 18f, -18f };

		private Queue<GameObject> _active_lines;

		private Queue<GameObject> _inactive_lines;

		private Dictionary<string, List<PowerButton>> ButtonGroups;

		private Dictionary<string, List<WrappedRectTransform>> CustomRectGroups;

		public bool Modifiable;

		public PowersTab Tab;

		public WrappedPowersTab(PowersTab pPowersTab)
		{
			Tab = pPowersTab;
			Modifiable = !PowerTabNames.GetNames().Contains(Tab.name);
			ButtonGroups = new Dictionary<string, List<PowerButton>>();
			CustomRectGroups = new Dictionary<string, List<WrappedRectTransform>>();
			AddGroup("Default");
			_inactive_lines = new Queue<GameObject>();
			_active_lines = new Queue<GameObject>();
		}

		internal void RecordLine(GameObject line)
		{
			_active_lines.Enqueue(line);
		}

		public static void _init()
		{
			_empty_button_placehold.SetParent(WorldBoxMod.Transform);
		}

		public bool HasGroup(string pGroupId)
		{
			return ButtonGroups.ContainsKey(pGroupId);
		}

		public void AddPowerButton(string pGroupId, PowerButton pPowerButton)
		{
			List<PowerButton> list = ButtonGroups[pGroupId];
			if (pPowerButton != null)
			{
				Transform transform;
				(transform = pPowerButton.transform).SetParent(Tab.transform);
				transform.localScale = Vector3.one;
			}
			list.Add(pPowerButton);
		}

		public void AddCustomRect(string pGroupId, RectTransform pRect, Vector2 pPositionInGroup, bool pPlacehold)
		{
			List<WrappedRectTransform> list = CustomRectGroups[pGroupId];
			pRect.SetParent(Tab.transform);
			pRect.localScale = Vector3.one;
			list.Add(new WrappedRectTransform(pRect, pPositionInGroup, pPlacehold));
		}

		public void AddGroup(string pGroupId)
		{
			ButtonGroups.Add(pGroupId, new List<PowerButton>());
			CustomRectGroups.Add(pGroupId, new List<WrappedRectTransform>());
		}

		public void ResetGroups()
		{
			ButtonGroups.Clear();
		}

		public void UpdateLayout()
		{
			foreach (GameObject active_line in _active_lines)
			{
				active_line.SetActive(value: false);
				_inactive_lines.Enqueue(active_line);
			}
			float num = 87.4f;
			bool flag = true;
			foreach (string key in ButtonGroups.Keys)
			{
				List<PowerButton> list = ButtonGroups[key];
				List<WrappedRectTransform> list2 = CustomRectGroups[key];
				if (list.Count <= 0 && list2.Count <= 0)
				{
					continue;
				}
				num += 8f;
				if (!flag)
				{
					_add_line(num);
				}
				else
				{
					flag = false;
				}
				num += 8f;
				PlaceholdRegions placeholdRegions = new PlaceholdRegions();
				foreach (WrappedRectTransform item in list2)
				{
					item.Rect.localPosition = item.PositionInGroup + new Vector2(num, 0f);
					if (item.Placehold)
					{
						placeholdRegions.AddRegion(item.Rect);
					}
				}
				bool flag2 = true;
				foreach (PowerButton item2 in list)
				{
					RectTransform rectTransform = ((item2 == null) ? _empty_button_placehold : item2.GetComponent<RectTransform>());
					if (item2 == null)
					{
						rectTransform.sizeDelta = new Vector2(32f, 32f);
						rectTransform.pivot = new Vector2(0.5f, 0.5f);
					}
					bool flag3 = false;
					while (!flag3)
					{
						if (flag2)
						{
							num += 16f;
							rectTransform.localPosition = new Vector3(num, available_y[0]);
							flag2 = false;
							if (!placeholdRegions.Overlap(rectTransform))
							{
								flag3 = true;
							}
						}
						else
						{
							rectTransform.localPosition = new Vector3(num, available_y[1]);
							flag2 = true;
							num += 20f;
							if (!placeholdRegions.Overlap(rectTransform))
							{
								flag3 = true;
							}
						}
					}
				}
				num = ((!flag2) ? (num + 16f) : (num + 4f));
			}
			Tab._power_buttons.Clear();
			PowerButton[] componentsInChildren = Tab.GetComponentsInChildren<PowerButton>();
			foreach (PowerButton powerButton in componentsInChildren)
			{
				if (!(powerButton == null) && !(powerButton.rect_transform == null))
				{
					Tab._power_buttons.Add(powerButton);
				}
			}
			foreach (PowerButton power_button in Tab._power_buttons)
			{
				power_button.findNeighbours(Tab._power_buttons, pCheckForActive: false);
			}
		}

		private void _add_line(float pX)
		{
			GameObject gameObject;
			if (_inactive_lines.Count > 0)
			{
				gameObject = _inactive_lines.Dequeue();
			}
			else
			{
				gameObject = UnityEngine.Object.Instantiate(ResourcesFinder.FindResource<GameObject>("_line"), Tab.transform);
				gameObject.GetComponent<UnityEngine.UI.Image>().enabled = true;
				gameObject.transform.localScale = new Vector3(1f, 48.3f, 1f);
			}
			gameObject.SetActive(value: true);
			gameObject.transform.localPosition = new Vector3(pX, 37.2f);
			_active_lines.Enqueue(gameObject);
		}
	}
}
namespace NeoModLoader.General.UI.Prefabs
{
	public abstract class APrefab<T> : MonoBehaviour where T : APrefab<T>
	{
		private static T mPrefab;

		protected bool Initialized;

		public static T Prefab
		{
			get
			{
				if (mPrefab == null)
				{
					if (OtherUtils.CalledBy("_init", typeof(T), pSearchAll: true))
					{
						return null;
					}
					typeof(T).GetMethod("_init", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)?.Invoke(null, null);
				}
				return mPrefab;
			}
			protected set
			{
				mPrefab = value;
			}
		}

		public static T Instantiate(Transform pParent = null, bool pWorldPositionStays = false, string pName = null)
		{
			T val = UnityEngine.Object.Instantiate(Prefab, pParent, pWorldPositionStays);
			if (!string.IsNullOrEmpty(pName))
			{
				val.name = pName;
			}
			return val;
		}

		public virtual void SetSize(Vector2 pSize)
		{
			RectTransform component = GetComponent<RectTransform>();
			if (!(component == null))
			{
				component.sizeDelta = pSize;
			}
		}

		protected virtual void Init()
		{
			if (!Initialized)
			{
				Initialized = true;
			}
		}
	}
	public class SimpleButton : APrefab<SimpleButton>
	{
		[SerializeField]
		private Button button;

		[SerializeField]
		private TipButton tipButton;

		[SerializeField]
		private UnityEngine.UI.Image background;

		[SerializeField]
		private UnityEngine.UI.Image icon;

		[SerializeField]
		private Text text;

		public Button Button => button;

		public TipButton TipButton => tipButton;

		public UnityEngine.UI.Image Background => background;

		public UnityEngine.UI.Image Icon => icon;

		public Text Text => text;

		private void Awake()
		{
			if (!Initialized)
			{
				Init();
			}
		}

		public void Setup(UnityAction pClickAction, Sprite pIcon, string pText = null, Vector2 pSize = default(Vector2), string pTipType = null, TooltipData pTipData = null)
		{
			if (pSize == default(Vector2))
			{
				pSize = new Vector2(32f, 32f);
			}
			SetSize(pSize);
			if (string.IsNullOrEmpty(pText))
			{
				Text.gameObject.SetActive(value: false);
				Icon.gameObject.SetActive(value: true);
			}
			else
			{
				Icon.gameObject.SetActive(value: false);
				Text.gameObject.SetActive(value: true);
			}
			Icon.sprite = pIcon;
			Text.text = pText;
			Button.onClick.RemoveAllListeners();
			Button.onClick.AddListener(pClickAction);
			if (string.IsNullOrEmpty(pTipType))
			{
				TipButton.enabled = false;
				return;
			}
			TipButton.enabled = true;
			TipButton.type = pTipType;
			if (string.IsNullOrEmpty(pTipData.tip_name))
			{
				TipButton.hoverAction = TipButton.showTooltipDefault;
				return;
			}
			TipButton.hoverAction = delegate
			{
				Tooltip.show(base.gameObject, TipButton.type, pTipData);
				base.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
				base.transform.DOKill();
				base.transform.DOScale(1f, 0.1f).SetEase(Ease.InBack);
			};
		}

		public override void SetSize(Vector2 pSize)
		{
			GetComponent<RectTransform>().sizeDelta = pSize;
			float num = Mathf.Min(pSize.x, pSize.y);
			Icon.GetComponent<RectTransform>().sizeDelta = new Vector2(num, num) * 0.875f;
			Text.GetComponent<RectTransform>().sizeDelta = pSize * 0.875f;
		}

		internal static void _init()
		{
			GameObject gameObject = new GameObject("SimpleButton", typeof(Button), typeof(UnityEngine.UI.Image), typeof(TipButton));
			gameObject.transform.SetParent(WorldBoxMod.Transform);
			gameObject.GetComponent<TipButton>().enabled = false;
			gameObject.GetComponent<UnityEngine.UI.Image>().sprite = SpriteTextureLoader.getSprite("ui/special/special_buttonRed");
			gameObject.GetComponent<UnityEngine.UI.Image>().type = UnityEngine.UI.Image.Type.Sliced;
			GameObject gameObject2 = new GameObject("Icon", typeof(UnityEngine.UI.Image));
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.transform.localPosition = Vector3.zero;
			gameObject2.transform.localScale = Vector3.one;
			GameObject gameObject3 = new GameObject("Text", typeof(Text));
			gameObject3.transform.SetParent(gameObject.transform);
			gameObject3.transform.localPosition = Vector3.zero;
			gameObject3.transform.localScale = Vector3.one;
			Text component = gameObject3.GetComponent<Text>();
			component.font = LocalizedTextManager.current_font;
			component.color = UnityEngine.Color.white;
			component.resizeTextForBestFit = true;
			component.resizeTextMinSize = 1;
			component.resizeTextMaxSize = 10;
			component.alignment = TextAnchor.MiddleCenter;
			gameObject3.SetActive(value: false);
			APrefab<SimpleButton>.Prefab = gameObject.AddComponent<SimpleButton>();
			APrefab<SimpleButton>.Prefab.button = gameObject.GetComponent<Button>();
			APrefab<SimpleButton>.Prefab.tipButton = gameObject.GetComponent<TipButton>();
			APrefab<SimpleButton>.Prefab.background = gameObject.GetComponent<UnityEngine.UI.Image>();
			APrefab<SimpleButton>.Prefab.icon = gameObject2.GetComponent<UnityEngine.UI.Image>();
			APrefab<SimpleButton>.Prefab.text = component;
		}
	}
	public class SimpleStatBar : APrefab<SimpleStatBar>
	{
		[SerializeField]
		private UnityEngine.UI.Image _background;

		[SerializeField]
		private UnityEngine.UI.Image _bar;

		[SerializeField]
		private UnityEngine.UI.Image _icon;

		[SerializeField]
		private StatBar _stat_bar;

		public UnityEngine.UI.Image background => _background;

		public UnityEngine.UI.Image bar => _bar;

		public UnityEngine.UI.Image icon => _icon;

		public StatBar stat_bar => _stat_bar;

		public virtual void Setup(float value, float max_value, string pEndText, Sprite pIcon, Sprite pBackground, UnityEngine.Color pBarColor, Vector2 pSize, bool pReset = true, bool pFloat = false, bool pUpdateText = true, float pSpeed = 0.3f)
		{
			if (!Initialized)
			{
				Init();
			}
			icon.sprite = pIcon;
			background.sprite = pBackground;
			if (pBackground == null)
			{
				background.enabled = false;
			}
			else
			{
				background.enabled = true;
			}
			GetComponent<RectTransform>().sizeDelta = pSize;
			Vector2 sizeDelta = pSize - new Vector2(pSize.y + 4f, pSize.y * 0.3f);
			base.transform.Find("Background").GetComponent<RectTransform>().sizeDelta = sizeDelta;
			base.transform.Find("Background").localPosition = new Vector3((pSize.x - sizeDelta.x) / 2f - pSize.x * 0.02f, 0f);
			base.transform.Find("Mask").GetComponent<RectTransform>().sizeDelta = sizeDelta;
			base.transform.Find("Mask").localPosition = new Vector3((pSize.x - sizeDelta.x) / 2f - pSize.x * 0.02f - sizeDelta.x / 2f, 0f);
			bar.GetComponent<RectTransform>().sizeDelta = sizeDelta;
			bar.transform.localPosition = new Vector3(sizeDelta.x / 2f, 0f);
			icon.transform.localPosition = new Vector3((0f - pSize.x) / 2f + pSize.y / 2f, 0f, 0f);
			icon.GetComponent<RectTransform>().sizeDelta = new Vector2(pSize.y, pSize.y);
			base.transform.Find("Text").GetComponent<RectTransform>().sizeDelta = new Vector2(sizeDelta.x, sizeDelta.y);
			base.transform.Find("Text").localPosition = new Vector3((pSize.x - sizeDelta.x) / 2f - pSize.x * 0.02f, 0f);
			UpdateBar(value, max_value, pEndText, pBarColor, pReset, pFloat, pUpdateText, pSpeed);
		}

		public void UpdateBar(float value, float max_value, string pEndText, UnityEngine.Color pBarColor = default(UnityEngine.Color), bool pReset = true, bool pFloat = false, bool pUpdateText = true, float pSpeed = 0.3f)
		{
			if (!Initialized)
			{
				Init();
			}
			if (pBarColor != default(UnityEngine.Color))
			{
				bar.color = pBarColor;
			}
			stat_bar.setBar(value, max_value, pEndText, pReset, pFloat, pUpdateText, pSpeed);
		}

		internal static void _init()
		{
			GameObject gameObject = new GameObject("SimpleStatBar", typeof(Button), typeof(TipButton), typeof(UnityEngine.UI.Image));
			gameObject.transform.SetParent(WorldBoxMod.Transform);
			gameObject.transform.localScale = Vector3.one;
			gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(100f, 14f);
			gameObject.GetComponent<UnityEngine.UI.Image>().type = UnityEngine.UI.Image.Type.Sliced;
			GameObject gameObject2 = new GameObject("Background", typeof(UnityEngine.UI.Image));
			gameObject2.transform.SetParent(gameObject.transform);
			UnityEngine.UI.Image component = gameObject2.GetComponent<UnityEngine.UI.Image>();
			component.sprite = SpriteTextureLoader.getSprite("ui/special/windowInnerSliced");
			component.type = UnityEngine.UI.Image.Type.Sliced;
			component.color = new UnityEngine.Color(0.49f, 0.49f, 0.49f);
			GameObject gameObject3 = new GameObject("Mask", typeof(UnityEngine.UI.Image), typeof(Mask));
			gameObject3.transform.SetParent(gameObject.transform);
			Mask component2 = gameObject3.GetComponent<Mask>();
			component2.showMaskGraphic = false;
			gameObject3.GetComponent<RectTransform>().pivot = new Vector2(0f, 0.5f);
			gameObject3.GetComponent<RectTransform>().anchorMax = new Vector2(0f, 0.5f);
			gameObject3.GetComponent<RectTransform>().anchorMin = new Vector2(0f, 0.5f);
			GameObject gameObject4 = new GameObject("Bar", typeof(UnityEngine.UI.Image));
			gameObject4.transform.SetParent(gameObject3.transform);
			UnityEngine.UI.Image component3 = gameObject4.GetComponent<UnityEngine.UI.Image>();
			component3.sprite = SpriteTextureLoader.getSprite("ui/special/windowBar");
			component3.type = UnityEngine.UI.Image.Type.Sliced;
			gameObject4.GetComponent<RectTransform>().anchorMax = new Vector2(0f, 0.5f);
			gameObject4.GetComponent<RectTransform>().anchorMin = new Vector2(0f, 0.5f);
			GameObject gameObject5 = new GameObject("Icon", typeof(UnityEngine.UI.Image), typeof(Shadow));
			gameObject5.transform.SetParent(gameObject.transform);
			UnityEngine.UI.Image component4 = gameObject5.GetComponent<UnityEngine.UI.Image>();
			component4.sprite = SpriteTextureLoader.getSprite("ui/icons/iconHealth");
			GameObject gameObject6 = new GameObject("Text", typeof(Text), typeof(Shadow));
			gameObject6.transform.SetParent(gameObject.transform);
			Text component5 = gameObject6.GetComponent<Text>();
			component5.text = "0/0";
			component5.resizeTextForBestFit = true;
			component5.resizeTextMaxSize = 10;
			component5.resizeTextMinSize = 1;
			component5.alignment = TextAnchor.UpperCenter;
			component5.color = UnityEngine.Color.white;
			component5.font = LocalizedTextManager.current_font;
			gameObject.SetActive(value: false);
			StatBar statBar = gameObject.AddComponent<StatBar>();
			statBar.textField = component5;
			statBar.mask = gameObject3.GetComponent<RectTransform>();
			statBar.bar = gameObject2.GetComponent<RectTransform>();
			gameObject.SetActive(value: true);
			APrefab<SimpleStatBar>.Prefab = gameObject.AddComponent<SimpleStatBar>();
			APrefab<SimpleStatBar>.Prefab._background = component;
			APrefab<SimpleStatBar>.Prefab._bar = component3;
			APrefab<SimpleStatBar>.Prefab._icon = component4;
			APrefab<SimpleStatBar>.Prefab._stat_bar = statBar;
		}
	}
	public class SliderBar : APrefab<SliderBar>
	{
		[SerializeField]
		private Slider _slider;

		[SerializeField]
		private TipButton _tip_button;

		public Slider slider => _slider;

		public TipButton tip_button => _tip_button;

		private void Awake()
		{
			if (!Initialized)
			{
				Init();
			}
		}

		public void Setup(float value, float min, float max, UnityAction<float> value_update, Vector2 size = default(Vector2), bool whole_numbers = false)
		{
			if (!Initialized)
			{
				Init();
			}
			slider.onValueChanged.RemoveAllListeners();
			slider.minValue = min;
			slider.maxValue = max;
			slider.value = value;
			slider.wholeNumbers = whole_numbers;
			slider.onValueChanged.AddListener(value_update);
			if (size != default(Vector2))
			{
				SetSize(size);
			}
		}

		public override void SetSize(Vector2 size)
		{
			if (!Initialized)
			{
				Init();
			}
			GetComponent<RectTransform>().sizeDelta = size;
			base.transform.Find("Background").GetComponent<RectTransform>().sizeDelta = size - new Vector2(0f, 10f);
			base.transform.Find("Fill Area").GetComponent<RectTransform>().sizeDelta = size - new Vector2(0f, 10f);
			base.transform.Find("Fill Area/Fill").GetComponent<RectTransform>().sizeDelta = Vector2.zero;
			base.transform.Find("Handle Slide Area").GetComponent<RectTransform>().sizeDelta = size - new Vector2(10f, 0f);
			base.transform.Find("Handle Slide Area/Handle").GetComponent<RectTransform>().sizeDelta = new Vector2(20f, 0f);
		}

		internal static void _init()
		{
			GameObject gameObject = new GameObject("SliderBar", typeof(Slider), typeof(TipButton));
			gameObject.transform.SetParent(WorldBoxMod.Transform);
			gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(172f, 20f);
			GameObject gameObject2 = new GameObject("Background", typeof(UnityEngine.UI.Image));
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.transform.localScale = Vector3.one;
			gameObject2.GetComponent<RectTransform>().sizeDelta = new Vector2(0f, 0f);
			gameObject2.GetComponent<UnityEngine.UI.Image>().sprite = SpriteTextureLoader.getSprite("ui/special/special_buttonGray");
			gameObject2.GetComponent<UnityEngine.UI.Image>().type = UnityEngine.UI.Image.Type.Sliced;
			GameObject gameObject3 = new GameObject("Fill Area", typeof(RectTransform));
			gameObject3.transform.SetParent(gameObject.transform);
			gameObject3.transform.localScale = Vector3.one;
			gameObject3.GetComponent<RectTransform>().sizeDelta = new Vector2(-20f, 0f);
			GameObject gameObject4 = new GameObject("Fill", typeof(UnityEngine.UI.Image));
			gameObject4.transform.SetParent(gameObject3.transform);
			gameObject4.transform.localScale = Vector3.one;
			gameObject4.GetComponent<RectTransform>().sizeDelta = new Vector2(10f, 0f);
			gameObject4.GetComponent<UnityEngine.UI.Image>().sprite = SpriteTextureLoader.getSprite("ui/special/special_buttonRed");
			gameObject4.GetComponent<UnityEngine.UI.Image>().type = UnityEngine.UI.Image.Type.Sliced;
			GameObject gameObject5 = new GameObject("Handle Slide Area", typeof(RectTransform));
			gameObject5.transform.SetParent(gameObject.transform);
			gameObject5.transform.localScale = Vector3.one;
			gameObject5.GetComponent<RectTransform>().sizeDelta = new Vector2(-20f, 0f);
			GameObject gameObject6 = new GameObject("Handle", typeof(UnityEngine.UI.Image));
			gameObject6.transform.SetParent(gameObject5.transform);
			gameObject6.transform.localScale = Vector3.one;
			gameObject6.GetComponent<UnityEngine.UI.Image>().sprite = SpriteTextureLoader.getSprite("ui/special/special_buttonRed");
			gameObject6.GetComponent<UnityEngine.UI.Image>().type = UnityEngine.UI.Image.Type.Sliced;
			gameObject6.GetComponent<RectTransform>().sizeDelta = new Vector2(20f, 0f);
			APrefab<SliderBar>.Prefab = gameObject.AddComponent<SliderBar>();
			Slider component = gameObject.GetComponent<Slider>();
			component.fillRect = gameObject4.GetComponent<RectTransform>();
			component.handleRect = gameObject6.GetComponent<RectTransform>();
			component.targetGraphic = gameObject6.GetComponent<UnityEngine.UI.Image>();
			component.direction = Slider.Direction.LeftToRight;
			component.interactable = true;
			APrefab<SliderBar>.Prefab._slider = component;
			APrefab<SliderBar>.Prefab._tip_button = gameObject.GetComponent<TipButton>();
		}
	}
	public class SwitchButton : APrefab<SwitchButton>
	{
		[SerializeField]
		private Button _button;

		[SerializeField]
		private UnityEngine.UI.Image _icon;

		[SerializeField]
		private Text _text;

		[SerializeField]
		private TipButton _tip_button;

		public Button button => _button;

		public UnityEngine.UI.Image icon => _icon;

		public Text text => _text;

		public TipButton tip_button => _tip_button;

		private void Awake()
		{
			if (!Initialized)
			{
				Init();
			}
		}

		public void Setup(bool value, Action value_update)
		{
			if (!Initialized)
			{
				Init();
			}
			icon.sprite = (value ? SpriteTextureLoader.getSprite("ui/icons/iconOn") : SpriteTextureLoader.getSprite("ui/icons/iconOff"));
			text.text = (value ? LM.Get("short_on") : LM.Get("short_off"));
			button.onClick.RemoveAllListeners();
			button.onClick.AddListener(delegate
			{
				value_update();
				Setup(!value, value_update);
			});
		}

		internal static void _init()
		{
			GameObject gameObject = new GameObject("SwitchButton", typeof(UnityEngine.UI.Image), typeof(Button), typeof(TipButton), typeof(HorizontalLayoutGroup));
			gameObject.transform.SetParent(WorldBoxMod.Transform);
			gameObject.transform.localScale = Vector3.one;
			gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(50f, 18f);
			HorizontalLayoutGroup component = gameObject.GetComponent<HorizontalLayoutGroup>();
			component.childControlWidth = false;
			component.childControlHeight = false;
			component.childAlignment = TextAnchor.MiddleCenter;
			gameObject.GetComponent<UnityEngine.UI.Image>().sprite = SpriteTextureLoader.getSprite("ui/special/special_buttonRed");
			gameObject.GetComponent<UnityEngine.UI.Image>().type = UnityEngine.UI.Image.Type.Sliced;
			GameObject gameObject2 = new GameObject("Icon", typeof(UnityEngine.UI.Image));
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.transform.localScale = Vector3.one;
			gameObject2.GetComponent<RectTransform>().sizeDelta = new Vector2(18f, 18f);
			GameObject gameObject3 = new GameObject("Text", typeof(Text));
			gameObject3.transform.SetParent(gameObject.transform);
			gameObject3.transform.localScale = Vector3.one;
			gameObject3.GetComponent<RectTransform>().sizeDelta = new Vector2(24f, 18f);
			Text component2 = gameObject3.GetComponent<Text>();
			component2.resizeTextForBestFit = true;
			OT.InitializeCommonText(component2);
			component2.alignment = TextAnchor.MiddleCenter;
			APrefab<SwitchButton>.Prefab = gameObject.AddComponent<SwitchButton>();
			APrefab<SwitchButton>.Prefab._button = gameObject.GetComponent<Button>();
			APrefab<SwitchButton>.Prefab._icon = gameObject2.GetComponent<UnityEngine.UI.Image>();
			APrefab<SwitchButton>.Prefab._text = gameObject3.GetComponent<Text>();
			APrefab<SwitchButton>.Prefab._tip_button = gameObject.GetComponent<TipButton>();
		}
	}
	public class TextInput : APrefab<TextInput>
	{
		[SerializeField]
		private UnityEngine.UI.Image _icon;

		[SerializeField]
		private InputField _input;

		[SerializeField]
		private Text _text;

		[SerializeField]
		private TipButton _tip_button;

		public UnityEngine.UI.Image icon => _icon;

		public InputField input => _input;

		public Text text => _text;

		public TipButton tip_button => _tip_button;

		private void Awake()
		{
			if (!Initialized)
			{
				Init();
			}
		}

		public virtual void Setup(string value, UnityAction<string> value_update, Sprite pIcon = null, Sprite pBackground = null)
		{
			if (!Initialized)
			{
				Init();
			}
			input.onEndEdit.RemoveAllListeners();
			input.text = value;
			input.onEndEdit.AddListener(value_update);
			if (pIcon == null)
			{
				icon.sprite = SpriteTextureLoader.getSprite("ui/special/inputFieldIcon");
			}
			else
			{
				icon.sprite = pIcon;
			}
			if (pBackground == null)
			{
				GetComponent<UnityEngine.UI.Image>().sprite = SpriteTextureLoader.getSprite("ui/special/darkInputFieldEmpty");
			}
			else
			{
				GetComponent<UnityEngine.UI.Image>().sprite = pBackground;
			}
		}

		public override void SetSize(Vector2 size)
		{
			if (!Initialized)
			{
				Init();
			}
			GetComponent<RectTransform>().sizeDelta = size;
			text.GetComponent<RectTransform>().sizeDelta = size - new Vector2(size.y / 2f + 4f, 2f);
			icon.GetComponent<RectTransform>().sizeDelta = new Vector2(size.y, size.y) - new Vector2(2f, 2f);
			text.transform.localPosition = new Vector3((0f - size.x) / 2f, 0f);
			icon.transform.localPosition = new Vector3((size.x - size.y / 2f) / 2f, 0f);
		}

		internal static void _init()
		{
			GameObject gameObject = new GameObject("TextInput", typeof(TipButton), typeof(UnityEngine.UI.Image));
			gameObject.transform.SetParent(WorldBoxMod.Transform);
			UnityEngine.UI.Image component = gameObject.GetComponent<UnityEngine.UI.Image>();
			component.sprite = SpriteTextureLoader.getSprite("ui/special/darkInputFieldEmpty");
			component.type = UnityEngine.UI.Image.Type.Sliced;
			GameObject gameObject2 = new GameObject("InputField", typeof(Text), typeof(InputField));
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.transform.localScale = Vector3.one;
			gameObject2.GetComponent<RectTransform>().pivot = new Vector2(0f, 0.5f);
			Text component2 = gameObject2.GetComponent<Text>();
			OT.InitializeCommonText(component2);
			component2.alignment = TextAnchor.MiddleLeft;
			component2.resizeTextForBestFit = true;
			InputField component3 = gameObject2.GetComponent<InputField>();
			component3.textComponent = component2;
			component3.text = "";
			component3.lineType = InputField.LineType.SingleLine;
			GameObject gameObject3 = new GameObject("Icon", typeof(UnityEngine.UI.Image));
			gameObject3.transform.SetParent(gameObject.transform);
			gameObject3.transform.localScale = Vector3.one;
			gameObject3.GetComponent<UnityEngine.UI.Image>().sprite = SpriteTextureLoader.getSprite("ui/special/inputFieldIcon");
			APrefab<TextInput>.Prefab = gameObject.AddComponent<TextInput>();
			APrefab<TextInput>.Prefab._icon = gameObject3.GetComponent<UnityEngine.UI.Image>();
			APrefab<TextInput>.Prefab._input = component3;
			APrefab<TextInput>.Prefab._text = component2;
			APrefab<TextInput>.Prefab._tip_button = gameObject.GetComponent<TipButton>();
		}
	}
}
namespace NeoModLoader.General.Game.extensions
{
	public static class AssetExtension
	{
		public static void ForEach<TAsset, TLibrary>(this TLibrary pLibrary, Action<TAsset> pAction) where TAsset : Asset where TLibrary : AssetLibrary<TAsset>
		{
			AssetExtensionInternal<TAsset, TLibrary>.ForEach(pLibrary, pAction);
		}
	}
	internal static class AssetExtensionInternal<TAsset, TLibrary> where TAsset : Asset where TLibrary : AssetLibrary<TAsset>
	{
		private class LibraryState
		{
			public readonly HashSet<string> done = new HashSet<string>();

			public Action<TAsset> action;
		}

		private static readonly Dictionary<TLibrary, List<LibraryState>> _states = new Dictionary<TLibrary, List<LibraryState>>();

		private static bool _assetlibrary_patched;

		public static void ForEach(TLibrary pLibrary, Action<TAsset> pAction)
		{
			if (pLibrary == null)
			{
				return;
			}
			LibraryState libraryState = new LibraryState();
			foreach (TAsset item in pLibrary.list)
			{
				pAction(item);
			}
			libraryState.action = delegate(TAsset asset)
			{
				pAction(asset);
			};
			libraryState.done.UnionWith(pLibrary.list.Select((TAsset x) => x.id));
			if (!_states.ContainsKey(pLibrary))
			{
				_states.Add(pLibrary, new List<LibraryState>());
			}
			_states[pLibrary].Add(libraryState);
			if (!_assetlibrary_patched)
			{
				_assetlibrary_patched = true;
				new Harmony("NeoModLoader.ForEach").Patch(AccessTools.Method(typeof(AssetLibrary<TAsset>), "add"), null, new HarmonyMethod(AccessTools.FirstMethod(typeof(AssetExtensionInternal<TAsset, TLibrary>), (MethodInfo x) => x.Name.Contains("AppendAssetToAction"))));
			}
		}

		private static void AppendAssetToAction(TLibrary __instance, TAsset pAsset)
		{
			if (!_states.TryGetValue(__instance, out var value))
			{
				return;
			}
			foreach (LibraryState item in value)
			{
				if (!item.done.Add(pAsset.id))
				{
					break;
				}
				item.action(pAsset);
			}
		}
	}
	public static class DataExtension
	{
		public static bool TryGet<TCustomData>(this BaseSystemData data, string key, out TCustomData result) where TCustomData : ICustomData, new()
		{
			result = new TCustomData();
			data.get(key, out var pResult, null);
			if (pResult == null)
			{
				return false;
			}
			JObject jObject;
			try
			{
				jObject = JObject.Parse(pResult);
			}
			catch (JsonReaderException)
			{
				return false;
			}
			SerializedCustomData serializedCustomData = jObject.ToObject<SerializedCustomData>();
			if (serializedCustomData == null)
			{
				return false;
			}
			result.Deserialize(serializedCustomData);
			return true;
		}

		public static void Set<TCustomData>(this BaseSystemData data, string key, TCustomData value) where TCustomData : ICustomData
		{
			data.set(key, JsonConvert.SerializeObject(value.Serialize()));
		}
	}
	public class SerializedCustomData
	{
		public string ModId;

		public string DataVersion;

		public JObject Data;

		public SerializedCustomData(string modId, string dataVersion, JObject data)
		{
			ModId = modId;
			DataVersion = dataVersion;
			Data = data;
		}
	}
	public interface ICustomData
	{
		SerializedCustomData Serialize();

		void Deserialize(SerializedCustomData data);
	}
	public sealed class BasicCustomData<TDataClass> : ICustomData where TDataClass : class, new()
	{
		public TDataClass Data { get; private set; } = new TDataClass();

		public BasicCustomData(TDataClass data)
		{
			if (data != null)
			{
				Data = data;
			}
		}

		public BasicCustomData()
			: this((TDataClass)null)
		{
		}

		public SerializedCustomData Serialize()
		{
			return new SerializedCustomData("UNKNOWN", "NO-VERSIONING-SUPPORT", JObject.FromObject(Data));
		}

		public void Deserialize(SerializedCustomData data)
		{
			if (data.ModId != "UNKNOWN" || data.DataVersion != "NO-VERSIONING-SUPPORT")
			{
				throw new Exception("Supplied data object is not compatible with the basic custom data serializer, mod ID or version mismatch");
			}
			Data = data.Data.ToObject<TDataClass>();
		}
	}
}
namespace NeoModLoader.General.Event
{
	public abstract class AbstractHandler<THandler> where THandler : AbstractHandler<THandler>
	{
		private int error_hit = 0;

		public bool enabled { get; private set; } = true;

		internal void HitException()
		{
			error_hit++;
			if (error_hit > 10)
			{
				enabled = false;
			}
		}
	}
	public abstract class BaseListener
	{
	}
	public abstract class AbstractListener<TListener, THandler> : BaseListener where TListener : AbstractListener<TListener, THandler> where THandler : AbstractHandler<THandler>
	{
		private bool _patched = false;

		protected static TListener instance { get; private set; }

		protected List<THandler> handlers { get; } = new List<THandler>();

		public AbstractListener()
		{
			instance = (TListener)this;
		}

		protected static void InsertCallHandleCode(List<CodeInstruction> codes, int pos)
		{
			codes.Insert(pos, new CodeInstruction(System.Reflection.Emit.OpCodes.Call, AccessTools.Method(typeof(TListener), "HandleAll")));
		}

		public static void RegisterHandler(THandler handler)
		{
			if (!instance._patched)
			{
				instance._patched = true;
				Type type = instance.GetType();
				try
				{
					Harmony.CreateAndPatchAll(type, type.FullName);
				}
				catch (Exception ex)
				{
					LogService.LogError("Failed to patch listener: " + type.FullName + ", with handler: " + handler.GetType().FullName);
					LogService.LogError(ex.Message);
					LogService.LogError(ex.StackTrace);
					return;
				}
			}
			instance.handlers.Add(handler);
		}
	}
	internal static class ListenerManager
	{
		private static readonly string ListenerNamespace = "NeoModLoader.General.Event.Listeners";

		private static readonly HashSet<BaseListener> _listeners = new HashSet<BaseListener>();

		public static void _init()
		{
			Type[] types = Assembly.GetExecutingAssembly().GetTypes();
			Type[] array = types;
			foreach (Type type in array)
			{
				if (type.Namespace != ListenerNamespace)
				{
					continue;
				}
				try
				{
					ConstructorInfo constructor = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, new Type[0], null);
					if (constructor == null)
					{
						LogService.LogWarning("Cannot find constructor of " + type.FullName);
					}
					else if (!(constructor.Invoke(null) is BaseListener item))
					{
						LogService.LogWarning("Failed to construct listener instance of " + type.FullName);
					}
					else
					{
						_listeners.Add(item);
					}
				}
				catch (Exception ex)
				{
					LogService.LogError("Failed to patch listener: " + type.FullName);
					LogService.LogError(ex.Message);
					LogService.LogError(ex.StackTrace);
				}
			}
		}
	}
}
namespace NeoModLoader.General.Event.Listeners
{
	public class ActorTryToAttackListener : AbstractListener<ActorTryToAttackListener, ActorTryToAttackHandler>
	{
		protected static void HandleAll(Actor pAttacker, BaseSimObject pTarget, CombatActionAsset pCombatActionAsset, AttackData pAttackData)
		{
			StringBuilder stringBuilder = null;
			int i = 0;
			int count = AbstractListener<ActorTryToAttackListener, ActorTryToAttackHandler>.instance.handlers.Count;
			bool flag = false;
			while (!flag)
			{
				try
				{
					for (; i < count; i++)
					{
						AbstractListener<ActorTryToAttackListener, ActorTryToAttackHandler>.instance.handlers[i].Handle(pAttacker, pTarget, pCombatActionAsset, pAttackData);
					}
					flag = true;
				}
				catch (Exception ex)
				{
					AbstractListener<ActorTryToAttackListener, ActorTryToAttackHandler>.instance.handlers[i].HitException();
					if (stringBuilder == null)
					{
						stringBuilder = new StringBuilder();
					}
					stringBuilder.AppendLine("Failed to handle event in " + AbstractListener<ActorTryToAttackListener, ActorTryToAttackHandler>.instance.handlers[i].GetType().FullName);
					stringBuilder.AppendLine(ex.Message);
					stringBuilder.AppendLine(ex.StackTrace);
					i++;
				}
			}
			if (stringBuilder != null)
			{
				LogService.LogError(stringBuilder.ToString());
			}
		}

		[HarmonyTranspiler]
		[HarmonyPatch(typeof(Actor), "tryToAttack")]
		private static IEnumerable<CodeInstruction> _tryToAttack_Patch(IEnumerable<CodeInstruction> instr)
		{
			List<CodeInstruction> list = new List<CodeInstruction>(instr);
			int pos = list.FindIndex((CodeInstruction x) => x.opcode == System.Reflection.Emit.OpCodes.Stloc_S && ((LocalBuilder)x.operand).LocalIndex == 7) - 1;
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_0));
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_1));
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldloc_S, 6));
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldloc_S, 4));
			AbstractListener<ActorTryToAttackListener, ActorTryToAttackHandler>.InsertCallHandleCode(list, pos);
			return list;
		}
	}
	public class AllianceCreateListener : AbstractListener<AllianceCreateListener, AllianceCreateHandler>
	{
		protected static void HandleAll(Alliance pAlliance, Kingdom pKingdom, Kingdom pKingdom2)
		{
			StringBuilder stringBuilder = null;
			int i = 0;
			int count = AbstractListener<AllianceCreateListener, AllianceCreateHandler>.instance.handlers.Count;
			bool flag = false;
			while (!flag)
			{
				try
				{
					for (; i < count; i++)
					{
						AbstractListener<AllianceCreateListener, AllianceCreateHandler>.instance.handlers[i].Handle(pAlliance, pKingdom, pKingdom2);
					}
					flag = true;
				}
				catch (Exception ex)
				{
					AbstractListener<AllianceCreateListener, AllianceCreateHandler>.instance.handlers[i].HitException();
					if (stringBuilder == null)
					{
						stringBuilder = new StringBuilder();
					}
					stringBuilder.AppendLine("Failed to handle event in " + AbstractListener<AllianceCreateListener, AllianceCreateHandler>.instance.handlers[i].GetType().FullName);
					stringBuilder.AppendLine(ex.Message);
					stringBuilder.AppendLine(ex.StackTrace);
					i++;
				}
			}
			if (stringBuilder != null)
			{
				LogService.LogError(stringBuilder.ToString());
			}
		}

		[HarmonyTranspiler]
		[HarmonyPatch(typeof(AllianceManager), "newAlliance")]
		private static IEnumerable<CodeInstruction> _newAllianceEvent_Patch(IEnumerable<CodeInstruction> instr)
		{
			List<CodeInstruction> list = new List<CodeInstruction>(instr);
			int pos = 9;
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Dup));
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_1));
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_2));
			AbstractListener<AllianceCreateListener, AllianceCreateHandler>.InsertCallHandleCode(list, pos);
			return list;
		}
	}
	public class CityCreateListener : AbstractListener<CityCreateListener, CityCreateHandler>
	{
		protected static void HandleAll(City pCity)
		{
			StringBuilder stringBuilder = null;
			int i = 0;
			int count = AbstractListener<CityCreateListener, CityCreateHandler>.instance.handlers.Count;
			bool flag = false;
			while (!flag)
			{
				try
				{
					for (; i < count; i++)
					{
						AbstractListener<CityCreateListener, CityCreateHandler>.instance.handlers[i].Handle(pCity);
					}
					flag = true;
				}
				catch (Exception ex)
				{
					AbstractListener<CityCreateListener, CityCreateHandler>.instance.handlers[i].HitException();
					if (stringBuilder == null)
					{
						stringBuilder = new StringBuilder();
					}
					stringBuilder.AppendLine("Failed to handle event in " + AbstractListener<CityCreateListener, CityCreateHandler>.instance.handlers[i].GetType().FullName);
					stringBuilder.AppendLine(ex.Message);
					stringBuilder.AppendLine(ex.StackTrace);
					i++;
				}
			}
			if (stringBuilder != null)
			{
				LogService.LogError(stringBuilder.ToString());
			}
		}

		[HarmonyTranspiler]
		[HarmonyPatch(typeof(City), "newCityEvent")]
		private static IEnumerable<CodeInstruction> _newCityEvent_Patch(IEnumerable<CodeInstruction> instr)
		{
			List<CodeInstruction> list = new List<CodeInstruction>(instr);
			int pos = 4;
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_0));
			AbstractListener<CityCreateListener, CityCreateHandler>.InsertCallHandleCode(list, pos);
			return list;
		}
	}
	public class ClanCreateListener : AbstractListener<ClanCreateListener, ClanCreateHandler>
	{
		protected static void HandleAll(Clan pClan, Actor pActor)
		{
			StringBuilder stringBuilder = null;
			int i = 0;
			int count = AbstractListener<ClanCreateListener, ClanCreateHandler>.instance.handlers.Count;
			bool flag = false;
			while (!flag)
			{
				try
				{
					for (; i < count; i++)
					{
						AbstractListener<ClanCreateListener, ClanCreateHandler>.instance.handlers[i].Handle(pClan, pActor);
					}
					flag = true;
				}
				catch (Exception ex)
				{
					AbstractListener<ClanCreateListener, ClanCreateHandler>.instance.handlers[i].HitException();
					if (stringBuilder == null)
					{
						stringBuilder = new StringBuilder();
					}
					stringBuilder.AppendLine("Failed to handle event in " + AbstractListener<ClanCreateListener, ClanCreateHandler>.instance.handlers[i].GetType().FullName);
					stringBuilder.AppendLine(ex.Message);
					stringBuilder.AppendLine(ex.StackTrace);
					i++;
				}
			}
			if (stringBuilder != null)
			{
				LogService.LogError(stringBuilder.ToString());
			}
		}

		[HarmonyTranspiler]
		[HarmonyPatch(typeof(ClanManager), "newClan")]
		private static IEnumerable<CodeInstruction> _newClan_Patch(IEnumerable<CodeInstruction> instr)
		{
			List<CodeInstruction> list = new List<CodeInstruction>(instr);
			int pos = 6;
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Dup));
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_1));
			AbstractListener<ClanCreateListener, ClanCreateHandler>.InsertCallHandleCode(list, pos);
			return list;
		}

		[Obsolete("Operation is not supported", true)]
		private static MethodInfo _createHandleAllMethodByIL()
		{
			MethodInfo methodInfo = AccessTools.Method(typeof(ClanCreateHandler), "Handle");
			ParameterInfo[] parameters = methodInfo.GetParameters();
			List<Type> list = new List<Type>();
			ParameterInfo[] array = parameters;
			foreach (ParameterInfo parameterInfo in array)
			{
				list.Add(parameterInfo.ParameterType);
			}
			DynamicMethod dynamicMethod = new DynamicMethod("ClanCreateListener_HandleAll", typeof(void), list.ToArray());
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Nop);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldnull);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Stloc_0);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldc_I4_0);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Stloc_1);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Call, AccessTools.PropertyGetter(typeof(ClanCreateListener), "instance"));
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Callvirt, AccessTools.PropertyGetter(typeof(ClanCreateListener), "handlers"));
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Callvirt, AccessTools.PropertyGetter(typeof(List<ClanCreateHandler>), "Count"));
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Stloc_2);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldc_I4_0);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Stloc_3);
			Label label = iLGenerator.DefineLabel();
			Label label2 = iLGenerator.DefineLabel();
			Label label3 = iLGenerator.DefineLabel();
			Label label4 = iLGenerator.DefineLabel();
			Label label5 = iLGenerator.DefineLabel();
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Br, label);
			iLGenerator.MarkLabel(label2);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Nop);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Nop);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Br_S, label3);
			iLGenerator.MarkLabel(label4);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Nop);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Call, AccessTools.PropertyGetter(typeof(ClanCreateListener), "instance"));
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Callvirt, AccessTools.PropertyGetter(typeof(ClanCreateListener), "handlers"));
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc_1);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Callvirt, AccessTools.Method(typeof(List<ClanCreateHandler>), "get_Item"));
			for (int j = 0; j < parameters.Length; j++)
			{
				iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldarg, j);
			}
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Callvirt, methodInfo);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Nop);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Nop);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc_1);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldc_I4_1);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Add);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Stloc_1);
			iLGenerator.MarkLabel(label3);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc_1);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc_2);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Clt);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Stloc_S, (byte)4);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc_S, (byte)4);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Brtrue_S, label4);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldc_I4_1);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Stloc_3);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Nop);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Leave_S, label5);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Stloc_S, (byte)5);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Nop);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Call, AccessTools.PropertyGetter(typeof(ClanCreateListener), "instance"));
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Callvirt, AccessTools.PropertyGetter(typeof(ClanCreateListener), "handlers"));
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc_1);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Callvirt, AccessTools.Method(typeof(List<ClanCreateHandler>), "get_Item"));
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Callvirt, AccessTools.Method(typeof(ClanCreateHandler), "HitException"));
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Nop);
			Label label6 = iLGenerator.DefineLabel();
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc_0);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Brtrue_S, label6);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Newobj, typeof(StringBuilder).GetConstructor(Type.EmptyTypes));
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Stloc_0);
			iLGenerator.MarkLabel(label6);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc_0);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldstr, "Failed to handle event in");
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Call, AccessTools.PropertyGetter(typeof(ClanCreateListener), "instance"));
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Callvirt, AccessTools.PropertyGetter(typeof(ClanCreateListener), "handlers"));
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc_1);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Callvirt, AccessTools.Method(typeof(List<ClanCreateHandler>), "get_Item"));
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Callvirt, AccessTools.Method(typeof(object), "GetType"));
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Callvirt, AccessTools.PropertyGetter(typeof(Type), "FullName"));
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Call, AccessTools.Method(typeof(string), "Concat", new Type[2]
			{
				typeof(string),
				typeof(string)
			}));
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Callvirt, AccessTools.Method(typeof(StringBuilder), "AppendLine", new Type[1] { typeof(string) }));
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Pop);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc_0);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc_S, (byte)5);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Callvirt, AccessTools.PropertyGetter(typeof(Exception), "Message"));
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Callvirt, AccessTools.Method(typeof(StringBuilder), "AppendLine", new Type[1] { typeof(string) }));
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Pop);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc_0);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc_S, (byte)5);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Callvirt, AccessTools.PropertyGetter(typeof(Exception), "StackTrace"));
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Callvirt, AccessTools.Method(typeof(StringBuilder), "AppendLine", new Type[1] { typeof(string) }));
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Pop);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc_1);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldc_I4_1);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Add);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Stloc_1);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Nop);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Leave_S, label5);
			iLGenerator.MarkLabel(label5);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Nop);
			iLGenerator.MarkLabel(label);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc_3);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldc_I4_0);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ceq);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Stloc_S, (byte)6);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc_S, (byte)6);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Brtrue_S, label2);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc_0);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldnull);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Cgt_Un);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Stloc_S, (byte)7);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc_S, (byte)7);
			Label label7 = iLGenerator.DefineLabel();
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Brfalse_S, label7);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Nop);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc_0);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Callvirt, AccessTools.Method(typeof(StringBuilder), "ToString"));
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Call, AccessTools.Method(typeof(LogService), "LogError", new Type[1] { typeof(string) }));
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Nop);
			iLGenerator.MarkLabel(label7);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Nop);
			iLGenerator.Emit(System.Reflection.Emit.OpCodes.Ret);
			Delegate del = dynamicMethod.CreateDelegate(typeof(Delegate));
			return del.GetMethodInfo();
		}
	}
	public class CultureCreateListener : AbstractListener<CultureCreateListener, CultureCreateHandler>
	{
		protected static void HandleAll(Culture pCulture, Actor pActor, City pCity)
		{
			StringBuilder stringBuilder = null;
			foreach (CultureCreateHandler handler in AbstractListener<CultureCreateListener, CultureCreateHandler>.instance.handlers)
			{
				if (!handler.enabled)
				{
					continue;
				}
				try
				{
					handler.Handle(pCulture, pActor, pCity);
				}
				catch (Exception ex)
				{
					handler.HitException();
					if (stringBuilder == null)
					{
						stringBuilder = new StringBuilder();
					}
					stringBuilder.AppendLine("Failed to handle event in " + handler.GetType().FullName);
					stringBuilder.AppendLine(ex.Message);
					stringBuilder.AppendLine(ex.StackTrace);
				}
			}
			if (stringBuilder != null)
			{
				LogService.LogError(stringBuilder.ToString());
			}
		}

		[HarmonyTranspiler]
		[HarmonyPatch(typeof(Culture), "createCulture")]
		private static IEnumerable<CodeInstruction> _createCulture_Patch(IEnumerable<CodeInstruction> instr)
		{
			List<CodeInstruction> list = new List<CodeInstruction>(instr);
			int pos = 42;
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_0));
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_1));
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_2));
			AbstractListener<CultureCreateListener, CultureCreateHandler>.InsertCallHandleCode(list, pos);
			return list;
		}
	}
	public class KingdomSetupListener : AbstractListener<KingdomSetupListener, KingdomSetupHandler>
	{
		protected static void HandleAll(Kingdom pKingdom, bool pCiv)
		{
			StringBuilder stringBuilder = null;
			foreach (KingdomSetupHandler handler in AbstractListener<KingdomSetupListener, KingdomSetupHandler>.instance.handlers)
			{
				if (!handler.enabled)
				{
					continue;
				}
				try
				{
					handler.Handle(pKingdom, pCiv);
				}
				catch (Exception ex)
				{
					handler.HitException();
					if (stringBuilder == null)
					{
						stringBuilder = new StringBuilder();
					}
					stringBuilder.AppendLine("Failed to handle event in " + handler.GetType().FullName);
					stringBuilder.AppendLine(ex.Message);
					stringBuilder.AppendLine(ex.StackTrace);
				}
			}
			if (stringBuilder != null)
			{
				LogService.LogError(stringBuilder.ToString());
			}
		}

		[HarmonyTranspiler]
		[HarmonyPatch(typeof(KingdomManager), "makeNewCivKingdom")]
		private static IEnumerable<CodeInstruction> _setupKingdom_Patch(IEnumerable<CodeInstruction> instr)
		{
			List<CodeInstruction> list = new List<CodeInstruction>(instr);
			int pos = 28;
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_1));
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_2));
			AbstractListener<KingdomSetupListener, KingdomSetupHandler>.InsertCallHandleCode(list, pos);
			return list;
		}
	}
	public class PlotStartListener : AbstractListener<PlotStartListener, PlotStartHandler>
	{
		protected static void HandleAll(Plot pPlot, Actor pActor, PlotAsset pAsset)
		{
			StringBuilder stringBuilder = null;
			foreach (PlotStartHandler handler in AbstractListener<PlotStartListener, PlotStartHandler>.instance.handlers)
			{
				if (!handler.enabled)
				{
					continue;
				}
				try
				{
					handler.Handle(pPlot, pActor, pAsset);
				}
				catch (Exception ex)
				{
					handler.HitException();
					if (stringBuilder == null)
					{
						stringBuilder = new StringBuilder();
					}
					stringBuilder.AppendLine("Failed to handle event in " + handler.GetType().FullName);
					stringBuilder.AppendLine(ex.Message);
					stringBuilder.AppendLine(ex.StackTrace);
				}
			}
			if (stringBuilder != null)
			{
				LogService.LogError(stringBuilder.ToString());
			}
		}

		[HarmonyTranspiler]
		[HarmonyPatch(typeof(PlotManager), "newPlot", new Type[]
		{
			typeof(Actor),
			typeof(PlotAsset)
		})]
		private static IEnumerable<CodeInstruction> _newPlot_Patch(IEnumerable<CodeInstruction> instr)
		{
			List<CodeInstruction> list = new List<CodeInstruction>(instr);
			int pos = list.FindIndex((CodeInstruction code) => code.opcode == System.Reflection.Emit.OpCodes.Ret);
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Dup));
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_1));
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_2));
			AbstractListener<PlotStartListener, PlotStartHandler>.InsertCallHandleCode(list, pos);
			return list;
		}
	}
	public class WarEndListener : AbstractListener<WarEndListener, WarEndHandler>
	{
		protected static void HandleAll(WarManager pWarManager, War pWar)
		{
			StringBuilder stringBuilder = null;
			foreach (WarEndHandler handler in AbstractListener<WarEndListener, WarEndHandler>.instance.handlers)
			{
				if (!handler.enabled)
				{
					continue;
				}
				try
				{
					handler.Handle(pWarManager, pWar);
				}
				catch (Exception ex)
				{
					handler.HitException();
					if (stringBuilder == null)
					{
						stringBuilder = new StringBuilder();
					}
					stringBuilder.AppendLine("Failed to handle event in " + handler.GetType().FullName);
					stringBuilder.AppendLine(ex.Message);
					stringBuilder.AppendLine(ex.StackTrace);
				}
			}
			if (stringBuilder != null)
			{
				LogService.LogError(stringBuilder.ToString());
			}
		}

		[HarmonyTranspiler]
		[HarmonyPatch(typeof(WarManager), "endWar")]
		private static IEnumerable<CodeInstruction> _endWar_Patch(IEnumerable<CodeInstruction> instr)
		{
			List<CodeInstruction> list = new List<CodeInstruction>(instr);
			int pos = 14;
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_0));
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_1));
			AbstractListener<WarEndListener, WarEndHandler>.InsertCallHandleCode(list, pos);
			return list;
		}
	}
	public class WarStartListener : AbstractListener<WarStartListener, WarStartHandler>
	{
		protected static void HandleAll(War pWar, Kingdom pAttacker, Kingdom pDefender, WarTypeAsset pWarType)
		{
			StringBuilder stringBuilder = null;
			foreach (WarStartHandler handler in AbstractListener<WarStartListener, WarStartHandler>.instance.handlers)
			{
				if (!handler.enabled)
				{
					continue;
				}
				try
				{
					handler.Handle(pWar, pAttacker, pDefender, pWarType);
				}
				catch (Exception ex)
				{
					handler.HitException();
					if (stringBuilder == null)
					{
						stringBuilder = new StringBuilder();
					}
					stringBuilder.AppendLine("Failed to handle event in " + handler.GetType().FullName);
					stringBuilder.AppendLine(ex.Message);
					stringBuilder.AppendLine(ex.StackTrace);
				}
			}
			if (stringBuilder != null)
			{
				LogService.LogError(stringBuilder.ToString());
			}
		}

		[HarmonyTranspiler]
		[HarmonyPatch(typeof(WarManager), "newWar")]
		private static IEnumerable<CodeInstruction> _newWar_Patch(IEnumerable<CodeInstruction> instr)
		{
			List<CodeInstruction> list = new List<CodeInstruction>(instr);
			int pos = list.FindIndex((CodeInstruction c) => c.opcode == System.Reflection.Emit.OpCodes.Ret);
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Dup));
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_1));
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_2));
			list.Insert(pos++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_3));
			AbstractListener<WarStartListener, WarStartHandler>.InsertCallHandleCode(list, pos);
			return list;
		}
	}
	public class WorldLogMessageListener : AbstractListener<WorldLogMessageListener, WorldLogMessageHandler>
	{
		protected static string HandleAll(ref WorldLogMessage pMessage, string pCurrentText, UnityEngine.Color pCurrentColor, Text pTextfield, bool pColorField, bool pColorTags)
		{
			StringBuilder stringBuilder = null;
			int i = 0;
			int count = AbstractListener<WorldLogMessageListener, WorldLogMessageHandler>.instance.handlers.Count;
			bool flag = false;
			while (!flag)
			{
				try
				{
					for (; i < count; i++)
					{
						AbstractListener<WorldLogMessageListener, WorldLogMessageHandler>.instance.handlers[i].Handle(ref pMessage, ref pCurrentText, ref pCurrentColor, ref pColorField, pColorTags);
					}
					flag = true;
				}
				catch (Exception ex)
				{
					AbstractListener<WorldLogMessageListener, WorldLogMessageHandler>.instance.handlers[i].HitException();
					if (stringBuilder == null)
					{
						stringBuilder = new StringBuilder();
					}
					stringBuilder.AppendLine("Failed to handle event in " + AbstractListener<WorldLogMessageListener, WorldLogMessageHandler>.instance.handlers[i].GetType().FullName);
					stringBuilder.AppendLine(ex.Message);
					stringBuilder.AppendLine(ex.StackTrace);
					i++;
				}
			}
			if (stringBuilder != null)
			{
				LogService.LogError(stringBuilder.ToString());
			}
			if (pColorField)
			{
				pTextfield.color = pCurrentColor;
			}
			else
			{
				pTextfield.color = Toolbox.color_log_neutral;
			}
			return pCurrentText;
		}

		[HarmonyTranspiler]
		[HarmonyPatch(typeof(WorldLogMessageExtensions), "getFormatedText")]
		private static IEnumerable<CodeInstruction> _WorldLogMessage_getFormatedText_Patch(IEnumerable<CodeInstruction> instr)
		{
			List<CodeInstruction> list = new List<CodeInstruction>(instr);
			int index = list.Count - 2;
			list.Insert(index++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_0));
			list.Insert(index++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldloc_0));
			list.Insert(index++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldloc_1));
			list.Insert(index++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_1));
			list.Insert(index++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_2));
			list.Insert(index++, new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_3));
			list.Insert(index++, new CodeInstruction(System.Reflection.Emit.OpCodes.Callvirt, AccessTools.Method(typeof(WorldLogMessageListener), "HandleAll")));
			list.Insert(index, new CodeInstruction(System.Reflection.Emit.OpCodes.Stloc_0));
			return list;
		}
	}
}
namespace NeoModLoader.General.Event.Handlers
{
	public abstract class ActorTryToAttackHandler : AbstractHandler<ActorTryToAttackHandler>
	{
		public abstract void Handle(Actor pAttacker, BaseSimObject pTarget, CombatActionAsset pCombatActionAsset, AttackData pAttackData);
	}
	public abstract class AllianceCreateHandler : AbstractHandler<AllianceCreateHandler>
	{
		public abstract void Handle(Alliance pAlliance, Kingdom pKingdom, Kingdom pKingdom2);
	}
	public abstract class CityCreateHandler : AbstractHandler<CityCreateHandler>
	{
		public abstract void Handle(City pCity);
	}
	public abstract class ClanCreateHandler : AbstractHandler<ClanCreateHandler>
	{
		public abstract void Handle(Clan pClan, Actor pFounder);
	}
	public abstract class CultureCreateHandler : AbstractHandler<CultureCreateHandler>
	{
		public abstract void Handle(Culture pCulture, Actor pActor, City pCity);
	}
	public abstract class KingdomSetupHandler : AbstractHandler<KingdomSetupHandler>
	{
		public abstract void Handle(Kingdom pKingdom, bool pCiv);
	}
	public abstract class PlotStartHandler : AbstractHandler<PlotStartHandler>
	{
		public abstract void Handle(Plot pPlot, Actor pActor, PlotAsset pAsset);
	}
	public abstract class WarEndHandler : AbstractHandler<WarEndHandler>
	{
		public abstract void Handle(WarManager pWarManager, War pWar);
	}
	public abstract class WarStartHandler : AbstractHandler<WarStartHandler>
	{
		public abstract void Handle(War pWar, Kingdom pAttacker, Kingdom pDefender, WarTypeAsset pWarType);
	}
	public abstract class WorldLogMessageHandler : AbstractHandler<WorldLogMessageHandler>
	{
		public abstract void Handle(ref WorldLogMessage pMessage, ref string pText, ref UnityEngine.Color pColor, ref bool pColorField, bool pColorTags);
	}
}
namespace NeoModLoader.constants
{
	public static class CoreConstants
	{
		public const string ModName = "NeoModLoader";

		public const string OrgName = "WorldBoxOpenMods";

		public const string RepoName = "ModLoader";

		public const string OrgURL = "https://github.com/WorldBoxOpenMods";

		public const string RepoURL = "https://github.com/WorldBoxOpenMods/ModLoader";

		internal const ulong WorkshopFileId = 3080294469uL;

		internal const ulong GameId = 1206560uL;

		internal const string DefaultLocaleID = "en";
	}
	public static class Others
	{
		internal const long confirmed_compile_time = 100000000L;

		internal const string harmony_id = "wbom.nml";

		public static bool unity_player_enabled { get; internal set; }

		public static bool is_editor
		{
			get
			{
				if (unity_player_enabled)
				{
					RuntimePlatform platform = Application.platform;
					if (1 == 0)
					{
					}
					bool result = platform switch
					{
						RuntimePlatform.WindowsEditor => true, 
						RuntimePlatform.OSXEditor => true, 
						RuntimePlatform.LinuxEditor => true, 
						_ => false, 
					};
					if (1 == 0)
					{
					}
					return result;
				}
				return false;
			}
		}
	}
	public static class Paths
	{
		public static readonly string NMLModPath;

		public static readonly string PersistentDataPath;

		public static readonly string StreamingAssetsPath;

		public static readonly string NativeModsPath;

		public static readonly string ManagedPath;

		public static readonly string NMLPath;

		public static readonly string NMLCommitPath;

		public static readonly string NMLAutoUpdateModulePath;

		public static readonly string PublicizedAssemblyPath;

		public static readonly string ModsConfigPath;

		public static readonly string BepInExPluginsPath;

		public static readonly string ModsPath;

		public static readonly string NMLAssembliesPath;

		public static readonly string CompiledModsPath;

		public static readonly string TabOrderRecordPath;

		public static readonly string ModCompileRecordPath;

		public static readonly string ModsDisabledRecordPath;

		public static readonly string ModDeclarationFileName;

		public static readonly string ModDefaultConfigFileName;

		public static readonly string ModResourceFolderName;

		public static readonly string NCMSAdditionModResourceFolderName;

		public static readonly string ModAssetBundleFolderName;

		public static readonly string CommonModsWorkshopPath;

		public static readonly string NCMSModEmbededResourceFolderName;

		public static readonly HashSet<string> IgnoreSearchDirectories;

		internal static readonly string LinuxSteamLocalConfigPath;

		public static string GamePath
		{
			get
			{
				RuntimePlatform platform = Application.platform;
				if (1 == 0)
				{
				}
				string result = platform switch
				{
					RuntimePlatform.WindowsPlayer => Combine(StreamingAssetsPath, "..", ".."), 
					RuntimePlatform.LinuxPlayer => Combine(StreamingAssetsPath, "..", ".."), 
					RuntimePlatform.OSXPlayer => Combine(StreamingAssetsPath, "..", "..", "..", "..", ".."), 
					_ => Combine(StreamingAssetsPath, "..", ".."), 
				};
				if (1 == 0)
				{
				}
				return result;
			}
		}

		static Paths()
		{
			PersistentDataPath = Combine(Application.persistentDataPath);
			StreamingAssetsPath = Combine(Application.streamingAssetsPath);
			NativeModsPath = Combine(StreamingAssetsPath, "mods");
			ManagedPath = (Others.is_editor ? Combine(StreamingAssetsPath, "..", ".Managed") : Combine(StreamingAssetsPath, "..", "Managed"));
			NMLPath = Combine(NativeModsPath, "NML");
			NMLCommitPath = Combine(NMLPath, "commit");
			NMLAutoUpdateModulePath = Combine(NativeModsPath, "NeoModLoader.AutoUpdate_memload.dll");
			PublicizedAssemblyPath = Combine(NMLPath, "Assembly-CSharp-Publicized.dll");
			ModsConfigPath = Combine(PersistentDataPath, "mods_config");
			BepInExPluginsPath = Combine(GamePath, "BepInEx", "plugins");
			ModsPath = (Others.is_editor ? Combine(GamePath, "Assets", "Mods") : Combine(GamePath, "Mods"));
			NMLAssembliesPath = Combine(NMLPath, "Assemblies");
			CompiledModsPath = Combine(NMLPath, "CompiledMods");
			TabOrderRecordPath = Combine(NMLPath, "tab_order_records.json");
			ModCompileRecordPath = Combine(NMLPath, "mod_compile_records.json");
			ModsDisabledRecordPath = Combine(NMLPath, "disabled_mods.txt");
			ModDeclarationFileName = "mod.json";
			ModDefaultConfigFileName = "default_config.json";
			ModResourceFolderName = (Others.is_editor ? "Resources" : "GameResources");
			NCMSAdditionModResourceFolderName = "GameResourcesReplace";
			ModAssetBundleFolderName = "AssetBundles";
			CommonModsWorkshopPath = Combine(GamePath, "..", "..", "workshop", "content", 1206560uL.ToString());
			NCMSModEmbededResourceFolderName = "EmbededResources";
			IgnoreSearchDirectories = new HashSet<string> { "bin", "obj", "Properties", "packages", "packages.config", "packages-lock.json", "packages-lock.xml" };
			LinuxSteamLocalConfigPath = "~/.local/share/Steam/userdata/{0}/config/localconfig.vdf";
			string text = Assembly.GetExecutingAssembly().Location;
			if (string.IsNullOrEmpty(text))
			{
				text = Combine(NativeModsPath, "NeoModLoader.dll");
				if (!File.Exists(text))
				{
					text = Combine(NativeModsPath, "NeoModLoader_memload.dll");
				}
			}
			NMLModPath = text;
		}

		private static string Combine(params string[] paths)
		{
			return new FileInfo(paths.Aggregate("", Path.Combine)).FullName;
		}
	}
	internal static class Setting
	{
		public const string github_auth_client_id = "Iv1.c85ea6bddeb2ed41";

		public const string discord_auth_client_id = "1171719697557880892";
	}
}
namespace NeoModLoader.api
{
	public abstract class AbstractListWindowItem<TItem> : MonoBehaviour
	{
		public abstract void Setup(TItem pObject);
	}
	public abstract class AbstractListWindow<T, TItem> : AbstractWindow<T> where T : AbstractListWindow<T, TItem>
	{
		protected static AbstractListWindowItem<TItem> ItemPrefab;

		private ObjectPoolGenericMono<AbstractListWindowItem<TItem>> _pool;

		protected Dictionary<TItem, AbstractListWindowItem<TItem>> ItemMap = new Dictionary<TItem, AbstractListWindowItem<TItem>>();

		protected virtual void AddItemToList(TItem item)
		{
			if (_pool == null)
			{
				_pool = new ObjectPoolGenericMono<AbstractListWindowItem<TItem>>(ItemPrefab, base.ContentTransform);
			}
			if (!ItemMap.TryGetValue(item, out var value))
			{
				value = _pool.getNext();
				ItemMap[item] = value;
			}
			value.transform.localScale = Vector3.one;
			value.Setup(item);
		}

		protected virtual void RemoveItemFromList(TItem item)
		{
			if (ItemMap.TryGetValue(item, out var value))
			{
				if (value.gameObject.activeSelf)
				{
					value.gameObject.SetActive(value: false);
				}
				_pool._elements_inactive.Enqueue(value);
				ItemMap.Remove(item);
			}
		}

		protected virtual void ClearList()
		{
			_pool?.clear();
			ItemMap.Clear();
		}

		public new static T CreateAndInit(string pWindowId)
		{
			ScrollWindow scrollWindow = WindowCreator.CreateEmptyWindow(pWindowId, pWindowId + " Title");
			GameObject gameObject = scrollWindow.gameObject;
			AbstractWindow<T>.Instance = gameObject.AddComponent<T>();
			AbstractWindow<T>.Instance.gameObject.SetActive(value: false);
			AbstractWindow<T>.Instance.BackgroundTransform = scrollWindow.transform.Find("Background");
			AbstractWindow<T>.Instance.BackgroundTransform.Find("Scroll View").gameObject.SetActive(value: true);
			AbstractWindow<T>.Instance.BackgroundTransform.Find("Scroll View").GetComponent<RectTransform>().sizeDelta = new Vector2(232f, 270f);
			AbstractWindow<T>.Instance.BackgroundTransform.Find("Scroll View").localPosition = new Vector3(0f, -6f);
			AbstractWindow<T>.Instance.BackgroundTransform.Find("Scroll View/Viewport").GetComponent<RectTransform>().sizeDelta = new Vector2(30f, 0f);
			AbstractWindow<T>.Instance.BackgroundTransform.Find("Scroll View/Viewport").localPosition = new Vector3(-131f, 135f);
			AbstractWindow<T>.Instance.ContentTransform = AbstractWindow<T>.Instance.BackgroundTransform.Find("Scroll View/Viewport/Content");
			VerticalLayoutGroup verticalLayoutGroup = AbstractWindow<T>.Instance.ContentTransform.gameObject.AddComponent<VerticalLayoutGroup>();
			ContentSizeFitter contentSizeFitter = AbstractWindow<T>.Instance.ContentTransform.gameObject.AddComponent<ContentSizeFitter>();
			verticalLayoutGroup.childControlWidth = true;
			verticalLayoutGroup.childControlHeight = false;
			verticalLayoutGroup.childForceExpandWidth = true;
			verticalLayoutGroup.childForceExpandHeight = false;
			verticalLayoutGroup.childAlignment = TextAnchor.MiddleCenter;
			verticalLayoutGroup.spacing = 10f;
			verticalLayoutGroup.padding = new RectOffset(30, 30, 10, 10);
			contentSizeFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
			ItemPrefab = AbstractWindow<T>.Instance.CreateItemPrefab();
			AbstractWindow<T>.Instance.Init();
			AbstractWindow<T>.Instance.Initialized = true;
			return AbstractWindow<T>.Instance;
		}

		protected abstract AbstractListWindowItem<TItem> CreateItemPrefab();
	}
	public abstract class AbstractWideWindow<T> : AbstractWindow<T> where T : AbstractWideWindow<T>
	{
		public void SetSize(Vector2 pSize)
		{
			AbstractWindow<T>.Instance.BackgroundTransform.GetComponent<RectTransform>().sizeDelta = pSize;
			AbstractWindow<T>.Instance.BackgroundTransform.parent.Find("CloseBackground").localPosition = new Vector3(pSize.x / 2f - 20f, pSize.y / 2f + 7f);
			AbstractWindow<T>.Instance.BackgroundTransform.Find("TitleBackground").GetComponent<RectTransform>().sizeDelta = new Vector2(pSize.x / 2f, 30f);
			AbstractWindow<T>.Instance.BackgroundTransform.Find("TitleBackground").localPosition = new Vector3(0f, pSize.y / 2f + 5f);
			AbstractWindow<T>.Instance.GetComponent<ScrollWindow>().titleText.transform.localPosition = new Vector3(0f, pSize.y / 2f + 5f);
			AbstractWindow<T>.Instance.GetComponent<ScrollWindow>().titleText.GetComponent<RectTransform>().sizeDelta = new Vector2(pSize.x / 2f * 0.92f, 28f);
		}

		public static T CreateAndInit(string pWindowId, Vector2 pSize = default(Vector2))
		{
			AbstractWindow<T>.WindowId = pWindowId;
			if (pSize == default(Vector2))
			{
				pSize = new Vector2(600f, 280f);
			}
			ScrollWindow scrollWindow = WindowCreator.CreateEmptyWindow(pWindowId, pWindowId + " Title");
			GameObject gameObject = scrollWindow.gameObject;
			AbstractWindow<T>.Instance = gameObject.AddComponent<T>();
			AbstractWindow<T>.Instance.gameObject.SetActive(value: false);
			AbstractWindow<T>.Instance.BackgroundTransform = scrollWindow.transform.Find("Background");
			AbstractWindow<T>.Instance.BackgroundTransform.Find("Scroll View").gameObject.SetActive(value: true);
			AbstractWindow<T>.Instance.ContentTransform = AbstractWindow<T>.Instance.BackgroundTransform.Find("Scroll View/Viewport/Content");
			AbstractWindow<T>.Instance.BackgroundTransform.GetComponent<UnityEngine.UI.Image>().sprite = InternalResourcesGetter.GetWindowEmptyFrame();
			AbstractWindow<T>.Instance.BackgroundTransform.GetComponent<UnityEngine.UI.Image>().type = UnityEngine.UI.Image.Type.Sliced;
			GameObject gameObject2 = new GameObject("TitleBackground", typeof(UnityEngine.UI.Image));
			gameObject2.transform.SetParent(AbstractWindow<T>.Instance.BackgroundTransform);
			gameObject2.transform.localPosition = new Vector3(0f, 145f);
			gameObject2.transform.localScale = Vector3.one;
			gameObject2.transform.SetSiblingIndex(1);
			gameObject2.GetComponent<UnityEngine.UI.Image>().sprite = InternalResourcesGetter.GetWindowBigCloseSliced();
			gameObject2.GetComponent<UnityEngine.UI.Image>().type = UnityEngine.UI.Image.Type.Sliced;
			AbstractWindow<T>.Instance.SetSize(pSize);
			AbstractWindow<T>.Instance.Init();
			AbstractWindow<T>.Instance.Initialized = true;
			return AbstractWindow<T>.Instance;
		}
	}
	public abstract class AbstractWindow<T> : MonoBehaviour where T : AbstractWindow<T>
	{
		protected bool Initialized;

		protected bool IsOpened;

		protected bool IsFirstOpen = true;

		public static T Instance { get; protected set; }

		protected Transform ContentTransform { get; set; }

		protected Transform BackgroundTransform { get; set; }

		public static string WindowId { get; protected set; }

		public static T CreateAndInit(string pWindowId)
		{
			WindowId = pWindowId;
			ScrollWindow scrollWindow = WindowCreator.CreateEmptyWindow(pWindowId, pWindowId + " Title");
			GameObject gameObject = scrollWindow.gameObject;
			Instance = gameObject.AddComponent<T>();
			Instance.gameObject.SetActive(value: false);
			Instance.BackgroundTransform = scrollWindow.transform.Find("Background");
			Instance.BackgroundTransform.Find("Scroll View").gameObject.SetActive(value: true);
			Instance.ContentTransform = Instance.BackgroundTransform.Find("Scroll View/Viewport/Content");
			Instance.Init();
			Instance.Initialized = true;
			return Instance;
		}

		protected abstract void Init();

		private void OnEnable()
		{
			if (Initialized)
			{
				if (IsFirstOpen)
				{
					IsFirstOpen = false;
					OnFirstEnable();
				}
				OnNormalEnable();
				IsOpened = true;
			}
		}

		private void OnDisable()
		{
			if (Initialized)
			{
				IsOpened = false;
				OnNormalDisable();
			}
		}

		public virtual void OnNormalDisable()
		{
		}

		public virtual void OnFirstEnable()
		{
		}

		public virtual void OnNormalEnable()
		{
		}
	}
	public class AttachedModComponent : MonoBehaviour, IMod
	{
		private ModDeclare _declare;

		public ModDeclare GetDeclaration()
		{
			return _declare;
		}

		public GameObject GetGameObject()
		{
			return base.gameObject;
		}

		public string GetUrl()
		{
			return string.IsNullOrEmpty(_declare.RepoUrl) ? "https://github.com/WorldBoxOpenMods" : _declare.RepoUrl;
		}

		public void OnLoad(ModDeclare pModDecl, GameObject pGameObject)
		{
			_declare = pModDecl;
		}
	}
	public abstract class BasicMod<T> : MonoBehaviour, IMod, ILocalizable, IConfigurable, IFeatureLoadManaged, IStagedLoad where T : BasicMod<T>
	{
		private ModConfig _config = null;

		private ModDeclare _declare = null;

		private bool _isLoaded;

		private Transform _prefab_library;

		public static T Instance { get; private set; }

		public static T I => Instance;

		public Transform PrefabLibrary
		{
			get
			{
				if (_prefab_library == null)
				{
					_prefab_library = base.transform.Find("PrefabLibrary");
					if (_prefab_library == null)
					{
						_prefab_library = new GameObject("PrefabLibrary").transform;
						_prefab_library.SetParent(base.transform);
					}
				}
				return _prefab_library;
			}
		}

		public IModFeatureManager ModFeatureManager { get; private set; }

		public ModConfig GetConfig()
		{
			return _config;
		}

		public string GetLocaleFilesDirectory(ModDeclare pModDeclare)
		{
			return Path.Combine(pModDeclare.FolderPath, "Locales");
		}

		public GameObject GetGameObject()
		{
			return base.gameObject;
		}

		public virtual string GetUrl()
		{
			return string.IsNullOrEmpty(_declare.RepoUrl) ? "https://github.com/WorldBoxOpenMods" : _declare.RepoUrl;
		}

		public void OnLoad(ModDeclare pModDecl, GameObject pGameObject)
		{
			if (!_isLoaded)
			{
				_declare = pModDecl;
				Instance = (T)this;
				ModFeatureManager = new ModFeatureManager<T>(this);
				if (_config == null)
				{
					_config = LoadConfig();
				}
				LogInfo("OnLoad");
				OnModLoad();
				ModFeatureManager.InstantiateFeatures();
				LogInfo("Loaded");
				_isLoaded = true;
			}
		}

		public virtual void Init()
		{
			ModFeatureManager.Init();
		}

		public virtual void PostInit()
		{
			ModFeatureManager.PostInit();
		}

		public ModDeclare GetDeclaration()
		{
			return _declare;
		}

		public static GameObject NewPrefab(string name)
		{
			GameObject gameObject = new GameObject(name);
			gameObject.transform.SetParent(Instance.PrefabLibrary);
			return gameObject;
		}

		private ModConfig LoadConfig()
		{
			ModConfig modConfig = new ModConfig(Path.Combine(Paths.ModsConfigPath, _declare.UID + ".config"), pIsPersistent: true);
			string path = Path.Combine(_declare.FolderPath, Paths.ModDefaultConfigFileName);
			if (!File.Exists(path))
			{
				return modConfig;
			}
			ModConfig pDefaultConfig = new ModConfig(Path.Combine(_declare.FolderPath, Paths.ModDefaultConfigFileName));
			modConfig.MergeWith(pDefaultConfig);
			return modConfig;
		}

		protected abstract void OnModLoad();

		public static void LogInfo(string message)
		{
			LogService.LogInfo("[" + Instance._declare.Name + "]: " + message);
		}

		public static void LogWarning(string message)
		{
			LogService.LogWarning("[" + Instance._declare.Name + "]: " + message);
		}

		public static void LogError(string message)
		{
			LogService.LogError("[" + Instance._declare.Name + "]: " + message);
		}
	}
	public class BepinexMod : VirtualMod
	{
		private MonoBehaviour _modComponent;

		public MonoBehaviour GetModComponent()
		{
			return _modComponent;
		}

		public void OnLoad(ModDeclare pModDecl, MonoBehaviour pModComponent)
		{
			OnLoad(pModDecl, pModComponent?.gameObject);
			_modComponent = pModComponent;
		}
	}
	public class FeatureLoadException : Exception
	{
		protected FeatureLoadException([NotNull] SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		public FeatureLoadException(string message)
			: base(message)
		{
		}

		public FeatureLoadException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
	public interface IConfigurable
	{
		ModConfig GetConfig();
	}
	public interface ICsvSepCustomized
	{
		char GetCsvSeparator();
	}
	public interface IDecoratePanel
	{
		void DecoratePanel(ModInfoPanel pPanel);
	}
	public interface IFeatureLoadManaged
	{
		IModFeatureManager ModFeatureManager { get; }
	}
	public interface ILocalizable
	{
		string GetLocaleFilesDirectory(ModDeclare pModDeclare);
	}
	public interface IMod
	{
		ModDeclare GetDeclaration();

		GameObject GetGameObject();

		string GetUrl();

		void OnLoad(ModDeclare pModDecl, GameObject pGameObject);
	}
	public interface IModFeature
	{
		IModFeatureManager ModFeatureManager { get; set; }

		ModFeatureRequirementList RequiredModFeatures { get; }

		ModFeatureRequirementList OptionalModFeatures { get; }

		bool Init();

		bool PostInit();
	}
	public interface IModFeatureManager : IStagedLoad
	{
		bool IsFeatureLoaded<T>() where T : IModFeature;

		T GetFeature<T>(IModFeature askingModFeature) where T : IModFeature;

		bool TryGetFeature<T>(IModFeature askingModFeature, out T feature) where T : IModFeature;

		void InstantiateFeatures();
	}
	public interface IReloadable
	{
		void Reload();
	}
	public interface IStagedLoad
	{
		void Init();

		void PostInit();
	}
	[Obsolete("This interface is deprecated, it is useless and it has not actual effect now.")]
	public interface IUnloadable
	{
		void OnUnload();
	}
	internal class ModCompilationCache
	{
		public List<string> dependencies;

		public bool disabled;

		public string mod_id;

		public List<string> optional_dependencies;

		public long timestamp;

		private ModCompilationCache()
		{
		}

		public ModCompilationCache(string pModID)
		{
			mod_id = pModID;
			timestamp = 0L;
			dependencies = new List<string>();
			optional_dependencies = new List<string>();
		}

		public ModCompilationCache(ModDeclare pModDeclare, List<string> pDependencies, List<string> pOptionalDependencies)
		{
			mod_id = pModDeclare.UID;
			disabled = false;
			timestamp = 0L;
			dependencies = new List<string>(pDependencies ?? new List<string>());
			optional_dependencies = new List<string>(pOptionalDependencies ?? new List<string>());
		}
	}
	public enum ConfigItemType
	{
		SWITCH,
		SLIDER,
		TEXT,
		SELECT,
		INT_SLIDER
	}
	public class ModConfigItem
	{
		private MethodInfo callback;

		[JsonProperty("Type")]
		public ConfigItemType Type { get; internal set; }

		[JsonProperty("Id")]
		public string Id { get; internal set; }

		[JsonProperty("IconPath")]
		public string IconPath { get; internal set; }

		[JsonProperty("BoolVal")]
		public bool BoolVal { get; internal set; }

		[JsonProperty("TextVal")]
		public string TextVal { get; internal set; }

		[JsonProperty("FloatVal")]
		public float FloatVal { get; internal set; }

		[JsonProperty("MaxFloatVal")]
		public float MaxFloatVal { get; internal set; } = 1f;

		[JsonProperty("MinFloatVal")]
		public float MinFloatVal { get; internal set; }

		[JsonProperty("IntVal")]
		public int IntVal { get; internal set; }

		[JsonProperty("MaxIntVal")]
		public int MaxIntVal { get; internal set; } = 1;

		[JsonProperty("MinIntVal")]
		public int MinIntVal { get; internal set; }

		[JsonProperty("Callback")]
		public string CallBack { get; internal set; }

		public void SetFloatRange(float pMin, float pMax)
		{
			if (pMax < pMin)
			{
				throw new ArgumentException("Max value must be greater than min value!");
			}
			MinFloatVal = pMin;
			MaxFloatVal = pMax;
		}

		public void SetIntRange(int pMin, int pMax)
		{
			if (pMax < pMin)
			{
				throw new ArgumentException("Max value must be greater than min value!");
			}
			MinIntVal = pMin;
			MaxIntVal = pMax;
		}

		public void SetValue(object val, bool pSkipCallback = false)
		{
			try
			{
				switch (Type)
				{
				case ConfigItemType.SWITCH:
				{
					bool boolVal = BoolVal;
					BoolVal = Convert.ToBoolean(val);
					if (string.IsNullOrEmpty(CallBack) || pSkipCallback)
					{
						break;
					}
					if (callback == null)
					{
						callback = AccessTools.Method(CallBack, new Type[1] { typeof(bool) });
					}
					if (callback == null)
					{
						LogService.LogWarning($"No found callback({typeof(bool)}) {CallBack}");
						break;
					}
					try
					{
						callback.Invoke(null, new object[1] { BoolVal });
						break;
					}
					catch (Exception ex3)
					{
						LogService.LogError($"Failed to set value '{BoolVal}'({typeof(bool)}) for config item '{Id}'");
						LogService.LogError(ex3.Message);
						LogService.LogError(ex3.StackTrace);
						BoolVal = boolVal;
						break;
					}
				}
				case ConfigItemType.SLIDER:
				{
					float floatVal = FloatVal;
					FloatVal = Convert.ToSingle(val);
					FloatVal = Math.Max(MinFloatVal, Math.Min(MaxFloatVal, FloatVal));
					if (string.IsNullOrEmpty(CallBack) || pSkipCallback)
					{
						break;
					}
					MethodInfo methodInfo4 = AccessTools.Method(CallBack, new Type[1] { typeof(float) });
					if (methodInfo4 == null)
					{
						LogService.LogWarning($"No found callback({typeof(float)}) {CallBack}");
						break;
					}
					try
					{
						methodInfo4.Invoke(null, new object[1] { FloatVal });
						break;
					}
					catch (Exception ex5)
					{
						LogService.LogError($"Failed to set value '{FloatVal}'({typeof(float)}) for config item '{Id}'");
						LogService.LogError(ex5.Message);
						LogService.LogError(ex5.StackTrace);
						FloatVal = floatVal;
						break;
					}
				}
				case ConfigItemType.INT_SLIDER:
				{
					int intVal2 = IntVal;
					IntVal = Convert.ToInt32(val);
					IntVal = Math.Max(MinIntVal, Math.Min(MaxIntVal, IntVal));
					if (string.IsNullOrEmpty(CallBack) || pSkipCallback)
					{
						break;
					}
					MethodInfo methodInfo3 = AccessTools.Method(CallBack, new Type[1] { typeof(int) });
					if (methodInfo3 == null)
					{
						LogService.LogWarning($"No found callback({typeof(int)}) {CallBack}");
						break;
					}
					try
					{
						methodInfo3.Invoke(null, new object[1] { IntVal });
						break;
					}
					catch (Exception ex4)
					{
						LogService.LogError($"Failed to set value '{IntVal}'({typeof(int)}) for config item '{Id}'");
						LogService.LogError(ex4.Message);
						LogService.LogError(ex4.StackTrace);
						IntVal = intVal2;
						break;
					}
				}
				case ConfigItemType.TEXT:
				{
					string textVal = TextVal;
					TextVal = Convert.ToString(val);
					if (string.IsNullOrEmpty(CallBack) || pSkipCallback)
					{
						break;
					}
					MethodInfo methodInfo2 = AccessTools.Method(CallBack, new Type[1] { typeof(string) });
					if (methodInfo2 == null)
					{
						LogService.LogWarning($"No found callback({typeof(string)}) {CallBack}");
						break;
					}
					try
					{
						methodInfo2.Invoke(null, new object[1] { TextVal });
						break;
					}
					catch (Exception ex2)
					{
						LogService.LogError($"Failed to set value '{TextVal}'({typeof(string)}) for config item '{Id}'");
						LogService.LogError(ex2.Message);
						LogService.LogError(ex2.StackTrace);
						TextVal = textVal;
						break;
					}
				}
				case ConfigItemType.SELECT:
				{
					int intVal = IntVal;
					IntVal = Convert.ToInt32(val);
					if (string.IsNullOrEmpty(CallBack) || pSkipCallback)
					{
						break;
					}
					MethodInfo methodInfo = AccessTools.Method(CallBack, new Type[1] { typeof(int) });
					if (methodInfo == null)
					{
						LogService.LogWarning($"No found callback({typeof(int)}) {CallBack}");
						break;
					}
					try
					{
						methodInfo.Invoke(null, new object[1] { IntVal });
						break;
					}
					catch (Exception ex)
					{
						LogService.LogError($"Failed to set value '{IntVal}'({typeof(int)}) for config item '{Id}'");
						LogService.LogError(ex.Message);
						LogService.LogError(ex.StackTrace);
						IntVal = intVal;
						break;
					}
				}
				}
			}
			catch (Exception ex6)
			{
				LogService.LogError($"Error while setting value for config item {Type}! {ex6.Message}");
				LogService.LogError(ex6.StackTrace);
				LogService.LogError("Set default value instead.");
				switch (Type)
				{
				case ConfigItemType.SWITCH:
					BoolVal = false;
					break;
				case ConfigItemType.SLIDER:
					FloatVal = 0f;
					break;
				case ConfigItemType.INT_SLIDER:
					IntVal = 0;
					break;
				case ConfigItemType.TEXT:
					TextVal = "";
					break;
				case ConfigItemType.SELECT:
					IntVal = 0;
					break;
				}
			}
		}

		public object GetValue()
		{
			ConfigItemType type = Type;
			if (1 == 0)
			{
			}
			object result = type switch
			{
				ConfigItemType.SWITCH => BoolVal, 
				ConfigItemType.SLIDER => FloatVal, 
				ConfigItemType.INT_SLIDER => IntVal, 
				ConfigItemType.TEXT => TextVal, 
				ConfigItemType.SELECT => IntVal, 
				_ => throw new ArgumentOutOfRangeException(), 
			};
			if (1 == 0)
			{
			}
			return result;
		}
	}
	public class ModConfig
	{
		private readonly string _path;

		internal Dictionary<string, Dictionary<string, ModConfigItem>> _config = new Dictionary<string, Dictionary<string, ModConfigItem>>();

		public Dictionary<string, ModConfigItem> this[string pGroupId] => _config[pGroupId];

		public ModConfig(string path, bool pIsPersistent = false)
		{
			if (!File.Exists(path))
			{
				if (!pIsPersistent)
				{
					LogService.LogWarning("ModConfig file " + path + " does not exist, suggest to create one");
				}
				else
				{
					_path = path;
				}
				return;
			}
			string value = File.ReadAllText(path);
			Dictionary<string, List<ModConfigItem>> dictionary = JsonConvert.DeserializeObject<Dictionary<string, List<ModConfigItem>>>(value);
			if (dictionary == null)
			{
				if (!pIsPersistent)
				{
					LogService.LogWarning("ModConfig file " + path + " is empty or in invalid format!");
				}
				else
				{
					_path = path;
				}
				return;
			}
			_path = path;
			foreach (string key in dictionary.Keys)
			{
				CreateGroup(key);
				List<ModConfigItem> list = dictionary[key];
				foreach (ModConfigItem item in list)
				{
					_config[key][item.Id] = item;
					if (item.Type == ConfigItemType.SLIDER && item.MaxFloatVal < item.MinFloatVal)
					{
						item.SetFloatRange(item.MinFloatVal, item.MinFloatVal);
					}
					if (item.Type == ConfigItemType.INT_SLIDER && item.MaxIntVal < item.MinIntVal)
					{
						item.SetIntRange(item.MinIntVal, item.MinIntVal);
					}
					item.SetValue(item.GetValue(), !pIsPersistent);
				}
			}
		}

		public void MergeWith(ModConfig pDefaultConfig)
		{
			HashSet<string> hashSet = new HashSet<string>();
			foreach (string key in _config.Keys)
			{
				if (!pDefaultConfig._config.ContainsKey(key))
				{
					hashSet.Add(key);
					continue;
				}
				Dictionary<string, ModConfigItem> dictionary = _config[key];
				Dictionary<string, ModConfigItem> default_group = pDefaultConfig._config[key];
				HashSet<string> hashSet2 = new HashSet<string>();
				foreach (string item in dictionary.Keys.Where((string item) => !default_group.ContainsKey(item)))
				{
					hashSet2.Add(item);
				}
				foreach (string item2 in hashSet2)
				{
					dictionary.Remove(item2);
				}
			}
			foreach (string item3 in hashSet)
			{
				_config.Remove(item3);
			}
			foreach (string key2 in pDefaultConfig._config.Keys)
			{
				if (!_config.ContainsKey(key2))
				{
					_config[key2] = new Dictionary<string, ModConfigItem>();
				}
				Dictionary<string, ModConfigItem> group = _config[key2];
				Dictionary<string, ModConfigItem> dictionary2 = pDefaultConfig._config[key2];
				foreach (string item4 in dictionary2.Keys.Where((string item) => group.ContainsKey(item)))
				{
					group[item4].CallBack = dictionary2[item4].CallBack;
					if (group[item4].Type != dictionary2[item4].Type)
					{
						object obj = dictionary2[item4].GetValue();
						switch (dictionary2[item4].Type)
						{
						case ConfigItemType.SLIDER:
							switch (group[item4].Type)
							{
							case ConfigItemType.TEXT:
							{
								if (float.TryParse(obj.ToString(), out var result4))
								{
									obj = result4;
								}
								break;
							}
							case ConfigItemType.SWITCH:
								obj = (((bool)group[item4].GetValue()) ? 1 : 0);
								break;
							case ConfigItemType.INT_SLIDER:
								obj = (int)group[item4].GetValue();
								break;
							}
							group[item4].SetFloatRange(dictionary2[item4].MinFloatVal, dictionary2[item4].MaxFloatVal);
							break;
						case ConfigItemType.INT_SLIDER:
							switch (group[item4].Type)
							{
							case ConfigItemType.TEXT:
							{
								if (int.TryParse(obj.ToString(), out var result3))
								{
									obj = result3;
								}
								break;
							}
							case ConfigItemType.SWITCH:
								obj = (((bool)group[item4].GetValue()) ? 1 : 0);
								break;
							case ConfigItemType.SLIDER:
								obj = (float)group[item4].GetValue();
								break;
							}
							group[item4].SetIntRange(dictionary2[item4].MinIntVal, dictionary2[item4].MaxIntVal);
							break;
						case ConfigItemType.SWITCH:
							switch (group[item4].Type)
							{
							case ConfigItemType.TEXT:
							{
								if (bool.TryParse(obj.ToString(), out var result))
								{
									obj = result;
								}
								if (int.TryParse(obj.ToString(), out var result2))
								{
									obj = result2 != 0;
								}
								break;
							}
							case ConfigItemType.SLIDER:
								obj = (float)group[item4].GetValue() != 0f;
								break;
							case ConfigItemType.INT_SLIDER:
								obj = (int)group[item4].GetValue() != 0;
								break;
							}
							break;
						}
						AddConfigItem(key2, item4, dictionary2[item4].Type, obj, dictionary2[item4].IconPath, dictionary2[item4].CallBack);
					}
					else if (group[item4].Type == ConfigItemType.SLIDER)
					{
						group[item4].SetFloatRange(dictionary2[item4].MinFloatVal, dictionary2[item4].MaxFloatVal);
						float num = ((group[item4].GetValue() is float) ? ((float)group[item4].GetValue()) : 0f);
						if (num < dictionary2[item4].MinFloatVal || num > dictionary2[item4].MaxFloatVal)
						{
							group[item4].SetValue(dictionary2[item4].GetValue());
						}
					}
					else if (group[item4].Type == ConfigItemType.INT_SLIDER)
					{
						group[item4].SetIntRange(dictionary2[item4].MinIntVal, dictionary2[item4].MaxIntVal);
						float num2 = ((group[item4].GetValue() is int) ? ((int)group[item4].GetValue()) : 0);
						if (num2 < (float)dictionary2[item4].MinIntVal || num2 > (float)dictionary2[item4].MaxIntVal)
						{
							group[item4].SetValue(dictionary2[item4].GetValue());
						}
					}
				}
				foreach (string item5 in dictionary2.Keys.Where((string item) => !group.ContainsKey(item)))
				{
					if (dictionary2[item5].Type == ConfigItemType.SLIDER)
					{
						AddConfigSliderItemWithRange(key2, item5, (float)dictionary2[item5].GetValue(), dictionary2[item5].MinFloatVal, dictionary2[item5].MaxFloatVal, dictionary2[item5].IconPath, dictionary2[item5].CallBack);
					}
					else if (dictionary2[item5].Type == ConfigItemType.INT_SLIDER)
					{
						AddConfigSliderItemWithIntRange(key2, item5, (int)dictionary2[item5].GetValue(), dictionary2[item5].MinIntVal, dictionary2[item5].MaxIntVal, dictionary2[item5].IconPath, dictionary2[item5].CallBack);
					}
					else
					{
						AddConfigItem(key2, item5, dictionary2[item5].Type, dictionary2[item5].GetValue(), dictionary2[item5].IconPath, dictionary2[item5].CallBack);
					}
				}
			}
		}

		public void Save(string path = null)
		{
			if (path == null)
			{
				path = _path;
			}
			if (string.IsNullOrEmpty(path))
			{
				return;
			}
			Dictionary<string, List<ModConfigItem>> dictionary = new Dictionary<string, List<ModConfigItem>>();
			foreach (string key in _config.Keys)
			{
				Dictionary<string, ModConfigItem> dictionary2 = _config[key];
				dictionary[key] = new List<ModConfigItem>();
				foreach (KeyValuePair<string, ModConfigItem> item in dictionary2)
				{
					dictionary[key].Add(item.Value);
				}
			}
			string contents = JsonConvert.SerializeObject(dictionary);
			File.WriteAllText(path, contents);
		}

		public void CreateGroup(string pId)
		{
			if (_config.ContainsKey(pId))
			{
				LogService.LogWarning("ModConfigGroup " + pId + " already exists!");
				LogService.LogStackTraceAsWarning();
			}
			else
			{
				_config[pId] = new Dictionary<string, ModConfigItem>();
			}
		}

		public ModConfigItem AddConfigItem(string pGroupId, string pId, ConfigItemType pType, object pDefaultValue, string pIconPath = "", string pCallback = "")
		{
			if (!_config.TryGetValue(pGroupId, out var value))
			{
				value = new Dictionary<string, ModConfigItem>();
				_config[pGroupId] = value;
			}
			if (value.ContainsKey(pId))
			{
				LogService.LogWarning("ModConfigItem " + pId + " already exists in group " + pGroupId + "! Overwriting...");
				LogService.LogStackTraceAsWarning();
			}
			else
			{
				value[pId] = new ModConfigItem
				{
					Id = pId
				};
			}
			value[pId].Type = pType;
			value[pId].CallBack = pCallback;
			value[pId].SetValue(pDefaultValue);
			value[pId].IconPath = pIconPath;
			return value[pId];
		}

		public ModConfigItem AddConfigSliderItemWithRange(string pGroupId, string pId, float pDefaultValue, float pMinValue, float pMaxValue, string pIconPath = "", string pCallback = "")
		{
			if (!_config.TryGetValue(pGroupId, out var value))
			{
				value = new Dictionary<string, ModConfigItem>();
				_config[pGroupId] = value;
			}
			if (value.ContainsKey(pId))
			{
				LogService.LogWarning("ModConfigItem " + pId + " already exists in group " + pGroupId + "! Overwriting...");
				LogService.LogStackTraceAsWarning();
			}
			else
			{
				value[pId] = new ModConfigItem
				{
					Id = pId
				};
			}
			value[pId].Type = ConfigItemType.SLIDER;
			value[pId].CallBack = pCallback;
			value[pId].SetFloatRange(pMinValue, pMaxValue);
			value[pId].SetValue(pDefaultValue);
			value[pId].IconPath = pIconPath;
			return value[pId];
		}

		public ModConfigItem AddConfigSliderItemWithIntRange(string pGroupId, string pId, int pDefaultValue, int pMinValue, int pMaxValue, string pIconPath = "", string pCallback = "")
		{
			if (!_config.TryGetValue(pGroupId, out var value))
			{
				value = new Dictionary<string, ModConfigItem>();
				_config[pGroupId] = value;
			}
			if (value.ContainsKey(pId))
			{
				LogService.LogWarning("ModConfigItem " + pId + " already exists in group " + pGroupId + "! Overwriting...");
				LogService.LogStackTraceAsWarning();
			}
			else
			{
				value[pId] = new ModConfigItem
				{
					Id = pId
				};
			}
			value[pId].Type = ConfigItemType.INT_SLIDER;
			value[pId].CallBack = pCallback;
			value[pId].SetIntRange(pMinValue, pMaxValue);
			value[pId].SetValue(pDefaultValue);
			value[pId].IconPath = pIconPath;
			return value[pId];
		}
	}
	public enum ModTypeEnum
	{
		NEOMOD,
		COMPILED_NEOMOD,
		BEPINEX,
		RESOURCE_PACK
	}
	internal enum ModState
	{
		DISABLED,
		LOADED,
		FAILED
	}
	[Serializable]
	public class ModDeclare
	{
		[JsonProperty("name")]
		public string Name { get; private set; }

		[JsonProperty("GUID")]
		public string UID { get; private set; }

		[JsonProperty("author")]
		public string Author { get; private set; }

		[JsonProperty("version")]
		public string Version { get; private set; }

		[JsonProperty("description")]
		public string Description { get; private set; }

		[JsonProperty("RepoUrl")]
		public string RepoUrl { get; private set; }

		[JsonProperty("Dependencies")]
		public string[] Dependencies { get; private set; }

		[JsonProperty("OptionalDependencies")]
		public string[] OptionalDependencies { get; private set; }

		[JsonProperty("IncompatibleWith")]
		public string[] IncompatibleWith { get; private set; }

		public string FolderPath { get; private set; } = null;

		[JsonProperty("targetGameBuild")]
		public int TargetGameBuild { get; private set; }

		[JsonProperty("iconPath")]
		public string IconPath { get; private set; }

		[JsonProperty("ModType")]
		public ModTypeEnum ModType { get; private set; } = ModTypeEnum.NEOMOD;

		[JsonProperty("UsePublicizedAssembly")]
		public bool UsePublicizedAssembly { get; private set; } = true;

		public bool IsNCMSMod { get; internal set; } = false;

		public StringBuilder FailReason { get; } = new StringBuilder();

		public bool IsWorkshopLoaded { get; internal set; } = false;

		private ModDeclare()
		{
		}

		public ModDeclare(string pName, string pAuthor, string pIconPath, string pVersion, string pDescription, string pFolderPath, string[] pDependencies, string[] pOptionalDependencies, string[] pIncompatibleWith, bool pIsWorkshopLoaded = false)
		{
			Name = pName;
			Author = pAuthor;
			IconPath = pIconPath;
			Version = pVersion;
			Description = pDescription;
			Dependencies = pDependencies ?? Array.Empty<string>();
			OptionalDependencies = pOptionalDependencies ?? Array.Empty<string>();
			IncompatibleWith = pIncompatibleWith ?? Array.Empty<string>();
			IsWorkshopLoaded = pIsWorkshopLoaded;
			UID = ModDependencyUtils.ParseDepenNameToPreprocessSymbol(Author + "." + Name);
			for (int i = 0; i < Dependencies.Length; i++)
			{
				Dependencies[i] = ModDependencyUtils.ParseDepenNameToPreprocessSymbol(Dependencies[i]);
			}
			for (int j = 0; j < OptionalDependencies.Length; j++)
			{
				OptionalDependencies[j] = ModDependencyUtils.ParseDepenNameToPreprocessSymbol(OptionalDependencies[j]);
			}
			for (int k = 0; k < IncompatibleWith.Length; k++)
			{
				IncompatibleWith[k] = ModDependencyUtils.ParseDepenNameToPreprocessSymbol(IncompatibleWith[k]);
			}
			FolderPath = pFolderPath;
		}

		public ModDeclare(string pFilePath)
		{
			ModDeclare modDeclare = JsonConvert.DeserializeObject<ModDeclare>(File.ReadAllText(pFilePath)) ?? throw new InvalidOperationException("Input Mod Config file path cannot be null");
			if (modDeclare == null)
			{
				throw new Exception("Mod Config file at \"" + pFilePath + "\" is invalid");
			}
			Name = modDeclare.Name;
			Author = modDeclare.Author;
			Version = modDeclare.Version;
			IconPath = modDeclare.IconPath;
			Description = modDeclare.Description;
			Dependencies = modDeclare.Dependencies;
			OptionalDependencies = modDeclare.OptionalDependencies;
			IncompatibleWith = modDeclare.IncompatibleWith;
			ModType = modDeclare.ModType;
			UsePublicizedAssembly = modDeclare.UsePublicizedAssembly;
			if (Dependencies == null)
			{
				string[] array = (Dependencies = Array.Empty<string>());
			}
			if (OptionalDependencies == null)
			{
				string[] array = (OptionalDependencies = Array.Empty<string>());
			}
			if (IncompatibleWith == null)
			{
				string[] array = (IncompatibleWith = Array.Empty<string>());
			}
			UID = modDeclare.UID;
			if (string.IsNullOrEmpty(UID))
			{
				UID = Author + "." + Name;
			}
			UID = ModDependencyUtils.ParseDepenNameToPreprocessSymbol(UID);
			for (int i = 0; i < Dependencies.Length; i++)
			{
				Dependencies[i] = ModDependencyUtils.ParseDepenNameToPreprocessSymbol(Dependencies[i]);
			}
			for (int j = 0; j < OptionalDependencies.Length; j++)
			{
				OptionalDependencies[j] = ModDependencyUtils.ParseDepenNameToPreprocessSymbol(OptionalDependencies[j]);
			}
			for (int k = 0; k < IncompatibleWith.Length; k++)
			{
				IncompatibleWith[k] = ModDependencyUtils.ParseDepenNameToPreprocessSymbol(IncompatibleWith[k]);
			}
			FolderPath = Path.GetDirectoryName(pFilePath) ?? throw new Exception("Cannot get folder path from input file path");
			string[] array5 = FolderPath.Split(new char[1] { Path.DirectorySeparatorChar });
			int num = array5.IndexOf("workshop");
			if (num != -1 && num + 3 < array5.Length && !(array5[++num] != "content") && !(array5[++num] != "1206560"))
			{
				Regex regex = new Regex("^\\d+$");
				if (regex.IsMatch(array5[++num]))
				{
					IsWorkshopLoaded = true;
				}
			}
		}

		internal void SetRepoUrlToWorkshopPage(string id)
		{
			RepoUrl = "https://steamcommunity.com/sharedfiles/filedetails/?id=" + id;
		}

		internal void SetModType(ModTypeEnum modType)
		{
			if (modType < ModTypeEnum.NEOMOD || modType > ModTypeEnum.RESOURCE_PACK)
			{
				throw new ArgumentOutOfRangeException("modType", modType, null);
			}
			ModType = modType;
		}

		internal void SetIconPath(string iconPath)
		{
			IconPath = iconPath;
		}
	}
	public static class ModDeclareExtensions
	{
		public static Version ParseVersion(this ModDeclare pModDeclare)
		{
			try
			{
				Version version = Version.Parse(pModDeclare.Version);
				int major = Math.Max(0, version.Major);
				int minor = Math.Max(0, version.Minor);
				int build = Math.Max(0, version.Build);
				int revision = Math.Max(0, version.Revision);
				return new Version(major, minor, build, revision);
			}
			catch (Exception)
			{
				return new Version(0, 0, 0, 0);
			}
		}

		public static bool TryGetDeclaration(this Assembly pModAssembly, out ModDeclare pModDeclare)
		{
			foreach (ModDeclare mod in WorldBoxMod.AllRecognizedMods.Keys)
			{
				switch (mod.ModType)
				{
				case ModTypeEnum.NEOMOD:
					if (mod.UID == pModAssembly.GetName().Name)
					{
						pModDeclare = mod;
						return true;
					}
					break;
				case ModTypeEnum.COMPILED_NEOMOD:
				{
					IMod modObj = WorldBoxMod.LoadedMods.FirstOrDefault((IMod m) => m.GetDeclaration() == mod);
					if (modObj != null)
					{
						if (pModAssembly == modObj.GetType().Assembly)
						{
							pModDeclare = mod;
							return true;
						}
						if ((from t in pModAssembly.Modules.SelectMany((Module m) => m.GetTypes())
							where t.GetInterfaces().Contains(typeof(IMod))
							select t).Any((Type modClass) => modClass.IsInstanceOfType(modObj)))
						{
							pModDeclare = mod;
							return true;
						}
					}
					else
					{
						if (Directory.GetFiles(mod.FolderPath).Any((string possible_file) => Path.GetFullPath(possible_file) == Path.GetFullPath(pModAssembly.Location)))
						{
							pModDeclare = mod;
							return true;
						}
						if (string.Concat(mod.Name.Where((char c) => new Regex("\\S").IsMatch(c.ToString()))) == pModAssembly.GetName().Name)
						{
							pModDeclare = mod;
							return true;
						}
					}
					break;
				}
				case ModTypeEnum.BEPINEX:
					if (mod.Name == pModAssembly.GetCustomAttribute<AssemblyTitleAttribute>()?.Title)
					{
						pModDeclare = mod;
						return true;
					}
					break;
				default:
					throw new ArgumentOutOfRangeException();
				case ModTypeEnum.RESOURCE_PACK:
					break;
				}
			}
			pModDeclare = null;
			return false;
		}
	}
	public abstract class ModFeature : IModFeature
	{
		public IModFeatureManager ModFeatureManager { get; set; }

		public virtual ModFeatureRequirementList RequiredModFeatures { get; } = new List<Type>();

		public virtual ModFeatureRequirementList OptionalModFeatures { get; } = new List<Type>();

		public abstract bool Init();

		public virtual bool PostInit()
		{
			return true;
		}

		protected bool TryGetFeature<T>(out T feature) where T : ModFeature
		{
			return ModFeatureManager.TryGetFeature<T>(this, out feature);
		}

		protected T GetFeature<T>() where T : ModFeature
		{
			return ModFeatureManager.GetFeature<T>(this);
		}

		protected bool IsFeatureLoaded<T>() where T : ModFeature
		{
			return ModFeatureManager.IsFeatureLoaded<T>();
		}
	}
	public class ModFeatureManager<TMod> : IModFeatureManager, IStagedLoad where TMod : BasicMod<TMod>
	{
		private class FeatureTreeNode
		{
			internal IModFeature ModFeature { get; }

			internal List<FeatureTreeNode> DependentFeatures { get; } = new List<FeatureTreeNode>();

			internal FeatureTreeNode(IModFeature modFeature)
			{
				ModFeature = modFeature;
			}

			internal static FeatureTreeNode[] CreateFeatureTrees(IModFeature[] features)
			{
				Dictionary<string, FeatureTreeNode> dictionary = new Dictionary<string, FeatureTreeNode>();
				List<FeatureTreeNode> list = new List<FeatureTreeNode>();
				foreach (IModFeature modFeature in features)
				{
					FeatureTreeNode featureTreeNode = new FeatureTreeNode(modFeature);
					dictionary.Add(modFeature.GetType().AssemblyQualifiedName ?? throw new Exception("AssemblyQualifiedName is null, apparently."), featureTreeNode);
					if (!modFeature.RequiredModFeatures.Concat(modFeature.OptionalModFeatures).Any())
					{
						list.Add(featureTreeNode);
					}
				}
				foreach (FeatureTreeNode value2 in dictionary.Values)
				{
					foreach (Type item in value2.ModFeature.RequiredModFeatures.Concat(value2.ModFeature.OptionalModFeatures))
					{
						if (dictionary.TryGetValue(item.AssemblyQualifiedName ?? throw new Exception("AssemblyQualifiedName is null, apparently."), out var value))
						{
							value.DependentFeatures.Add(value2);
						}
					}
				}
				return list.ToArray();
			}
		}

		private class FeatureLoadPathNode
		{
			private class PlaceholderRootModFeature : ModFeature
			{
				public override bool Init()
				{
					return true;
				}
			}

			internal IModFeature ModFeature { get; }

			internal FeatureLoadPathNode DependentFeature { get; private set; }

			internal FeatureLoadPathNode DependencyFeature { get; private set; }

			internal FeatureLoadPathNode(IModFeature modFeature)
			{
				ModFeature = modFeature;
			}

			[CanBeNull]
			internal static FeatureLoadPathNode CreateFeatureLoadPath(FeatureTreeNode[] featureTrees)
			{
				FeatureTreeNode featureTreeNode = new FeatureTreeNode(new PlaceholderRootModFeature());
				foreach (FeatureTreeNode item in featureTrees)
				{
					featureTreeNode.DependentFeatures.Add(item);
				}
				FeatureLoadPathNode featureLoadPathNode = new FeatureLoadPathNode(featureTreeNode.ModFeature);
				FeatureLoadPathNode featureLoadPathNode2 = featureLoadPathNode;
				List<FeatureTreeNode> list = new List<FeatureTreeNode>(featureTreeNode.DependentFeatures);
				while (list.Count > 0)
				{
					FeatureTreeNode featureTreeNode2 = list.Pop();
					for (FeatureLoadPathNode featureLoadPathNode3 = featureLoadPathNode2; featureLoadPathNode3 != null; featureLoadPathNode3 = featureLoadPathNode3.DependencyFeature)
					{
						if (featureLoadPathNode3.ModFeature == featureTreeNode2.ModFeature)
						{
							if (featureLoadPathNode3.DependentFeature != null)
							{
								featureLoadPathNode3.DependentFeature.DependencyFeature = featureLoadPathNode3.DependencyFeature;
							}
							if (featureLoadPathNode3.DependencyFeature != null)
							{
								featureLoadPathNode3.DependencyFeature.DependentFeature = featureLoadPathNode3.DependentFeature;
							}
						}
					}
					FeatureLoadPathNode featureLoadPathNode4 = (featureLoadPathNode2.DependentFeature = new FeatureLoadPathNode(featureTreeNode2.ModFeature));
					featureLoadPathNode4.DependencyFeature = featureLoadPathNode2;
					featureLoadPathNode2 = featureLoadPathNode4;
					list.AddRange(featureTreeNode2.DependentFeatures);
				}
				return featureLoadPathNode.DependentFeature;
			}
		}

		private readonly BasicMod<TMod> _mod;

		private readonly List<IModFeature> _foundFeatures = new List<IModFeature>();

		private FeatureLoadPathNode _featureLoadPath;

		private StackTrace _firstInstantiationStackTrace;

		private readonly List<IModFeature> _loadedFeatures = new List<IModFeature>();

		private StackTrace _firstLoadStackTrace;

		public ModFeatureManager(BasicMod<TMod> mod)
		{
			_mod = mod;
		}

		public bool IsFeatureLoaded<T>() where T : IModFeature
		{
			return IsFeatureLoaded(typeof(T));
		}

		private bool IsFeatureLoaded(Type featureType)
		{
			return _loadedFeatures.Any((IModFeature feature) => feature.GetType() == featureType);
		}

		public T GetFeature<T>(IModFeature askingModFeature) where T : IModFeature
		{
			if (!askingModFeature.RequiredModFeatures.Contains(typeof(T)))
			{
				throw new InvalidOperationException("Feature " + typeof(T).FullName + " is not set as a requirement for feature " + askingModFeature.GetType().FullName + ".");
			}
			if (!IsFeatureLoaded<T>())
			{
				throw new InvalidOperationException("Feature " + typeof(T).FullName + " is not loaded.");
			}
			return (T)GetFeature(typeof(T));
		}

		private IModFeature GetFeature(Type featureType)
		{
			return _foundFeatures.FirstOrDefault((IModFeature feature) => feature.GetType() == featureType);
		}

		public bool TryGetFeature<T>(IModFeature askingModFeature, out T feature) where T : IModFeature
		{
			if (!askingModFeature.RequiredModFeatures.Contains(typeof(T)) && !askingModFeature.OptionalModFeatures.Contains(typeof(T)))
			{
				throw new InvalidOperationException("Feature " + typeof(T).FullName + " is not set as a requirement or optional feature for feature " + askingModFeature.GetType().FullName + ".");
			}
			if (!IsFeatureLoaded<T>())
			{
				feature = default(T);
				return false;
			}
			feature = (T)GetFeature(typeof(T));
			return true;
		}

		public void InstantiateFeatures()
		{
			if (_featureLoadPath != null)
			{
				throw new InvalidOperationException($"Features have already been instantiated for this ModFeatureManager. Stack trace of first instantiation:\n{_firstInstantiationStackTrace}");
			}
			List<IModFeature> features = FindAndInstantiateModFeatures();
			_featureLoadPath = ParseModFeaturesIntoLoadPath(features);
			if (_foundFeatures.Count > 0)
			{
				_firstInstantiationStackTrace = new StackTrace();
			}
		}

		public void Init()
		{
			if (_loadedFeatures.Count > 0)
			{
				throw new InvalidOperationException($"Features have already been loaded for this ModFeatureManager. Stack trace of first load:\n{_firstLoadStackTrace}");
			}
			for (FeatureLoadPathNode featureLoadPathNode = _featureLoadPath; featureLoadPathNode != null; featureLoadPathNode = featureLoadPathNode.DependentFeature)
			{
				InitFeature(featureLoadPathNode.ModFeature);
			}
			if (_loadedFeatures.Count > 0)
			{
				_firstLoadStackTrace = new StackTrace();
			}
		}

		public void PostInit()
		{
			for (FeatureLoadPathNode featureLoadPathNode = _featureLoadPath; featureLoadPathNode != null; featureLoadPathNode = featureLoadPathNode.DependentFeature)
			{
				SafePerformActionOnFeature(featureLoadPathNode.ModFeature, "Post-Loading", (IModFeature feature) => feature.PostInit());
			}
		}

		private static FeatureLoadPathNode ParseModFeaturesIntoLoadPath(List<IModFeature> features)
		{
			FeatureTreeNode[] featureTrees = FeatureTreeNode.CreateFeatureTrees(features.ToArray());
			return FeatureLoadPathNode.CreateFeatureLoadPath(featureTrees);
		}

		private List<IModFeature> FindAndInstantiateModFeatures()
		{
			List<IModFeature> list = new List<IModFeature>();
			foreach (var (featureType, instanceConstructor) in from type in _mod.GetType().Assembly.Modules.SelectMany((Module m) => m.GetTypes())
				where typeof(IModFeature).IsAssignableFrom(type)
				where !type.IsAbstract
				where !type.IsNestedPrivate
				select (featureType: type, type.GetConstructors().FirstOrDefault((ConstructorInfo constructor) => constructor.GetParameters().Length < 1)))
			{
				InstantiateModFeature(featureType, instanceConstructor, list);
			}
			_foundFeatures.AddRange(list);
			return list;
		}

		private void InstantiateModFeature(Type featureType, ConstructorInfo instanceConstructor, List<IModFeature> features)
		{
			BasicMod<TMod>.LogInfo("Creating instance of Feature " + featureType.FullName + "...");
			if ((object)instanceConstructor == null)
			{
				BasicMod<TMod>.LogError("No suitable constructor found for Feature " + featureType.FullName + ".");
				return;
			}
			IModFeature modFeature;
			try
			{
				modFeature = instanceConstructor.Invoke(new object[0]) as IModFeature;
			}
			catch (Exception arg)
			{
				BasicMod<TMod>.LogError($"An error occurred while trying to create an instance of Feature {featureType.FullName}:\n{arg}");
				return;
			}
			if (modFeature == null)
			{
				BasicMod<TMod>.LogError("Failed to create instance of Feature " + featureType.FullName + " for unknown reasons.");
				return;
			}
			modFeature.ModFeatureManager = this;
			List<Type> list = modFeature.RequiredModFeatures.Where((Type requiredFeature) => !typeof(IModFeature).IsAssignableFrom(requiredFeature)).ToList();
			if (list.Any())
			{
				throw new InvalidOperationException("Feature " + featureType.FullName + " has required features that are not a subclass of IModFeature:\n" + string.Join("\n", list.Select((Type type) => type.FullName)));
			}
			List<Type> list2 = modFeature.OptionalModFeatures.Where((Type optionalFeature) => !typeof(IModFeature).IsAssignableFrom(optionalFeature)).ToList();
			if (list2.Any())
			{
				throw new InvalidOperationException("Feature " + featureType.FullName + " has optional features that are not a subclass of IModFeature:\n" + string.Join("\n", list2.Select((Type type) => type.FullName)));
			}
			features.Add(modFeature);
			BasicMod<TMod>.LogInfo("Successfully created instance of Feature " + featureType.FullName + ".");
		}

		private void InitFeature(IModFeature modFeature)
		{
			SafePerformActionOnFeature(modFeature, "Loading", delegate(IModFeature feature)
			{
				bool flag = feature.Init();
				if (flag)
				{
					_loadedFeatures.Add(modFeature);
				}
				return flag;
			});
		}

		private void SafePerformActionOnFeature(IModFeature modFeature, string actionVerb, Func<IModFeature, bool> performAction, bool log = true)
		{
			if (log)
			{
				BasicMod<TMod>.LogInfo(actionVerb + " feature " + modFeature.GetType().FullName + "...");
			}
			try
			{
				List<Type> list = modFeature.RequiredModFeatures.Where((Type requiredFeature) => !IsFeatureLoaded(requiredFeature)).ToList();
				if (list.Count > 0)
				{
					if (log)
					{
						BasicMod<TMod>.LogError(actionVerb + " feature " + modFeature.GetType().FullName + " failed due missing requirement features:\n" + string.Join("\n", list.Select((Type type) => type.FullName)));
					}
				}
				else if (!performAction(modFeature))
				{
					if (log)
					{
						BasicMod<TMod>.LogError(actionVerb + " feature " + modFeature.GetType().FullName + " failed due to a failing condition.");
					}
				}
				else if (log)
				{
					BasicMod<TMod>.LogInfo(actionVerb + " feature " + modFeature.GetType().FullName + " succeeded.");
				}
			}
			catch (Exception arg)
			{
				if (log)
				{
					BasicMod<TMod>.LogError($"{actionVerb} feature {modFeature.GetType().FullName} caused an error:\n{arg}");
				}
			}
		}
	}
	public class ModFeatureRequirementList : IEnumerable<Type>, IEnumerable
	{
		private List<Type> RequiredFeatureList { get; } = new List<Type>();

		public ModFeatureRequirementList(params Type[] types)
		{
			foreach (Type type in types)
			{
				if ((object)type == null)
				{
					throw new ArgumentNullException("types", "A required feature type was null.");
				}
				if (!typeof(IModFeature).IsAssignableFrom(type))
				{
					throw new ArgumentException("The type " + type.Name + " is not a valid feature type.");
				}
			}
			RequiredFeatureList.AddRange(types);
		}

		public static ModFeatureRequirementList operator +(ModFeatureRequirementList list, Type type)
		{
			return list.RequiredFeatureList.Append(type).ToList();
		}

		public static implicit operator ModFeatureRequirementList(List<Type> list)
		{
			return new ModFeatureRequirementList(list.ToArray());
		}

		public static implicit operator List<Type>(ModFeatureRequirementList list)
		{
			return list.RequiredFeatureList.ToList();
		}

		public static implicit operator ModFeatureRequirementList(Type type)
		{
			return new ModFeatureRequirementList(type);
		}

		public static implicit operator ModFeatureRequirementList(Type[] list)
		{
			return new ModFeatureRequirementList(list);
		}

		public IEnumerator<Type> GetEnumerator()
		{
			return RequiredFeatureList.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
	public class VirtualMod : IMod
	{
		private ModDeclare _declare;

		private GameObject _boundGameObject;

		public ModDeclare GetDeclaration()
		{
			return _declare;
		}

		public GameObject GetGameObject()
		{
			return _boundGameObject;
		}

		public string GetUrl()
		{
			return string.IsNullOrEmpty(_declare.RepoUrl) ? "https://github.com/WorldBoxOpenMods" : _declare.RepoUrl;
		}

		public void OnLoad(ModDeclare pModDecl, GameObject pGameObject)
		{
			_declare = pModDecl;
			_boundGameObject = pGameObject;
		}
	}
}
namespace NeoModLoader.api.features
{
	public abstract class ModAssetFeature<TAsset> : ModObjectFeature<TAsset> where TAsset : Asset
	{
		protected virtual bool AddToLibrary => true;

		public override bool Init()
		{
			if (!base.Init())
			{
				return false;
			}
			if (AddToLibrary)
			{
				AssetLibrary<TAsset> assetLibrary = AssetManager._instance._list.OfType<AssetLibrary<TAsset>>().FirstOrDefault();
				if (assetLibrary == null)
				{
					throw new FeatureLoadException("No library found for " + typeof(TAsset).Name);
				}
				assetLibrary.add(base.Object);
			}
			return true;
		}
	}
	public abstract class ModButtonFeature<TPowersTabFeature> : ModObjectFeature<PowerButton> where TPowersTabFeature : ModPowerTabFeature
	{
		public override ModFeatureRequirementList RequiredModFeatures => base.RequiredModFeatures + typeof(TPowersTabFeature);

		protected PowersTab Tab => GetFeature<TPowersTabFeature>();

		public override bool Init()
		{
			return base.Init() && GetFeature<TPowersTabFeature>().PositionButton(base.Object);
		}
	}
	public abstract class ModGodPowerButtonFeature<TGodPowerFeature, TPowersTabFeature> : ModButtonFeature<TPowersTabFeature> where TGodPowerFeature : ModAssetFeature<GodPower> where TPowersTabFeature : ModPowerTabFeature
	{
		public override ModFeatureRequirementList RequiredModFeatures => base.RequiredModFeatures + typeof(TGodPowerFeature);

		public abstract string SpritePath { get; }

		protected override PowerButton InitObject()
		{
			return PowerButtonCreator.CreateGodPowerButton(GetFeature<TGodPowerFeature>().Object.id, Resources.Load<Sprite>(SpritePath), base.Tab.transform);
		}
	}
	public abstract class ModObjectFeature<TObject> : ModFeature
	{
		public TObject Object { get; private set; }

		public override bool Init()
		{
			TObject val = InitObject();
			if (val == null)
			{
				return false;
			}
			Object = val;
			return true;
		}

		protected abstract TObject InitObject();

		public static implicit operator TObject(ModObjectFeature<TObject> feature)
		{
			return feature.Object;
		}
	}
	public abstract class ModPowerTabFeature : ModObjectFeature<PowersTab>
	{
		public abstract bool PositionButton(PowerButton button);
	}
	public abstract class ModWindowButtonFeature<TWindowFeature, TPowersTabFeature> : ModButtonFeature<TPowersTabFeature> where TWindowFeature : ModObjectFeature<ScrollWindow> where TPowersTabFeature : ModPowerTabFeature
	{
		public override ModFeatureRequirementList RequiredModFeatures => base.RequiredModFeatures + typeof(TWindowFeature);

		protected ScrollWindow Window => GetFeature<TWindowFeature>();

		public abstract UnityAction WindowOpenAction { get; }

		public abstract string SpritePath { get; }

		protected override PowerButton InitObject()
		{
			return PowerButtonCreator.CreateSimpleButton(Window.name, WindowOpenAction, Resources.Load<Sprite>(SpritePath), base.Tab.transform);
		}
	}
}
namespace NeoModLoader.api.exceptions
{
	public class UnrecognizableResourceFileException : Exception
	{
		public UnrecognizableResourceFileException(string path)
			: base("Unrecognizable resource file: " + path)
		{
		}
	}
	public class UnsupportedFileTypeException : IOException
	{
		public UnsupportedFileTypeException(string filePath)
			: base("Unsupported file type for path " + filePath)
		{
		}
	}
}
namespace NeoModLoader.api.attributes
{
	public class ExperimentalAttribute : Attribute
	{
		public ExperimentalAttribute()
		{
		}

		public ExperimentalAttribute(string tip)
		{
		}
	}
	[AttributeUsage(AttributeTargets.Method)]
	public class HotfixableAttribute : Attribute
	{
	}
}
