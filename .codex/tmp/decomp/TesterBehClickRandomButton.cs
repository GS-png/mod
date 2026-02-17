using System;
using UnityEngine;
using UnityEngine.UI;
using ai.behaviours;

public class TesterBehClickRandomButton : BehaviourActionTester
{
	private Type _type;

	public TesterBehClickRandomButton(Type pButtonType = null)
	{
		_type = pButtonType;
	}

	public override BehResult execute(AutoTesterBot pObject)
	{
		if (ScrollWindow.isAnimationActive())
		{
			return BehResult.RepeatStep;
		}
		if (!ScrollWindow.isWindowActive())
		{
			return BehResult.Stop;
		}
		ScrollWindow currentWindow = ScrollWindow.getCurrentWindow();
		if (currentWindow == null)
		{
			return BehResult.Stop;
		}
		Component[] componentsInChildren = currentWindow.GetComponentsInChildren(_type);
		if (componentsInChildren.Length == 0)
		{
			return BehResult.Stop;
		}
		Component random = Randy.getRandom(componentsInChildren);
		if (random == null)
		{
			return BehResult.Stop;
		}
		if (!random.TryGetComponent<Button>(out var component))
		{
			return BehResult.Stop;
		}
		pObject.wait = 0.5f;
		component.onClick?.Invoke();
		return BehResult.Continue;
	}
}
