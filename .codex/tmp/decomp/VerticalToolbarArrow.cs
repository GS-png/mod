using UnityEngine;

public class VerticalToolbarArrow : ToolbarArrow
{
	public bool is_bottom = true;

	protected override void Update()
	{
		base.Update();
		float num = iTween.easeInOutCirc(0f, hide_position.y, timer);
		if (arrow_transform.localPosition.y != num)
		{
			arrow_transform.localPosition = new Vector3(0f, num);
		}
	}

	protected override float getScrollPosition()
	{
		return scroll_rect.verticalNormalizedPosition;
	}

	protected override void setScrollPosition(float pValue)
	{
		scroll_rect.verticalNormalizedPosition = pValue;
	}

	protected override float getEndPosition()
	{
		float scrollPosition = getScrollPosition();
		float a = (float)Screen.height / CanvasMain.instance.canvas_ui.scaleFactor / scroll_rect.content.rect.height;
		if (is_bottom)
		{
			return scrollPosition - Mathf.Min(a, 0.5f);
		}
		return scrollPosition + Mathf.Min(a, 0.5f);
	}

	protected override void onScroll(Vector2 pVal)
	{
		float num = (float)Screen.height / CanvasMain.instance.canvas_ui.scaleFactor;
		should_show = true;
		if (scroll_rect.content.rect.height < num)
		{
			should_show = false;
		}
		else if (is_bottom)
		{
			if (getScrollPosition() > 0.1f)
			{
				should_show = true;
			}
			else
			{
				should_show = false;
			}
		}
		else if (getScrollPosition() == 1f)
		{
			should_show = false;
		}
		else if (getScrollPosition() < 0.98f)
		{
			should_show = true;
		}
		else
		{
			should_show = false;
		}
	}
}
