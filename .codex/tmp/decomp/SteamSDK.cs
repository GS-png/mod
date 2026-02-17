using System;
using Proyecto26;
using RSG;
using Steamworks;
using UnityEngine;

public class SteamSDK : MonoBehaviour
{
	public const uint STEAM_APP_ID = 1206560u;

	internal static Promise steamInitialized = new Promise();

	private bool _initiated;

	private static SteamSDK _instance;

	private static bool _should_quit = false;

	private static readonly string[] _supported_steam_languages = new string[28]
	{
		"ar", "cz", "ch", "cs", "da", "nl", "en", "fn", "fr", "de",
		"gr", "hu", "it", "ja", "ko", "no", "pl", "pt", "br", "ro",
		"ru", "es", "es", "sv", "th", "tr", "ua", "vn"
	};

	private void Start()
	{
		if (_initiated)
		{
			return;
		}
		_initiated = true;
		bool flag = false;
		try
		{
			_instance = this;
			SteamClient.Init(1206560u);
			RestClient.DefaultRequestHeaders["wb-stmc"] = "true";
		}
		catch (Exception message)
		{
			Debug.Log("Disabling Steam Integration");
			Debug.LogWarning(message);
			RestClient.DefaultRequestHeaders["wb-stmc"] = "na";
			flag = true;
			_should_quit = true;
		}
		try
		{
			string text = SteamClient.SteamId.ToString();
			if (!string.IsNullOrEmpty(text))
			{
				Config.steam_id = text;
				RestClient.DefaultRequestHeaders["wb-stm"] = text;
				Debug.Log("S:" + Config.steam_id);
			}
			else
			{
				Debug.Log("S:nf");
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (Config.steam_language_allow_detect)
			{
				Debug.Log("s:Detect - Steam detecting language");
				string steamLanguage = getSteamLanguage();
				if (!string.IsNullOrEmpty(steamLanguage))
				{
					string language = LocalizedTextManager.instance.language;
					if (steamLanguage == "en" && language != "en")
					{
						Debug.Log("s:Detect - Already have a language, not falling back to english");
					}
					else
					{
						LocalizedTextManager.instance.setLanguage(steamLanguage);
					}
				}
				Debug.Log("s:Detect - language " + steamLanguage);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			string text2 = SteamClient.Name;
			if (!string.IsNullOrEmpty(text2))
			{
				Config.steam_name = text2;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			if (SteamClient.RestartAppIfNecessary(1206560u))
			{
				Debug.Log("Restart App from Steam launcher");
				_should_quit = true;
				flag = true;
			}
		}
		catch (Exception message2)
		{
			Debug.Log(message2);
		}
		if (_should_quit && !Config.disable_steam)
		{
			Application.Quit();
		}
		if (flag)
		{
			Debug.Log("Steam is not available");
			steamInitialized.Reject(new Exception("Steam is not available"));
			UnityEngine.Object.Destroy(_instance);
		}
		else
		{
			steamInitialized.Resolve();
		}
	}

	private static string getSteamLanguage()
	{
		switch (SteamApps.GameLanguage)
		{
		case "arabic":
			return "ar";
		case "schinese":
			return "cz";
		case "tchinese":
			return "ch";
		case "czech":
			return "cs";
		case "danish":
			return "da";
		case "dutch":
			return "nl";
		case "english":
			return "en";
		case "finnish":
			return "fn";
		case "french":
			return "fr";
		case "german":
			return "de";
		case "greek":
			return "gr";
		case "hungarian":
			return "hu";
		case "indonesian":
			return "id";
		case "italian":
			return "it";
		case "japanese":
			return "ja";
		case "korean":
		case "koreana":
			return "ko";
		case "norwegian":
			return "no";
		case "polish":
			return "pl";
		case "portuguese":
			return "pt";
		case "brazilian":
			return "br";
		case "romanian":
			return "ro";
		case "russian":
			return "ru";
		case "spanish":
			return "es";
		case "latam":
			return "es";
		case "swedish":
			return "sv";
		case "thai":
			return "th";
		case "turkish":
			return "tr";
		case "ukrainian":
			return "ua";
		case "vietnamese":
			return "vn";
		default:
			return string.Empty;
		}
	}

	private void OnDisable()
	{
		try
		{
			SteamClient.Shutdown();
		}
		catch (Exception message)
		{
			Debug.LogWarning(message);
			UnityEngine.Object.Destroy(_instance);
		}
	}

	private void OnDestroy()
	{
		_instance = null;
	}
}
