using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using ai.behaviours;

public class TesterBehScreenshotTooltips : BehaviourActionTester
{
	private int screenshots;

	private TooltipScreenshotState state;

	private List<ButtonTrigger> triggers = new List<ButtonTrigger>();

	private ButtonTrigger activeTrigger;

	private bool _screenshot;

	public TesterBehScreenshotTooltips(bool pScreenshot = true)
	{
		_screenshot = pScreenshot;
	}

	public override BehResult execute(AutoTesterBot pObject)
	{
		string screenshotFolder = TesterBehScreenshotFolder.getScreenshotFolder(LocalizedTextManager.instance.language);
		ScrollWindow currentWindow = ScrollWindow.getCurrentWindow();
		string screen_id = currentWindow.screen_id;
		RectTransform component = currentWindow.transform.FindRecursive("Viewport").gameObject.GetComponent<RectTransform>();
		string text = ((int)currentWindow.transform.FindRecursive("Content").gameObject.GetComponent<RectTransform>().localPosition.y).ToString("D4");
		switch (state)
		{
		case TooltipScreenshotState.Load:
		{
			Button[] componentsInChildren = currentWindow.gameObject.GetComponentsInChildren<Button>();
			foreach (Button button in componentsInChildren)
			{
				if (!button.isActiveAndEnabled || !button.gameObject.activeInHierarchy)
				{
					continue;
				}
				EventTrigger component2 = button.gameObject.GetComponent<EventTrigger>();
				if (component2 == null || button.name == "Close" || (button.transform.GetComponentInParent<ScrollWindow>() != null && !button.gameObject.GetComponent<RectTransform>().GetWorldRect().Overlaps(component.GetWorldRect())))
				{
					continue;
				}
				int num = 0;
				foreach (EventTrigger.Entry trigger in component2.triggers)
				{
					if (trigger.eventID == EventTriggerType.PointerEnter)
					{
						triggers.Add(new ButtonTrigger(button, trigger, ++num));
					}
				}
			}
			state = TooltipScreenshotState.NextTrigger;
			return BehResult.RepeatStep;
		}
		case TooltipScreenshotState.NextTrigger:
			if (triggers.Count == 0)
			{
				state = TooltipScreenshotState.Finish;
				return BehResult.RepeatStep;
			}
			activeTrigger = triggers.Shift();
			if (!activeTrigger.button.isActiveAndEnabled)
			{
				Debug.LogWarning("button was already disabled: " + activeTrigger.button.name, activeTrigger.button);
				return BehResult.RepeatStep;
			}
			activeTrigger.entry.callback.Invoke(new BaseEventData(EventSystem.current));
			state = TooltipScreenshotState.Screenshot;
			pObject.wait = 0.01f;
			return BehResult.RepeatStep;
		case TooltipScreenshotState.Cleanup:
			Tooltip.hideTooltipNow();
			state = TooltipScreenshotState.NextTrigger;
			return BehResult.RepeatStep;
		case TooltipScreenshotState.Screenshot:
			if (!Tooltip.anyActive())
			{
				state = TooltipScreenshotState.NextTrigger;
				return BehResult.RepeatStep;
			}
			if (_screenshot)
			{
				screenshots++;
				string text2 = "";
				if (activeTrigger.index > 1)
				{
					text2 = "_" + activeTrigger.index;
				}
				string text3 = screen_id + "_" + text + "_" + screenshots.ToString("D3") + "_" + activeTrigger.button.name + text2 + "_5";
				ScreenCapture.CaptureScreenshot(screenshotFolder + "/" + text3 + ".png");
			}
			state = TooltipScreenshotState.Cleanup;
			return BehResult.RepeatStep;
		case TooltipScreenshotState.Finish:
			state = TooltipScreenshotState.Load;
			screenshots = 0;
			activeTrigger = default(ButtonTrigger);
			triggers.Clear();
			return BehResult.Continue;
		default:
			Debug.LogError("TesterBehScreenshotTooltips: Unknown state: " + state);
			return BehResult.Stop;
		}
	}
}
