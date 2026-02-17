using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowMetaTab : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup _canvas_group;

	public List<Transform> tab_elements = new List<Transform>();

	public WindowMetaTabEvent tab_action;

	internal WindowMetaTabButtonsContainer container;

	internal bool destroyed;

	private TipButton _tip_button;

	private string _worldtip_text;

	private bool _state = true;

	private void Awake()
	{
		GetComponent<Button>().onClick.AddListener(delegate
		{
			doAction();
		});
		_tip_button = GetComponent<TipButton>();
		_worldtip_text = getWorldTipText();
		_tip_button.setHoverAction(checkShowTooltip);
	}

	public void doAction()
	{
		tab_action.Invoke(this);
		checkShowWorldTip();
	}

	public void checkShowWorldTip()
	{
		if (!(_tip_button == null) && !InputHelpers.mouseSupported)
		{
			WorldTip.showNowTop(_worldtip_text, pTranslate: false);
		}
	}

	private void checkShowTooltip()
	{
		if (InputHelpers.mouseSupported)
		{
			Tooltip.show(this, "tip", new TooltipData
			{
				tip_name = _tip_button.textOnClick,
				tip_description = _tip_button.textOnClickDescription,
				tip_description_2 = _tip_button.text_description_2
			});
		}
	}

	private void OnDestroy()
	{
		destroyed = true;
		if (base.gameObject.HasComponent<PlatformRemover>())
		{
			container.removeTab(this);
		}
	}

	public bool getState()
	{
		return _state;
	}

	public void toggleActive(bool pState)
	{
		_state = pState;
		if (_state)
		{
			_canvas_group.alpha = 1f;
		}
		else
		{
			_canvas_group.alpha = 0f;
		}
		_canvas_group.interactable = _state;
		_canvas_group.blocksRaycasts = _state;
	}

	public string getWorldTipText()
	{
		string text = LocalizedTextManager.getText(_tip_button.textOnClick);
		if (!string.IsNullOrEmpty(_tip_button.textOnClickDescription))
		{
			text = text + "\n<size=9>" + LocalizedTextManager.getText(_tip_button.textOnClickDescription) + "</size>";
		}
		return text;
	}
}
