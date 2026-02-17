using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsViewer : MonoBehaviour
{
	private List<PowerButton> buttons;

	private Transform content;

	private float lastX;

	private float lastY;

	private Canvas canvas;

	private void Start()
	{
		content = base.transform.parent;
		canvas = CanvasMain.instance.canvas_ui;
		buttons = new List<PowerButton>();
		_ = base.transform.childCount;
		for (int i = 0; i < base.transform.childCount; i++)
		{
			GameObject gameObject = base.transform.GetChild(i).gameObject;
			if (gameObject.HasComponent<PowerButton>() && gameObject.activeSelf)
			{
				buttons.Add(gameObject.GetComponent<PowerButton>());
			}
			else if (!gameObject.HasComponent<Image>() || !gameObject.activeSelf)
			{
				Object.Destroy(gameObject);
			}
		}
	}

	private void Update()
	{
		if (lastX == content.position.x && lastY == content.position.y)
		{
			return;
		}
		lastX = content.position.x;
		lastY = content.position.y;
		int num = 0;
		int num2 = 0;
		bool flag = false;
		for (int i = 0; i < buttons.Count; i++)
		{
			PowerButton powerButton = buttons[i];
			if (flag)
			{
				num2++;
				powerButton.gameObject.SetActive(value: false);
				continue;
			}
			num++;
			Vector3[] array = new Vector3[4];
			powerButton.rect_transform.GetWorldCorners(array);
			float num3 = Mathf.Max(array[0].x, array[1].x, array[2].x, array[3].x);
			float num4 = Mathf.Min(array[0].x, array[1].x, array[2].x, array[3].x);
			if (num3 < 0f || num4 > (float)Screen.width)
			{
				powerButton.gameObject.SetActive(value: false);
				if (num4 > (float)Screen.width)
				{
					flag = true;
				}
			}
			else
			{
				powerButton.gameObject.SetActive(value: true);
			}
		}
	}
}
