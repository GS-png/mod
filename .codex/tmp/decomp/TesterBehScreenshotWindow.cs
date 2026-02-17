using System;
using UnityEngine;
using ai.behaviours;

public class TesterBehScreenshotWindow : BehaviourActionTester
{
	public override BehResult execute(AutoTesterBot pObject)
	{
		ScrollWindow currentWindow = ScrollWindow.getCurrentWindow();
		string screen_id = currentWindow.screen_id;
		string text = ((int)currentWindow.transform.FindRecursive("Content").gameObject.GetComponent<RectTransform>().localPosition.y).ToString("D4");
		string screenshotFolder = TesterBehScreenshotFolder.getScreenshotFolder(LocalizedTextManager.instance.language);
		Console.WriteLine("[" + Date.TimeNow() + "] Screenshotting window: " + screen_id + " to " + screenshotFolder + "/" + screen_id + "_" + text + ".png");
		ScreenCapture.CaptureScreenshot(screenshotFolder + "/" + screen_id + "_" + text + "_000.png");
		return BehResult.Continue;
	}
}
