using System.Collections.Generic;
using UnityEngine;

public class PrintLibrary : MonoBehaviour
{
	private readonly Color _color_0 = Toolbox.makeColor("#FFFFFF");

	private readonly Color _color_1 = Toolbox.makeColor("#CCCCCC");

	private readonly Color _color_2 = Toolbox.makeColor("#7F7F7F");

	private readonly Color _color_3 = Toolbox.makeColor("#000000");

	public List<PrintTemplate> list;

	private readonly Dictionary<string, PrintTemplate> _dict = new Dictionary<string, PrintTemplate>();

	private readonly List<PrintTemplate> _list_quakes = new List<PrintTemplate>();

	private static PrintLibrary _instance;

	private void Awake()
	{
		_instance = this;
		for (int i = 0; i < list.Count; i++)
		{
			PrintTemplate printTemplate = list[i];
			calcSteps(printTemplate);
			_dict.Add(printTemplate.name, printTemplate);
			if (printTemplate.name.Contains("quake"))
			{
				_list_quakes.Add(printTemplate);
				addRotatedQuake(printTemplate, 90);
				addRotatedQuake(printTemplate, 180);
				addRotatedQuake(printTemplate, 360);
				addRotatedQuake(printTemplate, -360);
				addRotatedQuake(printTemplate, -90);
				addRotatedQuake(printTemplate, -180);
				addRotatedQuake(printTemplate, -270);
			}
		}
	}

	private void addRotatedQuake(PrintTemplate pOrigin, int pRotation)
	{
		PrintTemplate printTemplate = new PrintTemplate();
		printTemplate.name = pOrigin.name + "_" + pRotation;
		Texture2D originTexture = Object.Instantiate(pOrigin.graphics);
		printTemplate.graphics = TextureRotator.Rotate(originTexture, pRotation, new Color32(0, 0, 0, 0));
		calcSteps(printTemplate);
		_list_quakes.Add(printTemplate);
	}

	private void calcSteps(PrintTemplate pPrint)
	{
		List<PrintStep> list = new List<PrintStep>();
		int width = pPrint.graphics.width;
		int height = pPrint.graphics.height;
		for (int i = 1; i < width - 1; i++)
		{
			for (int j = 1; j < height - 1; j++)
			{
				Color pixel = pPrint.graphics.GetPixel(i, j);
				if (!(pixel == _color_0))
				{
					PrintStep item = new PrintStep
					{
						x = i - 1 - width / 2,
						y = j - 1 - height / 2,
						action = 1
					};
					list.Add(item);
					if (pixel == _color_2)
					{
						list.Add(item);
					}
					else if (pixel == _color_3)
					{
						list.Add(item);
						list.Add(item);
					}
				}
			}
		}
		pPrint.steps = list.ToArray();
		pPrint.steps_per_tick = (int)((float)pPrint.steps.Length * 0.005f + 1f);
	}

	public static PrintTemplate getTemplate(string pTemplateID)
	{
		return _instance._dict[pTemplateID];
	}

	public static List<PrintTemplate> getQuakes()
	{
		return _instance._list_quakes;
	}
}
