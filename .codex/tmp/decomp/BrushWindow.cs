using UnityEngine;

public class BrushWindow : MonoBehaviour
{
	public Transform circles;

	public Transform squares;

	public Transform diamonds;

	public Transform special;

	public BrushSelectButton button_prefab;

	public void Awake()
	{
		foreach (BrushData item in AssetManager.brush_library.list)
		{
			if (item.show_in_brush_window)
			{
				Transform transform = null;
				switch (item.group)
				{
				case BrushGroup.Circles:
					transform = circles;
					break;
				case BrushGroup.Squares:
					transform = squares;
					break;
				case BrushGroup.Diamonds:
					transform = diamonds;
					break;
				case BrushGroup.Special:
					transform = special;
					break;
				default:
					continue;
				}
				Object.Instantiate(button_prefab, transform).setup(item);
			}
		}
	}

	public void selectBrush(GameObject pObject)
	{
		Config.current_brush = pObject.transform.name;
		GetComponent<ScrollWindow>().clickHide();
	}
}
