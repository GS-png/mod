using System;
using System.IO;
using UnityEngine;
using ai.behaviours;

public class TesterBehCopyCurrentLanguage : BehaviourActionTester
{
	public override BehResult execute(AutoTesterBot pObject)
	{
		string language = LocalizedTextManager.instance.language;
		string screenshotFolder = TesterBehScreenshotFolder.getScreenshotFolder(language);
		string text = "locales/" + language;
		string text2 = (Resources.Load(text) as TextAsset).text;
		Console.WriteLine("[" + Date.TimeNow() + "] Copying language: " + text + " to " + screenshotFolder + "/" + language + ".json");
		File.WriteAllText(screenshotFolder + "/" + language + ".json", text2);
		return BehResult.Continue;
	}
}
