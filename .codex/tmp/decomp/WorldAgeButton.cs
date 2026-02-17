using System;
using UnityEngine;
using UnityEngine.UI;

public class WorldAgeButton : BaseWorldAgeElement
{
	[SerializeField]
	private Image _selected;

	protected override void prepare()
	{
		base.prepare();
		if (TryGetComponent<DraggableLayoutElement>(out var component))
		{
			DraggableLayoutElement draggableLayoutElement = component;
			draggableLayoutElement.start_being_dragged = (Action<DraggableLayoutElement>)Delegate.Combine(draggableLayoutElement.start_being_dragged, new Action<DraggableLayoutElement>(onStartDrag));
		}
	}

	private void onStartDrag(DraggableLayoutElement pOriginalElement)
	{
		_selected.enabled = false;
	}

	public void toggleSelectedButton(bool pState)
	{
		if (_selected != null)
		{
			_selected.color = asset.pie_selection_color;
			_selected.enabled = pState;
		}
	}
}
