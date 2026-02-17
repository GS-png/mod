using UnityEngine.EventSystems;
using UnityEngine.UI;

public struct ButtonTrigger
{
	public Button button { get; }

	public EventTrigger.Entry entry { get; }

	public int index { get; }

	public ButtonTrigger(Button pButton, EventTrigger.Entry pEntry, int pIndex)
	{
		button = pButton;
		entry = pEntry;
		index = pIndex;
	}
}
