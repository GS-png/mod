using System.Collections.Generic;
using Firebase.Analytics;

public class Analytics
{
	private static Dictionary<string, string> _event_slugs = new Dictionary<string, string>();

	public static void trackWindow(string pName)
	{
		if (!Config.isEditor && !Config.isComputer)
		{
			string text = slugify(pName);
			if (Config.firebase_available)
			{
				FirebaseAnalytics.LogEvent("open_window", "window_id", text);
				logScreen("ScrollWindow", text);
			}
		}
	}

	public static void hideWindow()
	{
		logScreen("GamePlay", "gameplay");
	}

	public static void worldLoaded()
	{
		logScreen("GamePlay", "gameplay");
	}

	public static void worldLoading()
	{
		logScreen("LoadingScreen", "loading");
	}

	private static void logScreen(string pClass, string pName)
	{
		if (Config.firebase_available)
		{
			Parameter[] parameters = new Parameter[2]
			{
				new Parameter(FirebaseAnalytics.ParameterScreenClass, pClass),
				new Parameter(FirebaseAnalytics.ParameterScreenName, pName)
			};
			FirebaseAnalytics.LogEvent(FirebaseAnalytics.EventScreenView, parameters);
		}
	}

	public static void LogEvent(string pName, bool pFirebase = true, bool pFacebook = true)
	{
		if (Config.isEditor || Config.isComputer)
		{
			return;
		}
		MapBox world = World.world;
		if ((object)world == null || world.auto_tester?.active != true)
		{
			string name = slugify(pName);
			if (Config.firebase_available && pFirebase)
			{
				FirebaseAnalytics.LogEvent(name);
			}
		}
	}

	public static void LogEvent(string pName, string parameterName, string parameterValue)
	{
		if (Config.isEditor || Config.isComputer)
		{
			return;
		}
		MapBox world = World.world;
		if ((object)world == null || world.auto_tester?.active != true)
		{
			string name = slugify(pName);
			if (Config.firebase_available)
			{
				FirebaseAnalytics.LogEvent(name, parameterName, parameterValue);
			}
		}
	}

	public static string slugify(string pPhrase)
	{
		if (!_event_slugs.TryGetValue(pPhrase, out var value))
		{
			value = pPhrase.Trim().Replace(" ", "_").ToLower();
			_event_slugs[pPhrase] = value;
		}
		return value;
	}
}
