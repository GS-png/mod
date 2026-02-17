using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WorldAgeWheelPiece : BaseWorldAgeElement, IDropHandler, IEventSystemHandler
{
	public Image mask;

	[SerializeField]
	private Image _highlight;

	[SerializeField]
	private Image _icon_frame;

	private int _index;

	public void init(int pIndex)
	{
		_index = pIndex;
		_tip_button.setHoverAction(_tip_button.showTooltipDefault, pAddAnimation: false);
		button.onClick.AddListener(clickThisPiece);
	}

	public void toggleHighlight(bool pState)
	{
		_highlight.enabled = pState;
		_highlight.color = asset.pie_selection_color;
		if (_highlight.HasComponent<FadeInOutAnimation>())
		{
			_highlight.GetComponent<FadeInOutAnimation>().resetToFadeIn();
		}
	}

	private void clickThisPiece()
	{
		World.world.era_manager.setCurrentSlotIndex(_index, 0f);
	}

	public void toggleIconFrame(bool pState)
	{
		if (_icon_frame != null)
		{
			_icon_frame.enabled = pState;
		}
	}

	public void OnDrop(PointerEventData pEventData)
	{
		if (!(pEventData.pointerDrag == null))
		{
			WorldAgeButton component = pEventData.pointerDrag.GetComponent<WorldAgeButton>();
			if (!(component == null))
			{
				WorldAgesWindow.setAgeAndSelectPiece(component.getAsset(), this);
			}
		}
	}

	public bool isCurrentAge()
	{
		return _index == World.world.era_manager.getCurrentSlotIndex();
	}

	public int getIndex()
	{
		return _index;
	}
}
