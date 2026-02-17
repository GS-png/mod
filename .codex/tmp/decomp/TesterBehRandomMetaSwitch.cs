using ai.behaviours;

public class TesterBehRandomMetaSwitch : BehaviourActionTester
{
	public override BehResult execute(AutoTesterBot pObject)
	{
		if (ScrollWindow.isAnimationActive())
		{
			pObject.wait = 0.1f;
			return BehResult.RepeatStep;
		}
		if (!ScrollWindow.isWindowActive())
		{
			return BehResult.Continue;
		}
		if (!MetaSwitchManager.isSwitcherEnabled())
		{
			return BehResult.Continue;
		}
		using ListPool<MetaSwitchButton> listPool = new ListPool<MetaSwitchButton>(2);
		listPool.Add(MetaSwitchManager.getLeftbutton());
		listPool.Add(MetaSwitchManager.getRightButton());
		listPool.RemoveAll((MetaSwitchButton pButton) => !pButton.gameObject.activeSelf);
		if (listPool.Count == 0)
		{
			return BehResult.Continue;
		}
		MetaSwitchButton random = listPool.GetRandom();
		pObject.wait = 0.2f;
		random.button.onClick?.Invoke();
		return BehResult.Continue;
	}
}
