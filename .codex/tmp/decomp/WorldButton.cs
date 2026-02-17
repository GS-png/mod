using UnityEngine;

public class WorldButton : MonoBehaviour
{
	public static WorldButton active_buttons;

	public WorldButton mainButtonObject;

	public WorldButton[] lesser_buttons;

	private Vector3 initial_pos;

	private void Start()
	{
		initial_pos = base.transform.localPosition;
		if (mainButtonObject != null)
		{
			hide();
		}
	}

	public void onClickMain()
	{
		if (active_buttons != null && active_buttons != this)
		{
			active_buttons.hideChildren();
			active_buttons = null;
		}
		if (!lesser_buttons[0].gameObject.activeSelf)
		{
			WorldButton[] array = lesser_buttons;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].activate();
			}
			active_buttons = this;
		}
		else
		{
			hideChildren();
		}
	}

	public void hideChildren()
	{
		WorldButton[] array = lesser_buttons;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].hide();
		}
	}

	public void hide()
	{
		base.gameObject.SetActive(value: false);
		base.transform.localPosition = mainButtonObject.transform.position;
	}

	public void activate()
	{
		base.gameObject.SetActive(value: true);
		base.transform.localPosition = initial_pos;
	}
}
